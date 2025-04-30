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
      new CqlCodeSystem("http://loinc.org", null, [
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
          _Thoracic_or_Lumbar_Spine]);

    #endregion CodeSystems

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> zzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient zzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<Patient>(zzzzzzzzzzzzzzzzzzzzzzzzu_);

        return zzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Global Noise Value")]
    public decimal? Global_Noise_Value(CqlContext context, Observation Obs)
    {
        List<Observation.ComponentComponent> zzzzzzzzzzzzzzzzzzzzzzzzw_ = Obs?.Component;
        bool? zzzzzzzzzzzzzzzzzzzzzzzzx_(Observation.ComponentComponent C)
        {
            CodeableConcept azzzzzzzzzzzzzzzzzzzzzzzzd_ = C?.Code;
            CqlConcept azzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlCode azzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Calculated_CT_global_noise(context);
            CqlConcept azzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertCodeToConcept(azzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equivalent(azzzzzzzzzzzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzzzzzzzzzzg_);
            DataType azzzzzzzzzzzzzzzzzzzzzzzzi_ = C?.Value;
            object azzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzi_);
            string azzzzzzzzzzzzzzzzzzzzzzzzk_ = (azzzzzzzzzzzzzzzzzzzzzzzzj_ as CqlQuantity)?.unit;
            bool? azzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equal(azzzzzzzzzzzzzzzzzzzzzzzzk_, "[hnsf'U]");
            bool? azzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzh_, azzzzzzzzzzzzzzzzzzzzzzzzl_);

            return azzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Observation.ComponentComponent> zzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)zzzzzzzzzzzzzzzzzzzzzzzzw_, zzzzzzzzzzzzzzzzzzzzzzzzx_);
        decimal? zzzzzzzzzzzzzzzzzzzzzzzzz_(Observation.ComponentComponent C)
        {
            DataType azzzzzzzzzzzzzzzzzzzzzzzzn_ = C?.Value;
            object azzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzn_);
            decimal? azzzzzzzzzzzzzzzzzzzzzzzzp_ = (azzzzzzzzzzzzzzzzzzzzzzzzo_ as CqlQuantity)?.value;

            return azzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<decimal?> azzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Observation.ComponentComponent, decimal?>(zzzzzzzzzzzzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<decimal?> azzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Distinct<decimal?>(azzzzzzzzzzzzzzzzzzzzzzzza_);
        decimal? azzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SingletonFrom<decimal?>(azzzzzzzzzzzzzzzzzzzzzzzzb_);

        return azzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Size Adjusted Value")]
    public decimal? Size_Adjusted_Value(CqlContext context, Observation Obs)
    {
        List<Observation.ComponentComponent> azzzzzzzzzzzzzzzzzzzzzzzzq_ = Obs?.Component;
        bool? azzzzzzzzzzzzzzzzzzzzzzzzr_(Observation.ComponentComponent C)
        {
            CodeableConcept azzzzzzzzzzzzzzzzzzzzzzzzx_ = C?.Code;
            CqlConcept azzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlCode azzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Calculated_CT_size_adjusted_dose(context);
            CqlConcept bzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertCodeToConcept(azzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Equivalent(azzzzzzzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzzzzzzza_);
            DataType bzzzzzzzzzzzzzzzzzzzzzzzzc_ = C?.Value;
            object bzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzc_);
            string bzzzzzzzzzzzzzzzzzzzzzzzze_ = (bzzzzzzzzzzzzzzzzzzzzzzzzd_ as CqlQuantity)?.unit;
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzzzzzzzze_, "mGy.cm");
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Observation.ComponentComponent> azzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)azzzzzzzzzzzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzzzzzzzzzzr_);
        decimal? azzzzzzzzzzzzzzzzzzzzzzzzt_(Observation.ComponentComponent C)
        {
            DataType bzzzzzzzzzzzzzzzzzzzzzzzzh_ = C?.Value;
            object bzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzh_);
            decimal? bzzzzzzzzzzzzzzzzzzzzzzzzj_ = (bzzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlQuantity)?.value;

            return bzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<decimal?> azzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Observation.ComponentComponent, decimal?>(azzzzzzzzzzzzzzzzzzzzzzzzs_, azzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<decimal?> azzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Distinct<decimal?>(azzzzzzzzzzzzzzzzzzzzzzzzu_);
        decimal? azzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<decimal?>(azzzzzzzzzzzzzzzzzzzzzzzzv_);

        return azzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Qualifies")]
    public bool? Qualifies(CqlContext context, Observation Obs, CqlCode code, decimal? noiseThreshold, decimal? sizeDoseThreshold)
    {
        DataType bzzzzzzzzzzzzzzzzzzzzzzzzk_ = Obs?.Value;
        object bzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlCode[] bzzzzzzzzzzzzzzzzzzzzzzzzm_ = (bzzzzzzzzzzzzzzzzzzzzzzzzl_ as CqlConcept)?.codes;
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)bzzzzzzzzzzzzzzzzzzzzzzzzm_, code);
        decimal? bzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Global_Noise_Value(context, Obs);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.GreaterOrEqual(bzzzzzzzzzzzzzzzzzzzzzzzzo_, noiseThreshold);
        decimal? bzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Size_Adjusted_Value(context, Obs);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.GreaterOrEqual(bzzzzzzzzzzzzzzzzzzzzzzzzq_, sizeDoseThreshold);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("CT Scan Qualifies")]
    public bool? CT_Scan_Qualifies(CqlContext context, Observation Obs)
    {
        CqlCode bzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Abdomen_and_Pelvis_Low_Dose(context);
        decimal? bzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertIntegerToDecimal(64);
        decimal? bzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConvertIntegerToDecimal(598);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Qualifies(context, Obs, bzzzzzzzzzzzzzzzzzzzzzzzzu_, bzzzzzzzzzzzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzzzzzzzzzzzw_);
        CqlCode bzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Abdomen_and_Pelvis_Routine_Dose(context);
        decimal? bzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertIntegerToDecimal(29);
        decimal? czzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertIntegerToDecimal(644);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Qualifies(context, Obs, bzzzzzzzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzzzzzzzz_, czzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzzzzzzzzx_, czzzzzzzzzzzzzzzzzzzzzzzzb_);
        CqlCode czzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Abdomen_and_Pelvis_High_Dose(context);
        decimal? czzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConvertIntegerToDecimal(1260);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Qualifies(context, Obs, czzzzzzzzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzzzzzzzzz_, czzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlCode czzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Cardiac_Low_Dose(context);
        decimal? czzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertIntegerToDecimal(55);
        decimal? czzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertIntegerToDecimal(93);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Qualifies(context, Obs, czzzzzzzzzzzzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzzzzzzzzzzzl_);
        CqlCode czzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Cardiac_Routine_Dose(context);
        decimal? czzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertIntegerToDecimal(32);
        decimal? czzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertIntegerToDecimal(576);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Qualifies(context, Obs, czzzzzzzzzzzzzzzzzzzzzzzzn_, czzzzzzzzzzzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlCode czzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Chest_Low_Dose(context);
        decimal? czzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertIntegerToDecimal(377);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Qualifies(context, Obs, czzzzzzzzzzzzzzzzzzzzzzzzs_, czzzzzzzzzzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzzzzzzzzzv_);
        CqlCode czzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Chest_Routine_Dose(context);
        decimal? czzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertIntegerToDecimal(49);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Qualifies(context, Obs, czzzzzzzzzzzzzzzzzzzzzzzzx_, czzzzzzzzzzzzzzzzzzzzzzzzy_, czzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlCode dzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Cardiac_High_Dose_or_Chest_High_Dose(context);
        decimal? dzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertIntegerToDecimal(1282);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Qualifies(context, Obs, dzzzzzzzzzzzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzzzzzzzzzzy_, dzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzzzzzzzzzzzzf_);
        CqlCode dzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Head_Low_Dose(context);
        decimal? dzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConvertIntegerToDecimal(115);
        decimal? dzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertIntegerToDecimal(582);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Qualifies(context, Obs, dzzzzzzzzzzzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzzzzzzzzg_, dzzzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlCode dzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Head_Routine_Dose(context);
        decimal? dzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertIntegerToDecimal(1025);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Qualifies(context, Obs, dzzzzzzzzzzzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlCode dzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Head_High_Dose(context);
        decimal? dzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConvertIntegerToDecimal(1832);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Qualifies(context, Obs, dzzzzzzzzzzzzzzzzzzzzzzzzr_, dzzzzzzzzzzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzzzzzzzzq_, dzzzzzzzzzzzzzzzzzzzzzzzzu_);
        CqlCode dzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Extremity(context);
        decimal? dzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConvertIntegerToDecimal(73);
        decimal? dzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertIntegerToDecimal(320);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Qualifies(context, Obs, dzzzzzzzzzzzzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzzzzzzzzv_, dzzzzzzzzzzzzzzzzzzzzzzzzz_);
        CqlCode ezzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Neck_or_Cervical_Spine(context);
        decimal? ezzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConvertIntegerToDecimal(25);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzze_ = this.Qualifies(context, Obs, ezzzzzzzzzzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Or(ezzzzzzzzzzzzzzzzzzzzzzzza_, ezzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlCode ezzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Thoracic_or_Lumbar_Spine(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Qualifies(context, Obs, ezzzzzzzzzzzzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Or(ezzzzzzzzzzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzzzzzzzzzj_);
        CqlCode ezzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Simultaneous_Chest_and_Abdomen_and_Pelvis(context);
        decimal? ezzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConvertIntegerToDecimal(1637);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Qualifies(context, Obs, ezzzzzzzzzzzzzzzzzzzzzzzzl_, bzzzzzzzzzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Or(ezzzzzzzzzzzzzzzzzzzzzzzzk_, ezzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlCode ezzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Simultaneous_Thoracic_and_Lumbar_Spine(context);
        decimal? ezzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertIntegerToDecimal(2520);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Qualifies(context, Obs, ezzzzzzzzzzzzzzzzzzzzzzzzq_, ezzzzzzzzzzzzzzzzzzzzzzzzc_, ezzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Or(ezzzzzzzzzzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzzzzzzzzzt_);
        CqlCode ezzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Simultaneous_Head_and_Neck_Routine_Dose(context);
        decimal? ezzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConvertIntegerToDecimal(2285);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Qualifies(context, Obs, ezzzzzzzzzzzzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzzzzzzzzzzzc_, ezzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Or(ezzzzzzzzzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzzzzzzzzy_);
        CqlCode fzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Simultaneous_Head_and_Neck_High_Dose(context);
        decimal? fzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConvertIntegerToDecimal(3092);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Qualifies(context, Obs, fzzzzzzzzzzzzzzzzzzzzzzzza_, ezzzzzzzzzzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Or(ezzzzzzzzzzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return fzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    #endregion Expressions

}
