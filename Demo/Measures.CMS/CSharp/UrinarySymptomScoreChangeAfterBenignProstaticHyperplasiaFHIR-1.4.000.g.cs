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
    private static readonly CqlCode _American_Urological_Association_Symptom_Index__AUASI_ = new CqlCode("80883-2", "http://loinc.org");

    [CqlCodeDefinition("Benign prostatic hyperplasia with lower urinary tract symptoms", codeId: "N40.1", codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms(CqlContext _) => _Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms;
    private static readonly CqlCode _Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms = new CqlCode("N40.1", "http://hl7.org/fhir/sid/icd-10-cm");

    [CqlCodeDefinition("If you were to spend the rest of your life with your urinary condition just the way it is now, how would you feel about that [IPSS]", codeId: "81090-3", codeSystem: "http://loinc.org")]
    public CqlCode If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_(CqlContext _) => _If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_;
    private static readonly CqlCode _If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_ = new CqlCode("81090-3", "http://loinc.org");

    [CqlCodeDefinition("International Prostate Symptom Score [IPSS]", codeId: "80976-4", codeSystem: "http://loinc.org")]
    public CqlCode International_Prostate_Symptom_Score__IPSS_(CqlContext _) => _International_Prostate_Symptom_Score__IPSS_;
    private static readonly CqlCode _International_Prostate_Symptom_Score__IPSS_ = new CqlCode("80976-4", "http://loinc.org");

    [CqlCodeDefinition("virtual", codeId: "VR", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode @virtual(CqlContext _) => _virtual;
    private static readonly CqlCode _virtual = new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null,
          _American_Urological_Association_Symptom_Index__AUASI_,
          _If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_,
          _International_Prostate_Symptom_Score__IPSS_);

    [CqlCodeSystemDefinition("ICD10CM")]
    public CqlCodeSystem ICD10CM(CqlContext _) => _ICD10CM;
    private static readonly CqlCodeSystem _ICD10CM =
      new CqlCodeSystem("http://hl7.org/fhir/sid/icd-10-cm", null,
          _Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms);

    [CqlCodeSystemDefinition("ObservationCategoryCodes")]
    public CqlCodeSystem ObservationCategoryCodes(CqlContext _) => _ObservationCategoryCodes;
    private static readonly CqlCodeSystem _ObservationCategoryCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/observation-category", null);

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
        CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, true, true);
        object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.ResolveParameter("UrinarySymptomScoreChangeAfterBenignProstaticHyperplasiaFHIR-1.4.000", "Measurement Period", izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return (CqlInterval<CqlDateTime>)izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SingletonFrom<Patient>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Patient is Male")]
    public bool? Patient_is_Male(CqlContext context)
    {
        Patient izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Patient(context);
        Code<AdministrativeGender> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.GenderElement;
        AdministrativeGender? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
        string izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Equal(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, "male");

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Has Qualifying Encounter")]
    public bool? Has_Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Office_Visit(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
            Period jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, "day");
            Coding jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = ValidEncounter?.Class;
            CqlCode jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToCode(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlCode jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.@virtual(context);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equivalent(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Not(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            Code<Encounter.EncounterStatus> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
            Code<Encounter.EncounterStatus> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Equal(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, "finished");
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("isConfirmedActiveDiagnosis")]
    public bool? isConfirmedActiveDiagnosis(CqlContext context, Condition condition)
    {
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.isActive(context, condition);
        CodeableConcept jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = condition?.VerificationStatus;
        CqlConcept jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlCode jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.confirmed(context);
        CqlConcept jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertCodeToConcept(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Equivalent(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Initial BPH Diagnosis Starts Within 6 Months Before the Measurement Period")]
    public Condition Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(CqlContext context)
    {
        CqlCode jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms(context);
        IEnumerable<CqlCode> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ToList<CqlCode>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Condition> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Condition NewBPHDiagnosis)
        {
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, NewBPHDiagnosis);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlQuantity kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(6m, "months");
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Subtract(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, true, true);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.isConfirmedActiveDiagnosis(context, NewBPHDiagnosis);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Condition> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Condition>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Condition @this)
        {
            DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = @this?.Onset;
            object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Condition> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SortBy<Condition>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
        Condition kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.First<Condition>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Has Qualifying BPH Diagnosis")]
    public bool? Has_Qualifying_BPH_Diagnosis(CqlContext context)
    {
        Condition kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is null));

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Documented IPSS Assessment Result")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> Documented_IPSS_Assessment_Result(CqlContext context)
    {
        CqlCode kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.International_Prostate_Symptom_Score__IPSS_(context);
        IEnumerable<CqlCode> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ToList<CqlCode>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Observation IPSSAssessment)
        {
            Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = IPSSAssessment?.StatusElement;
            ObservationStatus? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
            Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<Code<ObservationStatus>>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            string lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            string[] lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<string>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as IEnumerable<string>);
            DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = IPSSAssessment?.Value;
            object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ is null));
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Observation IPSSAssessment)
        {
            object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_()
            {
                bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_()
                {
                    DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = IPSSAssessment?.Effective;
                    object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                    bool mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ is CqlDateTime;

                    return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
                };
                bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_()
                {
                    DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = IPSSAssessment?.Effective;
                    object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                    bool mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ is CqlInterval<CqlDateTime>;

                    return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
                };
                bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_()
                {
                    DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = IPSSAssessment?.Effective;
                    object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                    bool mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ is CqlDateTime;

                    return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
                };
                if (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_())
                {
                    DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = IPSSAssessment?.Effective;
                    object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                    return (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlDateTime) as object;
                }
                else if (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_())
                {
                    DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = IPSSAssessment?.Effective;
                    object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                    return (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_())
                {
                    DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = IPSSAssessment?.Effective;
                    object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                    return (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_());
            DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = IPSSAssessment?.Value;
            object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = (CqlTupleMetadata_GNNDVIQPcTANSdLebhBKYIdga, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as int?);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("AUA Symptom Index and Quality of Life Assessment Result")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result(CqlContext context)
    {
        CqlCode mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.American_Urological_Association_Symptom_Index__AUASI_(context);
        IEnumerable<CqlCode> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ToList<CqlCode>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Observation AUASIAssessment)
        {
            Code<ObservationStatus> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = AUASIAssessment?.StatusElement;
            ObservationStatus? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
            Code<ObservationStatus> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<Code<ObservationStatus>>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            string mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            string[] mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<string>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as IEnumerable<string>);
            DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = AUASIAssessment?.Value;
            object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ is null));
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Observation AUASIAssessment)
        {
            object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_()
            {
                bool nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_()
                {
                    DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = AUASIAssessment?.Effective;
                    object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                    bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ is CqlDateTime;

                    return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
                };
                bool nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_()
                {
                    DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = AUASIAssessment?.Effective;
                    object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                    bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ is CqlInterval<CqlDateTime>;

                    return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
                };
                bool nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_()
                {
                    DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = AUASIAssessment?.Effective;
                    object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                    bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ is CqlDateTime;

                    return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
                };
                if (nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_())
                {
                    DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = AUASIAssessment?.Effective;
                    object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                    return (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlDateTime) as object;
                }
                else if (nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_())
                {
                    DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = AUASIAssessment?.Effective;
                    object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                    return (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_())
                {
                    DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = AUASIAssessment?.Effective;
                    object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                    return (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_());
            DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = AUASIAssessment?.Value;
            object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlCode nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_(context);
            IEnumerable<CqlCode> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ToList<CqlCode>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Observation QOLAssessment)
            {
                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_()
                {
                    bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_()
                    {
                        DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QOLAssessment?.Effective;
                        object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                        bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ is CqlDateTime;

                        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
                    };
                    bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_()
                    {
                        DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QOLAssessment?.Effective;
                        object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                        bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ is CqlInterval<CqlDateTime>;

                        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
                    };
                    bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_()
                    {
                        DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QOLAssessment?.Effective;
                        object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                        bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ is CqlDateTime;

                        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
                    };
                    if (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_())
                    {
                        DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QOLAssessment?.Effective;
                        object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                        return (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlDateTime) as object;
                    }
                    else if (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_())
                    {
                        DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QOLAssessment?.Effective;
                        object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

                        return (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_())
                    {
                        DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QOLAssessment?.Effective;
                        object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                        return (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_());
                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_()
                {
                    bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_()
                    {
                        DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = AUASIAssessment?.Effective;
                        object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                        bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ is CqlDateTime;

                        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
                    };
                    bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_()
                    {
                        DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = AUASIAssessment?.Effective;
                        object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                        bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ is CqlInterval<CqlDateTime>;

                        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
                    };
                    bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_()
                    {
                        DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = AUASIAssessment?.Effective;
                        object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                        bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ is CqlDateTime;

                        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
                    };
                    if (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_())
                    {
                        DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = AUASIAssessment?.Effective;
                        object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                        return (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlDateTime) as object;
                    }
                    else if (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_())
                    {
                        DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = AUASIAssessment?.Effective;
                        object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                        return (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_())
                    {
                        DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = AUASIAssessment?.Effective;
                        object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                        return (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_());
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SameAs(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, "day");
                Code<ObservationStatus> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QOLAssessment?.StatusElement;
                ObservationStatus? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
                Code<ObservationStatus> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<Code<ObservationStatus>>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                string ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                string[] ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<string>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as IEnumerable<string>);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QOLAssessment?.Value;
                object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ is null));
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Observation @this)
            {
                object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_()
                {
                    bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_()
                    {
                        DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = @this?.Effective;
                        object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                        bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ is CqlDateTime;

                        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
                    };
                    bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_()
                    {
                        DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = @this?.Effective;
                        object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                        bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is CqlInterval<CqlDateTime>;

                        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
                    };
                    bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_()
                    {
                        DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = @this?.Effective;
                        object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                        bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ is CqlDateTime;

                        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
                    };
                    if (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_())
                    {
                        DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.Effective;
                        object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                        return (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlDateTime) as object;
                    }
                    else if (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_())
                    {
                        DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Effective;
                        object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                        return (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_())
                    {
                        DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                        object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                        return (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_());

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SortBy<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, System.ComponentModel.ListSortDirection.Ascending);
            Observation nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Last<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
            object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            int? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Add(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as int?, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as int?);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = (CqlTupleMetadata_GNNDVIQPcTANSdLebhBKYIdga, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Urinary Symptom Score Assessment")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> Urinary_Symptom_Score_Assessment(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Documented_IPSS_Assessment_Result(context);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result(context);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Urinary Symptom Score Within 1 Month after Initial BPH Diagnosis")]
    public (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Urinary_Symptom_Score_Assessment(context);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? USSAssessment)
        {
            Condition rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
            Condition[] rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = [
                rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_,
            ];
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Condition InitialBPHDiagnosis)
            {
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = USSAssessment?.effectiveDatetime;
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(1m, "month");
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Add(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, true, true);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "day");
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is null));
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Condition>((IEnumerable<Condition>)rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Condition InitialBPHDiagnosis) =>
                USSAssessment;
            IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Condition, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SelectMany<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? @this)
        {
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.effectiveDatetime;

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.First<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Urinary Symptom Score 6 to 12 Months After Initial BPH Diagnosis")]
    public (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Urinary_Symptom_Score_Assessment(context);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? USSAssessment)
        {
            Condition szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
            Condition[] szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = [
                szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_,
            ];
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Condition InitialBPHDiagnosis)
            {
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = USSAssessment?.effectiveDatetime;
                int? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DurationBetween(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "month");
                CqlInterval<int?> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(6, 12, true, true);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<int?>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default);

                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Condition>((IEnumerable<Condition>)szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Condition InitialBPHDiagnosis) =>
                USSAssessment;
            IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Condition, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SelectMany<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? @this)
        {
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.effectiveDatetime;

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Last<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Patient_is_Male(context);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Has_Qualifying_Encounter(context);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Has_Qualifying_BPH_Diagnosis(context);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis(context);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ is null));
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(context);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ is null));
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Initial_Population(context);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Urinary Retention Diagnosis Starts Within 1 Year After Initial BPH Diagnosis")]
    public IEnumerable<Condition> Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Urinary_retention(context);
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Condition UrinaryRetention)
        {
            Condition tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
            Condition[] tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = [
                tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_,
            ];
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Condition InitialBPHDiagnosis)
            {
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, UrinaryRetention);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlQuantity uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(1m, "year");
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Add(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, true, true);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "day");
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ is null));
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Condition>((IEnumerable<Condition>)tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            Condition tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Condition InitialBPHDiagnosis) =>
                UrinaryRetention;
            IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Condition, Condition>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SelectMany<Condition, Condition>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Condition UrinaryRetention)
        {
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.isConfirmedActiveDiagnosis(context, UrinaryRetention);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Has Initial BPH Diagnosis Starts During or Within 30 Days After End of Hospitalization")]
    public Condition Has_Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization(CqlContext context)
    {
        Condition uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
        Condition[] uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = [
            uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_,
        ];
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Condition InitialBPHDiagnosis)
        {
            CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Hospital_Services_for_Urology(context);
            IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Encounter InHospitalServices)
            {
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                Period vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = InHospitalServices?.Period;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.End(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlQuantity vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(31m, "days");
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Add(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, true, true);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default);
                Code<Encounter.EncounterStatus> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = InHospitalServices?.StatusElement;
                Encounter.EncounterStatus? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
                Code<Encounter.EncounterStatus> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Equal(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "finished");
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

                return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            Condition uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Encounter InHospitalServices) =>
                InitialBPHDiagnosis;
            IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Encounter, Condition>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SelectMany<Condition, Condition>((IEnumerable<Condition>)uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        Condition uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SingletonFrom<Condition>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Morbid Obesity Diagnosis On or Before Follow Up USS Assessment")]
    public IEnumerable<Condition> Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Morbid_Obesity(context);
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Condition MorbidObesity)
        {
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(context);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?[] vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = [
                vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_,
            ];
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)
            {
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MorbidObesity);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Overlaps(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FollowUpUSSAssessment?.effectiveDatetime;
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SameOrBefore(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>((IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>)vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            Condition wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment) =>
                MorbidObesity;
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, Condition>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SelectMany<Condition, Condition>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Condition MorbidObesity)
        {
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.isConfirmedActiveDiagnosis(context, MorbidObesity);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Condition>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("BMI Exam Result Greater Than or Equal To 40 During Measurement Period and On or Before Follow Up USS Assessment")]
    [CqlTag("code", "Body mass index (BMI) [Ratio] - 39156-5")]
    [CqlTag("profile", "http://hl7.org/fhir/StructureDefinition/bmi")]
    public bool? BMI_Exam_Result_Greater_Than_or_Equal_To_40_During_Measurement_Period_and_On_or_Before_Follow_Up_USS_Assessment(CqlContext context)
    {
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bmi"));
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Observation BMIExam)
        {
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(context);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?[] wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = [
                wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_,
            ];
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)
            {
                DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = BMIExam?.Value;
                CqlQuantity xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as Quantity);
                CqlQuantity xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(40m, "kg/m2");
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.GreaterOrEqual(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                Code<ObservationStatus> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = BMIExam?.StatusElement;
                ObservationStatus? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
                string xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                string[] xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<string>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as IEnumerable<string>);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = BMIExam?.Effective;
                object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "day");
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FollowUpUSSAssessment?.effectiveDatetime;
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SameOrBefore(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>((IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>)wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            Observation wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment) =>
                BMIExam;
            IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, Observation>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SelectMany<Observation, Observation>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Observation BMIExam)
        {
            DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = BMIExam?.Effective;
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Observation, CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Morbid Obesity Diagnosis or BMI Exam Result Greater Than or Equal to 40 Starts On or Before Follow Up USS Assessment")]
    public bool? Morbid_Obesity_Diagnosis_or_BMI_Exam_Result_Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment(CqlContext context)
    {
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment(context);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Condition>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.BMI_Exam_Result_Greater_Than_or_Equal_To_40_During_Measurement_Period_and_On_or_Before_Follow_Up_USS_Assessment(context);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Or(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis(context);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Condition>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        Condition yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Has_Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization(context);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ is null));
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Morbid_Obesity_Diagnosis_or_BMI_Exam_Result_Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment(context);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Or(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Urinary Symptom Score Change")]
    public int? Urinary_Symptom_Score_Change(CqlContext context)
    {
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis(context);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?[] yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = [
            yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_,
        ];
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(context);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?[] yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = [
            yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_,
        ];
        IEnumerable<ValueTuple<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.CrossJoin<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>((IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>)yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, (IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>)yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        (CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(ValueTuple<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> _valueTuple)
        {
            (CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = (CqlTupleMetadata_FBHNjYWJgMKheadEZUgcdQGXN, _valueTuple.Item1, _valueTuple.Item2);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)?> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<ValueTuple<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>, (CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)?>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        int? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_((CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)? tuple_fbhnjywjgmkheadezugcdqgxn)
        {
            int? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = tuple_fbhnjywjgmkheadezugcdqgxn?.FirstUSSAssessment?.valueInteger;
            int? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = tuple_fbhnjywjgmkheadezugcdqgxn?.FollowUpUSSAssessment?.valueInteger;
            int? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Subtract(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<int?> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)?, int?>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<int?> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<int?>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        int? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SingletonFrom<int?>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Urinary Symptom Score Improvement Greater Than or Equal To 3")]
    public bool? Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3(CqlContext context)
    {
        int? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Urinary_Symptom_Score_Change(context);
        int?[] zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = [
            yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_,
        ];
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(int? USSImprovement)
        {
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.GreaterOrEqual(USSImprovement, 3);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<int?> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<int?>((IEnumerable<int?>)zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        int? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SingletonFrom<int?>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is null));

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3(context);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
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
