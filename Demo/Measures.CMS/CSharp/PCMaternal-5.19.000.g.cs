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
    private static readonly CqlCode _Date_and_time_of_obstetric_delivery = new CqlCode("93857-1", "http://loinc.org");

    [CqlCodeDefinition("Delivery date Estimated", codeId: "11778-8", codeSystem: "http://loinc.org")]
    public CqlCode Delivery_date_Estimated(CqlContext _) => _Delivery_date_Estimated;
    private static readonly CqlCode _Delivery_date_Estimated = new CqlCode("11778-8", "http://loinc.org");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null,
          _Date_and_time_of_obstetric_delivery,
          _Delivery_date_Estimated);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime dzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime dzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzzzzzzf_, true, true);
        object dzzzzzzzzzzzzzzzzzzzzzh_ = context.ResolveParameter("PCMaternal-5.19.000", "Measurement Period", dzzzzzzzzzzzzzzzzzzzzzg_);

        return (CqlInterval<CqlDateTime>)dzzzzzzzzzzzzzzzzzzzzzh_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> dzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient dzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SingletonFrom<Patient>(dzzzzzzzzzzzzzzzzzzzzzi_);

        return dzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Encounter with Age Range")]
    public IEnumerable<Encounter> Encounter_with_Age_Range(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzk_ = CQMCommon_2_2_000.Instance.Inpatient_Encounter(context);
        bool? dzzzzzzzzzzzzzzzzzzzzzl_(Encounter InpatientEncounter)
        {
            Patient dzzzzzzzzzzzzzzzzzzzzzn_ = this.Patient(context);
            Date dzzzzzzzzzzzzzzzzzzzzzo_ = dzzzzzzzzzzzzzzzzzzzzzn_?.BirthDateElement;
            string dzzzzzzzzzzzzzzzzzzzzzp_ = dzzzzzzzzzzzzzzzzzzzzzo_?.Value;
            CqlDate dzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertStringToDate(dzzzzzzzzzzzzzzzzzzzzzp_);
            Period dzzzzzzzzzzzzzzzzzzzzzr_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDate dzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzzzzzzzt_);
            int? dzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.CalculateAgeAt(dzzzzzzzzzzzzzzzzzzzzzq_, dzzzzzzzzzzzzzzzzzzzzzu_, "year");
            CqlInterval<int?> dzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(8, 65, true, false);
            bool? dzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<int?>(dzzzzzzzzzzzzzzzzzzzzzv_, dzzzzzzzzzzzzzzzzzzzzzw_, default);

            return dzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzzk_, dzzzzzzzzzzzzzzzzzzzzzl_);

        return dzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("hospitalizationWithEDOBTriageObservation")]
    public CqlInterval<CqlDateTime> hospitalizationWithEDOBTriageObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] dzzzzzzzzzzzzzzzzzzzzzy_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzz_(Encounter Visit)
        {
            CqlValueSet ezzzzzzzzzzzzzzzzzzzzzd_ = this.ED_Visit_and_OB_Triage(context);
            IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? ezzzzzzzzzzzzzzzzzzzzzf_(Encounter LastEDOBTriage)
            {
                Period fzzzzzzzzzzzzzzzzzzzzze_ = LastEDOBTriage?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.End(fzzzzzzzzzzzzzzzzzzzzzf_);
                CqlValueSet fzzzzzzzzzzzzzzzzzzzzzh_ = this.Observation_Services(context);
                IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? fzzzzzzzzzzzzzzzzzzzzzj_(Encounter LastObs)
                {
                    Period hzzzzzzzzzzzzzzzzzzzzzf_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzf_);
                    CqlDateTime hzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.End(hzzzzzzzzzzzzzzzzzzzzzg_);
                    Period hzzzzzzzzzzzzzzzzzzzzzi_ = Visit?.Period;
                    CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzi_);
                    CqlDateTime hzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzj_);
                    CqlQuantity hzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime hzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(hzzzzzzzzzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzzzzzzzzzl_);
                    CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzi_);
                    CqlDateTime hzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzo_);
                    CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzzzzzp_, true, true);
                    bool? hzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzzzzzq_, default);
                    CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzi_);
                    CqlDateTime hzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzt_);
                    bool? hzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzzzzzzzu_ is null));
                    bool? hzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzzzzzzzv_);
                    Code<Encounter.EncounterStatus> hzzzzzzzzzzzzzzzzzzzzzx_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? hzzzzzzzzzzzzzzzzzzzzzy_ = hzzzzzzzzzzzzzzzzzzzzzx_?.Value;
                    Code<Encounter.EncounterStatus> hzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hzzzzzzzzzzzzzzzzzzzzzy_);
                    bool? izzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Equal(hzzzzzzzzzzzzzzzzzzzzzz_, "finished");
                    bool? izzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzzzzzza_);

                    return izzzzzzzzzzzzzzzzzzzzzb_;
                };
                IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzzzzzzzzzj_);
                object fzzzzzzzzzzzzzzzzzzzzzl_(Encounter @this)
                {
                    Period izzzzzzzzzzzzzzzzzzzzzc_ = @this?.Period;
                    CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzc_);
                    CqlDateTime izzzzzzzzzzzzzzzzzzzzze_ = context.Operators.End(izzzzzzzzzzzzzzzzzzzzzd_);

                    return izzzzzzzzzzzzzzzzzzzzze_;
                };
                IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SortBy<Encounter>(fzzzzzzzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzzzzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter fzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Last<Encounter>(fzzzzzzzzzzzzzzzzzzzzzm_);
                Period fzzzzzzzzzzzzzzzzzzzzzo_ = fzzzzzzzzzzzzzzzzzzzzzn_?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzp_);
                Period fzzzzzzzzzzzzzzzzzzzzzr_ = Visit?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzs_);
                CqlQuantity fzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Subtract(fzzzzzzzzzzzzzzzzzzzzzq_ ?? fzzzzzzzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzzzzzzzu_);
                IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? fzzzzzzzzzzzzzzzzzzzzzy_(Encounter LastObs)
                {
                    Period izzzzzzzzzzzzzzzzzzzzzf_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzf_);
                    CqlDateTime izzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.End(izzzzzzzzzzzzzzzzzzzzzg_);
                    Period izzzzzzzzzzzzzzzzzzzzzi_ = Visit?.Period;
                    CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzi_);
                    CqlDateTime izzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzj_);
                    CqlQuantity izzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime izzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(izzzzzzzzzzzzzzzzzzzzzk_, izzzzzzzzzzzzzzzzzzzzzl_);
                    CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzi_);
                    CqlDateTime izzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzo_);
                    CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(izzzzzzzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzzzzzzp_, true, true);
                    bool? izzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzzzzzzzzq_, default);
                    CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzi_);
                    CqlDateTime izzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzt_);
                    bool? izzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzzzzzzzu_ is null));
                    bool? izzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzr_, izzzzzzzzzzzzzzzzzzzzzv_);
                    Code<Encounter.EncounterStatus> izzzzzzzzzzzzzzzzzzzzzx_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? izzzzzzzzzzzzzzzzzzzzzy_ = izzzzzzzzzzzzzzzzzzzzzx_?.Value;
                    Code<Encounter.EncounterStatus> izzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(izzzzzzzzzzzzzzzzzzzzzy_);
                    bool? jzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Equal(izzzzzzzzzzzzzzzzzzzzzz_, "finished");
                    bool? jzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzzzzzzzzza_);

                    return jzzzzzzzzzzzzzzzzzzzzzb_;
                };
                IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzzzzzzzzy_);
                object gzzzzzzzzzzzzzzzzzzzzza_(Encounter @this)
                {
                    Period jzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzc_);
                    CqlDateTime jzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.End(jzzzzzzzzzzzzzzzzzzzzzd_);

                    return jzzzzzzzzzzzzzzzzzzzzze_;
                };
                IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SortBy<Encounter>(fzzzzzzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzzzzzza_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter gzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Last<Encounter>(gzzzzzzzzzzzzzzzzzzzzzb_);
                Period gzzzzzzzzzzzzzzzzzzzzzd_ = gzzzzzzzzzzzzzzzzzzzzzc_?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzzzzzzv_, gzzzzzzzzzzzzzzzzzzzzzf_ ?? gzzzzzzzzzzzzzzzzzzzzzi_, true, true);
                bool? gzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzzzzzzzzj_, default);
                IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? gzzzzzzzzzzzzzzzzzzzzzn_(Encounter LastObs)
                {
                    Period jzzzzzzzzzzzzzzzzzzzzzf_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzf_);
                    CqlDateTime jzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.End(jzzzzzzzzzzzzzzzzzzzzzg_);
                    Period jzzzzzzzzzzzzzzzzzzzzzi_ = Visit?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzi_);
                    CqlDateTime jzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzj_);
                    CqlQuantity jzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime jzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(jzzzzzzzzzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzzzzzzzzzl_);
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzi_);
                    CqlDateTime jzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzo_);
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(jzzzzzzzzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzzzzzzzzp_, true, true);
                    bool? jzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzh_, jzzzzzzzzzzzzzzzzzzzzzq_, default);
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzi_);
                    CqlDateTime jzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzt_);
                    bool? jzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzzzzzzu_ is null));
                    bool? jzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzr_, jzzzzzzzzzzzzzzzzzzzzzv_);
                    Code<Encounter.EncounterStatus> jzzzzzzzzzzzzzzzzzzzzzx_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? jzzzzzzzzzzzzzzzzzzzzzy_ = jzzzzzzzzzzzzzzzzzzzzzx_?.Value;
                    Code<Encounter.EncounterStatus> jzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jzzzzzzzzzzzzzzzzzzzzzy_);
                    bool? kzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Equal(jzzzzzzzzzzzzzzzzzzzzzz_, "finished");
                    bool? kzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzzzzzzzza_);

                    return kzzzzzzzzzzzzzzzzzzzzzb_;
                };
                IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzzzzzzzzm_, gzzzzzzzzzzzzzzzzzzzzzn_);
                object gzzzzzzzzzzzzzzzzzzzzzp_(Encounter @this)
                {
                    Period kzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Period;
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzzc_);
                    CqlDateTime kzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.End(kzzzzzzzzzzzzzzzzzzzzzd_);

                    return kzzzzzzzzzzzzzzzzzzzzze_;
                };
                IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SortBy<Encounter>(gzzzzzzzzzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzzzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter gzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Last<Encounter>(gzzzzzzzzzzzzzzzzzzzzzq_);
                Period gzzzzzzzzzzzzzzzzzzzzzs_ = gzzzzzzzzzzzzzzzzzzzzzr_?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzw_);
                bool? gzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)((gzzzzzzzzzzzzzzzzzzzzzu_ ?? gzzzzzzzzzzzzzzzzzzzzzx_) is null));
                bool? gzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzk_, gzzzzzzzzzzzzzzzzzzzzzy_);
                Code<Encounter.EncounterStatus> hzzzzzzzzzzzzzzzzzzzzza_ = LastEDOBTriage?.StatusElement;
                Encounter.EncounterStatus? hzzzzzzzzzzzzzzzzzzzzzb_ = hzzzzzzzzzzzzzzzzzzzzza_?.Value;
                Code<Encounter.EncounterStatus> hzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hzzzzzzzzzzzzzzzzzzzzzb_);
                bool? hzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(hzzzzzzzzzzzzzzzzzzzzzc_, "finished");
                bool? hzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzz_, hzzzzzzzzzzzzzzzzzzzzzd_);

                return hzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzzzzzzzzze_, ezzzzzzzzzzzzzzzzzzzzzf_);
            object ezzzzzzzzzzzzzzzzzzzzzh_(Encounter @this)
            {
                Period kzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Period;
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.End(kzzzzzzzzzzzzzzzzzzzzzg_);

                return kzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SortBy<Encounter>(ezzzzzzzzzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter ezzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Last<Encounter>(ezzzzzzzzzzzzzzzzzzzzzi_);
            Period ezzzzzzzzzzzzzzzzzzzzzk_ = ezzzzzzzzzzzzzzzzzzzzzj_?.Period;
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzk_);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzl_);
            CqlValueSet ezzzzzzzzzzzzzzzzzzzzzn_ = this.Observation_Services(context);
            IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? ezzzzzzzzzzzzzzzzzzzzzp_(Encounter LastObs)
            {
                Period kzzzzzzzzzzzzzzzzzzzzzi_ = LastObs?.Period;
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.End(kzzzzzzzzzzzzzzzzzzzzzj_);
                Period kzzzzzzzzzzzzzzzzzzzzzl_ = Visit?.Period;
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzm_);
                CqlQuantity kzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Subtract(kzzzzzzzzzzzzzzzzzzzzzn_, kzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzzzzzzzzs_, true, true);
                bool? kzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzk_, kzzzzzzzzzzzzzzzzzzzzzt_, default);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzw_);
                bool? kzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzzzzzzx_ is null));
                bool? kzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzzzzzzzzy_);
                Code<Encounter.EncounterStatus> lzzzzzzzzzzzzzzzzzzzzza_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? lzzzzzzzzzzzzzzzzzzzzzb_ = lzzzzzzzzzzzzzzzzzzzzza_?.Value;
                Code<Encounter.EncounterStatus> lzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lzzzzzzzzzzzzzzzzzzzzzb_);
                bool? lzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(lzzzzzzzzzzzzzzzzzzzzzc_, "finished");
                bool? lzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzzzzzzzzzd_);

                return lzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzzzzzzzzzo_, ezzzzzzzzzzzzzzzzzzzzzp_);
            object ezzzzzzzzzzzzzzzzzzzzzr_(Encounter @this)
            {
                Period lzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.End(lzzzzzzzzzzzzzzzzzzzzzg_);

                return lzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SortBy<Encounter>(ezzzzzzzzzzzzzzzzzzzzzq_, ezzzzzzzzzzzzzzzzzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter ezzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Last<Encounter>(ezzzzzzzzzzzzzzzzzzzzzs_);
            Period ezzzzzzzzzzzzzzzzzzzzzu_ = ezzzzzzzzzzzzzzzzzzzzzt_?.Period;
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzu_);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzv_);
            Period ezzzzzzzzzzzzzzzzzzzzzx_ = Visit?.Period;
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzx_);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzx_);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.End(fzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzzzzzzm_ ?? ezzzzzzzzzzzzzzzzzzzzzw_ ?? ezzzzzzzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzzzzzzzc_, true, true);

            return fzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> ezzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)dzzzzzzzzzzzzzzzzzzzzzy_, dzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<CqlInterval<CqlDateTime>> ezzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(ezzzzzzzzzzzzzzzzzzzzza_);
        CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(ezzzzzzzzzzzzzzzzzzzzzb_);

        return ezzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Delivery Encounter with Age Range")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Age_Range(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzi_ = this.Encounter_with_Age_Range(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzj_(Encounter EncounterWithAge)
        {
            CqlValueSet lzzzzzzzzzzzzzzzzzzzzzl_ = this.Delivery_Procedures(context);
            IEnumerable<Procedure> lzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? lzzzzzzzzzzzzzzzzzzzzzn_(Procedure DeliveryProcedure)
            {
                Code<EventStatus> lzzzzzzzzzzzzzzzzzzzzzr_ = DeliveryProcedure?.StatusElement;
                EventStatus? lzzzzzzzzzzzzzzzzzzzzzs_ = lzzzzzzzzzzzzzzzzzzzzzr_?.Value;
                string lzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzzzzzzs_);
                bool? lzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Equal(lzzzzzzzzzzzzzzzzzzzzzt_, "completed");
                DataType lzzzzzzzzzzzzzzzzzzzzzv_ = DeliveryProcedure?.Performed;
                object lzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzz_ = this.hospitalizationWithEDOBTriageObservation(context, EncounterWithAge);
                bool? mzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzy_, lzzzzzzzzzzzzzzzzzzzzzz_, default);
                bool? mzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzu_, mzzzzzzzzzzzzzzzzzzzzza_);

                return mzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Procedure> lzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Procedure>(lzzzzzzzzzzzzzzzzzzzzzm_, lzzzzzzzzzzzzzzzzzzzzzn_);
            Encounter lzzzzzzzzzzzzzzzzzzzzzp_(Procedure DeliveryProcedure) =>
                EncounterWithAge;
            IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Procedure, Encounter>(lzzzzzzzzzzzzzzzzzzzzzo_, lzzzzzzzzzzzzzzzzzzzzzp_);

            return lzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SelectMany<Encounter, Encounter>(lzzzzzzzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzzzzzzzj_);

        return lzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("lastTimeOfDelivery")]
    public CqlDateTime lastTimeOfDelivery(CqlContext context, Encounter TheEncounter)
    {
        CqlCode mzzzzzzzzzzzzzzzzzzzzzc_ = this.Date_and_time_of_obstetric_delivery(context);
        IEnumerable<CqlCode> mzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ToList<CqlCode>(mzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, mzzzzzzzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? mzzzzzzzzzzzzzzzzzzzzzf_(Observation TimeOfDelivery)
        {
            DataType mzzzzzzzzzzzzzzzzzzzzzm_ = TimeOfDelivery?.Value;
            object mzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzm_);
            bool? mzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)((mzzzzzzzzzzzzzzzzzzzzzn_ as CqlDateTime) is null));
            Code<ObservationStatus> mzzzzzzzzzzzzzzzzzzzzzp_ = TimeOfDelivery?.StatusElement;
            ObservationStatus? mzzzzzzzzzzzzzzzzzzzzzq_ = mzzzzzzzzzzzzzzzzzzzzzp_?.Value;
            Code<ObservationStatus> mzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<Code<ObservationStatus>>(mzzzzzzzzzzzzzzzzzzzzzq_);
            string mzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<string>(mzzzzzzzzzzzzzzzzzzzzzr_);
            string[] mzzzzzzzzzzzzzzzzzzzzzt_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? mzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<string>(mzzzzzzzzzzzzzzzzzzzzzs_, mzzzzzzzzzzzzzzzzzzzzzt_ as IEnumerable<string>);
            bool? mzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzzzzzzzzu_);
            object mzzzzzzzzzzzzzzzzzzzzzw_()
            {
                bool nzzzzzzzzzzzzzzzzzzzzzg_()
                {
                    DataType nzzzzzzzzzzzzzzzzzzzzzj_ = TimeOfDelivery?.Effective;
                    object nzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzj_);
                    bool nzzzzzzzzzzzzzzzzzzzzzl_ = nzzzzzzzzzzzzzzzzzzzzzk_ is CqlDateTime;

                    return nzzzzzzzzzzzzzzzzzzzzzl_;
                };
                bool nzzzzzzzzzzzzzzzzzzzzzh_()
                {
                    DataType nzzzzzzzzzzzzzzzzzzzzzm_ = TimeOfDelivery?.Effective;
                    object nzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzm_);
                    bool nzzzzzzzzzzzzzzzzzzzzzo_ = nzzzzzzzzzzzzzzzzzzzzzn_ is CqlInterval<CqlDateTime>;

                    return nzzzzzzzzzzzzzzzzzzzzzo_;
                };
                bool nzzzzzzzzzzzzzzzzzzzzzi_()
                {
                    DataType nzzzzzzzzzzzzzzzzzzzzzp_ = TimeOfDelivery?.Effective;
                    object nzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzp_);
                    bool nzzzzzzzzzzzzzzzzzzzzzr_ = nzzzzzzzzzzzzzzzzzzzzzq_ is CqlDateTime;

                    return nzzzzzzzzzzzzzzzzzzzzzr_;
                };
                if (nzzzzzzzzzzzzzzzzzzzzzg_())
                {
                    DataType nzzzzzzzzzzzzzzzzzzzzzs_ = TimeOfDelivery?.Effective;
                    object nzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzs_);

                    return (nzzzzzzzzzzzzzzzzzzzzzt_ as CqlDateTime) as object;
                }
                else if (nzzzzzzzzzzzzzzzzzzzzzh_())
                {
                    DataType nzzzzzzzzzzzzzzzzzzzzzu_ = TimeOfDelivery?.Effective;
                    object nzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzu_);

                    return (nzzzzzzzzzzzzzzzzzzzzzv_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (nzzzzzzzzzzzzzzzzzzzzzi_())
                {
                    DataType nzzzzzzzzzzzzzzzzzzzzzw_ = TimeOfDelivery?.Effective;
                    object nzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzw_);

                    return (nzzzzzzzzzzzzzzzzzzzzzx_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzzzzzw_());
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzy_ = this.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
            bool? mzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzx_, mzzzzzzzzzzzzzzzzzzzzzy_, default);
            bool? nzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzzzzzzzz_);
            object nzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzm_);
            bool? nzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzc_ as CqlDateTime, mzzzzzzzzzzzzzzzzzzzzzy_, default);
            bool? nzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzzzzze_);

            return nzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(mzzzzzzzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzzzzzzzf_);
        object mzzzzzzzzzzzzzzzzzzzzzh_(Observation @this)
        {
            object nzzzzzzzzzzzzzzzzzzzzzy_()
            {
                bool ozzzzzzzzzzzzzzzzzzzzza_()
                {
                    DataType ozzzzzzzzzzzzzzzzzzzzzd_ = @this?.Effective;
                    object ozzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzd_);
                    bool ozzzzzzzzzzzzzzzzzzzzzf_ = ozzzzzzzzzzzzzzzzzzzzze_ is CqlDateTime;

                    return ozzzzzzzzzzzzzzzzzzzzzf_;
                };
                bool ozzzzzzzzzzzzzzzzzzzzzb_()
                {
                    DataType ozzzzzzzzzzzzzzzzzzzzzg_ = @this?.Effective;
                    object ozzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzg_);
                    bool ozzzzzzzzzzzzzzzzzzzzzi_ = ozzzzzzzzzzzzzzzzzzzzzh_ is CqlInterval<CqlDateTime>;

                    return ozzzzzzzzzzzzzzzzzzzzzi_;
                };
                bool ozzzzzzzzzzzzzzzzzzzzzc_()
                {
                    DataType ozzzzzzzzzzzzzzzzzzzzzj_ = @this?.Effective;
                    object ozzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzj_);
                    bool ozzzzzzzzzzzzzzzzzzzzzl_ = ozzzzzzzzzzzzzzzzzzzzzk_ is CqlDateTime;

                    return ozzzzzzzzzzzzzzzzzzzzzl_;
                };
                if (ozzzzzzzzzzzzzzzzzzzzza_())
                {
                    DataType ozzzzzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                    object ozzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzm_);

                    return (ozzzzzzzzzzzzzzzzzzzzzn_ as CqlDateTime) as object;
                }
                else if (ozzzzzzzzzzzzzzzzzzzzzb_())
                {
                    DataType ozzzzzzzzzzzzzzzzzzzzzo_ = @this?.Effective;
                    object ozzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzo_);

                    return (ozzzzzzzzzzzzzzzzzzzzzp_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ozzzzzzzzzzzzzzzzzzzzzc_())
                {
                    DataType ozzzzzzzzzzzzzzzzzzzzzq_ = @this?.Effective;
                    object ozzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzq_);

                    return (ozzzzzzzzzzzzzzzzzzzzzr_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzzzzzy_());

            return nzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SortBy<Observation>(mzzzzzzzzzzzzzzzzzzzzzg_, mzzzzzzzzzzzzzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
        Observation mzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Last<Observation>(mzzzzzzzzzzzzzzzzzzzzzi_);
        DataType mzzzzzzzzzzzzzzzzzzzzzk_ = mzzzzzzzzzzzzzzzzzzzzzj_?.Value;
        object mzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzk_);

        return mzzzzzzzzzzzzzzzzzzzzzl_ as CqlDateTime;
    }


    [CqlExpressionDefinition("lastEstimatedDeliveryDate")]
    public CqlDateTime lastEstimatedDeliveryDate(CqlContext context, Encounter TheEncounter)
    {
        CqlCode ozzzzzzzzzzzzzzzzzzzzzs_ = this.Delivery_date_Estimated(context);
        IEnumerable<CqlCode> ozzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ToList<CqlCode>(ozzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ozzzzzzzzzzzzzzzzzzzzzt_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? ozzzzzzzzzzzzzzzzzzzzzv_(Observation EstimatedDateOfDelivery)
        {
            DataType pzzzzzzzzzzzzzzzzzzzzzc_ = EstimatedDateOfDelivery?.Value;
            object pzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzc_);
            bool? pzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)((pzzzzzzzzzzzzzzzzzzzzzd_ as CqlDateTime) is null));
            Code<ObservationStatus> pzzzzzzzzzzzzzzzzzzzzzf_ = EstimatedDateOfDelivery?.StatusElement;
            ObservationStatus? pzzzzzzzzzzzzzzzzzzzzzg_ = pzzzzzzzzzzzzzzzzzzzzzf_?.Value;
            Code<ObservationStatus> pzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<Code<ObservationStatus>>(pzzzzzzzzzzzzzzzzzzzzzg_);
            string pzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzzzzzzzh_);
            string[] pzzzzzzzzzzzzzzzzzzzzzj_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? pzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<string>(pzzzzzzzzzzzzzzzzzzzzzi_, pzzzzzzzzzzzzzzzzzzzzzj_ as IEnumerable<string>);
            bool? pzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzze_, pzzzzzzzzzzzzzzzzzzzzzk_);
            object pzzzzzzzzzzzzzzzzzzzzzm_()
            {
                bool pzzzzzzzzzzzzzzzzzzzzzy_()
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzzb_ = EstimatedDateOfDelivery?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzb_);
                    bool qzzzzzzzzzzzzzzzzzzzzzd_ = qzzzzzzzzzzzzzzzzzzzzzc_ is CqlDateTime;

                    return qzzzzzzzzzzzzzzzzzzzzzd_;
                };
                bool pzzzzzzzzzzzzzzzzzzzzzz_()
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzze_ = EstimatedDateOfDelivery?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzze_);
                    bool qzzzzzzzzzzzzzzzzzzzzzg_ = qzzzzzzzzzzzzzzzzzzzzzf_ is CqlInterval<CqlDateTime>;

                    return qzzzzzzzzzzzzzzzzzzzzzg_;
                };
                bool qzzzzzzzzzzzzzzzzzzzzza_()
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzzh_ = EstimatedDateOfDelivery?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzh_);
                    bool qzzzzzzzzzzzzzzzzzzzzzj_ = qzzzzzzzzzzzzzzzzzzzzzi_ is CqlDateTime;

                    return qzzzzzzzzzzzzzzzzzzzzzj_;
                };
                if (pzzzzzzzzzzzzzzzzzzzzzy_())
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzzk_ = EstimatedDateOfDelivery?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzk_);

                    return (qzzzzzzzzzzzzzzzzzzzzzl_ as CqlDateTime) as object;
                }
                else if (pzzzzzzzzzzzzzzzzzzzzzz_())
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzzm_ = EstimatedDateOfDelivery?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzm_);

                    return (qzzzzzzzzzzzzzzzzzzzzzn_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (qzzzzzzzzzzzzzzzzzzzzza_())
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzzo_ = EstimatedDateOfDelivery?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzo_);

                    return (qzzzzzzzzzzzzzzzzzzzzzp_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzzzzzzzzzzzzzzzzm_());
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzo_ = this.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity pzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Subtract(pzzzzzzzzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(pzzzzzzzzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzzzzzzzzo_, true, true);
            bool? pzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzzzzzzzzzs_, default);
            bool? pzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzzzzzzzzzo_ is null));
            bool? pzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzt_, pzzzzzzzzzzzzzzzzzzzzzv_);
            bool? pzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzl_, pzzzzzzzzzzzzzzzzzzzzzw_);

            return pzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(ozzzzzzzzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzzzzzzzzv_);
        object ozzzzzzzzzzzzzzzzzzzzzx_(Observation @this)
        {
            object qzzzzzzzzzzzzzzzzzzzzzq_()
            {
                bool qzzzzzzzzzzzzzzzzzzzzzs_()
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzzv_ = @this?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzv_);
                    bool qzzzzzzzzzzzzzzzzzzzzzx_ = qzzzzzzzzzzzzzzzzzzzzzw_ is CqlDateTime;

                    return qzzzzzzzzzzzzzzzzzzzzzx_;
                };
                bool qzzzzzzzzzzzzzzzzzzzzzt_()
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzzy_ = @this?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzy_);
                    bool rzzzzzzzzzzzzzzzzzzzzza_ = qzzzzzzzzzzzzzzzzzzzzzz_ is CqlInterval<CqlDateTime>;

                    return rzzzzzzzzzzzzzzzzzzzzza_;
                };
                bool qzzzzzzzzzzzzzzzzzzzzzu_()
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzzb_ = @this?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzb_);
                    bool rzzzzzzzzzzzzzzzzzzzzzd_ = rzzzzzzzzzzzzzzzzzzzzzc_ is CqlDateTime;

                    return rzzzzzzzzzzzzzzzzzzzzzd_;
                };
                if (qzzzzzzzzzzzzzzzzzzzzzs_())
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzze_ = @this?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzze_);

                    return (rzzzzzzzzzzzzzzzzzzzzzf_ as CqlDateTime) as object;
                }
                else if (qzzzzzzzzzzzzzzzzzzzzzt_())
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzzg_ = @this?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzg_);

                    return (rzzzzzzzzzzzzzzzzzzzzzh_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (qzzzzzzzzzzzzzzzzzzzzzu_())
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzzi_ = @this?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzi_);

                    return (rzzzzzzzzzzzzzzzzzzzzzj_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzzzzzzzzzzzzzzzzzzq_());

            return qzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SortBy<Observation>(ozzzzzzzzzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzzzzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
        Observation ozzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Last<Observation>(ozzzzzzzzzzzzzzzzzzzzzy_);
        DataType pzzzzzzzzzzzzzzzzzzzzza_ = ozzzzzzzzzzzzzzzzzzzzzz_?.Value;
        object pzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzza_);

        return pzzzzzzzzzzzzzzzzzzzzzb_ as CqlDateTime;
    }


    [CqlExpressionDefinition("calculatedGestationalAge")]
    public int? calculatedGestationalAge(CqlContext context, Encounter TheEncounter)
    {
        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzk_ = this.lastTimeOfDelivery(context, TheEncounter);
        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzl_ = this.lastEstimatedDeliveryDate(context, TheEncounter);
        int? rzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DifferenceBetween(rzzzzzzzzzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzzzzzzzzzl_, "day");
        int? rzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Subtract(280, rzzzzzzzzzzzzzzzzzzzzzm_);
        int? rzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.TruncatedDivide(rzzzzzzzzzzzzzzzzzzzzzn_, 7);

        return rzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Variable Calculated Gestational Age")]
    public IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> Variable_Calculated_Gestational_Age(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzp_ = this.Delivery_Encounter_with_Age_Range(context);
        (CqlTupleMetadata, string EncounterID, int? CalculatedCGA)? rzzzzzzzzzzzzzzzzzzzzzq_(Encounter DeliveryEncounter)
        {
            Id rzzzzzzzzzzzzzzzzzzzzzt_ = DeliveryEncounter?.IdElement;
            string rzzzzzzzzzzzzzzzzzzzzzu_ = rzzzzzzzzzzzzzzzzzzzzzt_?.Value;
            int? rzzzzzzzzzzzzzzzzzzzzzv_ = this.calculatedGestationalAge(context, DeliveryEncounter);
            (CqlTupleMetadata, string EncounterID, int? CalculatedCGA)? rzzzzzzzzzzzzzzzzzzzzzw_ = (CqlTupleMetadata_DjNbNOhJZXGJDNQeiTBabEOBB, rzzzzzzzzzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzzzzzzzzzv_);

            return rzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> rzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?>(rzzzzzzzzzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> rzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?>(rzzzzzzzzzzzzzzzzzzzzzr_);

        return rzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("lastEstimatedGestationalAge")]
    public CqlQuantity lastEstimatedGestationalAge(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzx_ = this.Estimated_Gestational_Age_at_Delivery(context);
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? rzzzzzzzzzzzzzzzzzzzzzz_(Observation EstimatedGestationalAge)
        {
            object szzzzzzzzzzzzzzzzzzzzzg_()
            {
                bool tzzzzzzzzzzzzzzzzzzzzzq_()
                {
                    DataType tzzzzzzzzzzzzzzzzzzzzzt_ = EstimatedGestationalAge?.Effective;
                    object tzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzt_);
                    bool tzzzzzzzzzzzzzzzzzzzzzv_ = tzzzzzzzzzzzzzzzzzzzzzu_ is CqlDateTime;

                    return tzzzzzzzzzzzzzzzzzzzzzv_;
                };
                bool tzzzzzzzzzzzzzzzzzzzzzr_()
                {
                    DataType tzzzzzzzzzzzzzzzzzzzzzw_ = EstimatedGestationalAge?.Effective;
                    object tzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzw_);
                    bool tzzzzzzzzzzzzzzzzzzzzzy_ = tzzzzzzzzzzzzzzzzzzzzzx_ is CqlInterval<CqlDateTime>;

                    return tzzzzzzzzzzzzzzzzzzzzzy_;
                };
                bool tzzzzzzzzzzzzzzzzzzzzzs_()
                {
                    DataType tzzzzzzzzzzzzzzzzzzzzzz_ = EstimatedGestationalAge?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzz_);
                    bool uzzzzzzzzzzzzzzzzzzzzzb_ = uzzzzzzzzzzzzzzzzzzzzza_ is CqlDateTime;

                    return uzzzzzzzzzzzzzzzzzzzzzb_;
                };
                if (tzzzzzzzzzzzzzzzzzzzzzq_())
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzc_ = EstimatedGestationalAge?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzc_);

                    return (uzzzzzzzzzzzzzzzzzzzzzd_ as CqlDateTime) as object;
                }
                else if (tzzzzzzzzzzzzzzzzzzzzzr_())
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzze_ = EstimatedGestationalAge?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzze_);

                    return (uzzzzzzzzzzzzzzzzzzzzzf_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (tzzzzzzzzzzzzzzzzzzzzzs_())
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzg_ = EstimatedGestationalAge?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzg_);

                    return (uzzzzzzzzzzzzzzzzzzzzzh_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzzzzzzzzzzzzzzzzg_());
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzi_ = this.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity szzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(24m, "hours");
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Subtract(szzzzzzzzzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(szzzzzzzzzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzzzzzzzzi_, true, true);
            bool? szzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzzzzzzzzm_, default);
            bool? szzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzzzzzzi_ is null));
            bool? szzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzzzzzzzzp_);
            DataType szzzzzzzzzzzzzzzzzzzzzr_ = EstimatedGestationalAge?.Value;
            object szzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzr_);
            bool? szzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzzzzzzs_ is null));
            bool? szzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzzzzzzzzt_);
            Code<ObservationStatus> szzzzzzzzzzzzzzzzzzzzzv_ = EstimatedGestationalAge?.StatusElement;
            ObservationStatus? szzzzzzzzzzzzzzzzzzzzzw_ = szzzzzzzzzzzzzzzzzzzzzv_?.Value;
            Code<ObservationStatus> szzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<Code<ObservationStatus>>(szzzzzzzzzzzzzzzzzzzzzw_);
            string szzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(szzzzzzzzzzzzzzzzzzzzzx_);
            string[] szzzzzzzzzzzzzzzzzzzzzz_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? tzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<string>(szzzzzzzzzzzzzzzzzzzzzy_, szzzzzzzzzzzzzzzzzzzzzz_ as IEnumerable<string>);
            bool? tzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzu_, tzzzzzzzzzzzzzzzzzzzzza_);
            object tzzzzzzzzzzzzzzzzzzzzzc_()
            {
                bool uzzzzzzzzzzzzzzzzzzzzzi_()
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzl_ = EstimatedGestationalAge?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzl_);
                    bool uzzzzzzzzzzzzzzzzzzzzzn_ = uzzzzzzzzzzzzzzzzzzzzzm_ is CqlDateTime;

                    return uzzzzzzzzzzzzzzzzzzzzzn_;
                };
                bool uzzzzzzzzzzzzzzzzzzzzzj_()
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzo_ = EstimatedGestationalAge?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzo_);
                    bool uzzzzzzzzzzzzzzzzzzzzzq_ = uzzzzzzzzzzzzzzzzzzzzzp_ is CqlInterval<CqlDateTime>;

                    return uzzzzzzzzzzzzzzzzzzzzzq_;
                };
                bool uzzzzzzzzzzzzzzzzzzzzzk_()
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzr_ = EstimatedGestationalAge?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzr_);
                    bool uzzzzzzzzzzzzzzzzzzzzzt_ = uzzzzzzzzzzzzzzzzzzzzzs_ is CqlDateTime;

                    return uzzzzzzzzzzzzzzzzzzzzzt_;
                };
                if (uzzzzzzzzzzzzzzzzzzzzzi_())
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzu_ = EstimatedGestationalAge?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzu_);

                    return (uzzzzzzzzzzzzzzzzzzzzzv_ as CqlDateTime) as object;
                }
                else if (uzzzzzzzzzzzzzzzzzzzzzj_())
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzw_ = EstimatedGestationalAge?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzw_);

                    return (uzzzzzzzzzzzzzzzzzzzzzx_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (uzzzzzzzzzzzzzzzzzzzzzk_())
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzy_ = EstimatedGestationalAge?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzy_);

                    return (uzzzzzzzzzzzzzzzzzzzzzz_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzc_());
            bool? tzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SameAs(tzzzzzzzzzzzzzzzzzzzzzd_, szzzzzzzzzzzzzzzzzzzzzi_, "day");
            object tzzzzzzzzzzzzzzzzzzzzzg_()
            {
                bool vzzzzzzzzzzzzzzzzzzzzza_()
                {
                    DataType vzzzzzzzzzzzzzzzzzzzzzd_ = EstimatedGestationalAge?.Effective;
                    object vzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzd_);
                    bool vzzzzzzzzzzzzzzzzzzzzzf_ = vzzzzzzzzzzzzzzzzzzzzze_ is CqlDateTime;

                    return vzzzzzzzzzzzzzzzzzzzzzf_;
                };
                bool vzzzzzzzzzzzzzzzzzzzzzb_()
                {
                    DataType vzzzzzzzzzzzzzzzzzzzzzg_ = EstimatedGestationalAge?.Effective;
                    object vzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzg_);
                    bool vzzzzzzzzzzzzzzzzzzzzzi_ = vzzzzzzzzzzzzzzzzzzzzzh_ is CqlInterval<CqlDateTime>;

                    return vzzzzzzzzzzzzzzzzzzzzzi_;
                };
                bool vzzzzzzzzzzzzzzzzzzzzzc_()
                {
                    DataType vzzzzzzzzzzzzzzzzzzzzzj_ = EstimatedGestationalAge?.Effective;
                    object vzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzj_);
                    bool vzzzzzzzzzzzzzzzzzzzzzl_ = vzzzzzzzzzzzzzzzzzzzzzk_ is CqlDateTime;

                    return vzzzzzzzzzzzzzzzzzzzzzl_;
                };
                if (vzzzzzzzzzzzzzzzzzzzzza_())
                {
                    DataType vzzzzzzzzzzzzzzzzzzzzzm_ = EstimatedGestationalAge?.Effective;
                    object vzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzm_);

                    return (vzzzzzzzzzzzzzzzzzzzzzn_ as CqlDateTime) as object;
                }
                else if (vzzzzzzzzzzzzzzzzzzzzzb_())
                {
                    DataType vzzzzzzzzzzzzzzzzzzzzzo_ = EstimatedGestationalAge?.Effective;
                    object vzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzo_);

                    return (vzzzzzzzzzzzzzzzzzzzzzp_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (vzzzzzzzzzzzzzzzzzzzzzc_())
                {
                    DataType vzzzzzzzzzzzzzzzzzzzzzq_ = EstimatedGestationalAge?.Effective;
                    object vzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzq_);

                    return (vzzzzzzzzzzzzzzzzzzzzzr_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzg_());
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzi_ = this.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
            bool? tzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzzzzzzzi_, default);
            bool? tzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzzzzzzj_);
            object tzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzr_);
            bool? tzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzzzzzm_ is null));
            bool? tzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzk_, tzzzzzzzzzzzzzzzzzzzzzn_);
            bool? tzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Or(tzzzzzzzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzzzzzzzo_);

            return tzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzzzzzzzzzz_);
        object szzzzzzzzzzzzzzzzzzzzzb_(Observation @this)
        {
            object vzzzzzzzzzzzzzzzzzzzzzs_()
            {
                bool vzzzzzzzzzzzzzzzzzzzzzu_()
                {
                    DataType vzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                    object vzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzx_);
                    bool vzzzzzzzzzzzzzzzzzzzzzz_ = vzzzzzzzzzzzzzzzzzzzzzy_ is CqlDateTime;

                    return vzzzzzzzzzzzzzzzzzzzzzz_;
                };
                bool vzzzzzzzzzzzzzzzzzzzzzv_()
                {
                    DataType wzzzzzzzzzzzzzzzzzzzzza_ = @this?.Effective;
                    object wzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzza_);
                    bool wzzzzzzzzzzzzzzzzzzzzzc_ = wzzzzzzzzzzzzzzzzzzzzzb_ is CqlInterval<CqlDateTime>;

                    return wzzzzzzzzzzzzzzzzzzzzzc_;
                };
                bool vzzzzzzzzzzzzzzzzzzzzzw_()
                {
                    DataType wzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Effective;
                    object wzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzd_);
                    bool wzzzzzzzzzzzzzzzzzzzzzf_ = wzzzzzzzzzzzzzzzzzzzzze_ is CqlDateTime;

                    return wzzzzzzzzzzzzzzzzzzzzzf_;
                };
                if (vzzzzzzzzzzzzzzzzzzzzzu_())
                {
                    DataType wzzzzzzzzzzzzzzzzzzzzzg_ = @this?.Effective;
                    object wzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzg_);

                    return (wzzzzzzzzzzzzzzzzzzzzzh_ as CqlDateTime) as object;
                }
                else if (vzzzzzzzzzzzzzzzzzzzzzv_())
                {
                    DataType wzzzzzzzzzzzzzzzzzzzzzi_ = @this?.Effective;
                    object wzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzi_);

                    return (wzzzzzzzzzzzzzzzzzzzzzj_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (vzzzzzzzzzzzzzzzzzzzzzw_())
                {
                    DataType wzzzzzzzzzzzzzzzzzzzzzk_ = @this?.Effective;
                    object wzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzk_);

                    return (wzzzzzzzzzzzzzzzzzzzzzl_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzzzzzzzzzzzzzzzzzzzs_());

            return vzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SortBy<Observation>(szzzzzzzzzzzzzzzzzzzzza_, szzzzzzzzzzzzzzzzzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
        Observation szzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Last<Observation>(szzzzzzzzzzzzzzzzzzzzzc_);
        DataType szzzzzzzzzzzzzzzzzzzzze_ = szzzzzzzzzzzzzzzzzzzzzd_?.Value;
        object szzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzze_);

        return szzzzzzzzzzzzzzzzzzzzzf_ as CqlQuantity;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_DjNbNOhJZXGJDNQeiTBabEOBB = new(
        [typeof(string), typeof(int?)],
        ["EncounterID", "CalculatedCGA"]);

    #endregion CqlTupleMetadata Properties

}
