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
[CqlLibrary("IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR", "1.4.000")]
public partial class IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR_1_4_000 : ILibrary, ISingleton<IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR_1_4_000>
{
    private IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR_1_4_000() {}

    public static IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR_1_4_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR";
    public string Version => "1.4.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: Active Tuberculosis for Urology Care
    [CqlValueSetDefinition(
        definitionName: "Active Tuberculosis for Urology Care",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.56",
        valueSetVersion: null)]
    public CqlValueSet Active_Tuberculosis_for_Urology_Care(CqlContext context) => _Active_Tuberculosis_for_Urology_Care;

    private static readonly CqlValueSet _Active_Tuberculosis_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.56", null);
    #endregion

    #region ValueSet: BCG Bacillus Calmette Guerin for Urology Care
    [CqlValueSetDefinition(
        definitionName: "BCG Bacillus Calmette Guerin for Urology Care",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.52",
        valueSetVersion: null)]
    public CqlValueSet BCG_Bacillus_Calmette_Guerin_for_Urology_Care(CqlContext context) => _BCG_Bacillus_Calmette_Guerin_for_Urology_Care;

    private static readonly CqlValueSet _BCG_Bacillus_Calmette_Guerin_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.52", null);
    #endregion

    #region ValueSet: Bladder Cancer for Urology Care
    [CqlValueSetDefinition(
        definitionName: "Bladder Cancer for Urology Care",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.45",
        valueSetVersion: null)]
    public CqlValueSet Bladder_Cancer_for_Urology_Care(CqlContext context) => _Bladder_Cancer_for_Urology_Care;

    private static readonly CqlValueSet _Bladder_Cancer_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.45", null);
    #endregion

    #region ValueSet: Chemotherapy Agents for Advanced Cancer
    [CqlValueSetDefinition(
        definitionName: "Chemotherapy Agents for Advanced Cancer",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.60",
        valueSetVersion: null)]
    public CqlValueSet Chemotherapy_Agents_for_Advanced_Cancer(CqlContext context) => _Chemotherapy_Agents_for_Advanced_Cancer;

    private static readonly CqlValueSet _Chemotherapy_Agents_for_Advanced_Cancer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.60", null);
    #endregion

    #region ValueSet: Cystectomy for Urology Care
    [CqlValueSetDefinition(
        definitionName: "Cystectomy for Urology Care",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.55",
        valueSetVersion: null)]
    public CqlValueSet Cystectomy_for_Urology_Care(CqlContext context) => _Cystectomy_for_Urology_Care;

    private static readonly CqlValueSet _Cystectomy_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.55", null);
    #endregion

    #region ValueSet: HIV
    [CqlValueSetDefinition(
        definitionName: "HIV",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003",
        valueSetVersion: null)]
    public CqlValueSet HIV(CqlContext context) => _HIV;

    private static readonly CqlValueSet _HIV = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", null);
    #endregion

    #region ValueSet: Immunocompromised Conditions
    [CqlValueSetDefinition(
        definitionName: "Immunocompromised Conditions",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.1940",
        valueSetVersion: null)]
    public CqlValueSet Immunocompromised_Conditions(CqlContext context) => _Immunocompromised_Conditions;

    private static readonly CqlValueSet _Immunocompromised_Conditions = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.1940", null);
    #endregion

    #region ValueSet: Immunosuppressive Drugs for Urology Care
    [CqlValueSetDefinition(
        definitionName: "Immunosuppressive Drugs for Urology Care",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.32",
        valueSetVersion: null)]
    public CqlValueSet Immunosuppressive_Drugs_for_Urology_Care(CqlContext context) => _Immunosuppressive_Drugs_for_Urology_Care;

    private static readonly CqlValueSet _Immunosuppressive_Drugs_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.32", null);
    #endregion

    #region ValueSet: Mixed histology urothelial cell carcinoma for Urology Care
    [CqlValueSetDefinition(
        definitionName: "Mixed histology urothelial cell carcinoma for Urology Care",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.39",
        valueSetVersion: null)]
    public CqlValueSet Mixed_histology_urothelial_cell_carcinoma_for_Urology_Care(CqlContext context) => _Mixed_histology_urothelial_cell_carcinoma_for_Urology_Care;

