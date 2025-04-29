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
        IEnumerable<Patient> pzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient pzzzzzzzzzzzzzg_ = context.Operators.SingletonFrom<Patient>(pzzzzzzzzzzzzzf_);

        return pzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Global Noise Value")]
    public decimal? Global_Noise_Value(CqlContext context, Observation Obs)
    {
        List<Observation.ComponentComponent> pzzzzzzzzzzzzzh_ = Obs?.Component;
        bool? pzzzzzzzzzzzzzi_(Observation.ComponentComponent C)
        {
            CodeableConcept pzzzzzzzzzzzzzo_ = C?.Code;
            CqlConcept pzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzzzo_);
            CqlCode pzzzzzzzzzzzzzq_ = this.Calculated_CT_global_noise(context);
            CqlConcept pzzzzzzzzzzzzzr_ = context.Operators.ConvertCodeToConcept(pzzzzzzzzzzzzzq_);
            bool? pzzzzzzzzzzzzzs_ = context.Operators.Equivalent(pzzzzzzzzzzzzzp_, pzzzzzzzzzzzzzr_);
            DataType pzzzzzzzzzzzzzt_ = C?.Value;
            object pzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzt_);
            string pzzzzzzzzzzzzzv_ = (pzzzzzzzzzzzzzu_ as CqlQuantity)?.unit;
            bool? pzzzzzzzzzzzzzw_ = context.Operators.Equal(pzzzzzzzzzzzzzv_, "[hnsf'U]");
            bool? pzzzzzzzzzzzzzx_ = context.Operators.And(pzzzzzzzzzzzzzs_, pzzzzzzzzzzzzzw_);

            return pzzzzzzzzzzzzzx_;
        };
        IEnumerable<Observation.ComponentComponent> pzzzzzzzzzzzzzj_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)pzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzi_);
        decimal? pzzzzzzzzzzzzzk_(Observation.ComponentComponent C)
        {
            DataType pzzzzzzzzzzzzzy_ = C?.Value;
            object pzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzy_);
            decimal? qzzzzzzzzzzzzza_ = (pzzzzzzzzzzzzzz_ as CqlQuantity)?.value;

            return qzzzzzzzzzzzzza_;
        };
        IEnumerable<decimal?> pzzzzzzzzzzzzzl_ = context.Operators.Select<Observation.ComponentComponent, decimal?>(pzzzzzzzzzzzzzj_, pzzzzzzzzzzzzzk_);
        IEnumerable<decimal?> pzzzzzzzzzzzzzm_ = context.Operators.Distinct<decimal?>(pzzzzzzzzzzzzzl_);
        decimal? pzzzzzzzzzzzzzn_ = context.Operators.SingletonFrom<decimal?>(pzzzzzzzzzzzzzm_);

        return pzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Size Adjusted Value")]
    public decimal? Size_Adjusted_Value(CqlContext context, Observation Obs)
    {
        List<Observation.ComponentComponent> qzzzzzzzzzzzzzb_ = Obs?.Component;
        bool? qzzzzzzzzzzzzzc_(Observation.ComponentComponent C)
        {
            CodeableConcept qzzzzzzzzzzzzzi_ = C?.Code;
            CqlConcept qzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, qzzzzzzzzzzzzzi_);
            CqlCode qzzzzzzzzzzzzzk_ = this.Calculated_CT_size_adjusted_dose(context);
            CqlConcept qzzzzzzzzzzzzzl_ = context.Operators.ConvertCodeToConcept(qzzzzzzzzzzzzzk_);
            bool? qzzzzzzzzzzzzzm_ = context.Operators.Equivalent(qzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzl_);
            DataType qzzzzzzzzzzzzzn_ = C?.Value;
            object qzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzn_);
            string qzzzzzzzzzzzzzp_ = (qzzzzzzzzzzzzzo_ as CqlQuantity)?.unit;
            bool? qzzzzzzzzzzzzzq_ = context.Operators.Equal(qzzzzzzzzzzzzzp_, "mGy.cm");
            bool? qzzzzzzzzzzzzzr_ = context.Operators.And(qzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzq_);

            return qzzzzzzzzzzzzzr_;
        };
        IEnumerable<Observation.ComponentComponent> qzzzzzzzzzzzzzd_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)qzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzc_);
        decimal? qzzzzzzzzzzzzze_(Observation.ComponentComponent C)
        {
            DataType qzzzzzzzzzzzzzs_ = C?.Value;
            object qzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzs_);
            decimal? qzzzzzzzzzzzzzu_ = (qzzzzzzzzzzzzzt_ as CqlQuantity)?.value;

            return qzzzzzzzzzzzzzu_;
        };
        IEnumerable<decimal?> qzzzzzzzzzzzzzf_ = context.Operators.Select<Observation.ComponentComponent, decimal?>(qzzzzzzzzzzzzzd_, qzzzzzzzzzzzzze_);
        IEnumerable<decimal?> qzzzzzzzzzzzzzg_ = context.Operators.Distinct<decimal?>(qzzzzzzzzzzzzzf_);
        decimal? qzzzzzzzzzzzzzh_ = context.Operators.SingletonFrom<decimal?>(qzzzzzzzzzzzzzg_);

        return qzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Qualifies")]
    public bool? Qualifies(CqlContext context, Observation Obs, CqlCode code, decimal? noiseThreshold, decimal? sizeDoseThreshold)
    {
        DataType qzzzzzzzzzzzzzv_ = Obs?.Value;
        object qzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzv_);
        CqlCode[] qzzzzzzzzzzzzzx_ = (qzzzzzzzzzzzzzw_ as CqlConcept)?.codes;
        bool? qzzzzzzzzzzzzzy_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)qzzzzzzzzzzzzzx_, code);
        decimal? qzzzzzzzzzzzzzz_ = this.Global_Noise_Value(context, Obs);
        bool? rzzzzzzzzzzzzza_ = context.Operators.GreaterOrEqual(qzzzzzzzzzzzzzz_, noiseThreshold);
        decimal? rzzzzzzzzzzzzzb_ = this.Size_Adjusted_Value(context, Obs);
        bool? rzzzzzzzzzzzzzc_ = context.Operators.GreaterOrEqual(rzzzzzzzzzzzzzb_, sizeDoseThreshold);
        bool? rzzzzzzzzzzzzzd_ = context.Operators.Or(rzzzzzzzzzzzzza_, rzzzzzzzzzzzzzc_);
        bool? rzzzzzzzzzzzzze_ = context.Operators.And(qzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzd_);

        return rzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("CT Scan Qualifies")]
    public bool? CT_Scan_Qualifies(CqlContext context, Observation Obs)
    {
        CqlCode rzzzzzzzzzzzzzf_ = this.Abdomen_and_Pelvis_Low_Dose(context);
        decimal? rzzzzzzzzzzzzzg_ = context.Operators.ConvertIntegerToDecimal(64);
        decimal? rzzzzzzzzzzzzzh_ = context.Operators.ConvertIntegerToDecimal(598);
        bool? rzzzzzzzzzzzzzi_ = this.Qualifies(context, Obs, rzzzzzzzzzzzzzf_, rzzzzzzzzzzzzzg_, rzzzzzzzzzzzzzh_);
        CqlCode rzzzzzzzzzzzzzj_ = this.Abdomen_and_Pelvis_Routine_Dose(context);
        decimal? rzzzzzzzzzzzzzk_ = context.Operators.ConvertIntegerToDecimal(29);
        decimal? rzzzzzzzzzzzzzl_ = context.Operators.ConvertIntegerToDecimal(644);
        bool? rzzzzzzzzzzzzzm_ = this.Qualifies(context, Obs, rzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzl_);
        bool? rzzzzzzzzzzzzzn_ = context.Operators.Or(rzzzzzzzzzzzzzi_, rzzzzzzzzzzzzzm_);
        CqlCode rzzzzzzzzzzzzzo_ = this.Abdomen_and_Pelvis_High_Dose(context);
        decimal? rzzzzzzzzzzzzzq_ = context.Operators.ConvertIntegerToDecimal(1260);
        bool? rzzzzzzzzzzzzzr_ = this.Qualifies(context, Obs, rzzzzzzzzzzzzzo_, rzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzq_);
        bool? rzzzzzzzzzzzzzs_ = context.Operators.Or(rzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzr_);
        CqlCode rzzzzzzzzzzzzzt_ = this.Cardiac_Low_Dose(context);
        decimal? rzzzzzzzzzzzzzu_ = context.Operators.ConvertIntegerToDecimal(55);
        decimal? rzzzzzzzzzzzzzv_ = context.Operators.ConvertIntegerToDecimal(93);
        bool? rzzzzzzzzzzzzzw_ = this.Qualifies(context, Obs, rzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzv_);
        bool? rzzzzzzzzzzzzzx_ = context.Operators.Or(rzzzzzzzzzzzzzs_, rzzzzzzzzzzzzzw_);
        CqlCode rzzzzzzzzzzzzzy_ = this.Cardiac_Routine_Dose(context);
        decimal? rzzzzzzzzzzzzzz_ = context.Operators.ConvertIntegerToDecimal(32);
        decimal? szzzzzzzzzzzzza_ = context.Operators.ConvertIntegerToDecimal(576);
        bool? szzzzzzzzzzzzzb_ = this.Qualifies(context, Obs, rzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzz_, szzzzzzzzzzzzza_);
        bool? szzzzzzzzzzzzzc_ = context.Operators.Or(rzzzzzzzzzzzzzx_, szzzzzzzzzzzzzb_);
        CqlCode szzzzzzzzzzzzzd_ = this.Chest_Low_Dose(context);
        decimal? szzzzzzzzzzzzzf_ = context.Operators.ConvertIntegerToDecimal(377);
        bool? szzzzzzzzzzzzzg_ = this.Qualifies(context, Obs, szzzzzzzzzzzzzd_, rzzzzzzzzzzzzzu_, szzzzzzzzzzzzzf_);
        bool? szzzzzzzzzzzzzh_ = context.Operators.Or(szzzzzzzzzzzzzc_, szzzzzzzzzzzzzg_);
        CqlCode szzzzzzzzzzzzzi_ = this.Chest_Routine_Dose(context);
        decimal? szzzzzzzzzzzzzj_ = context.Operators.ConvertIntegerToDecimal(49);
        bool? szzzzzzzzzzzzzl_ = this.Qualifies(context, Obs, szzzzzzzzzzzzzi_, szzzzzzzzzzzzzj_, szzzzzzzzzzzzzf_);
        bool? szzzzzzzzzzzzzm_ = context.Operators.Or(szzzzzzzzzzzzzh_, szzzzzzzzzzzzzl_);
        CqlCode szzzzzzzzzzzzzn_ = this.Cardiac_High_Dose_or_Chest_High_Dose(context);
        decimal? szzzzzzzzzzzzzp_ = context.Operators.ConvertIntegerToDecimal(1282);
        bool? szzzzzzzzzzzzzq_ = this.Qualifies(context, Obs, szzzzzzzzzzzzzn_, szzzzzzzzzzzzzj_, szzzzzzzzzzzzzp_);
        bool? szzzzzzzzzzzzzr_ = context.Operators.Or(szzzzzzzzzzzzzm_, szzzzzzzzzzzzzq_);
        CqlCode szzzzzzzzzzzzzs_ = this.Head_Low_Dose(context);
        decimal? szzzzzzzzzzzzzt_ = context.Operators.ConvertIntegerToDecimal(115);
        decimal? szzzzzzzzzzzzzu_ = context.Operators.ConvertIntegerToDecimal(582);
        bool? szzzzzzzzzzzzzv_ = this.Qualifies(context, Obs, szzzzzzzzzzzzzs_, szzzzzzzzzzzzzt_, szzzzzzzzzzzzzu_);
        bool? szzzzzzzzzzzzzw_ = context.Operators.Or(szzzzzzzzzzzzzr_, szzzzzzzzzzzzzv_);
        CqlCode szzzzzzzzzzzzzx_ = this.Head_Routine_Dose(context);
        decimal? szzzzzzzzzzzzzz_ = context.Operators.ConvertIntegerToDecimal(1025);
        bool? tzzzzzzzzzzzzza_ = this.Qualifies(context, Obs, szzzzzzzzzzzzzx_, szzzzzzzzzzzzzt_, szzzzzzzzzzzzzz_);
        bool? tzzzzzzzzzzzzzb_ = context.Operators.Or(szzzzzzzzzzzzzw_, tzzzzzzzzzzzzza_);
        CqlCode tzzzzzzzzzzzzzc_ = this.Head_High_Dose(context);
        decimal? tzzzzzzzzzzzzze_ = context.Operators.ConvertIntegerToDecimal(1832);
        bool? tzzzzzzzzzzzzzf_ = this.Qualifies(context, Obs, tzzzzzzzzzzzzzc_, szzzzzzzzzzzzzt_, tzzzzzzzzzzzzze_);
        bool? tzzzzzzzzzzzzzg_ = context.Operators.Or(tzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzf_);
        CqlCode tzzzzzzzzzzzzzh_ = this.Extremity(context);
        decimal? tzzzzzzzzzzzzzi_ = context.Operators.ConvertIntegerToDecimal(73);
        decimal? tzzzzzzzzzzzzzj_ = context.Operators.ConvertIntegerToDecimal(320);
        bool? tzzzzzzzzzzzzzk_ = this.Qualifies(context, Obs, tzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzi_, tzzzzzzzzzzzzzj_);
        bool? tzzzzzzzzzzzzzl_ = context.Operators.Or(tzzzzzzzzzzzzzg_, tzzzzzzzzzzzzzk_);
        CqlCode tzzzzzzzzzzzzzm_ = this.Neck_or_Cervical_Spine(context);
        decimal? tzzzzzzzzzzzzzn_ = context.Operators.ConvertIntegerToDecimal(25);
        bool? tzzzzzzzzzzzzzp_ = this.Qualifies(context, Obs, tzzzzzzzzzzzzzm_, tzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzq_);
        bool? tzzzzzzzzzzzzzq_ = context.Operators.Or(tzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzp_);
        CqlCode tzzzzzzzzzzzzzr_ = this.Thoracic_or_Lumbar_Spine(context);
        bool? tzzzzzzzzzzzzzu_ = this.Qualifies(context, Obs, tzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzq_);
        bool? tzzzzzzzzzzzzzv_ = context.Operators.Or(tzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzu_);
        CqlCode tzzzzzzzzzzzzzw_ = this.Simultaneous_Chest_and_Abdomen_and_Pelvis(context);
        decimal? tzzzzzzzzzzzzzy_ = context.Operators.ConvertIntegerToDecimal(1637);
        bool? tzzzzzzzzzzzzzz_ = this.Qualifies(context, Obs, tzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzk_, tzzzzzzzzzzzzzy_);
        bool? uzzzzzzzzzzzzza_ = context.Operators.Or(tzzzzzzzzzzzzzv_, tzzzzzzzzzzzzzz_);
        CqlCode uzzzzzzzzzzzzzb_ = this.Simultaneous_Thoracic_and_Lumbar_Spine(context);
        decimal? uzzzzzzzzzzzzzd_ = context.Operators.ConvertIntegerToDecimal(2520);
        bool? uzzzzzzzzzzzzze_ = this.Qualifies(context, Obs, uzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzd_);
        bool? uzzzzzzzzzzzzzf_ = context.Operators.Or(uzzzzzzzzzzzzza_, uzzzzzzzzzzzzze_);
        CqlCode uzzzzzzzzzzzzzg_ = this.Simultaneous_Head_and_Neck_Routine_Dose(context);
        decimal? uzzzzzzzzzzzzzi_ = context.Operators.ConvertIntegerToDecimal(2285);
        bool? uzzzzzzzzzzzzzj_ = this.Qualifies(context, Obs, uzzzzzzzzzzzzzg_, tzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzi_);
        bool? uzzzzzzzzzzzzzk_ = context.Operators.Or(uzzzzzzzzzzzzzf_, uzzzzzzzzzzzzzj_);
        CqlCode uzzzzzzzzzzzzzl_ = this.Simultaneous_Head_and_Neck_High_Dose(context);
        decimal? uzzzzzzzzzzzzzn_ = context.Operators.ConvertIntegerToDecimal(3092);
        bool? uzzzzzzzzzzzzzo_ = this.Qualifies(context, Obs, uzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzn_);
        bool? uzzzzzzzzzzzzzp_ = context.Operators.Or(uzzzzzzzzzzzzzk_, uzzzzzzzzzzzzzo_);

        return uzzzzzzzzzzzzzp_;
    }


    #endregion Expressions

}
