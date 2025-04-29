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
[CqlLibrary("AppropriateTreatmentforUpperRespiratoryInfectionURIFHIR", "0.1.001")]
public partial class AppropriateTreatmentforUpperRespiratoryInfectionURIFHIR_0_1_001 : ILibrary, ISingleton<AppropriateTreatmentforUpperRespiratoryInfectionURIFHIR_0_1_001>
{
    private AppropriateTreatmentforUpperRespiratoryInfectionURIFHIR_0_1_001() {}

    public static AppropriateTreatmentforUpperRespiratoryInfectionURIFHIR_0_1_001 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "AppropriateTreatmentforUpperRespiratoryInfectionURIFHIR";
    public string Version => "0.1.001";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, Hospice_6_12_000.Instance, Status_1_8_000.Instance, QICoreCommon_2_1_000.Instance, Antibiotic_1_7_000.Instance];

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

    #region ValueSet: Antibiotic Medications for Upper Respiratory Infection
    [CqlValueSetDefinition(
        definitionName: "Antibiotic Medications for Upper Respiratory Infection",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Antibiotic_Medications_for_Upper_Respiratory_Infection(CqlContext context) => _Antibiotic_Medications_for_Upper_Respiratory_Infection;

    private static readonly CqlValueSet _Antibiotic_Medications_for_Upper_Respiratory_Infection = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1001", null);
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

    #region ValueSet: Upper Respiratory Infection
    [CqlValueSetDefinition(
        definitionName: "Upper Respiratory Infection",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1022",
        valueSetVersion: null)]
    public CqlValueSet Upper_Respiratory_Infection(CqlContext context) => _Upper_Respiratory_Infection;

    private static readonly CqlValueSet _Upper_Respiratory_Infection = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1022", null);
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
        CqlCode[] fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = [
            new CqlCode("99429", "http://www.ama-assn.org/go/cpt", default, default),
        ];

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, true, true);
        object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.ResolveParameter("AppropriateTreatmentforUpperRespiratoryInfectionURIFHIR-0.1.001", "Measurement Period", fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return (CqlInterval<CqlDateTime>)fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SingletonFrom<Patient>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Emergency_Department_Evaluation_and_Management_Visit(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Medical_Disability_Exam(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Office_Visit(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Preventive_Care_Services_Group_Counseling(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<Encounter>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Encounter E)
        {
            List<CodeableConcept> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = E?.Type;
            CqlConcept hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(CodeableConcept @this)
            {
                CqlConcept hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<CqlConcept> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(CqlConcept T)
            {
                CqlCode hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Unlisted_preventive_medicine_service(context);
                CqlConcept hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertCodeToConcept(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Equivalent(T, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<CqlConcept> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<CqlConcept>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<CqlConcept>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = Status_1_8_000.Instance.isEncounterPerformed(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Encounter ValidEncounter)
        {
            Period hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as object);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.End(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Measurement_Period(context);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.End(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlQuantity izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(3m, "days");
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Subtract(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, true, true);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "day");

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Upper Respiratory Infection")]
    public IEnumerable<Encounter> Encounter_with_Upper_Respiratory_Infection(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Qualifying_Encounters(context);
        CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Upper_Respiratory_Infection(context);
        IEnumerable<Condition> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<ValueTuple<Encounter, Condition>> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.CrossJoin<Encounter, Condition>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        (CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(ValueTuple<Encounter, Condition> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = (CqlTupleMetadata_FiGMIRiNMNcaAVFKbMahDKTce, _valueTuple.Item1, _valueTuple.Item2);

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)?> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<ValueTuple<Encounter, Condition>, (CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)?>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_((CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)? tuple_figmirinmncaavfkbmahdktce)
        {
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, tuple_figmirinmncaavfkbmahdktce?.URI);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            Period izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = tuple_figmirinmncaavfkbmahdktce?.QualifyingEncounters?.Period;
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as object);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "day");
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ as object);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.OverlapsBefore(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)?> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)?>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        Encounter izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_((CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)? tuple_figmirinmncaavfkbmahdktce) =>
            tuple_figmirinmncaavfkbmahdktce?.QualifyingEncounters;
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)?, Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Encounter_with_Upper_Respiratory_Infection(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Encounter EncounterWithURI)
        {
            Patient jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Patient(context);
            Date jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.BirthDateElement;
            string jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
            CqlDate jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertStringToDate(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDate jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            int? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.CalculateAgeAt(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "month");
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.GreaterOrEqual(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, 3);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        Encounter jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Encounter EncounterWithURI) =>
            EncounterWithURI;
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Encounter, Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Distinct<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounters and Assessments with Hospice Patient")]
    public IEnumerable<Encounter> Encounters_and_Assessments_with_Hospice_Patient(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Initial_Population(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Encounter EligibleEncounters)
        {
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Initial_Population(context);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Encounters_and_Assessments_with_Hospice_Patient(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Encounter_with_Upper_Respiratory_Infection(context);
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Comorbid_Conditions_for_Respiratory_Conditions(context);
        IEnumerable<Condition> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = Antibiotic_1_7_000.Instance.Has_Comorbid_Condition_History(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Antibiotic_Medications_for_Upper_Respiratory_Infection(context);
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<MedicationRequest>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = Antibiotic_1_7_000.Instance.Has_Antibiotic_Medication_History(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Competing_Conditions_for_Respiratory_Conditions(context);
        IEnumerable<Condition> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Acute_Pharyngitis(context);
        IEnumerable<Condition> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Condition>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Acute_Tonsillitis(context);
        IEnumerable<Condition> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Condition>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = Antibiotic_1_7_000.Instance.Has_Competing_Diagnosis_History(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Encounter_with_Upper_Respiratory_Infection(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Encounter EncounterWithURI)
        {
            CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Antibiotic_Medications_for_Upper_Respiratory_Infection(context);
            IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<MedicationRequest>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = Status_1_8_000.Instance.isMedicationOrder(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(MedicationRequest OrderedAntibiotic)
            {
                FhirDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = OrderedAntibiotic?.AuthoredOnElement;
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                Period lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = EncounterWithURI?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as object);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as object);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlQuantity mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(3m, "days");
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Add(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, true, true);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as object);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is null));
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<MedicationRequest>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            Encounter lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(MedicationRequest OrderedAntibiotic) =>
                EncounterWithURI;
            IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<MedicationRequest, Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SelectMany<Encounter, Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Except<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        Encounter lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Encounter EncounterWithURI) =>
            EncounterWithURI;
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Encounter, Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Distinct<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Stratification 1")]
    public IEnumerable<Encounter> Stratification_1(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Encounter_with_Upper_Respiratory_Infection(context);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Encounter EncounterWithURI)
        {
            Patient mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Patient(context);
            Date mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.BirthDateElement;
            string mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertStringToDate(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            int? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.CalculateAgeAt(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "month");
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.GreaterOrEqual(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, 3);
            Date nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.BirthDateElement;
            string nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
            CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertStringToDate(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            int? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.CalculateAgeAt(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "year");
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.LessOrEqual(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, 17);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        Encounter mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Encounter EncounterWithURI) =>
            EncounterWithURI;
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Encounter, Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Distinct<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Stratification 2")]
    public IEnumerable<Encounter> Stratification_2(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Encounter_with_Upper_Respiratory_Infection(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Encounter EncounterWithURI)
        {
            Patient nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Patient(context);
            Date nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.BirthDateElement;
            string nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
            CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertStringToDate(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            int? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.CalculateAgeAt(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "year");
            CqlInterval<int?> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(18, 64, true, true);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<int?>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        Encounter nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Encounter EncounterWithURI) =>
            EncounterWithURI;
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Encounter, Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Stratification 3")]
    public IEnumerable<Encounter> Stratification_3(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Encounter_with_Upper_Respiratory_Infection(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Encounter EncounterWithURI)
        {
            Patient ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Patient(context);
            Date ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.BirthDateElement;
            string ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertStringToDate(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            int? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.CalculateAgeAt(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "year");
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.GreaterOrEqual(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, 65);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        Encounter ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Encounter EncounterWithURI) =>
            EncounterWithURI;
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<Encounter, Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Distinct<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_FiGMIRiNMNcaAVFKbMahDKTce = new(
        [typeof(Encounter), typeof(Condition)],
        ["QualifyingEncounters", "URI"]);

    #endregion CqlTupleMetadata Properties

}
