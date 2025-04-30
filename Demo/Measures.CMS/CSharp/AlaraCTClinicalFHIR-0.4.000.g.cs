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
    private static readonly CqlCode _Birth_date = new CqlCode("21112-8", "http://loinc.org");

    [CqlCodeDefinition("CT dose and image quality category", codeId: "96914-7", codeSystem: "http://loinc.org")]
    public CqlCode CT_dose_and_image_quality_category(CqlContext _) => _CT_dose_and_image_quality_category;
    private static readonly CqlCode _CT_dose_and_image_quality_category = new CqlCode("96914-7", "http://loinc.org");

    [CqlCodeDefinition("Full Body", codeId: "LA31771-1", codeSystem: "http://loinc.org")]
    public CqlCode Full_Body(CqlContext _) => _Full_Body;
    private static readonly CqlCode _Full_Body = new CqlCode("LA31771-1", "http://loinc.org");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null,
          _Birth_date,
          _CT_dose_and_image_quality_category,
          _Full_Body);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime czzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime czzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzzzzzs_, true, true);
        object czzzzzzzzzzzzzzzzzzzzu_ = context.ResolveParameter("AlaraCTClinicalFHIR-0.4.000", "Measurement Period", czzzzzzzzzzzzzzzzzzzzt_);

        return (CqlInterval<CqlDateTime>)czzzzzzzzzzzzzzzzzzzzu_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> czzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient czzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<Patient>(czzzzzzzzzzzzzzzzzzzzv_);

        return czzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? czzzzzzzzzzzzzzzzzzzzx_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return czzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> czzzzzzzzzzzzzzzzzzzzy_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return czzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? czzzzzzzzzzzzzzzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return czzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode dzzzzzzzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return dzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Patients with Qualifying CTScan")]
    public IEnumerable<Observation> Patients_with_Qualifying_CTScan(CqlContext context)
    {
        CqlCode dzzzzzzzzzzzzzzzzzzzzb_ = this.CT_dose_and_image_quality_category(context);
        IEnumerable<CqlCode> dzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ToList<CqlCode>(dzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, dzzzzzzzzzzzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? dzzzzzzzzzzzzzzzzzzzze_(Observation CTScanResult)
        {
            DataType dzzzzzzzzzzzzzzzzzzzzg_ = CTScanResult?.Effective;
            object dzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzh_);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.End(dzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            bool? dzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzj_, dzzzzzzzzzzzzzzzzzzzzk_, "day");
            Patient dzzzzzzzzzzzzzzzzzzzzm_ = this.Patient(context);
            Date dzzzzzzzzzzzzzzzzzzzzn_ = dzzzzzzzzzzzzzzzzzzzzm_?.BirthDateElement;
            string dzzzzzzzzzzzzzzzzzzzzo_ = dzzzzzzzzzzzzzzzzzzzzn_?.Value;
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertStringToDateTime(dzzzzzzzzzzzzzzzzzzzzo_);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzk_);
            int? dzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.CalculateAgeAt(dzzzzzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzzzzzr_, "year");
            bool? dzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.GreaterOrEqual(dzzzzzzzzzzzzzzzzzzzzs_, 18);
            bool? dzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzzzzzzzzt_);

            return dzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(dzzzzzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzzzzzze_);

        return dzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Patients with Qualifying CTScan with Values")]
    public IEnumerable<Observation> Patients_with_Qualifying_CTScan_with_Values(CqlContext context)
    {
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzv_ = this.Patients_with_Qualifying_CTScan(context);
        bool? dzzzzzzzzzzzzzzzzzzzzw_(Observation CTScan)
        {
            decimal? dzzzzzzzzzzzzzzzzzzzzy_ = AlaraCommonFunctions_1_5_000.Instance.Global_Noise_Value(context, CTScan);
            bool? dzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzzzzzzy_ is null));
            decimal? ezzzzzzzzzzzzzzzzzzzza_ = AlaraCommonFunctions_1_5_000.Instance.Size_Adjusted_Value(context, CTScan);
            bool? ezzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzzzzzza_ is null));
            bool? ezzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzzzzzb_);
            DataType ezzzzzzzzzzzzzzzzzzzzd_ = CTScan?.Value;
            object ezzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzd_);
            bool? ezzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzzzzzze_ is null));
            bool? ezzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzc_, ezzzzzzzzzzzzzzzzzzzzf_);

            return ezzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Observation>(dzzzzzzzzzzzzzzzzzzzzv_, dzzzzzzzzzzzzzzzzzzzzw_);

        return dzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzh_ = this.Patients_with_Qualifying_CTScan(context);
        bool? ezzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Exists<Observation>(ezzzzzzzzzzzzzzzzzzzzh_);

        return ezzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzj_ = this.Patients_with_Qualifying_CTScan_with_Values(context);
        bool? ezzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Observation>(ezzzzzzzzzzzzzzzzzzzzj_);

        return ezzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public bool? Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzl_ = this.Patients_with_Qualifying_CTScan_with_Values(context);
        bool? ezzzzzzzzzzzzzzzzzzzzm_(Observation CTScan)
        {
            DataType ezzzzzzzzzzzzzzzzzzzzp_ = CTScan?.Value;
            object ezzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzp_);
            CqlCode[] ezzzzzzzzzzzzzzzzzzzzr_ = (ezzzzzzzzzzzzzzzzzzzzq_ as CqlConcept)?.codes;
            CqlCode ezzzzzzzzzzzzzzzzzzzzs_ = this.Full_Body(context);
            bool? ezzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)ezzzzzzzzzzzzzzzzzzzzr_, ezzzzzzzzzzzzzzzzzzzzs_);

            return ezzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Observation>(ezzzzzzzzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzzzzzzzm_);
        bool? ezzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<Observation>(ezzzzzzzzzzzzzzzzzzzzn_);

        return ezzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzu_ = this.Patients_with_Qualifying_CTScan_with_Values(context);
        bool? ezzzzzzzzzzzzzzzzzzzzv_(Observation CTScan)
        {
            bool? ezzzzzzzzzzzzzzzzzzzzy_ = AlaraCommonFunctions_1_5_000.Instance.CT_Scan_Qualifies(context, CTScan);

            return ezzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(ezzzzzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzzzzv_);
        bool? ezzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Observation>(ezzzzzzzzzzzzzzzzzzzzw_);

        return ezzzzzzzzzzzzzzzzzzzzx_;
    }


    #endregion Expressions

}
