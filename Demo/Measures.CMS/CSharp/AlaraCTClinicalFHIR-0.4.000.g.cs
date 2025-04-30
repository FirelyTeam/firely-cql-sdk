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
      new CqlCodeSystem("http://loinc.org", null, [
          _Birth_date,
          _CT_dose_and_image_quality_category,
          _Full_Body]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(izzzzzzzzzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzzzzzzzzze_, true, true);
        object izzzzzzzzzzzzzzzzzzzzzzzzg_ = context.ResolveParameter("AlaraCTClinicalFHIR-0.4.000", "Measurement Period", izzzzzzzzzzzzzzzzzzzzzzzzf_);

        return (CqlInterval<CqlDateTime>)izzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> izzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient izzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SingletonFrom<Patient>(izzzzzzzzzzzzzzzzzzzzzzzzh_);

        return izzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? izzzzzzzzzzzzzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return izzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> izzzzzzzzzzzzzzzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return izzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? izzzzzzzzzzzzzzzzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return izzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode izzzzzzzzzzzzzzzzzzzzzzzzm_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return izzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Patients with Qualifying CTScan")]
    public IEnumerable<Observation> Patients_with_Qualifying_CTScan(CqlContext context)
    {
        CqlCode izzzzzzzzzzzzzzzzzzzzzzzzn_ = this.CT_dose_and_image_quality_category(context);
        IEnumerable<CqlCode> izzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ToList<CqlCode>(izzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, izzzzzzzzzzzzzzzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? izzzzzzzzzzzzzzzzzzzzzzzzq_(Observation CTScanResult)
        {
            DataType izzzzzzzzzzzzzzzzzzzzzzzzs_ = CTScanResult?.Effective;
            object izzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.End(izzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzv_, izzzzzzzzzzzzzzzzzzzzzzzzw_, "day");
            Patient izzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Patient(context);
            Date izzzzzzzzzzzzzzzzzzzzzzzzz_ = izzzzzzzzzzzzzzzzzzzzzzzzy_?.BirthDateElement;
            string jzzzzzzzzzzzzzzzzzzzzzzzza_ = izzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConvertStringToDateTime(jzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzw_);
            int? jzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.CalculateAgeAt(jzzzzzzzzzzzzzzzzzzzzzzzzb_, jzzzzzzzzzzzzzzzzzzzzzzzzd_, "year");
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.GreaterOrEqual(jzzzzzzzzzzzzzzzzzzzzzzzze_, 18);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Observation>(izzzzzzzzzzzzzzzzzzzzzzzzp_, izzzzzzzzzzzzzzzzzzzzzzzzq_);

        return izzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Patients with Qualifying CTScan with Values")]
    public IEnumerable<Observation> Patients_with_Qualifying_CTScan_with_Values(CqlContext context)
    {
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Patients_with_Qualifying_CTScan(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation CTScan)
        {
            decimal? jzzzzzzzzzzzzzzzzzzzzzzzzk_ = AlaraCommonFunctions_1_5_000.Instance.Global_Noise_Value(context, CTScan);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzzzzzzzzzk_ is null));
            decimal? jzzzzzzzzzzzzzzzzzzzzzzzzm_ = AlaraCommonFunctions_1_5_000.Instance.Size_Adjusted_Value(context, CTScan);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzzzzzzzzzm_ is null));
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzl_, jzzzzzzzzzzzzzzzzzzzzzzzzn_);
            DataType jzzzzzzzzzzzzzzzzzzzzzzzzp_ = CTScan?.Value;
            object jzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzzzzzzzzzq_ is null));
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzo_, jzzzzzzzzzzzzzzzzzzzzzzzzr_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzh_, jzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Patients_with_Qualifying_CTScan(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Patients_with_Qualifying_CTScan_with_Values(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public bool? Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Patients_with_Qualifying_CTScan_with_Values(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzy_(Observation CTScan)
        {
            DataType kzzzzzzzzzzzzzzzzzzzzzzzzb_ = CTScan?.Value;
            object kzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlCode[] kzzzzzzzzzzzzzzzzzzzzzzzzd_ = (kzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlConcept)?.codes;
            CqlCode kzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Full_Body(context);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)kzzzzzzzzzzzzzzzzzzzzzzzzd_, kzzzzzzzzzzzzzzzzzzzzzzzze_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return kzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Patients_with_Qualifying_CTScan_with_Values(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzh_(Observation CTScan)
        {
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzk_ = AlaraCommonFunctions_1_5_000.Instance.CT_Scan_Qualifies(context, CTScan);

            return kzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    #endregion Expressions

}
