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
[CqlLibrary("AlaraCTIQRFHIR", "0.4.000")]
public partial class AlaraCTIQRFHIR_0_4_000 : ILibrary, ISingleton<AlaraCTIQRFHIR_0_4_000>
{
    private AlaraCTIQRFHIR_0_4_000() {}

    public static AlaraCTIQRFHIR_0_4_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "AlaraCTIQRFHIR";
    public string Version => "0.4.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, CQMCommon_2_2_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance, AlaraCommonFunctions_1_5_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    #endregion ValueSets

    #region Codes

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
        CqlDateTime uzzzzzzzzzzzzzq_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime uzzzzzzzzzzzzzr_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> uzzzzzzzzzzzzzs_ = context.Operators.Interval(uzzzzzzzzzzzzzq_, uzzzzzzzzzzzzzr_, true, true);
        object uzzzzzzzzzzzzzt_ = context.ResolveParameter("AlaraCTIQRFHIR-0.4.000", "Measurement Period", uzzzzzzzzzzzzzs_);

        return (CqlInterval<CqlDateTime>)uzzzzzzzzzzzzzt_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> uzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient uzzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<Patient>(uzzzzzzzzzzzzzu_);

        return uzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Qualifying Inpatient Encounters")]
    public IEnumerable<Encounter> Qualifying_Inpatient_Encounters(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzw_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? uzzzzzzzzzzzzzy_(Encounter InpatientEncounter)
        {
            Period vzzzzzzzzzzzzza_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
            bool? vzzzzzzzzzzzzzd_ = context.Operators.Overlaps(vzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzc_, default);
            Patient vzzzzzzzzzzzzze_ = this.Patient(context);
            Date vzzzzzzzzzzzzzf_ = vzzzzzzzzzzzzze_?.BirthDateElement;
            string vzzzzzzzzzzzzzg_ = vzzzzzzzzzzzzzf_?.Value;
            CqlDate vzzzzzzzzzzzzzh_ = context.Operators.ConvertStringToDate(vzzzzzzzzzzzzzg_);
            CqlDateTime vzzzzzzzzzzzzzj_ = context.Operators.Start(vzzzzzzzzzzzzzc_);
            CqlDate vzzzzzzzzzzzzzk_ = context.Operators.DateFrom(vzzzzzzzzzzzzzj_);
            int? vzzzzzzzzzzzzzl_ = context.Operators.CalculateAgeAt(vzzzzzzzzzzzzzh_, vzzzzzzzzzzzzzk_, "year");
            bool? vzzzzzzzzzzzzzm_ = context.Operators.GreaterOrEqual(vzzzzzzzzzzzzzl_, 18);
            bool? vzzzzzzzzzzzzzn_ = context.Operators.And(vzzzzzzzzzzzzzd_, vzzzzzzzzzzzzzm_);

            return vzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzy_);

        return uzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? vzzzzzzzzzzzzzo_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return vzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> vzzzzzzzzzzzzzp_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return vzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? vzzzzzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return vzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode vzzzzzzzzzzzzzr_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return vzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Qualifying Scan During Inpatient Encounter")]
    public IEnumerable<Observation> Qualifying_Scan_During_Inpatient_Encounter(CqlContext context)
    {
        CqlCode vzzzzzzzzzzzzzs_ = this.CT_dose_and_image_quality_category(context);
        IEnumerable<CqlCode> vzzzzzzzzzzzzzt_ = context.Operators.ToList<CqlCode>(vzzzzzzzzzzzzzs_);
        IEnumerable<Observation> vzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, vzzzzzzzzzzzzzt_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> vzzzzzzzzzzzzzv_(Observation CTScan)
        {
            IEnumerable<Encounter> vzzzzzzzzzzzzzx_ = this.Qualifying_Inpatient_Encounters(context);
            bool? vzzzzzzzzzzzzzy_(Encounter InpatientEncounters)
            {
                DataType wzzzzzzzzzzzzzc_ = CTScan?.Effective;
                object wzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.ToInterval(context, wzzzzzzzzzzzzzd_);
                CqlDateTime wzzzzzzzzzzzzzf_ = context.Operators.Start(wzzzzzzzzzzzzze_);
                Period wzzzzzzzzzzzzzg_ = InpatientEncounters?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzg_);
                bool? wzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzh_, default);
                object wzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.ToInterval(context, wzzzzzzzzzzzzzk_);
                CqlDateTime wzzzzzzzzzzzzzm_ = context.Operators.End(wzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
                bool? wzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzn_, "day");
                bool? wzzzzzzzzzzzzzp_ = context.Operators.And(wzzzzzzzzzzzzzi_, wzzzzzzzzzzzzzo_);

                return wzzzzzzzzzzzzzp_;
            };
            IEnumerable<Encounter> vzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(vzzzzzzzzzzzzzx_, vzzzzzzzzzzzzzy_);
            Observation wzzzzzzzzzzzzza_(Encounter InpatientEncounters) =>
                CTScan;
            IEnumerable<Observation> wzzzzzzzzzzzzzb_ = context.Operators.Select<Encounter, Observation>(vzzzzzzzzzzzzzz_, wzzzzzzzzzzzzza_);

            return wzzzzzzzzzzzzzb_;
        };
        IEnumerable<Observation> vzzzzzzzzzzzzzw_ = context.Operators.SelectMany<Observation, Observation>(vzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzv_);