    private static readonly CqlValueSet _Mixed_histology_urothelial_cell_carcinoma_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.39", null);
    #endregion

    #region ValueSet: Office Visit
    [CqlValueSetDefinition(
        definitionName: "Office Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext context) => _Office_Visit;

    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);
    #endregion

    #region ValueSet: Unavailability of Bacillus Calmette Guerin for urology care
    [CqlValueSetDefinition(
        definitionName: "Unavailability of Bacillus Calmette Guerin for urology care",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.44",
        valueSetVersion: null)]
    public CqlValueSet Unavailability_of_Bacillus_Calmette_Guerin_for_urology_care(CqlContext context) => _Unavailability_of_Bacillus_Calmette_Guerin_for_urology_care;

    private static readonly CqlValueSet _Unavailability_of_Bacillus_Calmette_Guerin_for_urology_care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.44", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: American Joint Committee on Cancer cT1 (qualifier value)
    [CqlCodeDefinition(
        definitionName: "American Joint Committee on Cancer cT1 (qualifier value)",
        codeId: "1228889001",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode American_Joint_Committee_on_Cancer_cT1__qualifier_value_(CqlContext context) => _American_Joint_Committee_on_Cancer_cT1__qualifier_value_;

    private static readonly CqlCode _American_Joint_Committee_on_Cancer_cT1__qualifier_value_ = new CqlCode("1228889001", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: American Joint Committee on Cancer cTa (qualifier value)
    [CqlCodeDefinition(
        definitionName: "American Joint Committee on Cancer cTa (qualifier value)",
        codeId: "1228883000",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode American_Joint_Committee_on_Cancer_cTa__qualifier_value_(CqlContext context) => _American_Joint_Committee_on_Cancer_cTa__qualifier_value_;

    private static readonly CqlCode _American_Joint_Committee_on_Cancer_cTa__qualifier_value_ = new CqlCode("1228883000", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: American Joint Committee on Cancer cTis (qualifier value)
    [CqlCodeDefinition(
        definitionName: "American Joint Committee on Cancer cTis (qualifier value)",
        codeId: "1228884006",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode American_Joint_Committee_on_Cancer_cTis__qualifier_value_(CqlContext context) => _American_Joint_Committee_on_Cancer_cTis__qualifier_value_;

    private static readonly CqlCode _American_Joint_Committee_on_Cancer_cTis__qualifier_value_ = new CqlCode("1228884006", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Carcinoma in situ of bladder
    [CqlCodeDefinition(
        definitionName: "Carcinoma in situ of bladder",
        codeId: "D09.0",
        codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode Carcinoma_in_situ_of_bladder(CqlContext context) => _Carcinoma_in_situ_of_bladder;

    private static readonly CqlCode _Carcinoma_in_situ_of_bladder = new CqlCode("D09.0", "http://hl7.org/fhir/sid/icd-10-cm", default, default);
    #endregion

    #region Code: Combined radiotherapy (procedure)
    [CqlCodeDefinition(
        definitionName: "Combined radiotherapy (procedure)",
        codeId: "169331000",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Combined_radiotherapy__procedure_(CqlContext context) => _Combined_radiotherapy__procedure_;

    private static readonly CqlCode _Combined_radiotherapy__procedure_ = new CqlCode("169331000", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Tumor staging (tumor staging)
    [CqlCodeDefinition(
        definitionName: "Tumor staging (tumor staging)",
        codeId: "254292007",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Tumor_staging__tumor_staging_(CqlContext context) => _Tumor_staging__tumor_staging_;

    private static readonly CqlCode _Tumor_staging__tumor_staging_ = new CqlCode("254292007", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: virtual
    [CqlCodeDefinition(
        definitionName: "virtual",
        codeId: "VR",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode @virtual(CqlContext context) => _virtual;

    private static readonly CqlCode _virtual = new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = [
            new CqlCode("1228889001", "http://snomed.info/sct", default, default),
            new CqlCode("1228883000", "http://snomed.info/sct", default, default),
            new CqlCode("1228884006", "http://snomed.info/sct", default, default),
            new CqlCode("169331000", "http://snomed.info/sct", default, default),
            new CqlCode("254292007", "http://snomed.info/sct", default, default),
        ];

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ICD10CM")]
    public CqlCode[] ICD10CM(CqlContext context)
    {
        CqlCode[] uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = [
            new CqlCode("D09.0", "http://hl7.org/fhir/sid/icd-10-cm", default, default),
        ];

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ActCode")]
    public CqlCode[] ActCode(CqlContext context)
    {
        CqlCode[] uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = [
            new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
        ];

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, true, true);
        object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.ResolveParameter("IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR-1.4.000", "Measurement Period", uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return (CqlInterval<CqlDateTime>)uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SingletonFrom<Patient>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public bool? isConfirmedActiveDiagnosis(CqlContext context, Condition Condition)
    {
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.isActive(context, Condition);
        CodeableConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = Condition?.VerificationStatus;
        CqlConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        CqlCode uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.confirmed(context);
        CqlConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConvertCodeToConcept(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Equivalent(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Bladder Cancer Diagnosis")]
    public IEnumerable<Condition> Bladder_Cancer_Diagnosis(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Bladder_Cancer_for_Urology_Care(context);
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Condition BladderCancer)
        {
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, BladderCancer);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.End(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Before(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.isConfirmedActiveDiagnosis(context, BladderCancer);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Condition>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "First Bladder Cancer Staging Procedure")]
    public Procedure First_Bladder_Cancer_Staging_Procedure(CqlContext context)
    {
        CqlCode vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Tumor_staging__tumor_staging_(context);
        IEnumerable<CqlCode> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ToList<CqlCode>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Procedure BladderCancerStaging)
        {
            IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Bladder_Cancer_Diagnosis(context);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Condition BladderCancer)
            {
                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = BladderCancerStaging?.Performed;
                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, BladderCancer);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SameOrBefore(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "day");

                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Condition>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            Procedure vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Condition BladderCancer) =>
                BladderCancerStaging;
            IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Condition, Procedure>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SelectMany<Procedure, Procedure>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Procedure BladderCancerStaging)
        {
            Code<EventStatus> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = BladderCancerStaging?.StatusElement;
            EventStatus? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
            string wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Equal(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "completed");

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Procedure>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Procedure @this)
        {
            DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = @this?.Performed;
            object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SortBy<Procedure>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
        Procedure vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.First<Procedure>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "July 1 of Year Prior to the Measurement Period")]
    public CqlDateTime July_1_of_Year_Prior_to_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
        CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        int? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateTimeComponentFrom(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, "year");
        int? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Subtract(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, 1);
        decimal? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateTime(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, 7, 1, 0, 0, 0, 0, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "June 30 of the Measurement Period")]
    public CqlDateTime June_30_of_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
        CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        int? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateTimeComponentFrom(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "year");
        decimal? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateTime(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, 6, 30, 23, 59, 59, 0, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "First Bladder Cancer Staging Procedure during 6 Months Prior to Measurement Period through the First 6 Months of Measurement Period")]
    public Procedure First_Bladder_Cancer_Staging_Procedure_during_6_Months_Prior_to_Measurement_Period_through_the_First_6_Months_of_Measurement_Period(CqlContext context)
    {
        Procedure xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.First_Bladder_Cancer_Staging_Procedure(context);
        Procedure[] xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = [
            xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_,
        ];
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Procedure FirstBladderCancerStaging)
        {
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.July_1_of_Year_Prior_to_the_Measurement_Period(context);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.June_30_of_the_Measurement_Period(context);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, true, true);
            DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FirstBladderCancerStaging?.Performed;
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, "day");

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        Procedure xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SingletonFrom<Procedure>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Procedure> getStagingProcedure(CqlContext context, Observation StagingObservation)
    {
        List<ResourceReference> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = StagingObservation?.PartOf;
        Procedure xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(ResourceReference StagingReference)
        {
            Procedure xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.First_Bladder_Cancer_Staging_Procedure_during_6_Months_Prior_to_Measurement_Period_through_the_First_6_Months_of_Measurement_Period(context);
            Procedure[] xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = [
                xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_,
            ];
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Procedure FirstBladderCancerStagingMP)
            {
                Id xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FirstBladderCancerStagingMP?.IdElement;
                string xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
                FhirString xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = StagingReference?.ReferenceElement;
                string xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
                string xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.getId(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Equal(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            Procedure xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SingletonFrom<Procedure>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<ResourceReference, Procedure>((IEnumerable<ResourceReference>)xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Distinct<Procedure>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Most Recent Bladder Cancer Tumor Staging is Ta HG, Tis, T1")]
    public bool? Has_Most_Recent_Bladder_Cancer_Tumor_Staging_is_Ta_HG__Tis__T1(CqlContext context)
    {
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Observation StagingObservation)
        {
            IEnumerable<Procedure> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.getStagingProcedure(context, StagingObservation);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ is null));
            DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = StagingObservation?.Value;
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlCode yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.American_Joint_Committee_on_Cancer_cT1__qualifier_value_(context);
            CqlConcept yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertCodeToConcept(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equivalent(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlConcept, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlCode yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.American_Joint_Committee_on_Cancer_cTis__qualifier_value_(context);
            CqlConcept yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertCodeToConcept(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Equivalent(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlConcept, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlCode yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.American_Joint_Committee_on_Cancer_cTa__qualifier_value_(context);
            CqlConcept yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertCodeToConcept(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Equivalent(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlConcept, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Or(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlCode zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Carcinoma_in_situ_of_bladder(context);
            CqlConcept zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConvertCodeToConcept(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Equivalent(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as CqlConcept, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Or(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            Code<ObservationStatus> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = StagingObservation?.StatusElement;
            ObservationStatus? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
            Code<ObservationStatus> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<Code<ObservationStatus>>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            string zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<string>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            string[] zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<string>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as IEnumerable<string>);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Qualifying Encounter")]
    public bool? Has_Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Office_Visit(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            Period zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default);
            Coding zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = ValidEncounter?.Class;
            CqlCode zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToCode(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlCode zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.@virtual(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Equivalent(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            Code<Encounter.EncounterStatus> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
            Code<Encounter.EncounterStatus> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Equal(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "finished");
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Has_Most_Recent_Bladder_Cancer_Tumor_Staging_is_Ta_HG__Tis__T1(context);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Has_Qualifying_Encounter(context);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Initial_Population(context);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Acute Tuberculosis Diagnosis")]
    public IEnumerable<Condition> Acute_Tuberculosis_Diagnosis(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Active_Tuberculosis_for_Urology_Care(context);
        IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Condition ActiveTuberculosis)
        {
            Procedure azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = [
                azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_,
            ];
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Procedure FirstBladderCancerStaging)
            {
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ActiveTuberculosis);
                DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FirstBladderCancerStaging?.Performed;
                object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.OverlapsAfter(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "day");

                return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            Condition azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Procedure FirstBladderCancerStaging) =>
                ActiveTuberculosis;
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Procedure, Condition>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SelectMany<Condition, Condition>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Condition ActiveTuberculosis)
        {
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.isConfirmedActiveDiagnosis(context, ActiveTuberculosis);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Condition>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Immunosuppressive Drugs")]
    public IEnumerable<MedicationRequest> Immunosuppressive_Drugs(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Immunosuppressive_Drugs_for_Urology_Care(context);
        IEnumerable<MedicationRequest> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<MedicationRequest>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<MedicationRequest> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(MedicationRequest ImmunosuppressiveDrugs)
        {
            Procedure bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = [
                bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_,
            ];
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Procedure FirstBladderCancerStaging)
            {
                List<Dosage> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = ImmunosuppressiveDrugs?.DosageInstruction;
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Dosage @this)
                {
                    Timing dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Timing;
                    bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ is null));

                    return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
                };
                IEnumerable<Dosage> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                Timing bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Dosage @this)
                {
                    Timing dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = @this?.Timing;

                    return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                };
                IEnumerable<Timing> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Dosage, Timing>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Timing dosageTiming)
                {
                    List<FhirDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = dosageTiming?.EventElement;
                    IEnumerable<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.LateBoundProperty<IEnumerable<CqlDateTime>>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "value");
                    IEnumerable<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ListSort<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
                    CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.First<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                    return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
                };
                IEnumerable<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<Timing, CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                IEnumerable<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Distinct<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                IEnumerable<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ListSort<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.First<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as object);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Dosage @this)
                {
                    Timing dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Timing;
                    bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is null));

                    return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                };
                IEnumerable<Dosage> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                Timing czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Dosage @this)
                {
                    Timing dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = @this?.Timing;

                    return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
                };
                IEnumerable<Timing> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Dosage, Timing>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Timing @this)
                {
                    Timing.RepeatComponent dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = @this?.Repeat;
                    bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ is null));

                    return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
                };
                IEnumerable<Timing> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Timing>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                Timing.RepeatComponent czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Timing @this)
                {
                    Timing.RepeatComponent dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = @this?.Repeat;

                    return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
                };
                IEnumerable<Timing.RepeatComponent> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Timing, Timing.RepeatComponent>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Timing.RepeatComponent @this)
                {
                    DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = @this?.Bounds;
                    object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                    bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ is null));

                    return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
                };
                IEnumerable<Timing.RepeatComponent> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Timing.RepeatComponent>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Timing.RepeatComponent @this)
                {
                    DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = @this?.Bounds;
                    object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                    return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
                };
                IEnumerable<object> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Timing.RepeatComponent, object>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(object DoseTime)
                {
                    CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, DoseTime);

                    return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                IEnumerable<CqlInterval<CqlDateTime>> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                IEnumerable<CqlInterval<CqlDateTime>> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Collapse(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default);
                object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(CqlInterval<CqlDateTime> @this)
                {
                    CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(@this);

                    return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.First<CqlInterval<CqlDateTime>>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ ?? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FirstBladderCancerStaging?.Performed;
                object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SameOrBefore(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "day");

                return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Procedure> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            MedicationRequest bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Procedure FirstBladderCancerStaging) =>
                ImmunosuppressiveDrugs;
            IEnumerable<MedicationRequest> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Procedure, MedicationRequest>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<MedicationRequest> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(MedicationRequest ImmunosuppressiveDrugs)
        {
            Code<MedicationRequest.MedicationrequestStatus> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = ImmunosuppressiveDrugs?.StatusElement;
            MedicationRequest.MedicationrequestStatus? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
            string dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            string[] dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = [
                "active",
                "completed",
            ];
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<string>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = ImmunosuppressiveDrugs?.IntentElement;
            MedicationRequest.MedicationRequestIntent? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
            string ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<string>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Equal(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "order");
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<MedicationRequest> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<MedicationRequest>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "Cystectomy Done")]
    public IEnumerable<Procedure> Cystectomy_Done(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Cystectomy_for_Urology_Care(context);
        IEnumerable<Procedure> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Procedure Cystectomy)
        {
            Procedure ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = [
                ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_,
            ];
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Procedure FirstBladderCancerStaging)
            {
                DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = Cystectomy?.Performed;
                object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.End(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FirstBladderCancerStaging?.Performed;
                object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlQuantity fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(6m, "months");
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Subtract(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, true, false);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default);
                object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ is null));
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Procedure> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            Procedure ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Procedure FirstBladderCancerStaging) =>
                Cystectomy;
            IEnumerable<Procedure> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Procedure, Procedure>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Procedure> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<Procedure, Procedure>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Procedure Cystectomy)
        {
            Code<EventStatus> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = Cystectomy?.StatusElement;
            EventStatus? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
            string fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<string>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Equal(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, "completed");

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Procedure> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Procedure>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Excluding HIV, Immunocompromised Conditions or Mixed Histology Before Staging")]
    public bool? Has_Excluding_HIV__Immunocompromised_Conditions_or_Mixed_Histology_Before_Staging(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.HIV(context);
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Immunocompromised_Conditions(context);
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Mixed_histology_urothelial_cell_carcinoma_for_Urology_Care(context);
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Condition> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Condition ExclusionDiagnosis)
        {
            Procedure gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = [
                gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_,
            ];
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Procedure FirstBladderCancerStaging)
            {
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ExclusionDiagnosis);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FirstBladderCancerStaging?.Performed;
                object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SameOrBefore(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, "day");

                return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Procedure> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            Condition gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Procedure FirstBladderCancerStaging) =>
                ExclusionDiagnosis;
            IEnumerable<Condition> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Procedure, Condition>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Condition> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SelectMany<Condition, Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Condition ExclusionDiagnosis)
        {
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.isConfirmedActiveDiagnosis(context, ExclusionDiagnosis);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Condition> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Condition>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Condition>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Excluding Chemotherapy or Radiotherapy Procedure Before Staging")]
    public bool? Has_Excluding_Chemotherapy_or_Radiotherapy_Procedure_Before_Staging(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Chemotherapy_Agents_for_Advanced_Cancer(context);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(MedicationRequest ExclusionMed)
        {
            Procedure hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = [
                hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_,
            ];
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Procedure FirstBladderCancerStaging)
            {
                List<Dosage> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = ExclusionMed?.DosageInstruction;
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Dosage @this)
                {
                    Timing jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = @this?.Timing;
                    bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ is null));

                    return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
                };
                IEnumerable<Dosage> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                Timing hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Dosage @this)
                {
                    Timing jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = @this?.Timing;

                    return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
                };
                IEnumerable<Timing> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Dosage, Timing>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Timing @this)
                {
                    Timing.RepeatComponent jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Repeat;
                    bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ is null));

                    return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
                };
                IEnumerable<Timing> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Timing>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                Timing.RepeatComponent hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Timing @this)
                {
                    Timing.RepeatComponent jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Repeat;

                    return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
                };
                IEnumerable<Timing.RepeatComponent> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Timing, Timing.RepeatComponent>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Timing.RepeatComponent @this)
                {
                    DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = @this?.Bounds;
                    object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                    bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ is null));

                    return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
                };
                IEnumerable<Timing.RepeatComponent> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Timing.RepeatComponent>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Timing.RepeatComponent @this)
                {
                    DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.Bounds;
                    object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                    return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
                };
                IEnumerable<object> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<Timing.RepeatComponent, object>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(object DoseTime)
                {
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, DoseTime);

                    return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                IEnumerable<CqlInterval<CqlDateTime>> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                IEnumerable<CqlInterval<CqlDateTime>> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Collapse(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default);
                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(CqlInterval<CqlDateTime> @this)
                {
                    CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(@this);

                    return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.First<CqlInterval<CqlDateTime>>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FirstBladderCancerStaging?.Performed;
                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlQuantity izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(6m, "months");
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Subtract(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, true, false);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default);
                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ is null));
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

                return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            MedicationRequest hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Procedure FirstBladderCancerStaging) =>
                ExclusionMed;
            IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Procedure, MedicationRequest>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(MedicationRequest ExclusionMed)
        {
            Code<MedicationRequest.MedicationrequestStatus> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = ExclusionMed?.StatusElement;
            MedicationRequest.MedicationrequestStatus? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
            string jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            string[] jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = [
                "active",
                "completed",
            ];
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<string>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = ExclusionMed?.IntentElement;
            MedicationRequest.MedicationRequestIntent? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
            string jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equal(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "order");
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<MedicationRequest>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlCode hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Combined_radiotherapy__procedure_(context);
        IEnumerable<CqlCode> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Procedure ExclusionProcedure)
        {
            Procedure kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = [
                kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_,
            ];
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Procedure FirstBladderCancerStaging)
            {
                DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = ExclusionProcedure?.Performed;
                object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FirstBladderCancerStaging?.Performed;
                object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlQuantity kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(6m, "months");
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Subtract(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, true, false);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default);
                object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ is null));
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            Procedure kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Procedure FirstBladderCancerStaging) =>
                ExclusionProcedure;
            IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Procedure, Procedure>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SelectMany<Procedure, Procedure>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Procedure ExclusionProcedure)
        {
            Code<EventStatus> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = ExclusionProcedure?.StatusElement;
            EventStatus? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
            string lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Equal(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "completed");

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Procedure>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<object> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<object>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as IEnumerable<object>, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as IEnumerable<object>);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<object>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusion")]
    public bool? Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Acute_Tuberculosis_Diagnosis(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Exists<Condition>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Immunosuppressive_Drugs(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<MedicationRequest>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Or(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Cystectomy_Done(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Procedure>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Or(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Has_Excluding_HIV__Immunocompromised_Conditions_or_Mixed_Histology_Before_Staging(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Or(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Has_Excluding_Chemotherapy_or_Radiotherapy_Procedure_Before_Staging(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Or(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exception")]
    [CqlTag("commentedOut", "\"BCG Not Available Within 6 Months After Bladder Cancer Staging\"")]
    [CqlTag("commentedOutReason", "Negation issue related to https://github.com/cqframework/cql-execution/issues/296, which is tied to https://oncprojectracking.healthit.gov/support/browse/BONNIEMAT-1455. Due to this being the only logic in this population added 'false' as a placeholder.")]
    public bool? Denominator_Exception(CqlContext context) =>
        false;


    [CqlExpressionDefinition(
        definitionName: "First BCG Administered")]
    public MedicationAdministration First_BCG_Administered(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.BCG_Bacillus_Calmette_Guerin_for_Urology_Care(context);
        IEnumerable<MedicationAdministration> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<MedicationAdministration>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<MedicationAdministration> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(MedicationAdministration BCG)
        {
            Procedure mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = [
                mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_,
            ];
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Procedure FirstBladderCancerStaging)
            {
                DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = BCG?.Effective;
                object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FirstBladderCancerStaging?.Performed;
                object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlQuantity mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(6m, "months");
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Add(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, false, true);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default);
                object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ is null));
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Procedure> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            MedicationAdministration mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Procedure FirstBladderCancerStaging) =>
                BCG;
            IEnumerable<MedicationAdministration> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Procedure, MedicationAdministration>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<MedicationAdministration> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(MedicationAdministration BCG)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = BCG?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            string nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            string[] nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = [
                "in-progress",
                "completed",
            ];
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<string>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as IEnumerable<string>);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<MedicationAdministration> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<MedicationAdministration>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(MedicationAdministration @this)
        {
            DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = @this?.Effective;
            object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<MedicationAdministration> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SortBy<MedicationAdministration>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
        MedicationAdministration mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.First<MedicationAdministration>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        MedicationAdministration nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.First_BCG_Administered(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ is null));

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "BCG Not Available Within 6 Months After Bladder Cancer Staging")]
    public IEnumerable<MedicationAdministration> BCG_Not_Available_Within_6_Months_After_Bladder_Cancer_Staging(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.BCG_Bacillus_Calmette_Guerin_for_Urology_Care(context);
        IEnumerable<MedicationAdministration> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotadministered"));
        IEnumerable<MedicationAdministration> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotadministered"));
        IEnumerable<MedicationAdministration> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<MedicationAdministration>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<MedicationAdministration> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(MedicationAdministration BCGNotGiven)
        {
            Procedure ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = [
                ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_,
            ];
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Procedure FirstBladderCancerStaging)
            {
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Extension @this)
                {
                    string pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = @this?.Url;
                    FhirString pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<FhirString>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                    string pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToString(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                    bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Equal(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

                    return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
                };
                IEnumerable<Extension> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(BCGNotGiven is DomainResource
                        ? (BCGNotGiven as DomainResource).Extension
                        : default), ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Extension @this)
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = @this?.Value;

                    return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
                };
                IEnumerable<DataType> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<Extension, DataType>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SingletonFrom<DataType>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FirstBladderCancerStaging?.Performed;
                object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlQuantity pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(6m, "months");
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Add(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, false, true);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default);
                object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ is null));
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Procedure> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            MedicationAdministration ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Procedure FirstBladderCancerStaging) =>
                BCGNotGiven;
            IEnumerable<MedicationAdministration> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Procedure, MedicationAdministration>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<MedicationAdministration> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(MedicationAdministration BCGNotGiven)
        {
            List<CodeableConcept> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = BCGNotGiven?.StatusReason;
            CqlConcept pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(CodeableConcept @this)
            {
                CqlConcept qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<CqlConcept> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Unavailability_of_Bacillus_Calmette_Guerin_for_urology_care(context);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConceptsInValueSet(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<MedicationAdministration> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<MedicationAdministration>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    #endregion Expressions

}
