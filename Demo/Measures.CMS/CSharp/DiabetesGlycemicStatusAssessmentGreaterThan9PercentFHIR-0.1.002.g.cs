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
    private static readonly CqlCode _Glucose_management_indicator = new CqlCode("97506-0", "http://loinc.org");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null,
          _Glucose_management_indicator);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, true, true);
        object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.ResolveParameter("DiabetesGlycemicStatusAssessmentGreaterThan9PercentFHIR-0.1.002", "Measurement Period", mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return (CqlInterval<CqlDateTime>)nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SingletonFrom<Patient>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Patient(context);
        Date nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.BirthDateElement;
        string nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
        CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertStringToDate(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
        CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.End(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        int? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.CalculateAgeAt(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "year");
        CqlInterval<int?> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(18, 75, true, true);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<int?>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = AdultOutpatientEncounters_4_11_000.Instance.Qualifying_Encounters(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Diabetes(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Condition Diabetes)
        {
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Diabetes);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Measurement_Period(context);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Overlaps(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "day");

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Initial_Population(context);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Or(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Or(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Or(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Glycemic Status Assessment")]
    public IEnumerable<Observation> Glycemic_Status_Assessment(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.HbA1c_Laboratory_Test(context);
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        CqlCode ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Glucose_management_indicator(context);
        IEnumerable<CqlCode> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ToList<CqlCode>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Observation>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = Status_1_8_000.Instance.isLaboratoryTestPerformed(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Observation GlycemicStatus)
        {
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_()
            {
                bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_()
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = GlycemicStatus?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                    bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ is CqlDateTime;

                    return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
                };
                bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_()
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = GlycemicStatus?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                    bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ is CqlInterval<CqlDateTime>;

                    return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
                };
                bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_()
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = GlycemicStatus?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                    bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ is CqlDateTime;

                    return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
                };
                if (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_())
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = GlycemicStatus?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                    return (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as CqlDateTime) as object;
                }
                else if (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_())
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = GlycemicStatus?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                    return (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_())
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = GlycemicStatus?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                    return (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.latest(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_());
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "day");

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Observation>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Most Recent Glycemic Status Date")]
    public CqlDate Most_Recent_Glycemic_Status_Date(CqlContext context)
    {
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Glycemic_Status_Assessment(context);
        CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Observation QualifyingGlycemicStatus)
        {
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_()
            {
                bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_()
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QualifyingGlycemicStatus?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                    bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                    return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                };
                bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_()
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QualifyingGlycemicStatus?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                    bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is CqlInterval<CqlDateTime>;

                    return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                };
                bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_()
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QualifyingGlycemicStatus?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                    bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is CqlDateTime;

                    return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                };
                if (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_())
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QualifyingGlycemicStatus?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                    return (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                }
                else if (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_())
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QualifyingGlycemicStatus?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                    return (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_())
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QualifyingGlycemicStatus?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                    return (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.latest(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_());
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Observation, CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ListSort<CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Last<CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Lowest Glycemic Status Assessment Reading on Most Recent Day")]
    public Observation Lowest_Glycemic_Status_Assessment_Reading_on_Most_Recent_Day(CqlContext context)
    {
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Glycemic_Status_Assessment(context);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Observation QualifyingGlycemicStatus)
        {
            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_()
            {
                bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_()
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QualifyingGlycemicStatus?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                    bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ is CqlDateTime;

                    return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
                };
                bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_()
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QualifyingGlycemicStatus?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                    bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ is CqlInterval<CqlDateTime>;

                    return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
                };
                bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_()
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QualifyingGlycemicStatus?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                    bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ is CqlDateTime;

                    return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
                };
                if (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_())
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QualifyingGlycemicStatus?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                    return (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlDateTime) as object;
                }
                else if (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_())
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QualifyingGlycemicStatus?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                    return (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_())
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QualifyingGlycemicStatus?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                    return (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.latest(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_());
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Most_Recent_Glycemic_Status_Date(context);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertDateToDateTime(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SameAs(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, "day");

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        (CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Observation QualifyingGlycemicStatus)
        {
            DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QualifyingGlycemicStatus?.Value;
            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            (CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = (CqlTupleMetadata_FOBYUiHifSfYFYhEEQajgLbgF, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as CqlQuantity, QualifyingGlycemicStatus);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Distinct<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_((CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)? @this)
        {
            CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.QualifyingGlycemicStatusValue;

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SortBy<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.First<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        Observation rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.QualifyingGlycemicStatus;

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Has Most Recent Glycemic Status Assessment Without Result")]
    public bool? Has_Most_Recent_Glycemic_Status_Assessment_Without_Result(CqlContext context)
    {
        Observation szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Lowest_Glycemic_Status_Assessment_Reading_on_Most_Recent_Day(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ is null));
        DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
        object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, (bool?)(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is null));

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Has Most Recent Elevated Glycemic Status Assessment")]
    public bool? Has_Most_Recent_Elevated_Glycemic_Status_Assessment(CqlContext context)
    {
        Observation szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Lowest_Glycemic_Status_Assessment_Reading_on_Most_Recent_Day(context);
        DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
        object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(9m, "%");
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Greater(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as CqlQuantity, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Has No Record Of Glycemic Status Assessment")]
    public bool? Has_No_Record_Of_Glycemic_Status_Assessment(CqlContext context)
    {
        IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Glycemic_Status_Assessment(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<Observation>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Not(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Has_Most_Recent_Glycemic_Status_Assessment_Without_Result(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Has_Most_Recent_Elevated_Glycemic_Status_Assessment(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Has_No_Record_Of_Glycemic_Status_Assessment(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_FOBYUiHifSfYFYhEEQajgLbgF = new(
        [typeof(CqlQuantity), typeof(Observation)],
        ["QualifyingGlycemicStatusValue", "QualifyingGlycemicStatus"]);

    #endregion CqlTupleMetadata Properties

}
