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
        List<Encounter.DiagnosisComponent> tzzzh_ = Encounter?.Diagnosis;
        FhirString tzzzi_(Encounter.DiagnosisComponent D)
        {
            ResourceReference tzzzp_ = D?.Condition;
            FhirString tzzzq_ = tzzzp_?.ReferenceElement;

            return tzzzq_;
        };
        IEnumerable<FhirString> tzzzj_ = context.Operators.Select<Encounter.DiagnosisComponent, FhirString>((IEnumerable<Encounter.DiagnosisComponent>)tzzzh_, tzzzi_);
        IEnumerable<FhirString> tzzzk_ = context.Operators.Distinct<FhirString>(tzzzj_);
        bool? tzzzl_(FhirString CRef)
        {
            bool? tzzzr_(Condition C)
            {
                Id tzzzu_ = C?.IdElement;
                string tzzzv_ = FHIRHelpers_4_0_001.Instance.ToString(context, tzzzu_);
                string tzzzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, CRef);
                string tzzzx_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, tzzzw_);
                bool? tzzzy_ = context.Operators.Equal(tzzzv_, tzzzx_);

                return tzzzy_;
            };
            IEnumerable<Condition> tzzzs_ = context.Operators.Where<Condition>(Conditions, tzzzr_);
            bool? tzzzt_ = context.Operators.Exists<Condition>(tzzzs_);

            return tzzzt_;
        };
        IEnumerable<bool?> tzzzm_ = context.Operators.Select<FhirString, bool?>(tzzzk_, tzzzl_);
        IEnumerable<bool?> tzzzn_ = context.Operators.Distinct<bool?>(tzzzm_);
        bool? tzzzo_ = context.Operators.AnyTrue(tzzzn_);

        return tzzzo_;
    }


    [CqlExpressionDefinition("Encounter Has Principal Diagnosis")]
    public bool? Encounter_Has_Principal_Diagnosis(CqlContext context, Encounter Encounter, IEnumerable<Condition> Conditions)
    {
        List<Encounter.DiagnosisComponent> tzzzz_ = Encounter?.Diagnosis;
        bool? uzzza_(Encounter.DiagnosisComponent D)
        {
            PositiveInt uzzzi_ = D?.RankElement;
            Integer uzzzj_ = context.Operators.Convert<Integer>(uzzzi_);
            int? uzzzk_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, uzzzj_);
            bool? uzzzl_ = context.Operators.Equal(uzzzk_, 1);

            return uzzzl_;
        };
        IEnumerable<Encounter.DiagnosisComponent> uzzzb_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)tzzzz_, uzzza_);
        Encounter.DiagnosisComponent uzzzc_ = context.Operators.SingletonFrom<Encounter.DiagnosisComponent>(uzzzb_);
        Encounter.DiagnosisComponent[] uzzzd_ = [
            uzzzc_,
        ];
        bool? uzzze_(Encounter.DiagnosisComponent PrincipalDiagnosis)
        {
            bool? uzzzm_(Condition C)
            {
                Id uzzzp_ = C?.IdElement;
                string uzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzp_);
                ResourceReference uzzzr_ = PrincipalDiagnosis?.Condition;
                FhirString uzzzs_ = uzzzr_?.ReferenceElement;
                string uzzzt_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzs_);
                string uzzzu_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, uzzzt_);
                bool? uzzzv_ = context.Operators.Equal(uzzzq_, uzzzu_);

                return uzzzv_;
            };
            IEnumerable<Condition> uzzzn_ = context.Operators.Where<Condition>(Conditions, uzzzm_);
            bool? uzzzo_ = context.Operators.Exists<Condition>(uzzzn_);

            return uzzzo_;
        };
        IEnumerable<bool?> uzzzf_ = context.Operators.Select<Encounter.DiagnosisComponent, bool?>((IEnumerable<Encounter.DiagnosisComponent>)uzzzd_, uzzze_);
        IEnumerable<bool?> uzzzg_ = context.Operators.Distinct<bool?>(uzzzf_);
        bool? uzzzh_ = context.Operators.SingletonFrom<bool?>(uzzzg_);

        return uzzzh_;
    }


    [CqlExpressionDefinition("Encounter Completed during Period")]
    public bool? Encounter_Completed_during_Period(CqlContext context, IEnumerable<Encounter> Enc, CqlInterval<CqlDateTime> timeperiod)
    {
        IEnumerable<Encounter> uzzzw_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, Enc);
        bool? uzzzx_(Encounter EncounterPeriod)
        {
            Period vzzza_ = EncounterPeriod?.Period;
            CqlInterval<CqlDateTime> vzzzb_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, vzzza_ as object);
            CqlDateTime vzzzc_ = context.Operators.End(vzzzb_);
            bool? vzzzd_ = context.Operators.In<CqlDateTime>(vzzzc_, timeperiod, default);

            return vzzzd_;
        };
        IEnumerable<Encounter> uzzzy_ = context.Operators.Where<Encounter>(uzzzw_, uzzzx_);
        bool? uzzzz_ = context.Operators.Exists<Encounter>(uzzzy_);

        return uzzzz_;
    }


    [CqlExpressionDefinition("Finished Encounter with Telehealth POS")]
    public IEnumerable<Encounter> Finished_Encounter_with_Telehealth_POS(CqlContext context, IEnumerable<Encounter> Encounter)
    {
        IEnumerable<Encounter> vzzze_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, Encounter);
        bool? vzzzf_(Encounter E)
        {
            Coding vzzzh_ = E?.Class;
            bool? vzzzi_ = context.Operators.Not((bool?)(vzzzh_ is null));
            CqlCode vzzzk_ = FHIRHelpers_4_0_001.Instance.ToCode(context, vzzzh_);
            CqlCode vzzzl_ = NCQATerminology_1_0_0.Instance.@virtual(context);
            bool? vzzzm_ = context.Operators.Equivalent(vzzzk_, vzzzl_);
            bool? vzzzn_ = context.Operators.And(vzzzi_, vzzzm_);

            return vzzzn_;
        };
        IEnumerable<Encounter> vzzzg_ = context.Operators.Where<Encounter>(vzzze_, vzzzf_);

        return vzzzg_;
    }


    [CqlExpressionDefinition("Finished Encounter with Outpatient POS")]
    public IEnumerable<Encounter> Finished_Encounter_with_Outpatient_POS(CqlContext context, IEnumerable<Encounter> Encounter)
    {
        IEnumerable<Encounter> vzzzo_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, Encounter);
        bool? vzzzp_(Encounter E)
        {
            Coding vzzzr_ = E?.Class;
            bool? vzzzs_ = context.Operators.Not((bool?)(vzzzr_ is null));
            CqlCode vzzzu_ = FHIRHelpers_4_0_001.Instance.ToCode(context, vzzzr_);
            CqlCode vzzzv_ = NCQATerminology_1_0_0.Instance.ambulatory(context);
            bool? vzzzw_ = context.Operators.Equivalent(vzzzu_, vzzzv_);
            CqlCode vzzzy_ = FHIRHelpers_4_0_001.Instance.ToCode(context, vzzzr_);
            CqlCode vzzzz_ = NCQATerminology_1_0_0.Instance.home_health(context);
            bool? wzzza_ = context.Operators.Equivalent(vzzzy_, vzzzz_);
            bool? wzzzb_ = context.Operators.Or(vzzzw_, wzzza_);
            bool? wzzzc_ = context.Operators.And(vzzzs_, wzzzb_);

            return wzzzc_;
        };
        IEnumerable<Encounter> vzzzq_ = context.Operators.Where<Encounter>(vzzzo_, vzzzp_);

        return vzzzq_;
    }


    [CqlExpressionDefinition("Finished Encounter with Ambulatory POS")]
    public IEnumerable<Encounter> Finished_Encounter_with_Ambulatory_POS(CqlContext context, IEnumerable<Encounter> Encounter)
    {
        IEnumerable<Encounter> wzzzd_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, Encounter);
        bool? wzzze_(Encounter E)
        {
            Coding wzzzg_ = E?.Class;
            bool? wzzzh_ = context.Operators.Not((bool?)(wzzzg_ is null));
            CqlCode wzzzj_ = FHIRHelpers_4_0_001.Instance.ToCode(context, wzzzg_);
            CqlCode wzzzk_ = NCQATerminology_1_0_0.Instance.ambulatory(context);
            bool? wzzzl_ = context.Operators.Equivalent(wzzzj_, wzzzk_);
            bool? wzzzm_ = context.Operators.And(wzzzh_, wzzzl_);

            return wzzzm_;
        };
        IEnumerable<Encounter> wzzzf_ = context.Operators.Where<Encounter>(wzzzd_, wzzze_);

        return wzzzf_;
    }


    #endregion Expressions

}
