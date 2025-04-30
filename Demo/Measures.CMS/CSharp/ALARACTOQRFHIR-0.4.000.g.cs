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

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    #endregion ValueSets

    #region Codes

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
          _CT_dose_and_image_quality_category,
          _Full_Body);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(wzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, true, true);
        object wzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.ResolveParameter("ALARACTOQRFHIR-0.4.000", "Measurement Period", wzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return (CqlInterval<CqlDateTime>)wzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> wzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient wzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SingletonFrom<Patient>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Qualified Scan")]
    public IEnumerable<Observation> Qualified_Scan(CqlContext context)
    {
        CqlCode wzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.CT_dose_and_image_quality_category(context);
        IEnumerable<CqlCode> wzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ToList<CqlCode>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation CTScan)
        {
            DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = CTScan?.Effective;
            object wzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.End(wzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, "day");
            Patient wzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Patient(context);
            Date wzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.BirthDateElement;
            string wzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
            CqlDate xzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertStringToDate(wzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDate xzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            int? xzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.CalculateAgeAt(xzzzzzzzzzzzzzzzzzzzzzzzzzzza_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "year");
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.GreaterOrEqual(xzzzzzzzzzzzzzzzzzzzzzzzzzzze_, 18);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Qualified Scan without Inpatient Encounter")]
    public IEnumerable<Observation> Qualified_Scan_without_Inpatient_Encounter(CqlContext context)
    {
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Qualified_Scan(context);
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Observation QualifiedCTScan)
        {
            CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Encounter_Inpatient(context);
            IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Encounter InpatientEncounter)
            {
                DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QualifiedCTScan?.Effective;
                object xzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                Period xzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as object);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            Observation xzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Encounter InpatientEncounter) =>
                QualifiedCTScan;
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Encounter, Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SelectMany<Observation, Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Except<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Qualified Scan with Values")]
    public IEnumerable<Observation> Qualified_Scan_with_Values(CqlContext context)
    {
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Qualified_Scan_without_Inpatient_Encounter(context);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Observation CTScan)
        {
            decimal? yzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = AlaraCommonFunctions_1_5_000.Instance.Global_Noise_Value(context, CTScan);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is null));
            decimal? yzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = AlaraCommonFunctions_1_5_000.Instance.Size_Adjusted_Value(context, CTScan);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ is null));
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzze_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = CTScan?.Value;
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is null));
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Observation> Denominator(CqlContext context)
    {
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Qualified_Scan_with_Values(context);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public IEnumerable<Observation> Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Qualified_Scan_with_Values(context);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Observation CTScan)
        {
            DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = CTScan?.Value;
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlCode[] yzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = (yzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as CqlConcept)?.codes;
            CqlCode yzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Full_Body(context);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)yzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Observation> Initial_Population(CqlContext context)
    {
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Qualified_Scan_without_Inpatient_Encounter(context);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Observation> Numerator(CqlContext context)
    {
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Qualified_Scan_with_Values(context);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Observation CTScan)
        {
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = AlaraCommonFunctions_1_5_000.Instance.CT_Scan_Qualifies(context, CTScan);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? zzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> zzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? zzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode zzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    #endregion Expressions

}
