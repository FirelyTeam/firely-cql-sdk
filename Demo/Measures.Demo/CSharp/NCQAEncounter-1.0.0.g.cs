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
[CqlLibrary("NCQAEncounter", "1.0.0")]
public partial class NCQAEncounter_1_0_0 : ILibrary, ISingleton<NCQAEncounter_1_0_0>
{
    private NCQAEncounter_1_0_0() {}

    public static NCQAEncounter_1_0_0 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "NCQAEncounter";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, NCQAFHIRBase_1_0_0.Instance, NCQAStatus_1_0_0.Instance, NCQATerminology_1_0_0.Instance];

    #endregion ILibrary Implementation

    #region Expressions

    [CqlExpressionDefinition("Encounter Has Diagnosis")]
    public bool? Encounter_Has_Diagnosis(CqlContext context, Encounter Encounter, IEnumerable<Condition> Conditions)
    {
        List<Encounter.DiagnosisComponent> gzzzzzzzzzzc_ = Encounter?.Diagnosis;
        FhirString gzzzzzzzzzzd_(Encounter.DiagnosisComponent D)
        {
            ResourceReference gzzzzzzzzzzk_ = D?.Condition;
            FhirString gzzzzzzzzzzl_ = gzzzzzzzzzzk_?.ReferenceElement;

            return gzzzzzzzzzzl_;
        };
        IEnumerable<FhirString> gzzzzzzzzzze_ = context.Operators.Select<Encounter.DiagnosisComponent, FhirString>((IEnumerable<Encounter.DiagnosisComponent>)gzzzzzzzzzzc_, gzzzzzzzzzzd_);
        IEnumerable<FhirString> gzzzzzzzzzzf_ = context.Operators.Distinct<FhirString>(gzzzzzzzzzze_);
        bool? gzzzzzzzzzzg_(FhirString CRef)
        {
            bool? gzzzzzzzzzzm_(Condition C)
            {
                Id gzzzzzzzzzzp_ = C?.IdElement;
                string gzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzzzzzzzzzp_);
                string gzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToString(context, CRef);
                string gzzzzzzzzzzs_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, gzzzzzzzzzzr_);
                bool? gzzzzzzzzzzt_ = context.Operators.Equal(gzzzzzzzzzzq_, gzzzzzzzzzzs_);

                return gzzzzzzzzzzt_;
            };
            IEnumerable<Condition> gzzzzzzzzzzn_ = context.Operators.Where<Condition>(Conditions, gzzzzzzzzzzm_);
            bool? gzzzzzzzzzzo_ = context.Operators.Exists<Condition>(gzzzzzzzzzzn_);

            return gzzzzzzzzzzo_;
        };
        IEnumerable<bool?> gzzzzzzzzzzh_ = context.Operators.Select<FhirString, bool?>(gzzzzzzzzzzf_, gzzzzzzzzzzg_);
        IEnumerable<bool?> gzzzzzzzzzzi_ = context.Operators.Distinct<bool?>(gzzzzzzzzzzh_);
        bool? gzzzzzzzzzzj_ = context.Operators.AnyTrue(gzzzzzzzzzzi_);

        return gzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Encounter Has Principal Diagnosis")]
    public bool? Encounter_Has_Principal_Diagnosis(CqlContext context, Encounter Encounter, IEnumerable<Condition> Conditions)
    {
        List<Encounter.DiagnosisComponent> gzzzzzzzzzzu_ = Encounter?.Diagnosis;
        bool? gzzzzzzzzzzv_(Encounter.DiagnosisComponent D)
        {
            PositiveInt hzzzzzzzzzzd_ = D?.RankElement;
            Integer hzzzzzzzzzze_ = context.Operators.Convert<Integer>(hzzzzzzzzzzd_);
            int? hzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, hzzzzzzzzzze_);
            bool? hzzzzzzzzzzg_ = context.Operators.Equal(hzzzzzzzzzzf_, 1);

            return hzzzzzzzzzzg_;
        };
        IEnumerable<Encounter.DiagnosisComponent> gzzzzzzzzzzw_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)gzzzzzzzzzzu_, gzzzzzzzzzzv_);
        Encounter.DiagnosisComponent gzzzzzzzzzzx_ = context.Operators.SingletonFrom<Encounter.DiagnosisComponent>(gzzzzzzzzzzw_);
        Encounter.DiagnosisComponent[] gzzzzzzzzzzy_ = [
            gzzzzzzzzzzx_,
        ];
        bool? gzzzzzzzzzzz_(Encounter.DiagnosisComponent PrincipalDiagnosis)
        {
            bool? hzzzzzzzzzzh_(Condition C)
            {
                Id hzzzzzzzzzzk_ = C?.IdElement;
                string hzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToString(context, hzzzzzzzzzzk_);
                ResourceReference hzzzzzzzzzzm_ = PrincipalDiagnosis?.Condition;
                FhirString hzzzzzzzzzzn_ = hzzzzzzzzzzm_?.ReferenceElement;
                string hzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, hzzzzzzzzzzn_);
                string hzzzzzzzzzzp_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, hzzzzzzzzzzo_);
                bool? hzzzzzzzzzzq_ = context.Operators.Equal(hzzzzzzzzzzl_, hzzzzzzzzzzp_);

                return hzzzzzzzzzzq_;
            };
            IEnumerable<Condition> hzzzzzzzzzzi_ = context.Operators.Where<Condition>(Conditions, hzzzzzzzzzzh_);
            bool? hzzzzzzzzzzj_ = context.Operators.Exists<Condition>(hzzzzzzzzzzi_);

            return hzzzzzzzzzzj_;
        };
        IEnumerable<bool?> hzzzzzzzzzza_ = context.Operators.Select<Encounter.DiagnosisComponent, bool?>((IEnumerable<Encounter.DiagnosisComponent>)gzzzzzzzzzzy_, gzzzzzzzzzzz_);
        IEnumerable<bool?> hzzzzzzzzzzb_ = context.Operators.Distinct<bool?>(hzzzzzzzzzza_);
        bool? hzzzzzzzzzzc_ = context.Operators.SingletonFrom<bool?>(hzzzzzzzzzzb_);

        return hzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Encounter Completed during Period")]
    public bool? Encounter_Completed_during_Period(CqlContext context, IEnumerable<Encounter> Enc, CqlInterval<CqlDateTime> timeperiod)
    {
        IEnumerable<Encounter> hzzzzzzzzzzr_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, Enc);
        bool? hzzzzzzzzzzs_(Encounter EncounterPeriod)
        {
            Period hzzzzzzzzzzv_ = EncounterPeriod?.Period;
            CqlInterval<CqlDateTime> hzzzzzzzzzzw_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, hzzzzzzzzzzv_ as object);
            CqlDateTime hzzzzzzzzzzx_ = context.Operators.End(hzzzzzzzzzzw_);
            bool? hzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzx_, timeperiod, default);

            return hzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzt_ = context.Operators.Where<Encounter>(hzzzzzzzzzzr_, hzzzzzzzzzzs_);
        bool? hzzzzzzzzzzu_ = context.Operators.Exists<Encounter>(hzzzzzzzzzzt_);

        return hzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Finished Encounter with Telehealth POS")]
    public IEnumerable<Encounter> Finished_Encounter_with_Telehealth_POS(CqlContext context, IEnumerable<Encounter> Encounter)
    {
        IEnumerable<Encounter> hzzzzzzzzzzz_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, Encounter);
        bool? izzzzzzzzzza_(Encounter E)
        {
            Coding izzzzzzzzzzc_ = E?.Class;
            bool? izzzzzzzzzzd_ = context.Operators.Not((bool?)(izzzzzzzzzzc_ is null));
            CqlCode izzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToCode(context, izzzzzzzzzzc_);
            CqlCode izzzzzzzzzzg_ = NCQATerminology_1_0_0.Instance.@virtual(context);
            bool? izzzzzzzzzzh_ = context.Operators.Equivalent(izzzzzzzzzzf_, izzzzzzzzzzg_);
            bool? izzzzzzzzzzi_ = context.Operators.And(izzzzzzzzzzd_, izzzzzzzzzzh_);

            return izzzzzzzzzzi_;
        };
        IEnumerable<Encounter> izzzzzzzzzzb_ = context.Operators.Where<Encounter>(hzzzzzzzzzzz_, izzzzzzzzzza_);

        return izzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Finished Encounter with Outpatient POS")]
    public IEnumerable<Encounter> Finished_Encounter_with_Outpatient_POS(CqlContext context, IEnumerable<Encounter> Encounter)
    {
        IEnumerable<Encounter> izzzzzzzzzzj_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, Encounter);
        bool? izzzzzzzzzzk_(Encounter E)
        {
            Coding izzzzzzzzzzm_ = E?.Class;
            bool? izzzzzzzzzzn_ = context.Operators.Not((bool?)(izzzzzzzzzzm_ is null));
            CqlCode izzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToCode(context, izzzzzzzzzzm_);
            CqlCode izzzzzzzzzzq_ = NCQATerminology_1_0_0.Instance.ambulatory(context);
            bool? izzzzzzzzzzr_ = context.Operators.Equivalent(izzzzzzzzzzp_, izzzzzzzzzzq_);
            CqlCode izzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToCode(context, izzzzzzzzzzm_);
            CqlCode izzzzzzzzzzu_ = NCQATerminology_1_0_0.Instance.home_health(context);
            bool? izzzzzzzzzzv_ = context.Operators.Equivalent(izzzzzzzzzzt_, izzzzzzzzzzu_);
            bool? izzzzzzzzzzw_ = context.Operators.Or(izzzzzzzzzzr_, izzzzzzzzzzv_);
            bool? izzzzzzzzzzx_ = context.Operators.And(izzzzzzzzzzn_, izzzzzzzzzzw_);

            return izzzzzzzzzzx_;
        };
        IEnumerable<Encounter> izzzzzzzzzzl_ = context.Operators.Where<Encounter>(izzzzzzzzzzj_, izzzzzzzzzzk_);

        return izzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Finished Encounter with Ambulatory POS")]
    public IEnumerable<Encounter> Finished_Encounter_with_Ambulatory_POS(CqlContext context, IEnumerable<Encounter> Encounter)
    {
        IEnumerable<Encounter> izzzzzzzzzzy_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, Encounter);
        bool? izzzzzzzzzzz_(Encounter E)
        {
            Coding jzzzzzzzzzzb_ = E?.Class;
            bool? jzzzzzzzzzzc_ = context.Operators.Not((bool?)(jzzzzzzzzzzb_ is null));
            CqlCode jzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToCode(context, jzzzzzzzzzzb_);
            CqlCode jzzzzzzzzzzf_ = NCQATerminology_1_0_0.Instance.ambulatory(context);
            bool? jzzzzzzzzzzg_ = context.Operators.Equivalent(jzzzzzzzzzze_, jzzzzzzzzzzf_);
            bool? jzzzzzzzzzzh_ = context.Operators.And(jzzzzzzzzzzc_, jzzzzzzzzzzg_);

            return jzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> jzzzzzzzzzza_ = context.Operators.Where<Encounter>(izzzzzzzzzzy_, izzzzzzzzzzz_);

        return jzzzzzzzzzza_;
    }


    #endregion Expressions

}
