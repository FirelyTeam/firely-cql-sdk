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
        CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, true, true);
        object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.ResolveParameter("AlaraCTIQRFHIR-0.4.000", "Measurement Period", uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return (CqlInterval<CqlDateTime>)uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<Patient>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Qualifying Inpatient Encounters")]
    public IEnumerable<Encounter> Qualifying_Inpatient_Encounters(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Encounter InpatientEncounter)
        {
            Period vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Overlaps(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default);
            Patient vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Patient(context);
            Date vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.BirthDateElement;
            string vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConvertStringToDate(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            int? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.CalculateAgeAt(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "year");
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.GreaterOrEqual(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, 18);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Qualifying Scan During Inpatient Encounter")]
    public IEnumerable<Observation> Qualifying_Scan_During_Inpatient_Encounter(CqlContext context)
    {
        CqlCode vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.CT_dose_and_image_quality_category(context);
        IEnumerable<CqlCode> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ToList<CqlCode>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Observation CTScan)
        {
            IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Qualifying_Inpatient_Encounters(context);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Encounter InpatientEncounters)
            {
                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = CTScan?.Effective;
                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                Period wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = InpatientEncounters?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default);
                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.End(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, "day");
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            Observation wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Encounter InpatientEncounters) =>
                CTScan;
            IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<Encounter, Observation>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SelectMany<Observation, Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Qualifying Scan with Values")]
    public IEnumerable<Observation> Qualifying_Scan_with_Values(CqlContext context)
    {
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Qualifying_Scan_During_Inpatient_Encounter(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Observation CTScan)
        {
            decimal? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = AlaraCommonFunctions_1_5_000.Instance.Global_Noise_Value(context, CTScan);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is null));
            decimal? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = AlaraCommonFunctions_1_5_000.Instance.Size_Adjusted_Value(context, CTScan);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is null));
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = CTScan?.Value;
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ is null));
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Observation>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Observation> Numerator(CqlContext context)
    {
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Qualifying_Scan_with_Values(context);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Observation CTScan)
        {
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = AlaraCommonFunctions_1_5_000.Instance.CT_Scan_Qualifies(context, CTScan);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Observation> Initial_Population(CqlContext context)
    {
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Qualifying_Scan_During_Inpatient_Encounter(context);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Observation> Denominator(CqlContext context)
    {
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Qualifying_Scan_with_Values(context);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public IEnumerable<Observation> Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Qualifying_Scan_with_Values(context);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation CTScan)
        {
            DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = CTScan?.Value;
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlCode[] xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = (xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlConcept)?.codes;
            CqlCode xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Full_Body(context);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    #endregion Expressions

}
