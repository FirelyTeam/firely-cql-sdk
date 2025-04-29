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
        CqlDateTime yzzzzzzzzzze_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime yzzzzzzzzzzf_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> yzzzzzzzzzzg_ = context.Operators.Interval(yzzzzzzzzzze_, yzzzzzzzzzzf_, true, true);
        object yzzzzzzzzzzh_ = context.ResolveParameter("AppropriateTreatmentforUpperRespiratoryInfectionURIFHIR-0.1.001", "Measurement Period", yzzzzzzzzzzg_);

        return (CqlInterval<CqlDateTime>)yzzzzzzzzzzh_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> yzzzzzzzzzzi_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient yzzzzzzzzzzj_ = context.Operators.SingletonFrom<Patient>(yzzzzzzzzzzi_);

        return yzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? yzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return yzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> yzzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return yzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? yzzzzzzzzzzm_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return yzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode yzzzzzzzzzzn_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return yzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzo_ = this.Emergency_Department_Evaluation_and_Management_Visit(context);
        IEnumerable<Encounter> yzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet yzzzzzzzzzzq_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> yzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzzzzzzs_ = context.Operators.Union<Encounter>(yzzzzzzzzzzp_, yzzzzzzzzzzr_);
        CqlValueSet yzzzzzzzzzzt_ = this.Medical_Disability_Exam(context);
        IEnumerable<Encounter> yzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet yzzzzzzzzzzv_ = this.Office_Visit(context);
        IEnumerable<Encounter> yzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzzzzzzx_ = context.Operators.Union<Encounter>(yzzzzzzzzzzu_, yzzzzzzzzzzw_);
        IEnumerable<Encounter> yzzzzzzzzzzy_ = context.Operators.Union<Encounter>(yzzzzzzzzzzs_, yzzzzzzzzzzx_);
        CqlValueSet yzzzzzzzzzzz_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> zzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet zzzzzzzzzzzb_ = this.Preventive_Care_Services_Group_Counseling(context);
        IEnumerable<Encounter> zzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> zzzzzzzzzzzd_ = context.Operators.Union<Encounter>(zzzzzzzzzzza_, zzzzzzzzzzzc_);
        IEnumerable<Encounter> zzzzzzzzzzze_ = context.Operators.Union<Encounter>(yzzzzzzzzzzy_, zzzzzzzzzzzd_);
        CqlValueSet zzzzzzzzzzzf_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> zzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet zzzzzzzzzzzh_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> zzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> zzzzzzzzzzzj_ = context.Operators.Union<Encounter>(zzzzzzzzzzzg_, zzzzzzzzzzzi_);
        IEnumerable<Encounter> zzzzzzzzzzzk_ = context.Operators.Union<Encounter>(zzzzzzzzzzze_, zzzzzzzzzzzj_);
        CqlValueSet zzzzzzzzzzzl_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> zzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet zzzzzzzzzzzn_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> zzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> zzzzzzzzzzzp_ = context.Operators.Union<Encounter>(zzzzzzzzzzzm_, zzzzzzzzzzzo_);
        IEnumerable<Encounter> zzzzzzzzzzzq_ = context.Operators.Union<Encounter>(zzzzzzzzzzzk_, zzzzzzzzzzzp_);
        CqlValueSet zzzzzzzzzzzr_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> zzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet zzzzzzzzzzzt_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> zzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> zzzzzzzzzzzv_ = context.Operators.Union<Encounter>(zzzzzzzzzzzs_, zzzzzzzzzzzu_);
        IEnumerable<Encounter> zzzzzzzzzzzw_ = context.Operators.Union<Encounter>(zzzzzzzzzzzq_, zzzzzzzzzzzv_);
        CqlValueSet zzzzzzzzzzzx_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> zzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> zzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? azzzzzzzzzzza_(Encounter E)
        {
            List<CodeableConcept> azzzzzzzzzzzh_ = E?.Type;
            CqlConcept azzzzzzzzzzzi_(CodeableConcept @this)
            {
                CqlConcept azzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return azzzzzzzzzzzn_;
            };
            IEnumerable<CqlConcept> azzzzzzzzzzzj_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)azzzzzzzzzzzh_, azzzzzzzzzzzi_);
            bool? azzzzzzzzzzzk_(CqlConcept T)
            {
                CqlCode azzzzzzzzzzzo_ = this.Unlisted_preventive_medicine_service(context);
                CqlConcept azzzzzzzzzzzp_ = context.Operators.ConvertCodeToConcept(azzzzzzzzzzzo_);
                bool? azzzzzzzzzzzq_ = context.Operators.Equivalent(T, azzzzzzzzzzzp_);

                return azzzzzzzzzzzq_;
            };
            IEnumerable<CqlConcept> azzzzzzzzzzzl_ = context.Operators.Where<CqlConcept>(azzzzzzzzzzzj_, azzzzzzzzzzzk_);
            bool? azzzzzzzzzzzm_ = context.Operators.Exists<CqlConcept>(azzzzzzzzzzzl_);

            return azzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzb_ = context.Operators.Where<Encounter>(zzzzzzzzzzzz_, azzzzzzzzzzza_);
        IEnumerable<Encounter> azzzzzzzzzzzc_ = context.Operators.Union<Encounter>(zzzzzzzzzzzy_, azzzzzzzzzzzb_);
        IEnumerable<Encounter> azzzzzzzzzzzd_ = context.Operators.Union<Encounter>(zzzzzzzzzzzw_, azzzzzzzzzzzc_);
        IEnumerable<Encounter> azzzzzzzzzzze_ = Status_1_8_000.Instance.isEncounterPerformed(context, azzzzzzzzzzzd_);
        bool? azzzzzzzzzzzf_(Encounter ValidEncounter)
        {
            Period azzzzzzzzzzzr_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> azzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzs_ as object);
            CqlDateTime azzzzzzzzzzzu_ = context.Operators.End(azzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzv_ = this.Measurement_Period(context);
            CqlDateTime azzzzzzzzzzzw_ = context.Operators.Start(azzzzzzzzzzzv_);
            CqlDateTime azzzzzzzzzzzy_ = context.Operators.End(azzzzzzzzzzzv_);
            CqlQuantity azzzzzzzzzzzz_ = context.Operators.Quantity(3m, "days");
            CqlDateTime bzzzzzzzzzzza_ = context.Operators.Subtract(azzzzzzzzzzzy_, azzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzb_ = context.Operators.Interval(azzzzzzzzzzzw_, bzzzzzzzzzzza_, true, true);
            bool? bzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzu_, bzzzzzzzzzzzb_, "day");

            return bzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzg_ = context.Operators.Where<Encounter>(azzzzzzzzzzze_, azzzzzzzzzzzf_);

        return azzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Encounter with Upper Respiratory Infection")]
    public IEnumerable<Encounter> Encounter_with_Upper_Respiratory_Infection(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzd_ = this.Qualifying_Encounters(context);
        CqlValueSet bzzzzzzzzzzze_ = this.Upper_Respiratory_Infection(context);
        IEnumerable<Condition> bzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<ValueTuple<Encounter, Condition>> bzzzzzzzzzzzg_ = context.Operators.CrossJoin<Encounter, Condition>(bzzzzzzzzzzzd_, bzzzzzzzzzzzf_);
        (CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)? bzzzzzzzzzzzh_(ValueTuple<Encounter, Condition> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)? bzzzzzzzzzzzo_ = (CqlTupleMetadata_FiGMIRiNMNcaAVFKbMahDKTce, _valueTuple.Item1, _valueTuple.Item2);

            return bzzzzzzzzzzzo_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)?> bzzzzzzzzzzzi_ = context.Operators.Select<ValueTuple<Encounter, Condition>, (CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)?>(bzzzzzzzzzzzg_, bzzzzzzzzzzzh_);
        bool? bzzzzzzzzzzzj_((CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)? tuple_figmirinmncaavfkbmahdktce)
        {
            CqlInterval<CqlDateTime> bzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, tuple_figmirinmncaavfkbmahdktce?.URI);
            CqlDateTime bzzzzzzzzzzzq_ = context.Operators.Start(bzzzzzzzzzzzp_);
            Period bzzzzzzzzzzzr_ = tuple_figmirinmncaavfkbmahdktce?.QualifyingEncounters?.Period;
            CqlInterval<CqlDateTime> bzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzs_ as object);
            bool? bzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzq_, bzzzzzzzzzzzt_, "day");
            CqlInterval<CqlDateTime> bzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzx_ as object);
            bool? bzzzzzzzzzzzz_ = context.Operators.OverlapsBefore(bzzzzzzzzzzzp_, bzzzzzzzzzzzy_, default);
            bool? czzzzzzzzzzza_ = context.Operators.Or(bzzzzzzzzzzzu_, bzzzzzzzzzzzz_);

            return czzzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)?> bzzzzzzzzzzzk_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)?>(bzzzzzzzzzzzi_, bzzzzzzzzzzzj_);
        Encounter bzzzzzzzzzzzl_((CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)? tuple_figmirinmncaavfkbmahdktce) =>
            tuple_figmirinmncaavfkbmahdktce?.QualifyingEncounters;
        IEnumerable<Encounter> bzzzzzzzzzzzm_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounters, Condition URI)?, Encounter>(bzzzzzzzzzzzk_, bzzzzzzzzzzzl_);
        IEnumerable<Encounter> bzzzzzzzzzzzn_ = context.Operators.Distinct<Encounter>(bzzzzzzzzzzzm_);

        return bzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzb_ = this.Encounter_with_Upper_Respiratory_Infection(context);
        bool? czzzzzzzzzzzc_(Encounter EncounterWithURI)
        {
            Patient czzzzzzzzzzzh_ = this.Patient(context);
            Date czzzzzzzzzzzi_ = czzzzzzzzzzzh_?.BirthDateElement;
            string czzzzzzzzzzzj_ = czzzzzzzzzzzi_?.Value;
            CqlDate czzzzzzzzzzzk_ = context.Operators.ConvertStringToDate(czzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzl_ = this.Measurement_Period(context);
            CqlDateTime czzzzzzzzzzzm_ = context.Operators.Start(czzzzzzzzzzzl_);
            CqlDate czzzzzzzzzzzn_ = context.Operators.DateFrom(czzzzzzzzzzzm_);
            int? czzzzzzzzzzzo_ = context.Operators.CalculateAgeAt(czzzzzzzzzzzk_, czzzzzzzzzzzn_, "month");
            bool? czzzzzzzzzzzp_ = context.Operators.GreaterOrEqual(czzzzzzzzzzzo_, 3);

            return czzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzd_ = context.Operators.Where<Encounter>(czzzzzzzzzzzb_, czzzzzzzzzzzc_);
        Encounter czzzzzzzzzzze_(Encounter EncounterWithURI) =>
            EncounterWithURI;
        IEnumerable<Encounter> czzzzzzzzzzzf_ = context.Operators.Select<Encounter, Encounter>(czzzzzzzzzzzd_, czzzzzzzzzzze_);
        IEnumerable<Encounter> czzzzzzzzzzzg_ = context.Operators.Distinct<Encounter>(czzzzzzzzzzzf_);

        return czzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Encounters and Assessments with Hospice Patient")]
    public IEnumerable<Encounter> Encounters_and_Assessments_with_Hospice_Patient(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzq_ = this.Initial_Population(context);
        bool? czzzzzzzzzzzr_(Encounter EligibleEncounters)
        {
            bool? czzzzzzzzzzzt_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);

            return czzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzs_ = context.Operators.Where<Encounter>(czzzzzzzzzzzq_, czzzzzzzzzzzr_);

        return czzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzu_ = this.Initial_Population(context);

        return czzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzv_ = this.Encounters_and_Assessments_with_Hospice_Patient(context);
        IEnumerable<Encounter> czzzzzzzzzzzw_ = this.Encounter_with_Upper_Respiratory_Infection(context);
        CqlValueSet czzzzzzzzzzzx_ = this.Comorbid_Conditions_for_Respiratory_Conditions(context);
        IEnumerable<Condition> czzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Encounter> czzzzzzzzzzzz_ = Antibiotic_1_7_000.Instance.Has_Comorbid_Condition_History(context, czzzzzzzzzzzw_, czzzzzzzzzzzy_);
        IEnumerable<Encounter> dzzzzzzzzzzza_ = context.Operators.Union<Encounter>(czzzzzzzzzzzv_, czzzzzzzzzzzz_);
        CqlValueSet dzzzzzzzzzzzc_ = this.Antibiotic_Medications_for_Upper_Respiratory_Infection(context);
        IEnumerable<MedicationRequest> dzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dzzzzzzzzzzzg_ = context.Operators.Union<MedicationRequest>(dzzzzzzzzzzzd_, dzzzzzzzzzzzf_);
        IEnumerable<Encounter> dzzzzzzzzzzzh_ = Antibiotic_1_7_000.Instance.Has_Antibiotic_Medication_History(context, czzzzzzzzzzzw_, dzzzzzzzzzzzg_);
        CqlValueSet dzzzzzzzzzzzj_ = this.Competing_Conditions_for_Respiratory_Conditions(context);
        IEnumerable<Condition> dzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet dzzzzzzzzzzzl_ = this.Acute_Pharyngitis(context);
        IEnumerable<Condition> dzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> dzzzzzzzzzzzn_ = context.Operators.Union<Condition>(dzzzzzzzzzzzk_, dzzzzzzzzzzzm_);
        CqlValueSet dzzzzzzzzzzzo_ = this.Acute_Tonsillitis(context);
        IEnumerable<Condition> dzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> dzzzzzzzzzzzq_ = context.Operators.Union<Condition>(dzzzzzzzzzzzn_, dzzzzzzzzzzzp_);
        IEnumerable<Encounter> dzzzzzzzzzzzr_ = Antibiotic_1_7_000.Instance.Has_Competing_Diagnosis_History(context, czzzzzzzzzzzw_, dzzzzzzzzzzzq_);
        IEnumerable<Encounter> dzzzzzzzzzzzs_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzh_, dzzzzzzzzzzzr_);
        IEnumerable<Encounter> dzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(dzzzzzzzzzzza_, dzzzzzzzzzzzs_);

        return dzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzu_ = this.Encounter_with_Upper_Respiratory_Infection(context);
        IEnumerable<Encounter> dzzzzzzzzzzzw_(Encounter EncounterWithURI)
        {
            CqlValueSet ezzzzzzzzzzzc_ = this.Antibiotic_Medications_for_Upper_Respiratory_Infection(context);
            IEnumerable<MedicationRequest> ezzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ezzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> ezzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ezzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> ezzzzzzzzzzzg_ = context.Operators.Union<MedicationRequest>(ezzzzzzzzzzzd_, ezzzzzzzzzzzf_);
            IEnumerable<MedicationRequest> ezzzzzzzzzzzh_ = Status_1_8_000.Instance.isMedicationOrder(context, ezzzzzzzzzzzg_);
            bool? ezzzzzzzzzzzi_(MedicationRequest OrderedAntibiotic)
            {
                FhirDateTime ezzzzzzzzzzzm_ = OrderedAntibiotic?.AuthoredOnElement;
                CqlDateTime ezzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(ezzzzzzzzzzzm_);
                Period ezzzzzzzzzzzo_ = EncounterWithURI?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzp_ as object);
                CqlDateTime ezzzzzzzzzzzr_ = context.Operators.Start(ezzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzt_ as object);
                CqlDateTime ezzzzzzzzzzzv_ = context.Operators.Start(ezzzzzzzzzzzu_);
                CqlQuantity ezzzzzzzzzzzw_ = context.Operators.Quantity(3m, "days");
                CqlDateTime ezzzzzzzzzzzx_ = context.Operators.Add(ezzzzzzzzzzzv_, ezzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzy_ = context.Operators.Interval(ezzzzzzzzzzzr_, ezzzzzzzzzzzx_, true, true);
                bool? ezzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzn_, ezzzzzzzzzzzy_, default);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzb_ as object);
                CqlDateTime fzzzzzzzzzzzd_ = context.Operators.Start(fzzzzzzzzzzzc_);
                bool? fzzzzzzzzzzze_ = context.Operators.Not((bool?)(fzzzzzzzzzzzd_ is null));
                bool? fzzzzzzzzzzzf_ = context.Operators.And(ezzzzzzzzzzzz_, fzzzzzzzzzzze_);

                return fzzzzzzzzzzzf_;
            };
            IEnumerable<MedicationRequest> ezzzzzzzzzzzj_ = context.Operators.Where<MedicationRequest>(ezzzzzzzzzzzh_, ezzzzzzzzzzzi_);
            Encounter ezzzzzzzzzzzk_(MedicationRequest OrderedAntibiotic) =>
                EncounterWithURI;
            IEnumerable<Encounter> ezzzzzzzzzzzl_ = context.Operators.Select<MedicationRequest, Encounter>(ezzzzzzzzzzzj_, ezzzzzzzzzzzk_);

            return ezzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzx_ = context.Operators.SelectMany<Encounter, Encounter>(dzzzzzzzzzzzu_, dzzzzzzzzzzzw_);
        IEnumerable<Encounter> dzzzzzzzzzzzy_ = context.Operators.Except<Encounter>(dzzzzzzzzzzzu_, dzzzzzzzzzzzx_);
        Encounter dzzzzzzzzzzzz_(Encounter EncounterWithURI) =>
            EncounterWithURI;
        IEnumerable<Encounter> ezzzzzzzzzzza_ = context.Operators.Select<Encounter, Encounter>(dzzzzzzzzzzzy_, dzzzzzzzzzzzz_);
        IEnumerable<Encounter> ezzzzzzzzzzzb_ = context.Operators.Distinct<Encounter>(ezzzzzzzzzzza_);

        return ezzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Stratification 1")]
    public IEnumerable<Encounter> Stratification_1(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzg_ = this.Encounter_with_Upper_Respiratory_Infection(context);
        bool? fzzzzzzzzzzzh_(Encounter EncounterWithURI)
        {
            Patient fzzzzzzzzzzzm_ = this.Patient(context);
            Date fzzzzzzzzzzzn_ = fzzzzzzzzzzzm_?.BirthDateElement;
            string fzzzzzzzzzzzo_ = fzzzzzzzzzzzn_?.Value;
            CqlDate fzzzzzzzzzzzp_ = context.Operators.ConvertStringToDate(fzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzq_ = this.Measurement_Period(context);
            CqlDateTime fzzzzzzzzzzzr_ = context.Operators.Start(fzzzzzzzzzzzq_);
            CqlDate fzzzzzzzzzzzs_ = context.Operators.DateFrom(fzzzzzzzzzzzr_);
            int? fzzzzzzzzzzzt_ = context.Operators.CalculateAgeAt(fzzzzzzzzzzzp_, fzzzzzzzzzzzs_, "month");
            bool? fzzzzzzzzzzzu_ = context.Operators.GreaterOrEqual(fzzzzzzzzzzzt_, 3);
            Date fzzzzzzzzzzzw_ = fzzzzzzzzzzzm_?.BirthDateElement;
            string fzzzzzzzzzzzx_ = fzzzzzzzzzzzw_?.Value;
            CqlDate fzzzzzzzzzzzy_ = context.Operators.ConvertStringToDate(fzzzzzzzzzzzx_);
            CqlDateTime gzzzzzzzzzzza_ = context.Operators.Start(fzzzzzzzzzzzq_);
            CqlDate gzzzzzzzzzzzb_ = context.Operators.DateFrom(gzzzzzzzzzzza_);
            int? gzzzzzzzzzzzc_ = context.Operators.CalculateAgeAt(fzzzzzzzzzzzy_, gzzzzzzzzzzzb_, "year");
            bool? gzzzzzzzzzzzd_ = context.Operators.LessOrEqual(gzzzzzzzzzzzc_, 17);
            bool? gzzzzzzzzzzze_ = context.Operators.And(fzzzzzzzzzzzu_, gzzzzzzzzzzzd_);

            return gzzzzzzzzzzze_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzg_, fzzzzzzzzzzzh_);
        Encounter fzzzzzzzzzzzj_(Encounter EncounterWithURI) =>
            EncounterWithURI;
        IEnumerable<Encounter> fzzzzzzzzzzzk_ = context.Operators.Select<Encounter, Encounter>(fzzzzzzzzzzzi_, fzzzzzzzzzzzj_);
        IEnumerable<Encounter> fzzzzzzzzzzzl_ = context.Operators.Distinct<Encounter>(fzzzzzzzzzzzk_);

        return fzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public IEnumerable<Encounter> Stratification_2(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzf_ = this.Encounter_with_Upper_Respiratory_Infection(context);
        bool? gzzzzzzzzzzzg_(Encounter EncounterWithURI)
        {
            Patient gzzzzzzzzzzzl_ = this.Patient(context);
            Date gzzzzzzzzzzzm_ = gzzzzzzzzzzzl_?.BirthDateElement;
            string gzzzzzzzzzzzn_ = gzzzzzzzzzzzm_?.Value;
            CqlDate gzzzzzzzzzzzo_ = context.Operators.ConvertStringToDate(gzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzp_ = this.Measurement_Period(context);
            CqlDateTime gzzzzzzzzzzzq_ = context.Operators.Start(gzzzzzzzzzzzp_);
            CqlDate gzzzzzzzzzzzr_ = context.Operators.DateFrom(gzzzzzzzzzzzq_);
            int? gzzzzzzzzzzzs_ = context.Operators.CalculateAgeAt(gzzzzzzzzzzzo_, gzzzzzzzzzzzr_, "year");
            CqlInterval<int?> gzzzzzzzzzzzt_ = context.Operators.Interval(18, 64, true, true);
            bool? gzzzzzzzzzzzu_ = context.Operators.In<int?>(gzzzzzzzzzzzs_, gzzzzzzzzzzzt_, default);

            return gzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzf_, gzzzzzzzzzzzg_);
        Encounter gzzzzzzzzzzzi_(Encounter EncounterWithURI) =>
            EncounterWithURI;
        IEnumerable<Encounter> gzzzzzzzzzzzj_ = context.Operators.Select<Encounter, Encounter>(gzzzzzzzzzzzh_, gzzzzzzzzzzzi_);
        IEnumerable<Encounter> gzzzzzzzzzzzk_ = context.Operators.Distinct<Encounter>(gzzzzzzzzzzzj_);

        return gzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Stratification 3")]
    public IEnumerable<Encounter> Stratification_3(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzv_ = this.Encounter_with_Upper_Respiratory_Infection(context);
        bool? gzzzzzzzzzzzw_(Encounter EncounterWithURI)
        {
            Patient hzzzzzzzzzzzb_ = this.Patient(context);
            Date hzzzzzzzzzzzc_ = hzzzzzzzzzzzb_?.BirthDateElement;
            string hzzzzzzzzzzzd_ = hzzzzzzzzzzzc_?.Value;
            CqlDate hzzzzzzzzzzze_ = context.Operators.ConvertStringToDate(hzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzf_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzzzzzzzg_ = context.Operators.Start(hzzzzzzzzzzzf_);
            CqlDate hzzzzzzzzzzzh_ = context.Operators.DateFrom(hzzzzzzzzzzzg_);
            int? hzzzzzzzzzzzi_ = context.Operators.CalculateAgeAt(hzzzzzzzzzzze_, hzzzzzzzzzzzh_, "year");
            bool? hzzzzzzzzzzzj_ = context.Operators.GreaterOrEqual(hzzzzzzzzzzzi_, 65);

            return hzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzv_, gzzzzzzzzzzzw_);
        Encounter gzzzzzzzzzzzy_(Encounter EncounterWithURI) =>
            EncounterWithURI;
        IEnumerable<Encounter> gzzzzzzzzzzzz_ = context.Operators.Select<Encounter, Encounter>(gzzzzzzzzzzzx_, gzzzzzzzzzzzy_);
        IEnumerable<Encounter> hzzzzzzzzzzza_ = context.Operators.Distinct<Encounter>(gzzzzzzzzzzzz_);

        return hzzzzzzzzzzza_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_FiGMIRiNMNcaAVFKbMahDKTce = new(
        [typeof(Encounter), typeof(Condition)],
        ["QualifyingEncounters", "URI"]);

    #endregion CqlTupleMetadata Properties

}
