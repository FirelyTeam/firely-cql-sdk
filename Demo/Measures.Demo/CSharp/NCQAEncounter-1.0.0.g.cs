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

    // NOT A DEFINITION CqlExpressionDefinition//
    public bool? Encounter_Has_Diagnosis(CqlContext context, Encounter Encounter, IEnumerable<Condition> Conditions)
    {
        List<Encounter.DiagnosisComponent> czzzzzzs_ = Encounter?.Diagnosis;
        FhirString czzzzzzt_(Encounter.DiagnosisComponent D)
        {
            ResourceReference dzzzzzza_ = D?.Condition;
            FhirString dzzzzzzb_ = dzzzzzza_?.ReferenceElement;

            return dzzzzzzb_;
        };
        IEnumerable<FhirString> czzzzzzu_ = context.Operators.Select<Encounter.DiagnosisComponent, FhirString>((IEnumerable<Encounter.DiagnosisComponent>)czzzzzzs_, czzzzzzt_);
        IEnumerable<FhirString> czzzzzzv_ = context.Operators.Distinct<FhirString>(czzzzzzu_);
        bool? czzzzzzw_(FhirString CRef)
        {
            bool? dzzzzzzc_(Condition C)
            {
                Id dzzzzzzf_ = C?.IdElement;
                string dzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzzzzzf_);
                string dzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToString(context, CRef);
                string dzzzzzzi_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, dzzzzzzh_);
                bool? dzzzzzzj_ = context.Operators.Equal(dzzzzzzg_, dzzzzzzi_);

                return dzzzzzzj_;
            };
            IEnumerable<Condition> dzzzzzzd_ = context.Operators.Where<Condition>(Conditions, dzzzzzzc_);
            bool? dzzzzzze_ = context.Operators.Exists<Condition>(dzzzzzzd_);

            return dzzzzzze_;
        };
        IEnumerable<bool?> czzzzzzx_ = context.Operators.Select<FhirString, bool?>(czzzzzzv_, czzzzzzw_);
        IEnumerable<bool?> czzzzzzy_ = context.Operators.Distinct<bool?>(czzzzzzx_);
        bool? czzzzzzz_ = context.Operators.AnyTrue(czzzzzzy_);

        return czzzzzzz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public bool? Encounter_Has_Principal_Diagnosis(CqlContext context, Encounter Encounter, IEnumerable<Condition> Conditions)
    {
        List<Encounter.DiagnosisComponent> dzzzzzzk_ = Encounter?.Diagnosis;
        bool? dzzzzzzl_(Encounter.DiagnosisComponent D)
        {
            PositiveInt dzzzzzzt_ = D?.RankElement;
            Integer dzzzzzzu_ = context.Operators.Convert<Integer>(dzzzzzzt_);
            int? dzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, dzzzzzzu_);
            bool? dzzzzzzw_ = context.Operators.Equal(dzzzzzzv_, 1);

            return dzzzzzzw_;
        };
        IEnumerable<Encounter.DiagnosisComponent> dzzzzzzm_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)dzzzzzzk_, dzzzzzzl_);
        Encounter.DiagnosisComponent dzzzzzzn_ = context.Operators.SingletonFrom<Encounter.DiagnosisComponent>(dzzzzzzm_);
        Encounter.DiagnosisComponent[] dzzzzzzo_ = [
            dzzzzzzn_,
        ];
        bool? dzzzzzzp_(Encounter.DiagnosisComponent PrincipalDiagnosis)
        {
            bool? dzzzzzzx_(Condition C)
            {
                Id ezzzzzza_ = C?.IdElement;
                string ezzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzzzza_);
                ResourceReference ezzzzzzc_ = PrincipalDiagnosis?.Condition;
                FhirString ezzzzzzd_ = ezzzzzzc_?.ReferenceElement;
                string ezzzzzze_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzzzzd_);
                string ezzzzzzf_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, ezzzzzze_);
                bool? ezzzzzzg_ = context.Operators.Equal(ezzzzzzb_, ezzzzzzf_);

                return ezzzzzzg_;
            };
            IEnumerable<Condition> dzzzzzzy_ = context.Operators.Where<Condition>(Conditions, dzzzzzzx_);
            bool? dzzzzzzz_ = context.Operators.Exists<Condition>(dzzzzzzy_);

            return dzzzzzzz_;
        };
        IEnumerable<bool?> dzzzzzzq_ = context.Operators.Select<Encounter.DiagnosisComponent, bool?>((IEnumerable<Encounter.DiagnosisComponent>)dzzzzzzo_, dzzzzzzp_);
        IEnumerable<bool?> dzzzzzzr_ = context.Operators.Distinct<bool?>(dzzzzzzq_);
        bool? dzzzzzzs_ = context.Operators.SingletonFrom<bool?>(dzzzzzzr_);

        return dzzzzzzs_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public bool? Encounter_Completed_during_Period(CqlContext context, IEnumerable<Encounter> Enc, CqlInterval<CqlDateTime> timeperiod)
    {
        IEnumerable<Encounter> ezzzzzzh_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, Enc);
        bool? ezzzzzzi_(Encounter EncounterPeriod)
        {
            Period ezzzzzzl_ = EncounterPeriod?.Period;
            CqlInterval<CqlDateTime> ezzzzzzm_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ezzzzzzl_ as object);
            CqlDateTime ezzzzzzn_ = context.Operators.End(ezzzzzzm_);
            bool? ezzzzzzo_ = context.Operators.In<CqlDateTime>(ezzzzzzn_, timeperiod, default);

            return ezzzzzzo_;
        };
        IEnumerable<Encounter> ezzzzzzj_ = context.Operators.Where<Encounter>(ezzzzzzh_, ezzzzzzi_);
        bool? ezzzzzzk_ = context.Operators.Exists<Encounter>(ezzzzzzj_);

        return ezzzzzzk_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Encounter> Finished_Encounter_with_Telehealth_POS(CqlContext context, IEnumerable<Encounter> Encounter)
    {
        IEnumerable<Encounter> ezzzzzzp_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, Encounter);
        bool? ezzzzzzq_(Encounter E)
        {
            Coding ezzzzzzs_ = E?.Class;
            bool? ezzzzzzt_ = context.Operators.Not((bool?)(ezzzzzzs_ is null));
            CqlCode ezzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ezzzzzzs_);
            CqlCode ezzzzzzw_ = NCQATerminology_1_0_0.Instance.@virtual(context);
            bool? ezzzzzzx_ = context.Operators.Equivalent(ezzzzzzv_, ezzzzzzw_);
            bool? ezzzzzzy_ = context.Operators.And(ezzzzzzt_, ezzzzzzx_);

            return ezzzzzzy_;
        };
        IEnumerable<Encounter> ezzzzzzr_ = context.Operators.Where<Encounter>(ezzzzzzp_, ezzzzzzq_);

        return ezzzzzzr_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Encounter> Finished_Encounter_with_Outpatient_POS(CqlContext context, IEnumerable<Encounter> Encounter)
    {
        IEnumerable<Encounter> ezzzzzzz_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, Encounter);
        bool? fzzzzzza_(Encounter E)
        {
            Coding fzzzzzzc_ = E?.Class;
            bool? fzzzzzzd_ = context.Operators.Not((bool?)(fzzzzzzc_ is null));
            CqlCode fzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToCode(context, fzzzzzzc_);
            CqlCode fzzzzzzg_ = NCQATerminology_1_0_0.Instance.ambulatory(context);
            bool? fzzzzzzh_ = context.Operators.Equivalent(fzzzzzzf_, fzzzzzzg_);
            CqlCode fzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToCode(context, fzzzzzzc_);
            CqlCode fzzzzzzk_ = NCQATerminology_1_0_0.Instance.home_health(context);
            bool? fzzzzzzl_ = context.Operators.Equivalent(fzzzzzzj_, fzzzzzzk_);
            bool? fzzzzzzm_ = context.Operators.Or(fzzzzzzh_, fzzzzzzl_);
            bool? fzzzzzzn_ = context.Operators.And(fzzzzzzd_, fzzzzzzm_);

            return fzzzzzzn_;
        };
        IEnumerable<Encounter> fzzzzzzb_ = context.Operators.Where<Encounter>(ezzzzzzz_, fzzzzzza_);

        return fzzzzzzb_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Encounter> Finished_Encounter_with_Ambulatory_POS(CqlContext context, IEnumerable<Encounter> Encounter)
    {
        IEnumerable<Encounter> fzzzzzzo_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, Encounter);
        bool? fzzzzzzp_(Encounter E)
        {
            Coding fzzzzzzr_ = E?.Class;
            bool? fzzzzzzs_ = context.Operators.Not((bool?)(fzzzzzzr_ is null));
            CqlCode fzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToCode(context, fzzzzzzr_);
            CqlCode fzzzzzzv_ = NCQATerminology_1_0_0.Instance.ambulatory(context);
            bool? fzzzzzzw_ = context.Operators.Equivalent(fzzzzzzu_, fzzzzzzv_);
            bool? fzzzzzzx_ = context.Operators.And(fzzzzzzs_, fzzzzzzw_);

            return fzzzzzzx_;
        };
        IEnumerable<Encounter> fzzzzzzq_ = context.Operators.Where<Encounter>(fzzzzzzo_, fzzzzzzp_);

        return fzzzzzzq_;
    }


    #endregion Expressions

}
