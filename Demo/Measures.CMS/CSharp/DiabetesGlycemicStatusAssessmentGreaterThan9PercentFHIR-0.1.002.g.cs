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
[CqlLibrary("DiabetesGlycemicStatusAssessmentGreaterThan9PercentFHIR", "0.1.002")]
public partial class DiabetesGlycemicStatusAssessmentGreaterThan9PercentFHIR_0_1_002 : ILibrary, ISingleton<DiabetesGlycemicStatusAssessmentGreaterThan9PercentFHIR_0_1_002>
{
    private DiabetesGlycemicStatusAssessmentGreaterThan9PercentFHIR_0_1_002() {}

    public static DiabetesGlycemicStatusAssessmentGreaterThan9PercentFHIR_0_1_002 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "DiabetesGlycemicStatusAssessmentGreaterThan9PercentFHIR";
    public string Version => "0.1.002";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance, Status_1_8_000.Instance, CumulativeMedicationDuration_4_1_000.Instance, AdultOutpatientEncounters_4_11_000.Instance, AdvancedIllnessandFrailty_1_16_000.Instance, Hospice_6_12_000.Instance, PalliativeCare_1_11_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Diabetes", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", valueSetVersion: null)]
    public CqlValueSet Diabetes(CqlContext _) => _Diabetes;
    private static readonly CqlValueSet _Diabetes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", null);

    [CqlValueSetDefinition("HbA1c Laboratory Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1013", valueSetVersion: null)]
    public CqlValueSet HbA1c_Laboratory_Test(CqlContext _) => _HbA1c_Laboratory_Test;
    private static readonly CqlValueSet _HbA1c_Laboratory_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1013", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Glucose management indicator", codeId: "97506-0", codeSystem: "http://loinc.org")]
    public CqlCode Glucose_management_indicator(CqlContext _) => _Glucose_management_indicator;
    private static readonly CqlCode _Glucose_management_indicator = new CqlCode("97506-0", "http://loinc.org", default, default);

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
        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzzzzzzf_, ozzzzzzzzzzzzzzzzzzzzzzg_, true, true);
        object ozzzzzzzzzzzzzzzzzzzzzzi_ = context.ResolveParameter("DiabetesGlycemicStatusAssessmentGreaterThan9PercentFHIR-0.1.002", "Measurement Period", ozzzzzzzzzzzzzzzzzzzzzzh_);

        return (CqlInterval<CqlDateTime>)ozzzzzzzzzzzzzzzzzzzzzzi_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ozzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient ozzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SingletonFrom<Patient>(ozzzzzzzzzzzzzzzzzzzzzzj_);

        return ozzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ozzzzzzzzzzzzzzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return ozzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> ozzzzzzzzzzzzzzzzzzzzzzm_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return ozzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ozzzzzzzzzzzzzzzzzzzzzzn_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return ozzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode ozzzzzzzzzzzzzzzzzzzzzzo_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return ozzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient ozzzzzzzzzzzzzzzzzzzzzzp_ = this.Patient(context);
        Date ozzzzzzzzzzzzzzzzzzzzzzq_ = ozzzzzzzzzzzzzzzzzzzzzzp_?.BirthDateElement;
        string ozzzzzzzzzzzzzzzzzzzzzzr_ = ozzzzzzzzzzzzzzzzzzzzzzq_?.Value;
        CqlDate ozzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertStringToDate(ozzzzzzzzzzzzzzzzzzzzzzr_);
        CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.End(ozzzzzzzzzzzzzzzzzzzzzzt_);
        CqlDate ozzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzu_);
        int? ozzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.CalculateAgeAt(ozzzzzzzzzzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzzzzzzzzzv_, "year");
        CqlInterval<int?> ozzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(18, 75, true, true);
        bool? ozzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<int?>(ozzzzzzzzzzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzzzzzzzzzx_, default);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzz_ = AdultOutpatientEncounters_4_11_000.Instance.Qualifying_Encounters(context);
        bool? pzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzz_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzzzza_);
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzc_ = this.Diabetes(context);
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? pzzzzzzzzzzzzzzzzzzzzzze_(Condition Diabetes)
        {
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Diabetes);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            bool? pzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Overlaps(pzzzzzzzzzzzzzzzzzzzzzzi_, pzzzzzzzzzzzzzzzzzzzzzzj_, "day");

            return pzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Condition>(pzzzzzzzzzzzzzzzzzzzzzzd_, pzzzzzzzzzzzzzzzzzzzzzze_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Condition>(pzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzzzzzzzzzg_);

        return pzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? pzzzzzzzzzzzzzzzzzzzzzzl_ = this.Initial_Population(context);

        return pzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? pzzzzzzzzzzzzzzzzzzzzzzm_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? pzzzzzzzzzzzzzzzzzzzzzzn_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(context);
        bool? pzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Or(pzzzzzzzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzp_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty(context);
        bool? pzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Or(pzzzzzzzzzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzr_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? pzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Or(pzzzzzzzzzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzzzzzzzzzr_);

        return pzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Glycemic Status Assessment")]
    public IEnumerable<Observation> Glycemic_Status_Assessment(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzt_ = this.HbA1c_Laboratory_Test(context);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        CqlCode pzzzzzzzzzzzzzzzzzzzzzzv_ = this.Glucose_management_indicator(context);
        IEnumerable<CqlCode> pzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ToList<CqlCode>(pzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, pzzzzzzzzzzzzzzzzzzzzzzw_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Observation>(pzzzzzzzzzzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzz_ = Status_1_8_000.Instance.isLaboratoryTestPerformed(context, pzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? qzzzzzzzzzzzzzzzzzzzzzza_(Observation GlycemicStatus)
        {
            object qzzzzzzzzzzzzzzzzzzzzzzc_()
            {
                bool qzzzzzzzzzzzzzzzzzzzzzzg_()
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzzzj_ = GlycemicStatus?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzj_);
                    bool qzzzzzzzzzzzzzzzzzzzzzzl_ = qzzzzzzzzzzzzzzzzzzzzzzk_ is CqlDateTime;

                    return qzzzzzzzzzzzzzzzzzzzzzzl_;
                };
                bool qzzzzzzzzzzzzzzzzzzzzzzh_()
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzzzm_ = GlycemicStatus?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzm_);
                    bool qzzzzzzzzzzzzzzzzzzzzzzo_ = qzzzzzzzzzzzzzzzzzzzzzzn_ is CqlInterval<CqlDateTime>;

                    return qzzzzzzzzzzzzzzzzzzzzzzo_;
                };
                bool qzzzzzzzzzzzzzzzzzzzzzzi_()
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzzzp_ = GlycemicStatus?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzp_);
                    bool qzzzzzzzzzzzzzzzzzzzzzzr_ = qzzzzzzzzzzzzzzzzzzzzzzq_ is CqlDateTime;

                    return qzzzzzzzzzzzzzzzzzzzzzzr_;
                };
                if (qzzzzzzzzzzzzzzzzzzzzzzg_())
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzzzs_ = GlycemicStatus?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzs_);

                    return (qzzzzzzzzzzzzzzzzzzzzzzt_ as CqlDateTime) as object;
                }
                else if (qzzzzzzzzzzzzzzzzzzzzzzh_())
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzzzu_ = GlycemicStatus?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzu_);

                    return (qzzzzzzzzzzzzzzzzzzzzzzv_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (qzzzzzzzzzzzzzzzzzzzzzzi_())
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzzzw_ = GlycemicStatus?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzw_);

                    return (qzzzzzzzzzzzzzzzzzzzzzzx_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.latest(context, qzzzzzzzzzzzzzzzzzzzzzzc_());
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            bool? qzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzd_, qzzzzzzzzzzzzzzzzzzzzzze_, "day");

            return qzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzzzzzzzzza_);

        return qzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Most Recent Glycemic Status Date")]
    public CqlDate Most_Recent_Glycemic_Status_Date(CqlContext context)
    {
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzy_ = this.Glycemic_Status_Assessment(context);
        CqlDate qzzzzzzzzzzzzzzzzzzzzzzz_(Observation QualifyingGlycemicStatus)
        {
            object rzzzzzzzzzzzzzzzzzzzzzze_()
            {
                bool rzzzzzzzzzzzzzzzzzzzzzzh_()
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzzzk_ = QualifyingGlycemicStatus?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzk_);
                    bool rzzzzzzzzzzzzzzzzzzzzzzm_ = rzzzzzzzzzzzzzzzzzzzzzzl_ is CqlDateTime;

                    return rzzzzzzzzzzzzzzzzzzzzzzm_;
                };
                bool rzzzzzzzzzzzzzzzzzzzzzzi_()
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzzzn_ = QualifyingGlycemicStatus?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzn_);
                    bool rzzzzzzzzzzzzzzzzzzzzzzp_ = rzzzzzzzzzzzzzzzzzzzzzzo_ is CqlInterval<CqlDateTime>;

                    return rzzzzzzzzzzzzzzzzzzzzzzp_;
                };
                bool rzzzzzzzzzzzzzzzzzzzzzzj_()
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzzzq_ = QualifyingGlycemicStatus?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzq_);
                    bool rzzzzzzzzzzzzzzzzzzzzzzs_ = rzzzzzzzzzzzzzzzzzzzzzzr_ is CqlDateTime;

                    return rzzzzzzzzzzzzzzzzzzzzzzs_;
                };
                if (rzzzzzzzzzzzzzzzzzzzzzzh_())
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzzzt_ = QualifyingGlycemicStatus?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzt_);

                    return (rzzzzzzzzzzzzzzzzzzzzzzu_ as CqlDateTime) as object;
                }
                else if (rzzzzzzzzzzzzzzzzzzzzzzi_())
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzzzv_ = QualifyingGlycemicStatus?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzv_);

                    return (rzzzzzzzzzzzzzzzzzzzzzzw_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (rzzzzzzzzzzzzzzzzzzzzzzj_())
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzzzx_ = QualifyingGlycemicStatus?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzx_);

                    return (rzzzzzzzzzzzzzzzzzzzzzzy_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.latest(context, rzzzzzzzzzzzzzzzzzzzzzze_());
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzf_);

            return rzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<CqlDate> rzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Observation, CqlDate>(qzzzzzzzzzzzzzzzzzzzzzzy_, qzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<CqlDate> rzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Distinct<CqlDate>(rzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<CqlDate> rzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ListSort<CqlDate>(rzzzzzzzzzzzzzzzzzzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDate rzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Last<CqlDate>(rzzzzzzzzzzzzzzzzzzzzzzc_);

        return rzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Lowest Glycemic Status Assessment Reading on Most Recent Day")]
    public Observation Lowest_Glycemic_Status_Assessment_Reading_on_Most_Recent_Day(CqlContext context)
    {
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzz_ = this.Glycemic_Status_Assessment(context);
        bool? szzzzzzzzzzzzzzzzzzzzzza_(Observation QualifyingGlycemicStatus)
        {
            object szzzzzzzzzzzzzzzzzzzzzzj_()
            {
                bool szzzzzzzzzzzzzzzzzzzzzzo_()
                {
                    DataType szzzzzzzzzzzzzzzzzzzzzzr_ = QualifyingGlycemicStatus?.Effective;
                    object szzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzr_);
                    bool szzzzzzzzzzzzzzzzzzzzzzt_ = szzzzzzzzzzzzzzzzzzzzzzs_ is CqlDateTime;

                    return szzzzzzzzzzzzzzzzzzzzzzt_;
                };
                bool szzzzzzzzzzzzzzzzzzzzzzp_()
                {
                    DataType szzzzzzzzzzzzzzzzzzzzzzu_ = QualifyingGlycemicStatus?.Effective;
                    object szzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzu_);
                    bool szzzzzzzzzzzzzzzzzzzzzzw_ = szzzzzzzzzzzzzzzzzzzzzzv_ is CqlInterval<CqlDateTime>;

                    return szzzzzzzzzzzzzzzzzzzzzzw_;
                };
                bool szzzzzzzzzzzzzzzzzzzzzzq_()
                {
                    DataType szzzzzzzzzzzzzzzzzzzzzzx_ = QualifyingGlycemicStatus?.Effective;
                    object szzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzx_);
                    bool szzzzzzzzzzzzzzzzzzzzzzz_ = szzzzzzzzzzzzzzzzzzzzzzy_ is CqlDateTime;

                    return szzzzzzzzzzzzzzzzzzzzzzz_;
                };
                if (szzzzzzzzzzzzzzzzzzzzzzo_())
                {
                    DataType tzzzzzzzzzzzzzzzzzzzzzza_ = QualifyingGlycemicStatus?.Effective;
                    object tzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzza_);

                    return (tzzzzzzzzzzzzzzzzzzzzzzb_ as CqlDateTime) as object;
                }
                else if (szzzzzzzzzzzzzzzzzzzzzzp_())
                {
                    DataType tzzzzzzzzzzzzzzzzzzzzzzc_ = QualifyingGlycemicStatus?.Effective;
                    object tzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzc_);

                    return (tzzzzzzzzzzzzzzzzzzzzzzd_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (szzzzzzzzzzzzzzzzzzzzzzq_())
                {
                    DataType tzzzzzzzzzzzzzzzzzzzzzze_ = QualifyingGlycemicStatus?.Effective;
                    object tzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzze_);

                    return (tzzzzzzzzzzzzzzzzzzzzzzf_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.latest(context, szzzzzzzzzzzzzzzzzzzzzzj_());
            CqlDate szzzzzzzzzzzzzzzzzzzzzzl_ = this.Most_Recent_Glycemic_Status_Date(context);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConvertDateToDateTime(szzzzzzzzzzzzzzzzzzzzzzl_);
            bool? szzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SameAs(szzzzzzzzzzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzzzzzzzzzm_, "day");

            return szzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzzzzzzzzzzzz_, szzzzzzzzzzzzzzzzzzzzzza_);
        (CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)? szzzzzzzzzzzzzzzzzzzzzzc_(Observation QualifyingGlycemicStatus)
        {
            DataType tzzzzzzzzzzzzzzzzzzzzzzg_ = QualifyingGlycemicStatus?.Value;
            object tzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzg_);
            (CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)? tzzzzzzzzzzzzzzzzzzzzzzi_ = (CqlTupleMetadata_FOBYUiHifSfYFYhEEQajgLbgF, tzzzzzzzzzzzzzzzzzzzzzzh_ as CqlQuantity, QualifyingGlycemicStatus);

            return tzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?> szzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?>(szzzzzzzzzzzzzzzzzzzzzzb_, szzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?> szzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Distinct<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?>(szzzzzzzzzzzzzzzzzzzzzzd_);
        object szzzzzzzzzzzzzzzzzzzzzzf_((CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)? @this)
        {
            CqlQuantity tzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.QualifyingGlycemicStatusValue;

            return tzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?> szzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SortBy<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?>(szzzzzzzzzzzzzzzzzzzzzze_, szzzzzzzzzzzzzzzzzzzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)? szzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.First<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?>(szzzzzzzzzzzzzzzzzzzzzzg_);
        Observation szzzzzzzzzzzzzzzzzzzzzzi_ = szzzzzzzzzzzzzzzzzzzzzzh_?.QualifyingGlycemicStatus;

        return szzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Has Most Recent Glycemic Status Assessment Without Result")]
    public bool? Has_Most_Recent_Glycemic_Status_Assessment_Without_Result(CqlContext context)
    {
        Observation tzzzzzzzzzzzzzzzzzzzzzzk_ = this.Lowest_Glycemic_Status_Assessment_Reading_on_Most_Recent_Day(context);
        bool? tzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzzzzzzk_ is null));
        DataType tzzzzzzzzzzzzzzzzzzzzzzn_ = tzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
        object tzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzl_, (bool?)(tzzzzzzzzzzzzzzzzzzzzzzo_ is null));

        return tzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Has Most Recent Elevated Glycemic Status Assessment")]
    public bool? Has_Most_Recent_Elevated_Glycemic_Status_Assessment(CqlContext context)
    {
        Observation tzzzzzzzzzzzzzzzzzzzzzzq_ = this.Lowest_Glycemic_Status_Assessment_Reading_on_Most_Recent_Day(context);
        DataType tzzzzzzzzzzzzzzzzzzzzzzr_ = tzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
        object tzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzr_);
        CqlQuantity tzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(9m, "%");
        bool? tzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Greater(tzzzzzzzzzzzzzzzzzzzzzzs_ as CqlQuantity, tzzzzzzzzzzzzzzzzzzzzzzt_);

        return tzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Has No Record Of Glycemic Status Assessment")]
    public bool? Has_No_Record_Of_Glycemic_Status_Assessment(CqlContext context)
    {
        IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzzv_ = this.Glycemic_Status_Assessment(context);
        bool? tzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Observation>(tzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Not(tzzzzzzzzzzzzzzzzzzzzzzw_);

        return tzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? tzzzzzzzzzzzzzzzzzzzzzzy_ = this.Has_Most_Recent_Glycemic_Status_Assessment_Without_Result(context);
        bool? tzzzzzzzzzzzzzzzzzzzzzzz_ = this.Has_Most_Recent_Elevated_Glycemic_Status_Assessment(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Or(tzzzzzzzzzzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzb_ = this.Has_No_Record_Of_Glycemic_Status_Assessment(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Or(uzzzzzzzzzzzzzzzzzzzzzza_, uzzzzzzzzzzzzzzzzzzzzzzb_);

        return uzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_FOBYUiHifSfYFYhEEQajgLbgF = new(
        [typeof(CqlQuantity), typeof(Observation)],
        ["QualifyingGlycemicStatusValue", "QualifyingGlycemicStatus"]);

    #endregion CqlTupleMetadata Properties

}
