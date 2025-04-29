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

    [CqlValueSetDefinition("Active Tuberculosis for Urology Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.56", valueSetVersion: null)]
    public CqlValueSet Active_Tuberculosis_for_Urology_Care(CqlContext _) => _Active_Tuberculosis_for_Urology_Care;
    private static readonly CqlValueSet _Active_Tuberculosis_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.56", null);

    [CqlValueSetDefinition("BCG Bacillus Calmette Guerin for Urology Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.52", valueSetVersion: null)]
    public CqlValueSet BCG_Bacillus_Calmette_Guerin_for_Urology_Care(CqlContext _) => _BCG_Bacillus_Calmette_Guerin_for_Urology_Care;
    private static readonly CqlValueSet _BCG_Bacillus_Calmette_Guerin_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.52", null);

    [CqlValueSetDefinition("Bladder Cancer for Urology Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.45", valueSetVersion: null)]
    public CqlValueSet Bladder_Cancer_for_Urology_Care(CqlContext _) => _Bladder_Cancer_for_Urology_Care;
    private static readonly CqlValueSet _Bladder_Cancer_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.45", null);

    [CqlValueSetDefinition("Chemotherapy Agents for Advanced Cancer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.60", valueSetVersion: null)]
    public CqlValueSet Chemotherapy_Agents_for_Advanced_Cancer(CqlContext _) => _Chemotherapy_Agents_for_Advanced_Cancer;
    private static readonly CqlValueSet _Chemotherapy_Agents_for_Advanced_Cancer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.60", null);

    [CqlValueSetDefinition("Cystectomy for Urology Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.55", valueSetVersion: null)]
    public CqlValueSet Cystectomy_for_Urology_Care(CqlContext _) => _Cystectomy_for_Urology_Care;
    private static readonly CqlValueSet _Cystectomy_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.55", null);

    [CqlValueSetDefinition("HIV", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", valueSetVersion: null)]
    public CqlValueSet HIV(CqlContext _) => _HIV;
    private static readonly CqlValueSet _HIV = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", null);

    [CqlValueSetDefinition("Immunocompromised Conditions", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.1940", valueSetVersion: null)]
    public CqlValueSet Immunocompromised_Conditions(CqlContext _) => _Immunocompromised_Conditions;
    private static readonly CqlValueSet _Immunocompromised_Conditions = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.1940", null);

    [CqlValueSetDefinition("Immunosuppressive Drugs for Urology Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.32", valueSetVersion: null)]
    public CqlValueSet Immunosuppressive_Drugs_for_Urology_Care(CqlContext _) => _Immunosuppressive_Drugs_for_Urology_Care;
    private static readonly CqlValueSet _Immunosuppressive_Drugs_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.32", null);

    [CqlValueSetDefinition("Mixed histology urothelial cell carcinoma for Urology Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.39", valueSetVersion: null)]
    public CqlValueSet Mixed_histology_urothelial_cell_carcinoma_for_Urology_Care(CqlContext _) => _Mixed_histology_urothelial_cell_carcinoma_for_Urology_Care;
    private static readonly CqlValueSet _Mixed_histology_urothelial_cell_carcinoma_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.39", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Unavailability of Bacillus Calmette Guerin for urology care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.44", valueSetVersion: null)]
    public CqlValueSet Unavailability_of_Bacillus_Calmette_Guerin_for_urology_care(CqlContext _) => _Unavailability_of_Bacillus_Calmette_Guerin_for_urology_care;
    private static readonly CqlValueSet _Unavailability_of_Bacillus_Calmette_Guerin_for_urology_care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.44", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("American Joint Committee on Cancer cT1 (qualifier value)", codeId: "1228889001", codeSystem: "http://snomed.info/sct")]
    public CqlCode American_Joint_Committee_on_Cancer_cT1__qualifier_value_(CqlContext _) => _American_Joint_Committee_on_Cancer_cT1__qualifier_value_;
    private static readonly CqlCode _American_Joint_Committee_on_Cancer_cT1__qualifier_value_ = new CqlCode("1228889001", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("American Joint Committee on Cancer cTa (qualifier value)", codeId: "1228883000", codeSystem: "http://snomed.info/sct")]
    public CqlCode American_Joint_Committee_on_Cancer_cTa__qualifier_value_(CqlContext _) => _American_Joint_Committee_on_Cancer_cTa__qualifier_value_;
    private static readonly CqlCode _American_Joint_Committee_on_Cancer_cTa__qualifier_value_ = new CqlCode("1228883000", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("American Joint Committee on Cancer cTis (qualifier value)", codeId: "1228884006", codeSystem: "http://snomed.info/sct")]
    public CqlCode American_Joint_Committee_on_Cancer_cTis__qualifier_value_(CqlContext _) => _American_Joint_Committee_on_Cancer_cTis__qualifier_value_;
    private static readonly CqlCode _American_Joint_Committee_on_Cancer_cTis__qualifier_value_ = new CqlCode("1228884006", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Carcinoma in situ of bladder", codeId: "D09.0", codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode Carcinoma_in_situ_of_bladder(CqlContext _) => _Carcinoma_in_situ_of_bladder;
    private static readonly CqlCode _Carcinoma_in_situ_of_bladder = new CqlCode("D09.0", "http://hl7.org/fhir/sid/icd-10-cm", default, default);

    [CqlCodeDefinition("Combined radiotherapy (procedure)", codeId: "169331000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Combined_radiotherapy__procedure_(CqlContext _) => _Combined_radiotherapy__procedure_;
    private static readonly CqlCode _Combined_radiotherapy__procedure_ = new CqlCode("169331000", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Tumor staging (tumor staging)", codeId: "254292007", codeSystem: "http://snomed.info/sct")]
    public CqlCode Tumor_staging__tumor_staging_(CqlContext _) => _Tumor_staging__tumor_staging_;
    private static readonly CqlCode _Tumor_staging__tumor_staging_ = new CqlCode("254292007", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("virtual", codeId: "VR", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode @virtual(CqlContext _) => _virtual;
    private static readonly CqlCode _virtual = new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ICD10CM")]
    public CqlCodeSystem ICD10CM(CqlContext _) => _ICD10CM;
    private static readonly CqlCodeSystem _ICD10CM = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ActCode")]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime pzzzzzzzzzzzy_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime pzzzzzzzzzzzz_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> qzzzzzzzzzzza_ = context.Operators.Interval(pzzzzzzzzzzzy_, pzzzzzzzzzzzz_, true, true);
        object qzzzzzzzzzzzb_ = context.ResolveParameter("IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR-1.4.000", "Measurement Period", qzzzzzzzzzzza_);

        return (CqlInterval<CqlDateTime>)qzzzzzzzzzzzb_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> qzzzzzzzzzzzc_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient qzzzzzzzzzzzd_ = context.Operators.SingletonFrom<Patient>(qzzzzzzzzzzzc_);

        return qzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("isConfirmedActiveDiagnosis")]
    public bool? isConfirmedActiveDiagnosis(CqlContext context, Condition Condition)
    {
        bool? qzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.isActive(context, Condition);
        CodeableConcept qzzzzzzzzzzzf_ = Condition?.VerificationStatus;
        CqlConcept qzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, qzzzzzzzzzzzf_);
        CqlCode qzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.confirmed(context);
        CqlConcept qzzzzzzzzzzzi_ = context.Operators.ConvertCodeToConcept(qzzzzzzzzzzzh_);
        bool? qzzzzzzzzzzzj_ = context.Operators.Equivalent(qzzzzzzzzzzzg_, qzzzzzzzzzzzi_);
        bool? qzzzzzzzzzzzk_ = context.Operators.And(qzzzzzzzzzzze_, qzzzzzzzzzzzj_);

        return qzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Bladder Cancer Diagnosis")]
    public IEnumerable<Condition> Bladder_Cancer_Diagnosis(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzl_ = this.Bladder_Cancer_for_Urology_Care(context);
        IEnumerable<Condition> qzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? qzzzzzzzzzzzn_(Condition BladderCancer)
        {
            CqlInterval<CqlDateTime> qzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, BladderCancer);
            CqlDateTime qzzzzzzzzzzzq_ = context.Operators.Start(qzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzr_ = this.Measurement_Period(context);
            CqlDateTime qzzzzzzzzzzzs_ = context.Operators.End(qzzzzzzzzzzzr_);
            bool? qzzzzzzzzzzzt_ = context.Operators.Before(qzzzzzzzzzzzq_, qzzzzzzzzzzzs_, default);
            bool? qzzzzzzzzzzzu_ = this.isConfirmedActiveDiagnosis(context, BladderCancer);
            bool? qzzzzzzzzzzzv_ = context.Operators.And(qzzzzzzzzzzzt_, qzzzzzzzzzzzu_);

            return qzzzzzzzzzzzv_;
        };
        IEnumerable<Condition> qzzzzzzzzzzzo_ = context.Operators.Where<Condition>(qzzzzzzzzzzzm_, qzzzzzzzzzzzn_);

        return qzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("First Bladder Cancer Staging Procedure")]
    public Procedure First_Bladder_Cancer_Staging_Procedure(CqlContext context)
    {
        CqlCode qzzzzzzzzzzzw_ = this.Tumor_staging__tumor_staging_(context);
        IEnumerable<CqlCode> qzzzzzzzzzzzx_ = context.Operators.ToList<CqlCode>(qzzzzzzzzzzzw_);
        IEnumerable<Procedure> qzzzzzzzzzzzy_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, qzzzzzzzzzzzx_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> qzzzzzzzzzzzz_(Procedure BladderCancerStaging)
        {
            IEnumerable<Condition> rzzzzzzzzzzzg_ = this.Bladder_Cancer_Diagnosis(context);
            bool? rzzzzzzzzzzzh_(Condition BladderCancer)
            {
                DataType rzzzzzzzzzzzl_ = BladderCancerStaging?.Performed;
                object rzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzm_);
                CqlDateTime rzzzzzzzzzzzo_ = context.Operators.Start(rzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, BladderCancer);
                CqlDateTime rzzzzzzzzzzzq_ = context.Operators.Start(rzzzzzzzzzzzp_);
                bool? rzzzzzzzzzzzr_ = context.Operators.SameOrBefore(rzzzzzzzzzzzo_, rzzzzzzzzzzzq_, "day");

                return rzzzzzzzzzzzr_;
            };
            IEnumerable<Condition> rzzzzzzzzzzzi_ = context.Operators.Where<Condition>(rzzzzzzzzzzzg_, rzzzzzzzzzzzh_);
            Procedure rzzzzzzzzzzzj_(Condition BladderCancer) =>
                BladderCancerStaging;
            IEnumerable<Procedure> rzzzzzzzzzzzk_ = context.Operators.Select<Condition, Procedure>(rzzzzzzzzzzzi_, rzzzzzzzzzzzj_);

            return rzzzzzzzzzzzk_;
        };
        IEnumerable<Procedure> rzzzzzzzzzzza_ = context.Operators.SelectMany<Procedure, Procedure>(qzzzzzzzzzzzy_, qzzzzzzzzzzzz_);
        bool? rzzzzzzzzzzzb_(Procedure BladderCancerStaging)
        {
            Code<EventStatus> rzzzzzzzzzzzs_ = BladderCancerStaging?.StatusElement;
            EventStatus? rzzzzzzzzzzzt_ = rzzzzzzzzzzzs_?.Value;
            string rzzzzzzzzzzzu_ = context.Operators.Convert<string>(rzzzzzzzzzzzt_);
            bool? rzzzzzzzzzzzv_ = context.Operators.Equal(rzzzzzzzzzzzu_, "completed");

            return rzzzzzzzzzzzv_;
        };
        IEnumerable<Procedure> rzzzzzzzzzzzc_ = context.Operators.Where<Procedure>(rzzzzzzzzzzza_, rzzzzzzzzzzzb_);
        object rzzzzzzzzzzzd_(Procedure @this)
        {
            DataType rzzzzzzzzzzzw_ = @this?.Performed;
            object rzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzx_);
            CqlDateTime rzzzzzzzzzzzz_ = context.Operators.Start(rzzzzzzzzzzzy_);

            return rzzzzzzzzzzzz_;
        };
        IEnumerable<Procedure> rzzzzzzzzzzze_ = context.Operators.SortBy<Procedure>(rzzzzzzzzzzzc_, rzzzzzzzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
        Procedure rzzzzzzzzzzzf_ = context.Operators.First<Procedure>(rzzzzzzzzzzze_);

        return rzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("July 1 of Year Prior to the Measurement Period")]
    public CqlDateTime July_1_of_Year_Prior_to_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> szzzzzzzzzzza_ = this.Measurement_Period(context);
        CqlDateTime szzzzzzzzzzzb_ = context.Operators.Start(szzzzzzzzzzza_);
        int? szzzzzzzzzzzc_ = context.Operators.DateTimeComponentFrom(szzzzzzzzzzzb_, "year");
        int? szzzzzzzzzzzd_ = context.Operators.Subtract(szzzzzzzzzzzc_, 1);
        decimal? szzzzzzzzzzze_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime szzzzzzzzzzzf_ = context.Operators.DateTime(szzzzzzzzzzzd_, 7, 1, 0, 0, 0, 0, szzzzzzzzzzze_);

        return szzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("June 30 of the Measurement Period")]
    public CqlDateTime June_30_of_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> szzzzzzzzzzzg_ = this.Measurement_Period(context);
        CqlDateTime szzzzzzzzzzzh_ = context.Operators.Start(szzzzzzzzzzzg_);
        int? szzzzzzzzzzzi_ = context.Operators.DateTimeComponentFrom(szzzzzzzzzzzh_, "year");
        decimal? szzzzzzzzzzzj_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime szzzzzzzzzzzk_ = context.Operators.DateTime(szzzzzzzzzzzi_, 6, 30, 23, 59, 59, 0, szzzzzzzzzzzj_);

        return szzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("First Bladder Cancer Staging Procedure during 6 Months Prior to Measurement Period through the First 6 Months of Measurement Period")]
    public Procedure First_Bladder_Cancer_Staging_Procedure_during_6_Months_Prior_to_Measurement_Period_through_the_First_6_Months_of_Measurement_Period(CqlContext context)
    {
        Procedure szzzzzzzzzzzl_ = this.First_Bladder_Cancer_Staging_Procedure(context);
        Procedure[] szzzzzzzzzzzm_ = [
            szzzzzzzzzzzl_,
        ];
        bool? szzzzzzzzzzzn_(Procedure FirstBladderCancerStaging)
        {
            CqlDateTime szzzzzzzzzzzq_ = this.July_1_of_Year_Prior_to_the_Measurement_Period(context);
            CqlDateTime szzzzzzzzzzzr_ = this.June_30_of_the_Measurement_Period(context);
            CqlInterval<CqlDateTime> szzzzzzzzzzzs_ = context.Operators.Interval(szzzzzzzzzzzq_, szzzzzzzzzzzr_, true, true);
            DataType szzzzzzzzzzzt_ = FirstBladderCancerStaging?.Performed;
            object szzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzu_);
            bool? szzzzzzzzzzzw_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(szzzzzzzzzzzs_, szzzzzzzzzzzv_, "day");

            return szzzzzzzzzzzw_;
        };
        IEnumerable<Procedure> szzzzzzzzzzzo_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)szzzzzzzzzzzm_, szzzzzzzzzzzn_);
        Procedure szzzzzzzzzzzp_ = context.Operators.SingletonFrom<Procedure>(szzzzzzzzzzzo_);

        return szzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("getStagingProcedure")]
    public IEnumerable<Procedure> getStagingProcedure(CqlContext context, Observation StagingObservation)
    {
        List<ResourceReference> szzzzzzzzzzzx_ = StagingObservation?.PartOf;
        Procedure szzzzzzzzzzzy_(ResourceReference StagingReference)
        {
            Procedure tzzzzzzzzzzzb_ = this.First_Bladder_Cancer_Staging_Procedure_during_6_Months_Prior_to_Measurement_Period_through_the_First_6_Months_of_Measurement_Period(context);
            Procedure[] tzzzzzzzzzzzc_ = [
                tzzzzzzzzzzzb_,
            ];
            bool? tzzzzzzzzzzzd_(Procedure FirstBladderCancerStagingMP)
            {
                Id tzzzzzzzzzzzg_ = FirstBladderCancerStagingMP?.IdElement;
                string tzzzzzzzzzzzh_ = tzzzzzzzzzzzg_?.Value;
                FhirString tzzzzzzzzzzzi_ = StagingReference?.ReferenceElement;
                string tzzzzzzzzzzzj_ = tzzzzzzzzzzzi_?.Value;
                string tzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.getId(context, tzzzzzzzzzzzj_);
                bool? tzzzzzzzzzzzl_ = context.Operators.Equal(tzzzzzzzzzzzh_, tzzzzzzzzzzzk_);

                return tzzzzzzzzzzzl_;
            };
            IEnumerable<Procedure> tzzzzzzzzzzze_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)tzzzzzzzzzzzc_, tzzzzzzzzzzzd_);
            Procedure tzzzzzzzzzzzf_ = context.Operators.SingletonFrom<Procedure>(tzzzzzzzzzzze_);

            return tzzzzzzzzzzzf_;
        };
        IEnumerable<Procedure> szzzzzzzzzzzz_ = context.Operators.Select<ResourceReference, Procedure>((IEnumerable<ResourceReference>)szzzzzzzzzzzx_, szzzzzzzzzzzy_);
        IEnumerable<Procedure> tzzzzzzzzzzza_ = context.Operators.Distinct<Procedure>(szzzzzzzzzzzz_);

        return tzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Has Most Recent Bladder Cancer Tumor Staging is Ta HG, Tis, T1")]
    public bool? Has_Most_Recent_Bladder_Cancer_Tumor_Staging_is_Ta_HG__Tis__T1(CqlContext context)
    {
        IEnumerable<Observation> tzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? tzzzzzzzzzzzn_(Observation StagingObservation)
        {
            IEnumerable<Procedure> tzzzzzzzzzzzq_ = this.getStagingProcedure(context, StagingObservation);
            bool? tzzzzzzzzzzzr_ = context.Operators.Not((bool?)(tzzzzzzzzzzzq_ is null));
            DataType tzzzzzzzzzzzs_ = StagingObservation?.Value;
            object tzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzs_);
            CqlCode tzzzzzzzzzzzu_ = this.American_Joint_Committee_on_Cancer_cT1__qualifier_value_(context);
            CqlConcept tzzzzzzzzzzzv_ = context.Operators.ConvertCodeToConcept(tzzzzzzzzzzzu_);
            bool? tzzzzzzzzzzzw_ = context.Operators.Equivalent(tzzzzzzzzzzzt_ as CqlConcept, tzzzzzzzzzzzv_);
            object tzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzs_);
            CqlCode tzzzzzzzzzzzz_ = this.American_Joint_Committee_on_Cancer_cTis__qualifier_value_(context);
            CqlConcept uzzzzzzzzzzza_ = context.Operators.ConvertCodeToConcept(tzzzzzzzzzzzz_);
            bool? uzzzzzzzzzzzb_ = context.Operators.Equivalent(tzzzzzzzzzzzy_ as CqlConcept, uzzzzzzzzzzza_);
            bool? uzzzzzzzzzzzc_ = context.Operators.Or(tzzzzzzzzzzzw_, uzzzzzzzzzzzb_);
            object uzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzs_);
            CqlCode uzzzzzzzzzzzf_ = this.American_Joint_Committee_on_Cancer_cTa__qualifier_value_(context);
            CqlConcept uzzzzzzzzzzzg_ = context.Operators.ConvertCodeToConcept(uzzzzzzzzzzzf_);
            bool? uzzzzzzzzzzzh_ = context.Operators.Equivalent(uzzzzzzzzzzze_ as CqlConcept, uzzzzzzzzzzzg_);
            bool? uzzzzzzzzzzzi_ = context.Operators.Or(uzzzzzzzzzzzc_, uzzzzzzzzzzzh_);
            object uzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzs_);
            CqlCode uzzzzzzzzzzzl_ = this.Carcinoma_in_situ_of_bladder(context);
            CqlConcept uzzzzzzzzzzzm_ = context.Operators.ConvertCodeToConcept(uzzzzzzzzzzzl_);
            bool? uzzzzzzzzzzzn_ = context.Operators.Equivalent(uzzzzzzzzzzzk_ as CqlConcept, uzzzzzzzzzzzm_);
            bool? uzzzzzzzzzzzo_ = context.Operators.Or(uzzzzzzzzzzzi_, uzzzzzzzzzzzn_);
            bool? uzzzzzzzzzzzp_ = context.Operators.And(tzzzzzzzzzzzr_, uzzzzzzzzzzzo_);
            Code<ObservationStatus> uzzzzzzzzzzzq_ = StagingObservation?.StatusElement;
            ObservationStatus? uzzzzzzzzzzzr_ = uzzzzzzzzzzzq_?.Value;
            Code<ObservationStatus> uzzzzzzzzzzzs_ = context.Operators.Convert<Code<ObservationStatus>>(uzzzzzzzzzzzr_);
            string uzzzzzzzzzzzt_ = context.Operators.Convert<string>(uzzzzzzzzzzzs_);
            string[] uzzzzzzzzzzzu_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? uzzzzzzzzzzzv_ = context.Operators.In<string>(uzzzzzzzzzzzt_, uzzzzzzzzzzzu_ as IEnumerable<string>);
            bool? uzzzzzzzzzzzw_ = context.Operators.And(uzzzzzzzzzzzp_, uzzzzzzzzzzzv_);

            return uzzzzzzzzzzzw_;
        };
        IEnumerable<Observation> tzzzzzzzzzzzo_ = context.Operators.Where<Observation>(tzzzzzzzzzzzm_, tzzzzzzzzzzzn_);
        bool? tzzzzzzzzzzzp_ = context.Operators.Exists<Observation>(tzzzzzzzzzzzo_);

        return tzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Has Qualifying Encounter")]
    public bool? Has_Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzx_ = this.Office_Visit(context);
        IEnumerable<Encounter> uzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? uzzzzzzzzzzzz_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> vzzzzzzzzzzzc_ = this.Measurement_Period(context);
            Period vzzzzzzzzzzzd_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> vzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzd_);
            bool? vzzzzzzzzzzzf_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(vzzzzzzzzzzzc_, vzzzzzzzzzzze_, default);
            Coding vzzzzzzzzzzzg_ = ValidEncounter?.Class;
            CqlCode vzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToCode(context, vzzzzzzzzzzzg_);
            CqlCode vzzzzzzzzzzzi_ = this.@virtual(context);
            bool? vzzzzzzzzzzzj_ = context.Operators.Equivalent(vzzzzzzzzzzzh_, vzzzzzzzzzzzi_);
            bool? vzzzzzzzzzzzk_ = context.Operators.Not(vzzzzzzzzzzzj_);
            bool? vzzzzzzzzzzzl_ = context.Operators.And(vzzzzzzzzzzzf_, vzzzzzzzzzzzk_);
            Code<Encounter.EncounterStatus> vzzzzzzzzzzzm_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? vzzzzzzzzzzzn_ = vzzzzzzzzzzzm_?.Value;
            Code<Encounter.EncounterStatus> vzzzzzzzzzzzo_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(vzzzzzzzzzzzn_);
            bool? vzzzzzzzzzzzp_ = context.Operators.Equal(vzzzzzzzzzzzo_, "finished");
            bool? vzzzzzzzzzzzq_ = context.Operators.And(vzzzzzzzzzzzl_, vzzzzzzzzzzzp_);

            return vzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzza_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzy_, uzzzzzzzzzzzz_);
        bool? vzzzzzzzzzzzb_ = context.Operators.Exists<Encounter>(vzzzzzzzzzzza_);

        return vzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? vzzzzzzzzzzzr_ = this.Has_Most_Recent_Bladder_Cancer_Tumor_Staging_is_Ta_HG__Tis__T1(context);
        bool? vzzzzzzzzzzzs_ = this.Has_Qualifying_Encounter(context);
        bool? vzzzzzzzzzzzt_ = context.Operators.And(vzzzzzzzzzzzr_, vzzzzzzzzzzzs_);

        return vzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? vzzzzzzzzzzzu_ = this.Initial_Population(context);

        return vzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Acute Tuberculosis Diagnosis")]
    public IEnumerable<Condition> Acute_Tuberculosis_Diagnosis(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzv_ = this.Active_Tuberculosis_for_Urology_Care(context);
        IEnumerable<Condition> vzzzzzzzzzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> vzzzzzzzzzzzx_(Condition ActiveTuberculosis)
        {
            Procedure wzzzzzzzzzzzb_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] wzzzzzzzzzzzc_ = [
                wzzzzzzzzzzzb_,
            ];
            bool? wzzzzzzzzzzzd_(Procedure FirstBladderCancerStaging)
            {
                CqlInterval<CqlDateTime> wzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ActiveTuberculosis);
                DataType wzzzzzzzzzzzi_ = FirstBladderCancerStaging?.Performed;
                object wzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzj_);
                bool? wzzzzzzzzzzzl_ = context.Operators.OverlapsAfter(wzzzzzzzzzzzh_, wzzzzzzzzzzzk_, "day");

                return wzzzzzzzzzzzl_;
            };
            IEnumerable<Procedure> wzzzzzzzzzzze_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)wzzzzzzzzzzzc_, wzzzzzzzzzzzd_);
            Condition wzzzzzzzzzzzf_(Procedure FirstBladderCancerStaging) =>
                ActiveTuberculosis;
            IEnumerable<Condition> wzzzzzzzzzzzg_ = context.Operators.Select<Procedure, Condition>(wzzzzzzzzzzze_, wzzzzzzzzzzzf_);

            return wzzzzzzzzzzzg_;
        };
        IEnumerable<Condition> vzzzzzzzzzzzy_ = context.Operators.SelectMany<Condition, Condition>(vzzzzzzzzzzzw_, vzzzzzzzzzzzx_);
        bool? vzzzzzzzzzzzz_(Condition ActiveTuberculosis)
        {
            bool? wzzzzzzzzzzzm_ = this.isConfirmedActiveDiagnosis(context, ActiveTuberculosis);

            return wzzzzzzzzzzzm_;
        };
        IEnumerable<Condition> wzzzzzzzzzzza_ = context.Operators.Where<Condition>(vzzzzzzzzzzzy_, vzzzzzzzzzzzz_);

        return wzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Immunosuppressive Drugs")]
    public IEnumerable<MedicationRequest> Immunosuppressive_Drugs(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzn_ = this.Immunosuppressive_Drugs_for_Urology_Care(context);
        IEnumerable<MedicationRequest> wzzzzzzzzzzzo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> wzzzzzzzzzzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> wzzzzzzzzzzzr_ = context.Operators.Union<MedicationRequest>(wzzzzzzzzzzzo_, wzzzzzzzzzzzq_);
        IEnumerable<MedicationRequest> wzzzzzzzzzzzs_(MedicationRequest ImmunosuppressiveDrugs)
        {
            Procedure wzzzzzzzzzzzw_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] wzzzzzzzzzzzx_ = [
                wzzzzzzzzzzzw_,
            ];
            bool? wzzzzzzzzzzzy_(Procedure FirstBladderCancerStaging)
            {
                List<Dosage> xzzzzzzzzzzzc_ = ImmunosuppressiveDrugs?.DosageInstruction;
                bool? xzzzzzzzzzzzd_(Dosage @this)
                {
                    Timing yzzzzzzzzzzzn_ = @this?.Timing;
                    bool? yzzzzzzzzzzzo_ = context.Operators.Not((bool?)(yzzzzzzzzzzzn_ is null));

                    return yzzzzzzzzzzzo_;
                };
                IEnumerable<Dosage> xzzzzzzzzzzze_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)xzzzzzzzzzzzc_, xzzzzzzzzzzzd_);
                Timing xzzzzzzzzzzzf_(Dosage @this)
                {
                    Timing yzzzzzzzzzzzp_ = @this?.Timing;

                    return yzzzzzzzzzzzp_;
                };
                IEnumerable<Timing> xzzzzzzzzzzzg_ = context.Operators.Select<Dosage, Timing>(xzzzzzzzzzzze_, xzzzzzzzzzzzf_);
                CqlDateTime xzzzzzzzzzzzh_(Timing dosageTiming)
                {
                    List<FhirDateTime> yzzzzzzzzzzzq_ = dosageTiming?.EventElement;
                    IEnumerable<CqlDateTime> yzzzzzzzzzzzr_ = context.Operators.LateBoundProperty<IEnumerable<CqlDateTime>>(yzzzzzzzzzzzq_, "value");
                    IEnumerable<CqlDateTime> yzzzzzzzzzzzs_ = context.Operators.ListSort<CqlDateTime>(yzzzzzzzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
                    CqlDateTime yzzzzzzzzzzzt_ = context.Operators.First<CqlDateTime>(yzzzzzzzzzzzs_);

                    return yzzzzzzzzzzzt_;
                };
                IEnumerable<CqlDateTime> xzzzzzzzzzzzi_ = context.Operators.Select<Timing, CqlDateTime>(xzzzzzzzzzzzg_, xzzzzzzzzzzzh_);
                IEnumerable<CqlDateTime> xzzzzzzzzzzzj_ = context.Operators.Distinct<CqlDateTime>(xzzzzzzzzzzzi_);
                IEnumerable<CqlDateTime> xzzzzzzzzzzzk_ = context.Operators.ListSort<CqlDateTime>(xzzzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
                CqlDateTime xzzzzzzzzzzzl_ = context.Operators.First<CqlDateTime>(xzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzl_ as object);
                bool? xzzzzzzzzzzzo_(Dosage @this)
                {
                    Timing yzzzzzzzzzzzu_ = @this?.Timing;
                    bool? yzzzzzzzzzzzv_ = context.Operators.Not((bool?)(yzzzzzzzzzzzu_ is null));

                    return yzzzzzzzzzzzv_;
                };
                IEnumerable<Dosage> xzzzzzzzzzzzp_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)xzzzzzzzzzzzc_, xzzzzzzzzzzzo_);
                Timing xzzzzzzzzzzzq_(Dosage @this)
                {
                    Timing yzzzzzzzzzzzw_ = @this?.Timing;

                    return yzzzzzzzzzzzw_;
                };
                IEnumerable<Timing> xzzzzzzzzzzzr_ = context.Operators.Select<Dosage, Timing>(xzzzzzzzzzzzp_, xzzzzzzzzzzzq_);
                bool? xzzzzzzzzzzzs_(Timing @this)
                {
                    Timing.RepeatComponent yzzzzzzzzzzzx_ = @this?.Repeat;
                    bool? yzzzzzzzzzzzy_ = context.Operators.Not((bool?)(yzzzzzzzzzzzx_ is null));

                    return yzzzzzzzzzzzy_;
                };
                IEnumerable<Timing> xzzzzzzzzzzzt_ = context.Operators.Where<Timing>(xzzzzzzzzzzzr_, xzzzzzzzzzzzs_);
                Timing.RepeatComponent xzzzzzzzzzzzu_(Timing @this)
                {
                    Timing.RepeatComponent yzzzzzzzzzzzz_ = @this?.Repeat;

                    return yzzzzzzzzzzzz_;
                };
                IEnumerable<Timing.RepeatComponent> xzzzzzzzzzzzv_ = context.Operators.Select<Timing, Timing.RepeatComponent>(xzzzzzzzzzzzt_, xzzzzzzzzzzzu_);
                bool? xzzzzzzzzzzzw_(Timing.RepeatComponent @this)
                {
                    DataType zzzzzzzzzzzza_ = @this?.Bounds;
                    object zzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzza_);
                    bool? zzzzzzzzzzzzc_ = context.Operators.Not((bool?)(zzzzzzzzzzzzb_ is null));

                    return zzzzzzzzzzzzc_;
                };
                IEnumerable<Timing.RepeatComponent> xzzzzzzzzzzzx_ = context.Operators.Where<Timing.RepeatComponent>(xzzzzzzzzzzzv_, xzzzzzzzzzzzw_);
                object xzzzzzzzzzzzy_(Timing.RepeatComponent @this)
                {
                    DataType zzzzzzzzzzzzd_ = @this?.Bounds;
                    object zzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzd_);

                    return zzzzzzzzzzzze_;
                };
                IEnumerable<object> xzzzzzzzzzzzz_ = context.Operators.Select<Timing.RepeatComponent, object>(xzzzzzzzzzzzx_, xzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzza_(object DoseTime)
                {
                    CqlInterval<CqlDateTime> zzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, DoseTime);

                    return zzzzzzzzzzzzf_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzzzzb_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(xzzzzzzzzzzzz_, yzzzzzzzzzzza_);
                IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzzzzc_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(yzzzzzzzzzzzb_);
                IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzzzzd_ = context.Operators.Collapse(yzzzzzzzzzzzc_, default);
                object yzzzzzzzzzzze_(CqlInterval<CqlDateTime> @this)
                {
                    CqlDateTime zzzzzzzzzzzzg_ = context.Operators.Start(@this);

                    return zzzzzzzzzzzzg_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzzzzf_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(yzzzzzzzzzzzd_, yzzzzzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzg_ = context.Operators.First<CqlInterval<CqlDateTime>>(yzzzzzzzzzzzf_);
                CqlDateTime yzzzzzzzzzzzh_ = context.Operators.Start(xzzzzzzzzzzzm_ ?? yzzzzzzzzzzzg_);
                DataType yzzzzzzzzzzzi_ = FirstBladderCancerStaging?.Performed;
                object yzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzj_);
                CqlDateTime yzzzzzzzzzzzl_ = context.Operators.Start(yzzzzzzzzzzzk_);
                bool? yzzzzzzzzzzzm_ = context.Operators.SameOrBefore(yzzzzzzzzzzzh_, yzzzzzzzzzzzl_, "day");

                return yzzzzzzzzzzzm_;
            };
            IEnumerable<Procedure> wzzzzzzzzzzzz_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)wzzzzzzzzzzzx_, wzzzzzzzzzzzy_);
            MedicationRequest xzzzzzzzzzzza_(Procedure FirstBladderCancerStaging) =>
                ImmunosuppressiveDrugs;
            IEnumerable<MedicationRequest> xzzzzzzzzzzzb_ = context.Operators.Select<Procedure, MedicationRequest>(wzzzzzzzzzzzz_, xzzzzzzzzzzza_);

            return xzzzzzzzzzzzb_;
        };
        IEnumerable<MedicationRequest> wzzzzzzzzzzzt_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(wzzzzzzzzzzzr_, wzzzzzzzzzzzs_);
        bool? wzzzzzzzzzzzu_(MedicationRequest ImmunosuppressiveDrugs)
        {
            Code<MedicationRequest.MedicationrequestStatus> zzzzzzzzzzzzh_ = ImmunosuppressiveDrugs?.StatusElement;
            MedicationRequest.MedicationrequestStatus? zzzzzzzzzzzzi_ = zzzzzzzzzzzzh_?.Value;
            string zzzzzzzzzzzzj_ = context.Operators.Convert<string>(zzzzzzzzzzzzi_);
            string[] zzzzzzzzzzzzk_ = [
                "active",
                "completed",
            ];
            bool? zzzzzzzzzzzzl_ = context.Operators.In<string>(zzzzzzzzzzzzj_, zzzzzzzzzzzzk_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> zzzzzzzzzzzzm_ = ImmunosuppressiveDrugs?.IntentElement;
            MedicationRequest.MedicationRequestIntent? zzzzzzzzzzzzn_ = zzzzzzzzzzzzm_?.Value;
            string zzzzzzzzzzzzo_ = context.Operators.Convert<string>(zzzzzzzzzzzzn_);
            bool? zzzzzzzzzzzzp_ = context.Operators.Equal(zzzzzzzzzzzzo_, "order");
            bool? zzzzzzzzzzzzq_ = context.Operators.And(zzzzzzzzzzzzl_, zzzzzzzzzzzzp_);

            return zzzzzzzzzzzzq_;
        };
        IEnumerable<MedicationRequest> wzzzzzzzzzzzv_ = context.Operators.Where<MedicationRequest>(wzzzzzzzzzzzt_, wzzzzzzzzzzzu_);

        return wzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Cystectomy Done")]
    public IEnumerable<Procedure> Cystectomy_Done(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzr_ = this.Cystectomy_for_Urology_Care(context);
        IEnumerable<Procedure> zzzzzzzzzzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, zzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> zzzzzzzzzzzzt_(Procedure Cystectomy)
        {
            Procedure zzzzzzzzzzzzx_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] zzzzzzzzzzzzy_ = [
                zzzzzzzzzzzzx_,
            ];
            bool? zzzzzzzzzzzzz_(Procedure FirstBladderCancerStaging)
            {
                DataType azzzzzzzzzzzzd_ = Cystectomy?.Performed;
                object azzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzze_);
                CqlDateTime azzzzzzzzzzzzg_ = context.Operators.End(azzzzzzzzzzzzf_);
                DataType azzzzzzzzzzzzh_ = FirstBladderCancerStaging?.Performed;
                object azzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzi_);
                CqlDateTime azzzzzzzzzzzzk_ = context.Operators.Start(azzzzzzzzzzzzj_);
                CqlQuantity azzzzzzzzzzzzl_ = context.Operators.Quantity(6m, "months");
                CqlDateTime azzzzzzzzzzzzm_ = context.Operators.Subtract(azzzzzzzzzzzzk_, azzzzzzzzzzzzl_);
                object azzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzo_);
                CqlDateTime azzzzzzzzzzzzq_ = context.Operators.Start(azzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzr_ = context.Operators.Interval(azzzzzzzzzzzzm_, azzzzzzzzzzzzq_, true, false);
                bool? azzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzg_, azzzzzzzzzzzzr_, default);
                object azzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzu_);
                CqlDateTime azzzzzzzzzzzzw_ = context.Operators.Start(azzzzzzzzzzzzv_);
                bool? azzzzzzzzzzzzx_ = context.Operators.Not((bool?)(azzzzzzzzzzzzw_ is null));
                bool? azzzzzzzzzzzzy_ = context.Operators.And(azzzzzzzzzzzzs_, azzzzzzzzzzzzx_);

                return azzzzzzzzzzzzy_;
            };
            IEnumerable<Procedure> azzzzzzzzzzzza_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)zzzzzzzzzzzzy_, zzzzzzzzzzzzz_);
            Procedure azzzzzzzzzzzzb_(Procedure FirstBladderCancerStaging) =>
                Cystectomy;
            IEnumerable<Procedure> azzzzzzzzzzzzc_ = context.Operators.Select<Procedure, Procedure>(azzzzzzzzzzzza_, azzzzzzzzzzzzb_);

            return azzzzzzzzzzzzc_;
        };
        IEnumerable<Procedure> zzzzzzzzzzzzu_ = context.Operators.SelectMany<Procedure, Procedure>(zzzzzzzzzzzzs_, zzzzzzzzzzzzt_);
        bool? zzzzzzzzzzzzv_(Procedure Cystectomy)
        {
            Code<EventStatus> azzzzzzzzzzzzz_ = Cystectomy?.StatusElement;
            EventStatus? bzzzzzzzzzzzza_ = azzzzzzzzzzzzz_?.Value;
            string bzzzzzzzzzzzzb_ = context.Operators.Convert<string>(bzzzzzzzzzzzza_);
            bool? bzzzzzzzzzzzzc_ = context.Operators.Equal(bzzzzzzzzzzzzb_, "completed");

            return bzzzzzzzzzzzzc_;
        };
        IEnumerable<Procedure> zzzzzzzzzzzzw_ = context.Operators.Where<Procedure>(zzzzzzzzzzzzu_, zzzzzzzzzzzzv_);

        return zzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Has Excluding HIV, Immunocompromised Conditions or Mixed Histology Before Staging")]
    public bool? Has_Excluding_HIV__Immunocompromised_Conditions_or_Mixed_Histology_Before_Staging(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzd_ = this.HIV(context);
        IEnumerable<Condition> bzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet bzzzzzzzzzzzzf_ = this.Immunocompromised_Conditions(context);
        IEnumerable<Condition> bzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> bzzzzzzzzzzzzh_ = context.Operators.Union<Condition>(bzzzzzzzzzzzze_, bzzzzzzzzzzzzg_);
        CqlValueSet bzzzzzzzzzzzzi_ = this.Mixed_histology_urothelial_cell_carcinoma_for_Urology_Care(context);
        IEnumerable<Condition> bzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> bzzzzzzzzzzzzk_ = context.Operators.Union<Condition>(bzzzzzzzzzzzzh_, bzzzzzzzzzzzzj_);
        IEnumerable<Condition> bzzzzzzzzzzzzl_(Condition ExclusionDiagnosis)
        {
            Procedure bzzzzzzzzzzzzq_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] bzzzzzzzzzzzzr_ = [
                bzzzzzzzzzzzzq_,
            ];
            bool? bzzzzzzzzzzzzs_(Procedure FirstBladderCancerStaging)
            {
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ExclusionDiagnosis);
                CqlDateTime bzzzzzzzzzzzzx_ = context.Operators.Start(bzzzzzzzzzzzzw_);
                DataType bzzzzzzzzzzzzy_ = FirstBladderCancerStaging?.Performed;
                object bzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzz_);
                CqlDateTime czzzzzzzzzzzzb_ = context.Operators.Start(czzzzzzzzzzzza_);
                bool? czzzzzzzzzzzzc_ = context.Operators.SameOrBefore(bzzzzzzzzzzzzx_, czzzzzzzzzzzzb_, "day");

                return czzzzzzzzzzzzc_;
            };
            IEnumerable<Procedure> bzzzzzzzzzzzzt_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)bzzzzzzzzzzzzr_, bzzzzzzzzzzzzs_);
            Condition bzzzzzzzzzzzzu_(Procedure FirstBladderCancerStaging) =>
                ExclusionDiagnosis;
            IEnumerable<Condition> bzzzzzzzzzzzzv_ = context.Operators.Select<Procedure, Condition>(bzzzzzzzzzzzzt_, bzzzzzzzzzzzzu_);

            return bzzzzzzzzzzzzv_;
        };
        IEnumerable<Condition> bzzzzzzzzzzzzm_ = context.Operators.SelectMany<Condition, Condition>(bzzzzzzzzzzzzk_, bzzzzzzzzzzzzl_);
        bool? bzzzzzzzzzzzzn_(Condition ExclusionDiagnosis)
        {
            bool? czzzzzzzzzzzzd_ = this.isConfirmedActiveDiagnosis(context, ExclusionDiagnosis);

            return czzzzzzzzzzzzd_;
        };
        IEnumerable<Condition> bzzzzzzzzzzzzo_ = context.Operators.Where<Condition>(bzzzzzzzzzzzzm_, bzzzzzzzzzzzzn_);
        bool? bzzzzzzzzzzzzp_ = context.Operators.Exists<Condition>(bzzzzzzzzzzzzo_);

        return bzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Has Excluding Chemotherapy or Radiotherapy Procedure Before Staging")]
    public bool? Has_Excluding_Chemotherapy_or_Radiotherapy_Procedure_Before_Staging(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzze_ = this.Chemotherapy_Agents_for_Advanced_Cancer(context);
        IEnumerable<MedicationRequest> czzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, czzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> czzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, czzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> czzzzzzzzzzzzi_ = context.Operators.Union<MedicationRequest>(czzzzzzzzzzzzf_, czzzzzzzzzzzzh_);
        IEnumerable<MedicationRequest> czzzzzzzzzzzzj_(MedicationRequest ExclusionMed)
        {
            Procedure czzzzzzzzzzzzw_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] czzzzzzzzzzzzx_ = [
                czzzzzzzzzzzzw_,
            ];
            bool? czzzzzzzzzzzzy_(Procedure FirstBladderCancerStaging)
            {
                List<Dosage> dzzzzzzzzzzzzc_ = ExclusionMed?.DosageInstruction;
                bool? dzzzzzzzzzzzzd_(Dosage @this)
                {
                    Timing ezzzzzzzzzzzzp_ = @this?.Timing;
                    bool? ezzzzzzzzzzzzq_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzp_ is null));

                    return ezzzzzzzzzzzzq_;
                };
                IEnumerable<Dosage> dzzzzzzzzzzzze_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)dzzzzzzzzzzzzc_, dzzzzzzzzzzzzd_);
                Timing dzzzzzzzzzzzzf_(Dosage @this)
                {
                    Timing ezzzzzzzzzzzzr_ = @this?.Timing;

                    return ezzzzzzzzzzzzr_;
                };
                IEnumerable<Timing> dzzzzzzzzzzzzg_ = context.Operators.Select<Dosage, Timing>(dzzzzzzzzzzzze_, dzzzzzzzzzzzzf_);
                bool? dzzzzzzzzzzzzh_(Timing @this)
                {
                    Timing.RepeatComponent ezzzzzzzzzzzzs_ = @this?.Repeat;
                    bool? ezzzzzzzzzzzzt_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzs_ is null));

                    return ezzzzzzzzzzzzt_;
                };
                IEnumerable<Timing> dzzzzzzzzzzzzi_ = context.Operators.Where<Timing>(dzzzzzzzzzzzzg_, dzzzzzzzzzzzzh_);
                Timing.RepeatComponent dzzzzzzzzzzzzj_(Timing @this)
                {
                    Timing.RepeatComponent ezzzzzzzzzzzzu_ = @this?.Repeat;

                    return ezzzzzzzzzzzzu_;
                };
                IEnumerable<Timing.RepeatComponent> dzzzzzzzzzzzzk_ = context.Operators.Select<Timing, Timing.RepeatComponent>(dzzzzzzzzzzzzi_, dzzzzzzzzzzzzj_);
                bool? dzzzzzzzzzzzzl_(Timing.RepeatComponent @this)
                {
                    DataType ezzzzzzzzzzzzv_ = @this?.Bounds;
                    object ezzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzv_);
                    bool? ezzzzzzzzzzzzx_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzw_ is null));

                    return ezzzzzzzzzzzzx_;
                };
                IEnumerable<Timing.RepeatComponent> dzzzzzzzzzzzzm_ = context.Operators.Where<Timing.RepeatComponent>(dzzzzzzzzzzzzk_, dzzzzzzzzzzzzl_);
                object dzzzzzzzzzzzzn_(Timing.RepeatComponent @this)
                {
                    DataType ezzzzzzzzzzzzy_ = @this?.Bounds;
                    object ezzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzy_);

                    return ezzzzzzzzzzzzz_;
                };
                IEnumerable<object> dzzzzzzzzzzzzo_ = context.Operators.Select<Timing.RepeatComponent, object>(dzzzzzzzzzzzzm_, dzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzp_(object DoseTime)
                {
                    CqlInterval<CqlDateTime> fzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, DoseTime);

                    return fzzzzzzzzzzzza_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> dzzzzzzzzzzzzq_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(dzzzzzzzzzzzzo_, dzzzzzzzzzzzzp_);
                IEnumerable<CqlInterval<CqlDateTime>> dzzzzzzzzzzzzr_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(dzzzzzzzzzzzzq_);
                IEnumerable<CqlInterval<CqlDateTime>> dzzzzzzzzzzzzs_ = context.Operators.Collapse(dzzzzzzzzzzzzr_, default);
                object dzzzzzzzzzzzzt_(CqlInterval<CqlDateTime> @this)
                {
                    CqlDateTime fzzzzzzzzzzzzb_ = context.Operators.Start(@this);

                    return fzzzzzzzzzzzzb_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> dzzzzzzzzzzzzu_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(dzzzzzzzzzzzzs_, dzzzzzzzzzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzv_ = context.Operators.First<CqlInterval<CqlDateTime>>(dzzzzzzzzzzzzu_);
                CqlDateTime dzzzzzzzzzzzzw_ = context.Operators.Start(dzzzzzzzzzzzzv_);
                DataType dzzzzzzzzzzzzx_ = FirstBladderCancerStaging?.Performed;
                object dzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzy_);
                CqlDateTime ezzzzzzzzzzzza_ = context.Operators.Start(dzzzzzzzzzzzzz_);
                CqlQuantity ezzzzzzzzzzzzb_ = context.Operators.Quantity(6m, "months");
                CqlDateTime ezzzzzzzzzzzzc_ = context.Operators.Subtract(ezzzzzzzzzzzza_, ezzzzzzzzzzzzb_);
                object ezzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzze_);
                CqlDateTime ezzzzzzzzzzzzg_ = context.Operators.Start(ezzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzh_ = context.Operators.Interval(ezzzzzzzzzzzzc_, ezzzzzzzzzzzzg_, true, false);
                bool? ezzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzw_, ezzzzzzzzzzzzh_, default);
                object ezzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzk_);
                CqlDateTime ezzzzzzzzzzzzm_ = context.Operators.Start(ezzzzzzzzzzzzl_);
                bool? ezzzzzzzzzzzzn_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzm_ is null));
                bool? ezzzzzzzzzzzzo_ = context.Operators.And(ezzzzzzzzzzzzi_, ezzzzzzzzzzzzn_);

                return ezzzzzzzzzzzzo_;
            };
            IEnumerable<Procedure> czzzzzzzzzzzzz_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)czzzzzzzzzzzzx_, czzzzzzzzzzzzy_);
            MedicationRequest dzzzzzzzzzzzza_(Procedure FirstBladderCancerStaging) =>
                ExclusionMed;
            IEnumerable<MedicationRequest> dzzzzzzzzzzzzb_ = context.Operators.Select<Procedure, MedicationRequest>(czzzzzzzzzzzzz_, dzzzzzzzzzzzza_);

            return dzzzzzzzzzzzzb_;
        };
        IEnumerable<MedicationRequest> czzzzzzzzzzzzk_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(czzzzzzzzzzzzi_, czzzzzzzzzzzzj_);
        bool? czzzzzzzzzzzzl_(MedicationRequest ExclusionMed)
        {
            Code<MedicationRequest.MedicationrequestStatus> fzzzzzzzzzzzzc_ = ExclusionMed?.StatusElement;
            MedicationRequest.MedicationrequestStatus? fzzzzzzzzzzzzd_ = fzzzzzzzzzzzzc_?.Value;
            string fzzzzzzzzzzzze_ = context.Operators.Convert<string>(fzzzzzzzzzzzzd_);
            string[] fzzzzzzzzzzzzf_ = [
                "active",
                "completed",
            ];
            bool? fzzzzzzzzzzzzg_ = context.Operators.In<string>(fzzzzzzzzzzzze_, fzzzzzzzzzzzzf_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> fzzzzzzzzzzzzh_ = ExclusionMed?.IntentElement;
            MedicationRequest.MedicationRequestIntent? fzzzzzzzzzzzzi_ = fzzzzzzzzzzzzh_?.Value;
            string fzzzzzzzzzzzzj_ = context.Operators.Convert<string>(fzzzzzzzzzzzzi_);
            bool? fzzzzzzzzzzzzk_ = context.Operators.Equal(fzzzzzzzzzzzzj_, "order");
            bool? fzzzzzzzzzzzzl_ = context.Operators.And(fzzzzzzzzzzzzg_, fzzzzzzzzzzzzk_);

            return fzzzzzzzzzzzzl_;
        };
        IEnumerable<MedicationRequest> czzzzzzzzzzzzm_ = context.Operators.Where<MedicationRequest>(czzzzzzzzzzzzk_, czzzzzzzzzzzzl_);
        CqlCode czzzzzzzzzzzzn_ = this.Combined_radiotherapy__procedure_(context);
        IEnumerable<CqlCode> czzzzzzzzzzzzo_ = context.Operators.ToList<CqlCode>(czzzzzzzzzzzzn_);
        IEnumerable<Procedure> czzzzzzzzzzzzp_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, czzzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> czzzzzzzzzzzzq_(Procedure ExclusionProcedure)
        {
            Procedure fzzzzzzzzzzzzm_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] fzzzzzzzzzzzzn_ = [
                fzzzzzzzzzzzzm_,
            ];
            bool? fzzzzzzzzzzzzo_(Procedure FirstBladderCancerStaging)
            {
                DataType fzzzzzzzzzzzzs_ = ExclusionProcedure?.Performed;
                object fzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzt_);
                CqlDateTime fzzzzzzzzzzzzv_ = context.Operators.Start(fzzzzzzzzzzzzu_);
                DataType fzzzzzzzzzzzzw_ = FirstBladderCancerStaging?.Performed;
                object fzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzx_);
                CqlDateTime fzzzzzzzzzzzzz_ = context.Operators.Start(fzzzzzzzzzzzzy_);
                CqlQuantity gzzzzzzzzzzzza_ = context.Operators.Quantity(6m, "months");
                CqlDateTime gzzzzzzzzzzzzb_ = context.Operators.Subtract(fzzzzzzzzzzzzz_, gzzzzzzzzzzzza_);
                object gzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzd_);
                CqlDateTime gzzzzzzzzzzzzf_ = context.Operators.Start(gzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzg_ = context.Operators.Interval(gzzzzzzzzzzzzb_, gzzzzzzzzzzzzf_, true, false);
                bool? gzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzv_, gzzzzzzzzzzzzg_, default);
                object gzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzj_);
                CqlDateTime gzzzzzzzzzzzzl_ = context.Operators.Start(gzzzzzzzzzzzzk_);
                bool? gzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzl_ is null));
                bool? gzzzzzzzzzzzzn_ = context.Operators.And(gzzzzzzzzzzzzh_, gzzzzzzzzzzzzm_);

                return gzzzzzzzzzzzzn_;
            };
            IEnumerable<Procedure> fzzzzzzzzzzzzp_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)fzzzzzzzzzzzzn_, fzzzzzzzzzzzzo_);
            Procedure fzzzzzzzzzzzzq_(Procedure FirstBladderCancerStaging) =>
                ExclusionProcedure;
            IEnumerable<Procedure> fzzzzzzzzzzzzr_ = context.Operators.Select<Procedure, Procedure>(fzzzzzzzzzzzzp_, fzzzzzzzzzzzzq_);

            return fzzzzzzzzzzzzr_;
        };
        IEnumerable<Procedure> czzzzzzzzzzzzr_ = context.Operators.SelectMany<Procedure, Procedure>(czzzzzzzzzzzzp_, czzzzzzzzzzzzq_);
        bool? czzzzzzzzzzzzs_(Procedure ExclusionProcedure)
        {
            Code<EventStatus> gzzzzzzzzzzzzo_ = ExclusionProcedure?.StatusElement;
            EventStatus? gzzzzzzzzzzzzp_ = gzzzzzzzzzzzzo_?.Value;
            string gzzzzzzzzzzzzq_ = context.Operators.Convert<string>(gzzzzzzzzzzzzp_);
            bool? gzzzzzzzzzzzzr_ = context.Operators.Equal(gzzzzzzzzzzzzq_, "completed");

            return gzzzzzzzzzzzzr_;
        };
        IEnumerable<Procedure> czzzzzzzzzzzzt_ = context.Operators.Where<Procedure>(czzzzzzzzzzzzr_, czzzzzzzzzzzzs_);
        IEnumerable<object> czzzzzzzzzzzzu_ = context.Operators.Union<object>(czzzzzzzzzzzzm_ as IEnumerable<object>, czzzzzzzzzzzzt_ as IEnumerable<object>);
        bool? czzzzzzzzzzzzv_ = context.Operators.Exists<object>(czzzzzzzzzzzzu_);

        return czzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public bool? Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Condition> gzzzzzzzzzzzzs_ = this.Acute_Tuberculosis_Diagnosis(context);
        bool? gzzzzzzzzzzzzt_ = context.Operators.Exists<Condition>(gzzzzzzzzzzzzs_);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzu_ = this.Immunosuppressive_Drugs(context);
        bool? gzzzzzzzzzzzzv_ = context.Operators.Exists<MedicationRequest>(gzzzzzzzzzzzzu_);
        bool? gzzzzzzzzzzzzw_ = context.Operators.Or(gzzzzzzzzzzzzt_, gzzzzzzzzzzzzv_);
        IEnumerable<Procedure> gzzzzzzzzzzzzx_ = this.Cystectomy_Done(context);
        bool? gzzzzzzzzzzzzy_ = context.Operators.Exists<Procedure>(gzzzzzzzzzzzzx_);
        bool? gzzzzzzzzzzzzz_ = context.Operators.Or(gzzzzzzzzzzzzw_, gzzzzzzzzzzzzy_);
        bool? hzzzzzzzzzzzza_ = this.Has_Excluding_HIV__Immunocompromised_Conditions_or_Mixed_Histology_Before_Staging(context);
        bool? hzzzzzzzzzzzzb_ = context.Operators.Or(gzzzzzzzzzzzzz_, hzzzzzzzzzzzza_);
        bool? hzzzzzzzzzzzzc_ = this.Has_Excluding_Chemotherapy_or_Radiotherapy_Procedure_Before_Staging(context);
        bool? hzzzzzzzzzzzzd_ = context.Operators.Or(hzzzzzzzzzzzzb_, hzzzzzzzzzzzzc_);

        return hzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Denominator Exception")]
    [CqlTag("commentedOut", "\"BCG Not Available Within 6 Months After Bladder Cancer Staging\"")]
    [CqlTag("commentedOutReason", "Negation issue related to https://github.com/cqframework/cql-execution/issues/296, which is tied to https://oncprojectracking.healthit.gov/support/browse/BONNIEMAT-1455. Due to this being the only logic in this population added 'false' as a placeholder.")]
    public bool? Denominator_Exception(CqlContext context) =>
        false;


    [CqlExpressionDefinition("First BCG Administered")]
    public MedicationAdministration First_BCG_Administered(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzze_ = this.BCG_Bacillus_Calmette_Guerin_for_Urology_Care(context);
        IEnumerable<MedicationAdministration> hzzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, hzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> hzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, hzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> hzzzzzzzzzzzzi_ = context.Operators.Union<MedicationAdministration>(hzzzzzzzzzzzzf_, hzzzzzzzzzzzzh_);
        IEnumerable<MedicationAdministration> hzzzzzzzzzzzzj_(MedicationAdministration BCG)
        {
            Procedure hzzzzzzzzzzzzq_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] hzzzzzzzzzzzzr_ = [
                hzzzzzzzzzzzzq_,
            ];
            bool? hzzzzzzzzzzzzs_(Procedure FirstBladderCancerStaging)
            {
                DataType hzzzzzzzzzzzzw_ = BCG?.Effective;
                object hzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzx_);
                CqlDateTime hzzzzzzzzzzzzz_ = context.Operators.Start(hzzzzzzzzzzzzy_);
                DataType izzzzzzzzzzzza_ = FirstBladderCancerStaging?.Performed;
                object izzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzb_);
                CqlDateTime izzzzzzzzzzzzd_ = context.Operators.Start(izzzzzzzzzzzzc_);
                object izzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzf_);
                CqlDateTime izzzzzzzzzzzzh_ = context.Operators.Start(izzzzzzzzzzzzg_);
                CqlQuantity izzzzzzzzzzzzi_ = context.Operators.Quantity(6m, "months");
                CqlDateTime izzzzzzzzzzzzj_ = context.Operators.Add(izzzzzzzzzzzzh_, izzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzk_ = context.Operators.Interval(izzzzzzzzzzzzd_, izzzzzzzzzzzzj_, false, true);
                bool? izzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzz_, izzzzzzzzzzzzk_, default);
                object izzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzn_);
                CqlDateTime izzzzzzzzzzzzp_ = context.Operators.Start(izzzzzzzzzzzzo_);
                bool? izzzzzzzzzzzzq_ = context.Operators.Not((bool?)(izzzzzzzzzzzzp_ is null));
                bool? izzzzzzzzzzzzr_ = context.Operators.And(izzzzzzzzzzzzl_, izzzzzzzzzzzzq_);
                object izzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzt_);
                CqlDateTime izzzzzzzzzzzzv_ = context.Operators.Start(izzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzw_ = this.Measurement_Period(context);
                bool? izzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzv_, izzzzzzzzzzzzw_, default);
                bool? izzzzzzzzzzzzy_ = context.Operators.And(izzzzzzzzzzzzr_, izzzzzzzzzzzzx_);

                return izzzzzzzzzzzzy_;
            };
            IEnumerable<Procedure> hzzzzzzzzzzzzt_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)hzzzzzzzzzzzzr_, hzzzzzzzzzzzzs_);
            MedicationAdministration hzzzzzzzzzzzzu_(Procedure FirstBladderCancerStaging) =>
                BCG;
            IEnumerable<MedicationAdministration> hzzzzzzzzzzzzv_ = context.Operators.Select<Procedure, MedicationAdministration>(hzzzzzzzzzzzzt_, hzzzzzzzzzzzzu_);

            return hzzzzzzzzzzzzv_;
        };
        IEnumerable<MedicationAdministration> hzzzzzzzzzzzzk_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(hzzzzzzzzzzzzi_, hzzzzzzzzzzzzj_);
        bool? hzzzzzzzzzzzzl_(MedicationAdministration BCG)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> izzzzzzzzzzzzz_ = BCG?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? jzzzzzzzzzzzza_ = izzzzzzzzzzzzz_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> jzzzzzzzzzzzzb_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(jzzzzzzzzzzzza_);
            string jzzzzzzzzzzzzc_ = context.Operators.Convert<string>(jzzzzzzzzzzzzb_);
            string[] jzzzzzzzzzzzzd_ = [
                "in-progress",
                "completed",
            ];
            bool? jzzzzzzzzzzzze_ = context.Operators.In<string>(jzzzzzzzzzzzzc_, jzzzzzzzzzzzzd_ as IEnumerable<string>);

            return jzzzzzzzzzzzze_;
        };
        IEnumerable<MedicationAdministration> hzzzzzzzzzzzzm_ = context.Operators.Where<MedicationAdministration>(hzzzzzzzzzzzzk_, hzzzzzzzzzzzzl_);
        object hzzzzzzzzzzzzn_(MedicationAdministration @this)
        {
            DataType jzzzzzzzzzzzzf_ = @this?.Effective;
            object jzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzg_);
            CqlDateTime jzzzzzzzzzzzzi_ = context.Operators.Start(jzzzzzzzzzzzzh_);

            return jzzzzzzzzzzzzi_;
        };
        IEnumerable<MedicationAdministration> hzzzzzzzzzzzzo_ = context.Operators.SortBy<MedicationAdministration>(hzzzzzzzzzzzzm_, hzzzzzzzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
        MedicationAdministration hzzzzzzzzzzzzp_ = context.Operators.First<MedicationAdministration>(hzzzzzzzzzzzzo_);

        return hzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        MedicationAdministration jzzzzzzzzzzzzj_ = this.First_BCG_Administered(context);
        bool? jzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzj_ is null));

        return jzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? jzzzzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return jzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> jzzzzzzzzzzzzm_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return jzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? jzzzzzzzzzzzzn_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return jzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode jzzzzzzzzzzzzo_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return jzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("BCG Not Available Within 6 Months After Bladder Cancer Staging")]
    public IEnumerable<MedicationAdministration> BCG_Not_Available_Within_6_Months_After_Bladder_Cancer_Staging(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzp_ = this.BCG_Bacillus_Calmette_Guerin_for_Urology_Care(context);
        IEnumerable<MedicationAdministration> jzzzzzzzzzzzzq_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, jzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotadministered"));
        IEnumerable<MedicationAdministration> jzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, jzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotadministered"));
        IEnumerable<MedicationAdministration> jzzzzzzzzzzzzt_ = context.Operators.Union<MedicationAdministration>(jzzzzzzzzzzzzq_, jzzzzzzzzzzzzs_);
        IEnumerable<MedicationAdministration> jzzzzzzzzzzzzu_(MedicationAdministration BCGNotGiven)
        {
            Procedure jzzzzzzzzzzzzy_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] jzzzzzzzzzzzzz_ = [
                jzzzzzzzzzzzzy_,
            ];
            bool? kzzzzzzzzzzzza_(Procedure FirstBladderCancerStaging)
            {
                bool? kzzzzzzzzzzzze_(Extension @this)
                {
                    string lzzzzzzzzzzzzc_ = @this?.Url;
                    FhirString lzzzzzzzzzzzzd_ = context.Operators.Convert<FhirString>(lzzzzzzzzzzzzc_);
                    string lzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToString(context, lzzzzzzzzzzzzd_);
                    bool? lzzzzzzzzzzzzf_ = context.Operators.Equal(lzzzzzzzzzzzze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

                    return lzzzzzzzzzzzzf_;
                };
                IEnumerable<Extension> kzzzzzzzzzzzzf_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(BCGNotGiven is DomainResource
                        ? (BCGNotGiven as DomainResource).Extension
                        : default), kzzzzzzzzzzzze_);
                DataType kzzzzzzzzzzzzg_(Extension @this)
                {
                    DataType lzzzzzzzzzzzzg_ = @this?.Value;

                    return lzzzzzzzzzzzzg_;
                };
                IEnumerable<DataType> kzzzzzzzzzzzzh_ = context.Operators.Select<Extension, DataType>(kzzzzzzzzzzzzf_, kzzzzzzzzzzzzg_);
                DataType kzzzzzzzzzzzzi_ = context.Operators.SingletonFrom<DataType>(kzzzzzzzzzzzzh_);
                CqlDateTime kzzzzzzzzzzzzj_ = context.Operators.Convert<CqlDateTime>(kzzzzzzzzzzzzi_);
                DataType kzzzzzzzzzzzzk_ = FirstBladderCancerStaging?.Performed;
                object kzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzl_);
                CqlDateTime kzzzzzzzzzzzzn_ = context.Operators.Start(kzzzzzzzzzzzzm_);
                object kzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzp_);
                CqlDateTime kzzzzzzzzzzzzr_ = context.Operators.Start(kzzzzzzzzzzzzq_);
                CqlQuantity kzzzzzzzzzzzzs_ = context.Operators.Quantity(6m, "months");
                CqlDateTime kzzzzzzzzzzzzt_ = context.Operators.Add(kzzzzzzzzzzzzr_, kzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzu_ = context.Operators.Interval(kzzzzzzzzzzzzn_, kzzzzzzzzzzzzt_, false, true);
                bool? kzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzj_, kzzzzzzzzzzzzu_, default);
                object kzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzx_);
                CqlDateTime kzzzzzzzzzzzzz_ = context.Operators.Start(kzzzzzzzzzzzzy_);
                bool? lzzzzzzzzzzzza_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzz_ is null));
                bool? lzzzzzzzzzzzzb_ = context.Operators.And(kzzzzzzzzzzzzv_, lzzzzzzzzzzzza_);

                return lzzzzzzzzzzzzb_;
            };
            IEnumerable<Procedure> kzzzzzzzzzzzzb_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)jzzzzzzzzzzzzz_, kzzzzzzzzzzzza_);
            MedicationAdministration kzzzzzzzzzzzzc_(Procedure FirstBladderCancerStaging) =>
                BCGNotGiven;
            IEnumerable<MedicationAdministration> kzzzzzzzzzzzzd_ = context.Operators.Select<Procedure, MedicationAdministration>(kzzzzzzzzzzzzb_, kzzzzzzzzzzzzc_);

            return kzzzzzzzzzzzzd_;
        };
        IEnumerable<MedicationAdministration> jzzzzzzzzzzzzv_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(jzzzzzzzzzzzzt_, jzzzzzzzzzzzzu_);
        bool? jzzzzzzzzzzzzw_(MedicationAdministration BCGNotGiven)
        {
            List<CodeableConcept> lzzzzzzzzzzzzh_ = BCGNotGiven?.StatusReason;
            CqlConcept lzzzzzzzzzzzzi_(CodeableConcept @this)
            {
                CqlConcept lzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return lzzzzzzzzzzzzm_;
            };
            IEnumerable<CqlConcept> lzzzzzzzzzzzzj_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)lzzzzzzzzzzzzh_, lzzzzzzzzzzzzi_);
            CqlValueSet lzzzzzzzzzzzzk_ = this.Unavailability_of_Bacillus_Calmette_Guerin_for_urology_care(context);
            bool? lzzzzzzzzzzzzl_ = context.Operators.ConceptsInValueSet(lzzzzzzzzzzzzj_, lzzzzzzzzzzzzk_);

            return lzzzzzzzzzzzzl_;
        };
        IEnumerable<MedicationAdministration> jzzzzzzzzzzzzx_ = context.Operators.Where<MedicationAdministration>(jzzzzzzzzzzzzv_, jzzzzzzzzzzzzw_);

        return jzzzzzzzzzzzzx_;
    }


    #endregion Expressions

}
