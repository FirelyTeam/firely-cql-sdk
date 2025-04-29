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
        CqlDateTime qzzzzzg_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime qzzzzzh_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> qzzzzzi_ = context.Operators.Interval(qzzzzzg_, qzzzzzh_, true, false);
        object qzzzzzj_ = context.ResolveParameter("CQMCommon-2.2.000", "Measurement Period", qzzzzzi_);

        return (CqlInterval<CqlDateTime>)qzzzzzj_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> qzzzzzk_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient qzzzzzl_ = context.Operators.SingletonFrom<Patient>(qzzzzzk_);

        return qzzzzzl_;
    }


    [CqlExpressionDefinition("Inpatient Encounter")]
    public IEnumerable<Encounter> Inpatient_Encounter(CqlContext context)
    {
        CqlValueSet qzzzzzm_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> qzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? qzzzzzo_(Encounter EncounterInpatient)
        {
            Code<Encounter.EncounterStatus> qzzzzzq_ = EncounterInpatient?.StatusElement;
            Encounter.EncounterStatus? qzzzzzr_ = qzzzzzq_?.Value;
            Code<Encounter.EncounterStatus> qzzzzzs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(qzzzzzr_);
            bool? qzzzzzt_ = context.Operators.Equal(qzzzzzs_, "finished");
            Period qzzzzzu_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime> qzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzu_);
            CqlDateTime qzzzzzw_ = context.Operators.End(qzzzzzv_);
            CqlInterval<CqlDateTime> qzzzzzx_ = this.Measurement_Period(context);
            bool? qzzzzzy_ = context.Operators.In<CqlDateTime>(qzzzzzw_, qzzzzzx_, "day");
            bool? qzzzzzz_ = context.Operators.And(qzzzzzt_, qzzzzzy_);

            return qzzzzzz_;
        };
        IEnumerable<Encounter> qzzzzzp_ = context.Operators.Where<Encounter>(qzzzzzn_, qzzzzzo_);

        return qzzzzzp_;
    }


    [CqlExpressionDefinition("ToDateInterval")]
    [CqlTag("description", "Returns an interval of date values extracted from the input interval of date-time values")]
    [CqlTag("comment", "This function returns an interval constructed using the `date from` extractor on the start\nand end values of the input date-time interval. Note that using a precision specifier such as `day of`\nas part of a timing phrase is preferred to communicate intent to perform day-level comparison, as well\nas for general readability.")]
    public CqlInterval<CqlDate> ToDateInterval(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime rzzzzza_ = context.Operators.Start(period);
        CqlDate rzzzzzb_ = context.Operators.DateFrom(rzzzzza_);
        CqlDateTime rzzzzzc_ = context.Operators.End(period);
        CqlDate rzzzzzd_ = context.Operators.DateFrom(rzzzzzc_);
        CqlInterval<CqlDate> rzzzzze_ = context.Operators.Interval(rzzzzzb_, rzzzzzd_, true, true);

        return rzzzzze_;
    }


    [CqlExpressionDefinition("LengthInDays")]
    [CqlTag("description", "Calculates the difference in calendar days between the start and end of the given interval.")]
    [CqlTag("deprecated", "This function in deprecated. Use the fluent function `lengthInDays()` instead.")]
    public int? LengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
    {
        CqlDateTime rzzzzzf_ = context.Operators.Start(Value);
        CqlDateTime rzzzzzg_ = context.Operators.End(Value);
        int? rzzzzzh_ = context.Operators.DifferenceBetween(rzzzzzf_, rzzzzzg_, "day");

        return rzzzzzh_;
    }


    [CqlExpressionDefinition("lengthInDays")]
    [CqlTag("description", "Calculates the difference in calendar days between the start and end of the given interval.")]
    public int? lengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
    {
        CqlDateTime rzzzzzi_ = context.Operators.Start(Value);
        CqlDateTime rzzzzzj_ = context.Operators.End(Value);
        int? rzzzzzk_ = context.Operators.DifferenceBetween(rzzzzzi_, rzzzzzj_, "day");

        return rzzzzzk_;
    }


    [CqlExpressionDefinition("ED Visit")]
    [CqlTag("description", "Returns the most recent emergency department visit, if any, that occurs 1 hour or less prior to the given encounter.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `edVisit()` instead.")]
    public Encounter ED_Visit(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet rzzzzzl_ = this.Emergency_Department_Visit(context);
        IEnumerable<Encounter> rzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? rzzzzzn_(Encounter EDVisit)
        {
            Code<Encounter.EncounterStatus> rzzzzzs_ = EDVisit?.StatusElement;
            Encounter.EncounterStatus? rzzzzzt_ = rzzzzzs_?.Value;
            Code<Encounter.EncounterStatus> rzzzzzu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rzzzzzt_);
            bool? rzzzzzv_ = context.Operators.Equal(rzzzzzu_, "finished");
            Period rzzzzzw_ = EDVisit?.Period;
            CqlInterval<CqlDateTime> rzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzw_);
            CqlDateTime rzzzzzy_ = context.Operators.End(rzzzzzx_);
            Period rzzzzzz_ = TheEncounter?.Period;
            CqlInterval<CqlDateTime> szzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzz_);
            CqlDateTime szzzzzb_ = context.Operators.Start(szzzzza_);
            CqlQuantity szzzzzc_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime szzzzzd_ = context.Operators.Subtract(szzzzzb_, szzzzzc_);
            CqlInterval<CqlDateTime> szzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzz_);
            CqlDateTime szzzzzg_ = context.Operators.Start(szzzzzf_);
            CqlInterval<CqlDateTime> szzzzzh_ = context.Operators.Interval(szzzzzd_, szzzzzg_, true, true);
            bool? szzzzzi_ = context.Operators.In<CqlDateTime>(rzzzzzy_, szzzzzh_, default);
            CqlInterval<CqlDateTime> szzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzz_);
            CqlDateTime szzzzzl_ = context.Operators.Start(szzzzzk_);
            bool? szzzzzm_ = context.Operators.Not((bool?)(szzzzzl_ is null));
            bool? szzzzzn_ = context.Operators.And(szzzzzi_, szzzzzm_);
            bool? szzzzzo_ = context.Operators.And(rzzzzzv_, szzzzzn_);

            return szzzzzo_;
        };
        IEnumerable<Encounter> rzzzzzo_ = context.Operators.Where<Encounter>(rzzzzzm_, rzzzzzn_);
        object rzzzzzp_(Encounter @this)
        {
            Period szzzzzp_ = @this?.Period;
            CqlInterval<CqlDateTime> szzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzp_);
            CqlDateTime szzzzzr_ = context.Operators.End(szzzzzq_);

            return szzzzzr_;
        };
        IEnumerable<Encounter> rzzzzzq_ = context.Operators.SortBy<Encounter>(rzzzzzo_, rzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter rzzzzzr_ = context.Operators.Last<Encounter>(rzzzzzq_);

        return rzzzzzr_;
    }


    [CqlExpressionDefinition("edVisit")]
    [CqlTag("description", "Returns the most recent emergency department visit, if any, that occurs 1 hour or less prior to the given encounter.")]
    public Encounter edVisit(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet szzzzzs_ = this.Emergency_Department_Visit(context);
        IEnumerable<Encounter> szzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? szzzzzu_(Encounter EDVisit)
        {
            Code<Encounter.EncounterStatus> szzzzzz_ = EDVisit?.StatusElement;
            Encounter.EncounterStatus? tzzzzza_ = szzzzzz_?.Value;
            Code<Encounter.EncounterStatus> tzzzzzb_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(tzzzzza_);
            bool? tzzzzzc_ = context.Operators.Equal(tzzzzzb_, "finished");
            Period tzzzzzd_ = EDVisit?.Period;
            CqlInterval<CqlDateTime> tzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzd_);
            CqlDateTime tzzzzzf_ = context.Operators.End(tzzzzze_);
            Period tzzzzzg_ = TheEncounter?.Period;
            CqlInterval<CqlDateTime> tzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzg_);
            CqlDateTime tzzzzzi_ = context.Operators.Start(tzzzzzh_);
            CqlQuantity tzzzzzj_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime tzzzzzk_ = context.Operators.Subtract(tzzzzzi_, tzzzzzj_);
            CqlInterval<CqlDateTime> tzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzg_);
            CqlDateTime tzzzzzn_ = context.Operators.Start(tzzzzzm_);
            CqlInterval<CqlDateTime> tzzzzzo_ = context.Operators.Interval(tzzzzzk_, tzzzzzn_, true, true);
            bool? tzzzzzp_ = context.Operators.In<CqlDateTime>(tzzzzzf_, tzzzzzo_, default);
            CqlInterval<CqlDateTime> tzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzg_);
            CqlDateTime tzzzzzs_ = context.Operators.Start(tzzzzzr_);
            bool? tzzzzzt_ = context.Operators.Not((bool?)(tzzzzzs_ is null));
            bool? tzzzzzu_ = context.Operators.And(tzzzzzp_, tzzzzzt_);
            bool? tzzzzzv_ = context.Operators.And(tzzzzzc_, tzzzzzu_);

            return tzzzzzv_;
        };
        IEnumerable<Encounter> szzzzzv_ = context.Operators.Where<Encounter>(szzzzzt_, szzzzzu_);
        object szzzzzw_(Encounter @this)
        {
            Period tzzzzzw_ = @this?.Period;
            CqlInterval<CqlDateTime> tzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzw_);
            CqlDateTime tzzzzzy_ = context.Operators.End(tzzzzzx_);

            return tzzzzzy_;
        };
        IEnumerable<Encounter> szzzzzx_ = context.Operators.SortBy<Encounter>(szzzzzv_, szzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter szzzzzy_ = context.Operators.Last<Encounter>(szzzzzx_);

        return szzzzzy_;
    }


    [CqlExpressionDefinition("Hospitalization")]
    [CqlTag("description", "Hospitalization returns the total interval for admission to discharge for the given encounter, or for the admission of any immediately prior emergency department visit to the discharge of the given encounter.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalization()` instead.")]
    public CqlInterval<CqlDateTime> Hospitalization(CqlContext context, Encounter TheEncounter)
    {
        Encounter tzzzzzz_ = this.ED_Visit(context, TheEncounter);
        Encounter[] uzzzzza_ = [
            tzzzzzz_,
        ];
        CqlInterval<CqlDateTime> uzzzzzb_(Encounter X)
        {
            CqlInterval<CqlDateTime> uzzzzzf_()
            {
                if (X is null)
                {
                    Period uzzzzzg_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> uzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzg_);

                    return uzzzzzh_;
                }
                else
                {
                    Period uzzzzzi_ = X?.Period;
                    CqlInterval<CqlDateTime> uzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzi_);
                    CqlDateTime uzzzzzk_ = context.Operators.Start(uzzzzzj_);
                    Period uzzzzzl_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> uzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzl_);
                    CqlDateTime uzzzzzn_ = context.Operators.End(uzzzzzm_);
                    CqlInterval<CqlDateTime> uzzzzzo_ = context.Operators.Interval(uzzzzzk_, uzzzzzn_, true, false);

                    return uzzzzzo_;
                }
            };

            return uzzzzzf_();
        };
        IEnumerable<CqlInterval<CqlDateTime>> uzzzzzc_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)uzzzzza_, uzzzzzb_);
        IEnumerable<CqlInterval<CqlDateTime>> uzzzzzd_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(uzzzzzc_);
        CqlInterval<CqlDateTime> uzzzzze_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(uzzzzzd_);

        return uzzzzze_;
    }


    [CqlExpressionDefinition("hospitalization")]
    [CqlTag("description", "Hospitalization returns the total interval for admission to discharge for the given encounter, or for the admission of any immediately prior emergency department visit to the discharge of the given encounter.")]
    public CqlInterval<CqlDateTime> hospitalization(CqlContext context, Encounter TheEncounter)
    {
        Encounter uzzzzzp_ = this.edVisit(context, TheEncounter);
        Encounter[] uzzzzzq_ = [
            uzzzzzp_,
        ];
        CqlInterval<CqlDateTime> uzzzzzr_(Encounter X)
        {
            CqlInterval<CqlDateTime> uzzzzzv_()
            {
                if (X is null)
                {
                    Period uzzzzzw_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> uzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzw_);

                    return uzzzzzx_;
                }
                else
                {
                    Period uzzzzzy_ = X?.Period;
                    CqlInterval<CqlDateTime> uzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzy_);
                    CqlDateTime vzzzzza_ = context.Operators.Start(uzzzzzz_);
                    Period vzzzzzb_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> vzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzb_);
                    CqlDateTime vzzzzzd_ = context.Operators.End(vzzzzzc_);
                    CqlInterval<CqlDateTime> vzzzzze_ = context.Operators.Interval(vzzzzza_, vzzzzzd_, true, true);

                    return vzzzzze_;
                }
            };

            return uzzzzzv_();
        };
        IEnumerable<CqlInterval<CqlDateTime>> uzzzzzs_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)uzzzzzq_, uzzzzzr_);
        IEnumerable<CqlInterval<CqlDateTime>> uzzzzzt_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(uzzzzzs_);
        CqlInterval<CqlDateTime> uzzzzzu_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(uzzzzzt_);

        return uzzzzzu_;
    }


    [CqlExpressionDefinition("Hospitalization Locations")]
    [CqlTag("description", "Returns list of all locations within an encounter, including locations for immediately prior ED visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationLocations()` instead.")]
    public IEnumerable<Encounter.LocationComponent> Hospitalization_Locations(CqlContext context, Encounter TheEncounter)
    {
        Encounter vzzzzzf_ = this.ED_Visit(context, TheEncounter);
        Encounter[] vzzzzzg_ = [
            vzzzzzf_,
        ];
        IEnumerable<Encounter.LocationComponent> vzzzzzh_(Encounter EDEncounter)
        {
            IEnumerable<Encounter.LocationComponent> vzzzzzl_()
            {
                if (EDEncounter is null)
                {
                    List<Encounter.LocationComponent> vzzzzzm_ = TheEncounter?.Location;

                    return (IEnumerable<Encounter.LocationComponent>)vzzzzzm_;
                }
                else
                {
                    List<Encounter.LocationComponent> vzzzzzn_ = EDEncounter?.Location;
                    List<Encounter.LocationComponent> vzzzzzo_ = TheEncounter?.Location;
                    IEnumerable<Encounter.LocationComponent>[] vzzzzzp_ = [
                        (IEnumerable<Encounter.LocationComponent>)vzzzzzn_,
                        (IEnumerable<Encounter.LocationComponent>)vzzzzzo_,
                    ];
                    IEnumerable<Encounter.LocationComponent> vzzzzzq_ = context.Operators.Flatten<Encounter.LocationComponent>(vzzzzzp_ as IEnumerable<IEnumerable<Encounter.LocationComponent>>);

                    return vzzzzzq_;
                }
            };

            return vzzzzzl_();
        };
        IEnumerable<IEnumerable<Encounter.LocationComponent>> vzzzzzi_ = context.Operators.Select<Encounter, IEnumerable<Encounter.LocationComponent>>((IEnumerable<Encounter>)vzzzzzg_, vzzzzzh_);
        IEnumerable<IEnumerable<Encounter.LocationComponent>> vzzzzzj_ = context.Operators.Distinct<IEnumerable<Encounter.LocationComponent>>(vzzzzzi_);
        IEnumerable<Encounter.LocationComponent> vzzzzzk_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(vzzzzzj_);

        return vzzzzzk_;
    }


    [CqlExpressionDefinition("hospitalizationLocations")]
    [CqlTag("description", "Returns list of all locations within an encounter, including locations for immediately prior ED visit.")]
    public IEnumerable<Encounter.LocationComponent> hospitalizationLocations(CqlContext context, Encounter TheEncounter)
    {
        Encounter vzzzzzr_ = this.edVisit(context, TheEncounter);
        Encounter[] vzzzzzs_ = [
            vzzzzzr_,
        ];
        IEnumerable<Encounter.LocationComponent> vzzzzzt_(Encounter EDEncounter)
        {
            IEnumerable<Encounter.LocationComponent> vzzzzzx_()
            {
                if (EDEncounter is null)
                {
                    List<Encounter.LocationComponent> vzzzzzy_ = TheEncounter?.Location;

                    return (IEnumerable<Encounter.LocationComponent>)vzzzzzy_;
                }
                else
                {
                    List<Encounter.LocationComponent> vzzzzzz_ = EDEncounter?.Location;
                    List<Encounter.LocationComponent> wzzzzza_ = TheEncounter?.Location;
                    IEnumerable<Encounter.LocationComponent>[] wzzzzzb_ = [
                        (IEnumerable<Encounter.LocationComponent>)vzzzzzz_,
                        (IEnumerable<Encounter.LocationComponent>)wzzzzza_,
                    ];
                    IEnumerable<Encounter.LocationComponent> wzzzzzc_ = context.Operators.Flatten<Encounter.LocationComponent>(wzzzzzb_ as IEnumerable<IEnumerable<Encounter.LocationComponent>>);

                    return wzzzzzc_;
                }
            };

            return vzzzzzx_();
        };
        IEnumerable<IEnumerable<Encounter.LocationComponent>> vzzzzzu_ = context.Operators.Select<Encounter, IEnumerable<Encounter.LocationComponent>>((IEnumerable<Encounter>)vzzzzzs_, vzzzzzt_);
        IEnumerable<IEnumerable<Encounter.LocationComponent>> vzzzzzv_ = context.Operators.Distinct<IEnumerable<Encounter.LocationComponent>>(vzzzzzu_);
        IEnumerable<Encounter.LocationComponent> vzzzzzw_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(vzzzzzv_);

        return vzzzzzw_;
    }


    [CqlExpressionDefinition("Hospitalization Length of Stay")]
    [CqlTag("description", "Returns the length of stay in days (i.e. the number of days between admission and discharge) for the given encounter, or from the admission of any immediately prior emergency department visit to the discharge of the encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationLengthOfStay()` instead.")]
    public int? Hospitalization_Length_of_Stay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> wzzzzzd_ = this.Hospitalization(context, TheEncounter);
        int? wzzzzze_ = this.LengthInDays(context, wzzzzzd_);

        return wzzzzze_;
    }


    [CqlExpressionDefinition("hospitalizationLengthOfStay")]
    [CqlTag("description", "Returns the length of stay in days (i.e. the number of days between admission and discharge) for the given encounter, or from the admission of any immediately prior emergency department visit to the discharge of the encounter")]
    public int? hospitalizationLengthOfStay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> wzzzzzf_ = this.hospitalization(context, TheEncounter);
        int? wzzzzzg_ = this.lengthInDays(context, wzzzzzf_);

        return wzzzzzg_;
    }


    [CqlExpressionDefinition("Hospital Admission Time")]
    [CqlTag("description", "Returns admission time for an encounter or for immediately prior emergency department visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalAdmissionTime()` instead.")]
    public CqlDateTime Hospital_Admission_Time(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> wzzzzzh_ = this.Hospitalization(context, TheEncounter);
        CqlDateTime wzzzzzi_ = context.Operators.Start(wzzzzzh_);

        return wzzzzzi_;
    }


    [CqlExpressionDefinition("hospitalAdmissionTime")]
    [CqlTag("description", "Returns admission time for an encounter or for immediately prior emergency department visit.")]
    public CqlDateTime hospitalAdmissionTime(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> wzzzzzj_ = this.hospitalization(context, TheEncounter);
        CqlDateTime wzzzzzk_ = context.Operators.Start(wzzzzzj_);

        return wzzzzzk_;
    }


    [CqlExpressionDefinition("Hospital Discharge Time")]
    [CqlTag("description", "Hospital Discharge Time returns the discharge time for an encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalDischargeTime()` instead.")]
    public CqlDateTime Hospital_Discharge_Time(CqlContext context, Encounter TheEncounter)
    {
        Period wzzzzzl_ = TheEncounter?.Period;
        CqlInterval<CqlDateTime> wzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzl_);
        CqlDateTime wzzzzzn_ = context.Operators.End(wzzzzzm_);

        return wzzzzzn_;
    }


    [CqlExpressionDefinition("hospitalDischargeTime")]
    [CqlTag("description", "Hospital Discharge Time returns the discharge time for an encounter")]
    public CqlDateTime hospitalDischargeTime(CqlContext context, Encounter TheEncounter)
    {
        Period wzzzzzo_ = TheEncounter?.Period;
        CqlInterval<CqlDateTime> wzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzo_);
        CqlDateTime wzzzzzq_ = context.Operators.End(wzzzzzp_);

        return wzzzzzq_;
    }


    [CqlExpressionDefinition("Hospital Arrival Time")]
    [CqlTag("description", "Returns earliest arrival time for an encounter including any prior ED visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalArrivalTime()` instead.")]
    public CqlDateTime Hospital_Arrival_Time(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> wzzzzzr_ = this.Hospitalization_Locations(context, TheEncounter);
        object wzzzzzs_(Encounter.LocationComponent @this)
        {
            Period wzzzzzy_ = @this?.Period;
            CqlInterval<CqlDateTime> wzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzy_);
            CqlDateTime xzzzzza_ = context.Operators.Start(wzzzzzz_);

            return xzzzzza_;
        };
        IEnumerable<Encounter.LocationComponent> wzzzzzt_ = context.Operators.SortBy<Encounter.LocationComponent>(wzzzzzr_, wzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent wzzzzzu_ = context.Operators.First<Encounter.LocationComponent>(wzzzzzt_);
        Period wzzzzzv_ = wzzzzzu_?.Period;
        CqlInterval<CqlDateTime> wzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzv_);
        CqlDateTime wzzzzzx_ = context.Operators.Start(wzzzzzw_);

        return wzzzzzx_;
    }


    [CqlExpressionDefinition("hospitalArrivalTime")]
    [CqlTag("description", "Returns earliest arrival time for an encounter including any prior ED visit.")]
    public CqlDateTime hospitalArrivalTime(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> xzzzzzb_ = this.hospitalizationLocations(context, TheEncounter);
        object xzzzzzc_(Encounter.LocationComponent @this)
        {
            Period xzzzzzi_ = @this?.Period;
            CqlInterval<CqlDateTime> xzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzi_);
            CqlDateTime xzzzzzk_ = context.Operators.Start(xzzzzzj_);

            return xzzzzzk_;
        };
        IEnumerable<Encounter.LocationComponent> xzzzzzd_ = context.Operators.SortBy<Encounter.LocationComponent>(xzzzzzb_, xzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent xzzzzze_ = context.Operators.First<Encounter.LocationComponent>(xzzzzzd_);
        Period xzzzzzf_ = xzzzzze_?.Period;
        CqlInterval<CqlDateTime> xzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzf_);
        CqlDateTime xzzzzzh_ = context.Operators.Start(xzzzzzg_);

        return xzzzzzh_;
    }


    [CqlExpressionDefinition("Hospital Departure Time")]
    [CqlTag("description", "Returns the latest departure time for encounter including any prior ED visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalDepartureTime()` instead.")]
    public CqlDateTime Hospital_Departure_Time(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> xzzzzzl_ = this.Hospitalization_Locations(context, TheEncounter);
        object xzzzzzm_(Encounter.LocationComponent @this)
        {
            Period xzzzzzs_ = @this?.Period;
            CqlInterval<CqlDateTime> xzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzs_);
            CqlDateTime xzzzzzu_ = context.Operators.Start(xzzzzzt_);

            return xzzzzzu_;
        };
        IEnumerable<Encounter.LocationComponent> xzzzzzn_ = context.Operators.SortBy<Encounter.LocationComponent>(xzzzzzl_, xzzzzzm_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent xzzzzzo_ = context.Operators.Last<Encounter.LocationComponent>(xzzzzzn_);
        Period xzzzzzp_ = xzzzzzo_?.Period;
        CqlInterval<CqlDateTime> xzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzp_);
        CqlDateTime xzzzzzr_ = context.Operators.End(xzzzzzq_);

        return xzzzzzr_;
    }


    [CqlExpressionDefinition("hospitalDepartureTime")]
    [CqlTag("description", "Returns the latest departure time for encounter including any prior ED visit.")]
    public CqlDateTime hospitalDepartureTime(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> xzzzzzv_ = this.hospitalizationLocations(context, TheEncounter);
        object xzzzzzw_(Encounter.LocationComponent @this)
        {
            Period yzzzzzc_ = @this?.Period;
            CqlInterval<CqlDateTime> yzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzc_);
            CqlDateTime yzzzzze_ = context.Operators.Start(yzzzzzd_);

            return yzzzzze_;
        };
        IEnumerable<Encounter.LocationComponent> xzzzzzx_ = context.Operators.SortBy<Encounter.LocationComponent>(xzzzzzv_, xzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent xzzzzzy_ = context.Operators.Last<Encounter.LocationComponent>(xzzzzzx_);
        Period xzzzzzz_ = xzzzzzy_?.Period;
        CqlInterval<CqlDateTime> yzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzz_);
        CqlDateTime yzzzzzb_ = context.Operators.End(yzzzzza_);

        return yzzzzzb_;
    }


    [CqlExpressionDefinition("GetLocation")]
    [CqlTag("description", "Returns the Location resource specified by the given reference")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getLocation()` instead.")]
    public Location GetLocation(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Location> yzzzzzf_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-location"));
        bool? yzzzzzg_(Location L)
        {
            Id yzzzzzj_ = L?.IdElement;
            string yzzzzzk_ = yzzzzzj_?.Value;
            FhirString yzzzzzl_ = reference?.ReferenceElement;
            string yzzzzzm_ = yzzzzzl_?.Value;
            string yzzzzzn_ = QICoreCommon_2_1_000.Instance.getId(context, yzzzzzm_);
            bool? yzzzzzo_ = context.Operators.Equal(yzzzzzk_, yzzzzzn_);

            return yzzzzzo_;
        };
        IEnumerable<Location> yzzzzzh_ = context.Operators.Where<Location>(yzzzzzf_, yzzzzzg_);
        Location yzzzzzi_ = context.Operators.SingletonFrom<Location>(yzzzzzh_);

        return yzzzzzi_;
    }


    [CqlExpressionDefinition("Emergency Department Arrival Time")]
    [CqlTag("description", "Returns the emergency department arrival time for the encounter.")]
    public CqlDateTime Emergency_Department_Arrival_Time(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> yzzzzzp_ = this.Hospitalization_Locations(context, TheEncounter);
        bool? yzzzzzq_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference yzzzzzw_ = HospitalLocation?.Location;
            Location yzzzzzx_ = this.GetLocation(context, yzzzzzw_);
            List<CodeableConcept> yzzzzzy_ = yzzzzzx_?.Type;
            CqlConcept yzzzzzz_(CodeableConcept @this)
            {
                CqlConcept zzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return zzzzzzd_;
            };
            IEnumerable<CqlConcept> zzzzzza_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)yzzzzzy_, yzzzzzz_);
            CqlValueSet zzzzzzb_ = this.Emergency_Department_Visit(context);
            bool? zzzzzzc_ = context.Operators.ConceptsInValueSet(zzzzzza_, zzzzzzb_);

            return zzzzzzc_;
        };
        IEnumerable<Encounter.LocationComponent> yzzzzzr_ = context.Operators.Where<Encounter.LocationComponent>(yzzzzzp_, yzzzzzq_);
        Encounter.LocationComponent yzzzzzs_ = context.Operators.SingletonFrom<Encounter.LocationComponent>(yzzzzzr_);
        Period yzzzzzt_ = yzzzzzs_?.Period;
        CqlInterval<CqlDateTime> yzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzt_);
        CqlDateTime yzzzzzv_ = context.Operators.Start(yzzzzzu_);

        return yzzzzzv_;
    }


    [CqlExpressionDefinition("emergencyDepartmentArrivalTime")]
    [CqlTag("description", "Returns the emergency department arrival time for the encounter.")]
    public CqlDateTime emergencyDepartmentArrivalTime(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> zzzzzze_ = this.hospitalizationLocations(context, TheEncounter);
        bool? zzzzzzf_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference zzzzzzl_ = HospitalLocation?.Location;
            Location zzzzzzm_ = this.GetLocation(context, zzzzzzl_);
            List<CodeableConcept> zzzzzzn_ = zzzzzzm_?.Type;
            CqlConcept zzzzzzo_(CodeableConcept @this)
            {
                CqlConcept zzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return zzzzzzs_;
            };
            IEnumerable<CqlConcept> zzzzzzp_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)zzzzzzn_, zzzzzzo_);
            CqlValueSet zzzzzzq_ = this.Emergency_Department_Visit(context);
            bool? zzzzzzr_ = context.Operators.ConceptsInValueSet(zzzzzzp_, zzzzzzq_);

            return zzzzzzr_;
        };
        IEnumerable<Encounter.LocationComponent> zzzzzzg_ = context.Operators.Where<Encounter.LocationComponent>(zzzzzze_, zzzzzzf_);
        Encounter.LocationComponent zzzzzzh_ = context.Operators.SingletonFrom<Encounter.LocationComponent>(zzzzzzg_);
        Period zzzzzzi_ = zzzzzzh_?.Period;
        CqlInterval<CqlDateTime> zzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzi_);
        CqlDateTime zzzzzzk_ = context.Operators.Start(zzzzzzj_);

        return zzzzzzk_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservationAndOutpatientSurgeryService")]
    [CqlTag("description", "Hospitalization with Observation and Outpatient Surgery Service returns the total interval from the start of any immediately prior emergency department visit, outpatient surgery visit or observation visit to the discharge of the given encounter.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationWithObservationAndOutpatientSurgeryService()` instead.")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservationAndOutpatientSurgeryService(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] zzzzzzt_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> zzzzzzu_(Encounter Visit)
        {
            CqlValueSet zzzzzzy_ = this.Outpatient_Surgery_Service(context);
            IEnumerable<Encounter> zzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? azzzzzza_(Encounter LastSurgeryOP)
            {
                Period bzzzzzzj_ = LastSurgeryOP?.Period;
                CqlInterval<CqlDateTime> bzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzj_);
                CqlDateTime bzzzzzzl_ = context.Operators.End(bzzzzzzk_);
                CqlValueSet bzzzzzzm_ = this.Emergency_Department_Visit(context);
                IEnumerable<Encounter> bzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? bzzzzzzo_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> ezzzzzzj_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? ezzzzzzk_ = ezzzzzzj_?.Value;
                    Code<Encounter.EncounterStatus> ezzzzzzl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ezzzzzzk_);
                    bool? ezzzzzzm_ = context.Operators.Equal(ezzzzzzl_, "finished");
                    Period ezzzzzzn_ = LastED?.Period;
                    CqlInterval<CqlDateTime> ezzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzn_);
                    CqlDateTime ezzzzzzp_ = context.Operators.End(ezzzzzzo_);
                    CqlValueSet ezzzzzzq_ = this.Observation_Services(context);
                    IEnumerable<Encounter> ezzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? ezzzzzzs_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> gzzzzzzk_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? gzzzzzzl_ = gzzzzzzk_?.Value;
                        Code<Encounter.EncounterStatus> gzzzzzzm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gzzzzzzl_);
                        bool? gzzzzzzn_ = context.Operators.Equal(gzzzzzzm_, "finished");
                        Period gzzzzzzo_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> gzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzo_);
                        CqlDateTime gzzzzzzq_ = context.Operators.End(gzzzzzzp_);
                        Period gzzzzzzr_ = Visit?.Period;
                        CqlInterval<CqlDateTime> gzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzr_);
                        CqlDateTime gzzzzzzt_ = context.Operators.Start(gzzzzzzs_);
                        CqlQuantity gzzzzzzu_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime gzzzzzzv_ = context.Operators.Subtract(gzzzzzzt_, gzzzzzzu_);
                        CqlInterval<CqlDateTime> gzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzr_);
                        CqlDateTime gzzzzzzy_ = context.Operators.Start(gzzzzzzx_);
                        CqlInterval<CqlDateTime> gzzzzzzz_ = context.Operators.Interval(gzzzzzzv_, gzzzzzzy_, true, true);
                        bool? hzzzzzza_ = context.Operators.In<CqlDateTime>(gzzzzzzq_, gzzzzzzz_, default);
                        CqlInterval<CqlDateTime> hzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzr_);
                        CqlDateTime hzzzzzzd_ = context.Operators.Start(hzzzzzzc_);
                        bool? hzzzzzze_ = context.Operators.Not((bool?)(hzzzzzzd_ is null));
                        bool? hzzzzzzf_ = context.Operators.And(hzzzzzza_, hzzzzzze_);
                        bool? hzzzzzzg_ = context.Operators.And(gzzzzzzn_, hzzzzzzf_);

                        return hzzzzzzg_;
                    };
                    IEnumerable<Encounter> ezzzzzzt_ = context.Operators.Where<Encounter>(ezzzzzzr_, ezzzzzzs_);
                    object ezzzzzzu_(Encounter @this)
                    {
                        Period hzzzzzzh_ = @this?.Period;
                        CqlInterval<CqlDateTime> hzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzh_);
                        CqlDateTime hzzzzzzj_ = context.Operators.End(hzzzzzzi_);

                        return hzzzzzzj_;
                    };
                    IEnumerable<Encounter> ezzzzzzv_ = context.Operators.SortBy<Encounter>(ezzzzzzt_, ezzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter ezzzzzzw_ = context.Operators.Last<Encounter>(ezzzzzzv_);
                    Period ezzzzzzx_ = ezzzzzzw_?.Period;
                    CqlInterval<CqlDateTime> ezzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzx_);
                    CqlDateTime ezzzzzzz_ = context.Operators.Start(ezzzzzzy_);
                    Period fzzzzzza_ = Visit?.Period;
                    CqlInterval<CqlDateTime> fzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzza_);
                    CqlDateTime fzzzzzzc_ = context.Operators.Start(fzzzzzzb_);
                    CqlQuantity fzzzzzzd_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime fzzzzzze_ = context.Operators.Subtract(ezzzzzzz_ ?? fzzzzzzc_, fzzzzzzd_);
                    IEnumerable<Encounter> fzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? fzzzzzzh_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> hzzzzzzk_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? hzzzzzzl_ = hzzzzzzk_?.Value;
                        Code<Encounter.EncounterStatus> hzzzzzzm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hzzzzzzl_);
                        bool? hzzzzzzn_ = context.Operators.Equal(hzzzzzzm_, "finished");
                        Period hzzzzzzo_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> hzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzo_);
                        CqlDateTime hzzzzzzq_ = context.Operators.End(hzzzzzzp_);
                        Period hzzzzzzr_ = Visit?.Period;
                        CqlInterval<CqlDateTime> hzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzr_);
                        CqlDateTime hzzzzzzt_ = context.Operators.Start(hzzzzzzs_);
                        CqlQuantity hzzzzzzu_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime hzzzzzzv_ = context.Operators.Subtract(hzzzzzzt_, hzzzzzzu_);
                        CqlInterval<CqlDateTime> hzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzr_);
                        CqlDateTime hzzzzzzy_ = context.Operators.Start(hzzzzzzx_);
                        CqlInterval<CqlDateTime> hzzzzzzz_ = context.Operators.Interval(hzzzzzzv_, hzzzzzzy_, true, true);
                        bool? izzzzzza_ = context.Operators.In<CqlDateTime>(hzzzzzzq_, hzzzzzzz_, default);
                        CqlInterval<CqlDateTime> izzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzr_);
                        CqlDateTime izzzzzzd_ = context.Operators.Start(izzzzzzc_);
                        bool? izzzzzze_ = context.Operators.Not((bool?)(izzzzzzd_ is null));
                        bool? izzzzzzf_ = context.Operators.And(izzzzzza_, izzzzzze_);
                        bool? izzzzzzg_ = context.Operators.And(hzzzzzzn_, izzzzzzf_);

                        return izzzzzzg_;
                    };
                    IEnumerable<Encounter> fzzzzzzi_ = context.Operators.Where<Encounter>(fzzzzzzg_, fzzzzzzh_);
                    object fzzzzzzj_(Encounter @this)
                    {
                        Period izzzzzzh_ = @this?.Period;
                        CqlInterval<CqlDateTime> izzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzh_);
                        CqlDateTime izzzzzzj_ = context.Operators.End(izzzzzzi_);

                        return izzzzzzj_;
                    };
                    IEnumerable<Encounter> fzzzzzzk_ = context.Operators.SortBy<Encounter>(fzzzzzzi_, fzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter fzzzzzzl_ = context.Operators.Last<Encounter>(fzzzzzzk_);
                    Period fzzzzzzm_ = fzzzzzzl_?.Period;
                    CqlInterval<CqlDateTime> fzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzm_);
                    CqlDateTime fzzzzzzo_ = context.Operators.Start(fzzzzzzn_);
                    CqlInterval<CqlDateTime> fzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzza_);
                    CqlDateTime fzzzzzzr_ = context.Operators.Start(fzzzzzzq_);
                    CqlInterval<CqlDateTime> fzzzzzzs_ = context.Operators.Interval(fzzzzzze_, fzzzzzzo_ ?? fzzzzzzr_, true, true);
                    bool? fzzzzzzt_ = context.Operators.In<CqlDateTime>(ezzzzzzp_, fzzzzzzs_, default);
                    IEnumerable<Encounter> fzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? fzzzzzzw_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> izzzzzzk_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? izzzzzzl_ = izzzzzzk_?.Value;
                        Code<Encounter.EncounterStatus> izzzzzzm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(izzzzzzl_);
                        bool? izzzzzzn_ = context.Operators.Equal(izzzzzzm_, "finished");
                        Period izzzzzzo_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> izzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzo_);
                        CqlDateTime izzzzzzq_ = context.Operators.End(izzzzzzp_);
                        Period izzzzzzr_ = Visit?.Period;
                        CqlInterval<CqlDateTime> izzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzr_);
                        CqlDateTime izzzzzzt_ = context.Operators.Start(izzzzzzs_);
                        CqlQuantity izzzzzzu_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime izzzzzzv_ = context.Operators.Subtract(izzzzzzt_, izzzzzzu_);
                        CqlInterval<CqlDateTime> izzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzr_);
                        CqlDateTime izzzzzzy_ = context.Operators.Start(izzzzzzx_);
                        CqlInterval<CqlDateTime> izzzzzzz_ = context.Operators.Interval(izzzzzzv_, izzzzzzy_, true, true);
                        bool? jzzzzzza_ = context.Operators.In<CqlDateTime>(izzzzzzq_, izzzzzzz_, default);
                        CqlInterval<CqlDateTime> jzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzr_);
                        CqlDateTime jzzzzzzd_ = context.Operators.Start(jzzzzzzc_);
                        bool? jzzzzzze_ = context.Operators.Not((bool?)(jzzzzzzd_ is null));
                        bool? jzzzzzzf_ = context.Operators.And(jzzzzzza_, jzzzzzze_);
                        bool? jzzzzzzg_ = context.Operators.And(izzzzzzn_, jzzzzzzf_);

                        return jzzzzzzg_;
                    };
                    IEnumerable<Encounter> fzzzzzzx_ = context.Operators.Where<Encounter>(fzzzzzzv_, fzzzzzzw_);
                    object fzzzzzzy_(Encounter @this)
                    {
                        Period jzzzzzzh_ = @this?.Period;
                        CqlInterval<CqlDateTime> jzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzh_);
                        CqlDateTime jzzzzzzj_ = context.Operators.End(jzzzzzzi_);

                        return jzzzzzzj_;
                    };
                    IEnumerable<Encounter> fzzzzzzz_ = context.Operators.SortBy<Encounter>(fzzzzzzx_, fzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter gzzzzzza_ = context.Operators.Last<Encounter>(fzzzzzzz_);
                    Period gzzzzzzb_ = gzzzzzza_?.Period;
                    CqlInterval<CqlDateTime> gzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzb_);
                    CqlDateTime gzzzzzzd_ = context.Operators.Start(gzzzzzzc_);
                    CqlInterval<CqlDateTime> gzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzza_);
                    CqlDateTime gzzzzzzg_ = context.Operators.Start(gzzzzzzf_);
                    bool? gzzzzzzh_ = context.Operators.Not((bool?)((gzzzzzzd_ ?? gzzzzzzg_) is null));
                    bool? gzzzzzzi_ = context.Operators.And(fzzzzzzt_, gzzzzzzh_);
                    bool? gzzzzzzj_ = context.Operators.And(ezzzzzzm_, gzzzzzzi_);

                    return gzzzzzzj_;
                };
                IEnumerable<Encounter> bzzzzzzp_ = context.Operators.Where<Encounter>(bzzzzzzn_, bzzzzzzo_);
                object bzzzzzzq_(Encounter @this)
                {
                    Period jzzzzzzk_ = @this?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzk_);
                    CqlDateTime jzzzzzzm_ = context.Operators.End(jzzzzzzl_);

                    return jzzzzzzm_;
                };
                IEnumerable<Encounter> bzzzzzzr_ = context.Operators.SortBy<Encounter>(bzzzzzzp_, bzzzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bzzzzzzs_ = context.Operators.Last<Encounter>(bzzzzzzr_);
                Period bzzzzzzt_ = bzzzzzzs_?.Period;
                CqlInterval<CqlDateTime> bzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzt_);
                CqlDateTime bzzzzzzv_ = context.Operators.Start(bzzzzzzu_);
                CqlValueSet bzzzzzzw_ = this.Observation_Services(context);
                IEnumerable<Encounter> bzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? bzzzzzzy_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> jzzzzzzn_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? jzzzzzzo_ = jzzzzzzn_?.Value;
                    Code<Encounter.EncounterStatus> jzzzzzzp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jzzzzzzo_);
                    bool? jzzzzzzq_ = context.Operators.Equal(jzzzzzzp_, "finished");
                    Period jzzzzzzr_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzr_);
                    CqlDateTime jzzzzzzt_ = context.Operators.End(jzzzzzzs_);
                    Period jzzzzzzu_ = Visit?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzu_);
                    CqlDateTime jzzzzzzw_ = context.Operators.Start(jzzzzzzv_);
                    CqlQuantity jzzzzzzx_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime jzzzzzzy_ = context.Operators.Subtract(jzzzzzzw_, jzzzzzzx_);
                    CqlInterval<CqlDateTime> kzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzu_);
                    CqlDateTime kzzzzzzb_ = context.Operators.Start(kzzzzzza_);
                    CqlInterval<CqlDateTime> kzzzzzzc_ = context.Operators.Interval(jzzzzzzy_, kzzzzzzb_, true, true);
                    bool? kzzzzzzd_ = context.Operators.In<CqlDateTime>(jzzzzzzt_, kzzzzzzc_, default);
                    CqlInterval<CqlDateTime> kzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzu_);
                    CqlDateTime kzzzzzzg_ = context.Operators.Start(kzzzzzzf_);
                    bool? kzzzzzzh_ = context.Operators.Not((bool?)(kzzzzzzg_ is null));
                    bool? kzzzzzzi_ = context.Operators.And(kzzzzzzd_, kzzzzzzh_);
                    bool? kzzzzzzj_ = context.Operators.And(jzzzzzzq_, kzzzzzzi_);

                    return kzzzzzzj_;
                };
                IEnumerable<Encounter> bzzzzzzz_ = context.Operators.Where<Encounter>(bzzzzzzx_, bzzzzzzy_);
                object czzzzzza_(Encounter @this)
                {
                    Period kzzzzzzk_ = @this?.Period;
                    CqlInterval<CqlDateTime> kzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzk_);
                    CqlDateTime kzzzzzzm_ = context.Operators.End(kzzzzzzl_);

                    return kzzzzzzm_;
                };
                IEnumerable<Encounter> czzzzzzb_ = context.Operators.SortBy<Encounter>(bzzzzzzz_, czzzzzza_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter czzzzzzc_ = context.Operators.Last<Encounter>(czzzzzzb_);
                Period czzzzzzd_ = czzzzzzc_?.Period;
                CqlInterval<CqlDateTime> czzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzd_);
                CqlDateTime czzzzzzf_ = context.Operators.Start(czzzzzze_);
                Period czzzzzzg_ = Visit?.Period;
                CqlInterval<CqlDateTime> czzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzg_);
                CqlDateTime czzzzzzi_ = context.Operators.Start(czzzzzzh_);
                CqlQuantity czzzzzzj_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime czzzzzzk_ = context.Operators.Subtract(bzzzzzzv_ ?? czzzzzzf_ ?? czzzzzzi_, czzzzzzj_);
                IEnumerable<Encounter> czzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? czzzzzzn_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> kzzzzzzn_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? kzzzzzzo_ = kzzzzzzn_?.Value;
                    Code<Encounter.EncounterStatus> kzzzzzzp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(kzzzzzzo_);
                    bool? kzzzzzzq_ = context.Operators.Equal(kzzzzzzp_, "finished");
                    Period kzzzzzzr_ = LastED?.Period;
                    CqlInterval<CqlDateTime> kzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzr_);
                    CqlDateTime kzzzzzzt_ = context.Operators.End(kzzzzzzs_);
                    CqlValueSet kzzzzzzu_ = this.Observation_Services(context);
                    IEnumerable<Encounter> kzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? kzzzzzzw_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> mzzzzzzo_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? mzzzzzzp_ = mzzzzzzo_?.Value;
                        Code<Encounter.EncounterStatus> mzzzzzzq_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(mzzzzzzp_);
                        bool? mzzzzzzr_ = context.Operators.Equal(mzzzzzzq_, "finished");
                        Period mzzzzzzs_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> mzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzs_);
                        CqlDateTime mzzzzzzu_ = context.Operators.End(mzzzzzzt_);
                        Period mzzzzzzv_ = Visit?.Period;
                        CqlInterval<CqlDateTime> mzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzv_);
                        CqlDateTime mzzzzzzx_ = context.Operators.Start(mzzzzzzw_);
                        CqlQuantity mzzzzzzy_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime mzzzzzzz_ = context.Operators.Subtract(mzzzzzzx_, mzzzzzzy_);
                        CqlInterval<CqlDateTime> nzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzv_);
                        CqlDateTime nzzzzzzc_ = context.Operators.Start(nzzzzzzb_);
                        CqlInterval<CqlDateTime> nzzzzzzd_ = context.Operators.Interval(mzzzzzzz_, nzzzzzzc_, true, true);
                        bool? nzzzzzze_ = context.Operators.In<CqlDateTime>(mzzzzzzu_, nzzzzzzd_, default);
                        CqlInterval<CqlDateTime> nzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzv_);
                        CqlDateTime nzzzzzzh_ = context.Operators.Start(nzzzzzzg_);
                        bool? nzzzzzzi_ = context.Operators.Not((bool?)(nzzzzzzh_ is null));
                        bool? nzzzzzzj_ = context.Operators.And(nzzzzzze_, nzzzzzzi_);
                        bool? nzzzzzzk_ = context.Operators.And(mzzzzzzr_, nzzzzzzj_);

                        return nzzzzzzk_;
                    };
                    IEnumerable<Encounter> kzzzzzzx_ = context.Operators.Where<Encounter>(kzzzzzzv_, kzzzzzzw_);
                    object kzzzzzzy_(Encounter @this)
                    {
                        Period nzzzzzzl_ = @this?.Period;
                        CqlInterval<CqlDateTime> nzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzl_);
                        CqlDateTime nzzzzzzn_ = context.Operators.End(nzzzzzzm_);

                        return nzzzzzzn_;
                    };
                    IEnumerable<Encounter> kzzzzzzz_ = context.Operators.SortBy<Encounter>(kzzzzzzx_, kzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter lzzzzzza_ = context.Operators.Last<Encounter>(kzzzzzzz_);
                    Period lzzzzzzb_ = lzzzzzza_?.Period;
                    CqlInterval<CqlDateTime> lzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzb_);
                    CqlDateTime lzzzzzzd_ = context.Operators.Start(lzzzzzzc_);
                    Period lzzzzzze_ = Visit?.Period;
                    CqlInterval<CqlDateTime> lzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzze_);
                    CqlDateTime lzzzzzzg_ = context.Operators.Start(lzzzzzzf_);
                    CqlQuantity lzzzzzzh_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime lzzzzzzi_ = context.Operators.Subtract(lzzzzzzd_ ?? lzzzzzzg_, lzzzzzzh_);
                    IEnumerable<Encounter> lzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? lzzzzzzl_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> nzzzzzzo_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? nzzzzzzp_ = nzzzzzzo_?.Value;
                        Code<Encounter.EncounterStatus> nzzzzzzq_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(nzzzzzzp_);
                        bool? nzzzzzzr_ = context.Operators.Equal(nzzzzzzq_, "finished");
                        Period nzzzzzzs_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> nzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzs_);
                        CqlDateTime nzzzzzzu_ = context.Operators.End(nzzzzzzt_);
                        Period nzzzzzzv_ = Visit?.Period;
                        CqlInterval<CqlDateTime> nzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzv_);
                        CqlDateTime nzzzzzzx_ = context.Operators.Start(nzzzzzzw_);
                        CqlQuantity nzzzzzzy_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime nzzzzzzz_ = context.Operators.Subtract(nzzzzzzx_, nzzzzzzy_);
                        CqlInterval<CqlDateTime> ozzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzv_);
                        CqlDateTime ozzzzzzc_ = context.Operators.Start(ozzzzzzb_);
                        CqlInterval<CqlDateTime> ozzzzzzd_ = context.Operators.Interval(nzzzzzzz_, ozzzzzzc_, true, true);
                        bool? ozzzzzze_ = context.Operators.In<CqlDateTime>(nzzzzzzu_, ozzzzzzd_, default);
                        CqlInterval<CqlDateTime> ozzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzv_);
                        CqlDateTime ozzzzzzh_ = context.Operators.Start(ozzzzzzg_);
                        bool? ozzzzzzi_ = context.Operators.Not((bool?)(ozzzzzzh_ is null));
                        bool? ozzzzzzj_ = context.Operators.And(ozzzzzze_, ozzzzzzi_);
                        bool? ozzzzzzk_ = context.Operators.And(nzzzzzzr_, ozzzzzzj_);

                        return ozzzzzzk_;
                    };
                    IEnumerable<Encounter> lzzzzzzm_ = context.Operators.Where<Encounter>(lzzzzzzk_, lzzzzzzl_);
                    object lzzzzzzn_(Encounter @this)
                    {
                        Period ozzzzzzl_ = @this?.Period;
                        CqlInterval<CqlDateTime> ozzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzl_);
                        CqlDateTime ozzzzzzn_ = context.Operators.End(ozzzzzzm_);

                        return ozzzzzzn_;
                    };
                    IEnumerable<Encounter> lzzzzzzo_ = context.Operators.SortBy<Encounter>(lzzzzzzm_, lzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter lzzzzzzp_ = context.Operators.Last<Encounter>(lzzzzzzo_);
                    Period lzzzzzzq_ = lzzzzzzp_?.Period;
                    CqlInterval<CqlDateTime> lzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzq_);
                    CqlDateTime lzzzzzzs_ = context.Operators.Start(lzzzzzzr_);
                    CqlInterval<CqlDateTime> lzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzze_);
                    CqlDateTime lzzzzzzv_ = context.Operators.Start(lzzzzzzu_);
                    CqlInterval<CqlDateTime> lzzzzzzw_ = context.Operators.Interval(lzzzzzzi_, lzzzzzzs_ ?? lzzzzzzv_, true, true);
                    bool? lzzzzzzx_ = context.Operators.In<CqlDateTime>(kzzzzzzt_, lzzzzzzw_, default);
                    IEnumerable<Encounter> lzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? mzzzzzza_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> ozzzzzzo_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? ozzzzzzp_ = ozzzzzzo_?.Value;
                        Code<Encounter.EncounterStatus> ozzzzzzq_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ozzzzzzp_);
                        bool? ozzzzzzr_ = context.Operators.Equal(ozzzzzzq_, "finished");
                        Period ozzzzzzs_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> ozzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzs_);
                        CqlDateTime ozzzzzzu_ = context.Operators.End(ozzzzzzt_);
                        Period ozzzzzzv_ = Visit?.Period;
                        CqlInterval<CqlDateTime> ozzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzv_);
                        CqlDateTime ozzzzzzx_ = context.Operators.Start(ozzzzzzw_);
                        CqlQuantity ozzzzzzy_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime ozzzzzzz_ = context.Operators.Subtract(ozzzzzzx_, ozzzzzzy_);
                        CqlInterval<CqlDateTime> pzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzv_);
                        CqlDateTime pzzzzzzc_ = context.Operators.Start(pzzzzzzb_);
                        CqlInterval<CqlDateTime> pzzzzzzd_ = context.Operators.Interval(ozzzzzzz_, pzzzzzzc_, true, true);
                        bool? pzzzzzze_ = context.Operators.In<CqlDateTime>(ozzzzzzu_, pzzzzzzd_, default);
                        CqlInterval<CqlDateTime> pzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzv_);
                        CqlDateTime pzzzzzzh_ = context.Operators.Start(pzzzzzzg_);
                        bool? pzzzzzzi_ = context.Operators.Not((bool?)(pzzzzzzh_ is null));
                        bool? pzzzzzzj_ = context.Operators.And(pzzzzzze_, pzzzzzzi_);
                        bool? pzzzzzzk_ = context.Operators.And(ozzzzzzr_, pzzzzzzj_);

                        return pzzzzzzk_;
                    };
                    IEnumerable<Encounter> mzzzzzzb_ = context.Operators.Where<Encounter>(lzzzzzzz_, mzzzzzza_);
                    object mzzzzzzc_(Encounter @this)
                    {
                        Period pzzzzzzl_ = @this?.Period;
                        CqlInterval<CqlDateTime> pzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzl_);
                        CqlDateTime pzzzzzzn_ = context.Operators.End(pzzzzzzm_);

                        return pzzzzzzn_;
                    };
                    IEnumerable<Encounter> mzzzzzzd_ = context.Operators.SortBy<Encounter>(mzzzzzzb_, mzzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter mzzzzzze_ = context.Operators.Last<Encounter>(mzzzzzzd_);
                    Period mzzzzzzf_ = mzzzzzze_?.Period;
                    CqlInterval<CqlDateTime> mzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzf_);
                    CqlDateTime mzzzzzzh_ = context.Operators.Start(mzzzzzzg_);
                    CqlInterval<CqlDateTime> mzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzze_);
                    CqlDateTime mzzzzzzk_ = context.Operators.Start(mzzzzzzj_);
                    bool? mzzzzzzl_ = context.Operators.Not((bool?)((mzzzzzzh_ ?? mzzzzzzk_) is null));
                    bool? mzzzzzzm_ = context.Operators.And(lzzzzzzx_, mzzzzzzl_);
                    bool? mzzzzzzn_ = context.Operators.And(kzzzzzzq_, mzzzzzzm_);

                    return mzzzzzzn_;
                };
                IEnumerable<Encounter> czzzzzzo_ = context.Operators.Where<Encounter>(czzzzzzm_, czzzzzzn_);
                object czzzzzzp_(Encounter @this)
                {
                    Period pzzzzzzo_ = @this?.Period;
                    CqlInterval<CqlDateTime> pzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzo_);
                    CqlDateTime pzzzzzzq_ = context.Operators.End(pzzzzzzp_);

                    return pzzzzzzq_;
                };
                IEnumerable<Encounter> czzzzzzq_ = context.Operators.SortBy<Encounter>(czzzzzzo_, czzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter czzzzzzr_ = context.Operators.Last<Encounter>(czzzzzzq_);
                Period czzzzzzs_ = czzzzzzr_?.Period;
                CqlInterval<CqlDateTime> czzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzs_);
                CqlDateTime czzzzzzu_ = context.Operators.Start(czzzzzzt_);
                IEnumerable<Encounter> czzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? czzzzzzx_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> pzzzzzzr_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? pzzzzzzs_ = pzzzzzzr_?.Value;
                    Code<Encounter.EncounterStatus> pzzzzzzt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pzzzzzzs_);
                    bool? pzzzzzzu_ = context.Operators.Equal(pzzzzzzt_, "finished");
                    Period pzzzzzzv_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> pzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzv_);
                    CqlDateTime pzzzzzzx_ = context.Operators.End(pzzzzzzw_);
                    Period pzzzzzzy_ = Visit?.Period;
                    CqlInterval<CqlDateTime> pzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzy_);
                    CqlDateTime qzzzzzza_ = context.Operators.Start(pzzzzzzz_);
                    CqlQuantity qzzzzzzb_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime qzzzzzzc_ = context.Operators.Subtract(qzzzzzza_, qzzzzzzb_);
                    CqlInterval<CqlDateTime> qzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzy_);
                    CqlDateTime qzzzzzzf_ = context.Operators.Start(qzzzzzze_);
                    CqlInterval<CqlDateTime> qzzzzzzg_ = context.Operators.Interval(qzzzzzzc_, qzzzzzzf_, true, true);
                    bool? qzzzzzzh_ = context.Operators.In<CqlDateTime>(pzzzzzzx_, qzzzzzzg_, default);
                    CqlInterval<CqlDateTime> qzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzy_);
                    CqlDateTime qzzzzzzk_ = context.Operators.Start(qzzzzzzj_);
                    bool? qzzzzzzl_ = context.Operators.Not((bool?)(qzzzzzzk_ is null));
                    bool? qzzzzzzm_ = context.Operators.And(qzzzzzzh_, qzzzzzzl_);
                    bool? qzzzzzzn_ = context.Operators.And(pzzzzzzu_, qzzzzzzm_);

                    return qzzzzzzn_;
                };
                IEnumerable<Encounter> czzzzzzy_ = context.Operators.Where<Encounter>(czzzzzzw_, czzzzzzx_);
                object czzzzzzz_(Encounter @this)
                {
                    Period qzzzzzzo_ = @this?.Period;
                    CqlInterval<CqlDateTime> qzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzo_);
                    CqlDateTime qzzzzzzq_ = context.Operators.End(qzzzzzzp_);

                    return qzzzzzzq_;
                };
                IEnumerable<Encounter> dzzzzzza_ = context.Operators.SortBy<Encounter>(czzzzzzy_, czzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter dzzzzzzb_ = context.Operators.Last<Encounter>(dzzzzzza_);
                Period dzzzzzzc_ = dzzzzzzb_?.Period;
                CqlInterval<CqlDateTime> dzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzc_);
                CqlDateTime dzzzzzze_ = context.Operators.Start(dzzzzzzd_);
                CqlInterval<CqlDateTime> dzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzg_);
                CqlDateTime dzzzzzzh_ = context.Operators.Start(dzzzzzzg_);
                CqlInterval<CqlDateTime> dzzzzzzi_ = context.Operators.Interval(czzzzzzk_, czzzzzzu_ ?? dzzzzzze_ ?? dzzzzzzh_, true, true);
                bool? dzzzzzzj_ = context.Operators.In<CqlDateTime>(bzzzzzzl_, dzzzzzzi_, default);
                IEnumerable<Encounter> dzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? dzzzzzzm_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> qzzzzzzr_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? qzzzzzzs_ = qzzzzzzr_?.Value;
                    Code<Encounter.EncounterStatus> qzzzzzzt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(qzzzzzzs_);
                    bool? qzzzzzzu_ = context.Operators.Equal(qzzzzzzt_, "finished");
                    Period qzzzzzzv_ = LastED?.Period;
                    CqlInterval<CqlDateTime> qzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzv_);
                    CqlDateTime qzzzzzzx_ = context.Operators.End(qzzzzzzw_);
                    CqlValueSet qzzzzzzy_ = this.Observation_Services(context);
                    IEnumerable<Encounter> qzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? rzzzzzza_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> szzzzzzs_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? szzzzzzt_ = szzzzzzs_?.Value;
                        Code<Encounter.EncounterStatus> szzzzzzu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(szzzzzzt_);
                        bool? szzzzzzv_ = context.Operators.Equal(szzzzzzu_, "finished");
                        Period szzzzzzw_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> szzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzw_);
                        CqlDateTime szzzzzzy_ = context.Operators.End(szzzzzzx_);
                        Period szzzzzzz_ = Visit?.Period;
                        CqlInterval<CqlDateTime> tzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzz_);
                        CqlDateTime tzzzzzzb_ = context.Operators.Start(tzzzzzza_);
                        CqlQuantity tzzzzzzc_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime tzzzzzzd_ = context.Operators.Subtract(tzzzzzzb_, tzzzzzzc_);
                        CqlInterval<CqlDateTime> tzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzz_);
                        CqlDateTime tzzzzzzg_ = context.Operators.Start(tzzzzzzf_);
                        CqlInterval<CqlDateTime> tzzzzzzh_ = context.Operators.Interval(tzzzzzzd_, tzzzzzzg_, true, true);
                        bool? tzzzzzzi_ = context.Operators.In<CqlDateTime>(szzzzzzy_, tzzzzzzh_, default);
                        CqlInterval<CqlDateTime> tzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzz_);
                        CqlDateTime tzzzzzzl_ = context.Operators.Start(tzzzzzzk_);
                        bool? tzzzzzzm_ = context.Operators.Not((bool?)(tzzzzzzl_ is null));
                        bool? tzzzzzzn_ = context.Operators.And(tzzzzzzi_, tzzzzzzm_);
                        bool? tzzzzzzo_ = context.Operators.And(szzzzzzv_, tzzzzzzn_);

                        return tzzzzzzo_;
                    };
                    IEnumerable<Encounter> rzzzzzzb_ = context.Operators.Where<Encounter>(qzzzzzzz_, rzzzzzza_);
                    object rzzzzzzc_(Encounter @this)
                    {
                        Period tzzzzzzp_ = @this?.Period;
                        CqlInterval<CqlDateTime> tzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzp_);
                        CqlDateTime tzzzzzzr_ = context.Operators.End(tzzzzzzq_);

                        return tzzzzzzr_;
                    };
                    IEnumerable<Encounter> rzzzzzzd_ = context.Operators.SortBy<Encounter>(rzzzzzzb_, rzzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter rzzzzzze_ = context.Operators.Last<Encounter>(rzzzzzzd_);
                    Period rzzzzzzf_ = rzzzzzze_?.Period;
                    CqlInterval<CqlDateTime> rzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzf_);
                    CqlDateTime rzzzzzzh_ = context.Operators.Start(rzzzzzzg_);
                    Period rzzzzzzi_ = Visit?.Period;
                    CqlInterval<CqlDateTime> rzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzi_);
                    CqlDateTime rzzzzzzk_ = context.Operators.Start(rzzzzzzj_);
                    CqlQuantity rzzzzzzl_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime rzzzzzzm_ = context.Operators.Subtract(rzzzzzzh_ ?? rzzzzzzk_, rzzzzzzl_);
                    IEnumerable<Encounter> rzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? rzzzzzzp_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> tzzzzzzs_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? tzzzzzzt_ = tzzzzzzs_?.Value;
                        Code<Encounter.EncounterStatus> tzzzzzzu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(tzzzzzzt_);
                        bool? tzzzzzzv_ = context.Operators.Equal(tzzzzzzu_, "finished");
                        Period tzzzzzzw_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> tzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzw_);
                        CqlDateTime tzzzzzzy_ = context.Operators.End(tzzzzzzx_);
                        Period tzzzzzzz_ = Visit?.Period;
                        CqlInterval<CqlDateTime> uzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzz_);
                        CqlDateTime uzzzzzzb_ = context.Operators.Start(uzzzzzza_);
                        CqlQuantity uzzzzzzc_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime uzzzzzzd_ = context.Operators.Subtract(uzzzzzzb_, uzzzzzzc_);
                        CqlInterval<CqlDateTime> uzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzz_);
                        CqlDateTime uzzzzzzg_ = context.Operators.Start(uzzzzzzf_);
                        CqlInterval<CqlDateTime> uzzzzzzh_ = context.Operators.Interval(uzzzzzzd_, uzzzzzzg_, true, true);
                        bool? uzzzzzzi_ = context.Operators.In<CqlDateTime>(tzzzzzzy_, uzzzzzzh_, default);
                        CqlInterval<CqlDateTime> uzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzz_);
                        CqlDateTime uzzzzzzl_ = context.Operators.Start(uzzzzzzk_);
                        bool? uzzzzzzm_ = context.Operators.Not((bool?)(uzzzzzzl_ is null));
                        bool? uzzzzzzn_ = context.Operators.And(uzzzzzzi_, uzzzzzzm_);
                        bool? uzzzzzzo_ = context.Operators.And(tzzzzzzv_, uzzzzzzn_);

                        return uzzzzzzo_;
                    };
                    IEnumerable<Encounter> rzzzzzzq_ = context.Operators.Where<Encounter>(rzzzzzzo_, rzzzzzzp_);
                    object rzzzzzzr_(Encounter @this)
                    {
                        Period uzzzzzzp_ = @this?.Period;
                        CqlInterval<CqlDateTime> uzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzp_);
                        CqlDateTime uzzzzzzr_ = context.Operators.End(uzzzzzzq_);

                        return uzzzzzzr_;
                    };
                    IEnumerable<Encounter> rzzzzzzs_ = context.Operators.SortBy<Encounter>(rzzzzzzq_, rzzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter rzzzzzzt_ = context.Operators.Last<Encounter>(rzzzzzzs_);
                    Period rzzzzzzu_ = rzzzzzzt_?.Period;
                    CqlInterval<CqlDateTime> rzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzu_);
                    CqlDateTime rzzzzzzw_ = context.Operators.Start(rzzzzzzv_);
                    CqlInterval<CqlDateTime> rzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzi_);
                    CqlDateTime rzzzzzzz_ = context.Operators.Start(rzzzzzzy_);
                    CqlInterval<CqlDateTime> szzzzzza_ = context.Operators.Interval(rzzzzzzm_, rzzzzzzw_ ?? rzzzzzzz_, true, true);
                    bool? szzzzzzb_ = context.Operators.In<CqlDateTime>(qzzzzzzx_, szzzzzza_, default);
                    IEnumerable<Encounter> szzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? szzzzzze_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> uzzzzzzs_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? uzzzzzzt_ = uzzzzzzs_?.Value;
                        Code<Encounter.EncounterStatus> uzzzzzzu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(uzzzzzzt_);
                        bool? uzzzzzzv_ = context.Operators.Equal(uzzzzzzu_, "finished");
                        Period uzzzzzzw_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> uzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzw_);
                        CqlDateTime uzzzzzzy_ = context.Operators.End(uzzzzzzx_);
                        Period uzzzzzzz_ = Visit?.Period;
                        CqlInterval<CqlDateTime> vzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzz_);
                        CqlDateTime vzzzzzzb_ = context.Operators.Start(vzzzzzza_);
                        CqlQuantity vzzzzzzc_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime vzzzzzzd_ = context.Operators.Subtract(vzzzzzzb_, vzzzzzzc_);
                        CqlInterval<CqlDateTime> vzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzz_);
                        CqlDateTime vzzzzzzg_ = context.Operators.Start(vzzzzzzf_);
                        CqlInterval<CqlDateTime> vzzzzzzh_ = context.Operators.Interval(vzzzzzzd_, vzzzzzzg_, true, true);
                        bool? vzzzzzzi_ = context.Operators.In<CqlDateTime>(uzzzzzzy_, vzzzzzzh_, default);
                        CqlInterval<CqlDateTime> vzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzz_);
                        CqlDateTime vzzzzzzl_ = context.Operators.Start(vzzzzzzk_);
                        bool? vzzzzzzm_ = context.Operators.Not((bool?)(vzzzzzzl_ is null));
                        bool? vzzzzzzn_ = context.Operators.And(vzzzzzzi_, vzzzzzzm_);
                        bool? vzzzzzzo_ = context.Operators.And(uzzzzzzv_, vzzzzzzn_);

                        return vzzzzzzo_;
                    };
                    IEnumerable<Encounter> szzzzzzf_ = context.Operators.Where<Encounter>(szzzzzzd_, szzzzzze_);
                    object szzzzzzg_(Encounter @this)
                    {
                        Period vzzzzzzp_ = @this?.Period;
                        CqlInterval<CqlDateTime> vzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzp_);
                        CqlDateTime vzzzzzzr_ = context.Operators.End(vzzzzzzq_);

                        return vzzzzzzr_;
                    };
                    IEnumerable<Encounter> szzzzzzh_ = context.Operators.SortBy<Encounter>(szzzzzzf_, szzzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter szzzzzzi_ = context.Operators.Last<Encounter>(szzzzzzh_);
                    Period szzzzzzj_ = szzzzzzi_?.Period;
                    CqlInterval<CqlDateTime> szzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzj_);
                    CqlDateTime szzzzzzl_ = context.Operators.Start(szzzzzzk_);
                    CqlInterval<CqlDateTime> szzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzi_);
                    CqlDateTime szzzzzzo_ = context.Operators.Start(szzzzzzn_);
                    bool? szzzzzzp_ = context.Operators.Not((bool?)((szzzzzzl_ ?? szzzzzzo_) is null));
                    bool? szzzzzzq_ = context.Operators.And(szzzzzzb_, szzzzzzp_);
                    bool? szzzzzzr_ = context.Operators.And(qzzzzzzu_, szzzzzzq_);

                    return szzzzzzr_;
                };
                IEnumerable<Encounter> dzzzzzzn_ = context.Operators.Where<Encounter>(dzzzzzzl_, dzzzzzzm_);
                object dzzzzzzo_(Encounter @this)
                {
                    Period vzzzzzzs_ = @this?.Period;
                    CqlInterval<CqlDateTime> vzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzs_);
                    CqlDateTime vzzzzzzu_ = context.Operators.End(vzzzzzzt_);

                    return vzzzzzzu_;
                };
                IEnumerable<Encounter> dzzzzzzp_ = context.Operators.SortBy<Encounter>(dzzzzzzn_, dzzzzzzo_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter dzzzzzzq_ = context.Operators.Last<Encounter>(dzzzzzzp_);
                Period dzzzzzzr_ = dzzzzzzq_?.Period;
                CqlInterval<CqlDateTime> dzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzr_);
                CqlDateTime dzzzzzzt_ = context.Operators.Start(dzzzzzzs_);
                IEnumerable<Encounter> dzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? dzzzzzzw_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> vzzzzzzv_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? vzzzzzzw_ = vzzzzzzv_?.Value;
                    Code<Encounter.EncounterStatus> vzzzzzzx_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(vzzzzzzw_);
                    bool? vzzzzzzy_ = context.Operators.Equal(vzzzzzzx_, "finished");
                    Period vzzzzzzz_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> wzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzz_);
                    CqlDateTime wzzzzzzb_ = context.Operators.End(wzzzzzza_);
                    Period wzzzzzzc_ = Visit?.Period;
                    CqlInterval<CqlDateTime> wzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzc_);
                    CqlDateTime wzzzzzze_ = context.Operators.Start(wzzzzzzd_);
                    CqlQuantity wzzzzzzf_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime wzzzzzzg_ = context.Operators.Subtract(wzzzzzze_, wzzzzzzf_);
                    CqlInterval<CqlDateTime> wzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzc_);
                    CqlDateTime wzzzzzzj_ = context.Operators.Start(wzzzzzzi_);
                    CqlInterval<CqlDateTime> wzzzzzzk_ = context.Operators.Interval(wzzzzzzg_, wzzzzzzj_, true, true);
                    bool? wzzzzzzl_ = context.Operators.In<CqlDateTime>(wzzzzzzb_, wzzzzzzk_, default);
                    CqlInterval<CqlDateTime> wzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzc_);
                    CqlDateTime wzzzzzzo_ = context.Operators.Start(wzzzzzzn_);
                    bool? wzzzzzzp_ = context.Operators.Not((bool?)(wzzzzzzo_ is null));
                    bool? wzzzzzzq_ = context.Operators.And(wzzzzzzl_, wzzzzzzp_);
                    bool? wzzzzzzr_ = context.Operators.And(vzzzzzzy_, wzzzzzzq_);

                    return wzzzzzzr_;
                };
                IEnumerable<Encounter> dzzzzzzx_ = context.Operators.Where<Encounter>(dzzzzzzv_, dzzzzzzw_);
                object dzzzzzzy_(Encounter @this)
                {
                    Period wzzzzzzs_ = @this?.Period;
                    CqlInterval<CqlDateTime> wzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzs_);
                    CqlDateTime wzzzzzzu_ = context.Operators.End(wzzzzzzt_);

                    return wzzzzzzu_;
                };
                IEnumerable<Encounter> dzzzzzzz_ = context.Operators.SortBy<Encounter>(dzzzzzzx_, dzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter ezzzzzza_ = context.Operators.Last<Encounter>(dzzzzzzz_);
                Period ezzzzzzb_ = ezzzzzza_?.Period;
                CqlInterval<CqlDateTime> ezzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzb_);
                CqlDateTime ezzzzzzd_ = context.Operators.Start(ezzzzzzc_);
                CqlInterval<CqlDateTime> ezzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzg_);
                CqlDateTime ezzzzzzg_ = context.Operators.Start(ezzzzzzf_);
                bool? ezzzzzzh_ = context.Operators.Not((bool?)((dzzzzzzt_ ?? ezzzzzzd_ ?? ezzzzzzg_) is null));
                bool? ezzzzzzi_ = context.Operators.And(dzzzzzzj_, ezzzzzzh_);

                return ezzzzzzi_;
            };
            IEnumerable<Encounter> azzzzzzb_ = context.Operators.Where<Encounter>(zzzzzzz_, azzzzzza_);
            object azzzzzzc_(Encounter @this)
            {
                Period wzzzzzzv_ = @this?.Period;
                CqlInterval<CqlDateTime> wzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzv_);
                CqlDateTime wzzzzzzx_ = context.Operators.End(wzzzzzzw_);

                return wzzzzzzx_;
            };
            IEnumerable<Encounter> azzzzzzd_ = context.Operators.SortBy<Encounter>(azzzzzzb_, azzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter azzzzzze_ = context.Operators.Last<Encounter>(azzzzzzd_);
            Period azzzzzzf_ = azzzzzze_?.Period;
            CqlInterval<CqlDateTime> azzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzf_);
            CqlDateTime azzzzzzh_ = context.Operators.Start(azzzzzzg_);
            CqlValueSet azzzzzzi_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> azzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? azzzzzzk_(Encounter LastED)
            {
                Code<Encounter.EncounterStatus> wzzzzzzy_ = LastED?.StatusElement;
                Encounter.EncounterStatus? wzzzzzzz_ = wzzzzzzy_?.Value;
                Code<Encounter.EncounterStatus> xzzzzzza_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(wzzzzzzz_);
                bool? xzzzzzzb_ = context.Operators.Equal(xzzzzzza_, "finished");
                Period xzzzzzzc_ = LastED?.Period;
                CqlInterval<CqlDateTime> xzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzc_);
                CqlDateTime xzzzzzze_ = context.Operators.End(xzzzzzzd_);
                CqlValueSet xzzzzzzf_ = this.Observation_Services(context);
                IEnumerable<Encounter> xzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? xzzzzzzh_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> yzzzzzzz_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? zzzzzzza_ = yzzzzzzz_?.Value;
                    Code<Encounter.EncounterStatus> zzzzzzzb_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(zzzzzzza_);
                    bool? zzzzzzzc_ = context.Operators.Equal(zzzzzzzb_, "finished");
                    Period zzzzzzzd_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> zzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzd_);
                    CqlDateTime zzzzzzzf_ = context.Operators.End(zzzzzzze_);
                    Period zzzzzzzg_ = Visit?.Period;
                    CqlInterval<CqlDateTime> zzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzg_);
                    CqlDateTime zzzzzzzi_ = context.Operators.Start(zzzzzzzh_);
                    CqlQuantity zzzzzzzj_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime zzzzzzzk_ = context.Operators.Subtract(zzzzzzzi_, zzzzzzzj_);
                    CqlInterval<CqlDateTime> zzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzg_);
                    CqlDateTime zzzzzzzn_ = context.Operators.Start(zzzzzzzm_);
                    CqlInterval<CqlDateTime> zzzzzzzo_ = context.Operators.Interval(zzzzzzzk_, zzzzzzzn_, true, true);
                    bool? zzzzzzzp_ = context.Operators.In<CqlDateTime>(zzzzzzzf_, zzzzzzzo_, default);
                    CqlInterval<CqlDateTime> zzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzg_);
                    CqlDateTime zzzzzzzs_ = context.Operators.Start(zzzzzzzr_);
                    bool? zzzzzzzt_ = context.Operators.Not((bool?)(zzzzzzzs_ is null));
                    bool? zzzzzzzu_ = context.Operators.And(zzzzzzzp_, zzzzzzzt_);
                    bool? zzzzzzzv_ = context.Operators.And(zzzzzzzc_, zzzzzzzu_);

                    return zzzzzzzv_;
                };
                IEnumerable<Encounter> xzzzzzzi_ = context.Operators.Where<Encounter>(xzzzzzzg_, xzzzzzzh_);
                object xzzzzzzj_(Encounter @this)
                {
                    Period zzzzzzzw_ = @this?.Period;
                    CqlInterval<CqlDateTime> zzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzw_);
                    CqlDateTime zzzzzzzy_ = context.Operators.End(zzzzzzzx_);

                    return zzzzzzzy_;
                };
                IEnumerable<Encounter> xzzzzzzk_ = context.Operators.SortBy<Encounter>(xzzzzzzi_, xzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter xzzzzzzl_ = context.Operators.Last<Encounter>(xzzzzzzk_);
                Period xzzzzzzm_ = xzzzzzzl_?.Period;
                CqlInterval<CqlDateTime> xzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzm_);
                CqlDateTime xzzzzzzo_ = context.Operators.Start(xzzzzzzn_);
                Period xzzzzzzp_ = Visit?.Period;
                CqlInterval<CqlDateTime> xzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzp_);
                CqlDateTime xzzzzzzr_ = context.Operators.Start(xzzzzzzq_);
                CqlQuantity xzzzzzzs_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime xzzzzzzt_ = context.Operators.Subtract(xzzzzzzo_ ?? xzzzzzzr_, xzzzzzzs_);
                IEnumerable<Encounter> xzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? xzzzzzzw_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> zzzzzzzz_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? azzzzzzza_ = zzzzzzzz_?.Value;
                    Code<Encounter.EncounterStatus> azzzzzzzb_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(azzzzzzza_);
                    bool? azzzzzzzc_ = context.Operators.Equal(azzzzzzzb_, "finished");
                    Period azzzzzzzd_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> azzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzd_);
                    CqlDateTime azzzzzzzf_ = context.Operators.End(azzzzzzze_);
                    Period azzzzzzzg_ = Visit?.Period;
                    CqlInterval<CqlDateTime> azzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzg_);
                    CqlDateTime azzzzzzzi_ = context.Operators.Start(azzzzzzzh_);
                    CqlQuantity azzzzzzzj_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime azzzzzzzk_ = context.Operators.Subtract(azzzzzzzi_, azzzzzzzj_);
                    CqlInterval<CqlDateTime> azzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzg_);
                    CqlDateTime azzzzzzzn_ = context.Operators.Start(azzzzzzzm_);
                    CqlInterval<CqlDateTime> azzzzzzzo_ = context.Operators.Interval(azzzzzzzk_, azzzzzzzn_, true, true);
                    bool? azzzzzzzp_ = context.Operators.In<CqlDateTime>(azzzzzzzf_, azzzzzzzo_, default);
                    CqlInterval<CqlDateTime> azzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzg_);
                    CqlDateTime azzzzzzzs_ = context.Operators.Start(azzzzzzzr_);
                    bool? azzzzzzzt_ = context.Operators.Not((bool?)(azzzzzzzs_ is null));
                    bool? azzzzzzzu_ = context.Operators.And(azzzzzzzp_, azzzzzzzt_);
                    bool? azzzzzzzv_ = context.Operators.And(azzzzzzzc_, azzzzzzzu_);

                    return azzzzzzzv_;
                };
                IEnumerable<Encounter> xzzzzzzx_ = context.Operators.Where<Encounter>(xzzzzzzv_, xzzzzzzw_);
                object xzzzzzzy_(Encounter @this)
                {
                    Period azzzzzzzw_ = @this?.Period;
                    CqlInterval<CqlDateTime> azzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzw_);
                    CqlDateTime azzzzzzzy_ = context.Operators.End(azzzzzzzx_);

                    return azzzzzzzy_;
                };
                IEnumerable<Encounter> xzzzzzzz_ = context.Operators.SortBy<Encounter>(xzzzzzzx_, xzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter yzzzzzza_ = context.Operators.Last<Encounter>(xzzzzzzz_);
                Period yzzzzzzb_ = yzzzzzza_?.Period;
                CqlInterval<CqlDateTime> yzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzb_);
                CqlDateTime yzzzzzzd_ = context.Operators.Start(yzzzzzzc_);
                CqlInterval<CqlDateTime> yzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzp_);
                CqlDateTime yzzzzzzg_ = context.Operators.Start(yzzzzzzf_);
                CqlInterval<CqlDateTime> yzzzzzzh_ = context.Operators.Interval(xzzzzzzt_, yzzzzzzd_ ?? yzzzzzzg_, true, true);
                bool? yzzzzzzi_ = context.Operators.In<CqlDateTime>(xzzzzzze_, yzzzzzzh_, default);
                IEnumerable<Encounter> yzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? yzzzzzzl_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> azzzzzzzz_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? bzzzzzzza_ = azzzzzzzz_?.Value;
                    Code<Encounter.EncounterStatus> bzzzzzzzb_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bzzzzzzza_);
                    bool? bzzzzzzzc_ = context.Operators.Equal(bzzzzzzzb_, "finished");
                    Period bzzzzzzzd_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> bzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzd_);
                    CqlDateTime bzzzzzzzf_ = context.Operators.End(bzzzzzzze_);
                    Period bzzzzzzzg_ = Visit?.Period;
                    CqlInterval<CqlDateTime> bzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzg_);
                    CqlDateTime bzzzzzzzi_ = context.Operators.Start(bzzzzzzzh_);
                    CqlQuantity bzzzzzzzj_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime bzzzzzzzk_ = context.Operators.Subtract(bzzzzzzzi_, bzzzzzzzj_);
                    CqlInterval<CqlDateTime> bzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzg_);
                    CqlDateTime bzzzzzzzn_ = context.Operators.Start(bzzzzzzzm_);
                    CqlInterval<CqlDateTime> bzzzzzzzo_ = context.Operators.Interval(bzzzzzzzk_, bzzzzzzzn_, true, true);
                    bool? bzzzzzzzp_ = context.Operators.In<CqlDateTime>(bzzzzzzzf_, bzzzzzzzo_, default);
                    CqlInterval<CqlDateTime> bzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzg_);
                    CqlDateTime bzzzzzzzs_ = context.Operators.Start(bzzzzzzzr_);
                    bool? bzzzzzzzt_ = context.Operators.Not((bool?)(bzzzzzzzs_ is null));
                    bool? bzzzzzzzu_ = context.Operators.And(bzzzzzzzp_, bzzzzzzzt_);
                    bool? bzzzzzzzv_ = context.Operators.And(bzzzzzzzc_, bzzzzzzzu_);

                    return bzzzzzzzv_;
                };
                IEnumerable<Encounter> yzzzzzzm_ = context.Operators.Where<Encounter>(yzzzzzzk_, yzzzzzzl_);
                object yzzzzzzn_(Encounter @this)
                {
                    Period bzzzzzzzw_ = @this?.Period;
                    CqlInterval<CqlDateTime> bzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzw_);
                    CqlDateTime bzzzzzzzy_ = context.Operators.End(bzzzzzzzx_);

                    return bzzzzzzzy_;
                };
                IEnumerable<Encounter> yzzzzzzo_ = context.Operators.SortBy<Encounter>(yzzzzzzm_, yzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter yzzzzzzp_ = context.Operators.Last<Encounter>(yzzzzzzo_);
                Period yzzzzzzq_ = yzzzzzzp_?.Period;
                CqlInterval<CqlDateTime> yzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzq_);
                CqlDateTime yzzzzzzs_ = context.Operators.Start(yzzzzzzr_);
                CqlInterval<CqlDateTime> yzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzp_);
                CqlDateTime yzzzzzzv_ = context.Operators.Start(yzzzzzzu_);
                bool? yzzzzzzw_ = context.Operators.Not((bool?)((yzzzzzzs_ ?? yzzzzzzv_) is null));
                bool? yzzzzzzx_ = context.Operators.And(yzzzzzzi_, yzzzzzzw_);
                bool? yzzzzzzy_ = context.Operators.And(xzzzzzzb_, yzzzzzzx_);

                return yzzzzzzy_;
            };
            IEnumerable<Encounter> azzzzzzl_ = context.Operators.Where<Encounter>(azzzzzzj_, azzzzzzk_);
            object azzzzzzm_(Encounter @this)
            {
                Period bzzzzzzzz_ = @this?.Period;
                CqlInterval<CqlDateTime> czzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzz_);
                CqlDateTime czzzzzzzb_ = context.Operators.End(czzzzzzza_);

                return czzzzzzzb_;
            };
            IEnumerable<Encounter> azzzzzzn_ = context.Operators.SortBy<Encounter>(azzzzzzl_, azzzzzzm_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter azzzzzzo_ = context.Operators.Last<Encounter>(azzzzzzn_);
            Period azzzzzzp_ = azzzzzzo_?.Period;
            CqlInterval<CqlDateTime> azzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzp_);
            CqlDateTime azzzzzzr_ = context.Operators.Start(azzzzzzq_);
            CqlValueSet azzzzzzs_ = this.Observation_Services(context);
            IEnumerable<Encounter> azzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? azzzzzzu_(Encounter LastObs)
            {
                Code<Encounter.EncounterStatus> czzzzzzzc_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? czzzzzzzd_ = czzzzzzzc_?.Value;
                Code<Encounter.EncounterStatus> czzzzzzze_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(czzzzzzzd_);
                bool? czzzzzzzf_ = context.Operators.Equal(czzzzzzze_, "finished");
                Period czzzzzzzg_ = LastObs?.Period;
                CqlInterval<CqlDateTime> czzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzg_);
                CqlDateTime czzzzzzzi_ = context.Operators.End(czzzzzzzh_);
                Period czzzzzzzj_ = Visit?.Period;
                CqlInterval<CqlDateTime> czzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzj_);
                CqlDateTime czzzzzzzl_ = context.Operators.Start(czzzzzzzk_);
                CqlQuantity czzzzzzzm_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime czzzzzzzn_ = context.Operators.Subtract(czzzzzzzl_, czzzzzzzm_);
                CqlInterval<CqlDateTime> czzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzj_);
                CqlDateTime czzzzzzzq_ = context.Operators.Start(czzzzzzzp_);
                CqlInterval<CqlDateTime> czzzzzzzr_ = context.Operators.Interval(czzzzzzzn_, czzzzzzzq_, true, true);
                bool? czzzzzzzs_ = context.Operators.In<CqlDateTime>(czzzzzzzi_, czzzzzzzr_, default);
                CqlInterval<CqlDateTime> czzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzj_);
                CqlDateTime czzzzzzzv_ = context.Operators.Start(czzzzzzzu_);
                bool? czzzzzzzw_ = context.Operators.Not((bool?)(czzzzzzzv_ is null));
                bool? czzzzzzzx_ = context.Operators.And(czzzzzzzs_, czzzzzzzw_);
                bool? czzzzzzzy_ = context.Operators.And(czzzzzzzf_, czzzzzzzx_);

                return czzzzzzzy_;
            };
            IEnumerable<Encounter> azzzzzzv_ = context.Operators.Where<Encounter>(azzzzzzt_, azzzzzzu_);
            object azzzzzzw_(Encounter @this)
            {
                Period czzzzzzzz_ = @this?.Period;
                CqlInterval<CqlDateTime> dzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzz_);
                CqlDateTime dzzzzzzzb_ = context.Operators.End(dzzzzzzza_);

                return dzzzzzzzb_;
            };
            IEnumerable<Encounter> azzzzzzx_ = context.Operators.SortBy<Encounter>(azzzzzzv_, azzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter azzzzzzy_ = context.Operators.Last<Encounter>(azzzzzzx_);
            Period azzzzzzz_ = azzzzzzy_?.Period;
            CqlInterval<CqlDateTime> bzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzz_);
            CqlDateTime bzzzzzzb_ = context.Operators.Start(bzzzzzza_);
            Period bzzzzzzc_ = Visit?.Period;
            CqlInterval<CqlDateTime> bzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzc_);
            CqlDateTime bzzzzzze_ = context.Operators.Start(bzzzzzzd_);
            CqlInterval<CqlDateTime> bzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzc_);
            CqlDateTime bzzzzzzh_ = context.Operators.End(bzzzzzzg_);
            CqlInterval<CqlDateTime> bzzzzzzi_ = context.Operators.Interval(azzzzzzh_ ?? azzzzzzr_ ?? bzzzzzzb_ ?? bzzzzzze_, bzzzzzzh_, true, true);

            return bzzzzzzi_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> zzzzzzv_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)zzzzzzt_, zzzzzzu_);
        IEnumerable<CqlInterval<CqlDateTime>> zzzzzzw_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(zzzzzzv_);
        CqlInterval<CqlDateTime> zzzzzzx_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(zzzzzzw_);

        return zzzzzzx_;
    }


    [CqlExpressionDefinition("hospitalizationWithObservationAndOutpatientSurgeryService")]
    [CqlTag("description", "Hospitalization with Observation and Outpatient Surgery Service returns the total interval from the start of any immediately prior emergency department visit, outpatient surgery visit or observation visit to the discharge of the given encounter.")]
    public CqlInterval<CqlDateTime> hospitalizationWithObservationAndOutpatientSurgeryService(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] dzzzzzzzc_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> dzzzzzzzd_(Encounter Visit)
        {
            CqlValueSet dzzzzzzzh_ = this.Outpatient_Surgery_Service(context);
            IEnumerable<Encounter> dzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? dzzzzzzzj_(Encounter LastSurgeryOP)
            {
                Period ezzzzzzzs_ = LastSurgeryOP?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzs_);
                CqlDateTime ezzzzzzzu_ = context.Operators.End(ezzzzzzzt_);
                CqlValueSet ezzzzzzzv_ = this.Emergency_Department_Visit(context);
                IEnumerable<Encounter> ezzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? ezzzzzzzx_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> hzzzzzzzs_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? hzzzzzzzt_ = hzzzzzzzs_?.Value;
                    Code<Encounter.EncounterStatus> hzzzzzzzu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hzzzzzzzt_);
                    bool? hzzzzzzzv_ = context.Operators.Equal(hzzzzzzzu_, "finished");
                    Period hzzzzzzzw_ = LastED?.Period;
                    CqlInterval<CqlDateTime> hzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzw_);
                    CqlDateTime hzzzzzzzy_ = context.Operators.End(hzzzzzzzx_);
                    CqlValueSet hzzzzzzzz_ = this.Observation_Services(context);
                    IEnumerable<Encounter> izzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? izzzzzzzb_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> jzzzzzzzt_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? jzzzzzzzu_ = jzzzzzzzt_?.Value;
                        Code<Encounter.EncounterStatus> jzzzzzzzv_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jzzzzzzzu_);
                        bool? jzzzzzzzw_ = context.Operators.Equal(jzzzzzzzv_, "finished");
                        Period jzzzzzzzx_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> jzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzx_);
                        CqlDateTime jzzzzzzzz_ = context.Operators.End(jzzzzzzzy_);
                        Period kzzzzzzza_ = Visit?.Period;
                        CqlInterval<CqlDateTime> kzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzza_);
                        CqlDateTime kzzzzzzzc_ = context.Operators.Start(kzzzzzzzb_);
                        CqlQuantity kzzzzzzzd_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime kzzzzzzze_ = context.Operators.Subtract(kzzzzzzzc_, kzzzzzzzd_);
                        CqlInterval<CqlDateTime> kzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzza_);
                        CqlDateTime kzzzzzzzh_ = context.Operators.Start(kzzzzzzzg_);
                        CqlInterval<CqlDateTime> kzzzzzzzi_ = context.Operators.Interval(kzzzzzzze_, kzzzzzzzh_, true, true);
                        bool? kzzzzzzzj_ = context.Operators.In<CqlDateTime>(jzzzzzzzz_, kzzzzzzzi_, default);
                        CqlInterval<CqlDateTime> kzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzza_);
                        CqlDateTime kzzzzzzzm_ = context.Operators.Start(kzzzzzzzl_);
                        bool? kzzzzzzzn_ = context.Operators.Not((bool?)(kzzzzzzzm_ is null));
                        bool? kzzzzzzzo_ = context.Operators.And(kzzzzzzzj_, kzzzzzzzn_);
                        bool? kzzzzzzzp_ = context.Operators.And(jzzzzzzzw_, kzzzzzzzo_);

                        return kzzzzzzzp_;
                    };
                    IEnumerable<Encounter> izzzzzzzc_ = context.Operators.Where<Encounter>(izzzzzzza_, izzzzzzzb_);
                    object izzzzzzzd_(Encounter @this)
                    {
                        Period kzzzzzzzq_ = @this?.Period;
                        CqlInterval<CqlDateTime> kzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzq_);
                        CqlDateTime kzzzzzzzs_ = context.Operators.End(kzzzzzzzr_);

                        return kzzzzzzzs_;
                    };
                    IEnumerable<Encounter> izzzzzzze_ = context.Operators.SortBy<Encounter>(izzzzzzzc_, izzzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter izzzzzzzf_ = context.Operators.Last<Encounter>(izzzzzzze_);
                    Period izzzzzzzg_ = izzzzzzzf_?.Period;
                    CqlInterval<CqlDateTime> izzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzg_);
                    CqlDateTime izzzzzzzi_ = context.Operators.Start(izzzzzzzh_);
                    Period izzzzzzzj_ = Visit?.Period;
                    CqlInterval<CqlDateTime> izzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzj_);
                    CqlDateTime izzzzzzzl_ = context.Operators.Start(izzzzzzzk_);
                    CqlQuantity izzzzzzzm_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime izzzzzzzn_ = context.Operators.Subtract(izzzzzzzi_ ?? izzzzzzzl_, izzzzzzzm_);
                    IEnumerable<Encounter> izzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? izzzzzzzq_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> kzzzzzzzt_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? kzzzzzzzu_ = kzzzzzzzt_?.Value;
                        Code<Encounter.EncounterStatus> kzzzzzzzv_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(kzzzzzzzu_);
                        bool? kzzzzzzzw_ = context.Operators.Equal(kzzzzzzzv_, "finished");
                        Period kzzzzzzzx_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> kzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzx_);
                        CqlDateTime kzzzzzzzz_ = context.Operators.End(kzzzzzzzy_);
                        Period lzzzzzzza_ = Visit?.Period;
                        CqlInterval<CqlDateTime> lzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzza_);
                        CqlDateTime lzzzzzzzc_ = context.Operators.Start(lzzzzzzzb_);
                        CqlQuantity lzzzzzzzd_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime lzzzzzzze_ = context.Operators.Subtract(lzzzzzzzc_, lzzzzzzzd_);
                        CqlInterval<CqlDateTime> lzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzza_);
                        CqlDateTime lzzzzzzzh_ = context.Operators.Start(lzzzzzzzg_);
                        CqlInterval<CqlDateTime> lzzzzzzzi_ = context.Operators.Interval(lzzzzzzze_, lzzzzzzzh_, true, true);
                        bool? lzzzzzzzj_ = context.Operators.In<CqlDateTime>(kzzzzzzzz_, lzzzzzzzi_, default);
                        CqlInterval<CqlDateTime> lzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzza_);
                        CqlDateTime lzzzzzzzm_ = context.Operators.Start(lzzzzzzzl_);
                        bool? lzzzzzzzn_ = context.Operators.Not((bool?)(lzzzzzzzm_ is null));
                        bool? lzzzzzzzo_ = context.Operators.And(lzzzzzzzj_, lzzzzzzzn_);
                        bool? lzzzzzzzp_ = context.Operators.And(kzzzzzzzw_, lzzzzzzzo_);

                        return lzzzzzzzp_;
                    };
                    IEnumerable<Encounter> izzzzzzzr_ = context.Operators.Where<Encounter>(izzzzzzzp_, izzzzzzzq_);
                    object izzzzzzzs_(Encounter @this)
                    {
                        Period lzzzzzzzq_ = @this?.Period;
                        CqlInterval<CqlDateTime> lzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzq_);
                        CqlDateTime lzzzzzzzs_ = context.Operators.End(lzzzzzzzr_);

                        return lzzzzzzzs_;
                    };
                    IEnumerable<Encounter> izzzzzzzt_ = context.Operators.SortBy<Encounter>(izzzzzzzr_, izzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter izzzzzzzu_ = context.Operators.Last<Encounter>(izzzzzzzt_);
                    Period izzzzzzzv_ = izzzzzzzu_?.Period;
                    CqlInterval<CqlDateTime> izzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzv_);
                    CqlDateTime izzzzzzzx_ = context.Operators.Start(izzzzzzzw_);
                    CqlInterval<CqlDateTime> izzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzj_);
                    CqlDateTime jzzzzzzza_ = context.Operators.Start(izzzzzzzz_);
                    CqlInterval<CqlDateTime> jzzzzzzzb_ = context.Operators.Interval(izzzzzzzn_, izzzzzzzx_ ?? jzzzzzzza_, true, true);
                    bool? jzzzzzzzc_ = context.Operators.In<CqlDateTime>(hzzzzzzzy_, jzzzzzzzb_, default);
                    IEnumerable<Encounter> jzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? jzzzzzzzf_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> lzzzzzzzt_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? lzzzzzzzu_ = lzzzzzzzt_?.Value;
                        Code<Encounter.EncounterStatus> lzzzzzzzv_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lzzzzzzzu_);
                        bool? lzzzzzzzw_ = context.Operators.Equal(lzzzzzzzv_, "finished");
                        Period lzzzzzzzx_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> lzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzx_);
                        CqlDateTime lzzzzzzzz_ = context.Operators.End(lzzzzzzzy_);
                        Period mzzzzzzza_ = Visit?.Period;
                        CqlInterval<CqlDateTime> mzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzza_);
                        CqlDateTime mzzzzzzzc_ = context.Operators.Start(mzzzzzzzb_);
                        CqlQuantity mzzzzzzzd_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime mzzzzzzze_ = context.Operators.Subtract(mzzzzzzzc_, mzzzzzzzd_);
                        CqlInterval<CqlDateTime> mzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzza_);
                        CqlDateTime mzzzzzzzh_ = context.Operators.Start(mzzzzzzzg_);
                        CqlInterval<CqlDateTime> mzzzzzzzi_ = context.Operators.Interval(mzzzzzzze_, mzzzzzzzh_, true, true);
                        bool? mzzzzzzzj_ = context.Operators.In<CqlDateTime>(lzzzzzzzz_, mzzzzzzzi_, default);
                        CqlInterval<CqlDateTime> mzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzza_);
                        CqlDateTime mzzzzzzzm_ = context.Operators.Start(mzzzzzzzl_);
                        bool? mzzzzzzzn_ = context.Operators.Not((bool?)(mzzzzzzzm_ is null));
                        bool? mzzzzzzzo_ = context.Operators.And(mzzzzzzzj_, mzzzzzzzn_);
                        bool? mzzzzzzzp_ = context.Operators.And(lzzzzzzzw_, mzzzzzzzo_);

                        return mzzzzzzzp_;
                    };
                    IEnumerable<Encounter> jzzzzzzzg_ = context.Operators.Where<Encounter>(jzzzzzzze_, jzzzzzzzf_);
                    object jzzzzzzzh_(Encounter @this)
                    {
                        Period mzzzzzzzq_ = @this?.Period;
                        CqlInterval<CqlDateTime> mzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzq_);
                        CqlDateTime mzzzzzzzs_ = context.Operators.End(mzzzzzzzr_);

                        return mzzzzzzzs_;
                    };
                    IEnumerable<Encounter> jzzzzzzzi_ = context.Operators.SortBy<Encounter>(jzzzzzzzg_, jzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter jzzzzzzzj_ = context.Operators.Last<Encounter>(jzzzzzzzi_);
                    Period jzzzzzzzk_ = jzzzzzzzj_?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzk_);
                    CqlDateTime jzzzzzzzm_ = context.Operators.Start(jzzzzzzzl_);
                    CqlInterval<CqlDateTime> jzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzj_);
                    CqlDateTime jzzzzzzzp_ = context.Operators.Start(jzzzzzzzo_);
                    bool? jzzzzzzzq_ = context.Operators.Not((bool?)((jzzzzzzzm_ ?? jzzzzzzzp_) is null));
                    bool? jzzzzzzzr_ = context.Operators.And(jzzzzzzzc_, jzzzzzzzq_);
                    bool? jzzzzzzzs_ = context.Operators.And(hzzzzzzzv_, jzzzzzzzr_);

                    return jzzzzzzzs_;
                };
                IEnumerable<Encounter> ezzzzzzzy_ = context.Operators.Where<Encounter>(ezzzzzzzw_, ezzzzzzzx_);
                object ezzzzzzzz_(Encounter @this)
                {
                    Period mzzzzzzzt_ = @this?.Period;
                    CqlInterval<CqlDateTime> mzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzt_);
                    CqlDateTime mzzzzzzzv_ = context.Operators.End(mzzzzzzzu_);

                    return mzzzzzzzv_;
                };
                IEnumerable<Encounter> fzzzzzzza_ = context.Operators.SortBy<Encounter>(ezzzzzzzy_, ezzzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter fzzzzzzzb_ = context.Operators.Last<Encounter>(fzzzzzzza_);
                Period fzzzzzzzc_ = fzzzzzzzb_?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzc_);
                CqlDateTime fzzzzzzze_ = context.Operators.Start(fzzzzzzzd_);
                CqlValueSet fzzzzzzzf_ = this.Observation_Services(context);
                IEnumerable<Encounter> fzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? fzzzzzzzh_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> mzzzzzzzw_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? mzzzzzzzx_ = mzzzzzzzw_?.Value;
                    Code<Encounter.EncounterStatus> mzzzzzzzy_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(mzzzzzzzx_);
                    bool? mzzzzzzzz_ = context.Operators.Equal(mzzzzzzzy_, "finished");
                    Period nzzzzzzza_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> nzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzza_);
                    CqlDateTime nzzzzzzzc_ = context.Operators.End(nzzzzzzzb_);
                    Period nzzzzzzzd_ = Visit?.Period;
                    CqlInterval<CqlDateTime> nzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzd_);
                    CqlDateTime nzzzzzzzf_ = context.Operators.Start(nzzzzzzze_);
                    CqlQuantity nzzzzzzzg_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime nzzzzzzzh_ = context.Operators.Subtract(nzzzzzzzf_, nzzzzzzzg_);
                    CqlInterval<CqlDateTime> nzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzd_);
                    CqlDateTime nzzzzzzzk_ = context.Operators.Start(nzzzzzzzj_);
                    CqlInterval<CqlDateTime> nzzzzzzzl_ = context.Operators.Interval(nzzzzzzzh_, nzzzzzzzk_, true, true);
                    bool? nzzzzzzzm_ = context.Operators.In<CqlDateTime>(nzzzzzzzc_, nzzzzzzzl_, default);
                    CqlInterval<CqlDateTime> nzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzd_);
                    CqlDateTime nzzzzzzzp_ = context.Operators.Start(nzzzzzzzo_);
                    bool? nzzzzzzzq_ = context.Operators.Not((bool?)(nzzzzzzzp_ is null));
                    bool? nzzzzzzzr_ = context.Operators.And(nzzzzzzzm_, nzzzzzzzq_);
                    bool? nzzzzzzzs_ = context.Operators.And(mzzzzzzzz_, nzzzzzzzr_);

                    return nzzzzzzzs_;
                };
                IEnumerable<Encounter> fzzzzzzzi_ = context.Operators.Where<Encounter>(fzzzzzzzg_, fzzzzzzzh_);
                object fzzzzzzzj_(Encounter @this)
                {
                    Period nzzzzzzzt_ = @this?.Period;
                    CqlInterval<CqlDateTime> nzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzt_);
                    CqlDateTime nzzzzzzzv_ = context.Operators.End(nzzzzzzzu_);

                    return nzzzzzzzv_;
                };
                IEnumerable<Encounter> fzzzzzzzk_ = context.Operators.SortBy<Encounter>(fzzzzzzzi_, fzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter fzzzzzzzl_ = context.Operators.Last<Encounter>(fzzzzzzzk_);
                Period fzzzzzzzm_ = fzzzzzzzl_?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzm_);
                CqlDateTime fzzzzzzzo_ = context.Operators.Start(fzzzzzzzn_);
                Period fzzzzzzzp_ = Visit?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzp_);
                CqlDateTime fzzzzzzzr_ = context.Operators.Start(fzzzzzzzq_);
                CqlQuantity fzzzzzzzs_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime fzzzzzzzt_ = context.Operators.Subtract(fzzzzzzze_ ?? fzzzzzzzo_ ?? fzzzzzzzr_, fzzzzzzzs_);
                IEnumerable<Encounter> fzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? fzzzzzzzw_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> nzzzzzzzw_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? nzzzzzzzx_ = nzzzzzzzw_?.Value;
                    Code<Encounter.EncounterStatus> nzzzzzzzy_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(nzzzzzzzx_);
                    bool? nzzzzzzzz_ = context.Operators.Equal(nzzzzzzzy_, "finished");
                    Period ozzzzzzza_ = LastED?.Period;
                    CqlInterval<CqlDateTime> ozzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzza_);
                    CqlDateTime ozzzzzzzc_ = context.Operators.End(ozzzzzzzb_);
                    CqlValueSet ozzzzzzzd_ = this.Observation_Services(context);
                    IEnumerable<Encounter> ozzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? ozzzzzzzf_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> pzzzzzzzx_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? pzzzzzzzy_ = pzzzzzzzx_?.Value;
                        Code<Encounter.EncounterStatus> pzzzzzzzz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pzzzzzzzy_);
                        bool? qzzzzzzza_ = context.Operators.Equal(pzzzzzzzz_, "finished");
                        Period qzzzzzzzb_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> qzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzb_);
                        CqlDateTime qzzzzzzzd_ = context.Operators.End(qzzzzzzzc_);
                        Period qzzzzzzze_ = Visit?.Period;
                        CqlInterval<CqlDateTime> qzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzze_);
                        CqlDateTime qzzzzzzzg_ = context.Operators.Start(qzzzzzzzf_);
                        CqlQuantity qzzzzzzzh_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime qzzzzzzzi_ = context.Operators.Subtract(qzzzzzzzg_, qzzzzzzzh_);
                        CqlInterval<CqlDateTime> qzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzze_);
                        CqlDateTime qzzzzzzzl_ = context.Operators.Start(qzzzzzzzk_);
                        CqlInterval<CqlDateTime> qzzzzzzzm_ = context.Operators.Interval(qzzzzzzzi_, qzzzzzzzl_, true, true);
                        bool? qzzzzzzzn_ = context.Operators.In<CqlDateTime>(qzzzzzzzd_, qzzzzzzzm_, default);
                        CqlInterval<CqlDateTime> qzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzze_);
                        CqlDateTime qzzzzzzzq_ = context.Operators.Start(qzzzzzzzp_);
                        bool? qzzzzzzzr_ = context.Operators.Not((bool?)(qzzzzzzzq_ is null));
                        bool? qzzzzzzzs_ = context.Operators.And(qzzzzzzzn_, qzzzzzzzr_);
                        bool? qzzzzzzzt_ = context.Operators.And(qzzzzzzza_, qzzzzzzzs_);

                        return qzzzzzzzt_;
                    };
                    IEnumerable<Encounter> ozzzzzzzg_ = context.Operators.Where<Encounter>(ozzzzzzze_, ozzzzzzzf_);
                    object ozzzzzzzh_(Encounter @this)
                    {
                        Period qzzzzzzzu_ = @this?.Period;
                        CqlInterval<CqlDateTime> qzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzu_);
                        CqlDateTime qzzzzzzzw_ = context.Operators.End(qzzzzzzzv_);

                        return qzzzzzzzw_;
                    };
                    IEnumerable<Encounter> ozzzzzzzi_ = context.Operators.SortBy<Encounter>(ozzzzzzzg_, ozzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter ozzzzzzzj_ = context.Operators.Last<Encounter>(ozzzzzzzi_);
                    Period ozzzzzzzk_ = ozzzzzzzj_?.Period;
                    CqlInterval<CqlDateTime> ozzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzk_);
                    CqlDateTime ozzzzzzzm_ = context.Operators.Start(ozzzzzzzl_);
                    Period ozzzzzzzn_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ozzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzn_);
                    CqlDateTime ozzzzzzzp_ = context.Operators.Start(ozzzzzzzo_);
                    CqlQuantity ozzzzzzzq_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ozzzzzzzr_ = context.Operators.Subtract(ozzzzzzzm_ ?? ozzzzzzzp_, ozzzzzzzq_);
                    IEnumerable<Encounter> ozzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? ozzzzzzzu_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> qzzzzzzzx_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? qzzzzzzzy_ = qzzzzzzzx_?.Value;
                        Code<Encounter.EncounterStatus> qzzzzzzzz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(qzzzzzzzy_);
                        bool? rzzzzzzza_ = context.Operators.Equal(qzzzzzzzz_, "finished");
                        Period rzzzzzzzb_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> rzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzb_);
                        CqlDateTime rzzzzzzzd_ = context.Operators.End(rzzzzzzzc_);
                        Period rzzzzzzze_ = Visit?.Period;
                        CqlInterval<CqlDateTime> rzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzze_);
                        CqlDateTime rzzzzzzzg_ = context.Operators.Start(rzzzzzzzf_);
                        CqlQuantity rzzzzzzzh_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime rzzzzzzzi_ = context.Operators.Subtract(rzzzzzzzg_, rzzzzzzzh_);
                        CqlInterval<CqlDateTime> rzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzze_);
                        CqlDateTime rzzzzzzzl_ = context.Operators.Start(rzzzzzzzk_);
                        CqlInterval<CqlDateTime> rzzzzzzzm_ = context.Operators.Interval(rzzzzzzzi_, rzzzzzzzl_, true, true);
                        bool? rzzzzzzzn_ = context.Operators.In<CqlDateTime>(rzzzzzzzd_, rzzzzzzzm_, default);
                        CqlInterval<CqlDateTime> rzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzze_);
                        CqlDateTime rzzzzzzzq_ = context.Operators.Start(rzzzzzzzp_);
                        bool? rzzzzzzzr_ = context.Operators.Not((bool?)(rzzzzzzzq_ is null));
                        bool? rzzzzzzzs_ = context.Operators.And(rzzzzzzzn_, rzzzzzzzr_);
                        bool? rzzzzzzzt_ = context.Operators.And(rzzzzzzza_, rzzzzzzzs_);

                        return rzzzzzzzt_;
                    };
                    IEnumerable<Encounter> ozzzzzzzv_ = context.Operators.Where<Encounter>(ozzzzzzzt_, ozzzzzzzu_);
                    object ozzzzzzzw_(Encounter @this)
                    {
                        Period rzzzzzzzu_ = @this?.Period;
                        CqlInterval<CqlDateTime> rzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzu_);
                        CqlDateTime rzzzzzzzw_ = context.Operators.End(rzzzzzzzv_);

                        return rzzzzzzzw_;
                    };
                    IEnumerable<Encounter> ozzzzzzzx_ = context.Operators.SortBy<Encounter>(ozzzzzzzv_, ozzzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter ozzzzzzzy_ = context.Operators.Last<Encounter>(ozzzzzzzx_);
                    Period ozzzzzzzz_ = ozzzzzzzy_?.Period;
                    CqlInterval<CqlDateTime> pzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzz_);
                    CqlDateTime pzzzzzzzb_ = context.Operators.Start(pzzzzzzza_);
                    CqlInterval<CqlDateTime> pzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzn_);
                    CqlDateTime pzzzzzzze_ = context.Operators.Start(pzzzzzzzd_);
                    CqlInterval<CqlDateTime> pzzzzzzzf_ = context.Operators.Interval(ozzzzzzzr_, pzzzzzzzb_ ?? pzzzzzzze_, true, true);
                    bool? pzzzzzzzg_ = context.Operators.In<CqlDateTime>(ozzzzzzzc_, pzzzzzzzf_, default);
                    IEnumerable<Encounter> pzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? pzzzzzzzj_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> rzzzzzzzx_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? rzzzzzzzy_ = rzzzzzzzx_?.Value;
                        Code<Encounter.EncounterStatus> rzzzzzzzz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rzzzzzzzy_);
                        bool? szzzzzzza_ = context.Operators.Equal(rzzzzzzzz_, "finished");
                        Period szzzzzzzb_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> szzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzb_);
                        CqlDateTime szzzzzzzd_ = context.Operators.End(szzzzzzzc_);
                        Period szzzzzzze_ = Visit?.Period;
                        CqlInterval<CqlDateTime> szzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzze_);
                        CqlDateTime szzzzzzzg_ = context.Operators.Start(szzzzzzzf_);
                        CqlQuantity szzzzzzzh_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime szzzzzzzi_ = context.Operators.Subtract(szzzzzzzg_, szzzzzzzh_);
                        CqlInterval<CqlDateTime> szzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzze_);
                        CqlDateTime szzzzzzzl_ = context.Operators.Start(szzzzzzzk_);
                        CqlInterval<CqlDateTime> szzzzzzzm_ = context.Operators.Interval(szzzzzzzi_, szzzzzzzl_, true, true);
                        bool? szzzzzzzn_ = context.Operators.In<CqlDateTime>(szzzzzzzd_, szzzzzzzm_, default);
                        CqlInterval<CqlDateTime> szzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzze_);
                        CqlDateTime szzzzzzzq_ = context.Operators.Start(szzzzzzzp_);
                        bool? szzzzzzzr_ = context.Operators.Not((bool?)(szzzzzzzq_ is null));
                        bool? szzzzzzzs_ = context.Operators.And(szzzzzzzn_, szzzzzzzr_);
                        bool? szzzzzzzt_ = context.Operators.And(szzzzzzza_, szzzzzzzs_);

                        return szzzzzzzt_;
                    };
                    IEnumerable<Encounter> pzzzzzzzk_ = context.Operators.Where<Encounter>(pzzzzzzzi_, pzzzzzzzj_);
                    object pzzzzzzzl_(Encounter @this)
                    {
                        Period szzzzzzzu_ = @this?.Period;
                        CqlInterval<CqlDateTime> szzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzu_);
                        CqlDateTime szzzzzzzw_ = context.Operators.End(szzzzzzzv_);

                        return szzzzzzzw_;
                    };
                    IEnumerable<Encounter> pzzzzzzzm_ = context.Operators.SortBy<Encounter>(pzzzzzzzk_, pzzzzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter pzzzzzzzn_ = context.Operators.Last<Encounter>(pzzzzzzzm_);
                    Period pzzzzzzzo_ = pzzzzzzzn_?.Period;
                    CqlInterval<CqlDateTime> pzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzo_);
                    CqlDateTime pzzzzzzzq_ = context.Operators.Start(pzzzzzzzp_);
                    CqlInterval<CqlDateTime> pzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzn_);
                    CqlDateTime pzzzzzzzt_ = context.Operators.Start(pzzzzzzzs_);
                    bool? pzzzzzzzu_ = context.Operators.Not((bool?)((pzzzzzzzq_ ?? pzzzzzzzt_) is null));
                    bool? pzzzzzzzv_ = context.Operators.And(pzzzzzzzg_, pzzzzzzzu_);
                    bool? pzzzzzzzw_ = context.Operators.And(nzzzzzzzz_, pzzzzzzzv_);

                    return pzzzzzzzw_;
                };
                IEnumerable<Encounter> fzzzzzzzx_ = context.Operators.Where<Encounter>(fzzzzzzzv_, fzzzzzzzw_);
                object fzzzzzzzy_(Encounter @this)
                {
                    Period szzzzzzzx_ = @this?.Period;
                    CqlInterval<CqlDateTime> szzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzx_);
                    CqlDateTime szzzzzzzz_ = context.Operators.End(szzzzzzzy_);

                    return szzzzzzzz_;
                };
                IEnumerable<Encounter> fzzzzzzzz_ = context.Operators.SortBy<Encounter>(fzzzzzzzx_, fzzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter gzzzzzzza_ = context.Operators.Last<Encounter>(fzzzzzzzz_);
                Period gzzzzzzzb_ = gzzzzzzza_?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzb_);
                CqlDateTime gzzzzzzzd_ = context.Operators.Start(gzzzzzzzc_);
                IEnumerable<Encounter> gzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? gzzzzzzzg_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> tzzzzzzza_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? tzzzzzzzb_ = tzzzzzzza_?.Value;
                    Code<Encounter.EncounterStatus> tzzzzzzzc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(tzzzzzzzb_);
                    bool? tzzzzzzzd_ = context.Operators.Equal(tzzzzzzzc_, "finished");
                    Period tzzzzzzze_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> tzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzze_);
                    CqlDateTime tzzzzzzzg_ = context.Operators.End(tzzzzzzzf_);
                    Period tzzzzzzzh_ = Visit?.Period;
                    CqlInterval<CqlDateTime> tzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzh_);
                    CqlDateTime tzzzzzzzj_ = context.Operators.Start(tzzzzzzzi_);
                    CqlQuantity tzzzzzzzk_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime tzzzzzzzl_ = context.Operators.Subtract(tzzzzzzzj_, tzzzzzzzk_);
                    CqlInterval<CqlDateTime> tzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzh_);
                    CqlDateTime tzzzzzzzo_ = context.Operators.Start(tzzzzzzzn_);
                    CqlInterval<CqlDateTime> tzzzzzzzp_ = context.Operators.Interval(tzzzzzzzl_, tzzzzzzzo_, true, true);
                    bool? tzzzzzzzq_ = context.Operators.In<CqlDateTime>(tzzzzzzzg_, tzzzzzzzp_, default);
                    CqlInterval<CqlDateTime> tzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzh_);
                    CqlDateTime tzzzzzzzt_ = context.Operators.Start(tzzzzzzzs_);
                    bool? tzzzzzzzu_ = context.Operators.Not((bool?)(tzzzzzzzt_ is null));
                    bool? tzzzzzzzv_ = context.Operators.And(tzzzzzzzq_, tzzzzzzzu_);
                    bool? tzzzzzzzw_ = context.Operators.And(tzzzzzzzd_, tzzzzzzzv_);

                    return tzzzzzzzw_;
                };
                IEnumerable<Encounter> gzzzzzzzh_ = context.Operators.Where<Encounter>(gzzzzzzzf_, gzzzzzzzg_);
                object gzzzzzzzi_(Encounter @this)
                {
                    Period tzzzzzzzx_ = @this?.Period;
                    CqlInterval<CqlDateTime> tzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzx_);
                    CqlDateTime tzzzzzzzz_ = context.Operators.End(tzzzzzzzy_);

                    return tzzzzzzzz_;
                };
                IEnumerable<Encounter> gzzzzzzzj_ = context.Operators.SortBy<Encounter>(gzzzzzzzh_, gzzzzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter gzzzzzzzk_ = context.Operators.Last<Encounter>(gzzzzzzzj_);
                Period gzzzzzzzl_ = gzzzzzzzk_?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzl_);
                CqlDateTime gzzzzzzzn_ = context.Operators.Start(gzzzzzzzm_);
                CqlInterval<CqlDateTime> gzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzp_);
                CqlDateTime gzzzzzzzq_ = context.Operators.Start(gzzzzzzzp_);
                CqlInterval<CqlDateTime> gzzzzzzzr_ = context.Operators.Interval(fzzzzzzzt_, gzzzzzzzd_ ?? gzzzzzzzn_ ?? gzzzzzzzq_, true, true);
                bool? gzzzzzzzs_ = context.Operators.In<CqlDateTime>(ezzzzzzzu_, gzzzzzzzr_, default);
                IEnumerable<Encounter> gzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? gzzzzzzzv_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> uzzzzzzza_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? uzzzzzzzb_ = uzzzzzzza_?.Value;
                    Code<Encounter.EncounterStatus> uzzzzzzzc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(uzzzzzzzb_);
                    bool? uzzzzzzzd_ = context.Operators.Equal(uzzzzzzzc_, "finished");
                    Period uzzzzzzze_ = LastED?.Period;
                    CqlInterval<CqlDateTime> uzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzze_);
                    CqlDateTime uzzzzzzzg_ = context.Operators.End(uzzzzzzzf_);
                    CqlValueSet uzzzzzzzh_ = this.Observation_Services(context);
                    IEnumerable<Encounter> uzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? uzzzzzzzj_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> wzzzzzzzb_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? wzzzzzzzc_ = wzzzzzzzb_?.Value;
                        Code<Encounter.EncounterStatus> wzzzzzzzd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(wzzzzzzzc_);
                        bool? wzzzzzzze_ = context.Operators.Equal(wzzzzzzzd_, "finished");
                        Period wzzzzzzzf_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> wzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzf_);
                        CqlDateTime wzzzzzzzh_ = context.Operators.End(wzzzzzzzg_);
                        Period wzzzzzzzi_ = Visit?.Period;
                        CqlInterval<CqlDateTime> wzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzi_);
                        CqlDateTime wzzzzzzzk_ = context.Operators.Start(wzzzzzzzj_);
                        CqlQuantity wzzzzzzzl_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime wzzzzzzzm_ = context.Operators.Subtract(wzzzzzzzk_, wzzzzzzzl_);
                        CqlInterval<CqlDateTime> wzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzi_);
                        CqlDateTime wzzzzzzzp_ = context.Operators.Start(wzzzzzzzo_);
                        CqlInterval<CqlDateTime> wzzzzzzzq_ = context.Operators.Interval(wzzzzzzzm_, wzzzzzzzp_, true, true);
                        bool? wzzzzzzzr_ = context.Operators.In<CqlDateTime>(wzzzzzzzh_, wzzzzzzzq_, default);
                        CqlInterval<CqlDateTime> wzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzi_);
                        CqlDateTime wzzzzzzzu_ = context.Operators.Start(wzzzzzzzt_);
                        bool? wzzzzzzzv_ = context.Operators.Not((bool?)(wzzzzzzzu_ is null));
                        bool? wzzzzzzzw_ = context.Operators.And(wzzzzzzzr_, wzzzzzzzv_);
                        bool? wzzzzzzzx_ = context.Operators.And(wzzzzzzze_, wzzzzzzzw_);

                        return wzzzzzzzx_;
                    };
                    IEnumerable<Encounter> uzzzzzzzk_ = context.Operators.Where<Encounter>(uzzzzzzzi_, uzzzzzzzj_);
                    object uzzzzzzzl_(Encounter @this)
                    {
                        Period wzzzzzzzy_ = @this?.Period;
                        CqlInterval<CqlDateTime> wzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzy_);
                        CqlDateTime xzzzzzzza_ = context.Operators.End(wzzzzzzzz_);

                        return xzzzzzzza_;
                    };
                    IEnumerable<Encounter> uzzzzzzzm_ = context.Operators.SortBy<Encounter>(uzzzzzzzk_, uzzzzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter uzzzzzzzn_ = context.Operators.Last<Encounter>(uzzzzzzzm_);
                    Period uzzzzzzzo_ = uzzzzzzzn_?.Period;
                    CqlInterval<CqlDateTime> uzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzo_);
                    CqlDateTime uzzzzzzzq_ = context.Operators.Start(uzzzzzzzp_);
                    Period uzzzzzzzr_ = Visit?.Period;
                    CqlInterval<CqlDateTime> uzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzr_);
                    CqlDateTime uzzzzzzzt_ = context.Operators.Start(uzzzzzzzs_);
                    CqlQuantity uzzzzzzzu_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime uzzzzzzzv_ = context.Operators.Subtract(uzzzzzzzq_ ?? uzzzzzzzt_, uzzzzzzzu_);
                    IEnumerable<Encounter> uzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? uzzzzzzzy_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> xzzzzzzzb_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? xzzzzzzzc_ = xzzzzzzzb_?.Value;
                        Code<Encounter.EncounterStatus> xzzzzzzzd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(xzzzzzzzc_);
                        bool? xzzzzzzze_ = context.Operators.Equal(xzzzzzzzd_, "finished");
                        Period xzzzzzzzf_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> xzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzf_);
                        CqlDateTime xzzzzzzzh_ = context.Operators.End(xzzzzzzzg_);
                        Period xzzzzzzzi_ = Visit?.Period;
                        CqlInterval<CqlDateTime> xzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzi_);
                        CqlDateTime xzzzzzzzk_ = context.Operators.Start(xzzzzzzzj_);
                        CqlQuantity xzzzzzzzl_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime xzzzzzzzm_ = context.Operators.Subtract(xzzzzzzzk_, xzzzzzzzl_);
                        CqlInterval<CqlDateTime> xzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzi_);
                        CqlDateTime xzzzzzzzp_ = context.Operators.Start(xzzzzzzzo_);
                        CqlInterval<CqlDateTime> xzzzzzzzq_ = context.Operators.Interval(xzzzzzzzm_, xzzzzzzzp_, true, true);
                        bool? xzzzzzzzr_ = context.Operators.In<CqlDateTime>(xzzzzzzzh_, xzzzzzzzq_, default);
                        CqlInterval<CqlDateTime> xzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzi_);
                        CqlDateTime xzzzzzzzu_ = context.Operators.Start(xzzzzzzzt_);
                        bool? xzzzzzzzv_ = context.Operators.Not((bool?)(xzzzzzzzu_ is null));
                        bool? xzzzzzzzw_ = context.Operators.And(xzzzzzzzr_, xzzzzzzzv_);
                        bool? xzzzzzzzx_ = context.Operators.And(xzzzzzzze_, xzzzzzzzw_);

                        return xzzzzzzzx_;
                    };
                    IEnumerable<Encounter> uzzzzzzzz_ = context.Operators.Where<Encounter>(uzzzzzzzx_, uzzzzzzzy_);
                    object vzzzzzzza_(Encounter @this)
                    {
                        Period xzzzzzzzy_ = @this?.Period;
                        CqlInterval<CqlDateTime> xzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzy_);
                        CqlDateTime yzzzzzzza_ = context.Operators.End(xzzzzzzzz_);

                        return yzzzzzzza_;
                    };
                    IEnumerable<Encounter> vzzzzzzzb_ = context.Operators.SortBy<Encounter>(uzzzzzzzz_, vzzzzzzza_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter vzzzzzzzc_ = context.Operators.Last<Encounter>(vzzzzzzzb_);
                    Period vzzzzzzzd_ = vzzzzzzzc_?.Period;
                    CqlInterval<CqlDateTime> vzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzd_);
                    CqlDateTime vzzzzzzzf_ = context.Operators.Start(vzzzzzzze_);
                    CqlInterval<CqlDateTime> vzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzr_);
                    CqlDateTime vzzzzzzzi_ = context.Operators.Start(vzzzzzzzh_);
                    CqlInterval<CqlDateTime> vzzzzzzzj_ = context.Operators.Interval(uzzzzzzzv_, vzzzzzzzf_ ?? vzzzzzzzi_, true, true);
                    bool? vzzzzzzzk_ = context.Operators.In<CqlDateTime>(uzzzzzzzg_, vzzzzzzzj_, default);
                    IEnumerable<Encounter> vzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? vzzzzzzzn_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> yzzzzzzzb_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? yzzzzzzzc_ = yzzzzzzzb_?.Value;
                        Code<Encounter.EncounterStatus> yzzzzzzzd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(yzzzzzzzc_);
                        bool? yzzzzzzze_ = context.Operators.Equal(yzzzzzzzd_, "finished");
                        Period yzzzzzzzf_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> yzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzf_);
                        CqlDateTime yzzzzzzzh_ = context.Operators.End(yzzzzzzzg_);
                        Period yzzzzzzzi_ = Visit?.Period;
                        CqlInterval<CqlDateTime> yzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzi_);
                        CqlDateTime yzzzzzzzk_ = context.Operators.Start(yzzzzzzzj_);
                        CqlQuantity yzzzzzzzl_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime yzzzzzzzm_ = context.Operators.Subtract(yzzzzzzzk_, yzzzzzzzl_);
                        CqlInterval<CqlDateTime> yzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzi_);
                        CqlDateTime yzzzzzzzp_ = context.Operators.Start(yzzzzzzzo_);
                        CqlInterval<CqlDateTime> yzzzzzzzq_ = context.Operators.Interval(yzzzzzzzm_, yzzzzzzzp_, true, true);
                        bool? yzzzzzzzr_ = context.Operators.In<CqlDateTime>(yzzzzzzzh_, yzzzzzzzq_, default);
                        CqlInterval<CqlDateTime> yzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzi_);
                        CqlDateTime yzzzzzzzu_ = context.Operators.Start(yzzzzzzzt_);
                        bool? yzzzzzzzv_ = context.Operators.Not((bool?)(yzzzzzzzu_ is null));
                        bool? yzzzzzzzw_ = context.Operators.And(yzzzzzzzr_, yzzzzzzzv_);
                        bool? yzzzzzzzx_ = context.Operators.And(yzzzzzzze_, yzzzzzzzw_);

                        return yzzzzzzzx_;
                    };
                    IEnumerable<Encounter> vzzzzzzzo_ = context.Operators.Where<Encounter>(vzzzzzzzm_, vzzzzzzzn_);
                    object vzzzzzzzp_(Encounter @this)
                    {
                        Period yzzzzzzzy_ = @this?.Period;
                        CqlInterval<CqlDateTime> yzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzy_);
                        CqlDateTime zzzzzzzza_ = context.Operators.End(yzzzzzzzz_);

                        return zzzzzzzza_;
                    };
                    IEnumerable<Encounter> vzzzzzzzq_ = context.Operators.SortBy<Encounter>(vzzzzzzzo_, vzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter vzzzzzzzr_ = context.Operators.Last<Encounter>(vzzzzzzzq_);
                    Period vzzzzzzzs_ = vzzzzzzzr_?.Period;
                    CqlInterval<CqlDateTime> vzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzs_);
                    CqlDateTime vzzzzzzzu_ = context.Operators.Start(vzzzzzzzt_);
                    CqlInterval<CqlDateTime> vzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzr_);
                    CqlDateTime vzzzzzzzx_ = context.Operators.Start(vzzzzzzzw_);
                    bool? vzzzzzzzy_ = context.Operators.Not((bool?)((vzzzzzzzu_ ?? vzzzzzzzx_) is null));
                    bool? vzzzzzzzz_ = context.Operators.And(vzzzzzzzk_, vzzzzzzzy_);
                    bool? wzzzzzzza_ = context.Operators.And(uzzzzzzzd_, vzzzzzzzz_);

                    return wzzzzzzza_;
                };
                IEnumerable<Encounter> gzzzzzzzw_ = context.Operators.Where<Encounter>(gzzzzzzzu_, gzzzzzzzv_);
                object gzzzzzzzx_(Encounter @this)
                {
                    Period zzzzzzzzb_ = @this?.Period;
                    CqlInterval<CqlDateTime> zzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzb_);
                    CqlDateTime zzzzzzzzd_ = context.Operators.End(zzzzzzzzc_);

                    return zzzzzzzzd_;
                };
                IEnumerable<Encounter> gzzzzzzzy_ = context.Operators.SortBy<Encounter>(gzzzzzzzw_, gzzzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter gzzzzzzzz_ = context.Operators.Last<Encounter>(gzzzzzzzy_);
                Period hzzzzzzza_ = gzzzzzzzz_?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzza_);
                CqlDateTime hzzzzzzzc_ = context.Operators.Start(hzzzzzzzb_);
                IEnumerable<Encounter> hzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? hzzzzzzzf_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> zzzzzzzze_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? zzzzzzzzf_ = zzzzzzzze_?.Value;
                    Code<Encounter.EncounterStatus> zzzzzzzzg_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(zzzzzzzzf_);
                    bool? zzzzzzzzh_ = context.Operators.Equal(zzzzzzzzg_, "finished");
                    Period zzzzzzzzi_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> zzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzi_);
                    CqlDateTime zzzzzzzzk_ = context.Operators.End(zzzzzzzzj_);
                    Period zzzzzzzzl_ = Visit?.Period;
                    CqlInterval<CqlDateTime> zzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzl_);
                    CqlDateTime zzzzzzzzn_ = context.Operators.Start(zzzzzzzzm_);
                    CqlQuantity zzzzzzzzo_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime zzzzzzzzp_ = context.Operators.Subtract(zzzzzzzzn_, zzzzzzzzo_);
                    CqlInterval<CqlDateTime> zzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzl_);
                    CqlDateTime zzzzzzzzs_ = context.Operators.Start(zzzzzzzzr_);
                    CqlInterval<CqlDateTime> zzzzzzzzt_ = context.Operators.Interval(zzzzzzzzp_, zzzzzzzzs_, true, true);
                    bool? zzzzzzzzu_ = context.Operators.In<CqlDateTime>(zzzzzzzzk_, zzzzzzzzt_, default);
                    CqlInterval<CqlDateTime> zzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzl_);
                    CqlDateTime zzzzzzzzx_ = context.Operators.Start(zzzzzzzzw_);
                    bool? zzzzzzzzy_ = context.Operators.Not((bool?)(zzzzzzzzx_ is null));
                    bool? zzzzzzzzz_ = context.Operators.And(zzzzzzzzu_, zzzzzzzzy_);
                    bool? azzzzzzzza_ = context.Operators.And(zzzzzzzzh_, zzzzzzzzz_);

                    return azzzzzzzza_;
                };
                IEnumerable<Encounter> hzzzzzzzg_ = context.Operators.Where<Encounter>(hzzzzzzze_, hzzzzzzzf_);
                object hzzzzzzzh_(Encounter @this)
                {
                    Period azzzzzzzzb_ = @this?.Period;
                    CqlInterval<CqlDateTime> azzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzb_);
                    CqlDateTime azzzzzzzzd_ = context.Operators.End(azzzzzzzzc_);

                    return azzzzzzzzd_;
                };
                IEnumerable<Encounter> hzzzzzzzi_ = context.Operators.SortBy<Encounter>(hzzzzzzzg_, hzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter hzzzzzzzj_ = context.Operators.Last<Encounter>(hzzzzzzzi_);
                Period hzzzzzzzk_ = hzzzzzzzj_?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzk_);
                CqlDateTime hzzzzzzzm_ = context.Operators.Start(hzzzzzzzl_);
                CqlInterval<CqlDateTime> hzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzp_);
                CqlDateTime hzzzzzzzp_ = context.Operators.Start(hzzzzzzzo_);
                bool? hzzzzzzzq_ = context.Operators.Not((bool?)((hzzzzzzzc_ ?? hzzzzzzzm_ ?? hzzzzzzzp_) is null));
                bool? hzzzzzzzr_ = context.Operators.And(gzzzzzzzs_, hzzzzzzzq_);

                return hzzzzzzzr_;
            };
            IEnumerable<Encounter> dzzzzzzzk_ = context.Operators.Where<Encounter>(dzzzzzzzi_, dzzzzzzzj_);
            object dzzzzzzzl_(Encounter @this)
            {
                Period azzzzzzzze_ = @this?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzze_);
                CqlDateTime azzzzzzzzg_ = context.Operators.End(azzzzzzzzf_);

                return azzzzzzzzg_;
            };
            IEnumerable<Encounter> dzzzzzzzm_ = context.Operators.SortBy<Encounter>(dzzzzzzzk_, dzzzzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter dzzzzzzzn_ = context.Operators.Last<Encounter>(dzzzzzzzm_);
            Period dzzzzzzzo_ = dzzzzzzzn_?.Period;
            CqlInterval<CqlDateTime> dzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzo_);
            CqlDateTime dzzzzzzzq_ = context.Operators.Start(dzzzzzzzp_);
            CqlValueSet dzzzzzzzr_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> dzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? dzzzzzzzt_(Encounter LastED)
            {
                Code<Encounter.EncounterStatus> azzzzzzzzh_ = LastED?.StatusElement;
                Encounter.EncounterStatus? azzzzzzzzi_ = azzzzzzzzh_?.Value;
                Code<Encounter.EncounterStatus> azzzzzzzzj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(azzzzzzzzi_);
                bool? azzzzzzzzk_ = context.Operators.Equal(azzzzzzzzj_, "finished");
                Period azzzzzzzzl_ = LastED?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzl_);
                CqlDateTime azzzzzzzzn_ = context.Operators.End(azzzzzzzzm_);
                CqlValueSet azzzzzzzzo_ = this.Observation_Services(context);
                IEnumerable<Encounter> azzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? azzzzzzzzq_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> czzzzzzzzi_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? czzzzzzzzj_ = czzzzzzzzi_?.Value;
                    Code<Encounter.EncounterStatus> czzzzzzzzk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(czzzzzzzzj_);
                    bool? czzzzzzzzl_ = context.Operators.Equal(czzzzzzzzk_, "finished");
                    Period czzzzzzzzm_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> czzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzm_);
                    CqlDateTime czzzzzzzzo_ = context.Operators.End(czzzzzzzzn_);
                    Period czzzzzzzzp_ = Visit?.Period;
                    CqlInterval<CqlDateTime> czzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzp_);
                    CqlDateTime czzzzzzzzr_ = context.Operators.Start(czzzzzzzzq_);
                    CqlQuantity czzzzzzzzs_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime czzzzzzzzt_ = context.Operators.Subtract(czzzzzzzzr_, czzzzzzzzs_);
                    CqlInterval<CqlDateTime> czzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzp_);
                    CqlDateTime czzzzzzzzw_ = context.Operators.Start(czzzzzzzzv_);
                    CqlInterval<CqlDateTime> czzzzzzzzx_ = context.Operators.Interval(czzzzzzzzt_, czzzzzzzzw_, true, true);
                    bool? czzzzzzzzy_ = context.Operators.In<CqlDateTime>(czzzzzzzzo_, czzzzzzzzx_, default);
                    CqlInterval<CqlDateTime> dzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzp_);
                    CqlDateTime dzzzzzzzzb_ = context.Operators.Start(dzzzzzzzza_);
                    bool? dzzzzzzzzc_ = context.Operators.Not((bool?)(dzzzzzzzzb_ is null));
                    bool? dzzzzzzzzd_ = context.Operators.And(czzzzzzzzy_, dzzzzzzzzc_);
                    bool? dzzzzzzzze_ = context.Operators.And(czzzzzzzzl_, dzzzzzzzzd_);

                    return dzzzzzzzze_;
                };
                IEnumerable<Encounter> azzzzzzzzr_ = context.Operators.Where<Encounter>(azzzzzzzzp_, azzzzzzzzq_);
                object azzzzzzzzs_(Encounter @this)
                {
                    Period dzzzzzzzzf_ = @this?.Period;
                    CqlInterval<CqlDateTime> dzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzf_);
                    CqlDateTime dzzzzzzzzh_ = context.Operators.End(dzzzzzzzzg_);

                    return dzzzzzzzzh_;
                };
                IEnumerable<Encounter> azzzzzzzzt_ = context.Operators.SortBy<Encounter>(azzzzzzzzr_, azzzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter azzzzzzzzu_ = context.Operators.Last<Encounter>(azzzzzzzzt_);
                Period azzzzzzzzv_ = azzzzzzzzu_?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzv_);
                CqlDateTime azzzzzzzzx_ = context.Operators.Start(azzzzzzzzw_);
                Period azzzzzzzzy_ = Visit?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzy_);
                CqlDateTime bzzzzzzzza_ = context.Operators.Start(azzzzzzzzz_);
                CqlQuantity bzzzzzzzzb_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime bzzzzzzzzc_ = context.Operators.Subtract(azzzzzzzzx_ ?? bzzzzzzzza_, bzzzzzzzzb_);
                IEnumerable<Encounter> bzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? bzzzzzzzzf_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> dzzzzzzzzi_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? dzzzzzzzzj_ = dzzzzzzzzi_?.Value;
                    Code<Encounter.EncounterStatus> dzzzzzzzzk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dzzzzzzzzj_);
                    bool? dzzzzzzzzl_ = context.Operators.Equal(dzzzzzzzzk_, "finished");
                    Period dzzzzzzzzm_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> dzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzm_);
                    CqlDateTime dzzzzzzzzo_ = context.Operators.End(dzzzzzzzzn_);
                    Period dzzzzzzzzp_ = Visit?.Period;
                    CqlInterval<CqlDateTime> dzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzp_);
                    CqlDateTime dzzzzzzzzr_ = context.Operators.Start(dzzzzzzzzq_);
                    CqlQuantity dzzzzzzzzs_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime dzzzzzzzzt_ = context.Operators.Subtract(dzzzzzzzzr_, dzzzzzzzzs_);
                    CqlInterval<CqlDateTime> dzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzp_);
                    CqlDateTime dzzzzzzzzw_ = context.Operators.Start(dzzzzzzzzv_);
                    CqlInterval<CqlDateTime> dzzzzzzzzx_ = context.Operators.Interval(dzzzzzzzzt_, dzzzzzzzzw_, true, true);
                    bool? dzzzzzzzzy_ = context.Operators.In<CqlDateTime>(dzzzzzzzzo_, dzzzzzzzzx_, default);
                    CqlInterval<CqlDateTime> ezzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzp_);
                    CqlDateTime ezzzzzzzzb_ = context.Operators.Start(ezzzzzzzza_);
                    bool? ezzzzzzzzc_ = context.Operators.Not((bool?)(ezzzzzzzzb_ is null));
                    bool? ezzzzzzzzd_ = context.Operators.And(dzzzzzzzzy_, ezzzzzzzzc_);
                    bool? ezzzzzzzze_ = context.Operators.And(dzzzzzzzzl_, ezzzzzzzzd_);

                    return ezzzzzzzze_;
                };
                IEnumerable<Encounter> bzzzzzzzzg_ = context.Operators.Where<Encounter>(bzzzzzzzze_, bzzzzzzzzf_);
                object bzzzzzzzzh_(Encounter @this)
                {
                    Period ezzzzzzzzf_ = @this?.Period;
                    CqlInterval<CqlDateTime> ezzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzf_);
                    CqlDateTime ezzzzzzzzh_ = context.Operators.End(ezzzzzzzzg_);

                    return ezzzzzzzzh_;
                };
                IEnumerable<Encounter> bzzzzzzzzi_ = context.Operators.SortBy<Encounter>(bzzzzzzzzg_, bzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bzzzzzzzzj_ = context.Operators.Last<Encounter>(bzzzzzzzzi_);
                Period bzzzzzzzzk_ = bzzzzzzzzj_?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzk_);
                CqlDateTime bzzzzzzzzm_ = context.Operators.Start(bzzzzzzzzl_);
                CqlInterval<CqlDateTime> bzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzy_);
                CqlDateTime bzzzzzzzzp_ = context.Operators.Start(bzzzzzzzzo_);
                CqlInterval<CqlDateTime> bzzzzzzzzq_ = context.Operators.Interval(bzzzzzzzzc_, bzzzzzzzzm_ ?? bzzzzzzzzp_, true, true);
                bool? bzzzzzzzzr_ = context.Operators.In<CqlDateTime>(azzzzzzzzn_, bzzzzzzzzq_, default);
                IEnumerable<Encounter> bzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? bzzzzzzzzu_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> ezzzzzzzzi_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? ezzzzzzzzj_ = ezzzzzzzzi_?.Value;
                    Code<Encounter.EncounterStatus> ezzzzzzzzk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ezzzzzzzzj_);
                    bool? ezzzzzzzzl_ = context.Operators.Equal(ezzzzzzzzk_, "finished");
                    Period ezzzzzzzzm_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> ezzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzm_);
                    CqlDateTime ezzzzzzzzo_ = context.Operators.End(ezzzzzzzzn_);
                    Period ezzzzzzzzp_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ezzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzp_);
                    CqlDateTime ezzzzzzzzr_ = context.Operators.Start(ezzzzzzzzq_);
                    CqlQuantity ezzzzzzzzs_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ezzzzzzzzt_ = context.Operators.Subtract(ezzzzzzzzr_, ezzzzzzzzs_);
                    CqlInterval<CqlDateTime> ezzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzp_);
                    CqlDateTime ezzzzzzzzw_ = context.Operators.Start(ezzzzzzzzv_);
                    CqlInterval<CqlDateTime> ezzzzzzzzx_ = context.Operators.Interval(ezzzzzzzzt_, ezzzzzzzzw_, true, true);
                    bool? ezzzzzzzzy_ = context.Operators.In<CqlDateTime>(ezzzzzzzzo_, ezzzzzzzzx_, default);
                    CqlInterval<CqlDateTime> fzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzp_);
                    CqlDateTime fzzzzzzzzb_ = context.Operators.Start(fzzzzzzzza_);
                    bool? fzzzzzzzzc_ = context.Operators.Not((bool?)(fzzzzzzzzb_ is null));
                    bool? fzzzzzzzzd_ = context.Operators.And(ezzzzzzzzy_, fzzzzzzzzc_);
                    bool? fzzzzzzzze_ = context.Operators.And(ezzzzzzzzl_, fzzzzzzzzd_);

                    return fzzzzzzzze_;
                };
                IEnumerable<Encounter> bzzzzzzzzv_ = context.Operators.Where<Encounter>(bzzzzzzzzt_, bzzzzzzzzu_);
                object bzzzzzzzzw_(Encounter @this)
                {
                    Period fzzzzzzzzf_ = @this?.Period;
                    CqlInterval<CqlDateTime> fzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzf_);
                    CqlDateTime fzzzzzzzzh_ = context.Operators.End(fzzzzzzzzg_);

                    return fzzzzzzzzh_;
                };
                IEnumerable<Encounter> bzzzzzzzzx_ = context.Operators.SortBy<Encounter>(bzzzzzzzzv_, bzzzzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bzzzzzzzzy_ = context.Operators.Last<Encounter>(bzzzzzzzzx_);
                Period bzzzzzzzzz_ = bzzzzzzzzy_?.Period;
                CqlInterval<CqlDateTime> czzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzz_);
                CqlDateTime czzzzzzzzb_ = context.Operators.Start(czzzzzzzza_);
                CqlInterval<CqlDateTime> czzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzy_);
                CqlDateTime czzzzzzzze_ = context.Operators.Start(czzzzzzzzd_);
                bool? czzzzzzzzf_ = context.Operators.Not((bool?)((czzzzzzzzb_ ?? czzzzzzzze_) is null));
                bool? czzzzzzzzg_ = context.Operators.And(bzzzzzzzzr_, czzzzzzzzf_);
                bool? czzzzzzzzh_ = context.Operators.And(azzzzzzzzk_, czzzzzzzzg_);

                return czzzzzzzzh_;
            };
            IEnumerable<Encounter> dzzzzzzzu_ = context.Operators.Where<Encounter>(dzzzzzzzs_, dzzzzzzzt_);
            object dzzzzzzzv_(Encounter @this)
            {
                Period fzzzzzzzzi_ = @this?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzi_);
                CqlDateTime fzzzzzzzzk_ = context.Operators.End(fzzzzzzzzj_);

                return fzzzzzzzzk_;
            };
            IEnumerable<Encounter> dzzzzzzzw_ = context.Operators.SortBy<Encounter>(dzzzzzzzu_, dzzzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter dzzzzzzzx_ = context.Operators.Last<Encounter>(dzzzzzzzw_);
            Period dzzzzzzzy_ = dzzzzzzzx_?.Period;
            CqlInterval<CqlDateTime> dzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzy_);
            CqlDateTime ezzzzzzza_ = context.Operators.Start(dzzzzzzzz_);
            CqlValueSet ezzzzzzzb_ = this.Observation_Services(context);
            IEnumerable<Encounter> ezzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? ezzzzzzzd_(Encounter LastObs)
            {
                Code<Encounter.EncounterStatus> fzzzzzzzzl_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? fzzzzzzzzm_ = fzzzzzzzzl_?.Value;
                Code<Encounter.EncounterStatus> fzzzzzzzzn_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fzzzzzzzzm_);
                bool? fzzzzzzzzo_ = context.Operators.Equal(fzzzzzzzzn_, "finished");
                Period fzzzzzzzzp_ = LastObs?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzp_);
                CqlDateTime fzzzzzzzzr_ = context.Operators.End(fzzzzzzzzq_);
                Period fzzzzzzzzs_ = Visit?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzs_);
                CqlDateTime fzzzzzzzzu_ = context.Operators.Start(fzzzzzzzzt_);
                CqlQuantity fzzzzzzzzv_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime fzzzzzzzzw_ = context.Operators.Subtract(fzzzzzzzzu_, fzzzzzzzzv_);
                CqlInterval<CqlDateTime> fzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzs_);
                CqlDateTime fzzzzzzzzz_ = context.Operators.Start(fzzzzzzzzy_);
                CqlInterval<CqlDateTime> gzzzzzzzza_ = context.Operators.Interval(fzzzzzzzzw_, fzzzzzzzzz_, true, true);
                bool? gzzzzzzzzb_ = context.Operators.In<CqlDateTime>(fzzzzzzzzr_, gzzzzzzzza_, default);
                CqlInterval<CqlDateTime> gzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzs_);
                CqlDateTime gzzzzzzzze_ = context.Operators.Start(gzzzzzzzzd_);
                bool? gzzzzzzzzf_ = context.Operators.Not((bool?)(gzzzzzzzze_ is null));
                bool? gzzzzzzzzg_ = context.Operators.And(gzzzzzzzzb_, gzzzzzzzzf_);
                bool? gzzzzzzzzh_ = context.Operators.And(fzzzzzzzzo_, gzzzzzzzzg_);

                return gzzzzzzzzh_;
            };
            IEnumerable<Encounter> ezzzzzzze_ = context.Operators.Where<Encounter>(ezzzzzzzc_, ezzzzzzzd_);
            object ezzzzzzzf_(Encounter @this)
            {
                Period gzzzzzzzzi_ = @this?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzi_);
                CqlDateTime gzzzzzzzzk_ = context.Operators.End(gzzzzzzzzj_);

                return gzzzzzzzzk_;
            };
            IEnumerable<Encounter> ezzzzzzzg_ = context.Operators.SortBy<Encounter>(ezzzzzzze_, ezzzzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter ezzzzzzzh_ = context.Operators.Last<Encounter>(ezzzzzzzg_);
            Period ezzzzzzzi_ = ezzzzzzzh_?.Period;
            CqlInterval<CqlDateTime> ezzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzi_);
            CqlDateTime ezzzzzzzk_ = context.Operators.Start(ezzzzzzzj_);
            Period ezzzzzzzl_ = Visit?.Period;
            CqlInterval<CqlDateTime> ezzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzl_);
            CqlDateTime ezzzzzzzn_ = context.Operators.Start(ezzzzzzzm_);
            CqlInterval<CqlDateTime> ezzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzl_);
            CqlDateTime ezzzzzzzq_ = context.Operators.End(ezzzzzzzp_);
            CqlInterval<CqlDateTime> ezzzzzzzr_ = context.Operators.Interval(dzzzzzzzq_ ?? ezzzzzzza_ ?? ezzzzzzzk_ ?? ezzzzzzzn_, ezzzzzzzq_, true, true);

            return ezzzzzzzr_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> dzzzzzzze_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)dzzzzzzzc_, dzzzzzzzd_);
        IEnumerable<CqlInterval<CqlDateTime>> dzzzzzzzf_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(dzzzzzzze_);
        CqlInterval<CqlDateTime> dzzzzzzzg_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(dzzzzzzzf_);

        return dzzzzzzzg_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservation")]
    [CqlTag("description", "Hospitalization with Observation returns the total interval from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationWithObservation()` instead.")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] gzzzzzzzzl_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> gzzzzzzzzm_(Encounter Visit)
        {
            CqlValueSet gzzzzzzzzq_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> gzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? gzzzzzzzzs_(Encounter LastED)
            {
                Code<Encounter.EncounterStatus> hzzzzzzzzr_ = LastED?.StatusElement;
                Encounter.EncounterStatus? hzzzzzzzzs_ = hzzzzzzzzr_?.Value;
                Code<Encounter.EncounterStatus> hzzzzzzzzt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hzzzzzzzzs_);
                bool? hzzzzzzzzu_ = context.Operators.Equal(hzzzzzzzzt_, "finished");
                Period hzzzzzzzzv_ = LastED?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzv_);
                CqlDateTime hzzzzzzzzx_ = context.Operators.End(hzzzzzzzzw_);
                CqlValueSet hzzzzzzzzy_ = this.Observation_Services(context);
                IEnumerable<Encounter> hzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? izzzzzzzza_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> jzzzzzzzzs_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? jzzzzzzzzt_ = jzzzzzzzzs_?.Value;
                    Code<Encounter.EncounterStatus> jzzzzzzzzu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jzzzzzzzzt_);
                    bool? jzzzzzzzzv_ = context.Operators.Equal(jzzzzzzzzu_, "finished");
                    Period jzzzzzzzzw_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzw_);
                    CqlDateTime jzzzzzzzzy_ = context.Operators.End(jzzzzzzzzx_);
                    Period jzzzzzzzzz_ = Visit?.Period;
                    CqlInterval<CqlDateTime> kzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzz_);
                    CqlDateTime kzzzzzzzzb_ = context.Operators.Start(kzzzzzzzza_);
                    CqlQuantity kzzzzzzzzc_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime kzzzzzzzzd_ = context.Operators.Subtract(kzzzzzzzzb_, kzzzzzzzzc_);
                    CqlInterval<CqlDateTime> kzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzz_);
                    CqlDateTime kzzzzzzzzg_ = context.Operators.Start(kzzzzzzzzf_);
                    CqlInterval<CqlDateTime> kzzzzzzzzh_ = context.Operators.Interval(kzzzzzzzzd_, kzzzzzzzzg_, true, true);
                    bool? kzzzzzzzzi_ = context.Operators.In<CqlDateTime>(jzzzzzzzzy_, kzzzzzzzzh_, default);
                    CqlInterval<CqlDateTime> kzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzz_);
                    CqlDateTime kzzzzzzzzl_ = context.Operators.Start(kzzzzzzzzk_);
                    bool? kzzzzzzzzm_ = context.Operators.Not((bool?)(kzzzzzzzzl_ is null));
                    bool? kzzzzzzzzn_ = context.Operators.And(kzzzzzzzzi_, kzzzzzzzzm_);
                    bool? kzzzzzzzzo_ = context.Operators.And(jzzzzzzzzv_, kzzzzzzzzn_);

                    return kzzzzzzzzo_;
                };
                IEnumerable<Encounter> izzzzzzzzb_ = context.Operators.Where<Encounter>(hzzzzzzzzz_, izzzzzzzza_);
                object izzzzzzzzc_(Encounter @this)
                {
                    Period kzzzzzzzzp_ = @this?.Period;
                    CqlInterval<CqlDateTime> kzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzp_);
                    CqlDateTime kzzzzzzzzr_ = context.Operators.End(kzzzzzzzzq_);

                    return kzzzzzzzzr_;
                };
                IEnumerable<Encounter> izzzzzzzzd_ = context.Operators.SortBy<Encounter>(izzzzzzzzb_, izzzzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter izzzzzzzze_ = context.Operators.Last<Encounter>(izzzzzzzzd_);
                Period izzzzzzzzf_ = izzzzzzzze_?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzf_);
                CqlDateTime izzzzzzzzh_ = context.Operators.Start(izzzzzzzzg_);
                Period izzzzzzzzi_ = Visit?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzi_);
                CqlDateTime izzzzzzzzk_ = context.Operators.Start(izzzzzzzzj_);
                CqlQuantity izzzzzzzzl_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime izzzzzzzzm_ = context.Operators.Subtract(izzzzzzzzh_ ?? izzzzzzzzk_, izzzzzzzzl_);
                IEnumerable<Encounter> izzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? izzzzzzzzp_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> kzzzzzzzzs_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? kzzzzzzzzt_ = kzzzzzzzzs_?.Value;
                    Code<Encounter.EncounterStatus> kzzzzzzzzu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(kzzzzzzzzt_);
                    bool? kzzzzzzzzv_ = context.Operators.Equal(kzzzzzzzzu_, "finished");
                    Period kzzzzzzzzw_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> kzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzw_);
                    CqlDateTime kzzzzzzzzy_ = context.Operators.End(kzzzzzzzzx_);
                    Period kzzzzzzzzz_ = Visit?.Period;
                    CqlInterval<CqlDateTime> lzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzz_);
                    CqlDateTime lzzzzzzzzb_ = context.Operators.Start(lzzzzzzzza_);
                    CqlQuantity lzzzzzzzzc_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime lzzzzzzzzd_ = context.Operators.Subtract(lzzzzzzzzb_, lzzzzzzzzc_);
                    CqlInterval<CqlDateTime> lzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzz_);
                    CqlDateTime lzzzzzzzzg_ = context.Operators.Start(lzzzzzzzzf_);
                    CqlInterval<CqlDateTime> lzzzzzzzzh_ = context.Operators.Interval(lzzzzzzzzd_, lzzzzzzzzg_, true, true);
                    bool? lzzzzzzzzi_ = context.Operators.In<CqlDateTime>(kzzzzzzzzy_, lzzzzzzzzh_, default);
                    CqlInterval<CqlDateTime> lzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzz_);
                    CqlDateTime lzzzzzzzzl_ = context.Operators.Start(lzzzzzzzzk_);
                    bool? lzzzzzzzzm_ = context.Operators.Not((bool?)(lzzzzzzzzl_ is null));
                    bool? lzzzzzzzzn_ = context.Operators.And(lzzzzzzzzi_, lzzzzzzzzm_);
                    bool? lzzzzzzzzo_ = context.Operators.And(kzzzzzzzzv_, lzzzzzzzzn_);

                    return lzzzzzzzzo_;
                };
                IEnumerable<Encounter> izzzzzzzzq_ = context.Operators.Where<Encounter>(izzzzzzzzo_, izzzzzzzzp_);
                object izzzzzzzzr_(Encounter @this)
                {
                    Period lzzzzzzzzp_ = @this?.Period;
                    CqlInterval<CqlDateTime> lzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzp_);
                    CqlDateTime lzzzzzzzzr_ = context.Operators.End(lzzzzzzzzq_);

                    return lzzzzzzzzr_;
                };
                IEnumerable<Encounter> izzzzzzzzs_ = context.Operators.SortBy<Encounter>(izzzzzzzzq_, izzzzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter izzzzzzzzt_ = context.Operators.Last<Encounter>(izzzzzzzzs_);
                Period izzzzzzzzu_ = izzzzzzzzt_?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzu_);
                CqlDateTime izzzzzzzzw_ = context.Operators.Start(izzzzzzzzv_);
                CqlInterval<CqlDateTime> izzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzi_);
                CqlDateTime izzzzzzzzz_ = context.Operators.Start(izzzzzzzzy_);
                CqlInterval<CqlDateTime> jzzzzzzzza_ = context.Operators.Interval(izzzzzzzzm_, izzzzzzzzw_ ?? izzzzzzzzz_, true, true);
                bool? jzzzzzzzzb_ = context.Operators.In<CqlDateTime>(hzzzzzzzzx_, jzzzzzzzza_, default);
                IEnumerable<Encounter> jzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? jzzzzzzzze_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> lzzzzzzzzs_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? lzzzzzzzzt_ = lzzzzzzzzs_?.Value;
                    Code<Encounter.EncounterStatus> lzzzzzzzzu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lzzzzzzzzt_);
                    bool? lzzzzzzzzv_ = context.Operators.Equal(lzzzzzzzzu_, "finished");
                    Period lzzzzzzzzw_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> lzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzw_);
                    CqlDateTime lzzzzzzzzy_ = context.Operators.End(lzzzzzzzzx_);
                    Period lzzzzzzzzz_ = Visit?.Period;
                    CqlInterval<CqlDateTime> mzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzz_);
                    CqlDateTime mzzzzzzzzb_ = context.Operators.Start(mzzzzzzzza_);
                    CqlQuantity mzzzzzzzzc_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime mzzzzzzzzd_ = context.Operators.Subtract(mzzzzzzzzb_, mzzzzzzzzc_);
                    CqlInterval<CqlDateTime> mzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzz_);
                    CqlDateTime mzzzzzzzzg_ = context.Operators.Start(mzzzzzzzzf_);
                    CqlInterval<CqlDateTime> mzzzzzzzzh_ = context.Operators.Interval(mzzzzzzzzd_, mzzzzzzzzg_, true, true);
                    bool? mzzzzzzzzi_ = context.Operators.In<CqlDateTime>(lzzzzzzzzy_, mzzzzzzzzh_, default);
                    CqlInterval<CqlDateTime> mzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzz_);
                    CqlDateTime mzzzzzzzzl_ = context.Operators.Start(mzzzzzzzzk_);
                    bool? mzzzzzzzzm_ = context.Operators.Not((bool?)(mzzzzzzzzl_ is null));
                    bool? mzzzzzzzzn_ = context.Operators.And(mzzzzzzzzi_, mzzzzzzzzm_);
                    bool? mzzzzzzzzo_ = context.Operators.And(lzzzzzzzzv_, mzzzzzzzzn_);

                    return mzzzzzzzzo_;
                };
                IEnumerable<Encounter> jzzzzzzzzf_ = context.Operators.Where<Encounter>(jzzzzzzzzd_, jzzzzzzzze_);
                object jzzzzzzzzg_(Encounter @this)
                {
                    Period mzzzzzzzzp_ = @this?.Period;
                    CqlInterval<CqlDateTime> mzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzp_);
                    CqlDateTime mzzzzzzzzr_ = context.Operators.End(mzzzzzzzzq_);

                    return mzzzzzzzzr_;
                };
                IEnumerable<Encounter> jzzzzzzzzh_ = context.Operators.SortBy<Encounter>(jzzzzzzzzf_, jzzzzzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter jzzzzzzzzi_ = context.Operators.Last<Encounter>(jzzzzzzzzh_);
                Period jzzzzzzzzj_ = jzzzzzzzzi_?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzj_);
                CqlDateTime jzzzzzzzzl_ = context.Operators.Start(jzzzzzzzzk_);
                CqlInterval<CqlDateTime> jzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzi_);
                CqlDateTime jzzzzzzzzo_ = context.Operators.Start(jzzzzzzzzn_);
                bool? jzzzzzzzzp_ = context.Operators.Not((bool?)((jzzzzzzzzl_ ?? jzzzzzzzzo_) is null));
                bool? jzzzzzzzzq_ = context.Operators.And(jzzzzzzzzb_, jzzzzzzzzp_);
                bool? jzzzzzzzzr_ = context.Operators.And(hzzzzzzzzu_, jzzzzzzzzq_);

                return jzzzzzzzzr_;
            };
            IEnumerable<Encounter> gzzzzzzzzt_ = context.Operators.Where<Encounter>(gzzzzzzzzr_, gzzzzzzzzs_);
            object gzzzzzzzzu_(Encounter @this)
            {
                Period mzzzzzzzzs_ = @this?.Period;
                CqlInterval<CqlDateTime> mzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzs_);
                CqlDateTime mzzzzzzzzu_ = context.Operators.End(mzzzzzzzzt_);

                return mzzzzzzzzu_;
            };
            IEnumerable<Encounter> gzzzzzzzzv_ = context.Operators.SortBy<Encounter>(gzzzzzzzzt_, gzzzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter gzzzzzzzzw_ = context.Operators.Last<Encounter>(gzzzzzzzzv_);
            Period gzzzzzzzzx_ = gzzzzzzzzw_?.Period;
            CqlInterval<CqlDateTime> gzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzx_);
            CqlDateTime gzzzzzzzzz_ = context.Operators.Start(gzzzzzzzzy_);
            CqlValueSet hzzzzzzzza_ = this.Observation_Services(context);
            IEnumerable<Encounter> hzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? hzzzzzzzzc_(Encounter LastObs)
            {
                Code<Encounter.EncounterStatus> mzzzzzzzzv_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? mzzzzzzzzw_ = mzzzzzzzzv_?.Value;
                Code<Encounter.EncounterStatus> mzzzzzzzzx_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(mzzzzzzzzw_);
                bool? mzzzzzzzzy_ = context.Operators.Equal(mzzzzzzzzx_, "finished");
                Period mzzzzzzzzz_ = LastObs?.Period;
                CqlInterval<CqlDateTime> nzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzz_);
                CqlDateTime nzzzzzzzzb_ = context.Operators.End(nzzzzzzzza_);
                Period nzzzzzzzzc_ = Visit?.Period;
                CqlInterval<CqlDateTime> nzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzc_);
                CqlDateTime nzzzzzzzze_ = context.Operators.Start(nzzzzzzzzd_);
                CqlQuantity nzzzzzzzzf_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime nzzzzzzzzg_ = context.Operators.Subtract(nzzzzzzzze_, nzzzzzzzzf_);
                CqlInterval<CqlDateTime> nzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzc_);
                CqlDateTime nzzzzzzzzj_ = context.Operators.Start(nzzzzzzzzi_);
                CqlInterval<CqlDateTime> nzzzzzzzzk_ = context.Operators.Interval(nzzzzzzzzg_, nzzzzzzzzj_, true, true);
                bool? nzzzzzzzzl_ = context.Operators.In<CqlDateTime>(nzzzzzzzzb_, nzzzzzzzzk_, default);
                CqlInterval<CqlDateTime> nzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzc_);
                CqlDateTime nzzzzzzzzo_ = context.Operators.Start(nzzzzzzzzn_);
                bool? nzzzzzzzzp_ = context.Operators.Not((bool?)(nzzzzzzzzo_ is null));
                bool? nzzzzzzzzq_ = context.Operators.And(nzzzzzzzzl_, nzzzzzzzzp_);
                bool? nzzzzzzzzr_ = context.Operators.And(mzzzzzzzzy_, nzzzzzzzzq_);

                return nzzzzzzzzr_;
            };
            IEnumerable<Encounter> hzzzzzzzzd_ = context.Operators.Where<Encounter>(hzzzzzzzzb_, hzzzzzzzzc_);
            object hzzzzzzzze_(Encounter @this)
            {
                Period nzzzzzzzzs_ = @this?.Period;
                CqlInterval<CqlDateTime> nzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzs_);
                CqlDateTime nzzzzzzzzu_ = context.Operators.End(nzzzzzzzzt_);

                return nzzzzzzzzu_;
            };
            IEnumerable<Encounter> hzzzzzzzzf_ = context.Operators.SortBy<Encounter>(hzzzzzzzzd_, hzzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter hzzzzzzzzg_ = context.Operators.Last<Encounter>(hzzzzzzzzf_);
            Period hzzzzzzzzh_ = hzzzzzzzzg_?.Period;
            CqlInterval<CqlDateTime> hzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzh_);
            CqlDateTime hzzzzzzzzj_ = context.Operators.Start(hzzzzzzzzi_);
            Period hzzzzzzzzk_ = Visit?.Period;
            CqlInterval<CqlDateTime> hzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzk_);
            CqlDateTime hzzzzzzzzm_ = context.Operators.Start(hzzzzzzzzl_);
            CqlInterval<CqlDateTime> hzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzk_);
            CqlDateTime hzzzzzzzzp_ = context.Operators.End(hzzzzzzzzo_);
            CqlInterval<CqlDateTime> hzzzzzzzzq_ = context.Operators.Interval(gzzzzzzzzz_ ?? hzzzzzzzzj_ ?? hzzzzzzzzm_, hzzzzzzzzp_, true, true);

            return hzzzzzzzzq_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> gzzzzzzzzn_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)gzzzzzzzzl_, gzzzzzzzzm_);
        IEnumerable<CqlInterval<CqlDateTime>> gzzzzzzzzo_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(gzzzzzzzzn_);
        CqlInterval<CqlDateTime> gzzzzzzzzp_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(gzzzzzzzzo_);

        return gzzzzzzzzp_;
    }


    [CqlExpressionDefinition("hospitalizationWithObservation")]
    [CqlTag("description", "Hospitalization with Observation returns the total interval from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    public CqlInterval<CqlDateTime> hospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] nzzzzzzzzv_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> nzzzzzzzzw_(Encounter Visit)
        {
            CqlValueSet ozzzzzzzza_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> ozzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? ozzzzzzzzc_(Encounter LastED)
            {
                Code<Encounter.EncounterStatus> pzzzzzzzzb_ = LastED?.StatusElement;
                Encounter.EncounterStatus? pzzzzzzzzc_ = pzzzzzzzzb_?.Value;
                Code<Encounter.EncounterStatus> pzzzzzzzzd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pzzzzzzzzc_);
                bool? pzzzzzzzze_ = context.Operators.Equal(pzzzzzzzzd_, "finished");
                Period pzzzzzzzzf_ = LastED?.Period;
                CqlInterval<CqlDateTime> pzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzf_);
                CqlDateTime pzzzzzzzzh_ = context.Operators.End(pzzzzzzzzg_);
                CqlValueSet pzzzzzzzzi_ = this.Observation_Services(context);
                IEnumerable<Encounter> pzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? pzzzzzzzzk_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> rzzzzzzzzc_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? rzzzzzzzzd_ = rzzzzzzzzc_?.Value;
                    Code<Encounter.EncounterStatus> rzzzzzzzze_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rzzzzzzzzd_);
                    bool? rzzzzzzzzf_ = context.Operators.Equal(rzzzzzzzze_, "finished");
                    Period rzzzzzzzzg_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> rzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzg_);
                    CqlDateTime rzzzzzzzzi_ = context.Operators.End(rzzzzzzzzh_);
                    Period rzzzzzzzzj_ = Visit?.Period;
                    CqlInterval<CqlDateTime> rzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzj_);
                    CqlDateTime rzzzzzzzzl_ = context.Operators.Start(rzzzzzzzzk_);
                    CqlQuantity rzzzzzzzzm_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime rzzzzzzzzn_ = context.Operators.Subtract(rzzzzzzzzl_, rzzzzzzzzm_);
                    CqlInterval<CqlDateTime> rzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzj_);
                    CqlDateTime rzzzzzzzzq_ = context.Operators.Start(rzzzzzzzzp_);
                    CqlInterval<CqlDateTime> rzzzzzzzzr_ = context.Operators.Interval(rzzzzzzzzn_, rzzzzzzzzq_, true, true);
                    bool? rzzzzzzzzs_ = context.Operators.In<CqlDateTime>(rzzzzzzzzi_, rzzzzzzzzr_, default);
                    CqlInterval<CqlDateTime> rzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzj_);
                    CqlDateTime rzzzzzzzzv_ = context.Operators.Start(rzzzzzzzzu_);
                    bool? rzzzzzzzzw_ = context.Operators.Not((bool?)(rzzzzzzzzv_ is null));
                    bool? rzzzzzzzzx_ = context.Operators.And(rzzzzzzzzs_, rzzzzzzzzw_);
                    bool? rzzzzzzzzy_ = context.Operators.And(rzzzzzzzzf_, rzzzzzzzzx_);

                    return rzzzzzzzzy_;
                };
                IEnumerable<Encounter> pzzzzzzzzl_ = context.Operators.Where<Encounter>(pzzzzzzzzj_, pzzzzzzzzk_);
                object pzzzzzzzzm_(Encounter @this)
                {
                    Period rzzzzzzzzz_ = @this?.Period;
                    CqlInterval<CqlDateTime> szzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzz_);
                    CqlDateTime szzzzzzzzb_ = context.Operators.End(szzzzzzzza_);

                    return szzzzzzzzb_;
                };
                IEnumerable<Encounter> pzzzzzzzzn_ = context.Operators.SortBy<Encounter>(pzzzzzzzzl_, pzzzzzzzzm_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter pzzzzzzzzo_ = context.Operators.Last<Encounter>(pzzzzzzzzn_);
                Period pzzzzzzzzp_ = pzzzzzzzzo_?.Period;
                CqlInterval<CqlDateTime> pzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzp_);
                CqlDateTime pzzzzzzzzr_ = context.Operators.Start(pzzzzzzzzq_);
                Period pzzzzzzzzs_ = Visit?.Period;
                CqlInterval<CqlDateTime> pzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzs_);
                CqlDateTime pzzzzzzzzu_ = context.Operators.Start(pzzzzzzzzt_);
                CqlQuantity pzzzzzzzzv_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime pzzzzzzzzw_ = context.Operators.Subtract(pzzzzzzzzr_ ?? pzzzzzzzzu_, pzzzzzzzzv_);
                IEnumerable<Encounter> pzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? pzzzzzzzzz_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> szzzzzzzzc_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? szzzzzzzzd_ = szzzzzzzzc_?.Value;
                    Code<Encounter.EncounterStatus> szzzzzzzze_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(szzzzzzzzd_);
                    bool? szzzzzzzzf_ = context.Operators.Equal(szzzzzzzze_, "finished");
                    Period szzzzzzzzg_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> szzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzg_);
                    CqlDateTime szzzzzzzzi_ = context.Operators.End(szzzzzzzzh_);
                    Period szzzzzzzzj_ = Visit?.Period;
                    CqlInterval<CqlDateTime> szzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzj_);
                    CqlDateTime szzzzzzzzl_ = context.Operators.Start(szzzzzzzzk_);
                    CqlQuantity szzzzzzzzm_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime szzzzzzzzn_ = context.Operators.Subtract(szzzzzzzzl_, szzzzzzzzm_);
                    CqlInterval<CqlDateTime> szzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzj_);
                    CqlDateTime szzzzzzzzq_ = context.Operators.Start(szzzzzzzzp_);
                    CqlInterval<CqlDateTime> szzzzzzzzr_ = context.Operators.Interval(szzzzzzzzn_, szzzzzzzzq_, true, true);
                    bool? szzzzzzzzs_ = context.Operators.In<CqlDateTime>(szzzzzzzzi_, szzzzzzzzr_, default);
                    CqlInterval<CqlDateTime> szzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzj_);
                    CqlDateTime szzzzzzzzv_ = context.Operators.Start(szzzzzzzzu_);
                    bool? szzzzzzzzw_ = context.Operators.Not((bool?)(szzzzzzzzv_ is null));
                    bool? szzzzzzzzx_ = context.Operators.And(szzzzzzzzs_, szzzzzzzzw_);
                    bool? szzzzzzzzy_ = context.Operators.And(szzzzzzzzf_, szzzzzzzzx_);

                    return szzzzzzzzy_;
                };
                IEnumerable<Encounter> qzzzzzzzza_ = context.Operators.Where<Encounter>(pzzzzzzzzy_, pzzzzzzzzz_);
                object qzzzzzzzzb_(Encounter @this)
                {
                    Period szzzzzzzzz_ = @this?.Period;
                    CqlInterval<CqlDateTime> tzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzz_);
                    CqlDateTime tzzzzzzzzb_ = context.Operators.End(tzzzzzzzza_);

                    return tzzzzzzzzb_;
                };
                IEnumerable<Encounter> qzzzzzzzzc_ = context.Operators.SortBy<Encounter>(qzzzzzzzza_, qzzzzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter qzzzzzzzzd_ = context.Operators.Last<Encounter>(qzzzzzzzzc_);
                Period qzzzzzzzze_ = qzzzzzzzzd_?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzze_);
                CqlDateTime qzzzzzzzzg_ = context.Operators.Start(qzzzzzzzzf_);
                CqlInterval<CqlDateTime> qzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzs_);
                CqlDateTime qzzzzzzzzj_ = context.Operators.Start(qzzzzzzzzi_);
                CqlInterval<CqlDateTime> qzzzzzzzzk_ = context.Operators.Interval(pzzzzzzzzw_, qzzzzzzzzg_ ?? qzzzzzzzzj_, true, true);
                bool? qzzzzzzzzl_ = context.Operators.In<CqlDateTime>(pzzzzzzzzh_, qzzzzzzzzk_, default);
                IEnumerable<Encounter> qzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? qzzzzzzzzo_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> tzzzzzzzzc_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? tzzzzzzzzd_ = tzzzzzzzzc_?.Value;
                    Code<Encounter.EncounterStatus> tzzzzzzzze_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(tzzzzzzzzd_);
                    bool? tzzzzzzzzf_ = context.Operators.Equal(tzzzzzzzze_, "finished");
                    Period tzzzzzzzzg_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> tzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzg_);
                    CqlDateTime tzzzzzzzzi_ = context.Operators.End(tzzzzzzzzh_);
                    Period tzzzzzzzzj_ = Visit?.Period;
                    CqlInterval<CqlDateTime> tzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzj_);
                    CqlDateTime tzzzzzzzzl_ = context.Operators.Start(tzzzzzzzzk_);
                    CqlQuantity tzzzzzzzzm_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime tzzzzzzzzn_ = context.Operators.Subtract(tzzzzzzzzl_, tzzzzzzzzm_);
                    CqlInterval<CqlDateTime> tzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzj_);
                    CqlDateTime tzzzzzzzzq_ = context.Operators.Start(tzzzzzzzzp_);
                    CqlInterval<CqlDateTime> tzzzzzzzzr_ = context.Operators.Interval(tzzzzzzzzn_, tzzzzzzzzq_, true, true);
                    bool? tzzzzzzzzs_ = context.Operators.In<CqlDateTime>(tzzzzzzzzi_, tzzzzzzzzr_, default);
                    CqlInterval<CqlDateTime> tzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzj_);
                    CqlDateTime tzzzzzzzzv_ = context.Operators.Start(tzzzzzzzzu_);
                    bool? tzzzzzzzzw_ = context.Operators.Not((bool?)(tzzzzzzzzv_ is null));
                    bool? tzzzzzzzzx_ = context.Operators.And(tzzzzzzzzs_, tzzzzzzzzw_);
                    bool? tzzzzzzzzy_ = context.Operators.And(tzzzzzzzzf_, tzzzzzzzzx_);

                    return tzzzzzzzzy_;
                };
                IEnumerable<Encounter> qzzzzzzzzp_ = context.Operators.Where<Encounter>(qzzzzzzzzn_, qzzzzzzzzo_);
                object qzzzzzzzzq_(Encounter @this)
                {
                    Period tzzzzzzzzz_ = @this?.Period;
                    CqlInterval<CqlDateTime> uzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzz_);
                    CqlDateTime uzzzzzzzzb_ = context.Operators.End(uzzzzzzzza_);

                    return uzzzzzzzzb_;
                };
                IEnumerable<Encounter> qzzzzzzzzr_ = context.Operators.SortBy<Encounter>(qzzzzzzzzp_, qzzzzzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter qzzzzzzzzs_ = context.Operators.Last<Encounter>(qzzzzzzzzr_);
                Period qzzzzzzzzt_ = qzzzzzzzzs_?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzt_);
                CqlDateTime qzzzzzzzzv_ = context.Operators.Start(qzzzzzzzzu_);
                CqlInterval<CqlDateTime> qzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzs_);
                CqlDateTime qzzzzzzzzy_ = context.Operators.Start(qzzzzzzzzx_);
                bool? qzzzzzzzzz_ = context.Operators.Not((bool?)((qzzzzzzzzv_ ?? qzzzzzzzzy_) is null));
                bool? rzzzzzzzza_ = context.Operators.And(qzzzzzzzzl_, qzzzzzzzzz_);
                bool? rzzzzzzzzb_ = context.Operators.And(pzzzzzzzze_, rzzzzzzzza_);

                return rzzzzzzzzb_;
            };
            IEnumerable<Encounter> ozzzzzzzzd_ = context.Operators.Where<Encounter>(ozzzzzzzzb_, ozzzzzzzzc_);
            object ozzzzzzzze_(Encounter @this)
            {
                Period uzzzzzzzzc_ = @this?.Period;
                CqlInterval<CqlDateTime> uzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzc_);
                CqlDateTime uzzzzzzzze_ = context.Operators.End(uzzzzzzzzd_);

                return uzzzzzzzze_;
            };
            IEnumerable<Encounter> ozzzzzzzzf_ = context.Operators.SortBy<Encounter>(ozzzzzzzzd_, ozzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter ozzzzzzzzg_ = context.Operators.Last<Encounter>(ozzzzzzzzf_);
            Period ozzzzzzzzh_ = ozzzzzzzzg_?.Period;
            CqlInterval<CqlDateTime> ozzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzh_);
            CqlDateTime ozzzzzzzzj_ = context.Operators.Start(ozzzzzzzzi_);
            CqlValueSet ozzzzzzzzk_ = this.Observation_Services(context);
            IEnumerable<Encounter> ozzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? ozzzzzzzzm_(Encounter LastObs)
            {
                Code<Encounter.EncounterStatus> uzzzzzzzzf_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? uzzzzzzzzg_ = uzzzzzzzzf_?.Value;
                Code<Encounter.EncounterStatus> uzzzzzzzzh_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(uzzzzzzzzg_);
                bool? uzzzzzzzzi_ = context.Operators.Equal(uzzzzzzzzh_, "finished");
                Period uzzzzzzzzj_ = LastObs?.Period;
                CqlInterval<CqlDateTime> uzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzj_);
                CqlDateTime uzzzzzzzzl_ = context.Operators.End(uzzzzzzzzk_);
                Period uzzzzzzzzm_ = Visit?.Period;
                CqlInterval<CqlDateTime> uzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzm_);
                CqlDateTime uzzzzzzzzo_ = context.Operators.Start(uzzzzzzzzn_);
                CqlQuantity uzzzzzzzzp_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime uzzzzzzzzq_ = context.Operators.Subtract(uzzzzzzzzo_, uzzzzzzzzp_);
                CqlInterval<CqlDateTime> uzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzm_);
                CqlDateTime uzzzzzzzzt_ = context.Operators.Start(uzzzzzzzzs_);
                CqlInterval<CqlDateTime> uzzzzzzzzu_ = context.Operators.Interval(uzzzzzzzzq_, uzzzzzzzzt_, true, true);
                bool? uzzzzzzzzv_ = context.Operators.In<CqlDateTime>(uzzzzzzzzl_, uzzzzzzzzu_, default);
                CqlInterval<CqlDateTime> uzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzm_);
                CqlDateTime uzzzzzzzzy_ = context.Operators.Start(uzzzzzzzzx_);
                bool? uzzzzzzzzz_ = context.Operators.Not((bool?)(uzzzzzzzzy_ is null));
                bool? vzzzzzzzza_ = context.Operators.And(uzzzzzzzzv_, uzzzzzzzzz_);
                bool? vzzzzzzzzb_ = context.Operators.And(uzzzzzzzzi_, vzzzzzzzza_);

                return vzzzzzzzzb_;
            };
            IEnumerable<Encounter> ozzzzzzzzn_ = context.Operators.Where<Encounter>(ozzzzzzzzl_, ozzzzzzzzm_);
            object ozzzzzzzzo_(Encounter @this)
            {
                Period vzzzzzzzzc_ = @this?.Period;
                CqlInterval<CqlDateTime> vzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzc_);
                CqlDateTime vzzzzzzzze_ = context.Operators.End(vzzzzzzzzd_);

                return vzzzzzzzze_;
            };
            IEnumerable<Encounter> ozzzzzzzzp_ = context.Operators.SortBy<Encounter>(ozzzzzzzzn_, ozzzzzzzzo_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter ozzzzzzzzq_ = context.Operators.Last<Encounter>(ozzzzzzzzp_);
            Period ozzzzzzzzr_ = ozzzzzzzzq_?.Period;
            CqlInterval<CqlDateTime> ozzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzr_);
            CqlDateTime ozzzzzzzzt_ = context.Operators.Start(ozzzzzzzzs_);
            Period ozzzzzzzzu_ = Visit?.Period;
            CqlInterval<CqlDateTime> ozzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzu_);
            CqlDateTime ozzzzzzzzw_ = context.Operators.Start(ozzzzzzzzv_);
            CqlInterval<CqlDateTime> ozzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzu_);
            CqlDateTime ozzzzzzzzz_ = context.Operators.End(ozzzzzzzzy_);
            CqlInterval<CqlDateTime> pzzzzzzzza_ = context.Operators.Interval(ozzzzzzzzj_ ?? ozzzzzzzzt_ ?? ozzzzzzzzw_, ozzzzzzzzz_, true, true);

            return pzzzzzzzza_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> nzzzzzzzzx_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)nzzzzzzzzv_, nzzzzzzzzw_);
        IEnumerable<CqlInterval<CqlDateTime>> nzzzzzzzzy_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(nzzzzzzzzx_);
        CqlInterval<CqlDateTime> nzzzzzzzzz_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(nzzzzzzzzy_);

        return nzzzzzzzzz_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservationLengthofStay")]
    [CqlTag("description", "Hospitalization with Observation Length of Stay returns the length in days from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationWithObservationLengthofStay()` instead.")]
    public int? HospitalizationWithObservationLengthofStay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> vzzzzzzzzf_ = this.HospitalizationWithObservation(context, TheEncounter);
        int? vzzzzzzzzg_ = this.LengthInDays(context, vzzzzzzzzf_);

        return vzzzzzzzzg_;
    }


    [CqlExpressionDefinition("hospitalizationWithObservationLengthofStay")]
    [CqlTag("description", "Hospitalization with Observation Length of Stay returns the length in days from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    public int? hospitalizationWithObservationLengthofStay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> vzzzzzzzzh_ = this.hospitalizationWithObservation(context, TheEncounter);
        int? vzzzzzzzzi_ = this.lengthInDays(context, vzzzzzzzzh_);

        return vzzzzzzzzi_;
    }


    [CqlExpressionDefinition("FirstInpatientIntensiveCareUnit")]
    [CqlTag("description", "First Inpatient Intensive Care Unit returns the first intensive care unit for the given encounter, without considering any immediately prior emergency department visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `firstInpatientIntensiveCareUnit()` instead.")]
    public Encounter.LocationComponent FirstInpatientIntensiveCareUnit(CqlContext context, Encounter Encounter)
    {
        List<Encounter.LocationComponent> vzzzzzzzzj_ = Encounter?.Location;
        bool? vzzzzzzzzk_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference vzzzzzzzzp_ = HospitalLocation?.Location;
            Location vzzzzzzzzq_ = this.GetLocation(context, vzzzzzzzzp_);
            List<CodeableConcept> vzzzzzzzzr_ = vzzzzzzzzq_?.Type;
            CqlConcept vzzzzzzzzs_(CodeableConcept @this)
            {
                CqlConcept wzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return wzzzzzzzzc_;
            };
            IEnumerable<CqlConcept> vzzzzzzzzt_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)vzzzzzzzzr_, vzzzzzzzzs_);
            CqlValueSet vzzzzzzzzu_ = this.Intensive_Care_Unit(context);
            bool? vzzzzzzzzv_ = context.Operators.ConceptsInValueSet(vzzzzzzzzt_, vzzzzzzzzu_);
            Period vzzzzzzzzw_ = Encounter?.Period;
            CqlInterval<CqlDateTime> vzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzw_);
            Period vzzzzzzzzy_ = HospitalLocation?.Period;
            CqlInterval<CqlDateTime> vzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzy_);
            bool? wzzzzzzzza_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(vzzzzzzzzx_, vzzzzzzzzz_, default);
            bool? wzzzzzzzzb_ = context.Operators.And(vzzzzzzzzv_, wzzzzzzzza_);

            return wzzzzzzzzb_;
        };
        IEnumerable<Encounter.LocationComponent> vzzzzzzzzl_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)vzzzzzzzzj_, vzzzzzzzzk_);
        object vzzzzzzzzm_(Encounter.LocationComponent @this)
        {
            Period wzzzzzzzzd_ = @this?.Period;
            CqlInterval<CqlDateTime> wzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzd_);
            CqlDateTime wzzzzzzzzf_ = context.Operators.Start(wzzzzzzzze_);

            return wzzzzzzzzf_;
        };
        IEnumerable<Encounter.LocationComponent> vzzzzzzzzn_ = context.Operators.SortBy<Encounter.LocationComponent>(vzzzzzzzzl_, vzzzzzzzzm_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent vzzzzzzzzo_ = context.Operators.First<Encounter.LocationComponent>(vzzzzzzzzn_);

        return vzzzzzzzzo_;
    }


    [CqlExpressionDefinition("firstInpatientIntensiveCareUnit")]
    [CqlTag("description", "First Inpatient Intensive Care Unit returns the first intensive care unit for the given encounter, without considering any immediately prior emergency department visit.")]
    public Encounter.LocationComponent firstInpatientIntensiveCareUnit(CqlContext context, Encounter Encounter)
    {
        List<Encounter.LocationComponent> wzzzzzzzzg_ = Encounter?.Location;
        bool? wzzzzzzzzh_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference wzzzzzzzzm_ = HospitalLocation?.Location;
            Location wzzzzzzzzn_ = this.GetLocation(context, wzzzzzzzzm_);
            List<CodeableConcept> wzzzzzzzzo_ = wzzzzzzzzn_?.Type;
            CqlConcept wzzzzzzzzp_(CodeableConcept @this)
            {
                CqlConcept wzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return wzzzzzzzzz_;
            };
            IEnumerable<CqlConcept> wzzzzzzzzq_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)wzzzzzzzzo_, wzzzzzzzzp_);
            CqlValueSet wzzzzzzzzr_ = this.Intensive_Care_Unit(context);
            bool? wzzzzzzzzs_ = context.Operators.ConceptsInValueSet(wzzzzzzzzq_, wzzzzzzzzr_);
            Period wzzzzzzzzt_ = Encounter?.Period;
            CqlInterval<CqlDateTime> wzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzt_);
            Period wzzzzzzzzv_ = HospitalLocation?.Period;
            CqlInterval<CqlDateTime> wzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzv_);
            bool? wzzzzzzzzx_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(wzzzzzzzzu_, wzzzzzzzzw_, default);
            bool? wzzzzzzzzy_ = context.Operators.And(wzzzzzzzzs_, wzzzzzzzzx_);

            return wzzzzzzzzy_;
        };
        IEnumerable<Encounter.LocationComponent> wzzzzzzzzi_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)wzzzzzzzzg_, wzzzzzzzzh_);
        object wzzzzzzzzj_(Encounter.LocationComponent @this)
        {
            Period xzzzzzzzza_ = @this?.Period;
            CqlInterval<CqlDateTime> xzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzza_);
            CqlDateTime xzzzzzzzzc_ = context.Operators.Start(xzzzzzzzzb_);

            return xzzzzzzzzc_;
        };
        IEnumerable<Encounter.LocationComponent> wzzzzzzzzk_ = context.Operators.SortBy<Encounter.LocationComponent>(wzzzzzzzzi_, wzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent wzzzzzzzzl_ = context.Operators.First<Encounter.LocationComponent>(wzzzzzzzzk_);

        return wzzzzzzzzl_;
    }


    [CqlExpressionDefinition("EncounterDiagnosis")]
    [CqlTag("description", "Returns the Condition resource referenced by the `diagnosis.condition` element of the Encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `encounterDiagnosis()` instead.")]
    public IEnumerable<Condition> EncounterDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> xzzzzzzzzd_ = Encounter?.Diagnosis;
        Condition xzzzzzzzze_(Encounter.DiagnosisComponent D)
        {
            IEnumerable<Condition> xzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? xzzzzzzzzi_(Condition C)
            {
                Id xzzzzzzzzl_ = C?.IdElement;
                string xzzzzzzzzm_ = xzzzzzzzzl_?.Value;
                ResourceReference xzzzzzzzzn_ = D?.Condition;
                FhirString xzzzzzzzzo_ = xzzzzzzzzn_?.ReferenceElement;
                string xzzzzzzzzp_ = xzzzzzzzzo_?.Value;
                string xzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.getId(context, xzzzzzzzzp_);
                bool? xzzzzzzzzr_ = context.Operators.Equal(xzzzzzzzzm_, xzzzzzzzzq_);

                return xzzzzzzzzr_;
            };
            IEnumerable<Condition> xzzzzzzzzj_ = context.Operators.Where<Condition>(xzzzzzzzzh_, xzzzzzzzzi_);
            Condition xzzzzzzzzk_ = context.Operators.SingletonFrom<Condition>(xzzzzzzzzj_);

            return xzzzzzzzzk_;
        };
        IEnumerable<Condition> xzzzzzzzzf_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)xzzzzzzzzd_, xzzzzzzzze_);
        IEnumerable<Condition> xzzzzzzzzg_ = context.Operators.Distinct<Condition>(xzzzzzzzzf_);

        return xzzzzzzzzg_;
    }


    [CqlExpressionDefinition("encounterDiagnosis")]
    [CqlTag("description", "Returns the Condition resources referenced by the diagnosis element of the Encounter")]
    public IEnumerable<Condition> encounterDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> xzzzzzzzzs_ = Encounter?.Diagnosis;
        Condition xzzzzzzzzt_(Encounter.DiagnosisComponent D)
        {
            IEnumerable<Condition> xzzzzzzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? xzzzzzzzzx_(Condition C)
            {
                Id yzzzzzzzza_ = C?.IdElement;
                string yzzzzzzzzb_ = yzzzzzzzza_?.Value;
                ResourceReference yzzzzzzzzc_ = D?.Condition;
                FhirString yzzzzzzzzd_ = yzzzzzzzzc_?.ReferenceElement;
                string yzzzzzzzze_ = yzzzzzzzzd_?.Value;
                string yzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.getId(context, yzzzzzzzze_);
                bool? yzzzzzzzzg_ = context.Operators.Equal(yzzzzzzzzb_, yzzzzzzzzf_);

                return yzzzzzzzzg_;
            };
            IEnumerable<Condition> xzzzzzzzzy_ = context.Operators.Where<Condition>(xzzzzzzzzw_, xzzzzzzzzx_);
            Condition xzzzzzzzzz_ = context.Operators.SingletonFrom<Condition>(xzzzzzzzzy_);

            return xzzzzzzzzz_;
        };
        IEnumerable<Condition> xzzzzzzzzu_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)xzzzzzzzzs_, xzzzzzzzzt_);
        IEnumerable<Condition> xzzzzzzzzv_ = context.Operators.Distinct<Condition>(xzzzzzzzzu_);

        return xzzzzzzzzv_;
    }


    [CqlExpressionDefinition("GetCondition")]
    [CqlTag("description", "Returns the Condition resource for the given reference")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getCondition()` instead")]
    public Condition GetCondition(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Condition> yzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? yzzzzzzzzi_(Condition C)
        {
            Id yzzzzzzzzl_ = C?.IdElement;
            string yzzzzzzzzm_ = yzzzzzzzzl_?.Value;
            FhirString yzzzzzzzzn_ = reference?.ReferenceElement;
            string yzzzzzzzzo_ = yzzzzzzzzn_?.Value;
            string yzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.getId(context, yzzzzzzzzo_);
            bool? yzzzzzzzzq_ = context.Operators.Equal(yzzzzzzzzm_, yzzzzzzzzp_);

            return yzzzzzzzzq_;
        };
        IEnumerable<Condition> yzzzzzzzzj_ = context.Operators.Where<Condition>(yzzzzzzzzh_, yzzzzzzzzi_);
        Condition yzzzzzzzzk_ = context.Operators.SingletonFrom<Condition>(yzzzzzzzzj_);

        return yzzzzzzzzk_;
    }


    [CqlExpressionDefinition("getCondition")]
    [CqlTag("description", "Returns the Condition resource for the given reference")]
    public Condition getCondition(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Condition> yzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? yzzzzzzzzs_(Condition C)
        {
            Id yzzzzzzzzv_ = C?.IdElement;
            string yzzzzzzzzw_ = yzzzzzzzzv_?.Value;
            FhirString yzzzzzzzzx_ = reference?.ReferenceElement;
            string yzzzzzzzzy_ = yzzzzzzzzx_?.Value;
            string yzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.getId(context, yzzzzzzzzy_);
            bool? zzzzzzzzza_ = context.Operators.Equal(yzzzzzzzzw_, yzzzzzzzzz_);

            return zzzzzzzzza_;
        };
        IEnumerable<Condition> yzzzzzzzzt_ = context.Operators.Where<Condition>(yzzzzzzzzr_, yzzzzzzzzs_);
        Condition yzzzzzzzzu_ = context.Operators.SingletonFrom<Condition>(yzzzzzzzzt_);

        return yzzzzzzzzu_;
    }


    [CqlExpressionDefinition("PrincipalDiagnosis")]
    [CqlTag("description", "Returns the condition that is specified as the principal diagnosis for the encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `principalDiagnosis()` instead.")]
    public Condition PrincipalDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> zzzzzzzzzb_ = Encounter?.Diagnosis;
        bool? zzzzzzzzzc_(Encounter.DiagnosisComponent D)
        {
            PositiveInt zzzzzzzzzi_ = D?.RankElement;
            int? zzzzzzzzzj_ = zzzzzzzzzi_?.Value;
            bool? zzzzzzzzzk_ = context.Operators.Equal(zzzzzzzzzj_, 1);
            CodeableConcept zzzzzzzzzl_ = D?.Use;
            CqlConcept zzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, zzzzzzzzzl_);
            CqlCode zzzzzzzzzn_ = this.Billing(context);
            CqlConcept zzzzzzzzzo_ = context.Operators.ConvertCodeToConcept(zzzzzzzzzn_);
            bool? zzzzzzzzzp_ = context.Operators.Equivalent(zzzzzzzzzm_, zzzzzzzzzo_);
            bool? zzzzzzzzzq_ = context.Operators.And(zzzzzzzzzk_, zzzzzzzzzp_);

            return zzzzzzzzzq_;
        };
        IEnumerable<Encounter.DiagnosisComponent> zzzzzzzzzd_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)zzzzzzzzzb_, zzzzzzzzzc_);
        Condition zzzzzzzzze_(Encounter.DiagnosisComponent PD)
        {
            IEnumerable<Condition> zzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? zzzzzzzzzs_(Condition C)
            {
                Id zzzzzzzzzv_ = C?.IdElement;
                string zzzzzzzzzw_ = zzzzzzzzzv_?.Value;
                ResourceReference zzzzzzzzzx_ = PD?.Condition;
                FhirString zzzzzzzzzy_ = zzzzzzzzzx_?.ReferenceElement;
                string zzzzzzzzzz_ = zzzzzzzzzy_?.Value;
                string azzzzzzzzza_ = QICoreCommon_2_1_000.Instance.getId(context, zzzzzzzzzz_);
                bool? azzzzzzzzzb_ = context.Operators.Equal(zzzzzzzzzw_, azzzzzzzzza_);

                return azzzzzzzzzb_;
            };
            IEnumerable<Condition> zzzzzzzzzt_ = context.Operators.Where<Condition>(zzzzzzzzzr_, zzzzzzzzzs_);
            Condition zzzzzzzzzu_ = context.Operators.SingletonFrom<Condition>(zzzzzzzzzt_);

            return zzzzzzzzzu_;
        };
        IEnumerable<Condition> zzzzzzzzzf_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>(zzzzzzzzzd_, zzzzzzzzze_);
        IEnumerable<Condition> zzzzzzzzzg_ = context.Operators.Distinct<Condition>(zzzzzzzzzf_);
        Condition zzzzzzzzzh_ = context.Operators.SingletonFrom<Condition>(zzzzzzzzzg_);

        return zzzzzzzzzh_;
    }


    [CqlExpressionDefinition("principalDiagnosis")]
    [CqlTag("description", "Returns the condition that is specified as the principal diagnosis for the encounter")]
    public Condition principalDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> azzzzzzzzzc_ = Encounter?.Diagnosis;
        bool? azzzzzzzzzd_(Encounter.DiagnosisComponent D)
        {
            PositiveInt azzzzzzzzzj_ = D?.RankElement;
            int? azzzzzzzzzk_ = azzzzzzzzzj_?.Value;
            bool? azzzzzzzzzl_ = context.Operators.Equal(azzzzzzzzzk_, 1);
            CodeableConcept azzzzzzzzzm_ = D?.Use;
            CqlConcept azzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzzzzzzzm_);
            CqlCode azzzzzzzzzo_ = this.Billing(context);
            CqlConcept azzzzzzzzzp_ = context.Operators.ConvertCodeToConcept(azzzzzzzzzo_);
            bool? azzzzzzzzzq_ = context.Operators.Equivalent(azzzzzzzzzn_, azzzzzzzzzp_);
            bool? azzzzzzzzzr_ = context.Operators.And(azzzzzzzzzl_, azzzzzzzzzq_);

            return azzzzzzzzzr_;
        };
        IEnumerable<Encounter.DiagnosisComponent> azzzzzzzzze_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)azzzzzzzzzc_, azzzzzzzzzd_);
        Condition azzzzzzzzzf_(Encounter.DiagnosisComponent PD)
        {
            IEnumerable<Condition> azzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? azzzzzzzzzt_(Condition C)
            {
                Id azzzzzzzzzw_ = C?.IdElement;
                string azzzzzzzzzx_ = azzzzzzzzzw_?.Value;
                ResourceReference azzzzzzzzzy_ = PD?.Condition;
                FhirString azzzzzzzzzz_ = azzzzzzzzzy_?.ReferenceElement;
                string bzzzzzzzzza_ = azzzzzzzzzz_?.Value;
                string bzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.getId(context, bzzzzzzzzza_);
                bool? bzzzzzzzzzc_ = context.Operators.Equal(azzzzzzzzzx_, bzzzzzzzzzb_);

                return bzzzzzzzzzc_;
            };
            IEnumerable<Condition> azzzzzzzzzu_ = context.Operators.Where<Condition>(azzzzzzzzzs_, azzzzzzzzzt_);
            Condition azzzzzzzzzv_ = context.Operators.SingletonFrom<Condition>(azzzzzzzzzu_);

            return azzzzzzzzzv_;
        };
        IEnumerable<Condition> azzzzzzzzzg_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>(azzzzzzzzze_, azzzzzzzzzf_);
        IEnumerable<Condition> azzzzzzzzzh_ = context.Operators.Distinct<Condition>(azzzzzzzzzg_);
        Condition azzzzzzzzzi_ = context.Operators.SingletonFrom<Condition>(azzzzzzzzzh_);

        return azzzzzzzzzi_;
    }


    [CqlExpressionDefinition("getLocation")]
    [CqlTag("description", "Returns the Location resource specified by the given reference.")]
    public Location getLocation(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Location> bzzzzzzzzzd_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-location"));
        bool? bzzzzzzzzze_(Location L)
        {
            Id bzzzzzzzzzh_ = L?.IdElement;
            string bzzzzzzzzzi_ = bzzzzzzzzzh_?.Value;
            FhirString bzzzzzzzzzj_ = reference?.ReferenceElement;
            string bzzzzzzzzzk_ = bzzzzzzzzzj_?.Value;
            string bzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.getId(context, bzzzzzzzzzk_);
            bool? bzzzzzzzzzm_ = context.Operators.Equal(bzzzzzzzzzi_, bzzzzzzzzzl_);

            return bzzzzzzzzzm_;
        };
        IEnumerable<Location> bzzzzzzzzzf_ = context.Operators.Where<Location>(bzzzzzzzzzd_, bzzzzzzzzze_);
        Location bzzzzzzzzzg_ = context.Operators.SingletonFrom<Location>(bzzzzzzzzzf_);

        return bzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("GetMedicationCode")]
    [CqlTag("description", "Returns the medication code for the given MedicationRequest")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getMedicationCode()` instead.")]
    public CqlConcept GetMedicationCode(CqlContext context, MedicationRequest request)
    {
        CqlConcept bzzzzzzzzzn_()
        {
            bool bzzzzzzzzzo_()
            {
                DataType bzzzzzzzzzp_ = request?.Medication;
                object bzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzp_);
                bool bzzzzzzzzzr_ = bzzzzzzzzzq_ is CqlConcept;

                return bzzzzzzzzzr_;
            };
            if (bzzzzzzzzzo_())
            {
                DataType bzzzzzzzzzs_ = request?.Medication;
                object bzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzs_);

                return bzzzzzzzzzt_ as CqlConcept;
            }
            else
            {
                IEnumerable<Medication> bzzzzzzzzzu_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? bzzzzzzzzzv_(Medication M)
                {
                    Id czzzzzzzzza_ = M?.IdElement;
                    string czzzzzzzzzb_ = czzzzzzzzza_?.Value;
                    DataType czzzzzzzzzc_ = request?.Medication;
                    object czzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzc_);
                    FhirString czzzzzzzzze_ = (czzzzzzzzzd_ as ResourceReference)?.ReferenceElement;
                    string czzzzzzzzzf_ = czzzzzzzzze_?.Value;
                    string czzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.getId(context, czzzzzzzzzf_);
                    bool? czzzzzzzzzh_ = context.Operators.Equal(czzzzzzzzzb_, czzzzzzzzzg_);

                    return czzzzzzzzzh_;
                };
                IEnumerable<Medication> bzzzzzzzzzw_ = context.Operators.Where<Medication>(bzzzzzzzzzu_, bzzzzzzzzzv_);
                Medication bzzzzzzzzzx_ = context.Operators.SingletonFrom<Medication>(bzzzzzzzzzw_);
                CodeableConcept bzzzzzzzzzy_ = bzzzzzzzzzx_?.Code;
                CqlConcept bzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzzzzy_);

                return bzzzzzzzzzz_;
            }
        };

        return bzzzzzzzzzn_();
    }


    [CqlExpressionDefinition("getMedicationCode")]
    [CqlTag("description", "Returns the medication code for the given MedicationRequest")]
    public CqlConcept getMedicationCode(CqlContext context, MedicationRequest request)
    {
        CqlConcept czzzzzzzzzi_()
        {
            bool czzzzzzzzzj_()
            {
                DataType czzzzzzzzzk_ = request?.Medication;
                object czzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzk_);
                bool czzzzzzzzzm_ = czzzzzzzzzl_ is CqlConcept;

                return czzzzzzzzzm_;
            };
            if (czzzzzzzzzj_())
            {
                DataType czzzzzzzzzn_ = request?.Medication;
                object czzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzn_);

                return czzzzzzzzzo_ as CqlConcept;
            }
            else
            {
                IEnumerable<Medication> czzzzzzzzzp_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? czzzzzzzzzq_(Medication M)
                {
                    Id czzzzzzzzzv_ = M?.IdElement;
                    string czzzzzzzzzw_ = czzzzzzzzzv_?.Value;
                    DataType czzzzzzzzzx_ = request?.Medication;
                    object czzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzx_);
                    FhirString czzzzzzzzzz_ = (czzzzzzzzzy_ as ResourceReference)?.ReferenceElement;
                    string dzzzzzzzzza_ = czzzzzzzzzz_?.Value;
                    string dzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.getId(context, dzzzzzzzzza_);
                    bool? dzzzzzzzzzc_ = context.Operators.Equal(czzzzzzzzzw_, dzzzzzzzzzb_);

                    return dzzzzzzzzzc_;
                };
                IEnumerable<Medication> czzzzzzzzzr_ = context.Operators.Where<Medication>(czzzzzzzzzp_, czzzzzzzzzq_);
                Medication czzzzzzzzzs_ = context.Operators.SingletonFrom<Medication>(czzzzzzzzzr_);
                CodeableConcept czzzzzzzzzt_ = czzzzzzzzzs_?.Code;
                CqlConcept czzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, czzzzzzzzzt_);

                return czzzzzzzzzu_;
            }
        };

        return czzzzzzzzzi_();
    }


    #endregion Expressions

}
