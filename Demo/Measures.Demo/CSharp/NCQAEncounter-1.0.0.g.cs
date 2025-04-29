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
        List<Encounter.DiagnosisComponent> szzzzzzzzzu_ = Encounter?.Diagnosis;
        FhirString szzzzzzzzzv_(Encounter.DiagnosisComponent D)
        {
            ResourceReference tzzzzzzzzzc_ = D?.Condition;
            FhirString tzzzzzzzzzd_ = tzzzzzzzzzc_?.ReferenceElement;

            return tzzzzzzzzzd_;
        };
        IEnumerable<FhirString> szzzzzzzzzw_ = context.Operators.Select<Encounter.DiagnosisComponent, FhirString>((IEnumerable<Encounter.DiagnosisComponent>)szzzzzzzzzu_, szzzzzzzzzv_);
        IEnumerable<FhirString> szzzzzzzzzx_ = context.Operators.Distinct<FhirString>(szzzzzzzzzw_);
        bool? szzzzzzzzzy_(FhirString CRef)
        {
            bool? tzzzzzzzzze_(Condition C)
            {
                Id tzzzzzzzzzh_ = C?.IdElement;
                string tzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToString(context, tzzzzzzzzzh_);
                string tzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, CRef);
                string tzzzzzzzzzk_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, tzzzzzzzzzj_);
                bool? tzzzzzzzzzl_ = context.Operators.Equal(tzzzzzzzzzi_, tzzzzzzzzzk_);

                return tzzzzzzzzzl_;
            };
            IEnumerable<Condition> tzzzzzzzzzf_ = context.Operators.Where<Condition>(Conditions, tzzzzzzzzze_);
            bool? tzzzzzzzzzg_ = context.Operators.Exists<Condition>(tzzzzzzzzzf_);

            return tzzzzzzzzzg_;
        };
        IEnumerable<bool?> szzzzzzzzzz_ = context.Operators.Select<FhirString, bool?>(szzzzzzzzzx_, szzzzzzzzzy_);
        IEnumerable<bool?> tzzzzzzzzza_ = context.Operators.Distinct<bool?>(szzzzzzzzzz_);
        bool? tzzzzzzzzzb_ = context.Operators.AnyTrue(tzzzzzzzzza_);

        return tzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Encounter Has Principal Diagnosis")]
    public bool? Encounter_Has_Principal_Diagnosis(CqlContext context, Encounter Encounter, IEnumerable<Condition> Conditions)
    {
        List<Encounter.DiagnosisComponent> tzzzzzzzzzm_ = Encounter?.Diagnosis;
        bool? tzzzzzzzzzn_(Encounter.DiagnosisComponent D)
        {
            PositiveInt tzzzzzzzzzv_ = D?.RankElement;
            Integer tzzzzzzzzzw_ = context.Operators.Convert<Integer>(tzzzzzzzzzv_);
            int? tzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, tzzzzzzzzzw_);
            bool? tzzzzzzzzzy_ = context.Operators.Equal(tzzzzzzzzzx_, 1);

            return tzzzzzzzzzy_;
        };
        IEnumerable<Encounter.DiagnosisComponent> tzzzzzzzzzo_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)tzzzzzzzzzm_, tzzzzzzzzzn_);
        Encounter.DiagnosisComponent tzzzzzzzzzp_ = context.Operators.SingletonFrom<Encounter.DiagnosisComponent>(tzzzzzzzzzo_);
        Encounter.DiagnosisComponent[] tzzzzzzzzzq_ = [
            tzzzzzzzzzp_,
        ];
        bool? tzzzzzzzzzr_(Encounter.DiagnosisComponent PrincipalDiagnosis)
        {
            bool? tzzzzzzzzzz_(Condition C)
            {
                Id uzzzzzzzzzc_ = C?.IdElement;
                string uzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzzzzzzzc_);
                ResourceReference uzzzzzzzzze_ = PrincipalDiagnosis?.Condition;
                FhirString uzzzzzzzzzf_ = uzzzzzzzzze_?.ReferenceElement;
                string uzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzzzzzzzf_);
                string uzzzzzzzzzh_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, uzzzzzzzzzg_);
                bool? uzzzzzzzzzi_ = context.Operators.Equal(uzzzzzzzzzd_, uzzzzzzzzzh_);

                return uzzzzzzzzzi_;
            };
            IEnumerable<Condition> uzzzzzzzzza_ = context.Operators.Where<Condition>(Conditions, tzzzzzzzzzz_);
            bool? uzzzzzzzzzb_ = context.Operators.Exists<Condition>(uzzzzzzzzza_);

            return uzzzzzzzzzb_;
        };
        IEnumerable<bool?> tzzzzzzzzzs_ = context.Operators.Select<Encounter.DiagnosisComponent, bool?>((IEnumerable<Encounter.DiagnosisComponent>)tzzzzzzzzzq_, tzzzzzzzzzr_);
        IEnumerable<bool?> tzzzzzzzzzt_ = context.Operators.Distinct<bool?>(tzzzzzzzzzs_);
        bool? tzzzzzzzzzu_ = context.Operators.SingletonFrom<bool?>(tzzzzzzzzzt_);

        return tzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Encounter Completed during Period")]
    public bool? Encounter_Completed_during_Period(CqlContext context, IEnumerable<Encounter> Enc, CqlInterval<CqlDateTime> timeperiod)
    {
        IEnumerable<Encounter> uzzzzzzzzzj_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, Enc);
        bool? uzzzzzzzzzk_(Encounter EncounterPeriod)
        {
            Period uzzzzzzzzzn_ = EncounterPeriod?.Period;
            CqlInterval<CqlDateTime> uzzzzzzzzzo_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, uzzzzzzzzzn_ as object);
            CqlDateTime uzzzzzzzzzp_ = context.Operators.End(uzzzzzzzzzo_);
            bool? uzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzp_, timeperiod, default);

            return uzzzzzzzzzq_;
        };
        IEnumerable<Encounter> uzzzzzzzzzl_ = context.Operators.Where<Encounter>(uzzzzzzzzzj_, uzzzzzzzzzk_);
        bool? uzzzzzzzzzm_ = context.Operators.Exists<Encounter>(uzzzzzzzzzl_);

        return uzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Finished Encounter with Telehealth POS")]
    public IEnumerable<Encounter> Finished_Encounter_with_Telehealth_POS(CqlContext context, IEnumerable<Encounter> Encounter)
    {
        IEnumerable<Encounter> uzzzzzzzzzr_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, Encounter);
        bool? uzzzzzzzzzs_(Encounter E)
        {
            Coding uzzzzzzzzzu_ = E?.Class;
            bool? uzzzzzzzzzv_ = context.Operators.Not((bool?)(uzzzzzzzzzu_ is null));
            CqlCode uzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToCode(context, uzzzzzzzzzu_);
            CqlCode uzzzzzzzzzy_ = NCQATerminology_1_0_0.Instance.@virtual(context);
            bool? uzzzzzzzzzz_ = context.Operators.Equivalent(uzzzzzzzzzx_, uzzzzzzzzzy_);
            bool? vzzzzzzzzza_ = context.Operators.And(uzzzzzzzzzv_, uzzzzzzzzzz_);

            return vzzzzzzzzza_;
        };
        IEnumerable<Encounter> uzzzzzzzzzt_ = context.Operators.Where<Encounter>(uzzzzzzzzzr_, uzzzzzzzzzs_);

        return uzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Finished Encounter with Outpatient POS")]
    public IEnumerable<Encounter> Finished_Encounter_with_Outpatient_POS(CqlContext context, IEnumerable<Encounter> Encounter)
    {
        IEnumerable<Encounter> vzzzzzzzzzb_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, Encounter);
        bool? vzzzzzzzzzc_(Encounter E)
        {
            Coding vzzzzzzzzze_ = E?.Class;
            bool? vzzzzzzzzzf_ = context.Operators.Not((bool?)(vzzzzzzzzze_ is null));
            CqlCode vzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToCode(context, vzzzzzzzzze_);
            CqlCode vzzzzzzzzzi_ = NCQATerminology_1_0_0.Instance.ambulatory(context);
            bool? vzzzzzzzzzj_ = context.Operators.Equivalent(vzzzzzzzzzh_, vzzzzzzzzzi_);
            CqlCode vzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToCode(context, vzzzzzzzzze_);
            CqlCode vzzzzzzzzzm_ = NCQATerminology_1_0_0.Instance.home_health(context);
            bool? vzzzzzzzzzn_ = context.Operators.Equivalent(vzzzzzzzzzl_, vzzzzzzzzzm_);
            bool? vzzzzzzzzzo_ = context.Operators.Or(vzzzzzzzzzj_, vzzzzzzzzzn_);
            bool? vzzzzzzzzzp_ = context.Operators.And(vzzzzzzzzzf_, vzzzzzzzzzo_);

            return vzzzzzzzzzp_;
        };
        IEnumerable<Encounter> vzzzzzzzzzd_ = context.Operators.Where<Encounter>(vzzzzzzzzzb_, vzzzzzzzzzc_);

        return vzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Finished Encounter with Ambulatory POS")]
    public IEnumerable<Encounter> Finished_Encounter_with_Ambulatory_POS(CqlContext context, IEnumerable<Encounter> Encounter)
    {
        IEnumerable<Encounter> vzzzzzzzzzq_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, Encounter);
        bool? vzzzzzzzzzr_(Encounter E)
        {
            Coding vzzzzzzzzzt_ = E?.Class;
            bool? vzzzzzzzzzu_ = context.Operators.Not((bool?)(vzzzzzzzzzt_ is null));
            CqlCode vzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToCode(context, vzzzzzzzzzt_);
            CqlCode vzzzzzzzzzx_ = NCQATerminology_1_0_0.Instance.ambulatory(context);
            bool? vzzzzzzzzzy_ = context.Operators.Equivalent(vzzzzzzzzzw_, vzzzzzzzzzx_);
            bool? vzzzzzzzzzz_ = context.Operators.And(vzzzzzzzzzu_, vzzzzzzzzzy_);

            return vzzzzzzzzzz_;
        };
        IEnumerable<Encounter> vzzzzzzzzzs_ = context.Operators.Where<Encounter>(vzzzzzzzzzq_, vzzzzzzzzzr_);

        return vzzzzzzzzzs_;
    }


    #endregion Expressions

}
