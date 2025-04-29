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
        CqlDateTime ezzzzzzzzzzzzzzzl_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime ezzzzzzzzzzzzzzzm_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzn_ = context.Operators.Interval(ezzzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzzm_, true, true);
        object ezzzzzzzzzzzzzzzo_ = context.ResolveParameter("PCMaternal-5.19.000", "Measurement Period", ezzzzzzzzzzzzzzzn_);

        return (CqlInterval<CqlDateTime>)ezzzzzzzzzzzzzzzo_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ezzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient ezzzzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<Patient>(ezzzzzzzzzzzzzzzp_);

        return ezzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Encounter with Age Range")]
    public IEnumerable<Encounter> Encounter_with_Age_Range(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzr_ = CQMCommon_2_2_000.Instance.Inpatient_Encounter(context);
        bool? ezzzzzzzzzzzzzzzs_(Encounter InpatientEncounter)
        {
            Patient ezzzzzzzzzzzzzzzu_ = this.Patient(context);
            Date ezzzzzzzzzzzzzzzv_ = ezzzzzzzzzzzzzzzu_?.BirthDateElement;
            string ezzzzzzzzzzzzzzzw_ = ezzzzzzzzzzzzzzzv_?.Value;
            CqlDate ezzzzzzzzzzzzzzzx_ = context.Operators.ConvertStringToDate(ezzzzzzzzzzzzzzzw_);
            Period ezzzzzzzzzzzzzzzy_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzy_);
            CqlDateTime fzzzzzzzzzzzzzzza_ = context.Operators.Start(ezzzzzzzzzzzzzzzz_);
            CqlDate fzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzza_);
            int? fzzzzzzzzzzzzzzzc_ = context.Operators.CalculateAgeAt(ezzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzzb_, "year");
            CqlInterval<int?> fzzzzzzzzzzzzzzzd_ = context.Operators.Interval(8, 65, true, false);
            bool? fzzzzzzzzzzzzzzze_ = context.Operators.In<int?>(fzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzd_, default);

            return fzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzzzr_, ezzzzzzzzzzzzzzzs_);

        return ezzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("hospitalizationWithEDOBTriageObservation")]
    public CqlInterval<CqlDateTime> hospitalizationWithEDOBTriageObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] fzzzzzzzzzzzzzzzf_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzg_(Encounter Visit)
        {
            CqlValueSet fzzzzzzzzzzzzzzzk_ = this.ED_Visit_and_OB_Triage(context);
            IEnumerable<Encounter> fzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? fzzzzzzzzzzzzzzzm_(Encounter LastEDOBTriage)
            {
                Period gzzzzzzzzzzzzzzzl_ = LastEDOBTriage?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzl_);
                CqlDateTime gzzzzzzzzzzzzzzzn_ = context.Operators.End(gzzzzzzzzzzzzzzzm_);
                CqlValueSet gzzzzzzzzzzzzzzzo_ = this.Observation_Services(context);
                IEnumerable<Encounter> gzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? gzzzzzzzzzzzzzzzq_(Encounter LastObs)
                {
                    Period izzzzzzzzzzzzzzzm_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzm_);
                    CqlDateTime izzzzzzzzzzzzzzzo_ = context.Operators.End(izzzzzzzzzzzzzzzn_);
                    Period izzzzzzzzzzzzzzzp_ = Visit?.Period;
                    CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzp_);
                    CqlDateTime izzzzzzzzzzzzzzzr_ = context.Operators.Start(izzzzzzzzzzzzzzzq_);
                    CqlQuantity izzzzzzzzzzzzzzzs_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime izzzzzzzzzzzzzzzt_ = context.Operators.Subtract(izzzzzzzzzzzzzzzr_, izzzzzzzzzzzzzzzs_);
                    CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzp_);
                    CqlDateTime izzzzzzzzzzzzzzzw_ = context.Operators.Start(izzzzzzzzzzzzzzzv_);
                    CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzx_ = context.Operators.Interval(izzzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzzw_, true, true);
                    bool? izzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzo_, izzzzzzzzzzzzzzzx_, default);
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzp_);
                    CqlDateTime jzzzzzzzzzzzzzzzb_ = context.Operators.Start(jzzzzzzzzzzzzzzza_);
                    bool? jzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzb_ is null));
                    bool? jzzzzzzzzzzzzzzzd_ = context.Operators.And(izzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzc_);
                    Code<Encounter.EncounterStatus> jzzzzzzzzzzzzzzze_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? jzzzzzzzzzzzzzzzf_ = jzzzzzzzzzzzzzzze_?.Value;
                    Code<Encounter.EncounterStatus> jzzzzzzzzzzzzzzzg_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jzzzzzzzzzzzzzzzf_);
                    bool? jzzzzzzzzzzzzzzzh_ = context.Operators.Equal(jzzzzzzzzzzzzzzzg_, "finished");
                    bool? jzzzzzzzzzzzzzzzi_ = context.Operators.And(jzzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzzzh_);

                    return jzzzzzzzzzzzzzzzi_;
                };
                IEnumerable<Encounter> gzzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzzp_, gzzzzzzzzzzzzzzzq_);
                object gzzzzzzzzzzzzzzzs_(Encounter @this)
                {
                    Period jzzzzzzzzzzzzzzzj_ = @this?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzj_);
                    CqlDateTime jzzzzzzzzzzzzzzzl_ = context.Operators.End(jzzzzzzzzzzzzzzzk_);

                    return jzzzzzzzzzzzzzzzl_;
                };
                IEnumerable<Encounter> gzzzzzzzzzzzzzzzt_ = context.Operators.SortBy<Encounter>(gzzzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter gzzzzzzzzzzzzzzzu_ = context.Operators.Last<Encounter>(gzzzzzzzzzzzzzzzt_);
                Period gzzzzzzzzzzzzzzzv_ = gzzzzzzzzzzzzzzzu_?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzv_);
                CqlDateTime gzzzzzzzzzzzzzzzx_ = context.Operators.Start(gzzzzzzzzzzzzzzzw_);
                Period gzzzzzzzzzzzzzzzy_ = Visit?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzy_);
                CqlDateTime hzzzzzzzzzzzzzzza_ = context.Operators.Start(gzzzzzzzzzzzzzzzz_);
                CqlQuantity hzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime hzzzzzzzzzzzzzzzc_ = context.Operators.Subtract(gzzzzzzzzzzzzzzzx_ ?? hzzzzzzzzzzzzzzza_, hzzzzzzzzzzzzzzzb_);
                IEnumerable<Encounter> hzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? hzzzzzzzzzzzzzzzf_(Encounter LastObs)
                {
                    Period jzzzzzzzzzzzzzzzm_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzm_);
                    CqlDateTime jzzzzzzzzzzzzzzzo_ = context.Operators.End(jzzzzzzzzzzzzzzzn_);
                    Period jzzzzzzzzzzzzzzzp_ = Visit?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzp_);
                    CqlDateTime jzzzzzzzzzzzzzzzr_ = context.Operators.Start(jzzzzzzzzzzzzzzzq_);
                    CqlQuantity jzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime jzzzzzzzzzzzzzzzt_ = context.Operators.Subtract(jzzzzzzzzzzzzzzzr_, jzzzzzzzzzzzzzzzs_);
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzp_);
                    CqlDateTime jzzzzzzzzzzzzzzzw_ = context.Operators.Start(jzzzzzzzzzzzzzzzv_);
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzx_ = context.Operators.Interval(jzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzw_, true, true);
                    bool? jzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzo_, jzzzzzzzzzzzzzzzx_, default);
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzp_);
                    CqlDateTime kzzzzzzzzzzzzzzzb_ = context.Operators.Start(kzzzzzzzzzzzzzzza_);
                    bool? kzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzb_ is null));
                    bool? kzzzzzzzzzzzzzzzd_ = context.Operators.And(jzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzzc_);
                    Code<Encounter.EncounterStatus> kzzzzzzzzzzzzzzze_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? kzzzzzzzzzzzzzzzf_ = kzzzzzzzzzzzzzzze_?.Value;
                    Code<Encounter.EncounterStatus> kzzzzzzzzzzzzzzzg_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(kzzzzzzzzzzzzzzzf_);
                    bool? kzzzzzzzzzzzzzzzh_ = context.Operators.Equal(kzzzzzzzzzzzzzzzg_, "finished");
                    bool? kzzzzzzzzzzzzzzzi_ = context.Operators.And(kzzzzzzzzzzzzzzzd_, kzzzzzzzzzzzzzzzh_);

                    return kzzzzzzzzzzzzzzzi_;
                };
                IEnumerable<Encounter> hzzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzze_, hzzzzzzzzzzzzzzzf_);
                object hzzzzzzzzzzzzzzzh_(Encounter @this)
                {
                    Period kzzzzzzzzzzzzzzzj_ = @this?.Period;
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzj_);
                    CqlDateTime kzzzzzzzzzzzzzzzl_ = context.Operators.End(kzzzzzzzzzzzzzzzk_);

                    return kzzzzzzzzzzzzzzzl_;
                };
                IEnumerable<Encounter> hzzzzzzzzzzzzzzzi_ = context.Operators.SortBy<Encounter>(hzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter hzzzzzzzzzzzzzzzj_ = context.Operators.Last<Encounter>(hzzzzzzzzzzzzzzzi_);
                Period hzzzzzzzzzzzzzzzk_ = hzzzzzzzzzzzzzzzj_?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzk_);
                CqlDateTime hzzzzzzzzzzzzzzzm_ = context.Operators.Start(hzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzy_);
                CqlDateTime hzzzzzzzzzzzzzzzp_ = context.Operators.Start(hzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzq_ = context.Operators.Interval(hzzzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzzzm_ ?? hzzzzzzzzzzzzzzzp_, true, true);
                bool? hzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzn_, hzzzzzzzzzzzzzzzq_, default);
                IEnumerable<Encounter> hzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? hzzzzzzzzzzzzzzzu_(Encounter LastObs)
                {
                    Period kzzzzzzzzzzzzzzzm_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzm_);
                    CqlDateTime kzzzzzzzzzzzzzzzo_ = context.Operators.End(kzzzzzzzzzzzzzzzn_);
                    Period kzzzzzzzzzzzzzzzp_ = Visit?.Period;
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzp_);
                    CqlDateTime kzzzzzzzzzzzzzzzr_ = context.Operators.Start(kzzzzzzzzzzzzzzzq_);
                    CqlQuantity kzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime kzzzzzzzzzzzzzzzt_ = context.Operators.Subtract(kzzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzzs_);
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzp_);
                    CqlDateTime kzzzzzzzzzzzzzzzw_ = context.Operators.Start(kzzzzzzzzzzzzzzzv_);
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzx_ = context.Operators.Interval(kzzzzzzzzzzzzzzzt_, kzzzzzzzzzzzzzzzw_, true, true);
                    bool? kzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzzzx_, default);
                    CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzp_);
                    CqlDateTime lzzzzzzzzzzzzzzzb_ = context.Operators.Start(lzzzzzzzzzzzzzzza_);
                    bool? lzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzb_ is null));
                    bool? lzzzzzzzzzzzzzzzd_ = context.Operators.And(kzzzzzzzzzzzzzzzy_, lzzzzzzzzzzzzzzzc_);
                    Code<Encounter.EncounterStatus> lzzzzzzzzzzzzzzze_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? lzzzzzzzzzzzzzzzf_ = lzzzzzzzzzzzzzzze_?.Value;
                    Code<Encounter.EncounterStatus> lzzzzzzzzzzzzzzzg_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lzzzzzzzzzzzzzzzf_);
                    bool? lzzzzzzzzzzzzzzzh_ = context.Operators.Equal(lzzzzzzzzzzzzzzzg_, "finished");
                    bool? lzzzzzzzzzzzzzzzi_ = context.Operators.And(lzzzzzzzzzzzzzzzd_, lzzzzzzzzzzzzzzzh_);

                    return lzzzzzzzzzzzzzzzi_;
                };
                IEnumerable<Encounter> hzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzzu_);
                object hzzzzzzzzzzzzzzzw_(Encounter @this)
                {
                    Period lzzzzzzzzzzzzzzzj_ = @this?.Period;
                    CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzj_);
                    CqlDateTime lzzzzzzzzzzzzzzzl_ = context.Operators.End(lzzzzzzzzzzzzzzzk_);

                    return lzzzzzzzzzzzzzzzl_;
                };
                IEnumerable<Encounter> hzzzzzzzzzzzzzzzx_ = context.Operators.SortBy<Encounter>(hzzzzzzzzzzzzzzzv_, hzzzzzzzzzzzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter hzzzzzzzzzzzzzzzy_ = context.Operators.Last<Encounter>(hzzzzzzzzzzzzzzzx_);
                Period hzzzzzzzzzzzzzzzz_ = hzzzzzzzzzzzzzzzy_?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzz_);
                CqlDateTime izzzzzzzzzzzzzzzb_ = context.Operators.Start(izzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzy_);
                CqlDateTime izzzzzzzzzzzzzzze_ = context.Operators.Start(izzzzzzzzzzzzzzzd_);
                bool? izzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)((izzzzzzzzzzzzzzzb_ ?? izzzzzzzzzzzzzzze_) is null));
                bool? izzzzzzzzzzzzzzzg_ = context.Operators.And(hzzzzzzzzzzzzzzzr_, izzzzzzzzzzzzzzzf_);
                Code<Encounter.EncounterStatus> izzzzzzzzzzzzzzzh_ = LastEDOBTriage?.StatusElement;
                Encounter.EncounterStatus? izzzzzzzzzzzzzzzi_ = izzzzzzzzzzzzzzzh_?.Value;
                Code<Encounter.EncounterStatus> izzzzzzzzzzzzzzzj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(izzzzzzzzzzzzzzzi_);
                bool? izzzzzzzzzzzzzzzk_ = context.Operators.Equal(izzzzzzzzzzzzzzzj_, "finished");
                bool? izzzzzzzzzzzzzzzl_ = context.Operators.And(izzzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzzk_);

                return izzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Encounter> fzzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzzm_);
            object fzzzzzzzzzzzzzzzo_(Encounter @this)
            {
                Period lzzzzzzzzzzzzzzzm_ = @this?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzm_);
                CqlDateTime lzzzzzzzzzzzzzzzo_ = context.Operators.End(lzzzzzzzzzzzzzzzn_);

                return lzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Encounter> fzzzzzzzzzzzzzzzp_ = context.Operators.SortBy<Encounter>(fzzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzzo_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter fzzzzzzzzzzzzzzzq_ = context.Operators.Last<Encounter>(fzzzzzzzzzzzzzzzp_);
            Period fzzzzzzzzzzzzzzzr_ = fzzzzzzzzzzzzzzzq_?.Period;
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzr_);
            CqlDateTime fzzzzzzzzzzzzzzzt_ = context.Operators.Start(fzzzzzzzzzzzzzzzs_);
            CqlValueSet fzzzzzzzzzzzzzzzu_ = this.Observation_Services(context);
            IEnumerable<Encounter> fzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? fzzzzzzzzzzzzzzzw_(Encounter LastObs)
            {
                Period lzzzzzzzzzzzzzzzp_ = LastObs?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzp_);
                CqlDateTime lzzzzzzzzzzzzzzzr_ = context.Operators.End(lzzzzzzzzzzzzzzzq_);
                Period lzzzzzzzzzzzzzzzs_ = Visit?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzs_);
                CqlDateTime lzzzzzzzzzzzzzzzu_ = context.Operators.Start(lzzzzzzzzzzzzzzzt_);
                CqlQuantity lzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime lzzzzzzzzzzzzzzzw_ = context.Operators.Subtract(lzzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzs_);
                CqlDateTime lzzzzzzzzzzzzzzzz_ = context.Operators.Start(lzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzza_ = context.Operators.Interval(lzzzzzzzzzzzzzzzw_, lzzzzzzzzzzzzzzzz_, true, true);
                bool? mzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzza_, default);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzs_);
                CqlDateTime mzzzzzzzzzzzzzzze_ = context.Operators.Start(mzzzzzzzzzzzzzzzd_);
                bool? mzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzze_ is null));
                bool? mzzzzzzzzzzzzzzzg_ = context.Operators.And(mzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzf_);
                Code<Encounter.EncounterStatus> mzzzzzzzzzzzzzzzh_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? mzzzzzzzzzzzzzzzi_ = mzzzzzzzzzzzzzzzh_?.Value;
                Code<Encounter.EncounterStatus> mzzzzzzzzzzzzzzzj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(mzzzzzzzzzzzzzzzi_);
                bool? mzzzzzzzzzzzzzzzk_ = context.Operators.Equal(mzzzzzzzzzzzzzzzj_, "finished");
                bool? mzzzzzzzzzzzzzzzl_ = context.Operators.And(mzzzzzzzzzzzzzzzg_, mzzzzzzzzzzzzzzzk_);

                return mzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Encounter> fzzzzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzw_);
            object fzzzzzzzzzzzzzzzy_(Encounter @this)
            {
                Period mzzzzzzzzzzzzzzzm_ = @this?.Period;
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzm_);
                CqlDateTime mzzzzzzzzzzzzzzzo_ = context.Operators.End(mzzzzzzzzzzzzzzzn_);

                return mzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Encounter> fzzzzzzzzzzzzzzzz_ = context.Operators.SortBy<Encounter>(fzzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter gzzzzzzzzzzzzzzza_ = context.Operators.Last<Encounter>(fzzzzzzzzzzzzzzzz_);
            Period gzzzzzzzzzzzzzzzb_ = gzzzzzzzzzzzzzzza_?.Period;
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzb_);
            CqlDateTime gzzzzzzzzzzzzzzzd_ = context.Operators.Start(gzzzzzzzzzzzzzzzc_);
            Period gzzzzzzzzzzzzzzze_ = Visit?.Period;
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzze_);
            CqlDateTime gzzzzzzzzzzzzzzzg_ = context.Operators.Start(gzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzze_);
            CqlDateTime gzzzzzzzzzzzzzzzj_ = context.Operators.End(gzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzk_ = context.Operators.Interval(fzzzzzzzzzzzzzzzt_ ?? gzzzzzzzzzzzzzzzd_ ?? gzzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzzj_, true, true);

            return gzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> fzzzzzzzzzzzzzzzh_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)fzzzzzzzzzzzzzzzf_, fzzzzzzzzzzzzzzzg_);
        IEnumerable<CqlInterval<CqlDateTime>> fzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(fzzzzzzzzzzzzzzzh_);
        CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzj_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(fzzzzzzzzzzzzzzzi_);

        return fzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Delivery Encounter with Age Range")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Age_Range(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzp_ = this.Encounter_with_Age_Range(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzq_(Encounter EncounterWithAge)
        {
            CqlValueSet mzzzzzzzzzzzzzzzs_ = this.Delivery_Procedures(context);
            IEnumerable<Procedure> mzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? mzzzzzzzzzzzzzzzu_(Procedure DeliveryProcedure)
            {
                Code<EventStatus> mzzzzzzzzzzzzzzzy_ = DeliveryProcedure?.StatusElement;
                EventStatus? mzzzzzzzzzzzzzzzz_ = mzzzzzzzzzzzzzzzy_?.Value;
                string nzzzzzzzzzzzzzzza_ = context.Operators.Convert<string>(mzzzzzzzzzzzzzzzz_);
                bool? nzzzzzzzzzzzzzzzb_ = context.Operators.Equal(nzzzzzzzzzzzzzzza_, "completed");
                DataType nzzzzzzzzzzzzzzzc_ = DeliveryProcedure?.Performed;
                object nzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzd_);
                CqlDateTime nzzzzzzzzzzzzzzzf_ = context.Operators.Start(nzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzg_ = this.hospitalizationWithEDOBTriageObservation(context, EncounterWithAge);
                bool? nzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzzg_, default);
                bool? nzzzzzzzzzzzzzzzi_ = context.Operators.And(nzzzzzzzzzzzzzzzb_, nzzzzzzzzzzzzzzzh_);

                return nzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Procedure> mzzzzzzzzzzzzzzzv_ = context.Operators.Where<Procedure>(mzzzzzzzzzzzzzzzt_, mzzzzzzzzzzzzzzzu_);
            Encounter mzzzzzzzzzzzzzzzw_(Procedure DeliveryProcedure) =>
                EncounterWithAge;
            IEnumerable<Encounter> mzzzzzzzzzzzzzzzx_ = context.Operators.Select<Procedure, Encounter>(mzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzw_);

            return mzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzr_ = context.Operators.SelectMany<Encounter, Encounter>(mzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzq_);

        return mzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("lastTimeOfDelivery")]
    public CqlDateTime lastTimeOfDelivery(CqlContext context, Encounter TheEncounter)
    {
        CqlCode nzzzzzzzzzzzzzzzj_ = this.Date_and_time_of_obstetric_delivery(context);
        IEnumerable<CqlCode> nzzzzzzzzzzzzzzzk_ = context.Operators.ToList<CqlCode>(nzzzzzzzzzzzzzzzj_);
        IEnumerable<Observation> nzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, nzzzzzzzzzzzzzzzk_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? nzzzzzzzzzzzzzzzm_(Observation TimeOfDelivery)
        {
            DataType nzzzzzzzzzzzzzzzt_ = TimeOfDelivery?.Value;
            object nzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzt_);
            bool? nzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)((nzzzzzzzzzzzzzzzu_ as CqlDateTime) is null));
            Code<ObservationStatus> nzzzzzzzzzzzzzzzw_ = TimeOfDelivery?.StatusElement;
            ObservationStatus? nzzzzzzzzzzzzzzzx_ = nzzzzzzzzzzzzzzzw_?.Value;
            Code<ObservationStatus> nzzzzzzzzzzzzzzzy_ = context.Operators.Convert<Code<ObservationStatus>>(nzzzzzzzzzzzzzzzx_);
            string nzzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzy_);
            string[] ozzzzzzzzzzzzzzza_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ozzzzzzzzzzzzzzzb_ = context.Operators.In<string>(nzzzzzzzzzzzzzzzz_, ozzzzzzzzzzzzzzza_ as IEnumerable<string>);
            bool? ozzzzzzzzzzzzzzzc_ = context.Operators.And(nzzzzzzzzzzzzzzzv_, ozzzzzzzzzzzzzzzb_);
            object ozzzzzzzzzzzzzzzd_()
            {
                bool ozzzzzzzzzzzzzzzn_()
                {
                    DataType ozzzzzzzzzzzzzzzq_ = TimeOfDelivery?.Effective;
                    object ozzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzq_);
                    bool ozzzzzzzzzzzzzzzs_ = ozzzzzzzzzzzzzzzr_ is CqlDateTime;

                    return ozzzzzzzzzzzzzzzs_;
                };
                bool ozzzzzzzzzzzzzzzo_()
                {
                    DataType ozzzzzzzzzzzzzzzt_ = TimeOfDelivery?.Effective;
                    object ozzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzt_);
                    bool ozzzzzzzzzzzzzzzv_ = ozzzzzzzzzzzzzzzu_ is CqlInterval<CqlDateTime>;

                    return ozzzzzzzzzzzzzzzv_;
                };
                bool ozzzzzzzzzzzzzzzp_()
                {
                    DataType ozzzzzzzzzzzzzzzw_ = TimeOfDelivery?.Effective;
                    object ozzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzw_);
                    bool ozzzzzzzzzzzzzzzy_ = ozzzzzzzzzzzzzzzx_ is CqlDateTime;

                    return ozzzzzzzzzzzzzzzy_;
                };
                if (ozzzzzzzzzzzzzzzn_())
                {
                    DataType ozzzzzzzzzzzzzzzz_ = TimeOfDelivery?.Effective;
                    object pzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzz_);

                    return (pzzzzzzzzzzzzzzza_ as CqlDateTime) as object;
                }
                else if (ozzzzzzzzzzzzzzzo_())
                {
                    DataType pzzzzzzzzzzzzzzzb_ = TimeOfDelivery?.Effective;
                    object pzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzb_);

                    return (pzzzzzzzzzzzzzzzc_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ozzzzzzzzzzzzzzzp_())
                {
                    DataType pzzzzzzzzzzzzzzzd_ = TimeOfDelivery?.Effective;
                    object pzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzd_);

                    return (pzzzzzzzzzzzzzzze_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime ozzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzd_());
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzf_ = this.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
            bool? ozzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzf_, default);
            bool? ozzzzzzzzzzzzzzzh_ = context.Operators.And(ozzzzzzzzzzzzzzzc_, ozzzzzzzzzzzzzzzg_);
            object ozzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzt_);
            bool? ozzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzj_ as CqlDateTime, ozzzzzzzzzzzzzzzf_, default);
            bool? ozzzzzzzzzzzzzzzm_ = context.Operators.And(ozzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzl_);

            return ozzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Observation> nzzzzzzzzzzzzzzzn_ = context.Operators.Where<Observation>(nzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzm_);
        object nzzzzzzzzzzzzzzzo_(Observation @this)
        {
            object pzzzzzzzzzzzzzzzf_()
            {
                bool pzzzzzzzzzzzzzzzh_()
                {
                    DataType pzzzzzzzzzzzzzzzk_ = @this?.Effective;
                    object pzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzk_);
                    bool pzzzzzzzzzzzzzzzm_ = pzzzzzzzzzzzzzzzl_ is CqlDateTime;

                    return pzzzzzzzzzzzzzzzm_;
                };
                bool pzzzzzzzzzzzzzzzi_()
                {
                    DataType pzzzzzzzzzzzzzzzn_ = @this?.Effective;
                    object pzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzn_);
                    bool pzzzzzzzzzzzzzzzp_ = pzzzzzzzzzzzzzzzo_ is CqlInterval<CqlDateTime>;

                    return pzzzzzzzzzzzzzzzp_;
                };
                bool pzzzzzzzzzzzzzzzj_()
                {
                    DataType pzzzzzzzzzzzzzzzq_ = @this?.Effective;
                    object pzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzq_);
                    bool pzzzzzzzzzzzzzzzs_ = pzzzzzzzzzzzzzzzr_ is CqlDateTime;

                    return pzzzzzzzzzzzzzzzs_;
                };
                if (pzzzzzzzzzzzzzzzh_())
                {
                    DataType pzzzzzzzzzzzzzzzt_ = @this?.Effective;
                    object pzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzt_);

                    return (pzzzzzzzzzzzzzzzu_ as CqlDateTime) as object;
                }
                else if (pzzzzzzzzzzzzzzzi_())
                {
                    DataType pzzzzzzzzzzzzzzzv_ = @this?.Effective;
                    object pzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzv_);

                    return (pzzzzzzzzzzzzzzzw_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (pzzzzzzzzzzzzzzzj_())
                {
                    DataType pzzzzzzzzzzzzzzzx_ = @this?.Effective;
                    object pzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzx_);

                    return (pzzzzzzzzzzzzzzzy_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime pzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzzzzzzzzzzf_());

            return pzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Observation> nzzzzzzzzzzzzzzzp_ = context.Operators.SortBy<Observation>(nzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzo_, System.ComponentModel.ListSortDirection.Ascending);
        Observation nzzzzzzzzzzzzzzzq_ = context.Operators.Last<Observation>(nzzzzzzzzzzzzzzzp_);
        DataType nzzzzzzzzzzzzzzzr_ = nzzzzzzzzzzzzzzzq_?.Value;
        object nzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzr_);

        return nzzzzzzzzzzzzzzzs_ as CqlDateTime;
    }


    [CqlExpressionDefinition("lastEstimatedDeliveryDate")]
    public CqlDateTime lastEstimatedDeliveryDate(CqlContext context, Encounter TheEncounter)
    {
        CqlCode pzzzzzzzzzzzzzzzz_ = this.Delivery_date_Estimated(context);
        IEnumerable<CqlCode> qzzzzzzzzzzzzzzza_ = context.Operators.ToList<CqlCode>(pzzzzzzzzzzzzzzzz_);
        IEnumerable<Observation> qzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, qzzzzzzzzzzzzzzza_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? qzzzzzzzzzzzzzzzc_(Observation EstimatedDateOfDelivery)
        {
            DataType qzzzzzzzzzzzzzzzj_ = EstimatedDateOfDelivery?.Value;
            object qzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzj_);
            bool? qzzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)((qzzzzzzzzzzzzzzzk_ as CqlDateTime) is null));
            Code<ObservationStatus> qzzzzzzzzzzzzzzzm_ = EstimatedDateOfDelivery?.StatusElement;
            ObservationStatus? qzzzzzzzzzzzzzzzn_ = qzzzzzzzzzzzzzzzm_?.Value;
            Code<ObservationStatus> qzzzzzzzzzzzzzzzo_ = context.Operators.Convert<Code<ObservationStatus>>(qzzzzzzzzzzzzzzzn_);
            string qzzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzo_);
            string[] qzzzzzzzzzzzzzzzq_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? qzzzzzzzzzzzzzzzr_ = context.Operators.In<string>(qzzzzzzzzzzzzzzzp_, qzzzzzzzzzzzzzzzq_ as IEnumerable<string>);
            bool? qzzzzzzzzzzzzzzzs_ = context.Operators.And(qzzzzzzzzzzzzzzzl_, qzzzzzzzzzzzzzzzr_);
            object qzzzzzzzzzzzzzzzt_()
            {
                bool rzzzzzzzzzzzzzzzf_()
                {
                    DataType rzzzzzzzzzzzzzzzi_ = EstimatedDateOfDelivery?.Effective;
                    object rzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzi_);
                    bool rzzzzzzzzzzzzzzzk_ = rzzzzzzzzzzzzzzzj_ is CqlDateTime;

                    return rzzzzzzzzzzzzzzzk_;
                };
                bool rzzzzzzzzzzzzzzzg_()
                {
                    DataType rzzzzzzzzzzzzzzzl_ = EstimatedDateOfDelivery?.Effective;
                    object rzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzl_);
                    bool rzzzzzzzzzzzzzzzn_ = rzzzzzzzzzzzzzzzm_ is CqlInterval<CqlDateTime>;

                    return rzzzzzzzzzzzzzzzn_;
                };
                bool rzzzzzzzzzzzzzzzh_()
                {
                    DataType rzzzzzzzzzzzzzzzo_ = EstimatedDateOfDelivery?.Effective;
                    object rzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzo_);
                    bool rzzzzzzzzzzzzzzzq_ = rzzzzzzzzzzzzzzzp_ is CqlDateTime;

                    return rzzzzzzzzzzzzzzzq_;
                };
                if (rzzzzzzzzzzzzzzzf_())
                {
                    DataType rzzzzzzzzzzzzzzzr_ = EstimatedDateOfDelivery?.Effective;
                    object rzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzr_);

                    return (rzzzzzzzzzzzzzzzs_ as CqlDateTime) as object;
                }
                else if (rzzzzzzzzzzzzzzzg_())
                {
                    DataType rzzzzzzzzzzzzzzzt_ = EstimatedDateOfDelivery?.Effective;
                    object rzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzt_);

                    return (rzzzzzzzzzzzzzzzu_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (rzzzzzzzzzzzzzzzh_())
                {
                    DataType rzzzzzzzzzzzzzzzv_ = EstimatedDateOfDelivery?.Effective;
                    object rzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzv_);

                    return (rzzzzzzzzzzzzzzzw_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime qzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzzzzzzzzzzzzt_());
            CqlDateTime qzzzzzzzzzzzzzzzv_ = this.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity qzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime qzzzzzzzzzzzzzzzx_ = context.Operators.Subtract(qzzzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzz_ = context.Operators.Interval(qzzzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzzzv_, true, true);
            bool? rzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzu_, qzzzzzzzzzzzzzzzz_, default);
            bool? rzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzv_ is null));
            bool? rzzzzzzzzzzzzzzzd_ = context.Operators.And(rzzzzzzzzzzzzzzza_, rzzzzzzzzzzzzzzzc_);
            bool? rzzzzzzzzzzzzzzze_ = context.Operators.And(qzzzzzzzzzzzzzzzs_, rzzzzzzzzzzzzzzzd_);

            return rzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Observation> qzzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzc_);
        object qzzzzzzzzzzzzzzze_(Observation @this)
        {
            object rzzzzzzzzzzzzzzzx_()
            {
                bool rzzzzzzzzzzzzzzzz_()
                {
                    DataType szzzzzzzzzzzzzzzc_ = @this?.Effective;
                    object szzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzc_);
                    bool szzzzzzzzzzzzzzze_ = szzzzzzzzzzzzzzzd_ is CqlDateTime;

                    return szzzzzzzzzzzzzzze_;
                };
                bool szzzzzzzzzzzzzzza_()
                {
                    DataType szzzzzzzzzzzzzzzf_ = @this?.Effective;
                    object szzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzf_);
                    bool szzzzzzzzzzzzzzzh_ = szzzzzzzzzzzzzzzg_ is CqlInterval<CqlDateTime>;

                    return szzzzzzzzzzzzzzzh_;
                };
                bool szzzzzzzzzzzzzzzb_()
                {
                    DataType szzzzzzzzzzzzzzzi_ = @this?.Effective;
                    object szzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzi_);
                    bool szzzzzzzzzzzzzzzk_ = szzzzzzzzzzzzzzzj_ is CqlDateTime;

                    return szzzzzzzzzzzzzzzk_;
                };
                if (rzzzzzzzzzzzzzzzz_())
                {
                    DataType szzzzzzzzzzzzzzzl_ = @this?.Effective;
                    object szzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzl_);

                    return (szzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                }
                else if (szzzzzzzzzzzzzzza_())
                {
                    DataType szzzzzzzzzzzzzzzn_ = @this?.Effective;
                    object szzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzn_);

                    return (szzzzzzzzzzzzzzzo_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (szzzzzzzzzzzzzzzb_())
                {
                    DataType szzzzzzzzzzzzzzzp_ = @this?.Effective;
                    object szzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzp_);

                    return (szzzzzzzzzzzzzzzq_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime rzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzx_());

            return rzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Observation> qzzzzzzzzzzzzzzzf_ = context.Operators.SortBy<Observation>(qzzzzzzzzzzzzzzzd_, qzzzzzzzzzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
        Observation qzzzzzzzzzzzzzzzg_ = context.Operators.Last<Observation>(qzzzzzzzzzzzzzzzf_);
        DataType qzzzzzzzzzzzzzzzh_ = qzzzzzzzzzzzzzzzg_?.Value;
        object qzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzh_);

        return qzzzzzzzzzzzzzzzi_ as CqlDateTime;
    }


    [CqlExpressionDefinition("calculatedGestationalAge")]
    public int? calculatedGestationalAge(CqlContext context, Encounter TheEncounter)
    {
        CqlDateTime szzzzzzzzzzzzzzzr_ = this.lastTimeOfDelivery(context, TheEncounter);
        CqlDateTime szzzzzzzzzzzzzzzs_ = this.lastEstimatedDeliveryDate(context, TheEncounter);
        int? szzzzzzzzzzzzzzzt_ = context.Operators.DifferenceBetween(szzzzzzzzzzzzzzzr_, szzzzzzzzzzzzzzzs_, "day");
        int? szzzzzzzzzzzzzzzu_ = context.Operators.Subtract(280, szzzzzzzzzzzzzzzt_);
        int? szzzzzzzzzzzzzzzv_ = context.Operators.TruncatedDivide(szzzzzzzzzzzzzzzu_, 7);

        return szzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Variable Calculated Gestational Age")]
    public IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> Variable_Calculated_Gestational_Age(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzzw_ = this.Delivery_Encounter_with_Age_Range(context);
        (CqlTupleMetadata, string EncounterID, int? CalculatedCGA)? szzzzzzzzzzzzzzzx_(Encounter DeliveryEncounter)
        {
            Id tzzzzzzzzzzzzzzza_ = DeliveryEncounter?.IdElement;
            string tzzzzzzzzzzzzzzzb_ = tzzzzzzzzzzzzzzza_?.Value;
            int? tzzzzzzzzzzzzzzzc_ = this.calculatedGestationalAge(context, DeliveryEncounter);
            (CqlTupleMetadata, string EncounterID, int? CalculatedCGA)? tzzzzzzzzzzzzzzzd_ = (CqlTupleMetadata_DjNbNOhJZXGJDNQeiTBabEOBB, tzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzc_);

            return tzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> szzzzzzzzzzzzzzzy_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?>(szzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzx_);
        IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> szzzzzzzzzzzzzzzz_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?>(szzzzzzzzzzzzzzzy_);

        return szzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("lastEstimatedGestationalAge")]
    public CqlQuantity lastEstimatedGestationalAge(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet tzzzzzzzzzzzzzzze_ = this.Estimated_Gestational_Age_at_Delivery(context);
        IEnumerable<Observation> tzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, tzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? tzzzzzzzzzzzzzzzg_(Observation EstimatedGestationalAge)
        {
            object tzzzzzzzzzzzzzzzn_()
            {
                bool uzzzzzzzzzzzzzzzx_()
                {
                    DataType vzzzzzzzzzzzzzzza_ = EstimatedGestationalAge?.Effective;
                    object vzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzza_);
                    bool vzzzzzzzzzzzzzzzc_ = vzzzzzzzzzzzzzzzb_ is CqlDateTime;

                    return vzzzzzzzzzzzzzzzc_;
                };
                bool uzzzzzzzzzzzzzzzy_()
                {
                    DataType vzzzzzzzzzzzzzzzd_ = EstimatedGestationalAge?.Effective;
                    object vzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzd_);
                    bool vzzzzzzzzzzzzzzzf_ = vzzzzzzzzzzzzzzze_ is CqlInterval<CqlDateTime>;

                    return vzzzzzzzzzzzzzzzf_;
                };
                bool uzzzzzzzzzzzzzzzz_()
                {
                    DataType vzzzzzzzzzzzzzzzg_ = EstimatedGestationalAge?.Effective;
                    object vzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzg_);
                    bool vzzzzzzzzzzzzzzzi_ = vzzzzzzzzzzzzzzzh_ is CqlDateTime;

                    return vzzzzzzzzzzzzzzzi_;
                };
                if (uzzzzzzzzzzzzzzzx_())
                {
                    DataType vzzzzzzzzzzzzzzzj_ = EstimatedGestationalAge?.Effective;
                    object vzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzj_);

                    return (vzzzzzzzzzzzzzzzk_ as CqlDateTime) as object;
                }
                else if (uzzzzzzzzzzzzzzzy_())
                {
                    DataType vzzzzzzzzzzzzzzzl_ = EstimatedGestationalAge?.Effective;
                    object vzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzl_);

                    return (vzzzzzzzzzzzzzzzm_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (uzzzzzzzzzzzzzzzz_())
                {
                    DataType vzzzzzzzzzzzzzzzn_ = EstimatedGestationalAge?.Effective;
                    object vzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzn_);

                    return (vzzzzzzzzzzzzzzzo_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime tzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzn_());
            CqlDateTime tzzzzzzzzzzzzzzzp_ = this.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity tzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(24m, "hours");
            CqlDateTime tzzzzzzzzzzzzzzzr_ = context.Operators.Subtract(tzzzzzzzzzzzzzzzp_, tzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzt_ = context.Operators.Interval(tzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzp_, true, true);
            bool? tzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzt_, default);
            bool? tzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzp_ is null));
            bool? tzzzzzzzzzzzzzzzx_ = context.Operators.And(tzzzzzzzzzzzzzzzu_, tzzzzzzzzzzzzzzzw_);
            DataType tzzzzzzzzzzzzzzzy_ = EstimatedGestationalAge?.Value;
            object tzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzy_);
            bool? uzzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzz_ is null));
            bool? uzzzzzzzzzzzzzzzb_ = context.Operators.And(tzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzza_);
            Code<ObservationStatus> uzzzzzzzzzzzzzzzc_ = EstimatedGestationalAge?.StatusElement;
            ObservationStatus? uzzzzzzzzzzzzzzzd_ = uzzzzzzzzzzzzzzzc_?.Value;
            Code<ObservationStatus> uzzzzzzzzzzzzzzze_ = context.Operators.Convert<Code<ObservationStatus>>(uzzzzzzzzzzzzzzzd_);
            string uzzzzzzzzzzzzzzzf_ = context.Operators.Convert<string>(uzzzzzzzzzzzzzzze_);
            string[] uzzzzzzzzzzzzzzzg_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? uzzzzzzzzzzzzzzzh_ = context.Operators.In<string>(uzzzzzzzzzzzzzzzf_, uzzzzzzzzzzzzzzzg_ as IEnumerable<string>);
            bool? uzzzzzzzzzzzzzzzi_ = context.Operators.And(uzzzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzzzh_);
            object uzzzzzzzzzzzzzzzj_()
            {
                bool vzzzzzzzzzzzzzzzp_()
                {
                    DataType vzzzzzzzzzzzzzzzs_ = EstimatedGestationalAge?.Effective;
                    object vzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzs_);
                    bool vzzzzzzzzzzzzzzzu_ = vzzzzzzzzzzzzzzzt_ is CqlDateTime;

                    return vzzzzzzzzzzzzzzzu_;
                };
                bool vzzzzzzzzzzzzzzzq_()
                {
                    DataType vzzzzzzzzzzzzzzzv_ = EstimatedGestationalAge?.Effective;
                    object vzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzv_);
                    bool vzzzzzzzzzzzzzzzx_ = vzzzzzzzzzzzzzzzw_ is CqlInterval<CqlDateTime>;

                    return vzzzzzzzzzzzzzzzx_;
                };
                bool vzzzzzzzzzzzzzzzr_()
                {
                    DataType vzzzzzzzzzzzzzzzy_ = EstimatedGestationalAge?.Effective;
                    object vzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzy_);
                    bool wzzzzzzzzzzzzzzza_ = vzzzzzzzzzzzzzzzz_ is CqlDateTime;

                    return wzzzzzzzzzzzzzzza_;
                };
                if (vzzzzzzzzzzzzzzzp_())
                {
                    DataType wzzzzzzzzzzzzzzzb_ = EstimatedGestationalAge?.Effective;
                    object wzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzb_);

                    return (wzzzzzzzzzzzzzzzc_ as CqlDateTime) as object;
                }
                else if (vzzzzzzzzzzzzzzzq_())
                {
                    DataType wzzzzzzzzzzzzzzzd_ = EstimatedGestationalAge?.Effective;
                    object wzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzd_);

                    return (wzzzzzzzzzzzzzzze_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (vzzzzzzzzzzzzzzzr_())
                {
                    DataType wzzzzzzzzzzzzzzzf_ = EstimatedGestationalAge?.Effective;
                    object wzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzf_);

                    return (wzzzzzzzzzzzzzzzg_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime uzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzj_());
            bool? uzzzzzzzzzzzzzzzm_ = context.Operators.SameAs(uzzzzzzzzzzzzzzzk_, tzzzzzzzzzzzzzzzp_, "day");
            object uzzzzzzzzzzzzzzzn_()
            {
                bool wzzzzzzzzzzzzzzzh_()
                {
                    DataType wzzzzzzzzzzzzzzzk_ = EstimatedGestationalAge?.Effective;
                    object wzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzk_);
                    bool wzzzzzzzzzzzzzzzm_ = wzzzzzzzzzzzzzzzl_ is CqlDateTime;

                    return wzzzzzzzzzzzzzzzm_;
                };
                bool wzzzzzzzzzzzzzzzi_()
                {
                    DataType wzzzzzzzzzzzzzzzn_ = EstimatedGestationalAge?.Effective;
                    object wzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzn_);
                    bool wzzzzzzzzzzzzzzzp_ = wzzzzzzzzzzzzzzzo_ is CqlInterval<CqlDateTime>;

                    return wzzzzzzzzzzzzzzzp_;
                };
                bool wzzzzzzzzzzzzzzzj_()
                {
                    DataType wzzzzzzzzzzzzzzzq_ = EstimatedGestationalAge?.Effective;
                    object wzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzq_);
                    bool wzzzzzzzzzzzzzzzs_ = wzzzzzzzzzzzzzzzr_ is CqlDateTime;

                    return wzzzzzzzzzzzzzzzs_;
                };
                if (wzzzzzzzzzzzzzzzh_())
                {
                    DataType wzzzzzzzzzzzzzzzt_ = EstimatedGestationalAge?.Effective;
                    object wzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzt_);

                    return (wzzzzzzzzzzzzzzzu_ as CqlDateTime) as object;
                }
                else if (wzzzzzzzzzzzzzzzi_())
                {
                    DataType wzzzzzzzzzzzzzzzv_ = EstimatedGestationalAge?.Effective;
                    object wzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzv_);

                    return (wzzzzzzzzzzzzzzzw_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (wzzzzzzzzzzzzzzzj_())
                {
                    DataType wzzzzzzzzzzzzzzzx_ = EstimatedGestationalAge?.Effective;
                    object wzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzx_);

                    return (wzzzzzzzzzzzzzzzy_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime uzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzn_());
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzp_ = this.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
            bool? uzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzo_, uzzzzzzzzzzzzzzzp_, default);
            bool? uzzzzzzzzzzzzzzzr_ = context.Operators.And(uzzzzzzzzzzzzzzzm_, uzzzzzzzzzzzzzzzq_);
            object uzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzy_);
            bool? uzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzzzt_ is null));
            bool? uzzzzzzzzzzzzzzzv_ = context.Operators.And(uzzzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzzzu_);
            bool? uzzzzzzzzzzzzzzzw_ = context.Operators.Or(uzzzzzzzzzzzzzzzi_, uzzzzzzzzzzzzzzzv_);

            return uzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Observation> tzzzzzzzzzzzzzzzh_ = context.Operators.Where<Observation>(tzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzg_);
        object tzzzzzzzzzzzzzzzi_(Observation @this)
        {
            object wzzzzzzzzzzzzzzzz_()
            {
                bool xzzzzzzzzzzzzzzzb_()
                {
                    DataType xzzzzzzzzzzzzzzze_ = @this?.Effective;
                    object xzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzze_);
                    bool xzzzzzzzzzzzzzzzg_ = xzzzzzzzzzzzzzzzf_ is CqlDateTime;

                    return xzzzzzzzzzzzzzzzg_;
                };
                bool xzzzzzzzzzzzzzzzc_()
                {
                    DataType xzzzzzzzzzzzzzzzh_ = @this?.Effective;
                    object xzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzh_);
                    bool xzzzzzzzzzzzzzzzj_ = xzzzzzzzzzzzzzzzi_ is CqlInterval<CqlDateTime>;

                    return xzzzzzzzzzzzzzzzj_;
                };
                bool xzzzzzzzzzzzzzzzd_()
                {
                    DataType xzzzzzzzzzzzzzzzk_ = @this?.Effective;
                    object xzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzk_);
                    bool xzzzzzzzzzzzzzzzm_ = xzzzzzzzzzzzzzzzl_ is CqlDateTime;

                    return xzzzzzzzzzzzzzzzm_;
                };
                if (xzzzzzzzzzzzzzzzb_())
                {
                    DataType xzzzzzzzzzzzzzzzn_ = @this?.Effective;
                    object xzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzn_);

                    return (xzzzzzzzzzzzzzzzo_ as CqlDateTime) as object;
                }
                else if (xzzzzzzzzzzzzzzzc_())
                {
                    DataType xzzzzzzzzzzzzzzzp_ = @this?.Effective;
                    object xzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzp_);

                    return (xzzzzzzzzzzzzzzzq_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (xzzzzzzzzzzzzzzzd_())
                {
                    DataType xzzzzzzzzzzzzzzzr_ = @this?.Effective;
                    object xzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzr_);

                    return (xzzzzzzzzzzzzzzzs_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime xzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzz_());

            return xzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Observation> tzzzzzzzzzzzzzzzj_ = context.Operators.SortBy<Observation>(tzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
        Observation tzzzzzzzzzzzzzzzk_ = context.Operators.Last<Observation>(tzzzzzzzzzzzzzzzj_);
        DataType tzzzzzzzzzzzzzzzl_ = tzzzzzzzzzzzzzzzk_?.Value;
        object tzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzl_);

        return tzzzzzzzzzzzzzzzm_ as CqlQuantity;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_DjNbNOhJZXGJDNQeiTBabEOBB = new(
        [typeof(string), typeof(int?)],
        ["EncounterID", "CalculatedCGA"]);

    #endregion CqlTupleMetadata Properties

}
