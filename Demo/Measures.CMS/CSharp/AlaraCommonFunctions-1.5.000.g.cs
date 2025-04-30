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
    private static readonly CqlCode _Abdomen_and_Pelvis_High_Dose = new CqlCode("LA31754-7", "http://loinc.org");

    [CqlCodeDefinition("Abdomen and Pelvis Low Dose", codeId: "LA31752-1", codeSystem: "http://loinc.org")]
    public CqlCode Abdomen_and_Pelvis_Low_Dose(CqlContext _) => _Abdomen_and_Pelvis_Low_Dose;
    private static readonly CqlCode _Abdomen_and_Pelvis_Low_Dose = new CqlCode("LA31752-1", "http://loinc.org");

    [CqlCodeDefinition("Abdomen and Pelvis Routine Dose", codeId: "LA31753-9", codeSystem: "http://loinc.org")]
    public CqlCode Abdomen_and_Pelvis_Routine_Dose(CqlContext _) => _Abdomen_and_Pelvis_Routine_Dose;
    private static readonly CqlCode _Abdomen_and_Pelvis_Routine_Dose = new CqlCode("LA31753-9", "http://loinc.org");

    [CqlCodeDefinition("Calculated CT global noise", codeId: "96912-1", codeSystem: "http://loinc.org")]
    public CqlCode Calculated_CT_global_noise(CqlContext _) => _Calculated_CT_global_noise;
    private static readonly CqlCode _Calculated_CT_global_noise = new CqlCode("96912-1", "http://loinc.org");

    [CqlCodeDefinition("Calculated CT size-adjusted dose", codeId: "96913-9", codeSystem: "http://loinc.org")]
    public CqlCode Calculated_CT_size_adjusted_dose(CqlContext _) => _Calculated_CT_size_adjusted_dose;
    private static readonly CqlCode _Calculated_CT_size_adjusted_dose = new CqlCode("96913-9", "http://loinc.org");

    [CqlCodeDefinition("Cardiac High Dose or Chest High Dose", codeId: "LA31761-2", codeSystem: "http://loinc.org")]
    public CqlCode Cardiac_High_Dose_or_Chest_High_Dose(CqlContext _) => _Cardiac_High_Dose_or_Chest_High_Dose;
    private static readonly CqlCode _Cardiac_High_Dose_or_Chest_High_Dose = new CqlCode("LA31761-2", "http://loinc.org");

    [CqlCodeDefinition("Cardiac Low Dose", codeId: "LA31755-4", codeSystem: "http://loinc.org")]
    public CqlCode Cardiac_Low_Dose(CqlContext _) => _Cardiac_Low_Dose;
    private static readonly CqlCode _Cardiac_Low_Dose = new CqlCode("LA31755-4", "http://loinc.org");

    [CqlCodeDefinition("Cardiac Routine Dose", codeId: "LA31756-2", codeSystem: "http://loinc.org")]
    public CqlCode Cardiac_Routine_Dose(CqlContext _) => _Cardiac_Routine_Dose;
    private static readonly CqlCode _Cardiac_Routine_Dose = new CqlCode("LA31756-2", "http://loinc.org");

    [CqlCodeDefinition("Chest Low Dose", codeId: "LA31758-8", codeSystem: "http://loinc.org")]
    public CqlCode Chest_Low_Dose(CqlContext _) => _Chest_Low_Dose;
    private static readonly CqlCode _Chest_Low_Dose = new CqlCode("LA31758-8", "http://loinc.org");

    [CqlCodeDefinition("Chest Routine Dose", codeId: "LA31759-6", codeSystem: "http://loinc.org")]
    public CqlCode Chest_Routine_Dose(CqlContext _) => _Chest_Routine_Dose;
    private static readonly CqlCode _Chest_Routine_Dose = new CqlCode("LA31759-6", "http://loinc.org");

    [CqlCodeDefinition("Extremity", codeId: "LA31765-3", codeSystem: "http://loinc.org")]
    public CqlCode Extremity(CqlContext _) => _Extremity;
    private static readonly CqlCode _Extremity = new CqlCode("LA31765-3", "http://loinc.org");

    [CqlCodeDefinition("Head High Dose", codeId: "LA31764-6", codeSystem: "http://loinc.org")]
    public CqlCode Head_High_Dose(CqlContext _) => _Head_High_Dose;
    private static readonly CqlCode _Head_High_Dose = new CqlCode("LA31764-6", "http://loinc.org");

    [CqlCodeDefinition("Head Low Dose", codeId: "LA31762-0", codeSystem: "http://loinc.org")]
    public CqlCode Head_Low_Dose(CqlContext _) => _Head_Low_Dose;
    private static readonly CqlCode _Head_Low_Dose = new CqlCode("LA31762-0", "http://loinc.org");

    [CqlCodeDefinition("Head Routine Dose", codeId: "LA31763-8", codeSystem: "http://loinc.org")]
    public CqlCode Head_Routine_Dose(CqlContext _) => _Head_Routine_Dose;
    private static readonly CqlCode _Head_Routine_Dose = new CqlCode("LA31763-8", "http://loinc.org");

    [CqlCodeDefinition("Neck or Cervical Spine", codeId: "LA31766-1", codeSystem: "http://loinc.org")]
    public CqlCode Neck_or_Cervical_Spine(CqlContext _) => _Neck_or_Cervical_Spine;
    private static readonly CqlCode _Neck_or_Cervical_Spine = new CqlCode("LA31766-1", "http://loinc.org");

    [CqlCodeDefinition("Simultaneous Chest and Abdomen and Pelvis", codeId: "LA31768-7", codeSystem: "http://loinc.org")]
    public CqlCode Simultaneous_Chest_and_Abdomen_and_Pelvis(CqlContext _) => _Simultaneous_Chest_and_Abdomen_and_Pelvis;
    private static readonly CqlCode _Simultaneous_Chest_and_Abdomen_and_Pelvis = new CqlCode("LA31768-7", "http://loinc.org");

    [CqlCodeDefinition("Simultaneous Head and Neck High Dose", codeId: "LA31770-3", codeSystem: "http://loinc.org")]
    public CqlCode Simultaneous_Head_and_Neck_High_Dose(CqlContext _) => _Simultaneous_Head_and_Neck_High_Dose;
    private static readonly CqlCode _Simultaneous_Head_and_Neck_High_Dose = new CqlCode("LA31770-3", "http://loinc.org");

    [CqlCodeDefinition("Simultaneous Head and Neck Routine Dose", codeId: "LA31769-5", codeSystem: "http://loinc.org")]
    public CqlCode Simultaneous_Head_and_Neck_Routine_Dose(CqlContext _) => _Simultaneous_Head_and_Neck_Routine_Dose;
    private static readonly CqlCode _Simultaneous_Head_and_Neck_Routine_Dose = new CqlCode("LA31769-5", "http://loinc.org");

    [CqlCodeDefinition("Simultaneous Thoracic and Lumbar Spine", codeId: "LA31851-1", codeSystem: "http://loinc.org")]
    public CqlCode Simultaneous_Thoracic_and_Lumbar_Spine(CqlContext _) => _Simultaneous_Thoracic_and_Lumbar_Spine;
    private static readonly CqlCode _Simultaneous_Thoracic_and_Lumbar_Spine = new CqlCode("LA31851-1", "http://loinc.org");

    [CqlCodeDefinition("Thoracic or Lumbar Spine", codeId: "LA31767-9", codeSystem: "http://loinc.org")]
    public CqlCode Thoracic_or_Lumbar_Spine(CqlContext _) => _Thoracic_or_Lumbar_Spine;
    private static readonly CqlCode _Thoracic_or_Lumbar_Spine = new CqlCode("LA31767-9", "http://loinc.org");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null,
          _Abdomen_and_Pelvis_High_Dose,
          _Abdomen_and_Pelvis_Low_Dose,
          _Abdomen_and_Pelvis_Routine_Dose,
          _Calculated_CT_global_noise,
          _Calculated_CT_size_adjusted_dose,
          _Cardiac_High_Dose_or_Chest_High_Dose,
          _Cardiac_Low_Dose,
          _Cardiac_Routine_Dose,
          _Chest_Low_Dose,
          _Chest_Routine_Dose,
          _Extremity,
          _Head_High_Dose,
          _Head_Low_Dose,
          _Head_Routine_Dose,
          _Neck_or_Cervical_Spine,
          _Simultaneous_Chest_and_Abdomen_and_Pelvis,
          _Simultaneous_Head_and_Neck_High_Dose,
          _Simultaneous_Head_and_Neck_Routine_Dose,
          _Simultaneous_Thoracic_and_Lumbar_Spine,
          _Thoracic_or_Lumbar_Spine);

    #endregion CodeSystems

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> xzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient xzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SingletonFrom<Patient>(xzzzzzzzzzzzzzzzzzzzg_);

        return xzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Global Noise Value")]
    public decimal? Global_Noise_Value(CqlContext context, Observation Obs)
    {
        List<Observation.ComponentComponent> xzzzzzzzzzzzzzzzzzzzi_ = Obs?.Component;
        bool? xzzzzzzzzzzzzzzzzzzzj_(Observation.ComponentComponent C)
        {
            CodeableConcept xzzzzzzzzzzzzzzzzzzzp_ = C?.Code;
            CqlConcept xzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, xzzzzzzzzzzzzzzzzzzzp_);
            CqlCode xzzzzzzzzzzzzzzzzzzzr_ = this.Calculated_CT_global_noise(context);
            CqlConcept xzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertCodeToConcept(xzzzzzzzzzzzzzzzzzzzr_);
            bool? xzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Equivalent(xzzzzzzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzzzzzzs_);
            DataType xzzzzzzzzzzzzzzzzzzzu_ = C?.Value;
            object xzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzu_);
            string xzzzzzzzzzzzzzzzzzzzw_ = (xzzzzzzzzzzzzzzzzzzzv_ as CqlQuantity)?.unit;
            bool? xzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Equal(xzzzzzzzzzzzzzzzzzzzw_, "[hnsf'U]");
            bool? xzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzzzzzzx_);

            return xzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Observation.ComponentComponent> xzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)xzzzzzzzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzzzzzzzj_);
        decimal? xzzzzzzzzzzzzzzzzzzzl_(Observation.ComponentComponent C)
        {
            DataType xzzzzzzzzzzzzzzzzzzzz_ = C?.Value;
            object yzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzz_);
            decimal? yzzzzzzzzzzzzzzzzzzzb_ = (yzzzzzzzzzzzzzzzzzzza_ as CqlQuantity)?.value;

            return yzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<decimal?> xzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<Observation.ComponentComponent, decimal?>(xzzzzzzzzzzzzzzzzzzzk_, xzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<decimal?> xzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Distinct<decimal?>(xzzzzzzzzzzzzzzzzzzzm_);
        decimal? xzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SingletonFrom<decimal?>(xzzzzzzzzzzzzzzzzzzzn_);

        return xzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Size Adjusted Value")]
    public decimal? Size_Adjusted_Value(CqlContext context, Observation Obs)
    {
        List<Observation.ComponentComponent> yzzzzzzzzzzzzzzzzzzzc_ = Obs?.Component;
        bool? yzzzzzzzzzzzzzzzzzzzd_(Observation.ComponentComponent C)
        {
            CodeableConcept yzzzzzzzzzzzzzzzzzzzj_ = C?.Code;
            CqlConcept yzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzzzzzzzzzzj_);
            CqlCode yzzzzzzzzzzzzzzzzzzzl_ = this.Calculated_CT_size_adjusted_dose(context);
            CqlConcept yzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConvertCodeToConcept(yzzzzzzzzzzzzzzzzzzzl_);
            bool? yzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Equivalent(yzzzzzzzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzzzzzzzm_);
            DataType yzzzzzzzzzzzzzzzzzzzo_ = C?.Value;
            object yzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzo_);
            string yzzzzzzzzzzzzzzzzzzzq_ = (yzzzzzzzzzzzzzzzzzzzp_ as CqlQuantity)?.unit;
            bool? yzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Equal(yzzzzzzzzzzzzzzzzzzzq_, "mGy.cm");
            bool? yzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzzzzzzr_);

            return yzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Observation.ComponentComponent> yzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)yzzzzzzzzzzzzzzzzzzzc_, yzzzzzzzzzzzzzzzzzzzd_);
        decimal? yzzzzzzzzzzzzzzzzzzzf_(Observation.ComponentComponent C)
        {
            DataType yzzzzzzzzzzzzzzzzzzzt_ = C?.Value;
            object yzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzt_);
            decimal? yzzzzzzzzzzzzzzzzzzzv_ = (yzzzzzzzzzzzzzzzzzzzu_ as CqlQuantity)?.value;

            return yzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<decimal?> yzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Observation.ComponentComponent, decimal?>(yzzzzzzzzzzzzzzzzzzze_, yzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<decimal?> yzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Distinct<decimal?>(yzzzzzzzzzzzzzzzzzzzg_);
        decimal? yzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SingletonFrom<decimal?>(yzzzzzzzzzzzzzzzzzzzh_);

        return yzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Qualifies")]
    public bool? Qualifies(CqlContext context, Observation Obs, CqlCode code, decimal? noiseThreshold, decimal? sizeDoseThreshold)
    {
        DataType yzzzzzzzzzzzzzzzzzzzw_ = Obs?.Value;
        object yzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzw_);
        CqlCode[] yzzzzzzzzzzzzzzzzzzzy_ = (yzzzzzzzzzzzzzzzzzzzx_ as CqlConcept)?.codes;
        bool? yzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)yzzzzzzzzzzzzzzzzzzzy_, code);
        decimal? zzzzzzzzzzzzzzzzzzzza_ = this.Global_Noise_Value(context, Obs);
        bool? zzzzzzzzzzzzzzzzzzzzb_ = context.Operators.GreaterOrEqual(zzzzzzzzzzzzzzzzzzzza_, noiseThreshold);
        decimal? zzzzzzzzzzzzzzzzzzzzc_ = this.Size_Adjusted_Value(context, Obs);
        bool? zzzzzzzzzzzzzzzzzzzzd_ = context.Operators.GreaterOrEqual(zzzzzzzzzzzzzzzzzzzzc_, sizeDoseThreshold);
        bool? zzzzzzzzzzzzzzzzzzzze_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzb_, zzzzzzzzzzzzzzzzzzzzd_);
        bool? zzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzzzzzze_);

        return zzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("CT Scan Qualifies")]
    public bool? CT_Scan_Qualifies(CqlContext context, Observation Obs)
    {
        CqlCode zzzzzzzzzzzzzzzzzzzzg_ = this.Abdomen_and_Pelvis_Low_Dose(context);
        decimal? zzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertIntegerToDecimal(64);
        decimal? zzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConvertIntegerToDecimal(598);
        bool? zzzzzzzzzzzzzzzzzzzzj_ = this.Qualifies(context, Obs, zzzzzzzzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzzzzzzzi_);
        CqlCode zzzzzzzzzzzzzzzzzzzzk_ = this.Abdomen_and_Pelvis_Routine_Dose(context);
        decimal? zzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConvertIntegerToDecimal(29);
        decimal? zzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConvertIntegerToDecimal(644);
        bool? zzzzzzzzzzzzzzzzzzzzn_ = this.Qualifies(context, Obs, zzzzzzzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzzzzzzl_, zzzzzzzzzzzzzzzzzzzzm_);
        bool? zzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzj_, zzzzzzzzzzzzzzzzzzzzn_);
        CqlCode zzzzzzzzzzzzzzzzzzzzp_ = this.Abdomen_and_Pelvis_High_Dose(context);
        decimal? zzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConvertIntegerToDecimal(1260);
        bool? zzzzzzzzzzzzzzzzzzzzs_ = this.Qualifies(context, Obs, zzzzzzzzzzzzzzzzzzzzp_, zzzzzzzzzzzzzzzzzzzzl_, zzzzzzzzzzzzzzzzzzzzr_);
        bool? zzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzzzzzzzs_);
        CqlCode zzzzzzzzzzzzzzzzzzzzu_ = this.Cardiac_Low_Dose(context);
        decimal? zzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertIntegerToDecimal(55);
        decimal? zzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConvertIntegerToDecimal(93);
        bool? zzzzzzzzzzzzzzzzzzzzx_ = this.Qualifies(context, Obs, zzzzzzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzzzzzzzw_);
        bool? zzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzt_, zzzzzzzzzzzzzzzzzzzzx_);
        CqlCode zzzzzzzzzzzzzzzzzzzzz_ = this.Cardiac_Routine_Dose(context);
        decimal? azzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertIntegerToDecimal(32);
        decimal? azzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConvertIntegerToDecimal(576);
        bool? azzzzzzzzzzzzzzzzzzzzc_ = this.Qualifies(context, Obs, zzzzzzzzzzzzzzzzzzzzz_, azzzzzzzzzzzzzzzzzzzza_, azzzzzzzzzzzzzzzzzzzzb_);
        bool? azzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzy_, azzzzzzzzzzzzzzzzzzzzc_);
        CqlCode azzzzzzzzzzzzzzzzzzzze_ = this.Chest_Low_Dose(context);
        decimal? azzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertIntegerToDecimal(377);
        bool? azzzzzzzzzzzzzzzzzzzzh_ = this.Qualifies(context, Obs, azzzzzzzzzzzzzzzzzzzze_, zzzzzzzzzzzzzzzzzzzzv_, azzzzzzzzzzzzzzzzzzzzg_);
        bool? azzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Or(azzzzzzzzzzzzzzzzzzzzd_, azzzzzzzzzzzzzzzzzzzzh_);
        CqlCode azzzzzzzzzzzzzzzzzzzzj_ = this.Chest_Routine_Dose(context);
        decimal? azzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertIntegerToDecimal(49);
        bool? azzzzzzzzzzzzzzzzzzzzm_ = this.Qualifies(context, Obs, azzzzzzzzzzzzzzzzzzzzj_, azzzzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzzzg_);
        bool? azzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(azzzzzzzzzzzzzzzzzzzzi_, azzzzzzzzzzzzzzzzzzzzm_);
        CqlCode azzzzzzzzzzzzzzzzzzzzo_ = this.Cardiac_High_Dose_or_Chest_High_Dose(context);
        decimal? azzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertIntegerToDecimal(1282);
        bool? azzzzzzzzzzzzzzzzzzzzr_ = this.Qualifies(context, Obs, azzzzzzzzzzzzzzzzzzzzo_, azzzzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzzzq_);
        bool? azzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Or(azzzzzzzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzzzzzzr_);
        CqlCode azzzzzzzzzzzzzzzzzzzzt_ = this.Head_Low_Dose(context);
        decimal? azzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertIntegerToDecimal(115);
        decimal? azzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertIntegerToDecimal(582);
        bool? azzzzzzzzzzzzzzzzzzzzw_ = this.Qualifies(context, Obs, azzzzzzzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzzzzv_);
        bool? azzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Or(azzzzzzzzzzzzzzzzzzzzs_, azzzzzzzzzzzzzzzzzzzzw_);
        CqlCode azzzzzzzzzzzzzzzzzzzzy_ = this.Head_Routine_Dose(context);
        decimal? bzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertIntegerToDecimal(1025);
        bool? bzzzzzzzzzzzzzzzzzzzzb_ = this.Qualifies(context, Obs, azzzzzzzzzzzzzzzzzzzzy_, azzzzzzzzzzzzzzzzzzzzu_, bzzzzzzzzzzzzzzzzzzzza_);
        bool? bzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Or(azzzzzzzzzzzzzzzzzzzzx_, bzzzzzzzzzzzzzzzzzzzzb_);
        CqlCode bzzzzzzzzzzzzzzzzzzzzd_ = this.Head_High_Dose(context);
        decimal? bzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConvertIntegerToDecimal(1832);
        bool? bzzzzzzzzzzzzzzzzzzzzg_ = this.Qualifies(context, Obs, bzzzzzzzzzzzzzzzzzzzzd_, azzzzzzzzzzzzzzzzzzzzu_, bzzzzzzzzzzzzzzzzzzzzf_);
        bool? bzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzzzzc_, bzzzzzzzzzzzzzzzzzzzzg_);
        CqlCode bzzzzzzzzzzzzzzzzzzzzi_ = this.Extremity(context);
        decimal? bzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertIntegerToDecimal(73);
        decimal? bzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertIntegerToDecimal(320);
        bool? bzzzzzzzzzzzzzzzzzzzzl_ = this.Qualifies(context, Obs, bzzzzzzzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzzzzzzzzk_);
        bool? bzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzzzzh_, bzzzzzzzzzzzzzzzzzzzzl_);
        CqlCode bzzzzzzzzzzzzzzzzzzzzn_ = this.Neck_or_Cervical_Spine(context);
        decimal? bzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertIntegerToDecimal(25);
        bool? bzzzzzzzzzzzzzzzzzzzzq_ = this.Qualifies(context, Obs, bzzzzzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzzzzzzzr_);
        bool? bzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzzzzzzzq_);
        CqlCode bzzzzzzzzzzzzzzzzzzzzs_ = this.Thoracic_or_Lumbar_Spine(context);
        bool? bzzzzzzzzzzzzzzzzzzzzv_ = this.Qualifies(context, Obs, bzzzzzzzzzzzzzzzzzzzzs_, bzzzzzzzzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzzzzzzzr_);
        bool? bzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzzzzzzzv_);
        CqlCode bzzzzzzzzzzzzzzzzzzzzx_ = this.Simultaneous_Chest_and_Abdomen_and_Pelvis(context);
        decimal? bzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertIntegerToDecimal(1637);
        bool? czzzzzzzzzzzzzzzzzzzza_ = this.Qualifies(context, Obs, bzzzzzzzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzzzzzzl_, bzzzzzzzzzzzzzzzzzzzzz_);
        bool? czzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzzzzza_);
        CqlCode czzzzzzzzzzzzzzzzzzzzc_ = this.Simultaneous_Thoracic_and_Lumbar_Spine(context);
        decimal? czzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertIntegerToDecimal(2520);
        bool? czzzzzzzzzzzzzzzzzzzzf_ = this.Qualifies(context, Obs, czzzzzzzzzzzzzzzzzzzzc_, bzzzzzzzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzzzzzze_);
        bool? czzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzzzzzzzf_);
        CqlCode czzzzzzzzzzzzzzzzzzzzh_ = this.Simultaneous_Head_and_Neck_Routine_Dose(context);
        decimal? czzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertIntegerToDecimal(2285);
        bool? czzzzzzzzzzzzzzzzzzzzk_ = this.Qualifies(context, Obs, czzzzzzzzzzzzzzzzzzzzh_, bzzzzzzzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzzzzzzj_);
        bool? czzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzg_, czzzzzzzzzzzzzzzzzzzzk_);
        CqlCode czzzzzzzzzzzzzzzzzzzzm_ = this.Simultaneous_Head_and_Neck_High_Dose(context);
        decimal? czzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertIntegerToDecimal(3092);
        bool? czzzzzzzzzzzzzzzzzzzzp_ = this.Qualifies(context, Obs, czzzzzzzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzzzzzzo_);
        bool? czzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzzzzzzzp_);

        return czzzzzzzzzzzzzzzzzzzzq_;
    }


    #endregion Expressions

}
