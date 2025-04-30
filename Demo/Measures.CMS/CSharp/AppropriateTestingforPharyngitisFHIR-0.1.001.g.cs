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

    [CqlValueSetDefinition("Acute Pharyngitis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1011", valueSetVersion: null)]
    public CqlValueSet Acute_Pharyngitis(CqlContext _) => _Acute_Pharyngitis;
    private static readonly CqlValueSet _Acute_Pharyngitis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1011", null);

    [CqlValueSetDefinition("Acute Tonsillitis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1012", valueSetVersion: null)]
    public CqlValueSet Acute_Tonsillitis(CqlContext _) => _Acute_Tonsillitis;
    private static readonly CqlValueSet _Acute_Tonsillitis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1012", null);

    [CqlValueSetDefinition("Antibiotic Medications for Pharyngitis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1001", valueSetVersion: null)]
    public CqlValueSet Antibiotic_Medications_for_Pharyngitis(CqlContext _) => _Antibiotic_Medications_for_Pharyngitis;
    private static readonly CqlValueSet _Antibiotic_Medications_for_Pharyngitis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1001", null);

    [CqlValueSetDefinition("Comorbid Conditions for Respiratory Conditions", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1025", valueSetVersion: null)]
    public CqlValueSet Comorbid_Conditions_for_Respiratory_Conditions(CqlContext _) => _Comorbid_Conditions_for_Respiratory_Conditions;
    private static readonly CqlValueSet _Comorbid_Conditions_for_Respiratory_Conditions = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1025", null);

    [CqlValueSetDefinition("Competing Conditions for Respiratory Conditions", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1017", valueSetVersion: null)]
    public CqlValueSet Competing_Conditions_for_Respiratory_Conditions(CqlContext _) => _Competing_Conditions_for_Respiratory_Conditions;
    private static readonly CqlValueSet _Competing_Conditions_for_Respiratory_Conditions = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1017", null);

    [CqlValueSetDefinition("Emergency Department Evaluation and Management Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Evaluation_and_Management_Visit(CqlContext _) => _Emergency_Department_Evaluation_and_Management_Visit;
    private static readonly CqlValueSet _Emergency_Department_Evaluation_and_Management_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", null);

    [CqlValueSetDefinition("Group A Streptococcus Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1012", valueSetVersion: null)]
    public CqlValueSet Group_A_Streptococcus_Test(CqlContext _) => _Group_A_Streptococcus_Test;
    private static readonly CqlValueSet _Group_A_Streptococcus_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1012", null);

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
        CqlDateTime dzzzzzzzzzzx_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime dzzzzzzzzzzy_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> dzzzzzzzzzzz_ = context.Operators.Interval(dzzzzzzzzzzx_, dzzzzzzzzzzy_, true, true);
        object ezzzzzzzzzza_ = context.ResolveParameter("AppropriateTestingforPharyngitisFHIR-0.1.001", "Measurement Period", dzzzzzzzzzzz_);

        return (CqlInterval<CqlDateTime>)ezzzzzzzzzza_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ezzzzzzzzzzb_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient ezzzzzzzzzzc_ = context.Operators.SingletonFrom<Patient>(ezzzzzzzzzzb_);

        return ezzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ezzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return ezzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> ezzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return ezzzzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ezzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return ezzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode ezzzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return ezzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzh_ = this.Emergency_Department_Evaluation_and_Management_Visit(context);
        IEnumerable<Encounter> ezzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet ezzzzzzzzzzj_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> ezzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ezzzzzzzzzzl_ = context.Operators.Union<Encounter>(ezzzzzzzzzzi_, ezzzzzzzzzzk_);
        CqlValueSet ezzzzzzzzzzm_ = this.Medical_Disability_Exam(context);
        IEnumerable<Encounter> ezzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet ezzzzzzzzzzo_ = this.Office_Visit(context);
        IEnumerable<Encounter> ezzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ezzzzzzzzzzq_ = context.Operators.Union<Encounter>(ezzzzzzzzzzn_, ezzzzzzzzzzp_);
        IEnumerable<Encounter> ezzzzzzzzzzr_ = context.Operators.Union<Encounter>(ezzzzzzzzzzl_, ezzzzzzzzzzq_);
        CqlValueSet ezzzzzzzzzzs_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> ezzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet ezzzzzzzzzzu_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> ezzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ezzzzzzzzzzw_ = context.Operators.Union<Encounter>(ezzzzzzzzzzt_, ezzzzzzzzzzv_);
        IEnumerable<Encounter> ezzzzzzzzzzx_ = context.Operators.Union<Encounter>(ezzzzzzzzzzr_, ezzzzzzzzzzw_);
        CqlValueSet ezzzzzzzzzzy_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> ezzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet fzzzzzzzzzza_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> fzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> fzzzzzzzzzzc_ = context.Operators.Union<Encounter>(ezzzzzzzzzzz_, fzzzzzzzzzzb_);
        IEnumerable<Encounter> fzzzzzzzzzzd_ = context.Operators.Union<Encounter>(ezzzzzzzzzzx_, fzzzzzzzzzzc_);
        CqlValueSet fzzzzzzzzzze_ = this.Preventive_Care_Services_Group_Counseling(context);
        IEnumerable<Encounter> fzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> fzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? fzzzzzzzzzzh_(Encounter E)
        {
            List<CodeableConcept> gzzzzzzzzzza_ = E?.Type;
            CqlConcept gzzzzzzzzzzb_(CodeableConcept @this)
            {
                CqlConcept gzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return gzzzzzzzzzzg_;
            };
            IEnumerable<CqlConcept> gzzzzzzzzzzc_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)gzzzzzzzzzza_, gzzzzzzzzzzb_);
            bool? gzzzzzzzzzzd_(CqlConcept T)
            {
                CqlCode gzzzzzzzzzzh_ = this.Unlisted_preventive_medicine_service(context);
                CqlConcept gzzzzzzzzzzi_ = context.Operators.ConvertCodeToConcept(gzzzzzzzzzzh_);
                bool? gzzzzzzzzzzj_ = context.Operators.Equivalent(T, gzzzzzzzzzzi_);

                return gzzzzzzzzzzj_;
            };
            IEnumerable<CqlConcept> gzzzzzzzzzze_ = context.Operators.Where<CqlConcept>(gzzzzzzzzzzc_, gzzzzzzzzzzd_);
            bool? gzzzzzzzzzzf_ = context.Operators.Exists<CqlConcept>(gzzzzzzzzzze_);

            return gzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzi_ = context.Operators.Where<Encounter>(fzzzzzzzzzzg_, fzzzzzzzzzzh_);
        IEnumerable<Encounter> fzzzzzzzzzzj_ = context.Operators.Union<Encounter>(fzzzzzzzzzzf_, fzzzzzzzzzzi_);
        IEnumerable<Encounter> fzzzzzzzzzzk_ = context.Operators.Union<Encounter>(fzzzzzzzzzzd_, fzzzzzzzzzzj_);
        CqlValueSet fzzzzzzzzzzl_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> fzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet fzzzzzzzzzzn_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> fzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> fzzzzzzzzzzp_ = context.Operators.Union<Encounter>(fzzzzzzzzzzm_, fzzzzzzzzzzo_);
        IEnumerable<Encounter> fzzzzzzzzzzq_ = context.Operators.Union<Encounter>(fzzzzzzzzzzk_, fzzzzzzzzzzp_);
        CqlValueSet fzzzzzzzzzzr_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> fzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet fzzzzzzzzzzt_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> fzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> fzzzzzzzzzzv_ = context.Operators.Union<Encounter>(fzzzzzzzzzzs_, fzzzzzzzzzzu_);
        IEnumerable<Encounter> fzzzzzzzzzzw_ = context.Operators.Union<Encounter>(fzzzzzzzzzzq_, fzzzzzzzzzzv_);
        IEnumerable<Encounter> fzzzzzzzzzzx_ = Status_1_8_000.Instance.isEncounterPerformed(context, fzzzzzzzzzzw_);
        bool? fzzzzzzzzzzy_(Encounter ValidEncounter)
        {
            Period gzzzzzzzzzzk_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> gzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzl_ as object);
            CqlDateTime gzzzzzzzzzzn_ = context.Operators.End(gzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzo_ = this.Measurement_Period(context);
            CqlDateTime gzzzzzzzzzzp_ = context.Operators.Start(gzzzzzzzzzzo_);
            CqlDateTime gzzzzzzzzzzr_ = context.Operators.End(gzzzzzzzzzzo_);
            CqlQuantity gzzzzzzzzzzs_ = context.Operators.Quantity(3m, "days");
            CqlDateTime gzzzzzzzzzzt_ = context.Operators.Subtract(gzzzzzzzzzzr_, gzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzu_ = context.Operators.Interval(gzzzzzzzzzzp_, gzzzzzzzzzzt_, true, true);
            bool? gzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzn_, gzzzzzzzzzzu_, "day");

            return gzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzz_ = context.Operators.Where<Encounter>(fzzzzzzzzzzx_, fzzzzzzzzzzy_);

        return fzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Encounter With Antibiotic Ordered Within Three Days")]
    public IEnumerable<Encounter> Encounter_With_Antibiotic_Ordered_Within_Three_Days(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzw_ = this.Qualifying_Encounters(context);
        IEnumerable<Encounter> gzzzzzzzzzzx_(Encounter EDOrAmbulatoryVisit)
        {
            CqlValueSet gzzzzzzzzzzz_ = this.Antibiotic_Medications_for_Pharyngitis(context);
            IEnumerable<MedicationRequest> hzzzzzzzzzza_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> hzzzzzzzzzzc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> hzzzzzzzzzzd_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzza_, hzzzzzzzzzzc_);
            IEnumerable<MedicationRequest> hzzzzzzzzzze_ = Status_1_8_000.Instance.isMedicationOrder(context, hzzzzzzzzzzd_);
            bool? hzzzzzzzzzzf_(MedicationRequest AntibioticOrdered)
            {
                Period hzzzzzzzzzzj_ = EDOrAmbulatoryVisit?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzk_ as object);
                CqlDateTime hzzzzzzzzzzm_ = context.Operators.Start(hzzzzzzzzzzl_);
                FhirDateTime hzzzzzzzzzzn_ = AntibioticOrdered?.AuthoredOnElement;
                CqlDateTime hzzzzzzzzzzo_ = context.Operators.Convert<CqlDateTime>(hzzzzzzzzzzn_);
                CqlQuantity hzzzzzzzzzzp_ = context.Operators.Quantity(3m, "days");
                CqlDateTime hzzzzzzzzzzq_ = context.Operators.Subtract(hzzzzzzzzzzo_, hzzzzzzzzzzp_);
                CqlDateTime hzzzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(hzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzt_ = context.Operators.Interval(hzzzzzzzzzzq_, hzzzzzzzzzzs_, true, true);
                bool? hzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzm_, hzzzzzzzzzzt_, "day");
                CqlDateTime hzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(hzzzzzzzzzzn_);
                bool? hzzzzzzzzzzx_ = context.Operators.Not((bool?)(hzzzzzzzzzzw_ is null));
                bool? hzzzzzzzzzzy_ = context.Operators.And(hzzzzzzzzzzu_, hzzzzzzzzzzx_);

                return hzzzzzzzzzzy_;
            };
            IEnumerable<MedicationRequest> hzzzzzzzzzzg_ = context.Operators.Where<MedicationRequest>(hzzzzzzzzzze_, hzzzzzzzzzzf_);
            Encounter hzzzzzzzzzzh_(MedicationRequest AntibioticOrdered) =>
                EDOrAmbulatoryVisit;
            IEnumerable<Encounter> hzzzzzzzzzzi_ = context.Operators.Select<MedicationRequest, Encounter>(hzzzzzzzzzzg_, hzzzzzzzzzzh_);

            return hzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzy_ = context.Operators.SelectMany<Encounter, Encounter>(gzzzzzzzzzzw_, gzzzzzzzzzzx_);

        return gzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Pharyngitis or Tonsillitis")]
    public IEnumerable<Condition> Pharyngitis_or_Tonsillitis(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzz_ = this.Acute_Pharyngitis(context);
        IEnumerable<Condition> izzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet izzzzzzzzzzb_ = this.Acute_Tonsillitis(context);
        IEnumerable<Condition> izzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, izzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> izzzzzzzzzzd_ = context.Operators.Union<Condition>(izzzzzzzzzza_, izzzzzzzzzzc_);

        return izzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Encounter With Pharyngitis or Tonsillitis With Antibiotic")]
    public IEnumerable<Encounter> Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzze_ = this.Encounter_With_Antibiotic_Ordered_Within_Three_Days(context);
        IEnumerable<Condition> izzzzzzzzzzf_ = this.Pharyngitis_or_Tonsillitis(context);
        IEnumerable<ValueTuple<Encounter, Condition>> izzzzzzzzzzg_ = context.Operators.CrossJoin<Encounter, Condition>(izzzzzzzzzze_, izzzzzzzzzzf_);
        (CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)? izzzzzzzzzzh_(ValueTuple<Encounter, Condition> _valueTuple)
        {
            (CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)? izzzzzzzzzzo_ = (CqlTupleMetadata_BHcMAQBSeFPCjbDEhaVDLJXQU, _valueTuple.Item1, _valueTuple.Item2);

            return izzzzzzzzzzo_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)?> izzzzzzzzzzi_ = context.Operators.Select<ValueTuple<Encounter, Condition>, (CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)?>(izzzzzzzzzzg_, izzzzzzzzzzh_);
        bool? izzzzzzzzzzj_((CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)? tuple_ypyxedbbcqbdavhxvckuwmfh)
        {
            CqlInterval<CqlDateTime> izzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, tuple_ypyxedbbcqbdavhxvckuwmfh?.AcutePharyngitisTonsillitis);
            CqlDateTime izzzzzzzzzzq_ = context.Operators.Start(izzzzzzzzzzp_);
            Period izzzzzzzzzzr_ = tuple_ypyxedbbcqbdavhxvckuwmfh?.VisitWithAntibiotic?.Period;
            CqlInterval<CqlDateTime> izzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzr_);
            CqlInterval<CqlDateTime> izzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzs_ as object);
            bool? izzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzq_, izzzzzzzzzzt_, "day");

            return izzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)?> izzzzzzzzzzk_ = context.Operators.Where<(CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)?>(izzzzzzzzzzi_, izzzzzzzzzzj_);
        Encounter izzzzzzzzzzl_((CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)? tuple_ypyxedbbcqbdavhxvckuwmfh) =>
            tuple_ypyxedbbcqbdavhxvckuwmfh?.VisitWithAntibiotic;
        IEnumerable<Encounter> izzzzzzzzzzm_ = context.Operators.Select<(CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)?, Encounter>(izzzzzzzzzzk_, izzzzzzzzzzl_);
        IEnumerable<Encounter> izzzzzzzzzzn_ = context.Operators.Distinct<Encounter>(izzzzzzzzzzm_);

        return izzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzv_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);
        bool? izzzzzzzzzzw_(Encounter EncounterWithPharyngitis)
        {
            Patient jzzzzzzzzzzb_ = this.Patient(context);
            Date jzzzzzzzzzzc_ = jzzzzzzzzzzb_?.BirthDateElement;
            string jzzzzzzzzzzd_ = jzzzzzzzzzzc_?.Value;
            CqlDate jzzzzzzzzzze_ = context.Operators.ConvertStringToDate(jzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzf_ = this.Measurement_Period(context);
            CqlDateTime jzzzzzzzzzzg_ = context.Operators.Start(jzzzzzzzzzzf_);
            CqlDate jzzzzzzzzzzh_ = context.Operators.DateFrom(jzzzzzzzzzzg_);
            int? jzzzzzzzzzzi_ = context.Operators.CalculateAgeAt(jzzzzzzzzzze_, jzzzzzzzzzzh_, "year");
            bool? jzzzzzzzzzzj_ = context.Operators.GreaterOrEqual(jzzzzzzzzzzi_, 3);

            return jzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> izzzzzzzzzzx_ = context.Operators.Where<Encounter>(izzzzzzzzzzv_, izzzzzzzzzzw_);
        Encounter izzzzzzzzzzy_(Encounter EncounterWithPharyngitis) =>
            EncounterWithPharyngitis;
        IEnumerable<Encounter> izzzzzzzzzzz_ = context.Operators.Select<Encounter, Encounter>(izzzzzzzzzzx_, izzzzzzzzzzy_);
        IEnumerable<Encounter> jzzzzzzzzzza_ = context.Operators.Distinct<Encounter>(izzzzzzzzzzz_);

        return jzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzk_ = this.Initial_Population(context);

        return jzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Encounters and Assessments with Hospice Patient")]
    public IEnumerable<Encounter> Encounters_and_Assessments_with_Hospice_Patient(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzl_ = this.Initial_Population(context);
        bool? jzzzzzzzzzzm_(Encounter EligibleEncounters)
        {
            bool? jzzzzzzzzzzo_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);

            return jzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzn_ = context.Operators.Where<Encounter>(jzzzzzzzzzzl_, jzzzzzzzzzzm_);

        return jzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzp_ = this.Encounters_and_Assessments_with_Hospice_Patient(context);
        IEnumerable<Encounter> jzzzzzzzzzzq_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);
        CqlValueSet jzzzzzzzzzzr_ = this.Comorbid_Conditions_for_Respiratory_Conditions(context);
        IEnumerable<Condition> jzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Encounter> jzzzzzzzzzzt_ = Antibiotic_1_7_000.Instance.Has_Comorbid_Condition_History(context, jzzzzzzzzzzq_, jzzzzzzzzzzs_);
        IEnumerable<Encounter> jzzzzzzzzzzu_ = context.Operators.Union<Encounter>(jzzzzzzzzzzp_, jzzzzzzzzzzt_);
        CqlValueSet jzzzzzzzzzzw_ = this.Antibiotic_Medications_for_Pharyngitis(context);
        IEnumerable<MedicationRequest> jzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> jzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> kzzzzzzzzzza_ = context.Operators.Union<MedicationRequest>(jzzzzzzzzzzx_, jzzzzzzzzzzz_);
        IEnumerable<MedicationRequest> kzzzzzzzzzzb_ = Status_1_8_000.Instance.isMedicationActive(context, kzzzzzzzzzza_);
        IEnumerable<Encounter> kzzzzzzzzzzc_ = Antibiotic_1_7_000.Instance.Has_Antibiotic_Medication_History(context, jzzzzzzzzzzq_, kzzzzzzzzzzb_);
        CqlValueSet kzzzzzzzzzze_ = this.Competing_Conditions_for_Respiratory_Conditions(context);
        IEnumerable<Condition> kzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Encounter> kzzzzzzzzzzg_ = Antibiotic_1_7_000.Instance.Has_Competing_Diagnosis_History(context, jzzzzzzzzzzq_, kzzzzzzzzzzf_);
        IEnumerable<Encounter> kzzzzzzzzzzh_ = context.Operators.Union<Encounter>(kzzzzzzzzzzc_, kzzzzzzzzzzg_);
        IEnumerable<Encounter> kzzzzzzzzzzi_ = context.Operators.Union<Encounter>(jzzzzzzzzzzu_, kzzzzzzzzzzh_);

        return kzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Group A Streptococcus Lab Test With Result")]
    public IEnumerable<Observation> Group_A_Streptococcus_Lab_Test_With_Result(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzj_ = this.Group_A_Streptococcus_Test(context);
        IEnumerable<Observation> kzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> kzzzzzzzzzzl_ = Status_1_8_000.Instance.isLaboratoryTestPerformed(context, kzzzzzzzzzzk_);
        bool? kzzzzzzzzzzm_(Observation GroupAStreptococcusTest)
        {
            DataType kzzzzzzzzzzo_ = GroupAStreptococcusTest?.Value;
            object kzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzo_);
            bool? kzzzzzzzzzzq_ = context.Operators.Not((bool?)(kzzzzzzzzzzp_ is null));

            return kzzzzzzzzzzq_;
        };
        IEnumerable<Observation> kzzzzzzzzzzn_ = context.Operators.Where<Observation>(kzzzzzzzzzzl_, kzzzzzzzzzzm_);

        return kzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Observation> kzzzzzzzzzzr_ = this.Group_A_Streptococcus_Lab_Test_With_Result(context);
        IEnumerable<Encounter> kzzzzzzzzzzs_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);
        IEnumerable<ValueTuple<Observation, Encounter>> kzzzzzzzzzzt_ = context.Operators.CrossJoin<Observation, Encounter>(kzzzzzzzzzzr_, kzzzzzzzzzzs_);
        (CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)? kzzzzzzzzzzu_(ValueTuple<Observation, Encounter> _valueTuple)
        {
            (CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)? lzzzzzzzzzzb_ = (CqlTupleMetadata_FeNRUFDKGVUFAMiQLLieSFHIV, _valueTuple.Item1, _valueTuple.Item2);

            return lzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)?> kzzzzzzzzzzv_ = context.Operators.Select<ValueTuple<Observation, Encounter>, (CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)?>(kzzzzzzzzzzt_, kzzzzzzzzzzu_);
        bool? kzzzzzzzzzzw_((CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)? tuple_ffguysnebcxllexfcmjoehbij)
        {
            DataType lzzzzzzzzzzc_ = tuple_ffguysnebcxllexfcmjoehbij?.GroupAStreptococcusTest?.Effective;
            object lzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> lzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzd_);
            CqlDateTime lzzzzzzzzzzf_ = context.Operators.Start(lzzzzzzzzzze_);
            Period lzzzzzzzzzzg_ = tuple_ffguysnebcxllexfcmjoehbij?.EncounterWithPharyngitis?.Period;
            CqlInterval<CqlDateTime> lzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzg_);
            CqlDateTime lzzzzzzzzzzi_ = context.Operators.End(lzzzzzzzzzzh_);
            CqlQuantity lzzzzzzzzzzj_ = context.Operators.Quantity(3m, "days");
            CqlDateTime lzzzzzzzzzzk_ = context.Operators.Subtract(lzzzzzzzzzzi_, lzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzg_);
            CqlDateTime lzzzzzzzzzzn_ = context.Operators.End(lzzzzzzzzzzm_);
            CqlDateTime lzzzzzzzzzzp_ = context.Operators.Add(lzzzzzzzzzzn_, lzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzq_ = context.Operators.Interval(lzzzzzzzzzzk_, lzzzzzzzzzzp_, true, true);
            bool? lzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzf_, lzzzzzzzzzzq_, "day");

            return lzzzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)?> kzzzzzzzzzzx_ = context.Operators.Where<(CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)?>(kzzzzzzzzzzv_, kzzzzzzzzzzw_);
        Encounter kzzzzzzzzzzy_((CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)? tuple_ffguysnebcxllexfcmjoehbij) =>
            tuple_ffguysnebcxllexfcmjoehbij?.EncounterWithPharyngitis;
        IEnumerable<Encounter> kzzzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)?, Encounter>(kzzzzzzzzzzx_, kzzzzzzzzzzy_);
        IEnumerable<Encounter> lzzzzzzzzzza_ = context.Operators.Distinct<Encounter>(kzzzzzzzzzzz_);

        return lzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Stratification 1")]
    public IEnumerable<Encounter> Stratification_1(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzs_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);
        bool? lzzzzzzzzzzt_(Encounter EncounterWithPharyngitis)
        {
            Patient lzzzzzzzzzzy_ = this.Patient(context);
            Date lzzzzzzzzzzz_ = lzzzzzzzzzzy_?.BirthDateElement;
            string mzzzzzzzzzza_ = lzzzzzzzzzzz_?.Value;
            CqlDate mzzzzzzzzzzb_ = context.Operators.ConvertStringToDate(mzzzzzzzzzza_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzc_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzzzzzzd_ = context.Operators.Start(mzzzzzzzzzzc_);
            CqlDate mzzzzzzzzzze_ = context.Operators.DateFrom(mzzzzzzzzzzd_);
            int? mzzzzzzzzzzf_ = context.Operators.CalculateAgeAt(mzzzzzzzzzzb_, mzzzzzzzzzze_, "year");
            CqlInterval<int?> mzzzzzzzzzzg_ = context.Operators.Interval(3, 17, true, true);
            bool? mzzzzzzzzzzh_ = context.Operators.In<int?>(mzzzzzzzzzzf_, mzzzzzzzzzzg_, default);

            return mzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzu_ = context.Operators.Where<Encounter>(lzzzzzzzzzzs_, lzzzzzzzzzzt_);
        Encounter lzzzzzzzzzzv_(Encounter EncounterWithPharyngitis) =>
            EncounterWithPharyngitis;
        IEnumerable<Encounter> lzzzzzzzzzzw_ = context.Operators.Select<Encounter, Encounter>(lzzzzzzzzzzu_, lzzzzzzzzzzv_);
        IEnumerable<Encounter> lzzzzzzzzzzx_ = context.Operators.Distinct<Encounter>(lzzzzzzzzzzw_);

        return lzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public IEnumerable<Encounter> Stratification_2(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzi_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);
        bool? mzzzzzzzzzzj_(Encounter EncounterWithPharyngitis)
        {
            Patient mzzzzzzzzzzo_ = this.Patient(context);
            Date mzzzzzzzzzzp_ = mzzzzzzzzzzo_?.BirthDateElement;
            string mzzzzzzzzzzq_ = mzzzzzzzzzzp_?.Value;
            CqlDate mzzzzzzzzzzr_ = context.Operators.ConvertStringToDate(mzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzs_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzzzzzzt_ = context.Operators.Start(mzzzzzzzzzzs_);
            CqlDate mzzzzzzzzzzu_ = context.Operators.DateFrom(mzzzzzzzzzzt_);
            int? mzzzzzzzzzzv_ = context.Operators.CalculateAgeAt(mzzzzzzzzzzr_, mzzzzzzzzzzu_, "year");
            CqlInterval<int?> mzzzzzzzzzzw_ = context.Operators.Interval(18, 64, true, true);
            bool? mzzzzzzzzzzx_ = context.Operators.In<int?>(mzzzzzzzzzzv_, mzzzzzzzzzzw_, default);

            return mzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzk_ = context.Operators.Where<Encounter>(mzzzzzzzzzzi_, mzzzzzzzzzzj_);
        Encounter mzzzzzzzzzzl_(Encounter EncounterWithPharyngitis) =>
            EncounterWithPharyngitis;
        IEnumerable<Encounter> mzzzzzzzzzzm_ = context.Operators.Select<Encounter, Encounter>(mzzzzzzzzzzk_, mzzzzzzzzzzl_);
        IEnumerable<Encounter> mzzzzzzzzzzn_ = context.Operators.Distinct<Encounter>(mzzzzzzzzzzm_);

        return mzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Stratification 3")]
    public IEnumerable<Encounter> Stratification_3(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzy_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);
        bool? mzzzzzzzzzzz_(Encounter EncounterWithPharyngitis)
        {
            Patient nzzzzzzzzzze_ = this.Patient(context);
            Date nzzzzzzzzzzf_ = nzzzzzzzzzze_?.BirthDateElement;
            string nzzzzzzzzzzg_ = nzzzzzzzzzzf_?.Value;
            CqlDate nzzzzzzzzzzh_ = context.Operators.ConvertStringToDate(nzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzi_ = this.Measurement_Period(context);
            CqlDateTime nzzzzzzzzzzj_ = context.Operators.Start(nzzzzzzzzzzi_);
            CqlDate nzzzzzzzzzzk_ = context.Operators.DateFrom(nzzzzzzzzzzj_);
            int? nzzzzzzzzzzl_ = context.Operators.CalculateAgeAt(nzzzzzzzzzzh_, nzzzzzzzzzzk_, "year");
            bool? nzzzzzzzzzzm_ = context.Operators.GreaterOrEqual(nzzzzzzzzzzl_, 65);

            return nzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> nzzzzzzzzzza_ = context.Operators.Where<Encounter>(mzzzzzzzzzzy_, mzzzzzzzzzzz_);
        Encounter nzzzzzzzzzzb_(Encounter EncounterWithPharyngitis) =>
            EncounterWithPharyngitis;
        IEnumerable<Encounter> nzzzzzzzzzzc_ = context.Operators.Select<Encounter, Encounter>(nzzzzzzzzzza_, nzzzzzzzzzzb_);
        IEnumerable<Encounter> nzzzzzzzzzzd_ = context.Operators.Distinct<Encounter>(nzzzzzzzzzzc_);

        return nzzzzzzzzzzd_;
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
