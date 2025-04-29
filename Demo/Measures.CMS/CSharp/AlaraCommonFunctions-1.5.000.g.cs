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
[CqlLibrary("AlaraCommonFunctions", "1.5.000")]
public partial class AlaraCommonFunctions_1_5_000 : ILibrary, ISingleton<AlaraCommonFunctions_1_5_000>
{
    private AlaraCommonFunctions_1_5_000() {}

    public static AlaraCommonFunctions_1_5_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "AlaraCommonFunctions";
    public string Version => "1.5.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance];

    #endregion ILibrary Implementation

    #region Codes

    [CqlCodeDefinition("Abdomen and Pelvis High Dose", codeId: "LA31754-7", codeSystem: "http://loinc.org")]
    public CqlCode Abdomen_and_Pelvis_High_Dose(CqlContext _) => _Abdomen_and_Pelvis_High_Dose;
    private static readonly CqlCode _Abdomen_and_Pelvis_High_Dose = new CqlCode("LA31754-7", "http://loinc.org", default, default);

    [CqlCodeDefinition("Abdomen and Pelvis Low Dose", codeId: "LA31752-1", codeSystem: "http://loinc.org")]
    public CqlCode Abdomen_and_Pelvis_Low_Dose(CqlContext _) => _Abdomen_and_Pelvis_Low_Dose;
    private static readonly CqlCode _Abdomen_and_Pelvis_Low_Dose = new CqlCode("LA31752-1", "http://loinc.org", default, default);

    [CqlCodeDefinition("Abdomen and Pelvis Routine Dose", codeId: "LA31753-9", codeSystem: "http://loinc.org")]
    public CqlCode Abdomen_and_Pelvis_Routine_Dose(CqlContext _) => _Abdomen_and_Pelvis_Routine_Dose;
    private static readonly CqlCode _Abdomen_and_Pelvis_Routine_Dose = new CqlCode("LA31753-9", "http://loinc.org", default, default);

    [CqlCodeDefinition("Calculated CT global noise", codeId: "96912-1", codeSystem: "http://loinc.org")]
    public CqlCode Calculated_CT_global_noise(CqlContext _) => _Calculated_CT_global_noise;
    private static readonly CqlCode _Calculated_CT_global_noise = new CqlCode("96912-1", "http://loinc.org", default, default);

    [CqlCodeDefinition("Calculated CT size-adjusted dose", codeId: "96913-9", codeSystem: "http://loinc.org")]
    public CqlCode Calculated_CT_size_adjusted_dose(CqlContext _) => _Calculated_CT_size_adjusted_dose;
    private static readonly CqlCode _Calculated_CT_size_adjusted_dose = new CqlCode("96913-9", "http://loinc.org", default, default);

    [CqlCodeDefinition("Cardiac High Dose or Chest High Dose", codeId: "LA31761-2", codeSystem: "http://loinc.org")]
    public CqlCode Cardiac_High_Dose_or_Chest_High_Dose(CqlContext _) => _Cardiac_High_Dose_or_Chest_High_Dose;
    private static readonly CqlCode _Cardiac_High_Dose_or_Chest_High_Dose = new CqlCode("LA31761-2", "http://loinc.org", default, default);

    [CqlCodeDefinition("Cardiac Low Dose", codeId: "LA31755-4", codeSystem: "http://loinc.org")]
    public CqlCode Cardiac_Low_Dose(CqlContext _) => _Cardiac_Low_Dose;
    private static readonly CqlCode _Cardiac_Low_Dose = new CqlCode("LA31755-4", "http://loinc.org", default, default);

    [CqlCodeDefinition("Cardiac Routine Dose", codeId: "LA31756-2", codeSystem: "http://loinc.org")]
    public CqlCode Cardiac_Routine_Dose(CqlContext _) => _Cardiac_Routine_Dose;
    private static readonly CqlCode _Cardiac_Routine_Dose = new CqlCode("LA31756-2", "http://loinc.org", default, default);

    [CqlCodeDefinition("Chest Low Dose", codeId: "LA31758-8", codeSystem: "http://loinc.org")]
    public CqlCode Chest_Low_Dose(CqlContext _) => _Chest_Low_Dose;
    private static readonly CqlCode _Chest_Low_Dose = new CqlCode("LA31758-8", "http://loinc.org", default, default);

