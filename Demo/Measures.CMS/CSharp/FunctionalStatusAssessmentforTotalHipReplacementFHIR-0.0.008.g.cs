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
        CqlDateTime xzzzzzzzzzzzzzzzc_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime xzzzzzzzzzzzzzzzd_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzze_ = context.Operators.Interval(xzzzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzzzd_, true, true);
        object xzzzzzzzzzzzzzzzf_ = context.ResolveParameter("FunctionalStatusAssessmentforTotalHipReplacementFHIR-0.0.008", "Measurement Period", xzzzzzzzzzzzzzzze_);

        return (CqlInterval<CqlDateTime>)xzzzzzzzzzzzzzzzf_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> xzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient xzzzzzzzzzzzzzzzh_ = context.Operators.SingletonFrom<Patient>(xzzzzzzzzzzzzzzzg_);

        return xzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? xzzzzzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return xzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Payer Type")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Type(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> xzzzzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return xzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? xzzzzzzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return xzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode xzzzzzzzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return xzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("August 1 Year Prior to the Measurement Period")]
    public CqlDateTime August_1_Year_Prior_to_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
        CqlDateTime xzzzzzzzzzzzzzzzn_ = context.Operators.Start(xzzzzzzzzzzzzzzzm_);
        int? xzzzzzzzzzzzzzzzo_ = context.Operators.DateTimeComponentFrom(xzzzzzzzzzzzzzzzn_, "year");
        int? xzzzzzzzzzzzzzzzp_ = context.Operators.Subtract(xzzzzzzzzzzzzzzzo_, 1);
        decimal? xzzzzzzzzzzzzzzzq_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime xzzzzzzzzzzzzzzzr_ = context.Operators.DateTime(xzzzzzzzzzzzzzzzp_, 8, 1, 0, 0, 0, 0, xzzzzzzzzzzzzzzzq_);

        return xzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Has Qualifying Encounter")]
    public bool? Has_Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzs_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet xzzzzzzzzzzzzzzzu_ = this.Office_Visit(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzzv_);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? xzzzzzzzzzzzzzzzy_(Encounter E)
        {
            List<CodeableConcept> yzzzzzzzzzzzzzzzl_ = E?.Type;
            CqlConcept yzzzzzzzzzzzzzzzm_(CodeableConcept @this)
            {
                CqlConcept yzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return yzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<CqlConcept> yzzzzzzzzzzzzzzzn_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)yzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzm_);
            bool? yzzzzzzzzzzzzzzzo_(CqlConcept T)
            {
                CqlCode yzzzzzzzzzzzzzzzs_ = this.Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure(context);
                CqlConcept yzzzzzzzzzzzzzzzt_ = context.Operators.ConvertCodeToConcept(yzzzzzzzzzzzzzzzs_);
                bool? yzzzzzzzzzzzzzzzu_ = context.Operators.Equivalent(T, yzzzzzzzzzzzzzzzt_);

                return yzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<CqlConcept> yzzzzzzzzzzzzzzzp_ = context.Operators.Where<CqlConcept>(yzzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzzo_);
            bool? yzzzzzzzzzzzzzzzq_ = context.Operators.Exists<CqlConcept>(yzzzzzzzzzzzzzzzp_);

            return yzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(xzzzzzzzzzzzzzzzx_, xzzzzzzzzzzzzzzzy_);
        CqlValueSet yzzzzzzzzzzzzzzza_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzc_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzzzzz_, yzzzzzzzzzzzzzzzb_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzzzzw_, yzzzzzzzzzzzzzzzc_);
        CqlValueSet yzzzzzzzzzzzzzzze_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzzf_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzh_ = Status_1_8_000.Instance.isEncounterPerformed(context, yzzzzzzzzzzzzzzzg_);
        bool? yzzzzzzzzzzzzzzzi_(Encounter ValidEncounters)
        {
            CqlDateTime yzzzzzzzzzzzzzzzv_ = this.August_1_Year_Prior_to_the_Measurement_Period(context);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            CqlDateTime yzzzzzzzzzzzzzzzx_ = context.Operators.End(yzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzy_ = context.Operators.Interval(yzzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzzx_, true, true);
            Period yzzzzzzzzzzzzzzzz_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzzza_ as object);
            bool? zzzzzzzzzzzzzzzzc_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(yzzzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzzzb_, "day");

            return zzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzi_);
        bool? yzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Encounter>(yzzzzzzzzzzzzzzzj_);

        return yzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("November 1 Two Years Prior to the Measurement Period")]
    public CqlDateTime November_1_Two_Years_Prior_to_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
        CqlDateTime zzzzzzzzzzzzzzzze_ = context.Operators.Start(zzzzzzzzzzzzzzzzd_);
        int? zzzzzzzzzzzzzzzzf_ = context.Operators.DateTimeComponentFrom(zzzzzzzzzzzzzzzze_, "year");
        int? zzzzzzzzzzzzzzzzg_ = context.Operators.Subtract(zzzzzzzzzzzzzzzzf_, 2);
        decimal? zzzzzzzzzzzzzzzzh_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime zzzzzzzzzzzzzzzzi_ = context.Operators.DateTime(zzzzzzzzzzzzzzzzg_, 11, 1, 0, 0, 0, 0, zzzzzzzzzzzzzzzzh_);

        return zzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("October 31 Year Prior to the Measurement Period")]
    public CqlDateTime October_31_Year_Prior_to_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
        CqlDateTime zzzzzzzzzzzzzzzzk_ = context.Operators.Start(zzzzzzzzzzzzzzzzj_);
        int? zzzzzzzzzzzzzzzzl_ = context.Operators.DateTimeComponentFrom(zzzzzzzzzzzzzzzzk_, "year");
        int? zzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(zzzzzzzzzzzzzzzzl_, 1);
        decimal? zzzzzzzzzzzzzzzzn_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime zzzzzzzzzzzzzzzzo_ = context.Operators.DateTime(zzzzzzzzzzzzzzzzm_, 10, 31, 23, 59, 59, 0, zzzzzzzzzzzzzzzzn_);

        return zzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Total Hip Arthroplasty Procedure")]
    public IEnumerable<Procedure> Total_Hip_Arthroplasty_Procedure(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzzzp_ = this.Primary_THA_Procedure(context);
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzr_ = Status_1_8_000.Instance.isProcedurePerformed(context, zzzzzzzzzzzzzzzzq_);
        bool? zzzzzzzzzzzzzzzzs_(Procedure THAProcedure)
        {
            DataType zzzzzzzzzzzzzzzzu_ = THAProcedure?.Performed;
            object zzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzzzv_);
            CqlDateTime zzzzzzzzzzzzzzzzx_ = context.Operators.Start(zzzzzzzzzzzzzzzzw_);
            CqlDateTime zzzzzzzzzzzzzzzzy_ = this.November_1_Two_Years_Prior_to_the_Measurement_Period(context);
            CqlDateTime zzzzzzzzzzzzzzzzz_ = this.October_31_Year_Prior_to_the_Measurement_Period(context);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzza_ = context.Operators.Interval(zzzzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzzzz_, true, true);
            bool? azzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzza_, "day");

            return azzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzt_ = context.Operators.Where<Procedure>(zzzzzzzzzzzzzzzzr_, zzzzzzzzzzzzzzzzs_);

        return zzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? azzzzzzzzzzzzzzzzc_ = this.Has_Qualifying_Encounter(context);
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzd_ = this.Total_Hip_Arthroplasty_Procedure(context);
        bool? azzzzzzzzzzzzzzzze_ = context.Operators.Exists<Procedure>(azzzzzzzzzzzzzzzzd_);
        bool? azzzzzzzzzzzzzzzzf_ = context.Operators.And(azzzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzze_);
        Patient azzzzzzzzzzzzzzzzg_ = this.Patient(context);
        Date azzzzzzzzzzzzzzzzh_ = azzzzzzzzzzzzzzzzg_?.BirthDateElement;
        string azzzzzzzzzzzzzzzzi_ = azzzzzzzzzzzzzzzzh_?.Value;
        CqlDate azzzzzzzzzzzzzzzzj_ = context.Operators.ConvertStringToDate(azzzzzzzzzzzzzzzzi_);
        CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
        CqlDateTime azzzzzzzzzzzzzzzzl_ = context.Operators.Start(azzzzzzzzzzzzzzzzk_);
        CqlDate azzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzl_);
        int? azzzzzzzzzzzzzzzzn_ = context.Operators.CalculateAgeAt(azzzzzzzzzzzzzzzzj_, azzzzzzzzzzzzzzzzm_, "year");
        bool? azzzzzzzzzzzzzzzzo_ = context.Operators.GreaterOrEqual(azzzzzzzzzzzzzzzzn_, 19);
        bool? azzzzzzzzzzzzzzzzp_ = context.Operators.And(azzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzo_);

        return azzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? azzzzzzzzzzzzzzzzq_ = this.Initial_Population(context);

        return azzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Has Severe Cognitive Impairment")]
    public bool? Has_Severe_Cognitive_Impairment(CqlContext context)
    {
        CqlCode azzzzzzzzzzzzzzzzr_ = this.Severe_cognitive_impairment__finding_(context);
        IEnumerable<CqlCode> azzzzzzzzzzzzzzzzs_ = context.Operators.ToList<CqlCode>(azzzzzzzzzzzzzzzzr_);
        IEnumerable<Condition> azzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, azzzzzzzzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? azzzzzzzzzzzzzzzzu_(Condition Dementia)
        {
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Dementia);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
            bool? azzzzzzzzzzzzzzzzz_ = context.Operators.Overlaps(azzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzzy_, "day");

            return azzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Condition> azzzzzzzzzzzzzzzzv_ = context.Operators.Where<Condition>(azzzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzzu_);
        bool? azzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Condition>(azzzzzzzzzzzzzzzzv_);

        return azzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Has Total Hip Arthroplasty with 1 or More Lower Body Fractures")]
    public bool? Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures(CqlContext context)
    {
        IEnumerable<Procedure> bzzzzzzzzzzzzzzzza_ = this.Total_Hip_Arthroplasty_Procedure(context);
        IEnumerable<Procedure> bzzzzzzzzzzzzzzzzb_(Procedure THAProcedure)
        {
            CqlValueSet bzzzzzzzzzzzzzzzze_ = this.Lower_Body_Fractures_Excluding_Ankle_and_Foot(context);
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? bzzzzzzzzzzzzzzzzg_(Condition LowerBodyFracture)
            {
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, LowerBodyFracture);
                CqlDateTime bzzzzzzzzzzzzzzzzl_ = context.Operators.Start(bzzzzzzzzzzzzzzzzk_);
                DataType bzzzzzzzzzzzzzzzzm_ = THAProcedure?.Performed;
                object bzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzn_);
                CqlDateTime bzzzzzzzzzzzzzzzzp_ = context.Operators.Start(bzzzzzzzzzzzzzzzzo_);
                CqlQuantity bzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime bzzzzzzzzzzzzzzzzr_ = context.Operators.Subtract(bzzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzzq_);
                object bzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzt_);
                CqlDateTime bzzzzzzzzzzzzzzzzv_ = context.Operators.Start(bzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(bzzzzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzzzv_, true, true);
                bool? bzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzl_, bzzzzzzzzzzzzzzzzw_, default);
                object bzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzz_);
                CqlDateTime czzzzzzzzzzzzzzzzb_ = context.Operators.Start(czzzzzzzzzzzzzzzza_);
                bool? czzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzb_ is null));
                bool? czzzzzzzzzzzzzzzzd_ = context.Operators.And(bzzzzzzzzzzzzzzzzx_, czzzzzzzzzzzzzzzzc_);

                return czzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Condition>(bzzzzzzzzzzzzzzzzf_, bzzzzzzzzzzzzzzzzg_);
            Procedure bzzzzzzzzzzzzzzzzi_(Condition LowerBodyFracture) =>
                THAProcedure;
            IEnumerable<Procedure> bzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Condition, Procedure>(bzzzzzzzzzzzzzzzzh_, bzzzzzzzzzzzzzzzzi_);

            return bzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Procedure> bzzzzzzzzzzzzzzzzc_ = context.Operators.SelectMany<Procedure, Procedure>(bzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzb_);
        bool? bzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<Procedure>(bzzzzzzzzzzzzzzzzc_);

        return bzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Has Partial Hip Arthroplasty Procedure")]
    public bool? Has_Partial_Hip_Arthroplasty_Procedure(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzze_ = this.Partial_Arthroplasty_of_Hip(context);
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, czzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzg_ = Status_1_8_000.Instance.isProcedurePerformed(context, czzzzzzzzzzzzzzzzf_);
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzh_(Procedure PartialTHAProcedure)
        {
            IEnumerable<Procedure> czzzzzzzzzzzzzzzzk_ = this.Total_Hip_Arthroplasty_Procedure(context);
            bool? czzzzzzzzzzzzzzzzl_(Procedure THAProcedure)
            {
                DataType czzzzzzzzzzzzzzzzp_ = THAProcedure?.Performed;
                object czzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzq_);
                DataType czzzzzzzzzzzzzzzzs_ = PartialTHAProcedure?.Performed;
                object czzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzt_);
                bool? czzzzzzzzzzzzzzzzv_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(czzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzu_, "day");

                return czzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Procedure> czzzzzzzzzzzzzzzzm_ = context.Operators.Where<Procedure>(czzzzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzzzl_);
            Procedure czzzzzzzzzzzzzzzzn_(Procedure THAProcedure) =>
                PartialTHAProcedure;
            IEnumerable<Procedure> czzzzzzzzzzzzzzzzo_ = context.Operators.Select<Procedure, Procedure>(czzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzn_);

            return czzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzi_ = context.Operators.SelectMany<Procedure, Procedure>(czzzzzzzzzzzzzzzzg_, czzzzzzzzzzzzzzzzh_);
        bool? czzzzzzzzzzzzzzzzj_ = context.Operators.Exists<Procedure>(czzzzzzzzzzzzzzzzi_);

        return czzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Has Revision Hip Arthroplasty Procedure or Implanted Device or Prosthesis Removal Procedure")]
    public bool? Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure(CqlContext context)
    {
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzw_ = this.Total_Hip_Arthroplasty_Procedure(context);
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzx_(Procedure THAProcedure)
        {
            CqlValueSet dzzzzzzzzzzzzzzzza_ = this.Removal__Revision_and_Supplement_Procedures_of_the_Lower_Body_and_Spine(context);
            IEnumerable<Procedure> dzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> dzzzzzzzzzzzzzzzzc_ = Status_1_8_000.Instance.isProcedurePerformed(context, dzzzzzzzzzzzzzzzzb_);
            bool? dzzzzzzzzzzzzzzzzd_(Procedure RevisionTHAProcedure)
            {
                DataType dzzzzzzzzzzzzzzzzh_ = THAProcedure?.Performed;
                object dzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzi_);
                DataType dzzzzzzzzzzzzzzzzk_ = RevisionTHAProcedure?.Performed;
                object dzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzl_);
                bool? dzzzzzzzzzzzzzzzzn_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(dzzzzzzzzzzzzzzzzj_, dzzzzzzzzzzzzzzzzm_, "day");

                return dzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Procedure> dzzzzzzzzzzzzzzzze_ = context.Operators.Where<Procedure>(dzzzzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzzzzd_);
            Procedure dzzzzzzzzzzzzzzzzf_(Procedure RevisionTHAProcedure) =>
                THAProcedure;
            IEnumerable<Procedure> dzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Procedure, Procedure>(dzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzf_);

            return dzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzy_ = context.Operators.SelectMany<Procedure, Procedure>(czzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzx_);
        bool? czzzzzzzzzzzzzzzzz_ = context.Operators.Exists<Procedure>(czzzzzzzzzzzzzzzzy_);

        return czzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Has Malignant Neoplasm of Lower and Unspecified Limbs")]
    public bool? Has_Malignant_Neoplasm_of_Lower_and_Unspecified_Limbs(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzzzzo_ = this.Malignant_Neoplasms_of_Lower_and_Unspecified_Limbs(context);
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzq_(Condition MalignantNeoplasm)
        {
            IEnumerable<Procedure> dzzzzzzzzzzzzzzzzt_ = this.Total_Hip_Arthroplasty_Procedure(context);
            bool? dzzzzzzzzzzzzzzzzu_(Procedure THAProcedure)
            {
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MalignantNeoplasm);
                DataType dzzzzzzzzzzzzzzzzz_ = THAProcedure?.Performed;
                object ezzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzza_);
                bool? ezzzzzzzzzzzzzzzzc_ = context.Operators.Overlaps(dzzzzzzzzzzzzzzzzy_, ezzzzzzzzzzzzzzzzb_, "day");

                return ezzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Procedure> dzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Procedure>(dzzzzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzzzzu_);
            Condition dzzzzzzzzzzzzzzzzw_(Procedure THAProcedure) =>
                MalignantNeoplasm;
            IEnumerable<Condition> dzzzzzzzzzzzzzzzzx_ = context.Operators.Select<Procedure, Condition>(dzzzzzzzzzzzzzzzzv_, dzzzzzzzzzzzzzzzzw_);

            return dzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzr_ = context.Operators.SelectMany<Condition, Condition>(dzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzq_);
        bool? dzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<Condition>(dzzzzzzzzzzzzzzzzr_);

        return dzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Has Mechanical Complication")]
    public bool? Has_Mechanical_Complication(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzzd_ = this.Mechanical_Complications_Excluding_Upper_Body(context);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzf_(Condition MechanicalComplications)
        {
            IEnumerable<Procedure> ezzzzzzzzzzzzzzzzi_ = this.Total_Hip_Arthroplasty_Procedure(context);
            bool? ezzzzzzzzzzzzzzzzj_(Procedure THAProcedure)
            {
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MechanicalComplications);
                DataType ezzzzzzzzzzzzzzzzo_ = THAProcedure?.Performed;
                object ezzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzzp_);
                bool? ezzzzzzzzzzzzzzzzr_ = context.Operators.Overlaps(ezzzzzzzzzzzzzzzzn_, ezzzzzzzzzzzzzzzzq_, "day");

                return ezzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Procedure> ezzzzzzzzzzzzzzzzk_ = context.Operators.Where<Procedure>(ezzzzzzzzzzzzzzzzi_, ezzzzzzzzzzzzzzzzj_);
            Condition ezzzzzzzzzzzzzzzzl_(Procedure THAProcedure) =>
                MechanicalComplications;
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzm_ = context.Operators.Select<Procedure, Condition>(ezzzzzzzzzzzzzzzzk_, ezzzzzzzzzzzzzzzzl_);

            return ezzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzg_ = context.Operators.SelectMany<Condition, Condition>(ezzzzzzzzzzzzzzzze_, ezzzzzzzzzzzzzzzzf_);
        bool? ezzzzzzzzzzzzzzzzh_ = context.Operators.Exists<Condition>(ezzzzzzzzzzzzzzzzg_);

        return ezzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Has More Than One Elective Primary Total Hip Arthroplasty Performed")]
    public bool? Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed(CqlContext context)
    {
        IEnumerable<Procedure> ezzzzzzzzzzzzzzzzs_ = this.Total_Hip_Arthroplasty_Procedure(context);
        IEnumerable<Procedure> ezzzzzzzzzzzzzzzzt_(Procedure THAProcedure)
        {
            CqlValueSet ezzzzzzzzzzzzzzzzw_ = this.Primary_THA_Procedure(context);
            IEnumerable<Procedure> ezzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> ezzzzzzzzzzzzzzzzy_ = Status_1_8_000.Instance.isProcedurePerformed(context, ezzzzzzzzzzzzzzzzx_);
            bool? ezzzzzzzzzzzzzzzzz_(Procedure ElectiveTHAProcedure)
            {
                Id fzzzzzzzzzzzzzzzzd_ = THAProcedure?.IdElement;
                string fzzzzzzzzzzzzzzzze_ = fzzzzzzzzzzzzzzzzd_?.Value;
                Id fzzzzzzzzzzzzzzzzf_ = ElectiveTHAProcedure?.IdElement;
                string fzzzzzzzzzzzzzzzzg_ = fzzzzzzzzzzzzzzzzf_?.Value;
                bool? fzzzzzzzzzzzzzzzzh_ = context.Operators.Equivalent(fzzzzzzzzzzzzzzzze_, fzzzzzzzzzzzzzzzzg_);
                bool? fzzzzzzzzzzzzzzzzi_ = context.Operators.Not(fzzzzzzzzzzzzzzzzh_);
                DataType fzzzzzzzzzzzzzzzzj_ = ElectiveTHAProcedure?.Performed;
                object fzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzk_);
                CqlDateTime fzzzzzzzzzzzzzzzzm_ = context.Operators.Start(fzzzzzzzzzzzzzzzzl_);
                DataType fzzzzzzzzzzzzzzzzn_ = THAProcedure?.Performed;
                object fzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzo_);
                CqlDateTime fzzzzzzzzzzzzzzzzq_ = context.Operators.Start(fzzzzzzzzzzzzzzzzp_);
                CqlQuantity fzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(1m, "year");
                CqlDateTime fzzzzzzzzzzzzzzzzs_ = context.Operators.Subtract(fzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzr_);
                object fzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzu_);
                CqlDateTime fzzzzzzzzzzzzzzzzw_ = context.Operators.Start(fzzzzzzzzzzzzzzzzv_);
                CqlDateTime fzzzzzzzzzzzzzzzzy_ = context.Operators.Add(fzzzzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzzzy_, true, true);
                bool? gzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzzzzz_, "day");
                bool? gzzzzzzzzzzzzzzzzb_ = context.Operators.And(fzzzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzzza_);

                return gzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Procedure> fzzzzzzzzzzzzzzzza_ = context.Operators.Where<Procedure>(ezzzzzzzzzzzzzzzzy_, ezzzzzzzzzzzzzzzzz_);
            Procedure fzzzzzzzzzzzzzzzzb_(Procedure ElectiveTHAProcedure) =>
                THAProcedure;
            IEnumerable<Procedure> fzzzzzzzzzzzzzzzzc_ = context.Operators.Select<Procedure, Procedure>(fzzzzzzzzzzzzzzzza_, fzzzzzzzzzzzzzzzzb_);

            return fzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Procedure> ezzzzzzzzzzzzzzzzu_ = context.Operators.SelectMany<Procedure, Procedure>(ezzzzzzzzzzzzzzzzs_, ezzzzzzzzzzzzzzzzt_);
        bool? ezzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Procedure>(ezzzzzzzzzzzzzzzzu_);

        return ezzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Death Within 300 Days of the THA Procedure")]
    public bool? Death_Within_300_Days_of_the_THA_Procedure(CqlContext context)
    {
        IEnumerable<Procedure> gzzzzzzzzzzzzzzzzc_ = this.Total_Hip_Arthroplasty_Procedure(context);
        bool? gzzzzzzzzzzzzzzzzd_(Procedure THAProcedure)
        {
            Patient gzzzzzzzzzzzzzzzzg_ = this.Patient(context);
            DataType gzzzzzzzzzzzzzzzzh_ = gzzzzzzzzzzzzzzzzg_?.Deceased;
            object gzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzh_);
            CqlDate gzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzi_ as CqlDateTime);
            DataType gzzzzzzzzzzzzzzzzk_ = THAProcedure?.Performed;
            object gzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzl_);
            CqlDateTime gzzzzzzzzzzzzzzzzn_ = context.Operators.Start(gzzzzzzzzzzzzzzzzm_);
            CqlDate gzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzn_);
            object gzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzq_);
            CqlDateTime gzzzzzzzzzzzzzzzzs_ = context.Operators.Start(gzzzzzzzzzzzzzzzzr_);
            CqlDate gzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzs_);
            CqlQuantity gzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(300m, "days");
            CqlDate gzzzzzzzzzzzzzzzzv_ = context.Operators.Add(gzzzzzzzzzzzzzzzzt_, gzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDate> gzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzzzzv_, true, true);
            bool? gzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDate>(gzzzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzzzw_, "day");

            return gzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Procedure> gzzzzzzzzzzzzzzzze_ = context.Operators.Where<Procedure>(gzzzzzzzzzzzzzzzzc_, gzzzzzzzzzzzzzzzzd_);
        bool? gzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<Procedure>(gzzzzzzzzzzzzzzzze_);

        return gzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? gzzzzzzzzzzzzzzzzy_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? gzzzzzzzzzzzzzzzzz_ = this.Has_Severe_Cognitive_Impairment(context);
        bool? hzzzzzzzzzzzzzzzza_ = context.Operators.Or(gzzzzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzzzzz_);
        bool? hzzzzzzzzzzzzzzzzb_ = this.Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures(context);
        bool? hzzzzzzzzzzzzzzzzc_ = context.Operators.Or(hzzzzzzzzzzzzzzzza_, hzzzzzzzzzzzzzzzzb_);
        bool? hzzzzzzzzzzzzzzzzd_ = this.Has_Partial_Hip_Arthroplasty_Procedure(context);
        bool? hzzzzzzzzzzzzzzzze_ = context.Operators.Or(hzzzzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzzzzd_);
        bool? hzzzzzzzzzzzzzzzzf_ = this.Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure(context);
        bool? hzzzzzzzzzzzzzzzzg_ = context.Operators.Or(hzzzzzzzzzzzzzzzze_, hzzzzzzzzzzzzzzzzf_);
        bool? hzzzzzzzzzzzzzzzzh_ = this.Has_Malignant_Neoplasm_of_Lower_and_Unspecified_Limbs(context);
        bool? hzzzzzzzzzzzzzzzzi_ = context.Operators.Or(hzzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzzh_);
        bool? hzzzzzzzzzzzzzzzzj_ = this.Has_Mechanical_Complication(context);
        bool? hzzzzzzzzzzzzzzzzk_ = context.Operators.Or(hzzzzzzzzzzzzzzzzi_, hzzzzzzzzzzzzzzzzj_);
        bool? hzzzzzzzzzzzzzzzzl_ = this.Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed(context);
        bool? hzzzzzzzzzzzzzzzzm_ = context.Operators.Or(hzzzzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzzzzl_);
        bool? hzzzzzzzzzzzzzzzzn_ = this.Death_Within_300_Days_of_the_THA_Procedure(context);
        bool? hzzzzzzzzzzzzzzzzo_ = context.Operators.Or(hzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzn_);

        return hzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Date HOOS Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_HOOS_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode hzzzzzzzzzzzzzzzzp_ = this.Quality_of_life_score__HOOS_(context);
        IEnumerable<CqlCode> hzzzzzzzzzzzzzzzzq_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzzzzzzp_);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, hzzzzzzzzzzzzzzzzq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzs_ = Status_1_8_000.Instance.isAssessmentPerformed(context, hzzzzzzzzzzzzzzzzr_);
        CqlCode hzzzzzzzzzzzzzzzzt_ = this.Sport_recreation_score__HOOS_(context);
        IEnumerable<CqlCode> hzzzzzzzzzzzzzzzzu_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzzzzzzt_);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, hzzzzzzzzzzzzzzzzu_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzw_ = Status_1_8_000.Instance.isAssessmentPerformed(context, hzzzzzzzzzzzzzzzzv_);
        CqlCode hzzzzzzzzzzzzzzzzx_ = this.Activities_of_daily_living_score__HOOS_(context);
        IEnumerable<CqlCode> hzzzzzzzzzzzzzzzzy_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzzzzzzx_);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, hzzzzzzzzzzzzzzzzy_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> izzzzzzzzzzzzzzzza_ = Status_1_8_000.Instance.isAssessmentPerformed(context, hzzzzzzzzzzzzzzzzz_);
        CqlCode izzzzzzzzzzzzzzzzb_ = this.Symptoms_score__HOOS_(context);
        IEnumerable<CqlCode> izzzzzzzzzzzzzzzzc_ = context.Operators.ToList<CqlCode>(izzzzzzzzzzzzzzzzb_);
        IEnumerable<Observation> izzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, izzzzzzzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> izzzzzzzzzzzzzzzze_ = Status_1_8_000.Instance.isAssessmentPerformed(context, izzzzzzzzzzzzzzzzd_);
        CqlCode izzzzzzzzzzzzzzzzf_ = this.Pain_score__HOOS_(context);
        IEnumerable<CqlCode> izzzzzzzzzzzzzzzzg_ = context.Operators.ToList<CqlCode>(izzzzzzzzzzzzzzzzf_);
        IEnumerable<Observation> izzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, izzzzzzzzzzzzzzzzg_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> izzzzzzzzzzzzzzzzi_ = Status_1_8_000.Instance.isAssessmentPerformed(context, izzzzzzzzzzzzzzzzh_);
        IEnumerable<ValueTuple<Observation, Observation, Observation, Observation, Observation>> izzzzzzzzzzzzzzzzj_ = context.Operators.CrossJoin<Observation, Observation, Observation, Observation, Observation>(hzzzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzza_, izzzzzzzzzzzzzzzze_, izzzzzzzzzzzzzzzzi_);
        (CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)? izzzzzzzzzzzzzzzzk_(ValueTuple<Observation, Observation, Observation, Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)? izzzzzzzzzzzzzzzzr_ = (CqlTupleMetadata_GVNUVHGXYWXVGgfjdTEahUfhP, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4, _valueTuple.Item5);

            return izzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?> izzzzzzzzzzzzzzzzl_ = context.Operators.Select<ValueTuple<Observation, Observation, Observation, Observation, Observation>, (CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?>(izzzzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzzzk_);
        bool? izzzzzzzzzzzzzzzzm_((CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)? tuple_eipfmazvhfscjijaofhicpvmb)
        {
            DataType izzzzzzzzzzzzzzzzs_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSLifeQuality?.Effective;
            object izzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzt_);
            CqlDateTime izzzzzzzzzzzzzzzzv_ = context.Operators.Start(izzzzzzzzzzzzzzzzu_);
            CqlDate izzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(izzzzzzzzzzzzzzzzv_);
            DataType izzzzzzzzzzzzzzzzx_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSport?.Effective;
            object izzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzy_);
            CqlDateTime jzzzzzzzzzzzzzzzza_ = context.Operators.Start(izzzzzzzzzzzzzzzzz_);
            CqlDate jzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzzza_);
            bool? jzzzzzzzzzzzzzzzzc_ = context.Operators.SameAs(izzzzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzzzzb_, "day");
            DataType jzzzzzzzzzzzzzzzzd_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSport?.Value;
            object jzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzd_);
            bool? jzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzze_ is null));
            bool? jzzzzzzzzzzzzzzzzg_ = context.Operators.And(jzzzzzzzzzzzzzzzzc_, jzzzzzzzzzzzzzzzzf_);
            object jzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzi_);
            CqlDateTime jzzzzzzzzzzzzzzzzk_ = context.Operators.Start(jzzzzzzzzzzzzzzzzj_);
            CqlDate jzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzzzk_);
            DataType jzzzzzzzzzzzzzzzzm_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSActivityScore?.Effective;
            object jzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzn_);
            CqlDateTime jzzzzzzzzzzzzzzzzp_ = context.Operators.Start(jzzzzzzzzzzzzzzzzo_);
            CqlDate jzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzzzp_);
            bool? jzzzzzzzzzzzzzzzzr_ = context.Operators.SameAs(jzzzzzzzzzzzzzzzzl_, jzzzzzzzzzzzzzzzzq_, "day");
            bool? jzzzzzzzzzzzzzzzzs_ = context.Operators.And(jzzzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzzzr_);
            DataType jzzzzzzzzzzzzzzzzt_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSActivityScore?.Value;
            object jzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzt_);
            bool? jzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzu_ is null));
            bool? jzzzzzzzzzzzzzzzzw_ = context.Operators.And(jzzzzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzzzv_);
            object jzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzy_);
            CqlDateTime kzzzzzzzzzzzzzzzza_ = context.Operators.Start(jzzzzzzzzzzzzzzzzz_);
            CqlDate kzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzza_);
            DataType kzzzzzzzzzzzzzzzzc_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSymptoms?.Effective;
            object kzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzd_);
            CqlDateTime kzzzzzzzzzzzzzzzzf_ = context.Operators.Start(kzzzzzzzzzzzzzzzze_);
            CqlDate kzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzzf_);
            bool? kzzzzzzzzzzzzzzzzh_ = context.Operators.SameAs(kzzzzzzzzzzzzzzzzb_, kzzzzzzzzzzzzzzzzg_, "day");
            bool? kzzzzzzzzzzzzzzzzi_ = context.Operators.And(jzzzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzzzh_);
            DataType kzzzzzzzzzzzzzzzzj_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSymptoms?.Value;
            object kzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzj_);
            bool? kzzzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzk_ is null));
            bool? kzzzzzzzzzzzzzzzzm_ = context.Operators.And(kzzzzzzzzzzzzzzzzi_, kzzzzzzzzzzzzzzzzl_);
            object kzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzo_);
            CqlDateTime kzzzzzzzzzzzzzzzzq_ = context.Operators.Start(kzzzzzzzzzzzzzzzzp_);
            CqlDate kzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzzq_);
            DataType kzzzzzzzzzzzzzzzzs_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSPain?.Effective;
            object kzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzt_);
            CqlDateTime kzzzzzzzzzzzzzzzzv_ = context.Operators.Start(kzzzzzzzzzzzzzzzzu_);
            CqlDate kzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzzv_);
            bool? kzzzzzzzzzzzzzzzzx_ = context.Operators.SameAs(kzzzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzzzw_, "day");
            bool? kzzzzzzzzzzzzzzzzy_ = context.Operators.And(kzzzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzzzx_);
            DataType kzzzzzzzzzzzzzzzzz_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSPain?.Value;
            object lzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzz_);
            bool? lzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzza_ is null));
            bool? lzzzzzzzzzzzzzzzzc_ = context.Operators.And(kzzzzzzzzzzzzzzzzy_, lzzzzzzzzzzzzzzzzb_);
            DataType lzzzzzzzzzzzzzzzzd_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSLifeQuality?.Value;
            object lzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzd_);
            bool? lzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzze_ is null));
            bool? lzzzzzzzzzzzzzzzzg_ = context.Operators.And(lzzzzzzzzzzzzzzzzc_, lzzzzzzzzzzzzzzzzf_);

            return lzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?> izzzzzzzzzzzzzzzzn_ = context.Operators.Where<(CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?>(izzzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzzm_);
        CqlDate izzzzzzzzzzzzzzzzo_((CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)? tuple_eipfmazvhfscjijaofhicpvmb)
        {
            DataType lzzzzzzzzzzzzzzzzh_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSLifeQuality?.Effective;
            object lzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzi_);
            CqlDateTime lzzzzzzzzzzzzzzzzk_ = context.Operators.Start(lzzzzzzzzzzzzzzzzj_);
            CqlDate lzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzk_);
            DataType lzzzzzzzzzzzzzzzzm_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSport?.Effective;
            object lzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzn_);
            CqlDateTime lzzzzzzzzzzzzzzzzp_ = context.Operators.Start(lzzzzzzzzzzzzzzzzo_);
            CqlDate lzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzp_);
            DataType lzzzzzzzzzzzzzzzzr_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSActivityScore?.Effective;
            object lzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzs_);
            CqlDateTime lzzzzzzzzzzzzzzzzu_ = context.Operators.Start(lzzzzzzzzzzzzzzzzt_);
            CqlDate lzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzu_);
            DataType lzzzzzzzzzzzzzzzzw_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSymptoms?.Effective;
            object lzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzx_);
            CqlDateTime lzzzzzzzzzzzzzzzzz_ = context.Operators.Start(lzzzzzzzzzzzzzzzzy_);
            CqlDate mzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzz_);
            DataType mzzzzzzzzzzzzzzzzb_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSPain?.Effective;
            object mzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzc_);
            CqlDateTime mzzzzzzzzzzzzzzzze_ = context.Operators.Start(mzzzzzzzzzzzzzzzzd_);
            CqlDate mzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzze_);
            CqlDate[] mzzzzzzzzzzzzzzzzg_ = [
                lzzzzzzzzzzzzzzzzl_,
                lzzzzzzzzzzzzzzzzq_,
                lzzzzzzzzzzzzzzzzv_,
                mzzzzzzzzzzzzzzzza_,
                mzzzzzzzzzzzzzzzzf_,
            ];
            CqlDate mzzzzzzzzzzzzzzzzh_ = context.Operators.Max<CqlDate>(mzzzzzzzzzzzzzzzzg_ as IEnumerable<CqlDate>);

            return mzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?, CqlDate>(izzzzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzzzo_);
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<CqlDate>(izzzzzzzzzzzzzzzzp_);

        return izzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up HOOS Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments(CqlContext context)
    {
        IEnumerable<Procedure> mzzzzzzzzzzzzzzzzi_ = this.Total_Hip_Arthroplasty_Procedure(context);
        CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzj_(Procedure THAProcedure)
        {
            DataType mzzzzzzzzzzzzzzzzr_ = THAProcedure?.Performed;
            object mzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzs_);

            return mzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> mzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(mzzzzzzzzzzzzzzzzi_, mzzzzzzzzzzzzzzzzj_);
        IEnumerable<CqlInterval<CqlDateTime>> mzzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(mzzzzzzzzzzzzzzzzk_);
        IEnumerable<CqlInterval<CqlDateTime>> mzzzzzzzzzzzzzzzzm_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> mzzzzzzzzzzzzzzzzu_ = this.Date_HOOS_Total_Assessment_Completed(context);
            bool? mzzzzzzzzzzzzzzzzv_(CqlDate InitialHipAssessmentHOOS)
            {
                CqlDateTime mzzzzzzzzzzzzzzzzz_ = context.Operators.Start(TotalHip);
                CqlQuantity nzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(90m, "days");
                CqlDate nzzzzzzzzzzzzzzzzb_ = context.Operators.Add(InitialHipAssessmentHOOS, nzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDate> nzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(InitialHipAssessmentHOOS, nzzzzzzzzzzzzzzzzb_, true, true);
                CqlDate nzzzzzzzzzzzzzzzzd_ = nzzzzzzzzzzzzzzzzc_?.low;
                CqlDateTime nzzzzzzzzzzzzzzzze_ = context.Operators.ConvertDateToDateTime(nzzzzzzzzzzzzzzzzd_);
                CqlDate nzzzzzzzzzzzzzzzzg_ = context.Operators.Add(InitialHipAssessmentHOOS, nzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDate> nzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(InitialHipAssessmentHOOS, nzzzzzzzzzzzzzzzzg_, true, true);
                CqlDate nzzzzzzzzzzzzzzzzi_ = nzzzzzzzzzzzzzzzzh_?.high;
                CqlDateTime nzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertDateToDateTime(nzzzzzzzzzzzzzzzzi_);
                CqlDate nzzzzzzzzzzzzzzzzl_ = context.Operators.Add(InitialHipAssessmentHOOS, nzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDate> nzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(InitialHipAssessmentHOOS, nzzzzzzzzzzzzzzzzl_, true, true);
                bool? nzzzzzzzzzzzzzzzzn_ = nzzzzzzzzzzzzzzzzm_?.lowClosed;
                CqlDate nzzzzzzzzzzzzzzzzp_ = context.Operators.Add(InitialHipAssessmentHOOS, nzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDate> nzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(InitialHipAssessmentHOOS, nzzzzzzzzzzzzzzzzp_, true, true);
                bool? nzzzzzzzzzzzzzzzzr_ = nzzzzzzzzzzzzzzzzq_?.highClosed;
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(nzzzzzzzzzzzzzzzze_, nzzzzzzzzzzzzzzzzj_, nzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzr_);
                bool? nzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzz_, nzzzzzzzzzzzzzzzzs_, "day");
                bool? nzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(InitialHipAssessmentHOOS is null));
                bool? nzzzzzzzzzzzzzzzzv_ = context.Operators.And(nzzzzzzzzzzzzzzzzt_, nzzzzzzzzzzzzzzzzu_);

                return nzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<CqlDate> mzzzzzzzzzzzzzzzzw_ = context.Operators.Where<CqlDate>(mzzzzzzzzzzzzzzzzu_, mzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzx_(CqlDate InitialHipAssessmentHOOS) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> mzzzzzzzzzzzzzzzzy_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(mzzzzzzzzzzzzzzzzw_, mzzzzzzzzzzzzzzzzx_);

            return mzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> mzzzzzzzzzzzzzzzzn_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(mzzzzzzzzzzzzzzzzl_, mzzzzzzzzzzzzzzzzm_);
        IEnumerable<CqlInterval<CqlDateTime>> mzzzzzzzzzzzzzzzzo_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> nzzzzzzzzzzzzzzzzw_ = this.Date_HOOS_Total_Assessment_Completed(context);
            bool? nzzzzzzzzzzzzzzzzx_(CqlDate FollowUpHipAssessmentHOOS)
            {
                CqlDateTime ozzzzzzzzzzzzzzzzb_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentHOOS);
                CqlDate ozzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzb_);
                CqlDateTime ozzzzzzzzzzzzzzzzd_ = context.Operators.End(TotalHip);
                CqlDate ozzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzd_);
                CqlQuantity ozzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(300m, "days");
                CqlDate ozzzzzzzzzzzzzzzzg_ = context.Operators.Add(ozzzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzzf_);
                CqlDate ozzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzd_);
                CqlQuantity ozzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(425m, "days");
                CqlDate ozzzzzzzzzzzzzzzzk_ = context.Operators.Add(ozzzzzzzzzzzzzzzzi_, ozzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDate> ozzzzzzzzzzzzzzzzl_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzzzk_, true, true);
                bool? ozzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDate>(ozzzzzzzzzzzzzzzzc_, ozzzzzzzzzzzzzzzzl_, "day");

                return ozzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<CqlDate> nzzzzzzzzzzzzzzzzy_ = context.Operators.Where<CqlDate>(nzzzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzz_(CqlDate FollowUpHipAssessmentHOOS) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> ozzzzzzzzzzzzzzzza_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(nzzzzzzzzzzzzzzzzy_, nzzzzzzzzzzzzzzzzz_);

            return ozzzzzzzzzzzzzzzza_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> mzzzzzzzzzzzzzzzzp_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(mzzzzzzzzzzzzzzzzn_, mzzzzzzzzzzzzzzzzo_);
        bool? mzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(mzzzzzzzzzzzzzzzzp_);

        return mzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Date HOOSJr Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_HOOSJr_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode ozzzzzzzzzzzzzzzzn_ = this.Total_interval_score__HOOSJR_(context);
        IEnumerable<CqlCode> ozzzzzzzzzzzzzzzzo_ = context.Operators.ToList<CqlCode>(ozzzzzzzzzzzzzzzzn_);
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ozzzzzzzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzq_ = Status_1_8_000.Instance.isAssessmentPerformed(context, ozzzzzzzzzzzzzzzzp_);
        bool? ozzzzzzzzzzzzzzzzr_(Observation HOOSJr)
        {
            DataType ozzzzzzzzzzzzzzzzw_ = HOOSJr?.Value;
            object ozzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzw_);
            bool? ozzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzx_ is null));

            return ozzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzs_ = context.Operators.Where<Observation>(ozzzzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzzzr_);
        CqlDate ozzzzzzzzzzzzzzzzt_(Observation DocumentedHOOSJr)
        {
            DataType ozzzzzzzzzzzzzzzzz_ = DocumentedHOOSJr?.Effective;
            object pzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzza_);
            CqlDateTime pzzzzzzzzzzzzzzzzc_ = context.Operators.Start(pzzzzzzzzzzzzzzzzb_);
            CqlDate pzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzc_);

            return pzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<CqlDate> ozzzzzzzzzzzzzzzzu_ = context.Operators.Select<Observation, CqlDate>(ozzzzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzzzt_);
        IEnumerable<CqlDate> ozzzzzzzzzzzzzzzzv_ = context.Operators.Distinct<CqlDate>(ozzzzzzzzzzzzzzzzu_);

        return ozzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up HOOSJr Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments(CqlContext context)
    {
        IEnumerable<Procedure> pzzzzzzzzzzzzzzzze_ = this.Total_Hip_Arthroplasty_Procedure(context);
        CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzf_(Procedure THAProcedure)
        {
            DataType pzzzzzzzzzzzzzzzzn_ = THAProcedure?.Performed;
            object pzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzo_);

            return pzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(pzzzzzzzzzzzzzzzze_, pzzzzzzzzzzzzzzzzf_);
        IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzzzzzzzh_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(pzzzzzzzzzzzzzzzzg_);
        IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzzzzzzzi_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzq_ = this.Date_HOOSJr_Total_Assessment_Completed(context);
            bool? pzzzzzzzzzzzzzzzzr_(CqlDate InitialHipAssessment)
            {
                CqlDateTime pzzzzzzzzzzzzzzzzv_ = context.Operators.Start(TotalHip);
                CqlQuantity pzzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(90m, "days");
                CqlDate pzzzzzzzzzzzzzzzzx_ = context.Operators.Add(InitialHipAssessment, pzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDate> pzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(InitialHipAssessment, pzzzzzzzzzzzzzzzzx_, true, true);
                CqlDate pzzzzzzzzzzzzzzzzz_ = pzzzzzzzzzzzzzzzzy_?.low;
                CqlDateTime qzzzzzzzzzzzzzzzza_ = context.Operators.ConvertDateToDateTime(pzzzzzzzzzzzzzzzzz_);
                CqlDate qzzzzzzzzzzzzzzzzc_ = context.Operators.Add(InitialHipAssessment, pzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDate> qzzzzzzzzzzzzzzzzd_ = context.Operators.Interval(InitialHipAssessment, qzzzzzzzzzzzzzzzzc_, true, true);
                CqlDate qzzzzzzzzzzzzzzzze_ = qzzzzzzzzzzzzzzzzd_?.high;
                CqlDateTime qzzzzzzzzzzzzzzzzf_ = context.Operators.ConvertDateToDateTime(qzzzzzzzzzzzzzzzze_);
                CqlDate qzzzzzzzzzzzzzzzzh_ = context.Operators.Add(InitialHipAssessment, pzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDate> qzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(InitialHipAssessment, qzzzzzzzzzzzzzzzzh_, true, true);
                bool? qzzzzzzzzzzzzzzzzj_ = qzzzzzzzzzzzzzzzzi_?.lowClosed;
                CqlDate qzzzzzzzzzzzzzzzzl_ = context.Operators.Add(InitialHipAssessment, pzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDate> qzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(InitialHipAssessment, qzzzzzzzzzzzzzzzzl_, true, true);
                bool? qzzzzzzzzzzzzzzzzn_ = qzzzzzzzzzzzzzzzzm_?.highClosed;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(qzzzzzzzzzzzzzzzza_, qzzzzzzzzzzzzzzzzf_, qzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzn_);
                bool? qzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzzzzo_, "day");
                bool? qzzzzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(InitialHipAssessment is null));
                bool? qzzzzzzzzzzzzzzzzr_ = context.Operators.And(qzzzzzzzzzzzzzzzzp_, qzzzzzzzzzzzzzzzzq_);

                return qzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzs_ = context.Operators.Where<CqlDate>(pzzzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzt_(CqlDate InitialHipAssessment) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzzzzzzzu_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(pzzzzzzzzzzzzzzzzs_, pzzzzzzzzzzzzzzzzt_);

            return pzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(pzzzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzzzi_);
        IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzzzzzzzk_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzs_ = this.Date_HOOSJr_Total_Assessment_Completed(context);
            bool? qzzzzzzzzzzzzzzzzt_(CqlDate FollowUpHipAssessment)
            {
                CqlDateTime qzzzzzzzzzzzzzzzzx_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessment);
                CqlDate qzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzzzx_);
                CqlDateTime qzzzzzzzzzzzzzzzzz_ = context.Operators.End(TotalHip);
                CqlDate rzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzzzz_);
                CqlQuantity rzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(300m, "days");
                CqlDate rzzzzzzzzzzzzzzzzc_ = context.Operators.Add(rzzzzzzzzzzzzzzzza_, rzzzzzzzzzzzzzzzzb_);
                CqlDate rzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzzzz_);
                CqlQuantity rzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(425m, "days");
                CqlDate rzzzzzzzzzzzzzzzzg_ = context.Operators.Add(rzzzzzzzzzzzzzzzze_, rzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDate> rzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzc_, rzzzzzzzzzzzzzzzzg_, true, true);
                bool? rzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDate>(qzzzzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzzzzh_, "day");

                return rzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzu_ = context.Operators.Where<CqlDate>(qzzzzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzv_(CqlDate FollowUpHipAssessment) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> qzzzzzzzzzzzzzzzzw_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(qzzzzzzzzzzzzzzzzu_, qzzzzzzzzzzzzzzzzv_);

            return qzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzzzzzzzl_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(pzzzzzzzzzzzzzzzzj_, pzzzzzzzzzzzzzzzzk_);
        bool? pzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(pzzzzzzzzzzzzzzzzl_);

        return pzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Date PROMIS10 Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_PROMIS10_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode rzzzzzzzzzzzzzzzzj_ = this.PROMIS_10_Global_Mental_Health__GMH__score_T_score(context);
        IEnumerable<CqlCode> rzzzzzzzzzzzzzzzzk_ = context.Operators.ToList<CqlCode>(rzzzzzzzzzzzzzzzzj_);
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, rzzzzzzzzzzzzzzzzk_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzm_ = Status_1_8_000.Instance.isAssessmentPerformed(context, rzzzzzzzzzzzzzzzzl_);
        CqlCode rzzzzzzzzzzzzzzzzn_ = this.PROMIS_10_Global_Physical_Health__GPH__score_T_score(context);
        IEnumerable<CqlCode> rzzzzzzzzzzzzzzzzo_ = context.Operators.ToList<CqlCode>(rzzzzzzzzzzzzzzzzn_);
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, rzzzzzzzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzq_ = Status_1_8_000.Instance.isAssessmentPerformed(context, rzzzzzzzzzzzzzzzzp_);
        IEnumerable<ValueTuple<Observation, Observation>> rzzzzzzzzzzzzzzzzr_ = context.Operators.CrossJoin<Observation, Observation>(rzzzzzzzzzzzzzzzzm_, rzzzzzzzzzzzzzzzzq_);
        (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? rzzzzzzzzzzzzzzzzs_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? rzzzzzzzzzzzzzzzzz_ = (CqlTupleMetadata_DDTAOdcFieSJbGgRLLZPYbGQb, _valueTuple.Item1, _valueTuple.Item2);

            return rzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?> rzzzzzzzzzzzzzzzzt_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?>(rzzzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzzzs_);
        bool? rzzzzzzzzzzzzzzzzu_((CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? tuple_ddtaodcfiesjbggrllzpybgqb)
        {
            DataType szzzzzzzzzzzzzzzza_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Effective;
            object szzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzb_);
            CqlDateTime szzzzzzzzzzzzzzzzd_ = context.Operators.Start(szzzzzzzzzzzzzzzzc_);
            CqlDate szzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzd_);
            DataType szzzzzzzzzzzzzzzzf_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Effective;
            object szzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzg_);
            CqlDateTime szzzzzzzzzzzzzzzzi_ = context.Operators.Start(szzzzzzzzzzzzzzzzh_);
            CqlDate szzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzi_);
            bool? szzzzzzzzzzzzzzzzk_ = context.Operators.SameAs(szzzzzzzzzzzzzzzze_, szzzzzzzzzzzzzzzzj_, "day");
            DataType szzzzzzzzzzzzzzzzl_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Value;
            object szzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzl_);
            bool? szzzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzm_ is null));
            bool? szzzzzzzzzzzzzzzzo_ = context.Operators.And(szzzzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzzzn_);
            DataType szzzzzzzzzzzzzzzzp_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Value;
            object szzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzp_);
            bool? szzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzq_ is null));
            bool? szzzzzzzzzzzzzzzzs_ = context.Operators.And(szzzzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzzzr_);

            return szzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?> rzzzzzzzzzzzzzzzzv_ = context.Operators.Where<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?>(rzzzzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzzzzu_);
        CqlDate rzzzzzzzzzzzzzzzzw_((CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? tuple_ddtaodcfiesjbggrllzpybgqb)
        {
            DataType szzzzzzzzzzzzzzzzt_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Effective;
            object szzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzu_);
            CqlDateTime szzzzzzzzzzzzzzzzw_ = context.Operators.Start(szzzzzzzzzzzzzzzzv_);
            CqlDate szzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzw_);
            DataType szzzzzzzzzzzzzzzzy_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Effective;
            object szzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzz_);
            CqlDateTime tzzzzzzzzzzzzzzzzb_ = context.Operators.Start(tzzzzzzzzzzzzzzzza_);
            CqlDate tzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzb_);
            CqlDate[] tzzzzzzzzzzzzzzzzd_ = [
                szzzzzzzzzzzzzzzzx_,
                tzzzzzzzzzzzzzzzzc_,
            ];
            CqlDate tzzzzzzzzzzzzzzzze_ = context.Operators.Max<CqlDate>(tzzzzzzzzzzzzzzzzd_ as IEnumerable<CqlDate>);

            return tzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<CqlDate> rzzzzzzzzzzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?, CqlDate>(rzzzzzzzzzzzzzzzzv_, rzzzzzzzzzzzzzzzzw_);
        IEnumerable<CqlDate> rzzzzzzzzzzzzzzzzy_ = context.Operators.Distinct<CqlDate>(rzzzzzzzzzzzzzzzzx_);

        return rzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up PROMIS10 Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments(CqlContext context)
    {
        IEnumerable<Procedure> tzzzzzzzzzzzzzzzzf_ = this.Total_Hip_Arthroplasty_Procedure(context);
        CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzg_(Procedure THAProcedure)
        {
            DataType tzzzzzzzzzzzzzzzzo_ = THAProcedure?.Performed;
            object tzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzp_);

            return tzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> tzzzzzzzzzzzzzzzzh_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(tzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzg_);
        IEnumerable<CqlInterval<CqlDateTime>> tzzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(tzzzzzzzzzzzzzzzzh_);
        IEnumerable<CqlInterval<CqlDateTime>> tzzzzzzzzzzzzzzzzj_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> tzzzzzzzzzzzzzzzzr_ = this.Date_PROMIS10_Total_Assessment_Completed(context);
            bool? tzzzzzzzzzzzzzzzzs_(CqlDate InitialHipAssessmentPROMIS10)
            {
                CqlDateTime tzzzzzzzzzzzzzzzzw_ = context.Operators.Start(TotalHip);
                CqlQuantity tzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(90m, "days");
                CqlDate tzzzzzzzzzzzzzzzzy_ = context.Operators.Add(InitialHipAssessmentPROMIS10, tzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDate> tzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(InitialHipAssessmentPROMIS10, tzzzzzzzzzzzzzzzzy_, true, true);
                CqlDate uzzzzzzzzzzzzzzzza_ = tzzzzzzzzzzzzzzzzz_?.low;
                CqlDateTime uzzzzzzzzzzzzzzzzb_ = context.Operators.ConvertDateToDateTime(uzzzzzzzzzzzzzzzza_);
                CqlDate uzzzzzzzzzzzzzzzzd_ = context.Operators.Add(InitialHipAssessmentPROMIS10, tzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDate> uzzzzzzzzzzzzzzzze_ = context.Operators.Interval(InitialHipAssessmentPROMIS10, uzzzzzzzzzzzzzzzzd_, true, true);
                CqlDate uzzzzzzzzzzzzzzzzf_ = uzzzzzzzzzzzzzzzze_?.high;
                CqlDateTime uzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertDateToDateTime(uzzzzzzzzzzzzzzzzf_);
                CqlDate uzzzzzzzzzzzzzzzzi_ = context.Operators.Add(InitialHipAssessmentPROMIS10, tzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDate> uzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(InitialHipAssessmentPROMIS10, uzzzzzzzzzzzzzzzzi_, true, true);
                bool? uzzzzzzzzzzzzzzzzk_ = uzzzzzzzzzzzzzzzzj_?.lowClosed;
                CqlDate uzzzzzzzzzzzzzzzzm_ = context.Operators.Add(InitialHipAssessmentPROMIS10, tzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDate> uzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(InitialHipAssessmentPROMIS10, uzzzzzzzzzzzzzzzzm_, true, true);
                bool? uzzzzzzzzzzzzzzzzo_ = uzzzzzzzzzzzzzzzzn_?.highClosed;
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(uzzzzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzzzzk_, uzzzzzzzzzzzzzzzzo_);
                bool? uzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzw_, uzzzzzzzzzzzzzzzzp_, "day");
                bool? uzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(InitialHipAssessmentPROMIS10 is null));
                bool? uzzzzzzzzzzzzzzzzs_ = context.Operators.And(uzzzzzzzzzzzzzzzzq_, uzzzzzzzzzzzzzzzzr_);

                return uzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<CqlDate> tzzzzzzzzzzzzzzzzt_ = context.Operators.Where<CqlDate>(tzzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzu_(CqlDate InitialHipAssessmentPROMIS10) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> tzzzzzzzzzzzzzzzzv_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(tzzzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzzzu_);

            return tzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> tzzzzzzzzzzzzzzzzk_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(tzzzzzzzzzzzzzzzzi_, tzzzzzzzzzzzzzzzzj_);
        IEnumerable<CqlInterval<CqlDateTime>> tzzzzzzzzzzzzzzzzl_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> uzzzzzzzzzzzzzzzzt_ = this.Date_PROMIS10_Total_Assessment_Completed(context);
            bool? uzzzzzzzzzzzzzzzzu_(CqlDate FollowUpHipAssessmentPROMIS10)
            {
                CqlDateTime uzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentPROMIS10);
                CqlDate uzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzy_);
                CqlDateTime vzzzzzzzzzzzzzzzza_ = context.Operators.End(TotalHip);
                CqlDate vzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzza_);
                CqlQuantity vzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(300m, "days");
                CqlDate vzzzzzzzzzzzzzzzzd_ = context.Operators.Add(vzzzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzzzc_);
                CqlDate vzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzza_);
                CqlQuantity vzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(425m, "days");
                CqlDate vzzzzzzzzzzzzzzzzh_ = context.Operators.Add(vzzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDate> vzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzd_, vzzzzzzzzzzzzzzzzh_, true, true);
                bool? vzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDate>(uzzzzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzzzzi_, "day");

                return vzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<CqlDate> uzzzzzzzzzzzzzzzzv_ = context.Operators.Where<CqlDate>(uzzzzzzzzzzzzzzzzt_, uzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzw_(CqlDate FollowUpHipAssessmentPROMIS10) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> uzzzzzzzzzzzzzzzzx_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(uzzzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzzzw_);

            return uzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> tzzzzzzzzzzzzzzzzm_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(tzzzzzzzzzzzzzzzzk_, tzzzzzzzzzzzzzzzzl_);
        bool? tzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(tzzzzzzzzzzzzzzzzm_);

        return tzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Date VR12 Oblique Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR12_Oblique_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode vzzzzzzzzzzzzzzzzk_ = this.VR_12_Mental_component_summary__MCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> vzzzzzzzzzzzzzzzzl_ = context.Operators.ToList<CqlCode>(vzzzzzzzzzzzzzzzzk_);
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, vzzzzzzzzzzzzzzzzl_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzn_ = Status_1_8_000.Instance.isAssessmentPerformed(context, vzzzzzzzzzzzzzzzzm_);
        CqlCode vzzzzzzzzzzzzzzzzo_ = this.VR_12_Physical_component_summary__PCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> vzzzzzzzzzzzzzzzzp_ = context.Operators.ToList<CqlCode>(vzzzzzzzzzzzzzzzzo_);
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, vzzzzzzzzzzzzzzzzp_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzr_ = Status_1_8_000.Instance.isAssessmentPerformed(context, vzzzzzzzzzzzzzzzzq_);
        IEnumerable<ValueTuple<Observation, Observation>> vzzzzzzzzzzzzzzzzs_ = context.Operators.CrossJoin<Observation, Observation>(vzzzzzzzzzzzzzzzzn_, vzzzzzzzzzzzzzzzzr_);
        (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? vzzzzzzzzzzzzzzzzt_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? wzzzzzzzzzzzzzzzza_ = (CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH, _valueTuple.Item1, _valueTuple.Item2);

            return wzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> vzzzzzzzzzzzzzzzzu_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(vzzzzzzzzzzzzzzzzs_, vzzzzzzzzzzzzzzzzt_);
        bool? vzzzzzzzzzzzzzzzzv_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType wzzzzzzzzzzzzzzzzb_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object wzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzc_);
            CqlDateTime wzzzzzzzzzzzzzzzze_ = context.Operators.Start(wzzzzzzzzzzzzzzzzd_);
            CqlDate wzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzze_);
            DataType wzzzzzzzzzzzzzzzzg_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object wzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzh_);
            CqlDateTime wzzzzzzzzzzzzzzzzj_ = context.Operators.Start(wzzzzzzzzzzzzzzzzi_);
            CqlDate wzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzj_);
            bool? wzzzzzzzzzzzzzzzzl_ = context.Operators.SameAs(wzzzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzzzk_, "day");
            DataType wzzzzzzzzzzzzzzzzm_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Value;
            object wzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzm_);
            bool? wzzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzzn_ is null));
            bool? wzzzzzzzzzzzzzzzzp_ = context.Operators.And(wzzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzzo_);
            DataType wzzzzzzzzzzzzzzzzq_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Value;
            object wzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzq_);
            bool? wzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzzr_ is null));
            bool? wzzzzzzzzzzzzzzzzt_ = context.Operators.And(wzzzzzzzzzzzzzzzzp_, wzzzzzzzzzzzzzzzzs_);

            return wzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> vzzzzzzzzzzzzzzzzw_ = context.Operators.Where<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(vzzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzzv_);
        CqlDate vzzzzzzzzzzzzzzzzx_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType wzzzzzzzzzzzzzzzzu_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object wzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzv_);
            CqlDateTime wzzzzzzzzzzzzzzzzx_ = context.Operators.Start(wzzzzzzzzzzzzzzzzw_);
            CqlDate wzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzx_);
            DataType wzzzzzzzzzzzzzzzzz_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object xzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzza_);
            CqlDateTime xzzzzzzzzzzzzzzzzc_ = context.Operators.Start(xzzzzzzzzzzzzzzzzb_);
            CqlDate xzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzc_);
            CqlDate[] xzzzzzzzzzzzzzzzze_ = [
                wzzzzzzzzzzzzzzzzy_,
                xzzzzzzzzzzzzzzzzd_,
            ];
            CqlDate xzzzzzzzzzzzzzzzzf_ = context.Operators.Max<CqlDate>(xzzzzzzzzzzzzzzzze_ as IEnumerable<CqlDate>);

            return xzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<CqlDate> vzzzzzzzzzzzzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?, CqlDate>(vzzzzzzzzzzzzzzzzw_, vzzzzzzzzzzzzzzzzx_);
        IEnumerable<CqlDate> vzzzzzzzzzzzzzzzzz_ = context.Operators.Distinct<CqlDate>(vzzzzzzzzzzzzzzzzy_);

        return vzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up VR12 Oblique Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments(CqlContext context)
    {
        IEnumerable<Procedure> xzzzzzzzzzzzzzzzzg_ = this.Total_Hip_Arthroplasty_Procedure(context);
        CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzh_(Procedure THAProcedure)
        {
            DataType xzzzzzzzzzzzzzzzzp_ = THAProcedure?.Performed;
            object xzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzq_);

            return xzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> xzzzzzzzzzzzzzzzzi_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(xzzzzzzzzzzzzzzzzg_, xzzzzzzzzzzzzzzzzh_);
        IEnumerable<CqlInterval<CqlDateTime>> xzzzzzzzzzzzzzzzzj_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(xzzzzzzzzzzzzzzzzi_);
        IEnumerable<CqlInterval<CqlDateTime>> xzzzzzzzzzzzzzzzzk_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> xzzzzzzzzzzzzzzzzs_ = this.Date_VR12_Oblique_Total_Assessment_Completed(context);
            bool? xzzzzzzzzzzzzzzzzt_(CqlDate InitialHipAssessmentOblique)
            {
                CqlDateTime xzzzzzzzzzzzzzzzzx_ = context.Operators.Start(TotalHip);
                CqlQuantity xzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(90m, "days");
                CqlDate xzzzzzzzzzzzzzzzzz_ = context.Operators.Add(InitialHipAssessmentOblique, xzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDate> yzzzzzzzzzzzzzzzza_ = context.Operators.Interval(InitialHipAssessmentOblique, xzzzzzzzzzzzzzzzzz_, true, true);
                CqlDate yzzzzzzzzzzzzzzzzb_ = yzzzzzzzzzzzzzzzza_?.low;
                CqlDateTime yzzzzzzzzzzzzzzzzc_ = context.Operators.ConvertDateToDateTime(yzzzzzzzzzzzzzzzzb_);
                CqlDate yzzzzzzzzzzzzzzzze_ = context.Operators.Add(InitialHipAssessmentOblique, xzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDate> yzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(InitialHipAssessmentOblique, yzzzzzzzzzzzzzzzze_, true, true);
                CqlDate yzzzzzzzzzzzzzzzzg_ = yzzzzzzzzzzzzzzzzf_?.high;
                CqlDateTime yzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertDateToDateTime(yzzzzzzzzzzzzzzzzg_);
                CqlDate yzzzzzzzzzzzzzzzzj_ = context.Operators.Add(InitialHipAssessmentOblique, xzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDate> yzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(InitialHipAssessmentOblique, yzzzzzzzzzzzzzzzzj_, true, true);
                bool? yzzzzzzzzzzzzzzzzl_ = yzzzzzzzzzzzzzzzzk_?.lowClosed;
                CqlDate yzzzzzzzzzzzzzzzzn_ = context.Operators.Add(InitialHipAssessmentOblique, xzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDate> yzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(InitialHipAssessmentOblique, yzzzzzzzzzzzzzzzzn_, true, true);
                bool? yzzzzzzzzzzzzzzzzp_ = yzzzzzzzzzzzzzzzzo_?.highClosed;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzc_, yzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzzp_);
                bool? yzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzzzzq_, "day");
                bool? yzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(InitialHipAssessmentOblique is null));
                bool? yzzzzzzzzzzzzzzzzt_ = context.Operators.And(yzzzzzzzzzzzzzzzzr_, yzzzzzzzzzzzzzzzzs_);

                return yzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<CqlDate> xzzzzzzzzzzzzzzzzu_ = context.Operators.Where<CqlDate>(xzzzzzzzzzzzzzzzzs_, xzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzv_(CqlDate InitialHipAssessmentOblique) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> xzzzzzzzzzzzzzzzzw_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(xzzzzzzzzzzzzzzzzu_, xzzzzzzzzzzzzzzzzv_);

            return xzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> xzzzzzzzzzzzzzzzzl_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(xzzzzzzzzzzzzzzzzj_, xzzzzzzzzzzzzzzzzk_);
        IEnumerable<CqlInterval<CqlDateTime>> xzzzzzzzzzzzzzzzzm_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> yzzzzzzzzzzzzzzzzu_ = this.Date_VR12_Oblique_Total_Assessment_Completed(context);
            bool? yzzzzzzzzzzzzzzzzv_(CqlDate FollowUpHipAssessmentOblique)
            {
                CqlDateTime yzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentOblique);
                CqlDate zzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzz_);
                CqlDateTime zzzzzzzzzzzzzzzzzb_ = context.Operators.End(TotalHip);
                CqlDate zzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzb_);
                CqlQuantity zzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(300m, "days");
                CqlDate zzzzzzzzzzzzzzzzze_ = context.Operators.Add(zzzzzzzzzzzzzzzzzc_, zzzzzzzzzzzzzzzzzd_);
                CqlDate zzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzb_);
                CqlQuantity zzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(425m, "days");
                CqlDate zzzzzzzzzzzzzzzzzi_ = context.Operators.Add(zzzzzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(zzzzzzzzzzzzzzzzze_, zzzzzzzzzzzzzzzzzi_, true, true);
                bool? zzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDate>(zzzzzzzzzzzzzzzzza_, zzzzzzzzzzzzzzzzzj_, "day");

                return zzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<CqlDate> yzzzzzzzzzzzzzzzzw_ = context.Operators.Where<CqlDate>(yzzzzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzx_(CqlDate FollowUpHipAssessmentOblique) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzzzzzzzzzy_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(yzzzzzzzzzzzzzzzzw_, yzzzzzzzzzzzzzzzzx_);

            return yzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> xzzzzzzzzzzzzzzzzn_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(xzzzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzzzm_);
        bool? xzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(xzzzzzzzzzzzzzzzzn_);

        return xzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Date VR12 Orthogonal Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR12_Orthogonal_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode zzzzzzzzzzzzzzzzzl_ = this.VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> zzzzzzzzzzzzzzzzzm_ = context.Operators.ToList<CqlCode>(zzzzzzzzzzzzzzzzzl_);
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, zzzzzzzzzzzzzzzzzm_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzo_ = Status_1_8_000.Instance.isAssessmentPerformed(context, zzzzzzzzzzzzzzzzzn_);
        CqlCode zzzzzzzzzzzzzzzzzp_ = this.VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> zzzzzzzzzzzzzzzzzq_ = context.Operators.ToList<CqlCode>(zzzzzzzzzzzzzzzzzp_);
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, zzzzzzzzzzzzzzzzzq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzs_ = Status_1_8_000.Instance.isAssessmentPerformed(context, zzzzzzzzzzzzzzzzzr_);
        IEnumerable<ValueTuple<Observation, Observation>> zzzzzzzzzzzzzzzzzt_ = context.Operators.CrossJoin<Observation, Observation>(zzzzzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzzzzs_);
        (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? zzzzzzzzzzzzzzzzzu_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? azzzzzzzzzzzzzzzzzb_ = (CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH, _valueTuple.Item1, _valueTuple.Item2);

            return azzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> zzzzzzzzzzzzzzzzzv_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(zzzzzzzzzzzzzzzzzt_, zzzzzzzzzzzzzzzzzu_);
        bool? zzzzzzzzzzzzzzzzzw_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType azzzzzzzzzzzzzzzzzc_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object azzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzd_);
            CqlDateTime azzzzzzzzzzzzzzzzzf_ = context.Operators.Start(azzzzzzzzzzzzzzzzze_);
            CqlDate azzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzf_);
            DataType azzzzzzzzzzzzzzzzzh_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object azzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzi_);
            CqlDateTime azzzzzzzzzzzzzzzzzk_ = context.Operators.Start(azzzzzzzzzzzzzzzzzj_);
            CqlDate azzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzk_);
            bool? azzzzzzzzzzzzzzzzzm_ = context.Operators.SameAs(azzzzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzzzl_, "day");
            DataType azzzzzzzzzzzzzzzzzn_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Value;
            object azzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzn_);
            bool? azzzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzzo_ is null));
            bool? azzzzzzzzzzzzzzzzzq_ = context.Operators.And(azzzzzzzzzzzzzzzzzm_, azzzzzzzzzzzzzzzzzp_);
            DataType azzzzzzzzzzzzzzzzzr_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Value;
            object azzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzr_);
            bool? azzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzzs_ is null));
            bool? azzzzzzzzzzzzzzzzzu_ = context.Operators.And(azzzzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzzzt_);

            return azzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> zzzzzzzzzzzzzzzzzx_ = context.Operators.Where<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(zzzzzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzzzzw_);
        CqlDate zzzzzzzzzzzzzzzzzy_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType azzzzzzzzzzzzzzzzzv_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object azzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzw_);
            CqlDateTime azzzzzzzzzzzzzzzzzy_ = context.Operators.Start(azzzzzzzzzzzzzzzzzx_);
            CqlDate azzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzy_);
            DataType bzzzzzzzzzzzzzzzzza_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object bzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzb_);
            CqlDateTime bzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzc_);
            CqlDate bzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzd_);
            CqlDate[] bzzzzzzzzzzzzzzzzzf_ = [
                azzzzzzzzzzzzzzzzzz_,
                bzzzzzzzzzzzzzzzzze_,
            ];
            CqlDate bzzzzzzzzzzzzzzzzzg_ = context.Operators.Max<CqlDate>(bzzzzzzzzzzzzzzzzzf_ as IEnumerable<CqlDate>);

            return bzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?, CqlDate>(zzzzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzzzy_);
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzza_ = context.Operators.Distinct<CqlDate>(zzzzzzzzzzzzzzzzzz_);

        return azzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up VR12 Orthogonal Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments(CqlContext context)
    {
        IEnumerable<Procedure> bzzzzzzzzzzzzzzzzzh_ = this.Total_Hip_Arthroplasty_Procedure(context);
        CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzi_(Procedure THAProcedure)
        {
            DataType bzzzzzzzzzzzzzzzzzq_ = THAProcedure?.Performed;
            object bzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzr_);

            return bzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> bzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(bzzzzzzzzzzzzzzzzzh_, bzzzzzzzzzzzzzzzzzi_);
        IEnumerable<CqlInterval<CqlDateTime>> bzzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(bzzzzzzzzzzzzzzzzzj_);
        IEnumerable<CqlInterval<CqlDateTime>> bzzzzzzzzzzzzzzzzzl_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> bzzzzzzzzzzzzzzzzzt_ = this.Date_VR12_Orthogonal_Total_Assessment_Completed(context);
            bool? bzzzzzzzzzzzzzzzzzu_(CqlDate InitialHipAssessmentOrthogonal)
            {
                CqlDateTime bzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(TotalHip);
                CqlQuantity bzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(90m, "days");
                CqlDate czzzzzzzzzzzzzzzzza_ = context.Operators.Add(InitialHipAssessmentOrthogonal, bzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDate> czzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(InitialHipAssessmentOrthogonal, czzzzzzzzzzzzzzzzza_, true, true);
                CqlDate czzzzzzzzzzzzzzzzzc_ = czzzzzzzzzzzzzzzzzb_?.low;
                CqlDateTime czzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertDateToDateTime(czzzzzzzzzzzzzzzzzc_);
                CqlDate czzzzzzzzzzzzzzzzzf_ = context.Operators.Add(InitialHipAssessmentOrthogonal, bzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDate> czzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(InitialHipAssessmentOrthogonal, czzzzzzzzzzzzzzzzzf_, true, true);
                CqlDate czzzzzzzzzzzzzzzzzh_ = czzzzzzzzzzzzzzzzzg_?.high;
                CqlDateTime czzzzzzzzzzzzzzzzzi_ = context.Operators.ConvertDateToDateTime(czzzzzzzzzzzzzzzzzh_);
                CqlDate czzzzzzzzzzzzzzzzzk_ = context.Operators.Add(InitialHipAssessmentOrthogonal, bzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDate> czzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(InitialHipAssessmentOrthogonal, czzzzzzzzzzzzzzzzzk_, true, true);
                bool? czzzzzzzzzzzzzzzzzm_ = czzzzzzzzzzzzzzzzzl_?.lowClosed;
                CqlDate czzzzzzzzzzzzzzzzzo_ = context.Operators.Add(InitialHipAssessmentOrthogonal, bzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDate> czzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(InitialHipAssessmentOrthogonal, czzzzzzzzzzzzzzzzzo_, true, true);
                bool? czzzzzzzzzzzzzzzzzq_ = czzzzzzzzzzzzzzzzzp_?.highClosed;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzd_, czzzzzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzzq_);
                bool? czzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzy_, czzzzzzzzzzzzzzzzzr_, "day");
                bool? czzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(InitialHipAssessmentOrthogonal is null));
                bool? czzzzzzzzzzzzzzzzzu_ = context.Operators.And(czzzzzzzzzzzzzzzzzs_, czzzzzzzzzzzzzzzzzt_);

                return czzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<CqlDate> bzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<CqlDate>(bzzzzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzw_(CqlDate InitialHipAssessmentOrthogonal) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> bzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(bzzzzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzzzzw_);

            return bzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> bzzzzzzzzzzzzzzzzzm_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(bzzzzzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzzzzzl_);
        IEnumerable<CqlInterval<CqlDateTime>> bzzzzzzzzzzzzzzzzzn_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> czzzzzzzzzzzzzzzzzv_ = this.Date_VR12_Orthogonal_Total_Assessment_Completed(context);
            bool? czzzzzzzzzzzzzzzzzw_(CqlDate FollowUpHipAssessmentOrthogonal)
            {
                CqlDateTime dzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentOrthogonal);
                CqlDate dzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzzza_);
                CqlDateTime dzzzzzzzzzzzzzzzzzc_ = context.Operators.End(TotalHip);
                CqlDate dzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzzzc_);
                CqlQuantity dzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(300m, "days");
                CqlDate dzzzzzzzzzzzzzzzzzf_ = context.Operators.Add(dzzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzzze_);
                CqlDate dzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzzzc_);
                CqlQuantity dzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(425m, "days");
                CqlDate dzzzzzzzzzzzzzzzzzj_ = context.Operators.Add(dzzzzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDate> dzzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzzzzj_, true, true);
                bool? dzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDate>(dzzzzzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzzzzzk_, "day");

                return dzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<CqlDate> czzzzzzzzzzzzzzzzzx_ = context.Operators.Where<CqlDate>(czzzzzzzzzzzzzzzzzv_, czzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzy_(CqlDate FollowUpHipAssessmentOrthogonal) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> czzzzzzzzzzzzzzzzzz_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(czzzzzzzzzzzzzzzzzx_, czzzzzzzzzzzzzzzzzy_);

            return czzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> bzzzzzzzzzzzzzzzzzo_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(bzzzzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzzzzn_);
        bool? bzzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(bzzzzzzzzzzzzzzzzzo_);

        return bzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? dzzzzzzzzzzzzzzzzzm_ = this.Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments(context);
        bool? dzzzzzzzzzzzzzzzzzn_ = this.Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments(context);
        bool? dzzzzzzzzzzzzzzzzzo_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzzzzn_);
        bool? dzzzzzzzzzzzzzzzzzp_ = this.Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments(context);
        bool? dzzzzzzzzzzzzzzzzzq_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzo_, dzzzzzzzzzzzzzzzzzp_);
        bool? dzzzzzzzzzzzzzzzzzr_ = this.Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments(context);
        bool? dzzzzzzzzzzzzzzzzzs_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzq_, dzzzzzzzzzzzzzzzzzr_);
        bool? dzzzzzzzzzzzzzzzzzt_ = this.Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments(context);
        bool? dzzzzzzzzzzzzzzzzzu_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzs_, dzzzzzzzzzzzzzzzzzt_);

        return dzzzzzzzzzzzzzzzzzu_;
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
