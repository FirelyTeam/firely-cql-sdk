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

    #region ValueSet: Hospital Services for Urology
    [CqlValueSetDefinition(
        definitionName: "Hospital Services for Urology",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.59",
        valueSetVersion: null)]
    public CqlValueSet Hospital_Services_for_Urology(CqlContext context) => _Hospital_Services_for_Urology;

    private static readonly CqlValueSet _Hospital_Services_for_Urology = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.59", null);
    #endregion

    #region ValueSet: Morbid Obesity
    [CqlValueSetDefinition(
        definitionName: "Morbid Obesity",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1164.67",
        valueSetVersion: null)]
    public CqlValueSet Morbid_Obesity(CqlContext context) => _Morbid_Obesity;

    private static readonly CqlValueSet _Morbid_Obesity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1164.67", null);
    #endregion

    #region ValueSet: Office Visit
    [CqlValueSetDefinition(
        definitionName: "Office Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext context) => _Office_Visit;

    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);
    #endregion

    #region ValueSet: Urinary retention
    [CqlValueSetDefinition(
        definitionName: "Urinary retention",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1164.52",
        valueSetVersion: null)]
    public CqlValueSet Urinary_retention(CqlContext context) => _Urinary_retention;

    private static readonly CqlValueSet _Urinary_retention = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1164.52", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: American Urological Association Symptom Index [AUASI]
    [CqlCodeDefinition(
        definitionName: "American Urological Association Symptom Index [AUASI]",
        codeId: "80883-2",
        codeSystem: "http://loinc.org")]
    public CqlCode American_Urological_Association_Symptom_Index__AUASI_(CqlContext context) => _American_Urological_Association_Symptom_Index__AUASI_;

    private static readonly CqlCode _American_Urological_Association_Symptom_Index__AUASI_ = new CqlCode("80883-2", "http://loinc.org", default, default);
    #endregion

    #region Code: Benign prostatic hyperplasia with lower urinary tract symptoms
    [CqlCodeDefinition(
        definitionName: "Benign prostatic hyperplasia with lower urinary tract symptoms",
        codeId: "N40.1",
        codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms(CqlContext context) => _Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms;

    private static readonly CqlCode _Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms = new CqlCode("N40.1", "http://hl7.org/fhir/sid/icd-10-cm", default, default);
    #endregion

    #region Code: If you were to spend the rest of your life with your urinary condition just the way it is now, how would you feel about that [IPSS]
    [CqlCodeDefinition(
        definitionName: "If you were to spend the rest of your life with your urinary condition just the way it is now, how would you feel about that [IPSS]",
        codeId: "81090-3",
        codeSystem: "http://loinc.org")]
    public CqlCode If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_(CqlContext context) => _If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_;

    private static readonly CqlCode _If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_ = new CqlCode("81090-3", "http://loinc.org", default, default);
    #endregion

    #region Code: International Prostate Symptom Score [IPSS]
    [CqlCodeDefinition(
        definitionName: "International Prostate Symptom Score [IPSS]",
        codeId: "80976-4",
        codeSystem: "http://loinc.org")]
    public CqlCode International_Prostate_Symptom_Score__IPSS_(CqlContext context) => _International_Prostate_Symptom_Score__IPSS_;

    private static readonly CqlCode _International_Prostate_Symptom_Score__IPSS_ = new CqlCode("80976-4", "http://loinc.org", default, default);
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
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = [
            new CqlCode("80883-2", "http://loinc.org", default, default),
            new CqlCode("81090-3", "http://loinc.org", default, default),
            new CqlCode("80976-4", "http://loinc.org", default, default),
        ];

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ICD10CM")]
    public CqlCode[] ICD10CM(CqlContext context)
    {
        CqlCode[] qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = [
            new CqlCode("N40.1", "http://hl7.org/fhir/sid/icd-10-cm", default, default),
        ];

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ObservationCategoryCodes")]
    public CqlCode[] ObservationCategoryCodes(CqlContext context)
    {
        CqlCode[] qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = []
;

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ActCode")]
    public CqlCode[] ActCode(CqlContext context)
    {
        CqlCode[] qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = [
            new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
        ];

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, true, true);
        object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.ResolveParameter("UrinarySymptomScoreChangeAfterBenignProstaticHyperplasiaFHIR-1.4.000", "Measurement Period", qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return (CqlInterval<CqlDateTime>)qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SingletonFrom<Patient>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Patient is Male")]
    public bool? Patient_is_Male(CqlContext context)
    {
        Patient qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Patient(context);
        Code<AdministrativeGender> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.GenderElement;
        AdministrativeGender? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
        string qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "male");

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Qualifying Encounter")]
    public bool? Has_Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Office_Visit(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            Period qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "day");
            Coding rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = ValidEncounter?.Class;
            CqlCode rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToCode(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlCode rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.@virtual(context);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equivalent(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Not(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            Code<Encounter.EncounterStatus> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
            Code<Encounter.EncounterStatus> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equal(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "finished");
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public bool? isConfirmedActiveDiagnosis(CqlContext context, Condition condition)
    {
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.isActive(context, condition);
        CodeableConcept rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = condition?.VerificationStatus;
        CqlConcept rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        CqlCode rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.confirmed(context);
        CqlConcept rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertCodeToConcept(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Equivalent(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial BPH Diagnosis Starts Within 6 Months Before the Measurement Period")]
    public Condition Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(CqlContext context)
    {
        CqlCode rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms(context);
        IEnumerable<CqlCode> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ToList<CqlCode>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Condition NewBPHDiagnosis)
        {
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, NewBPHDiagnosis);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(6m, "months");
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Subtract(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, true, true);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.isConfirmedActiveDiagnosis(context, NewBPHDiagnosis);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Condition>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Condition @this)
        {
            DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = @this?.Onset;
            object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SortBy<Condition>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
        Condition rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.First<Condition>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Qualifying BPH Diagnosis")]
    public bool? Has_Qualifying_BPH_Diagnosis(CqlContext context)
    {
        Condition szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ is null));

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Documented IPSS Assessment Result")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> Documented_IPSS_Assessment_Result(CqlContext context)
    {
        CqlCode szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.International_Prostate_Symptom_Score__IPSS_(context);
        IEnumerable<CqlCode> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ToList<CqlCode>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Observation IPSSAssessment)
        {
            Code<ObservationStatus> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = IPSSAssessment?.StatusElement;
            ObservationStatus? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_?.Value;
            Code<ObservationStatus> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<Code<ObservationStatus>>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            string tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<string>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            string[] tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<string>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as IEnumerable<string>);
            DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = IPSSAssessment?.Value;
            object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ is null));
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Observation IPSSAssessment)
        {
            object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_()
            {
                bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_()
                {
                    DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = IPSSAssessment?.Effective;
                    object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                    bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ is CqlDateTime;

                    return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
                };
                bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_()
                {
                    DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = IPSSAssessment?.Effective;
                    object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                    bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is CqlInterval<CqlDateTime>;

                    return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
                };
                bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_()
                {
                    DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = IPSSAssessment?.Effective;
                    object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                    bool uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ is CqlDateTime;

                    return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
                };
                if (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_())
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = IPSSAssessment?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                    return (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlDateTime) as object;
                }
                else if (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_())
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = IPSSAssessment?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                    return (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_())
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = IPSSAssessment?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                    return (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_());
            DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = IPSSAssessment?.Value;
            object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = (CqlTupleMetadata_GNNDVIQPcTANSdLebhBKYIdga, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as int?);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "AUA Symptom Index and Quality of Life Assessment Result")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result(CqlContext context)
    {
        CqlCode uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.American_Urological_Association_Symptom_Index__AUASI_(context);
        IEnumerable<CqlCode> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ToList<CqlCode>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation AUASIAssessment)
        {
            Code<ObservationStatus> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = AUASIAssessment?.StatusElement;
            ObservationStatus? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
            Code<ObservationStatus> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<Code<ObservationStatus>>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            string uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<string>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            string[] uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<string>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as IEnumerable<string>);
            DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = AUASIAssessment?.Value;
            object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is null));
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Observation AUASIAssessment)
        {
            object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_()
            {
                bool vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_()
                {
                    DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = AUASIAssessment?.Effective;
                    object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                    bool vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ is CqlDateTime;

                    return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
                };
                bool vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_()
                {
                    DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = AUASIAssessment?.Effective;
                    object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                    bool vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is CqlInterval<CqlDateTime>;

                    return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
                };
                bool vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_()
                {
                    DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = AUASIAssessment?.Effective;
                    object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                    bool wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ is CqlDateTime;

                    return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
                };
                if (vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_())
                {
                    DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = AUASIAssessment?.Effective;
                    object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                    return (wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlDateTime) as object;
                }
                else if (vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_())
                {
                    DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = AUASIAssessment?.Effective;
                    object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                    return (wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_())
                {
                    DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = AUASIAssessment?.Effective;
                    object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                    return (wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_());
            DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = AUASIAssessment?.Value;
            object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlCode vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_(context);
            IEnumerable<CqlCode> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ToList<CqlCode>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Observation QOLAssessment)
            {
                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_()
                {
                    bool wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_()
                    {
                        DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QOLAssessment?.Effective;
                        object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                        bool xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ is CqlDateTime;

                        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
                    };
                    bool wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_()
                    {
                        DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QOLAssessment?.Effective;
                        object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                        bool xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ is CqlInterval<CqlDateTime>;

                        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
                    };
                    bool wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_()
                    {
                        DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QOLAssessment?.Effective;
                        object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                        bool xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ is CqlDateTime;

                        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
                    };
                    if (wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_())
                    {
                        DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QOLAssessment?.Effective;
                        object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                        return (xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as CqlDateTime) as object;
                    }
                    else if (wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_())
                    {
                        DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QOLAssessment?.Effective;
                        object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                        return (xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_())
                    {
                        DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QOLAssessment?.Effective;
                        object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                        return (xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_());
                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_()
                {
                    bool xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_()
                    {
                        DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = AUASIAssessment?.Effective;
                        object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                        bool xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ is CqlDateTime;

                        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
                    };
                    bool xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_()
                    {
                        DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = AUASIAssessment?.Effective;
                        object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                        bool xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is CqlInterval<CqlDateTime>;

                        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
                    };
                    bool xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_()
                    {
                        DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = AUASIAssessment?.Effective;
                        object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                        bool yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ is CqlDateTime;

                        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
                    };
                    if (xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_())
                    {
                        DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = AUASIAssessment?.Effective;
                        object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                        return (yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlDateTime) as object;
                    }
                    else if (xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_())
                    {
                        DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = AUASIAssessment?.Effective;
                        object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                        return (yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_())
                    {
                        DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = AUASIAssessment?.Effective;
                        object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                        return (yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_());
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SameAs(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, "day");
                Code<ObservationStatus> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QOLAssessment?.StatusElement;
                ObservationStatus? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
                Code<ObservationStatus> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<Code<ObservationStatus>>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                string wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                string[] wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<string>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as IEnumerable<string>);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QOLAssessment?.Value;
                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is null));
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation @this)
            {
                object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_()
                {
                    bool yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_()
                    {
                        DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                        object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                        bool yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ is CqlDateTime;

                        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
                    };
                    bool yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_()
                    {
                        DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = @this?.Effective;
                        object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                        bool yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ is CqlInterval<CqlDateTime>;

                        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
                    };
                    bool yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_()
                    {
                        DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = @this?.Effective;
                        object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                        bool yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ is CqlDateTime;

                        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
                    };
                    if (yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_())
                    {
                        DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = @this?.Effective;
                        object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                        return (yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlDateTime) as object;
                    }
                    else if (yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_())
                    {
                        DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                        object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                        return (yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_())
                    {
                        DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                        object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                        return (zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_());

                return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SortBy<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
            Observation vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Last<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
            object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            int? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Add(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as int?, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as int?);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = (CqlTupleMetadata_GNNDVIQPcTANSdLebhBKYIdga, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Urinary Symptom Score Assessment")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> Urinary_Symptom_Score_Assessment(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Documented_IPSS_Assessment_Result(context);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result(context);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Urinary Symptom Score Within 1 Month after Initial BPH Diagnosis")]
    public (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Urinary_Symptom_Score_Assessment(context);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? USSAssessment)
        {
            Condition zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
            Condition[] zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = [
                zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_,
            ];
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Condition InitialBPHDiagnosis)
            {
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = USSAssessment?.effectiveDatetime;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(1m, "month");
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Add(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, true, true);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "day");
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ is null));
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Condition>((IEnumerable<Condition>)zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Condition InitialBPHDiagnosis) =>
                USSAssessment;
            IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Condition, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SelectMany<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? @this)
        {
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.effectiveDatetime;

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.First<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Urinary Symptom Score 6 to 12 Months After Initial BPH Diagnosis")]
    public (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Urinary_Symptom_Score_Assessment(context);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? USSAssessment)
        {
            Condition azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
            Condition[] azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = [
                azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_,
            ];
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Condition InitialBPHDiagnosis)
            {
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = USSAssessment?.effectiveDatetime;
                int? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DurationBetween(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "month");
                CqlInterval<int?> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Interval(6, 12, true, true);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<int?>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default);

                return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Condition>((IEnumerable<Condition>)azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Condition InitialBPHDiagnosis) =>
                USSAssessment;
            IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Condition, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SelectMany<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? @this)
        {
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.effectiveDatetime;

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Last<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Patient_is_Male(context);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Has_Qualifying_Encounter(context);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Has_Qualifying_BPH_Diagnosis(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ is null));
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ is null));
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Initial_Population(context);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "Urinary Retention Diagnosis Starts Within 1 Year After Initial BPH Diagnosis")]
    public IEnumerable<Condition> Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Urinary_retention(context);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Condition UrinaryRetention)
        {
            Condition bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
            Condition[] bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = [
                bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_,
            ];
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Condition InitialBPHDiagnosis)
            {
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, UrinaryRetention);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlQuantity czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(1m, "year");
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Add(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Interval(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, true, true);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "day");
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is null));
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Condition>((IEnumerable<Condition>)bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            Condition bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Condition InitialBPHDiagnosis) =>
                UrinaryRetention;
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Condition, Condition>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SelectMany<Condition, Condition>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Condition UrinaryRetention)
        {
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.isConfirmedActiveDiagnosis(context, UrinaryRetention);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Condition>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Initial BPH Diagnosis Starts During or Within 30 Days After End of Hospitalization")]
    public Condition Has_Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization(CqlContext context)
    {
        Condition czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
        Condition[] czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = [
            czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_,
        ];
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Condition InitialBPHDiagnosis)
        {
            CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Hospital_Services_for_Urology(context);
            IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Encounter InHospitalServices)
            {
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                Period czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = InHospitalServices?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.End(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlQuantity dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(31m, "days");
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Add(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, true, true);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default);
                Code<Encounter.EncounterStatus> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = InHospitalServices?.StatusElement;
                Encounter.EncounterStatus? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
                Code<Encounter.EncounterStatus> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Equal(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "finished");
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            Condition czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Encounter InHospitalServices) =>
                InitialBPHDiagnosis;
            IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Encounter, Condition>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SelectMany<Condition, Condition>((IEnumerable<Condition>)czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        Condition czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SingletonFrom<Condition>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Morbid Obesity Diagnosis On or Before Follow Up USS Assessment")]
    public IEnumerable<Condition> Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Morbid_Obesity(context);
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Condition MorbidObesity)
        {
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(context);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?[] dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = [
                dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_,
            ];
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)
            {
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MorbidObesity);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Overlaps(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FollowUpUSSAssessment?.effectiveDatetime;
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SameOrBefore(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>((IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>)dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            Condition dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment) =>
                MorbidObesity;
            IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, Condition>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SelectMany<Condition, Condition>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Condition MorbidObesity)
        {
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.isConfirmedActiveDiagnosis(context, MorbidObesity);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Condition>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "BMI Exam Result Greater Than or Equal To 40 During Measurement Period and On or Before Follow Up USS Assessment")]
    [CqlTag("code", "Body mass index (BMI) [Ratio] - 39156-5")]
    [CqlTag("profile", "http://hl7.org/fhir/StructureDefinition/bmi")]
    public bool? BMI_Exam_Result_Greater_Than_or_Equal_To_40_During_Measurement_Period_and_On_or_Before_Follow_Up_USS_Assessment(CqlContext context)
    {
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bmi"));
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation BMIExam)
        {
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(context);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?[] ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = [
                ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_,
            ];
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)
            {
                DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = BMIExam?.Value;
                CqlQuantity ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as Quantity);
                CqlQuantity ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(40m, "kg/m2");
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.GreaterOrEqual(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                Code<ObservationStatus> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = BMIExam?.StatusElement;
                ObservationStatus? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
                string fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<string>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                string[] fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<string>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as IEnumerable<string>);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = BMIExam?.Effective;
                object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "day");
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FollowUpUSSAssessment?.effectiveDatetime;
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SameOrBefore(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>((IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>)ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            Observation ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment) =>
                BMIExam;
            IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<Observation, Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation BMIExam)
        {
            DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = BMIExam?.Effective;
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Observation, CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Distinct<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Morbid Obesity Diagnosis or BMI Exam Result Greater Than or Equal to 40 Starts On or Before Follow Up USS Assessment")]
    public bool? Morbid_Obesity_Diagnosis_or_BMI_Exam_Result_Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment(CqlContext context)
    {
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.BMI_Exam_Result_Greater_Than_or_Equal_To_40_During_Measurement_Period_and_On_or_Before_Follow_Up_USS_Assessment(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        Condition fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Has_Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ is null));
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Morbid_Obesity_Diagnosis_or_BMI_Exam_Result_Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Or(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Urinary Symptom Score Change")]
    public int? Urinary_Symptom_Score_Change(CqlContext context)
    {
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis(context);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?[] gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = [
            gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_,
        ];
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(context);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?[] gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = [
            gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_,
        ];
        IEnumerable<ValueTuple<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.CrossJoin<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>((IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>)gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, (IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>)gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        (CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(ValueTuple<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> _valueTuple)
        {
            (CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = (CqlTupleMetadata_FBHNjYWJgMKheadEZUgcdQGXN, _valueTuple.Item1, _valueTuple.Item2);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)?> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<ValueTuple<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>, (CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)?>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        int? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_((CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)? tuple_fbhnjywjgmkheadezugcdqgxn)
        {
            int? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = tuple_fbhnjywjgmkheadezugcdqgxn?.FirstUSSAssessment?.valueInteger;
            int? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = tuple_fbhnjywjgmkheadezugcdqgxn?.FollowUpUSSAssessment?.valueInteger;
            int? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Subtract(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<int?> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)?, int?>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<int?> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Distinct<int?>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        int? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SingletonFrom<int?>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Urinary Symptom Score Improvement Greater Than or Equal To 3")]
    public bool? Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3(CqlContext context)
    {
        int? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Urinary_Symptom_Score_Change(context);
        int?[] gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = [
            gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_,
        ];
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(int? USSImprovement)
        {
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.GreaterOrEqual(USSImprovement, 3);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<int?> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<int?>((IEnumerable<int?>)gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        int? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SingletonFrom<int?>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is null));

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3(context);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
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
