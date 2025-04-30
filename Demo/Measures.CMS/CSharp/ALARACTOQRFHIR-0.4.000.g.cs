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
      new CqlCodeSystem("http://loinc.org", null, [
          _CT_dose_and_image_quality_category,
          _Full_Body]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzzzzzzzzzf_, fzzzzzzzzzzzzzzzzzzzzzzzzg_, true, true);
        object fzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.ResolveParameter("ALARACTOQRFHIR-0.4.000", "Measurement Period", fzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return (CqlInterval<CqlDateTime>)fzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> fzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient fzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SingletonFrom<Patient>(fzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Qualified Scan")]
    public IEnumerable<Observation> Qualified_Scan(CqlContext context)
    {
        CqlCode fzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.CT_dose_and_image_quality_category(context);
        IEnumerable<CqlCode> fzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ToList<CqlCode>(fzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, fzzzzzzzzzzzzzzzzzzzzzzzzm_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzo_(Observation CTScan)
        {
            DataType fzzzzzzzzzzzzzzzzzzzzzzzzq_ = CTScan?.Effective;
            object fzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.End(fzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzzzzzzzzzzu_, "day");
            Patient fzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Patient(context);
            Date fzzzzzzzzzzzzzzzzzzzzzzzzx_ = fzzzzzzzzzzzzzzzzzzzzzzzzw_?.BirthDateElement;
            string fzzzzzzzzzzzzzzzzzzzzzzzzy_ = fzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
            CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertStringToDate(fzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDate gzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzzzzzzzb_);
            int? gzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.CalculateAgeAt(fzzzzzzzzzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzzzzzzzzzc_, "year");
            bool? gzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.GreaterOrEqual(gzzzzzzzzzzzzzzzzzzzzzzzzd_, 18);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzv_, gzzzzzzzzzzzzzzzzzzzzzzzze_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Qualified Scan without Inpatient Encounter")]
    public IEnumerable<Observation> Qualified_Scan_without_Inpatient_Encounter(CqlContext context)
    {
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Qualified_Scan(context);
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation QualifiedCTScan)
        {
            CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Encounter_Inpatient(context);
            IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzn_(Encounter InpatientEncounter)
            {
                DataType gzzzzzzzzzzzzzzzzzzzzzzzzr_ = QualifiedCTScan?.Effective;
                object gzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzt_);
                Period gzzzzzzzzzzzzzzzzzzzzzzzzv_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzw_ as object);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzu_, gzzzzzzzzzzzzzzzzzzzzzzzzx_, default);

                return gzzzzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzzzzzzzzzzzm_, gzzzzzzzzzzzzzzzzzzzzzzzzn_);
            Observation gzzzzzzzzzzzzzzzzzzzzzzzzp_(Encounter InpatientEncounter) =>
                QualifiedCTScan;
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Encounter, Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<Observation, Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Except<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Qualified Scan with Values")]
    public IEnumerable<Observation> Qualified_Scan_with_Values(CqlContext context)
    {
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Qualified_Scan_without_Inpatient_Encounter(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzza_(Observation CTScan)
        {
            decimal? hzzzzzzzzzzzzzzzzzzzzzzzzc_ = AlaraCommonFunctions_1_5_000.Instance.Global_Noise_Value(context, CTScan);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzzzzzzzzzzc_ is null));
            decimal? hzzzzzzzzzzzzzzzzzzzzzzzze_ = AlaraCommonFunctions_1_5_000.Instance.Size_Adjusted_Value(context, CTScan);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzzzzzzzzzze_ is null));
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzzzzzzzzzzzzf_);
            DataType hzzzzzzzzzzzzzzzzzzzzzzzzh_ = CTScan?.Value;
            object hzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzzzzzzzzzzi_ is null));
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return hzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzz_, hzzzzzzzzzzzzzzzzzzzzzzzza_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Observation> Denominator(CqlContext context)
    {
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Qualified_Scan_with_Values(context);

        return hzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public IEnumerable<Observation> Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Qualified_Scan_with_Values(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzn_(Observation CTScan)
        {
            DataType hzzzzzzzzzzzzzzzzzzzzzzzzp_ = CTScan?.Value;
            object hzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlCode[] hzzzzzzzzzzzzzzzzzzzzzzzzr_ = (hzzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlConcept)?.codes;
            CqlCode hzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Full_Body(context);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)hzzzzzzzzzzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return hzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Observation> Initial_Population(CqlContext context)
    {
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Qualified_Scan_without_Inpatient_Encounter(context);

        return hzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Observation> Numerator(CqlContext context)
    {
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Qualified_Scan_with_Values(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzw_(Observation CTScan)
        {
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzy_ = AlaraCommonFunctions_1_5_000.Instance.CT_Scan_Qualifies(context, CTScan);

            return hzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzv_, hzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? hzzzzzzzzzzzzzzzzzzzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return hzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> izzzzzzzzzzzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return izzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? izzzzzzzzzzzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return izzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode izzzzzzzzzzzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return izzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    #endregion Expressions

}
