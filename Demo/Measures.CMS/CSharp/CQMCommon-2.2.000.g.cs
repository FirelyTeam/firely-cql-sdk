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
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/diagnosis-role", null, [
          _Billing]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime gzzzzzx_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime gzzzzzy_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> gzzzzzz_ = context.Operators.Interval(gzzzzzx_, gzzzzzy_, true, false);
        object hzzzzza_ = context.ResolveParameter("CQMCommon-2.2.000", "Measurement Period", gzzzzzz_);

        return (CqlInterval<CqlDateTime>)hzzzzza_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> hzzzzzb_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient hzzzzzc_ = context.Operators.SingletonFrom<Patient>(hzzzzzb_);

        return hzzzzzc_;
    }


    [CqlExpressionDefinition("Inpatient Encounter")]
    public IEnumerable<Encounter> Inpatient_Encounter(CqlContext context)
    {
        CqlValueSet hzzzzzd_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> hzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? hzzzzzf_(Encounter EncounterInpatient)
        {
            Code<Encounter.EncounterStatus> hzzzzzh_ = EncounterInpatient?.StatusElement;
            Encounter.EncounterStatus? hzzzzzi_ = hzzzzzh_?.Value;
            Code<Encounter.EncounterStatus> hzzzzzj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hzzzzzi_);
            bool? hzzzzzk_ = context.Operators.Equal(hzzzzzj_, "finished");
            Period hzzzzzl_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime> hzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzl_);
            CqlDateTime hzzzzzn_ = context.Operators.End(hzzzzzm_);
            CqlInterval<CqlDateTime> hzzzzzo_ = this.Measurement_Period(context);
            bool? hzzzzzp_ = context.Operators.In<CqlDateTime>(hzzzzzn_, hzzzzzo_, "day");
            bool? hzzzzzq_ = context.Operators.And(hzzzzzk_, hzzzzzp_);

            return hzzzzzq_;
        };
        IEnumerable<Encounter> hzzzzzg_ = context.Operators.Where<Encounter>(hzzzzze_, hzzzzzf_);

        return hzzzzzg_;
    }


    [CqlExpressionDefinition("ToDateInterval")]
    [CqlTag("description", "Returns an interval of date values extracted from the input interval of date-time values")]
    [CqlTag("comment", "This function returns an interval constructed using the `date from` extractor on the start\nand end values of the input date-time interval. Note that using a precision specifier such as `day of`\nas part of a timing phrase is preferred to communicate intent to perform day-level comparison, as well\nas for general readability.")]
    public CqlInterval<CqlDate> ToDateInterval(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime hzzzzzr_ = context.Operators.Start(period);
        CqlDate hzzzzzs_ = context.Operators.DateFrom(hzzzzzr_);
        CqlDateTime hzzzzzt_ = context.Operators.End(period);
        CqlDate hzzzzzu_ = context.Operators.DateFrom(hzzzzzt_);
        CqlInterval<CqlDate> hzzzzzv_ = context.Operators.Interval(hzzzzzs_, hzzzzzu_, true, true);

        return hzzzzzv_;
    }


    [CqlExpressionDefinition("LengthInDays")]
    [CqlTag("description", "Calculates the difference in calendar days between the start and end of the given interval.")]
    [CqlTag("deprecated", "This function in deprecated. Use the fluent function `lengthInDays()` instead.")]
    public int? LengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
    {
        CqlDateTime hzzzzzw_ = context.Operators.Start(Value);
        CqlDateTime hzzzzzx_ = context.Operators.End(Value);
        int? hzzzzzy_ = context.Operators.DifferenceBetween(hzzzzzw_, hzzzzzx_, "day");

        return hzzzzzy_;
    }


    [CqlExpressionDefinition("lengthInDays")]
    [CqlTag("description", "Calculates the difference in calendar days between the start and end of the given interval.")]
    public int? lengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
    {
        CqlDateTime hzzzzzz_ = context.Operators.Start(Value);
        CqlDateTime izzzzza_ = context.Operators.End(Value);
        int? izzzzzb_ = context.Operators.DifferenceBetween(hzzzzzz_, izzzzza_, "day");

        return izzzzzb_;
    }


    [CqlExpressionDefinition("ED Visit")]
    [CqlTag("description", "Returns the most recent emergency department visit, if any, that occurs 1 hour or less prior to the given encounter.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `edVisit()` instead.")]
    public Encounter ED_Visit(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet izzzzzc_ = this.Emergency_Department_Visit(context);
        IEnumerable<Encounter> izzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? izzzzze_(Encounter EDVisit)
        {
            Code<Encounter.EncounterStatus> izzzzzj_ = EDVisit?.StatusElement;
            Encounter.EncounterStatus? izzzzzk_ = izzzzzj_?.Value;
            Code<Encounter.EncounterStatus> izzzzzl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(izzzzzk_);
            bool? izzzzzm_ = context.Operators.Equal(izzzzzl_, "finished");
            Period izzzzzn_ = EDVisit?.Period;
            CqlInterval<CqlDateTime> izzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzn_);
            CqlDateTime izzzzzp_ = context.Operators.End(izzzzzo_);
            Period izzzzzq_ = TheEncounter?.Period;
            CqlInterval<CqlDateTime> izzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzq_);
            CqlDateTime izzzzzs_ = context.Operators.Start(izzzzzr_);
            CqlQuantity izzzzzt_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime izzzzzu_ = context.Operators.Subtract(izzzzzs_, izzzzzt_);
            CqlInterval<CqlDateTime> izzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzq_);
            CqlDateTime izzzzzx_ = context.Operators.Start(izzzzzw_);
            CqlInterval<CqlDateTime> izzzzzy_ = context.Operators.Interval(izzzzzu_, izzzzzx_, true, true);
            bool? izzzzzz_ = context.Operators.In<CqlDateTime>(izzzzzp_, izzzzzy_, default);
            CqlInterval<CqlDateTime> jzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzq_);
            CqlDateTime jzzzzzc_ = context.Operators.Start(jzzzzzb_);
            bool? jzzzzzd_ = context.Operators.Not((bool?)(jzzzzzc_ is null));
            bool? jzzzzze_ = context.Operators.And(izzzzzz_, jzzzzzd_);
            bool? jzzzzzf_ = context.Operators.And(izzzzzm_, jzzzzze_);

            return jzzzzzf_;
        };
        IEnumerable<Encounter> izzzzzf_ = context.Operators.Where<Encounter>(izzzzzd_, izzzzze_);
        object izzzzzg_(Encounter @this)
        {
            Period jzzzzzg_ = @this?.Period;
            CqlInterval<CqlDateTime> jzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzg_);
            CqlDateTime jzzzzzi_ = context.Operators.End(jzzzzzh_);

            return jzzzzzi_;
        };
        IEnumerable<Encounter> izzzzzh_ = context.Operators.SortBy<Encounter>(izzzzzf_, izzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter izzzzzi_ = context.Operators.Last<Encounter>(izzzzzh_);

        return izzzzzi_;
    }


    [CqlExpressionDefinition("edVisit")]
    [CqlTag("description", "Returns the most recent emergency department visit, if any, that occurs 1 hour or less prior to the given encounter.")]
    public Encounter edVisit(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet jzzzzzj_ = this.Emergency_Department_Visit(context);
        IEnumerable<Encounter> jzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? jzzzzzl_(Encounter EDVisit)
        {
            Code<Encounter.EncounterStatus> jzzzzzq_ = EDVisit?.StatusElement;
            Encounter.EncounterStatus? jzzzzzr_ = jzzzzzq_?.Value;
            Code<Encounter.EncounterStatus> jzzzzzs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jzzzzzr_);
            bool? jzzzzzt_ = context.Operators.Equal(jzzzzzs_, "finished");
            Period jzzzzzu_ = EDVisit?.Period;
            CqlInterval<CqlDateTime> jzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzu_);
            CqlDateTime jzzzzzw_ = context.Operators.End(jzzzzzv_);
            Period jzzzzzx_ = TheEncounter?.Period;
            CqlInterval<CqlDateTime> jzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzx_);
            CqlDateTime jzzzzzz_ = context.Operators.Start(jzzzzzy_);
            CqlQuantity kzzzzza_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime kzzzzzb_ = context.Operators.Subtract(jzzzzzz_, kzzzzza_);
            CqlInterval<CqlDateTime> kzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzx_);
            CqlDateTime kzzzzze_ = context.Operators.Start(kzzzzzd_);
            CqlInterval<CqlDateTime> kzzzzzf_ = context.Operators.Interval(kzzzzzb_, kzzzzze_, true, true);
            bool? kzzzzzg_ = context.Operators.In<CqlDateTime>(jzzzzzw_, kzzzzzf_, default);
            CqlInterval<CqlDateTime> kzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzx_);
            CqlDateTime kzzzzzj_ = context.Operators.Start(kzzzzzi_);
            bool? kzzzzzk_ = context.Operators.Not((bool?)(kzzzzzj_ is null));
            bool? kzzzzzl_ = context.Operators.And(kzzzzzg_, kzzzzzk_);
            bool? kzzzzzm_ = context.Operators.And(jzzzzzt_, kzzzzzl_);

            return kzzzzzm_;
        };
        IEnumerable<Encounter> jzzzzzm_ = context.Operators.Where<Encounter>(jzzzzzk_, jzzzzzl_);
        object jzzzzzn_(Encounter @this)
        {
            Period kzzzzzn_ = @this?.Period;
            CqlInterval<CqlDateTime> kzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzn_);
            CqlDateTime kzzzzzp_ = context.Operators.End(kzzzzzo_);

            return kzzzzzp_;
        };
        IEnumerable<Encounter> jzzzzzo_ = context.Operators.SortBy<Encounter>(jzzzzzm_, jzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter jzzzzzp_ = context.Operators.Last<Encounter>(jzzzzzo_);

        return jzzzzzp_;
    }


    [CqlExpressionDefinition("Hospitalization")]
    [CqlTag("description", "Hospitalization returns the total interval for admission to discharge for the given encounter, or for the admission of any immediately prior emergency department visit to the discharge of the given encounter.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalization()` instead.")]
    public CqlInterval<CqlDateTime> Hospitalization(CqlContext context, Encounter TheEncounter)
    {
        Encounter kzzzzzq_ = this.ED_Visit(context, TheEncounter);
        Encounter[] kzzzzzr_ = [
            kzzzzzq_,
        ];
        CqlInterval<CqlDateTime> kzzzzzs_(Encounter X)
        {
            CqlInterval<CqlDateTime> kzzzzzw_()
            {
                if (X is null)
                {
                    Period kzzzzzx_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> kzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzx_);

                    return kzzzzzy_;
                }
                else
                {
                    Period kzzzzzz_ = X?.Period;
                    CqlInterval<CqlDateTime> lzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzz_);
                    CqlDateTime lzzzzzb_ = context.Operators.Start(lzzzzza_);
                    Period lzzzzzc_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> lzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzc_);
                    CqlDateTime lzzzzze_ = context.Operators.End(lzzzzzd_);
                    CqlInterval<CqlDateTime> lzzzzzf_ = context.Operators.Interval(lzzzzzb_, lzzzzze_, true, false);

                    return lzzzzzf_;
                }
            };

            return kzzzzzw_();
        };
        IEnumerable<CqlInterval<CqlDateTime>> kzzzzzt_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)kzzzzzr_, kzzzzzs_);
        IEnumerable<CqlInterval<CqlDateTime>> kzzzzzu_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(kzzzzzt_);
        CqlInterval<CqlDateTime> kzzzzzv_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(kzzzzzu_);

        return kzzzzzv_;
    }


    [CqlExpressionDefinition("hospitalization")]
    [CqlTag("description", "Hospitalization returns the total interval for admission to discharge for the given encounter, or for the admission of any immediately prior emergency department visit to the discharge of the given encounter.")]
    public CqlInterval<CqlDateTime> hospitalization(CqlContext context, Encounter TheEncounter)
    {
        Encounter lzzzzzg_ = this.edVisit(context, TheEncounter);
        Encounter[] lzzzzzh_ = [
            lzzzzzg_,
        ];
        CqlInterval<CqlDateTime> lzzzzzi_(Encounter X)
        {
            CqlInterval<CqlDateTime> lzzzzzm_()
            {
                if (X is null)
                {
                    Period lzzzzzn_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> lzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzn_);

                    return lzzzzzo_;
                }
                else
                {
                    Period lzzzzzp_ = X?.Period;
                    CqlInterval<CqlDateTime> lzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzp_);
                    CqlDateTime lzzzzzr_ = context.Operators.Start(lzzzzzq_);
                    Period lzzzzzs_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> lzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzs_);
                    CqlDateTime lzzzzzu_ = context.Operators.End(lzzzzzt_);
                    CqlInterval<CqlDateTime> lzzzzzv_ = context.Operators.Interval(lzzzzzr_, lzzzzzu_, true, true);

                    return lzzzzzv_;
                }
            };

            return lzzzzzm_();
        };
        IEnumerable<CqlInterval<CqlDateTime>> lzzzzzj_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)lzzzzzh_, lzzzzzi_);
        IEnumerable<CqlInterval<CqlDateTime>> lzzzzzk_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(lzzzzzj_);
        CqlInterval<CqlDateTime> lzzzzzl_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(lzzzzzk_);

        return lzzzzzl_;
    }


    [CqlExpressionDefinition("Hospitalization Locations")]
    [CqlTag("description", "Returns list of all locations within an encounter, including locations for immediately prior ED visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationLocations()` instead.")]
    public IEnumerable<Encounter.LocationComponent> Hospitalization_Locations(CqlContext context, Encounter TheEncounter)
    {
        Encounter lzzzzzw_ = this.ED_Visit(context, TheEncounter);
        Encounter[] lzzzzzx_ = [
            lzzzzzw_,
        ];
        IEnumerable<Encounter.LocationComponent> lzzzzzy_(Encounter EDEncounter)
        {
            IEnumerable<Encounter.LocationComponent> mzzzzzc_()
            {
                if (EDEncounter is null)
                {
                    List<Encounter.LocationComponent> mzzzzzd_ = TheEncounter?.Location;

                    return (IEnumerable<Encounter.LocationComponent>)mzzzzzd_;
                }
                else
                {
                    List<Encounter.LocationComponent> mzzzzze_ = EDEncounter?.Location;
                    List<Encounter.LocationComponent> mzzzzzf_ = TheEncounter?.Location;
                    IEnumerable<Encounter.LocationComponent>[] mzzzzzg_ = [
                        (IEnumerable<Encounter.LocationComponent>)mzzzzze_,
                        (IEnumerable<Encounter.LocationComponent>)mzzzzzf_,
                    ];
                    IEnumerable<Encounter.LocationComponent> mzzzzzh_ = context.Operators.Flatten<Encounter.LocationComponent>(mzzzzzg_ as IEnumerable<IEnumerable<Encounter.LocationComponent>>);

                    return mzzzzzh_;
                }
            };

            return mzzzzzc_();
        };
        IEnumerable<IEnumerable<Encounter.LocationComponent>> lzzzzzz_ = context.Operators.Select<Encounter, IEnumerable<Encounter.LocationComponent>>((IEnumerable<Encounter>)lzzzzzx_, lzzzzzy_);
        IEnumerable<IEnumerable<Encounter.LocationComponent>> mzzzzza_ = context.Operators.Distinct<IEnumerable<Encounter.LocationComponent>>(lzzzzzz_);
        IEnumerable<Encounter.LocationComponent> mzzzzzb_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(mzzzzza_);

        return mzzzzzb_;
    }


    [CqlExpressionDefinition("hospitalizationLocations")]
    [CqlTag("description", "Returns list of all locations within an encounter, including locations for immediately prior ED visit.")]
    public IEnumerable<Encounter.LocationComponent> hospitalizationLocations(CqlContext context, Encounter TheEncounter)
    {
        Encounter mzzzzzi_ = this.edVisit(context, TheEncounter);
        Encounter[] mzzzzzj_ = [
            mzzzzzi_,
        ];
        IEnumerable<Encounter.LocationComponent> mzzzzzk_(Encounter EDEncounter)
        {
            IEnumerable<Encounter.LocationComponent> mzzzzzo_()
            {
                if (EDEncounter is null)
                {
                    List<Encounter.LocationComponent> mzzzzzp_ = TheEncounter?.Location;

                    return (IEnumerable<Encounter.LocationComponent>)mzzzzzp_;
                }
                else
                {
                    List<Encounter.LocationComponent> mzzzzzq_ = EDEncounter?.Location;
                    List<Encounter.LocationComponent> mzzzzzr_ = TheEncounter?.Location;
                    IEnumerable<Encounter.LocationComponent>[] mzzzzzs_ = [
                        (IEnumerable<Encounter.LocationComponent>)mzzzzzq_,
                        (IEnumerable<Encounter.LocationComponent>)mzzzzzr_,
                    ];
                    IEnumerable<Encounter.LocationComponent> mzzzzzt_ = context.Operators.Flatten<Encounter.LocationComponent>(mzzzzzs_ as IEnumerable<IEnumerable<Encounter.LocationComponent>>);

                    return mzzzzzt_;
                }
            };

            return mzzzzzo_();
        };
        IEnumerable<IEnumerable<Encounter.LocationComponent>> mzzzzzl_ = context.Operators.Select<Encounter, IEnumerable<Encounter.LocationComponent>>((IEnumerable<Encounter>)mzzzzzj_, mzzzzzk_);
        IEnumerable<IEnumerable<Encounter.LocationComponent>> mzzzzzm_ = context.Operators.Distinct<IEnumerable<Encounter.LocationComponent>>(mzzzzzl_);
        IEnumerable<Encounter.LocationComponent> mzzzzzn_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(mzzzzzm_);

        return mzzzzzn_;
    }


    [CqlExpressionDefinition("Hospitalization Length of Stay")]
    [CqlTag("description", "Returns the length of stay in days (i.e. the number of days between admission and discharge) for the given encounter, or from the admission of any immediately prior emergency department visit to the discharge of the encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationLengthOfStay()` instead.")]
    public int? Hospitalization_Length_of_Stay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> mzzzzzu_ = this.Hospitalization(context, TheEncounter);
        int? mzzzzzv_ = this.LengthInDays(context, mzzzzzu_);

        return mzzzzzv_;
    }


    [CqlExpressionDefinition("hospitalizationLengthOfStay")]
    [CqlTag("description", "Returns the length of stay in days (i.e. the number of days between admission and discharge) for the given encounter, or from the admission of any immediately prior emergency department visit to the discharge of the encounter")]
    public int? hospitalizationLengthOfStay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> mzzzzzw_ = this.hospitalization(context, TheEncounter);
        int? mzzzzzx_ = this.lengthInDays(context, mzzzzzw_);

        return mzzzzzx_;
    }


    [CqlExpressionDefinition("Hospital Admission Time")]
    [CqlTag("description", "Returns admission time for an encounter or for immediately prior emergency department visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalAdmissionTime()` instead.")]
    public CqlDateTime Hospital_Admission_Time(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> mzzzzzy_ = this.Hospitalization(context, TheEncounter);
        CqlDateTime mzzzzzz_ = context.Operators.Start(mzzzzzy_);

        return mzzzzzz_;
    }


    [CqlExpressionDefinition("hospitalAdmissionTime")]
    [CqlTag("description", "Returns admission time for an encounter or for immediately prior emergency department visit.")]
    public CqlDateTime hospitalAdmissionTime(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> nzzzzza_ = this.hospitalization(context, TheEncounter);
        CqlDateTime nzzzzzb_ = context.Operators.Start(nzzzzza_);

        return nzzzzzb_;
    }


    [CqlExpressionDefinition("Hospital Discharge Time")]
    [CqlTag("description", "Hospital Discharge Time returns the discharge time for an encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalDischargeTime()` instead.")]
    public CqlDateTime Hospital_Discharge_Time(CqlContext context, Encounter TheEncounter)
    {
        Period nzzzzzc_ = TheEncounter?.Period;
        CqlInterval<CqlDateTime> nzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzc_);
        CqlDateTime nzzzzze_ = context.Operators.End(nzzzzzd_);

        return nzzzzze_;
    }


    [CqlExpressionDefinition("hospitalDischargeTime")]
    [CqlTag("description", "Hospital Discharge Time returns the discharge time for an encounter")]
    public CqlDateTime hospitalDischargeTime(CqlContext context, Encounter TheEncounter)
    {
        Period nzzzzzf_ = TheEncounter?.Period;
        CqlInterval<CqlDateTime> nzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzf_);
        CqlDateTime nzzzzzh_ = context.Operators.End(nzzzzzg_);

        return nzzzzzh_;
    }


    [CqlExpressionDefinition("Hospital Arrival Time")]
    [CqlTag("description", "Returns earliest arrival time for an encounter including any prior ED visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalArrivalTime()` instead.")]
    public CqlDateTime Hospital_Arrival_Time(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> nzzzzzi_ = this.Hospitalization_Locations(context, TheEncounter);
        object nzzzzzj_(Encounter.LocationComponent @this)
        {
            Period nzzzzzp_ = @this?.Period;
            CqlInterval<CqlDateTime> nzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzp_);
            CqlDateTime nzzzzzr_ = context.Operators.Start(nzzzzzq_);

            return nzzzzzr_;
        };
        IEnumerable<Encounter.LocationComponent> nzzzzzk_ = context.Operators.SortBy<Encounter.LocationComponent>(nzzzzzi_, nzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent nzzzzzl_ = context.Operators.First<Encounter.LocationComponent>(nzzzzzk_);
        Period nzzzzzm_ = nzzzzzl_?.Period;
        CqlInterval<CqlDateTime> nzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzm_);
        CqlDateTime nzzzzzo_ = context.Operators.Start(nzzzzzn_);

        return nzzzzzo_;
    }


    [CqlExpressionDefinition("hospitalArrivalTime")]
    [CqlTag("description", "Returns earliest arrival time for an encounter including any prior ED visit.")]
    public CqlDateTime hospitalArrivalTime(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> nzzzzzs_ = this.hospitalizationLocations(context, TheEncounter);
        object nzzzzzt_(Encounter.LocationComponent @this)
        {
            Period nzzzzzz_ = @this?.Period;
            CqlInterval<CqlDateTime> ozzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzz_);
            CqlDateTime ozzzzzb_ = context.Operators.Start(ozzzzza_);

            return ozzzzzb_;
        };
        IEnumerable<Encounter.LocationComponent> nzzzzzu_ = context.Operators.SortBy<Encounter.LocationComponent>(nzzzzzs_, nzzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent nzzzzzv_ = context.Operators.First<Encounter.LocationComponent>(nzzzzzu_);
        Period nzzzzzw_ = nzzzzzv_?.Period;
        CqlInterval<CqlDateTime> nzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzw_);
        CqlDateTime nzzzzzy_ = context.Operators.Start(nzzzzzx_);

        return nzzzzzy_;
    }


    [CqlExpressionDefinition("Hospital Departure Time")]
    [CqlTag("description", "Returns the latest departure time for encounter including any prior ED visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalDepartureTime()` instead.")]
    public CqlDateTime Hospital_Departure_Time(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> ozzzzzc_ = this.Hospitalization_Locations(context, TheEncounter);
        object ozzzzzd_(Encounter.LocationComponent @this)
        {
            Period ozzzzzj_ = @this?.Period;
            CqlInterval<CqlDateTime> ozzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzj_);
            CqlDateTime ozzzzzl_ = context.Operators.Start(ozzzzzk_);

            return ozzzzzl_;
        };
        IEnumerable<Encounter.LocationComponent> ozzzzze_ = context.Operators.SortBy<Encounter.LocationComponent>(ozzzzzc_, ozzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent ozzzzzf_ = context.Operators.Last<Encounter.LocationComponent>(ozzzzze_);
        Period ozzzzzg_ = ozzzzzf_?.Period;
        CqlInterval<CqlDateTime> ozzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzg_);
        CqlDateTime ozzzzzi_ = context.Operators.End(ozzzzzh_);

        return ozzzzzi_;
    }


    [CqlExpressionDefinition("hospitalDepartureTime")]
    [CqlTag("description", "Returns the latest departure time for encounter including any prior ED visit.")]
    public CqlDateTime hospitalDepartureTime(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> ozzzzzm_ = this.hospitalizationLocations(context, TheEncounter);
        object ozzzzzn_(Encounter.LocationComponent @this)
        {
            Period ozzzzzt_ = @this?.Period;
            CqlInterval<CqlDateTime> ozzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzt_);
            CqlDateTime ozzzzzv_ = context.Operators.Start(ozzzzzu_);

            return ozzzzzv_;
        };
        IEnumerable<Encounter.LocationComponent> ozzzzzo_ = context.Operators.SortBy<Encounter.LocationComponent>(ozzzzzm_, ozzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent ozzzzzp_ = context.Operators.Last<Encounter.LocationComponent>(ozzzzzo_);
        Period ozzzzzq_ = ozzzzzp_?.Period;
        CqlInterval<CqlDateTime> ozzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzq_);
        CqlDateTime ozzzzzs_ = context.Operators.End(ozzzzzr_);

        return ozzzzzs_;
    }


    [CqlExpressionDefinition("GetLocation")]
    [CqlTag("description", "Returns the Location resource specified by the given reference")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getLocation()` instead.")]
    public Location GetLocation(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Location> ozzzzzw_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-location"));
        bool? ozzzzzx_(Location L)
        {
            Id pzzzzza_ = L?.IdElement;
            string pzzzzzb_ = pzzzzza_?.Value;
            FhirString pzzzzzc_ = reference?.ReferenceElement;
            string pzzzzzd_ = pzzzzzc_?.Value;
            string pzzzzze_ = QICoreCommon_2_1_000.Instance.getId(context, pzzzzzd_);
            bool? pzzzzzf_ = context.Operators.Equal(pzzzzzb_, pzzzzze_);

            return pzzzzzf_;
        };
        IEnumerable<Location> ozzzzzy_ = context.Operators.Where<Location>(ozzzzzw_, ozzzzzx_);
        Location ozzzzzz_ = context.Operators.SingletonFrom<Location>(ozzzzzy_);

        return ozzzzzz_;
    }


    [CqlExpressionDefinition("Emergency Department Arrival Time")]
    [CqlTag("description", "Returns the emergency department arrival time for the encounter.")]
    public CqlDateTime Emergency_Department_Arrival_Time(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> pzzzzzg_ = this.Hospitalization_Locations(context, TheEncounter);
        bool? pzzzzzh_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference pzzzzzn_ = HospitalLocation?.Location;
            Location pzzzzzo_ = this.GetLocation(context, pzzzzzn_);
            List<CodeableConcept> pzzzzzp_ = pzzzzzo_?.Type;
            CqlConcept pzzzzzq_(CodeableConcept @this)
            {
                CqlConcept pzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return pzzzzzu_;
            };
            IEnumerable<CqlConcept> pzzzzzr_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)pzzzzzp_, pzzzzzq_);
            CqlValueSet pzzzzzs_ = this.Emergency_Department_Visit(context);
            bool? pzzzzzt_ = context.Operators.ConceptsInValueSet(pzzzzzr_, pzzzzzs_);

            return pzzzzzt_;
        };
        IEnumerable<Encounter.LocationComponent> pzzzzzi_ = context.Operators.Where<Encounter.LocationComponent>(pzzzzzg_, pzzzzzh_);
        Encounter.LocationComponent pzzzzzj_ = context.Operators.SingletonFrom<Encounter.LocationComponent>(pzzzzzi_);
        Period pzzzzzk_ = pzzzzzj_?.Period;
        CqlInterval<CqlDateTime> pzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzk_);
        CqlDateTime pzzzzzm_ = context.Operators.Start(pzzzzzl_);

        return pzzzzzm_;
    }


    [CqlExpressionDefinition("emergencyDepartmentArrivalTime")]
    [CqlTag("description", "Returns the emergency department arrival time for the encounter.")]
    public CqlDateTime emergencyDepartmentArrivalTime(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> pzzzzzv_ = this.hospitalizationLocations(context, TheEncounter);
        bool? pzzzzzw_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference qzzzzzc_ = HospitalLocation?.Location;
            Location qzzzzzd_ = this.GetLocation(context, qzzzzzc_);
            List<CodeableConcept> qzzzzze_ = qzzzzzd_?.Type;
            CqlConcept qzzzzzf_(CodeableConcept @this)
            {
                CqlConcept qzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return qzzzzzj_;
            };
            IEnumerable<CqlConcept> qzzzzzg_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)qzzzzze_, qzzzzzf_);
            CqlValueSet qzzzzzh_ = this.Emergency_Department_Visit(context);
            bool? qzzzzzi_ = context.Operators.ConceptsInValueSet(qzzzzzg_, qzzzzzh_);

            return qzzzzzi_;
        };
        IEnumerable<Encounter.LocationComponent> pzzzzzx_ = context.Operators.Where<Encounter.LocationComponent>(pzzzzzv_, pzzzzzw_);
        Encounter.LocationComponent pzzzzzy_ = context.Operators.SingletonFrom<Encounter.LocationComponent>(pzzzzzx_);
        Period pzzzzzz_ = pzzzzzy_?.Period;
        CqlInterval<CqlDateTime> qzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzz_);
        CqlDateTime qzzzzzb_ = context.Operators.Start(qzzzzza_);

        return qzzzzzb_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservationAndOutpatientSurgeryService")]
    [CqlTag("description", "Hospitalization with Observation and Outpatient Surgery Service returns the total interval from the start of any immediately prior emergency department visit, outpatient surgery visit or observation visit to the discharge of the given encounter.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationWithObservationAndOutpatientSurgeryService()` instead.")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservationAndOutpatientSurgeryService(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] qzzzzzk_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> qzzzzzl_(Encounter Visit)
        {
            CqlValueSet qzzzzzp_ = this.Outpatient_Surgery_Service(context);
            IEnumerable<Encounter> qzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? qzzzzzr_(Encounter LastSurgeryOP)
            {
                Period szzzzza_ = LastSurgeryOP?.Period;
                CqlInterval<CqlDateTime> szzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzza_);
                CqlDateTime szzzzzc_ = context.Operators.End(szzzzzb_);
                CqlValueSet szzzzzd_ = this.Emergency_Department_Visit(context);
                IEnumerable<Encounter> szzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? szzzzzf_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> vzzzzza_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? vzzzzzb_ = vzzzzza_?.Value;
                    Code<Encounter.EncounterStatus> vzzzzzc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(vzzzzzb_);
                    bool? vzzzzzd_ = context.Operators.Equal(vzzzzzc_, "finished");
                    Period vzzzzze_ = LastED?.Period;
                    CqlInterval<CqlDateTime> vzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzze_);
                    CqlDateTime vzzzzzg_ = context.Operators.End(vzzzzzf_);
                    CqlValueSet vzzzzzh_ = this.Observation_Services(context);
                    IEnumerable<Encounter> vzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? vzzzzzj_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> xzzzzzb_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? xzzzzzc_ = xzzzzzb_?.Value;
                        Code<Encounter.EncounterStatus> xzzzzzd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(xzzzzzc_);
                        bool? xzzzzze_ = context.Operators.Equal(xzzzzzd_, "finished");
                        Period xzzzzzf_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> xzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzf_);
                        CqlDateTime xzzzzzh_ = context.Operators.End(xzzzzzg_);
                        Period xzzzzzi_ = Visit?.Period;
                        CqlInterval<CqlDateTime> xzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzi_);
                        CqlDateTime xzzzzzk_ = context.Operators.Start(xzzzzzj_);
                        CqlQuantity xzzzzzl_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime xzzzzzm_ = context.Operators.Subtract(xzzzzzk_, xzzzzzl_);
                        CqlInterval<CqlDateTime> xzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzi_);
                        CqlDateTime xzzzzzp_ = context.Operators.Start(xzzzzzo_);
                        CqlInterval<CqlDateTime> xzzzzzq_ = context.Operators.Interval(xzzzzzm_, xzzzzzp_, true, true);
                        bool? xzzzzzr_ = context.Operators.In<CqlDateTime>(xzzzzzh_, xzzzzzq_, default);
                        CqlInterval<CqlDateTime> xzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzi_);
                        CqlDateTime xzzzzzu_ = context.Operators.Start(xzzzzzt_);
                        bool? xzzzzzv_ = context.Operators.Not((bool?)(xzzzzzu_ is null));
                        bool? xzzzzzw_ = context.Operators.And(xzzzzzr_, xzzzzzv_);
                        bool? xzzzzzx_ = context.Operators.And(xzzzzze_, xzzzzzw_);

                        return xzzzzzx_;
                    };
                    IEnumerable<Encounter> vzzzzzk_ = context.Operators.Where<Encounter>(vzzzzzi_, vzzzzzj_);
                    object vzzzzzl_(Encounter @this)
                    {
                        Period xzzzzzy_ = @this?.Period;
                        CqlInterval<CqlDateTime> xzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzy_);
                        CqlDateTime yzzzzza_ = context.Operators.End(xzzzzzz_);

                        return yzzzzza_;
                    };
                    IEnumerable<Encounter> vzzzzzm_ = context.Operators.SortBy<Encounter>(vzzzzzk_, vzzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter vzzzzzn_ = context.Operators.Last<Encounter>(vzzzzzm_);
                    Period vzzzzzo_ = vzzzzzn_?.Period;
                    CqlInterval<CqlDateTime> vzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzo_);
                    CqlDateTime vzzzzzq_ = context.Operators.Start(vzzzzzp_);
                    Period vzzzzzr_ = Visit?.Period;
                    CqlInterval<CqlDateTime> vzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzr_);
                    CqlDateTime vzzzzzt_ = context.Operators.Start(vzzzzzs_);
                    CqlQuantity vzzzzzu_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime vzzzzzv_ = context.Operators.Subtract(vzzzzzq_ ?? vzzzzzt_, vzzzzzu_);
                    IEnumerable<Encounter> vzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? vzzzzzy_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> yzzzzzb_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? yzzzzzc_ = yzzzzzb_?.Value;
                        Code<Encounter.EncounterStatus> yzzzzzd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(yzzzzzc_);
                        bool? yzzzzze_ = context.Operators.Equal(yzzzzzd_, "finished");
                        Period yzzzzzf_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> yzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzf_);
                        CqlDateTime yzzzzzh_ = context.Operators.End(yzzzzzg_);
                        Period yzzzzzi_ = Visit?.Period;
                        CqlInterval<CqlDateTime> yzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzi_);
                        CqlDateTime yzzzzzk_ = context.Operators.Start(yzzzzzj_);
                        CqlQuantity yzzzzzl_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime yzzzzzm_ = context.Operators.Subtract(yzzzzzk_, yzzzzzl_);
                        CqlInterval<CqlDateTime> yzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzi_);
                        CqlDateTime yzzzzzp_ = context.Operators.Start(yzzzzzo_);
                        CqlInterval<CqlDateTime> yzzzzzq_ = context.Operators.Interval(yzzzzzm_, yzzzzzp_, true, true);
                        bool? yzzzzzr_ = context.Operators.In<CqlDateTime>(yzzzzzh_, yzzzzzq_, default);
                        CqlInterval<CqlDateTime> yzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzi_);
                        CqlDateTime yzzzzzu_ = context.Operators.Start(yzzzzzt_);
                        bool? yzzzzzv_ = context.Operators.Not((bool?)(yzzzzzu_ is null));
                        bool? yzzzzzw_ = context.Operators.And(yzzzzzr_, yzzzzzv_);
                        bool? yzzzzzx_ = context.Operators.And(yzzzzze_, yzzzzzw_);

                        return yzzzzzx_;
                    };
                    IEnumerable<Encounter> vzzzzzz_ = context.Operators.Where<Encounter>(vzzzzzx_, vzzzzzy_);
                    object wzzzzza_(Encounter @this)
                    {
                        Period yzzzzzy_ = @this?.Period;
                        CqlInterval<CqlDateTime> yzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzy_);
                        CqlDateTime zzzzzza_ = context.Operators.End(yzzzzzz_);

                        return zzzzzza_;
                    };
                    IEnumerable<Encounter> wzzzzzb_ = context.Operators.SortBy<Encounter>(vzzzzzz_, wzzzzza_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter wzzzzzc_ = context.Operators.Last<Encounter>(wzzzzzb_);
                    Period wzzzzzd_ = wzzzzzc_?.Period;
                    CqlInterval<CqlDateTime> wzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzd_);
                    CqlDateTime wzzzzzf_ = context.Operators.Start(wzzzzze_);
                    CqlInterval<CqlDateTime> wzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzr_);
                    CqlDateTime wzzzzzi_ = context.Operators.Start(wzzzzzh_);
                    CqlInterval<CqlDateTime> wzzzzzj_ = context.Operators.Interval(vzzzzzv_, wzzzzzf_ ?? wzzzzzi_, true, true);
                    bool? wzzzzzk_ = context.Operators.In<CqlDateTime>(vzzzzzg_, wzzzzzj_, default);
                    IEnumerable<Encounter> wzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? wzzzzzn_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> zzzzzzb_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? zzzzzzc_ = zzzzzzb_?.Value;
                        Code<Encounter.EncounterStatus> zzzzzzd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(zzzzzzc_);
                        bool? zzzzzze_ = context.Operators.Equal(zzzzzzd_, "finished");
                        Period zzzzzzf_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> zzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzf_);
                        CqlDateTime zzzzzzh_ = context.Operators.End(zzzzzzg_);
                        Period zzzzzzi_ = Visit?.Period;
                        CqlInterval<CqlDateTime> zzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzi_);
                        CqlDateTime zzzzzzk_ = context.Operators.Start(zzzzzzj_);
                        CqlQuantity zzzzzzl_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime zzzzzzm_ = context.Operators.Subtract(zzzzzzk_, zzzzzzl_);
                        CqlInterval<CqlDateTime> zzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzi_);
                        CqlDateTime zzzzzzp_ = context.Operators.Start(zzzzzzo_);
                        CqlInterval<CqlDateTime> zzzzzzq_ = context.Operators.Interval(zzzzzzm_, zzzzzzp_, true, true);
                        bool? zzzzzzr_ = context.Operators.In<CqlDateTime>(zzzzzzh_, zzzzzzq_, default);
                        CqlInterval<CqlDateTime> zzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzi_);
                        CqlDateTime zzzzzzu_ = context.Operators.Start(zzzzzzt_);
                        bool? zzzzzzv_ = context.Operators.Not((bool?)(zzzzzzu_ is null));
                        bool? zzzzzzw_ = context.Operators.And(zzzzzzr_, zzzzzzv_);
                        bool? zzzzzzx_ = context.Operators.And(zzzzzze_, zzzzzzw_);

                        return zzzzzzx_;
                    };
                    IEnumerable<Encounter> wzzzzzo_ = context.Operators.Where<Encounter>(wzzzzzm_, wzzzzzn_);
                    object wzzzzzp_(Encounter @this)
                    {
                        Period zzzzzzy_ = @this?.Period;
                        CqlInterval<CqlDateTime> zzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzy_);
                        CqlDateTime azzzzzza_ = context.Operators.End(zzzzzzz_);

                        return azzzzzza_;
                    };
                    IEnumerable<Encounter> wzzzzzq_ = context.Operators.SortBy<Encounter>(wzzzzzo_, wzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter wzzzzzr_ = context.Operators.Last<Encounter>(wzzzzzq_);
                    Period wzzzzzs_ = wzzzzzr_?.Period;
                    CqlInterval<CqlDateTime> wzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzs_);
                    CqlDateTime wzzzzzu_ = context.Operators.Start(wzzzzzt_);
                    CqlInterval<CqlDateTime> wzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzr_);
                    CqlDateTime wzzzzzx_ = context.Operators.Start(wzzzzzw_);
                    bool? wzzzzzy_ = context.Operators.Not((bool?)((wzzzzzu_ ?? wzzzzzx_) is null));
                    bool? wzzzzzz_ = context.Operators.And(wzzzzzk_, wzzzzzy_);
                    bool? xzzzzza_ = context.Operators.And(vzzzzzd_, wzzzzzz_);

                    return xzzzzza_;
                };
                IEnumerable<Encounter> szzzzzg_ = context.Operators.Where<Encounter>(szzzzze_, szzzzzf_);
                object szzzzzh_(Encounter @this)
                {
                    Period azzzzzzb_ = @this?.Period;
                    CqlInterval<CqlDateTime> azzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzb_);
                    CqlDateTime azzzzzzd_ = context.Operators.End(azzzzzzc_);

                    return azzzzzzd_;
                };
                IEnumerable<Encounter> szzzzzi_ = context.Operators.SortBy<Encounter>(szzzzzg_, szzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter szzzzzj_ = context.Operators.Last<Encounter>(szzzzzi_);
                Period szzzzzk_ = szzzzzj_?.Period;
                CqlInterval<CqlDateTime> szzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzk_);
                CqlDateTime szzzzzm_ = context.Operators.Start(szzzzzl_);
                CqlValueSet szzzzzn_ = this.Observation_Services(context);
                IEnumerable<Encounter> szzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? szzzzzp_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> azzzzzze_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? azzzzzzf_ = azzzzzze_?.Value;
                    Code<Encounter.EncounterStatus> azzzzzzg_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(azzzzzzf_);
                    bool? azzzzzzh_ = context.Operators.Equal(azzzzzzg_, "finished");
                    Period azzzzzzi_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> azzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzi_);
                    CqlDateTime azzzzzzk_ = context.Operators.End(azzzzzzj_);
                    Period azzzzzzl_ = Visit?.Period;
                    CqlInterval<CqlDateTime> azzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzl_);
                    CqlDateTime azzzzzzn_ = context.Operators.Start(azzzzzzm_);
                    CqlQuantity azzzzzzo_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime azzzzzzp_ = context.Operators.Subtract(azzzzzzn_, azzzzzzo_);
                    CqlInterval<CqlDateTime> azzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzl_);
                    CqlDateTime azzzzzzs_ = context.Operators.Start(azzzzzzr_);
                    CqlInterval<CqlDateTime> azzzzzzt_ = context.Operators.Interval(azzzzzzp_, azzzzzzs_, true, true);
                    bool? azzzzzzu_ = context.Operators.In<CqlDateTime>(azzzzzzk_, azzzzzzt_, default);
                    CqlInterval<CqlDateTime> azzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzl_);
                    CqlDateTime azzzzzzx_ = context.Operators.Start(azzzzzzw_);
                    bool? azzzzzzy_ = context.Operators.Not((bool?)(azzzzzzx_ is null));
                    bool? azzzzzzz_ = context.Operators.And(azzzzzzu_, azzzzzzy_);
                    bool? bzzzzzza_ = context.Operators.And(azzzzzzh_, azzzzzzz_);

                    return bzzzzzza_;
                };
                IEnumerable<Encounter> szzzzzq_ = context.Operators.Where<Encounter>(szzzzzo_, szzzzzp_);
                object szzzzzr_(Encounter @this)
                {
                    Period bzzzzzzb_ = @this?.Period;
                    CqlInterval<CqlDateTime> bzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzb_);
                    CqlDateTime bzzzzzzd_ = context.Operators.End(bzzzzzzc_);

                    return bzzzzzzd_;
                };
                IEnumerable<Encounter> szzzzzs_ = context.Operators.SortBy<Encounter>(szzzzzq_, szzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter szzzzzt_ = context.Operators.Last<Encounter>(szzzzzs_);
                Period szzzzzu_ = szzzzzt_?.Period;
                CqlInterval<CqlDateTime> szzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzu_);
                CqlDateTime szzzzzw_ = context.Operators.Start(szzzzzv_);
                Period szzzzzx_ = Visit?.Period;
                CqlInterval<CqlDateTime> szzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzx_);
                CqlDateTime szzzzzz_ = context.Operators.Start(szzzzzy_);
                CqlQuantity tzzzzza_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime tzzzzzb_ = context.Operators.Subtract(szzzzzm_ ?? szzzzzw_ ?? szzzzzz_, tzzzzza_);
                IEnumerable<Encounter> tzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? tzzzzze_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> bzzzzzze_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? bzzzzzzf_ = bzzzzzze_?.Value;
                    Code<Encounter.EncounterStatus> bzzzzzzg_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bzzzzzzf_);
                    bool? bzzzzzzh_ = context.Operators.Equal(bzzzzzzg_, "finished");
                    Period bzzzzzzi_ = LastED?.Period;
                    CqlInterval<CqlDateTime> bzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzi_);
                    CqlDateTime bzzzzzzk_ = context.Operators.End(bzzzzzzj_);
                    CqlValueSet bzzzzzzl_ = this.Observation_Services(context);
                    IEnumerable<Encounter> bzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? bzzzzzzn_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> dzzzzzzf_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? dzzzzzzg_ = dzzzzzzf_?.Value;
                        Code<Encounter.EncounterStatus> dzzzzzzh_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dzzzzzzg_);
                        bool? dzzzzzzi_ = context.Operators.Equal(dzzzzzzh_, "finished");
                        Period dzzzzzzj_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> dzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzj_);
                        CqlDateTime dzzzzzzl_ = context.Operators.End(dzzzzzzk_);
                        Period dzzzzzzm_ = Visit?.Period;
                        CqlInterval<CqlDateTime> dzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzm_);
                        CqlDateTime dzzzzzzo_ = context.Operators.Start(dzzzzzzn_);
                        CqlQuantity dzzzzzzp_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime dzzzzzzq_ = context.Operators.Subtract(dzzzzzzo_, dzzzzzzp_);
                        CqlInterval<CqlDateTime> dzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzm_);
                        CqlDateTime dzzzzzzt_ = context.Operators.Start(dzzzzzzs_);
                        CqlInterval<CqlDateTime> dzzzzzzu_ = context.Operators.Interval(dzzzzzzq_, dzzzzzzt_, true, true);
                        bool? dzzzzzzv_ = context.Operators.In<CqlDateTime>(dzzzzzzl_, dzzzzzzu_, default);
                        CqlInterval<CqlDateTime> dzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzm_);
                        CqlDateTime dzzzzzzy_ = context.Operators.Start(dzzzzzzx_);
                        bool? dzzzzzzz_ = context.Operators.Not((bool?)(dzzzzzzy_ is null));
                        bool? ezzzzzza_ = context.Operators.And(dzzzzzzv_, dzzzzzzz_);
                        bool? ezzzzzzb_ = context.Operators.And(dzzzzzzi_, ezzzzzza_);

                        return ezzzzzzb_;
                    };
                    IEnumerable<Encounter> bzzzzzzo_ = context.Operators.Where<Encounter>(bzzzzzzm_, bzzzzzzn_);
                    object bzzzzzzp_(Encounter @this)
                    {
                        Period ezzzzzzc_ = @this?.Period;
                        CqlInterval<CqlDateTime> ezzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzc_);
                        CqlDateTime ezzzzzze_ = context.Operators.End(ezzzzzzd_);

                        return ezzzzzze_;
                    };
                    IEnumerable<Encounter> bzzzzzzq_ = context.Operators.SortBy<Encounter>(bzzzzzzo_, bzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter bzzzzzzr_ = context.Operators.Last<Encounter>(bzzzzzzq_);
                    Period bzzzzzzs_ = bzzzzzzr_?.Period;
                    CqlInterval<CqlDateTime> bzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzs_);
                    CqlDateTime bzzzzzzu_ = context.Operators.Start(bzzzzzzt_);
                    Period bzzzzzzv_ = Visit?.Period;
                    CqlInterval<CqlDateTime> bzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzv_);
                    CqlDateTime bzzzzzzx_ = context.Operators.Start(bzzzzzzw_);
                    CqlQuantity bzzzzzzy_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime bzzzzzzz_ = context.Operators.Subtract(bzzzzzzu_ ?? bzzzzzzx_, bzzzzzzy_);
                    IEnumerable<Encounter> czzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? czzzzzzc_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> ezzzzzzf_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? ezzzzzzg_ = ezzzzzzf_?.Value;
                        Code<Encounter.EncounterStatus> ezzzzzzh_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ezzzzzzg_);
                        bool? ezzzzzzi_ = context.Operators.Equal(ezzzzzzh_, "finished");
                        Period ezzzzzzj_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> ezzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzj_);
                        CqlDateTime ezzzzzzl_ = context.Operators.End(ezzzzzzk_);
                        Period ezzzzzzm_ = Visit?.Period;
                        CqlInterval<CqlDateTime> ezzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzm_);
                        CqlDateTime ezzzzzzo_ = context.Operators.Start(ezzzzzzn_);
                        CqlQuantity ezzzzzzp_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime ezzzzzzq_ = context.Operators.Subtract(ezzzzzzo_, ezzzzzzp_);
                        CqlInterval<CqlDateTime> ezzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzm_);
                        CqlDateTime ezzzzzzt_ = context.Operators.Start(ezzzzzzs_);
                        CqlInterval<CqlDateTime> ezzzzzzu_ = context.Operators.Interval(ezzzzzzq_, ezzzzzzt_, true, true);
                        bool? ezzzzzzv_ = context.Operators.In<CqlDateTime>(ezzzzzzl_, ezzzzzzu_, default);
                        CqlInterval<CqlDateTime> ezzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzm_);
                        CqlDateTime ezzzzzzy_ = context.Operators.Start(ezzzzzzx_);
                        bool? ezzzzzzz_ = context.Operators.Not((bool?)(ezzzzzzy_ is null));
                        bool? fzzzzzza_ = context.Operators.And(ezzzzzzv_, ezzzzzzz_);
                        bool? fzzzzzzb_ = context.Operators.And(ezzzzzzi_, fzzzzzza_);

                        return fzzzzzzb_;
                    };
                    IEnumerable<Encounter> czzzzzzd_ = context.Operators.Where<Encounter>(czzzzzzb_, czzzzzzc_);
                    object czzzzzze_(Encounter @this)
                    {
                        Period fzzzzzzc_ = @this?.Period;
                        CqlInterval<CqlDateTime> fzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzc_);
                        CqlDateTime fzzzzzze_ = context.Operators.End(fzzzzzzd_);

                        return fzzzzzze_;
                    };
                    IEnumerable<Encounter> czzzzzzf_ = context.Operators.SortBy<Encounter>(czzzzzzd_, czzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter czzzzzzg_ = context.Operators.Last<Encounter>(czzzzzzf_);
                    Period czzzzzzh_ = czzzzzzg_?.Period;
                    CqlInterval<CqlDateTime> czzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzh_);
                    CqlDateTime czzzzzzj_ = context.Operators.Start(czzzzzzi_);
                    CqlInterval<CqlDateTime> czzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzv_);
                    CqlDateTime czzzzzzm_ = context.Operators.Start(czzzzzzl_);
                    CqlInterval<CqlDateTime> czzzzzzn_ = context.Operators.Interval(bzzzzzzz_, czzzzzzj_ ?? czzzzzzm_, true, true);
                    bool? czzzzzzo_ = context.Operators.In<CqlDateTime>(bzzzzzzk_, czzzzzzn_, default);
                    IEnumerable<Encounter> czzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? czzzzzzr_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> fzzzzzzf_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? fzzzzzzg_ = fzzzzzzf_?.Value;
                        Code<Encounter.EncounterStatus> fzzzzzzh_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fzzzzzzg_);
                        bool? fzzzzzzi_ = context.Operators.Equal(fzzzzzzh_, "finished");
                        Period fzzzzzzj_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> fzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzj_);
                        CqlDateTime fzzzzzzl_ = context.Operators.End(fzzzzzzk_);
                        Period fzzzzzzm_ = Visit?.Period;
                        CqlInterval<CqlDateTime> fzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzm_);
                        CqlDateTime fzzzzzzo_ = context.Operators.Start(fzzzzzzn_);
                        CqlQuantity fzzzzzzp_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime fzzzzzzq_ = context.Operators.Subtract(fzzzzzzo_, fzzzzzzp_);
                        CqlInterval<CqlDateTime> fzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzm_);
                        CqlDateTime fzzzzzzt_ = context.Operators.Start(fzzzzzzs_);
                        CqlInterval<CqlDateTime> fzzzzzzu_ = context.Operators.Interval(fzzzzzzq_, fzzzzzzt_, true, true);
                        bool? fzzzzzzv_ = context.Operators.In<CqlDateTime>(fzzzzzzl_, fzzzzzzu_, default);
                        CqlInterval<CqlDateTime> fzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzm_);
                        CqlDateTime fzzzzzzy_ = context.Operators.Start(fzzzzzzx_);
                        bool? fzzzzzzz_ = context.Operators.Not((bool?)(fzzzzzzy_ is null));
                        bool? gzzzzzza_ = context.Operators.And(fzzzzzzv_, fzzzzzzz_);
                        bool? gzzzzzzb_ = context.Operators.And(fzzzzzzi_, gzzzzzza_);

                        return gzzzzzzb_;
                    };
                    IEnumerable<Encounter> czzzzzzs_ = context.Operators.Where<Encounter>(czzzzzzq_, czzzzzzr_);
                    object czzzzzzt_(Encounter @this)
                    {
                        Period gzzzzzzc_ = @this?.Period;
                        CqlInterval<CqlDateTime> gzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzc_);
                        CqlDateTime gzzzzzze_ = context.Operators.End(gzzzzzzd_);

                        return gzzzzzze_;
                    };
                    IEnumerable<Encounter> czzzzzzu_ = context.Operators.SortBy<Encounter>(czzzzzzs_, czzzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter czzzzzzv_ = context.Operators.Last<Encounter>(czzzzzzu_);
                    Period czzzzzzw_ = czzzzzzv_?.Period;
                    CqlInterval<CqlDateTime> czzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzw_);
                    CqlDateTime czzzzzzy_ = context.Operators.Start(czzzzzzx_);
                    CqlInterval<CqlDateTime> dzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzv_);
                    CqlDateTime dzzzzzzb_ = context.Operators.Start(dzzzzzza_);
                    bool? dzzzzzzc_ = context.Operators.Not((bool?)((czzzzzzy_ ?? dzzzzzzb_) is null));
                    bool? dzzzzzzd_ = context.Operators.And(czzzzzzo_, dzzzzzzc_);
                    bool? dzzzzzze_ = context.Operators.And(bzzzzzzh_, dzzzzzzd_);

                    return dzzzzzze_;
                };
                IEnumerable<Encounter> tzzzzzf_ = context.Operators.Where<Encounter>(tzzzzzd_, tzzzzze_);
                object tzzzzzg_(Encounter @this)
                {
                    Period gzzzzzzf_ = @this?.Period;
                    CqlInterval<CqlDateTime> gzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzf_);
                    CqlDateTime gzzzzzzh_ = context.Operators.End(gzzzzzzg_);

                    return gzzzzzzh_;
                };
                IEnumerable<Encounter> tzzzzzh_ = context.Operators.SortBy<Encounter>(tzzzzzf_, tzzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter tzzzzzi_ = context.Operators.Last<Encounter>(tzzzzzh_);
                Period tzzzzzj_ = tzzzzzi_?.Period;
                CqlInterval<CqlDateTime> tzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzj_);
                CqlDateTime tzzzzzl_ = context.Operators.Start(tzzzzzk_);
                IEnumerable<Encounter> tzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? tzzzzzo_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> gzzzzzzi_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? gzzzzzzj_ = gzzzzzzi_?.Value;
                    Code<Encounter.EncounterStatus> gzzzzzzk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gzzzzzzj_);
                    bool? gzzzzzzl_ = context.Operators.Equal(gzzzzzzk_, "finished");
                    Period gzzzzzzm_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> gzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzm_);
                    CqlDateTime gzzzzzzo_ = context.Operators.End(gzzzzzzn_);
                    Period gzzzzzzp_ = Visit?.Period;
                    CqlInterval<CqlDateTime> gzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzp_);
                    CqlDateTime gzzzzzzr_ = context.Operators.Start(gzzzzzzq_);
                    CqlQuantity gzzzzzzs_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime gzzzzzzt_ = context.Operators.Subtract(gzzzzzzr_, gzzzzzzs_);
                    CqlInterval<CqlDateTime> gzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzp_);
                    CqlDateTime gzzzzzzw_ = context.Operators.Start(gzzzzzzv_);
                    CqlInterval<CqlDateTime> gzzzzzzx_ = context.Operators.Interval(gzzzzzzt_, gzzzzzzw_, true, true);
                    bool? gzzzzzzy_ = context.Operators.In<CqlDateTime>(gzzzzzzo_, gzzzzzzx_, default);
                    CqlInterval<CqlDateTime> hzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzp_);
                    CqlDateTime hzzzzzzb_ = context.Operators.Start(hzzzzzza_);
                    bool? hzzzzzzc_ = context.Operators.Not((bool?)(hzzzzzzb_ is null));
                    bool? hzzzzzzd_ = context.Operators.And(gzzzzzzy_, hzzzzzzc_);
                    bool? hzzzzzze_ = context.Operators.And(gzzzzzzl_, hzzzzzzd_);

                    return hzzzzzze_;
                };
                IEnumerable<Encounter> tzzzzzp_ = context.Operators.Where<Encounter>(tzzzzzn_, tzzzzzo_);
                object tzzzzzq_(Encounter @this)
                {
                    Period hzzzzzzf_ = @this?.Period;
                    CqlInterval<CqlDateTime> hzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzf_);
                    CqlDateTime hzzzzzzh_ = context.Operators.End(hzzzzzzg_);

                    return hzzzzzzh_;
                };
                IEnumerable<Encounter> tzzzzzr_ = context.Operators.SortBy<Encounter>(tzzzzzp_, tzzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter tzzzzzs_ = context.Operators.Last<Encounter>(tzzzzzr_);
                Period tzzzzzt_ = tzzzzzs_?.Period;
                CqlInterval<CqlDateTime> tzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzt_);
                CqlDateTime tzzzzzv_ = context.Operators.Start(tzzzzzu_);
                CqlInterval<CqlDateTime> tzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzx_);
                CqlDateTime tzzzzzy_ = context.Operators.Start(tzzzzzx_);
                CqlInterval<CqlDateTime> tzzzzzz_ = context.Operators.Interval(tzzzzzb_, tzzzzzl_ ?? tzzzzzv_ ?? tzzzzzy_, true, true);
                bool? uzzzzza_ = context.Operators.In<CqlDateTime>(szzzzzc_, tzzzzzz_, default);
                IEnumerable<Encounter> uzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? uzzzzzd_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> hzzzzzzi_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? hzzzzzzj_ = hzzzzzzi_?.Value;
                    Code<Encounter.EncounterStatus> hzzzzzzk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hzzzzzzj_);
                    bool? hzzzzzzl_ = context.Operators.Equal(hzzzzzzk_, "finished");
                    Period hzzzzzzm_ = LastED?.Period;
                    CqlInterval<CqlDateTime> hzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzm_);
                    CqlDateTime hzzzzzzo_ = context.Operators.End(hzzzzzzn_);
                    CqlValueSet hzzzzzzp_ = this.Observation_Services(context);
                    IEnumerable<Encounter> hzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? hzzzzzzr_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> jzzzzzzj_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? jzzzzzzk_ = jzzzzzzj_?.Value;
                        Code<Encounter.EncounterStatus> jzzzzzzl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jzzzzzzk_);
                        bool? jzzzzzzm_ = context.Operators.Equal(jzzzzzzl_, "finished");
                        Period jzzzzzzn_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> jzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzn_);
                        CqlDateTime jzzzzzzp_ = context.Operators.End(jzzzzzzo_);
                        Period jzzzzzzq_ = Visit?.Period;
                        CqlInterval<CqlDateTime> jzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzq_);
                        CqlDateTime jzzzzzzs_ = context.Operators.Start(jzzzzzzr_);
                        CqlQuantity jzzzzzzt_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime jzzzzzzu_ = context.Operators.Subtract(jzzzzzzs_, jzzzzzzt_);
                        CqlInterval<CqlDateTime> jzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzq_);
                        CqlDateTime jzzzzzzx_ = context.Operators.Start(jzzzzzzw_);
                        CqlInterval<CqlDateTime> jzzzzzzy_ = context.Operators.Interval(jzzzzzzu_, jzzzzzzx_, true, true);
                        bool? jzzzzzzz_ = context.Operators.In<CqlDateTime>(jzzzzzzp_, jzzzzzzy_, default);
                        CqlInterval<CqlDateTime> kzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzq_);
                        CqlDateTime kzzzzzzc_ = context.Operators.Start(kzzzzzzb_);
                        bool? kzzzzzzd_ = context.Operators.Not((bool?)(kzzzzzzc_ is null));
                        bool? kzzzzzze_ = context.Operators.And(jzzzzzzz_, kzzzzzzd_);
                        bool? kzzzzzzf_ = context.Operators.And(jzzzzzzm_, kzzzzzze_);

                        return kzzzzzzf_;
                    };
                    IEnumerable<Encounter> hzzzzzzs_ = context.Operators.Where<Encounter>(hzzzzzzq_, hzzzzzzr_);
                    object hzzzzzzt_(Encounter @this)
                    {
                        Period kzzzzzzg_ = @this?.Period;
                        CqlInterval<CqlDateTime> kzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzg_);
                        CqlDateTime kzzzzzzi_ = context.Operators.End(kzzzzzzh_);

                        return kzzzzzzi_;
                    };
                    IEnumerable<Encounter> hzzzzzzu_ = context.Operators.SortBy<Encounter>(hzzzzzzs_, hzzzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter hzzzzzzv_ = context.Operators.Last<Encounter>(hzzzzzzu_);
                    Period hzzzzzzw_ = hzzzzzzv_?.Period;
                    CqlInterval<CqlDateTime> hzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzw_);
                    CqlDateTime hzzzzzzy_ = context.Operators.Start(hzzzzzzx_);
                    Period hzzzzzzz_ = Visit?.Period;
                    CqlInterval<CqlDateTime> izzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzz_);
                    CqlDateTime izzzzzzb_ = context.Operators.Start(izzzzzza_);
                    CqlQuantity izzzzzzc_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime izzzzzzd_ = context.Operators.Subtract(hzzzzzzy_ ?? izzzzzzb_, izzzzzzc_);
                    IEnumerable<Encounter> izzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? izzzzzzg_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> kzzzzzzj_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? kzzzzzzk_ = kzzzzzzj_?.Value;
                        Code<Encounter.EncounterStatus> kzzzzzzl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(kzzzzzzk_);
                        bool? kzzzzzzm_ = context.Operators.Equal(kzzzzzzl_, "finished");
                        Period kzzzzzzn_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> kzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzn_);
                        CqlDateTime kzzzzzzp_ = context.Operators.End(kzzzzzzo_);
                        Period kzzzzzzq_ = Visit?.Period;
                        CqlInterval<CqlDateTime> kzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzq_);
                        CqlDateTime kzzzzzzs_ = context.Operators.Start(kzzzzzzr_);
                        CqlQuantity kzzzzzzt_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime kzzzzzzu_ = context.Operators.Subtract(kzzzzzzs_, kzzzzzzt_);
                        CqlInterval<CqlDateTime> kzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzq_);
                        CqlDateTime kzzzzzzx_ = context.Operators.Start(kzzzzzzw_);
                        CqlInterval<CqlDateTime> kzzzzzzy_ = context.Operators.Interval(kzzzzzzu_, kzzzzzzx_, true, true);
                        bool? kzzzzzzz_ = context.Operators.In<CqlDateTime>(kzzzzzzp_, kzzzzzzy_, default);
                        CqlInterval<CqlDateTime> lzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzq_);
                        CqlDateTime lzzzzzzc_ = context.Operators.Start(lzzzzzzb_);
                        bool? lzzzzzzd_ = context.Operators.Not((bool?)(lzzzzzzc_ is null));
                        bool? lzzzzzze_ = context.Operators.And(kzzzzzzz_, lzzzzzzd_);
                        bool? lzzzzzzf_ = context.Operators.And(kzzzzzzm_, lzzzzzze_);

                        return lzzzzzzf_;
                    };
                    IEnumerable<Encounter> izzzzzzh_ = context.Operators.Where<Encounter>(izzzzzzf_, izzzzzzg_);
                    object izzzzzzi_(Encounter @this)
                    {
                        Period lzzzzzzg_ = @this?.Period;
                        CqlInterval<CqlDateTime> lzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzg_);
                        CqlDateTime lzzzzzzi_ = context.Operators.End(lzzzzzzh_);

                        return lzzzzzzi_;
                    };
                    IEnumerable<Encounter> izzzzzzj_ = context.Operators.SortBy<Encounter>(izzzzzzh_, izzzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter izzzzzzk_ = context.Operators.Last<Encounter>(izzzzzzj_);
                    Period izzzzzzl_ = izzzzzzk_?.Period;
                    CqlInterval<CqlDateTime> izzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzl_);
                    CqlDateTime izzzzzzn_ = context.Operators.Start(izzzzzzm_);
                    CqlInterval<CqlDateTime> izzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzz_);
                    CqlDateTime izzzzzzq_ = context.Operators.Start(izzzzzzp_);
                    CqlInterval<CqlDateTime> izzzzzzr_ = context.Operators.Interval(izzzzzzd_, izzzzzzn_ ?? izzzzzzq_, true, true);
                    bool? izzzzzzs_ = context.Operators.In<CqlDateTime>(hzzzzzzo_, izzzzzzr_, default);
                    IEnumerable<Encounter> izzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? izzzzzzv_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> lzzzzzzj_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? lzzzzzzk_ = lzzzzzzj_?.Value;
                        Code<Encounter.EncounterStatus> lzzzzzzl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lzzzzzzk_);
                        bool? lzzzzzzm_ = context.Operators.Equal(lzzzzzzl_, "finished");
                        Period lzzzzzzn_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> lzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzn_);
                        CqlDateTime lzzzzzzp_ = context.Operators.End(lzzzzzzo_);
                        Period lzzzzzzq_ = Visit?.Period;
                        CqlInterval<CqlDateTime> lzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzq_);
                        CqlDateTime lzzzzzzs_ = context.Operators.Start(lzzzzzzr_);
                        CqlQuantity lzzzzzzt_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime lzzzzzzu_ = context.Operators.Subtract(lzzzzzzs_, lzzzzzzt_);
                        CqlInterval<CqlDateTime> lzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzq_);
                        CqlDateTime lzzzzzzx_ = context.Operators.Start(lzzzzzzw_);
                        CqlInterval<CqlDateTime> lzzzzzzy_ = context.Operators.Interval(lzzzzzzu_, lzzzzzzx_, true, true);
                        bool? lzzzzzzz_ = context.Operators.In<CqlDateTime>(lzzzzzzp_, lzzzzzzy_, default);
                        CqlInterval<CqlDateTime> mzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzq_);
                        CqlDateTime mzzzzzzc_ = context.Operators.Start(mzzzzzzb_);
                        bool? mzzzzzzd_ = context.Operators.Not((bool?)(mzzzzzzc_ is null));
                        bool? mzzzzzze_ = context.Operators.And(lzzzzzzz_, mzzzzzzd_);
                        bool? mzzzzzzf_ = context.Operators.And(lzzzzzzm_, mzzzzzze_);

                        return mzzzzzzf_;
                    };
                    IEnumerable<Encounter> izzzzzzw_ = context.Operators.Where<Encounter>(izzzzzzu_, izzzzzzv_);
                    object izzzzzzx_(Encounter @this)
                    {
                        Period mzzzzzzg_ = @this?.Period;
                        CqlInterval<CqlDateTime> mzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzg_);
                        CqlDateTime mzzzzzzi_ = context.Operators.End(mzzzzzzh_);

                        return mzzzzzzi_;
                    };
                    IEnumerable<Encounter> izzzzzzy_ = context.Operators.SortBy<Encounter>(izzzzzzw_, izzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter izzzzzzz_ = context.Operators.Last<Encounter>(izzzzzzy_);
                    Period jzzzzzza_ = izzzzzzz_?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzza_);
                    CqlDateTime jzzzzzzc_ = context.Operators.Start(jzzzzzzb_);
                    CqlInterval<CqlDateTime> jzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzz_);
                    CqlDateTime jzzzzzzf_ = context.Operators.Start(jzzzzzze_);
                    bool? jzzzzzzg_ = context.Operators.Not((bool?)((jzzzzzzc_ ?? jzzzzzzf_) is null));
                    bool? jzzzzzzh_ = context.Operators.And(izzzzzzs_, jzzzzzzg_);
                    bool? jzzzzzzi_ = context.Operators.And(hzzzzzzl_, jzzzzzzh_);

                    return jzzzzzzi_;
                };
                IEnumerable<Encounter> uzzzzze_ = context.Operators.Where<Encounter>(uzzzzzc_, uzzzzzd_);
                object uzzzzzf_(Encounter @this)
                {
                    Period mzzzzzzj_ = @this?.Period;
                    CqlInterval<CqlDateTime> mzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzj_);
                    CqlDateTime mzzzzzzl_ = context.Operators.End(mzzzzzzk_);

                    return mzzzzzzl_;
                };
                IEnumerable<Encounter> uzzzzzg_ = context.Operators.SortBy<Encounter>(uzzzzze_, uzzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter uzzzzzh_ = context.Operators.Last<Encounter>(uzzzzzg_);
                Period uzzzzzi_ = uzzzzzh_?.Period;
                CqlInterval<CqlDateTime> uzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzi_);
                CqlDateTime uzzzzzk_ = context.Operators.Start(uzzzzzj_);
                IEnumerable<Encounter> uzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? uzzzzzn_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> mzzzzzzm_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? mzzzzzzn_ = mzzzzzzm_?.Value;
                    Code<Encounter.EncounterStatus> mzzzzzzo_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(mzzzzzzn_);
                    bool? mzzzzzzp_ = context.Operators.Equal(mzzzzzzo_, "finished");
                    Period mzzzzzzq_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> mzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzq_);
                    CqlDateTime mzzzzzzs_ = context.Operators.End(mzzzzzzr_);
                    Period mzzzzzzt_ = Visit?.Period;
                    CqlInterval<CqlDateTime> mzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzt_);
                    CqlDateTime mzzzzzzv_ = context.Operators.Start(mzzzzzzu_);
                    CqlQuantity mzzzzzzw_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime mzzzzzzx_ = context.Operators.Subtract(mzzzzzzv_, mzzzzzzw_);
                    CqlInterval<CqlDateTime> mzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzt_);
                    CqlDateTime nzzzzzza_ = context.Operators.Start(mzzzzzzz_);
                    CqlInterval<CqlDateTime> nzzzzzzb_ = context.Operators.Interval(mzzzzzzx_, nzzzzzza_, true, true);
                    bool? nzzzzzzc_ = context.Operators.In<CqlDateTime>(mzzzzzzs_, nzzzzzzb_, default);
                    CqlInterval<CqlDateTime> nzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzt_);
                    CqlDateTime nzzzzzzf_ = context.Operators.Start(nzzzzzze_);
                    bool? nzzzzzzg_ = context.Operators.Not((bool?)(nzzzzzzf_ is null));
                    bool? nzzzzzzh_ = context.Operators.And(nzzzzzzc_, nzzzzzzg_);
                    bool? nzzzzzzi_ = context.Operators.And(mzzzzzzp_, nzzzzzzh_);

                    return nzzzzzzi_;
                };
                IEnumerable<Encounter> uzzzzzo_ = context.Operators.Where<Encounter>(uzzzzzm_, uzzzzzn_);
                object uzzzzzp_(Encounter @this)
                {
                    Period nzzzzzzj_ = @this?.Period;
                    CqlInterval<CqlDateTime> nzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzj_);
                    CqlDateTime nzzzzzzl_ = context.Operators.End(nzzzzzzk_);

                    return nzzzzzzl_;
                };
                IEnumerable<Encounter> uzzzzzq_ = context.Operators.SortBy<Encounter>(uzzzzzo_, uzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter uzzzzzr_ = context.Operators.Last<Encounter>(uzzzzzq_);
                Period uzzzzzs_ = uzzzzzr_?.Period;
                CqlInterval<CqlDateTime> uzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzs_);
                CqlDateTime uzzzzzu_ = context.Operators.Start(uzzzzzt_);
                CqlInterval<CqlDateTime> uzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzx_);
                CqlDateTime uzzzzzx_ = context.Operators.Start(uzzzzzw_);
                bool? uzzzzzy_ = context.Operators.Not((bool?)((uzzzzzk_ ?? uzzzzzu_ ?? uzzzzzx_) is null));
                bool? uzzzzzz_ = context.Operators.And(uzzzzza_, uzzzzzy_);

                return uzzzzzz_;
            };
            IEnumerable<Encounter> qzzzzzs_ = context.Operators.Where<Encounter>(qzzzzzq_, qzzzzzr_);
            object qzzzzzt_(Encounter @this)
            {
                Period nzzzzzzm_ = @this?.Period;
                CqlInterval<CqlDateTime> nzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzm_);
                CqlDateTime nzzzzzzo_ = context.Operators.End(nzzzzzzn_);

                return nzzzzzzo_;
            };
            IEnumerable<Encounter> qzzzzzu_ = context.Operators.SortBy<Encounter>(qzzzzzs_, qzzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter qzzzzzv_ = context.Operators.Last<Encounter>(qzzzzzu_);
            Period qzzzzzw_ = qzzzzzv_?.Period;
            CqlInterval<CqlDateTime> qzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzw_);
            CqlDateTime qzzzzzy_ = context.Operators.Start(qzzzzzx_);
            CqlValueSet qzzzzzz_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> rzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? rzzzzzb_(Encounter LastED)
            {
                Code<Encounter.EncounterStatus> nzzzzzzp_ = LastED?.StatusElement;
                Encounter.EncounterStatus? nzzzzzzq_ = nzzzzzzp_?.Value;
                Code<Encounter.EncounterStatus> nzzzzzzr_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(nzzzzzzq_);
                bool? nzzzzzzs_ = context.Operators.Equal(nzzzzzzr_, "finished");
                Period nzzzzzzt_ = LastED?.Period;
                CqlInterval<CqlDateTime> nzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzt_);
                CqlDateTime nzzzzzzv_ = context.Operators.End(nzzzzzzu_);
                CqlValueSet nzzzzzzw_ = this.Observation_Services(context);
                IEnumerable<Encounter> nzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? nzzzzzzy_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> pzzzzzzq_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? pzzzzzzr_ = pzzzzzzq_?.Value;
                    Code<Encounter.EncounterStatus> pzzzzzzs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pzzzzzzr_);
                    bool? pzzzzzzt_ = context.Operators.Equal(pzzzzzzs_, "finished");
                    Period pzzzzzzu_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> pzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzu_);
                    CqlDateTime pzzzzzzw_ = context.Operators.End(pzzzzzzv_);
                    Period pzzzzzzx_ = Visit?.Period;
                    CqlInterval<CqlDateTime> pzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzx_);
                    CqlDateTime pzzzzzzz_ = context.Operators.Start(pzzzzzzy_);
                    CqlQuantity qzzzzzza_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime qzzzzzzb_ = context.Operators.Subtract(pzzzzzzz_, qzzzzzza_);
                    CqlInterval<CqlDateTime> qzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzx_);
                    CqlDateTime qzzzzzze_ = context.Operators.Start(qzzzzzzd_);
                    CqlInterval<CqlDateTime> qzzzzzzf_ = context.Operators.Interval(qzzzzzzb_, qzzzzzze_, true, true);
                    bool? qzzzzzzg_ = context.Operators.In<CqlDateTime>(pzzzzzzw_, qzzzzzzf_, default);
                    CqlInterval<CqlDateTime> qzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzx_);
                    CqlDateTime qzzzzzzj_ = context.Operators.Start(qzzzzzzi_);
                    bool? qzzzzzzk_ = context.Operators.Not((bool?)(qzzzzzzj_ is null));
                    bool? qzzzzzzl_ = context.Operators.And(qzzzzzzg_, qzzzzzzk_);
                    bool? qzzzzzzm_ = context.Operators.And(pzzzzzzt_, qzzzzzzl_);

                    return qzzzzzzm_;
                };
                IEnumerable<Encounter> nzzzzzzz_ = context.Operators.Where<Encounter>(nzzzzzzx_, nzzzzzzy_);
                object ozzzzzza_(Encounter @this)
                {
                    Period qzzzzzzn_ = @this?.Period;
                    CqlInterval<CqlDateTime> qzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzn_);
                    CqlDateTime qzzzzzzp_ = context.Operators.End(qzzzzzzo_);

                    return qzzzzzzp_;
                };
                IEnumerable<Encounter> ozzzzzzb_ = context.Operators.SortBy<Encounter>(nzzzzzzz_, ozzzzzza_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter ozzzzzzc_ = context.Operators.Last<Encounter>(ozzzzzzb_);
                Period ozzzzzzd_ = ozzzzzzc_?.Period;
                CqlInterval<CqlDateTime> ozzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzd_);
                CqlDateTime ozzzzzzf_ = context.Operators.Start(ozzzzzze_);
                Period ozzzzzzg_ = Visit?.Period;
                CqlInterval<CqlDateTime> ozzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzg_);
                CqlDateTime ozzzzzzi_ = context.Operators.Start(ozzzzzzh_);
                CqlQuantity ozzzzzzj_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime ozzzzzzk_ = context.Operators.Subtract(ozzzzzzf_ ?? ozzzzzzi_, ozzzzzzj_);
                IEnumerable<Encounter> ozzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? ozzzzzzn_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> qzzzzzzq_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? qzzzzzzr_ = qzzzzzzq_?.Value;
                    Code<Encounter.EncounterStatus> qzzzzzzs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(qzzzzzzr_);
                    bool? qzzzzzzt_ = context.Operators.Equal(qzzzzzzs_, "finished");
                    Period qzzzzzzu_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> qzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzu_);
                    CqlDateTime qzzzzzzw_ = context.Operators.End(qzzzzzzv_);
                    Period qzzzzzzx_ = Visit?.Period;
                    CqlInterval<CqlDateTime> qzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzx_);
                    CqlDateTime qzzzzzzz_ = context.Operators.Start(qzzzzzzy_);
                    CqlQuantity rzzzzzza_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime rzzzzzzb_ = context.Operators.Subtract(qzzzzzzz_, rzzzzzza_);
                    CqlInterval<CqlDateTime> rzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzx_);
                    CqlDateTime rzzzzzze_ = context.Operators.Start(rzzzzzzd_);
                    CqlInterval<CqlDateTime> rzzzzzzf_ = context.Operators.Interval(rzzzzzzb_, rzzzzzze_, true, true);
                    bool? rzzzzzzg_ = context.Operators.In<CqlDateTime>(qzzzzzzw_, rzzzzzzf_, default);
                    CqlInterval<CqlDateTime> rzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzx_);
                    CqlDateTime rzzzzzzj_ = context.Operators.Start(rzzzzzzi_);
                    bool? rzzzzzzk_ = context.Operators.Not((bool?)(rzzzzzzj_ is null));
                    bool? rzzzzzzl_ = context.Operators.And(rzzzzzzg_, rzzzzzzk_);
                    bool? rzzzzzzm_ = context.Operators.And(qzzzzzzt_, rzzzzzzl_);

                    return rzzzzzzm_;
                };
                IEnumerable<Encounter> ozzzzzzo_ = context.Operators.Where<Encounter>(ozzzzzzm_, ozzzzzzn_);
                object ozzzzzzp_(Encounter @this)
                {
                    Period rzzzzzzn_ = @this?.Period;
                    CqlInterval<CqlDateTime> rzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzn_);
                    CqlDateTime rzzzzzzp_ = context.Operators.End(rzzzzzzo_);

                    return rzzzzzzp_;
                };
                IEnumerable<Encounter> ozzzzzzq_ = context.Operators.SortBy<Encounter>(ozzzzzzo_, ozzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter ozzzzzzr_ = context.Operators.Last<Encounter>(ozzzzzzq_);
                Period ozzzzzzs_ = ozzzzzzr_?.Period;
                CqlInterval<CqlDateTime> ozzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzs_);
                CqlDateTime ozzzzzzu_ = context.Operators.Start(ozzzzzzt_);
                CqlInterval<CqlDateTime> ozzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzg_);
                CqlDateTime ozzzzzzx_ = context.Operators.Start(ozzzzzzw_);
                CqlInterval<CqlDateTime> ozzzzzzy_ = context.Operators.Interval(ozzzzzzk_, ozzzzzzu_ ?? ozzzzzzx_, true, true);
                bool? ozzzzzzz_ = context.Operators.In<CqlDateTime>(nzzzzzzv_, ozzzzzzy_, default);
                IEnumerable<Encounter> pzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? pzzzzzzc_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> rzzzzzzq_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? rzzzzzzr_ = rzzzzzzq_?.Value;
                    Code<Encounter.EncounterStatus> rzzzzzzs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rzzzzzzr_);
                    bool? rzzzzzzt_ = context.Operators.Equal(rzzzzzzs_, "finished");
                    Period rzzzzzzu_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> rzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzu_);
                    CqlDateTime rzzzzzzw_ = context.Operators.End(rzzzzzzv_);
                    Period rzzzzzzx_ = Visit?.Period;
                    CqlInterval<CqlDateTime> rzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzx_);
                    CqlDateTime rzzzzzzz_ = context.Operators.Start(rzzzzzzy_);
                    CqlQuantity szzzzzza_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime szzzzzzb_ = context.Operators.Subtract(rzzzzzzz_, szzzzzza_);
                    CqlInterval<CqlDateTime> szzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzx_);
                    CqlDateTime szzzzzze_ = context.Operators.Start(szzzzzzd_);
                    CqlInterval<CqlDateTime> szzzzzzf_ = context.Operators.Interval(szzzzzzb_, szzzzzze_, true, true);
                    bool? szzzzzzg_ = context.Operators.In<CqlDateTime>(rzzzzzzw_, szzzzzzf_, default);
                    CqlInterval<CqlDateTime> szzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzx_);
                    CqlDateTime szzzzzzj_ = context.Operators.Start(szzzzzzi_);
                    bool? szzzzzzk_ = context.Operators.Not((bool?)(szzzzzzj_ is null));
                    bool? szzzzzzl_ = context.Operators.And(szzzzzzg_, szzzzzzk_);
                    bool? szzzzzzm_ = context.Operators.And(rzzzzzzt_, szzzzzzl_);

                    return szzzzzzm_;
                };
                IEnumerable<Encounter> pzzzzzzd_ = context.Operators.Where<Encounter>(pzzzzzzb_, pzzzzzzc_);
                object pzzzzzze_(Encounter @this)
                {
                    Period szzzzzzn_ = @this?.Period;
                    CqlInterval<CqlDateTime> szzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzn_);
                    CqlDateTime szzzzzzp_ = context.Operators.End(szzzzzzo_);

                    return szzzzzzp_;
                };
                IEnumerable<Encounter> pzzzzzzf_ = context.Operators.SortBy<Encounter>(pzzzzzzd_, pzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter pzzzzzzg_ = context.Operators.Last<Encounter>(pzzzzzzf_);
                Period pzzzzzzh_ = pzzzzzzg_?.Period;
                CqlInterval<CqlDateTime> pzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzh_);
                CqlDateTime pzzzzzzj_ = context.Operators.Start(pzzzzzzi_);
                CqlInterval<CqlDateTime> pzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzg_);
                CqlDateTime pzzzzzzm_ = context.Operators.Start(pzzzzzzl_);
                bool? pzzzzzzn_ = context.Operators.Not((bool?)((pzzzzzzj_ ?? pzzzzzzm_) is null));
                bool? pzzzzzzo_ = context.Operators.And(ozzzzzzz_, pzzzzzzn_);
                bool? pzzzzzzp_ = context.Operators.And(nzzzzzzs_, pzzzzzzo_);

                return pzzzzzzp_;
            };
            IEnumerable<Encounter> rzzzzzc_ = context.Operators.Where<Encounter>(rzzzzza_, rzzzzzb_);
            object rzzzzzd_(Encounter @this)
            {
                Period szzzzzzq_ = @this?.Period;
                CqlInterval<CqlDateTime> szzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzq_);
                CqlDateTime szzzzzzs_ = context.Operators.End(szzzzzzr_);

                return szzzzzzs_;
            };
            IEnumerable<Encounter> rzzzzze_ = context.Operators.SortBy<Encounter>(rzzzzzc_, rzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter rzzzzzf_ = context.Operators.Last<Encounter>(rzzzzze_);
            Period rzzzzzg_ = rzzzzzf_?.Period;
            CqlInterval<CqlDateTime> rzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzg_);
            CqlDateTime rzzzzzi_ = context.Operators.Start(rzzzzzh_);
            CqlValueSet rzzzzzj_ = this.Observation_Services(context);
            IEnumerable<Encounter> rzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? rzzzzzl_(Encounter LastObs)
            {
                Code<Encounter.EncounterStatus> szzzzzzt_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? szzzzzzu_ = szzzzzzt_?.Value;
                Code<Encounter.EncounterStatus> szzzzzzv_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(szzzzzzu_);
                bool? szzzzzzw_ = context.Operators.Equal(szzzzzzv_, "finished");
                Period szzzzzzx_ = LastObs?.Period;
                CqlInterval<CqlDateTime> szzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzx_);
                CqlDateTime szzzzzzz_ = context.Operators.End(szzzzzzy_);
                Period tzzzzzza_ = Visit?.Period;
                CqlInterval<CqlDateTime> tzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzza_);
                CqlDateTime tzzzzzzc_ = context.Operators.Start(tzzzzzzb_);
                CqlQuantity tzzzzzzd_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime tzzzzzze_ = context.Operators.Subtract(tzzzzzzc_, tzzzzzzd_);
                CqlInterval<CqlDateTime> tzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzza_);
                CqlDateTime tzzzzzzh_ = context.Operators.Start(tzzzzzzg_);
                CqlInterval<CqlDateTime> tzzzzzzi_ = context.Operators.Interval(tzzzzzze_, tzzzzzzh_, true, true);
                bool? tzzzzzzj_ = context.Operators.In<CqlDateTime>(szzzzzzz_, tzzzzzzi_, default);
                CqlInterval<CqlDateTime> tzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzza_);
                CqlDateTime tzzzzzzm_ = context.Operators.Start(tzzzzzzl_);
                bool? tzzzzzzn_ = context.Operators.Not((bool?)(tzzzzzzm_ is null));
                bool? tzzzzzzo_ = context.Operators.And(tzzzzzzj_, tzzzzzzn_);
                bool? tzzzzzzp_ = context.Operators.And(szzzzzzw_, tzzzzzzo_);

                return tzzzzzzp_;
            };
            IEnumerable<Encounter> rzzzzzm_ = context.Operators.Where<Encounter>(rzzzzzk_, rzzzzzl_);
            object rzzzzzn_(Encounter @this)
            {
                Period tzzzzzzq_ = @this?.Period;
                CqlInterval<CqlDateTime> tzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzq_);
                CqlDateTime tzzzzzzs_ = context.Operators.End(tzzzzzzr_);

                return tzzzzzzs_;
            };
            IEnumerable<Encounter> rzzzzzo_ = context.Operators.SortBy<Encounter>(rzzzzzm_, rzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter rzzzzzp_ = context.Operators.Last<Encounter>(rzzzzzo_);
            Period rzzzzzq_ = rzzzzzp_?.Period;
            CqlInterval<CqlDateTime> rzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzq_);
            CqlDateTime rzzzzzs_ = context.Operators.Start(rzzzzzr_);
            Period rzzzzzt_ = Visit?.Period;
            CqlInterval<CqlDateTime> rzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzt_);
            CqlDateTime rzzzzzv_ = context.Operators.Start(rzzzzzu_);
            CqlInterval<CqlDateTime> rzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzt_);
            CqlDateTime rzzzzzy_ = context.Operators.End(rzzzzzx_);
            CqlInterval<CqlDateTime> rzzzzzz_ = context.Operators.Interval(qzzzzzy_ ?? rzzzzzi_ ?? rzzzzzs_ ?? rzzzzzv_, rzzzzzy_, true, true);

            return rzzzzzz_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> qzzzzzm_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)qzzzzzk_, qzzzzzl_);
        IEnumerable<CqlInterval<CqlDateTime>> qzzzzzn_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(qzzzzzm_);
        CqlInterval<CqlDateTime> qzzzzzo_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(qzzzzzn_);

        return qzzzzzo_;
    }


    [CqlExpressionDefinition("hospitalizationWithObservationAndOutpatientSurgeryService")]
    [CqlTag("description", "Hospitalization with Observation and Outpatient Surgery Service returns the total interval from the start of any immediately prior emergency department visit, outpatient surgery visit or observation visit to the discharge of the given encounter.")]
    public CqlInterval<CqlDateTime> hospitalizationWithObservationAndOutpatientSurgeryService(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] tzzzzzzt_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> tzzzzzzu_(Encounter Visit)
        {
            CqlValueSet tzzzzzzy_ = this.Outpatient_Surgery_Service(context);
            IEnumerable<Encounter> tzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? uzzzzzza_(Encounter LastSurgeryOP)
            {
                Period vzzzzzzj_ = LastSurgeryOP?.Period;
                CqlInterval<CqlDateTime> vzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzj_);
                CqlDateTime vzzzzzzl_ = context.Operators.End(vzzzzzzk_);
                CqlValueSet vzzzzzzm_ = this.Emergency_Department_Visit(context);
                IEnumerable<Encounter> vzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? vzzzzzzo_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> yzzzzzzj_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? yzzzzzzk_ = yzzzzzzj_?.Value;
                    Code<Encounter.EncounterStatus> yzzzzzzl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(yzzzzzzk_);
                    bool? yzzzzzzm_ = context.Operators.Equal(yzzzzzzl_, "finished");
                    Period yzzzzzzn_ = LastED?.Period;
                    CqlInterval<CqlDateTime> yzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzn_);
                    CqlDateTime yzzzzzzp_ = context.Operators.End(yzzzzzzo_);
                    CqlValueSet yzzzzzzq_ = this.Observation_Services(context);
                    IEnumerable<Encounter> yzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? yzzzzzzs_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> azzzzzzzk_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? azzzzzzzl_ = azzzzzzzk_?.Value;
                        Code<Encounter.EncounterStatus> azzzzzzzm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(azzzzzzzl_);
                        bool? azzzzzzzn_ = context.Operators.Equal(azzzzzzzm_, "finished");
                        Period azzzzzzzo_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> azzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzo_);
                        CqlDateTime azzzzzzzq_ = context.Operators.End(azzzzzzzp_);
                        Period azzzzzzzr_ = Visit?.Period;
                        CqlInterval<CqlDateTime> azzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzr_);
                        CqlDateTime azzzzzzzt_ = context.Operators.Start(azzzzzzzs_);
                        CqlQuantity azzzzzzzu_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime azzzzzzzv_ = context.Operators.Subtract(azzzzzzzt_, azzzzzzzu_);
                        CqlInterval<CqlDateTime> azzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzr_);
                        CqlDateTime azzzzzzzy_ = context.Operators.Start(azzzzzzzx_);
                        CqlInterval<CqlDateTime> azzzzzzzz_ = context.Operators.Interval(azzzzzzzv_, azzzzzzzy_, true, true);
                        bool? bzzzzzzza_ = context.Operators.In<CqlDateTime>(azzzzzzzq_, azzzzzzzz_, default);
                        CqlInterval<CqlDateTime> bzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzr_);
                        CqlDateTime bzzzzzzzd_ = context.Operators.Start(bzzzzzzzc_);
                        bool? bzzzzzzze_ = context.Operators.Not((bool?)(bzzzzzzzd_ is null));
                        bool? bzzzzzzzf_ = context.Operators.And(bzzzzzzza_, bzzzzzzze_);
                        bool? bzzzzzzzg_ = context.Operators.And(azzzzzzzn_, bzzzzzzzf_);

                        return bzzzzzzzg_;
                    };
                    IEnumerable<Encounter> yzzzzzzt_ = context.Operators.Where<Encounter>(yzzzzzzr_, yzzzzzzs_);
                    object yzzzzzzu_(Encounter @this)
                    {
                        Period bzzzzzzzh_ = @this?.Period;
                        CqlInterval<CqlDateTime> bzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzh_);
                        CqlDateTime bzzzzzzzj_ = context.Operators.End(bzzzzzzzi_);

                        return bzzzzzzzj_;
                    };
                    IEnumerable<Encounter> yzzzzzzv_ = context.Operators.SortBy<Encounter>(yzzzzzzt_, yzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter yzzzzzzw_ = context.Operators.Last<Encounter>(yzzzzzzv_);
                    Period yzzzzzzx_ = yzzzzzzw_?.Period;
                    CqlInterval<CqlDateTime> yzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzx_);
                    CqlDateTime yzzzzzzz_ = context.Operators.Start(yzzzzzzy_);
                    Period zzzzzzza_ = Visit?.Period;
                    CqlInterval<CqlDateTime> zzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzza_);
                    CqlDateTime zzzzzzzc_ = context.Operators.Start(zzzzzzzb_);
                    CqlQuantity zzzzzzzd_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime zzzzzzze_ = context.Operators.Subtract(yzzzzzzz_ ?? zzzzzzzc_, zzzzzzzd_);
                    IEnumerable<Encounter> zzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? zzzzzzzh_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> bzzzzzzzk_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? bzzzzzzzl_ = bzzzzzzzk_?.Value;
                        Code<Encounter.EncounterStatus> bzzzzzzzm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bzzzzzzzl_);
                        bool? bzzzzzzzn_ = context.Operators.Equal(bzzzzzzzm_, "finished");
                        Period bzzzzzzzo_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> bzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzo_);
                        CqlDateTime bzzzzzzzq_ = context.Operators.End(bzzzzzzzp_);
                        Period bzzzzzzzr_ = Visit?.Period;
                        CqlInterval<CqlDateTime> bzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzr_);
                        CqlDateTime bzzzzzzzt_ = context.Operators.Start(bzzzzzzzs_);
                        CqlQuantity bzzzzzzzu_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime bzzzzzzzv_ = context.Operators.Subtract(bzzzzzzzt_, bzzzzzzzu_);
                        CqlInterval<CqlDateTime> bzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzr_);
                        CqlDateTime bzzzzzzzy_ = context.Operators.Start(bzzzzzzzx_);
                        CqlInterval<CqlDateTime> bzzzzzzzz_ = context.Operators.Interval(bzzzzzzzv_, bzzzzzzzy_, true, true);
                        bool? czzzzzzza_ = context.Operators.In<CqlDateTime>(bzzzzzzzq_, bzzzzzzzz_, default);
                        CqlInterval<CqlDateTime> czzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzr_);
                        CqlDateTime czzzzzzzd_ = context.Operators.Start(czzzzzzzc_);
                        bool? czzzzzzze_ = context.Operators.Not((bool?)(czzzzzzzd_ is null));
                        bool? czzzzzzzf_ = context.Operators.And(czzzzzzza_, czzzzzzze_);
                        bool? czzzzzzzg_ = context.Operators.And(bzzzzzzzn_, czzzzzzzf_);

                        return czzzzzzzg_;
                    };
                    IEnumerable<Encounter> zzzzzzzi_ = context.Operators.Where<Encounter>(zzzzzzzg_, zzzzzzzh_);
                    object zzzzzzzj_(Encounter @this)
                    {
                        Period czzzzzzzh_ = @this?.Period;
                        CqlInterval<CqlDateTime> czzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzh_);
                        CqlDateTime czzzzzzzj_ = context.Operators.End(czzzzzzzi_);

                        return czzzzzzzj_;
                    };
                    IEnumerable<Encounter> zzzzzzzk_ = context.Operators.SortBy<Encounter>(zzzzzzzi_, zzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter zzzzzzzl_ = context.Operators.Last<Encounter>(zzzzzzzk_);
                    Period zzzzzzzm_ = zzzzzzzl_?.Period;
                    CqlInterval<CqlDateTime> zzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzm_);
                    CqlDateTime zzzzzzzo_ = context.Operators.Start(zzzzzzzn_);
                    CqlInterval<CqlDateTime> zzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzza_);
                    CqlDateTime zzzzzzzr_ = context.Operators.Start(zzzzzzzq_);
                    CqlInterval<CqlDateTime> zzzzzzzs_ = context.Operators.Interval(zzzzzzze_, zzzzzzzo_ ?? zzzzzzzr_, true, true);
                    bool? zzzzzzzt_ = context.Operators.In<CqlDateTime>(yzzzzzzp_, zzzzzzzs_, default);
                    IEnumerable<Encounter> zzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? zzzzzzzw_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> czzzzzzzk_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? czzzzzzzl_ = czzzzzzzk_?.Value;
                        Code<Encounter.EncounterStatus> czzzzzzzm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(czzzzzzzl_);
                        bool? czzzzzzzn_ = context.Operators.Equal(czzzzzzzm_, "finished");
                        Period czzzzzzzo_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> czzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzo_);
                        CqlDateTime czzzzzzzq_ = context.Operators.End(czzzzzzzp_);
                        Period czzzzzzzr_ = Visit?.Period;
                        CqlInterval<CqlDateTime> czzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzr_);
                        CqlDateTime czzzzzzzt_ = context.Operators.Start(czzzzzzzs_);
                        CqlQuantity czzzzzzzu_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime czzzzzzzv_ = context.Operators.Subtract(czzzzzzzt_, czzzzzzzu_);
                        CqlInterval<CqlDateTime> czzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzr_);
                        CqlDateTime czzzzzzzy_ = context.Operators.Start(czzzzzzzx_);
                        CqlInterval<CqlDateTime> czzzzzzzz_ = context.Operators.Interval(czzzzzzzv_, czzzzzzzy_, true, true);
                        bool? dzzzzzzza_ = context.Operators.In<CqlDateTime>(czzzzzzzq_, czzzzzzzz_, default);
                        CqlInterval<CqlDateTime> dzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzr_);
                        CqlDateTime dzzzzzzzd_ = context.Operators.Start(dzzzzzzzc_);
                        bool? dzzzzzzze_ = context.Operators.Not((bool?)(dzzzzzzzd_ is null));
                        bool? dzzzzzzzf_ = context.Operators.And(dzzzzzzza_, dzzzzzzze_);
                        bool? dzzzzzzzg_ = context.Operators.And(czzzzzzzn_, dzzzzzzzf_);

                        return dzzzzzzzg_;
                    };
                    IEnumerable<Encounter> zzzzzzzx_ = context.Operators.Where<Encounter>(zzzzzzzv_, zzzzzzzw_);
                    object zzzzzzzy_(Encounter @this)
                    {
                        Period dzzzzzzzh_ = @this?.Period;
                        CqlInterval<CqlDateTime> dzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzh_);
                        CqlDateTime dzzzzzzzj_ = context.Operators.End(dzzzzzzzi_);

                        return dzzzzzzzj_;
                    };
                    IEnumerable<Encounter> zzzzzzzz_ = context.Operators.SortBy<Encounter>(zzzzzzzx_, zzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter azzzzzzza_ = context.Operators.Last<Encounter>(zzzzzzzz_);
                    Period azzzzzzzb_ = azzzzzzza_?.Period;
                    CqlInterval<CqlDateTime> azzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzb_);
                    CqlDateTime azzzzzzzd_ = context.Operators.Start(azzzzzzzc_);
                    CqlInterval<CqlDateTime> azzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzza_);
                    CqlDateTime azzzzzzzg_ = context.Operators.Start(azzzzzzzf_);
                    bool? azzzzzzzh_ = context.Operators.Not((bool?)((azzzzzzzd_ ?? azzzzzzzg_) is null));
                    bool? azzzzzzzi_ = context.Operators.And(zzzzzzzt_, azzzzzzzh_);
                    bool? azzzzzzzj_ = context.Operators.And(yzzzzzzm_, azzzzzzzi_);

                    return azzzzzzzj_;
                };
                IEnumerable<Encounter> vzzzzzzp_ = context.Operators.Where<Encounter>(vzzzzzzn_, vzzzzzzo_);
                object vzzzzzzq_(Encounter @this)
                {
                    Period dzzzzzzzk_ = @this?.Period;
                    CqlInterval<CqlDateTime> dzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzk_);
                    CqlDateTime dzzzzzzzm_ = context.Operators.End(dzzzzzzzl_);

                    return dzzzzzzzm_;
                };
                IEnumerable<Encounter> vzzzzzzr_ = context.Operators.SortBy<Encounter>(vzzzzzzp_, vzzzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter vzzzzzzs_ = context.Operators.Last<Encounter>(vzzzzzzr_);
                Period vzzzzzzt_ = vzzzzzzs_?.Period;
                CqlInterval<CqlDateTime> vzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzt_);
                CqlDateTime vzzzzzzv_ = context.Operators.Start(vzzzzzzu_);
                CqlValueSet vzzzzzzw_ = this.Observation_Services(context);
                IEnumerable<Encounter> vzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? vzzzzzzy_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> dzzzzzzzn_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? dzzzzzzzo_ = dzzzzzzzn_?.Value;
                    Code<Encounter.EncounterStatus> dzzzzzzzp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dzzzzzzzo_);
                    bool? dzzzzzzzq_ = context.Operators.Equal(dzzzzzzzp_, "finished");
                    Period dzzzzzzzr_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> dzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzr_);
                    CqlDateTime dzzzzzzzt_ = context.Operators.End(dzzzzzzzs_);
                    Period dzzzzzzzu_ = Visit?.Period;
                    CqlInterval<CqlDateTime> dzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzu_);
                    CqlDateTime dzzzzzzzw_ = context.Operators.Start(dzzzzzzzv_);
                    CqlQuantity dzzzzzzzx_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime dzzzzzzzy_ = context.Operators.Subtract(dzzzzzzzw_, dzzzzzzzx_);
                    CqlInterval<CqlDateTime> ezzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzu_);
                    CqlDateTime ezzzzzzzb_ = context.Operators.Start(ezzzzzzza_);
                    CqlInterval<CqlDateTime> ezzzzzzzc_ = context.Operators.Interval(dzzzzzzzy_, ezzzzzzzb_, true, true);
                    bool? ezzzzzzzd_ = context.Operators.In<CqlDateTime>(dzzzzzzzt_, ezzzzzzzc_, default);
                    CqlInterval<CqlDateTime> ezzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzu_);
                    CqlDateTime ezzzzzzzg_ = context.Operators.Start(ezzzzzzzf_);
                    bool? ezzzzzzzh_ = context.Operators.Not((bool?)(ezzzzzzzg_ is null));
                    bool? ezzzzzzzi_ = context.Operators.And(ezzzzzzzd_, ezzzzzzzh_);
                    bool? ezzzzzzzj_ = context.Operators.And(dzzzzzzzq_, ezzzzzzzi_);

                    return ezzzzzzzj_;
                };
                IEnumerable<Encounter> vzzzzzzz_ = context.Operators.Where<Encounter>(vzzzzzzx_, vzzzzzzy_);
                object wzzzzzza_(Encounter @this)
                {
                    Period ezzzzzzzk_ = @this?.Period;
                    CqlInterval<CqlDateTime> ezzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzk_);
                    CqlDateTime ezzzzzzzm_ = context.Operators.End(ezzzzzzzl_);

                    return ezzzzzzzm_;
                };
                IEnumerable<Encounter> wzzzzzzb_ = context.Operators.SortBy<Encounter>(vzzzzzzz_, wzzzzzza_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter wzzzzzzc_ = context.Operators.Last<Encounter>(wzzzzzzb_);
                Period wzzzzzzd_ = wzzzzzzc_?.Period;
                CqlInterval<CqlDateTime> wzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzd_);
                CqlDateTime wzzzzzzf_ = context.Operators.Start(wzzzzzze_);
                Period wzzzzzzg_ = Visit?.Period;
                CqlInterval<CqlDateTime> wzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzg_);
                CqlDateTime wzzzzzzi_ = context.Operators.Start(wzzzzzzh_);
                CqlQuantity wzzzzzzj_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime wzzzzzzk_ = context.Operators.Subtract(vzzzzzzv_ ?? wzzzzzzf_ ?? wzzzzzzi_, wzzzzzzj_);
                IEnumerable<Encounter> wzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? wzzzzzzn_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> ezzzzzzzn_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? ezzzzzzzo_ = ezzzzzzzn_?.Value;
                    Code<Encounter.EncounterStatus> ezzzzzzzp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ezzzzzzzo_);
                    bool? ezzzzzzzq_ = context.Operators.Equal(ezzzzzzzp_, "finished");
                    Period ezzzzzzzr_ = LastED?.Period;
                    CqlInterval<CqlDateTime> ezzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzr_);
                    CqlDateTime ezzzzzzzt_ = context.Operators.End(ezzzzzzzs_);
                    CqlValueSet ezzzzzzzu_ = this.Observation_Services(context);
                    IEnumerable<Encounter> ezzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? ezzzzzzzw_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> gzzzzzzzo_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? gzzzzzzzp_ = gzzzzzzzo_?.Value;
                        Code<Encounter.EncounterStatus> gzzzzzzzq_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gzzzzzzzp_);
                        bool? gzzzzzzzr_ = context.Operators.Equal(gzzzzzzzq_, "finished");
                        Period gzzzzzzzs_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> gzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzs_);
                        CqlDateTime gzzzzzzzu_ = context.Operators.End(gzzzzzzzt_);
                        Period gzzzzzzzv_ = Visit?.Period;
                        CqlInterval<CqlDateTime> gzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzv_);
                        CqlDateTime gzzzzzzzx_ = context.Operators.Start(gzzzzzzzw_);
                        CqlQuantity gzzzzzzzy_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime gzzzzzzzz_ = context.Operators.Subtract(gzzzzzzzx_, gzzzzzzzy_);
                        CqlInterval<CqlDateTime> hzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzv_);
                        CqlDateTime hzzzzzzzc_ = context.Operators.Start(hzzzzzzzb_);
                        CqlInterval<CqlDateTime> hzzzzzzzd_ = context.Operators.Interval(gzzzzzzzz_, hzzzzzzzc_, true, true);
                        bool? hzzzzzzze_ = context.Operators.In<CqlDateTime>(gzzzzzzzu_, hzzzzzzzd_, default);
                        CqlInterval<CqlDateTime> hzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzv_);
                        CqlDateTime hzzzzzzzh_ = context.Operators.Start(hzzzzzzzg_);
                        bool? hzzzzzzzi_ = context.Operators.Not((bool?)(hzzzzzzzh_ is null));
                        bool? hzzzzzzzj_ = context.Operators.And(hzzzzzzze_, hzzzzzzzi_);
                        bool? hzzzzzzzk_ = context.Operators.And(gzzzzzzzr_, hzzzzzzzj_);

                        return hzzzzzzzk_;
                    };
                    IEnumerable<Encounter> ezzzzzzzx_ = context.Operators.Where<Encounter>(ezzzzzzzv_, ezzzzzzzw_);
                    object ezzzzzzzy_(Encounter @this)
                    {
                        Period hzzzzzzzl_ = @this?.Period;
                        CqlInterval<CqlDateTime> hzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzl_);
                        CqlDateTime hzzzzzzzn_ = context.Operators.End(hzzzzzzzm_);

                        return hzzzzzzzn_;
                    };
                    IEnumerable<Encounter> ezzzzzzzz_ = context.Operators.SortBy<Encounter>(ezzzzzzzx_, ezzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter fzzzzzzza_ = context.Operators.Last<Encounter>(ezzzzzzzz_);
                    Period fzzzzzzzb_ = fzzzzzzza_?.Period;
                    CqlInterval<CqlDateTime> fzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzb_);
                    CqlDateTime fzzzzzzzd_ = context.Operators.Start(fzzzzzzzc_);
                    Period fzzzzzzze_ = Visit?.Period;
                    CqlInterval<CqlDateTime> fzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzze_);
                    CqlDateTime fzzzzzzzg_ = context.Operators.Start(fzzzzzzzf_);
                    CqlQuantity fzzzzzzzh_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime fzzzzzzzi_ = context.Operators.Subtract(fzzzzzzzd_ ?? fzzzzzzzg_, fzzzzzzzh_);
                    IEnumerable<Encounter> fzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? fzzzzzzzl_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> hzzzzzzzo_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? hzzzzzzzp_ = hzzzzzzzo_?.Value;
                        Code<Encounter.EncounterStatus> hzzzzzzzq_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hzzzzzzzp_);
                        bool? hzzzzzzzr_ = context.Operators.Equal(hzzzzzzzq_, "finished");
                        Period hzzzzzzzs_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> hzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzs_);
                        CqlDateTime hzzzzzzzu_ = context.Operators.End(hzzzzzzzt_);
                        Period hzzzzzzzv_ = Visit?.Period;
                        CqlInterval<CqlDateTime> hzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzv_);
                        CqlDateTime hzzzzzzzx_ = context.Operators.Start(hzzzzzzzw_);
                        CqlQuantity hzzzzzzzy_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime hzzzzzzzz_ = context.Operators.Subtract(hzzzzzzzx_, hzzzzzzzy_);
                        CqlInterval<CqlDateTime> izzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzv_);
                        CqlDateTime izzzzzzzc_ = context.Operators.Start(izzzzzzzb_);
                        CqlInterval<CqlDateTime> izzzzzzzd_ = context.Operators.Interval(hzzzzzzzz_, izzzzzzzc_, true, true);
                        bool? izzzzzzze_ = context.Operators.In<CqlDateTime>(hzzzzzzzu_, izzzzzzzd_, default);
                        CqlInterval<CqlDateTime> izzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzv_);
                        CqlDateTime izzzzzzzh_ = context.Operators.Start(izzzzzzzg_);
                        bool? izzzzzzzi_ = context.Operators.Not((bool?)(izzzzzzzh_ is null));
                        bool? izzzzzzzj_ = context.Operators.And(izzzzzzze_, izzzzzzzi_);
                        bool? izzzzzzzk_ = context.Operators.And(hzzzzzzzr_, izzzzzzzj_);

                        return izzzzzzzk_;
                    };
                    IEnumerable<Encounter> fzzzzzzzm_ = context.Operators.Where<Encounter>(fzzzzzzzk_, fzzzzzzzl_);
                    object fzzzzzzzn_(Encounter @this)
                    {
                        Period izzzzzzzl_ = @this?.Period;
                        CqlInterval<CqlDateTime> izzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzl_);
                        CqlDateTime izzzzzzzn_ = context.Operators.End(izzzzzzzm_);

                        return izzzzzzzn_;
                    };
                    IEnumerable<Encounter> fzzzzzzzo_ = context.Operators.SortBy<Encounter>(fzzzzzzzm_, fzzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter fzzzzzzzp_ = context.Operators.Last<Encounter>(fzzzzzzzo_);
                    Period fzzzzzzzq_ = fzzzzzzzp_?.Period;
                    CqlInterval<CqlDateTime> fzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzq_);
                    CqlDateTime fzzzzzzzs_ = context.Operators.Start(fzzzzzzzr_);
                    CqlInterval<CqlDateTime> fzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzze_);
                    CqlDateTime fzzzzzzzv_ = context.Operators.Start(fzzzzzzzu_);
                    CqlInterval<CqlDateTime> fzzzzzzzw_ = context.Operators.Interval(fzzzzzzzi_, fzzzzzzzs_ ?? fzzzzzzzv_, true, true);
                    bool? fzzzzzzzx_ = context.Operators.In<CqlDateTime>(ezzzzzzzt_, fzzzzzzzw_, default);
                    IEnumerable<Encounter> fzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? gzzzzzzza_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> izzzzzzzo_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? izzzzzzzp_ = izzzzzzzo_?.Value;
                        Code<Encounter.EncounterStatus> izzzzzzzq_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(izzzzzzzp_);
                        bool? izzzzzzzr_ = context.Operators.Equal(izzzzzzzq_, "finished");
                        Period izzzzzzzs_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> izzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzs_);
                        CqlDateTime izzzzzzzu_ = context.Operators.End(izzzzzzzt_);
                        Period izzzzzzzv_ = Visit?.Period;
                        CqlInterval<CqlDateTime> izzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzv_);
                        CqlDateTime izzzzzzzx_ = context.Operators.Start(izzzzzzzw_);
                        CqlQuantity izzzzzzzy_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime izzzzzzzz_ = context.Operators.Subtract(izzzzzzzx_, izzzzzzzy_);
                        CqlInterval<CqlDateTime> jzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzv_);
                        CqlDateTime jzzzzzzzc_ = context.Operators.Start(jzzzzzzzb_);
                        CqlInterval<CqlDateTime> jzzzzzzzd_ = context.Operators.Interval(izzzzzzzz_, jzzzzzzzc_, true, true);
                        bool? jzzzzzzze_ = context.Operators.In<CqlDateTime>(izzzzzzzu_, jzzzzzzzd_, default);
                        CqlInterval<CqlDateTime> jzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzv_);
                        CqlDateTime jzzzzzzzh_ = context.Operators.Start(jzzzzzzzg_);
                        bool? jzzzzzzzi_ = context.Operators.Not((bool?)(jzzzzzzzh_ is null));
                        bool? jzzzzzzzj_ = context.Operators.And(jzzzzzzze_, jzzzzzzzi_);
                        bool? jzzzzzzzk_ = context.Operators.And(izzzzzzzr_, jzzzzzzzj_);

                        return jzzzzzzzk_;
                    };
                    IEnumerable<Encounter> gzzzzzzzb_ = context.Operators.Where<Encounter>(fzzzzzzzz_, gzzzzzzza_);
                    object gzzzzzzzc_(Encounter @this)
                    {
                        Period jzzzzzzzl_ = @this?.Period;
                        CqlInterval<CqlDateTime> jzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzl_);
                        CqlDateTime jzzzzzzzn_ = context.Operators.End(jzzzzzzzm_);

                        return jzzzzzzzn_;
                    };
                    IEnumerable<Encounter> gzzzzzzzd_ = context.Operators.SortBy<Encounter>(gzzzzzzzb_, gzzzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter gzzzzzzze_ = context.Operators.Last<Encounter>(gzzzzzzzd_);
                    Period gzzzzzzzf_ = gzzzzzzze_?.Period;
                    CqlInterval<CqlDateTime> gzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzf_);
                    CqlDateTime gzzzzzzzh_ = context.Operators.Start(gzzzzzzzg_);
                    CqlInterval<CqlDateTime> gzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzze_);
                    CqlDateTime gzzzzzzzk_ = context.Operators.Start(gzzzzzzzj_);
                    bool? gzzzzzzzl_ = context.Operators.Not((bool?)((gzzzzzzzh_ ?? gzzzzzzzk_) is null));
                    bool? gzzzzzzzm_ = context.Operators.And(fzzzzzzzx_, gzzzzzzzl_);
                    bool? gzzzzzzzn_ = context.Operators.And(ezzzzzzzq_, gzzzzzzzm_);

                    return gzzzzzzzn_;
                };
                IEnumerable<Encounter> wzzzzzzo_ = context.Operators.Where<Encounter>(wzzzzzzm_, wzzzzzzn_);
                object wzzzzzzp_(Encounter @this)
                {
                    Period jzzzzzzzo_ = @this?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzo_);
                    CqlDateTime jzzzzzzzq_ = context.Operators.End(jzzzzzzzp_);

                    return jzzzzzzzq_;
                };
                IEnumerable<Encounter> wzzzzzzq_ = context.Operators.SortBy<Encounter>(wzzzzzzo_, wzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter wzzzzzzr_ = context.Operators.Last<Encounter>(wzzzzzzq_);
                Period wzzzzzzs_ = wzzzzzzr_?.Period;
                CqlInterval<CqlDateTime> wzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzs_);
                CqlDateTime wzzzzzzu_ = context.Operators.Start(wzzzzzzt_);
                IEnumerable<Encounter> wzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? wzzzzzzx_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> jzzzzzzzr_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? jzzzzzzzs_ = jzzzzzzzr_?.Value;
                    Code<Encounter.EncounterStatus> jzzzzzzzt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jzzzzzzzs_);
                    bool? jzzzzzzzu_ = context.Operators.Equal(jzzzzzzzt_, "finished");
                    Period jzzzzzzzv_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzv_);
                    CqlDateTime jzzzzzzzx_ = context.Operators.End(jzzzzzzzw_);
                    Period jzzzzzzzy_ = Visit?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzy_);
                    CqlDateTime kzzzzzzza_ = context.Operators.Start(jzzzzzzzz_);
                    CqlQuantity kzzzzzzzb_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime kzzzzzzzc_ = context.Operators.Subtract(kzzzzzzza_, kzzzzzzzb_);
                    CqlInterval<CqlDateTime> kzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzy_);
                    CqlDateTime kzzzzzzzf_ = context.Operators.Start(kzzzzzzze_);
                    CqlInterval<CqlDateTime> kzzzzzzzg_ = context.Operators.Interval(kzzzzzzzc_, kzzzzzzzf_, true, true);
                    bool? kzzzzzzzh_ = context.Operators.In<CqlDateTime>(jzzzzzzzx_, kzzzzzzzg_, default);
                    CqlInterval<CqlDateTime> kzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzy_);
                    CqlDateTime kzzzzzzzk_ = context.Operators.Start(kzzzzzzzj_);
                    bool? kzzzzzzzl_ = context.Operators.Not((bool?)(kzzzzzzzk_ is null));
                    bool? kzzzzzzzm_ = context.Operators.And(kzzzzzzzh_, kzzzzzzzl_);
                    bool? kzzzzzzzn_ = context.Operators.And(jzzzzzzzu_, kzzzzzzzm_);

                    return kzzzzzzzn_;
                };
                IEnumerable<Encounter> wzzzzzzy_ = context.Operators.Where<Encounter>(wzzzzzzw_, wzzzzzzx_);
                object wzzzzzzz_(Encounter @this)
                {
                    Period kzzzzzzzo_ = @this?.Period;
                    CqlInterval<CqlDateTime> kzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzo_);
                    CqlDateTime kzzzzzzzq_ = context.Operators.End(kzzzzzzzp_);

                    return kzzzzzzzq_;
                };
                IEnumerable<Encounter> xzzzzzza_ = context.Operators.SortBy<Encounter>(wzzzzzzy_, wzzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter xzzzzzzb_ = context.Operators.Last<Encounter>(xzzzzzza_);
                Period xzzzzzzc_ = xzzzzzzb_?.Period;
                CqlInterval<CqlDateTime> xzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzc_);
                CqlDateTime xzzzzzze_ = context.Operators.Start(xzzzzzzd_);
                CqlInterval<CqlDateTime> xzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzg_);
                CqlDateTime xzzzzzzh_ = context.Operators.Start(xzzzzzzg_);
                CqlInterval<CqlDateTime> xzzzzzzi_ = context.Operators.Interval(wzzzzzzk_, wzzzzzzu_ ?? xzzzzzze_ ?? xzzzzzzh_, true, true);
                bool? xzzzzzzj_ = context.Operators.In<CqlDateTime>(vzzzzzzl_, xzzzzzzi_, default);
                IEnumerable<Encounter> xzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? xzzzzzzm_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> kzzzzzzzr_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? kzzzzzzzs_ = kzzzzzzzr_?.Value;
                    Code<Encounter.EncounterStatus> kzzzzzzzt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(kzzzzzzzs_);
                    bool? kzzzzzzzu_ = context.Operators.Equal(kzzzzzzzt_, "finished");
                    Period kzzzzzzzv_ = LastED?.Period;
                    CqlInterval<CqlDateTime> kzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzv_);
                    CqlDateTime kzzzzzzzx_ = context.Operators.End(kzzzzzzzw_);
                    CqlValueSet kzzzzzzzy_ = this.Observation_Services(context);
                    IEnumerable<Encounter> kzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? lzzzzzzza_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> mzzzzzzzs_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? mzzzzzzzt_ = mzzzzzzzs_?.Value;
                        Code<Encounter.EncounterStatus> mzzzzzzzu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(mzzzzzzzt_);
                        bool? mzzzzzzzv_ = context.Operators.Equal(mzzzzzzzu_, "finished");
                        Period mzzzzzzzw_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> mzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzw_);
                        CqlDateTime mzzzzzzzy_ = context.Operators.End(mzzzzzzzx_);
                        Period mzzzzzzzz_ = Visit?.Period;
                        CqlInterval<CqlDateTime> nzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzz_);
                        CqlDateTime nzzzzzzzb_ = context.Operators.Start(nzzzzzzza_);
                        CqlQuantity nzzzzzzzc_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime nzzzzzzzd_ = context.Operators.Subtract(nzzzzzzzb_, nzzzzzzzc_);
                        CqlInterval<CqlDateTime> nzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzz_);
                        CqlDateTime nzzzzzzzg_ = context.Operators.Start(nzzzzzzzf_);
                        CqlInterval<CqlDateTime> nzzzzzzzh_ = context.Operators.Interval(nzzzzzzzd_, nzzzzzzzg_, true, true);
                        bool? nzzzzzzzi_ = context.Operators.In<CqlDateTime>(mzzzzzzzy_, nzzzzzzzh_, default);
                        CqlInterval<CqlDateTime> nzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzz_);
                        CqlDateTime nzzzzzzzl_ = context.Operators.Start(nzzzzzzzk_);
                        bool? nzzzzzzzm_ = context.Operators.Not((bool?)(nzzzzzzzl_ is null));
                        bool? nzzzzzzzn_ = context.Operators.And(nzzzzzzzi_, nzzzzzzzm_);
                        bool? nzzzzzzzo_ = context.Operators.And(mzzzzzzzv_, nzzzzzzzn_);

                        return nzzzzzzzo_;
                    };
                    IEnumerable<Encounter> lzzzzzzzb_ = context.Operators.Where<Encounter>(kzzzzzzzz_, lzzzzzzza_);
                    object lzzzzzzzc_(Encounter @this)
                    {
                        Period nzzzzzzzp_ = @this?.Period;
                        CqlInterval<CqlDateTime> nzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzp_);
                        CqlDateTime nzzzzzzzr_ = context.Operators.End(nzzzzzzzq_);

                        return nzzzzzzzr_;
                    };
                    IEnumerable<Encounter> lzzzzzzzd_ = context.Operators.SortBy<Encounter>(lzzzzzzzb_, lzzzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter lzzzzzzze_ = context.Operators.Last<Encounter>(lzzzzzzzd_);
                    Period lzzzzzzzf_ = lzzzzzzze_?.Period;
                    CqlInterval<CqlDateTime> lzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzf_);
                    CqlDateTime lzzzzzzzh_ = context.Operators.Start(lzzzzzzzg_);
                    Period lzzzzzzzi_ = Visit?.Period;
                    CqlInterval<CqlDateTime> lzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzi_);
                    CqlDateTime lzzzzzzzk_ = context.Operators.Start(lzzzzzzzj_);
                    CqlQuantity lzzzzzzzl_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime lzzzzzzzm_ = context.Operators.Subtract(lzzzzzzzh_ ?? lzzzzzzzk_, lzzzzzzzl_);
                    IEnumerable<Encounter> lzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? lzzzzzzzp_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> nzzzzzzzs_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? nzzzzzzzt_ = nzzzzzzzs_?.Value;
                        Code<Encounter.EncounterStatus> nzzzzzzzu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(nzzzzzzzt_);
                        bool? nzzzzzzzv_ = context.Operators.Equal(nzzzzzzzu_, "finished");
                        Period nzzzzzzzw_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> nzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzw_);
                        CqlDateTime nzzzzzzzy_ = context.Operators.End(nzzzzzzzx_);
                        Period nzzzzzzzz_ = Visit?.Period;
                        CqlInterval<CqlDateTime> ozzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzz_);
                        CqlDateTime ozzzzzzzb_ = context.Operators.Start(ozzzzzzza_);
                        CqlQuantity ozzzzzzzc_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime ozzzzzzzd_ = context.Operators.Subtract(ozzzzzzzb_, ozzzzzzzc_);
                        CqlInterval<CqlDateTime> ozzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzz_);
                        CqlDateTime ozzzzzzzg_ = context.Operators.Start(ozzzzzzzf_);
                        CqlInterval<CqlDateTime> ozzzzzzzh_ = context.Operators.Interval(ozzzzzzzd_, ozzzzzzzg_, true, true);
                        bool? ozzzzzzzi_ = context.Operators.In<CqlDateTime>(nzzzzzzzy_, ozzzzzzzh_, default);
                        CqlInterval<CqlDateTime> ozzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzz_);
                        CqlDateTime ozzzzzzzl_ = context.Operators.Start(ozzzzzzzk_);
                        bool? ozzzzzzzm_ = context.Operators.Not((bool?)(ozzzzzzzl_ is null));
                        bool? ozzzzzzzn_ = context.Operators.And(ozzzzzzzi_, ozzzzzzzm_);
                        bool? ozzzzzzzo_ = context.Operators.And(nzzzzzzzv_, ozzzzzzzn_);

                        return ozzzzzzzo_;
                    };
                    IEnumerable<Encounter> lzzzzzzzq_ = context.Operators.Where<Encounter>(lzzzzzzzo_, lzzzzzzzp_);
                    object lzzzzzzzr_(Encounter @this)
                    {
                        Period ozzzzzzzp_ = @this?.Period;
                        CqlInterval<CqlDateTime> ozzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzp_);
                        CqlDateTime ozzzzzzzr_ = context.Operators.End(ozzzzzzzq_);

                        return ozzzzzzzr_;
                    };
                    IEnumerable<Encounter> lzzzzzzzs_ = context.Operators.SortBy<Encounter>(lzzzzzzzq_, lzzzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter lzzzzzzzt_ = context.Operators.Last<Encounter>(lzzzzzzzs_);
                    Period lzzzzzzzu_ = lzzzzzzzt_?.Period;
                    CqlInterval<CqlDateTime> lzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzu_);
                    CqlDateTime lzzzzzzzw_ = context.Operators.Start(lzzzzzzzv_);
                    CqlInterval<CqlDateTime> lzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzi_);
                    CqlDateTime lzzzzzzzz_ = context.Operators.Start(lzzzzzzzy_);
                    CqlInterval<CqlDateTime> mzzzzzzza_ = context.Operators.Interval(lzzzzzzzm_, lzzzzzzzw_ ?? lzzzzzzzz_, true, true);
                    bool? mzzzzzzzb_ = context.Operators.In<CqlDateTime>(kzzzzzzzx_, mzzzzzzza_, default);
                    IEnumerable<Encounter> mzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? mzzzzzzze_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> ozzzzzzzs_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? ozzzzzzzt_ = ozzzzzzzs_?.Value;
                        Code<Encounter.EncounterStatus> ozzzzzzzu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ozzzzzzzt_);
                        bool? ozzzzzzzv_ = context.Operators.Equal(ozzzzzzzu_, "finished");
                        Period ozzzzzzzw_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> ozzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzw_);
                        CqlDateTime ozzzzzzzy_ = context.Operators.End(ozzzzzzzx_);
                        Period ozzzzzzzz_ = Visit?.Period;
                        CqlInterval<CqlDateTime> pzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzz_);
                        CqlDateTime pzzzzzzzb_ = context.Operators.Start(pzzzzzzza_);
                        CqlQuantity pzzzzzzzc_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime pzzzzzzzd_ = context.Operators.Subtract(pzzzzzzzb_, pzzzzzzzc_);
                        CqlInterval<CqlDateTime> pzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzz_);
                        CqlDateTime pzzzzzzzg_ = context.Operators.Start(pzzzzzzzf_);
                        CqlInterval<CqlDateTime> pzzzzzzzh_ = context.Operators.Interval(pzzzzzzzd_, pzzzzzzzg_, true, true);
                        bool? pzzzzzzzi_ = context.Operators.In<CqlDateTime>(ozzzzzzzy_, pzzzzzzzh_, default);
                        CqlInterval<CqlDateTime> pzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzz_);
                        CqlDateTime pzzzzzzzl_ = context.Operators.Start(pzzzzzzzk_);
                        bool? pzzzzzzzm_ = context.Operators.Not((bool?)(pzzzzzzzl_ is null));
                        bool? pzzzzzzzn_ = context.Operators.And(pzzzzzzzi_, pzzzzzzzm_);
                        bool? pzzzzzzzo_ = context.Operators.And(ozzzzzzzv_, pzzzzzzzn_);

                        return pzzzzzzzo_;
                    };
                    IEnumerable<Encounter> mzzzzzzzf_ = context.Operators.Where<Encounter>(mzzzzzzzd_, mzzzzzzze_);
                    object mzzzzzzzg_(Encounter @this)
                    {
                        Period pzzzzzzzp_ = @this?.Period;
                        CqlInterval<CqlDateTime> pzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzp_);
                        CqlDateTime pzzzzzzzr_ = context.Operators.End(pzzzzzzzq_);

                        return pzzzzzzzr_;
                    };
                    IEnumerable<Encounter> mzzzzzzzh_ = context.Operators.SortBy<Encounter>(mzzzzzzzf_, mzzzzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter mzzzzzzzi_ = context.Operators.Last<Encounter>(mzzzzzzzh_);
                    Period mzzzzzzzj_ = mzzzzzzzi_?.Period;
                    CqlInterval<CqlDateTime> mzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzj_);
                    CqlDateTime mzzzzzzzl_ = context.Operators.Start(mzzzzzzzk_);
                    CqlInterval<CqlDateTime> mzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzi_);
                    CqlDateTime mzzzzzzzo_ = context.Operators.Start(mzzzzzzzn_);
                    bool? mzzzzzzzp_ = context.Operators.Not((bool?)((mzzzzzzzl_ ?? mzzzzzzzo_) is null));
                    bool? mzzzzzzzq_ = context.Operators.And(mzzzzzzzb_, mzzzzzzzp_);
                    bool? mzzzzzzzr_ = context.Operators.And(kzzzzzzzu_, mzzzzzzzq_);

                    return mzzzzzzzr_;
                };
                IEnumerable<Encounter> xzzzzzzn_ = context.Operators.Where<Encounter>(xzzzzzzl_, xzzzzzzm_);
                object xzzzzzzo_(Encounter @this)
                {
                    Period pzzzzzzzs_ = @this?.Period;
                    CqlInterval<CqlDateTime> pzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzs_);
                    CqlDateTime pzzzzzzzu_ = context.Operators.End(pzzzzzzzt_);

                    return pzzzzzzzu_;
                };
                IEnumerable<Encounter> xzzzzzzp_ = context.Operators.SortBy<Encounter>(xzzzzzzn_, xzzzzzzo_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter xzzzzzzq_ = context.Operators.Last<Encounter>(xzzzzzzp_);
                Period xzzzzzzr_ = xzzzzzzq_?.Period;
                CqlInterval<CqlDateTime> xzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzr_);
                CqlDateTime xzzzzzzt_ = context.Operators.Start(xzzzzzzs_);
                IEnumerable<Encounter> xzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? xzzzzzzw_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> pzzzzzzzv_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? pzzzzzzzw_ = pzzzzzzzv_?.Value;
                    Code<Encounter.EncounterStatus> pzzzzzzzx_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pzzzzzzzw_);
                    bool? pzzzzzzzy_ = context.Operators.Equal(pzzzzzzzx_, "finished");
                    Period pzzzzzzzz_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> qzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzz_);
                    CqlDateTime qzzzzzzzb_ = context.Operators.End(qzzzzzzza_);
                    Period qzzzzzzzc_ = Visit?.Period;
                    CqlInterval<CqlDateTime> qzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzc_);
                    CqlDateTime qzzzzzzze_ = context.Operators.Start(qzzzzzzzd_);
                    CqlQuantity qzzzzzzzf_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime qzzzzzzzg_ = context.Operators.Subtract(qzzzzzzze_, qzzzzzzzf_);
                    CqlInterval<CqlDateTime> qzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzc_);
                    CqlDateTime qzzzzzzzj_ = context.Operators.Start(qzzzzzzzi_);
                    CqlInterval<CqlDateTime> qzzzzzzzk_ = context.Operators.Interval(qzzzzzzzg_, qzzzzzzzj_, true, true);
                    bool? qzzzzzzzl_ = context.Operators.In<CqlDateTime>(qzzzzzzzb_, qzzzzzzzk_, default);
                    CqlInterval<CqlDateTime> qzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzc_);
                    CqlDateTime qzzzzzzzo_ = context.Operators.Start(qzzzzzzzn_);
                    bool? qzzzzzzzp_ = context.Operators.Not((bool?)(qzzzzzzzo_ is null));
                    bool? qzzzzzzzq_ = context.Operators.And(qzzzzzzzl_, qzzzzzzzp_);
                    bool? qzzzzzzzr_ = context.Operators.And(pzzzzzzzy_, qzzzzzzzq_);

                    return qzzzzzzzr_;
                };
                IEnumerable<Encounter> xzzzzzzx_ = context.Operators.Where<Encounter>(xzzzzzzv_, xzzzzzzw_);
                object xzzzzzzy_(Encounter @this)
                {
                    Period qzzzzzzzs_ = @this?.Period;
                    CqlInterval<CqlDateTime> qzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzs_);
                    CqlDateTime qzzzzzzzu_ = context.Operators.End(qzzzzzzzt_);

                    return qzzzzzzzu_;
                };
                IEnumerable<Encounter> xzzzzzzz_ = context.Operators.SortBy<Encounter>(xzzzzzzx_, xzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter yzzzzzza_ = context.Operators.Last<Encounter>(xzzzzzzz_);
                Period yzzzzzzb_ = yzzzzzza_?.Period;
                CqlInterval<CqlDateTime> yzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzb_);
                CqlDateTime yzzzzzzd_ = context.Operators.Start(yzzzzzzc_);
                CqlInterval<CqlDateTime> yzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzg_);
                CqlDateTime yzzzzzzg_ = context.Operators.Start(yzzzzzzf_);
                bool? yzzzzzzh_ = context.Operators.Not((bool?)((xzzzzzzt_ ?? yzzzzzzd_ ?? yzzzzzzg_) is null));
                bool? yzzzzzzi_ = context.Operators.And(xzzzzzzj_, yzzzzzzh_);

                return yzzzzzzi_;
            };
            IEnumerable<Encounter> uzzzzzzb_ = context.Operators.Where<Encounter>(tzzzzzzz_, uzzzzzza_);
            object uzzzzzzc_(Encounter @this)
            {
                Period qzzzzzzzv_ = @this?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzv_);
                CqlDateTime qzzzzzzzx_ = context.Operators.End(qzzzzzzzw_);

                return qzzzzzzzx_;
            };
            IEnumerable<Encounter> uzzzzzzd_ = context.Operators.SortBy<Encounter>(uzzzzzzb_, uzzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter uzzzzzze_ = context.Operators.Last<Encounter>(uzzzzzzd_);
            Period uzzzzzzf_ = uzzzzzze_?.Period;
            CqlInterval<CqlDateTime> uzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzf_);
            CqlDateTime uzzzzzzh_ = context.Operators.Start(uzzzzzzg_);
            CqlValueSet uzzzzzzi_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> uzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? uzzzzzzk_(Encounter LastED)
            {
                Code<Encounter.EncounterStatus> qzzzzzzzy_ = LastED?.StatusElement;
                Encounter.EncounterStatus? qzzzzzzzz_ = qzzzzzzzy_?.Value;
                Code<Encounter.EncounterStatus> rzzzzzzza_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(qzzzzzzzz_);
                bool? rzzzzzzzb_ = context.Operators.Equal(rzzzzzzza_, "finished");
                Period rzzzzzzzc_ = LastED?.Period;
                CqlInterval<CqlDateTime> rzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzc_);
                CqlDateTime rzzzzzzze_ = context.Operators.End(rzzzzzzzd_);
                CqlValueSet rzzzzzzzf_ = this.Observation_Services(context);
                IEnumerable<Encounter> rzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? rzzzzzzzh_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> szzzzzzzz_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? tzzzzzzza_ = szzzzzzzz_?.Value;
                    Code<Encounter.EncounterStatus> tzzzzzzzb_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(tzzzzzzza_);
                    bool? tzzzzzzzc_ = context.Operators.Equal(tzzzzzzzb_, "finished");
                    Period tzzzzzzzd_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> tzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzd_);
                    CqlDateTime tzzzzzzzf_ = context.Operators.End(tzzzzzzze_);
                    Period tzzzzzzzg_ = Visit?.Period;
                    CqlInterval<CqlDateTime> tzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzg_);
                    CqlDateTime tzzzzzzzi_ = context.Operators.Start(tzzzzzzzh_);
                    CqlQuantity tzzzzzzzj_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime tzzzzzzzk_ = context.Operators.Subtract(tzzzzzzzi_, tzzzzzzzj_);
                    CqlInterval<CqlDateTime> tzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzg_);
                    CqlDateTime tzzzzzzzn_ = context.Operators.Start(tzzzzzzzm_);
                    CqlInterval<CqlDateTime> tzzzzzzzo_ = context.Operators.Interval(tzzzzzzzk_, tzzzzzzzn_, true, true);
                    bool? tzzzzzzzp_ = context.Operators.In<CqlDateTime>(tzzzzzzzf_, tzzzzzzzo_, default);
                    CqlInterval<CqlDateTime> tzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzg_);
                    CqlDateTime tzzzzzzzs_ = context.Operators.Start(tzzzzzzzr_);
                    bool? tzzzzzzzt_ = context.Operators.Not((bool?)(tzzzzzzzs_ is null));
                    bool? tzzzzzzzu_ = context.Operators.And(tzzzzzzzp_, tzzzzzzzt_);
                    bool? tzzzzzzzv_ = context.Operators.And(tzzzzzzzc_, tzzzzzzzu_);

                    return tzzzzzzzv_;
                };
                IEnumerable<Encounter> rzzzzzzzi_ = context.Operators.Where<Encounter>(rzzzzzzzg_, rzzzzzzzh_);
                object rzzzzzzzj_(Encounter @this)
                {
                    Period tzzzzzzzw_ = @this?.Period;
                    CqlInterval<CqlDateTime> tzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzw_);
                    CqlDateTime tzzzzzzzy_ = context.Operators.End(tzzzzzzzx_);

                    return tzzzzzzzy_;
                };
                IEnumerable<Encounter> rzzzzzzzk_ = context.Operators.SortBy<Encounter>(rzzzzzzzi_, rzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter rzzzzzzzl_ = context.Operators.Last<Encounter>(rzzzzzzzk_);
                Period rzzzzzzzm_ = rzzzzzzzl_?.Period;
                CqlInterval<CqlDateTime> rzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzm_);
                CqlDateTime rzzzzzzzo_ = context.Operators.Start(rzzzzzzzn_);
                Period rzzzzzzzp_ = Visit?.Period;
                CqlInterval<CqlDateTime> rzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzp_);
                CqlDateTime rzzzzzzzr_ = context.Operators.Start(rzzzzzzzq_);
                CqlQuantity rzzzzzzzs_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime rzzzzzzzt_ = context.Operators.Subtract(rzzzzzzzo_ ?? rzzzzzzzr_, rzzzzzzzs_);
                IEnumerable<Encounter> rzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? rzzzzzzzw_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> tzzzzzzzz_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? uzzzzzzza_ = tzzzzzzzz_?.Value;
                    Code<Encounter.EncounterStatus> uzzzzzzzb_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(uzzzzzzza_);
                    bool? uzzzzzzzc_ = context.Operators.Equal(uzzzzzzzb_, "finished");
                    Period uzzzzzzzd_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> uzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzd_);
                    CqlDateTime uzzzzzzzf_ = context.Operators.End(uzzzzzzze_);
                    Period uzzzzzzzg_ = Visit?.Period;
                    CqlInterval<CqlDateTime> uzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzg_);
                    CqlDateTime uzzzzzzzi_ = context.Operators.Start(uzzzzzzzh_);
                    CqlQuantity uzzzzzzzj_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime uzzzzzzzk_ = context.Operators.Subtract(uzzzzzzzi_, uzzzzzzzj_);
                    CqlInterval<CqlDateTime> uzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzg_);
                    CqlDateTime uzzzzzzzn_ = context.Operators.Start(uzzzzzzzm_);
                    CqlInterval<CqlDateTime> uzzzzzzzo_ = context.Operators.Interval(uzzzzzzzk_, uzzzzzzzn_, true, true);
                    bool? uzzzzzzzp_ = context.Operators.In<CqlDateTime>(uzzzzzzzf_, uzzzzzzzo_, default);
                    CqlInterval<CqlDateTime> uzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzg_);
                    CqlDateTime uzzzzzzzs_ = context.Operators.Start(uzzzzzzzr_);
                    bool? uzzzzzzzt_ = context.Operators.Not((bool?)(uzzzzzzzs_ is null));
                    bool? uzzzzzzzu_ = context.Operators.And(uzzzzzzzp_, uzzzzzzzt_);
                    bool? uzzzzzzzv_ = context.Operators.And(uzzzzzzzc_, uzzzzzzzu_);

                    return uzzzzzzzv_;
                };
                IEnumerable<Encounter> rzzzzzzzx_ = context.Operators.Where<Encounter>(rzzzzzzzv_, rzzzzzzzw_);
                object rzzzzzzzy_(Encounter @this)
                {
                    Period uzzzzzzzw_ = @this?.Period;
                    CqlInterval<CqlDateTime> uzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzw_);
                    CqlDateTime uzzzzzzzy_ = context.Operators.End(uzzzzzzzx_);

                    return uzzzzzzzy_;
                };
                IEnumerable<Encounter> rzzzzzzzz_ = context.Operators.SortBy<Encounter>(rzzzzzzzx_, rzzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter szzzzzzza_ = context.Operators.Last<Encounter>(rzzzzzzzz_);
                Period szzzzzzzb_ = szzzzzzza_?.Period;
                CqlInterval<CqlDateTime> szzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzb_);
                CqlDateTime szzzzzzzd_ = context.Operators.Start(szzzzzzzc_);
                CqlInterval<CqlDateTime> szzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzp_);
                CqlDateTime szzzzzzzg_ = context.Operators.Start(szzzzzzzf_);
                CqlInterval<CqlDateTime> szzzzzzzh_ = context.Operators.Interval(rzzzzzzzt_, szzzzzzzd_ ?? szzzzzzzg_, true, true);
                bool? szzzzzzzi_ = context.Operators.In<CqlDateTime>(rzzzzzzze_, szzzzzzzh_, default);
                IEnumerable<Encounter> szzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? szzzzzzzl_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> uzzzzzzzz_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? vzzzzzzza_ = uzzzzzzzz_?.Value;
                    Code<Encounter.EncounterStatus> vzzzzzzzb_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(vzzzzzzza_);
                    bool? vzzzzzzzc_ = context.Operators.Equal(vzzzzzzzb_, "finished");
                    Period vzzzzzzzd_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> vzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzd_);
                    CqlDateTime vzzzzzzzf_ = context.Operators.End(vzzzzzzze_);
                    Period vzzzzzzzg_ = Visit?.Period;
                    CqlInterval<CqlDateTime> vzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzg_);
                    CqlDateTime vzzzzzzzi_ = context.Operators.Start(vzzzzzzzh_);
                    CqlQuantity vzzzzzzzj_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime vzzzzzzzk_ = context.Operators.Subtract(vzzzzzzzi_, vzzzzzzzj_);
                    CqlInterval<CqlDateTime> vzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzg_);
                    CqlDateTime vzzzzzzzn_ = context.Operators.Start(vzzzzzzzm_);
                    CqlInterval<CqlDateTime> vzzzzzzzo_ = context.Operators.Interval(vzzzzzzzk_, vzzzzzzzn_, true, true);
                    bool? vzzzzzzzp_ = context.Operators.In<CqlDateTime>(vzzzzzzzf_, vzzzzzzzo_, default);
                    CqlInterval<CqlDateTime> vzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzg_);
                    CqlDateTime vzzzzzzzs_ = context.Operators.Start(vzzzzzzzr_);
                    bool? vzzzzzzzt_ = context.Operators.Not((bool?)(vzzzzzzzs_ is null));
                    bool? vzzzzzzzu_ = context.Operators.And(vzzzzzzzp_, vzzzzzzzt_);
                    bool? vzzzzzzzv_ = context.Operators.And(vzzzzzzzc_, vzzzzzzzu_);

                    return vzzzzzzzv_;
                };
                IEnumerable<Encounter> szzzzzzzm_ = context.Operators.Where<Encounter>(szzzzzzzk_, szzzzzzzl_);
                object szzzzzzzn_(Encounter @this)
                {
                    Period vzzzzzzzw_ = @this?.Period;
                    CqlInterval<CqlDateTime> vzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzw_);
                    CqlDateTime vzzzzzzzy_ = context.Operators.End(vzzzzzzzx_);

                    return vzzzzzzzy_;
                };
                IEnumerable<Encounter> szzzzzzzo_ = context.Operators.SortBy<Encounter>(szzzzzzzm_, szzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter szzzzzzzp_ = context.Operators.Last<Encounter>(szzzzzzzo_);
                Period szzzzzzzq_ = szzzzzzzp_?.Period;
                CqlInterval<CqlDateTime> szzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzq_);
                CqlDateTime szzzzzzzs_ = context.Operators.Start(szzzzzzzr_);
                CqlInterval<CqlDateTime> szzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzp_);
                CqlDateTime szzzzzzzv_ = context.Operators.Start(szzzzzzzu_);
                bool? szzzzzzzw_ = context.Operators.Not((bool?)((szzzzzzzs_ ?? szzzzzzzv_) is null));
                bool? szzzzzzzx_ = context.Operators.And(szzzzzzzi_, szzzzzzzw_);
                bool? szzzzzzzy_ = context.Operators.And(rzzzzzzzb_, szzzzzzzx_);

                return szzzzzzzy_;
            };
            IEnumerable<Encounter> uzzzzzzl_ = context.Operators.Where<Encounter>(uzzzzzzj_, uzzzzzzk_);
            object uzzzzzzm_(Encounter @this)
            {
                Period vzzzzzzzz_ = @this?.Period;
                CqlInterval<CqlDateTime> wzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzz_);
                CqlDateTime wzzzzzzzb_ = context.Operators.End(wzzzzzzza_);

                return wzzzzzzzb_;
            };
            IEnumerable<Encounter> uzzzzzzn_ = context.Operators.SortBy<Encounter>(uzzzzzzl_, uzzzzzzm_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter uzzzzzzo_ = context.Operators.Last<Encounter>(uzzzzzzn_);
            Period uzzzzzzp_ = uzzzzzzo_?.Period;
            CqlInterval<CqlDateTime> uzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzp_);
            CqlDateTime uzzzzzzr_ = context.Operators.Start(uzzzzzzq_);
            CqlValueSet uzzzzzzs_ = this.Observation_Services(context);
            IEnumerable<Encounter> uzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? uzzzzzzu_(Encounter LastObs)
            {
                Code<Encounter.EncounterStatus> wzzzzzzzc_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? wzzzzzzzd_ = wzzzzzzzc_?.Value;
                Code<Encounter.EncounterStatus> wzzzzzzze_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(wzzzzzzzd_);
                bool? wzzzzzzzf_ = context.Operators.Equal(wzzzzzzze_, "finished");
                Period wzzzzzzzg_ = LastObs?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzg_);
                CqlDateTime wzzzzzzzi_ = context.Operators.End(wzzzzzzzh_);
                Period wzzzzzzzj_ = Visit?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzj_);
                CqlDateTime wzzzzzzzl_ = context.Operators.Start(wzzzzzzzk_);
                CqlQuantity wzzzzzzzm_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime wzzzzzzzn_ = context.Operators.Subtract(wzzzzzzzl_, wzzzzzzzm_);
                CqlInterval<CqlDateTime> wzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzj_);
                CqlDateTime wzzzzzzzq_ = context.Operators.Start(wzzzzzzzp_);
                CqlInterval<CqlDateTime> wzzzzzzzr_ = context.Operators.Interval(wzzzzzzzn_, wzzzzzzzq_, true, true);
                bool? wzzzzzzzs_ = context.Operators.In<CqlDateTime>(wzzzzzzzi_, wzzzzzzzr_, default);
                CqlInterval<CqlDateTime> wzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzj_);
                CqlDateTime wzzzzzzzv_ = context.Operators.Start(wzzzzzzzu_);
                bool? wzzzzzzzw_ = context.Operators.Not((bool?)(wzzzzzzzv_ is null));
                bool? wzzzzzzzx_ = context.Operators.And(wzzzzzzzs_, wzzzzzzzw_);
                bool? wzzzzzzzy_ = context.Operators.And(wzzzzzzzf_, wzzzzzzzx_);

                return wzzzzzzzy_;
            };
            IEnumerable<Encounter> uzzzzzzv_ = context.Operators.Where<Encounter>(uzzzzzzt_, uzzzzzzu_);
            object uzzzzzzw_(Encounter @this)
            {
                Period wzzzzzzzz_ = @this?.Period;
                CqlInterval<CqlDateTime> xzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzz_);
                CqlDateTime xzzzzzzzb_ = context.Operators.End(xzzzzzzza_);

                return xzzzzzzzb_;
            };
            IEnumerable<Encounter> uzzzzzzx_ = context.Operators.SortBy<Encounter>(uzzzzzzv_, uzzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter uzzzzzzy_ = context.Operators.Last<Encounter>(uzzzzzzx_);
            Period uzzzzzzz_ = uzzzzzzy_?.Period;
            CqlInterval<CqlDateTime> vzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzz_);
            CqlDateTime vzzzzzzb_ = context.Operators.Start(vzzzzzza_);
            Period vzzzzzzc_ = Visit?.Period;
            CqlInterval<CqlDateTime> vzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzc_);
            CqlDateTime vzzzzzze_ = context.Operators.Start(vzzzzzzd_);
            CqlInterval<CqlDateTime> vzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzc_);
            CqlDateTime vzzzzzzh_ = context.Operators.End(vzzzzzzg_);
            CqlInterval<CqlDateTime> vzzzzzzi_ = context.Operators.Interval(uzzzzzzh_ ?? uzzzzzzr_ ?? vzzzzzzb_ ?? vzzzzzze_, vzzzzzzh_, true, true);

            return vzzzzzzi_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> tzzzzzzv_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)tzzzzzzt_, tzzzzzzu_);
        IEnumerable<CqlInterval<CqlDateTime>> tzzzzzzw_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(tzzzzzzv_);
        CqlInterval<CqlDateTime> tzzzzzzx_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(tzzzzzzw_);

        return tzzzzzzx_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservation")]
    [CqlTag("description", "Hospitalization with Observation returns the total interval from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationWithObservation()` instead.")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] xzzzzzzzc_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> xzzzzzzzd_(Encounter Visit)
        {
            CqlValueSet xzzzzzzzh_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> xzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? xzzzzzzzj_(Encounter LastED)
            {
                Code<Encounter.EncounterStatus> yzzzzzzzi_ = LastED?.StatusElement;
                Encounter.EncounterStatus? yzzzzzzzj_ = yzzzzzzzi_?.Value;
                Code<Encounter.EncounterStatus> yzzzzzzzk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(yzzzzzzzj_);
                bool? yzzzzzzzl_ = context.Operators.Equal(yzzzzzzzk_, "finished");
                Period yzzzzzzzm_ = LastED?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzm_);
                CqlDateTime yzzzzzzzo_ = context.Operators.End(yzzzzzzzn_);
                CqlValueSet yzzzzzzzp_ = this.Observation_Services(context);
                IEnumerable<Encounter> yzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? yzzzzzzzr_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> azzzzzzzzj_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? azzzzzzzzk_ = azzzzzzzzj_?.Value;
                    Code<Encounter.EncounterStatus> azzzzzzzzl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(azzzzzzzzk_);
                    bool? azzzzzzzzm_ = context.Operators.Equal(azzzzzzzzl_, "finished");
                    Period azzzzzzzzn_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> azzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzn_);
                    CqlDateTime azzzzzzzzp_ = context.Operators.End(azzzzzzzzo_);
                    Period azzzzzzzzq_ = Visit?.Period;
                    CqlInterval<CqlDateTime> azzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzq_);
                    CqlDateTime azzzzzzzzs_ = context.Operators.Start(azzzzzzzzr_);
                    CqlQuantity azzzzzzzzt_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime azzzzzzzzu_ = context.Operators.Subtract(azzzzzzzzs_, azzzzzzzzt_);
                    CqlInterval<CqlDateTime> azzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzq_);
                    CqlDateTime azzzzzzzzx_ = context.Operators.Start(azzzzzzzzw_);
                    CqlInterval<CqlDateTime> azzzzzzzzy_ = context.Operators.Interval(azzzzzzzzu_, azzzzzzzzx_, true, true);
                    bool? azzzzzzzzz_ = context.Operators.In<CqlDateTime>(azzzzzzzzp_, azzzzzzzzy_, default);
                    CqlInterval<CqlDateTime> bzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzq_);
                    CqlDateTime bzzzzzzzzc_ = context.Operators.Start(bzzzzzzzzb_);
                    bool? bzzzzzzzzd_ = context.Operators.Not((bool?)(bzzzzzzzzc_ is null));
                    bool? bzzzzzzzze_ = context.Operators.And(azzzzzzzzz_, bzzzzzzzzd_);
                    bool? bzzzzzzzzf_ = context.Operators.And(azzzzzzzzm_, bzzzzzzzze_);

                    return bzzzzzzzzf_;
                };
                IEnumerable<Encounter> yzzzzzzzs_ = context.Operators.Where<Encounter>(yzzzzzzzq_, yzzzzzzzr_);
                object yzzzzzzzt_(Encounter @this)
                {
                    Period bzzzzzzzzg_ = @this?.Period;
                    CqlInterval<CqlDateTime> bzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzg_);
                    CqlDateTime bzzzzzzzzi_ = context.Operators.End(bzzzzzzzzh_);

                    return bzzzzzzzzi_;
                };
                IEnumerable<Encounter> yzzzzzzzu_ = context.Operators.SortBy<Encounter>(yzzzzzzzs_, yzzzzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter yzzzzzzzv_ = context.Operators.Last<Encounter>(yzzzzzzzu_);
                Period yzzzzzzzw_ = yzzzzzzzv_?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzw_);
                CqlDateTime yzzzzzzzy_ = context.Operators.Start(yzzzzzzzx_);
                Period yzzzzzzzz_ = Visit?.Period;
                CqlInterval<CqlDateTime> zzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzz_);
                CqlDateTime zzzzzzzzb_ = context.Operators.Start(zzzzzzzza_);
                CqlQuantity zzzzzzzzc_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime zzzzzzzzd_ = context.Operators.Subtract(yzzzzzzzy_ ?? zzzzzzzzb_, zzzzzzzzc_);
                IEnumerable<Encounter> zzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? zzzzzzzzg_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> bzzzzzzzzj_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? bzzzzzzzzk_ = bzzzzzzzzj_?.Value;
                    Code<Encounter.EncounterStatus> bzzzzzzzzl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bzzzzzzzzk_);
                    bool? bzzzzzzzzm_ = context.Operators.Equal(bzzzzzzzzl_, "finished");
                    Period bzzzzzzzzn_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> bzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzn_);
                    CqlDateTime bzzzzzzzzp_ = context.Operators.End(bzzzzzzzzo_);
                    Period bzzzzzzzzq_ = Visit?.Period;
                    CqlInterval<CqlDateTime> bzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzq_);
                    CqlDateTime bzzzzzzzzs_ = context.Operators.Start(bzzzzzzzzr_);
                    CqlQuantity bzzzzzzzzt_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime bzzzzzzzzu_ = context.Operators.Subtract(bzzzzzzzzs_, bzzzzzzzzt_);
                    CqlInterval<CqlDateTime> bzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzq_);
                    CqlDateTime bzzzzzzzzx_ = context.Operators.Start(bzzzzzzzzw_);
                    CqlInterval<CqlDateTime> bzzzzzzzzy_ = context.Operators.Interval(bzzzzzzzzu_, bzzzzzzzzx_, true, true);
                    bool? bzzzzzzzzz_ = context.Operators.In<CqlDateTime>(bzzzzzzzzp_, bzzzzzzzzy_, default);
                    CqlInterval<CqlDateTime> czzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzq_);
                    CqlDateTime czzzzzzzzc_ = context.Operators.Start(czzzzzzzzb_);
                    bool? czzzzzzzzd_ = context.Operators.Not((bool?)(czzzzzzzzc_ is null));
                    bool? czzzzzzzze_ = context.Operators.And(bzzzzzzzzz_, czzzzzzzzd_);
                    bool? czzzzzzzzf_ = context.Operators.And(bzzzzzzzzm_, czzzzzzzze_);

                    return czzzzzzzzf_;
                };
                IEnumerable<Encounter> zzzzzzzzh_ = context.Operators.Where<Encounter>(zzzzzzzzf_, zzzzzzzzg_);
                object zzzzzzzzi_(Encounter @this)
                {
                    Period czzzzzzzzg_ = @this?.Period;
                    CqlInterval<CqlDateTime> czzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzg_);
                    CqlDateTime czzzzzzzzi_ = context.Operators.End(czzzzzzzzh_);

                    return czzzzzzzzi_;
                };
                IEnumerable<Encounter> zzzzzzzzj_ = context.Operators.SortBy<Encounter>(zzzzzzzzh_, zzzzzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter zzzzzzzzk_ = context.Operators.Last<Encounter>(zzzzzzzzj_);
                Period zzzzzzzzl_ = zzzzzzzzk_?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzl_);
                CqlDateTime zzzzzzzzn_ = context.Operators.Start(zzzzzzzzm_);
                CqlInterval<CqlDateTime> zzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzz_);
                CqlDateTime zzzzzzzzq_ = context.Operators.Start(zzzzzzzzp_);
                CqlInterval<CqlDateTime> zzzzzzzzr_ = context.Operators.Interval(zzzzzzzzd_, zzzzzzzzn_ ?? zzzzzzzzq_, true, true);
                bool? zzzzzzzzs_ = context.Operators.In<CqlDateTime>(yzzzzzzzo_, zzzzzzzzr_, default);
                IEnumerable<Encounter> zzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? zzzzzzzzv_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> czzzzzzzzj_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? czzzzzzzzk_ = czzzzzzzzj_?.Value;
                    Code<Encounter.EncounterStatus> czzzzzzzzl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(czzzzzzzzk_);
                    bool? czzzzzzzzm_ = context.Operators.Equal(czzzzzzzzl_, "finished");
                    Period czzzzzzzzn_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> czzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzn_);
                    CqlDateTime czzzzzzzzp_ = context.Operators.End(czzzzzzzzo_);
                    Period czzzzzzzzq_ = Visit?.Period;
                    CqlInterval<CqlDateTime> czzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzq_);
                    CqlDateTime czzzzzzzzs_ = context.Operators.Start(czzzzzzzzr_);
                    CqlQuantity czzzzzzzzt_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime czzzzzzzzu_ = context.Operators.Subtract(czzzzzzzzs_, czzzzzzzzt_);
                    CqlInterval<CqlDateTime> czzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzq_);
                    CqlDateTime czzzzzzzzx_ = context.Operators.Start(czzzzzzzzw_);
                    CqlInterval<CqlDateTime> czzzzzzzzy_ = context.Operators.Interval(czzzzzzzzu_, czzzzzzzzx_, true, true);
                    bool? czzzzzzzzz_ = context.Operators.In<CqlDateTime>(czzzzzzzzp_, czzzzzzzzy_, default);
                    CqlInterval<CqlDateTime> dzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzq_);
                    CqlDateTime dzzzzzzzzc_ = context.Operators.Start(dzzzzzzzzb_);
                    bool? dzzzzzzzzd_ = context.Operators.Not((bool?)(dzzzzzzzzc_ is null));
                    bool? dzzzzzzzze_ = context.Operators.And(czzzzzzzzz_, dzzzzzzzzd_);
                    bool? dzzzzzzzzf_ = context.Operators.And(czzzzzzzzm_, dzzzzzzzze_);

                    return dzzzzzzzzf_;
                };
                IEnumerable<Encounter> zzzzzzzzw_ = context.Operators.Where<Encounter>(zzzzzzzzu_, zzzzzzzzv_);
                object zzzzzzzzx_(Encounter @this)
                {
                    Period dzzzzzzzzg_ = @this?.Period;
                    CqlInterval<CqlDateTime> dzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzg_);
                    CqlDateTime dzzzzzzzzi_ = context.Operators.End(dzzzzzzzzh_);

                    return dzzzzzzzzi_;
                };
                IEnumerable<Encounter> zzzzzzzzy_ = context.Operators.SortBy<Encounter>(zzzzzzzzw_, zzzzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter zzzzzzzzz_ = context.Operators.Last<Encounter>(zzzzzzzzy_);
                Period azzzzzzzza_ = zzzzzzzzz_?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzza_);
                CqlDateTime azzzzzzzzc_ = context.Operators.Start(azzzzzzzzb_);
                CqlInterval<CqlDateTime> azzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzz_);
                CqlDateTime azzzzzzzzf_ = context.Operators.Start(azzzzzzzze_);
                bool? azzzzzzzzg_ = context.Operators.Not((bool?)((azzzzzzzzc_ ?? azzzzzzzzf_) is null));
                bool? azzzzzzzzh_ = context.Operators.And(zzzzzzzzs_, azzzzzzzzg_);
                bool? azzzzzzzzi_ = context.Operators.And(yzzzzzzzl_, azzzzzzzzh_);

                return azzzzzzzzi_;
            };
            IEnumerable<Encounter> xzzzzzzzk_ = context.Operators.Where<Encounter>(xzzzzzzzi_, xzzzzzzzj_);
            object xzzzzzzzl_(Encounter @this)
            {
                Period dzzzzzzzzj_ = @this?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzj_);
                CqlDateTime dzzzzzzzzl_ = context.Operators.End(dzzzzzzzzk_);

                return dzzzzzzzzl_;
            };
            IEnumerable<Encounter> xzzzzzzzm_ = context.Operators.SortBy<Encounter>(xzzzzzzzk_, xzzzzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter xzzzzzzzn_ = context.Operators.Last<Encounter>(xzzzzzzzm_);
            Period xzzzzzzzo_ = xzzzzzzzn_?.Period;
            CqlInterval<CqlDateTime> xzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzo_);
            CqlDateTime xzzzzzzzq_ = context.Operators.Start(xzzzzzzzp_);
            CqlValueSet xzzzzzzzr_ = this.Observation_Services(context);
            IEnumerable<Encounter> xzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? xzzzzzzzt_(Encounter LastObs)
            {
                Code<Encounter.EncounterStatus> dzzzzzzzzm_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? dzzzzzzzzn_ = dzzzzzzzzm_?.Value;
                Code<Encounter.EncounterStatus> dzzzzzzzzo_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dzzzzzzzzn_);
                bool? dzzzzzzzzp_ = context.Operators.Equal(dzzzzzzzzo_, "finished");
                Period dzzzzzzzzq_ = LastObs?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzq_);
                CqlDateTime dzzzzzzzzs_ = context.Operators.End(dzzzzzzzzr_);
                Period dzzzzzzzzt_ = Visit?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzt_);
                CqlDateTime dzzzzzzzzv_ = context.Operators.Start(dzzzzzzzzu_);
                CqlQuantity dzzzzzzzzw_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime dzzzzzzzzx_ = context.Operators.Subtract(dzzzzzzzzv_, dzzzzzzzzw_);
                CqlInterval<CqlDateTime> dzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzt_);
                CqlDateTime ezzzzzzzza_ = context.Operators.Start(dzzzzzzzzz_);
                CqlInterval<CqlDateTime> ezzzzzzzzb_ = context.Operators.Interval(dzzzzzzzzx_, ezzzzzzzza_, true, true);
                bool? ezzzzzzzzc_ = context.Operators.In<CqlDateTime>(dzzzzzzzzs_, ezzzzzzzzb_, default);
                CqlInterval<CqlDateTime> ezzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzt_);
                CqlDateTime ezzzzzzzzf_ = context.Operators.Start(ezzzzzzzze_);
                bool? ezzzzzzzzg_ = context.Operators.Not((bool?)(ezzzzzzzzf_ is null));
                bool? ezzzzzzzzh_ = context.Operators.And(ezzzzzzzzc_, ezzzzzzzzg_);
                bool? ezzzzzzzzi_ = context.Operators.And(dzzzzzzzzp_, ezzzzzzzzh_);

                return ezzzzzzzzi_;
            };
            IEnumerable<Encounter> xzzzzzzzu_ = context.Operators.Where<Encounter>(xzzzzzzzs_, xzzzzzzzt_);
            object xzzzzzzzv_(Encounter @this)
            {
                Period ezzzzzzzzj_ = @this?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzj_);
                CqlDateTime ezzzzzzzzl_ = context.Operators.End(ezzzzzzzzk_);

                return ezzzzzzzzl_;
            };
            IEnumerable<Encounter> xzzzzzzzw_ = context.Operators.SortBy<Encounter>(xzzzzzzzu_, xzzzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter xzzzzzzzx_ = context.Operators.Last<Encounter>(xzzzzzzzw_);
            Period xzzzzzzzy_ = xzzzzzzzx_?.Period;
            CqlInterval<CqlDateTime> xzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzy_);
            CqlDateTime yzzzzzzza_ = context.Operators.Start(xzzzzzzzz_);
            Period yzzzzzzzb_ = Visit?.Period;
            CqlInterval<CqlDateTime> yzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzb_);
            CqlDateTime yzzzzzzzd_ = context.Operators.Start(yzzzzzzzc_);
            CqlInterval<CqlDateTime> yzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzb_);
            CqlDateTime yzzzzzzzg_ = context.Operators.End(yzzzzzzzf_);
            CqlInterval<CqlDateTime> yzzzzzzzh_ = context.Operators.Interval(xzzzzzzzq_ ?? yzzzzzzza_ ?? yzzzzzzzd_, yzzzzzzzg_, true, true);

            return yzzzzzzzh_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> xzzzzzzze_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)xzzzzzzzc_, xzzzzzzzd_);
        IEnumerable<CqlInterval<CqlDateTime>> xzzzzzzzf_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(xzzzzzzze_);
        CqlInterval<CqlDateTime> xzzzzzzzg_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(xzzzzzzzf_);

        return xzzzzzzzg_;
    }


    [CqlExpressionDefinition("hospitalizationWithObservation")]
    [CqlTag("description", "Hospitalization with Observation returns the total interval from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    public CqlInterval<CqlDateTime> hospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] ezzzzzzzzm_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> ezzzzzzzzn_(Encounter Visit)
        {
            CqlValueSet ezzzzzzzzr_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> ezzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? ezzzzzzzzt_(Encounter LastED)
            {
                Code<Encounter.EncounterStatus> fzzzzzzzzs_ = LastED?.StatusElement;
                Encounter.EncounterStatus? fzzzzzzzzt_ = fzzzzzzzzs_?.Value;
                Code<Encounter.EncounterStatus> fzzzzzzzzu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fzzzzzzzzt_);
                bool? fzzzzzzzzv_ = context.Operators.Equal(fzzzzzzzzu_, "finished");
                Period fzzzzzzzzw_ = LastED?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzw_);
                CqlDateTime fzzzzzzzzy_ = context.Operators.End(fzzzzzzzzx_);
                CqlValueSet fzzzzzzzzz_ = this.Observation_Services(context);
                IEnumerable<Encounter> gzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? gzzzzzzzzb_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> hzzzzzzzzt_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? hzzzzzzzzu_ = hzzzzzzzzt_?.Value;
                    Code<Encounter.EncounterStatus> hzzzzzzzzv_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hzzzzzzzzu_);
                    bool? hzzzzzzzzw_ = context.Operators.Equal(hzzzzzzzzv_, "finished");
                    Period hzzzzzzzzx_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> hzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzx_);
                    CqlDateTime hzzzzzzzzz_ = context.Operators.End(hzzzzzzzzy_);
                    Period izzzzzzzza_ = Visit?.Period;
                    CqlInterval<CqlDateTime> izzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzza_);
                    CqlDateTime izzzzzzzzc_ = context.Operators.Start(izzzzzzzzb_);
                    CqlQuantity izzzzzzzzd_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime izzzzzzzze_ = context.Operators.Subtract(izzzzzzzzc_, izzzzzzzzd_);
                    CqlInterval<CqlDateTime> izzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzza_);
                    CqlDateTime izzzzzzzzh_ = context.Operators.Start(izzzzzzzzg_);
                    CqlInterval<CqlDateTime> izzzzzzzzi_ = context.Operators.Interval(izzzzzzzze_, izzzzzzzzh_, true, true);
                    bool? izzzzzzzzj_ = context.Operators.In<CqlDateTime>(hzzzzzzzzz_, izzzzzzzzi_, default);
                    CqlInterval<CqlDateTime> izzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzza_);
                    CqlDateTime izzzzzzzzm_ = context.Operators.Start(izzzzzzzzl_);
                    bool? izzzzzzzzn_ = context.Operators.Not((bool?)(izzzzzzzzm_ is null));
                    bool? izzzzzzzzo_ = context.Operators.And(izzzzzzzzj_, izzzzzzzzn_);
                    bool? izzzzzzzzp_ = context.Operators.And(hzzzzzzzzw_, izzzzzzzzo_);

                    return izzzzzzzzp_;
                };
                IEnumerable<Encounter> gzzzzzzzzc_ = context.Operators.Where<Encounter>(gzzzzzzzza_, gzzzzzzzzb_);
                object gzzzzzzzzd_(Encounter @this)
                {
                    Period izzzzzzzzq_ = @this?.Period;
                    CqlInterval<CqlDateTime> izzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzq_);
                    CqlDateTime izzzzzzzzs_ = context.Operators.End(izzzzzzzzr_);

                    return izzzzzzzzs_;
                };
                IEnumerable<Encounter> gzzzzzzzze_ = context.Operators.SortBy<Encounter>(gzzzzzzzzc_, gzzzzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter gzzzzzzzzf_ = context.Operators.Last<Encounter>(gzzzzzzzze_);
                Period gzzzzzzzzg_ = gzzzzzzzzf_?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzg_);
                CqlDateTime gzzzzzzzzi_ = context.Operators.Start(gzzzzzzzzh_);
                Period gzzzzzzzzj_ = Visit?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzj_);
                CqlDateTime gzzzzzzzzl_ = context.Operators.Start(gzzzzzzzzk_);
                CqlQuantity gzzzzzzzzm_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime gzzzzzzzzn_ = context.Operators.Subtract(gzzzzzzzzi_ ?? gzzzzzzzzl_, gzzzzzzzzm_);
                IEnumerable<Encounter> gzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? gzzzzzzzzq_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> izzzzzzzzt_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? izzzzzzzzu_ = izzzzzzzzt_?.Value;
                    Code<Encounter.EncounterStatus> izzzzzzzzv_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(izzzzzzzzu_);
                    bool? izzzzzzzzw_ = context.Operators.Equal(izzzzzzzzv_, "finished");
                    Period izzzzzzzzx_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> izzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzx_);
                    CqlDateTime izzzzzzzzz_ = context.Operators.End(izzzzzzzzy_);
                    Period jzzzzzzzza_ = Visit?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzza_);
                    CqlDateTime jzzzzzzzzc_ = context.Operators.Start(jzzzzzzzzb_);
                    CqlQuantity jzzzzzzzzd_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime jzzzzzzzze_ = context.Operators.Subtract(jzzzzzzzzc_, jzzzzzzzzd_);
                    CqlInterval<CqlDateTime> jzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzza_);
                    CqlDateTime jzzzzzzzzh_ = context.Operators.Start(jzzzzzzzzg_);
                    CqlInterval<CqlDateTime> jzzzzzzzzi_ = context.Operators.Interval(jzzzzzzzze_, jzzzzzzzzh_, true, true);
                    bool? jzzzzzzzzj_ = context.Operators.In<CqlDateTime>(izzzzzzzzz_, jzzzzzzzzi_, default);
                    CqlInterval<CqlDateTime> jzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzza_);
                    CqlDateTime jzzzzzzzzm_ = context.Operators.Start(jzzzzzzzzl_);
                    bool? jzzzzzzzzn_ = context.Operators.Not((bool?)(jzzzzzzzzm_ is null));
                    bool? jzzzzzzzzo_ = context.Operators.And(jzzzzzzzzj_, jzzzzzzzzn_);
                    bool? jzzzzzzzzp_ = context.Operators.And(izzzzzzzzw_, jzzzzzzzzo_);

                    return jzzzzzzzzp_;
                };
                IEnumerable<Encounter> gzzzzzzzzr_ = context.Operators.Where<Encounter>(gzzzzzzzzp_, gzzzzzzzzq_);
                object gzzzzzzzzs_(Encounter @this)
                {
                    Period jzzzzzzzzq_ = @this?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzq_);
                    CqlDateTime jzzzzzzzzs_ = context.Operators.End(jzzzzzzzzr_);

                    return jzzzzzzzzs_;
                };
                IEnumerable<Encounter> gzzzzzzzzt_ = context.Operators.SortBy<Encounter>(gzzzzzzzzr_, gzzzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter gzzzzzzzzu_ = context.Operators.Last<Encounter>(gzzzzzzzzt_);
                Period gzzzzzzzzv_ = gzzzzzzzzu_?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzv_);
                CqlDateTime gzzzzzzzzx_ = context.Operators.Start(gzzzzzzzzw_);
                CqlInterval<CqlDateTime> gzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzj_);
                CqlDateTime hzzzzzzzza_ = context.Operators.Start(gzzzzzzzzz_);
                CqlInterval<CqlDateTime> hzzzzzzzzb_ = context.Operators.Interval(gzzzzzzzzn_, gzzzzzzzzx_ ?? hzzzzzzzza_, true, true);
                bool? hzzzzzzzzc_ = context.Operators.In<CqlDateTime>(fzzzzzzzzy_, hzzzzzzzzb_, default);
                IEnumerable<Encounter> hzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? hzzzzzzzzf_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> jzzzzzzzzt_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? jzzzzzzzzu_ = jzzzzzzzzt_?.Value;
                    Code<Encounter.EncounterStatus> jzzzzzzzzv_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jzzzzzzzzu_);
                    bool? jzzzzzzzzw_ = context.Operators.Equal(jzzzzzzzzv_, "finished");
                    Period jzzzzzzzzx_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> jzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzx_);
                    CqlDateTime jzzzzzzzzz_ = context.Operators.End(jzzzzzzzzy_);
                    Period kzzzzzzzza_ = Visit?.Period;
                    CqlInterval<CqlDateTime> kzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzza_);
                    CqlDateTime kzzzzzzzzc_ = context.Operators.Start(kzzzzzzzzb_);
                    CqlQuantity kzzzzzzzzd_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime kzzzzzzzze_ = context.Operators.Subtract(kzzzzzzzzc_, kzzzzzzzzd_);
                    CqlInterval<CqlDateTime> kzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzza_);
                    CqlDateTime kzzzzzzzzh_ = context.Operators.Start(kzzzzzzzzg_);
                    CqlInterval<CqlDateTime> kzzzzzzzzi_ = context.Operators.Interval(kzzzzzzzze_, kzzzzzzzzh_, true, true);
                    bool? kzzzzzzzzj_ = context.Operators.In<CqlDateTime>(jzzzzzzzzz_, kzzzzzzzzi_, default);
                    CqlInterval<CqlDateTime> kzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzza_);
                    CqlDateTime kzzzzzzzzm_ = context.Operators.Start(kzzzzzzzzl_);
                    bool? kzzzzzzzzn_ = context.Operators.Not((bool?)(kzzzzzzzzm_ is null));
                    bool? kzzzzzzzzo_ = context.Operators.And(kzzzzzzzzj_, kzzzzzzzzn_);
                    bool? kzzzzzzzzp_ = context.Operators.And(jzzzzzzzzw_, kzzzzzzzzo_);

                    return kzzzzzzzzp_;
                };
                IEnumerable<Encounter> hzzzzzzzzg_ = context.Operators.Where<Encounter>(hzzzzzzzze_, hzzzzzzzzf_);
                object hzzzzzzzzh_(Encounter @this)
                {
                    Period kzzzzzzzzq_ = @this?.Period;
                    CqlInterval<CqlDateTime> kzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzq_);
                    CqlDateTime kzzzzzzzzs_ = context.Operators.End(kzzzzzzzzr_);

                    return kzzzzzzzzs_;
                };
                IEnumerable<Encounter> hzzzzzzzzi_ = context.Operators.SortBy<Encounter>(hzzzzzzzzg_, hzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter hzzzzzzzzj_ = context.Operators.Last<Encounter>(hzzzzzzzzi_);
                Period hzzzzzzzzk_ = hzzzzzzzzj_?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzk_);
                CqlDateTime hzzzzzzzzm_ = context.Operators.Start(hzzzzzzzzl_);
                CqlInterval<CqlDateTime> hzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzj_);
                CqlDateTime hzzzzzzzzp_ = context.Operators.Start(hzzzzzzzzo_);
                bool? hzzzzzzzzq_ = context.Operators.Not((bool?)((hzzzzzzzzm_ ?? hzzzzzzzzp_) is null));
                bool? hzzzzzzzzr_ = context.Operators.And(hzzzzzzzzc_, hzzzzzzzzq_);
                bool? hzzzzzzzzs_ = context.Operators.And(fzzzzzzzzv_, hzzzzzzzzr_);

                return hzzzzzzzzs_;
            };
            IEnumerable<Encounter> ezzzzzzzzu_ = context.Operators.Where<Encounter>(ezzzzzzzzs_, ezzzzzzzzt_);
            object ezzzzzzzzv_(Encounter @this)
            {
                Period kzzzzzzzzt_ = @this?.Period;
                CqlInterval<CqlDateTime> kzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzt_);
                CqlDateTime kzzzzzzzzv_ = context.Operators.End(kzzzzzzzzu_);

                return kzzzzzzzzv_;
            };
            IEnumerable<Encounter> ezzzzzzzzw_ = context.Operators.SortBy<Encounter>(ezzzzzzzzu_, ezzzzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter ezzzzzzzzx_ = context.Operators.Last<Encounter>(ezzzzzzzzw_);
            Period ezzzzzzzzy_ = ezzzzzzzzx_?.Period;
            CqlInterval<CqlDateTime> ezzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzy_);
            CqlDateTime fzzzzzzzza_ = context.Operators.Start(ezzzzzzzzz_);
            CqlValueSet fzzzzzzzzb_ = this.Observation_Services(context);
            IEnumerable<Encounter> fzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? fzzzzzzzzd_(Encounter LastObs)
            {
                Code<Encounter.EncounterStatus> kzzzzzzzzw_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? kzzzzzzzzx_ = kzzzzzzzzw_?.Value;
                Code<Encounter.EncounterStatus> kzzzzzzzzy_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(kzzzzzzzzx_);
                bool? kzzzzzzzzz_ = context.Operators.Equal(kzzzzzzzzy_, "finished");
                Period lzzzzzzzza_ = LastObs?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzza_);
                CqlDateTime lzzzzzzzzc_ = context.Operators.End(lzzzzzzzzb_);
                Period lzzzzzzzzd_ = Visit?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzd_);
                CqlDateTime lzzzzzzzzf_ = context.Operators.Start(lzzzzzzzze_);
                CqlQuantity lzzzzzzzzg_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime lzzzzzzzzh_ = context.Operators.Subtract(lzzzzzzzzf_, lzzzzzzzzg_);
                CqlInterval<CqlDateTime> lzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzd_);
                CqlDateTime lzzzzzzzzk_ = context.Operators.Start(lzzzzzzzzj_);
                CqlInterval<CqlDateTime> lzzzzzzzzl_ = context.Operators.Interval(lzzzzzzzzh_, lzzzzzzzzk_, true, true);
                bool? lzzzzzzzzm_ = context.Operators.In<CqlDateTime>(lzzzzzzzzc_, lzzzzzzzzl_, default);
                CqlInterval<CqlDateTime> lzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzd_);
                CqlDateTime lzzzzzzzzp_ = context.Operators.Start(lzzzzzzzzo_);
                bool? lzzzzzzzzq_ = context.Operators.Not((bool?)(lzzzzzzzzp_ is null));
                bool? lzzzzzzzzr_ = context.Operators.And(lzzzzzzzzm_, lzzzzzzzzq_);
                bool? lzzzzzzzzs_ = context.Operators.And(kzzzzzzzzz_, lzzzzzzzzr_);

                return lzzzzzzzzs_;
            };
            IEnumerable<Encounter> fzzzzzzzze_ = context.Operators.Where<Encounter>(fzzzzzzzzc_, fzzzzzzzzd_);
            object fzzzzzzzzf_(Encounter @this)
            {
                Period lzzzzzzzzt_ = @this?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzt_);
                CqlDateTime lzzzzzzzzv_ = context.Operators.End(lzzzzzzzzu_);

                return lzzzzzzzzv_;
            };
            IEnumerable<Encounter> fzzzzzzzzg_ = context.Operators.SortBy<Encounter>(fzzzzzzzze_, fzzzzzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter fzzzzzzzzh_ = context.Operators.Last<Encounter>(fzzzzzzzzg_);
            Period fzzzzzzzzi_ = fzzzzzzzzh_?.Period;
            CqlInterval<CqlDateTime> fzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzi_);
            CqlDateTime fzzzzzzzzk_ = context.Operators.Start(fzzzzzzzzj_);
            Period fzzzzzzzzl_ = Visit?.Period;
            CqlInterval<CqlDateTime> fzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzl_);
            CqlDateTime fzzzzzzzzn_ = context.Operators.Start(fzzzzzzzzm_);
            CqlInterval<CqlDateTime> fzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzl_);
            CqlDateTime fzzzzzzzzq_ = context.Operators.End(fzzzzzzzzp_);
            CqlInterval<CqlDateTime> fzzzzzzzzr_ = context.Operators.Interval(fzzzzzzzza_ ?? fzzzzzzzzk_ ?? fzzzzzzzzn_, fzzzzzzzzq_, true, true);

            return fzzzzzzzzr_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> ezzzzzzzzo_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)ezzzzzzzzm_, ezzzzzzzzn_);
        IEnumerable<CqlInterval<CqlDateTime>> ezzzzzzzzp_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(ezzzzzzzzo_);
        CqlInterval<CqlDateTime> ezzzzzzzzq_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(ezzzzzzzzp_);

        return ezzzzzzzzq_;
    }


    [CqlExpressionDefinition("HospitalizationWithObservationLengthofStay")]
    [CqlTag("description", "Hospitalization with Observation Length of Stay returns the length in days from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationWithObservationLengthofStay()` instead.")]
    public int? HospitalizationWithObservationLengthofStay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> lzzzzzzzzw_ = this.HospitalizationWithObservation(context, TheEncounter);
        int? lzzzzzzzzx_ = this.LengthInDays(context, lzzzzzzzzw_);

        return lzzzzzzzzx_;
    }


    [CqlExpressionDefinition("hospitalizationWithObservationLengthofStay")]
    [CqlTag("description", "Hospitalization with Observation Length of Stay returns the length in days from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    public int? hospitalizationWithObservationLengthofStay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> lzzzzzzzzy_ = this.hospitalizationWithObservation(context, TheEncounter);
        int? lzzzzzzzzz_ = this.lengthInDays(context, lzzzzzzzzy_);

        return lzzzzzzzzz_;
    }


    [CqlExpressionDefinition("FirstInpatientIntensiveCareUnit")]
    [CqlTag("description", "First Inpatient Intensive Care Unit returns the first intensive care unit for the given encounter, without considering any immediately prior emergency department visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `firstInpatientIntensiveCareUnit()` instead.")]
    public Encounter.LocationComponent FirstInpatientIntensiveCareUnit(CqlContext context, Encounter Encounter)
    {
        List<Encounter.LocationComponent> mzzzzzzzza_ = Encounter?.Location;
        bool? mzzzzzzzzb_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference mzzzzzzzzg_ = HospitalLocation?.Location;
            Location mzzzzzzzzh_ = this.GetLocation(context, mzzzzzzzzg_);
            List<CodeableConcept> mzzzzzzzzi_ = mzzzzzzzzh_?.Type;
            CqlConcept mzzzzzzzzj_(CodeableConcept @this)
            {
                CqlConcept mzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return mzzzzzzzzt_;
            };
            IEnumerable<CqlConcept> mzzzzzzzzk_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)mzzzzzzzzi_, mzzzzzzzzj_);
            CqlValueSet mzzzzzzzzl_ = this.Intensive_Care_Unit(context);
            bool? mzzzzzzzzm_ = context.Operators.ConceptsInValueSet(mzzzzzzzzk_, mzzzzzzzzl_);
            Period mzzzzzzzzn_ = Encounter?.Period;
            CqlInterval<CqlDateTime> mzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzn_);
            Period mzzzzzzzzp_ = HospitalLocation?.Period;
            CqlInterval<CqlDateTime> mzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzp_);
            bool? mzzzzzzzzr_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(mzzzzzzzzo_, mzzzzzzzzq_, default);
            bool? mzzzzzzzzs_ = context.Operators.And(mzzzzzzzzm_, mzzzzzzzzr_);

            return mzzzzzzzzs_;
        };
        IEnumerable<Encounter.LocationComponent> mzzzzzzzzc_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)mzzzzzzzza_, mzzzzzzzzb_);
        object mzzzzzzzzd_(Encounter.LocationComponent @this)
        {
            Period mzzzzzzzzu_ = @this?.Period;
            CqlInterval<CqlDateTime> mzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzu_);
            CqlDateTime mzzzzzzzzw_ = context.Operators.Start(mzzzzzzzzv_);

            return mzzzzzzzzw_;
        };
        IEnumerable<Encounter.LocationComponent> mzzzzzzzze_ = context.Operators.SortBy<Encounter.LocationComponent>(mzzzzzzzzc_, mzzzzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent mzzzzzzzzf_ = context.Operators.First<Encounter.LocationComponent>(mzzzzzzzze_);

        return mzzzzzzzzf_;
    }


    [CqlExpressionDefinition("firstInpatientIntensiveCareUnit")]
    [CqlTag("description", "First Inpatient Intensive Care Unit returns the first intensive care unit for the given encounter, without considering any immediately prior emergency department visit.")]
    public Encounter.LocationComponent firstInpatientIntensiveCareUnit(CqlContext context, Encounter Encounter)
    {
        List<Encounter.LocationComponent> mzzzzzzzzx_ = Encounter?.Location;
        bool? mzzzzzzzzy_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference nzzzzzzzzd_ = HospitalLocation?.Location;
            Location nzzzzzzzze_ = this.GetLocation(context, nzzzzzzzzd_);
            List<CodeableConcept> nzzzzzzzzf_ = nzzzzzzzze_?.Type;
            CqlConcept nzzzzzzzzg_(CodeableConcept @this)
            {
                CqlConcept nzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return nzzzzzzzzq_;
            };
            IEnumerable<CqlConcept> nzzzzzzzzh_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)nzzzzzzzzf_, nzzzzzzzzg_);
            CqlValueSet nzzzzzzzzi_ = this.Intensive_Care_Unit(context);
            bool? nzzzzzzzzj_ = context.Operators.ConceptsInValueSet(nzzzzzzzzh_, nzzzzzzzzi_);
            Period nzzzzzzzzk_ = Encounter?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzk_);
            Period nzzzzzzzzm_ = HospitalLocation?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzm_);
            bool? nzzzzzzzzo_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(nzzzzzzzzl_, nzzzzzzzzn_, default);
            bool? nzzzzzzzzp_ = context.Operators.And(nzzzzzzzzj_, nzzzzzzzzo_);

            return nzzzzzzzzp_;
        };
        IEnumerable<Encounter.LocationComponent> mzzzzzzzzz_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)mzzzzzzzzx_, mzzzzzzzzy_);
        object nzzzzzzzza_(Encounter.LocationComponent @this)
        {
            Period nzzzzzzzzr_ = @this?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzr_);
            CqlDateTime nzzzzzzzzt_ = context.Operators.Start(nzzzzzzzzs_);

            return nzzzzzzzzt_;
        };
        IEnumerable<Encounter.LocationComponent> nzzzzzzzzb_ = context.Operators.SortBy<Encounter.LocationComponent>(mzzzzzzzzz_, nzzzzzzzza_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent nzzzzzzzzc_ = context.Operators.First<Encounter.LocationComponent>(nzzzzzzzzb_);

        return nzzzzzzzzc_;
    }


    [CqlExpressionDefinition("EncounterDiagnosis")]
    [CqlTag("description", "Returns the Condition resource referenced by the `diagnosis.condition` element of the Encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `encounterDiagnosis()` instead.")]
    public IEnumerable<Condition> EncounterDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> nzzzzzzzzu_ = Encounter?.Diagnosis;
        Condition nzzzzzzzzv_(Encounter.DiagnosisComponent D)
        {
            IEnumerable<Condition> nzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? nzzzzzzzzz_(Condition C)
            {
                Id ozzzzzzzzc_ = C?.IdElement;
                string ozzzzzzzzd_ = ozzzzzzzzc_?.Value;
                ResourceReference ozzzzzzzze_ = D?.Condition;
                FhirString ozzzzzzzzf_ = ozzzzzzzze_?.ReferenceElement;
                string ozzzzzzzzg_ = ozzzzzzzzf_?.Value;
                string ozzzzzzzzh_ = QICoreCommon_2_1_000.Instance.getId(context, ozzzzzzzzg_);
                bool? ozzzzzzzzi_ = context.Operators.Equal(ozzzzzzzzd_, ozzzzzzzzh_);

                return ozzzzzzzzi_;
            };
            IEnumerable<Condition> ozzzzzzzza_ = context.Operators.Where<Condition>(nzzzzzzzzy_, nzzzzzzzzz_);
            Condition ozzzzzzzzb_ = context.Operators.SingletonFrom<Condition>(ozzzzzzzza_);

            return ozzzzzzzzb_;
        };
        IEnumerable<Condition> nzzzzzzzzw_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)nzzzzzzzzu_, nzzzzzzzzv_);
        IEnumerable<Condition> nzzzzzzzzx_ = context.Operators.Distinct<Condition>(nzzzzzzzzw_);

        return nzzzzzzzzx_;
    }


    [CqlExpressionDefinition("encounterDiagnosis")]
    [CqlTag("description", "Returns the Condition resources referenced by the diagnosis element of the Encounter")]
    public IEnumerable<Condition> encounterDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> ozzzzzzzzj_ = Encounter?.Diagnosis;
        Condition ozzzzzzzzk_(Encounter.DiagnosisComponent D)
        {
            IEnumerable<Condition> ozzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? ozzzzzzzzo_(Condition C)
            {
                Id ozzzzzzzzr_ = C?.IdElement;
                string ozzzzzzzzs_ = ozzzzzzzzr_?.Value;
                ResourceReference ozzzzzzzzt_ = D?.Condition;
                FhirString ozzzzzzzzu_ = ozzzzzzzzt_?.ReferenceElement;
                string ozzzzzzzzv_ = ozzzzzzzzu_?.Value;
                string ozzzzzzzzw_ = QICoreCommon_2_1_000.Instance.getId(context, ozzzzzzzzv_);
                bool? ozzzzzzzzx_ = context.Operators.Equal(ozzzzzzzzs_, ozzzzzzzzw_);

                return ozzzzzzzzx_;
            };
            IEnumerable<Condition> ozzzzzzzzp_ = context.Operators.Where<Condition>(ozzzzzzzzn_, ozzzzzzzzo_);
            Condition ozzzzzzzzq_ = context.Operators.SingletonFrom<Condition>(ozzzzzzzzp_);

            return ozzzzzzzzq_;
        };
        IEnumerable<Condition> ozzzzzzzzl_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)ozzzzzzzzj_, ozzzzzzzzk_);
        IEnumerable<Condition> ozzzzzzzzm_ = context.Operators.Distinct<Condition>(ozzzzzzzzl_);

        return ozzzzzzzzm_;
    }


    [CqlExpressionDefinition("GetCondition")]
    [CqlTag("description", "Returns the Condition resource for the given reference")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getCondition()` instead")]
    public Condition GetCondition(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Condition> ozzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? ozzzzzzzzz_(Condition C)
        {
            Id pzzzzzzzzc_ = C?.IdElement;
            string pzzzzzzzzd_ = pzzzzzzzzc_?.Value;
            FhirString pzzzzzzzze_ = reference?.ReferenceElement;
            string pzzzzzzzzf_ = pzzzzzzzze_?.Value;
            string pzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.getId(context, pzzzzzzzzf_);
            bool? pzzzzzzzzh_ = context.Operators.Equal(pzzzzzzzzd_, pzzzzzzzzg_);

            return pzzzzzzzzh_;
        };
        IEnumerable<Condition> pzzzzzzzza_ = context.Operators.Where<Condition>(ozzzzzzzzy_, ozzzzzzzzz_);
        Condition pzzzzzzzzb_ = context.Operators.SingletonFrom<Condition>(pzzzzzzzza_);

        return pzzzzzzzzb_;
    }


    [CqlExpressionDefinition("getCondition")]
    [CqlTag("description", "Returns the Condition resource for the given reference")]
    public Condition getCondition(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Condition> pzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? pzzzzzzzzj_(Condition C)
        {
            Id pzzzzzzzzm_ = C?.IdElement;
            string pzzzzzzzzn_ = pzzzzzzzzm_?.Value;
            FhirString pzzzzzzzzo_ = reference?.ReferenceElement;
            string pzzzzzzzzp_ = pzzzzzzzzo_?.Value;
            string pzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.getId(context, pzzzzzzzzp_);
            bool? pzzzzzzzzr_ = context.Operators.Equal(pzzzzzzzzn_, pzzzzzzzzq_);

            return pzzzzzzzzr_;
        };
        IEnumerable<Condition> pzzzzzzzzk_ = context.Operators.Where<Condition>(pzzzzzzzzi_, pzzzzzzzzj_);
        Condition pzzzzzzzzl_ = context.Operators.SingletonFrom<Condition>(pzzzzzzzzk_);

        return pzzzzzzzzl_;
    }


    [CqlExpressionDefinition("PrincipalDiagnosis")]
    [CqlTag("description", "Returns the condition that is specified as the principal diagnosis for the encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `principalDiagnosis()` instead.")]
    public Condition PrincipalDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> pzzzzzzzzs_ = Encounter?.Diagnosis;
        bool? pzzzzzzzzt_(Encounter.DiagnosisComponent D)
        {
            PositiveInt pzzzzzzzzz_ = D?.RankElement;
            int? qzzzzzzzza_ = pzzzzzzzzz_?.Value;
            bool? qzzzzzzzzb_ = context.Operators.Equal(qzzzzzzzza_, 1);
            CodeableConcept qzzzzzzzzc_ = D?.Use;
            CqlConcept qzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, qzzzzzzzzc_);
            CqlCode qzzzzzzzze_ = this.Billing(context);
            CqlConcept qzzzzzzzzf_ = context.Operators.ConvertCodeToConcept(qzzzzzzzze_);
            bool? qzzzzzzzzg_ = context.Operators.Equivalent(qzzzzzzzzd_, qzzzzzzzzf_);
            bool? qzzzzzzzzh_ = context.Operators.And(qzzzzzzzzb_, qzzzzzzzzg_);

            return qzzzzzzzzh_;
        };
        IEnumerable<Encounter.DiagnosisComponent> pzzzzzzzzu_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)pzzzzzzzzs_, pzzzzzzzzt_);
        Condition pzzzzzzzzv_(Encounter.DiagnosisComponent PD)
        {
            IEnumerable<Condition> qzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? qzzzzzzzzj_(Condition C)
            {
                Id qzzzzzzzzm_ = C?.IdElement;
                string qzzzzzzzzn_ = qzzzzzzzzm_?.Value;
                ResourceReference qzzzzzzzzo_ = PD?.Condition;
                FhirString qzzzzzzzzp_ = qzzzzzzzzo_?.ReferenceElement;
                string qzzzzzzzzq_ = qzzzzzzzzp_?.Value;
                string qzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.getId(context, qzzzzzzzzq_);
                bool? qzzzzzzzzs_ = context.Operators.Equal(qzzzzzzzzn_, qzzzzzzzzr_);

                return qzzzzzzzzs_;
            };
            IEnumerable<Condition> qzzzzzzzzk_ = context.Operators.Where<Condition>(qzzzzzzzzi_, qzzzzzzzzj_);
            Condition qzzzzzzzzl_ = context.Operators.SingletonFrom<Condition>(qzzzzzzzzk_);

            return qzzzzzzzzl_;
        };
        IEnumerable<Condition> pzzzzzzzzw_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>(pzzzzzzzzu_, pzzzzzzzzv_);
        IEnumerable<Condition> pzzzzzzzzx_ = context.Operators.Distinct<Condition>(pzzzzzzzzw_);
        Condition pzzzzzzzzy_ = context.Operators.SingletonFrom<Condition>(pzzzzzzzzx_);

        return pzzzzzzzzy_;
    }


    [CqlExpressionDefinition("principalDiagnosis")]
    [CqlTag("description", "Returns the condition that is specified as the principal diagnosis for the encounter")]
    public Condition principalDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> qzzzzzzzzt_ = Encounter?.Diagnosis;
        bool? qzzzzzzzzu_(Encounter.DiagnosisComponent D)
        {
            PositiveInt rzzzzzzzza_ = D?.RankElement;
            int? rzzzzzzzzb_ = rzzzzzzzza_?.Value;
            bool? rzzzzzzzzc_ = context.Operators.Equal(rzzzzzzzzb_, 1);
            CodeableConcept rzzzzzzzzd_ = D?.Use;
            CqlConcept rzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, rzzzzzzzzd_);
            CqlCode rzzzzzzzzf_ = this.Billing(context);
            CqlConcept rzzzzzzzzg_ = context.Operators.ConvertCodeToConcept(rzzzzzzzzf_);
            bool? rzzzzzzzzh_ = context.Operators.Equivalent(rzzzzzzzze_, rzzzzzzzzg_);
            bool? rzzzzzzzzi_ = context.Operators.And(rzzzzzzzzc_, rzzzzzzzzh_);

            return rzzzzzzzzi_;
        };
        IEnumerable<Encounter.DiagnosisComponent> qzzzzzzzzv_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)qzzzzzzzzt_, qzzzzzzzzu_);
        Condition qzzzzzzzzw_(Encounter.DiagnosisComponent PD)
        {
            IEnumerable<Condition> rzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? rzzzzzzzzk_(Condition C)
            {
                Id rzzzzzzzzn_ = C?.IdElement;
                string rzzzzzzzzo_ = rzzzzzzzzn_?.Value;
                ResourceReference rzzzzzzzzp_ = PD?.Condition;
                FhirString rzzzzzzzzq_ = rzzzzzzzzp_?.ReferenceElement;
                string rzzzzzzzzr_ = rzzzzzzzzq_?.Value;
                string rzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.getId(context, rzzzzzzzzr_);
                bool? rzzzzzzzzt_ = context.Operators.Equal(rzzzzzzzzo_, rzzzzzzzzs_);

                return rzzzzzzzzt_;
            };
            IEnumerable<Condition> rzzzzzzzzl_ = context.Operators.Where<Condition>(rzzzzzzzzj_, rzzzzzzzzk_);
            Condition rzzzzzzzzm_ = context.Operators.SingletonFrom<Condition>(rzzzzzzzzl_);

            return rzzzzzzzzm_;
        };
        IEnumerable<Condition> qzzzzzzzzx_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>(qzzzzzzzzv_, qzzzzzzzzw_);
        IEnumerable<Condition> qzzzzzzzzy_ = context.Operators.Distinct<Condition>(qzzzzzzzzx_);
        Condition qzzzzzzzzz_ = context.Operators.SingletonFrom<Condition>(qzzzzzzzzy_);

        return qzzzzzzzzz_;
    }


    [CqlExpressionDefinition("getLocation")]
    [CqlTag("description", "Returns the Location resource specified by the given reference.")]
    public Location getLocation(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Location> rzzzzzzzzu_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-location"));
        bool? rzzzzzzzzv_(Location L)
        {
            Id rzzzzzzzzy_ = L?.IdElement;
            string rzzzzzzzzz_ = rzzzzzzzzy_?.Value;
            FhirString szzzzzzzza_ = reference?.ReferenceElement;
            string szzzzzzzzb_ = szzzzzzzza_?.Value;
            string szzzzzzzzc_ = QICoreCommon_2_1_000.Instance.getId(context, szzzzzzzzb_);
            bool? szzzzzzzzd_ = context.Operators.Equal(rzzzzzzzzz_, szzzzzzzzc_);

            return szzzzzzzzd_;
        };
        IEnumerable<Location> rzzzzzzzzw_ = context.Operators.Where<Location>(rzzzzzzzzu_, rzzzzzzzzv_);
        Location rzzzzzzzzx_ = context.Operators.SingletonFrom<Location>(rzzzzzzzzw_);

        return rzzzzzzzzx_;
    }


    [CqlExpressionDefinition("GetMedicationCode")]
    [CqlTag("description", "Returns the medication code for the given MedicationRequest")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getMedicationCode()` instead.")]
    public CqlConcept GetMedicationCode(CqlContext context, MedicationRequest request)
    {
        CqlConcept szzzzzzzze_()
        {
            bool szzzzzzzzf_()
            {
                DataType szzzzzzzzg_ = request?.Medication;
                object szzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzg_);
                bool szzzzzzzzi_ = szzzzzzzzh_ is CqlConcept;

                return szzzzzzzzi_;
            };
            if (szzzzzzzzf_())
            {
                DataType szzzzzzzzj_ = request?.Medication;
                object szzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzj_);

                return szzzzzzzzk_ as CqlConcept;
            }
            else
            {
                IEnumerable<Medication> szzzzzzzzl_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? szzzzzzzzm_(Medication M)
                {
                    Id szzzzzzzzr_ = M?.IdElement;
                    string szzzzzzzzs_ = szzzzzzzzr_?.Value;
                    DataType szzzzzzzzt_ = request?.Medication;
                    object szzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzt_);
                    FhirString szzzzzzzzv_ = (szzzzzzzzu_ as ResourceReference)?.ReferenceElement;
                    string szzzzzzzzw_ = szzzzzzzzv_?.Value;
                    string szzzzzzzzx_ = QICoreCommon_2_1_000.Instance.getId(context, szzzzzzzzw_);
                    bool? szzzzzzzzy_ = context.Operators.Equal(szzzzzzzzs_, szzzzzzzzx_);

                    return szzzzzzzzy_;
                };
                IEnumerable<Medication> szzzzzzzzn_ = context.Operators.Where<Medication>(szzzzzzzzl_, szzzzzzzzm_);
                Medication szzzzzzzzo_ = context.Operators.SingletonFrom<Medication>(szzzzzzzzn_);
                CodeableConcept szzzzzzzzp_ = szzzzzzzzo_?.Code;
                CqlConcept szzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, szzzzzzzzp_);

                return szzzzzzzzq_;
            }
        };

        return szzzzzzzze_();
    }


    [CqlExpressionDefinition("getMedicationCode")]
    [CqlTag("description", "Returns the medication code for the given MedicationRequest")]
    public CqlConcept getMedicationCode(CqlContext context, MedicationRequest request)
    {
        CqlConcept szzzzzzzzz_()
        {
            bool tzzzzzzzza_()
            {
                DataType tzzzzzzzzb_ = request?.Medication;
                object tzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzb_);
                bool tzzzzzzzzd_ = tzzzzzzzzc_ is CqlConcept;

                return tzzzzzzzzd_;
            };
            if (tzzzzzzzza_())
            {
                DataType tzzzzzzzze_ = request?.Medication;
                object tzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzze_);

                return tzzzzzzzzf_ as CqlConcept;
            }
            else
            {
                IEnumerable<Medication> tzzzzzzzzg_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? tzzzzzzzzh_(Medication M)
                {
                    Id tzzzzzzzzm_ = M?.IdElement;
                    string tzzzzzzzzn_ = tzzzzzzzzm_?.Value;
                    DataType tzzzzzzzzo_ = request?.Medication;
                    object tzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzo_);
                    FhirString tzzzzzzzzq_ = (tzzzzzzzzp_ as ResourceReference)?.ReferenceElement;
                    string tzzzzzzzzr_ = tzzzzzzzzq_?.Value;
                    string tzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.getId(context, tzzzzzzzzr_);
                    bool? tzzzzzzzzt_ = context.Operators.Equal(tzzzzzzzzn_, tzzzzzzzzs_);

                    return tzzzzzzzzt_;
                };
                IEnumerable<Medication> tzzzzzzzzi_ = context.Operators.Where<Medication>(tzzzzzzzzg_, tzzzzzzzzh_);
                Medication tzzzzzzzzj_ = context.Operators.SingletonFrom<Medication>(tzzzzzzzzi_);
                CodeableConcept tzzzzzzzzk_ = tzzzzzzzzj_?.Code;
                CqlConcept tzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, tzzzzzzzzk_);

                return tzzzzzzzzl_;
            }
        };

        return szzzzzzzzz_();
    }


    #endregion Expressions

}
