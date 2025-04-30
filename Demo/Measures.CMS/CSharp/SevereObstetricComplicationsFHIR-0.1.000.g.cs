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
      new CqlCodeSystem("http://loinc.org", null,
          _Heart_rate,
          _Systolic_blood_pressure);

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, true, true);
        object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.ResolveParameter("SevereObstetricComplicationsFHIR-0.1.000", "Measurement Period", gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return (CqlInterval<CqlDateTime>)gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SingletonFrom<Patient>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode hzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Calculated Gestational Age Greater than or Equal to 20 Weeks")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_20_Weeks(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Encounter DeliveryEncounter)
        {
            int? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.GreaterOrEqual(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, 20);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Estimated Gestational Age Assessment Greater than or Equal to 20 Weeks")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Estimated_Gestational_Age_Assessment_Greater_than_or_Equal_to_20_Weeks(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Encounter DeliveryEncounter)
        {
            int? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = PCMaternal_5_19_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(20m, "weeks");
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.GreaterOrEqual(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And((bool?)(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ is null), hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Gestational Age Greater than or Equal to 20 Weeks Based on Coding")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Gestational_Age_Greater_than_or_Equal_to_20_Weeks_Based_on_Coding(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Encounter DeliveryEncounter)
        {
            int? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = PCMaternal_5_19_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And((bool?)(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ is null), (bool?)(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is null));
            IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, DeliveryEncounter);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Condition EncounterDiagnosis)
            {
                CodeableConcept izzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = EncounterDiagnosis?.Code;
                CqlConcept izzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this._20_to_42_Plus_Weeks_Gestation(context);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConceptInValueSet(izzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Condition> izzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Condition>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<Condition>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Delivery Encounters At Greater than or Equal to 20 Weeks Gestation")]
    public IEnumerable<Encounter> Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Delivery_Encounters_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_20_Weeks(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Delivery_Encounters_with_Estimated_Gestational_Age_Assessment_Greater_than_or_Equal_to_20_Weeks(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Delivery_Encounters_with_Gestational_Age_Greater_than_or_Equal_to_20_Weeks_Based_on_Coding(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("pOAIsNoOrUTD")]
    public IEnumerable<CqlConcept> pOAIsNoOrUTD(CqlContext context, Encounter TheEncounter)
    {
        List<Encounter.DiagnosisComponent> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = TheEncounter?.Diagnosis;
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Encounter.DiagnosisComponent EncounterDiagnoses)
        {
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Extension @this)
            {
                string jzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = @this?.Url;
                FhirString jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<FhirString>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                string jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToString(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Extension> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(EncounterDiagnoses is Element
                    ? (EncounterDiagnoses as Element).Extension
                    : default), izzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Extension @this)
            {
                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = @this?.Value;

                return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<object> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Extension, object>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<object>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlConcept izzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as CodeableConcept);
            CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Present_on_Admission_is_No_or_Unable_To_Determine(context);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConceptInValueSet(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter.DiagnosisComponent> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)izzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        CqlConcept izzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Encounter.DiagnosisComponent EncounterDiagnoses)
        {
            ResourceReference jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = EncounterDiagnoses?.Condition;
            Condition jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = CQMCommon_2_2_000.Instance.getCondition(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CodeableConcept jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Code;
            CqlConcept jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<CqlConcept> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Encounter.DiagnosisComponent, CqlConcept>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<CqlConcept> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Distinct<CqlConcept>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Severe Obstetric Complications Diagnosis or Procedure Excluding Blood Transfusion")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Severe_Obstetric_Complications_Diagnosis_or_Procedure_Excluding_Blood_Transfusion(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.pOAIsNoOrUTD(context, TwentyWeeksPlusEncounter);
            CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConceptsInValueSet(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Severe_Maternal_Morbidity_Procedures(context);
            IEnumerable<Procedure> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Procedure SMMProcedures)
            {
                Code<EventStatus> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = SMMProcedures?.StatusElement;
                EventStatus? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
                string jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Equal(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "completed");
                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = SMMProcedures?.Performed;
                object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "day");
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Procedure> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Procedure>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Procedure>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Expiration")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Expiration(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Encounter TwentyWeeksPlusEncounter)
        {
            Encounter.HospitalizationComponent kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = TwentyWeeksPlusEncounter?.Hospitalization;
            CodeableConcept kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.DischargeDisposition;
            CqlConcept kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Patient_Expired(context);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConceptInValueSet(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Blood Transfusion")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Blood_Transfusion(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Encounter TwentyWeeksPlusEncounter)
        {
            CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Blood_Transfusion(context);
            IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Procedure BloodTransfusion)
            {
                Code<EventStatus> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = BloodTransfusion?.StatusElement;
                EventStatus? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
                string kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "completed");
                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = BloodTransfusion?.Performed;
                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "day");
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Procedure>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            Encounter kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Procedure BloodTransfusion) =>
                TwentyWeeksPlusEncounter;
            IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<Procedure, Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SelectMany<Encounter, Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Severe Obstetric Complications")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Severe_Obstetric_Complications(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Diagnosis_or_Procedure_Excluding_Blood_Transfusion(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Delivery_Encounters_with_Expiration(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Delivery_Encounters_with_Blood_Transfusion(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Hysterectomy")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Hysterectomy(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Encounter TwentyWeeksPlusEncounter)
        {
            CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Hysterectomy(context);
            IEnumerable<Procedure> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Procedure Hysterectomy)
            {
                Code<EventStatus> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = Hysterectomy?.StatusElement;
                EventStatus? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
                string lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equal(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "completed");
                DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = Hysterectomy?.Performed;
                object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, "day");
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Procedure> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Procedure>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            Encounter lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Procedure Hysterectomy) =>
                TwentyWeeksPlusEncounter;
            IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Procedure, Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SelectMany<Encounter, Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Cardiac Conversion, Tracheostomy or Ventilation Procedures")]
    public IEnumerable<Procedure> Cardiac_Conversion__Tracheostomy_or_Ventilation_Procedures(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Conversion_of_Cardiac_Rhythm(context);
        IEnumerable<Procedure> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Tracheostomy(context);
        IEnumerable<Procedure> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Procedure>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Ventilation(context);
        IEnumerable<Procedure> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Procedure>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Cardiac Conversion, Tracheostomy or Ventilation Procedures")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Cardiac_Conversion__Tracheostomy_or_Ventilation_Procedures(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<Procedure> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Cardiac_Conversion__Tracheostomy_or_Ventilation_Procedures(context);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Procedure ConvTrachVentProcedures)
            {
                Code<EventStatus> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = ConvTrachVentProcedures?.StatusElement;
                EventStatus? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
                string mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Equal(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "completed");
                DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = ConvTrachVentProcedures?.Performed;
                object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "day");
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Procedure> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Procedure>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            Encounter mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Procedure ConvTrachVentProcedures) =>
                TwentyWeeksPlusEncounter;
            IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<Procedure, Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SelectMany<Encounter, Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SOC with Hysterectomy or Blood Transfusion with Placenta Increta or Placenta Percreta Without Additional SOC")]
    public IEnumerable<Encounter> SOC_with_Hysterectomy_or_Blood_Transfusion_with_Placenta_Increta_or_Placenta_Percreta_Without_Additional_SOC(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Encounter SOCEncounter)
        {
            IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, SOCEncounter);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Condition EncounterDiagnosis)
            {
                CodeableConcept ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = EncounterDiagnosis?.Code;
                CqlConcept ozzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Placenta_Increta_or_Percreta(context);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConceptInValueSet(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Delivery_Encounters_with_Blood_Transfusion(context);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Delivery_Encounters_with_Hysterectomy(context);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Encounter SOCEncounter)
        {
            IEnumerable<CqlConcept> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.pOAIsNoOrUTD(context, SOCEncounter);
            CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConceptsInValueSet(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Delivery_Encounters_with_Cardiac_Conversion__Tracheostomy_or_Ventilation_Procedures(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Delivery_Encounters_with_Expiration(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Except<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Delivery Encounters with Severe Obstetric Complication Diagnosis")]
    public IEnumerable<Encounter> SDE_Delivery_Encounters_with_Severe_Obstetric_Complication_Diagnosis(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.SOC_with_Hysterectomy_or_Blood_Transfusion_with_Placenta_Increta_or_Placenta_Percreta_Without_Additional_SOC(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Except<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Encounter Encounter)
        {
            IEnumerable<CqlConcept> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.pOAIsNoOrUTD(context, Encounter);
            CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConceptsInValueSet(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("SDE Delivery Encounters with Severe Obstetric Complication Procedures")]
    public IEnumerable<Encounter> SDE_Delivery_Encounters_with_Severe_Obstetric_Complication_Procedures(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.SOC_with_Hysterectomy_or_Blood_Transfusion_with_Placenta_Increta_or_Placenta_Percreta_Without_Additional_SOC(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Except<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Encounter Encounter)
        {
            CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Severe_Maternal_Morbidity_Procedures(context);
            IEnumerable<Procedure> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Blood_Transfusion(context);
            IEnumerable<Procedure> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Procedure>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Procedure SMMProcedures)
            {
                Code<EventStatus> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = SMMProcedures?.StatusElement;
                EventStatus? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
                string pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Equal(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "completed");
                DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = SMMProcedures?.Performed;
                object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, Encounter);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "day");
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Procedure> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Procedure>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Procedure>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("sOCDxCategory")]
    public string sOCDxCategory(CqlContext context, CqlConcept Dx)
    {
        string pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_()
        {
            bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_()
            {
                CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Acute_Heart_Failure(context);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConceptInValueSet(Dx, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ ?? false;
            };
            bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_()
            {
                CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Acute_Myocardial_Infarction(context);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConceptInValueSet(Dx, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ ?? false;
            };
            bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_()
            {
                CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Acute_Renal_Failure(context);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConceptInValueSet(Dx, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ ?? false;
            };
            bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_()
            {
                CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Acute_Respiratory_Distress_Syndrome(context);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConceptInValueSet(Dx, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ ?? false;
            };
            bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_()
            {
                CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Air_and_Thrombotic_Embolism(context);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConceptInValueSet(Dx, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ ?? false;
            };
            bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_()
            {
                CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Amniotic_Fluid_Embolism(context);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConceptInValueSet(Dx, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ ?? false;
            };
            bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_()
            {
                CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Aortic_Aneurysm(context);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConceptInValueSet(Dx, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ ?? false;
            };
            bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_()
            {
                CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Cardiac_Arrest_Ventricular_Fibrillation(context);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(Dx, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ ?? false;
            };
            bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_()
            {
                CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Disseminated_Intravascular_Coagulation(context);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConceptInValueSet(Dx, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ ?? false;
            };
            bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_()
            {
                CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Eclampsia(context);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConceptInValueSet(Dx, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ ?? false;
            };
            bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_()
            {
                CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Heart_Failure_Cardiac_Arrest_Related_to_Procedure_or_Surgery(context);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConceptInValueSet(Dx, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ ?? false;
            };
            bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_()
            {
                CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Puerperal_Cerebrovascular_Disorder(context);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConceptInValueSet(Dx, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ ?? false;
            };
            bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_()
            {
                CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Pulmonary_Edema(context);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConceptInValueSet(Dx, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ ?? false;
            };
            bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_()
            {
                CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Sepsis(context);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConceptInValueSet(Dx, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ ?? false;
            };
            bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_()
            {
                CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Severe_Anesthesia_Complications(context);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConceptInValueSet(Dx, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ ?? false;
            };
            bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_()
            {
                CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Shock(context);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConceptInValueSet(Dx, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ ?? false;
            };
            bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_()
            {
                CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Sickle_Cell_Disease_with_Crisis(context);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConceptInValueSet(Dx, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ ?? false;
            };
            if (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_())
            {
                return "Acute Heart Failure";
            }
            else if (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_())
            {
                return "Acute Myocardial Infarction";
            }
            else if (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_())
            {
                return "Acute Renal Failure";
            }
            else if (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_())
            {
                return "Acute Respiratory Distress Syndrome";
            }
            else if (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_())
            {
                return "Air and Thrombotic Embolism";
            }
            else if (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_())
            {
                return "Amniotic Fluid Embolism";
            }
            else if (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_())
            {
                return "Aortic Aneurysm";
            }
            else if (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_())
            {
                return "Cardiac Arrest Ventricular Fibrillation";
            }
            else if (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_())
            {
                return "Disseminated Intravascular Coagulation";
            }
            else if (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_())
            {
                return "Eclampsia";
            }
            else if (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_())
            {
                return "Heart Failure Cardiac Arrest Related to Procedure or Surgery";
            }
            else if (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_())
            {
                return "Puerperal Cerebrovascular Disorder";
            }
            else if (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_())
            {
                return "Pulmonary Edema";
            }
            else if (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_())
            {
                return "Sepsis";
            }
            else if (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_())
            {
                return "Severe Anesthesia Complications";
            }
            else if (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_())
            {
                return "Shock";
            }
            else if (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_())
            {
                return "Sickle Cell Disease with Crisis";
            }
            else
            {
                return default;
            }
        };

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_();
    }


    [CqlExpressionDefinition("SDE SOC Diagnoses Detail")]
    public IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)?> SDE_SOC_Diagnoses_Detail(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.SDE_Delivery_Encounters_with_Severe_Obstetric_Complication_Diagnosis(context);
        (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Encounter Encounter)
        {
            Id rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = Encounter?.IdElement;
            string rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
            IEnumerable<CqlConcept> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.pOAIsNoOrUTD(context, Encounter);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(CqlConcept C)
            {
                CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConceptInValueSet(C, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                return szzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<CqlConcept> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<CqlConcept>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            (CqlTupleMetadata, CqlConcept code, string SOCDxCategory)? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(CqlConcept C)
            {
                string szzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.sOCDxCategory(context, C);
                (CqlTupleMetadata, CqlConcept code, string SOCDxCategory)? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = (CqlTupleMetadata_FRbAiSWEhRfKaLTXPVgFXYZAE, C, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> szzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<CqlConcept, (CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Distinct<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = (CqlTupleMetadata_RBQLXdQIRBbBEHDfOgQjdBMH, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)?> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)?>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)?> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)?>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("sOCProcedures")]
    public IEnumerable<Procedure> sOCProcedures(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Severe_Maternal_Morbidity_Procedures(context);
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Blood_Transfusion(context);
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Procedure>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Procedure SMMProcedures)
        {
            Code<EventStatus> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = SMMProcedures?.StatusElement;
            EventStatus? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
            string szzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<string>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Equal(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, "completed");
            DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = SMMProcedures?.Performed;
            object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "day");
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Procedure>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("sOCProcedureCategory")]
    public string sOCProcedureCategory(CqlContext context, Procedure TheProcedure)
    {
        string szzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_()
        {
            bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_()
            {
                CodeableConcept tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = TheProcedure?.Code;
                CqlConcept tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Blood_Transfusion(context);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConceptInValueSet(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ ?? false;
            };
            bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_()
            {
                CodeableConcept tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = TheProcedure?.Code;
                CqlConcept tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Conversion_of_Cardiac_Rhythm(context);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConceptInValueSet(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ ?? false;
            };
            bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_()
            {
                CodeableConcept tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = TheProcedure?.Code;
                CqlConcept tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Hysterectomy(context);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConceptInValueSet(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ ?? false;
            };
            bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_()
            {
                CodeableConcept tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = TheProcedure?.Code;
                CqlConcept tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Tracheostomy(context);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConceptInValueSet(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ ?? false;
            };
            bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_()
            {
                CodeableConcept tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = TheProcedure?.Code;
                CqlConcept tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Ventilation(context);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConceptInValueSet(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ ?? false;
            };
            if (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_())
            {
                return "Blood Transfusion";
            }
            else if (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_())
            {
                return "Conversion of cardiac rhythm";
            }
            else if (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_())
            {
                return "Hysterectomy";
            }
            else if (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_())
            {
                return "Tracheostomy";
            }
            else if (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_())
            {
                return "Ventilation";
            }
            else
            {
                return default;
            }
        };

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_();
    }


    [CqlExpressionDefinition("SDE SOC Procedure Detail")]
    public IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?> SDE_SOC_Procedure_Detail(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.SDE_Delivery_Encounters_with_Severe_Obstetric_Complication_Procedures(context);
        (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Encounter Encounter)
        {
            Id uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = Encounter?.IdElement;
            string uzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
            IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.sOCProcedures(context, Encounter);
            (CqlTupleMetadata, Procedure code, string SOCProcedureCategory)? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Procedure P)
            {
                string uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.sOCProcedureCategory(context, P);
                (CqlTupleMetadata, Procedure code, string SOCProcedureCategory)? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = (CqlTupleMetadata_FNaSKPNeFZXSNMfSCYPJLLGSR, P, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<Procedure, (CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = (CqlTupleMetadata_DbihhAfJfGSKOIcQDBMEMigFK, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Distinct<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications(context);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Delivery Encounters with COVID and Respiratory Condition or Procedure")]
    public IEnumerable<Encounter> Delivery_Encounters_with_COVID_and_Respiratory_Condition_or_Procedure(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, TwentyWeeksPlusEncounter);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Condition EncounterDiagnosis)
            {
                CodeableConcept vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = EncounterDiagnosis?.Code;
                CqlConcept vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.COVID_19_Confirmed(context);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConceptInValueSet(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Condition>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Condition>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Condition EncounterDiagnosis)
            {
                CodeableConcept vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = EncounterDiagnosis?.Code;
                CqlConcept vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Respiratory_Conditions_Related_to_COVID_19(context);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConceptInValueSet(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Condition>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Condition>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Respiratory_Support_Procedures_Related_to_COVID_19(context);
            IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Procedure COVIDRespiratoryProcedure)
            {
                Code<EventStatus> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = COVIDRespiratoryProcedure?.StatusElement;
                EventStatus? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
                string vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Equal(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "completed");
                DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = COVIDRespiratoryProcedure?.Performed;
                object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, "day");
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Procedure>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<Procedure>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Or(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public IEnumerable<Encounter> Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Delivery_Encounters_with_COVID_and_Respiratory_Condition_or_Procedure(context);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Stratification Encounter")]
    public IEnumerable<Encounter> Stratification_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Numerator(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Denominator_Exclusion(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Except<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Severe Obstetric Complications Excluding Blood Transfusions")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Diagnosis_or_Procedure_Excluding_Blood_Transfusion(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Delivery_Encounters_with_Expiration(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Stratum 1")]
    public IEnumerable<Encounter> Stratum_1(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Stratification_Encounter(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Intersect<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Variable Calculated Gestational Age")]
    public IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> SDE_Variable_Calculated_Gestational_Age(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = PCMaternal_5_19_000.Instance.Variable_Calculated_Gestational_Age(context);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Severe Obstetric Complications Excluding Blood Transfusions Only")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions_Only(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Intersect<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("SOC Excluding Blood Transfusions Only with Hysterectomy or Blood Transfusion with Placenta Increta or Placenta Percreta Without Additional SOC")]
    public IEnumerable<Encounter> SOC_Excluding_Blood_Transfusions_Only_with_Hysterectomy_or_Blood_Transfusion_with_Placenta_Increta_or_Placenta_Percreta_Without_Additional_SOC(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions_Only(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Encounter SOCExcludingTransfusion)
        {
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, SOCExcludingTransfusion);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Condition EncounterDiagnoses)
            {
                CodeableConcept xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = EncounterDiagnoses?.Code;
                CqlConcept xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Placenta_Increta_or_Percreta(context);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConceptInValueSet(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Condition>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<Condition>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Delivery_Encounters_with_Blood_Transfusion(context);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Delivery_Encounters_with_Hysterectomy(context);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Or(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Encounter SOCExcludingTransfusion)
        {
            IEnumerable<CqlConcept> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.pOAIsNoOrUTD(context, SOCExcludingTransfusion);
            CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConceptsInValueSet(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Delivery_Encounters_with_Cardiac_Conversion__Tracheostomy_or_Ventilation_Procedures(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Delivery_Encounters_with_Expiration(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Except<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("pOAIsYesOrExempt")]
    public IEnumerable<CqlConcept> pOAIsYesOrExempt(CqlContext context, Encounter TheEncounter)
    {
        List<Encounter.DiagnosisComponent> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = TheEncounter?.Diagnosis;
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Encounter.DiagnosisComponent EncounterDiagnoses)
        {
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Extension @this)
            {
                string yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Url;
                FhirString yzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<FhirString>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                string yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToString(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Equal(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Extension> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(EncounterDiagnoses is Element
                    ? (EncounterDiagnoses as Element).Extension
                    : default), xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Extension @this)
            {
                DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Value;

                return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<object> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<Extension, object>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SingletonFrom<object>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlConcept yzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as CodeableConcept);
            CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter.DiagnosisComponent> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlConcept xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Encounter.DiagnosisComponent EncounterDiagnoses)
        {
            ResourceReference yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = EncounterDiagnoses?.Condition;
            Condition yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = CQMCommon_2_2_000.Instance.getCondition(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CodeableConcept yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Code;
            CqlConcept yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<CqlConcept> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<Encounter.DiagnosisComponent, CqlConcept>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<CqlConcept> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Distinct<CqlConcept>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Risk Variable Anemia")]
    public IEnumerable<Encounter> Risk_Variable_Anemia(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Anemia(context);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConceptsInValueSet(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Risk Variable Asthma")]
    public IEnumerable<Encounter> Risk_Variable_Asthma(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Acute_or_Persistent_Asthma(context);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConceptsInValueSet(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Risk Variable Autoimmune Disease")]
    public IEnumerable<Encounter> Risk_Variable_Autoimmune_Disease(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Autoimmune_Disease(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConceptsInValueSet(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Risk Variable Bariatric Surgery")]
    public IEnumerable<Encounter> Risk_Variable_Bariatric_Surgery(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Bariatric_Surgery(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConceptsInValueSet(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Risk Variable Bleeding Disorder")]
    public IEnumerable<Encounter> Risk_Variable_Bleeding_Disorder(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Bleeding_Disorder(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConceptsInValueSet(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Risk Variable Morbid Obesity")]
    public IEnumerable<Encounter> Risk_Variable_Morbid_Obesity(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Morbid_or_Severe_Obesity(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConceptsInValueSet(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Risk Variable Cardiac Disease")]
    public IEnumerable<Encounter> Risk_Variable_Cardiac_Disease(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Cardiac_Disease(context);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConceptsInValueSet(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Risk Variable Economic Housing Instability")]
    public IEnumerable<Encounter> Risk_Variable_Economic_Housing_Instability(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Economic_Housing_Instability(context);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConceptsInValueSet(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Risk Variable Gastrointestinal Disease")]
    public IEnumerable<Encounter> Risk_Variable_Gastrointestinal_Disease(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Gastrointestinal_Disease(context);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConceptsInValueSet(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Risk Variable Gestational Diabetes")]
    public IEnumerable<Encounter> Risk_Variable_Gestational_Diabetes(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Gestational_Diabetes(context);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConceptsInValueSet(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Risk Variable HIV")]
    public IEnumerable<Encounter> Risk_Variable_HIV(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.HIV_in_Pregnancy_Childbirth_and_Puerperium(context);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConceptsInValueSet(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Risk Variable Hypertension")]
    public IEnumerable<Encounter> Risk_Variable_Hypertension(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Hypertension(context);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConceptsInValueSet(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Risk Variable Long Term Anticoagulant Use")]
    public IEnumerable<Encounter> Risk_Variable_Long_Term_Anticoagulant_Use(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Long_Term_Anticoagulant_Use(context);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConceptsInValueSet(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Risk Variable Maternal Age")]
    public IEnumerable<IEnumerable<object>> Risk_Variable_Maternal_Age(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        IEnumerable<object> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Encounter TwentyWeeksPlusEncounter)
        {
            Patient bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Patient(context);
            Date bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.BirthDateElement;
            string bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
            CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConvertStringToDate(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            Period bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = TwentyWeeksPlusEncounter?.Period;
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            int? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.CalculateAgeAt(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "year");
            object[] bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = [
                TwentyWeeksPlusEncounter,
bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ ?? default(int),
            ];

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as IEnumerable<object>;
        };
        IEnumerable<IEnumerable<object>> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Encounter, IEnumerable<object>>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<IEnumerable<object>> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Distinct<IEnumerable<object>>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Risk Variable Mental Health Disorder")]
    public IEnumerable<Encounter> Risk_Variable_Mental_Health_Disorder(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Mental_Health_Disorder(context);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConceptsInValueSet(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Risk Variable Multiple Pregnancy")]
    public IEnumerable<Encounter> Risk_Variable_Multiple_Pregnancy(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Multiple_Pregnancy(context);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConceptsInValueSet(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Risk Variable Neuromuscular")]
    public IEnumerable<Encounter> Risk_Variable_Neuromuscular(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Neuromuscular_Disease(context);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConceptsInValueSet(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Risk Variable Obstetrical VTE")]
    public IEnumerable<Encounter> Risk_Variable_Obstetrical_VTE(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Venous_Thromboembolism_in_Pregnancy(context);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConceptsInValueSet(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Risk Variable Placenta Previa")]
    public IEnumerable<Encounter> Risk_Variable_Placenta_Previa(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Placenta_Previa(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConceptsInValueSet(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Risk Variable Placental Abruption")]
    public IEnumerable<Encounter> Risk_Variable_Placental_Abruption(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Placental_Abruption(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConceptsInValueSet(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Risk Variable Placental Accreta Spectrum")]
    public IEnumerable<Encounter> Risk_Variable_Placental_Accreta_Spectrum(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Placenta_Accreta(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConceptsInValueSet(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Placenta_Increta_or_Percreta(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConceptsInValueSet(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Risk Variable Preexisting Diabetes")]
    public IEnumerable<Encounter> Risk_Variable_Preexisting_Diabetes(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Preexisting_Diabetes(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConceptsInValueSet(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Risk Variable Previous Cesarean")]
    public IEnumerable<Encounter> Risk_Variable_Previous_Cesarean(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Previous_Cesarean(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConceptsInValueSet(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Risk Variable Pulmonary Hypertension")]
    public IEnumerable<Encounter> Risk_Variable_Pulmonary_Hypertension(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Pulmonary_Hypertension(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConceptsInValueSet(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Risk Variable Renal Disease")]
    public IEnumerable<Encounter> Risk_Variable_Renal_Disease(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Renal_Disease(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConceptsInValueSet(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Risk Variable Severe Preeclampsia")]
    public IEnumerable<Encounter> Risk_Variable_Severe_Preeclampsia(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Severe_Preeclampsia(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConceptsInValueSet(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Risk Variable Substance Abuse")]
    public IEnumerable<Encounter> Risk_Variable_Substance_Abuse(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Substance_Abuse(context);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConceptsInValueSet(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Risk Variable Thyrotoxicosis")]
    public IEnumerable<Encounter> Risk_Variable_Thyrotoxicosis(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Thyrotoxicosis(context);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConceptsInValueSet(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Risk Variable Other Preeclampsia")]
    public IEnumerable<Encounter> Risk_Variable_Other_Preeclampsia(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Mild_or_Moderate_Preeclampsia(context);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConceptsInValueSet(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Risk Variable Preterm Birth")]
    public IEnumerable<Encounter> Risk_Variable_Preterm_Birth(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Encounter DeliveryEncounter)
        {
            int? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlInterval<int?> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(20, 36, true, true);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<int?>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default);
            CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = PCMaternal_5_19_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(20m, "weeks");
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.GreaterOrEqual(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(36m, "weeks");
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.LessOrEqual(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And((bool?)(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is null), gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Or(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Encounter DeliveryEncounter)
        {
            int? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = PCMaternal_5_19_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And((bool?)(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ is null), (bool?)(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ is null));
            IEnumerable<CqlConcept> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.pOAIsYesOrExempt(context, DeliveryEncounter);
            CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Preterm_Birth(context);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConceptsInValueSet(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Risk Variable First Hematocrit Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> Risk_Variable_First_Hematocrit_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Encounter TwentyWeeksPlusEncounter)
        {
            Id gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = TwentyWeeksPlusEncounter?.IdElement;
            string gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
            CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Hematocrit_lab_test(context);
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Observation Hematocrit)
            {
                Instant hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = Hematocrit?.IssuedElement;
                DateTimeOffset? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Subtract(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, true, false);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default);
                Code<ObservationStatus> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = Hematocrit?.StatusElement;
                ObservationStatus? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
                string izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                string[] izzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<string>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as IEnumerable<string>);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = Hematocrit?.Value;
                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ is null));
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Observation @this)
            {
                Instant izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = @this?.IssuedElement;
                DateTimeOffset? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as object);

                return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SortBy<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
            Observation hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.First<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
            object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation Hematocrit)
            {
                Instant izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = Hematocrit?.IssuedElement;
                DateTimeOffset? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlQuantity izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Subtract(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, true, false);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default);
                Code<ObservationStatus> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = Hematocrit?.StatusElement;
                ObservationStatus? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
                string jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                string[] jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<string>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as IEnumerable<string>);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = Hematocrit?.Value;
                object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is null));
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation @this)
            {
                Instant jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.IssuedElement;
                DateTimeOffset? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as object);

                return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SortBy<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
            Observation hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.First<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            Instant hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.IssuedElement;
            DateTimeOffset? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = (CqlTupleMetadata_DIHdhbAJeJTdiAVUAELUHRNdS, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as CqlQuantity, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Risk Variable First White Blood Cell Count Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?> Risk_Variable_First_White_Blood_Cell_Count_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Encounter TwentyWeeksPlusEncounter)
        {
            Id jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = TwentyWeeksPlusEncounter?.IdElement;
            string jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
            CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.White_blood_cells_count_lab_test(context);
            IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Observation WBC)
            {
                Instant kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = WBC?.IssuedElement;
                DateTimeOffset? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlQuantity kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Subtract(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, true, false);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default);
                Code<ObservationStatus> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = WBC?.StatusElement;
                ObservationStatus? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
                string kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                string[] lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<string>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as IEnumerable<string>);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = WBC?.Value;
                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ is null));
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Observation @this)
            {
                Instant lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.IssuedElement;
                DateTimeOffset? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as object);

                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SortBy<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
            Observation jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.First<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
            object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Observation WBC)
            {
                Instant lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = WBC?.IssuedElement;
                DateTimeOffset? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlQuantity lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Subtract(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, true, false);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default);
                Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = WBC?.StatusElement;
                ObservationStatus? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
                string lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                string[] lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<string>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as IEnumerable<string>);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = WBC?.Value;
                object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ is null));
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Observation @this)
            {
                Instant mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.IssuedElement;
                DateTimeOffset? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as object);

                return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SortBy<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
            Observation kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.First<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            Instant kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.IssuedElement;
            DateTimeOffset? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = (CqlTupleMetadata_ESFBYaBAeYMhOBFMjVCbeLhQA, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as CqlQuantity, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Risk Variable Heart Rate")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?> Risk_Variable_Heart_Rate(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Encounter TwentyWeeksPlusEncounter)
        {
            Id mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = TwentyWeeksPlusEncounter?.IdElement;
            string mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/heartrate"));
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Observation HeartRate)
            {
                DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = HeartRate?.Effective;
                object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Subtract(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, true, false);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default);
                Code<ObservationStatus> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = HeartRate?.StatusElement;
                ObservationStatus? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
                string nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                string[] nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<string>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as IEnumerable<string>);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Observation @this)
            {
                DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SortBy<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
            Observation mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.First<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
            CqlQuantity mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as Quantity);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Observation HeartRate)
            {
                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = HeartRate?.Effective;
                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Subtract(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, true, false);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default);
                Code<ObservationStatus> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = HeartRate?.StatusElement;
                ObservationStatus? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
                string ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<string>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                string[] ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<string>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as IEnumerable<string>);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Observation @this)
            {
                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = @this?.Effective;
                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SortBy<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, System.ComponentModel.ListSortDirection.Ascending);
            Observation nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.First<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Effective;
            object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = (CqlTupleMetadata_HOiMaDjifIOTXXFShNKiWLBLV, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlQuantity, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Risk Variable Systolic Blood Pressure")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?> Risk_Variable_Systolic_Blood_Pressure(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        (CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Encounter TwentyWeeksPlusEncounter)
        {
            Id ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = TwentyWeeksPlusEncounter?.IdElement;
            string ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Observation BP)
            {
                DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = BP?.Effective;
                object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlQuantity qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Subtract(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Interval(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, true, false);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default);
                Code<ObservationStatus> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = BP?.StatusElement;
                ObservationStatus? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
                string qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                string[] qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<string>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as IEnumerable<string>);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                List<Observation.ComponentComponent> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = BP?.Component;
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Observation.ComponentComponent @this)
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = @this?.Value;
                    object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                    bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ is null));

                    return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
                };
                IEnumerable<Observation.ComponentComponent> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Observation.ComponentComponent @this)
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = @this?.Value;
                    object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                    return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
                };
                IEnumerable<object> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Observation.ComponentComponent, object>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ is null));
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Observation>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Observation @this)
            {
                DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SortBy<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
            Observation pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.First<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            List<Observation.ComponentComponent> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Component;
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Observation.ComponentComponent C)
            {
                CodeableConcept rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = C?.Code;
                CqlConcept rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlCode rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Systolic_blood_pressure(context);
                CqlConcept rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertCodeToConcept(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Equivalent(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation.ComponentComponent> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlQuantity pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation.ComponentComponent C)
            {
                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = C?.Value;
                object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlQuantity;
            };
            IEnumerable<CqlQuantity> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Observation.ComponentComponent, CqlQuantity>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            IEnumerable<CqlQuantity> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<CqlQuantity>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Observation BP)
            {
                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = BP?.Effective;
                object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlQuantity rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Subtract(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, true, false);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default);
                Code<ObservationStatus> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = BP?.StatusElement;
                ObservationStatus? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
                string rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<string>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                string[] rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<string>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as IEnumerable<string>);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                List<Observation.ComponentComponent> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = BP?.Component;
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Observation.ComponentComponent @this)
                {
                    DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = @this?.Value;
                    object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                    bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ is null));

                    return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
                };
                IEnumerable<Observation.ComponentComponent> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Observation.ComponentComponent @this)
                {
                    DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Value;
                    object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                    return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
                };
                IEnumerable<object> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<Observation.ComponentComponent, object>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ is null));
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

                return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Observation>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Observation @this)
            {
                DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Effective;
                object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SortBy<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, System.ComponentModel.ListSortDirection.Ascending);
            Observation pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.First<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Effective;
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            (CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = (CqlTupleMetadata_FjSKXeIESORPNbRGajibMfUaK, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
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
