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
[CqlLibrary("AppropriateTestingforPharyngitisFHIR", "0.1.001")]
public partial class AppropriateTestingforPharyngitisFHIR_0_1_001 : ILibrary, ISingleton<AppropriateTestingforPharyngitisFHIR_0_1_001>
{
    private AppropriateTestingforPharyngitisFHIR_0_1_001() {}

    public static AppropriateTestingforPharyngitisFHIR_0_1_001 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "AppropriateTestingforPharyngitisFHIR";
    public string Version => "0.1.001";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, Hospice_6_12_000.Instance, Antibiotic_1_7_000.Instance, Status_1_8_000.Instance, QICoreCommon_2_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: Acute Pharyngitis
    [CqlValueSetDefinition(
        definitionName: "Acute Pharyngitis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1011",
        valueSetVersion: null)]
    public CqlValueSet Acute_Pharyngitis(CqlContext context) => _Acute_Pharyngitis;

    private static readonly CqlValueSet _Acute_Pharyngitis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1011", null);
    #endregion

    #region ValueSet: Acute Tonsillitis
    [CqlValueSetDefinition(
        definitionName: "Acute Tonsillitis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1012",
        valueSetVersion: null)]
    public CqlValueSet Acute_Tonsillitis(CqlContext context) => _Acute_Tonsillitis;

    private static readonly CqlValueSet _Acute_Tonsillitis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1012", null);
    #endregion

