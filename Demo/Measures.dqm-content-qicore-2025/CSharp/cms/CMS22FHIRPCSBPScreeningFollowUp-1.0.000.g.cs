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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.6.0")]
[CqlLibrary("CMS22FHIRPCSBPScreeningFollowUp", "1.0.000")]
public partial class CMS22FHIRPCSBPScreeningFollowUp_1_0_000 : ILibrary, ISingleton<CMS22FHIRPCSBPScreeningFollowUp_1_0_000>
{
    #region ValueSets (15)

    [CqlValueSetDefinition("Diagnosis of Hypertension", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.263", valueSetVersion: null)]
    public CqlValueSet Diagnosis_of_Hypertension(CqlContext _) => _Diagnosis_of_Hypertension;
    private static readonly CqlValueSet _Diagnosis_of_Hypertension = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.263", null);

    [CqlValueSetDefinition("Dietary Recommendations", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1515", valueSetVersion: null)]
    public CqlValueSet Dietary_Recommendations(CqlContext _) => _Dietary_Recommendations;
    private static readonly CqlValueSet _Dietary_Recommendations = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1515", null);

    [CqlValueSetDefinition("Encounter to Screen for Blood Pressure", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1920", valueSetVersion: null)]
    public CqlValueSet Encounter_to_Screen_for_Blood_Pressure(CqlContext _) => _Encounter_to_Screen_for_Blood_Pressure;
    private static readonly CqlValueSet _Encounter_to_Screen_for_Blood_Pressure = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1920", null);

    [CqlValueSetDefinition("Finding of Elevated Blood Pressure or Hypertension", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.514", valueSetVersion: null)]
    public CqlValueSet Finding_of_Elevated_Blood_Pressure_or_Hypertension(CqlContext _) => _Finding_of_Elevated_Blood_Pressure_or_Hypertension;
    private static readonly CqlValueSet _Finding_of_Elevated_Blood_Pressure_or_Hypertension = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.514", null);

    [CqlValueSetDefinition("Follow Up Within 4 Weeks", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1578", valueSetVersion: null)]
    public CqlValueSet Follow_Up_Within_4_Weeks(CqlContext _) => _Follow_Up_Within_4_Weeks;
    private static readonly CqlValueSet _Follow_Up_Within_4_Weeks = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1578", null);

    [CqlValueSetDefinition("Follow Up Within 6 Months", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.125", valueSetVersion: null)]
    public CqlValueSet Follow_Up_Within_6_Months(CqlContext _) => _Follow_Up_Within_6_Months;
    private static readonly CqlValueSet _Follow_Up_Within_6_Months = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.125", null);

    [CqlValueSetDefinition("Laboratory Tests for Hypertension", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1482", valueSetVersion: null)]
    public CqlValueSet Laboratory_Tests_for_Hypertension(CqlContext _) => _Laboratory_Tests_for_Hypertension;
    private static readonly CqlValueSet _Laboratory_Tests_for_Hypertension = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1482", null);

    [CqlValueSetDefinition("Lifestyle Recommendation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1581", valueSetVersion: null)]
    public CqlValueSet Lifestyle_Recommendation(CqlContext _) => _Lifestyle_Recommendation;
    private static readonly CqlValueSet _Lifestyle_Recommendation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1581", null);

    [CqlValueSetDefinition("Medical Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", valueSetVersion: null)]
    public CqlValueSet Medical_Reason(CqlContext _) => _Medical_Reason;
    private static readonly CqlValueSet _Medical_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);

    [CqlValueSetDefinition("Patient Declined", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1582", valueSetVersion: null)]
    public CqlValueSet Patient_Declined(CqlContext _) => _Patient_Declined;
    private static readonly CqlValueSet _Patient_Declined = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1582", null);

    [CqlValueSetDefinition("Pharmacologic Therapy for Hypertension", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.1577", valueSetVersion: null)]
    public CqlValueSet Pharmacologic_Therapy_for_Hypertension(CqlContext _) => _Pharmacologic_Therapy_for_Hypertension;
    private static readonly CqlValueSet _Pharmacologic_Therapy_for_Hypertension = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.1577", null);

    [CqlValueSetDefinition("Recommendation to Increase Physical Activity", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1518", valueSetVersion: null)]
    public CqlValueSet Recommendation_to_Increase_Physical_Activity(CqlContext _) => _Recommendation_to_Increase_Physical_Activity;
    private static readonly CqlValueSet _Recommendation_to_Increase_Physical_Activity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1518", null);

    [CqlValueSetDefinition("Referral or Counseling for Alcohol Consumption", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1583", valueSetVersion: null)]
    public CqlValueSet Referral_or_Counseling_for_Alcohol_Consumption(CqlContext _) => _Referral_or_Counseling_for_Alcohol_Consumption;
    private static readonly CqlValueSet _Referral_or_Counseling_for_Alcohol_Consumption = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1583", null);

    [CqlValueSetDefinition("Referral to Primary Care or Alternate Provider", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1580", valueSetVersion: null)]
    public CqlValueSet Referral_to_Primary_Care_or_Alternate_Provider(CqlContext _) => _Referral_to_Primary_Care_or_Alternate_Provider;
    private static readonly CqlValueSet _Referral_to_Primary_Care_or_Alternate_Provider = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1580", null);

    [CqlValueSetDefinition("Weight Reduction Recommended", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1510", valueSetVersion: null)]
    public CqlValueSet Weight_Reduction_Recommended(CqlContext _) => _Weight_Reduction_Recommended;
    private static readonly CqlValueSet _Weight_Reduction_Recommended = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1510", null);

    #endregion ValueSets

    #region Codes (6)

    [CqlCodeDefinition("Blood pressure panel with all children optional", codeId: "85354-9", codeSystem: "http://loinc.org")]
    public CqlCode Blood_pressure_panel_with_all_children_optional(CqlContext _) => _Blood_pressure_panel_with_all_children_optional;
    private static readonly CqlCode _Blood_pressure_panel_with_all_children_optional = new CqlCode("85354-9", "http://loinc.org");

    [CqlCodeDefinition("Diastolic blood pressure", codeId: "8462-4", codeSystem: "http://loinc.org")]
    public CqlCode Diastolic_blood_pressure(CqlContext _) => _Diastolic_blood_pressure;
    private static readonly CqlCode _Diastolic_blood_pressure = new CqlCode("8462-4", "http://loinc.org");

    [CqlCodeDefinition("12 lead EKG panel", codeId: "34534-8", codeSystem: "http://loinc.org")]
    public CqlCode _12_lead_EKG_panel(CqlContext _) => __12_lead_EKG_panel;
    private static readonly CqlCode __12_lead_EKG_panel = new CqlCode("34534-8", "http://loinc.org");

    [CqlCodeDefinition("EKG study", codeId: "11524-6", codeSystem: "http://loinc.org")]
    public CqlCode EKG_study(CqlContext _) => _EKG_study;
    private static readonly CqlCode _EKG_study = new CqlCode("11524-6", "http://loinc.org");

    [CqlCodeDefinition("Systolic blood pressure", codeId: "8480-6", codeSystem: "http://loinc.org")]
    public CqlCode Systolic_blood_pressure(CqlContext _) => _Systolic_blood_pressure;
    private static readonly CqlCode _Systolic_blood_pressure = new CqlCode("8480-6", "http://loinc.org");

    [CqlCodeDefinition("virtual", codeId: "VR", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode @virtual(CqlContext _) => _virtual;
    private static readonly CqlCode _virtual = new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode");

    #endregion Codes

    #region CodeSystems (3)

    [CqlCodeSystemDefinition("ActCode", codeSystemId: "http://terminology.hl7.org/CodeSystem/v3-ActCode", codeSystemVersion: null)]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-ActCode", null, [
          _virtual]);

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Blood_pressure_panel_with_all_children_optional,
          _Diastolic_blood_pressure,
          __12_lead_EKG_panel,
          _EKG_study,
          _Systolic_blood_pressure]);

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, []);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 5405139968706161975L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS22FHIRPCSBPScreeningFollowUp-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (35)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 1979955691118567769L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Qualifying Encounter during Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_during_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounter_during_Measurement_Period, Qualifying_Encounter_during_Measurement_Period_Compute);

    private const long _cacheIndex_Qualifying_Encounter_during_Measurement_Period = 2791217811809034209L;

    private IEnumerable<Encounter> Qualifying_Encounter_during_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_to_Screen_for_Blood_Pressure(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? c_(Encounter ValidEncounter) {
            Period e_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
            CqlDateTime g_ = context.Operators.End(f_);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            CqlBoolean i_ = context.Operators.In<CqlDateTime>(g_, h_, "day");

            CqlBoolean j_() {
                Code<Encounter.EncounterStatus> l_ = ValidEncounter?.StatusElement;
                Encounter.EncounterStatus? m_ = l_?.Value;
                Code<Encounter.EncounterStatus> n_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(m_);
                CqlBoolean o_ = context.Operators.Equivalent(n_, "finished");
                return o_;
            }


            CqlBoolean k_() {
                Coding p_ = ValidEncounter?.Class;
                CqlCode q_ = FHIRHelpers_4_4_000.Instance.ToCode(context, p_);
                CqlCode r_ = this.@virtual(context);
                CqlBoolean s_ = context.Operators.Equivalent(q_, r_);
                return !s_;
            }

            return i_
                /* CQL 'and' (145:11-146:44) */ && j_()
                /* CQL 'and' (145:5-147:43) */ && k_();
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 5204469400841768519L;

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Measurement_Period(context);

        bool? b_(Encounter QualifyingEncounter) {
            Patient d_ = this.Patient(context);
            Date e_ = d_?.BirthDateElement;
            string f_ = e_?.Value;
            CqlDate g_ = context.Operators.ConvertStringToDate(f_);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            CqlDateTime i_ = context.Operators.Start(h_);
            CqlDate j_ = context.Operators.DateFrom(i_);
            int? k_ = context.Operators.CalculateAgeAt(g_, j_, "year");
            CqlBoolean l_ = context.Operators.GreaterOrEqual(k_, 18);
            return l_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 298522840894766632L;

    private IEnumerable<Encounter> Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlFunctionDefinition("isVerified")]
    [CqlTag("description", "Returns true if the given condition either has no verification status or has a verification status of confirmed, unconfirmed, provisional, or differential")]
    public bool? isVerified(CqlContext context, Condition condition)
    {
        CodeableConcept a_ = condition?.VerificationStatus;
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);

        CqlBoolean c_() {
            CodeableConcept d_ = condition?.VerificationStatus;
            CqlConcept e_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, d_);
            CqlCode f_ = QICoreCommon_4_0_000.Instance.confirmed(context);
            CqlConcept g_ = context.Operators.ConvertCodeToConcept(f_);
            CqlBoolean h_ = context.Operators.Equivalent(e_, g_);

            CqlBoolean i_() {
                CodeableConcept l_ = condition?.VerificationStatus;
                CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, l_);
                CqlCode n_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
                CqlConcept o_ = context.Operators.ConvertCodeToConcept(n_);
                CqlBoolean p_ = context.Operators.Equivalent(m_, o_);
                return p_;
            }


            CqlBoolean j_() {
                CodeableConcept q_ = condition?.VerificationStatus;
                CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                CqlCode s_ = QICoreCommon_4_0_000.Instance.provisional(context);
                CqlConcept t_ = context.Operators.ConvertCodeToConcept(s_);
                CqlBoolean u_ = context.Operators.Equivalent(r_, t_);
                return u_;
            }


            CqlBoolean k_() {
                CodeableConcept v_ = condition?.VerificationStatus;
                CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                CqlCode x_ = QICoreCommon_4_0_000.Instance.differential(context);
                CqlConcept y_ = context.Operators.ConvertCodeToConcept(x_);
                CqlBoolean z_ = context.Operators.Equivalent(w_, y_);
                return z_;
            }

            return h_
                /* CQL 'or' (408:54-409:66) */ || i_()
                /* CQL 'or' (408:54-410:66) */ || j_()
                /* CQL 'or' (408:52-412:3) */ || k_();
        }

        return (CqlBoolean)((bool?)(b_ is null))
            /* CQL 'implies' (408:3-412:3) */ || c_();
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 2562950814575044657L;

    private IEnumerable<Encounter> Denominator_Exclusions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Measurement_Period(context);

        bool? b_(Encounter QualifyingEncounter) {
            CqlValueSet d_ = this.Diagnosis_of_Hypertension(context);
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? f_(Condition Hypertension) {
                CqlInterval<CqlDateTime> h_;
                CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, Hypertension as Condition);
                CqlDateTime m_ = context.Operators.Start(l_);
                if (m_ is null)
                {
                    h_ = default;
                }
                else
                {
                    CqlInterval<CqlDateTime> n_ = context.Operators.Interval(m_, m_, true, true);
                    h_ = n_;
                }
                Period i_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                CqlBoolean k_ = context.Operators.SameOrBefore(h_, j_, "day");
                return k_
                    /* CQL 'and' (51:17-52:39) */ && this.isVerified(context, Hypertension as Condition);
            }

            CqlBoolean g_ = context.Operators.WhereAny<Condition>(e_, f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter with Normal Blood Pressure Reading")]
    public IEnumerable<Encounter> Encounter_with_Normal_Blood_Pressure_Reading(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_with_Normal_Blood_Pressure_Reading, Encounter_with_Normal_Blood_Pressure_Reading_Compute);

    private const long _cacheIndex_Encounter_with_Normal_Blood_Pressure_Reading = -3289679879080611785L;

    private IEnumerable<Encounter> Encounter_with_Normal_Blood_Pressure_Reading_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Measurement_Period(context);

        bool? b_(Encounter QualifyingEncounter) {
            IEnumerable<Observation> d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

            bool? e_(Observation BloodPressure) {
                DataType u_ = BloodPressure?.Effective;
                object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
                CqlDateTime x_ = context.Operators.End(w_);
                Period y_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
                CqlBoolean aa_ = context.Operators.In<CqlDateTime>(x_, z_, "day");

                CqlBoolean ab_() {
                    Code<ObservationStatus> ac_ = BloodPressure?.StatusElement;
                    ObservationStatus? ad_ = ac_?.Value;
                    string ae_ = context.Operators.Convert<string>(ad_);
                    string[] af_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
                    return ag_;
                }

                return aa_
                    /* CQL 'and' (164:9-165:73) */ && ab_();
            }

            IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);

            object g_(Observation @this) {
                DataType ah_ = @this?.Effective;
                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                CqlInterval<CqlDateTime> aj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ai_);
                CqlDateTime ak_ = context.Operators.Start(aj_);
                return ak_;
            }

            IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
            Observation i_ = context.Operators.Last<Observation>(h_);
            List<Observation.ComponentComponent> j_ = i_?.Component;

            bool? k_(Observation.ComponentComponent C) {
                CodeableConcept al_ = C?.Code;
                CqlConcept am_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, al_);
                CqlCode an_ = this.Systolic_blood_pressure(context);
                CqlConcept ao_ = context.Operators.ConvertCodeToConcept(an_);
                CqlBoolean ap_ = context.Operators.Equivalent(am_, ao_);
                return ap_;
            }

            IEnumerable<Observation.ComponentComponent> l_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)j_, k_);
            Observation.ComponentComponent m_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            CqlQuantity p_ = context.Operators.Quantity(1m, "mm[Hg]");
            CqlQuantity q_ = context.Operators.Quantity(120m, "mm[Hg]");
            CqlInterval<CqlQuantity> r_ = context.Operators.Interval(p_, q_, true, false);
            CqlBoolean s_ = context.Operators.In<CqlQuantity>(o_ as CqlQuantity, r_, (string)default);

            CqlBoolean t_() {
                IEnumerable<Observation> aq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

                bool? ar_(Observation BloodPressure) {
                    DataType bg_ = BloodPressure?.Effective;
                    object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                    CqlInterval<CqlDateTime> bi_ = QICoreCommon_4_0_000.Instance.toInterval(context, bh_);
                    CqlDateTime bj_ = context.Operators.End(bi_);
                    Period bk_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> bl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bk_);
                    CqlBoolean bm_ = context.Operators.In<CqlDateTime>(bj_, bl_, "day");

                    CqlBoolean bn_() {
                        Code<ObservationStatus> bo_ = BloodPressure?.StatusElement;
                        ObservationStatus? bp_ = bo_?.Value;
                        string bq_ = context.Operators.Convert<string>(bp_);
                        string[] br_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        CqlBoolean bs_ = context.Operators.In<string>(bq_, (IEnumerable<string>)br_);
                        return bs_;
                    }

                    return bm_
                        /* CQL 'and' (164:9-165:73) */ && bn_();
                }

                IEnumerable<Observation> as_ = context.Operators.Where<Observation>(aq_, ar_);

                object at_(Observation @this) {
                    DataType bt_ = @this?.Effective;
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                    CqlInterval<CqlDateTime> bv_ = QICoreCommon_4_0_000.Instance.toInterval(context, bu_);
                    CqlDateTime bw_ = context.Operators.Start(bv_);
                    return bw_;
                }

                IEnumerable<Observation> au_ = context.Operators.SortBy<Observation>(as_, at_, System.ComponentModel.ListSortDirection.Ascending);
                Observation av_ = context.Operators.Last<Observation>(au_);
                List<Observation.ComponentComponent> aw_ = av_?.Component;

                bool? ax_(Observation.ComponentComponent C) {
                    CodeableConcept bx_ = C?.Code;
                    CqlConcept by_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bx_);
                    CqlCode bz_ = this.Diastolic_blood_pressure(context);
                    CqlConcept ca_ = context.Operators.ConvertCodeToConcept(bz_);
                    CqlBoolean cb_ = context.Operators.Equivalent(by_, ca_);
                    return cb_;
                }

                IEnumerable<Observation.ComponentComponent> ay_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)aw_, ax_);
                Observation.ComponentComponent az_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ay_);
                DataType ba_ = az_?.Value;
                object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                CqlQuantity bc_ = context.Operators.Quantity(1m, "mm[Hg]");
                CqlQuantity bd_ = context.Operators.Quantity(80m, "mm[Hg]");
                CqlInterval<CqlQuantity> be_ = context.Operators.Interval(bc_, bd_, true, false);
                CqlBoolean bf_ = context.Operators.In<CqlQuantity>(bb_ as CqlQuantity, be_, (string)default);
                return bf_;
            }

            return s_
                /* CQL 'and' (168:5-175:51) */ && t_();
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter with Elevated Blood Pressure Reading SBP 120 to 129 AND DBP less than 80")]
    public IEnumerable<Encounter> Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80, Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_Compute);

    private const long _cacheIndex_Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80 = 1561143826534787341L;

    private IEnumerable<Encounter> Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Measurement_Period(context);

        bool? b_(Encounter QualifyingEncounter) {
            IEnumerable<Observation> d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

            bool? e_(Observation BloodPressure) {
                DataType u_ = BloodPressure?.Effective;
                object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
                CqlDateTime x_ = context.Operators.End(w_);
                Period y_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
                CqlBoolean aa_ = context.Operators.In<CqlDateTime>(x_, z_, "day");

                CqlBoolean ab_() {
                    Code<ObservationStatus> ac_ = BloodPressure?.StatusElement;
                    ObservationStatus? ad_ = ac_?.Value;
                    string ae_ = context.Operators.Convert<string>(ad_);
                    string[] af_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
                    return ag_;
                }

                return aa_
                    /* CQL 'and' (180:9-181:73) */ && ab_();
            }

            IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);

            object g_(Observation @this) {
                DataType ah_ = @this?.Effective;
                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                CqlInterval<CqlDateTime> aj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ai_);
                CqlDateTime ak_ = context.Operators.Start(aj_);
                return ak_;
            }

            IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
            Observation i_ = context.Operators.Last<Observation>(h_);
            List<Observation.ComponentComponent> j_ = i_?.Component;

            bool? k_(Observation.ComponentComponent C) {
                CodeableConcept al_ = C?.Code;
                CqlConcept am_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, al_);
                CqlCode an_ = this.Systolic_blood_pressure(context);
                CqlConcept ao_ = context.Operators.ConvertCodeToConcept(an_);
                CqlBoolean ap_ = context.Operators.Equivalent(am_, ao_);
                return ap_;
            }

            IEnumerable<Observation.ComponentComponent> l_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)j_, k_);
            Observation.ComponentComponent m_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            CqlQuantity p_ = context.Operators.Quantity(120m, "mm[Hg]");
            CqlQuantity q_ = context.Operators.Quantity(129m, "mm[Hg]");
            CqlInterval<CqlQuantity> r_ = context.Operators.Interval(p_, q_, true, true);
            CqlBoolean s_ = context.Operators.In<CqlQuantity>(o_ as CqlQuantity, r_, (string)default);

            CqlBoolean t_() {
                IEnumerable<Observation> aq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

                bool? ar_(Observation BloodPressure) {
                    DataType bg_ = BloodPressure?.Effective;
                    object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                    CqlInterval<CqlDateTime> bi_ = QICoreCommon_4_0_000.Instance.toInterval(context, bh_);
                    CqlDateTime bj_ = context.Operators.End(bi_);
                    Period bk_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> bl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bk_);
                    CqlBoolean bm_ = context.Operators.In<CqlDateTime>(bj_, bl_, "day");

                    CqlBoolean bn_() {
                        Code<ObservationStatus> bo_ = BloodPressure?.StatusElement;
                        ObservationStatus? bp_ = bo_?.Value;
                        string bq_ = context.Operators.Convert<string>(bp_);
                        string[] br_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        CqlBoolean bs_ = context.Operators.In<string>(bq_, (IEnumerable<string>)br_);
                        return bs_;
                    }

                    return bm_
                        /* CQL 'and' (180:9-181:73) */ && bn_();
                }

                IEnumerable<Observation> as_ = context.Operators.Where<Observation>(aq_, ar_);

                object at_(Observation @this) {
                    DataType bt_ = @this?.Effective;
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                    CqlInterval<CqlDateTime> bv_ = QICoreCommon_4_0_000.Instance.toInterval(context, bu_);
                    CqlDateTime bw_ = context.Operators.Start(bv_);
                    return bw_;
                }

                IEnumerable<Observation> au_ = context.Operators.SortBy<Observation>(as_, at_, System.ComponentModel.ListSortDirection.Ascending);
                Observation av_ = context.Operators.Last<Observation>(au_);
                List<Observation.ComponentComponent> aw_ = av_?.Component;

                bool? ax_(Observation.ComponentComponent C) {
                    CodeableConcept bx_ = C?.Code;
                    CqlConcept by_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bx_);
                    CqlCode bz_ = this.Diastolic_blood_pressure(context);
                    CqlConcept ca_ = context.Operators.ConvertCodeToConcept(bz_);
                    CqlBoolean cb_ = context.Operators.Equivalent(by_, ca_);
                    return cb_;
                }

                IEnumerable<Observation.ComponentComponent> ay_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)aw_, ax_);
                Observation.ComponentComponent az_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ay_);
                DataType ba_ = az_?.Value;
                object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                CqlQuantity bc_ = context.Operators.Quantity(1m, "mm[Hg]");
                CqlQuantity bd_ = context.Operators.Quantity(80m, "mm[Hg]");
                CqlInterval<CqlQuantity> be_ = context.Operators.Interval(bc_, bd_, true, false);
                CqlBoolean bf_ = context.Operators.In<CqlQuantity>(bb_ as CqlQuantity, be_, (string)default);
                return bf_;
            }

            return s_
                /* CQL 'and' (184:5-192:5) */ && t_();
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Follow up with Rescreen Within 6 Months")]
    public IEnumerable<ServiceRequest> Follow_up_with_Rescreen_Within_6_Months(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Follow_up_with_Rescreen_Within_6_Months, Follow_up_with_Rescreen_Within_6_Months_Compute);

    private const long _cacheIndex_Follow_up_with_Rescreen_Within_6_Months = 7152259597155334887L;

    private IEnumerable<ServiceRequest> Follow_up_with_Rescreen_Within_6_Months_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Follow_Up_Within_6_Months(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        bool? c_(ServiceRequest FollowUp) {
            Code<RequestIntent> e_ = FollowUp?.IntentElement;
            RequestIntent? f_ = e_?.Value;
            Code<RequestIntent> g_ = context.Operators.Convert<Code<RequestIntent>>(f_);
            CqlBoolean h_ = context.Operators.Equivalent(g_, "order");
            return h_;
        }

        IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("NonPharmacological Interventions")]
    public IEnumerable<ServiceRequest> NonPharmacological_Interventions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NonPharmacological_Interventions, NonPharmacological_Interventions_Compute);

    private const long _cacheIndex_NonPharmacological_Interventions = -1336665860704740796L;

    private IEnumerable<ServiceRequest> NonPharmacological_Interventions_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Lifestyle_Recommendation(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        CqlValueSet c_ = this.Weight_Reduction_Recommended(context);
        IEnumerable<ServiceRequest> d_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> e_ = context.Operators.Union<ServiceRequest>(b_, d_);
        CqlValueSet f_ = this.Dietary_Recommendations(context);
        IEnumerable<ServiceRequest> g_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        CqlValueSet h_ = this.Recommendation_to_Increase_Physical_Activity(context);
        IEnumerable<ServiceRequest> i_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> j_ = context.Operators.Union<ServiceRequest>(g_, i_);
        IEnumerable<ServiceRequest> k_ = context.Operators.Union<ServiceRequest>(e_, j_);
        CqlValueSet l_ = this.Referral_or_Counseling_for_Alcohol_Consumption(context);
        IEnumerable<ServiceRequest> m_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> n_ = context.Operators.Union<ServiceRequest>(k_, m_);

        bool? o_(ServiceRequest NonPharmaInterventions) {
            Code<RequestIntent> q_ = NonPharmaInterventions?.IntentElement;
            RequestIntent? r_ = q_?.Value;
            Code<RequestIntent> s_ = context.Operators.Convert<Code<RequestIntent>>(r_);
            string t_ = context.Operators.Convert<string>(s_);
            string[] u_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            CqlBoolean v_ = context.Operators.In<string>(t_, (IEnumerable<string>)u_);
            return v_;
        }

        IEnumerable<ServiceRequest> p_ = context.Operators.Where<ServiceRequest>(n_, o_);
        return p_;
    }


    [CqlExpressionDefinition("Referral to Alternate or Primary Healthcare Professional for Hypertensive Reading")]
    public IEnumerable<ServiceRequest> Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading, Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading_Compute);

    private const long _cacheIndex_Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading = 798953437740674768L;

    private IEnumerable<ServiceRequest> Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        bool? c_(ServiceRequest Referral) {
            List<CodeableConcept> e_ = Referral?.ReasonCode;

            CqlConcept f_(CodeableConcept @this) {
                CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return k_;
            }

            IEnumerable<CqlConcept> g_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)e_, f_);
            CqlValueSet h_ = this.Finding_of_Elevated_Blood_Pressure_or_Hypertension(context);
            CqlBoolean i_ = context.Operators.ConceptsInValueSet(g_, h_);

