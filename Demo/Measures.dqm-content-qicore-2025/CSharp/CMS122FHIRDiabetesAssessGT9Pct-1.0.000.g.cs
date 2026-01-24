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
using Hl7.Cql.Runtime.Internal;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "6.0.0.0")]
[CqlLibrary("CMS122FHIRDiabetesAssessGT9Pct", "1.0.000")]
public partial class CMS122FHIRDiabetesAssessGT9Pct_1_0_000 : ILibrary, ILibraryInternals, ISingleton<CMS122FHIRDiabetesAssessGT9Pct_1_0_000>
{
    #region ValueSets (9)

    [CqlValueSetDefinition("Annual Wellness Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", valueSetVersion: null)]
    public CqlValueSet Annual_Wellness_Visit(CqlContext _) => _Annual_Wellness_Visit;
    private static readonly CqlValueSet _Annual_Wellness_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlValueSetDefinition("Diabetes", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", valueSetVersion: null)]
    public CqlValueSet Diabetes(CqlContext _) => _Diabetes;
    private static readonly CqlValueSet _Diabetes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", null);

    [CqlValueSetDefinition("HbA1c Laboratory Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1013", valueSetVersion: null)]
    public CqlValueSet HbA1c_Laboratory_Test(CqlContext _) => _HbA1c_Laboratory_Test;
    private static readonly CqlValueSet _HbA1c_Laboratory_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1013", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("Nutrition Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1006", valueSetVersion: null)]
    public CqlValueSet Nutrition_Services(CqlContext _) => _Nutrition_Services;
    private static readonly CqlValueSet _Nutrition_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1006", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Preventive Care Services Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    #endregion ValueSets

    #region Codes (6)

    [CqlCodeDefinition("Glucose management indicator", codeId: "97506-0", codeSystem: "http://loinc.org")]
    public CqlCode Glucose_management_indicator(CqlContext _) => _Glucose_management_indicator;
    private static readonly CqlCode _Glucose_management_indicator = new CqlCode("97506-0", "http://loinc.org");

    [CqlCodeDefinition("Medical nutrition therapy, reassessment and subsequent intervention(s) following second referral in same year for change in diagnosis, medical condition, or treatment regimen (including additional hours needed for renal disease), group (2 or more individuals), each 30 minutes", codeId: "G0271", codeSystem: "http://www.cms.gov/Medicare/Coding/HCPCSReleaseCodeSets")]
    public CqlCode Medical_nutrition_therapy__reassessment_and_subsequent_intervention_s__following_second_referral_in_same_year_for_change_in_diagnosis__medical_condition__or_treatment_regimen__including_additional_hours_needed_for_renal_disease___group__2_or_more_individuals___each_30_minutes(CqlContext _) => _Medical_nutrition_therapy__reassessment_and_subsequent_intervention_s__following_second_referral_in_same_year_for_change_in_diagnosis__medical_condition__or_treatment_regimen__including_additional_hours_needed_for_renal_disease___group__2_or_more_individuals___each_30_minutes;
    private static readonly CqlCode _Medical_nutrition_therapy__reassessment_and_subsequent_intervention_s__following_second_referral_in_same_year_for_change_in_diagnosis__medical_condition__or_treatment_regimen__including_additional_hours_needed_for_renal_disease___group__2_or_more_individuals___each_30_minutes = new CqlCode("G0271", "http://www.cms.gov/Medicare/Coding/HCPCSReleaseCodeSets");

    [CqlCodeDefinition("Medical nutrition therapy; group (2 or more individual(s)), each 30 minutes", codeId: "97804", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Medical_nutrition_therapy__group__2_or_more_individual_s____each_30_minutes(CqlContext _) => _Medical_nutrition_therapy__group__2_or_more_individual_s____each_30_minutes;
    private static readonly CqlCode _Medical_nutrition_therapy__group__2_or_more_individual_s____each_30_minutes = new CqlCode("97804", "http://www.ama-assn.org/go/cpt");

    [CqlCodeDefinition("Medical nutrition therapy; initial assessment and intervention, individual, face-to-face with the patient, each 15 minutes", codeId: "97802", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Medical_nutrition_therapy__initial_assessment_and_intervention__individual__face_to_face_with_the_patient__each_15_minutes(CqlContext _) => _Medical_nutrition_therapy__initial_assessment_and_intervention__individual__face_to_face_with_the_patient__each_15_minutes;
    private static readonly CqlCode _Medical_nutrition_therapy__initial_assessment_and_intervention__individual__face_to_face_with_the_patient__each_15_minutes = new CqlCode("97802", "http://www.ama-assn.org/go/cpt");

    [CqlCodeDefinition("Medical nutrition therapy; re-assessment and intervention, individual, face-to-face with the patient, each 15 minutes", codeId: "97803", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Medical_nutrition_therapy__re_assessment_and_intervention__individual__face_to_face_with_the_patient__each_15_minutes(CqlContext _) => _Medical_nutrition_therapy__re_assessment_and_intervention__individual__face_to_face_with_the_patient__each_15_minutes;
    private static readonly CqlCode _Medical_nutrition_therapy__re_assessment_and_intervention__individual__face_to_face_with_the_patient__each_15_minutes = new CqlCode("97803", "http://www.ama-assn.org/go/cpt");

    [CqlCodeDefinition("Medical nutrition therapy; reassessment and subsequent intervention(s) following second referral in same year for change in diagnosis, medical condition or treatment regimen (including additional hours needed for renal disease), individual, face to face with the patient, each 15 minutes", codeId: "G0270", codeSystem: "http://www.cms.gov/Medicare/Coding/HCPCSReleaseCodeSets")]
    public CqlCode Medical_nutrition_therapy__reassessment_and_subsequent_intervention_s__following_second_referral_in_same_year_for_change_in_diagnosis__medical_condition_or_treatment_regimen__including_additional_hours_needed_for_renal_disease___individual__face_to_face_with_the_patient__each_15_minutes(CqlContext _) => _Medical_nutrition_therapy__reassessment_and_subsequent_intervention_s__following_second_referral_in_same_year_for_change_in_diagnosis__medical_condition_or_treatment_regimen__including_additional_hours_needed_for_renal_disease___individual__face_to_face_with_the_patient__each_15_minutes;
    private static readonly CqlCode _Medical_nutrition_therapy__reassessment_and_subsequent_intervention_s__following_second_referral_in_same_year_for_change_in_diagnosis__medical_condition_or_treatment_regimen__including_additional_hours_needed_for_renal_disease___individual__face_to_face_with_the_patient__each_15_minutes = new CqlCode("G0270", "http://www.cms.gov/Medicare/Coding/HCPCSReleaseCodeSets");

    #endregion Codes

    #region CodeSystems (3)

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Glucose_management_indicator]);

    [CqlCodeSystemDefinition("HCPCS", codeSystemId: "http://www.cms.gov/Medicare/Coding/HCPCSReleaseCodeSets", codeSystemVersion: null)]
    public CqlCodeSystem HCPCS(CqlContext _) => _HCPCS;
    private static readonly CqlCodeSystem _HCPCS =
      new CqlCodeSystem("http://www.cms.gov/Medicare/Coding/HCPCSReleaseCodeSets", null, [
          _Medical_nutrition_therapy__reassessment_and_subsequent_intervention_s__following_second_referral_in_same_year_for_change_in_diagnosis__medical_condition__or_treatment_regimen__including_additional_hours_needed_for_renal_disease___group__2_or_more_individuals___each_30_minutes,
          _Medical_nutrition_therapy__reassessment_and_subsequent_intervention_s__following_second_referral_in_same_year_for_change_in_diagnosis__medical_condition_or_treatment_regimen__including_additional_hours_needed_for_renal_disease___individual__face_to_face_with_the_patient__each_15_minutes]);

    [CqlCodeSystemDefinition("CPT", codeSystemId: "http://www.ama-assn.org/go/cpt", codeSystemVersion: null)]
    public CqlCodeSystem CPT(CqlContext _) => _CPT;
    private static readonly CqlCodeSystem _CPT =
      new CqlCodeSystem("http://www.ama-assn.org/go/cpt", null, [
          _Medical_nutrition_therapy__group__2_or_more_individual_s____each_30_minutes,
          _Medical_nutrition_therapy__initial_assessment_and_intervention__individual__face_to_face_with_the_patient__each_15_minutes,
          _Medical_nutrition_therapy__re_assessment_and_intervention__individual__face_to_face_with_the_patient__each_15_minutes]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute, context) ?? Measurement_Period_Compute(context);

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS122FHIRDiabetesAssessGT9Pct-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (16)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Patient, Patient_Compute, context) ?? Patient_Compute(context);

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute, context) ?? SDE_Ethnicity_Compute(context);

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute, context) ?? SDE_Payer_Compute(context);

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute, context) ?? SDE_Race_Compute(context);

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute, context) ?? SDE_Sex_Compute(context);

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Qualifying_Encounters, Qualifying_Encounters_Compute, context) ?? Qualifying_Encounters_Compute(context);

    private IEnumerable<Encounter> Qualifying_Encounters_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet h_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
        CqlValueSet l_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet n_ = this.Nutrition_Services(context);
        IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
        IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
        IEnumerable<Encounter> r_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? s_(Encounter E) {
            List<CodeableConcept> ar_ = E?.Type;

            CqlConcept as_(CodeableConcept @this) {
                CqlConcept ax_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return ax_;
            }

            IEnumerable<CqlConcept> at_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ar_, as_);

            bool? au_(CqlConcept T) {
                CqlCode ay_ = this.Medical_nutrition_therapy__initial_assessment_and_intervention__individual__face_to_face_with_the_patient__each_15_minutes(context);
                CqlConcept az_ = context.Operators.ConvertCodeToConcept(ay_);
                bool? ba_ = context.Operators.Equivalent(T, az_);
                return ba_;
            }

            IEnumerable<CqlConcept> av_ = context.Operators.Where<CqlConcept>(at_, au_);
            bool? aw_ = context.Operators.Exists<CqlConcept>(av_);
            return aw_;
        }

        IEnumerable<Encounter> t_ = context.Operators.Where<Encounter>(r_, s_);

        bool? v_(Encounter E) {
            List<CodeableConcept> bb_ = E?.Type;

            CqlConcept bc_(CodeableConcept @this) {
                CqlConcept bh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return bh_;
            }

            IEnumerable<CqlConcept> bd_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bb_, bc_);

            bool? be_(CqlConcept T) {
                CqlCode bi_ = this.Medical_nutrition_therapy__re_assessment_and_intervention__individual__face_to_face_with_the_patient__each_15_minutes(context);
                CqlConcept bj_ = context.Operators.ConvertCodeToConcept(bi_);
                bool? bk_ = context.Operators.Equivalent(T, bj_);
                return bk_;
            }

            IEnumerable<CqlConcept> bf_ = context.Operators.Where<CqlConcept>(bd_, be_);
            bool? bg_ = context.Operators.Exists<CqlConcept>(bf_);
            return bg_;
        }

        IEnumerable<Encounter> w_ = context.Operators.Where<Encounter>(r_, v_);
        IEnumerable<Encounter> x_ = context.Operators.Union<Encounter>(t_, w_);
        IEnumerable<Encounter> y_ = context.Operators.Union<Encounter>(q_, x_);

        bool? aa_(Encounter E) {
            List<CodeableConcept> bl_ = E?.Type;

            CqlConcept bm_(CodeableConcept @this) {
                CqlConcept br_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return br_;
            }

            IEnumerable<CqlConcept> bn_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bl_, bm_);

            bool? bo_(CqlConcept T) {
                CqlCode bs_ = this.Medical_nutrition_therapy__group__2_or_more_individual_s____each_30_minutes(context);
                CqlConcept bt_ = context.Operators.ConvertCodeToConcept(bs_);
                bool? bu_ = context.Operators.Equivalent(T, bt_);
                return bu_;
            }

            IEnumerable<CqlConcept> bp_ = context.Operators.Where<CqlConcept>(bn_, bo_);
            bool? bq_ = context.Operators.Exists<CqlConcept>(bp_);
            return bq_;
        }

        IEnumerable<Encounter> ab_ = context.Operators.Where<Encounter>(r_, aa_);

        bool? ad_(Encounter E) {
            List<CodeableConcept> bv_ = E?.Type;

            CqlConcept bw_(CodeableConcept @this) {
                CqlConcept cb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return cb_;
            }

            IEnumerable<CqlConcept> bx_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bv_, bw_);

            bool? by_(CqlConcept T) {
                CqlCode cc_ = this.Medical_nutrition_therapy__reassessment_and_subsequent_intervention_s__following_second_referral_in_same_year_for_change_in_diagnosis__medical_condition_or_treatment_regimen__including_additional_hours_needed_for_renal_disease___individual__face_to_face_with_the_patient__each_15_minutes(context);
                CqlConcept cd_ = context.Operators.ConvertCodeToConcept(cc_);
                bool? ce_ = context.Operators.Equivalent(T, cd_);
                return ce_;
            }

            IEnumerable<CqlConcept> bz_ = context.Operators.Where<CqlConcept>(bx_, by_);
            bool? ca_ = context.Operators.Exists<CqlConcept>(bz_);
            return ca_;
        }

        IEnumerable<Encounter> ae_ = context.Operators.Where<Encounter>(r_, ad_);
        IEnumerable<Encounter> af_ = context.Operators.Union<Encounter>(ab_, ae_);
        IEnumerable<Encounter> ag_ = context.Operators.Union<Encounter>(y_, af_);

        bool? ai_(Encounter E) {
            List<CodeableConcept> cf_ = E?.Type;

            CqlConcept cg_(CodeableConcept @this) {
                CqlConcept cl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return cl_;
            }

            IEnumerable<CqlConcept> ch_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)cf_, cg_);

            bool? ci_(CqlConcept T) {
                CqlCode cm_ = this.Medical_nutrition_therapy__reassessment_and_subsequent_intervention_s__following_second_referral_in_same_year_for_change_in_diagnosis__medical_condition__or_treatment_regimen__including_additional_hours_needed_for_renal_disease___group__2_or_more_individuals___each_30_minutes(context);
                CqlConcept cn_ = context.Operators.ConvertCodeToConcept(cm_);
                bool? co_ = context.Operators.Equivalent(T, cn_);
                return co_;
            }

            IEnumerable<CqlConcept> cj_ = context.Operators.Where<CqlConcept>(ch_, ci_);
            bool? ck_ = context.Operators.Exists<CqlConcept>(cj_);
            return ck_;
        }

        IEnumerable<Encounter> aj_ = context.Operators.Where<Encounter>(r_, ai_);
        CqlValueSet ak_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> al_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ak_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> am_ = context.Operators.Union<Encounter>(aj_, al_);
        IEnumerable<Encounter> an_ = context.Operators.Union<Encounter>(ag_, am_);
        IEnumerable<Encounter> ao_ = Status_1_15_000.Instance.isEncounterPerformed(context, an_);

        bool? ap_(Encounter ValidEncounters) {
            CqlInterval<CqlDateTime> cp_ = this.Measurement_Period(context);
            Period cq_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> cr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cq_);
            bool? cs_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(cp_, cr_, "day");
            return cs_;
        }

        IEnumerable<Encounter> aq_ = context.Operators.Where<Encounter>(ao_, ap_);
        return aq_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute, context) ?? Initial_Population_Compute(context);

    private bool? Initial_Population_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.End(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?> i_ = context.Operators.Interval(18, 75, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, default);
        IEnumerable<Encounter> k_ = this.Qualifying_Encounters(context);
        bool? l_ = context.Operators.Exists<Encounter>(k_);
        bool? m_ = context.Operators.And(j_, l_);
        CqlValueSet n_ = this.Diabetes(context);
        IEnumerable<Condition> o_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        object p_(Condition X) => X as object;
        IEnumerable<object> q_ = context.Operators.Select<Condition, object>(o_, p_);
        IEnumerable<object> r_ = Status_1_15_000.Instance.verified(context, q_);

        bool? s_(object DiabetesDiagnosis) {
            CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, DiabetesDiagnosis);
            CqlInterval<CqlDateTime> x_ = this.Measurement_Period(context);
            bool? y_ = context.Operators.Overlaps(w_, x_, "day");
            return y_;
        }

        IEnumerable<object> t_ = context.Operators.Where<object>(r_, s_);
        bool? u_ = context.Operators.Exists<object>(t_);
        bool? v_ = context.Operators.And(m_, u_);
        return v_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute, context) ?? Denominator_Compute(context);

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute, context) ?? Denominator_Exclusions_Compute(context);

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        bool? a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
        bool? b_ = AdvancedIllnessandFrailty_1_27_000.Instance.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(context);
        bool? c_ = context.Operators.Or(a_, b_);
        bool? d_ = AdvancedIllnessandFrailty_1_27_000.Instance.Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty(context);
        bool? e_ = context.Operators.Or(c_, d_);
        bool? f_ = PalliativeCare_1_18_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? g_ = context.Operators.Or(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Glycemic Status Assessment")]
    public IEnumerable<Observation> Glycemic_Status_Assessment(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Glycemic_Status_Assessment, Glycemic_Status_Assessment_Compute, context) ?? Glycemic_Status_Assessment_Compute(context);

    private IEnumerable<Observation> Glycemic_Status_Assessment_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.HbA1c_Laboratory_Test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        CqlCode c_ = this.Glucose_management_indicator(context);
        IEnumerable<CqlCode> d_ = context.Operators.ToList<CqlCode>(c_);
        IEnumerable<Observation> e_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, d_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<Observation> f_ = context.Operators.Union<Observation>(b_, e_);
        IEnumerable<Observation> g_ = Status_1_15_000.Instance.isLaboratoryTestPerformed(context, f_);

        bool? h_(Observation GlycemicStatus) {

            object j_() {

                bool n_() {
                    DataType q_ = GlycemicStatus?.Effective;
                    object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                    bool s_ = r_ is CqlDateTime;
                    return s_;
                }


                bool o_() {
                    DataType t_ = GlycemicStatus?.Effective;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    bool v_ = u_ is CqlInterval<CqlDateTime>;
                    return v_;
                }


                bool p_() {
                    DataType w_ = GlycemicStatus?.Effective;
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    bool y_ = x_ is CqlDateTime;
                    return y_;
                }

                if (n_())
                {
                    DataType z_ = GlycemicStatus?.Effective;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    return (aa_ as CqlDateTime) as object;
                }
                else if (o_())
                {
                    DataType ab_ = GlycemicStatus?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    return (ac_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (p_())
                {
                    DataType ad_ = GlycemicStatus?.Effective;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    return (ae_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime k_ = QICoreCommon_4_0_000.Instance.latest(context, j_());
            CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
            bool? m_ = context.Operators.In<CqlDateTime>(k_, l_, "day");
            return m_;
        }

        IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
        return i_;
    }


    [CqlExpressionDefinition("Most Recent Glycemic Status Date")]
    public CqlDate Most_Recent_Glycemic_Status_Date(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Most_Recent_Glycemic_Status_Date, Most_Recent_Glycemic_Status_Date_Compute, context) ?? Most_Recent_Glycemic_Status_Date_Compute(context);

    private CqlDate Most_Recent_Glycemic_Status_Date_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Glycemic_Status_Assessment(context);

        CqlDate b_(Observation QualifyingGlycemicStatus) {

            object g_() {

                bool j_() {
                    DataType m_ = QualifyingGlycemicStatus?.Effective;
                    object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                    bool o_ = n_ is CqlDateTime;
                    return o_;
                }


                bool k_() {
                    DataType p_ = QualifyingGlycemicStatus?.Effective;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    bool r_ = q_ is CqlInterval<CqlDateTime>;
                    return r_;
                }


                bool l_() {
                    DataType s_ = QualifyingGlycemicStatus?.Effective;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlDateTime;
                    return u_;
                }

                if (j_())
                {
                    DataType v_ = QualifyingGlycemicStatus?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    return (w_ as CqlDateTime) as object;
                }
                else if (k_())
                {
                    DataType x_ = QualifyingGlycemicStatus?.Effective;
                    object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    return (y_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (l_())
                {
                    DataType z_ = QualifyingGlycemicStatus?.Effective;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    return (aa_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime h_ = QICoreCommon_4_0_000.Instance.latest(context, g_());
            CqlDate i_ = context.Operators.DateFrom(h_);
            return i_;
        }

        IEnumerable<CqlDate> c_ = context.Operators.Select<Observation, CqlDate>(a_, b_);
        IEnumerable<CqlDate> d_ = context.Operators.Distinct<CqlDate>(c_);
        IEnumerable<CqlDate> e_ = context.Operators.ListSort<CqlDate>(d_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDate f_ = context.Operators.Last<CqlDate>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Lowest Glycemic Status Assessment Reading on Most Recent Day")]
    public Observation Lowest_Glycemic_Status_Assessment_Reading_on_Most_Recent_Day(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Lowest_Glycemic_Status_Assessment_Reading_on_Most_Recent_Day, Lowest_Glycemic_Status_Assessment_Reading_on_Most_Recent_Day_Compute, context) ?? Lowest_Glycemic_Status_Assessment_Reading_on_Most_Recent_Day_Compute(context);

    private Observation Lowest_Glycemic_Status_Assessment_Reading_on_Most_Recent_Day_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Glycemic_Status_Assessment(context);

        bool? b_(Observation QualifyingGlycemicStatus) {

            object k_() {

                bool p_() {
                    DataType s_ = QualifyingGlycemicStatus?.Effective;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlDateTime;
                    return u_;
                }


                bool q_() {
                    DataType v_ = QualifyingGlycemicStatus?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlInterval<CqlDateTime>;
                    return x_;
                }


                bool r_() {
                    DataType y_ = QualifyingGlycemicStatus?.Effective;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlDateTime;
                    return aa_;
                }

                if (p_())
                {
                    DataType ab_ = QualifyingGlycemicStatus?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    return (ac_ as CqlDateTime) as object;
                }
                else if (q_())
                {
                    DataType ad_ = QualifyingGlycemicStatus?.Effective;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    return (ae_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (r_())
                {
                    DataType af_ = QualifyingGlycemicStatus?.Effective;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    return (ag_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime l_ = QICoreCommon_4_0_000.Instance.latest(context, k_());
            CqlDate m_ = this.Most_Recent_Glycemic_Status_Date(context);
            CqlDateTime n_ = context.Operators.ConvertDateToDateTime(m_);
            bool? o_ = context.Operators.SameAs(l_, n_, "day");
            return o_;
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        (CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)? d_(Observation QualifyingGlycemicStatus) {
            DataType ah_ = QualifyingGlycemicStatus?.Value;
            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
            (CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)? aj_ = (CqlTupleMetadata_FOBYUiHifSfYFYhEEQajgLbgF, ai_ as CqlQuantity, QualifyingGlycemicStatus);
            return aj_;
        }

        IEnumerable<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?> e_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?>(c_, d_);
        IEnumerable<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?> f_ = context.Operators.Distinct<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?>(e_);

        object g_((CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)? @this) {
            CqlQuantity ak_ = @this?.QualifyingGlycemicStatusValue;
            return ak_;
        }

        IEnumerable<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?> h_ = context.Operators.SortBy<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)? i_ = context.Operators.First<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?>(h_);
        Observation j_ = i_?.QualifyingGlycemicStatus;
        return j_;
    }


    [CqlExpressionDefinition("Has Most Recent Glycemic Status Assessment Without Result")]
    public bool? Has_Most_Recent_Glycemic_Status_Assessment_Without_Result(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Has_Most_Recent_Glycemic_Status_Assessment_Without_Result, Has_Most_Recent_Glycemic_Status_Assessment_Without_Result_Compute, context) ?? Has_Most_Recent_Glycemic_Status_Assessment_Without_Result_Compute(context);

    private bool? Has_Most_Recent_Glycemic_Status_Assessment_Without_Result_Compute(CqlContext context)
    {
        Observation a_ = this.Lowest_Glycemic_Status_Assessment_Reading_on_Most_Recent_Day(context);
        bool? b_ = context.Operators.Not((bool?)(a_ is null));
        DataType d_ = a_?.Value;
        object e_ = FHIRHelpers_4_4_000.Instance.ToValue(context, d_);
        bool? f_ = context.Operators.And(b_, (bool?)(e_ is null));
        return f_;
    }


    [CqlExpressionDefinition("Has Most Recent Elevated Glycemic Status Assessment")]
    public bool? Has_Most_Recent_Elevated_Glycemic_Status_Assessment(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Has_Most_Recent_Elevated_Glycemic_Status_Assessment, Has_Most_Recent_Elevated_Glycemic_Status_Assessment_Compute, context) ?? Has_Most_Recent_Elevated_Glycemic_Status_Assessment_Compute(context);

    private bool? Has_Most_Recent_Elevated_Glycemic_Status_Assessment_Compute(CqlContext context)
    {
        Observation a_ = this.Lowest_Glycemic_Status_Assessment_Reading_on_Most_Recent_Day(context);
        DataType b_ = a_?.Value;
        object c_ = FHIRHelpers_4_4_000.Instance.ToValue(context, b_);
        CqlQuantity d_ = context.Operators.Quantity(9m, "%");
        bool? e_ = context.Operators.Greater(c_ as CqlQuantity, d_);
        return e_;
    }


    [CqlExpressionDefinition("Has No Record Of Glycemic Status Assessment")]
    public bool? Has_No_Record_Of_Glycemic_Status_Assessment(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Has_No_Record_Of_Glycemic_Status_Assessment, Has_No_Record_Of_Glycemic_Status_Assessment_Compute, context) ?? Has_No_Record_Of_Glycemic_Status_Assessment_Compute(context);

    private bool? Has_No_Record_Of_Glycemic_Status_Assessment_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Glycemic_Status_Assessment(context);
        bool? b_ = context.Operators.Exists<Observation>(a_);
        bool? c_ = context.Operators.Not(b_);
        return c_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute, context) ?? Numerator_Compute(context);

    private bool? Numerator_Compute(CqlContext context)
    {
        bool? a_ = this.Has_Most_Recent_Glycemic_Status_Assessment_Without_Result(context);
        bool? b_ = this.Has_Most_Recent_Elevated_Glycemic_Status_Assessment(context);
        bool? c_ = context.Operators.Or(a_, b_);
        bool? d_ = this.Has_No_Record_Of_Glycemic_Status_Assessment(context);
        bool? e_ = context.Operators.Or(c_, d_);
        return e_;
    }


    #endregion Functions and Expressions

    #region Cache Index Fields (17)

    private int _cacheIndex_Measurement_Period = -1;
    private int _cacheIndex_Patient = -1;
    private int _cacheIndex_SDE_Ethnicity = -1;
    private int _cacheIndex_SDE_Payer = -1;
    private int _cacheIndex_SDE_Race = -1;
    private int _cacheIndex_SDE_Sex = -1;
    private int _cacheIndex_Qualifying_Encounters = -1;
    private int _cacheIndex_Initial_Population = -1;
    private int _cacheIndex_Denominator = -1;
    private int _cacheIndex_Denominator_Exclusions = -1;
    private int _cacheIndex_Glycemic_Status_Assessment = -1;
    private int _cacheIndex_Most_Recent_Glycemic_Status_Date = -1;
    private int _cacheIndex_Lowest_Glycemic_Status_Assessment_Reading_on_Most_Recent_Day = -1;
    private int _cacheIndex_Has_Most_Recent_Glycemic_Status_Assessment_Without_Result = -1;
    private int _cacheIndex_Has_Most_Recent_Elevated_Glycemic_Status_Assessment = -1;
    private int _cacheIndex_Has_No_Record_Of_Glycemic_Status_Assessment = -1;
    private int _cacheIndex_Numerator = -1;

    #endregion Cache Index Fields

    #region ILibraryInternals Implementation

    private CqlLibraryInvocationCache _cache = CqlLibraryInvocationCache.NeverCached;

    /// <summary>
    /// Initializes cache indices for this library's cached expressions.
    /// </summary>
    /// <param name="libraryInvocationSet">The library invocation set performing initialization.</param>
    /// <param name="startIndex">The starting index for cache field assignment.</param>
    /// <returns>The number of cache indices initialized (number of cached expressions in this library).</returns>
    int ILibraryInternals.InitializeCacheIndices(
        CqlLibraryInvocationSet libraryInvocationSet,
        int startIndex)
    {
        var index = startIndex;
        _cacheIndex_Measurement_Period = index++;
        _cacheIndex_Patient = index++;
        _cacheIndex_SDE_Ethnicity = index++;
        _cacheIndex_SDE_Payer = index++;
        _cacheIndex_SDE_Race = index++;
        _cacheIndex_SDE_Sex = index++;
        _cacheIndex_Qualifying_Encounters = index++;
        _cacheIndex_Initial_Population = index++;
        _cacheIndex_Denominator = index++;
        _cacheIndex_Denominator_Exclusions = index++;
        _cacheIndex_Glycemic_Status_Assessment = index++;
        _cacheIndex_Most_Recent_Glycemic_Status_Date = index++;
        _cacheIndex_Lowest_Glycemic_Status_Assessment_Reading_on_Most_Recent_Day = index++;
        _cacheIndex_Has_Most_Recent_Glycemic_Status_Assessment_Without_Result = index++;
        _cacheIndex_Has_Most_Recent_Elevated_Glycemic_Status_Assessment = index++;
        _cacheIndex_Has_No_Record_Of_Glycemic_Status_Assessment = index++;
        _cacheIndex_Numerator = index++;
        return index - startIndex;
    }

    /// <summary>
    /// Sets the cache instance that this library will use for caching computed values.
    /// </summary>
    /// <param name="cache">The cache instance to use.</param>
    void ILibraryInternals.SetCacheInstance(CqlLibraryInvocationCache cache)
    {
        _cache = cache;
    }

    #endregion ILibraryInternals Implementation

    #region Singleton Lifetime Members

    private CMS122FHIRDiabetesAssessGT9Pct_1_0_000() {}

    public static CMS122FHIRDiabetesAssessGT9Pct_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS122FHIRDiabetesAssessGT9Pct";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance, Status_1_15_000.Instance, AdvancedIllnessandFrailty_1_27_000.Instance, Hospice_6_18_000.Instance, PalliativeCare_1_18_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties (1)

    private static CqlTupleMetadata CqlTupleMetadata_FOBYUiHifSfYFYhEEQajgLbgF = new(
       [typeof(CqlQuantity), typeof(Observation)],
       ["QualifyingGlycemicStatusValue", "QualifyingGlycemicStatus"]);

    #endregion CqlTupleMetadata Properties

}
