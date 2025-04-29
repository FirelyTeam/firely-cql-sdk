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

    #region ValueSet: Encounter Inpatient
    [CqlValueSetDefinition(
        definitionName: "Encounter Inpatient",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307",
        valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext context) => _Encounter_Inpatient;

    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);
    #endregion

    #endregion ValueSets

    #region Codes

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
        CqlCode[] izzzzzzzzzzzzzw_ = [
            new CqlCode("96914-7", "http://loinc.org", default, default),
            new CqlCode("LA31771-1", "http://loinc.org", default, default),
        ];

        return izzzzzzzzzzzzzw_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime izzzzzzzzzzzzzx_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime izzzzzzzzzzzzzy_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> izzzzzzzzzzzzzz_ = context.Operators.Interval(izzzzzzzzzzzzzx_, izzzzzzzzzzzzzy_, true, true);
        object jzzzzzzzzzzzzza_ = context.ResolveParameter("AlaraCTIQRFHIR-0.4.000", "Measurement Period", izzzzzzzzzzzzzz_);

        return (CqlInterval<CqlDateTime>)jzzzzzzzzzzzzza_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> jzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient jzzzzzzzzzzzzzc_ = context.Operators.SingletonFrom<Patient>(jzzzzzzzzzzzzzb_);

        return jzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Inpatient Encounters")]
    public IEnumerable<Encounter> Qualifying_Inpatient_Encounters(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzd_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? jzzzzzzzzzzzzzf_(Encounter InpatientEncounter)
        {
            Period jzzzzzzzzzzzzzh_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            bool? jzzzzzzzzzzzzzk_ = context.Operators.Overlaps(jzzzzzzzzzzzzzi_, jzzzzzzzzzzzzzj_, default);
            Patient jzzzzzzzzzzzzzl_ = this.Patient(context);
            Date jzzzzzzzzzzzzzm_ = jzzzzzzzzzzzzzl_?.BirthDateElement;
            string jzzzzzzzzzzzzzn_ = jzzzzzzzzzzzzzm_?.Value;
            CqlDate jzzzzzzzzzzzzzo_ = context.Operators.ConvertStringToDate(jzzzzzzzzzzzzzn_);
            CqlDateTime jzzzzzzzzzzzzzq_ = context.Operators.Start(jzzzzzzzzzzzzzj_);
            CqlDate jzzzzzzzzzzzzzr_ = context.Operators.DateFrom(jzzzzzzzzzzzzzq_);
            int? jzzzzzzzzzzzzzs_ = context.Operators.CalculateAgeAt(jzzzzzzzzzzzzzo_, jzzzzzzzzzzzzzr_, "year");
            bool? jzzzzzzzzzzzzzt_ = context.Operators.GreaterOrEqual(jzzzzzzzzzzzzzs_, 18);
            bool? jzzzzzzzzzzzzzu_ = context.Operators.And(jzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzt_);

            return jzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzze_, jzzzzzzzzzzzzzf_);

        return jzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? jzzzzzzzzzzzzzv_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return jzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> jzzzzzzzzzzzzzw_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return jzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? jzzzzzzzzzzzzzx_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return jzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode jzzzzzzzzzzzzzy_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return jzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Scan During Inpatient Encounter")]
    public IEnumerable<Observation> Qualifying_Scan_During_Inpatient_Encounter(CqlContext context)
    {
        CqlCode jzzzzzzzzzzzzzz_ = this.CT_dose_and_image_quality_category(context);
        IEnumerable<CqlCode> kzzzzzzzzzzzzza_ = context.Operators.ToList<CqlCode>(jzzzzzzzzzzzzzz_);
        IEnumerable<Observation> kzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, kzzzzzzzzzzzzza_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> kzzzzzzzzzzzzzc_(Observation CTScan)
        {
            IEnumerable<Encounter> kzzzzzzzzzzzzze_ = this.Qualifying_Inpatient_Encounters(context);
            bool? kzzzzzzzzzzzzzf_(Encounter InpatientEncounters)
            {
                DataType kzzzzzzzzzzzzzj_ = CTScan?.Effective;
                object kzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.ToInterval(context, kzzzzzzzzzzzzzk_);
                CqlDateTime kzzzzzzzzzzzzzm_ = context.Operators.Start(kzzzzzzzzzzzzzl_);
                Period kzzzzzzzzzzzzzn_ = InpatientEncounters?.Period;
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzn_);
                bool? kzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzo_, default);
                object kzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.ToInterval(context, kzzzzzzzzzzzzzr_);
                CqlDateTime kzzzzzzzzzzzzzt_ = context.Operators.End(kzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
                bool? kzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzt_, kzzzzzzzzzzzzzu_, "day");
                bool? kzzzzzzzzzzzzzw_ = context.Operators.And(kzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzv_);

                return kzzzzzzzzzzzzzw_;
            };
            IEnumerable<Encounter> kzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzze_, kzzzzzzzzzzzzzf_);
            Observation kzzzzzzzzzzzzzh_(Encounter InpatientEncounters) =>
                CTScan;
            IEnumerable<Observation> kzzzzzzzzzzzzzi_ = context.Operators.Select<Encounter, Observation>(kzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzh_);

            return kzzzzzzzzzzzzzi_;
        };
        IEnumerable<Observation> kzzzzzzzzzzzzzd_ = context.Operators.SelectMany<Observation, Observation>(kzzzzzzzzzzzzzb_, kzzzzzzzzzzzzzc_);

        return kzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Scan with Values")]
    public IEnumerable<Observation> Qualifying_Scan_with_Values(CqlContext context)
    {
        IEnumerable<Observation> kzzzzzzzzzzzzzx_ = this.Qualifying_Scan_During_Inpatient_Encounter(context);
        bool? kzzzzzzzzzzzzzy_(Observation CTScan)
        {
            decimal? lzzzzzzzzzzzzza_ = AlaraCommonFunctions_1_5_000.Instance.Global_Noise_Value(context, CTScan);
            bool? lzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzza_ is null));
            decimal? lzzzzzzzzzzzzzc_ = AlaraCommonFunctions_1_5_000.Instance.Size_Adjusted_Value(context, CTScan);
            bool? lzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzc_ is null));
            bool? lzzzzzzzzzzzzze_ = context.Operators.And(lzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzd_);
            DataType lzzzzzzzzzzzzzf_ = CTScan?.Value;
            object lzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzf_);
            bool? lzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzg_ is null));
            bool? lzzzzzzzzzzzzzi_ = context.Operators.And(lzzzzzzzzzzzzze_, lzzzzzzzzzzzzzh_);

            return lzzzzzzzzzzzzzi_;
        };
        IEnumerable<Observation> kzzzzzzzzzzzzzz_ = context.Operators.Where<Observation>(kzzzzzzzzzzzzzx_, kzzzzzzzzzzzzzy_);

        return kzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public IEnumerable<Observation> Numerator(CqlContext context)
    {
        IEnumerable<Observation> lzzzzzzzzzzzzzj_ = this.Qualifying_Scan_with_Values(context);
        bool? lzzzzzzzzzzzzzk_(Observation CTScan)
        {
            bool? lzzzzzzzzzzzzzm_ = AlaraCommonFunctions_1_5_000.Instance.CT_Scan_Qualifies(context, CTScan);

            return lzzzzzzzzzzzzzm_;
        };
        IEnumerable<Observation> lzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(lzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzk_);

        return lzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public IEnumerable<Observation> Initial_Population(CqlContext context)
    {
        IEnumerable<Observation> lzzzzzzzzzzzzzn_ = this.Qualifying_Scan_During_Inpatient_Encounter(context);

        return lzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public IEnumerable<Observation> Denominator(CqlContext context)
    {
        IEnumerable<Observation> lzzzzzzzzzzzzzo_ = this.Qualifying_Scan_with_Values(context);

        return lzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusion")]
    public IEnumerable<Observation> Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Observation> lzzzzzzzzzzzzzp_ = this.Qualifying_Scan_with_Values(context);
        bool? lzzzzzzzzzzzzzq_(Observation CTScan)
        {
            DataType lzzzzzzzzzzzzzs_ = CTScan?.Value;
            object lzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzs_);
            CqlCode[] lzzzzzzzzzzzzzu_ = (lzzzzzzzzzzzzzt_ as CqlConcept)?.codes;
            CqlCode lzzzzzzzzzzzzzv_ = this.Full_Body(context);
            bool? lzzzzzzzzzzzzzw_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)lzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzv_);

            return lzzzzzzzzzzzzzw_;
        };
        IEnumerable<Observation> lzzzzzzzzzzzzzr_ = context.Operators.Where<Observation>(lzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzq_);

        return lzzzzzzzzzzzzzr_;
    }


    #endregion Expressions

}
