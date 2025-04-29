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
        CqlDateTime dzzzzzzr_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime dzzzzzzs_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> dzzzzzzt_ = context.Operators.Interval(dzzzzzzr_, dzzzzzzs_, true, true);
        object dzzzzzzu_ = context.ResolveParameter("PCMaternal-5.19.000", "Measurement Period", dzzzzzzt_);

        return (CqlInterval<CqlDateTime>)dzzzzzzu_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> dzzzzzzv_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient dzzzzzzw_ = context.Operators.SingletonFrom<Patient>(dzzzzzzv_);

        return dzzzzzzw_;
    }


    [CqlExpressionDefinition("Encounter with Age Range")]
    public IEnumerable<Encounter> Encounter_with_Age_Range(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzx_ = CQMCommon_2_2_000.Instance.Inpatient_Encounter(context);
        bool? dzzzzzzy_(Encounter InpatientEncounter)
        {
            Patient ezzzzzza_ = this.Patient(context);
            Date ezzzzzzb_ = ezzzzzza_?.BirthDateElement;
            string ezzzzzzc_ = ezzzzzzb_?.Value;
            CqlDate ezzzzzzd_ = context.Operators.ConvertStringToDate(ezzzzzzc_);
            Period ezzzzzze_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> ezzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzze_);
            CqlDateTime ezzzzzzg_ = context.Operators.Start(ezzzzzzf_);
            CqlDate ezzzzzzh_ = context.Operators.DateFrom(ezzzzzzg_);
            int? ezzzzzzi_ = context.Operators.CalculateAgeAt(ezzzzzzd_, ezzzzzzh_, "year");
            CqlInterval<int?> ezzzzzzj_ = context.Operators.Interval(8, 65, true, false);
            bool? ezzzzzzk_ = context.Operators.In<int?>(ezzzzzzi_, ezzzzzzj_, default);

            return ezzzzzzk_;
        };
        IEnumerable<Encounter> dzzzzzzz_ = context.Operators.Where<Encounter>(dzzzzzzx_, dzzzzzzy_);

        return dzzzzzzz_;
    }


    [CqlExpressionDefinition("hospitalizationWithEDOBTriageObservation")]
    public CqlInterval<CqlDateTime> hospitalizationWithEDOBTriageObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] ezzzzzzl_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> ezzzzzzm_(Encounter Visit)
        {
            CqlValueSet ezzzzzzq_ = this.ED_Visit_and_OB_Triage(context);
            IEnumerable<Encounter> ezzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? ezzzzzzs_(Encounter LastEDOBTriage)
            {
                Period fzzzzzzr_ = LastEDOBTriage?.Period;
                CqlInterval<CqlDateTime> fzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzr_);
                CqlDateTime fzzzzzzt_ = context.Operators.End(fzzzzzzs_);
                CqlValueSet fzzzzzzu_ = this.Observation_Services(context);
                IEnumerable<Encounter> fzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? fzzzzzzw_(Encounter LastObs)
                {
                    Period hzzzzzzs_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> hzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzs_);
                    CqlDateTime hzzzzzzu_ = context.Operators.End(hzzzzzzt_);
                    Period hzzzzzzv_ = Visit?.Period;
                    CqlInterval<CqlDateTime> hzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzv_);
                    CqlDateTime hzzzzzzx_ = context.Operators.Start(hzzzzzzw_);
                    CqlQuantity hzzzzzzy_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime hzzzzzzz_ = context.Operators.Subtract(hzzzzzzx_, hzzzzzzy_);
                    CqlInterval<CqlDateTime> izzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzv_);
                    CqlDateTime izzzzzzc_ = context.Operators.Start(izzzzzzb_);
                    CqlInterval<CqlDateTime> izzzzzzd_ = context.Operators.Interval(hzzzzzzz_, izzzzzzc_, true, true);
                    bool? izzzzzze_ = context.Operators.In<CqlDateTime>(hzzzzzzu_, izzzzzzd_, default);
                    CqlInterval<CqlDateTime> izzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzv_);
                    CqlDateTime izzzzzzh_ = context.Operators.Start(izzzzzzg_);
                    bool? izzzzzzi_ = context.Operators.Not((bool?)(izzzzzzh_ is null));
                    bool? izzzzzzj_ = context.Operators.And(izzzzzze_, izzzzzzi_);
                    Code<Encounter.EncounterStatus> izzzzzzk_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? izzzzzzl_ = izzzzzzk_?.Value;
                    Code<Encounter.EncounterStatus> izzzzzzm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(izzzzzzl_);
                    bool? izzzzzzn_ = context.Operators.Equal(izzzzzzm_, "finished");
                    bool? izzzzzzo_ = context.Operators.And(izzzzzzj_, izzzzzzn_);

                    return izzzzzzo_;
                };
                IEnumerable<Encounter> fzzzzzzx_ = context.Operators.Where<Encounter>(fzzzzzzv_, fzzzzzzw_);
                object fzzzzzzy_(Encounter @this)
                {
                    Period izzzzzzp_ = @this?.Period;
                    CqlInterval<CqlDateTime> izzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzp_);
                    CqlDateTime izzzzzzr_ = context.Operators.End(izzzzzzq_);

                    return izzzzzzr_;
                };
                IEnumerable<Encounter> fzzzzzzz_ = context.Operators.SortBy<Encounter>(fzzzzzzx_, fzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter gzzzzzza_ = context.Operators.Last<Encounter>(fzzzzzzz_);
                Period gzzzzzzb_ = gzzzzzza_?.Period;
                CqlInterval<CqlDateTime> gzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzb_);
                CqlDateTime gzzzzzzd_ = context.Operators.Start(gzzzzzzc_);
                Period gzzzzzze_ = Visit?.Period;
                CqlInterval<CqlDateTime> gzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzze_);
                CqlDateTime gzzzzzzg_ = context.Operators.Start(gzzzzzzf_);
                CqlQuantity gzzzzzzh_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime gzzzzzzi_ = context.Operators.Subtract(gzzzzzzd_ ?? gzzzzzzg_, gzzzzzzh_);
                IEnumerable<Encounter> gzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? gzzzzzzl_(Encounter LastObs)
                {
                    Period izzzzzzs_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> izzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzs_);
                    CqlDateTime izzzzzzu_ = context.Operators.End(izzzzzzt_);
                    Period izzzzzzv_ = Visit?.Period;
                    CqlInterval<CqlDateTime> izzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzv_);
                    CqlDateTime izzzzzzx_ = context.Operators.Start(izzzzzzw_);
                    CqlQuantity izzzzzzy_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime izzzzzzz_ = context.Operators.Subtract(izzzzzzx_, izzzzzzy_);
                    CqlInterval<CqlDateTime> jzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzv_);
                    CqlDateTime jzzzzzzc_ = context.Operators.Start(jzzzzzzb_);
                    CqlInterval<CqlDateTime> jzzzzzzd_ = context.Operators.Interval(izzzzzzz_, jzzzzzzc_, true, true);
                    bool? jzzzzzze_ = context.Operators.In<CqlDateTime>(izzzzzzu_, jzzzzzzd_, default);
                    CqlInterval<CqlDateTime> jzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzv_);
                    CqlDateTime jzzzzzzh_ = context.Operators.Start(jzzzzzzg_);
                    bool? jzzzzzzi_ = context.Operators.Not((bool?)(jzzzzzzh_ is null));
                    bool? jzzzzzzj_ = context.Operators.And(jzzzzzze_, jzzzzzzi_);
                    Code<Encounter.EncounterStatus> jzzzzzzk_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? jzzzzzzl_ = jzzzzzzk_?.Value;
                    Code<Encounter.EncounterStatus> jzzzzzzm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jzzzzzzl_);
                    bool? jzzzzzzn_ = context.Operators.Equal(jzzzzzzm_, "finished");
                    bool? jzzzzzzo_ = context.Operators.And(jzzzzzzj_, jzzzzzzn_);

                    return jzzzzzzo_;
                };
                IEnumerable<Encounter> gzzzzzzm_ = context.Operators.Where<Encounter>(gzzzzzzk_, gzzzzzzl_);
                object gzzzzzzn_(Encounter @this)
                {
                    Period jzzzzzzp_ = @this?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzp_);
                    CqlDateTime jzzzzzzr_ = context.Operators.End(jzzzzzzq_);

                    return jzzzzzzr_;
                };
                IEnumerable<Encounter> gzzzzzzo_ = context.Operators.SortBy<Encounter>(gzzzzzzm_, gzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter gzzzzzzp_ = context.Operators.Last<Encounter>(gzzzzzzo_);
                Period gzzzzzzq_ = gzzzzzzp_?.Period;
                CqlInterval<CqlDateTime> gzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzq_);
                CqlDateTime gzzzzzzs_ = context.Operators.Start(gzzzzzzr_);
                CqlInterval<CqlDateTime> gzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzze_);
                CqlDateTime gzzzzzzv_ = context.Operators.Start(gzzzzzzu_);
                CqlInterval<CqlDateTime> gzzzzzzw_ = context.Operators.Interval(gzzzzzzi_, gzzzzzzs_ ?? gzzzzzzv_, true, true);
                bool? gzzzzzzx_ = context.Operators.In<CqlDateTime>(fzzzzzzt_, gzzzzzzw_, default);
                IEnumerable<Encounter> gzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? hzzzzzza_(Encounter LastObs)
                {
                    Period jzzzzzzs_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzs_);
                    CqlDateTime jzzzzzzu_ = context.Operators.End(jzzzzzzt_);
                    Period jzzzzzzv_ = Visit?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzv_);
                    CqlDateTime jzzzzzzx_ = context.Operators.Start(jzzzzzzw_);
                    CqlQuantity jzzzzzzy_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime jzzzzzzz_ = context.Operators.Subtract(jzzzzzzx_, jzzzzzzy_);
                    CqlInterval<CqlDateTime> kzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzv_);
                    CqlDateTime kzzzzzzc_ = context.Operators.Start(kzzzzzzb_);
                    CqlInterval<CqlDateTime> kzzzzzzd_ = context.Operators.Interval(jzzzzzzz_, kzzzzzzc_, true, true);
                    bool? kzzzzzze_ = context.Operators.In<CqlDateTime>(jzzzzzzu_, kzzzzzzd_, default);
                    CqlInterval<CqlDateTime> kzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzv_);
                    CqlDateTime kzzzzzzh_ = context.Operators.Start(kzzzzzzg_);
                    bool? kzzzzzzi_ = context.Operators.Not((bool?)(kzzzzzzh_ is null));
                    bool? kzzzzzzj_ = context.Operators.And(kzzzzzze_, kzzzzzzi_);
                    Code<Encounter.EncounterStatus> kzzzzzzk_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? kzzzzzzl_ = kzzzzzzk_?.Value;
                    Code<Encounter.EncounterStatus> kzzzzzzm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(kzzzzzzl_);
                    bool? kzzzzzzn_ = context.Operators.Equal(kzzzzzzm_, "finished");
                    bool? kzzzzzzo_ = context.Operators.And(kzzzzzzj_, kzzzzzzn_);

                    return kzzzzzzo_;
                };
                IEnumerable<Encounter> hzzzzzzb_ = context.Operators.Where<Encounter>(gzzzzzzz_, hzzzzzza_);
                object hzzzzzzc_(Encounter @this)
                {
                    Period kzzzzzzp_ = @this?.Period;
                    CqlInterval<CqlDateTime> kzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzp_);
                    CqlDateTime kzzzzzzr_ = context.Operators.End(kzzzzzzq_);

                    return kzzzzzzr_;
                };
                IEnumerable<Encounter> hzzzzzzd_ = context.Operators.SortBy<Encounter>(hzzzzzzb_, hzzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter hzzzzzze_ = context.Operators.Last<Encounter>(hzzzzzzd_);
                Period hzzzzzzf_ = hzzzzzze_?.Period;
                CqlInterval<CqlDateTime> hzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzf_);
                CqlDateTime hzzzzzzh_ = context.Operators.Start(hzzzzzzg_);
                CqlInterval<CqlDateTime> hzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzze_);
                CqlDateTime hzzzzzzk_ = context.Operators.Start(hzzzzzzj_);
                bool? hzzzzzzl_ = context.Operators.Not((bool?)((hzzzzzzh_ ?? hzzzzzzk_) is null));
                bool? hzzzzzzm_ = context.Operators.And(gzzzzzzx_, hzzzzzzl_);
                Code<Encounter.EncounterStatus> hzzzzzzn_ = LastEDOBTriage?.StatusElement;
                Encounter.EncounterStatus? hzzzzzzo_ = hzzzzzzn_?.Value;
                Code<Encounter.EncounterStatus> hzzzzzzp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hzzzzzzo_);
                bool? hzzzzzzq_ = context.Operators.Equal(hzzzzzzp_, "finished");
                bool? hzzzzzzr_ = context.Operators.And(hzzzzzzm_, hzzzzzzq_);

                return hzzzzzzr_;
            };
            IEnumerable<Encounter> ezzzzzzt_ = context.Operators.Where<Encounter>(ezzzzzzr_, ezzzzzzs_);
            object ezzzzzzu_(Encounter @this)
            {
                Period kzzzzzzs_ = @this?.Period;
                CqlInterval<CqlDateTime> kzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzs_);
                CqlDateTime kzzzzzzu_ = context.Operators.End(kzzzzzzt_);

                return kzzzzzzu_;
            };
            IEnumerable<Encounter> ezzzzzzv_ = context.Operators.SortBy<Encounter>(ezzzzzzt_, ezzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter ezzzzzzw_ = context.Operators.Last<Encounter>(ezzzzzzv_);
            Period ezzzzzzx_ = ezzzzzzw_?.Period;
            CqlInterval<CqlDateTime> ezzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzx_);
            CqlDateTime ezzzzzzz_ = context.Operators.Start(ezzzzzzy_);
            CqlValueSet fzzzzzza_ = this.Observation_Services(context);
            IEnumerable<Encounter> fzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? fzzzzzzc_(Encounter LastObs)
            {
                Period kzzzzzzv_ = LastObs?.Period;
                CqlInterval<CqlDateTime> kzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzv_);
                CqlDateTime kzzzzzzx_ = context.Operators.End(kzzzzzzw_);
                Period kzzzzzzy_ = Visit?.Period;
                CqlInterval<CqlDateTime> kzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzy_);
                CqlDateTime lzzzzzza_ = context.Operators.Start(kzzzzzzz_);
                CqlQuantity lzzzzzzb_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime lzzzzzzc_ = context.Operators.Subtract(lzzzzzza_, lzzzzzzb_);
                CqlInterval<CqlDateTime> lzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzy_);
                CqlDateTime lzzzzzzf_ = context.Operators.Start(lzzzzzze_);
                CqlInterval<CqlDateTime> lzzzzzzg_ = context.Operators.Interval(lzzzzzzc_, lzzzzzzf_, true, true);
                bool? lzzzzzzh_ = context.Operators.In<CqlDateTime>(kzzzzzzx_, lzzzzzzg_, default);
                CqlInterval<CqlDateTime> lzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzy_);
                CqlDateTime lzzzzzzk_ = context.Operators.Start(lzzzzzzj_);
                bool? lzzzzzzl_ = context.Operators.Not((bool?)(lzzzzzzk_ is null));
                bool? lzzzzzzm_ = context.Operators.And(lzzzzzzh_, lzzzzzzl_);
                Code<Encounter.EncounterStatus> lzzzzzzn_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? lzzzzzzo_ = lzzzzzzn_?.Value;
                Code<Encounter.EncounterStatus> lzzzzzzp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lzzzzzzo_);
                bool? lzzzzzzq_ = context.Operators.Equal(lzzzzzzp_, "finished");
                bool? lzzzzzzr_ = context.Operators.And(lzzzzzzm_, lzzzzzzq_);

                return lzzzzzzr_;
            };
            IEnumerable<Encounter> fzzzzzzd_ = context.Operators.Where<Encounter>(fzzzzzzb_, fzzzzzzc_);
            object fzzzzzze_(Encounter @this)
            {
                Period lzzzzzzs_ = @this?.Period;
                CqlInterval<CqlDateTime> lzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzs_);
                CqlDateTime lzzzzzzu_ = context.Operators.End(lzzzzzzt_);

                return lzzzzzzu_;
            };
            IEnumerable<Encounter> fzzzzzzf_ = context.Operators.SortBy<Encounter>(fzzzzzzd_, fzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter fzzzzzzg_ = context.Operators.Last<Encounter>(fzzzzzzf_);
            Period fzzzzzzh_ = fzzzzzzg_?.Period;
            CqlInterval<CqlDateTime> fzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzh_);
            CqlDateTime fzzzzzzj_ = context.Operators.Start(fzzzzzzi_);
            Period fzzzzzzk_ = Visit?.Period;
            CqlInterval<CqlDateTime> fzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzk_);
            CqlDateTime fzzzzzzm_ = context.Operators.Start(fzzzzzzl_);
            CqlInterval<CqlDateTime> fzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzk_);
            CqlDateTime fzzzzzzp_ = context.Operators.End(fzzzzzzo_);
            CqlInterval<CqlDateTime> fzzzzzzq_ = context.Operators.Interval(ezzzzzzz_ ?? fzzzzzzj_ ?? fzzzzzzm_, fzzzzzzp_, true, true);

            return fzzzzzzq_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> ezzzzzzn_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)ezzzzzzl_, ezzzzzzm_);
        IEnumerable<CqlInterval<CqlDateTime>> ezzzzzzo_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(ezzzzzzn_);
        CqlInterval<CqlDateTime> ezzzzzzp_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(ezzzzzzo_);

        return ezzzzzzp_;
    }


    [CqlExpressionDefinition("Delivery Encounter with Age Range")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Age_Range(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzv_ = this.Encounter_with_Age_Range(context);
        IEnumerable<Encounter> lzzzzzzw_(Encounter EncounterWithAge)
        {
            CqlValueSet lzzzzzzy_ = this.Delivery_Procedures(context);
            IEnumerable<Procedure> lzzzzzzz_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, lzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? mzzzzzza_(Procedure DeliveryProcedure)
            {
                Code<EventStatus> mzzzzzze_ = DeliveryProcedure?.StatusElement;
                EventStatus? mzzzzzzf_ = mzzzzzze_?.Value;
                string mzzzzzzg_ = context.Operators.Convert<string>(mzzzzzzf_);
                bool? mzzzzzzh_ = context.Operators.Equal(mzzzzzzg_, "completed");
                DataType mzzzzzzi_ = DeliveryProcedure?.Performed;
                object mzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzi_);
                CqlInterval<CqlDateTime> mzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzj_);
                CqlDateTime mzzzzzzl_ = context.Operators.Start(mzzzzzzk_);
                CqlInterval<CqlDateTime> mzzzzzzm_ = this.hospitalizationWithEDOBTriageObservation(context, EncounterWithAge);
                bool? mzzzzzzn_ = context.Operators.In<CqlDateTime>(mzzzzzzl_, mzzzzzzm_, default);
                bool? mzzzzzzo_ = context.Operators.And(mzzzzzzh_, mzzzzzzn_);

                return mzzzzzzo_;
            };
            IEnumerable<Procedure> mzzzzzzb_ = context.Operators.Where<Procedure>(lzzzzzzz_, mzzzzzza_);
            Encounter mzzzzzzc_(Procedure DeliveryProcedure) =>
                EncounterWithAge;
            IEnumerable<Encounter> mzzzzzzd_ = context.Operators.Select<Procedure, Encounter>(mzzzzzzb_, mzzzzzzc_);

            return mzzzzzzd_;
        };
        IEnumerable<Encounter> lzzzzzzx_ = context.Operators.SelectMany<Encounter, Encounter>(lzzzzzzv_, lzzzzzzw_);

        return lzzzzzzx_;
    }


    [CqlExpressionDefinition("lastTimeOfDelivery")]
    public CqlDateTime lastTimeOfDelivery(CqlContext context, Encounter TheEncounter)
    {
        CqlCode mzzzzzzp_ = this.Date_and_time_of_obstetric_delivery(context);
        IEnumerable<CqlCode> mzzzzzzq_ = context.Operators.ToList<CqlCode>(mzzzzzzp_);
        IEnumerable<Observation> mzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, mzzzzzzq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? mzzzzzzs_(Observation TimeOfDelivery)
        {
            DataType mzzzzzzz_ = TimeOfDelivery?.Value;
            object nzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzz_);
            bool? nzzzzzzb_ = context.Operators.Not((bool?)((nzzzzzza_ as CqlDateTime) is null));
            Code<ObservationStatus> nzzzzzzc_ = TimeOfDelivery?.StatusElement;
            ObservationStatus? nzzzzzzd_ = nzzzzzzc_?.Value;
            Code<ObservationStatus> nzzzzzze_ = context.Operators.Convert<Code<ObservationStatus>>(nzzzzzzd_);
            string nzzzzzzf_ = context.Operators.Convert<string>(nzzzzzze_);
            string[] nzzzzzzg_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? nzzzzzzh_ = context.Operators.In<string>(nzzzzzzf_, nzzzzzzg_ as IEnumerable<string>);
            bool? nzzzzzzi_ = context.Operators.And(nzzzzzzb_, nzzzzzzh_);
            object nzzzzzzj_()
            {
                bool nzzzzzzt_()
                {
                    DataType nzzzzzzw_ = TimeOfDelivery?.Effective;
                    object nzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzw_);
                    bool nzzzzzzy_ = nzzzzzzx_ is CqlDateTime;

                    return nzzzzzzy_;
                };
                bool nzzzzzzu_()
                {
                    DataType nzzzzzzz_ = TimeOfDelivery?.Effective;
                    object ozzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzz_);
                    bool ozzzzzzb_ = ozzzzzza_ is CqlInterval<CqlDateTime>;

                    return ozzzzzzb_;
                };
                bool nzzzzzzv_()
                {
                    DataType ozzzzzzc_ = TimeOfDelivery?.Effective;
                    object ozzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzc_);
                    bool ozzzzzze_ = ozzzzzzd_ is CqlDateTime;

                    return ozzzzzze_;
                };
                if (nzzzzzzt_())
                {
                    DataType ozzzzzzf_ = TimeOfDelivery?.Effective;
                    object ozzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzf_);

                    return (ozzzzzzg_ as CqlDateTime) as object;
                }
                else if (nzzzzzzu_())
                {
                    DataType ozzzzzzh_ = TimeOfDelivery?.Effective;
                    object ozzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzh_);

                    return (ozzzzzzi_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (nzzzzzzv_())
                {
                    DataType ozzzzzzj_ = TimeOfDelivery?.Effective;
                    object ozzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzj_);

                    return (ozzzzzzk_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime nzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzj_());
            CqlInterval<CqlDateTime> nzzzzzzl_ = this.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
            bool? nzzzzzzm_ = context.Operators.In<CqlDateTime>(nzzzzzzk_, nzzzzzzl_, default);
            bool? nzzzzzzn_ = context.Operators.And(nzzzzzzi_, nzzzzzzm_);
            object nzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzz_);
            bool? nzzzzzzr_ = context.Operators.In<CqlDateTime>(nzzzzzzp_ as CqlDateTime, nzzzzzzl_, default);
            bool? nzzzzzzs_ = context.Operators.And(nzzzzzzn_, nzzzzzzr_);

            return nzzzzzzs_;
        };
        IEnumerable<Observation> mzzzzzzt_ = context.Operators.Where<Observation>(mzzzzzzr_, mzzzzzzs_);
        object mzzzzzzu_(Observation @this)
        {
            object ozzzzzzl_()
            {
                bool ozzzzzzn_()
                {
                    DataType ozzzzzzq_ = @this?.Effective;
                    object ozzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzq_);
                    bool ozzzzzzs_ = ozzzzzzr_ is CqlDateTime;

                    return ozzzzzzs_;
                };
                bool ozzzzzzo_()
                {
                    DataType ozzzzzzt_ = @this?.Effective;
                    object ozzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzt_);
                    bool ozzzzzzv_ = ozzzzzzu_ is CqlInterval<CqlDateTime>;

                    return ozzzzzzv_;
                };
                bool ozzzzzzp_()
                {
                    DataType ozzzzzzw_ = @this?.Effective;
                    object ozzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzw_);
                    bool ozzzzzzy_ = ozzzzzzx_ is CqlDateTime;

                    return ozzzzzzy_;
                };
                if (ozzzzzzn_())
                {
                    DataType ozzzzzzz_ = @this?.Effective;
                    object pzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzz_);

                    return (pzzzzzza_ as CqlDateTime) as object;
                }
                else if (ozzzzzzo_())
                {
                    DataType pzzzzzzb_ = @this?.Effective;
                    object pzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzb_);

                    return (pzzzzzzc_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ozzzzzzp_())
                {
                    DataType pzzzzzzd_ = @this?.Effective;
                    object pzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzd_);

                    return (pzzzzzze_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime ozzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzl_());

            return ozzzzzzm_;
        };
        IEnumerable<Observation> mzzzzzzv_ = context.Operators.SortBy<Observation>(mzzzzzzt_, mzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
        Observation mzzzzzzw_ = context.Operators.Last<Observation>(mzzzzzzv_);
        DataType mzzzzzzx_ = mzzzzzzw_?.Value;
        object mzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzx_);

        return mzzzzzzy_ as CqlDateTime;
    }


    [CqlExpressionDefinition("lastEstimatedDeliveryDate")]
    public CqlDateTime lastEstimatedDeliveryDate(CqlContext context, Encounter TheEncounter)
    {
        CqlCode pzzzzzzf_ = this.Delivery_date_Estimated(context);
        IEnumerable<CqlCode> pzzzzzzg_ = context.Operators.ToList<CqlCode>(pzzzzzzf_);
        IEnumerable<Observation> pzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, pzzzzzzg_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? pzzzzzzi_(Observation EstimatedDateOfDelivery)
        {
            DataType pzzzzzzp_ = EstimatedDateOfDelivery?.Value;
            object pzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzp_);
            bool? pzzzzzzr_ = context.Operators.Not((bool?)((pzzzzzzq_ as CqlDateTime) is null));
            Code<ObservationStatus> pzzzzzzs_ = EstimatedDateOfDelivery?.StatusElement;
            ObservationStatus? pzzzzzzt_ = pzzzzzzs_?.Value;
            Code<ObservationStatus> pzzzzzzu_ = context.Operators.Convert<Code<ObservationStatus>>(pzzzzzzt_);
            string pzzzzzzv_ = context.Operators.Convert<string>(pzzzzzzu_);
            string[] pzzzzzzw_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? pzzzzzzx_ = context.Operators.In<string>(pzzzzzzv_, pzzzzzzw_ as IEnumerable<string>);
            bool? pzzzzzzy_ = context.Operators.And(pzzzzzzr_, pzzzzzzx_);
            object pzzzzzzz_()
            {
                bool qzzzzzzl_()
                {
                    DataType qzzzzzzo_ = EstimatedDateOfDelivery?.Effective;
                    object qzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzo_);
                    bool qzzzzzzq_ = qzzzzzzp_ is CqlDateTime;

                    return qzzzzzzq_;
                };
                bool qzzzzzzm_()
                {
                    DataType qzzzzzzr_ = EstimatedDateOfDelivery?.Effective;
                    object qzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzr_);
                    bool qzzzzzzt_ = qzzzzzzs_ is CqlInterval<CqlDateTime>;

                    return qzzzzzzt_;
                };
                bool qzzzzzzn_()
                {
                    DataType qzzzzzzu_ = EstimatedDateOfDelivery?.Effective;
                    object qzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzu_);
                    bool qzzzzzzw_ = qzzzzzzv_ is CqlDateTime;

                    return qzzzzzzw_;
                };
                if (qzzzzzzl_())
                {
                    DataType qzzzzzzx_ = EstimatedDateOfDelivery?.Effective;
                    object qzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzx_);

                    return (qzzzzzzy_ as CqlDateTime) as object;
                }
                else if (qzzzzzzm_())
                {
                    DataType qzzzzzzz_ = EstimatedDateOfDelivery?.Effective;
                    object rzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzz_);

                    return (rzzzzzza_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (qzzzzzzn_())
                {
                    DataType rzzzzzzb_ = EstimatedDateOfDelivery?.Effective;
                    object rzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzb_);

                    return (rzzzzzzc_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime qzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzz_());
            CqlDateTime qzzzzzzb_ = this.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity qzzzzzzc_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime qzzzzzzd_ = context.Operators.Subtract(qzzzzzzb_, qzzzzzzc_);
            CqlInterval<CqlDateTime> qzzzzzzf_ = context.Operators.Interval(qzzzzzzd_, qzzzzzzb_, true, true);
            bool? qzzzzzzg_ = context.Operators.In<CqlDateTime>(qzzzzzza_, qzzzzzzf_, default);
            bool? qzzzzzzi_ = context.Operators.Not((bool?)(qzzzzzzb_ is null));
            bool? qzzzzzzj_ = context.Operators.And(qzzzzzzg_, qzzzzzzi_);
            bool? qzzzzzzk_ = context.Operators.And(pzzzzzzy_, qzzzzzzj_);

            return qzzzzzzk_;
        };
        IEnumerable<Observation> pzzzzzzj_ = context.Operators.Where<Observation>(pzzzzzzh_, pzzzzzzi_);
        object pzzzzzzk_(Observation @this)
        {
            object rzzzzzzd_()
            {
                bool rzzzzzzf_()
                {
                    DataType rzzzzzzi_ = @this?.Effective;
                    object rzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzi_);
                    bool rzzzzzzk_ = rzzzzzzj_ is CqlDateTime;

                    return rzzzzzzk_;
                };
                bool rzzzzzzg_()
                {
                    DataType rzzzzzzl_ = @this?.Effective;
                    object rzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzl_);
                    bool rzzzzzzn_ = rzzzzzzm_ is CqlInterval<CqlDateTime>;

                    return rzzzzzzn_;
                };
                bool rzzzzzzh_()
                {
                    DataType rzzzzzzo_ = @this?.Effective;
                    object rzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzo_);
                    bool rzzzzzzq_ = rzzzzzzp_ is CqlDateTime;

                    return rzzzzzzq_;
                };
                if (rzzzzzzf_())
                {
                    DataType rzzzzzzr_ = @this?.Effective;
                    object rzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzr_);

                    return (rzzzzzzs_ as CqlDateTime) as object;
                }
                else if (rzzzzzzg_())
                {
                    DataType rzzzzzzt_ = @this?.Effective;
                    object rzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzt_);

                    return (rzzzzzzu_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (rzzzzzzh_())
                {
                    DataType rzzzzzzv_ = @this?.Effective;
                    object rzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzv_);

                    return (rzzzzzzw_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime rzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzd_());

            return rzzzzzze_;
        };
        IEnumerable<Observation> pzzzzzzl_ = context.Operators.SortBy<Observation>(pzzzzzzj_, pzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
        Observation pzzzzzzm_ = context.Operators.Last<Observation>(pzzzzzzl_);
        DataType pzzzzzzn_ = pzzzzzzm_?.Value;
        object pzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzn_);

        return pzzzzzzo_ as CqlDateTime;
    }


    [CqlExpressionDefinition("calculatedGestationalAge")]
    public int? calculatedGestationalAge(CqlContext context, Encounter TheEncounter)
    {
        CqlDateTime rzzzzzzx_ = this.lastTimeOfDelivery(context, TheEncounter);
        CqlDateTime rzzzzzzy_ = this.lastEstimatedDeliveryDate(context, TheEncounter);
        int? rzzzzzzz_ = context.Operators.DifferenceBetween(rzzzzzzx_, rzzzzzzy_, "day");
        int? szzzzzza_ = context.Operators.Subtract(280, rzzzzzzz_);
        int? szzzzzzb_ = context.Operators.TruncatedDivide(szzzzzza_, 7);

        return szzzzzzb_;
    }


    [CqlExpressionDefinition("Variable Calculated Gestational Age")]
    public IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> Variable_Calculated_Gestational_Age(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzc_ = this.Delivery_Encounter_with_Age_Range(context);
        (CqlTupleMetadata, string EncounterID, int? CalculatedCGA)? szzzzzzd_(Encounter DeliveryEncounter)
        {
            Id szzzzzzg_ = DeliveryEncounter?.IdElement;
            string szzzzzzh_ = szzzzzzg_?.Value;
            int? szzzzzzi_ = this.calculatedGestationalAge(context, DeliveryEncounter);
            (CqlTupleMetadata, string EncounterID, int? CalculatedCGA)? szzzzzzj_ = (CqlTupleMetadata_DjNbNOhJZXGJDNQeiTBabEOBB, szzzzzzh_, szzzzzzi_);

            return szzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> szzzzzze_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?>(szzzzzzc_, szzzzzzd_);
        IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> szzzzzzf_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?>(szzzzzze_);

        return szzzzzzf_;
    }


    [CqlExpressionDefinition("lastEstimatedGestationalAge")]
    public CqlQuantity lastEstimatedGestationalAge(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet szzzzzzk_ = this.Estimated_Gestational_Age_at_Delivery(context);
        IEnumerable<Observation> szzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, szzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? szzzzzzm_(Observation EstimatedGestationalAge)
        {
            object szzzzzzt_()
            {
                bool uzzzzzzd_()
                {
                    DataType uzzzzzzg_ = EstimatedGestationalAge?.Effective;
                    object uzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzg_);
                    bool uzzzzzzi_ = uzzzzzzh_ is CqlDateTime;

                    return uzzzzzzi_;
                };
                bool uzzzzzze_()
                {
                    DataType uzzzzzzj_ = EstimatedGestationalAge?.Effective;
                    object uzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzj_);
                    bool uzzzzzzl_ = uzzzzzzk_ is CqlInterval<CqlDateTime>;

                    return uzzzzzzl_;
                };
                bool uzzzzzzf_()
                {
                    DataType uzzzzzzm_ = EstimatedGestationalAge?.Effective;
                    object uzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzm_);
                    bool uzzzzzzo_ = uzzzzzzn_ is CqlDateTime;

                    return uzzzzzzo_;
                };
                if (uzzzzzzd_())
                {
                    DataType uzzzzzzp_ = EstimatedGestationalAge?.Effective;
                    object uzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzp_);

                    return (uzzzzzzq_ as CqlDateTime) as object;
                }
                else if (uzzzzzze_())
                {
                    DataType uzzzzzzr_ = EstimatedGestationalAge?.Effective;
                    object uzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzr_);

                    return (uzzzzzzs_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (uzzzzzzf_())
                {
                    DataType uzzzzzzt_ = EstimatedGestationalAge?.Effective;
                    object uzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzt_);

                    return (uzzzzzzu_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime szzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzt_());
            CqlDateTime szzzzzzv_ = this.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity szzzzzzw_ = context.Operators.Quantity(24m, "hours");
            CqlDateTime szzzzzzx_ = context.Operators.Subtract(szzzzzzv_, szzzzzzw_);
            CqlInterval<CqlDateTime> szzzzzzz_ = context.Operators.Interval(szzzzzzx_, szzzzzzv_, true, true);
            bool? tzzzzzza_ = context.Operators.In<CqlDateTime>(szzzzzzu_, szzzzzzz_, default);
            bool? tzzzzzzc_ = context.Operators.Not((bool?)(szzzzzzv_ is null));
            bool? tzzzzzzd_ = context.Operators.And(tzzzzzza_, tzzzzzzc_);
            DataType tzzzzzze_ = EstimatedGestationalAge?.Value;
            object tzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzze_);
            bool? tzzzzzzg_ = context.Operators.Not((bool?)(tzzzzzzf_ is null));
            bool? tzzzzzzh_ = context.Operators.And(tzzzzzzd_, tzzzzzzg_);
            Code<ObservationStatus> tzzzzzzi_ = EstimatedGestationalAge?.StatusElement;
            ObservationStatus? tzzzzzzj_ = tzzzzzzi_?.Value;
            Code<ObservationStatus> tzzzzzzk_ = context.Operators.Convert<Code<ObservationStatus>>(tzzzzzzj_);
            string tzzzzzzl_ = context.Operators.Convert<string>(tzzzzzzk_);
            string[] tzzzzzzm_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? tzzzzzzn_ = context.Operators.In<string>(tzzzzzzl_, tzzzzzzm_ as IEnumerable<string>);
            bool? tzzzzzzo_ = context.Operators.And(tzzzzzzh_, tzzzzzzn_);
            object tzzzzzzp_()
            {
                bool uzzzzzzv_()
                {
                    DataType uzzzzzzy_ = EstimatedGestationalAge?.Effective;
                    object uzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzy_);
                    bool vzzzzzza_ = uzzzzzzz_ is CqlDateTime;

                    return vzzzzzza_;
                };
                bool uzzzzzzw_()
                {
                    DataType vzzzzzzb_ = EstimatedGestationalAge?.Effective;
                    object vzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzb_);
                    bool vzzzzzzd_ = vzzzzzzc_ is CqlInterval<CqlDateTime>;

                    return vzzzzzzd_;
                };
                bool uzzzzzzx_()
                {
                    DataType vzzzzzze_ = EstimatedGestationalAge?.Effective;
                    object vzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzze_);
                    bool vzzzzzzg_ = vzzzzzzf_ is CqlDateTime;

                    return vzzzzzzg_;
                };
                if (uzzzzzzv_())
                {
                    DataType vzzzzzzh_ = EstimatedGestationalAge?.Effective;
                    object vzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzh_);

                    return (vzzzzzzi_ as CqlDateTime) as object;
                }
                else if (uzzzzzzw_())
                {
                    DataType vzzzzzzj_ = EstimatedGestationalAge?.Effective;
                    object vzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzj_);

                    return (vzzzzzzk_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (uzzzzzzx_())
                {
                    DataType vzzzzzzl_ = EstimatedGestationalAge?.Effective;
                    object vzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzl_);

                    return (vzzzzzzm_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime tzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzp_());
            bool? tzzzzzzs_ = context.Operators.SameAs(tzzzzzzq_, szzzzzzv_, "day");
            object tzzzzzzt_()
            {
                bool vzzzzzzn_()
                {
                    DataType vzzzzzzq_ = EstimatedGestationalAge?.Effective;
                    object vzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzq_);
                    bool vzzzzzzs_ = vzzzzzzr_ is CqlDateTime;

                    return vzzzzzzs_;
                };
                bool vzzzzzzo_()
                {
                    DataType vzzzzzzt_ = EstimatedGestationalAge?.Effective;
                    object vzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzt_);
                    bool vzzzzzzv_ = vzzzzzzu_ is CqlInterval<CqlDateTime>;

                    return vzzzzzzv_;
                };
                bool vzzzzzzp_()
                {
                    DataType vzzzzzzw_ = EstimatedGestationalAge?.Effective;
                    object vzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzw_);
                    bool vzzzzzzy_ = vzzzzzzx_ is CqlDateTime;

                    return vzzzzzzy_;
                };
                if (vzzzzzzn_())
                {
                    DataType vzzzzzzz_ = EstimatedGestationalAge?.Effective;
                    object wzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzz_);

                    return (wzzzzzza_ as CqlDateTime) as object;
                }
                else if (vzzzzzzo_())
                {
                    DataType wzzzzzzb_ = EstimatedGestationalAge?.Effective;
                    object wzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzb_);

                    return (wzzzzzzc_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (vzzzzzzp_())
                {
                    DataType wzzzzzzd_ = EstimatedGestationalAge?.Effective;
                    object wzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzd_);

                    return (wzzzzzze_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime tzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzt_());
            CqlInterval<CqlDateTime> tzzzzzzv_ = this.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
            bool? tzzzzzzw_ = context.Operators.In<CqlDateTime>(tzzzzzzu_, tzzzzzzv_, default);
            bool? tzzzzzzx_ = context.Operators.And(tzzzzzzs_, tzzzzzzw_);
            object tzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzze_);
            bool? uzzzzzza_ = context.Operators.Not((bool?)(tzzzzzzz_ is null));
            bool? uzzzzzzb_ = context.Operators.And(tzzzzzzx_, uzzzzzza_);
            bool? uzzzzzzc_ = context.Operators.Or(tzzzzzzo_, uzzzzzzb_);

            return uzzzzzzc_;
        };
        IEnumerable<Observation> szzzzzzn_ = context.Operators.Where<Observation>(szzzzzzl_, szzzzzzm_);
        object szzzzzzo_(Observation @this)
        {
            object wzzzzzzf_()
            {
                bool wzzzzzzh_()
                {
                    DataType wzzzzzzk_ = @this?.Effective;
                    object wzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzk_);
                    bool wzzzzzzm_ = wzzzzzzl_ is CqlDateTime;

                    return wzzzzzzm_;
                };
                bool wzzzzzzi_()
                {
                    DataType wzzzzzzn_ = @this?.Effective;
                    object wzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzn_);
                    bool wzzzzzzp_ = wzzzzzzo_ is CqlInterval<CqlDateTime>;

                    return wzzzzzzp_;
                };
                bool wzzzzzzj_()
                {
                    DataType wzzzzzzq_ = @this?.Effective;
                    object wzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzq_);
                    bool wzzzzzzs_ = wzzzzzzr_ is CqlDateTime;

                    return wzzzzzzs_;
                };
                if (wzzzzzzh_())
                {
                    DataType wzzzzzzt_ = @this?.Effective;
                    object wzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzt_);

                    return (wzzzzzzu_ as CqlDateTime) as object;
                }
                else if (wzzzzzzi_())
                {
                    DataType wzzzzzzv_ = @this?.Effective;
                    object wzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzv_);

                    return (wzzzzzzw_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (wzzzzzzj_())
                {
                    DataType wzzzzzzx_ = @this?.Effective;
                    object wzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzx_);

                    return (wzzzzzzy_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime wzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzf_());

            return wzzzzzzg_;
        };
        IEnumerable<Observation> szzzzzzp_ = context.Operators.SortBy<Observation>(szzzzzzn_, szzzzzzo_, System.ComponentModel.ListSortDirection.Ascending);
        Observation szzzzzzq_ = context.Operators.Last<Observation>(szzzzzzp_);
        DataType szzzzzzr_ = szzzzzzq_?.Value;
        object szzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzr_);

        return szzzzzzs_ as CqlQuantity;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_DjNbNOhJZXGJDNQeiTBabEOBB = new(
        [typeof(string), typeof(int?)],
        ["EncounterID", "CalculatedCGA"]);

    #endregion CqlTupleMetadata Properties

}
