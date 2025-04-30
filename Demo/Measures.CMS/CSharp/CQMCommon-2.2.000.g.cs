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
    private static readonly CqlCode _Billing = new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("DiagnosisRole")]
    public CqlCodeSystem DiagnosisRole(CqlContext _) => _DiagnosisRole;
    private static readonly CqlCodeSystem _DiagnosisRole =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/diagnosis-role", null,
          _Billing);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime uzzw_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime uzzx_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> uzzy_ = context.Operators.Interval(uzzw_, uzzx_, true, false);
        object uzzz_ = context.ResolveParameter("CQMCommon-2.2.000", "Measurement Period", uzzy_);

        return (CqlInterval<CqlDateTime>)uzzz_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> vzza_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient vzzb_ = context.Operators.SingletonFrom<Patient>(vzza_);

        return vzzb_;
    }


    [CqlExpressionDefinition("Inpatient Encounter")]
    public IEnumerable<Encounter> Inpatient_Encounter(CqlContext context)
    {
        CqlValueSet vzzc_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> vzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? vzze_(Encounter EncounterInpatient)
        {
            Code<Encounter.EncounterStatus> vzzg_ = EncounterInpatient?.StatusElement;
            Encounter.EncounterStatus? vzzh_ = vzzg_?.Value;
            Code<Encounter.EncounterStatus> vzzi_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(vzzh_);
            bool? vzzj_ = context.Operators.Equal(vzzi_, "finished");
            Period vzzk_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime> vzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzk_);
            CqlDateTime vzzm_ = context.Operators.End(vzzl_);
            CqlInterval<CqlDateTime> vzzn_ = this.Measurement_Period(context);
            bool? vzzo_ = context.Operators.In<CqlDateTime>(vzzm_, vzzn_, "day");
            bool? vzzp_ = context.Operators.And(vzzj_, vzzo_);

            return vzzp_;
        };
        IEnumerable<Encounter> vzzf_ = context.Operators.Where<Encounter>(vzzd_, vzze_);

        return vzzf_;
    }


    [CqlExpressionDefinition("ToDateInterval")]
    [CqlTag("description", "Returns an interval of date values extracted from the input interval of date-time values")]
    [CqlTag("comment", "This function returns an interval constructed using the `date from` extractor on the start\nand end values of the input date-time interval. Note that using a precision specifier such as `day of`\nas part of a timing phrase is preferred to communicate intent to perform day-level comparison, as well\nas for general readability.")]
    public CqlInterval<CqlDate> ToDateInterval(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime vzzq_ = context.Operators.Start(period);
        CqlDate vzzr_ = context.Operators.DateFrom(vzzq_);
        CqlDateTime vzzs_ = context.Operators.End(period);
        CqlDate vzzt_ = context.Operators.DateFrom(vzzs_);
        CqlInterval<CqlDate> vzzu_ = context.Operators.Interval(vzzr_, vzzt_, true, true);

        return vzzu_;
    }


    [CqlExpressionDefinition("LengthInDays")]
    [CqlTag("description", "Calculates the difference in calendar days between the start and end of the given interval.")]
    [CqlTag("deprecated", "This function in deprecated. Use the fluent function `lengthInDays()` instead.")]
    public int? LengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
    {
        CqlDateTime vzzv_ = context.Operators.Start(Value);
        CqlDateTime vzzw_ = context.Operators.End(Value);
        int? vzzx_ = context.Operators.DifferenceBetween(vzzv_, vzzw_, "day");

        return vzzx_;
    }


    [CqlExpressionDefinition("lengthInDays")]
    [CqlTag("description", "Calculates the difference in calendar days between the start and end of the given interval.")]
    public int? lengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
    {
        CqlDateTime vzzy_ = context.Operators.Start(Value);
        CqlDateTime vzzz_ = context.Operators.End(Value);
        int? wzza_ = context.Operators.DifferenceBetween(vzzy_, vzzz_, "day");

        return wzza_;
    }


    [CqlExpressionDefinition("ED Visit")]
    [CqlTag("description", "Returns the most recent emergency department visit, if any, that occurs 1 hour or less prior to the given encounter.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `edVisit()` instead.")]
    public Encounter ED_Visit(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet wzzb_ = this.Emergency_Department_Visit(context);
        IEnumerable<Encounter> wzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? wzzd_(Encounter EDVisit)
        {
            Code<Encounter.EncounterStatus> wzzi_ = EDVisit?.StatusElement;
            Encounter.EncounterStatus? wzzj_ = wzzi_?.Value;
            Code<Encounter.EncounterStatus> wzzk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(wzzj_);
            bool? wzzl_ = context.Operators.Equal(wzzk_, "finished");
            Period wzzm_ = EDVisit?.Period;
            CqlInterval<CqlDateTime> wzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzm_);
            CqlDateTime wzzo_ = context.Operators.End(wzzn_);
            Period wzzp_ = TheEncounter?.Period;
            CqlInterval<CqlDateTime> wzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzp_);
            CqlDateTime wzzr_ = context.Operators.Start(wzzq_);
            CqlQuantity wzzs_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime wzzt_ = context.Operators.Subtract(wzzr_, wzzs_);
            CqlInterval<CqlDateTime> wzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzp_);
            CqlDateTime wzzw_ = context.Operators.Start(wzzv_);
            CqlInterval<CqlDateTime> wzzx_ = context.Operators.Interval(wzzt_, wzzw_, true, true);
            bool? wzzy_ = context.Operators.In<CqlDateTime>(wzzo_, wzzx_, default);
            CqlInterval<CqlDateTime> xzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzp_);
            CqlDateTime xzzb_ = context.Operators.Start(xzza_);
            bool? xzzc_ = context.Operators.Not((bool?)(xzzb_ is null));
            bool? xzzd_ = context.Operators.And(wzzy_, xzzc_);
            bool? xzze_ = context.Operators.And(wzzl_, xzzd_);

            return xzze_;
        };
        IEnumerable<Encounter> wzze_ = context.Operators.Where<Encounter>(wzzc_, wzzd_);
        object wzzf_(Encounter @this)
        {
            Period xzzf_ = @this?.Period;
            CqlInterval<CqlDateTime> xzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzf_);
            CqlDateTime xzzh_ = context.Operators.End(xzzg_);

            return xzzh_;
        };
        IEnumerable<Encounter> wzzg_ = context.Operators.SortBy<Encounter>(wzze_, wzzf_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter wzzh_ = context.Operators.Last<Encounter>(wzzg_);

        return wzzh_;
    }


    [CqlExpressionDefinition("edVisit")]
    [CqlTag("description", "Returns the most recent emergency department visit, if any, that occurs 1 hour or less prior to the given encounter.")]
    public Encounter edVisit(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet xzzi_ = this.Emergency_Department_Visit(context);
        IEnumerable<Encounter> xzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? xzzk_(Encounter EDVisit)
        {
            Code<Encounter.EncounterStatus> xzzp_ = EDVisit?.StatusElement;
            Encounter.EncounterStatus? xzzq_ = xzzp_?.Value;
            Code<Encounter.EncounterStatus> xzzr_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(xzzq_);
            bool? xzzs_ = context.Operators.Equal(xzzr_, "finished");
            Period xzzt_ = EDVisit?.Period;
            CqlInterval<CqlDateTime> xzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzt_);
            CqlDateTime xzzv_ = context.Operators.End(xzzu_);
            Period xzzw_ = TheEncounter?.Period;
            CqlInterval<CqlDateTime> xzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzw_);
            CqlDateTime xzzy_ = context.Operators.Start(xzzx_);
            CqlQuantity xzzz_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime yzza_ = context.Operators.Subtract(xzzy_, xzzz_);
            CqlInterval<CqlDateTime> yzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzw_);
            CqlDateTime yzzd_ = context.Operators.Start(yzzc_);
            CqlInterval<CqlDateTime> yzze_ = context.Operators.Interval(yzza_, yzzd_, true, true);
            bool? yzzf_ = context.Operators.In<CqlDateTime>(xzzv_, yzze_, default);
            CqlInterval<CqlDateTime> yzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzw_);
            CqlDateTime yzzi_ = context.Operators.Start(yzzh_);
            bool? yzzj_ = context.Operators.Not((bool?)(yzzi_ is null));
            bool? yzzk_ = context.Operators.And(yzzf_, yzzj_);
            bool? yzzl_ = context.Operators.And(xzzs_, yzzk_);

            return yzzl_;
        };
        IEnumerable<Encounter> xzzl_ = context.Operators.Where<Encounter>(xzzj_, xzzk_);
        object xzzm_(Encounter @this)
        {
            Period yzzm_ = @this?.Period;
            CqlInterval<CqlDateTime> yzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzm_);
            CqlDateTime yzzo_ = context.Operators.End(yzzn_);

            return yzzo_;
        };
        IEnumerable<Encounter> xzzn_ = context.Operators.SortBy<Encounter>(xzzl_, xzzm_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter xzzo_ = context.Operators.Last<Encounter>(xzzn_);

        return xzzo_;
    }


    [CqlExpressionDefinition("Hospitalization")]
    [CqlTag("description", "Hospitalization returns the total interval for admission to discharge for the given encounter, or for the admission of any immediately prior emergency department visit to the discharge of the given encounter.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalization()` instead.")]
    public CqlInterval<CqlDateTime> Hospitalization(CqlContext context, Encounter TheEncounter)
    {
        Encounter yzzp_ = this.ED_Visit(context, TheEncounter);
        Encounter[] yzzq_ = [
            yzzp_,
        ];
        CqlInterval<CqlDateTime> yzzr_(Encounter X)
        {
            CqlInterval<CqlDateTime> yzzv_()
            {
                if (X is null)
                {
                    Period yzzw_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> yzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzw_);

                    return yzzx_;
                }
                else
                {
                    Period yzzy_ = X?.Period;
                    CqlInterval<CqlDateTime> yzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzy_);
                    CqlDateTime zzza_ = context.Operators.Start(yzzz_);
                    Period zzzb_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> zzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzb_);
                    CqlDateTime zzzd_ = context.Operators.End(zzzc_);
                    CqlInterval<CqlDateTime> zzze_ = context.Operators.Interval(zzza_, zzzd_, true, false);

                    return zzze_;
                }
            };

            return yzzv_();
        };
        IEnumerable<CqlInterval<CqlDateTime>> yzzs_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)yzzq_, yzzr_);
        IEnumerable<CqlInterval<CqlDateTime>> yzzt_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(yzzs_);
        CqlInterval<CqlDateTime> yzzu_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(yzzt_);

        return yzzu_;
    }


    [CqlExpressionDefinition("hospitalization")]
    [CqlTag("description", "Hospitalization returns the total interval for admission to discharge for the given encounter, or for the admission of any immediately prior emergency department visit to the discharge of the given encounter.")]
    public CqlInterval<CqlDateTime> hospitalization(CqlContext context, Encounter TheEncounter)
    {
        Encounter zzzf_ = this.edVisit(context, TheEncounter);
        Encounter[] zzzg_ = [
            zzzf_,
        ];
        CqlInterval<CqlDateTime> zzzh_(Encounter X)
        {
            CqlInterval<CqlDateTime> zzzl_()
            {
                if (X is null)
                {
                    Period zzzm_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> zzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzm_);

                    return zzzn_;
                }
                else
                {
                    Period zzzo_ = X?.Period;
                    CqlInterval<CqlDateTime> zzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzo_);
                    CqlDateTime zzzq_ = context.Operators.Start(zzzp_);
                    Period zzzr_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> zzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzr_);
                    CqlDateTime zzzt_ = context.Operators.End(zzzs_);
                    CqlInterval<CqlDateTime> zzzu_ = context.Operators.Interval(zzzq_, zzzt_, true, true);

                    return zzzu_;
                }
            };

            return zzzl_();
        };
        IEnumerable<CqlInterval<CqlDateTime>> zzzi_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)zzzg_, zzzh_);
        IEnumerable<CqlInterval<CqlDateTime>> zzzj_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(zzzi_);
        CqlInterval<CqlDateTime> zzzk_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(zzzj_);

        return zzzk_;
    }


    [CqlExpressionDefinition("Hospitalization Locations")]
    [CqlTag("description", "Returns list of all locations within an encounter, including locations for immediately prior ED visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationLocations()` instead.")]
    public IEnumerable<Encounter.LocationComponent> Hospitalization_Locations(CqlContext context, Encounter TheEncounter)
    {
        Encounter zzzv_ = this.ED_Visit(context, TheEncounter);
        Encounter[] zzzw_ = [
            zzzv_,
        ];
        IEnumerable<Encounter.LocationComponent> zzzx_(Encounter EDEncounter)
        {
            IEnumerable<Encounter.LocationComponent> azzzb_()
            {
                if (EDEncounter is null)
                {
                    List<Encounter.LocationComponent> azzzc_ = TheEncounter?.Location;

                    return (IEnumerable<Encounter.LocationComponent>)azzzc_;
                }
                else
                {
                    List<Encounter.LocationComponent> azzzd_ = EDEncounter?.Location;
                    List<Encounter.LocationComponent> azzze_ = TheEncounter?.Location;
                    IEnumerable<Encounter.LocationComponent>[] azzzf_ = [
                        (IEnumerable<Encounter.LocationComponent>)azzzd_,
                        (IEnumerable<Encounter.LocationComponent>)azzze_,
                    ];
                    IEnumerable<Encounter.LocationComponent> azzzg_ = context.Operators.Flatten<Encounter.LocationComponent>(azzzf_ as IEnumerable<IEnumerable<Encounter.LocationComponent>>);

                    return azzzg_;
                }
            };

            return azzzb_();
        };
        IEnumerable<IEnumerable<Encounter.LocationComponent>> zzzy_ = context.Operators.Select<Encounter, IEnumerable<Encounter.LocationComponent>>((IEnumerable<Encounter>)zzzw_, zzzx_);
        IEnumerable<IEnumerable<Encounter.LocationComponent>> zzzz_ = context.Operators.Distinct<IEnumerable<Encounter.LocationComponent>>(zzzy_);
        IEnumerable<Encounter.LocationComponent> azzza_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(zzzz_);

        return azzza_;
    }


    [CqlExpressionDefinition("hospitalizationLocations")]
    [CqlTag("description", "Returns list of all locations within an encounter, including locations for immediately prior ED visit.")]
    public IEnumerable<Encounter.LocationComponent> hospitalizationLocations(CqlContext context, Encounter TheEncounter)
    {
        Encounter azzzh_ = this.edVisit(context, TheEncounter);
        Encounter[] azzzi_ = [
            azzzh_,
        ];
        IEnumerable<Encounter.LocationComponent> azzzj_(Encounter EDEncounter)
        {
            IEnumerable<Encounter.LocationComponent> azzzn_()
            {
                if (EDEncounter is null)
                {
                    List<Encounter.LocationComponent> azzzo_ = TheEncounter?.Location;

                    return (IEnumerable<Encounter.LocationComponent>)azzzo_;
                }
                else
                {
                    List<Encounter.LocationComponent> azzzp_ = EDEncounter?.Location;
                    List<Encounter.LocationComponent> azzzq_ = TheEncounter?.Location;
                    IEnumerable<Encounter.LocationComponent>[] azzzr_ = [
                        (IEnumerable<Encounter.LocationComponent>)azzzp_,
                        (IEnumerable<Encounter.LocationComponent>)azzzq_,
                    ];
                    IEnumerable<Encounter.LocationComponent> azzzs_ = context.Operators.Flatten<Encounter.LocationComponent>(azzzr_ as IEnumerable<IEnumerable<Encounter.LocationComponent>>);

                    return azzzs_;
                }
            };

            return azzzn_();
        };
        IEnumerable<IEnumerable<Encounter.LocationComponent>> azzzk_ = context.Operators.Select<Encounter, IEnumerable<Encounter.LocationComponent>>((IEnumerable<Encounter>)azzzi_, azzzj_);
        IEnumerable<IEnumerable<Encounter.LocationComponent>> azzzl_ = context.Operators.Distinct<IEnumerable<Encounter.LocationComponent>>(azzzk_);
        IEnumerable<Encounter.LocationComponent> azzzm_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(azzzl_);

        return azzzm_;
    }


    [CqlExpressionDefinition("Hospitalization Length of Stay")]
    [CqlTag("description", "Returns the length of stay in days (i.e. the number of days between admission and discharge) for the given encounter, or from the admission of any immediately prior emergency department visit to the discharge of the encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationLengthOfStay()` instead.")]
    public int? Hospitalization_Length_of_Stay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> azzzt_ = this.Hospitalization(context, TheEncounter);
        int? azzzu_ = this.LengthInDays(context, azzzt_);

        return azzzu_;
    }


    [CqlExpressionDefinition("hospitalizationLengthOfStay")]
    [CqlTag("description", "Returns the length of stay in days (i.e. the number of days between admission and discharge) for the given encounter, or from the admission of any immediately prior emergency department visit to the discharge of the encounter")]
    public int? hospitalizationLengthOfStay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> azzzv_ = this.hospitalization(context, TheEncounter);
        int? azzzw_ = this.lengthInDays(context, azzzv_);

        return azzzw_;
    }


    [CqlExpressionDefinition("Hospital Admission Time")]
    [CqlTag("description", "Returns admission time for an encounter or for immediately prior emergency department visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalAdmissionTime()` instead.")]
    public CqlDateTime Hospital_Admission_Time(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> azzzx_ = this.Hospitalization(context, TheEncounter);
        CqlDateTime azzzy_ = context.Operators.Start(azzzx_);

        return azzzy_;
    }


    [CqlExpressionDefinition("hospitalAdmissionTime")]
    [CqlTag("description", "Returns admission time for an encounter or for immediately prior emergency department visit.")]
    public CqlDateTime hospitalAdmissionTime(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> azzzz_ = this.hospitalization(context, TheEncounter);
        CqlDateTime bzzza_ = context.Operators.Start(azzzz_);

        return bzzza_;
    }


    [CqlExpressionDefinition("Hospital Discharge Time")]
    [CqlTag("description", "Hospital Discharge Time returns the discharge time for an encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalDischargeTime()` instead.")]
    public CqlDateTime Hospital_Discharge_Time(CqlContext context, Encounter TheEncounter)
    {
        Period bzzzb_ = TheEncounter?.Period;
        CqlInterval<CqlDateTime> bzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzb_);
        CqlDateTime bzzzd_ = context.Operators.End(bzzzc_);

        return bzzzd_;
    }


    [CqlExpressionDefinition("hospitalDischargeTime")]
    [CqlTag("description", "Hospital Discharge Time returns the discharge time for an encounter")]
    public CqlDateTime hospitalDischargeTime(CqlContext context, Encounter TheEncounter)
    {
        Period bzzze_ = TheEncounter?.Period;
        CqlInterval<CqlDateTime> bzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzze_);
        CqlDateTime bzzzg_ = context.Operators.End(bzzzf_);

        return bzzzg_;
    }


    [CqlExpressionDefinition("Hospital Arrival Time")]
    [CqlTag("description", "Returns earliest arrival time for an encounter including any prior ED visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalArrivalTime()` instead.")]
    public CqlDateTime Hospital_Arrival_Time(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> bzzzh_ = this.Hospitalization_Locations(context, TheEncounter);
        object bzzzi_(Encounter.LocationComponent @this)
        {
            Period bzzzo_ = @this?.Period;
            CqlInterval<CqlDateTime> bzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzo_);
            CqlDateTime bzzzq_ = context.Operators.Start(bzzzp_);

            return bzzzq_;
        };
        IEnumerable<Encounter.LocationComponent> bzzzj_ = context.Operators.SortBy<Encounter.LocationComponent>(bzzzh_, bzzzi_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent bzzzk_ = context.Operators.First<Encounter.LocationComponent>(bzzzj_);
        Period bzzzl_ = bzzzk_?.Period;
        CqlInterval<CqlDateTime> bzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzl_);
        CqlDateTime bzzzn_ = context.Operators.Start(bzzzm_);

        return bzzzn_;
    }


    [CqlExpressionDefinition("hospitalArrivalTime")]
    [CqlTag("description", "Returns earliest arrival time for an encounter including any prior ED visit.")]
    public CqlDateTime hospitalArrivalTime(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> bzzzr_ = this.hospitalizationLocations(context, TheEncounter);
        object bzzzs_(Encounter.LocationComponent @this)
        {
            Period bzzzy_ = @this?.Period;
            CqlInterval<CqlDateTime> bzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzy_);
            CqlDateTime czzza_ = context.Operators.Start(bzzzz_);

            return czzza_;
        };
        IEnumerable<Encounter.LocationComponent> bzzzt_ = context.Operators.SortBy<Encounter.LocationComponent>(bzzzr_, bzzzs_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent bzzzu_ = context.Operators.First<Encounter.LocationComponent>(bzzzt_);
        Period bzzzv_ = bzzzu_?.Period;
        CqlInterval<CqlDateTime> bzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzv_);
        CqlDateTime bzzzx_ = context.Operators.Start(bzzzw_);

        return bzzzx_;
    }


    [CqlExpressionDefinition("Hospital Departure Time")]
    [CqlTag("description", "Returns the latest departure time for encounter including any prior ED visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalDepartureTime()` instead.")]
    public CqlDateTime Hospital_Departure_Time(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> czzzb_ = this.Hospitalization_Locations(context, TheEncounter);
        object czzzc_(Encounter.LocationComponent @this)
        {
            Period czzzi_ = @this?.Period;
            CqlInterval<CqlDateTime> czzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzi_);
            CqlDateTime czzzk_ = context.Operators.Start(czzzj_);

            return czzzk_;
        };
        IEnumerable<Encounter.LocationComponent> czzzd_ = context.Operators.SortBy<Encounter.LocationComponent>(czzzb_, czzzc_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent czzze_ = context.Operators.Last<Encounter.LocationComponent>(czzzd_);
        Period czzzf_ = czzze_?.Period;
        CqlInterval<CqlDateTime> czzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzf_);
        CqlDateTime czzzh_ = context.Operators.End(czzzg_);

        return czzzh_;
    }


    [CqlExpressionDefinition("hospitalDepartureTime")]
    [CqlTag("description", "Returns the latest departure time for encounter including any prior ED visit.")]
    public CqlDateTime hospitalDepartureTime(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> czzzl_ = this.hospitalizationLocations(context, TheEncounter);
        object czzzm_(Encounter.LocationComponent @this)
        {
            Period czzzs_ = @this?.Period;
            CqlInterval<CqlDateTime> czzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzs_);
            CqlDateTime czzzu_ = context.Operators.Start(czzzt_);

            return czzzu_;
        };
        IEnumerable<Encounter.LocationComponent> czzzn_ = context.Operators.SortBy<Encounter.LocationComponent>(czzzl_, czzzm_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent czzzo_ = context.Operators.Last<Encounter.LocationComponent>(czzzn_);
        Period czzzp_ = czzzo_?.Period;
        CqlInterval<CqlDateTime> czzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzp_);
        CqlDateTime czzzr_ = context.Operators.End(czzzq_);

        return czzzr_;
    }


    [CqlExpressionDefinition("GetLocation")]
    [CqlTag("description", "Returns the Location resource specified by the given reference")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getLocation()` instead.")]
    public Location GetLocation(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Location> czzzv_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-location"));
        bool? czzzw_(Location L)
        {
            Id czzzz_ = L?.IdElement;
            string dzzza_ = czzzz_?.Value;
            FhirString dzzzb_ = reference?.ReferenceElement;
            string dzzzc_ = dzzzb_?.Value;
            string dzzzd_ = QICoreCommon_2_1_000.Instance.getId(context, dzzzc_);
            bool? dzzze_ = context.Operators.Equal(dzzza_, dzzzd_);

            return dzzze_;
        };
        IEnumerable<Location> czzzx_ = context.Operators.Where<Location>(czzzv_, czzzw_);
        Location czzzy_ = context.Operators.SingletonFrom<Location>(czzzx_);

        return czzzy_;
    }


    [CqlExpressionDefinition("Emergency Department Arrival Time")]
    [CqlTag("description", "Returns the emergency department arrival time for the encounter.")]
    public CqlDateTime Emergency_Department_Arrival_Time(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> dzzzf_ = this.Hospitalization_Locations(context, TheEncounter);
        bool? dzzzg_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference dzzzm_ = HospitalLocation?.Location;
            Location dzzzn_ = this.GetLocation(context, dzzzm_);
            List<CodeableConcept> dzzzo_ = dzzzn_?.Type;
            CqlConcept dzzzp_(CodeableConcept @this)
            {
                CqlConcept dzzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return dzzzt_;
            };
            IEnumerable<CqlConcept> dzzzq_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)dzzzo_, dzzzp_);
            CqlValueSet dzzzr_ = this.Emergency_Department_Visit(context);
            bool? dzzzs_ = context.Operators.ConceptsInValueSet(dzzzq_, dzzzr_);

            return dzzzs_;
        };
        IEnumerable<Encounter.LocationComponent> dzzzh_ = context.Operators.Where<Encounter.LocationComponent>(dzzzf_, dzzzg_);
        Encounter.LocationComponent dzzzi_ = context.Operators.SingletonFrom<Encounter.LocationComponent>(dzzzh_);
        Period dzzzj_ = dzzzi_?.Period;
        CqlInterval<CqlDateTime> dzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzj_);
        CqlDateTime dzzzl_ = context.Operators.Start(dzzzk_);

        return dzzzl_;
    }


    [CqlExpressionDefinition("emergencyDepartmentArrivalTime")]
    [CqlTag("description", "Returns the emergency department arrival time for the encounter.")]
    public CqlDateTime emergencyDepartmentArrivalTime(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> dzzzu_ = this.hospitalizationLocations(context, TheEncounter);
        bool? dzzzv_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference ezzzb_ = HospitalLocation?.Location;
            Location ezzzc_ = this.GetLocation(context, ezzzb_);
            List<CodeableConcept> ezzzd_ = ezzzc_?.Type;
            CqlConcept ezzze_(CodeableConcept @this)
            {
                CqlConcept ezzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return ezzzi_;
            };
            IEnumerable<CqlConcept> ezzzf_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ezzzd_, ezzze_);
            CqlValueSet ezzzg_ = this.Emergency_Department_Visit(context);
            bool? ezzzh_ = context.Operators.ConceptsInValueSet(ezzzf_, ezzzg_);

            return ezzzh_;
        };
        IEnumerable<Encounter.LocationComponent> dzzzw_ = context.Operators.Where<Encounter.LocationComponent>(dzzzu_, dzzzv_);
        Encounter.LocationComponent dzzzx_ = context.Operators.SingletonFrom<Encounter.LocationComponent>(dzzzw_);
        Period dzzzy_ = dzzzx_?.Period;
        CqlInterval<CqlDateTime> dzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzy_);
        CqlDateTime ezzza_ = context.Operators.Start(dzzzz_);

        return ezzza_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservationAndOutpatientSurgeryService")]
    [CqlTag("description", "Hospitalization with Observation and Outpatient Surgery Service returns the total interval from the start of any immediately prior emergency department visit, outpatient surgery visit or observation visit to the discharge of the given encounter.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationWithObservationAndOutpatientSurgeryService()` instead.")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservationAndOutpatientSurgeryService(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] ezzzj_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> ezzzk_(Encounter Visit)
        {
            CqlValueSet ezzzo_ = this.Outpatient_Surgery_Service(context);
            IEnumerable<Encounter> ezzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? ezzzq_(Encounter LastSurgeryOP)
            {
                Period fzzzz_ = LastSurgeryOP?.Period;
                CqlInterval<CqlDateTime> gzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzz_);
                CqlDateTime gzzzb_ = context.Operators.End(gzzza_);
                CqlValueSet gzzzc_ = this.Emergency_Department_Visit(context);
                IEnumerable<Encounter> gzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? gzzze_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> izzzz_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? jzzza_ = izzzz_?.Value;
                    Code<Encounter.EncounterStatus> jzzzb_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jzzza_);
                    bool? jzzzc_ = context.Operators.Equal(jzzzb_, "finished");
                    Period jzzzd_ = LastED?.Period;
                    CqlInterval<CqlDateTime> jzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzd_);
                    CqlDateTime jzzzf_ = context.Operators.End(jzzze_);
                    CqlValueSet jzzzg_ = this.Observation_Services(context);
                    IEnumerable<Encounter> jzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? jzzzi_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> lzzza_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? lzzzb_ = lzzza_?.Value;
                        Code<Encounter.EncounterStatus> lzzzc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lzzzb_);
                        bool? lzzzd_ = context.Operators.Equal(lzzzc_, "finished");
                        Period lzzze_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> lzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzze_);
                        CqlDateTime lzzzg_ = context.Operators.End(lzzzf_);
                        Period lzzzh_ = Visit?.Period;
                        CqlInterval<CqlDateTime> lzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzh_);
                        CqlDateTime lzzzj_ = context.Operators.Start(lzzzi_);
                        CqlQuantity lzzzk_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime lzzzl_ = context.Operators.Subtract(lzzzj_, lzzzk_);
                        CqlInterval<CqlDateTime> lzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzh_);
                        CqlDateTime lzzzo_ = context.Operators.Start(lzzzn_);
                        CqlInterval<CqlDateTime> lzzzp_ = context.Operators.Interval(lzzzl_, lzzzo_, true, true);
                        bool? lzzzq_ = context.Operators.In<CqlDateTime>(lzzzg_, lzzzp_, default);
                        CqlInterval<CqlDateTime> lzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzh_);
                        CqlDateTime lzzzt_ = context.Operators.Start(lzzzs_);
                        bool? lzzzu_ = context.Operators.Not((bool?)(lzzzt_ is null));
                        bool? lzzzv_ = context.Operators.And(lzzzq_, lzzzu_);
                        bool? lzzzw_ = context.Operators.And(lzzzd_, lzzzv_);

                        return lzzzw_;
                    };
                    IEnumerable<Encounter> jzzzj_ = context.Operators.Where<Encounter>(jzzzh_, jzzzi_);
                    object jzzzk_(Encounter @this)
                    {
                        Period lzzzx_ = @this?.Period;
                        CqlInterval<CqlDateTime> lzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzx_);
                        CqlDateTime lzzzz_ = context.Operators.End(lzzzy_);

                        return lzzzz_;
                    };
                    IEnumerable<Encounter> jzzzl_ = context.Operators.SortBy<Encounter>(jzzzj_, jzzzk_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter jzzzm_ = context.Operators.Last<Encounter>(jzzzl_);
                    Period jzzzn_ = jzzzm_?.Period;
                    CqlInterval<CqlDateTime> jzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzn_);
                    CqlDateTime jzzzp_ = context.Operators.Start(jzzzo_);
                    Period jzzzq_ = Visit?.Period;
                    CqlInterval<CqlDateTime> jzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzq_);
                    CqlDateTime jzzzs_ = context.Operators.Start(jzzzr_);
                    CqlQuantity jzzzt_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime jzzzu_ = context.Operators.Subtract(jzzzp_ ?? jzzzs_, jzzzt_);
                    IEnumerable<Encounter> jzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? jzzzx_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> mzzza_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? mzzzb_ = mzzza_?.Value;
                        Code<Encounter.EncounterStatus> mzzzc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(mzzzb_);
                        bool? mzzzd_ = context.Operators.Equal(mzzzc_, "finished");
                        Period mzzze_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> mzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzze_);
                        CqlDateTime mzzzg_ = context.Operators.End(mzzzf_);
                        Period mzzzh_ = Visit?.Period;
                        CqlInterval<CqlDateTime> mzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzh_);
                        CqlDateTime mzzzj_ = context.Operators.Start(mzzzi_);
                        CqlQuantity mzzzk_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime mzzzl_ = context.Operators.Subtract(mzzzj_, mzzzk_);
                        CqlInterval<CqlDateTime> mzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzh_);
                        CqlDateTime mzzzo_ = context.Operators.Start(mzzzn_);
                        CqlInterval<CqlDateTime> mzzzp_ = context.Operators.Interval(mzzzl_, mzzzo_, true, true);
                        bool? mzzzq_ = context.Operators.In<CqlDateTime>(mzzzg_, mzzzp_, default);
                        CqlInterval<CqlDateTime> mzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzh_);
                        CqlDateTime mzzzt_ = context.Operators.Start(mzzzs_);
                        bool? mzzzu_ = context.Operators.Not((bool?)(mzzzt_ is null));
                        bool? mzzzv_ = context.Operators.And(mzzzq_, mzzzu_);
                        bool? mzzzw_ = context.Operators.And(mzzzd_, mzzzv_);

                        return mzzzw_;
                    };
                    IEnumerable<Encounter> jzzzy_ = context.Operators.Where<Encounter>(jzzzw_, jzzzx_);
                    object jzzzz_(Encounter @this)
                    {
                        Period mzzzx_ = @this?.Period;
                        CqlInterval<CqlDateTime> mzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzx_);
                        CqlDateTime mzzzz_ = context.Operators.End(mzzzy_);

                        return mzzzz_;
                    };
                    IEnumerable<Encounter> kzzza_ = context.Operators.SortBy<Encounter>(jzzzy_, jzzzz_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter kzzzb_ = context.Operators.Last<Encounter>(kzzza_);
                    Period kzzzc_ = kzzzb_?.Period;
                    CqlInterval<CqlDateTime> kzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzc_);
                    CqlDateTime kzzze_ = context.Operators.Start(kzzzd_);
                    CqlInterval<CqlDateTime> kzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzq_);
                    CqlDateTime kzzzh_ = context.Operators.Start(kzzzg_);
                    CqlInterval<CqlDateTime> kzzzi_ = context.Operators.Interval(jzzzu_, kzzze_ ?? kzzzh_, true, true);
                    bool? kzzzj_ = context.Operators.In<CqlDateTime>(jzzzf_, kzzzi_, default);
                    IEnumerable<Encounter> kzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? kzzzm_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> nzzza_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? nzzzb_ = nzzza_?.Value;
                        Code<Encounter.EncounterStatus> nzzzc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(nzzzb_);
                        bool? nzzzd_ = context.Operators.Equal(nzzzc_, "finished");
                        Period nzzze_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> nzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzze_);
                        CqlDateTime nzzzg_ = context.Operators.End(nzzzf_);
                        Period nzzzh_ = Visit?.Period;
                        CqlInterval<CqlDateTime> nzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzh_);
                        CqlDateTime nzzzj_ = context.Operators.Start(nzzzi_);
                        CqlQuantity nzzzk_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime nzzzl_ = context.Operators.Subtract(nzzzj_, nzzzk_);
                        CqlInterval<CqlDateTime> nzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzh_);
                        CqlDateTime nzzzo_ = context.Operators.Start(nzzzn_);
                        CqlInterval<CqlDateTime> nzzzp_ = context.Operators.Interval(nzzzl_, nzzzo_, true, true);
                        bool? nzzzq_ = context.Operators.In<CqlDateTime>(nzzzg_, nzzzp_, default);
                        CqlInterval<CqlDateTime> nzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzh_);
                        CqlDateTime nzzzt_ = context.Operators.Start(nzzzs_);
                        bool? nzzzu_ = context.Operators.Not((bool?)(nzzzt_ is null));
                        bool? nzzzv_ = context.Operators.And(nzzzq_, nzzzu_);
                        bool? nzzzw_ = context.Operators.And(nzzzd_, nzzzv_);

                        return nzzzw_;
                    };
                    IEnumerable<Encounter> kzzzn_ = context.Operators.Where<Encounter>(kzzzl_, kzzzm_);
                    object kzzzo_(Encounter @this)
                    {
                        Period nzzzx_ = @this?.Period;
                        CqlInterval<CqlDateTime> nzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzx_);
                        CqlDateTime nzzzz_ = context.Operators.End(nzzzy_);

                        return nzzzz_;
                    };
                    IEnumerable<Encounter> kzzzp_ = context.Operators.SortBy<Encounter>(kzzzn_, kzzzo_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter kzzzq_ = context.Operators.Last<Encounter>(kzzzp_);
                    Period kzzzr_ = kzzzq_?.Period;
                    CqlInterval<CqlDateTime> kzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzr_);
                    CqlDateTime kzzzt_ = context.Operators.Start(kzzzs_);
                    CqlInterval<CqlDateTime> kzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzq_);
                    CqlDateTime kzzzw_ = context.Operators.Start(kzzzv_);
                    bool? kzzzx_ = context.Operators.Not((bool?)((kzzzt_ ?? kzzzw_) is null));
                    bool? kzzzy_ = context.Operators.And(kzzzj_, kzzzx_);
                    bool? kzzzz_ = context.Operators.And(jzzzc_, kzzzy_);

                    return kzzzz_;
                };
                IEnumerable<Encounter> gzzzf_ = context.Operators.Where<Encounter>(gzzzd_, gzzze_);
                object gzzzg_(Encounter @this)
                {
                    Period ozzza_ = @this?.Period;
                    CqlInterval<CqlDateTime> ozzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzza_);
                    CqlDateTime ozzzc_ = context.Operators.End(ozzzb_);

                    return ozzzc_;
                };
                IEnumerable<Encounter> gzzzh_ = context.Operators.SortBy<Encounter>(gzzzf_, gzzzg_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter gzzzi_ = context.Operators.Last<Encounter>(gzzzh_);
                Period gzzzj_ = gzzzi_?.Period;
                CqlInterval<CqlDateTime> gzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzj_);
                CqlDateTime gzzzl_ = context.Operators.Start(gzzzk_);
                CqlValueSet gzzzm_ = this.Observation_Services(context);
                IEnumerable<Encounter> gzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? gzzzo_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> ozzzd_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? ozzze_ = ozzzd_?.Value;
                    Code<Encounter.EncounterStatus> ozzzf_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ozzze_);
                    bool? ozzzg_ = context.Operators.Equal(ozzzf_, "finished");
                    Period ozzzh_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> ozzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzh_);
                    CqlDateTime ozzzj_ = context.Operators.End(ozzzi_);
                    Period ozzzk_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ozzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzk_);
                    CqlDateTime ozzzm_ = context.Operators.Start(ozzzl_);
                    CqlQuantity ozzzn_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ozzzo_ = context.Operators.Subtract(ozzzm_, ozzzn_);
                    CqlInterval<CqlDateTime> ozzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzk_);
                    CqlDateTime ozzzr_ = context.Operators.Start(ozzzq_);
                    CqlInterval<CqlDateTime> ozzzs_ = context.Operators.Interval(ozzzo_, ozzzr_, true, true);
                    bool? ozzzt_ = context.Operators.In<CqlDateTime>(ozzzj_, ozzzs_, default);
                    CqlInterval<CqlDateTime> ozzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzk_);
                    CqlDateTime ozzzw_ = context.Operators.Start(ozzzv_);
                    bool? ozzzx_ = context.Operators.Not((bool?)(ozzzw_ is null));
                    bool? ozzzy_ = context.Operators.And(ozzzt_, ozzzx_);
                    bool? ozzzz_ = context.Operators.And(ozzzg_, ozzzy_);

                    return ozzzz_;
                };
                IEnumerable<Encounter> gzzzp_ = context.Operators.Where<Encounter>(gzzzn_, gzzzo_);
                object gzzzq_(Encounter @this)
                {
                    Period pzzza_ = @this?.Period;
                    CqlInterval<CqlDateTime> pzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzza_);
                    CqlDateTime pzzzc_ = context.Operators.End(pzzzb_);

                    return pzzzc_;
                };
                IEnumerable<Encounter> gzzzr_ = context.Operators.SortBy<Encounter>(gzzzp_, gzzzq_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter gzzzs_ = context.Operators.Last<Encounter>(gzzzr_);
                Period gzzzt_ = gzzzs_?.Period;
                CqlInterval<CqlDateTime> gzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzt_);
                CqlDateTime gzzzv_ = context.Operators.Start(gzzzu_);
                Period gzzzw_ = Visit?.Period;
                CqlInterval<CqlDateTime> gzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzw_);
                CqlDateTime gzzzy_ = context.Operators.Start(gzzzx_);
                CqlQuantity gzzzz_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime hzzza_ = context.Operators.Subtract(gzzzl_ ?? gzzzv_ ?? gzzzy_, gzzzz_);
                IEnumerable<Encounter> hzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? hzzzd_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> pzzzd_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? pzzze_ = pzzzd_?.Value;
                    Code<Encounter.EncounterStatus> pzzzf_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pzzze_);
                    bool? pzzzg_ = context.Operators.Equal(pzzzf_, "finished");
                    Period pzzzh_ = LastED?.Period;
                    CqlInterval<CqlDateTime> pzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzh_);
                    CqlDateTime pzzzj_ = context.Operators.End(pzzzi_);
                    CqlValueSet pzzzk_ = this.Observation_Services(context);
                    IEnumerable<Encounter> pzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? pzzzm_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> rzzze_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? rzzzf_ = rzzze_?.Value;
                        Code<Encounter.EncounterStatus> rzzzg_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rzzzf_);
                        bool? rzzzh_ = context.Operators.Equal(rzzzg_, "finished");
                        Period rzzzi_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> rzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzi_);
                        CqlDateTime rzzzk_ = context.Operators.End(rzzzj_);
                        Period rzzzl_ = Visit?.Period;
                        CqlInterval<CqlDateTime> rzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzl_);
                        CqlDateTime rzzzn_ = context.Operators.Start(rzzzm_);
                        CqlQuantity rzzzo_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime rzzzp_ = context.Operators.Subtract(rzzzn_, rzzzo_);
                        CqlInterval<CqlDateTime> rzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzl_);
                        CqlDateTime rzzzs_ = context.Operators.Start(rzzzr_);
                        CqlInterval<CqlDateTime> rzzzt_ = context.Operators.Interval(rzzzp_, rzzzs_, true, true);
                        bool? rzzzu_ = context.Operators.In<CqlDateTime>(rzzzk_, rzzzt_, default);
                        CqlInterval<CqlDateTime> rzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzl_);
                        CqlDateTime rzzzx_ = context.Operators.Start(rzzzw_);
                        bool? rzzzy_ = context.Operators.Not((bool?)(rzzzx_ is null));
                        bool? rzzzz_ = context.Operators.And(rzzzu_, rzzzy_);
                        bool? szzza_ = context.Operators.And(rzzzh_, rzzzz_);

                        return szzza_;
                    };
                    IEnumerable<Encounter> pzzzn_ = context.Operators.Where<Encounter>(pzzzl_, pzzzm_);
                    object pzzzo_(Encounter @this)
                    {
                        Period szzzb_ = @this?.Period;
                        CqlInterval<CqlDateTime> szzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzb_);
                        CqlDateTime szzzd_ = context.Operators.End(szzzc_);

                        return szzzd_;
                    };
                    IEnumerable<Encounter> pzzzp_ = context.Operators.SortBy<Encounter>(pzzzn_, pzzzo_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter pzzzq_ = context.Operators.Last<Encounter>(pzzzp_);
                    Period pzzzr_ = pzzzq_?.Period;
                    CqlInterval<CqlDateTime> pzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzr_);
                    CqlDateTime pzzzt_ = context.Operators.Start(pzzzs_);
                    Period pzzzu_ = Visit?.Period;
                    CqlInterval<CqlDateTime> pzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzu_);
                    CqlDateTime pzzzw_ = context.Operators.Start(pzzzv_);
                    CqlQuantity pzzzx_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime pzzzy_ = context.Operators.Subtract(pzzzt_ ?? pzzzw_, pzzzx_);
                    IEnumerable<Encounter> qzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? qzzzb_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> szzze_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? szzzf_ = szzze_?.Value;
                        Code<Encounter.EncounterStatus> szzzg_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(szzzf_);
                        bool? szzzh_ = context.Operators.Equal(szzzg_, "finished");
                        Period szzzi_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> szzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzi_);
                        CqlDateTime szzzk_ = context.Operators.End(szzzj_);
                        Period szzzl_ = Visit?.Period;
                        CqlInterval<CqlDateTime> szzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzl_);
                        CqlDateTime szzzn_ = context.Operators.Start(szzzm_);
                        CqlQuantity szzzo_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime szzzp_ = context.Operators.Subtract(szzzn_, szzzo_);
                        CqlInterval<CqlDateTime> szzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzl_);
                        CqlDateTime szzzs_ = context.Operators.Start(szzzr_);
                        CqlInterval<CqlDateTime> szzzt_ = context.Operators.Interval(szzzp_, szzzs_, true, true);
                        bool? szzzu_ = context.Operators.In<CqlDateTime>(szzzk_, szzzt_, default);
                        CqlInterval<CqlDateTime> szzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzl_);
                        CqlDateTime szzzx_ = context.Operators.Start(szzzw_);
                        bool? szzzy_ = context.Operators.Not((bool?)(szzzx_ is null));
                        bool? szzzz_ = context.Operators.And(szzzu_, szzzy_);
                        bool? tzzza_ = context.Operators.And(szzzh_, szzzz_);

                        return tzzza_;
                    };
                    IEnumerable<Encounter> qzzzc_ = context.Operators.Where<Encounter>(qzzza_, qzzzb_);
                    object qzzzd_(Encounter @this)
                    {
                        Period tzzzb_ = @this?.Period;
                        CqlInterval<CqlDateTime> tzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzb_);
                        CqlDateTime tzzzd_ = context.Operators.End(tzzzc_);

                        return tzzzd_;
                    };
                    IEnumerable<Encounter> qzzze_ = context.Operators.SortBy<Encounter>(qzzzc_, qzzzd_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter qzzzf_ = context.Operators.Last<Encounter>(qzzze_);
                    Period qzzzg_ = qzzzf_?.Period;
                    CqlInterval<CqlDateTime> qzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzg_);
                    CqlDateTime qzzzi_ = context.Operators.Start(qzzzh_);
                    CqlInterval<CqlDateTime> qzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzu_);
                    CqlDateTime qzzzl_ = context.Operators.Start(qzzzk_);
                    CqlInterval<CqlDateTime> qzzzm_ = context.Operators.Interval(pzzzy_, qzzzi_ ?? qzzzl_, true, true);
                    bool? qzzzn_ = context.Operators.In<CqlDateTime>(pzzzj_, qzzzm_, default);
                    IEnumerable<Encounter> qzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? qzzzq_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> tzzze_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? tzzzf_ = tzzze_?.Value;
                        Code<Encounter.EncounterStatus> tzzzg_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(tzzzf_);
                        bool? tzzzh_ = context.Operators.Equal(tzzzg_, "finished");
                        Period tzzzi_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> tzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzi_);
                        CqlDateTime tzzzk_ = context.Operators.End(tzzzj_);
                        Period tzzzl_ = Visit?.Period;
                        CqlInterval<CqlDateTime> tzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzl_);
                        CqlDateTime tzzzn_ = context.Operators.Start(tzzzm_);
                        CqlQuantity tzzzo_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime tzzzp_ = context.Operators.Subtract(tzzzn_, tzzzo_);
                        CqlInterval<CqlDateTime> tzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzl_);
                        CqlDateTime tzzzs_ = context.Operators.Start(tzzzr_);
                        CqlInterval<CqlDateTime> tzzzt_ = context.Operators.Interval(tzzzp_, tzzzs_, true, true);
                        bool? tzzzu_ = context.Operators.In<CqlDateTime>(tzzzk_, tzzzt_, default);
                        CqlInterval<CqlDateTime> tzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzl_);
                        CqlDateTime tzzzx_ = context.Operators.Start(tzzzw_);
                        bool? tzzzy_ = context.Operators.Not((bool?)(tzzzx_ is null));
                        bool? tzzzz_ = context.Operators.And(tzzzu_, tzzzy_);
                        bool? uzzza_ = context.Operators.And(tzzzh_, tzzzz_);

                        return uzzza_;
                    };
                    IEnumerable<Encounter> qzzzr_ = context.Operators.Where<Encounter>(qzzzp_, qzzzq_);
                    object qzzzs_(Encounter @this)
                    {
                        Period uzzzb_ = @this?.Period;
                        CqlInterval<CqlDateTime> uzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzb_);
                        CqlDateTime uzzzd_ = context.Operators.End(uzzzc_);

                        return uzzzd_;
                    };
                    IEnumerable<Encounter> qzzzt_ = context.Operators.SortBy<Encounter>(qzzzr_, qzzzs_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter qzzzu_ = context.Operators.Last<Encounter>(qzzzt_);
                    Period qzzzv_ = qzzzu_?.Period;
                    CqlInterval<CqlDateTime> qzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzv_);
                    CqlDateTime qzzzx_ = context.Operators.Start(qzzzw_);
                    CqlInterval<CqlDateTime> qzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzu_);
                    CqlDateTime rzzza_ = context.Operators.Start(qzzzz_);
                    bool? rzzzb_ = context.Operators.Not((bool?)((qzzzx_ ?? rzzza_) is null));
                    bool? rzzzc_ = context.Operators.And(qzzzn_, rzzzb_);
                    bool? rzzzd_ = context.Operators.And(pzzzg_, rzzzc_);

                    return rzzzd_;
                };
                IEnumerable<Encounter> hzzze_ = context.Operators.Where<Encounter>(hzzzc_, hzzzd_);
                object hzzzf_(Encounter @this)
                {
                    Period uzzze_ = @this?.Period;
                    CqlInterval<CqlDateTime> uzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzze_);
                    CqlDateTime uzzzg_ = context.Operators.End(uzzzf_);

                    return uzzzg_;
                };
                IEnumerable<Encounter> hzzzg_ = context.Operators.SortBy<Encounter>(hzzze_, hzzzf_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter hzzzh_ = context.Operators.Last<Encounter>(hzzzg_);
                Period hzzzi_ = hzzzh_?.Period;
                CqlInterval<CqlDateTime> hzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzi_);
                CqlDateTime hzzzk_ = context.Operators.Start(hzzzj_);
                IEnumerable<Encounter> hzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? hzzzn_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> uzzzh_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? uzzzi_ = uzzzh_?.Value;
                    Code<Encounter.EncounterStatus> uzzzj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(uzzzi_);
                    bool? uzzzk_ = context.Operators.Equal(uzzzj_, "finished");
                    Period uzzzl_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> uzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzl_);
                    CqlDateTime uzzzn_ = context.Operators.End(uzzzm_);
                    Period uzzzo_ = Visit?.Period;
                    CqlInterval<CqlDateTime> uzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzo_);
                    CqlDateTime uzzzq_ = context.Operators.Start(uzzzp_);
                    CqlQuantity uzzzr_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime uzzzs_ = context.Operators.Subtract(uzzzq_, uzzzr_);
                    CqlInterval<CqlDateTime> uzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzo_);
                    CqlDateTime uzzzv_ = context.Operators.Start(uzzzu_);
                    CqlInterval<CqlDateTime> uzzzw_ = context.Operators.Interval(uzzzs_, uzzzv_, true, true);
                    bool? uzzzx_ = context.Operators.In<CqlDateTime>(uzzzn_, uzzzw_, default);
                    CqlInterval<CqlDateTime> uzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzo_);
                    CqlDateTime vzzza_ = context.Operators.Start(uzzzz_);
                    bool? vzzzb_ = context.Operators.Not((bool?)(vzzza_ is null));
                    bool? vzzzc_ = context.Operators.And(uzzzx_, vzzzb_);
                    bool? vzzzd_ = context.Operators.And(uzzzk_, vzzzc_);

                    return vzzzd_;
                };
                IEnumerable<Encounter> hzzzo_ = context.Operators.Where<Encounter>(hzzzm_, hzzzn_);
                object hzzzp_(Encounter @this)
                {
                    Period vzzze_ = @this?.Period;
                    CqlInterval<CqlDateTime> vzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzze_);
                    CqlDateTime vzzzg_ = context.Operators.End(vzzzf_);

                    return vzzzg_;
                };
                IEnumerable<Encounter> hzzzq_ = context.Operators.SortBy<Encounter>(hzzzo_, hzzzp_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter hzzzr_ = context.Operators.Last<Encounter>(hzzzq_);
                Period hzzzs_ = hzzzr_?.Period;
                CqlInterval<CqlDateTime> hzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzs_);
                CqlDateTime hzzzu_ = context.Operators.Start(hzzzt_);
                CqlInterval<CqlDateTime> hzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzw_);
                CqlDateTime hzzzx_ = context.Operators.Start(hzzzw_);
                CqlInterval<CqlDateTime> hzzzy_ = context.Operators.Interval(hzzza_, hzzzk_ ?? hzzzu_ ?? hzzzx_, true, true);
                bool? hzzzz_ = context.Operators.In<CqlDateTime>(gzzzb_, hzzzy_, default);
                IEnumerable<Encounter> izzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? izzzc_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> vzzzh_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? vzzzi_ = vzzzh_?.Value;
                    Code<Encounter.EncounterStatus> vzzzj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(vzzzi_);
                    bool? vzzzk_ = context.Operators.Equal(vzzzj_, "finished");
                    Period vzzzl_ = LastED?.Period;
                    CqlInterval<CqlDateTime> vzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzl_);
                    CqlDateTime vzzzn_ = context.Operators.End(vzzzm_);
                    CqlValueSet vzzzo_ = this.Observation_Services(context);
                    IEnumerable<Encounter> vzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? vzzzq_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> xzzzi_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? xzzzj_ = xzzzi_?.Value;
                        Code<Encounter.EncounterStatus> xzzzk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(xzzzj_);
                        bool? xzzzl_ = context.Operators.Equal(xzzzk_, "finished");
                        Period xzzzm_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> xzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzm_);
                        CqlDateTime xzzzo_ = context.Operators.End(xzzzn_);
                        Period xzzzp_ = Visit?.Period;
                        CqlInterval<CqlDateTime> xzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzp_);
                        CqlDateTime xzzzr_ = context.Operators.Start(xzzzq_);
                        CqlQuantity xzzzs_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime xzzzt_ = context.Operators.Subtract(xzzzr_, xzzzs_);
                        CqlInterval<CqlDateTime> xzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzp_);
                        CqlDateTime xzzzw_ = context.Operators.Start(xzzzv_);
                        CqlInterval<CqlDateTime> xzzzx_ = context.Operators.Interval(xzzzt_, xzzzw_, true, true);
                        bool? xzzzy_ = context.Operators.In<CqlDateTime>(xzzzo_, xzzzx_, default);
                        CqlInterval<CqlDateTime> yzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzp_);
                        CqlDateTime yzzzb_ = context.Operators.Start(yzzza_);
                        bool? yzzzc_ = context.Operators.Not((bool?)(yzzzb_ is null));
                        bool? yzzzd_ = context.Operators.And(xzzzy_, yzzzc_);
                        bool? yzzze_ = context.Operators.And(xzzzl_, yzzzd_);

                        return yzzze_;
                    };
                    IEnumerable<Encounter> vzzzr_ = context.Operators.Where<Encounter>(vzzzp_, vzzzq_);
                    object vzzzs_(Encounter @this)
                    {
                        Period yzzzf_ = @this?.Period;
                        CqlInterval<CqlDateTime> yzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzf_);
                        CqlDateTime yzzzh_ = context.Operators.End(yzzzg_);

                        return yzzzh_;
                    };
                    IEnumerable<Encounter> vzzzt_ = context.Operators.SortBy<Encounter>(vzzzr_, vzzzs_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter vzzzu_ = context.Operators.Last<Encounter>(vzzzt_);
                    Period vzzzv_ = vzzzu_?.Period;
                    CqlInterval<CqlDateTime> vzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzv_);
                    CqlDateTime vzzzx_ = context.Operators.Start(vzzzw_);
                    Period vzzzy_ = Visit?.Period;
                    CqlInterval<CqlDateTime> vzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzy_);
                    CqlDateTime wzzza_ = context.Operators.Start(vzzzz_);
                    CqlQuantity wzzzb_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime wzzzc_ = context.Operators.Subtract(vzzzx_ ?? wzzza_, wzzzb_);
                    IEnumerable<Encounter> wzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? wzzzf_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> yzzzi_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? yzzzj_ = yzzzi_?.Value;
                        Code<Encounter.EncounterStatus> yzzzk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(yzzzj_);
                        bool? yzzzl_ = context.Operators.Equal(yzzzk_, "finished");
                        Period yzzzm_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> yzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzm_);
                        CqlDateTime yzzzo_ = context.Operators.End(yzzzn_);
                        Period yzzzp_ = Visit?.Period;
                        CqlInterval<CqlDateTime> yzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzp_);
                        CqlDateTime yzzzr_ = context.Operators.Start(yzzzq_);
                        CqlQuantity yzzzs_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime yzzzt_ = context.Operators.Subtract(yzzzr_, yzzzs_);
                        CqlInterval<CqlDateTime> yzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzp_);
                        CqlDateTime yzzzw_ = context.Operators.Start(yzzzv_);
                        CqlInterval<CqlDateTime> yzzzx_ = context.Operators.Interval(yzzzt_, yzzzw_, true, true);
                        bool? yzzzy_ = context.Operators.In<CqlDateTime>(yzzzo_, yzzzx_, default);
                        CqlInterval<CqlDateTime> zzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzp_);
                        CqlDateTime zzzzb_ = context.Operators.Start(zzzza_);
                        bool? zzzzc_ = context.Operators.Not((bool?)(zzzzb_ is null));
                        bool? zzzzd_ = context.Operators.And(yzzzy_, zzzzc_);
                        bool? zzzze_ = context.Operators.And(yzzzl_, zzzzd_);

                        return zzzze_;
                    };
                    IEnumerable<Encounter> wzzzg_ = context.Operators.Where<Encounter>(wzzze_, wzzzf_);
                    object wzzzh_(Encounter @this)
                    {
                        Period zzzzf_ = @this?.Period;
                        CqlInterval<CqlDateTime> zzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzf_);
                        CqlDateTime zzzzh_ = context.Operators.End(zzzzg_);

                        return zzzzh_;
                    };
                    IEnumerable<Encounter> wzzzi_ = context.Operators.SortBy<Encounter>(wzzzg_, wzzzh_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter wzzzj_ = context.Operators.Last<Encounter>(wzzzi_);
                    Period wzzzk_ = wzzzj_?.Period;
                    CqlInterval<CqlDateTime> wzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzk_);
                    CqlDateTime wzzzm_ = context.Operators.Start(wzzzl_);
                    CqlInterval<CqlDateTime> wzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzy_);
                    CqlDateTime wzzzp_ = context.Operators.Start(wzzzo_);
                    CqlInterval<CqlDateTime> wzzzq_ = context.Operators.Interval(wzzzc_, wzzzm_ ?? wzzzp_, true, true);
                    bool? wzzzr_ = context.Operators.In<CqlDateTime>(vzzzn_, wzzzq_, default);
                    IEnumerable<Encounter> wzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? wzzzu_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> zzzzi_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? zzzzj_ = zzzzi_?.Value;
                        Code<Encounter.EncounterStatus> zzzzk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(zzzzj_);
                        bool? zzzzl_ = context.Operators.Equal(zzzzk_, "finished");
                        Period zzzzm_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> zzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzm_);
                        CqlDateTime zzzzo_ = context.Operators.End(zzzzn_);
                        Period zzzzp_ = Visit?.Period;
                        CqlInterval<CqlDateTime> zzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzp_);
                        CqlDateTime zzzzr_ = context.Operators.Start(zzzzq_);
                        CqlQuantity zzzzs_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime zzzzt_ = context.Operators.Subtract(zzzzr_, zzzzs_);
                        CqlInterval<CqlDateTime> zzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzp_);
                        CqlDateTime zzzzw_ = context.Operators.Start(zzzzv_);
                        CqlInterval<CqlDateTime> zzzzx_ = context.Operators.Interval(zzzzt_, zzzzw_, true, true);
                        bool? zzzzy_ = context.Operators.In<CqlDateTime>(zzzzo_, zzzzx_, default);
                        CqlInterval<CqlDateTime> azzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzp_);
                        CqlDateTime azzzzb_ = context.Operators.Start(azzzza_);
                        bool? azzzzc_ = context.Operators.Not((bool?)(azzzzb_ is null));
                        bool? azzzzd_ = context.Operators.And(zzzzy_, azzzzc_);
                        bool? azzzze_ = context.Operators.And(zzzzl_, azzzzd_);

                        return azzzze_;
                    };
                    IEnumerable<Encounter> wzzzv_ = context.Operators.Where<Encounter>(wzzzt_, wzzzu_);
                    object wzzzw_(Encounter @this)
                    {
                        Period azzzzf_ = @this?.Period;
                        CqlInterval<CqlDateTime> azzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzf_);
                        CqlDateTime azzzzh_ = context.Operators.End(azzzzg_);

                        return azzzzh_;
                    };
                    IEnumerable<Encounter> wzzzx_ = context.Operators.SortBy<Encounter>(wzzzv_, wzzzw_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter wzzzy_ = context.Operators.Last<Encounter>(wzzzx_);
                    Period wzzzz_ = wzzzy_?.Period;
                    CqlInterval<CqlDateTime> xzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzz_);
                    CqlDateTime xzzzb_ = context.Operators.Start(xzzza_);
                    CqlInterval<CqlDateTime> xzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzy_);
                    CqlDateTime xzzze_ = context.Operators.Start(xzzzd_);
                    bool? xzzzf_ = context.Operators.Not((bool?)((xzzzb_ ?? xzzze_) is null));
                    bool? xzzzg_ = context.Operators.And(wzzzr_, xzzzf_);
                    bool? xzzzh_ = context.Operators.And(vzzzk_, xzzzg_);

                    return xzzzh_;
                };
                IEnumerable<Encounter> izzzd_ = context.Operators.Where<Encounter>(izzzb_, izzzc_);
                object izzze_(Encounter @this)
                {
                    Period azzzzi_ = @this?.Period;
                    CqlInterval<CqlDateTime> azzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzi_);
                    CqlDateTime azzzzk_ = context.Operators.End(azzzzj_);

                    return azzzzk_;
                };
                IEnumerable<Encounter> izzzf_ = context.Operators.SortBy<Encounter>(izzzd_, izzze_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter izzzg_ = context.Operators.Last<Encounter>(izzzf_);
                Period izzzh_ = izzzg_?.Period;
                CqlInterval<CqlDateTime> izzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzh_);
                CqlDateTime izzzj_ = context.Operators.Start(izzzi_);
                IEnumerable<Encounter> izzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? izzzm_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> azzzzl_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? azzzzm_ = azzzzl_?.Value;
                    Code<Encounter.EncounterStatus> azzzzn_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(azzzzm_);
                    bool? azzzzo_ = context.Operators.Equal(azzzzn_, "finished");
                    Period azzzzp_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> azzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzp_);
                    CqlDateTime azzzzr_ = context.Operators.End(azzzzq_);
                    Period azzzzs_ = Visit?.Period;
                    CqlInterval<CqlDateTime> azzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzs_);
                    CqlDateTime azzzzu_ = context.Operators.Start(azzzzt_);
                    CqlQuantity azzzzv_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime azzzzw_ = context.Operators.Subtract(azzzzu_, azzzzv_);
                    CqlInterval<CqlDateTime> azzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzs_);
                    CqlDateTime azzzzz_ = context.Operators.Start(azzzzy_);
                    CqlInterval<CqlDateTime> bzzzza_ = context.Operators.Interval(azzzzw_, azzzzz_, true, true);
                    bool? bzzzzb_ = context.Operators.In<CqlDateTime>(azzzzr_, bzzzza_, default);
                    CqlInterval<CqlDateTime> bzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzs_);
                    CqlDateTime bzzzze_ = context.Operators.Start(bzzzzd_);
                    bool? bzzzzf_ = context.Operators.Not((bool?)(bzzzze_ is null));
                    bool? bzzzzg_ = context.Operators.And(bzzzzb_, bzzzzf_);
                    bool? bzzzzh_ = context.Operators.And(azzzzo_, bzzzzg_);

                    return bzzzzh_;
                };
                IEnumerable<Encounter> izzzn_ = context.Operators.Where<Encounter>(izzzl_, izzzm_);
                object izzzo_(Encounter @this)
                {
                    Period bzzzzi_ = @this?.Period;
                    CqlInterval<CqlDateTime> bzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzi_);
                    CqlDateTime bzzzzk_ = context.Operators.End(bzzzzj_);

                    return bzzzzk_;
                };
                IEnumerable<Encounter> izzzp_ = context.Operators.SortBy<Encounter>(izzzn_, izzzo_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter izzzq_ = context.Operators.Last<Encounter>(izzzp_);
                Period izzzr_ = izzzq_?.Period;
                CqlInterval<CqlDateTime> izzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzr_);
                CqlDateTime izzzt_ = context.Operators.Start(izzzs_);
                CqlInterval<CqlDateTime> izzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzw_);
                CqlDateTime izzzw_ = context.Operators.Start(izzzv_);
                bool? izzzx_ = context.Operators.Not((bool?)((izzzj_ ?? izzzt_ ?? izzzw_) is null));
                bool? izzzy_ = context.Operators.And(hzzzz_, izzzx_);

                return izzzy_;
            };
            IEnumerable<Encounter> ezzzr_ = context.Operators.Where<Encounter>(ezzzp_, ezzzq_);
            object ezzzs_(Encounter @this)
            {
                Period bzzzzl_ = @this?.Period;
                CqlInterval<CqlDateTime> bzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzl_);
                CqlDateTime bzzzzn_ = context.Operators.End(bzzzzm_);

                return bzzzzn_;
            };
            IEnumerable<Encounter> ezzzt_ = context.Operators.SortBy<Encounter>(ezzzr_, ezzzs_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter ezzzu_ = context.Operators.Last<Encounter>(ezzzt_);
            Period ezzzv_ = ezzzu_?.Period;
            CqlInterval<CqlDateTime> ezzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzv_);
            CqlDateTime ezzzx_ = context.Operators.Start(ezzzw_);
            CqlValueSet ezzzy_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> ezzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? fzzza_(Encounter LastED)
            {
                Code<Encounter.EncounterStatus> bzzzzo_ = LastED?.StatusElement;
                Encounter.EncounterStatus? bzzzzp_ = bzzzzo_?.Value;
                Code<Encounter.EncounterStatus> bzzzzq_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bzzzzp_);
                bool? bzzzzr_ = context.Operators.Equal(bzzzzq_, "finished");
                Period bzzzzs_ = LastED?.Period;
                CqlInterval<CqlDateTime> bzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzs_);
                CqlDateTime bzzzzu_ = context.Operators.End(bzzzzt_);
                CqlValueSet bzzzzv_ = this.Observation_Services(context);
                IEnumerable<Encounter> bzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? bzzzzx_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> dzzzzp_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? dzzzzq_ = dzzzzp_?.Value;
                    Code<Encounter.EncounterStatus> dzzzzr_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dzzzzq_);
                    bool? dzzzzs_ = context.Operators.Equal(dzzzzr_, "finished");
                    Period dzzzzt_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> dzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzt_);
                    CqlDateTime dzzzzv_ = context.Operators.End(dzzzzu_);
                    Period dzzzzw_ = Visit?.Period;
                    CqlInterval<CqlDateTime> dzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzw_);
                    CqlDateTime dzzzzy_ = context.Operators.Start(dzzzzx_);
                    CqlQuantity dzzzzz_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ezzzza_ = context.Operators.Subtract(dzzzzy_, dzzzzz_);
                    CqlInterval<CqlDateTime> ezzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzw_);
                    CqlDateTime ezzzzd_ = context.Operators.Start(ezzzzc_);
                    CqlInterval<CqlDateTime> ezzzze_ = context.Operators.Interval(ezzzza_, ezzzzd_, true, true);
                    bool? ezzzzf_ = context.Operators.In<CqlDateTime>(dzzzzv_, ezzzze_, default);
                    CqlInterval<CqlDateTime> ezzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzw_);
                    CqlDateTime ezzzzi_ = context.Operators.Start(ezzzzh_);
                    bool? ezzzzj_ = context.Operators.Not((bool?)(ezzzzi_ is null));
                    bool? ezzzzk_ = context.Operators.And(ezzzzf_, ezzzzj_);
                    bool? ezzzzl_ = context.Operators.And(dzzzzs_, ezzzzk_);

                    return ezzzzl_;
                };
                IEnumerable<Encounter> bzzzzy_ = context.Operators.Where<Encounter>(bzzzzw_, bzzzzx_);
                object bzzzzz_(Encounter @this)
                {
                    Period ezzzzm_ = @this?.Period;
                    CqlInterval<CqlDateTime> ezzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzm_);
                    CqlDateTime ezzzzo_ = context.Operators.End(ezzzzn_);

                    return ezzzzo_;
                };
                IEnumerable<Encounter> czzzza_ = context.Operators.SortBy<Encounter>(bzzzzy_, bzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter czzzzb_ = context.Operators.Last<Encounter>(czzzza_);
                Period czzzzc_ = czzzzb_?.Period;
                CqlInterval<CqlDateTime> czzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzc_);
                CqlDateTime czzzze_ = context.Operators.Start(czzzzd_);
                Period czzzzf_ = Visit?.Period;
                CqlInterval<CqlDateTime> czzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzf_);
                CqlDateTime czzzzh_ = context.Operators.Start(czzzzg_);
                CqlQuantity czzzzi_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime czzzzj_ = context.Operators.Subtract(czzzze_ ?? czzzzh_, czzzzi_);
                IEnumerable<Encounter> czzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? czzzzm_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> ezzzzp_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? ezzzzq_ = ezzzzp_?.Value;
                    Code<Encounter.EncounterStatus> ezzzzr_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ezzzzq_);
                    bool? ezzzzs_ = context.Operators.Equal(ezzzzr_, "finished");
                    Period ezzzzt_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> ezzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzt_);
                    CqlDateTime ezzzzv_ = context.Operators.End(ezzzzu_);
                    Period ezzzzw_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ezzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzw_);
                    CqlDateTime ezzzzy_ = context.Operators.Start(ezzzzx_);
                    CqlQuantity ezzzzz_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime fzzzza_ = context.Operators.Subtract(ezzzzy_, ezzzzz_);
                    CqlInterval<CqlDateTime> fzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzw_);
                    CqlDateTime fzzzzd_ = context.Operators.Start(fzzzzc_);
                    CqlInterval<CqlDateTime> fzzzze_ = context.Operators.Interval(fzzzza_, fzzzzd_, true, true);
                    bool? fzzzzf_ = context.Operators.In<CqlDateTime>(ezzzzv_, fzzzze_, default);
                    CqlInterval<CqlDateTime> fzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzw_);
                    CqlDateTime fzzzzi_ = context.Operators.Start(fzzzzh_);
                    bool? fzzzzj_ = context.Operators.Not((bool?)(fzzzzi_ is null));
                    bool? fzzzzk_ = context.Operators.And(fzzzzf_, fzzzzj_);
                    bool? fzzzzl_ = context.Operators.And(ezzzzs_, fzzzzk_);

                    return fzzzzl_;
                };
                IEnumerable<Encounter> czzzzn_ = context.Operators.Where<Encounter>(czzzzl_, czzzzm_);
                object czzzzo_(Encounter @this)
                {
                    Period fzzzzm_ = @this?.Period;
                    CqlInterval<CqlDateTime> fzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzm_);
                    CqlDateTime fzzzzo_ = context.Operators.End(fzzzzn_);

                    return fzzzzo_;
                };
                IEnumerable<Encounter> czzzzp_ = context.Operators.SortBy<Encounter>(czzzzn_, czzzzo_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter czzzzq_ = context.Operators.Last<Encounter>(czzzzp_);
                Period czzzzr_ = czzzzq_?.Period;
                CqlInterval<CqlDateTime> czzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzr_);
                CqlDateTime czzzzt_ = context.Operators.Start(czzzzs_);
                CqlInterval<CqlDateTime> czzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzf_);
                CqlDateTime czzzzw_ = context.Operators.Start(czzzzv_);
                CqlInterval<CqlDateTime> czzzzx_ = context.Operators.Interval(czzzzj_, czzzzt_ ?? czzzzw_, true, true);
                bool? czzzzy_ = context.Operators.In<CqlDateTime>(bzzzzu_, czzzzx_, default);
                IEnumerable<Encounter> dzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? dzzzzb_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> fzzzzp_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? fzzzzq_ = fzzzzp_?.Value;
                    Code<Encounter.EncounterStatus> fzzzzr_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fzzzzq_);
                    bool? fzzzzs_ = context.Operators.Equal(fzzzzr_, "finished");
                    Period fzzzzt_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> fzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzt_);
                    CqlDateTime fzzzzv_ = context.Operators.End(fzzzzu_);
                    Period fzzzzw_ = Visit?.Period;
                    CqlInterval<CqlDateTime> fzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzw_);
                    CqlDateTime fzzzzy_ = context.Operators.Start(fzzzzx_);
                    CqlQuantity fzzzzz_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime gzzzza_ = context.Operators.Subtract(fzzzzy_, fzzzzz_);
                    CqlInterval<CqlDateTime> gzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzw_);
                    CqlDateTime gzzzzd_ = context.Operators.Start(gzzzzc_);
                    CqlInterval<CqlDateTime> gzzzze_ = context.Operators.Interval(gzzzza_, gzzzzd_, true, true);
                    bool? gzzzzf_ = context.Operators.In<CqlDateTime>(fzzzzv_, gzzzze_, default);
                    CqlInterval<CqlDateTime> gzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzw_);
                    CqlDateTime gzzzzi_ = context.Operators.Start(gzzzzh_);
                    bool? gzzzzj_ = context.Operators.Not((bool?)(gzzzzi_ is null));
                    bool? gzzzzk_ = context.Operators.And(gzzzzf_, gzzzzj_);
                    bool? gzzzzl_ = context.Operators.And(fzzzzs_, gzzzzk_);

                    return gzzzzl_;
                };
                IEnumerable<Encounter> dzzzzc_ = context.Operators.Where<Encounter>(dzzzza_, dzzzzb_);
                object dzzzzd_(Encounter @this)
                {
                    Period gzzzzm_ = @this?.Period;
                    CqlInterval<CqlDateTime> gzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzm_);
                    CqlDateTime gzzzzo_ = context.Operators.End(gzzzzn_);

                    return gzzzzo_;
                };
                IEnumerable<Encounter> dzzzze_ = context.Operators.SortBy<Encounter>(dzzzzc_, dzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter dzzzzf_ = context.Operators.Last<Encounter>(dzzzze_);
                Period dzzzzg_ = dzzzzf_?.Period;
                CqlInterval<CqlDateTime> dzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzg_);
                CqlDateTime dzzzzi_ = context.Operators.Start(dzzzzh_);
                CqlInterval<CqlDateTime> dzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzf_);
                CqlDateTime dzzzzl_ = context.Operators.Start(dzzzzk_);
                bool? dzzzzm_ = context.Operators.Not((bool?)((dzzzzi_ ?? dzzzzl_) is null));
                bool? dzzzzn_ = context.Operators.And(czzzzy_, dzzzzm_);
                bool? dzzzzo_ = context.Operators.And(bzzzzr_, dzzzzn_);

                return dzzzzo_;
            };
            IEnumerable<Encounter> fzzzb_ = context.Operators.Where<Encounter>(ezzzz_, fzzza_);
            object fzzzc_(Encounter @this)
            {
                Period gzzzzp_ = @this?.Period;
                CqlInterval<CqlDateTime> gzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzp_);
                CqlDateTime gzzzzr_ = context.Operators.End(gzzzzq_);

                return gzzzzr_;
            };
            IEnumerable<Encounter> fzzzd_ = context.Operators.SortBy<Encounter>(fzzzb_, fzzzc_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter fzzze_ = context.Operators.Last<Encounter>(fzzzd_);
            Period fzzzf_ = fzzze_?.Period;
            CqlInterval<CqlDateTime> fzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzf_);
            CqlDateTime fzzzh_ = context.Operators.Start(fzzzg_);
            CqlValueSet fzzzi_ = this.Observation_Services(context);
            IEnumerable<Encounter> fzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? fzzzk_(Encounter LastObs)
            {
                Code<Encounter.EncounterStatus> gzzzzs_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? gzzzzt_ = gzzzzs_?.Value;
                Code<Encounter.EncounterStatus> gzzzzu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gzzzzt_);
                bool? gzzzzv_ = context.Operators.Equal(gzzzzu_, "finished");
                Period gzzzzw_ = LastObs?.Period;
                CqlInterval<CqlDateTime> gzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzw_);
                CqlDateTime gzzzzy_ = context.Operators.End(gzzzzx_);
                Period gzzzzz_ = Visit?.Period;
                CqlInterval<CqlDateTime> hzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzz_);
                CqlDateTime hzzzzb_ = context.Operators.Start(hzzzza_);
                CqlQuantity hzzzzc_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime hzzzzd_ = context.Operators.Subtract(hzzzzb_, hzzzzc_);
                CqlInterval<CqlDateTime> hzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzz_);
                CqlDateTime hzzzzg_ = context.Operators.Start(hzzzzf_);
                CqlInterval<CqlDateTime> hzzzzh_ = context.Operators.Interval(hzzzzd_, hzzzzg_, true, true);
                bool? hzzzzi_ = context.Operators.In<CqlDateTime>(gzzzzy_, hzzzzh_, default);
                CqlInterval<CqlDateTime> hzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzz_);
                CqlDateTime hzzzzl_ = context.Operators.Start(hzzzzk_);
                bool? hzzzzm_ = context.Operators.Not((bool?)(hzzzzl_ is null));
                bool? hzzzzn_ = context.Operators.And(hzzzzi_, hzzzzm_);
                bool? hzzzzo_ = context.Operators.And(gzzzzv_, hzzzzn_);

                return hzzzzo_;
            };
            IEnumerable<Encounter> fzzzl_ = context.Operators.Where<Encounter>(fzzzj_, fzzzk_);
            object fzzzm_(Encounter @this)
            {
                Period hzzzzp_ = @this?.Period;
                CqlInterval<CqlDateTime> hzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzp_);
                CqlDateTime hzzzzr_ = context.Operators.End(hzzzzq_);

                return hzzzzr_;
            };
            IEnumerable<Encounter> fzzzn_ = context.Operators.SortBy<Encounter>(fzzzl_, fzzzm_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter fzzzo_ = context.Operators.Last<Encounter>(fzzzn_);
            Period fzzzp_ = fzzzo_?.Period;
            CqlInterval<CqlDateTime> fzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzp_);
            CqlDateTime fzzzr_ = context.Operators.Start(fzzzq_);
            Period fzzzs_ = Visit?.Period;
            CqlInterval<CqlDateTime> fzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzs_);
            CqlDateTime fzzzu_ = context.Operators.Start(fzzzt_);
            CqlInterval<CqlDateTime> fzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzs_);
            CqlDateTime fzzzx_ = context.Operators.End(fzzzw_);
            CqlInterval<CqlDateTime> fzzzy_ = context.Operators.Interval(ezzzx_ ?? fzzzh_ ?? fzzzr_ ?? fzzzu_, fzzzx_, true, true);

            return fzzzy_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> ezzzl_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)ezzzj_, ezzzk_);
        IEnumerable<CqlInterval<CqlDateTime>> ezzzm_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(ezzzl_);
        CqlInterval<CqlDateTime> ezzzn_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(ezzzm_);

        return ezzzn_;
    }


    [CqlExpressionDefinition("hospitalizationWithObservationAndOutpatientSurgeryService")]
    [CqlTag("description", "Hospitalization with Observation and Outpatient Surgery Service returns the total interval from the start of any immediately prior emergency department visit, outpatient surgery visit or observation visit to the discharge of the given encounter.")]
    public CqlInterval<CqlDateTime> hospitalizationWithObservationAndOutpatientSurgeryService(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] hzzzzs_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> hzzzzt_(Encounter Visit)
        {
            CqlValueSet hzzzzx_ = this.Outpatient_Surgery_Service(context);
            IEnumerable<Encounter> hzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? hzzzzz_(Encounter LastSurgeryOP)
            {
                Period jzzzzi_ = LastSurgeryOP?.Period;
                CqlInterval<CqlDateTime> jzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzi_);
                CqlDateTime jzzzzk_ = context.Operators.End(jzzzzj_);
                CqlValueSet jzzzzl_ = this.Emergency_Department_Visit(context);
                IEnumerable<Encounter> jzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? jzzzzn_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> mzzzzi_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? mzzzzj_ = mzzzzi_?.Value;
                    Code<Encounter.EncounterStatus> mzzzzk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(mzzzzj_);
                    bool? mzzzzl_ = context.Operators.Equal(mzzzzk_, "finished");
                    Period mzzzzm_ = LastED?.Period;
                    CqlInterval<CqlDateTime> mzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzm_);
                    CqlDateTime mzzzzo_ = context.Operators.End(mzzzzn_);
                    CqlValueSet mzzzzp_ = this.Observation_Services(context);
                    IEnumerable<Encounter> mzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? mzzzzr_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> ozzzzj_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? ozzzzk_ = ozzzzj_?.Value;
                        Code<Encounter.EncounterStatus> ozzzzl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ozzzzk_);
                        bool? ozzzzm_ = context.Operators.Equal(ozzzzl_, "finished");
                        Period ozzzzn_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> ozzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzn_);
                        CqlDateTime ozzzzp_ = context.Operators.End(ozzzzo_);
                        Period ozzzzq_ = Visit?.Period;
                        CqlInterval<CqlDateTime> ozzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzq_);
                        CqlDateTime ozzzzs_ = context.Operators.Start(ozzzzr_);
                        CqlQuantity ozzzzt_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime ozzzzu_ = context.Operators.Subtract(ozzzzs_, ozzzzt_);
                        CqlInterval<CqlDateTime> ozzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzq_);
                        CqlDateTime ozzzzx_ = context.Operators.Start(ozzzzw_);
                        CqlInterval<CqlDateTime> ozzzzy_ = context.Operators.Interval(ozzzzu_, ozzzzx_, true, true);
                        bool? ozzzzz_ = context.Operators.In<CqlDateTime>(ozzzzp_, ozzzzy_, default);
                        CqlInterval<CqlDateTime> pzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzq_);
                        CqlDateTime pzzzzc_ = context.Operators.Start(pzzzzb_);
                        bool? pzzzzd_ = context.Operators.Not((bool?)(pzzzzc_ is null));
                        bool? pzzzze_ = context.Operators.And(ozzzzz_, pzzzzd_);
                        bool? pzzzzf_ = context.Operators.And(ozzzzm_, pzzzze_);

                        return pzzzzf_;
                    };
                    IEnumerable<Encounter> mzzzzs_ = context.Operators.Where<Encounter>(mzzzzq_, mzzzzr_);
                    object mzzzzt_(Encounter @this)
                    {
                        Period pzzzzg_ = @this?.Period;
                        CqlInterval<CqlDateTime> pzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzg_);
                        CqlDateTime pzzzzi_ = context.Operators.End(pzzzzh_);

                        return pzzzzi_;
                    };
                    IEnumerable<Encounter> mzzzzu_ = context.Operators.SortBy<Encounter>(mzzzzs_, mzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter mzzzzv_ = context.Operators.Last<Encounter>(mzzzzu_);
                    Period mzzzzw_ = mzzzzv_?.Period;
                    CqlInterval<CqlDateTime> mzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzw_);
                    CqlDateTime mzzzzy_ = context.Operators.Start(mzzzzx_);
                    Period mzzzzz_ = Visit?.Period;
                    CqlInterval<CqlDateTime> nzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzz_);
                    CqlDateTime nzzzzb_ = context.Operators.Start(nzzzza_);
                    CqlQuantity nzzzzc_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime nzzzzd_ = context.Operators.Subtract(mzzzzy_ ?? nzzzzb_, nzzzzc_);
                    IEnumerable<Encounter> nzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? nzzzzg_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> pzzzzj_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? pzzzzk_ = pzzzzj_?.Value;
                        Code<Encounter.EncounterStatus> pzzzzl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pzzzzk_);
                        bool? pzzzzm_ = context.Operators.Equal(pzzzzl_, "finished");
                        Period pzzzzn_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> pzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzn_);
                        CqlDateTime pzzzzp_ = context.Operators.End(pzzzzo_);
                        Period pzzzzq_ = Visit?.Period;
                        CqlInterval<CqlDateTime> pzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzq_);
                        CqlDateTime pzzzzs_ = context.Operators.Start(pzzzzr_);
                        CqlQuantity pzzzzt_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime pzzzzu_ = context.Operators.Subtract(pzzzzs_, pzzzzt_);
                        CqlInterval<CqlDateTime> pzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzq_);
                        CqlDateTime pzzzzx_ = context.Operators.Start(pzzzzw_);
                        CqlInterval<CqlDateTime> pzzzzy_ = context.Operators.Interval(pzzzzu_, pzzzzx_, true, true);
                        bool? pzzzzz_ = context.Operators.In<CqlDateTime>(pzzzzp_, pzzzzy_, default);
                        CqlInterval<CqlDateTime> qzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzq_);
                        CqlDateTime qzzzzc_ = context.Operators.Start(qzzzzb_);
                        bool? qzzzzd_ = context.Operators.Not((bool?)(qzzzzc_ is null));
                        bool? qzzzze_ = context.Operators.And(pzzzzz_, qzzzzd_);
                        bool? qzzzzf_ = context.Operators.And(pzzzzm_, qzzzze_);

                        return qzzzzf_;
                    };
                    IEnumerable<Encounter> nzzzzh_ = context.Operators.Where<Encounter>(nzzzzf_, nzzzzg_);
                    object nzzzzi_(Encounter @this)
                    {
                        Period qzzzzg_ = @this?.Period;
                        CqlInterval<CqlDateTime> qzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzg_);
                        CqlDateTime qzzzzi_ = context.Operators.End(qzzzzh_);

                        return qzzzzi_;
                    };
                    IEnumerable<Encounter> nzzzzj_ = context.Operators.SortBy<Encounter>(nzzzzh_, nzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter nzzzzk_ = context.Operators.Last<Encounter>(nzzzzj_);
                    Period nzzzzl_ = nzzzzk_?.Period;
                    CqlInterval<CqlDateTime> nzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzl_);
                    CqlDateTime nzzzzn_ = context.Operators.Start(nzzzzm_);
                    CqlInterval<CqlDateTime> nzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzz_);
                    CqlDateTime nzzzzq_ = context.Operators.Start(nzzzzp_);
                    CqlInterval<CqlDateTime> nzzzzr_ = context.Operators.Interval(nzzzzd_, nzzzzn_ ?? nzzzzq_, true, true);
                    bool? nzzzzs_ = context.Operators.In<CqlDateTime>(mzzzzo_, nzzzzr_, default);
                    IEnumerable<Encounter> nzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? nzzzzv_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> qzzzzj_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? qzzzzk_ = qzzzzj_?.Value;
                        Code<Encounter.EncounterStatus> qzzzzl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(qzzzzk_);
                        bool? qzzzzm_ = context.Operators.Equal(qzzzzl_, "finished");
                        Period qzzzzn_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> qzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzn_);
                        CqlDateTime qzzzzp_ = context.Operators.End(qzzzzo_);
                        Period qzzzzq_ = Visit?.Period;
                        CqlInterval<CqlDateTime> qzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzq_);
                        CqlDateTime qzzzzs_ = context.Operators.Start(qzzzzr_);
                        CqlQuantity qzzzzt_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime qzzzzu_ = context.Operators.Subtract(qzzzzs_, qzzzzt_);
                        CqlInterval<CqlDateTime> qzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzq_);
                        CqlDateTime qzzzzx_ = context.Operators.Start(qzzzzw_);
                        CqlInterval<CqlDateTime> qzzzzy_ = context.Operators.Interval(qzzzzu_, qzzzzx_, true, true);
                        bool? qzzzzz_ = context.Operators.In<CqlDateTime>(qzzzzp_, qzzzzy_, default);
                        CqlInterval<CqlDateTime> rzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzq_);
                        CqlDateTime rzzzzc_ = context.Operators.Start(rzzzzb_);
                        bool? rzzzzd_ = context.Operators.Not((bool?)(rzzzzc_ is null));
                        bool? rzzzze_ = context.Operators.And(qzzzzz_, rzzzzd_);
                        bool? rzzzzf_ = context.Operators.And(qzzzzm_, rzzzze_);

                        return rzzzzf_;
                    };
                    IEnumerable<Encounter> nzzzzw_ = context.Operators.Where<Encounter>(nzzzzu_, nzzzzv_);
                    object nzzzzx_(Encounter @this)
                    {
                        Period rzzzzg_ = @this?.Period;
                        CqlInterval<CqlDateTime> rzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzg_);
                        CqlDateTime rzzzzi_ = context.Operators.End(rzzzzh_);

                        return rzzzzi_;
                    };
                    IEnumerable<Encounter> nzzzzy_ = context.Operators.SortBy<Encounter>(nzzzzw_, nzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter nzzzzz_ = context.Operators.Last<Encounter>(nzzzzy_);
                    Period ozzzza_ = nzzzzz_?.Period;
                    CqlInterval<CqlDateTime> ozzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzza_);
                    CqlDateTime ozzzzc_ = context.Operators.Start(ozzzzb_);
                    CqlInterval<CqlDateTime> ozzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzz_);
                    CqlDateTime ozzzzf_ = context.Operators.Start(ozzzze_);
                    bool? ozzzzg_ = context.Operators.Not((bool?)((ozzzzc_ ?? ozzzzf_) is null));
                    bool? ozzzzh_ = context.Operators.And(nzzzzs_, ozzzzg_);
                    bool? ozzzzi_ = context.Operators.And(mzzzzl_, ozzzzh_);

                    return ozzzzi_;
                };
                IEnumerable<Encounter> jzzzzo_ = context.Operators.Where<Encounter>(jzzzzm_, jzzzzn_);
                object jzzzzp_(Encounter @this)
                {
                    Period rzzzzj_ = @this?.Period;
                    CqlInterval<CqlDateTime> rzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzj_);
                    CqlDateTime rzzzzl_ = context.Operators.End(rzzzzk_);

                    return rzzzzl_;
                };
                IEnumerable<Encounter> jzzzzq_ = context.Operators.SortBy<Encounter>(jzzzzo_, jzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter jzzzzr_ = context.Operators.Last<Encounter>(jzzzzq_);
                Period jzzzzs_ = jzzzzr_?.Period;
                CqlInterval<CqlDateTime> jzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzs_);
                CqlDateTime jzzzzu_ = context.Operators.Start(jzzzzt_);
                CqlValueSet jzzzzv_ = this.Observation_Services(context);
                IEnumerable<Encounter> jzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? jzzzzx_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> rzzzzm_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? rzzzzn_ = rzzzzm_?.Value;
                    Code<Encounter.EncounterStatus> rzzzzo_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rzzzzn_);
                    bool? rzzzzp_ = context.Operators.Equal(rzzzzo_, "finished");
                    Period rzzzzq_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> rzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzq_);
                    CqlDateTime rzzzzs_ = context.Operators.End(rzzzzr_);
                    Period rzzzzt_ = Visit?.Period;
                    CqlInterval<CqlDateTime> rzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzt_);
                    CqlDateTime rzzzzv_ = context.Operators.Start(rzzzzu_);
                    CqlQuantity rzzzzw_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime rzzzzx_ = context.Operators.Subtract(rzzzzv_, rzzzzw_);
                    CqlInterval<CqlDateTime> rzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzt_);
                    CqlDateTime szzzza_ = context.Operators.Start(rzzzzz_);
                    CqlInterval<CqlDateTime> szzzzb_ = context.Operators.Interval(rzzzzx_, szzzza_, true, true);
                    bool? szzzzc_ = context.Operators.In<CqlDateTime>(rzzzzs_, szzzzb_, default);
                    CqlInterval<CqlDateTime> szzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzt_);
                    CqlDateTime szzzzf_ = context.Operators.Start(szzzze_);
                    bool? szzzzg_ = context.Operators.Not((bool?)(szzzzf_ is null));
                    bool? szzzzh_ = context.Operators.And(szzzzc_, szzzzg_);
                    bool? szzzzi_ = context.Operators.And(rzzzzp_, szzzzh_);

                    return szzzzi_;
                };
                IEnumerable<Encounter> jzzzzy_ = context.Operators.Where<Encounter>(jzzzzw_, jzzzzx_);
                object jzzzzz_(Encounter @this)
                {
                    Period szzzzj_ = @this?.Period;
                    CqlInterval<CqlDateTime> szzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzj_);
                    CqlDateTime szzzzl_ = context.Operators.End(szzzzk_);

                    return szzzzl_;
                };
                IEnumerable<Encounter> kzzzza_ = context.Operators.SortBy<Encounter>(jzzzzy_, jzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter kzzzzb_ = context.Operators.Last<Encounter>(kzzzza_);
                Period kzzzzc_ = kzzzzb_?.Period;
                CqlInterval<CqlDateTime> kzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzc_);
                CqlDateTime kzzzze_ = context.Operators.Start(kzzzzd_);
                Period kzzzzf_ = Visit?.Period;
                CqlInterval<CqlDateTime> kzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzf_);
                CqlDateTime kzzzzh_ = context.Operators.Start(kzzzzg_);
                CqlQuantity kzzzzi_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime kzzzzj_ = context.Operators.Subtract(jzzzzu_ ?? kzzzze_ ?? kzzzzh_, kzzzzi_);
                IEnumerable<Encounter> kzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? kzzzzm_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> szzzzm_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? szzzzn_ = szzzzm_?.Value;
                    Code<Encounter.EncounterStatus> szzzzo_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(szzzzn_);
                    bool? szzzzp_ = context.Operators.Equal(szzzzo_, "finished");
                    Period szzzzq_ = LastED?.Period;
                    CqlInterval<CqlDateTime> szzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzq_);
                    CqlDateTime szzzzs_ = context.Operators.End(szzzzr_);
                    CqlValueSet szzzzt_ = this.Observation_Services(context);
                    IEnumerable<Encounter> szzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? szzzzv_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> uzzzzn_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? uzzzzo_ = uzzzzn_?.Value;
                        Code<Encounter.EncounterStatus> uzzzzp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(uzzzzo_);
                        bool? uzzzzq_ = context.Operators.Equal(uzzzzp_, "finished");
                        Period uzzzzr_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> uzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzr_);
                        CqlDateTime uzzzzt_ = context.Operators.End(uzzzzs_);
                        Period uzzzzu_ = Visit?.Period;
                        CqlInterval<CqlDateTime> uzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzu_);
                        CqlDateTime uzzzzw_ = context.Operators.Start(uzzzzv_);
                        CqlQuantity uzzzzx_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime uzzzzy_ = context.Operators.Subtract(uzzzzw_, uzzzzx_);
                        CqlInterval<CqlDateTime> vzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzu_);
                        CqlDateTime vzzzzb_ = context.Operators.Start(vzzzza_);
                        CqlInterval<CqlDateTime> vzzzzc_ = context.Operators.Interval(uzzzzy_, vzzzzb_, true, true);
                        bool? vzzzzd_ = context.Operators.In<CqlDateTime>(uzzzzt_, vzzzzc_, default);
                        CqlInterval<CqlDateTime> vzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzu_);
                        CqlDateTime vzzzzg_ = context.Operators.Start(vzzzzf_);
                        bool? vzzzzh_ = context.Operators.Not((bool?)(vzzzzg_ is null));
                        bool? vzzzzi_ = context.Operators.And(vzzzzd_, vzzzzh_);
                        bool? vzzzzj_ = context.Operators.And(uzzzzq_, vzzzzi_);

                        return vzzzzj_;
                    };
                    IEnumerable<Encounter> szzzzw_ = context.Operators.Where<Encounter>(szzzzu_, szzzzv_);
                    object szzzzx_(Encounter @this)
                    {
                        Period vzzzzk_ = @this?.Period;
                        CqlInterval<CqlDateTime> vzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzk_);
                        CqlDateTime vzzzzm_ = context.Operators.End(vzzzzl_);

                        return vzzzzm_;
                    };
                    IEnumerable<Encounter> szzzzy_ = context.Operators.SortBy<Encounter>(szzzzw_, szzzzx_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter szzzzz_ = context.Operators.Last<Encounter>(szzzzy_);
                    Period tzzzza_ = szzzzz_?.Period;
                    CqlInterval<CqlDateTime> tzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzza_);
                    CqlDateTime tzzzzc_ = context.Operators.Start(tzzzzb_);
                    Period tzzzzd_ = Visit?.Period;
                    CqlInterval<CqlDateTime> tzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzd_);
                    CqlDateTime tzzzzf_ = context.Operators.Start(tzzzze_);
                    CqlQuantity tzzzzg_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime tzzzzh_ = context.Operators.Subtract(tzzzzc_ ?? tzzzzf_, tzzzzg_);
                    IEnumerable<Encounter> tzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? tzzzzk_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> vzzzzn_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? vzzzzo_ = vzzzzn_?.Value;
                        Code<Encounter.EncounterStatus> vzzzzp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(vzzzzo_);
                        bool? vzzzzq_ = context.Operators.Equal(vzzzzp_, "finished");
                        Period vzzzzr_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> vzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzr_);
                        CqlDateTime vzzzzt_ = context.Operators.End(vzzzzs_);
                        Period vzzzzu_ = Visit?.Period;
                        CqlInterval<CqlDateTime> vzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzu_);
                        CqlDateTime vzzzzw_ = context.Operators.Start(vzzzzv_);
                        CqlQuantity vzzzzx_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime vzzzzy_ = context.Operators.Subtract(vzzzzw_, vzzzzx_);
                        CqlInterval<CqlDateTime> wzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzu_);
                        CqlDateTime wzzzzb_ = context.Operators.Start(wzzzza_);
                        CqlInterval<CqlDateTime> wzzzzc_ = context.Operators.Interval(vzzzzy_, wzzzzb_, true, true);
                        bool? wzzzzd_ = context.Operators.In<CqlDateTime>(vzzzzt_, wzzzzc_, default);
                        CqlInterval<CqlDateTime> wzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzu_);
                        CqlDateTime wzzzzg_ = context.Operators.Start(wzzzzf_);
                        bool? wzzzzh_ = context.Operators.Not((bool?)(wzzzzg_ is null));
                        bool? wzzzzi_ = context.Operators.And(wzzzzd_, wzzzzh_);
                        bool? wzzzzj_ = context.Operators.And(vzzzzq_, wzzzzi_);

                        return wzzzzj_;
                    };
                    IEnumerable<Encounter> tzzzzl_ = context.Operators.Where<Encounter>(tzzzzj_, tzzzzk_);
                    object tzzzzm_(Encounter @this)
                    {
                        Period wzzzzk_ = @this?.Period;
                        CqlInterval<CqlDateTime> wzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzk_);
                        CqlDateTime wzzzzm_ = context.Operators.End(wzzzzl_);

                        return wzzzzm_;
                    };
                    IEnumerable<Encounter> tzzzzn_ = context.Operators.SortBy<Encounter>(tzzzzl_, tzzzzm_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter tzzzzo_ = context.Operators.Last<Encounter>(tzzzzn_);
                    Period tzzzzp_ = tzzzzo_?.Period;
                    CqlInterval<CqlDateTime> tzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzp_);
                    CqlDateTime tzzzzr_ = context.Operators.Start(tzzzzq_);
                    CqlInterval<CqlDateTime> tzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzd_);
                    CqlDateTime tzzzzu_ = context.Operators.Start(tzzzzt_);
                    CqlInterval<CqlDateTime> tzzzzv_ = context.Operators.Interval(tzzzzh_, tzzzzr_ ?? tzzzzu_, true, true);
                    bool? tzzzzw_ = context.Operators.In<CqlDateTime>(szzzzs_, tzzzzv_, default);
                    IEnumerable<Encounter> tzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? tzzzzz_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> wzzzzn_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? wzzzzo_ = wzzzzn_?.Value;
                        Code<Encounter.EncounterStatus> wzzzzp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(wzzzzo_);
                        bool? wzzzzq_ = context.Operators.Equal(wzzzzp_, "finished");
                        Period wzzzzr_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> wzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzr_);
                        CqlDateTime wzzzzt_ = context.Operators.End(wzzzzs_);
                        Period wzzzzu_ = Visit?.Period;
                        CqlInterval<CqlDateTime> wzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzu_);
                        CqlDateTime wzzzzw_ = context.Operators.Start(wzzzzv_);
                        CqlQuantity wzzzzx_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime wzzzzy_ = context.Operators.Subtract(wzzzzw_, wzzzzx_);
                        CqlInterval<CqlDateTime> xzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzu_);
                        CqlDateTime xzzzzb_ = context.Operators.Start(xzzzza_);
                        CqlInterval<CqlDateTime> xzzzzc_ = context.Operators.Interval(wzzzzy_, xzzzzb_, true, true);
                        bool? xzzzzd_ = context.Operators.In<CqlDateTime>(wzzzzt_, xzzzzc_, default);
                        CqlInterval<CqlDateTime> xzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzu_);
                        CqlDateTime xzzzzg_ = context.Operators.Start(xzzzzf_);
                        bool? xzzzzh_ = context.Operators.Not((bool?)(xzzzzg_ is null));
                        bool? xzzzzi_ = context.Operators.And(xzzzzd_, xzzzzh_);
                        bool? xzzzzj_ = context.Operators.And(wzzzzq_, xzzzzi_);

                        return xzzzzj_;
                    };
                    IEnumerable<Encounter> uzzzza_ = context.Operators.Where<Encounter>(tzzzzy_, tzzzzz_);
                    object uzzzzb_(Encounter @this)
                    {
                        Period xzzzzk_ = @this?.Period;
                        CqlInterval<CqlDateTime> xzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzk_);
                        CqlDateTime xzzzzm_ = context.Operators.End(xzzzzl_);

                        return xzzzzm_;
                    };
                    IEnumerable<Encounter> uzzzzc_ = context.Operators.SortBy<Encounter>(uzzzza_, uzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter uzzzzd_ = context.Operators.Last<Encounter>(uzzzzc_);
                    Period uzzzze_ = uzzzzd_?.Period;
                    CqlInterval<CqlDateTime> uzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzze_);
                    CqlDateTime uzzzzg_ = context.Operators.Start(uzzzzf_);
                    CqlInterval<CqlDateTime> uzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzd_);
                    CqlDateTime uzzzzj_ = context.Operators.Start(uzzzzi_);
                    bool? uzzzzk_ = context.Operators.Not((bool?)((uzzzzg_ ?? uzzzzj_) is null));
                    bool? uzzzzl_ = context.Operators.And(tzzzzw_, uzzzzk_);
                    bool? uzzzzm_ = context.Operators.And(szzzzp_, uzzzzl_);

                    return uzzzzm_;
                };
                IEnumerable<Encounter> kzzzzn_ = context.Operators.Where<Encounter>(kzzzzl_, kzzzzm_);
                object kzzzzo_(Encounter @this)
                {
                    Period xzzzzn_ = @this?.Period;
                    CqlInterval<CqlDateTime> xzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzn_);
                    CqlDateTime xzzzzp_ = context.Operators.End(xzzzzo_);

                    return xzzzzp_;
                };
                IEnumerable<Encounter> kzzzzp_ = context.Operators.SortBy<Encounter>(kzzzzn_, kzzzzo_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter kzzzzq_ = context.Operators.Last<Encounter>(kzzzzp_);
                Period kzzzzr_ = kzzzzq_?.Period;
                CqlInterval<CqlDateTime> kzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzr_);
                CqlDateTime kzzzzt_ = context.Operators.Start(kzzzzs_);
                IEnumerable<Encounter> kzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? kzzzzw_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> xzzzzq_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? xzzzzr_ = xzzzzq_?.Value;
                    Code<Encounter.EncounterStatus> xzzzzs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(xzzzzr_);
                    bool? xzzzzt_ = context.Operators.Equal(xzzzzs_, "finished");
                    Period xzzzzu_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> xzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzu_);
                    CqlDateTime xzzzzw_ = context.Operators.End(xzzzzv_);
                    Period xzzzzx_ = Visit?.Period;
                    CqlInterval<CqlDateTime> xzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzx_);
                    CqlDateTime xzzzzz_ = context.Operators.Start(xzzzzy_);
                    CqlQuantity yzzzza_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime yzzzzb_ = context.Operators.Subtract(xzzzzz_, yzzzza_);
                    CqlInterval<CqlDateTime> yzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzx_);
                    CqlDateTime yzzzze_ = context.Operators.Start(yzzzzd_);
                    CqlInterval<CqlDateTime> yzzzzf_ = context.Operators.Interval(yzzzzb_, yzzzze_, true, true);
                    bool? yzzzzg_ = context.Operators.In<CqlDateTime>(xzzzzw_, yzzzzf_, default);
                    CqlInterval<CqlDateTime> yzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzx_);
                    CqlDateTime yzzzzj_ = context.Operators.Start(yzzzzi_);
                    bool? yzzzzk_ = context.Operators.Not((bool?)(yzzzzj_ is null));
                    bool? yzzzzl_ = context.Operators.And(yzzzzg_, yzzzzk_);
                    bool? yzzzzm_ = context.Operators.And(xzzzzt_, yzzzzl_);

                    return yzzzzm_;
                };
                IEnumerable<Encounter> kzzzzx_ = context.Operators.Where<Encounter>(kzzzzv_, kzzzzw_);
                object kzzzzy_(Encounter @this)
                {
                    Period yzzzzn_ = @this?.Period;
                    CqlInterval<CqlDateTime> yzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzn_);
                    CqlDateTime yzzzzp_ = context.Operators.End(yzzzzo_);

                    return yzzzzp_;
                };
                IEnumerable<Encounter> kzzzzz_ = context.Operators.SortBy<Encounter>(kzzzzx_, kzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter lzzzza_ = context.Operators.Last<Encounter>(kzzzzz_);
                Period lzzzzb_ = lzzzza_?.Period;
                CqlInterval<CqlDateTime> lzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzb_);
                CqlDateTime lzzzzd_ = context.Operators.Start(lzzzzc_);
                CqlInterval<CqlDateTime> lzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzf_);
                CqlDateTime lzzzzg_ = context.Operators.Start(lzzzzf_);
                CqlInterval<CqlDateTime> lzzzzh_ = context.Operators.Interval(kzzzzj_, kzzzzt_ ?? lzzzzd_ ?? lzzzzg_, true, true);
                bool? lzzzzi_ = context.Operators.In<CqlDateTime>(jzzzzk_, lzzzzh_, default);
                IEnumerable<Encounter> lzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? lzzzzl_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> yzzzzq_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? yzzzzr_ = yzzzzq_?.Value;
                    Code<Encounter.EncounterStatus> yzzzzs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(yzzzzr_);
                    bool? yzzzzt_ = context.Operators.Equal(yzzzzs_, "finished");
                    Period yzzzzu_ = LastED?.Period;
                    CqlInterval<CqlDateTime> yzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzu_);
                    CqlDateTime yzzzzw_ = context.Operators.End(yzzzzv_);
                    CqlValueSet yzzzzx_ = this.Observation_Services(context);
                    IEnumerable<Encounter> yzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? yzzzzz_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> azzzzzr_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? azzzzzs_ = azzzzzr_?.Value;
                        Code<Encounter.EncounterStatus> azzzzzt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(azzzzzs_);
                        bool? azzzzzu_ = context.Operators.Equal(azzzzzt_, "finished");
                        Period azzzzzv_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> azzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzv_);
                        CqlDateTime azzzzzx_ = context.Operators.End(azzzzzw_);
                        Period azzzzzy_ = Visit?.Period;
                        CqlInterval<CqlDateTime> azzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzy_);
                        CqlDateTime bzzzzza_ = context.Operators.Start(azzzzzz_);
                        CqlQuantity bzzzzzb_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime bzzzzzc_ = context.Operators.Subtract(bzzzzza_, bzzzzzb_);
                        CqlInterval<CqlDateTime> bzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzy_);
                        CqlDateTime bzzzzzf_ = context.Operators.Start(bzzzzze_);
                        CqlInterval<CqlDateTime> bzzzzzg_ = context.Operators.Interval(bzzzzzc_, bzzzzzf_, true, true);
                        bool? bzzzzzh_ = context.Operators.In<CqlDateTime>(azzzzzx_, bzzzzzg_, default);
                        CqlInterval<CqlDateTime> bzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzy_);
                        CqlDateTime bzzzzzk_ = context.Operators.Start(bzzzzzj_);
                        bool? bzzzzzl_ = context.Operators.Not((bool?)(bzzzzzk_ is null));
                        bool? bzzzzzm_ = context.Operators.And(bzzzzzh_, bzzzzzl_);
                        bool? bzzzzzn_ = context.Operators.And(azzzzzu_, bzzzzzm_);

                        return bzzzzzn_;
                    };
                    IEnumerable<Encounter> zzzzza_ = context.Operators.Where<Encounter>(yzzzzy_, yzzzzz_);
                    object zzzzzb_(Encounter @this)
                    {
                        Period bzzzzzo_ = @this?.Period;
                        CqlInterval<CqlDateTime> bzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzo_);
                        CqlDateTime bzzzzzq_ = context.Operators.End(bzzzzzp_);

                        return bzzzzzq_;
                    };
                    IEnumerable<Encounter> zzzzzc_ = context.Operators.SortBy<Encounter>(zzzzza_, zzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter zzzzzd_ = context.Operators.Last<Encounter>(zzzzzc_);
                    Period zzzzze_ = zzzzzd_?.Period;
                    CqlInterval<CqlDateTime> zzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzze_);
                    CqlDateTime zzzzzg_ = context.Operators.Start(zzzzzf_);
                    Period zzzzzh_ = Visit?.Period;
                    CqlInterval<CqlDateTime> zzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzh_);
                    CqlDateTime zzzzzj_ = context.Operators.Start(zzzzzi_);
                    CqlQuantity zzzzzk_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime zzzzzl_ = context.Operators.Subtract(zzzzzg_ ?? zzzzzj_, zzzzzk_);
                    IEnumerable<Encounter> zzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? zzzzzo_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> bzzzzzr_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? bzzzzzs_ = bzzzzzr_?.Value;
                        Code<Encounter.EncounterStatus> bzzzzzt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bzzzzzs_);
                        bool? bzzzzzu_ = context.Operators.Equal(bzzzzzt_, "finished");
                        Period bzzzzzv_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> bzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzv_);
                        CqlDateTime bzzzzzx_ = context.Operators.End(bzzzzzw_);
                        Period bzzzzzy_ = Visit?.Period;
                        CqlInterval<CqlDateTime> bzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzy_);
                        CqlDateTime czzzzza_ = context.Operators.Start(bzzzzzz_);
                        CqlQuantity czzzzzb_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime czzzzzc_ = context.Operators.Subtract(czzzzza_, czzzzzb_);
                        CqlInterval<CqlDateTime> czzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzy_);
                        CqlDateTime czzzzzf_ = context.Operators.Start(czzzzze_);
                        CqlInterval<CqlDateTime> czzzzzg_ = context.Operators.Interval(czzzzzc_, czzzzzf_, true, true);
                        bool? czzzzzh_ = context.Operators.In<CqlDateTime>(bzzzzzx_, czzzzzg_, default);
                        CqlInterval<CqlDateTime> czzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzy_);
                        CqlDateTime czzzzzk_ = context.Operators.Start(czzzzzj_);
                        bool? czzzzzl_ = context.Operators.Not((bool?)(czzzzzk_ is null));
                        bool? czzzzzm_ = context.Operators.And(czzzzzh_, czzzzzl_);
                        bool? czzzzzn_ = context.Operators.And(bzzzzzu_, czzzzzm_);

                        return czzzzzn_;
                    };
                    IEnumerable<Encounter> zzzzzp_ = context.Operators.Where<Encounter>(zzzzzn_, zzzzzo_);
                    object zzzzzq_(Encounter @this)
                    {
                        Period czzzzzo_ = @this?.Period;
                        CqlInterval<CqlDateTime> czzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzo_);
                        CqlDateTime czzzzzq_ = context.Operators.End(czzzzzp_);

                        return czzzzzq_;
                    };
                    IEnumerable<Encounter> zzzzzr_ = context.Operators.SortBy<Encounter>(zzzzzp_, zzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter zzzzzs_ = context.Operators.Last<Encounter>(zzzzzr_);
                    Period zzzzzt_ = zzzzzs_?.Period;
                    CqlInterval<CqlDateTime> zzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzt_);
                    CqlDateTime zzzzzv_ = context.Operators.Start(zzzzzu_);
                    CqlInterval<CqlDateTime> zzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzh_);
                    CqlDateTime zzzzzy_ = context.Operators.Start(zzzzzx_);
                    CqlInterval<CqlDateTime> zzzzzz_ = context.Operators.Interval(zzzzzl_, zzzzzv_ ?? zzzzzy_, true, true);
                    bool? azzzzza_ = context.Operators.In<CqlDateTime>(yzzzzw_, zzzzzz_, default);
                    IEnumerable<Encounter> azzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? azzzzzd_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> czzzzzr_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? czzzzzs_ = czzzzzr_?.Value;
                        Code<Encounter.EncounterStatus> czzzzzt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(czzzzzs_);
                        bool? czzzzzu_ = context.Operators.Equal(czzzzzt_, "finished");
                        Period czzzzzv_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> czzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzv_);
                        CqlDateTime czzzzzx_ = context.Operators.End(czzzzzw_);
                        Period czzzzzy_ = Visit?.Period;
                        CqlInterval<CqlDateTime> czzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzy_);
                        CqlDateTime dzzzzza_ = context.Operators.Start(czzzzzz_);
                        CqlQuantity dzzzzzb_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime dzzzzzc_ = context.Operators.Subtract(dzzzzza_, dzzzzzb_);
                        CqlInterval<CqlDateTime> dzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzy_);
                        CqlDateTime dzzzzzf_ = context.Operators.Start(dzzzzze_);
                        CqlInterval<CqlDateTime> dzzzzzg_ = context.Operators.Interval(dzzzzzc_, dzzzzzf_, true, true);
                        bool? dzzzzzh_ = context.Operators.In<CqlDateTime>(czzzzzx_, dzzzzzg_, default);
                        CqlInterval<CqlDateTime> dzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzy_);
                        CqlDateTime dzzzzzk_ = context.Operators.Start(dzzzzzj_);
                        bool? dzzzzzl_ = context.Operators.Not((bool?)(dzzzzzk_ is null));
                        bool? dzzzzzm_ = context.Operators.And(dzzzzzh_, dzzzzzl_);
                        bool? dzzzzzn_ = context.Operators.And(czzzzzu_, dzzzzzm_);

                        return dzzzzzn_;
                    };
                    IEnumerable<Encounter> azzzzze_ = context.Operators.Where<Encounter>(azzzzzc_, azzzzzd_);
                    object azzzzzf_(Encounter @this)
                    {
                        Period dzzzzzo_ = @this?.Period;
                        CqlInterval<CqlDateTime> dzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzo_);
                        CqlDateTime dzzzzzq_ = context.Operators.End(dzzzzzp_);

                        return dzzzzzq_;
                    };
                    IEnumerable<Encounter> azzzzzg_ = context.Operators.SortBy<Encounter>(azzzzze_, azzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter azzzzzh_ = context.Operators.Last<Encounter>(azzzzzg_);
                    Period azzzzzi_ = azzzzzh_?.Period;
                    CqlInterval<CqlDateTime> azzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzi_);
                    CqlDateTime azzzzzk_ = context.Operators.Start(azzzzzj_);
                    CqlInterval<CqlDateTime> azzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzh_);
                    CqlDateTime azzzzzn_ = context.Operators.Start(azzzzzm_);
                    bool? azzzzzo_ = context.Operators.Not((bool?)((azzzzzk_ ?? azzzzzn_) is null));
                    bool? azzzzzp_ = context.Operators.And(azzzzza_, azzzzzo_);
                    bool? azzzzzq_ = context.Operators.And(yzzzzt_, azzzzzp_);

                    return azzzzzq_;
                };
                IEnumerable<Encounter> lzzzzm_ = context.Operators.Where<Encounter>(lzzzzk_, lzzzzl_);
                object lzzzzn_(Encounter @this)
                {
                    Period dzzzzzr_ = @this?.Period;
                    CqlInterval<CqlDateTime> dzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzr_);
                    CqlDateTime dzzzzzt_ = context.Operators.End(dzzzzzs_);

                    return dzzzzzt_;
                };
                IEnumerable<Encounter> lzzzzo_ = context.Operators.SortBy<Encounter>(lzzzzm_, lzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter lzzzzp_ = context.Operators.Last<Encounter>(lzzzzo_);
                Period lzzzzq_ = lzzzzp_?.Period;
                CqlInterval<CqlDateTime> lzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzq_);
                CqlDateTime lzzzzs_ = context.Operators.Start(lzzzzr_);
                IEnumerable<Encounter> lzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? lzzzzv_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> dzzzzzu_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? dzzzzzv_ = dzzzzzu_?.Value;
                    Code<Encounter.EncounterStatus> dzzzzzw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dzzzzzv_);
                    bool? dzzzzzx_ = context.Operators.Equal(dzzzzzw_, "finished");
                    Period dzzzzzy_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> dzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzy_);
                    CqlDateTime ezzzzza_ = context.Operators.End(dzzzzzz_);
                    Period ezzzzzb_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ezzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzb_);
                    CqlDateTime ezzzzzd_ = context.Operators.Start(ezzzzzc_);
                    CqlQuantity ezzzzze_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ezzzzzf_ = context.Operators.Subtract(ezzzzzd_, ezzzzze_);
                    CqlInterval<CqlDateTime> ezzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzb_);
                    CqlDateTime ezzzzzi_ = context.Operators.Start(ezzzzzh_);
                    CqlInterval<CqlDateTime> ezzzzzj_ = context.Operators.Interval(ezzzzzf_, ezzzzzi_, true, true);
                    bool? ezzzzzk_ = context.Operators.In<CqlDateTime>(ezzzzza_, ezzzzzj_, default);
                    CqlInterval<CqlDateTime> ezzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzb_);
                    CqlDateTime ezzzzzn_ = context.Operators.Start(ezzzzzm_);
                    bool? ezzzzzo_ = context.Operators.Not((bool?)(ezzzzzn_ is null));
                    bool? ezzzzzp_ = context.Operators.And(ezzzzzk_, ezzzzzo_);
                    bool? ezzzzzq_ = context.Operators.And(dzzzzzx_, ezzzzzp_);

                    return ezzzzzq_;
                };
                IEnumerable<Encounter> lzzzzw_ = context.Operators.Where<Encounter>(lzzzzu_, lzzzzv_);
                object lzzzzx_(Encounter @this)
                {
                    Period ezzzzzr_ = @this?.Period;
                    CqlInterval<CqlDateTime> ezzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzr_);
                    CqlDateTime ezzzzzt_ = context.Operators.End(ezzzzzs_);

                    return ezzzzzt_;
                };
                IEnumerable<Encounter> lzzzzy_ = context.Operators.SortBy<Encounter>(lzzzzw_, lzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter lzzzzz_ = context.Operators.Last<Encounter>(lzzzzy_);
                Period mzzzza_ = lzzzzz_?.Period;
                CqlInterval<CqlDateTime> mzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzza_);
                CqlDateTime mzzzzc_ = context.Operators.Start(mzzzzb_);
                CqlInterval<CqlDateTime> mzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzf_);
                CqlDateTime mzzzzf_ = context.Operators.Start(mzzzze_);
                bool? mzzzzg_ = context.Operators.Not((bool?)((lzzzzs_ ?? mzzzzc_ ?? mzzzzf_) is null));
                bool? mzzzzh_ = context.Operators.And(lzzzzi_, mzzzzg_);

                return mzzzzh_;
            };
            IEnumerable<Encounter> izzzza_ = context.Operators.Where<Encounter>(hzzzzy_, hzzzzz_);
            object izzzzb_(Encounter @this)
            {
                Period ezzzzzu_ = @this?.Period;
                CqlInterval<CqlDateTime> ezzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzu_);
                CqlDateTime ezzzzzw_ = context.Operators.End(ezzzzzv_);

                return ezzzzzw_;
            };
            IEnumerable<Encounter> izzzzc_ = context.Operators.SortBy<Encounter>(izzzza_, izzzzb_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter izzzzd_ = context.Operators.Last<Encounter>(izzzzc_);
            Period izzzze_ = izzzzd_?.Period;
            CqlInterval<CqlDateTime> izzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzze_);
            CqlDateTime izzzzg_ = context.Operators.Start(izzzzf_);
            CqlValueSet izzzzh_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> izzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? izzzzj_(Encounter LastED)
            {
                Code<Encounter.EncounterStatus> ezzzzzx_ = LastED?.StatusElement;
                Encounter.EncounterStatus? ezzzzzy_ = ezzzzzx_?.Value;
                Code<Encounter.EncounterStatus> ezzzzzz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ezzzzzy_);
                bool? fzzzzza_ = context.Operators.Equal(ezzzzzz_, "finished");
                Period fzzzzzb_ = LastED?.Period;
                CqlInterval<CqlDateTime> fzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzb_);
                CqlDateTime fzzzzzd_ = context.Operators.End(fzzzzzc_);
                CqlValueSet fzzzzze_ = this.Observation_Services(context);
                IEnumerable<Encounter> fzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? fzzzzzg_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> gzzzzzy_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? gzzzzzz_ = gzzzzzy_?.Value;
                    Code<Encounter.EncounterStatus> hzzzzza_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gzzzzzz_);
                    bool? hzzzzzb_ = context.Operators.Equal(hzzzzza_, "finished");
                    Period hzzzzzc_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> hzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzc_);
                    CqlDateTime hzzzzze_ = context.Operators.End(hzzzzzd_);
                    Period hzzzzzf_ = Visit?.Period;
                    CqlInterval<CqlDateTime> hzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzf_);
                    CqlDateTime hzzzzzh_ = context.Operators.Start(hzzzzzg_);
                    CqlQuantity hzzzzzi_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime hzzzzzj_ = context.Operators.Subtract(hzzzzzh_, hzzzzzi_);
                    CqlInterval<CqlDateTime> hzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzf_);
                    CqlDateTime hzzzzzm_ = context.Operators.Start(hzzzzzl_);
                    CqlInterval<CqlDateTime> hzzzzzn_ = context.Operators.Interval(hzzzzzj_, hzzzzzm_, true, true);
                    bool? hzzzzzo_ = context.Operators.In<CqlDateTime>(hzzzzze_, hzzzzzn_, default);
                    CqlInterval<CqlDateTime> hzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzf_);
                    CqlDateTime hzzzzzr_ = context.Operators.Start(hzzzzzq_);
                    bool? hzzzzzs_ = context.Operators.Not((bool?)(hzzzzzr_ is null));
                    bool? hzzzzzt_ = context.Operators.And(hzzzzzo_, hzzzzzs_);
                    bool? hzzzzzu_ = context.Operators.And(hzzzzzb_, hzzzzzt_);

                    return hzzzzzu_;
                };
                IEnumerable<Encounter> fzzzzzh_ = context.Operators.Where<Encounter>(fzzzzzf_, fzzzzzg_);
                object fzzzzzi_(Encounter @this)
                {
                    Period hzzzzzv_ = @this?.Period;
                    CqlInterval<CqlDateTime> hzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzv_);
                    CqlDateTime hzzzzzx_ = context.Operators.End(hzzzzzw_);

                    return hzzzzzx_;
                };
                IEnumerable<Encounter> fzzzzzj_ = context.Operators.SortBy<Encounter>(fzzzzzh_, fzzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter fzzzzzk_ = context.Operators.Last<Encounter>(fzzzzzj_);
                Period fzzzzzl_ = fzzzzzk_?.Period;
                CqlInterval<CqlDateTime> fzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzl_);
                CqlDateTime fzzzzzn_ = context.Operators.Start(fzzzzzm_);
                Period fzzzzzo_ = Visit?.Period;
                CqlInterval<CqlDateTime> fzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzo_);
                CqlDateTime fzzzzzq_ = context.Operators.Start(fzzzzzp_);
                CqlQuantity fzzzzzr_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime fzzzzzs_ = context.Operators.Subtract(fzzzzzn_ ?? fzzzzzq_, fzzzzzr_);
                IEnumerable<Encounter> fzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? fzzzzzv_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> hzzzzzy_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? hzzzzzz_ = hzzzzzy_?.Value;
                    Code<Encounter.EncounterStatus> izzzzza_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hzzzzzz_);
                    bool? izzzzzb_ = context.Operators.Equal(izzzzza_, "finished");
                    Period izzzzzc_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> izzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzc_);
                    CqlDateTime izzzzze_ = context.Operators.End(izzzzzd_);
                    Period izzzzzf_ = Visit?.Period;
                    CqlInterval<CqlDateTime> izzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzf_);
                    CqlDateTime izzzzzh_ = context.Operators.Start(izzzzzg_);
                    CqlQuantity izzzzzi_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime izzzzzj_ = context.Operators.Subtract(izzzzzh_, izzzzzi_);
                    CqlInterval<CqlDateTime> izzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzf_);
                    CqlDateTime izzzzzm_ = context.Operators.Start(izzzzzl_);
                    CqlInterval<CqlDateTime> izzzzzn_ = context.Operators.Interval(izzzzzj_, izzzzzm_, true, true);
                    bool? izzzzzo_ = context.Operators.In<CqlDateTime>(izzzzze_, izzzzzn_, default);
                    CqlInterval<CqlDateTime> izzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzf_);
                    CqlDateTime izzzzzr_ = context.Operators.Start(izzzzzq_);
                    bool? izzzzzs_ = context.Operators.Not((bool?)(izzzzzr_ is null));
                    bool? izzzzzt_ = context.Operators.And(izzzzzo_, izzzzzs_);
                    bool? izzzzzu_ = context.Operators.And(izzzzzb_, izzzzzt_);

                    return izzzzzu_;
                };
                IEnumerable<Encounter> fzzzzzw_ = context.Operators.Where<Encounter>(fzzzzzu_, fzzzzzv_);
                object fzzzzzx_(Encounter @this)
                {
                    Period izzzzzv_ = @this?.Period;
                    CqlInterval<CqlDateTime> izzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzv_);
                    CqlDateTime izzzzzx_ = context.Operators.End(izzzzzw_);

                    return izzzzzx_;
                };
                IEnumerable<Encounter> fzzzzzy_ = context.Operators.SortBy<Encounter>(fzzzzzw_, fzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter fzzzzzz_ = context.Operators.Last<Encounter>(fzzzzzy_);
                Period gzzzzza_ = fzzzzzz_?.Period;
                CqlInterval<CqlDateTime> gzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzza_);
                CqlDateTime gzzzzzc_ = context.Operators.Start(gzzzzzb_);
                CqlInterval<CqlDateTime> gzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzo_);
                CqlDateTime gzzzzzf_ = context.Operators.Start(gzzzzze_);
                CqlInterval<CqlDateTime> gzzzzzg_ = context.Operators.Interval(fzzzzzs_, gzzzzzc_ ?? gzzzzzf_, true, true);
                bool? gzzzzzh_ = context.Operators.In<CqlDateTime>(fzzzzzd_, gzzzzzg_, default);
                IEnumerable<Encounter> gzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? gzzzzzk_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> izzzzzy_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? izzzzzz_ = izzzzzy_?.Value;
                    Code<Encounter.EncounterStatus> jzzzzza_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(izzzzzz_);
                    bool? jzzzzzb_ = context.Operators.Equal(jzzzzza_, "finished");
                    Period jzzzzzc_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> jzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzc_);
                    CqlDateTime jzzzzze_ = context.Operators.End(jzzzzzd_);
                    Period jzzzzzf_ = Visit?.Period;
                    CqlInterval<CqlDateTime> jzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzf_);
                    CqlDateTime jzzzzzh_ = context.Operators.Start(jzzzzzg_);
                    CqlQuantity jzzzzzi_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime jzzzzzj_ = context.Operators.Subtract(jzzzzzh_, jzzzzzi_);
                    CqlInterval<CqlDateTime> jzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzf_);
                    CqlDateTime jzzzzzm_ = context.Operators.Start(jzzzzzl_);
                    CqlInterval<CqlDateTime> jzzzzzn_ = context.Operators.Interval(jzzzzzj_, jzzzzzm_, true, true);
                    bool? jzzzzzo_ = context.Operators.In<CqlDateTime>(jzzzzze_, jzzzzzn_, default);
                    CqlInterval<CqlDateTime> jzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzf_);
                    CqlDateTime jzzzzzr_ = context.Operators.Start(jzzzzzq_);
                    bool? jzzzzzs_ = context.Operators.Not((bool?)(jzzzzzr_ is null));
                    bool? jzzzzzt_ = context.Operators.And(jzzzzzo_, jzzzzzs_);
                    bool? jzzzzzu_ = context.Operators.And(jzzzzzb_, jzzzzzt_);

                    return jzzzzzu_;
                };
                IEnumerable<Encounter> gzzzzzl_ = context.Operators.Where<Encounter>(gzzzzzj_, gzzzzzk_);
                object gzzzzzm_(Encounter @this)
                {
                    Period jzzzzzv_ = @this?.Period;
                    CqlInterval<CqlDateTime> jzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzv_);
                    CqlDateTime jzzzzzx_ = context.Operators.End(jzzzzzw_);

                    return jzzzzzx_;
                };
                IEnumerable<Encounter> gzzzzzn_ = context.Operators.SortBy<Encounter>(gzzzzzl_, gzzzzzm_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter gzzzzzo_ = context.Operators.Last<Encounter>(gzzzzzn_);
                Period gzzzzzp_ = gzzzzzo_?.Period;
                CqlInterval<CqlDateTime> gzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzp_);
                CqlDateTime gzzzzzr_ = context.Operators.Start(gzzzzzq_);
                CqlInterval<CqlDateTime> gzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzo_);
                CqlDateTime gzzzzzu_ = context.Operators.Start(gzzzzzt_);
                bool? gzzzzzv_ = context.Operators.Not((bool?)((gzzzzzr_ ?? gzzzzzu_) is null));
                bool? gzzzzzw_ = context.Operators.And(gzzzzzh_, gzzzzzv_);
                bool? gzzzzzx_ = context.Operators.And(fzzzzza_, gzzzzzw_);

                return gzzzzzx_;
            };
            IEnumerable<Encounter> izzzzk_ = context.Operators.Where<Encounter>(izzzzi_, izzzzj_);
            object izzzzl_(Encounter @this)
            {
                Period jzzzzzy_ = @this?.Period;
                CqlInterval<CqlDateTime> jzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzy_);
                CqlDateTime kzzzzza_ = context.Operators.End(jzzzzzz_);

                return kzzzzza_;
            };
            IEnumerable<Encounter> izzzzm_ = context.Operators.SortBy<Encounter>(izzzzk_, izzzzl_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter izzzzn_ = context.Operators.Last<Encounter>(izzzzm_);
            Period izzzzo_ = izzzzn_?.Period;
            CqlInterval<CqlDateTime> izzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzo_);
            CqlDateTime izzzzq_ = context.Operators.Start(izzzzp_);
            CqlValueSet izzzzr_ = this.Observation_Services(context);
            IEnumerable<Encounter> izzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? izzzzt_(Encounter LastObs)
            {
                Code<Encounter.EncounterStatus> kzzzzzb_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? kzzzzzc_ = kzzzzzb_?.Value;
                Code<Encounter.EncounterStatus> kzzzzzd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(kzzzzzc_);
                bool? kzzzzze_ = context.Operators.Equal(kzzzzzd_, "finished");
                Period kzzzzzf_ = LastObs?.Period;
                CqlInterval<CqlDateTime> kzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzf_);
                CqlDateTime kzzzzzh_ = context.Operators.End(kzzzzzg_);
                Period kzzzzzi_ = Visit?.Period;
                CqlInterval<CqlDateTime> kzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzi_);
                CqlDateTime kzzzzzk_ = context.Operators.Start(kzzzzzj_);
                CqlQuantity kzzzzzl_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime kzzzzzm_ = context.Operators.Subtract(kzzzzzk_, kzzzzzl_);
                CqlInterval<CqlDateTime> kzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzi_);
                CqlDateTime kzzzzzp_ = context.Operators.Start(kzzzzzo_);
                CqlInterval<CqlDateTime> kzzzzzq_ = context.Operators.Interval(kzzzzzm_, kzzzzzp_, true, true);
                bool? kzzzzzr_ = context.Operators.In<CqlDateTime>(kzzzzzh_, kzzzzzq_, default);
                CqlInterval<CqlDateTime> kzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzi_);
                CqlDateTime kzzzzzu_ = context.Operators.Start(kzzzzzt_);
                bool? kzzzzzv_ = context.Operators.Not((bool?)(kzzzzzu_ is null));
                bool? kzzzzzw_ = context.Operators.And(kzzzzzr_, kzzzzzv_);
                bool? kzzzzzx_ = context.Operators.And(kzzzzze_, kzzzzzw_);

                return kzzzzzx_;
            };
            IEnumerable<Encounter> izzzzu_ = context.Operators.Where<Encounter>(izzzzs_, izzzzt_);
            object izzzzv_(Encounter @this)
            {
                Period kzzzzzy_ = @this?.Period;
                CqlInterval<CqlDateTime> kzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzy_);
                CqlDateTime lzzzzza_ = context.Operators.End(kzzzzzz_);

                return lzzzzza_;
            };
            IEnumerable<Encounter> izzzzw_ = context.Operators.SortBy<Encounter>(izzzzu_, izzzzv_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter izzzzx_ = context.Operators.Last<Encounter>(izzzzw_);
            Period izzzzy_ = izzzzx_?.Period;
            CqlInterval<CqlDateTime> izzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzy_);
            CqlDateTime jzzzza_ = context.Operators.Start(izzzzz_);
            Period jzzzzb_ = Visit?.Period;
            CqlInterval<CqlDateTime> jzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzb_);
            CqlDateTime jzzzzd_ = context.Operators.Start(jzzzzc_);
            CqlInterval<CqlDateTime> jzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzb_);
            CqlDateTime jzzzzg_ = context.Operators.End(jzzzzf_);
            CqlInterval<CqlDateTime> jzzzzh_ = context.Operators.Interval(izzzzg_ ?? izzzzq_ ?? jzzzza_ ?? jzzzzd_, jzzzzg_, true, true);

            return jzzzzh_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> hzzzzu_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)hzzzzs_, hzzzzt_);
        IEnumerable<CqlInterval<CqlDateTime>> hzzzzv_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(hzzzzu_);
        CqlInterval<CqlDateTime> hzzzzw_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(hzzzzv_);

        return hzzzzw_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservation")]
    [CqlTag("description", "Hospitalization with Observation returns the total interval from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationWithObservation()` instead.")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] lzzzzzb_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> lzzzzzc_(Encounter Visit)
        {
            CqlValueSet lzzzzzg_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> lzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? lzzzzzi_(Encounter LastED)
            {
                Code<Encounter.EncounterStatus> mzzzzzh_ = LastED?.StatusElement;
                Encounter.EncounterStatus? mzzzzzi_ = mzzzzzh_?.Value;
                Code<Encounter.EncounterStatus> mzzzzzj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(mzzzzzi_);
                bool? mzzzzzk_ = context.Operators.Equal(mzzzzzj_, "finished");
                Period mzzzzzl_ = LastED?.Period;
                CqlInterval<CqlDateTime> mzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzl_);
                CqlDateTime mzzzzzn_ = context.Operators.End(mzzzzzm_);
                CqlValueSet mzzzzzo_ = this.Observation_Services(context);
                IEnumerable<Encounter> mzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? mzzzzzq_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> ozzzzzi_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? ozzzzzj_ = ozzzzzi_?.Value;
                    Code<Encounter.EncounterStatus> ozzzzzk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ozzzzzj_);
                    bool? ozzzzzl_ = context.Operators.Equal(ozzzzzk_, "finished");
                    Period ozzzzzm_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> ozzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzm_);
                    CqlDateTime ozzzzzo_ = context.Operators.End(ozzzzzn_);
                    Period ozzzzzp_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ozzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzp_);
                    CqlDateTime ozzzzzr_ = context.Operators.Start(ozzzzzq_);
                    CqlQuantity ozzzzzs_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ozzzzzt_ = context.Operators.Subtract(ozzzzzr_, ozzzzzs_);
                    CqlInterval<CqlDateTime> ozzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzp_);
                    CqlDateTime ozzzzzw_ = context.Operators.Start(ozzzzzv_);
                    CqlInterval<CqlDateTime> ozzzzzx_ = context.Operators.Interval(ozzzzzt_, ozzzzzw_, true, true);
                    bool? ozzzzzy_ = context.Operators.In<CqlDateTime>(ozzzzzo_, ozzzzzx_, default);
                    CqlInterval<CqlDateTime> pzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzp_);
                    CqlDateTime pzzzzzb_ = context.Operators.Start(pzzzzza_);
                    bool? pzzzzzc_ = context.Operators.Not((bool?)(pzzzzzb_ is null));
                    bool? pzzzzzd_ = context.Operators.And(ozzzzzy_, pzzzzzc_);
                    bool? pzzzzze_ = context.Operators.And(ozzzzzl_, pzzzzzd_);

                    return pzzzzze_;
                };
                IEnumerable<Encounter> mzzzzzr_ = context.Operators.Where<Encounter>(mzzzzzp_, mzzzzzq_);
                object mzzzzzs_(Encounter @this)
                {
                    Period pzzzzzf_ = @this?.Period;
                    CqlInterval<CqlDateTime> pzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzf_);
                    CqlDateTime pzzzzzh_ = context.Operators.End(pzzzzzg_);

                    return pzzzzzh_;
                };
                IEnumerable<Encounter> mzzzzzt_ = context.Operators.SortBy<Encounter>(mzzzzzr_, mzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter mzzzzzu_ = context.Operators.Last<Encounter>(mzzzzzt_);
                Period mzzzzzv_ = mzzzzzu_?.Period;
                CqlInterval<CqlDateTime> mzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzv_);
                CqlDateTime mzzzzzx_ = context.Operators.Start(mzzzzzw_);
                Period mzzzzzy_ = Visit?.Period;
                CqlInterval<CqlDateTime> mzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzy_);
                CqlDateTime nzzzzza_ = context.Operators.Start(mzzzzzz_);
                CqlQuantity nzzzzzb_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime nzzzzzc_ = context.Operators.Subtract(mzzzzzx_ ?? nzzzzza_, nzzzzzb_);
                IEnumerable<Encounter> nzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? nzzzzzf_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> pzzzzzi_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? pzzzzzj_ = pzzzzzi_?.Value;
                    Code<Encounter.EncounterStatus> pzzzzzk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pzzzzzj_);
                    bool? pzzzzzl_ = context.Operators.Equal(pzzzzzk_, "finished");
                    Period pzzzzzm_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> pzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzm_);
                    CqlDateTime pzzzzzo_ = context.Operators.End(pzzzzzn_);
                    Period pzzzzzp_ = Visit?.Period;
                    CqlInterval<CqlDateTime> pzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzp_);
                    CqlDateTime pzzzzzr_ = context.Operators.Start(pzzzzzq_);
                    CqlQuantity pzzzzzs_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime pzzzzzt_ = context.Operators.Subtract(pzzzzzr_, pzzzzzs_);
                    CqlInterval<CqlDateTime> pzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzp_);
                    CqlDateTime pzzzzzw_ = context.Operators.Start(pzzzzzv_);
                    CqlInterval<CqlDateTime> pzzzzzx_ = context.Operators.Interval(pzzzzzt_, pzzzzzw_, true, true);
                    bool? pzzzzzy_ = context.Operators.In<CqlDateTime>(pzzzzzo_, pzzzzzx_, default);
                    CqlInterval<CqlDateTime> qzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzp_);
                    CqlDateTime qzzzzzb_ = context.Operators.Start(qzzzzza_);
                    bool? qzzzzzc_ = context.Operators.Not((bool?)(qzzzzzb_ is null));
                    bool? qzzzzzd_ = context.Operators.And(pzzzzzy_, qzzzzzc_);
                    bool? qzzzzze_ = context.Operators.And(pzzzzzl_, qzzzzzd_);

                    return qzzzzze_;
                };
                IEnumerable<Encounter> nzzzzzg_ = context.Operators.Where<Encounter>(nzzzzze_, nzzzzzf_);
                object nzzzzzh_(Encounter @this)
                {
                    Period qzzzzzf_ = @this?.Period;
                    CqlInterval<CqlDateTime> qzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzf_);
                    CqlDateTime qzzzzzh_ = context.Operators.End(qzzzzzg_);

                    return qzzzzzh_;
                };
                IEnumerable<Encounter> nzzzzzi_ = context.Operators.SortBy<Encounter>(nzzzzzg_, nzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter nzzzzzj_ = context.Operators.Last<Encounter>(nzzzzzi_);
                Period nzzzzzk_ = nzzzzzj_?.Period;
                CqlInterval<CqlDateTime> nzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzk_);
                CqlDateTime nzzzzzm_ = context.Operators.Start(nzzzzzl_);
                CqlInterval<CqlDateTime> nzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzy_);
                CqlDateTime nzzzzzp_ = context.Operators.Start(nzzzzzo_);
                CqlInterval<CqlDateTime> nzzzzzq_ = context.Operators.Interval(nzzzzzc_, nzzzzzm_ ?? nzzzzzp_, true, true);
                bool? nzzzzzr_ = context.Operators.In<CqlDateTime>(mzzzzzn_, nzzzzzq_, default);
                IEnumerable<Encounter> nzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? nzzzzzu_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> qzzzzzi_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? qzzzzzj_ = qzzzzzi_?.Value;
                    Code<Encounter.EncounterStatus> qzzzzzk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(qzzzzzj_);
                    bool? qzzzzzl_ = context.Operators.Equal(qzzzzzk_, "finished");
                    Period qzzzzzm_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> qzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzm_);
                    CqlDateTime qzzzzzo_ = context.Operators.End(qzzzzzn_);
                    Period qzzzzzp_ = Visit?.Period;
                    CqlInterval<CqlDateTime> qzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzp_);
                    CqlDateTime qzzzzzr_ = context.Operators.Start(qzzzzzq_);
                    CqlQuantity qzzzzzs_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime qzzzzzt_ = context.Operators.Subtract(qzzzzzr_, qzzzzzs_);
                    CqlInterval<CqlDateTime> qzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzp_);
                    CqlDateTime qzzzzzw_ = context.Operators.Start(qzzzzzv_);
                    CqlInterval<CqlDateTime> qzzzzzx_ = context.Operators.Interval(qzzzzzt_, qzzzzzw_, true, true);
                    bool? qzzzzzy_ = context.Operators.In<CqlDateTime>(qzzzzzo_, qzzzzzx_, default);
                    CqlInterval<CqlDateTime> rzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzp_);
                    CqlDateTime rzzzzzb_ = context.Operators.Start(rzzzzza_);
                    bool? rzzzzzc_ = context.Operators.Not((bool?)(rzzzzzb_ is null));
                    bool? rzzzzzd_ = context.Operators.And(qzzzzzy_, rzzzzzc_);
                    bool? rzzzzze_ = context.Operators.And(qzzzzzl_, rzzzzzd_);

                    return rzzzzze_;
                };
                IEnumerable<Encounter> nzzzzzv_ = context.Operators.Where<Encounter>(nzzzzzt_, nzzzzzu_);
                object nzzzzzw_(Encounter @this)
                {
                    Period rzzzzzf_ = @this?.Period;
                    CqlInterval<CqlDateTime> rzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzf_);
                    CqlDateTime rzzzzzh_ = context.Operators.End(rzzzzzg_);

                    return rzzzzzh_;
                };
                IEnumerable<Encounter> nzzzzzx_ = context.Operators.SortBy<Encounter>(nzzzzzv_, nzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter nzzzzzy_ = context.Operators.Last<Encounter>(nzzzzzx_);
                Period nzzzzzz_ = nzzzzzy_?.Period;
                CqlInterval<CqlDateTime> ozzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzz_);
                CqlDateTime ozzzzzb_ = context.Operators.Start(ozzzzza_);
                CqlInterval<CqlDateTime> ozzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzy_);
                CqlDateTime ozzzzze_ = context.Operators.Start(ozzzzzd_);
                bool? ozzzzzf_ = context.Operators.Not((bool?)((ozzzzzb_ ?? ozzzzze_) is null));
                bool? ozzzzzg_ = context.Operators.And(nzzzzzr_, ozzzzzf_);
                bool? ozzzzzh_ = context.Operators.And(mzzzzzk_, ozzzzzg_);

                return ozzzzzh_;
            };
            IEnumerable<Encounter> lzzzzzj_ = context.Operators.Where<Encounter>(lzzzzzh_, lzzzzzi_);
            object lzzzzzk_(Encounter @this)
            {
                Period rzzzzzi_ = @this?.Period;
                CqlInterval<CqlDateTime> rzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzi_);
                CqlDateTime rzzzzzk_ = context.Operators.End(rzzzzzj_);

                return rzzzzzk_;
            };
            IEnumerable<Encounter> lzzzzzl_ = context.Operators.SortBy<Encounter>(lzzzzzj_, lzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter lzzzzzm_ = context.Operators.Last<Encounter>(lzzzzzl_);
            Period lzzzzzn_ = lzzzzzm_?.Period;
            CqlInterval<CqlDateTime> lzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzn_);
            CqlDateTime lzzzzzp_ = context.Operators.Start(lzzzzzo_);
            CqlValueSet lzzzzzq_ = this.Observation_Services(context);
            IEnumerable<Encounter> lzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? lzzzzzs_(Encounter LastObs)
            {
                Code<Encounter.EncounterStatus> rzzzzzl_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? rzzzzzm_ = rzzzzzl_?.Value;
                Code<Encounter.EncounterStatus> rzzzzzn_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rzzzzzm_);
                bool? rzzzzzo_ = context.Operators.Equal(rzzzzzn_, "finished");
                Period rzzzzzp_ = LastObs?.Period;
                CqlInterval<CqlDateTime> rzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzp_);
                CqlDateTime rzzzzzr_ = context.Operators.End(rzzzzzq_);
                Period rzzzzzs_ = Visit?.Period;
                CqlInterval<CqlDateTime> rzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzs_);
                CqlDateTime rzzzzzu_ = context.Operators.Start(rzzzzzt_);
                CqlQuantity rzzzzzv_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime rzzzzzw_ = context.Operators.Subtract(rzzzzzu_, rzzzzzv_);
                CqlInterval<CqlDateTime> rzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzs_);
                CqlDateTime rzzzzzz_ = context.Operators.Start(rzzzzzy_);
                CqlInterval<CqlDateTime> szzzzza_ = context.Operators.Interval(rzzzzzw_, rzzzzzz_, true, true);
                bool? szzzzzb_ = context.Operators.In<CqlDateTime>(rzzzzzr_, szzzzza_, default);
                CqlInterval<CqlDateTime> szzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzs_);
                CqlDateTime szzzzze_ = context.Operators.Start(szzzzzd_);
                bool? szzzzzf_ = context.Operators.Not((bool?)(szzzzze_ is null));
                bool? szzzzzg_ = context.Operators.And(szzzzzb_, szzzzzf_);
                bool? szzzzzh_ = context.Operators.And(rzzzzzo_, szzzzzg_);

                return szzzzzh_;
            };
            IEnumerable<Encounter> lzzzzzt_ = context.Operators.Where<Encounter>(lzzzzzr_, lzzzzzs_);
            object lzzzzzu_(Encounter @this)
            {
                Period szzzzzi_ = @this?.Period;
                CqlInterval<CqlDateTime> szzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzi_);
                CqlDateTime szzzzzk_ = context.Operators.End(szzzzzj_);

                return szzzzzk_;
            };
            IEnumerable<Encounter> lzzzzzv_ = context.Operators.SortBy<Encounter>(lzzzzzt_, lzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter lzzzzzw_ = context.Operators.Last<Encounter>(lzzzzzv_);
            Period lzzzzzx_ = lzzzzzw_?.Period;
            CqlInterval<CqlDateTime> lzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzx_);
            CqlDateTime lzzzzzz_ = context.Operators.Start(lzzzzzy_);
            Period mzzzzza_ = Visit?.Period;
            CqlInterval<CqlDateTime> mzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzza_);
            CqlDateTime mzzzzzc_ = context.Operators.Start(mzzzzzb_);
            CqlInterval<CqlDateTime> mzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzza_);
            CqlDateTime mzzzzzf_ = context.Operators.End(mzzzzze_);
            CqlInterval<CqlDateTime> mzzzzzg_ = context.Operators.Interval(lzzzzzp_ ?? lzzzzzz_ ?? mzzzzzc_, mzzzzzf_, true, true);

            return mzzzzzg_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> lzzzzzd_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)lzzzzzb_, lzzzzzc_);
        IEnumerable<CqlInterval<CqlDateTime>> lzzzzze_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(lzzzzzd_);
        CqlInterval<CqlDateTime> lzzzzzf_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(lzzzzze_);

        return lzzzzzf_;
    }


    [CqlExpressionDefinition("hospitalizationWithObservation")]
    [CqlTag("description", "Hospitalization with Observation returns the total interval from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    public CqlInterval<CqlDateTime> hospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] szzzzzl_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> szzzzzm_(Encounter Visit)
        {
            CqlValueSet szzzzzq_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> szzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? szzzzzs_(Encounter LastED)
            {
                Code<Encounter.EncounterStatus> tzzzzzr_ = LastED?.StatusElement;
                Encounter.EncounterStatus? tzzzzzs_ = tzzzzzr_?.Value;
                Code<Encounter.EncounterStatus> tzzzzzt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(tzzzzzs_);
                bool? tzzzzzu_ = context.Operators.Equal(tzzzzzt_, "finished");
                Period tzzzzzv_ = LastED?.Period;
                CqlInterval<CqlDateTime> tzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzv_);
                CqlDateTime tzzzzzx_ = context.Operators.End(tzzzzzw_);
                CqlValueSet tzzzzzy_ = this.Observation_Services(context);
                IEnumerable<Encounter> tzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? uzzzzza_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> vzzzzzs_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? vzzzzzt_ = vzzzzzs_?.Value;
                    Code<Encounter.EncounterStatus> vzzzzzu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(vzzzzzt_);
                    bool? vzzzzzv_ = context.Operators.Equal(vzzzzzu_, "finished");
                    Period vzzzzzw_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> vzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzw_);
                    CqlDateTime vzzzzzy_ = context.Operators.End(vzzzzzx_);
                    Period vzzzzzz_ = Visit?.Period;
                    CqlInterval<CqlDateTime> wzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzz_);
                    CqlDateTime wzzzzzb_ = context.Operators.Start(wzzzzza_);
                    CqlQuantity wzzzzzc_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime wzzzzzd_ = context.Operators.Subtract(wzzzzzb_, wzzzzzc_);
                    CqlInterval<CqlDateTime> wzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzz_);
                    CqlDateTime wzzzzzg_ = context.Operators.Start(wzzzzzf_);
                    CqlInterval<CqlDateTime> wzzzzzh_ = context.Operators.Interval(wzzzzzd_, wzzzzzg_, true, true);
                    bool? wzzzzzi_ = context.Operators.In<CqlDateTime>(vzzzzzy_, wzzzzzh_, default);
                    CqlInterval<CqlDateTime> wzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzz_);
                    CqlDateTime wzzzzzl_ = context.Operators.Start(wzzzzzk_);
                    bool? wzzzzzm_ = context.Operators.Not((bool?)(wzzzzzl_ is null));
                    bool? wzzzzzn_ = context.Operators.And(wzzzzzi_, wzzzzzm_);
                    bool? wzzzzzo_ = context.Operators.And(vzzzzzv_, wzzzzzn_);

                    return wzzzzzo_;
                };
                IEnumerable<Encounter> uzzzzzb_ = context.Operators.Where<Encounter>(tzzzzzz_, uzzzzza_);
                object uzzzzzc_(Encounter @this)
                {
                    Period wzzzzzp_ = @this?.Period;
                    CqlInterval<CqlDateTime> wzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzp_);
                    CqlDateTime wzzzzzr_ = context.Operators.End(wzzzzzq_);

                    return wzzzzzr_;
                };
                IEnumerable<Encounter> uzzzzzd_ = context.Operators.SortBy<Encounter>(uzzzzzb_, uzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter uzzzzze_ = context.Operators.Last<Encounter>(uzzzzzd_);
                Period uzzzzzf_ = uzzzzze_?.Period;
                CqlInterval<CqlDateTime> uzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzf_);
                CqlDateTime uzzzzzh_ = context.Operators.Start(uzzzzzg_);
                Period uzzzzzi_ = Visit?.Period;
                CqlInterval<CqlDateTime> uzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzi_);
                CqlDateTime uzzzzzk_ = context.Operators.Start(uzzzzzj_);
                CqlQuantity uzzzzzl_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime uzzzzzm_ = context.Operators.Subtract(uzzzzzh_ ?? uzzzzzk_, uzzzzzl_);
                IEnumerable<Encounter> uzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? uzzzzzp_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> wzzzzzs_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? wzzzzzt_ = wzzzzzs_?.Value;
                    Code<Encounter.EncounterStatus> wzzzzzu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(wzzzzzt_);
                    bool? wzzzzzv_ = context.Operators.Equal(wzzzzzu_, "finished");
                    Period wzzzzzw_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> wzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzw_);
                    CqlDateTime wzzzzzy_ = context.Operators.End(wzzzzzx_);
                    Period wzzzzzz_ = Visit?.Period;
                    CqlInterval<CqlDateTime> xzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzz_);
                    CqlDateTime xzzzzzb_ = context.Operators.Start(xzzzzza_);
                    CqlQuantity xzzzzzc_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime xzzzzzd_ = context.Operators.Subtract(xzzzzzb_, xzzzzzc_);
                    CqlInterval<CqlDateTime> xzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzz_);
                    CqlDateTime xzzzzzg_ = context.Operators.Start(xzzzzzf_);
                    CqlInterval<CqlDateTime> xzzzzzh_ = context.Operators.Interval(xzzzzzd_, xzzzzzg_, true, true);
                    bool? xzzzzzi_ = context.Operators.In<CqlDateTime>(wzzzzzy_, xzzzzzh_, default);
                    CqlInterval<CqlDateTime> xzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzz_);
                    CqlDateTime xzzzzzl_ = context.Operators.Start(xzzzzzk_);
                    bool? xzzzzzm_ = context.Operators.Not((bool?)(xzzzzzl_ is null));
                    bool? xzzzzzn_ = context.Operators.And(xzzzzzi_, xzzzzzm_);
                    bool? xzzzzzo_ = context.Operators.And(wzzzzzv_, xzzzzzn_);

                    return xzzzzzo_;
                };
                IEnumerable<Encounter> uzzzzzq_ = context.Operators.Where<Encounter>(uzzzzzo_, uzzzzzp_);
                object uzzzzzr_(Encounter @this)
                {
                    Period xzzzzzp_ = @this?.Period;
                    CqlInterval<CqlDateTime> xzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzp_);
                    CqlDateTime xzzzzzr_ = context.Operators.End(xzzzzzq_);

                    return xzzzzzr_;
                };
                IEnumerable<Encounter> uzzzzzs_ = context.Operators.SortBy<Encounter>(uzzzzzq_, uzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter uzzzzzt_ = context.Operators.Last<Encounter>(uzzzzzs_);
                Period uzzzzzu_ = uzzzzzt_?.Period;
                CqlInterval<CqlDateTime> uzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzu_);
                CqlDateTime uzzzzzw_ = context.Operators.Start(uzzzzzv_);
                CqlInterval<CqlDateTime> uzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzi_);
                CqlDateTime uzzzzzz_ = context.Operators.Start(uzzzzzy_);
                CqlInterval<CqlDateTime> vzzzzza_ = context.Operators.Interval(uzzzzzm_, uzzzzzw_ ?? uzzzzzz_, true, true);
                bool? vzzzzzb_ = context.Operators.In<CqlDateTime>(tzzzzzx_, vzzzzza_, default);
                IEnumerable<Encounter> vzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? vzzzzze_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> xzzzzzs_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? xzzzzzt_ = xzzzzzs_?.Value;
                    Code<Encounter.EncounterStatus> xzzzzzu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(xzzzzzt_);
                    bool? xzzzzzv_ = context.Operators.Equal(xzzzzzu_, "finished");
                    Period xzzzzzw_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> xzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzw_);
                    CqlDateTime xzzzzzy_ = context.Operators.End(xzzzzzx_);
                    Period xzzzzzz_ = Visit?.Period;
                    CqlInterval<CqlDateTime> yzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzz_);
                    CqlDateTime yzzzzzb_ = context.Operators.Start(yzzzzza_);
                    CqlQuantity yzzzzzc_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime yzzzzzd_ = context.Operators.Subtract(yzzzzzb_, yzzzzzc_);
                    CqlInterval<CqlDateTime> yzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzz_);
                    CqlDateTime yzzzzzg_ = context.Operators.Start(yzzzzzf_);
                    CqlInterval<CqlDateTime> yzzzzzh_ = context.Operators.Interval(yzzzzzd_, yzzzzzg_, true, true);
                    bool? yzzzzzi_ = context.Operators.In<CqlDateTime>(xzzzzzy_, yzzzzzh_, default);
                    CqlInterval<CqlDateTime> yzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzz_);
                    CqlDateTime yzzzzzl_ = context.Operators.Start(yzzzzzk_);
                    bool? yzzzzzm_ = context.Operators.Not((bool?)(yzzzzzl_ is null));
                    bool? yzzzzzn_ = context.Operators.And(yzzzzzi_, yzzzzzm_);
                    bool? yzzzzzo_ = context.Operators.And(xzzzzzv_, yzzzzzn_);

                    return yzzzzzo_;
                };
                IEnumerable<Encounter> vzzzzzf_ = context.Operators.Where<Encounter>(vzzzzzd_, vzzzzze_);
                object vzzzzzg_(Encounter @this)
                {
                    Period yzzzzzp_ = @this?.Period;
                    CqlInterval<CqlDateTime> yzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzp_);
                    CqlDateTime yzzzzzr_ = context.Operators.End(yzzzzzq_);

                    return yzzzzzr_;
                };
                IEnumerable<Encounter> vzzzzzh_ = context.Operators.SortBy<Encounter>(vzzzzzf_, vzzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter vzzzzzi_ = context.Operators.Last<Encounter>(vzzzzzh_);
                Period vzzzzzj_ = vzzzzzi_?.Period;
                CqlInterval<CqlDateTime> vzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzj_);
                CqlDateTime vzzzzzl_ = context.Operators.Start(vzzzzzk_);
                CqlInterval<CqlDateTime> vzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzi_);
                CqlDateTime vzzzzzo_ = context.Operators.Start(vzzzzzn_);
                bool? vzzzzzp_ = context.Operators.Not((bool?)((vzzzzzl_ ?? vzzzzzo_) is null));
                bool? vzzzzzq_ = context.Operators.And(vzzzzzb_, vzzzzzp_);
                bool? vzzzzzr_ = context.Operators.And(tzzzzzu_, vzzzzzq_);

                return vzzzzzr_;
            };
            IEnumerable<Encounter> szzzzzt_ = context.Operators.Where<Encounter>(szzzzzr_, szzzzzs_);
            object szzzzzu_(Encounter @this)
            {
                Period yzzzzzs_ = @this?.Period;
                CqlInterval<CqlDateTime> yzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzs_);
                CqlDateTime yzzzzzu_ = context.Operators.End(yzzzzzt_);

                return yzzzzzu_;
            };
            IEnumerable<Encounter> szzzzzv_ = context.Operators.SortBy<Encounter>(szzzzzt_, szzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter szzzzzw_ = context.Operators.Last<Encounter>(szzzzzv_);
            Period szzzzzx_ = szzzzzw_?.Period;
            CqlInterval<CqlDateTime> szzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzx_);
            CqlDateTime szzzzzz_ = context.Operators.Start(szzzzzy_);
            CqlValueSet tzzzzza_ = this.Observation_Services(context);
            IEnumerable<Encounter> tzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? tzzzzzc_(Encounter LastObs)
            {
                Code<Encounter.EncounterStatus> yzzzzzv_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? yzzzzzw_ = yzzzzzv_?.Value;
                Code<Encounter.EncounterStatus> yzzzzzx_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(yzzzzzw_);
                bool? yzzzzzy_ = context.Operators.Equal(yzzzzzx_, "finished");
                Period yzzzzzz_ = LastObs?.Period;
                CqlInterval<CqlDateTime> zzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzz_);
                CqlDateTime zzzzzzb_ = context.Operators.End(zzzzzza_);
                Period zzzzzzc_ = Visit?.Period;
                CqlInterval<CqlDateTime> zzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzc_);
                CqlDateTime zzzzzze_ = context.Operators.Start(zzzzzzd_);
                CqlQuantity zzzzzzf_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime zzzzzzg_ = context.Operators.Subtract(zzzzzze_, zzzzzzf_);
                CqlInterval<CqlDateTime> zzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzc_);
                CqlDateTime zzzzzzj_ = context.Operators.Start(zzzzzzi_);
                CqlInterval<CqlDateTime> zzzzzzk_ = context.Operators.Interval(zzzzzzg_, zzzzzzj_, true, true);
                bool? zzzzzzl_ = context.Operators.In<CqlDateTime>(zzzzzzb_, zzzzzzk_, default);
                CqlInterval<CqlDateTime> zzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzc_);
                CqlDateTime zzzzzzo_ = context.Operators.Start(zzzzzzn_);
                bool? zzzzzzp_ = context.Operators.Not((bool?)(zzzzzzo_ is null));
                bool? zzzzzzq_ = context.Operators.And(zzzzzzl_, zzzzzzp_);
                bool? zzzzzzr_ = context.Operators.And(yzzzzzy_, zzzzzzq_);

                return zzzzzzr_;
            };
            IEnumerable<Encounter> tzzzzzd_ = context.Operators.Where<Encounter>(tzzzzzb_, tzzzzzc_);
            object tzzzzze_(Encounter @this)
            {
                Period zzzzzzs_ = @this?.Period;
                CqlInterval<CqlDateTime> zzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzs_);
                CqlDateTime zzzzzzu_ = context.Operators.End(zzzzzzt_);

                return zzzzzzu_;
            };
            IEnumerable<Encounter> tzzzzzf_ = context.Operators.SortBy<Encounter>(tzzzzzd_, tzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter tzzzzzg_ = context.Operators.Last<Encounter>(tzzzzzf_);
            Period tzzzzzh_ = tzzzzzg_?.Period;
            CqlInterval<CqlDateTime> tzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzh_);
            CqlDateTime tzzzzzj_ = context.Operators.Start(tzzzzzi_);
            Period tzzzzzk_ = Visit?.Period;
            CqlInterval<CqlDateTime> tzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzk_);
            CqlDateTime tzzzzzm_ = context.Operators.Start(tzzzzzl_);
            CqlInterval<CqlDateTime> tzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzk_);
            CqlDateTime tzzzzzp_ = context.Operators.End(tzzzzzo_);
            CqlInterval<CqlDateTime> tzzzzzq_ = context.Operators.Interval(szzzzzz_ ?? tzzzzzj_ ?? tzzzzzm_, tzzzzzp_, true, true);

            return tzzzzzq_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> szzzzzn_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)szzzzzl_, szzzzzm_);
        IEnumerable<CqlInterval<CqlDateTime>> szzzzzo_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(szzzzzn_);
        CqlInterval<CqlDateTime> szzzzzp_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(szzzzzo_);

        return szzzzzp_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservationLengthofStay")]
    [CqlTag("description", "Hospitalization with Observation Length of Stay returns the length in days from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationWithObservationLengthofStay()` instead.")]
    public int? HospitalizationWithObservationLengthofStay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> zzzzzzv_ = this.HospitalizationWithObservation(context, TheEncounter);
        int? zzzzzzw_ = this.LengthInDays(context, zzzzzzv_);

        return zzzzzzw_;
    }


    [CqlExpressionDefinition("hospitalizationWithObservationLengthofStay")]
    [CqlTag("description", "Hospitalization with Observation Length of Stay returns the length in days from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    public int? hospitalizationWithObservationLengthofStay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> zzzzzzx_ = this.hospitalizationWithObservation(context, TheEncounter);
        int? zzzzzzy_ = this.lengthInDays(context, zzzzzzx_);

        return zzzzzzy_;
    }


    [CqlExpressionDefinition("FirstInpatientIntensiveCareUnit")]
    [CqlTag("description", "First Inpatient Intensive Care Unit returns the first intensive care unit for the given encounter, without considering any immediately prior emergency department visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `firstInpatientIntensiveCareUnit()` instead.")]
    public Encounter.LocationComponent FirstInpatientIntensiveCareUnit(CqlContext context, Encounter Encounter)
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


    [CqlExpressionDefinition("firstInpatientIntensiveCareUnit")]
    [CqlTag("description", "First Inpatient Intensive Care Unit returns the first intensive care unit for the given encounter, without considering any immediately prior emergency department visit.")]
    public Encounter.LocationComponent firstInpatientIntensiveCareUnit(CqlContext context, Encounter Encounter)
    {
        List<Encounter.LocationComponent> azzzzzzw_ = Encounter?.Location;
        bool? azzzzzzx_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference bzzzzzzc_ = HospitalLocation?.Location;
            Location bzzzzzzd_ = this.GetLocation(context, bzzzzzzc_);
            List<CodeableConcept> bzzzzzze_ = bzzzzzzd_?.Type;
            CqlConcept bzzzzzzf_(CodeableConcept @this)
            {
                CqlConcept bzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return bzzzzzzp_;
            };
            IEnumerable<CqlConcept> bzzzzzzg_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bzzzzzze_, bzzzzzzf_);
            CqlValueSet bzzzzzzh_ = this.Intensive_Care_Unit(context);
            bool? bzzzzzzi_ = context.Operators.ConceptsInValueSet(bzzzzzzg_, bzzzzzzh_);
            Period bzzzzzzj_ = Encounter?.Period;
            CqlInterval<CqlDateTime> bzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzj_);
            Period bzzzzzzl_ = HospitalLocation?.Period;
            CqlInterval<CqlDateTime> bzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzl_);
            bool? bzzzzzzn_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bzzzzzzk_, bzzzzzzm_, default);
            bool? bzzzzzzo_ = context.Operators.And(bzzzzzzi_, bzzzzzzn_);

            return bzzzzzzo_;
        };
        IEnumerable<Encounter.LocationComponent> azzzzzzy_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)azzzzzzw_, azzzzzzx_);
        object azzzzzzz_(Encounter.LocationComponent @this)
        {
            Period bzzzzzzq_ = @this?.Period;
            CqlInterval<CqlDateTime> bzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzq_);
            CqlDateTime bzzzzzzs_ = context.Operators.Start(bzzzzzzr_);

            return bzzzzzzs_;
        };
        IEnumerable<Encounter.LocationComponent> bzzzzzza_ = context.Operators.SortBy<Encounter.LocationComponent>(azzzzzzy_, azzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent bzzzzzzb_ = context.Operators.First<Encounter.LocationComponent>(bzzzzzza_);

        return bzzzzzzb_;
    }


    [CqlExpressionDefinition("EncounterDiagnosis")]
    [CqlTag("description", "Returns the Condition resource referenced by the `diagnosis.condition` element of the Encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `encounterDiagnosis()` instead.")]
    public IEnumerable<Condition> EncounterDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> bzzzzzzt_ = Encounter?.Diagnosis;
        Condition bzzzzzzu_(Encounter.DiagnosisComponent D)
        {
            IEnumerable<Condition> bzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? bzzzzzzy_(Condition C)
            {
                Id czzzzzzb_ = C?.IdElement;
                string czzzzzzc_ = czzzzzzb_?.Value;
                ResourceReference czzzzzzd_ = D?.Condition;
                FhirString czzzzzze_ = czzzzzzd_?.ReferenceElement;
                string czzzzzzf_ = czzzzzze_?.Value;
                string czzzzzzg_ = QICoreCommon_2_1_000.Instance.getId(context, czzzzzzf_);
                bool? czzzzzzh_ = context.Operators.Equal(czzzzzzc_, czzzzzzg_);

                return czzzzzzh_;
            };
            IEnumerable<Condition> bzzzzzzz_ = context.Operators.Where<Condition>(bzzzzzzx_, bzzzzzzy_);
            Condition czzzzzza_ = context.Operators.SingletonFrom<Condition>(bzzzzzzz_);

            return czzzzzza_;
        };
        IEnumerable<Condition> bzzzzzzv_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)bzzzzzzt_, bzzzzzzu_);
        IEnumerable<Condition> bzzzzzzw_ = context.Operators.Distinct<Condition>(bzzzzzzv_);

        return bzzzzzzw_;
    }


    [CqlExpressionDefinition("encounterDiagnosis")]
    [CqlTag("description", "Returns the Condition resources referenced by the diagnosis element of the Encounter")]
    public IEnumerable<Condition> encounterDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> czzzzzzi_ = Encounter?.Diagnosis;
        Condition czzzzzzj_(Encounter.DiagnosisComponent D)
        {
            IEnumerable<Condition> czzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? czzzzzzn_(Condition C)
            {
                Id czzzzzzq_ = C?.IdElement;
                string czzzzzzr_ = czzzzzzq_?.Value;
                ResourceReference czzzzzzs_ = D?.Condition;
                FhirString czzzzzzt_ = czzzzzzs_?.ReferenceElement;
                string czzzzzzu_ = czzzzzzt_?.Value;
                string czzzzzzv_ = QICoreCommon_2_1_000.Instance.getId(context, czzzzzzu_);
                bool? czzzzzzw_ = context.Operators.Equal(czzzzzzr_, czzzzzzv_);

                return czzzzzzw_;
            };
            IEnumerable<Condition> czzzzzzo_ = context.Operators.Where<Condition>(czzzzzzm_, czzzzzzn_);
            Condition czzzzzzp_ = context.Operators.SingletonFrom<Condition>(czzzzzzo_);

            return czzzzzzp_;
        };
        IEnumerable<Condition> czzzzzzk_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)czzzzzzi_, czzzzzzj_);
        IEnumerable<Condition> czzzzzzl_ = context.Operators.Distinct<Condition>(czzzzzzk_);

        return czzzzzzl_;
    }


    [CqlExpressionDefinition("GetCondition")]
    [CqlTag("description", "Returns the Condition resource for the given reference")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getCondition()` instead")]
    public Condition GetCondition(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Condition> czzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? czzzzzzy_(Condition C)
        {
            Id dzzzzzzb_ = C?.IdElement;
            string dzzzzzzc_ = dzzzzzzb_?.Value;
            FhirString dzzzzzzd_ = reference?.ReferenceElement;
            string dzzzzzze_ = dzzzzzzd_?.Value;
            string dzzzzzzf_ = QICoreCommon_2_1_000.Instance.getId(context, dzzzzzze_);
            bool? dzzzzzzg_ = context.Operators.Equal(dzzzzzzc_, dzzzzzzf_);

            return dzzzzzzg_;
        };
        IEnumerable<Condition> czzzzzzz_ = context.Operators.Where<Condition>(czzzzzzx_, czzzzzzy_);
        Condition dzzzzzza_ = context.Operators.SingletonFrom<Condition>(czzzzzzz_);

        return dzzzzzza_;
    }


    [CqlExpressionDefinition("getCondition")]
    [CqlTag("description", "Returns the Condition resource for the given reference")]
    public Condition getCondition(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Condition> dzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? dzzzzzzi_(Condition C)
        {
            Id dzzzzzzl_ = C?.IdElement;
            string dzzzzzzm_ = dzzzzzzl_?.Value;
            FhirString dzzzzzzn_ = reference?.ReferenceElement;
            string dzzzzzzo_ = dzzzzzzn_?.Value;
            string dzzzzzzp_ = QICoreCommon_2_1_000.Instance.getId(context, dzzzzzzo_);
            bool? dzzzzzzq_ = context.Operators.Equal(dzzzzzzm_, dzzzzzzp_);

            return dzzzzzzq_;
        };
        IEnumerable<Condition> dzzzzzzj_ = context.Operators.Where<Condition>(dzzzzzzh_, dzzzzzzi_);
        Condition dzzzzzzk_ = context.Operators.SingletonFrom<Condition>(dzzzzzzj_);

        return dzzzzzzk_;
    }


    [CqlExpressionDefinition("PrincipalDiagnosis")]
    [CqlTag("description", "Returns the condition that is specified as the principal diagnosis for the encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `principalDiagnosis()` instead.")]
    public Condition PrincipalDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> dzzzzzzr_ = Encounter?.Diagnosis;
        bool? dzzzzzzs_(Encounter.DiagnosisComponent D)
        {
            PositiveInt dzzzzzzy_ = D?.RankElement;
            int? dzzzzzzz_ = dzzzzzzy_?.Value;
            bool? ezzzzzza_ = context.Operators.Equal(dzzzzzzz_, 1);
            CodeableConcept ezzzzzzb_ = D?.Use;
            CqlConcept ezzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzb_);
            CqlCode ezzzzzzd_ = this.Billing(context);
            CqlConcept ezzzzzze_ = context.Operators.ConvertCodeToConcept(ezzzzzzd_);
            bool? ezzzzzzf_ = context.Operators.Equivalent(ezzzzzzc_, ezzzzzze_);
            bool? ezzzzzzg_ = context.Operators.And(ezzzzzza_, ezzzzzzf_);

            return ezzzzzzg_;
        };
        IEnumerable<Encounter.DiagnosisComponent> dzzzzzzt_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)dzzzzzzr_, dzzzzzzs_);
        Condition dzzzzzzu_(Encounter.DiagnosisComponent PD)
        {
            IEnumerable<Condition> ezzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? ezzzzzzi_(Condition C)
            {
                Id ezzzzzzl_ = C?.IdElement;
                string ezzzzzzm_ = ezzzzzzl_?.Value;
                ResourceReference ezzzzzzn_ = PD?.Condition;
                FhirString ezzzzzzo_ = ezzzzzzn_?.ReferenceElement;
                string ezzzzzzp_ = ezzzzzzo_?.Value;
                string ezzzzzzq_ = QICoreCommon_2_1_000.Instance.getId(context, ezzzzzzp_);
                bool? ezzzzzzr_ = context.Operators.Equal(ezzzzzzm_, ezzzzzzq_);

                return ezzzzzzr_;
            };
            IEnumerable<Condition> ezzzzzzj_ = context.Operators.Where<Condition>(ezzzzzzh_, ezzzzzzi_);
            Condition ezzzzzzk_ = context.Operators.SingletonFrom<Condition>(ezzzzzzj_);

            return ezzzzzzk_;
        };
        IEnumerable<Condition> dzzzzzzv_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>(dzzzzzzt_, dzzzzzzu_);
        IEnumerable<Condition> dzzzzzzw_ = context.Operators.Distinct<Condition>(dzzzzzzv_);
        Condition dzzzzzzx_ = context.Operators.SingletonFrom<Condition>(dzzzzzzw_);

        return dzzzzzzx_;
    }


    [CqlExpressionDefinition("principalDiagnosis")]
    [CqlTag("description", "Returns the condition that is specified as the principal diagnosis for the encounter")]
    public Condition principalDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> ezzzzzzs_ = Encounter?.Diagnosis;
        bool? ezzzzzzt_(Encounter.DiagnosisComponent D)
        {
            PositiveInt ezzzzzzz_ = D?.RankElement;
            int? fzzzzzza_ = ezzzzzzz_?.Value;
            bool? fzzzzzzb_ = context.Operators.Equal(fzzzzzza_, 1);
            CodeableConcept fzzzzzzc_ = D?.Use;
            CqlConcept fzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fzzzzzzc_);
            CqlCode fzzzzzze_ = this.Billing(context);
            CqlConcept fzzzzzzf_ = context.Operators.ConvertCodeToConcept(fzzzzzze_);
            bool? fzzzzzzg_ = context.Operators.Equivalent(fzzzzzzd_, fzzzzzzf_);
            bool? fzzzzzzh_ = context.Operators.And(fzzzzzzb_, fzzzzzzg_);

            return fzzzzzzh_;
        };
        IEnumerable<Encounter.DiagnosisComponent> ezzzzzzu_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)ezzzzzzs_, ezzzzzzt_);
        Condition ezzzzzzv_(Encounter.DiagnosisComponent PD)
        {
            IEnumerable<Condition> fzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? fzzzzzzj_(Condition C)
            {
                Id fzzzzzzm_ = C?.IdElement;
                string fzzzzzzn_ = fzzzzzzm_?.Value;
                ResourceReference fzzzzzzo_ = PD?.Condition;
                FhirString fzzzzzzp_ = fzzzzzzo_?.ReferenceElement;
                string fzzzzzzq_ = fzzzzzzp_?.Value;
                string fzzzzzzr_ = QICoreCommon_2_1_000.Instance.getId(context, fzzzzzzq_);
                bool? fzzzzzzs_ = context.Operators.Equal(fzzzzzzn_, fzzzzzzr_);

                return fzzzzzzs_;
            };
            IEnumerable<Condition> fzzzzzzk_ = context.Operators.Where<Condition>(fzzzzzzi_, fzzzzzzj_);
            Condition fzzzzzzl_ = context.Operators.SingletonFrom<Condition>(fzzzzzzk_);

            return fzzzzzzl_;
        };
        IEnumerable<Condition> ezzzzzzw_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>(ezzzzzzu_, ezzzzzzv_);
        IEnumerable<Condition> ezzzzzzx_ = context.Operators.Distinct<Condition>(ezzzzzzw_);
        Condition ezzzzzzy_ = context.Operators.SingletonFrom<Condition>(ezzzzzzx_);

        return ezzzzzzy_;
    }


    [CqlExpressionDefinition("getLocation")]
    [CqlTag("description", "Returns the Location resource specified by the given reference.")]
    public Location getLocation(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Location> fzzzzzzt_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-location"));
        bool? fzzzzzzu_(Location L)
        {
            Id fzzzzzzx_ = L?.IdElement;
            string fzzzzzzy_ = fzzzzzzx_?.Value;
            FhirString fzzzzzzz_ = reference?.ReferenceElement;
            string gzzzzzza_ = fzzzzzzz_?.Value;
            string gzzzzzzb_ = QICoreCommon_2_1_000.Instance.getId(context, gzzzzzza_);
            bool? gzzzzzzc_ = context.Operators.Equal(fzzzzzzy_, gzzzzzzb_);

            return gzzzzzzc_;
        };
        IEnumerable<Location> fzzzzzzv_ = context.Operators.Where<Location>(fzzzzzzt_, fzzzzzzu_);
        Location fzzzzzzw_ = context.Operators.SingletonFrom<Location>(fzzzzzzv_);

        return fzzzzzzw_;
    }


    [CqlExpressionDefinition("GetMedicationCode")]
    [CqlTag("description", "Returns the medication code for the given MedicationRequest")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getMedicationCode()` instead.")]
    public CqlConcept GetMedicationCode(CqlContext context, MedicationRequest request)
    {
        CqlConcept gzzzzzzd_()
        {
            bool gzzzzzze_()
            {
                DataType gzzzzzzf_ = request?.Medication;
                object gzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzf_);
                bool gzzzzzzh_ = gzzzzzzg_ is CqlConcept;

                return gzzzzzzh_;
            };
            if (gzzzzzze_())
            {
                DataType gzzzzzzi_ = request?.Medication;
                object gzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzi_);

                return gzzzzzzj_ as CqlConcept;
            }
            else
            {
                IEnumerable<Medication> gzzzzzzk_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? gzzzzzzl_(Medication M)
                {
                    Id gzzzzzzq_ = M?.IdElement;
                    string gzzzzzzr_ = gzzzzzzq_?.Value;
                    DataType gzzzzzzs_ = request?.Medication;
                    object gzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzs_);
                    FhirString gzzzzzzu_ = (gzzzzzzt_ as ResourceReference)?.ReferenceElement;
                    string gzzzzzzv_ = gzzzzzzu_?.Value;
                    string gzzzzzzw_ = QICoreCommon_2_1_000.Instance.getId(context, gzzzzzzv_);
                    bool? gzzzzzzx_ = context.Operators.Equal(gzzzzzzr_, gzzzzzzw_);

                    return gzzzzzzx_;
                };
                IEnumerable<Medication> gzzzzzzm_ = context.Operators.Where<Medication>(gzzzzzzk_, gzzzzzzl_);
                Medication gzzzzzzn_ = context.Operators.SingletonFrom<Medication>(gzzzzzzm_);
                CodeableConcept gzzzzzzo_ = gzzzzzzn_?.Code;
                CqlConcept gzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gzzzzzzo_);

                return gzzzzzzp_;
            }
        };

        return gzzzzzzd_();
    }


    [CqlExpressionDefinition("getMedicationCode")]
    [CqlTag("description", "Returns the medication code for the given MedicationRequest")]
    public CqlConcept getMedicationCode(CqlContext context, MedicationRequest request)
    {
        CqlConcept gzzzzzzy_()
        {
            bool gzzzzzzz_()
            {
                DataType hzzzzzza_ = request?.Medication;
                object hzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzza_);
                bool hzzzzzzc_ = hzzzzzzb_ is CqlConcept;

                return hzzzzzzc_;
            };
            if (gzzzzzzz_())
            {
                DataType hzzzzzzd_ = request?.Medication;
                object hzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzd_);

                return hzzzzzze_ as CqlConcept;
            }
            else
            {
                IEnumerable<Medication> hzzzzzzf_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? hzzzzzzg_(Medication M)
                {
                    Id hzzzzzzl_ = M?.IdElement;
                    string hzzzzzzm_ = hzzzzzzl_?.Value;
                    DataType hzzzzzzn_ = request?.Medication;
                    object hzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzn_);
                    FhirString hzzzzzzp_ = (hzzzzzzo_ as ResourceReference)?.ReferenceElement;
                    string hzzzzzzq_ = hzzzzzzp_?.Value;
                    string hzzzzzzr_ = QICoreCommon_2_1_000.Instance.getId(context, hzzzzzzq_);
                    bool? hzzzzzzs_ = context.Operators.Equal(hzzzzzzm_, hzzzzzzr_);

                    return hzzzzzzs_;
                };
                IEnumerable<Medication> hzzzzzzh_ = context.Operators.Where<Medication>(hzzzzzzf_, hzzzzzzg_);
                Medication hzzzzzzi_ = context.Operators.SingletonFrom<Medication>(hzzzzzzh_);
                CodeableConcept hzzzzzzj_ = hzzzzzzi_?.Code;
                CqlConcept hzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hzzzzzzj_);

                return hzzzzzzk_;
            }
        };

        return gzzzzzzy_();
    }


    #endregion Expressions

}
