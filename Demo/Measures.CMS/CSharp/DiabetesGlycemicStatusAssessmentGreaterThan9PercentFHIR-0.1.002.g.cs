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
        CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, true, true);
        object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.ResolveParameter("DiabetesGlycemicStatusAssessmentGreaterThan9PercentFHIR-0.1.002", "Measurement Period", xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return (CqlInterval<CqlDateTime>)xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SingletonFrom<Patient>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient yzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Patient(context);
        Date yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.BirthDateElement;
        string yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
        CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertStringToDate(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
        CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.End(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        int? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.CalculateAgeAt(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, "year");
        CqlInterval<int?> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(18, 75, true, true);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<int?>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = AdultOutpatientEncounters_4_11_000.Instance.Qualifying_Encounters(context);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Diabetes(context);
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Condition Diabetes)
        {
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Diabetes);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Overlaps(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "day");

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Condition>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Condition>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Initial_Population(context);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Glycemic Status Assessment")]
    public IEnumerable<Observation> Glycemic_Status_Assessment(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.HbA1c_Laboratory_Test(context);
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        CqlCode zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Glucose_management_indicator(context);
        IEnumerable<CqlCode> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ToList<CqlCode>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Observation>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = Status_1_8_000.Instance.isLaboratoryTestPerformed(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation GlycemicStatus)
        {
            object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_()
            {
                bool zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_()
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = GlycemicStatus?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                    bool azzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ is CqlDateTime;

                    return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
                };
                bool zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_()
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = GlycemicStatus?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                    bool azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ is CqlInterval<CqlDateTime>;

                    return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
                };
                bool zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_()
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = GlycemicStatus?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                    bool azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ is CqlDateTime;

                    return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
                };
                if (zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_())
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = GlycemicStatus?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                    return (azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlDateTime) as object;
                }
                else if (zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_())
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = GlycemicStatus?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                    return (azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_())
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = GlycemicStatus?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                    return (azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.latest(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_());
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "day");

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Most Recent Glycemic Status Date")]
    public CqlDate Most_Recent_Glycemic_Status_Date(CqlContext context)
    {
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Glycemic_Status_Assessment(context);
        CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Observation QualifyingGlycemicStatus)
        {
            object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_()
            {
                bool azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_()
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QualifyingGlycemicStatus?.Effective;
                    object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                    bool bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ is CqlDateTime;

                    return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                };
                bool azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_()
                {
                    DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QualifyingGlycemicStatus?.Effective;
                    object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                    bool bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlInterval<CqlDateTime>;

                    return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                };
                bool azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_()
                {
                    DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QualifyingGlycemicStatus?.Effective;
                    object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                    bool bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is CqlDateTime;

                    return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                };
                if (azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_())
                {
                    DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QualifyingGlycemicStatus?.Effective;
                    object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                    return (bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as CqlDateTime) as object;
                }
                else if (azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_())
                {
                    DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QualifyingGlycemicStatus?.Effective;
                    object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                    return (bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_())
                {
                    DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QualifyingGlycemicStatus?.Effective;
                    object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                    return (bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.latest(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_());
            CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Observation, CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ListSort<CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Last<CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Lowest Glycemic Status Assessment Reading on Most Recent Day")]
    public Observation Lowest_Glycemic_Status_Assessment_Reading_on_Most_Recent_Day(CqlContext context)
    {
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Glycemic_Status_Assessment(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation QualifyingGlycemicStatus)
        {
            object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_()
            {
                bool czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_()
                {
                    DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QualifyingGlycemicStatus?.Effective;
                    object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                    bool czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ is CqlDateTime;

                    return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
                };
                bool czzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_()
                {
                    DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QualifyingGlycemicStatus?.Effective;
                    object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                    bool czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ is CqlInterval<CqlDateTime>;

                    return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
                };
                bool czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_()
                {
                    DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QualifyingGlycemicStatus?.Effective;
                    object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                    bool czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ is CqlDateTime;

                    return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
                };
                if (czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_())
                {
                    DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QualifyingGlycemicStatus?.Effective;
                    object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                    return (czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlDateTime) as object;
                }
                else if (czzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_())
                {
                    DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QualifyingGlycemicStatus?.Effective;
                    object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

                    return (czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_())
                {
                    DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QualifyingGlycemicStatus?.Effective;
                    object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                    return (czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.latest(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_());
            CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Most_Recent_Glycemic_Status_Date(context);
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConvertDateToDateTime(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SameAs(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "day");

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        (CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Observation QualifyingGlycemicStatus)
        {
            DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QualifyingGlycemicStatus?.Value;
            object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            (CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = (CqlTupleMetadata_FOBYUiHifSfYFYhEEQajgLbgF, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlQuantity, QualifyingGlycemicStatus);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_((CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)? @this)
        {
            CqlQuantity czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = @this?.QualifyingGlycemicStatusValue;

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SortBy<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.First<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        Observation bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.QualifyingGlycemicStatus;

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Has Most Recent Glycemic Status Assessment Without Result")]
    public bool? Has_Most_Recent_Glycemic_Status_Assessment_Without_Result(CqlContext context)
    {
        Observation czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Lowest_Glycemic_Status_Assessment_Reading_on_Most_Recent_Day(context);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ is null));
        DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
        object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, (bool?)(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is null));

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Has Most Recent Elevated Glycemic Status Assessment")]
    public bool? Has_Most_Recent_Elevated_Glycemic_Status_Assessment(CqlContext context)
    {
        Observation dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Lowest_Glycemic_Status_Assessment_Reading_on_Most_Recent_Day(context);
        DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
        object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlQuantity dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(9m, "%");
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Greater(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as CqlQuantity, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Has No Record Of Glycemic Status Assessment")]
    public bool? Has_No_Record_Of_Glycemic_Status_Assessment(CqlContext context)
    {
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Glycemic_Status_Assessment(context);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Observation>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Has_Most_Recent_Glycemic_Status_Assessment_Without_Result(context);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Has_Most_Recent_Elevated_Glycemic_Status_Assessment(context);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Has_No_Record_Of_Glycemic_Status_Assessment(context);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_FOBYUiHifSfYFYhEEQajgLbgF = new(
        [typeof(CqlQuantity), typeof(Observation)],
        ["QualifyingGlycemicStatusValue", "QualifyingGlycemicStatus"]);

    #endregion CqlTupleMetadata Properties

}
