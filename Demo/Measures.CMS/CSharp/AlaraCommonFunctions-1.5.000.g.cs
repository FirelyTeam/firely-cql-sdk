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

    #region Code: Abdomen and Pelvis High Dose
    [CqlCodeDefinition(
        definitionName: "Abdomen and Pelvis High Dose",
        codeId: "LA31754-7",
        codeSystem: "http://loinc.org")]
    public CqlCode Abdomen_and_Pelvis_High_Dose(CqlContext context) => _Abdomen_and_Pelvis_High_Dose;

    private static readonly CqlCode _Abdomen_and_Pelvis_High_Dose = new CqlCode("LA31754-7", "http://loinc.org", default, default);
    #endregion

    #region Code: Abdomen and Pelvis Low Dose
    [CqlCodeDefinition(
        definitionName: "Abdomen and Pelvis Low Dose",
        codeId: "LA31752-1",
        codeSystem: "http://loinc.org")]
    public CqlCode Abdomen_and_Pelvis_Low_Dose(CqlContext context) => _Abdomen_and_Pelvis_Low_Dose;

    private static readonly CqlCode _Abdomen_and_Pelvis_Low_Dose = new CqlCode("LA31752-1", "http://loinc.org", default, default);
    #endregion

    #region Code: Abdomen and Pelvis Routine Dose
    [CqlCodeDefinition(
        definitionName: "Abdomen and Pelvis Routine Dose",
        codeId: "LA31753-9",
        codeSystem: "http://loinc.org")]
    public CqlCode Abdomen_and_Pelvis_Routine_Dose(CqlContext context) => _Abdomen_and_Pelvis_Routine_Dose;

    private static readonly CqlCode _Abdomen_and_Pelvis_Routine_Dose = new CqlCode("LA31753-9", "http://loinc.org", default, default);
    #endregion

    #region Code: Calculated CT global noise
    [CqlCodeDefinition(
        definitionName: "Calculated CT global noise",
        codeId: "96912-1",
        codeSystem: "http://loinc.org")]
    public CqlCode Calculated_CT_global_noise(CqlContext context) => _Calculated_CT_global_noise;

    private static readonly CqlCode _Calculated_CT_global_noise = new CqlCode("96912-1", "http://loinc.org", default, default);
    #endregion

    #region Code: Calculated CT size-adjusted dose
    [CqlCodeDefinition(
        definitionName: "Calculated CT size-adjusted dose",
        codeId: "96913-9",
        codeSystem: "http://loinc.org")]
    public CqlCode Calculated_CT_size_adjusted_dose(CqlContext context) => _Calculated_CT_size_adjusted_dose;

    private static readonly CqlCode _Calculated_CT_size_adjusted_dose = new CqlCode("96913-9", "http://loinc.org", default, default);
    #endregion

    #region Code: Cardiac High Dose or Chest High Dose
    [CqlCodeDefinition(
        definitionName: "Cardiac High Dose or Chest High Dose",
        codeId: "LA31761-2",
        codeSystem: "http://loinc.org")]
    public CqlCode Cardiac_High_Dose_or_Chest_High_Dose(CqlContext context) => _Cardiac_High_Dose_or_Chest_High_Dose;

    private static readonly CqlCode _Cardiac_High_Dose_or_Chest_High_Dose = new CqlCode("LA31761-2", "http://loinc.org", default, default);
    #endregion

    #region Code: Cardiac Low Dose
    [CqlCodeDefinition(
        definitionName: "Cardiac Low Dose",
        codeId: "LA31755-4",
        codeSystem: "http://loinc.org")]
    public CqlCode Cardiac_Low_Dose(CqlContext context) => _Cardiac_Low_Dose;

    private static readonly CqlCode _Cardiac_Low_Dose = new CqlCode("LA31755-4", "http://loinc.org", default, default);
    #endregion

    #region Code: Cardiac Routine Dose
    [CqlCodeDefinition(
        definitionName: "Cardiac Routine Dose",
        codeId: "LA31756-2",
        codeSystem: "http://loinc.org")]
    public CqlCode Cardiac_Routine_Dose(CqlContext context) => _Cardiac_Routine_Dose;

    private static readonly CqlCode _Cardiac_Routine_Dose = new CqlCode("LA31756-2", "http://loinc.org", default, default);
    #endregion

    #region Code: Chest Low Dose
    [CqlCodeDefinition(
        definitionName: "Chest Low Dose",
        codeId: "LA31758-8",
        codeSystem: "http://loinc.org")]
    public CqlCode Chest_Low_Dose(CqlContext context) => _Chest_Low_Dose;

    private static readonly CqlCode _Chest_Low_Dose = new CqlCode("LA31758-8", "http://loinc.org", default, default);
    #endregion

    #region Code: Chest Routine Dose
    [CqlCodeDefinition(
        definitionName: "Chest Routine Dose",
        codeId: "LA31759-6",
        codeSystem: "http://loinc.org")]
    public CqlCode Chest_Routine_Dose(CqlContext context) => _Chest_Routine_Dose;

    private static readonly CqlCode _Chest_Routine_Dose = new CqlCode("LA31759-6", "http://loinc.org", default, default);
    #endregion

    #region Code: Extremity
    [CqlCodeDefinition(
        definitionName: "Extremity",
        codeId: "LA31765-3",
        codeSystem: "http://loinc.org")]
    public CqlCode Extremity(CqlContext context) => _Extremity;

    private static readonly CqlCode _Extremity = new CqlCode("LA31765-3", "http://loinc.org", default, default);
    #endregion

    #region Code: Head High Dose
    [CqlCodeDefinition(
        definitionName: "Head High Dose",
        codeId: "LA31764-6",
        codeSystem: "http://loinc.org")]
    public CqlCode Head_High_Dose(CqlContext context) => _Head_High_Dose;

    private static readonly CqlCode _Head_High_Dose = new CqlCode("LA31764-6", "http://loinc.org", default, default);
    #endregion

    #region Code: Head Low Dose
    [CqlCodeDefinition(
        definitionName: "Head Low Dose",
        codeId: "LA31762-0",
        codeSystem: "http://loinc.org")]
    public CqlCode Head_Low_Dose(CqlContext context) => _Head_Low_Dose;

    private static readonly CqlCode _Head_Low_Dose = new CqlCode("LA31762-0", "http://loinc.org", default, default);
    #endregion

    #region Code: Head Routine Dose
    [CqlCodeDefinition(
        definitionName: "Head Routine Dose",
        codeId: "LA31763-8",
        codeSystem: "http://loinc.org")]
    public CqlCode Head_Routine_Dose(CqlContext context) => _Head_Routine_Dose;

    private static readonly CqlCode _Head_Routine_Dose = new CqlCode("LA31763-8", "http://loinc.org", default, default);
    #endregion

    #region Code: Neck or Cervical Spine
    [CqlCodeDefinition(
        definitionName: "Neck or Cervical Spine",
        codeId: "LA31766-1",
        codeSystem: "http://loinc.org")]
    public CqlCode Neck_or_Cervical_Spine(CqlContext context) => _Neck_or_Cervical_Spine;

    private static readonly CqlCode _Neck_or_Cervical_Spine = new CqlCode("LA31766-1", "http://loinc.org", default, default);
    #endregion

    #region Code: Simultaneous Chest and Abdomen and Pelvis
    [CqlCodeDefinition(
        definitionName: "Simultaneous Chest and Abdomen and Pelvis",
        codeId: "LA31768-7",
        codeSystem: "http://loinc.org")]
    public CqlCode Simultaneous_Chest_and_Abdomen_and_Pelvis(CqlContext context) => _Simultaneous_Chest_and_Abdomen_and_Pelvis;

    private static readonly CqlCode _Simultaneous_Chest_and_Abdomen_and_Pelvis = new CqlCode("LA31768-7", "http://loinc.org", default, default);
    #endregion

    #region Code: Simultaneous Head and Neck High Dose
    [CqlCodeDefinition(
        definitionName: "Simultaneous Head and Neck High Dose",
        codeId: "LA31770-3",
        codeSystem: "http://loinc.org")]
    public CqlCode Simultaneous_Head_and_Neck_High_Dose(CqlContext context) => _Simultaneous_Head_and_Neck_High_Dose;

    private static readonly CqlCode _Simultaneous_Head_and_Neck_High_Dose = new CqlCode("LA31770-3", "http://loinc.org", default, default);
    #endregion

    #region Code: Simultaneous Head and Neck Routine Dose
    [CqlCodeDefinition(
        definitionName: "Simultaneous Head and Neck Routine Dose",
        codeId: "LA31769-5",
        codeSystem: "http://loinc.org")]
    public CqlCode Simultaneous_Head_and_Neck_Routine_Dose(CqlContext context) => _Simultaneous_Head_and_Neck_Routine_Dose;

    private static readonly CqlCode _Simultaneous_Head_and_Neck_Routine_Dose = new CqlCode("LA31769-5", "http://loinc.org", default, default);
    #endregion

    #region Code: Simultaneous Thoracic and Lumbar Spine
    [CqlCodeDefinition(
        definitionName: "Simultaneous Thoracic and Lumbar Spine",
        codeId: "LA31851-1",
        codeSystem: "http://loinc.org")]
    public CqlCode Simultaneous_Thoracic_and_Lumbar_Spine(CqlContext context) => _Simultaneous_Thoracic_and_Lumbar_Spine;

    private static readonly CqlCode _Simultaneous_Thoracic_and_Lumbar_Spine = new CqlCode("LA31851-1", "http://loinc.org", default, default);
    #endregion

    #region Code: Thoracic or Lumbar Spine
    [CqlCodeDefinition(
        definitionName: "Thoracic or Lumbar Spine",
        codeId: "LA31767-9",
        codeSystem: "http://loinc.org")]
    public CqlCode Thoracic_or_Lumbar_Spine(CqlContext context) => _Thoracic_or_Lumbar_Spine;

    private static readonly CqlCode _Thoracic_or_Lumbar_Spine = new CqlCode("LA31767-9", "http://loinc.org", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] ozzzzzzzzzzzzh_ = [
            new CqlCode("LA31754-7", "http://loinc.org", default, default),
            new CqlCode("LA31752-1", "http://loinc.org", default, default),
            new CqlCode("LA31753-9", "http://loinc.org", default, default),
            new CqlCode("96912-1", "http://loinc.org", default, default),
            new CqlCode("96913-9", "http://loinc.org", default, default),
            new CqlCode("LA31761-2", "http://loinc.org", default, default),
            new CqlCode("LA31755-4", "http://loinc.org", default, default),
            new CqlCode("LA31756-2", "http://loinc.org", default, default),
            new CqlCode("LA31758-8", "http://loinc.org", default, default),
            new CqlCode("LA31759-6", "http://loinc.org", default, default),
            new CqlCode("LA31765-3", "http://loinc.org", default, default),
            new CqlCode("LA31764-6", "http://loinc.org", default, default),
            new CqlCode("LA31762-0", "http://loinc.org", default, default),
            new CqlCode("LA31763-8", "http://loinc.org", default, default),
            new CqlCode("LA31766-1", "http://loinc.org", default, default),
            new CqlCode("LA31768-7", "http://loinc.org", default, default),
            new CqlCode("LA31770-3", "http://loinc.org", default, default),
            new CqlCode("LA31769-5", "http://loinc.org", default, default),
            new CqlCode("LA31851-1", "http://loinc.org", default, default),
            new CqlCode("LA31767-9", "http://loinc.org", default, default),
        ];

        return ozzzzzzzzzzzzh_;
    }


    #endregion CodeSystems

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ozzzzzzzzzzzzi_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient ozzzzzzzzzzzzj_ = context.Operators.SingletonFrom<Patient>(ozzzzzzzzzzzzi_);

        return ozzzzzzzzzzzzj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public decimal? Global_Noise_Value(CqlContext context, Observation Obs)
    {
        List<Observation.ComponentComponent> ozzzzzzzzzzzzk_ = Obs?.Component;
        bool? ozzzzzzzzzzzzl_(Observation.ComponentComponent C)
        {
            CodeableConcept ozzzzzzzzzzzzr_ = C?.Code;
            CqlConcept ozzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ozzzzzzzzzzzzr_);
            CqlCode ozzzzzzzzzzzzt_ = this.Calculated_CT_global_noise(context);
            CqlConcept ozzzzzzzzzzzzu_ = context.Operators.ConvertCodeToConcept(ozzzzzzzzzzzzt_);
            bool? ozzzzzzzzzzzzv_ = context.Operators.Equivalent(ozzzzzzzzzzzzs_, ozzzzzzzzzzzzu_);
            DataType ozzzzzzzzzzzzw_ = C?.Value;
            object ozzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzw_);
            string ozzzzzzzzzzzzy_ = (ozzzzzzzzzzzzx_ as CqlQuantity)?.unit;
            bool? ozzzzzzzzzzzzz_ = context.Operators.Equal(ozzzzzzzzzzzzy_, "[hnsf'U]");
            bool? pzzzzzzzzzzzza_ = context.Operators.And(ozzzzzzzzzzzzv_, ozzzzzzzzzzzzz_);

            return pzzzzzzzzzzzza_;
        };
        IEnumerable<Observation.ComponentComponent> ozzzzzzzzzzzzm_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ozzzzzzzzzzzzk_, ozzzzzzzzzzzzl_);
        decimal? ozzzzzzzzzzzzn_(Observation.ComponentComponent C)
        {
            DataType pzzzzzzzzzzzzb_ = C?.Value;
            object pzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzb_);
            decimal? pzzzzzzzzzzzzd_ = (pzzzzzzzzzzzzc_ as CqlQuantity)?.value;

            return pzzzzzzzzzzzzd_;
        };
        IEnumerable<decimal?> ozzzzzzzzzzzzo_ = context.Operators.Select<Observation.ComponentComponent, decimal?>(ozzzzzzzzzzzzm_, ozzzzzzzzzzzzn_);
        IEnumerable<decimal?> ozzzzzzzzzzzzp_ = context.Operators.Distinct<decimal?>(ozzzzzzzzzzzzo_);
        decimal? ozzzzzzzzzzzzq_ = context.Operators.SingletonFrom<decimal?>(ozzzzzzzzzzzzp_);

        return ozzzzzzzzzzzzq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public decimal? Size_Adjusted_Value(CqlContext context, Observation Obs)
    {
        List<Observation.ComponentComponent> pzzzzzzzzzzzze_ = Obs?.Component;
        bool? pzzzzzzzzzzzzf_(Observation.ComponentComponent C)
        {
            CodeableConcept pzzzzzzzzzzzzl_ = C?.Code;
            CqlConcept pzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzzl_);
            CqlCode pzzzzzzzzzzzzn_ = this.Calculated_CT_size_adjusted_dose(context);
            CqlConcept pzzzzzzzzzzzzo_ = context.Operators.ConvertCodeToConcept(pzzzzzzzzzzzzn_);
            bool? pzzzzzzzzzzzzp_ = context.Operators.Equivalent(pzzzzzzzzzzzzm_, pzzzzzzzzzzzzo_);
            DataType pzzzzzzzzzzzzq_ = C?.Value;
            object pzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzq_);
            string pzzzzzzzzzzzzs_ = (pzzzzzzzzzzzzr_ as CqlQuantity)?.unit;
            bool? pzzzzzzzzzzzzt_ = context.Operators.Equal(pzzzzzzzzzzzzs_, "mGy.cm");
            bool? pzzzzzzzzzzzzu_ = context.Operators.And(pzzzzzzzzzzzzp_, pzzzzzzzzzzzzt_);

            return pzzzzzzzzzzzzu_;
        };
        IEnumerable<Observation.ComponentComponent> pzzzzzzzzzzzzg_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)pzzzzzzzzzzzze_, pzzzzzzzzzzzzf_);
        decimal? pzzzzzzzzzzzzh_(Observation.ComponentComponent C)
        {
            DataType pzzzzzzzzzzzzv_ = C?.Value;
            object pzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzv_);
            decimal? pzzzzzzzzzzzzx_ = (pzzzzzzzzzzzzw_ as CqlQuantity)?.value;

            return pzzzzzzzzzzzzx_;
        };
        IEnumerable<decimal?> pzzzzzzzzzzzzi_ = context.Operators.Select<Observation.ComponentComponent, decimal?>(pzzzzzzzzzzzzg_, pzzzzzzzzzzzzh_);
        IEnumerable<decimal?> pzzzzzzzzzzzzj_ = context.Operators.Distinct<decimal?>(pzzzzzzzzzzzzi_);
        decimal? pzzzzzzzzzzzzk_ = context.Operators.SingletonFrom<decimal?>(pzzzzzzzzzzzzj_);

        return pzzzzzzzzzzzzk_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public bool? Qualifies(CqlContext context, Observation Obs, CqlCode code, decimal? noiseThreshold, decimal? sizeDoseThreshold)
    {
        DataType pzzzzzzzzzzzzy_ = Obs?.Value;
        object pzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzy_);
        CqlCode[] qzzzzzzzzzzzza_ = (pzzzzzzzzzzzzz_ as CqlConcept)?.codes;
        bool? qzzzzzzzzzzzzb_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)qzzzzzzzzzzzza_, code);
        decimal? qzzzzzzzzzzzzc_ = this.Global_Noise_Value(context, Obs);
        bool? qzzzzzzzzzzzzd_ = context.Operators.GreaterOrEqual(qzzzzzzzzzzzzc_, noiseThreshold);
        decimal? qzzzzzzzzzzzze_ = this.Size_Adjusted_Value(context, Obs);
        bool? qzzzzzzzzzzzzf_ = context.Operators.GreaterOrEqual(qzzzzzzzzzzzze_, sizeDoseThreshold);
        bool? qzzzzzzzzzzzzg_ = context.Operators.Or(qzzzzzzzzzzzzd_, qzzzzzzzzzzzzf_);
        bool? qzzzzzzzzzzzzh_ = context.Operators.And(qzzzzzzzzzzzzb_, qzzzzzzzzzzzzg_);

        return qzzzzzzzzzzzzh_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public bool? CT_Scan_Qualifies(CqlContext context, Observation Obs)
    {
        CqlCode qzzzzzzzzzzzzi_ = this.Abdomen_and_Pelvis_Low_Dose(context);
        decimal? qzzzzzzzzzzzzj_ = context.Operators.ConvertIntegerToDecimal(64);
        decimal? qzzzzzzzzzzzzk_ = context.Operators.ConvertIntegerToDecimal(598);
        bool? qzzzzzzzzzzzzl_ = this.Qualifies(context, Obs, qzzzzzzzzzzzzi_, qzzzzzzzzzzzzj_, qzzzzzzzzzzzzk_);
        CqlCode qzzzzzzzzzzzzm_ = this.Abdomen_and_Pelvis_Routine_Dose(context);
        decimal? qzzzzzzzzzzzzn_ = context.Operators.ConvertIntegerToDecimal(29);
        decimal? qzzzzzzzzzzzzo_ = context.Operators.ConvertIntegerToDecimal(644);
        bool? qzzzzzzzzzzzzp_ = this.Qualifies(context, Obs, qzzzzzzzzzzzzm_, qzzzzzzzzzzzzn_, qzzzzzzzzzzzzo_);
        bool? qzzzzzzzzzzzzq_ = context.Operators.Or(qzzzzzzzzzzzzl_, qzzzzzzzzzzzzp_);
        CqlCode qzzzzzzzzzzzzr_ = this.Abdomen_and_Pelvis_High_Dose(context);
        decimal? qzzzzzzzzzzzzt_ = context.Operators.ConvertIntegerToDecimal(1260);
        bool? qzzzzzzzzzzzzu_ = this.Qualifies(context, Obs, qzzzzzzzzzzzzr_, qzzzzzzzzzzzzn_, qzzzzzzzzzzzzt_);
        bool? qzzzzzzzzzzzzv_ = context.Operators.Or(qzzzzzzzzzzzzq_, qzzzzzzzzzzzzu_);
        CqlCode qzzzzzzzzzzzzw_ = this.Cardiac_Low_Dose(context);
        decimal? qzzzzzzzzzzzzx_ = context.Operators.ConvertIntegerToDecimal(55);
        decimal? qzzzzzzzzzzzzy_ = context.Operators.ConvertIntegerToDecimal(93);
        bool? qzzzzzzzzzzzzz_ = this.Qualifies(context, Obs, qzzzzzzzzzzzzw_, qzzzzzzzzzzzzx_, qzzzzzzzzzzzzy_);
        bool? rzzzzzzzzzzzza_ = context.Operators.Or(qzzzzzzzzzzzzv_, qzzzzzzzzzzzzz_);
        CqlCode rzzzzzzzzzzzzb_ = this.Cardiac_Routine_Dose(context);
        decimal? rzzzzzzzzzzzzc_ = context.Operators.ConvertIntegerToDecimal(32);
        decimal? rzzzzzzzzzzzzd_ = context.Operators.ConvertIntegerToDecimal(576);
        bool? rzzzzzzzzzzzze_ = this.Qualifies(context, Obs, rzzzzzzzzzzzzb_, rzzzzzzzzzzzzc_, rzzzzzzzzzzzzd_);
        bool? rzzzzzzzzzzzzf_ = context.Operators.Or(rzzzzzzzzzzzza_, rzzzzzzzzzzzze_);
        CqlCode rzzzzzzzzzzzzg_ = this.Chest_Low_Dose(context);
        decimal? rzzzzzzzzzzzzi_ = context.Operators.ConvertIntegerToDecimal(377);
        bool? rzzzzzzzzzzzzj_ = this.Qualifies(context, Obs, rzzzzzzzzzzzzg_, qzzzzzzzzzzzzx_, rzzzzzzzzzzzzi_);
        bool? rzzzzzzzzzzzzk_ = context.Operators.Or(rzzzzzzzzzzzzf_, rzzzzzzzzzzzzj_);
        CqlCode rzzzzzzzzzzzzl_ = this.Chest_Routine_Dose(context);
        decimal? rzzzzzzzzzzzzm_ = context.Operators.ConvertIntegerToDecimal(49);
        bool? rzzzzzzzzzzzzo_ = this.Qualifies(context, Obs, rzzzzzzzzzzzzl_, rzzzzzzzzzzzzm_, rzzzzzzzzzzzzi_);
        bool? rzzzzzzzzzzzzp_ = context.Operators.Or(rzzzzzzzzzzzzk_, rzzzzzzzzzzzzo_);
        CqlCode rzzzzzzzzzzzzq_ = this.Cardiac_High_Dose_or_Chest_High_Dose(context);
        decimal? rzzzzzzzzzzzzs_ = context.Operators.ConvertIntegerToDecimal(1282);
        bool? rzzzzzzzzzzzzt_ = this.Qualifies(context, Obs, rzzzzzzzzzzzzq_, rzzzzzzzzzzzzm_, rzzzzzzzzzzzzs_);
        bool? rzzzzzzzzzzzzu_ = context.Operators.Or(rzzzzzzzzzzzzp_, rzzzzzzzzzzzzt_);
        CqlCode rzzzzzzzzzzzzv_ = this.Head_Low_Dose(context);
        decimal? rzzzzzzzzzzzzw_ = context.Operators.ConvertIntegerToDecimal(115);
        decimal? rzzzzzzzzzzzzx_ = context.Operators.ConvertIntegerToDecimal(582);
        bool? rzzzzzzzzzzzzy_ = this.Qualifies(context, Obs, rzzzzzzzzzzzzv_, rzzzzzzzzzzzzw_, rzzzzzzzzzzzzx_);
        bool? rzzzzzzzzzzzzz_ = context.Operators.Or(rzzzzzzzzzzzzu_, rzzzzzzzzzzzzy_);
        CqlCode szzzzzzzzzzzza_ = this.Head_Routine_Dose(context);
        decimal? szzzzzzzzzzzzc_ = context.Operators.ConvertIntegerToDecimal(1025);
        bool? szzzzzzzzzzzzd_ = this.Qualifies(context, Obs, szzzzzzzzzzzza_, rzzzzzzzzzzzzw_, szzzzzzzzzzzzc_);
        bool? szzzzzzzzzzzze_ = context.Operators.Or(rzzzzzzzzzzzzz_, szzzzzzzzzzzzd_);
        CqlCode szzzzzzzzzzzzf_ = this.Head_High_Dose(context);
        decimal? szzzzzzzzzzzzh_ = context.Operators.ConvertIntegerToDecimal(1832);
        bool? szzzzzzzzzzzzi_ = this.Qualifies(context, Obs, szzzzzzzzzzzzf_, rzzzzzzzzzzzzw_, szzzzzzzzzzzzh_);
        bool? szzzzzzzzzzzzj_ = context.Operators.Or(szzzzzzzzzzzze_, szzzzzzzzzzzzi_);
        CqlCode szzzzzzzzzzzzk_ = this.Extremity(context);
        decimal? szzzzzzzzzzzzl_ = context.Operators.ConvertIntegerToDecimal(73);
        decimal? szzzzzzzzzzzzm_ = context.Operators.ConvertIntegerToDecimal(320);
        bool? szzzzzzzzzzzzn_ = this.Qualifies(context, Obs, szzzzzzzzzzzzk_, szzzzzzzzzzzzl_, szzzzzzzzzzzzm_);
        bool? szzzzzzzzzzzzo_ = context.Operators.Or(szzzzzzzzzzzzj_, szzzzzzzzzzzzn_);
        CqlCode szzzzzzzzzzzzp_ = this.Neck_or_Cervical_Spine(context);
        decimal? szzzzzzzzzzzzq_ = context.Operators.ConvertIntegerToDecimal(25);
        bool? szzzzzzzzzzzzs_ = this.Qualifies(context, Obs, szzzzzzzzzzzzp_, szzzzzzzzzzzzq_, qzzzzzzzzzzzzt_);
        bool? szzzzzzzzzzzzt_ = context.Operators.Or(szzzzzzzzzzzzo_, szzzzzzzzzzzzs_);
        CqlCode szzzzzzzzzzzzu_ = this.Thoracic_or_Lumbar_Spine(context);
        bool? szzzzzzzzzzzzx_ = this.Qualifies(context, Obs, szzzzzzzzzzzzu_, szzzzzzzzzzzzq_, qzzzzzzzzzzzzt_);
        bool? szzzzzzzzzzzzy_ = context.Operators.Or(szzzzzzzzzzzzt_, szzzzzzzzzzzzx_);
        CqlCode szzzzzzzzzzzzz_ = this.Simultaneous_Chest_and_Abdomen_and_Pelvis(context);
        decimal? tzzzzzzzzzzzzb_ = context.Operators.ConvertIntegerToDecimal(1637);
        bool? tzzzzzzzzzzzzc_ = this.Qualifies(context, Obs, szzzzzzzzzzzzz_, qzzzzzzzzzzzzn_, tzzzzzzzzzzzzb_);
        bool? tzzzzzzzzzzzzd_ = context.Operators.Or(szzzzzzzzzzzzy_, tzzzzzzzzzzzzc_);
        CqlCode tzzzzzzzzzzzze_ = this.Simultaneous_Thoracic_and_Lumbar_Spine(context);
        decimal? tzzzzzzzzzzzzg_ = context.Operators.ConvertIntegerToDecimal(2520);
        bool? tzzzzzzzzzzzzh_ = this.Qualifies(context, Obs, tzzzzzzzzzzzze_, szzzzzzzzzzzzq_, tzzzzzzzzzzzzg_);
        bool? tzzzzzzzzzzzzi_ = context.Operators.Or(tzzzzzzzzzzzzd_, tzzzzzzzzzzzzh_);
        CqlCode tzzzzzzzzzzzzj_ = this.Simultaneous_Head_and_Neck_Routine_Dose(context);
        decimal? tzzzzzzzzzzzzl_ = context.Operators.ConvertIntegerToDecimal(2285);
        bool? tzzzzzzzzzzzzm_ = this.Qualifies(context, Obs, tzzzzzzzzzzzzj_, szzzzzzzzzzzzq_, tzzzzzzzzzzzzl_);
        bool? tzzzzzzzzzzzzn_ = context.Operators.Or(tzzzzzzzzzzzzi_, tzzzzzzzzzzzzm_);
        CqlCode tzzzzzzzzzzzzo_ = this.Simultaneous_Head_and_Neck_High_Dose(context);
        decimal? tzzzzzzzzzzzzq_ = context.Operators.ConvertIntegerToDecimal(3092);
        bool? tzzzzzzzzzzzzr_ = this.Qualifies(context, Obs, tzzzzzzzzzzzzo_, szzzzzzzzzzzzq_, tzzzzzzzzzzzzq_);
        bool? tzzzzzzzzzzzzs_ = context.Operators.Or(tzzzzzzzzzzzzn_, tzzzzzzzzzzzzr_);

        return tzzzzzzzzzzzzs_;
    }


    #endregion Expressions

}