        return vzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Qualifying Scan with Values")]
    public IEnumerable<Observation> Qualifying_Scan_with_Values(CqlContext context)
    {
        IEnumerable<Observation> wzzzzzzzzzzzzzq_ = this.Qualifying_Scan_During_Inpatient_Encounter(context);
        bool? wzzzzzzzzzzzzzr_(Observation CTScan)
        {
            decimal? wzzzzzzzzzzzzzt_ = AlaraCommonFunctions_1_5_000.Instance.Global_Noise_Value(context, CTScan);
            bool? wzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzt_ is null));
            decimal? wzzzzzzzzzzzzzv_ = AlaraCommonFunctions_1_5_000.Instance.Size_Adjusted_Value(context, CTScan);
            bool? wzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzv_ is null));
            bool? wzzzzzzzzzzzzzx_ = context.Operators.And(wzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzw_);
            DataType wzzzzzzzzzzzzzy_ = CTScan?.Value;
            object wzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzy_);
            bool? xzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzz_ is null));
            bool? xzzzzzzzzzzzzzb_ = context.Operators.And(wzzzzzzzzzzzzzx_, xzzzzzzzzzzzzza_);

            return xzzzzzzzzzzzzzb_;
        };
        IEnumerable<Observation> wzzzzzzzzzzzzzs_ = context.Operators.Where<Observation>(wzzzzzzzzzzzzzq_, wzzzzzzzzzzzzzr_);

        return wzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Observation> Numerator(CqlContext context)
    {
        IEnumerable<Observation> xzzzzzzzzzzzzzc_ = this.Qualifying_Scan_with_Values(context);
        bool? xzzzzzzzzzzzzzd_(Observation CTScan)
        {
            bool? xzzzzzzzzzzzzzf_ = AlaraCommonFunctions_1_5_000.Instance.CT_Scan_Qualifies(context, CTScan);

            return xzzzzzzzzzzzzzf_;
        };
        IEnumerable<Observation> xzzzzzzzzzzzzze_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzd_);

        return xzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Observation> Initial_Population(CqlContext context)
    {
        IEnumerable<Observation> xzzzzzzzzzzzzzg_ = this.Qualifying_Scan_During_Inpatient_Encounter(context);

        return xzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Observation> Denominator(CqlContext context)
    {
        IEnumerable<Observation> xzzzzzzzzzzzzzh_ = this.Qualifying_Scan_with_Values(context);

        return xzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public IEnumerable<Observation> Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Observation> xzzzzzzzzzzzzzi_ = this.Qualifying_Scan_with_Values(context);
        bool? xzzzzzzzzzzzzzj_(Observation CTScan)
        {
            DataType xzzzzzzzzzzzzzl_ = CTScan?.Value;
            object xzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzl_);
            CqlCode[] xzzzzzzzzzzzzzn_ = (xzzzzzzzzzzzzzm_ as CqlConcept)?.codes;
            CqlCode xzzzzzzzzzzzzzo_ = this.Full_Body(context);
            bool? xzzzzzzzzzzzzzp_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)xzzzzzzzzzzzzzn_, xzzzzzzzzzzzzzo_);

            return xzzzzzzzzzzzzzp_;
        };
        IEnumerable<Observation> xzzzzzzzzzzzzzk_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzj_);

        return xzzzzzzzzzzzzzk_;
    }


    #endregion Expressions

}
