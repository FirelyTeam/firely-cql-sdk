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
[CqlLibrary("ProstateCaAvoidanceBoneScanOveruseFHIR", "0.3.000")]
public partial class ProstateCaAvoidanceBoneScanOveruseFHIR_0_3_000 : ILibrary, ISingleton<ProstateCaAvoidanceBoneScanOveruseFHIR_0_3_000>
{
    private ProstateCaAvoidanceBoneScanOveruseFHIR_0_3_000() {}

    public static ProstateCaAvoidanceBoneScanOveruseFHIR_0_3_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "ProstateCaAvoidanceBoneScanOveruseFHIR";
    public string Version => "0.3.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: Bone Scan
    [CqlValueSetDefinition(
        definitionName: "Bone Scan",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.320",
        valueSetVersion: null)]
    public CqlValueSet Bone_Scan(CqlContext context) => _Bone_Scan;

    private static readonly CqlValueSet _Bone_Scan = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.320", null);
    #endregion

    #region ValueSet: Pain Warranting Further Investigation for Prostate Cancer
    [CqlValueSetDefinition(
        definitionName: "Pain Warranting Further Investigation for Prostate Cancer",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.451",
        valueSetVersion: null)]
    public CqlValueSet Pain_Warranting_Further_Investigation_for_Prostate_Cancer(CqlContext context) => _Pain_Warranting_Further_Investigation_for_Prostate_Cancer;

    private static readonly CqlValueSet _Pain_Warranting_Further_Investigation_for_Prostate_Cancer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.451", null);
    #endregion

    #region ValueSet: Prostate Cancer
    [CqlValueSetDefinition(
        definitionName: "Prostate Cancer",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.319",
        valueSetVersion: null)]
    public CqlValueSet Prostate_Cancer(CqlContext context) => _Prostate_Cancer;

    private static readonly CqlValueSet _Prostate_Cancer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.319", null);
    #endregion

    #region ValueSet: Prostate Cancer Treatment
    [CqlValueSetDefinition(
        definitionName: "Prostate Cancer Treatment",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.398",
        valueSetVersion: null)]
    public CqlValueSet Prostate_Cancer_Treatment(CqlContext context) => _Prostate_Cancer_Treatment;

    private static readonly CqlValueSet _Prostate_Cancer_Treatment = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.398", null);
    #endregion

    #region ValueSet: Prostate Specific Antigen Test
    [CqlValueSetDefinition(
        definitionName: "Prostate Specific Antigen Test",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.401",
        valueSetVersion: null)]
    public CqlValueSet Prostate_Specific_Antigen_Test(CqlContext context) => _Prostate_Specific_Antigen_Test;

    private static readonly CqlValueSet _Prostate_Specific_Antigen_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.401", null);
    #endregion

    #region ValueSet: Salvage Therapy
    [CqlValueSetDefinition(
        definitionName: "Salvage Therapy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.399",
        valueSetVersion: null)]
    public CqlValueSet Salvage_Therapy(CqlContext context) => _Salvage_Therapy;

    private static readonly CqlValueSet _Salvage_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.399", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Gleason score in Specimen Qualitative
    [CqlCodeDefinition(
        definitionName: "Gleason score in Specimen Qualitative",
        codeId: "35266-6",
        codeSystem: "http://loinc.org")]
    public CqlCode Gleason_score_in_Specimen_Qualitative(CqlContext context) => _Gleason_score_in_Specimen_Qualitative;

    private static readonly CqlCode _Gleason_score_in_Specimen_Qualitative = new CqlCode("35266-6", "http://loinc.org", default, default);
    #endregion

