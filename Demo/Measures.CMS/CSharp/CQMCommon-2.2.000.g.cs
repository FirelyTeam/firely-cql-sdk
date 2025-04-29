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
        CqlDateTime izzzzzzb_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime izzzzzzc_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> izzzzzzd_ = context.Operators.Interval(izzzzzzb_, izzzzzzc_, true, false);
        object izzzzzze_ = context.ResolveParameter("CQMCommon-2.2.000", "Measurement Period", izzzzzzd_);

        return (CqlInterval<CqlDateTime>)izzzzzze_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> izzzzzzf_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient izzzzzzg_ = context.Operators.SingletonFrom<Patient>(izzzzzzf_);

        return izzzzzzg_;
    }


    [CqlExpressionDefinition("Inpatient Encounter")]
    public IEnumerable<Encounter> Inpatient_Encounter(CqlContext context)
    {
        CqlValueSet izzzzzzh_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> izzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? izzzzzzj_(Encounter EncounterInpatient)
        {
            Code<Encounter.EncounterStatus> izzzzzzl_ = EncounterInpatient?.StatusElement;
            Encounter.EncounterStatus? izzzzzzm_ = izzzzzzl_?.Value;
            Code<Encounter.EncounterStatus> izzzzzzn_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(izzzzzzm_);
            bool? izzzzzzo_ = context.Operators.Equal(izzzzzzn_, "finished");
            Period izzzzzzp_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime> izzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzp_);
            CqlDateTime izzzzzzr_ = context.Operators.End(izzzzzzq_);
            CqlInterval<CqlDateTime> izzzzzzs_ = this.Measurement_Period(context);
            bool? izzzzzzt_ = context.Operators.In<CqlDateTime>(izzzzzzr_, izzzzzzs_, "day");
            bool? izzzzzzu_ = context.Operators.And(izzzzzzo_, izzzzzzt_);

            return izzzzzzu_;
        };
        IEnumerable<Encounter> izzzzzzk_ = context.Operators.Where<Encounter>(izzzzzzi_, izzzzzzj_);

        return izzzzzzk_;
    }


    [CqlExpressionDefinition("ToDateInterval")]
    [CqlTag("description", "Returns an interval of date values extracted from the input interval of date-time values")]
    [CqlTag("comment", "This function returns an interval constructed using the `date from` extractor on the start\nand end values of the input date-time interval. Note that using a precision specifier such as `day of`\nas part of a timing phrase is preferred to communicate intent to perform day-level comparison, as well\nas for general readability.")]
    public CqlInterval<CqlDate> ToDateInterval(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime izzzzzzv_ = context.Operators.Start(period);
        CqlDate izzzzzzw_ = context.Operators.DateFrom(izzzzzzv_);
        CqlDateTime izzzzzzx_ = context.Operators.End(period);
        CqlDate izzzzzzy_ = context.Operators.DateFrom(izzzzzzx_);
        CqlInterval<CqlDate> izzzzzzz_ = context.Operators.Interval(izzzzzzw_, izzzzzzy_, true, true);

        return izzzzzzz_;
    }


    [CqlExpressionDefinition("LengthInDays")]
    [CqlTag("description", "Calculates the difference in calendar days between the start and end of the given interval.")]
    [CqlTag("deprecated", "This function in deprecated. Use the fluent function `lengthInDays()` instead.")]
    public int? LengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
    {
        CqlDateTime jzzzzzza_ = context.Operators.Start(Value);
        CqlDateTime jzzzzzzb_ = context.Operators.End(Value);
        int? jzzzzzzc_ = context.Operators.DifferenceBetween(jzzzzzza_, jzzzzzzb_, "day");

        return jzzzzzzc_;
    }


    [CqlExpressionDefinition("lengthInDays")]
    [CqlTag("description", "Calculates the difference in calendar days between the start and end of the given interval.")]
    public int? lengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
    {
        CqlDateTime jzzzzzzd_ = context.Operators.Start(Value);
        CqlDateTime jzzzzzze_ = context.Operators.End(Value);
        int? jzzzzzzf_ = context.Operators.DifferenceBetween(jzzzzzzd_, jzzzzzze_, "day");

        return jzzzzzzf_;
    }


    [CqlExpressionDefinition("ED Visit")]
    [CqlTag("description", "Returns the most recent emergency department visit, if any, that occurs 1 hour or less prior to the given encounter.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `edVisit()` instead.")]
    public Encounter ED_Visit(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet jzzzzzzg_ = this.Emergency_Department_Visit(context);
        IEnumerable<Encounter> jzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? jzzzzzzi_(Encounter EDVisit)
        {
            Code<Encounter.EncounterStatus> jzzzzzzn_ = EDVisit?.StatusElement;
            Encounter.EncounterStatus? jzzzzzzo_ = jzzzzzzn_?.Value;
            Code<Encounter.EncounterStatus> jzzzzzzp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jzzzzzzo_);
            bool? jzzzzzzq_ = context.Operators.Equal(jzzzzzzp_, "finished");
            Period jzzzzzzr_ = EDVisit?.Period;
            CqlInterval<CqlDateTime> jzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzr_);
            CqlDateTime jzzzzzzt_ = context.Operators.End(jzzzzzzs_);
            Period jzzzzzzu_ = TheEncounter?.Period;
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
        IEnumerable<Encounter> jzzzzzzj_ = context.Operators.Where<Encounter>(jzzzzzzh_, jzzzzzzi_);
        object jzzzzzzk_(Encounter @this)
        {
            Period kzzzzzzk_ = @this?.Period;
            CqlInterval<CqlDateTime> kzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzk_);
            CqlDateTime kzzzzzzm_ = context.Operators.End(kzzzzzzl_);

            return kzzzzzzm_;
        };
        IEnumerable<Encounter> jzzzzzzl_ = context.Operators.SortBy<Encounter>(jzzzzzzj_, jzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter jzzzzzzm_ = context.Operators.Last<Encounter>(jzzzzzzl_);

        return jzzzzzzm_;
    }


    [CqlExpressionDefinition("edVisit")]
    [CqlTag("description", "Returns the most recent emergency department visit, if any, that occurs 1 hour or less prior to the given encounter.")]
    public Encounter edVisit(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet kzzzzzzn_ = this.Emergency_Department_Visit(context);
        IEnumerable<Encounter> kzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? kzzzzzzp_(Encounter EDVisit)
        {
            Code<Encounter.EncounterStatus> kzzzzzzu_ = EDVisit?.StatusElement;
            Encounter.EncounterStatus? kzzzzzzv_ = kzzzzzzu_?.Value;
            Code<Encounter.EncounterStatus> kzzzzzzw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(kzzzzzzv_);
            bool? kzzzzzzx_ = context.Operators.Equal(kzzzzzzw_, "finished");
            Period kzzzzzzy_ = EDVisit?.Period;
            CqlInterval<CqlDateTime> kzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzy_);
            CqlDateTime lzzzzzza_ = context.Operators.End(kzzzzzzz_);
            Period lzzzzzzb_ = TheEncounter?.Period;
            CqlInterval<CqlDateTime> lzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzb_);
            CqlDateTime lzzzzzzd_ = context.Operators.Start(lzzzzzzc_);
            CqlQuantity lzzzzzze_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime lzzzzzzf_ = context.Operators.Subtract(lzzzzzzd_, lzzzzzze_);
            CqlInterval<CqlDateTime> lzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzb_);
            CqlDateTime lzzzzzzi_ = context.Operators.Start(lzzzzzzh_);
            CqlInterval<CqlDateTime> lzzzzzzj_ = context.Operators.Interval(lzzzzzzf_, lzzzzzzi_, true, true);
            bool? lzzzzzzk_ = context.Operators.In<CqlDateTime>(lzzzzzza_, lzzzzzzj_, default);
            CqlInterval<CqlDateTime> lzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzb_);
            CqlDateTime lzzzzzzn_ = context.Operators.Start(lzzzzzzm_);
            bool? lzzzzzzo_ = context.Operators.Not((bool?)(lzzzzzzn_ is null));
            bool? lzzzzzzp_ = context.Operators.And(lzzzzzzk_, lzzzzzzo_);
            bool? lzzzzzzq_ = context.Operators.And(kzzzzzzx_, lzzzzzzp_);

            return lzzzzzzq_;
        };
        IEnumerable<Encounter> kzzzzzzq_ = context.Operators.Where<Encounter>(kzzzzzzo_, kzzzzzzp_);
        object kzzzzzzr_(Encounter @this)
        {
            Period lzzzzzzr_ = @this?.Period;
            CqlInterval<CqlDateTime> lzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzr_);
            CqlDateTime lzzzzzzt_ = context.Operators.End(lzzzzzzs_);

            return lzzzzzzt_;
        };
        IEnumerable<Encounter> kzzzzzzs_ = context.Operators.SortBy<Encounter>(kzzzzzzq_, kzzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter kzzzzzzt_ = context.Operators.Last<Encounter>(kzzzzzzs_);

        return kzzzzzzt_;
    }


    [CqlExpressionDefinition("Hospitalization")]
    [CqlTag("description", "Hospitalization returns the total interval for admission to discharge for the given encounter, or for the admission of any immediately prior emergency department visit to the discharge of the given encounter.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalization()` instead.")]
    public CqlInterval<CqlDateTime> Hospitalization(CqlContext context, Encounter TheEncounter)
    {
        Encounter lzzzzzzu_ = this.ED_Visit(context, TheEncounter);
        Encounter[] lzzzzzzv_ = [
            lzzzzzzu_,
        ];
        CqlInterval<CqlDateTime> lzzzzzzw_(Encounter X)
        {
            CqlInterval<CqlDateTime> mzzzzzza_()
            {
                if (X is null)
                {
                    Period mzzzzzzb_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> mzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzb_);

                    return mzzzzzzc_;
                }
                else
                {
                    Period mzzzzzzd_ = X?.Period;
                    CqlInterval<CqlDateTime> mzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzd_);
                    CqlDateTime mzzzzzzf_ = context.Operators.Start(mzzzzzze_);
                    Period mzzzzzzg_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> mzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzg_);
                    CqlDateTime mzzzzzzi_ = context.Operators.End(mzzzzzzh_);
                    CqlInterval<CqlDateTime> mzzzzzzj_ = context.Operators.Interval(mzzzzzzf_, mzzzzzzi_, true, false);

                    return mzzzzzzj_;
                }
            };

            return mzzzzzza_();
        };
        IEnumerable<CqlInterval<CqlDateTime>> lzzzzzzx_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)lzzzzzzv_, lzzzzzzw_);
        IEnumerable<CqlInterval<CqlDateTime>> lzzzzzzy_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(lzzzzzzx_);
        CqlInterval<CqlDateTime> lzzzzzzz_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(lzzzzzzy_);

        return lzzzzzzz_;
    }


    [CqlExpressionDefinition("hospitalization")]
    [CqlTag("description", "Hospitalization returns the total interval for admission to discharge for the given encounter, or for the admission of any immediately prior emergency department visit to the discharge of the given encounter.")]
    public CqlInterval<CqlDateTime> hospitalization(CqlContext context, Encounter TheEncounter)
    {
        Encounter mzzzzzzk_ = this.edVisit(context, TheEncounter);
        Encounter[] mzzzzzzl_ = [
            mzzzzzzk_,
        ];
        CqlInterval<CqlDateTime> mzzzzzzm_(Encounter X)
        {
            CqlInterval<CqlDateTime> mzzzzzzq_()
            {
                if (X is null)
                {
                    Period mzzzzzzr_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> mzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzr_);

                    return mzzzzzzs_;
                }
                else
                {
                    Period mzzzzzzt_ = X?.Period;
                    CqlInterval<CqlDateTime> mzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzt_);
                    CqlDateTime mzzzzzzv_ = context.Operators.Start(mzzzzzzu_);
                    Period mzzzzzzw_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> mzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzw_);
                    CqlDateTime mzzzzzzy_ = context.Operators.End(mzzzzzzx_);
                    CqlInterval<CqlDateTime> mzzzzzzz_ = context.Operators.Interval(mzzzzzzv_, mzzzzzzy_, true, true);

                    return mzzzzzzz_;
                }
            };

            return mzzzzzzq_();
        };
        IEnumerable<CqlInterval<CqlDateTime>> mzzzzzzn_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)mzzzzzzl_, mzzzzzzm_);
        IEnumerable<CqlInterval<CqlDateTime>> mzzzzzzo_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(mzzzzzzn_);
        CqlInterval<CqlDateTime> mzzzzzzp_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(mzzzzzzo_);

        return mzzzzzzp_;
    }


    [CqlExpressionDefinition("Hospitalization Locations")]
    [CqlTag("description", "Returns list of all locations within an encounter, including locations for immediately prior ED visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationLocations()` instead.")]
    public IEnumerable<Encounter.LocationComponent> Hospitalization_Locations(CqlContext context, Encounter TheEncounter)
    {
        Encounter nzzzzzza_ = this.ED_Visit(context, TheEncounter);
        Encounter[] nzzzzzzb_ = [
            nzzzzzza_,
        ];
        IEnumerable<Encounter.LocationComponent> nzzzzzzc_(Encounter EDEncounter)
        {
            IEnumerable<Encounter.LocationComponent> nzzzzzzg_()
            {
                if (EDEncounter is null)
                {
                    List<Encounter.LocationComponent> nzzzzzzh_ = TheEncounter?.Location;

                    return (IEnumerable<Encounter.LocationComponent>)nzzzzzzh_;
                }
                else
                {
                    List<Encounter.LocationComponent> nzzzzzzi_ = EDEncounter?.Location;
                    List<Encounter.LocationComponent> nzzzzzzj_ = TheEncounter?.Location;
                    IEnumerable<Encounter.LocationComponent>[] nzzzzzzk_ = [
                        (IEnumerable<Encounter.LocationComponent>)nzzzzzzi_,
                        (IEnumerable<Encounter.LocationComponent>)nzzzzzzj_,
                    ];
                    IEnumerable<Encounter.LocationComponent> nzzzzzzl_ = context.Operators.Flatten<Encounter.LocationComponent>(nzzzzzzk_ as IEnumerable<IEnumerable<Encounter.LocationComponent>>);

                    return nzzzzzzl_;
                }
            };

            return nzzzzzzg_();
        };
        IEnumerable<IEnumerable<Encounter.LocationComponent>> nzzzzzzd_ = context.Operators.Select<Encounter, IEnumerable<Encounter.LocationComponent>>((IEnumerable<Encounter>)nzzzzzzb_, nzzzzzzc_);
        IEnumerable<IEnumerable<Encounter.LocationComponent>> nzzzzzze_ = context.Operators.Distinct<IEnumerable<Encounter.LocationComponent>>(nzzzzzzd_);
        IEnumerable<Encounter.LocationComponent> nzzzzzzf_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(nzzzzzze_);

        return nzzzzzzf_;
    }


    [CqlExpressionDefinition("hospitalizationLocations")]
    [CqlTag("description", "Returns list of all locations within an encounter, including locations for immediately prior ED visit.")]
    public IEnumerable<Encounter.LocationComponent> hospitalizationLocations(CqlContext context, Encounter TheEncounter)
    {
        Encounter nzzzzzzm_ = this.edVisit(context, TheEncounter);
        Encounter[] nzzzzzzn_ = [
            nzzzzzzm_,
        ];
        IEnumerable<Encounter.LocationComponent> nzzzzzzo_(Encounter EDEncounter)
        {
            IEnumerable<Encounter.LocationComponent> nzzzzzzs_()
            {
                if (EDEncounter is null)
                {
                    List<Encounter.LocationComponent> nzzzzzzt_ = TheEncounter?.Location;

                    return (IEnumerable<Encounter.LocationComponent>)nzzzzzzt_;
                }
                else
                {
                    List<Encounter.LocationComponent> nzzzzzzu_ = EDEncounter?.Location;
                    List<Encounter.LocationComponent> nzzzzzzv_ = TheEncounter?.Location;
                    IEnumerable<Encounter.LocationComponent>[] nzzzzzzw_ = [
                        (IEnumerable<Encounter.LocationComponent>)nzzzzzzu_,
                        (IEnumerable<Encounter.LocationComponent>)nzzzzzzv_,
                    ];
                    IEnumerable<Encounter.LocationComponent> nzzzzzzx_ = context.Operators.Flatten<Encounter.LocationComponent>(nzzzzzzw_ as IEnumerable<IEnumerable<Encounter.LocationComponent>>);

                    return nzzzzzzx_;
                }
            };

            return nzzzzzzs_();
        };
        IEnumerable<IEnumerable<Encounter.LocationComponent>> nzzzzzzp_ = context.Operators.Select<Encounter, IEnumerable<Encounter.LocationComponent>>((IEnumerable<Encounter>)nzzzzzzn_, nzzzzzzo_);
        IEnumerable<IEnumerable<Encounter.LocationComponent>> nzzzzzzq_ = context.Operators.Distinct<IEnumerable<Encounter.LocationComponent>>(nzzzzzzp_);
        IEnumerable<Encounter.LocationComponent> nzzzzzzr_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(nzzzzzzq_);

        return nzzzzzzr_;
    }


    [CqlExpressionDefinition("Hospitalization Length of Stay")]
    [CqlTag("description", "Returns the length of stay in days (i.e. the number of days between admission and discharge) for the given encounter, or from the admission of any immediately prior emergency department visit to the discharge of the encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationLengthOfStay()` instead.")]
    public int? Hospitalization_Length_of_Stay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> nzzzzzzy_ = this.Hospitalization(context, TheEncounter);
        int? nzzzzzzz_ = this.LengthInDays(context, nzzzzzzy_);

        return nzzzzzzz_;
    }


    [CqlExpressionDefinition("hospitalizationLengthOfStay")]
    [CqlTag("description", "Returns the length of stay in days (i.e. the number of days between admission and discharge) for the given encounter, or from the admission of any immediately prior emergency department visit to the discharge of the encounter")]
    public int? hospitalizationLengthOfStay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> ozzzzzza_ = this.hospitalization(context, TheEncounter);
        int? ozzzzzzb_ = this.lengthInDays(context, ozzzzzza_);

        return ozzzzzzb_;
    }


    [CqlExpressionDefinition("Hospital Admission Time")]
    [CqlTag("description", "Returns admission time for an encounter or for immediately prior emergency department visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalAdmissionTime()` instead.")]
    public CqlDateTime Hospital_Admission_Time(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> ozzzzzzc_ = this.Hospitalization(context, TheEncounter);
        CqlDateTime ozzzzzzd_ = context.Operators.Start(ozzzzzzc_);

        return ozzzzzzd_;
    }


    [CqlExpressionDefinition("hospitalAdmissionTime")]
    [CqlTag("description", "Returns admission time for an encounter or for immediately prior emergency department visit.")]
    public CqlDateTime hospitalAdmissionTime(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> ozzzzzze_ = this.hospitalization(context, TheEncounter);
        CqlDateTime ozzzzzzf_ = context.Operators.Start(ozzzzzze_);

        return ozzzzzzf_;
    }


    [CqlExpressionDefinition("Hospital Discharge Time")]
    [CqlTag("description", "Hospital Discharge Time returns the discharge time for an encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalDischargeTime()` instead.")]
    public CqlDateTime Hospital_Discharge_Time(CqlContext context, Encounter TheEncounter)
    {
        Period ozzzzzzg_ = TheEncounter?.Period;
        CqlInterval<CqlDateTime> ozzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzg_);
        CqlDateTime ozzzzzzi_ = context.Operators.End(ozzzzzzh_);

        return ozzzzzzi_;
    }


    [CqlExpressionDefinition("hospitalDischargeTime")]
    [CqlTag("description", "Hospital Discharge Time returns the discharge time for an encounter")]
    public CqlDateTime hospitalDischargeTime(CqlContext context, Encounter TheEncounter)
    {
        Period ozzzzzzj_ = TheEncounter?.Period;
        CqlInterval<CqlDateTime> ozzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzj_);
        CqlDateTime ozzzzzzl_ = context.Operators.End(ozzzzzzk_);

        return ozzzzzzl_;
    }


    [CqlExpressionDefinition("Hospital Arrival Time")]
    [CqlTag("description", "Returns earliest arrival time for an encounter including any prior ED visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalArrivalTime()` instead.")]
    public CqlDateTime Hospital_Arrival_Time(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> ozzzzzzm_ = this.Hospitalization_Locations(context, TheEncounter);
        object ozzzzzzn_(Encounter.LocationComponent @this)
        {
            Period ozzzzzzt_ = @this?.Period;
            CqlInterval<CqlDateTime> ozzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzt_);
            CqlDateTime ozzzzzzv_ = context.Operators.Start(ozzzzzzu_);

            return ozzzzzzv_;
        };
        IEnumerable<Encounter.LocationComponent> ozzzzzzo_ = context.Operators.SortBy<Encounter.LocationComponent>(ozzzzzzm_, ozzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent ozzzzzzp_ = context.Operators.First<Encounter.LocationComponent>(ozzzzzzo_);
        Period ozzzzzzq_ = ozzzzzzp_?.Period;
        CqlInterval<CqlDateTime> ozzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzq_);
        CqlDateTime ozzzzzzs_ = context.Operators.Start(ozzzzzzr_);

        return ozzzzzzs_;
    }


    [CqlExpressionDefinition("hospitalArrivalTime")]
    [CqlTag("description", "Returns earliest arrival time for an encounter including any prior ED visit.")]
    public CqlDateTime hospitalArrivalTime(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> ozzzzzzw_ = this.hospitalizationLocations(context, TheEncounter);
        object ozzzzzzx_(Encounter.LocationComponent @this)
        {
            Period pzzzzzzd_ = @this?.Period;
            CqlInterval<CqlDateTime> pzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzd_);
            CqlDateTime pzzzzzzf_ = context.Operators.Start(pzzzzzze_);

            return pzzzzzzf_;
        };
        IEnumerable<Encounter.LocationComponent> ozzzzzzy_ = context.Operators.SortBy<Encounter.LocationComponent>(ozzzzzzw_, ozzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent ozzzzzzz_ = context.Operators.First<Encounter.LocationComponent>(ozzzzzzy_);
        Period pzzzzzza_ = ozzzzzzz_?.Period;
        CqlInterval<CqlDateTime> pzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzza_);
        CqlDateTime pzzzzzzc_ = context.Operators.Start(pzzzzzzb_);

        return pzzzzzzc_;
    }


    [CqlExpressionDefinition("Hospital Departure Time")]
    [CqlTag("description", "Returns the latest departure time for encounter including any prior ED visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalDepartureTime()` instead.")]
    public CqlDateTime Hospital_Departure_Time(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> pzzzzzzg_ = this.Hospitalization_Locations(context, TheEncounter);
        object pzzzzzzh_(Encounter.LocationComponent @this)
        {
            Period pzzzzzzn_ = @this?.Period;
            CqlInterval<CqlDateTime> pzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzn_);
            CqlDateTime pzzzzzzp_ = context.Operators.Start(pzzzzzzo_);

            return pzzzzzzp_;
        };
        IEnumerable<Encounter.LocationComponent> pzzzzzzi_ = context.Operators.SortBy<Encounter.LocationComponent>(pzzzzzzg_, pzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent pzzzzzzj_ = context.Operators.Last<Encounter.LocationComponent>(pzzzzzzi_);
        Period pzzzzzzk_ = pzzzzzzj_?.Period;
        CqlInterval<CqlDateTime> pzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzk_);
        CqlDateTime pzzzzzzm_ = context.Operators.End(pzzzzzzl_);

        return pzzzzzzm_;
    }


    [CqlExpressionDefinition("hospitalDepartureTime")]
    [CqlTag("description", "Returns the latest departure time for encounter including any prior ED visit.")]
    public CqlDateTime hospitalDepartureTime(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> pzzzzzzq_ = this.hospitalizationLocations(context, TheEncounter);
        object pzzzzzzr_(Encounter.LocationComponent @this)
        {
            Period pzzzzzzx_ = @this?.Period;
            CqlInterval<CqlDateTime> pzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzx_);
            CqlDateTime pzzzzzzz_ = context.Operators.Start(pzzzzzzy_);

            return pzzzzzzz_;
        };
        IEnumerable<Encounter.LocationComponent> pzzzzzzs_ = context.Operators.SortBy<Encounter.LocationComponent>(pzzzzzzq_, pzzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent pzzzzzzt_ = context.Operators.Last<Encounter.LocationComponent>(pzzzzzzs_);
        Period pzzzzzzu_ = pzzzzzzt_?.Period;
        CqlInterval<CqlDateTime> pzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzu_);
        CqlDateTime pzzzzzzw_ = context.Operators.End(pzzzzzzv_);

        return pzzzzzzw_;
    }


    [CqlExpressionDefinition("GetLocation")]
    [CqlTag("description", "Returns the Location resource specified by the given reference")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getLocation()` instead.")]
    public Location GetLocation(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Location> qzzzzzza_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-location"));
        bool? qzzzzzzb_(Location L)
        {
            Id qzzzzzze_ = L?.IdElement;
            string qzzzzzzf_ = qzzzzzze_?.Value;
            FhirString qzzzzzzg_ = reference?.ReferenceElement;
            string qzzzzzzh_ = qzzzzzzg_?.Value;
            string qzzzzzzi_ = QICoreCommon_2_1_000.Instance.getId(context, qzzzzzzh_);
            bool? qzzzzzzj_ = context.Operators.Equal(qzzzzzzf_, qzzzzzzi_);

            return qzzzzzzj_;
        };
        IEnumerable<Location> qzzzzzzc_ = context.Operators.Where<Location>(qzzzzzza_, qzzzzzzb_);
        Location qzzzzzzd_ = context.Operators.SingletonFrom<Location>(qzzzzzzc_);

        return qzzzzzzd_;
    }


    [CqlExpressionDefinition("Emergency Department Arrival Time")]
    [CqlTag("description", "Returns the emergency department arrival time for the encounter.")]
    public CqlDateTime Emergency_Department_Arrival_Time(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> qzzzzzzk_ = this.Hospitalization_Locations(context, TheEncounter);
        bool? qzzzzzzl_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference qzzzzzzr_ = HospitalLocation?.Location;
            Location qzzzzzzs_ = this.GetLocation(context, qzzzzzzr_);
            List<CodeableConcept> qzzzzzzt_ = qzzzzzzs_?.Type;
            CqlConcept qzzzzzzu_(CodeableConcept @this)
            {
                CqlConcept qzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return qzzzzzzy_;
            };
            IEnumerable<CqlConcept> qzzzzzzv_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)qzzzzzzt_, qzzzzzzu_);
            CqlValueSet qzzzzzzw_ = this.Emergency_Department_Visit(context);
            bool? qzzzzzzx_ = context.Operators.ConceptsInValueSet(qzzzzzzv_, qzzzzzzw_);

            return qzzzzzzx_;
        };
        IEnumerable<Encounter.LocationComponent> qzzzzzzm_ = context.Operators.Where<Encounter.LocationComponent>(qzzzzzzk_, qzzzzzzl_);
        Encounter.LocationComponent qzzzzzzn_ = context.Operators.SingletonFrom<Encounter.LocationComponent>(qzzzzzzm_);
        Period qzzzzzzo_ = qzzzzzzn_?.Period;
        CqlInterval<CqlDateTime> qzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzo_);
        CqlDateTime qzzzzzzq_ = context.Operators.Start(qzzzzzzp_);

        return qzzzzzzq_;
    }


    [CqlExpressionDefinition("emergencyDepartmentArrivalTime")]
    [CqlTag("description", "Returns the emergency department arrival time for the encounter.")]
    public CqlDateTime emergencyDepartmentArrivalTime(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> qzzzzzzz_ = this.hospitalizationLocations(context, TheEncounter);
        bool? rzzzzzza_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference rzzzzzzg_ = HospitalLocation?.Location;
            Location rzzzzzzh_ = this.GetLocation(context, rzzzzzzg_);
            List<CodeableConcept> rzzzzzzi_ = rzzzzzzh_?.Type;
            CqlConcept rzzzzzzj_(CodeableConcept @this)
            {
                CqlConcept rzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return rzzzzzzn_;
            };
            IEnumerable<CqlConcept> rzzzzzzk_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)rzzzzzzi_, rzzzzzzj_);
            CqlValueSet rzzzzzzl_ = this.Emergency_Department_Visit(context);
            bool? rzzzzzzm_ = context.Operators.ConceptsInValueSet(rzzzzzzk_, rzzzzzzl_);

            return rzzzzzzm_;
        };
        IEnumerable<Encounter.LocationComponent> rzzzzzzb_ = context.Operators.Where<Encounter.LocationComponent>(qzzzzzzz_, rzzzzzza_);
        Encounter.LocationComponent rzzzzzzc_ = context.Operators.SingletonFrom<Encounter.LocationComponent>(rzzzzzzb_);
        Period rzzzzzzd_ = rzzzzzzc_?.Period;
        CqlInterval<CqlDateTime> rzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzd_);
        CqlDateTime rzzzzzzf_ = context.Operators.Start(rzzzzzze_);

        return rzzzzzzf_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservationAndOutpatientSurgeryService")]
    [CqlTag("description", "Hospitalization with Observation and Outpatient Surgery Service returns the total interval from the start of any immediately prior emergency department visit, outpatient surgery visit or observation visit to the discharge of the given encounter.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationWithObservationAndOutpatientSurgeryService()` instead.")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservationAndOutpatientSurgeryService(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] rzzzzzzo_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> rzzzzzzp_(Encounter Visit)
        {
            CqlValueSet rzzzzzzt_ = this.Outpatient_Surgery_Service(context);
            IEnumerable<Encounter> rzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? rzzzzzzv_(Encounter LastSurgeryOP)
            {
                Period tzzzzzze_ = LastSurgeryOP?.Period;
                CqlInterval<CqlDateTime> tzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzze_);
                CqlDateTime tzzzzzzg_ = context.Operators.End(tzzzzzzf_);
                CqlValueSet tzzzzzzh_ = this.Emergency_Department_Visit(context);
                IEnumerable<Encounter> tzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? tzzzzzzj_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> wzzzzzze_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? wzzzzzzf_ = wzzzzzze_?.Value;
                    Code<Encounter.EncounterStatus> wzzzzzzg_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(wzzzzzzf_);
                    bool? wzzzzzzh_ = context.Operators.Equal(wzzzzzzg_, "finished");
                    Period wzzzzzzi_ = LastED?.Period;
                    CqlInterval<CqlDateTime> wzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzi_);
                    CqlDateTime wzzzzzzk_ = context.Operators.End(wzzzzzzj_);
                    CqlValueSet wzzzzzzl_ = this.Observation_Services(context);
                    IEnumerable<Encounter> wzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? wzzzzzzn_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> yzzzzzzf_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? yzzzzzzg_ = yzzzzzzf_?.Value;
                        Code<Encounter.EncounterStatus> yzzzzzzh_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(yzzzzzzg_);
                        bool? yzzzzzzi_ = context.Operators.Equal(yzzzzzzh_, "finished");
                        Period yzzzzzzj_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> yzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzj_);
                        CqlDateTime yzzzzzzl_ = context.Operators.End(yzzzzzzk_);
                        Period yzzzzzzm_ = Visit?.Period;
                        CqlInterval<CqlDateTime> yzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzm_);
                        CqlDateTime yzzzzzzo_ = context.Operators.Start(yzzzzzzn_);
                        CqlQuantity yzzzzzzp_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime yzzzzzzq_ = context.Operators.Subtract(yzzzzzzo_, yzzzzzzp_);
                        CqlInterval<CqlDateTime> yzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzm_);
                        CqlDateTime yzzzzzzt_ = context.Operators.Start(yzzzzzzs_);
                        CqlInterval<CqlDateTime> yzzzzzzu_ = context.Operators.Interval(yzzzzzzq_, yzzzzzzt_, true, true);
                        bool? yzzzzzzv_ = context.Operators.In<CqlDateTime>(yzzzzzzl_, yzzzzzzu_, default);
                        CqlInterval<CqlDateTime> yzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzm_);
                        CqlDateTime yzzzzzzy_ = context.Operators.Start(yzzzzzzx_);
                        bool? yzzzzzzz_ = context.Operators.Not((bool?)(yzzzzzzy_ is null));
                        bool? zzzzzzza_ = context.Operators.And(yzzzzzzv_, yzzzzzzz_);
                        bool? zzzzzzzb_ = context.Operators.And(yzzzzzzi_, zzzzzzza_);

                        return zzzzzzzb_;
                    };
                    IEnumerable<Encounter> wzzzzzzo_ = context.Operators.Where<Encounter>(wzzzzzzm_, wzzzzzzn_);
                    object wzzzzzzp_(Encounter @this)
                    {
                        Period zzzzzzzc_ = @this?.Period;
                        CqlInterval<CqlDateTime> zzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzc_);
                        CqlDateTime zzzzzzze_ = context.Operators.End(zzzzzzzd_);

                        return zzzzzzze_;
                    };
                    IEnumerable<Encounter> wzzzzzzq_ = context.Operators.SortBy<Encounter>(wzzzzzzo_, wzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter wzzzzzzr_ = context.Operators.Last<Encounter>(wzzzzzzq_);
                    Period wzzzzzzs_ = wzzzzzzr_?.Period;
                    CqlInterval<CqlDateTime> wzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzs_);
                    CqlDateTime wzzzzzzu_ = context.Operators.Start(wzzzzzzt_);
                    Period wzzzzzzv_ = Visit?.Period;
                    CqlInterval<CqlDateTime> wzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzv_);
                    CqlDateTime wzzzzzzx_ = context.Operators.Start(wzzzzzzw_);
                    CqlQuantity wzzzzzzy_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime wzzzzzzz_ = context.Operators.Subtract(wzzzzzzu_ ?? wzzzzzzx_, wzzzzzzy_);
                    IEnumerable<Encounter> xzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? xzzzzzzc_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> zzzzzzzf_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? zzzzzzzg_ = zzzzzzzf_?.Value;
                        Code<Encounter.EncounterStatus> zzzzzzzh_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(zzzzzzzg_);
                        bool? zzzzzzzi_ = context.Operators.Equal(zzzzzzzh_, "finished");
                        Period zzzzzzzj_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> zzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzj_);
                        CqlDateTime zzzzzzzl_ = context.Operators.End(zzzzzzzk_);
                        Period zzzzzzzm_ = Visit?.Period;
                        CqlInterval<CqlDateTime> zzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzm_);
                        CqlDateTime zzzzzzzo_ = context.Operators.Start(zzzzzzzn_);
                        CqlQuantity zzzzzzzp_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime zzzzzzzq_ = context.Operators.Subtract(zzzzzzzo_, zzzzzzzp_);
                        CqlInterval<CqlDateTime> zzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzm_);
                        CqlDateTime zzzzzzzt_ = context.Operators.Start(zzzzzzzs_);
                        CqlInterval<CqlDateTime> zzzzzzzu_ = context.Operators.Interval(zzzzzzzq_, zzzzzzzt_, true, true);
                        bool? zzzzzzzv_ = context.Operators.In<CqlDateTime>(zzzzzzzl_, zzzzzzzu_, default);
                        CqlInterval<CqlDateTime> zzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzm_);
                        CqlDateTime zzzzzzzy_ = context.Operators.Start(zzzzzzzx_);
                        bool? zzzzzzzz_ = context.Operators.Not((bool?)(zzzzzzzy_ is null));
                        bool? azzzzzzza_ = context.Operators.And(zzzzzzzv_, zzzzzzzz_);
                        bool? azzzzzzzb_ = context.Operators.And(zzzzzzzi_, azzzzzzza_);

                        return azzzzzzzb_;
                    };
                    IEnumerable<Encounter> xzzzzzzd_ = context.Operators.Where<Encounter>(xzzzzzzb_, xzzzzzzc_);
                    object xzzzzzze_(Encounter @this)
                    {
                        Period azzzzzzzc_ = @this?.Period;
                        CqlInterval<CqlDateTime> azzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzc_);
                        CqlDateTime azzzzzzze_ = context.Operators.End(azzzzzzzd_);

                        return azzzzzzze_;
                    };
                    IEnumerable<Encounter> xzzzzzzf_ = context.Operators.SortBy<Encounter>(xzzzzzzd_, xzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter xzzzzzzg_ = context.Operators.Last<Encounter>(xzzzzzzf_);
                    Period xzzzzzzh_ = xzzzzzzg_?.Period;
                    CqlInterval<CqlDateTime> xzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzh_);
                    CqlDateTime xzzzzzzj_ = context.Operators.Start(xzzzzzzi_);
                    CqlInterval<CqlDateTime> xzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzv_);
                    CqlDateTime xzzzzzzm_ = context.Operators.Start(xzzzzzzl_);
                    CqlInterval<CqlDateTime> xzzzzzzn_ = context.Operators.Interval(wzzzzzzz_, xzzzzzzj_ ?? xzzzzzzm_, true, true);
                    bool? xzzzzzzo_ = context.Operators.In<CqlDateTime>(wzzzzzzk_, xzzzzzzn_, default);
                    IEnumerable<Encounter> xzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? xzzzzzzr_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> azzzzzzzf_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? azzzzzzzg_ = azzzzzzzf_?.Value;
                        Code<Encounter.EncounterStatus> azzzzzzzh_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(azzzzzzzg_);
                        bool? azzzzzzzi_ = context.Operators.Equal(azzzzzzzh_, "finished");
                        Period azzzzzzzj_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> azzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzj_);
                        CqlDateTime azzzzzzzl_ = context.Operators.End(azzzzzzzk_);
                        Period azzzzzzzm_ = Visit?.Period;
                        CqlInterval<CqlDateTime> azzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzm_);
                        CqlDateTime azzzzzzzo_ = context.Operators.Start(azzzzzzzn_);
                        CqlQuantity azzzzzzzp_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime azzzzzzzq_ = context.Operators.Subtract(azzzzzzzo_, azzzzzzzp_);
                        CqlInterval<CqlDateTime> azzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzm_);
                        CqlDateTime azzzzzzzt_ = context.Operators.Start(azzzzzzzs_);
                        CqlInterval<CqlDateTime> azzzzzzzu_ = context.Operators.Interval(azzzzzzzq_, azzzzzzzt_, true, true);
                        bool? azzzzzzzv_ = context.Operators.In<CqlDateTime>(azzzzzzzl_, azzzzzzzu_, default);
                        CqlInterval<CqlDateTime> azzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzm_);
                        CqlDateTime azzzzzzzy_ = context.Operators.Start(azzzzzzzx_);
                        bool? azzzzzzzz_ = context.Operators.Not((bool?)(azzzzzzzy_ is null));
                        bool? bzzzzzzza_ = context.Operators.And(azzzzzzzv_, azzzzzzzz_);
                        bool? bzzzzzzzb_ = context.Operators.And(azzzzzzzi_, bzzzzzzza_);

                        return bzzzzzzzb_;
                    };
                    IEnumerable<Encounter> xzzzzzzs_ = context.Operators.Where<Encounter>(xzzzzzzq_, xzzzzzzr_);
                    object xzzzzzzt_(Encounter @this)
                    {
                        Period bzzzzzzzc_ = @this?.Period;
                        CqlInterval<CqlDateTime> bzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzc_);
                        CqlDateTime bzzzzzzze_ = context.Operators.End(bzzzzzzzd_);

                        return bzzzzzzze_;
                    };
                    IEnumerable<Encounter> xzzzzzzu_ = context.Operators.SortBy<Encounter>(xzzzzzzs_, xzzzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter xzzzzzzv_ = context.Operators.Last<Encounter>(xzzzzzzu_);
                    Period xzzzzzzw_ = xzzzzzzv_?.Period;
                    CqlInterval<CqlDateTime> xzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzw_);
                    CqlDateTime xzzzzzzy_ = context.Operators.Start(xzzzzzzx_);
                    CqlInterval<CqlDateTime> yzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzv_);
                    CqlDateTime yzzzzzzb_ = context.Operators.Start(yzzzzzza_);
                    bool? yzzzzzzc_ = context.Operators.Not((bool?)((xzzzzzzy_ ?? yzzzzzzb_) is null));
                    bool? yzzzzzzd_ = context.Operators.And(xzzzzzzo_, yzzzzzzc_);
                    bool? yzzzzzze_ = context.Operators.And(wzzzzzzh_, yzzzzzzd_);

                    return yzzzzzze_;
                };
                IEnumerable<Encounter> tzzzzzzk_ = context.Operators.Where<Encounter>(tzzzzzzi_, tzzzzzzj_);
                object tzzzzzzl_(Encounter @this)
                {
                    Period bzzzzzzzf_ = @this?.Period;
                    CqlInterval<CqlDateTime> bzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzf_);
                    CqlDateTime bzzzzzzzh_ = context.Operators.End(bzzzzzzzg_);

                    return bzzzzzzzh_;
                };
                IEnumerable<Encounter> tzzzzzzm_ = context.Operators.SortBy<Encounter>(tzzzzzzk_, tzzzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter tzzzzzzn_ = context.Operators.Last<Encounter>(tzzzzzzm_);
                Period tzzzzzzo_ = tzzzzzzn_?.Period;
                CqlInterval<CqlDateTime> tzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzo_);
                CqlDateTime tzzzzzzq_ = context.Operators.Start(tzzzzzzp_);
                CqlValueSet tzzzzzzr_ = this.Observation_Services(context);
                IEnumerable<Encounter> tzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? tzzzzzzt_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> bzzzzzzzi_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? bzzzzzzzj_ = bzzzzzzzi_?.Value;
                    Code<Encounter.EncounterStatus> bzzzzzzzk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bzzzzzzzj_);
                    bool? bzzzzzzzl_ = context.Operators.Equal(bzzzzzzzk_, "finished");
                    Period bzzzzzzzm_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> bzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzm_);
                    CqlDateTime bzzzzzzzo_ = context.Operators.End(bzzzzzzzn_);
                    Period bzzzzzzzp_ = Visit?.Period;
                    CqlInterval<CqlDateTime> bzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzp_);
                    CqlDateTime bzzzzzzzr_ = context.Operators.Start(bzzzzzzzq_);
                    CqlQuantity bzzzzzzzs_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime bzzzzzzzt_ = context.Operators.Subtract(bzzzzzzzr_, bzzzzzzzs_);
                    CqlInterval<CqlDateTime> bzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzp_);
                    CqlDateTime bzzzzzzzw_ = context.Operators.Start(bzzzzzzzv_);
                    CqlInterval<CqlDateTime> bzzzzzzzx_ = context.Operators.Interval(bzzzzzzzt_, bzzzzzzzw_, true, true);
                    bool? bzzzzzzzy_ = context.Operators.In<CqlDateTime>(bzzzzzzzo_, bzzzzzzzx_, default);
                    CqlInterval<CqlDateTime> czzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzp_);
                    CqlDateTime czzzzzzzb_ = context.Operators.Start(czzzzzzza_);
                    bool? czzzzzzzc_ = context.Operators.Not((bool?)(czzzzzzzb_ is null));
                    bool? czzzzzzzd_ = context.Operators.And(bzzzzzzzy_, czzzzzzzc_);
                    bool? czzzzzzze_ = context.Operators.And(bzzzzzzzl_, czzzzzzzd_);

                    return czzzzzzze_;
                };
                IEnumerable<Encounter> tzzzzzzu_ = context.Operators.Where<Encounter>(tzzzzzzs_, tzzzzzzt_);
                object tzzzzzzv_(Encounter @this)
                {
                    Period czzzzzzzf_ = @this?.Period;
                    CqlInterval<CqlDateTime> czzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzf_);
                    CqlDateTime czzzzzzzh_ = context.Operators.End(czzzzzzzg_);

                    return czzzzzzzh_;
                };
                IEnumerable<Encounter> tzzzzzzw_ = context.Operators.SortBy<Encounter>(tzzzzzzu_, tzzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter tzzzzzzx_ = context.Operators.Last<Encounter>(tzzzzzzw_);
                Period tzzzzzzy_ = tzzzzzzx_?.Period;
                CqlInterval<CqlDateTime> tzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzy_);
                CqlDateTime uzzzzzza_ = context.Operators.Start(tzzzzzzz_);
                Period uzzzzzzb_ = Visit?.Period;
                CqlInterval<CqlDateTime> uzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzb_);
                CqlDateTime uzzzzzzd_ = context.Operators.Start(uzzzzzzc_);
                CqlQuantity uzzzzzze_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime uzzzzzzf_ = context.Operators.Subtract(tzzzzzzq_ ?? uzzzzzza_ ?? uzzzzzzd_, uzzzzzze_);
                IEnumerable<Encounter> uzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? uzzzzzzi_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> czzzzzzzi_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? czzzzzzzj_ = czzzzzzzi_?.Value;
                    Code<Encounter.EncounterStatus> czzzzzzzk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(czzzzzzzj_);
                    bool? czzzzzzzl_ = context.Operators.Equal(czzzzzzzk_, "finished");
                    Period czzzzzzzm_ = LastED?.Period;
                    CqlInterval<CqlDateTime> czzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzm_);
                    CqlDateTime czzzzzzzo_ = context.Operators.End(czzzzzzzn_);
                    CqlValueSet czzzzzzzp_ = this.Observation_Services(context);
                    IEnumerable<Encounter> czzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? czzzzzzzr_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> ezzzzzzzj_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? ezzzzzzzk_ = ezzzzzzzj_?.Value;
                        Code<Encounter.EncounterStatus> ezzzzzzzl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ezzzzzzzk_);
                        bool? ezzzzzzzm_ = context.Operators.Equal(ezzzzzzzl_, "finished");
                        Period ezzzzzzzn_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> ezzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzn_);
                        CqlDateTime ezzzzzzzp_ = context.Operators.End(ezzzzzzzo_);
                        Period ezzzzzzzq_ = Visit?.Period;
                        CqlInterval<CqlDateTime> ezzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzq_);
                        CqlDateTime ezzzzzzzs_ = context.Operators.Start(ezzzzzzzr_);
                        CqlQuantity ezzzzzzzt_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime ezzzzzzzu_ = context.Operators.Subtract(ezzzzzzzs_, ezzzzzzzt_);
                        CqlInterval<CqlDateTime> ezzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzq_);
                        CqlDateTime ezzzzzzzx_ = context.Operators.Start(ezzzzzzzw_);
                        CqlInterval<CqlDateTime> ezzzzzzzy_ = context.Operators.Interval(ezzzzzzzu_, ezzzzzzzx_, true, true);
                        bool? ezzzzzzzz_ = context.Operators.In<CqlDateTime>(ezzzzzzzp_, ezzzzzzzy_, default);
                        CqlInterval<CqlDateTime> fzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzq_);
                        CqlDateTime fzzzzzzzc_ = context.Operators.Start(fzzzzzzzb_);
                        bool? fzzzzzzzd_ = context.Operators.Not((bool?)(fzzzzzzzc_ is null));
                        bool? fzzzzzzze_ = context.Operators.And(ezzzzzzzz_, fzzzzzzzd_);
                        bool? fzzzzzzzf_ = context.Operators.And(ezzzzzzzm_, fzzzzzzze_);

                        return fzzzzzzzf_;
                    };
                    IEnumerable<Encounter> czzzzzzzs_ = context.Operators.Where<Encounter>(czzzzzzzq_, czzzzzzzr_);
                    object czzzzzzzt_(Encounter @this)
                    {
                        Period fzzzzzzzg_ = @this?.Period;
                        CqlInterval<CqlDateTime> fzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzg_);
                        CqlDateTime fzzzzzzzi_ = context.Operators.End(fzzzzzzzh_);

                        return fzzzzzzzi_;
                    };
                    IEnumerable<Encounter> czzzzzzzu_ = context.Operators.SortBy<Encounter>(czzzzzzzs_, czzzzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter czzzzzzzv_ = context.Operators.Last<Encounter>(czzzzzzzu_);
                    Period czzzzzzzw_ = czzzzzzzv_?.Period;
                    CqlInterval<CqlDateTime> czzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzw_);
                    CqlDateTime czzzzzzzy_ = context.Operators.Start(czzzzzzzx_);
                    Period czzzzzzzz_ = Visit?.Period;
                    CqlInterval<CqlDateTime> dzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzz_);
                    CqlDateTime dzzzzzzzb_ = context.Operators.Start(dzzzzzzza_);
                    CqlQuantity dzzzzzzzc_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime dzzzzzzzd_ = context.Operators.Subtract(czzzzzzzy_ ?? dzzzzzzzb_, dzzzzzzzc_);
                    IEnumerable<Encounter> dzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? dzzzzzzzg_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> fzzzzzzzj_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? fzzzzzzzk_ = fzzzzzzzj_?.Value;
                        Code<Encounter.EncounterStatus> fzzzzzzzl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fzzzzzzzk_);
                        bool? fzzzzzzzm_ = context.Operators.Equal(fzzzzzzzl_, "finished");
                        Period fzzzzzzzn_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> fzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzn_);
                        CqlDateTime fzzzzzzzp_ = context.Operators.End(fzzzzzzzo_);
                        Period fzzzzzzzq_ = Visit?.Period;
                        CqlInterval<CqlDateTime> fzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzq_);
                        CqlDateTime fzzzzzzzs_ = context.Operators.Start(fzzzzzzzr_);
                        CqlQuantity fzzzzzzzt_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime fzzzzzzzu_ = context.Operators.Subtract(fzzzzzzzs_, fzzzzzzzt_);
                        CqlInterval<CqlDateTime> fzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzq_);
                        CqlDateTime fzzzzzzzx_ = context.Operators.Start(fzzzzzzzw_);
                        CqlInterval<CqlDateTime> fzzzzzzzy_ = context.Operators.Interval(fzzzzzzzu_, fzzzzzzzx_, true, true);
                        bool? fzzzzzzzz_ = context.Operators.In<CqlDateTime>(fzzzzzzzp_, fzzzzzzzy_, default);
                        CqlInterval<CqlDateTime> gzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzq_);
                        CqlDateTime gzzzzzzzc_ = context.Operators.Start(gzzzzzzzb_);
                        bool? gzzzzzzzd_ = context.Operators.Not((bool?)(gzzzzzzzc_ is null));
                        bool? gzzzzzzze_ = context.Operators.And(fzzzzzzzz_, gzzzzzzzd_);
                        bool? gzzzzzzzf_ = context.Operators.And(fzzzzzzzm_, gzzzzzzze_);

                        return gzzzzzzzf_;
                    };
                    IEnumerable<Encounter> dzzzzzzzh_ = context.Operators.Where<Encounter>(dzzzzzzzf_, dzzzzzzzg_);
                    object dzzzzzzzi_(Encounter @this)
                    {
                        Period gzzzzzzzg_ = @this?.Period;
                        CqlInterval<CqlDateTime> gzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzg_);
                        CqlDateTime gzzzzzzzi_ = context.Operators.End(gzzzzzzzh_);

                        return gzzzzzzzi_;
                    };
                    IEnumerable<Encounter> dzzzzzzzj_ = context.Operators.SortBy<Encounter>(dzzzzzzzh_, dzzzzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter dzzzzzzzk_ = context.Operators.Last<Encounter>(dzzzzzzzj_);
                    Period dzzzzzzzl_ = dzzzzzzzk_?.Period;
                    CqlInterval<CqlDateTime> dzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzl_);
                    CqlDateTime dzzzzzzzn_ = context.Operators.Start(dzzzzzzzm_);
                    CqlInterval<CqlDateTime> dzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzz_);
                    CqlDateTime dzzzzzzzq_ = context.Operators.Start(dzzzzzzzp_);
                    CqlInterval<CqlDateTime> dzzzzzzzr_ = context.Operators.Interval(dzzzzzzzd_, dzzzzzzzn_ ?? dzzzzzzzq_, true, true);
                    bool? dzzzzzzzs_ = context.Operators.In<CqlDateTime>(czzzzzzzo_, dzzzzzzzr_, default);
                    IEnumerable<Encounter> dzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? dzzzzzzzv_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> gzzzzzzzj_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? gzzzzzzzk_ = gzzzzzzzj_?.Value;
                        Code<Encounter.EncounterStatus> gzzzzzzzl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gzzzzzzzk_);
                        bool? gzzzzzzzm_ = context.Operators.Equal(gzzzzzzzl_, "finished");
                        Period gzzzzzzzn_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> gzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzn_);
                        CqlDateTime gzzzzzzzp_ = context.Operators.End(gzzzzzzzo_);
                        Period gzzzzzzzq_ = Visit?.Period;
                        CqlInterval<CqlDateTime> gzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzq_);
                        CqlDateTime gzzzzzzzs_ = context.Operators.Start(gzzzzzzzr_);
                        CqlQuantity gzzzzzzzt_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime gzzzzzzzu_ = context.Operators.Subtract(gzzzzzzzs_, gzzzzzzzt_);
                        CqlInterval<CqlDateTime> gzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzq_);
                        CqlDateTime gzzzzzzzx_ = context.Operators.Start(gzzzzzzzw_);
                        CqlInterval<CqlDateTime> gzzzzzzzy_ = context.Operators.Interval(gzzzzzzzu_, gzzzzzzzx_, true, true);
                        bool? gzzzzzzzz_ = context.Operators.In<CqlDateTime>(gzzzzzzzp_, gzzzzzzzy_, default);
                        CqlInterval<CqlDateTime> hzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzq_);
                        CqlDateTime hzzzzzzzc_ = context.Operators.Start(hzzzzzzzb_);
                        bool? hzzzzzzzd_ = context.Operators.Not((bool?)(hzzzzzzzc_ is null));
                        bool? hzzzzzzze_ = context.Operators.And(gzzzzzzzz_, hzzzzzzzd_);
                        bool? hzzzzzzzf_ = context.Operators.And(gzzzzzzzm_, hzzzzzzze_);

                        return hzzzzzzzf_;
                    };
                    IEnumerable<Encounter> dzzzzzzzw_ = context.Operators.Where<Encounter>(dzzzzzzzu_, dzzzzzzzv_);
                    object dzzzzzzzx_(Encounter @this)
                    {
                        Period hzzzzzzzg_ = @this?.Period;
                        CqlInterval<CqlDateTime> hzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzg_);
                        CqlDateTime hzzzzzzzi_ = context.Operators.End(hzzzzzzzh_);

                        return hzzzzzzzi_;
                    };
                    IEnumerable<Encounter> dzzzzzzzy_ = context.Operators.SortBy<Encounter>(dzzzzzzzw_, dzzzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter dzzzzzzzz_ = context.Operators.Last<Encounter>(dzzzzzzzy_);
                    Period ezzzzzzza_ = dzzzzzzzz_?.Period;
                    CqlInterval<CqlDateTime> ezzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzza_);
                    CqlDateTime ezzzzzzzc_ = context.Operators.Start(ezzzzzzzb_);
                    CqlInterval<CqlDateTime> ezzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzz_);
                    CqlDateTime ezzzzzzzf_ = context.Operators.Start(ezzzzzzze_);
                    bool? ezzzzzzzg_ = context.Operators.Not((bool?)((ezzzzzzzc_ ?? ezzzzzzzf_) is null));
                    bool? ezzzzzzzh_ = context.Operators.And(dzzzzzzzs_, ezzzzzzzg_);
                    bool? ezzzzzzzi_ = context.Operators.And(czzzzzzzl_, ezzzzzzzh_);

                    return ezzzzzzzi_;
                };
                IEnumerable<Encounter> uzzzzzzj_ = context.Operators.Where<Encounter>(uzzzzzzh_, uzzzzzzi_);
                object uzzzzzzk_(Encounter @this)
                {
                    Period hzzzzzzzj_ = @this?.Period;
                    CqlInterval<CqlDateTime> hzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzj_);
                    CqlDateTime hzzzzzzzl_ = context.Operators.End(hzzzzzzzk_);

                    return hzzzzzzzl_;
                };
                IEnumerable<Encounter> uzzzzzzl_ = context.Operators.SortBy<Encounter>(uzzzzzzj_, uzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter uzzzzzzm_ = context.Operators.Last<Encounter>(uzzzzzzl_);
                Period uzzzzzzn_ = uzzzzzzm_?.Period;
                CqlInterval<CqlDateTime> uzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzn_);
                CqlDateTime uzzzzzzp_ = context.Operators.Start(uzzzzzzo_);
                IEnumerable<Encounter> uzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? uzzzzzzs_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> hzzzzzzzm_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? hzzzzzzzn_ = hzzzzzzzm_?.Value;
                    Code<Encounter.EncounterStatus> hzzzzzzzo_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hzzzzzzzn_);
                    bool? hzzzzzzzp_ = context.Operators.Equal(hzzzzzzzo_, "finished");
                    Period hzzzzzzzq_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> hzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzq_);
                    CqlDateTime hzzzzzzzs_ = context.Operators.End(hzzzzzzzr_);
                    Period hzzzzzzzt_ = Visit?.Period;
                    CqlInterval<CqlDateTime> hzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzt_);
                    CqlDateTime hzzzzzzzv_ = context.Operators.Start(hzzzzzzzu_);
                    CqlQuantity hzzzzzzzw_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime hzzzzzzzx_ = context.Operators.Subtract(hzzzzzzzv_, hzzzzzzzw_);
                    CqlInterval<CqlDateTime> hzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzt_);
                    CqlDateTime izzzzzzza_ = context.Operators.Start(hzzzzzzzz_);
                    CqlInterval<CqlDateTime> izzzzzzzb_ = context.Operators.Interval(hzzzzzzzx_, izzzzzzza_, true, true);
                    bool? izzzzzzzc_ = context.Operators.In<CqlDateTime>(hzzzzzzzs_, izzzzzzzb_, default);
                    CqlInterval<CqlDateTime> izzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzt_);
                    CqlDateTime izzzzzzzf_ = context.Operators.Start(izzzzzzze_);
                    bool? izzzzzzzg_ = context.Operators.Not((bool?)(izzzzzzzf_ is null));
                    bool? izzzzzzzh_ = context.Operators.And(izzzzzzzc_, izzzzzzzg_);
                    bool? izzzzzzzi_ = context.Operators.And(hzzzzzzzp_, izzzzzzzh_);

                    return izzzzzzzi_;
                };
                IEnumerable<Encounter> uzzzzzzt_ = context.Operators.Where<Encounter>(uzzzzzzr_, uzzzzzzs_);
                object uzzzzzzu_(Encounter @this)
                {
                    Period izzzzzzzj_ = @this?.Period;
                    CqlInterval<CqlDateTime> izzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzj_);
                    CqlDateTime izzzzzzzl_ = context.Operators.End(izzzzzzzk_);

                    return izzzzzzzl_;
                };
                IEnumerable<Encounter> uzzzzzzv_ = context.Operators.SortBy<Encounter>(uzzzzzzt_, uzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter uzzzzzzw_ = context.Operators.Last<Encounter>(uzzzzzzv_);
                Period uzzzzzzx_ = uzzzzzzw_?.Period;
                CqlInterval<CqlDateTime> uzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzx_);
                CqlDateTime uzzzzzzz_ = context.Operators.Start(uzzzzzzy_);
                CqlInterval<CqlDateTime> vzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzb_);
                CqlDateTime vzzzzzzc_ = context.Operators.Start(vzzzzzzb_);
                CqlInterval<CqlDateTime> vzzzzzzd_ = context.Operators.Interval(uzzzzzzf_, uzzzzzzp_ ?? uzzzzzzz_ ?? vzzzzzzc_, true, true);
                bool? vzzzzzze_ = context.Operators.In<CqlDateTime>(tzzzzzzg_, vzzzzzzd_, default);
                IEnumerable<Encounter> vzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? vzzzzzzh_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> izzzzzzzm_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? izzzzzzzn_ = izzzzzzzm_?.Value;
                    Code<Encounter.EncounterStatus> izzzzzzzo_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(izzzzzzzn_);
                    bool? izzzzzzzp_ = context.Operators.Equal(izzzzzzzo_, "finished");
                    Period izzzzzzzq_ = LastED?.Period;
                    CqlInterval<CqlDateTime> izzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzq_);
                    CqlDateTime izzzzzzzs_ = context.Operators.End(izzzzzzzr_);
                    CqlValueSet izzzzzzzt_ = this.Observation_Services(context);
                    IEnumerable<Encounter> izzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? izzzzzzzv_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> kzzzzzzzn_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? kzzzzzzzo_ = kzzzzzzzn_?.Value;
                        Code<Encounter.EncounterStatus> kzzzzzzzp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(kzzzzzzzo_);
                        bool? kzzzzzzzq_ = context.Operators.Equal(kzzzzzzzp_, "finished");
                        Period kzzzzzzzr_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> kzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzr_);
                        CqlDateTime kzzzzzzzt_ = context.Operators.End(kzzzzzzzs_);
                        Period kzzzzzzzu_ = Visit?.Period;
                        CqlInterval<CqlDateTime> kzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzu_);
                        CqlDateTime kzzzzzzzw_ = context.Operators.Start(kzzzzzzzv_);
                        CqlQuantity kzzzzzzzx_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime kzzzzzzzy_ = context.Operators.Subtract(kzzzzzzzw_, kzzzzzzzx_);
                        CqlInterval<CqlDateTime> lzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzu_);
                        CqlDateTime lzzzzzzzb_ = context.Operators.Start(lzzzzzzza_);
                        CqlInterval<CqlDateTime> lzzzzzzzc_ = context.Operators.Interval(kzzzzzzzy_, lzzzzzzzb_, true, true);
                        bool? lzzzzzzzd_ = context.Operators.In<CqlDateTime>(kzzzzzzzt_, lzzzzzzzc_, default);
                        CqlInterval<CqlDateTime> lzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzu_);
                        CqlDateTime lzzzzzzzg_ = context.Operators.Start(lzzzzzzzf_);
                        bool? lzzzzzzzh_ = context.Operators.Not((bool?)(lzzzzzzzg_ is null));
                        bool? lzzzzzzzi_ = context.Operators.And(lzzzzzzzd_, lzzzzzzzh_);
                        bool? lzzzzzzzj_ = context.Operators.And(kzzzzzzzq_, lzzzzzzzi_);

                        return lzzzzzzzj_;
                    };
                    IEnumerable<Encounter> izzzzzzzw_ = context.Operators.Where<Encounter>(izzzzzzzu_, izzzzzzzv_);
                    object izzzzzzzx_(Encounter @this)
                    {
                        Period lzzzzzzzk_ = @this?.Period;
                        CqlInterval<CqlDateTime> lzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzk_);
                        CqlDateTime lzzzzzzzm_ = context.Operators.End(lzzzzzzzl_);

                        return lzzzzzzzm_;
                    };
                    IEnumerable<Encounter> izzzzzzzy_ = context.Operators.SortBy<Encounter>(izzzzzzzw_, izzzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter izzzzzzzz_ = context.Operators.Last<Encounter>(izzzzzzzy_);
                    Period jzzzzzzza_ = izzzzzzzz_?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzza_);
                    CqlDateTime jzzzzzzzc_ = context.Operators.Start(jzzzzzzzb_);
                    Period jzzzzzzzd_ = Visit?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzd_);
                    CqlDateTime jzzzzzzzf_ = context.Operators.Start(jzzzzzzze_);
                    CqlQuantity jzzzzzzzg_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime jzzzzzzzh_ = context.Operators.Subtract(jzzzzzzzc_ ?? jzzzzzzzf_, jzzzzzzzg_);
                    IEnumerable<Encounter> jzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? jzzzzzzzk_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> lzzzzzzzn_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? lzzzzzzzo_ = lzzzzzzzn_?.Value;
                        Code<Encounter.EncounterStatus> lzzzzzzzp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lzzzzzzzo_);
                        bool? lzzzzzzzq_ = context.Operators.Equal(lzzzzzzzp_, "finished");
                        Period lzzzzzzzr_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> lzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzr_);
                        CqlDateTime lzzzzzzzt_ = context.Operators.End(lzzzzzzzs_);
                        Period lzzzzzzzu_ = Visit?.Period;
                        CqlInterval<CqlDateTime> lzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzu_);
                        CqlDateTime lzzzzzzzw_ = context.Operators.Start(lzzzzzzzv_);
                        CqlQuantity lzzzzzzzx_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime lzzzzzzzy_ = context.Operators.Subtract(lzzzzzzzw_, lzzzzzzzx_);
                        CqlInterval<CqlDateTime> mzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzu_);
                        CqlDateTime mzzzzzzzb_ = context.Operators.Start(mzzzzzzza_);
                        CqlInterval<CqlDateTime> mzzzzzzzc_ = context.Operators.Interval(lzzzzzzzy_, mzzzzzzzb_, true, true);
                        bool? mzzzzzzzd_ = context.Operators.In<CqlDateTime>(lzzzzzzzt_, mzzzzzzzc_, default);
                        CqlInterval<CqlDateTime> mzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzu_);
                        CqlDateTime mzzzzzzzg_ = context.Operators.Start(mzzzzzzzf_);
                        bool? mzzzzzzzh_ = context.Operators.Not((bool?)(mzzzzzzzg_ is null));
                        bool? mzzzzzzzi_ = context.Operators.And(mzzzzzzzd_, mzzzzzzzh_);
                        bool? mzzzzzzzj_ = context.Operators.And(lzzzzzzzq_, mzzzzzzzi_);

                        return mzzzzzzzj_;
                    };
                    IEnumerable<Encounter> jzzzzzzzl_ = context.Operators.Where<Encounter>(jzzzzzzzj_, jzzzzzzzk_);
                    object jzzzzzzzm_(Encounter @this)
                    {
                        Period mzzzzzzzk_ = @this?.Period;
                        CqlInterval<CqlDateTime> mzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzk_);
                        CqlDateTime mzzzzzzzm_ = context.Operators.End(mzzzzzzzl_);

                        return mzzzzzzzm_;
                    };
                    IEnumerable<Encounter> jzzzzzzzn_ = context.Operators.SortBy<Encounter>(jzzzzzzzl_, jzzzzzzzm_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter jzzzzzzzo_ = context.Operators.Last<Encounter>(jzzzzzzzn_);
                    Period jzzzzzzzp_ = jzzzzzzzo_?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzp_);
                    CqlDateTime jzzzzzzzr_ = context.Operators.Start(jzzzzzzzq_);
                    CqlInterval<CqlDateTime> jzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzd_);
                    CqlDateTime jzzzzzzzu_ = context.Operators.Start(jzzzzzzzt_);
                    CqlInterval<CqlDateTime> jzzzzzzzv_ = context.Operators.Interval(jzzzzzzzh_, jzzzzzzzr_ ?? jzzzzzzzu_, true, true);
                    bool? jzzzzzzzw_ = context.Operators.In<CqlDateTime>(izzzzzzzs_, jzzzzzzzv_, default);
                    IEnumerable<Encounter> jzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? jzzzzzzzz_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> mzzzzzzzn_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? mzzzzzzzo_ = mzzzzzzzn_?.Value;
                        Code<Encounter.EncounterStatus> mzzzzzzzp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(mzzzzzzzo_);
                        bool? mzzzzzzzq_ = context.Operators.Equal(mzzzzzzzp_, "finished");
                        Period mzzzzzzzr_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> mzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzr_);
                        CqlDateTime mzzzzzzzt_ = context.Operators.End(mzzzzzzzs_);
                        Period mzzzzzzzu_ = Visit?.Period;
                        CqlInterval<CqlDateTime> mzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzu_);
                        CqlDateTime mzzzzzzzw_ = context.Operators.Start(mzzzzzzzv_);
                        CqlQuantity mzzzzzzzx_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime mzzzzzzzy_ = context.Operators.Subtract(mzzzzzzzw_, mzzzzzzzx_);
                        CqlInterval<CqlDateTime> nzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzu_);
                        CqlDateTime nzzzzzzzb_ = context.Operators.Start(nzzzzzzza_);
                        CqlInterval<CqlDateTime> nzzzzzzzc_ = context.Operators.Interval(mzzzzzzzy_, nzzzzzzzb_, true, true);
                        bool? nzzzzzzzd_ = context.Operators.In<CqlDateTime>(mzzzzzzzt_, nzzzzzzzc_, default);
                        CqlInterval<CqlDateTime> nzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzu_);
                        CqlDateTime nzzzzzzzg_ = context.Operators.Start(nzzzzzzzf_);
                        bool? nzzzzzzzh_ = context.Operators.Not((bool?)(nzzzzzzzg_ is null));
                        bool? nzzzzzzzi_ = context.Operators.And(nzzzzzzzd_, nzzzzzzzh_);
                        bool? nzzzzzzzj_ = context.Operators.And(mzzzzzzzq_, nzzzzzzzi_);

                        return nzzzzzzzj_;
                    };
                    IEnumerable<Encounter> kzzzzzzza_ = context.Operators.Where<Encounter>(jzzzzzzzy_, jzzzzzzzz_);
                    object kzzzzzzzb_(Encounter @this)
                    {
                        Period nzzzzzzzk_ = @this?.Period;
                        CqlInterval<CqlDateTime> nzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzk_);
                        CqlDateTime nzzzzzzzm_ = context.Operators.End(nzzzzzzzl_);

                        return nzzzzzzzm_;
                    };
                    IEnumerable<Encounter> kzzzzzzzc_ = context.Operators.SortBy<Encounter>(kzzzzzzza_, kzzzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter kzzzzzzzd_ = context.Operators.Last<Encounter>(kzzzzzzzc_);
                    Period kzzzzzzze_ = kzzzzzzzd_?.Period;
                    CqlInterval<CqlDateTime> kzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzze_);
                    CqlDateTime kzzzzzzzg_ = context.Operators.Start(kzzzzzzzf_);
                    CqlInterval<CqlDateTime> kzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzd_);
                    CqlDateTime kzzzzzzzj_ = context.Operators.Start(kzzzzzzzi_);
                    bool? kzzzzzzzk_ = context.Operators.Not((bool?)((kzzzzzzzg_ ?? kzzzzzzzj_) is null));
                    bool? kzzzzzzzl_ = context.Operators.And(jzzzzzzzw_, kzzzzzzzk_);
                    bool? kzzzzzzzm_ = context.Operators.And(izzzzzzzp_, kzzzzzzzl_);

                    return kzzzzzzzm_;
                };
                IEnumerable<Encounter> vzzzzzzi_ = context.Operators.Where<Encounter>(vzzzzzzg_, vzzzzzzh_);
                object vzzzzzzj_(Encounter @this)
                {
                    Period nzzzzzzzn_ = @this?.Period;
                    CqlInterval<CqlDateTime> nzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzn_);
                    CqlDateTime nzzzzzzzp_ = context.Operators.End(nzzzzzzzo_);

                    return nzzzzzzzp_;
                };
                IEnumerable<Encounter> vzzzzzzk_ = context.Operators.SortBy<Encounter>(vzzzzzzi_, vzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter vzzzzzzl_ = context.Operators.Last<Encounter>(vzzzzzzk_);
                Period vzzzzzzm_ = vzzzzzzl_?.Period;
                CqlInterval<CqlDateTime> vzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzm_);
                CqlDateTime vzzzzzzo_ = context.Operators.Start(vzzzzzzn_);
                IEnumerable<Encounter> vzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? vzzzzzzr_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> nzzzzzzzq_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? nzzzzzzzr_ = nzzzzzzzq_?.Value;
                    Code<Encounter.EncounterStatus> nzzzzzzzs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(nzzzzzzzr_);
                    bool? nzzzzzzzt_ = context.Operators.Equal(nzzzzzzzs_, "finished");
                    Period nzzzzzzzu_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> nzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzu_);
                    CqlDateTime nzzzzzzzw_ = context.Operators.End(nzzzzzzzv_);
                    Period nzzzzzzzx_ = Visit?.Period;
                    CqlInterval<CqlDateTime> nzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzx_);
                    CqlDateTime nzzzzzzzz_ = context.Operators.Start(nzzzzzzzy_);
                    CqlQuantity ozzzzzzza_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ozzzzzzzb_ = context.Operators.Subtract(nzzzzzzzz_, ozzzzzzza_);
                    CqlInterval<CqlDateTime> ozzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzx_);
                    CqlDateTime ozzzzzzze_ = context.Operators.Start(ozzzzzzzd_);
                    CqlInterval<CqlDateTime> ozzzzzzzf_ = context.Operators.Interval(ozzzzzzzb_, ozzzzzzze_, true, true);
                    bool? ozzzzzzzg_ = context.Operators.In<CqlDateTime>(nzzzzzzzw_, ozzzzzzzf_, default);
                    CqlInterval<CqlDateTime> ozzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzx_);
                    CqlDateTime ozzzzzzzj_ = context.Operators.Start(ozzzzzzzi_);
                    bool? ozzzzzzzk_ = context.Operators.Not((bool?)(ozzzzzzzj_ is null));
                    bool? ozzzzzzzl_ = context.Operators.And(ozzzzzzzg_, ozzzzzzzk_);
                    bool? ozzzzzzzm_ = context.Operators.And(nzzzzzzzt_, ozzzzzzzl_);

                    return ozzzzzzzm_;
                };
                IEnumerable<Encounter> vzzzzzzs_ = context.Operators.Where<Encounter>(vzzzzzzq_, vzzzzzzr_);
                object vzzzzzzt_(Encounter @this)
                {
                    Period ozzzzzzzn_ = @this?.Period;
                    CqlInterval<CqlDateTime> ozzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzn_);
                    CqlDateTime ozzzzzzzp_ = context.Operators.End(ozzzzzzzo_);

                    return ozzzzzzzp_;
                };
                IEnumerable<Encounter> vzzzzzzu_ = context.Operators.SortBy<Encounter>(vzzzzzzs_, vzzzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter vzzzzzzv_ = context.Operators.Last<Encounter>(vzzzzzzu_);
                Period vzzzzzzw_ = vzzzzzzv_?.Period;
                CqlInterval<CqlDateTime> vzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzw_);
                CqlDateTime vzzzzzzy_ = context.Operators.Start(vzzzzzzx_);
                CqlInterval<CqlDateTime> wzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzb_);
                CqlDateTime wzzzzzzb_ = context.Operators.Start(wzzzzzza_);
                bool? wzzzzzzc_ = context.Operators.Not((bool?)((vzzzzzzo_ ?? vzzzzzzy_ ?? wzzzzzzb_) is null));
                bool? wzzzzzzd_ = context.Operators.And(vzzzzzze_, wzzzzzzc_);

                return wzzzzzzd_;
            };
            IEnumerable<Encounter> rzzzzzzw_ = context.Operators.Where<Encounter>(rzzzzzzu_, rzzzzzzv_);
            object rzzzzzzx_(Encounter @this)
            {
                Period ozzzzzzzq_ = @this?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzq_);
                CqlDateTime ozzzzzzzs_ = context.Operators.End(ozzzzzzzr_);

                return ozzzzzzzs_;
            };
            IEnumerable<Encounter> rzzzzzzy_ = context.Operators.SortBy<Encounter>(rzzzzzzw_, rzzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter rzzzzzzz_ = context.Operators.Last<Encounter>(rzzzzzzy_);
            Period szzzzzza_ = rzzzzzzz_?.Period;
            CqlInterval<CqlDateTime> szzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzza_);
            CqlDateTime szzzzzzc_ = context.Operators.Start(szzzzzzb_);
            CqlValueSet szzzzzzd_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> szzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? szzzzzzf_(Encounter LastED)
            {
                Code<Encounter.EncounterStatus> ozzzzzzzt_ = LastED?.StatusElement;
                Encounter.EncounterStatus? ozzzzzzzu_ = ozzzzzzzt_?.Value;
                Code<Encounter.EncounterStatus> ozzzzzzzv_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ozzzzzzzu_);
                bool? ozzzzzzzw_ = context.Operators.Equal(ozzzzzzzv_, "finished");
                Period ozzzzzzzx_ = LastED?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzx_);
                CqlDateTime ozzzzzzzz_ = context.Operators.End(ozzzzzzzy_);
                CqlValueSet pzzzzzzza_ = this.Observation_Services(context);
                IEnumerable<Encounter> pzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? pzzzzzzzc_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> qzzzzzzzu_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? qzzzzzzzv_ = qzzzzzzzu_?.Value;
                    Code<Encounter.EncounterStatus> qzzzzzzzw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(qzzzzzzzv_);
                    bool? qzzzzzzzx_ = context.Operators.Equal(qzzzzzzzw_, "finished");
                    Period qzzzzzzzy_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> qzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzy_);
                    CqlDateTime rzzzzzzza_ = context.Operators.End(qzzzzzzzz_);
                    Period rzzzzzzzb_ = Visit?.Period;
                    CqlInterval<CqlDateTime> rzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzb_);
                    CqlDateTime rzzzzzzzd_ = context.Operators.Start(rzzzzzzzc_);
                    CqlQuantity rzzzzzzze_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime rzzzzzzzf_ = context.Operators.Subtract(rzzzzzzzd_, rzzzzzzze_);
                    CqlInterval<CqlDateTime> rzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzb_);
                    CqlDateTime rzzzzzzzi_ = context.Operators.Start(rzzzzzzzh_);
                    CqlInterval<CqlDateTime> rzzzzzzzj_ = context.Operators.Interval(rzzzzzzzf_, rzzzzzzzi_, true, true);
                    bool? rzzzzzzzk_ = context.Operators.In<CqlDateTime>(rzzzzzzza_, rzzzzzzzj_, default);
                    CqlInterval<CqlDateTime> rzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzb_);
                    CqlDateTime rzzzzzzzn_ = context.Operators.Start(rzzzzzzzm_);
                    bool? rzzzzzzzo_ = context.Operators.Not((bool?)(rzzzzzzzn_ is null));
                    bool? rzzzzzzzp_ = context.Operators.And(rzzzzzzzk_, rzzzzzzzo_);
                    bool? rzzzzzzzq_ = context.Operators.And(qzzzzzzzx_, rzzzzzzzp_);

                    return rzzzzzzzq_;
                };
                IEnumerable<Encounter> pzzzzzzzd_ = context.Operators.Where<Encounter>(pzzzzzzzb_, pzzzzzzzc_);
                object pzzzzzzze_(Encounter @this)
                {
                    Period rzzzzzzzr_ = @this?.Period;
                    CqlInterval<CqlDateTime> rzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzr_);
                    CqlDateTime rzzzzzzzt_ = context.Operators.End(rzzzzzzzs_);

                    return rzzzzzzzt_;
                };
                IEnumerable<Encounter> pzzzzzzzf_ = context.Operators.SortBy<Encounter>(pzzzzzzzd_, pzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter pzzzzzzzg_ = context.Operators.Last<Encounter>(pzzzzzzzf_);
                Period pzzzzzzzh_ = pzzzzzzzg_?.Period;
                CqlInterval<CqlDateTime> pzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzh_);
                CqlDateTime pzzzzzzzj_ = context.Operators.Start(pzzzzzzzi_);
                Period pzzzzzzzk_ = Visit?.Period;
                CqlInterval<CqlDateTime> pzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzk_);
                CqlDateTime pzzzzzzzm_ = context.Operators.Start(pzzzzzzzl_);
                CqlQuantity pzzzzzzzn_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime pzzzzzzzo_ = context.Operators.Subtract(pzzzzzzzj_ ?? pzzzzzzzm_, pzzzzzzzn_);
                IEnumerable<Encounter> pzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? pzzzzzzzr_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> rzzzzzzzu_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? rzzzzzzzv_ = rzzzzzzzu_?.Value;
                    Code<Encounter.EncounterStatus> rzzzzzzzw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rzzzzzzzv_);
                    bool? rzzzzzzzx_ = context.Operators.Equal(rzzzzzzzw_, "finished");
                    Period rzzzzzzzy_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> rzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzy_);
                    CqlDateTime szzzzzzza_ = context.Operators.End(rzzzzzzzz_);
                    Period szzzzzzzb_ = Visit?.Period;
                    CqlInterval<CqlDateTime> szzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzb_);
                    CqlDateTime szzzzzzzd_ = context.Operators.Start(szzzzzzzc_);
                    CqlQuantity szzzzzzze_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime szzzzzzzf_ = context.Operators.Subtract(szzzzzzzd_, szzzzzzze_);
                    CqlInterval<CqlDateTime> szzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzb_);
                    CqlDateTime szzzzzzzi_ = context.Operators.Start(szzzzzzzh_);
                    CqlInterval<CqlDateTime> szzzzzzzj_ = context.Operators.Interval(szzzzzzzf_, szzzzzzzi_, true, true);
                    bool? szzzzzzzk_ = context.Operators.In<CqlDateTime>(szzzzzzza_, szzzzzzzj_, default);
                    CqlInterval<CqlDateTime> szzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzb_);
                    CqlDateTime szzzzzzzn_ = context.Operators.Start(szzzzzzzm_);
                    bool? szzzzzzzo_ = context.Operators.Not((bool?)(szzzzzzzn_ is null));
                    bool? szzzzzzzp_ = context.Operators.And(szzzzzzzk_, szzzzzzzo_);
                    bool? szzzzzzzq_ = context.Operators.And(rzzzzzzzx_, szzzzzzzp_);

                    return szzzzzzzq_;
                };
                IEnumerable<Encounter> pzzzzzzzs_ = context.Operators.Where<Encounter>(pzzzzzzzq_, pzzzzzzzr_);
                object pzzzzzzzt_(Encounter @this)
                {
                    Period szzzzzzzr_ = @this?.Period;
                    CqlInterval<CqlDateTime> szzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzr_);
                    CqlDateTime szzzzzzzt_ = context.Operators.End(szzzzzzzs_);

                    return szzzzzzzt_;
                };
                IEnumerable<Encounter> pzzzzzzzu_ = context.Operators.SortBy<Encounter>(pzzzzzzzs_, pzzzzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter pzzzzzzzv_ = context.Operators.Last<Encounter>(pzzzzzzzu_);
                Period pzzzzzzzw_ = pzzzzzzzv_?.Period;
                CqlInterval<CqlDateTime> pzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzw_);
                CqlDateTime pzzzzzzzy_ = context.Operators.Start(pzzzzzzzx_);
                CqlInterval<CqlDateTime> qzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzk_);
                CqlDateTime qzzzzzzzb_ = context.Operators.Start(qzzzzzzza_);
                CqlInterval<CqlDateTime> qzzzzzzzc_ = context.Operators.Interval(pzzzzzzzo_, pzzzzzzzy_ ?? qzzzzzzzb_, true, true);
                bool? qzzzzzzzd_ = context.Operators.In<CqlDateTime>(ozzzzzzzz_, qzzzzzzzc_, default);
                IEnumerable<Encounter> qzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? qzzzzzzzg_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> szzzzzzzu_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? szzzzzzzv_ = szzzzzzzu_?.Value;
                    Code<Encounter.EncounterStatus> szzzzzzzw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(szzzzzzzv_);
                    bool? szzzzzzzx_ = context.Operators.Equal(szzzzzzzw_, "finished");
                    Period szzzzzzzy_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> szzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzy_);
                    CqlDateTime tzzzzzzza_ = context.Operators.End(szzzzzzzz_);
                    Period tzzzzzzzb_ = Visit?.Period;
                    CqlInterval<CqlDateTime> tzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzb_);
                    CqlDateTime tzzzzzzzd_ = context.Operators.Start(tzzzzzzzc_);
                    CqlQuantity tzzzzzzze_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime tzzzzzzzf_ = context.Operators.Subtract(tzzzzzzzd_, tzzzzzzze_);
                    CqlInterval<CqlDateTime> tzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzb_);
                    CqlDateTime tzzzzzzzi_ = context.Operators.Start(tzzzzzzzh_);
                    CqlInterval<CqlDateTime> tzzzzzzzj_ = context.Operators.Interval(tzzzzzzzf_, tzzzzzzzi_, true, true);
                    bool? tzzzzzzzk_ = context.Operators.In<CqlDateTime>(tzzzzzzza_, tzzzzzzzj_, default);
                    CqlInterval<CqlDateTime> tzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzb_);
                    CqlDateTime tzzzzzzzn_ = context.Operators.Start(tzzzzzzzm_);
                    bool? tzzzzzzzo_ = context.Operators.Not((bool?)(tzzzzzzzn_ is null));
                    bool? tzzzzzzzp_ = context.Operators.And(tzzzzzzzk_, tzzzzzzzo_);
                    bool? tzzzzzzzq_ = context.Operators.And(szzzzzzzx_, tzzzzzzzp_);

                    return tzzzzzzzq_;
                };
                IEnumerable<Encounter> qzzzzzzzh_ = context.Operators.Where<Encounter>(qzzzzzzzf_, qzzzzzzzg_);
                object qzzzzzzzi_(Encounter @this)
                {
                    Period tzzzzzzzr_ = @this?.Period;
                    CqlInterval<CqlDateTime> tzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzr_);
                    CqlDateTime tzzzzzzzt_ = context.Operators.End(tzzzzzzzs_);

                    return tzzzzzzzt_;
                };
                IEnumerable<Encounter> qzzzzzzzj_ = context.Operators.SortBy<Encounter>(qzzzzzzzh_, qzzzzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter qzzzzzzzk_ = context.Operators.Last<Encounter>(qzzzzzzzj_);
                Period qzzzzzzzl_ = qzzzzzzzk_?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzl_);
                CqlDateTime qzzzzzzzn_ = context.Operators.Start(qzzzzzzzm_);
                CqlInterval<CqlDateTime> qzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzk_);
                CqlDateTime qzzzzzzzq_ = context.Operators.Start(qzzzzzzzp_);
                bool? qzzzzzzzr_ = context.Operators.Not((bool?)((qzzzzzzzn_ ?? qzzzzzzzq_) is null));
                bool? qzzzzzzzs_ = context.Operators.And(qzzzzzzzd_, qzzzzzzzr_);
                bool? qzzzzzzzt_ = context.Operators.And(ozzzzzzzw_, qzzzzzzzs_);

                return qzzzzzzzt_;
            };
            IEnumerable<Encounter> szzzzzzg_ = context.Operators.Where<Encounter>(szzzzzze_, szzzzzzf_);
            object szzzzzzh_(Encounter @this)
            {
                Period tzzzzzzzu_ = @this?.Period;
                CqlInterval<CqlDateTime> tzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzu_);
                CqlDateTime tzzzzzzzw_ = context.Operators.End(tzzzzzzzv_);

                return tzzzzzzzw_;
            };
            IEnumerable<Encounter> szzzzzzi_ = context.Operators.SortBy<Encounter>(szzzzzzg_, szzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter szzzzzzj_ = context.Operators.Last<Encounter>(szzzzzzi_);
            Period szzzzzzk_ = szzzzzzj_?.Period;
            CqlInterval<CqlDateTime> szzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzk_);
            CqlDateTime szzzzzzm_ = context.Operators.Start(szzzzzzl_);
            CqlValueSet szzzzzzn_ = this.Observation_Services(context);
            IEnumerable<Encounter> szzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? szzzzzzp_(Encounter LastObs)
            {
                Code<Encounter.EncounterStatus> tzzzzzzzx_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? tzzzzzzzy_ = tzzzzzzzx_?.Value;
                Code<Encounter.EncounterStatus> tzzzzzzzz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(tzzzzzzzy_);
                bool? uzzzzzzza_ = context.Operators.Equal(tzzzzzzzz_, "finished");
                Period uzzzzzzzb_ = LastObs?.Period;
                CqlInterval<CqlDateTime> uzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzb_);
                CqlDateTime uzzzzzzzd_ = context.Operators.End(uzzzzzzzc_);
                Period uzzzzzzze_ = Visit?.Period;
                CqlInterval<CqlDateTime> uzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzze_);
                CqlDateTime uzzzzzzzg_ = context.Operators.Start(uzzzzzzzf_);
                CqlQuantity uzzzzzzzh_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime uzzzzzzzi_ = context.Operators.Subtract(uzzzzzzzg_, uzzzzzzzh_);
                CqlInterval<CqlDateTime> uzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzze_);
                CqlDateTime uzzzzzzzl_ = context.Operators.Start(uzzzzzzzk_);
                CqlInterval<CqlDateTime> uzzzzzzzm_ = context.Operators.Interval(uzzzzzzzi_, uzzzzzzzl_, true, true);
                bool? uzzzzzzzn_ = context.Operators.In<CqlDateTime>(uzzzzzzzd_, uzzzzzzzm_, default);
                CqlInterval<CqlDateTime> uzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzze_);
                CqlDateTime uzzzzzzzq_ = context.Operators.Start(uzzzzzzzp_);
                bool? uzzzzzzzr_ = context.Operators.Not((bool?)(uzzzzzzzq_ is null));
                bool? uzzzzzzzs_ = context.Operators.And(uzzzzzzzn_, uzzzzzzzr_);
                bool? uzzzzzzzt_ = context.Operators.And(uzzzzzzza_, uzzzzzzzs_);

                return uzzzzzzzt_;
            };
            IEnumerable<Encounter> szzzzzzq_ = context.Operators.Where<Encounter>(szzzzzzo_, szzzzzzp_);
            object szzzzzzr_(Encounter @this)
            {
                Period uzzzzzzzu_ = @this?.Period;
                CqlInterval<CqlDateTime> uzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzu_);
                CqlDateTime uzzzzzzzw_ = context.Operators.End(uzzzzzzzv_);

                return uzzzzzzzw_;
            };
            IEnumerable<Encounter> szzzzzzs_ = context.Operators.SortBy<Encounter>(szzzzzzq_, szzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter szzzzzzt_ = context.Operators.Last<Encounter>(szzzzzzs_);
            Period szzzzzzu_ = szzzzzzt_?.Period;
            CqlInterval<CqlDateTime> szzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzu_);
            CqlDateTime szzzzzzw_ = context.Operators.Start(szzzzzzv_);
            Period szzzzzzx_ = Visit?.Period;
            CqlInterval<CqlDateTime> szzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzx_);
            CqlDateTime szzzzzzz_ = context.Operators.Start(szzzzzzy_);
            CqlInterval<CqlDateTime> tzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzx_);
            CqlDateTime tzzzzzzc_ = context.Operators.End(tzzzzzzb_);
            CqlInterval<CqlDateTime> tzzzzzzd_ = context.Operators.Interval(szzzzzzc_ ?? szzzzzzm_ ?? szzzzzzw_ ?? szzzzzzz_, tzzzzzzc_, true, true);

            return tzzzzzzd_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> rzzzzzzq_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)rzzzzzzo_, rzzzzzzp_);
        IEnumerable<CqlInterval<CqlDateTime>> rzzzzzzr_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(rzzzzzzq_);
        CqlInterval<CqlDateTime> rzzzzzzs_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(rzzzzzzr_);

        return rzzzzzzs_;
    }


    [CqlExpressionDefinition("hospitalizationWithObservationAndOutpatientSurgeryService")]
    [CqlTag("description", "Hospitalization with Observation and Outpatient Surgery Service returns the total interval from the start of any immediately prior emergency department visit, outpatient surgery visit or observation visit to the discharge of the given encounter.")]
    public CqlInterval<CqlDateTime> hospitalizationWithObservationAndOutpatientSurgeryService(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] uzzzzzzzx_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> uzzzzzzzy_(Encounter Visit)
        {
            CqlValueSet vzzzzzzzc_ = this.Outpatient_Surgery_Service(context);
            IEnumerable<Encounter> vzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? vzzzzzzze_(Encounter LastSurgeryOP)
            {
                Period wzzzzzzzn_ = LastSurgeryOP?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzn_);
                CqlDateTime wzzzzzzzp_ = context.Operators.End(wzzzzzzzo_);
                CqlValueSet wzzzzzzzq_ = this.Emergency_Department_Visit(context);
                IEnumerable<Encounter> wzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? wzzzzzzzs_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> zzzzzzzzn_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? zzzzzzzzo_ = zzzzzzzzn_?.Value;
                    Code<Encounter.EncounterStatus> zzzzzzzzp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(zzzzzzzzo_);
                    bool? zzzzzzzzq_ = context.Operators.Equal(zzzzzzzzp_, "finished");
                    Period zzzzzzzzr_ = LastED?.Period;
                    CqlInterval<CqlDateTime> zzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzr_);
                    CqlDateTime zzzzzzzzt_ = context.Operators.End(zzzzzzzzs_);
                    CqlValueSet zzzzzzzzu_ = this.Observation_Services(context);
                    IEnumerable<Encounter> zzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? zzzzzzzzw_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> bzzzzzzzzo_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? bzzzzzzzzp_ = bzzzzzzzzo_?.Value;
                        Code<Encounter.EncounterStatus> bzzzzzzzzq_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bzzzzzzzzp_);
                        bool? bzzzzzzzzr_ = context.Operators.Equal(bzzzzzzzzq_, "finished");
                        Period bzzzzzzzzs_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> bzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzs_);
                        CqlDateTime bzzzzzzzzu_ = context.Operators.End(bzzzzzzzzt_);
                        Period bzzzzzzzzv_ = Visit?.Period;
                        CqlInterval<CqlDateTime> bzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzv_);
                        CqlDateTime bzzzzzzzzx_ = context.Operators.Start(bzzzzzzzzw_);
                        CqlQuantity bzzzzzzzzy_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime bzzzzzzzzz_ = context.Operators.Subtract(bzzzzzzzzx_, bzzzzzzzzy_);
                        CqlInterval<CqlDateTime> czzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzv_);
                        CqlDateTime czzzzzzzzc_ = context.Operators.Start(czzzzzzzzb_);
                        CqlInterval<CqlDateTime> czzzzzzzzd_ = context.Operators.Interval(bzzzzzzzzz_, czzzzzzzzc_, true, true);
                        bool? czzzzzzzze_ = context.Operators.In<CqlDateTime>(bzzzzzzzzu_, czzzzzzzzd_, default);
                        CqlInterval<CqlDateTime> czzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzv_);
                        CqlDateTime czzzzzzzzh_ = context.Operators.Start(czzzzzzzzg_);
                        bool? czzzzzzzzi_ = context.Operators.Not((bool?)(czzzzzzzzh_ is null));
                        bool? czzzzzzzzj_ = context.Operators.And(czzzzzzzze_, czzzzzzzzi_);
                        bool? czzzzzzzzk_ = context.Operators.And(bzzzzzzzzr_, czzzzzzzzj_);

                        return czzzzzzzzk_;
                    };
                    IEnumerable<Encounter> zzzzzzzzx_ = context.Operators.Where<Encounter>(zzzzzzzzv_, zzzzzzzzw_);
                    object zzzzzzzzy_(Encounter @this)
                    {
                        Period czzzzzzzzl_ = @this?.Period;
                        CqlInterval<CqlDateTime> czzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzl_);
                        CqlDateTime czzzzzzzzn_ = context.Operators.End(czzzzzzzzm_);

                        return czzzzzzzzn_;
                    };
                    IEnumerable<Encounter> zzzzzzzzz_ = context.Operators.SortBy<Encounter>(zzzzzzzzx_, zzzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter azzzzzzzza_ = context.Operators.Last<Encounter>(zzzzzzzzz_);
                    Period azzzzzzzzb_ = azzzzzzzza_?.Period;
                    CqlInterval<CqlDateTime> azzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzb_);
                    CqlDateTime azzzzzzzzd_ = context.Operators.Start(azzzzzzzzc_);
                    Period azzzzzzzze_ = Visit?.Period;
                    CqlInterval<CqlDateTime> azzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzze_);
                    CqlDateTime azzzzzzzzg_ = context.Operators.Start(azzzzzzzzf_);
                    CqlQuantity azzzzzzzzh_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime azzzzzzzzi_ = context.Operators.Subtract(azzzzzzzzd_ ?? azzzzzzzzg_, azzzzzzzzh_);
                    IEnumerable<Encounter> azzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? azzzzzzzzl_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> czzzzzzzzo_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? czzzzzzzzp_ = czzzzzzzzo_?.Value;
                        Code<Encounter.EncounterStatus> czzzzzzzzq_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(czzzzzzzzp_);
                        bool? czzzzzzzzr_ = context.Operators.Equal(czzzzzzzzq_, "finished");
                        Period czzzzzzzzs_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> czzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzs_);
                        CqlDateTime czzzzzzzzu_ = context.Operators.End(czzzzzzzzt_);
                        Period czzzzzzzzv_ = Visit?.Period;
                        CqlInterval<CqlDateTime> czzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzv_);
                        CqlDateTime czzzzzzzzx_ = context.Operators.Start(czzzzzzzzw_);
                        CqlQuantity czzzzzzzzy_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime czzzzzzzzz_ = context.Operators.Subtract(czzzzzzzzx_, czzzzzzzzy_);
                        CqlInterval<CqlDateTime> dzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzv_);
                        CqlDateTime dzzzzzzzzc_ = context.Operators.Start(dzzzzzzzzb_);
                        CqlInterval<CqlDateTime> dzzzzzzzzd_ = context.Operators.Interval(czzzzzzzzz_, dzzzzzzzzc_, true, true);
                        bool? dzzzzzzzze_ = context.Operators.In<CqlDateTime>(czzzzzzzzu_, dzzzzzzzzd_, default);
                        CqlInterval<CqlDateTime> dzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzv_);
                        CqlDateTime dzzzzzzzzh_ = context.Operators.Start(dzzzzzzzzg_);
                        bool? dzzzzzzzzi_ = context.Operators.Not((bool?)(dzzzzzzzzh_ is null));
                        bool? dzzzzzzzzj_ = context.Operators.And(dzzzzzzzze_, dzzzzzzzzi_);
                        bool? dzzzzzzzzk_ = context.Operators.And(czzzzzzzzr_, dzzzzzzzzj_);

                        return dzzzzzzzzk_;
                    };
                    IEnumerable<Encounter> azzzzzzzzm_ = context.Operators.Where<Encounter>(azzzzzzzzk_, azzzzzzzzl_);
                    object azzzzzzzzn_(Encounter @this)
                    {
                        Period dzzzzzzzzl_ = @this?.Period;
                        CqlInterval<CqlDateTime> dzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzl_);
                        CqlDateTime dzzzzzzzzn_ = context.Operators.End(dzzzzzzzzm_);

                        return dzzzzzzzzn_;
                    };
                    IEnumerable<Encounter> azzzzzzzzo_ = context.Operators.SortBy<Encounter>(azzzzzzzzm_, azzzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter azzzzzzzzp_ = context.Operators.Last<Encounter>(azzzzzzzzo_);
                    Period azzzzzzzzq_ = azzzzzzzzp_?.Period;
                    CqlInterval<CqlDateTime> azzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzq_);
                    CqlDateTime azzzzzzzzs_ = context.Operators.Start(azzzzzzzzr_);
                    CqlInterval<CqlDateTime> azzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzze_);
                    CqlDateTime azzzzzzzzv_ = context.Operators.Start(azzzzzzzzu_);
                    CqlInterval<CqlDateTime> azzzzzzzzw_ = context.Operators.Interval(azzzzzzzzi_, azzzzzzzzs_ ?? azzzzzzzzv_, true, true);
                    bool? azzzzzzzzx_ = context.Operators.In<CqlDateTime>(zzzzzzzzt_, azzzzzzzzw_, default);
                    IEnumerable<Encounter> azzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? bzzzzzzzza_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> dzzzzzzzzo_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? dzzzzzzzzp_ = dzzzzzzzzo_?.Value;
                        Code<Encounter.EncounterStatus> dzzzzzzzzq_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dzzzzzzzzp_);
                        bool? dzzzzzzzzr_ = context.Operators.Equal(dzzzzzzzzq_, "finished");
                        Period dzzzzzzzzs_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> dzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzs_);
                        CqlDateTime dzzzzzzzzu_ = context.Operators.End(dzzzzzzzzt_);
                        Period dzzzzzzzzv_ = Visit?.Period;
                        CqlInterval<CqlDateTime> dzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzv_);
                        CqlDateTime dzzzzzzzzx_ = context.Operators.Start(dzzzzzzzzw_);
                        CqlQuantity dzzzzzzzzy_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime dzzzzzzzzz_ = context.Operators.Subtract(dzzzzzzzzx_, dzzzzzzzzy_);
                        CqlInterval<CqlDateTime> ezzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzv_);
                        CqlDateTime ezzzzzzzzc_ = context.Operators.Start(ezzzzzzzzb_);
                        CqlInterval<CqlDateTime> ezzzzzzzzd_ = context.Operators.Interval(dzzzzzzzzz_, ezzzzzzzzc_, true, true);
                        bool? ezzzzzzzze_ = context.Operators.In<CqlDateTime>(dzzzzzzzzu_, ezzzzzzzzd_, default);
                        CqlInterval<CqlDateTime> ezzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzv_);
                        CqlDateTime ezzzzzzzzh_ = context.Operators.Start(ezzzzzzzzg_);
                        bool? ezzzzzzzzi_ = context.Operators.Not((bool?)(ezzzzzzzzh_ is null));
                        bool? ezzzzzzzzj_ = context.Operators.And(ezzzzzzzze_, ezzzzzzzzi_);
                        bool? ezzzzzzzzk_ = context.Operators.And(dzzzzzzzzr_, ezzzzzzzzj_);

                        return ezzzzzzzzk_;
                    };
                    IEnumerable<Encounter> bzzzzzzzzb_ = context.Operators.Where<Encounter>(azzzzzzzzz_, bzzzzzzzza_);
                    object bzzzzzzzzc_(Encounter @this)
                    {
                        Period ezzzzzzzzl_ = @this?.Period;
                        CqlInterval<CqlDateTime> ezzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzl_);
                        CqlDateTime ezzzzzzzzn_ = context.Operators.End(ezzzzzzzzm_);

                        return ezzzzzzzzn_;
                    };
                    IEnumerable<Encounter> bzzzzzzzzd_ = context.Operators.SortBy<Encounter>(bzzzzzzzzb_, bzzzzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter bzzzzzzzze_ = context.Operators.Last<Encounter>(bzzzzzzzzd_);
                    Period bzzzzzzzzf_ = bzzzzzzzze_?.Period;
                    CqlInterval<CqlDateTime> bzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzf_);
                    CqlDateTime bzzzzzzzzh_ = context.Operators.Start(bzzzzzzzzg_);
                    CqlInterval<CqlDateTime> bzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzze_);
                    CqlDateTime bzzzzzzzzk_ = context.Operators.Start(bzzzzzzzzj_);
                    bool? bzzzzzzzzl_ = context.Operators.Not((bool?)((bzzzzzzzzh_ ?? bzzzzzzzzk_) is null));
                    bool? bzzzzzzzzm_ = context.Operators.And(azzzzzzzzx_, bzzzzzzzzl_);
                    bool? bzzzzzzzzn_ = context.Operators.And(zzzzzzzzq_, bzzzzzzzzm_);

                    return bzzzzzzzzn_;
                };
                IEnumerable<Encounter> wzzzzzzzt_ = context.Operators.Where<Encounter>(wzzzzzzzr_, wzzzzzzzs_);
                object wzzzzzzzu_(Encounter @this)
                {
                    Period ezzzzzzzzo_ = @this?.Period;
                    CqlInterval<CqlDateTime> ezzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzo_);
                    CqlDateTime ezzzzzzzzq_ = context.Operators.End(ezzzzzzzzp_);

                    return ezzzzzzzzq_;
                };
                IEnumerable<Encounter> wzzzzzzzv_ = context.Operators.SortBy<Encounter>(wzzzzzzzt_, wzzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter wzzzzzzzw_ = context.Operators.Last<Encounter>(wzzzzzzzv_);
                Period wzzzzzzzx_ = wzzzzzzzw_?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzx_);
                CqlDateTime wzzzzzzzz_ = context.Operators.Start(wzzzzzzzy_);
                CqlValueSet xzzzzzzza_ = this.Observation_Services(context);
                IEnumerable<Encounter> xzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? xzzzzzzzc_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> ezzzzzzzzr_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? ezzzzzzzzs_ = ezzzzzzzzr_?.Value;
                    Code<Encounter.EncounterStatus> ezzzzzzzzt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ezzzzzzzzs_);
                    bool? ezzzzzzzzu_ = context.Operators.Equal(ezzzzzzzzt_, "finished");
                    Period ezzzzzzzzv_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> ezzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzv_);
                    CqlDateTime ezzzzzzzzx_ = context.Operators.End(ezzzzzzzzw_);
                    Period ezzzzzzzzy_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ezzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzy_);
                    CqlDateTime fzzzzzzzza_ = context.Operators.Start(ezzzzzzzzz_);
                    CqlQuantity fzzzzzzzzb_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime fzzzzzzzzc_ = context.Operators.Subtract(fzzzzzzzza_, fzzzzzzzzb_);
                    CqlInterval<CqlDateTime> fzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzy_);
                    CqlDateTime fzzzzzzzzf_ = context.Operators.Start(fzzzzzzzze_);
                    CqlInterval<CqlDateTime> fzzzzzzzzg_ = context.Operators.Interval(fzzzzzzzzc_, fzzzzzzzzf_, true, true);
                    bool? fzzzzzzzzh_ = context.Operators.In<CqlDateTime>(ezzzzzzzzx_, fzzzzzzzzg_, default);
                    CqlInterval<CqlDateTime> fzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzy_);
                    CqlDateTime fzzzzzzzzk_ = context.Operators.Start(fzzzzzzzzj_);
                    bool? fzzzzzzzzl_ = context.Operators.Not((bool?)(fzzzzzzzzk_ is null));
                    bool? fzzzzzzzzm_ = context.Operators.And(fzzzzzzzzh_, fzzzzzzzzl_);
                    bool? fzzzzzzzzn_ = context.Operators.And(ezzzzzzzzu_, fzzzzzzzzm_);

                    return fzzzzzzzzn_;
                };
                IEnumerable<Encounter> xzzzzzzzd_ = context.Operators.Where<Encounter>(xzzzzzzzb_, xzzzzzzzc_);
                object xzzzzzzze_(Encounter @this)
                {
                    Period fzzzzzzzzo_ = @this?.Period;
                    CqlInterval<CqlDateTime> fzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzo_);
                    CqlDateTime fzzzzzzzzq_ = context.Operators.End(fzzzzzzzzp_);

                    return fzzzzzzzzq_;
                };
                IEnumerable<Encounter> xzzzzzzzf_ = context.Operators.SortBy<Encounter>(xzzzzzzzd_, xzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter xzzzzzzzg_ = context.Operators.Last<Encounter>(xzzzzzzzf_);
                Period xzzzzzzzh_ = xzzzzzzzg_?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzh_);
                CqlDateTime xzzzzzzzj_ = context.Operators.Start(xzzzzzzzi_);
                Period xzzzzzzzk_ = Visit?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzk_);
                CqlDateTime xzzzzzzzm_ = context.Operators.Start(xzzzzzzzl_);
                CqlQuantity xzzzzzzzn_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime xzzzzzzzo_ = context.Operators.Subtract(wzzzzzzzz_ ?? xzzzzzzzj_ ?? xzzzzzzzm_, xzzzzzzzn_);
                IEnumerable<Encounter> xzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? xzzzzzzzr_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> fzzzzzzzzr_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? fzzzzzzzzs_ = fzzzzzzzzr_?.Value;
                    Code<Encounter.EncounterStatus> fzzzzzzzzt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fzzzzzzzzs_);
                    bool? fzzzzzzzzu_ = context.Operators.Equal(fzzzzzzzzt_, "finished");
                    Period fzzzzzzzzv_ = LastED?.Period;
                    CqlInterval<CqlDateTime> fzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzv_);
                    CqlDateTime fzzzzzzzzx_ = context.Operators.End(fzzzzzzzzw_);
                    CqlValueSet fzzzzzzzzy_ = this.Observation_Services(context);
                    IEnumerable<Encounter> fzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? gzzzzzzzza_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> hzzzzzzzzs_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? hzzzzzzzzt_ = hzzzzzzzzs_?.Value;
                        Code<Encounter.EncounterStatus> hzzzzzzzzu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hzzzzzzzzt_);
                        bool? hzzzzzzzzv_ = context.Operators.Equal(hzzzzzzzzu_, "finished");
                        Period hzzzzzzzzw_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> hzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzw_);
                        CqlDateTime hzzzzzzzzy_ = context.Operators.End(hzzzzzzzzx_);
                        Period hzzzzzzzzz_ = Visit?.Period;
                        CqlInterval<CqlDateTime> izzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzz_);
                        CqlDateTime izzzzzzzzb_ = context.Operators.Start(izzzzzzzza_);
                        CqlQuantity izzzzzzzzc_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime izzzzzzzzd_ = context.Operators.Subtract(izzzzzzzzb_, izzzzzzzzc_);
                        CqlInterval<CqlDateTime> izzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzz_);
                        CqlDateTime izzzzzzzzg_ = context.Operators.Start(izzzzzzzzf_);
                        CqlInterval<CqlDateTime> izzzzzzzzh_ = context.Operators.Interval(izzzzzzzzd_, izzzzzzzzg_, true, true);
                        bool? izzzzzzzzi_ = context.Operators.In<CqlDateTime>(hzzzzzzzzy_, izzzzzzzzh_, default);
                        CqlInterval<CqlDateTime> izzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzz_);
                        CqlDateTime izzzzzzzzl_ = context.Operators.Start(izzzzzzzzk_);
                        bool? izzzzzzzzm_ = context.Operators.Not((bool?)(izzzzzzzzl_ is null));
                        bool? izzzzzzzzn_ = context.Operators.And(izzzzzzzzi_, izzzzzzzzm_);
                        bool? izzzzzzzzo_ = context.Operators.And(hzzzzzzzzv_, izzzzzzzzn_);

                        return izzzzzzzzo_;
                    };
                    IEnumerable<Encounter> gzzzzzzzzb_ = context.Operators.Where<Encounter>(fzzzzzzzzz_, gzzzzzzzza_);
                    object gzzzzzzzzc_(Encounter @this)
                    {
                        Period izzzzzzzzp_ = @this?.Period;
                        CqlInterval<CqlDateTime> izzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzp_);
                        CqlDateTime izzzzzzzzr_ = context.Operators.End(izzzzzzzzq_);

                        return izzzzzzzzr_;
                    };
                    IEnumerable<Encounter> gzzzzzzzzd_ = context.Operators.SortBy<Encounter>(gzzzzzzzzb_, gzzzzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter gzzzzzzzze_ = context.Operators.Last<Encounter>(gzzzzzzzzd_);
                    Period gzzzzzzzzf_ = gzzzzzzzze_?.Period;
                    CqlInterval<CqlDateTime> gzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzf_);
                    CqlDateTime gzzzzzzzzh_ = context.Operators.Start(gzzzzzzzzg_);
                    Period gzzzzzzzzi_ = Visit?.Period;
                    CqlInterval<CqlDateTime> gzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzi_);
                    CqlDateTime gzzzzzzzzk_ = context.Operators.Start(gzzzzzzzzj_);
                    CqlQuantity gzzzzzzzzl_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime gzzzzzzzzm_ = context.Operators.Subtract(gzzzzzzzzh_ ?? gzzzzzzzzk_, gzzzzzzzzl_);
                    IEnumerable<Encounter> gzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? gzzzzzzzzp_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> izzzzzzzzs_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? izzzzzzzzt_ = izzzzzzzzs_?.Value;
                        Code<Encounter.EncounterStatus> izzzzzzzzu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(izzzzzzzzt_);
                        bool? izzzzzzzzv_ = context.Operators.Equal(izzzzzzzzu_, "finished");
                        Period izzzzzzzzw_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> izzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzw_);
                        CqlDateTime izzzzzzzzy_ = context.Operators.End(izzzzzzzzx_);
                        Period izzzzzzzzz_ = Visit?.Period;
                        CqlInterval<CqlDateTime> jzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzz_);
                        CqlDateTime jzzzzzzzzb_ = context.Operators.Start(jzzzzzzzza_);
                        CqlQuantity jzzzzzzzzc_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime jzzzzzzzzd_ = context.Operators.Subtract(jzzzzzzzzb_, jzzzzzzzzc_);
                        CqlInterval<CqlDateTime> jzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzz_);
                        CqlDateTime jzzzzzzzzg_ = context.Operators.Start(jzzzzzzzzf_);
                        CqlInterval<CqlDateTime> jzzzzzzzzh_ = context.Operators.Interval(jzzzzzzzzd_, jzzzzzzzzg_, true, true);
                        bool? jzzzzzzzzi_ = context.Operators.In<CqlDateTime>(izzzzzzzzy_, jzzzzzzzzh_, default);
                        CqlInterval<CqlDateTime> jzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzz_);
                        CqlDateTime jzzzzzzzzl_ = context.Operators.Start(jzzzzzzzzk_);
                        bool? jzzzzzzzzm_ = context.Operators.Not((bool?)(jzzzzzzzzl_ is null));
                        bool? jzzzzzzzzn_ = context.Operators.And(jzzzzzzzzi_, jzzzzzzzzm_);
                        bool? jzzzzzzzzo_ = context.Operators.And(izzzzzzzzv_, jzzzzzzzzn_);

                        return jzzzzzzzzo_;
                    };
                    IEnumerable<Encounter> gzzzzzzzzq_ = context.Operators.Where<Encounter>(gzzzzzzzzo_, gzzzzzzzzp_);
                    object gzzzzzzzzr_(Encounter @this)
                    {
                        Period jzzzzzzzzp_ = @this?.Period;
                        CqlInterval<CqlDateTime> jzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzp_);
                        CqlDateTime jzzzzzzzzr_ = context.Operators.End(jzzzzzzzzq_);

                        return jzzzzzzzzr_;
                    };
                    IEnumerable<Encounter> gzzzzzzzzs_ = context.Operators.SortBy<Encounter>(gzzzzzzzzq_, gzzzzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter gzzzzzzzzt_ = context.Operators.Last<Encounter>(gzzzzzzzzs_);
                    Period gzzzzzzzzu_ = gzzzzzzzzt_?.Period;
                    CqlInterval<CqlDateTime> gzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzu_);
                    CqlDateTime gzzzzzzzzw_ = context.Operators.Start(gzzzzzzzzv_);
                    CqlInterval<CqlDateTime> gzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzi_);
                    CqlDateTime gzzzzzzzzz_ = context.Operators.Start(gzzzzzzzzy_);
                    CqlInterval<CqlDateTime> hzzzzzzzza_ = context.Operators.Interval(gzzzzzzzzm_, gzzzzzzzzw_ ?? gzzzzzzzzz_, true, true);
                    bool? hzzzzzzzzb_ = context.Operators.In<CqlDateTime>(fzzzzzzzzx_, hzzzzzzzza_, default);
                    IEnumerable<Encounter> hzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? hzzzzzzzze_(Encounter LastObs)
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
                    IEnumerable<Encounter> hzzzzzzzzf_ = context.Operators.Where<Encounter>(hzzzzzzzzd_, hzzzzzzzze_);
                    object hzzzzzzzzg_(Encounter @this)
                    {
                        Period kzzzzzzzzp_ = @this?.Period;
                        CqlInterval<CqlDateTime> kzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzp_);
                        CqlDateTime kzzzzzzzzr_ = context.Operators.End(kzzzzzzzzq_);

                        return kzzzzzzzzr_;
                    };
                    IEnumerable<Encounter> hzzzzzzzzh_ = context.Operators.SortBy<Encounter>(hzzzzzzzzf_, hzzzzzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter hzzzzzzzzi_ = context.Operators.Last<Encounter>(hzzzzzzzzh_);
                    Period hzzzzzzzzj_ = hzzzzzzzzi_?.Period;
                    CqlInterval<CqlDateTime> hzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzj_);
                    CqlDateTime hzzzzzzzzl_ = context.Operators.Start(hzzzzzzzzk_);
                    CqlInterval<CqlDateTime> hzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzi_);
                    CqlDateTime hzzzzzzzzo_ = context.Operators.Start(hzzzzzzzzn_);
                    bool? hzzzzzzzzp_ = context.Operators.Not((bool?)((hzzzzzzzzl_ ?? hzzzzzzzzo_) is null));
                    bool? hzzzzzzzzq_ = context.Operators.And(hzzzzzzzzb_, hzzzzzzzzp_);
                    bool? hzzzzzzzzr_ = context.Operators.And(fzzzzzzzzu_, hzzzzzzzzq_);

                    return hzzzzzzzzr_;
                };
                IEnumerable<Encounter> xzzzzzzzs_ = context.Operators.Where<Encounter>(xzzzzzzzq_, xzzzzzzzr_);
                object xzzzzzzzt_(Encounter @this)
                {
                    Period kzzzzzzzzs_ = @this?.Period;
                    CqlInterval<CqlDateTime> kzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzs_);
                    CqlDateTime kzzzzzzzzu_ = context.Operators.End(kzzzzzzzzt_);

                    return kzzzzzzzzu_;
                };
                IEnumerable<Encounter> xzzzzzzzu_ = context.Operators.SortBy<Encounter>(xzzzzzzzs_, xzzzzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter xzzzzzzzv_ = context.Operators.Last<Encounter>(xzzzzzzzu_);
                Period xzzzzzzzw_ = xzzzzzzzv_?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzw_);
                CqlDateTime xzzzzzzzy_ = context.Operators.Start(xzzzzzzzx_);
                IEnumerable<Encounter> yzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? yzzzzzzzb_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> kzzzzzzzzv_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? kzzzzzzzzw_ = kzzzzzzzzv_?.Value;
                    Code<Encounter.EncounterStatus> kzzzzzzzzx_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(kzzzzzzzzw_);
                    bool? kzzzzzzzzy_ = context.Operators.Equal(kzzzzzzzzx_, "finished");
                    Period kzzzzzzzzz_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> lzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzz_);
                    CqlDateTime lzzzzzzzzb_ = context.Operators.End(lzzzzzzzza_);
                    Period lzzzzzzzzc_ = Visit?.Period;
                    CqlInterval<CqlDateTime> lzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzc_);
                    CqlDateTime lzzzzzzzze_ = context.Operators.Start(lzzzzzzzzd_);
                    CqlQuantity lzzzzzzzzf_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime lzzzzzzzzg_ = context.Operators.Subtract(lzzzzzzzze_, lzzzzzzzzf_);
                    CqlInterval<CqlDateTime> lzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzc_);
                    CqlDateTime lzzzzzzzzj_ = context.Operators.Start(lzzzzzzzzi_);
                    CqlInterval<CqlDateTime> lzzzzzzzzk_ = context.Operators.Interval(lzzzzzzzzg_, lzzzzzzzzj_, true, true);
                    bool? lzzzzzzzzl_ = context.Operators.In<CqlDateTime>(lzzzzzzzzb_, lzzzzzzzzk_, default);
                    CqlInterval<CqlDateTime> lzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzc_);
                    CqlDateTime lzzzzzzzzo_ = context.Operators.Start(lzzzzzzzzn_);
                    bool? lzzzzzzzzp_ = context.Operators.Not((bool?)(lzzzzzzzzo_ is null));
                    bool? lzzzzzzzzq_ = context.Operators.And(lzzzzzzzzl_, lzzzzzzzzp_);
                    bool? lzzzzzzzzr_ = context.Operators.And(kzzzzzzzzy_, lzzzzzzzzq_);

                    return lzzzzzzzzr_;
                };
                IEnumerable<Encounter> yzzzzzzzc_ = context.Operators.Where<Encounter>(yzzzzzzza_, yzzzzzzzb_);
                object yzzzzzzzd_(Encounter @this)
                {
                    Period lzzzzzzzzs_ = @this?.Period;
                    CqlInterval<CqlDateTime> lzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzs_);
                    CqlDateTime lzzzzzzzzu_ = context.Operators.End(lzzzzzzzzt_);

                    return lzzzzzzzzu_;
                };
                IEnumerable<Encounter> yzzzzzzze_ = context.Operators.SortBy<Encounter>(yzzzzzzzc_, yzzzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter yzzzzzzzf_ = context.Operators.Last<Encounter>(yzzzzzzze_);
                Period yzzzzzzzg_ = yzzzzzzzf_?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzg_);
                CqlDateTime yzzzzzzzi_ = context.Operators.Start(yzzzzzzzh_);
                CqlInterval<CqlDateTime> yzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzk_);
                CqlDateTime yzzzzzzzl_ = context.Operators.Start(yzzzzzzzk_);
                CqlInterval<CqlDateTime> yzzzzzzzm_ = context.Operators.Interval(xzzzzzzzo_, xzzzzzzzy_ ?? yzzzzzzzi_ ?? yzzzzzzzl_, true, true);
                bool? yzzzzzzzn_ = context.Operators.In<CqlDateTime>(wzzzzzzzp_, yzzzzzzzm_, default);
                IEnumerable<Encounter> yzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? yzzzzzzzq_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> lzzzzzzzzv_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? lzzzzzzzzw_ = lzzzzzzzzv_?.Value;
                    Code<Encounter.EncounterStatus> lzzzzzzzzx_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lzzzzzzzzw_);
                    bool? lzzzzzzzzy_ = context.Operators.Equal(lzzzzzzzzx_, "finished");
                    Period lzzzzzzzzz_ = LastED?.Period;
                    CqlInterval<CqlDateTime> mzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzz_);
                    CqlDateTime mzzzzzzzzb_ = context.Operators.End(mzzzzzzzza_);
                    CqlValueSet mzzzzzzzzc_ = this.Observation_Services(context);
                    IEnumerable<Encounter> mzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? mzzzzzzzze_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> nzzzzzzzzw_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? nzzzzzzzzx_ = nzzzzzzzzw_?.Value;
                        Code<Encounter.EncounterStatus> nzzzzzzzzy_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(nzzzzzzzzx_);
                        bool? nzzzzzzzzz_ = context.Operators.Equal(nzzzzzzzzy_, "finished");
                        Period ozzzzzzzza_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> ozzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzza_);
                        CqlDateTime ozzzzzzzzc_ = context.Operators.End(ozzzzzzzzb_);
                        Period ozzzzzzzzd_ = Visit?.Period;
                        CqlInterval<CqlDateTime> ozzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzd_);
                        CqlDateTime ozzzzzzzzf_ = context.Operators.Start(ozzzzzzzze_);
                        CqlQuantity ozzzzzzzzg_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime ozzzzzzzzh_ = context.Operators.Subtract(ozzzzzzzzf_, ozzzzzzzzg_);
                        CqlInterval<CqlDateTime> ozzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzd_);
                        CqlDateTime ozzzzzzzzk_ = context.Operators.Start(ozzzzzzzzj_);
                        CqlInterval<CqlDateTime> ozzzzzzzzl_ = context.Operators.Interval(ozzzzzzzzh_, ozzzzzzzzk_, true, true);
                        bool? ozzzzzzzzm_ = context.Operators.In<CqlDateTime>(ozzzzzzzzc_, ozzzzzzzzl_, default);
                        CqlInterval<CqlDateTime> ozzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzd_);
                        CqlDateTime ozzzzzzzzp_ = context.Operators.Start(ozzzzzzzzo_);
                        bool? ozzzzzzzzq_ = context.Operators.Not((bool?)(ozzzzzzzzp_ is null));
                        bool? ozzzzzzzzr_ = context.Operators.And(ozzzzzzzzm_, ozzzzzzzzq_);
                        bool? ozzzzzzzzs_ = context.Operators.And(nzzzzzzzzz_, ozzzzzzzzr_);

                        return ozzzzzzzzs_;
                    };
                    IEnumerable<Encounter> mzzzzzzzzf_ = context.Operators.Where<Encounter>(mzzzzzzzzd_, mzzzzzzzze_);
                    object mzzzzzzzzg_(Encounter @this)
                    {
                        Period ozzzzzzzzt_ = @this?.Period;
                        CqlInterval<CqlDateTime> ozzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzt_);
                        CqlDateTime ozzzzzzzzv_ = context.Operators.End(ozzzzzzzzu_);

                        return ozzzzzzzzv_;
                    };
                    IEnumerable<Encounter> mzzzzzzzzh_ = context.Operators.SortBy<Encounter>(mzzzzzzzzf_, mzzzzzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter mzzzzzzzzi_ = context.Operators.Last<Encounter>(mzzzzzzzzh_);
                    Period mzzzzzzzzj_ = mzzzzzzzzi_?.Period;
                    CqlInterval<CqlDateTime> mzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzj_);
                    CqlDateTime mzzzzzzzzl_ = context.Operators.Start(mzzzzzzzzk_);
                    Period mzzzzzzzzm_ = Visit?.Period;
                    CqlInterval<CqlDateTime> mzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzm_);
                    CqlDateTime mzzzzzzzzo_ = context.Operators.Start(mzzzzzzzzn_);
                    CqlQuantity mzzzzzzzzp_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime mzzzzzzzzq_ = context.Operators.Subtract(mzzzzzzzzl_ ?? mzzzzzzzzo_, mzzzzzzzzp_);
                    IEnumerable<Encounter> mzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? mzzzzzzzzt_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> ozzzzzzzzw_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? ozzzzzzzzx_ = ozzzzzzzzw_?.Value;
                        Code<Encounter.EncounterStatus> ozzzzzzzzy_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ozzzzzzzzx_);
                        bool? ozzzzzzzzz_ = context.Operators.Equal(ozzzzzzzzy_, "finished");
                        Period pzzzzzzzza_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> pzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzza_);
                        CqlDateTime pzzzzzzzzc_ = context.Operators.End(pzzzzzzzzb_);
                        Period pzzzzzzzzd_ = Visit?.Period;
                        CqlInterval<CqlDateTime> pzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzd_);
                        CqlDateTime pzzzzzzzzf_ = context.Operators.Start(pzzzzzzzze_);
                        CqlQuantity pzzzzzzzzg_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime pzzzzzzzzh_ = context.Operators.Subtract(pzzzzzzzzf_, pzzzzzzzzg_);
                        CqlInterval<CqlDateTime> pzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzd_);
                        CqlDateTime pzzzzzzzzk_ = context.Operators.Start(pzzzzzzzzj_);
                        CqlInterval<CqlDateTime> pzzzzzzzzl_ = context.Operators.Interval(pzzzzzzzzh_, pzzzzzzzzk_, true, true);
                        bool? pzzzzzzzzm_ = context.Operators.In<CqlDateTime>(pzzzzzzzzc_, pzzzzzzzzl_, default);
                        CqlInterval<CqlDateTime> pzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzd_);
                        CqlDateTime pzzzzzzzzp_ = context.Operators.Start(pzzzzzzzzo_);
                        bool? pzzzzzzzzq_ = context.Operators.Not((bool?)(pzzzzzzzzp_ is null));
                        bool? pzzzzzzzzr_ = context.Operators.And(pzzzzzzzzm_, pzzzzzzzzq_);
                        bool? pzzzzzzzzs_ = context.Operators.And(ozzzzzzzzz_, pzzzzzzzzr_);

                        return pzzzzzzzzs_;
                    };
                    IEnumerable<Encounter> mzzzzzzzzu_ = context.Operators.Where<Encounter>(mzzzzzzzzs_, mzzzzzzzzt_);
                    object mzzzzzzzzv_(Encounter @this)
                    {
                        Period pzzzzzzzzt_ = @this?.Period;
                        CqlInterval<CqlDateTime> pzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzt_);
                        CqlDateTime pzzzzzzzzv_ = context.Operators.End(pzzzzzzzzu_);

                        return pzzzzzzzzv_;
                    };
                    IEnumerable<Encounter> mzzzzzzzzw_ = context.Operators.SortBy<Encounter>(mzzzzzzzzu_, mzzzzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter mzzzzzzzzx_ = context.Operators.Last<Encounter>(mzzzzzzzzw_);
                    Period mzzzzzzzzy_ = mzzzzzzzzx_?.Period;
                    CqlInterval<CqlDateTime> mzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzy_);
                    CqlDateTime nzzzzzzzza_ = context.Operators.Start(mzzzzzzzzz_);
                    CqlInterval<CqlDateTime> nzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzm_);
                    CqlDateTime nzzzzzzzzd_ = context.Operators.Start(nzzzzzzzzc_);
                    CqlInterval<CqlDateTime> nzzzzzzzze_ = context.Operators.Interval(mzzzzzzzzq_, nzzzzzzzza_ ?? nzzzzzzzzd_, true, true);
                    bool? nzzzzzzzzf_ = context.Operators.In<CqlDateTime>(mzzzzzzzzb_, nzzzzzzzze_, default);
                    IEnumerable<Encounter> nzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? nzzzzzzzzi_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> pzzzzzzzzw_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? pzzzzzzzzx_ = pzzzzzzzzw_?.Value;
                        Code<Encounter.EncounterStatus> pzzzzzzzzy_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pzzzzzzzzx_);
                        bool? pzzzzzzzzz_ = context.Operators.Equal(pzzzzzzzzy_, "finished");
                        Period qzzzzzzzza_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> qzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzza_);
                        CqlDateTime qzzzzzzzzc_ = context.Operators.End(qzzzzzzzzb_);
                        Period qzzzzzzzzd_ = Visit?.Period;
                        CqlInterval<CqlDateTime> qzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzd_);
                        CqlDateTime qzzzzzzzzf_ = context.Operators.Start(qzzzzzzzze_);
                        CqlQuantity qzzzzzzzzg_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime qzzzzzzzzh_ = context.Operators.Subtract(qzzzzzzzzf_, qzzzzzzzzg_);
                        CqlInterval<CqlDateTime> qzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzd_);
                        CqlDateTime qzzzzzzzzk_ = context.Operators.Start(qzzzzzzzzj_);
                        CqlInterval<CqlDateTime> qzzzzzzzzl_ = context.Operators.Interval(qzzzzzzzzh_, qzzzzzzzzk_, true, true);
                        bool? qzzzzzzzzm_ = context.Operators.In<CqlDateTime>(qzzzzzzzzc_, qzzzzzzzzl_, default);
                        CqlInterval<CqlDateTime> qzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzd_);
                        CqlDateTime qzzzzzzzzp_ = context.Operators.Start(qzzzzzzzzo_);
                        bool? qzzzzzzzzq_ = context.Operators.Not((bool?)(qzzzzzzzzp_ is null));
                        bool? qzzzzzzzzr_ = context.Operators.And(qzzzzzzzzm_, qzzzzzzzzq_);
                        bool? qzzzzzzzzs_ = context.Operators.And(pzzzzzzzzz_, qzzzzzzzzr_);

                        return qzzzzzzzzs_;
                    };
                    IEnumerable<Encounter> nzzzzzzzzj_ = context.Operators.Where<Encounter>(nzzzzzzzzh_, nzzzzzzzzi_);
                    object nzzzzzzzzk_(Encounter @this)
                    {
                        Period qzzzzzzzzt_ = @this?.Period;
                        CqlInterval<CqlDateTime> qzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzt_);
                        CqlDateTime qzzzzzzzzv_ = context.Operators.End(qzzzzzzzzu_);

                        return qzzzzzzzzv_;
                    };
                    IEnumerable<Encounter> nzzzzzzzzl_ = context.Operators.SortBy<Encounter>(nzzzzzzzzj_, nzzzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter nzzzzzzzzm_ = context.Operators.Last<Encounter>(nzzzzzzzzl_);
                    Period nzzzzzzzzn_ = nzzzzzzzzm_?.Period;
                    CqlInterval<CqlDateTime> nzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzn_);
                    CqlDateTime nzzzzzzzzp_ = context.Operators.Start(nzzzzzzzzo_);
                    CqlInterval<CqlDateTime> nzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzm_);
                    CqlDateTime nzzzzzzzzs_ = context.Operators.Start(nzzzzzzzzr_);
                    bool? nzzzzzzzzt_ = context.Operators.Not((bool?)((nzzzzzzzzp_ ?? nzzzzzzzzs_) is null));
                    bool? nzzzzzzzzu_ = context.Operators.And(nzzzzzzzzf_, nzzzzzzzzt_);
                    bool? nzzzzzzzzv_ = context.Operators.And(lzzzzzzzzy_, nzzzzzzzzu_);

                    return nzzzzzzzzv_;
                };
                IEnumerable<Encounter> yzzzzzzzr_ = context.Operators.Where<Encounter>(yzzzzzzzp_, yzzzzzzzq_);
                object yzzzzzzzs_(Encounter @this)
                {
                    Period qzzzzzzzzw_ = @this?.Period;
                    CqlInterval<CqlDateTime> qzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzw_);
                    CqlDateTime qzzzzzzzzy_ = context.Operators.End(qzzzzzzzzx_);

                    return qzzzzzzzzy_;
                };
                IEnumerable<Encounter> yzzzzzzzt_ = context.Operators.SortBy<Encounter>(yzzzzzzzr_, yzzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter yzzzzzzzu_ = context.Operators.Last<Encounter>(yzzzzzzzt_);
                Period yzzzzzzzv_ = yzzzzzzzu_?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzv_);
                CqlDateTime yzzzzzzzx_ = context.Operators.Start(yzzzzzzzw_);
                IEnumerable<Encounter> yzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? zzzzzzzza_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> qzzzzzzzzz_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? rzzzzzzzza_ = qzzzzzzzzz_?.Value;
                    Code<Encounter.EncounterStatus> rzzzzzzzzb_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rzzzzzzzza_);
                    bool? rzzzzzzzzc_ = context.Operators.Equal(rzzzzzzzzb_, "finished");
                    Period rzzzzzzzzd_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> rzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzd_);
                    CqlDateTime rzzzzzzzzf_ = context.Operators.End(rzzzzzzzze_);
                    Period rzzzzzzzzg_ = Visit?.Period;
                    CqlInterval<CqlDateTime> rzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzg_);
                    CqlDateTime rzzzzzzzzi_ = context.Operators.Start(rzzzzzzzzh_);
                    CqlQuantity rzzzzzzzzj_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime rzzzzzzzzk_ = context.Operators.Subtract(rzzzzzzzzi_, rzzzzzzzzj_);
                    CqlInterval<CqlDateTime> rzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzg_);
                    CqlDateTime rzzzzzzzzn_ = context.Operators.Start(rzzzzzzzzm_);
                    CqlInterval<CqlDateTime> rzzzzzzzzo_ = context.Operators.Interval(rzzzzzzzzk_, rzzzzzzzzn_, true, true);
                    bool? rzzzzzzzzp_ = context.Operators.In<CqlDateTime>(rzzzzzzzzf_, rzzzzzzzzo_, default);
                    CqlInterval<CqlDateTime> rzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzg_);
                    CqlDateTime rzzzzzzzzs_ = context.Operators.Start(rzzzzzzzzr_);
                    bool? rzzzzzzzzt_ = context.Operators.Not((bool?)(rzzzzzzzzs_ is null));
                    bool? rzzzzzzzzu_ = context.Operators.And(rzzzzzzzzp_, rzzzzzzzzt_);
                    bool? rzzzzzzzzv_ = context.Operators.And(rzzzzzzzzc_, rzzzzzzzzu_);

                    return rzzzzzzzzv_;
                };
                IEnumerable<Encounter> zzzzzzzzb_ = context.Operators.Where<Encounter>(yzzzzzzzz_, zzzzzzzza_);
                object zzzzzzzzc_(Encounter @this)
                {
                    Period rzzzzzzzzw_ = @this?.Period;
                    CqlInterval<CqlDateTime> rzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzw_);
                    CqlDateTime rzzzzzzzzy_ = context.Operators.End(rzzzzzzzzx_);

                    return rzzzzzzzzy_;
                };
                IEnumerable<Encounter> zzzzzzzzd_ = context.Operators.SortBy<Encounter>(zzzzzzzzb_, zzzzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter zzzzzzzze_ = context.Operators.Last<Encounter>(zzzzzzzzd_);
                Period zzzzzzzzf_ = zzzzzzzze_?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzf_);
                CqlDateTime zzzzzzzzh_ = context.Operators.Start(zzzzzzzzg_);
                CqlInterval<CqlDateTime> zzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzk_);
                CqlDateTime zzzzzzzzk_ = context.Operators.Start(zzzzzzzzj_);
                bool? zzzzzzzzl_ = context.Operators.Not((bool?)((yzzzzzzzx_ ?? zzzzzzzzh_ ?? zzzzzzzzk_) is null));
                bool? zzzzzzzzm_ = context.Operators.And(yzzzzzzzn_, zzzzzzzzl_);

                return zzzzzzzzm_;
            };
            IEnumerable<Encounter> vzzzzzzzf_ = context.Operators.Where<Encounter>(vzzzzzzzd_, vzzzzzzze_);
            object vzzzzzzzg_(Encounter @this)
            {
                Period rzzzzzzzzz_ = @this?.Period;
                CqlInterval<CqlDateTime> szzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzz_);
                CqlDateTime szzzzzzzzb_ = context.Operators.End(szzzzzzzza_);

                return szzzzzzzzb_;
            };
            IEnumerable<Encounter> vzzzzzzzh_ = context.Operators.SortBy<Encounter>(vzzzzzzzf_, vzzzzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter vzzzzzzzi_ = context.Operators.Last<Encounter>(vzzzzzzzh_);
            Period vzzzzzzzj_ = vzzzzzzzi_?.Period;
            CqlInterval<CqlDateTime> vzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzj_);
            CqlDateTime vzzzzzzzl_ = context.Operators.Start(vzzzzzzzk_);
            CqlValueSet vzzzzzzzm_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> vzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? vzzzzzzzo_(Encounter LastED)
            {
                Code<Encounter.EncounterStatus> szzzzzzzzc_ = LastED?.StatusElement;
                Encounter.EncounterStatus? szzzzzzzzd_ = szzzzzzzzc_?.Value;
                Code<Encounter.EncounterStatus> szzzzzzzze_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(szzzzzzzzd_);
                bool? szzzzzzzzf_ = context.Operators.Equal(szzzzzzzze_, "finished");
                Period szzzzzzzzg_ = LastED?.Period;
                CqlInterval<CqlDateTime> szzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzg_);
                CqlDateTime szzzzzzzzi_ = context.Operators.End(szzzzzzzzh_);
                CqlValueSet szzzzzzzzj_ = this.Observation_Services(context);
                IEnumerable<Encounter> szzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? szzzzzzzzl_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> uzzzzzzzzd_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? uzzzzzzzze_ = uzzzzzzzzd_?.Value;
                    Code<Encounter.EncounterStatus> uzzzzzzzzf_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(uzzzzzzzze_);
                    bool? uzzzzzzzzg_ = context.Operators.Equal(uzzzzzzzzf_, "finished");
                    Period uzzzzzzzzh_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> uzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzh_);
                    CqlDateTime uzzzzzzzzj_ = context.Operators.End(uzzzzzzzzi_);
                    Period uzzzzzzzzk_ = Visit?.Period;
                    CqlInterval<CqlDateTime> uzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzk_);
                    CqlDateTime uzzzzzzzzm_ = context.Operators.Start(uzzzzzzzzl_);
                    CqlQuantity uzzzzzzzzn_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime uzzzzzzzzo_ = context.Operators.Subtract(uzzzzzzzzm_, uzzzzzzzzn_);
                    CqlInterval<CqlDateTime> uzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzk_);
                    CqlDateTime uzzzzzzzzr_ = context.Operators.Start(uzzzzzzzzq_);
                    CqlInterval<CqlDateTime> uzzzzzzzzs_ = context.Operators.Interval(uzzzzzzzzo_, uzzzzzzzzr_, true, true);
                    bool? uzzzzzzzzt_ = context.Operators.In<CqlDateTime>(uzzzzzzzzj_, uzzzzzzzzs_, default);
                    CqlInterval<CqlDateTime> uzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzk_);
                    CqlDateTime uzzzzzzzzw_ = context.Operators.Start(uzzzzzzzzv_);
                    bool? uzzzzzzzzx_ = context.Operators.Not((bool?)(uzzzzzzzzw_ is null));
                    bool? uzzzzzzzzy_ = context.Operators.And(uzzzzzzzzt_, uzzzzzzzzx_);
                    bool? uzzzzzzzzz_ = context.Operators.And(uzzzzzzzzg_, uzzzzzzzzy_);

                    return uzzzzzzzzz_;
                };
                IEnumerable<Encounter> szzzzzzzzm_ = context.Operators.Where<Encounter>(szzzzzzzzk_, szzzzzzzzl_);
                object szzzzzzzzn_(Encounter @this)
                {
                    Period vzzzzzzzza_ = @this?.Period;
                    CqlInterval<CqlDateTime> vzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzza_);
                    CqlDateTime vzzzzzzzzc_ = context.Operators.End(vzzzzzzzzb_);

                    return vzzzzzzzzc_;
                };
                IEnumerable<Encounter> szzzzzzzzo_ = context.Operators.SortBy<Encounter>(szzzzzzzzm_, szzzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter szzzzzzzzp_ = context.Operators.Last<Encounter>(szzzzzzzzo_);
                Period szzzzzzzzq_ = szzzzzzzzp_?.Period;
                CqlInterval<CqlDateTime> szzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzq_);
                CqlDateTime szzzzzzzzs_ = context.Operators.Start(szzzzzzzzr_);
                Period szzzzzzzzt_ = Visit?.Period;
                CqlInterval<CqlDateTime> szzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzt_);
                CqlDateTime szzzzzzzzv_ = context.Operators.Start(szzzzzzzzu_);
                CqlQuantity szzzzzzzzw_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime szzzzzzzzx_ = context.Operators.Subtract(szzzzzzzzs_ ?? szzzzzzzzv_, szzzzzzzzw_);
                IEnumerable<Encounter> szzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? tzzzzzzzza_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> vzzzzzzzzd_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? vzzzzzzzze_ = vzzzzzzzzd_?.Value;
                    Code<Encounter.EncounterStatus> vzzzzzzzzf_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(vzzzzzzzze_);
                    bool? vzzzzzzzzg_ = context.Operators.Equal(vzzzzzzzzf_, "finished");
                    Period vzzzzzzzzh_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> vzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzh_);
                    CqlDateTime vzzzzzzzzj_ = context.Operators.End(vzzzzzzzzi_);
                    Period vzzzzzzzzk_ = Visit?.Period;
                    CqlInterval<CqlDateTime> vzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzk_);
                    CqlDateTime vzzzzzzzzm_ = context.Operators.Start(vzzzzzzzzl_);
                    CqlQuantity vzzzzzzzzn_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime vzzzzzzzzo_ = context.Operators.Subtract(vzzzzzzzzm_, vzzzzzzzzn_);
                    CqlInterval<CqlDateTime> vzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzk_);
                    CqlDateTime vzzzzzzzzr_ = context.Operators.Start(vzzzzzzzzq_);
                    CqlInterval<CqlDateTime> vzzzzzzzzs_ = context.Operators.Interval(vzzzzzzzzo_, vzzzzzzzzr_, true, true);
                    bool? vzzzzzzzzt_ = context.Operators.In<CqlDateTime>(vzzzzzzzzj_, vzzzzzzzzs_, default);
                    CqlInterval<CqlDateTime> vzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzk_);
                    CqlDateTime vzzzzzzzzw_ = context.Operators.Start(vzzzzzzzzv_);
                    bool? vzzzzzzzzx_ = context.Operators.Not((bool?)(vzzzzzzzzw_ is null));
                    bool? vzzzzzzzzy_ = context.Operators.And(vzzzzzzzzt_, vzzzzzzzzx_);
                    bool? vzzzzzzzzz_ = context.Operators.And(vzzzzzzzzg_, vzzzzzzzzy_);

                    return vzzzzzzzzz_;
                };
                IEnumerable<Encounter> tzzzzzzzzb_ = context.Operators.Where<Encounter>(szzzzzzzzz_, tzzzzzzzza_);
                object tzzzzzzzzc_(Encounter @this)
                {
                    Period wzzzzzzzza_ = @this?.Period;
                    CqlInterval<CqlDateTime> wzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzza_);
                    CqlDateTime wzzzzzzzzc_ = context.Operators.End(wzzzzzzzzb_);

                    return wzzzzzzzzc_;
                };
                IEnumerable<Encounter> tzzzzzzzzd_ = context.Operators.SortBy<Encounter>(tzzzzzzzzb_, tzzzzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter tzzzzzzzze_ = context.Operators.Last<Encounter>(tzzzzzzzzd_);
                Period tzzzzzzzzf_ = tzzzzzzzze_?.Period;
                CqlInterval<CqlDateTime> tzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzf_);
                CqlDateTime tzzzzzzzzh_ = context.Operators.Start(tzzzzzzzzg_);
                CqlInterval<CqlDateTime> tzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzt_);
                CqlDateTime tzzzzzzzzk_ = context.Operators.Start(tzzzzzzzzj_);
                CqlInterval<CqlDateTime> tzzzzzzzzl_ = context.Operators.Interval(szzzzzzzzx_, tzzzzzzzzh_ ?? tzzzzzzzzk_, true, true);
                bool? tzzzzzzzzm_ = context.Operators.In<CqlDateTime>(szzzzzzzzi_, tzzzzzzzzl_, default);
                IEnumerable<Encounter> tzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? tzzzzzzzzp_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> wzzzzzzzzd_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? wzzzzzzzze_ = wzzzzzzzzd_?.Value;
                    Code<Encounter.EncounterStatus> wzzzzzzzzf_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(wzzzzzzzze_);
                    bool? wzzzzzzzzg_ = context.Operators.Equal(wzzzzzzzzf_, "finished");
                    Period wzzzzzzzzh_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> wzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzh_);
                    CqlDateTime wzzzzzzzzj_ = context.Operators.End(wzzzzzzzzi_);
                    Period wzzzzzzzzk_ = Visit?.Period;
                    CqlInterval<CqlDateTime> wzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzk_);
                    CqlDateTime wzzzzzzzzm_ = context.Operators.Start(wzzzzzzzzl_);
                    CqlQuantity wzzzzzzzzn_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime wzzzzzzzzo_ = context.Operators.Subtract(wzzzzzzzzm_, wzzzzzzzzn_);
                    CqlInterval<CqlDateTime> wzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzk_);
                    CqlDateTime wzzzzzzzzr_ = context.Operators.Start(wzzzzzzzzq_);
                    CqlInterval<CqlDateTime> wzzzzzzzzs_ = context.Operators.Interval(wzzzzzzzzo_, wzzzzzzzzr_, true, true);
                    bool? wzzzzzzzzt_ = context.Operators.In<CqlDateTime>(wzzzzzzzzj_, wzzzzzzzzs_, default);
                    CqlInterval<CqlDateTime> wzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzk_);
                    CqlDateTime wzzzzzzzzw_ = context.Operators.Start(wzzzzzzzzv_);
                    bool? wzzzzzzzzx_ = context.Operators.Not((bool?)(wzzzzzzzzw_ is null));
                    bool? wzzzzzzzzy_ = context.Operators.And(wzzzzzzzzt_, wzzzzzzzzx_);
                    bool? wzzzzzzzzz_ = context.Operators.And(wzzzzzzzzg_, wzzzzzzzzy_);

                    return wzzzzzzzzz_;
                };
                IEnumerable<Encounter> tzzzzzzzzq_ = context.Operators.Where<Encounter>(tzzzzzzzzo_, tzzzzzzzzp_);
                object tzzzzzzzzr_(Encounter @this)
                {
                    Period xzzzzzzzza_ = @this?.Period;
                    CqlInterval<CqlDateTime> xzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzza_);
                    CqlDateTime xzzzzzzzzc_ = context.Operators.End(xzzzzzzzzb_);

                    return xzzzzzzzzc_;
                };
                IEnumerable<Encounter> tzzzzzzzzs_ = context.Operators.SortBy<Encounter>(tzzzzzzzzq_, tzzzzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter tzzzzzzzzt_ = context.Operators.Last<Encounter>(tzzzzzzzzs_);
                Period tzzzzzzzzu_ = tzzzzzzzzt_?.Period;
                CqlInterval<CqlDateTime> tzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzu_);
                CqlDateTime tzzzzzzzzw_ = context.Operators.Start(tzzzzzzzzv_);
                CqlInterval<CqlDateTime> tzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzt_);
                CqlDateTime tzzzzzzzzz_ = context.Operators.Start(tzzzzzzzzy_);
                bool? uzzzzzzzza_ = context.Operators.Not((bool?)((tzzzzzzzzw_ ?? tzzzzzzzzz_) is null));
                bool? uzzzzzzzzb_ = context.Operators.And(tzzzzzzzzm_, uzzzzzzzza_);
                bool? uzzzzzzzzc_ = context.Operators.And(szzzzzzzzf_, uzzzzzzzzb_);

                return uzzzzzzzzc_;
            };
            IEnumerable<Encounter> vzzzzzzzp_ = context.Operators.Where<Encounter>(vzzzzzzzn_, vzzzzzzzo_);
            object vzzzzzzzq_(Encounter @this)
            {
                Period xzzzzzzzzd_ = @this?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzd_);
                CqlDateTime xzzzzzzzzf_ = context.Operators.End(xzzzzzzzze_);

                return xzzzzzzzzf_;
            };
            IEnumerable<Encounter> vzzzzzzzr_ = context.Operators.SortBy<Encounter>(vzzzzzzzp_, vzzzzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter vzzzzzzzs_ = context.Operators.Last<Encounter>(vzzzzzzzr_);
            Period vzzzzzzzt_ = vzzzzzzzs_?.Period;
            CqlInterval<CqlDateTime> vzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzt_);
            CqlDateTime vzzzzzzzv_ = context.Operators.Start(vzzzzzzzu_);
            CqlValueSet vzzzzzzzw_ = this.Observation_Services(context);
            IEnumerable<Encounter> vzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? vzzzzzzzy_(Encounter LastObs)
            {
                Code<Encounter.EncounterStatus> xzzzzzzzzg_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? xzzzzzzzzh_ = xzzzzzzzzg_?.Value;
                Code<Encounter.EncounterStatus> xzzzzzzzzi_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(xzzzzzzzzh_);
                bool? xzzzzzzzzj_ = context.Operators.Equal(xzzzzzzzzi_, "finished");
                Period xzzzzzzzzk_ = LastObs?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzk_);
                CqlDateTime xzzzzzzzzm_ = context.Operators.End(xzzzzzzzzl_);
                Period xzzzzzzzzn_ = Visit?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzn_);
                CqlDateTime xzzzzzzzzp_ = context.Operators.Start(xzzzzzzzzo_);
                CqlQuantity xzzzzzzzzq_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime xzzzzzzzzr_ = context.Operators.Subtract(xzzzzzzzzp_, xzzzzzzzzq_);
                CqlInterval<CqlDateTime> xzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzn_);
                CqlDateTime xzzzzzzzzu_ = context.Operators.Start(xzzzzzzzzt_);
                CqlInterval<CqlDateTime> xzzzzzzzzv_ = context.Operators.Interval(xzzzzzzzzr_, xzzzzzzzzu_, true, true);
                bool? xzzzzzzzzw_ = context.Operators.In<CqlDateTime>(xzzzzzzzzm_, xzzzzzzzzv_, default);
                CqlInterval<CqlDateTime> xzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzn_);
                CqlDateTime xzzzzzzzzz_ = context.Operators.Start(xzzzzzzzzy_);
                bool? yzzzzzzzza_ = context.Operators.Not((bool?)(xzzzzzzzzz_ is null));
                bool? yzzzzzzzzb_ = context.Operators.And(xzzzzzzzzw_, yzzzzzzzza_);
                bool? yzzzzzzzzc_ = context.Operators.And(xzzzzzzzzj_, yzzzzzzzzb_);

                return yzzzzzzzzc_;
            };
            IEnumerable<Encounter> vzzzzzzzz_ = context.Operators.Where<Encounter>(vzzzzzzzx_, vzzzzzzzy_);
            object wzzzzzzza_(Encounter @this)
            {
                Period yzzzzzzzzd_ = @this?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzd_);
                CqlDateTime yzzzzzzzzf_ = context.Operators.End(yzzzzzzzze_);

                return yzzzzzzzzf_;
            };
            IEnumerable<Encounter> wzzzzzzzb_ = context.Operators.SortBy<Encounter>(vzzzzzzzz_, wzzzzzzza_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter wzzzzzzzc_ = context.Operators.Last<Encounter>(wzzzzzzzb_);
            Period wzzzzzzzd_ = wzzzzzzzc_?.Period;
            CqlInterval<CqlDateTime> wzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzd_);
            CqlDateTime wzzzzzzzf_ = context.Operators.Start(wzzzzzzze_);
            Period wzzzzzzzg_ = Visit?.Period;
            CqlInterval<CqlDateTime> wzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzg_);
            CqlDateTime wzzzzzzzi_ = context.Operators.Start(wzzzzzzzh_);
            CqlInterval<CqlDateTime> wzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzg_);
            CqlDateTime wzzzzzzzl_ = context.Operators.End(wzzzzzzzk_);
            CqlInterval<CqlDateTime> wzzzzzzzm_ = context.Operators.Interval(vzzzzzzzl_ ?? vzzzzzzzv_ ?? wzzzzzzzf_ ?? wzzzzzzzi_, wzzzzzzzl_, true, true);

            return wzzzzzzzm_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> uzzzzzzzz_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)uzzzzzzzx_, uzzzzzzzy_);
        IEnumerable<CqlInterval<CqlDateTime>> vzzzzzzza_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(uzzzzzzzz_);
        CqlInterval<CqlDateTime> vzzzzzzzb_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(vzzzzzzza_);

        return vzzzzzzzb_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservation")]
    [CqlTag("description", "Hospitalization with Observation returns the total interval from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationWithObservation()` instead.")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] yzzzzzzzzg_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> yzzzzzzzzh_(Encounter Visit)
        {
            CqlValueSet yzzzzzzzzl_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> yzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? yzzzzzzzzn_(Encounter LastED)
            {
                Code<Encounter.EncounterStatus> zzzzzzzzzm_ = LastED?.StatusElement;
                Encounter.EncounterStatus? zzzzzzzzzn_ = zzzzzzzzzm_?.Value;
                Code<Encounter.EncounterStatus> zzzzzzzzzo_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(zzzzzzzzzn_);
                bool? zzzzzzzzzp_ = context.Operators.Equal(zzzzzzzzzo_, "finished");
                Period zzzzzzzzzq_ = LastED?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzq_);
                CqlDateTime zzzzzzzzzs_ = context.Operators.End(zzzzzzzzzr_);
                CqlValueSet zzzzzzzzzt_ = this.Observation_Services(context);
                IEnumerable<Encounter> zzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? zzzzzzzzzv_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> bzzzzzzzzzn_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? bzzzzzzzzzo_ = bzzzzzzzzzn_?.Value;
                    Code<Encounter.EncounterStatus> bzzzzzzzzzp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bzzzzzzzzzo_);
                    bool? bzzzzzzzzzq_ = context.Operators.Equal(bzzzzzzzzzp_, "finished");
                    Period bzzzzzzzzzr_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> bzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzr_);
                    CqlDateTime bzzzzzzzzzt_ = context.Operators.End(bzzzzzzzzzs_);
                    Period bzzzzzzzzzu_ = Visit?.Period;
                    CqlInterval<CqlDateTime> bzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzu_);
                    CqlDateTime bzzzzzzzzzw_ = context.Operators.Start(bzzzzzzzzzv_);
                    CqlQuantity bzzzzzzzzzx_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime bzzzzzzzzzy_ = context.Operators.Subtract(bzzzzzzzzzw_, bzzzzzzzzzx_);
                    CqlInterval<CqlDateTime> czzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzu_);
                    CqlDateTime czzzzzzzzzb_ = context.Operators.Start(czzzzzzzzza_);
                    CqlInterval<CqlDateTime> czzzzzzzzzc_ = context.Operators.Interval(bzzzzzzzzzy_, czzzzzzzzzb_, true, true);
                    bool? czzzzzzzzzd_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzt_, czzzzzzzzzc_, default);
                    CqlInterval<CqlDateTime> czzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzu_);
                    CqlDateTime czzzzzzzzzg_ = context.Operators.Start(czzzzzzzzzf_);
                    bool? czzzzzzzzzh_ = context.Operators.Not((bool?)(czzzzzzzzzg_ is null));
                    bool? czzzzzzzzzi_ = context.Operators.And(czzzzzzzzzd_, czzzzzzzzzh_);
                    bool? czzzzzzzzzj_ = context.Operators.And(bzzzzzzzzzq_, czzzzzzzzzi_);

                    return czzzzzzzzzj_;
                };
                IEnumerable<Encounter> zzzzzzzzzw_ = context.Operators.Where<Encounter>(zzzzzzzzzu_, zzzzzzzzzv_);
                object zzzzzzzzzx_(Encounter @this)
                {
                    Period czzzzzzzzzk_ = @this?.Period;
                    CqlInterval<CqlDateTime> czzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzk_);
                    CqlDateTime czzzzzzzzzm_ = context.Operators.End(czzzzzzzzzl_);

                    return czzzzzzzzzm_;
                };
                IEnumerable<Encounter> zzzzzzzzzy_ = context.Operators.SortBy<Encounter>(zzzzzzzzzw_, zzzzzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter zzzzzzzzzz_ = context.Operators.Last<Encounter>(zzzzzzzzzy_);
                Period azzzzzzzzza_ = zzzzzzzzzz_?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzza_);
                CqlDateTime azzzzzzzzzc_ = context.Operators.Start(azzzzzzzzzb_);
                Period azzzzzzzzzd_ = Visit?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzd_);
                CqlDateTime azzzzzzzzzf_ = context.Operators.Start(azzzzzzzzze_);
                CqlQuantity azzzzzzzzzg_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime azzzzzzzzzh_ = context.Operators.Subtract(azzzzzzzzzc_ ?? azzzzzzzzzf_, azzzzzzzzzg_);
                IEnumerable<Encounter> azzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? azzzzzzzzzk_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> czzzzzzzzzn_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? czzzzzzzzzo_ = czzzzzzzzzn_?.Value;
                    Code<Encounter.EncounterStatus> czzzzzzzzzp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(czzzzzzzzzo_);
                    bool? czzzzzzzzzq_ = context.Operators.Equal(czzzzzzzzzp_, "finished");
                    Period czzzzzzzzzr_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> czzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzr_);
                    CqlDateTime czzzzzzzzzt_ = context.Operators.End(czzzzzzzzzs_);
                    Period czzzzzzzzzu_ = Visit?.Period;
                    CqlInterval<CqlDateTime> czzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzu_);
                    CqlDateTime czzzzzzzzzw_ = context.Operators.Start(czzzzzzzzzv_);
                    CqlQuantity czzzzzzzzzx_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime czzzzzzzzzy_ = context.Operators.Subtract(czzzzzzzzzw_, czzzzzzzzzx_);
                    CqlInterval<CqlDateTime> dzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzu_);
                    CqlDateTime dzzzzzzzzzb_ = context.Operators.Start(dzzzzzzzzza_);
                    CqlInterval<CqlDateTime> dzzzzzzzzzc_ = context.Operators.Interval(czzzzzzzzzy_, dzzzzzzzzzb_, true, true);
                    bool? dzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(czzzzzzzzzt_, dzzzzzzzzzc_, default);
                    CqlInterval<CqlDateTime> dzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzu_);
                    CqlDateTime dzzzzzzzzzg_ = context.Operators.Start(dzzzzzzzzzf_);
                    bool? dzzzzzzzzzh_ = context.Operators.Not((bool?)(dzzzzzzzzzg_ is null));
                    bool? dzzzzzzzzzi_ = context.Operators.And(dzzzzzzzzzd_, dzzzzzzzzzh_);
                    bool? dzzzzzzzzzj_ = context.Operators.And(czzzzzzzzzq_, dzzzzzzzzzi_);

                    return dzzzzzzzzzj_;
                };
                IEnumerable<Encounter> azzzzzzzzzl_ = context.Operators.Where<Encounter>(azzzzzzzzzj_, azzzzzzzzzk_);
                object azzzzzzzzzm_(Encounter @this)
                {
                    Period dzzzzzzzzzk_ = @this?.Period;
                    CqlInterval<CqlDateTime> dzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzk_);
                    CqlDateTime dzzzzzzzzzm_ = context.Operators.End(dzzzzzzzzzl_);

                    return dzzzzzzzzzm_;
                };
                IEnumerable<Encounter> azzzzzzzzzn_ = context.Operators.SortBy<Encounter>(azzzzzzzzzl_, azzzzzzzzzm_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter azzzzzzzzzo_ = context.Operators.Last<Encounter>(azzzzzzzzzn_);
                Period azzzzzzzzzp_ = azzzzzzzzzo_?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzp_);
                CqlDateTime azzzzzzzzzr_ = context.Operators.Start(azzzzzzzzzq_);
                CqlInterval<CqlDateTime> azzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzd_);
                CqlDateTime azzzzzzzzzu_ = context.Operators.Start(azzzzzzzzzt_);
                CqlInterval<CqlDateTime> azzzzzzzzzv_ = context.Operators.Interval(azzzzzzzzzh_, azzzzzzzzzr_ ?? azzzzzzzzzu_, true, true);
                bool? azzzzzzzzzw_ = context.Operators.In<CqlDateTime>(zzzzzzzzzs_, azzzzzzzzzv_, default);
                IEnumerable<Encounter> azzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? azzzzzzzzzz_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> dzzzzzzzzzn_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? dzzzzzzzzzo_ = dzzzzzzzzzn_?.Value;
                    Code<Encounter.EncounterStatus> dzzzzzzzzzp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dzzzzzzzzzo_);
                    bool? dzzzzzzzzzq_ = context.Operators.Equal(dzzzzzzzzzp_, "finished");
                    Period dzzzzzzzzzr_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> dzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzr_);
                    CqlDateTime dzzzzzzzzzt_ = context.Operators.End(dzzzzzzzzzs_);
                    Period dzzzzzzzzzu_ = Visit?.Period;
                    CqlInterval<CqlDateTime> dzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzu_);
                    CqlDateTime dzzzzzzzzzw_ = context.Operators.Start(dzzzzzzzzzv_);
                    CqlQuantity dzzzzzzzzzx_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime dzzzzzzzzzy_ = context.Operators.Subtract(dzzzzzzzzzw_, dzzzzzzzzzx_);
                    CqlInterval<CqlDateTime> ezzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzu_);
                    CqlDateTime ezzzzzzzzzb_ = context.Operators.Start(ezzzzzzzzza_);
                    CqlInterval<CqlDateTime> ezzzzzzzzzc_ = context.Operators.Interval(dzzzzzzzzzy_, ezzzzzzzzzb_, true, true);
                    bool? ezzzzzzzzzd_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzt_, ezzzzzzzzzc_, default);
                    CqlInterval<CqlDateTime> ezzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzu_);
                    CqlDateTime ezzzzzzzzzg_ = context.Operators.Start(ezzzzzzzzzf_);
                    bool? ezzzzzzzzzh_ = context.Operators.Not((bool?)(ezzzzzzzzzg_ is null));
                    bool? ezzzzzzzzzi_ = context.Operators.And(ezzzzzzzzzd_, ezzzzzzzzzh_);
                    bool? ezzzzzzzzzj_ = context.Operators.And(dzzzzzzzzzq_, ezzzzzzzzzi_);

                    return ezzzzzzzzzj_;
                };
                IEnumerable<Encounter> bzzzzzzzzza_ = context.Operators.Where<Encounter>(azzzzzzzzzy_, azzzzzzzzzz_);
                object bzzzzzzzzzb_(Encounter @this)
                {
                    Period ezzzzzzzzzk_ = @this?.Period;
                    CqlInterval<CqlDateTime> ezzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzk_);
                    CqlDateTime ezzzzzzzzzm_ = context.Operators.End(ezzzzzzzzzl_);

                    return ezzzzzzzzzm_;
                };
                IEnumerable<Encounter> bzzzzzzzzzc_ = context.Operators.SortBy<Encounter>(bzzzzzzzzza_, bzzzzzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bzzzzzzzzzd_ = context.Operators.Last<Encounter>(bzzzzzzzzzc_);
                Period bzzzzzzzzze_ = bzzzzzzzzzd_?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzze_);
                CqlDateTime bzzzzzzzzzg_ = context.Operators.Start(bzzzzzzzzzf_);
                CqlInterval<CqlDateTime> bzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzd_);
                CqlDateTime bzzzzzzzzzj_ = context.Operators.Start(bzzzzzzzzzi_);
                bool? bzzzzzzzzzk_ = context.Operators.Not((bool?)((bzzzzzzzzzg_ ?? bzzzzzzzzzj_) is null));
                bool? bzzzzzzzzzl_ = context.Operators.And(azzzzzzzzzw_, bzzzzzzzzzk_);
                bool? bzzzzzzzzzm_ = context.Operators.And(zzzzzzzzzp_, bzzzzzzzzzl_);

                return bzzzzzzzzzm_;
            };
            IEnumerable<Encounter> yzzzzzzzzo_ = context.Operators.Where<Encounter>(yzzzzzzzzm_, yzzzzzzzzn_);
            object yzzzzzzzzp_(Encounter @this)
            {
                Period ezzzzzzzzzn_ = @this?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzn_);
                CqlDateTime ezzzzzzzzzp_ = context.Operators.End(ezzzzzzzzzo_);

                return ezzzzzzzzzp_;
            };
            IEnumerable<Encounter> yzzzzzzzzq_ = context.Operators.SortBy<Encounter>(yzzzzzzzzo_, yzzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter yzzzzzzzzr_ = context.Operators.Last<Encounter>(yzzzzzzzzq_);
            Period yzzzzzzzzs_ = yzzzzzzzzr_?.Period;
            CqlInterval<CqlDateTime> yzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzs_);
            CqlDateTime yzzzzzzzzu_ = context.Operators.Start(yzzzzzzzzt_);
            CqlValueSet yzzzzzzzzv_ = this.Observation_Services(context);
            IEnumerable<Encounter> yzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? yzzzzzzzzx_(Encounter LastObs)
            {
                Code<Encounter.EncounterStatus> ezzzzzzzzzq_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? ezzzzzzzzzr_ = ezzzzzzzzzq_?.Value;
                Code<Encounter.EncounterStatus> ezzzzzzzzzs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ezzzzzzzzzr_);
                bool? ezzzzzzzzzt_ = context.Operators.Equal(ezzzzzzzzzs_, "finished");
                Period ezzzzzzzzzu_ = LastObs?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzu_);
                CqlDateTime ezzzzzzzzzw_ = context.Operators.End(ezzzzzzzzzv_);
                Period ezzzzzzzzzx_ = Visit?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzx_);
                CqlDateTime ezzzzzzzzzz_ = context.Operators.Start(ezzzzzzzzzy_);
                CqlQuantity fzzzzzzzzza_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime fzzzzzzzzzb_ = context.Operators.Subtract(ezzzzzzzzzz_, fzzzzzzzzza_);
                CqlInterval<CqlDateTime> fzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzx_);
                CqlDateTime fzzzzzzzzze_ = context.Operators.Start(fzzzzzzzzzd_);
                CqlInterval<CqlDateTime> fzzzzzzzzzf_ = context.Operators.Interval(fzzzzzzzzzb_, fzzzzzzzzze_, true, true);
                bool? fzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzw_, fzzzzzzzzzf_, default);
                CqlInterval<CqlDateTime> fzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzx_);
                CqlDateTime fzzzzzzzzzj_ = context.Operators.Start(fzzzzzzzzzi_);
                bool? fzzzzzzzzzk_ = context.Operators.Not((bool?)(fzzzzzzzzzj_ is null));
                bool? fzzzzzzzzzl_ = context.Operators.And(fzzzzzzzzzg_, fzzzzzzzzzk_);
                bool? fzzzzzzzzzm_ = context.Operators.And(ezzzzzzzzzt_, fzzzzzzzzzl_);

                return fzzzzzzzzzm_;
            };
            IEnumerable<Encounter> yzzzzzzzzy_ = context.Operators.Where<Encounter>(yzzzzzzzzw_, yzzzzzzzzx_);
            object yzzzzzzzzz_(Encounter @this)
            {
                Period fzzzzzzzzzn_ = @this?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzn_);
                CqlDateTime fzzzzzzzzzp_ = context.Operators.End(fzzzzzzzzzo_);

                return fzzzzzzzzzp_;
            };
            IEnumerable<Encounter> zzzzzzzzza_ = context.Operators.SortBy<Encounter>(yzzzzzzzzy_, yzzzzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter zzzzzzzzzb_ = context.Operators.Last<Encounter>(zzzzzzzzza_);
            Period zzzzzzzzzc_ = zzzzzzzzzb_?.Period;
            CqlInterval<CqlDateTime> zzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzc_);
            CqlDateTime zzzzzzzzze_ = context.Operators.Start(zzzzzzzzzd_);
            Period zzzzzzzzzf_ = Visit?.Period;
            CqlInterval<CqlDateTime> zzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzf_);
            CqlDateTime zzzzzzzzzh_ = context.Operators.Start(zzzzzzzzzg_);
            CqlInterval<CqlDateTime> zzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzf_);
            CqlDateTime zzzzzzzzzk_ = context.Operators.End(zzzzzzzzzj_);
            CqlInterval<CqlDateTime> zzzzzzzzzl_ = context.Operators.Interval(yzzzzzzzzu_ ?? zzzzzzzzze_ ?? zzzzzzzzzh_, zzzzzzzzzk_, true, true);

            return zzzzzzzzzl_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzi_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)yzzzzzzzzg_, yzzzzzzzzh_);
        IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzj_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(yzzzzzzzzi_);
        CqlInterval<CqlDateTime> yzzzzzzzzk_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(yzzzzzzzzj_);

        return yzzzzzzzzk_;
    }


    [CqlExpressionDefinition("hospitalizationWithObservation")]
    [CqlTag("description", "Hospitalization with Observation returns the total interval from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    public CqlInterval<CqlDateTime> hospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] fzzzzzzzzzq_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> fzzzzzzzzzr_(Encounter Visit)
        {
            CqlValueSet fzzzzzzzzzv_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> fzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? fzzzzzzzzzx_(Encounter LastED)
            {
                Code<Encounter.EncounterStatus> gzzzzzzzzzw_ = LastED?.StatusElement;
                Encounter.EncounterStatus? gzzzzzzzzzx_ = gzzzzzzzzzw_?.Value;
                Code<Encounter.EncounterStatus> gzzzzzzzzzy_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gzzzzzzzzzx_);
                bool? gzzzzzzzzzz_ = context.Operators.Equal(gzzzzzzzzzy_, "finished");
                Period hzzzzzzzzza_ = LastED?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzza_);
                CqlDateTime hzzzzzzzzzc_ = context.Operators.End(hzzzzzzzzzb_);
                CqlValueSet hzzzzzzzzzd_ = this.Observation_Services(context);
                IEnumerable<Encounter> hzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? hzzzzzzzzzf_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> izzzzzzzzzx_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? izzzzzzzzzy_ = izzzzzzzzzx_?.Value;
                    Code<Encounter.EncounterStatus> izzzzzzzzzz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(izzzzzzzzzy_);
                    bool? jzzzzzzzzza_ = context.Operators.Equal(izzzzzzzzzz_, "finished");
                    Period jzzzzzzzzzb_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzb_);
                    CqlDateTime jzzzzzzzzzd_ = context.Operators.End(jzzzzzzzzzc_);
                    Period jzzzzzzzzze_ = Visit?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzze_);
                    CqlDateTime jzzzzzzzzzg_ = context.Operators.Start(jzzzzzzzzzf_);
                    CqlQuantity jzzzzzzzzzh_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime jzzzzzzzzzi_ = context.Operators.Subtract(jzzzzzzzzzg_, jzzzzzzzzzh_);
                    CqlInterval<CqlDateTime> jzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzze_);
                    CqlDateTime jzzzzzzzzzl_ = context.Operators.Start(jzzzzzzzzzk_);
                    CqlInterval<CqlDateTime> jzzzzzzzzzm_ = context.Operators.Interval(jzzzzzzzzzi_, jzzzzzzzzzl_, true, true);
                    bool? jzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzd_, jzzzzzzzzzm_, default);
                    CqlInterval<CqlDateTime> jzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzze_);
                    CqlDateTime jzzzzzzzzzq_ = context.Operators.Start(jzzzzzzzzzp_);
                    bool? jzzzzzzzzzr_ = context.Operators.Not((bool?)(jzzzzzzzzzq_ is null));
                    bool? jzzzzzzzzzs_ = context.Operators.And(jzzzzzzzzzn_, jzzzzzzzzzr_);
                    bool? jzzzzzzzzzt_ = context.Operators.And(jzzzzzzzzza_, jzzzzzzzzzs_);

                    return jzzzzzzzzzt_;
                };
                IEnumerable<Encounter> hzzzzzzzzzg_ = context.Operators.Where<Encounter>(hzzzzzzzzze_, hzzzzzzzzzf_);
                object hzzzzzzzzzh_(Encounter @this)
                {
                    Period jzzzzzzzzzu_ = @this?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzu_);
                    CqlDateTime jzzzzzzzzzw_ = context.Operators.End(jzzzzzzzzzv_);

                    return jzzzzzzzzzw_;
                };
                IEnumerable<Encounter> hzzzzzzzzzi_ = context.Operators.SortBy<Encounter>(hzzzzzzzzzg_, hzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter hzzzzzzzzzj_ = context.Operators.Last<Encounter>(hzzzzzzzzzi_);
                Period hzzzzzzzzzk_ = hzzzzzzzzzj_?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzk_);
                CqlDateTime hzzzzzzzzzm_ = context.Operators.Start(hzzzzzzzzzl_);
                Period hzzzzzzzzzn_ = Visit?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzn_);
                CqlDateTime hzzzzzzzzzp_ = context.Operators.Start(hzzzzzzzzzo_);
                CqlQuantity hzzzzzzzzzq_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime hzzzzzzzzzr_ = context.Operators.Subtract(hzzzzzzzzzm_ ?? hzzzzzzzzzp_, hzzzzzzzzzq_);
                IEnumerable<Encounter> hzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? hzzzzzzzzzu_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> jzzzzzzzzzx_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? jzzzzzzzzzy_ = jzzzzzzzzzx_?.Value;
                    Code<Encounter.EncounterStatus> jzzzzzzzzzz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jzzzzzzzzzy_);
                    bool? kzzzzzzzzza_ = context.Operators.Equal(jzzzzzzzzzz_, "finished");
                    Period kzzzzzzzzzb_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> kzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzb_);
                    CqlDateTime kzzzzzzzzzd_ = context.Operators.End(kzzzzzzzzzc_);
                    Period kzzzzzzzzze_ = Visit?.Period;
                    CqlInterval<CqlDateTime> kzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzze_);
                    CqlDateTime kzzzzzzzzzg_ = context.Operators.Start(kzzzzzzzzzf_);
                    CqlQuantity kzzzzzzzzzh_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime kzzzzzzzzzi_ = context.Operators.Subtract(kzzzzzzzzzg_, kzzzzzzzzzh_);
                    CqlInterval<CqlDateTime> kzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzze_);
                    CqlDateTime kzzzzzzzzzl_ = context.Operators.Start(kzzzzzzzzzk_);
                    CqlInterval<CqlDateTime> kzzzzzzzzzm_ = context.Operators.Interval(kzzzzzzzzzi_, kzzzzzzzzzl_, true, true);
                    bool? kzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzd_, kzzzzzzzzzm_, default);
                    CqlInterval<CqlDateTime> kzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzze_);
                    CqlDateTime kzzzzzzzzzq_ = context.Operators.Start(kzzzzzzzzzp_);
                    bool? kzzzzzzzzzr_ = context.Operators.Not((bool?)(kzzzzzzzzzq_ is null));
                    bool? kzzzzzzzzzs_ = context.Operators.And(kzzzzzzzzzn_, kzzzzzzzzzr_);
                    bool? kzzzzzzzzzt_ = context.Operators.And(kzzzzzzzzza_, kzzzzzzzzzs_);

                    return kzzzzzzzzzt_;
                };
                IEnumerable<Encounter> hzzzzzzzzzv_ = context.Operators.Where<Encounter>(hzzzzzzzzzt_, hzzzzzzzzzu_);
                object hzzzzzzzzzw_(Encounter @this)
                {
                    Period kzzzzzzzzzu_ = @this?.Period;
                    CqlInterval<CqlDateTime> kzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzu_);
                    CqlDateTime kzzzzzzzzzw_ = context.Operators.End(kzzzzzzzzzv_);

                    return kzzzzzzzzzw_;
                };
                IEnumerable<Encounter> hzzzzzzzzzx_ = context.Operators.SortBy<Encounter>(hzzzzzzzzzv_, hzzzzzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter hzzzzzzzzzy_ = context.Operators.Last<Encounter>(hzzzzzzzzzx_);
                Period hzzzzzzzzzz_ = hzzzzzzzzzy_?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzz_);
                CqlDateTime izzzzzzzzzb_ = context.Operators.Start(izzzzzzzzza_);
                CqlInterval<CqlDateTime> izzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzn_);
                CqlDateTime izzzzzzzzze_ = context.Operators.Start(izzzzzzzzzd_);
                CqlInterval<CqlDateTime> izzzzzzzzzf_ = context.Operators.Interval(hzzzzzzzzzr_, izzzzzzzzzb_ ?? izzzzzzzzze_, true, true);
                bool? izzzzzzzzzg_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzc_, izzzzzzzzzf_, default);
                IEnumerable<Encounter> izzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? izzzzzzzzzj_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> kzzzzzzzzzx_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? kzzzzzzzzzy_ = kzzzzzzzzzx_?.Value;
                    Code<Encounter.EncounterStatus> kzzzzzzzzzz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(kzzzzzzzzzy_);
                    bool? lzzzzzzzzza_ = context.Operators.Equal(kzzzzzzzzzz_, "finished");
                    Period lzzzzzzzzzb_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> lzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzb_);
                    CqlDateTime lzzzzzzzzzd_ = context.Operators.End(lzzzzzzzzzc_);
                    Period lzzzzzzzzze_ = Visit?.Period;
                    CqlInterval<CqlDateTime> lzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzze_);
                    CqlDateTime lzzzzzzzzzg_ = context.Operators.Start(lzzzzzzzzzf_);
                    CqlQuantity lzzzzzzzzzh_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime lzzzzzzzzzi_ = context.Operators.Subtract(lzzzzzzzzzg_, lzzzzzzzzzh_);
                    CqlInterval<CqlDateTime> lzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzze_);
                    CqlDateTime lzzzzzzzzzl_ = context.Operators.Start(lzzzzzzzzzk_);
                    CqlInterval<CqlDateTime> lzzzzzzzzzm_ = context.Operators.Interval(lzzzzzzzzzi_, lzzzzzzzzzl_, true, true);
                    bool? lzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzd_, lzzzzzzzzzm_, default);
                    CqlInterval<CqlDateTime> lzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzze_);
                    CqlDateTime lzzzzzzzzzq_ = context.Operators.Start(lzzzzzzzzzp_);
                    bool? lzzzzzzzzzr_ = context.Operators.Not((bool?)(lzzzzzzzzzq_ is null));
                    bool? lzzzzzzzzzs_ = context.Operators.And(lzzzzzzzzzn_, lzzzzzzzzzr_);
                    bool? lzzzzzzzzzt_ = context.Operators.And(lzzzzzzzzza_, lzzzzzzzzzs_);

                    return lzzzzzzzzzt_;
                };
                IEnumerable<Encounter> izzzzzzzzzk_ = context.Operators.Where<Encounter>(izzzzzzzzzi_, izzzzzzzzzj_);
                object izzzzzzzzzl_(Encounter @this)
                {
                    Period lzzzzzzzzzu_ = @this?.Period;
                    CqlInterval<CqlDateTime> lzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzu_);
                    CqlDateTime lzzzzzzzzzw_ = context.Operators.End(lzzzzzzzzzv_);

                    return lzzzzzzzzzw_;
                };
                IEnumerable<Encounter> izzzzzzzzzm_ = context.Operators.SortBy<Encounter>(izzzzzzzzzk_, izzzzzzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter izzzzzzzzzn_ = context.Operators.Last<Encounter>(izzzzzzzzzm_);
                Period izzzzzzzzzo_ = izzzzzzzzzn_?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzo_);
                CqlDateTime izzzzzzzzzq_ = context.Operators.Start(izzzzzzzzzp_);
                CqlInterval<CqlDateTime> izzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzn_);
                CqlDateTime izzzzzzzzzt_ = context.Operators.Start(izzzzzzzzzs_);
                bool? izzzzzzzzzu_ = context.Operators.Not((bool?)((izzzzzzzzzq_ ?? izzzzzzzzzt_) is null));
                bool? izzzzzzzzzv_ = context.Operators.And(izzzzzzzzzg_, izzzzzzzzzu_);
                bool? izzzzzzzzzw_ = context.Operators.And(gzzzzzzzzzz_, izzzzzzzzzv_);

                return izzzzzzzzzw_;
            };
            IEnumerable<Encounter> fzzzzzzzzzy_ = context.Operators.Where<Encounter>(fzzzzzzzzzw_, fzzzzzzzzzx_);
            object fzzzzzzzzzz_(Encounter @this)
            {
                Period lzzzzzzzzzx_ = @this?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzx_);
                CqlDateTime lzzzzzzzzzz_ = context.Operators.End(lzzzzzzzzzy_);

                return lzzzzzzzzzz_;
            };
            IEnumerable<Encounter> gzzzzzzzzza_ = context.Operators.SortBy<Encounter>(fzzzzzzzzzy_, fzzzzzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter gzzzzzzzzzb_ = context.Operators.Last<Encounter>(gzzzzzzzzza_);
            Period gzzzzzzzzzc_ = gzzzzzzzzzb_?.Period;
            CqlInterval<CqlDateTime> gzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzc_);
            CqlDateTime gzzzzzzzzze_ = context.Operators.Start(gzzzzzzzzzd_);
            CqlValueSet gzzzzzzzzzf_ = this.Observation_Services(context);
            IEnumerable<Encounter> gzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? gzzzzzzzzzh_(Encounter LastObs)
            {
                Code<Encounter.EncounterStatus> mzzzzzzzzza_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? mzzzzzzzzzb_ = mzzzzzzzzza_?.Value;
                Code<Encounter.EncounterStatus> mzzzzzzzzzc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(mzzzzzzzzzb_);
                bool? mzzzzzzzzzd_ = context.Operators.Equal(mzzzzzzzzzc_, "finished");
                Period mzzzzzzzzze_ = LastObs?.Period;
                CqlInterval<CqlDateTime> mzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzze_);
                CqlDateTime mzzzzzzzzzg_ = context.Operators.End(mzzzzzzzzzf_);
                Period mzzzzzzzzzh_ = Visit?.Period;
                CqlInterval<CqlDateTime> mzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzh_);
                CqlDateTime mzzzzzzzzzj_ = context.Operators.Start(mzzzzzzzzzi_);
                CqlQuantity mzzzzzzzzzk_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime mzzzzzzzzzl_ = context.Operators.Subtract(mzzzzzzzzzj_, mzzzzzzzzzk_);
                CqlInterval<CqlDateTime> mzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzh_);
                CqlDateTime mzzzzzzzzzo_ = context.Operators.Start(mzzzzzzzzzn_);
                CqlInterval<CqlDateTime> mzzzzzzzzzp_ = context.Operators.Interval(mzzzzzzzzzl_, mzzzzzzzzzo_, true, true);
                bool? mzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzg_, mzzzzzzzzzp_, default);
                CqlInterval<CqlDateTime> mzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzh_);
                CqlDateTime mzzzzzzzzzt_ = context.Operators.Start(mzzzzzzzzzs_);
                bool? mzzzzzzzzzu_ = context.Operators.Not((bool?)(mzzzzzzzzzt_ is null));
                bool? mzzzzzzzzzv_ = context.Operators.And(mzzzzzzzzzq_, mzzzzzzzzzu_);
                bool? mzzzzzzzzzw_ = context.Operators.And(mzzzzzzzzzd_, mzzzzzzzzzv_);

                return mzzzzzzzzzw_;
            };
            IEnumerable<Encounter> gzzzzzzzzzi_ = context.Operators.Where<Encounter>(gzzzzzzzzzg_, gzzzzzzzzzh_);
            object gzzzzzzzzzj_(Encounter @this)
            {
                Period mzzzzzzzzzx_ = @this?.Period;
                CqlInterval<CqlDateTime> mzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzx_);
                CqlDateTime mzzzzzzzzzz_ = context.Operators.End(mzzzzzzzzzy_);

                return mzzzzzzzzzz_;
            };
            IEnumerable<Encounter> gzzzzzzzzzk_ = context.Operators.SortBy<Encounter>(gzzzzzzzzzi_, gzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter gzzzzzzzzzl_ = context.Operators.Last<Encounter>(gzzzzzzzzzk_);
            Period gzzzzzzzzzm_ = gzzzzzzzzzl_?.Period;
            CqlInterval<CqlDateTime> gzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzm_);
            CqlDateTime gzzzzzzzzzo_ = context.Operators.Start(gzzzzzzzzzn_);
            Period gzzzzzzzzzp_ = Visit?.Period;
            CqlInterval<CqlDateTime> gzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzp_);
            CqlDateTime gzzzzzzzzzr_ = context.Operators.Start(gzzzzzzzzzq_);
            CqlInterval<CqlDateTime> gzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzp_);
            CqlDateTime gzzzzzzzzzu_ = context.Operators.End(gzzzzzzzzzt_);
            CqlInterval<CqlDateTime> gzzzzzzzzzv_ = context.Operators.Interval(gzzzzzzzzze_ ?? gzzzzzzzzzo_ ?? gzzzzzzzzzr_, gzzzzzzzzzu_, true, true);

            return gzzzzzzzzzv_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> fzzzzzzzzzs_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)fzzzzzzzzzq_, fzzzzzzzzzr_);
        IEnumerable<CqlInterval<CqlDateTime>> fzzzzzzzzzt_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(fzzzzzzzzzs_);
        CqlInterval<CqlDateTime> fzzzzzzzzzu_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(fzzzzzzzzzt_);

        return fzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservationLengthofStay")]
    [CqlTag("description", "Hospitalization with Observation Length of Stay returns the length in days from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationWithObservationLengthofStay()` instead.")]
    public int? HospitalizationWithObservationLengthofStay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> nzzzzzzzzza_ = this.HospitalizationWithObservation(context, TheEncounter);
        int? nzzzzzzzzzb_ = this.LengthInDays(context, nzzzzzzzzza_);

        return nzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("hospitalizationWithObservationLengthofStay")]
    [CqlTag("description", "Hospitalization with Observation Length of Stay returns the length in days from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    public int? hospitalizationWithObservationLengthofStay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> nzzzzzzzzzc_ = this.hospitalizationWithObservation(context, TheEncounter);
        int? nzzzzzzzzzd_ = this.lengthInDays(context, nzzzzzzzzzc_);

        return nzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("FirstInpatientIntensiveCareUnit")]
    [CqlTag("description", "First Inpatient Intensive Care Unit returns the first intensive care unit for the given encounter, without considering any immediately prior emergency department visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `firstInpatientIntensiveCareUnit()` instead.")]
    public Encounter.LocationComponent FirstInpatientIntensiveCareUnit(CqlContext context, Encounter Encounter)
    {
        List<Encounter.LocationComponent> nzzzzzzzzze_ = Encounter?.Location;
        bool? nzzzzzzzzzf_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference nzzzzzzzzzk_ = HospitalLocation?.Location;
            Location nzzzzzzzzzl_ = this.GetLocation(context, nzzzzzzzzzk_);
            List<CodeableConcept> nzzzzzzzzzm_ = nzzzzzzzzzl_?.Type;
            CqlConcept nzzzzzzzzzn_(CodeableConcept @this)
            {
                CqlConcept nzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return nzzzzzzzzzx_;
            };
            IEnumerable<CqlConcept> nzzzzzzzzzo_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)nzzzzzzzzzm_, nzzzzzzzzzn_);
            CqlValueSet nzzzzzzzzzp_ = this.Intensive_Care_Unit(context);
            bool? nzzzzzzzzzq_ = context.Operators.ConceptsInValueSet(nzzzzzzzzzo_, nzzzzzzzzzp_);
            Period nzzzzzzzzzr_ = Encounter?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzr_);
            Period nzzzzzzzzzt_ = HospitalLocation?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzt_);
            bool? nzzzzzzzzzv_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(nzzzzzzzzzs_, nzzzzzzzzzu_, default);
            bool? nzzzzzzzzzw_ = context.Operators.And(nzzzzzzzzzq_, nzzzzzzzzzv_);

            return nzzzzzzzzzw_;
        };
        IEnumerable<Encounter.LocationComponent> nzzzzzzzzzg_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)nzzzzzzzzze_, nzzzzzzzzzf_);
        object nzzzzzzzzzh_(Encounter.LocationComponent @this)
        {
            Period nzzzzzzzzzy_ = @this?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzy_);
            CqlDateTime ozzzzzzzzza_ = context.Operators.Start(nzzzzzzzzzz_);

            return ozzzzzzzzza_;
        };
        IEnumerable<Encounter.LocationComponent> nzzzzzzzzzi_ = context.Operators.SortBy<Encounter.LocationComponent>(nzzzzzzzzzg_, nzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent nzzzzzzzzzj_ = context.Operators.First<Encounter.LocationComponent>(nzzzzzzzzzi_);

        return nzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("firstInpatientIntensiveCareUnit")]
    [CqlTag("description", "First Inpatient Intensive Care Unit returns the first intensive care unit for the given encounter, without considering any immediately prior emergency department visit.")]
    public Encounter.LocationComponent firstInpatientIntensiveCareUnit(CqlContext context, Encounter Encounter)
    {
        List<Encounter.LocationComponent> ozzzzzzzzzb_ = Encounter?.Location;
        bool? ozzzzzzzzzc_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference ozzzzzzzzzh_ = HospitalLocation?.Location;
            Location ozzzzzzzzzi_ = this.GetLocation(context, ozzzzzzzzzh_);
            List<CodeableConcept> ozzzzzzzzzj_ = ozzzzzzzzzi_?.Type;
            CqlConcept ozzzzzzzzzk_(CodeableConcept @this)
            {
                CqlConcept ozzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return ozzzzzzzzzu_;
            };
            IEnumerable<CqlConcept> ozzzzzzzzzl_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ozzzzzzzzzj_, ozzzzzzzzzk_);
            CqlValueSet ozzzzzzzzzm_ = this.Intensive_Care_Unit(context);
            bool? ozzzzzzzzzn_ = context.Operators.ConceptsInValueSet(ozzzzzzzzzl_, ozzzzzzzzzm_);
            Period ozzzzzzzzzo_ = Encounter?.Period;
            CqlInterval<CqlDateTime> ozzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzo_);
            Period ozzzzzzzzzq_ = HospitalLocation?.Period;
            CqlInterval<CqlDateTime> ozzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzq_);
            bool? ozzzzzzzzzs_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ozzzzzzzzzp_, ozzzzzzzzzr_, default);
            bool? ozzzzzzzzzt_ = context.Operators.And(ozzzzzzzzzn_, ozzzzzzzzzs_);

            return ozzzzzzzzzt_;
        };
        IEnumerable<Encounter.LocationComponent> ozzzzzzzzzd_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)ozzzzzzzzzb_, ozzzzzzzzzc_);
        object ozzzzzzzzze_(Encounter.LocationComponent @this)
        {
            Period ozzzzzzzzzv_ = @this?.Period;
            CqlInterval<CqlDateTime> ozzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzv_);
            CqlDateTime ozzzzzzzzzx_ = context.Operators.Start(ozzzzzzzzzw_);

            return ozzzzzzzzzx_;
        };
        IEnumerable<Encounter.LocationComponent> ozzzzzzzzzf_ = context.Operators.SortBy<Encounter.LocationComponent>(ozzzzzzzzzd_, ozzzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent ozzzzzzzzzg_ = context.Operators.First<Encounter.LocationComponent>(ozzzzzzzzzf_);

        return ozzzzzzzzzg_;
    }


    [CqlExpressionDefinition("EncounterDiagnosis")]
    [CqlTag("description", "Returns the Condition resource referenced by the `diagnosis.condition` element of the Encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `encounterDiagnosis()` instead.")]
    public IEnumerable<Condition> EncounterDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> ozzzzzzzzzy_ = Encounter?.Diagnosis;
        Condition ozzzzzzzzzz_(Encounter.DiagnosisComponent D)
        {
            IEnumerable<Condition> pzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? pzzzzzzzzzd_(Condition C)
            {
                Id pzzzzzzzzzg_ = C?.IdElement;
                string pzzzzzzzzzh_ = pzzzzzzzzzg_?.Value;
                ResourceReference pzzzzzzzzzi_ = D?.Condition;
                FhirString pzzzzzzzzzj_ = pzzzzzzzzzi_?.ReferenceElement;
                string pzzzzzzzzzk_ = pzzzzzzzzzj_?.Value;
                string pzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.getId(context, pzzzzzzzzzk_);
                bool? pzzzzzzzzzm_ = context.Operators.Equal(pzzzzzzzzzh_, pzzzzzzzzzl_);

                return pzzzzzzzzzm_;
            };
            IEnumerable<Condition> pzzzzzzzzze_ = context.Operators.Where<Condition>(pzzzzzzzzzc_, pzzzzzzzzzd_);
            Condition pzzzzzzzzzf_ = context.Operators.SingletonFrom<Condition>(pzzzzzzzzze_);

            return pzzzzzzzzzf_;
        };
        IEnumerable<Condition> pzzzzzzzzza_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)ozzzzzzzzzy_, ozzzzzzzzzz_);
        IEnumerable<Condition> pzzzzzzzzzb_ = context.Operators.Distinct<Condition>(pzzzzzzzzza_);

        return pzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("encounterDiagnosis")]
    [CqlTag("description", "Returns the Condition resources referenced by the diagnosis element of the Encounter")]
    public IEnumerable<Condition> encounterDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> pzzzzzzzzzn_ = Encounter?.Diagnosis;
        Condition pzzzzzzzzzo_(Encounter.DiagnosisComponent D)
        {
            IEnumerable<Condition> pzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? pzzzzzzzzzs_(Condition C)
            {
                Id pzzzzzzzzzv_ = C?.IdElement;
                string pzzzzzzzzzw_ = pzzzzzzzzzv_?.Value;
                ResourceReference pzzzzzzzzzx_ = D?.Condition;
                FhirString pzzzzzzzzzy_ = pzzzzzzzzzx_?.ReferenceElement;
                string pzzzzzzzzzz_ = pzzzzzzzzzy_?.Value;
                string qzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.getId(context, pzzzzzzzzzz_);
                bool? qzzzzzzzzzb_ = context.Operators.Equal(pzzzzzzzzzw_, qzzzzzzzzza_);

                return qzzzzzzzzzb_;
            };
            IEnumerable<Condition> pzzzzzzzzzt_ = context.Operators.Where<Condition>(pzzzzzzzzzr_, pzzzzzzzzzs_);
            Condition pzzzzzzzzzu_ = context.Operators.SingletonFrom<Condition>(pzzzzzzzzzt_);

            return pzzzzzzzzzu_;
        };
        IEnumerable<Condition> pzzzzzzzzzp_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)pzzzzzzzzzn_, pzzzzzzzzzo_);
        IEnumerable<Condition> pzzzzzzzzzq_ = context.Operators.Distinct<Condition>(pzzzzzzzzzp_);

        return pzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("GetCondition")]
    [CqlTag("description", "Returns the Condition resource for the given reference")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getCondition()` instead")]
    public Condition GetCondition(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Condition> qzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? qzzzzzzzzzd_(Condition C)
        {
            Id qzzzzzzzzzg_ = C?.IdElement;
            string qzzzzzzzzzh_ = qzzzzzzzzzg_?.Value;
            FhirString qzzzzzzzzzi_ = reference?.ReferenceElement;
            string qzzzzzzzzzj_ = qzzzzzzzzzi_?.Value;
            string qzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.getId(context, qzzzzzzzzzj_);
            bool? qzzzzzzzzzl_ = context.Operators.Equal(qzzzzzzzzzh_, qzzzzzzzzzk_);

            return qzzzzzzzzzl_;
        };
        IEnumerable<Condition> qzzzzzzzzze_ = context.Operators.Where<Condition>(qzzzzzzzzzc_, qzzzzzzzzzd_);
        Condition qzzzzzzzzzf_ = context.Operators.SingletonFrom<Condition>(qzzzzzzzzze_);

        return qzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("getCondition")]
    [CqlTag("description", "Returns the Condition resource for the given reference")]
    public Condition getCondition(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Condition> qzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? qzzzzzzzzzn_(Condition C)
        {
            Id qzzzzzzzzzq_ = C?.IdElement;
            string qzzzzzzzzzr_ = qzzzzzzzzzq_?.Value;
            FhirString qzzzzzzzzzs_ = reference?.ReferenceElement;
            string qzzzzzzzzzt_ = qzzzzzzzzzs_?.Value;
            string qzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.getId(context, qzzzzzzzzzt_);
            bool? qzzzzzzzzzv_ = context.Operators.Equal(qzzzzzzzzzr_, qzzzzzzzzzu_);

            return qzzzzzzzzzv_;
        };
        IEnumerable<Condition> qzzzzzzzzzo_ = context.Operators.Where<Condition>(qzzzzzzzzzm_, qzzzzzzzzzn_);
        Condition qzzzzzzzzzp_ = context.Operators.SingletonFrom<Condition>(qzzzzzzzzzo_);

        return qzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("PrincipalDiagnosis")]
    [CqlTag("description", "Returns the condition that is specified as the principal diagnosis for the encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `principalDiagnosis()` instead.")]
    public Condition PrincipalDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> qzzzzzzzzzw_ = Encounter?.Diagnosis;
        bool? qzzzzzzzzzx_(Encounter.DiagnosisComponent D)
        {
            PositiveInt rzzzzzzzzzd_ = D?.RankElement;
            int? rzzzzzzzzze_ = rzzzzzzzzzd_?.Value;
            bool? rzzzzzzzzzf_ = context.Operators.Equal(rzzzzzzzzze_, 1);
            CodeableConcept rzzzzzzzzzg_ = D?.Use;
            CqlConcept rzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, rzzzzzzzzzg_);
            CqlCode rzzzzzzzzzi_ = this.Billing(context);
            CqlConcept rzzzzzzzzzj_ = context.Operators.ConvertCodeToConcept(rzzzzzzzzzi_);
            bool? rzzzzzzzzzk_ = context.Operators.Equivalent(rzzzzzzzzzh_, rzzzzzzzzzj_);
            bool? rzzzzzzzzzl_ = context.Operators.And(rzzzzzzzzzf_, rzzzzzzzzzk_);

            return rzzzzzzzzzl_;
        };
        IEnumerable<Encounter.DiagnosisComponent> qzzzzzzzzzy_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)qzzzzzzzzzw_, qzzzzzzzzzx_);
        Condition qzzzzzzzzzz_(Encounter.DiagnosisComponent PD)
        {
            IEnumerable<Condition> rzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? rzzzzzzzzzn_(Condition C)
            {
                Id rzzzzzzzzzq_ = C?.IdElement;
                string rzzzzzzzzzr_ = rzzzzzzzzzq_?.Value;
                ResourceReference rzzzzzzzzzs_ = PD?.Condition;
                FhirString rzzzzzzzzzt_ = rzzzzzzzzzs_?.ReferenceElement;
                string rzzzzzzzzzu_ = rzzzzzzzzzt_?.Value;
                string rzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.getId(context, rzzzzzzzzzu_);
                bool? rzzzzzzzzzw_ = context.Operators.Equal(rzzzzzzzzzr_, rzzzzzzzzzv_);

                return rzzzzzzzzzw_;
            };
            IEnumerable<Condition> rzzzzzzzzzo_ = context.Operators.Where<Condition>(rzzzzzzzzzm_, rzzzzzzzzzn_);
            Condition rzzzzzzzzzp_ = context.Operators.SingletonFrom<Condition>(rzzzzzzzzzo_);

            return rzzzzzzzzzp_;
        };
        IEnumerable<Condition> rzzzzzzzzza_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>(qzzzzzzzzzy_, qzzzzzzzzzz_);
        IEnumerable<Condition> rzzzzzzzzzb_ = context.Operators.Distinct<Condition>(rzzzzzzzzza_);
        Condition rzzzzzzzzzc_ = context.Operators.SingletonFrom<Condition>(rzzzzzzzzzb_);

        return rzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("principalDiagnosis")]
    [CqlTag("description", "Returns the condition that is specified as the principal diagnosis for the encounter")]
    public Condition principalDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> rzzzzzzzzzx_ = Encounter?.Diagnosis;
        bool? rzzzzzzzzzy_(Encounter.DiagnosisComponent D)
        {
            PositiveInt szzzzzzzzze_ = D?.RankElement;
            int? szzzzzzzzzf_ = szzzzzzzzze_?.Value;
            bool? szzzzzzzzzg_ = context.Operators.Equal(szzzzzzzzzf_, 1);
            CodeableConcept szzzzzzzzzh_ = D?.Use;
            CqlConcept szzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, szzzzzzzzzh_);
            CqlCode szzzzzzzzzj_ = this.Billing(context);
            CqlConcept szzzzzzzzzk_ = context.Operators.ConvertCodeToConcept(szzzzzzzzzj_);
            bool? szzzzzzzzzl_ = context.Operators.Equivalent(szzzzzzzzzi_, szzzzzzzzzk_);
            bool? szzzzzzzzzm_ = context.Operators.And(szzzzzzzzzg_, szzzzzzzzzl_);

            return szzzzzzzzzm_;
        };
        IEnumerable<Encounter.DiagnosisComponent> rzzzzzzzzzz_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)rzzzzzzzzzx_, rzzzzzzzzzy_);
        Condition szzzzzzzzza_(Encounter.DiagnosisComponent PD)
        {
            IEnumerable<Condition> szzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? szzzzzzzzzo_(Condition C)
            {
                Id szzzzzzzzzr_ = C?.IdElement;
                string szzzzzzzzzs_ = szzzzzzzzzr_?.Value;
                ResourceReference szzzzzzzzzt_ = PD?.Condition;
                FhirString szzzzzzzzzu_ = szzzzzzzzzt_?.ReferenceElement;
                string szzzzzzzzzv_ = szzzzzzzzzu_?.Value;
                string szzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.getId(context, szzzzzzzzzv_);
                bool? szzzzzzzzzx_ = context.Operators.Equal(szzzzzzzzzs_, szzzzzzzzzw_);

                return szzzzzzzzzx_;
            };
            IEnumerable<Condition> szzzzzzzzzp_ = context.Operators.Where<Condition>(szzzzzzzzzn_, szzzzzzzzzo_);
            Condition szzzzzzzzzq_ = context.Operators.SingletonFrom<Condition>(szzzzzzzzzp_);

            return szzzzzzzzzq_;
        };
        IEnumerable<Condition> szzzzzzzzzb_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>(rzzzzzzzzzz_, szzzzzzzzza_);
        IEnumerable<Condition> szzzzzzzzzc_ = context.Operators.Distinct<Condition>(szzzzzzzzzb_);
        Condition szzzzzzzzzd_ = context.Operators.SingletonFrom<Condition>(szzzzzzzzzc_);

        return szzzzzzzzzd_;
    }


    [CqlExpressionDefinition("getLocation")]
    [CqlTag("description", "Returns the Location resource specified by the given reference.")]
    public Location getLocation(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Location> szzzzzzzzzy_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-location"));
        bool? szzzzzzzzzz_(Location L)
        {
            Id tzzzzzzzzzc_ = L?.IdElement;
            string tzzzzzzzzzd_ = tzzzzzzzzzc_?.Value;
            FhirString tzzzzzzzzze_ = reference?.ReferenceElement;
            string tzzzzzzzzzf_ = tzzzzzzzzze_?.Value;
            string tzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.getId(context, tzzzzzzzzzf_);
            bool? tzzzzzzzzzh_ = context.Operators.Equal(tzzzzzzzzzd_, tzzzzzzzzzg_);

            return tzzzzzzzzzh_;
        };
        IEnumerable<Location> tzzzzzzzzza_ = context.Operators.Where<Location>(szzzzzzzzzy_, szzzzzzzzzz_);
        Location tzzzzzzzzzb_ = context.Operators.SingletonFrom<Location>(tzzzzzzzzza_);

        return tzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("GetMedicationCode")]
    [CqlTag("description", "Returns the medication code for the given MedicationRequest")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getMedicationCode()` instead.")]
    public CqlConcept GetMedicationCode(CqlContext context, MedicationRequest request)
    {
        CqlConcept tzzzzzzzzzi_()
        {
            bool tzzzzzzzzzj_()
            {
                DataType tzzzzzzzzzk_ = request?.Medication;
                object tzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzk_);
                bool tzzzzzzzzzm_ = tzzzzzzzzzl_ is CqlConcept;

                return tzzzzzzzzzm_;
            };
            if (tzzzzzzzzzj_())
            {
                DataType tzzzzzzzzzn_ = request?.Medication;
                object tzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzn_);

                return tzzzzzzzzzo_ as CqlConcept;
            }
            else
            {
                IEnumerable<Medication> tzzzzzzzzzp_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? tzzzzzzzzzq_(Medication M)
                {
                    Id tzzzzzzzzzv_ = M?.IdElement;
                    string tzzzzzzzzzw_ = tzzzzzzzzzv_?.Value;
                    DataType tzzzzzzzzzx_ = request?.Medication;
                    object tzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzx_);
                    FhirString tzzzzzzzzzz_ = (tzzzzzzzzzy_ as ResourceReference)?.ReferenceElement;
                    string uzzzzzzzzza_ = tzzzzzzzzzz_?.Value;
                    string uzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.getId(context, uzzzzzzzzza_);
                    bool? uzzzzzzzzzc_ = context.Operators.Equal(tzzzzzzzzzw_, uzzzzzzzzzb_);

                    return uzzzzzzzzzc_;
                };
                IEnumerable<Medication> tzzzzzzzzzr_ = context.Operators.Where<Medication>(tzzzzzzzzzp_, tzzzzzzzzzq_);
                Medication tzzzzzzzzzs_ = context.Operators.SingletonFrom<Medication>(tzzzzzzzzzr_);
                CodeableConcept tzzzzzzzzzt_ = tzzzzzzzzzs_?.Code;
                CqlConcept tzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, tzzzzzzzzzt_);

                return tzzzzzzzzzu_;
            }
        };

        return tzzzzzzzzzi_();
    }


    [CqlExpressionDefinition("getMedicationCode")]
    [CqlTag("description", "Returns the medication code for the given MedicationRequest")]
    public CqlConcept getMedicationCode(CqlContext context, MedicationRequest request)
    {
        CqlConcept uzzzzzzzzzd_()
        {
            bool uzzzzzzzzze_()
            {
                DataType uzzzzzzzzzf_ = request?.Medication;
                object uzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzf_);
                bool uzzzzzzzzzh_ = uzzzzzzzzzg_ is CqlConcept;

                return uzzzzzzzzzh_;
            };
            if (uzzzzzzzzze_())
            {
                DataType uzzzzzzzzzi_ = request?.Medication;
                object uzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzi_);

                return uzzzzzzzzzj_ as CqlConcept;
            }
            else
            {
                IEnumerable<Medication> uzzzzzzzzzk_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? uzzzzzzzzzl_(Medication M)
                {
                    Id uzzzzzzzzzq_ = M?.IdElement;
                    string uzzzzzzzzzr_ = uzzzzzzzzzq_?.Value;
                    DataType uzzzzzzzzzs_ = request?.Medication;
                    object uzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzs_);
                    FhirString uzzzzzzzzzu_ = (uzzzzzzzzzt_ as ResourceReference)?.ReferenceElement;
                    string uzzzzzzzzzv_ = uzzzzzzzzzu_?.Value;
                    string uzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.getId(context, uzzzzzzzzzv_);
                    bool? uzzzzzzzzzx_ = context.Operators.Equal(uzzzzzzzzzr_, uzzzzzzzzzw_);

                    return uzzzzzzzzzx_;
                };
                IEnumerable<Medication> uzzzzzzzzzm_ = context.Operators.Where<Medication>(uzzzzzzzzzk_, uzzzzzzzzzl_);
                Medication uzzzzzzzzzn_ = context.Operators.SingletonFrom<Medication>(uzzzzzzzzzm_);
                CodeableConcept uzzzzzzzzzo_ = uzzzzzzzzzn_?.Code;
                CqlConcept uzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzo_);

                return uzzzzzzzzzp_;
            }
        };

        return uzzzzzzzzzd_();
    }


    #endregion Expressions

}
