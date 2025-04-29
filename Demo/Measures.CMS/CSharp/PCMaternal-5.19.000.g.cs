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

    [CqlValueSetDefinition("Delivery Procedures", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.59", valueSetVersion: null)]
    public CqlValueSet Delivery_Procedures(CqlContext _) => _Delivery_Procedures;
    private static readonly CqlValueSet _Delivery_Procedures = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.59", null);

    [CqlValueSetDefinition("ED Visit and OB Triage", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.369", valueSetVersion: null)]
    public CqlValueSet ED_Visit_and_OB_Triage(CqlContext _) => _ED_Visit_and_OB_Triage;
    private static readonly CqlValueSet _ED_Visit_and_OB_Triage = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.369", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Estimated Gestational Age at Delivery", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.26", valueSetVersion: null)]
    public CqlValueSet Estimated_Gestational_Age_at_Delivery(CqlContext _) => _Estimated_Gestational_Age_at_Delivery;
    private static readonly CqlValueSet _Estimated_Gestational_Age_at_Delivery = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.26", null);

    [CqlValueSetDefinition("Observation Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", valueSetVersion: null)]
    public CqlValueSet Observation_Services(CqlContext _) => _Observation_Services;
    private static readonly CqlValueSet _Observation_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Date and time of obstetric delivery", codeId: "93857-1", codeSystem: "http://loinc.org")]
    public CqlCode Date_and_time_of_obstetric_delivery(CqlContext _) => _Date_and_time_of_obstetric_delivery;
    private static readonly CqlCode _Date_and_time_of_obstetric_delivery = new CqlCode("93857-1", "http://loinc.org", default, default);

    [CqlCodeDefinition("Delivery date Estimated", codeId: "11778-8", codeSystem: "http://loinc.org")]
    public CqlCode Delivery_date_Estimated(CqlContext _) => _Delivery_date_Estimated;
    private static readonly CqlCode _Delivery_date_Estimated = new CqlCode("11778-8", "http://loinc.org", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime mzzzzzzzzzzzzzzzzze_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime mzzzzzzzzzzzzzzzzzf_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzzzf_, true, true);
        object mzzzzzzzzzzzzzzzzzh_ = context.ResolveParameter("PCMaternal-5.19.000", "Measurement Period", mzzzzzzzzzzzzzzzzzg_);

        return (CqlInterval<CqlDateTime>)mzzzzzzzzzzzzzzzzzh_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> mzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient mzzzzzzzzzzzzzzzzzj_ = context.Operators.SingletonFrom<Patient>(mzzzzzzzzzzzzzzzzzi_);

        return mzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Encounter with Age Range")]
    public IEnumerable<Encounter> Encounter_with_Age_Range(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzk_ = CQMCommon_2_2_000.Instance.Inpatient_Encounter(context);
        bool? mzzzzzzzzzzzzzzzzzl_(Encounter InpatientEncounter)
        {
            Patient mzzzzzzzzzzzzzzzzzn_ = this.Patient(context);
            Date mzzzzzzzzzzzzzzzzzo_ = mzzzzzzzzzzzzzzzzzn_?.BirthDateElement;
            string mzzzzzzzzzzzzzzzzzp_ = mzzzzzzzzzzzzzzzzzo_?.Value;
            CqlDate mzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertStringToDate(mzzzzzzzzzzzzzzzzzp_);
            Period mzzzzzzzzzzzzzzzzzr_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzr_);
            CqlDateTime mzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzs_);
            CqlDate mzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzt_);
            int? mzzzzzzzzzzzzzzzzzv_ = context.Operators.CalculateAgeAt(mzzzzzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzzzzzu_, "year");
            CqlInterval<int?> mzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(8, 65, true, false);
            bool? mzzzzzzzzzzzzzzzzzx_ = context.Operators.In<int?>(mzzzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzzzw_, default);

            return mzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzzzzzzzk_, mzzzzzzzzzzzzzzzzzl_);

        return mzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("hospitalizationWithEDOBTriageObservation")]
    public CqlInterval<CqlDateTime> hospitalizationWithEDOBTriageObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] mzzzzzzzzzzzzzzzzzy_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzz_(Encounter Visit)
        {
            CqlValueSet nzzzzzzzzzzzzzzzzzd_ = this.ED_Visit_and_OB_Triage(context);
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? nzzzzzzzzzzzzzzzzzf_(Encounter LastEDOBTriage)
            {
                Period ozzzzzzzzzzzzzzzzze_ = LastEDOBTriage?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzze_);
                CqlDateTime ozzzzzzzzzzzzzzzzzg_ = context.Operators.End(ozzzzzzzzzzzzzzzzzf_);
                CqlValueSet ozzzzzzzzzzzzzzzzzh_ = this.Observation_Services(context);
                IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? ozzzzzzzzzzzzzzzzzj_(Encounter LastObs)
                {
                    Period qzzzzzzzzzzzzzzzzzf_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzf_);
                    CqlDateTime qzzzzzzzzzzzzzzzzzh_ = context.Operators.End(qzzzzzzzzzzzzzzzzzg_);
                    Period qzzzzzzzzzzzzzzzzzi_ = Visit?.Period;
                    CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzi_);
                    CqlDateTime qzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzj_);
                    CqlQuantity qzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime qzzzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(qzzzzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzzzzl_);
                    CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzi_);
                    CqlDateTime qzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzo_);
                    CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(qzzzzzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzzzzzp_, true, true);
                    bool? qzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzh_, qzzzzzzzzzzzzzzzzzq_, default);
                    CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzi_);
                    CqlDateTime qzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzt_);
                    bool? qzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzzzu_ is null));
                    bool? qzzzzzzzzzzzzzzzzzw_ = context.Operators.And(qzzzzzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzzzzzv_);
                    Code<Encounter.EncounterStatus> qzzzzzzzzzzzzzzzzzx_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? qzzzzzzzzzzzzzzzzzy_ = qzzzzzzzzzzzzzzzzzx_?.Value;
                    Code<Encounter.EncounterStatus> qzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(qzzzzzzzzzzzzzzzzzy_);
                    bool? rzzzzzzzzzzzzzzzzza_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzz_, "finished");
                    bool? rzzzzzzzzzzzzzzzzzb_ = context.Operators.And(qzzzzzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzzzzza_);

                    return rzzzzzzzzzzzzzzzzzb_;
                };
                IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzzzi_, ozzzzzzzzzzzzzzzzzj_);
                object ozzzzzzzzzzzzzzzzzl_(Encounter @this)
                {
                    Period rzzzzzzzzzzzzzzzzzc_ = @this?.Period;
                    CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzc_);
                    CqlDateTime rzzzzzzzzzzzzzzzzze_ = context.Operators.End(rzzzzzzzzzzzzzzzzzd_);

                    return rzzzzzzzzzzzzzzzzze_;
                };
                IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzm_ = context.Operators.SortBy<Encounter>(ozzzzzzzzzzzzzzzzzk_, ozzzzzzzzzzzzzzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter ozzzzzzzzzzzzzzzzzn_ = context.Operators.Last<Encounter>(ozzzzzzzzzzzzzzzzzm_);
                Period ozzzzzzzzzzzzzzzzzo_ = ozzzzzzzzzzzzzzzzzn_?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzo_);
                CqlDateTime ozzzzzzzzzzzzzzzzzq_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzp_);
                Period ozzzzzzzzzzzzzzzzzr_ = Visit?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzr_);
                CqlDateTime ozzzzzzzzzzzzzzzzzt_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzs_);
                CqlQuantity ozzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime ozzzzzzzzzzzzzzzzzv_ = context.Operators.Subtract(ozzzzzzzzzzzzzzzzzq_ ?? ozzzzzzzzzzzzzzzzzt_, ozzzzzzzzzzzzzzzzzu_);
                IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? ozzzzzzzzzzzzzzzzzy_(Encounter LastObs)
                {
                    Period rzzzzzzzzzzzzzzzzzf_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzf_);
                    CqlDateTime rzzzzzzzzzzzzzzzzzh_ = context.Operators.End(rzzzzzzzzzzzzzzzzzg_);
                    Period rzzzzzzzzzzzzzzzzzi_ = Visit?.Period;
                    CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzi_);
                    CqlDateTime rzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzj_);
                    CqlQuantity rzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime rzzzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(rzzzzzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzzzzzl_);
                    CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzi_);
                    CqlDateTime rzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzo_);
                    CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzzm_, rzzzzzzzzzzzzzzzzzp_, true, true);
                    bool? rzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzzzzzq_, default);
                    CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzi_);
                    CqlDateTime rzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzt_);
                    bool? rzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzzzzzu_ is null));
                    bool? rzzzzzzzzzzzzzzzzzw_ = context.Operators.And(rzzzzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzzzzv_);
                    Code<Encounter.EncounterStatus> rzzzzzzzzzzzzzzzzzx_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? rzzzzzzzzzzzzzzzzzy_ = rzzzzzzzzzzzzzzzzzx_?.Value;
                    Code<Encounter.EncounterStatus> rzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rzzzzzzzzzzzzzzzzzy_);
                    bool? szzzzzzzzzzzzzzzzza_ = context.Operators.Equal(rzzzzzzzzzzzzzzzzzz_, "finished");
                    bool? szzzzzzzzzzzzzzzzzb_ = context.Operators.And(rzzzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzzza_);

                    return szzzzzzzzzzzzzzzzzb_;
                };
                IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzzzx_, ozzzzzzzzzzzzzzzzzy_);
                object pzzzzzzzzzzzzzzzzza_(Encounter @this)
                {
                    Period szzzzzzzzzzzzzzzzzc_ = @this?.Period;
                    CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzc_);
                    CqlDateTime szzzzzzzzzzzzzzzzze_ = context.Operators.End(szzzzzzzzzzzzzzzzzd_);

                    return szzzzzzzzzzzzzzzzze_;
                };
                IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzb_ = context.Operators.SortBy<Encounter>(ozzzzzzzzzzzzzzzzzz_, pzzzzzzzzzzzzzzzzza_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter pzzzzzzzzzzzzzzzzzc_ = context.Operators.Last<Encounter>(pzzzzzzzzzzzzzzzzzb_);
                Period pzzzzzzzzzzzzzzzzzd_ = pzzzzzzzzzzzzzzzzzc_?.Period;
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzd_);
                CqlDateTime pzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(pzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzr_);
                CqlDateTime pzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzv_, pzzzzzzzzzzzzzzzzzf_ ?? pzzzzzzzzzzzzzzzzzi_, true, true);
                bool? pzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzzg_, pzzzzzzzzzzzzzzzzzj_, default);
                IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? pzzzzzzzzzzzzzzzzzn_(Encounter LastObs)
                {
                    Period szzzzzzzzzzzzzzzzzf_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzf_);
                    CqlDateTime szzzzzzzzzzzzzzzzzh_ = context.Operators.End(szzzzzzzzzzzzzzzzzg_);
                    Period szzzzzzzzzzzzzzzzzi_ = Visit?.Period;
                    CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzi_);
                    CqlDateTime szzzzzzzzzzzzzzzzzk_ = context.Operators.Start(szzzzzzzzzzzzzzzzzj_);
                    CqlQuantity szzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime szzzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(szzzzzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzzzzl_);
                    CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzi_);
                    CqlDateTime szzzzzzzzzzzzzzzzzp_ = context.Operators.Start(szzzzzzzzzzzzzzzzzo_);
                    CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(szzzzzzzzzzzzzzzzzm_, szzzzzzzzzzzzzzzzzp_, true, true);
                    bool? szzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzzzzq_, default);
                    CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzi_);
                    CqlDateTime szzzzzzzzzzzzzzzzzu_ = context.Operators.Start(szzzzzzzzzzzzzzzzzt_);
                    bool? szzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzzu_ is null));
                    bool? szzzzzzzzzzzzzzzzzw_ = context.Operators.And(szzzzzzzzzzzzzzzzzr_, szzzzzzzzzzzzzzzzzv_);
                    Code<Encounter.EncounterStatus> szzzzzzzzzzzzzzzzzx_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? szzzzzzzzzzzzzzzzzy_ = szzzzzzzzzzzzzzzzzx_?.Value;
                    Code<Encounter.EncounterStatus> szzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(szzzzzzzzzzzzzzzzzy_);
                    bool? tzzzzzzzzzzzzzzzzza_ = context.Operators.Equal(szzzzzzzzzzzzzzzzzz_, "finished");
                    bool? tzzzzzzzzzzzzzzzzzb_ = context.Operators.And(szzzzzzzzzzzzzzzzzw_, tzzzzzzzzzzzzzzzzza_);

                    return tzzzzzzzzzzzzzzzzzb_;
                };
                IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzn_);
                object pzzzzzzzzzzzzzzzzzp_(Encounter @this)
                {
                    Period tzzzzzzzzzzzzzzzzzc_ = @this?.Period;
                    CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzc_);
                    CqlDateTime tzzzzzzzzzzzzzzzzze_ = context.Operators.End(tzzzzzzzzzzzzzzzzzd_);

                    return tzzzzzzzzzzzzzzzzze_;
                };
                IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzq_ = context.Operators.SortBy<Encounter>(pzzzzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter pzzzzzzzzzzzzzzzzzr_ = context.Operators.Last<Encounter>(pzzzzzzzzzzzzzzzzzq_);
                Period pzzzzzzzzzzzzzzzzzs_ = pzzzzzzzzzzzzzzzzzr_?.Period;
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzs_);
                CqlDateTime pzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzr_);
                CqlDateTime pzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzw_);
                bool? pzzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)((pzzzzzzzzzzzzzzzzzu_ ?? pzzzzzzzzzzzzzzzzzx_) is null));
                bool? pzzzzzzzzzzzzzzzzzz_ = context.Operators.And(pzzzzzzzzzzzzzzzzzk_, pzzzzzzzzzzzzzzzzzy_);
                Code<Encounter.EncounterStatus> qzzzzzzzzzzzzzzzzza_ = LastEDOBTriage?.StatusElement;
                Encounter.EncounterStatus? qzzzzzzzzzzzzzzzzzb_ = qzzzzzzzzzzzzzzzzza_?.Value;
                Code<Encounter.EncounterStatus> qzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(qzzzzzzzzzzzzzzzzzb_);
                bool? qzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzc_, "finished");
                bool? qzzzzzzzzzzzzzzzzze_ = context.Operators.And(pzzzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzzzzd_);

                return qzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzze_, nzzzzzzzzzzzzzzzzzf_);
            object nzzzzzzzzzzzzzzzzzh_(Encounter @this)
            {
                Period tzzzzzzzzzzzzzzzzzf_ = @this?.Period;
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzf_);
                CqlDateTime tzzzzzzzzzzzzzzzzzh_ = context.Operators.End(tzzzzzzzzzzzzzzzzzg_);

                return tzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzi_ = context.Operators.SortBy<Encounter>(nzzzzzzzzzzzzzzzzzg_, nzzzzzzzzzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter nzzzzzzzzzzzzzzzzzj_ = context.Operators.Last<Encounter>(nzzzzzzzzzzzzzzzzzi_);
            Period nzzzzzzzzzzzzzzzzzk_ = nzzzzzzzzzzzzzzzzzj_?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzk_);
            CqlDateTime nzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzl_);
            CqlValueSet nzzzzzzzzzzzzzzzzzn_ = this.Observation_Services(context);
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? nzzzzzzzzzzzzzzzzzp_(Encounter LastObs)
            {
                Period tzzzzzzzzzzzzzzzzzi_ = LastObs?.Period;
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzi_);
                CqlDateTime tzzzzzzzzzzzzzzzzzk_ = context.Operators.End(tzzzzzzzzzzzzzzzzzj_);
                Period tzzzzzzzzzzzzzzzzzl_ = Visit?.Period;
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzl_);
                CqlDateTime tzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzm_);
                CqlQuantity tzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime tzzzzzzzzzzzzzzzzzp_ = context.Operators.Subtract(tzzzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzl_);
                CqlDateTime tzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(tzzzzzzzzzzzzzzzzzp_, tzzzzzzzzzzzzzzzzzs_, true, true);
                bool? tzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzzk_, tzzzzzzzzzzzzzzzzzt_, default);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzl_);
                CqlDateTime tzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzw_);
                bool? tzzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzx_ is null));
                bool? tzzzzzzzzzzzzzzzzzz_ = context.Operators.And(tzzzzzzzzzzzzzzzzzu_, tzzzzzzzzzzzzzzzzzy_);
                Code<Encounter.EncounterStatus> uzzzzzzzzzzzzzzzzza_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? uzzzzzzzzzzzzzzzzzb_ = uzzzzzzzzzzzzzzzzza_?.Value;
                Code<Encounter.EncounterStatus> uzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(uzzzzzzzzzzzzzzzzzb_);
                bool? uzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(uzzzzzzzzzzzzzzzzzc_, "finished");
                bool? uzzzzzzzzzzzzzzzzze_ = context.Operators.And(tzzzzzzzzzzzzzzzzzz_, uzzzzzzzzzzzzzzzzzd_);

                return uzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzzo_, nzzzzzzzzzzzzzzzzzp_);
            object nzzzzzzzzzzzzzzzzzr_(Encounter @this)
            {
                Period uzzzzzzzzzzzzzzzzzf_ = @this?.Period;
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzf_);
                CqlDateTime uzzzzzzzzzzzzzzzzzh_ = context.Operators.End(uzzzzzzzzzzzzzzzzzg_);

                return uzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzs_ = context.Operators.SortBy<Encounter>(nzzzzzzzzzzzzzzzzzq_, nzzzzzzzzzzzzzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter nzzzzzzzzzzzzzzzzzt_ = context.Operators.Last<Encounter>(nzzzzzzzzzzzzzzzzzs_);
            Period nzzzzzzzzzzzzzzzzzu_ = nzzzzzzzzzzzzzzzzzt_?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzu_);
            CqlDateTime nzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzv_);
            Period nzzzzzzzzzzzzzzzzzx_ = Visit?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzx_);
            CqlDateTime nzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzx_);
            CqlDateTime ozzzzzzzzzzzzzzzzzc_ = context.Operators.End(ozzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzd_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzm_ ?? nzzzzzzzzzzzzzzzzzw_ ?? nzzzzzzzzzzzzzzzzzz_, ozzzzzzzzzzzzzzzzzc_, true, true);

            return ozzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> nzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)mzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzz_);
        IEnumerable<CqlInterval<CqlDateTime>> nzzzzzzzzzzzzzzzzzb_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(nzzzzzzzzzzzzzzzzza_);
        CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzc_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(nzzzzzzzzzzzzzzzzzb_);

        return nzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Delivery Encounter with Age Range")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Age_Range(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzi_ = this.Encounter_with_Age_Range(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzj_(Encounter EncounterWithAge)
        {
            CqlValueSet uzzzzzzzzzzzzzzzzzl_ = this.Delivery_Procedures(context);
            IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? uzzzzzzzzzzzzzzzzzn_(Procedure DeliveryProcedure)
            {
                Code<EventStatus> uzzzzzzzzzzzzzzzzzr_ = DeliveryProcedure?.StatusElement;
                EventStatus? uzzzzzzzzzzzzzzzzzs_ = uzzzzzzzzzzzzzzzzzr_?.Value;
                string uzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<string>(uzzzzzzzzzzzzzzzzzs_);
                bool? uzzzzzzzzzzzzzzzzzu_ = context.Operators.Equal(uzzzzzzzzzzzzzzzzzt_, "completed");
                DataType uzzzzzzzzzzzzzzzzzv_ = DeliveryProcedure?.Performed;
                object uzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzzzzw_);
                CqlDateTime uzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzz_ = this.hospitalizationWithEDOBTriageObservation(context, EncounterWithAge);
                bool? vzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzzz_, default);
                bool? vzzzzzzzzzzzzzzzzzb_ = context.Operators.And(uzzzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzzza_);

                return vzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Procedure>(uzzzzzzzzzzzzzzzzzm_, uzzzzzzzzzzzzzzzzzn_);
            Encounter uzzzzzzzzzzzzzzzzzp_(Procedure DeliveryProcedure) =>
                EncounterWithAge;
            IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Procedure, Encounter>(uzzzzzzzzzzzzzzzzzo_, uzzzzzzzzzzzzzzzzzp_);

            return uzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzk_ = context.Operators.SelectMany<Encounter, Encounter>(uzzzzzzzzzzzzzzzzzi_, uzzzzzzzzzzzzzzzzzj_);

        return uzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("lastTimeOfDelivery")]
    public CqlDateTime lastTimeOfDelivery(CqlContext context, Encounter TheEncounter)
    {
        CqlCode vzzzzzzzzzzzzzzzzzc_ = this.Date_and_time_of_obstetric_delivery(context);
        IEnumerable<CqlCode> vzzzzzzzzzzzzzzzzzd_ = context.Operators.ToList<CqlCode>(vzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, vzzzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? vzzzzzzzzzzzzzzzzzf_(Observation TimeOfDelivery)
        {
            DataType vzzzzzzzzzzzzzzzzzm_ = TimeOfDelivery?.Value;
            object vzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzm_);
            bool? vzzzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)((vzzzzzzzzzzzzzzzzzn_ as CqlDateTime) is null));
            Code<ObservationStatus> vzzzzzzzzzzzzzzzzzp_ = TimeOfDelivery?.StatusElement;
            ObservationStatus? vzzzzzzzzzzzzzzzzzq_ = vzzzzzzzzzzzzzzzzzp_?.Value;
            Code<ObservationStatus> vzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<Code<ObservationStatus>>(vzzzzzzzzzzzzzzzzzq_);
            string vzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<string>(vzzzzzzzzzzzzzzzzzr_);
            string[] vzzzzzzzzzzzzzzzzzt_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? vzzzzzzzzzzzzzzzzzu_ = context.Operators.In<string>(vzzzzzzzzzzzzzzzzzs_, vzzzzzzzzzzzzzzzzzt_ as IEnumerable<string>);
            bool? vzzzzzzzzzzzzzzzzzv_ = context.Operators.And(vzzzzzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzzzzzu_);
            object vzzzzzzzzzzzzzzzzzw_()
            {
                bool wzzzzzzzzzzzzzzzzzg_()
                {
                    DataType wzzzzzzzzzzzzzzzzzj_ = TimeOfDelivery?.Effective;
                    object wzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzj_);
                    bool wzzzzzzzzzzzzzzzzzl_ = wzzzzzzzzzzzzzzzzzk_ is CqlDateTime;

                    return wzzzzzzzzzzzzzzzzzl_;
                };
                bool wzzzzzzzzzzzzzzzzzh_()
                {
                    DataType wzzzzzzzzzzzzzzzzzm_ = TimeOfDelivery?.Effective;
                    object wzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzm_);
                    bool wzzzzzzzzzzzzzzzzzo_ = wzzzzzzzzzzzzzzzzzn_ is CqlInterval<CqlDateTime>;

                    return wzzzzzzzzzzzzzzzzzo_;
                };
                bool wzzzzzzzzzzzzzzzzzi_()
                {
                    DataType wzzzzzzzzzzzzzzzzzp_ = TimeOfDelivery?.Effective;
                    object wzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzp_);
                    bool wzzzzzzzzzzzzzzzzzr_ = wzzzzzzzzzzzzzzzzzq_ is CqlDateTime;

                    return wzzzzzzzzzzzzzzzzzr_;
                };
                if (wzzzzzzzzzzzzzzzzzg_())
                {
                    DataType wzzzzzzzzzzzzzzzzzs_ = TimeOfDelivery?.Effective;
                    object wzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzs_);

                    return (wzzzzzzzzzzzzzzzzzt_ as CqlDateTime) as object;
                }
                else if (wzzzzzzzzzzzzzzzzzh_())
                {
                    DataType wzzzzzzzzzzzzzzzzzu_ = TimeOfDelivery?.Effective;
                    object wzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzu_);

                    return (wzzzzzzzzzzzzzzzzzv_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (wzzzzzzzzzzzzzzzzzi_())
                {
                    DataType wzzzzzzzzzzzzzzzzzw_ = TimeOfDelivery?.Effective;
                    object wzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzw_);

                    return (wzzzzzzzzzzzzzzzzzx_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime vzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzzzzzzzzzzzzzzzw_());
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzy_ = this.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
            bool? vzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzx_, vzzzzzzzzzzzzzzzzzy_, default);
            bool? wzzzzzzzzzzzzzzzzza_ = context.Operators.And(vzzzzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzzzzz_);
            object wzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzm_);
            bool? wzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzc_ as CqlDateTime, vzzzzzzzzzzzzzzzzzy_, default);
            bool? wzzzzzzzzzzzzzzzzzf_ = context.Operators.And(wzzzzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzzzze_);

            return wzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzzze_, vzzzzzzzzzzzzzzzzzf_);
        object vzzzzzzzzzzzzzzzzzh_(Observation @this)
        {
            object wzzzzzzzzzzzzzzzzzy_()
            {
                bool xzzzzzzzzzzzzzzzzza_()
                {
                    DataType xzzzzzzzzzzzzzzzzzd_ = @this?.Effective;
                    object xzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzd_);
                    bool xzzzzzzzzzzzzzzzzzf_ = xzzzzzzzzzzzzzzzzze_ is CqlDateTime;

                    return xzzzzzzzzzzzzzzzzzf_;
                };
                bool xzzzzzzzzzzzzzzzzzb_()
                {
                    DataType xzzzzzzzzzzzzzzzzzg_ = @this?.Effective;
                    object xzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzg_);
                    bool xzzzzzzzzzzzzzzzzzi_ = xzzzzzzzzzzzzzzzzzh_ is CqlInterval<CqlDateTime>;

                    return xzzzzzzzzzzzzzzzzzi_;
                };
                bool xzzzzzzzzzzzzzzzzzc_()
                {
                    DataType xzzzzzzzzzzzzzzzzzj_ = @this?.Effective;
                    object xzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzj_);
                    bool xzzzzzzzzzzzzzzzzzl_ = xzzzzzzzzzzzzzzzzzk_ is CqlDateTime;

                    return xzzzzzzzzzzzzzzzzzl_;
                };
                if (xzzzzzzzzzzzzzzzzza_())
                {
                    DataType xzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                    object xzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzm_);

                    return (xzzzzzzzzzzzzzzzzzn_ as CqlDateTime) as object;
                }
                else if (xzzzzzzzzzzzzzzzzzb_())
                {
                    DataType xzzzzzzzzzzzzzzzzzo_ = @this?.Effective;
                    object xzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzo_);

                    return (xzzzzzzzzzzzzzzzzzp_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (xzzzzzzzzzzzzzzzzzc_())
                {
                    DataType xzzzzzzzzzzzzzzzzzq_ = @this?.Effective;
                    object xzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzq_);

                    return (xzzzzzzzzzzzzzzzzzr_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime wzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzy_());

            return wzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzi_ = context.Operators.SortBy<Observation>(vzzzzzzzzzzzzzzzzzg_, vzzzzzzzzzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
        Observation vzzzzzzzzzzzzzzzzzj_ = context.Operators.Last<Observation>(vzzzzzzzzzzzzzzzzzi_);
        DataType vzzzzzzzzzzzzzzzzzk_ = vzzzzzzzzzzzzzzzzzj_?.Value;
        object vzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzk_);

        return vzzzzzzzzzzzzzzzzzl_ as CqlDateTime;
    }


    [CqlExpressionDefinition("lastEstimatedDeliveryDate")]
    public CqlDateTime lastEstimatedDeliveryDate(CqlContext context, Encounter TheEncounter)
    {
        CqlCode xzzzzzzzzzzzzzzzzzs_ = this.Delivery_date_Estimated(context);
        IEnumerable<CqlCode> xzzzzzzzzzzzzzzzzzt_ = context.Operators.ToList<CqlCode>(xzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, xzzzzzzzzzzzzzzzzzt_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? xzzzzzzzzzzzzzzzzzv_(Observation EstimatedDateOfDelivery)
        {
            DataType yzzzzzzzzzzzzzzzzzc_ = EstimatedDateOfDelivery?.Value;
            object yzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzc_);
            bool? yzzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)((yzzzzzzzzzzzzzzzzzd_ as CqlDateTime) is null));
            Code<ObservationStatus> yzzzzzzzzzzzzzzzzzf_ = EstimatedDateOfDelivery?.StatusElement;
            ObservationStatus? yzzzzzzzzzzzzzzzzzg_ = yzzzzzzzzzzzzzzzzzf_?.Value;
            Code<ObservationStatus> yzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<Code<ObservationStatus>>(yzzzzzzzzzzzzzzzzzg_);
            string yzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<string>(yzzzzzzzzzzzzzzzzzh_);
            string[] yzzzzzzzzzzzzzzzzzj_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? yzzzzzzzzzzzzzzzzzk_ = context.Operators.In<string>(yzzzzzzzzzzzzzzzzzi_, yzzzzzzzzzzzzzzzzzj_ as IEnumerable<string>);
            bool? yzzzzzzzzzzzzzzzzzl_ = context.Operators.And(yzzzzzzzzzzzzzzzzze_, yzzzzzzzzzzzzzzzzzk_);
            object yzzzzzzzzzzzzzzzzzm_()
            {
                bool yzzzzzzzzzzzzzzzzzy_()
                {
                    DataType zzzzzzzzzzzzzzzzzzb_ = EstimatedDateOfDelivery?.Effective;
                    object zzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzb_);
                    bool zzzzzzzzzzzzzzzzzzd_ = zzzzzzzzzzzzzzzzzzc_ is CqlDateTime;

                    return zzzzzzzzzzzzzzzzzzd_;
                };
                bool yzzzzzzzzzzzzzzzzzz_()
                {
                    DataType zzzzzzzzzzzzzzzzzze_ = EstimatedDateOfDelivery?.Effective;
                    object zzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzze_);
                    bool zzzzzzzzzzzzzzzzzzg_ = zzzzzzzzzzzzzzzzzzf_ is CqlInterval<CqlDateTime>;

                    return zzzzzzzzzzzzzzzzzzg_;
                };
                bool zzzzzzzzzzzzzzzzzza_()
                {
                    DataType zzzzzzzzzzzzzzzzzzh_ = EstimatedDateOfDelivery?.Effective;
                    object zzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzh_);
                    bool zzzzzzzzzzzzzzzzzzj_ = zzzzzzzzzzzzzzzzzzi_ is CqlDateTime;

                    return zzzzzzzzzzzzzzzzzzj_;
                };
                if (yzzzzzzzzzzzzzzzzzy_())
                {
                    DataType zzzzzzzzzzzzzzzzzzk_ = EstimatedDateOfDelivery?.Effective;
                    object zzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzk_);

                    return (zzzzzzzzzzzzzzzzzzl_ as CqlDateTime) as object;
                }
                else if (yzzzzzzzzzzzzzzzzzz_())
                {
                    DataType zzzzzzzzzzzzzzzzzzm_ = EstimatedDateOfDelivery?.Effective;
                    object zzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzm_);

                    return (zzzzzzzzzzzzzzzzzzn_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (zzzzzzzzzzzzzzzzzza_())
                {
                    DataType zzzzzzzzzzzzzzzzzzo_ = EstimatedDateOfDelivery?.Effective;
                    object zzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzo_);

                    return (zzzzzzzzzzzzzzzzzzp_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime yzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzm_());
            CqlDateTime yzzzzzzzzzzzzzzzzzo_ = this.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity yzzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime yzzzzzzzzzzzzzzzzzq_ = context.Operators.Subtract(yzzzzzzzzzzzzzzzzzo_, yzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzzzzzo_, true, true);
            bool? yzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzzzzs_, default);
            bool? yzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzzo_ is null));
            bool? yzzzzzzzzzzzzzzzzzw_ = context.Operators.And(yzzzzzzzzzzzzzzzzzt_, yzzzzzzzzzzzzzzzzzv_);
            bool? yzzzzzzzzzzzzzzzzzx_ = context.Operators.And(yzzzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzzzw_);

            return yzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzzzzzu_, xzzzzzzzzzzzzzzzzzv_);
        object xzzzzzzzzzzzzzzzzzx_(Observation @this)
        {
            object zzzzzzzzzzzzzzzzzzq_()
            {
                bool zzzzzzzzzzzzzzzzzzs_()
                {
                    DataType zzzzzzzzzzzzzzzzzzv_ = @this?.Effective;
                    object zzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzv_);
                    bool zzzzzzzzzzzzzzzzzzx_ = zzzzzzzzzzzzzzzzzzw_ is CqlDateTime;

                    return zzzzzzzzzzzzzzzzzzx_;
                };
                bool zzzzzzzzzzzzzzzzzzt_()
                {
                    DataType zzzzzzzzzzzzzzzzzzy_ = @this?.Effective;
                    object zzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzy_);
                    bool azzzzzzzzzzzzzzzzzza_ = zzzzzzzzzzzzzzzzzzz_ is CqlInterval<CqlDateTime>;

                    return azzzzzzzzzzzzzzzzzza_;
                };
                bool zzzzzzzzzzzzzzzzzzu_()
                {
                    DataType azzzzzzzzzzzzzzzzzzb_ = @this?.Effective;
                    object azzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzb_);
                    bool azzzzzzzzzzzzzzzzzzd_ = azzzzzzzzzzzzzzzzzzc_ is CqlDateTime;

                    return azzzzzzzzzzzzzzzzzzd_;
                };
                if (zzzzzzzzzzzzzzzzzzs_())
                {
                    DataType azzzzzzzzzzzzzzzzzze_ = @this?.Effective;
                    object azzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzze_);

                    return (azzzzzzzzzzzzzzzzzzf_ as CqlDateTime) as object;
                }
                else if (zzzzzzzzzzzzzzzzzzt_())
                {
                    DataType azzzzzzzzzzzzzzzzzzg_ = @this?.Effective;
                    object azzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzg_);

                    return (azzzzzzzzzzzzzzzzzzh_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (zzzzzzzzzzzzzzzzzzu_())
                {
                    DataType azzzzzzzzzzzzzzzzzzi_ = @this?.Effective;
                    object azzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzi_);

                    return (azzzzzzzzzzzzzzzzzzj_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime zzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzq_());

            return zzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzy_ = context.Operators.SortBy<Observation>(xzzzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
        Observation xzzzzzzzzzzzzzzzzzz_ = context.Operators.Last<Observation>(xzzzzzzzzzzzzzzzzzy_);
        DataType yzzzzzzzzzzzzzzzzza_ = xzzzzzzzzzzzzzzzzzz_?.Value;
        object yzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzza_);

        return yzzzzzzzzzzzzzzzzzb_ as CqlDateTime;
    }


    [CqlExpressionDefinition("calculatedGestationalAge")]
    public int? calculatedGestationalAge(CqlContext context, Encounter TheEncounter)
    {
        CqlDateTime azzzzzzzzzzzzzzzzzzk_ = this.lastTimeOfDelivery(context, TheEncounter);
        CqlDateTime azzzzzzzzzzzzzzzzzzl_ = this.lastEstimatedDeliveryDate(context, TheEncounter);
        int? azzzzzzzzzzzzzzzzzzm_ = context.Operators.DifferenceBetween(azzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzl_, "day");
        int? azzzzzzzzzzzzzzzzzzn_ = context.Operators.Subtract(280, azzzzzzzzzzzzzzzzzzm_);
        int? azzzzzzzzzzzzzzzzzzo_ = context.Operators.TruncatedDivide(azzzzzzzzzzzzzzzzzzn_, 7);

        return azzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Variable Calculated Gestational Age")]
    public IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> Variable_Calculated_Gestational_Age(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzp_ = this.Delivery_Encounter_with_Age_Range(context);
        (CqlTupleMetadata, string EncounterID, int? CalculatedCGA)? azzzzzzzzzzzzzzzzzzq_(Encounter DeliveryEncounter)
        {
            Id azzzzzzzzzzzzzzzzzzt_ = DeliveryEncounter?.IdElement;
            string azzzzzzzzzzzzzzzzzzu_ = azzzzzzzzzzzzzzzzzzt_?.Value;
            int? azzzzzzzzzzzzzzzzzzv_ = this.calculatedGestationalAge(context, DeliveryEncounter);
            (CqlTupleMetadata, string EncounterID, int? CalculatedCGA)? azzzzzzzzzzzzzzzzzzw_ = (CqlTupleMetadata_DjNbNOhJZXGJDNQeiTBabEOBB, azzzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzzv_);

            return azzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> azzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?>(azzzzzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzzzzq_);
        IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> azzzzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?>(azzzzzzzzzzzzzzzzzzr_);

        return azzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("lastEstimatedGestationalAge")]
    public CqlQuantity lastEstimatedGestationalAge(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet azzzzzzzzzzzzzzzzzzx_ = this.Estimated_Gestational_Age_at_Delivery(context);
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? azzzzzzzzzzzzzzzzzzz_(Observation EstimatedGestationalAge)
        {
            object bzzzzzzzzzzzzzzzzzzg_()
            {
                bool czzzzzzzzzzzzzzzzzzq_()
                {
                    DataType czzzzzzzzzzzzzzzzzzt_ = EstimatedGestationalAge?.Effective;
                    object czzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzt_);
                    bool czzzzzzzzzzzzzzzzzzv_ = czzzzzzzzzzzzzzzzzzu_ is CqlDateTime;

                    return czzzzzzzzzzzzzzzzzzv_;
                };
                bool czzzzzzzzzzzzzzzzzzr_()
                {
                    DataType czzzzzzzzzzzzzzzzzzw_ = EstimatedGestationalAge?.Effective;
                    object czzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzw_);
                    bool czzzzzzzzzzzzzzzzzzy_ = czzzzzzzzzzzzzzzzzzx_ is CqlInterval<CqlDateTime>;

                    return czzzzzzzzzzzzzzzzzzy_;
                };
                bool czzzzzzzzzzzzzzzzzzs_()
                {
                    DataType czzzzzzzzzzzzzzzzzzz_ = EstimatedGestationalAge?.Effective;
                    object dzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzz_);
                    bool dzzzzzzzzzzzzzzzzzzb_ = dzzzzzzzzzzzzzzzzzza_ is CqlDateTime;

                    return dzzzzzzzzzzzzzzzzzzb_;
                };
                if (czzzzzzzzzzzzzzzzzzq_())
                {
                    DataType dzzzzzzzzzzzzzzzzzzc_ = EstimatedGestationalAge?.Effective;
                    object dzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzc_);

                    return (dzzzzzzzzzzzzzzzzzzd_ as CqlDateTime) as object;
                }
                else if (czzzzzzzzzzzzzzzzzzr_())
                {
                    DataType dzzzzzzzzzzzzzzzzzze_ = EstimatedGestationalAge?.Effective;
                    object dzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzze_);

                    return (dzzzzzzzzzzzzzzzzzzf_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (czzzzzzzzzzzzzzzzzzs_())
                {
                    DataType dzzzzzzzzzzzzzzzzzzg_ = EstimatedGestationalAge?.Effective;
                    object dzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzg_);

                    return (dzzzzzzzzzzzzzzzzzzh_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime bzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzg_());
            CqlDateTime bzzzzzzzzzzzzzzzzzzi_ = this.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity bzzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(24m, "hours");
            CqlDateTime bzzzzzzzzzzzzzzzzzzk_ = context.Operators.Subtract(bzzzzzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(bzzzzzzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzzzzzzi_, true, true);
            bool? bzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzh_, bzzzzzzzzzzzzzzzzzzm_, default);
            bool? bzzzzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzzzi_ is null));
            bool? bzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzzzp_);
            DataType bzzzzzzzzzzzzzzzzzzr_ = EstimatedGestationalAge?.Value;
            object bzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzr_);
            bool? bzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzzzs_ is null));
            bool? bzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzq_, bzzzzzzzzzzzzzzzzzzt_);
            Code<ObservationStatus> bzzzzzzzzzzzzzzzzzzv_ = EstimatedGestationalAge?.StatusElement;
            ObservationStatus? bzzzzzzzzzzzzzzzzzzw_ = bzzzzzzzzzzzzzzzzzzv_?.Value;
            Code<ObservationStatus> bzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<Code<ObservationStatus>>(bzzzzzzzzzzzzzzzzzzw_);
            string bzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzzzzzx_);
            string[] bzzzzzzzzzzzzzzzzzzz_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? czzzzzzzzzzzzzzzzzza_ = context.Operators.In<string>(bzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzz_ as IEnumerable<string>);
            bool? czzzzzzzzzzzzzzzzzzb_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzu_, czzzzzzzzzzzzzzzzzza_);
            object czzzzzzzzzzzzzzzzzzc_()
            {
                bool dzzzzzzzzzzzzzzzzzzi_()
                {
                    DataType dzzzzzzzzzzzzzzzzzzl_ = EstimatedGestationalAge?.Effective;
                    object dzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzl_);
                    bool dzzzzzzzzzzzzzzzzzzn_ = dzzzzzzzzzzzzzzzzzzm_ is CqlDateTime;

                    return dzzzzzzzzzzzzzzzzzzn_;
                };
                bool dzzzzzzzzzzzzzzzzzzj_()
                {
                    DataType dzzzzzzzzzzzzzzzzzzo_ = EstimatedGestationalAge?.Effective;
                    object dzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzo_);
                    bool dzzzzzzzzzzzzzzzzzzq_ = dzzzzzzzzzzzzzzzzzzp_ is CqlInterval<CqlDateTime>;

                    return dzzzzzzzzzzzzzzzzzzq_;
                };
                bool dzzzzzzzzzzzzzzzzzzk_()
                {
                    DataType dzzzzzzzzzzzzzzzzzzr_ = EstimatedGestationalAge?.Effective;
                    object dzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzr_);
                    bool dzzzzzzzzzzzzzzzzzzt_ = dzzzzzzzzzzzzzzzzzzs_ is CqlDateTime;

                    return dzzzzzzzzzzzzzzzzzzt_;
                };
                if (dzzzzzzzzzzzzzzzzzzi_())
                {
                    DataType dzzzzzzzzzzzzzzzzzzu_ = EstimatedGestationalAge?.Effective;
                    object dzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzu_);

                    return (dzzzzzzzzzzzzzzzzzzv_ as CqlDateTime) as object;
                }
                else if (dzzzzzzzzzzzzzzzzzzj_())
                {
                    DataType dzzzzzzzzzzzzzzzzzzw_ = EstimatedGestationalAge?.Effective;
                    object dzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzw_);

                    return (dzzzzzzzzzzzzzzzzzzx_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (dzzzzzzzzzzzzzzzzzzk_())
                {
                    DataType dzzzzzzzzzzzzzzzzzzy_ = EstimatedGestationalAge?.Effective;
                    object dzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzy_);

                    return (dzzzzzzzzzzzzzzzzzzz_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime czzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzc_());
            bool? czzzzzzzzzzzzzzzzzzf_ = context.Operators.SameAs(czzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzzi_, "day");
            object czzzzzzzzzzzzzzzzzzg_()
            {
                bool ezzzzzzzzzzzzzzzzzza_()
                {
                    DataType ezzzzzzzzzzzzzzzzzzd_ = EstimatedGestationalAge?.Effective;
                    object ezzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzd_);
                    bool ezzzzzzzzzzzzzzzzzzf_ = ezzzzzzzzzzzzzzzzzze_ is CqlDateTime;

                    return ezzzzzzzzzzzzzzzzzzf_;
                };
                bool ezzzzzzzzzzzzzzzzzzb_()
                {
                    DataType ezzzzzzzzzzzzzzzzzzg_ = EstimatedGestationalAge?.Effective;
                    object ezzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzg_);
                    bool ezzzzzzzzzzzzzzzzzzi_ = ezzzzzzzzzzzzzzzzzzh_ is CqlInterval<CqlDateTime>;

                    return ezzzzzzzzzzzzzzzzzzi_;
                };
                bool ezzzzzzzzzzzzzzzzzzc_()
                {
                    DataType ezzzzzzzzzzzzzzzzzzj_ = EstimatedGestationalAge?.Effective;
                    object ezzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzj_);
                    bool ezzzzzzzzzzzzzzzzzzl_ = ezzzzzzzzzzzzzzzzzzk_ is CqlDateTime;

                    return ezzzzzzzzzzzzzzzzzzl_;
                };
                if (ezzzzzzzzzzzzzzzzzza_())
                {
                    DataType ezzzzzzzzzzzzzzzzzzm_ = EstimatedGestationalAge?.Effective;
                    object ezzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzm_);

                    return (ezzzzzzzzzzzzzzzzzzn_ as CqlDateTime) as object;
                }
                else if (ezzzzzzzzzzzzzzzzzzb_())
                {
                    DataType ezzzzzzzzzzzzzzzzzzo_ = EstimatedGestationalAge?.Effective;
                    object ezzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzo_);

                    return (ezzzzzzzzzzzzzzzzzzp_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ezzzzzzzzzzzzzzzzzzc_())
                {
                    DataType ezzzzzzzzzzzzzzzzzzq_ = EstimatedGestationalAge?.Effective;
                    object ezzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzq_);

                    return (ezzzzzzzzzzzzzzzzzzr_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime czzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzg_());
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzi_ = this.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
            bool? czzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzzzzzi_, default);
            bool? czzzzzzzzzzzzzzzzzzk_ = context.Operators.And(czzzzzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzzzzj_);
            object czzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzr_);
            bool? czzzzzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzm_ is null));
            bool? czzzzzzzzzzzzzzzzzzo_ = context.Operators.And(czzzzzzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzzzzzn_);
            bool? czzzzzzzzzzzzzzzzzzp_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzzzzzo_);

            return czzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(azzzzzzzzzzzzzzzzzzy_, azzzzzzzzzzzzzzzzzzz_);
        object bzzzzzzzzzzzzzzzzzzb_(Observation @this)
        {
            object ezzzzzzzzzzzzzzzzzzs_()
            {
                bool ezzzzzzzzzzzzzzzzzzu_()
                {
                    DataType ezzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                    object ezzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzx_);
                    bool ezzzzzzzzzzzzzzzzzzz_ = ezzzzzzzzzzzzzzzzzzy_ is CqlDateTime;

                    return ezzzzzzzzzzzzzzzzzzz_;
                };
                bool ezzzzzzzzzzzzzzzzzzv_()
                {
                    DataType fzzzzzzzzzzzzzzzzzza_ = @this?.Effective;
                    object fzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzza_);
                    bool fzzzzzzzzzzzzzzzzzzc_ = fzzzzzzzzzzzzzzzzzzb_ is CqlInterval<CqlDateTime>;

                    return fzzzzzzzzzzzzzzzzzzc_;
                };
                bool ezzzzzzzzzzzzzzzzzzw_()
                {
                    DataType fzzzzzzzzzzzzzzzzzzd_ = @this?.Effective;
                    object fzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzd_);
                    bool fzzzzzzzzzzzzzzzzzzf_ = fzzzzzzzzzzzzzzzzzze_ is CqlDateTime;

                    return fzzzzzzzzzzzzzzzzzzf_;
                };
                if (ezzzzzzzzzzzzzzzzzzu_())
                {
                    DataType fzzzzzzzzzzzzzzzzzzg_ = @this?.Effective;
                    object fzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzg_);

                    return (fzzzzzzzzzzzzzzzzzzh_ as CqlDateTime) as object;
                }
                else if (ezzzzzzzzzzzzzzzzzzv_())
                {
                    DataType fzzzzzzzzzzzzzzzzzzi_ = @this?.Effective;
                    object fzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzi_);

                    return (fzzzzzzzzzzzzzzzzzzj_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ezzzzzzzzzzzzzzzzzzw_())
                {
                    DataType fzzzzzzzzzzzzzzzzzzk_ = @this?.Effective;
                    object fzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzk_);

                    return (fzzzzzzzzzzzzzzzzzzl_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime ezzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzzs_());

            return ezzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzc_ = context.Operators.SortBy<Observation>(bzzzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
        Observation bzzzzzzzzzzzzzzzzzzd_ = context.Operators.Last<Observation>(bzzzzzzzzzzzzzzzzzzc_);
        DataType bzzzzzzzzzzzzzzzzzze_ = bzzzzzzzzzzzzzzzzzzd_?.Value;
        object bzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzze_);

        return bzzzzzzzzzzzzzzzzzzf_ as CqlQuantity;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_DjNbNOhJZXGJDNQeiTBabEOBB = new(
        [typeof(string), typeof(int?)],
        ["EncounterID", "CalculatedCGA"]);

    #endregion CqlTupleMetadata Properties

}
