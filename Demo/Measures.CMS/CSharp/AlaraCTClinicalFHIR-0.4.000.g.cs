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
[CqlLibrary("AlaraCTClinicalFHIR", "0.4.000")]
public partial class AlaraCTClinicalFHIR_0_4_000 : ILibrary, ISingleton<AlaraCTClinicalFHIR_0_4_000>
{
    private AlaraCTClinicalFHIR_0_4_000() {}

    public static AlaraCTClinicalFHIR_0_4_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "AlaraCTClinicalFHIR";
    public string Version => "0.4.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, CQMCommon_2_2_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance, AlaraCommonFunctions_1_5_000.Instance];

    #endregion ILibrary Implementation

    #region Codes

    [CqlCodeDefinition("Birth date", codeId: "21112-8", codeSystem: "http://loinc.org")]
    public CqlCode Birth_date(CqlContext _) => _Birth_date;
    private static readonly CqlCode _Birth_date = new CqlCode("21112-8", "http://loinc.org", default, default);

    [CqlCodeDefinition("CT dose and image quality category", codeId: "96914-7", codeSystem: "http://loinc.org")]
    public CqlCode CT_dose_and_image_quality_category(CqlContext _) => _CT_dose_and_image_quality_category;
    private static readonly CqlCode _CT_dose_and_image_quality_category = new CqlCode("96914-7", "http://loinc.org", default, default);

    [CqlCodeDefinition("Full Body", codeId: "LA31771-1", codeSystem: "http://loinc.org")]
    public CqlCode Full_Body(CqlContext _) => _Full_Body;
    private static readonly CqlCode _Full_Body = new CqlCode("LA31771-1", "http://loinc.org", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, true, true);
        object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.ResolveParameter("AlaraCTClinicalFHIR-0.4.000", "Measurement Period", xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return (CqlInterval<CqlDateTime>)xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SingletonFrom<Patient>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Patients with Qualifying CTScan")]
    public IEnumerable<Observation> Patients_with_Qualifying_CTScan(CqlContext context)
    {
        CqlCode yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.CT_dose_and_image_quality_category(context);
        IEnumerable<CqlCode> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ToList<CqlCode>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Observation CTScanResult)
        {
            DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = CTScanResult?.Effective;
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.End(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "day");
            Patient yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Patient(context);
            Date yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.BirthDateElement;
            string yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertStringToDateTime(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            int? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.CalculateAgeAt(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "year");
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.GreaterOrEqual(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, 18);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Patients with Qualifying CTScan with Values")]
    public IEnumerable<Observation> Patients_with_Qualifying_CTScan_with_Values(CqlContext context)
    {
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Patients_with_Qualifying_CTScan(context);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Observation CTScan)
        {
            decimal? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = AlaraCommonFunctions_1_5_000.Instance.Global_Noise_Value(context, CTScan);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ is null));
            decimal? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = AlaraCommonFunctions_1_5_000.Instance.Size_Adjusted_Value(context, CTScan);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is null));
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = CTScan?.Value;
            object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ is null));
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Patients_with_Qualifying_CTScan(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Observation>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Patients_with_Qualifying_CTScan_with_Values(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Observation>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public bool? Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Patients_with_Qualifying_CTScan_with_Values(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation CTScan)
        {
            DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = CTScan?.Value;
            object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlCode[] zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = (zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlConcept)?.codes;
            CqlCode zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Full_Body(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<Observation>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Patients_with_Qualifying_CTScan_with_Values(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Observation CTScan)
        {
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = AlaraCommonFunctions_1_5_000.Instance.CT_Scan_Qualifies(context, CTScan);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Observation>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    #endregion Expressions

}
