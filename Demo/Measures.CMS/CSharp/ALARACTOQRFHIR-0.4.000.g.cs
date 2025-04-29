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
        CqlDateTime ozzzzzzzzzzzzzzn_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime ozzzzzzzzzzzzzzo_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzp_ = context.Operators.Interval(ozzzzzzzzzzzzzzn_, ozzzzzzzzzzzzzzo_, true, true);
        object ozzzzzzzzzzzzzzq_ = context.ResolveParameter("ALARACTOQRFHIR-0.4.000", "Measurement Period", ozzzzzzzzzzzzzzp_);

        return (CqlInterval<CqlDateTime>)ozzzzzzzzzzzzzzq_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ozzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient ozzzzzzzzzzzzzzs_ = context.Operators.SingletonFrom<Patient>(ozzzzzzzzzzzzzzr_);

        return ozzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Qualified Scan")]
    public IEnumerable<Observation> Qualified_Scan(CqlContext context)
    {
        CqlCode ozzzzzzzzzzzzzzt_ = this.CT_dose_and_image_quality_category(context);
        IEnumerable<CqlCode> ozzzzzzzzzzzzzzu_ = context.Operators.ToList<CqlCode>(ozzzzzzzzzzzzzzt_);
        IEnumerable<Observation> ozzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ozzzzzzzzzzzzzzu_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? ozzzzzzzzzzzzzzw_(Observation CTScan)
        {
            DataType ozzzzzzzzzzzzzzy_ = CTScan?.Effective;
            object ozzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzz_);
            CqlDateTime pzzzzzzzzzzzzzzb_ = context.Operators.End(pzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
            bool? pzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzc_, "day");
            Patient pzzzzzzzzzzzzzze_ = this.Patient(context);
            Date pzzzzzzzzzzzzzzf_ = pzzzzzzzzzzzzzze_?.BirthDateElement;
            string pzzzzzzzzzzzzzzg_ = pzzzzzzzzzzzzzzf_?.Value;
            CqlDate pzzzzzzzzzzzzzzh_ = context.Operators.ConvertStringToDate(pzzzzzzzzzzzzzzg_);
            CqlDateTime pzzzzzzzzzzzzzzj_ = context.Operators.Start(pzzzzzzzzzzzzzzc_);
            CqlDate pzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzj_);
            int? pzzzzzzzzzzzzzzl_ = context.Operators.CalculateAgeAt(pzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzk_, "year");
            bool? pzzzzzzzzzzzzzzm_ = context.Operators.GreaterOrEqual(pzzzzzzzzzzzzzzl_, 18);
            bool? pzzzzzzzzzzzzzzn_ = context.Operators.And(pzzzzzzzzzzzzzzd_, pzzzzzzzzzzzzzzm_);

            return pzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Observation> ozzzzzzzzzzzzzzx_ = context.Operators.Where<Observation>(ozzzzzzzzzzzzzzv_, ozzzzzzzzzzzzzzw_);

        return ozzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Qualified Scan without Inpatient Encounter")]
    public IEnumerable<Observation> Qualified_Scan_without_Inpatient_Encounter(CqlContext context)
    {
        IEnumerable<Observation> pzzzzzzzzzzzzzzo_ = this.Qualified_Scan(context);
        IEnumerable<Observation> pzzzzzzzzzzzzzzq_(Observation QualifiedCTScan)
        {
            CqlValueSet pzzzzzzzzzzzzzzt_ = this.Encounter_Inpatient(context);
            IEnumerable<Encounter> pzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? pzzzzzzzzzzzzzzv_(Encounter InpatientEncounter)
            {
                DataType pzzzzzzzzzzzzzzz_ = QualifiedCTScan?.Effective;
                object qzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.ToInterval(context, qzzzzzzzzzzzzzza_);
                CqlDateTime qzzzzzzzzzzzzzzc_ = context.Operators.Start(qzzzzzzzzzzzzzzb_);
                Period qzzzzzzzzzzzzzzd_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.ToInterval(context, qzzzzzzzzzzzzzze_ as object);
                bool? qzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzf_, default);

                return qzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Encounter> pzzzzzzzzzzzzzzw_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzzv_);
            Observation pzzzzzzzzzzzzzzx_(Encounter InpatientEncounter) =>
                QualifiedCTScan;
            IEnumerable<Observation> pzzzzzzzzzzzzzzy_ = context.Operators.Select<Encounter, Observation>(pzzzzzzzzzzzzzzw_, pzzzzzzzzzzzzzzx_);

            return pzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Observation> pzzzzzzzzzzzzzzr_ = context.Operators.SelectMany<Observation, Observation>(pzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzq_);
        IEnumerable<Observation> pzzzzzzzzzzzzzzs_ = context.Operators.Except<Observation>(pzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzr_);

        return pzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Qualified Scan with Values")]
    public IEnumerable<Observation> Qualified_Scan_with_Values(CqlContext context)
    {
        IEnumerable<Observation> qzzzzzzzzzzzzzzh_ = this.Qualified_Scan_without_Inpatient_Encounter(context);
        bool? qzzzzzzzzzzzzzzi_(Observation CTScan)
        {
            decimal? qzzzzzzzzzzzzzzk_ = AlaraCommonFunctions_1_5_000.Instance.Global_Noise_Value(context, CTScan);
            bool? qzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzk_ is null));
            decimal? qzzzzzzzzzzzzzzm_ = AlaraCommonFunctions_1_5_000.Instance.Size_Adjusted_Value(context, CTScan);
            bool? qzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzm_ is null));
            bool? qzzzzzzzzzzzzzzo_ = context.Operators.And(qzzzzzzzzzzzzzzl_, qzzzzzzzzzzzzzzn_);
            DataType qzzzzzzzzzzzzzzp_ = CTScan?.Value;
            object qzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzp_);
            bool? qzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzq_ is null));
            bool? qzzzzzzzzzzzzzzs_ = context.Operators.And(qzzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzzr_);

            return qzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Observation> qzzzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzh_, qzzzzzzzzzzzzzzi_);

        return qzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Observation> Denominator(CqlContext context)
    {
        IEnumerable<Observation> qzzzzzzzzzzzzzzt_ = this.Qualified_Scan_with_Values(context);

        return qzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public IEnumerable<Observation> Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Observation> qzzzzzzzzzzzzzzu_ = this.Qualified_Scan_with_Values(context);
        bool? qzzzzzzzzzzzzzzv_(Observation CTScan)
        {
            DataType qzzzzzzzzzzzzzzx_ = CTScan?.Value;
            object qzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzx_);
            CqlCode[] qzzzzzzzzzzzzzzz_ = (qzzzzzzzzzzzzzzy_ as CqlConcept)?.codes;
            CqlCode rzzzzzzzzzzzzzza_ = this.Full_Body(context);
            bool? rzzzzzzzzzzzzzzb_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)qzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzza_);

            return rzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Observation> qzzzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzu_, qzzzzzzzzzzzzzzv_);

        return qzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Observation> Initial_Population(CqlContext context)
    {
        IEnumerable<Observation> rzzzzzzzzzzzzzzc_ = this.Qualified_Scan_without_Inpatient_Encounter(context);

        return rzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Observation> Numerator(CqlContext context)
    {
        IEnumerable<Observation> rzzzzzzzzzzzzzzd_ = this.Qualified_Scan_with_Values(context);
        bool? rzzzzzzzzzzzzzze_(Observation CTScan)
        {
            bool? rzzzzzzzzzzzzzzg_ = AlaraCommonFunctions_1_5_000.Instance.CT_Scan_Qualifies(context, CTScan);

            return rzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Observation> rzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzzzd_, rzzzzzzzzzzzzzze_);

        return rzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? rzzzzzzzzzzzzzzh_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return rzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> rzzzzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return rzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? rzzzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return rzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode rzzzzzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return rzzzzzzzzzzzzzzk_;
    }


    #endregion Expressions

}
