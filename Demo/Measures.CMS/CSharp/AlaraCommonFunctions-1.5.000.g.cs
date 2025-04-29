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
        IEnumerable<Patient> jzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient jzzzzzzzzzzzzzzd_ = context.Operators.SingletonFrom<Patient>(jzzzzzzzzzzzzzzc_);

        return jzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Global Noise Value")]
    public decimal? Global_Noise_Value(CqlContext context, Observation Obs)
    {
        List<Observation.ComponentComponent> jzzzzzzzzzzzzzze_ = Obs?.Component;
        bool? jzzzzzzzzzzzzzzf_(Observation.ComponentComponent C)
        {
            CodeableConcept jzzzzzzzzzzzzzzl_ = C?.Code;
            CqlConcept jzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jzzzzzzzzzzzzzzl_);
            CqlCode jzzzzzzzzzzzzzzn_ = this.Calculated_CT_global_noise(context);
            CqlConcept jzzzzzzzzzzzzzzo_ = context.Operators.ConvertCodeToConcept(jzzzzzzzzzzzzzzn_);
            bool? jzzzzzzzzzzzzzzp_ = context.Operators.Equivalent(jzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzo_);
            DataType jzzzzzzzzzzzzzzq_ = C?.Value;
            object jzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzq_);
            string jzzzzzzzzzzzzzzs_ = (jzzzzzzzzzzzzzzr_ as CqlQuantity)?.unit;
            bool? jzzzzzzzzzzzzzzt_ = context.Operators.Equal(jzzzzzzzzzzzzzzs_, "[hnsf'U]");
            bool? jzzzzzzzzzzzzzzu_ = context.Operators.And(jzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzt_);

            return jzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Observation.ComponentComponent> jzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)jzzzzzzzzzzzzzze_, jzzzzzzzzzzzzzzf_);
        decimal? jzzzzzzzzzzzzzzh_(Observation.ComponentComponent C)
        {
            DataType jzzzzzzzzzzzzzzv_ = C?.Value;
            object jzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzv_);
            decimal? jzzzzzzzzzzzzzzx_ = (jzzzzzzzzzzzzzzw_ as CqlQuantity)?.value;

            return jzzzzzzzzzzzzzzx_;
        };
        IEnumerable<decimal?> jzzzzzzzzzzzzzzi_ = context.Operators.Select<Observation.ComponentComponent, decimal?>(jzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzh_);
        IEnumerable<decimal?> jzzzzzzzzzzzzzzj_ = context.Operators.Distinct<decimal?>(jzzzzzzzzzzzzzzi_);
        decimal? jzzzzzzzzzzzzzzk_ = context.Operators.SingletonFrom<decimal?>(jzzzzzzzzzzzzzzj_);

        return jzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Size Adjusted Value")]
    public decimal? Size_Adjusted_Value(CqlContext context, Observation Obs)
    {
        List<Observation.ComponentComponent> jzzzzzzzzzzzzzzy_ = Obs?.Component;
        bool? jzzzzzzzzzzzzzzz_(Observation.ComponentComponent C)
        {
            CodeableConcept kzzzzzzzzzzzzzzf_ = C?.Code;
            CqlConcept kzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzzzzzzzzzf_);
            CqlCode kzzzzzzzzzzzzzzh_ = this.Calculated_CT_size_adjusted_dose(context);
            CqlConcept kzzzzzzzzzzzzzzi_ = context.Operators.ConvertCodeToConcept(kzzzzzzzzzzzzzzh_);
            bool? kzzzzzzzzzzzzzzj_ = context.Operators.Equivalent(kzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzi_);
            DataType kzzzzzzzzzzzzzzk_ = C?.Value;
            object kzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzk_);
            string kzzzzzzzzzzzzzzm_ = (kzzzzzzzzzzzzzzl_ as CqlQuantity)?.unit;
            bool? kzzzzzzzzzzzzzzn_ = context.Operators.Equal(kzzzzzzzzzzzzzzm_, "mGy.cm");
            bool? kzzzzzzzzzzzzzzo_ = context.Operators.And(kzzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzzn_);

            return kzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Observation.ComponentComponent> kzzzzzzzzzzzzzza_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)jzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzz_);
        decimal? kzzzzzzzzzzzzzzb_(Observation.ComponentComponent C)
        {
            DataType kzzzzzzzzzzzzzzp_ = C?.Value;
            object kzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzp_);
            decimal? kzzzzzzzzzzzzzzr_ = (kzzzzzzzzzzzzzzq_ as CqlQuantity)?.value;

            return kzzzzzzzzzzzzzzr_;
        };
        IEnumerable<decimal?> kzzzzzzzzzzzzzzc_ = context.Operators.Select<Observation.ComponentComponent, decimal?>(kzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzb_);
        IEnumerable<decimal?> kzzzzzzzzzzzzzzd_ = context.Operators.Distinct<decimal?>(kzzzzzzzzzzzzzzc_);
        decimal? kzzzzzzzzzzzzzze_ = context.Operators.SingletonFrom<decimal?>(kzzzzzzzzzzzzzzd_);

        return kzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Qualifies")]
    public bool? Qualifies(CqlContext context, Observation Obs, CqlCode code, decimal? noiseThreshold, decimal? sizeDoseThreshold)
    {
        DataType kzzzzzzzzzzzzzzs_ = Obs?.Value;
        object kzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzs_);
        CqlCode[] kzzzzzzzzzzzzzzu_ = (kzzzzzzzzzzzzzzt_ as CqlConcept)?.codes;
        bool? kzzzzzzzzzzzzzzv_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)kzzzzzzzzzzzzzzu_, code);
        decimal? kzzzzzzzzzzzzzzw_ = this.Global_Noise_Value(context, Obs);
        bool? kzzzzzzzzzzzzzzx_ = context.Operators.GreaterOrEqual(kzzzzzzzzzzzzzzw_, noiseThreshold);
        decimal? kzzzzzzzzzzzzzzy_ = this.Size_Adjusted_Value(context, Obs);
        bool? kzzzzzzzzzzzzzzz_ = context.Operators.GreaterOrEqual(kzzzzzzzzzzzzzzy_, sizeDoseThreshold);
        bool? lzzzzzzzzzzzzzza_ = context.Operators.Or(kzzzzzzzzzzzzzzx_, kzzzzzzzzzzzzzzz_);
        bool? lzzzzzzzzzzzzzzb_ = context.Operators.And(kzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzza_);

        return lzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("CT Scan Qualifies")]
    public bool? CT_Scan_Qualifies(CqlContext context, Observation Obs)
    {
        CqlCode lzzzzzzzzzzzzzzc_ = this.Abdomen_and_Pelvis_Low_Dose(context);
        decimal? lzzzzzzzzzzzzzzd_ = context.Operators.ConvertIntegerToDecimal(64);
        decimal? lzzzzzzzzzzzzzze_ = context.Operators.ConvertIntegerToDecimal(598);
        bool? lzzzzzzzzzzzzzzf_ = this.Qualifies(context, Obs, lzzzzzzzzzzzzzzc_, lzzzzzzzzzzzzzzd_, lzzzzzzzzzzzzzze_);
        CqlCode lzzzzzzzzzzzzzzg_ = this.Abdomen_and_Pelvis_Routine_Dose(context);
        decimal? lzzzzzzzzzzzzzzh_ = context.Operators.ConvertIntegerToDecimal(29);
        decimal? lzzzzzzzzzzzzzzi_ = context.Operators.ConvertIntegerToDecimal(644);
        bool? lzzzzzzzzzzzzzzj_ = this.Qualifies(context, Obs, lzzzzzzzzzzzzzzg_, lzzzzzzzzzzzzzzh_, lzzzzzzzzzzzzzzi_);
        bool? lzzzzzzzzzzzzzzk_ = context.Operators.Or(lzzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzzj_);
        CqlCode lzzzzzzzzzzzzzzl_ = this.Abdomen_and_Pelvis_High_Dose(context);
        decimal? lzzzzzzzzzzzzzzn_ = context.Operators.ConvertIntegerToDecimal(1260);
        bool? lzzzzzzzzzzzzzzo_ = this.Qualifies(context, Obs, lzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzh_, lzzzzzzzzzzzzzzn_);
        bool? lzzzzzzzzzzzzzzp_ = context.Operators.Or(lzzzzzzzzzzzzzzk_, lzzzzzzzzzzzzzzo_);
        CqlCode lzzzzzzzzzzzzzzq_ = this.Cardiac_Low_Dose(context);
        decimal? lzzzzzzzzzzzzzzr_ = context.Operators.ConvertIntegerToDecimal(55);
        decimal? lzzzzzzzzzzzzzzs_ = context.Operators.ConvertIntegerToDecimal(93);
        bool? lzzzzzzzzzzzzzzt_ = this.Qualifies(context, Obs, lzzzzzzzzzzzzzzq_, lzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzs_);
        bool? lzzzzzzzzzzzzzzu_ = context.Operators.Or(lzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzt_);
        CqlCode lzzzzzzzzzzzzzzv_ = this.Cardiac_Routine_Dose(context);
        decimal? lzzzzzzzzzzzzzzw_ = context.Operators.ConvertIntegerToDecimal(32);
        decimal? lzzzzzzzzzzzzzzx_ = context.Operators.ConvertIntegerToDecimal(576);
        bool? lzzzzzzzzzzzzzzy_ = this.Qualifies(context, Obs, lzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzw_, lzzzzzzzzzzzzzzx_);
        bool? lzzzzzzzzzzzzzzz_ = context.Operators.Or(lzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzy_);
        CqlCode mzzzzzzzzzzzzzza_ = this.Chest_Low_Dose(context);
        decimal? mzzzzzzzzzzzzzzc_ = context.Operators.ConvertIntegerToDecimal(377);
        bool? mzzzzzzzzzzzzzzd_ = this.Qualifies(context, Obs, mzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzc_);
        bool? mzzzzzzzzzzzzzze_ = context.Operators.Or(lzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzzd_);
        CqlCode mzzzzzzzzzzzzzzf_ = this.Chest_Routine_Dose(context);
        decimal? mzzzzzzzzzzzzzzg_ = context.Operators.ConvertIntegerToDecimal(49);
        bool? mzzzzzzzzzzzzzzi_ = this.Qualifies(context, Obs, mzzzzzzzzzzzzzzf_, mzzzzzzzzzzzzzzg_, mzzzzzzzzzzzzzzc_);
        bool? mzzzzzzzzzzzzzzj_ = context.Operators.Or(mzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzi_);
        CqlCode mzzzzzzzzzzzzzzk_ = this.Cardiac_High_Dose_or_Chest_High_Dose(context);
        decimal? mzzzzzzzzzzzzzzm_ = context.Operators.ConvertIntegerToDecimal(1282);
        bool? mzzzzzzzzzzzzzzn_ = this.Qualifies(context, Obs, mzzzzzzzzzzzzzzk_, mzzzzzzzzzzzzzzg_, mzzzzzzzzzzzzzzm_);
        bool? mzzzzzzzzzzzzzzo_ = context.Operators.Or(mzzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzzn_);
        CqlCode mzzzzzzzzzzzzzzp_ = this.Head_Low_Dose(context);
        decimal? mzzzzzzzzzzzzzzq_ = context.Operators.ConvertIntegerToDecimal(115);
        decimal? mzzzzzzzzzzzzzzr_ = context.Operators.ConvertIntegerToDecimal(582);
        bool? mzzzzzzzzzzzzzzs_ = this.Qualifies(context, Obs, mzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzzr_);
        bool? mzzzzzzzzzzzzzzt_ = context.Operators.Or(mzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzs_);
        CqlCode mzzzzzzzzzzzzzzu_ = this.Head_Routine_Dose(context);
        decimal? mzzzzzzzzzzzzzzw_ = context.Operators.ConvertIntegerToDecimal(1025);
        bool? mzzzzzzzzzzzzzzx_ = this.Qualifies(context, Obs, mzzzzzzzzzzzzzzu_, mzzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzzw_);
        bool? mzzzzzzzzzzzzzzy_ = context.Operators.Or(mzzzzzzzzzzzzzzt_, mzzzzzzzzzzzzzzx_);
        CqlCode mzzzzzzzzzzzzzzz_ = this.Head_High_Dose(context);
        decimal? nzzzzzzzzzzzzzzb_ = context.Operators.ConvertIntegerToDecimal(1832);
        bool? nzzzzzzzzzzzzzzc_ = this.Qualifies(context, Obs, mzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzzq_, nzzzzzzzzzzzzzzb_);
        bool? nzzzzzzzzzzzzzzd_ = context.Operators.Or(mzzzzzzzzzzzzzzy_, nzzzzzzzzzzzzzzc_);
        CqlCode nzzzzzzzzzzzzzze_ = this.Extremity(context);
        decimal? nzzzzzzzzzzzzzzf_ = context.Operators.ConvertIntegerToDecimal(73);
        decimal? nzzzzzzzzzzzzzzg_ = context.Operators.ConvertIntegerToDecimal(320);
        bool? nzzzzzzzzzzzzzzh_ = this.Qualifies(context, Obs, nzzzzzzzzzzzzzze_, nzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzg_);
        bool? nzzzzzzzzzzzzzzi_ = context.Operators.Or(nzzzzzzzzzzzzzzd_, nzzzzzzzzzzzzzzh_);
        CqlCode nzzzzzzzzzzzzzzj_ = this.Neck_or_Cervical_Spine(context);
        decimal? nzzzzzzzzzzzzzzk_ = context.Operators.ConvertIntegerToDecimal(25);
        bool? nzzzzzzzzzzzzzzm_ = this.Qualifies(context, Obs, nzzzzzzzzzzzzzzj_, nzzzzzzzzzzzzzzk_, lzzzzzzzzzzzzzzn_);
        bool? nzzzzzzzzzzzzzzn_ = context.Operators.Or(nzzzzzzzzzzzzzzi_, nzzzzzzzzzzzzzzm_);
        CqlCode nzzzzzzzzzzzzzzo_ = this.Thoracic_or_Lumbar_Spine(context);
        bool? nzzzzzzzzzzzzzzr_ = this.Qualifies(context, Obs, nzzzzzzzzzzzzzzo_, nzzzzzzzzzzzzzzk_, lzzzzzzzzzzzzzzn_);
        bool? nzzzzzzzzzzzzzzs_ = context.Operators.Or(nzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzr_);
        CqlCode nzzzzzzzzzzzzzzt_ = this.Simultaneous_Chest_and_Abdomen_and_Pelvis(context);
        decimal? nzzzzzzzzzzzzzzv_ = context.Operators.ConvertIntegerToDecimal(1637);
        bool? nzzzzzzzzzzzzzzw_ = this.Qualifies(context, Obs, nzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzv_);
        bool? nzzzzzzzzzzzzzzx_ = context.Operators.Or(nzzzzzzzzzzzzzzs_, nzzzzzzzzzzzzzzw_);
        CqlCode nzzzzzzzzzzzzzzy_ = this.Simultaneous_Thoracic_and_Lumbar_Spine(context);
        decimal? ozzzzzzzzzzzzzza_ = context.Operators.ConvertIntegerToDecimal(2520);
        bool? ozzzzzzzzzzzzzzb_ = this.Qualifies(context, Obs, nzzzzzzzzzzzzzzy_, nzzzzzzzzzzzzzzk_, ozzzzzzzzzzzzzza_);
        bool? ozzzzzzzzzzzzzzc_ = context.Operators.Or(nzzzzzzzzzzzzzzx_, ozzzzzzzzzzzzzzb_);
        CqlCode ozzzzzzzzzzzzzzd_ = this.Simultaneous_Head_and_Neck_Routine_Dose(context);
        decimal? ozzzzzzzzzzzzzzf_ = context.Operators.ConvertIntegerToDecimal(2285);
        bool? ozzzzzzzzzzzzzzg_ = this.Qualifies(context, Obs, ozzzzzzzzzzzzzzd_, nzzzzzzzzzzzzzzk_, ozzzzzzzzzzzzzzf_);
        bool? ozzzzzzzzzzzzzzh_ = context.Operators.Or(ozzzzzzzzzzzzzzc_, ozzzzzzzzzzzzzzg_);
        CqlCode ozzzzzzzzzzzzzzi_ = this.Simultaneous_Head_and_Neck_High_Dose(context);
        decimal? ozzzzzzzzzzzzzzk_ = context.Operators.ConvertIntegerToDecimal(3092);
        bool? ozzzzzzzzzzzzzzl_ = this.Qualifies(context, Obs, ozzzzzzzzzzzzzzi_, nzzzzzzzzzzzzzzk_, ozzzzzzzzzzzzzzk_);
        bool? ozzzzzzzzzzzzzzm_ = context.Operators.Or(ozzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzl_);

        return ozzzzzzzzzzzzzzm_;
    }


    #endregion Expressions

}
