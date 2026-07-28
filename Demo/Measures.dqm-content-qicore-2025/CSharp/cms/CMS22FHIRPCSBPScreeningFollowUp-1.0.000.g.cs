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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.5.0")]
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
            Code<Encounter.EncounterStatus> j_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? k_ = j_?.Value;
            Code<Encounter.EncounterStatus> l_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(k_);
            bool? m_ = context.Operators.Equivalent(l_, "finished");
            bool? n_ = context.Operators.And(i_, m_);
            Coding o_ = ValidEncounter?.Class;
            CqlCode p_ = FHIRHelpers_4_4_000.Instance.ToCode(context, o_);
            CqlCode q_ = this.@virtual(context);
            bool? r_ = context.Operators.Equivalent(p_, q_);
            bool? s_ = context.Operators.Not(r_);
            bool? t_ = context.Operators.And(n_, s_);
            return t_;
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
        bool? c_ = context.Operators.Not((bool?)(b_ is null));
        CqlCode d_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept e_ = context.Operators.ConvertCodeToConcept(d_);
        bool? f_ = context.Operators.Equivalent(b_, e_);
        CqlCode g_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
        CqlConcept h_ = context.Operators.ConvertCodeToConcept(g_);
        bool? i_ = context.Operators.Equivalent(b_, h_);
        bool? j_ = context.Operators.Or(f_, i_);
        CqlCode k_ = QICoreCommon_4_0_000.Instance.provisional(context);
        CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
        bool? m_ = context.Operators.Equivalent(b_, l_);
        bool? n_ = context.Operators.Or(j_, m_);
        CqlCode o_ = QICoreCommon_4_0_000.Instance.differential(context);
        CqlConcept p_ = context.Operators.ConvertCodeToConcept(o_);
        bool? q_ = context.Operators.Equivalent(b_, p_);
        bool? r_ = context.Operators.Or(n_, q_);
        bool? s_ = context.Operators.Implies(c_, r_);
        return s_;
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

                CqlInterval<CqlDateTime> i_() {

                    bool o_() {
                        CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, Hypertension as Condition);
                        CqlDateTime q_ = context.Operators.Start(p_);
                        return q_ is null;
                    }

                    if (o_())
                    {
                        return default;
                    }
                    else
                    {
                        CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, Hypertension as Condition);
                        CqlDateTime s_ = context.Operators.Start(r_);
                        CqlInterval<CqlDateTime> t_ = context.Operators.Interval(s_, s_, true, true);
                        return t_;
                    }
                }

                Period j_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, j_);
                bool? l_ = context.Operators.SameOrBefore(i_(), k_, "day");
                bool? m_ = this.isVerified(context, Hypertension as Condition);
                bool? n_ = context.Operators.And(l_, m_);
                return n_;
            }

            IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
            bool? h_ = context.Operators.Exists<Condition>(g_);
            return h_;
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
                DataType ai_ = BloodPressure?.Effective;
                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                CqlInterval<CqlDateTime> ak_ = QICoreCommon_4_0_000.Instance.toInterval(context, aj_);
                CqlDateTime al_ = context.Operators.End(ak_);
                Period am_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> an_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, am_);
                bool? ao_ = context.Operators.In<CqlDateTime>(al_, an_, "day");
                Code<ObservationStatus> ap_ = BloodPressure?.StatusElement;
                ObservationStatus? aq_ = ap_?.Value;
                string ar_ = context.Operators.Convert<string>(aq_);
                string[] as_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? at_ = context.Operators.In<string>(ar_, (IEnumerable<string>)as_);
                bool? au_ = context.Operators.And(ao_, at_);
                return au_;
            }

            IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);

            object g_(Observation @this) {
                DataType av_ = @this?.Effective;
                object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                CqlInterval<CqlDateTime> ax_ = QICoreCommon_4_0_000.Instance.toInterval(context, aw_);
                CqlDateTime ay_ = context.Operators.Start(ax_);
                return ay_;
            }

            IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
            Observation i_ = context.Operators.Last<Observation>(h_);
            List<Observation.ComponentComponent> j_ = i_?.Component;

            bool? k_(Observation.ComponentComponent C) {
                CodeableConcept az_ = C?.Code;
                CqlConcept ba_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, az_);
                CqlCode bb_ = this.Systolic_blood_pressure(context);
                CqlConcept bc_ = context.Operators.ConvertCodeToConcept(bb_);
                bool? bd_ = context.Operators.Equivalent(ba_, bc_);
                return bd_;
            }

            IEnumerable<Observation.ComponentComponent> l_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)j_, k_);
            Observation.ComponentComponent m_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            CqlQuantity p_ = context.Operators.Quantity(1m, "mm[Hg]");
            CqlQuantity q_ = context.Operators.Quantity(120m, "mm[Hg]");
            CqlInterval<CqlQuantity> r_ = context.Operators.Interval(p_, q_, true, false);
            bool? s_ = context.Operators.In<CqlQuantity>(o_ as CqlQuantity, r_, (string)default);

            bool? t_(Observation BloodPressure) {
                DataType be_ = BloodPressure?.Effective;
                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                CqlInterval<CqlDateTime> bg_ = QICoreCommon_4_0_000.Instance.toInterval(context, bf_);
                CqlDateTime bh_ = context.Operators.End(bg_);
                Period bi_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bi_);
                bool? bk_ = context.Operators.In<CqlDateTime>(bh_, bj_, "day");
                Code<ObservationStatus> bl_ = BloodPressure?.StatusElement;
                ObservationStatus? bm_ = bl_?.Value;
                string bn_ = context.Operators.Convert<string>(bm_);
                string[] bo_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bp_ = context.Operators.In<string>(bn_, (IEnumerable<string>)bo_);
                bool? bq_ = context.Operators.And(bk_, bp_);
                return bq_;
            }

            IEnumerable<Observation> u_ = context.Operators.Where<Observation>(d_, t_);

            object v_(Observation @this) {
                DataType br_ = @this?.Effective;
                object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                CqlInterval<CqlDateTime> bt_ = QICoreCommon_4_0_000.Instance.toInterval(context, bs_);
                CqlDateTime bu_ = context.Operators.Start(bt_);
                return bu_;
            }

            IEnumerable<Observation> w_ = context.Operators.SortBy<Observation>(u_, v_, System.ComponentModel.ListSortDirection.Ascending);
            Observation x_ = context.Operators.Last<Observation>(w_);
            List<Observation.ComponentComponent> y_ = x_?.Component;

            bool? z_(Observation.ComponentComponent C) {
                CodeableConcept bv_ = C?.Code;
                CqlConcept bw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bv_);
                CqlCode bx_ = this.Diastolic_blood_pressure(context);
                CqlConcept by_ = context.Operators.ConvertCodeToConcept(bx_);
                bool? bz_ = context.Operators.Equivalent(bw_, by_);
                return bz_;
            }

            IEnumerable<Observation.ComponentComponent> aa_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)y_, z_);
            Observation.ComponentComponent ab_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(aa_);
            DataType ac_ = ab_?.Value;
            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
            CqlQuantity ae_ = context.Operators.Quantity(80m, "mm[Hg]");
            CqlInterval<CqlQuantity> af_ = context.Operators.Interval(p_, ae_, true, false);
            bool? ag_ = context.Operators.In<CqlQuantity>(ad_ as CqlQuantity, af_, (string)default);
            bool? ah_ = context.Operators.And(s_, ag_);
            return ah_;
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
                DataType aj_ = BloodPressure?.Effective;
                object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                CqlInterval<CqlDateTime> al_ = QICoreCommon_4_0_000.Instance.toInterval(context, ak_);
                CqlDateTime am_ = context.Operators.End(al_);
                Period an_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> ao_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, an_);
                bool? ap_ = context.Operators.In<CqlDateTime>(am_, ao_, "day");
                Code<ObservationStatus> aq_ = BloodPressure?.StatusElement;
                ObservationStatus? ar_ = aq_?.Value;
                string as_ = context.Operators.Convert<string>(ar_);
                string[] at_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? au_ = context.Operators.In<string>(as_, (IEnumerable<string>)at_);
                bool? av_ = context.Operators.And(ap_, au_);
                return av_;
            }

            IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);

            object g_(Observation @this) {
                DataType aw_ = @this?.Effective;
                object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                CqlInterval<CqlDateTime> ay_ = QICoreCommon_4_0_000.Instance.toInterval(context, ax_);
                CqlDateTime az_ = context.Operators.Start(ay_);
                return az_;
            }

            IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
            Observation i_ = context.Operators.Last<Observation>(h_);
            List<Observation.ComponentComponent> j_ = i_?.Component;

            bool? k_(Observation.ComponentComponent C) {
                CodeableConcept ba_ = C?.Code;
                CqlConcept bb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ba_);
                CqlCode bc_ = this.Systolic_blood_pressure(context);
                CqlConcept bd_ = context.Operators.ConvertCodeToConcept(bc_);
                bool? be_ = context.Operators.Equivalent(bb_, bd_);
                return be_;
            }

            IEnumerable<Observation.ComponentComponent> l_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)j_, k_);
            Observation.ComponentComponent m_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            CqlQuantity p_ = context.Operators.Quantity(120m, "mm[Hg]");
            CqlQuantity q_ = context.Operators.Quantity(129m, "mm[Hg]");
            CqlInterval<CqlQuantity> r_ = context.Operators.Interval(p_, q_, true, true);
            bool? s_ = context.Operators.In<CqlQuantity>(o_ as CqlQuantity, r_, (string)default);

            bool? t_(Observation BloodPressure) {
                DataType bf_ = BloodPressure?.Effective;
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                CqlInterval<CqlDateTime> bh_ = QICoreCommon_4_0_000.Instance.toInterval(context, bg_);
                CqlDateTime bi_ = context.Operators.End(bh_);
                Period bj_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> bk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bj_);
                bool? bl_ = context.Operators.In<CqlDateTime>(bi_, bk_, "day");
                Code<ObservationStatus> bm_ = BloodPressure?.StatusElement;
                ObservationStatus? bn_ = bm_?.Value;
                string bo_ = context.Operators.Convert<string>(bn_);
                string[] bp_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bq_ = context.Operators.In<string>(bo_, (IEnumerable<string>)bp_);
                bool? br_ = context.Operators.And(bl_, bq_);
                return br_;
            }

            IEnumerable<Observation> u_ = context.Operators.Where<Observation>(d_, t_);

            object v_(Observation @this) {
                DataType bs_ = @this?.Effective;
                object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                CqlInterval<CqlDateTime> bu_ = QICoreCommon_4_0_000.Instance.toInterval(context, bt_);
                CqlDateTime bv_ = context.Operators.Start(bu_);
                return bv_;
            }

            IEnumerable<Observation> w_ = context.Operators.SortBy<Observation>(u_, v_, System.ComponentModel.ListSortDirection.Ascending);
            Observation x_ = context.Operators.Last<Observation>(w_);
            List<Observation.ComponentComponent> y_ = x_?.Component;

            bool? z_(Observation.ComponentComponent C) {
                CodeableConcept bw_ = C?.Code;
                CqlConcept bx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bw_);
                CqlCode by_ = this.Diastolic_blood_pressure(context);
                CqlConcept bz_ = context.Operators.ConvertCodeToConcept(by_);
                bool? ca_ = context.Operators.Equivalent(bx_, bz_);
                return ca_;
            }

            IEnumerable<Observation.ComponentComponent> aa_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)y_, z_);
            Observation.ComponentComponent ab_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(aa_);
            DataType ac_ = ab_?.Value;
            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
            CqlQuantity ae_ = context.Operators.Quantity(1m, "mm[Hg]");
            CqlQuantity af_ = context.Operators.Quantity(80m, "mm[Hg]");
            CqlInterval<CqlQuantity> ag_ = context.Operators.Interval(ae_, af_, true, false);
            bool? ah_ = context.Operators.In<CqlQuantity>(ad_ as CqlQuantity, ag_, (string)default);
            bool? ai_ = context.Operators.And(s_, ah_);
            return ai_;
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
                CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return q_;
            }

            IEnumerable<CqlConcept> g_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)e_, f_);
            CqlValueSet h_ = this.Finding_of_Elevated_Blood_Pressure_or_Hypertension(context);
            bool? i_ = context.Operators.ConceptsInValueSet(g_, h_);
            Code<RequestIntent> j_ = Referral?.IntentElement;
            RequestIntent? k_ = j_?.Value;
            Code<RequestIntent> l_ = context.Operators.Convert<Code<RequestIntent>>(k_);
            string m_ = context.Operators.Convert<string>(l_);
            string[] n_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);
            bool? p_ = context.Operators.And(i_, o_);
            return p_;
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
                FhirDateTime m_ = Twoto6MonthRescreen?.AuthoredOnElement;
                CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
                Period o_ = ElevatedEncounter?.Period;
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                bool? q_ = context.Operators.In<CqlDateTime>(n_, p_, "day");
                return q_;
            }

            IEnumerable<ServiceRequest> k_ = context.Operators.Where<ServiceRequest>(i_, j_);
            bool? l_ = context.Operators.Exists<ServiceRequest>(k_);
            return l_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter ElevatedEncounter) {
            IEnumerable<ServiceRequest> r_ = this.NonPharmacological_Interventions(context);

            bool? s_(ServiceRequest NonPharmInterventions) {
                FhirDateTime v_ = NonPharmInterventions?.AuthoredOnElement;
                CqlDateTime w_ = context.Operators.Convert<CqlDateTime>(v_);
                Period x_ = ElevatedEncounter?.Period;
                CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, x_);
                bool? z_ = context.Operators.In<CqlDateTime>(w_, y_, "day");
                return z_;
            }

            IEnumerable<ServiceRequest> t_ = context.Operators.Where<ServiceRequest>(r_, s_);
            bool? u_ = context.Operators.Exists<ServiceRequest>(t_);
            return u_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);

        bool? f_(Encounter ElevatedEncounter) {
            IEnumerable<ServiceRequest> aa_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(context);

            bool? ab_(ServiceRequest Referral) {
                FhirDateTime ae_ = Referral?.AuthoredOnElement;
                CqlDateTime af_ = context.Operators.Convert<CqlDateTime>(ae_);
                Period ag_ = ElevatedEncounter?.Period;
                CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
                bool? ai_ = context.Operators.In<CqlDateTime>(af_, ah_, "day");
                return ai_;
            }

            IEnumerable<ServiceRequest> ac_ = context.Operators.Where<ServiceRequest>(aa_, ab_);
            bool? ad_ = context.Operators.Exists<ServiceRequest>(ac_);
            return ad_;
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
                DataType bg_ = BloodPressure?.Effective;
                object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                CqlInterval<CqlDateTime> bi_ = QICoreCommon_4_0_000.Instance.toInterval(context, bh_);
                CqlDateTime bj_ = context.Operators.End(bi_);
                Period bk_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> bl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bk_);
                CqlDateTime bm_ = context.Operators.Start(bl_);
                CqlQuantity bn_ = context.Operators.Quantity(1m, "year");
                CqlDateTime bo_ = context.Operators.Subtract(bm_, bn_);
                CqlInterval<CqlDateTime> bp_ = context.Operators.Interval(bo_, bm_, true, true);
                bool? bq_ = context.Operators.In<CqlDateTime>(bj_, bp_, (string)default);
                bool? br_ = context.Operators.Not((bool?)(bm_ is null));
                bool? bs_ = context.Operators.And(bq_, br_);
                Code<ObservationStatus> bt_ = BloodPressure?.StatusElement;
                ObservationStatus? bu_ = bt_?.Value;
                string bv_ = context.Operators.Convert<string>(bu_);
                string[] bw_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bx_ = context.Operators.In<string>(bv_, (IEnumerable<string>)bw_);
                bool? by_ = context.Operators.And(bs_, bx_);
                return by_;
            }

            IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);

            object g_(Observation @this) {
                DataType bz_ = @this?.Effective;
                object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                CqlInterval<CqlDateTime> cb_ = QICoreCommon_4_0_000.Instance.toInterval(context, ca_);
                CqlDateTime cc_ = context.Operators.Start(cb_);
                return cc_;
            }

            IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
            Observation i_ = context.Operators.Last<Observation>(h_);
            List<Observation.ComponentComponent> j_ = i_?.Component;

            bool? k_(Observation.ComponentComponent C) {
                CodeableConcept cd_ = C?.Code;
                CqlConcept ce_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cd_);
                CqlCode cf_ = this.Systolic_blood_pressure(context);
                CqlConcept cg_ = context.Operators.ConvertCodeToConcept(cf_);
                bool? ch_ = context.Operators.Equivalent(ce_, cg_);
                return ch_;
            }

            IEnumerable<Observation.ComponentComponent> l_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)j_, k_);
            Observation.ComponentComponent m_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            CqlQuantity p_ = context.Operators.Quantity(0m, "mm[Hg]");
            bool? q_ = context.Operators.Greater(o_ as CqlQuantity, p_);

            bool? r_(Observation BloodPressure) {
                DataType ci_ = BloodPressure?.Effective;
                object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                CqlInterval<CqlDateTime> ck_ = QICoreCommon_4_0_000.Instance.toInterval(context, cj_);
                CqlDateTime cl_ = context.Operators.End(ck_);
                Period cm_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> cn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cm_);
                CqlDateTime co_ = context.Operators.Start(cn_);
                CqlQuantity cp_ = context.Operators.Quantity(1m, "year");
                CqlDateTime cq_ = context.Operators.Subtract(co_, cp_);
                CqlInterval<CqlDateTime> cr_ = context.Operators.Interval(cq_, co_, true, true);
                bool? cs_ = context.Operators.In<CqlDateTime>(cl_, cr_, (string)default);
                bool? ct_ = context.Operators.Not((bool?)(co_ is null));
                bool? cu_ = context.Operators.And(cs_, ct_);
                Code<ObservationStatus> cv_ = BloodPressure?.StatusElement;
                ObservationStatus? cw_ = cv_?.Value;
                string cx_ = context.Operators.Convert<string>(cw_);
                string[] cy_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? cz_ = context.Operators.In<string>(cx_, (IEnumerable<string>)cy_);
                bool? da_ = context.Operators.And(cu_, cz_);
                return da_;
            }

            IEnumerable<Observation> s_ = context.Operators.Where<Observation>(d_, r_);

            object t_(Observation @this) {
                DataType db_ = @this?.Effective;
                object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                CqlInterval<CqlDateTime> dd_ = QICoreCommon_4_0_000.Instance.toInterval(context, dc_);
                CqlDateTime de_ = context.Operators.Start(dd_);
                return de_;
            }

            IEnumerable<Observation> u_ = context.Operators.SortBy<Observation>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
            Observation v_ = context.Operators.Last<Observation>(u_);
            List<Observation.ComponentComponent> w_ = v_?.Component;

            bool? x_(Observation.ComponentComponent C) {
                CodeableConcept df_ = C?.Code;
                CqlConcept dg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, df_);
                CqlCode dh_ = this.Diastolic_blood_pressure(context);
                CqlConcept di_ = context.Operators.ConvertCodeToConcept(dh_);
                bool? dj_ = context.Operators.Equivalent(dg_, di_);
                return dj_;
            }

            IEnumerable<Observation.ComponentComponent> y_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)w_, x_);
            Observation.ComponentComponent z_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(y_);
            DataType aa_ = z_?.Value;
            object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
            bool? ac_ = context.Operators.Greater(ab_ as CqlQuantity, p_);
            bool? ad_ = context.Operators.And(q_, ac_);

            bool? ae_(Observation BloodPressure) {
                DataType dk_ = BloodPressure?.Effective;
                object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                CqlInterval<CqlDateTime> dm_ = QICoreCommon_4_0_000.Instance.toInterval(context, dl_);
                CqlDateTime dn_ = context.Operators.End(dm_);
                Period do_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> dp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, do_);
                CqlDateTime dq_ = context.Operators.Start(dp_);
                CqlQuantity dr_ = context.Operators.Quantity(1m, "year");
                CqlDateTime ds_ = context.Operators.Subtract(dq_, dr_);
                CqlInterval<CqlDateTime> dt_ = context.Operators.Interval(ds_, dq_, true, true);
                bool? du_ = context.Operators.In<CqlDateTime>(dn_, dt_, (string)default);
                bool? dv_ = context.Operators.Not((bool?)(dq_ is null));
                bool? dw_ = context.Operators.And(du_, dv_);
                Code<ObservationStatus> dx_ = BloodPressure?.StatusElement;
                ObservationStatus? dy_ = dx_?.Value;
                string dz_ = context.Operators.Convert<string>(dy_);
                string[] ea_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? eb_ = context.Operators.In<string>(dz_, (IEnumerable<string>)ea_);
                bool? ec_ = context.Operators.And(dw_, eb_);
                return ec_;
            }

            IEnumerable<Observation> af_ = context.Operators.Where<Observation>(d_, ae_);

            object ag_(Observation @this) {
                DataType ed_ = @this?.Effective;
                object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                CqlInterval<CqlDateTime> ef_ = QICoreCommon_4_0_000.Instance.toInterval(context, ee_);
                CqlDateTime eg_ = context.Operators.Start(ef_);
                return eg_;
            }

            IEnumerable<Observation> ah_ = context.Operators.SortBy<Observation>(af_, ag_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ai_ = context.Operators.Last<Observation>(ah_);
            List<Observation.ComponentComponent> aj_ = ai_?.Component;

            bool? ak_(Observation.ComponentComponent C) {
                CodeableConcept eh_ = C?.Code;
                CqlConcept ei_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, eh_);
                CqlCode ej_ = this.Systolic_blood_pressure(context);
                CqlConcept ek_ = context.Operators.ConvertCodeToConcept(ej_);
                bool? el_ = context.Operators.Equivalent(ei_, ek_);
                return el_;
            }

            IEnumerable<Observation.ComponentComponent> al_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)aj_, ak_);
            Observation.ComponentComponent am_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(al_);
            DataType an_ = am_?.Value;
            object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
            CqlQuantity ap_ = context.Operators.Quantity(130m, "mm[Hg]");
            bool? aq_ = context.Operators.GreaterOrEqual(ao_ as CqlQuantity, ap_);

            bool? ar_(Observation BloodPressure) {
                DataType em_ = BloodPressure?.Effective;
                object en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
                CqlInterval<CqlDateTime> eo_ = QICoreCommon_4_0_000.Instance.toInterval(context, en_);
                CqlDateTime ep_ = context.Operators.End(eo_);
                Period eq_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> er_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eq_);
                CqlDateTime es_ = context.Operators.Start(er_);
                CqlQuantity et_ = context.Operators.Quantity(1m, "year");
                CqlDateTime eu_ = context.Operators.Subtract(es_, et_);
                CqlInterval<CqlDateTime> ev_ = context.Operators.Interval(eu_, es_, true, true);
                bool? ew_ = context.Operators.In<CqlDateTime>(ep_, ev_, (string)default);
                bool? ex_ = context.Operators.Not((bool?)(es_ is null));
                bool? ey_ = context.Operators.And(ew_, ex_);
                Code<ObservationStatus> ez_ = BloodPressure?.StatusElement;
                ObservationStatus? fa_ = ez_?.Value;
                string fb_ = context.Operators.Convert<string>(fa_);
                string[] fc_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? fd_ = context.Operators.In<string>(fb_, (IEnumerable<string>)fc_);
                bool? fe_ = context.Operators.And(ey_, fd_);
                return fe_;
            }

            IEnumerable<Observation> as_ = context.Operators.Where<Observation>(d_, ar_);

            object at_(Observation @this) {
                DataType ff_ = @this?.Effective;
                object fg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ff_);
                CqlInterval<CqlDateTime> fh_ = QICoreCommon_4_0_000.Instance.toInterval(context, fg_);
                CqlDateTime fi_ = context.Operators.Start(fh_);
                return fi_;
            }

            IEnumerable<Observation> au_ = context.Operators.SortBy<Observation>(as_, at_, System.ComponentModel.ListSortDirection.Ascending);
            Observation av_ = context.Operators.Last<Observation>(au_);
            List<Observation.ComponentComponent> aw_ = av_?.Component;

            bool? ax_(Observation.ComponentComponent C) {
                CodeableConcept fj_ = C?.Code;
                CqlConcept fk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fj_);
                CqlCode fl_ = this.Diastolic_blood_pressure(context);
                CqlConcept fm_ = context.Operators.ConvertCodeToConcept(fl_);
                bool? fn_ = context.Operators.Equivalent(fk_, fm_);
                return fn_;
            }

            IEnumerable<Observation.ComponentComponent> ay_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)aw_, ax_);
            Observation.ComponentComponent az_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ay_);
            DataType ba_ = az_?.Value;
            object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
            CqlQuantity bc_ = context.Operators.Quantity(80m, "mm[Hg]");
            bool? bd_ = context.Operators.GreaterOrEqual(bb_ as CqlQuantity, bc_);
            bool? be_ = context.Operators.Or(aq_, bd_);
            bool? bf_ = context.Operators.And(ad_, be_);
            return bf_;
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
                DataType bi_ = BloodPressure?.Effective;
                object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                CqlInterval<CqlDateTime> bk_ = QICoreCommon_4_0_000.Instance.toInterval(context, bj_);
                CqlDateTime bl_ = context.Operators.End(bk_);
                Period bm_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> bn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bm_);
                bool? bo_ = context.Operators.In<CqlDateTime>(bl_, bn_, "day");
                Code<ObservationStatus> bp_ = BloodPressure?.StatusElement;
                ObservationStatus? bq_ = bp_?.Value;
                string br_ = context.Operators.Convert<string>(bq_);
                string[] bs_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bt_ = context.Operators.In<string>(br_, (IEnumerable<string>)bs_);
                bool? bu_ = context.Operators.And(bo_, bt_);
                return bu_;
            }

            IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);

            object i_(Observation @this) {
                DataType bv_ = @this?.Effective;
                object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                CqlInterval<CqlDateTime> bx_ = QICoreCommon_4_0_000.Instance.toInterval(context, bw_);
                CqlDateTime by_ = context.Operators.Start(bx_);
                return by_;
            }

            IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Observation k_ = context.Operators.Last<Observation>(j_);
            List<Observation.ComponentComponent> l_ = k_?.Component;

            bool? m_(Observation.ComponentComponent C) {
                CodeableConcept bz_ = C?.Code;
                CqlConcept ca_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bz_);
                CqlCode cb_ = this.Systolic_blood_pressure(context);
                CqlConcept cc_ = context.Operators.ConvertCodeToConcept(cb_);
                bool? cd_ = context.Operators.Equivalent(ca_, cc_);
                return cd_;
            }

            IEnumerable<Observation.ComponentComponent> n_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)l_, m_);
            Observation.ComponentComponent o_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(n_);
            DataType p_ = o_?.Value;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlQuantity r_ = context.Operators.Quantity(0m, "mm[Hg]");
            bool? s_ = context.Operators.Greater(q_ as CqlQuantity, r_);

            bool? t_(Observation BloodPressure) {
                DataType ce_ = BloodPressure?.Effective;
                object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                CqlInterval<CqlDateTime> cg_ = QICoreCommon_4_0_000.Instance.toInterval(context, cf_);
                CqlDateTime ch_ = context.Operators.End(cg_);
                Period ci_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> cj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ci_);
                bool? ck_ = context.Operators.In<CqlDateTime>(ch_, cj_, "day");
                Code<ObservationStatus> cl_ = BloodPressure?.StatusElement;
                ObservationStatus? cm_ = cl_?.Value;
                string cn_ = context.Operators.Convert<string>(cm_);
                string[] co_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? cp_ = context.Operators.In<string>(cn_, (IEnumerable<string>)co_);
                bool? cq_ = context.Operators.And(ck_, cp_);
                return cq_;
            }

            IEnumerable<Observation> u_ = context.Operators.Where<Observation>(f_, t_);

            object v_(Observation @this) {
                DataType cr_ = @this?.Effective;
                object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                CqlInterval<CqlDateTime> ct_ = QICoreCommon_4_0_000.Instance.toInterval(context, cs_);
                CqlDateTime cu_ = context.Operators.Start(ct_);
                return cu_;
            }

            IEnumerable<Observation> w_ = context.Operators.SortBy<Observation>(u_, v_, System.ComponentModel.ListSortDirection.Ascending);
            Observation x_ = context.Operators.Last<Observation>(w_);
            List<Observation.ComponentComponent> y_ = x_?.Component;

            bool? z_(Observation.ComponentComponent C) {
                CodeableConcept cv_ = C?.Code;
                CqlConcept cw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cv_);
                CqlCode cx_ = this.Diastolic_blood_pressure(context);
                CqlConcept cy_ = context.Operators.ConvertCodeToConcept(cx_);
                bool? cz_ = context.Operators.Equivalent(cw_, cy_);
                return cz_;
            }

            IEnumerable<Observation.ComponentComponent> aa_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)y_, z_);
            Observation.ComponentComponent ab_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(aa_);
            DataType ac_ = ab_?.Value;
            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
            bool? ae_ = context.Operators.Greater(ad_ as CqlQuantity, r_);
            bool? af_ = context.Operators.And(s_, ae_);

            bool? ag_(Observation BloodPressure) {
                DataType da_ = BloodPressure?.Effective;
                object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                CqlInterval<CqlDateTime> dc_ = QICoreCommon_4_0_000.Instance.toInterval(context, db_);
                CqlDateTime dd_ = context.Operators.End(dc_);
                Period de_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> df_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, de_);
                bool? dg_ = context.Operators.In<CqlDateTime>(dd_, df_, "day");
                Code<ObservationStatus> dh_ = BloodPressure?.StatusElement;
                ObservationStatus? di_ = dh_?.Value;
                string dj_ = context.Operators.Convert<string>(di_);
                string[] dk_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? dl_ = context.Operators.In<string>(dj_, (IEnumerable<string>)dk_);
                bool? dm_ = context.Operators.And(dg_, dl_);
                return dm_;
            }

            IEnumerable<Observation> ah_ = context.Operators.Where<Observation>(f_, ag_);

            object ai_(Observation @this) {
                DataType dn_ = @this?.Effective;
                object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                CqlInterval<CqlDateTime> dp_ = QICoreCommon_4_0_000.Instance.toInterval(context, do_);
                CqlDateTime dq_ = context.Operators.Start(dp_);
                return dq_;
            }

            IEnumerable<Observation> aj_ = context.Operators.SortBy<Observation>(ah_, ai_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ak_ = context.Operators.Last<Observation>(aj_);
            List<Observation.ComponentComponent> al_ = ak_?.Component;

            bool? am_(Observation.ComponentComponent C) {
                CodeableConcept dr_ = C?.Code;
                CqlConcept ds_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dr_);
                CqlCode dt_ = this.Systolic_blood_pressure(context);
                CqlConcept du_ = context.Operators.ConvertCodeToConcept(dt_);
                bool? dv_ = context.Operators.Equivalent(ds_, du_);
                return dv_;
            }

            IEnumerable<Observation.ComponentComponent> an_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)al_, am_);
            Observation.ComponentComponent ao_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(an_);
            DataType ap_ = ao_?.Value;
            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
            CqlQuantity ar_ = context.Operators.Quantity(130m, "mm[Hg]");
            bool? as_ = context.Operators.GreaterOrEqual(aq_ as CqlQuantity, ar_);

            bool? at_(Observation BloodPressure) {
                DataType dw_ = BloodPressure?.Effective;
                object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                CqlInterval<CqlDateTime> dy_ = QICoreCommon_4_0_000.Instance.toInterval(context, dx_);
                CqlDateTime dz_ = context.Operators.End(dy_);
                Period ea_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> eb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ea_);
                bool? ec_ = context.Operators.In<CqlDateTime>(dz_, eb_, "day");
                Code<ObservationStatus> ed_ = BloodPressure?.StatusElement;
                ObservationStatus? ee_ = ed_?.Value;
                string ef_ = context.Operators.Convert<string>(ee_);
                string[] eg_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? eh_ = context.Operators.In<string>(ef_, (IEnumerable<string>)eg_);
                bool? ei_ = context.Operators.And(ec_, eh_);
                return ei_;
            }

            IEnumerable<Observation> au_ = context.Operators.Where<Observation>(f_, at_);

            object av_(Observation @this) {
                DataType ej_ = @this?.Effective;
                object ek_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ej_);
                CqlInterval<CqlDateTime> el_ = QICoreCommon_4_0_000.Instance.toInterval(context, ek_);
                CqlDateTime em_ = context.Operators.Start(el_);
                return em_;
            }

            IEnumerable<Observation> aw_ = context.Operators.SortBy<Observation>(au_, av_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ax_ = context.Operators.Last<Observation>(aw_);
            List<Observation.ComponentComponent> ay_ = ax_?.Component;

            bool? az_(Observation.ComponentComponent C) {
                CodeableConcept en_ = C?.Code;
                CqlConcept eo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, en_);
                CqlCode ep_ = this.Diastolic_blood_pressure(context);
                CqlConcept eq_ = context.Operators.ConvertCodeToConcept(ep_);
                bool? er_ = context.Operators.Equivalent(eo_, eq_);
                return er_;
            }

            IEnumerable<Observation.ComponentComponent> ba_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ay_, az_);
            Observation.ComponentComponent bb_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ba_);
            DataType bc_ = bb_?.Value;
            object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
            CqlQuantity be_ = context.Operators.Quantity(80m, "mm[Hg]");
            bool? bf_ = context.Operators.GreaterOrEqual(bd_ as CqlQuantity, be_);
            bool? bg_ = context.Operators.Or(as_, bf_);
            bool? bh_ = context.Operators.And(af_, bg_);
            return bh_;
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
                FhirDateTime k_ = FourWeekRescreen?.AuthoredOnElement;
                CqlDateTime l_ = context.Operators.Convert<CqlDateTime>(k_);
                CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
                bool? n_ = context.Operators.In<CqlDateTime>(l_, m_, "day");
                FhirDateTime o_ = NonPharmInterventionsHTN?.AuthoredOnElement;
                CqlDateTime p_ = context.Operators.Convert<CqlDateTime>(o_);
                bool? q_ = context.Operators.In<CqlDateTime>(p_, m_, "day");
                bool? r_ = context.Operators.And(n_, q_);
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
                bool? y_ = context.Operators.And(r_, x_);
                return y_;
            }

            IEnumerable<ServiceRequest> i_ = context.Operators.Where<ServiceRequest>(g_, h_);
            bool? j_ = context.Operators.Exists<ServiceRequest>(i_);
            return j_;
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
                FhirDateTime h_ = FirstHTNIntervention?.AuthoredOnElement;
                CqlDateTime i_ = context.Operators.Convert<CqlDateTime>(h_);
                Period j_ = FirstHTNEncounter?.Period;
                CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, j_);
                bool? l_ = context.Operators.In<CqlDateTime>(i_, k_, "day");
                return l_;
            }

            IEnumerable<ServiceRequest> f_ = context.Operators.Where<ServiceRequest>(d_, e_);
            bool? g_ = context.Operators.Exists<ServiceRequest>(f_);
            return g_;
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
                DataType bo_ = BloodPressure?.Effective;
                object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                CqlInterval<CqlDateTime> bq_ = QICoreCommon_4_0_000.Instance.toInterval(context, bp_);
                CqlDateTime br_ = context.Operators.End(bq_);
                Period bs_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> bt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bs_);
                bool? bu_ = context.Operators.In<CqlDateTime>(br_, bt_, "day");
                Code<ObservationStatus> bv_ = BloodPressure?.StatusElement;
                ObservationStatus? bw_ = bv_?.Value;
                string bx_ = context.Operators.Convert<string>(bw_);
                string[] by_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bz_ = context.Operators.In<string>(bx_, (IEnumerable<string>)by_);
                bool? ca_ = context.Operators.And(bu_, bz_);
                return ca_;
            }

            IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);

            object i_(Observation @this) {
                DataType cb_ = @this?.Effective;
                object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                CqlInterval<CqlDateTime> cd_ = QICoreCommon_4_0_000.Instance.toInterval(context, cc_);
                CqlDateTime ce_ = context.Operators.Start(cd_);
                return ce_;
            }

            IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Observation k_ = context.Operators.Last<Observation>(j_);
            List<Observation.ComponentComponent> l_ = k_?.Component;

            bool? m_(Observation.ComponentComponent C) {
                CodeableConcept cf_ = C?.Code;
                CqlConcept cg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cf_);
                CqlCode ch_ = this.Systolic_blood_pressure(context);
                CqlConcept ci_ = context.Operators.ConvertCodeToConcept(ch_);
                bool? cj_ = context.Operators.Equivalent(cg_, ci_);
                return cj_;
            }

            IEnumerable<Observation.ComponentComponent> n_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)l_, m_);
            Observation.ComponentComponent o_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(n_);
            DataType p_ = o_?.Value;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlQuantity r_ = context.Operators.Quantity(130m, "mm[Hg]");
            CqlQuantity s_ = context.Operators.Quantity(139m, "mm[Hg]");
            CqlInterval<CqlQuantity> t_ = context.Operators.Interval(r_, s_, true, true);
            bool? u_ = context.Operators.In<CqlQuantity>(q_ as CqlQuantity, t_, (string)default);

            bool? v_(Observation BloodPressure) {
                DataType ck_ = BloodPressure?.Effective;
                object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                CqlInterval<CqlDateTime> cm_ = QICoreCommon_4_0_000.Instance.toInterval(context, cl_);
                CqlDateTime cn_ = context.Operators.End(cm_);
                Period co_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> cp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, co_);
                bool? cq_ = context.Operators.In<CqlDateTime>(cn_, cp_, "day");
                Code<ObservationStatus> cr_ = BloodPressure?.StatusElement;
                ObservationStatus? cs_ = cr_?.Value;
                string ct_ = context.Operators.Convert<string>(cs_);
                string[] cu_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? cv_ = context.Operators.In<string>(ct_, (IEnumerable<string>)cu_);
                bool? cw_ = context.Operators.And(cq_, cv_);
                return cw_;
            }

            IEnumerable<Observation> w_ = context.Operators.Where<Observation>(f_, v_);

            object x_(Observation @this) {
                DataType cx_ = @this?.Effective;
                object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                CqlInterval<CqlDateTime> cz_ = QICoreCommon_4_0_000.Instance.toInterval(context, cy_);
                CqlDateTime da_ = context.Operators.Start(cz_);
                return da_;
            }

            IEnumerable<Observation> y_ = context.Operators.SortBy<Observation>(w_, x_, System.ComponentModel.ListSortDirection.Ascending);
            Observation z_ = context.Operators.Last<Observation>(y_);
            List<Observation.ComponentComponent> aa_ = z_?.Component;

            bool? ab_(Observation.ComponentComponent C) {
                CodeableConcept db_ = C?.Code;
                CqlConcept dc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, db_);
                CqlCode dd_ = this.Diastolic_blood_pressure(context);
                CqlConcept de_ = context.Operators.ConvertCodeToConcept(dd_);
                bool? df_ = context.Operators.Equivalent(dc_, de_);
                return df_;
            }

            IEnumerable<Observation.ComponentComponent> ac_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)aa_, ab_);
            Observation.ComponentComponent ad_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ac_);
            DataType ae_ = ad_?.Value;
            object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
            CqlQuantity ag_ = context.Operators.Quantity(80m, "mm[Hg]");
            CqlQuantity ah_ = context.Operators.Quantity(89m, "mm[Hg]");
            CqlInterval<CqlQuantity> ai_ = context.Operators.Interval(ag_, ah_, true, true);
            bool? aj_ = context.Operators.In<CqlQuantity>(af_ as CqlQuantity, ai_, (string)default);
            bool? ak_ = context.Operators.Or(u_, aj_);

            bool? al_(Observation BloodPressure) {
                DataType dg_ = BloodPressure?.Effective;
                object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                CqlInterval<CqlDateTime> di_ = QICoreCommon_4_0_000.Instance.toInterval(context, dh_);
                CqlDateTime dj_ = context.Operators.End(di_);
                Period dk_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> dl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dk_);
                bool? dm_ = context.Operators.In<CqlDateTime>(dj_, dl_, "day");
                Code<ObservationStatus> dn_ = BloodPressure?.StatusElement;
                ObservationStatus? do_ = dn_?.Value;
                string dp_ = context.Operators.Convert<string>(do_);
                string[] dq_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? dr_ = context.Operators.In<string>(dp_, (IEnumerable<string>)dq_);
                bool? ds_ = context.Operators.And(dm_, dr_);
                return ds_;
            }

            IEnumerable<Observation> am_ = context.Operators.Where<Observation>(f_, al_);

            object an_(Observation @this) {
                DataType dt_ = @this?.Effective;
                object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                CqlInterval<CqlDateTime> dv_ = QICoreCommon_4_0_000.Instance.toInterval(context, du_);
                CqlDateTime dw_ = context.Operators.Start(dv_);
                return dw_;
            }

            IEnumerable<Observation> ao_ = context.Operators.SortBy<Observation>(am_, an_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ap_ = context.Operators.Last<Observation>(ao_);
            List<Observation.ComponentComponent> aq_ = ap_?.Component;

            bool? ar_(Observation.ComponentComponent C) {
                CodeableConcept dx_ = C?.Code;
                CqlConcept dy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dx_);
                CqlCode dz_ = this.Systolic_blood_pressure(context);
                CqlConcept ea_ = context.Operators.ConvertCodeToConcept(dz_);
                bool? eb_ = context.Operators.Equivalent(dy_, ea_);
                return eb_;
            }

            IEnumerable<Observation.ComponentComponent> as_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)aq_, ar_);
            Observation.ComponentComponent at_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(as_);
            DataType au_ = at_?.Value;
            object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
            CqlQuantity aw_ = context.Operators.Quantity(140m, "mm[Hg]");
            bool? ax_ = context.Operators.GreaterOrEqual(av_ as CqlQuantity, aw_);

            bool? ay_(Observation BloodPressure) {
                DataType ec_ = BloodPressure?.Effective;
                object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                CqlInterval<CqlDateTime> ee_ = QICoreCommon_4_0_000.Instance.toInterval(context, ed_);
                CqlDateTime ef_ = context.Operators.End(ee_);
                Period eg_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> eh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eg_);
                bool? ei_ = context.Operators.In<CqlDateTime>(ef_, eh_, "day");
                Code<ObservationStatus> ej_ = BloodPressure?.StatusElement;
                ObservationStatus? ek_ = ej_?.Value;
                string el_ = context.Operators.Convert<string>(ek_);
                string[] em_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? en_ = context.Operators.In<string>(el_, (IEnumerable<string>)em_);
                bool? eo_ = context.Operators.And(ei_, en_);
                return eo_;
            }

            IEnumerable<Observation> az_ = context.Operators.Where<Observation>(f_, ay_);

            object ba_(Observation @this) {
                DataType ep_ = @this?.Effective;
                object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                CqlInterval<CqlDateTime> er_ = QICoreCommon_4_0_000.Instance.toInterval(context, eq_);
                CqlDateTime es_ = context.Operators.Start(er_);
                return es_;
            }

            IEnumerable<Observation> bb_ = context.Operators.SortBy<Observation>(az_, ba_, System.ComponentModel.ListSortDirection.Ascending);
            Observation bc_ = context.Operators.Last<Observation>(bb_);
            List<Observation.ComponentComponent> bd_ = bc_?.Component;

            bool? be_(Observation.ComponentComponent C) {
                CodeableConcept et_ = C?.Code;
                CqlConcept eu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, et_);
                CqlCode ev_ = this.Diastolic_blood_pressure(context);
                CqlConcept ew_ = context.Operators.ConvertCodeToConcept(ev_);
                bool? ex_ = context.Operators.Equivalent(eu_, ew_);
                return ex_;
            }

            IEnumerable<Observation.ComponentComponent> bf_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)bd_, be_);
            Observation.ComponentComponent bg_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(bf_);
            DataType bh_ = bg_?.Value;
            object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
            CqlQuantity bj_ = context.Operators.Quantity(90m, "mm[Hg]");
            bool? bk_ = context.Operators.GreaterOrEqual(bi_ as CqlQuantity, bj_);
            bool? bl_ = context.Operators.Or(ax_, bk_);
            bool? bm_ = context.Operators.Not(bl_);
            bool? bn_ = context.Operators.And(ak_, bm_);
            return bn_;
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
                FhirDateTime j_ = Rescreen2to6?.AuthoredOnElement;
                CqlDateTime k_ = context.Operators.Convert<CqlDateTime>(j_);
                CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
                bool? m_ = context.Operators.In<CqlDateTime>(k_, l_, "day");
                FhirDateTime n_ = LabECGIntervention?.AuthoredOnElement;
                CqlDateTime o_ = context.Operators.Convert<CqlDateTime>(n_);
                bool? p_ = context.Operators.In<CqlDateTime>(o_, l_, "day");
                bool? q_ = context.Operators.And(m_, p_);
                return q_;
            }

            IEnumerable<ServiceRequest> h_ = context.Operators.Where<ServiceRequest>(f_, g_);
            bool? i_ = context.Operators.Exists<ServiceRequest>(h_);
            return i_;
        }

        IEnumerable<ServiceRequest> c_ = context.Operators.Where<ServiceRequest>(a_, b_);

        bool? d_(ServiceRequest Rescreen2to6) {
            IEnumerable<ServiceRequest> r_ = this.NonPharmacological_Interventions(context);

            bool? s_(ServiceRequest NonPharmSecondIntervention) {
                FhirDateTime v_ = NonPharmSecondIntervention?.AuthoredOnElement;
                CqlDateTime w_ = context.Operators.Convert<CqlDateTime>(v_);
                CqlInterval<CqlDateTime> x_ = this.Measurement_Period(context);
                bool? y_ = context.Operators.In<CqlDateTime>(w_, x_, "day");
                return y_;
            }

            IEnumerable<ServiceRequest> t_ = context.Operators.Where<ServiceRequest>(r_, s_);
            bool? u_ = context.Operators.Exists<ServiceRequest>(t_);
            return u_;
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
                FhirDateTime k_ = EncounterInterventions?.AuthoredOnElement;
                CqlDateTime l_ = context.Operators.Convert<CqlDateTime>(k_);
                Period m_ = SecondHTNEncounterReading?.Period;
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                bool? o_ = context.Operators.In<CqlDateTime>(l_, n_, "day");
                return o_;
            }

            IEnumerable<ServiceRequest> i_ = context.Operators.Where<ServiceRequest>(g_, h_);
            bool? j_ = context.Operators.Exists<ServiceRequest>(i_);
            return j_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter SecondHTNEncounterReading) {
            IEnumerable<ServiceRequest> p_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(context);

            bool? q_(ServiceRequest ReferralForHTN) {
                FhirDateTime t_ = ReferralForHTN?.AuthoredOnElement;
                CqlDateTime u_ = context.Operators.Convert<CqlDateTime>(t_);
                Period v_ = SecondHTNEncounterReading?.Period;
                CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, v_);
                bool? x_ = context.Operators.In<CqlDateTime>(u_, w_, "day");
                return x_;
            }

            IEnumerable<ServiceRequest> r_ = context.Operators.Where<ServiceRequest>(p_, q_);
            bool? s_ = context.Operators.Exists<ServiceRequest>(r_);
            return s_;
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
                DataType bi_ = BloodPressure?.Effective;
                object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                CqlInterval<CqlDateTime> bk_ = QICoreCommon_4_0_000.Instance.toInterval(context, bj_);
                CqlDateTime bl_ = context.Operators.End(bk_);
                Period bm_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> bn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bm_);
                bool? bo_ = context.Operators.In<CqlDateTime>(bl_, bn_, "day");
                Code<ObservationStatus> bp_ = BloodPressure?.StatusElement;
                ObservationStatus? bq_ = bp_?.Value;
                string br_ = context.Operators.Convert<string>(bq_);
                string[] bs_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bt_ = context.Operators.In<string>(br_, (IEnumerable<string>)bs_);
                bool? bu_ = context.Operators.And(bo_, bt_);
                return bu_;
            }

            IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);

            object i_(Observation @this) {
                DataType bv_ = @this?.Effective;
                object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                CqlInterval<CqlDateTime> bx_ = QICoreCommon_4_0_000.Instance.toInterval(context, bw_);
                CqlDateTime by_ = context.Operators.Start(bx_);
                return by_;
            }

            IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Observation k_ = context.Operators.Last<Observation>(j_);
            List<Observation.ComponentComponent> l_ = k_?.Component;

            bool? m_(Observation.ComponentComponent C) {
                CodeableConcept bz_ = C?.Code;
                CqlConcept ca_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bz_);
                CqlCode cb_ = this.Systolic_blood_pressure(context);
                CqlConcept cc_ = context.Operators.ConvertCodeToConcept(cb_);
                bool? cd_ = context.Operators.Equivalent(ca_, cc_);
                return cd_;
            }

            IEnumerable<Observation.ComponentComponent> n_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)l_, m_);
            Observation.ComponentComponent o_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(n_);
            DataType p_ = o_?.Value;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlQuantity r_ = context.Operators.Quantity(0m, "mm[Hg]");
            bool? s_ = context.Operators.Greater(q_ as CqlQuantity, r_);

            bool? t_(Observation BloodPressure) {
                DataType ce_ = BloodPressure?.Effective;
                object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                CqlInterval<CqlDateTime> cg_ = QICoreCommon_4_0_000.Instance.toInterval(context, cf_);
                CqlDateTime ch_ = context.Operators.End(cg_);
                Period ci_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> cj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ci_);
                bool? ck_ = context.Operators.In<CqlDateTime>(ch_, cj_, "day");
                Code<ObservationStatus> cl_ = BloodPressure?.StatusElement;
                ObservationStatus? cm_ = cl_?.Value;
                string cn_ = context.Operators.Convert<string>(cm_);
                string[] co_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? cp_ = context.Operators.In<string>(cn_, (IEnumerable<string>)co_);
                bool? cq_ = context.Operators.And(ck_, cp_);
                return cq_;
            }

            IEnumerable<Observation> u_ = context.Operators.Where<Observation>(f_, t_);

            object v_(Observation @this) {
                DataType cr_ = @this?.Effective;
                object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                CqlInterval<CqlDateTime> ct_ = QICoreCommon_4_0_000.Instance.toInterval(context, cs_);
                CqlDateTime cu_ = context.Operators.Start(ct_);
                return cu_;
            }

            IEnumerable<Observation> w_ = context.Operators.SortBy<Observation>(u_, v_, System.ComponentModel.ListSortDirection.Ascending);
            Observation x_ = context.Operators.Last<Observation>(w_);
            List<Observation.ComponentComponent> y_ = x_?.Component;

            bool? z_(Observation.ComponentComponent C) {
                CodeableConcept cv_ = C?.Code;
                CqlConcept cw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cv_);
                CqlCode cx_ = this.Diastolic_blood_pressure(context);
                CqlConcept cy_ = context.Operators.ConvertCodeToConcept(cx_);
                bool? cz_ = context.Operators.Equivalent(cw_, cy_);
                return cz_;
            }

            IEnumerable<Observation.ComponentComponent> aa_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)y_, z_);
            Observation.ComponentComponent ab_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(aa_);
            DataType ac_ = ab_?.Value;
            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
            bool? ae_ = context.Operators.Greater(ad_ as CqlQuantity, r_);
            bool? af_ = context.Operators.And(s_, ae_);

            bool? ag_(Observation BloodPressure) {
                DataType da_ = BloodPressure?.Effective;
                object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                CqlInterval<CqlDateTime> dc_ = QICoreCommon_4_0_000.Instance.toInterval(context, db_);
                CqlDateTime dd_ = context.Operators.End(dc_);
                Period de_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> df_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, de_);
                bool? dg_ = context.Operators.In<CqlDateTime>(dd_, df_, "day");
                Code<ObservationStatus> dh_ = BloodPressure?.StatusElement;
                ObservationStatus? di_ = dh_?.Value;
                string dj_ = context.Operators.Convert<string>(di_);
                string[] dk_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? dl_ = context.Operators.In<string>(dj_, (IEnumerable<string>)dk_);
                bool? dm_ = context.Operators.And(dg_, dl_);
                return dm_;
            }

            IEnumerable<Observation> ah_ = context.Operators.Where<Observation>(f_, ag_);

            object ai_(Observation @this) {
                DataType dn_ = @this?.Effective;
                object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                CqlInterval<CqlDateTime> dp_ = QICoreCommon_4_0_000.Instance.toInterval(context, do_);
                CqlDateTime dq_ = context.Operators.Start(dp_);
                return dq_;
            }

            IEnumerable<Observation> aj_ = context.Operators.SortBy<Observation>(ah_, ai_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ak_ = context.Operators.Last<Observation>(aj_);
            List<Observation.ComponentComponent> al_ = ak_?.Component;

            bool? am_(Observation.ComponentComponent C) {
                CodeableConcept dr_ = C?.Code;
                CqlConcept ds_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dr_);
                CqlCode dt_ = this.Systolic_blood_pressure(context);
                CqlConcept du_ = context.Operators.ConvertCodeToConcept(dt_);
                bool? dv_ = context.Operators.Equivalent(ds_, du_);
                return dv_;
            }

            IEnumerable<Observation.ComponentComponent> an_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)al_, am_);
            Observation.ComponentComponent ao_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(an_);
            DataType ap_ = ao_?.Value;
            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
            CqlQuantity ar_ = context.Operators.Quantity(140m, "mm[Hg]");
            bool? as_ = context.Operators.GreaterOrEqual(aq_ as CqlQuantity, ar_);

            bool? at_(Observation BloodPressure) {
                DataType dw_ = BloodPressure?.Effective;
                object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                CqlInterval<CqlDateTime> dy_ = QICoreCommon_4_0_000.Instance.toInterval(context, dx_);
                CqlDateTime dz_ = context.Operators.End(dy_);
                Period ea_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> eb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ea_);
                bool? ec_ = context.Operators.In<CqlDateTime>(dz_, eb_, "day");
                Code<ObservationStatus> ed_ = BloodPressure?.StatusElement;
                ObservationStatus? ee_ = ed_?.Value;
                string ef_ = context.Operators.Convert<string>(ee_);
                string[] eg_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? eh_ = context.Operators.In<string>(ef_, (IEnumerable<string>)eg_);
                bool? ei_ = context.Operators.And(ec_, eh_);
                return ei_;
            }

            IEnumerable<Observation> au_ = context.Operators.Where<Observation>(f_, at_);

            object av_(Observation @this) {
                DataType ej_ = @this?.Effective;
                object ek_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ej_);
                CqlInterval<CqlDateTime> el_ = QICoreCommon_4_0_000.Instance.toInterval(context, ek_);
                CqlDateTime em_ = context.Operators.Start(el_);
                return em_;
            }

            IEnumerable<Observation> aw_ = context.Operators.SortBy<Observation>(au_, av_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ax_ = context.Operators.Last<Observation>(aw_);
            List<Observation.ComponentComponent> ay_ = ax_?.Component;

            bool? az_(Observation.ComponentComponent C) {
                CodeableConcept en_ = C?.Code;
                CqlConcept eo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, en_);
                CqlCode ep_ = this.Diastolic_blood_pressure(context);
                CqlConcept eq_ = context.Operators.ConvertCodeToConcept(ep_);
                bool? er_ = context.Operators.Equivalent(eo_, eq_);
                return er_;
            }

            IEnumerable<Observation.ComponentComponent> ba_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ay_, az_);
            Observation.ComponentComponent bb_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ba_);
            DataType bc_ = bb_?.Value;
            object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
            CqlQuantity be_ = context.Operators.Quantity(90m, "mm[Hg]");
            bool? bf_ = context.Operators.GreaterOrEqual(bd_ as CqlQuantity, be_);
            bool? bg_ = context.Operators.Or(as_, bf_);
            bool? bh_ = context.Operators.And(af_, bg_);
            return bh_;
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
                FhirDateTime m_ = WeeksRescreen?.AuthoredOnElement;
                CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
                CqlInterval<CqlDateTime> o_ = this.Measurement_Period(context);
                bool? p_ = context.Operators.In<CqlDateTime>(n_, o_, "day");
                FhirDateTime q_ = ECGLabTest?.AuthoredOnElement;
                CqlDateTime r_ = context.Operators.Convert<CqlDateTime>(q_);
                bool? s_ = context.Operators.In<CqlDateTime>(r_, o_, "day");
                bool? t_ = context.Operators.And(p_, s_);
                Code<RequestIntent> u_ = WeeksRescreen?.IntentElement;
                RequestIntent? v_ = u_?.Value;
                Code<RequestIntent> w_ = context.Operators.Convert<Code<RequestIntent>>(v_);
                string x_ = context.Operators.Convert<string>(w_);
                string[] y_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                bool? z_ = context.Operators.In<string>(x_, (IEnumerable<string>)y_);
                bool? aa_ = context.Operators.And(t_, z_);
                Code<RequestIntent> ab_ = ECGLabTest?.IntentElement;
                RequestIntent? ac_ = ab_?.Value;
                Code<RequestIntent> ad_ = context.Operators.Convert<Code<RequestIntent>>(ac_);
                string ae_ = context.Operators.Convert<string>(ad_);
                bool? af_ = context.Operators.In<string>(ae_, (IEnumerable<string>)y_);
                bool? ag_ = context.Operators.And(aa_, af_);
                return ag_;
            }

            IEnumerable<ServiceRequest> k_ = context.Operators.Where<ServiceRequest>(i_, j_);
            bool? l_ = context.Operators.Exists<ServiceRequest>(k_);
            return l_;
        }

        IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);

        bool? e_(ServiceRequest WeeksRescreen) {
            IEnumerable<ServiceRequest> ah_ = this.NonPharmacological_Interventions(context);

            bool? ai_(ServiceRequest HTNInterventions) {
                FhirDateTime al_ = HTNInterventions?.AuthoredOnElement;
                CqlDateTime am_ = context.Operators.Convert<CqlDateTime>(al_);
                CqlInterval<CqlDateTime> an_ = this.Measurement_Period(context);
                bool? ao_ = context.Operators.In<CqlDateTime>(am_, an_, "day");
                return ao_;
            }

            IEnumerable<ServiceRequest> aj_ = context.Operators.Where<ServiceRequest>(ah_, ai_);
            bool? ak_ = context.Operators.Exists<ServiceRequest>(aj_);
            return ak_;
        }

        IEnumerable<ServiceRequest> f_ = context.Operators.Where<ServiceRequest>(d_, e_);

        bool? g_(ServiceRequest WeeksRescreen) {
            IEnumerable<MedicationRequest> ap_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? aq_(MedicationRequest MR) {
                IEnumerable<Medication> ay_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? az_(Medication M) {
                    object bc_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object bd_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> be_ = context.Operators.Split((string)bd_, "/");
                    string bf_ = context.Operators.Last<string>(be_);
                    bool? bg_ = context.Operators.Equal(bc_, bf_);
                    CodeableConcept bh_ = M?.Code;
                    CqlConcept bi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bh_);
                    CqlValueSet bj_ = this.Pharmacologic_Therapy_for_Hypertension(context);
                    bool? bk_ = context.Operators.ConceptInValueSet(bi_, bj_);
                    bool? bl_ = context.Operators.And(bg_, bk_);
                    return bl_;
                }

                IEnumerable<Medication> ba_ = context.Operators.Where<Medication>(ay_, az_);
                bool? bb_ = context.Operators.Exists<Medication>(ba_);
                return bb_;
            }

            IEnumerable<MedicationRequest> ar_ = context.Operators.Where<MedicationRequest>(ap_, aq_);
            CqlValueSet as_ = this.Pharmacologic_Therapy_for_Hypertension(context);
            IEnumerable<MedicationRequest> at_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, as_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> au_ = context.Operators.Union<MedicationRequest>(ar_, at_);

            bool? av_(MedicationRequest Medications) {
                FhirDateTime bm_ = Medications?.AuthoredOnElement;
                CqlDateTime bn_ = context.Operators.Convert<CqlDateTime>(bm_);
                CqlInterval<CqlDateTime> bo_ = this.Measurement_Period(context);
                bool? bp_ = context.Operators.In<CqlDateTime>(bn_, bo_, "day");
                Code<MedicationRequest.MedicationrequestStatus> bq_ = Medications?.StatusElement;
                MedicationRequest.MedicationrequestStatus? br_ = bq_?.Value;
                string bs_ = context.Operators.Convert<string>(br_);
                string[] bt_ = [
                    "active",
                    "completed",
                ];
                bool? bu_ = context.Operators.In<string>(bs_, (IEnumerable<string>)bt_);
                bool? bv_ = context.Operators.And(bp_, bu_);
                return bv_;
            }

            IEnumerable<MedicationRequest> aw_ = context.Operators.Where<MedicationRequest>(au_, av_);
            bool? ax_ = context.Operators.Exists<MedicationRequest>(aw_);
            return ax_;
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
                FhirDateTime k_ = SecondHTN140Over90Interventions?.AuthoredOnElement;
                CqlDateTime l_ = context.Operators.Convert<CqlDateTime>(k_);
                Period m_ = SecondHTNEncounterReading140Over90?.Period;
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                bool? o_ = context.Operators.In<CqlDateTime>(l_, n_, "day");
                return o_;
            }

            IEnumerable<ServiceRequest> i_ = context.Operators.Where<ServiceRequest>(g_, h_);
            bool? j_ = context.Operators.Exists<ServiceRequest>(i_);
            return j_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter SecondHTNEncounterReading140Over90) {
            IEnumerable<ServiceRequest> p_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(context);

            bool? q_(ServiceRequest ReferralToProfessional) {
                FhirDateTime t_ = ReferralToProfessional?.AuthoredOnElement;
                CqlDateTime u_ = context.Operators.Convert<CqlDateTime>(t_);
                Period v_ = SecondHTNEncounterReading140Over90?.Period;
                CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, v_);
                bool? x_ = context.Operators.In<CqlDateTime>(u_, w_, "day");
                return x_;
            }

            IEnumerable<ServiceRequest> r_ = context.Operators.Where<ServiceRequest>(p_, q_);
            bool? s_ = context.Operators.Exists<ServiceRequest>(r_);
            return s_;
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
                Instant r_ = NoBPScreen?.IssuedElement;
                DateTimeOffset? s_ = r_?.Value;
                CqlDateTime t_ = context.Operators.Convert<CqlDateTime>(s_);
                Period u_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
                bool? w_ = context.Operators.In<CqlDateTime>(t_, v_, "day");

                bool? x_(Extension @this) {
                    FhirUri ap_ = @this?.UrlElement;
                    string aq_ = FHIRHelpers_4_4_000.Instance.ToString(context, ap_);
                    bool? ar_ = context.Operators.Equal(aq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                    return ar_;
                }

                IEnumerable<Extension> y_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoBPScreen is DomainResource
                    ? (NoBPScreen as DomainResource).Extension
                    : default), x_);

                object z_(Extension @this) {
                    DataType as_ = @this?.Value;
                    return as_;
                }

                IEnumerable<object> aa_ = context.Operators.Select<Extension, object>(y_, z_);
                object ab_ = context.Operators.SingletonFrom<object>(aa_);
                CqlConcept ac_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ab_ as CodeableConcept);
                CqlValueSet ad_ = this.Patient_Declined(context);
                bool? ae_ = context.Operators.ConceptInValueSet(ac_, ad_);

                bool? af_(Extension @this) {
                    FhirUri at_ = @this?.UrlElement;
                    string au_ = FHIRHelpers_4_4_000.Instance.ToString(context, at_);
                    bool? av_ = context.Operators.Equal(au_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                    return av_;
                }

                IEnumerable<Extension> ag_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoBPScreen is DomainResource
                    ? (NoBPScreen as DomainResource).Extension
                    : default), af_);

                object ah_(Extension @this) {
                    DataType aw_ = @this?.Value;
                    return aw_;
                }

                IEnumerable<object> ai_ = context.Operators.Select<Extension, object>(ag_, ah_);
                object aj_ = context.Operators.SingletonFrom<object>(ai_);
                CqlConcept ak_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aj_ as CodeableConcept);
                CqlValueSet al_ = this.Medical_Reason(context);
                bool? am_ = context.Operators.ConceptInValueSet(ak_, al_);
                bool? an_ = context.Operators.Or(ae_, am_);
                bool? ao_ = context.Operators.And(w_, an_);
                return ao_;
            }

            IEnumerable<Observation> p_ = context.Operators.Where<Observation>(n_, o_);
            bool? q_ = context.Operators.Exists<Observation>(p_);
            return q_;
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

            bool? ab_(Extension @this) {
                FhirUri ak_ = @this?.UrlElement;
                string al_ = FHIRHelpers_4_4_000.Instance.ToString(context, ak_);
                bool? am_ = context.Operators.Equal(al_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                return am_;
            }

            IEnumerable<Extension> ac_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NonPharmIntervention is DomainResource
                ? (NonPharmIntervention as DomainResource).Extension
                : default), ab_);

            object ad_(Extension @this) {
                DataType an_ = @this?.Value;
                return an_;
            }

            IEnumerable<object> ae_ = context.Operators.Select<Extension, object>(ac_, ad_);
            object af_ = context.Operators.SingletonFrom<object>(ae_);
            CqlConcept ag_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, af_ as CodeableConcept);
            CqlValueSet ah_ = this.Patient_Declined(context);
            bool? ai_ = context.Operators.ConceptInValueSet(ag_, ah_);
            bool? aj_ = context.Operators.And(aa_, ai_);
            return aj_;
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

            bool? t_(Extension @this) {
                FhirUri ac_ = @this?.UrlElement;
                string ad_ = FHIRHelpers_4_4_000.Instance.ToString(context, ac_);
                bool? ae_ = context.Operators.Equal(ad_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                return ae_;
            }

            IEnumerable<Extension> u_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(LabECGNotDone is DomainResource
                ? (LabECGNotDone as DomainResource).Extension
                : default), t_);

            object v_(Extension @this) {
                DataType af_ = @this?.Value;
                return af_;
            }

            IEnumerable<object> w_ = context.Operators.Select<Extension, object>(u_, v_);
            object x_ = context.Operators.SingletonFrom<object>(w_);
            CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_ as CodeableConcept);
            CqlValueSet z_ = this.Patient_Declined(context);
            bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
            bool? ab_ = context.Operators.And(s_, aa_);
            return ab_;
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

            bool? t_(Extension @this) {
                FhirUri ac_ = @this?.UrlElement;
                string ad_ = FHIRHelpers_4_4_000.Instance.ToString(context, ac_);
                bool? ae_ = context.Operators.Equal(ad_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                return ae_;
            }

            IEnumerable<Extension> u_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(SecondHTNDeclinedReferralAndFollowUp is DomainResource
                ? (SecondHTNDeclinedReferralAndFollowUp as DomainResource).Extension
                : default), t_);

            object v_(Extension @this) {
                DataType af_ = @this?.Value;
                return af_;
            }

            IEnumerable<object> w_ = context.Operators.Select<Extension, object>(u_, v_);
            object x_ = context.Operators.SingletonFrom<object>(w_);
            CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_ as CodeableConcept);
            CqlValueSet z_ = this.Patient_Declined(context);
            bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
            bool? ab_ = context.Operators.And(s_, aa_);
            return ab_;
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

            bool? z_(Extension @this) {
                FhirUri ai_ = @this?.UrlElement;
                string aj_ = FHIRHelpers_4_4_000.Instance.ToString(context, ai_);
                bool? ak_ = context.Operators.Equal(aj_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                return ak_;
            }

            IEnumerable<Extension> aa_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(SecondHTN140Over90ReferralFollowUpNotDone is DomainResource
                ? (SecondHTN140Over90ReferralFollowUpNotDone as DomainResource).Extension
                : default), z_);

            object ab_(Extension @this) {
                DataType al_ = @this?.Value;
                return al_;
            }

            IEnumerable<object> ac_ = context.Operators.Select<Extension, object>(aa_, ab_);
            object ad_ = context.Operators.SingletonFrom<object>(ac_);
            CqlConcept ae_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ad_ as CodeableConcept);
            CqlValueSet af_ = this.Patient_Declined(context);
            bool? ag_ = context.Operators.ConceptInValueSet(ae_, af_);
            bool? ah_ = context.Operators.And(y_, ag_);
            return ah_;
        }

        IEnumerable<ServiceRequest> i_ = context.Operators.Where<ServiceRequest>(g_, h_);
        CqlValueSet j_ = this.Pharmacologic_Therapy_for_Hypertension(context);
        IEnumerable<MedicationRequest> k_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(k_, k_);

        bool? m_(MedicationRequest MedicationRequestNotOrdered) {
            Code<MedicationRequest.MedicationrequestStatus> am_ = MedicationRequestNotOrdered?.StatusElement;
            MedicationRequest.MedicationrequestStatus? an_ = am_?.Value;
            string ao_ = context.Operators.Convert<string>(an_);
            string[] ap_ = [
                "active",
                "completed",
            ];
            bool? aq_ = context.Operators.In<string>(ao_, (IEnumerable<string>)ap_);
            return aq_;
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
                FhirDateTime af_ = ElevatedBPDeclinedInterventions?.AuthoredOnElement;
                CqlDateTime ag_ = context.Operators.Convert<CqlDateTime>(af_);
                Period ah_ = ElevatedBPEncounter?.Period;
                CqlInterval<CqlDateTime> ai_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ah_);
                bool? aj_ = context.Operators.In<CqlDateTime>(ag_, ai_, "day");
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
                bool? aq_ = context.Operators.And(aj_, ap_);

                bool? ar_(Extension @this) {
                    FhirUri ba_ = @this?.UrlElement;
                    string bb_ = FHIRHelpers_4_4_000.Instance.ToString(context, ba_);
                    bool? bc_ = context.Operators.Equal(bb_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                    return bc_;
                }

                IEnumerable<Extension> as_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(ElevatedBPDeclinedInterventions is DomainResource
                    ? (ElevatedBPDeclinedInterventions as DomainResource).Extension
                    : default), ar_);

                object at_(Extension @this) {
                    DataType bd_ = @this?.Value;
                    return bd_;
                }

                IEnumerable<object> au_ = context.Operators.Select<Extension, object>(as_, at_);
                object av_ = context.Operators.SingletonFrom<object>(au_);
                CqlConcept aw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, av_ as CodeableConcept);
                CqlValueSet ax_ = this.Patient_Declined(context);
                bool? ay_ = context.Operators.ConceptInValueSet(aw_, ax_);
                bool? az_ = context.Operators.And(aq_, ay_);
                return az_;
            }

            IEnumerable<ServiceRequest> ad_ = context.Operators.Where<ServiceRequest>(ab_, ac_);
            bool? ae_ = context.Operators.Exists<ServiceRequest>(ad_);
            return ae_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter ElevatedBPEncounter) {
            IEnumerable<ServiceRequest> be_ = this.NonPharmacological_Intervention_Not_Ordered(context);

            bool? bf_(ServiceRequest NotOrdered) {
                FhirDateTime bi_ = NotOrdered?.AuthoredOnElement;
                CqlDateTime bj_ = context.Operators.Convert<CqlDateTime>(bi_);
                Period bk_ = ElevatedBPEncounter?.Period;
                CqlInterval<CqlDateTime> bl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bk_);
                bool? bm_ = context.Operators.In<CqlDateTime>(bj_, bl_, "day");
                return bm_;
            }

            IEnumerable<ServiceRequest> bg_ = context.Operators.Where<ServiceRequest>(be_, bf_);
            bool? bh_ = context.Operators.Exists<ServiceRequest>(bg_);
            return bh_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(a_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(c_, e_);
        IEnumerable<Encounter> g_ = this.Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80(context);

        bool? h_(Encounter FirstHTNEncounter) {
            CqlValueSet bn_ = this.Follow_Up_Within_4_Weeks(context);
            IEnumerable<ServiceRequest> bo_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, bn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> bp_ = context.Operators.Union<ServiceRequest>(bo_, bo_);
            CqlValueSet bq_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
            IEnumerable<ServiceRequest> br_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, bq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> bs_ = context.Operators.Union<ServiceRequest>(br_, br_);
            IEnumerable<ServiceRequest> bt_ = context.Operators.Union<ServiceRequest>(bp_, bs_);

            bool? bu_(ServiceRequest FirstHTNDeclinedInterventions) {
                FhirDateTime bx_ = FirstHTNDeclinedInterventions?.AuthoredOnElement;
                CqlDateTime by_ = context.Operators.Convert<CqlDateTime>(bx_);
                Period bz_ = FirstHTNEncounter?.Period;
                CqlInterval<CqlDateTime> ca_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bz_);
                bool? cb_ = context.Operators.In<CqlDateTime>(by_, ca_, "day");
                Code<RequestStatus> cc_ = FirstHTNDeclinedInterventions?.StatusElement;
                RequestStatus? cd_ = cc_?.Value;
                Code<RequestStatus> ce_ = context.Operators.Convert<Code<RequestStatus>>(cd_);
                string cf_ = context.Operators.Convert<string>(ce_);
                string[] cg_ = [
                    "active",
                    "completed",
                    "on-hold",
                ];
                bool? ch_ = context.Operators.In<string>(cf_, (IEnumerable<string>)cg_);
                bool? ci_ = context.Operators.And(cb_, ch_);

                bool? cj_(Extension @this) {
                    FhirUri cs_ = @this?.UrlElement;
                    string ct_ = FHIRHelpers_4_4_000.Instance.ToString(context, cs_);
                    bool? cu_ = context.Operators.Equal(ct_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                    return cu_;
                }

                IEnumerable<Extension> ck_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(FirstHTNDeclinedInterventions is DomainResource
                    ? (FirstHTNDeclinedInterventions as DomainResource).Extension
                    : default), cj_);

                object cl_(Extension @this) {
                    DataType cv_ = @this?.Value;
                    return cv_;
                }

                IEnumerable<object> cm_ = context.Operators.Select<Extension, object>(ck_, cl_);
                object cn_ = context.Operators.SingletonFrom<object>(cm_);
                CqlConcept co_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cn_ as CodeableConcept);
                CqlValueSet cp_ = this.Patient_Declined(context);
                bool? cq_ = context.Operators.ConceptInValueSet(co_, cp_);
                bool? cr_ = context.Operators.And(ci_, cq_);
                return cr_;
            }

            IEnumerable<ServiceRequest> bv_ = context.Operators.Where<ServiceRequest>(bt_, bu_);
            bool? bw_ = context.Operators.Exists<ServiceRequest>(bv_);
            return bw_;
        }

        IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);

        bool? j_(Encounter FirstHTNEncounter) {
            IEnumerable<ServiceRequest> cw_ = this.NonPharmacological_Intervention_Not_Ordered(context);

            bool? cx_(ServiceRequest NoNonPharm) {
                FhirDateTime da_ = NoNonPharm?.AuthoredOnElement;
                CqlDateTime db_ = context.Operators.Convert<CqlDateTime>(da_);
                Period dc_ = FirstHTNEncounter?.Period;
                CqlInterval<CqlDateTime> dd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dc_);
                bool? de_ = context.Operators.In<CqlDateTime>(db_, dd_, "day");
                return de_;
            }

            IEnumerable<ServiceRequest> cy_ = context.Operators.Where<ServiceRequest>(cw_, cx_);
            bool? cz_ = context.Operators.Exists<ServiceRequest>(cy_);
            return cz_;
        }

        IEnumerable<Encounter> k_ = context.Operators.Where<Encounter>(g_, j_);
        IEnumerable<Encounter> l_ = context.Operators.Union<Encounter>(i_, k_);
        IEnumerable<Encounter> m_ = context.Operators.Union<Encounter>(f_, l_);
        IEnumerable<Encounter> n_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89(context);

        bool? o_(Encounter SecondHTNEncounter) {
            IEnumerable<ServiceRequest> df_ = this.Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined(context);

            bool? dg_(ServiceRequest SecondHTNDeclinedInterventions) {
                FhirDateTime dj_ = SecondHTNDeclinedInterventions?.AuthoredOnElement;
                CqlDateTime dk_ = context.Operators.Convert<CqlDateTime>(dj_);
                Period dl_ = SecondHTNEncounter?.Period;
                CqlInterval<CqlDateTime> dm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dl_);
                bool? dn_ = context.Operators.In<CqlDateTime>(dk_, dm_, "day");
                return dn_;
            }

            IEnumerable<ServiceRequest> dh_ = context.Operators.Where<ServiceRequest>(df_, dg_);
            bool? di_ = context.Operators.Exists<ServiceRequest>(dh_);
            return di_;
        }

        IEnumerable<Encounter> p_ = context.Operators.Where<Encounter>(n_, o_);
        IEnumerable<Encounter> q_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90(context);

        bool? r_(Encounter SecondHTN140Over90Encounter) {
            IEnumerable<object> do_ = this.Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined(context);

            bool? dp_(object SecondHTN140Over90DeclinedInterventions) {
                object ds_ = context.Operators.LateBoundProperty<object>(SecondHTN140Over90DeclinedInterventions, "authoredOn");
                CqlDateTime dt_ = context.Operators.LateBoundProperty<CqlDateTime>(ds_, "value");
                Period du_ = SecondHTN140Over90Encounter?.Period;
                CqlInterval<CqlDateTime> dv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, du_);
                bool? dw_ = context.Operators.In<CqlDateTime>(dt_, dv_, "day");
                return dw_;
            }

            IEnumerable<object> dq_ = context.Operators.Where<object>(do_, dp_);
            bool? dr_ = context.Operators.Exists<object>(dq_);
            return dr_;
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