    [CqlCodeDefinition("Chest Routine Dose", codeId: "LA31759-6", codeSystem: "http://loinc.org")]
    public CqlCode Chest_Routine_Dose(CqlContext _) => _Chest_Routine_Dose;
    private static readonly CqlCode _Chest_Routine_Dose = new CqlCode("LA31759-6", "http://loinc.org", default, default);

    [CqlCodeDefinition("Extremity", codeId: "LA31765-3", codeSystem: "http://loinc.org")]
    public CqlCode Extremity(CqlContext _) => _Extremity;
    private static readonly CqlCode _Extremity = new CqlCode("LA31765-3", "http://loinc.org", default, default);

    [CqlCodeDefinition("Head High Dose", codeId: "LA31764-6", codeSystem: "http://loinc.org")]
    public CqlCode Head_High_Dose(CqlContext _) => _Head_High_Dose;
    private static readonly CqlCode _Head_High_Dose = new CqlCode("LA31764-6", "http://loinc.org", default, default);

    [CqlCodeDefinition("Head Low Dose", codeId: "LA31762-0", codeSystem: "http://loinc.org")]
    public CqlCode Head_Low_Dose(CqlContext _) => _Head_Low_Dose;
    private static readonly CqlCode _Head_Low_Dose = new CqlCode("LA31762-0", "http://loinc.org", default, default);

    [CqlCodeDefinition("Head Routine Dose", codeId: "LA31763-8", codeSystem: "http://loinc.org")]
    public CqlCode Head_Routine_Dose(CqlContext _) => _Head_Routine_Dose;
    private static readonly CqlCode _Head_Routine_Dose = new CqlCode("LA31763-8", "http://loinc.org", default, default);

    [CqlCodeDefinition("Neck or Cervical Spine", codeId: "LA31766-1", codeSystem: "http://loinc.org")]
    public CqlCode Neck_or_Cervical_Spine(CqlContext _) => _Neck_or_Cervical_Spine;
    private static readonly CqlCode _Neck_or_Cervical_Spine = new CqlCode("LA31766-1", "http://loinc.org", default, default);

    [CqlCodeDefinition("Simultaneous Chest and Abdomen and Pelvis", codeId: "LA31768-7", codeSystem: "http://loinc.org")]
    public CqlCode Simultaneous_Chest_and_Abdomen_and_Pelvis(CqlContext _) => _Simultaneous_Chest_and_Abdomen_and_Pelvis;
    private static readonly CqlCode _Simultaneous_Chest_and_Abdomen_and_Pelvis = new CqlCode("LA31768-7", "http://loinc.org", default, default);

    [CqlCodeDefinition("Simultaneous Head and Neck High Dose", codeId: "LA31770-3", codeSystem: "http://loinc.org")]
    public CqlCode Simultaneous_Head_and_Neck_High_Dose(CqlContext _) => _Simultaneous_Head_and_Neck_High_Dose;
    private static readonly CqlCode _Simultaneous_Head_and_Neck_High_Dose = new CqlCode("LA31770-3", "http://loinc.org", default, default);

    [CqlCodeDefinition("Simultaneous Head and Neck Routine Dose", codeId: "LA31769-5", codeSystem: "http://loinc.org")]
    public CqlCode Simultaneous_Head_and_Neck_Routine_Dose(CqlContext _) => _Simultaneous_Head_and_Neck_Routine_Dose;
    private static readonly CqlCode _Simultaneous_Head_and_Neck_Routine_Dose = new CqlCode("LA31769-5", "http://loinc.org", default, default);

    [CqlCodeDefinition("Simultaneous Thoracic and Lumbar Spine", codeId: "LA31851-1", codeSystem: "http://loinc.org")]
    public CqlCode Simultaneous_Thoracic_and_Lumbar_Spine(CqlContext _) => _Simultaneous_Thoracic_and_Lumbar_Spine;
    private static readonly CqlCode _Simultaneous_Thoracic_and_Lumbar_Spine = new CqlCode("LA31851-1", "http://loinc.org", default, default);