            CqlBoolean j_() {
                Code<RequestIntent> l_ = Referral?.IntentElement;
                RequestIntent? m_ = l_?.Value;
                Code<RequestIntent> n_ = context.Operators.Convert<Code<RequestIntent>>(m_);
                string o_ = context.Operators.Convert<string>(n_);
                string[] p_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                CqlBoolean q_ = context.Operators.In<string>(o_, (IEnumerable<string>)p_);
                return q_;
            }

            return i_
                /* CQL 'and' (118:5-119:108) */ && j_();
        }

        IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Encounter with Elevated Blood Pressure Reading SBP 120 to 129 AND DBP less than 80 and Interventions")]
    public IEnumerable<Encounter> Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_and_Interventions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_and_Interventions, Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_and_Interventions_Compute);

    private const long _cacheIndex_Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_and_Interventions = 3603924513490000529L;

    private IEnumerable<Encounter> Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_and_Interventions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80(context);

        bool? b_(Encounter ElevatedEncounter) {
            IEnumerable<ServiceRequest> i_ = this.Follow_up_with_Rescreen_Within_6_Months(context);

            bool? j_(ServiceRequest Twoto6MonthRescreen) {
                FhirDateTime l_ = Twoto6MonthRescreen?.AuthoredOnElement;
                CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(l_);
                Period n_ = ElevatedEncounter?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlBoolean p_ = context.Operators.In<CqlDateTime>(m_, o_, "day");
                return p_;
            }

            CqlBoolean k_ = context.Operators.WhereAny<ServiceRequest>(i_, j_);
            return k_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter ElevatedEncounter) {
            IEnumerable<ServiceRequest> q_ = this.NonPharmacological_Interventions(context);

            bool? r_(ServiceRequest NonPharmInterventions) {
                FhirDateTime t_ = NonPharmInterventions?.AuthoredOnElement;
                CqlDateTime u_ = context.Operators.Convert<CqlDateTime>(t_);
                Period v_ = ElevatedEncounter?.Period;
                CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, v_);
                CqlBoolean x_ = context.Operators.In<CqlDateTime>(u_, w_, "day");
                return x_;
            }

            CqlBoolean s_ = context.Operators.WhereAny<ServiceRequest>(q_, r_);
            return s_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);

        bool? f_(Encounter ElevatedEncounter) {
            IEnumerable<ServiceRequest> y_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(context);

            bool? z_(ServiceRequest Referral) {
                FhirDateTime ab_ = Referral?.AuthoredOnElement;
                CqlDateTime ac_ = context.Operators.Convert<CqlDateTime>(ab_);
                Period ad_ = ElevatedEncounter?.Period;
                CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ad_);
                CqlBoolean af_ = context.Operators.In<CqlDateTime>(ac_, ae_, "day");
                return af_;
            }

            CqlBoolean aa_ = context.Operators.WhereAny<ServiceRequest>(y_, z_);
            return aa_;
        }

        IEnumerable<Encounter> g_ = context.Operators.Where<Encounter>(a_, f_);
        IEnumerable<Encounter> h_ = context.Operators.Union<Encounter>(e_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Encounter with Hypertensive Reading Within Year Prior")]
    public IEnumerable<Encounter> Encounter_with_Hypertensive_Reading_Within_Year_Prior(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_with_Hypertensive_Reading_Within_Year_Prior, Encounter_with_Hypertensive_Reading_Within_Year_Prior_Compute);

    private const long _cacheIndex_Encounter_with_Hypertensive_Reading_Within_Year_Prior = 642947153961372105L;

    private IEnumerable<Encounter> Encounter_with_Hypertensive_Reading_Within_Year_Prior_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Measurement_Period(context);

        bool? b_(Encounter QualifyingEncounter) {
            IEnumerable<Observation> d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

            bool? e_(Observation BloodPressure) {
                DataType t_ = BloodPressure?.Effective;
                object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.toInterval(context, u_);
                CqlDateTime w_ = context.Operators.End(v_);
                Period x_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, x_);
                CqlDateTime z_ = context.Operators.Start(y_);
                CqlQuantity aa_ = context.Operators.Quantity(1m, "year");
                CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
                CqlInterval<CqlDateTime> ac_ = context.Operators.Interval(ab_, z_, true, true);
                CqlBoolean ad_ = context.Operators.In<CqlDateTime>(w_, ac_, (string)default);

                CqlBoolean ae_() {
                    Period ag_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
                    CqlDateTime ai_ = context.Operators.Start(ah_);
                    return !((bool?)(ai_ is null));
                }


                CqlBoolean af_() {
                    Code<ObservationStatus> aj_ = BloodPressure?.StatusElement;
                    ObservationStatus? ak_ = aj_?.Value;
                    string al_ = context.Operators.Convert<string>(ak_);
                    string[] am_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean an_ = context.Operators.In<string>(al_, (IEnumerable<string>)am_);
                    return an_;
                }

                return ad_
                    /* CQL 'and' (285:17-285:121) */ && ae_()
                    /* CQL 'and' (285:11-286:75) */ && af_();
            }

            IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);

            object g_(Observation @this) {
                DataType ao_ = @this?.Effective;
                object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                CqlInterval<CqlDateTime> aq_ = QICoreCommon_4_0_000.Instance.toInterval(context, ap_);
                CqlDateTime ar_ = context.Operators.Start(aq_);
                return ar_;
            }

            IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
            Observation i_ = context.Operators.Last<Observation>(h_);
            List<Observation.ComponentComponent> j_ = i_?.Component;

            bool? k_(Observation.ComponentComponent C) {
                CodeableConcept as_ = C?.Code;
                CqlConcept at_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, as_);
                CqlCode au_ = this.Systolic_blood_pressure(context);
                CqlConcept av_ = context.Operators.ConvertCodeToConcept(au_);
                CqlBoolean aw_ = context.Operators.Equivalent(at_, av_);
                return aw_;
            }

            IEnumerable<Observation.ComponentComponent> l_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)j_, k_);
            Observation.ComponentComponent m_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            CqlQuantity p_ = context.Operators.Quantity(0m, "mm[Hg]");
            CqlBoolean q_ = context.Operators.Greater(o_ as CqlQuantity, p_);

            CqlBoolean r_() {
                IEnumerable<Observation> ax_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

                bool? ay_(Observation BloodPressure) {
                    DataType bl_ = BloodPressure?.Effective;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    CqlInterval<CqlDateTime> bn_ = QICoreCommon_4_0_000.Instance.toInterval(context, bm_);
                    CqlDateTime bo_ = context.Operators.End(bn_);
                    Period bp_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> bq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bp_);
                    CqlDateTime br_ = context.Operators.Start(bq_);
                    CqlQuantity bs_ = context.Operators.Quantity(1m, "year");
                    CqlDateTime bt_ = context.Operators.Subtract(br_, bs_);
                    CqlInterval<CqlDateTime> bu_ = context.Operators.Interval(bt_, br_, true, true);
                    CqlBoolean bv_ = context.Operators.In<CqlDateTime>(bo_, bu_, (string)default);

                    CqlBoolean bw_() {
                        Period by_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> bz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, by_);
                        CqlDateTime ca_ = context.Operators.Start(bz_);
                        return !((bool?)(ca_ is null));
                    }


                    CqlBoolean bx_() {
                        Code<ObservationStatus> cb_ = BloodPressure?.StatusElement;
                        ObservationStatus? cc_ = cb_?.Value;
                        string cd_ = context.Operators.Convert<string>(cc_);
                        string[] ce_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        CqlBoolean cf_ = context.Operators.In<string>(cd_, (IEnumerable<string>)ce_);
                        return cf_;
                    }

                    return bv_
                        /* CQL 'and' (285:17-285:121) */ && bw_()
                        /* CQL 'and' (285:11-286:75) */ && bx_();
                }

                IEnumerable<Observation> az_ = context.Operators.Where<Observation>(ax_, ay_);

                object ba_(Observation @this) {
                    DataType cg_ = @this?.Effective;
                    object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                    CqlInterval<CqlDateTime> ci_ = QICoreCommon_4_0_000.Instance.toInterval(context, ch_);
                    CqlDateTime cj_ = context.Operators.Start(ci_);
                    return cj_;
                }

                IEnumerable<Observation> bb_ = context.Operators.SortBy<Observation>(az_, ba_, System.ComponentModel.ListSortDirection.Ascending);
                Observation bc_ = context.Operators.Last<Observation>(bb_);
                List<Observation.ComponentComponent> bd_ = bc_?.Component;

                bool? be_(Observation.ComponentComponent C) {
                    CodeableConcept ck_ = C?.Code;
                    CqlConcept cl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ck_);
                    CqlCode cm_ = this.Diastolic_blood_pressure(context);
                    CqlConcept cn_ = context.Operators.ConvertCodeToConcept(cm_);
                    CqlBoolean co_ = context.Operators.Equivalent(cl_, cn_);
                    return co_;
                }

                IEnumerable<Observation.ComponentComponent> bf_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)bd_, be_);
                Observation.ComponentComponent bg_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(bf_);
                DataType bh_ = bg_?.Value;
                object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                CqlQuantity bj_ = context.Operators.Quantity(0m, "mm[Hg]");
                CqlBoolean bk_ = context.Operators.Greater(bi_ as CqlQuantity, bj_);
                return bk_;
            }


            CqlBoolean s_() {
                IEnumerable<Observation> cp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

                bool? cq_(Observation BloodPressure) {
                    DataType de_ = BloodPressure?.Effective;
                    object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                    CqlInterval<CqlDateTime> dg_ = QICoreCommon_4_0_000.Instance.toInterval(context, df_);
                    CqlDateTime dh_ = context.Operators.End(dg_);
                    Period di_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> dj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, di_);
                    CqlDateTime dk_ = context.Operators.Start(dj_);
                    CqlQuantity dl_ = context.Operators.Quantity(1m, "year");
                    CqlDateTime dm_ = context.Operators.Subtract(dk_, dl_);
                    CqlInterval<CqlDateTime> dn_ = context.Operators.Interval(dm_, dk_, true, true);
                    CqlBoolean do_ = context.Operators.In<CqlDateTime>(dh_, dn_, (string)default);

                    CqlBoolean dp_() {
                        Period dr_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> ds_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dr_);
                        CqlDateTime dt_ = context.Operators.Start(ds_);
                        return !((bool?)(dt_ is null));
                    }


                    CqlBoolean dq_() {
                        Code<ObservationStatus> du_ = BloodPressure?.StatusElement;
                        ObservationStatus? dv_ = du_?.Value;
                        string dw_ = context.Operators.Convert<string>(dv_);
                        string[] dx_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        CqlBoolean dy_ = context.Operators.In<string>(dw_, (IEnumerable<string>)dx_);
                        return dy_;
                    }

                    return do_
                        /* CQL 'and' (285:17-285:121) */ && dp_()
                        /* CQL 'and' (285:11-286:75) */ && dq_();
                }

                IEnumerable<Observation> cr_ = context.Operators.Where<Observation>(cp_, cq_);

                object cs_(Observation @this) {
                    DataType dz_ = @this?.Effective;
                    object ea_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dz_);
                    CqlInterval<CqlDateTime> eb_ = QICoreCommon_4_0_000.Instance.toInterval(context, ea_);
                    CqlDateTime ec_ = context.Operators.Start(eb_);
                    return ec_;
                }

                IEnumerable<Observation> ct_ = context.Operators.SortBy<Observation>(cr_, cs_, System.ComponentModel.ListSortDirection.Ascending);
                Observation cu_ = context.Operators.Last<Observation>(ct_);
                List<Observation.ComponentComponent> cv_ = cu_?.Component;

                bool? cw_(Observation.ComponentComponent C) {
                    CodeableConcept ed_ = C?.Code;
                    CqlConcept ee_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ed_);
                    CqlCode ef_ = this.Systolic_blood_pressure(context);
                    CqlConcept eg_ = context.Operators.ConvertCodeToConcept(ef_);
                    CqlBoolean eh_ = context.Operators.Equivalent(ee_, eg_);
                    return eh_;
                }

                IEnumerable<Observation.ComponentComponent> cx_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)cv_, cw_);
                Observation.ComponentComponent cy_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(cx_);
                DataType cz_ = cy_?.Value;
                object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                CqlQuantity db_ = context.Operators.Quantity(130m, "mm[Hg]");
                CqlBoolean dc_ = context.Operators.GreaterOrEqual(da_ as CqlQuantity, db_);

                CqlBoolean dd_() {
                    IEnumerable<Observation> ei_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

                    bool? ej_(Observation BloodPressure) {
                        DataType ew_ = BloodPressure?.Effective;
                        object ex_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ew_);
                        CqlInterval<CqlDateTime> ey_ = QICoreCommon_4_0_000.Instance.toInterval(context, ex_);
                        CqlDateTime ez_ = context.Operators.End(ey_);
                        Period fa_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> fb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fa_);
                        CqlDateTime fc_ = context.Operators.Start(fb_);
                        CqlQuantity fd_ = context.Operators.Quantity(1m, "year");
                        CqlDateTime fe_ = context.Operators.Subtract(fc_, fd_);
                        CqlInterval<CqlDateTime> ff_ = context.Operators.Interval(fe_, fc_, true, true);
                        CqlBoolean fg_ = context.Operators.In<CqlDateTime>(ez_, ff_, (string)default);

                        CqlBoolean fh_() {
                            Period fj_ = QualifyingEncounter?.Period;
                            CqlInterval<CqlDateTime> fk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fj_);
                            CqlDateTime fl_ = context.Operators.Start(fk_);
                            return !((bool?)(fl_ is null));
                        }


                        CqlBoolean fi_() {
                            Code<ObservationStatus> fm_ = BloodPressure?.StatusElement;
                            ObservationStatus? fn_ = fm_?.Value;
                            string fo_ = context.Operators.Convert<string>(fn_);
                            string[] fp_ = [
                                "final",
                                "amended",
                                "corrected",
                            ];
                            CqlBoolean fq_ = context.Operators.In<string>(fo_, (IEnumerable<string>)fp_);
                            return fq_;
                        }

                        return fg_
                            /* CQL 'and' (285:17-285:121) */ && fh_()
                            /* CQL 'and' (285:11-286:75) */ && fi_();
                    }

                    IEnumerable<Observation> ek_ = context.Operators.Where<Observation>(ei_, ej_);

                    object el_(Observation @this) {
                        DataType fr_ = @this?.Effective;
                        object fs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fr_);
                        CqlInterval<CqlDateTime> ft_ = QICoreCommon_4_0_000.Instance.toInterval(context, fs_);
                        CqlDateTime fu_ = context.Operators.Start(ft_);
                        return fu_;
                    }

                    IEnumerable<Observation> em_ = context.Operators.SortBy<Observation>(ek_, el_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation en_ = context.Operators.Last<Observation>(em_);
                    List<Observation.ComponentComponent> eo_ = en_?.Component;

                    bool? ep_(Observation.ComponentComponent C) {
                        CodeableConcept fv_ = C?.Code;
                        CqlConcept fw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fv_);
                        CqlCode fx_ = this.Diastolic_blood_pressure(context);
                        CqlConcept fy_ = context.Operators.ConvertCodeToConcept(fx_);
                        CqlBoolean fz_ = context.Operators.Equivalent(fw_, fy_);
                        return fz_;
                    }

                    IEnumerable<Observation.ComponentComponent> eq_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)eo_, ep_);
                    Observation.ComponentComponent er_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(eq_);
                    DataType es_ = er_?.Value;
                    object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                    CqlQuantity eu_ = context.Operators.Quantity(80m, "mm[Hg]");
                    CqlBoolean ev_ = context.Operators.GreaterOrEqual(et_ as CqlQuantity, eu_);
                    return ev_;
                }

                return dc_
                    /* CQL 'or' (297:15-305:11) */ || dd_();
            }

            return q_
                /* CQL 'and' (289:15-296:30) */ && r_()
                /* CQL 'and' (289:7-306:7) */ && s_();
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter with First Hypertensive Reading SBP Greater than or Equal to 130 OR DBP Greater than or Equal to 80")]
    public IEnumerable<Encounter> Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80, Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_Compute);

    private const long _cacheIndex_Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80 = -727108611607069120L;

    private IEnumerable<Encounter> Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Measurement_Period(context);

        bool? b_(Encounter QualifyingEncounter) {
            IEnumerable<Observation> f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

            bool? g_(Observation BloodPressure) {
                DataType v_ = BloodPressure?.Effective;
                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                CqlInterval<CqlDateTime> x_ = QICoreCommon_4_0_000.Instance.toInterval(context, w_);
                CqlDateTime y_ = context.Operators.End(x_);
                Period z_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
                CqlBoolean ab_ = context.Operators.In<CqlDateTime>(y_, aa_, "day");

                CqlBoolean ac_() {
                    Code<ObservationStatus> ad_ = BloodPressure?.StatusElement;
                    ObservationStatus? ae_ = ad_?.Value;
                    string af_ = context.Operators.Convert<string>(ae_);
                    string[] ag_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean ah_ = context.Operators.In<string>(af_, (IEnumerable<string>)ag_);
                    return ah_;
                }

                return ab_
                    /* CQL 'and' (256:11-257:75) */ && ac_();
            }

            IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);

            object i_(Observation @this) {
                DataType ai_ = @this?.Effective;
                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                CqlInterval<CqlDateTime> ak_ = QICoreCommon_4_0_000.Instance.toInterval(context, aj_);
                CqlDateTime al_ = context.Operators.Start(ak_);
                return al_;
            }

            IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Observation k_ = context.Operators.Last<Observation>(j_);
            List<Observation.ComponentComponent> l_ = k_?.Component;

            bool? m_(Observation.ComponentComponent C) {
                CodeableConcept am_ = C?.Code;
                CqlConcept an_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, am_);
                CqlCode ao_ = this.Systolic_blood_pressure(context);
                CqlConcept ap_ = context.Operators.ConvertCodeToConcept(ao_);
                CqlBoolean aq_ = context.Operators.Equivalent(an_, ap_);
                return aq_;
            }

            IEnumerable<Observation.ComponentComponent> n_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)l_, m_);
            Observation.ComponentComponent o_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(n_);
            DataType p_ = o_?.Value;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlQuantity r_ = context.Operators.Quantity(0m, "mm[Hg]");
            CqlBoolean s_ = context.Operators.Greater(q_ as CqlQuantity, r_);

            CqlBoolean t_() {
                IEnumerable<Observation> ar_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

                bool? as_(Observation BloodPressure) {
                    DataType bf_ = BloodPressure?.Effective;
                    object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                    CqlInterval<CqlDateTime> bh_ = QICoreCommon_4_0_000.Instance.toInterval(context, bg_);
                    CqlDateTime bi_ = context.Operators.End(bh_);
                    Period bj_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> bk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bj_);
                    CqlBoolean bl_ = context.Operators.In<CqlDateTime>(bi_, bk_, "day");

                    CqlBoolean bm_() {
                        Code<ObservationStatus> bn_ = BloodPressure?.StatusElement;
                        ObservationStatus? bo_ = bn_?.Value;
                        string bp_ = context.Operators.Convert<string>(bo_);
                        string[] bq_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        CqlBoolean br_ = context.Operators.In<string>(bp_, (IEnumerable<string>)bq_);
                        return br_;
                    }

                    return bl_
                        /* CQL 'and' (256:11-257:75) */ && bm_();
                }

                IEnumerable<Observation> at_ = context.Operators.Where<Observation>(ar_, as_);

                object au_(Observation @this) {
                    DataType bs_ = @this?.Effective;
                    object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                    CqlInterval<CqlDateTime> bu_ = QICoreCommon_4_0_000.Instance.toInterval(context, bt_);
                    CqlDateTime bv_ = context.Operators.Start(bu_);
                    return bv_;
                }

                IEnumerable<Observation> av_ = context.Operators.SortBy<Observation>(at_, au_, System.ComponentModel.ListSortDirection.Ascending);
                Observation aw_ = context.Operators.Last<Observation>(av_);
                List<Observation.ComponentComponent> ax_ = aw_?.Component;

                bool? ay_(Observation.ComponentComponent C) {
                    CodeableConcept bw_ = C?.Code;
                    CqlConcept bx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bw_);
                    CqlCode by_ = this.Diastolic_blood_pressure(context);
                    CqlConcept bz_ = context.Operators.ConvertCodeToConcept(by_);
                    CqlBoolean ca_ = context.Operators.Equivalent(bx_, bz_);
                    return ca_;
                }

                IEnumerable<Observation.ComponentComponent> az_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ax_, ay_);
                Observation.ComponentComponent ba_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(az_);
                DataType bb_ = ba_?.Value;
                object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                CqlQuantity bd_ = context.Operators.Quantity(0m, "mm[Hg]");
                CqlBoolean be_ = context.Operators.Greater(bc_ as CqlQuantity, bd_);
                return be_;
            }


            CqlBoolean u_() {
                IEnumerable<Observation> cb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

                bool? cc_(Observation BloodPressure) {
                    DataType cq_ = BloodPressure?.Effective;
                    object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                    CqlInterval<CqlDateTime> cs_ = QICoreCommon_4_0_000.Instance.toInterval(context, cr_);
                    CqlDateTime ct_ = context.Operators.End(cs_);
                    Period cu_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> cv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cu_);
                    CqlBoolean cw_ = context.Operators.In<CqlDateTime>(ct_, cv_, "day");

                    CqlBoolean cx_() {
                        Code<ObservationStatus> cy_ = BloodPressure?.StatusElement;
                        ObservationStatus? cz_ = cy_?.Value;
                        string da_ = context.Operators.Convert<string>(cz_);
                        string[] db_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        CqlBoolean dc_ = context.Operators.In<string>(da_, (IEnumerable<string>)db_);
                        return dc_;
                    }

                    return cw_
                        /* CQL 'and' (256:11-257:75) */ && cx_();
                }

                IEnumerable<Observation> cd_ = context.Operators.Where<Observation>(cb_, cc_);

                object ce_(Observation @this) {
                    DataType dd_ = @this?.Effective;
                    object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                    CqlInterval<CqlDateTime> df_ = QICoreCommon_4_0_000.Instance.toInterval(context, de_);
                    CqlDateTime dg_ = context.Operators.Start(df_);
                    return dg_;
                }

                IEnumerable<Observation> cf_ = context.Operators.SortBy<Observation>(cd_, ce_, System.ComponentModel.ListSortDirection.Ascending);
                Observation cg_ = context.Operators.Last<Observation>(cf_);
                List<Observation.ComponentComponent> ch_ = cg_?.Component;

                bool? ci_(Observation.ComponentComponent C) {
                    CodeableConcept dh_ = C?.Code;
                    CqlConcept di_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dh_);
                    CqlCode dj_ = this.Systolic_blood_pressure(context);
                    CqlConcept dk_ = context.Operators.ConvertCodeToConcept(dj_);
                    CqlBoolean dl_ = context.Operators.Equivalent(di_, dk_);
                    return dl_;
                }

                IEnumerable<Observation.ComponentComponent> cj_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ch_, ci_);
                Observation.ComponentComponent ck_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(cj_);
                DataType cl_ = ck_?.Value;
                object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                CqlQuantity cn_ = context.Operators.Quantity(130m, "mm[Hg]");
                CqlBoolean co_ = context.Operators.GreaterOrEqual(cm_ as CqlQuantity, cn_);

                CqlBoolean cp_() {
                    IEnumerable<Observation> dm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

                    bool? dn_(Observation BloodPressure) {
                        DataType ea_ = BloodPressure?.Effective;
                        object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                        CqlInterval<CqlDateTime> ec_ = QICoreCommon_4_0_000.Instance.toInterval(context, eb_);
                        CqlDateTime ed_ = context.Operators.End(ec_);
                        Period ee_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> ef_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ee_);
                        CqlBoolean eg_ = context.Operators.In<CqlDateTime>(ed_, ef_, "day");

                        CqlBoolean eh_() {
                            Code<ObservationStatus> ei_ = BloodPressure?.StatusElement;
                            ObservationStatus? ej_ = ei_?.Value;
                            string ek_ = context.Operators.Convert<string>(ej_);
                            string[] el_ = [
                                "final",
                                "amended",
                                "corrected",
                            ];
                            CqlBoolean em_ = context.Operators.In<string>(ek_, (IEnumerable<string>)el_);
                            return em_;
                        }

                        return eg_
                            /* CQL 'and' (256:11-257:75) */ && eh_();
                    }

                    IEnumerable<Observation> do_ = context.Operators.Where<Observation>(dm_, dn_);

                    object dp_(Observation @this) {
                        DataType en_ = @this?.Effective;
                        object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                        CqlInterval<CqlDateTime> ep_ = QICoreCommon_4_0_000.Instance.toInterval(context, eo_);
                        CqlDateTime eq_ = context.Operators.Start(ep_);
                        return eq_;
                    }

                    IEnumerable<Observation> dq_ = context.Operators.SortBy<Observation>(do_, dp_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation dr_ = context.Operators.Last<Observation>(dq_);
                    List<Observation.ComponentComponent> ds_ = dr_?.Component;

                    bool? dt_(Observation.ComponentComponent C) {
                        CodeableConcept er_ = C?.Code;
                        CqlConcept es_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, er_);
                        CqlCode et_ = this.Diastolic_blood_pressure(context);
                        CqlConcept eu_ = context.Operators.ConvertCodeToConcept(et_);
                        CqlBoolean ev_ = context.Operators.Equivalent(es_, eu_);
                        return ev_;
                    }

                    IEnumerable<Observation.ComponentComponent> du_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ds_, dt_);
                    Observation.ComponentComponent dv_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(du_);
                    DataType dw_ = dv_?.Value;
                    object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                    CqlQuantity dy_ = context.Operators.Quantity(80m, "mm[Hg]");
                    CqlBoolean dz_ = context.Operators.GreaterOrEqual(dx_ as CqlQuantity, dy_);
                    return dz_;
                }

                return co_
                    /* CQL 'or' (269:15-277:11) */ || cp_();
            }

            return s_
                /* CQL 'and' (260:15-268:9) */ && t_()
                /* CQL 'and' (260:7-278:7) */ && u_();
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior(context);
        IEnumerable<Encounter> e_ = context.Operators.Except<Encounter>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("First Hypertensive Reading Interventions or Referral to Alternate Professional")]
    public IEnumerable<ServiceRequest> First_Hypertensive_Reading_Interventions_or_Referral_to_Alternate_Professional(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_First_Hypertensive_Reading_Interventions_or_Referral_to_Alternate_Professional, First_Hypertensive_Reading_Interventions_or_Referral_to_Alternate_Professional_Compute);

    private const long _cacheIndex_First_Hypertensive_Reading_Interventions_or_Referral_to_Alternate_Professional = -4104918889481513848L;

    private IEnumerable<ServiceRequest> First_Hypertensive_Reading_Interventions_or_Referral_to_Alternate_Professional_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Follow_Up_Within_4_Weeks(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        bool? c_(ServiceRequest FourWeekRescreen) {
            IEnumerable<ServiceRequest> g_ = this.NonPharmacological_Interventions(context);

            bool? h_(ServiceRequest NonPharmInterventionsHTN) {
                FhirDateTime j_ = FourWeekRescreen?.AuthoredOnElement;
                CqlDateTime k_ = context.Operators.Convert<CqlDateTime>(j_);
                CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
                CqlBoolean m_ = context.Operators.In<CqlDateTime>(k_, l_, "day");

                CqlBoolean n_() {
                    FhirDateTime p_ = NonPharmInterventionsHTN?.AuthoredOnElement;
                    CqlDateTime q_ = context.Operators.Convert<CqlDateTime>(p_);
                    CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
                    CqlBoolean s_ = context.Operators.In<CqlDateTime>(q_, r_, "day");
                    return s_;
                }


                CqlBoolean o_() {
                    Code<RequestIntent> t_ = FourWeekRescreen?.IntentElement;
                    RequestIntent? u_ = t_?.Value;
                    Code<RequestIntent> v_ = context.Operators.Convert<Code<RequestIntent>>(u_);
                    string w_ = context.Operators.Convert<string>(v_);
                    string[] x_ = [
                        "order",
                        "original-order",
                        "reflex-order",
                        "filler-order",
                        "instance-order",
                    ];
                    CqlBoolean y_ = context.Operators.In<string>(w_, (IEnumerable<string>)x_);
                    return y_;
                }

                return m_
                    /* CQL 'and' (110:19-111:84) */ && n_()
                    /* CQL 'and' (110:19-112:120) */ && o_();
            }

            CqlBoolean i_ = context.Operators.WhereAny<ServiceRequest>(g_, h_);
            return i_;
        }

        IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);
        IEnumerable<ServiceRequest> e_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(context);
        IEnumerable<ServiceRequest> f_ = context.Operators.Union<ServiceRequest>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Encounter with First Hypertensive Reading SBP Greater than or Equal to 130 OR DBP Greater than or Equal to 80 and Interventions")]
    public IEnumerable<Encounter> Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_and_Interventions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_and_Interventions, Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_and_Interventions_Compute);

    private const long _cacheIndex_Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_and_Interventions = 701637351502478151L;

    private IEnumerable<Encounter> Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_and_Interventions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80(context);

        bool? b_(Encounter FirstHTNEncounter) {
            IEnumerable<ServiceRequest> d_ = this.First_Hypertensive_Reading_Interventions_or_Referral_to_Alternate_Professional(context);

            bool? e_(ServiceRequest FirstHTNIntervention) {
                FhirDateTime g_ = FirstHTNIntervention?.AuthoredOnElement;
                CqlDateTime h_ = context.Operators.Convert<CqlDateTime>(g_);
                Period i_ = FirstHTNEncounter?.Period;
                CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                CqlBoolean k_ = context.Operators.In<CqlDateTime>(h_, j_, "day");
                return k_;
            }

            CqlBoolean f_ = context.Operators.WhereAny<ServiceRequest>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter with Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89")]
    public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89, Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Compute);

    private const long _cacheIndex_Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89 = 902164234878548056L;

    private IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Measurement_Period(context);

        bool? b_(Encounter QualifyingEncounter) {
            IEnumerable<Observation> f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

            bool? g_(Observation BloodPressure) {
                DataType x_ = BloodPressure?.Effective;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                CqlInterval<CqlDateTime> z_ = QICoreCommon_4_0_000.Instance.toInterval(context, y_);
                CqlDateTime aa_ = context.Operators.End(z_);
                Period ab_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ab_);
                CqlBoolean ad_ = context.Operators.In<CqlDateTime>(aa_, ac_, "day");

                CqlBoolean ae_() {
                    Code<ObservationStatus> af_ = BloodPressure?.StatusElement;
                    ObservationStatus? ag_ = af_?.Value;
                    string ah_ = context.Operators.Convert<string>(ag_);
                    string[] ai_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean aj_ = context.Operators.In<string>(ah_, (IEnumerable<string>)ai_);
                    return aj_;
                }

                return ad_
                    /* CQL 'and' (226:13-227:77) */ && ae_();
            }

            IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);

            object i_(Observation @this) {
                DataType ak_ = @this?.Effective;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                CqlInterval<CqlDateTime> am_ = QICoreCommon_4_0_000.Instance.toInterval(context, al_);
                CqlDateTime an_ = context.Operators.Start(am_);
                return an_;
            }

            IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Observation k_ = context.Operators.Last<Observation>(j_);
            List<Observation.ComponentComponent> l_ = k_?.Component;

            bool? m_(Observation.ComponentComponent C) {
                CodeableConcept ao_ = C?.Code;
                CqlConcept ap_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ao_);
                CqlCode aq_ = this.Systolic_blood_pressure(context);
                CqlConcept ar_ = context.Operators.ConvertCodeToConcept(aq_);
                CqlBoolean as_ = context.Operators.Equivalent(ap_, ar_);
                return as_;
            }

            IEnumerable<Observation.ComponentComponent> n_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)l_, m_);
            Observation.ComponentComponent o_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(n_);
            DataType p_ = o_?.Value;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlQuantity r_ = context.Operators.Quantity(130m, "mm[Hg]");
            CqlQuantity s_ = context.Operators.Quantity(139m, "mm[Hg]");
            CqlInterval<CqlQuantity> t_ = context.Operators.Interval(r_, s_, true, true);
            CqlBoolean u_ = context.Operators.In<CqlQuantity>(q_ as CqlQuantity, t_, (string)default);

            CqlBoolean v_() {
                IEnumerable<Observation> at_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

                bool? au_(Observation BloodPressure) {
                    DataType bj_ = BloodPressure?.Effective;
                    object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                    CqlInterval<CqlDateTime> bl_ = QICoreCommon_4_0_000.Instance.toInterval(context, bk_);
                    CqlDateTime bm_ = context.Operators.End(bl_);
                    Period bn_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> bo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bn_);
                    CqlBoolean bp_ = context.Operators.In<CqlDateTime>(bm_, bo_, "day");

                    CqlBoolean bq_() {
                        Code<ObservationStatus> br_ = BloodPressure?.StatusElement;
                        ObservationStatus? bs_ = br_?.Value;
                        string bt_ = context.Operators.Convert<string>(bs_);
                        string[] bu_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        CqlBoolean bv_ = context.Operators.In<string>(bt_, (IEnumerable<string>)bu_);
                        return bv_;
                    }

                    return bp_
                        /* CQL 'and' (226:13-227:77) */ && bq_();
                }

                IEnumerable<Observation> av_ = context.Operators.Where<Observation>(at_, au_);

                object aw_(Observation @this) {
                    DataType bw_ = @this?.Effective;
                    object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                    CqlInterval<CqlDateTime> by_ = QICoreCommon_4_0_000.Instance.toInterval(context, bx_);
                    CqlDateTime bz_ = context.Operators.Start(by_);
                    return bz_;
                }

                IEnumerable<Observation> ax_ = context.Operators.SortBy<Observation>(av_, aw_, System.ComponentModel.ListSortDirection.Ascending);
                Observation ay_ = context.Operators.Last<Observation>(ax_);
                List<Observation.ComponentComponent> az_ = ay_?.Component;

                bool? ba_(Observation.ComponentComponent C) {
                    CodeableConcept ca_ = C?.Code;
                    CqlConcept cb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ca_);
                    CqlCode cc_ = this.Diastolic_blood_pressure(context);
                    CqlConcept cd_ = context.Operators.ConvertCodeToConcept(cc_);
                    CqlBoolean ce_ = context.Operators.Equivalent(cb_, cd_);
                    return ce_;
                }

                IEnumerable<Observation.ComponentComponent> bb_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)az_, ba_);
                Observation.ComponentComponent bc_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(bb_);
                DataType bd_ = bc_?.Value;
                object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                CqlQuantity bf_ = context.Operators.Quantity(80m, "mm[Hg]");
                CqlQuantity bg_ = context.Operators.Quantity(89m, "mm[Hg]");
                CqlInterval<CqlQuantity> bh_ = context.Operators.Interval(bf_, bg_, true, true);
                CqlBoolean bi_ = context.Operators.In<CqlQuantity>(be_ as CqlQuantity, bh_, (string)default);
                return bi_;
            }


            CqlBoolean w_() {
                IEnumerable<Observation> cf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

                bool? cg_(Observation BloodPressure) {
                    DataType cu_ = BloodPressure?.Effective;
                    object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                    CqlInterval<CqlDateTime> cw_ = QICoreCommon_4_0_000.Instance.toInterval(context, cv_);
                    CqlDateTime cx_ = context.Operators.End(cw_);
                    Period cy_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> cz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cy_);
                    CqlBoolean da_ = context.Operators.In<CqlDateTime>(cx_, cz_, "day");

                    CqlBoolean db_() {
                        Code<ObservationStatus> dc_ = BloodPressure?.StatusElement;
                        ObservationStatus? dd_ = dc_?.Value;
                        string de_ = context.Operators.Convert<string>(dd_);
                        string[] df_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        CqlBoolean dg_ = context.Operators.In<string>(de_, (IEnumerable<string>)df_);
                        return dg_;
                    }

                    return da_
                        /* CQL 'and' (226:13-227:77) */ && db_();
                }

                IEnumerable<Observation> ch_ = context.Operators.Where<Observation>(cf_, cg_);

                object ci_(Observation @this) {
                    DataType dh_ = @this?.Effective;
                    object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                    CqlInterval<CqlDateTime> dj_ = QICoreCommon_4_0_000.Instance.toInterval(context, di_);
                    CqlDateTime dk_ = context.Operators.Start(dj_);
                    return dk_;
                }

                IEnumerable<Observation> cj_ = context.Operators.SortBy<Observation>(ch_, ci_, System.ComponentModel.ListSortDirection.Ascending);
                Observation ck_ = context.Operators.Last<Observation>(cj_);
                List<Observation.ComponentComponent> cl_ = ck_?.Component;

                bool? cm_(Observation.ComponentComponent C) {
                    CodeableConcept dl_ = C?.Code;
                    CqlConcept dm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dl_);
                    CqlCode dn_ = this.Systolic_blood_pressure(context);
                    CqlConcept do_ = context.Operators.ConvertCodeToConcept(dn_);
                    CqlBoolean dp_ = context.Operators.Equivalent(dm_, do_);
                    return dp_;
                }

                IEnumerable<Observation.ComponentComponent> cn_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)cl_, cm_);
                Observation.ComponentComponent co_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(cn_);
                DataType cp_ = co_?.Value;
                object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                CqlQuantity cr_ = context.Operators.Quantity(140m, "mm[Hg]");
                CqlBoolean cs_ = context.Operators.GreaterOrEqual(cq_ as CqlQuantity, cr_);

                CqlBoolean ct_() {
                    IEnumerable<Observation> dq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

                    bool? dr_(Observation BloodPressure) {
                        DataType ee_ = BloodPressure?.Effective;
                        object ef_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ee_);
                        CqlInterval<CqlDateTime> eg_ = QICoreCommon_4_0_000.Instance.toInterval(context, ef_);
                        CqlDateTime eh_ = context.Operators.End(eg_);
                        Period ei_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> ej_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ei_);
                        CqlBoolean ek_ = context.Operators.In<CqlDateTime>(eh_, ej_, "day");

                        CqlBoolean el_() {
                            Code<ObservationStatus> em_ = BloodPressure?.StatusElement;
                            ObservationStatus? en_ = em_?.Value;
                            string eo_ = context.Operators.Convert<string>(en_);
                            string[] ep_ = [
                                "final",
                                "amended",
                                "corrected",
                            ];
                            CqlBoolean eq_ = context.Operators.In<string>(eo_, (IEnumerable<string>)ep_);
                            return eq_;
                        }

                        return ek_
                            /* CQL 'and' (226:13-227:77) */ && el_();
                    }

                    IEnumerable<Observation> ds_ = context.Operators.Where<Observation>(dq_, dr_);

                    object dt_(Observation @this) {
                        DataType er_ = @this?.Effective;
                        object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                        CqlInterval<CqlDateTime> et_ = QICoreCommon_4_0_000.Instance.toInterval(context, es_);
                        CqlDateTime eu_ = context.Operators.Start(et_);
                        return eu_;
                    }

                    IEnumerable<Observation> du_ = context.Operators.SortBy<Observation>(ds_, dt_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation dv_ = context.Operators.Last<Observation>(du_);
                    List<Observation.ComponentComponent> dw_ = dv_?.Component;

                    bool? dx_(Observation.ComponentComponent C) {
                        CodeableConcept ev_ = C?.Code;
                        CqlConcept ew_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ev_);
                        CqlCode ex_ = this.Diastolic_blood_pressure(context);
                        CqlConcept ey_ = context.Operators.ConvertCodeToConcept(ex_);
                        CqlBoolean ez_ = context.Operators.Equivalent(ew_, ey_);
                        return ez_;
                    }

                    IEnumerable<Observation.ComponentComponent> dy_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)dw_, dx_);
                    Observation.ComponentComponent dz_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(dy_);
                    DataType ea_ = dz_?.Value;
                    object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                    CqlQuantity ec_ = context.Operators.Quantity(90m, "mm[Hg]");
                    CqlBoolean ed_ = context.Operators.GreaterOrEqual(eb_ as CqlQuantity, ec_);
                    return ed_;
                }

                return !((bool?)(cs_
                    /* CQL 'or' (239:21-247:13) */ || ct_()));
            }

            return (u_
                /* CQL 'or' (230:17-238:11) */ || v_())
                /* CQL 'and' (230:9-248:9) */ && w_();
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior(context);
        IEnumerable<Encounter> e_ = context.Operators.Intersect<Encounter>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Laboratory Test or ECG for Hypertension")]
    public IEnumerable<ServiceRequest> Laboratory_Test_or_ECG_for_Hypertension(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Laboratory_Test_or_ECG_for_Hypertension, Laboratory_Test_or_ECG_for_Hypertension_Compute);

    private const long _cacheIndex_Laboratory_Test_or_ECG_for_Hypertension = 974567035854950012L;

    private IEnumerable<ServiceRequest> Laboratory_Test_or_ECG_for_Hypertension_Compute(CqlContext context)
    {
        CqlCode a_ = this._12_lead_EKG_panel(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<ServiceRequest> c_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        CqlCode d_ = this.EKG_study(context);
        IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
        IEnumerable<ServiceRequest> f_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> g_ = context.Operators.Union<ServiceRequest>(c_, f_);
        CqlValueSet h_ = this.Laboratory_Tests_for_Hypertension(context);
        IEnumerable<ServiceRequest> i_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> j_ = context.Operators.Union<ServiceRequest>(g_, i_);

        bool? k_(ServiceRequest EKGLab) {
            Code<RequestIntent> m_ = EKGLab?.IntentElement;
            RequestIntent? n_ = m_?.Value;
            Code<RequestIntent> o_ = context.Operators.Convert<Code<RequestIntent>>(n_);
            string p_ = context.Operators.Convert<string>(o_);
            string[] q_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            CqlBoolean r_ = context.Operators.In<string>(p_, (IEnumerable<string>)q_);
            return r_;
        }

        IEnumerable<ServiceRequest> l_ = context.Operators.Where<ServiceRequest>(j_, k_);
        return l_;
    }


    [CqlExpressionDefinition("Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 and Interventions")]
    public IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions, Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions_Compute);

    private const long _cacheIndex_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions = -1906076675216982303L;

    private IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions_Compute(CqlContext context)
    {
        IEnumerable<ServiceRequest> a_ = this.Follow_up_with_Rescreen_Within_6_Months(context);

        bool? b_(ServiceRequest Rescreen2to6) {
            IEnumerable<ServiceRequest> f_ = this.Laboratory_Test_or_ECG_for_Hypertension(context);

            bool? g_(ServiceRequest LabECGIntervention) {
                FhirDateTime i_ = Rescreen2to6?.AuthoredOnElement;
                CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
                CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
                CqlBoolean l_ = context.Operators.In<CqlDateTime>(j_, k_, "day");

                CqlBoolean m_() {
                    FhirDateTime n_ = LabECGIntervention?.AuthoredOnElement;
                    CqlDateTime o_ = context.Operators.Convert<CqlDateTime>(n_);
                    CqlInterval<CqlDateTime> p_ = this.Measurement_Period(context);
                    CqlBoolean q_ = context.Operators.In<CqlDateTime>(o_, p_, "day");
                    return q_;
                }

                return l_
                    /* CQL 'and' (138:17-139:76) */ && m_();
            }

            CqlBoolean h_ = context.Operators.WhereAny<ServiceRequest>(f_, g_);
            return h_;
        }

        IEnumerable<ServiceRequest> c_ = context.Operators.Where<ServiceRequest>(a_, b_);

        bool? d_(ServiceRequest Rescreen2to6) {
            IEnumerable<ServiceRequest> r_ = this.NonPharmacological_Interventions(context);

            bool? s_(ServiceRequest NonPharmSecondIntervention) {
                FhirDateTime u_ = NonPharmSecondIntervention?.AuthoredOnElement;
                CqlDateTime v_ = context.Operators.Convert<CqlDateTime>(u_);
                CqlInterval<CqlDateTime> w_ = this.Measurement_Period(context);
                CqlBoolean x_ = context.Operators.In<CqlDateTime>(v_, w_, "day");
                return x_;
            }

            CqlBoolean t_ = context.Operators.WhereAny<ServiceRequest>(r_, s_);
            return t_;
        }

        IEnumerable<ServiceRequest> e_ = context.Operators.Where<ServiceRequest>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Encounter with Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 and Interventions")]
    public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions, Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions_Compute);

    private const long _cacheIndex_Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions = -258842581733264246L;

    private IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89(context);

        bool? b_(Encounter SecondHTNEncounterReading) {
            IEnumerable<ServiceRequest> g_ = this.Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions(context);

            bool? h_(ServiceRequest EncounterInterventions) {
                FhirDateTime j_ = EncounterInterventions?.AuthoredOnElement;
                CqlDateTime k_ = context.Operators.Convert<CqlDateTime>(j_);
                Period l_ = SecondHTNEncounterReading?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                CqlBoolean n_ = context.Operators.In<CqlDateTime>(k_, m_, "day");
                return n_;
            }

            CqlBoolean i_ = context.Operators.WhereAny<ServiceRequest>(g_, h_);
            return i_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter SecondHTNEncounterReading) {
            IEnumerable<ServiceRequest> o_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(context);

            bool? p_(ServiceRequest ReferralForHTN) {
                FhirDateTime r_ = ReferralForHTN?.AuthoredOnElement;
                CqlDateTime s_ = context.Operators.Convert<CqlDateTime>(r_);
                Period t_ = SecondHTNEncounterReading?.Period;
                CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
                CqlBoolean v_ = context.Operators.In<CqlDateTime>(s_, u_, "day");
                return v_;
            }

            CqlBoolean q_ = context.Operators.WhereAny<ServiceRequest>(o_, p_);
            return q_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(a_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(c_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Encounter with Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90")]
    public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90, Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Compute);

    private const long _cacheIndex_Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90 = 3986487361060020718L;

    private IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Measurement_Period(context);

        bool? b_(Encounter QualifyingEncounter) {
            IEnumerable<Observation> f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

            bool? g_(Observation BloodPressure) {
                DataType v_ = BloodPressure?.Effective;
                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                CqlInterval<CqlDateTime> x_ = QICoreCommon_4_0_000.Instance.toInterval(context, w_);
                CqlDateTime y_ = context.Operators.End(x_);
                Period z_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
                CqlBoolean ab_ = context.Operators.In<CqlDateTime>(y_, aa_, "day");

                CqlBoolean ac_() {
                    Code<ObservationStatus> ad_ = BloodPressure?.StatusElement;
                    ObservationStatus? ae_ = ad_?.Value;
                    string af_ = context.Operators.Convert<string>(ae_);
                    string[] ag_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean ah_ = context.Operators.In<string>(af_, (IEnumerable<string>)ag_);
                    return ah_;
                }

                return ab_
                    /* CQL 'and' (197:13-198:77) */ && ac_();
            }

            IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);

            object i_(Observation @this) {
                DataType ai_ = @this?.Effective;
                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                CqlInterval<CqlDateTime> ak_ = QICoreCommon_4_0_000.Instance.toInterval(context, aj_);
                CqlDateTime al_ = context.Operators.Start(ak_);
                return al_;
            }

            IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Observation k_ = context.Operators.Last<Observation>(j_);
            List<Observation.ComponentComponent> l_ = k_?.Component;

            bool? m_(Observation.ComponentComponent C) {
                CodeableConcept am_ = C?.Code;
                CqlConcept an_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, am_);
                CqlCode ao_ = this.Systolic_blood_pressure(context);
                CqlConcept ap_ = context.Operators.ConvertCodeToConcept(ao_);
                CqlBoolean aq_ = context.Operators.Equivalent(an_, ap_);
                return aq_;
            }

            IEnumerable<Observation.ComponentComponent> n_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)l_, m_);
            Observation.ComponentComponent o_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(n_);
            DataType p_ = o_?.Value;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlQuantity r_ = context.Operators.Quantity(0m, "mm[Hg]");
            CqlBoolean s_ = context.Operators.Greater(q_ as CqlQuantity, r_);

            CqlBoolean t_() {
                IEnumerable<Observation> ar_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

                bool? as_(Observation BloodPressure) {
                    DataType bf_ = BloodPressure?.Effective;
                    object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                    CqlInterval<CqlDateTime> bh_ = QICoreCommon_4_0_000.Instance.toInterval(context, bg_);
                    CqlDateTime bi_ = context.Operators.End(bh_);
                    Period bj_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> bk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bj_);
                    CqlBoolean bl_ = context.Operators.In<CqlDateTime>(bi_, bk_, "day");

                    CqlBoolean bm_() {
                        Code<ObservationStatus> bn_ = BloodPressure?.StatusElement;
                        ObservationStatus? bo_ = bn_?.Value;
                        string bp_ = context.Operators.Convert<string>(bo_);
                        string[] bq_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        CqlBoolean br_ = context.Operators.In<string>(bp_, (IEnumerable<string>)bq_);
                        return br_;
                    }

                    return bl_
                        /* CQL 'and' (197:13-198:77) */ && bm_();
                }

                IEnumerable<Observation> at_ = context.Operators.Where<Observation>(ar_, as_);

                object au_(Observation @this) {
                    DataType bs_ = @this?.Effective;
                    object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                    CqlInterval<CqlDateTime> bu_ = QICoreCommon_4_0_000.Instance.toInterval(context, bt_);
                    CqlDateTime bv_ = context.Operators.Start(bu_);
                    return bv_;
                }

                IEnumerable<Observation> av_ = context.Operators.SortBy<Observation>(at_, au_, System.ComponentModel.ListSortDirection.Ascending);
                Observation aw_ = context.Operators.Last<Observation>(av_);
                List<Observation.ComponentComponent> ax_ = aw_?.Component;

                bool? ay_(Observation.ComponentComponent C) {
                    CodeableConcept bw_ = C?.Code;
                    CqlConcept bx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bw_);
                    CqlCode by_ = this.Diastolic_blood_pressure(context);
                    CqlConcept bz_ = context.Operators.ConvertCodeToConcept(by_);
                    CqlBoolean ca_ = context.Operators.Equivalent(bx_, bz_);
                    return ca_;
                }

                IEnumerable<Observation.ComponentComponent> az_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ax_, ay_);
                Observation.ComponentComponent ba_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(az_);
                DataType bb_ = ba_?.Value;
                object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                CqlQuantity bd_ = context.Operators.Quantity(0m, "mm[Hg]");
                CqlBoolean be_ = context.Operators.Greater(bc_ as CqlQuantity, bd_);
                return be_;
            }


            CqlBoolean u_() {
                IEnumerable<Observation> cb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

                bool? cc_(Observation BloodPressure) {
                    DataType cq_ = BloodPressure?.Effective;
                    object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                    CqlInterval<CqlDateTime> cs_ = QICoreCommon_4_0_000.Instance.toInterval(context, cr_);
                    CqlDateTime ct_ = context.Operators.End(cs_);
                    Period cu_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> cv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cu_);
                    CqlBoolean cw_ = context.Operators.In<CqlDateTime>(ct_, cv_, "day");

                    CqlBoolean cx_() {
                        Code<ObservationStatus> cy_ = BloodPressure?.StatusElement;
                        ObservationStatus? cz_ = cy_?.Value;
                        string da_ = context.Operators.Convert<string>(cz_);
                        string[] db_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        CqlBoolean dc_ = context.Operators.In<string>(da_, (IEnumerable<string>)db_);
                        return dc_;
                    }

                    return cw_
                        /* CQL 'and' (197:13-198:77) */ && cx_();
                }

                IEnumerable<Observation> cd_ = context.Operators.Where<Observation>(cb_, cc_);

                object ce_(Observation @this) {
                    DataType dd_ = @this?.Effective;
                    object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                    CqlInterval<CqlDateTime> df_ = QICoreCommon_4_0_000.Instance.toInterval(context, de_);
                    CqlDateTime dg_ = context.Operators.Start(df_);
                    return dg_;
                }

                IEnumerable<Observation> cf_ = context.Operators.SortBy<Observation>(cd_, ce_, System.ComponentModel.ListSortDirection.Ascending);
                Observation cg_ = context.Operators.Last<Observation>(cf_);
                List<Observation.ComponentComponent> ch_ = cg_?.Component;

                bool? ci_(Observation.ComponentComponent C) {
                    CodeableConcept dh_ = C?.Code;
                    CqlConcept di_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dh_);
                    CqlCode dj_ = this.Systolic_blood_pressure(context);
                    CqlConcept dk_ = context.Operators.ConvertCodeToConcept(dj_);
                    CqlBoolean dl_ = context.Operators.Equivalent(di_, dk_);
                    return dl_;
                }

                IEnumerable<Observation.ComponentComponent> cj_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ch_, ci_);
                Observation.ComponentComponent ck_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(cj_);
                DataType cl_ = ck_?.Value;
                object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                CqlQuantity cn_ = context.Operators.Quantity(140m, "mm[Hg]");
                CqlBoolean co_ = context.Operators.GreaterOrEqual(cm_ as CqlQuantity, cn_);

                CqlBoolean cp_() {
                    IEnumerable<Observation> dm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

                    bool? dn_(Observation BloodPressure) {
                        DataType ea_ = BloodPressure?.Effective;
                        object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                        CqlInterval<CqlDateTime> ec_ = QICoreCommon_4_0_000.Instance.toInterval(context, eb_);
                        CqlDateTime ed_ = context.Operators.End(ec_);
                        Period ee_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> ef_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ee_);
                        CqlBoolean eg_ = context.Operators.In<CqlDateTime>(ed_, ef_, "day");

                        CqlBoolean eh_() {
                            Code<ObservationStatus> ei_ = BloodPressure?.StatusElement;
                            ObservationStatus? ej_ = ei_?.Value;
                            string ek_ = context.Operators.Convert<string>(ej_);
                            string[] el_ = [
                                "final",
                                "amended",
                                "corrected",
                            ];
                            CqlBoolean em_ = context.Operators.In<string>(ek_, (IEnumerable<string>)el_);
                            return em_;
                        }

                        return eg_
                            /* CQL 'and' (197:13-198:77) */ && eh_();
                    }

                    IEnumerable<Observation> do_ = context.Operators.Where<Observation>(dm_, dn_);

                    object dp_(Observation @this) {
                        DataType en_ = @this?.Effective;
                        object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                        CqlInterval<CqlDateTime> ep_ = QICoreCommon_4_0_000.Instance.toInterval(context, eo_);
                        CqlDateTime eq_ = context.Operators.Start(ep_);
                        return eq_;
                    }

                    IEnumerable<Observation> dq_ = context.Operators.SortBy<Observation>(do_, dp_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation dr_ = context.Operators.Last<Observation>(dq_);
                    List<Observation.ComponentComponent> ds_ = dr_?.Component;

                    bool? dt_(Observation.ComponentComponent C) {
                        CodeableConcept er_ = C?.Code;
                        CqlConcept es_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, er_);
                        CqlCode et_ = this.Diastolic_blood_pressure(context);
                        CqlConcept eu_ = context.Operators.ConvertCodeToConcept(et_);
                        CqlBoolean ev_ = context.Operators.Equivalent(es_, eu_);
                        return ev_;
                    }

                    IEnumerable<Observation.ComponentComponent> du_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ds_, dt_);
                    Observation.ComponentComponent dv_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(du_);
                    DataType dw_ = dv_?.Value;
                    object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                    CqlQuantity dy_ = context.Operators.Quantity(90m, "mm[Hg]");
                    CqlBoolean dz_ = context.Operators.GreaterOrEqual(dx_ as CqlQuantity, dy_);
                    return dz_;
                }

                return co_
                    /* CQL 'or' (209:17-217:13) */ || cp_();
            }

            return s_
                /* CQL 'and' (201:17-208:32) */ && t_()
                /* CQL 'and' (201:9-218:9) */ && u_();
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior(context);
        IEnumerable<Encounter> e_ = context.Operators.Intersect<Encounter>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 Interventions")]
    public IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions, Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Compute);

    private const long _cacheIndex_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions = -1721575913823299180L;

    private IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Follow_Up_Within_4_Weeks(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        bool? c_(ServiceRequest WeeksRescreen) {
            IEnumerable<ServiceRequest> i_ = this.Laboratory_Test_or_ECG_for_Hypertension(context);

            bool? j_(ServiceRequest ECGLabTest) {
                FhirDateTime l_ = WeeksRescreen?.AuthoredOnElement;
                CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(l_);
                CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
                CqlBoolean o_ = context.Operators.In<CqlDateTime>(m_, n_, "day");

                CqlBoolean p_() {
                    FhirDateTime s_ = ECGLabTest?.AuthoredOnElement;
                    CqlDateTime t_ = context.Operators.Convert<CqlDateTime>(s_);
                    CqlInterval<CqlDateTime> u_ = this.Measurement_Period(context);
                    CqlBoolean v_ = context.Operators.In<CqlDateTime>(t_, u_, "day");
                    return v_;
                }


                CqlBoolean q_() {
                    Code<RequestIntent> w_ = WeeksRescreen?.IntentElement;
                    RequestIntent? x_ = w_?.Value;
                    Code<RequestIntent> y_ = context.Operators.Convert<Code<RequestIntent>>(x_);
                    string z_ = context.Operators.Convert<string>(y_);
                    string[] aa_ = [
                        "order",
                        "original-order",
                        "reflex-order",
                        "filler-order",
                        "instance-order",
                    ];
                    CqlBoolean ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
                    return ab_;
                }


                CqlBoolean r_() {
                    Code<RequestIntent> ac_ = ECGLabTest?.IntentElement;
                    RequestIntent? ad_ = ac_?.Value;
                    Code<RequestIntent> ae_ = context.Operators.Convert<Code<RequestIntent>>(ad_);
                    string af_ = context.Operators.Convert<string>(ae_);
                    string[] ag_ = [
                        "order",
                        "original-order",
                        "reflex-order",
                        "filler-order",
                        "instance-order",
                    ];
                    CqlBoolean ah_ = context.Operators.In<string>(af_, (IEnumerable<string>)ag_);
                    return ah_;
                }

                return o_
                    /* CQL 'and' (124:19-125:70) */ && p_()
                    /* CQL 'and' (124:19-126:117) */ && q_()
                    /* CQL 'and' (124:19-127:114) */ && r_();
            }

            CqlBoolean k_ = context.Operators.WhereAny<ServiceRequest>(i_, j_);
            return k_;
        }

        IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);

        bool? e_(ServiceRequest WeeksRescreen) {
            IEnumerable<ServiceRequest> ai_ = this.NonPharmacological_Interventions(context);

            bool? aj_(ServiceRequest HTNInterventions) {
                FhirDateTime al_ = HTNInterventions?.AuthoredOnElement;
                CqlDateTime am_ = context.Operators.Convert<CqlDateTime>(al_);
                CqlInterval<CqlDateTime> an_ = this.Measurement_Period(context);
                CqlBoolean ao_ = context.Operators.In<CqlDateTime>(am_, an_, "day");
                return ao_;
            }

            CqlBoolean ak_ = context.Operators.WhereAny<ServiceRequest>(ai_, aj_);
            return ak_;
        }

        IEnumerable<ServiceRequest> f_ = context.Operators.Where<ServiceRequest>(d_, e_);

        bool? g_(ServiceRequest WeeksRescreen) {
            IEnumerable<MedicationRequest> ap_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? aq_(MedicationRequest MR) {
                IEnumerable<Medication> ax_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? ay_(Medication M) {
                    object ba_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object bb_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> bc_ = context.Operators.Split((string)bb_, "/");
                    string bd_ = context.Operators.Last<string>(bc_);
                    CqlBoolean be_ = context.Operators.Equal(ba_, bd_);

                    CqlBoolean bf_() {
                        CodeableConcept bg_ = M?.Code;
                        CqlConcept bh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bg_);
                        CqlValueSet bi_ = this.Pharmacologic_Therapy_for_Hypertension(context);
                        CqlBoolean bj_ = context.Operators.ConceptInValueSet(bh_, bi_);
                        return bj_;
                    }

                    return be_
                        /* CQL 'and' */ && bf_();
                }

                CqlBoolean az_ = context.Operators.WhereAny<Medication>(ax_, ay_);
                return az_;
            }

            IEnumerable<MedicationRequest> ar_ = context.Operators.Where<MedicationRequest>(ap_, aq_);
            CqlValueSet as_ = this.Pharmacologic_Therapy_for_Hypertension(context);
            IEnumerable<MedicationRequest> at_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, as_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> au_ = context.Operators.Union<MedicationRequest>(ar_, at_);

            bool? av_(MedicationRequest Medications) {
                FhirDateTime bk_ = Medications?.AuthoredOnElement;
                CqlDateTime bl_ = context.Operators.Convert<CqlDateTime>(bk_);
                CqlInterval<CqlDateTime> bm_ = this.Measurement_Period(context);
                CqlBoolean bn_ = context.Operators.In<CqlDateTime>(bl_, bm_, "day");

                CqlBoolean bo_() {
                    Code<MedicationRequest.MedicationrequestStatus> bp_ = Medications?.StatusElement;
                    MedicationRequest.MedicationrequestStatus? bq_ = bp_?.Value;
                    string br_ = context.Operators.Convert<string>(bq_);
                    string[] bs_ = [
                        "active",
                        "completed",
                    ];
                    CqlBoolean bt_ = context.Operators.In<string>(br_, (IEnumerable<string>)bs_);
                    return bt_;
                }

                return bn_
                    /* CQL 'and' (131:19-132:61) */ && bo_();
            }

            CqlBoolean aw_ = context.Operators.WhereAny<MedicationRequest>(au_, av_);
            return aw_;
        }

        IEnumerable<ServiceRequest> h_ = context.Operators.Where<ServiceRequest>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Encounter with Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 and Interventions")]
    public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_and_Interventions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_and_Interventions, Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_and_Interventions_Compute);

    private const long _cacheIndex_Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_and_Interventions = -5081003607919568601L;

    private IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_and_Interventions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90(context);

        bool? b_(Encounter SecondHTNEncounterReading140Over90) {
            IEnumerable<ServiceRequest> g_ = this.Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions(context);

            bool? h_(ServiceRequest SecondHTN140Over90Interventions) {
                FhirDateTime j_ = SecondHTN140Over90Interventions?.AuthoredOnElement;
                CqlDateTime k_ = context.Operators.Convert<CqlDateTime>(j_);
                Period l_ = SecondHTNEncounterReading140Over90?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                CqlBoolean n_ = context.Operators.In<CqlDateTime>(k_, m_, "day");
                return n_;
            }

            CqlBoolean i_ = context.Operators.WhereAny<ServiceRequest>(g_, h_);
            return i_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter SecondHTNEncounterReading140Over90) {
            IEnumerable<ServiceRequest> o_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(context);

            bool? p_(ServiceRequest ReferralToProfessional) {
                FhirDateTime r_ = ReferralToProfessional?.AuthoredOnElement;
                CqlDateTime s_ = context.Operators.Convert<CqlDateTime>(r_);
                Period t_ = SecondHTNEncounterReading140Over90?.Period;
                CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
                CqlBoolean v_ = context.Operators.In<CqlDateTime>(s_, u_, "day");
                return v_;
            }

            CqlBoolean q_ = context.Operators.WhereAny<ServiceRequest>(o_, p_);
            return q_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(a_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(c_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -4244956736763244578L;

    private IEnumerable<Encounter> Numerator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Normal_Blood_Pressure_Reading(context);
        IEnumerable<Encounter> b_ = this.Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_and_Interventions(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_and_Interventions(context);
        IEnumerable<Encounter> e_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions(context);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(d_, e_);
        IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);
        IEnumerable<Encounter> h_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_and_Interventions(context);
        IEnumerable<Encounter> i_ = context.Operators.Union<Encounter>(g_, h_);
        return i_;
    }


    [CqlExpressionDefinition("Encounter with Medical Reason for Not Obtaining or Patient Declined Blood Pressure Measurement")]
    public IEnumerable<Encounter> Encounter_with_Medical_Reason_for_Not_Obtaining_or_Patient_Declined_Blood_Pressure_Measurement(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_with_Medical_Reason_for_Not_Obtaining_or_Patient_Declined_Blood_Pressure_Measurement, Encounter_with_Medical_Reason_for_Not_Obtaining_or_Patient_Declined_Blood_Pressure_Measurement_Compute);

    private const long _cacheIndex_Encounter_with_Medical_Reason_for_Not_Obtaining_or_Patient_Declined_Blood_Pressure_Measurement = -4063250941269070627L;

    private IEnumerable<Encounter> Encounter_with_Medical_Reason_for_Not_Obtaining_or_Patient_Declined_Blood_Pressure_Measurement_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Measurement_Period(context);

        bool? b_(Encounter QualifyingEncounter) {
            CqlCode d_ = this.Blood_pressure_panel_with_all_children_optional(context);
            IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
            IEnumerable<Observation> f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationcancelled"));
            CqlCode g_ = this.Systolic_blood_pressure(context);
            IEnumerable<CqlCode> h_ = context.Operators.ToList<CqlCode>(g_);
            IEnumerable<Observation> i_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, h_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationcancelled"));
            IEnumerable<Observation> j_ = context.Operators.Union<Observation>(f_, i_);
            CqlCode k_ = this.Diastolic_blood_pressure(context);
            IEnumerable<CqlCode> l_ = context.Operators.ToList<CqlCode>(k_);
            IEnumerable<Observation> m_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, l_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationcancelled"));
            IEnumerable<Observation> n_ = context.Operators.Union<Observation>(j_, m_);

            bool? o_(Observation NoBPScreen) {
                Instant q_ = NoBPScreen?.IssuedElement;
                DateTimeOffset? r_ = q_?.Value;
                CqlDateTime s_ = context.Operators.Convert<CqlDateTime>(r_);
                Period t_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
                CqlBoolean v_ = context.Operators.In<CqlDateTime>(s_, u_, "day");

                CqlBoolean w_() {

                    bool? x_(Extension @this) {
                        FhirUri af_ = @this?.UrlElement;
                        string ag_ = FHIRHelpers_4_4_000.Instance.ToString(context, af_);
                        CqlBoolean ah_ = context.Operators.Equal(ag_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                        return ah_;
                    }


                    object y_(Extension @this) {
                        DataType ai_ = @this?.Value;
                        return ai_;
                    }

                    IEnumerable<object> z_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(NoBPScreen is DomainResource
                        ? (NoBPScreen as DomainResource).Extension
                        : default), x_, y_);
                    object aa_ = context.Operators.SingletonFrom<object>(z_);
                    CqlConcept ab_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aa_ as CodeableConcept);
                    CqlValueSet ac_ = this.Patient_Declined(context);
                    CqlBoolean ad_ = context.Operators.ConceptInValueSet(ab_, ac_);

                    CqlBoolean ae_() {

                        bool? aj_(Extension @this) {
                            FhirUri aq_ = @this?.UrlElement;
                            string ar_ = FHIRHelpers_4_4_000.Instance.ToString(context, aq_);
                            CqlBoolean as_ = context.Operators.Equal(ar_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                            return as_;
                        }


                        object ak_(Extension @this) {
                            DataType at_ = @this?.Value;
                            return at_;
                        }

                        IEnumerable<object> al_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(NoBPScreen is DomainResource
                            ? (NoBPScreen as DomainResource).Extension
                            : default), aj_, ak_);
                        object am_ = context.Operators.SingletonFrom<object>(al_);
                        CqlConcept an_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, am_ as CodeableConcept);
                        CqlValueSet ao_ = this.Medical_Reason(context);
                        CqlBoolean ap_ = context.Operators.ConceptInValueSet(an_, ao_);
                        return ap_;
                    }

                    return ad_
                        /* CQL 'or' (324:13-326:9) */ || ae_();
                }

                return v_
                    /* CQL 'and' (323:17-326:9) */ && w_();
            }

            CqlBoolean p_ = context.Operators.WhereAny<Observation>(n_, o_);
            return p_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("NonPharmacological Intervention Not Ordered")]
    public IEnumerable<ServiceRequest> NonPharmacological_Intervention_Not_Ordered(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NonPharmacological_Intervention_Not_Ordered, NonPharmacological_Intervention_Not_Ordered_Compute);

    private const long _cacheIndex_NonPharmacological_Intervention_Not_Ordered = 4934381066235649525L;

    private IEnumerable<ServiceRequest> NonPharmacological_Intervention_Not_Ordered_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Lifestyle_Recommendation(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> c_ = context.Operators.Union<ServiceRequest>(b_, b_);
        CqlValueSet d_ = this.Weight_Reduction_Recommended(context);
        IEnumerable<ServiceRequest> e_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> f_ = context.Operators.Union<ServiceRequest>(e_, e_);
        IEnumerable<ServiceRequest> g_ = context.Operators.Union<ServiceRequest>(c_, f_);
        CqlValueSet h_ = this.Dietary_Recommendations(context);
        IEnumerable<ServiceRequest> i_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> j_ = context.Operators.Union<ServiceRequest>(i_, i_);
        IEnumerable<ServiceRequest> k_ = context.Operators.Union<ServiceRequest>(g_, j_);
        CqlValueSet l_ = this.Recommendation_to_Increase_Physical_Activity(context);
        IEnumerable<ServiceRequest> m_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> n_ = context.Operators.Union<ServiceRequest>(m_, m_);
        IEnumerable<ServiceRequest> o_ = context.Operators.Union<ServiceRequest>(k_, n_);
        CqlValueSet p_ = this.Referral_or_Counseling_for_Alcohol_Consumption(context);
        IEnumerable<ServiceRequest> q_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> r_ = context.Operators.Union<ServiceRequest>(q_, q_);
        IEnumerable<ServiceRequest> s_ = context.Operators.Union<ServiceRequest>(o_, r_);

        bool? t_(ServiceRequest NonPharmIntervention) {
            Code<RequestStatus> v_ = NonPharmIntervention?.StatusElement;
            RequestStatus? w_ = v_?.Value;
            Code<RequestStatus> x_ = context.Operators.Convert<Code<RequestStatus>>(w_);
            string y_ = context.Operators.Convert<string>(x_);
            string[] z_ = [
                "active",
                "completed",
                "on-hold",
            ];
            CqlBoolean aa_ = context.Operators.In<string>(y_, (IEnumerable<string>)z_);

            CqlBoolean ab_() {

                bool? ac_(Extension @this) {
                    FhirUri aj_ = @this?.UrlElement;
                    string ak_ = FHIRHelpers_4_4_000.Instance.ToString(context, aj_);
                    CqlBoolean al_ = context.Operators.Equal(ak_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                    return al_;
                }


                object ad_(Extension @this) {
                    DataType am_ = @this?.Value;
                    return am_;
                }

                IEnumerable<object> ae_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(NonPharmIntervention is DomainResource
                    ? (NonPharmIntervention as DomainResource).Extension
                    : default), ac_, ad_);
                object af_ = context.Operators.SingletonFrom<object>(ae_);
                CqlConcept ag_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, af_ as CodeableConcept);
                CqlValueSet ah_ = this.Patient_Declined(context);
                CqlBoolean ai_ = context.Operators.ConceptInValueSet(ag_, ah_);
                return ai_;
            }

            return aa_
                /* CQL 'and' (315:5-316:66) */ && ab_();
        }

        IEnumerable<ServiceRequest> u_ = context.Operators.Where<ServiceRequest>(s_, t_);
        return u_;
    }


    [CqlExpressionDefinition("Laboratory Test or ECG for Hypertension Not Ordered")]
    public IEnumerable<ServiceRequest> Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered, Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered_Compute);

    private const long _cacheIndex_Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered = 3750817146901417937L;

    private IEnumerable<ServiceRequest> Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered_Compute(CqlContext context)
    {
        CqlCode a_ = this._12_lead_EKG_panel(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<ServiceRequest> c_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        CqlCode d_ = this.EKG_study(context);
        IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
        IEnumerable<ServiceRequest> f_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> g_ = context.Operators.Union<ServiceRequest>(c_, f_);
        CqlValueSet h_ = this.Laboratory_Tests_for_Hypertension(context);
        IEnumerable<ServiceRequest> i_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> j_ = context.Operators.Union<ServiceRequest>(i_, i_);
        IEnumerable<ServiceRequest> k_ = context.Operators.Union<ServiceRequest>(g_, j_);

        bool? l_(ServiceRequest LabECGNotDone) {
            Code<RequestStatus> n_ = LabECGNotDone?.StatusElement;
            RequestStatus? o_ = n_?.Value;
            Code<RequestStatus> p_ = context.Operators.Convert<Code<RequestStatus>>(o_);
            string q_ = context.Operators.Convert<string>(p_);
            string[] r_ = [
                "active",
                "completed",
                "on-hold",
            ];
            CqlBoolean s_ = context.Operators.In<string>(q_, (IEnumerable<string>)r_);

            CqlBoolean t_() {

                bool? u_(Extension @this) {
                    FhirUri ab_ = @this?.UrlElement;
                    string ac_ = FHIRHelpers_4_4_000.Instance.ToString(context, ab_);
                    CqlBoolean ad_ = context.Operators.Equal(ac_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                    return ad_;
                }


                object v_(Extension @this) {
                    DataType ae_ = @this?.Value;
                    return ae_;
                }

                IEnumerable<object> w_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(LabECGNotDone is DomainResource
                    ? (LabECGNotDone as DomainResource).Extension
                    : default), u_, v_);
                object x_ = context.Operators.SingletonFrom<object>(w_);
                CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_ as CodeableConcept);
                CqlValueSet z_ = this.Patient_Declined(context);
                CqlBoolean aa_ = context.Operators.ConceptInValueSet(y_, z_);
                return aa_;
            }

            return s_
                /* CQL 'and' (387:5-388:59) */ && t_();
        }

        IEnumerable<ServiceRequest> m_ = context.Operators.Where<ServiceRequest>(k_, l_);
        return m_;
    }


    [CqlExpressionDefinition("Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 Interventions Declined")]
    public IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined, Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined_Compute);

    private const long _cacheIndex_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined = -361062810499215070L;

    private IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> c_ = context.Operators.Union<ServiceRequest>(b_, b_);
        CqlValueSet d_ = this.Follow_Up_Within_6_Months(context);
        IEnumerable<ServiceRequest> e_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> f_ = context.Operators.Union<ServiceRequest>(e_, e_);
        IEnumerable<ServiceRequest> g_ = context.Operators.Union<ServiceRequest>(c_, f_);

        bool? h_(ServiceRequest SecondHTNDeclinedReferralAndFollowUp) {
            Code<RequestStatus> n_ = SecondHTNDeclinedReferralAndFollowUp?.StatusElement;
            RequestStatus? o_ = n_?.Value;
            Code<RequestStatus> p_ = context.Operators.Convert<Code<RequestStatus>>(o_);
            string q_ = context.Operators.Convert<string>(p_);
            string[] r_ = [
                "active",
                "completed",
                "on-hold",
            ];
            CqlBoolean s_ = context.Operators.In<string>(q_, (IEnumerable<string>)r_);

            CqlBoolean t_() {

                bool? u_(Extension @this) {
                    FhirUri ab_ = @this?.UrlElement;
                    string ac_ = FHIRHelpers_4_4_000.Instance.ToString(context, ab_);
                    CqlBoolean ad_ = context.Operators.Equal(ac_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                    return ad_;
                }


                object v_(Extension @this) {
                    DataType ae_ = @this?.Value;
                    return ae_;
                }

                IEnumerable<object> w_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(SecondHTNDeclinedReferralAndFollowUp is DomainResource
                    ? (SecondHTNDeclinedReferralAndFollowUp as DomainResource).Extension
                    : default), u_, v_);
                object x_ = context.Operators.SingletonFrom<object>(w_);
                CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_ as CodeableConcept);
                CqlValueSet z_ = this.Patient_Declined(context);
                CqlBoolean aa_ = context.Operators.ConceptInValueSet(y_, z_);
                return aa_;
            }

            return s_
                /* CQL 'and' (364:7-365:84) */ && t_();
        }

        IEnumerable<ServiceRequest> i_ = context.Operators.Where<ServiceRequest>(g_, h_);
        IEnumerable<ServiceRequest> j_ = this.Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered(context);
        IEnumerable<ServiceRequest> k_ = context.Operators.Union<ServiceRequest>(i_, j_);
        IEnumerable<ServiceRequest> l_ = this.NonPharmacological_Intervention_Not_Ordered(context);
        IEnumerable<ServiceRequest> m_ = context.Operators.Union<ServiceRequest>(k_, l_);
        return m_;
    }


    [CqlExpressionDefinition("Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 Interventions Declined")]
    public IEnumerable<object> Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined, Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined_Compute);

    private const long _cacheIndex_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined = -3769384087218300315L;

    private IEnumerable<object> Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> c_ = context.Operators.Union<ServiceRequest>(b_, b_);
        CqlValueSet d_ = this.Follow_Up_Within_4_Weeks(context);
        IEnumerable<ServiceRequest> e_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> f_ = context.Operators.Union<ServiceRequest>(e_, e_);
        IEnumerable<ServiceRequest> g_ = context.Operators.Union<ServiceRequest>(c_, f_);

        bool? h_(ServiceRequest SecondHTN140Over90ReferralFollowUpNotDone) {
            Code<RequestStatus> t_ = SecondHTN140Over90ReferralFollowUpNotDone?.StatusElement;
            RequestStatus? u_ = t_?.Value;
            Code<RequestStatus> v_ = context.Operators.Convert<Code<RequestStatus>>(u_);
            string w_ = context.Operators.Convert<string>(v_);
            string[] x_ = [
                "active",
                "completed",
                "on-hold",
            ];
            CqlBoolean y_ = context.Operators.In<string>(w_, (IEnumerable<string>)x_);

            CqlBoolean z_() {

                bool? aa_(Extension @this) {
                    FhirUri ah_ = @this?.UrlElement;
                    string ai_ = FHIRHelpers_4_4_000.Instance.ToString(context, ah_);
                    CqlBoolean aj_ = context.Operators.Equal(ai_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                    return aj_;
                }


                object ab_(Extension @this) {
                    DataType ak_ = @this?.Value;
                    return ak_;
                }

                IEnumerable<object> ac_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(SecondHTN140Over90ReferralFollowUpNotDone is DomainResource
                    ? (SecondHTN140Over90ReferralFollowUpNotDone as DomainResource).Extension
                    : default), aa_, ab_);
                object ad_ = context.Operators.SingletonFrom<object>(ac_);
                CqlConcept ae_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ad_ as CodeableConcept);
                CqlValueSet af_ = this.Patient_Declined(context);
                CqlBoolean ag_ = context.Operators.ConceptInValueSet(ae_, af_);
                return ag_;
            }

            return y_
                /* CQL 'and' (373:9-374:91) */ && z_();
        }

        IEnumerable<ServiceRequest> i_ = context.Operators.Where<ServiceRequest>(g_, h_);
        CqlValueSet j_ = this.Pharmacologic_Therapy_for_Hypertension(context);
        IEnumerable<MedicationRequest> k_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(k_, k_);

        bool? m_(MedicationRequest MedicationRequestNotOrdered) {
            Code<MedicationRequest.MedicationrequestStatus> al_ = MedicationRequestNotOrdered?.StatusElement;
            MedicationRequest.MedicationrequestStatus? am_ = al_?.Value;
            string an_ = context.Operators.Convert<string>(am_);
            string[] ao_ = [
                "active",
                "completed",
            ];
            CqlBoolean ap_ = context.Operators.In<string>(an_, (IEnumerable<string>)ao_);
            return ap_;
        }

        IEnumerable<MedicationRequest> n_ = context.Operators.Where<MedicationRequest>(l_, m_);
        IEnumerable<object> o_ = context.Operators.Union<object>(i_ as IEnumerable<object>, n_ as IEnumerable<object>);
        IEnumerable<ServiceRequest> p_ = this.Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered(context);
        IEnumerable<object> q_ = context.Operators.Union<object>(o_ as IEnumerable<object>, p_ as IEnumerable<object>);
        IEnumerable<ServiceRequest> r_ = this.NonPharmacological_Intervention_Not_Ordered(context);
        IEnumerable<object> s_ = context.Operators.Union<object>(q_ as IEnumerable<object>, r_ as IEnumerable<object>);
        return s_;
    }


    [CqlExpressionDefinition("Encounter with Order for Hypertension Follow Up Declined by Patient")]
    public IEnumerable<Encounter> Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient, Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient_Compute);

    private const long _cacheIndex_Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient = 4380464251877560299L;

    private IEnumerable<Encounter> Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80(context);

        bool? b_(Encounter ElevatedBPEncounter) {
            CqlValueSet v_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
            IEnumerable<ServiceRequest> w_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> x_ = context.Operators.Union<ServiceRequest>(w_, w_);
            CqlValueSet y_ = this.Follow_Up_Within_6_Months(context);
            IEnumerable<ServiceRequest> z_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> aa_ = context.Operators.Union<ServiceRequest>(z_, z_);
            IEnumerable<ServiceRequest> ab_ = context.Operators.Union<ServiceRequest>(x_, aa_);

            bool? ac_(ServiceRequest ElevatedBPDeclinedInterventions) {
                FhirDateTime ae_ = ElevatedBPDeclinedInterventions?.AuthoredOnElement;
                CqlDateTime af_ = context.Operators.Convert<CqlDateTime>(ae_);
                Period ag_ = ElevatedBPEncounter?.Period;
                CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
                CqlBoolean ai_ = context.Operators.In<CqlDateTime>(af_, ah_, "day");

                CqlBoolean aj_() {
                    Code<RequestStatus> al_ = ElevatedBPDeclinedInterventions?.StatusElement;
                    RequestStatus? am_ = al_?.Value;
                    Code<RequestStatus> an_ = context.Operators.Convert<Code<RequestStatus>>(am_);
                    string ao_ = context.Operators.Convert<string>(an_);
                    string[] ap_ = [
                        "active",
                        "completed",
                        "on-hold",
                    ];
                    CqlBoolean aq_ = context.Operators.In<string>(ao_, (IEnumerable<string>)ap_);
                    return aq_;
                }


                CqlBoolean ak_() {

                    bool? ar_(Extension @this) {
                        FhirUri ay_ = @this?.UrlElement;
                        string az_ = FHIRHelpers_4_4_000.Instance.ToString(context, ay_);
                        CqlBoolean ba_ = context.Operators.Equal(az_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                        return ba_;
                    }


                    object as_(Extension @this) {
                        DataType bb_ = @this?.Value;
                        return bb_;
                    }

                    IEnumerable<object> at_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(ElevatedBPDeclinedInterventions is DomainResource
                        ? (ElevatedBPDeclinedInterventions as DomainResource).Extension
                        : default), ar_, as_);
                    object au_ = context.Operators.SingletonFrom<object>(at_);
                    CqlConcept av_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, au_ as CodeableConcept);
                    CqlValueSet aw_ = this.Patient_Declined(context);
                    CqlBoolean ax_ = context.Operators.ConceptInValueSet(av_, aw_);
                    return ax_;
                }

                return ai_
                    /* CQL 'and' (332:21-333:94) */ && aj_()
                    /* CQL 'and' (332:21-334:83) */ && ak_();
            }

            CqlBoolean ad_ = context.Operators.WhereAny<ServiceRequest>(ab_, ac_);
            return ad_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter ElevatedBPEncounter) {
            IEnumerable<ServiceRequest> bc_ = this.NonPharmacological_Intervention_Not_Ordered(context);

            bool? bd_(ServiceRequest NotOrdered) {
                FhirDateTime bf_ = NotOrdered?.AuthoredOnElement;
                CqlDateTime bg_ = context.Operators.Convert<CqlDateTime>(bf_);
                Period bh_ = ElevatedBPEncounter?.Period;
                CqlInterval<CqlDateTime> bi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bh_);
                CqlBoolean bj_ = context.Operators.In<CqlDateTime>(bg_, bi_, "day");
                return bj_;
            }

            CqlBoolean be_ = context.Operators.WhereAny<ServiceRequest>(bc_, bd_);
            return be_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(a_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(c_, e_);
        IEnumerable<Encounter> g_ = this.Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80(context);

        bool? h_(Encounter FirstHTNEncounter) {
            CqlValueSet bk_ = this.Follow_Up_Within_4_Weeks(context);
            IEnumerable<ServiceRequest> bl_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, bk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> bm_ = context.Operators.Union<ServiceRequest>(bl_, bl_);
            CqlValueSet bn_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
            IEnumerable<ServiceRequest> bo_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, bn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> bp_ = context.Operators.Union<ServiceRequest>(bo_, bo_);
            IEnumerable<ServiceRequest> bq_ = context.Operators.Union<ServiceRequest>(bm_, bp_);

            bool? br_(ServiceRequest FirstHTNDeclinedInterventions) {
                FhirDateTime bt_ = FirstHTNDeclinedInterventions?.AuthoredOnElement;
                CqlDateTime bu_ = context.Operators.Convert<CqlDateTime>(bt_);
                Period bv_ = FirstHTNEncounter?.Period;
                CqlInterval<CqlDateTime> bw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bv_);
                CqlBoolean bx_ = context.Operators.In<CqlDateTime>(bu_, bw_, "day");

                CqlBoolean by_() {
                    Code<RequestStatus> ca_ = FirstHTNDeclinedInterventions?.StatusElement;
                    RequestStatus? cb_ = ca_?.Value;
                    Code<RequestStatus> cc_ = context.Operators.Convert<Code<RequestStatus>>(cb_);
                    string cd_ = context.Operators.Convert<string>(cc_);
                    string[] ce_ = [
                        "active",
                        "completed",
                        "on-hold",
                    ];
                    CqlBoolean cf_ = context.Operators.In<string>(cd_, (IEnumerable<string>)ce_);
                    return cf_;
                }


                CqlBoolean bz_() {

                    bool? cg_(Extension @this) {
                        FhirUri cn_ = @this?.UrlElement;
                        string co_ = FHIRHelpers_4_4_000.Instance.ToString(context, cn_);
                        CqlBoolean cp_ = context.Operators.Equal(co_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                        return cp_;
                    }


                    object ch_(Extension @this) {
                        DataType cq_ = @this?.Value;
                        return cq_;
                    }

                    IEnumerable<object> ci_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(FirstHTNDeclinedInterventions is DomainResource
                        ? (FirstHTNDeclinedInterventions as DomainResource).Extension
                        : default), cg_, ch_);
                    object cj_ = context.Operators.SingletonFrom<object>(ci_);
                    CqlConcept ck_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cj_ as CodeableConcept);
                    CqlValueSet cl_ = this.Patient_Declined(context);
                    CqlBoolean cm_ = context.Operators.ConceptInValueSet(ck_, cl_);
                    return cm_;
                }

                return bx_
                    /* CQL 'and' (343:23-344:94) */ && by_()
                    /* CQL 'and' (343:23-345:83) */ && bz_();
            }

            CqlBoolean bs_ = context.Operators.WhereAny<ServiceRequest>(bq_, br_);
            return bs_;
        }

        IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);

        bool? j_(Encounter FirstHTNEncounter) {
            IEnumerable<ServiceRequest> cr_ = this.NonPharmacological_Intervention_Not_Ordered(context);

            bool? cs_(ServiceRequest NoNonPharm) {
                FhirDateTime cu_ = NoNonPharm?.AuthoredOnElement;
                CqlDateTime cv_ = context.Operators.Convert<CqlDateTime>(cu_);
                Period cw_ = FirstHTNEncounter?.Period;
                CqlInterval<CqlDateTime> cx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cw_);
                CqlBoolean cy_ = context.Operators.In<CqlDateTime>(cv_, cx_, "day");
                return cy_;
            }

            CqlBoolean ct_ = context.Operators.WhereAny<ServiceRequest>(cr_, cs_);
            return ct_;
        }

        IEnumerable<Encounter> k_ = context.Operators.Where<Encounter>(g_, j_);
        IEnumerable<Encounter> l_ = context.Operators.Union<Encounter>(i_, k_);
        IEnumerable<Encounter> m_ = context.Operators.Union<Encounter>(f_, l_);
        IEnumerable<Encounter> n_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89(context);

        bool? o_(Encounter SecondHTNEncounter) {
            IEnumerable<ServiceRequest> cz_ = this.Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined(context);

            bool? da_(ServiceRequest SecondHTNDeclinedInterventions) {
                FhirDateTime dc_ = SecondHTNDeclinedInterventions?.AuthoredOnElement;
                CqlDateTime dd_ = context.Operators.Convert<CqlDateTime>(dc_);
                Period de_ = SecondHTNEncounter?.Period;
                CqlInterval<CqlDateTime> df_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, de_);
                CqlBoolean dg_ = context.Operators.In<CqlDateTime>(dd_, df_, "day");
                return dg_;
            }

            CqlBoolean db_ = context.Operators.WhereAny<ServiceRequest>(cz_, da_);
            return db_;
        }

        IEnumerable<Encounter> p_ = context.Operators.Where<Encounter>(n_, o_);
        IEnumerable<Encounter> q_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90(context);

        bool? r_(Encounter SecondHTN140Over90Encounter) {
            IEnumerable<object> dh_ = this.Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined(context);

            bool? di_(object SecondHTN140Over90DeclinedInterventions) {
                object dk_ = context.Operators.LateBoundProperty<object>(SecondHTN140Over90DeclinedInterventions, "authoredOn");
                CqlDateTime dl_ = context.Operators.LateBoundProperty<CqlDateTime>(dk_, "value");
                Period dm_ = SecondHTN140Over90Encounter?.Period;
                CqlInterval<CqlDateTime> dn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dm_);
                CqlBoolean do_ = context.Operators.In<CqlDateTime>(dl_, dn_, "day");
                return do_;
            }

            CqlBoolean dj_ = context.Operators.WhereAny<object>(dh_, di_);
            return dj_;
        }

        IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);
        IEnumerable<Encounter> t_ = context.Operators.Union<Encounter>(p_, s_);
        IEnumerable<Encounter> u_ = context.Operators.Union<Encounter>(m_, t_);
        return u_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exceptions, Denominator_Exceptions_Compute);

    private const long _cacheIndex_Denominator_Exceptions = -8874499887259637803L;

    private IEnumerable<Encounter> Denominator_Exceptions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Medical_Reason_for_Not_Obtaining_or_Patient_Declined_Blood_Pressure_Measurement(context);
        IEnumerable<Encounter> b_ = this.Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 1992829834485047426L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 4914906704581305508L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 3333275587893479696L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 1375056595253438726L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS22FHIRPCSBPScreeningFollowUp_1_0_000() {}

    public static CMS22FHIRPCSBPScreeningFollowUp_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS22FHIRPCSBPScreeningFollowUp";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

}
