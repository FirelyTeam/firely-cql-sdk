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
        CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(tzzzzzzzzzzzzzzzzzzzzzzzzc_, tzzzzzzzzzzzzzzzzzzzzzzzzd_, true, true);
        object tzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.ResolveParameter("AlaraCTIQRFHIR-0.4.000", "Measurement Period", tzzzzzzzzzzzzzzzzzzzzzzzze_);

        return (CqlInterval<CqlDateTime>)tzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> tzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient tzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SingletonFrom<Patient>(tzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Qualifying Inpatient Encounters")]
    public IEnumerable<Encounter> Qualifying_Inpatient_Encounters(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzk_(Encounter InpatientEncounter)
        {
            Period tzzzzzzzzzzzzzzzzzzzzzzzzm_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Overlaps(tzzzzzzzzzzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzzzzzzzzzzo_, default);
            Patient tzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Patient(context);
            Date tzzzzzzzzzzzzzzzzzzzzzzzzr_ = tzzzzzzzzzzzzzzzzzzzzzzzzq_?.BirthDateElement;
            string tzzzzzzzzzzzzzzzzzzzzzzzzs_ = tzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConvertStringToDate(tzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzzzv_);
            int? tzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.CalculateAgeAt(tzzzzzzzzzzzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzzzzzzzzzzzw_, "year");
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.GreaterOrEqual(tzzzzzzzzzzzzzzzzzzzzzzzzx_, 18);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzp_, tzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzj_, tzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? uzzzzzzzzzzzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return uzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> uzzzzzzzzzzzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return uzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? uzzzzzzzzzzzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return uzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode uzzzzzzzzzzzzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return uzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Qualifying Scan During Inpatient Encounter")]
    public IEnumerable<Observation> Qualifying_Scan_During_Inpatient_Encounter(CqlContext context)
    {
        CqlCode uzzzzzzzzzzzzzzzzzzzzzzzze_ = this.CT_dose_and_image_quality_category(context);
        IEnumerable<CqlCode> uzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ToList<CqlCode>(uzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, uzzzzzzzzzzzzzzzzzzzzzzzzf_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzh_(Observation CTScan)
        {
            IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Qualifying_Inpatient_Encounters(context);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzk_(Encounter InpatientEncounters)
            {
                DataType uzzzzzzzzzzzzzzzzzzzzzzzzo_ = CTScan?.Effective;
                object uzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzq_);
                Period uzzzzzzzzzzzzzzzzzzzzzzzzs_ = InpatientEncounters?.Period;
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzs_);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzzzzzzzzzzzzt_, default);
                object uzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.End(uzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzzzzzzzzzz_, "day");
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzzzzzzzzzza_);

                return vzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzzzzzzzzzzk_);
            Observation uzzzzzzzzzzzzzzzzzzzzzzzzm_(Encounter InpatientEncounters) =>
                CTScan;
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Encounter, Observation>(uzzzzzzzzzzzzzzzzzzzzzzzzl_, uzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SelectMany<Observation, Observation>(uzzzzzzzzzzzzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Qualifying Scan with Values")]
    public IEnumerable<Observation> Qualifying_Scan_with_Values(CqlContext context)
    {
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Qualifying_Scan_During_Inpatient_Encounter(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzd_(Observation CTScan)
        {
            decimal? vzzzzzzzzzzzzzzzzzzzzzzzzf_ = AlaraCommonFunctions_1_5_000.Instance.Global_Noise_Value(context, CTScan);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzzzzzzzzzzzzf_ is null));
            decimal? vzzzzzzzzzzzzzzzzzzzzzzzzh_ = AlaraCommonFunctions_1_5_000.Instance.Size_Adjusted_Value(context, CTScan);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzzzzzzzzzzzzh_ is null));
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzg_, vzzzzzzzzzzzzzzzzzzzzzzzzi_);
            DataType vzzzzzzzzzzzzzzzzzzzzzzzzk_ = CTScan?.Value;
            object vzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzzzzzzzzzzzzl_ is null));
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzj_, vzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return vzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Observation> Numerator(CqlContext context)
    {
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Qualifying_Scan_with_Values(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation CTScan)
        {
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzr_ = AlaraCommonFunctions_1_5_000.Instance.CT_Scan_Qualifies(context, CTScan);

            return vzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Observation> Initial_Population(CqlContext context)
    {
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Qualifying_Scan_During_Inpatient_Encounter(context);

        return vzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Observation> Denominator(CqlContext context)
    {
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Qualifying_Scan_with_Values(context);

        return vzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public IEnumerable<Observation> Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Qualifying_Scan_with_Values(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzv_(Observation CTScan)
        {
            DataType vzzzzzzzzzzzzzzzzzzzzzzzzx_ = CTScan?.Value;
            object vzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlCode[] vzzzzzzzzzzzzzzzzzzzzzzzzz_ = (vzzzzzzzzzzzzzzzzzzzzzzzzy_ as CqlConcept)?.codes;
            CqlCode wzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Full_Body(context);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)vzzzzzzzzzzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzzzzzzzzzzza_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    #endregion Expressions

}
