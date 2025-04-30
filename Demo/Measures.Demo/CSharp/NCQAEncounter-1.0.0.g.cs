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
        List<Encounter.DiagnosisComponent> vzzzze_ = Encounter?.Diagnosis;
        FhirString vzzzzf_(Encounter.DiagnosisComponent D)
        {
            ResourceReference vzzzzm_ = D?.Condition;
            FhirString vzzzzn_ = vzzzzm_?.ReferenceElement;

            return vzzzzn_;
        };
        IEnumerable<FhirString> vzzzzg_ = context.Operators.Select<Encounter.DiagnosisComponent, FhirString>((IEnumerable<Encounter.DiagnosisComponent>)vzzzze_, vzzzzf_);
        IEnumerable<FhirString> vzzzzh_ = context.Operators.Distinct<FhirString>(vzzzzg_);
        bool? vzzzzi_(FhirString CRef)
        {
            bool? vzzzzo_(Condition C)
            {
                Id vzzzzr_ = C?.IdElement;
                string vzzzzs_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzzzzr_);
                string vzzzzt_ = FHIRHelpers_4_0_001.Instance.ToString(context, CRef);
                string vzzzzu_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, vzzzzt_);
                bool? vzzzzv_ = context.Operators.Equal(vzzzzs_, vzzzzu_);

                return vzzzzv_;
            };
            IEnumerable<Condition> vzzzzp_ = context.Operators.Where<Condition>(Conditions, vzzzzo_);
            bool? vzzzzq_ = context.Operators.Exists<Condition>(vzzzzp_);

            return vzzzzq_;
        };
        IEnumerable<bool?> vzzzzj_ = context.Operators.Select<FhirString, bool?>(vzzzzh_, vzzzzi_);
        IEnumerable<bool?> vzzzzk_ = context.Operators.Distinct<bool?>(vzzzzj_);
        bool? vzzzzl_ = context.Operators.AnyTrue(vzzzzk_);

        return vzzzzl_;
    }


    [CqlExpressionDefinition("Encounter Has Principal Diagnosis")]
    public bool? Encounter_Has_Principal_Diagnosis(CqlContext context, Encounter Encounter, IEnumerable<Condition> Conditions)
    {
        List<Encounter.DiagnosisComponent> vzzzzw_ = Encounter?.Diagnosis;
        bool? vzzzzx_(Encounter.DiagnosisComponent D)
        {
            PositiveInt wzzzzf_ = D?.RankElement;
            Integer wzzzzg_ = context.Operators.Convert<Integer>(wzzzzf_);
            int? wzzzzh_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, wzzzzg_);
            bool? wzzzzi_ = context.Operators.Equal(wzzzzh_, 1);

            return wzzzzi_;
        };
        IEnumerable<Encounter.DiagnosisComponent> vzzzzy_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)vzzzzw_, vzzzzx_);
        Encounter.DiagnosisComponent vzzzzz_ = context.Operators.SingletonFrom<Encounter.DiagnosisComponent>(vzzzzy_);
        Encounter.DiagnosisComponent[] wzzzza_ = [
            vzzzzz_,
        ];
        bool? wzzzzb_(Encounter.DiagnosisComponent PrincipalDiagnosis)
        {
            bool? wzzzzj_(Condition C)
            {
                Id wzzzzm_ = C?.IdElement;
                string wzzzzn_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzzzm_);
                ResourceReference wzzzzo_ = PrincipalDiagnosis?.Condition;
                FhirString wzzzzp_ = wzzzzo_?.ReferenceElement;
                string wzzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzzzp_);
                string wzzzzr_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, wzzzzq_);
                bool? wzzzzs_ = context.Operators.Equal(wzzzzn_, wzzzzr_);

                return wzzzzs_;
            };
            IEnumerable<Condition> wzzzzk_ = context.Operators.Where<Condition>(Conditions, wzzzzj_);
            bool? wzzzzl_ = context.Operators.Exists<Condition>(wzzzzk_);

            return wzzzzl_;
        };
        IEnumerable<bool?> wzzzzc_ = context.Operators.Select<Encounter.DiagnosisComponent, bool?>((IEnumerable<Encounter.DiagnosisComponent>)wzzzza_, wzzzzb_);
        IEnumerable<bool?> wzzzzd_ = context.Operators.Distinct<bool?>(wzzzzc_);
        bool? wzzzze_ = context.Operators.SingletonFrom<bool?>(wzzzzd_);

        return wzzzze_;
    }


    [CqlExpressionDefinition("Encounter Completed during Period")]
    public bool? Encounter_Completed_during_Period(CqlContext context, IEnumerable<Encounter> Enc, CqlInterval<CqlDateTime> timeperiod)
    {
        IEnumerable<Encounter> wzzzzt_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, Enc);
        bool? wzzzzu_(Encounter EncounterPeriod)
        {
            Period wzzzzx_ = EncounterPeriod?.Period;
            CqlInterval<CqlDateTime> wzzzzy_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, wzzzzx_ as object);
            CqlDateTime wzzzzz_ = context.Operators.End(wzzzzy_);
            bool? xzzzza_ = context.Operators.In<CqlDateTime>(wzzzzz_, timeperiod, default);

            return xzzzza_;
        };
        IEnumerable<Encounter> wzzzzv_ = context.Operators.Where<Encounter>(wzzzzt_, wzzzzu_);
        bool? wzzzzw_ = context.Operators.Exists<Encounter>(wzzzzv_);

        return wzzzzw_;
    }


    [CqlExpressionDefinition("Finished Encounter with Telehealth POS")]
    public IEnumerable<Encounter> Finished_Encounter_with_Telehealth_POS(CqlContext context, IEnumerable<Encounter> Encounter)
    {
        IEnumerable<Encounter> xzzzzb_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, Encounter);
        bool? xzzzzc_(Encounter E)
        {
            Coding xzzzze_ = E?.Class;
            bool? xzzzzf_ = context.Operators.Not((bool?)(xzzzze_ is null));
            CqlCode xzzzzh_ = FHIRHelpers_4_0_001.Instance.ToCode(context, xzzzze_);
            CqlCode xzzzzi_ = NCQATerminology_1_0_0.Instance.@virtual(context);
            bool? xzzzzj_ = context.Operators.Equivalent(xzzzzh_, xzzzzi_);
            bool? xzzzzk_ = context.Operators.And(xzzzzf_, xzzzzj_);

            return xzzzzk_;
        };
        IEnumerable<Encounter> xzzzzd_ = context.Operators.Where<Encounter>(xzzzzb_, xzzzzc_);

        return xzzzzd_;
    }


    [CqlExpressionDefinition("Finished Encounter with Outpatient POS")]
    public IEnumerable<Encounter> Finished_Encounter_with_Outpatient_POS(CqlContext context, IEnumerable<Encounter> Encounter)
    {
        IEnumerable<Encounter> xzzzzl_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, Encounter);
        bool? xzzzzm_(Encounter E)
        {
            Coding xzzzzo_ = E?.Class;
            bool? xzzzzp_ = context.Operators.Not((bool?)(xzzzzo_ is null));
            CqlCode xzzzzr_ = FHIRHelpers_4_0_001.Instance.ToCode(context, xzzzzo_);
            CqlCode xzzzzs_ = NCQATerminology_1_0_0.Instance.ambulatory(context);
            bool? xzzzzt_ = context.Operators.Equivalent(xzzzzr_, xzzzzs_);
            CqlCode xzzzzv_ = FHIRHelpers_4_0_001.Instance.ToCode(context, xzzzzo_);
            CqlCode xzzzzw_ = NCQATerminology_1_0_0.Instance.home_health(context);
            bool? xzzzzx_ = context.Operators.Equivalent(xzzzzv_, xzzzzw_);
            bool? xzzzzy_ = context.Operators.Or(xzzzzt_, xzzzzx_);
            bool? xzzzzz_ = context.Operators.And(xzzzzp_, xzzzzy_);

            return xzzzzz_;
        };
        IEnumerable<Encounter> xzzzzn_ = context.Operators.Where<Encounter>(xzzzzl_, xzzzzm_);

        return xzzzzn_;
    }


    [CqlExpressionDefinition("Finished Encounter with Ambulatory POS")]
    public IEnumerable<Encounter> Finished_Encounter_with_Ambulatory_POS(CqlContext context, IEnumerable<Encounter> Encounter)
    {
        IEnumerable<Encounter> yzzzza_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, Encounter);
        bool? yzzzzb_(Encounter E)
        {
            Coding yzzzzd_ = E?.Class;
            bool? yzzzze_ = context.Operators.Not((bool?)(yzzzzd_ is null));
            CqlCode yzzzzg_ = FHIRHelpers_4_0_001.Instance.ToCode(context, yzzzzd_);
            CqlCode yzzzzh_ = NCQATerminology_1_0_0.Instance.ambulatory(context);
            bool? yzzzzi_ = context.Operators.Equivalent(yzzzzg_, yzzzzh_);
            bool? yzzzzj_ = context.Operators.And(yzzzze_, yzzzzi_);

            return yzzzzj_;
        };
        IEnumerable<Encounter> yzzzzc_ = context.Operators.Where<Encounter>(yzzzza_, yzzzzb_);

        return yzzzzc_;
    }


    #endregion Expressions

}
