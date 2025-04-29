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
        CqlDateTime uzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime uzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(uzzzzzzzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzzzzzzzs_, true, true);
        object uzzzzzzzzzzzzzzzzzzzu_ = context.ResolveParameter("AlaraCTClinicalFHIR-0.4.000", "Measurement Period", uzzzzzzzzzzzzzzzzzzzt_);

        return (CqlInterval<CqlDateTime>)uzzzzzzzzzzzzzzzzzzzu_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> uzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient uzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<Patient>(uzzzzzzzzzzzzzzzzzzzv_);

        return uzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? uzzzzzzzzzzzzzzzzzzzx_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return uzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> uzzzzzzzzzzzzzzzzzzzy_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return uzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? uzzzzzzzzzzzzzzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return uzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode vzzzzzzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return vzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Patients with Qualifying CTScan")]
    public IEnumerable<Observation> Patients_with_Qualifying_CTScan(CqlContext context)
    {
        CqlCode vzzzzzzzzzzzzzzzzzzzb_ = this.CT_dose_and_image_quality_category(context);
        IEnumerable<CqlCode> vzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ToList<CqlCode>(vzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, vzzzzzzzzzzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? vzzzzzzzzzzzzzzzzzzze_(Observation CTScanResult)
        {
            DataType vzzzzzzzzzzzzzzzzzzzg_ = CTScanResult?.Effective;
            object vzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzh_);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzj_ = context.Operators.End(vzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            bool? vzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzj_, vzzzzzzzzzzzzzzzzzzzk_, "day");
            Patient vzzzzzzzzzzzzzzzzzzzm_ = this.Patient(context);
            Date vzzzzzzzzzzzzzzzzzzzn_ = vzzzzzzzzzzzzzzzzzzzm_?.BirthDateElement;
            string vzzzzzzzzzzzzzzzzzzzo_ = vzzzzzzzzzzzzzzzzzzzn_?.Value;
            CqlDateTime vzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertStringToDateTime(vzzzzzzzzzzzzzzzzzzzo_);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzk_);
            int? vzzzzzzzzzzzzzzzzzzzs_ = context.Operators.CalculateAgeAt(vzzzzzzzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzzzzzzzr_, "year");
            bool? vzzzzzzzzzzzzzzzzzzzt_ = context.Operators.GreaterOrEqual(vzzzzzzzzzzzzzzzzzzzs_, 18);
            bool? vzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzl_, vzzzzzzzzzzzzzzzzzzzt_);

            return vzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzzzzzd_, vzzzzzzzzzzzzzzzzzzze_);

        return vzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Patients with Qualifying CTScan with Values")]
    public IEnumerable<Observation> Patients_with_Qualifying_CTScan_with_Values(CqlContext context)
    {
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzv_ = this.Patients_with_Qualifying_CTScan(context);
        bool? vzzzzzzzzzzzzzzzzzzzw_(Observation CTScan)
        {
            decimal? vzzzzzzzzzzzzzzzzzzzy_ = AlaraCommonFunctions_1_5_000.Instance.Global_Noise_Value(context, CTScan);
            bool? vzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzzzzzzzy_ is null));
            decimal? wzzzzzzzzzzzzzzzzzzza_ = AlaraCommonFunctions_1_5_000.Instance.Size_Adjusted_Value(context, CTScan);
            bool? wzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzzzzza_ is null));
            bool? wzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzzzzzzb_);
            DataType wzzzzzzzzzzzzzzzzzzzd_ = CTScan?.Value;
            object wzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzd_);
            bool? wzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzzzzze_ is null));
            bool? wzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzc_, wzzzzzzzzzzzzzzzzzzzf_);

            return wzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzzzzzzw_);

        return vzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzh_ = this.Patients_with_Qualifying_CTScan(context);
        bool? wzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Exists<Observation>(wzzzzzzzzzzzzzzzzzzzh_);

        return wzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzj_ = this.Patients_with_Qualifying_CTScan_with_Values(context);
        bool? wzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Observation>(wzzzzzzzzzzzzzzzzzzzj_);

        return wzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public bool? Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzl_ = this.Patients_with_Qualifying_CTScan_with_Values(context);
        bool? wzzzzzzzzzzzzzzzzzzzm_(Observation CTScan)
        {
            DataType wzzzzzzzzzzzzzzzzzzzp_ = CTScan?.Value;
            object wzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzp_);
            CqlCode[] wzzzzzzzzzzzzzzzzzzzr_ = (wzzzzzzzzzzzzzzzzzzzq_ as CqlConcept)?.codes;
            CqlCode wzzzzzzzzzzzzzzzzzzzs_ = this.Full_Body(context);
            bool? wzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)wzzzzzzzzzzzzzzzzzzzr_, wzzzzzzzzzzzzzzzzzzzs_);

            return wzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Observation>(wzzzzzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzzzzzm_);
        bool? wzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<Observation>(wzzzzzzzzzzzzzzzzzzzn_);

        return wzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzu_ = this.Patients_with_Qualifying_CTScan_with_Values(context);
        bool? wzzzzzzzzzzzzzzzzzzzv_(Observation CTScan)
        {
            bool? wzzzzzzzzzzzzzzzzzzzy_ = AlaraCommonFunctions_1_5_000.Instance.CT_Scan_Qualifies(context, CTScan);

            return wzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(wzzzzzzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzzzzzzv_);
        bool? wzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Observation>(wzzzzzzzzzzzzzzzzzzzw_);

        return wzzzzzzzzzzzzzzzzzzzx_;
    }


    #endregion Expressions

}
