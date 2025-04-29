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
[CqlLibrary("PCMaternal", "5.19.000")]
public partial class PCMaternal_5_19_000 : ILibrary, ISingleton<PCMaternal_5_19_000>
{
    private PCMaternal_5_19_000() {}

    public static PCMaternal_5_19_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "PCMaternal";
    public string Version => "5.19.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, CQMCommon_2_2_000.Instance, QICoreCommon_2_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: Delivery Procedures
    [CqlValueSetDefinition(
        definitionName: "Delivery Procedures",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.59",
        valueSetVersion: null)]
    public CqlValueSet Delivery_Procedures(CqlContext context) => _Delivery_Procedures;

    private static readonly CqlValueSet _Delivery_Procedures = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.59", null);
    #endregion

    #region ValueSet: ED Visit and OB Triage
    [CqlValueSetDefinition(
        definitionName: "ED Visit and OB Triage",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.369",
        valueSetVersion: null)]
    public CqlValueSet ED_Visit_and_OB_Triage(CqlContext context) => _ED_Visit_and_OB_Triage;

    private static readonly CqlValueSet _ED_Visit_and_OB_Triage = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.369", null);
    #endregion

    #region ValueSet: Encounter Inpatient
    [CqlValueSetDefinition(
        definitionName: "Encounter Inpatient",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307",
        valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext context) => _Encounter_Inpatient;

    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);
    #endregion

    #region ValueSet: Estimated Gestational Age at Delivery
    [CqlValueSetDefinition(
        definitionName: "Estimated Gestational Age at Delivery",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.26",
        valueSetVersion: null)]
    public CqlValueSet Estimated_Gestational_Age_at_Delivery(CqlContext context) => _Estimated_Gestational_Age_at_Delivery;

    private static readonly CqlValueSet _Estimated_Gestational_Age_at_Delivery = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.26", null);
    #endregion

    #region ValueSet: Observation Services
    [CqlValueSetDefinition(
        definitionName: "Observation Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143",
        valueSetVersion: null)]
    public CqlValueSet Observation_Services(CqlContext context) => _Observation_Services;

    private static readonly CqlValueSet _Observation_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Date and time of obstetric delivery
    [CqlCodeDefinition(
        definitionName: "Date and time of obstetric delivery",
        codeId: "93857-1",
        codeSystem: "http://loinc.org")]
    public CqlCode Date_and_time_of_obstetric_delivery(CqlContext context) => _Date_and_time_of_obstetric_delivery;

    private static readonly CqlCode _Date_and_time_of_obstetric_delivery = new CqlCode("93857-1", "http://loinc.org", default, default);
    #endregion

    #region Code: Delivery date Estimated
    [CqlCodeDefinition(
        definitionName: "Delivery date Estimated",
        codeId: "11778-8",
        codeSystem: "http://loinc.org")]
    public CqlCode Delivery_date_Estimated(CqlContext context) => _Delivery_date_Estimated;

    private static readonly CqlCode _Delivery_date_Estimated = new CqlCode("11778-8", "http://loinc.org", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] tzzzzzzzzzzzzzzzzzm_ = [
            new CqlCode("93857-1", "http://loinc.org", default, default),
            new CqlCode("11778-8", "http://loinc.org", default, default),
        ];

        return tzzzzzzzzzzzzzzzzzm_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime tzzzzzzzzzzzzzzzzzn_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime tzzzzzzzzzzzzzzzzzo_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(tzzzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzzzo_, true, true);
        object tzzzzzzzzzzzzzzzzzq_ = context.ResolveParameter("PCMaternal-5.19.000", "Measurement Period", tzzzzzzzzzzzzzzzzzp_);

        return (CqlInterval<CqlDateTime>)tzzzzzzzzzzzzzzzzzq_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> tzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient tzzzzzzzzzzzzzzzzzs_ = context.Operators.SingletonFrom<Patient>(tzzzzzzzzzzzzzzzzzr_);

