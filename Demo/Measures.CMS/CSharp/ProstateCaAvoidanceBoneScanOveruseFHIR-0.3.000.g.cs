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

    [CqlValueSetDefinition("Bone Scan", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.320", valueSetVersion: null)]
    public CqlValueSet Bone_Scan(CqlContext _) => _Bone_Scan;
    private static readonly CqlValueSet _Bone_Scan = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.320", null);

    [CqlValueSetDefinition("Pain Warranting Further Investigation for Prostate Cancer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.451", valueSetVersion: null)]
    public CqlValueSet Pain_Warranting_Further_Investigation_for_Prostate_Cancer(CqlContext _) => _Pain_Warranting_Further_Investigation_for_Prostate_Cancer;
    private static readonly CqlValueSet _Pain_Warranting_Further_Investigation_for_Prostate_Cancer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.451", null);

    [CqlValueSetDefinition("Prostate Cancer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.319", valueSetVersion: null)]
    public CqlValueSet Prostate_Cancer(CqlContext _) => _Prostate_Cancer;
    private static readonly CqlValueSet _Prostate_Cancer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.319", null);

    [CqlValueSetDefinition("Prostate Cancer Treatment", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.398", valueSetVersion: null)]
    public CqlValueSet Prostate_Cancer_Treatment(CqlContext _) => _Prostate_Cancer_Treatment;
    private static readonly CqlValueSet _Prostate_Cancer_Treatment = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.398", null);

    [CqlValueSetDefinition("Prostate Specific Antigen Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.401", valueSetVersion: null)]
    public CqlValueSet Prostate_Specific_Antigen_Test(CqlContext _) => _Prostate_Specific_Antigen_Test;
    private static readonly CqlValueSet _Prostate_Specific_Antigen_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.401", null);

    [CqlValueSetDefinition("Salvage Therapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.399", valueSetVersion: null)]
    public CqlValueSet Salvage_Therapy(CqlContext _) => _Salvage_Therapy;
    private static readonly CqlValueSet _Salvage_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.399", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Gleason score in Specimen Qualitative", codeId: "35266-6", codeSystem: "http://loinc.org")]
    public CqlCode Gleason_score_in_Specimen_Qualitative(CqlContext _) => _Gleason_score_in_Specimen_Qualitative;
    private static readonly CqlCode _Gleason_score_in_Specimen_Qualitative = new CqlCode("35266-6", "http://loinc.org", default, default);

    [CqlCodeDefinition("Neoplasm of prostate primary tumor staging category T1c: Tumor identified by needle biopsy (finding)", codeId: "433351000124101", codeSystem: "http://snomed.info/sct")]
    public CqlCode Neoplasm_of_prostate_primary_tumor_staging_category_T1c__Tumor_identified_by_needle_biopsy__finding_(CqlContext _) => _Neoplasm_of_prostate_primary_tumor_staging_category_T1c__Tumor_identified_by_needle_biopsy__finding_;
    private static readonly CqlCode _Neoplasm_of_prostate_primary_tumor_staging_category_T1c__Tumor_identified_by_needle_biopsy__finding_ = new CqlCode("433351000124101", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Neoplasm of prostate primary tumor staging category T2a: Involves one-half of one lobe or less (finding)", codeId: "433361000124104", codeSystem: "http://snomed.info/sct")]
    public CqlCode Neoplasm_of_prostate_primary_tumor_staging_category_T2a__Involves_one_half_of_one_lobe_or_less__finding_(CqlContext _) => _Neoplasm_of_prostate_primary_tumor_staging_category_T2a__Involves_one_half_of_one_lobe_or_less__finding_;
    private static readonly CqlCode _Neoplasm_of_prostate_primary_tumor_staging_category_T2a__Involves_one_half_of_one_lobe_or_less__finding_ = new CqlCode("433361000124104", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Procedure reason record (record artifact)", codeId: "433611000124109", codeSystem: "http://snomed.info/sct")]
    public CqlCode Procedure_reason_record__record_artifact_(CqlContext _) => _Procedure_reason_record__record_artifact_;
    private static readonly CqlCode _Procedure_reason_record__record_artifact_ = new CqlCode("433611000124109", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("T1a: Prostate tumor incidental histologic finding in 5 percent or less of tissue resected (finding)", codeId: "369833007", codeSystem: "http://snomed.info/sct")]
    public CqlCode T1a__Prostate_tumor_incidental_histologic_finding_in_5_percent_or_less_of_tissue_resected__finding_(CqlContext _) => _T1a__Prostate_tumor_incidental_histologic_finding_in_5_percent_or_less_of_tissue_resected__finding_;
    private static readonly CqlCode _T1a__Prostate_tumor_incidental_histologic_finding_in_5_percent_or_less_of_tissue_resected__finding_ = new CqlCode("369833007", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("T1b: Prostate tumor incidental histologic finding in greater than 5 percent of tissue resected (finding)", codeId: "369834001", codeSystem: "http://snomed.info/sct")]
    public CqlCode T1b__Prostate_tumor_incidental_histologic_finding_in_greater_than_5_percent_of_tissue_resected__finding_(CqlContext _) => _T1b__Prostate_tumor_incidental_histologic_finding_in_greater_than_5_percent_of_tissue_resected__finding_;
    private static readonly CqlCode _T1b__Prostate_tumor_incidental_histologic_finding_in_greater_than_5_percent_of_tissue_resected__finding_ = new CqlCode("369834001", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Tumor staging (tumor staging)", codeId: "254292007", codeSystem: "http://snomed.info/sct")]
    public CqlCode Tumor_staging__tumor_staging_(CqlContext _) => _Tumor_staging__tumor_staging_;
    private static readonly CqlCode _Tumor_staging__tumor_staging_ = new CqlCode("254292007", "http://snomed.info/sct", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC = new CqlCodeSystem();

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT = new CqlCodeSystem();

    [CqlCodeSystemDefinition("UCUM")]
    public CqlCodeSystem UCUM(CqlContext _) => _UCUM;
    private static readonly CqlCodeSystem _UCUM = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime czzzzzzzzzzzzzzd_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime czzzzzzzzzzzzzze_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> czzzzzzzzzzzzzzf_ = context.Operators.Interval(czzzzzzzzzzzzzzd_, czzzzzzzzzzzzzze_, true, true);
        object czzzzzzzzzzzzzzg_ = context.ResolveParameter("ProstateCaAvoidanceBoneScanOveruseFHIR-0.3.000", "Measurement Period", czzzzzzzzzzzzzzf_);

        return (CqlInterval<CqlDateTime>)czzzzzzzzzzzzzzg_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> czzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient czzzzzzzzzzzzzzi_ = context.Operators.SingletonFrom<Patient>(czzzzzzzzzzzzzzh_);

        return czzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? czzzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return czzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> czzzzzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return czzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? czzzzzzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return czzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode czzzzzzzzzzzzzzm_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return czzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Prostate Cancer Diagnosis")]
    public IEnumerable<Condition> Prostate_Cancer_Diagnosis(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzn_ = this.Prostate_Cancer(context);
        IEnumerable<Condition> czzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? czzzzzzzzzzzzzzp_(Condition ProstateCancer)
        {
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ProstateCancer);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
            bool? czzzzzzzzzzzzzzt_ = context.Operators.Overlaps(czzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzs_, "day");
            bool? czzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, ProstateCancer);
            bool? czzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, ProstateCancer);
            bool? czzzzzzzzzzzzzzw_ = context.Operators.Or(czzzzzzzzzzzzzzu_, czzzzzzzzzzzzzzv_);
            bool? czzzzzzzzzzzzzzx_ = context.Operators.And(czzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzw_);

            return czzzzzzzzzzzzzzx_;
        };
        IEnumerable<Condition> czzzzzzzzzzzzzzq_ = context.Operators.Where<Condition>(czzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzp_);

        return czzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        IEnumerable<Condition> czzzzzzzzzzzzzzy_ = this.Prostate_Cancer_Diagnosis(context);
        bool? czzzzzzzzzzzzzzz_ = context.Operators.Exists<Condition>(czzzzzzzzzzzzzzy_);

        return czzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("First Prostate Cancer Treatment during day of Measurement Period")]
    public Procedure First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzza_ = this.Prostate_Cancer_Treatment(context);
        IEnumerable<Procedure> dzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, dzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? dzzzzzzzzzzzzzzc_(Procedure ProstateCancerTreatment)
        {
            DataType dzzzzzzzzzzzzzzh_ = ProstateCancerTreatment?.Performed;
            object dzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzi_);
            CqlDateTime dzzzzzzzzzzzzzzk_ = context.Operators.End(dzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
            bool? dzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzk_, dzzzzzzzzzzzzzzl_, "day");
            Code<EventStatus> dzzzzzzzzzzzzzzn_ = ProstateCancerTreatment?.StatusElement;
            EventStatus? dzzzzzzzzzzzzzzo_ = dzzzzzzzzzzzzzzn_?.Value;
            string dzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(dzzzzzzzzzzzzzzo_);
            bool? dzzzzzzzzzzzzzzq_ = context.Operators.Equal(dzzzzzzzzzzzzzzp_, "completed");
            bool? dzzzzzzzzzzzzzzr_ = context.Operators.And(dzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzq_);

            return dzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Procedure> dzzzzzzzzzzzzzzd_ = context.Operators.Where<Procedure>(dzzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzzc_);
        object dzzzzzzzzzzzzzze_(Procedure @this)
        {
            DataType dzzzzzzzzzzzzzzs_ = @this?.Performed;
            object dzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzt_);
            CqlDateTime dzzzzzzzzzzzzzzv_ = context.Operators.Start(dzzzzzzzzzzzzzzu_);

            return dzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Procedure> dzzzzzzzzzzzzzzf_ = context.Operators.SortBy<Procedure>(dzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
        Procedure dzzzzzzzzzzzzzzg_ = context.Operators.First<Procedure>(dzzzzzzzzzzzzzzf_);

        return dzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Most Recent Prostate Cancer Staging Tumor Size T1a to T2a")]
    public Observation Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a(CqlContext context)
    {
        CqlCode dzzzzzzzzzzzzzzw_ = this.Tumor_staging__tumor_staging_(context);
        IEnumerable<CqlCode> dzzzzzzzzzzzzzzx_ = context.Operators.ToList<CqlCode>(dzzzzzzzzzzzzzzw_);
        IEnumerable<Observation> dzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, dzzzzzzzzzzzzzzx_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> dzzzzzzzzzzzzzzz_(Observation ProstateCancerStaging)
        {
            Procedure ezzzzzzzzzzzzzzi_ = this.First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period(context);
            Procedure[] ezzzzzzzzzzzzzzj_ = [
                ezzzzzzzzzzzzzzi_,
            ];
            bool? ezzzzzzzzzzzzzzk_(Procedure FirstProstateCancerTreatment)
            {
                DataType ezzzzzzzzzzzzzzo_ = ProstateCancerStaging?.Effective;
                object ezzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzp_);
                CqlDateTime ezzzzzzzzzzzzzzr_ = context.Operators.Start(ezzzzzzzzzzzzzzq_);
                DataType ezzzzzzzzzzzzzzs_ = FirstProstateCancerTreatment?.Performed;
                object ezzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzt_);
                CqlDateTime ezzzzzzzzzzzzzzv_ = context.Operators.Start(ezzzzzzzzzzzzzzu_);
                bool? ezzzzzzzzzzzzzzw_ = context.Operators.Before(ezzzzzzzzzzzzzzr_, ezzzzzzzzzzzzzzv_, default);
                Code<ObservationStatus> ezzzzzzzzzzzzzzx_ = ProstateCancerStaging?.StatusElement;
                ObservationStatus? ezzzzzzzzzzzzzzy_ = ezzzzzzzzzzzzzzx_?.Value;
                Code<ObservationStatus> ezzzzzzzzzzzzzzz_ = context.Operators.Convert<Code<ObservationStatus>>(ezzzzzzzzzzzzzzy_);
                string fzzzzzzzzzzzzzza_ = context.Operators.Convert<string>(ezzzzzzzzzzzzzzz_);
                string[] fzzzzzzzzzzzzzzb_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? fzzzzzzzzzzzzzzc_ = context.Operators.In<string>(fzzzzzzzzzzzzzza_, fzzzzzzzzzzzzzzb_ as IEnumerable<string>);
                bool? fzzzzzzzzzzzzzzd_ = context.Operators.And(ezzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzzc_);

                return fzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Procedure> ezzzzzzzzzzzzzzl_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)ezzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzk_);
            Observation ezzzzzzzzzzzzzzm_(Procedure FirstProstateCancerTreatment) =>
                ProstateCancerStaging;
            IEnumerable<Observation> ezzzzzzzzzzzzzzn_ = context.Operators.Select<Procedure, Observation>(ezzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzm_);

            return ezzzzzzzzzzzzzzn_;
        };
        IEnumerable<Observation> ezzzzzzzzzzzzzza_ = context.Operators.SelectMany<Observation, Observation>(dzzzzzzzzzzzzzzy_, dzzzzzzzzzzzzzzz_);
        object ezzzzzzzzzzzzzzb_(Observation @this)
        {
            DataType fzzzzzzzzzzzzzze_ = @this?.Effective;
            object fzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzf_);
            CqlDateTime fzzzzzzzzzzzzzzh_ = context.Operators.Start(fzzzzzzzzzzzzzzg_);

            return fzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Observation> ezzzzzzzzzzzzzzc_ = context.Operators.SortBy<Observation>(ezzzzzzzzzzzzzza_, ezzzzzzzzzzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
        Observation ezzzzzzzzzzzzzzd_ = context.Operators.Last<Observation>(ezzzzzzzzzzzzzzc_);
        Observation[] ezzzzzzzzzzzzzze_ = [
            ezzzzzzzzzzzzzzd_,
        ];
        bool? ezzzzzzzzzzzzzzf_(Observation LastProstateCancerStaging)
        {
            DataType fzzzzzzzzzzzzzzi_ = LastProstateCancerStaging?.Value;
            object fzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzi_);
            CqlCode fzzzzzzzzzzzzzzk_ = this.T1a__Prostate_tumor_incidental_histologic_finding_in_5_percent_or_less_of_tissue_resected__finding_(context);
            CqlConcept fzzzzzzzzzzzzzzl_ = context.Operators.ConvertCodeToConcept(fzzzzzzzzzzzzzzk_);
            bool? fzzzzzzzzzzzzzzm_ = context.Operators.Equivalent(fzzzzzzzzzzzzzzj_ as CqlConcept, fzzzzzzzzzzzzzzl_);
            object fzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzi_);
            CqlCode fzzzzzzzzzzzzzzp_ = this.T1b__Prostate_tumor_incidental_histologic_finding_in_greater_than_5_percent_of_tissue_resected__finding_(context);
            CqlConcept fzzzzzzzzzzzzzzq_ = context.Operators.ConvertCodeToConcept(fzzzzzzzzzzzzzzp_);
            bool? fzzzzzzzzzzzzzzr_ = context.Operators.Equivalent(fzzzzzzzzzzzzzzo_ as CqlConcept, fzzzzzzzzzzzzzzq_);
            bool? fzzzzzzzzzzzzzzs_ = context.Operators.Or(fzzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzzr_);
            object fzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzi_);
            CqlCode fzzzzzzzzzzzzzzv_ = this.Neoplasm_of_prostate_primary_tumor_staging_category_T1c__Tumor_identified_by_needle_biopsy__finding_(context);
            CqlConcept fzzzzzzzzzzzzzzw_ = context.Operators.ConvertCodeToConcept(fzzzzzzzzzzzzzzv_);
            bool? fzzzzzzzzzzzzzzx_ = context.Operators.Equivalent(fzzzzzzzzzzzzzzu_ as CqlConcept, fzzzzzzzzzzzzzzw_);
            bool? fzzzzzzzzzzzzzzy_ = context.Operators.Or(fzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzx_);
            object gzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzi_);
            CqlCode gzzzzzzzzzzzzzzb_ = this.Neoplasm_of_prostate_primary_tumor_staging_category_T2a__Involves_one_half_of_one_lobe_or_less__finding_(context);
            CqlConcept gzzzzzzzzzzzzzzc_ = context.Operators.ConvertCodeToConcept(gzzzzzzzzzzzzzzb_);
            bool? gzzzzzzzzzzzzzzd_ = context.Operators.Equivalent(gzzzzzzzzzzzzzza_ as CqlConcept, gzzzzzzzzzzzzzzc_);
            bool? gzzzzzzzzzzzzzze_ = context.Operators.Or(fzzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzzd_);

            return gzzzzzzzzzzzzzze_;
        };
        IEnumerable<Observation> ezzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>((IEnumerable<Observation>)ezzzzzzzzzzzzzze_, ezzzzzzzzzzzzzzf_);
        Observation ezzzzzzzzzzzzzzh_ = context.Operators.SingletonFrom<Observation>(ezzzzzzzzzzzzzzg_);

        return ezzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Most Recent PSA Test Result is Low")]
    public bool? Most_Recent_PSA_Test_Result_is_Low(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzzzzf_ = this.Prostate_Specific_Antigen_Test(context);
        IEnumerable<Observation> gzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> gzzzzzzzzzzzzzzh_(Observation PSATest)
        {
            Observation gzzzzzzzzzzzzzzr_ = this.Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a(context);
            Observation[] gzzzzzzzzzzzzzzs_ = [
                gzzzzzzzzzzzzzzr_,
            ];
            bool? gzzzzzzzzzzzzzzt_(Observation MostRecentProstateCancerStaging)
            {
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzx_()
                {
                    bool hzzzzzzzzzzzzzzj_()
                    {
                        DataType hzzzzzzzzzzzzzzk_ = PSATest?.Effective;
                        object hzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzk_);
                        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzl_);
                        CqlDateTime hzzzzzzzzzzzzzzn_ = context.Operators.Start(hzzzzzzzzzzzzzzm_);

                        return hzzzzzzzzzzzzzzn_ is null;
                    };
                    if (hzzzzzzzzzzzzzzj_())
                    {
                        return default;
                    }
                    else
                    {
                        DataType hzzzzzzzzzzzzzzo_ = PSATest?.Effective;
                        object hzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzo_);
                        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzp_);
                        CqlDateTime hzzzzzzzzzzzzzzr_ = context.Operators.Start(hzzzzzzzzzzzzzzq_);
                        object hzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzo_);
                        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzt_);
                        CqlDateTime hzzzzzzzzzzzzzzv_ = context.Operators.Start(hzzzzzzzzzzzzzzu_);
                        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzw_ = context.Operators.Interval(hzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzv_, true, true);

                        return hzzzzzzzzzzzzzzw_;
                    }
                };
                DataType gzzzzzzzzzzzzzzy_ = MostRecentProstateCancerStaging?.Effective;
                object gzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzz_);
                bool? hzzzzzzzzzzzzzzb_ = context.Operators.Before(gzzzzzzzzzzzzzzx_(), hzzzzzzzzzzzzzza_, default);
                Code<ObservationStatus> hzzzzzzzzzzzzzzc_ = PSATest?.StatusElement;
                ObservationStatus? hzzzzzzzzzzzzzzd_ = hzzzzzzzzzzzzzzc_?.Value;
                Code<ObservationStatus> hzzzzzzzzzzzzzze_ = context.Operators.Convert<Code<ObservationStatus>>(hzzzzzzzzzzzzzzd_);
                string hzzzzzzzzzzzzzzf_ = context.Operators.Convert<string>(hzzzzzzzzzzzzzze_);
                string[] hzzzzzzzzzzzzzzg_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? hzzzzzzzzzzzzzzh_ = context.Operators.In<string>(hzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzg_ as IEnumerable<string>);
                bool? hzzzzzzzzzzzzzzi_ = context.Operators.And(hzzzzzzzzzzzzzzb_, hzzzzzzzzzzzzzzh_);

                return hzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Observation> gzzzzzzzzzzzzzzu_ = context.Operators.Where<Observation>((IEnumerable<Observation>)gzzzzzzzzzzzzzzs_, gzzzzzzzzzzzzzzt_);
            Observation gzzzzzzzzzzzzzzv_(Observation MostRecentProstateCancerStaging) =>
                PSATest;
            IEnumerable<Observation> gzzzzzzzzzzzzzzw_ = context.Operators.Select<Observation, Observation>(gzzzzzzzzzzzzzzu_, gzzzzzzzzzzzzzzv_);

            return gzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Observation> gzzzzzzzzzzzzzzi_ = context.Operators.SelectMany<Observation, Observation>(gzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzh_);
        object gzzzzzzzzzzzzzzj_(Observation @this)
        {
            DataType hzzzzzzzzzzzzzzx_ = @this?.Effective;
            object hzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzy_);
            CqlDateTime izzzzzzzzzzzzzza_ = context.Operators.Start(hzzzzzzzzzzzzzzz_);

            return izzzzzzzzzzzzzza_;
        };
        IEnumerable<Observation> gzzzzzzzzzzzzzzk_ = context.Operators.SortBy<Observation>(gzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
        Observation gzzzzzzzzzzzzzzl_ = context.Operators.Last<Observation>(gzzzzzzzzzzzzzzk_);
        Observation[] gzzzzzzzzzzzzzzm_ = [
            gzzzzzzzzzzzzzzl_,
        ];
        bool? gzzzzzzzzzzzzzzn_(Observation LastPSATest)
        {
            DataType izzzzzzzzzzzzzzb_ = LastPSATest?.Value;
            object izzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzb_);
            CqlQuantity izzzzzzzzzzzzzzd_ = context.Operators.Quantity(10m, "ng/mL");
            bool? izzzzzzzzzzzzzze_ = context.Operators.Less(izzzzzzzzzzzzzzc_ as CqlQuantity, izzzzzzzzzzzzzzd_);

            return izzzzzzzzzzzzzze_;
        };
        IEnumerable<bool?> gzzzzzzzzzzzzzzo_ = context.Operators.Select<Observation, bool?>((IEnumerable<Observation>)gzzzzzzzzzzzzzzm_, gzzzzzzzzzzzzzzn_);
        IEnumerable<bool?> gzzzzzzzzzzzzzzp_ = context.Operators.Distinct<bool?>(gzzzzzzzzzzzzzzo_);
        bool? gzzzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<bool?>(gzzzzzzzzzzzzzzp_);

        return gzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Most Recent Gleason Score is Low")]
    public bool? Most_Recent_Gleason_Score_is_Low(CqlContext context)
    {
        CqlCode izzzzzzzzzzzzzzf_ = this.Gleason_score_in_Specimen_Qualitative(context);
        IEnumerable<CqlCode> izzzzzzzzzzzzzzg_ = context.Operators.ToList<CqlCode>(izzzzzzzzzzzzzzf_);
        IEnumerable<Observation> izzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, izzzzzzzzzzzzzzg_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> izzzzzzzzzzzzzzi_(Observation GleasonScore)
        {
            Procedure izzzzzzzzzzzzzzs_ = this.First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period(context);
            Procedure[] izzzzzzzzzzzzzzt_ = [
                izzzzzzzzzzzzzzs_,
            ];
            bool? izzzzzzzzzzzzzzu_(Procedure FirstProstateCancerTreatment)
            {
                DataType izzzzzzzzzzzzzzy_ = GleasonScore?.Effective;
                object izzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzz_);
                CqlDateTime jzzzzzzzzzzzzzzb_ = context.Operators.Start(jzzzzzzzzzzzzzza_);
                DataType jzzzzzzzzzzzzzzc_ = FirstProstateCancerTreatment?.Performed;
                object jzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzd_);
                CqlDateTime jzzzzzzzzzzzzzzf_ = context.Operators.Start(jzzzzzzzzzzzzzze_);
                bool? jzzzzzzzzzzzzzzg_ = context.Operators.Before(jzzzzzzzzzzzzzzb_, jzzzzzzzzzzzzzzf_, default);
                Code<ObservationStatus> jzzzzzzzzzzzzzzh_ = GleasonScore?.StatusElement;
                ObservationStatus? jzzzzzzzzzzzzzzi_ = jzzzzzzzzzzzzzzh_?.Value;
                Code<ObservationStatus> jzzzzzzzzzzzzzzj_ = context.Operators.Convert<Code<ObservationStatus>>(jzzzzzzzzzzzzzzi_);
                string jzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzj_);
                string[] jzzzzzzzzzzzzzzl_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? jzzzzzzzzzzzzzzm_ = context.Operators.In<string>(jzzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzzl_ as IEnumerable<string>);
                bool? jzzzzzzzzzzzzzzn_ = context.Operators.And(jzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzm_);

                return jzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Procedure> izzzzzzzzzzzzzzv_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)izzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzu_);
            Observation izzzzzzzzzzzzzzw_(Procedure FirstProstateCancerTreatment) =>
                GleasonScore;
            IEnumerable<Observation> izzzzzzzzzzzzzzx_ = context.Operators.Select<Procedure, Observation>(izzzzzzzzzzzzzzv_, izzzzzzzzzzzzzzw_);

            return izzzzzzzzzzzzzzx_;
        };
        IEnumerable<Observation> izzzzzzzzzzzzzzj_ = context.Operators.SelectMany<Observation, Observation>(izzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzi_);
        object izzzzzzzzzzzzzzk_(Observation @this)
        {
            DataType jzzzzzzzzzzzzzzo_ = @this?.Effective;
            object jzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzp_);
            CqlDateTime jzzzzzzzzzzzzzzr_ = context.Operators.Start(jzzzzzzzzzzzzzzq_);

            return jzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Observation> izzzzzzzzzzzzzzl_ = context.Operators.SortBy<Observation>(izzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
        Observation izzzzzzzzzzzzzzm_ = context.Operators.Last<Observation>(izzzzzzzzzzzzzzl_);
        Observation[] izzzzzzzzzzzzzzn_ = [
            izzzzzzzzzzzzzzm_,
        ];
        bool? izzzzzzzzzzzzzzo_(Observation LastGleasonScore)
        {
            DataType jzzzzzzzzzzzzzzs_ = LastGleasonScore?.Value;
            object jzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzs_);
            bool? jzzzzzzzzzzzzzzu_ = context.Operators.LessOrEqual(jzzzzzzzzzzzzzzt_ as int?, 6);

            return jzzzzzzzzzzzzzzu_;
        };
        IEnumerable<bool?> izzzzzzzzzzzzzzp_ = context.Operators.Select<Observation, bool?>((IEnumerable<Observation>)izzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzo_);
        IEnumerable<bool?> izzzzzzzzzzzzzzq_ = context.Operators.Distinct<bool?>(izzzzzzzzzzzzzzp_);
        bool? izzzzzzzzzzzzzzr_ = context.Operators.SingletonFrom<bool?>(izzzzzzzzzzzzzzq_);

        return izzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? jzzzzzzzzzzzzzzv_ = this.Initial_Population(context);
        Procedure jzzzzzzzzzzzzzzw_ = this.First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period(context);
        bool? jzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzw_ is null));
        bool? jzzzzzzzzzzzzzzy_ = context.Operators.And(jzzzzzzzzzzzzzzv_, jzzzzzzzzzzzzzzx_);
        Observation jzzzzzzzzzzzzzzz_ = this.Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a(context);
        bool? kzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzz_ is null));
        bool? kzzzzzzzzzzzzzzb_ = context.Operators.And(jzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzza_);
        bool? kzzzzzzzzzzzzzzc_ = this.Most_Recent_PSA_Test_Result_is_Low(context);
        bool? kzzzzzzzzzzzzzzd_ = context.Operators.And(kzzzzzzzzzzzzzzb_, kzzzzzzzzzzzzzzc_);
        bool? kzzzzzzzzzzzzzze_ = this.Most_Recent_Gleason_Score_is_Low(context);
        bool? kzzzzzzzzzzzzzzf_ = context.Operators.And(kzzzzzzzzzzzzzzd_, kzzzzzzzzzzzzzze_);

        return kzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Bone Scan Study Performed")]
    public IEnumerable<Observation> Bone_Scan_Study_Performed(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzg_ = this.Bone_Scan(context);
        IEnumerable<Observation> kzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> kzzzzzzzzzzzzzzi_(Observation BoneScan)
        {
            IEnumerable<Condition> kzzzzzzzzzzzzzzm_ = this.Prostate_Cancer_Diagnosis(context);
            bool? kzzzzzzzzzzzzzzn_(Condition ActiveProstateCancer)
            {
                DataType kzzzzzzzzzzzzzzr_ = BoneScan?.Effective;
                object kzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzs_);
                CqlDateTime kzzzzzzzzzzzzzzu_ = context.Operators.Start(kzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ActiveProstateCancer);
                CqlDateTime kzzzzzzzzzzzzzzw_ = context.Operators.Start(kzzzzzzzzzzzzzzv_);
                bool? kzzzzzzzzzzzzzzx_ = context.Operators.After(kzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzw_, default);

                return kzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Condition> kzzzzzzzzzzzzzzo_ = context.Operators.Where<Condition>(kzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzn_);
            Observation kzzzzzzzzzzzzzzp_(Condition ActiveProstateCancer) =>
                BoneScan;
            IEnumerable<Observation> kzzzzzzzzzzzzzzq_ = context.Operators.Select<Condition, Observation>(kzzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzzp_);

            return kzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Observation> kzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<Observation, Observation>(kzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzi_);
        bool? kzzzzzzzzzzzzzzk_(Observation BoneScan)
        {
            DataType kzzzzzzzzzzzzzzy_ = BoneScan?.Effective;
            object kzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzz_);
            CqlDateTime lzzzzzzzzzzzzzzb_ = context.Operators.End(lzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
            bool? lzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzc_, "day");

            return lzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Observation> kzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(kzzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzzk_);

        return kzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Observation> lzzzzzzzzzzzzzze_ = this.Bone_Scan_Study_Performed(context);
        bool? lzzzzzzzzzzzzzzf_ = context.Operators.Exists<Observation>(lzzzzzzzzzzzzzze_);
        bool? lzzzzzzzzzzzzzzg_ = context.Operators.Not(lzzzzzzzzzzzzzzf_);

        return lzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Has Diagnosis of Pain related to Prostate Cancer")]
    public bool? Has_Diagnosis_of_Pain_related_to_Prostate_Cancer(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzh_ = this.Pain_Warranting_Further_Investigation_for_Prostate_Cancer(context);
        IEnumerable<Condition> lzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> lzzzzzzzzzzzzzzj_(Condition ProstateCancerPain)
        {
            IEnumerable<Condition> lzzzzzzzzzzzzzzm_ = this.Prostate_Cancer_Diagnosis(context);
            bool? lzzzzzzzzzzzzzzn_(Condition ActiveProstateCancer)
            {
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ProstateCancerPain);
                CqlDateTime lzzzzzzzzzzzzzzs_ = context.Operators.Start(lzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ActiveProstateCancer);
                CqlDateTime lzzzzzzzzzzzzzzu_ = context.Operators.Start(lzzzzzzzzzzzzzzt_);
                bool? lzzzzzzzzzzzzzzv_ = context.Operators.After(lzzzzzzzzzzzzzzs_, lzzzzzzzzzzzzzzu_, default);
                bool? lzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, ProstateCancerPain);
                bool? lzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, ProstateCancerPain);
                bool? lzzzzzzzzzzzzzzy_ = context.Operators.Or(lzzzzzzzzzzzzzzw_, lzzzzzzzzzzzzzzx_);
                bool? lzzzzzzzzzzzzzzz_ = context.Operators.And(lzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzy_);

                return lzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Condition> lzzzzzzzzzzzzzzo_ = context.Operators.Where<Condition>(lzzzzzzzzzzzzzzm_, lzzzzzzzzzzzzzzn_);
            Condition lzzzzzzzzzzzzzzp_(Condition ActiveProstateCancer) =>
                ProstateCancerPain;
            IEnumerable<Condition> lzzzzzzzzzzzzzzq_ = context.Operators.Select<Condition, Condition>(lzzzzzzzzzzzzzzo_, lzzzzzzzzzzzzzzp_);

            return lzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Condition> lzzzzzzzzzzzzzzk_ = context.Operators.SelectMany<Condition, Condition>(lzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzj_);
        bool? lzzzzzzzzzzzzzzl_ = context.Operators.Exists<Condition>(lzzzzzzzzzzzzzzk_);

        return lzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Has Salvage Therapy Performed after Prostate Cancer Diagnosis")]
    public bool? Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzza_ = this.Salvage_Therapy(context);
        IEnumerable<Procedure> mzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, mzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> mzzzzzzzzzzzzzzc_(Procedure SalvageTherapy)
        {
            IEnumerable<Condition> mzzzzzzzzzzzzzzf_ = this.Prostate_Cancer_Diagnosis(context);
            bool? mzzzzzzzzzzzzzzg_(Condition ActiveProstateCancer)
            {
                DataType mzzzzzzzzzzzzzzk_ = SalvageTherapy?.Performed;
                object mzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzl_);
                CqlDateTime mzzzzzzzzzzzzzzn_ = context.Operators.Start(mzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ActiveProstateCancer);
                CqlDateTime mzzzzzzzzzzzzzzp_ = context.Operators.Start(mzzzzzzzzzzzzzzo_);
                bool? mzzzzzzzzzzzzzzq_ = context.Operators.After(mzzzzzzzzzzzzzzn_, mzzzzzzzzzzzzzzp_, default);
                Code<EventStatus> mzzzzzzzzzzzzzzr_ = SalvageTherapy?.StatusElement;
                EventStatus? mzzzzzzzzzzzzzzs_ = mzzzzzzzzzzzzzzr_?.Value;
                string mzzzzzzzzzzzzzzt_ = context.Operators.Convert<string>(mzzzzzzzzzzzzzzs_);
                bool? mzzzzzzzzzzzzzzu_ = context.Operators.Equal(mzzzzzzzzzzzzzzt_, "completed");
                bool? mzzzzzzzzzzzzzzv_ = context.Operators.And(mzzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzzu_);

                return mzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Condition> mzzzzzzzzzzzzzzh_ = context.Operators.Where<Condition>(mzzzzzzzzzzzzzzf_, mzzzzzzzzzzzzzzg_);
            Procedure mzzzzzzzzzzzzzzi_(Condition ActiveProstateCancer) =>
                SalvageTherapy;
            IEnumerable<Procedure> mzzzzzzzzzzzzzzj_ = context.Operators.Select<Condition, Procedure>(mzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzi_);

            return mzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Procedure> mzzzzzzzzzzzzzzd_ = context.Operators.SelectMany<Procedure, Procedure>(mzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzc_);
        bool? mzzzzzzzzzzzzzze_ = context.Operators.Exists<Procedure>(mzzzzzzzzzzzzzzd_);

        return mzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Has Bone Scan Study Performed with Documented Reason")]
    public bool? Has_Bone_Scan_Study_Performed_with_Documented_Reason(CqlContext context)
    {
        IEnumerable<Observation> mzzzzzzzzzzzzzzw_ = this.Bone_Scan_Study_Performed(context);
        bool? mzzzzzzzzzzzzzzx_(Observation BoneScanAfterDiagnosis)
        {
            DataType nzzzzzzzzzzzzzza_ = BoneScanAfterDiagnosis?.Value;
            object nzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzza_);
            CqlCode nzzzzzzzzzzzzzzc_ = this.Procedure_reason_record__record_artifact_(context);
            CqlConcept nzzzzzzzzzzzzzzd_ = context.Operators.ConvertCodeToConcept(nzzzzzzzzzzzzzzc_);
            bool? nzzzzzzzzzzzzzze_ = context.Operators.Equivalent(nzzzzzzzzzzzzzzb_ as CqlConcept, nzzzzzzzzzzzzzzd_);

            return nzzzzzzzzzzzzzze_;
        };
        IEnumerable<Observation> mzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(mzzzzzzzzzzzzzzw_, mzzzzzzzzzzzzzzx_);
        bool? mzzzzzzzzzzzzzzz_ = context.Operators.Exists<Observation>(mzzzzzzzzzzzzzzy_);

        return mzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        bool? nzzzzzzzzzzzzzzf_ = this.Has_Diagnosis_of_Pain_related_to_Prostate_Cancer(context);
        bool? nzzzzzzzzzzzzzzg_ = this.Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis(context);
        bool? nzzzzzzzzzzzzzzh_ = context.Operators.Or(nzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzg_);
        bool? nzzzzzzzzzzzzzzi_ = this.Has_Bone_Scan_Study_Performed_with_Documented_Reason(context);
        bool? nzzzzzzzzzzzzzzj_ = context.Operators.Or(nzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzi_);

        return nzzzzzzzzzzzzzzj_;
    }


    #endregion Expressions

}
