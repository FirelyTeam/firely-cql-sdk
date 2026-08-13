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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.2.2.0")]
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
            bool? i_ = context.Operators.In<CqlDateTime>(g_, h_, "day");
            bool? j_;
            // CQL 'and' (145:11-146:44): right operand skipped when left is false
            if (i_ is false)
            {
                j_ = false;
            }
            else
            {
                Code<Encounter.EncounterStatus> k_ = ValidEncounter?.StatusElement;
                Encounter.EncounterStatus? l_ = k_?.Value;
                Code<Encounter.EncounterStatus> m_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(l_);
                bool? n_ = context.Operators.Equivalent(m_, "finished");
                j_ = i_ & n_;
            }
            // CQL 'and' (145:5-147:43): right operand skipped when left is false
            if (j_ is false)
            {
                return false;
            }
            else
            {
                Coding o_ = ValidEncounter?.Class;
                CqlCode p_ = FHIRHelpers_4_4_000.Instance.ToCode(context, o_);
                CqlCode q_ = this.@virtual(context);
                bool? r_ = context.Operators.Equivalent(p_, q_);
                return j_ & !r_;
            }
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
            bool? l_ = context.Operators.GreaterOrEqual(k_, 18);
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
        CqlCode c_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept d_ = context.Operators.ConvertCodeToConcept(c_);
        bool? e_ = context.Operators.Equivalent(b_, d_);
        bool? f_;
        // CQL 'or' (408:54-409:66): right operand skipped when left is true
        if (e_ is true)
        {
            f_ = true;
        }
        else
        {
            CodeableConcept j_ = condition?.VerificationStatus;
            CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
            CqlCode l_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
            CqlConcept m_ = context.Operators.ConvertCodeToConcept(l_);
            bool? n_ = context.Operators.Equivalent(k_, m_);
            f_ = e_ | n_;
        }
        bool? g_;
        // CQL 'or' (408:54-410:66): right operand skipped when left is true
        if (f_ is true)
        {
            g_ = true;
        }
        else
        {
            CodeableConcept o_ = condition?.VerificationStatus;
            CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, o_);
            CqlCode q_ = QICoreCommon_4_0_000.Instance.provisional(context);
            CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
            bool? s_ = context.Operators.Equivalent(p_, r_);
            g_ = f_ | s_;
        }
        bool? h_;
        // CQL 'or' (408:52-412:3): right operand skipped when left is true
        if (g_ is true)
        {
            h_ = true;
        }
        else
        {
            CodeableConcept t_ = condition?.VerificationStatus;
            CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
            CqlCode v_ = QICoreCommon_4_0_000.Instance.differential(context);
            CqlConcept w_ = context.Operators.ConvertCodeToConcept(v_);
            bool? x_ = context.Operators.Equivalent(u_, w_);
            h_ = g_ | x_;
        }
        bool? i_ = context.Operators.Implies(!((bool?)(b_ is null)), h_);
        return i_;
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
                    CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, Hypertension as Condition);
                    CqlDateTime o_ = context.Operators.Start(n_);
                    CqlInterval<CqlDateTime> p_ = context.Operators.Interval(o_, o_, true, true);
                    h_ = p_;
                }
                Period i_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                bool? k_ = context.Operators.SameOrBefore(h_, j_, "day");
                // CQL 'and' (51:17-52:39): right operand skipped when left is false
                if (k_ is false)
                {
                    return false;
                }
                else
                {
                    bool? q_ = this.isVerified(context, Hypertension as Condition);
                    return k_ & q_;
                }
            }

            bool? g_ = context.Operators.WhereAny<Condition>(e_, f_);
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
                DataType t_ = BloodPressure?.Effective;
                object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.toInterval(context, u_);
                CqlDateTime w_ = context.Operators.End(v_);
                Period x_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, x_);
                bool? z_ = context.Operators.In<CqlDateTime>(w_, y_, "day");
                // CQL 'and' (164:9-165:73): right operand skipped when left is false
                if (z_ is false)
                {
                    return false;
                }
                else
                {
                    Code<ObservationStatus> aa_ = BloodPressure?.StatusElement;
                    ObservationStatus? ab_ = aa_?.Value;
                    string ac_ = context.Operators.Convert<string>(ab_);
                    string[] ad_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? ae_ = context.Operators.In<string>(ac_, (IEnumerable<string>)ad_);
                    return z_ & ae_;
                }
            }

            IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);

            object g_(Observation @this) {
                DataType af_ = @this?.Effective;
                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_);
                CqlDateTime ai_ = context.Operators.Start(ah_);
                return ai_;
            }

            IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
            Observation i_ = context.Operators.Last<Observation>(h_);
            List<Observation.ComponentComponent> j_ = i_?.Component;

            bool? k_(Observation.ComponentComponent C) {
                CodeableConcept aj_ = C?.Code;
                CqlConcept ak_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aj_);
                CqlCode al_ = this.Systolic_blood_pressure(context);
                CqlConcept am_ = context.Operators.ConvertCodeToConcept(al_);
                bool? an_ = context.Operators.Equivalent(ak_, am_);
                return an_;
            }

            IEnumerable<Observation.ComponentComponent> l_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)j_, k_);
            Observation.ComponentComponent m_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            CqlQuantity p_ = context.Operators.Quantity(1m, "mm[Hg]");
            CqlQuantity q_ = context.Operators.Quantity(120m, "mm[Hg]");
            CqlInterval<CqlQuantity> r_ = context.Operators.Interval(p_, q_, true, false);
            bool? s_ = context.Operators.In<CqlQuantity>(o_ as CqlQuantity, r_, (string)default);
            // CQL 'and' (168:5-175:51): right operand skipped when left is false
            if (s_ is false)
            {
                return false;
            }
            else
            {
                IEnumerable<Observation> ao_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

                bool? ap_(Observation BloodPressure) {
                    DataType be_ = BloodPressure?.Effective;
                    object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                    CqlInterval<CqlDateTime> bg_ = QICoreCommon_4_0_000.Instance.toInterval(context, bf_);
                    CqlDateTime bh_ = context.Operators.End(bg_);
                    Period bi_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bi_);
                    bool? bk_ = context.Operators.In<CqlDateTime>(bh_, bj_, "day");
                    // CQL 'and' (164:9-165:73): right operand skipped when left is false
                    if (bk_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Code<ObservationStatus> bl_ = BloodPressure?.StatusElement;
                        ObservationStatus? bm_ = bl_?.Value;
                        string bn_ = context.Operators.Convert<string>(bm_);
                        string[] bo_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? bp_ = context.Operators.In<string>(bn_, (IEnumerable<string>)bo_);
                        return bk_ & bp_;
                    }
                }

                IEnumerable<Observation> aq_ = context.Operators.Where<Observation>(ao_, ap_);

                object ar_(Observation @this) {
                    DataType bq_ = @this?.Effective;
                    object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                    CqlInterval<CqlDateTime> bs_ = QICoreCommon_4_0_000.Instance.toInterval(context, br_);
                    CqlDateTime bt_ = context.Operators.Start(bs_);
                    return bt_;
                }

                IEnumerable<Observation> as_ = context.Operators.SortBy<Observation>(aq_, ar_, System.ComponentModel.ListSortDirection.Ascending);
                Observation at_ = context.Operators.Last<Observation>(as_);
                List<Observation.ComponentComponent> au_ = at_?.Component;

                bool? av_(Observation.ComponentComponent C) {
                    CodeableConcept bu_ = C?.Code;
                    CqlConcept bv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bu_);
                    CqlCode bw_ = this.Diastolic_blood_pressure(context);
                    CqlConcept bx_ = context.Operators.ConvertCodeToConcept(bw_);
                    bool? by_ = context.Operators.Equivalent(bv_, bx_);
                    return by_;
                }

                IEnumerable<Observation.ComponentComponent> aw_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)au_, av_);
                Observation.ComponentComponent ax_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(aw_);
                DataType ay_ = ax_?.Value;
                object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                CqlQuantity ba_ = context.Operators.Quantity(1m, "mm[Hg]");
                CqlQuantity bb_ = context.Operators.Quantity(80m, "mm[Hg]");
                CqlInterval<CqlQuantity> bc_ = context.Operators.Interval(ba_, bb_, true, false);
                bool? bd_ = context.Operators.In<CqlQuantity>(az_ as CqlQuantity, bc_, (string)default);
                return s_ & bd_;
            }
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
                DataType t_ = BloodPressure?.Effective;
                object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.toInterval(context, u_);
                CqlDateTime w_ = context.Operators.End(v_);
                Period x_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, x_);
                bool? z_ = context.Operators.In<CqlDateTime>(w_, y_, "day");
                // CQL 'and' (180:9-181:73): right operand skipped when left is false
                if (z_ is false)
                {
                    return false;
                }
                else
                {
                    Code<ObservationStatus> aa_ = BloodPressure?.StatusElement;
                    ObservationStatus? ab_ = aa_?.Value;
                    string ac_ = context.Operators.Convert<string>(ab_);
                    string[] ad_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? ae_ = context.Operators.In<string>(ac_, (IEnumerable<string>)ad_);
                    return z_ & ae_;
                }
            }

            IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);

            object g_(Observation @this) {
                DataType af_ = @this?.Effective;
                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_);
                CqlDateTime ai_ = context.Operators.Start(ah_);
                return ai_;
            }

            IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
            Observation i_ = context.Operators.Last<Observation>(h_);
            List<Observation.ComponentComponent> j_ = i_?.Component;

            bool? k_(Observation.ComponentComponent C) {
                CodeableConcept aj_ = C?.Code;
                CqlConcept ak_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aj_);
                CqlCode al_ = this.Systolic_blood_pressure(context);
                CqlConcept am_ = context.Operators.ConvertCodeToConcept(al_);
                bool? an_ = context.Operators.Equivalent(ak_, am_);
                return an_;
            }

            IEnumerable<Observation.ComponentComponent> l_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)j_, k_);
            Observation.ComponentComponent m_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            CqlQuantity p_ = context.Operators.Quantity(120m, "mm[Hg]");
            CqlQuantity q_ = context.Operators.Quantity(129m, "mm[Hg]");
            CqlInterval<CqlQuantity> r_ = context.Operators.Interval(p_, q_, true, true);
            bool? s_ = context.Operators.In<CqlQuantity>(o_ as CqlQuantity, r_, (string)default);
            // CQL 'and' (184:5-192:5): right operand skipped when left is false
            if (s_ is false)
            {
                return false;
            }
            else
            {
                IEnumerable<Observation> ao_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

                bool? ap_(Observation BloodPressure) {
                    DataType be_ = BloodPressure?.Effective;
                    object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                    CqlInterval<CqlDateTime> bg_ = QICoreCommon_4_0_000.Instance.toInterval(context, bf_);
                    CqlDateTime bh_ = context.Operators.End(bg_);
                    Period bi_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bi_);
                    bool? bk_ = context.Operators.In<CqlDateTime>(bh_, bj_, "day");
                    // CQL 'and' (180:9-181:73): right operand skipped when left is false
                    if (bk_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Code<ObservationStatus> bl_ = BloodPressure?.StatusElement;
                        ObservationStatus? bm_ = bl_?.Value;
                        string bn_ = context.Operators.Convert<string>(bm_);
                        string[] bo_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? bp_ = context.Operators.In<string>(bn_, (IEnumerable<string>)bo_);
                        return bk_ & bp_;
                    }
                }

                IEnumerable<Observation> aq_ = context.Operators.Where<Observation>(ao_, ap_);

                object ar_(Observation @this) {
                    DataType bq_ = @this?.Effective;
                    object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                    CqlInterval<CqlDateTime> bs_ = QICoreCommon_4_0_000.Instance.toInterval(context, br_);
                    CqlDateTime bt_ = context.Operators.Start(bs_);
                    return bt_;
                }

                IEnumerable<Observation> as_ = context.Operators.SortBy<Observation>(aq_, ar_, System.ComponentModel.ListSortDirection.Ascending);
                Observation at_ = context.Operators.Last<Observation>(as_);
                List<Observation.ComponentComponent> au_ = at_?.Component;

                bool? av_(Observation.ComponentComponent C) {
                    CodeableConcept bu_ = C?.Code;
                    CqlConcept bv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bu_);
                    CqlCode bw_ = this.Diastolic_blood_pressure(context);
                    CqlConcept bx_ = context.Operators.ConvertCodeToConcept(bw_);
                    bool? by_ = context.Operators.Equivalent(bv_, bx_);
                    return by_;
                }

                IEnumerable<Observation.ComponentComponent> aw_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)au_, av_);
                Observation.ComponentComponent ax_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(aw_);
                DataType ay_ = ax_?.Value;
                object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                CqlQuantity ba_ = context.Operators.Quantity(1m, "mm[Hg]");
                CqlQuantity bb_ = context.Operators.Quantity(80m, "mm[Hg]");
                CqlInterval<CqlQuantity> bc_ = context.Operators.Interval(ba_, bb_, true, false);
                bool? bd_ = context.Operators.In<CqlQuantity>(az_ as CqlQuantity, bc_, (string)default);
                return s_ & bd_;
            }
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
            bool? h_ = context.Operators.Equivalent(g_, "order");
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
            bool? v_ = context.Operators.In<string>(t_, (IEnumerable<string>)u_);
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
                CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return j_;
            }

            IEnumerable<CqlConcept> g_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)e_, f_);
            CqlValueSet h_ = this.Finding_of_Elevated_Blood_Pressure_or_Hypertension(context);
            bool? i_ = context.Operators.ConceptsInValueSet(g_, h_);
            // CQL 'and' (118:5-119:108): right operand skipped when left is false
            if (i_ is false)
            {
                return false;
            }
            else
            {
                Code<RequestIntent> k_ = Referral?.IntentElement;
                RequestIntent? l_ = k_?.Value;
                Code<RequestIntent> m_ = context.Operators.Convert<Code<RequestIntent>>(l_);
                string n_ = context.Operators.Convert<string>(m_);
                string[] o_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                bool? p_ = context.Operators.In<string>(n_, (IEnumerable<string>)o_);
                return i_ & p_;
            }
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
                bool? p_ = context.Operators.In<CqlDateTime>(m_, o_, "day");
                return p_;
            }

            bool? k_ = context.Operators.WhereAny<ServiceRequest>(i_, j_);
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
                bool? x_ = context.Operators.In<CqlDateTime>(u_, w_, "day");
                return x_;
            }

            bool? s_ = context.Operators.WhereAny<ServiceRequest>(q_, r_);
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
                bool? af_ = context.Operators.In<CqlDateTime>(ac_, ae_, "day");
                return af_;
            }

            bool? aa_ = context.Operators.WhereAny<ServiceRequest>(y_, z_);
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
                DataType s_ = BloodPressure?.Effective;
                object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_);
                CqlDateTime v_ = context.Operators.End(u_);
                Period w_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, w_);
                CqlDateTime y_ = context.Operators.Start(x_);
                CqlQuantity z_ = context.Operators.Quantity(1m, "year");
                CqlDateTime aa_ = context.Operators.Subtract(y_, z_);
                CqlInterval<CqlDateTime> ab_ = context.Operators.Interval(aa_, y_, true, true);
                bool? ac_ = context.Operators.In<CqlDateTime>(v_, ab_, (string)default);
                bool? ad_;
                // CQL 'and' (285:17-285:121): right operand skipped when left is false
                if (ac_ is false)
                {
                    ad_ = false;
                }
                else
                {
                    Period ae_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ae_);
                    CqlDateTime ag_ = context.Operators.Start(af_);
                    ad_ = ac_ & (!((bool?)(ag_ is null)));
                }
                // CQL 'and' (285:11-286:75): right operand skipped when left is false
                if (ad_ is false)
                {
                    return false;
                }
                else
                {
                    Code<ObservationStatus> ah_ = BloodPressure?.StatusElement;
                    ObservationStatus? ai_ = ah_?.Value;
                    string aj_ = context.Operators.Convert<string>(ai_);
                    string[] ak_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? al_ = context.Operators.In<string>(aj_, (IEnumerable<string>)ak_);
                    return ad_ & al_;
                }
            }

            IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);

            object g_(Observation @this) {
                DataType am_ = @this?.Effective;
                object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                CqlInterval<CqlDateTime> ao_ = QICoreCommon_4_0_000.Instance.toInterval(context, an_);
                CqlDateTime ap_ = context.Operators.Start(ao_);
                return ap_;
            }

            IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
            Observation i_ = context.Operators.Last<Observation>(h_);
            List<Observation.ComponentComponent> j_ = i_?.Component;

            bool? k_(Observation.ComponentComponent C) {
                CodeableConcept aq_ = C?.Code;
                CqlConcept ar_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aq_);
                CqlCode as_ = this.Systolic_blood_pressure(context);
                CqlConcept at_ = context.Operators.ConvertCodeToConcept(as_);
                bool? au_ = context.Operators.Equivalent(ar_, at_);
                return au_;
            }

            IEnumerable<Observation.ComponentComponent> l_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)j_, k_);
            Observation.ComponentComponent m_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            CqlQuantity p_ = context.Operators.Quantity(0m, "mm[Hg]");
            bool? q_ = context.Operators.Greater(o_ as CqlQuantity, p_);
            bool? r_;
            // CQL 'and' (289:15-296:30): right operand skipped when left is false
            if (q_ is false)
            {
                r_ = false;
            }
            else
            {
                IEnumerable<Observation> av_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

                bool? aw_(Observation BloodPressure) {
                    DataType bj_ = BloodPressure?.Effective;
                    object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                    CqlInterval<CqlDateTime> bl_ = QICoreCommon_4_0_000.Instance.toInterval(context, bk_);
                    CqlDateTime bm_ = context.Operators.End(bl_);
                    Period bn_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> bo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bn_);
                    CqlDateTime bp_ = context.Operators.Start(bo_);
                    CqlQuantity bq_ = context.Operators.Quantity(1m, "year");
                    CqlDateTime br_ = context.Operators.Subtract(bp_, bq_);
                    CqlInterval<CqlDateTime> bs_ = context.Operators.Interval(br_, bp_, true, true);
                    bool? bt_ = context.Operators.In<CqlDateTime>(bm_, bs_, (string)default);
                    bool? bu_;
                    // CQL 'and' (285:17-285:121): right operand skipped when left is false
                    if (bt_ is false)
                    {
                        bu_ = false;
                    }
                    else
                    {
                        Period bv_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> bw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bv_);
                        CqlDateTime bx_ = context.Operators.Start(bw_);
                        bu_ = bt_ & (!((bool?)(bx_ is null)));
                    }
                    // CQL 'and' (285:11-286:75): right operand skipped when left is false
                    if (bu_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Code<ObservationStatus> by_ = BloodPressure?.StatusElement;
                        ObservationStatus? bz_ = by_?.Value;
                        string ca_ = context.Operators.Convert<string>(bz_);
                        string[] cb_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? cc_ = context.Operators.In<string>(ca_, (IEnumerable<string>)cb_);
                        return bu_ & cc_;
                    }
                }

                IEnumerable<Observation> ax_ = context.Operators.Where<Observation>(av_, aw_);

                object ay_(Observation @this) {
                    DataType cd_ = @this?.Effective;
                    object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                    CqlInterval<CqlDateTime> cf_ = QICoreCommon_4_0_000.Instance.toInterval(context, ce_);
                    CqlDateTime cg_ = context.Operators.Start(cf_);
                    return cg_;
                }

                IEnumerable<Observation> az_ = context.Operators.SortBy<Observation>(ax_, ay_, System.ComponentModel.ListSortDirection.Ascending);
                Observation ba_ = context.Operators.Last<Observation>(az_);
                List<Observation.ComponentComponent> bb_ = ba_?.Component;

                bool? bc_(Observation.ComponentComponent C) {
                    CodeableConcept ch_ = C?.Code;
                    CqlConcept ci_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ch_);
                    CqlCode cj_ = this.Diastolic_blood_pressure(context);
                    CqlConcept ck_ = context.Operators.ConvertCodeToConcept(cj_);
                    bool? cl_ = context.Operators.Equivalent(ci_, ck_);
                    return cl_;
                }

                IEnumerable<Observation.ComponentComponent> bd_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)bb_, bc_);
                Observation.ComponentComponent be_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(bd_);
                DataType bf_ = be_?.Value;
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                CqlQuantity bh_ = context.Operators.Quantity(0m, "mm[Hg]");
                bool? bi_ = context.Operators.Greater(bg_ as CqlQuantity, bh_);
                r_ = q_ & bi_;
            }
            // CQL 'and' (289:7-306:7): right operand skipped when left is false
            if (r_ is false)
            {
                return false;
            }
            else
            {
                IEnumerable<Observation> cm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

                bool? cn_(Observation BloodPressure) {
                    DataType db_ = BloodPressure?.Effective;
                    object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                    CqlInterval<CqlDateTime> dd_ = QICoreCommon_4_0_000.Instance.toInterval(context, dc_);
                    CqlDateTime de_ = context.Operators.End(dd_);
                    Period df_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> dg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, df_);
                    CqlDateTime dh_ = context.Operators.Start(dg_);
                    CqlQuantity di_ = context.Operators.Quantity(1m, "year");
                    CqlDateTime dj_ = context.Operators.Subtract(dh_, di_);
                    CqlInterval<CqlDateTime> dk_ = context.Operators.Interval(dj_, dh_, true, true);
                    bool? dl_ = context.Operators.In<CqlDateTime>(de_, dk_, (string)default);
                    bool? dm_;
                    // CQL 'and' (285:17-285:121): right operand skipped when left is false
                    if (dl_ is false)
                    {
                        dm_ = false;
                    }
                    else
                    {
                        Period dn_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> do_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dn_);
                        CqlDateTime dp_ = context.Operators.Start(do_);
                        dm_ = dl_ & (!((bool?)(dp_ is null)));
                    }
                    // CQL 'and' (285:11-286:75): right operand skipped when left is false
                    if (dm_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Code<ObservationStatus> dq_ = BloodPressure?.StatusElement;
                        ObservationStatus? dr_ = dq_?.Value;
                        string ds_ = context.Operators.Convert<string>(dr_);
                        string[] dt_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? du_ = context.Operators.In<string>(ds_, (IEnumerable<string>)dt_);
                        return dm_ & du_;
                    }
                }

                IEnumerable<Observation> co_ = context.Operators.Where<Observation>(cm_, cn_);

                object cp_(Observation @this) {
                    DataType dv_ = @this?.Effective;
                    object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                    CqlInterval<CqlDateTime> dx_ = QICoreCommon_4_0_000.Instance.toInterval(context, dw_);
                    CqlDateTime dy_ = context.Operators.Start(dx_);
                    return dy_;
                }

                IEnumerable<Observation> cq_ = context.Operators.SortBy<Observation>(co_, cp_, System.ComponentModel.ListSortDirection.Ascending);
                Observation cr_ = context.Operators.Last<Observation>(cq_);
                List<Observation.ComponentComponent> cs_ = cr_?.Component;

                bool? ct_(Observation.ComponentComponent C) {
                    CodeableConcept dz_ = C?.Code;
                    CqlConcept ea_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dz_);
                    CqlCode eb_ = this.Systolic_blood_pressure(context);
                    CqlConcept ec_ = context.Operators.ConvertCodeToConcept(eb_);
                    bool? ed_ = context.Operators.Equivalent(ea_, ec_);
                    return ed_;
                }

                IEnumerable<Observation.ComponentComponent> cu_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)cs_, ct_);
                Observation.ComponentComponent cv_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(cu_);
                DataType cw_ = cv_?.Value;
                object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                CqlQuantity cy_ = context.Operators.Quantity(130m, "mm[Hg]");
                bool? cz_ = context.Operators.GreaterOrEqual(cx_ as CqlQuantity, cy_);
                bool? da_;
                // CQL 'or' (297:15-305:11): right operand skipped when left is true
                if (cz_ is true)
                {
                    da_ = true;
                }
                else
                {
                    IEnumerable<Observation> ee_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

                    bool? ef_(Observation BloodPressure) {
                        DataType es_ = BloodPressure?.Effective;
                        object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                        CqlInterval<CqlDateTime> eu_ = QICoreCommon_4_0_000.Instance.toInterval(context, et_);
                        CqlDateTime ev_ = context.Operators.End(eu_);
                        Period ew_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> ex_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ew_);
                        CqlDateTime ey_ = context.Operators.Start(ex_);
                        CqlQuantity ez_ = context.Operators.Quantity(1m, "year");
                        CqlDateTime fa_ = context.Operators.Subtract(ey_, ez_);
                        CqlInterval<CqlDateTime> fb_ = context.Operators.Interval(fa_, ey_, true, true);
                        bool? fc_ = context.Operators.In<CqlDateTime>(ev_, fb_, (string)default);
                        bool? fd_;
                        // CQL 'and' (285:17-285:121): right operand skipped when left is false
                        if (fc_ is false)
                        {
                            fd_ = false;
                        }
                        else
                        {
                            Period fe_ = QualifyingEncounter?.Period;
                            CqlInterval<CqlDateTime> ff_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fe_);
                            CqlDateTime fg_ = context.Operators.Start(ff_);
                            fd_ = fc_ & (!((bool?)(fg_ is null)));
                        }
                        // CQL 'and' (285:11-286:75): right operand skipped when left is false
                        if (fd_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            Code<ObservationStatus> fh_ = BloodPressure?.StatusElement;
                            ObservationStatus? fi_ = fh_?.Value;
                            string fj_ = context.Operators.Convert<string>(fi_);
                            string[] fk_ = [
                                "final",
                                "amended",
                                "corrected",
                            ];
                            bool? fl_ = context.Operators.In<string>(fj_, (IEnumerable<string>)fk_);
                            return fd_ & fl_;
                        }
                    }

                    IEnumerable<Observation> eg_ = context.Operators.Where<Observation>(ee_, ef_);

                    object eh_(Observation @this) {
                        DataType fm_ = @this?.Effective;
                        object fn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fm_);
                        CqlInterval<CqlDateTime> fo_ = QICoreCommon_4_0_000.Instance.toInterval(context, fn_);
                        CqlDateTime fp_ = context.Operators.Start(fo_);
                        return fp_;
                    }

                    IEnumerable<Observation> ei_ = context.Operators.SortBy<Observation>(eg_, eh_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation ej_ = context.Operators.Last<Observation>(ei_);
                    List<Observation.ComponentComponent> ek_ = ej_?.Component;

                    bool? el_(Observation.ComponentComponent C) {
                        CodeableConcept fq_ = C?.Code;
                        CqlConcept fr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fq_);
                        CqlCode fs_ = this.Diastolic_blood_pressure(context);
                        CqlConcept ft_ = context.Operators.ConvertCodeToConcept(fs_);
                        bool? fu_ = context.Operators.Equivalent(fr_, ft_);
                        return fu_;
                    }

                    IEnumerable<Observation.ComponentComponent> em_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ek_, el_);
                    Observation.ComponentComponent en_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(em_);
                    DataType eo_ = en_?.Value;
                    object ep_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eo_);
                    CqlQuantity eq_ = context.Operators.Quantity(80m, "mm[Hg]");
                    bool? er_ = context.Operators.GreaterOrEqual(ep_ as CqlQuantity, eq_);
                    da_ = cz_ | er_;
                }
                return r_ & da_;
            }
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
                DataType u_ = BloodPressure?.Effective;
                object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
                CqlDateTime x_ = context.Operators.End(w_);
                Period y_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
                bool? aa_ = context.Operators.In<CqlDateTime>(x_, z_, "day");
                // CQL 'and' (256:11-257:75): right operand skipped when left is false
                if (aa_ is false)
                {
                    return false;
                }
                else
                {
                    Code<ObservationStatus> ab_ = BloodPressure?.StatusElement;
                    ObservationStatus? ac_ = ab_?.Value;
                    string ad_ = context.Operators.Convert<string>(ac_);
                    string[] ae_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? af_ = context.Operators.In<string>(ad_, (IEnumerable<string>)ae_);
                    return aa_ & af_;
                }
            }

            IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);

            object i_(Observation @this) {
                DataType ag_ = @this?.Effective;
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                CqlInterval<CqlDateTime> ai_ = QICoreCommon_4_0_000.Instance.toInterval(context, ah_);
                CqlDateTime aj_ = context.Operators.Start(ai_);
                return aj_;
            }

            IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Observation k_ = context.Operators.Last<Observation>(j_);
            List<Observation.ComponentComponent> l_ = k_?.Component;

            bool? m_(Observation.ComponentComponent C) {
                CodeableConcept ak_ = C?.Code;
                CqlConcept al_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ak_);
                CqlCode am_ = this.Systolic_blood_pressure(context);
                CqlConcept an_ = context.Operators.ConvertCodeToConcept(am_);
                bool? ao_ = context.Operators.Equivalent(al_, an_);
                return ao_;
            }

            IEnumerable<Observation.ComponentComponent> n_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)l_, m_);
            Observation.ComponentComponent o_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(n_);
            DataType p_ = o_?.Value;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlQuantity r_ = context.Operators.Quantity(0m, "mm[Hg]");
            bool? s_ = context.Operators.Greater(q_ as CqlQuantity, r_);
            bool? t_;
            // CQL 'and' (260:15-268:9): right operand skipped when left is false
            if (s_ is false)
            {
                t_ = false;
            }
            else
            {
                IEnumerable<Observation> ap_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

                bool? aq_(Observation BloodPressure) {
                    DataType bd_ = BloodPressure?.Effective;
                    object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                    CqlInterval<CqlDateTime> bf_ = QICoreCommon_4_0_000.Instance.toInterval(context, be_);
                    CqlDateTime bg_ = context.Operators.End(bf_);
                    Period bh_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> bi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bh_);
                    bool? bj_ = context.Operators.In<CqlDateTime>(bg_, bi_, "day");
                    // CQL 'and' (256:11-257:75): right operand skipped when left is false
                    if (bj_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Code<ObservationStatus> bk_ = BloodPressure?.StatusElement;
                        ObservationStatus? bl_ = bk_?.Value;
                        string bm_ = context.Operators.Convert<string>(bl_);
                        string[] bn_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? bo_ = context.Operators.In<string>(bm_, (IEnumerable<string>)bn_);
                        return bj_ & bo_;
                    }
                }

                IEnumerable<Observation> ar_ = context.Operators.Where<Observation>(ap_, aq_);

                object as_(Observation @this) {
                    DataType bp_ = @this?.Effective;
                    object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                    CqlInterval<CqlDateTime> br_ = QICoreCommon_4_0_000.Instance.toInterval(context, bq_);
                    CqlDateTime bs_ = context.Operators.Start(br_);
                    return bs_;
                }

                IEnumerable<Observation> at_ = context.Operators.SortBy<Observation>(ar_, as_, System.ComponentModel.ListSortDirection.Ascending);
                Observation au_ = context.Operators.Last<Observation>(at_);
                List<Observation.ComponentComponent> av_ = au_?.Component;

                bool? aw_(Observation.ComponentComponent C) {
                    CodeableConcept bt_ = C?.Code;
                    CqlConcept bu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bt_);
                    CqlCode bv_ = this.Diastolic_blood_pressure(context);
                    CqlConcept bw_ = context.Operators.ConvertCodeToConcept(bv_);
                    bool? bx_ = context.Operators.Equivalent(bu_, bw_);
                    return bx_;
                }

                IEnumerable<Observation.ComponentComponent> ax_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)av_, aw_);
                Observation.ComponentComponent ay_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ax_);
                DataType az_ = ay_?.Value;
                object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                CqlQuantity bb_ = context.Operators.Quantity(0m, "mm[Hg]");
                bool? bc_ = context.Operators.Greater(ba_ as CqlQuantity, bb_);
                t_ = s_ & bc_;
            }
            // CQL 'and' (260:7-278:7): right operand skipped when left is false
            if (t_ is false)
            {
                return false;
            }
            else
            {
                IEnumerable<Observation> by_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

                bool? bz_(Observation BloodPressure) {
                    DataType cn_ = BloodPressure?.Effective;
                    object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                    CqlInterval<CqlDateTime> cp_ = QICoreCommon_4_0_000.Instance.toInterval(context, co_);
                    CqlDateTime cq_ = context.Operators.End(cp_);
                    Period cr_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> cs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cr_);
                    bool? ct_ = context.Operators.In<CqlDateTime>(cq_, cs_, "day");
                    // CQL 'and' (256:11-257:75): right operand skipped when left is false
                    if (ct_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Code<ObservationStatus> cu_ = BloodPressure?.StatusElement;
                        ObservationStatus? cv_ = cu_?.Value;
                        string cw_ = context.Operators.Convert<string>(cv_);
                        string[] cx_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? cy_ = context.Operators.In<string>(cw_, (IEnumerable<string>)cx_);
                        return ct_ & cy_;
                    }
                }

                IEnumerable<Observation> ca_ = context.Operators.Where<Observation>(by_, bz_);

                object cb_(Observation @this) {
                    DataType cz_ = @this?.Effective;
                    object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                    CqlInterval<CqlDateTime> db_ = QICoreCommon_4_0_000.Instance.toInterval(context, da_);
                    CqlDateTime dc_ = context.Operators.Start(db_);
                    return dc_;
                }

                IEnumerable<Observation> cc_ = context.Operators.SortBy<Observation>(ca_, cb_, System.ComponentModel.ListSortDirection.Ascending);
                Observation cd_ = context.Operators.Last<Observation>(cc_);
                List<Observation.ComponentComponent> ce_ = cd_?.Component;

                bool? cf_(Observation.ComponentComponent C) {
                    CodeableConcept dd_ = C?.Code;
                    CqlConcept de_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dd_);
                    CqlCode df_ = this.Systolic_blood_pressure(context);
                    CqlConcept dg_ = context.Operators.ConvertCodeToConcept(df_);
                    bool? dh_ = context.Operators.Equivalent(de_, dg_);
                    return dh_;
                }

                IEnumerable<Observation.ComponentComponent> cg_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ce_, cf_);
                Observation.ComponentComponent ch_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(cg_);
                DataType ci_ = ch_?.Value;
                object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                CqlQuantity ck_ = context.Operators.Quantity(130m, "mm[Hg]");
                bool? cl_ = context.Operators.GreaterOrEqual(cj_ as CqlQuantity, ck_);
                bool? cm_;
                // CQL 'or' (269:15-277:11): right operand skipped when left is true
                if (cl_ is true)
                {
                    cm_ = true;
                }
                else
                {
                    IEnumerable<Observation> di_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

                    bool? dj_(Observation BloodPressure) {
                        DataType dw_ = BloodPressure?.Effective;
                        object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                        CqlInterval<CqlDateTime> dy_ = QICoreCommon_4_0_000.Instance.toInterval(context, dx_);
                        CqlDateTime dz_ = context.Operators.End(dy_);
                        Period ea_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> eb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ea_);
                        bool? ec_ = context.Operators.In<CqlDateTime>(dz_, eb_, "day");
                        // CQL 'and' (256:11-257:75): right operand skipped when left is false
                        if (ec_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            Code<ObservationStatus> ed_ = BloodPressure?.StatusElement;
                            ObservationStatus? ee_ = ed_?.Value;
                            string ef_ = context.Operators.Convert<string>(ee_);
                            string[] eg_ = [
                                "final",
                                "amended",
                                "corrected",
                            ];
                            bool? eh_ = context.Operators.In<string>(ef_, (IEnumerable<string>)eg_);
                            return ec_ & eh_;
                        }
                    }

                    IEnumerable<Observation> dk_ = context.Operators.Where<Observation>(di_, dj_);

                    object dl_(Observation @this) {
                        DataType ei_ = @this?.Effective;
                        object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                        CqlInterval<CqlDateTime> ek_ = QICoreCommon_4_0_000.Instance.toInterval(context, ej_);
                        CqlDateTime el_ = context.Operators.Start(ek_);
                        return el_;
                    }

                    IEnumerable<Observation> dm_ = context.Operators.SortBy<Observation>(dk_, dl_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation dn_ = context.Operators.Last<Observation>(dm_);
                    List<Observation.ComponentComponent> do_ = dn_?.Component;

                    bool? dp_(Observation.ComponentComponent C) {
                        CodeableConcept em_ = C?.Code;
                        CqlConcept en_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, em_);
                        CqlCode eo_ = this.Diastolic_blood_pressure(context);
                        CqlConcept ep_ = context.Operators.ConvertCodeToConcept(eo_);
                        bool? eq_ = context.Operators.Equivalent(en_, ep_);
                        return eq_;
                    }

                    IEnumerable<Observation.ComponentComponent> dq_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)do_, dp_);
                    Observation.ComponentComponent dr_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(dq_);
                    DataType ds_ = dr_?.Value;
                    object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                    CqlQuantity du_ = context.Operators.Quantity(80m, "mm[Hg]");
                    bool? dv_ = context.Operators.GreaterOrEqual(dt_ as CqlQuantity, du_);
                    cm_ = cl_ | dv_;
                }
                return t_ & cm_;
            }
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
                bool? m_ = context.Operators.In<CqlDateTime>(k_, l_, "day");
                bool? n_;
                // CQL 'and' (110:19-111:84): right operand skipped when left is false
                if (m_ is false)
                {
                    n_ = false;
                }
                else
                {
                    FhirDateTime o_ = NonPharmInterventionsHTN?.AuthoredOnElement;
                    CqlDateTime p_ = context.Operators.Convert<CqlDateTime>(o_);
                    CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
                    bool? r_ = context.Operators.In<CqlDateTime>(p_, q_, "day");
                    n_ = m_ & r_;
                }
                // CQL 'and' (110:19-112:120): right operand skipped when left is false
                if (n_ is false)
                {
                    return false;
                }
                else
                {
                    Code<RequestIntent> s_ = FourWeekRescreen?.IntentElement;
                    RequestIntent? t_ = s_?.Value;
                    Code<RequestIntent> u_ = context.Operators.Convert<Code<RequestIntent>>(t_);
                    string v_ = context.Operators.Convert<string>(u_);
                    string[] w_ = [
                        "order",
                        "original-order",
                        "reflex-order",
                        "filler-order",
                        "instance-order",
                    ];
                    bool? x_ = context.Operators.In<string>(v_, (IEnumerable<string>)w_);
                    return n_ & x_;
                }
            }

            bool? i_ = context.Operators.WhereAny<ServiceRequest>(g_, h_);
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
                bool? k_ = context.Operators.In<CqlDateTime>(h_, j_, "day");
                return k_;
            }

            bool? f_ = context.Operators.WhereAny<ServiceRequest>(d_, e_);
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
                DataType w_ = BloodPressure?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_);
                CqlDateTime z_ = context.Operators.End(y_);
                Period aa_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aa_);
                bool? ac_ = context.Operators.In<CqlDateTime>(z_, ab_, "day");
                // CQL 'and' (226:13-227:77): right operand skipped when left is false
                if (ac_ is false)
                {
                    return false;
                }
                else
                {
                    Code<ObservationStatus> ad_ = BloodPressure?.StatusElement;
                    ObservationStatus? ae_ = ad_?.Value;
                    string af_ = context.Operators.Convert<string>(ae_);
                    string[] ag_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? ah_ = context.Operators.In<string>(af_, (IEnumerable<string>)ag_);
                    return ac_ & ah_;
                }
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
                bool? aq_ = context.Operators.Equivalent(an_, ap_);
                return aq_;
            }

            IEnumerable<Observation.ComponentComponent> n_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)l_, m_);
            Observation.ComponentComponent o_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(n_);
            DataType p_ = o_?.Value;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlQuantity r_ = context.Operators.Quantity(130m, "mm[Hg]");
            CqlQuantity s_ = context.Operators.Quantity(139m, "mm[Hg]");
            CqlInterval<CqlQuantity> t_ = context.Operators.Interval(r_, s_, true, true);
            bool? u_ = context.Operators.In<CqlQuantity>(q_ as CqlQuantity, t_, (string)default);
            bool? v_;
            // CQL 'or' (230:17-238:11): right operand skipped when left is true
            if (u_ is true)
            {
                v_ = true;
            }
            else
            {
                IEnumerable<Observation> ar_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

                bool? as_(Observation BloodPressure) {
                    DataType bh_ = BloodPressure?.Effective;
                    object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    CqlInterval<CqlDateTime> bj_ = QICoreCommon_4_0_000.Instance.toInterval(context, bi_);
                    CqlDateTime bk_ = context.Operators.End(bj_);
                    Period bl_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> bm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bl_);
                    bool? bn_ = context.Operators.In<CqlDateTime>(bk_, bm_, "day");
                    // CQL 'and' (226:13-227:77): right operand skipped when left is false
                    if (bn_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Code<ObservationStatus> bo_ = BloodPressure?.StatusElement;
                        ObservationStatus? bp_ = bo_?.Value;
                        string bq_ = context.Operators.Convert<string>(bp_);
                        string[] br_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? bs_ = context.Operators.In<string>(bq_, (IEnumerable<string>)br_);
                        return bn_ & bs_;
                    }
                }

                IEnumerable<Observation> at_ = context.Operators.Where<Observation>(ar_, as_);

                object au_(Observation @this) {
                    DataType bt_ = @this?.Effective;
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                    CqlInterval<CqlDateTime> bv_ = QICoreCommon_4_0_000.Instance.toInterval(context, bu_);
                    CqlDateTime bw_ = context.Operators.Start(bv_);
                    return bw_;
                }

                IEnumerable<Observation> av_ = context.Operators.SortBy<Observation>(at_, au_, System.ComponentModel.ListSortDirection.Ascending);
                Observation aw_ = context.Operators.Last<Observation>(av_);
                List<Observation.ComponentComponent> ax_ = aw_?.Component;

                bool? ay_(Observation.ComponentComponent C) {
                    CodeableConcept bx_ = C?.Code;
                    CqlConcept by_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bx_);
                    CqlCode bz_ = this.Diastolic_blood_pressure(context);
                    CqlConcept ca_ = context.Operators.ConvertCodeToConcept(bz_);
                    bool? cb_ = context.Operators.Equivalent(by_, ca_);
                    return cb_;
                }

                IEnumerable<Observation.ComponentComponent> az_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ax_, ay_);
                Observation.ComponentComponent ba_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(az_);
                DataType bb_ = ba_?.Value;
                object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                CqlQuantity bd_ = context.Operators.Quantity(80m, "mm[Hg]");
                CqlQuantity be_ = context.Operators.Quantity(89m, "mm[Hg]");
                CqlInterval<CqlQuantity> bf_ = context.Operators.Interval(bd_, be_, true, true);
                bool? bg_ = context.Operators.In<CqlQuantity>(bc_ as CqlQuantity, bf_, (string)default);
                v_ = u_ | bg_;
            }
            // CQL 'and' (230:9-248:9): right operand skipped when left is false
            if (v_ is false)
            {
                return false;
            }
            else
            {
                IEnumerable<Observation> cc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

                bool? cd_(Observation BloodPressure) {
                    DataType cr_ = BloodPressure?.Effective;
                    object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                    CqlInterval<CqlDateTime> ct_ = QICoreCommon_4_0_000.Instance.toInterval(context, cs_);
                    CqlDateTime cu_ = context.Operators.End(ct_);
                    Period cv_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> cw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cv_);
                    bool? cx_ = context.Operators.In<CqlDateTime>(cu_, cw_, "day");
                    // CQL 'and' (226:13-227:77): right operand skipped when left is false
                    if (cx_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Code<ObservationStatus> cy_ = BloodPressure?.StatusElement;
                        ObservationStatus? cz_ = cy_?.Value;
                        string da_ = context.Operators.Convert<string>(cz_);
                        string[] db_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? dc_ = context.Operators.In<string>(da_, (IEnumerable<string>)db_);
                        return cx_ & dc_;
                    }
                }

                IEnumerable<Observation> ce_ = context.Operators.Where<Observation>(cc_, cd_);

                object cf_(Observation @this) {
                    DataType dd_ = @this?.Effective;
                    object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                    CqlInterval<CqlDateTime> df_ = QICoreCommon_4_0_000.Instance.toInterval(context, de_);
                    CqlDateTime dg_ = context.Operators.Start(df_);
                    return dg_;
                }

                IEnumerable<Observation> cg_ = context.Operators.SortBy<Observation>(ce_, cf_, System.ComponentModel.ListSortDirection.Ascending);
                Observation ch_ = context.Operators.Last<Observation>(cg_);
                List<Observation.ComponentComponent> ci_ = ch_?.Component;

                bool? cj_(Observation.ComponentComponent C) {
                    CodeableConcept dh_ = C?.Code;
                    CqlConcept di_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dh_);
                    CqlCode dj_ = this.Systolic_blood_pressure(context);
                    CqlConcept dk_ = context.Operators.ConvertCodeToConcept(dj_);
                    bool? dl_ = context.Operators.Equivalent(di_, dk_);
                    return dl_;
                }

                IEnumerable<Observation.ComponentComponent> ck_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ci_, cj_);
                Observation.ComponentComponent cl_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ck_);
                DataType cm_ = cl_?.Value;
                object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                CqlQuantity co_ = context.Operators.Quantity(140m, "mm[Hg]");
                bool? cp_ = context.Operators.GreaterOrEqual(cn_ as CqlQuantity, co_);
                bool? cq_;
                // CQL 'or' (239:21-247:13): right operand skipped when left is true
                if (cp_ is true)
                {
                    cq_ = true;
                }
                else
                {
                    IEnumerable<Observation> dm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

                    bool? dn_(Observation BloodPressure) {
                        DataType ea_ = BloodPressure?.Effective;
                        object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                        CqlInterval<CqlDateTime> ec_ = QICoreCommon_4_0_000.Instance.toInterval(context, eb_);
                        CqlDateTime ed_ = context.Operators.End(ec_);
                        Period ee_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> ef_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ee_);
                        bool? eg_ = context.Operators.In<CqlDateTime>(ed_, ef_, "day");
                        // CQL 'and' (226:13-227:77): right operand skipped when left is false
                        if (eg_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            Code<ObservationStatus> eh_ = BloodPressure?.StatusElement;
                            ObservationStatus? ei_ = eh_?.Value;
                            string ej_ = context.Operators.Convert<string>(ei_);
                            string[] ek_ = [
                                "final",
                                "amended",
                                "corrected",
                            ];
                            bool? el_ = context.Operators.In<string>(ej_, (IEnumerable<string>)ek_);
                            return eg_ & el_;
                        }
                    }

                    IEnumerable<Observation> do_ = context.Operators.Where<Observation>(dm_, dn_);

                    object dp_(Observation @this) {
                        DataType em_ = @this?.Effective;
                        object en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
                        CqlInterval<CqlDateTime> eo_ = QICoreCommon_4_0_000.Instance.toInterval(context, en_);
                        CqlDateTime ep_ = context.Operators.Start(eo_);
                        return ep_;
                    }

                    IEnumerable<Observation> dq_ = context.Operators.SortBy<Observation>(do_, dp_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation dr_ = context.Operators.Last<Observation>(dq_);
                    List<Observation.ComponentComponent> ds_ = dr_?.Component;

                    bool? dt_(Observation.ComponentComponent C) {
                        CodeableConcept eq_ = C?.Code;
                        CqlConcept er_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, eq_);
                        CqlCode es_ = this.Diastolic_blood_pressure(context);
                        CqlConcept et_ = context.Operators.ConvertCodeToConcept(es_);
                        bool? eu_ = context.Operators.Equivalent(er_, et_);
                        return eu_;
                    }

                    IEnumerable<Observation.ComponentComponent> du_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ds_, dt_);
                    Observation.ComponentComponent dv_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(du_);
                    DataType dw_ = dv_?.Value;
                    object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                    CqlQuantity dy_ = context.Operators.Quantity(90m, "mm[Hg]");
                    bool? dz_ = context.Operators.GreaterOrEqual(dx_ as CqlQuantity, dy_);
                    cq_ = cp_ | dz_;
                }
                return v_ & !cq_;
            }
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
            bool? r_ = context.Operators.In<string>(p_, (IEnumerable<string>)q_);
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
                bool? l_ = context.Operators.In<CqlDateTime>(j_, k_, "day");
                // CQL 'and' (138:17-139:76): right operand skipped when left is false
                if (l_ is false)
                {
                    return false;
                }
                else
                {
                    FhirDateTime m_ = LabECGIntervention?.AuthoredOnElement;
                    CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
                    CqlInterval<CqlDateTime> o_ = this.Measurement_Period(context);
                    bool? p_ = context.Operators.In<CqlDateTime>(n_, o_, "day");
                    return l_ & p_;
                }
            }

            bool? h_ = context.Operators.WhereAny<ServiceRequest>(f_, g_);
            return h_;
        }

        IEnumerable<ServiceRequest> c_ = context.Operators.Where<ServiceRequest>(a_, b_);

        bool? d_(ServiceRequest Rescreen2to6) {
            IEnumerable<ServiceRequest> q_ = this.NonPharmacological_Interventions(context);

            bool? r_(ServiceRequest NonPharmSecondIntervention) {
                FhirDateTime t_ = NonPharmSecondIntervention?.AuthoredOnElement;
                CqlDateTime u_ = context.Operators.Convert<CqlDateTime>(t_);
                CqlInterval<CqlDateTime> v_ = this.Measurement_Period(context);
                bool? w_ = context.Operators.In<CqlDateTime>(u_, v_, "day");
                return w_;
            }

            bool? s_ = context.Operators.WhereAny<ServiceRequest>(q_, r_);
            return s_;
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
                bool? n_ = context.Operators.In<CqlDateTime>(k_, m_, "day");
                return n_;
            }

            bool? i_ = context.Operators.WhereAny<ServiceRequest>(g_, h_);
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
                bool? v_ = context.Operators.In<CqlDateTime>(s_, u_, "day");
                return v_;
            }

            bool? q_ = context.Operators.WhereAny<ServiceRequest>(o_, p_);
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
                DataType u_ = BloodPressure?.Effective;
                object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
                CqlDateTime x_ = context.Operators.End(w_);
                Period y_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
                bool? aa_ = context.Operators.In<CqlDateTime>(x_, z_, "day");
                // CQL 'and' (197:13-198:77): right operand skipped when left is false
                if (aa_ is false)
                {
                    return false;
                }
                else
                {
                    Code<ObservationStatus> ab_ = BloodPressure?.StatusElement;
                    ObservationStatus? ac_ = ab_?.Value;
                    string ad_ = context.Operators.Convert<string>(ac_);
                    string[] ae_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? af_ = context.Operators.In<string>(ad_, (IEnumerable<string>)ae_);
                    return aa_ & af_;
                }
            }

            IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);

            object i_(Observation @this) {
                DataType ag_ = @this?.Effective;
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                CqlInterval<CqlDateTime> ai_ = QICoreCommon_4_0_000.Instance.toInterval(context, ah_);
                CqlDateTime aj_ = context.Operators.Start(ai_);
                return aj_;
            }

            IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Observation k_ = context.Operators.Last<Observation>(j_);
            List<Observation.ComponentComponent> l_ = k_?.Component;

            bool? m_(Observation.ComponentComponent C) {
                CodeableConcept ak_ = C?.Code;
                CqlConcept al_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ak_);
                CqlCode am_ = this.Systolic_blood_pressure(context);
                CqlConcept an_ = context.Operators.ConvertCodeToConcept(am_);
                bool? ao_ = context.Operators.Equivalent(al_, an_);
                return ao_;
            }

            IEnumerable<Observation.ComponentComponent> n_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)l_, m_);
            Observation.ComponentComponent o_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(n_);
            DataType p_ = o_?.Value;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlQuantity r_ = context.Operators.Quantity(0m, "mm[Hg]");
            bool? s_ = context.Operators.Greater(q_ as CqlQuantity, r_);
            bool? t_;
            // CQL 'and' (201:17-208:32): right operand skipped when left is false
            if (s_ is false)
            {
                t_ = false;
            }
            else
            {
                IEnumerable<Observation> ap_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

                bool? aq_(Observation BloodPressure) {
                    DataType bd_ = BloodPressure?.Effective;
                    object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                    CqlInterval<CqlDateTime> bf_ = QICoreCommon_4_0_000.Instance.toInterval(context, be_);
                    CqlDateTime bg_ = context.Operators.End(bf_);
                    Period bh_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> bi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bh_);
                    bool? bj_ = context.Operators.In<CqlDateTime>(bg_, bi_, "day");
                    // CQL 'and' (197:13-198:77): right operand skipped when left is false
                    if (bj_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Code<ObservationStatus> bk_ = BloodPressure?.StatusElement;
                        ObservationStatus? bl_ = bk_?.Value;
                        string bm_ = context.Operators.Convert<string>(bl_);
                        string[] bn_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? bo_ = context.Operators.In<string>(bm_, (IEnumerable<string>)bn_);
                        return bj_ & bo_;
                    }
                }

                IEnumerable<Observation> ar_ = context.Operators.Where<Observation>(ap_, aq_);

                object as_(Observation @this) {
                    DataType bp_ = @this?.Effective;
                    object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                    CqlInterval<CqlDateTime> br_ = QICoreCommon_4_0_000.Instance.toInterval(context, bq_);
                    CqlDateTime bs_ = context.Operators.Start(br_);
                    return bs_;
                }

                IEnumerable<Observation> at_ = context.Operators.SortBy<Observation>(ar_, as_, System.ComponentModel.ListSortDirection.Ascending);
                Observation au_ = context.Operators.Last<Observation>(at_);
                List<Observation.ComponentComponent> av_ = au_?.Component;

                bool? aw_(Observation.ComponentComponent C) {
                    CodeableConcept bt_ = C?.Code;
                    CqlConcept bu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bt_);
                    CqlCode bv_ = this.Diastolic_blood_pressure(context);
                    CqlConcept bw_ = context.Operators.ConvertCodeToConcept(bv_);
                    bool? bx_ = context.Operators.Equivalent(bu_, bw_);
                    return bx_;
                }

                IEnumerable<Observation.ComponentComponent> ax_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)av_, aw_);
                Observation.ComponentComponent ay_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ax_);
                DataType az_ = ay_?.Value;
                object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                CqlQuantity bb_ = context.Operators.Quantity(0m, "mm[Hg]");
                bool? bc_ = context.Operators.Greater(ba_ as CqlQuantity, bb_);
                t_ = s_ & bc_;
            }
            // CQL 'and' (201:9-218:9): right operand skipped when left is false
            if (t_ is false)
            {
                return false;
            }
            else
            {
                IEnumerable<Observation> by_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

                bool? bz_(Observation BloodPressure) {
                    DataType cn_ = BloodPressure?.Effective;
                    object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                    CqlInterval<CqlDateTime> cp_ = QICoreCommon_4_0_000.Instance.toInterval(context, co_);
                    CqlDateTime cq_ = context.Operators.End(cp_);
                    Period cr_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> cs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cr_);
                    bool? ct_ = context.Operators.In<CqlDateTime>(cq_, cs_, "day");
                    // CQL 'and' (197:13-198:77): right operand skipped when left is false
                    if (ct_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Code<ObservationStatus> cu_ = BloodPressure?.StatusElement;
                        ObservationStatus? cv_ = cu_?.Value;
                        string cw_ = context.Operators.Convert<string>(cv_);
                        string[] cx_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? cy_ = context.Operators.In<string>(cw_, (IEnumerable<string>)cx_);
                        return ct_ & cy_;
                    }
                }

                IEnumerable<Observation> ca_ = context.Operators.Where<Observation>(by_, bz_);

                object cb_(Observation @this) {
                    DataType cz_ = @this?.Effective;
                    object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                    CqlInterval<CqlDateTime> db_ = QICoreCommon_4_0_000.Instance.toInterval(context, da_);
                    CqlDateTime dc_ = context.Operators.Start(db_);
                    return dc_;
                }

                IEnumerable<Observation> cc_ = context.Operators.SortBy<Observation>(ca_, cb_, System.ComponentModel.ListSortDirection.Ascending);
                Observation cd_ = context.Operators.Last<Observation>(cc_);
                List<Observation.ComponentComponent> ce_ = cd_?.Component;

                bool? cf_(Observation.ComponentComponent C) {
                    CodeableConcept dd_ = C?.Code;
                    CqlConcept de_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dd_);
                    CqlCode df_ = this.Systolic_blood_pressure(context);
                    CqlConcept dg_ = context.Operators.ConvertCodeToConcept(df_);
                    bool? dh_ = context.Operators.Equivalent(de_, dg_);
                    return dh_;
                }

                IEnumerable<Observation.ComponentComponent> cg_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ce_, cf_);
                Observation.ComponentComponent ch_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(cg_);
                DataType ci_ = ch_?.Value;
                object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                CqlQuantity ck_ = context.Operators.Quantity(140m, "mm[Hg]");
                bool? cl_ = context.Operators.GreaterOrEqual(cj_ as CqlQuantity, ck_);
                bool? cm_;
                // CQL 'or' (209:17-217:13): right operand skipped when left is true
                if (cl_ is true)
                {
                    cm_ = true;
                }
                else
                {
                    IEnumerable<Observation> di_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

                    bool? dj_(Observation BloodPressure) {
                        DataType dw_ = BloodPressure?.Effective;
                        object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                        CqlInterval<CqlDateTime> dy_ = QICoreCommon_4_0_000.Instance.toInterval(context, dx_);
                        CqlDateTime dz_ = context.Operators.End(dy_);
                        Period ea_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> eb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ea_);
                        bool? ec_ = context.Operators.In<CqlDateTime>(dz_, eb_, "day");
                        // CQL 'and' (197:13-198:77): right operand skipped when left is false
                        if (ec_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            Code<ObservationStatus> ed_ = BloodPressure?.StatusElement;
                            ObservationStatus? ee_ = ed_?.Value;
                            string ef_ = context.Operators.Convert<string>(ee_);
                            string[] eg_ = [
                                "final",
                                "amended",
                                "corrected",
                            ];
                            bool? eh_ = context.Operators.In<string>(ef_, (IEnumerable<string>)eg_);
                            return ec_ & eh_;
                        }
                    }

                    IEnumerable<Observation> dk_ = context.Operators.Where<Observation>(di_, dj_);

                    object dl_(Observation @this) {
                        DataType ei_ = @this?.Effective;
                        object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                        CqlInterval<CqlDateTime> ek_ = QICoreCommon_4_0_000.Instance.toInterval(context, ej_);
                        CqlDateTime el_ = context.Operators.Start(ek_);
                        return el_;
                    }

                    IEnumerable<Observation> dm_ = context.Operators.SortBy<Observation>(dk_, dl_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation dn_ = context.Operators.Last<Observation>(dm_);
                    List<Observation.ComponentComponent> do_ = dn_?.Component;

                    bool? dp_(Observation.ComponentComponent C) {
                        CodeableConcept em_ = C?.Code;
                        CqlConcept en_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, em_);
                        CqlCode eo_ = this.Diastolic_blood_pressure(context);
                        CqlConcept ep_ = context.Operators.ConvertCodeToConcept(eo_);
                        bool? eq_ = context.Operators.Equivalent(en_, ep_);
                        return eq_;
                    }

                    IEnumerable<Observation.ComponentComponent> dq_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)do_, dp_);
                    Observation.ComponentComponent dr_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(dq_);
                    DataType ds_ = dr_?.Value;
                    object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                    CqlQuantity du_ = context.Operators.Quantity(90m, "mm[Hg]");
                    bool? dv_ = context.Operators.GreaterOrEqual(dt_ as CqlQuantity, du_);
                    cm_ = cl_ | dv_;
                }
                return t_ & cm_;
            }
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
                bool? o_ = context.Operators.In<CqlDateTime>(m_, n_, "day");
                bool? p_;
                // CQL 'and' (124:19-125:70): right operand skipped when left is false
                if (o_ is false)
                {
                    p_ = false;
                }
                else
                {
                    FhirDateTime r_ = ECGLabTest?.AuthoredOnElement;
                    CqlDateTime s_ = context.Operators.Convert<CqlDateTime>(r_);
                    CqlInterval<CqlDateTime> t_ = this.Measurement_Period(context);
                    bool? u_ = context.Operators.In<CqlDateTime>(s_, t_, "day");
                    p_ = o_ & u_;
                }
                bool? q_;
                // CQL 'and' (124:19-126:117): right operand skipped when left is false
                if (p_ is false)
                {
                    q_ = false;
                }
                else
                {
                    Code<RequestIntent> v_ = WeeksRescreen?.IntentElement;
                    RequestIntent? w_ = v_?.Value;
                    Code<RequestIntent> x_ = context.Operators.Convert<Code<RequestIntent>>(w_);
                    string y_ = context.Operators.Convert<string>(x_);
                    string[] z_ = [
                        "order",
                        "original-order",
                        "reflex-order",
                        "filler-order",
                        "instance-order",
                    ];
                    bool? aa_ = context.Operators.In<string>(y_, (IEnumerable<string>)z_);
                    q_ = p_ & aa_;
                }
                // CQL 'and' (124:19-127:114): right operand skipped when left is false
                if (q_ is false)
                {
                    return false;
                }
                else
                {
                    Code<RequestIntent> ab_ = ECGLabTest?.IntentElement;
                    RequestIntent? ac_ = ab_?.Value;
                    Code<RequestIntent> ad_ = context.Operators.Convert<Code<RequestIntent>>(ac_);
                    string ae_ = context.Operators.Convert<string>(ad_);
                    string[] af_ = [
                        "order",
                        "original-order",
                        "reflex-order",
                        "filler-order",
                        "instance-order",
                    ];
                    bool? ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
                    return q_ & ag_;
                }
            }

            bool? k_ = context.Operators.WhereAny<ServiceRequest>(i_, j_);
            return k_;
        }

        IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);

        bool? e_(ServiceRequest WeeksRescreen) {
            IEnumerable<ServiceRequest> ah_ = this.NonPharmacological_Interventions(context);

            bool? ai_(ServiceRequest HTNInterventions) {
                FhirDateTime ak_ = HTNInterventions?.AuthoredOnElement;
                CqlDateTime al_ = context.Operators.Convert<CqlDateTime>(ak_);
                CqlInterval<CqlDateTime> am_ = this.Measurement_Period(context);
                bool? an_ = context.Operators.In<CqlDateTime>(al_, am_, "day");
                return an_;
            }

            bool? aj_ = context.Operators.WhereAny<ServiceRequest>(ah_, ai_);
            return aj_;
        }

        IEnumerable<ServiceRequest> f_ = context.Operators.Where<ServiceRequest>(d_, e_);

        bool? g_(ServiceRequest WeeksRescreen) {
            IEnumerable<MedicationRequest> ao_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? ap_(MedicationRequest MR) {
                IEnumerable<Medication> aw_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? ax_(Medication M) {
                    object az_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object ba_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> bb_ = context.Operators.Split((string)ba_, "/");
                    string bc_ = context.Operators.Last<string>(bb_);
                    bool? bd_ = context.Operators.Equal(az_, bc_);
                    // CQL 'and': right operand skipped when left is false
                    if (bd_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        CodeableConcept be_ = M?.Code;
                        CqlConcept bf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, be_);
                        CqlValueSet bg_ = this.Pharmacologic_Therapy_for_Hypertension(context);
                        bool? bh_ = context.Operators.ConceptInValueSet(bf_, bg_);
                        return bd_ & bh_;
                    }
                }

                bool? ay_ = context.Operators.WhereAny<Medication>(aw_, ax_);
                return ay_;
            }

            IEnumerable<MedicationRequest> aq_ = context.Operators.Where<MedicationRequest>(ao_, ap_);
            CqlValueSet ar_ = this.Pharmacologic_Therapy_for_Hypertension(context);
            IEnumerable<MedicationRequest> as_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ar_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> at_ = context.Operators.Union<MedicationRequest>(aq_, as_);

            bool? au_(MedicationRequest Medications) {
                FhirDateTime bi_ = Medications?.AuthoredOnElement;
                CqlDateTime bj_ = context.Operators.Convert<CqlDateTime>(bi_);
                CqlInterval<CqlDateTime> bk_ = this.Measurement_Period(context);
                bool? bl_ = context.Operators.In<CqlDateTime>(bj_, bk_, "day");
                // CQL 'and' (131:19-132:61): right operand skipped when left is false
                if (bl_ is false)
                {
                    return false;
                }
                else
                {
                    Code<MedicationRequest.MedicationrequestStatus> bm_ = Medications?.StatusElement;
                    MedicationRequest.MedicationrequestStatus? bn_ = bm_?.Value;
                    string bo_ = context.Operators.Convert<string>(bn_);
                    string[] bp_ = [
                        "active",
                        "completed",
                    ];
                    bool? bq_ = context.Operators.In<string>(bo_, (IEnumerable<string>)bp_);
                    return bl_ & bq_;
                }
            }

            bool? av_ = context.Operators.WhereAny<MedicationRequest>(at_, au_);
            return av_;
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
                bool? n_ = context.Operators.In<CqlDateTime>(k_, m_, "day");
                return n_;
            }

            bool? i_ = context.Operators.WhereAny<ServiceRequest>(g_, h_);
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
                bool? v_ = context.Operators.In<CqlDateTime>(s_, u_, "day");
                return v_;
            }

            bool? q_ = context.Operators.WhereAny<ServiceRequest>(o_, p_);
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
                bool? v_ = context.Operators.In<CqlDateTime>(s_, u_, "day");
                // CQL 'and' (323:17-326:9): right operand skipped when left is false
                if (v_ is false)
                {
                    return false;
                }
                else
                {

                    bool? w_(Extension @this) {
                        FhirUri ae_ = @this?.UrlElement;
                        string af_ = FHIRHelpers_4_4_000.Instance.ToString(context, ae_);
                        bool? ag_ = context.Operators.Equal(af_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                        return ag_;
                    }


                    object x_(Extension @this) {
                        DataType ah_ = @this?.Value;
                        return ah_;
                    }

                    IEnumerable<object> y_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(NoBPScreen is DomainResource
                        ? (NoBPScreen as DomainResource).Extension
                        : default), w_, x_);
                    object z_ = context.Operators.SingletonFrom<object>(y_);
                    CqlConcept aa_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, z_ as CodeableConcept);
                    CqlValueSet ab_ = this.Patient_Declined(context);
                    bool? ac_ = context.Operators.ConceptInValueSet(aa_, ab_);
                    bool? ad_;
                    // CQL 'or' (324:13-326:9): right operand skipped when left is true
                    if (ac_ is true)
                    {
                        ad_ = true;
                    }
                    else
                    {

                        bool? ai_(Extension @this) {
                            FhirUri ap_ = @this?.UrlElement;
                            string aq_ = FHIRHelpers_4_4_000.Instance.ToString(context, ap_);
                            bool? ar_ = context.Operators.Equal(aq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                            return ar_;
                        }


                        object aj_(Extension @this) {
                            DataType as_ = @this?.Value;
                            return as_;
                        }

                        IEnumerable<object> ak_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(NoBPScreen is DomainResource
                            ? (NoBPScreen as DomainResource).Extension
                            : default), ai_, aj_);
                        object al_ = context.Operators.SingletonFrom<object>(ak_);
                        CqlConcept am_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, al_ as CodeableConcept);
                        CqlValueSet an_ = this.Medical_Reason(context);
                        bool? ao_ = context.Operators.ConceptInValueSet(am_, an_);
                        ad_ = ac_ | ao_;
                    }
                    return v_ & ad_;
                }
            }

            bool? p_ = context.Operators.WhereAny<Observation>(n_, o_);
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
            bool? aa_ = context.Operators.In<string>(y_, (IEnumerable<string>)z_);
            // CQL 'and' (315:5-316:66): right operand skipped when left is false
            if (aa_ is false)
            {
                return false;
            }
            else
            {

                bool? ab_(Extension @this) {
                    FhirUri ai_ = @this?.UrlElement;
                    string aj_ = FHIRHelpers_4_4_000.Instance.ToString(context, ai_);
                    bool? ak_ = context.Operators.Equal(aj_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                    return ak_;
                }


                object ac_(Extension @this) {
                    DataType al_ = @this?.Value;
                    return al_;
                }

                IEnumerable<object> ad_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(NonPharmIntervention is DomainResource
                    ? (NonPharmIntervention as DomainResource).Extension
                    : default), ab_, ac_);
                object ae_ = context.Operators.SingletonFrom<object>(ad_);
                CqlConcept af_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ae_ as CodeableConcept);
                CqlValueSet ag_ = this.Patient_Declined(context);
                bool? ah_ = context.Operators.ConceptInValueSet(af_, ag_);
                return aa_ & ah_;
            }
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
            bool? s_ = context.Operators.In<string>(q_, (IEnumerable<string>)r_);
            // CQL 'and' (387:5-388:59): right operand skipped when left is false
            if (s_ is false)
            {
                return false;
            }
            else
            {

                bool? t_(Extension @this) {
                    FhirUri aa_ = @this?.UrlElement;
                    string ab_ = FHIRHelpers_4_4_000.Instance.ToString(context, aa_);
                    bool? ac_ = context.Operators.Equal(ab_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                    return ac_;
                }


                object u_(Extension @this) {
                    DataType ad_ = @this?.Value;
                    return ad_;
                }

                IEnumerable<object> v_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(LabECGNotDone is DomainResource
                    ? (LabECGNotDone as DomainResource).Extension
                    : default), t_, u_);
                object w_ = context.Operators.SingletonFrom<object>(v_);
                CqlConcept x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, w_ as CodeableConcept);
                CqlValueSet y_ = this.Patient_Declined(context);
                bool? z_ = context.Operators.ConceptInValueSet(x_, y_);
                return s_ & z_;
            }
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
            bool? s_ = context.Operators.In<string>(q_, (IEnumerable<string>)r_);
            // CQL 'and' (364:7-365:84): right operand skipped when left is false
            if (s_ is false)
            {
                return false;
            }
            else
            {

                bool? t_(Extension @this) {
                    FhirUri aa_ = @this?.UrlElement;
                    string ab_ = FHIRHelpers_4_4_000.Instance.ToString(context, aa_);
                    bool? ac_ = context.Operators.Equal(ab_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                    return ac_;
                }


                object u_(Extension @this) {
                    DataType ad_ = @this?.Value;
                    return ad_;
                }

                IEnumerable<object> v_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(SecondHTNDeclinedReferralAndFollowUp is DomainResource
                    ? (SecondHTNDeclinedReferralAndFollowUp as DomainResource).Extension
                    : default), t_, u_);
                object w_ = context.Operators.SingletonFrom<object>(v_);
                CqlConcept x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, w_ as CodeableConcept);
                CqlValueSet y_ = this.Patient_Declined(context);
                bool? z_ = context.Operators.ConceptInValueSet(x_, y_);
                return s_ & z_;
            }
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
            bool? y_ = context.Operators.In<string>(w_, (IEnumerable<string>)x_);
            // CQL 'and' (373:9-374:91): right operand skipped when left is false
            if (y_ is false)
            {
                return false;
            }
            else
            {

                bool? z_(Extension @this) {
                    FhirUri ag_ = @this?.UrlElement;
                    string ah_ = FHIRHelpers_4_4_000.Instance.ToString(context, ag_);
                    bool? ai_ = context.Operators.Equal(ah_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                    return ai_;
                }


                object aa_(Extension @this) {
                    DataType aj_ = @this?.Value;
                    return aj_;
                }

                IEnumerable<object> ab_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(SecondHTN140Over90ReferralFollowUpNotDone is DomainResource
                    ? (SecondHTN140Over90ReferralFollowUpNotDone as DomainResource).Extension
                    : default), z_, aa_);
                object ac_ = context.Operators.SingletonFrom<object>(ab_);
                CqlConcept ad_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ac_ as CodeableConcept);
                CqlValueSet ae_ = this.Patient_Declined(context);
                bool? af_ = context.Operators.ConceptInValueSet(ad_, ae_);
                return y_ & af_;
            }
        }

        IEnumerable<ServiceRequest> i_ = context.Operators.Where<ServiceRequest>(g_, h_);
        CqlValueSet j_ = this.Pharmacologic_Therapy_for_Hypertension(context);
        IEnumerable<MedicationRequest> k_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(k_, k_);

        bool? m_(MedicationRequest MedicationRequestNotOrdered) {
            Code<MedicationRequest.MedicationrequestStatus> ak_ = MedicationRequestNotOrdered?.StatusElement;
            MedicationRequest.MedicationrequestStatus? al_ = ak_?.Value;
            string am_ = context.Operators.Convert<string>(al_);
            string[] an_ = [
                "active",
                "completed",
            ];
            bool? ao_ = context.Operators.In<string>(am_, (IEnumerable<string>)an_);
            return ao_;
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
                bool? ai_ = context.Operators.In<CqlDateTime>(af_, ah_, "day");
                bool? aj_;
                // CQL 'and' (332:21-333:94): right operand skipped when left is false
                if (ai_ is false)
                {
                    aj_ = false;
                }
                else
                {
                    Code<RequestStatus> ak_ = ElevatedBPDeclinedInterventions?.StatusElement;
                    RequestStatus? al_ = ak_?.Value;
                    Code<RequestStatus> am_ = context.Operators.Convert<Code<RequestStatus>>(al_);
                    string an_ = context.Operators.Convert<string>(am_);
                    string[] ao_ = [
                        "active",
                        "completed",
                        "on-hold",
                    ];
                    bool? ap_ = context.Operators.In<string>(an_, (IEnumerable<string>)ao_);
                    aj_ = ai_ & ap_;
                }
                // CQL 'and' (332:21-334:83): right operand skipped when left is false
                if (aj_ is false)
                {
                    return false;
                }
                else
                {

                    bool? aq_(Extension @this) {
                        FhirUri ax_ = @this?.UrlElement;
                        string ay_ = FHIRHelpers_4_4_000.Instance.ToString(context, ax_);
                        bool? az_ = context.Operators.Equal(ay_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                        return az_;
                    }


                    object ar_(Extension @this) {
                        DataType ba_ = @this?.Value;
                        return ba_;
                    }

                    IEnumerable<object> as_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(ElevatedBPDeclinedInterventions is DomainResource
                        ? (ElevatedBPDeclinedInterventions as DomainResource).Extension
                        : default), aq_, ar_);
                    object at_ = context.Operators.SingletonFrom<object>(as_);
                    CqlConcept au_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, at_ as CodeableConcept);
                    CqlValueSet av_ = this.Patient_Declined(context);
                    bool? aw_ = context.Operators.ConceptInValueSet(au_, av_);
                    return aj_ & aw_;
                }
            }

            bool? ad_ = context.Operators.WhereAny<ServiceRequest>(ab_, ac_);
            return ad_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter ElevatedBPEncounter) {
            IEnumerable<ServiceRequest> bb_ = this.NonPharmacological_Intervention_Not_Ordered(context);

            bool? bc_(ServiceRequest NotOrdered) {
                FhirDateTime be_ = NotOrdered?.AuthoredOnElement;
                CqlDateTime bf_ = context.Operators.Convert<CqlDateTime>(be_);
                Period bg_ = ElevatedBPEncounter?.Period;
                CqlInterval<CqlDateTime> bh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bg_);
                bool? bi_ = context.Operators.In<CqlDateTime>(bf_, bh_, "day");
                return bi_;
            }

            bool? bd_ = context.Operators.WhereAny<ServiceRequest>(bb_, bc_);
            return bd_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(a_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(c_, e_);
        IEnumerable<Encounter> g_ = this.Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80(context);

        bool? h_(Encounter FirstHTNEncounter) {
            CqlValueSet bj_ = this.Follow_Up_Within_4_Weeks(context);
            IEnumerable<ServiceRequest> bk_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, bj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> bl_ = context.Operators.Union<ServiceRequest>(bk_, bk_);
            CqlValueSet bm_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
            IEnumerable<ServiceRequest> bn_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, bm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> bo_ = context.Operators.Union<ServiceRequest>(bn_, bn_);
            IEnumerable<ServiceRequest> bp_ = context.Operators.Union<ServiceRequest>(bl_, bo_);

            bool? bq_(ServiceRequest FirstHTNDeclinedInterventions) {
                FhirDateTime bs_ = FirstHTNDeclinedInterventions?.AuthoredOnElement;
                CqlDateTime bt_ = context.Operators.Convert<CqlDateTime>(bs_);
                Period bu_ = FirstHTNEncounter?.Period;
                CqlInterval<CqlDateTime> bv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bu_);
                bool? bw_ = context.Operators.In<CqlDateTime>(bt_, bv_, "day");
                bool? bx_;
                // CQL 'and' (343:23-344:94): right operand skipped when left is false
                if (bw_ is false)
                {
                    bx_ = false;
                }
                else
                {
                    Code<RequestStatus> by_ = FirstHTNDeclinedInterventions?.StatusElement;
                    RequestStatus? bz_ = by_?.Value;
                    Code<RequestStatus> ca_ = context.Operators.Convert<Code<RequestStatus>>(bz_);
                    string cb_ = context.Operators.Convert<string>(ca_);
                    string[] cc_ = [
                        "active",
                        "completed",
                        "on-hold",
                    ];
                    bool? cd_ = context.Operators.In<string>(cb_, (IEnumerable<string>)cc_);
                    bx_ = bw_ & cd_;
                }
                // CQL 'and' (343:23-345:83): right operand skipped when left is false
                if (bx_ is false)
                {
                    return false;
                }
                else
                {

                    bool? ce_(Extension @this) {
                        FhirUri cl_ = @this?.UrlElement;
                        string cm_ = FHIRHelpers_4_4_000.Instance.ToString(context, cl_);
                        bool? cn_ = context.Operators.Equal(cm_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                        return cn_;
                    }


                    object cf_(Extension @this) {
                        DataType co_ = @this?.Value;
                        return co_;
                    }

                    IEnumerable<object> cg_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(FirstHTNDeclinedInterventions is DomainResource
                        ? (FirstHTNDeclinedInterventions as DomainResource).Extension
                        : default), ce_, cf_);
                    object ch_ = context.Operators.SingletonFrom<object>(cg_);
                    CqlConcept ci_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ch_ as CodeableConcept);
                    CqlValueSet cj_ = this.Patient_Declined(context);
                    bool? ck_ = context.Operators.ConceptInValueSet(ci_, cj_);
                    return bx_ & ck_;
                }
            }

            bool? br_ = context.Operators.WhereAny<ServiceRequest>(bp_, bq_);
            return br_;
        }

        IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);

        bool? j_(Encounter FirstHTNEncounter) {
            IEnumerable<ServiceRequest> cp_ = this.NonPharmacological_Intervention_Not_Ordered(context);

            bool? cq_(ServiceRequest NoNonPharm) {
                FhirDateTime cs_ = NoNonPharm?.AuthoredOnElement;
                CqlDateTime ct_ = context.Operators.Convert<CqlDateTime>(cs_);
                Period cu_ = FirstHTNEncounter?.Period;
                CqlInterval<CqlDateTime> cv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cu_);
                bool? cw_ = context.Operators.In<CqlDateTime>(ct_, cv_, "day");
                return cw_;
            }

            bool? cr_ = context.Operators.WhereAny<ServiceRequest>(cp_, cq_);
            return cr_;
        }

        IEnumerable<Encounter> k_ = context.Operators.Where<Encounter>(g_, j_);
        IEnumerable<Encounter> l_ = context.Operators.Union<Encounter>(i_, k_);
        IEnumerable<Encounter> m_ = context.Operators.Union<Encounter>(f_, l_);
        IEnumerable<Encounter> n_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89(context);

        bool? o_(Encounter SecondHTNEncounter) {
            IEnumerable<ServiceRequest> cx_ = this.Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined(context);

            bool? cy_(ServiceRequest SecondHTNDeclinedInterventions) {
                FhirDateTime da_ = SecondHTNDeclinedInterventions?.AuthoredOnElement;
                CqlDateTime db_ = context.Operators.Convert<CqlDateTime>(da_);
                Period dc_ = SecondHTNEncounter?.Period;
                CqlInterval<CqlDateTime> dd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dc_);
                bool? de_ = context.Operators.In<CqlDateTime>(db_, dd_, "day");
                return de_;
            }

            bool? cz_ = context.Operators.WhereAny<ServiceRequest>(cx_, cy_);
            return cz_;
        }

        IEnumerable<Encounter> p_ = context.Operators.Where<Encounter>(n_, o_);
        IEnumerable<Encounter> q_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90(context);

        bool? r_(Encounter SecondHTN140Over90Encounter) {
            IEnumerable<object> df_ = this.Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined(context);

            bool? dg_(object SecondHTN140Over90DeclinedInterventions) {
                object di_ = context.Operators.LateBoundProperty<object>(SecondHTN140Over90DeclinedInterventions, "authoredOn");
                CqlDateTime dj_ = context.Operators.LateBoundProperty<CqlDateTime>(di_, "value");
                Period dk_ = SecondHTN140Over90Encounter?.Period;
                CqlInterval<CqlDateTime> dl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dk_);
                bool? dm_ = context.Operators.In<CqlDateTime>(dj_, dl_, "day");
                return dm_;
            }

            bool? dh_ = context.Operators.WhereAny<object>(df_, dg_);
            return dh_;
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