        return tzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Age Range")]
    public IEnumerable<Encounter> Encounter_with_Age_Range(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzt_ = CQMCommon_2_2_000.Instance.Inpatient_Encounter(context);
        bool? tzzzzzzzzzzzzzzzzzu_(Encounter InpatientEncounter)
        {
            Patient tzzzzzzzzzzzzzzzzzw_ = this.Patient(context);
            Date tzzzzzzzzzzzzzzzzzx_ = tzzzzzzzzzzzzzzzzzw_?.BirthDateElement;
            string tzzzzzzzzzzzzzzzzzy_ = tzzzzzzzzzzzzzzzzzx_?.Value;
            CqlDate tzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertStringToDate(tzzzzzzzzzzzzzzzzzy_);
            Period uzzzzzzzzzzzzzzzzza_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzza_);
            CqlDateTime uzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzb_);
            CqlDate uzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzc_);
            int? uzzzzzzzzzzzzzzzzze_ = context.Operators.CalculateAgeAt(tzzzzzzzzzzzzzzzzzz_, uzzzzzzzzzzzzzzzzzd_, "year");
            CqlInterval<int?> uzzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(8, 65, true, false);
            bool? uzzzzzzzzzzzzzzzzzg_ = context.Operators.In<int?>(uzzzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzzzf_, default);

            return uzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(tzzzzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzzzzu_);

        return tzzzzzzzzzzzzzzzzzv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDateTime> hospitalizationWithEDOBTriageObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] uzzzzzzzzzzzzzzzzzh_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzi_(Encounter Visit)
        {
            CqlValueSet uzzzzzzzzzzzzzzzzzm_ = this.ED_Visit_and_OB_Triage(context);
            IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? uzzzzzzzzzzzzzzzzzo_(Encounter LastEDOBTriage)
            {
                Period vzzzzzzzzzzzzzzzzzn_ = LastEDOBTriage?.Period;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzn_);
                CqlDateTime vzzzzzzzzzzzzzzzzzp_ = context.Operators.End(vzzzzzzzzzzzzzzzzzo_);
                CqlValueSet vzzzzzzzzzzzzzzzzzq_ = this.Observation_Services(context);
                IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? vzzzzzzzzzzzzzzzzzs_(Encounter LastObs)
                {
                    Period xzzzzzzzzzzzzzzzzzo_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzo_);
                    CqlDateTime xzzzzzzzzzzzzzzzzzq_ = context.Operators.End(xzzzzzzzzzzzzzzzzzp_);
                    Period xzzzzzzzzzzzzzzzzzr_ = Visit?.Period;
                    CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzr_);
                    CqlDateTime xzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzs_);
                    CqlQuantity xzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime xzzzzzzzzzzzzzzzzzv_ = context.Operators.Subtract(xzzzzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzzzzu_);
                    CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzr_);
                    CqlDateTime xzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzx_);
                    CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzv_, xzzzzzzzzzzzzzzzzzy_, true, true);
                    bool? yzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzzzzz_, default);
                    CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzr_);
                    CqlDateTime yzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzc_);
                    bool? yzzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzzd_ is null));
                    bool? yzzzzzzzzzzzzzzzzzf_ = context.Operators.And(yzzzzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzzzze_);
                    Code<Encounter.EncounterStatus> yzzzzzzzzzzzzzzzzzg_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? yzzzzzzzzzzzzzzzzzh_ = yzzzzzzzzzzzzzzzzzg_?.Value;
                    Code<Encounter.EncounterStatus> yzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(yzzzzzzzzzzzzzzzzzh_);
                    bool? yzzzzzzzzzzzzzzzzzj_ = context.Operators.Equal(yzzzzzzzzzzzzzzzzzi_, "finished");
                    bool? yzzzzzzzzzzzzzzzzzk_ = context.Operators.And(yzzzzzzzzzzzzzzzzzf_, yzzzzzzzzzzzzzzzzzj_);

                    return yzzzzzzzzzzzzzzzzzk_;
                };
                IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(vzzzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzzzs_);
                object vzzzzzzzzzzzzzzzzzu_(Encounter @this)
                {
                    Period yzzzzzzzzzzzzzzzzzl_ = @this?.Period;
                    CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzl_);
                    CqlDateTime yzzzzzzzzzzzzzzzzzn_ = context.Operators.End(yzzzzzzzzzzzzzzzzzm_);

                    return yzzzzzzzzzzzzzzzzzn_;
                };
                IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzv_ = context.Operators.SortBy<Encounter>(vzzzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter vzzzzzzzzzzzzzzzzzw_ = context.Operators.Last<Encounter>(vzzzzzzzzzzzzzzzzzv_);
                Period vzzzzzzzzzzzzzzzzzx_ = vzzzzzzzzzzzzzzzzzw_?.Period;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzx_);
                CqlDateTime vzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzy_);
                Period wzzzzzzzzzzzzzzzzza_ = Visit?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzza_);
                CqlDateTime wzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzb_);
                CqlQuantity wzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime wzzzzzzzzzzzzzzzzze_ = context.Operators.Subtract(vzzzzzzzzzzzzzzzzzz_ ?? wzzzzzzzzzzzzzzzzzc_, wzzzzzzzzzzzzzzzzzd_);
                IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? wzzzzzzzzzzzzzzzzzh_(Encounter LastObs)
                {
                    Period yzzzzzzzzzzzzzzzzzo_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzo_);
                    CqlDateTime yzzzzzzzzzzzzzzzzzq_ = context.Operators.End(yzzzzzzzzzzzzzzzzzp_);
                    Period yzzzzzzzzzzzzzzzzzr_ = Visit?.Period;
                    CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzr_);
                    CqlDateTime yzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzs_);
                    CqlQuantity yzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime yzzzzzzzzzzzzzzzzzv_ = context.Operators.Subtract(yzzzzzzzzzzzzzzzzzt_, yzzzzzzzzzzzzzzzzzu_);
                    CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzr_);
                    CqlDateTime yzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzx_);
                    CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzzzzy_, true, true);
                    bool? zzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzzzzzz_, default);
                    CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzr_);
                    CqlDateTime zzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzc_);
                    bool? zzzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzzzd_ is null));
                    bool? zzzzzzzzzzzzzzzzzzf_ = context.Operators.And(zzzzzzzzzzzzzzzzzza_, zzzzzzzzzzzzzzzzzze_);
                    Code<Encounter.EncounterStatus> zzzzzzzzzzzzzzzzzzg_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? zzzzzzzzzzzzzzzzzzh_ = zzzzzzzzzzzzzzzzzzg_?.Value;
                    Code<Encounter.EncounterStatus> zzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(zzzzzzzzzzzzzzzzzzh_);
                    bool? zzzzzzzzzzzzzzzzzzj_ = context.Operators.Equal(zzzzzzzzzzzzzzzzzzi_, "finished");
                    bool? zzzzzzzzzzzzzzzzzzk_ = context.Operators.And(zzzzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzzzj_);

                    return zzzzzzzzzzzzzzzzzzk_;
                };
                IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(wzzzzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzzzzh_);
                object wzzzzzzzzzzzzzzzzzj_(Encounter @this)
                {
                    Period zzzzzzzzzzzzzzzzzzl_ = @this?.Period;
                    CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzl_);
                    CqlDateTime zzzzzzzzzzzzzzzzzzn_ = context.Operators.End(zzzzzzzzzzzzzzzzzzm_);

                    return zzzzzzzzzzzzzzzzzzn_;
                };
                IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzk_ = context.Operators.SortBy<Encounter>(wzzzzzzzzzzzzzzzzzi_, wzzzzzzzzzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter wzzzzzzzzzzzzzzzzzl_ = context.Operators.Last<Encounter>(wzzzzzzzzzzzzzzzzzk_);
                Period wzzzzzzzzzzzzzzzzzm_ = wzzzzzzzzzzzzzzzzzl_?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzm_);
                CqlDateTime wzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzza_);
                CqlDateTime wzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(wzzzzzzzzzzzzzzzzze_, wzzzzzzzzzzzzzzzzzo_ ?? wzzzzzzzzzzzzzzzzzr_, true, true);
                bool? wzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzp_, wzzzzzzzzzzzzzzzzzs_, default);
                IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? wzzzzzzzzzzzzzzzzzw_(Encounter LastObs)
                {
                    Period zzzzzzzzzzzzzzzzzzo_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzo_);
                    CqlDateTime zzzzzzzzzzzzzzzzzzq_ = context.Operators.End(zzzzzzzzzzzzzzzzzzp_);
                    Period zzzzzzzzzzzzzzzzzzr_ = Visit?.Period;
                    CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzr_);
                    CqlDateTime zzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzs_);
                    CqlQuantity zzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime zzzzzzzzzzzzzzzzzzv_ = context.Operators.Subtract(zzzzzzzzzzzzzzzzzzt_, zzzzzzzzzzzzzzzzzzu_);
                    CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzr_);
                    CqlDateTime zzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzx_);
                    CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzzzzzy_, true, true);
                    bool? azzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzzzzzz_, default);
                    CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzr_);
                    CqlDateTime azzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzc_);
                    bool? azzzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzzzd_ is null));
                    bool? azzzzzzzzzzzzzzzzzzf_ = context.Operators.And(azzzzzzzzzzzzzzzzzza_, azzzzzzzzzzzzzzzzzze_);
                    Code<Encounter.EncounterStatus> azzzzzzzzzzzzzzzzzzg_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? azzzzzzzzzzzzzzzzzzh_ = azzzzzzzzzzzzzzzzzzg_?.Value;
                    Code<Encounter.EncounterStatus> azzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(azzzzzzzzzzzzzzzzzzh_);
                    bool? azzzzzzzzzzzzzzzzzzj_ = context.Operators.Equal(azzzzzzzzzzzzzzzzzzi_, "finished");
                    bool? azzzzzzzzzzzzzzzzzzk_ = context.Operators.And(azzzzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzzzj_);

                    return azzzzzzzzzzzzzzzzzzk_;
                };
                IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(wzzzzzzzzzzzzzzzzzv_, wzzzzzzzzzzzzzzzzzw_);
                object wzzzzzzzzzzzzzzzzzy_(Encounter @this)
                {
                    Period azzzzzzzzzzzzzzzzzzl_ = @this?.Period;
                    CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzl_);
                    CqlDateTime azzzzzzzzzzzzzzzzzzn_ = context.Operators.End(azzzzzzzzzzzzzzzzzzm_);

                    return azzzzzzzzzzzzzzzzzzn_;
                };
                IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzz_ = context.Operators.SortBy<Encounter>(wzzzzzzzzzzzzzzzzzx_, wzzzzzzzzzzzzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter xzzzzzzzzzzzzzzzzza_ = context.Operators.Last<Encounter>(wzzzzzzzzzzzzzzzzzz_);
                Period xzzzzzzzzzzzzzzzzzb_ = xzzzzzzzzzzzzzzzzza_?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzb_);
                CqlDateTime xzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzza_);
                CqlDateTime xzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzf_);
                bool? xzzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)((xzzzzzzzzzzzzzzzzzd_ ?? xzzzzzzzzzzzzzzzzzg_) is null));
                bool? xzzzzzzzzzzzzzzzzzi_ = context.Operators.And(wzzzzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzzzzh_);
                Code<Encounter.EncounterStatus> xzzzzzzzzzzzzzzzzzj_ = LastEDOBTriage?.StatusElement;
                Encounter.EncounterStatus? xzzzzzzzzzzzzzzzzzk_ = xzzzzzzzzzzzzzzzzzj_?.Value;
                Code<Encounter.EncounterStatus> xzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(xzzzzzzzzzzzzzzzzzk_);
                bool? xzzzzzzzzzzzzzzzzzm_ = context.Operators.Equal(xzzzzzzzzzzzzzzzzzl_, "finished");
                bool? xzzzzzzzzzzzzzzzzzn_ = context.Operators.And(xzzzzzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzzzzzm_);

                return xzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzzo_);
            object uzzzzzzzzzzzzzzzzzq_(Encounter @this)
            {
                Period azzzzzzzzzzzzzzzzzzo_ = @this?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzo_);
                CqlDateTime azzzzzzzzzzzzzzzzzzq_ = context.Operators.End(azzzzzzzzzzzzzzzzzzp_);

                return azzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzr_ = context.Operators.SortBy<Encounter>(uzzzzzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter uzzzzzzzzzzzzzzzzzs_ = context.Operators.Last<Encounter>(uzzzzzzzzzzzzzzzzzr_);
            Period uzzzzzzzzzzzzzzzzzt_ = uzzzzzzzzzzzzzzzzzs_?.Period;
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzt_);
            CqlDateTime uzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzu_);
            CqlValueSet uzzzzzzzzzzzzzzzzzw_ = this.Observation_Services(context);
            IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? uzzzzzzzzzzzzzzzzzy_(Encounter LastObs)
            {
                Period azzzzzzzzzzzzzzzzzzr_ = LastObs?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzr_);
                CqlDateTime azzzzzzzzzzzzzzzzzzt_ = context.Operators.End(azzzzzzzzzzzzzzzzzzs_);
                Period azzzzzzzzzzzzzzzzzzu_ = Visit?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzu_);
                CqlDateTime azzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzv_);
                CqlQuantity azzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime azzzzzzzzzzzzzzzzzzy_ = context.Operators.Subtract(azzzzzzzzzzzzzzzzzzw_, azzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzu_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(azzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzb_, true, true);
                bool? bzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzzzzzc_, default);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzu_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzf_);
                bool? bzzzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzzzg_ is null));
                bool? bzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzzh_);
                Code<Encounter.EncounterStatus> bzzzzzzzzzzzzzzzzzzj_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? bzzzzzzzzzzzzzzzzzzk_ = bzzzzzzzzzzzzzzzzzzj_?.Value;
                Code<Encounter.EncounterStatus> bzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bzzzzzzzzzzzzzzzzzzk_);
                bool? bzzzzzzzzzzzzzzzzzzm_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzzl_, "finished");
                bool? bzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzzzzzm_);

                return bzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzzy_);
            object vzzzzzzzzzzzzzzzzza_(Encounter @this)
            {
                Period bzzzzzzzzzzzzzzzzzzo_ = @this?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzq_ = context.Operators.End(bzzzzzzzzzzzzzzzzzzp_);

                return bzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzb_ = context.Operators.SortBy<Encounter>(uzzzzzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzzzzza_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter vzzzzzzzzzzzzzzzzzc_ = context.Operators.Last<Encounter>(vzzzzzzzzzzzzzzzzzb_);
            Period vzzzzzzzzzzzzzzzzzd_ = vzzzzzzzzzzzzzzzzzc_?.Period;
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzd_);
            CqlDateTime vzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(vzzzzzzzzzzzzzzzzze_);
            Period vzzzzzzzzzzzzzzzzzg_ = Visit?.Period;
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzg_);
            CqlDateTime vzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzg_);
            CqlDateTime vzzzzzzzzzzzzzzzzzl_ = context.Operators.End(vzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(uzzzzzzzzzzzzzzzzzv_ ?? vzzzzzzzzzzzzzzzzzf_ ?? vzzzzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzzzzl_, true, true);

            return vzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> uzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)uzzzzzzzzzzzzzzzzzh_, uzzzzzzzzzzzzzzzzzi_);
        IEnumerable<CqlInterval<CqlDateTime>> uzzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(uzzzzzzzzzzzzzzzzzj_);
        CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzl_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(uzzzzzzzzzzzzzzzzzk_);

        return uzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Delivery Encounter with Age Range")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Age_Range(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzr_ = this.Encounter_with_Age_Range(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzs_(Encounter EncounterWithAge)
        {
            CqlValueSet bzzzzzzzzzzzzzzzzzzu_ = this.Delivery_Procedures(context);
            IEnumerable<Procedure> bzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? bzzzzzzzzzzzzzzzzzzw_(Procedure DeliveryProcedure)
            {
                Code<EventStatus> czzzzzzzzzzzzzzzzzza_ = DeliveryProcedure?.StatusElement;
                EventStatus? czzzzzzzzzzzzzzzzzzb_ = czzzzzzzzzzzzzzzzzza_?.Value;
                string czzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<string>(czzzzzzzzzzzzzzzzzzb_);
                bool? czzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(czzzzzzzzzzzzzzzzzzc_, "completed");
                DataType czzzzzzzzzzzzzzzzzze_ = DeliveryProcedure?.Performed;
                object czzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzf_);
                CqlDateTime czzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzi_ = this.hospitalizationWithEDOBTriageObservation(context, EncounterWithAge);
                bool? czzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzzzzzi_, default);
                bool? czzzzzzzzzzzzzzzzzzk_ = context.Operators.And(czzzzzzzzzzzzzzzzzzd_, czzzzzzzzzzzzzzzzzzj_);

                return czzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Procedure> bzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Procedure>(bzzzzzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzzzzzw_);
            Encounter bzzzzzzzzzzzzzzzzzzy_(Procedure DeliveryProcedure) =>
                EncounterWithAge;
            IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Procedure, Encounter>(bzzzzzzzzzzzzzzzzzzx_, bzzzzzzzzzzzzzzzzzzy_);

            return bzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzt_ = context.Operators.SelectMany<Encounter, Encounter>(bzzzzzzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzzzzzs_);

        return bzzzzzzzzzzzzzzzzzzt_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlDateTime lastTimeOfDelivery(CqlContext context, Encounter TheEncounter)
    {
        CqlCode czzzzzzzzzzzzzzzzzzl_ = this.Date_and_time_of_obstetric_delivery(context);
        IEnumerable<CqlCode> czzzzzzzzzzzzzzzzzzm_ = context.Operators.ToList<CqlCode>(czzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, czzzzzzzzzzzzzzzzzzm_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? czzzzzzzzzzzzzzzzzzo_(Observation TimeOfDelivery)
        {
            DataType czzzzzzzzzzzzzzzzzzv_ = TimeOfDelivery?.Value;
            object czzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzv_);
            bool? czzzzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)((czzzzzzzzzzzzzzzzzzw_ as CqlDateTime) is null));
            Code<ObservationStatus> czzzzzzzzzzzzzzzzzzy_ = TimeOfDelivery?.StatusElement;
            ObservationStatus? czzzzzzzzzzzzzzzzzzz_ = czzzzzzzzzzzzzzzzzzy_?.Value;
            Code<ObservationStatus> dzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<Code<ObservationStatus>>(czzzzzzzzzzzzzzzzzzz_);
            string dzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(dzzzzzzzzzzzzzzzzzza_);
            string[] dzzzzzzzzzzzzzzzzzzc_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? dzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<string>(dzzzzzzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzzzzzzc_ as IEnumerable<string>);
            bool? dzzzzzzzzzzzzzzzzzze_ = context.Operators.And(czzzzzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzzzzd_);
            object dzzzzzzzzzzzzzzzzzzf_()
            {
                bool dzzzzzzzzzzzzzzzzzzp_()
                {
                    DataType dzzzzzzzzzzzzzzzzzzs_ = TimeOfDelivery?.Effective;
                    object dzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzs_);
                    bool dzzzzzzzzzzzzzzzzzzu_ = dzzzzzzzzzzzzzzzzzzt_ is CqlDateTime;

                    return dzzzzzzzzzzzzzzzzzzu_;
                };
                bool dzzzzzzzzzzzzzzzzzzq_()
                {
                    DataType dzzzzzzzzzzzzzzzzzzv_ = TimeOfDelivery?.Effective;
                    object dzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzv_);
                    bool dzzzzzzzzzzzzzzzzzzx_ = dzzzzzzzzzzzzzzzzzzw_ is CqlInterval<CqlDateTime>;

                    return dzzzzzzzzzzzzzzzzzzx_;
                };
                bool dzzzzzzzzzzzzzzzzzzr_()
                {
                    DataType dzzzzzzzzzzzzzzzzzzy_ = TimeOfDelivery?.Effective;
                    object dzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzy_);
                    bool ezzzzzzzzzzzzzzzzzza_ = dzzzzzzzzzzzzzzzzzzz_ is CqlDateTime;

                    return ezzzzzzzzzzzzzzzzzza_;
                };
                if (dzzzzzzzzzzzzzzzzzzp_())
                {
                    DataType ezzzzzzzzzzzzzzzzzzb_ = TimeOfDelivery?.Effective;
                    object ezzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzb_);

                    return (ezzzzzzzzzzzzzzzzzzc_ as CqlDateTime) as object;
                }
                else if (dzzzzzzzzzzzzzzzzzzq_())
                {
                    DataType ezzzzzzzzzzzzzzzzzzd_ = TimeOfDelivery?.Effective;
                    object ezzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzd_);

                    return (ezzzzzzzzzzzzzzzzzze_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (dzzzzzzzzzzzzzzzzzzr_())
                {
                    DataType ezzzzzzzzzzzzzzzzzzf_ = TimeOfDelivery?.Effective;
                    object ezzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzf_);

                    return (ezzzzzzzzzzzzzzzzzzg_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime dzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzf_());
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzh_ = this.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
            bool? dzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzg_, dzzzzzzzzzzzzzzzzzzh_, default);
            bool? dzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(dzzzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzzzi_);
            object dzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzv_);
            bool? dzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzl_ as CqlDateTime, dzzzzzzzzzzzzzzzzzzh_, default);
            bool? dzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzj_, dzzzzzzzzzzzzzzzzzzn_);

            return dzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzzzzn_, czzzzzzzzzzzzzzzzzzo_);
        object czzzzzzzzzzzzzzzzzzq_(Observation @this)
        {
            object ezzzzzzzzzzzzzzzzzzh_()
            {
                bool ezzzzzzzzzzzzzzzzzzj_()
                {
                    DataType ezzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                    object ezzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzm_);
                    bool ezzzzzzzzzzzzzzzzzzo_ = ezzzzzzzzzzzzzzzzzzn_ is CqlDateTime;

                    return ezzzzzzzzzzzzzzzzzzo_;
                };
                bool ezzzzzzzzzzzzzzzzzzk_()
                {
                    DataType ezzzzzzzzzzzzzzzzzzp_ = @this?.Effective;
                    object ezzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzp_);
                    bool ezzzzzzzzzzzzzzzzzzr_ = ezzzzzzzzzzzzzzzzzzq_ is CqlInterval<CqlDateTime>;

                    return ezzzzzzzzzzzzzzzzzzr_;
                };
                bool ezzzzzzzzzzzzzzzzzzl_()
                {
                    DataType ezzzzzzzzzzzzzzzzzzs_ = @this?.Effective;
                    object ezzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzs_);
                    bool ezzzzzzzzzzzzzzzzzzu_ = ezzzzzzzzzzzzzzzzzzt_ is CqlDateTime;

                    return ezzzzzzzzzzzzzzzzzzu_;
                };
                if (ezzzzzzzzzzzzzzzzzzj_())
                {
                    DataType ezzzzzzzzzzzzzzzzzzv_ = @this?.Effective;
                    object ezzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzv_);

                    return (ezzzzzzzzzzzzzzzzzzw_ as CqlDateTime) as object;
                }
                else if (ezzzzzzzzzzzzzzzzzzk_())
                {
                    DataType ezzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                    object ezzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzx_);

                    return (ezzzzzzzzzzzzzzzzzzy_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ezzzzzzzzzzzzzzzzzzl_())
                {
                    DataType ezzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                    object fzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzz_);

                    return (fzzzzzzzzzzzzzzzzzza_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime ezzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzzh_());

            return ezzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzr_ = context.Operators.SortBy<Observation>(czzzzzzzzzzzzzzzzzzp_, czzzzzzzzzzzzzzzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
        Observation czzzzzzzzzzzzzzzzzzs_ = context.Operators.Last<Observation>(czzzzzzzzzzzzzzzzzzr_);
        DataType czzzzzzzzzzzzzzzzzzt_ = czzzzzzzzzzzzzzzzzzs_?.Value;
        object czzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzt_);

        return czzzzzzzzzzzzzzzzzzu_ as CqlDateTime;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlDateTime lastEstimatedDeliveryDate(CqlContext context, Encounter TheEncounter)
    {
        CqlCode fzzzzzzzzzzzzzzzzzzb_ = this.Delivery_date_Estimated(context);
        IEnumerable<CqlCode> fzzzzzzzzzzzzzzzzzzc_ = context.Operators.ToList<CqlCode>(fzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, fzzzzzzzzzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? fzzzzzzzzzzzzzzzzzze_(Observation EstimatedDateOfDelivery)
        {
            DataType fzzzzzzzzzzzzzzzzzzl_ = EstimatedDateOfDelivery?.Value;
            object fzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzl_);
            bool? fzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)((fzzzzzzzzzzzzzzzzzzm_ as CqlDateTime) is null));
            Code<ObservationStatus> fzzzzzzzzzzzzzzzzzzo_ = EstimatedDateOfDelivery?.StatusElement;
            ObservationStatus? fzzzzzzzzzzzzzzzzzzp_ = fzzzzzzzzzzzzzzzzzzo_?.Value;
            Code<ObservationStatus> fzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<Code<ObservationStatus>>(fzzzzzzzzzzzzzzzzzzp_);
            string fzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<string>(fzzzzzzzzzzzzzzzzzzq_);
            string[] fzzzzzzzzzzzzzzzzzzs_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? fzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<string>(fzzzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzzzs_ as IEnumerable<string>);
            bool? fzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzzzzzt_);
            object fzzzzzzzzzzzzzzzzzzv_()
            {
                bool gzzzzzzzzzzzzzzzzzzh_()
                {
                    DataType gzzzzzzzzzzzzzzzzzzk_ = EstimatedDateOfDelivery?.Effective;
                    object gzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzk_);
                    bool gzzzzzzzzzzzzzzzzzzm_ = gzzzzzzzzzzzzzzzzzzl_ is CqlDateTime;

                    return gzzzzzzzzzzzzzzzzzzm_;
                };
                bool gzzzzzzzzzzzzzzzzzzi_()
                {
                    DataType gzzzzzzzzzzzzzzzzzzn_ = EstimatedDateOfDelivery?.Effective;
                    object gzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzn_);
                    bool gzzzzzzzzzzzzzzzzzzp_ = gzzzzzzzzzzzzzzzzzzo_ is CqlInterval<CqlDateTime>;

                    return gzzzzzzzzzzzzzzzzzzp_;
                };
                bool gzzzzzzzzzzzzzzzzzzj_()
                {
                    DataType gzzzzzzzzzzzzzzzzzzq_ = EstimatedDateOfDelivery?.Effective;
                    object gzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzq_);
                    bool gzzzzzzzzzzzzzzzzzzs_ = gzzzzzzzzzzzzzzzzzzr_ is CqlDateTime;

                    return gzzzzzzzzzzzzzzzzzzs_;
                };
                if (gzzzzzzzzzzzzzzzzzzh_())
                {
                    DataType gzzzzzzzzzzzzzzzzzzt_ = EstimatedDateOfDelivery?.Effective;
                    object gzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzt_);

                    return (gzzzzzzzzzzzzzzzzzzu_ as CqlDateTime) as object;
                }
                else if (gzzzzzzzzzzzzzzzzzzi_())
                {
                    DataType gzzzzzzzzzzzzzzzzzzv_ = EstimatedDateOfDelivery?.Effective;
                    object gzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzv_);

                    return (gzzzzzzzzzzzzzzzzzzw_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (gzzzzzzzzzzzzzzzzzzj_())
                {
                    DataType gzzzzzzzzzzzzzzzzzzx_ = EstimatedDateOfDelivery?.Effective;
                    object gzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzx_);

                    return (gzzzzzzzzzzzzzzzzzzy_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime fzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzzzv_());
            CqlDateTime fzzzzzzzzzzzzzzzzzzx_ = this.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity fzzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime fzzzzzzzzzzzzzzzzzzz_ = context.Operators.Subtract(fzzzzzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzzzzx_, true, true);
            bool? gzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzzzzzzb_, default);
            bool? gzzzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzzzzzx_ is null));
            bool? gzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzc_, gzzzzzzzzzzzzzzzzzze_);
            bool? gzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzu_, gzzzzzzzzzzzzzzzzzzf_);

            return gzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(fzzzzzzzzzzzzzzzzzzd_, fzzzzzzzzzzzzzzzzzze_);
        object fzzzzzzzzzzzzzzzzzzg_(Observation @this)
        {
            object gzzzzzzzzzzzzzzzzzzz_()
            {
                bool hzzzzzzzzzzzzzzzzzzb_()
                {
                    DataType hzzzzzzzzzzzzzzzzzze_ = @this?.Effective;
                    object hzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzze_);
                    bool hzzzzzzzzzzzzzzzzzzg_ = hzzzzzzzzzzzzzzzzzzf_ is CqlDateTime;

                    return hzzzzzzzzzzzzzzzzzzg_;
                };
                bool hzzzzzzzzzzzzzzzzzzc_()
                {
                    DataType hzzzzzzzzzzzzzzzzzzh_ = @this?.Effective;
                    object hzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzh_);
                    bool hzzzzzzzzzzzzzzzzzzj_ = hzzzzzzzzzzzzzzzzzzi_ is CqlInterval<CqlDateTime>;

                    return hzzzzzzzzzzzzzzzzzzj_;
                };
                bool hzzzzzzzzzzzzzzzzzzd_()
                {
                    DataType hzzzzzzzzzzzzzzzzzzk_ = @this?.Effective;
                    object hzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzk_);
                    bool hzzzzzzzzzzzzzzzzzzm_ = hzzzzzzzzzzzzzzzzzzl_ is CqlDateTime;

                    return hzzzzzzzzzzzzzzzzzzm_;
                };
                if (hzzzzzzzzzzzzzzzzzzb_())
                {
                    DataType hzzzzzzzzzzzzzzzzzzn_ = @this?.Effective;
                    object hzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzn_);

                    return (hzzzzzzzzzzzzzzzzzzo_ as CqlDateTime) as object;
                }
                else if (hzzzzzzzzzzzzzzzzzzc_())
                {
                    DataType hzzzzzzzzzzzzzzzzzzp_ = @this?.Effective;
                    object hzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzp_);

                    return (hzzzzzzzzzzzzzzzzzzq_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (hzzzzzzzzzzzzzzzzzzd_())
                {
                    DataType hzzzzzzzzzzzzzzzzzzr_ = @this?.Effective;
                    object hzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzr_);

                    return (hzzzzzzzzzzzzzzzzzzs_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime hzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzz_());

            return hzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzh_ = context.Operators.SortBy<Observation>(fzzzzzzzzzzzzzzzzzzf_, fzzzzzzzzzzzzzzzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
        Observation fzzzzzzzzzzzzzzzzzzi_ = context.Operators.Last<Observation>(fzzzzzzzzzzzzzzzzzzh_);
        DataType fzzzzzzzzzzzzzzzzzzj_ = fzzzzzzzzzzzzzzzzzzi_?.Value;
        object fzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzj_);

        return fzzzzzzzzzzzzzzzzzzk_ as CqlDateTime;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public int? calculatedGestationalAge(CqlContext context, Encounter TheEncounter)
    {
        CqlDateTime hzzzzzzzzzzzzzzzzzzt_ = this.lastTimeOfDelivery(context, TheEncounter);
        CqlDateTime hzzzzzzzzzzzzzzzzzzu_ = this.lastEstimatedDeliveryDate(context, TheEncounter);
        int? hzzzzzzzzzzzzzzzzzzv_ = context.Operators.DifferenceBetween(hzzzzzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzzzzzu_, "day");
        int? hzzzzzzzzzzzzzzzzzzw_ = context.Operators.Subtract(280, hzzzzzzzzzzzzzzzzzzv_);
        int? hzzzzzzzzzzzzzzzzzzx_ = context.Operators.TruncatedDivide(hzzzzzzzzzzzzzzzzzzw_, 7);

        return hzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Variable Calculated Gestational Age")]
    public IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> Variable_Calculated_Gestational_Age(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzy_ = this.Delivery_Encounter_with_Age_Range(context);
        (CqlTupleMetadata, string EncounterID, int? CalculatedCGA)? hzzzzzzzzzzzzzzzzzzz_(Encounter DeliveryEncounter)
        {
            Id izzzzzzzzzzzzzzzzzzc_ = DeliveryEncounter?.IdElement;
            string izzzzzzzzzzzzzzzzzzd_ = izzzzzzzzzzzzzzzzzzc_?.Value;
            int? izzzzzzzzzzzzzzzzzze_ = this.calculatedGestationalAge(context, DeliveryEncounter);
            (CqlTupleMetadata, string EncounterID, int? CalculatedCGA)? izzzzzzzzzzzzzzzzzzf_ = (CqlTupleMetadata_DjNbNOhJZXGJDNQeiTBabEOBB, izzzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzzze_);

            return izzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> izzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?>(hzzzzzzzzzzzzzzzzzzy_, hzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> izzzzzzzzzzzzzzzzzzb_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?>(izzzzzzzzzzzzzzzzzza_);

        return izzzzzzzzzzzzzzzzzzb_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlQuantity lastEstimatedGestationalAge(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet izzzzzzzzzzzzzzzzzzg_ = this.Estimated_Gestational_Age_at_Delivery(context);
        IEnumerable<Observation> izzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? izzzzzzzzzzzzzzzzzzi_(Observation EstimatedGestationalAge)
        {
            object izzzzzzzzzzzzzzzzzzp_()
            {
                bool jzzzzzzzzzzzzzzzzzzz_()
                {
                    DataType kzzzzzzzzzzzzzzzzzzc_ = EstimatedGestationalAge?.Effective;
                    object kzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzc_);
                    bool kzzzzzzzzzzzzzzzzzze_ = kzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                    return kzzzzzzzzzzzzzzzzzze_;
                };
                bool kzzzzzzzzzzzzzzzzzza_()
                {
                    DataType kzzzzzzzzzzzzzzzzzzf_ = EstimatedGestationalAge?.Effective;
                    object kzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzf_);
                    bool kzzzzzzzzzzzzzzzzzzh_ = kzzzzzzzzzzzzzzzzzzg_ is CqlInterval<CqlDateTime>;

                    return kzzzzzzzzzzzzzzzzzzh_;
                };
                bool kzzzzzzzzzzzzzzzzzzb_()
                {
                    DataType kzzzzzzzzzzzzzzzzzzi_ = EstimatedGestationalAge?.Effective;
                    object kzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzi_);
                    bool kzzzzzzzzzzzzzzzzzzk_ = kzzzzzzzzzzzzzzzzzzj_ is CqlDateTime;

                    return kzzzzzzzzzzzzzzzzzzk_;
                };
                if (jzzzzzzzzzzzzzzzzzzz_())
                {
                    DataType kzzzzzzzzzzzzzzzzzzl_ = EstimatedGestationalAge?.Effective;
                    object kzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzl_);

                    return (kzzzzzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                }
                else if (kzzzzzzzzzzzzzzzzzza_())
                {
                    DataType kzzzzzzzzzzzzzzzzzzn_ = EstimatedGestationalAge?.Effective;
                    object kzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzn_);

                    return (kzzzzzzzzzzzzzzzzzzo_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (kzzzzzzzzzzzzzzzzzzb_())
                {
                    DataType kzzzzzzzzzzzzzzzzzzp_ = EstimatedGestationalAge?.Effective;
                    object kzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzp_);

                    return (kzzzzzzzzzzzzzzzzzzq_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime izzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzzzp_());
            CqlDateTime izzzzzzzzzzzzzzzzzzr_ = this.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity izzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(24m, "hours");
            CqlDateTime izzzzzzzzzzzzzzzzzzt_ = context.Operators.Subtract(izzzzzzzzzzzzzzzzzzr_, izzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(izzzzzzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzzzzzr_, true, true);
            bool? izzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzq_, izzzzzzzzzzzzzzzzzzv_, default);
            bool? izzzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzzzzr_ is null));
            bool? izzzzzzzzzzzzzzzzzzz_ = context.Operators.And(izzzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzzzy_);
            DataType jzzzzzzzzzzzzzzzzzza_ = EstimatedGestationalAge?.Value;
            object jzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzza_);
            bool? jzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzzzb_ is null));
            bool? jzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(izzzzzzzzzzzzzzzzzzz_, jzzzzzzzzzzzzzzzzzzc_);
            Code<ObservationStatus> jzzzzzzzzzzzzzzzzzze_ = EstimatedGestationalAge?.StatusElement;
            ObservationStatus? jzzzzzzzzzzzzzzzzzzf_ = jzzzzzzzzzzzzzzzzzze_?.Value;
            Code<ObservationStatus> jzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<Code<ObservationStatus>>(jzzzzzzzzzzzzzzzzzzf_);
            string jzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzzzzzg_);
            string[] jzzzzzzzzzzzzzzzzzzi_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? jzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<string>(jzzzzzzzzzzzzzzzzzzh_, jzzzzzzzzzzzzzzzzzzi_ as IEnumerable<string>);
            bool? jzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzzzzzzj_);
            object jzzzzzzzzzzzzzzzzzzl_()
            {
                bool kzzzzzzzzzzzzzzzzzzr_()
                {
                    DataType kzzzzzzzzzzzzzzzzzzu_ = EstimatedGestationalAge?.Effective;
                    object kzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzu_);
                    bool kzzzzzzzzzzzzzzzzzzw_ = kzzzzzzzzzzzzzzzzzzv_ is CqlDateTime;

                    return kzzzzzzzzzzzzzzzzzzw_;
                };
                bool kzzzzzzzzzzzzzzzzzzs_()
                {
                    DataType kzzzzzzzzzzzzzzzzzzx_ = EstimatedGestationalAge?.Effective;
                    object kzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzx_);
                    bool kzzzzzzzzzzzzzzzzzzz_ = kzzzzzzzzzzzzzzzzzzy_ is CqlInterval<CqlDateTime>;

                    return kzzzzzzzzzzzzzzzzzzz_;
                };
                bool kzzzzzzzzzzzzzzzzzzt_()
                {
                    DataType lzzzzzzzzzzzzzzzzzza_ = EstimatedGestationalAge?.Effective;
                    object lzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzza_);
                    bool lzzzzzzzzzzzzzzzzzzc_ = lzzzzzzzzzzzzzzzzzzb_ is CqlDateTime;

                    return lzzzzzzzzzzzzzzzzzzc_;
                };
                if (kzzzzzzzzzzzzzzzzzzr_())
                {
                    DataType lzzzzzzzzzzzzzzzzzzd_ = EstimatedGestationalAge?.Effective;
                    object lzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzd_);

                    return (lzzzzzzzzzzzzzzzzzze_ as CqlDateTime) as object;
                }
                else if (kzzzzzzzzzzzzzzzzzzs_())
                {
                    DataType lzzzzzzzzzzzzzzzzzzf_ = EstimatedGestationalAge?.Effective;
                    object lzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzf_);

                    return (lzzzzzzzzzzzzzzzzzzg_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (kzzzzzzzzzzzzzzzzzzt_())
                {
                    DataType lzzzzzzzzzzzzzzzzzzh_ = EstimatedGestationalAge?.Effective;
                    object lzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzh_);

                    return (lzzzzzzzzzzzzzzzzzzi_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime jzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzzzzzzzzzzzzzzzl_());
            bool? jzzzzzzzzzzzzzzzzzzo_ = context.Operators.SameAs(jzzzzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzzzr_, "day");
            object jzzzzzzzzzzzzzzzzzzp_()
            {
                bool lzzzzzzzzzzzzzzzzzzj_()
                {
                    DataType lzzzzzzzzzzzzzzzzzzm_ = EstimatedGestationalAge?.Effective;
                    object lzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzm_);
                    bool lzzzzzzzzzzzzzzzzzzo_ = lzzzzzzzzzzzzzzzzzzn_ is CqlDateTime;

                    return lzzzzzzzzzzzzzzzzzzo_;
                };
                bool lzzzzzzzzzzzzzzzzzzk_()
                {
                    DataType lzzzzzzzzzzzzzzzzzzp_ = EstimatedGestationalAge?.Effective;
                    object lzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzp_);
                    bool lzzzzzzzzzzzzzzzzzzr_ = lzzzzzzzzzzzzzzzzzzq_ is CqlInterval<CqlDateTime>;

                    return lzzzzzzzzzzzzzzzzzzr_;
                };
                bool lzzzzzzzzzzzzzzzzzzl_()
                {
                    DataType lzzzzzzzzzzzzzzzzzzs_ = EstimatedGestationalAge?.Effective;
                    object lzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzs_);
                    bool lzzzzzzzzzzzzzzzzzzu_ = lzzzzzzzzzzzzzzzzzzt_ is CqlDateTime;

                    return lzzzzzzzzzzzzzzzzzzu_;
                };
                if (lzzzzzzzzzzzzzzzzzzj_())
                {
                    DataType lzzzzzzzzzzzzzzzzzzv_ = EstimatedGestationalAge?.Effective;
                    object lzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzv_);

                    return (lzzzzzzzzzzzzzzzzzzw_ as CqlDateTime) as object;
                }
                else if (lzzzzzzzzzzzzzzzzzzk_())
                {
                    DataType lzzzzzzzzzzzzzzzzzzx_ = EstimatedGestationalAge?.Effective;
                    object lzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzx_);

                    return (lzzzzzzzzzzzzzzzzzzy_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (lzzzzzzzzzzzzzzzzzzl_())
                {
                    DataType lzzzzzzzzzzzzzzzzzzz_ = EstimatedGestationalAge?.Effective;
                    object mzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzz_);

                    return (mzzzzzzzzzzzzzzzzzza_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime jzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzzzzzzzzzzzzzzzp_());
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzr_ = this.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
            bool? jzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzzq_, jzzzzzzzzzzzzzzzzzzr_, default);
            bool? jzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzo_, jzzzzzzzzzzzzzzzzzzs_);
            object jzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzza_);
            bool? jzzzzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzzzv_ is null));
            bool? jzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzzzzw_);
            bool? jzzzzzzzzzzzzzzzzzzy_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzzzzzzx_);

            return jzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Observation> izzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(izzzzzzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzzzzzi_);
        object izzzzzzzzzzzzzzzzzzk_(Observation @this)
        {
            object mzzzzzzzzzzzzzzzzzzb_()
            {
                bool mzzzzzzzzzzzzzzzzzzd_()
                {
                    DataType mzzzzzzzzzzzzzzzzzzg_ = @this?.Effective;
                    object mzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzg_);
                    bool mzzzzzzzzzzzzzzzzzzi_ = mzzzzzzzzzzzzzzzzzzh_ is CqlDateTime;

                    return mzzzzzzzzzzzzzzzzzzi_;
                };
                bool mzzzzzzzzzzzzzzzzzze_()
                {
                    DataType mzzzzzzzzzzzzzzzzzzj_ = @this?.Effective;
                    object mzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzj_);
                    bool mzzzzzzzzzzzzzzzzzzl_ = mzzzzzzzzzzzzzzzzzzk_ is CqlInterval<CqlDateTime>;

                    return mzzzzzzzzzzzzzzzzzzl_;
                };
                bool mzzzzzzzzzzzzzzzzzzf_()
                {
                    DataType mzzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                    object mzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzm_);
                    bool mzzzzzzzzzzzzzzzzzzo_ = mzzzzzzzzzzzzzzzzzzn_ is CqlDateTime;

                    return mzzzzzzzzzzzzzzzzzzo_;
                };
                if (mzzzzzzzzzzzzzzzzzzd_())
                {
                    DataType mzzzzzzzzzzzzzzzzzzp_ = @this?.Effective;
                    object mzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzp_);

                    return (mzzzzzzzzzzzzzzzzzzq_ as CqlDateTime) as object;
                }
                else if (mzzzzzzzzzzzzzzzzzze_())
                {
                    DataType mzzzzzzzzzzzzzzzzzzr_ = @this?.Effective;
                    object mzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzr_);

                    return (mzzzzzzzzzzzzzzzzzzs_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (mzzzzzzzzzzzzzzzzzzf_())
                {
                    DataType mzzzzzzzzzzzzzzzzzzt_ = @this?.Effective;
                    object mzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzt_);

                    return (mzzzzzzzzzzzzzzzzzzu_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime mzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzzb_());

            return mzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Observation> izzzzzzzzzzzzzzzzzzl_ = context.Operators.SortBy<Observation>(izzzzzzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
        Observation izzzzzzzzzzzzzzzzzzm_ = context.Operators.Last<Observation>(izzzzzzzzzzzzzzzzzzl_);
        DataType izzzzzzzzzzzzzzzzzzn_ = izzzzzzzzzzzzzzzzzzm_?.Value;
        object izzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzn_);

        return izzzzzzzzzzzzzzzzzzo_ as CqlQuantity;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_DjNbNOhJZXGJDNQeiTBabEOBB = new(
        [typeof(string), typeof(int?)],
        ["EncounterID", "CalculatedCGA"]);

    #endregion CqlTupleMetadata Properties

}
