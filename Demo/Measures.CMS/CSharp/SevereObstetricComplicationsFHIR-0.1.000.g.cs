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
        CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzzzzzzzzzzzk_, true, true);
        object ezzzzzzzzzzzzzzzzzzzzzzzzm_ = context.ResolveParameter("SevereObstetricComplicationsFHIR-0.1.000", "Measurement Period", ezzzzzzzzzzzzzzzzzzzzzzzzl_);

        return (CqlInterval<CqlDateTime>)ezzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ezzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient ezzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SingletonFrom<Patient>(ezzzzzzzzzzzzzzzzzzzzzzzzn_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzp_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ezzzzzzzzzzzzzzzzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> ezzzzzzzzzzzzzzzzzzzzzzzzr_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ezzzzzzzzzzzzzzzzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode ezzzzzzzzzzzzzzzzzzzzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Calculated Gestational Age Greater than or Equal to 20 Weeks")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_20_Weeks(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzu_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzv_(Encounter DeliveryEncounter)
        {
            int? ezzzzzzzzzzzzzzzzzzzzzzzzx_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.GreaterOrEqual(ezzzzzzzzzzzzzzzzzzzzzzzzx_, 20);

            return ezzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzzzzzzzzv_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Estimated Gestational Age Assessment Greater than or Equal to 20 Weeks")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Estimated_Gestational_Age_Assessment_Greater_than_or_Equal_to_20_Weeks(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzz_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzza_(Encounter DeliveryEncounter)
        {
            int? fzzzzzzzzzzzzzzzzzzzzzzzzc_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity fzzzzzzzzzzzzzzzzzzzzzzzzd_ = PCMaternal_5_19_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity fzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(20m, "weeks");
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.GreaterOrEqual(fzzzzzzzzzzzzzzzzzzzzzzzzd_, fzzzzzzzzzzzzzzzzzzzzzzzze_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And((bool?)(fzzzzzzzzzzzzzzzzzzzzzzzzc_ is null), fzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzzzzzzzzzza_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Gestational Age Greater than or Equal to 20 Weeks Based on Coding")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Gestational_Age_Greater_than_or_Equal_to_20_Weeks_Based_on_Coding(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzh_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzi_(Encounter DeliveryEncounter)
        {
            int? fzzzzzzzzzzzzzzzzzzzzzzzzk_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity fzzzzzzzzzzzzzzzzzzzzzzzzl_ = PCMaternal_5_19_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And((bool?)(fzzzzzzzzzzzzzzzzzzzzzzzzk_ is null), (bool?)(fzzzzzzzzzzzzzzzzzzzzzzzzl_ is null));
            IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzn_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, DeliveryEncounter);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzo_(Condition EncounterDiagnosis)
            {
                CodeableConcept fzzzzzzzzzzzzzzzzzzzzzzzzs_ = EncounterDiagnosis?.Code;
                CqlConcept fzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzu_ = this._20_to_42_Plus_Weeks_Gestation(context);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConceptInValueSet(fzzzzzzzzzzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzzzzzzzzzzu_);

                return fzzzzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Delivery Encounters At Greater than or Equal to 20 Weeks Gestation")]
    public IEnumerable<Encounter> Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Delivery_Encounters_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_20_Weeks(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Delivery_Encounters_with_Estimated_Gestational_Age_Assessment_Greater_than_or_Equal_to_20_Weeks(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Delivery_Encounters_with_Gestational_Age_Greater_than_or_Equal_to_20_Weeks_Based_on_Coding(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return gzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("pOAIsNoOrUTD")]
    public IEnumerable<CqlConcept> pOAIsNoOrUTD(CqlContext context, Encounter TheEncounter)
    {
        List<Encounter.DiagnosisComponent> gzzzzzzzzzzzzzzzzzzzzzzzzb_ = TheEncounter?.Diagnosis;
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzc_(Encounter.DiagnosisComponent EncounterDiagnoses)
        {
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzh_(Extension @this)
            {
                string gzzzzzzzzzzzzzzzzzzzzzzzzp_ = @this?.Url;
                FhirString gzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<FhirString>(gzzzzzzzzzzzzzzzzzzzzzzzzp_);
                string gzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToString(context, gzzzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Equal(gzzzzzzzzzzzzzzzzzzzzzzzzr_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                return gzzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Extension> gzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(EncounterDiagnoses is Element
                    ? (EncounterDiagnoses as Element).Extension
                    : default), gzzzzzzzzzzzzzzzzzzzzzzzzh_);
            object gzzzzzzzzzzzzzzzzzzzzzzzzj_(Extension @this)
            {
                DataType gzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Value;

                return gzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<object> gzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Extension, object>(gzzzzzzzzzzzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzzzzzzzzzzzj_);
            object gzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SingletonFrom<object>(gzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlConcept gzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gzzzzzzzzzzzzzzzzzzzzzzzzl_ as CodeableConcept);
            CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Present_on_Admission_is_No_or_Unable_To_Determine(context);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConceptInValueSet(gzzzzzzzzzzzzzzzzzzzzzzzzm_, gzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter.DiagnosisComponent> gzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)gzzzzzzzzzzzzzzzzzzzzzzzzb_, gzzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlConcept gzzzzzzzzzzzzzzzzzzzzzzzze_(Encounter.DiagnosisComponent EncounterDiagnoses)
        {
            ResourceReference gzzzzzzzzzzzzzzzzzzzzzzzzu_ = EncounterDiagnoses?.Condition;
            Condition gzzzzzzzzzzzzzzzzzzzzzzzzv_ = CQMCommon_2_2_000.Instance.getCondition(context, gzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CodeableConcept gzzzzzzzzzzzzzzzzzzzzzzzzw_ = gzzzzzzzzzzzzzzzzzzzzzzzzv_?.Code;
            CqlConcept gzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<CqlConcept> gzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<Encounter.DiagnosisComponent, CqlConcept>(gzzzzzzzzzzzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<CqlConcept> gzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Distinct<CqlConcept>(gzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Severe Obstetric Complications Diagnosis or Procedure Excluding Blood Transfusion")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Severe_Obstetric_Complications_Diagnosis_or_Procedure_Excluding_Blood_Transfusion(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzz_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> hzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.pOAIsNoOrUTD(context, TwentyWeeksPlusEncounter);
            CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConceptsInValueSet(hzzzzzzzzzzzzzzzzzzzzzzzzb_, hzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Severe_Maternal_Morbidity_Procedures(context);
            IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzg_(Procedure SMMProcedures)
            {
                Code<EventStatus> hzzzzzzzzzzzzzzzzzzzzzzzzk_ = SMMProcedures?.StatusElement;
                EventStatus? hzzzzzzzzzzzzzzzzzzzzzzzzl_ = hzzzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
                string hzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<string>(hzzzzzzzzzzzzzzzzzzzzzzzzl_);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Equal(hzzzzzzzzzzzzzzzzzzzzzzzzm_, "completed");
                DataType hzzzzzzzzzzzzzzzzzzzzzzzzo_ = SMMProcedures?.Performed;
                object hzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzs_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzzzzzzzzzzs_, "day");
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzn_, hzzzzzzzzzzzzzzzzzzzzzzzzt_);

                return hzzzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Procedure>(hzzzzzzzzzzzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzzzzzzzzzzzg_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Exists<Procedure>(hzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return hzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return hzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Expiration")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Expiration(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzw_(Encounter TwentyWeeksPlusEncounter)
        {
            Encounter.HospitalizationComponent hzzzzzzzzzzzzzzzzzzzzzzzzy_ = TwentyWeeksPlusEncounter?.Hospitalization;
            CodeableConcept hzzzzzzzzzzzzzzzzzzzzzzzzz_ = hzzzzzzzzzzzzzzzzzzzzzzzzy_?.DischargeDisposition;
            CqlConcept izzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Patient_Expired(context);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConceptInValueSet(izzzzzzzzzzzzzzzzzzzzzzzza_, izzzzzzzzzzzzzzzzzzzzzzzzb_);

            return izzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzzv_, hzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Blood Transfusion")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Blood_Transfusion(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzze_(Encounter TwentyWeeksPlusEncounter)
        {
            CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Blood_Transfusion(context);
            IEnumerable<Procedure> izzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? izzzzzzzzzzzzzzzzzzzzzzzzi_(Procedure BloodTransfusion)
            {
                Code<EventStatus> izzzzzzzzzzzzzzzzzzzzzzzzm_ = BloodTransfusion?.StatusElement;
                EventStatus? izzzzzzzzzzzzzzzzzzzzzzzzn_ = izzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
                string izzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Equal(izzzzzzzzzzzzzzzzzzzzzzzzo_, "completed");
                DataType izzzzzzzzzzzzzzzzzzzzzzzzq_ = BloodTransfusion?.Performed;
                object izzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzu_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzzzzzzzzzzzu_, "day");
                bool? izzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzp_, izzzzzzzzzzzzzzzzzzzzzzzzv_);

                return izzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Procedure> izzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Procedure>(izzzzzzzzzzzzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzzzzzzzzzzzi_);
            Encounter izzzzzzzzzzzzzzzzzzzzzzzzk_(Procedure BloodTransfusion) =>
                TwentyWeeksPlusEncounter;
            IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Procedure, Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzzzzzzzzzzzk_);

            return izzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SelectMany<Encounter, Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzzzzzzzzze_);

        return izzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Severe Obstetric Complications")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Severe_Obstetric_Complications(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Diagnosis_or_Procedure_Excluding_Blood_Transfusion(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Delivery_Encounters_with_Expiration(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Delivery_Encounters_with_Blood_Transfusion(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzz_, jzzzzzzzzzzzzzzzzzzzzzzzza_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Hysterectomy")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Hysterectomy(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzd_(Encounter TwentyWeeksPlusEncounter)
        {
            CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Hysterectomy(context);
            IEnumerable<Procedure> jzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzh_(Procedure Hysterectomy)
            {
                Code<EventStatus> jzzzzzzzzzzzzzzzzzzzzzzzzl_ = Hysterectomy?.StatusElement;
                EventStatus? jzzzzzzzzzzzzzzzzzzzzzzzzm_ = jzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
                string jzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzzzzzzzzzzzm_);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equal(jzzzzzzzzzzzzzzzzzzzzzzzzn_, "completed");
                DataType jzzzzzzzzzzzzzzzzzzzzzzzzp_ = Hysterectomy?.Performed;
                object jzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzt_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzzzzzzzzzzzt_, "day");
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzo_, jzzzzzzzzzzzzzzzzzzzzzzzzu_);

                return jzzzzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Procedure> jzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Procedure>(jzzzzzzzzzzzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzzzzzzzzzzzh_);
            Encounter jzzzzzzzzzzzzzzzzzzzzzzzzj_(Procedure Hysterectomy) =>
                TwentyWeeksPlusEncounter;
            IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Procedure, Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzi_, jzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SelectMany<Encounter, Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzc_, jzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return jzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Cardiac Conversion, Tracheostomy or Ventilation Procedures")]
    public IEnumerable<Procedure> Cardiac_Conversion__Tracheostomy_or_Ventilation_Procedures(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Conversion_of_Cardiac_Rhythm(context);
        IEnumerable<Procedure> jzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Tracheostomy(context);
        IEnumerable<Procedure> jzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Procedure>(jzzzzzzzzzzzzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzzzzzzzzzzzzz_);
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Ventilation(context);
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Procedure>(kzzzzzzzzzzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Cardiac Conversion, Tracheostomy or Ventilation Procedures")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Cardiac_Conversion__Tracheostomy_or_Ventilation_Procedures(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzf_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Cardiac_Conversion__Tracheostomy_or_Ventilation_Procedures(context);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzi_(Procedure ConvTrachVentProcedures)
            {
                Code<EventStatus> kzzzzzzzzzzzzzzzzzzzzzzzzm_ = ConvTrachVentProcedures?.StatusElement;
                EventStatus? kzzzzzzzzzzzzzzzzzzzzzzzzn_ = kzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
                string kzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzzzzzzzzzo_, "completed");
                DataType kzzzzzzzzzzzzzzzzzzzzzzzzq_ = ConvTrachVentProcedures?.Performed;
                object kzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzu_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzt_, kzzzzzzzzzzzzzzzzzzzzzzzzu_, "day");
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzzzzzzzzzzzv_);

                return kzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Procedure>(kzzzzzzzzzzzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzzzzzzzzzzzi_);
            Encounter kzzzzzzzzzzzzzzzzzzzzzzzzk_(Procedure ConvTrachVentProcedures) =>
                TwentyWeeksPlusEncounter;
            IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Procedure, Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SelectMany<Encounter, Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("SOC with Hysterectomy or Blood Transfusion with Placenta Increta or Placenta Percreta Without Additional SOC")]
    public IEnumerable<Encounter> SOC_with_Hysterectomy_or_Blood_Transfusion_with_Placenta_Increta_or_Placenta_Percreta_Without_Additional_SOC(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzy_(Encounter SOCEncounter)
        {
            IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzzzzi_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, SOCEncounter);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzj_(Condition EncounterDiagnosis)
            {
                CodeableConcept lzzzzzzzzzzzzzzzzzzzzzzzzs_ = EncounterDiagnosis?.Code;
                CqlConcept lzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Placenta_Increta_or_Percreta(context);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConceptInValueSet(lzzzzzzzzzzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzzzzzzzzzzu_);

                return lzzzzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Condition>(lzzzzzzzzzzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Condition>(lzzzzzzzzzzzzzzzzzzzzzzzzk_);
            IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Delivery_Encounters_with_Blood_Transfusion(context);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzm_);
            IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Delivery_Encounters_with_Hysterectomy(context);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Or(lzzzzzzzzzzzzzzzzzzzzzzzzn_, lzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzx_, kzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzb_(Encounter SOCEncounter)
        {
            IEnumerable<CqlConcept> lzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.pOAIsNoOrUTD(context, SOCEncounter);
            CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConceptsInValueSet(lzzzzzzzzzzzzzzzzzzzzzzzzw_, lzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Delivery_Encounters_with_Cardiac_Conversion__Tracheostomy_or_Ventilation_Procedures(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzc_, lzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Delivery_Encounters_with_Expiration(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzze_, lzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Except<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Delivery Encounters with Severe Obstetric Complication Diagnosis")]
    public IEnumerable<Encounter> SDE_Delivery_Encounters_with_Severe_Obstetric_Complication_Diagnosis(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzza_ = this.SOC_with_Hysterectomy_or_Blood_Transfusion_with_Placenta_Increta_or_Placenta_Percreta_Without_Additional_SOC(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Except<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzc_(Encounter Encounter)
        {
            IEnumerable<CqlConcept> mzzzzzzzzzzzzzzzzzzzzzzzze_ = this.pOAIsNoOrUTD(context, Encounter);
            CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConceptsInValueSet(mzzzzzzzzzzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Delivery Encounters with Severe Obstetric Complication Procedures")]
    public IEnumerable<Encounter> SDE_Delivery_Encounters_with_Severe_Obstetric_Complication_Procedures(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.SOC_with_Hysterectomy_or_Blood_Transfusion_with_Placenta_Increta_or_Placenta_Percreta_Without_Additional_SOC(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Except<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzk_(Encounter Encounter)
        {
            CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Severe_Maternal_Morbidity_Procedures(context);
            IEnumerable<Procedure> mzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Blood_Transfusion(context);
            IEnumerable<Procedure> mzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> mzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Procedure>(mzzzzzzzzzzzzzzzzzzzzzzzzn_, mzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzr_(Procedure SMMProcedures)
            {
                Code<EventStatus> mzzzzzzzzzzzzzzzzzzzzzzzzu_ = SMMProcedures?.StatusElement;
                EventStatus? mzzzzzzzzzzzzzzzzzzzzzzzzv_ = mzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
                string mzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(mzzzzzzzzzzzzzzzzzzzzzzzzv_);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Equal(mzzzzzzzzzzzzzzzzzzzzzzzzw_, "completed");
                DataType mzzzzzzzzzzzzzzzzzzzzzzzzy_ = SMMProcedures?.Performed;
                object mzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzc_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, Encounter);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzb_, nzzzzzzzzzzzzzzzzzzzzzzzzc_, "day");
                bool? nzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzx_, nzzzzzzzzzzzzzzzzzzzzzzzzd_);

                return nzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Procedure> mzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Procedure>(mzzzzzzzzzzzzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Procedure>(mzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("sOCDxCategory")]
    public string sOCDxCategory(CqlContext context, CqlConcept Dx)
    {
        string nzzzzzzzzzzzzzzzzzzzzzzzzf_()
        {
            bool nzzzzzzzzzzzzzzzzzzzzzzzzg_()
            {
                CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Acute_Heart_Failure(context);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConceptInValueSet(Dx, nzzzzzzzzzzzzzzzzzzzzzzzzx_);

                return nzzzzzzzzzzzzzzzzzzzzzzzzy_ ?? false;
            };
            bool nzzzzzzzzzzzzzzzzzzzzzzzzh_()
            {
                CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Acute_Myocardial_Infarction(context);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConceptInValueSet(Dx, nzzzzzzzzzzzzzzzzzzzzzzzzz_);

                return ozzzzzzzzzzzzzzzzzzzzzzzza_ ?? false;
            };
            bool nzzzzzzzzzzzzzzzzzzzzzzzzi_()
            {
                CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Acute_Renal_Failure(context);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConceptInValueSet(Dx, ozzzzzzzzzzzzzzzzzzzzzzzzb_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzc_ ?? false;
            };
            bool nzzzzzzzzzzzzzzzzzzzzzzzzj_()
            {
                CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Acute_Respiratory_Distress_Syndrome(context);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConceptInValueSet(Dx, ozzzzzzzzzzzzzzzzzzzzzzzzd_);

                return ozzzzzzzzzzzzzzzzzzzzzzzze_ ?? false;
            };
            bool nzzzzzzzzzzzzzzzzzzzzzzzzk_()
            {
                CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Air_and_Thrombotic_Embolism(context);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConceptInValueSet(Dx, ozzzzzzzzzzzzzzzzzzzzzzzzf_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzg_ ?? false;
            };
            bool nzzzzzzzzzzzzzzzzzzzzzzzzl_()
            {
                CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Amniotic_Fluid_Embolism(context);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConceptInValueSet(Dx, ozzzzzzzzzzzzzzzzzzzzzzzzh_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzi_ ?? false;
            };
            bool nzzzzzzzzzzzzzzzzzzzzzzzzm_()
            {
                CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Aortic_Aneurysm(context);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConceptInValueSet(Dx, ozzzzzzzzzzzzzzzzzzzzzzzzj_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzk_ ?? false;
            };
            bool nzzzzzzzzzzzzzzzzzzzzzzzzn_()
            {
                CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Cardiac_Arrest_Ventricular_Fibrillation(context);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConceptInValueSet(Dx, ozzzzzzzzzzzzzzzzzzzzzzzzl_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzm_ ?? false;
            };
            bool nzzzzzzzzzzzzzzzzzzzzzzzzo_()
            {
                CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Disseminated_Intravascular_Coagulation(context);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConceptInValueSet(Dx, ozzzzzzzzzzzzzzzzzzzzzzzzn_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzo_ ?? false;
            };
            bool nzzzzzzzzzzzzzzzzzzzzzzzzp_()
            {
                CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Eclampsia(context);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConceptInValueSet(Dx, ozzzzzzzzzzzzzzzzzzzzzzzzp_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzq_ ?? false;
            };
            bool nzzzzzzzzzzzzzzzzzzzzzzzzq_()
            {
                CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Heart_Failure_Cardiac_Arrest_Related_to_Procedure_or_Surgery(context);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConceptInValueSet(Dx, ozzzzzzzzzzzzzzzzzzzzzzzzr_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzs_ ?? false;
            };
            bool nzzzzzzzzzzzzzzzzzzzzzzzzr_()
            {
                CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Puerperal_Cerebrovascular_Disorder(context);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConceptInValueSet(Dx, ozzzzzzzzzzzzzzzzzzzzzzzzt_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzu_ ?? false;
            };
            bool nzzzzzzzzzzzzzzzzzzzzzzzzs_()
            {
                CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Pulmonary_Edema(context);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConceptInValueSet(Dx, ozzzzzzzzzzzzzzzzzzzzzzzzv_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzw_ ?? false;
            };
            bool nzzzzzzzzzzzzzzzzzzzzzzzzt_()
            {
                CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Sepsis(context);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConceptInValueSet(Dx, ozzzzzzzzzzzzzzzzzzzzzzzzx_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzy_ ?? false;
            };
            bool nzzzzzzzzzzzzzzzzzzzzzzzzu_()
            {
                CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Severe_Anesthesia_Complications(context);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConceptInValueSet(Dx, ozzzzzzzzzzzzzzzzzzzzzzzzz_);

                return pzzzzzzzzzzzzzzzzzzzzzzzza_ ?? false;
            };
            bool nzzzzzzzzzzzzzzzzzzzzzzzzv_()
            {
                CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Shock(context);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConceptInValueSet(Dx, pzzzzzzzzzzzzzzzzzzzzzzzzb_);

                return pzzzzzzzzzzzzzzzzzzzzzzzzc_ ?? false;
            };
            bool nzzzzzzzzzzzzzzzzzzzzzzzzw_()
            {
                CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Sickle_Cell_Disease_with_Crisis(context);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConceptInValueSet(Dx, pzzzzzzzzzzzzzzzzzzzzzzzzd_);

                return pzzzzzzzzzzzzzzzzzzzzzzzze_ ?? false;
            };
            if (nzzzzzzzzzzzzzzzzzzzzzzzzg_())
            {
                return "Acute Heart Failure";
            }
            else if (nzzzzzzzzzzzzzzzzzzzzzzzzh_())
            {
                return "Acute Myocardial Infarction";
            }
            else if (nzzzzzzzzzzzzzzzzzzzzzzzzi_())
            {
                return "Acute Renal Failure";
            }
            else if (nzzzzzzzzzzzzzzzzzzzzzzzzj_())
            {
                return "Acute Respiratory Distress Syndrome";
            }
            else if (nzzzzzzzzzzzzzzzzzzzzzzzzk_())
            {
                return "Air and Thrombotic Embolism";
            }
            else if (nzzzzzzzzzzzzzzzzzzzzzzzzl_())
            {
                return "Amniotic Fluid Embolism";
            }
            else if (nzzzzzzzzzzzzzzzzzzzzzzzzm_())
            {
                return "Aortic Aneurysm";
            }
            else if (nzzzzzzzzzzzzzzzzzzzzzzzzn_())
            {
                return "Cardiac Arrest Ventricular Fibrillation";
            }
            else if (nzzzzzzzzzzzzzzzzzzzzzzzzo_())
            {
                return "Disseminated Intravascular Coagulation";
            }
            else if (nzzzzzzzzzzzzzzzzzzzzzzzzp_())
            {
                return "Eclampsia";
            }
            else if (nzzzzzzzzzzzzzzzzzzzzzzzzq_())
            {
                return "Heart Failure Cardiac Arrest Related to Procedure or Surgery";
            }
            else if (nzzzzzzzzzzzzzzzzzzzzzzzzr_())
            {
                return "Puerperal Cerebrovascular Disorder";
            }
            else if (nzzzzzzzzzzzzzzzzzzzzzzzzs_())
            {
                return "Pulmonary Edema";
            }
            else if (nzzzzzzzzzzzzzzzzzzzzzzzzt_())
            {
                return "Sepsis";
            }
            else if (nzzzzzzzzzzzzzzzzzzzzzzzzu_())
            {
                return "Severe Anesthesia Complications";
            }
            else if (nzzzzzzzzzzzzzzzzzzzzzzzzv_())
            {
                return "Shock";
            }
            else if (nzzzzzzzzzzzzzzzzzzzzzzzzw_())
            {
                return "Sickle Cell Disease with Crisis";
            }
            else
            {
                return default;
            }
        };

        return nzzzzzzzzzzzzzzzzzzzzzzzzf_();
    }


    [CqlExpressionDefinition("SDE SOC Diagnoses Detail")]
    public IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)?> SDE_SOC_Diagnoses_Detail(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.SDE_Delivery_Encounters_with_Severe_Obstetric_Complication_Diagnosis(context);
        (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)? pzzzzzzzzzzzzzzzzzzzzzzzzg_(Encounter Encounter)
        {
            Id pzzzzzzzzzzzzzzzzzzzzzzzzj_ = Encounter?.IdElement;
            string pzzzzzzzzzzzzzzzzzzzzzzzzk_ = pzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
            IEnumerable<CqlConcept> pzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.pOAIsNoOrUTD(context, Encounter);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzm_(CqlConcept C)
            {
                CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConceptInValueSet(C, pzzzzzzzzzzzzzzzzzzzzzzzzs_);

                return pzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<CqlConcept> pzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<CqlConcept>(pzzzzzzzzzzzzzzzzzzzzzzzzl_, pzzzzzzzzzzzzzzzzzzzzzzzzm_);
            (CqlTupleMetadata, CqlConcept code, string SOCDxCategory)? pzzzzzzzzzzzzzzzzzzzzzzzzo_(CqlConcept C)
            {
                string pzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.sOCDxCategory(context, C);
                (CqlTupleMetadata, CqlConcept code, string SOCDxCategory)? pzzzzzzzzzzzzzzzzzzzzzzzzv_ = (CqlTupleMetadata_FRbAiSWEhRfKaLTXPVgFXYZAE, C, pzzzzzzzzzzzzzzzzzzzzzzzzu_);

                return pzzzzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> pzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<CqlConcept, (CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?>(pzzzzzzzzzzzzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzzzzzzzzzzzzo_);
            IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> pzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?>(pzzzzzzzzzzzzzzzzzzzzzzzzp_);
            (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)? pzzzzzzzzzzzzzzzzzzzzzzzzr_ = (CqlTupleMetadata_RBQLXdQIRBbBEHDfOgQjdBMH, pzzzzzzzzzzzzzzzzzzzzzzzzk_, pzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)?> pzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)?>(pzzzzzzzzzzzzzzzzzzzzzzzzf_, pzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)?> pzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)?>(pzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("sOCProcedures")]
    public IEnumerable<Procedure> sOCProcedures(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Severe_Maternal_Morbidity_Procedures(context);
        IEnumerable<Procedure> pzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Blood_Transfusion(context);
        IEnumerable<Procedure> pzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> qzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Procedure>(pzzzzzzzzzzzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzb_(Procedure SMMProcedures)
        {
            Code<EventStatus> qzzzzzzzzzzzzzzzzzzzzzzzzd_ = SMMProcedures?.StatusElement;
            EventStatus? qzzzzzzzzzzzzzzzzzzzzzzzze_ = qzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
            string qzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzzzzzzzzze_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzzzzzzzf_, "completed");
            DataType qzzzzzzzzzzzzzzzzzzzzzzzzh_ = SMMProcedures?.Performed;
            object qzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzl_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzzzzzzzzzzzl_, "day");
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Procedure> qzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Procedure>(qzzzzzzzzzzzzzzzzzzzzzzzza_, qzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("sOCProcedureCategory")]
    public string sOCProcedureCategory(CqlContext context, Procedure TheProcedure)
    {
        string qzzzzzzzzzzzzzzzzzzzzzzzzo_()
        {
            bool qzzzzzzzzzzzzzzzzzzzzzzzzp_()
            {
                CodeableConcept qzzzzzzzzzzzzzzzzzzzzzzzzu_ = TheProcedure?.Code;
                CqlConcept qzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, qzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Blood_Transfusion(context);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(qzzzzzzzzzzzzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzzzzzzzzzzzzw_);

                return qzzzzzzzzzzzzzzzzzzzzzzzzx_ ?? false;
            };
            bool qzzzzzzzzzzzzzzzzzzzzzzzzq_()
            {
                CodeableConcept qzzzzzzzzzzzzzzzzzzzzzzzzy_ = TheProcedure?.Code;
                CqlConcept qzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, qzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Conversion_of_Cardiac_Rhythm(context);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConceptInValueSet(qzzzzzzzzzzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzzzzzzzzzza_);

                return rzzzzzzzzzzzzzzzzzzzzzzzzb_ ?? false;
            };
            bool qzzzzzzzzzzzzzzzzzzzzzzzzr_()
            {
                CodeableConcept rzzzzzzzzzzzzzzzzzzzzzzzzc_ = TheProcedure?.Code;
                CqlConcept rzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, rzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Hysterectomy(context);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConceptInValueSet(rzzzzzzzzzzzzzzzzzzzzzzzzd_, rzzzzzzzzzzzzzzzzzzzzzzzze_);

                return rzzzzzzzzzzzzzzzzzzzzzzzzf_ ?? false;
            };
            bool qzzzzzzzzzzzzzzzzzzzzzzzzs_()
            {
                CodeableConcept rzzzzzzzzzzzzzzzzzzzzzzzzg_ = TheProcedure?.Code;
                CqlConcept rzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, rzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Tracheostomy(context);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConceptInValueSet(rzzzzzzzzzzzzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzzzzzzzzzzzzi_);

                return rzzzzzzzzzzzzzzzzzzzzzzzzj_ ?? false;
            };
            bool qzzzzzzzzzzzzzzzzzzzzzzzzt_()
            {
                CodeableConcept rzzzzzzzzzzzzzzzzzzzzzzzzk_ = TheProcedure?.Code;
                CqlConcept rzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, rzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Ventilation(context);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConceptInValueSet(rzzzzzzzzzzzzzzzzzzzzzzzzl_, rzzzzzzzzzzzzzzzzzzzzzzzzm_);

                return rzzzzzzzzzzzzzzzzzzzzzzzzn_ ?? false;
            };
            if (qzzzzzzzzzzzzzzzzzzzzzzzzp_())
            {
                return "Blood Transfusion";
            }
            else if (qzzzzzzzzzzzzzzzzzzzzzzzzq_())
            {
                return "Conversion of cardiac rhythm";
            }
            else if (qzzzzzzzzzzzzzzzzzzzzzzzzr_())
            {
                return "Hysterectomy";
            }
            else if (qzzzzzzzzzzzzzzzzzzzzzzzzs_())
            {
                return "Tracheostomy";
            }
            else if (qzzzzzzzzzzzzzzzzzzzzzzzzt_())
            {
                return "Ventilation";
            }
            else
            {
                return default;
            }
        };

        return qzzzzzzzzzzzzzzzzzzzzzzzzo_();
    }


    [CqlExpressionDefinition("SDE SOC Procedure Detail")]
    public IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?> SDE_SOC_Procedure_Detail(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.SDE_Delivery_Encounters_with_Severe_Obstetric_Complication_Procedures(context);
        (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)? rzzzzzzzzzzzzzzzzzzzzzzzzp_(Encounter Encounter)
        {
            Id rzzzzzzzzzzzzzzzzzzzzzzzzs_ = Encounter?.IdElement;
            string rzzzzzzzzzzzzzzzzzzzzzzzzt_ = rzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
            IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.sOCProcedures(context, Encounter);
            (CqlTupleMetadata, Procedure code, string SOCProcedureCategory)? rzzzzzzzzzzzzzzzzzzzzzzzzv_(Procedure P)
            {
                string rzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.sOCProcedureCategory(context, P);
                (CqlTupleMetadata, Procedure code, string SOCProcedureCategory)? szzzzzzzzzzzzzzzzzzzzzzzza_ = (CqlTupleMetadata_FNaSKPNeFZXSNMfSCYPJLLGSR, P, rzzzzzzzzzzzzzzzzzzzzzzzzz_);

                return szzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> rzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<Procedure, (CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?>(rzzzzzzzzzzzzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzzzzzzzzzzzzv_);
            IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> rzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Distinct<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?>(rzzzzzzzzzzzzzzzzzzzzzzzzw_);
            (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)? rzzzzzzzzzzzzzzzzzzzzzzzzy_ = (CqlTupleMetadata_DbihhAfJfGSKOIcQDBMEMigFK, rzzzzzzzzzzzzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return rzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?> rzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?>(rzzzzzzzzzzzzzzzzzzzzzzzzo_, rzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?> rzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Distinct<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?>(rzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications(context);

        return szzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Delivery Encounters with COVID and Respiratory Condition or Procedure")]
    public IEnumerable<Encounter> Delivery_Encounters_with_COVID_and_Respiratory_Condition_or_Procedure(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzd_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzf_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, TwentyWeeksPlusEncounter);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzg_(Condition EncounterDiagnosis)
            {
                CodeableConcept szzzzzzzzzzzzzzzzzzzzzzzzu_ = EncounterDiagnosis?.Code;
                CqlConcept szzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, szzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzw_ = this.COVID_19_Confirmed(context);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(szzzzzzzzzzzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzzzzzzzzzzw_);

                return szzzzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Condition>(szzzzzzzzzzzzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzzzzzzzzzzzg_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Exists<Condition>(szzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzk_(Condition EncounterDiagnosis)
            {
                CodeableConcept szzzzzzzzzzzzzzzzzzzzzzzzy_ = EncounterDiagnosis?.Code;
                CqlConcept szzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, szzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Respiratory_Conditions_Related_to_COVID_19(context);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConceptInValueSet(szzzzzzzzzzzzzzzzzzzzzzzzz_, tzzzzzzzzzzzzzzzzzzzzzzzza_);

                return tzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Condition>(szzzzzzzzzzzzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Condition>(szzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Respiratory_Support_Procedures_Related_to_COVID_19(context);
            IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? szzzzzzzzzzzzzzzzzzzzzzzzp_(Procedure COVIDRespiratoryProcedure)
            {
                Code<EventStatus> tzzzzzzzzzzzzzzzzzzzzzzzzc_ = COVIDRespiratoryProcedure?.StatusElement;
                EventStatus? tzzzzzzzzzzzzzzzzzzzzzzzzd_ = tzzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
                string tzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<string>(tzzzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Equal(tzzzzzzzzzzzzzzzzzzzzzzzze_, "completed");
                DataType tzzzzzzzzzzzzzzzzzzzzzzzzg_ = COVIDRespiratoryProcedure?.Performed;
                object tzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzk_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzj_, tzzzzzzzzzzzzzzzzzzzzzzzzk_, "day");
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzzzzzzzzzl_);

                return tzzzzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Procedure>(szzzzzzzzzzzzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<Procedure>(szzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzzzzzzm_, szzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzzzzzzzzzzzs_);

            return szzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(szzzzzzzzzzzzzzzzzzzzzzzzc_, szzzzzzzzzzzzzzzzzzzzzzzzd_);

        return szzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public IEnumerable<Encounter> Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Delivery_Encounters_with_COVID_and_Respiratory_Condition_or_Procedure(context);

        return tzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Stratification Encounter")]
    public IEnumerable<Encounter> Stratification_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Numerator(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Denominator_Exclusion(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Except<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Severe Obstetric Complications Excluding Blood Transfusions")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Diagnosis_or_Procedure_Excluding_Blood_Transfusion(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Delivery_Encounters_with_Expiration(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Stratum 1")]
    public IEnumerable<Encounter> Stratum_1(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Stratification_Encounter(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Intersect<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzu_, tzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("SDE Variable Calculated Gestational Age")]
    public IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> SDE_Variable_Calculated_Gestational_Age(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> tzzzzzzzzzzzzzzzzzzzzzzzzx_ = PCMaternal_5_19_000.Instance.Variable_Calculated_Gestational_Age(context);

        return tzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);

        return tzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Severe Obstetric Complications Excluding Blood Transfusions Only")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions_Only(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Intersect<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzz_, uzzzzzzzzzzzzzzzzzzzzzzzza_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SOC Excluding Blood Transfusions Only with Hysterectomy or Blood Transfusion with Placenta Increta or Placenta Percreta Without Additional SOC")]
    public IEnumerable<Encounter> SOC_Excluding_Blood_Transfusions_Only_with_Hysterectomy_or_Blood_Transfusion_with_Placenta_Increta_or_Placenta_Percreta_Without_Additional_SOC(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions_Only(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzd_(Encounter SOCExcludingTransfusion)
        {
            IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzn_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, SOCExcludingTransfusion);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzo_(Condition EncounterDiagnoses)
            {
                CodeableConcept uzzzzzzzzzzzzzzzzzzzzzzzzx_ = EncounterDiagnoses?.Code;
                CqlConcept uzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Placenta_Increta_or_Percreta(context);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConceptInValueSet(uzzzzzzzzzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzzzzzzzzzz_);

                return vzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Condition>(uzzzzzzzzzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Condition>(uzzzzzzzzzzzzzzzzzzzzzzzzp_);
            IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Delivery_Encounters_with_Blood_Transfusion(context);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzr_);
            IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Delivery_Encounters_with_Hysterectomy(context);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(uzzzzzzzzzzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzq_, uzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzg_(Encounter SOCExcludingTransfusion)
        {
            IEnumerable<CqlConcept> vzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.pOAIsNoOrUTD(context, SOCExcludingTransfusion);
            CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConceptsInValueSet(vzzzzzzzzzzzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Delivery_Encounters_with_Cardiac_Conversion__Tracheostomy_or_Ventilation_Procedures(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzh_, uzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Delivery_Encounters_with_Expiration(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Except<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("pOAIsYesOrExempt")]
    public IEnumerable<CqlConcept> pOAIsYesOrExempt(CqlContext context, Encounter TheEncounter)
    {
        List<Encounter.DiagnosisComponent> vzzzzzzzzzzzzzzzzzzzzzzzze_ = TheEncounter?.Diagnosis;
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzf_(Encounter.DiagnosisComponent EncounterDiagnoses)
        {
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzk_(Extension @this)
            {
                string vzzzzzzzzzzzzzzzzzzzzzzzzs_ = @this?.Url;
                FhirString vzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<FhirString>(vzzzzzzzzzzzzzzzzzzzzzzzzs_);
                string vzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToString(context, vzzzzzzzzzzzzzzzzzzzzzzzzt_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equal(vzzzzzzzzzzzzzzzzzzzzzzzzu_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                return vzzzzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Extension> vzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(EncounterDiagnoses is Element
                    ? (EncounterDiagnoses as Element).Extension
                    : default), vzzzzzzzzzzzzzzzzzzzzzzzzk_);
            object vzzzzzzzzzzzzzzzzzzzzzzzzm_(Extension @this)
            {
                DataType vzzzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.Value;

                return vzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<object> vzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Extension, object>(vzzzzzzzzzzzzzzzzzzzzzzzzl_, vzzzzzzzzzzzzzzzzzzzzzzzzm_);
            object vzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SingletonFrom<object>(vzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlConcept vzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzzzzzzzzzzzzzzzzzzzzo_ as CodeableConcept);
            CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConceptInValueSet(vzzzzzzzzzzzzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter.DiagnosisComponent> vzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)vzzzzzzzzzzzzzzzzzzzzzzzze_, vzzzzzzzzzzzzzzzzzzzzzzzzf_);
        CqlConcept vzzzzzzzzzzzzzzzzzzzzzzzzh_(Encounter.DiagnosisComponent EncounterDiagnoses)
        {
            ResourceReference vzzzzzzzzzzzzzzzzzzzzzzzzx_ = EncounterDiagnoses?.Condition;
            Condition vzzzzzzzzzzzzzzzzzzzzzzzzy_ = CQMCommon_2_2_000.Instance.getCondition(context, vzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CodeableConcept vzzzzzzzzzzzzzzzzzzzzzzzzz_ = vzzzzzzzzzzzzzzzzzzzzzzzzy_?.Code;
            CqlConcept wzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return wzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<CqlConcept> vzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<Encounter.DiagnosisComponent, CqlConcept>(vzzzzzzzzzzzzzzzzzzzzzzzzg_, vzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<CqlConcept> vzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Distinct<CqlConcept>(vzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Risk Variable Anemia")]
    public IEnumerable<Encounter> Risk_Variable_Anemia(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzc_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> wzzzzzzzzzzzzzzzzzzzzzzzze_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Anemia(context);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConceptsInValueSet(wzzzzzzzzzzzzzzzzzzzzzzzze_, wzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzb_, wzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Risk Variable Asthma")]
    public IEnumerable<Encounter> Risk_Variable_Asthma(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzi_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> wzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Acute_or_Persistent_Asthma(context);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConceptsInValueSet(wzzzzzzzzzzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzh_, wzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Risk Variable Autoimmune Disease")]
    public IEnumerable<Encounter> Risk_Variable_Autoimmune_Disease(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzo_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> wzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Autoimmune_Disease(context);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConceptsInValueSet(wzzzzzzzzzzzzzzzzzzzzzzzzq_, wzzzzzzzzzzzzzzzzzzzzzzzzr_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzn_, wzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Risk Variable Bariatric Surgery")]
    public IEnumerable<Encounter> Risk_Variable_Bariatric_Surgery(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzu_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> wzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Bariatric_Surgery(context);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConceptsInValueSet(wzzzzzzzzzzzzzzzzzzzzzzzzw_, wzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Risk Variable Bleeding Disorder")]
    public IEnumerable<Encounter> Risk_Variable_Bleeding_Disorder(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzza_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> xzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Bleeding_Disorder(context);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConceptsInValueSet(xzzzzzzzzzzzzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzzzzzzzzzzzzd_);

            return xzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzz_, xzzzzzzzzzzzzzzzzzzzzzzzza_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Risk Variable Morbid Obesity")]
    public IEnumerable<Encounter> Risk_Variable_Morbid_Obesity(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzg_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> xzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Morbid_or_Severe_Obesity(context);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConceptsInValueSet(xzzzzzzzzzzzzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Risk Variable Cardiac Disease")]
    public IEnumerable<Encounter> Risk_Variable_Cardiac_Disease(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzm_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> xzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Cardiac_Disease(context);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConceptsInValueSet(xzzzzzzzzzzzzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Risk Variable Economic Housing Instability")]
    public IEnumerable<Encounter> Risk_Variable_Economic_Housing_Instability(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzs_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> xzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Economic_Housing_Instability(context);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConceptsInValueSet(xzzzzzzzzzzzzzzzzzzzzzzzzu_, xzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Risk Variable Gastrointestinal Disease")]
    public IEnumerable<Encounter> Risk_Variable_Gastrointestinal_Disease(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzy_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> yzzzzzzzzzzzzzzzzzzzzzzzza_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Gastrointestinal_Disease(context);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConceptsInValueSet(yzzzzzzzzzzzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzzzzzzzzzzzb_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzx_, xzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Risk Variable Gestational Diabetes")]
    public IEnumerable<Encounter> Risk_Variable_Gestational_Diabetes(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzze_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> yzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Gestational_Diabetes(context);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConceptsInValueSet(yzzzzzzzzzzzzzzzzzzzzzzzzg_, yzzzzzzzzzzzzzzzzzzzzzzzzh_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzzzzzzzzzzze_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Risk Variable HIV")]
    public IEnumerable<Encounter> Risk_Variable_HIV(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzk_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> yzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.HIV_in_Pregnancy_Childbirth_and_Puerperium(context);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConceptsInValueSet(yzzzzzzzzzzzzzzzzzzzzzzzzm_, yzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Risk Variable Hypertension")]
    public IEnumerable<Encounter> Risk_Variable_Hypertension(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzq_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> yzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Hypertension(context);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConceptsInValueSet(yzzzzzzzzzzzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Risk Variable Long Term Anticoagulant Use")]
    public IEnumerable<Encounter> Risk_Variable_Long_Term_Anticoagulant_Use(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzw_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> yzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Long_Term_Anticoagulant_Use(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConceptsInValueSet(yzzzzzzzzzzzzzzzzzzzzzzzzy_, yzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return zzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Risk Variable Maternal Age")]
    public IEnumerable<IEnumerable<object>> Risk_Variable_Maternal_Age(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        IEnumerable<object> zzzzzzzzzzzzzzzzzzzzzzzzzc_(Encounter TwentyWeeksPlusEncounter)
        {
            Patient zzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Patient(context);
            Date zzzzzzzzzzzzzzzzzzzzzzzzzg_ = zzzzzzzzzzzzzzzzzzzzzzzzzf_?.BirthDateElement;
            string zzzzzzzzzzzzzzzzzzzzzzzzzh_ = zzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConvertStringToDate(zzzzzzzzzzzzzzzzzzzzzzzzzh_);
            Period zzzzzzzzzzzzzzzzzzzzzzzzzj_ = TwentyWeeksPlusEncounter?.Period;
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzzzzzzzzzl_);
            int? zzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.CalculateAgeAt(zzzzzzzzzzzzzzzzzzzzzzzzzi_, zzzzzzzzzzzzzzzzzzzzzzzzzm_, "year");
            object[] zzzzzzzzzzzzzzzzzzzzzzzzzo_ = [
                TwentyWeeksPlusEncounter,
zzzzzzzzzzzzzzzzzzzzzzzzzn_ ?? default(int),
            ];

            return zzzzzzzzzzzzzzzzzzzzzzzzzo_ as IEnumerable<object>;
        };
        IEnumerable<IEnumerable<object>> zzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<Encounter, IEnumerable<object>>(zzzzzzzzzzzzzzzzzzzzzzzzzb_, zzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<IEnumerable<object>> zzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Distinct<IEnumerable<object>>(zzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return zzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Risk Variable Mental Health Disorder")]
    public IEnumerable<Encounter> Risk_Variable_Mental_Health_Disorder(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzq_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> zzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Mental_Health_Disorder(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConceptsInValueSet(zzzzzzzzzzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzp_, zzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Risk Variable Multiple Pregnancy")]
    public IEnumerable<Encounter> Risk_Variable_Multiple_Pregnancy(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzw_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> zzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Multiple_Pregnancy(context);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConceptsInValueSet(zzzzzzzzzzzzzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return azzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Risk Variable Neuromuscular")]
    public IEnumerable<Encounter> Risk_Variable_Neuromuscular(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzc_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> azzzzzzzzzzzzzzzzzzzzzzzzze_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Neuromuscular_Disease(context);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConceptsInValueSet(azzzzzzzzzzzzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzb_, azzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Risk Variable Obstetrical VTE")]
    public IEnumerable<Encounter> Risk_Variable_Obstetrical_VTE(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzi_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> azzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Venous_Thromboembolism_in_Pregnancy(context);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConceptsInValueSet(azzzzzzzzzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzh_, azzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Risk Variable Placenta Previa")]
    public IEnumerable<Encounter> Risk_Variable_Placenta_Previa(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzo_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> azzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Placenta_Previa(context);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConceptsInValueSet(azzzzzzzzzzzzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzzzzzzzzzzzr_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Risk Variable Placental Abruption")]
    public IEnumerable<Encounter> Risk_Variable_Placental_Abruption(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzu_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> azzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Placental_Abruption(context);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConceptsInValueSet(azzzzzzzzzzzzzzzzzzzzzzzzzw_, azzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Risk Variable Placental Accreta Spectrum")]
    public IEnumerable<Encounter> Risk_Variable_Placental_Accreta_Spectrum(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzza_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> bzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Placenta_Accreta(context);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConceptsInValueSet(bzzzzzzzzzzzzzzzzzzzzzzzzzc_, bzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Placenta_Increta_or_Percreta(context);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConceptsInValueSet(bzzzzzzzzzzzzzzzzzzzzzzzzzc_, bzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzzzzzzzzze_, bzzzzzzzzzzzzzzzzzzzzzzzzzh_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzz_, bzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Risk Variable Preexisting Diabetes")]
    public IEnumerable<Encounter> Risk_Variable_Preexisting_Diabetes(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzk_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> bzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Preexisting_Diabetes(context);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConceptsInValueSet(bzzzzzzzzzzzzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Risk Variable Previous Cesarean")]
    public IEnumerable<Encounter> Risk_Variable_Previous_Cesarean(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzq_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> bzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Previous_Cesarean(context);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConceptsInValueSet(bzzzzzzzzzzzzzzzzzzzzzzzzzs_, bzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Risk Variable Pulmonary Hypertension")]
    public IEnumerable<Encounter> Risk_Variable_Pulmonary_Hypertension(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzw_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> bzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Pulmonary_Hypertension(context);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConceptsInValueSet(bzzzzzzzzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return czzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Risk Variable Renal Disease")]
    public IEnumerable<Encounter> Risk_Variable_Renal_Disease(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzc_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> czzzzzzzzzzzzzzzzzzzzzzzzze_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Renal_Disease(context);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConceptsInValueSet(czzzzzzzzzzzzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Risk Variable Severe Preeclampsia")]
    public IEnumerable<Encounter> Risk_Variable_Severe_Preeclampsia(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzi_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> czzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Severe_Preeclampsia(context);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConceptsInValueSet(czzzzzzzzzzzzzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Risk Variable Substance Abuse")]
    public IEnumerable<Encounter> Risk_Variable_Substance_Abuse(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzo_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> czzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Substance_Abuse(context);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConceptsInValueSet(czzzzzzzzzzzzzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzzzzzzzzzzzzr_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzn_, czzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Risk Variable Thyrotoxicosis")]
    public IEnumerable<Encounter> Risk_Variable_Thyrotoxicosis(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzu_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> czzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Thyrotoxicosis(context);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConceptsInValueSet(czzzzzzzzzzzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Risk Variable Other Preeclampsia")]
    public IEnumerable<Encounter> Risk_Variable_Other_Preeclampsia(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzza_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> dzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Mild_or_Moderate_Preeclampsia(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConceptsInValueSet(dzzzzzzzzzzzzzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzzzzzzzzzzzzzd_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzz_, dzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Risk Variable Preterm Birth")]
    public IEnumerable<Encounter> Risk_Variable_Preterm_Birth(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzf_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzg_(Encounter DeliveryEncounter)
        {
            int? dzzzzzzzzzzzzzzzzzzzzzzzzzm_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlInterval<int?> dzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(20, 36, true, true);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<int?>(dzzzzzzzzzzzzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzzzzzzzzzzzzn_, default);
            CqlQuantity dzzzzzzzzzzzzzzzzzzzzzzzzzq_ = PCMaternal_5_19_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity dzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(20m, "weeks");
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.GreaterOrEqual(dzzzzzzzzzzzzzzzzzzzzzzzzzq_, dzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlQuantity dzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(36m, "weeks");
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.LessOrEqual(dzzzzzzzzzzzzzzzzzzzzzzzzzq_, dzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzs_, dzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And((bool?)(dzzzzzzzzzzzzzzzzzzzzzzzzzm_ is null), dzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzzzzzzzzzo_, dzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzj_(Encounter DeliveryEncounter)
        {
            int? dzzzzzzzzzzzzzzzzzzzzzzzzzz_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity ezzzzzzzzzzzzzzzzzzzzzzzzza_ = PCMaternal_5_19_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And((bool?)(dzzzzzzzzzzzzzzzzzzzzzzzzzz_ is null), (bool?)(ezzzzzzzzzzzzzzzzzzzzzzzzza_ is null));
            IEnumerable<CqlConcept> ezzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.pOAIsYesOrExempt(context, DeliveryEncounter);
            CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Preterm_Birth(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConceptsInValueSet(ezzzzzzzzzzzzzzzzzzzzzzzzzc_, ezzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzzzzzzzzzzze_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Risk Variable First Hematocrit Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> Risk_Variable_First_Hematocrit_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? ezzzzzzzzzzzzzzzzzzzzzzzzzh_(Encounter TwentyWeeksPlusEncounter)
        {
            Id ezzzzzzzzzzzzzzzzzzzzzzzzzk_ = TwentyWeeksPlusEncounter?.IdElement;
            string ezzzzzzzzzzzzzzzzzzzzzzzzzl_ = ezzzzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
            CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Hematocrit_lab_test(context);
            IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzo_(Observation Hematocrit)
            {
                Instant fzzzzzzzzzzzzzzzzzzzzzzzzzg_ = Hematocrit?.IssuedElement;
                DateTimeOffset? fzzzzzzzzzzzzzzzzzzzzzzzzzh_ = fzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzj_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlQuantity fzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(fzzzzzzzzzzzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzn_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzzzzzzzzzzzzzn_, true, false);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzzzzzzzzzzzzzo_, default);
                Code<ObservationStatus> fzzzzzzzzzzzzzzzzzzzzzzzzzq_ = Hematocrit?.StatusElement;
                ObservationStatus? fzzzzzzzzzzzzzzzzzzzzzzzzzr_ = fzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
                string fzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<string>(fzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                string[] fzzzzzzzzzzzzzzzzzzzzzzzzzt_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<string>(fzzzzzzzzzzzzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzzzzzzzzzzzzt_ as IEnumerable<string>);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzp_, fzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                DataType fzzzzzzzzzzzzzzzzzzzzzzzzzw_ = Hematocrit?.Value;
                object fzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzzzzzzzzzzzzx_ is null));
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                return fzzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzn_, ezzzzzzzzzzzzzzzzzzzzzzzzzo_);
            object ezzzzzzzzzzzzzzzzzzzzzzzzzq_(Observation @this)
            {
                Instant gzzzzzzzzzzzzzzzzzzzzzzzzza_ = @this?.IssuedElement;
                DateTimeOffset? gzzzzzzzzzzzzzzzzzzzzzzzzzb_ = gzzzzzzzzzzzzzzzzzzzzzzzzza_?.Value;
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzzzzzzzzc_ as object);

                return gzzzzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SortBy<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzzzzzzzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ezzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.First<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzr_);
            DataType ezzzzzzzzzzzzzzzzzzzzzzzzzt_ = ezzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
            object ezzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzt_);
            IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzx_(Observation Hematocrit)
            {
                Instant gzzzzzzzzzzzzzzzzzzzzzzzzze_ = Hematocrit?.IssuedElement;
                DateTimeOffset? gzzzzzzzzzzzzzzzzzzzzzzzzzf_ = gzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzh_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Subtract(gzzzzzzzzzzzzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzl_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzzzzzzzzzk_, gzzzzzzzzzzzzzzzzzzzzzzzzzl_, true, false);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzzzzzzzzzzzzm_, default);
                Code<ObservationStatus> gzzzzzzzzzzzzzzzzzzzzzzzzzo_ = Hematocrit?.StatusElement;
                ObservationStatus? gzzzzzzzzzzzzzzzzzzzzzzzzzp_ = gzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
                string gzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<string>(gzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                string[] gzzzzzzzzzzzzzzzzzzzzzzzzzr_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<string>(gzzzzzzzzzzzzzzzzzzzzzzzzzq_, gzzzzzzzzzzzzzzzzzzzzzzzzzr_ as IEnumerable<string>);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzn_, gzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzu_ = Hematocrit?.Value;
                object gzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzzzzzzzzzzzv_ is null));
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzt_, gzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                return gzzzzzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzw_, ezzzzzzzzzzzzzzzzzzzzzzzzzx_);
            object ezzzzzzzzzzzzzzzzzzzzzzzzzz_(Observation @this)
            {
                Instant gzzzzzzzzzzzzzzzzzzzzzzzzzy_ = @this?.IssuedElement;
                DateTimeOffset? gzzzzzzzzzzzzzzzzzzzzzzzzzz_ = gzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzzzzzzzzza_ as object);

                return hzzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SortBy<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzy_, ezzzzzzzzzzzzzzzzzzzzzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
            Observation fzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.First<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzza_);
            Instant fzzzzzzzzzzzzzzzzzzzzzzzzzc_ = fzzzzzzzzzzzzzzzzzzzzzzzzzb_?.IssuedElement;
            DateTimeOffset? fzzzzzzzzzzzzzzzzzzzzzzzzzd_ = fzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? fzzzzzzzzzzzzzzzzzzzzzzzzzf_ = (CqlTupleMetadata_DIHdhbAJeJTdiAVUAELUHRNdS, ezzzzzzzzzzzzzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzzzzzzzzzzzzu_ as CqlQuantity, fzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> ezzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(ezzzzzzzzzzzzzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> ezzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(ezzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Risk Variable First White Blood Cell Count Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?> Risk_Variable_First_White_Blood_Cell_Count_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)? hzzzzzzzzzzzzzzzzzzzzzzzzzd_(Encounter TwentyWeeksPlusEncounter)
        {
            Id hzzzzzzzzzzzzzzzzzzzzzzzzzg_ = TwentyWeeksPlusEncounter?.IdElement;
            string hzzzzzzzzzzzzzzzzzzzzzzzzzh_ = hzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
            CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.White_blood_cells_count_lab_test(context);
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation WBC)
            {
                Instant izzzzzzzzzzzzzzzzzzzzzzzzzc_ = WBC?.IssuedElement;
                DateTimeOffset? izzzzzzzzzzzzzzzzzzzzzzzzzd_ = izzzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzf_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlQuantity izzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Subtract(izzzzzzzzzzzzzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzj_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(izzzzzzzzzzzzzzzzzzzzzzzzzi_, izzzzzzzzzzzzzzzzzzzzzzzzzj_, true, false);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzze_, izzzzzzzzzzzzzzzzzzzzzzzzzk_, default);
                Code<ObservationStatus> izzzzzzzzzzzzzzzzzzzzzzzzzm_ = WBC?.StatusElement;
                ObservationStatus? izzzzzzzzzzzzzzzzzzzzzzzzzn_ = izzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
                string izzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzzzzzzzzzzzzn_);
                string[] izzzzzzzzzzzzzzzzzzzzzzzzzp_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<string>(izzzzzzzzzzzzzzzzzzzzzzzzzo_, izzzzzzzzzzzzzzzzzzzzzzzzzp_ as IEnumerable<string>);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzzzzzzzzzzzq_);
                DataType izzzzzzzzzzzzzzzzzzzzzzzzzs_ = WBC?.Value;
                object izzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzs_);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzzzzzzzzzzzt_ is null));
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzr_, izzzzzzzzzzzzzzzzzzzzzzzzzu_);

                return izzzzzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            object hzzzzzzzzzzzzzzzzzzzzzzzzzm_(Observation @this)
            {
                Instant izzzzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.IssuedElement;
                DateTimeOffset? izzzzzzzzzzzzzzzzzzzzzzzzzx_ = izzzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzzzzzzzzzzy_ as object);

                return izzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SortBy<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzzzzzzzzzzzzm_, System.ComponentModel.ListSortDirection.Ascending);
            Observation hzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.First<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            DataType hzzzzzzzzzzzzzzzzzzzzzzzzzp_ = hzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
            object hzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzt_(Observation WBC)
            {
                Instant jzzzzzzzzzzzzzzzzzzzzzzzzza_ = WBC?.IssuedElement;
                DateTimeOffset? jzzzzzzzzzzzzzzzzzzzzzzzzzb_ = jzzzzzzzzzzzzzzzzzzzzzzzzza_?.Value;
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzd_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlQuantity jzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Subtract(jzzzzzzzzzzzzzzzzzzzzzzzzze_, jzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzh_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(jzzzzzzzzzzzzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzzzzzzzzzzzzh_, true, false);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzzzzzc_, jzzzzzzzzzzzzzzzzzzzzzzzzzi_, default);
                Code<ObservationStatus> jzzzzzzzzzzzzzzzzzzzzzzzzzk_ = WBC?.StatusElement;
                ObservationStatus? jzzzzzzzzzzzzzzzzzzzzzzzzzl_ = jzzzzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
                string jzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                string[] jzzzzzzzzzzzzzzzzzzzzzzzzzn_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<string>(jzzzzzzzzzzzzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzzzzzzzzzzzzn_ as IEnumerable<string>);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzq_ = WBC?.Value;
                object jzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzzzzzzzzzzr_ is null));
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                return jzzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            object hzzzzzzzzzzzzzzzzzzzzzzzzzv_(Observation @this)
            {
                Instant jzzzzzzzzzzzzzzzzzzzzzzzzzu_ = @this?.IssuedElement;
                DateTimeOffset? jzzzzzzzzzzzzzzzzzzzzzzzzzv_ = jzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzzzzzzzzzzzzzzzzzzzzzzw_ as object);

                return jzzzzzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SortBy<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzu_, hzzzzzzzzzzzzzzzzzzzzzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
            Observation hzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.First<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            Instant hzzzzzzzzzzzzzzzzzzzzzzzzzy_ = hzzzzzzzzzzzzzzzzzzzzzzzzzx_?.IssuedElement;
            DateTimeOffset? hzzzzzzzzzzzzzzzzzzzzzzzzzz_ = hzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)? izzzzzzzzzzzzzzzzzzzzzzzzzb_ = (CqlTupleMetadata_ESFBYaBAeYMhOBFMjVCbeLhQA, hzzzzzzzzzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlQuantity, izzzzzzzzzzzzzzzzzzzzzzzzza_);

            return izzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?> hzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?>(hzzzzzzzzzzzzzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?> hzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?>(hzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Risk Variable Heart Rate")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?> Risk_Variable_Heart_Rate(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)? jzzzzzzzzzzzzzzzzzzzzzzzzzz_(Encounter TwentyWeeksPlusEncounter)
        {
            Id kzzzzzzzzzzzzzzzzzzzzzzzzzc_ = TwentyWeeksPlusEncounter?.IdElement;
            string kzzzzzzzzzzzzzzzzzzzzzzzzzd_ = kzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
            IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/heartrate"));
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzf_(Observation HeartRate)
            {
                DataType kzzzzzzzzzzzzzzzzzzzzzzzzzw_ = HeartRate?.Effective;
                object kzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, kzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzz_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlQuantity lzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Subtract(lzzzzzzzzzzzzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzd_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzzzzzzzzzzc_, lzzzzzzzzzzzzzzzzzzzzzzzzzd_, true, false);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzy_, lzzzzzzzzzzzzzzzzzzzzzzzzze_, default);
                Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzzzzzzg_ = HeartRate?.StatusElement;
                ObservationStatus? lzzzzzzzzzzzzzzzzzzzzzzzzzh_ = lzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
                string lzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                string[] lzzzzzzzzzzzzzzzzzzzzzzzzzj_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<string>(lzzzzzzzzzzzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzzzzzzzzzzzj_ as IEnumerable<string>);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                return lzzzzzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            object kzzzzzzzzzzzzzzzzzzzzzzzzzh_(Observation @this)
            {
                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                object lzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                return lzzzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SortBy<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzzzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
            Observation kzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.First<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            DataType kzzzzzzzzzzzzzzzzzzzzzzzzzk_ = kzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
            CqlQuantity kzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, kzzzzzzzzzzzzzzzzzzzzzzzzzk_ as Quantity);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzn_(Observation HeartRate)
            {
                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzp_ = HeartRate?.Effective;
                object lzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzs_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlQuantity lzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Subtract(lzzzzzzzzzzzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzw_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzzzzzzzzzzzw_, true, false);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzzzzzzzzzzzzx_, default);
                Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzzzzzzz_ = HeartRate?.StatusElement;
                ObservationStatus? mzzzzzzzzzzzzzzzzzzzzzzzzza_ = lzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
                string mzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(mzzzzzzzzzzzzzzzzzzzzzzzzza_);
                string[] mzzzzzzzzzzzzzzzzzzzzzzzzzc_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<string>(mzzzzzzzzzzzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzzzzzzzzzzzc_ as IEnumerable<string>);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                return mzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            object kzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation @this)
            {
                DataType mzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                object mzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                return mzzzzzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SortBy<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzzzzzzzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
            Observation kzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.First<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            DataType kzzzzzzzzzzzzzzzzzzzzzzzzzs_ = kzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Effective;
            object kzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, kzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)? kzzzzzzzzzzzzzzzzzzzzzzzzzv_ = (CqlTupleMetadata_HOiMaDjifIOTXXFShNKiWLBLV, kzzzzzzzzzzzzzzzzzzzzzzzzzd_, kzzzzzzzzzzzzzzzzzzzzzzzzzl_ as CqlQuantity, kzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?> kzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?>(jzzzzzzzzzzzzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?> kzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?>(kzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Risk Variable Systolic Blood Pressure")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?> Risk_Variable_Systolic_Blood_Pressure(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        (CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)? mzzzzzzzzzzzzzzzzzzzzzzzzzj_(Encounter TwentyWeeksPlusEncounter)
        {
            Id mzzzzzzzzzzzzzzzzzzzzzzzzzm_ = TwentyWeeksPlusEncounter?.IdElement;
            string mzzzzzzzzzzzzzzzzzzzzzzzzzn_ = mzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation BP)
            {
                DataType nzzzzzzzzzzzzzzzzzzzzzzzzzk_ = BP?.Effective;
                object nzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzn_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Subtract(nzzzzzzzzzzzzzzzzzzzzzzzzzo_, nzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzr_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzzzzzzzzzq_, nzzzzzzzzzzzzzzzzzzzzzzzzzr_, true, false);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzm_, nzzzzzzzzzzzzzzzzzzzzzzzzzs_, default);
                Code<ObservationStatus> nzzzzzzzzzzzzzzzzzzzzzzzzzu_ = BP?.StatusElement;
                ObservationStatus? nzzzzzzzzzzzzzzzzzzzzzzzzzv_ = nzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
                string nzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                string[] nzzzzzzzzzzzzzzzzzzzzzzzzzx_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<string>(nzzzzzzzzzzzzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzzzzzzzzzzzzx_ as IEnumerable<string>);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzt_, nzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                List<Observation.ComponentComponent> ozzzzzzzzzzzzzzzzzzzzzzzzza_ = BP?.Component;
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzb_(Observation.ComponentComponent @this)
                {
                    DataType ozzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Value;
                    object ozzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzh_);
                    bool? ozzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzzzzzzzzzzi_ is null));

                    return ozzzzzzzzzzzzzzzzzzzzzzzzzj_;
                };
                IEnumerable<Observation.ComponentComponent> ozzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ozzzzzzzzzzzzzzzzzzzzzzzzza_, ozzzzzzzzzzzzzzzzzzzzzzzzzb_);
                object ozzzzzzzzzzzzzzzzzzzzzzzzzd_(Observation.ComponentComponent @this)
                {
                    DataType ozzzzzzzzzzzzzzzzzzzzzzzzzk_ = @this?.Value;
                    object ozzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzk_);

                    return ozzzzzzzzzzzzzzzzzzzzzzzzzl_;
                };
                IEnumerable<object> ozzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<Observation.ComponentComponent, object>(ozzzzzzzzzzzzzzzzzzzzzzzzzc_, ozzzzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzzzzzzzzzze_ is null));
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzz_, ozzzzzzzzzzzzzzzzzzzzzzzzzf_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            object mzzzzzzzzzzzzzzzzzzzzzzzzzr_(Observation @this)
            {
                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                object ozzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzzzzzzzzzn_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SortBy<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzzzzzzzzzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
            Observation mzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.First<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            List<Observation.ComponentComponent> mzzzzzzzzzzzzzzzzzzzzzzzzzu_ = mzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Component;
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzv_(Observation.ComponentComponent C)
            {
                CodeableConcept ozzzzzzzzzzzzzzzzzzzzzzzzzp_ = C?.Code;
                CqlConcept ozzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ozzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlCode ozzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Systolic_blood_pressure(context);
                CqlConcept ozzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertCodeToConcept(ozzzzzzzzzzzzzzzzzzzzzzzzzr_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Equivalent(ozzzzzzzzzzzzzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzzzzzzzzzzzzs_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Observation.ComponentComponent> mzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)mzzzzzzzzzzzzzzzzzzzzzzzzzu_, mzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlQuantity mzzzzzzzzzzzzzzzzzzzzzzzzzx_(Observation.ComponentComponent C)
            {
                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzu_ = C?.Value;
                object ozzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzu_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzzv_ as CqlQuantity;
            };
            IEnumerable<CqlQuantity> mzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<Observation.ComponentComponent, CqlQuantity>(mzzzzzzzzzzzzzzzzzzzzzzzzzw_, mzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            IEnumerable<CqlQuantity> mzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Distinct<CqlQuantity>(mzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzb_(Observation BP)
            {
                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzw_ = BP?.Effective;
                object ozzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzz_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlQuantity pzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Subtract(pzzzzzzzzzzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzd_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(pzzzzzzzzzzzzzzzzzzzzzzzzzc_, pzzzzzzzzzzzzzzzzzzzzzzzzzd_, true, false);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzzzzzzze_, default);
                Code<ObservationStatus> pzzzzzzzzzzzzzzzzzzzzzzzzzg_ = BP?.StatusElement;
                ObservationStatus? pzzzzzzzzzzzzzzzzzzzzzzzzzh_ = pzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
                string pzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                string[] pzzzzzzzzzzzzzzzzzzzzzzzzzj_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<string>(pzzzzzzzzzzzzzzzzzzzzzzzzzi_, pzzzzzzzzzzzzzzzzzzzzzzzzzj_ as IEnumerable<string>);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzf_, pzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                List<Observation.ComponentComponent> pzzzzzzzzzzzzzzzzzzzzzzzzzm_ = BP?.Component;
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzn_(Observation.ComponentComponent @this)
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Value;
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                    bool? pzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzzzzzzzzzzzzzu_ is null));

                    return pzzzzzzzzzzzzzzzzzzzzzzzzzv_;
                };
                IEnumerable<Observation.ComponentComponent> pzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)pzzzzzzzzzzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                object pzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation.ComponentComponent @this)
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.Value;
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                    return pzzzzzzzzzzzzzzzzzzzzzzzzzx_;
                };
                IEnumerable<object> pzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Observation.ComponentComponent, object>(pzzzzzzzzzzzzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzzzzzzzzzzzzzq_ is null));
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzl_, pzzzzzzzzzzzzzzzzzzzzzzzzzr_);

                return pzzzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzo_, nzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            object nzzzzzzzzzzzzzzzzzzzzzzzzzd_(Observation @this)
            {
                DataType pzzzzzzzzzzzzzzzzzzzzzzzzzy_ = @this?.Effective;
                object pzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                return qzzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SortBy<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzc_, nzzzzzzzzzzzzzzzzzzzzzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
            Observation nzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.First<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzze_);
            DataType nzzzzzzzzzzzzzzzzzzzzzzzzzg_ = nzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Effective;
            object nzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            (CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)? nzzzzzzzzzzzzzzzzzzzzzzzzzj_ = (CqlTupleMetadata_FjSKXeIESORPNbRGajibMfUaK, mzzzzzzzzzzzzzzzzzzzzzzzzzn_, mzzzzzzzzzzzzzzzzzzzzzzzzzz_, nzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?> mzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?>(mzzzzzzzzzzzzzzzzzzzzzzzzzi_, mzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?> mzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?>(mzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzl_;
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
