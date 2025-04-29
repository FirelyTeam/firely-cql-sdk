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

    #region ValueSet: Emergency Department Visit
    [CqlValueSetDefinition(
        definitionName: "Emergency Department Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292",
        valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Visit(CqlContext context) => _Emergency_Department_Visit;

    private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);
    #endregion

    #region ValueSet: Encounter Inpatient
    [CqlValueSetDefinition(
        definitionName: "Encounter Inpatient",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307",
        valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext context) => _Encounter_Inpatient;

    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);
    #endregion

    #region ValueSet: Intensive Care Unit
    [CqlValueSetDefinition(
        definitionName: "Intensive Care Unit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.206",
        valueSetVersion: null)]
    public CqlValueSet Intensive_Care_Unit(CqlContext context) => _Intensive_Care_Unit;

    private static readonly CqlValueSet _Intensive_Care_Unit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.206", null);
    #endregion

    #region ValueSet: Observation Services
    [CqlValueSetDefinition(
        definitionName: "Observation Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143",
        valueSetVersion: null)]
    public CqlValueSet Observation_Services(CqlContext context) => _Observation_Services;

    private static readonly CqlValueSet _Observation_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);
    #endregion

    #region ValueSet: Outpatient Surgery Service
    [CqlValueSetDefinition(
        definitionName: "Outpatient Surgery Service",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.38",
        valueSetVersion: null)]
    public CqlValueSet Outpatient_Surgery_Service(CqlContext context) => _Outpatient_Surgery_Service;

    private static readonly CqlValueSet _Outpatient_Surgery_Service = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.38", null);
    #endregion

    #region ValueSet: Present on Admission or Clinically Undetermined
    [CqlValueSetDefinition(
        definitionName: "Present on Admission or Clinically Undetermined",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197",
        valueSetVersion: null)]
    public CqlValueSet Present_on_Admission_or_Clinically_Undetermined(CqlContext context) => _Present_on_Admission_or_Clinically_Undetermined;

    private static readonly CqlValueSet _Present_on_Admission_or_Clinically_Undetermined = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Billing
    [CqlCodeDefinition(
        definitionName: "Billing",
        codeId: "billing",
        codeSystem: "http://terminology.hl7.org/CodeSystem/diagnosis-role")]
    public CqlCode Billing(CqlContext context) => _Billing;

    private static readonly CqlCode _Billing = new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "DiagnosisRole")]
    public CqlCode[] DiagnosisRole(CqlContext context)
    {
        CqlCode[] mzze_ = [
            new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
        ];

        return mzze_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime mzzf_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime mzzg_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> mzzh_ = context.Operators.Interval(mzzf_, mzzg_, true, false);
        object mzzi_ = context.ResolveParameter("CQMCommon-2.2.000", "Measurement Period", mzzh_);

        return (CqlInterval<CqlDateTime>)mzzi_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> mzzj_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient mzzk_ = context.Operators.SingletonFrom<Patient>(mzzj_);

        return mzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "Inpatient Encounter")]
    public IEnumerable<Encounter> Inpatient_Encounter(CqlContext context)
    {
        CqlValueSet mzzl_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> mzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? mzzn_(Encounter EncounterInpatient)
        {
            Code<Encounter.EncounterStatus> mzzp_ = EncounterInpatient?.StatusElement;
            Encounter.EncounterStatus? mzzq_ = mzzp_?.Value;
            Code<Encounter.EncounterStatus> mzzr_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(mzzq_);
            bool? mzzs_ = context.Operators.Equal(mzzr_, "finished");
            Period mzzt_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime> mzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzt_);
            CqlDateTime mzzv_ = context.Operators.End(mzzu_);
            CqlInterval<CqlDateTime> mzzw_ = this.Measurement_Period(context);
            bool? mzzx_ = context.Operators.In<CqlDateTime>(mzzv_, mzzw_, "day");
            bool? mzzy_ = context.Operators.And(mzzs_, mzzx_);

            return mzzy_;
        };
        IEnumerable<Encounter> mzzo_ = context.Operators.Where<Encounter>(mzzm_, mzzn_);

        return mzzo_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns an interval of date values extracted from the input interval of date-time values")]
    [CqlTag("comment", "This function returns an interval constructed using the `date from` extractor on the start\nand end values of the input date-time interval. Note that using a precision specifier such as `day of`\nas part of a timing phrase is preferred to communicate intent to perform day-level comparison, as well\nas for general readability.")]
    public CqlInterval<CqlDate> ToDateInterval(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime mzzz_ = context.Operators.Start(period);
        CqlDate nzza_ = context.Operators.DateFrom(mzzz_);
        CqlDateTime nzzb_ = context.Operators.End(period);
        CqlDate nzzc_ = context.Operators.DateFrom(nzzb_);
        CqlInterval<CqlDate> nzzd_ = context.Operators.Interval(nzza_, nzzc_, true, true);

        return nzzd_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Calculates the difference in calendar days between the start and end of the given interval.")]
    [CqlTag("deprecated", "This function in deprecated. Use the fluent function `lengthInDays()` instead.")]
    public int? LengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
    {
        CqlDateTime nzze_ = context.Operators.Start(Value);
        CqlDateTime nzzf_ = context.Operators.End(Value);
        int? nzzg_ = context.Operators.DifferenceBetween(nzze_, nzzf_, "day");

        return nzzg_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Calculates the difference in calendar days between the start and end of the given interval.")]
    public int? lengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
    {
        CqlDateTime nzzh_ = context.Operators.Start(Value);
        CqlDateTime nzzi_ = context.Operators.End(Value);
        int? nzzj_ = context.Operators.DifferenceBetween(nzzh_, nzzi_, "day");

        return nzzj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns the most recent emergency department visit, if any, that occurs 1 hour or less prior to the given encounter.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `edVisit()` instead.")]
    public Encounter ED_Visit(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet nzzk_ = this.Emergency_Department_Visit(context);
        IEnumerable<Encounter> nzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? nzzm_(Encounter EDVisit)
        {
            Code<Encounter.EncounterStatus> nzzr_ = EDVisit?.StatusElement;
            Encounter.EncounterStatus? nzzs_ = nzzr_?.Value;
            Code<Encounter.EncounterStatus> nzzt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(nzzs_);
            bool? nzzu_ = context.Operators.Equal(nzzt_, "finished");
            Period nzzv_ = EDVisit?.Period;
            CqlInterval<CqlDateTime> nzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzv_);
            CqlDateTime nzzx_ = context.Operators.End(nzzw_);
            Period nzzy_ = TheEncounter?.Period;
            CqlInterval<CqlDateTime> nzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzy_);
            CqlDateTime ozza_ = context.Operators.Start(nzzz_);
            CqlQuantity ozzb_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime ozzc_ = context.Operators.Subtract(ozza_, ozzb_);
            CqlInterval<CqlDateTime> ozze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzy_);
            CqlDateTime ozzf_ = context.Operators.Start(ozze_);
            CqlInterval<CqlDateTime> ozzg_ = context.Operators.Interval(ozzc_, ozzf_, true, true);
            bool? ozzh_ = context.Operators.In<CqlDateTime>(nzzx_, ozzg_, default);
            CqlInterval<CqlDateTime> ozzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzy_);
            CqlDateTime ozzk_ = context.Operators.Start(ozzj_);
            bool? ozzl_ = context.Operators.Not((bool?)(ozzk_ is null));
            bool? ozzm_ = context.Operators.And(ozzh_, ozzl_);
            bool? ozzn_ = context.Operators.And(nzzu_, ozzm_);

            return ozzn_;
        };
        IEnumerable<Encounter> nzzn_ = context.Operators.Where<Encounter>(nzzl_, nzzm_);
        object nzzo_(Encounter @this)
        {
            Period ozzo_ = @this?.Period;
            CqlInterval<CqlDateTime> ozzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzo_);
            CqlDateTime ozzq_ = context.Operators.End(ozzp_);

            return ozzq_;
        };
        IEnumerable<Encounter> nzzp_ = context.Operators.SortBy<Encounter>(nzzn_, nzzo_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter nzzq_ = context.Operators.Last<Encounter>(nzzp_);

        return nzzq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns the most recent emergency department visit, if any, that occurs 1 hour or less prior to the given encounter.")]
    public Encounter edVisit(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet ozzr_ = this.Emergency_Department_Visit(context);
        IEnumerable<Encounter> ozzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? ozzt_(Encounter EDVisit)
        {
            Code<Encounter.EncounterStatus> ozzy_ = EDVisit?.StatusElement;
            Encounter.EncounterStatus? ozzz_ = ozzy_?.Value;
            Code<Encounter.EncounterStatus> pzza_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ozzz_);
            bool? pzzb_ = context.Operators.Equal(pzza_, "finished");
            Period pzzc_ = EDVisit?.Period;
            CqlInterval<CqlDateTime> pzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzc_);
            CqlDateTime pzze_ = context.Operators.End(pzzd_);
            Period pzzf_ = TheEncounter?.Period;
            CqlInterval<CqlDateTime> pzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzf_);
            CqlDateTime pzzh_ = context.Operators.Start(pzzg_);
            CqlQuantity pzzi_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime pzzj_ = context.Operators.Subtract(pzzh_, pzzi_);
            CqlInterval<CqlDateTime> pzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzf_);
            CqlDateTime pzzm_ = context.Operators.Start(pzzl_);
            CqlInterval<CqlDateTime> pzzn_ = context.Operators.Interval(pzzj_, pzzm_, true, true);
            bool? pzzo_ = context.Operators.In<CqlDateTime>(pzze_, pzzn_, default);
            CqlInterval<CqlDateTime> pzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzf_);
            CqlDateTime pzzr_ = context.Operators.Start(pzzq_);
            bool? pzzs_ = context.Operators.Not((bool?)(pzzr_ is null));
            bool? pzzt_ = context.Operators.And(pzzo_, pzzs_);
            bool? pzzu_ = context.Operators.And(pzzb_, pzzt_);

            return pzzu_;
        };
        IEnumerable<Encounter> ozzu_ = context.Operators.Where<Encounter>(ozzs_, ozzt_);
        object ozzv_(Encounter @this)
        {
            Period pzzv_ = @this?.Period;
            CqlInterval<CqlDateTime> pzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzv_);
            CqlDateTime pzzx_ = context.Operators.End(pzzw_);

            return pzzx_;
        };
        IEnumerable<Encounter> ozzw_ = context.Operators.SortBy<Encounter>(ozzu_, ozzv_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter ozzx_ = context.Operators.Last<Encounter>(ozzw_);

        return ozzx_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Hospitalization returns the total interval for admission to discharge for the given encounter, or for the admission of any immediately prior emergency department visit to the discharge of the given encounter.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalization()` instead.")]
    public CqlInterval<CqlDateTime> Hospitalization(CqlContext context, Encounter TheEncounter)
    {
        Encounter pzzy_ = this.ED_Visit(context, TheEncounter);
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
                    CqlInterval<CqlDateTime> qzzn_ = context.Operators.Interval(qzzj_, qzzm_, true, false);

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


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Hospitalization returns the total interval for admission to discharge for the given encounter, or for the admission of any immediately prior emergency department visit to the discharge of the given encounter.")]
    public CqlInterval<CqlDateTime> hospitalization(CqlContext context, Encounter TheEncounter)
    {
        Encounter qzzo_ = this.edVisit(context, TheEncounter);
        Encounter[] qzzp_ = [
            qzzo_,
        ];
        CqlInterval<CqlDateTime> qzzq_(Encounter X)
        {
            CqlInterval<CqlDateTime> qzzu_()
            {
                if (X is null)
                {
                    Period qzzv_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> qzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzv_);

                    return qzzw_;
                }
                else
                {
                    Period qzzx_ = X?.Period;
                    CqlInterval<CqlDateTime> qzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzx_);
                    CqlDateTime qzzz_ = context.Operators.Start(qzzy_);
                    Period rzza_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> rzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzza_);
                    CqlDateTime rzzc_ = context.Operators.End(rzzb_);
                    CqlInterval<CqlDateTime> rzzd_ = context.Operators.Interval(qzzz_, rzzc_, true, true);

                    return rzzd_;
                }
            };

            return qzzu_();
        };
        IEnumerable<CqlInterval<CqlDateTime>> qzzr_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)qzzp_, qzzq_);
        IEnumerable<CqlInterval<CqlDateTime>> qzzs_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(qzzr_);
        CqlInterval<CqlDateTime> qzzt_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(qzzs_);

        return qzzt_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns list of all locations within an encounter, including locations for immediately prior ED visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationLocations()` instead.")]
    public IEnumerable<Encounter.LocationComponent> Hospitalization_Locations(CqlContext context, Encounter TheEncounter)
    {
        Encounter rzze_ = this.ED_Visit(context, TheEncounter);
        Encounter[] rzzf_ = [
            rzze_,
        ];
        IEnumerable<Encounter.LocationComponent> rzzg_(Encounter EDEncounter)
        {
            IEnumerable<Encounter.LocationComponent> rzzk_()
            {
                if (EDEncounter is null)
                {
                    List<Encounter.LocationComponent> rzzl_ = TheEncounter?.Location;

                    return (IEnumerable<Encounter.LocationComponent>)rzzl_;
                }
                else
                {
                    List<Encounter.LocationComponent> rzzm_ = EDEncounter?.Location;
                    List<Encounter.LocationComponent> rzzn_ = TheEncounter?.Location;
                    IEnumerable<Encounter.LocationComponent>[] rzzo_ = [
                        (IEnumerable<Encounter.LocationComponent>)rzzm_,
                        (IEnumerable<Encounter.LocationComponent>)rzzn_,
                    ];
                    IEnumerable<Encounter.LocationComponent> rzzp_ = context.Operators.Flatten<Encounter.LocationComponent>(rzzo_ as IEnumerable<IEnumerable<Encounter.LocationComponent>>);

                    return rzzp_;
                }
            };

            return rzzk_();
        };
        IEnumerable<IEnumerable<Encounter.LocationComponent>> rzzh_ = context.Operators.Select<Encounter, IEnumerable<Encounter.LocationComponent>>((IEnumerable<Encounter>)rzzf_, rzzg_);
        IEnumerable<IEnumerable<Encounter.LocationComponent>> rzzi_ = context.Operators.Distinct<IEnumerable<Encounter.LocationComponent>>(rzzh_);
        IEnumerable<Encounter.LocationComponent> rzzj_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(rzzi_);

        return rzzj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns list of all locations within an encounter, including locations for immediately prior ED visit.")]
    public IEnumerable<Encounter.LocationComponent> hospitalizationLocations(CqlContext context, Encounter TheEncounter)
    {
        Encounter rzzq_ = this.edVisit(context, TheEncounter);
        Encounter[] rzzr_ = [
            rzzq_,
        ];
        IEnumerable<Encounter.LocationComponent> rzzs_(Encounter EDEncounter)
        {
            IEnumerable<Encounter.LocationComponent> rzzw_()
            {
                if (EDEncounter is null)
                {
                    List<Encounter.LocationComponent> rzzx_ = TheEncounter?.Location;

                    return (IEnumerable<Encounter.LocationComponent>)rzzx_;
                }
                else
                {
                    List<Encounter.LocationComponent> rzzy_ = EDEncounter?.Location;
                    List<Encounter.LocationComponent> rzzz_ = TheEncounter?.Location;
                    IEnumerable<Encounter.LocationComponent>[] szza_ = [
                        (IEnumerable<Encounter.LocationComponent>)rzzy_,
                        (IEnumerable<Encounter.LocationComponent>)rzzz_,
                    ];
                    IEnumerable<Encounter.LocationComponent> szzb_ = context.Operators.Flatten<Encounter.LocationComponent>(szza_ as IEnumerable<IEnumerable<Encounter.LocationComponent>>);

                    return szzb_;
                }
            };

            return rzzw_();
        };
        IEnumerable<IEnumerable<Encounter.LocationComponent>> rzzt_ = context.Operators.Select<Encounter, IEnumerable<Encounter.LocationComponent>>((IEnumerable<Encounter>)rzzr_, rzzs_);
        IEnumerable<IEnumerable<Encounter.LocationComponent>> rzzu_ = context.Operators.Distinct<IEnumerable<Encounter.LocationComponent>>(rzzt_);
        IEnumerable<Encounter.LocationComponent> rzzv_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(rzzu_);

        return rzzv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns the length of stay in days (i.e. the number of days between admission and discharge) for the given encounter, or from the admission of any immediately prior emergency department visit to the discharge of the encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationLengthOfStay()` instead.")]
    public int? Hospitalization_Length_of_Stay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> szzc_ = this.Hospitalization(context, TheEncounter);
        int? szzd_ = this.LengthInDays(context, szzc_);

        return szzd_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns the length of stay in days (i.e. the number of days between admission and discharge) for the given encounter, or from the admission of any immediately prior emergency department visit to the discharge of the encounter")]
    public int? hospitalizationLengthOfStay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> szze_ = this.hospitalization(context, TheEncounter);
        int? szzf_ = this.lengthInDays(context, szze_);

        return szzf_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns admission time for an encounter or for immediately prior emergency department visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalAdmissionTime()` instead.")]
    public CqlDateTime Hospital_Admission_Time(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> szzg_ = this.Hospitalization(context, TheEncounter);
        CqlDateTime szzh_ = context.Operators.Start(szzg_);

        return szzh_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns admission time for an encounter or for immediately prior emergency department visit.")]
    public CqlDateTime hospitalAdmissionTime(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> szzi_ = this.hospitalization(context, TheEncounter);
        CqlDateTime szzj_ = context.Operators.Start(szzi_);

        return szzj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Hospital Discharge Time returns the discharge time for an encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalDischargeTime()` instead.")]
    public CqlDateTime Hospital_Discharge_Time(CqlContext context, Encounter TheEncounter)
    {
        Period szzk_ = TheEncounter?.Period;
        CqlInterval<CqlDateTime> szzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzk_);
        CqlDateTime szzm_ = context.Operators.End(szzl_);

        return szzm_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Hospital Discharge Time returns the discharge time for an encounter")]
    public CqlDateTime hospitalDischargeTime(CqlContext context, Encounter TheEncounter)
    {
        Period szzn_ = TheEncounter?.Period;
        CqlInterval<CqlDateTime> szzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzn_);
        CqlDateTime szzp_ = context.Operators.End(szzo_);

        return szzp_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns earliest arrival time for an encounter including any prior ED visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalArrivalTime()` instead.")]
    public CqlDateTime Hospital_Arrival_Time(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> szzq_ = this.Hospitalization_Locations(context, TheEncounter);
        object szzr_(Encounter.LocationComponent @this)
        {
            Period szzx_ = @this?.Period;
            CqlInterval<CqlDateTime> szzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzx_);
            CqlDateTime szzz_ = context.Operators.Start(szzy_);

            return szzz_;
        };
        IEnumerable<Encounter.LocationComponent> szzs_ = context.Operators.SortBy<Encounter.LocationComponent>(szzq_, szzr_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent szzt_ = context.Operators.First<Encounter.LocationComponent>(szzs_);
        Period szzu_ = szzt_?.Period;
        CqlInterval<CqlDateTime> szzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzu_);
        CqlDateTime szzw_ = context.Operators.Start(szzv_);

        return szzw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns earliest arrival time for an encounter including any prior ED visit.")]
    public CqlDateTime hospitalArrivalTime(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> tzza_ = this.hospitalizationLocations(context, TheEncounter);
        object tzzb_(Encounter.LocationComponent @this)
        {
            Period tzzh_ = @this?.Period;
            CqlInterval<CqlDateTime> tzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzh_);
            CqlDateTime tzzj_ = context.Operators.Start(tzzi_);

            return tzzj_;
        };
        IEnumerable<Encounter.LocationComponent> tzzc_ = context.Operators.SortBy<Encounter.LocationComponent>(tzza_, tzzb_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent tzzd_ = context.Operators.First<Encounter.LocationComponent>(tzzc_);
        Period tzze_ = tzzd_?.Period;
        CqlInterval<CqlDateTime> tzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzze_);
        CqlDateTime tzzg_ = context.Operators.Start(tzzf_);

        return tzzg_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns the latest departure time for encounter including any prior ED visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalDepartureTime()` instead.")]
    public CqlDateTime Hospital_Departure_Time(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> tzzk_ = this.Hospitalization_Locations(context, TheEncounter);
        object tzzl_(Encounter.LocationComponent @this)
        {
            Period tzzr_ = @this?.Period;
            CqlInterval<CqlDateTime> tzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzr_);
            CqlDateTime tzzt_ = context.Operators.Start(tzzs_);

            return tzzt_;
        };
        IEnumerable<Encounter.LocationComponent> tzzm_ = context.Operators.SortBy<Encounter.LocationComponent>(tzzk_, tzzl_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent tzzn_ = context.Operators.Last<Encounter.LocationComponent>(tzzm_);
        Period tzzo_ = tzzn_?.Period;
        CqlInterval<CqlDateTime> tzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzo_);
        CqlDateTime tzzq_ = context.Operators.End(tzzp_);

        return tzzq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns the latest departure time for encounter including any prior ED visit.")]
    public CqlDateTime hospitalDepartureTime(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> tzzu_ = this.hospitalizationLocations(context, TheEncounter);
        object tzzv_(Encounter.LocationComponent @this)
        {
            Period uzzb_ = @this?.Period;
            CqlInterval<CqlDateTime> uzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzb_);
            CqlDateTime uzzd_ = context.Operators.Start(uzzc_);

            return uzzd_;
        };
        IEnumerable<Encounter.LocationComponent> tzzw_ = context.Operators.SortBy<Encounter.LocationComponent>(tzzu_, tzzv_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent tzzx_ = context.Operators.Last<Encounter.LocationComponent>(tzzw_);
        Period tzzy_ = tzzx_?.Period;
        CqlInterval<CqlDateTime> tzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzy_);
        CqlDateTime uzza_ = context.Operators.End(tzzz_);

        return uzza_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns the Location resource specified by the given reference")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getLocation()` instead.")]
    public Location GetLocation(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Location> uzze_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-location"));
        bool? uzzf_(Location L)
        {
            Id uzzi_ = L?.IdElement;
            string uzzj_ = uzzi_?.Value;
            FhirString uzzk_ = reference?.ReferenceElement;
            string uzzl_ = uzzk_?.Value;
            string uzzm_ = QICoreCommon_2_1_000.Instance.getId(context, uzzl_);
            bool? uzzn_ = context.Operators.Equal(uzzj_, uzzm_);

            return uzzn_;
        };
        IEnumerable<Location> uzzg_ = context.Operators.Where<Location>(uzze_, uzzf_);
        Location uzzh_ = context.Operators.SingletonFrom<Location>(uzzg_);

        return uzzh_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns the emergency department arrival time for the encounter.")]
    public CqlDateTime Emergency_Department_Arrival_Time(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> uzzo_ = this.Hospitalization_Locations(context, TheEncounter);
        bool? uzzp_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference uzzv_ = HospitalLocation?.Location;
            Location uzzw_ = this.GetLocation(context, uzzv_);
            List<CodeableConcept> uzzx_ = uzzw_?.Type;
            CqlConcept uzzy_(CodeableConcept @this)
            {
                CqlConcept vzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return vzzc_;
            };
            IEnumerable<CqlConcept> uzzz_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)uzzx_, uzzy_);
            CqlValueSet vzza_ = this.Emergency_Department_Visit(context);
            bool? vzzb_ = context.Operators.ConceptsInValueSet(uzzz_, vzza_);

            return vzzb_;
        };
        IEnumerable<Encounter.LocationComponent> uzzq_ = context.Operators.Where<Encounter.LocationComponent>(uzzo_, uzzp_);
        Encounter.LocationComponent uzzr_ = context.Operators.SingletonFrom<Encounter.LocationComponent>(uzzq_);
        Period uzzs_ = uzzr_?.Period;
        CqlInterval<CqlDateTime> uzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzs_);
        CqlDateTime uzzu_ = context.Operators.Start(uzzt_);

        return uzzu_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns the emergency department arrival time for the encounter.")]
    public CqlDateTime emergencyDepartmentArrivalTime(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> vzzd_ = this.hospitalizationLocations(context, TheEncounter);
        bool? vzze_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference vzzk_ = HospitalLocation?.Location;
            Location vzzl_ = this.GetLocation(context, vzzk_);
            List<CodeableConcept> vzzm_ = vzzl_?.Type;
            CqlConcept vzzn_(CodeableConcept @this)
            {
                CqlConcept vzzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return vzzr_;
            };
            IEnumerable<CqlConcept> vzzo_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)vzzm_, vzzn_);
            CqlValueSet vzzp_ = this.Emergency_Department_Visit(context);
            bool? vzzq_ = context.Operators.ConceptsInValueSet(vzzo_, vzzp_);

            return vzzq_;
        };
        IEnumerable<Encounter.LocationComponent> vzzf_ = context.Operators.Where<Encounter.LocationComponent>(vzzd_, vzze_);
        Encounter.LocationComponent vzzg_ = context.Operators.SingletonFrom<Encounter.LocationComponent>(vzzf_);
        Period vzzh_ = vzzg_?.Period;
        CqlInterval<CqlDateTime> vzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzh_);
        CqlDateTime vzzj_ = context.Operators.Start(vzzi_);

        return vzzj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Hospitalization with Observation and Outpatient Surgery Service returns the total interval from the start of any immediately prior emergency department visit, outpatient surgery visit or observation visit to the discharge of the given encounter.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationWithObservationAndOutpatientSurgeryService()` instead.")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservationAndOutpatientSurgeryService(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] vzzs_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> vzzt_(Encounter Visit)
        {
            CqlValueSet vzzx_ = this.Outpatient_Surgery_Service(context);
            IEnumerable<Encounter> vzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? vzzz_(Encounter LastSurgeryOP)
            {
                Period xzzi_ = LastSurgeryOP?.Period;
                CqlInterval<CqlDateTime> xzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzi_);
                CqlDateTime xzzk_ = context.Operators.End(xzzj_);
                CqlValueSet xzzl_ = this.Emergency_Department_Visit(context);
                IEnumerable<Encounter> xzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? xzzn_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> azzzi_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? azzzj_ = azzzi_?.Value;
                    Code<Encounter.EncounterStatus> azzzk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(azzzj_);
                    bool? azzzl_ = context.Operators.Equal(azzzk_, "finished");
                    Period azzzm_ = LastED?.Period;
                    CqlInterval<CqlDateTime> azzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzm_);
                    CqlDateTime azzzo_ = context.Operators.End(azzzn_);
                    CqlValueSet azzzp_ = this.Observation_Services(context);
                    IEnumerable<Encounter> azzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? azzzr_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> czzzj_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? czzzk_ = czzzj_?.Value;
                        Code<Encounter.EncounterStatus> czzzl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(czzzk_);
                        bool? czzzm_ = context.Operators.Equal(czzzl_, "finished");
                        Period czzzn_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> czzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzn_);
                        CqlDateTime czzzp_ = context.Operators.End(czzzo_);
                        Period czzzq_ = Visit?.Period;
                        CqlInterval<CqlDateTime> czzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzq_);
                        CqlDateTime czzzs_ = context.Operators.Start(czzzr_);
                        CqlQuantity czzzt_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime czzzu_ = context.Operators.Subtract(czzzs_, czzzt_);
                        CqlInterval<CqlDateTime> czzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzq_);
                        CqlDateTime czzzx_ = context.Operators.Start(czzzw_);
                        CqlInterval<CqlDateTime> czzzy_ = context.Operators.Interval(czzzu_, czzzx_, true, true);
                        bool? czzzz_ = context.Operators.In<CqlDateTime>(czzzp_, czzzy_, default);
                        CqlInterval<CqlDateTime> dzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzq_);
                        CqlDateTime dzzzc_ = context.Operators.Start(dzzzb_);
                        bool? dzzzd_ = context.Operators.Not((bool?)(dzzzc_ is null));
                        bool? dzzze_ = context.Operators.And(czzzz_, dzzzd_);
                        bool? dzzzf_ = context.Operators.And(czzzm_, dzzze_);

                        return dzzzf_;
                    };
                    IEnumerable<Encounter> azzzs_ = context.Operators.Where<Encounter>(azzzq_, azzzr_);
                    object azzzt_(Encounter @this)
                    {
                        Period dzzzg_ = @this?.Period;
                        CqlInterval<CqlDateTime> dzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzg_);
                        CqlDateTime dzzzi_ = context.Operators.End(dzzzh_);

                        return dzzzi_;
                    };
                    IEnumerable<Encounter> azzzu_ = context.Operators.SortBy<Encounter>(azzzs_, azzzt_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter azzzv_ = context.Operators.Last<Encounter>(azzzu_);
                    Period azzzw_ = azzzv_?.Period;
                    CqlInterval<CqlDateTime> azzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzw_);
                    CqlDateTime azzzy_ = context.Operators.Start(azzzx_);
                    Period azzzz_ = Visit?.Period;
                    CqlInterval<CqlDateTime> bzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzz_);
                    CqlDateTime bzzzb_ = context.Operators.Start(bzzza_);
                    CqlQuantity bzzzc_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime bzzzd_ = context.Operators.Subtract(azzzy_ ?? bzzzb_, bzzzc_);
                    IEnumerable<Encounter> bzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? bzzzg_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> dzzzj_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? dzzzk_ = dzzzj_?.Value;
                        Code<Encounter.EncounterStatus> dzzzl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dzzzk_);
                        bool? dzzzm_ = context.Operators.Equal(dzzzl_, "finished");
                        Period dzzzn_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> dzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzn_);
                        CqlDateTime dzzzp_ = context.Operators.End(dzzzo_);
                        Period dzzzq_ = Visit?.Period;
                        CqlInterval<CqlDateTime> dzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzq_);
                        CqlDateTime dzzzs_ = context.Operators.Start(dzzzr_);
                        CqlQuantity dzzzt_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime dzzzu_ = context.Operators.Subtract(dzzzs_, dzzzt_);
                        CqlInterval<CqlDateTime> dzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzq_);
                        CqlDateTime dzzzx_ = context.Operators.Start(dzzzw_);
                        CqlInterval<CqlDateTime> dzzzy_ = context.Operators.Interval(dzzzu_, dzzzx_, true, true);
                        bool? dzzzz_ = context.Operators.In<CqlDateTime>(dzzzp_, dzzzy_, default);
                        CqlInterval<CqlDateTime> ezzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzq_);
                        CqlDateTime ezzzc_ = context.Operators.Start(ezzzb_);
                        bool? ezzzd_ = context.Operators.Not((bool?)(ezzzc_ is null));
                        bool? ezzze_ = context.Operators.And(dzzzz_, ezzzd_);
                        bool? ezzzf_ = context.Operators.And(dzzzm_, ezzze_);

                        return ezzzf_;
                    };
                    IEnumerable<Encounter> bzzzh_ = context.Operators.Where<Encounter>(bzzzf_, bzzzg_);
                    object bzzzi_(Encounter @this)
                    {
                        Period ezzzg_ = @this?.Period;
                        CqlInterval<CqlDateTime> ezzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzg_);
                        CqlDateTime ezzzi_ = context.Operators.End(ezzzh_);

                        return ezzzi_;
                    };
                    IEnumerable<Encounter> bzzzj_ = context.Operators.SortBy<Encounter>(bzzzh_, bzzzi_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter bzzzk_ = context.Operators.Last<Encounter>(bzzzj_);
                    Period bzzzl_ = bzzzk_?.Period;
                    CqlInterval<CqlDateTime> bzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzl_);
                    CqlDateTime bzzzn_ = context.Operators.Start(bzzzm_);
                    CqlInterval<CqlDateTime> bzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzz_);
                    CqlDateTime bzzzq_ = context.Operators.Start(bzzzp_);
                    CqlInterval<CqlDateTime> bzzzr_ = context.Operators.Interval(bzzzd_, bzzzn_ ?? bzzzq_, true, true);
                    bool? bzzzs_ = context.Operators.In<CqlDateTime>(azzzo_, bzzzr_, default);
                    IEnumerable<Encounter> bzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? bzzzv_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> ezzzj_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? ezzzk_ = ezzzj_?.Value;
                        Code<Encounter.EncounterStatus> ezzzl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ezzzk_);
                        bool? ezzzm_ = context.Operators.Equal(ezzzl_, "finished");
                        Period ezzzn_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> ezzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzn_);
                        CqlDateTime ezzzp_ = context.Operators.End(ezzzo_);
                        Period ezzzq_ = Visit?.Period;
                        CqlInterval<CqlDateTime> ezzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzq_);
                        CqlDateTime ezzzs_ = context.Operators.Start(ezzzr_);
                        CqlQuantity ezzzt_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime ezzzu_ = context.Operators.Subtract(ezzzs_, ezzzt_);
                        CqlInterval<CqlDateTime> ezzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzq_);
                        CqlDateTime ezzzx_ = context.Operators.Start(ezzzw_);
                        CqlInterval<CqlDateTime> ezzzy_ = context.Operators.Interval(ezzzu_, ezzzx_, true, true);
                        bool? ezzzz_ = context.Operators.In<CqlDateTime>(ezzzp_, ezzzy_, default);
                        CqlInterval<CqlDateTime> fzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzq_);
                        CqlDateTime fzzzc_ = context.Operators.Start(fzzzb_);
                        bool? fzzzd_ = context.Operators.Not((bool?)(fzzzc_ is null));
                        bool? fzzze_ = context.Operators.And(ezzzz_, fzzzd_);
                        bool? fzzzf_ = context.Operators.And(ezzzm_, fzzze_);

                        return fzzzf_;
                    };
                    IEnumerable<Encounter> bzzzw_ = context.Operators.Where<Encounter>(bzzzu_, bzzzv_);
                    object bzzzx_(Encounter @this)
                    {
                        Period fzzzg_ = @this?.Period;
                        CqlInterval<CqlDateTime> fzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzg_);
                        CqlDateTime fzzzi_ = context.Operators.End(fzzzh_);

                        return fzzzi_;
                    };
                    IEnumerable<Encounter> bzzzy_ = context.Operators.SortBy<Encounter>(bzzzw_, bzzzx_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter bzzzz_ = context.Operators.Last<Encounter>(bzzzy_);
                    Period czzza_ = bzzzz_?.Period;
                    CqlInterval<CqlDateTime> czzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzza_);
                    CqlDateTime czzzc_ = context.Operators.Start(czzzb_);
                    CqlInterval<CqlDateTime> czzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzz_);
                    CqlDateTime czzzf_ = context.Operators.Start(czzze_);
                    bool? czzzg_ = context.Operators.Not((bool?)((czzzc_ ?? czzzf_) is null));
                    bool? czzzh_ = context.Operators.And(bzzzs_, czzzg_);
                    bool? czzzi_ = context.Operators.And(azzzl_, czzzh_);

                    return czzzi_;
                };
                IEnumerable<Encounter> xzzo_ = context.Operators.Where<Encounter>(xzzm_, xzzn_);
                object xzzp_(Encounter @this)
                {
                    Period fzzzj_ = @this?.Period;
                    CqlInterval<CqlDateTime> fzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzj_);
                    CqlDateTime fzzzl_ = context.Operators.End(fzzzk_);

                    return fzzzl_;
                };
                IEnumerable<Encounter> xzzq_ = context.Operators.SortBy<Encounter>(xzzo_, xzzp_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter xzzr_ = context.Operators.Last<Encounter>(xzzq_);
                Period xzzs_ = xzzr_?.Period;
                CqlInterval<CqlDateTime> xzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzs_);
                CqlDateTime xzzu_ = context.Operators.Start(xzzt_);
                CqlValueSet xzzv_ = this.Observation_Services(context);
                IEnumerable<Encounter> xzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? xzzx_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> fzzzm_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? fzzzn_ = fzzzm_?.Value;
                    Code<Encounter.EncounterStatus> fzzzo_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fzzzn_);
                    bool? fzzzp_ = context.Operators.Equal(fzzzo_, "finished");
                    Period fzzzq_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> fzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzq_);
                    CqlDateTime fzzzs_ = context.Operators.End(fzzzr_);
                    Period fzzzt_ = Visit?.Period;
                    CqlInterval<CqlDateTime> fzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzt_);
                    CqlDateTime fzzzv_ = context.Operators.Start(fzzzu_);
                    CqlQuantity fzzzw_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime fzzzx_ = context.Operators.Subtract(fzzzv_, fzzzw_);
                    CqlInterval<CqlDateTime> fzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzt_);
                    CqlDateTime gzzza_ = context.Operators.Start(fzzzz_);
                    CqlInterval<CqlDateTime> gzzzb_ = context.Operators.Interval(fzzzx_, gzzza_, true, true);
                    bool? gzzzc_ = context.Operators.In<CqlDateTime>(fzzzs_, gzzzb_, default);
                    CqlInterval<CqlDateTime> gzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzt_);
                    CqlDateTime gzzzf_ = context.Operators.Start(gzzze_);
                    bool? gzzzg_ = context.Operators.Not((bool?)(gzzzf_ is null));
                    bool? gzzzh_ = context.Operators.And(gzzzc_, gzzzg_);
                    bool? gzzzi_ = context.Operators.And(fzzzp_, gzzzh_);

                    return gzzzi_;
                };
                IEnumerable<Encounter> xzzy_ = context.Operators.Where<Encounter>(xzzw_, xzzx_);
                object xzzz_(Encounter @this)
                {
                    Period gzzzj_ = @this?.Period;
                    CqlInterval<CqlDateTime> gzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzj_);
                    CqlDateTime gzzzl_ = context.Operators.End(gzzzk_);

                    return gzzzl_;
                };
                IEnumerable<Encounter> yzza_ = context.Operators.SortBy<Encounter>(xzzy_, xzzz_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter yzzb_ = context.Operators.Last<Encounter>(yzza_);
                Period yzzc_ = yzzb_?.Period;
                CqlInterval<CqlDateTime> yzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzc_);
                CqlDateTime yzze_ = context.Operators.Start(yzzd_);
                Period yzzf_ = Visit?.Period;
                CqlInterval<CqlDateTime> yzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzf_);
                CqlDateTime yzzh_ = context.Operators.Start(yzzg_);
                CqlQuantity yzzi_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime yzzj_ = context.Operators.Subtract(xzzu_ ?? yzze_ ?? yzzh_, yzzi_);
                IEnumerable<Encounter> yzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? yzzm_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> gzzzm_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? gzzzn_ = gzzzm_?.Value;
                    Code<Encounter.EncounterStatus> gzzzo_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gzzzn_);
                    bool? gzzzp_ = context.Operators.Equal(gzzzo_, "finished");
                    Period gzzzq_ = LastED?.Period;
                    CqlInterval<CqlDateTime> gzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzq_);
                    CqlDateTime gzzzs_ = context.Operators.End(gzzzr_);
                    CqlValueSet gzzzt_ = this.Observation_Services(context);
                    IEnumerable<Encounter> gzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? gzzzv_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> izzzn_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? izzzo_ = izzzn_?.Value;
                        Code<Encounter.EncounterStatus> izzzp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(izzzo_);
                        bool? izzzq_ = context.Operators.Equal(izzzp_, "finished");
                        Period izzzr_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> izzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzr_);
                        CqlDateTime izzzt_ = context.Operators.End(izzzs_);
                        Period izzzu_ = Visit?.Period;
                        CqlInterval<CqlDateTime> izzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzu_);
                        CqlDateTime izzzw_ = context.Operators.Start(izzzv_);
                        CqlQuantity izzzx_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime izzzy_ = context.Operators.Subtract(izzzw_, izzzx_);
                        CqlInterval<CqlDateTime> jzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzu_);
                        CqlDateTime jzzzb_ = context.Operators.Start(jzzza_);
                        CqlInterval<CqlDateTime> jzzzc_ = context.Operators.Interval(izzzy_, jzzzb_, true, true);
                        bool? jzzzd_ = context.Operators.In<CqlDateTime>(izzzt_, jzzzc_, default);
                        CqlInterval<CqlDateTime> jzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzu_);
                        CqlDateTime jzzzg_ = context.Operators.Start(jzzzf_);
                        bool? jzzzh_ = context.Operators.Not((bool?)(jzzzg_ is null));
                        bool? jzzzi_ = context.Operators.And(jzzzd_, jzzzh_);
                        bool? jzzzj_ = context.Operators.And(izzzq_, jzzzi_);

                        return jzzzj_;
                    };
                    IEnumerable<Encounter> gzzzw_ = context.Operators.Where<Encounter>(gzzzu_, gzzzv_);
                    object gzzzx_(Encounter @this)
                    {
                        Period jzzzk_ = @this?.Period;
                        CqlInterval<CqlDateTime> jzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzk_);
                        CqlDateTime jzzzm_ = context.Operators.End(jzzzl_);

                        return jzzzm_;
                    };
                    IEnumerable<Encounter> gzzzy_ = context.Operators.SortBy<Encounter>(gzzzw_, gzzzx_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter gzzzz_ = context.Operators.Last<Encounter>(gzzzy_);
                    Period hzzza_ = gzzzz_?.Period;
                    CqlInterval<CqlDateTime> hzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzza_);
                    CqlDateTime hzzzc_ = context.Operators.Start(hzzzb_);
                    Period hzzzd_ = Visit?.Period;
                    CqlInterval<CqlDateTime> hzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzd_);
                    CqlDateTime hzzzf_ = context.Operators.Start(hzzze_);
                    CqlQuantity hzzzg_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime hzzzh_ = context.Operators.Subtract(hzzzc_ ?? hzzzf_, hzzzg_);
                    IEnumerable<Encounter> hzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? hzzzk_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> jzzzn_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? jzzzo_ = jzzzn_?.Value;
                        Code<Encounter.EncounterStatus> jzzzp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jzzzo_);
                        bool? jzzzq_ = context.Operators.Equal(jzzzp_, "finished");
                        Period jzzzr_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> jzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzr_);
                        CqlDateTime jzzzt_ = context.Operators.End(jzzzs_);
                        Period jzzzu_ = Visit?.Period;
                        CqlInterval<CqlDateTime> jzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzu_);
                        CqlDateTime jzzzw_ = context.Operators.Start(jzzzv_);
                        CqlQuantity jzzzx_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime jzzzy_ = context.Operators.Subtract(jzzzw_, jzzzx_);
                        CqlInterval<CqlDateTime> kzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzu_);
                        CqlDateTime kzzzb_ = context.Operators.Start(kzzza_);
                        CqlInterval<CqlDateTime> kzzzc_ = context.Operators.Interval(jzzzy_, kzzzb_, true, true);
                        bool? kzzzd_ = context.Operators.In<CqlDateTime>(jzzzt_, kzzzc_, default);
                        CqlInterval<CqlDateTime> kzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzu_);
                        CqlDateTime kzzzg_ = context.Operators.Start(kzzzf_);
                        bool? kzzzh_ = context.Operators.Not((bool?)(kzzzg_ is null));
                        bool? kzzzi_ = context.Operators.And(kzzzd_, kzzzh_);
                        bool? kzzzj_ = context.Operators.And(jzzzq_, kzzzi_);

                        return kzzzj_;
                    };
                    IEnumerable<Encounter> hzzzl_ = context.Operators.Where<Encounter>(hzzzj_, hzzzk_);
                    object hzzzm_(Encounter @this)
                    {
                        Period kzzzk_ = @this?.Period;
                        CqlInterval<CqlDateTime> kzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzk_);
                        CqlDateTime kzzzm_ = context.Operators.End(kzzzl_);

                        return kzzzm_;
                    };
                    IEnumerable<Encounter> hzzzn_ = context.Operators.SortBy<Encounter>(hzzzl_, hzzzm_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter hzzzo_ = context.Operators.Last<Encounter>(hzzzn_);
                    Period hzzzp_ = hzzzo_?.Period;
                    CqlInterval<CqlDateTime> hzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzp_);
                    CqlDateTime hzzzr_ = context.Operators.Start(hzzzq_);
                    CqlInterval<CqlDateTime> hzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzd_);
                    CqlDateTime hzzzu_ = context.Operators.Start(hzzzt_);
                    CqlInterval<CqlDateTime> hzzzv_ = context.Operators.Interval(hzzzh_, hzzzr_ ?? hzzzu_, true, true);
                    bool? hzzzw_ = context.Operators.In<CqlDateTime>(gzzzs_, hzzzv_, default);
                    IEnumerable<Encounter> hzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? hzzzz_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> kzzzn_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? kzzzo_ = kzzzn_?.Value;
                        Code<Encounter.EncounterStatus> kzzzp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(kzzzo_);
                        bool? kzzzq_ = context.Operators.Equal(kzzzp_, "finished");
                        Period kzzzr_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> kzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzr_);
                        CqlDateTime kzzzt_ = context.Operators.End(kzzzs_);
                        Period kzzzu_ = Visit?.Period;
                        CqlInterval<CqlDateTime> kzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzu_);
                        CqlDateTime kzzzw_ = context.Operators.Start(kzzzv_);
                        CqlQuantity kzzzx_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime kzzzy_ = context.Operators.Subtract(kzzzw_, kzzzx_);
                        CqlInterval<CqlDateTime> lzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzu_);
                        CqlDateTime lzzzb_ = context.Operators.Start(lzzza_);
                        CqlInterval<CqlDateTime> lzzzc_ = context.Operators.Interval(kzzzy_, lzzzb_, true, true);
                        bool? lzzzd_ = context.Operators.In<CqlDateTime>(kzzzt_, lzzzc_, default);
                        CqlInterval<CqlDateTime> lzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzu_);
                        CqlDateTime lzzzg_ = context.Operators.Start(lzzzf_);
                        bool? lzzzh_ = context.Operators.Not((bool?)(lzzzg_ is null));
                        bool? lzzzi_ = context.Operators.And(lzzzd_, lzzzh_);
                        bool? lzzzj_ = context.Operators.And(kzzzq_, lzzzi_);

                        return lzzzj_;
                    };
                    IEnumerable<Encounter> izzza_ = context.Operators.Where<Encounter>(hzzzy_, hzzzz_);
                    object izzzb_(Encounter @this)
                    {
                        Period lzzzk_ = @this?.Period;
                        CqlInterval<CqlDateTime> lzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzk_);
                        CqlDateTime lzzzm_ = context.Operators.End(lzzzl_);

                        return lzzzm_;
                    };
                    IEnumerable<Encounter> izzzc_ = context.Operators.SortBy<Encounter>(izzza_, izzzb_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter izzzd_ = context.Operators.Last<Encounter>(izzzc_);
                    Period izzze_ = izzzd_?.Period;
                    CqlInterval<CqlDateTime> izzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzze_);
                    CqlDateTime izzzg_ = context.Operators.Start(izzzf_);
                    CqlInterval<CqlDateTime> izzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzd_);
                    CqlDateTime izzzj_ = context.Operators.Start(izzzi_);
                    bool? izzzk_ = context.Operators.Not((bool?)((izzzg_ ?? izzzj_) is null));
                    bool? izzzl_ = context.Operators.And(hzzzw_, izzzk_);
                    bool? izzzm_ = context.Operators.And(gzzzp_, izzzl_);

                    return izzzm_;
                };
                IEnumerable<Encounter> yzzn_ = context.Operators.Where<Encounter>(yzzl_, yzzm_);
                object yzzo_(Encounter @this)
                {
                    Period lzzzn_ = @this?.Period;
                    CqlInterval<CqlDateTime> lzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzn_);
                    CqlDateTime lzzzp_ = context.Operators.End(lzzzo_);

                    return lzzzp_;
                };
                IEnumerable<Encounter> yzzp_ = context.Operators.SortBy<Encounter>(yzzn_, yzzo_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter yzzq_ = context.Operators.Last<Encounter>(yzzp_);
                Period yzzr_ = yzzq_?.Period;
                CqlInterval<CqlDateTime> yzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzr_);
                CqlDateTime yzzt_ = context.Operators.Start(yzzs_);
                IEnumerable<Encounter> yzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? yzzw_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> lzzzq_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? lzzzr_ = lzzzq_?.Value;
                    Code<Encounter.EncounterStatus> lzzzs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lzzzr_);
                    bool? lzzzt_ = context.Operators.Equal(lzzzs_, "finished");
                    Period lzzzu_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> lzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzu_);
                    CqlDateTime lzzzw_ = context.Operators.End(lzzzv_);
                    Period lzzzx_ = Visit?.Period;
                    CqlInterval<CqlDateTime> lzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzx_);
                    CqlDateTime lzzzz_ = context.Operators.Start(lzzzy_);
                    CqlQuantity mzzza_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime mzzzb_ = context.Operators.Subtract(lzzzz_, mzzza_);
                    CqlInterval<CqlDateTime> mzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzx_);
                    CqlDateTime mzzze_ = context.Operators.Start(mzzzd_);
                    CqlInterval<CqlDateTime> mzzzf_ = context.Operators.Interval(mzzzb_, mzzze_, true, true);
                    bool? mzzzg_ = context.Operators.In<CqlDateTime>(lzzzw_, mzzzf_, default);
                    CqlInterval<CqlDateTime> mzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzx_);
                    CqlDateTime mzzzj_ = context.Operators.Start(mzzzi_);
                    bool? mzzzk_ = context.Operators.Not((bool?)(mzzzj_ is null));
                    bool? mzzzl_ = context.Operators.And(mzzzg_, mzzzk_);
                    bool? mzzzm_ = context.Operators.And(lzzzt_, mzzzl_);

                    return mzzzm_;
                };
                IEnumerable<Encounter> yzzx_ = context.Operators.Where<Encounter>(yzzv_, yzzw_);
                object yzzy_(Encounter @this)
                {
                    Period mzzzn_ = @this?.Period;
                    CqlInterval<CqlDateTime> mzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzn_);
                    CqlDateTime mzzzp_ = context.Operators.End(mzzzo_);

                    return mzzzp_;
                };
                IEnumerable<Encounter> yzzz_ = context.Operators.SortBy<Encounter>(yzzx_, yzzy_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter zzza_ = context.Operators.Last<Encounter>(yzzz_);
                Period zzzb_ = zzza_?.Period;
                CqlInterval<CqlDateTime> zzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzb_);
                CqlDateTime zzzd_ = context.Operators.Start(zzzc_);
                CqlInterval<CqlDateTime> zzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzf_);
                CqlDateTime zzzg_ = context.Operators.Start(zzzf_);
                CqlInterval<CqlDateTime> zzzh_ = context.Operators.Interval(yzzj_, yzzt_ ?? zzzd_ ?? zzzg_, true, true);
                bool? zzzi_ = context.Operators.In<CqlDateTime>(xzzk_, zzzh_, default);
                IEnumerable<Encounter> zzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? zzzl_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> mzzzq_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? mzzzr_ = mzzzq_?.Value;
                    Code<Encounter.EncounterStatus> mzzzs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(mzzzr_);
                    bool? mzzzt_ = context.Operators.Equal(mzzzs_, "finished");
                    Period mzzzu_ = LastED?.Period;
                    CqlInterval<CqlDateTime> mzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzu_);
                    CqlDateTime mzzzw_ = context.Operators.End(mzzzv_);
                    CqlValueSet mzzzx_ = this.Observation_Services(context);
                    IEnumerable<Encounter> mzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? mzzzz_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> ozzzr_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? ozzzs_ = ozzzr_?.Value;
                        Code<Encounter.EncounterStatus> ozzzt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ozzzs_);
                        bool? ozzzu_ = context.Operators.Equal(ozzzt_, "finished");
                        Period ozzzv_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> ozzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzv_);
                        CqlDateTime ozzzx_ = context.Operators.End(ozzzw_);
                        Period ozzzy_ = Visit?.Period;
                        CqlInterval<CqlDateTime> ozzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzy_);
                        CqlDateTime pzzza_ = context.Operators.Start(ozzzz_);
                        CqlQuantity pzzzb_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime pzzzc_ = context.Operators.Subtract(pzzza_, pzzzb_);
                        CqlInterval<CqlDateTime> pzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzy_);
                        CqlDateTime pzzzf_ = context.Operators.Start(pzzze_);
                        CqlInterval<CqlDateTime> pzzzg_ = context.Operators.Interval(pzzzc_, pzzzf_, true, true);
                        bool? pzzzh_ = context.Operators.In<CqlDateTime>(ozzzx_, pzzzg_, default);
                        CqlInterval<CqlDateTime> pzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzy_);
                        CqlDateTime pzzzk_ = context.Operators.Start(pzzzj_);
                        bool? pzzzl_ = context.Operators.Not((bool?)(pzzzk_ is null));
                        bool? pzzzm_ = context.Operators.And(pzzzh_, pzzzl_);
                        bool? pzzzn_ = context.Operators.And(ozzzu_, pzzzm_);

                        return pzzzn_;
                    };
                    IEnumerable<Encounter> nzzza_ = context.Operators.Where<Encounter>(mzzzy_, mzzzz_);
                    object nzzzb_(Encounter @this)
                    {
                        Period pzzzo_ = @this?.Period;
                        CqlInterval<CqlDateTime> pzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzo_);
                        CqlDateTime pzzzq_ = context.Operators.End(pzzzp_);

                        return pzzzq_;
                    };
                    IEnumerable<Encounter> nzzzc_ = context.Operators.SortBy<Encounter>(nzzza_, nzzzb_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter nzzzd_ = context.Operators.Last<Encounter>(nzzzc_);
                    Period nzzze_ = nzzzd_?.Period;
                    CqlInterval<CqlDateTime> nzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzze_);
                    CqlDateTime nzzzg_ = context.Operators.Start(nzzzf_);
                    Period nzzzh_ = Visit?.Period;
                    CqlInterval<CqlDateTime> nzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzh_);
                    CqlDateTime nzzzj_ = context.Operators.Start(nzzzi_);
                    CqlQuantity nzzzk_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime nzzzl_ = context.Operators.Subtract(nzzzg_ ?? nzzzj_, nzzzk_);
                    IEnumerable<Encounter> nzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? nzzzo_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> pzzzr_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? pzzzs_ = pzzzr_?.Value;
                        Code<Encounter.EncounterStatus> pzzzt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pzzzs_);
                        bool? pzzzu_ = context.Operators.Equal(pzzzt_, "finished");
                        Period pzzzv_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> pzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzv_);
                        CqlDateTime pzzzx_ = context.Operators.End(pzzzw_);
                        Period pzzzy_ = Visit?.Period;
                        CqlInterval<CqlDateTime> pzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzy_);
                        CqlDateTime qzzza_ = context.Operators.Start(pzzzz_);
                        CqlQuantity qzzzb_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime qzzzc_ = context.Operators.Subtract(qzzza_, qzzzb_);
                        CqlInterval<CqlDateTime> qzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzy_);
                        CqlDateTime qzzzf_ = context.Operators.Start(qzzze_);
                        CqlInterval<CqlDateTime> qzzzg_ = context.Operators.Interval(qzzzc_, qzzzf_, true, true);
                        bool? qzzzh_ = context.Operators.In<CqlDateTime>(pzzzx_, qzzzg_, default);
                        CqlInterval<CqlDateTime> qzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzy_);
                        CqlDateTime qzzzk_ = context.Operators.Start(qzzzj_);
                        bool? qzzzl_ = context.Operators.Not((bool?)(qzzzk_ is null));
                        bool? qzzzm_ = context.Operators.And(qzzzh_, qzzzl_);
                        bool? qzzzn_ = context.Operators.And(pzzzu_, qzzzm_);

                        return qzzzn_;
                    };
                    IEnumerable<Encounter> nzzzp_ = context.Operators.Where<Encounter>(nzzzn_, nzzzo_);
                    object nzzzq_(Encounter @this)
                    {
                        Period qzzzo_ = @this?.Period;
                        CqlInterval<CqlDateTime> qzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzo_);
                        CqlDateTime qzzzq_ = context.Operators.End(qzzzp_);

                        return qzzzq_;
                    };
                    IEnumerable<Encounter> nzzzr_ = context.Operators.SortBy<Encounter>(nzzzp_, nzzzq_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter nzzzs_ = context.Operators.Last<Encounter>(nzzzr_);
                    Period nzzzt_ = nzzzs_?.Period;
                    CqlInterval<CqlDateTime> nzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzt_);
                    CqlDateTime nzzzv_ = context.Operators.Start(nzzzu_);
                    CqlInterval<CqlDateTime> nzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzh_);
                    CqlDateTime nzzzy_ = context.Operators.Start(nzzzx_);
                    CqlInterval<CqlDateTime> nzzzz_ = context.Operators.Interval(nzzzl_, nzzzv_ ?? nzzzy_, true, true);
                    bool? ozzza_ = context.Operators.In<CqlDateTime>(mzzzw_, nzzzz_, default);
                    IEnumerable<Encounter> ozzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? ozzzd_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> qzzzr_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? qzzzs_ = qzzzr_?.Value;
                        Code<Encounter.EncounterStatus> qzzzt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(qzzzs_);
                        bool? qzzzu_ = context.Operators.Equal(qzzzt_, "finished");
                        Period qzzzv_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> qzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzv_);
                        CqlDateTime qzzzx_ = context.Operators.End(qzzzw_);
                        Period qzzzy_ = Visit?.Period;
                        CqlInterval<CqlDateTime> qzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzy_);
                        CqlDateTime rzzza_ = context.Operators.Start(qzzzz_);
                        CqlQuantity rzzzb_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime rzzzc_ = context.Operators.Subtract(rzzza_, rzzzb_);
                        CqlInterval<CqlDateTime> rzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzy_);
                        CqlDateTime rzzzf_ = context.Operators.Start(rzzze_);
                        CqlInterval<CqlDateTime> rzzzg_ = context.Operators.Interval(rzzzc_, rzzzf_, true, true);
                        bool? rzzzh_ = context.Operators.In<CqlDateTime>(qzzzx_, rzzzg_, default);
                        CqlInterval<CqlDateTime> rzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzy_);
                        CqlDateTime rzzzk_ = context.Operators.Start(rzzzj_);
                        bool? rzzzl_ = context.Operators.Not((bool?)(rzzzk_ is null));
                        bool? rzzzm_ = context.Operators.And(rzzzh_, rzzzl_);
                        bool? rzzzn_ = context.Operators.And(qzzzu_, rzzzm_);

                        return rzzzn_;
                    };
                    IEnumerable<Encounter> ozzze_ = context.Operators.Where<Encounter>(ozzzc_, ozzzd_);
                    object ozzzf_(Encounter @this)
                    {
                        Period rzzzo_ = @this?.Period;
                        CqlInterval<CqlDateTime> rzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzo_);
                        CqlDateTime rzzzq_ = context.Operators.End(rzzzp_);

                        return rzzzq_;
                    };
                    IEnumerable<Encounter> ozzzg_ = context.Operators.SortBy<Encounter>(ozzze_, ozzzf_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter ozzzh_ = context.Operators.Last<Encounter>(ozzzg_);
                    Period ozzzi_ = ozzzh_?.Period;
                    CqlInterval<CqlDateTime> ozzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzi_);
                    CqlDateTime ozzzk_ = context.Operators.Start(ozzzj_);
                    CqlInterval<CqlDateTime> ozzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzh_);
                    CqlDateTime ozzzn_ = context.Operators.Start(ozzzm_);
                    bool? ozzzo_ = context.Operators.Not((bool?)((ozzzk_ ?? ozzzn_) is null));
                    bool? ozzzp_ = context.Operators.And(ozzza_, ozzzo_);
                    bool? ozzzq_ = context.Operators.And(mzzzt_, ozzzp_);

                    return ozzzq_;
                };
                IEnumerable<Encounter> zzzm_ = context.Operators.Where<Encounter>(zzzk_, zzzl_);
                object zzzn_(Encounter @this)
                {
                    Period rzzzr_ = @this?.Period;
                    CqlInterval<CqlDateTime> rzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzr_);
                    CqlDateTime rzzzt_ = context.Operators.End(rzzzs_);

                    return rzzzt_;
                };
                IEnumerable<Encounter> zzzo_ = context.Operators.SortBy<Encounter>(zzzm_, zzzn_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter zzzp_ = context.Operators.Last<Encounter>(zzzo_);
                Period zzzq_ = zzzp_?.Period;
                CqlInterval<CqlDateTime> zzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzq_);
                CqlDateTime zzzs_ = context.Operators.Start(zzzr_);
                IEnumerable<Encounter> zzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? zzzv_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> rzzzu_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? rzzzv_ = rzzzu_?.Value;
                    Code<Encounter.EncounterStatus> rzzzw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rzzzv_);
                    bool? rzzzx_ = context.Operators.Equal(rzzzw_, "finished");
                    Period rzzzy_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> rzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzy_);
                    CqlDateTime szzza_ = context.Operators.End(rzzzz_);
                    Period szzzb_ = Visit?.Period;
                    CqlInterval<CqlDateTime> szzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzb_);
                    CqlDateTime szzzd_ = context.Operators.Start(szzzc_);
                    CqlQuantity szzze_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime szzzf_ = context.Operators.Subtract(szzzd_, szzze_);
                    CqlInterval<CqlDateTime> szzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzb_);
                    CqlDateTime szzzi_ = context.Operators.Start(szzzh_);
                    CqlInterval<CqlDateTime> szzzj_ = context.Operators.Interval(szzzf_, szzzi_, true, true);
                    bool? szzzk_ = context.Operators.In<CqlDateTime>(szzza_, szzzj_, default);
                    CqlInterval<CqlDateTime> szzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzb_);
                    CqlDateTime szzzn_ = context.Operators.Start(szzzm_);
                    bool? szzzo_ = context.Operators.Not((bool?)(szzzn_ is null));
                    bool? szzzp_ = context.Operators.And(szzzk_, szzzo_);
                    bool? szzzq_ = context.Operators.And(rzzzx_, szzzp_);

                    return szzzq_;
                };
                IEnumerable<Encounter> zzzw_ = context.Operators.Where<Encounter>(zzzu_, zzzv_);
                object zzzx_(Encounter @this)
                {
                    Period szzzr_ = @this?.Period;
                    CqlInterval<CqlDateTime> szzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzr_);
                    CqlDateTime szzzt_ = context.Operators.End(szzzs_);

                    return szzzt_;
                };
                IEnumerable<Encounter> zzzy_ = context.Operators.SortBy<Encounter>(zzzw_, zzzx_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter zzzz_ = context.Operators.Last<Encounter>(zzzy_);
                Period azzza_ = zzzz_?.Period;
                CqlInterval<CqlDateTime> azzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzza_);
                CqlDateTime azzzc_ = context.Operators.Start(azzzb_);
                CqlInterval<CqlDateTime> azzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzf_);
                CqlDateTime azzzf_ = context.Operators.Start(azzze_);
                bool? azzzg_ = context.Operators.Not((bool?)((zzzs_ ?? azzzc_ ?? azzzf_) is null));
                bool? azzzh_ = context.Operators.And(zzzi_, azzzg_);

                return azzzh_;
            };
            IEnumerable<Encounter> wzza_ = context.Operators.Where<Encounter>(vzzy_, vzzz_);
            object wzzb_(Encounter @this)
            {
                Period szzzu_ = @this?.Period;
                CqlInterval<CqlDateTime> szzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzu_);
                CqlDateTime szzzw_ = context.Operators.End(szzzv_);

                return szzzw_;
            };
            IEnumerable<Encounter> wzzc_ = context.Operators.SortBy<Encounter>(wzza_, wzzb_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter wzzd_ = context.Operators.Last<Encounter>(wzzc_);
            Period wzze_ = wzzd_?.Period;
            CqlInterval<CqlDateTime> wzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzze_);
            CqlDateTime wzzg_ = context.Operators.Start(wzzf_);
            CqlValueSet wzzh_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> wzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? wzzj_(Encounter LastED)
            {
                Code<Encounter.EncounterStatus> szzzx_ = LastED?.StatusElement;
                Encounter.EncounterStatus? szzzy_ = szzzx_?.Value;
                Code<Encounter.EncounterStatus> szzzz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(szzzy_);
                bool? tzzza_ = context.Operators.Equal(szzzz_, "finished");
                Period tzzzb_ = LastED?.Period;
                CqlInterval<CqlDateTime> tzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzb_);
                CqlDateTime tzzzd_ = context.Operators.End(tzzzc_);
                CqlValueSet tzzze_ = this.Observation_Services(context);
                IEnumerable<Encounter> tzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? tzzzg_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> uzzzy_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? uzzzz_ = uzzzy_?.Value;
                    Code<Encounter.EncounterStatus> vzzza_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(uzzzz_);
                    bool? vzzzb_ = context.Operators.Equal(vzzza_, "finished");
                    Period vzzzc_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> vzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzc_);
                    CqlDateTime vzzze_ = context.Operators.End(vzzzd_);
                    Period vzzzf_ = Visit?.Period;
                    CqlInterval<CqlDateTime> vzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzf_);
                    CqlDateTime vzzzh_ = context.Operators.Start(vzzzg_);
                    CqlQuantity vzzzi_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime vzzzj_ = context.Operators.Subtract(vzzzh_, vzzzi_);
                    CqlInterval<CqlDateTime> vzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzf_);
                    CqlDateTime vzzzm_ = context.Operators.Start(vzzzl_);
                    CqlInterval<CqlDateTime> vzzzn_ = context.Operators.Interval(vzzzj_, vzzzm_, true, true);
                    bool? vzzzo_ = context.Operators.In<CqlDateTime>(vzzze_, vzzzn_, default);
                    CqlInterval<CqlDateTime> vzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzf_);
                    CqlDateTime vzzzr_ = context.Operators.Start(vzzzq_);
                    bool? vzzzs_ = context.Operators.Not((bool?)(vzzzr_ is null));
                    bool? vzzzt_ = context.Operators.And(vzzzo_, vzzzs_);
                    bool? vzzzu_ = context.Operators.And(vzzzb_, vzzzt_);

                    return vzzzu_;
                };
                IEnumerable<Encounter> tzzzh_ = context.Operators.Where<Encounter>(tzzzf_, tzzzg_);
                object tzzzi_(Encounter @this)
                {
                    Period vzzzv_ = @this?.Period;
                    CqlInterval<CqlDateTime> vzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzv_);
                    CqlDateTime vzzzx_ = context.Operators.End(vzzzw_);

                    return vzzzx_;
                };
                IEnumerable<Encounter> tzzzj_ = context.Operators.SortBy<Encounter>(tzzzh_, tzzzi_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter tzzzk_ = context.Operators.Last<Encounter>(tzzzj_);
                Period tzzzl_ = tzzzk_?.Period;
                CqlInterval<CqlDateTime> tzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzl_);
                CqlDateTime tzzzn_ = context.Operators.Start(tzzzm_);
                Period tzzzo_ = Visit?.Period;
                CqlInterval<CqlDateTime> tzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzo_);
                CqlDateTime tzzzq_ = context.Operators.Start(tzzzp_);
                CqlQuantity tzzzr_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime tzzzs_ = context.Operators.Subtract(tzzzn_ ?? tzzzq_, tzzzr_);
                IEnumerable<Encounter> tzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? tzzzv_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> vzzzy_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? vzzzz_ = vzzzy_?.Value;
                    Code<Encounter.EncounterStatus> wzzza_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(vzzzz_);
                    bool? wzzzb_ = context.Operators.Equal(wzzza_, "finished");
                    Period wzzzc_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> wzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzc_);
                    CqlDateTime wzzze_ = context.Operators.End(wzzzd_);
                    Period wzzzf_ = Visit?.Period;
                    CqlInterval<CqlDateTime> wzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzf_);
                    CqlDateTime wzzzh_ = context.Operators.Start(wzzzg_);
                    CqlQuantity wzzzi_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime wzzzj_ = context.Operators.Subtract(wzzzh_, wzzzi_);
                    CqlInterval<CqlDateTime> wzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzf_);
                    CqlDateTime wzzzm_ = context.Operators.Start(wzzzl_);
                    CqlInterval<CqlDateTime> wzzzn_ = context.Operators.Interval(wzzzj_, wzzzm_, true, true);
                    bool? wzzzo_ = context.Operators.In<CqlDateTime>(wzzze_, wzzzn_, default);
                    CqlInterval<CqlDateTime> wzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzf_);
                    CqlDateTime wzzzr_ = context.Operators.Start(wzzzq_);
                    bool? wzzzs_ = context.Operators.Not((bool?)(wzzzr_ is null));
                    bool? wzzzt_ = context.Operators.And(wzzzo_, wzzzs_);
                    bool? wzzzu_ = context.Operators.And(wzzzb_, wzzzt_);

                    return wzzzu_;
                };
                IEnumerable<Encounter> tzzzw_ = context.Operators.Where<Encounter>(tzzzu_, tzzzv_);
                object tzzzx_(Encounter @this)
                {
                    Period wzzzv_ = @this?.Period;
                    CqlInterval<CqlDateTime> wzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzv_);
                    CqlDateTime wzzzx_ = context.Operators.End(wzzzw_);

                    return wzzzx_;
                };
                IEnumerable<Encounter> tzzzy_ = context.Operators.SortBy<Encounter>(tzzzw_, tzzzx_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter tzzzz_ = context.Operators.Last<Encounter>(tzzzy_);
                Period uzzza_ = tzzzz_?.Period;
                CqlInterval<CqlDateTime> uzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzza_);
                CqlDateTime uzzzc_ = context.Operators.Start(uzzzb_);
                CqlInterval<CqlDateTime> uzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzo_);
                CqlDateTime uzzzf_ = context.Operators.Start(uzzze_);
                CqlInterval<CqlDateTime> uzzzg_ = context.Operators.Interval(tzzzs_, uzzzc_ ?? uzzzf_, true, true);
                bool? uzzzh_ = context.Operators.In<CqlDateTime>(tzzzd_, uzzzg_, default);
                IEnumerable<Encounter> uzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? uzzzk_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> wzzzy_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? wzzzz_ = wzzzy_?.Value;
                    Code<Encounter.EncounterStatus> xzzza_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(wzzzz_);
                    bool? xzzzb_ = context.Operators.Equal(xzzza_, "finished");
                    Period xzzzc_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> xzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzc_);
                    CqlDateTime xzzze_ = context.Operators.End(xzzzd_);
                    Period xzzzf_ = Visit?.Period;
                    CqlInterval<CqlDateTime> xzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzf_);
                    CqlDateTime xzzzh_ = context.Operators.Start(xzzzg_);
                    CqlQuantity xzzzi_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime xzzzj_ = context.Operators.Subtract(xzzzh_, xzzzi_);
                    CqlInterval<CqlDateTime> xzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzf_);
                    CqlDateTime xzzzm_ = context.Operators.Start(xzzzl_);
                    CqlInterval<CqlDateTime> xzzzn_ = context.Operators.Interval(xzzzj_, xzzzm_, true, true);
                    bool? xzzzo_ = context.Operators.In<CqlDateTime>(xzzze_, xzzzn_, default);
                    CqlInterval<CqlDateTime> xzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzf_);
                    CqlDateTime xzzzr_ = context.Operators.Start(xzzzq_);
                    bool? xzzzs_ = context.Operators.Not((bool?)(xzzzr_ is null));
                    bool? xzzzt_ = context.Operators.And(xzzzo_, xzzzs_);
                    bool? xzzzu_ = context.Operators.And(xzzzb_, xzzzt_);

                    return xzzzu_;
                };
                IEnumerable<Encounter> uzzzl_ = context.Operators.Where<Encounter>(uzzzj_, uzzzk_);
                object uzzzm_(Encounter @this)
                {
                    Period xzzzv_ = @this?.Period;
                    CqlInterval<CqlDateTime> xzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzv_);
                    CqlDateTime xzzzx_ = context.Operators.End(xzzzw_);

                    return xzzzx_;
                };
                IEnumerable<Encounter> uzzzn_ = context.Operators.SortBy<Encounter>(uzzzl_, uzzzm_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter uzzzo_ = context.Operators.Last<Encounter>(uzzzn_);
                Period uzzzp_ = uzzzo_?.Period;
                CqlInterval<CqlDateTime> uzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzp_);
                CqlDateTime uzzzr_ = context.Operators.Start(uzzzq_);
                CqlInterval<CqlDateTime> uzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzo_);
                CqlDateTime uzzzu_ = context.Operators.Start(uzzzt_);
                bool? uzzzv_ = context.Operators.Not((bool?)((uzzzr_ ?? uzzzu_) is null));
                bool? uzzzw_ = context.Operators.And(uzzzh_, uzzzv_);
                bool? uzzzx_ = context.Operators.And(tzzza_, uzzzw_);

                return uzzzx_;
            };
            IEnumerable<Encounter> wzzk_ = context.Operators.Where<Encounter>(wzzi_, wzzj_);
            object wzzl_(Encounter @this)
            {
                Period xzzzy_ = @this?.Period;
                CqlInterval<CqlDateTime> xzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzy_);
                CqlDateTime yzzza_ = context.Operators.End(xzzzz_);

                return yzzza_;
            };
            IEnumerable<Encounter> wzzm_ = context.Operators.SortBy<Encounter>(wzzk_, wzzl_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter wzzn_ = context.Operators.Last<Encounter>(wzzm_);
            Period wzzo_ = wzzn_?.Period;
            CqlInterval<CqlDateTime> wzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzo_);
            CqlDateTime wzzq_ = context.Operators.Start(wzzp_);
            CqlValueSet wzzr_ = this.Observation_Services(context);
            IEnumerable<Encounter> wzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? wzzt_(Encounter LastObs)
            {
                Code<Encounter.EncounterStatus> yzzzb_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? yzzzc_ = yzzzb_?.Value;
                Code<Encounter.EncounterStatus> yzzzd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(yzzzc_);
                bool? yzzze_ = context.Operators.Equal(yzzzd_, "finished");
                Period yzzzf_ = LastObs?.Period;
                CqlInterval<CqlDateTime> yzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzf_);
                CqlDateTime yzzzh_ = context.Operators.End(yzzzg_);
                Period yzzzi_ = Visit?.Period;
                CqlInterval<CqlDateTime> yzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzi_);
                CqlDateTime yzzzk_ = context.Operators.Start(yzzzj_);
                CqlQuantity yzzzl_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime yzzzm_ = context.Operators.Subtract(yzzzk_, yzzzl_);
                CqlInterval<CqlDateTime> yzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzi_);
                CqlDateTime yzzzp_ = context.Operators.Start(yzzzo_);
                CqlInterval<CqlDateTime> yzzzq_ = context.Operators.Interval(yzzzm_, yzzzp_, true, true);
                bool? yzzzr_ = context.Operators.In<CqlDateTime>(yzzzh_, yzzzq_, default);
                CqlInterval<CqlDateTime> yzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzi_);
                CqlDateTime yzzzu_ = context.Operators.Start(yzzzt_);
                bool? yzzzv_ = context.Operators.Not((bool?)(yzzzu_ is null));
                bool? yzzzw_ = context.Operators.And(yzzzr_, yzzzv_);
                bool? yzzzx_ = context.Operators.And(yzzze_, yzzzw_);

                return yzzzx_;
            };
            IEnumerable<Encounter> wzzu_ = context.Operators.Where<Encounter>(wzzs_, wzzt_);
            object wzzv_(Encounter @this)
            {
                Period yzzzy_ = @this?.Period;
                CqlInterval<CqlDateTime> yzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzy_);
                CqlDateTime zzzza_ = context.Operators.End(yzzzz_);

                return zzzza_;
            };
            IEnumerable<Encounter> wzzw_ = context.Operators.SortBy<Encounter>(wzzu_, wzzv_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter wzzx_ = context.Operators.Last<Encounter>(wzzw_);
            Period wzzy_ = wzzx_?.Period;
            CqlInterval<CqlDateTime> wzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzy_);
            CqlDateTime xzza_ = context.Operators.Start(wzzz_);
            Period xzzb_ = Visit?.Period;
            CqlInterval<CqlDateTime> xzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzb_);
            CqlDateTime xzzd_ = context.Operators.Start(xzzc_);
            CqlInterval<CqlDateTime> xzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzb_);
            CqlDateTime xzzg_ = context.Operators.End(xzzf_);
            CqlInterval<CqlDateTime> xzzh_ = context.Operators.Interval(wzzg_ ?? wzzq_ ?? xzza_ ?? xzzd_, xzzg_, true, true);

            return xzzh_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> vzzu_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)vzzs_, vzzt_);
        IEnumerable<CqlInterval<CqlDateTime>> vzzv_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(vzzu_);
        CqlInterval<CqlDateTime> vzzw_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(vzzv_);

        return vzzw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Hospitalization with Observation and Outpatient Surgery Service returns the total interval from the start of any immediately prior emergency department visit, outpatient surgery visit or observation visit to the discharge of the given encounter.")]
    public CqlInterval<CqlDateTime> hospitalizationWithObservationAndOutpatientSurgeryService(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] zzzzb_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> zzzzc_(Encounter Visit)
        {
            CqlValueSet zzzzg_ = this.Outpatient_Surgery_Service(context);
            IEnumerable<Encounter> zzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? zzzzi_(Encounter LastSurgeryOP)
            {
                Period azzzzr_ = LastSurgeryOP?.Period;
                CqlInterval<CqlDateTime> azzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzr_);
                CqlDateTime azzzzt_ = context.Operators.End(azzzzs_);
                CqlValueSet azzzzu_ = this.Emergency_Department_Visit(context);
                IEnumerable<Encounter> azzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? azzzzw_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> dzzzzr_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? dzzzzs_ = dzzzzr_?.Value;
                    Code<Encounter.EncounterStatus> dzzzzt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dzzzzs_);
                    bool? dzzzzu_ = context.Operators.Equal(dzzzzt_, "finished");
                    Period dzzzzv_ = LastED?.Period;
                    CqlInterval<CqlDateTime> dzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzv_);
                    CqlDateTime dzzzzx_ = context.Operators.End(dzzzzw_);
                    CqlValueSet dzzzzy_ = this.Observation_Services(context);
                    IEnumerable<Encounter> dzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? ezzzza_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> fzzzzs_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? fzzzzt_ = fzzzzs_?.Value;
                        Code<Encounter.EncounterStatus> fzzzzu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fzzzzt_);
                        bool? fzzzzv_ = context.Operators.Equal(fzzzzu_, "finished");
                        Period fzzzzw_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> fzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzw_);
                        CqlDateTime fzzzzy_ = context.Operators.End(fzzzzx_);
                        Period fzzzzz_ = Visit?.Period;
                        CqlInterval<CqlDateTime> gzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzz_);
                        CqlDateTime gzzzzb_ = context.Operators.Start(gzzzza_);
                        CqlQuantity gzzzzc_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime gzzzzd_ = context.Operators.Subtract(gzzzzb_, gzzzzc_);
                        CqlInterval<CqlDateTime> gzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzz_);
                        CqlDateTime gzzzzg_ = context.Operators.Start(gzzzzf_);
                        CqlInterval<CqlDateTime> gzzzzh_ = context.Operators.Interval(gzzzzd_, gzzzzg_, true, true);
                        bool? gzzzzi_ = context.Operators.In<CqlDateTime>(fzzzzy_, gzzzzh_, default);
                        CqlInterval<CqlDateTime> gzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzz_);
                        CqlDateTime gzzzzl_ = context.Operators.Start(gzzzzk_);
                        bool? gzzzzm_ = context.Operators.Not((bool?)(gzzzzl_ is null));
                        bool? gzzzzn_ = context.Operators.And(gzzzzi_, gzzzzm_);
                        bool? gzzzzo_ = context.Operators.And(fzzzzv_, gzzzzn_);

                        return gzzzzo_;
                    };
                    IEnumerable<Encounter> ezzzzb_ = context.Operators.Where<Encounter>(dzzzzz_, ezzzza_);
                    object ezzzzc_(Encounter @this)
                    {
                        Period gzzzzp_ = @this?.Period;
                        CqlInterval<CqlDateTime> gzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzp_);
                        CqlDateTime gzzzzr_ = context.Operators.End(gzzzzq_);

                        return gzzzzr_;
                    };
                    IEnumerable<Encounter> ezzzzd_ = context.Operators.SortBy<Encounter>(ezzzzb_, ezzzzc_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter ezzzze_ = context.Operators.Last<Encounter>(ezzzzd_);
                    Period ezzzzf_ = ezzzze_?.Period;
                    CqlInterval<CqlDateTime> ezzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzf_);
                    CqlDateTime ezzzzh_ = context.Operators.Start(ezzzzg_);
                    Period ezzzzi_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ezzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzi_);
                    CqlDateTime ezzzzk_ = context.Operators.Start(ezzzzj_);
                    CqlQuantity ezzzzl_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ezzzzm_ = context.Operators.Subtract(ezzzzh_ ?? ezzzzk_, ezzzzl_);
                    IEnumerable<Encounter> ezzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? ezzzzp_(Encounter LastObs)
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
                    IEnumerable<Encounter> ezzzzq_ = context.Operators.Where<Encounter>(ezzzzo_, ezzzzp_);
                    object ezzzzr_(Encounter @this)
                    {
                        Period hzzzzp_ = @this?.Period;
                        CqlInterval<CqlDateTime> hzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzp_);
                        CqlDateTime hzzzzr_ = context.Operators.End(hzzzzq_);

                        return hzzzzr_;
                    };
                    IEnumerable<Encounter> ezzzzs_ = context.Operators.SortBy<Encounter>(ezzzzq_, ezzzzr_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter ezzzzt_ = context.Operators.Last<Encounter>(ezzzzs_);
                    Period ezzzzu_ = ezzzzt_?.Period;
                    CqlInterval<CqlDateTime> ezzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzu_);
                    CqlDateTime ezzzzw_ = context.Operators.Start(ezzzzv_);
                    CqlInterval<CqlDateTime> ezzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzi_);
                    CqlDateTime ezzzzz_ = context.Operators.Start(ezzzzy_);
                    CqlInterval<CqlDateTime> fzzzza_ = context.Operators.Interval(ezzzzm_, ezzzzw_ ?? ezzzzz_, true, true);
                    bool? fzzzzb_ = context.Operators.In<CqlDateTime>(dzzzzx_, fzzzza_, default);
                    IEnumerable<Encounter> fzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? fzzzze_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> hzzzzs_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? hzzzzt_ = hzzzzs_?.Value;
                        Code<Encounter.EncounterStatus> hzzzzu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hzzzzt_);
                        bool? hzzzzv_ = context.Operators.Equal(hzzzzu_, "finished");
                        Period hzzzzw_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> hzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzw_);
                        CqlDateTime hzzzzy_ = context.Operators.End(hzzzzx_);
                        Period hzzzzz_ = Visit?.Period;
                        CqlInterval<CqlDateTime> izzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzz_);
                        CqlDateTime izzzzb_ = context.Operators.Start(izzzza_);
                        CqlQuantity izzzzc_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime izzzzd_ = context.Operators.Subtract(izzzzb_, izzzzc_);
                        CqlInterval<CqlDateTime> izzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzz_);
                        CqlDateTime izzzzg_ = context.Operators.Start(izzzzf_);
                        CqlInterval<CqlDateTime> izzzzh_ = context.Operators.Interval(izzzzd_, izzzzg_, true, true);
                        bool? izzzzi_ = context.Operators.In<CqlDateTime>(hzzzzy_, izzzzh_, default);
                        CqlInterval<CqlDateTime> izzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzz_);
                        CqlDateTime izzzzl_ = context.Operators.Start(izzzzk_);
                        bool? izzzzm_ = context.Operators.Not((bool?)(izzzzl_ is null));
                        bool? izzzzn_ = context.Operators.And(izzzzi_, izzzzm_);
                        bool? izzzzo_ = context.Operators.And(hzzzzv_, izzzzn_);

                        return izzzzo_;
                    };
                    IEnumerable<Encounter> fzzzzf_ = context.Operators.Where<Encounter>(fzzzzd_, fzzzze_);
                    object fzzzzg_(Encounter @this)
                    {
                        Period izzzzp_ = @this?.Period;
                        CqlInterval<CqlDateTime> izzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzp_);
                        CqlDateTime izzzzr_ = context.Operators.End(izzzzq_);

                        return izzzzr_;
                    };
                    IEnumerable<Encounter> fzzzzh_ = context.Operators.SortBy<Encounter>(fzzzzf_, fzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter fzzzzi_ = context.Operators.Last<Encounter>(fzzzzh_);
                    Period fzzzzj_ = fzzzzi_?.Period;
                    CqlInterval<CqlDateTime> fzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzj_);
                    CqlDateTime fzzzzl_ = context.Operators.Start(fzzzzk_);
                    CqlInterval<CqlDateTime> fzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzi_);
                    CqlDateTime fzzzzo_ = context.Operators.Start(fzzzzn_);
                    bool? fzzzzp_ = context.Operators.Not((bool?)((fzzzzl_ ?? fzzzzo_) is null));
                    bool? fzzzzq_ = context.Operators.And(fzzzzb_, fzzzzp_);
                    bool? fzzzzr_ = context.Operators.And(dzzzzu_, fzzzzq_);

                    return fzzzzr_;
                };
                IEnumerable<Encounter> azzzzx_ = context.Operators.Where<Encounter>(azzzzv_, azzzzw_);
                object azzzzy_(Encounter @this)
                {
                    Period izzzzs_ = @this?.Period;
                    CqlInterval<CqlDateTime> izzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzs_);
                    CqlDateTime izzzzu_ = context.Operators.End(izzzzt_);

                    return izzzzu_;
                };
                IEnumerable<Encounter> azzzzz_ = context.Operators.SortBy<Encounter>(azzzzx_, azzzzy_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bzzzza_ = context.Operators.Last<Encounter>(azzzzz_);
                Period bzzzzb_ = bzzzza_?.Period;
                CqlInterval<CqlDateTime> bzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzb_);
                CqlDateTime bzzzzd_ = context.Operators.Start(bzzzzc_);
                CqlValueSet bzzzze_ = this.Observation_Services(context);
                IEnumerable<Encounter> bzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? bzzzzg_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> izzzzv_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? izzzzw_ = izzzzv_?.Value;
                    Code<Encounter.EncounterStatus> izzzzx_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(izzzzw_);
                    bool? izzzzy_ = context.Operators.Equal(izzzzx_, "finished");
                    Period izzzzz_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> jzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzz_);
                    CqlDateTime jzzzzb_ = context.Operators.End(jzzzza_);
                    Period jzzzzc_ = Visit?.Period;
                    CqlInterval<CqlDateTime> jzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzc_);
                    CqlDateTime jzzzze_ = context.Operators.Start(jzzzzd_);
                    CqlQuantity jzzzzf_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime jzzzzg_ = context.Operators.Subtract(jzzzze_, jzzzzf_);
                    CqlInterval<CqlDateTime> jzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzc_);
                    CqlDateTime jzzzzj_ = context.Operators.Start(jzzzzi_);
                    CqlInterval<CqlDateTime> jzzzzk_ = context.Operators.Interval(jzzzzg_, jzzzzj_, true, true);
                    bool? jzzzzl_ = context.Operators.In<CqlDateTime>(jzzzzb_, jzzzzk_, default);
                    CqlInterval<CqlDateTime> jzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzc_);
                    CqlDateTime jzzzzo_ = context.Operators.Start(jzzzzn_);
                    bool? jzzzzp_ = context.Operators.Not((bool?)(jzzzzo_ is null));
                    bool? jzzzzq_ = context.Operators.And(jzzzzl_, jzzzzp_);
                    bool? jzzzzr_ = context.Operators.And(izzzzy_, jzzzzq_);

                    return jzzzzr_;
                };
                IEnumerable<Encounter> bzzzzh_ = context.Operators.Where<Encounter>(bzzzzf_, bzzzzg_);
                object bzzzzi_(Encounter @this)
                {
                    Period jzzzzs_ = @this?.Period;
                    CqlInterval<CqlDateTime> jzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzs_);
                    CqlDateTime jzzzzu_ = context.Operators.End(jzzzzt_);

                    return jzzzzu_;
                };
                IEnumerable<Encounter> bzzzzj_ = context.Operators.SortBy<Encounter>(bzzzzh_, bzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bzzzzk_ = context.Operators.Last<Encounter>(bzzzzj_);
                Period bzzzzl_ = bzzzzk_?.Period;
                CqlInterval<CqlDateTime> bzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzl_);
                CqlDateTime bzzzzn_ = context.Operators.Start(bzzzzm_);
                Period bzzzzo_ = Visit?.Period;
                CqlInterval<CqlDateTime> bzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzo_);
                CqlDateTime bzzzzq_ = context.Operators.Start(bzzzzp_);
                CqlQuantity bzzzzr_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime bzzzzs_ = context.Operators.Subtract(bzzzzd_ ?? bzzzzn_ ?? bzzzzq_, bzzzzr_);
                IEnumerable<Encounter> bzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? bzzzzv_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> jzzzzv_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? jzzzzw_ = jzzzzv_?.Value;
                    Code<Encounter.EncounterStatus> jzzzzx_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jzzzzw_);
                    bool? jzzzzy_ = context.Operators.Equal(jzzzzx_, "finished");
                    Period jzzzzz_ = LastED?.Period;
                    CqlInterval<CqlDateTime> kzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzz_);
                    CqlDateTime kzzzzb_ = context.Operators.End(kzzzza_);
                    CqlValueSet kzzzzc_ = this.Observation_Services(context);
                    IEnumerable<Encounter> kzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? kzzzze_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> lzzzzw_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? lzzzzx_ = lzzzzw_?.Value;
                        Code<Encounter.EncounterStatus> lzzzzy_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lzzzzx_);
                        bool? lzzzzz_ = context.Operators.Equal(lzzzzy_, "finished");
                        Period mzzzza_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> mzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzza_);
                        CqlDateTime mzzzzc_ = context.Operators.End(mzzzzb_);
                        Period mzzzzd_ = Visit?.Period;
                        CqlInterval<CqlDateTime> mzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzd_);
                        CqlDateTime mzzzzf_ = context.Operators.Start(mzzzze_);
                        CqlQuantity mzzzzg_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime mzzzzh_ = context.Operators.Subtract(mzzzzf_, mzzzzg_);
                        CqlInterval<CqlDateTime> mzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzd_);
                        CqlDateTime mzzzzk_ = context.Operators.Start(mzzzzj_);
                        CqlInterval<CqlDateTime> mzzzzl_ = context.Operators.Interval(mzzzzh_, mzzzzk_, true, true);
                        bool? mzzzzm_ = context.Operators.In<CqlDateTime>(mzzzzc_, mzzzzl_, default);
                        CqlInterval<CqlDateTime> mzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzd_);
                        CqlDateTime mzzzzp_ = context.Operators.Start(mzzzzo_);
                        bool? mzzzzq_ = context.Operators.Not((bool?)(mzzzzp_ is null));
                        bool? mzzzzr_ = context.Operators.And(mzzzzm_, mzzzzq_);
                        bool? mzzzzs_ = context.Operators.And(lzzzzz_, mzzzzr_);

                        return mzzzzs_;
                    };
                    IEnumerable<Encounter> kzzzzf_ = context.Operators.Where<Encounter>(kzzzzd_, kzzzze_);
                    object kzzzzg_(Encounter @this)
                    {
                        Period mzzzzt_ = @this?.Period;
                        CqlInterval<CqlDateTime> mzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzt_);
                        CqlDateTime mzzzzv_ = context.Operators.End(mzzzzu_);

                        return mzzzzv_;
                    };
                    IEnumerable<Encounter> kzzzzh_ = context.Operators.SortBy<Encounter>(kzzzzf_, kzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter kzzzzi_ = context.Operators.Last<Encounter>(kzzzzh_);
                    Period kzzzzj_ = kzzzzi_?.Period;
                    CqlInterval<CqlDateTime> kzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzj_);
                    CqlDateTime kzzzzl_ = context.Operators.Start(kzzzzk_);
                    Period kzzzzm_ = Visit?.Period;
                    CqlInterval<CqlDateTime> kzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzm_);
                    CqlDateTime kzzzzo_ = context.Operators.Start(kzzzzn_);
                    CqlQuantity kzzzzp_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime kzzzzq_ = context.Operators.Subtract(kzzzzl_ ?? kzzzzo_, kzzzzp_);
                    IEnumerable<Encounter> kzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? kzzzzt_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> mzzzzw_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? mzzzzx_ = mzzzzw_?.Value;
                        Code<Encounter.EncounterStatus> mzzzzy_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(mzzzzx_);
                        bool? mzzzzz_ = context.Operators.Equal(mzzzzy_, "finished");
                        Period nzzzza_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> nzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzza_);
                        CqlDateTime nzzzzc_ = context.Operators.End(nzzzzb_);
                        Period nzzzzd_ = Visit?.Period;
                        CqlInterval<CqlDateTime> nzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzd_);
                        CqlDateTime nzzzzf_ = context.Operators.Start(nzzzze_);
                        CqlQuantity nzzzzg_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime nzzzzh_ = context.Operators.Subtract(nzzzzf_, nzzzzg_);
                        CqlInterval<CqlDateTime> nzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzd_);
                        CqlDateTime nzzzzk_ = context.Operators.Start(nzzzzj_);
                        CqlInterval<CqlDateTime> nzzzzl_ = context.Operators.Interval(nzzzzh_, nzzzzk_, true, true);
                        bool? nzzzzm_ = context.Operators.In<CqlDateTime>(nzzzzc_, nzzzzl_, default);
                        CqlInterval<CqlDateTime> nzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzd_);
                        CqlDateTime nzzzzp_ = context.Operators.Start(nzzzzo_);
                        bool? nzzzzq_ = context.Operators.Not((bool?)(nzzzzp_ is null));
                        bool? nzzzzr_ = context.Operators.And(nzzzzm_, nzzzzq_);
                        bool? nzzzzs_ = context.Operators.And(mzzzzz_, nzzzzr_);

                        return nzzzzs_;
                    };
                    IEnumerable<Encounter> kzzzzu_ = context.Operators.Where<Encounter>(kzzzzs_, kzzzzt_);
                    object kzzzzv_(Encounter @this)
                    {
                        Period nzzzzt_ = @this?.Period;
                        CqlInterval<CqlDateTime> nzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzt_);
                        CqlDateTime nzzzzv_ = context.Operators.End(nzzzzu_);

                        return nzzzzv_;
                    };
                    IEnumerable<Encounter> kzzzzw_ = context.Operators.SortBy<Encounter>(kzzzzu_, kzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter kzzzzx_ = context.Operators.Last<Encounter>(kzzzzw_);
                    Period kzzzzy_ = kzzzzx_?.Period;
                    CqlInterval<CqlDateTime> kzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzy_);
                    CqlDateTime lzzzza_ = context.Operators.Start(kzzzzz_);
                    CqlInterval<CqlDateTime> lzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzm_);
                    CqlDateTime lzzzzd_ = context.Operators.Start(lzzzzc_);
                    CqlInterval<CqlDateTime> lzzzze_ = context.Operators.Interval(kzzzzq_, lzzzza_ ?? lzzzzd_, true, true);
                    bool? lzzzzf_ = context.Operators.In<CqlDateTime>(kzzzzb_, lzzzze_, default);
                    IEnumerable<Encounter> lzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? lzzzzi_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> nzzzzw_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? nzzzzx_ = nzzzzw_?.Value;
                        Code<Encounter.EncounterStatus> nzzzzy_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(nzzzzx_);
                        bool? nzzzzz_ = context.Operators.Equal(nzzzzy_, "finished");
                        Period ozzzza_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> ozzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzza_);
                        CqlDateTime ozzzzc_ = context.Operators.End(ozzzzb_);
                        Period ozzzzd_ = Visit?.Period;
                        CqlInterval<CqlDateTime> ozzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzd_);
                        CqlDateTime ozzzzf_ = context.Operators.Start(ozzzze_);
                        CqlQuantity ozzzzg_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime ozzzzh_ = context.Operators.Subtract(ozzzzf_, ozzzzg_);
                        CqlInterval<CqlDateTime> ozzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzd_);
                        CqlDateTime ozzzzk_ = context.Operators.Start(ozzzzj_);
                        CqlInterval<CqlDateTime> ozzzzl_ = context.Operators.Interval(ozzzzh_, ozzzzk_, true, true);
                        bool? ozzzzm_ = context.Operators.In<CqlDateTime>(ozzzzc_, ozzzzl_, default);
                        CqlInterval<CqlDateTime> ozzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzd_);
                        CqlDateTime ozzzzp_ = context.Operators.Start(ozzzzo_);
                        bool? ozzzzq_ = context.Operators.Not((bool?)(ozzzzp_ is null));
                        bool? ozzzzr_ = context.Operators.And(ozzzzm_, ozzzzq_);
                        bool? ozzzzs_ = context.Operators.And(nzzzzz_, ozzzzr_);

                        return ozzzzs_;
                    };
                    IEnumerable<Encounter> lzzzzj_ = context.Operators.Where<Encounter>(lzzzzh_, lzzzzi_);
                    object lzzzzk_(Encounter @this)
                    {
                        Period ozzzzt_ = @this?.Period;
                        CqlInterval<CqlDateTime> ozzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzt_);
                        CqlDateTime ozzzzv_ = context.Operators.End(ozzzzu_);

                        return ozzzzv_;
                    };
                    IEnumerable<Encounter> lzzzzl_ = context.Operators.SortBy<Encounter>(lzzzzj_, lzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter lzzzzm_ = context.Operators.Last<Encounter>(lzzzzl_);
                    Period lzzzzn_ = lzzzzm_?.Period;
                    CqlInterval<CqlDateTime> lzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzn_);
                    CqlDateTime lzzzzp_ = context.Operators.Start(lzzzzo_);
                    CqlInterval<CqlDateTime> lzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzm_);
                    CqlDateTime lzzzzs_ = context.Operators.Start(lzzzzr_);
                    bool? lzzzzt_ = context.Operators.Not((bool?)((lzzzzp_ ?? lzzzzs_) is null));
                    bool? lzzzzu_ = context.Operators.And(lzzzzf_, lzzzzt_);
                    bool? lzzzzv_ = context.Operators.And(jzzzzy_, lzzzzu_);

                    return lzzzzv_;
                };
                IEnumerable<Encounter> bzzzzw_ = context.Operators.Where<Encounter>(bzzzzu_, bzzzzv_);
                object bzzzzx_(Encounter @this)
                {
                    Period ozzzzw_ = @this?.Period;
                    CqlInterval<CqlDateTime> ozzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzw_);
                    CqlDateTime ozzzzy_ = context.Operators.End(ozzzzx_);

                    return ozzzzy_;
                };
                IEnumerable<Encounter> bzzzzy_ = context.Operators.SortBy<Encounter>(bzzzzw_, bzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bzzzzz_ = context.Operators.Last<Encounter>(bzzzzy_);
                Period czzzza_ = bzzzzz_?.Period;
                CqlInterval<CqlDateTime> czzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzza_);
                CqlDateTime czzzzc_ = context.Operators.Start(czzzzb_);
                IEnumerable<Encounter> czzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? czzzzf_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> ozzzzz_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? pzzzza_ = ozzzzz_?.Value;
                    Code<Encounter.EncounterStatus> pzzzzb_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pzzzza_);
                    bool? pzzzzc_ = context.Operators.Equal(pzzzzb_, "finished");
                    Period pzzzzd_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> pzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzd_);
                    CqlDateTime pzzzzf_ = context.Operators.End(pzzzze_);
                    Period pzzzzg_ = Visit?.Period;
                    CqlInterval<CqlDateTime> pzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzg_);
                    CqlDateTime pzzzzi_ = context.Operators.Start(pzzzzh_);
                    CqlQuantity pzzzzj_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime pzzzzk_ = context.Operators.Subtract(pzzzzi_, pzzzzj_);
                    CqlInterval<CqlDateTime> pzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzg_);
                    CqlDateTime pzzzzn_ = context.Operators.Start(pzzzzm_);
                    CqlInterval<CqlDateTime> pzzzzo_ = context.Operators.Interval(pzzzzk_, pzzzzn_, true, true);
                    bool? pzzzzp_ = context.Operators.In<CqlDateTime>(pzzzzf_, pzzzzo_, default);
                    CqlInterval<CqlDateTime> pzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzg_);
                    CqlDateTime pzzzzs_ = context.Operators.Start(pzzzzr_);
                    bool? pzzzzt_ = context.Operators.Not((bool?)(pzzzzs_ is null));
                    bool? pzzzzu_ = context.Operators.And(pzzzzp_, pzzzzt_);
                    bool? pzzzzv_ = context.Operators.And(pzzzzc_, pzzzzu_);

                    return pzzzzv_;
                };
                IEnumerable<Encounter> czzzzg_ = context.Operators.Where<Encounter>(czzzze_, czzzzf_);
                object czzzzh_(Encounter @this)
                {
                    Period pzzzzw_ = @this?.Period;
                    CqlInterval<CqlDateTime> pzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzw_);
                    CqlDateTime pzzzzy_ = context.Operators.End(pzzzzx_);

                    return pzzzzy_;
                };
                IEnumerable<Encounter> czzzzi_ = context.Operators.SortBy<Encounter>(czzzzg_, czzzzh_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter czzzzj_ = context.Operators.Last<Encounter>(czzzzi_);
                Period czzzzk_ = czzzzj_?.Period;
                CqlInterval<CqlDateTime> czzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzk_);
                CqlDateTime czzzzm_ = context.Operators.Start(czzzzl_);
                CqlInterval<CqlDateTime> czzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzo_);
                CqlDateTime czzzzp_ = context.Operators.Start(czzzzo_);
                CqlInterval<CqlDateTime> czzzzq_ = context.Operators.Interval(bzzzzs_, czzzzc_ ?? czzzzm_ ?? czzzzp_, true, true);
                bool? czzzzr_ = context.Operators.In<CqlDateTime>(azzzzt_, czzzzq_, default);
                IEnumerable<Encounter> czzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? czzzzu_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> pzzzzz_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? qzzzza_ = pzzzzz_?.Value;
                    Code<Encounter.EncounterStatus> qzzzzb_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(qzzzza_);
                    bool? qzzzzc_ = context.Operators.Equal(qzzzzb_, "finished");
                    Period qzzzzd_ = LastED?.Period;
                    CqlInterval<CqlDateTime> qzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzd_);
                    CqlDateTime qzzzzf_ = context.Operators.End(qzzzze_);
                    CqlValueSet qzzzzg_ = this.Observation_Services(context);
                    IEnumerable<Encounter> qzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? qzzzzi_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> szzzza_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? szzzzb_ = szzzza_?.Value;
                        Code<Encounter.EncounterStatus> szzzzc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(szzzzb_);
                        bool? szzzzd_ = context.Operators.Equal(szzzzc_, "finished");
                        Period szzzze_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> szzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzze_);
                        CqlDateTime szzzzg_ = context.Operators.End(szzzzf_);
                        Period szzzzh_ = Visit?.Period;
                        CqlInterval<CqlDateTime> szzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzh_);
                        CqlDateTime szzzzj_ = context.Operators.Start(szzzzi_);
                        CqlQuantity szzzzk_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime szzzzl_ = context.Operators.Subtract(szzzzj_, szzzzk_);
                        CqlInterval<CqlDateTime> szzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzh_);
                        CqlDateTime szzzzo_ = context.Operators.Start(szzzzn_);
                        CqlInterval<CqlDateTime> szzzzp_ = context.Operators.Interval(szzzzl_, szzzzo_, true, true);
                        bool? szzzzq_ = context.Operators.In<CqlDateTime>(szzzzg_, szzzzp_, default);
                        CqlInterval<CqlDateTime> szzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzh_);
                        CqlDateTime szzzzt_ = context.Operators.Start(szzzzs_);
                        bool? szzzzu_ = context.Operators.Not((bool?)(szzzzt_ is null));
                        bool? szzzzv_ = context.Operators.And(szzzzq_, szzzzu_);
                        bool? szzzzw_ = context.Operators.And(szzzzd_, szzzzv_);

                        return szzzzw_;
                    };
                    IEnumerable<Encounter> qzzzzj_ = context.Operators.Where<Encounter>(qzzzzh_, qzzzzi_);
                    object qzzzzk_(Encounter @this)
                    {
                        Period szzzzx_ = @this?.Period;
                        CqlInterval<CqlDateTime> szzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzx_);
                        CqlDateTime szzzzz_ = context.Operators.End(szzzzy_);

                        return szzzzz_;
                    };
                    IEnumerable<Encounter> qzzzzl_ = context.Operators.SortBy<Encounter>(qzzzzj_, qzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter qzzzzm_ = context.Operators.Last<Encounter>(qzzzzl_);
                    Period qzzzzn_ = qzzzzm_?.Period;
                    CqlInterval<CqlDateTime> qzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzn_);
                    CqlDateTime qzzzzp_ = context.Operators.Start(qzzzzo_);
                    Period qzzzzq_ = Visit?.Period;
                    CqlInterval<CqlDateTime> qzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzq_);
                    CqlDateTime qzzzzs_ = context.Operators.Start(qzzzzr_);
                    CqlQuantity qzzzzt_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime qzzzzu_ = context.Operators.Subtract(qzzzzp_ ?? qzzzzs_, qzzzzt_);
                    IEnumerable<Encounter> qzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? qzzzzx_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> tzzzza_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? tzzzzb_ = tzzzza_?.Value;
                        Code<Encounter.EncounterStatus> tzzzzc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(tzzzzb_);
                        bool? tzzzzd_ = context.Operators.Equal(tzzzzc_, "finished");
                        Period tzzzze_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> tzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzze_);
                        CqlDateTime tzzzzg_ = context.Operators.End(tzzzzf_);
                        Period tzzzzh_ = Visit?.Period;
                        CqlInterval<CqlDateTime> tzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzh_);
                        CqlDateTime tzzzzj_ = context.Operators.Start(tzzzzi_);
                        CqlQuantity tzzzzk_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime tzzzzl_ = context.Operators.Subtract(tzzzzj_, tzzzzk_);
                        CqlInterval<CqlDateTime> tzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzh_);
                        CqlDateTime tzzzzo_ = context.Operators.Start(tzzzzn_);
                        CqlInterval<CqlDateTime> tzzzzp_ = context.Operators.Interval(tzzzzl_, tzzzzo_, true, true);
                        bool? tzzzzq_ = context.Operators.In<CqlDateTime>(tzzzzg_, tzzzzp_, default);
                        CqlInterval<CqlDateTime> tzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzh_);
                        CqlDateTime tzzzzt_ = context.Operators.Start(tzzzzs_);
                        bool? tzzzzu_ = context.Operators.Not((bool?)(tzzzzt_ is null));
                        bool? tzzzzv_ = context.Operators.And(tzzzzq_, tzzzzu_);
                        bool? tzzzzw_ = context.Operators.And(tzzzzd_, tzzzzv_);

                        return tzzzzw_;
                    };
                    IEnumerable<Encounter> qzzzzy_ = context.Operators.Where<Encounter>(qzzzzw_, qzzzzx_);
                    object qzzzzz_(Encounter @this)
                    {
                        Period tzzzzx_ = @this?.Period;
                        CqlInterval<CqlDateTime> tzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzx_);
                        CqlDateTime tzzzzz_ = context.Operators.End(tzzzzy_);

                        return tzzzzz_;
                    };
                    IEnumerable<Encounter> rzzzza_ = context.Operators.SortBy<Encounter>(qzzzzy_, qzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter rzzzzb_ = context.Operators.Last<Encounter>(rzzzza_);
                    Period rzzzzc_ = rzzzzb_?.Period;
                    CqlInterval<CqlDateTime> rzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzc_);
                    CqlDateTime rzzzze_ = context.Operators.Start(rzzzzd_);
                    CqlInterval<CqlDateTime> rzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzq_);
                    CqlDateTime rzzzzh_ = context.Operators.Start(rzzzzg_);
                    CqlInterval<CqlDateTime> rzzzzi_ = context.Operators.Interval(qzzzzu_, rzzzze_ ?? rzzzzh_, true, true);
                    bool? rzzzzj_ = context.Operators.In<CqlDateTime>(qzzzzf_, rzzzzi_, default);
                    IEnumerable<Encounter> rzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? rzzzzm_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> uzzzza_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? uzzzzb_ = uzzzza_?.Value;
                        Code<Encounter.EncounterStatus> uzzzzc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(uzzzzb_);
                        bool? uzzzzd_ = context.Operators.Equal(uzzzzc_, "finished");
                        Period uzzzze_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> uzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzze_);
                        CqlDateTime uzzzzg_ = context.Operators.End(uzzzzf_);
                        Period uzzzzh_ = Visit?.Period;
                        CqlInterval<CqlDateTime> uzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzh_);
                        CqlDateTime uzzzzj_ = context.Operators.Start(uzzzzi_);
                        CqlQuantity uzzzzk_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime uzzzzl_ = context.Operators.Subtract(uzzzzj_, uzzzzk_);
                        CqlInterval<CqlDateTime> uzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzh_);
                        CqlDateTime uzzzzo_ = context.Operators.Start(uzzzzn_);
                        CqlInterval<CqlDateTime> uzzzzp_ = context.Operators.Interval(uzzzzl_, uzzzzo_, true, true);
                        bool? uzzzzq_ = context.Operators.In<CqlDateTime>(uzzzzg_, uzzzzp_, default);
                        CqlInterval<CqlDateTime> uzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzh_);
                        CqlDateTime uzzzzt_ = context.Operators.Start(uzzzzs_);
                        bool? uzzzzu_ = context.Operators.Not((bool?)(uzzzzt_ is null));
                        bool? uzzzzv_ = context.Operators.And(uzzzzq_, uzzzzu_);
                        bool? uzzzzw_ = context.Operators.And(uzzzzd_, uzzzzv_);

                        return uzzzzw_;
                    };
                    IEnumerable<Encounter> rzzzzn_ = context.Operators.Where<Encounter>(rzzzzl_, rzzzzm_);
                    object rzzzzo_(Encounter @this)
                    {
                        Period uzzzzx_ = @this?.Period;
                        CqlInterval<CqlDateTime> uzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzx_);
                        CqlDateTime uzzzzz_ = context.Operators.End(uzzzzy_);

                        return uzzzzz_;
                    };
                    IEnumerable<Encounter> rzzzzp_ = context.Operators.SortBy<Encounter>(rzzzzn_, rzzzzo_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter rzzzzq_ = context.Operators.Last<Encounter>(rzzzzp_);
                    Period rzzzzr_ = rzzzzq_?.Period;
                    CqlInterval<CqlDateTime> rzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzr_);
                    CqlDateTime rzzzzt_ = context.Operators.Start(rzzzzs_);
                    CqlInterval<CqlDateTime> rzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzq_);
                    CqlDateTime rzzzzw_ = context.Operators.Start(rzzzzv_);
                    bool? rzzzzx_ = context.Operators.Not((bool?)((rzzzzt_ ?? rzzzzw_) is null));
                    bool? rzzzzy_ = context.Operators.And(rzzzzj_, rzzzzx_);
                    bool? rzzzzz_ = context.Operators.And(qzzzzc_, rzzzzy_);

                    return rzzzzz_;
                };
                IEnumerable<Encounter> czzzzv_ = context.Operators.Where<Encounter>(czzzzt_, czzzzu_);
                object czzzzw_(Encounter @this)
                {
                    Period vzzzza_ = @this?.Period;
                    CqlInterval<CqlDateTime> vzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzza_);
                    CqlDateTime vzzzzc_ = context.Operators.End(vzzzzb_);

                    return vzzzzc_;
                };
                IEnumerable<Encounter> czzzzx_ = context.Operators.SortBy<Encounter>(czzzzv_, czzzzw_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter czzzzy_ = context.Operators.Last<Encounter>(czzzzx_);
                Period czzzzz_ = czzzzy_?.Period;
                CqlInterval<CqlDateTime> dzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzz_);
                CqlDateTime dzzzzb_ = context.Operators.Start(dzzzza_);
                IEnumerable<Encounter> dzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? dzzzze_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> vzzzzd_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? vzzzze_ = vzzzzd_?.Value;
                    Code<Encounter.EncounterStatus> vzzzzf_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(vzzzze_);
                    bool? vzzzzg_ = context.Operators.Equal(vzzzzf_, "finished");
                    Period vzzzzh_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> vzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzh_);
                    CqlDateTime vzzzzj_ = context.Operators.End(vzzzzi_);
                    Period vzzzzk_ = Visit?.Period;
                    CqlInterval<CqlDateTime> vzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzk_);
                    CqlDateTime vzzzzm_ = context.Operators.Start(vzzzzl_);
                    CqlQuantity vzzzzn_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime vzzzzo_ = context.Operators.Subtract(vzzzzm_, vzzzzn_);
                    CqlInterval<CqlDateTime> vzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzk_);
                    CqlDateTime vzzzzr_ = context.Operators.Start(vzzzzq_);
                    CqlInterval<CqlDateTime> vzzzzs_ = context.Operators.Interval(vzzzzo_, vzzzzr_, true, true);
                    bool? vzzzzt_ = context.Operators.In<CqlDateTime>(vzzzzj_, vzzzzs_, default);
                    CqlInterval<CqlDateTime> vzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzk_);
                    CqlDateTime vzzzzw_ = context.Operators.Start(vzzzzv_);
                    bool? vzzzzx_ = context.Operators.Not((bool?)(vzzzzw_ is null));
                    bool? vzzzzy_ = context.Operators.And(vzzzzt_, vzzzzx_);
                    bool? vzzzzz_ = context.Operators.And(vzzzzg_, vzzzzy_);

                    return vzzzzz_;
                };
                IEnumerable<Encounter> dzzzzf_ = context.Operators.Where<Encounter>(dzzzzd_, dzzzze_);
                object dzzzzg_(Encounter @this)
                {
                    Period wzzzza_ = @this?.Period;
                    CqlInterval<CqlDateTime> wzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzza_);
                    CqlDateTime wzzzzc_ = context.Operators.End(wzzzzb_);

                    return wzzzzc_;
                };
                IEnumerable<Encounter> dzzzzh_ = context.Operators.SortBy<Encounter>(dzzzzf_, dzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter dzzzzi_ = context.Operators.Last<Encounter>(dzzzzh_);
                Period dzzzzj_ = dzzzzi_?.Period;
                CqlInterval<CqlDateTime> dzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzj_);
                CqlDateTime dzzzzl_ = context.Operators.Start(dzzzzk_);
                CqlInterval<CqlDateTime> dzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzo_);
                CqlDateTime dzzzzo_ = context.Operators.Start(dzzzzn_);
                bool? dzzzzp_ = context.Operators.Not((bool?)((dzzzzb_ ?? dzzzzl_ ?? dzzzzo_) is null));
                bool? dzzzzq_ = context.Operators.And(czzzzr_, dzzzzp_);

                return dzzzzq_;
            };
            IEnumerable<Encounter> zzzzj_ = context.Operators.Where<Encounter>(zzzzh_, zzzzi_);
            object zzzzk_(Encounter @this)
            {
                Period wzzzzd_ = @this?.Period;
                CqlInterval<CqlDateTime> wzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzd_);
                CqlDateTime wzzzzf_ = context.Operators.End(wzzzze_);

                return wzzzzf_;
            };
            IEnumerable<Encounter> zzzzl_ = context.Operators.SortBy<Encounter>(zzzzj_, zzzzk_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter zzzzm_ = context.Operators.Last<Encounter>(zzzzl_);
            Period zzzzn_ = zzzzm_?.Period;
            CqlInterval<CqlDateTime> zzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzn_);
            CqlDateTime zzzzp_ = context.Operators.Start(zzzzo_);
            CqlValueSet zzzzq_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> zzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? zzzzs_(Encounter LastED)
            {
                Code<Encounter.EncounterStatus> wzzzzg_ = LastED?.StatusElement;
                Encounter.EncounterStatus? wzzzzh_ = wzzzzg_?.Value;
                Code<Encounter.EncounterStatus> wzzzzi_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(wzzzzh_);
                bool? wzzzzj_ = context.Operators.Equal(wzzzzi_, "finished");
                Period wzzzzk_ = LastED?.Period;
                CqlInterval<CqlDateTime> wzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzk_);
                CqlDateTime wzzzzm_ = context.Operators.End(wzzzzl_);
                CqlValueSet wzzzzn_ = this.Observation_Services(context);
                IEnumerable<Encounter> wzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? wzzzzp_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> yzzzzh_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? yzzzzi_ = yzzzzh_?.Value;
                    Code<Encounter.EncounterStatus> yzzzzj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(yzzzzi_);
                    bool? yzzzzk_ = context.Operators.Equal(yzzzzj_, "finished");
                    Period yzzzzl_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> yzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzl_);
                    CqlDateTime yzzzzn_ = context.Operators.End(yzzzzm_);
                    Period yzzzzo_ = Visit?.Period;
                    CqlInterval<CqlDateTime> yzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzo_);
                    CqlDateTime yzzzzq_ = context.Operators.Start(yzzzzp_);
                    CqlQuantity yzzzzr_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime yzzzzs_ = context.Operators.Subtract(yzzzzq_, yzzzzr_);
                    CqlInterval<CqlDateTime> yzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzo_);
                    CqlDateTime yzzzzv_ = context.Operators.Start(yzzzzu_);
                    CqlInterval<CqlDateTime> yzzzzw_ = context.Operators.Interval(yzzzzs_, yzzzzv_, true, true);
                    bool? yzzzzx_ = context.Operators.In<CqlDateTime>(yzzzzn_, yzzzzw_, default);
                    CqlInterval<CqlDateTime> yzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzo_);
                    CqlDateTime zzzzza_ = context.Operators.Start(yzzzzz_);
                    bool? zzzzzb_ = context.Operators.Not((bool?)(zzzzza_ is null));
                    bool? zzzzzc_ = context.Operators.And(yzzzzx_, zzzzzb_);
                    bool? zzzzzd_ = context.Operators.And(yzzzzk_, zzzzzc_);

                    return zzzzzd_;
                };
                IEnumerable<Encounter> wzzzzq_ = context.Operators.Where<Encounter>(wzzzzo_, wzzzzp_);
                object wzzzzr_(Encounter @this)
                {
                    Period zzzzze_ = @this?.Period;
                    CqlInterval<CqlDateTime> zzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzze_);
                    CqlDateTime zzzzzg_ = context.Operators.End(zzzzzf_);

                    return zzzzzg_;
                };
                IEnumerable<Encounter> wzzzzs_ = context.Operators.SortBy<Encounter>(wzzzzq_, wzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter wzzzzt_ = context.Operators.Last<Encounter>(wzzzzs_);
                Period wzzzzu_ = wzzzzt_?.Period;
                CqlInterval<CqlDateTime> wzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzu_);
                CqlDateTime wzzzzw_ = context.Operators.Start(wzzzzv_);
                Period wzzzzx_ = Visit?.Period;
                CqlInterval<CqlDateTime> wzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzx_);
                CqlDateTime wzzzzz_ = context.Operators.Start(wzzzzy_);
                CqlQuantity xzzzza_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime xzzzzb_ = context.Operators.Subtract(wzzzzw_ ?? wzzzzz_, xzzzza_);
                IEnumerable<Encounter> xzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? xzzzze_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> zzzzzh_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? zzzzzi_ = zzzzzh_?.Value;
                    Code<Encounter.EncounterStatus> zzzzzj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(zzzzzi_);
                    bool? zzzzzk_ = context.Operators.Equal(zzzzzj_, "finished");
                    Period zzzzzl_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> zzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzl_);
                    CqlDateTime zzzzzn_ = context.Operators.End(zzzzzm_);
                    Period zzzzzo_ = Visit?.Period;
                    CqlInterval<CqlDateTime> zzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzo_);
                    CqlDateTime zzzzzq_ = context.Operators.Start(zzzzzp_);
                    CqlQuantity zzzzzr_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime zzzzzs_ = context.Operators.Subtract(zzzzzq_, zzzzzr_);
                    CqlInterval<CqlDateTime> zzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzo_);
                    CqlDateTime zzzzzv_ = context.Operators.Start(zzzzzu_);
                    CqlInterval<CqlDateTime> zzzzzw_ = context.Operators.Interval(zzzzzs_, zzzzzv_, true, true);
                    bool? zzzzzx_ = context.Operators.In<CqlDateTime>(zzzzzn_, zzzzzw_, default);
                    CqlInterval<CqlDateTime> zzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzo_);
                    CqlDateTime azzzzza_ = context.Operators.Start(zzzzzz_);
                    bool? azzzzzb_ = context.Operators.Not((bool?)(azzzzza_ is null));
                    bool? azzzzzc_ = context.Operators.And(zzzzzx_, azzzzzb_);
                    bool? azzzzzd_ = context.Operators.And(zzzzzk_, azzzzzc_);

                    return azzzzzd_;
                };
                IEnumerable<Encounter> xzzzzf_ = context.Operators.Where<Encounter>(xzzzzd_, xzzzze_);
                object xzzzzg_(Encounter @this)
                {
                    Period azzzzze_ = @this?.Period;
                    CqlInterval<CqlDateTime> azzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzze_);
                    CqlDateTime azzzzzg_ = context.Operators.End(azzzzzf_);

                    return azzzzzg_;
                };
                IEnumerable<Encounter> xzzzzh_ = context.Operators.SortBy<Encounter>(xzzzzf_, xzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter xzzzzi_ = context.Operators.Last<Encounter>(xzzzzh_);
                Period xzzzzj_ = xzzzzi_?.Period;
                CqlInterval<CqlDateTime> xzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzj_);
                CqlDateTime xzzzzl_ = context.Operators.Start(xzzzzk_);
                CqlInterval<CqlDateTime> xzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzx_);
                CqlDateTime xzzzzo_ = context.Operators.Start(xzzzzn_);
                CqlInterval<CqlDateTime> xzzzzp_ = context.Operators.Interval(xzzzzb_, xzzzzl_ ?? xzzzzo_, true, true);
                bool? xzzzzq_ = context.Operators.In<CqlDateTime>(wzzzzm_, xzzzzp_, default);
                IEnumerable<Encounter> xzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? xzzzzt_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> azzzzzh_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? azzzzzi_ = azzzzzh_?.Value;
                    Code<Encounter.EncounterStatus> azzzzzj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(azzzzzi_);
                    bool? azzzzzk_ = context.Operators.Equal(azzzzzj_, "finished");
                    Period azzzzzl_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> azzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzl_);
                    CqlDateTime azzzzzn_ = context.Operators.End(azzzzzm_);
                    Period azzzzzo_ = Visit?.Period;
                    CqlInterval<CqlDateTime> azzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzo_);
                    CqlDateTime azzzzzq_ = context.Operators.Start(azzzzzp_);
                    CqlQuantity azzzzzr_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime azzzzzs_ = context.Operators.Subtract(azzzzzq_, azzzzzr_);
                    CqlInterval<CqlDateTime> azzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzo_);
                    CqlDateTime azzzzzv_ = context.Operators.Start(azzzzzu_);
                    CqlInterval<CqlDateTime> azzzzzw_ = context.Operators.Interval(azzzzzs_, azzzzzv_, true, true);
                    bool? azzzzzx_ = context.Operators.In<CqlDateTime>(azzzzzn_, azzzzzw_, default);
                    CqlInterval<CqlDateTime> azzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzo_);
                    CqlDateTime bzzzzza_ = context.Operators.Start(azzzzzz_);
                    bool? bzzzzzb_ = context.Operators.Not((bool?)(bzzzzza_ is null));
                    bool? bzzzzzc_ = context.Operators.And(azzzzzx_, bzzzzzb_);
                    bool? bzzzzzd_ = context.Operators.And(azzzzzk_, bzzzzzc_);

                    return bzzzzzd_;
                };
                IEnumerable<Encounter> xzzzzu_ = context.Operators.Where<Encounter>(xzzzzs_, xzzzzt_);
                object xzzzzv_(Encounter @this)
                {
                    Period bzzzzze_ = @this?.Period;
                    CqlInterval<CqlDateTime> bzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzze_);
                    CqlDateTime bzzzzzg_ = context.Operators.End(bzzzzzf_);

                    return bzzzzzg_;
                };
                IEnumerable<Encounter> xzzzzw_ = context.Operators.SortBy<Encounter>(xzzzzu_, xzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter xzzzzx_ = context.Operators.Last<Encounter>(xzzzzw_);
                Period xzzzzy_ = xzzzzx_?.Period;
                CqlInterval<CqlDateTime> xzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzy_);
                CqlDateTime yzzzza_ = context.Operators.Start(xzzzzz_);
                CqlInterval<CqlDateTime> yzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzx_);
                CqlDateTime yzzzzd_ = context.Operators.Start(yzzzzc_);
                bool? yzzzze_ = context.Operators.Not((bool?)((yzzzza_ ?? yzzzzd_) is null));
                bool? yzzzzf_ = context.Operators.And(xzzzzq_, yzzzze_);
                bool? yzzzzg_ = context.Operators.And(wzzzzj_, yzzzzf_);

                return yzzzzg_;
            };
            IEnumerable<Encounter> zzzzt_ = context.Operators.Where<Encounter>(zzzzr_, zzzzs_);
            object zzzzu_(Encounter @this)
            {
                Period bzzzzzh_ = @this?.Period;
                CqlInterval<CqlDateTime> bzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzh_);
                CqlDateTime bzzzzzj_ = context.Operators.End(bzzzzzi_);

                return bzzzzzj_;
            };
            IEnumerable<Encounter> zzzzv_ = context.Operators.SortBy<Encounter>(zzzzt_, zzzzu_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter zzzzw_ = context.Operators.Last<Encounter>(zzzzv_);
            Period zzzzx_ = zzzzw_?.Period;
            CqlInterval<CqlDateTime> zzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzx_);
            CqlDateTime zzzzz_ = context.Operators.Start(zzzzy_);
            CqlValueSet azzzza_ = this.Observation_Services(context);
            IEnumerable<Encounter> azzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? azzzzc_(Encounter LastObs)
            {
                Code<Encounter.EncounterStatus> bzzzzzk_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? bzzzzzl_ = bzzzzzk_?.Value;
                Code<Encounter.EncounterStatus> bzzzzzm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bzzzzzl_);
                bool? bzzzzzn_ = context.Operators.Equal(bzzzzzm_, "finished");
                Period bzzzzzo_ = LastObs?.Period;
                CqlInterval<CqlDateTime> bzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzo_);
                CqlDateTime bzzzzzq_ = context.Operators.End(bzzzzzp_);
                Period bzzzzzr_ = Visit?.Period;
                CqlInterval<CqlDateTime> bzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzr_);
                CqlDateTime bzzzzzt_ = context.Operators.Start(bzzzzzs_);
                CqlQuantity bzzzzzu_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime bzzzzzv_ = context.Operators.Subtract(bzzzzzt_, bzzzzzu_);
                CqlInterval<CqlDateTime> bzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzr_);
                CqlDateTime bzzzzzy_ = context.Operators.Start(bzzzzzx_);
                CqlInterval<CqlDateTime> bzzzzzz_ = context.Operators.Interval(bzzzzzv_, bzzzzzy_, true, true);
                bool? czzzzza_ = context.Operators.In<CqlDateTime>(bzzzzzq_, bzzzzzz_, default);
                CqlInterval<CqlDateTime> czzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzr_);
                CqlDateTime czzzzzd_ = context.Operators.Start(czzzzzc_);
                bool? czzzzze_ = context.Operators.Not((bool?)(czzzzzd_ is null));
                bool? czzzzzf_ = context.Operators.And(czzzzza_, czzzzze_);
                bool? czzzzzg_ = context.Operators.And(bzzzzzn_, czzzzzf_);

                return czzzzzg_;
            };
            IEnumerable<Encounter> azzzzd_ = context.Operators.Where<Encounter>(azzzzb_, azzzzc_);
            object azzzze_(Encounter @this)
            {
                Period czzzzzh_ = @this?.Period;
                CqlInterval<CqlDateTime> czzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzh_);
                CqlDateTime czzzzzj_ = context.Operators.End(czzzzzi_);

                return czzzzzj_;
            };
            IEnumerable<Encounter> azzzzf_ = context.Operators.SortBy<Encounter>(azzzzd_, azzzze_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter azzzzg_ = context.Operators.Last<Encounter>(azzzzf_);
            Period azzzzh_ = azzzzg_?.Period;
            CqlInterval<CqlDateTime> azzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzh_);
            CqlDateTime azzzzj_ = context.Operators.Start(azzzzi_);
            Period azzzzk_ = Visit?.Period;
            CqlInterval<CqlDateTime> azzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzk_);
            CqlDateTime azzzzm_ = context.Operators.Start(azzzzl_);
            CqlInterval<CqlDateTime> azzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzk_);
            CqlDateTime azzzzp_ = context.Operators.End(azzzzo_);
            CqlInterval<CqlDateTime> azzzzq_ = context.Operators.Interval(zzzzp_ ?? zzzzz_ ?? azzzzj_ ?? azzzzm_, azzzzp_, true, true);

            return azzzzq_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> zzzzd_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)zzzzb_, zzzzc_);
        IEnumerable<CqlInterval<CqlDateTime>> zzzze_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(zzzzd_);
        CqlInterval<CqlDateTime> zzzzf_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(zzzze_);

        return zzzzf_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Hospitalization with Observation returns the total interval from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationWithObservation()` instead.")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] czzzzzk_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> czzzzzl_(Encounter Visit)
        {
            CqlValueSet czzzzzp_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> czzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? czzzzzr_(Encounter LastED)
            {
                Code<Encounter.EncounterStatus> dzzzzzq_ = LastED?.StatusElement;
                Encounter.EncounterStatus? dzzzzzr_ = dzzzzzq_?.Value;
                Code<Encounter.EncounterStatus> dzzzzzs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dzzzzzr_);
                bool? dzzzzzt_ = context.Operators.Equal(dzzzzzs_, "finished");
                Period dzzzzzu_ = LastED?.Period;
                CqlInterval<CqlDateTime> dzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzu_);
                CqlDateTime dzzzzzw_ = context.Operators.End(dzzzzzv_);
                CqlValueSet dzzzzzx_ = this.Observation_Services(context);
                IEnumerable<Encounter> dzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? dzzzzzz_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> fzzzzzr_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? fzzzzzs_ = fzzzzzr_?.Value;
                    Code<Encounter.EncounterStatus> fzzzzzt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fzzzzzs_);
                    bool? fzzzzzu_ = context.Operators.Equal(fzzzzzt_, "finished");
                    Period fzzzzzv_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> fzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzv_);
                    CqlDateTime fzzzzzx_ = context.Operators.End(fzzzzzw_);
                    Period fzzzzzy_ = Visit?.Period;
                    CqlInterval<CqlDateTime> fzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzy_);
                    CqlDateTime gzzzzza_ = context.Operators.Start(fzzzzzz_);
                    CqlQuantity gzzzzzb_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime gzzzzzc_ = context.Operators.Subtract(gzzzzza_, gzzzzzb_);
                    CqlInterval<CqlDateTime> gzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzy_);
                    CqlDateTime gzzzzzf_ = context.Operators.Start(gzzzzze_);
                    CqlInterval<CqlDateTime> gzzzzzg_ = context.Operators.Interval(gzzzzzc_, gzzzzzf_, true, true);
                    bool? gzzzzzh_ = context.Operators.In<CqlDateTime>(fzzzzzx_, gzzzzzg_, default);
                    CqlInterval<CqlDateTime> gzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzy_);
                    CqlDateTime gzzzzzk_ = context.Operators.Start(gzzzzzj_);
                    bool? gzzzzzl_ = context.Operators.Not((bool?)(gzzzzzk_ is null));
                    bool? gzzzzzm_ = context.Operators.And(gzzzzzh_, gzzzzzl_);
                    bool? gzzzzzn_ = context.Operators.And(fzzzzzu_, gzzzzzm_);

                    return gzzzzzn_;
                };
                IEnumerable<Encounter> ezzzzza_ = context.Operators.Where<Encounter>(dzzzzzy_, dzzzzzz_);
                object ezzzzzb_(Encounter @this)
                {
                    Period gzzzzzo_ = @this?.Period;
                    CqlInterval<CqlDateTime> gzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzo_);
                    CqlDateTime gzzzzzq_ = context.Operators.End(gzzzzzp_);

                    return gzzzzzq_;
                };
                IEnumerable<Encounter> ezzzzzc_ = context.Operators.SortBy<Encounter>(ezzzzza_, ezzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter ezzzzzd_ = context.Operators.Last<Encounter>(ezzzzzc_);
                Period ezzzzze_ = ezzzzzd_?.Period;
                CqlInterval<CqlDateTime> ezzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzze_);
                CqlDateTime ezzzzzg_ = context.Operators.Start(ezzzzzf_);
                Period ezzzzzh_ = Visit?.Period;
                CqlInterval<CqlDateTime> ezzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzh_);
                CqlDateTime ezzzzzj_ = context.Operators.Start(ezzzzzi_);
                CqlQuantity ezzzzzk_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime ezzzzzl_ = context.Operators.Subtract(ezzzzzg_ ?? ezzzzzj_, ezzzzzk_);
                IEnumerable<Encounter> ezzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? ezzzzzo_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> gzzzzzr_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? gzzzzzs_ = gzzzzzr_?.Value;
                    Code<Encounter.EncounterStatus> gzzzzzt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gzzzzzs_);
                    bool? gzzzzzu_ = context.Operators.Equal(gzzzzzt_, "finished");
                    Period gzzzzzv_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> gzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzv_);
                    CqlDateTime gzzzzzx_ = context.Operators.End(gzzzzzw_);
                    Period gzzzzzy_ = Visit?.Period;
                    CqlInterval<CqlDateTime> gzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzy_);
                    CqlDateTime hzzzzza_ = context.Operators.Start(gzzzzzz_);
                    CqlQuantity hzzzzzb_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime hzzzzzc_ = context.Operators.Subtract(hzzzzza_, hzzzzzb_);
                    CqlInterval<CqlDateTime> hzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzy_);
                    CqlDateTime hzzzzzf_ = context.Operators.Start(hzzzzze_);
                    CqlInterval<CqlDateTime> hzzzzzg_ = context.Operators.Interval(hzzzzzc_, hzzzzzf_, true, true);
                    bool? hzzzzzh_ = context.Operators.In<CqlDateTime>(gzzzzzx_, hzzzzzg_, default);
                    CqlInterval<CqlDateTime> hzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzy_);
                    CqlDateTime hzzzzzk_ = context.Operators.Start(hzzzzzj_);
                    bool? hzzzzzl_ = context.Operators.Not((bool?)(hzzzzzk_ is null));
                    bool? hzzzzzm_ = context.Operators.And(hzzzzzh_, hzzzzzl_);
                    bool? hzzzzzn_ = context.Operators.And(gzzzzzu_, hzzzzzm_);

                    return hzzzzzn_;
                };
                IEnumerable<Encounter> ezzzzzp_ = context.Operators.Where<Encounter>(ezzzzzn_, ezzzzzo_);
                object ezzzzzq_(Encounter @this)
                {
                    Period hzzzzzo_ = @this?.Period;
                    CqlInterval<CqlDateTime> hzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzo_);
                    CqlDateTime hzzzzzq_ = context.Operators.End(hzzzzzp_);

                    return hzzzzzq_;
                };
                IEnumerable<Encounter> ezzzzzr_ = context.Operators.SortBy<Encounter>(ezzzzzp_, ezzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter ezzzzzs_ = context.Operators.Last<Encounter>(ezzzzzr_);
                Period ezzzzzt_ = ezzzzzs_?.Period;
                CqlInterval<CqlDateTime> ezzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzt_);
                CqlDateTime ezzzzzv_ = context.Operators.Start(ezzzzzu_);
                CqlInterval<CqlDateTime> ezzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzh_);
                CqlDateTime ezzzzzy_ = context.Operators.Start(ezzzzzx_);
                CqlInterval<CqlDateTime> ezzzzzz_ = context.Operators.Interval(ezzzzzl_, ezzzzzv_ ?? ezzzzzy_, true, true);
                bool? fzzzzza_ = context.Operators.In<CqlDateTime>(dzzzzzw_, ezzzzzz_, default);
                IEnumerable<Encounter> fzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? fzzzzzd_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> hzzzzzr_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? hzzzzzs_ = hzzzzzr_?.Value;
                    Code<Encounter.EncounterStatus> hzzzzzt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hzzzzzs_);
                    bool? hzzzzzu_ = context.Operators.Equal(hzzzzzt_, "finished");
                    Period hzzzzzv_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> hzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzv_);
                    CqlDateTime hzzzzzx_ = context.Operators.End(hzzzzzw_);
                    Period hzzzzzy_ = Visit?.Period;
                    CqlInterval<CqlDateTime> hzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzy_);
                    CqlDateTime izzzzza_ = context.Operators.Start(hzzzzzz_);
                    CqlQuantity izzzzzb_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime izzzzzc_ = context.Operators.Subtract(izzzzza_, izzzzzb_);
                    CqlInterval<CqlDateTime> izzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzy_);
                    CqlDateTime izzzzzf_ = context.Operators.Start(izzzzze_);
                    CqlInterval<CqlDateTime> izzzzzg_ = context.Operators.Interval(izzzzzc_, izzzzzf_, true, true);
                    bool? izzzzzh_ = context.Operators.In<CqlDateTime>(hzzzzzx_, izzzzzg_, default);
                    CqlInterval<CqlDateTime> izzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzy_);
                    CqlDateTime izzzzzk_ = context.Operators.Start(izzzzzj_);
                    bool? izzzzzl_ = context.Operators.Not((bool?)(izzzzzk_ is null));
                    bool? izzzzzm_ = context.Operators.And(izzzzzh_, izzzzzl_);
                    bool? izzzzzn_ = context.Operators.And(hzzzzzu_, izzzzzm_);

                    return izzzzzn_;
                };
                IEnumerable<Encounter> fzzzzze_ = context.Operators.Where<Encounter>(fzzzzzc_, fzzzzzd_);
                object fzzzzzf_(Encounter @this)
                {
                    Period izzzzzo_ = @this?.Period;
                    CqlInterval<CqlDateTime> izzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzo_);
                    CqlDateTime izzzzzq_ = context.Operators.End(izzzzzp_);

                    return izzzzzq_;
                };
                IEnumerable<Encounter> fzzzzzg_ = context.Operators.SortBy<Encounter>(fzzzzze_, fzzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter fzzzzzh_ = context.Operators.Last<Encounter>(fzzzzzg_);
                Period fzzzzzi_ = fzzzzzh_?.Period;
                CqlInterval<CqlDateTime> fzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzi_);
                CqlDateTime fzzzzzk_ = context.Operators.Start(fzzzzzj_);
                CqlInterval<CqlDateTime> fzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzh_);
                CqlDateTime fzzzzzn_ = context.Operators.Start(fzzzzzm_);
                bool? fzzzzzo_ = context.Operators.Not((bool?)((fzzzzzk_ ?? fzzzzzn_) is null));
                bool? fzzzzzp_ = context.Operators.And(fzzzzza_, fzzzzzo_);
                bool? fzzzzzq_ = context.Operators.And(dzzzzzt_, fzzzzzp_);

                return fzzzzzq_;
            };
            IEnumerable<Encounter> czzzzzs_ = context.Operators.Where<Encounter>(czzzzzq_, czzzzzr_);
            object czzzzzt_(Encounter @this)
            {
                Period izzzzzr_ = @this?.Period;
                CqlInterval<CqlDateTime> izzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzr_);
                CqlDateTime izzzzzt_ = context.Operators.End(izzzzzs_);

                return izzzzzt_;
            };
            IEnumerable<Encounter> czzzzzu_ = context.Operators.SortBy<Encounter>(czzzzzs_, czzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter czzzzzv_ = context.Operators.Last<Encounter>(czzzzzu_);
            Period czzzzzw_ = czzzzzv_?.Period;
            CqlInterval<CqlDateTime> czzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzw_);
            CqlDateTime czzzzzy_ = context.Operators.Start(czzzzzx_);
            CqlValueSet czzzzzz_ = this.Observation_Services(context);
            IEnumerable<Encounter> dzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? dzzzzzb_(Encounter LastObs)
            {
                Code<Encounter.EncounterStatus> izzzzzu_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? izzzzzv_ = izzzzzu_?.Value;
                Code<Encounter.EncounterStatus> izzzzzw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(izzzzzv_);
                bool? izzzzzx_ = context.Operators.Equal(izzzzzw_, "finished");
                Period izzzzzy_ = LastObs?.Period;
                CqlInterval<CqlDateTime> izzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzy_);
                CqlDateTime jzzzzza_ = context.Operators.End(izzzzzz_);
                Period jzzzzzb_ = Visit?.Period;
                CqlInterval<CqlDateTime> jzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzb_);
                CqlDateTime jzzzzzd_ = context.Operators.Start(jzzzzzc_);
                CqlQuantity jzzzzze_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime jzzzzzf_ = context.Operators.Subtract(jzzzzzd_, jzzzzze_);
                CqlInterval<CqlDateTime> jzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzb_);
                CqlDateTime jzzzzzi_ = context.Operators.Start(jzzzzzh_);
                CqlInterval<CqlDateTime> jzzzzzj_ = context.Operators.Interval(jzzzzzf_, jzzzzzi_, true, true);
                bool? jzzzzzk_ = context.Operators.In<CqlDateTime>(jzzzzza_, jzzzzzj_, default);
                CqlInterval<CqlDateTime> jzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzb_);
                CqlDateTime jzzzzzn_ = context.Operators.Start(jzzzzzm_);
                bool? jzzzzzo_ = context.Operators.Not((bool?)(jzzzzzn_ is null));
                bool? jzzzzzp_ = context.Operators.And(jzzzzzk_, jzzzzzo_);
                bool? jzzzzzq_ = context.Operators.And(izzzzzx_, jzzzzzp_);

                return jzzzzzq_;
            };
            IEnumerable<Encounter> dzzzzzc_ = context.Operators.Where<Encounter>(dzzzzza_, dzzzzzb_);
            object dzzzzzd_(Encounter @this)
            {
                Period jzzzzzr_ = @this?.Period;
                CqlInterval<CqlDateTime> jzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzr_);
                CqlDateTime jzzzzzt_ = context.Operators.End(jzzzzzs_);

                return jzzzzzt_;
            };
            IEnumerable<Encounter> dzzzzze_ = context.Operators.SortBy<Encounter>(dzzzzzc_, dzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter dzzzzzf_ = context.Operators.Last<Encounter>(dzzzzze_);
            Period dzzzzzg_ = dzzzzzf_?.Period;
            CqlInterval<CqlDateTime> dzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzg_);
            CqlDateTime dzzzzzi_ = context.Operators.Start(dzzzzzh_);
            Period dzzzzzj_ = Visit?.Period;
            CqlInterval<CqlDateTime> dzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzj_);
            CqlDateTime dzzzzzl_ = context.Operators.Start(dzzzzzk_);
            CqlInterval<CqlDateTime> dzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzj_);
            CqlDateTime dzzzzzo_ = context.Operators.End(dzzzzzn_);
            CqlInterval<CqlDateTime> dzzzzzp_ = context.Operators.Interval(czzzzzy_ ?? dzzzzzi_ ?? dzzzzzl_, dzzzzzo_, true, true);

            return dzzzzzp_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> czzzzzm_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)czzzzzk_, czzzzzl_);
        IEnumerable<CqlInterval<CqlDateTime>> czzzzzn_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(czzzzzm_);
        CqlInterval<CqlDateTime> czzzzzo_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(czzzzzn_);

        return czzzzzo_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Hospitalization with Observation returns the total interval from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    public CqlInterval<CqlDateTime> hospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] jzzzzzu_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> jzzzzzv_(Encounter Visit)
        {
            CqlValueSet jzzzzzz_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> kzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? kzzzzzb_(Encounter LastED)
            {
                Code<Encounter.EncounterStatus> lzzzzza_ = LastED?.StatusElement;
                Encounter.EncounterStatus? lzzzzzb_ = lzzzzza_?.Value;
                Code<Encounter.EncounterStatus> lzzzzzc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lzzzzzb_);
                bool? lzzzzzd_ = context.Operators.Equal(lzzzzzc_, "finished");
                Period lzzzzze_ = LastED?.Period;
                CqlInterval<CqlDateTime> lzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzze_);
                CqlDateTime lzzzzzg_ = context.Operators.End(lzzzzzf_);
                CqlValueSet lzzzzzh_ = this.Observation_Services(context);
                IEnumerable<Encounter> lzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? lzzzzzj_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> nzzzzzb_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? nzzzzzc_ = nzzzzzb_?.Value;
                    Code<Encounter.EncounterStatus> nzzzzzd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(nzzzzzc_);
                    bool? nzzzzze_ = context.Operators.Equal(nzzzzzd_, "finished");
                    Period nzzzzzf_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> nzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzf_);
                    CqlDateTime nzzzzzh_ = context.Operators.End(nzzzzzg_);
                    Period nzzzzzi_ = Visit?.Period;
                    CqlInterval<CqlDateTime> nzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzi_);
                    CqlDateTime nzzzzzk_ = context.Operators.Start(nzzzzzj_);
                    CqlQuantity nzzzzzl_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime nzzzzzm_ = context.Operators.Subtract(nzzzzzk_, nzzzzzl_);
                    CqlInterval<CqlDateTime> nzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzi_);
                    CqlDateTime nzzzzzp_ = context.Operators.Start(nzzzzzo_);
                    CqlInterval<CqlDateTime> nzzzzzq_ = context.Operators.Interval(nzzzzzm_, nzzzzzp_, true, true);
                    bool? nzzzzzr_ = context.Operators.In<CqlDateTime>(nzzzzzh_, nzzzzzq_, default);
                    CqlInterval<CqlDateTime> nzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzi_);
                    CqlDateTime nzzzzzu_ = context.Operators.Start(nzzzzzt_);
                    bool? nzzzzzv_ = context.Operators.Not((bool?)(nzzzzzu_ is null));
                    bool? nzzzzzw_ = context.Operators.And(nzzzzzr_, nzzzzzv_);
                    bool? nzzzzzx_ = context.Operators.And(nzzzzze_, nzzzzzw_);

                    return nzzzzzx_;
                };
                IEnumerable<Encounter> lzzzzzk_ = context.Operators.Where<Encounter>(lzzzzzi_, lzzzzzj_);
                object lzzzzzl_(Encounter @this)
                {
                    Period nzzzzzy_ = @this?.Period;
                    CqlInterval<CqlDateTime> nzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzy_);
                    CqlDateTime ozzzzza_ = context.Operators.End(nzzzzzz_);

                    return ozzzzza_;
                };
                IEnumerable<Encounter> lzzzzzm_ = context.Operators.SortBy<Encounter>(lzzzzzk_, lzzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter lzzzzzn_ = context.Operators.Last<Encounter>(lzzzzzm_);
                Period lzzzzzo_ = lzzzzzn_?.Period;
                CqlInterval<CqlDateTime> lzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzo_);
                CqlDateTime lzzzzzq_ = context.Operators.Start(lzzzzzp_);
                Period lzzzzzr_ = Visit?.Period;
                CqlInterval<CqlDateTime> lzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzr_);
                CqlDateTime lzzzzzt_ = context.Operators.Start(lzzzzzs_);
                CqlQuantity lzzzzzu_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime lzzzzzv_ = context.Operators.Subtract(lzzzzzq_ ?? lzzzzzt_, lzzzzzu_);
                IEnumerable<Encounter> lzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? lzzzzzy_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> ozzzzzb_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? ozzzzzc_ = ozzzzzb_?.Value;
                    Code<Encounter.EncounterStatus> ozzzzzd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ozzzzzc_);
                    bool? ozzzzze_ = context.Operators.Equal(ozzzzzd_, "finished");
                    Period ozzzzzf_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> ozzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzf_);
                    CqlDateTime ozzzzzh_ = context.Operators.End(ozzzzzg_);
                    Period ozzzzzi_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ozzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzi_);
                    CqlDateTime ozzzzzk_ = context.Operators.Start(ozzzzzj_);
                    CqlQuantity ozzzzzl_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ozzzzzm_ = context.Operators.Subtract(ozzzzzk_, ozzzzzl_);
                    CqlInterval<CqlDateTime> ozzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzi_);
                    CqlDateTime ozzzzzp_ = context.Operators.Start(ozzzzzo_);
                    CqlInterval<CqlDateTime> ozzzzzq_ = context.Operators.Interval(ozzzzzm_, ozzzzzp_, true, true);
                    bool? ozzzzzr_ = context.Operators.In<CqlDateTime>(ozzzzzh_, ozzzzzq_, default);
                    CqlInterval<CqlDateTime> ozzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzi_);
                    CqlDateTime ozzzzzu_ = context.Operators.Start(ozzzzzt_);
                    bool? ozzzzzv_ = context.Operators.Not((bool?)(ozzzzzu_ is null));
                    bool? ozzzzzw_ = context.Operators.And(ozzzzzr_, ozzzzzv_);
                    bool? ozzzzzx_ = context.Operators.And(ozzzzze_, ozzzzzw_);

                    return ozzzzzx_;
                };
                IEnumerable<Encounter> lzzzzzz_ = context.Operators.Where<Encounter>(lzzzzzx_, lzzzzzy_);
                object mzzzzza_(Encounter @this)
                {
                    Period ozzzzzy_ = @this?.Period;
                    CqlInterval<CqlDateTime> ozzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzy_);
                    CqlDateTime pzzzzza_ = context.Operators.End(ozzzzzz_);

                    return pzzzzza_;
                };
                IEnumerable<Encounter> mzzzzzb_ = context.Operators.SortBy<Encounter>(lzzzzzz_, mzzzzza_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter mzzzzzc_ = context.Operators.Last<Encounter>(mzzzzzb_);
                Period mzzzzzd_ = mzzzzzc_?.Period;
                CqlInterval<CqlDateTime> mzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzd_);
                CqlDateTime mzzzzzf_ = context.Operators.Start(mzzzzze_);
                CqlInterval<CqlDateTime> mzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzr_);
                CqlDateTime mzzzzzi_ = context.Operators.Start(mzzzzzh_);
                CqlInterval<CqlDateTime> mzzzzzj_ = context.Operators.Interval(lzzzzzv_, mzzzzzf_ ?? mzzzzzi_, true, true);
                bool? mzzzzzk_ = context.Operators.In<CqlDateTime>(lzzzzzg_, mzzzzzj_, default);
                IEnumerable<Encounter> mzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? mzzzzzn_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> pzzzzzb_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? pzzzzzc_ = pzzzzzb_?.Value;
                    Code<Encounter.EncounterStatus> pzzzzzd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pzzzzzc_);
                    bool? pzzzzze_ = context.Operators.Equal(pzzzzzd_, "finished");
                    Period pzzzzzf_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> pzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzf_);
                    CqlDateTime pzzzzzh_ = context.Operators.End(pzzzzzg_);
                    Period pzzzzzi_ = Visit?.Period;
                    CqlInterval<CqlDateTime> pzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzi_);
                    CqlDateTime pzzzzzk_ = context.Operators.Start(pzzzzzj_);
                    CqlQuantity pzzzzzl_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime pzzzzzm_ = context.Operators.Subtract(pzzzzzk_, pzzzzzl_);
                    CqlInterval<CqlDateTime> pzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzi_);
                    CqlDateTime pzzzzzp_ = context.Operators.Start(pzzzzzo_);
                    CqlInterval<CqlDateTime> pzzzzzq_ = context.Operators.Interval(pzzzzzm_, pzzzzzp_, true, true);
                    bool? pzzzzzr_ = context.Operators.In<CqlDateTime>(pzzzzzh_, pzzzzzq_, default);
                    CqlInterval<CqlDateTime> pzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzi_);
                    CqlDateTime pzzzzzu_ = context.Operators.Start(pzzzzzt_);
                    bool? pzzzzzv_ = context.Operators.Not((bool?)(pzzzzzu_ is null));
                    bool? pzzzzzw_ = context.Operators.And(pzzzzzr_, pzzzzzv_);
                    bool? pzzzzzx_ = context.Operators.And(pzzzzze_, pzzzzzw_);

                    return pzzzzzx_;
                };
                IEnumerable<Encounter> mzzzzzo_ = context.Operators.Where<Encounter>(mzzzzzm_, mzzzzzn_);
                object mzzzzzp_(Encounter @this)
                {
                    Period pzzzzzy_ = @this?.Period;
                    CqlInterval<CqlDateTime> pzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzy_);
                    CqlDateTime qzzzzza_ = context.Operators.End(pzzzzzz_);

                    return qzzzzza_;
                };
                IEnumerable<Encounter> mzzzzzq_ = context.Operators.SortBy<Encounter>(mzzzzzo_, mzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter mzzzzzr_ = context.Operators.Last<Encounter>(mzzzzzq_);
                Period mzzzzzs_ = mzzzzzr_?.Period;
                CqlInterval<CqlDateTime> mzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzs_);
                CqlDateTime mzzzzzu_ = context.Operators.Start(mzzzzzt_);
                CqlInterval<CqlDateTime> mzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzr_);
                CqlDateTime mzzzzzx_ = context.Operators.Start(mzzzzzw_);
                bool? mzzzzzy_ = context.Operators.Not((bool?)((mzzzzzu_ ?? mzzzzzx_) is null));
                bool? mzzzzzz_ = context.Operators.And(mzzzzzk_, mzzzzzy_);
                bool? nzzzzza_ = context.Operators.And(lzzzzzd_, mzzzzzz_);

                return nzzzzza_;
            };
            IEnumerable<Encounter> kzzzzzc_ = context.Operators.Where<Encounter>(kzzzzza_, kzzzzzb_);
            object kzzzzzd_(Encounter @this)
            {
                Period qzzzzzb_ = @this?.Period;
                CqlInterval<CqlDateTime> qzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzb_);
                CqlDateTime qzzzzzd_ = context.Operators.End(qzzzzzc_);

                return qzzzzzd_;
            };
            IEnumerable<Encounter> kzzzzze_ = context.Operators.SortBy<Encounter>(kzzzzzc_, kzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter kzzzzzf_ = context.Operators.Last<Encounter>(kzzzzze_);
            Period kzzzzzg_ = kzzzzzf_?.Period;
            CqlInterval<CqlDateTime> kzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzg_);
            CqlDateTime kzzzzzi_ = context.Operators.Start(kzzzzzh_);
            CqlValueSet kzzzzzj_ = this.Observation_Services(context);
            IEnumerable<Encounter> kzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? kzzzzzl_(Encounter LastObs)
            {
                Code<Encounter.EncounterStatus> qzzzzze_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? qzzzzzf_ = qzzzzze_?.Value;
                Code<Encounter.EncounterStatus> qzzzzzg_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(qzzzzzf_);
                bool? qzzzzzh_ = context.Operators.Equal(qzzzzzg_, "finished");
                Period qzzzzzi_ = LastObs?.Period;
                CqlInterval<CqlDateTime> qzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzi_);
                CqlDateTime qzzzzzk_ = context.Operators.End(qzzzzzj_);
                Period qzzzzzl_ = Visit?.Period;
                CqlInterval<CqlDateTime> qzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzl_);
                CqlDateTime qzzzzzn_ = context.Operators.Start(qzzzzzm_);
                CqlQuantity qzzzzzo_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime qzzzzzp_ = context.Operators.Subtract(qzzzzzn_, qzzzzzo_);
                CqlInterval<CqlDateTime> qzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzl_);
                CqlDateTime qzzzzzs_ = context.Operators.Start(qzzzzzr_);
                CqlInterval<CqlDateTime> qzzzzzt_ = context.Operators.Interval(qzzzzzp_, qzzzzzs_, true, true);
                bool? qzzzzzu_ = context.Operators.In<CqlDateTime>(qzzzzzk_, qzzzzzt_, default);
                CqlInterval<CqlDateTime> qzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzl_);
                CqlDateTime qzzzzzx_ = context.Operators.Start(qzzzzzw_);
                bool? qzzzzzy_ = context.Operators.Not((bool?)(qzzzzzx_ is null));
                bool? qzzzzzz_ = context.Operators.And(qzzzzzu_, qzzzzzy_);
                bool? rzzzzza_ = context.Operators.And(qzzzzzh_, qzzzzzz_);

                return rzzzzza_;
            };
            IEnumerable<Encounter> kzzzzzm_ = context.Operators.Where<Encounter>(kzzzzzk_, kzzzzzl_);
            object kzzzzzn_(Encounter @this)
            {
                Period rzzzzzb_ = @this?.Period;
                CqlInterval<CqlDateTime> rzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzb_);
                CqlDateTime rzzzzzd_ = context.Operators.End(rzzzzzc_);

                return rzzzzzd_;
            };
            IEnumerable<Encounter> kzzzzzo_ = context.Operators.SortBy<Encounter>(kzzzzzm_, kzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter kzzzzzp_ = context.Operators.Last<Encounter>(kzzzzzo_);
            Period kzzzzzq_ = kzzzzzp_?.Period;
            CqlInterval<CqlDateTime> kzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzq_);
            CqlDateTime kzzzzzs_ = context.Operators.Start(kzzzzzr_);
            Period kzzzzzt_ = Visit?.Period;
            CqlInterval<CqlDateTime> kzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzt_);
            CqlDateTime kzzzzzv_ = context.Operators.Start(kzzzzzu_);
            CqlInterval<CqlDateTime> kzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzt_);
            CqlDateTime kzzzzzy_ = context.Operators.End(kzzzzzx_);
            CqlInterval<CqlDateTime> kzzzzzz_ = context.Operators.Interval(kzzzzzi_ ?? kzzzzzs_ ?? kzzzzzv_, kzzzzzy_, true, true);

            return kzzzzzz_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> jzzzzzw_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)jzzzzzu_, jzzzzzv_);
        IEnumerable<CqlInterval<CqlDateTime>> jzzzzzx_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(jzzzzzw_);
        CqlInterval<CqlDateTime> jzzzzzy_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(jzzzzzx_);

        return jzzzzzy_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Hospitalization with Observation Length of Stay returns the length in days from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationWithObservationLengthofStay()` instead.")]
    public int? HospitalizationWithObservationLengthofStay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> rzzzzze_ = this.HospitalizationWithObservation(context, TheEncounter);
        int? rzzzzzf_ = this.LengthInDays(context, rzzzzze_);

        return rzzzzzf_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Hospitalization with Observation Length of Stay returns the length in days from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    public int? hospitalizationWithObservationLengthofStay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> rzzzzzg_ = this.hospitalizationWithObservation(context, TheEncounter);
        int? rzzzzzh_ = this.lengthInDays(context, rzzzzzg_);

        return rzzzzzh_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "First Inpatient Intensive Care Unit returns the first intensive care unit for the given encounter, without considering any immediately prior emergency department visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `firstInpatientIntensiveCareUnit()` instead.")]
    public Encounter.LocationComponent FirstInpatientIntensiveCareUnit(CqlContext context, Encounter Encounter)
    {
        List<Encounter.LocationComponent> rzzzzzi_ = Encounter?.Location;
        bool? rzzzzzj_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference rzzzzzo_ = HospitalLocation?.Location;
            Location rzzzzzp_ = this.GetLocation(context, rzzzzzo_);
            List<CodeableConcept> rzzzzzq_ = rzzzzzp_?.Type;
            CqlConcept rzzzzzr_(CodeableConcept @this)
            {
                CqlConcept szzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return szzzzzb_;
            };
            IEnumerable<CqlConcept> rzzzzzs_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)rzzzzzq_, rzzzzzr_);
            CqlValueSet rzzzzzt_ = this.Intensive_Care_Unit(context);
            bool? rzzzzzu_ = context.Operators.ConceptsInValueSet(rzzzzzs_, rzzzzzt_);
            Period rzzzzzv_ = Encounter?.Period;
            CqlInterval<CqlDateTime> rzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzv_);
            Period rzzzzzx_ = HospitalLocation?.Period;
            CqlInterval<CqlDateTime> rzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzx_);
            bool? rzzzzzz_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(rzzzzzw_, rzzzzzy_, default);
            bool? szzzzza_ = context.Operators.And(rzzzzzu_, rzzzzzz_);

            return szzzzza_;
        };
        IEnumerable<Encounter.LocationComponent> rzzzzzk_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)rzzzzzi_, rzzzzzj_);
        object rzzzzzl_(Encounter.LocationComponent @this)
        {
            Period szzzzzc_ = @this?.Period;
            CqlInterval<CqlDateTime> szzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzc_);
            CqlDateTime szzzzze_ = context.Operators.Start(szzzzzd_);

            return szzzzze_;
        };
        IEnumerable<Encounter.LocationComponent> rzzzzzm_ = context.Operators.SortBy<Encounter.LocationComponent>(rzzzzzk_, rzzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent rzzzzzn_ = context.Operators.First<Encounter.LocationComponent>(rzzzzzm_);

        return rzzzzzn_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "First Inpatient Intensive Care Unit returns the first intensive care unit for the given encounter, without considering any immediately prior emergency department visit.")]
    public Encounter.LocationComponent firstInpatientIntensiveCareUnit(CqlContext context, Encounter Encounter)
    {
        List<Encounter.LocationComponent> szzzzzf_ = Encounter?.Location;
        bool? szzzzzg_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference szzzzzl_ = HospitalLocation?.Location;
            Location szzzzzm_ = this.GetLocation(context, szzzzzl_);
            List<CodeableConcept> szzzzzn_ = szzzzzm_?.Type;
            CqlConcept szzzzzo_(CodeableConcept @this)
            {
                CqlConcept szzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return szzzzzy_;
            };
            IEnumerable<CqlConcept> szzzzzp_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)szzzzzn_, szzzzzo_);
            CqlValueSet szzzzzq_ = this.Intensive_Care_Unit(context);
            bool? szzzzzr_ = context.Operators.ConceptsInValueSet(szzzzzp_, szzzzzq_);
            Period szzzzzs_ = Encounter?.Period;
            CqlInterval<CqlDateTime> szzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzs_);
            Period szzzzzu_ = HospitalLocation?.Period;
            CqlInterval<CqlDateTime> szzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzu_);
            bool? szzzzzw_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(szzzzzt_, szzzzzv_, default);
            bool? szzzzzx_ = context.Operators.And(szzzzzr_, szzzzzw_);

            return szzzzzx_;
        };
        IEnumerable<Encounter.LocationComponent> szzzzzh_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)szzzzzf_, szzzzzg_);
        object szzzzzi_(Encounter.LocationComponent @this)
        {
            Period szzzzzz_ = @this?.Period;
            CqlInterval<CqlDateTime> tzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzz_);
            CqlDateTime tzzzzzb_ = context.Operators.Start(tzzzzza_);

            return tzzzzzb_;
        };
        IEnumerable<Encounter.LocationComponent> szzzzzj_ = context.Operators.SortBy<Encounter.LocationComponent>(szzzzzh_, szzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent szzzzzk_ = context.Operators.First<Encounter.LocationComponent>(szzzzzj_);

        return szzzzzk_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns the Condition resource referenced by the `diagnosis.condition` element of the Encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `encounterDiagnosis()` instead.")]
    public IEnumerable<Condition> EncounterDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> tzzzzzc_ = Encounter?.Diagnosis;
        Condition tzzzzzd_(Encounter.DiagnosisComponent D)
        {
            IEnumerable<Condition> tzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? tzzzzzh_(Condition C)
            {
                Id tzzzzzk_ = C?.IdElement;
                string tzzzzzl_ = tzzzzzk_?.Value;
                ResourceReference tzzzzzm_ = D?.Condition;
                FhirString tzzzzzn_ = tzzzzzm_?.ReferenceElement;
                string tzzzzzo_ = tzzzzzn_?.Value;
                string tzzzzzp_ = QICoreCommon_2_1_000.Instance.getId(context, tzzzzzo_);
                bool? tzzzzzq_ = context.Operators.Equal(tzzzzzl_, tzzzzzp_);

                return tzzzzzq_;
            };
            IEnumerable<Condition> tzzzzzi_ = context.Operators.Where<Condition>(tzzzzzg_, tzzzzzh_);
            Condition tzzzzzj_ = context.Operators.SingletonFrom<Condition>(tzzzzzi_);

            return tzzzzzj_;
        };
        IEnumerable<Condition> tzzzzze_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)tzzzzzc_, tzzzzzd_);
        IEnumerable<Condition> tzzzzzf_ = context.Operators.Distinct<Condition>(tzzzzze_);

        return tzzzzzf_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns the Condition resources referenced by the diagnosis element of the Encounter")]
    public IEnumerable<Condition> encounterDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> tzzzzzr_ = Encounter?.Diagnosis;
        Condition tzzzzzs_(Encounter.DiagnosisComponent D)
        {
            IEnumerable<Condition> tzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? tzzzzzw_(Condition C)
            {
                Id tzzzzzz_ = C?.IdElement;
                string uzzzzza_ = tzzzzzz_?.Value;
                ResourceReference uzzzzzb_ = D?.Condition;
                FhirString uzzzzzc_ = uzzzzzb_?.ReferenceElement;
                string uzzzzzd_ = uzzzzzc_?.Value;
                string uzzzzze_ = QICoreCommon_2_1_000.Instance.getId(context, uzzzzzd_);
                bool? uzzzzzf_ = context.Operators.Equal(uzzzzza_, uzzzzze_);

                return uzzzzzf_;
            };
            IEnumerable<Condition> tzzzzzx_ = context.Operators.Where<Condition>(tzzzzzv_, tzzzzzw_);
            Condition tzzzzzy_ = context.Operators.SingletonFrom<Condition>(tzzzzzx_);

            return tzzzzzy_;
        };
        IEnumerable<Condition> tzzzzzt_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)tzzzzzr_, tzzzzzs_);
        IEnumerable<Condition> tzzzzzu_ = context.Operators.Distinct<Condition>(tzzzzzt_);

        return tzzzzzu_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns the Condition resource for the given reference")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getCondition()` instead")]
    public Condition GetCondition(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Condition> uzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? uzzzzzh_(Condition C)
        {
            Id uzzzzzk_ = C?.IdElement;
            string uzzzzzl_ = uzzzzzk_?.Value;
            FhirString uzzzzzm_ = reference?.ReferenceElement;
            string uzzzzzn_ = uzzzzzm_?.Value;
            string uzzzzzo_ = QICoreCommon_2_1_000.Instance.getId(context, uzzzzzn_);
            bool? uzzzzzp_ = context.Operators.Equal(uzzzzzl_, uzzzzzo_);

            return uzzzzzp_;
        };
        IEnumerable<Condition> uzzzzzi_ = context.Operators.Where<Condition>(uzzzzzg_, uzzzzzh_);
        Condition uzzzzzj_ = context.Operators.SingletonFrom<Condition>(uzzzzzi_);

        return uzzzzzj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns the Condition resource for the given reference")]
    public Condition getCondition(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Condition> uzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? uzzzzzr_(Condition C)
        {
            Id uzzzzzu_ = C?.IdElement;
            string uzzzzzv_ = uzzzzzu_?.Value;
            FhirString uzzzzzw_ = reference?.ReferenceElement;
            string uzzzzzx_ = uzzzzzw_?.Value;
            string uzzzzzy_ = QICoreCommon_2_1_000.Instance.getId(context, uzzzzzx_);
            bool? uzzzzzz_ = context.Operators.Equal(uzzzzzv_, uzzzzzy_);

            return uzzzzzz_;
        };
        IEnumerable<Condition> uzzzzzs_ = context.Operators.Where<Condition>(uzzzzzq_, uzzzzzr_);
        Condition uzzzzzt_ = context.Operators.SingletonFrom<Condition>(uzzzzzs_);

        return uzzzzzt_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns the condition that is specified as the principal diagnosis for the encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `principalDiagnosis()` instead.")]
    public Condition PrincipalDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> vzzzzza_ = Encounter?.Diagnosis;
        bool? vzzzzzb_(Encounter.DiagnosisComponent D)
        {
            PositiveInt vzzzzzh_ = D?.RankElement;
            int? vzzzzzi_ = vzzzzzh_?.Value;
            bool? vzzzzzj_ = context.Operators.Equal(vzzzzzi_, 1);
            CodeableConcept vzzzzzk_ = D?.Use;
            CqlConcept vzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzk_);
            CqlCode vzzzzzm_ = this.Billing(context);
            CqlConcept vzzzzzn_ = context.Operators.ConvertCodeToConcept(vzzzzzm_);
            bool? vzzzzzo_ = context.Operators.Equivalent(vzzzzzl_, vzzzzzn_);
            bool? vzzzzzp_ = context.Operators.And(vzzzzzj_, vzzzzzo_);

            return vzzzzzp_;
        };
        IEnumerable<Encounter.DiagnosisComponent> vzzzzzc_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)vzzzzza_, vzzzzzb_);
        Condition vzzzzzd_(Encounter.DiagnosisComponent PD)
        {
            IEnumerable<Condition> vzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? vzzzzzr_(Condition C)
            {
                Id vzzzzzu_ = C?.IdElement;
                string vzzzzzv_ = vzzzzzu_?.Value;
                ResourceReference vzzzzzw_ = PD?.Condition;
                FhirString vzzzzzx_ = vzzzzzw_?.ReferenceElement;
                string vzzzzzy_ = vzzzzzx_?.Value;
                string vzzzzzz_ = QICoreCommon_2_1_000.Instance.getId(context, vzzzzzy_);
                bool? wzzzzza_ = context.Operators.Equal(vzzzzzv_, vzzzzzz_);

                return wzzzzza_;
            };
            IEnumerable<Condition> vzzzzzs_ = context.Operators.Where<Condition>(vzzzzzq_, vzzzzzr_);
            Condition vzzzzzt_ = context.Operators.SingletonFrom<Condition>(vzzzzzs_);

            return vzzzzzt_;
        };
        IEnumerable<Condition> vzzzzze_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>(vzzzzzc_, vzzzzzd_);
        IEnumerable<Condition> vzzzzzf_ = context.Operators.Distinct<Condition>(vzzzzze_);
        Condition vzzzzzg_ = context.Operators.SingletonFrom<Condition>(vzzzzzf_);

        return vzzzzzg_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns the condition that is specified as the principal diagnosis for the encounter")]
    public Condition principalDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> wzzzzzb_ = Encounter?.Diagnosis;
        bool? wzzzzzc_(Encounter.DiagnosisComponent D)
        {
            PositiveInt wzzzzzi_ = D?.RankElement;
            int? wzzzzzj_ = wzzzzzi_?.Value;
            bool? wzzzzzk_ = context.Operators.Equal(wzzzzzj_, 1);
            CodeableConcept wzzzzzl_ = D?.Use;
            CqlConcept wzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, wzzzzzl_);
            CqlCode wzzzzzn_ = this.Billing(context);
            CqlConcept wzzzzzo_ = context.Operators.ConvertCodeToConcept(wzzzzzn_);
            bool? wzzzzzp_ = context.Operators.Equivalent(wzzzzzm_, wzzzzzo_);
            bool? wzzzzzq_ = context.Operators.And(wzzzzzk_, wzzzzzp_);

            return wzzzzzq_;
        };
        IEnumerable<Encounter.DiagnosisComponent> wzzzzzd_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)wzzzzzb_, wzzzzzc_);
        Condition wzzzzze_(Encounter.DiagnosisComponent PD)
        {
            IEnumerable<Condition> wzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? wzzzzzs_(Condition C)
            {
                Id wzzzzzv_ = C?.IdElement;
                string wzzzzzw_ = wzzzzzv_?.Value;
                ResourceReference wzzzzzx_ = PD?.Condition;
                FhirString wzzzzzy_ = wzzzzzx_?.ReferenceElement;
                string wzzzzzz_ = wzzzzzy_?.Value;
                string xzzzzza_ = QICoreCommon_2_1_000.Instance.getId(context, wzzzzzz_);
                bool? xzzzzzb_ = context.Operators.Equal(wzzzzzw_, xzzzzza_);

                return xzzzzzb_;
            };
            IEnumerable<Condition> wzzzzzt_ = context.Operators.Where<Condition>(wzzzzzr_, wzzzzzs_);
            Condition wzzzzzu_ = context.Operators.SingletonFrom<Condition>(wzzzzzt_);

            return wzzzzzu_;
        };
        IEnumerable<Condition> wzzzzzf_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>(wzzzzzd_, wzzzzze_);
        IEnumerable<Condition> wzzzzzg_ = context.Operators.Distinct<Condition>(wzzzzzf_);
        Condition wzzzzzh_ = context.Operators.SingletonFrom<Condition>(wzzzzzg_);

        return wzzzzzh_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns the Location resource specified by the given reference.")]
    public Location getLocation(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Location> xzzzzzc_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-location"));
        bool? xzzzzzd_(Location L)
        {
            Id xzzzzzg_ = L?.IdElement;
            string xzzzzzh_ = xzzzzzg_?.Value;
            FhirString xzzzzzi_ = reference?.ReferenceElement;
            string xzzzzzj_ = xzzzzzi_?.Value;
            string xzzzzzk_ = QICoreCommon_2_1_000.Instance.getId(context, xzzzzzj_);
            bool? xzzzzzl_ = context.Operators.Equal(xzzzzzh_, xzzzzzk_);

            return xzzzzzl_;
        };
        IEnumerable<Location> xzzzzze_ = context.Operators.Where<Location>(xzzzzzc_, xzzzzzd_);
        Location xzzzzzf_ = context.Operators.SingletonFrom<Location>(xzzzzze_);

        return xzzzzzf_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns the medication code for the given MedicationRequest")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getMedicationCode()` instead.")]
    public CqlConcept GetMedicationCode(CqlContext context, MedicationRequest request)
    {
        CqlConcept xzzzzzm_()
        {
            bool xzzzzzn_()
            {
                DataType xzzzzzo_ = request?.Medication;
                object xzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzo_);
                bool xzzzzzq_ = xzzzzzp_ is CqlConcept;

                return xzzzzzq_;
            };
            if (xzzzzzn_())
            {
                DataType xzzzzzr_ = request?.Medication;
                object xzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzr_);

                return xzzzzzs_ as CqlConcept;
            }
            else
            {
                IEnumerable<Medication> xzzzzzt_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? xzzzzzu_(Medication M)
                {
                    Id xzzzzzz_ = M?.IdElement;
                    string yzzzzza_ = xzzzzzz_?.Value;
                    DataType yzzzzzb_ = request?.Medication;
                    object yzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzb_);
                    FhirString yzzzzzd_ = (yzzzzzc_ as ResourceReference)?.ReferenceElement;
                    string yzzzzze_ = yzzzzzd_?.Value;
                    string yzzzzzf_ = QICoreCommon_2_1_000.Instance.getId(context, yzzzzze_);
                    bool? yzzzzzg_ = context.Operators.Equal(yzzzzza_, yzzzzzf_);

                    return yzzzzzg_;
                };
                IEnumerable<Medication> xzzzzzv_ = context.Operators.Where<Medication>(xzzzzzt_, xzzzzzu_);
                Medication xzzzzzw_ = context.Operators.SingletonFrom<Medication>(xzzzzzv_);
                CodeableConcept xzzzzzx_ = xzzzzzw_?.Code;
                CqlConcept xzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, xzzzzzx_);

                return xzzzzzy_;
            }
        };

        return xzzzzzm_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns the medication code for the given MedicationRequest")]
    public CqlConcept getMedicationCode(CqlContext context, MedicationRequest request)
    {
        CqlConcept yzzzzzh_()
        {
            bool yzzzzzi_()
            {
                DataType yzzzzzj_ = request?.Medication;
                object yzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzj_);
                bool yzzzzzl_ = yzzzzzk_ is CqlConcept;

                return yzzzzzl_;
            };
            if (yzzzzzi_())
            {
                DataType yzzzzzm_ = request?.Medication;
                object yzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzm_);

                return yzzzzzn_ as CqlConcept;
            }
            else
            {
                IEnumerable<Medication> yzzzzzo_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? yzzzzzp_(Medication M)
                {
                    Id yzzzzzu_ = M?.IdElement;
                    string yzzzzzv_ = yzzzzzu_?.Value;
                    DataType yzzzzzw_ = request?.Medication;
                    object yzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzw_);
                    FhirString yzzzzzy_ = (yzzzzzx_ as ResourceReference)?.ReferenceElement;
                    string yzzzzzz_ = yzzzzzy_?.Value;
                    string zzzzzza_ = QICoreCommon_2_1_000.Instance.getId(context, yzzzzzz_);
                    bool? zzzzzzb_ = context.Operators.Equal(yzzzzzv_, zzzzzza_);

                    return zzzzzzb_;
                };
                IEnumerable<Medication> yzzzzzq_ = context.Operators.Where<Medication>(yzzzzzo_, yzzzzzp_);
                Medication yzzzzzr_ = context.Operators.SingletonFrom<Medication>(yzzzzzq_);
                CodeableConcept yzzzzzs_ = yzzzzzr_?.Code;
                CqlConcept yzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzs_);

                return yzzzzzt_;
            }
        };

        return yzzzzzh_();
    }


    #endregion Expressions

}