    #region ValueSet: Antibiotic Medications for Pharyngitis
    [CqlValueSetDefinition(
        definitionName: "Antibiotic Medications for Pharyngitis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Antibiotic_Medications_for_Pharyngitis(CqlContext context) => _Antibiotic_Medications_for_Pharyngitis;

    private static readonly CqlValueSet _Antibiotic_Medications_for_Pharyngitis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1001", null);
    #endregion

    #region ValueSet: Comorbid Conditions for Respiratory Conditions
    [CqlValueSetDefinition(
        definitionName: "Comorbid Conditions for Respiratory Conditions",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1025",
        valueSetVersion: null)]
    public CqlValueSet Comorbid_Conditions_for_Respiratory_Conditions(CqlContext context) => _Comorbid_Conditions_for_Respiratory_Conditions;

    private static readonly CqlValueSet _Comorbid_Conditions_for_Respiratory_Conditions = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1025", null);
    #endregion

    #region ValueSet: Competing Conditions for Respiratory Conditions
    [CqlValueSetDefinition(
        definitionName: "Competing Conditions for Respiratory Conditions",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1017",
        valueSetVersion: null)]
    public CqlValueSet Competing_Conditions_for_Respiratory_Conditions(CqlContext context) => _Competing_Conditions_for_Respiratory_Conditions;

    private static readonly CqlValueSet _Competing_Conditions_for_Respiratory_Conditions = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1017", null);
    #endregion

    #region ValueSet: Emergency Department Evaluation and Management Visit
    [CqlValueSetDefinition(
        definitionName: "Emergency Department Evaluation and Management Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010",
        valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Evaluation_and_Management_Visit(CqlContext context) => _Emergency_Department_Evaluation_and_Management_Visit;

    private static readonly CqlValueSet _Emergency_Department_Evaluation_and_Management_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", null);
    #endregion

    #region ValueSet: Group A Streptococcus Test
    [CqlValueSetDefinition(
        definitionName: "Group A Streptococcus Test",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1012",
        valueSetVersion: null)]
    public CqlValueSet Group_A_Streptococcus_Test(CqlContext context) => _Group_A_Streptococcus_Test;

    private static readonly CqlValueSet _Group_A_Streptococcus_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1012", null);
    #endregion

    #region ValueSet: Home Healthcare Services
    [CqlValueSetDefinition(
        definitionName: "Home Healthcare Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016",
        valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext context) => _Home_Healthcare_Services;

    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);
    #endregion

    #region ValueSet: Medical Disability Exam
    [CqlValueSetDefinition(
        definitionName: "Medical Disability Exam",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1073",
        valueSetVersion: null)]
    public CqlValueSet Medical_Disability_Exam(CqlContext context) => _Medical_Disability_Exam;

    private static readonly CqlValueSet _Medical_Disability_Exam = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1073", null);
    #endregion

    #region ValueSet: Office Visit
    [CqlValueSetDefinition(
        definitionName: "Office Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext context) => _Office_Visit;

    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);
    #endregion

    #region ValueSet: Outpatient Consultation
    [CqlValueSetDefinition(
        definitionName: "Outpatient Consultation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008",
        valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext context) => _Outpatient_Consultation;

    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);
    #endregion

    #region ValueSet: Preventive Care Services Established Office Visit, 18 and Up
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services Established Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext context) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;

    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);
    #endregion

    #region ValueSet: Preventive Care Services Group Counseling
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services Group Counseling",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Group_Counseling(CqlContext context) => _Preventive_Care_Services_Group_Counseling;

    private static readonly CqlValueSet _Preventive_Care_Services_Group_Counseling = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027", null);
    #endregion

    #region ValueSet: Preventive Care Services Individual Counseling
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services Individual Counseling",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Individual_Counseling(CqlContext context) => _Preventive_Care_Services_Individual_Counseling;

    private static readonly CqlValueSet _Preventive_Care_Services_Individual_Counseling = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", null);
    #endregion

    #region ValueSet: Preventive Care Services Initial Office Visit, 18 and Up
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services Initial Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;

    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);
    #endregion

    #region ValueSet: Preventive Care Services, Initial Office Visit, 0 to 17
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services, Initial Office Visit, 0 to 17",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext context) => _Preventive_Care_Services__Initial_Office_Visit__0_to_17;

    private static readonly CqlValueSet _Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);
    #endregion

    #region ValueSet: Preventive Care, Established Office Visit, 0 to 17
    [CqlValueSetDefinition(
        definitionName: "Preventive Care, Established Office Visit, 0 to 17",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext context) => _Preventive_Care__Established_Office_Visit__0_to_17;

    private static readonly CqlValueSet _Preventive_Care__Established_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);
    #endregion

    #region ValueSet: Telephone Visits
    [CqlValueSetDefinition(
        definitionName: "Telephone Visits",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080",
        valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext context) => _Telephone_Visits;

    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);
    #endregion

    #region ValueSet: Virtual Encounter
    [CqlValueSetDefinition(
        definitionName: "Virtual Encounter",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089",
        valueSetVersion: null)]
    public CqlValueSet Virtual_Encounter(CqlContext context) => _Virtual_Encounter;

    private static readonly CqlValueSet _Virtual_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Unlisted preventive medicine service
    [CqlCodeDefinition(
        definitionName: "Unlisted preventive medicine service",
        codeId: "99429",
        codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Unlisted_preventive_medicine_service(CqlContext context) => _Unlisted_preventive_medicine_service;

    private static readonly CqlCode _Unlisted_preventive_medicine_service = new CqlCode("99429", "http://www.ama-assn.org/go/cpt", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "CPT")]
    public CqlCode[] CPT(CqlContext context)
    {
        CqlCode[] izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = [
            new CqlCode("99429", "http://www.ama-assn.org/go/cpt", default, default),
        ];

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, true, true);
        object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.ResolveParameter("AppropriateTestingforPharyngitisFHIR-0.1.001", "Measurement Period", izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return (CqlInterval<CqlDateTime>)izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SingletonFrom<Patient>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Emergency_Department_Evaluation_and_Management_Visit(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Medical_Disability_Exam(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Office_Visit(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Preventive_Care_Services_Group_Counseling(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Encounter E)
        {
            List<CodeableConcept> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = E?.Type;
            CqlConcept kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(CodeableConcept @this)
            {
                CqlConcept kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<CqlConcept> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(CqlConcept T)
            {
                CqlCode kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Unlisted_preventive_medicine_service(context);
                CqlConcept kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertCodeToConcept(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equivalent(T, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<CqlConcept> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<CqlConcept>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<CqlConcept>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = Status_1_8_000.Instance.isEncounterPerformed(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Encounter ValidEncounter)
        {
            Period lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as object);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.End(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.End(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlQuantity lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(3m, "days");
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Subtract(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, true, true);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, "day");

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter With Antibiotic Ordered Within Three Days")]
    public IEnumerable<Encounter> Encounter_With_Antibiotic_Ordered_Within_Three_Days(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Qualifying_Encounters(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Encounter EDOrAmbulatoryVisit)
        {
            CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Antibiotic_Medications_for_Pharyngitis(context);
            IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<MedicationRequest>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = Status_1_8_000.Instance.isMedicationOrder(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(MedicationRequest AntibioticOrdered)
            {
                Period lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = EDOrAmbulatoryVisit?.Period;
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as object);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                FhirDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = AntibioticOrdered?.AuthoredOnElement;
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlQuantity mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(3m, "days");
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Subtract(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, true, true);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "day");
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ is null));
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<MedicationRequest>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            Encounter lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(MedicationRequest AntibioticOrdered) =>
                EDOrAmbulatoryVisit;
            IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<MedicationRequest, Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SelectMany<Encounter, Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Pharyngitis or Tonsillitis")]
    public IEnumerable<Condition> Pharyngitis_or_Tonsillitis(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Acute_Pharyngitis(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Acute_Tonsillitis(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Condition>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter With Pharyngitis or Tonsillitis With Antibiotic")]
    public IEnumerable<Encounter> Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Encounter_With_Antibiotic_Ordered_Within_Three_Days(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Pharyngitis_or_Tonsillitis(context);
        IEnumerable<ValueTuple<Encounter, Condition>> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.CrossJoin<Encounter, Condition>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        (CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(ValueTuple<Encounter, Condition> _valueTuple)
        {
            (CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = (CqlTupleMetadata_BHcMAQBSeFPCjbDEhaVDLJXQU, _valueTuple.Item1, _valueTuple.Item2);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)?> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<ValueTuple<Encounter, Condition>, (CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)?>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_((CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)? tuple_ypyxedbbcqbdavhxvckuwmfh)
        {
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, tuple_ypyxedbbcqbdavhxvckuwmfh?.AcutePharyngitisTonsillitis);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            Period nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = tuple_ypyxedbbcqbdavhxvckuwmfh?.VisitWithAntibiotic?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as object);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "day");

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)?> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<(CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)?>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        Encounter nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_((CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)? tuple_ypyxedbbcqbdavhxvckuwmfh) =>
            tuple_ypyxedbbcqbdavhxvckuwmfh?.VisitWithAntibiotic;
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<(CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)?, Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Distinct<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Encounter EncounterWithPharyngitis)
        {
            Patient nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Patient(context);
            Date nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.BirthDateElement;
            string nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
            CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertStringToDate(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            int? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.CalculateAgeAt(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "year");
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.GreaterOrEqual(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, 3);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        Encounter nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Encounter EncounterWithPharyngitis) =>
            EncounterWithPharyngitis;
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Encounter, Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Initial_Population(context);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounters and Assessments with Hospice Patient")]
    public IEnumerable<Encounter> Encounters_and_Assessments_with_Hospice_Patient(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Initial_Population(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Encounter EligibleEncounters)
        {
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Encounters_and_Assessments_with_Hospice_Patient(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Comorbid_Conditions_for_Respiratory_Conditions(context);
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = Antibiotic_1_7_000.Instance.Has_Comorbid_Condition_History(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Antibiotic_Medications_for_Pharyngitis(context);
        IEnumerable<MedicationRequest> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<MedicationRequest>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<MedicationRequest> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = Status_1_8_000.Instance.isMedicationActive(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = Antibiotic_1_7_000.Instance.Has_Antibiotic_Medication_History(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Competing_Conditions_for_Respiratory_Conditions(context);
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = Antibiotic_1_7_000.Instance.Has_Competing_Diagnosis_History(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "Group A Streptococcus Lab Test With Result")]
    public IEnumerable<Observation> Group_A_Streptococcus_Lab_Test_With_Result(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Group_A_Streptococcus_Test(context);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = Status_1_8_000.Instance.isLaboratoryTestPerformed(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Observation GroupAStreptococcusTest)
        {
            DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = GroupAStreptococcusTest?.Value;
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ is null));

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Group_A_Streptococcus_Lab_Test_With_Result(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);
        IEnumerable<ValueTuple<Observation, Encounter>> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.CrossJoin<Observation, Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        (CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(ValueTuple<Observation, Encounter> _valueTuple)
        {
            (CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = (CqlTupleMetadata_FeNRUFDKGVUFAMiQLLieSFHIV, _valueTuple.Item1, _valueTuple.Item2);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)?> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<ValueTuple<Observation, Encounter>, (CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)?>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_((CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)? tuple_ffguysnebcxllexfcmjoehbij)
        {
            DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = tuple_ffguysnebcxllexfcmjoehbij?.GroupAStreptococcusTest?.Effective;
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            Period pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = tuple_ffguysnebcxllexfcmjoehbij?.EncounterWithPharyngitis?.Period;
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.End(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlQuantity pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(3m, "days");
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Subtract(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.End(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Add(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, true, true);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, "day");

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)?> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<(CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)?>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        Encounter pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_((CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)? tuple_ffguysnebcxllexfcmjoehbij) =>
            tuple_ffguysnebcxllexfcmjoehbij?.EncounterWithPharyngitis;
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)?, Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Stratification 1")]
    public IEnumerable<Encounter> Stratification_1(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Encounter EncounterWithPharyngitis)
        {
            Patient qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Patient(context);
            Date qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.BirthDateElement;
            string qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
            CqlDate qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConvertStringToDate(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDate qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            int? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.CalculateAgeAt(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "year");
            CqlInterval<int?> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(3, 17, true, true);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<int?>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        Encounter qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Encounter EncounterWithPharyngitis) =>
            EncounterWithPharyngitis;
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<Encounter, Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Distinct<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Stratification 2")]
    public IEnumerable<Encounter> Stratification_2(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Encounter EncounterWithPharyngitis)
        {
            Patient rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Patient(context);
            Date rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.BirthDateElement;
            string rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertStringToDate(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            int? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.CalculateAgeAt(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, "year");
            CqlInterval<int?> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(18, 64, true, true);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<int?>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        Encounter rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Encounter EncounterWithPharyngitis) =>
            EncounterWithPharyngitis;
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<Encounter, Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Distinct<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Stratification 3")]
    public IEnumerable<Encounter> Stratification_3(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Encounter EncounterWithPharyngitis)
        {
            Patient rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Patient(context);
            Date rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.BirthDateElement;
            string rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConvertStringToDate(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDate szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            int? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.CalculateAgeAt(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "year");
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.GreaterOrEqual(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, 65);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        Encounter rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Encounter EncounterWithPharyngitis) =>
            EncounterWithPharyngitis;
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Encounter, Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_BHcMAQBSeFPCjbDEhaVDLJXQU = new(
        [typeof(Encounter), typeof(Condition)],
        ["VisitWithAntibiotic", "AcutePharyngitisTonsillitis"]);

    private static CqlTupleMetadata CqlTupleMetadata_FeNRUFDKGVUFAMiQLLieSFHIV = new(
        [typeof(Observation), typeof(Encounter)],
        ["GroupAStreptococcusTest", "EncounterWithPharyngitis"]);

    #endregion CqlTupleMetadata Properties

}
