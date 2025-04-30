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
    private static readonly CqlCode __24_HR_dexmethylphenidate_hydrochloride_40_MG_Extended_Release_Oral_Capsule = new CqlCode("1006608", "http://www.nlm.nih.gov/research/umls/rxnorm");

    [CqlCodeDefinition("methamphetamine hydrochloride 5 MG Oral Tablet", codeId: "977860", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode methamphetamine_hydrochloride_5_MG_Oral_Tablet(CqlContext _) => _methamphetamine_hydrochloride_5_MG_Oral_Tablet;
    private static readonly CqlCode _methamphetamine_hydrochloride_5_MG_Oral_Tablet = new CqlCode("977860", "http://www.nlm.nih.gov/research/umls/rxnorm");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("RXNORM")]
    public CqlCodeSystem RXNORM(CqlContext _) => _RXNORM;
    private static readonly CqlCodeSystem _RXNORM =
      new CqlCodeSystem("http://www.nlm.nih.gov/research/umls/rxnorm", null,
          __24_HR_dexmethylphenidate_hydrochloride_40_MG_Extended_Release_Oral_Capsule,
          _methamphetamine_hydrochloride_5_MG_Oral_Tablet);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzzzzzzzzz_, pzzzzzzzzzzzzzzzzzzzzzzzza_, true, true);
        object pzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.ResolveParameter("FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR-0.1.001", "Measurement Period", pzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return (CqlInterval<CqlDateTime>)pzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> pzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient pzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SingletonFrom<Patient>(pzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return pzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("March 1 of Year Prior to Measurement Period")]
    public CqlDateTime March_1_of_Year_Prior_to_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
        CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzf_);
        int? pzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateTimeComponentFrom(pzzzzzzzzzzzzzzzzzzzzzzzzg_, "year");
        int? pzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Subtract(pzzzzzzzzzzzzzzzzzzzzzzzzh_, 1);
        decimal? pzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateTime(pzzzzzzzzzzzzzzzzzzzzzzzzi_, 3, 1, 0, 0, 0, 0, pzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Last Calendar Day of February of Measurement Period")]
    public CqlDateTime Last_Calendar_Day_of_February_of_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
        CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzl_);
        int? pzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateTimeComponentFrom(pzzzzzzzzzzzzzzzzzzzzzzzzm_, "year");
        decimal? pzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateTime(pzzzzzzzzzzzzzzzzzzzzzzzzn_, 3, 1, 23, 59, 59, 0, pzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlQuantity pzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(1m, "day");
        CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Subtract(pzzzzzzzzzzzzzzzzzzzzzzzzp_, pzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Intake Period")]
    public CqlInterval<CqlDateTime> Intake_Period(CqlContext context)
    {
        CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.March_1_of_Year_Prior_to_Measurement_Period(context);
        CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Last_Calendar_Day_of_February_of_Measurement_Period(context);
        CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Interval(pzzzzzzzzzzzzzzzzzzzzzzzzs_, pzzzzzzzzzzzzzzzzzzzzzzzzt_, true, true);

        return pzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("ADHD Medication Prescribed During Intake Period and Not Previously on ADHD Medication")]
    public IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Atomoxetine(context);
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<MedicationRequest>(pzzzzzzzzzzzzzzzzzzzzzzzzw_, pzzzzzzzzzzzzzzzzzzzzzzzzy_);
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Clonidine(context);
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<MedicationRequest>(qzzzzzzzzzzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<MedicationRequest>(pzzzzzzzzzzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Dexmethylphenidate(context);
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<MedicationRequest>(qzzzzzzzzzzzzzzzzzzzzzzzzh_, qzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<MedicationRequest>(qzzzzzzzzzzzzzzzzzzzzzzzzf_, qzzzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Dextroamphetamine(context);
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<MedicationRequest>(qzzzzzzzzzzzzzzzzzzzzzzzzn_, qzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<MedicationRequest>(qzzzzzzzzzzzzzzzzzzzzzzzzl_, qzzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Lisdexamfetamine(context);
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<MedicationRequest>(qzzzzzzzzzzzzzzzzzzzzzzzzt_, qzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<MedicationRequest>(qzzzzzzzzzzzzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzzzzzzzzzzzzw_);
        CqlCode qzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
        IEnumerable<CqlCode> qzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ToList<CqlCode>(qzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, qzzzzzzzzzzzzzzzzzzzzzzzzz_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<CqlCode> rzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ToList<CqlCode>(qzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, rzzzzzzzzzzzzzzzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<MedicationRequest>(rzzzzzzzzzzzzzzzzzzzzzzzza_, rzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<MedicationRequest>(qzzzzzzzzzzzzzzzzzzzzzzzzx_, rzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Methylphenidate(context);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<MedicationRequest>(rzzzzzzzzzzzzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<MedicationRequest>(rzzzzzzzzzzzzzzzzzzzzzzzzf_, rzzzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Guanfacine_Medications(context);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<MedicationRequest>(rzzzzzzzzzzzzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<MedicationRequest>(rzzzzzzzzzzzzzzzzzzzzzzzzl_, rzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzs_ = Status_1_8_000.Instance.isMedicationOrder(context, rzzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzt_(MedicationRequest ADHDMedications)
        {
            CqlInterval<CqlDate> uzzzzzzzzzzzzzzzzzzzzzzzzc_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ADHDMedications);
            CqlDate uzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertDateToDateTime(uzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Intake_Period(context);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzzzzzzzzzzf_, default);

            return uzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<MedicationRequest>(rzzzzzzzzzzzzzzzzzzzzzzzzs_, rzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<MedicationRequest>(rzzzzzzzzzzzzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzzzzzzzzzzzzzzzb_, szzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<MedicationRequest>(rzzzzzzzzzzzzzzzzzzzzzzzzz_, szzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzzzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzzzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzzzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzzzzzzzzzzzzzzzl_, szzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzzzzzzzzzzzzzzzt_, szzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzzzzzzzzzzzzzzzr_, szzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<CqlCode> szzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ToList<CqlCode>(qzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, szzzzzzzzzzzzzzzzzzzzzzzzz_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<CqlCode> tzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ToList<CqlCode>(qzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, tzzzzzzzzzzzzzzzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<MedicationRequest>(tzzzzzzzzzzzzzzzzzzzzzzzza_, tzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzzzzzzzzzzzzzzzx_, tzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<MedicationRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<MedicationRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<MedicationRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<MedicationRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzs_ = Status_1_8_000.Instance.isMedicationOrder(context, tzzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzt_(MedicationRequest ADHDMedications)
        {
            CqlInterval<CqlDate> uzzzzzzzzzzzzzzzzzzzzzzzzh_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ADHDMedications);
            CqlDate uzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertDateToDateTime(uzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Intake_Period(context);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzzzzzzzzzzk_, default);

            return uzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<MedicationRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzv_(MedicationRequest ADHDMedicationOrder)
        {
            CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Atomoxetine(context);
            IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<MedicationRequest>(uzzzzzzzzzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Clonidine(context);
            IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<MedicationRequest>(uzzzzzzzzzzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzzzzzzzzzzu_);
            IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<MedicationRequest>(uzzzzzzzzzzzzzzzzzzzzzzzzq_, uzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Dexmethylphenidate(context);
            IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<MedicationRequest>(uzzzzzzzzzzzzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzzzzzzzzzzzza_);
            IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<MedicationRequest>(uzzzzzzzzzzzzzzzzzzzzzzzzw_, vzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Dextroamphetamine(context);
            IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<MedicationRequest>(vzzzzzzzzzzzzzzzzzzzzzzzze_, vzzzzzzzzzzzzzzzzzzzzzzzzg_);
            IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<MedicationRequest>(vzzzzzzzzzzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Lisdexamfetamine(context);
            IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<MedicationRequest>(vzzzzzzzzzzzzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzzzzzzzzzzzzm_);
            IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<MedicationRequest>(vzzzzzzzzzzzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlCode vzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
            IEnumerable<CqlCode> vzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ToList<CqlCode>(vzzzzzzzzzzzzzzzzzzzzzzzzp_);
            IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, vzzzzzzzzzzzzzzzzzzzzzzzzq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<CqlCode> vzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ToList<CqlCode>(vzzzzzzzzzzzzzzzzzzzzzzzzp_);
            IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, vzzzzzzzzzzzzzzzzzzzzzzzzt_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<MedicationRequest>(vzzzzzzzzzzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzzzzzzzzzzu_);
            IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<MedicationRequest>(vzzzzzzzzzzzzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Methylphenidate(context);
            IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<MedicationRequest>(vzzzzzzzzzzzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzzzzzzzzzzza_);
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<MedicationRequest>(vzzzzzzzzzzzzzzzzzzzzzzzzw_, wzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Guanfacine_Medications(context);
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<MedicationRequest>(wzzzzzzzzzzzzzzzzzzzzzzzze_, wzzzzzzzzzzzzzzzzzzzzzzzzg_);
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<MedicationRequest>(wzzzzzzzzzzzzzzzzzzzzzzzzc_, wzzzzzzzzzzzzzzzzzzzzzzzzh_);
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzj_ = Status_1_8_000.Instance.isMedicationActive(context, wzzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzk_(MedicationRequest ActiveADHDMedication)
            {
                CqlInterval<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzzzo_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ActiveADHDMedication);
                CqlInterval<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzzzp_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ADHDMedicationOrder);
                CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConvertDateToDateTime(wzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlQuantity wzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(120m, "days");
                CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Subtract(wzzzzzzzzzzzzzzzzzzzzzzzzs_, wzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConvertDateToDateTime(wzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(wzzzzzzzzzzzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzzzzzzzzzzzy_, true, false);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Overlaps(wzzzzzzzzzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzzzzzzzzzz_, default);

                return xzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<MedicationRequest>(wzzzzzzzzzzzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzzzzzzzzzzzk_);
            MedicationRequest wzzzzzzzzzzzzzzzzzzzzzzzzm_(MedicationRequest ActiveADHDMedication) =>
                ADHDMedicationOrder;
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<MedicationRequest, MedicationRequest>(wzzzzzzzzzzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzu_, tzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Except<MedicationRequest>(rzzzzzzzzzzzzzzzzzzzzzzzzu_, tzzzzzzzzzzzzzzzzzzzzzzzzw_);
        (CqlTupleMetadata, CqlDate startDate)? tzzzzzzzzzzzzzzzzzzzzzzzzy_(MedicationRequest QualifyingMed)
        {
            CqlInterval<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzzzb_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, QualifyingMed);
            CqlDate xzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzb_);
            (CqlTupleMetadata, CqlDate startDate)? xzzzzzzzzzzzzzzzzzzzzzzzzd_ = (CqlTupleMetadata_CVELXTjiMTaGQEjMfJXBdUHjW, xzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> tzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlDate startDate)?>(tzzzzzzzzzzzzzzzzzzzzzzzzx_, tzzzzzzzzzzzzzzzzzzzzzzzzy_);
        object uzzzzzzzzzzzzzzzzzzzzzzzza_((CqlTupleMetadata, CqlDate startDate)? @this)
        {
            CqlDate xzzzzzzzzzzzzzzzzzzzzzzzze_ = @this?.startDate;

            return xzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> uzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDate startDate)?>(tzzzzzzzzzzzzzzzzzzzzzzzzz_, uzzzzzzzzzzzzzzzzzzzzzzzza_, System.ComponentModel.ListSortDirection.Ascending);

        return uzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("First ADHD Medication Prescribed During Intake Period")]
    public CqlDate First_ADHD_Medication_Prescribed_During_Intake_Period(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> xzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication(context);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzg_((CqlTupleMetadata, CqlDate startDate)? @this)
        {
            CqlDate xzzzzzzzzzzzzzzzzzzzzzzzzl_ = @this?.startDate;
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzzzzzzzzzzzl_ is null));

            return xzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> xzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<(CqlTupleMetadata, CqlDate startDate)?>(xzzzzzzzzzzzzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlDate xzzzzzzzzzzzzzzzzzzzzzzzzi_((CqlTupleMetadata, CqlDate startDate)? @this)
        {
            CqlDate xzzzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.startDate;

            return xzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<(CqlTupleMetadata, CqlDate startDate)?, CqlDate>(xzzzzzzzzzzzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzzzzzzzzzzzi_);
        CqlDate xzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.First<CqlDate>(xzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("IPSD")]
    public CqlDate IPSD(CqlContext context)
    {
        CqlDate xzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.First_ADHD_Medication_Prescribed_During_Intake_Period(context);

        return xzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Office_Visit(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzv_, xzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzza_ = Status_1_8_000.Instance.isEncounterPerformed(context, xzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzb_(Encounter ValidEncounters)
        {
            CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.IPSD(context);
            CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(6m, "months");
            CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Subtract(yzzzzzzzzzzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzzzzzzzzf_, yzzzzzzzzzzzzzzzzzzzzzzzzd_, true, true);
            Period yzzzzzzzzzzzzzzzzzzzzzzzzi_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzj_ as object);
            CqlInterval<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzzzl_ = CQMCommon_2_2_000.Instance.ToDateInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.IntervalIncludesInterval<CqlDate>(yzzzzzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzzzzzl_, "day");

            return yzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Inpatient Stay with Qualifying Diagnosis")]
    public IEnumerable<Encounter> Inpatient_Stay_with_Qualifying_Diagnosis(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzp_ = Status_1_8_000.Instance.isEncounterPerformed(context, yzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzq_(Encounter InpatientStay)
        {
            Condition yzzzzzzzzzzzzzzzzzzzzzzzzs_ = CQMCommon_2_2_000.Instance.principalDiagnosis(context, InpatientStay);
            CodeableConcept yzzzzzzzzzzzzzzzzzzzzzzzzt_ = yzzzzzzzzzzzzzzzzzzzzzzzzs_?.Code;
            CqlConcept yzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Mental_Behavioral_and_Neurodevelopmental_Disorders(context);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzzzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Inpatient Stay with Qualifying Diagnosis During Initiation Phase")]
    public IEnumerable<Encounter> Inpatient_Stay_with_Qualifying_Diagnosis_During_Initiation_Phase(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Inpatient_Stay_with_Qualifying_Diagnosis(context);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzy_(Encounter InpatientStay)
        {
            Period zzzzzzzzzzzzzzzzzzzzzzzzza_ = InpatientStay?.Period;
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzb_ as object);
            CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzzd_ = CQMCommon_2_2_000.Instance.ToDateInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.IPSD(context);
            CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(30m, "days");
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Add(zzzzzzzzzzzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzzzzzzzzzzi_, false, true);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDate>(zzzzzzzzzzzzzzzzzzzzzzzzze_, zzzzzzzzzzzzzzzzzzzzzzzzzj_, "day");
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzzzzzzzzzzf_ is null));
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Initial Population 1")]
    public bool? Initial_Population_1(CqlContext context)
    {
        Patient zzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Patient(context);
        Date zzzzzzzzzzzzzzzzzzzzzzzzzp_ = zzzzzzzzzzzzzzzzzzzzzzzzzo_?.BirthDateElement;
        string zzzzzzzzzzzzzzzzzzzzzzzzzq_ = zzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
        CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConvertStringToDate(zzzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Intake_Period(context);
        CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzzzzzzzzzt_);
        int? zzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.CalculateAgeAt(zzzzzzzzzzzzzzzzzzzzzzzzzr_, zzzzzzzzzzzzzzzzzzzzzzzzzu_, "year");
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.GreaterOrEqual(zzzzzzzzzzzzzzzzzzzzzzzzzv_, 6);
        Date zzzzzzzzzzzzzzzzzzzzzzzzzy_ = zzzzzzzzzzzzzzzzzzzzzzzzzo_?.BirthDateElement;
        string zzzzzzzzzzzzzzzzzzzzzzzzzz_ = zzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
        CqlDate azzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertStringToDate(zzzzzzzzzzzzzzzzzzzzzzzzzz_);
        CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.End(zzzzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzzzc_);
        int? azzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.CalculateAgeAt(azzzzzzzzzzzzzzzzzzzzzzzzza_, azzzzzzzzzzzzzzzzzzzzzzzzzd_, "year");
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.LessOrEqual(azzzzzzzzzzzzzzzzzzzzzzzzze_, 12);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzw_, azzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Qualifying_Encounter(context);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Exists<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzzzzzzzzzzzi_);
        CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.First_ADHD_Medication_Prescribed_During_Intake_Period(context);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzzzzzzzzzzk_ is null));
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzj_, azzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Inpatient_Stay_with_Qualifying_Diagnosis_During_Initiation_Phase(context);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Not(azzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzm_, azzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Denominator 1")]
    public bool? Denominator_1(CqlContext context)
    {
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Initial_Population_1(context);

        return azzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Narcolepsy Exclusion")]
    public IEnumerable<Condition> Narcolepsy_Exclusion(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Narcolepsy(context);
        IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzu_(Condition Narcolepsy)
        {
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Narcolepsy);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.End(azzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SameOrBefore(azzzzzzzzzzzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzzzzzzzzzzzz_, default);

            return bzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Condition>(azzzzzzzzzzzzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzb_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Narcolepsy_Exclusion(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<Condition>(bzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Qualifying Numerator Encounter")]
    public IEnumerable<Encounter> Qualifying_Numerator_Encounter(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Office_Visit(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Preventive_Care_Services_Group_Counseling(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Behavioral_Health_Follow_up_Visit(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzl_, bzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Psychotherapy_and_Pharmacologic_Management(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzs_(Encounter PsychPharmManagement)
        {
            List<Encounter.LocationComponent> czzzzzzzzzzzzzzzzzzzzzzzzzq_ = PsychPharmManagement?.Location;
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzr_(Encounter.LocationComponent Location)
            {
                ResourceReference czzzzzzzzzzzzzzzzzzzzzzzzzu_ = Location?.Location;
                Location czzzzzzzzzzzzzzzzzzzzzzzzzv_ = CQMCommon_2_2_000.Instance.GetLocation(context, czzzzzzzzzzzzzzzzzzzzzzzzzu_);
                List<CodeableConcept> czzzzzzzzzzzzzzzzzzzzzzzzzw_ = czzzzzzzzzzzzzzzzzzzzzzzzzv_?.Type;
                CqlConcept czzzzzzzzzzzzzzzzzzzzzzzzzx_(CodeableConcept @this)
                {
                    CqlConcept dzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                    return dzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                };
                IEnumerable<CqlConcept> czzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)czzzzzzzzzzzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Ambulatory(context);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConceptsInValueSet(czzzzzzzzzzzzzzzzzzzzzzzzzy_, czzzzzzzzzzzzzzzzzzzzzzzzzz_);

                return dzzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Encounter.LocationComponent> czzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)czzzzzzzzzzzzzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Encounter.LocationComponent>(czzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzz_, czzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzx_, czzzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Psych_Visit_Diagnostic_Evaluation(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzd_, czzzzzzzzzzzzzzzzzzzzzzzzzi_);
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Psych_Visit_Psychotherapy(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Encounter During Initiation Phase")]
    public IEnumerable<Encounter> Encounter_During_Initiation_Phase(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Qualifying_Numerator_Encounter(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzd_ = Status_1_8_000.Instance.isEncounterPerformed(context, dzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzze_(Encounter ValidNumeratorEncounter)
        {
            Period dzzzzzzzzzzzzzzzzzzzzzzzzzg_ = ValidNumeratorEncounter?.Period;
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzh_ as object);
            CqlInterval<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzzzj_ = CQMCommon_2_2_000.Instance.ToDateInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.IPSD(context);
            CqlQuantity dzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(30m, "days");
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Add(dzzzzzzzzzzzzzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzzzzzzzzzzzzzo_, false, true);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDate>(dzzzzzzzzzzzzzzzzzzzzzzzzzk_, dzzzzzzzzzzzzzzzzzzzzzzzzzp_, "day");
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzzzzzzzzzzzl_ is null));
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzq_, dzzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public bool? Numerator_1(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Encounter_During_Initiation_Phase(context);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("ADHD Medications Taken on IPSD or During Continuation and Maintenance Phase")]
    public IEnumerable<CqlInterval<CqlDate>> ADHD_Medications_Taken_on_IPSD_or_During_Continuation_and_Maintenance_Phase(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Atomoxetine(context);
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<MedicationRequest>(dzzzzzzzzzzzzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzzzzzzzb_ = Status_1_8_000.Instance.isMedicationOrder(context, ezzzzzzzzzzzzzzzzzzzzzzzzza_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? ezzzzzzzzzzzzzzzzzzzzzzzzzc_(MedicationRequest AtomoxetineMed)
        {
            CqlInterval<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzzzx_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, AtomoxetineMed);
            CqlDate izzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzx_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? jzzzzzzzzzzzzzzzzzzzzzzzzza_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, izzzzzzzzzzzzzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> ezzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(ezzzzzzzzzzzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzzzzzzzzzzzc_);
        object ezzzzzzzzzzzzzzzzzzzzzzzzze_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate jzzzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.periodStart;

            return jzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> ezzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(ezzzzzzzzzzzzzzzzzzzzzzzzzd_, ezzzzzzzzzzzzzzzzzzzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzg_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.period;
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzzzzzzzzzzc_ is null));

            return jzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> ezzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(ezzzzzzzzzzzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlInterval<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzzzzi_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzzze_ = @this?.period;

            return jzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<CqlInterval<CqlDate>> ezzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(ezzzzzzzzzzzzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<CqlInterval<CqlDate>> ezzzzzzzzzzzzzzzzzzzzzzzzzk_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, ezzzzzzzzzzzzzzzzzzzzzzzzzj_);
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Clonidine(context);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<MedicationRequest>(ezzzzzzzzzzzzzzzzzzzzzzzzzm_, ezzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzzzzzzzq_ = Status_1_8_000.Instance.isMedicationOrder(context, ezzzzzzzzzzzzzzzzzzzzzzzzzp_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? ezzzzzzzzzzzzzzzzzzzzzzzzzr_(MedicationRequest ClonidineMed)
        {
            CqlInterval<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzzzf_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ClonidineMed);
            CqlDate jzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? jzzzzzzzzzzzzzzzzzzzzzzzzzi_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, jzzzzzzzzzzzzzzzzzzzzzzzzzf_, jzzzzzzzzzzzzzzzzzzzzzzzzzh_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> ezzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(ezzzzzzzzzzzzzzzzzzzzzzzzzq_, ezzzzzzzzzzzzzzzzzzzzzzzzzr_);
        object ezzzzzzzzzzzzzzzzzzzzzzzzzt_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate jzzzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.periodStart;

            return jzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> ezzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(ezzzzzzzzzzzzzzzzzzzzzzzzzs_, ezzzzzzzzzzzzzzzzzzzzzzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzv_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzzzk_ = @this?.period;
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzzzzzzzzzzk_ is null));

            return jzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> ezzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(ezzzzzzzzzzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzzzzzzzzzv_);
        CqlInterval<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzzzzx_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzzzm_ = @this?.period;

            return jzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<CqlInterval<CqlDate>> ezzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(ezzzzzzzzzzzzzzzzzzzzzzzzzw_, ezzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<CqlInterval<CqlDate>> ezzzzzzzzzzzzzzzzzzzzzzzzzz_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, ezzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<CqlInterval<CqlDate>> fzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<CqlInterval<CqlDate>>(ezzzzzzzzzzzzzzzzzzzzzzzzzk_, ezzzzzzzzzzzzzzzzzzzzzzzzzz_);
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Dexmethylphenidate(context);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<MedicationRequest>(fzzzzzzzzzzzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzzg_ = Status_1_8_000.Instance.isMedicationOrder(context, fzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? fzzzzzzzzzzzzzzzzzzzzzzzzzh_(MedicationRequest DexmethylphenidateMed)
        {
            CqlInterval<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzzzn_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, DexmethylphenidateMed);
            CqlDate jzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? jzzzzzzzzzzzzzzzzzzzzzzzzzq_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, jzzzzzzzzzzzzzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> fzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(fzzzzzzzzzzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        object fzzzzzzzzzzzzzzzzzzzzzzzzzj_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate jzzzzzzzzzzzzzzzzzzzzzzzzzr_ = @this?.periodStart;

            return jzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> fzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(fzzzzzzzzzzzzzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzzzzzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzl_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzzzs_ = @this?.period;
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzzzzzzzzzzs_ is null));

            return jzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> fzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(fzzzzzzzzzzzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        CqlInterval<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzzzn_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzzzu_ = @this?.period;

            return jzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<CqlInterval<CqlDate>> fzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(fzzzzzzzzzzzzzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<CqlInterval<CqlDate>> fzzzzzzzzzzzzzzzzzzzzzzzzzp_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, fzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Dextroamphetamine(context);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<MedicationRequest>(fzzzzzzzzzzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzzv_ = Status_1_8_000.Instance.isMedicationOrder(context, fzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? fzzzzzzzzzzzzzzzzzzzzzzzzzw_(MedicationRequest DextroamphetamineMed)
        {
            CqlInterval<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzzzv_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, DextroamphetamineMed);
            CqlDate jzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? jzzzzzzzzzzzzzzzzzzzzzzzzzy_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, jzzzzzzzzzzzzzzzzzzzzzzzzzv_, jzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> fzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(fzzzzzzzzzzzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        object fzzzzzzzzzzzzzzzzzzzzzzzzzy_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate jzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.periodStart;

            return jzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> fzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(fzzzzzzzzzzzzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzzzzzzzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzza_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> kzzzzzzzzzzzzzzzzzzzzzzzzza_ = @this?.period;
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzzzzzzzzzza_ is null));

            return kzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> gzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(fzzzzzzzzzzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlInterval<CqlDate> gzzzzzzzzzzzzzzzzzzzzzzzzzc_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> kzzzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.period;

            return kzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(gzzzzzzzzzzzzzzzzzzzzzzzzzb_, gzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzzzzzzzzzzzzzzzzzze_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, gzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<CqlInterval<CqlDate>>(fzzzzzzzzzzzzzzzzzzzzzzzzzp_, gzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<CqlInterval<CqlDate>>(fzzzzzzzzzzzzzzzzzzzzzzzzza_, gzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Lisdexamfetamine(context);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzm_ = Status_1_8_000.Instance.isMedicationOrder(context, gzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? gzzzzzzzzzzzzzzzzzzzzzzzzzn_(MedicationRequest LisdexamfetamineMed)
        {
            CqlInterval<CqlDate> kzzzzzzzzzzzzzzzzzzzzzzzzzd_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, LisdexamfetamineMed);
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? kzzzzzzzzzzzzzzzzzzzzzzzzzg_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, kzzzzzzzzzzzzzzzzzzzzzzzzzd_, kzzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> gzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(gzzzzzzzzzzzzzzzzzzzzzzzzzm_, gzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        object gzzzzzzzzzzzzzzzzzzzzzzzzzp_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.periodStart;

            return kzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> gzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(gzzzzzzzzzzzzzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzzzzzzzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzr_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> kzzzzzzzzzzzzzzzzzzzzzzzzzi_ = @this?.period;
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzzzzzzzzzzi_ is null));

            return kzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> gzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(gzzzzzzzzzzzzzzzzzzzzzzzzzq_, gzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        CqlInterval<CqlDate> gzzzzzzzzzzzzzzzzzzzzzzzzzt_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> kzzzzzzzzzzzzzzzzzzzzzzzzzk_ = @this?.period;

            return kzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(gzzzzzzzzzzzzzzzzzzzzzzzzzs_, gzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzzzzzzzzzzzzzzzzzzv_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, gzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Methylphenidate(context);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzzb_ = Status_1_8_000.Instance.isMedicationOrder(context, hzzzzzzzzzzzzzzzzzzzzzzzzza_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? hzzzzzzzzzzzzzzzzzzzzzzzzzc_(MedicationRequest MethylphenidateMed)
        {
            CqlInterval<CqlDate> kzzzzzzzzzzzzzzzzzzzzzzzzzl_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, MethylphenidateMed);
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? kzzzzzzzzzzzzzzzzzzzzzzzzzo_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, kzzzzzzzzzzzzzzzzzzzzzzzzzl_, kzzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> hzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(hzzzzzzzzzzzzzzzzzzzzzzzzzb_, hzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        object hzzzzzzzzzzzzzzzzzzzzzzzzze_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzzzp_ = @this?.periodStart;

            return kzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> hzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(hzzzzzzzzzzzzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzzzzzzzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzg_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> kzzzzzzzzzzzzzzzzzzzzzzzzzq_ = @this?.period;
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzzzzzzzzzzq_ is null));

            return kzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> hzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(hzzzzzzzzzzzzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlInterval<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzi_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> kzzzzzzzzzzzzzzzzzzzzzzzzzs_ = @this?.period;

            return kzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(hzzzzzzzzzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzzzzzzzzzzzzzzzzzzk_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, hzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<CqlInterval<CqlDate>>(gzzzzzzzzzzzzzzzzzzzzzzzzzv_, hzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<CqlInterval<CqlDate>>(gzzzzzzzzzzzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Guanfacine_Medications(context);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzzs_ = Status_1_8_000.Instance.isMedicationOrder(context, hzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? hzzzzzzzzzzzzzzzzzzzzzzzzzt_(MedicationRequest GuanfacineMed)
        {
            CqlInterval<CqlDate> kzzzzzzzzzzzzzzzzzzzzzzzzzt_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, GuanfacineMed);
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? kzzzzzzzzzzzzzzzzzzzzzzzzzw_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, kzzzzzzzzzzzzzzzzzzzzzzzzzt_, kzzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> hzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(hzzzzzzzzzzzzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        object hzzzzzzzzzzzzzzzzzzzzzzzzzv_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.periodStart;

            return kzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> hzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(hzzzzzzzzzzzzzzzzzzzzzzzzzu_, hzzzzzzzzzzzzzzzzzzzzzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzx_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> kzzzzzzzzzzzzzzzzzzzzzzzzzy_ = @this?.period;
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzzzzzzzzzzy_ is null));

            return kzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> hzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(hzzzzzzzzzzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        CqlInterval<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzz_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> lzzzzzzzzzzzzzzzzzzzzzzzzza_ = @this?.period;

            return lzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(hzzzzzzzzzzzzzzzzzzzzzzzzzy_, hzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzzzzzzzzzzzzzzzzb_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, izzzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlCode izzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
        IEnumerable<CqlCode> izzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ToList<CqlCode>(izzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, izzzzzzzzzzzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<CqlCode> izzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ToList<CqlCode>(izzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, izzzzzzzzzzzzzzzzzzzzzzzzzg_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<MedicationRequest>(izzzzzzzzzzzzzzzzzzzzzzzzze_, izzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzzzzj_ = Status_1_8_000.Instance.isMedicationOrder(context, izzzzzzzzzzzzzzzzzzzzzzzzzi_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? izzzzzzzzzzzzzzzzzzzzzzzzzk_(MedicationRequest MethamphetamineMed)
        {
            CqlInterval<CqlDate> lzzzzzzzzzzzzzzzzzzzzzzzzzb_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, MethamphetamineMed);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? lzzzzzzzzzzzzzzzzzzzzzzzzze_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, lzzzzzzzzzzzzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzzzzzzzzzzzzd_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> izzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(izzzzzzzzzzzzzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzzzzzzzzzzzzk_);
        object izzzzzzzzzzzzzzzzzzzzzzzzzm_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.periodStart;

            return lzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> izzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(izzzzzzzzzzzzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzzzzzzzzzzzm_, System.ComponentModel.ListSortDirection.Ascending);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzo_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> lzzzzzzzzzzzzzzzzzzzzzzzzzg_ = @this?.period;
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzzzzzzzzzzzg_ is null));

            return lzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> izzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(izzzzzzzzzzzzzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlInterval<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzzzq_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> lzzzzzzzzzzzzzzzzzzzzzzzzzi_ = @this?.period;

            return lzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(izzzzzzzzzzzzzzzzzzzzzzzzzp_, izzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzzzzzzzzzzzzzzzzs_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, izzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<CqlInterval<CqlDate>>(izzzzzzzzzzzzzzzzzzzzzzzzzb_, izzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<CqlInterval<CqlDate>>(hzzzzzzzzzzzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzzzzzzzzzzt_);
        CqlInterval<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzzzv_(CqlInterval<CqlDate> ADHDMedication)
        {
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.IPSD(context);
            CqlQuantity lzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(300m, "days");
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Add(lzzzzzzzzzzzzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDate> lzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzzzzzzzzzzzzm_, true, true);
            CqlInterval<CqlDate> lzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Intersect<CqlDate>(ADHDMedication, lzzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(izzzzzzzzzzzzzzzzzzzzzzzzzu_, izzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("ADHD Cumulative Medication Duration")]
    public int? ADHD_Cumulative_Medication_Duration(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.ADHD_Medications_Taken_on_IPSD_or_During_Continuation_and_Maintenance_Phase(context);
        int? lzzzzzzzzzzzzzzzzzzzzzzzzzq_ = CumulativeMedicationDuration_4_1_000.Instance.cumulativeDuration(context, lzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Has ADHD Cumulative Medication Duration Greater Than or Equal to 210 Days")]
    public bool? Has_ADHD_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_210_Days(CqlContext context)
    {
        int? lzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.ADHD_Cumulative_Medication_Duration(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.GreaterOrEqual(lzzzzzzzzzzzzzzzzzzzzzzzzzr_, 210);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Inpatient Stay with Qualifying Diagnosis During Continuation and Maintenance Phase")]
    public IEnumerable<Encounter> Inpatient_Stay_with_Qualifying_Diagnosis_During_Continuation_and_Maintenance_Phase(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Inpatient_Stay_with_Qualifying_Diagnosis(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzu_(Encounter InpatientStay)
        {
            Period lzzzzzzzzzzzzzzzzzzzzzzzzzw_ = InpatientStay?.Period;
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzzx_ as object);
            CqlInterval<CqlDate> lzzzzzzzzzzzzzzzzzzzzzzzzzz_ = CQMCommon_2_2_000.Instance.ToDateInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.IPSD(context);
            CqlQuantity mzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(300m, "days");
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Add(mzzzzzzzzzzzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDate> mzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzzzzzzzzzzze_, false, true);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDate>(mzzzzzzzzzzzzzzzzzzzzzzzzza_, mzzzzzzzzzzzzzzzzzzzzzzzzzf_, "day");
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzzzzzzzzb_ is null));
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzg_, mzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Initial Population 2")]
    public bool? Initial_Population_2(CqlContext context)
    {
        Patient mzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Patient(context);
        Date mzzzzzzzzzzzzzzzzzzzzzzzzzl_ = mzzzzzzzzzzzzzzzzzzzzzzzzzk_?.BirthDateElement;
        string mzzzzzzzzzzzzzzzzzzzzzzzzzm_ = mzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
        CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConvertStringToDate(mzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Intake_Period(context);
        CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        int? mzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.CalculateAgeAt(mzzzzzzzzzzzzzzzzzzzzzzzzzn_, mzzzzzzzzzzzzzzzzzzzzzzzzzq_, "year");
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.GreaterOrEqual(mzzzzzzzzzzzzzzzzzzzzzzzzzr_, 6);
        Date mzzzzzzzzzzzzzzzzzzzzzzzzzu_ = mzzzzzzzzzzzzzzzzzzzzzzzzzk_?.BirthDateElement;
        string mzzzzzzzzzzzzzzzzzzzzzzzzzv_ = mzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
        CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConvertStringToDate(mzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.End(mzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        int? nzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.CalculateAgeAt(mzzzzzzzzzzzzzzzzzzzzzzzzzw_, mzzzzzzzzzzzzzzzzzzzzzzzzzz_, "year");
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.LessOrEqual(nzzzzzzzzzzzzzzzzzzzzzzzzza_, 12);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzs_, nzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Qualifying_Encounter(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzc_, nzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.First_ADHD_Medication_Prescribed_During_Intake_Period(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzzzzzzzzzzg_ is null));
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Has_ADHD_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_210_Days(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzi_, nzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Inpatient_Stay_with_Qualifying_Diagnosis_During_Continuation_and_Maintenance_Phase(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not(nzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Denominator 2")]
    public bool? Denominator_2(CqlContext context)
    {
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Initial_Population_2(context);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Encounter 31 to 300 Days into Continuation and Maintenance Phase")]
    public IEnumerable<CqlDate> Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Qualifying_Numerator_Encounter(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzr_ = Status_1_8_000.Instance.isEncounterPerformed(context, nzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzs_(Encounter ValidNumeratorEncounter)
        {
            Period nzzzzzzzzzzzzzzzzzzzzzzzzzx_ = ValidNumeratorEncounter?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzy_ as object);
            CqlInterval<CqlDate> ozzzzzzzzzzzzzzzzzzzzzzzzza_ = CQMCommon_2_2_000.Instance.ToDateInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.IPSD(context);
            CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(31m, "days");
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Add(ozzzzzzzzzzzzzzzzzzzzzzzzzc_, ozzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(300m, "days");
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Add(ozzzzzzzzzzzzzzzzzzzzzzzzzc_, ozzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDate> ozzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzzzzzzzzzzzh_, true, true);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDate>(ozzzzzzzzzzzzzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzzzzzzzzzzzzi_, "day");

            return ozzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzu_(Encounter ValidNumeratorEncounter)
        {
            Period ozzzzzzzzzzzzzzzzzzzzzzzzzk_ = ValidNumeratorEncounter?.Period;
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<CqlDate> nzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Encounter, CqlDate>(nzzzzzzzzzzzzzzzzzzzzzzzzzt_, nzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<CqlDate> nzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Distinct<CqlDate>(nzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Two or More Encounters 31 to 300 Days into Continuation and Maintenance Phase")]
    public bool? Two_or_More_Encounters_31_to_300_Days_into_Continuation_and_Maintenance_Phase(CqlContext context)
    {
        IEnumerable<CqlDate> ozzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(context);
        int? ozzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Count<CqlDate>(ozzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.GreaterOrEqual(ozzzzzzzzzzzzzzzzzzzzzzzzzp_, 2);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Virtual Encounter 31 to 300 Days into Continuation and Maintenance Phase")]
    public IEnumerable<CqlDate> Virtual_Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzt_ = Status_1_8_000.Instance.isEncounterPerformed(context, ozzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzu_(Encounter VirtualEnc)
        {
            Period ozzzzzzzzzzzzzzzzzzzzzzzzzz_ = VirtualEnc?.Period;
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzza_ as object);
            CqlInterval<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzzzzc_ = CQMCommon_2_2_000.Instance.ToDateInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.IPSD(context);
            CqlQuantity pzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(31m, "days");
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Add(pzzzzzzzzzzzzzzzzzzzzzzzzze_, pzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlQuantity pzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(300m, "days");
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Add(pzzzzzzzzzzzzzzzzzzzzzzzzze_, pzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(pzzzzzzzzzzzzzzzzzzzzzzzzzg_, pzzzzzzzzzzzzzzzzzzzzzzzzzj_, true, true);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzzzzd_, pzzzzzzzzzzzzzzzzzzzzzzzzzk_, "day");

            return pzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzt_, ozzzzzzzzzzzzzzzzzzzzzzzzzu_);
        CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzw_(Encounter VirtualEnc)
        {
            Period pzzzzzzzzzzzzzzzzzzzzzzzzzm_ = VirtualEnc?.Period;
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<CqlDate> ozzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<Encounter, CqlDate>(ozzzzzzzzzzzzzzzzzzzzzzzzzv_, ozzzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<CqlDate> ozzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Distinct<CqlDate>(ozzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public bool? Numerator_2(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Encounter_During_Initiation_Phase(context);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Two_or_More_Encounters_31_to_300_Days_into_Continuation_and_Maintenance_Phase(context);
        IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(context);
        IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzzzzu_(CqlDate Encounter1)
        {
            IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Virtual_Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(context);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzza_(CqlDate Encounter2)
            {
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(Encounter1 is null));
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(Encounter2 is null));
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzze_, qzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equivalent(Encounter1, Encounter2);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Not(qzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                return qzzzzzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDate qzzzzzzzzzzzzzzzzzzzzzzzzzc_(CqlDate Encounter2) =>
                Encounter1;
            IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<CqlDate, CqlDate>(qzzzzzzzzzzzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SelectMany<CqlDate, CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzzzzt_, pzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Or(pzzzzzzzzzzzzzzzzzzzzzzzzzs_, pzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? qzzzzzzzzzzzzzzzzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> qzzzzzzzzzzzzzzzzzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? qzzzzzzzzzzzzzzzzzzzzzzzzzm_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode qzzzzzzzzzzzzzzzzzzzzzzzzzn_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzn_;
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
