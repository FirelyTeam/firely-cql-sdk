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
[CqlLibrary("CQMCommon", "2.2.000")]
public partial class CQMCommon_2_2_000 : ILibrary, ISingleton<CQMCommon_2_2_000>
{
    private CQMCommon_2_2_000() {}

    public static CQMCommon_2_2_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CQMCommon";
    public string Version => "2.2.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Emergency Department Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Visit(CqlContext _) => _Emergency_Department_Visit;
    private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Intensive Care Unit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.206", valueSetVersion: null)]
    public CqlValueSet Intensive_Care_Unit(CqlContext _) => _Intensive_Care_Unit;
    private static readonly CqlValueSet _Intensive_Care_Unit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.206", null);

    [CqlValueSetDefinition("Observation Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", valueSetVersion: null)]
    public CqlValueSet Observation_Services(CqlContext _) => _Observation_Services;
    private static readonly CqlValueSet _Observation_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    [CqlValueSetDefinition("Outpatient Surgery Service", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.38", valueSetVersion: null)]
    public CqlValueSet Outpatient_Surgery_Service(CqlContext _) => _Outpatient_Surgery_Service;
    private static readonly CqlValueSet _Outpatient_Surgery_Service = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.38", null);

    [CqlValueSetDefinition("Present on Admission or Clinically Undetermined", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", valueSetVersion: null)]
    public CqlValueSet Present_on_Admission_or_Clinically_Undetermined(CqlContext _) => _Present_on_Admission_or_Clinically_Undetermined;
    private static readonly CqlValueSet _Present_on_Admission_or_Clinically_Undetermined = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Billing", codeId: "billing", codeSystem: "http://terminology.hl7.org/CodeSystem/diagnosis-role")]
    public CqlCode Billing(CqlContext _) => _Billing;
    private static readonly CqlCode _Billing = new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("DiagnosisRole")]
    public CqlCodeSystem DiagnosisRole(CqlContext _) => _DiagnosisRole;
    private static readonly CqlCodeSystem _DiagnosisRole = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime tzzz_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime uzza_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> uzzb_ = context.Operators.Interval(tzzz_, uzza_, true, false);
        object uzzc_ = context.ResolveParameter("CQMCommon-2.2.000", "Measurement Period", uzzb_);

        return (CqlInterval<CqlDateTime>)uzzc_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> uzzd_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient uzze_ = context.Operators.SingletonFrom<Patient>(uzzd_);

        return uzze_;
    }


    [CqlExpressionDefinition("Inpatient Encounter")]
    public IEnumerable<Encounter> Inpatient_Encounter(CqlContext context)
    {
        CqlValueSet uzzf_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> uzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? uzzh_(Encounter EncounterInpatient)
        {
            Code<Encounter.EncounterStatus> uzzj_ = EncounterInpatient?.StatusElement;
            Encounter.EncounterStatus? uzzk_ = uzzj_?.Value;
            Code<Encounter.EncounterStatus> uzzl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(uzzk_);
            bool? uzzm_ = context.Operators.Equal(uzzl_, "finished");
            Period uzzn_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime> uzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzn_);
            CqlDateTime uzzp_ = context.Operators.End(uzzo_);
            CqlInterval<CqlDateTime> uzzq_ = this.Measurement_Period(context);
            bool? uzzr_ = context.Operators.In<CqlDateTime>(uzzp_, uzzq_, "day");
            bool? uzzs_ = context.Operators.And(uzzm_, uzzr_);

            return uzzs_;
        };
        IEnumerable<Encounter> uzzi_ = context.Operators.Where<Encounter>(uzzg_, uzzh_);

        return uzzi_;
    }


    [CqlExpressionDefinition("ToDateInterval")]
    [CqlTag("description", "Returns an interval of date values extracted from the input interval of date-time values")]
    [CqlTag("comment", "This function returns an interval constructed using the `date from` extractor on the start\nand end values of the input date-time interval. Note that using a precision specifier such as `day of`\nas part of a timing phrase is preferred to communicate intent to perform day-level comparison, as well\nas for general readability.")]
    public CqlInterval<CqlDate> ToDateInterval(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime uzzt_ = context.Operators.Start(period);
        CqlDate uzzu_ = context.Operators.DateFrom(uzzt_);
        CqlDateTime uzzv_ = context.Operators.End(period);
        CqlDate uzzw_ = context.Operators.DateFrom(uzzv_);
        CqlInterval<CqlDate> uzzx_ = context.Operators.Interval(uzzu_, uzzw_, true, true);

        return uzzx_;
    }


    [CqlExpressionDefinition("LengthInDays")]
    [CqlTag("description", "Calculates the difference in calendar days between the start and end of the given interval.")]
    [CqlTag("deprecated", "This function in deprecated. Use the fluent function `lengthInDays()` instead.")]
    public int? LengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
    {
        CqlDateTime uzzy_ = context.Operators.Start(Value);
        CqlDateTime uzzz_ = context.Operators.End(Value);
        int? vzza_ = context.Operators.DifferenceBetween(uzzy_, uzzz_, "day");

        return vzza_;
    }


    [CqlExpressionDefinition("lengthInDays")]
    [CqlTag("description", "Calculates the difference in calendar days between the start and end of the given interval.")]
    public int? lengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
    {
        CqlDateTime vzzb_ = context.Operators.Start(Value);
        CqlDateTime vzzc_ = context.Operators.End(Value);
        int? vzzd_ = context.Operators.DifferenceBetween(vzzb_, vzzc_, "day");

        return vzzd_;
    }


    [CqlExpressionDefinition("ED Visit")]
    [CqlTag("description", "Returns the most recent emergency department visit, if any, that occurs 1 hour or less prior to the given encounter.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `edVisit()` instead.")]
    public Encounter ED_Visit(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet vzze_ = this.Emergency_Department_Visit(context);
        IEnumerable<Encounter> vzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? vzzg_(Encounter EDVisit)
        {
            Code<Encounter.EncounterStatus> vzzl_ = EDVisit?.StatusElement;
            Encounter.EncounterStatus? vzzm_ = vzzl_?.Value;
            Code<Encounter.EncounterStatus> vzzn_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(vzzm_);
            bool? vzzo_ = context.Operators.Equal(vzzn_, "finished");
            Period vzzp_ = EDVisit?.Period;
            CqlInterval<CqlDateTime> vzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzp_);
            CqlDateTime vzzr_ = context.Operators.End(vzzq_);
            Period vzzs_ = TheEncounter?.Period;
            CqlInterval<CqlDateTime> vzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzs_);
            CqlDateTime vzzu_ = context.Operators.Start(vzzt_);
            CqlQuantity vzzv_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime vzzw_ = context.Operators.Subtract(vzzu_, vzzv_);
            CqlInterval<CqlDateTime> vzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzs_);
            CqlDateTime vzzz_ = context.Operators.Start(vzzy_);
            CqlInterval<CqlDateTime> wzza_ = context.Operators.Interval(vzzw_, vzzz_, true, true);
            bool? wzzb_ = context.Operators.In<CqlDateTime>(vzzr_, wzza_, default);
            CqlInterval<CqlDateTime> wzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzs_);
            CqlDateTime wzze_ = context.Operators.Start(wzzd_);
            bool? wzzf_ = context.Operators.Not((bool?)(wzze_ is null));
            bool? wzzg_ = context.Operators.And(wzzb_, wzzf_);
            bool? wzzh_ = context.Operators.And(vzzo_, wzzg_);

            return wzzh_;
        };
        IEnumerable<Encounter> vzzh_ = context.Operators.Where<Encounter>(vzzf_, vzzg_);
        object vzzi_(Encounter @this)
        {
            Period wzzi_ = @this?.Period;
            CqlInterval<CqlDateTime> wzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzi_);
            CqlDateTime wzzk_ = context.Operators.End(wzzj_);

            return wzzk_;
        };
        IEnumerable<Encounter> vzzj_ = context.Operators.SortBy<Encounter>(vzzh_, vzzi_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter vzzk_ = context.Operators.Last<Encounter>(vzzj_);

        return vzzk_;
    }


    [CqlExpressionDefinition("edVisit")]
    [CqlTag("description", "Returns the most recent emergency department visit, if any, that occurs 1 hour or less prior to the given encounter.")]
    public Encounter edVisit(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet wzzl_ = this.Emergency_Department_Visit(context);
        IEnumerable<Encounter> wzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? wzzn_(Encounter EDVisit)
        {
            Code<Encounter.EncounterStatus> wzzs_ = EDVisit?.StatusElement;
            Encounter.EncounterStatus? wzzt_ = wzzs_?.Value;
            Code<Encounter.EncounterStatus> wzzu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(wzzt_);
            bool? wzzv_ = context.Operators.Equal(wzzu_, "finished");
            Period wzzw_ = EDVisit?.Period;
            CqlInterval<CqlDateTime> wzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzw_);
            CqlDateTime wzzy_ = context.Operators.End(wzzx_);
            Period wzzz_ = TheEncounter?.Period;
            CqlInterval<CqlDateTime> xzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzz_);
            CqlDateTime xzzb_ = context.Operators.Start(xzza_);
            CqlQuantity xzzc_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime xzzd_ = context.Operators.Subtract(xzzb_, xzzc_);
            CqlInterval<CqlDateTime> xzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzz_);
            CqlDateTime xzzg_ = context.Operators.Start(xzzf_);
            CqlInterval<CqlDateTime> xzzh_ = context.Operators.Interval(xzzd_, xzzg_, true, true);
            bool? xzzi_ = context.Operators.In<CqlDateTime>(wzzy_, xzzh_, default);
            CqlInterval<CqlDateTime> xzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzz_);
            CqlDateTime xzzl_ = context.Operators.Start(xzzk_);
            bool? xzzm_ = context.Operators.Not((bool?)(xzzl_ is null));
            bool? xzzn_ = context.Operators.And(xzzi_, xzzm_);
            bool? xzzo_ = context.Operators.And(wzzv_, xzzn_);

            return xzzo_;
        };
        IEnumerable<Encounter> wzzo_ = context.Operators.Where<Encounter>(wzzm_, wzzn_);
        object wzzp_(Encounter @this)
        {
            Period xzzp_ = @this?.Period;
            CqlInterval<CqlDateTime> xzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzp_);
            CqlDateTime xzzr_ = context.Operators.End(xzzq_);

            return xzzr_;
        };
        IEnumerable<Encounter> wzzq_ = context.Operators.SortBy<Encounter>(wzzo_, wzzp_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter wzzr_ = context.Operators.Last<Encounter>(wzzq_);

        return wzzr_;
    }


    [CqlExpressionDefinition("Hospitalization")]
    [CqlTag("description", "Hospitalization returns the total interval for admission to discharge for the given encounter, or for the admission of any immediately prior emergency department visit to the discharge of the given encounter.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalization()` instead.")]
    public CqlInterval<CqlDateTime> Hospitalization(CqlContext context, Encounter TheEncounter)
    {
        Encounter xzzs_ = this.ED_Visit(context, TheEncounter);
        Encounter[] xzzt_ = [
            xzzs_,
        ];
        CqlInterval<CqlDateTime> xzzu_(Encounter X)
        {
            CqlInterval<CqlDateTime> xzzy_()
            {
                if (X is null)
                {
                    Period xzzz_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> yzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzz_);

                    return yzza_;
                }
                else
                {
                    Period yzzb_ = X?.Period;
                    CqlInterval<CqlDateTime> yzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzb_);
                    CqlDateTime yzzd_ = context.Operators.Start(yzzc_);
                    Period yzze_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> yzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzze_);
                    CqlDateTime yzzg_ = context.Operators.End(yzzf_);
                    CqlInterval<CqlDateTime> yzzh_ = context.Operators.Interval(yzzd_, yzzg_, true, false);

                    return yzzh_;
                }
            };

            return xzzy_();
        };
        IEnumerable<CqlInterval<CqlDateTime>> xzzv_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)xzzt_, xzzu_);
        IEnumerable<CqlInterval<CqlDateTime>> xzzw_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(xzzv_);
        CqlInterval<CqlDateTime> xzzx_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(xzzw_);

        return xzzx_;
    }


    [CqlExpressionDefinition("hospitalization")]
    [CqlTag("description", "Hospitalization returns the total interval for admission to discharge for the given encounter, or for the admission of any immediately prior emergency department visit to the discharge of the given encounter.")]
    public CqlInterval<CqlDateTime> hospitalization(CqlContext context, Encounter TheEncounter)
    {
        Encounter yzzi_ = this.edVisit(context, TheEncounter);
        Encounter[] yzzj_ = [
            yzzi_,
        ];
        CqlInterval<CqlDateTime> yzzk_(Encounter X)
        {
            CqlInterval<CqlDateTime> yzzo_()
            {
                if (X is null)
                {
                    Period yzzp_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> yzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzp_);

                    return yzzq_;
                }
                else
                {
                    Period yzzr_ = X?.Period;
                    CqlInterval<CqlDateTime> yzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzr_);
                    CqlDateTime yzzt_ = context.Operators.Start(yzzs_);
                    Period yzzu_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> yzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzu_);
                    CqlDateTime yzzw_ = context.Operators.End(yzzv_);
                    CqlInterval<CqlDateTime> yzzx_ = context.Operators.Interval(yzzt_, yzzw_, true, true);

                    return yzzx_;
                }
            };

            return yzzo_();
        };
        IEnumerable<CqlInterval<CqlDateTime>> yzzl_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)yzzj_, yzzk_);
        IEnumerable<CqlInterval<CqlDateTime>> yzzm_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(yzzl_);
        CqlInterval<CqlDateTime> yzzn_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(yzzm_);

        return yzzn_;
    }


    [CqlExpressionDefinition("Hospitalization Locations")]
    [CqlTag("description", "Returns list of all locations within an encounter, including locations for immediately prior ED visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationLocations()` instead.")]
    public IEnumerable<Encounter.LocationComponent> Hospitalization_Locations(CqlContext context, Encounter TheEncounter)
    {
        Encounter yzzy_ = this.ED_Visit(context, TheEncounter);
        Encounter[] yzzz_ = [
            yzzy_,
        ];
        IEnumerable<Encounter.LocationComponent> zzza_(Encounter EDEncounter)
        {
            IEnumerable<Encounter.LocationComponent> zzze_()
            {
                if (EDEncounter is null)
                {
                    List<Encounter.LocationComponent> zzzf_ = TheEncounter?.Location;

                    return (IEnumerable<Encounter.LocationComponent>)zzzf_;
                }
                else
                {
                    List<Encounter.LocationComponent> zzzg_ = EDEncounter?.Location;
                    List<Encounter.LocationComponent> zzzh_ = TheEncounter?.Location;
                    IEnumerable<Encounter.LocationComponent>[] zzzi_ = [
                        (IEnumerable<Encounter.LocationComponent>)zzzg_,
                        (IEnumerable<Encounter.LocationComponent>)zzzh_,
                    ];
                    IEnumerable<Encounter.LocationComponent> zzzj_ = context.Operators.Flatten<Encounter.LocationComponent>(zzzi_ as IEnumerable<IEnumerable<Encounter.LocationComponent>>);

                    return zzzj_;
                }
            };

            return zzze_();
        };
        IEnumerable<IEnumerable<Encounter.LocationComponent>> zzzb_ = context.Operators.Select<Encounter, IEnumerable<Encounter.LocationComponent>>((IEnumerable<Encounter>)yzzz_, zzza_);
        IEnumerable<IEnumerable<Encounter.LocationComponent>> zzzc_ = context.Operators.Distinct<IEnumerable<Encounter.LocationComponent>>(zzzb_);
        IEnumerable<Encounter.LocationComponent> zzzd_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(zzzc_);

        return zzzd_;
    }


    [CqlExpressionDefinition("hospitalizationLocations")]
    [CqlTag("description", "Returns list of all locations within an encounter, including locations for immediately prior ED visit.")]
    public IEnumerable<Encounter.LocationComponent> hospitalizationLocations(CqlContext context, Encounter TheEncounter)
    {
        Encounter zzzk_ = this.edVisit(context, TheEncounter);
        Encounter[] zzzl_ = [
            zzzk_,
        ];
        IEnumerable<Encounter.LocationComponent> zzzm_(Encounter EDEncounter)
        {
            IEnumerable<Encounter.LocationComponent> zzzq_()
            {
                if (EDEncounter is null)
                {
                    List<Encounter.LocationComponent> zzzr_ = TheEncounter?.Location;

                    return (IEnumerable<Encounter.LocationComponent>)zzzr_;
                }
                else
                {
                    List<Encounter.LocationComponent> zzzs_ = EDEncounter?.Location;
                    List<Encounter.LocationComponent> zzzt_ = TheEncounter?.Location;
                    IEnumerable<Encounter.LocationComponent>[] zzzu_ = [
                        (IEnumerable<Encounter.LocationComponent>)zzzs_,
                        (IEnumerable<Encounter.LocationComponent>)zzzt_,
                    ];
                    IEnumerable<Encounter.LocationComponent> zzzv_ = context.Operators.Flatten<Encounter.LocationComponent>(zzzu_ as IEnumerable<IEnumerable<Encounter.LocationComponent>>);

                    return zzzv_;
                }
            };

            return zzzq_();
        };
        IEnumerable<IEnumerable<Encounter.LocationComponent>> zzzn_ = context.Operators.Select<Encounter, IEnumerable<Encounter.LocationComponent>>((IEnumerable<Encounter>)zzzl_, zzzm_);
        IEnumerable<IEnumerable<Encounter.LocationComponent>> zzzo_ = context.Operators.Distinct<IEnumerable<Encounter.LocationComponent>>(zzzn_);
        IEnumerable<Encounter.LocationComponent> zzzp_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(zzzo_);

        return zzzp_;
    }


    [CqlExpressionDefinition("Hospitalization Length of Stay")]
    [CqlTag("description", "Returns the length of stay in days (i.e. the number of days between admission and discharge) for the given encounter, or from the admission of any immediately prior emergency department visit to the discharge of the encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationLengthOfStay()` instead.")]
    public int? Hospitalization_Length_of_Stay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> zzzw_ = this.Hospitalization(context, TheEncounter);
        int? zzzx_ = this.LengthInDays(context, zzzw_);

        return zzzx_;
    }


    [CqlExpressionDefinition("hospitalizationLengthOfStay")]
    [CqlTag("description", "Returns the length of stay in days (i.e. the number of days between admission and discharge) for the given encounter, or from the admission of any immediately prior emergency department visit to the discharge of the encounter")]
    public int? hospitalizationLengthOfStay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> zzzy_ = this.hospitalization(context, TheEncounter);
        int? zzzz_ = this.lengthInDays(context, zzzy_);

        return zzzz_;
    }


    [CqlExpressionDefinition("Hospital Admission Time")]
    [CqlTag("description", "Returns admission time for an encounter or for immediately prior emergency department visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalAdmissionTime()` instead.")]
    public CqlDateTime Hospital_Admission_Time(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> azzza_ = this.Hospitalization(context, TheEncounter);
        CqlDateTime azzzb_ = context.Operators.Start(azzza_);

        return azzzb_;
    }


    [CqlExpressionDefinition("hospitalAdmissionTime")]
    [CqlTag("description", "Returns admission time for an encounter or for immediately prior emergency department visit.")]
    public CqlDateTime hospitalAdmissionTime(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> azzzc_ = this.hospitalization(context, TheEncounter);
        CqlDateTime azzzd_ = context.Operators.Start(azzzc_);

        return azzzd_;
    }


    [CqlExpressionDefinition("Hospital Discharge Time")]
    [CqlTag("description", "Hospital Discharge Time returns the discharge time for an encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalDischargeTime()` instead.")]
    public CqlDateTime Hospital_Discharge_Time(CqlContext context, Encounter TheEncounter)
    {
        Period azzze_ = TheEncounter?.Period;
        CqlInterval<CqlDateTime> azzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzze_);
        CqlDateTime azzzg_ = context.Operators.End(azzzf_);

        return azzzg_;
    }


    [CqlExpressionDefinition("hospitalDischargeTime")]
    [CqlTag("description", "Hospital Discharge Time returns the discharge time for an encounter")]
    public CqlDateTime hospitalDischargeTime(CqlContext context, Encounter TheEncounter)
    {
        Period azzzh_ = TheEncounter?.Period;
        CqlInterval<CqlDateTime> azzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzh_);
        CqlDateTime azzzj_ = context.Operators.End(azzzi_);

        return azzzj_;
    }


    [CqlExpressionDefinition("Hospital Arrival Time")]
    [CqlTag("description", "Returns earliest arrival time for an encounter including any prior ED visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalArrivalTime()` instead.")]
    public CqlDateTime Hospital_Arrival_Time(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> azzzk_ = this.Hospitalization_Locations(context, TheEncounter);
        object azzzl_(Encounter.LocationComponent @this)
        {
            Period azzzr_ = @this?.Period;
            CqlInterval<CqlDateTime> azzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzr_);
            CqlDateTime azzzt_ = context.Operators.Start(azzzs_);

            return azzzt_;
        };
        IEnumerable<Encounter.LocationComponent> azzzm_ = context.Operators.SortBy<Encounter.LocationComponent>(azzzk_, azzzl_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent azzzn_ = context.Operators.First<Encounter.LocationComponent>(azzzm_);
        Period azzzo_ = azzzn_?.Period;
        CqlInterval<CqlDateTime> azzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzo_);
        CqlDateTime azzzq_ = context.Operators.Start(azzzp_);

        return azzzq_;
    }


    [CqlExpressionDefinition("hospitalArrivalTime")]
    [CqlTag("description", "Returns earliest arrival time for an encounter including any prior ED visit.")]
    public CqlDateTime hospitalArrivalTime(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> azzzu_ = this.hospitalizationLocations(context, TheEncounter);
        object azzzv_(Encounter.LocationComponent @this)
        {
            Period bzzzb_ = @this?.Period;
            CqlInterval<CqlDateTime> bzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzb_);
            CqlDateTime bzzzd_ = context.Operators.Start(bzzzc_);

            return bzzzd_;
        };
        IEnumerable<Encounter.LocationComponent> azzzw_ = context.Operators.SortBy<Encounter.LocationComponent>(azzzu_, azzzv_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent azzzx_ = context.Operators.First<Encounter.LocationComponent>(azzzw_);
        Period azzzy_ = azzzx_?.Period;
        CqlInterval<CqlDateTime> azzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzy_);
        CqlDateTime bzzza_ = context.Operators.Start(azzzz_);

        return bzzza_;
    }


    [CqlExpressionDefinition("Hospital Departure Time")]
    [CqlTag("description", "Returns the latest departure time for encounter including any prior ED visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalDepartureTime()` instead.")]
    public CqlDateTime Hospital_Departure_Time(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> bzzze_ = this.Hospitalization_Locations(context, TheEncounter);
        object bzzzf_(Encounter.LocationComponent @this)
        {
            Period bzzzl_ = @this?.Period;
            CqlInterval<CqlDateTime> bzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzl_);
            CqlDateTime bzzzn_ = context.Operators.Start(bzzzm_);

            return bzzzn_;
        };
        IEnumerable<Encounter.LocationComponent> bzzzg_ = context.Operators.SortBy<Encounter.LocationComponent>(bzzze_, bzzzf_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent bzzzh_ = context.Operators.Last<Encounter.LocationComponent>(bzzzg_);
        Period bzzzi_ = bzzzh_?.Period;
        CqlInterval<CqlDateTime> bzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzi_);
        CqlDateTime bzzzk_ = context.Operators.End(bzzzj_);

        return bzzzk_;
    }


    [CqlExpressionDefinition("hospitalDepartureTime")]
    [CqlTag("description", "Returns the latest departure time for encounter including any prior ED visit.")]
    public CqlDateTime hospitalDepartureTime(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> bzzzo_ = this.hospitalizationLocations(context, TheEncounter);
        object bzzzp_(Encounter.LocationComponent @this)
        {
            Period bzzzv_ = @this?.Period;
            CqlInterval<CqlDateTime> bzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzv_);
            CqlDateTime bzzzx_ = context.Operators.Start(bzzzw_);

            return bzzzx_;
        };
        IEnumerable<Encounter.LocationComponent> bzzzq_ = context.Operators.SortBy<Encounter.LocationComponent>(bzzzo_, bzzzp_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent bzzzr_ = context.Operators.Last<Encounter.LocationComponent>(bzzzq_);
        Period bzzzs_ = bzzzr_?.Period;
        CqlInterval<CqlDateTime> bzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzs_);
        CqlDateTime bzzzu_ = context.Operators.End(bzzzt_);

        return bzzzu_;
    }


    [CqlExpressionDefinition("GetLocation")]
    [CqlTag("description", "Returns the Location resource specified by the given reference")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getLocation()` instead.")]
    public Location GetLocation(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Location> bzzzy_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-location"));
        bool? bzzzz_(Location L)
        {
            Id czzzc_ = L?.IdElement;
            string czzzd_ = czzzc_?.Value;
            FhirString czzze_ = reference?.ReferenceElement;
            string czzzf_ = czzze_?.Value;
            string czzzg_ = QICoreCommon_2_1_000.Instance.getId(context, czzzf_);
            bool? czzzh_ = context.Operators.Equal(czzzd_, czzzg_);

            return czzzh_;
        };
        IEnumerable<Location> czzza_ = context.Operators.Where<Location>(bzzzy_, bzzzz_);
        Location czzzb_ = context.Operators.SingletonFrom<Location>(czzza_);

        return czzzb_;
    }


    [CqlExpressionDefinition("Emergency Department Arrival Time")]
    [CqlTag("description", "Returns the emergency department arrival time for the encounter.")]
    public CqlDateTime Emergency_Department_Arrival_Time(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> czzzi_ = this.Hospitalization_Locations(context, TheEncounter);
        bool? czzzj_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference czzzp_ = HospitalLocation?.Location;
            Location czzzq_ = this.GetLocation(context, czzzp_);
            List<CodeableConcept> czzzr_ = czzzq_?.Type;
            CqlConcept czzzs_(CodeableConcept @this)
            {
                CqlConcept czzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return czzzw_;
            };
            IEnumerable<CqlConcept> czzzt_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)czzzr_, czzzs_);
            CqlValueSet czzzu_ = this.Emergency_Department_Visit(context);
            bool? czzzv_ = context.Operators.ConceptsInValueSet(czzzt_, czzzu_);

            return czzzv_;
        };
        IEnumerable<Encounter.LocationComponent> czzzk_ = context.Operators.Where<Encounter.LocationComponent>(czzzi_, czzzj_);
        Encounter.LocationComponent czzzl_ = context.Operators.SingletonFrom<Encounter.LocationComponent>(czzzk_);
        Period czzzm_ = czzzl_?.Period;
        CqlInterval<CqlDateTime> czzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzm_);
        CqlDateTime czzzo_ = context.Operators.Start(czzzn_);

        return czzzo_;
    }


    [CqlExpressionDefinition("emergencyDepartmentArrivalTime")]
    [CqlTag("description", "Returns the emergency department arrival time for the encounter.")]
    public CqlDateTime emergencyDepartmentArrivalTime(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> czzzx_ = this.hospitalizationLocations(context, TheEncounter);
        bool? czzzy_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference dzzze_ = HospitalLocation?.Location;
            Location dzzzf_ = this.GetLocation(context, dzzze_);
            List<CodeableConcept> dzzzg_ = dzzzf_?.Type;
            CqlConcept dzzzh_(CodeableConcept @this)
            {
                CqlConcept dzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return dzzzl_;
            };
            IEnumerable<CqlConcept> dzzzi_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)dzzzg_, dzzzh_);
            CqlValueSet dzzzj_ = this.Emergency_Department_Visit(context);
            bool? dzzzk_ = context.Operators.ConceptsInValueSet(dzzzi_, dzzzj_);

            return dzzzk_;
        };
        IEnumerable<Encounter.LocationComponent> czzzz_ = context.Operators.Where<Encounter.LocationComponent>(czzzx_, czzzy_);
        Encounter.LocationComponent dzzza_ = context.Operators.SingletonFrom<Encounter.LocationComponent>(czzzz_);
        Period dzzzb_ = dzzza_?.Period;
        CqlInterval<CqlDateTime> dzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzb_);
        CqlDateTime dzzzd_ = context.Operators.Start(dzzzc_);

        return dzzzd_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservationAndOutpatientSurgeryService")]
    [CqlTag("description", "Hospitalization with Observation and Outpatient Surgery Service returns the total interval from the start of any immediately prior emergency department visit, outpatient surgery visit or observation visit to the discharge of the given encounter.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationWithObservationAndOutpatientSurgeryService()` instead.")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservationAndOutpatientSurgeryService(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] dzzzm_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> dzzzn_(Encounter Visit)
        {
            CqlValueSet dzzzr_ = this.Outpatient_Surgery_Service(context);
            IEnumerable<Encounter> dzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? dzzzt_(Encounter LastSurgeryOP)
            {
                Period fzzzc_ = LastSurgeryOP?.Period;
                CqlInterval<CqlDateTime> fzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzc_);
                CqlDateTime fzzze_ = context.Operators.End(fzzzd_);
                CqlValueSet fzzzf_ = this.Emergency_Department_Visit(context);
                IEnumerable<Encounter> fzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? fzzzh_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> izzzc_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? izzzd_ = izzzc_?.Value;
                    Code<Encounter.EncounterStatus> izzze_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(izzzd_);
                    bool? izzzf_ = context.Operators.Equal(izzze_, "finished");
                    Period izzzg_ = LastED?.Period;
                    CqlInterval<CqlDateTime> izzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzg_);
                    CqlDateTime izzzi_ = context.Operators.End(izzzh_);
                    CqlValueSet izzzj_ = this.Observation_Services(context);
                    IEnumerable<Encounter> izzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? izzzl_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> kzzzd_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? kzzze_ = kzzzd_?.Value;
                        Code<Encounter.EncounterStatus> kzzzf_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(kzzze_);
                        bool? kzzzg_ = context.Operators.Equal(kzzzf_, "finished");
                        Period kzzzh_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> kzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzh_);
                        CqlDateTime kzzzj_ = context.Operators.End(kzzzi_);
                        Period kzzzk_ = Visit?.Period;
                        CqlInterval<CqlDateTime> kzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzk_);
                        CqlDateTime kzzzm_ = context.Operators.Start(kzzzl_);
                        CqlQuantity kzzzn_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime kzzzo_ = context.Operators.Subtract(kzzzm_, kzzzn_);
                        CqlInterval<CqlDateTime> kzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzk_);
                        CqlDateTime kzzzr_ = context.Operators.Start(kzzzq_);
                        CqlInterval<CqlDateTime> kzzzs_ = context.Operators.Interval(kzzzo_, kzzzr_, true, true);
                        bool? kzzzt_ = context.Operators.In<CqlDateTime>(kzzzj_, kzzzs_, default);
                        CqlInterval<CqlDateTime> kzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzk_);
                        CqlDateTime kzzzw_ = context.Operators.Start(kzzzv_);
                        bool? kzzzx_ = context.Operators.Not((bool?)(kzzzw_ is null));
                        bool? kzzzy_ = context.Operators.And(kzzzt_, kzzzx_);
                        bool? kzzzz_ = context.Operators.And(kzzzg_, kzzzy_);

                        return kzzzz_;
                    };
                    IEnumerable<Encounter> izzzm_ = context.Operators.Where<Encounter>(izzzk_, izzzl_);
                    object izzzn_(Encounter @this)
                    {
                        Period lzzza_ = @this?.Period;
                        CqlInterval<CqlDateTime> lzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzza_);
                        CqlDateTime lzzzc_ = context.Operators.End(lzzzb_);

                        return lzzzc_;
                    };
                    IEnumerable<Encounter> izzzo_ = context.Operators.SortBy<Encounter>(izzzm_, izzzn_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter izzzp_ = context.Operators.Last<Encounter>(izzzo_);
                    Period izzzq_ = izzzp_?.Period;
                    CqlInterval<CqlDateTime> izzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzq_);
                    CqlDateTime izzzs_ = context.Operators.Start(izzzr_);
                    Period izzzt_ = Visit?.Period;
                    CqlInterval<CqlDateTime> izzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzt_);
                    CqlDateTime izzzv_ = context.Operators.Start(izzzu_);
                    CqlQuantity izzzw_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime izzzx_ = context.Operators.Subtract(izzzs_ ?? izzzv_, izzzw_);
                    IEnumerable<Encounter> izzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? jzzza_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> lzzzd_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? lzzze_ = lzzzd_?.Value;
                        Code<Encounter.EncounterStatus> lzzzf_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lzzze_);
                        bool? lzzzg_ = context.Operators.Equal(lzzzf_, "finished");
                        Period lzzzh_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> lzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzh_);
                        CqlDateTime lzzzj_ = context.Operators.End(lzzzi_);
                        Period lzzzk_ = Visit?.Period;
                        CqlInterval<CqlDateTime> lzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzk_);
                        CqlDateTime lzzzm_ = context.Operators.Start(lzzzl_);
                        CqlQuantity lzzzn_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime lzzzo_ = context.Operators.Subtract(lzzzm_, lzzzn_);
                        CqlInterval<CqlDateTime> lzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzk_);
                        CqlDateTime lzzzr_ = context.Operators.Start(lzzzq_);
                        CqlInterval<CqlDateTime> lzzzs_ = context.Operators.Interval(lzzzo_, lzzzr_, true, true);
                        bool? lzzzt_ = context.Operators.In<CqlDateTime>(lzzzj_, lzzzs_, default);
                        CqlInterval<CqlDateTime> lzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzk_);
                        CqlDateTime lzzzw_ = context.Operators.Start(lzzzv_);
                        bool? lzzzx_ = context.Operators.Not((bool?)(lzzzw_ is null));
                        bool? lzzzy_ = context.Operators.And(lzzzt_, lzzzx_);
                        bool? lzzzz_ = context.Operators.And(lzzzg_, lzzzy_);

                        return lzzzz_;
                    };
                    IEnumerable<Encounter> jzzzb_ = context.Operators.Where<Encounter>(izzzz_, jzzza_);
                    object jzzzc_(Encounter @this)
                    {
                        Period mzzza_ = @this?.Period;
                        CqlInterval<CqlDateTime> mzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzza_);
                        CqlDateTime mzzzc_ = context.Operators.End(mzzzb_);

                        return mzzzc_;
                    };
                    IEnumerable<Encounter> jzzzd_ = context.Operators.SortBy<Encounter>(jzzzb_, jzzzc_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter jzzze_ = context.Operators.Last<Encounter>(jzzzd_);
                    Period jzzzf_ = jzzze_?.Period;
                    CqlInterval<CqlDateTime> jzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzf_);
                    CqlDateTime jzzzh_ = context.Operators.Start(jzzzg_);
                    CqlInterval<CqlDateTime> jzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzt_);
                    CqlDateTime jzzzk_ = context.Operators.Start(jzzzj_);
                    CqlInterval<CqlDateTime> jzzzl_ = context.Operators.Interval(izzzx_, jzzzh_ ?? jzzzk_, true, true);
                    bool? jzzzm_ = context.Operators.In<CqlDateTime>(izzzi_, jzzzl_, default);
                    IEnumerable<Encounter> jzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? jzzzp_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> mzzzd_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? mzzze_ = mzzzd_?.Value;
                        Code<Encounter.EncounterStatus> mzzzf_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(mzzze_);
                        bool? mzzzg_ = context.Operators.Equal(mzzzf_, "finished");
                        Period mzzzh_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> mzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzh_);
                        CqlDateTime mzzzj_ = context.Operators.End(mzzzi_);
                        Period mzzzk_ = Visit?.Period;
                        CqlInterval<CqlDateTime> mzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzk_);
                        CqlDateTime mzzzm_ = context.Operators.Start(mzzzl_);
                        CqlQuantity mzzzn_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime mzzzo_ = context.Operators.Subtract(mzzzm_, mzzzn_);
                        CqlInterval<CqlDateTime> mzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzk_);
                        CqlDateTime mzzzr_ = context.Operators.Start(mzzzq_);
                        CqlInterval<CqlDateTime> mzzzs_ = context.Operators.Interval(mzzzo_, mzzzr_, true, true);
                        bool? mzzzt_ = context.Operators.In<CqlDateTime>(mzzzj_, mzzzs_, default);
                        CqlInterval<CqlDateTime> mzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzk_);
                        CqlDateTime mzzzw_ = context.Operators.Start(mzzzv_);
                        bool? mzzzx_ = context.Operators.Not((bool?)(mzzzw_ is null));
                        bool? mzzzy_ = context.Operators.And(mzzzt_, mzzzx_);
                        bool? mzzzz_ = context.Operators.And(mzzzg_, mzzzy_);

                        return mzzzz_;
                    };
                    IEnumerable<Encounter> jzzzq_ = context.Operators.Where<Encounter>(jzzzo_, jzzzp_);
                    object jzzzr_(Encounter @this)
                    {
                        Period nzzza_ = @this?.Period;
                        CqlInterval<CqlDateTime> nzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzza_);
                        CqlDateTime nzzzc_ = context.Operators.End(nzzzb_);

                        return nzzzc_;
                    };
                    IEnumerable<Encounter> jzzzs_ = context.Operators.SortBy<Encounter>(jzzzq_, jzzzr_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter jzzzt_ = context.Operators.Last<Encounter>(jzzzs_);
                    Period jzzzu_ = jzzzt_?.Period;
                    CqlInterval<CqlDateTime> jzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzu_);
                    CqlDateTime jzzzw_ = context.Operators.Start(jzzzv_);
                    CqlInterval<CqlDateTime> jzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzt_);
                    CqlDateTime jzzzz_ = context.Operators.Start(jzzzy_);
                    bool? kzzza_ = context.Operators.Not((bool?)((jzzzw_ ?? jzzzz_) is null));
                    bool? kzzzb_ = context.Operators.And(jzzzm_, kzzza_);
                    bool? kzzzc_ = context.Operators.And(izzzf_, kzzzb_);

                    return kzzzc_;
                };
                IEnumerable<Encounter> fzzzi_ = context.Operators.Where<Encounter>(fzzzg_, fzzzh_);
                object fzzzj_(Encounter @this)
                {
                    Period nzzzd_ = @this?.Period;
                    CqlInterval<CqlDateTime> nzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzd_);
                    CqlDateTime nzzzf_ = context.Operators.End(nzzze_);

                    return nzzzf_;
                };
                IEnumerable<Encounter> fzzzk_ = context.Operators.SortBy<Encounter>(fzzzi_, fzzzj_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter fzzzl_ = context.Operators.Last<Encounter>(fzzzk_);
                Period fzzzm_ = fzzzl_?.Period;
                CqlInterval<CqlDateTime> fzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzm_);
                CqlDateTime fzzzo_ = context.Operators.Start(fzzzn_);
                CqlValueSet fzzzp_ = this.Observation_Services(context);
                IEnumerable<Encounter> fzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? fzzzr_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> nzzzg_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? nzzzh_ = nzzzg_?.Value;
                    Code<Encounter.EncounterStatus> nzzzi_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(nzzzh_);
                    bool? nzzzj_ = context.Operators.Equal(nzzzi_, "finished");
                    Period nzzzk_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> nzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzk_);
                    CqlDateTime nzzzm_ = context.Operators.End(nzzzl_);
                    Period nzzzn_ = Visit?.Period;
                    CqlInterval<CqlDateTime> nzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzn_);
                    CqlDateTime nzzzp_ = context.Operators.Start(nzzzo_);
                    CqlQuantity nzzzq_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime nzzzr_ = context.Operators.Subtract(nzzzp_, nzzzq_);
                    CqlInterval<CqlDateTime> nzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzn_);
                    CqlDateTime nzzzu_ = context.Operators.Start(nzzzt_);
                    CqlInterval<CqlDateTime> nzzzv_ = context.Operators.Interval(nzzzr_, nzzzu_, true, true);
                    bool? nzzzw_ = context.Operators.In<CqlDateTime>(nzzzm_, nzzzv_, default);
                    CqlInterval<CqlDateTime> nzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzn_);
                    CqlDateTime nzzzz_ = context.Operators.Start(nzzzy_);
                    bool? ozzza_ = context.Operators.Not((bool?)(nzzzz_ is null));
                    bool? ozzzb_ = context.Operators.And(nzzzw_, ozzza_);
                    bool? ozzzc_ = context.Operators.And(nzzzj_, ozzzb_);

                    return ozzzc_;
                };
                IEnumerable<Encounter> fzzzs_ = context.Operators.Where<Encounter>(fzzzq_, fzzzr_);
                object fzzzt_(Encounter @this)
                {
                    Period ozzzd_ = @this?.Period;
                    CqlInterval<CqlDateTime> ozzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzd_);
                    CqlDateTime ozzzf_ = context.Operators.End(ozzze_);

                    return ozzzf_;
                };
                IEnumerable<Encounter> fzzzu_ = context.Operators.SortBy<Encounter>(fzzzs_, fzzzt_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter fzzzv_ = context.Operators.Last<Encounter>(fzzzu_);
                Period fzzzw_ = fzzzv_?.Period;
                CqlInterval<CqlDateTime> fzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzw_);
                CqlDateTime fzzzy_ = context.Operators.Start(fzzzx_);
                Period fzzzz_ = Visit?.Period;
                CqlInterval<CqlDateTime> gzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzz_);
                CqlDateTime gzzzb_ = context.Operators.Start(gzzza_);
                CqlQuantity gzzzc_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime gzzzd_ = context.Operators.Subtract(fzzzo_ ?? fzzzy_ ?? gzzzb_, gzzzc_);
                IEnumerable<Encounter> gzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? gzzzg_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> ozzzg_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? ozzzh_ = ozzzg_?.Value;
                    Code<Encounter.EncounterStatus> ozzzi_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ozzzh_);
                    bool? ozzzj_ = context.Operators.Equal(ozzzi_, "finished");
                    Period ozzzk_ = LastED?.Period;
                    CqlInterval<CqlDateTime> ozzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzk_);
                    CqlDateTime ozzzm_ = context.Operators.End(ozzzl_);
                    CqlValueSet ozzzn_ = this.Observation_Services(context);
                    IEnumerable<Encounter> ozzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? ozzzp_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> qzzzh_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? qzzzi_ = qzzzh_?.Value;
                        Code<Encounter.EncounterStatus> qzzzj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(qzzzi_);
                        bool? qzzzk_ = context.Operators.Equal(qzzzj_, "finished");
                        Period qzzzl_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> qzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzl_);
                        CqlDateTime qzzzn_ = context.Operators.End(qzzzm_);
                        Period qzzzo_ = Visit?.Period;
                        CqlInterval<CqlDateTime> qzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzo_);
                        CqlDateTime qzzzq_ = context.Operators.Start(qzzzp_);
                        CqlQuantity qzzzr_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime qzzzs_ = context.Operators.Subtract(qzzzq_, qzzzr_);
                        CqlInterval<CqlDateTime> qzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzo_);
                        CqlDateTime qzzzv_ = context.Operators.Start(qzzzu_);
                        CqlInterval<CqlDateTime> qzzzw_ = context.Operators.Interval(qzzzs_, qzzzv_, true, true);
                        bool? qzzzx_ = context.Operators.In<CqlDateTime>(qzzzn_, qzzzw_, default);
                        CqlInterval<CqlDateTime> qzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzo_);
                        CqlDateTime rzzza_ = context.Operators.Start(qzzzz_);
                        bool? rzzzb_ = context.Operators.Not((bool?)(rzzza_ is null));
                        bool? rzzzc_ = context.Operators.And(qzzzx_, rzzzb_);
                        bool? rzzzd_ = context.Operators.And(qzzzk_, rzzzc_);

                        return rzzzd_;
                    };
                    IEnumerable<Encounter> ozzzq_ = context.Operators.Where<Encounter>(ozzzo_, ozzzp_);
                    object ozzzr_(Encounter @this)
                    {
                        Period rzzze_ = @this?.Period;
                        CqlInterval<CqlDateTime> rzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzze_);
                        CqlDateTime rzzzg_ = context.Operators.End(rzzzf_);

                        return rzzzg_;
                    };
                    IEnumerable<Encounter> ozzzs_ = context.Operators.SortBy<Encounter>(ozzzq_, ozzzr_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter ozzzt_ = context.Operators.Last<Encounter>(ozzzs_);
                    Period ozzzu_ = ozzzt_?.Period;
                    CqlInterval<CqlDateTime> ozzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzu_);
                    CqlDateTime ozzzw_ = context.Operators.Start(ozzzv_);
                    Period ozzzx_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ozzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzx_);
                    CqlDateTime ozzzz_ = context.Operators.Start(ozzzy_);
                    CqlQuantity pzzza_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime pzzzb_ = context.Operators.Subtract(ozzzw_ ?? ozzzz_, pzzza_);
                    IEnumerable<Encounter> pzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? pzzze_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> rzzzh_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? rzzzi_ = rzzzh_?.Value;
                        Code<Encounter.EncounterStatus> rzzzj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rzzzi_);
                        bool? rzzzk_ = context.Operators.Equal(rzzzj_, "finished");
                        Period rzzzl_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> rzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzl_);
                        CqlDateTime rzzzn_ = context.Operators.End(rzzzm_);
                        Period rzzzo_ = Visit?.Period;
                        CqlInterval<CqlDateTime> rzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzo_);
                        CqlDateTime rzzzq_ = context.Operators.Start(rzzzp_);
                        CqlQuantity rzzzr_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime rzzzs_ = context.Operators.Subtract(rzzzq_, rzzzr_);
                        CqlInterval<CqlDateTime> rzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzo_);
                        CqlDateTime rzzzv_ = context.Operators.Start(rzzzu_);
                        CqlInterval<CqlDateTime> rzzzw_ = context.Operators.Interval(rzzzs_, rzzzv_, true, true);
                        bool? rzzzx_ = context.Operators.In<CqlDateTime>(rzzzn_, rzzzw_, default);
                        CqlInterval<CqlDateTime> rzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzo_);
                        CqlDateTime szzza_ = context.Operators.Start(rzzzz_);
                        bool? szzzb_ = context.Operators.Not((bool?)(szzza_ is null));
                        bool? szzzc_ = context.Operators.And(rzzzx_, szzzb_);
                        bool? szzzd_ = context.Operators.And(rzzzk_, szzzc_);

                        return szzzd_;
                    };
                    IEnumerable<Encounter> pzzzf_ = context.Operators.Where<Encounter>(pzzzd_, pzzze_);
                    object pzzzg_(Encounter @this)
                    {
                        Period szzze_ = @this?.Period;
                        CqlInterval<CqlDateTime> szzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzze_);
                        CqlDateTime szzzg_ = context.Operators.End(szzzf_);

                        return szzzg_;
                    };
                    IEnumerable<Encounter> pzzzh_ = context.Operators.SortBy<Encounter>(pzzzf_, pzzzg_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter pzzzi_ = context.Operators.Last<Encounter>(pzzzh_);
                    Period pzzzj_ = pzzzi_?.Period;
                    CqlInterval<CqlDateTime> pzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzj_);
                    CqlDateTime pzzzl_ = context.Operators.Start(pzzzk_);
                    CqlInterval<CqlDateTime> pzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzx_);
                    CqlDateTime pzzzo_ = context.Operators.Start(pzzzn_);
                    CqlInterval<CqlDateTime> pzzzp_ = context.Operators.Interval(pzzzb_, pzzzl_ ?? pzzzo_, true, true);
                    bool? pzzzq_ = context.Operators.In<CqlDateTime>(ozzzm_, pzzzp_, default);
                    IEnumerable<Encounter> pzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? pzzzt_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> szzzh_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? szzzi_ = szzzh_?.Value;
                        Code<Encounter.EncounterStatus> szzzj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(szzzi_);
                        bool? szzzk_ = context.Operators.Equal(szzzj_, "finished");
                        Period szzzl_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> szzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzl_);
                        CqlDateTime szzzn_ = context.Operators.End(szzzm_);
                        Period szzzo_ = Visit?.Period;
                        CqlInterval<CqlDateTime> szzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzo_);
                        CqlDateTime szzzq_ = context.Operators.Start(szzzp_);
                        CqlQuantity szzzr_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime szzzs_ = context.Operators.Subtract(szzzq_, szzzr_);
                        CqlInterval<CqlDateTime> szzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzo_);
                        CqlDateTime szzzv_ = context.Operators.Start(szzzu_);
                        CqlInterval<CqlDateTime> szzzw_ = context.Operators.Interval(szzzs_, szzzv_, true, true);
                        bool? szzzx_ = context.Operators.In<CqlDateTime>(szzzn_, szzzw_, default);
                        CqlInterval<CqlDateTime> szzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzo_);
                        CqlDateTime tzzza_ = context.Operators.Start(szzzz_);
                        bool? tzzzb_ = context.Operators.Not((bool?)(tzzza_ is null));
                        bool? tzzzc_ = context.Operators.And(szzzx_, tzzzb_);
                        bool? tzzzd_ = context.Operators.And(szzzk_, tzzzc_);

                        return tzzzd_;
                    };
                    IEnumerable<Encounter> pzzzu_ = context.Operators.Where<Encounter>(pzzzs_, pzzzt_);
                    object pzzzv_(Encounter @this)
                    {
                        Period tzzze_ = @this?.Period;
                        CqlInterval<CqlDateTime> tzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzze_);
                        CqlDateTime tzzzg_ = context.Operators.End(tzzzf_);

                        return tzzzg_;
                    };
                    IEnumerable<Encounter> pzzzw_ = context.Operators.SortBy<Encounter>(pzzzu_, pzzzv_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter pzzzx_ = context.Operators.Last<Encounter>(pzzzw_);
                    Period pzzzy_ = pzzzx_?.Period;
                    CqlInterval<CqlDateTime> pzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzy_);
                    CqlDateTime qzzza_ = context.Operators.Start(pzzzz_);
                    CqlInterval<CqlDateTime> qzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzx_);
                    CqlDateTime qzzzd_ = context.Operators.Start(qzzzc_);
                    bool? qzzze_ = context.Operators.Not((bool?)((qzzza_ ?? qzzzd_) is null));
                    bool? qzzzf_ = context.Operators.And(pzzzq_, qzzze_);
                    bool? qzzzg_ = context.Operators.And(ozzzj_, qzzzf_);

                    return qzzzg_;
                };
                IEnumerable<Encounter> gzzzh_ = context.Operators.Where<Encounter>(gzzzf_, gzzzg_);
                object gzzzi_(Encounter @this)
                {
                    Period tzzzh_ = @this?.Period;
                    CqlInterval<CqlDateTime> tzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzh_);
                    CqlDateTime tzzzj_ = context.Operators.End(tzzzi_);

                    return tzzzj_;
                };
                IEnumerable<Encounter> gzzzj_ = context.Operators.SortBy<Encounter>(gzzzh_, gzzzi_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter gzzzk_ = context.Operators.Last<Encounter>(gzzzj_);
                Period gzzzl_ = gzzzk_?.Period;
                CqlInterval<CqlDateTime> gzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzl_);
                CqlDateTime gzzzn_ = context.Operators.Start(gzzzm_);
                IEnumerable<Encounter> gzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? gzzzq_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> tzzzk_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? tzzzl_ = tzzzk_?.Value;
                    Code<Encounter.EncounterStatus> tzzzm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(tzzzl_);
                    bool? tzzzn_ = context.Operators.Equal(tzzzm_, "finished");
                    Period tzzzo_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> tzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzo_);
                    CqlDateTime tzzzq_ = context.Operators.End(tzzzp_);
                    Period tzzzr_ = Visit?.Period;
                    CqlInterval<CqlDateTime> tzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzr_);
                    CqlDateTime tzzzt_ = context.Operators.Start(tzzzs_);
                    CqlQuantity tzzzu_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime tzzzv_ = context.Operators.Subtract(tzzzt_, tzzzu_);
                    CqlInterval<CqlDateTime> tzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzr_);
                    CqlDateTime tzzzy_ = context.Operators.Start(tzzzx_);
                    CqlInterval<CqlDateTime> tzzzz_ = context.Operators.Interval(tzzzv_, tzzzy_, true, true);
                    bool? uzzza_ = context.Operators.In<CqlDateTime>(tzzzq_, tzzzz_, default);
                    CqlInterval<CqlDateTime> uzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzr_);
                    CqlDateTime uzzzd_ = context.Operators.Start(uzzzc_);
                    bool? uzzze_ = context.Operators.Not((bool?)(uzzzd_ is null));
                    bool? uzzzf_ = context.Operators.And(uzzza_, uzzze_);
                    bool? uzzzg_ = context.Operators.And(tzzzn_, uzzzf_);

                    return uzzzg_;
                };
                IEnumerable<Encounter> gzzzr_ = context.Operators.Where<Encounter>(gzzzp_, gzzzq_);
                object gzzzs_(Encounter @this)
                {
                    Period uzzzh_ = @this?.Period;
                    CqlInterval<CqlDateTime> uzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzh_);
                    CqlDateTime uzzzj_ = context.Operators.End(uzzzi_);

                    return uzzzj_;
                };
                IEnumerable<Encounter> gzzzt_ = context.Operators.SortBy<Encounter>(gzzzr_, gzzzs_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter gzzzu_ = context.Operators.Last<Encounter>(gzzzt_);
                Period gzzzv_ = gzzzu_?.Period;
                CqlInterval<CqlDateTime> gzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzv_);
                CqlDateTime gzzzx_ = context.Operators.Start(gzzzw_);
                CqlInterval<CqlDateTime> gzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzz_);
                CqlDateTime hzzza_ = context.Operators.Start(gzzzz_);
                CqlInterval<CqlDateTime> hzzzb_ = context.Operators.Interval(gzzzd_, gzzzn_ ?? gzzzx_ ?? hzzza_, true, true);
                bool? hzzzc_ = context.Operators.In<CqlDateTime>(fzzze_, hzzzb_, default);
                IEnumerable<Encounter> hzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? hzzzf_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> uzzzk_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? uzzzl_ = uzzzk_?.Value;
                    Code<Encounter.EncounterStatus> uzzzm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(uzzzl_);
                    bool? uzzzn_ = context.Operators.Equal(uzzzm_, "finished");
                    Period uzzzo_ = LastED?.Period;
                    CqlInterval<CqlDateTime> uzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzo_);
                    CqlDateTime uzzzq_ = context.Operators.End(uzzzp_);
                    CqlValueSet uzzzr_ = this.Observation_Services(context);
                    IEnumerable<Encounter> uzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? uzzzt_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> wzzzl_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? wzzzm_ = wzzzl_?.Value;
                        Code<Encounter.EncounterStatus> wzzzn_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(wzzzm_);
                        bool? wzzzo_ = context.Operators.Equal(wzzzn_, "finished");
                        Period wzzzp_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> wzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzp_);
                        CqlDateTime wzzzr_ = context.Operators.End(wzzzq_);
                        Period wzzzs_ = Visit?.Period;
                        CqlInterval<CqlDateTime> wzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzs_);
                        CqlDateTime wzzzu_ = context.Operators.Start(wzzzt_);
                        CqlQuantity wzzzv_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime wzzzw_ = context.Operators.Subtract(wzzzu_, wzzzv_);
                        CqlInterval<CqlDateTime> wzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzs_);
                        CqlDateTime wzzzz_ = context.Operators.Start(wzzzy_);
                        CqlInterval<CqlDateTime> xzzza_ = context.Operators.Interval(wzzzw_, wzzzz_, true, true);
                        bool? xzzzb_ = context.Operators.In<CqlDateTime>(wzzzr_, xzzza_, default);
                        CqlInterval<CqlDateTime> xzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzs_);
                        CqlDateTime xzzze_ = context.Operators.Start(xzzzd_);
                        bool? xzzzf_ = context.Operators.Not((bool?)(xzzze_ is null));
                        bool? xzzzg_ = context.Operators.And(xzzzb_, xzzzf_);
                        bool? xzzzh_ = context.Operators.And(wzzzo_, xzzzg_);

                        return xzzzh_;
                    };
                    IEnumerable<Encounter> uzzzu_ = context.Operators.Where<Encounter>(uzzzs_, uzzzt_);
                    object uzzzv_(Encounter @this)
                    {
                        Period xzzzi_ = @this?.Period;
                        CqlInterval<CqlDateTime> xzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzi_);
                        CqlDateTime xzzzk_ = context.Operators.End(xzzzj_);

                        return xzzzk_;
                    };
                    IEnumerable<Encounter> uzzzw_ = context.Operators.SortBy<Encounter>(uzzzu_, uzzzv_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter uzzzx_ = context.Operators.Last<Encounter>(uzzzw_);
                    Period uzzzy_ = uzzzx_?.Period;
                    CqlInterval<CqlDateTime> uzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzy_);
                    CqlDateTime vzzza_ = context.Operators.Start(uzzzz_);
                    Period vzzzb_ = Visit?.Period;
                    CqlInterval<CqlDateTime> vzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzb_);
                    CqlDateTime vzzzd_ = context.Operators.Start(vzzzc_);
                    CqlQuantity vzzze_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime vzzzf_ = context.Operators.Subtract(vzzza_ ?? vzzzd_, vzzze_);
                    IEnumerable<Encounter> vzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? vzzzi_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> xzzzl_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? xzzzm_ = xzzzl_?.Value;
                        Code<Encounter.EncounterStatus> xzzzn_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(xzzzm_);
                        bool? xzzzo_ = context.Operators.Equal(xzzzn_, "finished");
                        Period xzzzp_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> xzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzp_);
                        CqlDateTime xzzzr_ = context.Operators.End(xzzzq_);
                        Period xzzzs_ = Visit?.Period;
                        CqlInterval<CqlDateTime> xzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzs_);
                        CqlDateTime xzzzu_ = context.Operators.Start(xzzzt_);
                        CqlQuantity xzzzv_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime xzzzw_ = context.Operators.Subtract(xzzzu_, xzzzv_);
                        CqlInterval<CqlDateTime> xzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzs_);
                        CqlDateTime xzzzz_ = context.Operators.Start(xzzzy_);
                        CqlInterval<CqlDateTime> yzzza_ = context.Operators.Interval(xzzzw_, xzzzz_, true, true);
                        bool? yzzzb_ = context.Operators.In<CqlDateTime>(xzzzr_, yzzza_, default);
                        CqlInterval<CqlDateTime> yzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzs_);
                        CqlDateTime yzzze_ = context.Operators.Start(yzzzd_);
                        bool? yzzzf_ = context.Operators.Not((bool?)(yzzze_ is null));
                        bool? yzzzg_ = context.Operators.And(yzzzb_, yzzzf_);
                        bool? yzzzh_ = context.Operators.And(xzzzo_, yzzzg_);

                        return yzzzh_;
                    };
                    IEnumerable<Encounter> vzzzj_ = context.Operators.Where<Encounter>(vzzzh_, vzzzi_);
                    object vzzzk_(Encounter @this)
                    {
                        Period yzzzi_ = @this?.Period;
                        CqlInterval<CqlDateTime> yzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzi_);
                        CqlDateTime yzzzk_ = context.Operators.End(yzzzj_);

                        return yzzzk_;
                    };
                    IEnumerable<Encounter> vzzzl_ = context.Operators.SortBy<Encounter>(vzzzj_, vzzzk_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter vzzzm_ = context.Operators.Last<Encounter>(vzzzl_);
                    Period vzzzn_ = vzzzm_?.Period;
                    CqlInterval<CqlDateTime> vzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzn_);
                    CqlDateTime vzzzp_ = context.Operators.Start(vzzzo_);
                    CqlInterval<CqlDateTime> vzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzb_);
                    CqlDateTime vzzzs_ = context.Operators.Start(vzzzr_);
                    CqlInterval<CqlDateTime> vzzzt_ = context.Operators.Interval(vzzzf_, vzzzp_ ?? vzzzs_, true, true);
                    bool? vzzzu_ = context.Operators.In<CqlDateTime>(uzzzq_, vzzzt_, default);
                    IEnumerable<Encounter> vzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? vzzzx_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> yzzzl_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? yzzzm_ = yzzzl_?.Value;
                        Code<Encounter.EncounterStatus> yzzzn_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(yzzzm_);
                        bool? yzzzo_ = context.Operators.Equal(yzzzn_, "finished");
                        Period yzzzp_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> yzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzp_);
                        CqlDateTime yzzzr_ = context.Operators.End(yzzzq_);
                        Period yzzzs_ = Visit?.Period;
                        CqlInterval<CqlDateTime> yzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzs_);
                        CqlDateTime yzzzu_ = context.Operators.Start(yzzzt_);
                        CqlQuantity yzzzv_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime yzzzw_ = context.Operators.Subtract(yzzzu_, yzzzv_);
                        CqlInterval<CqlDateTime> yzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzs_);
                        CqlDateTime yzzzz_ = context.Operators.Start(yzzzy_);
                        CqlInterval<CqlDateTime> zzzza_ = context.Operators.Interval(yzzzw_, yzzzz_, true, true);
                        bool? zzzzb_ = context.Operators.In<CqlDateTime>(yzzzr_, zzzza_, default);
                        CqlInterval<CqlDateTime> zzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzs_);
                        CqlDateTime zzzze_ = context.Operators.Start(zzzzd_);
                        bool? zzzzf_ = context.Operators.Not((bool?)(zzzze_ is null));
                        bool? zzzzg_ = context.Operators.And(zzzzb_, zzzzf_);
                        bool? zzzzh_ = context.Operators.And(yzzzo_, zzzzg_);

                        return zzzzh_;
                    };
                    IEnumerable<Encounter> vzzzy_ = context.Operators.Where<Encounter>(vzzzw_, vzzzx_);
                    object vzzzz_(Encounter @this)
                    {
                        Period zzzzi_ = @this?.Period;
                        CqlInterval<CqlDateTime> zzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzi_);
                        CqlDateTime zzzzk_ = context.Operators.End(zzzzj_);

                        return zzzzk_;
                    };
                    IEnumerable<Encounter> wzzza_ = context.Operators.SortBy<Encounter>(vzzzy_, vzzzz_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter wzzzb_ = context.Operators.Last<Encounter>(wzzza_);
                    Period wzzzc_ = wzzzb_?.Period;
                    CqlInterval<CqlDateTime> wzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzc_);
                    CqlDateTime wzzze_ = context.Operators.Start(wzzzd_);
                    CqlInterval<CqlDateTime> wzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzb_);
                    CqlDateTime wzzzh_ = context.Operators.Start(wzzzg_);
                    bool? wzzzi_ = context.Operators.Not((bool?)((wzzze_ ?? wzzzh_) is null));
                    bool? wzzzj_ = context.Operators.And(vzzzu_, wzzzi_);
                    bool? wzzzk_ = context.Operators.And(uzzzn_, wzzzj_);

                    return wzzzk_;
                };
                IEnumerable<Encounter> hzzzg_ = context.Operators.Where<Encounter>(hzzze_, hzzzf_);
                object hzzzh_(Encounter @this)
                {
                    Period zzzzl_ = @this?.Period;
                    CqlInterval<CqlDateTime> zzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzl_);
                    CqlDateTime zzzzn_ = context.Operators.End(zzzzm_);

                    return zzzzn_;
                };
                IEnumerable<Encounter> hzzzi_ = context.Operators.SortBy<Encounter>(hzzzg_, hzzzh_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter hzzzj_ = context.Operators.Last<Encounter>(hzzzi_);
                Period hzzzk_ = hzzzj_?.Period;
                CqlInterval<CqlDateTime> hzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzk_);
                CqlDateTime hzzzm_ = context.Operators.Start(hzzzl_);
                IEnumerable<Encounter> hzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? hzzzp_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> zzzzo_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? zzzzp_ = zzzzo_?.Value;
                    Code<Encounter.EncounterStatus> zzzzq_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(zzzzp_);
                    bool? zzzzr_ = context.Operators.Equal(zzzzq_, "finished");
                    Period zzzzs_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> zzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzs_);
                    CqlDateTime zzzzu_ = context.Operators.End(zzzzt_);
                    Period zzzzv_ = Visit?.Period;
                    CqlInterval<CqlDateTime> zzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzv_);
                    CqlDateTime zzzzx_ = context.Operators.Start(zzzzw_);
                    CqlQuantity zzzzy_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime zzzzz_ = context.Operators.Subtract(zzzzx_, zzzzy_);
                    CqlInterval<CqlDateTime> azzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzv_);
                    CqlDateTime azzzzc_ = context.Operators.Start(azzzzb_);
                    CqlInterval<CqlDateTime> azzzzd_ = context.Operators.Interval(zzzzz_, azzzzc_, true, true);
                    bool? azzzze_ = context.Operators.In<CqlDateTime>(zzzzu_, azzzzd_, default);
                    CqlInterval<CqlDateTime> azzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzv_);
                    CqlDateTime azzzzh_ = context.Operators.Start(azzzzg_);
                    bool? azzzzi_ = context.Operators.Not((bool?)(azzzzh_ is null));
                    bool? azzzzj_ = context.Operators.And(azzzze_, azzzzi_);
                    bool? azzzzk_ = context.Operators.And(zzzzr_, azzzzj_);

                    return azzzzk_;
                };
                IEnumerable<Encounter> hzzzq_ = context.Operators.Where<Encounter>(hzzzo_, hzzzp_);
                object hzzzr_(Encounter @this)
                {
                    Period azzzzl_ = @this?.Period;
                    CqlInterval<CqlDateTime> azzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzl_);
                    CqlDateTime azzzzn_ = context.Operators.End(azzzzm_);

                    return azzzzn_;
                };
                IEnumerable<Encounter> hzzzs_ = context.Operators.SortBy<Encounter>(hzzzq_, hzzzr_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter hzzzt_ = context.Operators.Last<Encounter>(hzzzs_);
                Period hzzzu_ = hzzzt_?.Period;
                CqlInterval<CqlDateTime> hzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzu_);
                CqlDateTime hzzzw_ = context.Operators.Start(hzzzv_);
                CqlInterval<CqlDateTime> hzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzz_);
                CqlDateTime hzzzz_ = context.Operators.Start(hzzzy_);
                bool? izzza_ = context.Operators.Not((bool?)((hzzzm_ ?? hzzzw_ ?? hzzzz_) is null));
                bool? izzzb_ = context.Operators.And(hzzzc_, izzza_);

                return izzzb_;
            };
            IEnumerable<Encounter> dzzzu_ = context.Operators.Where<Encounter>(dzzzs_, dzzzt_);
            object dzzzv_(Encounter @this)
            {
                Period azzzzo_ = @this?.Period;
                CqlInterval<CqlDateTime> azzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzo_);
                CqlDateTime azzzzq_ = context.Operators.End(azzzzp_);

                return azzzzq_;
            };
            IEnumerable<Encounter> dzzzw_ = context.Operators.SortBy<Encounter>(dzzzu_, dzzzv_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter dzzzx_ = context.Operators.Last<Encounter>(dzzzw_);
            Period dzzzy_ = dzzzx_?.Period;
            CqlInterval<CqlDateTime> dzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzy_);
            CqlDateTime ezzza_ = context.Operators.Start(dzzzz_);
            CqlValueSet ezzzb_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> ezzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? ezzzd_(Encounter LastED)
            {
                Code<Encounter.EncounterStatus> azzzzr_ = LastED?.StatusElement;
                Encounter.EncounterStatus? azzzzs_ = azzzzr_?.Value;
                Code<Encounter.EncounterStatus> azzzzt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(azzzzs_);
                bool? azzzzu_ = context.Operators.Equal(azzzzt_, "finished");
                Period azzzzv_ = LastED?.Period;
                CqlInterval<CqlDateTime> azzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzv_);
                CqlDateTime azzzzx_ = context.Operators.End(azzzzw_);
                CqlValueSet azzzzy_ = this.Observation_Services(context);
                IEnumerable<Encounter> azzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? bzzzza_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> czzzzs_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? czzzzt_ = czzzzs_?.Value;
                    Code<Encounter.EncounterStatus> czzzzu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(czzzzt_);
                    bool? czzzzv_ = context.Operators.Equal(czzzzu_, "finished");
                    Period czzzzw_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> czzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzw_);
                    CqlDateTime czzzzy_ = context.Operators.End(czzzzx_);
                    Period czzzzz_ = Visit?.Period;
                    CqlInterval<CqlDateTime> dzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzz_);
                    CqlDateTime dzzzzb_ = context.Operators.Start(dzzzza_);
                    CqlQuantity dzzzzc_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime dzzzzd_ = context.Operators.Subtract(dzzzzb_, dzzzzc_);
                    CqlInterval<CqlDateTime> dzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzz_);
                    CqlDateTime dzzzzg_ = context.Operators.Start(dzzzzf_);
                    CqlInterval<CqlDateTime> dzzzzh_ = context.Operators.Interval(dzzzzd_, dzzzzg_, true, true);
                    bool? dzzzzi_ = context.Operators.In<CqlDateTime>(czzzzy_, dzzzzh_, default);
                    CqlInterval<CqlDateTime> dzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzz_);
                    CqlDateTime dzzzzl_ = context.Operators.Start(dzzzzk_);
                    bool? dzzzzm_ = context.Operators.Not((bool?)(dzzzzl_ is null));
                    bool? dzzzzn_ = context.Operators.And(dzzzzi_, dzzzzm_);
                    bool? dzzzzo_ = context.Operators.And(czzzzv_, dzzzzn_);

                    return dzzzzo_;
                };
                IEnumerable<Encounter> bzzzzb_ = context.Operators.Where<Encounter>(azzzzz_, bzzzza_);
                object bzzzzc_(Encounter @this)
                {
                    Period dzzzzp_ = @this?.Period;
                    CqlInterval<CqlDateTime> dzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzp_);
                    CqlDateTime dzzzzr_ = context.Operators.End(dzzzzq_);

                    return dzzzzr_;
                };
                IEnumerable<Encounter> bzzzzd_ = context.Operators.SortBy<Encounter>(bzzzzb_, bzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bzzzze_ = context.Operators.Last<Encounter>(bzzzzd_);
                Period bzzzzf_ = bzzzze_?.Period;
                CqlInterval<CqlDateTime> bzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzf_);
                CqlDateTime bzzzzh_ = context.Operators.Start(bzzzzg_);
                Period bzzzzi_ = Visit?.Period;
                CqlInterval<CqlDateTime> bzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzi_);
                CqlDateTime bzzzzk_ = context.Operators.Start(bzzzzj_);
                CqlQuantity bzzzzl_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime bzzzzm_ = context.Operators.Subtract(bzzzzh_ ?? bzzzzk_, bzzzzl_);
                IEnumerable<Encounter> bzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? bzzzzp_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> dzzzzs_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? dzzzzt_ = dzzzzs_?.Value;
                    Code<Encounter.EncounterStatus> dzzzzu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dzzzzt_);
                    bool? dzzzzv_ = context.Operators.Equal(dzzzzu_, "finished");
                    Period dzzzzw_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> dzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzw_);
                    CqlDateTime dzzzzy_ = context.Operators.End(dzzzzx_);
                    Period dzzzzz_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ezzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzz_);
                    CqlDateTime ezzzzb_ = context.Operators.Start(ezzzza_);
                    CqlQuantity ezzzzc_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ezzzzd_ = context.Operators.Subtract(ezzzzb_, ezzzzc_);
                    CqlInterval<CqlDateTime> ezzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzz_);
                    CqlDateTime ezzzzg_ = context.Operators.Start(ezzzzf_);
                    CqlInterval<CqlDateTime> ezzzzh_ = context.Operators.Interval(ezzzzd_, ezzzzg_, true, true);
                    bool? ezzzzi_ = context.Operators.In<CqlDateTime>(dzzzzy_, ezzzzh_, default);
                    CqlInterval<CqlDateTime> ezzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzz_);
                    CqlDateTime ezzzzl_ = context.Operators.Start(ezzzzk_);
                    bool? ezzzzm_ = context.Operators.Not((bool?)(ezzzzl_ is null));
                    bool? ezzzzn_ = context.Operators.And(ezzzzi_, ezzzzm_);
                    bool? ezzzzo_ = context.Operators.And(dzzzzv_, ezzzzn_);

                    return ezzzzo_;
                };
                IEnumerable<Encounter> bzzzzq_ = context.Operators.Where<Encounter>(bzzzzo_, bzzzzp_);
                object bzzzzr_(Encounter @this)
                {
                    Period ezzzzp_ = @this?.Period;
                    CqlInterval<CqlDateTime> ezzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzp_);
                    CqlDateTime ezzzzr_ = context.Operators.End(ezzzzq_);

                    return ezzzzr_;
                };
                IEnumerable<Encounter> bzzzzs_ = context.Operators.SortBy<Encounter>(bzzzzq_, bzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bzzzzt_ = context.Operators.Last<Encounter>(bzzzzs_);
                Period bzzzzu_ = bzzzzt_?.Period;
                CqlInterval<CqlDateTime> bzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzu_);
                CqlDateTime bzzzzw_ = context.Operators.Start(bzzzzv_);
                CqlInterval<CqlDateTime> bzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzi_);
                CqlDateTime bzzzzz_ = context.Operators.Start(bzzzzy_);
                CqlInterval<CqlDateTime> czzzza_ = context.Operators.Interval(bzzzzm_, bzzzzw_ ?? bzzzzz_, true, true);
                bool? czzzzb_ = context.Operators.In<CqlDateTime>(azzzzx_, czzzza_, default);
                IEnumerable<Encounter> czzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? czzzze_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> ezzzzs_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? ezzzzt_ = ezzzzs_?.Value;
                    Code<Encounter.EncounterStatus> ezzzzu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ezzzzt_);
                    bool? ezzzzv_ = context.Operators.Equal(ezzzzu_, "finished");
                    Period ezzzzw_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> ezzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzw_);
                    CqlDateTime ezzzzy_ = context.Operators.End(ezzzzx_);
                    Period ezzzzz_ = Visit?.Period;
                    CqlInterval<CqlDateTime> fzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzz_);
                    CqlDateTime fzzzzb_ = context.Operators.Start(fzzzza_);
                    CqlQuantity fzzzzc_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime fzzzzd_ = context.Operators.Subtract(fzzzzb_, fzzzzc_);
                    CqlInterval<CqlDateTime> fzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzz_);
                    CqlDateTime fzzzzg_ = context.Operators.Start(fzzzzf_);
                    CqlInterval<CqlDateTime> fzzzzh_ = context.Operators.Interval(fzzzzd_, fzzzzg_, true, true);
                    bool? fzzzzi_ = context.Operators.In<CqlDateTime>(ezzzzy_, fzzzzh_, default);
                    CqlInterval<CqlDateTime> fzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzz_);
                    CqlDateTime fzzzzl_ = context.Operators.Start(fzzzzk_);
                    bool? fzzzzm_ = context.Operators.Not((bool?)(fzzzzl_ is null));
                    bool? fzzzzn_ = context.Operators.And(fzzzzi_, fzzzzm_);
                    bool? fzzzzo_ = context.Operators.And(ezzzzv_, fzzzzn_);

                    return fzzzzo_;
                };
                IEnumerable<Encounter> czzzzf_ = context.Operators.Where<Encounter>(czzzzd_, czzzze_);
                object czzzzg_(Encounter @this)
                {
                    Period fzzzzp_ = @this?.Period;
                    CqlInterval<CqlDateTime> fzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzp_);
                    CqlDateTime fzzzzr_ = context.Operators.End(fzzzzq_);

                    return fzzzzr_;
                };
                IEnumerable<Encounter> czzzzh_ = context.Operators.SortBy<Encounter>(czzzzf_, czzzzg_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter czzzzi_ = context.Operators.Last<Encounter>(czzzzh_);
                Period czzzzj_ = czzzzi_?.Period;
                CqlInterval<CqlDateTime> czzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzj_);
                CqlDateTime czzzzl_ = context.Operators.Start(czzzzk_);
                CqlInterval<CqlDateTime> czzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzi_);
                CqlDateTime czzzzo_ = context.Operators.Start(czzzzn_);
                bool? czzzzp_ = context.Operators.Not((bool?)((czzzzl_ ?? czzzzo_) is null));
                bool? czzzzq_ = context.Operators.And(czzzzb_, czzzzp_);
                bool? czzzzr_ = context.Operators.And(azzzzu_, czzzzq_);

                return czzzzr_;
            };
            IEnumerable<Encounter> ezzze_ = context.Operators.Where<Encounter>(ezzzc_, ezzzd_);
            object ezzzf_(Encounter @this)
            {
                Period fzzzzs_ = @this?.Period;
                CqlInterval<CqlDateTime> fzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzs_);
                CqlDateTime fzzzzu_ = context.Operators.End(fzzzzt_);

                return fzzzzu_;
            };
            IEnumerable<Encounter> ezzzg_ = context.Operators.SortBy<Encounter>(ezzze_, ezzzf_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter ezzzh_ = context.Operators.Last<Encounter>(ezzzg_);
            Period ezzzi_ = ezzzh_?.Period;
            CqlInterval<CqlDateTime> ezzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzi_);
            CqlDateTime ezzzk_ = context.Operators.Start(ezzzj_);
            CqlValueSet ezzzl_ = this.Observation_Services(context);
            IEnumerable<Encounter> ezzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? ezzzn_(Encounter LastObs)
            {
                Code<Encounter.EncounterStatus> fzzzzv_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? fzzzzw_ = fzzzzv_?.Value;
                Code<Encounter.EncounterStatus> fzzzzx_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fzzzzw_);
                bool? fzzzzy_ = context.Operators.Equal(fzzzzx_, "finished");
                Period fzzzzz_ = LastObs?.Period;
                CqlInterval<CqlDateTime> gzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzz_);
                CqlDateTime gzzzzb_ = context.Operators.End(gzzzza_);
                Period gzzzzc_ = Visit?.Period;
                CqlInterval<CqlDateTime> gzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzc_);
                CqlDateTime gzzzze_ = context.Operators.Start(gzzzzd_);
                CqlQuantity gzzzzf_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime gzzzzg_ = context.Operators.Subtract(gzzzze_, gzzzzf_);
                CqlInterval<CqlDateTime> gzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzc_);
                CqlDateTime gzzzzj_ = context.Operators.Start(gzzzzi_);
                CqlInterval<CqlDateTime> gzzzzk_ = context.Operators.Interval(gzzzzg_, gzzzzj_, true, true);
                bool? gzzzzl_ = context.Operators.In<CqlDateTime>(gzzzzb_, gzzzzk_, default);
                CqlInterval<CqlDateTime> gzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzc_);
                CqlDateTime gzzzzo_ = context.Operators.Start(gzzzzn_);
                bool? gzzzzp_ = context.Operators.Not((bool?)(gzzzzo_ is null));
                bool? gzzzzq_ = context.Operators.And(gzzzzl_, gzzzzp_);
                bool? gzzzzr_ = context.Operators.And(fzzzzy_, gzzzzq_);

                return gzzzzr_;
            };
            IEnumerable<Encounter> ezzzo_ = context.Operators.Where<Encounter>(ezzzm_, ezzzn_);
            object ezzzp_(Encounter @this)
            {
                Period gzzzzs_ = @this?.Period;
                CqlInterval<CqlDateTime> gzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzs_);
                CqlDateTime gzzzzu_ = context.Operators.End(gzzzzt_);

                return gzzzzu_;
            };
            IEnumerable<Encounter> ezzzq_ = context.Operators.SortBy<Encounter>(ezzzo_, ezzzp_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter ezzzr_ = context.Operators.Last<Encounter>(ezzzq_);
            Period ezzzs_ = ezzzr_?.Period;
            CqlInterval<CqlDateTime> ezzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzs_);
            CqlDateTime ezzzu_ = context.Operators.Start(ezzzt_);
            Period ezzzv_ = Visit?.Period;
            CqlInterval<CqlDateTime> ezzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzv_);
            CqlDateTime ezzzx_ = context.Operators.Start(ezzzw_);
            CqlInterval<CqlDateTime> ezzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzv_);
            CqlDateTime fzzza_ = context.Operators.End(ezzzz_);
            CqlInterval<CqlDateTime> fzzzb_ = context.Operators.Interval(ezzza_ ?? ezzzk_ ?? ezzzu_ ?? ezzzx_, fzzza_, true, true);

            return fzzzb_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> dzzzo_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)dzzzm_, dzzzn_);
        IEnumerable<CqlInterval<CqlDateTime>> dzzzp_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(dzzzo_);
        CqlInterval<CqlDateTime> dzzzq_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(dzzzp_);

        return dzzzq_;
    }


    [CqlExpressionDefinition("hospitalizationWithObservationAndOutpatientSurgeryService")]
    [CqlTag("description", "Hospitalization with Observation and Outpatient Surgery Service returns the total interval from the start of any immediately prior emergency department visit, outpatient surgery visit or observation visit to the discharge of the given encounter.")]
    public CqlInterval<CqlDateTime> hospitalizationWithObservationAndOutpatientSurgeryService(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] gzzzzv_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> gzzzzw_(Encounter Visit)
        {
            CqlValueSet hzzzza_ = this.Outpatient_Surgery_Service(context);
            IEnumerable<Encounter> hzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? hzzzzc_(Encounter LastSurgeryOP)
            {
                Period izzzzl_ = LastSurgeryOP?.Period;
                CqlInterval<CqlDateTime> izzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzl_);
                CqlDateTime izzzzn_ = context.Operators.End(izzzzm_);
                CqlValueSet izzzzo_ = this.Emergency_Department_Visit(context);
                IEnumerable<Encounter> izzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? izzzzq_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> lzzzzl_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? lzzzzm_ = lzzzzl_?.Value;
                    Code<Encounter.EncounterStatus> lzzzzn_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lzzzzm_);
                    bool? lzzzzo_ = context.Operators.Equal(lzzzzn_, "finished");
                    Period lzzzzp_ = LastED?.Period;
                    CqlInterval<CqlDateTime> lzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzp_);
                    CqlDateTime lzzzzr_ = context.Operators.End(lzzzzq_);
                    CqlValueSet lzzzzs_ = this.Observation_Services(context);
                    IEnumerable<Encounter> lzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? lzzzzu_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> nzzzzm_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? nzzzzn_ = nzzzzm_?.Value;
                        Code<Encounter.EncounterStatus> nzzzzo_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(nzzzzn_);
                        bool? nzzzzp_ = context.Operators.Equal(nzzzzo_, "finished");
                        Period nzzzzq_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> nzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzq_);
                        CqlDateTime nzzzzs_ = context.Operators.End(nzzzzr_);
                        Period nzzzzt_ = Visit?.Period;
                        CqlInterval<CqlDateTime> nzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzt_);
                        CqlDateTime nzzzzv_ = context.Operators.Start(nzzzzu_);
                        CqlQuantity nzzzzw_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime nzzzzx_ = context.Operators.Subtract(nzzzzv_, nzzzzw_);
                        CqlInterval<CqlDateTime> nzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzt_);
                        CqlDateTime ozzzza_ = context.Operators.Start(nzzzzz_);
                        CqlInterval<CqlDateTime> ozzzzb_ = context.Operators.Interval(nzzzzx_, ozzzza_, true, true);
                        bool? ozzzzc_ = context.Operators.In<CqlDateTime>(nzzzzs_, ozzzzb_, default);
                        CqlInterval<CqlDateTime> ozzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzt_);
                        CqlDateTime ozzzzf_ = context.Operators.Start(ozzzze_);
                        bool? ozzzzg_ = context.Operators.Not((bool?)(ozzzzf_ is null));
                        bool? ozzzzh_ = context.Operators.And(ozzzzc_, ozzzzg_);
                        bool? ozzzzi_ = context.Operators.And(nzzzzp_, ozzzzh_);

                        return ozzzzi_;
                    };
                    IEnumerable<Encounter> lzzzzv_ = context.Operators.Where<Encounter>(lzzzzt_, lzzzzu_);
                    object lzzzzw_(Encounter @this)
                    {
                        Period ozzzzj_ = @this?.Period;
                        CqlInterval<CqlDateTime> ozzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzj_);
                        CqlDateTime ozzzzl_ = context.Operators.End(ozzzzk_);

                        return ozzzzl_;
                    };
                    IEnumerable<Encounter> lzzzzx_ = context.Operators.SortBy<Encounter>(lzzzzv_, lzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter lzzzzy_ = context.Operators.Last<Encounter>(lzzzzx_);
                    Period lzzzzz_ = lzzzzy_?.Period;
                    CqlInterval<CqlDateTime> mzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzz_);
                    CqlDateTime mzzzzb_ = context.Operators.Start(mzzzza_);
                    Period mzzzzc_ = Visit?.Period;
                    CqlInterval<CqlDateTime> mzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzc_);
                    CqlDateTime mzzzze_ = context.Operators.Start(mzzzzd_);
                    CqlQuantity mzzzzf_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime mzzzzg_ = context.Operators.Subtract(mzzzzb_ ?? mzzzze_, mzzzzf_);
                    IEnumerable<Encounter> mzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? mzzzzj_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> ozzzzm_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? ozzzzn_ = ozzzzm_?.Value;
                        Code<Encounter.EncounterStatus> ozzzzo_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ozzzzn_);
                        bool? ozzzzp_ = context.Operators.Equal(ozzzzo_, "finished");
                        Period ozzzzq_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> ozzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzq_);
                        CqlDateTime ozzzzs_ = context.Operators.End(ozzzzr_);
                        Period ozzzzt_ = Visit?.Period;
                        CqlInterval<CqlDateTime> ozzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzt_);
                        CqlDateTime ozzzzv_ = context.Operators.Start(ozzzzu_);
                        CqlQuantity ozzzzw_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime ozzzzx_ = context.Operators.Subtract(ozzzzv_, ozzzzw_);
                        CqlInterval<CqlDateTime> ozzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzt_);
                        CqlDateTime pzzzza_ = context.Operators.Start(ozzzzz_);
                        CqlInterval<CqlDateTime> pzzzzb_ = context.Operators.Interval(ozzzzx_, pzzzza_, true, true);
                        bool? pzzzzc_ = context.Operators.In<CqlDateTime>(ozzzzs_, pzzzzb_, default);
                        CqlInterval<CqlDateTime> pzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzt_);
                        CqlDateTime pzzzzf_ = context.Operators.Start(pzzzze_);
                        bool? pzzzzg_ = context.Operators.Not((bool?)(pzzzzf_ is null));
                        bool? pzzzzh_ = context.Operators.And(pzzzzc_, pzzzzg_);
                        bool? pzzzzi_ = context.Operators.And(ozzzzp_, pzzzzh_);

                        return pzzzzi_;
                    };
                    IEnumerable<Encounter> mzzzzk_ = context.Operators.Where<Encounter>(mzzzzi_, mzzzzj_);
                    object mzzzzl_(Encounter @this)
                    {
                        Period pzzzzj_ = @this?.Period;
                        CqlInterval<CqlDateTime> pzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzj_);
                        CqlDateTime pzzzzl_ = context.Operators.End(pzzzzk_);

                        return pzzzzl_;
                    };
                    IEnumerable<Encounter> mzzzzm_ = context.Operators.SortBy<Encounter>(mzzzzk_, mzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter mzzzzn_ = context.Operators.Last<Encounter>(mzzzzm_);
                    Period mzzzzo_ = mzzzzn_?.Period;
                    CqlInterval<CqlDateTime> mzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzo_);
                    CqlDateTime mzzzzq_ = context.Operators.Start(mzzzzp_);
                    CqlInterval<CqlDateTime> mzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzc_);
                    CqlDateTime mzzzzt_ = context.Operators.Start(mzzzzs_);
                    CqlInterval<CqlDateTime> mzzzzu_ = context.Operators.Interval(mzzzzg_, mzzzzq_ ?? mzzzzt_, true, true);
                    bool? mzzzzv_ = context.Operators.In<CqlDateTime>(lzzzzr_, mzzzzu_, default);
                    IEnumerable<Encounter> mzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? mzzzzy_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> pzzzzm_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? pzzzzn_ = pzzzzm_?.Value;
                        Code<Encounter.EncounterStatus> pzzzzo_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pzzzzn_);
                        bool? pzzzzp_ = context.Operators.Equal(pzzzzo_, "finished");
                        Period pzzzzq_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> pzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzq_);
                        CqlDateTime pzzzzs_ = context.Operators.End(pzzzzr_);
                        Period pzzzzt_ = Visit?.Period;
                        CqlInterval<CqlDateTime> pzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzt_);
                        CqlDateTime pzzzzv_ = context.Operators.Start(pzzzzu_);
                        CqlQuantity pzzzzw_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime pzzzzx_ = context.Operators.Subtract(pzzzzv_, pzzzzw_);
                        CqlInterval<CqlDateTime> pzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzt_);
                        CqlDateTime qzzzza_ = context.Operators.Start(pzzzzz_);
                        CqlInterval<CqlDateTime> qzzzzb_ = context.Operators.Interval(pzzzzx_, qzzzza_, true, true);
                        bool? qzzzzc_ = context.Operators.In<CqlDateTime>(pzzzzs_, qzzzzb_, default);
                        CqlInterval<CqlDateTime> qzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzt_);
                        CqlDateTime qzzzzf_ = context.Operators.Start(qzzzze_);
                        bool? qzzzzg_ = context.Operators.Not((bool?)(qzzzzf_ is null));
                        bool? qzzzzh_ = context.Operators.And(qzzzzc_, qzzzzg_);
                        bool? qzzzzi_ = context.Operators.And(pzzzzp_, qzzzzh_);

                        return qzzzzi_;
                    };
                    IEnumerable<Encounter> mzzzzz_ = context.Operators.Where<Encounter>(mzzzzx_, mzzzzy_);
                    object nzzzza_(Encounter @this)
                    {
                        Period qzzzzj_ = @this?.Period;
                        CqlInterval<CqlDateTime> qzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzj_);
                        CqlDateTime qzzzzl_ = context.Operators.End(qzzzzk_);

                        return qzzzzl_;
                    };
                    IEnumerable<Encounter> nzzzzb_ = context.Operators.SortBy<Encounter>(mzzzzz_, nzzzza_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter nzzzzc_ = context.Operators.Last<Encounter>(nzzzzb_);
                    Period nzzzzd_ = nzzzzc_?.Period;
                    CqlInterval<CqlDateTime> nzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzd_);
                    CqlDateTime nzzzzf_ = context.Operators.Start(nzzzze_);
                    CqlInterval<CqlDateTime> nzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzc_);
                    CqlDateTime nzzzzi_ = context.Operators.Start(nzzzzh_);
                    bool? nzzzzj_ = context.Operators.Not((bool?)((nzzzzf_ ?? nzzzzi_) is null));
                    bool? nzzzzk_ = context.Operators.And(mzzzzv_, nzzzzj_);
                    bool? nzzzzl_ = context.Operators.And(lzzzzo_, nzzzzk_);

                    return nzzzzl_;
                };
                IEnumerable<Encounter> izzzzr_ = context.Operators.Where<Encounter>(izzzzp_, izzzzq_);
                object izzzzs_(Encounter @this)
                {
                    Period qzzzzm_ = @this?.Period;
                    CqlInterval<CqlDateTime> qzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzm_);
                    CqlDateTime qzzzzo_ = context.Operators.End(qzzzzn_);

                    return qzzzzo_;
                };
                IEnumerable<Encounter> izzzzt_ = context.Operators.SortBy<Encounter>(izzzzr_, izzzzs_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter izzzzu_ = context.Operators.Last<Encounter>(izzzzt_);
                Period izzzzv_ = izzzzu_?.Period;
                CqlInterval<CqlDateTime> izzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzv_);
                CqlDateTime izzzzx_ = context.Operators.Start(izzzzw_);
                CqlValueSet izzzzy_ = this.Observation_Services(context);
                IEnumerable<Encounter> izzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? jzzzza_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> qzzzzp_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? qzzzzq_ = qzzzzp_?.Value;
                    Code<Encounter.EncounterStatus> qzzzzr_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(qzzzzq_);
                    bool? qzzzzs_ = context.Operators.Equal(qzzzzr_, "finished");
                    Period qzzzzt_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> qzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzt_);
                    CqlDateTime qzzzzv_ = context.Operators.End(qzzzzu_);
                    Period qzzzzw_ = Visit?.Period;
                    CqlInterval<CqlDateTime> qzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzw_);
                    CqlDateTime qzzzzy_ = context.Operators.Start(qzzzzx_);
                    CqlQuantity qzzzzz_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime rzzzza_ = context.Operators.Subtract(qzzzzy_, qzzzzz_);
                    CqlInterval<CqlDateTime> rzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzw_);
                    CqlDateTime rzzzzd_ = context.Operators.Start(rzzzzc_);
                    CqlInterval<CqlDateTime> rzzzze_ = context.Operators.Interval(rzzzza_, rzzzzd_, true, true);
                    bool? rzzzzf_ = context.Operators.In<CqlDateTime>(qzzzzv_, rzzzze_, default);
                    CqlInterval<CqlDateTime> rzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzw_);
                    CqlDateTime rzzzzi_ = context.Operators.Start(rzzzzh_);
                    bool? rzzzzj_ = context.Operators.Not((bool?)(rzzzzi_ is null));
                    bool? rzzzzk_ = context.Operators.And(rzzzzf_, rzzzzj_);
                    bool? rzzzzl_ = context.Operators.And(qzzzzs_, rzzzzk_);

                    return rzzzzl_;
                };
                IEnumerable<Encounter> jzzzzb_ = context.Operators.Where<Encounter>(izzzzz_, jzzzza_);
                object jzzzzc_(Encounter @this)
                {
                    Period rzzzzm_ = @this?.Period;
                    CqlInterval<CqlDateTime> rzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzm_);
                    CqlDateTime rzzzzo_ = context.Operators.End(rzzzzn_);

                    return rzzzzo_;
                };
                IEnumerable<Encounter> jzzzzd_ = context.Operators.SortBy<Encounter>(jzzzzb_, jzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter jzzzze_ = context.Operators.Last<Encounter>(jzzzzd_);
                Period jzzzzf_ = jzzzze_?.Period;
                CqlInterval<CqlDateTime> jzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzf_);
                CqlDateTime jzzzzh_ = context.Operators.Start(jzzzzg_);
                Period jzzzzi_ = Visit?.Period;
                CqlInterval<CqlDateTime> jzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzi_);
                CqlDateTime jzzzzk_ = context.Operators.Start(jzzzzj_);
                CqlQuantity jzzzzl_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime jzzzzm_ = context.Operators.Subtract(izzzzx_ ?? jzzzzh_ ?? jzzzzk_, jzzzzl_);
                IEnumerable<Encounter> jzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? jzzzzp_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> rzzzzp_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? rzzzzq_ = rzzzzp_?.Value;
                    Code<Encounter.EncounterStatus> rzzzzr_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rzzzzq_);
                    bool? rzzzzs_ = context.Operators.Equal(rzzzzr_, "finished");
                    Period rzzzzt_ = LastED?.Period;
                    CqlInterval<CqlDateTime> rzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzt_);
                    CqlDateTime rzzzzv_ = context.Operators.End(rzzzzu_);
                    CqlValueSet rzzzzw_ = this.Observation_Services(context);
                    IEnumerable<Encounter> rzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? rzzzzy_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> tzzzzq_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? tzzzzr_ = tzzzzq_?.Value;
                        Code<Encounter.EncounterStatus> tzzzzs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(tzzzzr_);
                        bool? tzzzzt_ = context.Operators.Equal(tzzzzs_, "finished");
                        Period tzzzzu_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> tzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzu_);
                        CqlDateTime tzzzzw_ = context.Operators.End(tzzzzv_);
                        Period tzzzzx_ = Visit?.Period;
                        CqlInterval<CqlDateTime> tzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzx_);
                        CqlDateTime tzzzzz_ = context.Operators.Start(tzzzzy_);
                        CqlQuantity uzzzza_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime uzzzzb_ = context.Operators.Subtract(tzzzzz_, uzzzza_);
                        CqlInterval<CqlDateTime> uzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzx_);
                        CqlDateTime uzzzze_ = context.Operators.Start(uzzzzd_);
                        CqlInterval<CqlDateTime> uzzzzf_ = context.Operators.Interval(uzzzzb_, uzzzze_, true, true);
                        bool? uzzzzg_ = context.Operators.In<CqlDateTime>(tzzzzw_, uzzzzf_, default);
                        CqlInterval<CqlDateTime> uzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzx_);
                        CqlDateTime uzzzzj_ = context.Operators.Start(uzzzzi_);
                        bool? uzzzzk_ = context.Operators.Not((bool?)(uzzzzj_ is null));
                        bool? uzzzzl_ = context.Operators.And(uzzzzg_, uzzzzk_);
                        bool? uzzzzm_ = context.Operators.And(tzzzzt_, uzzzzl_);

                        return uzzzzm_;
                    };
                    IEnumerable<Encounter> rzzzzz_ = context.Operators.Where<Encounter>(rzzzzx_, rzzzzy_);
                    object szzzza_(Encounter @this)
                    {
                        Period uzzzzn_ = @this?.Period;
                        CqlInterval<CqlDateTime> uzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzn_);
                        CqlDateTime uzzzzp_ = context.Operators.End(uzzzzo_);

                        return uzzzzp_;
                    };
                    IEnumerable<Encounter> szzzzb_ = context.Operators.SortBy<Encounter>(rzzzzz_, szzzza_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter szzzzc_ = context.Operators.Last<Encounter>(szzzzb_);
                    Period szzzzd_ = szzzzc_?.Period;
                    CqlInterval<CqlDateTime> szzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzd_);
                    CqlDateTime szzzzf_ = context.Operators.Start(szzzze_);
                    Period szzzzg_ = Visit?.Period;
                    CqlInterval<CqlDateTime> szzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzg_);
                    CqlDateTime szzzzi_ = context.Operators.Start(szzzzh_);
                    CqlQuantity szzzzj_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime szzzzk_ = context.Operators.Subtract(szzzzf_ ?? szzzzi_, szzzzj_);
                    IEnumerable<Encounter> szzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? szzzzn_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> uzzzzq_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? uzzzzr_ = uzzzzq_?.Value;
                        Code<Encounter.EncounterStatus> uzzzzs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(uzzzzr_);
                        bool? uzzzzt_ = context.Operators.Equal(uzzzzs_, "finished");
                        Period uzzzzu_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> uzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzu_);
                        CqlDateTime uzzzzw_ = context.Operators.End(uzzzzv_);
                        Period uzzzzx_ = Visit?.Period;
                        CqlInterval<CqlDateTime> uzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzx_);
                        CqlDateTime uzzzzz_ = context.Operators.Start(uzzzzy_);
                        CqlQuantity vzzzza_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime vzzzzb_ = context.Operators.Subtract(uzzzzz_, vzzzza_);
                        CqlInterval<CqlDateTime> vzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzx_);
                        CqlDateTime vzzzze_ = context.Operators.Start(vzzzzd_);
                        CqlInterval<CqlDateTime> vzzzzf_ = context.Operators.Interval(vzzzzb_, vzzzze_, true, true);
                        bool? vzzzzg_ = context.Operators.In<CqlDateTime>(uzzzzw_, vzzzzf_, default);
                        CqlInterval<CqlDateTime> vzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzx_);
                        CqlDateTime vzzzzj_ = context.Operators.Start(vzzzzi_);
                        bool? vzzzzk_ = context.Operators.Not((bool?)(vzzzzj_ is null));
                        bool? vzzzzl_ = context.Operators.And(vzzzzg_, vzzzzk_);
                        bool? vzzzzm_ = context.Operators.And(uzzzzt_, vzzzzl_);

                        return vzzzzm_;
                    };
                    IEnumerable<Encounter> szzzzo_ = context.Operators.Where<Encounter>(szzzzm_, szzzzn_);
                    object szzzzp_(Encounter @this)
                    {
                        Period vzzzzn_ = @this?.Period;
                        CqlInterval<CqlDateTime> vzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzn_);
                        CqlDateTime vzzzzp_ = context.Operators.End(vzzzzo_);

                        return vzzzzp_;
                    };
                    IEnumerable<Encounter> szzzzq_ = context.Operators.SortBy<Encounter>(szzzzo_, szzzzp_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter szzzzr_ = context.Operators.Last<Encounter>(szzzzq_);
                    Period szzzzs_ = szzzzr_?.Period;
                    CqlInterval<CqlDateTime> szzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzs_);
                    CqlDateTime szzzzu_ = context.Operators.Start(szzzzt_);
                    CqlInterval<CqlDateTime> szzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzg_);
                    CqlDateTime szzzzx_ = context.Operators.Start(szzzzw_);
                    CqlInterval<CqlDateTime> szzzzy_ = context.Operators.Interval(szzzzk_, szzzzu_ ?? szzzzx_, true, true);
                    bool? szzzzz_ = context.Operators.In<CqlDateTime>(rzzzzv_, szzzzy_, default);
                    IEnumerable<Encounter> tzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? tzzzzc_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> vzzzzq_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? vzzzzr_ = vzzzzq_?.Value;
                        Code<Encounter.EncounterStatus> vzzzzs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(vzzzzr_);
                        bool? vzzzzt_ = context.Operators.Equal(vzzzzs_, "finished");
                        Period vzzzzu_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> vzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzu_);
                        CqlDateTime vzzzzw_ = context.Operators.End(vzzzzv_);
                        Period vzzzzx_ = Visit?.Period;
                        CqlInterval<CqlDateTime> vzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzx_);
                        CqlDateTime vzzzzz_ = context.Operators.Start(vzzzzy_);
                        CqlQuantity wzzzza_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime wzzzzb_ = context.Operators.Subtract(vzzzzz_, wzzzza_);
                        CqlInterval<CqlDateTime> wzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzx_);
                        CqlDateTime wzzzze_ = context.Operators.Start(wzzzzd_);
                        CqlInterval<CqlDateTime> wzzzzf_ = context.Operators.Interval(wzzzzb_, wzzzze_, true, true);
                        bool? wzzzzg_ = context.Operators.In<CqlDateTime>(vzzzzw_, wzzzzf_, default);
                        CqlInterval<CqlDateTime> wzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzx_);
                        CqlDateTime wzzzzj_ = context.Operators.Start(wzzzzi_);
                        bool? wzzzzk_ = context.Operators.Not((bool?)(wzzzzj_ is null));
                        bool? wzzzzl_ = context.Operators.And(wzzzzg_, wzzzzk_);
                        bool? wzzzzm_ = context.Operators.And(vzzzzt_, wzzzzl_);

                        return wzzzzm_;
                    };
                    IEnumerable<Encounter> tzzzzd_ = context.Operators.Where<Encounter>(tzzzzb_, tzzzzc_);
                    object tzzzze_(Encounter @this)
                    {
                        Period wzzzzn_ = @this?.Period;
                        CqlInterval<CqlDateTime> wzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzn_);
                        CqlDateTime wzzzzp_ = context.Operators.End(wzzzzo_);

                        return wzzzzp_;
                    };
                    IEnumerable<Encounter> tzzzzf_ = context.Operators.SortBy<Encounter>(tzzzzd_, tzzzze_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter tzzzzg_ = context.Operators.Last<Encounter>(tzzzzf_);
                    Period tzzzzh_ = tzzzzg_?.Period;
                    CqlInterval<CqlDateTime> tzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzh_);
                    CqlDateTime tzzzzj_ = context.Operators.Start(tzzzzi_);
                    CqlInterval<CqlDateTime> tzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzg_);
                    CqlDateTime tzzzzm_ = context.Operators.Start(tzzzzl_);
                    bool? tzzzzn_ = context.Operators.Not((bool?)((tzzzzj_ ?? tzzzzm_) is null));
                    bool? tzzzzo_ = context.Operators.And(szzzzz_, tzzzzn_);
                    bool? tzzzzp_ = context.Operators.And(rzzzzs_, tzzzzo_);

                    return tzzzzp_;
                };
                IEnumerable<Encounter> jzzzzq_ = context.Operators.Where<Encounter>(jzzzzo_, jzzzzp_);
                object jzzzzr_(Encounter @this)
                {
                    Period wzzzzq_ = @this?.Period;
                    CqlInterval<CqlDateTime> wzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzq_);
                    CqlDateTime wzzzzs_ = context.Operators.End(wzzzzr_);

                    return wzzzzs_;
                };
                IEnumerable<Encounter> jzzzzs_ = context.Operators.SortBy<Encounter>(jzzzzq_, jzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter jzzzzt_ = context.Operators.Last<Encounter>(jzzzzs_);
                Period jzzzzu_ = jzzzzt_?.Period;
                CqlInterval<CqlDateTime> jzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzu_);
                CqlDateTime jzzzzw_ = context.Operators.Start(jzzzzv_);
                IEnumerable<Encounter> jzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? jzzzzz_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> wzzzzt_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? wzzzzu_ = wzzzzt_?.Value;
                    Code<Encounter.EncounterStatus> wzzzzv_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(wzzzzu_);
                    bool? wzzzzw_ = context.Operators.Equal(wzzzzv_, "finished");
                    Period wzzzzx_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> wzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzx_);
                    CqlDateTime wzzzzz_ = context.Operators.End(wzzzzy_);
                    Period xzzzza_ = Visit?.Period;
                    CqlInterval<CqlDateTime> xzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzza_);
                    CqlDateTime xzzzzc_ = context.Operators.Start(xzzzzb_);
                    CqlQuantity xzzzzd_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime xzzzze_ = context.Operators.Subtract(xzzzzc_, xzzzzd_);
                    CqlInterval<CqlDateTime> xzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzza_);
                    CqlDateTime xzzzzh_ = context.Operators.Start(xzzzzg_);
                    CqlInterval<CqlDateTime> xzzzzi_ = context.Operators.Interval(xzzzze_, xzzzzh_, true, true);
                    bool? xzzzzj_ = context.Operators.In<CqlDateTime>(wzzzzz_, xzzzzi_, default);
                    CqlInterval<CqlDateTime> xzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzza_);
                    CqlDateTime xzzzzm_ = context.Operators.Start(xzzzzl_);
                    bool? xzzzzn_ = context.Operators.Not((bool?)(xzzzzm_ is null));
                    bool? xzzzzo_ = context.Operators.And(xzzzzj_, xzzzzn_);
                    bool? xzzzzp_ = context.Operators.And(wzzzzw_, xzzzzo_);

                    return xzzzzp_;
                };
                IEnumerable<Encounter> kzzzza_ = context.Operators.Where<Encounter>(jzzzzy_, jzzzzz_);
                object kzzzzb_(Encounter @this)
                {
                    Period xzzzzq_ = @this?.Period;
                    CqlInterval<CqlDateTime> xzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzq_);
                    CqlDateTime xzzzzs_ = context.Operators.End(xzzzzr_);

                    return xzzzzs_;
                };
                IEnumerable<Encounter> kzzzzc_ = context.Operators.SortBy<Encounter>(kzzzza_, kzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter kzzzzd_ = context.Operators.Last<Encounter>(kzzzzc_);
                Period kzzzze_ = kzzzzd_?.Period;
                CqlInterval<CqlDateTime> kzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzze_);
                CqlDateTime kzzzzg_ = context.Operators.Start(kzzzzf_);
                CqlInterval<CqlDateTime> kzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzi_);
                CqlDateTime kzzzzj_ = context.Operators.Start(kzzzzi_);
                CqlInterval<CqlDateTime> kzzzzk_ = context.Operators.Interval(jzzzzm_, jzzzzw_ ?? kzzzzg_ ?? kzzzzj_, true, true);
                bool? kzzzzl_ = context.Operators.In<CqlDateTime>(izzzzn_, kzzzzk_, default);
                IEnumerable<Encounter> kzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? kzzzzo_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> xzzzzt_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? xzzzzu_ = xzzzzt_?.Value;
                    Code<Encounter.EncounterStatus> xzzzzv_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(xzzzzu_);
                    bool? xzzzzw_ = context.Operators.Equal(xzzzzv_, "finished");
                    Period xzzzzx_ = LastED?.Period;
                    CqlInterval<CqlDateTime> xzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzx_);
                    CqlDateTime xzzzzz_ = context.Operators.End(xzzzzy_);
                    CqlValueSet yzzzza_ = this.Observation_Services(context);
                    IEnumerable<Encounter> yzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? yzzzzc_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> zzzzzu_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? zzzzzv_ = zzzzzu_?.Value;
                        Code<Encounter.EncounterStatus> zzzzzw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(zzzzzv_);
                        bool? zzzzzx_ = context.Operators.Equal(zzzzzw_, "finished");
                        Period zzzzzy_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> zzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzy_);
                        CqlDateTime azzzzza_ = context.Operators.End(zzzzzz_);
                        Period azzzzzb_ = Visit?.Period;
                        CqlInterval<CqlDateTime> azzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzb_);
                        CqlDateTime azzzzzd_ = context.Operators.Start(azzzzzc_);
                        CqlQuantity azzzzze_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime azzzzzf_ = context.Operators.Subtract(azzzzzd_, azzzzze_);
                        CqlInterval<CqlDateTime> azzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzb_);
                        CqlDateTime azzzzzi_ = context.Operators.Start(azzzzzh_);
                        CqlInterval<CqlDateTime> azzzzzj_ = context.Operators.Interval(azzzzzf_, azzzzzi_, true, true);
                        bool? azzzzzk_ = context.Operators.In<CqlDateTime>(azzzzza_, azzzzzj_, default);
                        CqlInterval<CqlDateTime> azzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzb_);
                        CqlDateTime azzzzzn_ = context.Operators.Start(azzzzzm_);
                        bool? azzzzzo_ = context.Operators.Not((bool?)(azzzzzn_ is null));
                        bool? azzzzzp_ = context.Operators.And(azzzzzk_, azzzzzo_);
                        bool? azzzzzq_ = context.Operators.And(zzzzzx_, azzzzzp_);

                        return azzzzzq_;
                    };
                    IEnumerable<Encounter> yzzzzd_ = context.Operators.Where<Encounter>(yzzzzb_, yzzzzc_);
                    object yzzzze_(Encounter @this)
                    {
                        Period azzzzzr_ = @this?.Period;
                        CqlInterval<CqlDateTime> azzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzr_);
                        CqlDateTime azzzzzt_ = context.Operators.End(azzzzzs_);

                        return azzzzzt_;
                    };
                    IEnumerable<Encounter> yzzzzf_ = context.Operators.SortBy<Encounter>(yzzzzd_, yzzzze_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter yzzzzg_ = context.Operators.Last<Encounter>(yzzzzf_);
                    Period yzzzzh_ = yzzzzg_?.Period;
                    CqlInterval<CqlDateTime> yzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzh_);
                    CqlDateTime yzzzzj_ = context.Operators.Start(yzzzzi_);
                    Period yzzzzk_ = Visit?.Period;
                    CqlInterval<CqlDateTime> yzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzk_);
                    CqlDateTime yzzzzm_ = context.Operators.Start(yzzzzl_);
                    CqlQuantity yzzzzn_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime yzzzzo_ = context.Operators.Subtract(yzzzzj_ ?? yzzzzm_, yzzzzn_);
                    IEnumerable<Encounter> yzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? yzzzzr_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> azzzzzu_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? azzzzzv_ = azzzzzu_?.Value;
                        Code<Encounter.EncounterStatus> azzzzzw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(azzzzzv_);
                        bool? azzzzzx_ = context.Operators.Equal(azzzzzw_, "finished");
                        Period azzzzzy_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> azzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzy_);
                        CqlDateTime bzzzzza_ = context.Operators.End(azzzzzz_);
                        Period bzzzzzb_ = Visit?.Period;
                        CqlInterval<CqlDateTime> bzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzb_);
                        CqlDateTime bzzzzzd_ = context.Operators.Start(bzzzzzc_);
                        CqlQuantity bzzzzze_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime bzzzzzf_ = context.Operators.Subtract(bzzzzzd_, bzzzzze_);
                        CqlInterval<CqlDateTime> bzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzb_);
                        CqlDateTime bzzzzzi_ = context.Operators.Start(bzzzzzh_);
                        CqlInterval<CqlDateTime> bzzzzzj_ = context.Operators.Interval(bzzzzzf_, bzzzzzi_, true, true);
                        bool? bzzzzzk_ = context.Operators.In<CqlDateTime>(bzzzzza_, bzzzzzj_, default);
                        CqlInterval<CqlDateTime> bzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzb_);
                        CqlDateTime bzzzzzn_ = context.Operators.Start(bzzzzzm_);
                        bool? bzzzzzo_ = context.Operators.Not((bool?)(bzzzzzn_ is null));
                        bool? bzzzzzp_ = context.Operators.And(bzzzzzk_, bzzzzzo_);
                        bool? bzzzzzq_ = context.Operators.And(azzzzzx_, bzzzzzp_);

                        return bzzzzzq_;
                    };
                    IEnumerable<Encounter> yzzzzs_ = context.Operators.Where<Encounter>(yzzzzq_, yzzzzr_);
                    object yzzzzt_(Encounter @this)
                    {
                        Period bzzzzzr_ = @this?.Period;
                        CqlInterval<CqlDateTime> bzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzr_);
                        CqlDateTime bzzzzzt_ = context.Operators.End(bzzzzzs_);

                        return bzzzzzt_;
                    };
                    IEnumerable<Encounter> yzzzzu_ = context.Operators.SortBy<Encounter>(yzzzzs_, yzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter yzzzzv_ = context.Operators.Last<Encounter>(yzzzzu_);
                    Period yzzzzw_ = yzzzzv_?.Period;
                    CqlInterval<CqlDateTime> yzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzw_);
                    CqlDateTime yzzzzy_ = context.Operators.Start(yzzzzx_);
                    CqlInterval<CqlDateTime> zzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzk_);
                    CqlDateTime zzzzzb_ = context.Operators.Start(zzzzza_);
                    CqlInterval<CqlDateTime> zzzzzc_ = context.Operators.Interval(yzzzzo_, yzzzzy_ ?? zzzzzb_, true, true);
                    bool? zzzzzd_ = context.Operators.In<CqlDateTime>(xzzzzz_, zzzzzc_, default);
                    IEnumerable<Encounter> zzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? zzzzzg_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> bzzzzzu_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? bzzzzzv_ = bzzzzzu_?.Value;
                        Code<Encounter.EncounterStatus> bzzzzzw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bzzzzzv_);
                        bool? bzzzzzx_ = context.Operators.Equal(bzzzzzw_, "finished");
                        Period bzzzzzy_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> bzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzy_);
                        CqlDateTime czzzzza_ = context.Operators.End(bzzzzzz_);
                        Period czzzzzb_ = Visit?.Period;
                        CqlInterval<CqlDateTime> czzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzb_);
                        CqlDateTime czzzzzd_ = context.Operators.Start(czzzzzc_);
                        CqlQuantity czzzzze_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime czzzzzf_ = context.Operators.Subtract(czzzzzd_, czzzzze_);
                        CqlInterval<CqlDateTime> czzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzb_);
                        CqlDateTime czzzzzi_ = context.Operators.Start(czzzzzh_);
                        CqlInterval<CqlDateTime> czzzzzj_ = context.Operators.Interval(czzzzzf_, czzzzzi_, true, true);
                        bool? czzzzzk_ = context.Operators.In<CqlDateTime>(czzzzza_, czzzzzj_, default);
                        CqlInterval<CqlDateTime> czzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzb_);
                        CqlDateTime czzzzzn_ = context.Operators.Start(czzzzzm_);
                        bool? czzzzzo_ = context.Operators.Not((bool?)(czzzzzn_ is null));
                        bool? czzzzzp_ = context.Operators.And(czzzzzk_, czzzzzo_);
                        bool? czzzzzq_ = context.Operators.And(bzzzzzx_, czzzzzp_);

                        return czzzzzq_;
                    };
                    IEnumerable<Encounter> zzzzzh_ = context.Operators.Where<Encounter>(zzzzzf_, zzzzzg_);
                    object zzzzzi_(Encounter @this)
                    {
                        Period czzzzzr_ = @this?.Period;
                        CqlInterval<CqlDateTime> czzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzr_);
                        CqlDateTime czzzzzt_ = context.Operators.End(czzzzzs_);

                        return czzzzzt_;
                    };
                    IEnumerable<Encounter> zzzzzj_ = context.Operators.SortBy<Encounter>(zzzzzh_, zzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter zzzzzk_ = context.Operators.Last<Encounter>(zzzzzj_);
                    Period zzzzzl_ = zzzzzk_?.Period;
                    CqlInterval<CqlDateTime> zzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzl_);
                    CqlDateTime zzzzzn_ = context.Operators.Start(zzzzzm_);
                    CqlInterval<CqlDateTime> zzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzk_);
                    CqlDateTime zzzzzq_ = context.Operators.Start(zzzzzp_);
                    bool? zzzzzr_ = context.Operators.Not((bool?)((zzzzzn_ ?? zzzzzq_) is null));
                    bool? zzzzzs_ = context.Operators.And(zzzzzd_, zzzzzr_);
                    bool? zzzzzt_ = context.Operators.And(xzzzzw_, zzzzzs_);

                    return zzzzzt_;
                };
                IEnumerable<Encounter> kzzzzp_ = context.Operators.Where<Encounter>(kzzzzn_, kzzzzo_);
                object kzzzzq_(Encounter @this)
                {
                    Period czzzzzu_ = @this?.Period;
                    CqlInterval<CqlDateTime> czzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzu_);
                    CqlDateTime czzzzzw_ = context.Operators.End(czzzzzv_);

                    return czzzzzw_;
                };
                IEnumerable<Encounter> kzzzzr_ = context.Operators.SortBy<Encounter>(kzzzzp_, kzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter kzzzzs_ = context.Operators.Last<Encounter>(kzzzzr_);
                Period kzzzzt_ = kzzzzs_?.Period;
                CqlInterval<CqlDateTime> kzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzt_);
                CqlDateTime kzzzzv_ = context.Operators.Start(kzzzzu_);
                IEnumerable<Encounter> kzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? kzzzzy_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> czzzzzx_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? czzzzzy_ = czzzzzx_?.Value;
                    Code<Encounter.EncounterStatus> czzzzzz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(czzzzzy_);
                    bool? dzzzzza_ = context.Operators.Equal(czzzzzz_, "finished");
                    Period dzzzzzb_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> dzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzb_);
                    CqlDateTime dzzzzzd_ = context.Operators.End(dzzzzzc_);
                    Period dzzzzze_ = Visit?.Period;
                    CqlInterval<CqlDateTime> dzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzze_);
                    CqlDateTime dzzzzzg_ = context.Operators.Start(dzzzzzf_);
                    CqlQuantity dzzzzzh_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime dzzzzzi_ = context.Operators.Subtract(dzzzzzg_, dzzzzzh_);
                    CqlInterval<CqlDateTime> dzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzze_);
                    CqlDateTime dzzzzzl_ = context.Operators.Start(dzzzzzk_);
                    CqlInterval<CqlDateTime> dzzzzzm_ = context.Operators.Interval(dzzzzzi_, dzzzzzl_, true, true);
                    bool? dzzzzzn_ = context.Operators.In<CqlDateTime>(dzzzzzd_, dzzzzzm_, default);
                    CqlInterval<CqlDateTime> dzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzze_);
                    CqlDateTime dzzzzzq_ = context.Operators.Start(dzzzzzp_);
                    bool? dzzzzzr_ = context.Operators.Not((bool?)(dzzzzzq_ is null));
                    bool? dzzzzzs_ = context.Operators.And(dzzzzzn_, dzzzzzr_);
                    bool? dzzzzzt_ = context.Operators.And(dzzzzza_, dzzzzzs_);

                    return dzzzzzt_;
                };
                IEnumerable<Encounter> kzzzzz_ = context.Operators.Where<Encounter>(kzzzzx_, kzzzzy_);
                object lzzzza_(Encounter @this)
                {
                    Period dzzzzzu_ = @this?.Period;
                    CqlInterval<CqlDateTime> dzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzu_);
                    CqlDateTime dzzzzzw_ = context.Operators.End(dzzzzzv_);

                    return dzzzzzw_;
                };
                IEnumerable<Encounter> lzzzzb_ = context.Operators.SortBy<Encounter>(kzzzzz_, lzzzza_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter lzzzzc_ = context.Operators.Last<Encounter>(lzzzzb_);
                Period lzzzzd_ = lzzzzc_?.Period;
                CqlInterval<CqlDateTime> lzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzd_);
                CqlDateTime lzzzzf_ = context.Operators.Start(lzzzze_);
                CqlInterval<CqlDateTime> lzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzi_);
                CqlDateTime lzzzzi_ = context.Operators.Start(lzzzzh_);
                bool? lzzzzj_ = context.Operators.Not((bool?)((kzzzzv_ ?? lzzzzf_ ?? lzzzzi_) is null));
                bool? lzzzzk_ = context.Operators.And(kzzzzl_, lzzzzj_);

                return lzzzzk_;
            };
            IEnumerable<Encounter> hzzzzd_ = context.Operators.Where<Encounter>(hzzzzb_, hzzzzc_);
            object hzzzze_(Encounter @this)
            {
                Period dzzzzzx_ = @this?.Period;
                CqlInterval<CqlDateTime> dzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzx_);
                CqlDateTime dzzzzzz_ = context.Operators.End(dzzzzzy_);

                return dzzzzzz_;
            };
            IEnumerable<Encounter> hzzzzf_ = context.Operators.SortBy<Encounter>(hzzzzd_, hzzzze_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter hzzzzg_ = context.Operators.Last<Encounter>(hzzzzf_);
            Period hzzzzh_ = hzzzzg_?.Period;
            CqlInterval<CqlDateTime> hzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzh_);
            CqlDateTime hzzzzj_ = context.Operators.Start(hzzzzi_);
            CqlValueSet hzzzzk_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> hzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? hzzzzm_(Encounter LastED)
            {
                Code<Encounter.EncounterStatus> ezzzzza_ = LastED?.StatusElement;
                Encounter.EncounterStatus? ezzzzzb_ = ezzzzza_?.Value;
                Code<Encounter.EncounterStatus> ezzzzzc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ezzzzzb_);
                bool? ezzzzzd_ = context.Operators.Equal(ezzzzzc_, "finished");
                Period ezzzzze_ = LastED?.Period;
                CqlInterval<CqlDateTime> ezzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzze_);
                CqlDateTime ezzzzzg_ = context.Operators.End(ezzzzzf_);
                CqlValueSet ezzzzzh_ = this.Observation_Services(context);
                IEnumerable<Encounter> ezzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? ezzzzzj_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> gzzzzzb_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? gzzzzzc_ = gzzzzzb_?.Value;
                    Code<Encounter.EncounterStatus> gzzzzzd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gzzzzzc_);
                    bool? gzzzzze_ = context.Operators.Equal(gzzzzzd_, "finished");
                    Period gzzzzzf_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> gzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzf_);
                    CqlDateTime gzzzzzh_ = context.Operators.End(gzzzzzg_);
                    Period gzzzzzi_ = Visit?.Period;
                    CqlInterval<CqlDateTime> gzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzi_);
                    CqlDateTime gzzzzzk_ = context.Operators.Start(gzzzzzj_);
                    CqlQuantity gzzzzzl_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime gzzzzzm_ = context.Operators.Subtract(gzzzzzk_, gzzzzzl_);
                    CqlInterval<CqlDateTime> gzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzi_);
                    CqlDateTime gzzzzzp_ = context.Operators.Start(gzzzzzo_);
                    CqlInterval<CqlDateTime> gzzzzzq_ = context.Operators.Interval(gzzzzzm_, gzzzzzp_, true, true);
                    bool? gzzzzzr_ = context.Operators.In<CqlDateTime>(gzzzzzh_, gzzzzzq_, default);
                    CqlInterval<CqlDateTime> gzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzi_);
                    CqlDateTime gzzzzzu_ = context.Operators.Start(gzzzzzt_);
                    bool? gzzzzzv_ = context.Operators.Not((bool?)(gzzzzzu_ is null));
                    bool? gzzzzzw_ = context.Operators.And(gzzzzzr_, gzzzzzv_);
                    bool? gzzzzzx_ = context.Operators.And(gzzzzze_, gzzzzzw_);

                    return gzzzzzx_;
                };
                IEnumerable<Encounter> ezzzzzk_ = context.Operators.Where<Encounter>(ezzzzzi_, ezzzzzj_);
                object ezzzzzl_(Encounter @this)
                {
                    Period gzzzzzy_ = @this?.Period;
                    CqlInterval<CqlDateTime> gzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzy_);
                    CqlDateTime hzzzzza_ = context.Operators.End(gzzzzzz_);

                    return hzzzzza_;
                };
                IEnumerable<Encounter> ezzzzzm_ = context.Operators.SortBy<Encounter>(ezzzzzk_, ezzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter ezzzzzn_ = context.Operators.Last<Encounter>(ezzzzzm_);
                Period ezzzzzo_ = ezzzzzn_?.Period;
                CqlInterval<CqlDateTime> ezzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzo_);
                CqlDateTime ezzzzzq_ = context.Operators.Start(ezzzzzp_);
                Period ezzzzzr_ = Visit?.Period;
                CqlInterval<CqlDateTime> ezzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzr_);
                CqlDateTime ezzzzzt_ = context.Operators.Start(ezzzzzs_);
                CqlQuantity ezzzzzu_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime ezzzzzv_ = context.Operators.Subtract(ezzzzzq_ ?? ezzzzzt_, ezzzzzu_);
                IEnumerable<Encounter> ezzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? ezzzzzy_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> hzzzzzb_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? hzzzzzc_ = hzzzzzb_?.Value;
                    Code<Encounter.EncounterStatus> hzzzzzd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hzzzzzc_);
                    bool? hzzzzze_ = context.Operators.Equal(hzzzzzd_, "finished");
                    Period hzzzzzf_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> hzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzf_);
                    CqlDateTime hzzzzzh_ = context.Operators.End(hzzzzzg_);
                    Period hzzzzzi_ = Visit?.Period;
                    CqlInterval<CqlDateTime> hzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzi_);
                    CqlDateTime hzzzzzk_ = context.Operators.Start(hzzzzzj_);
                    CqlQuantity hzzzzzl_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime hzzzzzm_ = context.Operators.Subtract(hzzzzzk_, hzzzzzl_);
                    CqlInterval<CqlDateTime> hzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzi_);
                    CqlDateTime hzzzzzp_ = context.Operators.Start(hzzzzzo_);
                    CqlInterval<CqlDateTime> hzzzzzq_ = context.Operators.Interval(hzzzzzm_, hzzzzzp_, true, true);
                    bool? hzzzzzr_ = context.Operators.In<CqlDateTime>(hzzzzzh_, hzzzzzq_, default);
                    CqlInterval<CqlDateTime> hzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzi_);
                    CqlDateTime hzzzzzu_ = context.Operators.Start(hzzzzzt_);
                    bool? hzzzzzv_ = context.Operators.Not((bool?)(hzzzzzu_ is null));
                    bool? hzzzzzw_ = context.Operators.And(hzzzzzr_, hzzzzzv_);
                    bool? hzzzzzx_ = context.Operators.And(hzzzzze_, hzzzzzw_);

                    return hzzzzzx_;
                };
                IEnumerable<Encounter> ezzzzzz_ = context.Operators.Where<Encounter>(ezzzzzx_, ezzzzzy_);
                object fzzzzza_(Encounter @this)
                {
                    Period hzzzzzy_ = @this?.Period;
                    CqlInterval<CqlDateTime> hzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzy_);
                    CqlDateTime izzzzza_ = context.Operators.End(hzzzzzz_);

                    return izzzzza_;
                };
                IEnumerable<Encounter> fzzzzzb_ = context.Operators.SortBy<Encounter>(ezzzzzz_, fzzzzza_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter fzzzzzc_ = context.Operators.Last<Encounter>(fzzzzzb_);
                Period fzzzzzd_ = fzzzzzc_?.Period;
                CqlInterval<CqlDateTime> fzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzd_);
                CqlDateTime fzzzzzf_ = context.Operators.Start(fzzzzze_);
                CqlInterval<CqlDateTime> fzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzr_);
                CqlDateTime fzzzzzi_ = context.Operators.Start(fzzzzzh_);
                CqlInterval<CqlDateTime> fzzzzzj_ = context.Operators.Interval(ezzzzzv_, fzzzzzf_ ?? fzzzzzi_, true, true);
                bool? fzzzzzk_ = context.Operators.In<CqlDateTime>(ezzzzzg_, fzzzzzj_, default);
                IEnumerable<Encounter> fzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? fzzzzzn_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> izzzzzb_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? izzzzzc_ = izzzzzb_?.Value;
                    Code<Encounter.EncounterStatus> izzzzzd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(izzzzzc_);
                    bool? izzzzze_ = context.Operators.Equal(izzzzzd_, "finished");
                    Period izzzzzf_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> izzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzf_);
                    CqlDateTime izzzzzh_ = context.Operators.End(izzzzzg_);
                    Period izzzzzi_ = Visit?.Period;
                    CqlInterval<CqlDateTime> izzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzi_);
                    CqlDateTime izzzzzk_ = context.Operators.Start(izzzzzj_);
                    CqlQuantity izzzzzl_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime izzzzzm_ = context.Operators.Subtract(izzzzzk_, izzzzzl_);
                    CqlInterval<CqlDateTime> izzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzi_);
                    CqlDateTime izzzzzp_ = context.Operators.Start(izzzzzo_);
                    CqlInterval<CqlDateTime> izzzzzq_ = context.Operators.Interval(izzzzzm_, izzzzzp_, true, true);
                    bool? izzzzzr_ = context.Operators.In<CqlDateTime>(izzzzzh_, izzzzzq_, default);
                    CqlInterval<CqlDateTime> izzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzi_);
                    CqlDateTime izzzzzu_ = context.Operators.Start(izzzzzt_);
                    bool? izzzzzv_ = context.Operators.Not((bool?)(izzzzzu_ is null));
                    bool? izzzzzw_ = context.Operators.And(izzzzzr_, izzzzzv_);
                    bool? izzzzzx_ = context.Operators.And(izzzzze_, izzzzzw_);

                    return izzzzzx_;
                };
                IEnumerable<Encounter> fzzzzzo_ = context.Operators.Where<Encounter>(fzzzzzm_, fzzzzzn_);
                object fzzzzzp_(Encounter @this)
                {
                    Period izzzzzy_ = @this?.Period;
                    CqlInterval<CqlDateTime> izzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzy_);
                    CqlDateTime jzzzzza_ = context.Operators.End(izzzzzz_);

                    return jzzzzza_;
                };
                IEnumerable<Encounter> fzzzzzq_ = context.Operators.SortBy<Encounter>(fzzzzzo_, fzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter fzzzzzr_ = context.Operators.Last<Encounter>(fzzzzzq_);
                Period fzzzzzs_ = fzzzzzr_?.Period;
                CqlInterval<CqlDateTime> fzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzs_);
                CqlDateTime fzzzzzu_ = context.Operators.Start(fzzzzzt_);
                CqlInterval<CqlDateTime> fzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzr_);
                CqlDateTime fzzzzzx_ = context.Operators.Start(fzzzzzw_);
                bool? fzzzzzy_ = context.Operators.Not((bool?)((fzzzzzu_ ?? fzzzzzx_) is null));
                bool? fzzzzzz_ = context.Operators.And(fzzzzzk_, fzzzzzy_);
                bool? gzzzzza_ = context.Operators.And(ezzzzzd_, fzzzzzz_);

                return gzzzzza_;
            };
            IEnumerable<Encounter> hzzzzn_ = context.Operators.Where<Encounter>(hzzzzl_, hzzzzm_);
            object hzzzzo_(Encounter @this)
            {
                Period jzzzzzb_ = @this?.Period;
                CqlInterval<CqlDateTime> jzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzb_);
                CqlDateTime jzzzzzd_ = context.Operators.End(jzzzzzc_);

                return jzzzzzd_;
            };
            IEnumerable<Encounter> hzzzzp_ = context.Operators.SortBy<Encounter>(hzzzzn_, hzzzzo_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter hzzzzq_ = context.Operators.Last<Encounter>(hzzzzp_);
            Period hzzzzr_ = hzzzzq_?.Period;
            CqlInterval<CqlDateTime> hzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzr_);
            CqlDateTime hzzzzt_ = context.Operators.Start(hzzzzs_);
            CqlValueSet hzzzzu_ = this.Observation_Services(context);
            IEnumerable<Encounter> hzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? hzzzzw_(Encounter LastObs)
            {
                Code<Encounter.EncounterStatus> jzzzzze_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? jzzzzzf_ = jzzzzze_?.Value;
                Code<Encounter.EncounterStatus> jzzzzzg_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jzzzzzf_);
                bool? jzzzzzh_ = context.Operators.Equal(jzzzzzg_, "finished");
                Period jzzzzzi_ = LastObs?.Period;
                CqlInterval<CqlDateTime> jzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzi_);
                CqlDateTime jzzzzzk_ = context.Operators.End(jzzzzzj_);
                Period jzzzzzl_ = Visit?.Period;
                CqlInterval<CqlDateTime> jzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzl_);
                CqlDateTime jzzzzzn_ = context.Operators.Start(jzzzzzm_);
                CqlQuantity jzzzzzo_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime jzzzzzp_ = context.Operators.Subtract(jzzzzzn_, jzzzzzo_);
                CqlInterval<CqlDateTime> jzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzl_);
                CqlDateTime jzzzzzs_ = context.Operators.Start(jzzzzzr_);
                CqlInterval<CqlDateTime> jzzzzzt_ = context.Operators.Interval(jzzzzzp_, jzzzzzs_, true, true);
                bool? jzzzzzu_ = context.Operators.In<CqlDateTime>(jzzzzzk_, jzzzzzt_, default);
                CqlInterval<CqlDateTime> jzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzl_);
                CqlDateTime jzzzzzx_ = context.Operators.Start(jzzzzzw_);
                bool? jzzzzzy_ = context.Operators.Not((bool?)(jzzzzzx_ is null));
                bool? jzzzzzz_ = context.Operators.And(jzzzzzu_, jzzzzzy_);
                bool? kzzzzza_ = context.Operators.And(jzzzzzh_, jzzzzzz_);

                return kzzzzza_;
            };
            IEnumerable<Encounter> hzzzzx_ = context.Operators.Where<Encounter>(hzzzzv_, hzzzzw_);
            object hzzzzy_(Encounter @this)
            {
                Period kzzzzzb_ = @this?.Period;
                CqlInterval<CqlDateTime> kzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzb_);
                CqlDateTime kzzzzzd_ = context.Operators.End(kzzzzzc_);

                return kzzzzzd_;
            };
            IEnumerable<Encounter> hzzzzz_ = context.Operators.SortBy<Encounter>(hzzzzx_, hzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter izzzza_ = context.Operators.Last<Encounter>(hzzzzz_);
            Period izzzzb_ = izzzza_?.Period;
            CqlInterval<CqlDateTime> izzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzb_);
            CqlDateTime izzzzd_ = context.Operators.Start(izzzzc_);
            Period izzzze_ = Visit?.Period;
            CqlInterval<CqlDateTime> izzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzze_);
            CqlDateTime izzzzg_ = context.Operators.Start(izzzzf_);
            CqlInterval<CqlDateTime> izzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzze_);
            CqlDateTime izzzzj_ = context.Operators.End(izzzzi_);
            CqlInterval<CqlDateTime> izzzzk_ = context.Operators.Interval(hzzzzj_ ?? hzzzzt_ ?? izzzzd_ ?? izzzzg_, izzzzj_, true, true);

            return izzzzk_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> gzzzzx_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)gzzzzv_, gzzzzw_);
        IEnumerable<CqlInterval<CqlDateTime>> gzzzzy_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(gzzzzx_);
        CqlInterval<CqlDateTime> gzzzzz_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(gzzzzy_);

        return gzzzzz_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservation")]
    [CqlTag("description", "Hospitalization with Observation returns the total interval from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationWithObservation()` instead.")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] kzzzzze_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> kzzzzzf_(Encounter Visit)
        {
            CqlValueSet kzzzzzj_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> kzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? kzzzzzl_(Encounter LastED)
            {
                Code<Encounter.EncounterStatus> lzzzzzk_ = LastED?.StatusElement;
                Encounter.EncounterStatus? lzzzzzl_ = lzzzzzk_?.Value;
                Code<Encounter.EncounterStatus> lzzzzzm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lzzzzzl_);
                bool? lzzzzzn_ = context.Operators.Equal(lzzzzzm_, "finished");
                Period lzzzzzo_ = LastED?.Period;
                CqlInterval<CqlDateTime> lzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzo_);
                CqlDateTime lzzzzzq_ = context.Operators.End(lzzzzzp_);
                CqlValueSet lzzzzzr_ = this.Observation_Services(context);
                IEnumerable<Encounter> lzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? lzzzzzt_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> nzzzzzl_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? nzzzzzm_ = nzzzzzl_?.Value;
                    Code<Encounter.EncounterStatus> nzzzzzn_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(nzzzzzm_);
                    bool? nzzzzzo_ = context.Operators.Equal(nzzzzzn_, "finished");
                    Period nzzzzzp_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> nzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzp_);
                    CqlDateTime nzzzzzr_ = context.Operators.End(nzzzzzq_);
                    Period nzzzzzs_ = Visit?.Period;
                    CqlInterval<CqlDateTime> nzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzs_);
                    CqlDateTime nzzzzzu_ = context.Operators.Start(nzzzzzt_);
                    CqlQuantity nzzzzzv_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime nzzzzzw_ = context.Operators.Subtract(nzzzzzu_, nzzzzzv_);
                    CqlInterval<CqlDateTime> nzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzs_);
                    CqlDateTime nzzzzzz_ = context.Operators.Start(nzzzzzy_);
                    CqlInterval<CqlDateTime> ozzzzza_ = context.Operators.Interval(nzzzzzw_, nzzzzzz_, true, true);
                    bool? ozzzzzb_ = context.Operators.In<CqlDateTime>(nzzzzzr_, ozzzzza_, default);
                    CqlInterval<CqlDateTime> ozzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzs_);
                    CqlDateTime ozzzzze_ = context.Operators.Start(ozzzzzd_);
                    bool? ozzzzzf_ = context.Operators.Not((bool?)(ozzzzze_ is null));
                    bool? ozzzzzg_ = context.Operators.And(ozzzzzb_, ozzzzzf_);
                    bool? ozzzzzh_ = context.Operators.And(nzzzzzo_, ozzzzzg_);

                    return ozzzzzh_;
                };
                IEnumerable<Encounter> lzzzzzu_ = context.Operators.Where<Encounter>(lzzzzzs_, lzzzzzt_);
                object lzzzzzv_(Encounter @this)
                {
                    Period ozzzzzi_ = @this?.Period;
                    CqlInterval<CqlDateTime> ozzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzi_);
                    CqlDateTime ozzzzzk_ = context.Operators.End(ozzzzzj_);

                    return ozzzzzk_;
                };
                IEnumerable<Encounter> lzzzzzw_ = context.Operators.SortBy<Encounter>(lzzzzzu_, lzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter lzzzzzx_ = context.Operators.Last<Encounter>(lzzzzzw_);
                Period lzzzzzy_ = lzzzzzx_?.Period;
                CqlInterval<CqlDateTime> lzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzy_);
                CqlDateTime mzzzzza_ = context.Operators.Start(lzzzzzz_);
                Period mzzzzzb_ = Visit?.Period;
                CqlInterval<CqlDateTime> mzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzb_);
                CqlDateTime mzzzzzd_ = context.Operators.Start(mzzzzzc_);
                CqlQuantity mzzzzze_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime mzzzzzf_ = context.Operators.Subtract(mzzzzza_ ?? mzzzzzd_, mzzzzze_);
                IEnumerable<Encounter> mzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? mzzzzzi_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> ozzzzzl_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? ozzzzzm_ = ozzzzzl_?.Value;
                    Code<Encounter.EncounterStatus> ozzzzzn_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ozzzzzm_);
                    bool? ozzzzzo_ = context.Operators.Equal(ozzzzzn_, "finished");
                    Period ozzzzzp_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> ozzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzp_);
                    CqlDateTime ozzzzzr_ = context.Operators.End(ozzzzzq_);
                    Period ozzzzzs_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ozzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzs_);
                    CqlDateTime ozzzzzu_ = context.Operators.Start(ozzzzzt_);
                    CqlQuantity ozzzzzv_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ozzzzzw_ = context.Operators.Subtract(ozzzzzu_, ozzzzzv_);
                    CqlInterval<CqlDateTime> ozzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzs_);
                    CqlDateTime ozzzzzz_ = context.Operators.Start(ozzzzzy_);
                    CqlInterval<CqlDateTime> pzzzzza_ = context.Operators.Interval(ozzzzzw_, ozzzzzz_, true, true);
                    bool? pzzzzzb_ = context.Operators.In<CqlDateTime>(ozzzzzr_, pzzzzza_, default);
                    CqlInterval<CqlDateTime> pzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzs_);
                    CqlDateTime pzzzzze_ = context.Operators.Start(pzzzzzd_);
                    bool? pzzzzzf_ = context.Operators.Not((bool?)(pzzzzze_ is null));
                    bool? pzzzzzg_ = context.Operators.And(pzzzzzb_, pzzzzzf_);
                    bool? pzzzzzh_ = context.Operators.And(ozzzzzo_, pzzzzzg_);

                    return pzzzzzh_;
                };
                IEnumerable<Encounter> mzzzzzj_ = context.Operators.Where<Encounter>(mzzzzzh_, mzzzzzi_);
                object mzzzzzk_(Encounter @this)
                {
                    Period pzzzzzi_ = @this?.Period;
                    CqlInterval<CqlDateTime> pzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzi_);
                    CqlDateTime pzzzzzk_ = context.Operators.End(pzzzzzj_);

                    return pzzzzzk_;
                };
                IEnumerable<Encounter> mzzzzzl_ = context.Operators.SortBy<Encounter>(mzzzzzj_, mzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter mzzzzzm_ = context.Operators.Last<Encounter>(mzzzzzl_);
                Period mzzzzzn_ = mzzzzzm_?.Period;
                CqlInterval<CqlDateTime> mzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzn_);
                CqlDateTime mzzzzzp_ = context.Operators.Start(mzzzzzo_);
                CqlInterval<CqlDateTime> mzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzb_);
                CqlDateTime mzzzzzs_ = context.Operators.Start(mzzzzzr_);
                CqlInterval<CqlDateTime> mzzzzzt_ = context.Operators.Interval(mzzzzzf_, mzzzzzp_ ?? mzzzzzs_, true, true);
                bool? mzzzzzu_ = context.Operators.In<CqlDateTime>(lzzzzzq_, mzzzzzt_, default);
                IEnumerable<Encounter> mzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? mzzzzzx_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> pzzzzzl_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? pzzzzzm_ = pzzzzzl_?.Value;
                    Code<Encounter.EncounterStatus> pzzzzzn_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pzzzzzm_);
                    bool? pzzzzzo_ = context.Operators.Equal(pzzzzzn_, "finished");
                    Period pzzzzzp_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> pzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzp_);
                    CqlDateTime pzzzzzr_ = context.Operators.End(pzzzzzq_);
                    Period pzzzzzs_ = Visit?.Period;
                    CqlInterval<CqlDateTime> pzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzs_);
                    CqlDateTime pzzzzzu_ = context.Operators.Start(pzzzzzt_);
                    CqlQuantity pzzzzzv_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime pzzzzzw_ = context.Operators.Subtract(pzzzzzu_, pzzzzzv_);
                    CqlInterval<CqlDateTime> pzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzs_);
                    CqlDateTime pzzzzzz_ = context.Operators.Start(pzzzzzy_);
                    CqlInterval<CqlDateTime> qzzzzza_ = context.Operators.Interval(pzzzzzw_, pzzzzzz_, true, true);
                    bool? qzzzzzb_ = context.Operators.In<CqlDateTime>(pzzzzzr_, qzzzzza_, default);
                    CqlInterval<CqlDateTime> qzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzs_);
                    CqlDateTime qzzzzze_ = context.Operators.Start(qzzzzzd_);
                    bool? qzzzzzf_ = context.Operators.Not((bool?)(qzzzzze_ is null));
                    bool? qzzzzzg_ = context.Operators.And(qzzzzzb_, qzzzzzf_);
                    bool? qzzzzzh_ = context.Operators.And(pzzzzzo_, qzzzzzg_);

                    return qzzzzzh_;
                };
                IEnumerable<Encounter> mzzzzzy_ = context.Operators.Where<Encounter>(mzzzzzw_, mzzzzzx_);
                object mzzzzzz_(Encounter @this)
                {
                    Period qzzzzzi_ = @this?.Period;
                    CqlInterval<CqlDateTime> qzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzi_);
                    CqlDateTime qzzzzzk_ = context.Operators.End(qzzzzzj_);

                    return qzzzzzk_;
                };
                IEnumerable<Encounter> nzzzzza_ = context.Operators.SortBy<Encounter>(mzzzzzy_, mzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter nzzzzzb_ = context.Operators.Last<Encounter>(nzzzzza_);
                Period nzzzzzc_ = nzzzzzb_?.Period;
                CqlInterval<CqlDateTime> nzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzc_);
                CqlDateTime nzzzzze_ = context.Operators.Start(nzzzzzd_);
                CqlInterval<CqlDateTime> nzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzb_);
                CqlDateTime nzzzzzh_ = context.Operators.Start(nzzzzzg_);
                bool? nzzzzzi_ = context.Operators.Not((bool?)((nzzzzze_ ?? nzzzzzh_) is null));
                bool? nzzzzzj_ = context.Operators.And(mzzzzzu_, nzzzzzi_);
                bool? nzzzzzk_ = context.Operators.And(lzzzzzn_, nzzzzzj_);

                return nzzzzzk_;
            };
            IEnumerable<Encounter> kzzzzzm_ = context.Operators.Where<Encounter>(kzzzzzk_, kzzzzzl_);
            object kzzzzzn_(Encounter @this)
            {
                Period qzzzzzl_ = @this?.Period;
                CqlInterval<CqlDateTime> qzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzl_);
                CqlDateTime qzzzzzn_ = context.Operators.End(qzzzzzm_);

                return qzzzzzn_;
            };
            IEnumerable<Encounter> kzzzzzo_ = context.Operators.SortBy<Encounter>(kzzzzzm_, kzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter kzzzzzp_ = context.Operators.Last<Encounter>(kzzzzzo_);
            Period kzzzzzq_ = kzzzzzp_?.Period;
            CqlInterval<CqlDateTime> kzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzq_);
            CqlDateTime kzzzzzs_ = context.Operators.Start(kzzzzzr_);
            CqlValueSet kzzzzzt_ = this.Observation_Services(context);
            IEnumerable<Encounter> kzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? kzzzzzv_(Encounter LastObs)
            {
                Code<Encounter.EncounterStatus> qzzzzzo_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? qzzzzzp_ = qzzzzzo_?.Value;
                Code<Encounter.EncounterStatus> qzzzzzq_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(qzzzzzp_);
                bool? qzzzzzr_ = context.Operators.Equal(qzzzzzq_, "finished");
                Period qzzzzzs_ = LastObs?.Period;
                CqlInterval<CqlDateTime> qzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzs_);
                CqlDateTime qzzzzzu_ = context.Operators.End(qzzzzzt_);
                Period qzzzzzv_ = Visit?.Period;
                CqlInterval<CqlDateTime> qzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzv_);
                CqlDateTime qzzzzzx_ = context.Operators.Start(qzzzzzw_);
                CqlQuantity qzzzzzy_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime qzzzzzz_ = context.Operators.Subtract(qzzzzzx_, qzzzzzy_);
                CqlInterval<CqlDateTime> rzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzv_);
                CqlDateTime rzzzzzc_ = context.Operators.Start(rzzzzzb_);
                CqlInterval<CqlDateTime> rzzzzzd_ = context.Operators.Interval(qzzzzzz_, rzzzzzc_, true, true);
                bool? rzzzzze_ = context.Operators.In<CqlDateTime>(qzzzzzu_, rzzzzzd_, default);
                CqlInterval<CqlDateTime> rzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzv_);
                CqlDateTime rzzzzzh_ = context.Operators.Start(rzzzzzg_);
                bool? rzzzzzi_ = context.Operators.Not((bool?)(rzzzzzh_ is null));
                bool? rzzzzzj_ = context.Operators.And(rzzzzze_, rzzzzzi_);
                bool? rzzzzzk_ = context.Operators.And(qzzzzzr_, rzzzzzj_);

                return rzzzzzk_;
            };
            IEnumerable<Encounter> kzzzzzw_ = context.Operators.Where<Encounter>(kzzzzzu_, kzzzzzv_);
            object kzzzzzx_(Encounter @this)
            {
                Period rzzzzzl_ = @this?.Period;
                CqlInterval<CqlDateTime> rzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzl_);
                CqlDateTime rzzzzzn_ = context.Operators.End(rzzzzzm_);

                return rzzzzzn_;
            };
            IEnumerable<Encounter> kzzzzzy_ = context.Operators.SortBy<Encounter>(kzzzzzw_, kzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter kzzzzzz_ = context.Operators.Last<Encounter>(kzzzzzy_);
            Period lzzzzza_ = kzzzzzz_?.Period;
            CqlInterval<CqlDateTime> lzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzza_);
            CqlDateTime lzzzzzc_ = context.Operators.Start(lzzzzzb_);
            Period lzzzzzd_ = Visit?.Period;
            CqlInterval<CqlDateTime> lzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzd_);
            CqlDateTime lzzzzzf_ = context.Operators.Start(lzzzzze_);
            CqlInterval<CqlDateTime> lzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzd_);
            CqlDateTime lzzzzzi_ = context.Operators.End(lzzzzzh_);
            CqlInterval<CqlDateTime> lzzzzzj_ = context.Operators.Interval(kzzzzzs_ ?? lzzzzzc_ ?? lzzzzzf_, lzzzzzi_, true, true);

            return lzzzzzj_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> kzzzzzg_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)kzzzzze_, kzzzzzf_);
        IEnumerable<CqlInterval<CqlDateTime>> kzzzzzh_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(kzzzzzg_);
        CqlInterval<CqlDateTime> kzzzzzi_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(kzzzzzh_);

        return kzzzzzi_;
    }


    [CqlExpressionDefinition("hospitalizationWithObservation")]
    [CqlTag("description", "Hospitalization with Observation returns the total interval from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    public CqlInterval<CqlDateTime> hospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] rzzzzzo_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> rzzzzzp_(Encounter Visit)
        {
            CqlValueSet rzzzzzt_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> rzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? rzzzzzv_(Encounter LastED)
            {
                Code<Encounter.EncounterStatus> szzzzzu_ = LastED?.StatusElement;
                Encounter.EncounterStatus? szzzzzv_ = szzzzzu_?.Value;
                Code<Encounter.EncounterStatus> szzzzzw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(szzzzzv_);
                bool? szzzzzx_ = context.Operators.Equal(szzzzzw_, "finished");
                Period szzzzzy_ = LastED?.Period;
                CqlInterval<CqlDateTime> szzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzy_);
                CqlDateTime tzzzzza_ = context.Operators.End(szzzzzz_);
                CqlValueSet tzzzzzb_ = this.Observation_Services(context);
                IEnumerable<Encounter> tzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? tzzzzzd_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> uzzzzzv_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? uzzzzzw_ = uzzzzzv_?.Value;
                    Code<Encounter.EncounterStatus> uzzzzzx_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(uzzzzzw_);
                    bool? uzzzzzy_ = context.Operators.Equal(uzzzzzx_, "finished");
                    Period uzzzzzz_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> vzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzz_);
                    CqlDateTime vzzzzzb_ = context.Operators.End(vzzzzza_);
                    Period vzzzzzc_ = Visit?.Period;
                    CqlInterval<CqlDateTime> vzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzc_);
                    CqlDateTime vzzzzze_ = context.Operators.Start(vzzzzzd_);
                    CqlQuantity vzzzzzf_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime vzzzzzg_ = context.Operators.Subtract(vzzzzze_, vzzzzzf_);
                    CqlInterval<CqlDateTime> vzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzc_);
                    CqlDateTime vzzzzzj_ = context.Operators.Start(vzzzzzi_);
                    CqlInterval<CqlDateTime> vzzzzzk_ = context.Operators.Interval(vzzzzzg_, vzzzzzj_, true, true);
                    bool? vzzzzzl_ = context.Operators.In<CqlDateTime>(vzzzzzb_, vzzzzzk_, default);
                    CqlInterval<CqlDateTime> vzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzc_);
                    CqlDateTime vzzzzzo_ = context.Operators.Start(vzzzzzn_);
                    bool? vzzzzzp_ = context.Operators.Not((bool?)(vzzzzzo_ is null));
                    bool? vzzzzzq_ = context.Operators.And(vzzzzzl_, vzzzzzp_);
                    bool? vzzzzzr_ = context.Operators.And(uzzzzzy_, vzzzzzq_);

                    return vzzzzzr_;
                };
                IEnumerable<Encounter> tzzzzze_ = context.Operators.Where<Encounter>(tzzzzzc_, tzzzzzd_);
                object tzzzzzf_(Encounter @this)
                {
                    Period vzzzzzs_ = @this?.Period;
                    CqlInterval<CqlDateTime> vzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzs_);
                    CqlDateTime vzzzzzu_ = context.Operators.End(vzzzzzt_);

                    return vzzzzzu_;
                };
                IEnumerable<Encounter> tzzzzzg_ = context.Operators.SortBy<Encounter>(tzzzzze_, tzzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter tzzzzzh_ = context.Operators.Last<Encounter>(tzzzzzg_);
                Period tzzzzzi_ = tzzzzzh_?.Period;
                CqlInterval<CqlDateTime> tzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzi_);
                CqlDateTime tzzzzzk_ = context.Operators.Start(tzzzzzj_);
                Period tzzzzzl_ = Visit?.Period;
                CqlInterval<CqlDateTime> tzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzl_);
                CqlDateTime tzzzzzn_ = context.Operators.Start(tzzzzzm_);
                CqlQuantity tzzzzzo_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime tzzzzzp_ = context.Operators.Subtract(tzzzzzk_ ?? tzzzzzn_, tzzzzzo_);
                IEnumerable<Encounter> tzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? tzzzzzs_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> vzzzzzv_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? vzzzzzw_ = vzzzzzv_?.Value;
                    Code<Encounter.EncounterStatus> vzzzzzx_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(vzzzzzw_);
                    bool? vzzzzzy_ = context.Operators.Equal(vzzzzzx_, "finished");
                    Period vzzzzzz_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> wzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzz_);
                    CqlDateTime wzzzzzb_ = context.Operators.End(wzzzzza_);
                    Period wzzzzzc_ = Visit?.Period;
                    CqlInterval<CqlDateTime> wzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzc_);
                    CqlDateTime wzzzzze_ = context.Operators.Start(wzzzzzd_);
                    CqlQuantity wzzzzzf_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime wzzzzzg_ = context.Operators.Subtract(wzzzzze_, wzzzzzf_);
                    CqlInterval<CqlDateTime> wzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzc_);
                    CqlDateTime wzzzzzj_ = context.Operators.Start(wzzzzzi_);
                    CqlInterval<CqlDateTime> wzzzzzk_ = context.Operators.Interval(wzzzzzg_, wzzzzzj_, true, true);
                    bool? wzzzzzl_ = context.Operators.In<CqlDateTime>(wzzzzzb_, wzzzzzk_, default);
                    CqlInterval<CqlDateTime> wzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzc_);
                    CqlDateTime wzzzzzo_ = context.Operators.Start(wzzzzzn_);
                    bool? wzzzzzp_ = context.Operators.Not((bool?)(wzzzzzo_ is null));
                    bool? wzzzzzq_ = context.Operators.And(wzzzzzl_, wzzzzzp_);
                    bool? wzzzzzr_ = context.Operators.And(vzzzzzy_, wzzzzzq_);

                    return wzzzzzr_;
                };
                IEnumerable<Encounter> tzzzzzt_ = context.Operators.Where<Encounter>(tzzzzzr_, tzzzzzs_);
                object tzzzzzu_(Encounter @this)
                {
                    Period wzzzzzs_ = @this?.Period;
                    CqlInterval<CqlDateTime> wzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzs_);
                    CqlDateTime wzzzzzu_ = context.Operators.End(wzzzzzt_);

                    return wzzzzzu_;
                };
                IEnumerable<Encounter> tzzzzzv_ = context.Operators.SortBy<Encounter>(tzzzzzt_, tzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter tzzzzzw_ = context.Operators.Last<Encounter>(tzzzzzv_);
                Period tzzzzzx_ = tzzzzzw_?.Period;
                CqlInterval<CqlDateTime> tzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzx_);
                CqlDateTime tzzzzzz_ = context.Operators.Start(tzzzzzy_);
                CqlInterval<CqlDateTime> uzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzl_);
                CqlDateTime uzzzzzc_ = context.Operators.Start(uzzzzzb_);
                CqlInterval<CqlDateTime> uzzzzzd_ = context.Operators.Interval(tzzzzzp_, tzzzzzz_ ?? uzzzzzc_, true, true);
                bool? uzzzzze_ = context.Operators.In<CqlDateTime>(tzzzzza_, uzzzzzd_, default);
                IEnumerable<Encounter> uzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? uzzzzzh_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> wzzzzzv_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? wzzzzzw_ = wzzzzzv_?.Value;
                    Code<Encounter.EncounterStatus> wzzzzzx_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(wzzzzzw_);
                    bool? wzzzzzy_ = context.Operators.Equal(wzzzzzx_, "finished");
                    Period wzzzzzz_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> xzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzz_);
                    CqlDateTime xzzzzzb_ = context.Operators.End(xzzzzza_);
                    Period xzzzzzc_ = Visit?.Period;
                    CqlInterval<CqlDateTime> xzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzc_);
                    CqlDateTime xzzzzze_ = context.Operators.Start(xzzzzzd_);
                    CqlQuantity xzzzzzf_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime xzzzzzg_ = context.Operators.Subtract(xzzzzze_, xzzzzzf_);
                    CqlInterval<CqlDateTime> xzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzc_);
                    CqlDateTime xzzzzzj_ = context.Operators.Start(xzzzzzi_);
                    CqlInterval<CqlDateTime> xzzzzzk_ = context.Operators.Interval(xzzzzzg_, xzzzzzj_, true, true);
                    bool? xzzzzzl_ = context.Operators.In<CqlDateTime>(xzzzzzb_, xzzzzzk_, default);
                    CqlInterval<CqlDateTime> xzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzc_);
                    CqlDateTime xzzzzzo_ = context.Operators.Start(xzzzzzn_);
                    bool? xzzzzzp_ = context.Operators.Not((bool?)(xzzzzzo_ is null));
                    bool? xzzzzzq_ = context.Operators.And(xzzzzzl_, xzzzzzp_);
                    bool? xzzzzzr_ = context.Operators.And(wzzzzzy_, xzzzzzq_);

                    return xzzzzzr_;
                };
                IEnumerable<Encounter> uzzzzzi_ = context.Operators.Where<Encounter>(uzzzzzg_, uzzzzzh_);
                object uzzzzzj_(Encounter @this)
                {
                    Period xzzzzzs_ = @this?.Period;
                    CqlInterval<CqlDateTime> xzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzs_);
                    CqlDateTime xzzzzzu_ = context.Operators.End(xzzzzzt_);

                    return xzzzzzu_;
                };
                IEnumerable<Encounter> uzzzzzk_ = context.Operators.SortBy<Encounter>(uzzzzzi_, uzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter uzzzzzl_ = context.Operators.Last<Encounter>(uzzzzzk_);
                Period uzzzzzm_ = uzzzzzl_?.Period;
                CqlInterval<CqlDateTime> uzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzm_);
                CqlDateTime uzzzzzo_ = context.Operators.Start(uzzzzzn_);
                CqlInterval<CqlDateTime> uzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzl_);
                CqlDateTime uzzzzzr_ = context.Operators.Start(uzzzzzq_);
                bool? uzzzzzs_ = context.Operators.Not((bool?)((uzzzzzo_ ?? uzzzzzr_) is null));
                bool? uzzzzzt_ = context.Operators.And(uzzzzze_, uzzzzzs_);
                bool? uzzzzzu_ = context.Operators.And(szzzzzx_, uzzzzzt_);

                return uzzzzzu_;
            };
            IEnumerable<Encounter> rzzzzzw_ = context.Operators.Where<Encounter>(rzzzzzu_, rzzzzzv_);
            object rzzzzzx_(Encounter @this)
            {
                Period xzzzzzv_ = @this?.Period;
                CqlInterval<CqlDateTime> xzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzv_);
                CqlDateTime xzzzzzx_ = context.Operators.End(xzzzzzw_);

                return xzzzzzx_;
            };
            IEnumerable<Encounter> rzzzzzy_ = context.Operators.SortBy<Encounter>(rzzzzzw_, rzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter rzzzzzz_ = context.Operators.Last<Encounter>(rzzzzzy_);
            Period szzzzza_ = rzzzzzz_?.Period;
            CqlInterval<CqlDateTime> szzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzza_);
            CqlDateTime szzzzzc_ = context.Operators.Start(szzzzzb_);
            CqlValueSet szzzzzd_ = this.Observation_Services(context);
            IEnumerable<Encounter> szzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? szzzzzf_(Encounter LastObs)
            {
                Code<Encounter.EncounterStatus> xzzzzzy_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? xzzzzzz_ = xzzzzzy_?.Value;
                Code<Encounter.EncounterStatus> yzzzzza_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(xzzzzzz_);
                bool? yzzzzzb_ = context.Operators.Equal(yzzzzza_, "finished");
                Period yzzzzzc_ = LastObs?.Period;
                CqlInterval<CqlDateTime> yzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzc_);
                CqlDateTime yzzzzze_ = context.Operators.End(yzzzzzd_);
                Period yzzzzzf_ = Visit?.Period;
                CqlInterval<CqlDateTime> yzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzf_);
                CqlDateTime yzzzzzh_ = context.Operators.Start(yzzzzzg_);
                CqlQuantity yzzzzzi_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime yzzzzzj_ = context.Operators.Subtract(yzzzzzh_, yzzzzzi_);
                CqlInterval<CqlDateTime> yzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzf_);
                CqlDateTime yzzzzzm_ = context.Operators.Start(yzzzzzl_);
                CqlInterval<CqlDateTime> yzzzzzn_ = context.Operators.Interval(yzzzzzj_, yzzzzzm_, true, true);
                bool? yzzzzzo_ = context.Operators.In<CqlDateTime>(yzzzzze_, yzzzzzn_, default);
                CqlInterval<CqlDateTime> yzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzf_);
                CqlDateTime yzzzzzr_ = context.Operators.Start(yzzzzzq_);
                bool? yzzzzzs_ = context.Operators.Not((bool?)(yzzzzzr_ is null));
                bool? yzzzzzt_ = context.Operators.And(yzzzzzo_, yzzzzzs_);
                bool? yzzzzzu_ = context.Operators.And(yzzzzzb_, yzzzzzt_);

                return yzzzzzu_;
            };
            IEnumerable<Encounter> szzzzzg_ = context.Operators.Where<Encounter>(szzzzze_, szzzzzf_);
            object szzzzzh_(Encounter @this)
            {
                Period yzzzzzv_ = @this?.Period;
                CqlInterval<CqlDateTime> yzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzv_);
                CqlDateTime yzzzzzx_ = context.Operators.End(yzzzzzw_);

                return yzzzzzx_;
            };
            IEnumerable<Encounter> szzzzzi_ = context.Operators.SortBy<Encounter>(szzzzzg_, szzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter szzzzzj_ = context.Operators.Last<Encounter>(szzzzzi_);
            Period szzzzzk_ = szzzzzj_?.Period;
            CqlInterval<CqlDateTime> szzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzk_);
            CqlDateTime szzzzzm_ = context.Operators.Start(szzzzzl_);
            Period szzzzzn_ = Visit?.Period;
            CqlInterval<CqlDateTime> szzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzn_);
            CqlDateTime szzzzzp_ = context.Operators.Start(szzzzzo_);
            CqlInterval<CqlDateTime> szzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzn_);
            CqlDateTime szzzzzs_ = context.Operators.End(szzzzzr_);
            CqlInterval<CqlDateTime> szzzzzt_ = context.Operators.Interval(szzzzzc_ ?? szzzzzm_ ?? szzzzzp_, szzzzzs_, true, true);

            return szzzzzt_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> rzzzzzq_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)rzzzzzo_, rzzzzzp_);
        IEnumerable<CqlInterval<CqlDateTime>> rzzzzzr_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(rzzzzzq_);
        CqlInterval<CqlDateTime> rzzzzzs_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(rzzzzzr_);

        return rzzzzzs_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservationLengthofStay")]
    [CqlTag("description", "Hospitalization with Observation Length of Stay returns the length in days from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationWithObservationLengthofStay()` instead.")]
    public int? HospitalizationWithObservationLengthofStay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> yzzzzzy_ = this.HospitalizationWithObservation(context, TheEncounter);
        int? yzzzzzz_ = this.LengthInDays(context, yzzzzzy_);

        return yzzzzzz_;
    }


    [CqlExpressionDefinition("hospitalizationWithObservationLengthofStay")]
    [CqlTag("description", "Hospitalization with Observation Length of Stay returns the length in days from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    public int? hospitalizationWithObservationLengthofStay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> zzzzzza_ = this.hospitalizationWithObservation(context, TheEncounter);
        int? zzzzzzb_ = this.lengthInDays(context, zzzzzza_);

        return zzzzzzb_;
    }


    [CqlExpressionDefinition("FirstInpatientIntensiveCareUnit")]
    [CqlTag("description", "First Inpatient Intensive Care Unit returns the first intensive care unit for the given encounter, without considering any immediately prior emergency department visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `firstInpatientIntensiveCareUnit()` instead.")]
    public Encounter.LocationComponent FirstInpatientIntensiveCareUnit(CqlContext context, Encounter Encounter)
    {
        List<Encounter.LocationComponent> zzzzzzc_ = Encounter?.Location;
        bool? zzzzzzd_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference zzzzzzi_ = HospitalLocation?.Location;
            Location zzzzzzj_ = this.GetLocation(context, zzzzzzi_);
            List<CodeableConcept> zzzzzzk_ = zzzzzzj_?.Type;
            CqlConcept zzzzzzl_(CodeableConcept @this)
            {
                CqlConcept zzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return zzzzzzv_;
            };
            IEnumerable<CqlConcept> zzzzzzm_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)zzzzzzk_, zzzzzzl_);
            CqlValueSet zzzzzzn_ = this.Intensive_Care_Unit(context);
            bool? zzzzzzo_ = context.Operators.ConceptsInValueSet(zzzzzzm_, zzzzzzn_);
            Period zzzzzzp_ = Encounter?.Period;
            CqlInterval<CqlDateTime> zzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzp_);
            Period zzzzzzr_ = HospitalLocation?.Period;
            CqlInterval<CqlDateTime> zzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzr_);
            bool? zzzzzzt_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(zzzzzzq_, zzzzzzs_, default);
            bool? zzzzzzu_ = context.Operators.And(zzzzzzo_, zzzzzzt_);

            return zzzzzzu_;
        };
        IEnumerable<Encounter.LocationComponent> zzzzzze_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)zzzzzzc_, zzzzzzd_);
        object zzzzzzf_(Encounter.LocationComponent @this)
        {
            Period zzzzzzw_ = @this?.Period;
            CqlInterval<CqlDateTime> zzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzw_);
            CqlDateTime zzzzzzy_ = context.Operators.Start(zzzzzzx_);

            return zzzzzzy_;
        };
        IEnumerable<Encounter.LocationComponent> zzzzzzg_ = context.Operators.SortBy<Encounter.LocationComponent>(zzzzzze_, zzzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent zzzzzzh_ = context.Operators.First<Encounter.LocationComponent>(zzzzzzg_);

        return zzzzzzh_;
    }


    [CqlExpressionDefinition("firstInpatientIntensiveCareUnit")]
    [CqlTag("description", "First Inpatient Intensive Care Unit returns the first intensive care unit for the given encounter, without considering any immediately prior emergency department visit.")]
    public Encounter.LocationComponent firstInpatientIntensiveCareUnit(CqlContext context, Encounter Encounter)
    {
        List<Encounter.LocationComponent> zzzzzzz_ = Encounter?.Location;
        bool? azzzzzza_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference azzzzzzf_ = HospitalLocation?.Location;
            Location azzzzzzg_ = this.GetLocation(context, azzzzzzf_);
            List<CodeableConcept> azzzzzzh_ = azzzzzzg_?.Type;
            CqlConcept azzzzzzi_(CodeableConcept @this)
            {
                CqlConcept azzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return azzzzzzs_;
            };
            IEnumerable<CqlConcept> azzzzzzj_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)azzzzzzh_, azzzzzzi_);
            CqlValueSet azzzzzzk_ = this.Intensive_Care_Unit(context);
            bool? azzzzzzl_ = context.Operators.ConceptsInValueSet(azzzzzzj_, azzzzzzk_);
            Period azzzzzzm_ = Encounter?.Period;
            CqlInterval<CqlDateTime> azzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzm_);
            Period azzzzzzo_ = HospitalLocation?.Period;
            CqlInterval<CqlDateTime> azzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzo_);
            bool? azzzzzzq_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(azzzzzzn_, azzzzzzp_, default);
            bool? azzzzzzr_ = context.Operators.And(azzzzzzl_, azzzzzzq_);

            return azzzzzzr_;
        };
        IEnumerable<Encounter.LocationComponent> azzzzzzb_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)zzzzzzz_, azzzzzza_);
        object azzzzzzc_(Encounter.LocationComponent @this)
        {
            Period azzzzzzt_ = @this?.Period;
            CqlInterval<CqlDateTime> azzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzt_);
            CqlDateTime azzzzzzv_ = context.Operators.Start(azzzzzzu_);

            return azzzzzzv_;
        };
        IEnumerable<Encounter.LocationComponent> azzzzzzd_ = context.Operators.SortBy<Encounter.LocationComponent>(azzzzzzb_, azzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent azzzzzze_ = context.Operators.First<Encounter.LocationComponent>(azzzzzzd_);

        return azzzzzze_;
    }


    [CqlExpressionDefinition("EncounterDiagnosis")]
    [CqlTag("description", "Returns the Condition resource referenced by the `diagnosis.condition` element of the Encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `encounterDiagnosis()` instead.")]
    public IEnumerable<Condition> EncounterDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> azzzzzzw_ = Encounter?.Diagnosis;
        Condition azzzzzzx_(Encounter.DiagnosisComponent D)
        {
            IEnumerable<Condition> bzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? bzzzzzzb_(Condition C)
            {
                Id bzzzzzze_ = C?.IdElement;
                string bzzzzzzf_ = bzzzzzze_?.Value;
                ResourceReference bzzzzzzg_ = D?.Condition;
                FhirString bzzzzzzh_ = bzzzzzzg_?.ReferenceElement;
                string bzzzzzzi_ = bzzzzzzh_?.Value;
                string bzzzzzzj_ = QICoreCommon_2_1_000.Instance.getId(context, bzzzzzzi_);
                bool? bzzzzzzk_ = context.Operators.Equal(bzzzzzzf_, bzzzzzzj_);

                return bzzzzzzk_;
            };
            IEnumerable<Condition> bzzzzzzc_ = context.Operators.Where<Condition>(bzzzzzza_, bzzzzzzb_);
            Condition bzzzzzzd_ = context.Operators.SingletonFrom<Condition>(bzzzzzzc_);

            return bzzzzzzd_;
        };
        IEnumerable<Condition> azzzzzzy_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)azzzzzzw_, azzzzzzx_);
        IEnumerable<Condition> azzzzzzz_ = context.Operators.Distinct<Condition>(azzzzzzy_);

        return azzzzzzz_;
    }


    [CqlExpressionDefinition("encounterDiagnosis")]
    [CqlTag("description", "Returns the Condition resources referenced by the diagnosis element of the Encounter")]
    public IEnumerable<Condition> encounterDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> bzzzzzzl_ = Encounter?.Diagnosis;
        Condition bzzzzzzm_(Encounter.DiagnosisComponent D)
        {
            IEnumerable<Condition> bzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? bzzzzzzq_(Condition C)
            {
                Id bzzzzzzt_ = C?.IdElement;
                string bzzzzzzu_ = bzzzzzzt_?.Value;
                ResourceReference bzzzzzzv_ = D?.Condition;
                FhirString bzzzzzzw_ = bzzzzzzv_?.ReferenceElement;
                string bzzzzzzx_ = bzzzzzzw_?.Value;
                string bzzzzzzy_ = QICoreCommon_2_1_000.Instance.getId(context, bzzzzzzx_);
                bool? bzzzzzzz_ = context.Operators.Equal(bzzzzzzu_, bzzzzzzy_);

                return bzzzzzzz_;
            };
            IEnumerable<Condition> bzzzzzzr_ = context.Operators.Where<Condition>(bzzzzzzp_, bzzzzzzq_);
            Condition bzzzzzzs_ = context.Operators.SingletonFrom<Condition>(bzzzzzzr_);

            return bzzzzzzs_;
        };
        IEnumerable<Condition> bzzzzzzn_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)bzzzzzzl_, bzzzzzzm_);
        IEnumerable<Condition> bzzzzzzo_ = context.Operators.Distinct<Condition>(bzzzzzzn_);

        return bzzzzzzo_;
    }


    [CqlExpressionDefinition("GetCondition")]
    [CqlTag("description", "Returns the Condition resource for the given reference")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getCondition()` instead")]
    public Condition GetCondition(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Condition> czzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? czzzzzzb_(Condition C)
        {
            Id czzzzzze_ = C?.IdElement;
            string czzzzzzf_ = czzzzzze_?.Value;
            FhirString czzzzzzg_ = reference?.ReferenceElement;
            string czzzzzzh_ = czzzzzzg_?.Value;
            string czzzzzzi_ = QICoreCommon_2_1_000.Instance.getId(context, czzzzzzh_);
            bool? czzzzzzj_ = context.Operators.Equal(czzzzzzf_, czzzzzzi_);

            return czzzzzzj_;
        };
        IEnumerable<Condition> czzzzzzc_ = context.Operators.Where<Condition>(czzzzzza_, czzzzzzb_);
        Condition czzzzzzd_ = context.Operators.SingletonFrom<Condition>(czzzzzzc_);

        return czzzzzzd_;
    }


    [CqlExpressionDefinition("getCondition")]
    [CqlTag("description", "Returns the Condition resource for the given reference")]
    public Condition getCondition(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Condition> czzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? czzzzzzl_(Condition C)
        {
            Id czzzzzzo_ = C?.IdElement;
            string czzzzzzp_ = czzzzzzo_?.Value;
            FhirString czzzzzzq_ = reference?.ReferenceElement;
            string czzzzzzr_ = czzzzzzq_?.Value;
            string czzzzzzs_ = QICoreCommon_2_1_000.Instance.getId(context, czzzzzzr_);
            bool? czzzzzzt_ = context.Operators.Equal(czzzzzzp_, czzzzzzs_);

            return czzzzzzt_;
        };
        IEnumerable<Condition> czzzzzzm_ = context.Operators.Where<Condition>(czzzzzzk_, czzzzzzl_);
        Condition czzzzzzn_ = context.Operators.SingletonFrom<Condition>(czzzzzzm_);

        return czzzzzzn_;
    }


    [CqlExpressionDefinition("PrincipalDiagnosis")]
    [CqlTag("description", "Returns the condition that is specified as the principal diagnosis for the encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `principalDiagnosis()` instead.")]
    public Condition PrincipalDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> czzzzzzu_ = Encounter?.Diagnosis;
        bool? czzzzzzv_(Encounter.DiagnosisComponent D)
        {
            PositiveInt dzzzzzzb_ = D?.RankElement;
            int? dzzzzzzc_ = dzzzzzzb_?.Value;
            bool? dzzzzzzd_ = context.Operators.Equal(dzzzzzzc_, 1);
            CodeableConcept dzzzzzze_ = D?.Use;
            CqlConcept dzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dzzzzzze_);
            CqlCode dzzzzzzg_ = this.Billing(context);
            CqlConcept dzzzzzzh_ = context.Operators.ConvertCodeToConcept(dzzzzzzg_);
            bool? dzzzzzzi_ = context.Operators.Equivalent(dzzzzzzf_, dzzzzzzh_);
            bool? dzzzzzzj_ = context.Operators.And(dzzzzzzd_, dzzzzzzi_);

            return dzzzzzzj_;
        };
        IEnumerable<Encounter.DiagnosisComponent> czzzzzzw_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)czzzzzzu_, czzzzzzv_);
        Condition czzzzzzx_(Encounter.DiagnosisComponent PD)
        {
            IEnumerable<Condition> dzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? dzzzzzzl_(Condition C)
            {
                Id dzzzzzzo_ = C?.IdElement;
                string dzzzzzzp_ = dzzzzzzo_?.Value;
                ResourceReference dzzzzzzq_ = PD?.Condition;
                FhirString dzzzzzzr_ = dzzzzzzq_?.ReferenceElement;
                string dzzzzzzs_ = dzzzzzzr_?.Value;
                string dzzzzzzt_ = QICoreCommon_2_1_000.Instance.getId(context, dzzzzzzs_);
                bool? dzzzzzzu_ = context.Operators.Equal(dzzzzzzp_, dzzzzzzt_);

                return dzzzzzzu_;
            };
            IEnumerable<Condition> dzzzzzzm_ = context.Operators.Where<Condition>(dzzzzzzk_, dzzzzzzl_);
            Condition dzzzzzzn_ = context.Operators.SingletonFrom<Condition>(dzzzzzzm_);

            return dzzzzzzn_;
        };
        IEnumerable<Condition> czzzzzzy_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>(czzzzzzw_, czzzzzzx_);
        IEnumerable<Condition> czzzzzzz_ = context.Operators.Distinct<Condition>(czzzzzzy_);
        Condition dzzzzzza_ = context.Operators.SingletonFrom<Condition>(czzzzzzz_);

        return dzzzzzza_;
    }


    [CqlExpressionDefinition("principalDiagnosis")]
    [CqlTag("description", "Returns the condition that is specified as the principal diagnosis for the encounter")]
    public Condition principalDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> dzzzzzzv_ = Encounter?.Diagnosis;
        bool? dzzzzzzw_(Encounter.DiagnosisComponent D)
        {
            PositiveInt ezzzzzzc_ = D?.RankElement;
            int? ezzzzzzd_ = ezzzzzzc_?.Value;
            bool? ezzzzzze_ = context.Operators.Equal(ezzzzzzd_, 1);
            CodeableConcept ezzzzzzf_ = D?.Use;
            CqlConcept ezzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzf_);
            CqlCode ezzzzzzh_ = this.Billing(context);
            CqlConcept ezzzzzzi_ = context.Operators.ConvertCodeToConcept(ezzzzzzh_);
            bool? ezzzzzzj_ = context.Operators.Equivalent(ezzzzzzg_, ezzzzzzi_);
            bool? ezzzzzzk_ = context.Operators.And(ezzzzzze_, ezzzzzzj_);

            return ezzzzzzk_;
        };
        IEnumerable<Encounter.DiagnosisComponent> dzzzzzzx_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)dzzzzzzv_, dzzzzzzw_);
        Condition dzzzzzzy_(Encounter.DiagnosisComponent PD)
        {
            IEnumerable<Condition> ezzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? ezzzzzzm_(Condition C)
            {
                Id ezzzzzzp_ = C?.IdElement;
                string ezzzzzzq_ = ezzzzzzp_?.Value;
                ResourceReference ezzzzzzr_ = PD?.Condition;
                FhirString ezzzzzzs_ = ezzzzzzr_?.ReferenceElement;
                string ezzzzzzt_ = ezzzzzzs_?.Value;
                string ezzzzzzu_ = QICoreCommon_2_1_000.Instance.getId(context, ezzzzzzt_);
                bool? ezzzzzzv_ = context.Operators.Equal(ezzzzzzq_, ezzzzzzu_);

                return ezzzzzzv_;
            };
            IEnumerable<Condition> ezzzzzzn_ = context.Operators.Where<Condition>(ezzzzzzl_, ezzzzzzm_);
            Condition ezzzzzzo_ = context.Operators.SingletonFrom<Condition>(ezzzzzzn_);

            return ezzzzzzo_;
        };
        IEnumerable<Condition> dzzzzzzz_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>(dzzzzzzx_, dzzzzzzy_);
        IEnumerable<Condition> ezzzzzza_ = context.Operators.Distinct<Condition>(dzzzzzzz_);
        Condition ezzzzzzb_ = context.Operators.SingletonFrom<Condition>(ezzzzzza_);

        return ezzzzzzb_;
    }


    [CqlExpressionDefinition("getLocation")]
    [CqlTag("description", "Returns the Location resource specified by the given reference.")]
    public Location getLocation(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Location> ezzzzzzw_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-location"));
        bool? ezzzzzzx_(Location L)
        {
            Id fzzzzzza_ = L?.IdElement;
            string fzzzzzzb_ = fzzzzzza_?.Value;
            FhirString fzzzzzzc_ = reference?.ReferenceElement;
            string fzzzzzzd_ = fzzzzzzc_?.Value;
            string fzzzzzze_ = QICoreCommon_2_1_000.Instance.getId(context, fzzzzzzd_);
            bool? fzzzzzzf_ = context.Operators.Equal(fzzzzzzb_, fzzzzzze_);

            return fzzzzzzf_;
        };
        IEnumerable<Location> ezzzzzzy_ = context.Operators.Where<Location>(ezzzzzzw_, ezzzzzzx_);
        Location ezzzzzzz_ = context.Operators.SingletonFrom<Location>(ezzzzzzy_);

        return ezzzzzzz_;
    }


    [CqlExpressionDefinition("GetMedicationCode")]
    [CqlTag("description", "Returns the medication code for the given MedicationRequest")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getMedicationCode()` instead.")]
    public CqlConcept GetMedicationCode(CqlContext context, MedicationRequest request)
    {
        CqlConcept fzzzzzzg_()
        {
            bool fzzzzzzh_()
            {
                DataType fzzzzzzi_ = request?.Medication;
                object fzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzi_);
                bool fzzzzzzk_ = fzzzzzzj_ is CqlConcept;

                return fzzzzzzk_;
            };
            if (fzzzzzzh_())
            {
                DataType fzzzzzzl_ = request?.Medication;
                object fzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzl_);

                return fzzzzzzm_ as CqlConcept;
            }
            else
            {
                IEnumerable<Medication> fzzzzzzn_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? fzzzzzzo_(Medication M)
                {
                    Id fzzzzzzt_ = M?.IdElement;
                    string fzzzzzzu_ = fzzzzzzt_?.Value;
                    DataType fzzzzzzv_ = request?.Medication;
                    object fzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzv_);
                    FhirString fzzzzzzx_ = (fzzzzzzw_ as ResourceReference)?.ReferenceElement;
                    string fzzzzzzy_ = fzzzzzzx_?.Value;
                    string fzzzzzzz_ = QICoreCommon_2_1_000.Instance.getId(context, fzzzzzzy_);
                    bool? gzzzzzza_ = context.Operators.Equal(fzzzzzzu_, fzzzzzzz_);

                    return gzzzzzza_;
                };
                IEnumerable<Medication> fzzzzzzp_ = context.Operators.Where<Medication>(fzzzzzzn_, fzzzzzzo_);
                Medication fzzzzzzq_ = context.Operators.SingletonFrom<Medication>(fzzzzzzp_);
                CodeableConcept fzzzzzzr_ = fzzzzzzq_?.Code;
                CqlConcept fzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fzzzzzzr_);

                return fzzzzzzs_;
            }
        };

        return fzzzzzzg_();
    }


    [CqlExpressionDefinition("getMedicationCode")]
    [CqlTag("description", "Returns the medication code for the given MedicationRequest")]
    public CqlConcept getMedicationCode(CqlContext context, MedicationRequest request)
    {
        CqlConcept gzzzzzzb_()
        {
            bool gzzzzzzc_()
            {
                DataType gzzzzzzd_ = request?.Medication;
                object gzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzd_);
                bool gzzzzzzf_ = gzzzzzze_ is CqlConcept;

                return gzzzzzzf_;
            };
            if (gzzzzzzc_())
            {
                DataType gzzzzzzg_ = request?.Medication;
                object gzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzg_);

                return gzzzzzzh_ as CqlConcept;
            }
            else
            {
                IEnumerable<Medication> gzzzzzzi_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? gzzzzzzj_(Medication M)
                {
                    Id gzzzzzzo_ = M?.IdElement;
                    string gzzzzzzp_ = gzzzzzzo_?.Value;
                    DataType gzzzzzzq_ = request?.Medication;
                    object gzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzq_);
                    FhirString gzzzzzzs_ = (gzzzzzzr_ as ResourceReference)?.ReferenceElement;
                    string gzzzzzzt_ = gzzzzzzs_?.Value;
                    string gzzzzzzu_ = QICoreCommon_2_1_000.Instance.getId(context, gzzzzzzt_);
                    bool? gzzzzzzv_ = context.Operators.Equal(gzzzzzzp_, gzzzzzzu_);

                    return gzzzzzzv_;
                };
                IEnumerable<Medication> gzzzzzzk_ = context.Operators.Where<Medication>(gzzzzzzi_, gzzzzzzj_);
                Medication gzzzzzzl_ = context.Operators.SingletonFrom<Medication>(gzzzzzzk_);
                CodeableConcept gzzzzzzm_ = gzzzzzzl_?.Code;
                CqlConcept gzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gzzzzzzm_);

                return gzzzzzzn_;
            }
        };

        return gzzzzzzb_();
    }


    #endregion Expressions

}
