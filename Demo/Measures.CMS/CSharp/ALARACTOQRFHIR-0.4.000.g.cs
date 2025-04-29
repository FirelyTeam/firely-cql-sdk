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
[CqlLibrary("ALARACTOQRFHIR", "0.4.000")]
public partial class ALARACTOQRFHIR_0_4_000 : ILibrary, ISingleton<ALARACTOQRFHIR_0_4_000>
{
    private ALARACTOQRFHIR_0_4_000() {}

    public static ALARACTOQRFHIR_0_4_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "ALARACTOQRFHIR";
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
        CqlCode[] tzzzzzzzzzzzzt_ = [
            new CqlCode("96914-7", "http://loinc.org", default, default),
            new CqlCode("LA31771-1", "http://loinc.org", default, default),
        ];

        return tzzzzzzzzzzzzt_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime tzzzzzzzzzzzzu_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime tzzzzzzzzzzzzv_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> tzzzzzzzzzzzzw_ = context.Operators.Interval(tzzzzzzzzzzzzu_, tzzzzzzzzzzzzv_, true, true);
        object tzzzzzzzzzzzzx_ = context.ResolveParameter("ALARACTOQRFHIR-0.4.000", "Measurement Period", tzzzzzzzzzzzzw_);

        return (CqlInterval<CqlDateTime>)tzzzzzzzzzzzzx_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> tzzzzzzzzzzzzy_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient tzzzzzzzzzzzzz_ = context.Operators.SingletonFrom<Patient>(tzzzzzzzzzzzzy_);

