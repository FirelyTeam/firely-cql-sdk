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
        CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, true, true);
        object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.ResolveParameter("UrinarySymptomScoreChangeAfterBenignProstaticHyperplasiaFHIR-1.4.000", "Measurement Period", ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return (CqlInterval<CqlDateTime>)ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SingletonFrom<Patient>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Patient is Male")]
    public bool? Patient_is_Male(CqlContext context)
    {
        Patient ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Patient(context);
        Code<AdministrativeGender> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.GenderElement;
        AdministrativeGender? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
        string ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<string>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Equal(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, "male");

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Has Qualifying Encounter")]
    public bool? Has_Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Office_Visit(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
            Period ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, "day");
            Coding ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = ValidEncounter?.Class;
            CqlCode ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToCode(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlCode ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.@virtual(context);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Equivalent(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            Code<Encounter.EncounterStatus> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
            Code<Encounter.EncounterStatus> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Equal(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "finished");
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("isConfirmedActiveDiagnosis")]
    public bool? isConfirmedActiveDiagnosis(CqlContext context, Condition condition)
    {
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.isActive(context, condition);
        CodeableConcept fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = condition?.VerificationStatus;
        CqlConcept fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        CqlCode fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.confirmed(context);
        CqlConcept fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConvertCodeToConcept(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Equivalent(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Initial BPH Diagnosis Starts Within 6 Months Before the Measurement Period")]
    public Condition Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(CqlContext context)
    {
        CqlCode fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms(context);
        IEnumerable<CqlCode> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ToList<CqlCode>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Condition NewBPHDiagnosis)
        {
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, NewBPHDiagnosis);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(6m, "months");
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Subtract(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, true, true);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.isConfirmedActiveDiagnosis(context, NewBPHDiagnosis);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Condition @this)
        {
            DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Onset;
            object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SortBy<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
        Condition fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.First<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Has Qualifying BPH Diagnosis")]
    public bool? Has_Qualifying_BPH_Diagnosis(CqlContext context)
    {
        Condition gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ is null));

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Documented IPSS Assessment Result")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> Documented_IPSS_Assessment_Result(CqlContext context)
    {
        CqlCode gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.International_Prostate_Symptom_Score__IPSS_(context);
        IEnumerable<CqlCode> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ToList<CqlCode>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Observation IPSSAssessment)
        {
            Code<ObservationStatus> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = IPSSAssessment?.StatusElement;
            ObservationStatus? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
            Code<ObservationStatus> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<Code<ObservationStatus>>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            string hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<string>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            string[] hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<string>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as IEnumerable<string>);
            DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = IPSSAssessment?.Value;
            object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ is null));
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Observation IPSSAssessment)
        {
            object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_()
            {
                bool hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_()
                {
                    DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = IPSSAssessment?.Effective;
                    object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                    bool hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ is CqlDateTime;

                    return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
                };
                bool hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_()
                {
                    DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = IPSSAssessment?.Effective;
                    object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                    bool hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ is CqlInterval<CqlDateTime>;

                    return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
                };
                bool hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_()
                {
                    DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = IPSSAssessment?.Effective;
                    object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                    bool hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is CqlDateTime;

                    return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
                };
                if (hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_())
                {
                    DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = IPSSAssessment?.Effective;
                    object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                    return (hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as CqlDateTime) as object;
                }
                else if (hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_())
                {
                    DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = IPSSAssessment?.Effective;
                    object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

                    return (izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_())
                {
                    DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = IPSSAssessment?.Effective;
                    object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

                    return (izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_());
            DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = IPSSAssessment?.Value;
            object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = (CqlTupleMetadata_GNNDVIQPcTANSdLebhBKYIdga, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as int?);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("AUA Symptom Index and Quality of Life Assessment Result")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result(CqlContext context)
    {
        CqlCode izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.American_Urological_Association_Symptom_Index__AUASI_(context);
        IEnumerable<CqlCode> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ToList<CqlCode>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Observation AUASIAssessment)
        {
            Code<ObservationStatus> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = AUASIAssessment?.StatusElement;
            ObservationStatus? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
            Code<ObservationStatus> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<Code<ObservationStatus>>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            string izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            string[] izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<string>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as IEnumerable<string>);
            DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = AUASIAssessment?.Value;
            object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ is null));
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Observation AUASIAssessment)
        {
            object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_()
            {
                bool jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_()
                {
                    DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = AUASIAssessment?.Effective;
                    object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                    bool jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ is CqlDateTime;

                    return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
                };
                bool jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_()
                {
                    DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = AUASIAssessment?.Effective;
                    object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                    bool jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ is CqlInterval<CqlDateTime>;

                    return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
                };
                bool jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_()
                {
                    DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = AUASIAssessment?.Effective;
                    object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                    bool jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is CqlDateTime;

                    return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
                };
                if (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_())
                {
                    DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = AUASIAssessment?.Effective;
                    object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                    return (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as CqlDateTime) as object;
                }
                else if (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_())
                {
                    DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = AUASIAssessment?.Effective;
                    object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

                    return (kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_())
                {
                    DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = AUASIAssessment?.Effective;
                    object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

                    return (kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_());
            DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = AUASIAssessment?.Value;
            object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlCode jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_(context);
            IEnumerable<CqlCode> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ToList<CqlCode>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Observation QOLAssessment)
            {
                object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_()
                {
                    bool kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_()
                    {
                        DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QOLAssessment?.Effective;
                        object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                        bool kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ is CqlDateTime;

                        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
                    };
                    bool kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_()
                    {
                        DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QOLAssessment?.Effective;
                        object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                        bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ is CqlInterval<CqlDateTime>;

                        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
                    };
                    bool kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_()
                    {
                        DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QOLAssessment?.Effective;
                        object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                        bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ is CqlDateTime;

                        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
                    };
                    if (kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_())
                    {
                        DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QOLAssessment?.Effective;
                        object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                        return (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as CqlDateTime) as object;
                    }
                    else if (kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_())
                    {
                        DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QOLAssessment?.Effective;
                        object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                        return (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_())
                    {
                        DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QOLAssessment?.Effective;
                        object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                        return (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_());
                object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_()
                {
                    bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_()
                    {
                        DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = AUASIAssessment?.Effective;
                        object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                        bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ is CqlDateTime;

                        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
                    };
                    bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_()
                    {
                        DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = AUASIAssessment?.Effective;
                        object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                        bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ is CqlInterval<CqlDateTime>;

                        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
                    };
                    bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_()
                    {
                        DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = AUASIAssessment?.Effective;
                        object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                        bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is CqlDateTime;

                        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
                    };
                    if (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_())
                    {
                        DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = AUASIAssessment?.Effective;
                        object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                        return (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as CqlDateTime) as object;
                    }
                    else if (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_())
                    {
                        DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = AUASIAssessment?.Effective;
                        object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

                        return (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_())
                    {
                        DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = AUASIAssessment?.Effective;
                        object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

                        return (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_());
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SameAs(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "day");
                Code<ObservationStatus> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QOLAssessment?.StatusElement;
                ObservationStatus? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
                Code<ObservationStatus> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<Code<ObservationStatus>>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                string kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                string[] kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<string>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as IEnumerable<string>);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QOLAssessment?.Value;
                object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ is null));
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Observation @this)
            {
                object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_()
                {
                    bool mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_()
                    {
                        DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Effective;
                        object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                        bool mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ is CqlDateTime;

                        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
                    };
                    bool mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_()
                    {
                        DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                        object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                        bool mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ is CqlInterval<CqlDateTime>;

                        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
                    };
                    bool mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_()
                    {
                        DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = @this?.Effective;
                        object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                        bool mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ is CqlDateTime;

                        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
                    };
                    if (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_())
                    {
                        DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = @this?.Effective;
                        object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                        return (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlDateTime) as object;
                    }
                    else if (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_())
                    {
                        DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = @this?.Effective;
                        object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                        return (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_())
                    {
                        DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                        object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                        return (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_());

                return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SortBy<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
            Observation jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Last<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
            object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            int? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Add(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as int?, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as int?);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = (CqlTupleMetadata_GNNDVIQPcTANSdLebhBKYIdga, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Urinary Symptom Score Assessment")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> Urinary_Symptom_Score_Assessment(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Documented_IPSS_Assessment_Result(context);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result(context);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Urinary Symptom Score Within 1 Month after Initial BPH Diagnosis")]
    public (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Urinary_Symptom_Score_Assessment(context);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? USSAssessment)
        {
            Condition nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
            Condition[] nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = [
                nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_,
            ];
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Condition InitialBPHDiagnosis)
            {
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = USSAssessment?.effectiveDatetime;
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(1m, "month");
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Add(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, true, true);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "day");
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is null));
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Condition>((IEnumerable<Condition>)nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Condition InitialBPHDiagnosis) =>
                USSAssessment;
            IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<Condition, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SelectMany<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? @this)
        {
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = @this?.effectiveDatetime;

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.First<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Urinary Symptom Score 6 to 12 Months After Initial BPH Diagnosis")]
    public (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Urinary_Symptom_Score_Assessment(context);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? USSAssessment)
        {
            Condition ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
            Condition[] ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = [
                ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_,
            ];
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Condition InitialBPHDiagnosis)
            {
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = USSAssessment?.effectiveDatetime;
                int? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DurationBetween(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "month");
                CqlInterval<int?> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(6, 12, true, true);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<int?>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default);

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Condition>((IEnumerable<Condition>)ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Condition InitialBPHDiagnosis) =>
                USSAssessment;
            IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<Condition, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SelectMany<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? @this)
        {
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.effectiveDatetime;

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Last<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Patient_is_Male(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Has_Qualifying_Encounter(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Has_Qualifying_BPH_Diagnosis(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis(context);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ is null));
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(context);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ is null));
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Initial_Population(context);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Urinary Retention Diagnosis Starts Within 1 Year After Initial BPH Diagnosis")]
    public IEnumerable<Condition> Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Urinary_retention(context);
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Condition UrinaryRetention)
        {
            Condition pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
            Condition[] pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = [
                pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_,
            ];
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Condition InitialBPHDiagnosis)
            {
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, UrinaryRetention);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlQuantity pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(1m, "year");
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Add(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, true, true);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "day");
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is null));
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Condition>((IEnumerable<Condition>)pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            Condition pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Condition InitialBPHDiagnosis) =>
                UrinaryRetention;
            IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Condition, Condition>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<Condition, Condition>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Condition UrinaryRetention)
        {
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.isConfirmedActiveDiagnosis(context, UrinaryRetention);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Condition>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Has Initial BPH Diagnosis Starts During or Within 30 Days After End of Hospitalization")]
    public Condition Has_Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization(CqlContext context)
    {
        Condition qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
        Condition[] qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = [
            qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_,
        ];
        IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Condition InitialBPHDiagnosis)
        {
            CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Hospital_Services_for_Urology(context);
            IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Encounter InHospitalServices)
            {
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                Period qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = InHospitalServices?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.End(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlQuantity rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(31m, "days");
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Add(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, true, true);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default);
                Code<Encounter.EncounterStatus> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = InHospitalServices?.StatusElement;
                Encounter.EncounterStatus? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
                Code<Encounter.EncounterStatus> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equal(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, "finished");
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            Condition qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Encounter InHospitalServices) =>
                InitialBPHDiagnosis;
            IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Encounter, Condition>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SelectMany<Condition, Condition>((IEnumerable<Condition>)qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        Condition qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SingletonFrom<Condition>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Morbid Obesity Diagnosis On or Before Follow Up USS Assessment")]
    public IEnumerable<Condition> Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Morbid_Obesity(context);
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Condition MorbidObesity)
        {
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(context);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?[] rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = [
                rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_,
            ];
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)
            {
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MorbidObesity);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Overlaps(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FollowUpUSSAssessment?.effectiveDatetime;
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SameOrBefore(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>((IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>)rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            Condition rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment) =>
                MorbidObesity;
            IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, Condition>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SelectMany<Condition, Condition>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Condition MorbidObesity)
        {
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.isConfirmedActiveDiagnosis(context, MorbidObesity);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Condition>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("BMI Exam Result Greater Than or Equal To 40 During Measurement Period and On or Before Follow Up USS Assessment")]
    [CqlTag("code", "Body mass index (BMI) [Ratio] - 39156-5")]
    [CqlTag("profile", "http://hl7.org/fhir/StructureDefinition/bmi")]
    public bool? BMI_Exam_Result_Greater_Than_or_Equal_To_40_During_Measurement_Period_and_On_or_Before_Follow_Up_USS_Assessment(CqlContext context)
    {
        IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bmi"));
        IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Observation BMIExam)
        {
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(context);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?[] szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = [
                szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_,
            ];
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)
            {
                DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = BMIExam?.Value;
                CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as Quantity);
                CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(40m, "kg/m2");
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.GreaterOrEqual(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                Code<ObservationStatus> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = BMIExam?.StatusElement;
                ObservationStatus? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
                string szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                string[] szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<string>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as IEnumerable<string>);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = BMIExam?.Effective;
                object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, "day");
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FollowUpUSSAssessment?.effectiveDatetime;
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SameOrBefore(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>((IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>)szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            Observation szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment) =>
                BMIExam;
            IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, Observation>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SelectMany<Observation, Observation>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Observation BMIExam)
        {
            DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = BMIExam?.Effective;
            object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<Observation, CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Distinct<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Morbid Obesity Diagnosis or BMI Exam Result Greater Than or Equal to 40 Starts On or Before Follow Up USS Assessment")]
    public bool? Morbid_Obesity_Diagnosis_or_BMI_Exam_Result_Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment(CqlContext context)
    {
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment(context);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.BMI_Exam_Result_Greater_Than_or_Equal_To_40_During_Measurement_Period_and_On_or_Before_Follow_Up_USS_Assessment(context);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Or(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis(context);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        Condition tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Has_Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization(context);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is null));
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Or(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Morbid_Obesity_Diagnosis_or_BMI_Exam_Result_Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Or(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Urinary Symptom Score Change")]
    public int? Urinary_Symptom_Score_Change(CqlContext context)
    {
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis(context);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?[] uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = [
            uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_,
        ];
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(context);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?[] uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = [
            uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_,
        ];
        IEnumerable<ValueTuple<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.CrossJoin<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>((IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>)uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, (IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>)uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        (CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(ValueTuple<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> _valueTuple)
        {
            (CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = (CqlTupleMetadata_FBHNjYWJgMKheadEZUgcdQGXN, _valueTuple.Item1, _valueTuple.Item2);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)?> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<ValueTuple<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>, (CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)?>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        int? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_((CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)? tuple_fbhnjywjgmkheadezugcdqgxn)
        {
            int? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = tuple_fbhnjywjgmkheadezugcdqgxn?.FirstUSSAssessment?.valueInteger;
            int? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = tuple_fbhnjywjgmkheadezugcdqgxn?.FollowUpUSSAssessment?.valueInteger;
            int? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Subtract(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<int?> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)?, int?>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<int?> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<int?>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        int? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SingletonFrom<int?>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Urinary Symptom Score Improvement Greater Than or Equal To 3")]
    public bool? Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3(CqlContext context)
    {
        int? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Urinary_Symptom_Score_Change(context);
        int?[] uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = [
            uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_,
        ];
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(int? USSImprovement)
        {
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.GreaterOrEqual(USSImprovement, 3);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<int?> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<int?>((IEnumerable<int?>)uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        int? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SingletonFrom<int?>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is null));

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3(context);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
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