    #region Code: Neoplasm of prostate primary tumor staging category T1c: Tumor identified by needle biopsy (finding)
    [CqlCodeDefinition(
        definitionName: "Neoplasm of prostate primary tumor staging category T1c: Tumor identified by needle biopsy (finding)",
        codeId: "433351000124101",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Neoplasm_of_prostate_primary_tumor_staging_category_T1c__Tumor_identified_by_needle_biopsy__finding_(CqlContext context) => _Neoplasm_of_prostate_primary_tumor_staging_category_T1c__Tumor_identified_by_needle_biopsy__finding_;

    private static readonly CqlCode _Neoplasm_of_prostate_primary_tumor_staging_category_T1c__Tumor_identified_by_needle_biopsy__finding_ = new CqlCode("433351000124101", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Neoplasm of prostate primary tumor staging category T2a: Involves one-half of one lobe or less (finding)
    [CqlCodeDefinition(
        definitionName: "Neoplasm of prostate primary tumor staging category T2a: Involves one-half of one lobe or less (finding)",
        codeId: "433361000124104",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Neoplasm_of_prostate_primary_tumor_staging_category_T2a__Involves_one_half_of_one_lobe_or_less__finding_(CqlContext context) => _Neoplasm_of_prostate_primary_tumor_staging_category_T2a__Involves_one_half_of_one_lobe_or_less__finding_;

    private static readonly CqlCode _Neoplasm_of_prostate_primary_tumor_staging_category_T2a__Involves_one_half_of_one_lobe_or_less__finding_ = new CqlCode("433361000124104", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Procedure reason record (record artifact)
    [CqlCodeDefinition(
        definitionName: "Procedure reason record (record artifact)",
        codeId: "433611000124109",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Procedure_reason_record__record_artifact_(CqlContext context) => _Procedure_reason_record__record_artifact_;

    private static readonly CqlCode _Procedure_reason_record__record_artifact_ = new CqlCode("433611000124109", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: T1a: Prostate tumor incidental histologic finding in 5 percent or less of tissue resected (finding)
    [CqlCodeDefinition(
        definitionName: "T1a: Prostate tumor incidental histologic finding in 5 percent or less of tissue resected (finding)",
        codeId: "369833007",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode T1a__Prostate_tumor_incidental_histologic_finding_in_5_percent_or_less_of_tissue_resected__finding_(CqlContext context) => _T1a__Prostate_tumor_incidental_histologic_finding_in_5_percent_or_less_of_tissue_resected__finding_;

    private static readonly CqlCode _T1a__Prostate_tumor_incidental_histologic_finding_in_5_percent_or_less_of_tissue_resected__finding_ = new CqlCode("369833007", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: T1b: Prostate tumor incidental histologic finding in greater than 5 percent of tissue resected (finding)
    [CqlCodeDefinition(
        definitionName: "T1b: Prostate tumor incidental histologic finding in greater than 5 percent of tissue resected (finding)",
        codeId: "369834001",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode T1b__Prostate_tumor_incidental_histologic_finding_in_greater_than_5_percent_of_tissue_resected__finding_(CqlContext context) => _T1b__Prostate_tumor_incidental_histologic_finding_in_greater_than_5_percent_of_tissue_resected__finding_;

    private static readonly CqlCode _T1b__Prostate_tumor_incidental_histologic_finding_in_greater_than_5_percent_of_tissue_resected__finding_ = new CqlCode("369834001", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Tumor staging (tumor staging)
    [CqlCodeDefinition(
        definitionName: "Tumor staging (tumor staging)",
        codeId: "254292007",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Tumor_staging__tumor_staging_(CqlContext context) => _Tumor_staging__tumor_staging_;

    private static readonly CqlCode _Tumor_staging__tumor_staging_ = new CqlCode("254292007", "http://snomed.info/sct", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] ezzzzzzzzzzzzzzzzzzzzzzzzv_ = [
            new CqlCode("35266-6", "http://loinc.org", default, default),
        ];

        return ezzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] ezzzzzzzzzzzzzzzzzzzzzzzzw_ = [
            new CqlCode("433351000124101", "http://snomed.info/sct", default, default),
            new CqlCode("433361000124104", "http://snomed.info/sct", default, default),
            new CqlCode("433611000124109", "http://snomed.info/sct", default, default),
            new CqlCode("369833007", "http://snomed.info/sct", default, default),
            new CqlCode("369834001", "http://snomed.info/sct", default, default),
            new CqlCode("254292007", "http://snomed.info/sct", default, default),
        ];

        return ezzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "UCUM")]
    public CqlCode[] UCUM(CqlContext context)
    {
        CqlCode[] ezzzzzzzzzzzzzzzzzzzzzzzzx_ = []
;

        return ezzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzzzzzzzzzy_, ezzzzzzzzzzzzzzzzzzzzzzzzz_, true, true);
        object fzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.ResolveParameter("ProstateCaAvoidanceBoneScanOveruseFHIR-0.3.000", "Measurement Period", fzzzzzzzzzzzzzzzzzzzzzzzza_);

        return (CqlInterval<CqlDateTime>)fzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> fzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient fzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SingletonFrom<Patient>(fzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? fzzzzzzzzzzzzzzzzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return fzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> fzzzzzzzzzzzzzzzzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return fzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? fzzzzzzzzzzzzzzzzzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return fzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode fzzzzzzzzzzzzzzzzzzzzzzzzh_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return fzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Prostate Cancer Diagnosis")]
    public IEnumerable<Condition> Prostate_Cancer_Diagnosis(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Prostate_Cancer(context);
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzk_(Condition ProstateCancer)
        {
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ProstateCancer);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Overlaps(fzzzzzzzzzzzzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzzzzzzzzzzzzn_, "day");
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, ProstateCancer);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, ProstateCancer);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(fzzzzzzzzzzzzzzzzzzzzzzzzp_, fzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzo_, fzzzzzzzzzzzzzzzzzzzzzzzzr_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzj_, fzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Prostate_Cancer_Diagnosis(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "First Prostate Cancer Treatment during day of Measurement Period")]
    public Procedure First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Prostate_Cancer_Treatment(context);
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzx_(Procedure ProstateCancerTreatment)
        {
            DataType gzzzzzzzzzzzzzzzzzzzzzzzzc_ = ProstateCancerTreatment?.Performed;
            object gzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.End(gzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzf_, gzzzzzzzzzzzzzzzzzzzzzzzzg_, "day");
            Code<EventStatus> gzzzzzzzzzzzzzzzzzzzzzzzzi_ = ProstateCancerTreatment?.StatusElement;
            EventStatus? gzzzzzzzzzzzzzzzzzzzzzzzzj_ = gzzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
            string gzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(gzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equal(gzzzzzzzzzzzzzzzzzzzzzzzzk_, "completed");
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Procedure>(fzzzzzzzzzzzzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzzzzzzzzzzzzx_);
        object fzzzzzzzzzzzzzzzzzzzzzzzzz_(Procedure @this)
        {
            DataType gzzzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.Performed;
            object gzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Procedure> gzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SortBy<Procedure>(fzzzzzzzzzzzzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzzzzzzzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
        Procedure gzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.First<Procedure>(gzzzzzzzzzzzzzzzzzzzzzzzza_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "Most Recent Prostate Cancer Staging Tumor Size T1a to T2a")]
    public Observation Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a(CqlContext context)
    {
        CqlCode gzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Tumor_staging__tumor_staging_(context);
        IEnumerable<CqlCode> gzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ToList<CqlCode>(gzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, gzzzzzzzzzzzzzzzzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzu_(Observation ProstateCancerStaging)
        {
            Procedure hzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period(context);
            Procedure[] hzzzzzzzzzzzzzzzzzzzzzzzze_ = [
                hzzzzzzzzzzzzzzzzzzzzzzzzd_,
            ];
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzf_(Procedure FirstProstateCancerTreatment)
            {
                DataType hzzzzzzzzzzzzzzzzzzzzzzzzj_ = ProstateCancerStaging?.Effective;
                object hzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzl_);
                DataType hzzzzzzzzzzzzzzzzzzzzzzzzn_ = FirstProstateCancerTreatment?.Performed;
                object hzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzp_);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Before(hzzzzzzzzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzzzzzzzzq_, default);
                Code<ObservationStatus> hzzzzzzzzzzzzzzzzzzzzzzzzs_ = ProstateCancerStaging?.StatusElement;
                ObservationStatus? hzzzzzzzzzzzzzzzzzzzzzzzzt_ = hzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
                Code<ObservationStatus> hzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<Code<ObservationStatus>>(hzzzzzzzzzzzzzzzzzzzzzzzzt_);
                string hzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(hzzzzzzzzzzzzzzzzzzzzzzzzu_);
                string[] hzzzzzzzzzzzzzzzzzzzzzzzzw_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<string>(hzzzzzzzzzzzzzzzzzzzzzzzzv_, hzzzzzzzzzzzzzzzzzzzzzzzzw_ as IEnumerable<string>);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzzzzzzzzzzx_);

                return hzzzzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)hzzzzzzzzzzzzzzzzzzzzzzzze_, hzzzzzzzzzzzzzzzzzzzzzzzzf_);
            Observation hzzzzzzzzzzzzzzzzzzzzzzzzh_(Procedure FirstProstateCancerTreatment) =>
                ProstateCancerStaging;
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<Procedure, Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzzzzzzzzzzh_);

            return hzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SelectMany<Observation, Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzt_, gzzzzzzzzzzzzzzzzzzzzzzzzu_);
        object gzzzzzzzzzzzzzzzzzzzzzzzzw_(Observation @this)
        {
            DataType hzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
            object izzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzb_);

            return izzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SortBy<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzv_, gzzzzzzzzzzzzzzzzzzzzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
        Observation gzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Last<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzx_);
        Observation[] gzzzzzzzzzzzzzzzzzzzzzzzzz_ = [
            gzzzzzzzzzzzzzzzzzzzzzzzzy_,
        ];
        bool? hzzzzzzzzzzzzzzzzzzzzzzzza_(Observation LastProstateCancerStaging)
        {
            DataType izzzzzzzzzzzzzzzzzzzzzzzzd_ = LastProstateCancerStaging?.Value;
            object izzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlCode izzzzzzzzzzzzzzzzzzzzzzzzf_ = this.T1a__Prostate_tumor_incidental_histologic_finding_in_5_percent_or_less_of_tissue_resected__finding_(context);
            CqlConcept izzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertCodeToConcept(izzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equivalent(izzzzzzzzzzzzzzzzzzzzzzzze_ as CqlConcept, izzzzzzzzzzzzzzzzzzzzzzzzg_);
            object izzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlCode izzzzzzzzzzzzzzzzzzzzzzzzk_ = this.T1b__Prostate_tumor_incidental_histologic_finding_in_greater_than_5_percent_of_tissue_resected__finding_(context);
            CqlConcept izzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConvertCodeToConcept(izzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Equivalent(izzzzzzzzzzzzzzzzzzzzzzzzj_ as CqlConcept, izzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzzzzzzzzzzzm_);
            object izzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlCode izzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Neoplasm_of_prostate_primary_tumor_staging_category_T1c__Tumor_identified_by_needle_biopsy__finding_(context);
            CqlConcept izzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConvertCodeToConcept(izzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Equivalent(izzzzzzzzzzzzzzzzzzzzzzzzp_ as CqlConcept, izzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzzzzzzzzzzzs_);
            object izzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlCode izzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Neoplasm_of_prostate_primary_tumor_staging_category_T2a__Involves_one_half_of_one_lobe_or_less__finding_(context);
            CqlConcept izzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConvertCodeToConcept(izzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Equivalent(izzzzzzzzzzzzzzzzzzzzzzzzv_ as CqlConcept, izzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzzzzzzzzzzzy_);

            return izzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Observation>((IEnumerable<Observation>)gzzzzzzzzzzzzzzzzzzzzzzzzz_, hzzzzzzzzzzzzzzzzzzzzzzzza_);
        Observation hzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SingletonFrom<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Most Recent PSA Test Result is Low")]
    public bool? Most_Recent_PSA_Test_Result_is_Low(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Prostate_Specific_Antigen_Test(context);
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzc_(Observation PSATest)
        {
            Observation jzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a(context);
            Observation[] jzzzzzzzzzzzzzzzzzzzzzzzzn_ = [
                jzzzzzzzzzzzzzzzzzzzzzzzzm_,
            ];
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzo_(Observation MostRecentProstateCancerStaging)
            {
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzs_()
                {
                    bool kzzzzzzzzzzzzzzzzzzzzzzzze_()
                    {
                        DataType kzzzzzzzzzzzzzzzzzzzzzzzzf_ = PSATest?.Effective;
                        object kzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzf_);
                        CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzg_);
                        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzh_);

                        return kzzzzzzzzzzzzzzzzzzzzzzzzi_ is null;
                    };
                    if (kzzzzzzzzzzzzzzzzzzzzzzzze_())
                    {
                        return default;
                    }
                    else
                    {
                        DataType kzzzzzzzzzzzzzzzzzzzzzzzzj_ = PSATest?.Effective;
                        object kzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzj_);
                        CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzk_);
                        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzl_);
                        object kzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzj_);
                        CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzo_);
                        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzp_);
                        CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzzzzzzzzzzzq_, true, true);

                        return kzzzzzzzzzzzzzzzzzzzzzzzzr_;
                    }
                };
                DataType jzzzzzzzzzzzzzzzzzzzzzzzzt_ = MostRecentProstateCancerStaging?.Effective;
                object jzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzu_);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Before(jzzzzzzzzzzzzzzzzzzzzzzzzs_(), jzzzzzzzzzzzzzzzzzzzzzzzzv_, default);
                Code<ObservationStatus> jzzzzzzzzzzzzzzzzzzzzzzzzx_ = PSATest?.StatusElement;
                ObservationStatus? jzzzzzzzzzzzzzzzzzzzzzzzzy_ = jzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
                Code<ObservationStatus> jzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<Code<ObservationStatus>>(jzzzzzzzzzzzzzzzzzzzzzzzzy_);
                string kzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzzzzzzzzzzzz_);
                string[] kzzzzzzzzzzzzzzzzzzzzzzzzb_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<string>(kzzzzzzzzzzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzzzzzzzzzzb_ as IEnumerable<string>);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzzzzzzzzzzzc_);

                return kzzzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>((IEnumerable<Observation>)jzzzzzzzzzzzzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzzzzzzzzzzzzo_);
            Observation jzzzzzzzzzzzzzzzzzzzzzzzzq_(Observation MostRecentProstateCancerStaging) =>
                PSATest;
            IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Observation, Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SelectMany<Observation, Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzb_, jzzzzzzzzzzzzzzzzzzzzzzzzc_);
        object jzzzzzzzzzzzzzzzzzzzzzzzze_(Observation @this)
        {
            DataType kzzzzzzzzzzzzzzzzzzzzzzzzs_ = @this?.Effective;
            object kzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SortBy<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzzzzzzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
        Observation jzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Last<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzf_);
        Observation[] jzzzzzzzzzzzzzzzzzzzzzzzzh_ = [
            jzzzzzzzzzzzzzzzzzzzzzzzzg_,
        ];
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation LastPSATest)
        {
            DataType kzzzzzzzzzzzzzzzzzzzzzzzzw_ = LastPSATest?.Value;
            object kzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlQuantity kzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(10m, "ng/mL");
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Less(kzzzzzzzzzzzzzzzzzzzzzzzzx_ as CqlQuantity, kzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<bool?> jzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Observation, bool?>((IEnumerable<Observation>)jzzzzzzzzzzzzzzzzzzzzzzzzh_, jzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<bool?> jzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<bool?>(jzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SingletonFrom<bool?>(jzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Most Recent Gleason Score is Low")]
    public bool? Most_Recent_Gleason_Score_is_Low(CqlContext context)
    {
        CqlCode lzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Gleason_score_in_Specimen_Qualitative(context);
        IEnumerable<CqlCode> lzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ToList<CqlCode>(lzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, lzzzzzzzzzzzzzzzzzzzzzzzzb_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzd_(Observation GleasonScore)
        {
            Procedure lzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period(context);
            Procedure[] lzzzzzzzzzzzzzzzzzzzzzzzzo_ = [
                lzzzzzzzzzzzzzzzzzzzzzzzzn_,
            ];
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzp_(Procedure FirstProstateCancerTreatment)
            {
                DataType lzzzzzzzzzzzzzzzzzzzzzzzzt_ = GleasonScore?.Effective;
                object lzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzzzv_);
                DataType lzzzzzzzzzzzzzzzzzzzzzzzzx_ = FirstProstateCancerTreatment?.Performed;
                object lzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Before(lzzzzzzzzzzzzzzzzzzzzzzzzw_, mzzzzzzzzzzzzzzzzzzzzzzzza_, default);
                Code<ObservationStatus> mzzzzzzzzzzzzzzzzzzzzzzzzc_ = GleasonScore?.StatusElement;
                ObservationStatus? mzzzzzzzzzzzzzzzzzzzzzzzzd_ = mzzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
                Code<ObservationStatus> mzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<Code<ObservationStatus>>(mzzzzzzzzzzzzzzzzzzzzzzzzd_);
                string mzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<string>(mzzzzzzzzzzzzzzzzzzzzzzzze_);
                string[] mzzzzzzzzzzzzzzzzzzzzzzzzg_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<string>(mzzzzzzzzzzzzzzzzzzzzzzzzf_, mzzzzzzzzzzzzzzzzzzzzzzzzg_ as IEnumerable<string>);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzzzzzzzzzzh_);

                return mzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Procedure> lzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)lzzzzzzzzzzzzzzzzzzzzzzzzo_, lzzzzzzzzzzzzzzzzzzzzzzzzp_);
            Observation lzzzzzzzzzzzzzzzzzzzzzzzzr_(Procedure FirstProstateCancerTreatment) =>
                GleasonScore;
            IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Procedure, Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzq_, lzzzzzzzzzzzzzzzzzzzzzzzzr_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SelectMany<Observation, Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzc_, lzzzzzzzzzzzzzzzzzzzzzzzzd_);
        object lzzzzzzzzzzzzzzzzzzzzzzzzf_(Observation @this)
        {
            DataType mzzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Effective;
            object mzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SortBy<Observation>(lzzzzzzzzzzzzzzzzzzzzzzzze_, lzzzzzzzzzzzzzzzzzzzzzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
        Observation lzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Last<Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzg_);
        Observation[] lzzzzzzzzzzzzzzzzzzzzzzzzi_ = [
            lzzzzzzzzzzzzzzzzzzzzzzzzh_,
        ];
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzj_(Observation LastGleasonScore)
        {
            DataType mzzzzzzzzzzzzzzzzzzzzzzzzn_ = LastGleasonScore?.Value;
            object mzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.LessOrEqual(mzzzzzzzzzzzzzzzzzzzzzzzzo_ as int?, 6);

            return mzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<bool?> lzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Observation, bool?>((IEnumerable<Observation>)lzzzzzzzzzzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<bool?> lzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<bool?>(lzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SingletonFrom<bool?>(lzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Initial_Population(context);
        Procedure mzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period(context);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzzzzzzzr_ is null));
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzzzzzzzzzzzzs_);
        Observation mzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a(context);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzzzzzzzu_ is null));
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzt_, mzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Most_Recent_PSA_Test_Result_is_Low(context);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzw_, mzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Most_Recent_Gleason_Score_is_Low(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return nzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Bone Scan Study Performed")]
    public IEnumerable<Observation> Bone_Scan_Study_Performed(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Bone_Scan(context);
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzd_(Observation BoneScan)
        {
            IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Prostate_Cancer_Diagnosis(context);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzi_(Condition ActiveProstateCancer)
            {
                DataType nzzzzzzzzzzzzzzzzzzzzzzzzm_ = BoneScan?.Effective;
                object nzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ActiveProstateCancer);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.After(nzzzzzzzzzzzzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzzzzzzzzzzzzr_, default);

                return nzzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzzzzzzzzzzzi_);
            Observation nzzzzzzzzzzzzzzzzzzzzzzzzk_(Condition ActiveProstateCancer) =>
                BoneScan;
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Condition, Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzj_, nzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SelectMany<Observation, Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzc_, nzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzf_(Observation BoneScan)
        {
            DataType nzzzzzzzzzzzzzzzzzzzzzzzzt_ = BoneScan?.Effective;
            object nzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.End(nzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzzzzzzzzzzzx_, "day");

            return nzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzze_, nzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Bone_Scan_Study_Performed(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not(ozzzzzzzzzzzzzzzzzzzzzzzza_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Diagnosis of Pain related to Prostate Cancer")]
    public bool? Has_Diagnosis_of_Pain_related_to_Prostate_Cancer(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Pain_Warranting_Further_Investigation_for_Prostate_Cancer(context);
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzze_(Condition ProstateCancerPain)
        {
            IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Prostate_Cancer_Diagnosis(context);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzi_(Condition ActiveProstateCancer)
            {
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ProstateCancerPain);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ActiveProstateCancer);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzo_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.After(ozzzzzzzzzzzzzzzzzzzzzzzzn_, ozzzzzzzzzzzzzzzzzzzzzzzzp_, default);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, ProstateCancerPain);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, ProstateCancerPain);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Or(ozzzzzzzzzzzzzzzzzzzzzzzzr_, ozzzzzzzzzzzzzzzzzzzzzzzzs_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzzzzzzzzzzzt_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Condition>(ozzzzzzzzzzzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzzzzzzzzzzi_);
            Condition ozzzzzzzzzzzzzzzzzzzzzzzzk_(Condition ActiveProstateCancer) =>
                ProstateCancerPain;
            IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Condition, Condition>(ozzzzzzzzzzzzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzzzzzzzzzzzk_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SelectMany<Condition, Condition>(ozzzzzzzzzzzzzzzzzzzzzzzzd_, ozzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Condition>(ozzzzzzzzzzzzzzzzzzzzzzzzf_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Salvage Therapy Performed after Prostate Cancer Diagnosis")]
    public bool? Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Salvage_Therapy(context);
        IEnumerable<Procedure> ozzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> ozzzzzzzzzzzzzzzzzzzzzzzzx_(Procedure SalvageTherapy)
        {
            IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Prostate_Cancer_Diagnosis(context);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzb_(Condition ActiveProstateCancer)
            {
                DataType pzzzzzzzzzzzzzzzzzzzzzzzzf_ = SalvageTherapy?.Performed;
                object pzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ActiveProstateCancer);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzj_);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.After(pzzzzzzzzzzzzzzzzzzzzzzzzi_, pzzzzzzzzzzzzzzzzzzzzzzzzk_, default);
                Code<EventStatus> pzzzzzzzzzzzzzzzzzzzzzzzzm_ = SalvageTherapy?.StatusElement;
                EventStatus? pzzzzzzzzzzzzzzzzzzzzzzzzn_ = pzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
                string pzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Equal(pzzzzzzzzzzzzzzzzzzzzzzzzo_, "completed");
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzl_, pzzzzzzzzzzzzzzzzzzzzzzzzp_);

                return pzzzzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Condition>(pzzzzzzzzzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzzzzzzzzzb_);
            Procedure pzzzzzzzzzzzzzzzzzzzzzzzzd_(Condition ActiveProstateCancer) =>
                SalvageTherapy;
            IEnumerable<Procedure> pzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<Condition, Procedure>(pzzzzzzzzzzzzzzzzzzzzzzzzc_, pzzzzzzzzzzzzzzzzzzzzzzzzd_);

            return pzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Procedure> ozzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SelectMany<Procedure, Procedure>(ozzzzzzzzzzzzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<Procedure>(ozzzzzzzzzzzzzzzzzzzzzzzzy_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Bone Scan Study Performed with Documented Reason")]
    public bool? Has_Bone_Scan_Study_Performed_with_Documented_Reason(CqlContext context)
    {
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Bone_Scan_Study_Performed(context);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzs_(Observation BoneScanAfterDiagnosis)
        {
            DataType pzzzzzzzzzzzzzzzzzzzzzzzzv_ = BoneScanAfterDiagnosis?.Value;
            object pzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlCode pzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Procedure_reason_record__record_artifact_(context);
            CqlConcept pzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertCodeToConcept(pzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equivalent(pzzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlConcept, pzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        bool? qzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Has_Diagnosis_of_Pain_related_to_Prostate_Cancer(context);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis(context);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzzzzzzzza_, qzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Has_Bone_Scan_Study_Performed_with_Documented_Reason(context);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return qzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    #endregion Expressions

}
