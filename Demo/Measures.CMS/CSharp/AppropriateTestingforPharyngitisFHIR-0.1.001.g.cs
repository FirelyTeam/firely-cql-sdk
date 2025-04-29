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
        CqlDateTime pzzzzzzzzzzd_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime pzzzzzzzzzze_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> pzzzzzzzzzzf_ = context.Operators.Interval(pzzzzzzzzzzd_, pzzzzzzzzzze_, true, true);
        object pzzzzzzzzzzg_ = context.ResolveParameter("AppropriateTestingforPharyngitisFHIR-0.1.001", "Measurement Period", pzzzzzzzzzzf_);

        return (CqlInterval<CqlDateTime>)pzzzzzzzzzzg_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> pzzzzzzzzzzh_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient pzzzzzzzzzzi_ = context.Operators.SingletonFrom<Patient>(pzzzzzzzzzzh_);

        return pzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? pzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return pzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> pzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return pzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? pzzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return pzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode pzzzzzzzzzzm_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return pzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzn_ = this.Emergency_Department_Evaluation_and_Management_Visit(context);
        IEnumerable<Encounter> pzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet pzzzzzzzzzzp_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> pzzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> pzzzzzzzzzzr_ = context.Operators.Union<Encounter>(pzzzzzzzzzzo_, pzzzzzzzzzzq_);
        CqlValueSet pzzzzzzzzzzs_ = this.Medical_Disability_Exam(context);
        IEnumerable<Encounter> pzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet pzzzzzzzzzzu_ = this.Office_Visit(context);
        IEnumerable<Encounter> pzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> pzzzzzzzzzzw_ = context.Operators.Union<Encounter>(pzzzzzzzzzzt_, pzzzzzzzzzzv_);
        IEnumerable<Encounter> pzzzzzzzzzzx_ = context.Operators.Union<Encounter>(pzzzzzzzzzzr_, pzzzzzzzzzzw_);
        CqlValueSet pzzzzzzzzzzy_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> pzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet qzzzzzzzzzza_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> qzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> qzzzzzzzzzzc_ = context.Operators.Union<Encounter>(pzzzzzzzzzzz_, qzzzzzzzzzzb_);
        IEnumerable<Encounter> qzzzzzzzzzzd_ = context.Operators.Union<Encounter>(pzzzzzzzzzzx_, qzzzzzzzzzzc_);
        CqlValueSet qzzzzzzzzzze_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> qzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet qzzzzzzzzzzg_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> qzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> qzzzzzzzzzzi_ = context.Operators.Union<Encounter>(qzzzzzzzzzzf_, qzzzzzzzzzzh_);
        IEnumerable<Encounter> qzzzzzzzzzzj_ = context.Operators.Union<Encounter>(qzzzzzzzzzzd_, qzzzzzzzzzzi_);
        CqlValueSet qzzzzzzzzzzk_ = this.Preventive_Care_Services_Group_Counseling(context);
        IEnumerable<Encounter> qzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> qzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? qzzzzzzzzzzn_(Encounter E)
        {
            List<CodeableConcept> rzzzzzzzzzzg_ = E?.Type;
            CqlConcept rzzzzzzzzzzh_(CodeableConcept @this)
            {
                CqlConcept rzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return rzzzzzzzzzzm_;
            };
            IEnumerable<CqlConcept> rzzzzzzzzzzi_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)rzzzzzzzzzzg_, rzzzzzzzzzzh_);
            bool? rzzzzzzzzzzj_(CqlConcept T)
            {
                CqlCode rzzzzzzzzzzn_ = this.Unlisted_preventive_medicine_service(context);
                CqlConcept rzzzzzzzzzzo_ = context.Operators.ConvertCodeToConcept(rzzzzzzzzzzn_);
                bool? rzzzzzzzzzzp_ = context.Operators.Equivalent(T, rzzzzzzzzzzo_);

                return rzzzzzzzzzzp_;
            };
            IEnumerable<CqlConcept> rzzzzzzzzzzk_ = context.Operators.Where<CqlConcept>(rzzzzzzzzzzi_, rzzzzzzzzzzj_);
            bool? rzzzzzzzzzzl_ = context.Operators.Exists<CqlConcept>(rzzzzzzzzzzk_);

            return rzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzo_ = context.Operators.Where<Encounter>(qzzzzzzzzzzm_, qzzzzzzzzzzn_);
        IEnumerable<Encounter> qzzzzzzzzzzp_ = context.Operators.Union<Encounter>(qzzzzzzzzzzl_, qzzzzzzzzzzo_);
        IEnumerable<Encounter> qzzzzzzzzzzq_ = context.Operators.Union<Encounter>(qzzzzzzzzzzj_, qzzzzzzzzzzp_);
        CqlValueSet qzzzzzzzzzzr_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> qzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet qzzzzzzzzzzt_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> qzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> qzzzzzzzzzzv_ = context.Operators.Union<Encounter>(qzzzzzzzzzzs_, qzzzzzzzzzzu_);
        IEnumerable<Encounter> qzzzzzzzzzzw_ = context.Operators.Union<Encounter>(qzzzzzzzzzzq_, qzzzzzzzzzzv_);
        CqlValueSet qzzzzzzzzzzx_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> qzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet qzzzzzzzzzzz_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> rzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> rzzzzzzzzzzb_ = context.Operators.Union<Encounter>(qzzzzzzzzzzy_, rzzzzzzzzzza_);
        IEnumerable<Encounter> rzzzzzzzzzzc_ = context.Operators.Union<Encounter>(qzzzzzzzzzzw_, rzzzzzzzzzzb_);
        IEnumerable<Encounter> rzzzzzzzzzzd_ = Status_1_8_000.Instance.isEncounterPerformed(context, rzzzzzzzzzzc_);
        bool? rzzzzzzzzzze_(Encounter ValidEncounter)
        {
            Period rzzzzzzzzzzq_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> rzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzr_ as object);
            CqlDateTime rzzzzzzzzzzt_ = context.Operators.End(rzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzu_ = this.Measurement_Period(context);
            CqlDateTime rzzzzzzzzzzv_ = context.Operators.Start(rzzzzzzzzzzu_);
            CqlDateTime rzzzzzzzzzzx_ = context.Operators.End(rzzzzzzzzzzu_);
            CqlQuantity rzzzzzzzzzzy_ = context.Operators.Quantity(3m, "days");
            CqlDateTime rzzzzzzzzzzz_ = context.Operators.Subtract(rzzzzzzzzzzx_, rzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> szzzzzzzzzza_ = context.Operators.Interval(rzzzzzzzzzzv_, rzzzzzzzzzzz_, true, true);
            bool? szzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzt_, szzzzzzzzzza_, "day");

            return szzzzzzzzzzb_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzf_ = context.Operators.Where<Encounter>(rzzzzzzzzzzd_, rzzzzzzzzzze_);

        return rzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Encounter With Antibiotic Ordered Within Three Days")]
    public IEnumerable<Encounter> Encounter_With_Antibiotic_Ordered_Within_Three_Days(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzc_ = this.Qualifying_Encounters(context);
        IEnumerable<Encounter> szzzzzzzzzzd_(Encounter EDOrAmbulatoryVisit)
        {
            CqlValueSet szzzzzzzzzzf_ = this.Antibiotic_Medications_for_Pharyngitis(context);
            IEnumerable<MedicationRequest> szzzzzzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> szzzzzzzzzzi_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> szzzzzzzzzzj_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzg_, szzzzzzzzzzi_);
            IEnumerable<MedicationRequest> szzzzzzzzzzk_ = Status_1_8_000.Instance.isMedicationOrder(context, szzzzzzzzzzj_);
            bool? szzzzzzzzzzl_(MedicationRequest AntibioticOrdered)
            {
                Period szzzzzzzzzzp_ = EDOrAmbulatoryVisit?.Period;
                CqlInterval<CqlDateTime> szzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzp_);
                CqlInterval<CqlDateTime> szzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzq_ as object);
                CqlDateTime szzzzzzzzzzs_ = context.Operators.Start(szzzzzzzzzzr_);
                FhirDateTime szzzzzzzzzzt_ = AntibioticOrdered?.AuthoredOnElement;
                CqlDateTime szzzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzt_);
                CqlQuantity szzzzzzzzzzv_ = context.Operators.Quantity(3m, "days");
                CqlDateTime szzzzzzzzzzw_ = context.Operators.Subtract(szzzzzzzzzzu_, szzzzzzzzzzv_);
                CqlDateTime szzzzzzzzzzy_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzt_);
                CqlInterval<CqlDateTime> szzzzzzzzzzz_ = context.Operators.Interval(szzzzzzzzzzw_, szzzzzzzzzzy_, true, true);
                bool? tzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzs_, szzzzzzzzzzz_, "day");
                CqlDateTime tzzzzzzzzzzc_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzt_);
                bool? tzzzzzzzzzzd_ = context.Operators.Not((bool?)(tzzzzzzzzzzc_ is null));
                bool? tzzzzzzzzzze_ = context.Operators.And(tzzzzzzzzzza_, tzzzzzzzzzzd_);

                return tzzzzzzzzzze_;
            };
            IEnumerable<MedicationRequest> szzzzzzzzzzm_ = context.Operators.Where<MedicationRequest>(szzzzzzzzzzk_, szzzzzzzzzzl_);
            Encounter szzzzzzzzzzn_(MedicationRequest AntibioticOrdered) =>
                EDOrAmbulatoryVisit;
            IEnumerable<Encounter> szzzzzzzzzzo_ = context.Operators.Select<MedicationRequest, Encounter>(szzzzzzzzzzm_, szzzzzzzzzzn_);

            return szzzzzzzzzzo_;
        };
        IEnumerable<Encounter> szzzzzzzzzze_ = context.Operators.SelectMany<Encounter, Encounter>(szzzzzzzzzzc_, szzzzzzzzzzd_);

        return szzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Pharyngitis or Tonsillitis")]
    public IEnumerable<Condition> Pharyngitis_or_Tonsillitis(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzf_ = this.Acute_Pharyngitis(context);
        IEnumerable<Condition> tzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet tzzzzzzzzzzh_ = this.Acute_Tonsillitis(context);
        IEnumerable<Condition> tzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> tzzzzzzzzzzj_ = context.Operators.Union<Condition>(tzzzzzzzzzzg_, tzzzzzzzzzzi_);

        return tzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Encounter With Pharyngitis or Tonsillitis With Antibiotic")]
    public IEnumerable<Encounter> Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzk_ = this.Encounter_With_Antibiotic_Ordered_Within_Three_Days(context);
        IEnumerable<Condition> tzzzzzzzzzzl_ = this.Pharyngitis_or_Tonsillitis(context);
        IEnumerable<ValueTuple<Encounter, Condition>> tzzzzzzzzzzm_ = context.Operators.CrossJoin<Encounter, Condition>(tzzzzzzzzzzk_, tzzzzzzzzzzl_);
        (CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)? tzzzzzzzzzzn_(ValueTuple<Encounter, Condition> _valueTuple)
        {
            (CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)? tzzzzzzzzzzu_ = (CqlTupleMetadata_BHcMAQBSeFPCjbDEhaVDLJXQU, _valueTuple.Item1, _valueTuple.Item2);

            return tzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)?> tzzzzzzzzzzo_ = context.Operators.Select<ValueTuple<Encounter, Condition>, (CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)?>(tzzzzzzzzzzm_, tzzzzzzzzzzn_);
        bool? tzzzzzzzzzzp_((CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)? tuple_ypyxedbbcqbdavhxvckuwmfh)
        {
            CqlInterval<CqlDateTime> tzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, tuple_ypyxedbbcqbdavhxvckuwmfh?.AcutePharyngitisTonsillitis);
            CqlDateTime tzzzzzzzzzzw_ = context.Operators.Start(tzzzzzzzzzzv_);
            Period tzzzzzzzzzzx_ = tuple_ypyxedbbcqbdavhxvckuwmfh?.VisitWithAntibiotic?.Period;
            CqlInterval<CqlDateTime> tzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzy_ as object);
            bool? uzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzw_, tzzzzzzzzzzz_, "day");

            return uzzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)?> tzzzzzzzzzzq_ = context.Operators.Where<(CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)?>(tzzzzzzzzzzo_, tzzzzzzzzzzp_);
        Encounter tzzzzzzzzzzr_((CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)? tuple_ypyxedbbcqbdavhxvckuwmfh) =>
            tuple_ypyxedbbcqbdavhxvckuwmfh?.VisitWithAntibiotic;
        IEnumerable<Encounter> tzzzzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, Encounter VisitWithAntibiotic, Condition AcutePharyngitisTonsillitis)?, Encounter>(tzzzzzzzzzzq_, tzzzzzzzzzzr_);
        IEnumerable<Encounter> tzzzzzzzzzzt_ = context.Operators.Distinct<Encounter>(tzzzzzzzzzzs_);

        return tzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzb_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);
        bool? uzzzzzzzzzzc_(Encounter EncounterWithPharyngitis)
        {
            Patient uzzzzzzzzzzh_ = this.Patient(context);
            Date uzzzzzzzzzzi_ = uzzzzzzzzzzh_?.BirthDateElement;
            string uzzzzzzzzzzj_ = uzzzzzzzzzzi_?.Value;
            CqlDate uzzzzzzzzzzk_ = context.Operators.ConvertStringToDate(uzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzl_ = this.Measurement_Period(context);
            CqlDateTime uzzzzzzzzzzm_ = context.Operators.Start(uzzzzzzzzzzl_);
            CqlDate uzzzzzzzzzzn_ = context.Operators.DateFrom(uzzzzzzzzzzm_);
            int? uzzzzzzzzzzo_ = context.Operators.CalculateAgeAt(uzzzzzzzzzzk_, uzzzzzzzzzzn_, "year");
            bool? uzzzzzzzzzzp_ = context.Operators.GreaterOrEqual(uzzzzzzzzzzo_, 3);

            return uzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzd_ = context.Operators.Where<Encounter>(uzzzzzzzzzzb_, uzzzzzzzzzzc_);
        Encounter uzzzzzzzzzze_(Encounter EncounterWithPharyngitis) =>
            EncounterWithPharyngitis;
        IEnumerable<Encounter> uzzzzzzzzzzf_ = context.Operators.Select<Encounter, Encounter>(uzzzzzzzzzzd_, uzzzzzzzzzze_);
        IEnumerable<Encounter> uzzzzzzzzzzg_ = context.Operators.Distinct<Encounter>(uzzzzzzzzzzf_);

        return uzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzq_ = this.Initial_Population(context);

        return uzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Encounters and Assessments with Hospice Patient")]
    public IEnumerable<Encounter> Encounters_and_Assessments_with_Hospice_Patient(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzr_ = this.Initial_Population(context);
        bool? uzzzzzzzzzzs_(Encounter EligibleEncounters)
        {
            bool? uzzzzzzzzzzu_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);

            return uzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzt_ = context.Operators.Where<Encounter>(uzzzzzzzzzzr_, uzzzzzzzzzzs_);

        return uzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzv_ = this.Encounters_and_Assessments_with_Hospice_Patient(context);
        IEnumerable<Encounter> uzzzzzzzzzzw_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);
        CqlValueSet uzzzzzzzzzzx_ = this.Comorbid_Conditions_for_Respiratory_Conditions(context);
        IEnumerable<Condition> uzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Encounter> uzzzzzzzzzzz_ = Antibiotic_1_7_000.Instance.Has_Comorbid_Condition_History(context, uzzzzzzzzzzw_, uzzzzzzzzzzy_);
        IEnumerable<Encounter> vzzzzzzzzzza_ = context.Operators.Union<Encounter>(uzzzzzzzzzzv_, uzzzzzzzzzzz_);
        CqlValueSet vzzzzzzzzzzc_ = this.Antibiotic_Medications_for_Pharyngitis(context);
        IEnumerable<MedicationRequest> vzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, vzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> vzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, vzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> vzzzzzzzzzzg_ = context.Operators.Union<MedicationRequest>(vzzzzzzzzzzd_, vzzzzzzzzzzf_);
        IEnumerable<MedicationRequest> vzzzzzzzzzzh_ = Status_1_8_000.Instance.isMedicationActive(context, vzzzzzzzzzzg_);
        IEnumerable<Encounter> vzzzzzzzzzzi_ = Antibiotic_1_7_000.Instance.Has_Antibiotic_Medication_History(context, uzzzzzzzzzzw_, vzzzzzzzzzzh_);
        CqlValueSet vzzzzzzzzzzk_ = this.Competing_Conditions_for_Respiratory_Conditions(context);
        IEnumerable<Condition> vzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Encounter> vzzzzzzzzzzm_ = Antibiotic_1_7_000.Instance.Has_Competing_Diagnosis_History(context, uzzzzzzzzzzw_, vzzzzzzzzzzl_);
        IEnumerable<Encounter> vzzzzzzzzzzn_ = context.Operators.Union<Encounter>(vzzzzzzzzzzi_, vzzzzzzzzzzm_);
        IEnumerable<Encounter> vzzzzzzzzzzo_ = context.Operators.Union<Encounter>(vzzzzzzzzzza_, vzzzzzzzzzzn_);

        return vzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Group A Streptococcus Lab Test With Result")]
    public IEnumerable<Observation> Group_A_Streptococcus_Lab_Test_With_Result(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzp_ = this.Group_A_Streptococcus_Test(context);
        IEnumerable<Observation> vzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, vzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> vzzzzzzzzzzr_ = Status_1_8_000.Instance.isLaboratoryTestPerformed(context, vzzzzzzzzzzq_);
        bool? vzzzzzzzzzzs_(Observation GroupAStreptococcusTest)
        {
            DataType vzzzzzzzzzzu_ = GroupAStreptococcusTest?.Value;
            object vzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzu_);
            bool? vzzzzzzzzzzw_ = context.Operators.Not((bool?)(vzzzzzzzzzzv_ is null));

            return vzzzzzzzzzzw_;
        };
        IEnumerable<Observation> vzzzzzzzzzzt_ = context.Operators.Where<Observation>(vzzzzzzzzzzr_, vzzzzzzzzzzs_);

        return vzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Observation> vzzzzzzzzzzx_ = this.Group_A_Streptococcus_Lab_Test_With_Result(context);
        IEnumerable<Encounter> vzzzzzzzzzzy_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);
        IEnumerable<ValueTuple<Observation, Encounter>> vzzzzzzzzzzz_ = context.Operators.CrossJoin<Observation, Encounter>(vzzzzzzzzzzx_, vzzzzzzzzzzy_);
        (CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)? wzzzzzzzzzza_(ValueTuple<Observation, Encounter> _valueTuple)
        {
            (CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)? wzzzzzzzzzzh_ = (CqlTupleMetadata_FeNRUFDKGVUFAMiQLLieSFHIV, _valueTuple.Item1, _valueTuple.Item2);

            return wzzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)?> wzzzzzzzzzzb_ = context.Operators.Select<ValueTuple<Observation, Encounter>, (CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)?>(vzzzzzzzzzzz_, wzzzzzzzzzza_);
        bool? wzzzzzzzzzzc_((CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)? tuple_ffguysnebcxllexfcmjoehbij)
        {
            DataType wzzzzzzzzzzi_ = tuple_ffguysnebcxllexfcmjoehbij?.GroupAStreptococcusTest?.Effective;
            object wzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzj_);
            CqlDateTime wzzzzzzzzzzl_ = context.Operators.Start(wzzzzzzzzzzk_);
            Period wzzzzzzzzzzm_ = tuple_ffguysnebcxllexfcmjoehbij?.EncounterWithPharyngitis?.Period;
            CqlInterval<CqlDateTime> wzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzm_);
            CqlDateTime wzzzzzzzzzzo_ = context.Operators.End(wzzzzzzzzzzn_);
            CqlQuantity wzzzzzzzzzzp_ = context.Operators.Quantity(3m, "days");
            CqlDateTime wzzzzzzzzzzq_ = context.Operators.Subtract(wzzzzzzzzzzo_, wzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzm_);
            CqlDateTime wzzzzzzzzzzt_ = context.Operators.End(wzzzzzzzzzzs_);
            CqlDateTime wzzzzzzzzzzv_ = context.Operators.Add(wzzzzzzzzzzt_, wzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzw_ = context.Operators.Interval(wzzzzzzzzzzq_, wzzzzzzzzzzv_, true, true);
            bool? wzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzl_, wzzzzzzzzzzw_, "day");

            return wzzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)?> wzzzzzzzzzzd_ = context.Operators.Where<(CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)?>(wzzzzzzzzzzb_, wzzzzzzzzzzc_);
        Encounter wzzzzzzzzzze_((CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)? tuple_ffguysnebcxllexfcmjoehbij) =>
            tuple_ffguysnebcxllexfcmjoehbij?.EncounterWithPharyngitis;
        IEnumerable<Encounter> wzzzzzzzzzzf_ = context.Operators.Select<(CqlTupleMetadata, Observation GroupAStreptococcusTest, Encounter EncounterWithPharyngitis)?, Encounter>(wzzzzzzzzzzd_, wzzzzzzzzzze_);
        IEnumerable<Encounter> wzzzzzzzzzzg_ = context.Operators.Distinct<Encounter>(wzzzzzzzzzzf_);

        return wzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Stratification 1")]
    public IEnumerable<Encounter> Stratification_1(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzy_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);
        bool? wzzzzzzzzzzz_(Encounter EncounterWithPharyngitis)
        {
            Patient xzzzzzzzzzze_ = this.Patient(context);
            Date xzzzzzzzzzzf_ = xzzzzzzzzzze_?.BirthDateElement;
            string xzzzzzzzzzzg_ = xzzzzzzzzzzf_?.Value;
            CqlDate xzzzzzzzzzzh_ = context.Operators.ConvertStringToDate(xzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzi_ = this.Measurement_Period(context);
            CqlDateTime xzzzzzzzzzzj_ = context.Operators.Start(xzzzzzzzzzzi_);
            CqlDate xzzzzzzzzzzk_ = context.Operators.DateFrom(xzzzzzzzzzzj_);
            int? xzzzzzzzzzzl_ = context.Operators.CalculateAgeAt(xzzzzzzzzzzh_, xzzzzzzzzzzk_, "year");
            CqlInterval<int?> xzzzzzzzzzzm_ = context.Operators.Interval(3, 17, true, true);
            bool? xzzzzzzzzzzn_ = context.Operators.In<int?>(xzzzzzzzzzzl_, xzzzzzzzzzzm_, default);

            return xzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> xzzzzzzzzzza_ = context.Operators.Where<Encounter>(wzzzzzzzzzzy_, wzzzzzzzzzzz_);
        Encounter xzzzzzzzzzzb_(Encounter EncounterWithPharyngitis) =>
            EncounterWithPharyngitis;
        IEnumerable<Encounter> xzzzzzzzzzzc_ = context.Operators.Select<Encounter, Encounter>(xzzzzzzzzzza_, xzzzzzzzzzzb_);
        IEnumerable<Encounter> xzzzzzzzzzzd_ = context.Operators.Distinct<Encounter>(xzzzzzzzzzzc_);

        return xzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public IEnumerable<Encounter> Stratification_2(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzo_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);
        bool? xzzzzzzzzzzp_(Encounter EncounterWithPharyngitis)
        {
            Patient xzzzzzzzzzzu_ = this.Patient(context);
            Date xzzzzzzzzzzv_ = xzzzzzzzzzzu_?.BirthDateElement;
            string xzzzzzzzzzzw_ = xzzzzzzzzzzv_?.Value;
            CqlDate xzzzzzzzzzzx_ = context.Operators.ConvertStringToDate(xzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzy_ = this.Measurement_Period(context);
            CqlDateTime xzzzzzzzzzzz_ = context.Operators.Start(xzzzzzzzzzzy_);
            CqlDate yzzzzzzzzzza_ = context.Operators.DateFrom(xzzzzzzzzzzz_);
            int? yzzzzzzzzzzb_ = context.Operators.CalculateAgeAt(xzzzzzzzzzzx_, yzzzzzzzzzza_, "year");
            CqlInterval<int?> yzzzzzzzzzzc_ = context.Operators.Interval(18, 64, true, true);
            bool? yzzzzzzzzzzd_ = context.Operators.In<int?>(yzzzzzzzzzzb_, yzzzzzzzzzzc_, default);

            return yzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzq_ = context.Operators.Where<Encounter>(xzzzzzzzzzzo_, xzzzzzzzzzzp_);
        Encounter xzzzzzzzzzzr_(Encounter EncounterWithPharyngitis) =>
            EncounterWithPharyngitis;
        IEnumerable<Encounter> xzzzzzzzzzzs_ = context.Operators.Select<Encounter, Encounter>(xzzzzzzzzzzq_, xzzzzzzzzzzr_);
        IEnumerable<Encounter> xzzzzzzzzzzt_ = context.Operators.Distinct<Encounter>(xzzzzzzzzzzs_);

        return xzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Stratification 3")]
    public IEnumerable<Encounter> Stratification_3(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzze_ = this.Encounter_With_Pharyngitis_or_Tonsillitis_With_Antibiotic(context);
        bool? yzzzzzzzzzzf_(Encounter EncounterWithPharyngitis)
        {
            Patient yzzzzzzzzzzk_ = this.Patient(context);
            Date yzzzzzzzzzzl_ = yzzzzzzzzzzk_?.BirthDateElement;
            string yzzzzzzzzzzm_ = yzzzzzzzzzzl_?.Value;
            CqlDate yzzzzzzzzzzn_ = context.Operators.ConvertStringToDate(yzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzo_ = this.Measurement_Period(context);
            CqlDateTime yzzzzzzzzzzp_ = context.Operators.Start(yzzzzzzzzzzo_);
            CqlDate yzzzzzzzzzzq_ = context.Operators.DateFrom(yzzzzzzzzzzp_);
            int? yzzzzzzzzzzr_ = context.Operators.CalculateAgeAt(yzzzzzzzzzzn_, yzzzzzzzzzzq_, "year");
            bool? yzzzzzzzzzzs_ = context.Operators.GreaterOrEqual(yzzzzzzzzzzr_, 65);

            return yzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzg_ = context.Operators.Where<Encounter>(yzzzzzzzzzze_, yzzzzzzzzzzf_);
        Encounter yzzzzzzzzzzh_(Encounter EncounterWithPharyngitis) =>
            EncounterWithPharyngitis;
        IEnumerable<Encounter> yzzzzzzzzzzi_ = context.Operators.Select<Encounter, Encounter>(yzzzzzzzzzzg_, yzzzzzzzzzzh_);
        IEnumerable<Encounter> yzzzzzzzzzzj_ = context.Operators.Distinct<Encounter>(yzzzzzzzzzzi_);

        return yzzzzzzzzzzj_;
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
