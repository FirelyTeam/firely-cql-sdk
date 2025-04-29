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
[CqlLibrary("FunctionalStatusAssessmentforTotalHipReplacementFHIR", "0.0.008")]
public partial class FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008 : ILibrary, ISingleton<FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008>
{
    private FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008() {}

    public static FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "FunctionalStatusAssessmentforTotalHipReplacementFHIR";
    public string Version => "0.0.008";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance, Hospice_6_12_000.Instance, Status_1_8_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Lower Body Fractures Excluding Ankle and Foot", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1178", valueSetVersion: null)]
    public CqlValueSet Lower_Body_Fractures_Excluding_Ankle_and_Foot(CqlContext _) => _Lower_Body_Fractures_Excluding_Ankle_and_Foot;
    private static readonly CqlValueSet _Lower_Body_Fractures_Excluding_Ankle_and_Foot = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1178", null);

    [CqlValueSetDefinition("Malignant Neoplasms of Lower and Unspecified Limbs", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1180", valueSetVersion: null)]
    public CqlValueSet Malignant_Neoplasms_of_Lower_and_Unspecified_Limbs(CqlContext _) => _Malignant_Neoplasms_of_Lower_and_Unspecified_Limbs;
    private static readonly CqlValueSet _Malignant_Neoplasms_of_Lower_and_Unspecified_Limbs = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1180", null);

    [CqlValueSetDefinition("Mechanical Complications Excluding Upper Body", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1182", valueSetVersion: null)]
    public CqlValueSet Mechanical_Complications_Excluding_Upper_Body(CqlContext _) => _Mechanical_Complications_Excluding_Upper_Body;
    private static readonly CqlValueSet _Mechanical_Complications_Excluding_Upper_Body = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1182", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Virtual Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", valueSetVersion: null)]
    public CqlValueSet Virtual_Encounter(CqlContext _) => _Virtual_Encounter;
    private static readonly CqlValueSet _Virtual_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    [CqlValueSetDefinition("Outpatient Consultation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext _) => _Outpatient_Consultation;
    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlValueSetDefinition("Partial Arthroplasty of Hip", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1184", valueSetVersion: null)]
    public CqlValueSet Partial_Arthroplasty_of_Hip(CqlContext _) => _Partial_Arthroplasty_of_Hip;
    private static readonly CqlValueSet _Partial_Arthroplasty_of_Hip = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1184", null);

    [CqlValueSetDefinition("Primary THA Procedure", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1006", valueSetVersion: null)]
    public CqlValueSet Primary_THA_Procedure(CqlContext _) => _Primary_THA_Procedure;
    private static readonly CqlValueSet _Primary_THA_Procedure = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1006", null);

    [CqlValueSetDefinition("Removal, Revision and Supplement Procedures of the Lower Body and Spine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1189", valueSetVersion: null)]
    public CqlValueSet Removal__Revision_and_Supplement_Procedures_of_the_Lower_Body_and_Spine(CqlContext _) => _Removal__Revision_and_Supplement_Procedures_of_the_Lower_Body_and_Spine;
    private static readonly CqlValueSet _Removal__Revision_and_Supplement_Procedures_of_the_Lower_Body_and_Spine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1189", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Activities of daily living score [HOOS]", codeId: "72095-3", codeSystem: "http://loinc.org")]
    public CqlCode Activities_of_daily_living_score__HOOS_(CqlContext _) => _Activities_of_daily_living_score__HOOS_;
    private static readonly CqlCode _Activities_of_daily_living_score__HOOS_ = new CqlCode("72095-3", "http://loinc.org", default, default);

    [CqlCodeDefinition("Dead (finding)", codeId: "419099009", codeSystem: "http://snomed.info/sct")]
    public CqlCode Dead__finding_(CqlContext _) => _Dead__finding_;
    private static readonly CqlCode _Dead__finding_ = new CqlCode("419099009", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Discharge to healthcare facility for hospice care (procedure)", codeId: "428371000124100", codeSystem: "http://snomed.info/sct")]
    public CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure_(CqlContext _) => _Discharge_to_healthcare_facility_for_hospice_care__procedure_;
    private static readonly CqlCode _Discharge_to_healthcare_facility_for_hospice_care__procedure_ = new CqlCode("428371000124100", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Discharge to home for hospice care (procedure)", codeId: "428371000124100", codeSystem: "http://snomed.info/sct")]
    public CqlCode Discharge_to_home_for_hospice_care__procedure_(CqlContext _) => _Discharge_to_home_for_hospice_care__procedure_;
    private static readonly CqlCode _Discharge_to_home_for_hospice_care__procedure_ = new CqlCode("428371000124100", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Hospice care [Minimum Data Set]", codeId: "45755-6", codeSystem: "http://loinc.org")]
    public CqlCode Hospice_care__Minimum_Data_Set_(CqlContext _) => _Hospice_care__Minimum_Data_Set_;
    private static readonly CqlCode _Hospice_care__Minimum_Data_Set_ = new CqlCode("45755-6", "http://loinc.org", default, default);

    [CqlCodeDefinition("Pain score [HOOS]", codeId: "72097-9", codeSystem: "http://loinc.org")]
    public CqlCode Pain_score__HOOS_(CqlContext _) => _Pain_score__HOOS_;
    private static readonly CqlCode _Pain_score__HOOS_ = new CqlCode("72097-9", "http://loinc.org", default, default);

    [CqlCodeDefinition("Postoperative follow-up visit, normally included in the surgical package, to indicate that an evaluation and management service was performed during a postoperative period for a reason(s) related to the original procedure", codeId: "99024", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure(CqlContext _) => _Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure;
    private static readonly CqlCode _Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure = new CqlCode("99024", "http://www.ama-assn.org/go/cpt", default, default);

    [CqlCodeDefinition("PROMIS-10 Global Mental Health (GMH) score T-score", codeId: "71969-0", codeSystem: "http://loinc.org")]
    public CqlCode PROMIS_10_Global_Mental_Health__GMH__score_T_score(CqlContext _) => _PROMIS_10_Global_Mental_Health__GMH__score_T_score;
    private static readonly CqlCode _PROMIS_10_Global_Mental_Health__GMH__score_T_score = new CqlCode("71969-0", "http://loinc.org", default, default);

    [CqlCodeDefinition("PROMIS-10 Global Physical Health (GPH) score T-score", codeId: "71971-6", codeSystem: "http://loinc.org")]
    public CqlCode PROMIS_10_Global_Physical_Health__GPH__score_T_score(CqlContext _) => _PROMIS_10_Global_Physical_Health__GPH__score_T_score;
    private static readonly CqlCode _PROMIS_10_Global_Physical_Health__GPH__score_T_score = new CqlCode("71971-6", "http://loinc.org", default, default);

    [CqlCodeDefinition("Quality of life score [HOOS]", codeId: "72093-8", codeSystem: "http://loinc.org")]
    public CqlCode Quality_of_life_score__HOOS_(CqlContext _) => _Quality_of_life_score__HOOS_;
    private static readonly CqlCode _Quality_of_life_score__HOOS_ = new CqlCode("72093-8", "http://loinc.org", default, default);

    [CqlCodeDefinition("Severe cognitive impairment (finding)", codeId: "702956004", codeSystem: "http://snomed.info/sct")]
    public CqlCode Severe_cognitive_impairment__finding_(CqlContext _) => _Severe_cognitive_impairment__finding_;
    private static readonly CqlCode _Severe_cognitive_impairment__finding_ = new CqlCode("702956004", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Sport-recreation score [HOOS]", codeId: "72094-6", codeSystem: "http://loinc.org")]
    public CqlCode Sport_recreation_score__HOOS_(CqlContext _) => _Sport_recreation_score__HOOS_;
    private static readonly CqlCode _Sport_recreation_score__HOOS_ = new CqlCode("72094-6", "http://loinc.org", default, default);

    [CqlCodeDefinition("Symptoms score [HOOS]", codeId: "72096-1", codeSystem: "http://loinc.org")]
    public CqlCode Symptoms_score__HOOS_(CqlContext _) => _Symptoms_score__HOOS_;
    private static readonly CqlCode _Symptoms_score__HOOS_ = new CqlCode("72096-1", "http://loinc.org", default, default);

    [CqlCodeDefinition("Total interval score [HOOSJR]", codeId: "82323-7", codeSystem: "http://loinc.org")]
    public CqlCode Total_interval_score__HOOSJR_(CqlContext _) => _Total_interval_score__HOOSJR_;
    private static readonly CqlCode _Total_interval_score__HOOSJR_ = new CqlCode("82323-7", "http://loinc.org", default, default);

    [CqlCodeDefinition("VR-12 Mental component summary (MCS) score - oblique method T-score", codeId: "72026-8", codeSystem: "http://loinc.org")]
    public CqlCode VR_12_Mental_component_summary__MCS__score___oblique_method_T_score(CqlContext _) => _VR_12_Mental_component_summary__MCS__score___oblique_method_T_score;
    private static readonly CqlCode _VR_12_Mental_component_summary__MCS__score___oblique_method_T_score = new CqlCode("72026-8", "http://loinc.org", default, default);

    [CqlCodeDefinition("VR-12 Mental component summary (MCS) score - orthogonal method T-score", codeId: "72028-4", codeSystem: "http://loinc.org")]
    public CqlCode VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score(CqlContext _) => _VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score;
    private static readonly CqlCode _VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score = new CqlCode("72028-4", "http://loinc.org", default, default);

    [CqlCodeDefinition("VR-12 Physical component summary (PCS) score - oblique method T-score", codeId: "72025-0", codeSystem: "http://loinc.org")]
    public CqlCode VR_12_Physical_component_summary__PCS__score___oblique_method_T_score(CqlContext _) => _VR_12_Physical_component_summary__PCS__score___oblique_method_T_score;
    private static readonly CqlCode _VR_12_Physical_component_summary__PCS__score___oblique_method_T_score = new CqlCode("72025-0", "http://loinc.org", default, default);

    [CqlCodeDefinition("VR-12 Physical component summary (PCS) score - orthogonal method T-score", codeId: "72027-6", codeSystem: "http://loinc.org")]
    public CqlCode VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score(CqlContext _) => _VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score;
    private static readonly CqlCode _VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score = new CqlCode("72027-6", "http://loinc.org", default, default);

    [CqlCodeDefinition("Yes (qualifier value)", codeId: "373066001", codeSystem: "http://snomed.info/sct")]
    public CqlCode Yes__qualifier_value_(CqlContext _) => _Yes__qualifier_value_;
    private static readonly CqlCode _Yes__qualifier_value_ = new CqlCode("373066001", "http://snomed.info/sct", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC = new CqlCodeSystem();

    [CqlCodeSystemDefinition("CPT")]
    public CqlCodeSystem CPT(CqlContext _) => _CPT;
    private static readonly CqlCodeSystem _CPT = new CqlCodeSystem();

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime pzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(pzzzzzzzzzzzzzzzzzzzzzzd_, pzzzzzzzzzzzzzzzzzzzzzze_, true, true);
        object pzzzzzzzzzzzzzzzzzzzzzzg_ = context.ResolveParameter("FunctionalStatusAssessmentforTotalHipReplacementFHIR-0.0.008", "Measurement Period", pzzzzzzzzzzzzzzzzzzzzzzf_);

        return (CqlInterval<CqlDateTime>)pzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> pzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient pzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SingletonFrom<Patient>(pzzzzzzzzzzzzzzzzzzzzzzh_);

        return pzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? pzzzzzzzzzzzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return pzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Payer Type")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Type(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> pzzzzzzzzzzzzzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return pzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? pzzzzzzzzzzzzzzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return pzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode pzzzzzzzzzzzzzzzzzzzzzzm_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return pzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("August 1 Year Prior to the Measurement Period")]
    public CqlDateTime August_1_Year_Prior_to_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
        CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzn_);
        int? pzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateTimeComponentFrom(pzzzzzzzzzzzzzzzzzzzzzzo_, "year");
        int? pzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Subtract(pzzzzzzzzzzzzzzzzzzzzzzp_, 1);
        decimal? pzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateTime(pzzzzzzzzzzzzzzzzzzzzzzq_, 8, 1, 0, 0, 0, 0, pzzzzzzzzzzzzzzzzzzzzzzr_);

        return pzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Has Qualifying Encounter")]
    public bool? Has_Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzt_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzv_ = this.Office_Visit(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? pzzzzzzzzzzzzzzzzzzzzzzz_(Encounter E)
        {
            List<CodeableConcept> qzzzzzzzzzzzzzzzzzzzzzzm_ = E?.Type;
            CqlConcept qzzzzzzzzzzzzzzzzzzzzzzn_(CodeableConcept @this)
            {
                CqlConcept qzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return qzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<CqlConcept> qzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)qzzzzzzzzzzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzp_(CqlConcept T)
            {
                CqlCode qzzzzzzzzzzzzzzzzzzzzzzt_ = this.Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure(context);
                CqlConcept qzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertCodeToConcept(qzzzzzzzzzzzzzzzzzzzzzzt_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equivalent(T, qzzzzzzzzzzzzzzzzzzzzzzu_);

                return qzzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<CqlConcept> qzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<CqlConcept>(qzzzzzzzzzzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<CqlConcept>(qzzzzzzzzzzzzzzzzzzzzzzq_);

            return qzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzzzzz_);
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzb_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(qzzzzzzzzzzzzzzzzzzzzzza_, qzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzzzzzzzzzzd_);
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzf_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(qzzzzzzzzzzzzzzzzzzzzzze_, qzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzi_ = Status_1_8_000.Instance.isEncounterPerformed(context, qzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzj_(Encounter ValidEncounters)
        {
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzw_ = this.August_1_Year_Prior_to_the_Measurement_Period(context);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.End(qzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(qzzzzzzzzzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzzzzzzzzzy_, true, true);
            Period rzzzzzzzzzzzzzzzzzzzzzza_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzzzzzb_ as object);
            bool? rzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzzzzzzzzc_, "day");

            return rzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzk_);

        return qzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("November 1 Two Years Prior to the Measurement Period")]
    public CqlDateTime November_1_Two_Years_Prior_to_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzze_);
        int? rzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateTimeComponentFrom(rzzzzzzzzzzzzzzzzzzzzzzf_, "year");
        int? rzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Subtract(rzzzzzzzzzzzzzzzzzzzzzzg_, 2);
        decimal? rzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateTime(rzzzzzzzzzzzzzzzzzzzzzzh_, 11, 1, 0, 0, 0, 0, rzzzzzzzzzzzzzzzzzzzzzzi_);

        return rzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("October 31 Year Prior to the Measurement Period")]
    public CqlDateTime October_31_Year_Prior_to_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzk_);
        int? rzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateTimeComponentFrom(rzzzzzzzzzzzzzzzzzzzzzzl_, "year");
        int? rzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Subtract(rzzzzzzzzzzzzzzzzzzzzzzm_, 1);
        decimal? rzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateTime(rzzzzzzzzzzzzzzzzzzzzzzn_, 10, 31, 23, 59, 59, 0, rzzzzzzzzzzzzzzzzzzzzzzo_);

        return rzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Total Hip Arthroplasty Procedure")]
    public IEnumerable<Procedure> Total_Hip_Arthroplasty_Procedure(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzq_ = this.Primary_THA_Procedure(context);
        IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzzzzs_ = Status_1_8_000.Instance.isProcedurePerformed(context, rzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzt_(Procedure THAProcedure)
        {
            DataType rzzzzzzzzzzzzzzzzzzzzzzv_ = THAProcedure?.Performed;
            object rzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzz_ = this.November_1_Two_Years_Prior_to_the_Measurement_Period(context);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzza_ = this.October_31_Year_Prior_to_the_Measurement_Period(context);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzzzzzzzz_, szzzzzzzzzzzzzzzzzzzzzza_, true, true);
            bool? szzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzy_, szzzzzzzzzzzzzzzzzzzzzzb_, "day");

            return szzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Procedure>(rzzzzzzzzzzzzzzzzzzzzzzs_, rzzzzzzzzzzzzzzzzzzzzzzt_);

        return rzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? szzzzzzzzzzzzzzzzzzzzzzd_ = this.Has_Qualifying_Encounter(context);
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzze_ = this.Total_Hip_Arthroplasty_Procedure(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<Procedure>(szzzzzzzzzzzzzzzzzzzzzze_);
        bool? szzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzd_, szzzzzzzzzzzzzzzzzzzzzzf_);
        Patient szzzzzzzzzzzzzzzzzzzzzzh_ = this.Patient(context);
        Date szzzzzzzzzzzzzzzzzzzzzzi_ = szzzzzzzzzzzzzzzzzzzzzzh_?.BirthDateElement;
        string szzzzzzzzzzzzzzzzzzzzzzj_ = szzzzzzzzzzzzzzzzzzzzzzi_?.Value;
        CqlDate szzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertStringToDate(szzzzzzzzzzzzzzzzzzzzzzj_);
        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
        CqlDateTime szzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzl_);
        CqlDate szzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzzzzzzzm_);
        int? szzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.CalculateAgeAt(szzzzzzzzzzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzzzzzzzzzn_, "year");
        bool? szzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.GreaterOrEqual(szzzzzzzzzzzzzzzzzzzzzzo_, 19);
        bool? szzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzg_, szzzzzzzzzzzzzzzzzzzzzzp_);

        return szzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? szzzzzzzzzzzzzzzzzzzzzzr_ = this.Initial_Population(context);

        return szzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Has Severe Cognitive Impairment")]
    public bool? Has_Severe_Cognitive_Impairment(CqlContext context)
    {
        CqlCode szzzzzzzzzzzzzzzzzzzzzzs_ = this.Severe_cognitive_impairment__finding_(context);
        IEnumerable<CqlCode> szzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ToList<CqlCode>(szzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, szzzzzzzzzzzzzzzzzzzzzzt_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? szzzzzzzzzzzzzzzzzzzzzzv_(Condition Dementia)
        {
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Dementia);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
            bool? tzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Overlaps(szzzzzzzzzzzzzzzzzzzzzzy_, szzzzzzzzzzzzzzzzzzzzzzz_, "day");

            return tzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Condition>(szzzzzzzzzzzzzzzzzzzzzzu_, szzzzzzzzzzzzzzzzzzzzzzv_);
        bool? szzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Condition>(szzzzzzzzzzzzzzzzzzzzzzw_);

        return szzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Has Total Hip Arthroplasty with 1 or More Lower Body Fractures")]
    public bool? Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures(CqlContext context)
    {
        IEnumerable<Procedure> tzzzzzzzzzzzzzzzzzzzzzzb_ = this.Total_Hip_Arthroplasty_Procedure(context);
        IEnumerable<Procedure> tzzzzzzzzzzzzzzzzzzzzzzc_(Procedure THAProcedure)
        {
            CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzf_ = this.Lower_Body_Fractures_Excluding_Ankle_and_Foot(context);
            IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? tzzzzzzzzzzzzzzzzzzzzzzh_(Condition LowerBodyFracture)
            {
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, LowerBodyFracture);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzl_);
                DataType tzzzzzzzzzzzzzzzzzzzzzzn_ = THAProcedure?.Performed;
                object tzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlQuantity tzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Subtract(tzzzzzzzzzzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzzzzzzzzzzr_);
                object tzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(tzzzzzzzzzzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzzzzzzzzzzw_, true, true);
                bool? tzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzm_, tzzzzzzzzzzzzzzzzzzzzzzx_, default);
                object uzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzb_);
                bool? uzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzzzzzzzzzzc_ is null));
                bool? uzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzzzzzzzd_);

                return uzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Condition>(tzzzzzzzzzzzzzzzzzzzzzzg_, tzzzzzzzzzzzzzzzzzzzzzzh_);
            Procedure tzzzzzzzzzzzzzzzzzzzzzzj_(Condition LowerBodyFracture) =>
                THAProcedure;
            IEnumerable<Procedure> tzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Condition, Procedure>(tzzzzzzzzzzzzzzzzzzzzzzi_, tzzzzzzzzzzzzzzzzzzzzzzj_);

            return tzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Procedure> tzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SelectMany<Procedure, Procedure>(tzzzzzzzzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? tzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Procedure>(tzzzzzzzzzzzzzzzzzzzzzzd_);

        return tzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Has Partial Hip Arthroplasty Procedure")]
    public bool? Has_Partial_Hip_Arthroplasty_Procedure(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzf_ = this.Partial_Arthroplasty_of_Hip(context);
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzh_ = Status_1_8_000.Instance.isProcedurePerformed(context, uzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzi_(Procedure PartialTHAProcedure)
        {
            IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzl_ = this.Total_Hip_Arthroplasty_Procedure(context);
            bool? uzzzzzzzzzzzzzzzzzzzzzzm_(Procedure THAProcedure)
            {
                DataType uzzzzzzzzzzzzzzzzzzzzzzq_ = THAProcedure?.Performed;
                object uzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzzzzzzzzzr_);
                DataType uzzzzzzzzzzzzzzzzzzzzzzt_ = PartialTHAProcedure?.Performed;
                object uzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzzzzzzzzzu_);
                bool? uzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzzzzzzzzv_, "day");

                return uzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Procedure>(uzzzzzzzzzzzzzzzzzzzzzzl_, uzzzzzzzzzzzzzzzzzzzzzzm_);
            Procedure uzzzzzzzzzzzzzzzzzzzzzzo_(Procedure THAProcedure) =>
                PartialTHAProcedure;
            IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Procedure, Procedure>(uzzzzzzzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzzzzzzzo_);

            return uzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<Procedure, Procedure>(uzzzzzzzzzzzzzzzzzzzzzzh_, uzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Procedure>(uzzzzzzzzzzzzzzzzzzzzzzj_);

        return uzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Has Revision Hip Arthroplasty Procedure or Implanted Device or Prosthesis Removal Procedure")]
    public bool? Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure(CqlContext context)
    {
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzx_ = this.Total_Hip_Arthroplasty_Procedure(context);
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzy_(Procedure THAProcedure)
        {
            CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzb_ = this.Removal__Revision_and_Supplement_Procedures_of_the_Lower_Body_and_Spine(context);
            IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzzd_ = Status_1_8_000.Instance.isProcedurePerformed(context, vzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? vzzzzzzzzzzzzzzzzzzzzzze_(Procedure RevisionTHAProcedure)
            {
                DataType vzzzzzzzzzzzzzzzzzzzzzzi_ = THAProcedure?.Performed;
                object vzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzzzzzzj_);
                DataType vzzzzzzzzzzzzzzzzzzzzzzl_ = RevisionTHAProcedure?.Performed;
                object vzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzzzzzzm_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzzzzzzzzzzn_, "day");

                return vzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Procedure>(vzzzzzzzzzzzzzzzzzzzzzzd_, vzzzzzzzzzzzzzzzzzzzzzze_);
            Procedure vzzzzzzzzzzzzzzzzzzzzzzg_(Procedure RevisionTHAProcedure) =>
                THAProcedure;
            IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<Procedure, Procedure>(vzzzzzzzzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzzzzzzzzg_);

            return vzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SelectMany<Procedure, Procedure>(uzzzzzzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? vzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Procedure>(uzzzzzzzzzzzzzzzzzzzzzzz_);

        return vzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Has Malignant Neoplasm of Lower and Unspecified Limbs")]
    public bool? Has_Malignant_Neoplasm_of_Lower_and_Unspecified_Limbs(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzp_ = this.Malignant_Neoplasms_of_Lower_and_Unspecified_Limbs(context);
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzr_(Condition MalignantNeoplasm)
        {
            IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzzu_ = this.Total_Hip_Arthroplasty_Procedure(context);
            bool? vzzzzzzzzzzzzzzzzzzzzzzv_(Procedure THAProcedure)
            {
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MalignantNeoplasm);
                DataType wzzzzzzzzzzzzzzzzzzzzzza_ = THAProcedure?.Performed;
                object wzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzzzzzzzb_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Overlaps(vzzzzzzzzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzzzzzzzzzc_, "day");

                return wzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Procedure>(vzzzzzzzzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzzzzzzzzv_);
            Condition vzzzzzzzzzzzzzzzzzzzzzzx_(Procedure THAProcedure) =>
                MalignantNeoplasm;
            IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<Procedure, Condition>(vzzzzzzzzzzzzzzzzzzzzzzw_, vzzzzzzzzzzzzzzzzzzzzzzx_);

            return vzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SelectMany<Condition, Condition>(vzzzzzzzzzzzzzzzzzzzzzzq_, vzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Condition>(vzzzzzzzzzzzzzzzzzzzzzzs_);

        return vzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Has Mechanical Complication")]
    public bool? Has_Mechanical_Complication(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzze_ = this.Mechanical_Complications_Excluding_Upper_Body(context);
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzg_(Condition MechanicalComplications)
        {
            IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzzzzzzj_ = this.Total_Hip_Arthroplasty_Procedure(context);
            bool? wzzzzzzzzzzzzzzzzzzzzzzk_(Procedure THAProcedure)
            {
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MechanicalComplications);
                DataType wzzzzzzzzzzzzzzzzzzzzzzp_ = THAProcedure?.Performed;
                object wzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Overlaps(wzzzzzzzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzzzzzzzr_, "day");

                return wzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Procedure>(wzzzzzzzzzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzzzzzzzzzk_);
            Condition wzzzzzzzzzzzzzzzzzzzzzzm_(Procedure THAProcedure) =>
                MechanicalComplications;
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Procedure, Condition>(wzzzzzzzzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzzzzzzzzm_);

            return wzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SelectMany<Condition, Condition>(wzzzzzzzzzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Exists<Condition>(wzzzzzzzzzzzzzzzzzzzzzzh_);

        return wzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Has More Than One Elective Primary Total Hip Arthroplasty Performed")]
    public bool? Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed(CqlContext context)
    {
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzzzzzzt_ = this.Total_Hip_Arthroplasty_Procedure(context);
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzzzzzzu_(Procedure THAProcedure)
        {
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzx_ = this.Primary_THA_Procedure(context);
            IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzzzzzzz_ = Status_1_8_000.Instance.isProcedurePerformed(context, wzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? xzzzzzzzzzzzzzzzzzzzzzza_(Procedure ElectiveTHAProcedure)
            {
                Id xzzzzzzzzzzzzzzzzzzzzzze_ = THAProcedure?.IdElement;
                string xzzzzzzzzzzzzzzzzzzzzzzf_ = xzzzzzzzzzzzzzzzzzzzzzze_?.Value;
                Id xzzzzzzzzzzzzzzzzzzzzzzg_ = ElectiveTHAProcedure?.IdElement;
                string xzzzzzzzzzzzzzzzzzzzzzzh_ = xzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
                bool? xzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Equivalent(xzzzzzzzzzzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzzzzzzzzzzh_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Not(xzzzzzzzzzzzzzzzzzzzzzzi_);
                DataType xzzzzzzzzzzzzzzzzzzzzzzk_ = ElectiveTHAProcedure?.Performed;
                object xzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzm_);
                DataType xzzzzzzzzzzzzzzzzzzzzzzo_ = THAProcedure?.Performed;
                object xzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlQuantity xzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(1m, "year");
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Subtract(xzzzzzzzzzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzzzzzzzzzs_);
                object xzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Add(xzzzzzzzzzzzzzzzzzzzzzzx_, xzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzzzzzzzzzz_, true, true);
                bool? yzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzzzzzzzzza_, "day");
                bool? yzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzzzzzzzzzzb_);

                return yzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Procedure>(wzzzzzzzzzzzzzzzzzzzzzzz_, xzzzzzzzzzzzzzzzzzzzzzza_);
            Procedure xzzzzzzzzzzzzzzzzzzzzzzc_(Procedure ElectiveTHAProcedure) =>
                THAProcedure;
            IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<Procedure, Procedure>(xzzzzzzzzzzzzzzzzzzzzzzb_, xzzzzzzzzzzzzzzzzzzzzzzc_);

            return xzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SelectMany<Procedure, Procedure>(wzzzzzzzzzzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Procedure>(wzzzzzzzzzzzzzzzzzzzzzzv_);

        return wzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Death Within 300 Days of the THA Procedure")]
    public bool? Death_Within_300_Days_of_the_THA_Procedure(CqlContext context)
    {
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzzzzzzzd_ = this.Total_Hip_Arthroplasty_Procedure(context);
        bool? yzzzzzzzzzzzzzzzzzzzzzze_(Procedure THAProcedure)
        {
            Patient yzzzzzzzzzzzzzzzzzzzzzzh_ = this.Patient(context);
            DataType yzzzzzzzzzzzzzzzzzzzzzzi_ = yzzzzzzzzzzzzzzzzzzzzzzh_?.Deceased;
            object yzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDate yzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzzj_ as CqlDateTime);
            DataType yzzzzzzzzzzzzzzzzzzzzzzl_ = THAProcedure?.Performed;
            object yzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDate yzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzzo_);
            object yzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDate yzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(300m, "days");
            CqlDate yzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Add(yzzzzzzzzzzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzzzzzzzzzzw_, true, true);
            bool? yzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDate>(yzzzzzzzzzzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzzzzzzzzzzx_, "day");

            return yzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Procedure>(yzzzzzzzzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzzzzzzzzze_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Procedure>(yzzzzzzzzzzzzzzzzzzzzzzf_);

        return yzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? yzzzzzzzzzzzzzzzzzzzzzzz_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzza_ = this.Has_Severe_Cognitive_Impairment(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(yzzzzzzzzzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzzzzzzzzza_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzc_ = this.Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzzzb_, zzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? zzzzzzzzzzzzzzzzzzzzzzze_ = this.Has_Partial_Hip_Arthroplasty_Procedure(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzzzzzzzzze_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzg_ = this.Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzi_ = this.Has_Malignant_Neoplasm_of_Lower_and_Unspecified_Limbs(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzk_ = this.Has_Mechanical_Complication(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzzzj_, zzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzm_ = this.Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzzzl_, zzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzo_ = this.Death_Within_300_Days_of_the_THA_Procedure(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzzzzzzzo_);

        return zzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Date HOOS Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_HOOS_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode zzzzzzzzzzzzzzzzzzzzzzzq_ = this.Quality_of_life_score__HOOS_(context);
        IEnumerable<CqlCode> zzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ToList<CqlCode>(zzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, zzzzzzzzzzzzzzzzzzzzzzzr_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzt_ = Status_1_8_000.Instance.isAssessmentPerformed(context, zzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlCode zzzzzzzzzzzzzzzzzzzzzzzu_ = this.Sport_recreation_score__HOOS_(context);
        IEnumerable<CqlCode> zzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ToList<CqlCode>(zzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, zzzzzzzzzzzzzzzzzzzzzzzv_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzx_ = Status_1_8_000.Instance.isAssessmentPerformed(context, zzzzzzzzzzzzzzzzzzzzzzzw_);
        CqlCode zzzzzzzzzzzzzzzzzzzzzzzy_ = this.Activities_of_daily_living_score__HOOS_(context);
        IEnumerable<CqlCode> zzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ToList<CqlCode>(zzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, zzzzzzzzzzzzzzzzzzzzzzzz_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzb_ = Status_1_8_000.Instance.isAssessmentPerformed(context, azzzzzzzzzzzzzzzzzzzzzzza_);
        CqlCode azzzzzzzzzzzzzzzzzzzzzzzc_ = this.Symptoms_score__HOOS_(context);
        IEnumerable<CqlCode> azzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ToList<CqlCode>(azzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, azzzzzzzzzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzf_ = Status_1_8_000.Instance.isAssessmentPerformed(context, azzzzzzzzzzzzzzzzzzzzzzze_);
        CqlCode azzzzzzzzzzzzzzzzzzzzzzzg_ = this.Pain_score__HOOS_(context);
        IEnumerable<CqlCode> azzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ToList<CqlCode>(azzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, azzzzzzzzzzzzzzzzzzzzzzzh_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzj_ = Status_1_8_000.Instance.isAssessmentPerformed(context, azzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<ValueTuple<Observation, Observation, Observation, Observation, Observation>> azzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.CrossJoin<Observation, Observation, Observation, Observation, Observation>(zzzzzzzzzzzzzzzzzzzzzzzt_, zzzzzzzzzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzzzzzzzzzb_, azzzzzzzzzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzzzzzzzzj_);
        (CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)? azzzzzzzzzzzzzzzzzzzzzzzl_(ValueTuple<Observation, Observation, Observation, Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)? azzzzzzzzzzzzzzzzzzzzzzzs_ = (CqlTupleMetadata_GVNUVHGXYWXVGgfjdTEahUfhP, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4, _valueTuple.Item5);

            return azzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?> azzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<ValueTuple<Observation, Observation, Observation, Observation, Observation>, (CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?>(azzzzzzzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzn_((CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)? tuple_eipfmazvhfscjijaofhicpvmb)
        {
            DataType azzzzzzzzzzzzzzzzzzzzzzzt_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSLifeQuality?.Effective;
            object azzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDate azzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzw_);
            DataType azzzzzzzzzzzzzzzzzzzzzzzy_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSport?.Effective;
            object azzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDate bzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SameAs(azzzzzzzzzzzzzzzzzzzzzzzx_, bzzzzzzzzzzzzzzzzzzzzzzzc_, "day");
            DataType bzzzzzzzzzzzzzzzzzzzzzzze_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSport?.Value;
            object bzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzze_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzzzzzzzzf_ is null));
            bool? bzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzzzzzzzg_);
            object bzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDate bzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzl_);
            DataType bzzzzzzzzzzzzzzzzzzzzzzzn_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSActivityScore?.Effective;
            object bzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDate bzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SameAs(bzzzzzzzzzzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzzzzzzzzzzr_, "day");
            bool? bzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzh_, bzzzzzzzzzzzzzzzzzzzzzzzs_);
            DataType bzzzzzzzzzzzzzzzzzzzzzzzu_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSActivityScore?.Value;
            object bzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzzzzzzzzv_ is null));
            bool? bzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzzzzzzzzzzw_);
            object bzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDate czzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzzb_);
            DataType czzzzzzzzzzzzzzzzzzzzzzzd_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSymptoms?.Effective;
            object czzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDate czzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzzg_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SameAs(czzzzzzzzzzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzzzzzzzzzh_, "day");
            bool? czzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzx_, czzzzzzzzzzzzzzzzzzzzzzzi_);
            DataType czzzzzzzzzzzzzzzzzzzzzzzk_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSymptoms?.Value;
            object czzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzzzzzzl_ is null));
            bool? czzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzzzzzzzzm_);
            object czzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDate czzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzzr_);
            DataType czzzzzzzzzzzzzzzzzzzzzzzt_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSPain?.Effective;
            object czzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDate czzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SameAs(czzzzzzzzzzzzzzzzzzzzzzzs_, czzzzzzzzzzzzzzzzzzzzzzzx_, "day");
            bool? czzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzn_, czzzzzzzzzzzzzzzzzzzzzzzy_);
            DataType dzzzzzzzzzzzzzzzzzzzzzzza_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSPain?.Value;
            object dzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzzzzzzzzzb_ is null));
            bool? dzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzz_, dzzzzzzzzzzzzzzzzzzzzzzzc_);
            DataType dzzzzzzzzzzzzzzzzzzzzzzze_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSLifeQuality?.Value;
            object dzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzze_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzzzzzzzzzf_ is null));
            bool? dzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzzzzzzzzzg_);

            return dzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?> azzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<(CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?>(azzzzzzzzzzzzzzzzzzzzzzzm_, azzzzzzzzzzzzzzzzzzzzzzzn_);
        CqlDate azzzzzzzzzzzzzzzzzzzzzzzp_((CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)? tuple_eipfmazvhfscjijaofhicpvmb)
        {
            DataType dzzzzzzzzzzzzzzzzzzzzzzzi_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSLifeQuality?.Effective;
            object dzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzzzzzzzzzl_);
            DataType dzzzzzzzzzzzzzzzzzzzzzzzn_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSport?.Effective;
            object dzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzzzzzzzzzq_);
            DataType dzzzzzzzzzzzzzzzzzzzzzzzs_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSActivityScore?.Effective;
            object dzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzzzzzzzzzv_);
            DataType dzzzzzzzzzzzzzzzzzzzzzzzx_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSymptoms?.Effective;
            object dzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDate ezzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzza_);
            DataType ezzzzzzzzzzzzzzzzzzzzzzzc_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSPain?.Effective;
            object ezzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDate ezzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDate[] ezzzzzzzzzzzzzzzzzzzzzzzh_ = [
                dzzzzzzzzzzzzzzzzzzzzzzzm_,
                dzzzzzzzzzzzzzzzzzzzzzzzr_,
                dzzzzzzzzzzzzzzzzzzzzzzzw_,
                ezzzzzzzzzzzzzzzzzzzzzzzb_,
                ezzzzzzzzzzzzzzzzzzzzzzzg_,
            ];
            CqlDate ezzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Max<CqlDate>(ezzzzzzzzzzzzzzzzzzzzzzzh_ as IEnumerable<CqlDate>);

            return ezzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?, CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzo_, azzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Distinct<CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzq_);

        return azzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up HOOS Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments(CqlContext context)
    {
        IEnumerable<Procedure> ezzzzzzzzzzzzzzzzzzzzzzzj_ = this.Total_Hip_Arthroplasty_Procedure(context);
        CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzk_(Procedure THAProcedure)
        {
            DataType ezzzzzzzzzzzzzzzzzzzzzzzs_ = THAProcedure?.Performed;
            object ezzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzt_);

            return ezzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> ezzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(ezzzzzzzzzzzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<CqlInterval<CqlDateTime>> ezzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(ezzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<CqlInterval<CqlDateTime>> ezzzzzzzzzzzzzzzzzzzzzzzn_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzzv_ = this.Date_HOOS_Total_Assessment_Completed(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzw_(CqlDate InitialHipAssessmentHOOS)
            {
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(TotalHip);
                CqlQuantity fzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(90m, "days");
                CqlDate fzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Add(InitialHipAssessmentHOOS, fzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Interval(InitialHipAssessmentHOOS, fzzzzzzzzzzzzzzzzzzzzzzzc_, true, true);
                CqlDate fzzzzzzzzzzzzzzzzzzzzzzze_ = fzzzzzzzzzzzzzzzzzzzzzzzd_?.low;
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConvertDateToDateTime(fzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDate fzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Add(InitialHipAssessmentHOOS, fzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(InitialHipAssessmentHOOS, fzzzzzzzzzzzzzzzzzzzzzzzh_, true, true);
                CqlDate fzzzzzzzzzzzzzzzzzzzzzzzj_ = fzzzzzzzzzzzzzzzzzzzzzzzi_?.high;
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertDateToDateTime(fzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDate fzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Add(InitialHipAssessmentHOOS, fzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(InitialHipAssessmentHOOS, fzzzzzzzzzzzzzzzzzzzzzzzm_, true, true);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzo_ = fzzzzzzzzzzzzzzzzzzzzzzzn_?.lowClosed;
                CqlDate fzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Add(InitialHipAssessmentHOOS, fzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(InitialHipAssessmentHOOS, fzzzzzzzzzzzzzzzzzzzzzzzq_, true, true);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzs_ = fzzzzzzzzzzzzzzzzzzzzzzzr_?.highClosed;
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzzzzzzzzf_, fzzzzzzzzzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzzzzzzzzzo_, fzzzzzzzzzzzzzzzzzzzzzzzs_);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzza_, fzzzzzzzzzzzzzzzzzzzzzzzt_, "day");
                bool? fzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(InitialHipAssessmentHOOS is null));
                bool? fzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzu_, fzzzzzzzzzzzzzzzzzzzzzzzv_);

                return fzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<CqlDate>(ezzzzzzzzzzzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzy_(CqlDate InitialHipAssessmentHOOS) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> ezzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(ezzzzzzzzzzzzzzzzzzzzzzzx_, ezzzzzzzzzzzzzzzzzzzzzzzy_);

            return ezzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> ezzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(ezzzzzzzzzzzzzzzzzzzzzzzm_, ezzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<CqlInterval<CqlDateTime>> ezzzzzzzzzzzzzzzzzzzzzzzp_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Date_HOOS_Total_Assessment_Completed(context);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzy_(CqlDate FollowUpHipAssessmentHOOS)
            {
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentHOOS);
                CqlDate gzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.End(TotalHip);
                CqlDate gzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(300m, "days");
                CqlDate gzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Add(gzzzzzzzzzzzzzzzzzzzzzzzf_, gzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDate gzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(425m, "days");
                CqlDate gzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Add(gzzzzzzzzzzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDate> gzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzzzzzzzzzzzl_, true, true);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDate>(gzzzzzzzzzzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzzzzzzzzzzzm_, "day");

                return gzzzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzza_(CqlDate FollowUpHipAssessmentHOOS) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> gzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(fzzzzzzzzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzzzzzzzza_);

            return gzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> ezzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(ezzzzzzzzzzzzzzzzzzzzzzzo_, ezzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(ezzzzzzzzzzzzzzzzzzzzzzzq_);

        return ezzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Date HOOSJr Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_HOOSJr_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode gzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Total_interval_score__HOOSJR_(context);
        IEnumerable<CqlCode> gzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ToList<CqlCode>(gzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, gzzzzzzzzzzzzzzzzzzzzzzzp_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzr_ = Status_1_8_000.Instance.isAssessmentPerformed(context, gzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzs_(Observation HOOSJr)
        {
            DataType gzzzzzzzzzzzzzzzzzzzzzzzx_ = HOOSJr?.Value;
            object gzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzzzzzzzzzy_ is null));

            return gzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlDate gzzzzzzzzzzzzzzzzzzzzzzzu_(Observation DocumentedHOOSJr)
        {
            DataType hzzzzzzzzzzzzzzzzzzzzzzza_ = DocumentedHOOSJr?.Effective;
            object hzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDate hzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzzzzzzzzd_);

            return hzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<CqlDate> gzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Observation, CqlDate>(gzzzzzzzzzzzzzzzzzzzzzzzt_, gzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<CqlDate> gzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Distinct<CqlDate>(gzzzzzzzzzzzzzzzzzzzzzzzv_);

        return gzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up HOOSJr Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments(CqlContext context)
    {
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Total_Hip_Arthroplasty_Procedure(context);
        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzg_(Procedure THAProcedure)
        {
            DataType hzzzzzzzzzzzzzzzzzzzzzzzo_ = THAProcedure?.Performed;
            object hzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzp_);

            return hzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> hzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(hzzzzzzzzzzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<CqlInterval<CqlDateTime>> hzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(hzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<CqlInterval<CqlDateTime>> hzzzzzzzzzzzzzzzzzzzzzzzj_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Date_HOOSJr_Total_Assessment_Completed(context);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzs_(CqlDate InitialHipAssessment)
            {
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(TotalHip);
                CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(90m, "days");
                CqlDate hzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Add(InitialHipAssessment, hzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(InitialHipAssessment, hzzzzzzzzzzzzzzzzzzzzzzzy_, true, true);
                CqlDate izzzzzzzzzzzzzzzzzzzzzzza_ = hzzzzzzzzzzzzzzzzzzzzzzzz_?.low;
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConvertDateToDateTime(izzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDate izzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Add(InitialHipAssessment, hzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDate> izzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(InitialHipAssessment, izzzzzzzzzzzzzzzzzzzzzzzd_, true, true);
                CqlDate izzzzzzzzzzzzzzzzzzzzzzzf_ = izzzzzzzzzzzzzzzzzzzzzzze_?.high;
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertDateToDateTime(izzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDate izzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Add(InitialHipAssessment, hzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(InitialHipAssessment, izzzzzzzzzzzzzzzzzzzzzzzi_, true, true);
                bool? izzzzzzzzzzzzzzzzzzzzzzzk_ = izzzzzzzzzzzzzzzzzzzzzzzj_?.lowClosed;
                CqlDate izzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Add(InitialHipAssessment, hzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(InitialHipAssessment, izzzzzzzzzzzzzzzzzzzzzzzm_, true, true);
                bool? izzzzzzzzzzzzzzzzzzzzzzzo_ = izzzzzzzzzzzzzzzzzzzzzzzn_?.highClosed;
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(izzzzzzzzzzzzzzzzzzzzzzzb_, izzzzzzzzzzzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzzzzzzzzzzk_, izzzzzzzzzzzzzzzzzzzzzzzo_);
                bool? izzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzzzzzzzzp_, "day");
                bool? izzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(InitialHipAssessment is null));
                bool? izzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzq_, izzzzzzzzzzzzzzzzzzzzzzzr_);

                return izzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzu_(CqlDate InitialHipAssessment) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> hzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(hzzzzzzzzzzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzzzzzzzzzzu_);

            return hzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> hzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(hzzzzzzzzzzzzzzzzzzzzzzzi_, hzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<CqlInterval<CqlDateTime>> hzzzzzzzzzzzzzzzzzzzzzzzl_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzt_ = this.Date_HOOSJr_Total_Assessment_Completed(context);
            bool? izzzzzzzzzzzzzzzzzzzzzzzu_(CqlDate FollowUpHipAssessment)
            {
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessment);
                CqlDate izzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(izzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.End(TotalHip);
                CqlDate jzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlQuantity jzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(300m, "days");
                CqlDate jzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Add(jzzzzzzzzzzzzzzzzzzzzzzzb_, jzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDate jzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlQuantity jzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(425m, "days");
                CqlDate jzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Add(jzzzzzzzzzzzzzzzzzzzzzzzf_, jzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(jzzzzzzzzzzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzzzzzzzzzzzh_, true, true);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDate>(izzzzzzzzzzzzzzzzzzzzzzzz_, jzzzzzzzzzzzzzzzzzzzzzzzi_, "day");

                return jzzzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<CqlDate>(izzzzzzzzzzzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzw_(CqlDate FollowUpHipAssessment) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> izzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(izzzzzzzzzzzzzzzzzzzzzzzv_, izzzzzzzzzzzzzzzzzzzzzzzw_);

            return izzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> hzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(hzzzzzzzzzzzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(hzzzzzzzzzzzzzzzzzzzzzzzm_);

        return hzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Date PROMIS10 Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_PROMIS10_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode jzzzzzzzzzzzzzzzzzzzzzzzk_ = this.PROMIS_10_Global_Mental_Health__GMH__score_T_score(context);
        IEnumerable<CqlCode> jzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ToList<CqlCode>(jzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, jzzzzzzzzzzzzzzzzzzzzzzzl_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzn_ = Status_1_8_000.Instance.isAssessmentPerformed(context, jzzzzzzzzzzzzzzzzzzzzzzzm_);
        CqlCode jzzzzzzzzzzzzzzzzzzzzzzzo_ = this.PROMIS_10_Global_Physical_Health__GPH__score_T_score(context);
        IEnumerable<CqlCode> jzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ToList<CqlCode>(jzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, jzzzzzzzzzzzzzzzzzzzzzzzp_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzr_ = Status_1_8_000.Instance.isAssessmentPerformed(context, jzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<ValueTuple<Observation, Observation>> jzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.CrossJoin<Observation, Observation>(jzzzzzzzzzzzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzzzzzzzzzzzr_);
        (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? jzzzzzzzzzzzzzzzzzzzzzzzt_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? kzzzzzzzzzzzzzzzzzzzzzzza_ = (CqlTupleMetadata_DDTAOdcFieSJbGgRLLZPYbGQb, _valueTuple.Item1, _valueTuple.Item2);

            return kzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?> jzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?>(jzzzzzzzzzzzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzv_((CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? tuple_ddtaodcfiesjbggrllzpybgqb)
        {
            DataType kzzzzzzzzzzzzzzzzzzzzzzzb_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Effective;
            object kzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzzzzzzzzze_);
            DataType kzzzzzzzzzzzzzzzzzzzzzzzg_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Effective;
            object kzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SameAs(kzzzzzzzzzzzzzzzzzzzzzzzf_, kzzzzzzzzzzzzzzzzzzzzzzzk_, "day");
            DataType kzzzzzzzzzzzzzzzzzzzzzzzm_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Value;
            object kzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzzzzzzzzn_ is null));
            bool? kzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzl_, kzzzzzzzzzzzzzzzzzzzzzzzo_);
            DataType kzzzzzzzzzzzzzzzzzzzzzzzq_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Value;
            object kzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzzzzzzzzr_ is null));
            bool? kzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzzzzzzzzzzs_);

            return kzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?> jzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?>(jzzzzzzzzzzzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzzzzzzzzzzzv_);
        CqlDate jzzzzzzzzzzzzzzzzzzzzzzzx_((CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? tuple_ddtaodcfiesjbggrllzpybgqb)
        {
            DataType kzzzzzzzzzzzzzzzzzzzzzzzu_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Effective;
            object kzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzzzzzzzzzx_);
            DataType kzzzzzzzzzzzzzzzzzzzzzzzz_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Effective;
            object lzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDate[] lzzzzzzzzzzzzzzzzzzzzzzze_ = [
                kzzzzzzzzzzzzzzzzzzzzzzzy_,
                lzzzzzzzzzzzzzzzzzzzzzzzd_,
            ];
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Max<CqlDate>(lzzzzzzzzzzzzzzzzzzzzzzze_ as IEnumerable<CqlDate>);

            return lzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?, CqlDate>(jzzzzzzzzzzzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Distinct<CqlDate>(jzzzzzzzzzzzzzzzzzzzzzzzy_);

        return jzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up PROMIS10 Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments(CqlContext context)
    {
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Total_Hip_Arthroplasty_Procedure(context);
        CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzh_(Procedure THAProcedure)
        {
            DataType lzzzzzzzzzzzzzzzzzzzzzzzp_ = THAProcedure?.Performed;
            object lzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzq_);

            return lzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> lzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(lzzzzzzzzzzzzzzzzzzzzzzzg_, lzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<CqlInterval<CqlDateTime>> lzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(lzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<CqlInterval<CqlDateTime>> lzzzzzzzzzzzzzzzzzzzzzzzk_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> lzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Date_PROMIS10_Total_Assessment_Completed(context);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzt_(CqlDate InitialHipAssessmentPROMIS10)
            {
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(TotalHip);
                CqlQuantity lzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(90m, "days");
                CqlDate lzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Add(InitialHipAssessmentPROMIS10, lzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDate> mzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(InitialHipAssessmentPROMIS10, lzzzzzzzzzzzzzzzzzzzzzzzz_, true, true);
                CqlDate mzzzzzzzzzzzzzzzzzzzzzzzb_ = mzzzzzzzzzzzzzzzzzzzzzzza_?.low;
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConvertDateToDateTime(mzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDate mzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Add(InitialHipAssessmentPROMIS10, lzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDate> mzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(InitialHipAssessmentPROMIS10, mzzzzzzzzzzzzzzzzzzzzzzze_, true, true);
                CqlDate mzzzzzzzzzzzzzzzzzzzzzzzg_ = mzzzzzzzzzzzzzzzzzzzzzzzf_?.high;
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertDateToDateTime(mzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDate mzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Add(InitialHipAssessmentPROMIS10, lzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDate> mzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(InitialHipAssessmentPROMIS10, mzzzzzzzzzzzzzzzzzzzzzzzj_, true, true);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzl_ = mzzzzzzzzzzzzzzzzzzzzzzzk_?.lowClosed;
                CqlDate mzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Add(InitialHipAssessmentPROMIS10, lzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDate> mzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(InitialHipAssessmentPROMIS10, mzzzzzzzzzzzzzzzzzzzzzzzn_, true, true);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzp_ = mzzzzzzzzzzzzzzzzzzzzzzzo_?.highClosed;
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzzzzzzzzc_, mzzzzzzzzzzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzzzzzzzzzzl_, mzzzzzzzzzzzzzzzzzzzzzzzp_);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzx_, mzzzzzzzzzzzzzzzzzzzzzzzq_, "day");
                bool? mzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(InitialHipAssessmentPROMIS10 is null));
                bool? mzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzzzzzzzzzs_);

                return mzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<CqlDate> lzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<CqlDate>(lzzzzzzzzzzzzzzzzzzzzzzzs_, lzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzv_(CqlDate InitialHipAssessmentPROMIS10) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> lzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(lzzzzzzzzzzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzzzzzzzzzzv_);

            return lzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> lzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(lzzzzzzzzzzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<CqlInterval<CqlDateTime>> lzzzzzzzzzzzzzzzzzzzzzzzm_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> mzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Date_PROMIS10_Total_Assessment_Completed(context);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzv_(CqlDate FollowUpHipAssessmentPROMIS10)
            {
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentPROMIS10);
                CqlDate nzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.End(TotalHip);
                CqlDate nzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(300m, "days");
                CqlDate nzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Add(nzzzzzzzzzzzzzzzzzzzzzzzc_, nzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDate nzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(425m, "days");
                CqlDate nzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Add(nzzzzzzzzzzzzzzzzzzzzzzzg_, nzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDate> nzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzzzzzzze_, nzzzzzzzzzzzzzzzzzzzzzzzi_, true, true);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDate>(nzzzzzzzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzzzzzzzj_, "day");

                return nzzzzzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<CqlDate> mzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<CqlDate>(mzzzzzzzzzzzzzzzzzzzzzzzu_, mzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzx_(CqlDate FollowUpHipAssessmentPROMIS10) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> mzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(mzzzzzzzzzzzzzzzzzzzzzzzw_, mzzzzzzzzzzzzzzzzzzzzzzzx_);

            return mzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> lzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(lzzzzzzzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(lzzzzzzzzzzzzzzzzzzzzzzzn_);

        return lzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Date VR12 Oblique Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR12_Oblique_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode nzzzzzzzzzzzzzzzzzzzzzzzl_ = this.VR_12_Mental_component_summary__MCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> nzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ToList<CqlCode>(nzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, nzzzzzzzzzzzzzzzzzzzzzzzm_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzo_ = Status_1_8_000.Instance.isAssessmentPerformed(context, nzzzzzzzzzzzzzzzzzzzzzzzn_);
        CqlCode nzzzzzzzzzzzzzzzzzzzzzzzp_ = this.VR_12_Physical_component_summary__PCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> nzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ToList<CqlCode>(nzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, nzzzzzzzzzzzzzzzzzzzzzzzq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzs_ = Status_1_8_000.Instance.isAssessmentPerformed(context, nzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<ValueTuple<Observation, Observation>> nzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.CrossJoin<Observation, Observation>(nzzzzzzzzzzzzzzzzzzzzzzzo_, nzzzzzzzzzzzzzzzzzzzzzzzs_);
        (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? nzzzzzzzzzzzzzzzzzzzzzzzu_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? ozzzzzzzzzzzzzzzzzzzzzzzb_ = (CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH, _valueTuple.Item1, _valueTuple.Item2);

            return ozzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> nzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(nzzzzzzzzzzzzzzzzzzzzzzzt_, nzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzw_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType ozzzzzzzzzzzzzzzzzzzzzzzc_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object ozzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzzf_);
            DataType ozzzzzzzzzzzzzzzzzzzzzzzh_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object ozzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SameAs(ozzzzzzzzzzzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzzzzzzzzzzl_, "day");
            DataType ozzzzzzzzzzzzzzzzzzzzzzzn_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Value;
            object ozzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzzzzzzzzo_ is null));
            bool? ozzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzm_, ozzzzzzzzzzzzzzzzzzzzzzzp_);
            DataType ozzzzzzzzzzzzzzzzzzzzzzzr_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Value;
            object ozzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzzzzzzzzs_ is null));
            bool? ozzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzzzzzzzzzzt_);

            return ozzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> nzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(nzzzzzzzzzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzzzzzzzzzw_);
        CqlDate nzzzzzzzzzzzzzzzzzzzzzzzy_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType ozzzzzzzzzzzzzzzzzzzzzzzv_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object ozzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzzy_);
            DataType pzzzzzzzzzzzzzzzzzzzzzzza_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object pzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDate[] pzzzzzzzzzzzzzzzzzzzzzzzf_ = [
                ozzzzzzzzzzzzzzzzzzzzzzzz_,
                pzzzzzzzzzzzzzzzzzzzzzzze_,
            ];
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Max<CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzzf_ as IEnumerable<CqlDate>);

            return pzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<CqlDate> nzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?, CqlDate>(nzzzzzzzzzzzzzzzzzzzzzzzx_, nzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<CqlDate> ozzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Distinct<CqlDate>(nzzzzzzzzzzzzzzzzzzzzzzzz_);

        return ozzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up VR12 Oblique Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments(CqlContext context)
    {
        IEnumerable<Procedure> pzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Total_Hip_Arthroplasty_Procedure(context);
        CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzi_(Procedure THAProcedure)
        {
            DataType pzzzzzzzzzzzzzzzzzzzzzzzq_ = THAProcedure?.Performed;
            object pzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzr_);

            return pzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(pzzzzzzzzzzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(pzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzzzzzzzzzzzzzzl_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Date_VR12_Oblique_Total_Assessment_Completed(context);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzu_(CqlDate InitialHipAssessmentOblique)
            {
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(TotalHip);
                CqlQuantity pzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(90m, "days");
                CqlDate qzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Add(InitialHipAssessmentOblique, pzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(InitialHipAssessmentOblique, qzzzzzzzzzzzzzzzzzzzzzzza_, true, true);
                CqlDate qzzzzzzzzzzzzzzzzzzzzzzzc_ = qzzzzzzzzzzzzzzzzzzzzzzzb_?.low;
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertDateToDateTime(qzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDate qzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Add(InitialHipAssessmentOblique, pzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(InitialHipAssessmentOblique, qzzzzzzzzzzzzzzzzzzzzzzzf_, true, true);
                CqlDate qzzzzzzzzzzzzzzzzzzzzzzzh_ = qzzzzzzzzzzzzzzzzzzzzzzzg_?.high;
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConvertDateToDateTime(qzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDate qzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Add(InitialHipAssessmentOblique, pzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(InitialHipAssessmentOblique, qzzzzzzzzzzzzzzzzzzzzzzzk_, true, true);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzm_ = qzzzzzzzzzzzzzzzzzzzzzzzl_?.lowClosed;
                CqlDate qzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Add(InitialHipAssessmentOblique, pzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(InitialHipAssessmentOblique, qzzzzzzzzzzzzzzzzzzzzzzzo_, true, true);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzq_ = qzzzzzzzzzzzzzzzzzzzzzzzp_?.highClosed;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(qzzzzzzzzzzzzzzzzzzzzzzzd_, qzzzzzzzzzzzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzy_, qzzzzzzzzzzzzzzzzzzzzzzzr_, "day");
                bool? qzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(InitialHipAssessmentOblique is null));
                bool? qzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzzzzzzzzzzzt_);

                return qzzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzzt_, pzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzw_(CqlDate InitialHipAssessmentOblique) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(pzzzzzzzzzzzzzzzzzzzzzzzv_, pzzzzzzzzzzzzzzzzzzzzzzzw_);

            return pzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(pzzzzzzzzzzzzzzzzzzzzzzzk_, pzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzzzzzzzzzzzzzzn_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Date_VR12_Oblique_Total_Assessment_Completed(context);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzw_(CqlDate FollowUpHipAssessmentOblique)
            {
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentOblique);
                CqlDate rzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.End(TotalHip);
                CqlDate rzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlQuantity rzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(300m, "days");
                CqlDate rzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Add(rzzzzzzzzzzzzzzzzzzzzzzzd_, rzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDate rzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlQuantity rzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(425m, "days");
                CqlDate rzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Add(rzzzzzzzzzzzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDate> rzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzzzzzzzzf_, rzzzzzzzzzzzzzzzzzzzzzzzj_, true, true);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDate>(rzzzzzzzzzzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzzzzzzzzzzk_, "day");

                return rzzzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<CqlDate>(qzzzzzzzzzzzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzy_(CqlDate FollowUpHipAssessmentOblique) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> qzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(qzzzzzzzzzzzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzzzzzzzzzzzy_);

            return qzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(pzzzzzzzzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(pzzzzzzzzzzzzzzzzzzzzzzzo_);

        return pzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Date VR12 Orthogonal Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR12_Orthogonal_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode rzzzzzzzzzzzzzzzzzzzzzzzm_ = this.VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> rzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ToList<CqlCode>(rzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, rzzzzzzzzzzzzzzzzzzzzzzzn_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzp_ = Status_1_8_000.Instance.isAssessmentPerformed(context, rzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlCode rzzzzzzzzzzzzzzzzzzzzzzzq_ = this.VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> rzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ToList<CqlCode>(rzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, rzzzzzzzzzzzzzzzzzzzzzzzr_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzt_ = Status_1_8_000.Instance.isAssessmentPerformed(context, rzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<ValueTuple<Observation, Observation>> rzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.CrossJoin<Observation, Observation>(rzzzzzzzzzzzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzzzzzzzzzzzt_);
        (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? rzzzzzzzzzzzzzzzzzzzzzzzv_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? szzzzzzzzzzzzzzzzzzzzzzzc_ = (CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH, _valueTuple.Item1, _valueTuple.Item2);

            return szzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> rzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(rzzzzzzzzzzzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzx_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType szzzzzzzzzzzzzzzzzzzzzzzd_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object szzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDate szzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzzzzzzzzg_);
            DataType szzzzzzzzzzzzzzzzzzzzzzzi_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object szzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDate szzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SameAs(szzzzzzzzzzzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzzzzzzzzzzm_, "day");
            DataType szzzzzzzzzzzzzzzzzzzzzzzo_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Value;
            object szzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzzzzzzzzp_ is null));
            bool? szzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzzzzzzzzzzq_);
            DataType szzzzzzzzzzzzzzzzzzzzzzzs_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Value;
            object szzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzzzzzzzzt_ is null));
            bool? szzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzr_, szzzzzzzzzzzzzzzzzzzzzzzu_);

            return szzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> rzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(rzzzzzzzzzzzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzzzzzzzzzzzx_);
        CqlDate rzzzzzzzzzzzzzzzzzzzzzzzz_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType szzzzzzzzzzzzzzzzzzzzzzzw_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object szzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzzzzzzzzz_);
            DataType tzzzzzzzzzzzzzzzzzzzzzzzb_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object tzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDate[] tzzzzzzzzzzzzzzzzzzzzzzzg_ = [
                tzzzzzzzzzzzzzzzzzzzzzzza_,
                tzzzzzzzzzzzzzzzzzzzzzzzf_,
            ];
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Max<CqlDate>(tzzzzzzzzzzzzzzzzzzzzzzzg_ as IEnumerable<CqlDate>);

            return tzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<CqlDate> szzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?, CqlDate>(rzzzzzzzzzzzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<CqlDate> szzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Distinct<CqlDate>(szzzzzzzzzzzzzzzzzzzzzzza_);

        return szzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up VR12 Orthogonal Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments(CqlContext context)
    {
        IEnumerable<Procedure> tzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Total_Hip_Arthroplasty_Procedure(context);
        CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzj_(Procedure THAProcedure)
        {
            DataType tzzzzzzzzzzzzzzzzzzzzzzzr_ = THAProcedure?.Performed;
            object tzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzs_);

            return tzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> tzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(tzzzzzzzzzzzzzzzzzzzzzzzi_, tzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<CqlInterval<CqlDateTime>> tzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(tzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<CqlInterval<CqlDateTime>> tzzzzzzzzzzzzzzzzzzzzzzzm_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> tzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Date_VR12_Orthogonal_Total_Assessment_Completed(context);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzv_(CqlDate InitialHipAssessmentOrthogonal)
            {
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(TotalHip);
                CqlQuantity uzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(90m, "days");
                CqlDate uzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Add(InitialHipAssessmentOrthogonal, uzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDate> uzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(InitialHipAssessmentOrthogonal, uzzzzzzzzzzzzzzzzzzzzzzzb_, true, true);
                CqlDate uzzzzzzzzzzzzzzzzzzzzzzzd_ = uzzzzzzzzzzzzzzzzzzzzzzzc_?.low;
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertDateToDateTime(uzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDate uzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Add(InitialHipAssessmentOrthogonal, uzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDate> uzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(InitialHipAssessmentOrthogonal, uzzzzzzzzzzzzzzzzzzzzzzzg_, true, true);
                CqlDate uzzzzzzzzzzzzzzzzzzzzzzzi_ = uzzzzzzzzzzzzzzzzzzzzzzzh_?.high;
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertDateToDateTime(uzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDate uzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Add(InitialHipAssessmentOrthogonal, uzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDate> uzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(InitialHipAssessmentOrthogonal, uzzzzzzzzzzzzzzzzzzzzzzzl_, true, true);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzn_ = uzzzzzzzzzzzzzzzzzzzzzzzm_?.lowClosed;
                CqlDate uzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Add(InitialHipAssessmentOrthogonal, uzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDate> uzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(InitialHipAssessmentOrthogonal, uzzzzzzzzzzzzzzzzzzzzzzzp_, true, true);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzr_ = uzzzzzzzzzzzzzzzzzzzzzzzq_?.highClosed;
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(uzzzzzzzzzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzzzzzzzzr_);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzz_, uzzzzzzzzzzzzzzzzzzzzzzzs_, "day");
                bool? uzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(InitialHipAssessmentOrthogonal is null));
                bool? uzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzt_, uzzzzzzzzzzzzzzzzzzzzzzzu_);

                return uzzzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<CqlDate> tzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<CqlDate>(tzzzzzzzzzzzzzzzzzzzzzzzu_, tzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzx_(CqlDate InitialHipAssessmentOrthogonal) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> tzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(tzzzzzzzzzzzzzzzzzzzzzzzw_, tzzzzzzzzzzzzzzzzzzzzzzzx_);

            return tzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> tzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(tzzzzzzzzzzzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<CqlInterval<CqlDateTime>> tzzzzzzzzzzzzzzzzzzzzzzzo_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> uzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Date_VR12_Orthogonal_Total_Assessment_Completed(context);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzx_(CqlDate FollowUpHipAssessmentOrthogonal)
            {
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentOrthogonal);
                CqlDate vzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.End(TotalHip);
                CqlDate vzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlQuantity vzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(300m, "days");
                CqlDate vzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Add(vzzzzzzzzzzzzzzzzzzzzzzze_, vzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDate vzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlQuantity vzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(425m, "days");
                CqlDate vzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Add(vzzzzzzzzzzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzzzzzzzg_, vzzzzzzzzzzzzzzzzzzzzzzzk_, true, true);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDate>(vzzzzzzzzzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzzzzzzzzzl_, "day");

                return vzzzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<CqlDate> uzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<CqlDate>(uzzzzzzzzzzzzzzzzzzzzzzzw_, uzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzz_(CqlDate FollowUpHipAssessmentOrthogonal) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> vzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(uzzzzzzzzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzzzzzzzzz_);

            return vzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> tzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(tzzzzzzzzzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(tzzzzzzzzzzzzzzzzzzzzzzzp_);

        return tzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? vzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Or(vzzzzzzzzzzzzzzzzzzzzzzzn_, vzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(vzzzzzzzzzzzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Or(vzzzzzzzzzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(vzzzzzzzzzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzzzzzzzzzu_);

        return vzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_DDTAOdcFieSJbGgRLLZPYbGQb = new(
        [typeof(Observation), typeof(Observation)],
        ["PROMIS10MentalScore", "PROMIS10PhysicalScore"]);

    private static CqlTupleMetadata CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH = new(
        [typeof(Observation), typeof(Observation)],
        ["VR12MentalAssessment", "VR12PhysicalAssessment"]);

    private static CqlTupleMetadata CqlTupleMetadata_GVNUVHGXYWXVGgfjdTEahUfhP = new(
        [typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation)],
        ["HOOSLifeQuality", "HOOSSport", "HOOSActivityScore", "HOOSSymptoms", "HOOSPain"]);

    #endregion CqlTupleMetadata Properties

}
