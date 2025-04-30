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
    private static readonly CqlCode _Activities_of_daily_living_score__HOOS_ = new CqlCode("72095-3", "http://loinc.org");

    [CqlCodeDefinition("Dead (finding)", codeId: "419099009", codeSystem: "http://snomed.info/sct")]
    public CqlCode Dead__finding_(CqlContext _) => _Dead__finding_;
    private static readonly CqlCode _Dead__finding_ = new CqlCode("419099009", "http://snomed.info/sct");

    [CqlCodeDefinition("Discharge to healthcare facility for hospice care (procedure)", codeId: "428371000124100", codeSystem: "http://snomed.info/sct")]
    public CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure_(CqlContext _) => _Discharge_to_healthcare_facility_for_hospice_care__procedure_;
    private static readonly CqlCode _Discharge_to_healthcare_facility_for_hospice_care__procedure_ = new CqlCode("428371000124100", "http://snomed.info/sct");

    [CqlCodeDefinition("Discharge to home for hospice care (procedure)", codeId: "428371000124100", codeSystem: "http://snomed.info/sct")]
    public CqlCode Discharge_to_home_for_hospice_care__procedure_(CqlContext _) => _Discharge_to_home_for_hospice_care__procedure_;
    private static readonly CqlCode _Discharge_to_home_for_hospice_care__procedure_ = new CqlCode("428371000124100", "http://snomed.info/sct");

    [CqlCodeDefinition("Hospice care [Minimum Data Set]", codeId: "45755-6", codeSystem: "http://loinc.org")]
    public CqlCode Hospice_care__Minimum_Data_Set_(CqlContext _) => _Hospice_care__Minimum_Data_Set_;
    private static readonly CqlCode _Hospice_care__Minimum_Data_Set_ = new CqlCode("45755-6", "http://loinc.org");

    [CqlCodeDefinition("Pain score [HOOS]", codeId: "72097-9", codeSystem: "http://loinc.org")]
    public CqlCode Pain_score__HOOS_(CqlContext _) => _Pain_score__HOOS_;
    private static readonly CqlCode _Pain_score__HOOS_ = new CqlCode("72097-9", "http://loinc.org");

    [CqlCodeDefinition("Postoperative follow-up visit, normally included in the surgical package, to indicate that an evaluation and management service was performed during a postoperative period for a reason(s) related to the original procedure", codeId: "99024", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure(CqlContext _) => _Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure;
    private static readonly CqlCode _Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure = new CqlCode("99024", "http://www.ama-assn.org/go/cpt");

    [CqlCodeDefinition("PROMIS-10 Global Mental Health (GMH) score T-score", codeId: "71969-0", codeSystem: "http://loinc.org")]
    public CqlCode PROMIS_10_Global_Mental_Health__GMH__score_T_score(CqlContext _) => _PROMIS_10_Global_Mental_Health__GMH__score_T_score;
    private static readonly CqlCode _PROMIS_10_Global_Mental_Health__GMH__score_T_score = new CqlCode("71969-0", "http://loinc.org");

    [CqlCodeDefinition("PROMIS-10 Global Physical Health (GPH) score T-score", codeId: "71971-6", codeSystem: "http://loinc.org")]
    public CqlCode PROMIS_10_Global_Physical_Health__GPH__score_T_score(CqlContext _) => _PROMIS_10_Global_Physical_Health__GPH__score_T_score;
    private static readonly CqlCode _PROMIS_10_Global_Physical_Health__GPH__score_T_score = new CqlCode("71971-6", "http://loinc.org");

    [CqlCodeDefinition("Quality of life score [HOOS]", codeId: "72093-8", codeSystem: "http://loinc.org")]
    public CqlCode Quality_of_life_score__HOOS_(CqlContext _) => _Quality_of_life_score__HOOS_;
    private static readonly CqlCode _Quality_of_life_score__HOOS_ = new CqlCode("72093-8", "http://loinc.org");

    [CqlCodeDefinition("Severe cognitive impairment (finding)", codeId: "702956004", codeSystem: "http://snomed.info/sct")]
    public CqlCode Severe_cognitive_impairment__finding_(CqlContext _) => _Severe_cognitive_impairment__finding_;
    private static readonly CqlCode _Severe_cognitive_impairment__finding_ = new CqlCode("702956004", "http://snomed.info/sct");

    [CqlCodeDefinition("Sport-recreation score [HOOS]", codeId: "72094-6", codeSystem: "http://loinc.org")]
    public CqlCode Sport_recreation_score__HOOS_(CqlContext _) => _Sport_recreation_score__HOOS_;
    private static readonly CqlCode _Sport_recreation_score__HOOS_ = new CqlCode("72094-6", "http://loinc.org");

    [CqlCodeDefinition("Symptoms score [HOOS]", codeId: "72096-1", codeSystem: "http://loinc.org")]
    public CqlCode Symptoms_score__HOOS_(CqlContext _) => _Symptoms_score__HOOS_;
    private static readonly CqlCode _Symptoms_score__HOOS_ = new CqlCode("72096-1", "http://loinc.org");

    [CqlCodeDefinition("Total interval score [HOOSJR]", codeId: "82323-7", codeSystem: "http://loinc.org")]
    public CqlCode Total_interval_score__HOOSJR_(CqlContext _) => _Total_interval_score__HOOSJR_;
    private static readonly CqlCode _Total_interval_score__HOOSJR_ = new CqlCode("82323-7", "http://loinc.org");

    [CqlCodeDefinition("VR-12 Mental component summary (MCS) score - oblique method T-score", codeId: "72026-8", codeSystem: "http://loinc.org")]
    public CqlCode VR_12_Mental_component_summary__MCS__score___oblique_method_T_score(CqlContext _) => _VR_12_Mental_component_summary__MCS__score___oblique_method_T_score;
    private static readonly CqlCode _VR_12_Mental_component_summary__MCS__score___oblique_method_T_score = new CqlCode("72026-8", "http://loinc.org");

    [CqlCodeDefinition("VR-12 Mental component summary (MCS) score - orthogonal method T-score", codeId: "72028-4", codeSystem: "http://loinc.org")]
    public CqlCode VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score(CqlContext _) => _VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score;
    private static readonly CqlCode _VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score = new CqlCode("72028-4", "http://loinc.org");

    [CqlCodeDefinition("VR-12 Physical component summary (PCS) score - oblique method T-score", codeId: "72025-0", codeSystem: "http://loinc.org")]
    public CqlCode VR_12_Physical_component_summary__PCS__score___oblique_method_T_score(CqlContext _) => _VR_12_Physical_component_summary__PCS__score___oblique_method_T_score;
    private static readonly CqlCode _VR_12_Physical_component_summary__PCS__score___oblique_method_T_score = new CqlCode("72025-0", "http://loinc.org");

    [CqlCodeDefinition("VR-12 Physical component summary (PCS) score - orthogonal method T-score", codeId: "72027-6", codeSystem: "http://loinc.org")]
    public CqlCode VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score(CqlContext _) => _VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score;
    private static readonly CqlCode _VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score = new CqlCode("72027-6", "http://loinc.org");

    [CqlCodeDefinition("Yes (qualifier value)", codeId: "373066001", codeSystem: "http://snomed.info/sct")]
    public CqlCode Yes__qualifier_value_(CqlContext _) => _Yes__qualifier_value_;
    private static readonly CqlCode _Yes__qualifier_value_ = new CqlCode("373066001", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Activities_of_daily_living_score__HOOS_,
          _Hospice_care__Minimum_Data_Set_,
          _Pain_score__HOOS_,
          _PROMIS_10_Global_Mental_Health__GMH__score_T_score,
          _PROMIS_10_Global_Physical_Health__GPH__score_T_score,
          _Quality_of_life_score__HOOS_,
          _Sport_recreation_score__HOOS_,
          _Symptoms_score__HOOS_,
          _Total_interval_score__HOOSJR_,
          _VR_12_Mental_component_summary__MCS__score___oblique_method_T_score,
          _VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score,
          _VR_12_Physical_component_summary__PCS__score___oblique_method_T_score,
          _VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score]);

    [CqlCodeSystemDefinition("CPT")]
    public CqlCodeSystem CPT(CqlContext _) => _CPT;
    private static readonly CqlCodeSystem _CPT =
      new CqlCodeSystem("http://www.ama-assn.org/go/cpt", null, [
          _Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure]);

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Dead__finding_,
          _Discharge_to_healthcare_facility_for_hospice_care__procedure_,
          _Discharge_to_home_for_hospice_care__procedure_,
          _Severe_cognitive_impairment__finding_,
          _Yes__qualifier_value_]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime yzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime yzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzzzzzzzze_, true, true);
        object yzzzzzzzzzzzzzzzzzzzzzg_ = context.ResolveParameter("FunctionalStatusAssessmentforTotalHipReplacementFHIR-0.0.008", "Measurement Period", yzzzzzzzzzzzzzzzzzzzzzf_);

        return (CqlInterval<CqlDateTime>)yzzzzzzzzzzzzzzzzzzzzzg_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> yzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient yzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SingletonFrom<Patient>(yzzzzzzzzzzzzzzzzzzzzzh_);

        return yzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? yzzzzzzzzzzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return yzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Payer Type")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Type(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> yzzzzzzzzzzzzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return yzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? yzzzzzzzzzzzzzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return yzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode yzzzzzzzzzzzzzzzzzzzzzm_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return yzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("August 1 Year Prior to the Measurement Period")]
    public CqlDateTime August_1_Year_Prior_to_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
        CqlDateTime yzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzn_);
        int? yzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateTimeComponentFrom(yzzzzzzzzzzzzzzzzzzzzzo_, "year");
        int? yzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Subtract(yzzzzzzzzzzzzzzzzzzzzzp_, 1);
        decimal? yzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime yzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateTime(yzzzzzzzzzzzzzzzzzzzzzq_, 8, 1, 0, 0, 0, 0, yzzzzzzzzzzzzzzzzzzzzzr_);

        return yzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Has Qualifying Encounter")]
    public bool? Has_Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzt_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzv_ = this.Office_Visit(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? yzzzzzzzzzzzzzzzzzzzzzz_(Encounter E)
        {
            List<CodeableConcept> zzzzzzzzzzzzzzzzzzzzzzm_ = E?.Type;
            CqlConcept zzzzzzzzzzzzzzzzzzzzzzn_(CodeableConcept @this)
            {
                CqlConcept zzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return zzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<CqlConcept> zzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)zzzzzzzzzzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzzzzzzzzzn_);
            bool? zzzzzzzzzzzzzzzzzzzzzzp_(CqlConcept T)
            {
                CqlCode zzzzzzzzzzzzzzzzzzzzzzt_ = this.Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure(context);
                CqlConcept zzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertCodeToConcept(zzzzzzzzzzzzzzzzzzzzzzt_);
                bool? zzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equivalent(T, zzzzzzzzzzzzzzzzzzzzzzu_);

                return zzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<CqlConcept> zzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<CqlConcept>(zzzzzzzzzzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzzzzzzzzzp_);
            bool? zzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<CqlConcept>(zzzzzzzzzzzzzzzzzzzzzzq_);

            return zzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzzzzzzzzy_, yzzzzzzzzzzzzzzzzzzzzzz_);
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzb_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzzzzzzzzzza_, zzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzzzzzzzzd_);
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzf_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzzzzzzzzzze_, zzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzi_ = Status_1_8_000.Instance.isEncounterPerformed(context, zzzzzzzzzzzzzzzzzzzzzzh_);
        bool? zzzzzzzzzzzzzzzzzzzzzzj_(Encounter ValidEncounters)
        {
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzw_ = this.August_1_Year_Prior_to_the_Measurement_Period(context);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.End(zzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzzzzw_, zzzzzzzzzzzzzzzzzzzzzzy_, true, true);
            Period azzzzzzzzzzzzzzzzzzzzzza_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzzzzzzb_ as object);
            bool? azzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzz_, azzzzzzzzzzzzzzzzzzzzzzc_, "day");

            return azzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzzzzzzzzzi_, zzzzzzzzzzzzzzzzzzzzzzj_);
        bool? zzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Encounter>(zzzzzzzzzzzzzzzzzzzzzzk_);

        return zzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("November 1 Two Years Prior to the Measurement Period")]
    public CqlDateTime November_1_Two_Years_Prior_to_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
        CqlDateTime azzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzze_);
        int? azzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateTimeComponentFrom(azzzzzzzzzzzzzzzzzzzzzzf_, "year");
        int? azzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Subtract(azzzzzzzzzzzzzzzzzzzzzzg_, 2);
        decimal? azzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime azzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateTime(azzzzzzzzzzzzzzzzzzzzzzh_, 11, 1, 0, 0, 0, 0, azzzzzzzzzzzzzzzzzzzzzzi_);

        return azzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("October 31 Year Prior to the Measurement Period")]
    public CqlDateTime October_31_Year_Prior_to_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
        CqlDateTime azzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzk_);
        int? azzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateTimeComponentFrom(azzzzzzzzzzzzzzzzzzzzzzl_, "year");
        int? azzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Subtract(azzzzzzzzzzzzzzzzzzzzzzm_, 1);
        decimal? azzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime azzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateTime(azzzzzzzzzzzzzzzzzzzzzzn_, 10, 31, 23, 59, 59, 0, azzzzzzzzzzzzzzzzzzzzzzo_);

        return azzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Total Hip Arthroplasty Procedure")]
    public IEnumerable<Procedure> Total_Hip_Arthroplasty_Procedure(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzq_ = this.Primary_THA_Procedure(context);
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzs_ = Status_1_8_000.Instance.isProcedurePerformed(context, azzzzzzzzzzzzzzzzzzzzzzr_);
        bool? azzzzzzzzzzzzzzzzzzzzzzt_(Procedure THAProcedure)
        {
            DataType azzzzzzzzzzzzzzzzzzzzzzv_ = THAProcedure?.Performed;
            object azzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzz_ = this.November_1_Two_Years_Prior_to_the_Measurement_Period(context);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzza_ = this.October_31_Year_Prior_to_the_Measurement_Period(context);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(azzzzzzzzzzzzzzzzzzzzzzz_, bzzzzzzzzzzzzzzzzzzzzzza_, true, true);
            bool? bzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzzzzzb_, "day");

            return bzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Procedure>(azzzzzzzzzzzzzzzzzzzzzzs_, azzzzzzzzzzzzzzzzzzzzzzt_);

        return azzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? bzzzzzzzzzzzzzzzzzzzzzzd_ = this.Has_Qualifying_Encounter(context);
        IEnumerable<Procedure> bzzzzzzzzzzzzzzzzzzzzzze_ = this.Total_Hip_Arthroplasty_Procedure(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<Procedure>(bzzzzzzzzzzzzzzzzzzzzzze_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzzzzzzf_);
        Patient bzzzzzzzzzzzzzzzzzzzzzzh_ = this.Patient(context);
        Date bzzzzzzzzzzzzzzzzzzzzzzi_ = bzzzzzzzzzzzzzzzzzzzzzzh_?.BirthDateElement;
        string bzzzzzzzzzzzzzzzzzzzzzzj_ = bzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
        CqlDate bzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertStringToDate(bzzzzzzzzzzzzzzzzzzzzzzj_);
        CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
        CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzl_);
        CqlDate bzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzm_);
        int? bzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.CalculateAgeAt(bzzzzzzzzzzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzzzzzzzzzzn_, "year");
        bool? bzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.GreaterOrEqual(bzzzzzzzzzzzzzzzzzzzzzzo_, 19);
        bool? bzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzzzzzzzzp_);

        return bzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? bzzzzzzzzzzzzzzzzzzzzzzr_ = this.Initial_Population(context);

        return bzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Has Severe Cognitive Impairment")]
    public bool? Has_Severe_Cognitive_Impairment(CqlContext context)
    {
        CqlCode bzzzzzzzzzzzzzzzzzzzzzzs_ = this.Severe_cognitive_impairment__finding_(context);
        IEnumerable<CqlCode> bzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ToList<CqlCode>(bzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, bzzzzzzzzzzzzzzzzzzzzzzt_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? bzzzzzzzzzzzzzzzzzzzzzzv_(Condition Dementia)
        {
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Dementia);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
            bool? czzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Overlaps(bzzzzzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzzzzzz_, "day");

            return czzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Condition>(bzzzzzzzzzzzzzzzzzzzzzzu_, bzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Condition>(bzzzzzzzzzzzzzzzzzzzzzzw_);

        return bzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Has Total Hip Arthroplasty with 1 or More Lower Body Fractures")]
    public bool? Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures(CqlContext context)
    {
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzzzzb_ = this.Total_Hip_Arthroplasty_Procedure(context);
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzzzzc_(Procedure THAProcedure)
        {
            CqlValueSet czzzzzzzzzzzzzzzzzzzzzzf_ = this.Lower_Body_Fractures_Excluding_Ankle_and_Foot(context);
            IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? czzzzzzzzzzzzzzzzzzzzzzh_(Condition LowerBodyFracture)
            {
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, LowerBodyFracture);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzl_);
                DataType czzzzzzzzzzzzzzzzzzzzzzn_ = THAProcedure?.Performed;
                object czzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzp_);
                CqlQuantity czzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Subtract(czzzzzzzzzzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzzzzzzzzzr_);
                object czzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzzzzzzs_, czzzzzzzzzzzzzzzzzzzzzzw_, true, true);
                bool? czzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzzzzzzzx_, default);
                object dzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzb_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzzzzzzzzc_ is null));
                bool? dzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzy_, dzzzzzzzzzzzzzzzzzzzzzzd_);

                return dzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Condition>(czzzzzzzzzzzzzzzzzzzzzzg_, czzzzzzzzzzzzzzzzzzzzzzh_);
            Procedure czzzzzzzzzzzzzzzzzzzzzzj_(Condition LowerBodyFracture) =>
                THAProcedure;
            IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Condition, Procedure>(czzzzzzzzzzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzzzzzzzzzj_);

            return czzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SelectMany<Procedure, Procedure>(czzzzzzzzzzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzzzzzzzzzc_);
        bool? czzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Procedure>(czzzzzzzzzzzzzzzzzzzzzzd_);

        return czzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Has Partial Hip Arthroplasty Procedure")]
    public bool? Has_Partial_Hip_Arthroplasty_Procedure(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzf_ = this.Partial_Arthroplasty_of_Hip(context);
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzzzh_ = Status_1_8_000.Instance.isProcedurePerformed(context, dzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzzzi_(Procedure PartialTHAProcedure)
        {
            IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzzzl_ = this.Total_Hip_Arthroplasty_Procedure(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzzm_(Procedure THAProcedure)
            {
                DataType dzzzzzzzzzzzzzzzzzzzzzzq_ = THAProcedure?.Performed;
                object dzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzzzzr_);
                DataType dzzzzzzzzzzzzzzzzzzzzzzt_ = PartialTHAProcedure?.Performed;
                object dzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzzzzu_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzs_, dzzzzzzzzzzzzzzzzzzzzzzv_, "day");

                return dzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Procedure>(dzzzzzzzzzzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzzzzzzzzzzm_);
            Procedure dzzzzzzzzzzzzzzzzzzzzzzo_(Procedure THAProcedure) =>
                PartialTHAProcedure;
            IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Procedure, Procedure>(dzzzzzzzzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzzzzzzzzo_);

            return dzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<Procedure, Procedure>(dzzzzzzzzzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Procedure>(dzzzzzzzzzzzzzzzzzzzzzzj_);

        return dzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Has Revision Hip Arthroplasty Procedure or Implanted Device or Prosthesis Removal Procedure")]
    public bool? Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure(CqlContext context)
    {
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzzzx_ = this.Total_Hip_Arthroplasty_Procedure(context);
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzzzy_(Procedure THAProcedure)
        {
            CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzb_ = this.Removal__Revision_and_Supplement_Procedures_of_the_Lower_Body_and_Spine(context);
            IEnumerable<Procedure> ezzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> ezzzzzzzzzzzzzzzzzzzzzzd_ = Status_1_8_000.Instance.isProcedurePerformed(context, ezzzzzzzzzzzzzzzzzzzzzzc_);
            bool? ezzzzzzzzzzzzzzzzzzzzzze_(Procedure RevisionTHAProcedure)
            {
                DataType ezzzzzzzzzzzzzzzzzzzzzzi_ = THAProcedure?.Performed;
                object ezzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzzzzzzzzj_);
                DataType ezzzzzzzzzzzzzzzzzzzzzzl_ = RevisionTHAProcedure?.Performed;
                object ezzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzzzzzzzzm_);
                bool? ezzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzk_, ezzzzzzzzzzzzzzzzzzzzzzn_, "day");

                return ezzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Procedure> ezzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Procedure>(ezzzzzzzzzzzzzzzzzzzzzzd_, ezzzzzzzzzzzzzzzzzzzzzze_);
            Procedure ezzzzzzzzzzzzzzzzzzzzzzg_(Procedure RevisionTHAProcedure) =>
                THAProcedure;
            IEnumerable<Procedure> ezzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<Procedure, Procedure>(ezzzzzzzzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzzzzzzzg_);

            return ezzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SelectMany<Procedure, Procedure>(dzzzzzzzzzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? ezzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Procedure>(dzzzzzzzzzzzzzzzzzzzzzzz_);

        return ezzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Has Malignant Neoplasm of Lower and Unspecified Limbs")]
    public bool? Has_Malignant_Neoplasm_of_Lower_and_Unspecified_Limbs(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzp_ = this.Malignant_Neoplasms_of_Lower_and_Unspecified_Limbs(context);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzr_(Condition MalignantNeoplasm)
        {
            IEnumerable<Procedure> ezzzzzzzzzzzzzzzzzzzzzzu_ = this.Total_Hip_Arthroplasty_Procedure(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzzv_(Procedure THAProcedure)
            {
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MalignantNeoplasm);
                DataType fzzzzzzzzzzzzzzzzzzzzzza_ = THAProcedure?.Performed;
                object fzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzzzzzzzb_);
                bool? fzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Overlaps(ezzzzzzzzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzzzzzzzzc_, "day");

                return fzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Procedure> ezzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Procedure>(ezzzzzzzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzzzzzzv_);
            Condition ezzzzzzzzzzzzzzzzzzzzzzx_(Procedure THAProcedure) =>
                MalignantNeoplasm;
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<Procedure, Condition>(ezzzzzzzzzzzzzzzzzzzzzzw_, ezzzzzzzzzzzzzzzzzzzzzzx_);

            return ezzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SelectMany<Condition, Condition>(ezzzzzzzzzzzzzzzzzzzzzzq_, ezzzzzzzzzzzzzzzzzzzzzzr_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Condition>(ezzzzzzzzzzzzzzzzzzzzzzs_);

        return ezzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Has Mechanical Complication")]
    public bool? Has_Mechanical_Complication(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzze_ = this.Mechanical_Complications_Excluding_Upper_Body(context);
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzg_(Condition MechanicalComplications)
        {
            IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzj_ = this.Total_Hip_Arthroplasty_Procedure(context);
            bool? fzzzzzzzzzzzzzzzzzzzzzzk_(Procedure THAProcedure)
            {
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MechanicalComplications);
                DataType fzzzzzzzzzzzzzzzzzzzzzzp_ = THAProcedure?.Performed;
                object fzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? fzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Overlaps(fzzzzzzzzzzzzzzzzzzzzzzo_, fzzzzzzzzzzzzzzzzzzzzzzr_, "day");

                return fzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Procedure>(fzzzzzzzzzzzzzzzzzzzzzzj_, fzzzzzzzzzzzzzzzzzzzzzzk_);
            Condition fzzzzzzzzzzzzzzzzzzzzzzm_(Procedure THAProcedure) =>
                MechanicalComplications;
            IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Procedure, Condition>(fzzzzzzzzzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzzzzzzzzzm_);

            return fzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SelectMany<Condition, Condition>(fzzzzzzzzzzzzzzzzzzzzzzf_, fzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Exists<Condition>(fzzzzzzzzzzzzzzzzzzzzzzh_);

        return fzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Has More Than One Elective Primary Total Hip Arthroplasty Performed")]
    public bool? Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed(CqlContext context)
    {
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzt_ = this.Total_Hip_Arthroplasty_Procedure(context);
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzu_(Procedure THAProcedure)
        {
            CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzx_ = this.Primary_THA_Procedure(context);
            IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzz_ = Status_1_8_000.Instance.isProcedurePerformed(context, fzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? gzzzzzzzzzzzzzzzzzzzzzza_(Procedure ElectiveTHAProcedure)
            {
                Id gzzzzzzzzzzzzzzzzzzzzzze_ = THAProcedure?.IdElement;
                string gzzzzzzzzzzzzzzzzzzzzzzf_ = gzzzzzzzzzzzzzzzzzzzzzze_?.Value;
                Id gzzzzzzzzzzzzzzzzzzzzzzg_ = ElectiveTHAProcedure?.IdElement;
                string gzzzzzzzzzzzzzzzzzzzzzzh_ = gzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
                bool? gzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Equivalent(gzzzzzzzzzzzzzzzzzzzzzzf_, gzzzzzzzzzzzzzzzzzzzzzzh_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Not(gzzzzzzzzzzzzzzzzzzzzzzi_);
                DataType gzzzzzzzzzzzzzzzzzzzzzzk_ = ElectiveTHAProcedure?.Performed;
                object gzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzm_);
                DataType gzzzzzzzzzzzzzzzzzzzzzzo_ = THAProcedure?.Performed;
                object gzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(1m, "year");
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Subtract(gzzzzzzzzzzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzzzzzzzzzzs_);
                object gzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Add(gzzzzzzzzzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzzzzzzt_, gzzzzzzzzzzzzzzzzzzzzzzz_, true, true);
                bool? hzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzn_, hzzzzzzzzzzzzzzzzzzzzzza_, "day");
                bool? hzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzzzzzzzzb_);

                return hzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Procedure> gzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Procedure>(fzzzzzzzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzzzzzzza_);
            Procedure gzzzzzzzzzzzzzzzzzzzzzzc_(Procedure ElectiveTHAProcedure) =>
                THAProcedure;
            IEnumerable<Procedure> gzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<Procedure, Procedure>(gzzzzzzzzzzzzzzzzzzzzzzb_, gzzzzzzzzzzzzzzzzzzzzzzc_);

            return gzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SelectMany<Procedure, Procedure>(fzzzzzzzzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Procedure>(fzzzzzzzzzzzzzzzzzzzzzzv_);

        return fzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Death Within 300 Days of the THA Procedure")]
    public bool? Death_Within_300_Days_of_the_THA_Procedure(CqlContext context)
    {
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzd_ = this.Total_Hip_Arthroplasty_Procedure(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzze_(Procedure THAProcedure)
        {
            Patient hzzzzzzzzzzzzzzzzzzzzzzh_ = this.Patient(context);
            DataType hzzzzzzzzzzzzzzzzzzzzzzi_ = hzzzzzzzzzzzzzzzzzzzzzzh_?.Deceased;
            object hzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDate hzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzzzzzzzj_ as CqlDateTime);
            DataType hzzzzzzzzzzzzzzzzzzzzzzl_ = THAProcedure?.Performed;
            object hzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDate hzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzzzzzzzo_);
            object hzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDate hzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(300m, "days");
            CqlDate hzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Add(hzzzzzzzzzzzzzzzzzzzzzzu_, hzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzzzzzzzp_, hzzzzzzzzzzzzzzzzzzzzzzw_, true, true);
            bool? hzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzzzzzzzzzzx_, "day");

            return hzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Procedure>(hzzzzzzzzzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzzzzzzzzzze_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Procedure>(hzzzzzzzzzzzzzzzzzzzzzzf_);

        return hzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? hzzzzzzzzzzzzzzzzzzzzzzz_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? izzzzzzzzzzzzzzzzzzzzzza_ = this.Has_Severe_Cognitive_Impairment(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzzzzzzzzzza_);
        bool? izzzzzzzzzzzzzzzzzzzzzzc_ = this.Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzzzzzb_, izzzzzzzzzzzzzzzzzzzzzzc_);
        bool? izzzzzzzzzzzzzzzzzzzzzze_ = this.Has_Partial_Hip_Arthroplasty_Procedure(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzzzzzzze_);
        bool? izzzzzzzzzzzzzzzzzzzzzzg_ = this.Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzzzzzf_, izzzzzzzzzzzzzzzzzzzzzzg_);
        bool? izzzzzzzzzzzzzzzzzzzzzzi_ = this.Has_Malignant_Neoplasm_of_Lower_and_Unspecified_Limbs(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzzzzzzzzzi_);
        bool? izzzzzzzzzzzzzzzzzzzzzzk_ = this.Has_Mechanical_Complication(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzzzzzzzzzk_);
        bool? izzzzzzzzzzzzzzzzzzzzzzm_ = this.Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzzzzzzzzm_);
        bool? izzzzzzzzzzzzzzzzzzzzzzo_ = this.Death_Within_300_Days_of_the_THA_Procedure(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzzzzzzzzzo_);

        return izzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Date HOOS Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_HOOS_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode izzzzzzzzzzzzzzzzzzzzzzq_ = this.Quality_of_life_score__HOOS_(context);
        IEnumerable<CqlCode> izzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ToList<CqlCode>(izzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, izzzzzzzzzzzzzzzzzzzzzzr_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzt_ = Status_1_8_000.Instance.isAssessmentPerformed(context, izzzzzzzzzzzzzzzzzzzzzzs_);
        CqlCode izzzzzzzzzzzzzzzzzzzzzzu_ = this.Sport_recreation_score__HOOS_(context);
        IEnumerable<CqlCode> izzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ToList<CqlCode>(izzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, izzzzzzzzzzzzzzzzzzzzzzv_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzx_ = Status_1_8_000.Instance.isAssessmentPerformed(context, izzzzzzzzzzzzzzzzzzzzzzw_);
        CqlCode izzzzzzzzzzzzzzzzzzzzzzy_ = this.Activities_of_daily_living_score__HOOS_(context);
        IEnumerable<CqlCode> izzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ToList<CqlCode>(izzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, izzzzzzzzzzzzzzzzzzzzzzz_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzb_ = Status_1_8_000.Instance.isAssessmentPerformed(context, jzzzzzzzzzzzzzzzzzzzzzza_);
        CqlCode jzzzzzzzzzzzzzzzzzzzzzzc_ = this.Symptoms_score__HOOS_(context);
        IEnumerable<CqlCode> jzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ToList<CqlCode>(jzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, jzzzzzzzzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzf_ = Status_1_8_000.Instance.isAssessmentPerformed(context, jzzzzzzzzzzzzzzzzzzzzzze_);
        CqlCode jzzzzzzzzzzzzzzzzzzzzzzg_ = this.Pain_score__HOOS_(context);
        IEnumerable<CqlCode> jzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ToList<CqlCode>(jzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, jzzzzzzzzzzzzzzzzzzzzzzh_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzj_ = Status_1_8_000.Instance.isAssessmentPerformed(context, jzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<ValueTuple<Observation, Observation, Observation, Observation, Observation>> jzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.CrossJoin<Observation, Observation, Observation, Observation, Observation>(izzzzzzzzzzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzzzzzzzzzzb_, jzzzzzzzzzzzzzzzzzzzzzzf_, jzzzzzzzzzzzzzzzzzzzzzzj_);
        (CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)? jzzzzzzzzzzzzzzzzzzzzzzl_(ValueTuple<Observation, Observation, Observation, Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)? jzzzzzzzzzzzzzzzzzzzzzzs_ = (CqlTupleMetadata_GVNUVHGXYWXVGgfjdTEahUfhP, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4, _valueTuple.Item5);

            return jzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?> jzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<ValueTuple<Observation, Observation, Observation, Observation, Observation>, (CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?>(jzzzzzzzzzzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzn_((CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)? tuple_eipfmazvhfscjijaofhicpvmb)
        {
            DataType jzzzzzzzzzzzzzzzzzzzzzzt_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSLifeQuality?.Effective;
            object jzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDate jzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzzzzzzzzzw_);
            DataType jzzzzzzzzzzzzzzzzzzzzzzy_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSport?.Effective;
            object jzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SameAs(jzzzzzzzzzzzzzzzzzzzzzzx_, kzzzzzzzzzzzzzzzzzzzzzzc_, "day");
            DataType kzzzzzzzzzzzzzzzzzzzzzze_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSport?.Value;
            object kzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzze_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzzzzzzzf_ is null));
            bool? kzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzd_, kzzzzzzzzzzzzzzzzzzzzzzg_);
            object kzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzzzzzzzzl_);
            DataType kzzzzzzzzzzzzzzzzzzzzzzn_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSActivityScore?.Effective;
            object kzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SameAs(kzzzzzzzzzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzzzzzzzzzr_, "day");
            bool? kzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzzzzzzzzzs_);
            DataType kzzzzzzzzzzzzzzzzzzzzzzu_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSActivityScore?.Value;
            object kzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzzzzzzzv_ is null));
            bool? kzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzt_, kzzzzzzzzzzzzzzzzzzzzzzw_);
            object kzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzzzzzzb_);
            DataType lzzzzzzzzzzzzzzzzzzzzzzd_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSymptoms?.Effective;
            object lzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzzzzzzg_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SameAs(lzzzzzzzzzzzzzzzzzzzzzzc_, lzzzzzzzzzzzzzzzzzzzzzzh_, "day");
            bool? lzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzzzzzzzzzzi_);
            DataType lzzzzzzzzzzzzzzzzzzzzzzk_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSymptoms?.Value;
            object lzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzzzzzzzzl_ is null));
            bool? lzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzzzzzzzzzm_);
            object lzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzzzzzzr_);
            DataType lzzzzzzzzzzzzzzzzzzzzzzt_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSPain?.Effective;
            object lzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SameAs(lzzzzzzzzzzzzzzzzzzzzzzs_, lzzzzzzzzzzzzzzzzzzzzzzx_, "day");
            bool? lzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzn_, lzzzzzzzzzzzzzzzzzzzzzzy_);
            DataType mzzzzzzzzzzzzzzzzzzzzzza_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSPain?.Value;
            object mzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzza_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzzzzzb_ is null));
            bool? mzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzzzzzzzzzzc_);
            DataType mzzzzzzzzzzzzzzzzzzzzzze_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSLifeQuality?.Value;
            object mzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzze_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzzzzzf_ is null));
            bool? mzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzd_, mzzzzzzzzzzzzzzzzzzzzzzg_);

            return mzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?> jzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<(CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?>(jzzzzzzzzzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzzzzzzzzzn_);
        CqlDate jzzzzzzzzzzzzzzzzzzzzzzp_((CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)? tuple_eipfmazvhfscjijaofhicpvmb)
        {
            DataType mzzzzzzzzzzzzzzzzzzzzzzi_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSLifeQuality?.Effective;
            object mzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzzzzzzl_);
            DataType mzzzzzzzzzzzzzzzzzzzzzzn_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSport?.Effective;
            object mzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzzzzzzq_);
            DataType mzzzzzzzzzzzzzzzzzzzzzzs_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSActivityScore?.Effective;
            object mzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzzzzzzv_);
            DataType mzzzzzzzzzzzzzzzzzzzzzzx_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSymptoms?.Effective;
            object mzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDate nzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzzzzzzza_);
            DataType nzzzzzzzzzzzzzzzzzzzzzzc_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSPain?.Effective;
            object nzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDate nzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDate[] nzzzzzzzzzzzzzzzzzzzzzzh_ = [
                mzzzzzzzzzzzzzzzzzzzzzzm_,
                mzzzzzzzzzzzzzzzzzzzzzzr_,
                mzzzzzzzzzzzzzzzzzzzzzzw_,
                nzzzzzzzzzzzzzzzzzzzzzzb_,
                nzzzzzzzzzzzzzzzzzzzzzzg_,
            ];
            CqlDate nzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Max<CqlDate>(nzzzzzzzzzzzzzzzzzzzzzzh_ as IEnumerable<CqlDate>);

            return nzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?, CqlDate>(jzzzzzzzzzzzzzzzzzzzzzzo_, jzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Distinct<CqlDate>(jzzzzzzzzzzzzzzzzzzzzzzq_);

        return jzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up HOOS Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments(CqlContext context)
    {
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzzzzzzzj_ = this.Total_Hip_Arthroplasty_Procedure(context);
        CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzk_(Procedure THAProcedure)
        {
            DataType nzzzzzzzzzzzzzzzzzzzzzzs_ = THAProcedure?.Performed;
            object nzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzzt_);

            return nzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> nzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(nzzzzzzzzzzzzzzzzzzzzzzj_, nzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<CqlInterval<CqlDateTime>> nzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(nzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<CqlInterval<CqlDateTime>> nzzzzzzzzzzzzzzzzzzzzzzn_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> nzzzzzzzzzzzzzzzzzzzzzzv_ = this.Date_HOOS_Total_Assessment_Completed(context);
            bool? nzzzzzzzzzzzzzzzzzzzzzzw_(CqlDate InitialHipAssessmentHOOS)
            {
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(TotalHip);
                CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(90m, "days");
                CqlDate ozzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Add(InitialHipAssessmentHOOS, ozzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDate> ozzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Interval(InitialHipAssessmentHOOS, ozzzzzzzzzzzzzzzzzzzzzzc_, true, true);
                CqlDate ozzzzzzzzzzzzzzzzzzzzzze_ = ozzzzzzzzzzzzzzzzzzzzzzd_?.low;
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConvertDateToDateTime(ozzzzzzzzzzzzzzzzzzzzzze_);
                CqlDate ozzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Add(InitialHipAssessmentHOOS, ozzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDate> ozzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(InitialHipAssessmentHOOS, ozzzzzzzzzzzzzzzzzzzzzzh_, true, true);
                CqlDate ozzzzzzzzzzzzzzzzzzzzzzj_ = ozzzzzzzzzzzzzzzzzzzzzzi_?.high;
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertDateToDateTime(ozzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDate ozzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Add(InitialHipAssessmentHOOS, ozzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDate> ozzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(InitialHipAssessmentHOOS, ozzzzzzzzzzzzzzzzzzzzzzm_, true, true);
                bool? ozzzzzzzzzzzzzzzzzzzzzzo_ = ozzzzzzzzzzzzzzzzzzzzzzn_?.lowClosed;
                CqlDate ozzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Add(InitialHipAssessmentHOOS, ozzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDate> ozzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(InitialHipAssessmentHOOS, ozzzzzzzzzzzzzzzzzzzzzzq_, true, true);
                bool? ozzzzzzzzzzzzzzzzzzzzzzs_ = ozzzzzzzzzzzzzzzzzzzzzzr_?.highClosed;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzzzzzzf_, ozzzzzzzzzzzzzzzzzzzzzzk_, ozzzzzzzzzzzzzzzzzzzzzzo_, ozzzzzzzzzzzzzzzzzzzzzzs_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzza_, ozzzzzzzzzzzzzzzzzzzzzzt_, "day");
                bool? ozzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(InitialHipAssessmentHOOS is null));
                bool? ozzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzzzzzzzzzv_);

                return ozzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<CqlDate> nzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<CqlDate>(nzzzzzzzzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzy_(CqlDate InitialHipAssessmentHOOS) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> nzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(nzzzzzzzzzzzzzzzzzzzzzzx_, nzzzzzzzzzzzzzzzzzzzzzzy_);

            return nzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> nzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(nzzzzzzzzzzzzzzzzzzzzzzm_, nzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<CqlInterval<CqlDateTime>> nzzzzzzzzzzzzzzzzzzzzzzp_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> ozzzzzzzzzzzzzzzzzzzzzzx_ = this.Date_HOOS_Total_Assessment_Completed(context);
            bool? ozzzzzzzzzzzzzzzzzzzzzzy_(CqlDate FollowUpHipAssessmentHOOS)
            {
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentHOOS);
                CqlDate pzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.End(TotalHip);
                CqlDate pzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzzzzzzze_);
                CqlQuantity pzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(300m, "days");
                CqlDate pzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Add(pzzzzzzzzzzzzzzzzzzzzzzf_, pzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDate pzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzzzzzzze_);
                CqlQuantity pzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(425m, "days");
                CqlDate pzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Add(pzzzzzzzzzzzzzzzzzzzzzzj_, pzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(pzzzzzzzzzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzzzzzzzzzl_, true, true);
                bool? pzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzd_, pzzzzzzzzzzzzzzzzzzzzzzm_, "day");

                return pzzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<CqlDate> ozzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<CqlDate>(ozzzzzzzzzzzzzzzzzzzzzzx_, ozzzzzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzza_(CqlDate FollowUpHipAssessmentHOOS) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(ozzzzzzzzzzzzzzzzzzzzzzz_, pzzzzzzzzzzzzzzzzzzzzzza_);

            return pzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> nzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(nzzzzzzzzzzzzzzzzzzzzzzo_, nzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(nzzzzzzzzzzzzzzzzzzzzzzq_);

        return nzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Date HOOSJr Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_HOOSJr_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode pzzzzzzzzzzzzzzzzzzzzzzo_ = this.Total_interval_score__HOOSJR_(context);
        IEnumerable<CqlCode> pzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ToList<CqlCode>(pzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, pzzzzzzzzzzzzzzzzzzzzzzp_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzr_ = Status_1_8_000.Instance.isAssessmentPerformed(context, pzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzs_(Observation HOOSJr)
        {
            DataType pzzzzzzzzzzzzzzzzzzzzzzx_ = HOOSJr?.Value;
            object pzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzzzzzzzzzzy_ is null));

            return pzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlDate pzzzzzzzzzzzzzzzzzzzzzzu_(Observation DocumentedHOOSJr)
        {
            DataType qzzzzzzzzzzzzzzzzzzzzzza_ = DocumentedHOOSJr?.Effective;
            object qzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDate qzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzzzzzzzzzd_);

            return qzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Observation, CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzt_, pzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Distinct<CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzv_);

        return pzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up HOOSJr Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments(CqlContext context)
    {
        IEnumerable<Procedure> qzzzzzzzzzzzzzzzzzzzzzzf_ = this.Total_Hip_Arthroplasty_Procedure(context);
        CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzg_(Procedure THAProcedure)
        {
            DataType qzzzzzzzzzzzzzzzzzzzzzzo_ = THAProcedure?.Performed;
            object qzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzzzzzp_);

            return qzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> qzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(qzzzzzzzzzzzzzzzzzzzzzzf_, qzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<CqlInterval<CqlDateTime>> qzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(qzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<CqlInterval<CqlDateTime>> qzzzzzzzzzzzzzzzzzzzzzzj_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzr_ = this.Date_HOOSJr_Total_Assessment_Completed(context);
            bool? qzzzzzzzzzzzzzzzzzzzzzzs_(CqlDate InitialHipAssessment)
            {
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(TotalHip);
                CqlQuantity qzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(90m, "days");
                CqlDate qzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Add(InitialHipAssessment, qzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(InitialHipAssessment, qzzzzzzzzzzzzzzzzzzzzzzy_, true, true);
                CqlDate rzzzzzzzzzzzzzzzzzzzzzza_ = qzzzzzzzzzzzzzzzzzzzzzzz_?.low;
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConvertDateToDateTime(rzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDate rzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Add(InitialHipAssessment, qzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDate> rzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(InitialHipAssessment, rzzzzzzzzzzzzzzzzzzzzzzd_, true, true);
                CqlDate rzzzzzzzzzzzzzzzzzzzzzzf_ = rzzzzzzzzzzzzzzzzzzzzzze_?.high;
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertDateToDateTime(rzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDate rzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Add(InitialHipAssessment, qzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDate> rzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(InitialHipAssessment, rzzzzzzzzzzzzzzzzzzzzzzi_, true, true);
                bool? rzzzzzzzzzzzzzzzzzzzzzzk_ = rzzzzzzzzzzzzzzzzzzzzzzj_?.lowClosed;
                CqlDate rzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Add(InitialHipAssessment, qzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDate> rzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(InitialHipAssessment, rzzzzzzzzzzzzzzzzzzzzzzm_, true, true);
                bool? rzzzzzzzzzzzzzzzzzzzzzzo_ = rzzzzzzzzzzzzzzzzzzzzzzn_?.highClosed;
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzzzzzzzzzg_, rzzzzzzzzzzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzzzzzzzzzzo_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzzzzzzzzzzp_, "day");
                bool? rzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(InitialHipAssessment is null));
                bool? rzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzq_, rzzzzzzzzzzzzzzzzzzzzzzr_);

                return rzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<CqlDate>(qzzzzzzzzzzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzu_(CqlDate InitialHipAssessment) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> qzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(qzzzzzzzzzzzzzzzzzzzzzzt_, qzzzzzzzzzzzzzzzzzzzzzzu_);

            return qzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> qzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(qzzzzzzzzzzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<CqlInterval<CqlDateTime>> qzzzzzzzzzzzzzzzzzzzzzzl_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> rzzzzzzzzzzzzzzzzzzzzzzt_ = this.Date_HOOSJr_Total_Assessment_Completed(context);
            bool? rzzzzzzzzzzzzzzzzzzzzzzu_(CqlDate FollowUpHipAssessment)
            {
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessment);
                CqlDate rzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.End(TotalHip);
                CqlDate szzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzzzzzzza_);
                CqlQuantity szzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(300m, "days");
                CqlDate szzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Add(szzzzzzzzzzzzzzzzzzzzzzb_, szzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDate szzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzzzzzzza_);
                CqlQuantity szzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(425m, "days");
                CqlDate szzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Add(szzzzzzzzzzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDate> szzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(szzzzzzzzzzzzzzzzzzzzzzd_, szzzzzzzzzzzzzzzzzzzzzzh_, true, true);
                bool? szzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDate>(rzzzzzzzzzzzzzzzzzzzzzzz_, szzzzzzzzzzzzzzzzzzzzzzi_, "day");

                return szzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<CqlDate> rzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<CqlDate>(rzzzzzzzzzzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzw_(CqlDate FollowUpHipAssessment) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> rzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(rzzzzzzzzzzzzzzzzzzzzzzv_, rzzzzzzzzzzzzzzzzzzzzzzw_);

            return rzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> qzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(qzzzzzzzzzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(qzzzzzzzzzzzzzzzzzzzzzzm_);

        return qzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Date PROMIS10 Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_PROMIS10_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode szzzzzzzzzzzzzzzzzzzzzzk_ = this.PROMIS_10_Global_Mental_Health__GMH__score_T_score(context);
        IEnumerable<CqlCode> szzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ToList<CqlCode>(szzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, szzzzzzzzzzzzzzzzzzzzzzl_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzn_ = Status_1_8_000.Instance.isAssessmentPerformed(context, szzzzzzzzzzzzzzzzzzzzzzm_);
        CqlCode szzzzzzzzzzzzzzzzzzzzzzo_ = this.PROMIS_10_Global_Physical_Health__GPH__score_T_score(context);
        IEnumerable<CqlCode> szzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ToList<CqlCode>(szzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, szzzzzzzzzzzzzzzzzzzzzzp_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzr_ = Status_1_8_000.Instance.isAssessmentPerformed(context, szzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<ValueTuple<Observation, Observation>> szzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.CrossJoin<Observation, Observation>(szzzzzzzzzzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzzzzzzzzzr_);
        (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? szzzzzzzzzzzzzzzzzzzzzzt_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? tzzzzzzzzzzzzzzzzzzzzzza_ = (CqlTupleMetadata_DDTAOdcFieSJbGgRLLZPYbGQb, _valueTuple.Item1, _valueTuple.Item2);

            return tzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?> szzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?>(szzzzzzzzzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzzzzzzzzt_);
        bool? szzzzzzzzzzzzzzzzzzzzzzv_((CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? tuple_ddtaodcfiesjbggrllzpybgqb)
        {
            DataType tzzzzzzzzzzzzzzzzzzzzzzb_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Effective;
            object tzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzze_);
            DataType tzzzzzzzzzzzzzzzzzzzzzzg_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Effective;
            object tzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SameAs(tzzzzzzzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzzzzzzzk_, "day");
            DataType tzzzzzzzzzzzzzzzzzzzzzzm_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Value;
            object tzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzzzzzzn_ is null));
            bool? tzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzzzzzzzzzzo_);
            DataType tzzzzzzzzzzzzzzzzzzzzzzq_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Value;
            object tzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzzzzzzr_ is null));
            bool? tzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzp_, tzzzzzzzzzzzzzzzzzzzzzzs_);

            return tzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?> szzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?>(szzzzzzzzzzzzzzzzzzzzzzu_, szzzzzzzzzzzzzzzzzzzzzzv_);
        CqlDate szzzzzzzzzzzzzzzzzzzzzzx_((CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? tuple_ddtaodcfiesjbggrllzpybgqb)
        {
            DataType tzzzzzzzzzzzzzzzzzzzzzzu_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Effective;
            object tzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzx_);
            DataType tzzzzzzzzzzzzzzzzzzzzzzz_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Effective;
            object uzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDate uzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDate[] uzzzzzzzzzzzzzzzzzzzzzze_ = [
                tzzzzzzzzzzzzzzzzzzzzzzy_,
                uzzzzzzzzzzzzzzzzzzzzzzd_,
            ];
            CqlDate uzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Max<CqlDate>(uzzzzzzzzzzzzzzzzzzzzzze_ as IEnumerable<CqlDate>);

            return uzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<CqlDate> szzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?, CqlDate>(szzzzzzzzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<CqlDate> szzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Distinct<CqlDate>(szzzzzzzzzzzzzzzzzzzzzzy_);

        return szzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up PROMIS10 Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments(CqlContext context)
    {
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzg_ = this.Total_Hip_Arthroplasty_Procedure(context);
        CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzh_(Procedure THAProcedure)
        {
            DataType uzzzzzzzzzzzzzzzzzzzzzzp_ = THAProcedure?.Performed;
            object uzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzzzzzzzzzq_);

            return uzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> uzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(uzzzzzzzzzzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<CqlInterval<CqlDateTime>> uzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(uzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<CqlInterval<CqlDateTime>> uzzzzzzzzzzzzzzzzzzzzzzk_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> uzzzzzzzzzzzzzzzzzzzzzzs_ = this.Date_PROMIS10_Total_Assessment_Completed(context);
            bool? uzzzzzzzzzzzzzzzzzzzzzzt_(CqlDate InitialHipAssessmentPROMIS10)
            {
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(TotalHip);
                CqlQuantity uzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(90m, "days");
                CqlDate uzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Add(InitialHipAssessmentPROMIS10, uzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDate> vzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(InitialHipAssessmentPROMIS10, uzzzzzzzzzzzzzzzzzzzzzzz_, true, true);
                CqlDate vzzzzzzzzzzzzzzzzzzzzzzb_ = vzzzzzzzzzzzzzzzzzzzzzza_?.low;
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConvertDateToDateTime(vzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDate vzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Add(InitialHipAssessmentPROMIS10, uzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(InitialHipAssessmentPROMIS10, vzzzzzzzzzzzzzzzzzzzzzze_, true, true);
                CqlDate vzzzzzzzzzzzzzzzzzzzzzzg_ = vzzzzzzzzzzzzzzzzzzzzzzf_?.high;
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertDateToDateTime(vzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDate vzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Add(InitialHipAssessmentPROMIS10, uzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(InitialHipAssessmentPROMIS10, vzzzzzzzzzzzzzzzzzzzzzzj_, true, true);
                bool? vzzzzzzzzzzzzzzzzzzzzzzl_ = vzzzzzzzzzzzzzzzzzzzzzzk_?.lowClosed;
                CqlDate vzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Add(InitialHipAssessmentPROMIS10, uzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(InitialHipAssessmentPROMIS10, vzzzzzzzzzzzzzzzzzzzzzzn_, true, true);
                bool? vzzzzzzzzzzzzzzzzzzzzzzp_ = vzzzzzzzzzzzzzzzzzzzzzzo_?.highClosed;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzzzzzzzzh_, vzzzzzzzzzzzzzzzzzzzzzzl_, vzzzzzzzzzzzzzzzzzzzzzzp_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzx_, vzzzzzzzzzzzzzzzzzzzzzzq_, "day");
                bool? vzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(InitialHipAssessmentPROMIS10 is null));
                bool? vzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzzzzzzzzs_);

                return vzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<CqlDate> uzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<CqlDate>(uzzzzzzzzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzv_(CqlDate InitialHipAssessmentPROMIS10) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> uzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(uzzzzzzzzzzzzzzzzzzzzzzu_, uzzzzzzzzzzzzzzzzzzzzzzv_);

            return uzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> uzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(uzzzzzzzzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<CqlInterval<CqlDateTime>> uzzzzzzzzzzzzzzzzzzzzzzm_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzu_ = this.Date_PROMIS10_Total_Assessment_Completed(context);
            bool? vzzzzzzzzzzzzzzzzzzzzzzv_(CqlDate FollowUpHipAssessmentPROMIS10)
            {
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentPROMIS10);
                CqlDate wzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.End(TotalHip);
                CqlDate wzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlQuantity wzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(300m, "days");
                CqlDate wzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Add(wzzzzzzzzzzzzzzzzzzzzzzc_, wzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDate wzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlQuantity wzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(425m, "days");
                CqlDate wzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Add(wzzzzzzzzzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(wzzzzzzzzzzzzzzzzzzzzzze_, wzzzzzzzzzzzzzzzzzzzzzzi_, true, true);
                bool? wzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDate>(wzzzzzzzzzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzzzzzzzzzj_, "day");

                return wzzzzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<CqlDate>(vzzzzzzzzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzx_(CqlDate FollowUpHipAssessmentPROMIS10) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> vzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(vzzzzzzzzzzzzzzzzzzzzzzw_, vzzzzzzzzzzzzzzzzzzzzzzx_);

            return vzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> uzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(uzzzzzzzzzzzzzzzzzzzzzzl_, uzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(uzzzzzzzzzzzzzzzzzzzzzzn_);

        return uzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Date VR12 Oblique Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR12_Oblique_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode wzzzzzzzzzzzzzzzzzzzzzzl_ = this.VR_12_Mental_component_summary__MCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> wzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ToList<CqlCode>(wzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, wzzzzzzzzzzzzzzzzzzzzzzm_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzo_ = Status_1_8_000.Instance.isAssessmentPerformed(context, wzzzzzzzzzzzzzzzzzzzzzzn_);
        CqlCode wzzzzzzzzzzzzzzzzzzzzzzp_ = this.VR_12_Physical_component_summary__PCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> wzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ToList<CqlCode>(wzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, wzzzzzzzzzzzzzzzzzzzzzzq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzs_ = Status_1_8_000.Instance.isAssessmentPerformed(context, wzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<ValueTuple<Observation, Observation>> wzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.CrossJoin<Observation, Observation>(wzzzzzzzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzzzzzzzs_);
        (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? wzzzzzzzzzzzzzzzzzzzzzzu_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? xzzzzzzzzzzzzzzzzzzzzzzb_ = (CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH, _valueTuple.Item1, _valueTuple.Item2);

            return xzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> wzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(wzzzzzzzzzzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzw_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType xzzzzzzzzzzzzzzzzzzzzzzc_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object xzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDate xzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzzzzzzzf_);
            DataType xzzzzzzzzzzzzzzzzzzzzzzh_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object xzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDate xzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SameAs(xzzzzzzzzzzzzzzzzzzzzzzg_, xzzzzzzzzzzzzzzzzzzzzzzl_, "day");
            DataType xzzzzzzzzzzzzzzzzzzzzzzn_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Value;
            object xzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzzzzzzzzzo_ is null));
            bool? xzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzzzzzzzzzp_);
            DataType xzzzzzzzzzzzzzzzzzzzzzzr_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Value;
            object xzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzzzzzzzzzs_ is null));
            bool? xzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzzzzzzzzzt_);

            return xzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> wzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(wzzzzzzzzzzzzzzzzzzzzzzv_, wzzzzzzzzzzzzzzzzzzzzzzw_);
        CqlDate wzzzzzzzzzzzzzzzzzzzzzzy_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType xzzzzzzzzzzzzzzzzzzzzzzv_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object xzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDate xzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzzzzzzzy_);
            DataType yzzzzzzzzzzzzzzzzzzzzzza_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object yzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDate yzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDate[] yzzzzzzzzzzzzzzzzzzzzzzf_ = [
                xzzzzzzzzzzzzzzzzzzzzzzz_,
                yzzzzzzzzzzzzzzzzzzzzzze_,
            ];
            CqlDate yzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Max<CqlDate>(yzzzzzzzzzzzzzzzzzzzzzzf_ as IEnumerable<CqlDate>);

            return yzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?, CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzx_, wzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<CqlDate> xzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Distinct<CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzz_);

        return xzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up VR12 Oblique Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments(CqlContext context)
    {
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzzzzzzzh_ = this.Total_Hip_Arthroplasty_Procedure(context);
        CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzi_(Procedure THAProcedure)
        {
            DataType yzzzzzzzzzzzzzzzzzzzzzzq_ = THAProcedure?.Performed;
            object yzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzzzzzzzr_);

            return yzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(yzzzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(yzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzzzzzzzzzzzzzzzl_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzt_ = this.Date_VR12_Oblique_Total_Assessment_Completed(context);
            bool? yzzzzzzzzzzzzzzzzzzzzzzu_(CqlDate InitialHipAssessmentOblique)
            {
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(TotalHip);
                CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(90m, "days");
                CqlDate zzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Add(InitialHipAssessmentOblique, yzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(InitialHipAssessmentOblique, zzzzzzzzzzzzzzzzzzzzzzza_, true, true);
                CqlDate zzzzzzzzzzzzzzzzzzzzzzzc_ = zzzzzzzzzzzzzzzzzzzzzzzb_?.low;
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertDateToDateTime(zzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDate zzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Add(InitialHipAssessmentOblique, yzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(InitialHipAssessmentOblique, zzzzzzzzzzzzzzzzzzzzzzzf_, true, true);
                CqlDate zzzzzzzzzzzzzzzzzzzzzzzh_ = zzzzzzzzzzzzzzzzzzzzzzzg_?.high;
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConvertDateToDateTime(zzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDate zzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Add(InitialHipAssessmentOblique, yzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(InitialHipAssessmentOblique, zzzzzzzzzzzzzzzzzzzzzzzk_, true, true);
                bool? zzzzzzzzzzzzzzzzzzzzzzzm_ = zzzzzzzzzzzzzzzzzzzzzzzl_?.lowClosed;
                CqlDate zzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Add(InitialHipAssessmentOblique, yzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(InitialHipAssessmentOblique, zzzzzzzzzzzzzzzzzzzzzzzo_, true, true);
                bool? zzzzzzzzzzzzzzzzzzzzzzzq_ = zzzzzzzzzzzzzzzzzzzzzzzp_?.highClosed;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzzzzzzzzzi_, zzzzzzzzzzzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? zzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzzzzzzzzzzr_, "day");
                bool? zzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(InitialHipAssessmentOblique is null));
                bool? zzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzzzzzzzt_);

                return zzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<CqlDate>(yzzzzzzzzzzzzzzzzzzzzzzt_, yzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzw_(CqlDate InitialHipAssessmentOblique) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(yzzzzzzzzzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzzzzzzzzzw_);

            return yzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(yzzzzzzzzzzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzzzzzzzzzzzzzzzn_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzv_ = this.Date_VR12_Oblique_Total_Assessment_Completed(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzw_(CqlDate FollowUpHipAssessmentOblique)
            {
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentOblique);
                CqlDate azzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.End(TotalHip);
                CqlDate azzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlQuantity azzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(300m, "days");
                CqlDate azzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Add(azzzzzzzzzzzzzzzzzzzzzzzd_, azzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDate azzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlQuantity azzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(425m, "days");
                CqlDate azzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Add(azzzzzzzzzzzzzzzzzzzzzzzh_, azzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(azzzzzzzzzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzzzzzzzzj_, true, true);
                bool? azzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzb_, azzzzzzzzzzzzzzzzzzzzzzzk_, "day");

                return azzzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<CqlDate>(zzzzzzzzzzzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzy_(CqlDate FollowUpHipAssessmentOblique) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> zzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(zzzzzzzzzzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzzzzzzzzzy_);

            return zzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(yzzzzzzzzzzzzzzzzzzzzzzm_, yzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(yzzzzzzzzzzzzzzzzzzzzzzo_);

        return yzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Date VR12 Orthogonal Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR12_Orthogonal_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode azzzzzzzzzzzzzzzzzzzzzzzm_ = this.VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> azzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ToList<CqlCode>(azzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, azzzzzzzzzzzzzzzzzzzzzzzn_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzp_ = Status_1_8_000.Instance.isAssessmentPerformed(context, azzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlCode azzzzzzzzzzzzzzzzzzzzzzzq_ = this.VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> azzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ToList<CqlCode>(azzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, azzzzzzzzzzzzzzzzzzzzzzzr_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzt_ = Status_1_8_000.Instance.isAssessmentPerformed(context, azzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<ValueTuple<Observation, Observation>> azzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.CrossJoin<Observation, Observation>(azzzzzzzzzzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzzzzzzzzzt_);
        (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? azzzzzzzzzzzzzzzzzzzzzzzv_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? bzzzzzzzzzzzzzzzzzzzzzzzc_ = (CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH, _valueTuple.Item1, _valueTuple.Item2);

            return bzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> azzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(azzzzzzzzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzx_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType bzzzzzzzzzzzzzzzzzzzzzzzd_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object bzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDate bzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzg_);
            DataType bzzzzzzzzzzzzzzzzzzzzzzzi_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object bzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDate bzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SameAs(bzzzzzzzzzzzzzzzzzzzzzzzh_, bzzzzzzzzzzzzzzzzzzzzzzzm_, "day");
            DataType bzzzzzzzzzzzzzzzzzzzzzzzo_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Value;
            object bzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzzzzzzzzp_ is null));
            bool? bzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzzzzzzzzq_);
            DataType bzzzzzzzzzzzzzzzzzzzzzzzs_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Value;
            object bzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzzzzzzzzt_ is null));
            bool? bzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzzzzzzzzzzu_);

            return bzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> azzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(azzzzzzzzzzzzzzzzzzzzzzzw_, azzzzzzzzzzzzzzzzzzzzzzzx_);
        CqlDate azzzzzzzzzzzzzzzzzzzzzzzz_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType bzzzzzzzzzzzzzzzzzzzzzzzw_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object bzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDate czzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzz_);
            DataType czzzzzzzzzzzzzzzzzzzzzzzb_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object czzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDate czzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDate[] czzzzzzzzzzzzzzzzzzzzzzzg_ = [
                czzzzzzzzzzzzzzzzzzzzzzza_,
                czzzzzzzzzzzzzzzzzzzzzzzf_,
            ];
            CqlDate czzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Max<CqlDate>(czzzzzzzzzzzzzzzzzzzzzzzg_ as IEnumerable<CqlDate>);

            return czzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<CqlDate> bzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?, CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzy_, azzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<CqlDate> bzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Distinct<CqlDate>(bzzzzzzzzzzzzzzzzzzzzzzza_);

        return bzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up VR12 Orthogonal Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments(CqlContext context)
    {
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzzzzzi_ = this.Total_Hip_Arthroplasty_Procedure(context);
        CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzj_(Procedure THAProcedure)
        {
            DataType czzzzzzzzzzzzzzzzzzzzzzzr_ = THAProcedure?.Performed;
            object czzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzzzzzzs_);

            return czzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> czzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(czzzzzzzzzzzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<CqlInterval<CqlDateTime>> czzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(czzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<CqlInterval<CqlDateTime>> czzzzzzzzzzzzzzzzzzzzzzzm_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> czzzzzzzzzzzzzzzzzzzzzzzu_ = this.Date_VR12_Orthogonal_Total_Assessment_Completed(context);
            bool? czzzzzzzzzzzzzzzzzzzzzzzv_(CqlDate InitialHipAssessmentOrthogonal)
            {
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(TotalHip);
                CqlQuantity dzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(90m, "days");
                CqlDate dzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Add(InitialHipAssessmentOrthogonal, dzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(InitialHipAssessmentOrthogonal, dzzzzzzzzzzzzzzzzzzzzzzzb_, true, true);
                CqlDate dzzzzzzzzzzzzzzzzzzzzzzzd_ = dzzzzzzzzzzzzzzzzzzzzzzzc_?.low;
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertDateToDateTime(dzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDate dzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Add(InitialHipAssessmentOrthogonal, dzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(InitialHipAssessmentOrthogonal, dzzzzzzzzzzzzzzzzzzzzzzzg_, true, true);
                CqlDate dzzzzzzzzzzzzzzzzzzzzzzzi_ = dzzzzzzzzzzzzzzzzzzzzzzzh_?.high;
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertDateToDateTime(dzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDate dzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Add(InitialHipAssessmentOrthogonal, dzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(InitialHipAssessmentOrthogonal, dzzzzzzzzzzzzzzzzzzzzzzzl_, true, true);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzn_ = dzzzzzzzzzzzzzzzzzzzzzzzm_?.lowClosed;
                CqlDate dzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Add(InitialHipAssessmentOrthogonal, dzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(InitialHipAssessmentOrthogonal, dzzzzzzzzzzzzzzzzzzzzzzzp_, true, true);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzr_ = dzzzzzzzzzzzzzzzzzzzzzzzq_?.highClosed;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzzzzzzzzj_, dzzzzzzzzzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzzzzzzzzzr_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzz_, dzzzzzzzzzzzzzzzzzzzzzzzs_, "day");
                bool? dzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(InitialHipAssessmentOrthogonal is null));
                bool? dzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzzzzzzzzzzzu_);

                return dzzzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<CqlDate> czzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<CqlDate>(czzzzzzzzzzzzzzzzzzzzzzzu_, czzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzx_(CqlDate InitialHipAssessmentOrthogonal) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> czzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(czzzzzzzzzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzzzzzzzzx_);

            return czzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> czzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(czzzzzzzzzzzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<CqlInterval<CqlDateTime>> czzzzzzzzzzzzzzzzzzzzzzzo_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Date_VR12_Orthogonal_Total_Assessment_Completed(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzx_(CqlDate FollowUpHipAssessmentOrthogonal)
            {
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentOrthogonal);
                CqlDate ezzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.End(TotalHip);
                CqlDate ezzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlQuantity ezzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(300m, "days");
                CqlDate ezzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Add(ezzzzzzzzzzzzzzzzzzzzzzze_, ezzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDate ezzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlQuantity ezzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(425m, "days");
                CqlDate ezzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Add(ezzzzzzzzzzzzzzzzzzzzzzzi_, ezzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzzzzzzzzzzk_, true, true);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDate>(ezzzzzzzzzzzzzzzzzzzzzzzc_, ezzzzzzzzzzzzzzzzzzzzzzzl_, "day");

                return ezzzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<CqlDate>(dzzzzzzzzzzzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzz_(CqlDate FollowUpHipAssessmentOrthogonal) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> ezzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(dzzzzzzzzzzzzzzzzzzzzzzzy_, dzzzzzzzzzzzzzzzzzzzzzzzz_);

            return ezzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> czzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(czzzzzzzzzzzzzzzzzzzzzzzn_, czzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(czzzzzzzzzzzzzzzzzzzzzzzp_);

        return czzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? ezzzzzzzzzzzzzzzzzzzzzzzn_ = this.Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzo_ = this.Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Or(ezzzzzzzzzzzzzzzzzzzzzzzn_, ezzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzq_ = this.Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(ezzzzzzzzzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzs_ = this.Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Or(ezzzzzzzzzzzzzzzzzzzzzzzr_, ezzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzu_ = this.Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(ezzzzzzzzzzzzzzzzzzzzzzzt_, ezzzzzzzzzzzzzzzzzzzzzzzu_);

        return ezzzzzzzzzzzzzzzzzzzzzzzv_;
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
