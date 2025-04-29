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
        CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzzzzzzzzzzzza_, true, true);
        object wzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.ResolveParameter("ProstateCaAvoidanceBoneScanOveruseFHIR-0.3.000", "Measurement Period", wzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return (CqlInterval<CqlDateTime>)wzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> wzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient wzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SingletonFrom<Patient>(wzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? wzzzzzzzzzzzzzzzzzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> wzzzzzzzzzzzzzzzzzzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? wzzzzzzzzzzzzzzzzzzzzzzzzzh_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode wzzzzzzzzzzzzzzzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Prostate Cancer Diagnosis")]
    public IEnumerable<Condition> Prostate_Cancer_Diagnosis(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Prostate_Cancer(context);
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzl_(Condition ProstateCancer)
        {
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ProstateCancer);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Overlaps(wzzzzzzzzzzzzzzzzzzzzzzzzzn_, wzzzzzzzzzzzzzzzzzzzzzzzzzo_, "day");
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, ProstateCancer);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, ProstateCancer);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Or(wzzzzzzzzzzzzzzzzzzzzzzzzzq_, wzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzp_, wzzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Condition>(wzzzzzzzzzzzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Prostate_Cancer_Diagnosis(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Condition>(wzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("First Prostate Cancer Treatment during day of Measurement Period")]
    public Procedure First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Prostate_Cancer_Treatment(context);
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzy_(Procedure ProstateCancerTreatment)
        {
            DataType xzzzzzzzzzzzzzzzzzzzzzzzzzd_ = ProstateCancerTreatment?.Performed;
            object xzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.End(xzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzg_, xzzzzzzzzzzzzzzzzzzzzzzzzzh_, "day");
            Code<EventStatus> xzzzzzzzzzzzzzzzzzzzzzzzzzj_ = ProstateCancerTreatment?.StatusElement;
            EventStatus? xzzzzzzzzzzzzzzzzzzzzzzzzzk_ = xzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
            string xzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<string>(xzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Equal(xzzzzzzzzzzzzzzzzzzzzzzzzzl_, "completed");
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Procedure>(wzzzzzzzzzzzzzzzzzzzzzzzzzx_, wzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        object xzzzzzzzzzzzzzzzzzzzzzzzzza_(Procedure @this)
        {
            DataType xzzzzzzzzzzzzzzzzzzzzzzzzzo_ = @this?.Performed;
            object xzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SortBy<Procedure>(wzzzzzzzzzzzzzzzzzzzzzzzzzz_, xzzzzzzzzzzzzzzzzzzzzzzzzza_, System.ComponentModel.ListSortDirection.Ascending);
        Procedure xzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.First<Procedure>(xzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Most Recent Prostate Cancer Staging Tumor Size T1a to T2a")]
    public Observation Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a(CqlContext context)
    {
        CqlCode xzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Tumor_staging__tumor_staging_(context);
        IEnumerable<CqlCode> xzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ToList<CqlCode>(xzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, xzzzzzzzzzzzzzzzzzzzzzzzzzt_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzv_(Observation ProstateCancerStaging)
        {
            Procedure yzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period(context);
            Procedure[] yzzzzzzzzzzzzzzzzzzzzzzzzzf_ = [
                yzzzzzzzzzzzzzzzzzzzzzzzzze_,
            ];
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzg_(Procedure FirstProstateCancerTreatment)
            {
                DataType yzzzzzzzzzzzzzzzzzzzzzzzzzk_ = ProstateCancerStaging?.Effective;
                object yzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                DataType yzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FirstProstateCancerTreatment?.Performed;
                object yzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Before(yzzzzzzzzzzzzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzzzzzzzzzzzzr_, default);
                Code<ObservationStatus> yzzzzzzzzzzzzzzzzzzzzzzzzzt_ = ProstateCancerStaging?.StatusElement;
                ObservationStatus? yzzzzzzzzzzzzzzzzzzzzzzzzzu_ = yzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
                Code<ObservationStatus> yzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<Code<ObservationStatus>>(yzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                string yzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(yzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                string[] yzzzzzzzzzzzzzzzzzzzzzzzzzx_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<string>(yzzzzzzzzzzzzzzzzzzzzzzzzzw_, yzzzzzzzzzzzzzzzzzzzzzzzzzx_ as IEnumerable<string>);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                return yzzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Procedure> yzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)yzzzzzzzzzzzzzzzzzzzzzzzzzf_, yzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            Observation yzzzzzzzzzzzzzzzzzzzzzzzzzi_(Procedure FirstProstateCancerTreatment) =>
                ProstateCancerStaging;
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Procedure, Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SelectMany<Observation, Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzu_, xzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        object xzzzzzzzzzzzzzzzzzzzzzzzzzx_(Observation @this)
        {
            DataType zzzzzzzzzzzzzzzzzzzzzzzzzza_ = @this?.Effective;
            object zzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SortBy<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzzzzzzzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
        Observation xzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Last<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        Observation[] yzzzzzzzzzzzzzzzzzzzzzzzzza_ = [
            xzzzzzzzzzzzzzzzzzzzzzzzzzz_,
        ];
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzb_(Observation LastProstateCancerStaging)
        {
            DataType zzzzzzzzzzzzzzzzzzzzzzzzzze_ = LastProstateCancerStaging?.Value;
            object zzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlCode zzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.T1a__Prostate_tumor_incidental_histologic_finding_in_5_percent_or_less_of_tissue_resected__finding_(context);
            CqlConcept zzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertCodeToConcept(zzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Equivalent(zzzzzzzzzzzzzzzzzzzzzzzzzzf_ as CqlConcept, zzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            object zzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlCode zzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.T1b__Prostate_tumor_incidental_histologic_finding_in_greater_than_5_percent_of_tissue_resected__finding_(context);
            CqlConcept zzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConvertCodeToConcept(zzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Equivalent(zzzzzzzzzzzzzzzzzzzzzzzzzzk_ as CqlConcept, zzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzzzzzzi_, zzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            object zzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlCode zzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Neoplasm_of_prostate_primary_tumor_staging_category_T1c__Tumor_identified_by_needle_biopsy__finding_(context);
            CqlConcept zzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertCodeToConcept(zzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Equivalent(zzzzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlConcept, zzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            object zzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlCode zzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Neoplasm_of_prostate_primary_tumor_staging_category_T2a__Involves_one_half_of_one_lobe_or_less__finding_(context);
            CqlConcept zzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertCodeToConcept(zzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equivalent(zzzzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlConcept, zzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>((IEnumerable<Observation>)yzzzzzzzzzzzzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        Observation yzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SingletonFrom<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Most Recent PSA Test Result is Low")]
    public bool? Most_Recent_PSA_Test_Result_is_Low(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Prostate_Specific_Antigen_Test(context);
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzd_(Observation PSATest)
        {
            Observation azzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a(context);
            Observation[] azzzzzzzzzzzzzzzzzzzzzzzzzzo_ = [
                azzzzzzzzzzzzzzzzzzzzzzzzzzn_,
            ];
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation MostRecentProstateCancerStaging)
            {
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzt_()
                {
                    bool bzzzzzzzzzzzzzzzzzzzzzzzzzzf_()
                    {
                        DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = PSATest?.Effective;
                        object bzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                        CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                        CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                        return bzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is null;
                    };
                    if (bzzzzzzzzzzzzzzzzzzzzzzzzzzf_())
                    {
                        return default;
                    }
                    else
                    {
                        DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = PSATest?.Effective;
                        object bzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                        CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                        CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                        object bzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                        CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                        CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                        CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(bzzzzzzzzzzzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzzzzzzzzzzzr_, true, true);

                        return bzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
                    }
                };
                DataType azzzzzzzzzzzzzzzzzzzzzzzzzzu_ = MostRecentProstateCancerStaging?.Effective;
                object azzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Before(azzzzzzzzzzzzzzzzzzzzzzzzzzt_(), azzzzzzzzzzzzzzzzzzzzzzzzzzw_, default);
                Code<ObservationStatus> azzzzzzzzzzzzzzzzzzzzzzzzzzy_ = PSATest?.StatusElement;
                ObservationStatus? azzzzzzzzzzzzzzzzzzzzzzzzzzz_ = azzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
                Code<ObservationStatus> bzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<Code<ObservationStatus>>(azzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                string bzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                string[] bzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<string>(bzzzzzzzzzzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as IEnumerable<string>);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzx_, bzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>((IEnumerable<Observation>)azzzzzzzzzzzzzzzzzzzzzzzzzzo_, azzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            Observation azzzzzzzzzzzzzzzzzzzzzzzzzzr_(Observation MostRecentProstateCancerStaging) =>
                PSATest;
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Observation, Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzzzzzzzzzzzzr_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SelectMany<Observation, Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        object azzzzzzzzzzzzzzzzzzzzzzzzzzf_(Observation @this)
        {
            DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Effective;
            object bzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SortBy<Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzzzzzzzzzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
        Observation azzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Last<Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        Observation[] azzzzzzzzzzzzzzzzzzzzzzzzzzi_ = [
            azzzzzzzzzzzzzzzzzzzzzzzzzzh_,
        ];
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzj_(Observation LastPSATest)
        {
            DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = LastPSATest?.Value;
            object bzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlQuantity bzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(10m, "ng/mL");
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Less(bzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as CqlQuantity, bzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<bool?> azzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Observation, bool?>((IEnumerable<Observation>)azzzzzzzzzzzzzzzzzzzzzzzzzzi_, azzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<bool?> azzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<bool?>(azzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SingletonFrom<bool?>(azzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Most Recent Gleason Score is Low")]
    public bool? Most_Recent_Gleason_Score_is_Low(CqlContext context)
    {
        CqlCode czzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Gleason_score_in_Specimen_Qualitative(context);
        IEnumerable<CqlCode> czzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ToList<CqlCode>(czzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, czzzzzzzzzzzzzzzzzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzze_(Observation GleasonScore)
        {
            Procedure czzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period(context);
            Procedure[] czzzzzzzzzzzzzzzzzzzzzzzzzzp_ = [
                czzzzzzzzzzzzzzzzzzzzzzzzzzo_,
            ];
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzq_(Procedure FirstProstateCancerTreatment)
            {
                DataType czzzzzzzzzzzzzzzzzzzzzzzzzzu_ = GleasonScore?.Effective;
                object czzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                DataType czzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FirstProstateCancerTreatment?.Performed;
                object czzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Before(czzzzzzzzzzzzzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default);
                Code<ObservationStatus> dzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = GleasonScore?.StatusElement;
                ObservationStatus? dzzzzzzzzzzzzzzzzzzzzzzzzzze_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
                Code<ObservationStatus> dzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<Code<ObservationStatus>>(dzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                string dzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(dzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                string[] dzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<string>(dzzzzzzzzzzzzzzzzzzzzzzzzzzg_, dzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as IEnumerable<string>);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                return dzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)czzzzzzzzzzzzzzzzzzzzzzzzzzp_, czzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            Observation czzzzzzzzzzzzzzzzzzzzzzzzzzs_(Procedure FirstProstateCancerTreatment) =>
                GleasonScore;
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<Procedure, Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SelectMany<Observation, Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzd_, czzzzzzzzzzzzzzzzzzzzzzzzzze_);
        object czzzzzzzzzzzzzzzzzzzzzzzzzzg_(Observation @this)
        {
            DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = @this?.Effective;
            object dzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SortBy<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzzzzzzzzzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
        Observation czzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Last<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        Observation[] czzzzzzzzzzzzzzzzzzzzzzzzzzj_ = [
            czzzzzzzzzzzzzzzzzzzzzzzzzzi_,
        ];
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation LastGleasonScore)
        {
            DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = LastGleasonScore?.Value;
            object dzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.LessOrEqual(dzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as int?, 6);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<bool?> czzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Observation, bool?>((IEnumerable<Observation>)czzzzzzzzzzzzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<bool?> czzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Distinct<bool?>(czzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SingletonFrom<bool?>(czzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Initial_Population(context);
        Procedure dzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period(context);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is null));
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzr_, dzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        Observation dzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a(context);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzzzzzzzzzzzzv_ is null));
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzu_, dzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Most_Recent_PSA_Test_Result_is_Low(context);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Most_Recent_Gleason_Score_is_Low(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Bone Scan Study Performed")]
    public IEnumerable<Observation> Bone_Scan_Study_Performed(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Bone_Scan(context);
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzze_(Observation BoneScan)
        {
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Prostate_Cancer_Diagnosis(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzj_(Condition ActiveProstateCancer)
            {
                DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzn_ = BoneScan?.Effective;
                object ezzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ActiveProstateCancer);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.After(ezzzzzzzzzzzzzzzzzzzzzzzzzzq_, ezzzzzzzzzzzzzzzzzzzzzzzzzzs_, default);

                return ezzzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzi_, ezzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            Observation ezzzzzzzzzzzzzzzzzzzzzzzzzzl_(Condition ActiveProstateCancer) =>
                BoneScan;
            IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<Condition, Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzk_, ezzzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SelectMany<Observation, Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzd_, ezzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzg_(Observation BoneScan)
        {
            DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzu_ = BoneScan?.Effective;
            object ezzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.End(ezzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzx_, ezzzzzzzzzzzzzzzzzzzzzzzzzzy_, "day");

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Bone_Scan_Study_Performed(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not(fzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Has Diagnosis of Pain related to Prostate Cancer")]
    public bool? Has_Diagnosis_of_Pain_related_to_Prostate_Cancer(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Pain_Warranting_Further_Investigation_for_Prostate_Cancer(context);
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Condition ProstateCancerPain)
        {
            IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Prostate_Cancer_Diagnosis(context);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Condition ActiveProstateCancer)
            {
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ProstateCancerPain);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ActiveProstateCancer);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.After(fzzzzzzzzzzzzzzzzzzzzzzzzzzo_, fzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, ProstateCancerPain);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, ProstateCancerPain);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Or(fzzzzzzzzzzzzzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                return fzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            Condition fzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Condition ActiveProstateCancer) =>
                ProstateCancerPain;
            IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<Condition, Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SelectMany<Condition, Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzze_, fzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Has Salvage Therapy Performed after Prostate Cancer Diagnosis")]
    public bool? Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Salvage_Therapy(context);
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Procedure SalvageTherapy)
        {
            IEnumerable<Condition> gzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Prostate_Cancer_Diagnosis(context);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Condition ActiveProstateCancer)
            {
                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = SalvageTherapy?.Performed;
                object gzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ActiveProstateCancer);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.After(gzzzzzzzzzzzzzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default);
                Code<EventStatus> gzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = SalvageTherapy?.StatusElement;
                EventStatus? gzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
                string gzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(gzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Equal(gzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "completed");
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzm_, gzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

                return gzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Condition> gzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Condition>(gzzzzzzzzzzzzzzzzzzzzzzzzzzb_, gzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            Procedure gzzzzzzzzzzzzzzzzzzzzzzzzzze_(Condition ActiveProstateCancer) =>
                SalvageTherapy;
            IEnumerable<Procedure> gzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<Condition, Procedure>(gzzzzzzzzzzzzzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SelectMany<Procedure, Procedure>(fzzzzzzzzzzzzzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Procedure>(fzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Has Bone Scan Study Performed with Documented Reason")]
    public bool? Has_Bone_Scan_Study_Performed_with_Documented_Reason(CqlContext context)
    {
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Bone_Scan_Study_Performed(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Observation BoneScanAfterDiagnosis)
        {
            DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = BoneScanAfterDiagnosis?.Value;
            object gzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlCode gzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Procedure_reason_record__record_artifact_(context);
            CqlConcept gzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertCodeToConcept(gzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Equivalent(gzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as CqlConcept, gzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzzs_, gzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Has_Diagnosis_of_Pain_related_to_Prostate_Cancer(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzzzzzzzzzzb_, hzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Has_Bone_Scan_Study_Performed_with_Documented_Reason(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    #endregion Expressions

}
