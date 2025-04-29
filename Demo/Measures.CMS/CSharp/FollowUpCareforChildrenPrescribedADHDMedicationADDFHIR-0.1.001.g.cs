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

    #region ValueSet: Ambulatory
    [CqlValueSetDefinition(
        definitionName: "Ambulatory",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1003",
        valueSetVersion: null)]
    public CqlValueSet Ambulatory(CqlContext context) => _Ambulatory;

    private static readonly CqlValueSet _Ambulatory = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1003", null);
    #endregion

    #region ValueSet: Atomoxetine
    [CqlValueSetDefinition(
        definitionName: "Atomoxetine",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1170",
        valueSetVersion: null)]
    public CqlValueSet Atomoxetine(CqlContext context) => _Atomoxetine;

    private static readonly CqlValueSet _Atomoxetine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1170", null);
    #endregion

    #region ValueSet: Behavioral Health Follow up Visit
    [CqlValueSetDefinition(
        definitionName: "Behavioral Health Follow up Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1054",
        valueSetVersion: null)]
    public CqlValueSet Behavioral_Health_Follow_up_Visit(CqlContext context) => _Behavioral_Health_Follow_up_Visit;

    private static readonly CqlValueSet _Behavioral_Health_Follow_up_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1054", null);
    #endregion

    #region ValueSet: Clonidine
    [CqlValueSetDefinition(
        definitionName: "Clonidine",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1171",
        valueSetVersion: null)]
    public CqlValueSet Clonidine(CqlContext context) => _Clonidine;

    private static readonly CqlValueSet _Clonidine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1171", null);
    #endregion

    #region ValueSet: Dexmethylphenidate
    [CqlValueSetDefinition(
        definitionName: "Dexmethylphenidate",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1172",
        valueSetVersion: null)]
    public CqlValueSet Dexmethylphenidate(CqlContext context) => _Dexmethylphenidate;

    private static readonly CqlValueSet _Dexmethylphenidate = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1172", null);
    #endregion

    #region ValueSet: Dextroamphetamine
    [CqlValueSetDefinition(
        definitionName: "Dextroamphetamine",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1173",
        valueSetVersion: null)]
    public CqlValueSet Dextroamphetamine(CqlContext context) => _Dextroamphetamine;

    private static readonly CqlValueSet _Dextroamphetamine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1173", null);
    #endregion

    #region ValueSet: Encounter Inpatient
    [CqlValueSetDefinition(
        definitionName: "Encounter Inpatient",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307",
        valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext context) => _Encounter_Inpatient;

    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);
    #endregion

    #region ValueSet: Guanfacine Medications
    [CqlValueSetDefinition(
        definitionName: "Guanfacine Medications",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.11.1252",
        valueSetVersion: null)]
    public CqlValueSet Guanfacine_Medications(CqlContext context) => _Guanfacine_Medications;

    private static readonly CqlValueSet _Guanfacine_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.11.1252", null);
    #endregion

    #region ValueSet: Home Healthcare Services
    [CqlValueSetDefinition(
        definitionName: "Home Healthcare Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016",
        valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext context) => _Home_Healthcare_Services;

    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);
    #endregion

    #region ValueSet: Lisdexamfetamine
    [CqlValueSetDefinition(
        definitionName: "Lisdexamfetamine",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1174",
        valueSetVersion: null)]
    public CqlValueSet Lisdexamfetamine(CqlContext context) => _Lisdexamfetamine;

    private static readonly CqlValueSet _Lisdexamfetamine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1174", null);
    #endregion

    #region ValueSet: Mental Behavioral and Neurodevelopmental Disorders
    [CqlValueSetDefinition(
        definitionName: "Mental Behavioral and Neurodevelopmental Disorders",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1203",
        valueSetVersion: null)]
    public CqlValueSet Mental_Behavioral_and_Neurodevelopmental_Disorders(CqlContext context) => _Mental_Behavioral_and_Neurodevelopmental_Disorders;

    private static readonly CqlValueSet _Mental_Behavioral_and_Neurodevelopmental_Disorders = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1203", null);
    #endregion

    #region ValueSet: Methylphenidate
    [CqlValueSetDefinition(
        definitionName: "Methylphenidate",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1176",
        valueSetVersion: null)]
    public CqlValueSet Methylphenidate(CqlContext context) => _Methylphenidate;

    private static readonly CqlValueSet _Methylphenidate = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1176", null);
    #endregion

    #region ValueSet: Narcolepsy
    [CqlValueSetDefinition(
        definitionName: "Narcolepsy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.114.12.1011",
        valueSetVersion: null)]
    public CqlValueSet Narcolepsy(CqlContext context) => _Narcolepsy;

    private static readonly CqlValueSet _Narcolepsy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.114.12.1011", null);
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

    #region ValueSet: Psych Visit Diagnostic Evaluation
    [CqlValueSetDefinition(
        definitionName: "Psych Visit Diagnostic Evaluation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492",
        valueSetVersion: null)]
    public CqlValueSet Psych_Visit_Diagnostic_Evaluation(CqlContext context) => _Psych_Visit_Diagnostic_Evaluation;

    private static readonly CqlValueSet _Psych_Visit_Diagnostic_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492", null);
    #endregion

    #region ValueSet: Psych Visit Psychotherapy
    [CqlValueSetDefinition(
        definitionName: "Psych Visit Psychotherapy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496",
        valueSetVersion: null)]
    public CqlValueSet Psych_Visit_Psychotherapy(CqlContext context) => _Psych_Visit_Psychotherapy;

    private static readonly CqlValueSet _Psych_Visit_Psychotherapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", null);
    #endregion

    #region ValueSet: Psychotherapy and Pharmacologic Management
    [CqlValueSetDefinition(
        definitionName: "Psychotherapy and Pharmacologic Management",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1055",
        valueSetVersion: null)]
    public CqlValueSet Psychotherapy_and_Pharmacologic_Management(CqlContext context) => _Psychotherapy_and_Pharmacologic_Management;

    private static readonly CqlValueSet _Psychotherapy_and_Pharmacologic_Management = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1055", null);
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

    #region Code: 24 HR dexmethylphenidate hydrochloride 40 MG Extended Release Oral Capsule
    [CqlCodeDefinition(
        definitionName: "24 HR dexmethylphenidate hydrochloride 40 MG Extended Release Oral Capsule",
        codeId: "1006608",
        codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode _24_HR_dexmethylphenidate_hydrochloride_40_MG_Extended_Release_Oral_Capsule(CqlContext context) => __24_HR_dexmethylphenidate_hydrochloride_40_MG_Extended_Release_Oral_Capsule;

    private static readonly CqlCode __24_HR_dexmethylphenidate_hydrochloride_40_MG_Extended_Release_Oral_Capsule = new CqlCode("1006608", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);
    #endregion

    #region Code: methamphetamine hydrochloride 5 MG Oral Tablet
    [CqlCodeDefinition(
        definitionName: "methamphetamine hydrochloride 5 MG Oral Tablet",
        codeId: "977860",
        codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode methamphetamine_hydrochloride_5_MG_Oral_Tablet(CqlContext context) => _methamphetamine_hydrochloride_5_MG_Oral_Tablet;

    private static readonly CqlCode _methamphetamine_hydrochloride_5_MG_Oral_Tablet = new CqlCode("977860", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "RXNORM")]
    public CqlCode[] RXNORM(CqlContext context)
    {
        CqlCode[] qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = [
            new CqlCode("1006608", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
            new CqlCode("977860", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
        ];

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, true, true);
        object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.ResolveParameter("FollowUpCareforChildrenPrescribedADHDMedicationADDFHIR-0.1.001", "Measurement Period", qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return (CqlInterval<CqlDateTime>)qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SingletonFrom<Patient>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "March 1 of Year Prior to Measurement Period")]
    public CqlDateTime March_1_of_Year_Prior_to_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
        CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        int? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateTimeComponentFrom(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "year");
        int? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Subtract(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, 1);
        decimal? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateTime(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, 3, 1, 0, 0, 0, 0, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Last Calendar Day of February of Measurement Period")]
    public CqlDateTime Last_Calendar_Day_of_February_of_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Measurement_Period(context);
        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        int? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateTimeComponentFrom(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, "year");
        decimal? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateTime(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, 3, 1, 23, 59, 59, 0, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlQuantity rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(1m, "day");
        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Subtract(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Intake Period")]
    public CqlInterval<CqlDateTime> Intake_Period(CqlContext context)
    {
        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.March_1_of_Year_Prior_to_Measurement_Period(context);
        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Last_Calendar_Day_of_February_of_Measurement_Period(context);
        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, true, true);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "ADHD Medication Prescribed During Intake Period and Not Previously on ADHD Medication")]
    public IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Atomoxetine(context);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<MedicationRequest>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Clonidine(context);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<MedicationRequest>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<MedicationRequest>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Dexmethylphenidate(context);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<MedicationRequest>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<MedicationRequest>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Dextroamphetamine(context);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Lisdexamfetamine(context);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        CqlCode szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
        IEnumerable<CqlCode> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ToList<CqlCode>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<CqlCode> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ToList<CqlCode>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Methylphenidate(context);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Guanfacine_Medications(context);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<MedicationRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<MedicationRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = Status_1_8_000.Instance.isMedicationOrder(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(MedicationRequest ADHDMedications)
        {
            CqlInterval<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ADHDMedications);
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertDateToDateTime(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Intake_Period(context);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<MedicationRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<MedicationRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<MedicationRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<MedicationRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<MedicationRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<MedicationRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<MedicationRequest>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<MedicationRequest>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<MedicationRequest>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<MedicationRequest>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<CqlCode> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ToList<CqlCode>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<CqlCode> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ToList<CqlCode>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<MedicationRequest>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<MedicationRequest>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<MedicationRequest>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<MedicationRequest>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<MedicationRequest>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<MedicationRequest>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = Status_1_8_000.Instance.isMedicationOrder(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(MedicationRequest ADHDMedications)
        {
            CqlInterval<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ADHDMedications);
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertDateToDateTime(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Intake_Period(context);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<MedicationRequest>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(MedicationRequest ADHDMedicationOrder)
        {
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Atomoxetine(context);
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<MedicationRequest>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Clonidine(context);
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<MedicationRequest>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<MedicationRequest>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Dexmethylphenidate(context);
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<MedicationRequest>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<MedicationRequest>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Dextroamphetamine(context);
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<MedicationRequest>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<MedicationRequest>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Lisdexamfetamine(context);
            IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<MedicationRequest>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<MedicationRequest>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlCode xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
            IEnumerable<CqlCode> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ToList<CqlCode>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<CqlCode> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ToList<CqlCode>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<MedicationRequest>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<MedicationRequest>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Methylphenidate(context);
            IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<MedicationRequest>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<MedicationRequest>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Guanfacine_Medications(context);
            IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<MedicationRequest>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<MedicationRequest>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = Status_1_8_000.Instance.isMedicationActive(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(MedicationRequest ActiveADHDMedication)
            {
                CqlInterval<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ActiveADHDMedication);
                CqlInterval<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ADHDMedicationOrder);
                CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertDateToDateTime(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(120m, "days");
                CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Subtract(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConvertDateToDateTime(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, true, false);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Overlaps(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default);

                return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<MedicationRequest>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            MedicationRequest yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(MedicationRequest ActiveADHDMedication) =>
                ADHDMedicationOrder;
            IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<MedicationRequest, MedicationRequest>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Except<MedicationRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        (CqlTupleMetadata, CqlDate startDate)? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(MedicationRequest QualifyingMed)
        {
            CqlInterval<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, QualifyingMed);
            CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            (CqlTupleMetadata, CqlDate startDate)? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = (CqlTupleMetadata_CVELXTjiMTaGQEjMfJXBdUHjW, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlDate startDate)?>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_((CqlTupleMetadata, CqlDate startDate)? @this)
        {
            CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = @this?.startDate;

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDate startDate)?>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, System.ComponentModel.ListSortDirection.Ascending);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "First ADHD Medication Prescribed During Intake Period")]
    public CqlDate First_ADHD_Medication_Prescribed_During_Intake_Period(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.ADHD_Medication_Prescribed_During_Intake_Period_and_Not_Previously_on_ADHD_Medication(context);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_((CqlTupleMetadata, CqlDate startDate)? @this)
        {
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.startDate;
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ is null));

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate startDate)?> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<(CqlTupleMetadata, CqlDate startDate)?>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_((CqlTupleMetadata, CqlDate startDate)? @this)
        {
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.startDate;

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, CqlDate startDate)?, CqlDate>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.First<CqlDate>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "IPSD")]
    public CqlDate IPSD(CqlContext context)
    {
        CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.First_ADHD_Medication_Prescribed_During_Intake_Period(context);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Office_Visit(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = Status_1_8_000.Instance.isEncounterPerformed(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Encounter ValidEncounters)
        {
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.IPSD(context);
            CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(6m, "months");
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Subtract(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, true, true);
            Period zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as object);
            CqlInterval<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = CQMCommon_2_2_000.Instance.ToDateInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.IntervalIncludesInterval<CqlDate>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "day");

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Inpatient Stay with Qualifying Diagnosis")]
    public IEnumerable<Encounter> Inpatient_Stay_with_Qualifying_Diagnosis(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = Status_1_8_000.Instance.isEncounterPerformed(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Encounter InpatientStay)
        {
            Condition azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = CQMCommon_2_2_000.Instance.principalDiagnosis(context, InpatientStay);
            CodeableConcept azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Code;
            CqlConcept azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Mental_Behavioral_and_Neurodevelopmental_Disorders(context);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConceptInValueSet(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Inpatient Stay with Qualifying Diagnosis During Initiation Phase")]
    public IEnumerable<Encounter> Inpatient_Stay_with_Qualifying_Diagnosis_During_Initiation_Phase(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Inpatient_Stay_with_Qualifying_Diagnosis(context);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Encounter InpatientStay)
        {
            Period azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = InpatientStay?.Period;
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as object);
            CqlInterval<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = CQMCommon_2_2_000.Instance.ToDateInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.IPSD(context);
            CqlQuantity azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(30m, "days");
            CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Add(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, false, true);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "day");
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ is null));
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population 1")]
    public bool? Initial_Population_1(CqlContext context)
    {
        Patient bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Patient(context);
        Date bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.BirthDateElement;
        string bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
        CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertStringToDate(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Intake_Period(context);
        CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        int? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.CalculateAgeAt(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, "year");
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.GreaterOrEqual(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, 6);
        Date bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.BirthDateElement;
        string bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
        CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertStringToDate(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.End(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        int? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.CalculateAgeAt(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "year");
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.LessOrEqual(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, 12);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Qualifying_Encounter(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.First_ADHD_Medication_Prescribed_During_Intake_Period(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ is null));
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Inpatient_Stay_with_Qualifying_Diagnosis_During_Initiation_Phase(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator 1")]
    public bool? Denominator_1(CqlContext context)
    {
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Initial_Population_1(context);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Narcolepsy Exclusion")]
    public IEnumerable<Condition> Narcolepsy_Exclusion(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Narcolepsy(context);
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Condition Narcolepsy)
        {
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Narcolepsy);
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.End(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SameOrBefore(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Condition>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Narcolepsy_Exclusion(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Condition>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Numerator Encounter")]
    public IEnumerable<Encounter> Qualifying_Numerator_Encounter(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Office_Visit(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Preventive_Care_Services_Group_Counseling(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Behavioral_Health_Follow_up_Visit(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Psychotherapy_and_Pharmacologic_Management(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Encounter PsychPharmManagement)
        {
            List<Encounter.LocationComponent> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = PsychPharmManagement?.Location;
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Encounter.LocationComponent Location)
            {
                ResourceReference ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = Location?.Location;
                Location ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = CQMCommon_2_2_000.Instance.GetLocation(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                List<CodeableConcept> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Type;
                CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(CodeableConcept @this)
                {
                    CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                    return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
                };
                IEnumerable<CqlConcept> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Ambulatory(context);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConceptsInValueSet(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Encounter.LocationComponent> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<Encounter.LocationComponent>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Psych_Visit_Diagnostic_Evaluation(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Psych_Visit_Psychotherapy(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter During Initiation Phase")]
    public IEnumerable<Encounter> Encounter_During_Initiation_Phase(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Qualifying_Numerator_Encounter(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = Status_1_8_000.Instance.isEncounterPerformed(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Encounter ValidNumeratorEncounter)
        {
            Period ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = ValidNumeratorEncounter?.Period;
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as object);
            CqlInterval<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = CQMCommon_2_2_000.Instance.ToDateInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.IPSD(context);
            CqlQuantity fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(30m, "days");
            CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Add(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, false, true);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "day");
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ is null));
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator 1")]
    public bool? Numerator_1(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Encounter_During_Initiation_Phase(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "ADHD Medications Taken on IPSD or During Continuation and Maintenance Phase")]
    public IEnumerable<CqlInterval<CqlDate>> ADHD_Medications_Taken_on_IPSD_or_During_Continuation_and_Maintenance_Phase(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Atomoxetine(context);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<MedicationRequest>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = Status_1_8_000.Instance.isMedicationOrder(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(MedicationRequest AtomoxetineMed)
        {
            CqlInterval<CqlDate> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, AtomoxetineMed);
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = @this?.periodStart;

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = @this?.period;
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is null));

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        CqlInterval<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = @this?.period;

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<CqlInterval<CqlDate>> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Clonidine(context);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = Status_1_8_000.Instance.isMedicationOrder(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(MedicationRequest ClonidineMed)
        {
            CqlInterval<CqlDate> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ClonidineMed);
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.periodStart;

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = @this?.period;
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ is null));

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        CqlInterval<CqlDate> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.period;

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<CqlInterval<CqlDate>>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Dexmethylphenidate(context);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = Status_1_8_000.Instance.isMedicationOrder(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(MedicationRequest DexmethylphenidateMed)
        {
            CqlInterval<CqlDate> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, DexmethylphenidateMed);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.periodStart;

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = @this?.period;
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ is null));

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        CqlInterval<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = @this?.period;

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Dextroamphetamine(context);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = Status_1_8_000.Instance.isMedicationOrder(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(MedicationRequest DextroamphetamineMed)
        {
            CqlInterval<CqlDate> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, DextroamphetamineMed);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = @this?.periodStart;

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, System.ComponentModel.ListSortDirection.Ascending);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = @this?.period;
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ is null));

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlInterval<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = @this?.period;

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<CqlInterval<CqlDate>>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<CqlInterval<CqlDate>>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Lisdexamfetamine(context);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = Status_1_8_000.Instance.isMedicationOrder(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(MedicationRequest LisdexamfetamineMed)
        {
            CqlInterval<CqlDate> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, LisdexamfetamineMed);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.periodStart;

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = @this?.period;
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ is null));

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        CqlInterval<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = @this?.period;

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Methylphenidate(context);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<MedicationRequest>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = Status_1_8_000.Instance.isMedicationOrder(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(MedicationRequest MethylphenidateMed)
        {
            CqlInterval<CqlDate> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, MethylphenidateMed);
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.periodStart;

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = @this?.period;
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is null));

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        CqlInterval<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = @this?.period;

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<CqlInterval<CqlDate>> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<CqlInterval<CqlDate>> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<CqlInterval<CqlDate>>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<CqlInterval<CqlDate>> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<CqlInterval<CqlDate>>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Guanfacine_Medications(context);
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<MedicationRequest>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = Status_1_8_000.Instance.isMedicationOrder(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(MedicationRequest GuanfacineMed)
        {
            CqlInterval<CqlDate> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, GuanfacineMed);
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.periodStart;

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = @this?.period;
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ is null));

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        CqlInterval<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = @this?.period;

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<CqlInterval<CqlDate>> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<CqlInterval<CqlDate>> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlCode jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.methamphetamine_hydrochloride_5_MG_Oral_Tablet(context);
        IEnumerable<CqlCode> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ToList<CqlCode>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<CqlCode> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ToList<CqlCode>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<MedicationRequest>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = Status_1_8_000.Instance.isMedicationOrder(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(MedicationRequest MethamphetamineMed)
        {
            CqlInterval<CqlDate> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, MethamphetamineMed);
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = (CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = @this?.periodStart;

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.period;
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is null));

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlInterval<CqlDate> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_((CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)? @this)
        {
            CqlInterval<CqlDate> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = @this?.period;

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> period, CqlDate periodStart)?, CqlInterval<CqlDate>>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = CumulativeMedicationDuration_4_1_000.Instance.rolloutIntervals(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<CqlInterval<CqlDate>>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<CqlInterval<CqlDate>>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        CqlInterval<CqlDate> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(CqlInterval<CqlDate> ADHDMedication)
        {
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.IPSD(context);
            CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(300m, "days");
            CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Add(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDate> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, true, true);
            CqlInterval<CqlDate> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Intersect<CqlDate>(ADHDMedication, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "ADHD Cumulative Medication Duration")]
    public int? ADHD_Cumulative_Medication_Duration(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDate>> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.ADHD_Medications_Taken_on_IPSD_or_During_Continuation_and_Maintenance_Phase(context);
        int? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = CumulativeMedicationDuration_4_1_000.Instance.cumulativeDuration(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has ADHD Cumulative Medication Duration Greater Than or Equal to 210 Days")]
    public bool? Has_ADHD_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_210_Days(CqlContext context)
    {
        int? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.ADHD_Cumulative_Medication_Duration(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.GreaterOrEqual(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, 210);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "Inpatient Stay with Qualifying Diagnosis During Continuation and Maintenance Phase")]
    public IEnumerable<Encounter> Inpatient_Stay_with_Qualifying_Diagnosis_During_Continuation_and_Maintenance_Phase(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Inpatient_Stay_with_Qualifying_Diagnosis(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Encounter InpatientStay)
        {
            Period nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = InpatientStay?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as object);
            CqlInterval<CqlDate> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = CQMCommon_2_2_000.Instance.ToDateInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.IPSD(context);
            CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(300m, "days");
            CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Add(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDate> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, false, true);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDate>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, "day");
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ is null));
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population 2")]
    public bool? Initial_Population_2(CqlContext context)
    {
        Patient ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Patient(context);
        Date ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_?.BirthDateElement;
        string ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
        CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertStringToDate(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Intake_Period(context);
        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        int? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.CalculateAgeAt(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, "year");
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.GreaterOrEqual(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, 6);
        Date ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_?.BirthDateElement;
        string ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
        CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConvertStringToDate(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.End(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        int? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.CalculateAgeAt(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "year");
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.LessOrEqual(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, 12);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Qualifying_Encounter(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.First_ADHD_Medication_Prescribed_During_Intake_Period(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is null));
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Has_ADHD_Cumulative_Medication_Duration_Greater_Than_or_Equal_to_210_Days(context);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Inpatient_Stay_with_Qualifying_Diagnosis_During_Continuation_and_Maintenance_Phase(context);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator 2")]
    public bool? Denominator_2(CqlContext context)
    {
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Initial_Population_2(context);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter 31 to 300 Days into Continuation and Maintenance Phase")]
    public IEnumerable<CqlDate> Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Qualifying_Numerator_Encounter(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = Status_1_8_000.Instance.isEncounterPerformed(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Encounter ValidNumeratorEncounter)
        {
            Period pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = ValidNumeratorEncounter?.Period;
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as object);
            CqlInterval<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = CQMCommon_2_2_000.Instance.ToDateInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.IPSD(context);
            CqlQuantity pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(31m, "days");
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Add(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlQuantity pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(300m, "days");
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Add(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, true, true);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "day");

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Encounter ValidNumeratorEncounter)
        {
            Period qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = ValidNumeratorEncounter?.Period;
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDate qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Encounter, CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Distinct<CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "Two or More Encounters 31 to 300 Days into Continuation and Maintenance Phase")]
    public bool? Two_or_More_Encounters_31_to_300_Days_into_Continuation_and_Maintenance_Phase(CqlContext context)
    {
        IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(context);
        int? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Count<CqlDate>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.GreaterOrEqual(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, 2);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Virtual Encounter 31 to 300 Days into Continuation and Maintenance Phase")]
    public IEnumerable<CqlDate> Virtual_Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = Status_1_8_000.Instance.isEncounterPerformed(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Encounter VirtualEnc)
        {
            Period qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = VirtualEnc?.Period;
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as object);
            CqlInterval<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = CQMCommon_2_2_000.Instance.ToDateInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDate qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDate qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.IPSD(context);
            CqlQuantity qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(31m, "days");
            CqlDate qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Add(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlQuantity qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(300m, "days");
            CqlDate qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Add(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDate> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, true, true);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDate>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "day");

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlDate qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Encounter VirtualEnc)
        {
            Period rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = VirtualEnc?.Period;
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Encounter, CqlDate>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<CqlDate>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator 2")]
    public bool? Numerator_2(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Encounter_During_Initiation_Phase(context);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Two_or_More_Encounters_31_to_300_Days_into_Continuation_and_Maintenance_Phase(context);
        IEnumerable<CqlDate> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(context);
        IEnumerable<CqlDate> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(CqlDate Encounter1)
        {
            IEnumerable<CqlDate> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Virtual_Encounter_31_to_300_Days_into_Continuation_and_Maintenance_Phase(context);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(CqlDate Encounter2)
            {
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(Encounter1 is null));
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(Encounter2 is null));
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Equivalent(Encounter1, Encounter2);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Not(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<CqlDate> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<CqlDate>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(CqlDate Encounter2) =>
                Encounter1;
            IEnumerable<CqlDate> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<CqlDate, CqlDate>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<CqlDate> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SelectMany<CqlDate, CqlDate>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<CqlDate>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
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