    [CqlCodeDefinition("Thoracic or Lumbar Spine", codeId: "LA31767-9", codeSystem: "http://loinc.org")]
    public CqlCode Thoracic_or_Lumbar_Spine(CqlContext _) => _Thoracic_or_Lumbar_Spine;
    private static readonly CqlCode _Thoracic_or_Lumbar_Spine = new CqlCode("LA31767-9", "http://loinc.org", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC = new CqlCodeSystem();

    #endregion CodeSystems

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> dzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient dzzzzzzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<Patient>(dzzzzzzzzzzzzzzzzzv_);

        return dzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Global Noise Value")]
    public decimal? Global_Noise_Value(CqlContext context, Observation Obs)
    {
        List<Observation.ComponentComponent> dzzzzzzzzzzzzzzzzzx_ = Obs?.Component;
        bool? dzzzzzzzzzzzzzzzzzy_(Observation.ComponentComponent C)
        {
            CodeableConcept ezzzzzzzzzzzzzzzzze_ = C?.Code;
            CqlConcept ezzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzzzzzzzzze_);
            CqlCode ezzzzzzzzzzzzzzzzzg_ = this.Calculated_CT_global_noise(context);
            CqlConcept ezzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertCodeToConcept(ezzzzzzzzzzzzzzzzzg_);
            bool? ezzzzzzzzzzzzzzzzzi_ = context.Operators.Equivalent(ezzzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzzh_);
            DataType ezzzzzzzzzzzzzzzzzj_ = C?.Value;
            object ezzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzj_);
            string ezzzzzzzzzzzzzzzzzl_ = (ezzzzzzzzzzzzzzzzzk_ as CqlQuantity)?.unit;
            bool? ezzzzzzzzzzzzzzzzzm_ = context.Operators.Equal(ezzzzzzzzzzzzzzzzzl_, "[hnsf'U]");
            bool? ezzzzzzzzzzzzzzzzzn_ = context.Operators.And(ezzzzzzzzzzzzzzzzzi_, ezzzzzzzzzzzzzzzzzm_);

            return ezzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Observation.ComponentComponent> dzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)dzzzzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzzzy_);
        decimal? ezzzzzzzzzzzzzzzzza_(Observation.ComponentComponent C)
        {
            DataType ezzzzzzzzzzzzzzzzzo_ = C?.Value;
            object ezzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzo_);
            decimal? ezzzzzzzzzzzzzzzzzq_ = (ezzzzzzzzzzzzzzzzzp_ as CqlQuantity)?.value;

            return ezzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<decimal?> ezzzzzzzzzzzzzzzzzb_ = context.Operators.Select<Observation.ComponentComponent, decimal?>(dzzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzza_);
        IEnumerable<decimal?> ezzzzzzzzzzzzzzzzzc_ = context.Operators.Distinct<decimal?>(ezzzzzzzzzzzzzzzzzb_);
        decimal? ezzzzzzzzzzzzzzzzzd_ = context.Operators.SingletonFrom<decimal?>(ezzzzzzzzzzzzzzzzzc_);

        return ezzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Size Adjusted Value")]
    public decimal? Size_Adjusted_Value(CqlContext context, Observation Obs)
    {
        List<Observation.ComponentComponent> ezzzzzzzzzzzzzzzzzr_ = Obs?.Component;
        bool? ezzzzzzzzzzzzzzzzzs_(Observation.ComponentComponent C)
        {
            CodeableConcept ezzzzzzzzzzzzzzzzzy_ = C?.Code;
            CqlConcept ezzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzzzzzzzzzy_);
            CqlCode fzzzzzzzzzzzzzzzzza_ = this.Calculated_CT_size_adjusted_dose(context);
            CqlConcept fzzzzzzzzzzzzzzzzzb_ = context.Operators.ConvertCodeToConcept(fzzzzzzzzzzzzzzzzza_);
            bool? fzzzzzzzzzzzzzzzzzc_ = context.Operators.Equivalent(ezzzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzzzb_);
            DataType fzzzzzzzzzzzzzzzzzd_ = C?.Value;
            object fzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzd_);
            string fzzzzzzzzzzzzzzzzzf_ = (fzzzzzzzzzzzzzzzzze_ as CqlQuantity)?.unit;
            bool? fzzzzzzzzzzzzzzzzzg_ = context.Operators.Equal(fzzzzzzzzzzzzzzzzzf_, "mGy.cm");
            bool? fzzzzzzzzzzzzzzzzzh_ = context.Operators.And(fzzzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzzzg_);

            return fzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Observation.ComponentComponent> ezzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ezzzzzzzzzzzzzzzzzr_, ezzzzzzzzzzzzzzzzzs_);
        decimal? ezzzzzzzzzzzzzzzzzu_(Observation.ComponentComponent C)
        {
            DataType fzzzzzzzzzzzzzzzzzi_ = C?.Value;
            object fzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzi_);
            decimal? fzzzzzzzzzzzzzzzzzk_ = (fzzzzzzzzzzzzzzzzzj_ as CqlQuantity)?.value;

            return fzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<decimal?> ezzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Observation.ComponentComponent, decimal?>(ezzzzzzzzzzzzzzzzzt_, ezzzzzzzzzzzzzzzzzu_);
        IEnumerable<decimal?> ezzzzzzzzzzzzzzzzzw_ = context.Operators.Distinct<decimal?>(ezzzzzzzzzzzzzzzzzv_);
        decimal? ezzzzzzzzzzzzzzzzzx_ = context.Operators.SingletonFrom<decimal?>(ezzzzzzzzzzzzzzzzzw_);

        return ezzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Qualifies")]
    public bool? Qualifies(CqlContext context, Observation Obs, CqlCode code, decimal? noiseThreshold, decimal? sizeDoseThreshold)
    {
        DataType fzzzzzzzzzzzzzzzzzl_ = Obs?.Value;
        object fzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzl_);
        CqlCode[] fzzzzzzzzzzzzzzzzzn_ = (fzzzzzzzzzzzzzzzzzm_ as CqlConcept)?.codes;
        bool? fzzzzzzzzzzzzzzzzzo_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)fzzzzzzzzzzzzzzzzzn_, code);
        decimal? fzzzzzzzzzzzzzzzzzp_ = this.Global_Noise_Value(context, Obs);
        bool? fzzzzzzzzzzzzzzzzzq_ = context.Operators.GreaterOrEqual(fzzzzzzzzzzzzzzzzzp_, noiseThreshold);
        decimal? fzzzzzzzzzzzzzzzzzr_ = this.Size_Adjusted_Value(context, Obs);
        bool? fzzzzzzzzzzzzzzzzzs_ = context.Operators.GreaterOrEqual(fzzzzzzzzzzzzzzzzzr_, sizeDoseThreshold);
        bool? fzzzzzzzzzzzzzzzzzt_ = context.Operators.Or(fzzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzzs_);
        bool? fzzzzzzzzzzzzzzzzzu_ = context.Operators.And(fzzzzzzzzzzzzzzzzzo_, fzzzzzzzzzzzzzzzzzt_);

        return fzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("CT Scan Qualifies")]
    public bool? CT_Scan_Qualifies(CqlContext context, Observation Obs)
    {
        CqlCode fzzzzzzzzzzzzzzzzzv_ = this.Abdomen_and_Pelvis_Low_Dose(context);
        decimal? fzzzzzzzzzzzzzzzzzw_ = context.Operators.ConvertIntegerToDecimal(64);
        decimal? fzzzzzzzzzzzzzzzzzx_ = context.Operators.ConvertIntegerToDecimal(598);
        bool? fzzzzzzzzzzzzzzzzzy_ = this.Qualifies(context, Obs, fzzzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzzzzzx_);
        CqlCode fzzzzzzzzzzzzzzzzzz_ = this.Abdomen_and_Pelvis_Routine_Dose(context);
        decimal? gzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertIntegerToDecimal(29);
        decimal? gzzzzzzzzzzzzzzzzzb_ = context.Operators.ConvertIntegerToDecimal(644);
        bool? gzzzzzzzzzzzzzzzzzc_ = this.Qualifies(context, Obs, fzzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzza_, gzzzzzzzzzzzzzzzzzb_);
        bool? gzzzzzzzzzzzzzzzzzd_ = context.Operators.Or(fzzzzzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzzzzzc_);
        CqlCode gzzzzzzzzzzzzzzzzze_ = this.Abdomen_and_Pelvis_High_Dose(context);
        decimal? gzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertIntegerToDecimal(1260);
        bool? gzzzzzzzzzzzzzzzzzh_ = this.Qualifies(context, Obs, gzzzzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzzzza_, gzzzzzzzzzzzzzzzzzg_);
        bool? gzzzzzzzzzzzzzzzzzi_ = context.Operators.Or(gzzzzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzzzzzh_);
        CqlCode gzzzzzzzzzzzzzzzzzj_ = this.Cardiac_Low_Dose(context);
        decimal? gzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertIntegerToDecimal(55);
        decimal? gzzzzzzzzzzzzzzzzzl_ = context.Operators.ConvertIntegerToDecimal(93);
        bool? gzzzzzzzzzzzzzzzzzm_ = this.Qualifies(context, Obs, gzzzzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzzzzk_, gzzzzzzzzzzzzzzzzzl_);
        bool? gzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(gzzzzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzzzzm_);
        CqlCode gzzzzzzzzzzzzzzzzzo_ = this.Cardiac_Routine_Dose(context);
        decimal? gzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertIntegerToDecimal(32);
        decimal? gzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertIntegerToDecimal(576);
        bool? gzzzzzzzzzzzzzzzzzr_ = this.Qualifies(context, Obs, gzzzzzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzzzzzp_, gzzzzzzzzzzzzzzzzzq_);
        bool? gzzzzzzzzzzzzzzzzzs_ = context.Operators.Or(gzzzzzzzzzzzzzzzzzn_, gzzzzzzzzzzzzzzzzzr_);
        CqlCode gzzzzzzzzzzzzzzzzzt_ = this.Chest_Low_Dose(context);
        decimal? gzzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertIntegerToDecimal(377);
        bool? gzzzzzzzzzzzzzzzzzw_ = this.Qualifies(context, Obs, gzzzzzzzzzzzzzzzzzt_, gzzzzzzzzzzzzzzzzzk_, gzzzzzzzzzzzzzzzzzv_);
        bool? gzzzzzzzzzzzzzzzzzx_ = context.Operators.Or(gzzzzzzzzzzzzzzzzzs_, gzzzzzzzzzzzzzzzzzw_);
        CqlCode gzzzzzzzzzzzzzzzzzy_ = this.Chest_Routine_Dose(context);
        decimal? gzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertIntegerToDecimal(49);
        bool? hzzzzzzzzzzzzzzzzzb_ = this.Qualifies(context, Obs, gzzzzzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzzv_);
        bool? hzzzzzzzzzzzzzzzzzc_ = context.Operators.Or(gzzzzzzzzzzzzzzzzzx_, hzzzzzzzzzzzzzzzzzb_);
        CqlCode hzzzzzzzzzzzzzzzzzd_ = this.Cardiac_High_Dose_or_Chest_High_Dose(context);
        decimal? hzzzzzzzzzzzzzzzzzf_ = context.Operators.ConvertIntegerToDecimal(1282);
        bool? hzzzzzzzzzzzzzzzzzg_ = this.Qualifies(context, Obs, hzzzzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzzzzzz_, hzzzzzzzzzzzzzzzzzf_);
        bool? hzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzzzzzg_);
        CqlCode hzzzzzzzzzzzzzzzzzi_ = this.Head_Low_Dose(context);
        decimal? hzzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertIntegerToDecimal(115);
        decimal? hzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertIntegerToDecimal(582);
        bool? hzzzzzzzzzzzzzzzzzl_ = this.Qualifies(context, Obs, hzzzzzzzzzzzzzzzzzi_, hzzzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzzzk_);
        bool? hzzzzzzzzzzzzzzzzzm_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzl_);
        CqlCode hzzzzzzzzzzzzzzzzzn_ = this.Head_Routine_Dose(context);
        decimal? hzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertIntegerToDecimal(1025);
        bool? hzzzzzzzzzzzzzzzzzq_ = this.Qualifies(context, Obs, hzzzzzzzzzzzzzzzzzn_, hzzzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzzzp_);
        bool? hzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzq_);
        CqlCode hzzzzzzzzzzzzzzzzzs_ = this.Head_High_Dose(context);
        decimal? hzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertIntegerToDecimal(1832);
        bool? hzzzzzzzzzzzzzzzzzv_ = this.Qualifies(context, Obs, hzzzzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzzzu_);
        bool? hzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzzzv_);
        CqlCode hzzzzzzzzzzzzzzzzzx_ = this.Extremity(context);
        decimal? hzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertIntegerToDecimal(73);
        decimal? hzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertIntegerToDecimal(320);
        bool? izzzzzzzzzzzzzzzzza_ = this.Qualifies(context, Obs, hzzzzzzzzzzzzzzzzzx_, hzzzzzzzzzzzzzzzzzy_, hzzzzzzzzzzzzzzzzzz_);
        bool? izzzzzzzzzzzzzzzzzb_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzza_);
        CqlCode izzzzzzzzzzzzzzzzzc_ = this.Neck_or_Cervical_Spine(context);
        decimal? izzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertIntegerToDecimal(25);
        bool? izzzzzzzzzzzzzzzzzf_ = this.Qualifies(context, Obs, izzzzzzzzzzzzzzzzzc_, izzzzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzzzzzg_);
        bool? izzzzzzzzzzzzzzzzzg_ = context.Operators.Or(izzzzzzzzzzzzzzzzzb_, izzzzzzzzzzzzzzzzzf_);
        CqlCode izzzzzzzzzzzzzzzzzh_ = this.Thoracic_or_Lumbar_Spine(context);
        bool? izzzzzzzzzzzzzzzzzk_ = this.Qualifies(context, Obs, izzzzzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzzzzzg_);
        bool? izzzzzzzzzzzzzzzzzl_ = context.Operators.Or(izzzzzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzzzzk_);
        CqlCode izzzzzzzzzzzzzzzzzm_ = this.Simultaneous_Chest_and_Abdomen_and_Pelvis(context);
        decimal? izzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertIntegerToDecimal(1637);
        bool? izzzzzzzzzzzzzzzzzp_ = this.Qualifies(context, Obs, izzzzzzzzzzzzzzzzzm_, gzzzzzzzzzzzzzzzzza_, izzzzzzzzzzzzzzzzzo_);
        bool? izzzzzzzzzzzzzzzzzq_ = context.Operators.Or(izzzzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzzzp_);
        CqlCode izzzzzzzzzzzzzzzzzr_ = this.Simultaneous_Thoracic_and_Lumbar_Spine(context);
        decimal? izzzzzzzzzzzzzzzzzt_ = context.Operators.ConvertIntegerToDecimal(2520);
        bool? izzzzzzzzzzzzzzzzzu_ = this.Qualifies(context, Obs, izzzzzzzzzzzzzzzzzr_, izzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzzt_);
        bool? izzzzzzzzzzzzzzzzzv_ = context.Operators.Or(izzzzzzzzzzzzzzzzzq_, izzzzzzzzzzzzzzzzzu_);
        CqlCode izzzzzzzzzzzzzzzzzw_ = this.Simultaneous_Head_and_Neck_Routine_Dose(context);
        decimal? izzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertIntegerToDecimal(2285);
        bool? izzzzzzzzzzzzzzzzzz_ = this.Qualifies(context, Obs, izzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzzy_);
        bool? jzzzzzzzzzzzzzzzzza_ = context.Operators.Or(izzzzzzzzzzzzzzzzzv_, izzzzzzzzzzzzzzzzzz_);
        CqlCode jzzzzzzzzzzzzzzzzzb_ = this.Simultaneous_Head_and_Neck_High_Dose(context);
        decimal? jzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertIntegerToDecimal(3092);
        bool? jzzzzzzzzzzzzzzzzze_ = this.Qualifies(context, Obs, jzzzzzzzzzzzzzzzzzb_, izzzzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzzzzzd_);
        bool? jzzzzzzzzzzzzzzzzzf_ = context.Operators.Or(jzzzzzzzzzzzzzzzzza_, jzzzzzzzzzzzzzzzzze_);

        return jzzzzzzzzzzzzzzzzzf_;
    }


    #endregion Expressions

}
