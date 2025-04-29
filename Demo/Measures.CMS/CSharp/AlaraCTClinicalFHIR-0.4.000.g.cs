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

    #region Code: Birth date
    [CqlCodeDefinition(
        definitionName: "Birth date",
        codeId: "21112-8",
        codeSystem: "http://loinc.org")]
    public CqlCode Birth_date(CqlContext context) => _Birth_date;

    private static readonly CqlCode _Birth_date = new CqlCode("21112-8", "http://loinc.org", default, default);
    #endregion

    #region Code: CT dose and image quality category
    [CqlCodeDefinition(
        definitionName: "CT dose and image quality category",
        codeId: "96914-7",
        codeSystem: "http://loinc.org")]
    public CqlCode CT_dose_and_image_quality_category(CqlContext context) => _CT_dose_and_image_quality_category;

    private static readonly CqlCode _CT_dose_and_image_quality_category = new CqlCode("96914-7", "http://loinc.org", default, default);
    #endregion

    #region Code: Full Body
    [CqlCodeDefinition(
        definitionName: "Full Body",
        codeId: "LA31771-1",
        codeSystem: "http://loinc.org")]
    public CqlCode Full_Body(CqlContext context) => _Full_Body;

    private static readonly CqlCode _Full_Body = new CqlCode("LA31771-1", "http://loinc.org", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = [
            new CqlCode("21112-8", "http://loinc.org", default, default),
            new CqlCode("96914-7", "http://loinc.org", default, default),
            new CqlCode("LA31771-1", "http://loinc.org", default, default),
        ];

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, true, true);
        object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.ResolveParameter("AlaraCTClinicalFHIR-0.4.000", "Measurement Period", hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return (CqlInterval<CqlDateTime>)hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SingletonFrom<Patient>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Patients with Qualifying CTScan")]
    public IEnumerable<Observation> Patients_with_Qualifying_CTScan(CqlContext context)
    {
        CqlCode hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.CT_dose_and_image_quality_category(context);
        IEnumerable<CqlCode> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Observation CTScanResult)
        {
            DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = CTScanResult?.Effective;
            object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.End(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "day");
            Patient izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Patient(context);
            Date izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.BirthDateElement;
            string izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertStringToDateTime(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            int? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.CalculateAgeAt(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, "year");
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.GreaterOrEqual(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, 18);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Patients with Qualifying CTScan with Values")]
    public IEnumerable<Observation> Patients_with_Qualifying_CTScan_with_Values(CqlContext context)
    {
        IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Patients_with_Qualifying_CTScan(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Observation CTScan)
        {
            decimal? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = AlaraCommonFunctions_1_5_000.Instance.Global_Noise_Value(context, CTScan);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ is null));
            decimal? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = AlaraCommonFunctions_1_5_000.Instance.Size_Adjusted_Value(context, CTScan);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ is null));
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = CTScan?.Value;
            object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ is null));
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Observation>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Patients_with_Qualifying_CTScan(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Observation>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Patients_with_Qualifying_CTScan_with_Values(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<Observation>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusion")]
    public bool? Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Patients_with_Qualifying_CTScan_with_Values(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Observation CTScan)
        {
            DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = CTScan?.Value;
            object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlCode[] jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as CqlConcept)?.codes;
            CqlCode jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Full_Body(context);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Patients_with_Qualifying_CTScan_with_Values(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation CTScan)
        {
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = AlaraCommonFunctions_1_5_000.Instance.CT_Scan_Qualifies(context, CTScan);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    #endregion Expressions

}
