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

    [CqlValueSetDefinition("Acute Pharyngitis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1011", valueSetVersion: null)]
    public CqlValueSet Acute_Pharyngitis(CqlContext _) => _Acute_Pharyngitis;
    private static readonly CqlValueSet _Acute_Pharyngitis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1011", null);

    [CqlValueSetDefinition("Acute Tonsillitis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1012", valueSetVersion: null)]
    public CqlValueSet Acute_Tonsillitis(CqlContext _) => _Acute_Tonsillitis;
    private static readonly CqlValueSet _Acute_Tonsillitis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1012", null);

    [CqlValueSetDefinition("Antibiotic Medications for Upper Respiratory Infection", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1001", valueSetVersion: null)]
    public CqlValueSet Antibiotic_Medications_for_Upper_Respiratory_Infection(CqlContext _) => _Antibiotic_Medications_for_Upper_Respiratory_Infection;
    private static readonly CqlValueSet _Antibiotic_Medications_for_Upper_Respiratory_Infection = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1001", null);

    [CqlValueSetDefinition("Comorbid Conditions for Respiratory Conditions", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1025", valueSetVersion: null)]
    public CqlValueSet Comorbid_Conditions_for_Respiratory_Conditions(CqlContext _) => _Comorbid_Conditions_for_Respiratory_Conditions;
    private static readonly CqlValueSet _Comorbid_Conditions_for_Respiratory_Conditions = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1025", null);

    [CqlValueSetDefinition("Competing Conditions for Respiratory Conditions", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1017", valueSetVersion: null)]
    public CqlValueSet Competing_Conditions_for_Respiratory_Conditions(CqlContext _) => _Competing_Conditions_for_Respiratory_Conditions;
    private static readonly CqlValueSet _Competing_Conditions_for_Respiratory_Conditions = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1017", null);

    [CqlValueSetDefinition("Emergency Department Evaluation and Management Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Evaluation_and_Management_Visit(CqlContext _) => _Emergency_Department_Evaluation_and_Management_Visit;
    private static readonly CqlValueSet _Emergency_Department_Evaluation_and_Management_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("Medical Disability Exam", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1073", valueSetVersion: null)]
    public CqlValueSet Medical_Disability_Exam(CqlContext _) => _Medical_Disability_Exam;
    private static readonly CqlValueSet _Medical_Disability_Exam = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1073", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Outpatient Consultation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext _) => _Outpatient_Consultation;
    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlValueSetDefinition("Preventive Care Services Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services Group Counseling", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Group_Counseling(CqlContext _) => _Preventive_Care_Services_Group_Counseling;
    private static readonly CqlValueSet _Preventive_Care_Services_Group_Counseling = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027", null);

    [CqlValueSetDefinition("Preventive Care Services Individual Counseling", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Individual_Counseling(CqlContext _) => _Preventive_Care_Services_Individual_Counseling;
    private static readonly CqlValueSet _Preventive_Care_Services_Individual_Counseling = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", null);

    [CqlValueSetDefinition("Preventive Care Services Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("Preventive Care Services, Initial Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care_Services__Initial_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);

    [CqlValueSetDefinition("Preventive Care, Established Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", valueSetVersion: null)]
    public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care__Established_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care__Established_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlValueSetDefinition("Upper Respiratory Infection", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1022", valueSetVersion: null)]
    public CqlValueSet Upper_Respiratory_Infection(CqlContext _) => _Upper_Respiratory_Infection;
    private static readonly CqlValueSet _Upper_Respiratory_Infection = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1022", null);

    [CqlValueSetDefinition("Virtual Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", valueSetVersion: null)]
    public CqlValueSet Virtual_Encounter(CqlContext _) => _Virtual_Encounter;
    private static readonly CqlValueSet _Virtual_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Unlisted preventive medicine service", codeId: "99429", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Unlisted_preventive_medicine_service(CqlContext _) => _Unlisted_preventive_medicine_service;
    private static readonly CqlCode _Unlisted_preventive_medicine_service = new CqlCode("99429", "http://www.ama-assn.org/go/cpt", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("CPT")]
    public CqlCodeSystem CPT(CqlContext _) => _CPT;
    private static readonly CqlCodeSystem _CPT = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime kzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime kzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzzf_, kzzzzzzzzzzzzzzzzzzg_, true, true);
        object kzzzzzzzzzzzzzzzzzzi_ = context.ResolveParameter("AppropriateTreatmentforUpperRespiratoryInfectionURIFHIR-0.1.001", "Measurement Period", kzzzzzzzzzzzzzzzzzzh_);

        return (CqlInterval<CqlDateTime>)kzzzzzzzzzzzzzzzzzzi_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> kzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient kzzzzzzzzzzzzzzzzzzk_ = context.Operators.SingletonFrom<Patient>(kzzzzzzzzzzzzzzzzzzj_);

        return kzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? kzzzzzzzzzzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return kzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> kzzzzzzzzzzzzzzzzzzm_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return kzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? kzzzzzzzzzzzzzzzzzzn_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return kzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode kzzzzzzzzzzzzzzzzzzo_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return kzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzzzzp_ = this.Emergency_Department_Evaluation_and_Management_Visit(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet kzzzzzzzzzzzzzzzzzzr_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(kzzzzzzzzzzzzzzzzzzq_, kzzzzzzzzzzzzzzzzzzs_);
        CqlValueSet kzzzzzzzzzzzzzzzzzzu_ = this.Medical_Disability_Exam(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet kzzzzzzzzzzzzzzzzzzw_ = this.Office_Visit(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(kzzzzzzzzzzzzzzzzzzv_, kzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Encounter>(kzzzzzzzzzzzzzzzzzzt_, kzzzzzzzzzzzzzzzzzzy_);
        CqlValueSet lzzzzzzzzzzzzzzzzzza_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet lzzzzzzzzzzzzzzzzzzc_ = this.Preventive_Care_Services_Group_Counseling(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(lzzzzzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(kzzzzzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzzzzzze_);
        CqlValueSet lzzzzzzzzzzzzzzzzzzg_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet lzzzzzzzzzzzzzzzzzzi_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(lzzzzzzzzzzzzzzzzzzh_, lzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(lzzzzzzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzzzzzzk_);
        CqlValueSet lzzzzzzzzzzzzzzzzzzm_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet lzzzzzzzzzzzzzzzzzzo_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(lzzzzzzzzzzzzzzzzzzn_, lzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(lzzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzzq_);
        CqlValueSet lzzzzzzzzzzzzzzzzzzs_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet lzzzzzzzzzzzzzzzzzzu_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(lzzzzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(lzzzzzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzzzzzw_);
        CqlValueSet lzzzzzzzzzzzzzzzzzzy_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? mzzzzzzzzzzzzzzzzzzb_(Encounter E)
        {
            List<CodeableConcept> mzzzzzzzzzzzzzzzzzzi_ = E?.Type;
            CqlConcept mzzzzzzzzzzzzzzzzzzj_(CodeableConcept @this)
            {
                CqlConcept mzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return mzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<CqlConcept> mzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)mzzzzzzzzzzzzzzzzzzi_, mzzzzzzzzzzzzzzzzzzj_);
            bool? mzzzzzzzzzzzzzzzzzzl_(CqlConcept T)
            {
                CqlCode mzzzzzzzzzzzzzzzzzzp_ = this.Unlisted_preventive_medicine_service(context);
                CqlConcept mzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertCodeToConcept(mzzzzzzzzzzzzzzzzzzp_);
                bool? mzzzzzzzzzzzzzzzzzzr_ = context.Operators.Equivalent(T, mzzzzzzzzzzzzzzzzzzq_);

                return mzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<CqlConcept> mzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<CqlConcept>(mzzzzzzzzzzzzzzzzzzk_, mzzzzzzzzzzzzzzzzzzl_);
            bool? mzzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<CqlConcept>(mzzzzzzzzzzzzzzzzzzm_);

            return mzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzzzzzzzza_, mzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(lzzzzzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(lzzzzzzzzzzzzzzzzzzx_, mzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzf_ = Status_1_8_000.Instance.isEncounterPerformed(context, mzzzzzzzzzzzzzzzzzze_);
        bool? mzzzzzzzzzzzzzzzzzzg_(Encounter ValidEncounter)
        {
            Period mzzzzzzzzzzzzzzzzzzs_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzt_ as object);
            CqlDateTime mzzzzzzzzzzzzzzzzzzv_ = context.Operators.End(mzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzw_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzz_ = context.Operators.End(mzzzzzzzzzzzzzzzzzzw_);
            CqlQuantity nzzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(3m, "days");
            CqlDateTime nzzzzzzzzzzzzzzzzzzb_ = context.Operators.Subtract(mzzzzzzzzzzzzzzzzzzz_, nzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzzzx_, nzzzzzzzzzzzzzzzzzzb_, true, true);
            bool? nzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzzzzc_, "day");

            return nzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzzzzzzzzf_, mzzzzzzzzzzzzzzzzzzg_);

        return mzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Encounter with Upper Respiratory Infection")]
    public IEnumerable<Encounter> Encounter_with_Upper_Respiratory_Infection(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzze_ = this.Qualifying_Encounters(context);
        CqlValueSet nzzzzzzzzzzzzzzzzzzf_ = this.Upper_Respiratory_Infection(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<ValueTuple<Encounter, Condition>> nzzzzzzzzzzzzzzzzzzh_ = context.Operators.CrossJoin<Encounter, Condition>(nzzzzzzzzzzzzzzzzzze_, nzzzzzzzzzzzzzzzzzzg_);
        (CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)? nzzzzzzzzzzzzzzzzzzi_(ValueTuple<Encounter, Condition> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)? nzzzzzzzzzzzzzzzzzzp_ = (CqlTupleMetadata_FiGMIRiNMNcaAVFKbMahDKTce, _valueTuple.Item1, _valueTuple.Item2);

            return nzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)?> nzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<ValueTuple<Encounter, Condition>, (CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)?>(nzzzzzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzzzzzi_);
        bool? nzzzzzzzzzzzzzzzzzzk_((CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)? tuple_figmirinmncaavfkbmahdktce)
        {
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, tuple_figmirinmncaavfkbmahdktce?.URI);
            CqlDateTime nzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzq_);
            Period nzzzzzzzzzzzzzzzzzzs_ = tuple_figmirinmncaavfkbmahdktce?.QualifyingEncounters?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzt_ as object);
            bool? nzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzzu_, "day");
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzy_ as object);
            bool? ozzzzzzzzzzzzzzzzzza_ = context.Operators.OverlapsBefore(nzzzzzzzzzzzzzzzzzzq_, nzzzzzzzzzzzzzzzzzzz_, default);
            bool? ozzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(nzzzzzzzzzzzzzzzzzzv_, ozzzzzzzzzzzzzzzzzza_);

            return ozzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)?> nzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)?>(nzzzzzzzzzzzzzzzzzzj_, nzzzzzzzzzzzzzzzzzzk_);
        Encounter nzzzzzzzzzzzzzzzzzzm_((CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)? tuple_figmirinmncaavfkbmahdktce) =>
            tuple_figmirinmncaavfkbmahdktce?.QualifyingEncounters;
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)?, Encounter>(nzzzzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<Encounter>(nzzzzzzzzzzzzzzzzzzn_);

        return nzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzc_ = this.Encounter_with_Upper_Respiratory_Infection(context);
        bool? ozzzzzzzzzzzzzzzzzzd_(Encounter EncounterWithURI)
        {
            Patient ozzzzzzzzzzzzzzzzzzi_ = this.Patient(context);
            Date ozzzzzzzzzzzzzzzzzzj_ = ozzzzzzzzzzzzzzzzzzi_?.BirthDateElement;
            string ozzzzzzzzzzzzzzzzzzk_ = ozzzzzzzzzzzzzzzzzzj_?.Value;
            CqlDate ozzzzzzzzzzzzzzzzzzl_ = context.Operators.ConvertStringToDate(ozzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
            CqlDateTime ozzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzm_);
            CqlDate ozzzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzn_);
            int? ozzzzzzzzzzzzzzzzzzp_ = context.Operators.CalculateAgeAt(ozzzzzzzzzzzzzzzzzzl_, ozzzzzzzzzzzzzzzzzzo_, "month");
            bool? ozzzzzzzzzzzzzzzzzzq_ = context.Operators.GreaterOrEqual(ozzzzzzzzzzzzzzzzzzp_, 3);

            return ozzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzzzzc_, ozzzzzzzzzzzzzzzzzzd_);
        Encounter ozzzzzzzzzzzzzzzzzzf_(Encounter EncounterWithURI) =>
            EncounterWithURI;
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Encounter, Encounter>(ozzzzzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzzzzf_);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzh_ = context.Operators.Distinct<Encounter>(ozzzzzzzzzzzzzzzzzzg_);

        return ozzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Encounters and Assessments with Hospice Patient")]
    public IEnumerable<Encounter> Encounters_and_Assessments_with_Hospice_Patient(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzr_ = this.Initial_Population(context);
        bool? ozzzzzzzzzzzzzzzzzzs_(Encounter EligibleEncounters)
        {
            bool? ozzzzzzzzzzzzzzzzzzu_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);

            return ozzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzzzzr_, ozzzzzzzzzzzzzzzzzzs_);

        return ozzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzv_ = this.Initial_Population(context);

        return ozzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzw_ = this.Encounters_and_Assessments_with_Hospice_Patient(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzx_ = this.Encounter_with_Upper_Respiratory_Infection(context);
        CqlValueSet ozzzzzzzzzzzzzzzzzzy_ = this.Comorbid_Conditions_for_Respiratory_Conditions(context);
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzza_ = Antibiotic_1_7_000.Instance.Has_Comorbid_Condition_History(context, ozzzzzzzzzzzzzzzzzzx_, ozzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzzzzzzzzw_, pzzzzzzzzzzzzzzzzzza_);
        CqlValueSet pzzzzzzzzzzzzzzzzzzd_ = this.Antibiotic_Medications_for_Upper_Respiratory_Infection(context);
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<MedicationRequest>(pzzzzzzzzzzzzzzzzzze_, pzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzi_ = Antibiotic_1_7_000.Instance.Has_Antibiotic_Medication_History(context, ozzzzzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzzzzzh_);
        CqlValueSet pzzzzzzzzzzzzzzzzzzk_ = this.Competing_Conditions_for_Respiratory_Conditions(context);
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet pzzzzzzzzzzzzzzzzzzm_ = this.Acute_Pharyngitis(context);
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Condition>(pzzzzzzzzzzzzzzzzzzl_, pzzzzzzzzzzzzzzzzzzn_);
        CqlValueSet pzzzzzzzzzzzzzzzzzzp_ = this.Acute_Tonsillitis(context);
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Condition>(pzzzzzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzs_ = Antibiotic_1_7_000.Instance.Has_Competing_Diagnosis_History(context, ozzzzzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzzzzzzi_, pzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzzzzzt_);

        return pzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzv_ = this.Encounter_with_Upper_Respiratory_Infection(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzx_(Encounter EncounterWithURI)
        {
            CqlValueSet qzzzzzzzzzzzzzzzzzzd_ = this.Antibiotic_Medications_for_Upper_Respiratory_Infection(context);
            IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<MedicationRequest>(qzzzzzzzzzzzzzzzzzze_, qzzzzzzzzzzzzzzzzzzg_);
            IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzi_ = Status_1_8_000.Instance.isMedicationOrder(context, qzzzzzzzzzzzzzzzzzzh_);
            bool? qzzzzzzzzzzzzzzzzzzj_(MedicationRequest OrderedAntibiotic)
            {
                FhirDateTime qzzzzzzzzzzzzzzzzzzn_ = OrderedAntibiotic?.AuthoredOnElement;
                CqlDateTime qzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<CqlDateTime>(qzzzzzzzzzzzzzzzzzzn_);
                Period qzzzzzzzzzzzzzzzzzzp_ = EncounterWithURI?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzq_ as object);
                CqlDateTime qzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzu_ as object);
                CqlDateTime qzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzv_);
                CqlQuantity qzzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(3m, "days");
                CqlDateTime qzzzzzzzzzzzzzzzzzzy_ = context.Operators.Add(qzzzzzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(qzzzzzzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzzzzzzy_, true, true);
                bool? rzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzzzzzzz_, default);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzc_ as object);
                CqlDateTime rzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzd_);
                bool? rzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzzzzzze_ is null));
                bool? rzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(rzzzzzzzzzzzzzzzzzza_, rzzzzzzzzzzzzzzzzzzf_);

                return rzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<MedicationRequest>(qzzzzzzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzzzzzzj_);
            Encounter qzzzzzzzzzzzzzzzzzzl_(MedicationRequest OrderedAntibiotic) =>
                EncounterWithURI;
            IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<MedicationRequest, Encounter>(qzzzzzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzzzzzl_);

            return qzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzy_ = context.Operators.SelectMany<Encounter, Encounter>(pzzzzzzzzzzzzzzzzzzv_, pzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzz_ = context.Operators.Except<Encounter>(pzzzzzzzzzzzzzzzzzzv_, pzzzzzzzzzzzzzzzzzzy_);
        Encounter qzzzzzzzzzzzzzzzzzza_(Encounter EncounterWithURI) =>
            EncounterWithURI;
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<Encounter, Encounter>(pzzzzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzc_ = context.Operators.Distinct<Encounter>(qzzzzzzzzzzzzzzzzzzb_);

        return qzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Stratification 1")]
    public IEnumerable<Encounter> Stratification_1(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzh_ = this.Encounter_with_Upper_Respiratory_Infection(context);
        bool? rzzzzzzzzzzzzzzzzzzi_(Encounter EncounterWithURI)
        {
            Patient rzzzzzzzzzzzzzzzzzzn_ = this.Patient(context);
            Date rzzzzzzzzzzzzzzzzzzo_ = rzzzzzzzzzzzzzzzzzzn_?.BirthDateElement;
            string rzzzzzzzzzzzzzzzzzzp_ = rzzzzzzzzzzzzzzzzzzo_?.Value;
            CqlDate rzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertStringToDate(rzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            CqlDateTime rzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzr_);
            CqlDate rzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzs_);
            int? rzzzzzzzzzzzzzzzzzzu_ = context.Operators.CalculateAgeAt(rzzzzzzzzzzzzzzzzzzq_, rzzzzzzzzzzzzzzzzzzt_, "month");
            bool? rzzzzzzzzzzzzzzzzzzv_ = context.Operators.GreaterOrEqual(rzzzzzzzzzzzzzzzzzzu_, 3);
            Date rzzzzzzzzzzzzzzzzzzx_ = rzzzzzzzzzzzzzzzzzzn_?.BirthDateElement;
            string rzzzzzzzzzzzzzzzzzzy_ = rzzzzzzzzzzzzzzzzzzx_?.Value;
            CqlDate rzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertStringToDate(rzzzzzzzzzzzzzzzzzzy_);
            CqlDateTime szzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzr_);
            CqlDate szzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzzzb_);
            int? szzzzzzzzzzzzzzzzzzd_ = context.Operators.CalculateAgeAt(rzzzzzzzzzzzzzzzzzzz_, szzzzzzzzzzzzzzzzzzc_, "year");
            bool? szzzzzzzzzzzzzzzzzze_ = context.Operators.LessOrEqual(szzzzzzzzzzzzzzzzzzd_, 17);
            bool? szzzzzzzzzzzzzzzzzzf_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzzzze_);

            return szzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(rzzzzzzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzzzzzzi_);
        Encounter rzzzzzzzzzzzzzzzzzzk_(Encounter EncounterWithURI) =>
            EncounterWithURI;
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Encounter, Encounter>(rzzzzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzm_ = context.Operators.Distinct<Encounter>(rzzzzzzzzzzzzzzzzzzl_);

        return rzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public IEnumerable<Encounter> Stratification_2(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzg_ = this.Encounter_with_Upper_Respiratory_Infection(context);
        bool? szzzzzzzzzzzzzzzzzzh_(Encounter EncounterWithURI)
        {
            Patient szzzzzzzzzzzzzzzzzzm_ = this.Patient(context);
            Date szzzzzzzzzzzzzzzzzzn_ = szzzzzzzzzzzzzzzzzzm_?.BirthDateElement;
            string szzzzzzzzzzzzzzzzzzo_ = szzzzzzzzzzzzzzzzzzn_?.Value;
            CqlDate szzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertStringToDate(szzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
            CqlDateTime szzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzq_);
            CqlDate szzzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzzzr_);
            int? szzzzzzzzzzzzzzzzzzt_ = context.Operators.CalculateAgeAt(szzzzzzzzzzzzzzzzzzp_, szzzzzzzzzzzzzzzzzzs_, "year");
            CqlInterval<int?> szzzzzzzzzzzzzzzzzzu_ = context.Operators.Interval(18, 64, true, true);
            bool? szzzzzzzzzzzzzzzzzzv_ = context.Operators.In<int?>(szzzzzzzzzzzzzzzzzzt_, szzzzzzzzzzzzzzzzzzu_, default);

            return szzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(szzzzzzzzzzzzzzzzzzg_, szzzzzzzzzzzzzzzzzzh_);
        Encounter szzzzzzzzzzzzzzzzzzj_(Encounter EncounterWithURI) =>
            EncounterWithURI;
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Encounter, Encounter>(szzzzzzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<Encounter>(szzzzzzzzzzzzzzzzzzk_);

        return szzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Stratification 3")]
    public IEnumerable<Encounter> Stratification_3(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzw_ = this.Encounter_with_Upper_Respiratory_Infection(context);
        bool? szzzzzzzzzzzzzzzzzzx_(Encounter EncounterWithURI)
        {
            Patient tzzzzzzzzzzzzzzzzzzc_ = this.Patient(context);
            Date tzzzzzzzzzzzzzzzzzzd_ = tzzzzzzzzzzzzzzzzzzc_?.BirthDateElement;
            string tzzzzzzzzzzzzzzzzzze_ = tzzzzzzzzzzzzzzzzzzd_?.Value;
            CqlDate tzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConvertStringToDate(tzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
            CqlDateTime tzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzg_);
            CqlDate tzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzh_);
            int? tzzzzzzzzzzzzzzzzzzj_ = context.Operators.CalculateAgeAt(tzzzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzzzi_, "year");
            bool? tzzzzzzzzzzzzzzzzzzk_ = context.Operators.GreaterOrEqual(tzzzzzzzzzzzzzzzzzzj_, 65);

            return tzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Encounter>(szzzzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzzzzx_);
        Encounter szzzzzzzzzzzzzzzzzzz_(Encounter EncounterWithURI) =>
            EncounterWithURI;
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Encounter, Encounter>(szzzzzzzzzzzzzzzzzzy_, szzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzb_ = context.Operators.Distinct<Encounter>(tzzzzzzzzzzzzzzzzzza_);

        return tzzzzzzzzzzzzzzzzzzb_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_FiGMIRiNMNcaAVFKbMahDKTce = new(
        [typeof(Encounter), typeof(Condition)],
        ["QualifyingEncounters", "URI"]);

    #endregion CqlTupleMetadata Properties

}
