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
[CqlLibrary("UrinarySymptomScoreChangeAfterBenignProstaticHyperplasiaFHIR", "1.4.000")]
public partial class UrinarySymptomScoreChangeAfterBenignProstaticHyperplasiaFHIR_1_4_000 : ILibrary, ISingleton<UrinarySymptomScoreChangeAfterBenignProstaticHyperplasiaFHIR_1_4_000>
{
    private UrinarySymptomScoreChangeAfterBenignProstaticHyperplasiaFHIR_1_4_000() {}

    public static UrinarySymptomScoreChangeAfterBenignProstaticHyperplasiaFHIR_1_4_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "UrinarySymptomScoreChangeAfterBenignProstaticHyperplasiaFHIR";
    public string Version => "1.4.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Hospital Services for Urology", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.59", valueSetVersion: null)]
    public CqlValueSet Hospital_Services_for_Urology(CqlContext _) => _Hospital_Services_for_Urology;
    private static readonly CqlValueSet _Hospital_Services_for_Urology = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.59", null);

    [CqlValueSetDefinition("Morbid Obesity", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1164.67", valueSetVersion: null)]
    public CqlValueSet Morbid_Obesity(CqlContext _) => _Morbid_Obesity;
    private static readonly CqlValueSet _Morbid_Obesity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1164.67", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Urinary retention", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1164.52", valueSetVersion: null)]
    public CqlValueSet Urinary_retention(CqlContext _) => _Urinary_retention;
    private static readonly CqlValueSet _Urinary_retention = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1164.52", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("American Urological Association Symptom Index [AUASI]", codeId: "80883-2", codeSystem: "http://loinc.org")]
    public CqlCode American_Urological_Association_Symptom_Index__AUASI_(CqlContext _) => _American_Urological_Association_Symptom_Index__AUASI_;
    private static readonly CqlCode _American_Urological_Association_Symptom_Index__AUASI_ = new CqlCode("80883-2", "http://loinc.org", default, default);

    [CqlCodeDefinition("Benign prostatic hyperplasia with lower urinary tract symptoms", codeId: "N40.1", codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms(CqlContext _) => _Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms;
    private static readonly CqlCode _Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms = new CqlCode("N40.1", "http://hl7.org/fhir/sid/icd-10-cm", default, default);

    [CqlCodeDefinition("If you were to spend the rest of your life with your urinary condition just the way it is now, how would you feel about that [IPSS]", codeId: "81090-3", codeSystem: "http://loinc.org")]
    public CqlCode If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_(CqlContext _) => _If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_;
    private static readonly CqlCode _If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_ = new CqlCode("81090-3", "http://loinc.org", default, default);

    [CqlCodeDefinition("International Prostate Symptom Score [IPSS]", codeId: "80976-4", codeSystem: "http://loinc.org")]
    public CqlCode International_Prostate_Symptom_Score__IPSS_(CqlContext _) => _International_Prostate_Symptom_Score__IPSS_;
    private static readonly CqlCode _International_Prostate_Symptom_Score__IPSS_ = new CqlCode("80976-4", "http://loinc.org", default, default);

    [CqlCodeDefinition("virtual", codeId: "VR", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode @virtual(CqlContext _) => _virtual;
    private static readonly CqlCode _virtual = new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ICD10CM")]
    public CqlCodeSystem ICD10CM(CqlContext _) => _ICD10CM;
    private static readonly CqlCodeSystem _ICD10CM = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ObservationCategoryCodes")]
    public CqlCodeSystem ObservationCategoryCodes(CqlContext _) => _ObservationCategoryCodes;
    private static readonly CqlCodeSystem _ObservationCategoryCodes = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ActCode")]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, true, true);
        object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.ResolveParameter("UrinarySymptomScoreChangeAfterBenignProstaticHyperplasiaFHIR-1.4.000", "Measurement Period", dzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return (CqlInterval<CqlDateTime>)dzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient dzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SingletonFrom<Patient>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Patient is Male")]
    public bool? Patient_is_Male(CqlContext context)
    {
        Patient dzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Patient(context);
        Code<AdministrativeGender> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.GenderElement;
        AdministrativeGender? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
        string dzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<string>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Equal(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "male");

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Has Qualifying Encounter")]
    public bool? Has_Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Office_Visit(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
            Period dzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "day");
            Coding dzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = ValidEncounter?.Class;
            CqlCode dzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToCode(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlCode dzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.@virtual(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equivalent(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Not(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            Code<Encounter.EncounterStatus> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
            Code<Encounter.EncounterStatus> ezzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Equal(ezzzzzzzzzzzzzzzzzzzzzzzzzzzze_, "finished");
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("isConfirmedActiveDiagnosis")]
    public bool? isConfirmedActiveDiagnosis(CqlContext context, Condition condition)
    {
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.isActive(context, condition);
        CodeableConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = condition?.VerificationStatus;
        CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        CqlCode ezzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.confirmed(context);
        CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConvertCodeToConcept(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Equivalent(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Initial BPH Diagnosis Starts Within 6 Months Before the Measurement Period")]
    public Condition Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(CqlContext context)
    {
        CqlCode ezzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms(context);
        IEnumerable<CqlCode> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ToList<CqlCode>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Condition NewBPHDiagnosis)
        {
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, NewBPHDiagnosis);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlQuantity fzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(6m, "months");
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Subtract(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, true, true);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.isConfirmedActiveDiagnosis(context, NewBPHDiagnosis);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Condition @this)
        {
            DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = @this?.Onset;
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SortBy<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
        Condition ezzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.First<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Has Qualifying BPH Diagnosis")]
    public bool? Has_Qualifying_BPH_Diagnosis(CqlContext context)
    {
        Condition fzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ is null));

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Documented IPSS Assessment Result")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> Documented_IPSS_Assessment_Result(CqlContext context)
    {
        CqlCode fzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.International_Prostate_Symptom_Score__IPSS_(context);
        IEnumerable<CqlCode> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ToList<CqlCode>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Observation IPSSAssessment)
        {
            Code<ObservationStatus> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = IPSSAssessment?.StatusElement;
            ObservationStatus? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
            Code<ObservationStatus> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<Code<ObservationStatus>>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            string fzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            string[] gzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<string>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as IEnumerable<string>);
            DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = IPSSAssessment?.Value;
            object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is null));
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Observation IPSSAssessment)
        {
            object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_()
            {
                bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_()
                {
                    DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = IPSSAssessment?.Effective;
                    object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                    bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ is CqlDateTime;

                    return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
                };
                bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_()
                {
                    DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = IPSSAssessment?.Effective;
                    object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                    bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is CqlInterval<CqlDateTime>;

                    return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
                };
                bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_()
                {
                    DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = IPSSAssessment?.Effective;
                    object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                    bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ is CqlDateTime;

                    return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
                };
                if (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_())
                {
                    DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = IPSSAssessment?.Effective;
                    object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                    return (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as CqlDateTime) as object;
                }
                else if (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_())
                {
                    DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = IPSSAssessment?.Effective;
                    object hzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                    return (hzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_())
                {
                    DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = IPSSAssessment?.Effective;
                    object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                    return (hzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_());
            DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = IPSSAssessment?.Value;
            object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = (CqlTupleMetadata_GNNDVIQPcTANSdLebhBKYIdga, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as int?);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("AUA Symptom Index and Quality of Life Assessment Result")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result(CqlContext context)
    {
        CqlCode hzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.American_Urological_Association_Symptom_Index__AUASI_(context);
        IEnumerable<CqlCode> hzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Observation AUASIAssessment)
        {
            Code<ObservationStatus> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = AUASIAssessment?.StatusElement;
            ObservationStatus? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
            Code<ObservationStatus> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<Code<ObservationStatus>>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            string hzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<string>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            string[] hzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<string>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as IEnumerable<string>);
            DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = AUASIAssessment?.Value;
            object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is null));
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation AUASIAssessment)
        {
            object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_()
            {
                bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzl_()
                {
                    DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = AUASIAssessment?.Effective;
                    object izzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                    bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ is CqlDateTime;

                    return izzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
                };
                bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzm_()
                {
                    DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = AUASIAssessment?.Effective;
                    object izzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                    bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is CqlInterval<CqlDateTime>;

                    return izzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
                };
                bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzn_()
                {
                    DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = AUASIAssessment?.Effective;
                    object izzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                    bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ is CqlDateTime;

                    return izzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
                };
                if (izzzzzzzzzzzzzzzzzzzzzzzzzzzzl_())
                {
                    DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = AUASIAssessment?.Effective;
                    object izzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                    return (izzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as CqlDateTime) as object;
                }
                else if (izzzzzzzzzzzzzzzzzzzzzzzzzzzzm_())
                {
                    DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = AUASIAssessment?.Effective;
                    object jzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                    return (jzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (izzzzzzzzzzzzzzzzzzzzzzzzzzzzn_())
                {
                    DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = AUASIAssessment?.Effective;
                    object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                    return (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_());
            DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = AUASIAssessment?.Value;
            object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlCode hzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_(context);
            IEnumerable<CqlCode> izzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, izzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Observation QOLAssessment)
            {
                object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_()
                {
                    bool jzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_()
                    {
                        DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QOLAssessment?.Effective;
                        object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                        bool jzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is CqlDateTime;

                        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                    };
                    bool jzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_()
                    {
                        DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QOLAssessment?.Effective;
                        object kzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                        bool kzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ is CqlInterval<CqlDateTime>;

                        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                    };
                    bool jzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_()
                    {
                        DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QOLAssessment?.Effective;
                        object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                        bool kzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                    };
                    if (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_())
                    {
                        DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QOLAssessment?.Effective;
                        object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                        return (kzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlDateTime) as object;
                    }
                    else if (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_())
                    {
                        DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QOLAssessment?.Effective;
                        object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                        return (kzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_())
                    {
                        DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QOLAssessment?.Effective;
                        object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                        return (kzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_());
                object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_()
                {
                    bool kzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_()
                    {
                        DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = AUASIAssessment?.Effective;
                        object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                        bool kzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ is CqlDateTime;

                        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
                    };
                    bool kzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_()
                    {
                        DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = AUASIAssessment?.Effective;
                        object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                        bool kzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is CqlInterval<CqlDateTime>;

                        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
                    };
                    bool kzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_()
                    {
                        DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = AUASIAssessment?.Effective;
                        object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                        bool kzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ is CqlDateTime;

                        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
                    };
                    if (kzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_())
                    {
                        DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = AUASIAssessment?.Effective;
                        object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                        return (kzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as CqlDateTime) as object;
                    }
                    else if (kzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_())
                    {
                        DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = AUASIAssessment?.Effective;
                        object lzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                        return (lzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (kzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_())
                    {
                        DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = AUASIAssessment?.Effective;
                        object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                        return (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_());
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SameAs(jzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, "day");
                Code<ObservationStatus> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QOLAssessment?.StatusElement;
                ObservationStatus? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
                Code<ObservationStatus> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<Code<ObservationStatus>>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                string jzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                string[] jzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<string>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as IEnumerable<string>);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QOLAssessment?.Value;
                object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ is null));
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

                return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            object izzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Observation @this)
            {
                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_()
                {
                    bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_()
                    {
                        DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = @this?.Effective;
                        object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                        bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is CqlDateTime;

                        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                    };
                    bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_()
                    {
                        DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = @this?.Effective;
                        object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                        bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ is CqlInterval<CqlDateTime>;

                        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
                    };
                    bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_()
                    {
                        DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = @this?.Effective;
                        object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                        bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ is CqlDateTime;

                        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
                    };
                    if (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_())
                    {
                        DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = @this?.Effective;
                        object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

                        return (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as CqlDateTime) as object;
                    }
                    else if (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_())
                    {
                        DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Effective;
                        object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                        return (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_())
                    {
                        DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = @this?.Effective;
                        object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                        return (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_());

                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SortBy<Observation>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzzzzzzzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
            Observation izzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Last<Observation>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
            object izzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            int? izzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Add(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as int?, izzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as int?);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? izzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = (CqlTupleMetadata_GNNDVIQPcTANSdLebhBKYIdga, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Urinary Symptom Score Assessment")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> Urinary_Symptom_Score_Assessment(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Documented_IPSS_Assessment_Result(context);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result(context);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Urinary Symptom Score Within 1 Month after Initial BPH Diagnosis")]
    public (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> mzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Urinary_Symptom_Score_Assessment(context);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? USSAssessment)
        {
            Condition mzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
            Condition[] mzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = [
                mzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_,
            ];
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Condition InitialBPHDiagnosis)
            {
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = USSAssessment?.effectiveDatetime;
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlQuantity mzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(1m, "month");
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Add(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, true, true);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "day");
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is null));
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Condition>((IEnumerable<Condition>)mzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Condition InitialBPHDiagnosis) =>
                USSAssessment;
            IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Condition, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SelectMany<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? @this)
        {
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.effectiveDatetime;

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> mzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.First<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Urinary Symptom Score 6 to 12 Months After Initial BPH Diagnosis")]
    public (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> nzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Urinary_Symptom_Score_Assessment(context);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? USSAssessment)
        {
            Condition nzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
            Condition[] nzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = [
                nzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_,
            ];
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Condition InitialBPHDiagnosis)
            {
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = USSAssessment?.effectiveDatetime;
                int? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DurationBetween(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, "month");
                CqlInterval<int?> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(6, 12, true, true);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<int?>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default);

                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Condition>((IEnumerable<Condition>)nzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Condition InitialBPHDiagnosis) =>
                USSAssessment;
            IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Condition, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SelectMany<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? @this)
        {
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = @this?.effectiveDatetime;

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> nzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Last<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Patient_is_Male(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Has_Qualifying_Encounter(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Has_Qualifying_BPH_Diagnosis(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ is null));
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ is null));
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzza_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Initial_Population(context);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Urinary Retention Diagnosis Starts Within 1 Year After Initial BPH Diagnosis")]
    public IEnumerable<Condition> Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Urinary_retention(context);
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Condition UrinaryRetention)
        {
            Condition ozzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
            Condition[] ozzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = [
                ozzzzzzzzzzzzzzzzzzzzzzzzzzzzl_,
            ];
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Condition InitialBPHDiagnosis)
            {
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, UrinaryRetention);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(1m, "year");
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Add(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, true, true);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "day");
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ is null));
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                return pzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Condition>((IEnumerable<Condition>)ozzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            Condition ozzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Condition InitialBPHDiagnosis) =>
                UrinaryRetention;
            IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Condition, Condition>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SelectMany<Condition, Condition>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Condition UrinaryRetention)
        {
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.isConfirmedActiveDiagnosis(context, UrinaryRetention);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Condition>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Has Initial BPH Diagnosis Starts During or Within 30 Days After End of Hospitalization")]
    public Condition Has_Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization(CqlContext context)
    {
        Condition pzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
        Condition[] pzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = [
            pzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_,
        ];
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Condition InitialBPHDiagnosis)
        {
            CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Hospital_Services_for_Urology(context);
            IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Encounter InHospitalServices)
            {
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                Period pzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = InHospitalServices?.Period;
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.End(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlQuantity pzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(31m, "days");
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Add(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, true, true);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default);
                Code<Encounter.EncounterStatus> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = InHospitalServices?.StatusElement;
                Encounter.EncounterStatus? qzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
                Code<Encounter.EncounterStatus> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "finished");
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            Condition pzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Encounter InHospitalServices) =>
                InitialBPHDiagnosis;
            IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Encounter, Condition>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<Condition, Condition>((IEnumerable<Condition>)pzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        Condition pzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SingletonFrom<Condition>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Morbid Obesity Diagnosis On or Before Follow Up USS Assessment")]
    public IEnumerable<Condition> Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Morbid_Obesity(context);
        IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Condition MorbidObesity)
        {
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(context);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?[] qzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = [
                qzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_,
            ];
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)
            {
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MorbidObesity);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Overlaps(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FollowUpUSSAssessment?.effectiveDatetime;
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SameOrBefore(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>((IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>)qzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            Condition qzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment) =>
                MorbidObesity;
            IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, Condition>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SelectMany<Condition, Condition>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Condition MorbidObesity)
        {
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.isConfirmedActiveDiagnosis(context, MorbidObesity);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Condition>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("BMI Exam Result Greater Than or Equal To 40 During Measurement Period and On or Before Follow Up USS Assessment")]
    [CqlTag("code", "Body mass index (BMI) [Ratio] - 39156-5")]
    [CqlTag("profile", "http://hl7.org/fhir/StructureDefinition/bmi")]
    public bool? BMI_Exam_Result_Greater_Than_or_Equal_To_40_During_Measurement_Period_and_On_or_Before_Follow_Up_USS_Assessment(CqlContext context)
    {
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bmi"));
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Observation BMIExam)
        {
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(context);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?[] rzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = [
                rzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_,
            ];
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)
            {
                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = BMIExam?.Value;
                CqlQuantity rzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as Quantity);
                CqlQuantity rzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(40m, "kg/m2");
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.GreaterOrEqual(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                Code<ObservationStatus> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = BMIExam?.StatusElement;
                ObservationStatus? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
                string rzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                string[] rzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<string>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as IEnumerable<string>);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = BMIExam?.Effective;
                object szzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "day");
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, szzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                object szzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FollowUpUSSAssessment?.effectiveDatetime;
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SameOrBefore(szzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                return szzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>((IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>)rzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            Observation rzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment) =>
                BMIExam;
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, Observation>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SelectMany<Observation, Observation>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Observation BMIExam)
        {
            DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = BMIExam?.Effective;
            object szzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<Observation, CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Morbid Obesity Diagnosis or BMI Exam Result Greater Than or Equal to 40 Starts On or Before Follow Up USS Assessment")]
    public bool? Morbid_Obesity_Diagnosis_or_BMI_Exam_Result_Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment(CqlContext context)
    {
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Condition>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.BMI_Exam_Result_Greater_Than_or_Equal_To_40_During_Measurement_Period_and_On_or_Before_Follow_Up_USS_Assessment(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Condition>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        Condition szzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Has_Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ is null));
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Morbid_Obesity_Diagnosis_or_BMI_Exam_Result_Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Urinary Symptom Score Change")]
    public int? Urinary_Symptom_Score_Change(CqlContext context)
    {
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? tzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis(context);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?[] tzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = [
            tzzzzzzzzzzzzzzzzzzzzzzzzzzzza_,
        ];
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(context);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?[] tzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = [
            tzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_,
        ];
        IEnumerable<ValueTuple<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>> tzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.CrossJoin<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>((IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>)tzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, (IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>)tzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        (CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(ValueTuple<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> _valueTuple)
        {
            (CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = (CqlTupleMetadata_FBHNjYWJgMKheadEZUgcdQGXN, _valueTuple.Item1, _valueTuple.Item2);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)?> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<ValueTuple<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>, (CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)?>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        int? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_((CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)? tuple_fbhnjywjgmkheadezugcdqgxn)
        {
            int? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = tuple_fbhnjywjgmkheadezugcdqgxn?.FirstUSSAssessment?.valueInteger;
            int? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = tuple_fbhnjywjgmkheadezugcdqgxn?.FollowUpUSSAssessment?.valueInteger;
            int? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Subtract(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<int?> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)?, int?>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<int?> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Distinct<int?>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        int? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SingletonFrom<int?>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Urinary Symptom Score Improvement Greater Than or Equal To 3")]
    public bool? Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3(CqlContext context)
    {
        int? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Urinary_Symptom_Score_Change(context);
        int?[] tzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = [
            tzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_,
        ];
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(int? USSImprovement)
        {
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.GreaterOrEqual(USSImprovement, 3);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<int?> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<int?>((IEnumerable<int?>)tzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        int? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SingletonFrom<int?>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ is null));

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3(context);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode uzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_FBHNjYWJgMKheadEZUgcdQGXN = new(
        [typeof((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?), typeof((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?)],
        ["FirstUSSAssessment", "FollowUpUSSAssessment"]);

    private static CqlTupleMetadata CqlTupleMetadata_GNNDVIQPcTANSdLebhBKYIdga = new(
        [typeof(CqlDateTime), typeof(int?)],
        ["effectiveDatetime", "valueInteger"]);

    #endregion CqlTupleMetadata Properties

}
