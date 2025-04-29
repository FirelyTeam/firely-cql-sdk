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

    #region ValueSet: Diabetes
    [CqlValueSetDefinition(
        definitionName: "Diabetes",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Diabetes(CqlContext context) => _Diabetes;

    private static readonly CqlValueSet _Diabetes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", null);
    #endregion

    #region ValueSet: HbA1c Laboratory Test
    [CqlValueSetDefinition(
        definitionName: "HbA1c Laboratory Test",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1013",
        valueSetVersion: null)]
    public CqlValueSet HbA1c_Laboratory_Test(CqlContext context) => _HbA1c_Laboratory_Test;

    private static readonly CqlValueSet _HbA1c_Laboratory_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1013", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Glucose management indicator
    [CqlCodeDefinition(
        definitionName: "Glucose management indicator",
        codeId: "97506-0",
        codeSystem: "http://loinc.org")]
    public CqlCode Glucose_management_indicator(CqlContext context) => _Glucose_management_indicator;

    private static readonly CqlCode _Glucose_management_indicator = new CqlCode("97506-0", "http://loinc.org", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = [
            new CqlCode("97506-0", "http://loinc.org", default, default),
        ];

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, true, true);
        object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.ResolveParameter("DiabetesGlycemicStatusAssessmentGreaterThan9PercentFHIR-0.1.002", "Measurement Period", ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return (CqlInterval<CqlDateTime>)ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SingletonFrom<Patient>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Patient(context);
        Date fzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.BirthDateElement;
        string fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
        CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertStringToDate(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
        CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.End(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        int? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.CalculateAgeAt(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "year");
        CqlInterval<int?> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(18, 75, true, true);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<int?>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = AdultOutpatientEncounters_4_11_000.Instance.Qualifying_Encounters(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Diabetes(context);
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Condition Diabetes)
        {
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Diabetes);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Overlaps(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "day");

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Initial_Population(context);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Or(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Or(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Or(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Glycemic Status Assessment")]
    public IEnumerable<Observation> Glycemic_Status_Assessment(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.HbA1c_Laboratory_Test(context);
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        CqlCode gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Glucose_management_indicator(context);
        IEnumerable<CqlCode> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ToList<CqlCode>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = Status_1_8_000.Instance.isLaboratoryTestPerformed(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Observation GlycemicStatus)
        {
            object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_()
            {
                bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_()
                {
                    DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = GlycemicStatus?.Effective;
                    object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                    bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ is CqlDateTime;

                    return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
                };
                bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_()
                {
                    DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = GlycemicStatus?.Effective;
                    object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                    bool hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ is CqlInterval<CqlDateTime>;

                    return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
                };
                bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_()
                {
                    DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = GlycemicStatus?.Effective;
                    object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                    bool hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ is CqlDateTime;

                    return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
                };
                if (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_())
                {
                    DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = GlycemicStatus?.Effective;
                    object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                    return (hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as CqlDateTime) as object;
                }
                else if (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_())
                {
                    DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = GlycemicStatus?.Effective;
                    object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                    return (hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_())
                {
                    DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = GlycemicStatus?.Effective;
                    object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                    return (hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.latest(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_());
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "day");

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Most Recent Glycemic Status Date")]
    public CqlDate Most_Recent_Glycemic_Status_Date(CqlContext context)
    {
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Glycemic_Status_Assessment(context);
        CqlDate hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Observation QualifyingGlycemicStatus)
        {
            object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_()
            {
                bool hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_()
                {
                    DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QualifyingGlycemicStatus?.Effective;
                    object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                    bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ is CqlDateTime;

                    return izzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
                };
                bool hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_()
                {
                    DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QualifyingGlycemicStatus?.Effective;
                    object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                    bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ is CqlInterval<CqlDateTime>;

                    return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
                };
                bool hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_()
                {
                    DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QualifyingGlycemicStatus?.Effective;
                    object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                    bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ is CqlDateTime;

                    return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
                };
                if (hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_())
                {
                    DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QualifyingGlycemicStatus?.Effective;
                    object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                    return (izzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlDateTime) as object;
                }
                else if (hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_())
                {
                    DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QualifyingGlycemicStatus?.Effective;
                    object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                    return (izzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_())
                {
                    DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QualifyingGlycemicStatus?.Effective;
                    object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                    return (izzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.latest(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_());
            CqlDate hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Observation, CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Distinct<CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ListSort<CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDate hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Last<CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Lowest Glycemic Status Assessment Reading on Most Recent Day")]
    public Observation Lowest_Glycemic_Status_Assessment_Reading_on_Most_Recent_Day(CqlContext context)
    {
        IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Glycemic_Status_Assessment(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Observation QualifyingGlycemicStatus)
        {
            object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_()
            {
                bool jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_()
                {
                    DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QualifyingGlycemicStatus?.Effective;
                    object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                    bool jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is CqlDateTime;

                    return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                };
                bool jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_()
                {
                    DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QualifyingGlycemicStatus?.Effective;
                    object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                    bool jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is CqlInterval<CqlDateTime>;

                    return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                };
                bool jzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_()
                {
                    DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QualifyingGlycemicStatus?.Effective;
                    object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                    bool jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ is CqlDateTime;

                    return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
                };
                if (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_())
                {
                    DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QualifyingGlycemicStatus?.Effective;
                    object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                    return (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as CqlDateTime) as object;
                }
                else if (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_())
                {
                    DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QualifyingGlycemicStatus?.Effective;
                    object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

                    return (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_())
                {
                    DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QualifyingGlycemicStatus?.Effective;
                    object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                    return (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.latest(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_());
            CqlDate izzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Most_Recent_Glycemic_Status_Date(context);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertDateToDateTime(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SameAs(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "day");

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        (CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Observation QualifyingGlycemicStatus)
        {
            DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QualifyingGlycemicStatus?.Value;
            object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            (CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = (CqlTupleMetadata_FOBYUiHifSfYFYhEEQajgLbgF, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as CqlQuantity, QualifyingGlycemicStatus);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_((CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)? @this)
        {
            CqlQuantity jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.QualifyingGlycemicStatusValue;

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SortBy<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.First<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        Observation izzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.QualifyingGlycemicStatus;

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Most Recent Glycemic Status Assessment Without Result")]
    public bool? Has_Most_Recent_Glycemic_Status_Assessment_Without_Result(CqlContext context)
    {
        Observation jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Lowest_Glycemic_Status_Assessment_Reading_on_Most_Recent_Day(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ is null));
        DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
        object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, (bool?)(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ is null));

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Most Recent Elevated Glycemic Status Assessment")]
    public bool? Has_Most_Recent_Elevated_Glycemic_Status_Assessment(CqlContext context)
    {
        Observation kzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Lowest_Glycemic_Status_Assessment_Reading_on_Most_Recent_Day(context);
        DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
        object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        CqlQuantity kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(9m, "%");
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Greater(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlQuantity, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has No Record Of Glycemic Status Assessment")]
    public bool? Has_No_Record_Of_Glycemic_Status_Assessment(CqlContext context)
    {
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Glycemic_Status_Assessment(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Not(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Has_Most_Recent_Glycemic_Status_Assessment_Without_Result(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Has_Most_Recent_Elevated_Glycemic_Status_Assessment(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Or(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Has_No_Record_Of_Glycemic_Status_Assessment(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Or(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_FOBYUiHifSfYFYhEEQajgLbgF = new(
        [typeof(CqlQuantity), typeof(Observation)],
        ["QualifyingGlycemicStatusValue", "QualifyingGlycemicStatus"]);

    #endregion CqlTupleMetadata Properties

}
