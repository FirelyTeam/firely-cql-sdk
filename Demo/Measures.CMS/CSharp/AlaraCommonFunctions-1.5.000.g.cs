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
        IEnumerable<Patient> uzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient uzzzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<Patient>(uzzzzzzzzzzzzzzu_);

        return uzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Global Noise Value")]
    public decimal? Global_Noise_Value(CqlContext context, Observation Obs)
    {
        List<Observation.ComponentComponent> uzzzzzzzzzzzzzzw_ = Obs?.Component;
        bool? uzzzzzzzzzzzzzzx_(Observation.ComponentComponent C)
        {
            CodeableConcept vzzzzzzzzzzzzzzd_ = C?.Code;
            CqlConcept vzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzzzzzzzzzzd_);
            CqlCode vzzzzzzzzzzzzzzf_ = this.Calculated_CT_global_noise(context);
            CqlConcept vzzzzzzzzzzzzzzg_ = context.Operators.ConvertCodeToConcept(vzzzzzzzzzzzzzzf_);
            bool? vzzzzzzzzzzzzzzh_ = context.Operators.Equivalent(vzzzzzzzzzzzzzze_, vzzzzzzzzzzzzzzg_);
            DataType vzzzzzzzzzzzzzzi_ = C?.Value;
            object vzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzi_);
            string vzzzzzzzzzzzzzzk_ = (vzzzzzzzzzzzzzzj_ as CqlQuantity)?.unit;
            bool? vzzzzzzzzzzzzzzl_ = context.Operators.Equal(vzzzzzzzzzzzzzzk_, "[hnsf'U]");
            bool? vzzzzzzzzzzzzzzm_ = context.Operators.And(vzzzzzzzzzzzzzzh_, vzzzzzzzzzzzzzzl_);

            return vzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Observation.ComponentComponent> uzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)uzzzzzzzzzzzzzzw_, uzzzzzzzzzzzzzzx_);
        decimal? uzzzzzzzzzzzzzzz_(Observation.ComponentComponent C)
        {
            DataType vzzzzzzzzzzzzzzn_ = C?.Value;
            object vzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzn_);
            decimal? vzzzzzzzzzzzzzzp_ = (vzzzzzzzzzzzzzzo_ as CqlQuantity)?.value;

            return vzzzzzzzzzzzzzzp_;
        };
        IEnumerable<decimal?> vzzzzzzzzzzzzzza_ = context.Operators.Select<Observation.ComponentComponent, decimal?>(uzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzz_);
        IEnumerable<decimal?> vzzzzzzzzzzzzzzb_ = context.Operators.Distinct<decimal?>(vzzzzzzzzzzzzzza_);
        decimal? vzzzzzzzzzzzzzzc_ = context.Operators.SingletonFrom<decimal?>(vzzzzzzzzzzzzzzb_);

        return vzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Size Adjusted Value")]
    public decimal? Size_Adjusted_Value(CqlContext context, Observation Obs)
    {
        List<Observation.ComponentComponent> vzzzzzzzzzzzzzzq_ = Obs?.Component;
        bool? vzzzzzzzzzzzzzzr_(Observation.ComponentComponent C)
        {
            CodeableConcept vzzzzzzzzzzzzzzx_ = C?.Code;
            CqlConcept vzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzzzzzzzzzzx_);
            CqlCode vzzzzzzzzzzzzzzz_ = this.Calculated_CT_size_adjusted_dose(context);
            CqlConcept wzzzzzzzzzzzzzza_ = context.Operators.ConvertCodeToConcept(vzzzzzzzzzzzzzzz_);
            bool? wzzzzzzzzzzzzzzb_ = context.Operators.Equivalent(vzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzza_);
            DataType wzzzzzzzzzzzzzzc_ = C?.Value;
            object wzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzc_);
            string wzzzzzzzzzzzzzze_ = (wzzzzzzzzzzzzzzd_ as CqlQuantity)?.unit;
            bool? wzzzzzzzzzzzzzzf_ = context.Operators.Equal(wzzzzzzzzzzzzzze_, "mGy.cm");
            bool? wzzzzzzzzzzzzzzg_ = context.Operators.And(wzzzzzzzzzzzzzzb_, wzzzzzzzzzzzzzzf_);

            return wzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Observation.ComponentComponent> vzzzzzzzzzzzzzzs_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)vzzzzzzzzzzzzzzq_, vzzzzzzzzzzzzzzr_);
        decimal? vzzzzzzzzzzzzzzt_(Observation.ComponentComponent C)
        {
            DataType wzzzzzzzzzzzzzzh_ = C?.Value;
            object wzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzh_);
            decimal? wzzzzzzzzzzzzzzj_ = (wzzzzzzzzzzzzzzi_ as CqlQuantity)?.value;

            return wzzzzzzzzzzzzzzj_;
        };
        IEnumerable<decimal?> vzzzzzzzzzzzzzzu_ = context.Operators.Select<Observation.ComponentComponent, decimal?>(vzzzzzzzzzzzzzzs_, vzzzzzzzzzzzzzzt_);
        IEnumerable<decimal?> vzzzzzzzzzzzzzzv_ = context.Operators.Distinct<decimal?>(vzzzzzzzzzzzzzzu_);
        decimal? vzzzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<decimal?>(vzzzzzzzzzzzzzzv_);

        return vzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Qualifies")]
    public bool? Qualifies(CqlContext context, Observation Obs, CqlCode code, decimal? noiseThreshold, decimal? sizeDoseThreshold)
    {
        DataType wzzzzzzzzzzzzzzk_ = Obs?.Value;
        object wzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzk_);
        CqlCode[] wzzzzzzzzzzzzzzm_ = (wzzzzzzzzzzzzzzl_ as CqlConcept)?.codes;
        bool? wzzzzzzzzzzzzzzn_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)wzzzzzzzzzzzzzzm_, code);
        decimal? wzzzzzzzzzzzzzzo_ = this.Global_Noise_Value(context, Obs);
        bool? wzzzzzzzzzzzzzzp_ = context.Operators.GreaterOrEqual(wzzzzzzzzzzzzzzo_, noiseThreshold);
        decimal? wzzzzzzzzzzzzzzq_ = this.Size_Adjusted_Value(context, Obs);
        bool? wzzzzzzzzzzzzzzr_ = context.Operators.GreaterOrEqual(wzzzzzzzzzzzzzzq_, sizeDoseThreshold);
        bool? wzzzzzzzzzzzzzzs_ = context.Operators.Or(wzzzzzzzzzzzzzzp_, wzzzzzzzzzzzzzzr_);
        bool? wzzzzzzzzzzzzzzt_ = context.Operators.And(wzzzzzzzzzzzzzzn_, wzzzzzzzzzzzzzzs_);

        return wzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("CT Scan Qualifies")]
    public bool? CT_Scan_Qualifies(CqlContext context, Observation Obs)
    {
        CqlCode wzzzzzzzzzzzzzzu_ = this.Abdomen_and_Pelvis_Low_Dose(context);
        decimal? wzzzzzzzzzzzzzzv_ = context.Operators.ConvertIntegerToDecimal(64);
        decimal? wzzzzzzzzzzzzzzw_ = context.Operators.ConvertIntegerToDecimal(598);
        bool? wzzzzzzzzzzzzzzx_ = this.Qualifies(context, Obs, wzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzv_, wzzzzzzzzzzzzzzw_);
        CqlCode wzzzzzzzzzzzzzzy_ = this.Abdomen_and_Pelvis_Routine_Dose(context);
        decimal? wzzzzzzzzzzzzzzz_ = context.Operators.ConvertIntegerToDecimal(29);
        decimal? xzzzzzzzzzzzzzza_ = context.Operators.ConvertIntegerToDecimal(644);
        bool? xzzzzzzzzzzzzzzb_ = this.Qualifies(context, Obs, wzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzz_, xzzzzzzzzzzzzzza_);
        bool? xzzzzzzzzzzzzzzc_ = context.Operators.Or(wzzzzzzzzzzzzzzx_, xzzzzzzzzzzzzzzb_);
        CqlCode xzzzzzzzzzzzzzzd_ = this.Abdomen_and_Pelvis_High_Dose(context);
        decimal? xzzzzzzzzzzzzzzf_ = context.Operators.ConvertIntegerToDecimal(1260);
        bool? xzzzzzzzzzzzzzzg_ = this.Qualifies(context, Obs, xzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzz_, xzzzzzzzzzzzzzzf_);
        bool? xzzzzzzzzzzzzzzh_ = context.Operators.Or(xzzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzzg_);
        CqlCode xzzzzzzzzzzzzzzi_ = this.Cardiac_Low_Dose(context);
        decimal? xzzzzzzzzzzzzzzj_ = context.Operators.ConvertIntegerToDecimal(55);
        decimal? xzzzzzzzzzzzzzzk_ = context.Operators.ConvertIntegerToDecimal(93);
        bool? xzzzzzzzzzzzzzzl_ = this.Qualifies(context, Obs, xzzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzzj_, xzzzzzzzzzzzzzzk_);
        bool? xzzzzzzzzzzzzzzm_ = context.Operators.Or(xzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzl_);
        CqlCode xzzzzzzzzzzzzzzn_ = this.Cardiac_Routine_Dose(context);
        decimal? xzzzzzzzzzzzzzzo_ = context.Operators.ConvertIntegerToDecimal(32);
        decimal? xzzzzzzzzzzzzzzp_ = context.Operators.ConvertIntegerToDecimal(576);
        bool? xzzzzzzzzzzzzzzq_ = this.Qualifies(context, Obs, xzzzzzzzzzzzzzzn_, xzzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzzp_);
        bool? xzzzzzzzzzzzzzzr_ = context.Operators.Or(xzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzq_);
        CqlCode xzzzzzzzzzzzzzzs_ = this.Chest_Low_Dose(context);
        decimal? xzzzzzzzzzzzzzzu_ = context.Operators.ConvertIntegerToDecimal(377);
        bool? xzzzzzzzzzzzzzzv_ = this.Qualifies(context, Obs, xzzzzzzzzzzzzzzs_, xzzzzzzzzzzzzzzj_, xzzzzzzzzzzzzzzu_);
        bool? xzzzzzzzzzzzzzzw_ = context.Operators.Or(xzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzv_);
        CqlCode xzzzzzzzzzzzzzzx_ = this.Chest_Routine_Dose(context);
        decimal? xzzzzzzzzzzzzzzy_ = context.Operators.ConvertIntegerToDecimal(49);
        bool? yzzzzzzzzzzzzzza_ = this.Qualifies(context, Obs, xzzzzzzzzzzzzzzx_, xzzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzzu_);
        bool? yzzzzzzzzzzzzzzb_ = context.Operators.Or(xzzzzzzzzzzzzzzw_, yzzzzzzzzzzzzzza_);
        CqlCode yzzzzzzzzzzzzzzc_ = this.Cardiac_High_Dose_or_Chest_High_Dose(context);
        decimal? yzzzzzzzzzzzzzze_ = context.Operators.ConvertIntegerToDecimal(1282);
        bool? yzzzzzzzzzzzzzzf_ = this.Qualifies(context, Obs, yzzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzzy_, yzzzzzzzzzzzzzze_);
        bool? yzzzzzzzzzzzzzzg_ = context.Operators.Or(yzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzf_);
        CqlCode yzzzzzzzzzzzzzzh_ = this.Head_Low_Dose(context);
        decimal? yzzzzzzzzzzzzzzi_ = context.Operators.ConvertIntegerToDecimal(115);
        decimal? yzzzzzzzzzzzzzzj_ = context.Operators.ConvertIntegerToDecimal(582);
        bool? yzzzzzzzzzzzzzzk_ = this.Qualifies(context, Obs, yzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzi_, yzzzzzzzzzzzzzzj_);
        bool? yzzzzzzzzzzzzzzl_ = context.Operators.Or(yzzzzzzzzzzzzzzg_, yzzzzzzzzzzzzzzk_);
        CqlCode yzzzzzzzzzzzzzzm_ = this.Head_Routine_Dose(context);
        decimal? yzzzzzzzzzzzzzzo_ = context.Operators.ConvertIntegerToDecimal(1025);
        bool? yzzzzzzzzzzzzzzp_ = this.Qualifies(context, Obs, yzzzzzzzzzzzzzzm_, yzzzzzzzzzzzzzzi_, yzzzzzzzzzzzzzzo_);
        bool? yzzzzzzzzzzzzzzq_ = context.Operators.Or(yzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzp_);
        CqlCode yzzzzzzzzzzzzzzr_ = this.Head_High_Dose(context);
        decimal? yzzzzzzzzzzzzzzt_ = context.Operators.ConvertIntegerToDecimal(1832);
        bool? yzzzzzzzzzzzzzzu_ = this.Qualifies(context, Obs, yzzzzzzzzzzzzzzr_, yzzzzzzzzzzzzzzi_, yzzzzzzzzzzzzzzt_);
        bool? yzzzzzzzzzzzzzzv_ = context.Operators.Or(yzzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzzu_);
        CqlCode yzzzzzzzzzzzzzzw_ = this.Extremity(context);
        decimal? yzzzzzzzzzzzzzzx_ = context.Operators.ConvertIntegerToDecimal(73);
        decimal? yzzzzzzzzzzzzzzy_ = context.Operators.ConvertIntegerToDecimal(320);
        bool? yzzzzzzzzzzzzzzz_ = this.Qualifies(context, Obs, yzzzzzzzzzzzzzzw_, yzzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzzy_);
        bool? zzzzzzzzzzzzzzza_ = context.Operators.Or(yzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzz_);
        CqlCode zzzzzzzzzzzzzzzb_ = this.Neck_or_Cervical_Spine(context);
        decimal? zzzzzzzzzzzzzzzc_ = context.Operators.ConvertIntegerToDecimal(25);
        bool? zzzzzzzzzzzzzzze_ = this.Qualifies(context, Obs, zzzzzzzzzzzzzzzb_, zzzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzzf_);
        bool? zzzzzzzzzzzzzzzf_ = context.Operators.Or(zzzzzzzzzzzzzzza_, zzzzzzzzzzzzzzze_);
        CqlCode zzzzzzzzzzzzzzzg_ = this.Thoracic_or_Lumbar_Spine(context);
        bool? zzzzzzzzzzzzzzzj_ = this.Qualifies(context, Obs, zzzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzzf_);
        bool? zzzzzzzzzzzzzzzk_ = context.Operators.Or(zzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzj_);
        CqlCode zzzzzzzzzzzzzzzl_ = this.Simultaneous_Chest_and_Abdomen_and_Pelvis(context);
        decimal? zzzzzzzzzzzzzzzn_ = context.Operators.ConvertIntegerToDecimal(1637);
        bool? zzzzzzzzzzzzzzzo_ = this.Qualifies(context, Obs, zzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzn_);
        bool? zzzzzzzzzzzzzzzp_ = context.Operators.Or(zzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzo_);
        CqlCode zzzzzzzzzzzzzzzq_ = this.Simultaneous_Thoracic_and_Lumbar_Spine(context);
        decimal? zzzzzzzzzzzzzzzs_ = context.Operators.ConvertIntegerToDecimal(2520);
        bool? zzzzzzzzzzzzzzzt_ = this.Qualifies(context, Obs, zzzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzzc_, zzzzzzzzzzzzzzzs_);
        bool? zzzzzzzzzzzzzzzu_ = context.Operators.Or(zzzzzzzzzzzzzzzp_, zzzzzzzzzzzzzzzt_);
        CqlCode zzzzzzzzzzzzzzzv_ = this.Simultaneous_Head_and_Neck_Routine_Dose(context);
        decimal? zzzzzzzzzzzzzzzx_ = context.Operators.ConvertIntegerToDecimal(2285);
        bool? zzzzzzzzzzzzzzzy_ = this.Qualifies(context, Obs, zzzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzzc_, zzzzzzzzzzzzzzzx_);
        bool? zzzzzzzzzzzzzzzz_ = context.Operators.Or(zzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzy_);
        CqlCode azzzzzzzzzzzzzzza_ = this.Simultaneous_Head_and_Neck_High_Dose(context);
        decimal? azzzzzzzzzzzzzzzc_ = context.Operators.ConvertIntegerToDecimal(3092);
        bool? azzzzzzzzzzzzzzzd_ = this.Qualifies(context, Obs, azzzzzzzzzzzzzzza_, zzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzc_);
        bool? azzzzzzzzzzzzzzze_ = context.Operators.Or(zzzzzzzzzzzzzzzz_, azzzzzzzzzzzzzzzd_);

        return azzzzzzzzzzzzzzze_;
    }


    #endregion Expressions

}
