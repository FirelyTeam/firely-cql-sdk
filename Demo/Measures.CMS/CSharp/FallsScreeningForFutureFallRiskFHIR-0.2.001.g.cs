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
[CqlLibrary("FallsScreeningForFutureFallRiskFHIR", "0.2.001")]
public partial class FallsScreeningForFutureFallRiskFHIR_0_2_001 : ILibrary, ISingleton<FallsScreeningForFutureFallRiskFHIR_0_2_001>
{
    private FallsScreeningForFutureFallRiskFHIR_0_2_001() {}

    public static FallsScreeningForFutureFallRiskFHIR_0_2_001 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "FallsScreeningForFutureFallRiskFHIR";
    public string Version => "0.2.001";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance, Hospice_6_12_000.Instance, Status_1_8_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: Annual Wellness Visit
    [CqlValueSetDefinition(
        definitionName: "Annual Wellness Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240",
        valueSetVersion: null)]
    public CqlValueSet Annual_Wellness_Visit(CqlContext context) => _Annual_Wellness_Visit;

    private static readonly CqlValueSet _Annual_Wellness_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);
    #endregion

    #region ValueSet: Audiology Visit
    [CqlValueSetDefinition(
        definitionName: "Audiology Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1066",
        valueSetVersion: null)]
    public CqlValueSet Audiology_Visit(CqlContext context) => _Audiology_Visit;

    private static readonly CqlValueSet _Audiology_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1066", null);
    #endregion

    #region ValueSet: Care Services in Long Term Residential Facility
    [CqlValueSetDefinition(
        definitionName: "Care Services in Long Term Residential Facility",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014",
        valueSetVersion: null)]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility(CqlContext context) => _Care_Services_in_Long_Term_Residential_Facility;

    private static readonly CqlValueSet _Care_Services_in_Long_Term_Residential_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);
    #endregion

    #region ValueSet: Discharge Services Nursing Facility
    [CqlValueSetDefinition(
        definitionName: "Discharge Services Nursing Facility",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1013",
        valueSetVersion: null)]
    public CqlValueSet Discharge_Services_Nursing_Facility(CqlContext context) => _Discharge_Services_Nursing_Facility;

    private static readonly CqlValueSet _Discharge_Services_Nursing_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1013", null);
    #endregion

    #region ValueSet: Falls Screening
    [CqlValueSetDefinition(
        definitionName: "Falls Screening",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1028",
        valueSetVersion: null)]
    public CqlValueSet Falls_Screening(CqlContext context) => _Falls_Screening;

    private static readonly CqlValueSet _Falls_Screening = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1028", null);
    #endregion

    #region ValueSet: Home Healthcare Services
    [CqlValueSetDefinition(
        definitionName: "Home Healthcare Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016",
        valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext context) => _Home_Healthcare_Services;

    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);
    #endregion

    #region ValueSet: Nursing Facility Visit
    [CqlValueSetDefinition(
        definitionName: "Nursing Facility Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012",
        valueSetVersion: null)]
    public CqlValueSet Nursing_Facility_Visit(CqlContext context) => _Nursing_Facility_Visit;

    private static readonly CqlValueSet _Nursing_Facility_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);
    #endregion

    #region ValueSet: Occupational Therapy Evaluation
    [CqlValueSetDefinition(
        definitionName: "Occupational Therapy Evaluation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1011",
        valueSetVersion: null)]
    public CqlValueSet Occupational_Therapy_Evaluation(CqlContext context) => _Occupational_Therapy_Evaluation;

    private static readonly CqlValueSet _Occupational_Therapy_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1011", null);
    #endregion

    #region ValueSet: Office Visit
    [CqlValueSetDefinition(
        definitionName: "Office Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext context) => _Office_Visit;

    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);
    #endregion

    #region ValueSet: Ophthalmological Services
    [CqlValueSetDefinition(
        definitionName: "Ophthalmological Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285",
        valueSetVersion: null)]
    public CqlValueSet Ophthalmological_Services(CqlContext context) => _Ophthalmological_Services;

    private static readonly CqlValueSet _Ophthalmological_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", null);
    #endregion

    #region ValueSet: Physical Therapy Evaluation
    [CqlValueSetDefinition(
        definitionName: "Physical Therapy Evaluation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1022",
        valueSetVersion: null)]
    public CqlValueSet Physical_Therapy_Evaluation(CqlContext context) => _Physical_Therapy_Evaluation;

    private static readonly CqlValueSet _Physical_Therapy_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1022", null);
    #endregion

    #region ValueSet: Preventive Care Services Established Office Visit, 18 and Up
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services Established Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext context) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;

    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);
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

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, true, true);
        object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.ResolveParameter("FallsScreeningForFutureFallRiskFHIR-0.2.001", "Measurement Period", szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return (CqlInterval<CqlDateTime>)szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<Patient>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Office_Visit(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Encounter>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Discharge_Services_Nursing_Facility(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Audiology_Visit(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Physical_Therapy_Evaluation(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Occupational_Therapy_Evaluation(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = Status_1_8_000.Instance.isEncounterPerformed(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
            Period uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as object);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "day");

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Patient(context);
        Date uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.BirthDateElement;
        string uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
        CqlDate uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertStringToDate(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
        CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        int? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.CalculateAgeAt(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "year");
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.GreaterOrEqual(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, 65);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Qualifying_Encounter(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Initial_Population(context);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Falls_Screening(context);
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = Status_1_8_000.Instance.isAssessmentPerformed(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Observation FallsScreening)
        {
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
            DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FallsScreening?.Effective;
            object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "day");

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    #endregion Expressions

}
