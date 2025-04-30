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
      new CqlCodeSystem("http://loinc.org", null, [
          _Date_and_time_of_obstetric_delivery,
          _Delivery_date_Estimated]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime szzzzzzzzzzzzzzzzzzl_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime szzzzzzzzzzzzzzzzzzm_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(szzzzzzzzzzzzzzzzzzl_, szzzzzzzzzzzzzzzzzzm_, true, true);
        object szzzzzzzzzzzzzzzzzzo_ = context.ResolveParameter("PCMaternal-5.19.000", "Measurement Period", szzzzzzzzzzzzzzzzzzn_);

        return (CqlInterval<CqlDateTime>)szzzzzzzzzzzzzzzzzzo_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> szzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient szzzzzzzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<Patient>(szzzzzzzzzzzzzzzzzzp_);

        return szzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Encounter with Age Range")]
    public IEnumerable<Encounter> Encounter_with_Age_Range(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzr_ = CQMCommon_2_2_000.Instance.Inpatient_Encounter(context);
        bool? szzzzzzzzzzzzzzzzzzs_(Encounter InpatientEncounter)
        {
            Patient szzzzzzzzzzzzzzzzzzu_ = this.Patient(context);
            Date szzzzzzzzzzzzzzzzzzv_ = szzzzzzzzzzzzzzzzzzu_?.BirthDateElement;
            string szzzzzzzzzzzzzzzzzzw_ = szzzzzzzzzzzzzzzzzzv_?.Value;
            CqlDate szzzzzzzzzzzzzzzzzzx_ = context.Operators.ConvertStringToDate(szzzzzzzzzzzzzzzzzzw_);
            Period szzzzzzzzzzzzzzzzzzy_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzy_);
            CqlDateTime tzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzz_);
            CqlDate tzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzza_);
            int? tzzzzzzzzzzzzzzzzzzc_ = context.Operators.CalculateAgeAt(szzzzzzzzzzzzzzzzzzx_, tzzzzzzzzzzzzzzzzzzb_, "year");
            CqlInterval<int?> tzzzzzzzzzzzzzzzzzzd_ = context.Operators.Interval(8, 65, true, false);
            bool? tzzzzzzzzzzzzzzzzzze_ = context.Operators.In<int?>(tzzzzzzzzzzzzzzzzzzc_, tzzzzzzzzzzzzzzzzzzd_, default);

            return tzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(szzzzzzzzzzzzzzzzzzr_, szzzzzzzzzzzzzzzzzzs_);

        return szzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("hospitalizationWithEDOBTriageObservation")]
    public CqlInterval<CqlDateTime> hospitalizationWithEDOBTriageObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] tzzzzzzzzzzzzzzzzzzf_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzg_(Encounter Visit)
        {
            CqlValueSet tzzzzzzzzzzzzzzzzzzk_ = this.ED_Visit_and_OB_Triage(context);
            IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? tzzzzzzzzzzzzzzzzzzm_(Encounter LastEDOBTriage)
            {
                Period uzzzzzzzzzzzzzzzzzzl_ = LastEDOBTriage?.Period;
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzn_ = context.Operators.End(uzzzzzzzzzzzzzzzzzzm_);
                CqlValueSet uzzzzzzzzzzzzzzzzzzo_ = this.Observation_Services(context);
                IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? uzzzzzzzzzzzzzzzzzzq_(Encounter LastObs)
                {
                    Period wzzzzzzzzzzzzzzzzzzm_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzm_);
                    CqlDateTime wzzzzzzzzzzzzzzzzzzo_ = context.Operators.End(wzzzzzzzzzzzzzzzzzzn_);
                    Period wzzzzzzzzzzzzzzzzzzp_ = Visit?.Period;
                    CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzp_);
                    CqlDateTime wzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzq_);
                    CqlQuantity wzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime wzzzzzzzzzzzzzzzzzzt_ = context.Operators.Subtract(wzzzzzzzzzzzzzzzzzzr_, wzzzzzzzzzzzzzzzzzzs_);
                    CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzp_);
                    CqlDateTime wzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzv_);
                    CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(wzzzzzzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzzzzzzw_, true, true);
                    bool? wzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzzzx_, default);
                    CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzp_);
                    CqlDateTime xzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzza_);
                    bool? xzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzzzzzb_ is null));
                    bool? xzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzzzzzzc_);
                    Code<Encounter.EncounterStatus> xzzzzzzzzzzzzzzzzzze_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? xzzzzzzzzzzzzzzzzzzf_ = xzzzzzzzzzzzzzzzzzze_?.Value;
                    Code<Encounter.EncounterStatus> xzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(xzzzzzzzzzzzzzzzzzzf_);
                    bool? xzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equal(xzzzzzzzzzzzzzzzzzzg_, "finished");
                    bool? xzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzzzzzh_);

                    return xzzzzzzzzzzzzzzzzzzi_;
                };
                IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzzzzzzq_);
                object uzzzzzzzzzzzzzzzzzzs_(Encounter @this)
                {
                    Period xzzzzzzzzzzzzzzzzzzj_ = @this?.Period;
                    CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzj_);
                    CqlDateTime xzzzzzzzzzzzzzzzzzzl_ = context.Operators.End(xzzzzzzzzzzzzzzzzzzk_);

                    return xzzzzzzzzzzzzzzzzzzl_;
                };
                IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzt_ = context.Operators.SortBy<Encounter>(uzzzzzzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter uzzzzzzzzzzzzzzzzzzu_ = context.Operators.Last<Encounter>(uzzzzzzzzzzzzzzzzzzt_);
                Period uzzzzzzzzzzzzzzzzzzv_ = uzzzzzzzzzzzzzzzzzzu_?.Period;
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzw_);
                Period uzzzzzzzzzzzzzzzzzzy_ = Visit?.Period;
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime vzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzz_);
                CqlQuantity vzzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime vzzzzzzzzzzzzzzzzzzc_ = context.Operators.Subtract(uzzzzzzzzzzzzzzzzzzx_ ?? vzzzzzzzzzzzzzzzzzza_, vzzzzzzzzzzzzzzzzzzb_);
                IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? vzzzzzzzzzzzzzzzzzzf_(Encounter LastObs)
                {
                    Period xzzzzzzzzzzzzzzzzzzm_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzm_);
                    CqlDateTime xzzzzzzzzzzzzzzzzzzo_ = context.Operators.End(xzzzzzzzzzzzzzzzzzzn_);
                    Period xzzzzzzzzzzzzzzzzzzp_ = Visit?.Period;
                    CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzp_);
                    CqlDateTime xzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzq_);
                    CqlQuantity xzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime xzzzzzzzzzzzzzzzzzzt_ = context.Operators.Subtract(xzzzzzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzzzzzs_);
                    CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzp_);
                    CqlDateTime xzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzv_);
                    CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzzzzzw_, true, true);
                    bool? xzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzzzzzzx_, default);
                    CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzp_);
                    CqlDateTime yzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzza_);
                    bool? yzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzzzb_ is null));
                    bool? yzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzy_, yzzzzzzzzzzzzzzzzzzc_);
                    Code<Encounter.EncounterStatus> yzzzzzzzzzzzzzzzzzze_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? yzzzzzzzzzzzzzzzzzzf_ = yzzzzzzzzzzzzzzzzzze_?.Value;
                    Code<Encounter.EncounterStatus> yzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(yzzzzzzzzzzzzzzzzzzf_);
                    bool? yzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equal(yzzzzzzzzzzzzzzzzzzg_, "finished");
                    bool? yzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzzzzzh_);

                    return yzzzzzzzzzzzzzzzzzzi_;
                };
                IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(vzzzzzzzzzzzzzzzzzze_, vzzzzzzzzzzzzzzzzzzf_);
                object vzzzzzzzzzzzzzzzzzzh_(Encounter @this)
                {
                    Period yzzzzzzzzzzzzzzzzzzj_ = @this?.Period;
                    CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzj_);
                    CqlDateTime yzzzzzzzzzzzzzzzzzzl_ = context.Operators.End(yzzzzzzzzzzzzzzzzzzk_);

                    return yzzzzzzzzzzzzzzzzzzl_;
                };
                IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzi_ = context.Operators.SortBy<Encounter>(vzzzzzzzzzzzzzzzzzzg_, vzzzzzzzzzzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter vzzzzzzzzzzzzzzzzzzj_ = context.Operators.Last<Encounter>(vzzzzzzzzzzzzzzzzzzi_);
                Period vzzzzzzzzzzzzzzzzzzk_ = vzzzzzzzzzzzzzzzzzzj_?.Period;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzzzzm_ ?? vzzzzzzzzzzzzzzzzzzp_, true, true);
                bool? vzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzzn_, vzzzzzzzzzzzzzzzzzzq_, default);
                IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? vzzzzzzzzzzzzzzzzzzu_(Encounter LastObs)
                {
                    Period yzzzzzzzzzzzzzzzzzzm_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzm_);
                    CqlDateTime yzzzzzzzzzzzzzzzzzzo_ = context.Operators.End(yzzzzzzzzzzzzzzzzzzn_);
                    Period yzzzzzzzzzzzzzzzzzzp_ = Visit?.Period;
                    CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzp_);
                    CqlDateTime yzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzq_);
                    CqlQuantity yzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime yzzzzzzzzzzzzzzzzzzt_ = context.Operators.Subtract(yzzzzzzzzzzzzzzzzzzr_, yzzzzzzzzzzzzzzzzzzs_);
                    CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzp_);
                    CqlDateTime yzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzv_);
                    CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzzt_, yzzzzzzzzzzzzzzzzzzw_, true, true);
                    bool? yzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzzzzo_, yzzzzzzzzzzzzzzzzzzx_, default);
                    CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzp_);
                    CqlDateTime zzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzza_);
                    bool? zzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzzzzb_ is null));
                    bool? zzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzzzzzzc_);
                    Code<Encounter.EncounterStatus> zzzzzzzzzzzzzzzzzzze_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? zzzzzzzzzzzzzzzzzzzf_ = zzzzzzzzzzzzzzzzzzze_?.Value;
                    Code<Encounter.EncounterStatus> zzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(zzzzzzzzzzzzzzzzzzzf_);
                    bool? zzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equal(zzzzzzzzzzzzzzzzzzzg_, "finished");
                    bool? zzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzzzzzh_);

                    return zzzzzzzzzzzzzzzzzzzi_;
                };
                IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(vzzzzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzzzzu_);
                object vzzzzzzzzzzzzzzzzzzw_(Encounter @this)
                {
                    Period zzzzzzzzzzzzzzzzzzzj_ = @this?.Period;
                    CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzj_);
                    CqlDateTime zzzzzzzzzzzzzzzzzzzl_ = context.Operators.End(zzzzzzzzzzzzzzzzzzzk_);

                    return zzzzzzzzzzzzzzzzzzzl_;
                };
                IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzx_ = context.Operators.SortBy<Encounter>(vzzzzzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter vzzzzzzzzzzzzzzzzzzy_ = context.Operators.Last<Encounter>(vzzzzzzzzzzzzzzzzzzx_);
                Period vzzzzzzzzzzzzzzzzzzz_ = vzzzzzzzzzzzzzzzzzzy_?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime wzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzd_);
                bool? wzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)((wzzzzzzzzzzzzzzzzzzb_ ?? wzzzzzzzzzzzzzzzzzze_) is null));
                bool? wzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzr_, wzzzzzzzzzzzzzzzzzzf_);
                Code<Encounter.EncounterStatus> wzzzzzzzzzzzzzzzzzzh_ = LastEDOBTriage?.StatusElement;
                Encounter.EncounterStatus? wzzzzzzzzzzzzzzzzzzi_ = wzzzzzzzzzzzzzzzzzzh_?.Value;
                Code<Encounter.EncounterStatus> wzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(wzzzzzzzzzzzzzzzzzzi_);
                bool? wzzzzzzzzzzzzzzzzzzk_ = context.Operators.Equal(wzzzzzzzzzzzzzzzzzzj_, "finished");
                bool? wzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzzzzzk_);

                return wzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(tzzzzzzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzzzzzzm_);
            object tzzzzzzzzzzzzzzzzzzo_(Encounter @this)
            {
                Period zzzzzzzzzzzzzzzzzzzm_ = @this?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzo_ = context.Operators.End(zzzzzzzzzzzzzzzzzzzn_);

                return zzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzp_ = context.Operators.SortBy<Encounter>(tzzzzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzzzzo_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter tzzzzzzzzzzzzzzzzzzq_ = context.Operators.Last<Encounter>(tzzzzzzzzzzzzzzzzzzp_);
            Period tzzzzzzzzzzzzzzzzzzr_ = tzzzzzzzzzzzzzzzzzzq_?.Period;
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzzr_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzs_);
            CqlValueSet tzzzzzzzzzzzzzzzzzzu_ = this.Observation_Services(context);
            IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? tzzzzzzzzzzzzzzzzzzw_(Encounter LastObs)
            {
                Period zzzzzzzzzzzzzzzzzzzp_ = LastObs?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzr_ = context.Operators.End(zzzzzzzzzzzzzzzzzzzq_);
                Period zzzzzzzzzzzzzzzzzzzs_ = Visit?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzt_);
                CqlQuantity zzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime zzzzzzzzzzzzzzzzzzzw_ = context.Operators.Subtract(zzzzzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzw_, zzzzzzzzzzzzzzzzzzzz_, true, true);
                bool? azzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzzzza_, default);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime azzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzd_);
                bool? azzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzzzze_ is null));
                bool? azzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzb_, azzzzzzzzzzzzzzzzzzzf_);
                Code<Encounter.EncounterStatus> azzzzzzzzzzzzzzzzzzzh_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? azzzzzzzzzzzzzzzzzzzi_ = azzzzzzzzzzzzzzzzzzzh_?.Value;
                Code<Encounter.EncounterStatus> azzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(azzzzzzzzzzzzzzzzzzzi_);
                bool? azzzzzzzzzzzzzzzzzzzk_ = context.Operators.Equal(azzzzzzzzzzzzzzzzzzzj_, "finished");
                bool? azzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzzzzzk_);

                return azzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(tzzzzzzzzzzzzzzzzzzv_, tzzzzzzzzzzzzzzzzzzw_);
            object tzzzzzzzzzzzzzzzzzzy_(Encounter @this)
            {
                Period azzzzzzzzzzzzzzzzzzzm_ = @this?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzo_ = context.Operators.End(azzzzzzzzzzzzzzzzzzzn_);

                return azzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzz_ = context.Operators.SortBy<Encounter>(tzzzzzzzzzzzzzzzzzzx_, tzzzzzzzzzzzzzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter uzzzzzzzzzzzzzzzzzza_ = context.Operators.Last<Encounter>(tzzzzzzzzzzzzzzzzzzz_);
            Period uzzzzzzzzzzzzzzzzzzb_ = uzzzzzzzzzzzzzzzzzza_?.Period;
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzb_);
            CqlDateTime uzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzc_);
            Period uzzzzzzzzzzzzzzzzzze_ = Visit?.Period;
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzze_);
            CqlDateTime uzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzze_);
            CqlDateTime uzzzzzzzzzzzzzzzzzzj_ = context.Operators.End(uzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(tzzzzzzzzzzzzzzzzzzt_ ?? uzzzzzzzzzzzzzzzzzzd_ ?? uzzzzzzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzzzzzzj_, true, true);

            return uzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> tzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)tzzzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<CqlInterval<CqlDateTime>> tzzzzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(tzzzzzzzzzzzzzzzzzzh_);
        CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzj_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(tzzzzzzzzzzzzzzzzzzi_);

        return tzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Delivery Encounter with Age Range")]
    public IEnumerable<Encounter> Delivery_Encounter_with_Age_Range(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzp_ = this.Encounter_with_Age_Range(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzq_(Encounter EncounterWithAge)
        {
            CqlValueSet azzzzzzzzzzzzzzzzzzzs_ = this.Delivery_Procedures(context);
            IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? azzzzzzzzzzzzzzzzzzzu_(Procedure DeliveryProcedure)
            {
                Code<EventStatus> azzzzzzzzzzzzzzzzzzzy_ = DeliveryProcedure?.StatusElement;
                EventStatus? azzzzzzzzzzzzzzzzzzzz_ = azzzzzzzzzzzzzzzzzzzy_?.Value;
                string bzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<string>(azzzzzzzzzzzzzzzzzzzz_);
                bool? bzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzzza_, "completed");
                DataType bzzzzzzzzzzzzzzzzzzzc_ = DeliveryProcedure?.Performed;
                object bzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzg_ = this.hospitalizationWithEDOBTriageObservation(context, EncounterWithAge);
                bool? bzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzf_, bzzzzzzzzzzzzzzzzzzzg_, default);
                bool? bzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzzzh_);

                return bzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Procedure>(azzzzzzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzzzzzu_);
            Encounter azzzzzzzzzzzzzzzzzzzw_(Procedure DeliveryProcedure) =>
                EncounterWithAge;
            IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<Procedure, Encounter>(azzzzzzzzzzzzzzzzzzzv_, azzzzzzzzzzzzzzzzzzzw_);

            return azzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzr_ = context.Operators.SelectMany<Encounter, Encounter>(azzzzzzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzzzzzq_);

        return azzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("lastTimeOfDelivery")]
    public CqlDateTime lastTimeOfDelivery(CqlContext context, Encounter TheEncounter)
    {
        CqlCode bzzzzzzzzzzzzzzzzzzzj_ = this.Date_and_time_of_obstetric_delivery(context);
        IEnumerable<CqlCode> bzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ToList<CqlCode>(bzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, bzzzzzzzzzzzzzzzzzzzk_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? bzzzzzzzzzzzzzzzzzzzm_(Observation TimeOfDelivery)
        {
            DataType bzzzzzzzzzzzzzzzzzzzt_ = TimeOfDelivery?.Value;
            object bzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzt_);
            bool? bzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)((bzzzzzzzzzzzzzzzzzzzu_ as CqlDateTime) is null));
            Code<ObservationStatus> bzzzzzzzzzzzzzzzzzzzw_ = TimeOfDelivery?.StatusElement;
            ObservationStatus? bzzzzzzzzzzzzzzzzzzzx_ = bzzzzzzzzzzzzzzzzzzzw_?.Value;
            Code<ObservationStatus> bzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<Code<ObservationStatus>>(bzzzzzzzzzzzzzzzzzzzx_);
            string bzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzzzzzzy_);
            string[] czzzzzzzzzzzzzzzzzzza_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? czzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<string>(bzzzzzzzzzzzzzzzzzzzz_, czzzzzzzzzzzzzzzzzzza_ as IEnumerable<string>);
            bool? czzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzv_, czzzzzzzzzzzzzzzzzzzb_);
            object czzzzzzzzzzzzzzzzzzzd_()
            {
                bool czzzzzzzzzzzzzzzzzzzn_()
                {
                    DataType czzzzzzzzzzzzzzzzzzzq_ = TimeOfDelivery?.Effective;
                    object czzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzq_);
                    bool czzzzzzzzzzzzzzzzzzzs_ = czzzzzzzzzzzzzzzzzzzr_ is CqlDateTime;

                    return czzzzzzzzzzzzzzzzzzzs_;
                };
                bool czzzzzzzzzzzzzzzzzzzo_()
                {
                    DataType czzzzzzzzzzzzzzzzzzzt_ = TimeOfDelivery?.Effective;
                    object czzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzt_);
                    bool czzzzzzzzzzzzzzzzzzzv_ = czzzzzzzzzzzzzzzzzzzu_ is CqlInterval<CqlDateTime>;

                    return czzzzzzzzzzzzzzzzzzzv_;
                };
                bool czzzzzzzzzzzzzzzzzzzp_()
                {
                    DataType czzzzzzzzzzzzzzzzzzzw_ = TimeOfDelivery?.Effective;
                    object czzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzw_);
                    bool czzzzzzzzzzzzzzzzzzzy_ = czzzzzzzzzzzzzzzzzzzx_ is CqlDateTime;

                    return czzzzzzzzzzzzzzzzzzzy_;
                };
                if (czzzzzzzzzzzzzzzzzzzn_())
                {
                    DataType czzzzzzzzzzzzzzzzzzzz_ = TimeOfDelivery?.Effective;
                    object dzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzz_);

                    return (dzzzzzzzzzzzzzzzzzzza_ as CqlDateTime) as object;
                }
                else if (czzzzzzzzzzzzzzzzzzzo_())
                {
                    DataType dzzzzzzzzzzzzzzzzzzzb_ = TimeOfDelivery?.Effective;
                    object dzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzb_);

                    return (dzzzzzzzzzzzzzzzzzzzc_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (czzzzzzzzzzzzzzzzzzzp_())
                {
                    DataType dzzzzzzzzzzzzzzzzzzzd_ = TimeOfDelivery?.Effective;
                    object dzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzd_);

                    return (dzzzzzzzzzzzzzzzzzzze_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime czzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzd_());
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzf_ = this.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
            bool? czzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzzzzzf_, default);
            bool? czzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzzzzzg_);
            object czzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzt_);
            bool? czzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzj_ as CqlDateTime, czzzzzzzzzzzzzzzzzzzf_, default);
            bool? czzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzzzzzzl_);

            return czzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzzzzzzzzl_, bzzzzzzzzzzzzzzzzzzzm_);
        object bzzzzzzzzzzzzzzzzzzzo_(Observation @this)
        {
            object dzzzzzzzzzzzzzzzzzzzf_()
            {
                bool dzzzzzzzzzzzzzzzzzzzh_()
                {
                    DataType dzzzzzzzzzzzzzzzzzzzk_ = @this?.Effective;
                    object dzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzk_);
                    bool dzzzzzzzzzzzzzzzzzzzm_ = dzzzzzzzzzzzzzzzzzzzl_ is CqlDateTime;

                    return dzzzzzzzzzzzzzzzzzzzm_;
                };
                bool dzzzzzzzzzzzzzzzzzzzi_()
                {
                    DataType dzzzzzzzzzzzzzzzzzzzn_ = @this?.Effective;
                    object dzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzn_);
                    bool dzzzzzzzzzzzzzzzzzzzp_ = dzzzzzzzzzzzzzzzzzzzo_ is CqlInterval<CqlDateTime>;

                    return dzzzzzzzzzzzzzzzzzzzp_;
                };
                bool dzzzzzzzzzzzzzzzzzzzj_()
                {
                    DataType dzzzzzzzzzzzzzzzzzzzq_ = @this?.Effective;
                    object dzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzq_);
                    bool dzzzzzzzzzzzzzzzzzzzs_ = dzzzzzzzzzzzzzzzzzzzr_ is CqlDateTime;

                    return dzzzzzzzzzzzzzzzzzzzs_;
                };
                if (dzzzzzzzzzzzzzzzzzzzh_())
                {
                    DataType dzzzzzzzzzzzzzzzzzzzt_ = @this?.Effective;
                    object dzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzt_);

                    return (dzzzzzzzzzzzzzzzzzzzu_ as CqlDateTime) as object;
                }
                else if (dzzzzzzzzzzzzzzzzzzzi_())
                {
                    DataType dzzzzzzzzzzzzzzzzzzzv_ = @this?.Effective;
                    object dzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzv_);

                    return (dzzzzzzzzzzzzzzzzzzzw_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (dzzzzzzzzzzzzzzzzzzzj_())
                {
                    DataType dzzzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                    object dzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzx_);

                    return (dzzzzzzzzzzzzzzzzzzzy_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime dzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzf_());

            return dzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SortBy<Observation>(bzzzzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzzzzo_, System.ComponentModel.ListSortDirection.Ascending);
        Observation bzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Last<Observation>(bzzzzzzzzzzzzzzzzzzzp_);
        DataType bzzzzzzzzzzzzzzzzzzzr_ = bzzzzzzzzzzzzzzzzzzzq_?.Value;
        object bzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzr_);

        return bzzzzzzzzzzzzzzzzzzzs_ as CqlDateTime;
    }


    [CqlExpressionDefinition("lastEstimatedDeliveryDate")]
    public CqlDateTime lastEstimatedDeliveryDate(CqlContext context, Encounter TheEncounter)
    {
        CqlCode dzzzzzzzzzzzzzzzzzzzz_ = this.Delivery_date_Estimated(context);
        IEnumerable<CqlCode> ezzzzzzzzzzzzzzzzzzza_ = context.Operators.ToList<CqlCode>(dzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ezzzzzzzzzzzzzzzzzzza_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? ezzzzzzzzzzzzzzzzzzzc_(Observation EstimatedDateOfDelivery)
        {
            DataType ezzzzzzzzzzzzzzzzzzzj_ = EstimatedDateOfDelivery?.Value;
            object ezzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzj_);
            bool? ezzzzzzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)((ezzzzzzzzzzzzzzzzzzzk_ as CqlDateTime) is null));
            Code<ObservationStatus> ezzzzzzzzzzzzzzzzzzzm_ = EstimatedDateOfDelivery?.StatusElement;
            ObservationStatus? ezzzzzzzzzzzzzzzzzzzn_ = ezzzzzzzzzzzzzzzzzzzm_?.Value;
            Code<ObservationStatus> ezzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<Code<ObservationStatus>>(ezzzzzzzzzzzzzzzzzzzn_);
            string ezzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(ezzzzzzzzzzzzzzzzzzzo_);
            string[] ezzzzzzzzzzzzzzzzzzzq_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ezzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<string>(ezzzzzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzzzzq_ as IEnumerable<string>);
            bool? ezzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzzzzzzr_);
            object ezzzzzzzzzzzzzzzzzzzt_()
            {
                bool fzzzzzzzzzzzzzzzzzzzf_()
                {
                    DataType fzzzzzzzzzzzzzzzzzzzi_ = EstimatedDateOfDelivery?.Effective;
                    object fzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzi_);
                    bool fzzzzzzzzzzzzzzzzzzzk_ = fzzzzzzzzzzzzzzzzzzzj_ is CqlDateTime;

                    return fzzzzzzzzzzzzzzzzzzzk_;
                };
                bool fzzzzzzzzzzzzzzzzzzzg_()
                {
                    DataType fzzzzzzzzzzzzzzzzzzzl_ = EstimatedDateOfDelivery?.Effective;
                    object fzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzl_);
                    bool fzzzzzzzzzzzzzzzzzzzn_ = fzzzzzzzzzzzzzzzzzzzm_ is CqlInterval<CqlDateTime>;

                    return fzzzzzzzzzzzzzzzzzzzn_;
                };
                bool fzzzzzzzzzzzzzzzzzzzh_()
                {
                    DataType fzzzzzzzzzzzzzzzzzzzo_ = EstimatedDateOfDelivery?.Effective;
                    object fzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzo_);
                    bool fzzzzzzzzzzzzzzzzzzzq_ = fzzzzzzzzzzzzzzzzzzzp_ is CqlDateTime;

                    return fzzzzzzzzzzzzzzzzzzzq_;
                };
                if (fzzzzzzzzzzzzzzzzzzzf_())
                {
                    DataType fzzzzzzzzzzzzzzzzzzzr_ = EstimatedDateOfDelivery?.Effective;
                    object fzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzr_);

                    return (fzzzzzzzzzzzzzzzzzzzs_ as CqlDateTime) as object;
                }
                else if (fzzzzzzzzzzzzzzzzzzzg_())
                {
                    DataType fzzzzzzzzzzzzzzzzzzzt_ = EstimatedDateOfDelivery?.Effective;
                    object fzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzt_);

                    return (fzzzzzzzzzzzzzzzzzzzu_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (fzzzzzzzzzzzzzzzzzzzh_())
                {
                    DataType fzzzzzzzzzzzzzzzzzzzv_ = EstimatedDateOfDelivery?.Effective;
                    object fzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzv_);

                    return (fzzzzzzzzzzzzzzzzzzzw_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime ezzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzzzt_());
            CqlDateTime ezzzzzzzzzzzzzzzzzzzv_ = this.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity ezzzzzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime ezzzzzzzzzzzzzzzzzzzx_ = context.Operators.Subtract(ezzzzzzzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzzzzx_, ezzzzzzzzzzzzzzzzzzzv_, true, true);
            bool? fzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzzzz_, default);
            bool? fzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzzzzzv_ is null));
            bool? fzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzza_, fzzzzzzzzzzzzzzzzzzzc_);
            bool? fzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzzzzzzd_);

            return fzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(ezzzzzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzzzzzc_);
        object ezzzzzzzzzzzzzzzzzzze_(Observation @this)
        {
            object fzzzzzzzzzzzzzzzzzzzx_()
            {
                bool fzzzzzzzzzzzzzzzzzzzz_()
                {
                    DataType gzzzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                    object gzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzc_);
                    bool gzzzzzzzzzzzzzzzzzzze_ = gzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                    return gzzzzzzzzzzzzzzzzzzze_;
                };
                bool gzzzzzzzzzzzzzzzzzzza_()
                {
                    DataType gzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                    object gzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzf_);
                    bool gzzzzzzzzzzzzzzzzzzzh_ = gzzzzzzzzzzzzzzzzzzzg_ is CqlInterval<CqlDateTime>;

                    return gzzzzzzzzzzzzzzzzzzzh_;
                };
                bool gzzzzzzzzzzzzzzzzzzzb_()
                {
                    DataType gzzzzzzzzzzzzzzzzzzzi_ = @this?.Effective;
                    object gzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzi_);
                    bool gzzzzzzzzzzzzzzzzzzzk_ = gzzzzzzzzzzzzzzzzzzzj_ is CqlDateTime;

                    return gzzzzzzzzzzzzzzzzzzzk_;
                };
                if (fzzzzzzzzzzzzzzzzzzzz_())
                {
                    DataType gzzzzzzzzzzzzzzzzzzzl_ = @this?.Effective;
                    object gzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzl_);

                    return (gzzzzzzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                }
                else if (gzzzzzzzzzzzzzzzzzzza_())
                {
                    DataType gzzzzzzzzzzzzzzzzzzzn_ = @this?.Effective;
                    object gzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzn_);

                    return (gzzzzzzzzzzzzzzzzzzzo_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (gzzzzzzzzzzzzzzzzzzzb_())
                {
                    DataType gzzzzzzzzzzzzzzzzzzzp_ = @this?.Effective;
                    object gzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzp_);

                    return (gzzzzzzzzzzzzzzzzzzzq_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime fzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzzzzx_());

            return fzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzf_ = context.Operators.SortBy<Observation>(ezzzzzzzzzzzzzzzzzzzd_, ezzzzzzzzzzzzzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
        Observation ezzzzzzzzzzzzzzzzzzzg_ = context.Operators.Last<Observation>(ezzzzzzzzzzzzzzzzzzzf_);
        DataType ezzzzzzzzzzzzzzzzzzzh_ = ezzzzzzzzzzzzzzzzzzzg_?.Value;
        object ezzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzh_);

        return ezzzzzzzzzzzzzzzzzzzi_ as CqlDateTime;
    }


    [CqlExpressionDefinition("calculatedGestationalAge")]
    public int? calculatedGestationalAge(CqlContext context, Encounter TheEncounter)
    {
        CqlDateTime gzzzzzzzzzzzzzzzzzzzr_ = this.lastTimeOfDelivery(context, TheEncounter);
        CqlDateTime gzzzzzzzzzzzzzzzzzzzs_ = this.lastEstimatedDeliveryDate(context, TheEncounter);
        int? gzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DifferenceBetween(gzzzzzzzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzzzzzzzs_, "day");
        int? gzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Subtract(280, gzzzzzzzzzzzzzzzzzzzt_);
        int? gzzzzzzzzzzzzzzzzzzzv_ = context.Operators.TruncatedDivide(gzzzzzzzzzzzzzzzzzzzu_, 7);

        return gzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Variable Calculated Gestational Age")]
    public IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> Variable_Calculated_Gestational_Age(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzw_ = this.Delivery_Encounter_with_Age_Range(context);
        (CqlTupleMetadata, string EncounterID, int? CalculatedCGA)? gzzzzzzzzzzzzzzzzzzzx_(Encounter DeliveryEncounter)
        {
            Id hzzzzzzzzzzzzzzzzzzza_ = DeliveryEncounter?.IdElement;
            string hzzzzzzzzzzzzzzzzzzzb_ = hzzzzzzzzzzzzzzzzzzza_?.Value;
            int? hzzzzzzzzzzzzzzzzzzzc_ = this.calculatedGestationalAge(context, DeliveryEncounter);
            (CqlTupleMetadata, string EncounterID, int? CalculatedCGA)? hzzzzzzzzzzzzzzzzzzzd_ = (CqlTupleMetadata_DjNbNOhJZXGJDNQeiTBabEOBB, hzzzzzzzzzzzzzzzzzzzb_, hzzzzzzzzzzzzzzzzzzzc_);

            return hzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> gzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?>(gzzzzzzzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> gzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?>(gzzzzzzzzzzzzzzzzzzzy_);

        return gzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("lastEstimatedGestationalAge")]
    public CqlQuantity lastEstimatedGestationalAge(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet hzzzzzzzzzzzzzzzzzzze_ = this.Estimated_Gestational_Age_at_Delivery(context);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? hzzzzzzzzzzzzzzzzzzzg_(Observation EstimatedGestationalAge)
        {
            object hzzzzzzzzzzzzzzzzzzzn_()
            {
                bool izzzzzzzzzzzzzzzzzzzx_()
                {
                    DataType jzzzzzzzzzzzzzzzzzzza_ = EstimatedGestationalAge?.Effective;
                    object jzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzza_);
                    bool jzzzzzzzzzzzzzzzzzzzc_ = jzzzzzzzzzzzzzzzzzzzb_ is CqlDateTime;

                    return jzzzzzzzzzzzzzzzzzzzc_;
                };
                bool izzzzzzzzzzzzzzzzzzzy_()
                {
                    DataType jzzzzzzzzzzzzzzzzzzzd_ = EstimatedGestationalAge?.Effective;
                    object jzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzd_);
                    bool jzzzzzzzzzzzzzzzzzzzf_ = jzzzzzzzzzzzzzzzzzzze_ is CqlInterval<CqlDateTime>;

                    return jzzzzzzzzzzzzzzzzzzzf_;
                };
                bool izzzzzzzzzzzzzzzzzzzz_()
                {
                    DataType jzzzzzzzzzzzzzzzzzzzg_ = EstimatedGestationalAge?.Effective;
                    object jzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzg_);
                    bool jzzzzzzzzzzzzzzzzzzzi_ = jzzzzzzzzzzzzzzzzzzzh_ is CqlDateTime;

                    return jzzzzzzzzzzzzzzzzzzzi_;
                };
                if (izzzzzzzzzzzzzzzzzzzx_())
                {
                    DataType jzzzzzzzzzzzzzzzzzzzj_ = EstimatedGestationalAge?.Effective;
                    object jzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzj_);

                    return (jzzzzzzzzzzzzzzzzzzzk_ as CqlDateTime) as object;
                }
                else if (izzzzzzzzzzzzzzzzzzzy_())
                {
                    DataType jzzzzzzzzzzzzzzzzzzzl_ = EstimatedGestationalAge?.Effective;
                    object jzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzl_);

                    return (jzzzzzzzzzzzzzzzzzzzm_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (izzzzzzzzzzzzzzzzzzzz_())
                {
                    DataType jzzzzzzzzzzzzzzzzzzzn_ = EstimatedGestationalAge?.Effective;
                    object jzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzn_);

                    return (jzzzzzzzzzzzzzzzzzzzo_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime hzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzzzn_());
            CqlDateTime hzzzzzzzzzzzzzzzzzzzp_ = this.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity hzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(24m, "hours");
            CqlDateTime hzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Subtract(hzzzzzzzzzzzzzzzzzzzp_, hzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzzzzzp_, true, true);
            bool? hzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzzzzzt_, default);
            bool? hzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzzzzzp_ is null));
            bool? hzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzu_, hzzzzzzzzzzzzzzzzzzzw_);
            DataType hzzzzzzzzzzzzzzzzzzzy_ = EstimatedGestationalAge?.Value;
            object hzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzy_);
            bool? izzzzzzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzzzzzz_ is null));
            bool? izzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzzzzzza_);
            Code<ObservationStatus> izzzzzzzzzzzzzzzzzzzc_ = EstimatedGestationalAge?.StatusElement;
            ObservationStatus? izzzzzzzzzzzzzzzzzzzd_ = izzzzzzzzzzzzzzzzzzzc_?.Value;
            Code<ObservationStatus> izzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<Code<ObservationStatus>>(izzzzzzzzzzzzzzzzzzzd_);
            string izzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzzzzzze_);
            string[] izzzzzzzzzzzzzzzzzzzg_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? izzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<string>(izzzzzzzzzzzzzzzzzzzf_, izzzzzzzzzzzzzzzzzzzg_ as IEnumerable<string>);
            bool? izzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzb_, izzzzzzzzzzzzzzzzzzzh_);
            object izzzzzzzzzzzzzzzzzzzj_()
            {
                bool jzzzzzzzzzzzzzzzzzzzp_()
                {
                    DataType jzzzzzzzzzzzzzzzzzzzs_ = EstimatedGestationalAge?.Effective;
                    object jzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzs_);
                    bool jzzzzzzzzzzzzzzzzzzzu_ = jzzzzzzzzzzzzzzzzzzzt_ is CqlDateTime;

                    return jzzzzzzzzzzzzzzzzzzzu_;
                };
                bool jzzzzzzzzzzzzzzzzzzzq_()
                {
                    DataType jzzzzzzzzzzzzzzzzzzzv_ = EstimatedGestationalAge?.Effective;
                    object jzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzv_);
                    bool jzzzzzzzzzzzzzzzzzzzx_ = jzzzzzzzzzzzzzzzzzzzw_ is CqlInterval<CqlDateTime>;

                    return jzzzzzzzzzzzzzzzzzzzx_;
                };
                bool jzzzzzzzzzzzzzzzzzzzr_()
                {
                    DataType jzzzzzzzzzzzzzzzzzzzy_ = EstimatedGestationalAge?.Effective;
                    object jzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzy_);
                    bool kzzzzzzzzzzzzzzzzzzza_ = jzzzzzzzzzzzzzzzzzzzz_ is CqlDateTime;

                    return kzzzzzzzzzzzzzzzzzzza_;
                };
                if (jzzzzzzzzzzzzzzzzzzzp_())
                {
                    DataType kzzzzzzzzzzzzzzzzzzzb_ = EstimatedGestationalAge?.Effective;
                    object kzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzb_);

                    return (kzzzzzzzzzzzzzzzzzzzc_ as CqlDateTime) as object;
                }
                else if (jzzzzzzzzzzzzzzzzzzzq_())
                {
                    DataType kzzzzzzzzzzzzzzzzzzzd_ = EstimatedGestationalAge?.Effective;
                    object kzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzd_);

                    return (kzzzzzzzzzzzzzzzzzzze_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (jzzzzzzzzzzzzzzzzzzzr_())
                {
                    DataType kzzzzzzzzzzzzzzzzzzzf_ = EstimatedGestationalAge?.Effective;
                    object kzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzf_);

                    return (kzzzzzzzzzzzzzzzzzzzg_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime izzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzzzzj_());
            bool? izzzzzzzzzzzzzzzzzzzm_ = context.Operators.SameAs(izzzzzzzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzzzzzzzp_, "day");
            object izzzzzzzzzzzzzzzzzzzn_()
            {
                bool kzzzzzzzzzzzzzzzzzzzh_()
                {
                    DataType kzzzzzzzzzzzzzzzzzzzk_ = EstimatedGestationalAge?.Effective;
                    object kzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzk_);
                    bool kzzzzzzzzzzzzzzzzzzzm_ = kzzzzzzzzzzzzzzzzzzzl_ is CqlDateTime;

                    return kzzzzzzzzzzzzzzzzzzzm_;
                };
                bool kzzzzzzzzzzzzzzzzzzzi_()
                {
                    DataType kzzzzzzzzzzzzzzzzzzzn_ = EstimatedGestationalAge?.Effective;
                    object kzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzn_);
                    bool kzzzzzzzzzzzzzzzzzzzp_ = kzzzzzzzzzzzzzzzzzzzo_ is CqlInterval<CqlDateTime>;

                    return kzzzzzzzzzzzzzzzzzzzp_;
                };
                bool kzzzzzzzzzzzzzzzzzzzj_()
                {
                    DataType kzzzzzzzzzzzzzzzzzzzq_ = EstimatedGestationalAge?.Effective;
                    object kzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzq_);
                    bool kzzzzzzzzzzzzzzzzzzzs_ = kzzzzzzzzzzzzzzzzzzzr_ is CqlDateTime;

                    return kzzzzzzzzzzzzzzzzzzzs_;
                };
                if (kzzzzzzzzzzzzzzzzzzzh_())
                {
                    DataType kzzzzzzzzzzzzzzzzzzzt_ = EstimatedGestationalAge?.Effective;
                    object kzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzt_);

                    return (kzzzzzzzzzzzzzzzzzzzu_ as CqlDateTime) as object;
                }
                else if (kzzzzzzzzzzzzzzzzzzzi_())
                {
                    DataType kzzzzzzzzzzzzzzzzzzzv_ = EstimatedGestationalAge?.Effective;
                    object kzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzv_);

                    return (kzzzzzzzzzzzzzzzzzzzw_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (kzzzzzzzzzzzzzzzzzzzj_())
                {
                    DataType kzzzzzzzzzzzzzzzzzzzx_ = EstimatedGestationalAge?.Effective;
                    object kzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzx_);

                    return (kzzzzzzzzzzzzzzzzzzzy_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime izzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzzzzn_());
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzp_ = this.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
            bool? izzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzzo_, izzzzzzzzzzzzzzzzzzzp_, default);
            bool? izzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzzzzq_);
            object izzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzy_);
            bool? izzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzzzzzt_ is null));
            bool? izzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzr_, izzzzzzzzzzzzzzzzzzzu_);
            bool? izzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzzi_, izzzzzzzzzzzzzzzzzzzv_);

            return izzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzzzzzzg_);
        object hzzzzzzzzzzzzzzzzzzzi_(Observation @this)
        {
            object kzzzzzzzzzzzzzzzzzzzz_()
            {
                bool lzzzzzzzzzzzzzzzzzzzb_()
                {
                    DataType lzzzzzzzzzzzzzzzzzzze_ = @this?.Effective;
                    object lzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzze_);
                    bool lzzzzzzzzzzzzzzzzzzzg_ = lzzzzzzzzzzzzzzzzzzzf_ is CqlDateTime;

                    return lzzzzzzzzzzzzzzzzzzzg_;
                };
                bool lzzzzzzzzzzzzzzzzzzzc_()
                {
                    DataType lzzzzzzzzzzzzzzzzzzzh_ = @this?.Effective;
                    object lzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzh_);
                    bool lzzzzzzzzzzzzzzzzzzzj_ = lzzzzzzzzzzzzzzzzzzzi_ is CqlInterval<CqlDateTime>;

                    return lzzzzzzzzzzzzzzzzzzzj_;
                };
                bool lzzzzzzzzzzzzzzzzzzzd_()
                {
                    DataType lzzzzzzzzzzzzzzzzzzzk_ = @this?.Effective;
                    object lzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzk_);
                    bool lzzzzzzzzzzzzzzzzzzzm_ = lzzzzzzzzzzzzzzzzzzzl_ is CqlDateTime;

                    return lzzzzzzzzzzzzzzzzzzzm_;
                };
                if (lzzzzzzzzzzzzzzzzzzzb_())
                {
                    DataType lzzzzzzzzzzzzzzzzzzzn_ = @this?.Effective;
                    object lzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzn_);

                    return (lzzzzzzzzzzzzzzzzzzzo_ as CqlDateTime) as object;
                }
                else if (lzzzzzzzzzzzzzzzzzzzc_())
                {
                    DataType lzzzzzzzzzzzzzzzzzzzp_ = @this?.Effective;
                    object lzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzp_);

                    return (lzzzzzzzzzzzzzzzzzzzq_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (lzzzzzzzzzzzzzzzzzzzd_())
                {
                    DataType lzzzzzzzzzzzzzzzzzzzr_ = @this?.Effective;
                    object lzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzr_);

                    return (lzzzzzzzzzzzzzzzzzzzs_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime lzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, kzzzzzzzzzzzzzzzzzzzz_());

            return lzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SortBy<Observation>(hzzzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
        Observation hzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Last<Observation>(hzzzzzzzzzzzzzzzzzzzj_);
        DataType hzzzzzzzzzzzzzzzzzzzl_ = hzzzzzzzzzzzzzzzzzzzk_?.Value;
        object hzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzl_);

        return hzzzzzzzzzzzzzzzzzzzm_ as CqlQuantity;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_DjNbNOhJZXGJDNQeiTBabEOBB = new(
        [typeof(string), typeof(int?)],
        ["EncounterID", "CalculatedCGA"]);

    #endregion CqlTupleMetadata Properties

}