        return tzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualified Scan")]
    public IEnumerable<Observation> Qualified_Scan(CqlContext context)
    {
        CqlCode uzzzzzzzzzzzza_ = this.CT_dose_and_image_quality_category(context);
        IEnumerable<CqlCode> uzzzzzzzzzzzzb_ = context.Operators.ToList<CqlCode>(uzzzzzzzzzzzza_);
        IEnumerable<Observation> uzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, uzzzzzzzzzzzzb_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? uzzzzzzzzzzzzd_(Observation CTScan)
        {
            DataType uzzzzzzzzzzzzf_ = CTScan?.Effective;
            object uzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.ToInterval(context, uzzzzzzzzzzzzg_);
            CqlDateTime uzzzzzzzzzzzzi_ = context.Operators.End(uzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            bool? uzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzi_, uzzzzzzzzzzzzj_, "day");
            Patient uzzzzzzzzzzzzl_ = this.Patient(context);
            Date uzzzzzzzzzzzzm_ = uzzzzzzzzzzzzl_?.BirthDateElement;
            string uzzzzzzzzzzzzn_ = uzzzzzzzzzzzzm_?.Value;
            CqlDate uzzzzzzzzzzzzo_ = context.Operators.ConvertStringToDate(uzzzzzzzzzzzzn_);
            CqlDateTime uzzzzzzzzzzzzq_ = context.Operators.Start(uzzzzzzzzzzzzj_);
            CqlDate uzzzzzzzzzzzzr_ = context.Operators.DateFrom(uzzzzzzzzzzzzq_);
            int? uzzzzzzzzzzzzs_ = context.Operators.CalculateAgeAt(uzzzzzzzzzzzzo_, uzzzzzzzzzzzzr_, "year");
            bool? uzzzzzzzzzzzzt_ = context.Operators.GreaterOrEqual(uzzzzzzzzzzzzs_, 18);
            bool? uzzzzzzzzzzzzu_ = context.Operators.And(uzzzzzzzzzzzzk_, uzzzzzzzzzzzzt_);

            return uzzzzzzzzzzzzu_;
        };
        IEnumerable<Observation> uzzzzzzzzzzzze_ = context.Operators.Where<Observation>(uzzzzzzzzzzzzc_, uzzzzzzzzzzzzd_);

        return uzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualified Scan without Inpatient Encounter")]
    public IEnumerable<Observation> Qualified_Scan_without_Inpatient_Encounter(CqlContext context)
    {
        IEnumerable<Observation> uzzzzzzzzzzzzv_ = this.Qualified_Scan(context);
        IEnumerable<Observation> uzzzzzzzzzzzzx_(Observation QualifiedCTScan)
        {
            CqlValueSet vzzzzzzzzzzzza_ = this.Encounter_Inpatient(context);
            IEnumerable<Encounter> vzzzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? vzzzzzzzzzzzzc_(Encounter InpatientEncounter)
            {
                DataType vzzzzzzzzzzzzg_ = QualifiedCTScan?.Effective;
                object vzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.ToInterval(context, vzzzzzzzzzzzzh_);
                CqlDateTime vzzzzzzzzzzzzj_ = context.Operators.Start(vzzzzzzzzzzzzi_);
                Period vzzzzzzzzzzzzk_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.ToInterval(context, vzzzzzzzzzzzzl_ as object);
                bool? vzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzj_, vzzzzzzzzzzzzm_, default);

                return vzzzzzzzzzzzzn_;
            };
            IEnumerable<Encounter> vzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(vzzzzzzzzzzzzb_, vzzzzzzzzzzzzc_);
            Observation vzzzzzzzzzzzze_(Encounter InpatientEncounter) =>
                QualifiedCTScan;
            IEnumerable<Observation> vzzzzzzzzzzzzf_ = context.Operators.Select<Encounter, Observation>(vzzzzzzzzzzzzd_, vzzzzzzzzzzzze_);

            return vzzzzzzzzzzzzf_;
        };
        IEnumerable<Observation> uzzzzzzzzzzzzy_ = context.Operators.SelectMany<Observation, Observation>(uzzzzzzzzzzzzv_, uzzzzzzzzzzzzx_);
        IEnumerable<Observation> uzzzzzzzzzzzzz_ = context.Operators.Except<Observation>(uzzzzzzzzzzzzv_, uzzzzzzzzzzzzy_);

        return uzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualified Scan with Values")]
    public IEnumerable<Observation> Qualified_Scan_with_Values(CqlContext context)
    {
        IEnumerable<Observation> vzzzzzzzzzzzzo_ = this.Qualified_Scan_without_Inpatient_Encounter(context);
        bool? vzzzzzzzzzzzzp_(Observation CTScan)
        {
            decimal? vzzzzzzzzzzzzr_ = AlaraCommonFunctions_1_5_000.Instance.Global_Noise_Value(context, CTScan);
            bool? vzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzr_ is null));
            decimal? vzzzzzzzzzzzzt_ = AlaraCommonFunctions_1_5_000.Instance.Size_Adjusted_Value(context, CTScan);
            bool? vzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzt_ is null));
            bool? vzzzzzzzzzzzzv_ = context.Operators.And(vzzzzzzzzzzzzs_, vzzzzzzzzzzzzu_);
            DataType vzzzzzzzzzzzzw_ = CTScan?.Value;
            object vzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzw_);
            bool? vzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzx_ is null));
            bool? vzzzzzzzzzzzzz_ = context.Operators.And(vzzzzzzzzzzzzv_, vzzzzzzzzzzzzy_);

            return vzzzzzzzzzzzzz_;
        };
        IEnumerable<Observation> vzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzo_, vzzzzzzzzzzzzp_);

        return vzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public IEnumerable<Observation> Denominator(CqlContext context)
    {
        IEnumerable<Observation> wzzzzzzzzzzzza_ = this.Qualified_Scan_with_Values(context);

        return wzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusion")]
    public IEnumerable<Observation> Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Observation> wzzzzzzzzzzzzb_ = this.Qualified_Scan_with_Values(context);
        bool? wzzzzzzzzzzzzc_(Observation CTScan)
        {
            DataType wzzzzzzzzzzzze_ = CTScan?.Value;
            object wzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzze_);
            CqlCode[] wzzzzzzzzzzzzg_ = (wzzzzzzzzzzzzf_ as CqlConcept)?.codes;
            CqlCode wzzzzzzzzzzzzh_ = this.Full_Body(context);
            bool? wzzzzzzzzzzzzi_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)wzzzzzzzzzzzzg_, wzzzzzzzzzzzzh_);

            return wzzzzzzzzzzzzi_;
        };
        IEnumerable<Observation> wzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(wzzzzzzzzzzzzb_, wzzzzzzzzzzzzc_);

        return wzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public IEnumerable<Observation> Initial_Population(CqlContext context)
    {
        IEnumerable<Observation> wzzzzzzzzzzzzj_ = this.Qualified_Scan_without_Inpatient_Encounter(context);

        return wzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public IEnumerable<Observation> Numerator(CqlContext context)
    {
        IEnumerable<Observation> wzzzzzzzzzzzzk_ = this.Qualified_Scan_with_Values(context);
        bool? wzzzzzzzzzzzzl_(Observation CTScan)
        {
            bool? wzzzzzzzzzzzzn_ = AlaraCommonFunctions_1_5_000.Instance.CT_Scan_Qualifies(context, CTScan);

            return wzzzzzzzzzzzzn_;
        };
        IEnumerable<Observation> wzzzzzzzzzzzzm_ = context.Operators.Where<Observation>(wzzzzzzzzzzzzk_, wzzzzzzzzzzzzl_);

        return wzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? wzzzzzzzzzzzzo_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return wzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> wzzzzzzzzzzzzp_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return wzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? wzzzzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return wzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode wzzzzzzzzzzzzr_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return wzzzzzzzzzzzzr_;
    }


    #endregion Expressions

}
