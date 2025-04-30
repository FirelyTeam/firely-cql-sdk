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
    private static readonly CqlCode _American_Joint_Committee_on_Cancer_cT1__qualifier_value_ = new CqlCode("1228889001", "http://snomed.info/sct");

    [CqlCodeDefinition("American Joint Committee on Cancer cTa (qualifier value)", codeId: "1228883000", codeSystem: "http://snomed.info/sct")]
    public CqlCode American_Joint_Committee_on_Cancer_cTa__qualifier_value_(CqlContext _) => _American_Joint_Committee_on_Cancer_cTa__qualifier_value_;
    private static readonly CqlCode _American_Joint_Committee_on_Cancer_cTa__qualifier_value_ = new CqlCode("1228883000", "http://snomed.info/sct");

    [CqlCodeDefinition("American Joint Committee on Cancer cTis (qualifier value)", codeId: "1228884006", codeSystem: "http://snomed.info/sct")]
    public CqlCode American_Joint_Committee_on_Cancer_cTis__qualifier_value_(CqlContext _) => _American_Joint_Committee_on_Cancer_cTis__qualifier_value_;
    private static readonly CqlCode _American_Joint_Committee_on_Cancer_cTis__qualifier_value_ = new CqlCode("1228884006", "http://snomed.info/sct");

    [CqlCodeDefinition("Carcinoma in situ of bladder", codeId: "D09.0", codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode Carcinoma_in_situ_of_bladder(CqlContext _) => _Carcinoma_in_situ_of_bladder;
    private static readonly CqlCode _Carcinoma_in_situ_of_bladder = new CqlCode("D09.0", "http://hl7.org/fhir/sid/icd-10-cm");

    [CqlCodeDefinition("Combined radiotherapy (procedure)", codeId: "169331000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Combined_radiotherapy__procedure_(CqlContext _) => _Combined_radiotherapy__procedure_;
    private static readonly CqlCode _Combined_radiotherapy__procedure_ = new CqlCode("169331000", "http://snomed.info/sct");

    [CqlCodeDefinition("Tumor staging (tumor staging)", codeId: "254292007", codeSystem: "http://snomed.info/sct")]
    public CqlCode Tumor_staging__tumor_staging_(CqlContext _) => _Tumor_staging__tumor_staging_;
    private static readonly CqlCode _Tumor_staging__tumor_staging_ = new CqlCode("254292007", "http://snomed.info/sct");

    [CqlCodeDefinition("virtual", codeId: "VR", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode @virtual(CqlContext _) => _virtual;
    private static readonly CqlCode _virtual = new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null,
          _American_Joint_Committee_on_Cancer_cT1__qualifier_value_,
          _American_Joint_Committee_on_Cancer_cTa__qualifier_value_,
          _American_Joint_Committee_on_Cancer_cTis__qualifier_value_,
          _Combined_radiotherapy__procedure_,
          _Tumor_staging__tumor_staging_);

    [CqlCodeSystemDefinition("ICD10CM")]
    public CqlCodeSystem ICD10CM(CqlContext _) => _ICD10CM;
    private static readonly CqlCodeSystem _ICD10CM =
      new CqlCodeSystem("http://hl7.org/fhir/sid/icd-10-cm", null,
          _Carcinoma_in_situ_of_bladder);

    [CqlCodeSystemDefinition("ActCode")]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-ActCode", null,
          _virtual);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime zzzzzzzzzzzzzv_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime zzzzzzzzzzzzzw_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> zzzzzzzzzzzzzx_ = context.Operators.Interval(zzzzzzzzzzzzzv_, zzzzzzzzzzzzzw_, true, true);
        object zzzzzzzzzzzzzy_ = context.ResolveParameter("IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR-1.4.000", "Measurement Period", zzzzzzzzzzzzzx_);

        return (CqlInterval<CqlDateTime>)zzzzzzzzzzzzzy_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> zzzzzzzzzzzzzz_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient azzzzzzzzzzzzza_ = context.Operators.SingletonFrom<Patient>(zzzzzzzzzzzzzz_);

        return azzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("isConfirmedActiveDiagnosis")]
    public bool? isConfirmedActiveDiagnosis(CqlContext context, Condition Condition)
    {
        bool? azzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.isActive(context, Condition);
        CodeableConcept azzzzzzzzzzzzzc_ = Condition?.VerificationStatus;
        CqlConcept azzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzzzzzzzzzzzc_);
        CqlCode azzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.confirmed(context);
        CqlConcept azzzzzzzzzzzzzf_ = context.Operators.ConvertCodeToConcept(azzzzzzzzzzzzze_);
        bool? azzzzzzzzzzzzzg_ = context.Operators.Equivalent(azzzzzzzzzzzzzd_, azzzzzzzzzzzzzf_);
        bool? azzzzzzzzzzzzzh_ = context.Operators.And(azzzzzzzzzzzzzb_, azzzzzzzzzzzzzg_);

        return azzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Bladder Cancer Diagnosis")]
    public IEnumerable<Condition> Bladder_Cancer_Diagnosis(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzi_ = this.Bladder_Cancer_for_Urology_Care(context);
        IEnumerable<Condition> azzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? azzzzzzzzzzzzzk_(Condition BladderCancer)
        {
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, BladderCancer);
            CqlDateTime azzzzzzzzzzzzzn_ = context.Operators.Start(azzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            CqlDateTime azzzzzzzzzzzzzp_ = context.Operators.End(azzzzzzzzzzzzzo_);
            bool? azzzzzzzzzzzzzq_ = context.Operators.Before(azzzzzzzzzzzzzn_, azzzzzzzzzzzzzp_, default);
            bool? azzzzzzzzzzzzzr_ = this.isConfirmedActiveDiagnosis(context, BladderCancer);
            bool? azzzzzzzzzzzzzs_ = context.Operators.And(azzzzzzzzzzzzzq_, azzzzzzzzzzzzzr_);

            return azzzzzzzzzzzzzs_;
        };
        IEnumerable<Condition> azzzzzzzzzzzzzl_ = context.Operators.Where<Condition>(azzzzzzzzzzzzzj_, azzzzzzzzzzzzzk_);

        return azzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("First Bladder Cancer Staging Procedure")]
    public Procedure First_Bladder_Cancer_Staging_Procedure(CqlContext context)
    {
        CqlCode azzzzzzzzzzzzzt_ = this.Tumor_staging__tumor_staging_(context);
        IEnumerable<CqlCode> azzzzzzzzzzzzzu_ = context.Operators.ToList<CqlCode>(azzzzzzzzzzzzzt_);
        IEnumerable<Procedure> azzzzzzzzzzzzzv_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, azzzzzzzzzzzzzu_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> azzzzzzzzzzzzzw_(Procedure BladderCancerStaging)
        {
            IEnumerable<Condition> bzzzzzzzzzzzzzd_ = this.Bladder_Cancer_Diagnosis(context);
            bool? bzzzzzzzzzzzzze_(Condition BladderCancer)
            {
                DataType bzzzzzzzzzzzzzi_ = BladderCancerStaging?.Performed;
                object bzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzj_);
                CqlDateTime bzzzzzzzzzzzzzl_ = context.Operators.Start(bzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, BladderCancer);
                CqlDateTime bzzzzzzzzzzzzzn_ = context.Operators.Start(bzzzzzzzzzzzzzm_);
                bool? bzzzzzzzzzzzzzo_ = context.Operators.SameOrBefore(bzzzzzzzzzzzzzl_, bzzzzzzzzzzzzzn_, "day");

                return bzzzzzzzzzzzzzo_;
            };
            IEnumerable<Condition> bzzzzzzzzzzzzzf_ = context.Operators.Where<Condition>(bzzzzzzzzzzzzzd_, bzzzzzzzzzzzzze_);
            Procedure bzzzzzzzzzzzzzg_(Condition BladderCancer) =>
                BladderCancerStaging;
            IEnumerable<Procedure> bzzzzzzzzzzzzzh_ = context.Operators.Select<Condition, Procedure>(bzzzzzzzzzzzzzf_, bzzzzzzzzzzzzzg_);

            return bzzzzzzzzzzzzzh_;
        };
        IEnumerable<Procedure> azzzzzzzzzzzzzx_ = context.Operators.SelectMany<Procedure, Procedure>(azzzzzzzzzzzzzv_, azzzzzzzzzzzzzw_);
        bool? azzzzzzzzzzzzzy_(Procedure BladderCancerStaging)
        {
            Code<EventStatus> bzzzzzzzzzzzzzp_ = BladderCancerStaging?.StatusElement;
            EventStatus? bzzzzzzzzzzzzzq_ = bzzzzzzzzzzzzzp_?.Value;
            string bzzzzzzzzzzzzzr_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzq_);
            bool? bzzzzzzzzzzzzzs_ = context.Operators.Equal(bzzzzzzzzzzzzzr_, "completed");

            return bzzzzzzzzzzzzzs_;
        };
        IEnumerable<Procedure> azzzzzzzzzzzzzz_ = context.Operators.Where<Procedure>(azzzzzzzzzzzzzx_, azzzzzzzzzzzzzy_);
        object bzzzzzzzzzzzzza_(Procedure @this)
        {
            DataType bzzzzzzzzzzzzzt_ = @this?.Performed;
            object bzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzu_);
            CqlDateTime bzzzzzzzzzzzzzw_ = context.Operators.Start(bzzzzzzzzzzzzzv_);

            return bzzzzzzzzzzzzzw_;
        };
        IEnumerable<Procedure> bzzzzzzzzzzzzzb_ = context.Operators.SortBy<Procedure>(azzzzzzzzzzzzzz_, bzzzzzzzzzzzzza_, System.ComponentModel.ListSortDirection.Ascending);
        Procedure bzzzzzzzzzzzzzc_ = context.Operators.First<Procedure>(bzzzzzzzzzzzzzb_);

        return bzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("July 1 of Year Prior to the Measurement Period")]
    public CqlDateTime July_1_of_Year_Prior_to_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> bzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
        CqlDateTime bzzzzzzzzzzzzzy_ = context.Operators.Start(bzzzzzzzzzzzzzx_);
        int? bzzzzzzzzzzzzzz_ = context.Operators.DateTimeComponentFrom(bzzzzzzzzzzzzzy_, "year");
        int? czzzzzzzzzzzzza_ = context.Operators.Subtract(bzzzzzzzzzzzzzz_, 1);
        decimal? czzzzzzzzzzzzzb_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime czzzzzzzzzzzzzc_ = context.Operators.DateTime(czzzzzzzzzzzzza_, 7, 1, 0, 0, 0, 0, czzzzzzzzzzzzzb_);

        return czzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("June 30 of the Measurement Period")]
    public CqlDateTime June_30_of_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> czzzzzzzzzzzzzd_ = this.Measurement_Period(context);
        CqlDateTime czzzzzzzzzzzzze_ = context.Operators.Start(czzzzzzzzzzzzzd_);
        int? czzzzzzzzzzzzzf_ = context.Operators.DateTimeComponentFrom(czzzzzzzzzzzzze_, "year");
        decimal? czzzzzzzzzzzzzg_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime czzzzzzzzzzzzzh_ = context.Operators.DateTime(czzzzzzzzzzzzzf_, 6, 30, 23, 59, 59, 0, czzzzzzzzzzzzzg_);

        return czzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("First Bladder Cancer Staging Procedure during 6 Months Prior to Measurement Period through the First 6 Months of Measurement Period")]
    public Procedure First_Bladder_Cancer_Staging_Procedure_during_6_Months_Prior_to_Measurement_Period_through_the_First_6_Months_of_Measurement_Period(CqlContext context)
    {
        Procedure czzzzzzzzzzzzzi_ = this.First_Bladder_Cancer_Staging_Procedure(context);
        Procedure[] czzzzzzzzzzzzzj_ = [
            czzzzzzzzzzzzzi_,
        ];
        bool? czzzzzzzzzzzzzk_(Procedure FirstBladderCancerStaging)
        {
            CqlDateTime czzzzzzzzzzzzzn_ = this.July_1_of_Year_Prior_to_the_Measurement_Period(context);
            CqlDateTime czzzzzzzzzzzzzo_ = this.June_30_of_the_Measurement_Period(context);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzp_ = context.Operators.Interval(czzzzzzzzzzzzzn_, czzzzzzzzzzzzzo_, true, true);
            DataType czzzzzzzzzzzzzq_ = FirstBladderCancerStaging?.Performed;
            object czzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzr_);
            bool? czzzzzzzzzzzzzt_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(czzzzzzzzzzzzzp_, czzzzzzzzzzzzzs_, "day");

            return czzzzzzzzzzzzzt_;
        };
        IEnumerable<Procedure> czzzzzzzzzzzzzl_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)czzzzzzzzzzzzzj_, czzzzzzzzzzzzzk_);
        Procedure czzzzzzzzzzzzzm_ = context.Operators.SingletonFrom<Procedure>(czzzzzzzzzzzzzl_);

        return czzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("getStagingProcedure")]
    public IEnumerable<Procedure> getStagingProcedure(CqlContext context, Observation StagingObservation)
    {
        List<ResourceReference> czzzzzzzzzzzzzu_ = StagingObservation?.PartOf;
        Procedure czzzzzzzzzzzzzv_(ResourceReference StagingReference)
        {
            Procedure czzzzzzzzzzzzzy_ = this.First_Bladder_Cancer_Staging_Procedure_during_6_Months_Prior_to_Measurement_Period_through_the_First_6_Months_of_Measurement_Period(context);
            Procedure[] czzzzzzzzzzzzzz_ = [
                czzzzzzzzzzzzzy_,
            ];
            bool? dzzzzzzzzzzzzza_(Procedure FirstBladderCancerStagingMP)
            {
                Id dzzzzzzzzzzzzzd_ = FirstBladderCancerStagingMP?.IdElement;
                string dzzzzzzzzzzzzze_ = dzzzzzzzzzzzzzd_?.Value;
                FhirString dzzzzzzzzzzzzzf_ = StagingReference?.ReferenceElement;
                string dzzzzzzzzzzzzzg_ = dzzzzzzzzzzzzzf_?.Value;
                string dzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.getId(context, dzzzzzzzzzzzzzg_);
                bool? dzzzzzzzzzzzzzi_ = context.Operators.Equal(dzzzzzzzzzzzzze_, dzzzzzzzzzzzzzh_);

                return dzzzzzzzzzzzzzi_;
            };
            IEnumerable<Procedure> dzzzzzzzzzzzzzb_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)czzzzzzzzzzzzzz_, dzzzzzzzzzzzzza_);
            Procedure dzzzzzzzzzzzzzc_ = context.Operators.SingletonFrom<Procedure>(dzzzzzzzzzzzzzb_);

            return dzzzzzzzzzzzzzc_;
        };
        IEnumerable<Procedure> czzzzzzzzzzzzzw_ = context.Operators.Select<ResourceReference, Procedure>((IEnumerable<ResourceReference>)czzzzzzzzzzzzzu_, czzzzzzzzzzzzzv_);
        IEnumerable<Procedure> czzzzzzzzzzzzzx_ = context.Operators.Distinct<Procedure>(czzzzzzzzzzzzzw_);

        return czzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Has Most Recent Bladder Cancer Tumor Staging is Ta HG, Tis, T1")]
    public bool? Has_Most_Recent_Bladder_Cancer_Tumor_Staging_is_Ta_HG__Tis__T1(CqlContext context)
    {
        IEnumerable<Observation> dzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? dzzzzzzzzzzzzzk_(Observation StagingObservation)
        {
            IEnumerable<Procedure> dzzzzzzzzzzzzzn_ = this.getStagingProcedure(context, StagingObservation);
            bool? dzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzn_ is null));
            DataType dzzzzzzzzzzzzzp_ = StagingObservation?.Value;
            object dzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzp_);
            CqlCode dzzzzzzzzzzzzzr_ = this.American_Joint_Committee_on_Cancer_cT1__qualifier_value_(context);
            CqlConcept dzzzzzzzzzzzzzs_ = context.Operators.ConvertCodeToConcept(dzzzzzzzzzzzzzr_);
            bool? dzzzzzzzzzzzzzt_ = context.Operators.Equivalent(dzzzzzzzzzzzzzq_ as CqlConcept, dzzzzzzzzzzzzzs_);
            object dzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzp_);
            CqlCode dzzzzzzzzzzzzzw_ = this.American_Joint_Committee_on_Cancer_cTis__qualifier_value_(context);
            CqlConcept dzzzzzzzzzzzzzx_ = context.Operators.ConvertCodeToConcept(dzzzzzzzzzzzzzw_);
            bool? dzzzzzzzzzzzzzy_ = context.Operators.Equivalent(dzzzzzzzzzzzzzv_ as CqlConcept, dzzzzzzzzzzzzzx_);
            bool? dzzzzzzzzzzzzzz_ = context.Operators.Or(dzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzy_);
            object ezzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzp_);
            CqlCode ezzzzzzzzzzzzzc_ = this.American_Joint_Committee_on_Cancer_cTa__qualifier_value_(context);
            CqlConcept ezzzzzzzzzzzzzd_ = context.Operators.ConvertCodeToConcept(ezzzzzzzzzzzzzc_);
            bool? ezzzzzzzzzzzzze_ = context.Operators.Equivalent(ezzzzzzzzzzzzzb_ as CqlConcept, ezzzzzzzzzzzzzd_);
            bool? ezzzzzzzzzzzzzf_ = context.Operators.Or(dzzzzzzzzzzzzzz_, ezzzzzzzzzzzzze_);
            object ezzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzp_);
            CqlCode ezzzzzzzzzzzzzi_ = this.Carcinoma_in_situ_of_bladder(context);
            CqlConcept ezzzzzzzzzzzzzj_ = context.Operators.ConvertCodeToConcept(ezzzzzzzzzzzzzi_);
            bool? ezzzzzzzzzzzzzk_ = context.Operators.Equivalent(ezzzzzzzzzzzzzh_ as CqlConcept, ezzzzzzzzzzzzzj_);
            bool? ezzzzzzzzzzzzzl_ = context.Operators.Or(ezzzzzzzzzzzzzf_, ezzzzzzzzzzzzzk_);
            bool? ezzzzzzzzzzzzzm_ = context.Operators.And(dzzzzzzzzzzzzzo_, ezzzzzzzzzzzzzl_);
            Code<ObservationStatus> ezzzzzzzzzzzzzn_ = StagingObservation?.StatusElement;
            ObservationStatus? ezzzzzzzzzzzzzo_ = ezzzzzzzzzzzzzn_?.Value;
            Code<ObservationStatus> ezzzzzzzzzzzzzp_ = context.Operators.Convert<Code<ObservationStatus>>(ezzzzzzzzzzzzzo_);
            string ezzzzzzzzzzzzzq_ = context.Operators.Convert<string>(ezzzzzzzzzzzzzp_);
            string[] ezzzzzzzzzzzzzr_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ezzzzzzzzzzzzzs_ = context.Operators.In<string>(ezzzzzzzzzzzzzq_, ezzzzzzzzzzzzzr_ as IEnumerable<string>);
            bool? ezzzzzzzzzzzzzt_ = context.Operators.And(ezzzzzzzzzzzzzm_, ezzzzzzzzzzzzzs_);

            return ezzzzzzzzzzzzzt_;
        };
        IEnumerable<Observation> dzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(dzzzzzzzzzzzzzj_, dzzzzzzzzzzzzzk_);
        bool? dzzzzzzzzzzzzzm_ = context.Operators.Exists<Observation>(dzzzzzzzzzzzzzl_);

        return dzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Has Qualifying Encounter")]
    public bool? Has_Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzu_ = this.Office_Visit(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? ezzzzzzzzzzzzzw_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzz_ = this.Measurement_Period(context);
            Period fzzzzzzzzzzzzza_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzza_);
            bool? fzzzzzzzzzzzzzc_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ezzzzzzzzzzzzzz_, fzzzzzzzzzzzzzb_, default);
            Coding fzzzzzzzzzzzzzd_ = ValidEncounter?.Class;
            CqlCode fzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToCode(context, fzzzzzzzzzzzzzd_);
            CqlCode fzzzzzzzzzzzzzf_ = this.@virtual(context);
            bool? fzzzzzzzzzzzzzg_ = context.Operators.Equivalent(fzzzzzzzzzzzzze_, fzzzzzzzzzzzzzf_);
            bool? fzzzzzzzzzzzzzh_ = context.Operators.Not(fzzzzzzzzzzzzzg_);
            bool? fzzzzzzzzzzzzzi_ = context.Operators.And(fzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzh_);
            Code<Encounter.EncounterStatus> fzzzzzzzzzzzzzj_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? fzzzzzzzzzzzzzk_ = fzzzzzzzzzzzzzj_?.Value;
            Code<Encounter.EncounterStatus> fzzzzzzzzzzzzzl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fzzzzzzzzzzzzzk_);
            bool? fzzzzzzzzzzzzzm_ = context.Operators.Equal(fzzzzzzzzzzzzzl_, "finished");
            bool? fzzzzzzzzzzzzzn_ = context.Operators.And(fzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzm_);

            return fzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzv_, ezzzzzzzzzzzzzw_);
        bool? ezzzzzzzzzzzzzy_ = context.Operators.Exists<Encounter>(ezzzzzzzzzzzzzx_);

        return ezzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? fzzzzzzzzzzzzzo_ = this.Has_Most_Recent_Bladder_Cancer_Tumor_Staging_is_Ta_HG__Tis__T1(context);
        bool? fzzzzzzzzzzzzzp_ = this.Has_Qualifying_Encounter(context);
        bool? fzzzzzzzzzzzzzq_ = context.Operators.And(fzzzzzzzzzzzzzo_, fzzzzzzzzzzzzzp_);

        return fzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? fzzzzzzzzzzzzzr_ = this.Initial_Population(context);

        return fzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Acute Tuberculosis Diagnosis")]
    public IEnumerable<Condition> Acute_Tuberculosis_Diagnosis(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzs_ = this.Active_Tuberculosis_for_Urology_Care(context);
        IEnumerable<Condition> fzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> fzzzzzzzzzzzzzu_(Condition ActiveTuberculosis)
        {
            Procedure fzzzzzzzzzzzzzy_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] fzzzzzzzzzzzzzz_ = [
                fzzzzzzzzzzzzzy_,
            ];
            bool? gzzzzzzzzzzzzza_(Procedure FirstBladderCancerStaging)
            {
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ActiveTuberculosis);
                DataType gzzzzzzzzzzzzzf_ = FirstBladderCancerStaging?.Performed;
                object gzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzg_);
                bool? gzzzzzzzzzzzzzi_ = context.Operators.OverlapsAfter(gzzzzzzzzzzzzze_, gzzzzzzzzzzzzzh_, "day");

                return gzzzzzzzzzzzzzi_;
            };
            IEnumerable<Procedure> gzzzzzzzzzzzzzb_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)fzzzzzzzzzzzzzz_, gzzzzzzzzzzzzza_);
            Condition gzzzzzzzzzzzzzc_(Procedure FirstBladderCancerStaging) =>
                ActiveTuberculosis;
            IEnumerable<Condition> gzzzzzzzzzzzzzd_ = context.Operators.Select<Procedure, Condition>(gzzzzzzzzzzzzzb_, gzzzzzzzzzzzzzc_);

            return gzzzzzzzzzzzzzd_;
        };
        IEnumerable<Condition> fzzzzzzzzzzzzzv_ = context.Operators.SelectMany<Condition, Condition>(fzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzu_);
        bool? fzzzzzzzzzzzzzw_(Condition ActiveTuberculosis)
        {
            bool? gzzzzzzzzzzzzzj_ = this.isConfirmedActiveDiagnosis(context, ActiveTuberculosis);

            return gzzzzzzzzzzzzzj_;
        };
        IEnumerable<Condition> fzzzzzzzzzzzzzx_ = context.Operators.Where<Condition>(fzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzw_);

        return fzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Immunosuppressive Drugs")]
    public IEnumerable<MedicationRequest> Immunosuppressive_Drugs(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzzzk_ = this.Immunosuppressive_Drugs_for_Urology_Care(context);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzo_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzn_);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzp_(MedicationRequest ImmunosuppressiveDrugs)
        {
            Procedure gzzzzzzzzzzzzzt_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] gzzzzzzzzzzzzzu_ = [
                gzzzzzzzzzzzzzt_,
            ];
            bool? gzzzzzzzzzzzzzv_(Procedure FirstBladderCancerStaging)
            {
                List<Dosage> gzzzzzzzzzzzzzz_ = ImmunosuppressiveDrugs?.DosageInstruction;
                bool? hzzzzzzzzzzzzza_(Dosage @this)
                {
                    Timing izzzzzzzzzzzzzk_ = @this?.Timing;
                    bool? izzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzk_ is null));

                    return izzzzzzzzzzzzzl_;
                };
                IEnumerable<Dosage> hzzzzzzzzzzzzzb_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)gzzzzzzzzzzzzzz_, hzzzzzzzzzzzzza_);
                Timing hzzzzzzzzzzzzzc_(Dosage @this)
                {
                    Timing izzzzzzzzzzzzzm_ = @this?.Timing;

                    return izzzzzzzzzzzzzm_;
                };
                IEnumerable<Timing> hzzzzzzzzzzzzzd_ = context.Operators.Select<Dosage, Timing>(hzzzzzzzzzzzzzb_, hzzzzzzzzzzzzzc_);
                CqlDateTime hzzzzzzzzzzzzze_(Timing dosageTiming)
                {
                    List<FhirDateTime> izzzzzzzzzzzzzn_ = dosageTiming?.EventElement;
                    IEnumerable<CqlDateTime> izzzzzzzzzzzzzo_ = context.Operators.LateBoundProperty<IEnumerable<CqlDateTime>>(izzzzzzzzzzzzzn_, "value");
                    IEnumerable<CqlDateTime> izzzzzzzzzzzzzp_ = context.Operators.ListSort<CqlDateTime>(izzzzzzzzzzzzzo_, System.ComponentModel.ListSortDirection.Ascending);
                    CqlDateTime izzzzzzzzzzzzzq_ = context.Operators.First<CqlDateTime>(izzzzzzzzzzzzzp_);

                    return izzzzzzzzzzzzzq_;
                };
                IEnumerable<CqlDateTime> hzzzzzzzzzzzzzf_ = context.Operators.Select<Timing, CqlDateTime>(hzzzzzzzzzzzzzd_, hzzzzzzzzzzzzze_);
                IEnumerable<CqlDateTime> hzzzzzzzzzzzzzg_ = context.Operators.Distinct<CqlDateTime>(hzzzzzzzzzzzzzf_);
                IEnumerable<CqlDateTime> hzzzzzzzzzzzzzh_ = context.Operators.ListSort<CqlDateTime>(hzzzzzzzzzzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
                CqlDateTime hzzzzzzzzzzzzzi_ = context.Operators.First<CqlDateTime>(hzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzi_ as object);
                bool? hzzzzzzzzzzzzzl_(Dosage @this)
                {
                    Timing izzzzzzzzzzzzzr_ = @this?.Timing;
                    bool? izzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzr_ is null));

                    return izzzzzzzzzzzzzs_;
                };
                IEnumerable<Dosage> hzzzzzzzzzzzzzm_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)gzzzzzzzzzzzzzz_, hzzzzzzzzzzzzzl_);
                Timing hzzzzzzzzzzzzzn_(Dosage @this)
                {
                    Timing izzzzzzzzzzzzzt_ = @this?.Timing;

                    return izzzzzzzzzzzzzt_;
                };
                IEnumerable<Timing> hzzzzzzzzzzzzzo_ = context.Operators.Select<Dosage, Timing>(hzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzn_);
                bool? hzzzzzzzzzzzzzp_(Timing @this)
                {
                    Timing.RepeatComponent izzzzzzzzzzzzzu_ = @this?.Repeat;
                    bool? izzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzu_ is null));

                    return izzzzzzzzzzzzzv_;
                };
                IEnumerable<Timing> hzzzzzzzzzzzzzq_ = context.Operators.Where<Timing>(hzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzp_);
                Timing.RepeatComponent hzzzzzzzzzzzzzr_(Timing @this)
                {
                    Timing.RepeatComponent izzzzzzzzzzzzzw_ = @this?.Repeat;

                    return izzzzzzzzzzzzzw_;
                };
                IEnumerable<Timing.RepeatComponent> hzzzzzzzzzzzzzs_ = context.Operators.Select<Timing, Timing.RepeatComponent>(hzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzr_);
                bool? hzzzzzzzzzzzzzt_(Timing.RepeatComponent @this)
                {
                    DataType izzzzzzzzzzzzzx_ = @this?.Bounds;
                    object izzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzx_);
                    bool? izzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzy_ is null));

                    return izzzzzzzzzzzzzz_;
                };
                IEnumerable<Timing.RepeatComponent> hzzzzzzzzzzzzzu_ = context.Operators.Where<Timing.RepeatComponent>(hzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzt_);
                object hzzzzzzzzzzzzzv_(Timing.RepeatComponent @this)
                {
                    DataType jzzzzzzzzzzzzza_ = @this?.Bounds;
                    object jzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzza_);

                    return jzzzzzzzzzzzzzb_;
                };
                IEnumerable<object> hzzzzzzzzzzzzzw_ = context.Operators.Select<Timing.RepeatComponent, object>(hzzzzzzzzzzzzzu_, hzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzx_(object DoseTime)
                {
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, DoseTime);

                    return jzzzzzzzzzzzzzc_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> hzzzzzzzzzzzzzy_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(hzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzx_);
                IEnumerable<CqlInterval<CqlDateTime>> hzzzzzzzzzzzzzz_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(hzzzzzzzzzzzzzy_);
                IEnumerable<CqlInterval<CqlDateTime>> izzzzzzzzzzzzza_ = context.Operators.Collapse(hzzzzzzzzzzzzzz_, default);
                object izzzzzzzzzzzzzb_(CqlInterval<CqlDateTime> @this)
                {
                    CqlDateTime jzzzzzzzzzzzzzd_ = context.Operators.Start(@this);

                    return jzzzzzzzzzzzzzd_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> izzzzzzzzzzzzzc_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(izzzzzzzzzzzzza_, izzzzzzzzzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzd_ = context.Operators.First<CqlInterval<CqlDateTime>>(izzzzzzzzzzzzzc_);
                CqlDateTime izzzzzzzzzzzzze_ = context.Operators.Start(hzzzzzzzzzzzzzj_ ?? izzzzzzzzzzzzzd_);
                DataType izzzzzzzzzzzzzf_ = FirstBladderCancerStaging?.Performed;
                object izzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzg_);
                CqlDateTime izzzzzzzzzzzzzi_ = context.Operators.Start(izzzzzzzzzzzzzh_);
                bool? izzzzzzzzzzzzzj_ = context.Operators.SameOrBefore(izzzzzzzzzzzzze_, izzzzzzzzzzzzzi_, "day");

                return izzzzzzzzzzzzzj_;
            };
            IEnumerable<Procedure> gzzzzzzzzzzzzzw_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)gzzzzzzzzzzzzzu_, gzzzzzzzzzzzzzv_);
            MedicationRequest gzzzzzzzzzzzzzx_(Procedure FirstBladderCancerStaging) =>
                ImmunosuppressiveDrugs;
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzzy_ = context.Operators.Select<Procedure, MedicationRequest>(gzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzx_);

            return gzzzzzzzzzzzzzy_;
        };
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzq_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(gzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzp_);
        bool? gzzzzzzzzzzzzzr_(MedicationRequest ImmunosuppressiveDrugs)
        {
            Code<MedicationRequest.MedicationrequestStatus> jzzzzzzzzzzzzze_ = ImmunosuppressiveDrugs?.StatusElement;
            MedicationRequest.MedicationrequestStatus? jzzzzzzzzzzzzzf_ = jzzzzzzzzzzzzze_?.Value;
            string jzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzf_);
            string[] jzzzzzzzzzzzzzh_ = [
                "active",
                "completed",
            ];
            bool? jzzzzzzzzzzzzzi_ = context.Operators.In<string>(jzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzh_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> jzzzzzzzzzzzzzj_ = ImmunosuppressiveDrugs?.IntentElement;
            MedicationRequest.MedicationRequestIntent? jzzzzzzzzzzzzzk_ = jzzzzzzzzzzzzzj_?.Value;
            string jzzzzzzzzzzzzzl_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzk_);
            bool? jzzzzzzzzzzzzzm_ = context.Operators.Equal(jzzzzzzzzzzzzzl_, "order");
            bool? jzzzzzzzzzzzzzn_ = context.Operators.And(jzzzzzzzzzzzzzi_, jzzzzzzzzzzzzzm_);

            return jzzzzzzzzzzzzzn_;
        };
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzs_ = context.Operators.Where<MedicationRequest>(gzzzzzzzzzzzzzq_, gzzzzzzzzzzzzzr_);

        return gzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Cystectomy Done")]
    public IEnumerable<Procedure> Cystectomy_Done(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzo_ = this.Cystectomy_for_Urology_Care(context);
        IEnumerable<Procedure> jzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, jzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> jzzzzzzzzzzzzzq_(Procedure Cystectomy)
        {
            Procedure jzzzzzzzzzzzzzu_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] jzzzzzzzzzzzzzv_ = [
                jzzzzzzzzzzzzzu_,
            ];
            bool? jzzzzzzzzzzzzzw_(Procedure FirstBladderCancerStaging)
            {
                DataType kzzzzzzzzzzzzza_ = Cystectomy?.Performed;
                object kzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzb_);
                CqlDateTime kzzzzzzzzzzzzzd_ = context.Operators.End(kzzzzzzzzzzzzzc_);
                DataType kzzzzzzzzzzzzze_ = FirstBladderCancerStaging?.Performed;
                object kzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzf_);
                CqlDateTime kzzzzzzzzzzzzzh_ = context.Operators.Start(kzzzzzzzzzzzzzg_);
                CqlQuantity kzzzzzzzzzzzzzi_ = context.Operators.Quantity(6m, "months");
                CqlDateTime kzzzzzzzzzzzzzj_ = context.Operators.Subtract(kzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzi_);
                object kzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzl_);
                CqlDateTime kzzzzzzzzzzzzzn_ = context.Operators.Start(kzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzo_ = context.Operators.Interval(kzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzn_, true, false);
                bool? kzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzd_, kzzzzzzzzzzzzzo_, default);
                object kzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzr_);
                CqlDateTime kzzzzzzzzzzzzzt_ = context.Operators.Start(kzzzzzzzzzzzzzs_);
                bool? kzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzt_ is null));
                bool? kzzzzzzzzzzzzzv_ = context.Operators.And(kzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzu_);

                return kzzzzzzzzzzzzzv_;
            };
            IEnumerable<Procedure> jzzzzzzzzzzzzzx_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)jzzzzzzzzzzzzzv_, jzzzzzzzzzzzzzw_);
            Procedure jzzzzzzzzzzzzzy_(Procedure FirstBladderCancerStaging) =>
                Cystectomy;
            IEnumerable<Procedure> jzzzzzzzzzzzzzz_ = context.Operators.Select<Procedure, Procedure>(jzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzy_);

            return jzzzzzzzzzzzzzz_;
        };
        IEnumerable<Procedure> jzzzzzzzzzzzzzr_ = context.Operators.SelectMany<Procedure, Procedure>(jzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzq_);
        bool? jzzzzzzzzzzzzzs_(Procedure Cystectomy)
        {
            Code<EventStatus> kzzzzzzzzzzzzzw_ = Cystectomy?.StatusElement;
            EventStatus? kzzzzzzzzzzzzzx_ = kzzzzzzzzzzzzzw_?.Value;
            string kzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzx_);
            bool? kzzzzzzzzzzzzzz_ = context.Operators.Equal(kzzzzzzzzzzzzzy_, "completed");

            return kzzzzzzzzzzzzzz_;
        };
        IEnumerable<Procedure> jzzzzzzzzzzzzzt_ = context.Operators.Where<Procedure>(jzzzzzzzzzzzzzr_, jzzzzzzzzzzzzzs_);

        return jzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Has Excluding HIV, Immunocompromised Conditions or Mixed Histology Before Staging")]
    public bool? Has_Excluding_HIV__Immunocompromised_Conditions_or_Mixed_Histology_Before_Staging(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzza_ = this.HIV(context);
        IEnumerable<Condition> lzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet lzzzzzzzzzzzzzc_ = this.Immunocompromised_Conditions(context);
        IEnumerable<Condition> lzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> lzzzzzzzzzzzzze_ = context.Operators.Union<Condition>(lzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzd_);
        CqlValueSet lzzzzzzzzzzzzzf_ = this.Mixed_histology_urothelial_cell_carcinoma_for_Urology_Care(context);
        IEnumerable<Condition> lzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> lzzzzzzzzzzzzzh_ = context.Operators.Union<Condition>(lzzzzzzzzzzzzze_, lzzzzzzzzzzzzzg_);
        IEnumerable<Condition> lzzzzzzzzzzzzzi_(Condition ExclusionDiagnosis)
        {
            Procedure lzzzzzzzzzzzzzn_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] lzzzzzzzzzzzzzo_ = [
                lzzzzzzzzzzzzzn_,
            ];
            bool? lzzzzzzzzzzzzzp_(Procedure FirstBladderCancerStaging)
            {
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ExclusionDiagnosis);
                CqlDateTime lzzzzzzzzzzzzzu_ = context.Operators.Start(lzzzzzzzzzzzzzt_);
                DataType lzzzzzzzzzzzzzv_ = FirstBladderCancerStaging?.Performed;
                object lzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzw_);
                CqlDateTime lzzzzzzzzzzzzzy_ = context.Operators.Start(lzzzzzzzzzzzzzx_);
                bool? lzzzzzzzzzzzzzz_ = context.Operators.SameOrBefore(lzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzy_, "day");

                return lzzzzzzzzzzzzzz_;
            };
            IEnumerable<Procedure> lzzzzzzzzzzzzzq_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)lzzzzzzzzzzzzzo_, lzzzzzzzzzzzzzp_);
            Condition lzzzzzzzzzzzzzr_(Procedure FirstBladderCancerStaging) =>
                ExclusionDiagnosis;
            IEnumerable<Condition> lzzzzzzzzzzzzzs_ = context.Operators.Select<Procedure, Condition>(lzzzzzzzzzzzzzq_, lzzzzzzzzzzzzzr_);

            return lzzzzzzzzzzzzzs_;
        };
        IEnumerable<Condition> lzzzzzzzzzzzzzj_ = context.Operators.SelectMany<Condition, Condition>(lzzzzzzzzzzzzzh_, lzzzzzzzzzzzzzi_);
        bool? lzzzzzzzzzzzzzk_(Condition ExclusionDiagnosis)
        {
            bool? mzzzzzzzzzzzzza_ = this.isConfirmedActiveDiagnosis(context, ExclusionDiagnosis);

            return mzzzzzzzzzzzzza_;
        };
        IEnumerable<Condition> lzzzzzzzzzzzzzl_ = context.Operators.Where<Condition>(lzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzk_);
        bool? lzzzzzzzzzzzzzm_ = context.Operators.Exists<Condition>(lzzzzzzzzzzzzzl_);

        return lzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Has Excluding Chemotherapy or Radiotherapy Procedure Before Staging")]
    public bool? Has_Excluding_Chemotherapy_or_Radiotherapy_Procedure_Before_Staging(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzb_ = this.Chemotherapy_Agents_for_Advanced_Cancer(context);
        IEnumerable<MedicationRequest> mzzzzzzzzzzzzzc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, mzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> mzzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, mzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> mzzzzzzzzzzzzzf_ = context.Operators.Union<MedicationRequest>(mzzzzzzzzzzzzzc_, mzzzzzzzzzzzzze_);
        IEnumerable<MedicationRequest> mzzzzzzzzzzzzzg_(MedicationRequest ExclusionMed)
        {
            Procedure mzzzzzzzzzzzzzt_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] mzzzzzzzzzzzzzu_ = [
                mzzzzzzzzzzzzzt_,
            ];
            bool? mzzzzzzzzzzzzzv_(Procedure FirstBladderCancerStaging)
            {
                List<Dosage> mzzzzzzzzzzzzzz_ = ExclusionMed?.DosageInstruction;
                bool? nzzzzzzzzzzzzza_(Dosage @this)
                {
                    Timing ozzzzzzzzzzzzzm_ = @this?.Timing;
                    bool? ozzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzm_ is null));

                    return ozzzzzzzzzzzzzn_;
                };
                IEnumerable<Dosage> nzzzzzzzzzzzzzb_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)mzzzzzzzzzzzzzz_, nzzzzzzzzzzzzza_);
                Timing nzzzzzzzzzzzzzc_(Dosage @this)
                {
                    Timing ozzzzzzzzzzzzzo_ = @this?.Timing;

                    return ozzzzzzzzzzzzzo_;
                };
                IEnumerable<Timing> nzzzzzzzzzzzzzd_ = context.Operators.Select<Dosage, Timing>(nzzzzzzzzzzzzzb_, nzzzzzzzzzzzzzc_);
                bool? nzzzzzzzzzzzzze_(Timing @this)
                {
                    Timing.RepeatComponent ozzzzzzzzzzzzzp_ = @this?.Repeat;
                    bool? ozzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzp_ is null));

                    return ozzzzzzzzzzzzzq_;
                };
                IEnumerable<Timing> nzzzzzzzzzzzzzf_ = context.Operators.Where<Timing>(nzzzzzzzzzzzzzd_, nzzzzzzzzzzzzze_);
                Timing.RepeatComponent nzzzzzzzzzzzzzg_(Timing @this)
                {
                    Timing.RepeatComponent ozzzzzzzzzzzzzr_ = @this?.Repeat;

                    return ozzzzzzzzzzzzzr_;
                };
                IEnumerable<Timing.RepeatComponent> nzzzzzzzzzzzzzh_ = context.Operators.Select<Timing, Timing.RepeatComponent>(nzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzg_);
                bool? nzzzzzzzzzzzzzi_(Timing.RepeatComponent @this)
                {
                    DataType ozzzzzzzzzzzzzs_ = @this?.Bounds;
                    object ozzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzs_);
                    bool? ozzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzt_ is null));

                    return ozzzzzzzzzzzzzu_;
                };
                IEnumerable<Timing.RepeatComponent> nzzzzzzzzzzzzzj_ = context.Operators.Where<Timing.RepeatComponent>(nzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzi_);
                object nzzzzzzzzzzzzzk_(Timing.RepeatComponent @this)
                {
                    DataType ozzzzzzzzzzzzzv_ = @this?.Bounds;
                    object ozzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzv_);

                    return ozzzzzzzzzzzzzw_;
                };
                IEnumerable<object> nzzzzzzzzzzzzzl_ = context.Operators.Select<Timing.RepeatComponent, object>(nzzzzzzzzzzzzzj_, nzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzm_(object DoseTime)
                {
                    CqlInterval<CqlDateTime> ozzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, DoseTime);

                    return ozzzzzzzzzzzzzx_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> nzzzzzzzzzzzzzn_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(nzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzm_);
                IEnumerable<CqlInterval<CqlDateTime>> nzzzzzzzzzzzzzo_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(nzzzzzzzzzzzzzn_);
                IEnumerable<CqlInterval<CqlDateTime>> nzzzzzzzzzzzzzp_ = context.Operators.Collapse(nzzzzzzzzzzzzzo_, default);
                object nzzzzzzzzzzzzzq_(CqlInterval<CqlDateTime> @this)
                {
                    CqlDateTime ozzzzzzzzzzzzzy_ = context.Operators.Start(@this);

                    return ozzzzzzzzzzzzzy_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> nzzzzzzzzzzzzzr_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(nzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzs_ = context.Operators.First<CqlInterval<CqlDateTime>>(nzzzzzzzzzzzzzr_);
                CqlDateTime nzzzzzzzzzzzzzt_ = context.Operators.Start(nzzzzzzzzzzzzzs_);
                DataType nzzzzzzzzzzzzzu_ = FirstBladderCancerStaging?.Performed;
                object nzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzv_);
                CqlDateTime nzzzzzzzzzzzzzx_ = context.Operators.Start(nzzzzzzzzzzzzzw_);
                CqlQuantity nzzzzzzzzzzzzzy_ = context.Operators.Quantity(6m, "months");
                CqlDateTime nzzzzzzzzzzzzzz_ = context.Operators.Subtract(nzzzzzzzzzzzzzx_, nzzzzzzzzzzzzzy_);
                object ozzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzb_);
                CqlDateTime ozzzzzzzzzzzzzd_ = context.Operators.Start(ozzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzze_ = context.Operators.Interval(nzzzzzzzzzzzzzz_, ozzzzzzzzzzzzzd_, true, false);
                bool? ozzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzt_, ozzzzzzzzzzzzze_, default);
                object ozzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzh_);
                CqlDateTime ozzzzzzzzzzzzzj_ = context.Operators.Start(ozzzzzzzzzzzzzi_);
                bool? ozzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzj_ is null));
                bool? ozzzzzzzzzzzzzl_ = context.Operators.And(ozzzzzzzzzzzzzf_, ozzzzzzzzzzzzzk_);

                return ozzzzzzzzzzzzzl_;
            };
            IEnumerable<Procedure> mzzzzzzzzzzzzzw_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)mzzzzzzzzzzzzzu_, mzzzzzzzzzzzzzv_);
            MedicationRequest mzzzzzzzzzzzzzx_(Procedure FirstBladderCancerStaging) =>
                ExclusionMed;
            IEnumerable<MedicationRequest> mzzzzzzzzzzzzzy_ = context.Operators.Select<Procedure, MedicationRequest>(mzzzzzzzzzzzzzw_, mzzzzzzzzzzzzzx_);

            return mzzzzzzzzzzzzzy_;
        };
        IEnumerable<MedicationRequest> mzzzzzzzzzzzzzh_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(mzzzzzzzzzzzzzf_, mzzzzzzzzzzzzzg_);
        bool? mzzzzzzzzzzzzzi_(MedicationRequest ExclusionMed)
        {
            Code<MedicationRequest.MedicationrequestStatus> ozzzzzzzzzzzzzz_ = ExclusionMed?.StatusElement;
            MedicationRequest.MedicationrequestStatus? pzzzzzzzzzzzzza_ = ozzzzzzzzzzzzzz_?.Value;
            string pzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(pzzzzzzzzzzzzza_);
            string[] pzzzzzzzzzzzzzc_ = [
                "active",
                "completed",
            ];
            bool? pzzzzzzzzzzzzzd_ = context.Operators.In<string>(pzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzc_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> pzzzzzzzzzzzzze_ = ExclusionMed?.IntentElement;
            MedicationRequest.MedicationRequestIntent? pzzzzzzzzzzzzzf_ = pzzzzzzzzzzzzze_?.Value;
            string pzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzf_);
            bool? pzzzzzzzzzzzzzh_ = context.Operators.Equal(pzzzzzzzzzzzzzg_, "order");
            bool? pzzzzzzzzzzzzzi_ = context.Operators.And(pzzzzzzzzzzzzzd_, pzzzzzzzzzzzzzh_);

            return pzzzzzzzzzzzzzi_;
        };
        IEnumerable<MedicationRequest> mzzzzzzzzzzzzzj_ = context.Operators.Where<MedicationRequest>(mzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzi_);
        CqlCode mzzzzzzzzzzzzzk_ = this.Combined_radiotherapy__procedure_(context);
        IEnumerable<CqlCode> mzzzzzzzzzzzzzl_ = context.Operators.ToList<CqlCode>(mzzzzzzzzzzzzzk_);
        IEnumerable<Procedure> mzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, mzzzzzzzzzzzzzl_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> mzzzzzzzzzzzzzn_(Procedure ExclusionProcedure)
        {
            Procedure pzzzzzzzzzzzzzj_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] pzzzzzzzzzzzzzk_ = [
                pzzzzzzzzzzzzzj_,
            ];
            bool? pzzzzzzzzzzzzzl_(Procedure FirstBladderCancerStaging)
            {
                DataType pzzzzzzzzzzzzzp_ = ExclusionProcedure?.Performed;
                object pzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzq_);
                CqlDateTime pzzzzzzzzzzzzzs_ = context.Operators.Start(pzzzzzzzzzzzzzr_);
                DataType pzzzzzzzzzzzzzt_ = FirstBladderCancerStaging?.Performed;
                object pzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzu_);
                CqlDateTime pzzzzzzzzzzzzzw_ = context.Operators.Start(pzzzzzzzzzzzzzv_);
                CqlQuantity pzzzzzzzzzzzzzx_ = context.Operators.Quantity(6m, "months");
                CqlDateTime pzzzzzzzzzzzzzy_ = context.Operators.Subtract(pzzzzzzzzzzzzzw_, pzzzzzzzzzzzzzx_);
                object qzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzza_);
                CqlDateTime qzzzzzzzzzzzzzc_ = context.Operators.Start(qzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzd_ = context.Operators.Interval(pzzzzzzzzzzzzzy_, qzzzzzzzzzzzzzc_, true, false);
                bool? qzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzd_, default);
                object qzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzg_);
                CqlDateTime qzzzzzzzzzzzzzi_ = context.Operators.Start(qzzzzzzzzzzzzzh_);
                bool? qzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzi_ is null));
                bool? qzzzzzzzzzzzzzk_ = context.Operators.And(qzzzzzzzzzzzzze_, qzzzzzzzzzzzzzj_);

                return qzzzzzzzzzzzzzk_;
            };
            IEnumerable<Procedure> pzzzzzzzzzzzzzm_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)pzzzzzzzzzzzzzk_, pzzzzzzzzzzzzzl_);
            Procedure pzzzzzzzzzzzzzn_(Procedure FirstBladderCancerStaging) =>
                ExclusionProcedure;
            IEnumerable<Procedure> pzzzzzzzzzzzzzo_ = context.Operators.Select<Procedure, Procedure>(pzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzn_);

            return pzzzzzzzzzzzzzo_;
        };
        IEnumerable<Procedure> mzzzzzzzzzzzzzo_ = context.Operators.SelectMany<Procedure, Procedure>(mzzzzzzzzzzzzzm_, mzzzzzzzzzzzzzn_);
        bool? mzzzzzzzzzzzzzp_(Procedure ExclusionProcedure)
        {
            Code<EventStatus> qzzzzzzzzzzzzzl_ = ExclusionProcedure?.StatusElement;
            EventStatus? qzzzzzzzzzzzzzm_ = qzzzzzzzzzzzzzl_?.Value;
            string qzzzzzzzzzzzzzn_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzm_);
            bool? qzzzzzzzzzzzzzo_ = context.Operators.Equal(qzzzzzzzzzzzzzn_, "completed");

            return qzzzzzzzzzzzzzo_;
        };
        IEnumerable<Procedure> mzzzzzzzzzzzzzq_ = context.Operators.Where<Procedure>(mzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzp_);
        IEnumerable<object> mzzzzzzzzzzzzzr_ = context.Operators.Union<object>(mzzzzzzzzzzzzzj_ as IEnumerable<object>, mzzzzzzzzzzzzzq_ as IEnumerable<object>);
        bool? mzzzzzzzzzzzzzs_ = context.Operators.Exists<object>(mzzzzzzzzzzzzzr_);

        return mzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public bool? Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Condition> qzzzzzzzzzzzzzp_ = this.Acute_Tuberculosis_Diagnosis(context);
        bool? qzzzzzzzzzzzzzq_ = context.Operators.Exists<Condition>(qzzzzzzzzzzzzzp_);
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzr_ = this.Immunosuppressive_Drugs(context);
        bool? qzzzzzzzzzzzzzs_ = context.Operators.Exists<MedicationRequest>(qzzzzzzzzzzzzzr_);
        bool? qzzzzzzzzzzzzzt_ = context.Operators.Or(qzzzzzzzzzzzzzq_, qzzzzzzzzzzzzzs_);
        IEnumerable<Procedure> qzzzzzzzzzzzzzu_ = this.Cystectomy_Done(context);
        bool? qzzzzzzzzzzzzzv_ = context.Operators.Exists<Procedure>(qzzzzzzzzzzzzzu_);
        bool? qzzzzzzzzzzzzzw_ = context.Operators.Or(qzzzzzzzzzzzzzt_, qzzzzzzzzzzzzzv_);
        bool? qzzzzzzzzzzzzzx_ = this.Has_Excluding_HIV__Immunocompromised_Conditions_or_Mixed_Histology_Before_Staging(context);
        bool? qzzzzzzzzzzzzzy_ = context.Operators.Or(qzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzx_);
        bool? qzzzzzzzzzzzzzz_ = this.Has_Excluding_Chemotherapy_or_Radiotherapy_Procedure_Before_Staging(context);
        bool? rzzzzzzzzzzzzza_ = context.Operators.Or(qzzzzzzzzzzzzzy_, qzzzzzzzzzzzzzz_);

        return rzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Denominator Exception")]
    [CqlTag("commentedOut", "\"BCG Not Available Within 6 Months After Bladder Cancer Staging\"")]
    [CqlTag("commentedOutReason", "Negation issue related to https://github.com/cqframework/cql-execution/issues/296, which is tied to https://oncprojectracking.healthit.gov/support/browse/BONNIEMAT-1455. Due to this being the only logic in this population added 'false' as a placeholder.")]
    public bool? Denominator_Exception(CqlContext context) =>
        false;


    [CqlExpressionDefinition("First BCG Administered")]
    public MedicationAdministration First_BCG_Administered(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzb_ = this.BCG_Bacillus_Calmette_Guerin_for_Urology_Care(context);
        IEnumerable<MedicationAdministration> rzzzzzzzzzzzzzc_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, rzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> rzzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, rzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> rzzzzzzzzzzzzzf_ = context.Operators.Union<MedicationAdministration>(rzzzzzzzzzzzzzc_, rzzzzzzzzzzzzze_);
        IEnumerable<MedicationAdministration> rzzzzzzzzzzzzzg_(MedicationAdministration BCG)
        {
            Procedure rzzzzzzzzzzzzzn_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] rzzzzzzzzzzzzzo_ = [
                rzzzzzzzzzzzzzn_,
            ];
            bool? rzzzzzzzzzzzzzp_(Procedure FirstBladderCancerStaging)
            {
                DataType rzzzzzzzzzzzzzt_ = BCG?.Effective;
                object rzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzu_);
                CqlDateTime rzzzzzzzzzzzzzw_ = context.Operators.Start(rzzzzzzzzzzzzzv_);
                DataType rzzzzzzzzzzzzzx_ = FirstBladderCancerStaging?.Performed;
                object rzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzy_);
                CqlDateTime szzzzzzzzzzzzza_ = context.Operators.Start(rzzzzzzzzzzzzzz_);
                object szzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzc_);
                CqlDateTime szzzzzzzzzzzzze_ = context.Operators.Start(szzzzzzzzzzzzzd_);
                CqlQuantity szzzzzzzzzzzzzf_ = context.Operators.Quantity(6m, "months");
                CqlDateTime szzzzzzzzzzzzzg_ = context.Operators.Add(szzzzzzzzzzzzze_, szzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzh_ = context.Operators.Interval(szzzzzzzzzzzzza_, szzzzzzzzzzzzzg_, false, true);
                bool? szzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzw_, szzzzzzzzzzzzzh_, default);
                object szzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzk_);
                CqlDateTime szzzzzzzzzzzzzm_ = context.Operators.Start(szzzzzzzzzzzzzl_);
                bool? szzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzm_ is null));
                bool? szzzzzzzzzzzzzo_ = context.Operators.And(szzzzzzzzzzzzzi_, szzzzzzzzzzzzzn_);
                object szzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzq_);
                CqlDateTime szzzzzzzzzzzzzs_ = context.Operators.Start(szzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzt_ = this.Measurement_Period(context);
                bool? szzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzs_, szzzzzzzzzzzzzt_, default);
                bool? szzzzzzzzzzzzzv_ = context.Operators.And(szzzzzzzzzzzzzo_, szzzzzzzzzzzzzu_);

                return szzzzzzzzzzzzzv_;
            };
            IEnumerable<Procedure> rzzzzzzzzzzzzzq_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)rzzzzzzzzzzzzzo_, rzzzzzzzzzzzzzp_);
            MedicationAdministration rzzzzzzzzzzzzzr_(Procedure FirstBladderCancerStaging) =>
                BCG;
            IEnumerable<MedicationAdministration> rzzzzzzzzzzzzzs_ = context.Operators.Select<Procedure, MedicationAdministration>(rzzzzzzzzzzzzzq_, rzzzzzzzzzzzzzr_);

            return rzzzzzzzzzzzzzs_;
        };
        IEnumerable<MedicationAdministration> rzzzzzzzzzzzzzh_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(rzzzzzzzzzzzzzf_, rzzzzzzzzzzzzzg_);
        bool? rzzzzzzzzzzzzzi_(MedicationAdministration BCG)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> szzzzzzzzzzzzzw_ = BCG?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? szzzzzzzzzzzzzx_ = szzzzzzzzzzzzzw_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> szzzzzzzzzzzzzy_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(szzzzzzzzzzzzzx_);
            string szzzzzzzzzzzzzz_ = context.Operators.Convert<string>(szzzzzzzzzzzzzy_);
            string[] tzzzzzzzzzzzzza_ = [
                "in-progress",
                "completed",
            ];
            bool? tzzzzzzzzzzzzzb_ = context.Operators.In<string>(szzzzzzzzzzzzzz_, tzzzzzzzzzzzzza_ as IEnumerable<string>);

            return tzzzzzzzzzzzzzb_;
        };
        IEnumerable<MedicationAdministration> rzzzzzzzzzzzzzj_ = context.Operators.Where<MedicationAdministration>(rzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzi_);
        object rzzzzzzzzzzzzzk_(MedicationAdministration @this)
        {
            DataType tzzzzzzzzzzzzzc_ = @this?.Effective;
            object tzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzd_);
            CqlDateTime tzzzzzzzzzzzzzf_ = context.Operators.Start(tzzzzzzzzzzzzze_);

            return tzzzzzzzzzzzzzf_;
        };
        IEnumerable<MedicationAdministration> rzzzzzzzzzzzzzl_ = context.Operators.SortBy<MedicationAdministration>(rzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
        MedicationAdministration rzzzzzzzzzzzzzm_ = context.Operators.First<MedicationAdministration>(rzzzzzzzzzzzzzl_);

        return rzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        MedicationAdministration tzzzzzzzzzzzzzg_ = this.First_BCG_Administered(context);
        bool? tzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzg_ is null));

        return tzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? tzzzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return tzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> tzzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return tzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? tzzzzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return tzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode tzzzzzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return tzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("BCG Not Available Within 6 Months After Bladder Cancer Staging")]
    public IEnumerable<MedicationAdministration> BCG_Not_Available_Within_6_Months_After_Bladder_Cancer_Staging(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzm_ = this.BCG_Bacillus_Calmette_Guerin_for_Urology_Care(context);
        IEnumerable<MedicationAdministration> tzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, tzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotadministered"));
        IEnumerable<MedicationAdministration> tzzzzzzzzzzzzzp_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, tzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotadministered"));
        IEnumerable<MedicationAdministration> tzzzzzzzzzzzzzq_ = context.Operators.Union<MedicationAdministration>(tzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzp_);
        IEnumerable<MedicationAdministration> tzzzzzzzzzzzzzr_(MedicationAdministration BCGNotGiven)
        {
            Procedure tzzzzzzzzzzzzzv_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] tzzzzzzzzzzzzzw_ = [
                tzzzzzzzzzzzzzv_,
            ];
            bool? tzzzzzzzzzzzzzx_(Procedure FirstBladderCancerStaging)
            {
                bool? uzzzzzzzzzzzzzb_(Extension @this)
                {
                    string uzzzzzzzzzzzzzz_ = @this?.Url;
                    FhirString vzzzzzzzzzzzzza_ = context.Operators.Convert<FhirString>(uzzzzzzzzzzzzzz_);
                    string vzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToString(context, vzzzzzzzzzzzzza_);
                    bool? vzzzzzzzzzzzzzc_ = context.Operators.Equal(vzzzzzzzzzzzzzb_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

                    return vzzzzzzzzzzzzzc_;
                };
                IEnumerable<Extension> uzzzzzzzzzzzzzc_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(BCGNotGiven is DomainResource
                        ? (BCGNotGiven as DomainResource).Extension
                        : default), uzzzzzzzzzzzzzb_);
                DataType uzzzzzzzzzzzzzd_(Extension @this)
                {
                    DataType vzzzzzzzzzzzzzd_ = @this?.Value;

                    return vzzzzzzzzzzzzzd_;
                };
                IEnumerable<DataType> uzzzzzzzzzzzzze_ = context.Operators.Select<Extension, DataType>(uzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzd_);
                DataType uzzzzzzzzzzzzzf_ = context.Operators.SingletonFrom<DataType>(uzzzzzzzzzzzzze_);
                CqlDateTime uzzzzzzzzzzzzzg_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzzzf_);
                DataType uzzzzzzzzzzzzzh_ = FirstBladderCancerStaging?.Performed;
                object uzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzi_);
                CqlDateTime uzzzzzzzzzzzzzk_ = context.Operators.Start(uzzzzzzzzzzzzzj_);
                object uzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzm_);
                CqlDateTime uzzzzzzzzzzzzzo_ = context.Operators.Start(uzzzzzzzzzzzzzn_);
                CqlQuantity uzzzzzzzzzzzzzp_ = context.Operators.Quantity(6m, "months");
                CqlDateTime uzzzzzzzzzzzzzq_ = context.Operators.Add(uzzzzzzzzzzzzzo_, uzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzr_ = context.Operators.Interval(uzzzzzzzzzzzzzk_, uzzzzzzzzzzzzzq_, false, true);
                bool? uzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzr_, default);
                object uzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzu_);
                CqlDateTime uzzzzzzzzzzzzzw_ = context.Operators.Start(uzzzzzzzzzzzzzv_);
                bool? uzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzw_ is null));
                bool? uzzzzzzzzzzzzzy_ = context.Operators.And(uzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzx_);

                return uzzzzzzzzzzzzzy_;
            };
            IEnumerable<Procedure> tzzzzzzzzzzzzzy_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)tzzzzzzzzzzzzzw_, tzzzzzzzzzzzzzx_);
            MedicationAdministration tzzzzzzzzzzzzzz_(Procedure FirstBladderCancerStaging) =>
                BCGNotGiven;
            IEnumerable<MedicationAdministration> uzzzzzzzzzzzzza_ = context.Operators.Select<Procedure, MedicationAdministration>(tzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzz_);

            return uzzzzzzzzzzzzza_;
        };
        IEnumerable<MedicationAdministration> tzzzzzzzzzzzzzs_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(tzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzr_);
        bool? tzzzzzzzzzzzzzt_(MedicationAdministration BCGNotGiven)
        {
            List<CodeableConcept> vzzzzzzzzzzzzze_ = BCGNotGiven?.StatusReason;
            CqlConcept vzzzzzzzzzzzzzf_(CodeableConcept @this)
            {
                CqlConcept vzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return vzzzzzzzzzzzzzj_;
            };
            IEnumerable<CqlConcept> vzzzzzzzzzzzzzg_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)vzzzzzzzzzzzzze_, vzzzzzzzzzzzzzf_);
            CqlValueSet vzzzzzzzzzzzzzh_ = this.Unavailability_of_Bacillus_Calmette_Guerin_for_urology_care(context);
            bool? vzzzzzzzzzzzzzi_ = context.Operators.ConceptsInValueSet(vzzzzzzzzzzzzzg_, vzzzzzzzzzzzzzh_);

            return vzzzzzzzzzzzzzi_;
        };
        IEnumerable<MedicationAdministration> tzzzzzzzzzzzzzu_ = context.Operators.Where<MedicationAdministration>(tzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzt_);

        return tzzzzzzzzzzzzzu_;
    }


    #endregion Expressions

}
