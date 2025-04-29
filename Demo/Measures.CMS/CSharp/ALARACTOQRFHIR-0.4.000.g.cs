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
        CqlDateTime jzzzzzzzzzzzzzzzzzg_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime jzzzzzzzzzzzzzzzzzh_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(jzzzzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzzzzh_, true, true);
        object jzzzzzzzzzzzzzzzzzj_ = context.ResolveParameter("ALARACTOQRFHIR-0.4.000", "Measurement Period", jzzzzzzzzzzzzzzzzzi_);

        return (CqlInterval<CqlDateTime>)jzzzzzzzzzzzzzzzzzj_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> jzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient jzzzzzzzzzzzzzzzzzl_ = context.Operators.SingletonFrom<Patient>(jzzzzzzzzzzzzzzzzzk_);

        return jzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Qualified Scan")]
    public IEnumerable<Observation> Qualified_Scan(CqlContext context)
    {
        CqlCode jzzzzzzzzzzzzzzzzzm_ = this.CT_dose_and_image_quality_category(context);
        IEnumerable<CqlCode> jzzzzzzzzzzzzzzzzzn_ = context.Operators.ToList<CqlCode>(jzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, jzzzzzzzzzzzzzzzzzn_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? jzzzzzzzzzzzzzzzzzp_(Observation CTScan)
        {
            DataType jzzzzzzzzzzzzzzzzzr_ = CTScan?.Effective;
            object jzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzs_);
            CqlDateTime jzzzzzzzzzzzzzzzzzu_ = context.Operators.End(jzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
            bool? jzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzzzzzv_, "day");
            Patient jzzzzzzzzzzzzzzzzzx_ = this.Patient(context);
            Date jzzzzzzzzzzzzzzzzzy_ = jzzzzzzzzzzzzzzzzzx_?.BirthDateElement;
            string jzzzzzzzzzzzzzzzzzz_ = jzzzzzzzzzzzzzzzzzy_?.Value;
            CqlDate kzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertStringToDate(jzzzzzzzzzzzzzzzzzz_);
            CqlDateTime kzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzv_);
            CqlDate kzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzzzc_);
            int? kzzzzzzzzzzzzzzzzze_ = context.Operators.CalculateAgeAt(kzzzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzzzd_, "year");
            bool? kzzzzzzzzzzzzzzzzzf_ = context.Operators.GreaterOrEqual(kzzzzzzzzzzzzzzzzze_, 18);
            bool? kzzzzzzzzzzzzzzzzzg_ = context.Operators.And(jzzzzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzzzzf_);

            return kzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(jzzzzzzzzzzzzzzzzzo_, jzzzzzzzzzzzzzzzzzp_);

        return jzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Qualified Scan without Inpatient Encounter")]
    public IEnumerable<Observation> Qualified_Scan_without_Inpatient_Encounter(CqlContext context)
    {
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzh_ = this.Qualified_Scan(context);
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzj_(Observation QualifiedCTScan)
        {
            CqlValueSet kzzzzzzzzzzzzzzzzzm_ = this.Encounter_Inpatient(context);
            IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? kzzzzzzzzzzzzzzzzzo_(Encounter InpatientEncounter)
            {
                DataType kzzzzzzzzzzzzzzzzzs_ = QualifiedCTScan?.Effective;
                object kzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzt_);
                CqlDateTime kzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzu_);
                Period kzzzzzzzzzzzzzzzzzw_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzx_ as object);
                bool? kzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzzzv_, kzzzzzzzzzzzzzzzzzy_, default);

                return kzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzzzzn_, kzzzzzzzzzzzzzzzzzo_);
            Observation kzzzzzzzzzzzzzzzzzq_(Encounter InpatientEncounter) =>
                QualifiedCTScan;
            IEnumerable<Observation> kzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Encounter, Observation>(kzzzzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzzzzq_);

            return kzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzk_ = context.Operators.SelectMany<Observation, Observation>(kzzzzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzl_ = context.Operators.Except<Observation>(kzzzzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzzzzk_);

        return kzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Qualified Scan with Values")]
    public IEnumerable<Observation> Qualified_Scan_with_Values(CqlContext context)
    {
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzza_ = this.Qualified_Scan_without_Inpatient_Encounter(context);
        bool? lzzzzzzzzzzzzzzzzzb_(Observation CTScan)
        {
            decimal? lzzzzzzzzzzzzzzzzzd_ = AlaraCommonFunctions_1_5_000.Instance.Global_Noise_Value(context, CTScan);
            bool? lzzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzzzd_ is null));
            decimal? lzzzzzzzzzzzzzzzzzf_ = AlaraCommonFunctions_1_5_000.Instance.Size_Adjusted_Value(context, CTScan);
            bool? lzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzzzf_ is null));
            bool? lzzzzzzzzzzzzzzzzzh_ = context.Operators.And(lzzzzzzzzzzzzzzzzze_, lzzzzzzzzzzzzzzzzzg_);
            DataType lzzzzzzzzzzzzzzzzzi_ = CTScan?.Value;
            object lzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzi_);
            bool? lzzzzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzzzj_ is null));
            bool? lzzzzzzzzzzzzzzzzzl_ = context.Operators.And(lzzzzzzzzzzzzzzzzzh_, lzzzzzzzzzzzzzzzzzk_);

            return lzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(lzzzzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzzzzb_);

        return lzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Observation> Denominator(CqlContext context)
    {
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzm_ = this.Qualified_Scan_with_Values(context);

        return lzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public IEnumerable<Observation> Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzn_ = this.Qualified_Scan_with_Values(context);
        bool? lzzzzzzzzzzzzzzzzzo_(Observation CTScan)
        {
            DataType lzzzzzzzzzzzzzzzzzq_ = CTScan?.Value;
            object lzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzq_);
            CqlCode[] lzzzzzzzzzzzzzzzzzs_ = (lzzzzzzzzzzzzzzzzzr_ as CqlConcept)?.codes;
            CqlCode lzzzzzzzzzzzzzzzzzt_ = this.Full_Body(context);
            bool? lzzzzzzzzzzzzzzzzzu_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)lzzzzzzzzzzzzzzzzzs_, lzzzzzzzzzzzzzzzzzt_);

            return lzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(lzzzzzzzzzzzzzzzzzn_, lzzzzzzzzzzzzzzzzzo_);

        return lzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Observation> Initial_Population(CqlContext context)
    {
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzv_ = this.Qualified_Scan_without_Inpatient_Encounter(context);

        return lzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Observation> Numerator(CqlContext context)
    {
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzw_ = this.Qualified_Scan_with_Values(context);
        bool? lzzzzzzzzzzzzzzzzzx_(Observation CTScan)
        {
            bool? lzzzzzzzzzzzzzzzzzz_ = AlaraCommonFunctions_1_5_000.Instance.CT_Scan_Qualifies(context, CTScan);

            return lzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(lzzzzzzzzzzzzzzzzzw_, lzzzzzzzzzzzzzzzzzx_);

        return lzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? mzzzzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return mzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> mzzzzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return mzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? mzzzzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return mzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode mzzzzzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return mzzzzzzzzzzzzzzzzzd_;
    }


    #endregion Expressions

}
