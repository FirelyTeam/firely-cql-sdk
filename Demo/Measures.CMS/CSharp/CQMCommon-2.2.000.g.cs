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
        CqlDateTime lzzp_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime lzzq_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> lzzr_ = context.Operators.Interval(lzzp_, lzzq_, true, false);
        object lzzs_ = context.ResolveParameter("CQMCommon-2.2.000", "Measurement Period", lzzr_);

        return (CqlInterval<CqlDateTime>)lzzs_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> lzzt_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient lzzu_ = context.Operators.SingletonFrom<Patient>(lzzt_);

        return lzzu_;
    }


    [CqlExpressionDefinition("Inpatient Encounter")]
    public IEnumerable<Encounter> Inpatient_Encounter(CqlContext context)
    {
        CqlValueSet lzzv_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> lzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? lzzx_(Encounter EncounterInpatient)
        {
            Code<Encounter.EncounterStatus> lzzz_ = EncounterInpatient?.StatusElement;
            Encounter.EncounterStatus? mzza_ = lzzz_?.Value;
            Code<Encounter.EncounterStatus> mzzb_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(mzza_);
            bool? mzzc_ = context.Operators.Equal(mzzb_, "finished");
            Period mzzd_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime> mzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzd_);
            CqlDateTime mzzf_ = context.Operators.End(mzze_);
            CqlInterval<CqlDateTime> mzzg_ = this.Measurement_Period(context);
            bool? mzzh_ = context.Operators.In<CqlDateTime>(mzzf_, mzzg_, "day");
            bool? mzzi_ = context.Operators.And(mzzc_, mzzh_);

            return mzzi_;
        };
        IEnumerable<Encounter> lzzy_ = context.Operators.Where<Encounter>(lzzw_, lzzx_);

        return lzzy_;
    }


    [CqlExpressionDefinition("ToDateInterval")]
    [CqlTag("description", "Returns an interval of date values extracted from the input interval of date-time values")]
    [CqlTag("comment", "This function returns an interval constructed using the `date from` extractor on the start\nand end values of the input date-time interval. Note that using a precision specifier such as `day of`\nas part of a timing phrase is preferred to communicate intent to perform day-level comparison, as well\nas for general readability.")]
    public CqlInterval<CqlDate> ToDateInterval(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime mzzj_ = context.Operators.Start(period);
        CqlDate mzzk_ = context.Operators.DateFrom(mzzj_);
        CqlDateTime mzzl_ = context.Operators.End(period);
        CqlDate mzzm_ = context.Operators.DateFrom(mzzl_);
        CqlInterval<CqlDate> mzzn_ = context.Operators.Interval(mzzk_, mzzm_, true, true);

        return mzzn_;
    }


    [CqlExpressionDefinition("LengthInDays")]
    [CqlTag("description", "Calculates the difference in calendar days between the start and end of the given interval.")]
    [CqlTag("deprecated", "This function in deprecated. Use the fluent function `lengthInDays()` instead.")]
    public int? LengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
    {
        CqlDateTime mzzo_ = context.Operators.Start(Value);
        CqlDateTime mzzp_ = context.Operators.End(Value);
        int? mzzq_ = context.Operators.DifferenceBetween(mzzo_, mzzp_, "day");

        return mzzq_;
    }


    [CqlExpressionDefinition("lengthInDays")]
    [CqlTag("description", "Calculates the difference in calendar days between the start and end of the given interval.")]
    public int? lengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
    {
        CqlDateTime mzzr_ = context.Operators.Start(Value);
        CqlDateTime mzzs_ = context.Operators.End(Value);
        int? mzzt_ = context.Operators.DifferenceBetween(mzzr_, mzzs_, "day");

        return mzzt_;
    }


    [CqlExpressionDefinition("ED Visit")]
    [CqlTag("description", "Returns the most recent emergency department visit, if any, that occurs 1 hour or less prior to the given encounter.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `edVisit()` instead.")]
    public Encounter ED_Visit(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet mzzu_ = this.Emergency_Department_Visit(context);
        IEnumerable<Encounter> mzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? mzzw_(Encounter EDVisit)
        {
            Code<Encounter.EncounterStatus> nzzb_ = EDVisit?.StatusElement;
            Encounter.EncounterStatus? nzzc_ = nzzb_?.Value;
            Code<Encounter.EncounterStatus> nzzd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(nzzc_);
            bool? nzze_ = context.Operators.Equal(nzzd_, "finished");
            Period nzzf_ = EDVisit?.Period;
            CqlInterval<CqlDateTime> nzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzf_);
            CqlDateTime nzzh_ = context.Operators.End(nzzg_);
            Period nzzi_ = TheEncounter?.Period;
            CqlInterval<CqlDateTime> nzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzi_);
            CqlDateTime nzzk_ = context.Operators.Start(nzzj_);
            CqlQuantity nzzl_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime nzzm_ = context.Operators.Subtract(nzzk_, nzzl_);
            CqlInterval<CqlDateTime> nzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzi_);
            CqlDateTime nzzp_ = context.Operators.Start(nzzo_);
            CqlInterval<CqlDateTime> nzzq_ = context.Operators.Interval(nzzm_, nzzp_, true, true);
            bool? nzzr_ = context.Operators.In<CqlDateTime>(nzzh_, nzzq_, default);
            CqlInterval<CqlDateTime> nzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzi_);
            CqlDateTime nzzu_ = context.Operators.Start(nzzt_);
            bool? nzzv_ = context.Operators.Not((bool?)(nzzu_ is null));
            bool? nzzw_ = context.Operators.And(nzzr_, nzzv_);
            bool? nzzx_ = context.Operators.And(nzze_, nzzw_);

            return nzzx_;
        };
        IEnumerable<Encounter> mzzx_ = context.Operators.Where<Encounter>(mzzv_, mzzw_);
        object mzzy_(Encounter @this)
        {
            Period nzzy_ = @this?.Period;
            CqlInterval<CqlDateTime> nzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzy_);
            CqlDateTime ozza_ = context.Operators.End(nzzz_);

            return ozza_;
        };
        IEnumerable<Encounter> mzzz_ = context.Operators.SortBy<Encounter>(mzzx_, mzzy_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter nzza_ = context.Operators.Last<Encounter>(mzzz_);

        return nzza_;
    }


    [CqlExpressionDefinition("edVisit")]
    [CqlTag("description", "Returns the most recent emergency department visit, if any, that occurs 1 hour or less prior to the given encounter.")]
    public Encounter edVisit(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet ozzb_ = this.Emergency_Department_Visit(context);
        IEnumerable<Encounter> ozzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? ozzd_(Encounter EDVisit)
        {
            Code<Encounter.EncounterStatus> ozzi_ = EDVisit?.StatusElement;
            Encounter.EncounterStatus? ozzj_ = ozzi_?.Value;
            Code<Encounter.EncounterStatus> ozzk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ozzj_);
            bool? ozzl_ = context.Operators.Equal(ozzk_, "finished");
            Period ozzm_ = EDVisit?.Period;
            CqlInterval<CqlDateTime> ozzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzm_);
            CqlDateTime ozzo_ = context.Operators.End(ozzn_);
            Period ozzp_ = TheEncounter?.Period;
            CqlInterval<CqlDateTime> ozzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzp_);
            CqlDateTime ozzr_ = context.Operators.Start(ozzq_);
            CqlQuantity ozzs_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime ozzt_ = context.Operators.Subtract(ozzr_, ozzs_);
            CqlInterval<CqlDateTime> ozzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzp_);
            CqlDateTime ozzw_ = context.Operators.Start(ozzv_);
            CqlInterval<CqlDateTime> ozzx_ = context.Operators.Interval(ozzt_, ozzw_, true, true);
            bool? ozzy_ = context.Operators.In<CqlDateTime>(ozzo_, ozzx_, default);
            CqlInterval<CqlDateTime> pzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzp_);
            CqlDateTime pzzb_ = context.Operators.Start(pzza_);
            bool? pzzc_ = context.Operators.Not((bool?)(pzzb_ is null));
            bool? pzzd_ = context.Operators.And(ozzy_, pzzc_);
            bool? pzze_ = context.Operators.And(ozzl_, pzzd_);

            return pzze_;
        };
        IEnumerable<Encounter> ozze_ = context.Operators.Where<Encounter>(ozzc_, ozzd_);
        object ozzf_(Encounter @this)
        {
            Period pzzf_ = @this?.Period;
            CqlInterval<CqlDateTime> pzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzf_);
            CqlDateTime pzzh_ = context.Operators.End(pzzg_);

            return pzzh_;
        };
        IEnumerable<Encounter> ozzg_ = context.Operators.SortBy<Encounter>(ozze_, ozzf_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter ozzh_ = context.Operators.Last<Encounter>(ozzg_);

        return ozzh_;
    }


    [CqlExpressionDefinition("Hospitalization")]
    [CqlTag("description", "Hospitalization returns the total interval for admission to discharge for the given encounter, or for the admission of any immediately prior emergency department visit to the discharge of the given encounter.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalization()` instead.")]
    public CqlInterval<CqlDateTime> Hospitalization(CqlContext context, Encounter TheEncounter)
    {
        Encounter pzzi_ = this.ED_Visit(context, TheEncounter);
        Encounter[] pzzj_ = [
            pzzi_,
        ];
        CqlInterval<CqlDateTime> pzzk_(Encounter X)
        {
            CqlInterval<CqlDateTime> pzzo_()
            {
                if (X is null)
                {
                    Period pzzp_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> pzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzp_);

                    return pzzq_;
                }
                else
                {
                    Period pzzr_ = X?.Period;
                    CqlInterval<CqlDateTime> pzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzr_);
                    CqlDateTime pzzt_ = context.Operators.Start(pzzs_);
                    Period pzzu_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> pzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzu_);
                    CqlDateTime pzzw_ = context.Operators.End(pzzv_);
                    CqlInterval<CqlDateTime> pzzx_ = context.Operators.Interval(pzzt_, pzzw_, true, false);

                    return pzzx_;
                }
            };

            return pzzo_();
        };
        IEnumerable<CqlInterval<CqlDateTime>> pzzl_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)pzzj_, pzzk_);
        IEnumerable<CqlInterval<CqlDateTime>> pzzm_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(pzzl_);
        CqlInterval<CqlDateTime> pzzn_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(pzzm_);

        return pzzn_;
    }


    [CqlExpressionDefinition("hospitalization")]
    [CqlTag("description", "Hospitalization returns the total interval for admission to discharge for the given encounter, or for the admission of any immediately prior emergency department visit to the discharge of the given encounter.")]
    public CqlInterval<CqlDateTime> hospitalization(CqlContext context, Encounter TheEncounter)
    {
        Encounter pzzy_ = this.edVisit(context, TheEncounter);
        Encounter[] pzzz_ = [
            pzzy_,
        ];
        CqlInterval<CqlDateTime> qzza_(Encounter X)
        {
            CqlInterval<CqlDateTime> qzze_()
            {
                if (X is null)
                {
                    Period qzzf_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> qzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzf_);

                    return qzzg_;
                }
                else
                {
                    Period qzzh_ = X?.Period;
                    CqlInterval<CqlDateTime> qzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzh_);
                    CqlDateTime qzzj_ = context.Operators.Start(qzzi_);
                    Period qzzk_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> qzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzk_);
                    CqlDateTime qzzm_ = context.Operators.End(qzzl_);
                    CqlInterval<CqlDateTime> qzzn_ = context.Operators.Interval(qzzj_, qzzm_, true, true);

                    return qzzn_;
                }
            };

            return qzze_();
        };
        IEnumerable<CqlInterval<CqlDateTime>> qzzb_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)pzzz_, qzza_);
        IEnumerable<CqlInterval<CqlDateTime>> qzzc_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(qzzb_);
        CqlInterval<CqlDateTime> qzzd_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(qzzc_);

        return qzzd_;
    }


    [CqlExpressionDefinition("Hospitalization Locations")]
    [CqlTag("description", "Returns list of all locations within an encounter, including locations for immediately prior ED visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationLocations()` instead.")]
    public IEnumerable<Encounter.LocationComponent> Hospitalization_Locations(CqlContext context, Encounter TheEncounter)
    {
        Encounter qzzo_ = this.ED_Visit(context, TheEncounter);
        Encounter[] qzzp_ = [
            qzzo_,
        ];
        IEnumerable<Encounter.LocationComponent> qzzq_(Encounter EDEncounter)
        {
            IEnumerable<Encounter.LocationComponent> qzzu_()
            {
                if (EDEncounter is null)
                {
                    List<Encounter.LocationComponent> qzzv_ = TheEncounter?.Location;

                    return (IEnumerable<Encounter.LocationComponent>)qzzv_;
                }
                else
                {
                    List<Encounter.LocationComponent> qzzw_ = EDEncounter?.Location;
                    List<Encounter.LocationComponent> qzzx_ = TheEncounter?.Location;
                    IEnumerable<Encounter.LocationComponent>[] qzzy_ = [
                        (IEnumerable<Encounter.LocationComponent>)qzzw_,
                        (IEnumerable<Encounter.LocationComponent>)qzzx_,
                    ];
                    IEnumerable<Encounter.LocationComponent> qzzz_ = context.Operators.Flatten<Encounter.LocationComponent>(qzzy_ as IEnumerable<IEnumerable<Encounter.LocationComponent>>);

                    return qzzz_;
                }
            };

            return qzzu_();
        };
        IEnumerable<IEnumerable<Encounter.LocationComponent>> qzzr_ = context.Operators.Select<Encounter, IEnumerable<Encounter.LocationComponent>>((IEnumerable<Encounter>)qzzp_, qzzq_);
        IEnumerable<IEnumerable<Encounter.LocationComponent>> qzzs_ = context.Operators.Distinct<IEnumerable<Encounter.LocationComponent>>(qzzr_);
        IEnumerable<Encounter.LocationComponent> qzzt_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(qzzs_);

        return qzzt_;
    }


    [CqlExpressionDefinition("hospitalizationLocations")]
    [CqlTag("description", "Returns list of all locations within an encounter, including locations for immediately prior ED visit.")]
    public IEnumerable<Encounter.LocationComponent> hospitalizationLocations(CqlContext context, Encounter TheEncounter)
    {
        Encounter rzza_ = this.edVisit(context, TheEncounter);
        Encounter[] rzzb_ = [
            rzza_,
        ];
        IEnumerable<Encounter.LocationComponent> rzzc_(Encounter EDEncounter)
        {
            IEnumerable<Encounter.LocationComponent> rzzg_()
            {
                if (EDEncounter is null)
                {
                    List<Encounter.LocationComponent> rzzh_ = TheEncounter?.Location;

                    return (IEnumerable<Encounter.LocationComponent>)rzzh_;
                }
                else
                {
                    List<Encounter.LocationComponent> rzzi_ = EDEncounter?.Location;
                    List<Encounter.LocationComponent> rzzj_ = TheEncounter?.Location;
                    IEnumerable<Encounter.LocationComponent>[] rzzk_ = [
                        (IEnumerable<Encounter.LocationComponent>)rzzi_,
                        (IEnumerable<Encounter.LocationComponent>)rzzj_,
                    ];
                    IEnumerable<Encounter.LocationComponent> rzzl_ = context.Operators.Flatten<Encounter.LocationComponent>(rzzk_ as IEnumerable<IEnumerable<Encounter.LocationComponent>>);

                    return rzzl_;
                }
            };

            return rzzg_();
        };
        IEnumerable<IEnumerable<Encounter.LocationComponent>> rzzd_ = context.Operators.Select<Encounter, IEnumerable<Encounter.LocationComponent>>((IEnumerable<Encounter>)rzzb_, rzzc_);
        IEnumerable<IEnumerable<Encounter.LocationComponent>> rzze_ = context.Operators.Distinct<IEnumerable<Encounter.LocationComponent>>(rzzd_);
        IEnumerable<Encounter.LocationComponent> rzzf_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(rzze_);

        return rzzf_;
    }


    [CqlExpressionDefinition("Hospitalization Length of Stay")]
    [CqlTag("description", "Returns the length of stay in days (i.e. the number of days between admission and discharge) for the given encounter, or from the admission of any immediately prior emergency department visit to the discharge of the encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationLengthOfStay()` instead.")]
    public int? Hospitalization_Length_of_Stay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> rzzm_ = this.Hospitalization(context, TheEncounter);
        int? rzzn_ = this.LengthInDays(context, rzzm_);

        return rzzn_;
    }


    [CqlExpressionDefinition("hospitalizationLengthOfStay")]
    [CqlTag("description", "Returns the length of stay in days (i.e. the number of days between admission and discharge) for the given encounter, or from the admission of any immediately prior emergency department visit to the discharge of the encounter")]
    public int? hospitalizationLengthOfStay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> rzzo_ = this.hospitalization(context, TheEncounter);
        int? rzzp_ = this.lengthInDays(context, rzzo_);

        return rzzp_;
    }


    [CqlExpressionDefinition("Hospital Admission Time")]
    [CqlTag("description", "Returns admission time for an encounter or for immediately prior emergency department visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalAdmissionTime()` instead.")]
    public CqlDateTime Hospital_Admission_Time(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> rzzq_ = this.Hospitalization(context, TheEncounter);
        CqlDateTime rzzr_ = context.Operators.Start(rzzq_);

        return rzzr_;
    }


    [CqlExpressionDefinition("hospitalAdmissionTime")]
    [CqlTag("description", "Returns admission time for an encounter or for immediately prior emergency department visit.")]
    public CqlDateTime hospitalAdmissionTime(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> rzzs_ = this.hospitalization(context, TheEncounter);
        CqlDateTime rzzt_ = context.Operators.Start(rzzs_);

        return rzzt_;
    }


    [CqlExpressionDefinition("Hospital Discharge Time")]
    [CqlTag("description", "Hospital Discharge Time returns the discharge time for an encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalDischargeTime()` instead.")]
    public CqlDateTime Hospital_Discharge_Time(CqlContext context, Encounter TheEncounter)
    {
        Period rzzu_ = TheEncounter?.Period;
        CqlInterval<CqlDateTime> rzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzu_);
        CqlDateTime rzzw_ = context.Operators.End(rzzv_);

        return rzzw_;
    }


    [CqlExpressionDefinition("hospitalDischargeTime")]
    [CqlTag("description", "Hospital Discharge Time returns the discharge time for an encounter")]
    public CqlDateTime hospitalDischargeTime(CqlContext context, Encounter TheEncounter)
    {
        Period rzzx_ = TheEncounter?.Period;
        CqlInterval<CqlDateTime> rzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzx_);
        CqlDateTime rzzz_ = context.Operators.End(rzzy_);

        return rzzz_;
    }


    [CqlExpressionDefinition("Hospital Arrival Time")]
    [CqlTag("description", "Returns earliest arrival time for an encounter including any prior ED visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalArrivalTime()` instead.")]
    public CqlDateTime Hospital_Arrival_Time(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> szza_ = this.Hospitalization_Locations(context, TheEncounter);
        object szzb_(Encounter.LocationComponent @this)
        {
            Period szzh_ = @this?.Period;
            CqlInterval<CqlDateTime> szzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzh_);
            CqlDateTime szzj_ = context.Operators.Start(szzi_);

            return szzj_;
        };
        IEnumerable<Encounter.LocationComponent> szzc_ = context.Operators.SortBy<Encounter.LocationComponent>(szza_, szzb_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent szzd_ = context.Operators.First<Encounter.LocationComponent>(szzc_);
        Period szze_ = szzd_?.Period;
        CqlInterval<CqlDateTime> szzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szze_);
        CqlDateTime szzg_ = context.Operators.Start(szzf_);

        return szzg_;
    }


    [CqlExpressionDefinition("hospitalArrivalTime")]
    [CqlTag("description", "Returns earliest arrival time for an encounter including any prior ED visit.")]
    public CqlDateTime hospitalArrivalTime(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> szzk_ = this.hospitalizationLocations(context, TheEncounter);
        object szzl_(Encounter.LocationComponent @this)
        {
            Period szzr_ = @this?.Period;
            CqlInterval<CqlDateTime> szzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzr_);
            CqlDateTime szzt_ = context.Operators.Start(szzs_);

            return szzt_;
        };
        IEnumerable<Encounter.LocationComponent> szzm_ = context.Operators.SortBy<Encounter.LocationComponent>(szzk_, szzl_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent szzn_ = context.Operators.First<Encounter.LocationComponent>(szzm_);
        Period szzo_ = szzn_?.Period;
        CqlInterval<CqlDateTime> szzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzo_);
        CqlDateTime szzq_ = context.Operators.Start(szzp_);

        return szzq_;
    }


    [CqlExpressionDefinition("Hospital Departure Time")]
    [CqlTag("description", "Returns the latest departure time for encounter including any prior ED visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalDepartureTime()` instead.")]
    public CqlDateTime Hospital_Departure_Time(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> szzu_ = this.Hospitalization_Locations(context, TheEncounter);
        object szzv_(Encounter.LocationComponent @this)
        {
            Period tzzb_ = @this?.Period;
            CqlInterval<CqlDateTime> tzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzb_);
            CqlDateTime tzzd_ = context.Operators.Start(tzzc_);

            return tzzd_;
        };
        IEnumerable<Encounter.LocationComponent> szzw_ = context.Operators.SortBy<Encounter.LocationComponent>(szzu_, szzv_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent szzx_ = context.Operators.Last<Encounter.LocationComponent>(szzw_);
        Period szzy_ = szzx_?.Period;
        CqlInterval<CqlDateTime> szzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzy_);
        CqlDateTime tzza_ = context.Operators.End(szzz_);

        return tzza_;
    }


    [CqlExpressionDefinition("hospitalDepartureTime")]
    [CqlTag("description", "Returns the latest departure time for encounter including any prior ED visit.")]
    public CqlDateTime hospitalDepartureTime(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> tzze_ = this.hospitalizationLocations(context, TheEncounter);
        object tzzf_(Encounter.LocationComponent @this)
        {
            Period tzzl_ = @this?.Period;
            CqlInterval<CqlDateTime> tzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzl_);
            CqlDateTime tzzn_ = context.Operators.Start(tzzm_);

            return tzzn_;
        };
        IEnumerable<Encounter.LocationComponent> tzzg_ = context.Operators.SortBy<Encounter.LocationComponent>(tzze_, tzzf_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent tzzh_ = context.Operators.Last<Encounter.LocationComponent>(tzzg_);
        Period tzzi_ = tzzh_?.Period;
        CqlInterval<CqlDateTime> tzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzi_);
        CqlDateTime tzzk_ = context.Operators.End(tzzj_);

        return tzzk_;
    }


    [CqlExpressionDefinition("GetLocation")]
    [CqlTag("description", "Returns the Location resource specified by the given reference")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getLocation()` instead.")]
    public Location GetLocation(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Location> tzzo_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-location"));
        bool? tzzp_(Location L)
        {
            Id tzzs_ = L?.IdElement;
            string tzzt_ = tzzs_?.Value;
            FhirString tzzu_ = reference?.ReferenceElement;
            string tzzv_ = tzzu_?.Value;
            string tzzw_ = QICoreCommon_2_1_000.Instance.getId(context, tzzv_);
            bool? tzzx_ = context.Operators.Equal(tzzt_, tzzw_);

            return tzzx_;
        };
        IEnumerable<Location> tzzq_ = context.Operators.Where<Location>(tzzo_, tzzp_);
        Location tzzr_ = context.Operators.SingletonFrom<Location>(tzzq_);

        return tzzr_;
    }


    [CqlExpressionDefinition("Emergency Department Arrival Time")]
    [CqlTag("description", "Returns the emergency department arrival time for the encounter.")]
    public CqlDateTime Emergency_Department_Arrival_Time(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> tzzy_ = this.Hospitalization_Locations(context, TheEncounter);
        bool? tzzz_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference uzzf_ = HospitalLocation?.Location;
            Location uzzg_ = this.GetLocation(context, uzzf_);
            List<CodeableConcept> uzzh_ = uzzg_?.Type;
            CqlConcept uzzi_(CodeableConcept @this)
            {
                CqlConcept uzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return uzzm_;
            };
            IEnumerable<CqlConcept> uzzj_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)uzzh_, uzzi_);
            CqlValueSet uzzk_ = this.Emergency_Department_Visit(context);
            bool? uzzl_ = context.Operators.ConceptsInValueSet(uzzj_, uzzk_);

            return uzzl_;
        };
        IEnumerable<Encounter.LocationComponent> uzza_ = context.Operators.Where<Encounter.LocationComponent>(tzzy_, tzzz_);
        Encounter.LocationComponent uzzb_ = context.Operators.SingletonFrom<Encounter.LocationComponent>(uzza_);
        Period uzzc_ = uzzb_?.Period;
        CqlInterval<CqlDateTime> uzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzc_);
        CqlDateTime uzze_ = context.Operators.Start(uzzd_);

        return uzze_;
    }


    [CqlExpressionDefinition("emergencyDepartmentArrivalTime")]
    [CqlTag("description", "Returns the emergency department arrival time for the encounter.")]
    public CqlDateTime emergencyDepartmentArrivalTime(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> uzzn_ = this.hospitalizationLocations(context, TheEncounter);
        bool? uzzo_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference uzzu_ = HospitalLocation?.Location;
            Location uzzv_ = this.GetLocation(context, uzzu_);
            List<CodeableConcept> uzzw_ = uzzv_?.Type;
            CqlConcept uzzx_(CodeableConcept @this)
            {
                CqlConcept vzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return vzzb_;
            };
            IEnumerable<CqlConcept> uzzy_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)uzzw_, uzzx_);
            CqlValueSet uzzz_ = this.Emergency_Department_Visit(context);
            bool? vzza_ = context.Operators.ConceptsInValueSet(uzzy_, uzzz_);

            return vzza_;
        };
        IEnumerable<Encounter.LocationComponent> uzzp_ = context.Operators.Where<Encounter.LocationComponent>(uzzn_, uzzo_);
        Encounter.LocationComponent uzzq_ = context.Operators.SingletonFrom<Encounter.LocationComponent>(uzzp_);
        Period uzzr_ = uzzq_?.Period;
        CqlInterval<CqlDateTime> uzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzr_);
        CqlDateTime uzzt_ = context.Operators.Start(uzzs_);

        return uzzt_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservationAndOutpatientSurgeryService")]
    [CqlTag("description", "Hospitalization with Observation and Outpatient Surgery Service returns the total interval from the start of any immediately prior emergency department visit, outpatient surgery visit or observation visit to the discharge of the given encounter.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationWithObservationAndOutpatientSurgeryService()` instead.")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservationAndOutpatientSurgeryService(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] vzzc_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> vzzd_(Encounter Visit)
        {
            CqlValueSet vzzh_ = this.Outpatient_Surgery_Service(context);
            IEnumerable<Encounter> vzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? vzzj_(Encounter LastSurgeryOP)
            {
                Period wzzs_ = LastSurgeryOP?.Period;
                CqlInterval<CqlDateTime> wzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzs_);
                CqlDateTime wzzu_ = context.Operators.End(wzzt_);
                CqlValueSet wzzv_ = this.Emergency_Department_Visit(context);
                IEnumerable<Encounter> wzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? wzzx_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> zzzs_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? zzzt_ = zzzs_?.Value;
                    Code<Encounter.EncounterStatus> zzzu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(zzzt_);
                    bool? zzzv_ = context.Operators.Equal(zzzu_, "finished");
                    Period zzzw_ = LastED?.Period;
                    CqlInterval<CqlDateTime> zzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzw_);
                    CqlDateTime zzzy_ = context.Operators.End(zzzx_);
                    CqlValueSet zzzz_ = this.Observation_Services(context);
                    IEnumerable<Encounter> azzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? azzzb_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> bzzzt_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? bzzzu_ = bzzzt_?.Value;
                        Code<Encounter.EncounterStatus> bzzzv_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bzzzu_);
                        bool? bzzzw_ = context.Operators.Equal(bzzzv_, "finished");
                        Period bzzzx_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> bzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzx_);
                        CqlDateTime bzzzz_ = context.Operators.End(bzzzy_);
                        Period czzza_ = Visit?.Period;
                        CqlInterval<CqlDateTime> czzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzza_);
                        CqlDateTime czzzc_ = context.Operators.Start(czzzb_);
                        CqlQuantity czzzd_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime czzze_ = context.Operators.Subtract(czzzc_, czzzd_);
                        CqlInterval<CqlDateTime> czzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzza_);
                        CqlDateTime czzzh_ = context.Operators.Start(czzzg_);
                        CqlInterval<CqlDateTime> czzzi_ = context.Operators.Interval(czzze_, czzzh_, true, true);
                        bool? czzzj_ = context.Operators.In<CqlDateTime>(bzzzz_, czzzi_, default);
                        CqlInterval<CqlDateTime> czzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzza_);
                        CqlDateTime czzzm_ = context.Operators.Start(czzzl_);
                        bool? czzzn_ = context.Operators.Not((bool?)(czzzm_ is null));
                        bool? czzzo_ = context.Operators.And(czzzj_, czzzn_);
                        bool? czzzp_ = context.Operators.And(bzzzw_, czzzo_);

                        return czzzp_;
                    };
                    IEnumerable<Encounter> azzzc_ = context.Operators.Where<Encounter>(azzza_, azzzb_);
                    object azzzd_(Encounter @this)
                    {
                        Period czzzq_ = @this?.Period;
                        CqlInterval<CqlDateTime> czzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzq_);
                        CqlDateTime czzzs_ = context.Operators.End(czzzr_);

                        return czzzs_;
                    };
                    IEnumerable<Encounter> azzze_ = context.Operators.SortBy<Encounter>(azzzc_, azzzd_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter azzzf_ = context.Operators.Last<Encounter>(azzze_);
                    Period azzzg_ = azzzf_?.Period;
                    CqlInterval<CqlDateTime> azzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzg_);
                    CqlDateTime azzzi_ = context.Operators.Start(azzzh_);
                    Period azzzj_ = Visit?.Period;
                    CqlInterval<CqlDateTime> azzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzj_);
                    CqlDateTime azzzl_ = context.Operators.Start(azzzk_);
                    CqlQuantity azzzm_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime azzzn_ = context.Operators.Subtract(azzzi_ ?? azzzl_, azzzm_);
                    IEnumerable<Encounter> azzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? azzzq_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> czzzt_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? czzzu_ = czzzt_?.Value;
                        Code<Encounter.EncounterStatus> czzzv_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(czzzu_);
                        bool? czzzw_ = context.Operators.Equal(czzzv_, "finished");
                        Period czzzx_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> czzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzx_);
                        CqlDateTime czzzz_ = context.Operators.End(czzzy_);
                        Period dzzza_ = Visit?.Period;
                        CqlInterval<CqlDateTime> dzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzza_);
                        CqlDateTime dzzzc_ = context.Operators.Start(dzzzb_);
                        CqlQuantity dzzzd_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime dzzze_ = context.Operators.Subtract(dzzzc_, dzzzd_);
                        CqlInterval<CqlDateTime> dzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzza_);
                        CqlDateTime dzzzh_ = context.Operators.Start(dzzzg_);
                        CqlInterval<CqlDateTime> dzzzi_ = context.Operators.Interval(dzzze_, dzzzh_, true, true);
                        bool? dzzzj_ = context.Operators.In<CqlDateTime>(czzzz_, dzzzi_, default);
                        CqlInterval<CqlDateTime> dzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzza_);
                        CqlDateTime dzzzm_ = context.Operators.Start(dzzzl_);
                        bool? dzzzn_ = context.Operators.Not((bool?)(dzzzm_ is null));
                        bool? dzzzo_ = context.Operators.And(dzzzj_, dzzzn_);
                        bool? dzzzp_ = context.Operators.And(czzzw_, dzzzo_);

                        return dzzzp_;
                    };
                    IEnumerable<Encounter> azzzr_ = context.Operators.Where<Encounter>(azzzp_, azzzq_);
                    object azzzs_(Encounter @this)
                    {
                        Period dzzzq_ = @this?.Period;
                        CqlInterval<CqlDateTime> dzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzq_);
                        CqlDateTime dzzzs_ = context.Operators.End(dzzzr_);

                        return dzzzs_;
                    };
                    IEnumerable<Encounter> azzzt_ = context.Operators.SortBy<Encounter>(azzzr_, azzzs_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter azzzu_ = context.Operators.Last<Encounter>(azzzt_);
                    Period azzzv_ = azzzu_?.Period;
                    CqlInterval<CqlDateTime> azzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzv_);
                    CqlDateTime azzzx_ = context.Operators.Start(azzzw_);
                    CqlInterval<CqlDateTime> azzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzj_);
                    CqlDateTime bzzza_ = context.Operators.Start(azzzz_);
                    CqlInterval<CqlDateTime> bzzzb_ = context.Operators.Interval(azzzn_, azzzx_ ?? bzzza_, true, true);
                    bool? bzzzc_ = context.Operators.In<CqlDateTime>(zzzy_, bzzzb_, default);
                    IEnumerable<Encounter> bzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? bzzzf_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> dzzzt_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? dzzzu_ = dzzzt_?.Value;
                        Code<Encounter.EncounterStatus> dzzzv_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dzzzu_);
                        bool? dzzzw_ = context.Operators.Equal(dzzzv_, "finished");
                        Period dzzzx_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> dzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzx_);
                        CqlDateTime dzzzz_ = context.Operators.End(dzzzy_);
                        Period ezzza_ = Visit?.Period;
                        CqlInterval<CqlDateTime> ezzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzza_);
                        CqlDateTime ezzzc_ = context.Operators.Start(ezzzb_);
                        CqlQuantity ezzzd_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime ezzze_ = context.Operators.Subtract(ezzzc_, ezzzd_);
                        CqlInterval<CqlDateTime> ezzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzza_);
                        CqlDateTime ezzzh_ = context.Operators.Start(ezzzg_);
                        CqlInterval<CqlDateTime> ezzzi_ = context.Operators.Interval(ezzze_, ezzzh_, true, true);
                        bool? ezzzj_ = context.Operators.In<CqlDateTime>(dzzzz_, ezzzi_, default);
                        CqlInterval<CqlDateTime> ezzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzza_);
                        CqlDateTime ezzzm_ = context.Operators.Start(ezzzl_);
                        bool? ezzzn_ = context.Operators.Not((bool?)(ezzzm_ is null));
                        bool? ezzzo_ = context.Operators.And(ezzzj_, ezzzn_);
                        bool? ezzzp_ = context.Operators.And(dzzzw_, ezzzo_);

                        return ezzzp_;
                    };
                    IEnumerable<Encounter> bzzzg_ = context.Operators.Where<Encounter>(bzzze_, bzzzf_);
                    object bzzzh_(Encounter @this)
                    {
                        Period ezzzq_ = @this?.Period;
                        CqlInterval<CqlDateTime> ezzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzq_);
                        CqlDateTime ezzzs_ = context.Operators.End(ezzzr_);

                        return ezzzs_;
                    };
                    IEnumerable<Encounter> bzzzi_ = context.Operators.SortBy<Encounter>(bzzzg_, bzzzh_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter bzzzj_ = context.Operators.Last<Encounter>(bzzzi_);
                    Period bzzzk_ = bzzzj_?.Period;
                    CqlInterval<CqlDateTime> bzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzk_);
                    CqlDateTime bzzzm_ = context.Operators.Start(bzzzl_);
                    CqlInterval<CqlDateTime> bzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzj_);
                    CqlDateTime bzzzp_ = context.Operators.Start(bzzzo_);
                    bool? bzzzq_ = context.Operators.Not((bool?)((bzzzm_ ?? bzzzp_) is null));
                    bool? bzzzr_ = context.Operators.And(bzzzc_, bzzzq_);
                    bool? bzzzs_ = context.Operators.And(zzzv_, bzzzr_);

                    return bzzzs_;
                };
                IEnumerable<Encounter> wzzy_ = context.Operators.Where<Encounter>(wzzw_, wzzx_);
                object wzzz_(Encounter @this)
                {
                    Period ezzzt_ = @this?.Period;
                    CqlInterval<CqlDateTime> ezzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzt_);
                    CqlDateTime ezzzv_ = context.Operators.End(ezzzu_);

                    return ezzzv_;
                };
                IEnumerable<Encounter> xzza_ = context.Operators.SortBy<Encounter>(wzzy_, wzzz_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter xzzb_ = context.Operators.Last<Encounter>(xzza_);
                Period xzzc_ = xzzb_?.Period;
                CqlInterval<CqlDateTime> xzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzc_);
                CqlDateTime xzze_ = context.Operators.Start(xzzd_);
                CqlValueSet xzzf_ = this.Observation_Services(context);
                IEnumerable<Encounter> xzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? xzzh_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> ezzzw_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? ezzzx_ = ezzzw_?.Value;
                    Code<Encounter.EncounterStatus> ezzzy_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ezzzx_);
                    bool? ezzzz_ = context.Operators.Equal(ezzzy_, "finished");
                    Period fzzza_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> fzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzza_);
                    CqlDateTime fzzzc_ = context.Operators.End(fzzzb_);
                    Period fzzzd_ = Visit?.Period;
                    CqlInterval<CqlDateTime> fzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzd_);
                    CqlDateTime fzzzf_ = context.Operators.Start(fzzze_);
                    CqlQuantity fzzzg_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime fzzzh_ = context.Operators.Subtract(fzzzf_, fzzzg_);
                    CqlInterval<CqlDateTime> fzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzd_);
                    CqlDateTime fzzzk_ = context.Operators.Start(fzzzj_);
                    CqlInterval<CqlDateTime> fzzzl_ = context.Operators.Interval(fzzzh_, fzzzk_, true, true);
                    bool? fzzzm_ = context.Operators.In<CqlDateTime>(fzzzc_, fzzzl_, default);
                    CqlInterval<CqlDateTime> fzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzd_);
                    CqlDateTime fzzzp_ = context.Operators.Start(fzzzo_);
                    bool? fzzzq_ = context.Operators.Not((bool?)(fzzzp_ is null));
                    bool? fzzzr_ = context.Operators.And(fzzzm_, fzzzq_);
                    bool? fzzzs_ = context.Operators.And(ezzzz_, fzzzr_);

                    return fzzzs_;
                };
                IEnumerable<Encounter> xzzi_ = context.Operators.Where<Encounter>(xzzg_, xzzh_);
                object xzzj_(Encounter @this)
                {
                    Period fzzzt_ = @this?.Period;
                    CqlInterval<CqlDateTime> fzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzt_);
                    CqlDateTime fzzzv_ = context.Operators.End(fzzzu_);

                    return fzzzv_;
                };
                IEnumerable<Encounter> xzzk_ = context.Operators.SortBy<Encounter>(xzzi_, xzzj_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter xzzl_ = context.Operators.Last<Encounter>(xzzk_);
                Period xzzm_ = xzzl_?.Period;
                CqlInterval<CqlDateTime> xzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzm_);
                CqlDateTime xzzo_ = context.Operators.Start(xzzn_);
                Period xzzp_ = Visit?.Period;
                CqlInterval<CqlDateTime> xzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzp_);
                CqlDateTime xzzr_ = context.Operators.Start(xzzq_);
                CqlQuantity xzzs_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime xzzt_ = context.Operators.Subtract(xzze_ ?? xzzo_ ?? xzzr_, xzzs_);
                IEnumerable<Encounter> xzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? xzzw_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> fzzzw_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? fzzzx_ = fzzzw_?.Value;
                    Code<Encounter.EncounterStatus> fzzzy_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fzzzx_);
                    bool? fzzzz_ = context.Operators.Equal(fzzzy_, "finished");
                    Period gzzza_ = LastED?.Period;
                    CqlInterval<CqlDateTime> gzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzza_);
                    CqlDateTime gzzzc_ = context.Operators.End(gzzzb_);
                    CqlValueSet gzzzd_ = this.Observation_Services(context);
                    IEnumerable<Encounter> gzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? gzzzf_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> hzzzx_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? hzzzy_ = hzzzx_?.Value;
                        Code<Encounter.EncounterStatus> hzzzz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hzzzy_);
                        bool? izzza_ = context.Operators.Equal(hzzzz_, "finished");
                        Period izzzb_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> izzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzb_);
                        CqlDateTime izzzd_ = context.Operators.End(izzzc_);
                        Period izzze_ = Visit?.Period;
                        CqlInterval<CqlDateTime> izzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzze_);
                        CqlDateTime izzzg_ = context.Operators.Start(izzzf_);
                        CqlQuantity izzzh_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime izzzi_ = context.Operators.Subtract(izzzg_, izzzh_);
                        CqlInterval<CqlDateTime> izzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzze_);
                        CqlDateTime izzzl_ = context.Operators.Start(izzzk_);
                        CqlInterval<CqlDateTime> izzzm_ = context.Operators.Interval(izzzi_, izzzl_, true, true);
                        bool? izzzn_ = context.Operators.In<CqlDateTime>(izzzd_, izzzm_, default);
                        CqlInterval<CqlDateTime> izzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzze_);
                        CqlDateTime izzzq_ = context.Operators.Start(izzzp_);
                        bool? izzzr_ = context.Operators.Not((bool?)(izzzq_ is null));
                        bool? izzzs_ = context.Operators.And(izzzn_, izzzr_);
                        bool? izzzt_ = context.Operators.And(izzza_, izzzs_);

                        return izzzt_;
                    };
                    IEnumerable<Encounter> gzzzg_ = context.Operators.Where<Encounter>(gzzze_, gzzzf_);
                    object gzzzh_(Encounter @this)
                    {
                        Period izzzu_ = @this?.Period;
                        CqlInterval<CqlDateTime> izzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzu_);
                        CqlDateTime izzzw_ = context.Operators.End(izzzv_);

                        return izzzw_;
                    };
                    IEnumerable<Encounter> gzzzi_ = context.Operators.SortBy<Encounter>(gzzzg_, gzzzh_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter gzzzj_ = context.Operators.Last<Encounter>(gzzzi_);
                    Period gzzzk_ = gzzzj_?.Period;
                    CqlInterval<CqlDateTime> gzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzk_);
                    CqlDateTime gzzzm_ = context.Operators.Start(gzzzl_);
                    Period gzzzn_ = Visit?.Period;
                    CqlInterval<CqlDateTime> gzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzn_);
                    CqlDateTime gzzzp_ = context.Operators.Start(gzzzo_);
                    CqlQuantity gzzzq_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime gzzzr_ = context.Operators.Subtract(gzzzm_ ?? gzzzp_, gzzzq_);
                    IEnumerable<Encounter> gzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? gzzzu_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> izzzx_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? izzzy_ = izzzx_?.Value;
                        Code<Encounter.EncounterStatus> izzzz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(izzzy_);
                        bool? jzzza_ = context.Operators.Equal(izzzz_, "finished");
                        Period jzzzb_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> jzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzb_);
                        CqlDateTime jzzzd_ = context.Operators.End(jzzzc_);
                        Period jzzze_ = Visit?.Period;
                        CqlInterval<CqlDateTime> jzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzze_);
                        CqlDateTime jzzzg_ = context.Operators.Start(jzzzf_);
                        CqlQuantity jzzzh_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime jzzzi_ = context.Operators.Subtract(jzzzg_, jzzzh_);
                        CqlInterval<CqlDateTime> jzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzze_);
                        CqlDateTime jzzzl_ = context.Operators.Start(jzzzk_);
                        CqlInterval<CqlDateTime> jzzzm_ = context.Operators.Interval(jzzzi_, jzzzl_, true, true);
                        bool? jzzzn_ = context.Operators.In<CqlDateTime>(jzzzd_, jzzzm_, default);
                        CqlInterval<CqlDateTime> jzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzze_);
                        CqlDateTime jzzzq_ = context.Operators.Start(jzzzp_);
                        bool? jzzzr_ = context.Operators.Not((bool?)(jzzzq_ is null));
                        bool? jzzzs_ = context.Operators.And(jzzzn_, jzzzr_);
                        bool? jzzzt_ = context.Operators.And(jzzza_, jzzzs_);

                        return jzzzt_;
                    };
                    IEnumerable<Encounter> gzzzv_ = context.Operators.Where<Encounter>(gzzzt_, gzzzu_);
                    object gzzzw_(Encounter @this)
                    {
                        Period jzzzu_ = @this?.Period;
                        CqlInterval<CqlDateTime> jzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzu_);
                        CqlDateTime jzzzw_ = context.Operators.End(jzzzv_);

                        return jzzzw_;
                    };
                    IEnumerable<Encounter> gzzzx_ = context.Operators.SortBy<Encounter>(gzzzv_, gzzzw_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter gzzzy_ = context.Operators.Last<Encounter>(gzzzx_);
                    Period gzzzz_ = gzzzy_?.Period;
                    CqlInterval<CqlDateTime> hzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzz_);
                    CqlDateTime hzzzb_ = context.Operators.Start(hzzza_);
                    CqlInterval<CqlDateTime> hzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzn_);
                    CqlDateTime hzzze_ = context.Operators.Start(hzzzd_);
                    CqlInterval<CqlDateTime> hzzzf_ = context.Operators.Interval(gzzzr_, hzzzb_ ?? hzzze_, true, true);
                    bool? hzzzg_ = context.Operators.In<CqlDateTime>(gzzzc_, hzzzf_, default);
                    IEnumerable<Encounter> hzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? hzzzj_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> jzzzx_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? jzzzy_ = jzzzx_?.Value;
                        Code<Encounter.EncounterStatus> jzzzz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jzzzy_);
                        bool? kzzza_ = context.Operators.Equal(jzzzz_, "finished");
                        Period kzzzb_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> kzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzb_);
                        CqlDateTime kzzzd_ = context.Operators.End(kzzzc_);
                        Period kzzze_ = Visit?.Period;
                        CqlInterval<CqlDateTime> kzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzze_);
                        CqlDateTime kzzzg_ = context.Operators.Start(kzzzf_);
                        CqlQuantity kzzzh_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime kzzzi_ = context.Operators.Subtract(kzzzg_, kzzzh_);
                        CqlInterval<CqlDateTime> kzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzze_);
                        CqlDateTime kzzzl_ = context.Operators.Start(kzzzk_);
                        CqlInterval<CqlDateTime> kzzzm_ = context.Operators.Interval(kzzzi_, kzzzl_, true, true);
                        bool? kzzzn_ = context.Operators.In<CqlDateTime>(kzzzd_, kzzzm_, default);
                        CqlInterval<CqlDateTime> kzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzze_);
                        CqlDateTime kzzzq_ = context.Operators.Start(kzzzp_);
                        bool? kzzzr_ = context.Operators.Not((bool?)(kzzzq_ is null));
                        bool? kzzzs_ = context.Operators.And(kzzzn_, kzzzr_);
                        bool? kzzzt_ = context.Operators.And(kzzza_, kzzzs_);

                        return kzzzt_;
                    };
                    IEnumerable<Encounter> hzzzk_ = context.Operators.Where<Encounter>(hzzzi_, hzzzj_);
                    object hzzzl_(Encounter @this)
                    {
                        Period kzzzu_ = @this?.Period;
                        CqlInterval<CqlDateTime> kzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzu_);
                        CqlDateTime kzzzw_ = context.Operators.End(kzzzv_);

                        return kzzzw_;
                    };
                    IEnumerable<Encounter> hzzzm_ = context.Operators.SortBy<Encounter>(hzzzk_, hzzzl_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter hzzzn_ = context.Operators.Last<Encounter>(hzzzm_);
                    Period hzzzo_ = hzzzn_?.Period;
                    CqlInterval<CqlDateTime> hzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzo_);
                    CqlDateTime hzzzq_ = context.Operators.Start(hzzzp_);
                    CqlInterval<CqlDateTime> hzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzn_);
                    CqlDateTime hzzzt_ = context.Operators.Start(hzzzs_);
                    bool? hzzzu_ = context.Operators.Not((bool?)((hzzzq_ ?? hzzzt_) is null));
                    bool? hzzzv_ = context.Operators.And(hzzzg_, hzzzu_);
                    bool? hzzzw_ = context.Operators.And(fzzzz_, hzzzv_);

                    return hzzzw_;
                };
                IEnumerable<Encounter> xzzx_ = context.Operators.Where<Encounter>(xzzv_, xzzw_);
                object xzzy_(Encounter @this)
                {
                    Period kzzzx_ = @this?.Period;
                    CqlInterval<CqlDateTime> kzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzx_);
                    CqlDateTime kzzzz_ = context.Operators.End(kzzzy_);

                    return kzzzz_;
                };
                IEnumerable<Encounter> xzzz_ = context.Operators.SortBy<Encounter>(xzzx_, xzzy_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter yzza_ = context.Operators.Last<Encounter>(xzzz_);
                Period yzzb_ = yzza_?.Period;
                CqlInterval<CqlDateTime> yzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzb_);
                CqlDateTime yzzd_ = context.Operators.Start(yzzc_);
                IEnumerable<Encounter> yzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? yzzg_(Encounter LastObs)
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
                IEnumerable<Encounter> yzzh_ = context.Operators.Where<Encounter>(yzzf_, yzzg_);
                object yzzi_(Encounter @this)
                {
                    Period lzzzx_ = @this?.Period;
                    CqlInterval<CqlDateTime> lzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzx_);
                    CqlDateTime lzzzz_ = context.Operators.End(lzzzy_);

                    return lzzzz_;
                };
                IEnumerable<Encounter> yzzj_ = context.Operators.SortBy<Encounter>(yzzh_, yzzi_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter yzzk_ = context.Operators.Last<Encounter>(yzzj_);
                Period yzzl_ = yzzk_?.Period;
                CqlInterval<CqlDateTime> yzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzl_);
                CqlDateTime yzzn_ = context.Operators.Start(yzzm_);
                CqlInterval<CqlDateTime> yzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzp_);
                CqlDateTime yzzq_ = context.Operators.Start(yzzp_);
                CqlInterval<CqlDateTime> yzzr_ = context.Operators.Interval(xzzt_, yzzd_ ?? yzzn_ ?? yzzq_, true, true);
                bool? yzzs_ = context.Operators.In<CqlDateTime>(wzzu_, yzzr_, default);
                IEnumerable<Encounter> yzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? yzzv_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> mzzza_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? mzzzb_ = mzzza_?.Value;
                    Code<Encounter.EncounterStatus> mzzzc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(mzzzb_);
                    bool? mzzzd_ = context.Operators.Equal(mzzzc_, "finished");
                    Period mzzze_ = LastED?.Period;
                    CqlInterval<CqlDateTime> mzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzze_);
                    CqlDateTime mzzzg_ = context.Operators.End(mzzzf_);
                    CqlValueSet mzzzh_ = this.Observation_Services(context);
                    IEnumerable<Encounter> mzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? mzzzj_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> ozzzb_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? ozzzc_ = ozzzb_?.Value;
                        Code<Encounter.EncounterStatus> ozzzd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ozzzc_);
                        bool? ozzze_ = context.Operators.Equal(ozzzd_, "finished");
                        Period ozzzf_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> ozzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzf_);
                        CqlDateTime ozzzh_ = context.Operators.End(ozzzg_);
                        Period ozzzi_ = Visit?.Period;
                        CqlInterval<CqlDateTime> ozzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzi_);
                        CqlDateTime ozzzk_ = context.Operators.Start(ozzzj_);
                        CqlQuantity ozzzl_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime ozzzm_ = context.Operators.Subtract(ozzzk_, ozzzl_);
                        CqlInterval<CqlDateTime> ozzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzi_);
                        CqlDateTime ozzzp_ = context.Operators.Start(ozzzo_);
                        CqlInterval<CqlDateTime> ozzzq_ = context.Operators.Interval(ozzzm_, ozzzp_, true, true);
                        bool? ozzzr_ = context.Operators.In<CqlDateTime>(ozzzh_, ozzzq_, default);
                        CqlInterval<CqlDateTime> ozzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzi_);
                        CqlDateTime ozzzu_ = context.Operators.Start(ozzzt_);
                        bool? ozzzv_ = context.Operators.Not((bool?)(ozzzu_ is null));
                        bool? ozzzw_ = context.Operators.And(ozzzr_, ozzzv_);
                        bool? ozzzx_ = context.Operators.And(ozzze_, ozzzw_);

                        return ozzzx_;
                    };
                    IEnumerable<Encounter> mzzzk_ = context.Operators.Where<Encounter>(mzzzi_, mzzzj_);
                    object mzzzl_(Encounter @this)
                    {
                        Period ozzzy_ = @this?.Period;
                        CqlInterval<CqlDateTime> ozzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzy_);
                        CqlDateTime pzzza_ = context.Operators.End(ozzzz_);

                        return pzzza_;
                    };
                    IEnumerable<Encounter> mzzzm_ = context.Operators.SortBy<Encounter>(mzzzk_, mzzzl_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter mzzzn_ = context.Operators.Last<Encounter>(mzzzm_);
                    Period mzzzo_ = mzzzn_?.Period;
                    CqlInterval<CqlDateTime> mzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzo_);
                    CqlDateTime mzzzq_ = context.Operators.Start(mzzzp_);
                    Period mzzzr_ = Visit?.Period;
                    CqlInterval<CqlDateTime> mzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzr_);
                    CqlDateTime mzzzt_ = context.Operators.Start(mzzzs_);
                    CqlQuantity mzzzu_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime mzzzv_ = context.Operators.Subtract(mzzzq_ ?? mzzzt_, mzzzu_);
                    IEnumerable<Encounter> mzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? mzzzy_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> pzzzb_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? pzzzc_ = pzzzb_?.Value;
                        Code<Encounter.EncounterStatus> pzzzd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pzzzc_);
                        bool? pzzze_ = context.Operators.Equal(pzzzd_, "finished");
                        Period pzzzf_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> pzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzf_);
                        CqlDateTime pzzzh_ = context.Operators.End(pzzzg_);
                        Period pzzzi_ = Visit?.Period;
                        CqlInterval<CqlDateTime> pzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzi_);
                        CqlDateTime pzzzk_ = context.Operators.Start(pzzzj_);
                        CqlQuantity pzzzl_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime pzzzm_ = context.Operators.Subtract(pzzzk_, pzzzl_);
                        CqlInterval<CqlDateTime> pzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzi_);
                        CqlDateTime pzzzp_ = context.Operators.Start(pzzzo_);
                        CqlInterval<CqlDateTime> pzzzq_ = context.Operators.Interval(pzzzm_, pzzzp_, true, true);
                        bool? pzzzr_ = context.Operators.In<CqlDateTime>(pzzzh_, pzzzq_, default);
                        CqlInterval<CqlDateTime> pzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzi_);
                        CqlDateTime pzzzu_ = context.Operators.Start(pzzzt_);
                        bool? pzzzv_ = context.Operators.Not((bool?)(pzzzu_ is null));
                        bool? pzzzw_ = context.Operators.And(pzzzr_, pzzzv_);
                        bool? pzzzx_ = context.Operators.And(pzzze_, pzzzw_);

                        return pzzzx_;
                    };
                    IEnumerable<Encounter> mzzzz_ = context.Operators.Where<Encounter>(mzzzx_, mzzzy_);
                    object nzzza_(Encounter @this)
                    {
                        Period pzzzy_ = @this?.Period;
                        CqlInterval<CqlDateTime> pzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzy_);
                        CqlDateTime qzzza_ = context.Operators.End(pzzzz_);

                        return qzzza_;
                    };
                    IEnumerable<Encounter> nzzzb_ = context.Operators.SortBy<Encounter>(mzzzz_, nzzza_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter nzzzc_ = context.Operators.Last<Encounter>(nzzzb_);
                    Period nzzzd_ = nzzzc_?.Period;
                    CqlInterval<CqlDateTime> nzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzd_);
                    CqlDateTime nzzzf_ = context.Operators.Start(nzzze_);
                    CqlInterval<CqlDateTime> nzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzr_);
                    CqlDateTime nzzzi_ = context.Operators.Start(nzzzh_);
                    CqlInterval<CqlDateTime> nzzzj_ = context.Operators.Interval(mzzzv_, nzzzf_ ?? nzzzi_, true, true);
                    bool? nzzzk_ = context.Operators.In<CqlDateTime>(mzzzg_, nzzzj_, default);
                    IEnumerable<Encounter> nzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? nzzzn_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> qzzzb_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? qzzzc_ = qzzzb_?.Value;
                        Code<Encounter.EncounterStatus> qzzzd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(qzzzc_);
                        bool? qzzze_ = context.Operators.Equal(qzzzd_, "finished");
                        Period qzzzf_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> qzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzf_);
                        CqlDateTime qzzzh_ = context.Operators.End(qzzzg_);
                        Period qzzzi_ = Visit?.Period;
                        CqlInterval<CqlDateTime> qzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzi_);
                        CqlDateTime qzzzk_ = context.Operators.Start(qzzzj_);
                        CqlQuantity qzzzl_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime qzzzm_ = context.Operators.Subtract(qzzzk_, qzzzl_);
                        CqlInterval<CqlDateTime> qzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzi_);
                        CqlDateTime qzzzp_ = context.Operators.Start(qzzzo_);
                        CqlInterval<CqlDateTime> qzzzq_ = context.Operators.Interval(qzzzm_, qzzzp_, true, true);
                        bool? qzzzr_ = context.Operators.In<CqlDateTime>(qzzzh_, qzzzq_, default);
                        CqlInterval<CqlDateTime> qzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzi_);
                        CqlDateTime qzzzu_ = context.Operators.Start(qzzzt_);
                        bool? qzzzv_ = context.Operators.Not((bool?)(qzzzu_ is null));
                        bool? qzzzw_ = context.Operators.And(qzzzr_, qzzzv_);
                        bool? qzzzx_ = context.Operators.And(qzzze_, qzzzw_);

                        return qzzzx_;
                    };
                    IEnumerable<Encounter> nzzzo_ = context.Operators.Where<Encounter>(nzzzm_, nzzzn_);
                    object nzzzp_(Encounter @this)
                    {
                        Period qzzzy_ = @this?.Period;
                        CqlInterval<CqlDateTime> qzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzy_);
                        CqlDateTime rzzza_ = context.Operators.End(qzzzz_);

                        return rzzza_;
                    };
                    IEnumerable<Encounter> nzzzq_ = context.Operators.SortBy<Encounter>(nzzzo_, nzzzp_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter nzzzr_ = context.Operators.Last<Encounter>(nzzzq_);
                    Period nzzzs_ = nzzzr_?.Period;
                    CqlInterval<CqlDateTime> nzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzs_);
                    CqlDateTime nzzzu_ = context.Operators.Start(nzzzt_);
                    CqlInterval<CqlDateTime> nzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzr_);
                    CqlDateTime nzzzx_ = context.Operators.Start(nzzzw_);
                    bool? nzzzy_ = context.Operators.Not((bool?)((nzzzu_ ?? nzzzx_) is null));
                    bool? nzzzz_ = context.Operators.And(nzzzk_, nzzzy_);
                    bool? ozzza_ = context.Operators.And(mzzzd_, nzzzz_);

                    return ozzza_;
                };
                IEnumerable<Encounter> yzzw_ = context.Operators.Where<Encounter>(yzzu_, yzzv_);
                object yzzx_(Encounter @this)
                {
                    Period rzzzb_ = @this?.Period;
                    CqlInterval<CqlDateTime> rzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzb_);
                    CqlDateTime rzzzd_ = context.Operators.End(rzzzc_);

                    return rzzzd_;
                };
                IEnumerable<Encounter> yzzy_ = context.Operators.SortBy<Encounter>(yzzw_, yzzx_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter yzzz_ = context.Operators.Last<Encounter>(yzzy_);
                Period zzza_ = yzzz_?.Period;
                CqlInterval<CqlDateTime> zzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzza_);
                CqlDateTime zzzc_ = context.Operators.Start(zzzb_);
                IEnumerable<Encounter> zzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? zzzf_(Encounter LastObs)
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
                IEnumerable<Encounter> zzzg_ = context.Operators.Where<Encounter>(zzze_, zzzf_);
                object zzzh_(Encounter @this)
                {
                    Period szzzb_ = @this?.Period;
                    CqlInterval<CqlDateTime> szzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzb_);
                    CqlDateTime szzzd_ = context.Operators.End(szzzc_);

                    return szzzd_;
                };
                IEnumerable<Encounter> zzzi_ = context.Operators.SortBy<Encounter>(zzzg_, zzzh_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter zzzj_ = context.Operators.Last<Encounter>(zzzi_);
                Period zzzk_ = zzzj_?.Period;
                CqlInterval<CqlDateTime> zzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzk_);
                CqlDateTime zzzm_ = context.Operators.Start(zzzl_);
                CqlInterval<CqlDateTime> zzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzp_);
                CqlDateTime zzzp_ = context.Operators.Start(zzzo_);
                bool? zzzq_ = context.Operators.Not((bool?)((zzzc_ ?? zzzm_ ?? zzzp_) is null));
                bool? zzzr_ = context.Operators.And(yzzs_, zzzq_);

                return zzzr_;
            };
            IEnumerable<Encounter> vzzk_ = context.Operators.Where<Encounter>(vzzi_, vzzj_);
            object vzzl_(Encounter @this)
            {
                Period szzze_ = @this?.Period;
                CqlInterval<CqlDateTime> szzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzze_);
                CqlDateTime szzzg_ = context.Operators.End(szzzf_);

                return szzzg_;
            };
            IEnumerable<Encounter> vzzm_ = context.Operators.SortBy<Encounter>(vzzk_, vzzl_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter vzzn_ = context.Operators.Last<Encounter>(vzzm_);
            Period vzzo_ = vzzn_?.Period;
            CqlInterval<CqlDateTime> vzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzo_);
            CqlDateTime vzzq_ = context.Operators.Start(vzzp_);
            CqlValueSet vzzr_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> vzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? vzzt_(Encounter LastED)
            {
                Code<Encounter.EncounterStatus> szzzh_ = LastED?.StatusElement;
                Encounter.EncounterStatus? szzzi_ = szzzh_?.Value;
                Code<Encounter.EncounterStatus> szzzj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(szzzi_);
                bool? szzzk_ = context.Operators.Equal(szzzj_, "finished");
                Period szzzl_ = LastED?.Period;
                CqlInterval<CqlDateTime> szzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzl_);
                CqlDateTime szzzn_ = context.Operators.End(szzzm_);
                CqlValueSet szzzo_ = this.Observation_Services(context);
                IEnumerable<Encounter> szzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? szzzq_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> uzzzi_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? uzzzj_ = uzzzi_?.Value;
                    Code<Encounter.EncounterStatus> uzzzk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(uzzzj_);
                    bool? uzzzl_ = context.Operators.Equal(uzzzk_, "finished");
                    Period uzzzm_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> uzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzm_);
                    CqlDateTime uzzzo_ = context.Operators.End(uzzzn_);
                    Period uzzzp_ = Visit?.Period;
                    CqlInterval<CqlDateTime> uzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzp_);
                    CqlDateTime uzzzr_ = context.Operators.Start(uzzzq_);
                    CqlQuantity uzzzs_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime uzzzt_ = context.Operators.Subtract(uzzzr_, uzzzs_);
                    CqlInterval<CqlDateTime> uzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzp_);
                    CqlDateTime uzzzw_ = context.Operators.Start(uzzzv_);
                    CqlInterval<CqlDateTime> uzzzx_ = context.Operators.Interval(uzzzt_, uzzzw_, true, true);
                    bool? uzzzy_ = context.Operators.In<CqlDateTime>(uzzzo_, uzzzx_, default);
                    CqlInterval<CqlDateTime> vzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzp_);
                    CqlDateTime vzzzb_ = context.Operators.Start(vzzza_);
                    bool? vzzzc_ = context.Operators.Not((bool?)(vzzzb_ is null));
                    bool? vzzzd_ = context.Operators.And(uzzzy_, vzzzc_);
                    bool? vzzze_ = context.Operators.And(uzzzl_, vzzzd_);

                    return vzzze_;
                };
                IEnumerable<Encounter> szzzr_ = context.Operators.Where<Encounter>(szzzp_, szzzq_);
                object szzzs_(Encounter @this)
                {
                    Period vzzzf_ = @this?.Period;
                    CqlInterval<CqlDateTime> vzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzf_);
                    CqlDateTime vzzzh_ = context.Operators.End(vzzzg_);

                    return vzzzh_;
                };
                IEnumerable<Encounter> szzzt_ = context.Operators.SortBy<Encounter>(szzzr_, szzzs_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter szzzu_ = context.Operators.Last<Encounter>(szzzt_);
                Period szzzv_ = szzzu_?.Period;
                CqlInterval<CqlDateTime> szzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzv_);
                CqlDateTime szzzx_ = context.Operators.Start(szzzw_);
                Period szzzy_ = Visit?.Period;
                CqlInterval<CqlDateTime> szzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzy_);
                CqlDateTime tzzza_ = context.Operators.Start(szzzz_);
                CqlQuantity tzzzb_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime tzzzc_ = context.Operators.Subtract(szzzx_ ?? tzzza_, tzzzb_);
                IEnumerable<Encounter> tzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? tzzzf_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> vzzzi_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? vzzzj_ = vzzzi_?.Value;
                    Code<Encounter.EncounterStatus> vzzzk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(vzzzj_);
                    bool? vzzzl_ = context.Operators.Equal(vzzzk_, "finished");
                    Period vzzzm_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> vzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzm_);
                    CqlDateTime vzzzo_ = context.Operators.End(vzzzn_);
                    Period vzzzp_ = Visit?.Period;
                    CqlInterval<CqlDateTime> vzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzp_);
                    CqlDateTime vzzzr_ = context.Operators.Start(vzzzq_);
                    CqlQuantity vzzzs_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime vzzzt_ = context.Operators.Subtract(vzzzr_, vzzzs_);
                    CqlInterval<CqlDateTime> vzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzp_);
                    CqlDateTime vzzzw_ = context.Operators.Start(vzzzv_);
                    CqlInterval<CqlDateTime> vzzzx_ = context.Operators.Interval(vzzzt_, vzzzw_, true, true);
                    bool? vzzzy_ = context.Operators.In<CqlDateTime>(vzzzo_, vzzzx_, default);
                    CqlInterval<CqlDateTime> wzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzp_);
                    CqlDateTime wzzzb_ = context.Operators.Start(wzzza_);
                    bool? wzzzc_ = context.Operators.Not((bool?)(wzzzb_ is null));
                    bool? wzzzd_ = context.Operators.And(vzzzy_, wzzzc_);
                    bool? wzzze_ = context.Operators.And(vzzzl_, wzzzd_);

                    return wzzze_;
                };
                IEnumerable<Encounter> tzzzg_ = context.Operators.Where<Encounter>(tzzze_, tzzzf_);
                object tzzzh_(Encounter @this)
                {
                    Period wzzzf_ = @this?.Period;
                    CqlInterval<CqlDateTime> wzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzf_);
                    CqlDateTime wzzzh_ = context.Operators.End(wzzzg_);

                    return wzzzh_;
                };
                IEnumerable<Encounter> tzzzi_ = context.Operators.SortBy<Encounter>(tzzzg_, tzzzh_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter tzzzj_ = context.Operators.Last<Encounter>(tzzzi_);
                Period tzzzk_ = tzzzj_?.Period;
                CqlInterval<CqlDateTime> tzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzk_);
                CqlDateTime tzzzm_ = context.Operators.Start(tzzzl_);
                CqlInterval<CqlDateTime> tzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzy_);
                CqlDateTime tzzzp_ = context.Operators.Start(tzzzo_);
                CqlInterval<CqlDateTime> tzzzq_ = context.Operators.Interval(tzzzc_, tzzzm_ ?? tzzzp_, true, true);
                bool? tzzzr_ = context.Operators.In<CqlDateTime>(szzzn_, tzzzq_, default);
                IEnumerable<Encounter> tzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? tzzzu_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> wzzzi_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? wzzzj_ = wzzzi_?.Value;
                    Code<Encounter.EncounterStatus> wzzzk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(wzzzj_);
                    bool? wzzzl_ = context.Operators.Equal(wzzzk_, "finished");
                    Period wzzzm_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> wzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzm_);
                    CqlDateTime wzzzo_ = context.Operators.End(wzzzn_);
                    Period wzzzp_ = Visit?.Period;
                    CqlInterval<CqlDateTime> wzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzp_);
                    CqlDateTime wzzzr_ = context.Operators.Start(wzzzq_);
                    CqlQuantity wzzzs_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime wzzzt_ = context.Operators.Subtract(wzzzr_, wzzzs_);
                    CqlInterval<CqlDateTime> wzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzp_);
                    CqlDateTime wzzzw_ = context.Operators.Start(wzzzv_);
                    CqlInterval<CqlDateTime> wzzzx_ = context.Operators.Interval(wzzzt_, wzzzw_, true, true);
                    bool? wzzzy_ = context.Operators.In<CqlDateTime>(wzzzo_, wzzzx_, default);
                    CqlInterval<CqlDateTime> xzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzp_);
                    CqlDateTime xzzzb_ = context.Operators.Start(xzzza_);
                    bool? xzzzc_ = context.Operators.Not((bool?)(xzzzb_ is null));
                    bool? xzzzd_ = context.Operators.And(wzzzy_, xzzzc_);
                    bool? xzzze_ = context.Operators.And(wzzzl_, xzzzd_);

                    return xzzze_;
                };
                IEnumerable<Encounter> tzzzv_ = context.Operators.Where<Encounter>(tzzzt_, tzzzu_);
                object tzzzw_(Encounter @this)
                {
                    Period xzzzf_ = @this?.Period;
                    CqlInterval<CqlDateTime> xzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzf_);
                    CqlDateTime xzzzh_ = context.Operators.End(xzzzg_);

                    return xzzzh_;
                };
                IEnumerable<Encounter> tzzzx_ = context.Operators.SortBy<Encounter>(tzzzv_, tzzzw_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter tzzzy_ = context.Operators.Last<Encounter>(tzzzx_);
                Period tzzzz_ = tzzzy_?.Period;
                CqlInterval<CqlDateTime> uzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzz_);
                CqlDateTime uzzzb_ = context.Operators.Start(uzzza_);
                CqlInterval<CqlDateTime> uzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzy_);
                CqlDateTime uzzze_ = context.Operators.Start(uzzzd_);
                bool? uzzzf_ = context.Operators.Not((bool?)((uzzzb_ ?? uzzze_) is null));
                bool? uzzzg_ = context.Operators.And(tzzzr_, uzzzf_);
                bool? uzzzh_ = context.Operators.And(szzzk_, uzzzg_);

                return uzzzh_;
            };
            IEnumerable<Encounter> vzzu_ = context.Operators.Where<Encounter>(vzzs_, vzzt_);
            object vzzv_(Encounter @this)
            {
                Period xzzzi_ = @this?.Period;
                CqlInterval<CqlDateTime> xzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzi_);
                CqlDateTime xzzzk_ = context.Operators.End(xzzzj_);

                return xzzzk_;
            };
            IEnumerable<Encounter> vzzw_ = context.Operators.SortBy<Encounter>(vzzu_, vzzv_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter vzzx_ = context.Operators.Last<Encounter>(vzzw_);
            Period vzzy_ = vzzx_?.Period;
            CqlInterval<CqlDateTime> vzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzy_);
            CqlDateTime wzza_ = context.Operators.Start(vzzz_);
            CqlValueSet wzzb_ = this.Observation_Services(context);
            IEnumerable<Encounter> wzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? wzzd_(Encounter LastObs)
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
            IEnumerable<Encounter> wzze_ = context.Operators.Where<Encounter>(wzzc_, wzzd_);
            object wzzf_(Encounter @this)
            {
                Period yzzzi_ = @this?.Period;
                CqlInterval<CqlDateTime> yzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzi_);
                CqlDateTime yzzzk_ = context.Operators.End(yzzzj_);

                return yzzzk_;
            };
            IEnumerable<Encounter> wzzg_ = context.Operators.SortBy<Encounter>(wzze_, wzzf_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter wzzh_ = context.Operators.Last<Encounter>(wzzg_);
            Period wzzi_ = wzzh_?.Period;
            CqlInterval<CqlDateTime> wzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzi_);
            CqlDateTime wzzk_ = context.Operators.Start(wzzj_);
            Period wzzl_ = Visit?.Period;
            CqlInterval<CqlDateTime> wzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzl_);
            CqlDateTime wzzn_ = context.Operators.Start(wzzm_);
            CqlInterval<CqlDateTime> wzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzl_);
            CqlDateTime wzzq_ = context.Operators.End(wzzp_);
            CqlInterval<CqlDateTime> wzzr_ = context.Operators.Interval(vzzq_ ?? wzza_ ?? wzzk_ ?? wzzn_, wzzq_, true, true);

            return wzzr_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> vzze_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)vzzc_, vzzd_);
        IEnumerable<CqlInterval<CqlDateTime>> vzzf_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(vzze_);
        CqlInterval<CqlDateTime> vzzg_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(vzzf_);

        return vzzg_;
    }


    [CqlExpressionDefinition("hospitalizationWithObservationAndOutpatientSurgeryService")]
    [CqlTag("description", "Hospitalization with Observation and Outpatient Surgery Service returns the total interval from the start of any immediately prior emergency department visit, outpatient surgery visit or observation visit to the discharge of the given encounter.")]
    public CqlInterval<CqlDateTime> hospitalizationWithObservationAndOutpatientSurgeryService(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] yzzzl_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> yzzzm_(Encounter Visit)
        {
            CqlValueSet yzzzq_ = this.Outpatient_Surgery_Service(context);
            IEnumerable<Encounter> yzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? yzzzs_(Encounter LastSurgeryOP)
            {
                Period azzzzb_ = LastSurgeryOP?.Period;
                CqlInterval<CqlDateTime> azzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzb_);
                CqlDateTime azzzzd_ = context.Operators.End(azzzzc_);
                CqlValueSet azzzze_ = this.Emergency_Department_Visit(context);
                IEnumerable<Encounter> azzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? azzzzg_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> dzzzzb_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? dzzzzc_ = dzzzzb_?.Value;
                    Code<Encounter.EncounterStatus> dzzzzd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dzzzzc_);
                    bool? dzzzze_ = context.Operators.Equal(dzzzzd_, "finished");
                    Period dzzzzf_ = LastED?.Period;
                    CqlInterval<CqlDateTime> dzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzf_);
                    CqlDateTime dzzzzh_ = context.Operators.End(dzzzzg_);
                    CqlValueSet dzzzzi_ = this.Observation_Services(context);
                    IEnumerable<Encounter> dzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? dzzzzk_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> fzzzzc_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? fzzzzd_ = fzzzzc_?.Value;
                        Code<Encounter.EncounterStatus> fzzzze_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fzzzzd_);
                        bool? fzzzzf_ = context.Operators.Equal(fzzzze_, "finished");
                        Period fzzzzg_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> fzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzg_);
                        CqlDateTime fzzzzi_ = context.Operators.End(fzzzzh_);
                        Period fzzzzj_ = Visit?.Period;
                        CqlInterval<CqlDateTime> fzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzj_);
                        CqlDateTime fzzzzl_ = context.Operators.Start(fzzzzk_);
                        CqlQuantity fzzzzm_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime fzzzzn_ = context.Operators.Subtract(fzzzzl_, fzzzzm_);
                        CqlInterval<CqlDateTime> fzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzj_);
                        CqlDateTime fzzzzq_ = context.Operators.Start(fzzzzp_);
                        CqlInterval<CqlDateTime> fzzzzr_ = context.Operators.Interval(fzzzzn_, fzzzzq_, true, true);
                        bool? fzzzzs_ = context.Operators.In<CqlDateTime>(fzzzzi_, fzzzzr_, default);
                        CqlInterval<CqlDateTime> fzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzj_);
                        CqlDateTime fzzzzv_ = context.Operators.Start(fzzzzu_);
                        bool? fzzzzw_ = context.Operators.Not((bool?)(fzzzzv_ is null));
                        bool? fzzzzx_ = context.Operators.And(fzzzzs_, fzzzzw_);
                        bool? fzzzzy_ = context.Operators.And(fzzzzf_, fzzzzx_);

                        return fzzzzy_;
                    };
                    IEnumerable<Encounter> dzzzzl_ = context.Operators.Where<Encounter>(dzzzzj_, dzzzzk_);
                    object dzzzzm_(Encounter @this)
                    {
                        Period fzzzzz_ = @this?.Period;
                        CqlInterval<CqlDateTime> gzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzz_);
                        CqlDateTime gzzzzb_ = context.Operators.End(gzzzza_);

                        return gzzzzb_;
                    };
                    IEnumerable<Encounter> dzzzzn_ = context.Operators.SortBy<Encounter>(dzzzzl_, dzzzzm_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter dzzzzo_ = context.Operators.Last<Encounter>(dzzzzn_);
                    Period dzzzzp_ = dzzzzo_?.Period;
                    CqlInterval<CqlDateTime> dzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzp_);
                    CqlDateTime dzzzzr_ = context.Operators.Start(dzzzzq_);
                    Period dzzzzs_ = Visit?.Period;
                    CqlInterval<CqlDateTime> dzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzs_);
                    CqlDateTime dzzzzu_ = context.Operators.Start(dzzzzt_);
                    CqlQuantity dzzzzv_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime dzzzzw_ = context.Operators.Subtract(dzzzzr_ ?? dzzzzu_, dzzzzv_);
                    IEnumerable<Encounter> dzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? dzzzzz_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> gzzzzc_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? gzzzzd_ = gzzzzc_?.Value;
                        Code<Encounter.EncounterStatus> gzzzze_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gzzzzd_);
                        bool? gzzzzf_ = context.Operators.Equal(gzzzze_, "finished");
                        Period gzzzzg_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> gzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzg_);
                        CqlDateTime gzzzzi_ = context.Operators.End(gzzzzh_);
                        Period gzzzzj_ = Visit?.Period;
                        CqlInterval<CqlDateTime> gzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzj_);
                        CqlDateTime gzzzzl_ = context.Operators.Start(gzzzzk_);
                        CqlQuantity gzzzzm_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime gzzzzn_ = context.Operators.Subtract(gzzzzl_, gzzzzm_);
                        CqlInterval<CqlDateTime> gzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzj_);
                        CqlDateTime gzzzzq_ = context.Operators.Start(gzzzzp_);
                        CqlInterval<CqlDateTime> gzzzzr_ = context.Operators.Interval(gzzzzn_, gzzzzq_, true, true);
                        bool? gzzzzs_ = context.Operators.In<CqlDateTime>(gzzzzi_, gzzzzr_, default);
                        CqlInterval<CqlDateTime> gzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzj_);
                        CqlDateTime gzzzzv_ = context.Operators.Start(gzzzzu_);
                        bool? gzzzzw_ = context.Operators.Not((bool?)(gzzzzv_ is null));
                        bool? gzzzzx_ = context.Operators.And(gzzzzs_, gzzzzw_);
                        bool? gzzzzy_ = context.Operators.And(gzzzzf_, gzzzzx_);

                        return gzzzzy_;
                    };
                    IEnumerable<Encounter> ezzzza_ = context.Operators.Where<Encounter>(dzzzzy_, dzzzzz_);
                    object ezzzzb_(Encounter @this)
                    {
                        Period gzzzzz_ = @this?.Period;
                        CqlInterval<CqlDateTime> hzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzz_);
                        CqlDateTime hzzzzb_ = context.Operators.End(hzzzza_);

                        return hzzzzb_;
                    };
                    IEnumerable<Encounter> ezzzzc_ = context.Operators.SortBy<Encounter>(ezzzza_, ezzzzb_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter ezzzzd_ = context.Operators.Last<Encounter>(ezzzzc_);
                    Period ezzzze_ = ezzzzd_?.Period;
                    CqlInterval<CqlDateTime> ezzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzze_);
                    CqlDateTime ezzzzg_ = context.Operators.Start(ezzzzf_);
                    CqlInterval<CqlDateTime> ezzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzs_);
                    CqlDateTime ezzzzj_ = context.Operators.Start(ezzzzi_);
                    CqlInterval<CqlDateTime> ezzzzk_ = context.Operators.Interval(dzzzzw_, ezzzzg_ ?? ezzzzj_, true, true);
                    bool? ezzzzl_ = context.Operators.In<CqlDateTime>(dzzzzh_, ezzzzk_, default);
                    IEnumerable<Encounter> ezzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? ezzzzo_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> hzzzzc_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? hzzzzd_ = hzzzzc_?.Value;
                        Code<Encounter.EncounterStatus> hzzzze_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hzzzzd_);
                        bool? hzzzzf_ = context.Operators.Equal(hzzzze_, "finished");
                        Period hzzzzg_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> hzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzg_);
                        CqlDateTime hzzzzi_ = context.Operators.End(hzzzzh_);
                        Period hzzzzj_ = Visit?.Period;
                        CqlInterval<CqlDateTime> hzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzj_);
                        CqlDateTime hzzzzl_ = context.Operators.Start(hzzzzk_);
                        CqlQuantity hzzzzm_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime hzzzzn_ = context.Operators.Subtract(hzzzzl_, hzzzzm_);
                        CqlInterval<CqlDateTime> hzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzj_);
                        CqlDateTime hzzzzq_ = context.Operators.Start(hzzzzp_);
                        CqlInterval<CqlDateTime> hzzzzr_ = context.Operators.Interval(hzzzzn_, hzzzzq_, true, true);
                        bool? hzzzzs_ = context.Operators.In<CqlDateTime>(hzzzzi_, hzzzzr_, default);
                        CqlInterval<CqlDateTime> hzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzj_);
                        CqlDateTime hzzzzv_ = context.Operators.Start(hzzzzu_);
                        bool? hzzzzw_ = context.Operators.Not((bool?)(hzzzzv_ is null));
                        bool? hzzzzx_ = context.Operators.And(hzzzzs_, hzzzzw_);
                        bool? hzzzzy_ = context.Operators.And(hzzzzf_, hzzzzx_);

                        return hzzzzy_;
                    };
                    IEnumerable<Encounter> ezzzzp_ = context.Operators.Where<Encounter>(ezzzzn_, ezzzzo_);
                    object ezzzzq_(Encounter @this)
                    {
                        Period hzzzzz_ = @this?.Period;
                        CqlInterval<CqlDateTime> izzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzz_);
                        CqlDateTime izzzzb_ = context.Operators.End(izzzza_);

                        return izzzzb_;
                    };
                    IEnumerable<Encounter> ezzzzr_ = context.Operators.SortBy<Encounter>(ezzzzp_, ezzzzq_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter ezzzzs_ = context.Operators.Last<Encounter>(ezzzzr_);
                    Period ezzzzt_ = ezzzzs_?.Period;
                    CqlInterval<CqlDateTime> ezzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzt_);
                    CqlDateTime ezzzzv_ = context.Operators.Start(ezzzzu_);
                    CqlInterval<CqlDateTime> ezzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzs_);
                    CqlDateTime ezzzzy_ = context.Operators.Start(ezzzzx_);
                    bool? ezzzzz_ = context.Operators.Not((bool?)((ezzzzv_ ?? ezzzzy_) is null));
                    bool? fzzzza_ = context.Operators.And(ezzzzl_, ezzzzz_);
                    bool? fzzzzb_ = context.Operators.And(dzzzze_, fzzzza_);

                    return fzzzzb_;
                };
                IEnumerable<Encounter> azzzzh_ = context.Operators.Where<Encounter>(azzzzf_, azzzzg_);
                object azzzzi_(Encounter @this)
                {
                    Period izzzzc_ = @this?.Period;
                    CqlInterval<CqlDateTime> izzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzc_);
                    CqlDateTime izzzze_ = context.Operators.End(izzzzd_);

                    return izzzze_;
                };
                IEnumerable<Encounter> azzzzj_ = context.Operators.SortBy<Encounter>(azzzzh_, azzzzi_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter azzzzk_ = context.Operators.Last<Encounter>(azzzzj_);
                Period azzzzl_ = azzzzk_?.Period;
                CqlInterval<CqlDateTime> azzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzl_);
                CqlDateTime azzzzn_ = context.Operators.Start(azzzzm_);
                CqlValueSet azzzzo_ = this.Observation_Services(context);
                IEnumerable<Encounter> azzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? azzzzq_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> izzzzf_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? izzzzg_ = izzzzf_?.Value;
                    Code<Encounter.EncounterStatus> izzzzh_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(izzzzg_);
                    bool? izzzzi_ = context.Operators.Equal(izzzzh_, "finished");
                    Period izzzzj_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> izzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzj_);
                    CqlDateTime izzzzl_ = context.Operators.End(izzzzk_);
                    Period izzzzm_ = Visit?.Period;
                    CqlInterval<CqlDateTime> izzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzm_);
                    CqlDateTime izzzzo_ = context.Operators.Start(izzzzn_);
                    CqlQuantity izzzzp_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime izzzzq_ = context.Operators.Subtract(izzzzo_, izzzzp_);
                    CqlInterval<CqlDateTime> izzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzm_);
                    CqlDateTime izzzzt_ = context.Operators.Start(izzzzs_);
                    CqlInterval<CqlDateTime> izzzzu_ = context.Operators.Interval(izzzzq_, izzzzt_, true, true);
                    bool? izzzzv_ = context.Operators.In<CqlDateTime>(izzzzl_, izzzzu_, default);
                    CqlInterval<CqlDateTime> izzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzm_);
                    CqlDateTime izzzzy_ = context.Operators.Start(izzzzx_);
                    bool? izzzzz_ = context.Operators.Not((bool?)(izzzzy_ is null));
                    bool? jzzzza_ = context.Operators.And(izzzzv_, izzzzz_);
                    bool? jzzzzb_ = context.Operators.And(izzzzi_, jzzzza_);

                    return jzzzzb_;
                };
                IEnumerable<Encounter> azzzzr_ = context.Operators.Where<Encounter>(azzzzp_, azzzzq_);
                object azzzzs_(Encounter @this)
                {
                    Period jzzzzc_ = @this?.Period;
                    CqlInterval<CqlDateTime> jzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzc_);
                    CqlDateTime jzzzze_ = context.Operators.End(jzzzzd_);

                    return jzzzze_;
                };
                IEnumerable<Encounter> azzzzt_ = context.Operators.SortBy<Encounter>(azzzzr_, azzzzs_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter azzzzu_ = context.Operators.Last<Encounter>(azzzzt_);
                Period azzzzv_ = azzzzu_?.Period;
                CqlInterval<CqlDateTime> azzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzv_);
                CqlDateTime azzzzx_ = context.Operators.Start(azzzzw_);
                Period azzzzy_ = Visit?.Period;
                CqlInterval<CqlDateTime> azzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzy_);
                CqlDateTime bzzzza_ = context.Operators.Start(azzzzz_);
                CqlQuantity bzzzzb_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime bzzzzc_ = context.Operators.Subtract(azzzzn_ ?? azzzzx_ ?? bzzzza_, bzzzzb_);
                IEnumerable<Encounter> bzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? bzzzzf_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> jzzzzf_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? jzzzzg_ = jzzzzf_?.Value;
                    Code<Encounter.EncounterStatus> jzzzzh_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jzzzzg_);
                    bool? jzzzzi_ = context.Operators.Equal(jzzzzh_, "finished");
                    Period jzzzzj_ = LastED?.Period;
                    CqlInterval<CqlDateTime> jzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzj_);
                    CqlDateTime jzzzzl_ = context.Operators.End(jzzzzk_);
                    CqlValueSet jzzzzm_ = this.Observation_Services(context);
                    IEnumerable<Encounter> jzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? jzzzzo_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> lzzzzg_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? lzzzzh_ = lzzzzg_?.Value;
                        Code<Encounter.EncounterStatus> lzzzzi_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lzzzzh_);
                        bool? lzzzzj_ = context.Operators.Equal(lzzzzi_, "finished");
                        Period lzzzzk_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> lzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzk_);
                        CqlDateTime lzzzzm_ = context.Operators.End(lzzzzl_);
                        Period lzzzzn_ = Visit?.Period;
                        CqlInterval<CqlDateTime> lzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzn_);
                        CqlDateTime lzzzzp_ = context.Operators.Start(lzzzzo_);
                        CqlQuantity lzzzzq_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime lzzzzr_ = context.Operators.Subtract(lzzzzp_, lzzzzq_);
                        CqlInterval<CqlDateTime> lzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzn_);
                        CqlDateTime lzzzzu_ = context.Operators.Start(lzzzzt_);
                        CqlInterval<CqlDateTime> lzzzzv_ = context.Operators.Interval(lzzzzr_, lzzzzu_, true, true);
                        bool? lzzzzw_ = context.Operators.In<CqlDateTime>(lzzzzm_, lzzzzv_, default);
                        CqlInterval<CqlDateTime> lzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzn_);
                        CqlDateTime lzzzzz_ = context.Operators.Start(lzzzzy_);
                        bool? mzzzza_ = context.Operators.Not((bool?)(lzzzzz_ is null));
                        bool? mzzzzb_ = context.Operators.And(lzzzzw_, mzzzza_);
                        bool? mzzzzc_ = context.Operators.And(lzzzzj_, mzzzzb_);

                        return mzzzzc_;
                    };
                    IEnumerable<Encounter> jzzzzp_ = context.Operators.Where<Encounter>(jzzzzn_, jzzzzo_);
                    object jzzzzq_(Encounter @this)
                    {
                        Period mzzzzd_ = @this?.Period;
                        CqlInterval<CqlDateTime> mzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzd_);
                        CqlDateTime mzzzzf_ = context.Operators.End(mzzzze_);

                        return mzzzzf_;
                    };
                    IEnumerable<Encounter> jzzzzr_ = context.Operators.SortBy<Encounter>(jzzzzp_, jzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter jzzzzs_ = context.Operators.Last<Encounter>(jzzzzr_);
                    Period jzzzzt_ = jzzzzs_?.Period;
                    CqlInterval<CqlDateTime> jzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzt_);
                    CqlDateTime jzzzzv_ = context.Operators.Start(jzzzzu_);
                    Period jzzzzw_ = Visit?.Period;
                    CqlInterval<CqlDateTime> jzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzw_);
                    CqlDateTime jzzzzy_ = context.Operators.Start(jzzzzx_);
                    CqlQuantity jzzzzz_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime kzzzza_ = context.Operators.Subtract(jzzzzv_ ?? jzzzzy_, jzzzzz_);
                    IEnumerable<Encounter> kzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? kzzzzd_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> mzzzzg_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? mzzzzh_ = mzzzzg_?.Value;
                        Code<Encounter.EncounterStatus> mzzzzi_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(mzzzzh_);
                        bool? mzzzzj_ = context.Operators.Equal(mzzzzi_, "finished");
                        Period mzzzzk_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> mzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzk_);
                        CqlDateTime mzzzzm_ = context.Operators.End(mzzzzl_);
                        Period mzzzzn_ = Visit?.Period;
                        CqlInterval<CqlDateTime> mzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzn_);
                        CqlDateTime mzzzzp_ = context.Operators.Start(mzzzzo_);
                        CqlQuantity mzzzzq_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime mzzzzr_ = context.Operators.Subtract(mzzzzp_, mzzzzq_);
                        CqlInterval<CqlDateTime> mzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzn_);
                        CqlDateTime mzzzzu_ = context.Operators.Start(mzzzzt_);
                        CqlInterval<CqlDateTime> mzzzzv_ = context.Operators.Interval(mzzzzr_, mzzzzu_, true, true);
                        bool? mzzzzw_ = context.Operators.In<CqlDateTime>(mzzzzm_, mzzzzv_, default);
                        CqlInterval<CqlDateTime> mzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzn_);
                        CqlDateTime mzzzzz_ = context.Operators.Start(mzzzzy_);
                        bool? nzzzza_ = context.Operators.Not((bool?)(mzzzzz_ is null));
                        bool? nzzzzb_ = context.Operators.And(mzzzzw_, nzzzza_);
                        bool? nzzzzc_ = context.Operators.And(mzzzzj_, nzzzzb_);

                        return nzzzzc_;
                    };
                    IEnumerable<Encounter> kzzzze_ = context.Operators.Where<Encounter>(kzzzzc_, kzzzzd_);
                    object kzzzzf_(Encounter @this)
                    {
                        Period nzzzzd_ = @this?.Period;
                        CqlInterval<CqlDateTime> nzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzd_);
                        CqlDateTime nzzzzf_ = context.Operators.End(nzzzze_);

                        return nzzzzf_;
                    };
                    IEnumerable<Encounter> kzzzzg_ = context.Operators.SortBy<Encounter>(kzzzze_, kzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter kzzzzh_ = context.Operators.Last<Encounter>(kzzzzg_);
                    Period kzzzzi_ = kzzzzh_?.Period;
                    CqlInterval<CqlDateTime> kzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzi_);
                    CqlDateTime kzzzzk_ = context.Operators.Start(kzzzzj_);
                    CqlInterval<CqlDateTime> kzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzw_);
                    CqlDateTime kzzzzn_ = context.Operators.Start(kzzzzm_);
                    CqlInterval<CqlDateTime> kzzzzo_ = context.Operators.Interval(kzzzza_, kzzzzk_ ?? kzzzzn_, true, true);
                    bool? kzzzzp_ = context.Operators.In<CqlDateTime>(jzzzzl_, kzzzzo_, default);
                    IEnumerable<Encounter> kzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? kzzzzs_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> nzzzzg_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? nzzzzh_ = nzzzzg_?.Value;
                        Code<Encounter.EncounterStatus> nzzzzi_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(nzzzzh_);
                        bool? nzzzzj_ = context.Operators.Equal(nzzzzi_, "finished");
                        Period nzzzzk_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> nzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzk_);
                        CqlDateTime nzzzzm_ = context.Operators.End(nzzzzl_);
                        Period nzzzzn_ = Visit?.Period;
                        CqlInterval<CqlDateTime> nzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzn_);
                        CqlDateTime nzzzzp_ = context.Operators.Start(nzzzzo_);
                        CqlQuantity nzzzzq_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime nzzzzr_ = context.Operators.Subtract(nzzzzp_, nzzzzq_);
                        CqlInterval<CqlDateTime> nzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzn_);
                        CqlDateTime nzzzzu_ = context.Operators.Start(nzzzzt_);
                        CqlInterval<CqlDateTime> nzzzzv_ = context.Operators.Interval(nzzzzr_, nzzzzu_, true, true);
                        bool? nzzzzw_ = context.Operators.In<CqlDateTime>(nzzzzm_, nzzzzv_, default);
                        CqlInterval<CqlDateTime> nzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzn_);
                        CqlDateTime nzzzzz_ = context.Operators.Start(nzzzzy_);
                        bool? ozzzza_ = context.Operators.Not((bool?)(nzzzzz_ is null));
                        bool? ozzzzb_ = context.Operators.And(nzzzzw_, ozzzza_);
                        bool? ozzzzc_ = context.Operators.And(nzzzzj_, ozzzzb_);

                        return ozzzzc_;
                    };
                    IEnumerable<Encounter> kzzzzt_ = context.Operators.Where<Encounter>(kzzzzr_, kzzzzs_);
                    object kzzzzu_(Encounter @this)
                    {
                        Period ozzzzd_ = @this?.Period;
                        CqlInterval<CqlDateTime> ozzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzd_);
                        CqlDateTime ozzzzf_ = context.Operators.End(ozzzze_);

                        return ozzzzf_;
                    };
                    IEnumerable<Encounter> kzzzzv_ = context.Operators.SortBy<Encounter>(kzzzzt_, kzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter kzzzzw_ = context.Operators.Last<Encounter>(kzzzzv_);
                    Period kzzzzx_ = kzzzzw_?.Period;
                    CqlInterval<CqlDateTime> kzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzx_);
                    CqlDateTime kzzzzz_ = context.Operators.Start(kzzzzy_);
                    CqlInterval<CqlDateTime> lzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzw_);
                    CqlDateTime lzzzzc_ = context.Operators.Start(lzzzzb_);
                    bool? lzzzzd_ = context.Operators.Not((bool?)((kzzzzz_ ?? lzzzzc_) is null));
                    bool? lzzzze_ = context.Operators.And(kzzzzp_, lzzzzd_);
                    bool? lzzzzf_ = context.Operators.And(jzzzzi_, lzzzze_);

                    return lzzzzf_;
                };
                IEnumerable<Encounter> bzzzzg_ = context.Operators.Where<Encounter>(bzzzze_, bzzzzf_);
                object bzzzzh_(Encounter @this)
                {
                    Period ozzzzg_ = @this?.Period;
                    CqlInterval<CqlDateTime> ozzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzg_);
                    CqlDateTime ozzzzi_ = context.Operators.End(ozzzzh_);

                    return ozzzzi_;
                };
                IEnumerable<Encounter> bzzzzi_ = context.Operators.SortBy<Encounter>(bzzzzg_, bzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bzzzzj_ = context.Operators.Last<Encounter>(bzzzzi_);
                Period bzzzzk_ = bzzzzj_?.Period;
                CqlInterval<CqlDateTime> bzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzk_);
                CqlDateTime bzzzzm_ = context.Operators.Start(bzzzzl_);
                IEnumerable<Encounter> bzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? bzzzzp_(Encounter LastObs)
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
                IEnumerable<Encounter> bzzzzq_ = context.Operators.Where<Encounter>(bzzzzo_, bzzzzp_);
                object bzzzzr_(Encounter @this)
                {
                    Period pzzzzg_ = @this?.Period;
                    CqlInterval<CqlDateTime> pzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzg_);
                    CqlDateTime pzzzzi_ = context.Operators.End(pzzzzh_);

                    return pzzzzi_;
                };
                IEnumerable<Encounter> bzzzzs_ = context.Operators.SortBy<Encounter>(bzzzzq_, bzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bzzzzt_ = context.Operators.Last<Encounter>(bzzzzs_);
                Period bzzzzu_ = bzzzzt_?.Period;
                CqlInterval<CqlDateTime> bzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzu_);
                CqlDateTime bzzzzw_ = context.Operators.Start(bzzzzv_);
                CqlInterval<CqlDateTime> bzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzy_);
                CqlDateTime bzzzzz_ = context.Operators.Start(bzzzzy_);
                CqlInterval<CqlDateTime> czzzza_ = context.Operators.Interval(bzzzzc_, bzzzzm_ ?? bzzzzw_ ?? bzzzzz_, true, true);
                bool? czzzzb_ = context.Operators.In<CqlDateTime>(azzzzd_, czzzza_, default);
                IEnumerable<Encounter> czzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? czzzze_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> pzzzzj_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? pzzzzk_ = pzzzzj_?.Value;
                    Code<Encounter.EncounterStatus> pzzzzl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pzzzzk_);
                    bool? pzzzzm_ = context.Operators.Equal(pzzzzl_, "finished");
                    Period pzzzzn_ = LastED?.Period;
                    CqlInterval<CqlDateTime> pzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzn_);
                    CqlDateTime pzzzzp_ = context.Operators.End(pzzzzo_);
                    CqlValueSet pzzzzq_ = this.Observation_Services(context);
                    IEnumerable<Encounter> pzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? pzzzzs_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> rzzzzk_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? rzzzzl_ = rzzzzk_?.Value;
                        Code<Encounter.EncounterStatus> rzzzzm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rzzzzl_);
                        bool? rzzzzn_ = context.Operators.Equal(rzzzzm_, "finished");
                        Period rzzzzo_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> rzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzo_);
                        CqlDateTime rzzzzq_ = context.Operators.End(rzzzzp_);
                        Period rzzzzr_ = Visit?.Period;
                        CqlInterval<CqlDateTime> rzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzr_);
                        CqlDateTime rzzzzt_ = context.Operators.Start(rzzzzs_);
                        CqlQuantity rzzzzu_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime rzzzzv_ = context.Operators.Subtract(rzzzzt_, rzzzzu_);
                        CqlInterval<CqlDateTime> rzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzr_);
                        CqlDateTime rzzzzy_ = context.Operators.Start(rzzzzx_);
                        CqlInterval<CqlDateTime> rzzzzz_ = context.Operators.Interval(rzzzzv_, rzzzzy_, true, true);
                        bool? szzzza_ = context.Operators.In<CqlDateTime>(rzzzzq_, rzzzzz_, default);
                        CqlInterval<CqlDateTime> szzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzr_);
                        CqlDateTime szzzzd_ = context.Operators.Start(szzzzc_);
                        bool? szzzze_ = context.Operators.Not((bool?)(szzzzd_ is null));
                        bool? szzzzf_ = context.Operators.And(szzzza_, szzzze_);
                        bool? szzzzg_ = context.Operators.And(rzzzzn_, szzzzf_);

                        return szzzzg_;
                    };
                    IEnumerable<Encounter> pzzzzt_ = context.Operators.Where<Encounter>(pzzzzr_, pzzzzs_);
                    object pzzzzu_(Encounter @this)
                    {
                        Period szzzzh_ = @this?.Period;
                        CqlInterval<CqlDateTime> szzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzh_);
                        CqlDateTime szzzzj_ = context.Operators.End(szzzzi_);

                        return szzzzj_;
                    };
                    IEnumerable<Encounter> pzzzzv_ = context.Operators.SortBy<Encounter>(pzzzzt_, pzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter pzzzzw_ = context.Operators.Last<Encounter>(pzzzzv_);
                    Period pzzzzx_ = pzzzzw_?.Period;
                    CqlInterval<CqlDateTime> pzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzx_);
                    CqlDateTime pzzzzz_ = context.Operators.Start(pzzzzy_);
                    Period qzzzza_ = Visit?.Period;
                    CqlInterval<CqlDateTime> qzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzza_);
                    CqlDateTime qzzzzc_ = context.Operators.Start(qzzzzb_);
                    CqlQuantity qzzzzd_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime qzzzze_ = context.Operators.Subtract(pzzzzz_ ?? qzzzzc_, qzzzzd_);
                    IEnumerable<Encounter> qzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? qzzzzh_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> szzzzk_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? szzzzl_ = szzzzk_?.Value;
                        Code<Encounter.EncounterStatus> szzzzm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(szzzzl_);
                        bool? szzzzn_ = context.Operators.Equal(szzzzm_, "finished");
                        Period szzzzo_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> szzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzo_);
                        CqlDateTime szzzzq_ = context.Operators.End(szzzzp_);
                        Period szzzzr_ = Visit?.Period;
                        CqlInterval<CqlDateTime> szzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzr_);
                        CqlDateTime szzzzt_ = context.Operators.Start(szzzzs_);
                        CqlQuantity szzzzu_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime szzzzv_ = context.Operators.Subtract(szzzzt_, szzzzu_);
                        CqlInterval<CqlDateTime> szzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzr_);
                        CqlDateTime szzzzy_ = context.Operators.Start(szzzzx_);
                        CqlInterval<CqlDateTime> szzzzz_ = context.Operators.Interval(szzzzv_, szzzzy_, true, true);
                        bool? tzzzza_ = context.Operators.In<CqlDateTime>(szzzzq_, szzzzz_, default);
                        CqlInterval<CqlDateTime> tzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzr_);
                        CqlDateTime tzzzzd_ = context.Operators.Start(tzzzzc_);
                        bool? tzzzze_ = context.Operators.Not((bool?)(tzzzzd_ is null));
                        bool? tzzzzf_ = context.Operators.And(tzzzza_, tzzzze_);
                        bool? tzzzzg_ = context.Operators.And(szzzzn_, tzzzzf_);

                        return tzzzzg_;
                    };
                    IEnumerable<Encounter> qzzzzi_ = context.Operators.Where<Encounter>(qzzzzg_, qzzzzh_);
                    object qzzzzj_(Encounter @this)
                    {
                        Period tzzzzh_ = @this?.Period;
                        CqlInterval<CqlDateTime> tzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzh_);
                        CqlDateTime tzzzzj_ = context.Operators.End(tzzzzi_);

                        return tzzzzj_;
                    };
                    IEnumerable<Encounter> qzzzzk_ = context.Operators.SortBy<Encounter>(qzzzzi_, qzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter qzzzzl_ = context.Operators.Last<Encounter>(qzzzzk_);
                    Period qzzzzm_ = qzzzzl_?.Period;
                    CqlInterval<CqlDateTime> qzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzm_);
                    CqlDateTime qzzzzo_ = context.Operators.Start(qzzzzn_);
                    CqlInterval<CqlDateTime> qzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzza_);
                    CqlDateTime qzzzzr_ = context.Operators.Start(qzzzzq_);
                    CqlInterval<CqlDateTime> qzzzzs_ = context.Operators.Interval(qzzzze_, qzzzzo_ ?? qzzzzr_, true, true);
                    bool? qzzzzt_ = context.Operators.In<CqlDateTime>(pzzzzp_, qzzzzs_, default);
                    IEnumerable<Encounter> qzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? qzzzzw_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> tzzzzk_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? tzzzzl_ = tzzzzk_?.Value;
                        Code<Encounter.EncounterStatus> tzzzzm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(tzzzzl_);
                        bool? tzzzzn_ = context.Operators.Equal(tzzzzm_, "finished");
                        Period tzzzzo_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> tzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzo_);
                        CqlDateTime tzzzzq_ = context.Operators.End(tzzzzp_);
                        Period tzzzzr_ = Visit?.Period;
                        CqlInterval<CqlDateTime> tzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzr_);
                        CqlDateTime tzzzzt_ = context.Operators.Start(tzzzzs_);
                        CqlQuantity tzzzzu_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime tzzzzv_ = context.Operators.Subtract(tzzzzt_, tzzzzu_);
                        CqlInterval<CqlDateTime> tzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzr_);
                        CqlDateTime tzzzzy_ = context.Operators.Start(tzzzzx_);
                        CqlInterval<CqlDateTime> tzzzzz_ = context.Operators.Interval(tzzzzv_, tzzzzy_, true, true);
                        bool? uzzzza_ = context.Operators.In<CqlDateTime>(tzzzzq_, tzzzzz_, default);
                        CqlInterval<CqlDateTime> uzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzr_);
                        CqlDateTime uzzzzd_ = context.Operators.Start(uzzzzc_);
                        bool? uzzzze_ = context.Operators.Not((bool?)(uzzzzd_ is null));
                        bool? uzzzzf_ = context.Operators.And(uzzzza_, uzzzze_);
                        bool? uzzzzg_ = context.Operators.And(tzzzzn_, uzzzzf_);

                        return uzzzzg_;
                    };
                    IEnumerable<Encounter> qzzzzx_ = context.Operators.Where<Encounter>(qzzzzv_, qzzzzw_);
                    object qzzzzy_(Encounter @this)
                    {
                        Period uzzzzh_ = @this?.Period;
                        CqlInterval<CqlDateTime> uzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzh_);
                        CqlDateTime uzzzzj_ = context.Operators.End(uzzzzi_);

                        return uzzzzj_;
                    };
                    IEnumerable<Encounter> qzzzzz_ = context.Operators.SortBy<Encounter>(qzzzzx_, qzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter rzzzza_ = context.Operators.Last<Encounter>(qzzzzz_);
                    Period rzzzzb_ = rzzzza_?.Period;
                    CqlInterval<CqlDateTime> rzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzb_);
                    CqlDateTime rzzzzd_ = context.Operators.Start(rzzzzc_);
                    CqlInterval<CqlDateTime> rzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzza_);
                    CqlDateTime rzzzzg_ = context.Operators.Start(rzzzzf_);
                    bool? rzzzzh_ = context.Operators.Not((bool?)((rzzzzd_ ?? rzzzzg_) is null));
                    bool? rzzzzi_ = context.Operators.And(qzzzzt_, rzzzzh_);
                    bool? rzzzzj_ = context.Operators.And(pzzzzm_, rzzzzi_);

                    return rzzzzj_;
                };
                IEnumerable<Encounter> czzzzf_ = context.Operators.Where<Encounter>(czzzzd_, czzzze_);
                object czzzzg_(Encounter @this)
                {
                    Period uzzzzk_ = @this?.Period;
                    CqlInterval<CqlDateTime> uzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzk_);
                    CqlDateTime uzzzzm_ = context.Operators.End(uzzzzl_);

                    return uzzzzm_;
                };
                IEnumerable<Encounter> czzzzh_ = context.Operators.SortBy<Encounter>(czzzzf_, czzzzg_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter czzzzi_ = context.Operators.Last<Encounter>(czzzzh_);
                Period czzzzj_ = czzzzi_?.Period;
                CqlInterval<CqlDateTime> czzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzj_);
                CqlDateTime czzzzl_ = context.Operators.Start(czzzzk_);
                IEnumerable<Encounter> czzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? czzzzo_(Encounter LastObs)
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
                IEnumerable<Encounter> czzzzp_ = context.Operators.Where<Encounter>(czzzzn_, czzzzo_);
                object czzzzq_(Encounter @this)
                {
                    Period vzzzzk_ = @this?.Period;
                    CqlInterval<CqlDateTime> vzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzk_);
                    CqlDateTime vzzzzm_ = context.Operators.End(vzzzzl_);

                    return vzzzzm_;
                };
                IEnumerable<Encounter> czzzzr_ = context.Operators.SortBy<Encounter>(czzzzp_, czzzzq_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter czzzzs_ = context.Operators.Last<Encounter>(czzzzr_);
                Period czzzzt_ = czzzzs_?.Period;
                CqlInterval<CqlDateTime> czzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzt_);
                CqlDateTime czzzzv_ = context.Operators.Start(czzzzu_);
                CqlInterval<CqlDateTime> czzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzy_);
                CqlDateTime czzzzy_ = context.Operators.Start(czzzzx_);
                bool? czzzzz_ = context.Operators.Not((bool?)((czzzzl_ ?? czzzzv_ ?? czzzzy_) is null));
                bool? dzzzza_ = context.Operators.And(czzzzb_, czzzzz_);

                return dzzzza_;
            };
            IEnumerable<Encounter> yzzzt_ = context.Operators.Where<Encounter>(yzzzr_, yzzzs_);
            object yzzzu_(Encounter @this)
            {
                Period vzzzzn_ = @this?.Period;
                CqlInterval<CqlDateTime> vzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzn_);
                CqlDateTime vzzzzp_ = context.Operators.End(vzzzzo_);

                return vzzzzp_;
            };
            IEnumerable<Encounter> yzzzv_ = context.Operators.SortBy<Encounter>(yzzzt_, yzzzu_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter yzzzw_ = context.Operators.Last<Encounter>(yzzzv_);
            Period yzzzx_ = yzzzw_?.Period;
            CqlInterval<CqlDateTime> yzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzx_);
            CqlDateTime yzzzz_ = context.Operators.Start(yzzzy_);
            CqlValueSet zzzza_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> zzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? zzzzc_(Encounter LastED)
            {
                Code<Encounter.EncounterStatus> vzzzzq_ = LastED?.StatusElement;
                Encounter.EncounterStatus? vzzzzr_ = vzzzzq_?.Value;
                Code<Encounter.EncounterStatus> vzzzzs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(vzzzzr_);
                bool? vzzzzt_ = context.Operators.Equal(vzzzzs_, "finished");
                Period vzzzzu_ = LastED?.Period;
                CqlInterval<CqlDateTime> vzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzu_);
                CqlDateTime vzzzzw_ = context.Operators.End(vzzzzv_);
                CqlValueSet vzzzzx_ = this.Observation_Services(context);
                IEnumerable<Encounter> vzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? vzzzzz_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> xzzzzr_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? xzzzzs_ = xzzzzr_?.Value;
                    Code<Encounter.EncounterStatus> xzzzzt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(xzzzzs_);
                    bool? xzzzzu_ = context.Operators.Equal(xzzzzt_, "finished");
                    Period xzzzzv_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> xzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzv_);
                    CqlDateTime xzzzzx_ = context.Operators.End(xzzzzw_);
                    Period xzzzzy_ = Visit?.Period;
                    CqlInterval<CqlDateTime> xzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzy_);
                    CqlDateTime yzzzza_ = context.Operators.Start(xzzzzz_);
                    CqlQuantity yzzzzb_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime yzzzzc_ = context.Operators.Subtract(yzzzza_, yzzzzb_);
                    CqlInterval<CqlDateTime> yzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzy_);
                    CqlDateTime yzzzzf_ = context.Operators.Start(yzzzze_);
                    CqlInterval<CqlDateTime> yzzzzg_ = context.Operators.Interval(yzzzzc_, yzzzzf_, true, true);
                    bool? yzzzzh_ = context.Operators.In<CqlDateTime>(xzzzzx_, yzzzzg_, default);
                    CqlInterval<CqlDateTime> yzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzy_);
                    CqlDateTime yzzzzk_ = context.Operators.Start(yzzzzj_);
                    bool? yzzzzl_ = context.Operators.Not((bool?)(yzzzzk_ is null));
                    bool? yzzzzm_ = context.Operators.And(yzzzzh_, yzzzzl_);
                    bool? yzzzzn_ = context.Operators.And(xzzzzu_, yzzzzm_);

                    return yzzzzn_;
                };
                IEnumerable<Encounter> wzzzza_ = context.Operators.Where<Encounter>(vzzzzy_, vzzzzz_);
                object wzzzzb_(Encounter @this)
                {
                    Period yzzzzo_ = @this?.Period;
                    CqlInterval<CqlDateTime> yzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzo_);
                    CqlDateTime yzzzzq_ = context.Operators.End(yzzzzp_);

                    return yzzzzq_;
                };
                IEnumerable<Encounter> wzzzzc_ = context.Operators.SortBy<Encounter>(wzzzza_, wzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter wzzzzd_ = context.Operators.Last<Encounter>(wzzzzc_);
                Period wzzzze_ = wzzzzd_?.Period;
                CqlInterval<CqlDateTime> wzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzze_);
                CqlDateTime wzzzzg_ = context.Operators.Start(wzzzzf_);
                Period wzzzzh_ = Visit?.Period;
                CqlInterval<CqlDateTime> wzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzh_);
                CqlDateTime wzzzzj_ = context.Operators.Start(wzzzzi_);
                CqlQuantity wzzzzk_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime wzzzzl_ = context.Operators.Subtract(wzzzzg_ ?? wzzzzj_, wzzzzk_);
                IEnumerable<Encounter> wzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? wzzzzo_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> yzzzzr_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? yzzzzs_ = yzzzzr_?.Value;
                    Code<Encounter.EncounterStatus> yzzzzt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(yzzzzs_);
                    bool? yzzzzu_ = context.Operators.Equal(yzzzzt_, "finished");
                    Period yzzzzv_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> yzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzv_);
                    CqlDateTime yzzzzx_ = context.Operators.End(yzzzzw_);
                    Period yzzzzy_ = Visit?.Period;
                    CqlInterval<CqlDateTime> yzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzy_);
                    CqlDateTime zzzzza_ = context.Operators.Start(yzzzzz_);
                    CqlQuantity zzzzzb_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime zzzzzc_ = context.Operators.Subtract(zzzzza_, zzzzzb_);
                    CqlInterval<CqlDateTime> zzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzy_);
                    CqlDateTime zzzzzf_ = context.Operators.Start(zzzzze_);
                    CqlInterval<CqlDateTime> zzzzzg_ = context.Operators.Interval(zzzzzc_, zzzzzf_, true, true);
                    bool? zzzzzh_ = context.Operators.In<CqlDateTime>(yzzzzx_, zzzzzg_, default);
                    CqlInterval<CqlDateTime> zzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzy_);
                    CqlDateTime zzzzzk_ = context.Operators.Start(zzzzzj_);
                    bool? zzzzzl_ = context.Operators.Not((bool?)(zzzzzk_ is null));
                    bool? zzzzzm_ = context.Operators.And(zzzzzh_, zzzzzl_);
                    bool? zzzzzn_ = context.Operators.And(yzzzzu_, zzzzzm_);

                    return zzzzzn_;
                };
                IEnumerable<Encounter> wzzzzp_ = context.Operators.Where<Encounter>(wzzzzn_, wzzzzo_);
                object wzzzzq_(Encounter @this)
                {
                    Period zzzzzo_ = @this?.Period;
                    CqlInterval<CqlDateTime> zzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzo_);
                    CqlDateTime zzzzzq_ = context.Operators.End(zzzzzp_);

                    return zzzzzq_;
                };
                IEnumerable<Encounter> wzzzzr_ = context.Operators.SortBy<Encounter>(wzzzzp_, wzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter wzzzzs_ = context.Operators.Last<Encounter>(wzzzzr_);
                Period wzzzzt_ = wzzzzs_?.Period;
                CqlInterval<CqlDateTime> wzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzt_);
                CqlDateTime wzzzzv_ = context.Operators.Start(wzzzzu_);
                CqlInterval<CqlDateTime> wzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzh_);
                CqlDateTime wzzzzy_ = context.Operators.Start(wzzzzx_);
                CqlInterval<CqlDateTime> wzzzzz_ = context.Operators.Interval(wzzzzl_, wzzzzv_ ?? wzzzzy_, true, true);
                bool? xzzzza_ = context.Operators.In<CqlDateTime>(vzzzzw_, wzzzzz_, default);
                IEnumerable<Encounter> xzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? xzzzzd_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> zzzzzr_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? zzzzzs_ = zzzzzr_?.Value;
                    Code<Encounter.EncounterStatus> zzzzzt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(zzzzzs_);
                    bool? zzzzzu_ = context.Operators.Equal(zzzzzt_, "finished");
                    Period zzzzzv_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> zzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzv_);
                    CqlDateTime zzzzzx_ = context.Operators.End(zzzzzw_);
                    Period zzzzzy_ = Visit?.Period;
                    CqlInterval<CqlDateTime> zzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzy_);
                    CqlDateTime azzzzza_ = context.Operators.Start(zzzzzz_);
                    CqlQuantity azzzzzb_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime azzzzzc_ = context.Operators.Subtract(azzzzza_, azzzzzb_);
                    CqlInterval<CqlDateTime> azzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzy_);
                    CqlDateTime azzzzzf_ = context.Operators.Start(azzzzze_);
                    CqlInterval<CqlDateTime> azzzzzg_ = context.Operators.Interval(azzzzzc_, azzzzzf_, true, true);
                    bool? azzzzzh_ = context.Operators.In<CqlDateTime>(zzzzzx_, azzzzzg_, default);
                    CqlInterval<CqlDateTime> azzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzy_);
                    CqlDateTime azzzzzk_ = context.Operators.Start(azzzzzj_);
                    bool? azzzzzl_ = context.Operators.Not((bool?)(azzzzzk_ is null));
                    bool? azzzzzm_ = context.Operators.And(azzzzzh_, azzzzzl_);
                    bool? azzzzzn_ = context.Operators.And(zzzzzu_, azzzzzm_);

                    return azzzzzn_;
                };
                IEnumerable<Encounter> xzzzze_ = context.Operators.Where<Encounter>(xzzzzc_, xzzzzd_);
                object xzzzzf_(Encounter @this)
                {
                    Period azzzzzo_ = @this?.Period;
                    CqlInterval<CqlDateTime> azzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzo_);
                    CqlDateTime azzzzzq_ = context.Operators.End(azzzzzp_);

                    return azzzzzq_;
                };
                IEnumerable<Encounter> xzzzzg_ = context.Operators.SortBy<Encounter>(xzzzze_, xzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter xzzzzh_ = context.Operators.Last<Encounter>(xzzzzg_);
                Period xzzzzi_ = xzzzzh_?.Period;
                CqlInterval<CqlDateTime> xzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzi_);
                CqlDateTime xzzzzk_ = context.Operators.Start(xzzzzj_);
                CqlInterval<CqlDateTime> xzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzh_);
                CqlDateTime xzzzzn_ = context.Operators.Start(xzzzzm_);
                bool? xzzzzo_ = context.Operators.Not((bool?)((xzzzzk_ ?? xzzzzn_) is null));
                bool? xzzzzp_ = context.Operators.And(xzzzza_, xzzzzo_);
                bool? xzzzzq_ = context.Operators.And(vzzzzt_, xzzzzp_);

                return xzzzzq_;
            };
            IEnumerable<Encounter> zzzzd_ = context.Operators.Where<Encounter>(zzzzb_, zzzzc_);
            object zzzze_(Encounter @this)
            {
                Period azzzzzr_ = @this?.Period;
                CqlInterval<CqlDateTime> azzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzr_);
                CqlDateTime azzzzzt_ = context.Operators.End(azzzzzs_);

                return azzzzzt_;
            };
            IEnumerable<Encounter> zzzzf_ = context.Operators.SortBy<Encounter>(zzzzd_, zzzze_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter zzzzg_ = context.Operators.Last<Encounter>(zzzzf_);
            Period zzzzh_ = zzzzg_?.Period;
            CqlInterval<CqlDateTime> zzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzh_);
            CqlDateTime zzzzj_ = context.Operators.Start(zzzzi_);
            CqlValueSet zzzzk_ = this.Observation_Services(context);
            IEnumerable<Encounter> zzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? zzzzm_(Encounter LastObs)
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
            IEnumerable<Encounter> zzzzn_ = context.Operators.Where<Encounter>(zzzzl_, zzzzm_);
            object zzzzo_(Encounter @this)
            {
                Period bzzzzzr_ = @this?.Period;
                CqlInterval<CqlDateTime> bzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzr_);
                CqlDateTime bzzzzzt_ = context.Operators.End(bzzzzzs_);

                return bzzzzzt_;
            };
            IEnumerable<Encounter> zzzzp_ = context.Operators.SortBy<Encounter>(zzzzn_, zzzzo_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter zzzzq_ = context.Operators.Last<Encounter>(zzzzp_);
            Period zzzzr_ = zzzzq_?.Period;
            CqlInterval<CqlDateTime> zzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzr_);
            CqlDateTime zzzzt_ = context.Operators.Start(zzzzs_);
            Period zzzzu_ = Visit?.Period;
            CqlInterval<CqlDateTime> zzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzu_);
            CqlDateTime zzzzw_ = context.Operators.Start(zzzzv_);
            CqlInterval<CqlDateTime> zzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzu_);
            CqlDateTime zzzzz_ = context.Operators.End(zzzzy_);
            CqlInterval<CqlDateTime> azzzza_ = context.Operators.Interval(yzzzz_ ?? zzzzj_ ?? zzzzt_ ?? zzzzw_, zzzzz_, true, true);

            return azzzza_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> yzzzn_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)yzzzl_, yzzzm_);
        IEnumerable<CqlInterval<CqlDateTime>> yzzzo_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(yzzzn_);
        CqlInterval<CqlDateTime> yzzzp_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(yzzzo_);

        return yzzzp_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservation")]
    [CqlTag("description", "Hospitalization with Observation returns the total interval from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationWithObservation()` instead.")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] bzzzzzu_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> bzzzzzv_(Encounter Visit)
        {
            CqlValueSet bzzzzzz_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> czzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? czzzzzb_(Encounter LastED)
            {
                Code<Encounter.EncounterStatus> dzzzzza_ = LastED?.StatusElement;
                Encounter.EncounterStatus? dzzzzzb_ = dzzzzza_?.Value;
                Code<Encounter.EncounterStatus> dzzzzzc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dzzzzzb_);
                bool? dzzzzzd_ = context.Operators.Equal(dzzzzzc_, "finished");
                Period dzzzzze_ = LastED?.Period;
                CqlInterval<CqlDateTime> dzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzze_);
                CqlDateTime dzzzzzg_ = context.Operators.End(dzzzzzf_);
                CqlValueSet dzzzzzh_ = this.Observation_Services(context);
                IEnumerable<Encounter> dzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? dzzzzzj_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> fzzzzzb_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? fzzzzzc_ = fzzzzzb_?.Value;
                    Code<Encounter.EncounterStatus> fzzzzzd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fzzzzzc_);
                    bool? fzzzzze_ = context.Operators.Equal(fzzzzzd_, "finished");
                    Period fzzzzzf_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> fzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzf_);
                    CqlDateTime fzzzzzh_ = context.Operators.End(fzzzzzg_);
                    Period fzzzzzi_ = Visit?.Period;
                    CqlInterval<CqlDateTime> fzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzi_);
                    CqlDateTime fzzzzzk_ = context.Operators.Start(fzzzzzj_);
                    CqlQuantity fzzzzzl_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime fzzzzzm_ = context.Operators.Subtract(fzzzzzk_, fzzzzzl_);
                    CqlInterval<CqlDateTime> fzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzi_);
                    CqlDateTime fzzzzzp_ = context.Operators.Start(fzzzzzo_);
                    CqlInterval<CqlDateTime> fzzzzzq_ = context.Operators.Interval(fzzzzzm_, fzzzzzp_, true, true);
                    bool? fzzzzzr_ = context.Operators.In<CqlDateTime>(fzzzzzh_, fzzzzzq_, default);
                    CqlInterval<CqlDateTime> fzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzi_);
                    CqlDateTime fzzzzzu_ = context.Operators.Start(fzzzzzt_);
                    bool? fzzzzzv_ = context.Operators.Not((bool?)(fzzzzzu_ is null));
                    bool? fzzzzzw_ = context.Operators.And(fzzzzzr_, fzzzzzv_);
                    bool? fzzzzzx_ = context.Operators.And(fzzzzze_, fzzzzzw_);

                    return fzzzzzx_;
                };
                IEnumerable<Encounter> dzzzzzk_ = context.Operators.Where<Encounter>(dzzzzzi_, dzzzzzj_);
                object dzzzzzl_(Encounter @this)
                {
                    Period fzzzzzy_ = @this?.Period;
                    CqlInterval<CqlDateTime> fzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzy_);
                    CqlDateTime gzzzzza_ = context.Operators.End(fzzzzzz_);

                    return gzzzzza_;
                };
                IEnumerable<Encounter> dzzzzzm_ = context.Operators.SortBy<Encounter>(dzzzzzk_, dzzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter dzzzzzn_ = context.Operators.Last<Encounter>(dzzzzzm_);
                Period dzzzzzo_ = dzzzzzn_?.Period;
                CqlInterval<CqlDateTime> dzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzo_);
                CqlDateTime dzzzzzq_ = context.Operators.Start(dzzzzzp_);
                Period dzzzzzr_ = Visit?.Period;
                CqlInterval<CqlDateTime> dzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzr_);
                CqlDateTime dzzzzzt_ = context.Operators.Start(dzzzzzs_);
                CqlQuantity dzzzzzu_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime dzzzzzv_ = context.Operators.Subtract(dzzzzzq_ ?? dzzzzzt_, dzzzzzu_);
                IEnumerable<Encounter> dzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? dzzzzzy_(Encounter LastObs)
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
                IEnumerable<Encounter> dzzzzzz_ = context.Operators.Where<Encounter>(dzzzzzx_, dzzzzzy_);
                object ezzzzza_(Encounter @this)
                {
                    Period gzzzzzy_ = @this?.Period;
                    CqlInterval<CqlDateTime> gzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzy_);
                    CqlDateTime hzzzzza_ = context.Operators.End(gzzzzzz_);

                    return hzzzzza_;
                };
                IEnumerable<Encounter> ezzzzzb_ = context.Operators.SortBy<Encounter>(dzzzzzz_, ezzzzza_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter ezzzzzc_ = context.Operators.Last<Encounter>(ezzzzzb_);
                Period ezzzzzd_ = ezzzzzc_?.Period;
                CqlInterval<CqlDateTime> ezzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzd_);
                CqlDateTime ezzzzzf_ = context.Operators.Start(ezzzzze_);
                CqlInterval<CqlDateTime> ezzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzr_);
                CqlDateTime ezzzzzi_ = context.Operators.Start(ezzzzzh_);
                CqlInterval<CqlDateTime> ezzzzzj_ = context.Operators.Interval(dzzzzzv_, ezzzzzf_ ?? ezzzzzi_, true, true);
                bool? ezzzzzk_ = context.Operators.In<CqlDateTime>(dzzzzzg_, ezzzzzj_, default);
                IEnumerable<Encounter> ezzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? ezzzzzn_(Encounter LastObs)
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
                IEnumerable<Encounter> ezzzzzo_ = context.Operators.Where<Encounter>(ezzzzzm_, ezzzzzn_);
                object ezzzzzp_(Encounter @this)
                {
                    Period hzzzzzy_ = @this?.Period;
                    CqlInterval<CqlDateTime> hzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzy_);
                    CqlDateTime izzzzza_ = context.Operators.End(hzzzzzz_);

                    return izzzzza_;
                };
                IEnumerable<Encounter> ezzzzzq_ = context.Operators.SortBy<Encounter>(ezzzzzo_, ezzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter ezzzzzr_ = context.Operators.Last<Encounter>(ezzzzzq_);
                Period ezzzzzs_ = ezzzzzr_?.Period;
                CqlInterval<CqlDateTime> ezzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzs_);
                CqlDateTime ezzzzzu_ = context.Operators.Start(ezzzzzt_);
                CqlInterval<CqlDateTime> ezzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzr_);
                CqlDateTime ezzzzzx_ = context.Operators.Start(ezzzzzw_);
                bool? ezzzzzy_ = context.Operators.Not((bool?)((ezzzzzu_ ?? ezzzzzx_) is null));
                bool? ezzzzzz_ = context.Operators.And(ezzzzzk_, ezzzzzy_);
                bool? fzzzzza_ = context.Operators.And(dzzzzzd_, ezzzzzz_);

                return fzzzzza_;
            };
            IEnumerable<Encounter> czzzzzc_ = context.Operators.Where<Encounter>(czzzzza_, czzzzzb_);
            object czzzzzd_(Encounter @this)
            {
                Period izzzzzb_ = @this?.Period;
                CqlInterval<CqlDateTime> izzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzb_);
                CqlDateTime izzzzzd_ = context.Operators.End(izzzzzc_);

                return izzzzzd_;
            };
            IEnumerable<Encounter> czzzzze_ = context.Operators.SortBy<Encounter>(czzzzzc_, czzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter czzzzzf_ = context.Operators.Last<Encounter>(czzzzze_);
            Period czzzzzg_ = czzzzzf_?.Period;
            CqlInterval<CqlDateTime> czzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzg_);
            CqlDateTime czzzzzi_ = context.Operators.Start(czzzzzh_);
            CqlValueSet czzzzzj_ = this.Observation_Services(context);
            IEnumerable<Encounter> czzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? czzzzzl_(Encounter LastObs)
            {
                Code<Encounter.EncounterStatus> izzzzze_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? izzzzzf_ = izzzzze_?.Value;
                Code<Encounter.EncounterStatus> izzzzzg_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(izzzzzf_);
                bool? izzzzzh_ = context.Operators.Equal(izzzzzg_, "finished");
                Period izzzzzi_ = LastObs?.Period;
                CqlInterval<CqlDateTime> izzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzi_);
                CqlDateTime izzzzzk_ = context.Operators.End(izzzzzj_);
                Period izzzzzl_ = Visit?.Period;
                CqlInterval<CqlDateTime> izzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzl_);
                CqlDateTime izzzzzn_ = context.Operators.Start(izzzzzm_);
                CqlQuantity izzzzzo_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime izzzzzp_ = context.Operators.Subtract(izzzzzn_, izzzzzo_);
                CqlInterval<CqlDateTime> izzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzl_);
                CqlDateTime izzzzzs_ = context.Operators.Start(izzzzzr_);
                CqlInterval<CqlDateTime> izzzzzt_ = context.Operators.Interval(izzzzzp_, izzzzzs_, true, true);
                bool? izzzzzu_ = context.Operators.In<CqlDateTime>(izzzzzk_, izzzzzt_, default);
                CqlInterval<CqlDateTime> izzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzl_);
                CqlDateTime izzzzzx_ = context.Operators.Start(izzzzzw_);
                bool? izzzzzy_ = context.Operators.Not((bool?)(izzzzzx_ is null));
                bool? izzzzzz_ = context.Operators.And(izzzzzu_, izzzzzy_);
                bool? jzzzzza_ = context.Operators.And(izzzzzh_, izzzzzz_);

                return jzzzzza_;
            };
            IEnumerable<Encounter> czzzzzm_ = context.Operators.Where<Encounter>(czzzzzk_, czzzzzl_);
            object czzzzzn_(Encounter @this)
            {
                Period jzzzzzb_ = @this?.Period;
                CqlInterval<CqlDateTime> jzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzb_);
                CqlDateTime jzzzzzd_ = context.Operators.End(jzzzzzc_);

                return jzzzzzd_;
            };
            IEnumerable<Encounter> czzzzzo_ = context.Operators.SortBy<Encounter>(czzzzzm_, czzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter czzzzzp_ = context.Operators.Last<Encounter>(czzzzzo_);
            Period czzzzzq_ = czzzzzp_?.Period;
            CqlInterval<CqlDateTime> czzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzq_);
            CqlDateTime czzzzzs_ = context.Operators.Start(czzzzzr_);
            Period czzzzzt_ = Visit?.Period;
            CqlInterval<CqlDateTime> czzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzt_);
            CqlDateTime czzzzzv_ = context.Operators.Start(czzzzzu_);
            CqlInterval<CqlDateTime> czzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzt_);
            CqlDateTime czzzzzy_ = context.Operators.End(czzzzzx_);
            CqlInterval<CqlDateTime> czzzzzz_ = context.Operators.Interval(czzzzzi_ ?? czzzzzs_ ?? czzzzzv_, czzzzzy_, true, true);

            return czzzzzz_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> bzzzzzw_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)bzzzzzu_, bzzzzzv_);
        IEnumerable<CqlInterval<CqlDateTime>> bzzzzzx_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(bzzzzzw_);
        CqlInterval<CqlDateTime> bzzzzzy_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(bzzzzzx_);

        return bzzzzzy_;
    }


    [CqlExpressionDefinition("hospitalizationWithObservation")]
    [CqlTag("description", "Hospitalization with Observation returns the total interval from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    public CqlInterval<CqlDateTime> hospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] jzzzzze_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> jzzzzzf_(Encounter Visit)
        {
            CqlValueSet jzzzzzj_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> jzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? jzzzzzl_(Encounter LastED)
            {
                Code<Encounter.EncounterStatus> kzzzzzk_ = LastED?.StatusElement;
                Encounter.EncounterStatus? kzzzzzl_ = kzzzzzk_?.Value;
                Code<Encounter.EncounterStatus> kzzzzzm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(kzzzzzl_);
                bool? kzzzzzn_ = context.Operators.Equal(kzzzzzm_, "finished");
                Period kzzzzzo_ = LastED?.Period;
                CqlInterval<CqlDateTime> kzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzo_);
                CqlDateTime kzzzzzq_ = context.Operators.End(kzzzzzp_);
                CqlValueSet kzzzzzr_ = this.Observation_Services(context);
                IEnumerable<Encounter> kzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? kzzzzzt_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> mzzzzzl_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? mzzzzzm_ = mzzzzzl_?.Value;
                    Code<Encounter.EncounterStatus> mzzzzzn_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(mzzzzzm_);
                    bool? mzzzzzo_ = context.Operators.Equal(mzzzzzn_, "finished");
                    Period mzzzzzp_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> mzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzp_);
                    CqlDateTime mzzzzzr_ = context.Operators.End(mzzzzzq_);
                    Period mzzzzzs_ = Visit?.Period;
                    CqlInterval<CqlDateTime> mzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzs_);
                    CqlDateTime mzzzzzu_ = context.Operators.Start(mzzzzzt_);
                    CqlQuantity mzzzzzv_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime mzzzzzw_ = context.Operators.Subtract(mzzzzzu_, mzzzzzv_);
                    CqlInterval<CqlDateTime> mzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzs_);
                    CqlDateTime mzzzzzz_ = context.Operators.Start(mzzzzzy_);
                    CqlInterval<CqlDateTime> nzzzzza_ = context.Operators.Interval(mzzzzzw_, mzzzzzz_, true, true);
                    bool? nzzzzzb_ = context.Operators.In<CqlDateTime>(mzzzzzr_, nzzzzza_, default);
                    CqlInterval<CqlDateTime> nzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzs_);
                    CqlDateTime nzzzzze_ = context.Operators.Start(nzzzzzd_);
                    bool? nzzzzzf_ = context.Operators.Not((bool?)(nzzzzze_ is null));
                    bool? nzzzzzg_ = context.Operators.And(nzzzzzb_, nzzzzzf_);
                    bool? nzzzzzh_ = context.Operators.And(mzzzzzo_, nzzzzzg_);

                    return nzzzzzh_;
                };
                IEnumerable<Encounter> kzzzzzu_ = context.Operators.Where<Encounter>(kzzzzzs_, kzzzzzt_);
                object kzzzzzv_(Encounter @this)
                {
                    Period nzzzzzi_ = @this?.Period;
                    CqlInterval<CqlDateTime> nzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzi_);
                    CqlDateTime nzzzzzk_ = context.Operators.End(nzzzzzj_);

                    return nzzzzzk_;
                };
                IEnumerable<Encounter> kzzzzzw_ = context.Operators.SortBy<Encounter>(kzzzzzu_, kzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter kzzzzzx_ = context.Operators.Last<Encounter>(kzzzzzw_);
                Period kzzzzzy_ = kzzzzzx_?.Period;
                CqlInterval<CqlDateTime> kzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzy_);
                CqlDateTime lzzzzza_ = context.Operators.Start(kzzzzzz_);
                Period lzzzzzb_ = Visit?.Period;
                CqlInterval<CqlDateTime> lzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzb_);
                CqlDateTime lzzzzzd_ = context.Operators.Start(lzzzzzc_);
                CqlQuantity lzzzzze_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime lzzzzzf_ = context.Operators.Subtract(lzzzzza_ ?? lzzzzzd_, lzzzzze_);
                IEnumerable<Encounter> lzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? lzzzzzi_(Encounter LastObs)
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
                IEnumerable<Encounter> lzzzzzj_ = context.Operators.Where<Encounter>(lzzzzzh_, lzzzzzi_);
                object lzzzzzk_(Encounter @this)
                {
                    Period ozzzzzi_ = @this?.Period;
                    CqlInterval<CqlDateTime> ozzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzi_);
                    CqlDateTime ozzzzzk_ = context.Operators.End(ozzzzzj_);

                    return ozzzzzk_;
                };
                IEnumerable<Encounter> lzzzzzl_ = context.Operators.SortBy<Encounter>(lzzzzzj_, lzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter lzzzzzm_ = context.Operators.Last<Encounter>(lzzzzzl_);
                Period lzzzzzn_ = lzzzzzm_?.Period;
                CqlInterval<CqlDateTime> lzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzn_);
                CqlDateTime lzzzzzp_ = context.Operators.Start(lzzzzzo_);
                CqlInterval<CqlDateTime> lzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzb_);
                CqlDateTime lzzzzzs_ = context.Operators.Start(lzzzzzr_);
                CqlInterval<CqlDateTime> lzzzzzt_ = context.Operators.Interval(lzzzzzf_, lzzzzzp_ ?? lzzzzzs_, true, true);
                bool? lzzzzzu_ = context.Operators.In<CqlDateTime>(kzzzzzq_, lzzzzzt_, default);
                IEnumerable<Encounter> lzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? lzzzzzx_(Encounter LastObs)
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
                IEnumerable<Encounter> lzzzzzy_ = context.Operators.Where<Encounter>(lzzzzzw_, lzzzzzx_);
                object lzzzzzz_(Encounter @this)
                {
                    Period pzzzzzi_ = @this?.Period;
                    CqlInterval<CqlDateTime> pzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzi_);
                    CqlDateTime pzzzzzk_ = context.Operators.End(pzzzzzj_);

                    return pzzzzzk_;
                };
                IEnumerable<Encounter> mzzzzza_ = context.Operators.SortBy<Encounter>(lzzzzzy_, lzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter mzzzzzb_ = context.Operators.Last<Encounter>(mzzzzza_);
                Period mzzzzzc_ = mzzzzzb_?.Period;
                CqlInterval<CqlDateTime> mzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzc_);
                CqlDateTime mzzzzze_ = context.Operators.Start(mzzzzzd_);
                CqlInterval<CqlDateTime> mzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzb_);
                CqlDateTime mzzzzzh_ = context.Operators.Start(mzzzzzg_);
                bool? mzzzzzi_ = context.Operators.Not((bool?)((mzzzzze_ ?? mzzzzzh_) is null));
                bool? mzzzzzj_ = context.Operators.And(lzzzzzu_, mzzzzzi_);
                bool? mzzzzzk_ = context.Operators.And(kzzzzzn_, mzzzzzj_);

                return mzzzzzk_;
            };
            IEnumerable<Encounter> jzzzzzm_ = context.Operators.Where<Encounter>(jzzzzzk_, jzzzzzl_);
            object jzzzzzn_(Encounter @this)
            {
                Period pzzzzzl_ = @this?.Period;
                CqlInterval<CqlDateTime> pzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzl_);
                CqlDateTime pzzzzzn_ = context.Operators.End(pzzzzzm_);

                return pzzzzzn_;
            };
            IEnumerable<Encounter> jzzzzzo_ = context.Operators.SortBy<Encounter>(jzzzzzm_, jzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter jzzzzzp_ = context.Operators.Last<Encounter>(jzzzzzo_);
            Period jzzzzzq_ = jzzzzzp_?.Period;
            CqlInterval<CqlDateTime> jzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzq_);
            CqlDateTime jzzzzzs_ = context.Operators.Start(jzzzzzr_);
            CqlValueSet jzzzzzt_ = this.Observation_Services(context);
            IEnumerable<Encounter> jzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? jzzzzzv_(Encounter LastObs)
            {
                Code<Encounter.EncounterStatus> pzzzzzo_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? pzzzzzp_ = pzzzzzo_?.Value;
                Code<Encounter.EncounterStatus> pzzzzzq_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pzzzzzp_);
                bool? pzzzzzr_ = context.Operators.Equal(pzzzzzq_, "finished");
                Period pzzzzzs_ = LastObs?.Period;
                CqlInterval<CqlDateTime> pzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzs_);
                CqlDateTime pzzzzzu_ = context.Operators.End(pzzzzzt_);
                Period pzzzzzv_ = Visit?.Period;
                CqlInterval<CqlDateTime> pzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzv_);
                CqlDateTime pzzzzzx_ = context.Operators.Start(pzzzzzw_);
                CqlQuantity pzzzzzy_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime pzzzzzz_ = context.Operators.Subtract(pzzzzzx_, pzzzzzy_);
                CqlInterval<CqlDateTime> qzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzv_);
                CqlDateTime qzzzzzc_ = context.Operators.Start(qzzzzzb_);
                CqlInterval<CqlDateTime> qzzzzzd_ = context.Operators.Interval(pzzzzzz_, qzzzzzc_, true, true);
                bool? qzzzzze_ = context.Operators.In<CqlDateTime>(pzzzzzu_, qzzzzzd_, default);
                CqlInterval<CqlDateTime> qzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzv_);
                CqlDateTime qzzzzzh_ = context.Operators.Start(qzzzzzg_);
                bool? qzzzzzi_ = context.Operators.Not((bool?)(qzzzzzh_ is null));
                bool? qzzzzzj_ = context.Operators.And(qzzzzze_, qzzzzzi_);
                bool? qzzzzzk_ = context.Operators.And(pzzzzzr_, qzzzzzj_);

                return qzzzzzk_;
            };
            IEnumerable<Encounter> jzzzzzw_ = context.Operators.Where<Encounter>(jzzzzzu_, jzzzzzv_);
            object jzzzzzx_(Encounter @this)
            {
                Period qzzzzzl_ = @this?.Period;
                CqlInterval<CqlDateTime> qzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzl_);
                CqlDateTime qzzzzzn_ = context.Operators.End(qzzzzzm_);

                return qzzzzzn_;
            };
            IEnumerable<Encounter> jzzzzzy_ = context.Operators.SortBy<Encounter>(jzzzzzw_, jzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter jzzzzzz_ = context.Operators.Last<Encounter>(jzzzzzy_);
            Period kzzzzza_ = jzzzzzz_?.Period;
            CqlInterval<CqlDateTime> kzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzza_);
            CqlDateTime kzzzzzc_ = context.Operators.Start(kzzzzzb_);
            Period kzzzzzd_ = Visit?.Period;
            CqlInterval<CqlDateTime> kzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzd_);
            CqlDateTime kzzzzzf_ = context.Operators.Start(kzzzzze_);
            CqlInterval<CqlDateTime> kzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzd_);
            CqlDateTime kzzzzzi_ = context.Operators.End(kzzzzzh_);
            CqlInterval<CqlDateTime> kzzzzzj_ = context.Operators.Interval(jzzzzzs_ ?? kzzzzzc_ ?? kzzzzzf_, kzzzzzi_, true, true);

            return kzzzzzj_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> jzzzzzg_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)jzzzzze_, jzzzzzf_);
        IEnumerable<CqlInterval<CqlDateTime>> jzzzzzh_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(jzzzzzg_);
        CqlInterval<CqlDateTime> jzzzzzi_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(jzzzzzh_);

        return jzzzzzi_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservationLengthofStay")]
    [CqlTag("description", "Hospitalization with Observation Length of Stay returns the length in days from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationWithObservationLengthofStay()` instead.")]
    public int? HospitalizationWithObservationLengthofStay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> qzzzzzo_ = this.HospitalizationWithObservation(context, TheEncounter);
        int? qzzzzzp_ = this.LengthInDays(context, qzzzzzo_);

        return qzzzzzp_;
    }


    [CqlExpressionDefinition("hospitalizationWithObservationLengthofStay")]
    [CqlTag("description", "Hospitalization with Observation Length of Stay returns the length in days from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    public int? hospitalizationWithObservationLengthofStay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> qzzzzzq_ = this.hospitalizationWithObservation(context, TheEncounter);
        int? qzzzzzr_ = this.lengthInDays(context, qzzzzzq_);

        return qzzzzzr_;
    }


    [CqlExpressionDefinition("FirstInpatientIntensiveCareUnit")]
    [CqlTag("description", "First Inpatient Intensive Care Unit returns the first intensive care unit for the given encounter, without considering any immediately prior emergency department visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `firstInpatientIntensiveCareUnit()` instead.")]
    public Encounter.LocationComponent FirstInpatientIntensiveCareUnit(CqlContext context, Encounter Encounter)
    {
        List<Encounter.LocationComponent> qzzzzzs_ = Encounter?.Location;
        bool? qzzzzzt_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference qzzzzzy_ = HospitalLocation?.Location;
            Location qzzzzzz_ = this.GetLocation(context, qzzzzzy_);
            List<CodeableConcept> rzzzzza_ = qzzzzzz_?.Type;
            CqlConcept rzzzzzb_(CodeableConcept @this)
            {
                CqlConcept rzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return rzzzzzl_;
            };
            IEnumerable<CqlConcept> rzzzzzc_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)rzzzzza_, rzzzzzb_);
            CqlValueSet rzzzzzd_ = this.Intensive_Care_Unit(context);
            bool? rzzzzze_ = context.Operators.ConceptsInValueSet(rzzzzzc_, rzzzzzd_);
            Period rzzzzzf_ = Encounter?.Period;
            CqlInterval<CqlDateTime> rzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzf_);
            Period rzzzzzh_ = HospitalLocation?.Period;
            CqlInterval<CqlDateTime> rzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzh_);
            bool? rzzzzzj_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(rzzzzzg_, rzzzzzi_, default);
            bool? rzzzzzk_ = context.Operators.And(rzzzzze_, rzzzzzj_);

            return rzzzzzk_;
        };
        IEnumerable<Encounter.LocationComponent> qzzzzzu_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)qzzzzzs_, qzzzzzt_);
        object qzzzzzv_(Encounter.LocationComponent @this)
        {
            Period rzzzzzm_ = @this?.Period;
            CqlInterval<CqlDateTime> rzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzm_);
            CqlDateTime rzzzzzo_ = context.Operators.Start(rzzzzzn_);

            return rzzzzzo_;
        };
        IEnumerable<Encounter.LocationComponent> qzzzzzw_ = context.Operators.SortBy<Encounter.LocationComponent>(qzzzzzu_, qzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent qzzzzzx_ = context.Operators.First<Encounter.LocationComponent>(qzzzzzw_);

        return qzzzzzx_;
    }


    [CqlExpressionDefinition("firstInpatientIntensiveCareUnit")]
    [CqlTag("description", "First Inpatient Intensive Care Unit returns the first intensive care unit for the given encounter, without considering any immediately prior emergency department visit.")]
    public Encounter.LocationComponent firstInpatientIntensiveCareUnit(CqlContext context, Encounter Encounter)
    {
        List<Encounter.LocationComponent> rzzzzzp_ = Encounter?.Location;
        bool? rzzzzzq_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference rzzzzzv_ = HospitalLocation?.Location;
            Location rzzzzzw_ = this.GetLocation(context, rzzzzzv_);
            List<CodeableConcept> rzzzzzx_ = rzzzzzw_?.Type;
            CqlConcept rzzzzzy_(CodeableConcept @this)
            {
                CqlConcept szzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return szzzzzi_;
            };
            IEnumerable<CqlConcept> rzzzzzz_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)rzzzzzx_, rzzzzzy_);
            CqlValueSet szzzzza_ = this.Intensive_Care_Unit(context);
            bool? szzzzzb_ = context.Operators.ConceptsInValueSet(rzzzzzz_, szzzzza_);
            Period szzzzzc_ = Encounter?.Period;
            CqlInterval<CqlDateTime> szzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzc_);
            Period szzzzze_ = HospitalLocation?.Period;
            CqlInterval<CqlDateTime> szzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzze_);
            bool? szzzzzg_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(szzzzzd_, szzzzzf_, default);
            bool? szzzzzh_ = context.Operators.And(szzzzzb_, szzzzzg_);

            return szzzzzh_;
        };
        IEnumerable<Encounter.LocationComponent> rzzzzzr_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)rzzzzzp_, rzzzzzq_);
        object rzzzzzs_(Encounter.LocationComponent @this)
        {
            Period szzzzzj_ = @this?.Period;
            CqlInterval<CqlDateTime> szzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzj_);
            CqlDateTime szzzzzl_ = context.Operators.Start(szzzzzk_);

            return szzzzzl_;
        };
        IEnumerable<Encounter.LocationComponent> rzzzzzt_ = context.Operators.SortBy<Encounter.LocationComponent>(rzzzzzr_, rzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent rzzzzzu_ = context.Operators.First<Encounter.LocationComponent>(rzzzzzt_);

        return rzzzzzu_;
    }


    [CqlExpressionDefinition("EncounterDiagnosis")]
    [CqlTag("description", "Returns the Condition resource referenced by the `diagnosis.condition` element of the Encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `encounterDiagnosis()` instead.")]
    public IEnumerable<Condition> EncounterDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> szzzzzm_ = Encounter?.Diagnosis;
        Condition szzzzzn_(Encounter.DiagnosisComponent D)
        {
            IEnumerable<Condition> szzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? szzzzzr_(Condition C)
            {
                Id szzzzzu_ = C?.IdElement;
                string szzzzzv_ = szzzzzu_?.Value;
                ResourceReference szzzzzw_ = D?.Condition;
                FhirString szzzzzx_ = szzzzzw_?.ReferenceElement;
                string szzzzzy_ = szzzzzx_?.Value;
                string szzzzzz_ = QICoreCommon_2_1_000.Instance.getId(context, szzzzzy_);
                bool? tzzzzza_ = context.Operators.Equal(szzzzzv_, szzzzzz_);

                return tzzzzza_;
            };
            IEnumerable<Condition> szzzzzs_ = context.Operators.Where<Condition>(szzzzzq_, szzzzzr_);
            Condition szzzzzt_ = context.Operators.SingletonFrom<Condition>(szzzzzs_);

            return szzzzzt_;
        };
        IEnumerable<Condition> szzzzzo_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)szzzzzm_, szzzzzn_);
        IEnumerable<Condition> szzzzzp_ = context.Operators.Distinct<Condition>(szzzzzo_);

        return szzzzzp_;
    }


    [CqlExpressionDefinition("encounterDiagnosis")]
    [CqlTag("description", "Returns the Condition resources referenced by the diagnosis element of the Encounter")]
    public IEnumerable<Condition> encounterDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> tzzzzzb_ = Encounter?.Diagnosis;
        Condition tzzzzzc_(Encounter.DiagnosisComponent D)
        {
            IEnumerable<Condition> tzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? tzzzzzg_(Condition C)
            {
                Id tzzzzzj_ = C?.IdElement;
                string tzzzzzk_ = tzzzzzj_?.Value;
                ResourceReference tzzzzzl_ = D?.Condition;
                FhirString tzzzzzm_ = tzzzzzl_?.ReferenceElement;
                string tzzzzzn_ = tzzzzzm_?.Value;
                string tzzzzzo_ = QICoreCommon_2_1_000.Instance.getId(context, tzzzzzn_);
                bool? tzzzzzp_ = context.Operators.Equal(tzzzzzk_, tzzzzzo_);

                return tzzzzzp_;
            };
            IEnumerable<Condition> tzzzzzh_ = context.Operators.Where<Condition>(tzzzzzf_, tzzzzzg_);
            Condition tzzzzzi_ = context.Operators.SingletonFrom<Condition>(tzzzzzh_);

            return tzzzzzi_;
        };
        IEnumerable<Condition> tzzzzzd_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)tzzzzzb_, tzzzzzc_);
        IEnumerable<Condition> tzzzzze_ = context.Operators.Distinct<Condition>(tzzzzzd_);

        return tzzzzze_;
    }


    [CqlExpressionDefinition("GetCondition")]
    [CqlTag("description", "Returns the Condition resource for the given reference")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getCondition()` instead")]
    public Condition GetCondition(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Condition> tzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? tzzzzzr_(Condition C)
        {
            Id tzzzzzu_ = C?.IdElement;
            string tzzzzzv_ = tzzzzzu_?.Value;
            FhirString tzzzzzw_ = reference?.ReferenceElement;
            string tzzzzzx_ = tzzzzzw_?.Value;
            string tzzzzzy_ = QICoreCommon_2_1_000.Instance.getId(context, tzzzzzx_);
            bool? tzzzzzz_ = context.Operators.Equal(tzzzzzv_, tzzzzzy_);

            return tzzzzzz_;
        };
        IEnumerable<Condition> tzzzzzs_ = context.Operators.Where<Condition>(tzzzzzq_, tzzzzzr_);
        Condition tzzzzzt_ = context.Operators.SingletonFrom<Condition>(tzzzzzs_);

        return tzzzzzt_;
    }


    [CqlExpressionDefinition("getCondition")]
    [CqlTag("description", "Returns the Condition resource for the given reference")]
    public Condition getCondition(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Condition> uzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? uzzzzzb_(Condition C)
        {
            Id uzzzzze_ = C?.IdElement;
            string uzzzzzf_ = uzzzzze_?.Value;
            FhirString uzzzzzg_ = reference?.ReferenceElement;
            string uzzzzzh_ = uzzzzzg_?.Value;
            string uzzzzzi_ = QICoreCommon_2_1_000.Instance.getId(context, uzzzzzh_);
            bool? uzzzzzj_ = context.Operators.Equal(uzzzzzf_, uzzzzzi_);

            return uzzzzzj_;
        };
        IEnumerable<Condition> uzzzzzc_ = context.Operators.Where<Condition>(uzzzzza_, uzzzzzb_);
        Condition uzzzzzd_ = context.Operators.SingletonFrom<Condition>(uzzzzzc_);

        return uzzzzzd_;
    }


    [CqlExpressionDefinition("PrincipalDiagnosis")]
    [CqlTag("description", "Returns the condition that is specified as the principal diagnosis for the encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `principalDiagnosis()` instead.")]
    public Condition PrincipalDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> uzzzzzk_ = Encounter?.Diagnosis;
        bool? uzzzzzl_(Encounter.DiagnosisComponent D)
        {
            PositiveInt uzzzzzr_ = D?.RankElement;
            int? uzzzzzs_ = uzzzzzr_?.Value;
            bool? uzzzzzt_ = context.Operators.Equal(uzzzzzs_, 1);
            CodeableConcept uzzzzzu_ = D?.Use;
            CqlConcept uzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzu_);
            CqlCode uzzzzzw_ = this.Billing(context);
            CqlConcept uzzzzzx_ = context.Operators.ConvertCodeToConcept(uzzzzzw_);
            bool? uzzzzzy_ = context.Operators.Equivalent(uzzzzzv_, uzzzzzx_);
            bool? uzzzzzz_ = context.Operators.And(uzzzzzt_, uzzzzzy_);

            return uzzzzzz_;
        };
        IEnumerable<Encounter.DiagnosisComponent> uzzzzzm_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)uzzzzzk_, uzzzzzl_);
        Condition uzzzzzn_(Encounter.DiagnosisComponent PD)
        {
            IEnumerable<Condition> vzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? vzzzzzb_(Condition C)
            {
                Id vzzzzze_ = C?.IdElement;
                string vzzzzzf_ = vzzzzze_?.Value;
                ResourceReference vzzzzzg_ = PD?.Condition;
                FhirString vzzzzzh_ = vzzzzzg_?.ReferenceElement;
                string vzzzzzi_ = vzzzzzh_?.Value;
                string vzzzzzj_ = QICoreCommon_2_1_000.Instance.getId(context, vzzzzzi_);
                bool? vzzzzzk_ = context.Operators.Equal(vzzzzzf_, vzzzzzj_);

                return vzzzzzk_;
            };
            IEnumerable<Condition> vzzzzzc_ = context.Operators.Where<Condition>(vzzzzza_, vzzzzzb_);
            Condition vzzzzzd_ = context.Operators.SingletonFrom<Condition>(vzzzzzc_);

            return vzzzzzd_;
        };
        IEnumerable<Condition> uzzzzzo_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>(uzzzzzm_, uzzzzzn_);
        IEnumerable<Condition> uzzzzzp_ = context.Operators.Distinct<Condition>(uzzzzzo_);
        Condition uzzzzzq_ = context.Operators.SingletonFrom<Condition>(uzzzzzp_);

        return uzzzzzq_;
    }


    [CqlExpressionDefinition("principalDiagnosis")]
    [CqlTag("description", "Returns the condition that is specified as the principal diagnosis for the encounter")]
    public Condition principalDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> vzzzzzl_ = Encounter?.Diagnosis;
        bool? vzzzzzm_(Encounter.DiagnosisComponent D)
        {
            PositiveInt vzzzzzs_ = D?.RankElement;
            int? vzzzzzt_ = vzzzzzs_?.Value;
            bool? vzzzzzu_ = context.Operators.Equal(vzzzzzt_, 1);
            CodeableConcept vzzzzzv_ = D?.Use;
            CqlConcept vzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzv_);
            CqlCode vzzzzzx_ = this.Billing(context);
            CqlConcept vzzzzzy_ = context.Operators.ConvertCodeToConcept(vzzzzzx_);
            bool? vzzzzzz_ = context.Operators.Equivalent(vzzzzzw_, vzzzzzy_);
            bool? wzzzzza_ = context.Operators.And(vzzzzzu_, vzzzzzz_);

            return wzzzzza_;
        };
        IEnumerable<Encounter.DiagnosisComponent> vzzzzzn_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)vzzzzzl_, vzzzzzm_);
        Condition vzzzzzo_(Encounter.DiagnosisComponent PD)
        {
            IEnumerable<Condition> wzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? wzzzzzc_(Condition C)
            {
                Id wzzzzzf_ = C?.IdElement;
                string wzzzzzg_ = wzzzzzf_?.Value;
                ResourceReference wzzzzzh_ = PD?.Condition;
                FhirString wzzzzzi_ = wzzzzzh_?.ReferenceElement;
                string wzzzzzj_ = wzzzzzi_?.Value;
                string wzzzzzk_ = QICoreCommon_2_1_000.Instance.getId(context, wzzzzzj_);
                bool? wzzzzzl_ = context.Operators.Equal(wzzzzzg_, wzzzzzk_);

                return wzzzzzl_;
            };
            IEnumerable<Condition> wzzzzzd_ = context.Operators.Where<Condition>(wzzzzzb_, wzzzzzc_);
            Condition wzzzzze_ = context.Operators.SingletonFrom<Condition>(wzzzzzd_);

            return wzzzzze_;
        };
        IEnumerable<Condition> vzzzzzp_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>(vzzzzzn_, vzzzzzo_);
        IEnumerable<Condition> vzzzzzq_ = context.Operators.Distinct<Condition>(vzzzzzp_);
        Condition vzzzzzr_ = context.Operators.SingletonFrom<Condition>(vzzzzzq_);

        return vzzzzzr_;
    }


    [CqlExpressionDefinition("getLocation")]
    [CqlTag("description", "Returns the Location resource specified by the given reference.")]
    public Location getLocation(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Location> wzzzzzm_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-location"));
        bool? wzzzzzn_(Location L)
        {
            Id wzzzzzq_ = L?.IdElement;
            string wzzzzzr_ = wzzzzzq_?.Value;
            FhirString wzzzzzs_ = reference?.ReferenceElement;
            string wzzzzzt_ = wzzzzzs_?.Value;
            string wzzzzzu_ = QICoreCommon_2_1_000.Instance.getId(context, wzzzzzt_);
            bool? wzzzzzv_ = context.Operators.Equal(wzzzzzr_, wzzzzzu_);

            return wzzzzzv_;
        };
        IEnumerable<Location> wzzzzzo_ = context.Operators.Where<Location>(wzzzzzm_, wzzzzzn_);
        Location wzzzzzp_ = context.Operators.SingletonFrom<Location>(wzzzzzo_);

        return wzzzzzp_;
    }


    [CqlExpressionDefinition("GetMedicationCode")]
    [CqlTag("description", "Returns the medication code for the given MedicationRequest")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getMedicationCode()` instead.")]
    public CqlConcept GetMedicationCode(CqlContext context, MedicationRequest request)
    {
        CqlConcept wzzzzzw_()
        {
            bool wzzzzzx_()
            {
                DataType wzzzzzy_ = request?.Medication;
                object wzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzy_);
                bool xzzzzza_ = wzzzzzz_ is CqlConcept;

                return xzzzzza_;
            };
            if (wzzzzzx_())
            {
                DataType xzzzzzb_ = request?.Medication;
                object xzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzb_);

                return xzzzzzc_ as CqlConcept;
            }
            else
            {
                IEnumerable<Medication> xzzzzzd_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? xzzzzze_(Medication M)
                {
                    Id xzzzzzj_ = M?.IdElement;
                    string xzzzzzk_ = xzzzzzj_?.Value;
                    DataType xzzzzzl_ = request?.Medication;
                    object xzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzl_);
                    FhirString xzzzzzn_ = (xzzzzzm_ as ResourceReference)?.ReferenceElement;
                    string xzzzzzo_ = xzzzzzn_?.Value;
                    string xzzzzzp_ = QICoreCommon_2_1_000.Instance.getId(context, xzzzzzo_);
                    bool? xzzzzzq_ = context.Operators.Equal(xzzzzzk_, xzzzzzp_);

                    return xzzzzzq_;
                };
                IEnumerable<Medication> xzzzzzf_ = context.Operators.Where<Medication>(xzzzzzd_, xzzzzze_);
                Medication xzzzzzg_ = context.Operators.SingletonFrom<Medication>(xzzzzzf_);
                CodeableConcept xzzzzzh_ = xzzzzzg_?.Code;
                CqlConcept xzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, xzzzzzh_);

                return xzzzzzi_;
            }
        };

        return wzzzzzw_();
    }


    [CqlExpressionDefinition("getMedicationCode")]
    [CqlTag("description", "Returns the medication code for the given MedicationRequest")]
    public CqlConcept getMedicationCode(CqlContext context, MedicationRequest request)
    {
        CqlConcept xzzzzzr_()
        {
            bool xzzzzzs_()
            {
                DataType xzzzzzt_ = request?.Medication;
                object xzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzt_);
                bool xzzzzzv_ = xzzzzzu_ is CqlConcept;

                return xzzzzzv_;
            };
            if (xzzzzzs_())
            {
                DataType xzzzzzw_ = request?.Medication;
                object xzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzw_);

                return xzzzzzx_ as CqlConcept;
            }
            else
            {
                IEnumerable<Medication> xzzzzzy_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? xzzzzzz_(Medication M)
                {
                    Id yzzzzze_ = M?.IdElement;
                    string yzzzzzf_ = yzzzzze_?.Value;
                    DataType yzzzzzg_ = request?.Medication;
                    object yzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzg_);
                    FhirString yzzzzzi_ = (yzzzzzh_ as ResourceReference)?.ReferenceElement;
                    string yzzzzzj_ = yzzzzzi_?.Value;
                    string yzzzzzk_ = QICoreCommon_2_1_000.Instance.getId(context, yzzzzzj_);
                    bool? yzzzzzl_ = context.Operators.Equal(yzzzzzf_, yzzzzzk_);

                    return yzzzzzl_;
                };
                IEnumerable<Medication> yzzzzza_ = context.Operators.Where<Medication>(xzzzzzy_, xzzzzzz_);
                Medication yzzzzzb_ = context.Operators.SingletonFrom<Medication>(yzzzzza_);
                CodeableConcept yzzzzzc_ = yzzzzzb_?.Code;
                CqlConcept yzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzc_);

                return yzzzzzd_;
            }
        };

        return xzzzzzr_();
    }


    #endregion Expressions

}
