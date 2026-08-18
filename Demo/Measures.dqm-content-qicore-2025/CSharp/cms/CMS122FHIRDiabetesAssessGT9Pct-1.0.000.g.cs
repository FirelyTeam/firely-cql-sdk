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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.5.0")]
[CqlLibrary("CMS122FHIRDiabetesAssessGT9Pct", "1.0.000")]
public partial class CMS122FHIRDiabetesAssessGT9Pct_1_0_000 : ILibrary, ISingleton<CMS122FHIRDiabetesAssessGT9Pct_1_0_000>
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
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 7402305925856102842L;

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
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 5155769517994188859L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -854433992633449296L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 6275135362415019525L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -3186245049232621800L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -7004708749295299838L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounters, Qualifying_Encounters_Compute);

    private const long _cacheIndex_Qualifying_Encounters = 6026662126881716377L;

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
            List<CodeableConcept> an_ = E?.Type;

            CqlConcept ao_(CodeableConcept @this) {
                CqlConcept as_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return as_;
            }


            bool? ap_(CqlConcept T) {
                CqlCode at_ = this.Medical_nutrition_therapy__initial_assessment_and_intervention__individual__face_to_face_with_the_patient__each_15_minutes(context);
                CqlConcept au_ = context.Operators.ConvertCodeToConcept(at_);
                CqlBoolean av_ = context.Operators.Equivalent(T, au_);
                return av_;
            }

            IEnumerable<CqlConcept> aq_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)an_, ao_, ap_);
            CqlBoolean ar_ = context.Operators.Exists<CqlConcept>(aq_);
            return ar_;
        }

        IEnumerable<Encounter> t_ = context.Operators.Where<Encounter>(r_, s_);

        bool? u_(Encounter E) {
            List<CodeableConcept> aw_ = E?.Type;

            CqlConcept ax_(CodeableConcept @this) {
                CqlConcept bb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return bb_;
            }


            bool? ay_(CqlConcept T) {
                CqlCode bc_ = this.Medical_nutrition_therapy__re_assessment_and_intervention__individual__face_to_face_with_the_patient__each_15_minutes(context);
                CqlConcept bd_ = context.Operators.ConvertCodeToConcept(bc_);
                CqlBoolean be_ = context.Operators.Equivalent(T, bd_);
                return be_;
            }

            IEnumerable<CqlConcept> az_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)aw_, ax_, ay_);
            CqlBoolean ba_ = context.Operators.Exists<CqlConcept>(az_);
            return ba_;
        }

        IEnumerable<Encounter> v_ = context.Operators.Where<Encounter>(r_, u_);
        IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(t_, v_);
        IEnumerable<Encounter> x_ = context.Operators.Union<Encounter>(q_, w_);

        bool? y_(Encounter E) {
            List<CodeableConcept> bf_ = E?.Type;

            CqlConcept bg_(CodeableConcept @this) {
                CqlConcept bk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return bk_;
            }


            bool? bh_(CqlConcept T) {
                CqlCode bl_ = this.Medical_nutrition_therapy__group__2_or_more_individual_s____each_30_minutes(context);
                CqlConcept bm_ = context.Operators.ConvertCodeToConcept(bl_);
                CqlBoolean bn_ = context.Operators.Equivalent(T, bm_);
                return bn_;
            }

            IEnumerable<CqlConcept> bi_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bf_, bg_, bh_);
            CqlBoolean bj_ = context.Operators.Exists<CqlConcept>(bi_);
            return bj_;
        }

        IEnumerable<Encounter> z_ = context.Operators.Where<Encounter>(r_, y_);

        bool? aa_(Encounter E) {
            List<CodeableConcept> bo_ = E?.Type;

            CqlConcept bp_(CodeableConcept @this) {
                CqlConcept bt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return bt_;
            }


            bool? bq_(CqlConcept T) {
                CqlCode bu_ = this.Medical_nutrition_therapy__reassessment_and_subsequent_intervention_s__following_second_referral_in_same_year_for_change_in_diagnosis__medical_condition_or_treatment_regimen__including_additional_hours_needed_for_renal_disease___individual__face_to_face_with_the_patient__each_15_minutes(context);
                CqlConcept bv_ = context.Operators.ConvertCodeToConcept(bu_);
                CqlBoolean bw_ = context.Operators.Equivalent(T, bv_);
                return bw_;
            }

            IEnumerable<CqlConcept> br_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bo_, bp_, bq_);
            CqlBoolean bs_ = context.Operators.Exists<CqlConcept>(br_);
            return bs_;
        }

        IEnumerable<Encounter> ab_ = context.Operators.Where<Encounter>(r_, aa_);
        IEnumerable<Encounter> ac_ = context.Operators.Union<Encounter>(z_, ab_);
        IEnumerable<Encounter> ad_ = context.Operators.Union<Encounter>(x_, ac_);

        bool? ae_(Encounter E) {
            List<CodeableConcept> bx_ = E?.Type;

            CqlConcept by_(CodeableConcept @this) {
                CqlConcept cc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return cc_;
            }


            bool? bz_(CqlConcept T) {
                CqlCode cd_ = this.Medical_nutrition_therapy__reassessment_and_subsequent_intervention_s__following_second_referral_in_same_year_for_change_in_diagnosis__medical_condition__or_treatment_regimen__including_additional_hours_needed_for_renal_disease___group__2_or_more_individuals___each_30_minutes(context);
                CqlConcept ce_ = context.Operators.ConvertCodeToConcept(cd_);
                CqlBoolean cf_ = context.Operators.Equivalent(T, ce_);
                return cf_;
            }

            IEnumerable<CqlConcept> ca_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bx_, by_, bz_);
            CqlBoolean cb_ = context.Operators.Exists<CqlConcept>(ca_);
            return cb_;
        }

        IEnumerable<Encounter> af_ = context.Operators.Where<Encounter>(r_, ae_);
        CqlValueSet ag_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> ah_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ag_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ai_ = context.Operators.Union<Encounter>(af_, ah_);
        IEnumerable<Encounter> aj_ = context.Operators.Union<Encounter>(ad_, ai_);
        IEnumerable<Encounter> ak_ = Status_1_15_000.Instance.isEncounterPerformed(context, aj_);

        bool? al_(Encounter ValidEncounters) {
            CqlInterval<CqlDateTime> cg_ = this.Measurement_Period(context);
            Period ch_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> ci_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ch_);
            CqlBoolean cj_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(cg_, ci_, "day");
            return cj_;
        }

        IEnumerable<Encounter> am_ = context.Operators.Where<Encounter>(ak_, al_);
        return am_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -3733609777355774695L;

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
        CqlBoolean j_ = context.Operators.In<int?>(h_, i_, (string)default);

        CqlBoolean k_() {
            IEnumerable<Encounter> m_ = this.Qualifying_Encounters(context);
            CqlBoolean n_ = context.Operators.Exists<Encounter>(m_);
            return n_;
        }


        CqlBoolean l_() {
            CqlValueSet o_ = this.Diabetes(context);
            IEnumerable<Condition> p_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            Condition q_(Condition X) => X as Condition;
            IEnumerable<Condition> r_ = context.Operators.Select<Condition, Condition>(p_, q_);
            IEnumerable<Condition> s_ = Status_1_15_000.Instance.verified(context, r_);

            bool? t_(Condition DiabetesDiagnosis) {
                CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, DiabetesDiagnosis);
                CqlInterval<CqlDateTime> w_ = this.Measurement_Period(context);
                CqlBoolean x_ = context.Operators.Overlaps(v_, w_, "day");
                return x_;
            }

            CqlBoolean u_ = context.Operators.WhereAny<Condition>(s_, t_);
            return u_;
        }

        return j_
            /* CQL 'and' (52:3-55:38) */ && k_()
            /* CQL 'and' (52:3-58:5) */ && l_();
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 7239434794158260384L;

    private bool? Denominator_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 2942293260668315369L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        CqlBoolean a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
        return a_
            /* CQL 'or' (64:3-65:74) */ || AdvancedIllnessandFrailty_1_27_000.Instance.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(context)
            /* CQL 'or' (64:3-66:73) */ || AdvancedIllnessandFrailty_1_27_000.Instance.Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty(context)
            /* CQL 'or' (64:3-67:69) */ || PalliativeCare_1_18_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
    }


    [CqlExpressionDefinition("Glycemic Status Assessment")]
    public IEnumerable<Observation> Glycemic_Status_Assessment(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Glycemic_Status_Assessment, Glycemic_Status_Assessment_Compute);

    private const long _cacheIndex_Glycemic_Status_Assessment = -6709887676474614211L;

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
            object j_;
            DataType n_ = GlycemicStatus?.Effective;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            bool p_ = o_ is CqlDateTime;
            if (p_)
            {
                j_ = o_ as CqlDateTime;
            }
            else
            {
                if (p_)
                {
                    j_ = o_ as CqlDateTime;
                }
                else
                {
                    bool q_ = o_ is CqlInterval<CqlDateTime>;
                    if (q_)
                    {
                        j_ = o_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        j_ = null;
                    }
                }
            }
            CqlDateTime k_ = QICoreCommon_4_0_000.Instance.latest(context, j_);
            CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
            CqlBoolean m_ = context.Operators.In<CqlDateTime>(k_, l_, "day");
            return m_;
        }

        IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
        return i_;
    }


    [CqlExpressionDefinition("Most Recent Glycemic Status Date")]
    public CqlDate Most_Recent_Glycemic_Status_Date(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Most_Recent_Glycemic_Status_Date, Most_Recent_Glycemic_Status_Date_Compute);

    private const long _cacheIndex_Most_Recent_Glycemic_Status_Date = -58492716871071978L;

    private CqlDate Most_Recent_Glycemic_Status_Date_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Glycemic_Status_Assessment(context);

        CqlDate b_(Observation QualifyingGlycemicStatus) {
            object f_;
            DataType i_ = QualifyingGlycemicStatus?.Effective;
            object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
            bool k_ = j_ is CqlDateTime;
            if (k_)
            {
                f_ = j_ as CqlDateTime;
            }
            else
            {
                if (k_)
                {
                    f_ = j_ as CqlDateTime;
                }
                else
                {
                    bool l_ = j_ is CqlInterval<CqlDateTime>;
                    if (l_)
                    {
                        f_ = j_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        f_ = null;
                    }
                }
            }
            CqlDateTime g_ = QICoreCommon_4_0_000.Instance.latest(context, f_);
            CqlDate h_ = context.Operators.DateFrom(g_);
            return h_;
        }

        IEnumerable<CqlDate> c_ = context.Operators.SelectDistinct<Observation, CqlDate>(a_, b_);
        IEnumerable<CqlDate> d_ = context.Operators.ListSort<CqlDate>(c_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDate e_ = context.Operators.Last<CqlDate>(d_);
        return e_;
    }


    [CqlExpressionDefinition("Lowest Glycemic Status Assessment Reading on Most Recent Day")]
    public Observation Lowest_Glycemic_Status_Assessment_Reading_on_Most_Recent_Day(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Lowest_Glycemic_Status_Assessment_Reading_on_Most_Recent_Day, Lowest_Glycemic_Status_Assessment_Reading_on_Most_Recent_Day_Compute);

    private const long _cacheIndex_Lowest_Glycemic_Status_Assessment_Reading_on_Most_Recent_Day = 7833671671686808528L;

    private Observation Lowest_Glycemic_Status_Assessment_Reading_on_Most_Recent_Day_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Glycemic_Status_Assessment(context);

        bool? b_(Observation QualifyingGlycemicStatus) {
            object j_;
            DataType o_ = QualifyingGlycemicStatus?.Effective;
            object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
            bool q_ = p_ is CqlDateTime;
            if (q_)
            {
                j_ = p_ as CqlDateTime;
            }
            else
            {
                if (q_)
                {
                    j_ = p_ as CqlDateTime;
                }
                else
                {
                    bool r_ = p_ is CqlInterval<CqlDateTime>;
                    if (r_)
                    {
                        j_ = p_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        j_ = null;
                    }
                }
            }
            CqlDateTime k_ = QICoreCommon_4_0_000.Instance.latest(context, j_);
            CqlDate l_ = this.Most_Recent_Glycemic_Status_Date(context);
            CqlDateTime m_ = context.Operators.ConvertDateToDateTime(l_);
            CqlBoolean n_ = context.Operators.SameAs(k_, m_, "day");
            return n_;
        }


        (CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)? c_(Observation QualifyingGlycemicStatus) {
            DataType s_ = QualifyingGlycemicStatus?.Value;
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            (CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)? u_ = (CqlTupleMetadata_FOBYUiHifSfYFYhEEQajgLbgF, t_ as CqlQuantity, QualifyingGlycemicStatus);
            return u_;
        }

        IEnumerable<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?> d_ = context.Operators.WhereSelect<Observation, (CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?>(a_, b_, c_);
        IEnumerable<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?> e_ = context.Operators.Distinct<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?>(d_);

        object f_((CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)? @this) {
            CqlQuantity v_ = @this?.QualifyingGlycemicStatusValue;
            return v_;
        }

        IEnumerable<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?> g_ = context.Operators.SortBy<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)? h_ = context.Operators.First<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?>(g_);
        Observation i_ = h_?.QualifyingGlycemicStatus;
        return i_;
    }


    [CqlExpressionDefinition("Has Most Recent Glycemic Status Assessment Without Result")]
    public bool? Has_Most_Recent_Glycemic_Status_Assessment_Without_Result(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Most_Recent_Glycemic_Status_Assessment_Without_Result, Has_Most_Recent_Glycemic_Status_Assessment_Without_Result_Compute);

    private const long _cacheIndex_Has_Most_Recent_Glycemic_Status_Assessment_Without_Result = 7788228314779565051L;

    private bool? Has_Most_Recent_Glycemic_Status_Assessment_Without_Result_Compute(CqlContext context)
    {
        Observation a_ = this.Lowest_Glycemic_Status_Assessment_Reading_on_Most_Recent_Day(context);

        CqlBoolean b_() {
            Observation c_ = this.Lowest_Glycemic_Status_Assessment_Reading_on_Most_Recent_Day(context);
            DataType d_ = c_?.Value;
            object e_ = FHIRHelpers_4_4_000.Instance.ToValue(context, d_);
            return e_ is null;
        }

        return (CqlBoolean)(!((bool?)(a_ is null)))
            /* CQL 'and' (133:3-134:84) */ && b_();
    }


    [CqlExpressionDefinition("Has Most Recent Elevated Glycemic Status Assessment")]
    public bool? Has_Most_Recent_Elevated_Glycemic_Status_Assessment(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Most_Recent_Elevated_Glycemic_Status_Assessment, Has_Most_Recent_Elevated_Glycemic_Status_Assessment_Compute);

    private const long _cacheIndex_Has_Most_Recent_Elevated_Glycemic_Status_Assessment = 965345808148093052L;

    private bool? Has_Most_Recent_Elevated_Glycemic_Status_Assessment_Compute(CqlContext context)
    {
        Observation a_ = this.Lowest_Glycemic_Status_Assessment_Reading_on_Most_Recent_Day(context);
        DataType b_ = a_?.Value;
        object c_ = FHIRHelpers_4_4_000.Instance.ToValue(context, b_);
        CqlQuantity d_ = context.Operators.Quantity(9m, "%");
        CqlBoolean e_ = context.Operators.Greater(c_ as CqlQuantity, d_);
        return e_;
    }


    [CqlExpressionDefinition("Has No Record Of Glycemic Status Assessment")]
    public bool? Has_No_Record_Of_Glycemic_Status_Assessment(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_No_Record_Of_Glycemic_Status_Assessment, Has_No_Record_Of_Glycemic_Status_Assessment_Compute);

    private const long _cacheIndex_Has_No_Record_Of_Glycemic_Status_Assessment = 614845829781613145L;

    private bool? Has_No_Record_Of_Glycemic_Status_Assessment_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Glycemic_Status_Assessment(context);
        CqlBoolean b_ = context.Operators.Exists<Observation>(a_);
        return !b_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -3415809354610142637L;

    private bool? Numerator_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.Has_Most_Recent_Glycemic_Status_Assessment_Without_Result(context);
        return a_
            /* CQL 'or' (70:3-71:60) */ || this.Has_Most_Recent_Elevated_Glycemic_Status_Assessment(context)
            /* CQL 'or' (70:3-72:52) */ || this.Has_No_Record_Of_Glycemic_Status_Assessment(context);
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS122FHIRDiabetesAssessGT9Pct_1_0_000() {}

    public static CMS122FHIRDiabetesAssessGT9Pct_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS122FHIRDiabetesAssessGT9Pct";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance, Status_1_15_000.Instance, AdvancedIllnessandFrailty_1_27_000.Instance, Hospice_6_18_000.Instance, PalliativeCare_1_18_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_FOBYUiHifSfYFYhEEQajgLbgF = new(
       [typeof(CqlQuantity), typeof(Observation)],
       ["QualifyingGlycemicStatusValue", "QualifyingGlycemicStatus"]);

    #endregion CqlTupleMetadata Properties

}
