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
        CqlDateTime dzzzzzzzzzzzw_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime dzzzzzzzzzzzx_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> dzzzzzzzzzzzy_ = context.Operators.Interval(dzzzzzzzzzzzw_, dzzzzzzzzzzzx_, true, true);
        object dzzzzzzzzzzzz_ = context.ResolveParameter("PCMaternal-5.19.000", "Measurement Period", dzzzzzzzzzzzy_);

        return (CqlInterval<CqlDateTime>)dzzzzzzzzzzzz_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ezzzzzzzzzzza_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient ezzzzzzzzzzzb_ = context.Operators.SingletonFrom<Patient>(ezzzzzzzzzzza_);

        return ezzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Encounter with Age Range")]
    public IEnumerable<Encounter> Encounter_with_Age_Range(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzc_ = CQMCommon_2_2_000.Instance.Inpatient_Encounter(context);
        bool? ezzzzzzzzzzzd_(Encounter InpatientEncounter)
        {
            Patient ezzzzzzzzzzzf_ = this.Patient(context);
            Date ezzzzzzzzzzzg_ = ezzzzzzzzzzzf_?.BirthDateElement;
            string ezzzzzzzzzzzh_ = ezzzzzzzzzzzg_?.Value;
            CqlDate ezzzzzzzzzzzi_ = context.Operators.ConvertStringToDate(ezzzzzzzzzzzh_);
            Period ezzzzzzzzzzzj_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> ezzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzj_);
            CqlDateTime ezzzzzzzzzzzl_ = context.Operators.Start(ezzzzzzzzzzzk_);
            CqlDate ezzzzzzzzzzzm_ = context.Operators.DateFrom(ezzzzzzzzzzzl_);
            int? ezzzzzzzzzzzn_ = context.Operators.CalculateAgeAt(ezzzzzzzzzzzi_, ezzzzzzzzzzzm_, "year");
            CqlInterval<int?> ezzzzzzzzzzzo_ = context.Operators.Interval(8, 65, true, false);
            bool? ezzzzzzzzzzzp_ = context.Operators.In<int?>(ezzzzzzzzzzzn_, ezzzzzzzzzzzo_, default);

            return ezzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzze_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzc_, ezzzzzzzzzzzd_);

        return ezzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("hospitalizationWithEDOBTriageObservation")]
    public CqlInterval<CqlDateTime> hospitalizationWithEDOBTriageObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] ezzzzzzzzzzzq_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> ezzzzzzzzzzzr_(Encounter Visit)
        {
            CqlValueSet ezzzzzzzzzzzv_ = this.ED_Visit_and_OB_Triage(context);
            IEnumerable<Encounter> ezzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? ezzzzzzzzzzzx_(Encounter LastEDOBTriage)
            {
                Period fzzzzzzzzzzzw_ = LastEDOBTriage?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzw_);
                CqlDateTime fzzzzzzzzzzzy_ = context.Operators.End(fzzzzzzzzzzzx_);
                CqlValueSet fzzzzzzzzzzzz_ = this.Observation_Services(context);
                IEnumerable<Encounter> gzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? gzzzzzzzzzzzb_(Encounter LastObs)
                {
                    Period hzzzzzzzzzzzx_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> hzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzx_);
                    CqlDateTime hzzzzzzzzzzzz_ = context.Operators.End(hzzzzzzzzzzzy_);
                    Period izzzzzzzzzzza_ = Visit?.Period;
                    CqlInterval<CqlDateTime> izzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzza_);
                    CqlDateTime izzzzzzzzzzzc_ = context.Operators.Start(izzzzzzzzzzzb_);
                    CqlQuantity izzzzzzzzzzzd_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime izzzzzzzzzzze_ = context.Operators.Subtract(izzzzzzzzzzzc_, izzzzzzzzzzzd_);
                    CqlInterval<CqlDateTime> izzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzza_);
                    CqlDateTime izzzzzzzzzzzh_ = context.Operators.Start(izzzzzzzzzzzg_);
                    CqlInterval<CqlDateTime> izzzzzzzzzzzi_ = context.Operators.Interval(izzzzzzzzzzze_, izzzzzzzzzzzh_, true, true);
                    bool? izzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzz_, izzzzzzzzzzzi_, default);
                    CqlInterval<CqlDateTime> izzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzza_);
                    CqlDateTime izzzzzzzzzzzm_ = context.Operators.Start(izzzzzzzzzzzl_);
                    bool? izzzzzzzzzzzn_ = context.Operators.Not((bool?)(izzzzzzzzzzzm_ is null));
                    bool? izzzzzzzzzzzo_ = context.Operators.And(izzzzzzzzzzzj_, izzzzzzzzzzzn_);
                    Code<Encounter.EncounterStatus> izzzzzzzzzzzp_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? izzzzzzzzzzzq_ = izzzzzzzzzzzp_?.Value;
                    Code<Encounter.EncounterStatus> izzzzzzzzzzzr_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(izzzzzzzzzzzq_);
                    bool? izzzzzzzzzzzs_ = context.Operators.Equal(izzzzzzzzzzzr_, "finished");
                    bool? izzzzzzzzzzzt_ = context.Operators.And(izzzzzzzzzzzo_, izzzzzzzzzzzs_);

                    return izzzzzzzzzzzt_;
                };
                IEnumerable<Encounter> gzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(gzzzzzzzzzzza_, gzzzzzzzzzzzb_);
                object gzzzzzzzzzzzd_(Encounter @this)
                {
                    Period izzzzzzzzzzzu_ = @this?.Period;
                    CqlInterval<CqlDateTime> izzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzu_);
                    CqlDateTime izzzzzzzzzzzw_ = context.Operators.End(izzzzzzzzzzzv_);

                    return izzzzzzzzzzzw_;
                };
                IEnumerable<Encounter> gzzzzzzzzzzze_ = context.Operators.SortBy<Encounter>(gzzzzzzzzzzzc_, gzzzzzzzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter gzzzzzzzzzzzf_ = context.Operators.Last<Encounter>(gzzzzzzzzzzze_);
                Period gzzzzzzzzzzzg_ = gzzzzzzzzzzzf_?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzg_);
                CqlDateTime gzzzzzzzzzzzi_ = context.Operators.Start(gzzzzzzzzzzzh_);
                Period gzzzzzzzzzzzj_ = Visit?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzj_);
                CqlDateTime gzzzzzzzzzzzl_ = context.Operators.Start(gzzzzzzzzzzzk_);
                CqlQuantity gzzzzzzzzzzzm_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime gzzzzzzzzzzzn_ = context.Operators.Subtract(gzzzzzzzzzzzi_ ?? gzzzzzzzzzzzl_, gzzzzzzzzzzzm_);
                IEnumerable<Encounter> gzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? gzzzzzzzzzzzq_(Encounter LastObs)
                {
                    Period izzzzzzzzzzzx_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> izzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzx_);
                    CqlDateTime izzzzzzzzzzzz_ = context.Operators.End(izzzzzzzzzzzy_);
                    Period jzzzzzzzzzzza_ = Visit?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzza_);
                    CqlDateTime jzzzzzzzzzzzc_ = context.Operators.Start(jzzzzzzzzzzzb_);
                    CqlQuantity jzzzzzzzzzzzd_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime jzzzzzzzzzzze_ = context.Operators.Subtract(jzzzzzzzzzzzc_, jzzzzzzzzzzzd_);
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzza_);
                    CqlDateTime jzzzzzzzzzzzh_ = context.Operators.Start(jzzzzzzzzzzzg_);
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzi_ = context.Operators.Interval(jzzzzzzzzzzze_, jzzzzzzzzzzzh_, true, true);
                    bool? jzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzz_, jzzzzzzzzzzzi_, default);
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzza_);
                    CqlDateTime jzzzzzzzzzzzm_ = context.Operators.Start(jzzzzzzzzzzzl_);
                    bool? jzzzzzzzzzzzn_ = context.Operators.Not((bool?)(jzzzzzzzzzzzm_ is null));
                    bool? jzzzzzzzzzzzo_ = context.Operators.And(jzzzzzzzzzzzj_, jzzzzzzzzzzzn_);
                    Code<Encounter.EncounterStatus> jzzzzzzzzzzzp_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? jzzzzzzzzzzzq_ = jzzzzzzzzzzzp_?.Value;
                    Code<Encounter.EncounterStatus> jzzzzzzzzzzzr_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jzzzzzzzzzzzq_);
                    bool? jzzzzzzzzzzzs_ = context.Operators.Equal(jzzzzzzzzzzzr_, "finished");
                    bool? jzzzzzzzzzzzt_ = context.Operators.And(jzzzzzzzzzzzo_, jzzzzzzzzzzzs_);

                    return jzzzzzzzzzzzt_;
                };
                IEnumerable<Encounter> gzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzp_, gzzzzzzzzzzzq_);
                object gzzzzzzzzzzzs_(Encounter @this)
                {
                    Period jzzzzzzzzzzzu_ = @this?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzu_);
                    CqlDateTime jzzzzzzzzzzzw_ = context.Operators.End(jzzzzzzzzzzzv_);

                    return jzzzzzzzzzzzw_;
                };
                IEnumerable<Encounter> gzzzzzzzzzzzt_ = context.Operators.SortBy<Encounter>(gzzzzzzzzzzzr_, gzzzzzzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter gzzzzzzzzzzzu_ = context.Operators.Last<Encounter>(gzzzzzzzzzzzt_);
                Period gzzzzzzzzzzzv_ = gzzzzzzzzzzzu_?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzv_);
                CqlDateTime gzzzzzzzzzzzx_ = context.Operators.Start(gzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzj_);
                CqlDateTime hzzzzzzzzzzza_ = context.Operators.Start(gzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzb_ = context.Operators.Interval(gzzzzzzzzzzzn_, gzzzzzzzzzzzx_ ?? hzzzzzzzzzzza_, true, true);
                bool? hzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzy_, hzzzzzzzzzzzb_, default);
                IEnumerable<Encounter> hzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? hzzzzzzzzzzzf_(Encounter LastObs)
                {
                    Period jzzzzzzzzzzzx_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzx_);
                    CqlDateTime jzzzzzzzzzzzz_ = context.Operators.End(jzzzzzzzzzzzy_);
                    Period kzzzzzzzzzzza_ = Visit?.Period;
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzza_);
                    CqlDateTime kzzzzzzzzzzzc_ = context.Operators.Start(kzzzzzzzzzzzb_);
                    CqlQuantity kzzzzzzzzzzzd_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime kzzzzzzzzzzze_ = context.Operators.Subtract(kzzzzzzzzzzzc_, kzzzzzzzzzzzd_);
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzza_);
                    CqlDateTime kzzzzzzzzzzzh_ = context.Operators.Start(kzzzzzzzzzzzg_);
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzi_ = context.Operators.Interval(kzzzzzzzzzzze_, kzzzzzzzzzzzh_, true, true);
                    bool? kzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzz_, kzzzzzzzzzzzi_, default);
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzza_);
                    CqlDateTime kzzzzzzzzzzzm_ = context.Operators.Start(kzzzzzzzzzzzl_);
                    bool? kzzzzzzzzzzzn_ = context.Operators.Not((bool?)(kzzzzzzzzzzzm_ is null));
                    bool? kzzzzzzzzzzzo_ = context.Operators.And(kzzzzzzzzzzzj_, kzzzzzzzzzzzn_);
                    Code<Encounter.EncounterStatus> kzzzzzzzzzzzp_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? kzzzzzzzzzzzq_ = kzzzzzzzzzzzp_?.Value;
                    Code<Encounter.EncounterStatus> kzzzzzzzzzzzr_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(kzzzzzzzzzzzq_);
                    bool? kzzzzzzzzzzzs_ = context.Operators.Equal(kzzzzzzzzzzzr_, "finished");
                    bool? kzzzzzzzzzzzt_ = context.Operators.And(kzzzzzzzzzzzo_, kzzzzzzzzzzzs_);

                    return kzzzzzzzzzzzt_;
                };
                IEnumerable<Encounter> hzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(hzzzzzzzzzzze_, hzzzzzzzzzzzf_);
                object hzzzzzzzzzzzh_(Encounter @this)
                {
                    Period kzzzzzzzzzzzu_ = @this?.Period;
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzu_);
                    CqlDateTime kzzzzzzzzzzzw_ = context.Operators.End(kzzzzzzzzzzzv_);

                    return kzzzzzzzzzzzw_;
                };
                IEnumerable<Encounter> hzzzzzzzzzzzi_ = context.Operators.SortBy<Encounter>(hzzzzzzzzzzzg_, hzzzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter hzzzzzzzzzzzj_ = context.Operators.Last<Encounter>(hzzzzzzzzzzzi_);
                Period hzzzzzzzzzzzk_ = hzzzzzzzzzzzj_?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzk_);
                CqlDateTime hzzzzzzzzzzzm_ = context.Operators.Start(hzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzj_);
                CqlDateTime hzzzzzzzzzzzp_ = context.Operators.Start(hzzzzzzzzzzzo_);
                bool? hzzzzzzzzzzzq_ = context.Operators.Not((bool?)((hzzzzzzzzzzzm_ ?? hzzzzzzzzzzzp_) is null));
                bool? hzzzzzzzzzzzr_ = context.Operators.And(hzzzzzzzzzzzc_, hzzzzzzzzzzzq_);
                Code<Encounter.EncounterStatus> hzzzzzzzzzzzs_ = LastEDOBTriage?.StatusElement;
                Encounter.EncounterStatus? hzzzzzzzzzzzt_ = hzzzzzzzzzzzs_?.Value;
                Code<Encounter.EncounterStatus> hzzzzzzzzzzzu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hzzzzzzzzzzzt_);
                bool? hzzzzzzzzzzzv_ = context.Operators.Equal(hzzzzzzzzzzzu_, "finished");
                bool? hzzzzzzzzzzzw_ = context.Operators.And(hzzzzzzzzzzzr_, hzzzzzzzzzzzv_);

                return hzzzzzzzzzzzw_;
            };
            IEnumerable<Encounter> ezzzzzzzzzzzy_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzw_, ezzzzzzzzzzzx_);
            object ezzzzzzzzzzzz_(Encounter @this)
            {
                Period kzzzzzzzzzzzx_ = @this?.Period;
                CqlInterval<CqlDateTime> kzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzx_);
                CqlDateTime kzzzzzzzzzzzz_ = context.Operators.End(kzzzzzzzzzzzy_);

                return kzzzzzzzzzzzz_;
            };
            IEnumerable<Encounter> fzzzzzzzzzzza_ = context.Operators.SortBy<Encounter>(ezzzzzzzzzzzy_, ezzzzzzzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter fzzzzzzzzzzzb_ = context.Operators.Last<Encounter>(fzzzzzzzzzzza_);
            Period fzzzzzzzzzzzc_ = fzzzzzzzzzzzb_?.Period;
            CqlInterval<CqlDateTime> fzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzc_);
            CqlDateTime fzzzzzzzzzzze_ = context.Operators.Start(fzzzzzzzzzzzd_);
            CqlValueSet fzzzzzzzzzzzf_ = this.Observation_Services(context);
            IEnumerable<Encounter> fzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? fzzzzzzzzzzzh_(Encounter LastObs)
            {
                Period lzzzzzzzzzzza_ = LastObs?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzza_);
                CqlDateTime lzzzzzzzzzzzc_ = context.Operators.End(lzzzzzzzzzzzb_);
                Period lzzzzzzzzzzzd_ = Visit?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzd_);
                CqlDateTime lzzzzzzzzzzzf_ = context.Operators.Start(lzzzzzzzzzzze_);
                CqlQuantity lzzzzzzzzzzzg_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime lzzzzzzzzzzzh_ = context.Operators.Subtract(lzzzzzzzzzzzf_, lzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzd_);
                CqlDateTime lzzzzzzzzzzzk_ = context.Operators.Start(lzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzl_ = context.Operators.Interval(lzzzzzzzzzzzh_, lzzzzzzzzzzzk_, true, true);
                bool? lzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzc_, lzzzzzzzzzzzl_, default);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzd_);
                CqlDateTime lzzzzzzzzzzzp_ = context.Operators.Start(lzzzzzzzzzzzo_);
                bool? lzzzzzzzzzzzq_ = context.Operators.Not((bool?)(lzzzzzzzzzzzp_ is null));
                bool? lzzzzzzzzzzzr_ = context.Operators.And(lzzzzzzzzzzzm_, lzzzzzzzzzzzq_);
                Code<Encounter.EncounterStatus> lzzzzzzzzzzzs_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? lzzzzzzzzzzzt_ = lzzzzzzzzzzzs_?.Value;
                Code<Encounter.EncounterStatus> lzzzzzzzzzzzu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lzzzzzzzzzzzt_);
                bool? lzzzzzzzzzzzv_ = context.Operators.Equal(lzzzzzzzzzzzu_, "finished");
                bool? lzzzzzzzzzzzw_ = context.Operators.And(lzzzzzzzzzzzr_, lzzzzzzzzzzzv_);

                return lzzzzzzzzzzzw_;
            };
            IEnumerable<Encounter> fzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzg_, fzzzzzzzzzzzh_);
            object fzzzzzzzzzzzj_(Encounter @this)
            {
                Period lzzzzzzzzzzzx_ = @this?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzx_);
                CqlDateTime lzzzzzzzzzzzz_ = context.Operators.End(lzzzzzzzzzzzy_);

                return lzzzzzzzzzzzz_;
            };
            IEnumerable<Encounter> fzzzzzzzzzzzk_ = context.Operators.SortBy<Encounter>(fzzzzzzzzzzzi_, fzzzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter fzzzzzzzzzzzl_ = context.Operators.Last<Encounter>(fzzzzzzzzzzzk_);
            Period fzzzzzzzzzzzm_ = fzzzzzzzzzzzl_?.Period;
            CqlInterval<CqlDateTime> fzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzm_);
            CqlDateTime fzzzzzzzzzzzo_ = context.Operators.Start(fzzzzzzzzzzzn_);
            Period fzzzzzzzzzzzp_ = Visit?.Period;
            CqlInterval<CqlDateTime> fzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzp_);
            CqlDateTime fzzzzzzzzzzzr_ = context.Operators.Start(fzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzp_);
            CqlDateTime fzzzzzzzzzzzu_ = context.Operators.End(fzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzv_ = context.Operators.Interval(fzzzzzzzzzzze_ ?? fzzzzzzzzzzzo_ ?? fzzzzzzzzzzzr_, fzzzzzzzzzzzu_, true, true);

            return fzzzzzzzzzzzv_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> ezzzzzzzzzzzs_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)ezzzzzzzzzzzq_, ezzzzzzzzzzzr_);
        IEnumerable<CqlInterval<CqlDateTime>> ezzzzzzzzzzzt_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(ezzzzzzzzzzzs_);
        CqlInterval<CqlDateTime> ezzzzzzzzzzzu_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(ezzzzzzzzzzzt_);

        return ezzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Delivery Encounter with Age Range")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Age_Range(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzza_ = this.Encounter_with_Age_Range(context);
        IEnumerable<Encounter> mzzzzzzzzzzzb_(Encounter EncounterWithAge)
        {
            CqlValueSet mzzzzzzzzzzzd_ = this.Delivery_Procedures(context);
            IEnumerable<Procedure> mzzzzzzzzzzze_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, mzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? mzzzzzzzzzzzf_(Procedure DeliveryProcedure)
            {
                Code<EventStatus> mzzzzzzzzzzzj_ = DeliveryProcedure?.StatusElement;
                EventStatus? mzzzzzzzzzzzk_ = mzzzzzzzzzzzj_?.Value;
                string mzzzzzzzzzzzl_ = context.Operators.Convert<string>(mzzzzzzzzzzzk_);
                bool? mzzzzzzzzzzzm_ = context.Operators.Equal(mzzzzzzzzzzzl_, "completed");
                DataType mzzzzzzzzzzzn_ = DeliveryProcedure?.Performed;
                object mzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzo_);
                CqlDateTime mzzzzzzzzzzzq_ = context.Operators.Start(mzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzr_ = this.hospitalizationWithEDOBTriageObservation(context, EncounterWithAge);
                bool? mzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzq_, mzzzzzzzzzzzr_, default);
                bool? mzzzzzzzzzzzt_ = context.Operators.And(mzzzzzzzzzzzm_, mzzzzzzzzzzzs_);

                return mzzzzzzzzzzzt_;
            };
            IEnumerable<Procedure> mzzzzzzzzzzzg_ = context.Operators.Where<Procedure>(mzzzzzzzzzzze_, mzzzzzzzzzzzf_);
            Encounter mzzzzzzzzzzzh_(Procedure DeliveryProcedure) =>
                EncounterWithAge;
            IEnumerable<Encounter> mzzzzzzzzzzzi_ = context.Operators.Select<Procedure, Encounter>(mzzzzzzzzzzzg_, mzzzzzzzzzzzh_);

            return mzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzc_ = context.Operators.SelectMany<Encounter, Encounter>(mzzzzzzzzzzza_, mzzzzzzzzzzzb_);

        return mzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("lastTimeOfDelivery")]
    public CqlDateTime lastTimeOfDelivery(CqlContext context, Encounter TheEncounter)
    {
        CqlCode mzzzzzzzzzzzu_ = this.Date_and_time_of_obstetric_delivery(context);
        IEnumerable<CqlCode> mzzzzzzzzzzzv_ = context.Operators.ToList<CqlCode>(mzzzzzzzzzzzu_);
        IEnumerable<Observation> mzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, mzzzzzzzzzzzv_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? mzzzzzzzzzzzx_(Observation TimeOfDelivery)
        {
            DataType nzzzzzzzzzzze_ = TimeOfDelivery?.Value;
            object nzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzze_);
            bool? nzzzzzzzzzzzg_ = context.Operators.Not((bool?)((nzzzzzzzzzzzf_ as CqlDateTime) is null));
            Code<ObservationStatus> nzzzzzzzzzzzh_ = TimeOfDelivery?.StatusElement;
            ObservationStatus? nzzzzzzzzzzzi_ = nzzzzzzzzzzzh_?.Value;
            Code<ObservationStatus> nzzzzzzzzzzzj_ = context.Operators.Convert<Code<ObservationStatus>>(nzzzzzzzzzzzi_);
            string nzzzzzzzzzzzk_ = context.Operators.Convert<string>(nzzzzzzzzzzzj_);
            string[] nzzzzzzzzzzzl_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? nzzzzzzzzzzzm_ = context.Operators.In<string>(nzzzzzzzzzzzk_, nzzzzzzzzzzzl_ as IEnumerable<string>);
            bool? nzzzzzzzzzzzn_ = context.Operators.And(nzzzzzzzzzzzg_, nzzzzzzzzzzzm_);
            object nzzzzzzzzzzzo_()
            {
                bool nzzzzzzzzzzzy_()
                {
                    DataType ozzzzzzzzzzzb_ = TimeOfDelivery?.Effective;
                    object ozzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzb_);
                    bool ozzzzzzzzzzzd_ = ozzzzzzzzzzzc_ is CqlDateTime;

                    return ozzzzzzzzzzzd_;
                };
                bool nzzzzzzzzzzzz_()
                {
                    DataType ozzzzzzzzzzze_ = TimeOfDelivery?.Effective;
                    object ozzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzze_);
                    bool ozzzzzzzzzzzg_ = ozzzzzzzzzzzf_ is CqlInterval<CqlDateTime>;

                    return ozzzzzzzzzzzg_;
                };
                bool ozzzzzzzzzzza_()
                {
                    DataType ozzzzzzzzzzzh_ = TimeOfDelivery?.Effective;
                    object ozzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzh_);
                    bool ozzzzzzzzzzzj_ = ozzzzzzzzzzzi_ is CqlDateTime;

                    return ozzzzzzzzzzzj_;
                };
                if (nzzzzzzzzzzzy_())
                {
                    DataType ozzzzzzzzzzzk_ = TimeOfDelivery?.Effective;
                    object ozzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzk_);

                    return (ozzzzzzzzzzzl_ as CqlDateTime) as object;
                }
                else if (nzzzzzzzzzzzz_())
                {
                    DataType ozzzzzzzzzzzm_ = TimeOfDelivery?.Effective;
                    object ozzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzm_);

                    return (ozzzzzzzzzzzn_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ozzzzzzzzzzza_())
                {
                    DataType ozzzzzzzzzzzo_ = TimeOfDelivery?.Effective;
                    object ozzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzo_);

                    return (ozzzzzzzzzzzp_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime nzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzo_());
            CqlInterval<CqlDateTime> nzzzzzzzzzzzq_ = this.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
            bool? nzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzp_, nzzzzzzzzzzzq_, default);
            bool? nzzzzzzzzzzzs_ = context.Operators.And(nzzzzzzzzzzzn_, nzzzzzzzzzzzr_);
            object nzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzze_);
            bool? nzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzu_ as CqlDateTime, nzzzzzzzzzzzq_, default);
            bool? nzzzzzzzzzzzx_ = context.Operators.And(nzzzzzzzzzzzs_, nzzzzzzzzzzzw_);

            return nzzzzzzzzzzzx_;
        };
        IEnumerable<Observation> mzzzzzzzzzzzy_ = context.Operators.Where<Observation>(mzzzzzzzzzzzw_, mzzzzzzzzzzzx_);
        object mzzzzzzzzzzzz_(Observation @this)
        {
            object ozzzzzzzzzzzq_()
            {
                bool ozzzzzzzzzzzs_()
                {
                    DataType ozzzzzzzzzzzv_ = @this?.Effective;
                    object ozzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzv_);
                    bool ozzzzzzzzzzzx_ = ozzzzzzzzzzzw_ is CqlDateTime;

                    return ozzzzzzzzzzzx_;
                };
                bool ozzzzzzzzzzzt_()
                {
                    DataType ozzzzzzzzzzzy_ = @this?.Effective;
                    object ozzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzy_);
                    bool pzzzzzzzzzzza_ = ozzzzzzzzzzzz_ is CqlInterval<CqlDateTime>;

                    return pzzzzzzzzzzza_;
                };
                bool ozzzzzzzzzzzu_()
                {
                    DataType pzzzzzzzzzzzb_ = @this?.Effective;
                    object pzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzb_);
                    bool pzzzzzzzzzzzd_ = pzzzzzzzzzzzc_ is CqlDateTime;

                    return pzzzzzzzzzzzd_;
                };
                if (ozzzzzzzzzzzs_())
                {
                    DataType pzzzzzzzzzzze_ = @this?.Effective;
                    object pzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzze_);

                    return (pzzzzzzzzzzzf_ as CqlDateTime) as object;
                }
                else if (ozzzzzzzzzzzt_())
                {
                    DataType pzzzzzzzzzzzg_ = @this?.Effective;
                    object pzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzg_);

                    return (pzzzzzzzzzzzh_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ozzzzzzzzzzzu_())
                {
                    DataType pzzzzzzzzzzzi_ = @this?.Effective;
                    object pzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzi_);

                    return (pzzzzzzzzzzzj_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime ozzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzq_());

            return ozzzzzzzzzzzr_;
        };
        IEnumerable<Observation> nzzzzzzzzzzza_ = context.Operators.SortBy<Observation>(mzzzzzzzzzzzy_, mzzzzzzzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
        Observation nzzzzzzzzzzzb_ = context.Operators.Last<Observation>(nzzzzzzzzzzza_);
        DataType nzzzzzzzzzzzc_ = nzzzzzzzzzzzb_?.Value;
        object nzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzc_);

        return nzzzzzzzzzzzd_ as CqlDateTime;
    }


    [CqlExpressionDefinition("lastEstimatedDeliveryDate")]
    public CqlDateTime lastEstimatedDeliveryDate(CqlContext context, Encounter TheEncounter)
    {
        CqlCode pzzzzzzzzzzzk_ = this.Delivery_date_Estimated(context);
        IEnumerable<CqlCode> pzzzzzzzzzzzl_ = context.Operators.ToList<CqlCode>(pzzzzzzzzzzzk_);
        IEnumerable<Observation> pzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, pzzzzzzzzzzzl_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? pzzzzzzzzzzzn_(Observation EstimatedDateOfDelivery)
        {
            DataType pzzzzzzzzzzzu_ = EstimatedDateOfDelivery?.Value;
            object pzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzu_);
            bool? pzzzzzzzzzzzw_ = context.Operators.Not((bool?)((pzzzzzzzzzzzv_ as CqlDateTime) is null));
            Code<ObservationStatus> pzzzzzzzzzzzx_ = EstimatedDateOfDelivery?.StatusElement;
            ObservationStatus? pzzzzzzzzzzzy_ = pzzzzzzzzzzzx_?.Value;
            Code<ObservationStatus> pzzzzzzzzzzzz_ = context.Operators.Convert<Code<ObservationStatus>>(pzzzzzzzzzzzy_);
            string qzzzzzzzzzzza_ = context.Operators.Convert<string>(pzzzzzzzzzzzz_);
            string[] qzzzzzzzzzzzb_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? qzzzzzzzzzzzc_ = context.Operators.In<string>(qzzzzzzzzzzza_, qzzzzzzzzzzzb_ as IEnumerable<string>);
            bool? qzzzzzzzzzzzd_ = context.Operators.And(pzzzzzzzzzzzw_, qzzzzzzzzzzzc_);
            object qzzzzzzzzzzze_()
            {
                bool qzzzzzzzzzzzq_()
                {
                    DataType qzzzzzzzzzzzt_ = EstimatedDateOfDelivery?.Effective;
                    object qzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzt_);
                    bool qzzzzzzzzzzzv_ = qzzzzzzzzzzzu_ is CqlDateTime;

                    return qzzzzzzzzzzzv_;
                };
                bool qzzzzzzzzzzzr_()
                {
                    DataType qzzzzzzzzzzzw_ = EstimatedDateOfDelivery?.Effective;
                    object qzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzw_);
                    bool qzzzzzzzzzzzy_ = qzzzzzzzzzzzx_ is CqlInterval<CqlDateTime>;

                    return qzzzzzzzzzzzy_;
                };
                bool qzzzzzzzzzzzs_()
                {
                    DataType qzzzzzzzzzzzz_ = EstimatedDateOfDelivery?.Effective;
                    object rzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzz_);
                    bool rzzzzzzzzzzzb_ = rzzzzzzzzzzza_ is CqlDateTime;

                    return rzzzzzzzzzzzb_;
                };
                if (qzzzzzzzzzzzq_())
                {
                    DataType rzzzzzzzzzzzc_ = EstimatedDateOfDelivery?.Effective;
                    object rzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzc_);

                    return (rzzzzzzzzzzzd_ as CqlDateTime) as object;
                }
                else if (qzzzzzzzzzzzr_())
                {
                    DataType rzzzzzzzzzzze_ = EstimatedDateOfDelivery?.Effective;
                    object rzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzze_);

                    return (rzzzzzzzzzzzf_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (qzzzzzzzzzzzs_())
                {
                    DataType rzzzzzzzzzzzg_ = EstimatedDateOfDelivery?.Effective;
                    object rzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzg_);

                    return (rzzzzzzzzzzzh_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime qzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzzzzzzzze_());
            CqlDateTime qzzzzzzzzzzzg_ = this.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity qzzzzzzzzzzzh_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime qzzzzzzzzzzzi_ = context.Operators.Subtract(qzzzzzzzzzzzg_, qzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzk_ = context.Operators.Interval(qzzzzzzzzzzzi_, qzzzzzzzzzzzg_, true, true);
            bool? qzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzf_, qzzzzzzzzzzzk_, default);
            bool? qzzzzzzzzzzzn_ = context.Operators.Not((bool?)(qzzzzzzzzzzzg_ is null));
            bool? qzzzzzzzzzzzo_ = context.Operators.And(qzzzzzzzzzzzl_, qzzzzzzzzzzzn_);
            bool? qzzzzzzzzzzzp_ = context.Operators.And(qzzzzzzzzzzzd_, qzzzzzzzzzzzo_);

            return qzzzzzzzzzzzp_;
        };
        IEnumerable<Observation> pzzzzzzzzzzzo_ = context.Operators.Where<Observation>(pzzzzzzzzzzzm_, pzzzzzzzzzzzn_);
        object pzzzzzzzzzzzp_(Observation @this)
        {
            object rzzzzzzzzzzzi_()
            {
                bool rzzzzzzzzzzzk_()
                {
                    DataType rzzzzzzzzzzzn_ = @this?.Effective;
                    object rzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzn_);
                    bool rzzzzzzzzzzzp_ = rzzzzzzzzzzzo_ is CqlDateTime;

                    return rzzzzzzzzzzzp_;
                };
                bool rzzzzzzzzzzzl_()
                {
                    DataType rzzzzzzzzzzzq_ = @this?.Effective;
                    object rzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzq_);
                    bool rzzzzzzzzzzzs_ = rzzzzzzzzzzzr_ is CqlInterval<CqlDateTime>;

                    return rzzzzzzzzzzzs_;
                };
                bool rzzzzzzzzzzzm_()
                {
                    DataType rzzzzzzzzzzzt_ = @this?.Effective;
                    object rzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzt_);
                    bool rzzzzzzzzzzzv_ = rzzzzzzzzzzzu_ is CqlDateTime;

                    return rzzzzzzzzzzzv_;
                };
                if (rzzzzzzzzzzzk_())
                {
                    DataType rzzzzzzzzzzzw_ = @this?.Effective;
                    object rzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzw_);

                    return (rzzzzzzzzzzzx_ as CqlDateTime) as object;
                }
                else if (rzzzzzzzzzzzl_())
                {
                    DataType rzzzzzzzzzzzy_ = @this?.Effective;
                    object rzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzy_);

                    return (rzzzzzzzzzzzz_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (rzzzzzzzzzzzm_())
                {
                    DataType szzzzzzzzzzza_ = @this?.Effective;
                    object szzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzza_);

                    return (szzzzzzzzzzzb_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime rzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzi_());

            return rzzzzzzzzzzzj_;
        };
        IEnumerable<Observation> pzzzzzzzzzzzq_ = context.Operators.SortBy<Observation>(pzzzzzzzzzzzo_, pzzzzzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
        Observation pzzzzzzzzzzzr_ = context.Operators.Last<Observation>(pzzzzzzzzzzzq_);
        DataType pzzzzzzzzzzzs_ = pzzzzzzzzzzzr_?.Value;
        object pzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzs_);

        return pzzzzzzzzzzzt_ as CqlDateTime;
    }


    [CqlExpressionDefinition("calculatedGestationalAge")]
    public int? calculatedGestationalAge(CqlContext context, Encounter TheEncounter)
    {
        CqlDateTime szzzzzzzzzzzc_ = this.lastTimeOfDelivery(context, TheEncounter);
        CqlDateTime szzzzzzzzzzzd_ = this.lastEstimatedDeliveryDate(context, TheEncounter);
        int? szzzzzzzzzzze_ = context.Operators.DifferenceBetween(szzzzzzzzzzzc_, szzzzzzzzzzzd_, "day");
        int? szzzzzzzzzzzf_ = context.Operators.Subtract(280, szzzzzzzzzzze_);
        int? szzzzzzzzzzzg_ = context.Operators.TruncatedDivide(szzzzzzzzzzzf_, 7);

        return szzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Variable Calculated Gestational Age")]
    public IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> Variable_Calculated_Gestational_Age(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzh_ = this.Delivery_Encounter_with_Age_Range(context);
        (CqlTupleMetadata, string EncounterID, int? CalculatedCGA)? szzzzzzzzzzzi_(Encounter DeliveryEncounter)
        {
            Id szzzzzzzzzzzl_ = DeliveryEncounter?.IdElement;
            string szzzzzzzzzzzm_ = szzzzzzzzzzzl_?.Value;
            int? szzzzzzzzzzzn_ = this.calculatedGestationalAge(context, DeliveryEncounter);
            (CqlTupleMetadata, string EncounterID, int? CalculatedCGA)? szzzzzzzzzzzo_ = (CqlTupleMetadata_DjNbNOhJZXGJDNQeiTBabEOBB, szzzzzzzzzzzm_, szzzzzzzzzzzn_);

            return szzzzzzzzzzzo_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> szzzzzzzzzzzj_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?>(szzzzzzzzzzzh_, szzzzzzzzzzzi_);
        IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> szzzzzzzzzzzk_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?>(szzzzzzzzzzzj_);

        return szzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("lastEstimatedGestationalAge")]
    public CqlQuantity lastEstimatedGestationalAge(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet szzzzzzzzzzzp_ = this.Estimated_Gestational_Age_at_Delivery(context);
        IEnumerable<Observation> szzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, szzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? szzzzzzzzzzzr_(Observation EstimatedGestationalAge)
        {
            object szzzzzzzzzzzy_()
            {
                bool uzzzzzzzzzzzi_()
                {
                    DataType uzzzzzzzzzzzl_ = EstimatedGestationalAge?.Effective;
                    object uzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzl_);
                    bool uzzzzzzzzzzzn_ = uzzzzzzzzzzzm_ is CqlDateTime;

                    return uzzzzzzzzzzzn_;
                };
                bool uzzzzzzzzzzzj_()
                {
                    DataType uzzzzzzzzzzzo_ = EstimatedGestationalAge?.Effective;
                    object uzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzo_);
                    bool uzzzzzzzzzzzq_ = uzzzzzzzzzzzp_ is CqlInterval<CqlDateTime>;

                    return uzzzzzzzzzzzq_;
                };
                bool uzzzzzzzzzzzk_()
                {
                    DataType uzzzzzzzzzzzr_ = EstimatedGestationalAge?.Effective;
                    object uzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzr_);
                    bool uzzzzzzzzzzzt_ = uzzzzzzzzzzzs_ is CqlDateTime;

                    return uzzzzzzzzzzzt_;
                };
                if (uzzzzzzzzzzzi_())
                {
                    DataType uzzzzzzzzzzzu_ = EstimatedGestationalAge?.Effective;
                    object uzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzu_);

                    return (uzzzzzzzzzzzv_ as CqlDateTime) as object;
                }
                else if (uzzzzzzzzzzzj_())
                {
                    DataType uzzzzzzzzzzzw_ = EstimatedGestationalAge?.Effective;
                    object uzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzw_);

                    return (uzzzzzzzzzzzx_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (uzzzzzzzzzzzk_())
                {
                    DataType uzzzzzzzzzzzy_ = EstimatedGestationalAge?.Effective;
                    object uzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzy_);

                    return (uzzzzzzzzzzzz_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime szzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzzzzzzy_());
            CqlDateTime tzzzzzzzzzzza_ = this.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity tzzzzzzzzzzzb_ = context.Operators.Quantity(24m, "hours");
            CqlDateTime tzzzzzzzzzzzc_ = context.Operators.Subtract(tzzzzzzzzzzza_, tzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzze_ = context.Operators.Interval(tzzzzzzzzzzzc_, tzzzzzzzzzzza_, true, true);
            bool? tzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzz_, tzzzzzzzzzzze_, default);
            bool? tzzzzzzzzzzzh_ = context.Operators.Not((bool?)(tzzzzzzzzzzza_ is null));
            bool? tzzzzzzzzzzzi_ = context.Operators.And(tzzzzzzzzzzzf_, tzzzzzzzzzzzh_);
            DataType tzzzzzzzzzzzj_ = EstimatedGestationalAge?.Value;
            object tzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzj_);
            bool? tzzzzzzzzzzzl_ = context.Operators.Not((bool?)(tzzzzzzzzzzzk_ is null));
            bool? tzzzzzzzzzzzm_ = context.Operators.And(tzzzzzzzzzzzi_, tzzzzzzzzzzzl_);
            Code<ObservationStatus> tzzzzzzzzzzzn_ = EstimatedGestationalAge?.StatusElement;
            ObservationStatus? tzzzzzzzzzzzo_ = tzzzzzzzzzzzn_?.Value;
            Code<ObservationStatus> tzzzzzzzzzzzp_ = context.Operators.Convert<Code<ObservationStatus>>(tzzzzzzzzzzzo_);
            string tzzzzzzzzzzzq_ = context.Operators.Convert<string>(tzzzzzzzzzzzp_);
            string[] tzzzzzzzzzzzr_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? tzzzzzzzzzzzs_ = context.Operators.In<string>(tzzzzzzzzzzzq_, tzzzzzzzzzzzr_ as IEnumerable<string>);
            bool? tzzzzzzzzzzzt_ = context.Operators.And(tzzzzzzzzzzzm_, tzzzzzzzzzzzs_);
            object tzzzzzzzzzzzu_()
            {
                bool vzzzzzzzzzzza_()
                {
                    DataType vzzzzzzzzzzzd_ = EstimatedGestationalAge?.Effective;
                    object vzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzd_);
                    bool vzzzzzzzzzzzf_ = vzzzzzzzzzzze_ is CqlDateTime;

                    return vzzzzzzzzzzzf_;
                };
                bool vzzzzzzzzzzzb_()
                {
                    DataType vzzzzzzzzzzzg_ = EstimatedGestationalAge?.Effective;
                    object vzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzg_);
                    bool vzzzzzzzzzzzi_ = vzzzzzzzzzzzh_ is CqlInterval<CqlDateTime>;

                    return vzzzzzzzzzzzi_;
                };
                bool vzzzzzzzzzzzc_()
                {
                    DataType vzzzzzzzzzzzj_ = EstimatedGestationalAge?.Effective;
                    object vzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzj_);
                    bool vzzzzzzzzzzzl_ = vzzzzzzzzzzzk_ is CqlDateTime;

                    return vzzzzzzzzzzzl_;
                };
                if (vzzzzzzzzzzza_())
                {
                    DataType vzzzzzzzzzzzm_ = EstimatedGestationalAge?.Effective;
                    object vzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzm_);

                    return (vzzzzzzzzzzzn_ as CqlDateTime) as object;
                }
                else if (vzzzzzzzzzzzb_())
                {
                    DataType vzzzzzzzzzzzo_ = EstimatedGestationalAge?.Effective;
                    object vzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzo_);

                    return (vzzzzzzzzzzzp_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (vzzzzzzzzzzzc_())
                {
                    DataType vzzzzzzzzzzzq_ = EstimatedGestationalAge?.Effective;
                    object vzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzq_);

                    return (vzzzzzzzzzzzr_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime tzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzu_());
            bool? tzzzzzzzzzzzx_ = context.Operators.SameAs(tzzzzzzzzzzzv_, tzzzzzzzzzzza_, "day");
            object tzzzzzzzzzzzy_()
            {
                bool vzzzzzzzzzzzs_()
                {
                    DataType vzzzzzzzzzzzv_ = EstimatedGestationalAge?.Effective;
                    object vzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzv_);
                    bool vzzzzzzzzzzzx_ = vzzzzzzzzzzzw_ is CqlDateTime;

                    return vzzzzzzzzzzzx_;
                };
                bool vzzzzzzzzzzzt_()
                {
                    DataType vzzzzzzzzzzzy_ = EstimatedGestationalAge?.Effective;
                    object vzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzy_);
                    bool wzzzzzzzzzzza_ = vzzzzzzzzzzzz_ is CqlInterval<CqlDateTime>;

                    return wzzzzzzzzzzza_;
                };
                bool vzzzzzzzzzzzu_()
                {
                    DataType wzzzzzzzzzzzb_ = EstimatedGestationalAge?.Effective;
                    object wzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzb_);
                    bool wzzzzzzzzzzzd_ = wzzzzzzzzzzzc_ is CqlDateTime;

                    return wzzzzzzzzzzzd_;
                };
                if (vzzzzzzzzzzzs_())
                {
                    DataType wzzzzzzzzzzze_ = EstimatedGestationalAge?.Effective;
                    object wzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzze_);

                    return (wzzzzzzzzzzzf_ as CqlDateTime) as object;
                }
                else if (vzzzzzzzzzzzt_())
                {
                    DataType wzzzzzzzzzzzg_ = EstimatedGestationalAge?.Effective;
                    object wzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzg_);

                    return (wzzzzzzzzzzzh_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (vzzzzzzzzzzzu_())
                {
                    DataType wzzzzzzzzzzzi_ = EstimatedGestationalAge?.Effective;
                    object wzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzi_);

                    return (wzzzzzzzzzzzj_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime tzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzy_());
            CqlInterval<CqlDateTime> uzzzzzzzzzzza_ = this.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
            bool? uzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzz_, uzzzzzzzzzzza_, default);
            bool? uzzzzzzzzzzzc_ = context.Operators.And(tzzzzzzzzzzzx_, uzzzzzzzzzzzb_);
            object uzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzj_);
            bool? uzzzzzzzzzzzf_ = context.Operators.Not((bool?)(uzzzzzzzzzzze_ is null));
            bool? uzzzzzzzzzzzg_ = context.Operators.And(uzzzzzzzzzzzc_, uzzzzzzzzzzzf_);
            bool? uzzzzzzzzzzzh_ = context.Operators.Or(tzzzzzzzzzzzt_, uzzzzzzzzzzzg_);

            return uzzzzzzzzzzzh_;
        };
        IEnumerable<Observation> szzzzzzzzzzzs_ = context.Operators.Where<Observation>(szzzzzzzzzzzq_, szzzzzzzzzzzr_);
        object szzzzzzzzzzzt_(Observation @this)
        {
            object wzzzzzzzzzzzk_()
            {
                bool wzzzzzzzzzzzm_()
                {
                    DataType wzzzzzzzzzzzp_ = @this?.Effective;
                    object wzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzp_);
                    bool wzzzzzzzzzzzr_ = wzzzzzzzzzzzq_ is CqlDateTime;

                    return wzzzzzzzzzzzr_;
                };
                bool wzzzzzzzzzzzn_()
                {
                    DataType wzzzzzzzzzzzs_ = @this?.Effective;
                    object wzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzs_);
                    bool wzzzzzzzzzzzu_ = wzzzzzzzzzzzt_ is CqlInterval<CqlDateTime>;

                    return wzzzzzzzzzzzu_;
                };
                bool wzzzzzzzzzzzo_()
                {
                    DataType wzzzzzzzzzzzv_ = @this?.Effective;
                    object wzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzv_);
                    bool wzzzzzzzzzzzx_ = wzzzzzzzzzzzw_ is CqlDateTime;

                    return wzzzzzzzzzzzx_;
                };
                if (wzzzzzzzzzzzm_())
                {
                    DataType wzzzzzzzzzzzy_ = @this?.Effective;
                    object wzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzy_);

                    return (wzzzzzzzzzzzz_ as CqlDateTime) as object;
                }
                else if (wzzzzzzzzzzzn_())
                {
                    DataType xzzzzzzzzzzza_ = @this?.Effective;
                    object xzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzza_);

                    return (xzzzzzzzzzzzb_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (wzzzzzzzzzzzo_())
                {
                    DataType xzzzzzzzzzzzc_ = @this?.Effective;
                    object xzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzc_);

                    return (xzzzzzzzzzzzd_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime wzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzk_());

            return wzzzzzzzzzzzl_;
        };
        IEnumerable<Observation> szzzzzzzzzzzu_ = context.Operators.SortBy<Observation>(szzzzzzzzzzzs_, szzzzzzzzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
        Observation szzzzzzzzzzzv_ = context.Operators.Last<Observation>(szzzzzzzzzzzu_);
        DataType szzzzzzzzzzzw_ = szzzzzzzzzzzv_?.Value;
        object szzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzw_);

        return szzzzzzzzzzzx_ as CqlQuantity;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_DjNbNOhJZXGJDNQeiTBabEOBB = new(
        [typeof(string), typeof(int?)],
        ["EncounterID", "CalculatedCGA"]);

    #endregion CqlTupleMetadata Properties

}
