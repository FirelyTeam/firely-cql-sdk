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
[CqlLibrary("FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR", "0.1.001")]
public partial class FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_001 : ILibrary, ISingleton<FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_001>
{
    private FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_001() {}

    public static FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR_0_1_001 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR";
    public string Version => "0.1.001";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance, CQMCommon_2_2_000.Instance, Hospice_6_12_000.Instance, CumulativeMedicationDuration_4_1_000.Instance, Status_1_8_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Ambulatory", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1003", valueSetVersion: null)]
    public CqlValueSet Ambulatory(CqlContext _) => _Ambulatory;
    private static readonly CqlValueSet _Ambulatory = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1003", null);

    [CqlValueSetDefinition("Atomoxetine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1170", valueSetVersion: null)]
    public CqlValueSet Atomoxetine(CqlContext _) => _Atomoxetine;
    private static readonly CqlValueSet _Atomoxetine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1170", null);

    [CqlValueSetDefinition("Behavioral Health Follow up Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1054", valueSetVersion: null)]
    public CqlValueSet Behavioral_Health_Follow_up_Visit(CqlContext _) => _Behavioral_Health_Follow_up_Visit;
    private static readonly CqlValueSet _Behavioral_Health_Follow_up_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1054", null);

    [CqlValueSetDefinition("Clonidine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1171", valueSetVersion: null)]
    public CqlValueSet Clonidine(CqlContext _) => _Clonidine;
    private static readonly CqlValueSet _Clonidine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1171", null);

    [CqlValueSetDefinition("Dexmethylphenidate", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1172", valueSetVersion: null)]
    public CqlValueSet Dexmethylphenidate(CqlContext _) => _Dexmethylphenidate;
    private static readonly CqlValueSet _Dexmethylphenidate = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1172", null);

    [CqlValueSetDefinition("Dextroamphetamine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1173", valueSetVersion: null)]
    public CqlValueSet Dextroamphetamine(CqlContext _) => _Dextroamphetamine;
    private static readonly CqlValueSet _Dextroamphetamine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1173", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Guanfacine Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.11.1252", valueSetVersion: null)]
    public CqlValueSet Guanfacine_Medications(CqlContext _) => _Guanfacine_Medications;
    private static readonly CqlValueSet _Guanfacine_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.11.1252", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("Lisdexamfetamine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1174", valueSetVersion: null)]
    public CqlValueSet Lisdexamfetamine(CqlContext _) => _Lisdexamfetamine;
    private static readonly CqlValueSet _Lisdexamfetamine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1174", null);

    [CqlValueSetDefinition("Mental Behavioral and Neurodevelopmental Disorders", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1203", valueSetVersion: null)]
    public CqlValueSet Mental_Behavioral_and_Neurodevelopmental_Disorders(CqlContext _) => _Mental_Behavioral_and_Neurodevelopmental_Disorders;
    private static readonly CqlValueSet _Mental_Behavioral_and_Neurodevelopmental_Disorders = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1203", null);

    [CqlValueSetDefinition("Methylphenidate", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1176", valueSetVersion: null)]
    public CqlValueSet Methylphenidate(CqlContext _) => _Methylphenidate;
    private static readonly CqlValueSet _Methylphenidate = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1176", null);

    [CqlValueSetDefinition("Narcolepsy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.114.12.1011", valueSetVersion: null)]
    public CqlValueSet Narcolepsy(CqlContext _) => _Narcolepsy;
    private static readonly CqlValueSet _Narcolepsy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.114.12.1011", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Outpatient Consultation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext _) => _Outpatient_Consultation;
    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlValueSetDefinition("Preventive Care Services Group Counseling", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Group_Counseling(CqlContext _) => _Preventive_Care_Services_Group_Counseling;
    private static readonly CqlValueSet _Preventive_Care_Services_Group_Counseling = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027", null);

    [CqlValueSetDefinition("Preventive Care Services Individual Counseling", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Individual_Counseling(CqlContext _) => _Preventive_Care_Services_Individual_Counseling;
    private static readonly CqlValueSet _Preventive_Care_Services_Individual_Counseling = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", null);

    [CqlValueSetDefinition("Preventive Care Services, Initial Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care_Services__Initial_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);

    [CqlValueSetDefinition("Preventive Care, Established Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", valueSetVersion: null)]
    public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care__Established_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care__Established_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);

    [CqlValueSetDefinition("Psych Visit Diagnostic Evaluation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492", valueSetVersion: null)]
    public CqlValueSet Psych_Visit_Diagnostic_Evaluation(CqlContext _) => _Psych_Visit_Diagnostic_Evaluation;
    private static readonly CqlValueSet _Psych_Visit_Diagnostic_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492", null);

    [CqlValueSetDefinition("Psych Visit Psychotherapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", valueSetVersion: null)]
    public CqlValueSet Psych_Visit_Psychotherapy(CqlContext _) => _Psych_Visit_Psychotherapy;
    private static readonly CqlValueSet _Psych_Visit_Psychotherapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", null);

    [CqlValueSetDefinition("Psychotherapy and Pharmacologic Management", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1055", valueSetVersion: null)]
    public CqlValueSet Psychotherapy_and_Pharmacologic_Management(CqlContext _) => _Psychotherapy_and_Pharmacologic_Management;
    private static readonly CqlValueSet _Psychotherapy_and_Pharmacologic_Management = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1055", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlValueSetDefinition("Virtual Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", valueSetVersion: null)]
    public CqlValueSet Virtual_Encounter(CqlContext _) => _Virtual_Encounter;
    private static readonly CqlValueSet _Virtual_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("24 HR dexmethylphenidate hydrochloride 40 MG Extended Release Oral Capsule", codeId: "1006608", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode _24_HR_dexmethylphenidate_hydrochloride_40_MG_Extended_Release_Oral_Capsule(CqlContext _) => __24_HR_dexmethylphenidate_hydrochloride_40_MG_Extended_Release_Oral_Capsule;
    private static readonly CqlCode __24_HR_dexmethylphenidate_hydrochloride_40_MG_Extended_Release_Oral_Capsule = new CqlCode("1006608", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlCodeDefinition("methamphetamine hydrochloride 5 MG Oral Tablet", codeId: "977860", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode methamphetamine_hydrochloride_5_MG_Oral_Tablet(CqlContext _) => _methamphetamine_hydrochloride_5_MG_Oral_Tablet;
    private static readonly CqlCode _methamphetamine_hydrochloride_5_MG_Oral_Tablet = new CqlCode("977860", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("RXNORM")]
    public CqlCodeSystem RXNORM(CqlContext _) => _RXNORM;
    private static readonly CqlCodeSystem _RXNORM = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime azzzzzzzzzzzzzo_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime azzzzzzzzzzzzzp_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> azzzzzzzzzzzzzq_ = context.Operators.Interval(azzzzzzzzzzzzzo_, azzzzzzzzzzzzzp_, true, true);
        object azzzzzzzzzzzzzr_ = context.ResolveParameter("FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR-0.1.001", "Measurement Period", azzzzzzzzzzzzzq_);

        return (CqlInterval<CqlDateTime>)azzzzzzzzzzzzzr_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> azzzzzzzzzzzzzs_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient azzzzzzzzzzzzzt_ = context.Operators.SingletonFrom<Patient>(azzzzzzzzzzzzzs_);

        return azzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("March 1 of Year Prior to Measurement Period")]
    public CqlDateTime March_1_of_Year_Prior_to_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> azzzzzzzzzzzzzu_ = this.Measurement_Period(context);
        CqlDateTime azzzzzzzzzzzzzv_ = context.Operators.Start(azzzzzzzzzzzzzu_);
        int? azzzzzzzzzzzzzw_ = context.Operators.DateTimeComponentFrom(azzzzzzzzzzzzzv_, "year");
        int? azzzzzzzzzzzzzx_ = context.Operators.Subtract(azzzzzzzzzzzzzw_, 1);
        decimal? azzzzzzzzzzzzzy_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime azzzzzzzzzzzzzz_ = context.Operators.DateTime(azzzzzzzzzzzzzx_, 3, 1, 0, 0, 0, 0, azzzzzzzzzzzzzy_);

        return azzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Last Calendar Day of February of Measurement Period")]
    public CqlDateTime Last_Calendar_Day_of_February_of_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> bzzzzzzzzzzzzza_ = this.Measurement_Period(context);
        CqlDateTime bzzzzzzzzzzzzzb_ = context.Operators.Start(bzzzzzzzzzzzzza_);
        int? bzzzzzzzzzzzzzc_ = context.Operators.DateTimeComponentFrom(bzzzzzzzzzzzzzb_, "year");
        decimal? bzzzzzzzzzzzzzd_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime bzzzzzzzzzzzzze_ = context.Operators.DateTime(bzzzzzzzzzzzzzc_, 3, 1, 23, 59, 59, 0, bzzzzzzzzzzzzzd_);
        CqlQuantity bzzzzzzzzzzzzzf_ = context.Operators.Quantity(1m, "day");
        CqlDateTime bzzzzzzzzzzzzzg_ = context.Operators.Subtract(bzzzzzzzzzzzzze_, bzzzzzzzzzzzzzf_);

        return bzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Intake Period")]
    public CqlInterval<CqlDateTime> Intake_Period(CqlContext context)
    {
        CqlDateTime bzzzzzzzzzzzzzh_ = this.March_1_of_Year_Prior_to_Measurement_Period(context);
        CqlDateTime bzzzzzzzzzzzzzi_ = this.Last_Calendar_Day_of_February_of_Measurement_Period(context);
        CqlInterval<CqlDateTime> bzzzzzzzzzzzzzj_ = context.Operators.Interval(bzzzzzzzzzzzzzh_, bzzzzzzzzzzzzzi_, true, true);

        return bzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("ADHD Medication Prescribed During Intake Period and Not Previously on ADHD Medication")]
    public IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzk_ = this.Atomoxetine(context);
        IEnumerable<MedicationRequest> bzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bzzzzzzzzzzzzzo_ = context.Operators.Union<MedicationRequest>(bzzzzzzzzzzzzzl_, bzzzzzzzzzzzzzn_);
        CqlValueSet bzzzzzzzzzzzzzp_ = this.Clonidine(context);
        IEnumerable<MedicationRequest> bzzzzzzzzzzzzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bzzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bzzzzzzzzzzzzzt_ = context.Operators.Union<MedicationRequest>(bzzzzzzzzzzzzzq_, bzzzzzzzzzzzzzs_);
        IEnumerable<MedicationRequest> bzzzzzzzzzzzzzu_ = context.Operators.Union<MedicationRequest>(bzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzt_);
        CqlValueSet bzzzzzzzzzzzzzv_ = this.Dexmethylphenidate(context);
        IEnumerable<MedicationRequest> bzzzzzzzzzzzzzw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bzzzzzzzzzzzzzy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bzzzzzzzzzzzzzz_ = context.Operators.Union<MedicationRequest>(bzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzy_);
        IEnumerable<MedicationRequest> czzzzzzzzzzzzza_ = context.Operators.Union<MedicationRequest>(bzzzzzzzzzzzzzu_, bzzzzzzzzzzzzzz_);
        CqlValueSet czzzzzzzzzzzzzb_ = this.Dextroamphetamine(context);
        IEnumerable<MedicationRequest> czzzzzzzzzzzzzc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> czzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> czzzzzzzzzzzzzf_ = context.Operators.Union<MedicationRequest>(czzzzzzzzzzzzzc_, czzzzzzzzzzzzze_);
        IEnumerable<MedicationRequest> czzzzzzzzzzzzzg_ = context.Operators.Union<MedicationRequest>(czzzzzzzzzzzzza_, czzzzzzzzzzzzzf_);
        CqlValueSet czzzzzzzzzzzzzh_ = this.Lisdexamfetamine(context);
        IEnumerable<MedicationRequest> czzzzzzzzzzzzzi_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> czzzzzzzzzzzzzk_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> czzzzzzzzzzzzzl_ = context.Operators.Union<MedicationRequest>(czzzzzzzzzzzzzi_, czzzzzzzzzzzzzk_);
        IEnumerable<MedicationRequest> czzzzzzzzzzzzzm_ = context.Operators.Union<MedicationRequest>(czzzzzzzzzzzzzg_, czzzzzzzzzzzzzl_);
        CqlCode czzzzzzzzzzzzzn_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
        IEnumerable<CqlCode> czzzzzzzzzzzzzo_ = context.Operators.ToList<CqlCode>(czzzzzzzzzzzzzn_);
        IEnumerable<MedicationRequest> czzzzzzzzzzzzzp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, czzzzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<CqlCode> czzzzzzzzzzzzzr_ = context.Operators.ToList<CqlCode>(czzzzzzzzzzzzzn_);
        IEnumerable<MedicationRequest> czzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, czzzzzzzzzzzzzr_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> czzzzzzzzzzzzzt_ = context.Operators.Union<MedicationRequest>(czzzzzzzzzzzzzp_, czzzzzzzzzzzzzs_);
        IEnumerable<MedicationRequest> czzzzzzzzzzzzzu_ = context.Operators.Union<MedicationRequest>(czzzzzzzzzzzzzm_, czzzzzzzzzzzzzt_);
        CqlValueSet czzzzzzzzzzzzzv_ = this.Methylphenidate(context);
        IEnumerable<MedicationRequest> czzzzzzzzzzzzzw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> czzzzzzzzzzzzzy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> czzzzzzzzzzzzzz_ = context.Operators.Union<MedicationRequest>(czzzzzzzzzzzzzw_, czzzzzzzzzzzzzy_);
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzza_ = context.Operators.Union<MedicationRequest>(czzzzzzzzzzzzzu_, czzzzzzzzzzzzzz_);
        CqlValueSet dzzzzzzzzzzzzzb_ = this.Guanfacine_Medications(context);
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzf_ = context.Operators.Union<MedicationRequest>(dzzzzzzzzzzzzzc_, dzzzzzzzzzzzzze_);
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzg_ = context.Operators.Union<MedicationRequest>(dzzzzzzzzzzzzza_, dzzzzzzzzzzzzzf_);
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzh_ = Status_1_8_000.Instance.isMedicationOrder(context, dzzzzzzzzzzzzzg_);
        bool? dzzzzzzzzzzzzzi_(MedicationRequest ADHDMedications)
        {
            CqlInterval<CqlDate> fzzzzzzzzzzzzzr_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ADHDMedications);
            CqlDate fzzzzzzzzzzzzzs_ = context.Operators.Start(fzzzzzzzzzzzzzr_);
            CqlDateTime fzzzzzzzzzzzzzt_ = context.Operators.ConvertDateToDateTime(fzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzu_ = this.Intake_Period(context);
            bool? fzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzu_, default);

            return fzzzzzzzzzzzzzv_;
        };
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzj_ = context.Operators.Where<MedicationRequest>(dzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzi_);
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzo_ = context.Operators.Union<MedicationRequest>(dzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzn_);
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzt_ = context.Operators.Union<MedicationRequest>(dzzzzzzzzzzzzzq_, dzzzzzzzzzzzzzs_);
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzu_ = context.Operators.Union<MedicationRequest>(dzzzzzzzzzzzzzo_, dzzzzzzzzzzzzzt_);
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzz_ = context.Operators.Union<MedicationRequest>(dzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzy_);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzza_ = context.Operators.Union<MedicationRequest>(dzzzzzzzzzzzzzu_, dzzzzzzzzzzzzzz_);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzf_ = context.Operators.Union<MedicationRequest>(ezzzzzzzzzzzzzc_, ezzzzzzzzzzzzze_);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzg_ = context.Operators.Union<MedicationRequest>(ezzzzzzzzzzzzza_, ezzzzzzzzzzzzzf_);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzi_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzk_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzl_ = context.Operators.Union<MedicationRequest>(ezzzzzzzzzzzzzi_, ezzzzzzzzzzzzzk_);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzm_ = context.Operators.Union<MedicationRequest>(ezzzzzzzzzzzzzg_, ezzzzzzzzzzzzzl_);
        IEnumerable<CqlCode> ezzzzzzzzzzzzzo_ = context.Operators.ToList<CqlCode>(czzzzzzzzzzzzzn_);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, ezzzzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<CqlCode> ezzzzzzzzzzzzzr_ = context.Operators.ToList<CqlCode>(czzzzzzzzzzzzzn_);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, ezzzzzzzzzzzzzr_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzt_ = context.Operators.Union<MedicationRequest>(ezzzzzzzzzzzzzp_, ezzzzzzzzzzzzzs_);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzu_ = context.Operators.Union<MedicationRequest>(ezzzzzzzzzzzzzm_, ezzzzzzzzzzzzzt_);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzz_ = context.Operators.Union<MedicationRequest>(ezzzzzzzzzzzzzw_, ezzzzzzzzzzzzzy_);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzza_ = context.Operators.Union<MedicationRequest>(ezzzzzzzzzzzzzu_, ezzzzzzzzzzzzzz_);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzf_ = context.Operators.Union<MedicationRequest>(fzzzzzzzzzzzzzc_, fzzzzzzzzzzzzze_);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzg_ = context.Operators.Union<MedicationRequest>(fzzzzzzzzzzzzza_, fzzzzzzzzzzzzzf_);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzh_ = Status_1_8_000.Instance.isMedicationOrder(context, fzzzzzzzzzzzzzg_);
        bool? fzzzzzzzzzzzzzi_(MedicationRequest ADHDMedications)
        {
            CqlInterval<CqlDate> fzzzzzzzzzzzzzw_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ADHDMedications);
            CqlDate fzzzzzzzzzzzzzx_ = context.Operators.Start(fzzzzzzzzzzzzzw_);
            CqlDateTime fzzzzzzzzzzzzzy_ = context.Operators.ConvertDateToDateTime(fzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzz_ = this.Intake_Period(context);
            bool? gzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzz_, default);

            return gzzzzzzzzzzzzza_;
        };
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzj_ = context.Operators.Where<MedicationRequest>(fzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzi_);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzk_(MedicationRequest ADHDMedicationOrder)
        {
            CqlValueSet gzzzzzzzzzzzzzb_ = this.Atomoxetine(context);
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzzc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzzf_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzc_, gzzzzzzzzzzzzze_);
            CqlValueSet gzzzzzzzzzzzzzg_ = this.Clonidine(context);
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzzk_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzj_);
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzzl_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzf_, gzzzzzzzzzzzzzk_);
            CqlValueSet gzzzzzzzzzzzzzm_ = this.Dexmethylphenidate(context);
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzzp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzzq_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzn_, gzzzzzzzzzzzzzp_);
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzzr_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzq_);
            CqlValueSet gzzzzzzzzzzzzzs_ = this.Dextroamphetamine(context);
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzzv_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzzw_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzt_, gzzzzzzzzzzzzzv_);
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzzx_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzw_);
            CqlValueSet gzzzzzzzzzzzzzy_ = this.Lisdexamfetamine(context);
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> hzzzzzzzzzzzzzb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> hzzzzzzzzzzzzzc_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzz_, hzzzzzzzzzzzzzb_);
            IEnumerable<MedicationRequest> hzzzzzzzzzzzzzd_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzx_, hzzzzzzzzzzzzzc_);
            CqlCode hzzzzzzzzzzzzze_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
            IEnumerable<CqlCode> hzzzzzzzzzzzzzf_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzzze_);
            IEnumerable<MedicationRequest> hzzzzzzzzzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, hzzzzzzzzzzzzzf_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<CqlCode> hzzzzzzzzzzzzzi_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzzze_);
            IEnumerable<MedicationRequest> hzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, hzzzzzzzzzzzzzi_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> hzzzzzzzzzzzzzk_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzj_);
            IEnumerable<MedicationRequest> hzzzzzzzzzzzzzl_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzk_);
            CqlValueSet hzzzzzzzzzzzzzm_ = this.Methylphenidate(context);
            IEnumerable<MedicationRequest> hzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> hzzzzzzzzzzzzzp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> hzzzzzzzzzzzzzq_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzn_, hzzzzzzzzzzzzzp_);
            IEnumerable<MedicationRequest> hzzzzzzzzzzzzzr_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzq_);
            CqlValueSet hzzzzzzzzzzzzzs_ = this.Guanfacine_Medications(context);
            IEnumerable<MedicationRequest> hzzzzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> hzzzzzzzzzzzzzv_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> hzzzzzzzzzzzzzw_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzv_);
            IEnumerable<MedicationRequest> hzzzzzzzzzzzzzx_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzw_);
            IEnumerable<MedicationRequest> hzzzzzzzzzzzzzy_ = Status_1_8_000.Instance.isMedicationActive(context, hzzzzzzzzzzzzzx_);
            bool? hzzzzzzzzzzzzzz_(MedicationRequest ActiveADHDMedication)
            {
                CqlInterval<CqlDate> izzzzzzzzzzzzzd_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ActiveADHDMedication);
                CqlInterval<CqlDate> izzzzzzzzzzzzze_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ADHDMedicationOrder);
                CqlDate izzzzzzzzzzzzzf_ = context.Operators.Start(izzzzzzzzzzzzze_);
                CqlDateTime izzzzzzzzzzzzzg_ = context.Operators.ConvertDateToDateTime(izzzzzzzzzzzzzf_);
                CqlDate izzzzzzzzzzzzzh_ = context.Operators.DateFrom(izzzzzzzzzzzzzg_);
                CqlQuantity izzzzzzzzzzzzzi_ = context.Operators.Quantity(120m, "days");
                CqlDate izzzzzzzzzzzzzj_ = context.Operators.Subtract(izzzzzzzzzzzzzh_, izzzzzzzzzzzzzi_);
                CqlDate izzzzzzzzzzzzzl_ = context.Operators.Start(izzzzzzzzzzzzze_);
                CqlDateTime izzzzzzzzzzzzzm_ = context.Operators.ConvertDateToDateTime(izzzzzzzzzzzzzl_);
                CqlDate izzzzzzzzzzzzzn_ = context.Operators.DateFrom(izzzzzzzzzzzzzm_);
                CqlInterval<CqlDate> izzzzzzzzzzzzzo_ = context.Operators.Interval(izzzzzzzzzzzzzj_, izzzzzzzzzzzzzn_, true, false);
                bool? izzzzzzzzzzzzzp_ = context.Operators.Overlaps(izzzzzzzzzzzzzd_, izzzzzzzzzzzzzo_, default);

                return izzzzzzzzzzzzzp_;
            };
            IEnumerable<MedicationRequest> izzzzzzzzzzzzza_ = context.Operators.Where<MedicationRequest>(hzzzzzzzzzzzzzy_, hzzzzzzzzzzzzzz_);
            MedicationRequest izzzzzzzzzzzzzb_(MedicationRequest ActiveADHDMedication) =>
                ADHDMedicationOrder;
            IEnumerable<MedicationRequest> izzzzzzzzzzzzzc_ = context.Operators.Select<MedicationRequest, MedicationRequest>(izzzzzzzzzzzzza_, izzzzzzzzzzzzzb_);

            return izzzzzzzzzzzzzc_;
        };
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzl_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(fzzzzzzzzzzzzzj_, fzzzzzzzzzzzzzk_);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzm_ = context.Operators.Except<MedicationRequest>(dzzzzzzzzzzzzzj_, fzzzzzzzzzzzzzl_);
        (CqlTupleMetadata, CqlDate startDate)? fzzzzzzzzzzzzzn_(MedicationRequest QualifyingMed)
        {
            CqlInterval<CqlDate> izzzzzzzzzzzzzq_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, QualifyingMed);
            CqlDate izzzzzzzzzzzzzr_ = context.Operators.Start(izzzzzzzzzzzzzq_);
            (CqlTupleMetadata, CqlDate startDate)? izzzzzzzzzzzzzs_ = (CqlTupleMetadata_CVELXTjiMTaGQEjMfJXBdUHjW, izzzzzzzzzzzzzr_);

            return izzzzzzzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> fzzzzzzzzzzzzzo_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlDate startDate)?>(fzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzn_);
        object fzzzzzzzzzzzzzp_((CqlTupleMetadata, CqlDate startDate)? @this)
        {
            CqlDate izzzzzzzzzzzzzt_ = @this?.startDate;

            return izzzzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> fzzzzzzzzzzzzzq_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDate startDate)?>(fzzzzzzzzzzzzzo_, fzzzzzzzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);

        return fzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("First ADHD Medication Prescribed During Intake Period")]
    public CqlDate First_ADHD_Medication_Prescribed_During_Intake_Period(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> izzzzzzzzzzzzzu_ = this.ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication(context);
        bool? izzzzzzzzzzzzzv_((CqlTupleMetadata, CqlDate startDate)? @this)
        {
            CqlDate jzzzzzzzzzzzzza_ = @this?.startDate;
            bool? jzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzza_ is null));

            return jzzzzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> izzzzzzzzzzzzzw_ = context.Operators.Where<(CqlTupleMetadata, CqlDate startDate)?>(izzzzzzzzzzzzzu_, izzzzzzzzzzzzzv_);
        CqlDate izzzzzzzzzzzzzx_((CqlTupleMetadata, CqlDate startDate)? @this)
        {
            CqlDate jzzzzzzzzzzzzzc_ = @this?.startDate;

            return jzzzzzzzzzzzzzc_;
        };
        IEnumerable<CqlDate> izzzzzzzzzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, CqlDate startDate)?, CqlDate>(izzzzzzzzzzzzzw_, izzzzzzzzzzzzzx_);
        CqlDate izzzzzzzzzzzzzz_ = context.Operators.First<CqlDate>(izzzzzzzzzzzzzy_);

        return izzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("IPSD")]
    public CqlDate IPSD(CqlContext context)
    {
        CqlDate jzzzzzzzzzzzzzd_ = this.First_ADHD_Medication_Prescribed_During_Intake_Period(context);

        return jzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzze_ = this.Office_Visit(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet jzzzzzzzzzzzzzg_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> jzzzzzzzzzzzzzi_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzf_, jzzzzzzzzzzzzzh_);
        CqlValueSet jzzzzzzzzzzzzzj_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet jzzzzzzzzzzzzzl_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> jzzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> jzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzi_, jzzzzzzzzzzzzzn_);
        IEnumerable<Encounter> jzzzzzzzzzzzzzp_ = Status_1_8_000.Instance.isEncounterPerformed(context, jzzzzzzzzzzzzzo_);
        bool? jzzzzzzzzzzzzzq_(Encounter ValidEncounters)
        {
            CqlDate jzzzzzzzzzzzzzs_ = this.IPSD(context);
            CqlQuantity jzzzzzzzzzzzzzt_ = context.Operators.Quantity(6m, "months");
            CqlDate jzzzzzzzzzzzzzu_ = context.Operators.Subtract(jzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzt_);
            CqlInterval<CqlDate> jzzzzzzzzzzzzzw_ = context.Operators.Interval(jzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzs_, true, true);
            Period jzzzzzzzzzzzzzx_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzy_ as object);
            CqlInterval<CqlDate> kzzzzzzzzzzzzza_ = CQMCommon_2_2_000.Instance.ToDateInterval(context, jzzzzzzzzzzzzzz_);
            bool? kzzzzzzzzzzzzzb_ = context.Operators.IntervalIncludesInterval<CqlDate>(jzzzzzzzzzzzzzw_, kzzzzzzzzzzzzza_, "day");

            return kzzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzq_);

        return jzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Inpatient Stay with Qualifying Diagnosis")]
    public IEnumerable<Encounter> Inpatient_Stay_with_Qualifying_Diagnosis(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzc_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> kzzzzzzzzzzzzze_ = Status_1_8_000.Instance.isEncounterPerformed(context, kzzzzzzzzzzzzzd_);
        bool? kzzzzzzzzzzzzzf_(Encounter InpatientStay)
        {
            Condition kzzzzzzzzzzzzzh_ = CQMCommon_2_2_000.Instance.principalDiagnosis(context, InpatientStay);
            CodeableConcept kzzzzzzzzzzzzzi_ = kzzzzzzzzzzzzzh_?.Code;
            CqlConcept kzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzzzzzzzzi_);
            CqlValueSet kzzzzzzzzzzzzzk_ = this.Mental_Behavioral_and_Neurodevelopmental_Disorders(context);
            bool? kzzzzzzzzzzzzzl_ = context.Operators.ConceptInValueSet(kzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzk_);

            return kzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzze_, kzzzzzzzzzzzzzf_);

        return kzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Inpatient Stay with Qualifying Diagnosis During Initiation Phase")]
    public IEnumerable<Encounter> Inpatient_Stay_with_Qualifying_Diagnosis_During_Initiation_Phase(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzm_ = this.Inpatient_Stay_with_Qualifying_Diagnosis(context);
        bool? kzzzzzzzzzzzzzn_(Encounter InpatientStay)
        {
            Period kzzzzzzzzzzzzzp_ = InpatientStay?.Period;
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzq_ as object);
            CqlInterval<CqlDate> kzzzzzzzzzzzzzs_ = CQMCommon_2_2_000.Instance.ToDateInterval(context, kzzzzzzzzzzzzzr_);
            CqlDate kzzzzzzzzzzzzzt_ = context.Operators.Start(kzzzzzzzzzzzzzs_);
            CqlDate kzzzzzzzzzzzzzu_ = this.IPSD(context);
            CqlQuantity kzzzzzzzzzzzzzw_ = context.Operators.Quantity(30m, "days");
            CqlDate kzzzzzzzzzzzzzx_ = context.Operators.Add(kzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzw_);
            CqlInterval<CqlDate> kzzzzzzzzzzzzzy_ = context.Operators.Interval(kzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzx_, false, true);
            bool? kzzzzzzzzzzzzzz_ = context.Operators.In<CqlDate>(kzzzzzzzzzzzzzt_, kzzzzzzzzzzzzzy_, "day");
            bool? lzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzu_ is null));
            bool? lzzzzzzzzzzzzzc_ = context.Operators.And(kzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzb_);

            return lzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzn_);

        return kzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Initial Population 1")]
    public bool? Initial_Population_1(CqlContext context)
    {
        Patient lzzzzzzzzzzzzzd_ = this.Patient(context);
        Date lzzzzzzzzzzzzze_ = lzzzzzzzzzzzzzd_?.BirthDateElement;
        string lzzzzzzzzzzzzzf_ = lzzzzzzzzzzzzze_?.Value;
        CqlDate lzzzzzzzzzzzzzg_ = context.Operators.ConvertStringToDate(lzzzzzzzzzzzzzf_);
        CqlInterval<CqlDateTime> lzzzzzzzzzzzzzh_ = this.Intake_Period(context);
        CqlDateTime lzzzzzzzzzzzzzi_ = context.Operators.Start(lzzzzzzzzzzzzzh_);
        CqlDate lzzzzzzzzzzzzzj_ = context.Operators.DateFrom(lzzzzzzzzzzzzzi_);
        int? lzzzzzzzzzzzzzk_ = context.Operators.CalculateAgeAt(lzzzzzzzzzzzzzg_, lzzzzzzzzzzzzzj_, "year");
        bool? lzzzzzzzzzzzzzl_ = context.Operators.GreaterOrEqual(lzzzzzzzzzzzzzk_, 6);
        Date lzzzzzzzzzzzzzn_ = lzzzzzzzzzzzzzd_?.BirthDateElement;
        string lzzzzzzzzzzzzzo_ = lzzzzzzzzzzzzzn_?.Value;
        CqlDate lzzzzzzzzzzzzzp_ = context.Operators.ConvertStringToDate(lzzzzzzzzzzzzzo_);
        CqlDateTime lzzzzzzzzzzzzzr_ = context.Operators.End(lzzzzzzzzzzzzzh_);
        CqlDate lzzzzzzzzzzzzzs_ = context.Operators.DateFrom(lzzzzzzzzzzzzzr_);
        int? lzzzzzzzzzzzzzt_ = context.Operators.CalculateAgeAt(lzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzs_, "year");
        bool? lzzzzzzzzzzzzzu_ = context.Operators.LessOrEqual(lzzzzzzzzzzzzzt_, 12);
        bool? lzzzzzzzzzzzzzv_ = context.Operators.And(lzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzu_);
        IEnumerable<Encounter> lzzzzzzzzzzzzzw_ = this.Qualifying_Encounter(context);
        bool? lzzzzzzzzzzzzzx_ = context.Operators.Exists<Encounter>(lzzzzzzzzzzzzzw_);
        bool? lzzzzzzzzzzzzzy_ = context.Operators.And(lzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzx_);
        CqlDate lzzzzzzzzzzzzzz_ = this.First_ADHD_Medication_Prescribed_During_Intake_Period(context);
        bool? mzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzz_ is null));
        bool? mzzzzzzzzzzzzzb_ = context.Operators.And(lzzzzzzzzzzzzzy_, mzzzzzzzzzzzzza_);
        IEnumerable<Encounter> mzzzzzzzzzzzzzc_ = this.Inpatient_Stay_with_Qualifying_Diagnosis_During_Initiation_Phase(context);
        bool? mzzzzzzzzzzzzzd_ = context.Operators.Exists<Encounter>(mzzzzzzzzzzzzzc_);
        bool? mzzzzzzzzzzzzze_ = context.Operators.Not(mzzzzzzzzzzzzzd_);
        bool? mzzzzzzzzzzzzzf_ = context.Operators.And(mzzzzzzzzzzzzzb_, mzzzzzzzzzzzzze_);

        return mzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Denominator 1")]
    public bool? Denominator_1(CqlContext context)
    {
        bool? mzzzzzzzzzzzzzg_ = this.Initial_Population_1(context);

        return mzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Narcolepsy Exclusion")]
    public IEnumerable<Condition> Narcolepsy_Exclusion(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzh_ = this.Narcolepsy(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? mzzzzzzzzzzzzzj_(Condition Narcolepsy)
        {
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Narcolepsy);
            CqlDateTime mzzzzzzzzzzzzzm_ = context.Operators.Start(mzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzzzzzzzzzo_ = context.Operators.End(mzzzzzzzzzzzzzn_);
            bool? mzzzzzzzzzzzzzp_ = context.Operators.SameOrBefore(mzzzzzzzzzzzzzm_, mzzzzzzzzzzzzzo_, default);

            return mzzzzzzzzzzzzzp_;
        };
        IEnumerable<Condition> mzzzzzzzzzzzzzk_ = context.Operators.Where<Condition>(mzzzzzzzzzzzzzi_, mzzzzzzzzzzzzzj_);

        return mzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? mzzzzzzzzzzzzzq_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzr_ = this.Narcolepsy_Exclusion(context);
        bool? mzzzzzzzzzzzzzs_ = context.Operators.Exists<Condition>(mzzzzzzzzzzzzzr_);
        bool? mzzzzzzzzzzzzzt_ = context.Operators.Or(mzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzs_);

        return mzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Qualifying Numerator Encounter")]
    public IEnumerable<Encounter> Qualifying_Numerator_Encounter(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzu_ = this.Office_Visit(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet mzzzzzzzzzzzzzw_ = this.Preventive_Care_Services_Group_Counseling(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> mzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzx_);
        CqlValueSet mzzzzzzzzzzzzzz_ = this.Behavioral_Health_Follow_up_Visit(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet nzzzzzzzzzzzzzb_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> nzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzza_, nzzzzzzzzzzzzzc_);
        IEnumerable<Encounter> nzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzy_, nzzzzzzzzzzzzzd_);
        CqlValueSet nzzzzzzzzzzzzzf_ = this.Psychotherapy_and_Pharmacologic_Management(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? nzzzzzzzzzzzzzh_(Encounter PsychPharmManagement)
        {
            List<Encounter.LocationComponent> ozzzzzzzzzzzzzf_ = PsychPharmManagement?.Location;
            bool? ozzzzzzzzzzzzzg_(Encounter.LocationComponent Location)
            {
                ResourceReference ozzzzzzzzzzzzzj_ = Location?.Location;
                Location ozzzzzzzzzzzzzk_ = CQMCommon_2_2_000.Instance.GetLocation(context, ozzzzzzzzzzzzzj_);
                List<CodeableConcept> ozzzzzzzzzzzzzl_ = ozzzzzzzzzzzzzk_?.Type;
                CqlConcept ozzzzzzzzzzzzzm_(CodeableConcept @this)
                {
                    CqlConcept ozzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                    return ozzzzzzzzzzzzzq_;
                };
                IEnumerable<CqlConcept> ozzzzzzzzzzzzzn_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ozzzzzzzzzzzzzl_, ozzzzzzzzzzzzzm_);
                CqlValueSet ozzzzzzzzzzzzzo_ = this.Ambulatory(context);
                bool? ozzzzzzzzzzzzzp_ = context.Operators.ConceptsInValueSet(ozzzzzzzzzzzzzn_, ozzzzzzzzzzzzzo_);

                return ozzzzzzzzzzzzzp_;
            };
            IEnumerable<Encounter.LocationComponent> ozzzzzzzzzzzzzh_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)ozzzzzzzzzzzzzf_, ozzzzzzzzzzzzzg_);
            bool? ozzzzzzzzzzzzzi_ = context.Operators.Exists<Encounter.LocationComponent>(ozzzzzzzzzzzzzh_);

            return ozzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzg_, nzzzzzzzzzzzzzh_);
        CqlValueSet nzzzzzzzzzzzzzj_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> nzzzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzi_, nzzzzzzzzzzzzzk_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzze_, nzzzzzzzzzzzzzl_);
        CqlValueSet nzzzzzzzzzzzzzn_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet nzzzzzzzzzzzzzp_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> nzzzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzo_, nzzzzzzzzzzzzzq_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzs_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzm_, nzzzzzzzzzzzzzr_);
        CqlValueSet nzzzzzzzzzzzzzt_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet nzzzzzzzzzzzzzv_ = this.Psych_Visit_Diagnostic_Evaluation(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> nzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzw_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzs_, nzzzzzzzzzzzzzx_);
        CqlValueSet nzzzzzzzzzzzzzz_ = this.Psych_Visit_Psychotherapy(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet ozzzzzzzzzzzzzb_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ozzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzzza_, ozzzzzzzzzzzzzc_);
        IEnumerable<Encounter> ozzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzy_, ozzzzzzzzzzzzzd_);

        return ozzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Encounter During Initiation Phase")]
    public IEnumerable<Encounter> Encounter_During_Initiation_Phase(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzr_ = this.Qualifying_Numerator_Encounter(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzs_ = Status_1_8_000.Instance.isEncounterPerformed(context, ozzzzzzzzzzzzzr_);
        bool? ozzzzzzzzzzzzzt_(Encounter ValidNumeratorEncounter)
        {
            Period ozzzzzzzzzzzzzv_ = ValidNumeratorEncounter?.Period;
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzw_ as object);
            CqlInterval<CqlDate> ozzzzzzzzzzzzzy_ = CQMCommon_2_2_000.Instance.ToDateInterval(context, ozzzzzzzzzzzzzx_);
            CqlDate ozzzzzzzzzzzzzz_ = context.Operators.Start(ozzzzzzzzzzzzzy_);
            CqlDate pzzzzzzzzzzzzza_ = this.IPSD(context);
            CqlQuantity pzzzzzzzzzzzzzc_ = context.Operators.Quantity(30m, "days");
            CqlDate pzzzzzzzzzzzzzd_ = context.Operators.Add(pzzzzzzzzzzzzza_, pzzzzzzzzzzzzzc_);
            CqlInterval<CqlDate> pzzzzzzzzzzzzze_ = context.Operators.Interval(pzzzzzzzzzzzzza_, pzzzzzzzzzzzzzd_, false, true);
            bool? pzzzzzzzzzzzzzf_ = context.Operators.In<CqlDate>(ozzzzzzzzzzzzzz_, pzzzzzzzzzzzzze_, "day");
            bool? pzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzza_ is null));
            bool? pzzzzzzzzzzzzzi_ = context.Operators.And(pzzzzzzzzzzzzzf_, pzzzzzzzzzzzzzh_);

            return pzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzu_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzs_, ozzzzzzzzzzzzzt_);

        return ozzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public bool? Numerator_1(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzj_ = this.Encounter_During_Initiation_Phase(context);
        bool? pzzzzzzzzzzzzzk_ = context.Operators.Exists<Encounter>(pzzzzzzzzzzzzzj_);

        return pzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("ADHD Medications Taken on IPSD or During Continuation and Maintenance Phase")]
    public IEnumerable<CqlInterval<CqlDate>> ADHD_Medications_Taken_on_IPSD_or_During_Continuation_and_Maintenance_Phase(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzl_ = this.Atomoxetine(context);
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzp_ = context.Operators.Union<MedicationRequest>(pzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzo_);
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzq_ = Status_1_8_000.Instance.isMedicationOrder(context, pzzzzzzzzzzzzzp_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? pzzzzzzzzzzzzzr_(MedicationRequest AtomoxetineMed)
        {
            CqlInterval<CqlDate> uzzzzzzzzzzzzzm_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, AtomoxetineMed);
            CqlDate uzzzzzzzzzzzzzo_ = context.Operators.Start(uzzzzzzzzzzzzzm_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? uzzzzzzzzzzzzzp_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, uzzzzzzzzzzzzzm_, uzzzzzzzzzzzzzo_);

            return uzzzzzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> pzzzzzzzzzzzzzs_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(pzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzr_);
        object pzzzzzzzzzzzzzt_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate uzzzzzzzzzzzzzq_ = @this?.periodStart;

            return uzzzzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> pzzzzzzzzzzzzzu_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(pzzzzzzzzzzzzzs_, pzzzzzzzzzzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
        bool? pzzzzzzzzzzzzzv_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> uzzzzzzzzzzzzzr_ = @this?.period;
            bool? uzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzr_ is null));

            return uzzzzzzzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> pzzzzzzzzzzzzzw_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(pzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzv_);
        CqlInterval<CqlDate> pzzzzzzzzzzzzzx_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> uzzzzzzzzzzzzzt_ = @this?.period;

            return uzzzzzzzzzzzzzt_;
        };
        IEnumerable<CqlInterval<CqlDate>> pzzzzzzzzzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(pzzzzzzzzzzzzzw_, pzzzzzzzzzzzzzx_);
        IEnumerable<CqlInterval<CqlDate>> pzzzzzzzzzzzzzz_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, pzzzzzzzzzzzzzy_);
        CqlValueSet qzzzzzzzzzzzzza_ = this.Clonidine(context);
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzze_ = context.Operators.Union<MedicationRequest>(qzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzd_);
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzf_ = Status_1_8_000.Instance.isMedicationOrder(context, qzzzzzzzzzzzzze_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? qzzzzzzzzzzzzzg_(MedicationRequest ClonidineMed)
        {
            CqlInterval<CqlDate> uzzzzzzzzzzzzzu_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ClonidineMed);
            CqlDate uzzzzzzzzzzzzzw_ = context.Operators.Start(uzzzzzzzzzzzzzu_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? uzzzzzzzzzzzzzx_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, uzzzzzzzzzzzzzu_, uzzzzzzzzzzzzzw_);

            return uzzzzzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> qzzzzzzzzzzzzzh_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(qzzzzzzzzzzzzzf_, qzzzzzzzzzzzzzg_);
        object qzzzzzzzzzzzzzi_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate uzzzzzzzzzzzzzy_ = @this?.periodStart;

            return uzzzzzzzzzzzzzy_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> qzzzzzzzzzzzzzj_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(qzzzzzzzzzzzzzh_, qzzzzzzzzzzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
        bool? qzzzzzzzzzzzzzk_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> uzzzzzzzzzzzzzz_ = @this?.period;
            bool? vzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzz_ is null));

            return vzzzzzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> qzzzzzzzzzzzzzl_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(qzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzk_);
        CqlInterval<CqlDate> qzzzzzzzzzzzzzm_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> vzzzzzzzzzzzzzb_ = @this?.period;

            return vzzzzzzzzzzzzzb_;
        };
        IEnumerable<CqlInterval<CqlDate>> qzzzzzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(qzzzzzzzzzzzzzl_, qzzzzzzzzzzzzzm_);
        IEnumerable<CqlInterval<CqlDate>> qzzzzzzzzzzzzzo_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, qzzzzzzzzzzzzzn_);
        IEnumerable<CqlInterval<CqlDate>> qzzzzzzzzzzzzzp_ = context.Operators.Union<CqlInterval<CqlDate>>(pzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzo_);
        CqlValueSet qzzzzzzzzzzzzzq_ = this.Dexmethylphenidate(context);
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzr_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzu_ = context.Operators.Union<MedicationRequest>(qzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzt_);
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzv_ = Status_1_8_000.Instance.isMedicationOrder(context, qzzzzzzzzzzzzzu_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? qzzzzzzzzzzzzzw_(MedicationRequest DexmethylphenidateMed)
        {
            CqlInterval<CqlDate> vzzzzzzzzzzzzzc_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, DexmethylphenidateMed);
            CqlDate vzzzzzzzzzzzzze_ = context.Operators.Start(vzzzzzzzzzzzzzc_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? vzzzzzzzzzzzzzf_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, vzzzzzzzzzzzzzc_, vzzzzzzzzzzzzze_);

            return vzzzzzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> qzzzzzzzzzzzzzx_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(qzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzw_);
        object qzzzzzzzzzzzzzy_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate vzzzzzzzzzzzzzg_ = @this?.periodStart;

            return vzzzzzzzzzzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> qzzzzzzzzzzzzzz_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(qzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
        bool? rzzzzzzzzzzzzza_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> vzzzzzzzzzzzzzh_ = @this?.period;
            bool? vzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzh_ is null));

            return vzzzzzzzzzzzzzi_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> rzzzzzzzzzzzzzb_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(qzzzzzzzzzzzzzz_, rzzzzzzzzzzzzza_);
        CqlInterval<CqlDate> rzzzzzzzzzzzzzc_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> vzzzzzzzzzzzzzj_ = @this?.period;

            return vzzzzzzzzzzzzzj_;
        };
        IEnumerable<CqlInterval<CqlDate>> rzzzzzzzzzzzzzd_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(rzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzc_);
        IEnumerable<CqlInterval<CqlDate>> rzzzzzzzzzzzzze_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, rzzzzzzzzzzzzzd_);
        CqlValueSet rzzzzzzzzzzzzzf_ = this.Dextroamphetamine(context);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzi_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzj_ = context.Operators.Union<MedicationRequest>(rzzzzzzzzzzzzzg_, rzzzzzzzzzzzzzi_);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzk_ = Status_1_8_000.Instance.isMedicationOrder(context, rzzzzzzzzzzzzzj_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? rzzzzzzzzzzzzzl_(MedicationRequest DextroamphetamineMed)
        {
            CqlInterval<CqlDate> vzzzzzzzzzzzzzk_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, DextroamphetamineMed);
            CqlDate vzzzzzzzzzzzzzm_ = context.Operators.Start(vzzzzzzzzzzzzzk_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? vzzzzzzzzzzzzzn_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, vzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzm_);

            return vzzzzzzzzzzzzzn_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> rzzzzzzzzzzzzzm_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(rzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzl_);
        object rzzzzzzzzzzzzzn_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate vzzzzzzzzzzzzzo_ = @this?.periodStart;

            return vzzzzzzzzzzzzzo_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> rzzzzzzzzzzzzzo_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(rzzzzzzzzzzzzzm_, rzzzzzzzzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
        bool? rzzzzzzzzzzzzzp_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> vzzzzzzzzzzzzzp_ = @this?.period;
            bool? vzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzp_ is null));

            return vzzzzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> rzzzzzzzzzzzzzq_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(rzzzzzzzzzzzzzo_, rzzzzzzzzzzzzzp_);
        CqlInterval<CqlDate> rzzzzzzzzzzzzzr_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> vzzzzzzzzzzzzzr_ = @this?.period;

            return vzzzzzzzzzzzzzr_;
        };
        IEnumerable<CqlInterval<CqlDate>> rzzzzzzzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(rzzzzzzzzzzzzzq_, rzzzzzzzzzzzzzr_);
        IEnumerable<CqlInterval<CqlDate>> rzzzzzzzzzzzzzt_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, rzzzzzzzzzzzzzs_);
        IEnumerable<CqlInterval<CqlDate>> rzzzzzzzzzzzzzu_ = context.Operators.Union<CqlInterval<CqlDate>>(rzzzzzzzzzzzzze_, rzzzzzzzzzzzzzt_);
        IEnumerable<CqlInterval<CqlDate>> rzzzzzzzzzzzzzv_ = context.Operators.Union<CqlInterval<CqlDate>>(qzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzu_);
        CqlValueSet rzzzzzzzzzzzzzw_ = this.Lisdexamfetamine(context);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzza_ = context.Operators.Union<MedicationRequest>(rzzzzzzzzzzzzzx_, rzzzzzzzzzzzzzz_);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzb_ = Status_1_8_000.Instance.isMedicationOrder(context, szzzzzzzzzzzzza_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? szzzzzzzzzzzzzc_(MedicationRequest LisdexamfetamineMed)
        {
            CqlInterval<CqlDate> vzzzzzzzzzzzzzs_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, LisdexamfetamineMed);
            CqlDate vzzzzzzzzzzzzzu_ = context.Operators.Start(vzzzzzzzzzzzzzs_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? vzzzzzzzzzzzzzv_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, vzzzzzzzzzzzzzs_, vzzzzzzzzzzzzzu_);

            return vzzzzzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> szzzzzzzzzzzzzd_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(szzzzzzzzzzzzzb_, szzzzzzzzzzzzzc_);
        object szzzzzzzzzzzzze_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate vzzzzzzzzzzzzzw_ = @this?.periodStart;

            return vzzzzzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> szzzzzzzzzzzzzf_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(szzzzzzzzzzzzzd_, szzzzzzzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
        bool? szzzzzzzzzzzzzg_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> vzzzzzzzzzzzzzx_ = @this?.period;
            bool? vzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzx_ is null));

            return vzzzzzzzzzzzzzy_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> szzzzzzzzzzzzzh_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(szzzzzzzzzzzzzf_, szzzzzzzzzzzzzg_);
        CqlInterval<CqlDate> szzzzzzzzzzzzzi_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> vzzzzzzzzzzzzzz_ = @this?.period;

            return vzzzzzzzzzzzzzz_;
        };
        IEnumerable<CqlInterval<CqlDate>> szzzzzzzzzzzzzj_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(szzzzzzzzzzzzzh_, szzzzzzzzzzzzzi_);
        IEnumerable<CqlInterval<CqlDate>> szzzzzzzzzzzzzk_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, szzzzzzzzzzzzzj_);
        CqlValueSet szzzzzzzzzzzzzl_ = this.Methylphenidate(context);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzp_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzzzzm_, szzzzzzzzzzzzzo_);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzq_ = Status_1_8_000.Instance.isMedicationOrder(context, szzzzzzzzzzzzzp_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? szzzzzzzzzzzzzr_(MedicationRequest MethylphenidateMed)
        {
            CqlInterval<CqlDate> wzzzzzzzzzzzzza_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, MethylphenidateMed);
            CqlDate wzzzzzzzzzzzzzc_ = context.Operators.Start(wzzzzzzzzzzzzza_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? wzzzzzzzzzzzzzd_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, wzzzzzzzzzzzzza_, wzzzzzzzzzzzzzc_);

            return wzzzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> szzzzzzzzzzzzzs_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(szzzzzzzzzzzzzq_, szzzzzzzzzzzzzr_);
        object szzzzzzzzzzzzzt_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate wzzzzzzzzzzzzze_ = @this?.periodStart;

            return wzzzzzzzzzzzzze_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> szzzzzzzzzzzzzu_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(szzzzzzzzzzzzzs_, szzzzzzzzzzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
        bool? szzzzzzzzzzzzzv_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> wzzzzzzzzzzzzzf_ = @this?.period;
            bool? wzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzf_ is null));

            return wzzzzzzzzzzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> szzzzzzzzzzzzzw_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(szzzzzzzzzzzzzu_, szzzzzzzzzzzzzv_);
        CqlInterval<CqlDate> szzzzzzzzzzzzzx_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> wzzzzzzzzzzzzzh_ = @this?.period;

            return wzzzzzzzzzzzzzh_;
        };
        IEnumerable<CqlInterval<CqlDate>> szzzzzzzzzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(szzzzzzzzzzzzzw_, szzzzzzzzzzzzzx_);
        IEnumerable<CqlInterval<CqlDate>> szzzzzzzzzzzzzz_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, szzzzzzzzzzzzzy_);
        IEnumerable<CqlInterval<CqlDate>> tzzzzzzzzzzzzza_ = context.Operators.Union<CqlInterval<CqlDate>>(szzzzzzzzzzzzzk_, szzzzzzzzzzzzzz_);
        IEnumerable<CqlInterval<CqlDate>> tzzzzzzzzzzzzzb_ = context.Operators.Union<CqlInterval<CqlDate>>(rzzzzzzzzzzzzzv_, tzzzzzzzzzzzzza_);
        CqlValueSet tzzzzzzzzzzzzzc_ = this.Guanfacine_Medications(context);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzg_ = context.Operators.Union<MedicationRequest>(tzzzzzzzzzzzzzd_, tzzzzzzzzzzzzzf_);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzh_ = Status_1_8_000.Instance.isMedicationOrder(context, tzzzzzzzzzzzzzg_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? tzzzzzzzzzzzzzi_(MedicationRequest GuanfacineMed)
        {
            CqlInterval<CqlDate> wzzzzzzzzzzzzzi_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, GuanfacineMed);
            CqlDate wzzzzzzzzzzzzzk_ = context.Operators.Start(wzzzzzzzzzzzzzi_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? wzzzzzzzzzzzzzl_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, wzzzzzzzzzzzzzi_, wzzzzzzzzzzzzzk_);

            return wzzzzzzzzzzzzzl_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> tzzzzzzzzzzzzzj_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(tzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzi_);
        object tzzzzzzzzzzzzzk_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate wzzzzzzzzzzzzzm_ = @this?.periodStart;

            return wzzzzzzzzzzzzzm_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> tzzzzzzzzzzzzzl_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(tzzzzzzzzzzzzzj_, tzzzzzzzzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
        bool? tzzzzzzzzzzzzzm_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> wzzzzzzzzzzzzzn_ = @this?.period;
            bool? wzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzn_ is null));

            return wzzzzzzzzzzzzzo_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> tzzzzzzzzzzzzzn_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(tzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzm_);
        CqlInterval<CqlDate> tzzzzzzzzzzzzzo_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> wzzzzzzzzzzzzzp_ = @this?.period;

            return wzzzzzzzzzzzzzp_;
        };
        IEnumerable<CqlInterval<CqlDate>> tzzzzzzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(tzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzo_);
        IEnumerable<CqlInterval<CqlDate>> tzzzzzzzzzzzzzq_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, tzzzzzzzzzzzzzp_);
        CqlCode tzzzzzzzzzzzzzr_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
        IEnumerable<CqlCode> tzzzzzzzzzzzzzs_ = context.Operators.ToList<CqlCode>(tzzzzzzzzzzzzzr_);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, tzzzzzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<CqlCode> tzzzzzzzzzzzzzv_ = context.Operators.ToList<CqlCode>(tzzzzzzzzzzzzzr_);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, tzzzzzzzzzzzzzv_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzx_ = context.Operators.Union<MedicationRequest>(tzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzw_);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzy_ = Status_1_8_000.Instance.isMedicationOrder(context, tzzzzzzzzzzzzzx_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? tzzzzzzzzzzzzzz_(MedicationRequest MethamphetamineMed)
        {
            CqlInterval<CqlDate> wzzzzzzzzzzzzzq_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, MethamphetamineMed);
            CqlDate wzzzzzzzzzzzzzs_ = context.Operators.Start(wzzzzzzzzzzzzzq_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? wzzzzzzzzzzzzzt_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, wzzzzzzzzzzzzzq_, wzzzzzzzzzzzzzs_);

            return wzzzzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> uzzzzzzzzzzzzza_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(tzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzz_);
        object uzzzzzzzzzzzzzb_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate wzzzzzzzzzzzzzu_ = @this?.periodStart;

            return wzzzzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> uzzzzzzzzzzzzzc_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(uzzzzzzzzzzzzza_, uzzzzzzzzzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
        bool? uzzzzzzzzzzzzzd_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> wzzzzzzzzzzzzzv_ = @this?.period;
            bool? wzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzv_ is null));

            return wzzzzzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> uzzzzzzzzzzzzze_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(uzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzd_);
        CqlInterval<CqlDate> uzzzzzzzzzzzzzf_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> wzzzzzzzzzzzzzx_ = @this?.period;

            return wzzzzzzzzzzzzzx_;
        };
        IEnumerable<CqlInterval<CqlDate>> uzzzzzzzzzzzzzg_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(uzzzzzzzzzzzzze_, uzzzzzzzzzzzzzf_);
        IEnumerable<CqlInterval<CqlDate>> uzzzzzzzzzzzzzh_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, uzzzzzzzzzzzzzg_);
        IEnumerable<CqlInterval<CqlDate>> uzzzzzzzzzzzzzi_ = context.Operators.Union<CqlInterval<CqlDate>>(tzzzzzzzzzzzzzq_, uzzzzzzzzzzzzzh_);
        IEnumerable<CqlInterval<CqlDate>> uzzzzzzzzzzzzzj_ = context.Operators.Union<CqlInterval<CqlDate>>(tzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzi_);
        CqlInterval<CqlDate> uzzzzzzzzzzzzzk_(CqlInterval<CqlDate> ADHDMedication)
        {
            CqlDate wzzzzzzzzzzzzzy_ = this.IPSD(context);
            CqlQuantity xzzzzzzzzzzzzza_ = context.Operators.Quantity(300m, "days");
            CqlDate xzzzzzzzzzzzzzb_ = context.Operators.Add(wzzzzzzzzzzzzzy_, xzzzzzzzzzzzzza_);
            CqlInterval<CqlDate> xzzzzzzzzzzzzzc_ = context.Operators.Interval(wzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzb_, true, true);
            CqlInterval<CqlDate> xzzzzzzzzzzzzzd_ = context.Operators.Intersect<CqlDate>(ADHDMedication, xzzzzzzzzzzzzzc_);

            return xzzzzzzzzzzzzzd_;
        };
        IEnumerable<CqlInterval<CqlDate>> uzzzzzzzzzzzzzl_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(uzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzk_);

        return uzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("ADHD Cumulative Medication Duration")]
    public int? ADHD_Cumulative_Medication_Duration(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDate>> xzzzzzzzzzzzzze_ = this.ADHD_Medications_Taken_on_IPSD_or_During_Continuation_and_Maintenance_Phase(context);
        int? xzzzzzzzzzzzzzf_ = CumulativeMedicationDuration_4_1_000.Instance.cumulativeDuration(context, xzzzzzzzzzzzzze_);

        return xzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Has ADHD Cumulative Medication Duration Greater Than or Equal to 210 Days")]
    public bool? Has_ADHD_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_210_Days(CqlContext context)
    {
        int? xzzzzzzzzzzzzzg_ = this.ADHD_Cumulative_Medication_Duration(context);
        bool? xzzzzzzzzzzzzzh_ = context.Operators.GreaterOrEqual(xzzzzzzzzzzzzzg_, 210);

        return xzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Inpatient Stay with Qualifying Diagnosis During Continuation and Maintenance Phase")]
    public IEnumerable<Encounter> Inpatient_Stay_with_Qualifying_Diagnosis_During_Continuation_and_Maintenance_Phase(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzi_ = this.Inpatient_Stay_with_Qualifying_Diagnosis(context);
        bool? xzzzzzzzzzzzzzj_(Encounter InpatientStay)
        {
            Period xzzzzzzzzzzzzzl_ = InpatientStay?.Period;
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzm_ as object);
            CqlInterval<CqlDate> xzzzzzzzzzzzzzo_ = CQMCommon_2_2_000.Instance.ToDateInterval(context, xzzzzzzzzzzzzzn_);
            CqlDate xzzzzzzzzzzzzzp_ = context.Operators.Start(xzzzzzzzzzzzzzo_);
            CqlDate xzzzzzzzzzzzzzq_ = this.IPSD(context);
            CqlQuantity xzzzzzzzzzzzzzs_ = context.Operators.Quantity(300m, "days");
            CqlDate xzzzzzzzzzzzzzt_ = context.Operators.Add(xzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzs_);
            CqlInterval<CqlDate> xzzzzzzzzzzzzzu_ = context.Operators.Interval(xzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzt_, false, true);
            bool? xzzzzzzzzzzzzzv_ = context.Operators.In<CqlDate>(xzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzu_, "day");
            bool? xzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzq_ is null));
            bool? xzzzzzzzzzzzzzy_ = context.Operators.And(xzzzzzzzzzzzzzv_, xzzzzzzzzzzzzzx_);

            return xzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(xzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzj_);

        return xzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Initial Population 2")]
    public bool? Initial_Population_2(CqlContext context)
    {
        Patient xzzzzzzzzzzzzzz_ = this.Patient(context);
        Date yzzzzzzzzzzzzza_ = xzzzzzzzzzzzzzz_?.BirthDateElement;
        string yzzzzzzzzzzzzzb_ = yzzzzzzzzzzzzza_?.Value;
        CqlDate yzzzzzzzzzzzzzc_ = context.Operators.ConvertStringToDate(yzzzzzzzzzzzzzb_);
        CqlInterval<CqlDateTime> yzzzzzzzzzzzzzd_ = this.Intake_Period(context);
        CqlDateTime yzzzzzzzzzzzzze_ = context.Operators.Start(yzzzzzzzzzzzzzd_);
        CqlDate yzzzzzzzzzzzzzf_ = context.Operators.DateFrom(yzzzzzzzzzzzzze_);
        int? yzzzzzzzzzzzzzg_ = context.Operators.CalculateAgeAt(yzzzzzzzzzzzzzc_, yzzzzzzzzzzzzzf_, "year");
        bool? yzzzzzzzzzzzzzh_ = context.Operators.GreaterOrEqual(yzzzzzzzzzzzzzg_, 6);
        Date yzzzzzzzzzzzzzj_ = xzzzzzzzzzzzzzz_?.BirthDateElement;
        string yzzzzzzzzzzzzzk_ = yzzzzzzzzzzzzzj_?.Value;
        CqlDate yzzzzzzzzzzzzzl_ = context.Operators.ConvertStringToDate(yzzzzzzzzzzzzzk_);
        CqlDateTime yzzzzzzzzzzzzzn_ = context.Operators.End(yzzzzzzzzzzzzzd_);
        CqlDate yzzzzzzzzzzzzzo_ = context.Operators.DateFrom(yzzzzzzzzzzzzzn_);
        int? yzzzzzzzzzzzzzp_ = context.Operators.CalculateAgeAt(yzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzo_, "year");
        bool? yzzzzzzzzzzzzzq_ = context.Operators.LessOrEqual(yzzzzzzzzzzzzzp_, 12);
        bool? yzzzzzzzzzzzzzr_ = context.Operators.And(yzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzq_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzs_ = this.Qualifying_Encounter(context);
        bool? yzzzzzzzzzzzzzt_ = context.Operators.Exists<Encounter>(yzzzzzzzzzzzzzs_);
        bool? yzzzzzzzzzzzzzu_ = context.Operators.And(yzzzzzzzzzzzzzr_, yzzzzzzzzzzzzzt_);
        CqlDate yzzzzzzzzzzzzzv_ = this.First_ADHD_Medication_Prescribed_During_Intake_Period(context);
        bool? yzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzv_ is null));
        bool? yzzzzzzzzzzzzzx_ = context.Operators.And(yzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzw_);
        bool? yzzzzzzzzzzzzzy_ = this.Has_ADHD_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_210_Days(context);
        bool? yzzzzzzzzzzzzzz_ = context.Operators.And(yzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzy_);
        IEnumerable<Encounter> zzzzzzzzzzzzzza_ = this.Inpatient_Stay_with_Qualifying_Diagnosis_During_Continuation_and_Maintenance_Phase(context);
        bool? zzzzzzzzzzzzzzb_ = context.Operators.Exists<Encounter>(zzzzzzzzzzzzzza_);
        bool? zzzzzzzzzzzzzzc_ = context.Operators.Not(zzzzzzzzzzzzzzb_);
        bool? zzzzzzzzzzzzzzd_ = context.Operators.And(yzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzc_);

        return zzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Denominator 2")]
    public bool? Denominator_2(CqlContext context)
    {
        bool? zzzzzzzzzzzzzze_ = this.Initial_Population_2(context);

        return zzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Encounter 31 to 300 Days into Continuation and Maintenance Phase")]
    public IEnumerable<CqlDate> Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzf_ = this.Qualifying_Numerator_Encounter(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzg_ = Status_1_8_000.Instance.isEncounterPerformed(context, zzzzzzzzzzzzzzf_);
        bool? zzzzzzzzzzzzzzh_(Encounter ValidNumeratorEncounter)
        {
            Period zzzzzzzzzzzzzzm_ = ValidNumeratorEncounter?.Period;
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzn_ as object);
            CqlInterval<CqlDate> zzzzzzzzzzzzzzp_ = CQMCommon_2_2_000.Instance.ToDateInterval(context, zzzzzzzzzzzzzzo_);
            CqlDate zzzzzzzzzzzzzzq_ = context.Operators.Start(zzzzzzzzzzzzzzp_);
            CqlDate zzzzzzzzzzzzzzr_ = this.IPSD(context);
            CqlQuantity zzzzzzzzzzzzzzs_ = context.Operators.Quantity(31m, "days");
            CqlDate zzzzzzzzzzzzzzt_ = context.Operators.Add(zzzzzzzzzzzzzzr_, zzzzzzzzzzzzzzs_);
            CqlQuantity zzzzzzzzzzzzzzv_ = context.Operators.Quantity(300m, "days");
            CqlDate zzzzzzzzzzzzzzw_ = context.Operators.Add(zzzzzzzzzzzzzzr_, zzzzzzzzzzzzzzv_);
            CqlInterval<CqlDate> zzzzzzzzzzzzzzx_ = context.Operators.Interval(zzzzzzzzzzzzzzt_, zzzzzzzzzzzzzzw_, true, true);
            bool? zzzzzzzzzzzzzzy_ = context.Operators.In<CqlDate>(zzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzx_, "day");

            return zzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzh_);
        CqlDate zzzzzzzzzzzzzzj_(Encounter ValidNumeratorEncounter)
        {
            Period zzzzzzzzzzzzzzz_ = ValidNumeratorEncounter?.Period;
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzz_);
            CqlDateTime azzzzzzzzzzzzzzb_ = context.Operators.Start(azzzzzzzzzzzzzza_);
            CqlDate azzzzzzzzzzzzzzc_ = context.Operators.DateFrom(azzzzzzzzzzzzzzb_);

            return azzzzzzzzzzzzzzc_;
        };
        IEnumerable<CqlDate> zzzzzzzzzzzzzzk_ = context.Operators.Select<Encounter, CqlDate>(zzzzzzzzzzzzzzi_, zzzzzzzzzzzzzzj_);
        IEnumerable<CqlDate> zzzzzzzzzzzzzzl_ = context.Operators.Distinct<CqlDate>(zzzzzzzzzzzzzzk_);

        return zzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Two or More Encounters 31 to 300 Days into Continuation and Maintenance Phase")]
    public bool? Two_or_More_Encounters_31_to_300_Days_into_Continuation_and_Maintenance_Phase(CqlContext context)
    {
        IEnumerable<CqlDate> azzzzzzzzzzzzzzd_ = this.Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(context);
        int? azzzzzzzzzzzzzze_ = context.Operators.Count<CqlDate>(azzzzzzzzzzzzzzd_);
        bool? azzzzzzzzzzzzzzf_ = context.Operators.GreaterOrEqual(azzzzzzzzzzzzzze_, 2);

        return azzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Virtual Encounter 31 to 300 Days into Continuation and Maintenance Phase")]
    public IEnumerable<CqlDate> Virtual_Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzg_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzzzi_ = Status_1_8_000.Instance.isEncounterPerformed(context, azzzzzzzzzzzzzzh_);
        bool? azzzzzzzzzzzzzzj_(Encounter VirtualEnc)
        {
            Period azzzzzzzzzzzzzzo_ = VirtualEnc?.Period;
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzp_ as object);
            CqlInterval<CqlDate> azzzzzzzzzzzzzzr_ = CQMCommon_2_2_000.Instance.ToDateInterval(context, azzzzzzzzzzzzzzq_);
            CqlDate azzzzzzzzzzzzzzs_ = context.Operators.Start(azzzzzzzzzzzzzzr_);
            CqlDate azzzzzzzzzzzzzzt_ = this.IPSD(context);
            CqlQuantity azzzzzzzzzzzzzzu_ = context.Operators.Quantity(31m, "days");
            CqlDate azzzzzzzzzzzzzzv_ = context.Operators.Add(azzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzu_);
            CqlQuantity azzzzzzzzzzzzzzx_ = context.Operators.Quantity(300m, "days");
            CqlDate azzzzzzzzzzzzzzy_ = context.Operators.Add(azzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzx_);
            CqlInterval<CqlDate> azzzzzzzzzzzzzzz_ = context.Operators.Interval(azzzzzzzzzzzzzzv_, azzzzzzzzzzzzzzy_, true, true);
            bool? bzzzzzzzzzzzzzza_ = context.Operators.In<CqlDate>(azzzzzzzzzzzzzzs_, azzzzzzzzzzzzzzz_, "day");

            return bzzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzzi_, azzzzzzzzzzzzzzj_);
        CqlDate azzzzzzzzzzzzzzl_(Encounter VirtualEnc)
        {
            Period bzzzzzzzzzzzzzzb_ = VirtualEnc?.Period;
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzb_);
            CqlDateTime bzzzzzzzzzzzzzzd_ = context.Operators.Start(bzzzzzzzzzzzzzzc_);
            CqlDate bzzzzzzzzzzzzzze_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzd_);

            return bzzzzzzzzzzzzzze_;
        };
        IEnumerable<CqlDate> azzzzzzzzzzzzzzm_ = context.Operators.Select<Encounter, CqlDate>(azzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzl_);
        IEnumerable<CqlDate> azzzzzzzzzzzzzzn_ = context.Operators.Distinct<CqlDate>(azzzzzzzzzzzzzzm_);

        return azzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public bool? Numerator_2(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzf_ = this.Encounter_During_Initiation_Phase(context);
        bool? bzzzzzzzzzzzzzzg_ = context.Operators.Exists<Encounter>(bzzzzzzzzzzzzzzf_);
        bool? bzzzzzzzzzzzzzzh_ = this.Two_or_More_Encounters_31_to_300_Days_into_Continuation_and_Maintenance_Phase(context);
        IEnumerable<CqlDate> bzzzzzzzzzzzzzzi_ = this.Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(context);
        IEnumerable<CqlDate> bzzzzzzzzzzzzzzj_(CqlDate Encounter1)
        {
            IEnumerable<CqlDate> bzzzzzzzzzzzzzzo_ = this.Virtual_Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(context);
            bool? bzzzzzzzzzzzzzzp_(CqlDate Encounter2)
            {
                bool? bzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(Encounter1 is null));
                bool? bzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(Encounter2 is null));
                bool? bzzzzzzzzzzzzzzv_ = context.Operators.And(bzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzu_);
                bool? bzzzzzzzzzzzzzzw_ = context.Operators.Equivalent(Encounter1, Encounter2);
                bool? bzzzzzzzzzzzzzzx_ = context.Operators.Not(bzzzzzzzzzzzzzzw_);
                bool? bzzzzzzzzzzzzzzy_ = context.Operators.And(bzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzx_);

                return bzzzzzzzzzzzzzzy_;
            };
            IEnumerable<CqlDate> bzzzzzzzzzzzzzzq_ = context.Operators.Where<CqlDate>(bzzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzzp_);
            CqlDate bzzzzzzzzzzzzzzr_(CqlDate Encounter2) =>
                Encounter1;
            IEnumerable<CqlDate> bzzzzzzzzzzzzzzs_ = context.Operators.Select<CqlDate, CqlDate>(bzzzzzzzzzzzzzzq_, bzzzzzzzzzzzzzzr_);

            return bzzzzzzzzzzzzzzs_;
        };
        IEnumerable<CqlDate> bzzzzzzzzzzzzzzk_ = context.Operators.SelectMany<CqlDate, CqlDate>(bzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzj_);
        bool? bzzzzzzzzzzzzzzl_ = context.Operators.Exists<CqlDate>(bzzzzzzzzzzzzzzk_);
        bool? bzzzzzzzzzzzzzzm_ = context.Operators.Or(bzzzzzzzzzzzzzzh_, bzzzzzzzzzzzzzzl_);
        bool? bzzzzzzzzzzzzzzn_ = context.Operators.And(bzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzm_);

        return bzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? bzzzzzzzzzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return bzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> czzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return czzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? czzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return czzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode czzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return czzzzzzzzzzzzzzc_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_CVELXTjiMTaGQEjMfJXBdUHjW = new(
        [typeof(CqlDate)],
        ["startDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD = new(
        [typeof(CqlInterval<CqlDate>), typeof(CqlDate)],
        ["period", "periodStart"]);

    #endregion CqlTupleMetadata Properties

}
