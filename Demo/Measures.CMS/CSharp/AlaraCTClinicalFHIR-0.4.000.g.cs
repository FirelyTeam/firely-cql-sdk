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
        CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(azzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, true, true);
        object azzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.ResolveParameter("AlaraCTClinicalFHIR-0.4.000", "Measurement Period", azzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return (CqlInterval<CqlDateTime>)azzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> azzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient azzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SingletonFrom<Patient>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? bzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode bzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Patients with Qualifying CTScan")]
    public IEnumerable<Observation> Patients_with_Qualifying_CTScan(CqlContext context)
    {
        CqlCode bzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.CT_dose_and_image_quality_category(context);
        IEnumerable<CqlCode> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ToList<CqlCode>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Observation CTScanResult)
        {
            DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = CTScanResult?.Effective;
            object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.End(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "day");
            Patient bzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Patient(context);
            Date bzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.BirthDateElement;
            string bzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertStringToDateTime(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            int? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.CalculateAgeAt(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "year");
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.GreaterOrEqual(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, 18);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Patients with Qualifying CTScan with Values")]
    public IEnumerable<Observation> Patients_with_Qualifying_CTScan_with_Values(CqlContext context)
    {
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Patients_with_Qualifying_CTScan(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Observation CTScan)
        {
            decimal? czzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = AlaraCommonFunctions_1_5_000.Instance.Global_Noise_Value(context, CTScan);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ is null));
            decimal? czzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = AlaraCommonFunctions_1_5_000.Instance.Size_Adjusted_Value(context, CTScan);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is null));
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = CTScan?.Value;
            object czzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ is null));
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Patients_with_Qualifying_CTScan(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Patients_with_Qualifying_CTScan_with_Values(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public bool? Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Patients_with_Qualifying_CTScan_with_Values(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation CTScan)
        {
            DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = CTScan?.Value;
            object czzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlCode[] czzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = (czzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlConcept)?.codes;
            CqlCode czzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Full_Body(context);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)czzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Patients_with_Qualifying_CTScan_with_Values(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Observation CTScan)
        {
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = AlaraCommonFunctions_1_5_000.Instance.CT_Scan_Qualifies(context, CTScan);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    #endregion Expressions

}
