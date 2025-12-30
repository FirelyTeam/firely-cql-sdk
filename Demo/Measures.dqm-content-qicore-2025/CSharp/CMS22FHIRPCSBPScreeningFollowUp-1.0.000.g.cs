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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.1.0.0")]
[CqlLibrary("CMS22FHIRPCSBPScreeningFollowUp", "1.0.000")]
public partial class CMS22FHIRPCSBPScreeningFollowUp_1_0_000 : ILibrary, ISingleton<CMS22FHIRPCSBPScreeningFollowUp_1_0_000>
{
    private CMS22FHIRPCSBPScreeningFollowUp_1_0_000() {}

    public static CMS22FHIRPCSBPScreeningFollowUp_1_0_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS22FHIRPCSBPScreeningFollowUp";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

    #region Nested Type - Cached<T>

    private struct Cached<T>(object CacheVersion, T CachedValue)
    {
        public T GetOrReplace(ICqlContextInternals cqlContext, Func<T> factory)
        {
            var cqlContextCacheVersion = cqlContext.CacheVersion;
            if (cqlContextCacheVersion is null)
            {
                // No caching, clear out previous values
                CacheVersion = null;
                CachedValue = default;
                var value = factory();
                return value;
            }

            if (ReferenceEquals(CacheVersion, cqlContextCacheVersion))
            {
                // Cache hit
                return CachedValue;
            }
            else
            {
                // Cache miss, refresh and store
                var value = factory();
                CachedValue = value;
                CacheVersion = cqlContextCacheVersion;
                return value;
            }
        }
    }

    #endregion

    #region ValueSets

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

    #region Codes

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

    #region CodeSystems

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

    #region Parameters

    private Cached<CqlInterval<CqlDateTime>> _Measurement_Period_Cached = new();

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        _Measurement_Period_Cached.GetOrReplace(
            context,
            () =>
            {
                object a_ = context.ResolveParameter("CMS22FHIRPCSBPScreeningFollowUp-1.0.000", "Measurement Period", null);
                return (CqlInterval<CqlDateTime>)a_;
            });


    #endregion Parameters

    #region Functions and Expressions

    private Cached<Patient> _Patient_Cached = new();

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _Patient_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
                Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
                return b_;
            });


    private Cached<IEnumerable<Encounter>> _Qualifying_Encounter_during_Measurement_Period_Cached = new();

    [CqlExpressionDefinition("Qualifying Encounter during Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_during_Measurement_Period(CqlContext context) =>
        _Qualifying_Encounter_during_Measurement_Period_Cached.GetOrReplace(
            context,
            () =>
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
            });


    private Cached<IEnumerable<Encounter>> _Initial_Population_Cached = new();

    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        _Initial_Population_Cached.GetOrReplace(
            context,
            () =>
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
            });


    private Cached<IEnumerable<Encounter>> _Denominator_Cached = new();

    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        _Denominator_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Encounter> a_ = this.Initial_Population(context);
                return a_;
            });


    [CqlFunctionDefinition("isVerified")]
    [CqlTag("description", "Returns true if the given condition either has no verification status or has a verification status of confirmed, unconfirmed, provisional, or differential")]
    public bool? isVerified(CqlContext context, object condition)
    {
        object a_ = context.Operators.LateBoundProperty<object>(condition, "verificationStatus");
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        bool? c_ = context.Operators.Not((bool?)(b_ is null));
        CqlConcept e_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode f_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept g_ = context.Operators.ConvertCodeToConcept(f_);
        bool? h_ = context.Operators.Equivalent(e_, g_);
        CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode k_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
        CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
        bool? m_ = context.Operators.Equivalent(j_, l_);
        bool? n_ = context.Operators.Or(h_, m_);
        CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode q_ = QICoreCommon_4_0_000.Instance.provisional(context);
        CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
        bool? s_ = context.Operators.Equivalent(p_, r_);
        bool? t_ = context.Operators.Or(n_, s_);
        CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode w_ = QICoreCommon_4_0_000.Instance.differential(context);
        CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
        bool? y_ = context.Operators.Equivalent(v_, x_);
        bool? z_ = context.Operators.Or(t_, y_);
        bool? aa_ = context.Operators.Implies(c_, z_);
        return aa_;
    }


    private Cached<IEnumerable<Encounter>> _Denominator_Exclusions_Cached = new();

    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context) =>
        _Denominator_Exclusions_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Measurement_Period(context);

                IEnumerable<Encounter> b_(Encounter QualifyingEncounter) {
                    CqlValueSet d_ = this.Diagnosis_of_Hypertension(context);
                    IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

                    bool? f_(Condition Hypertension) {

                        CqlInterval<CqlDateTime> j_() {

                            bool p_() {
                                CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, Hypertension as object);
                                CqlDateTime r_ = context.Operators.Start(q_);
                                return r_ is null;
                            }

                            if (p_())
                            {
                                return default;
                            }
                            else
                            {
                                CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, Hypertension as object);
                                CqlDateTime t_ = context.Operators.Start(s_);
                                CqlDateTime v_ = context.Operators.Start(s_);
                                CqlInterval<CqlDateTime> w_ = context.Operators.Interval(t_, v_, true, true);
                                return w_;
                            };
                        }

                        Period k_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                        bool? m_ = context.Operators.SameOrBefore(j_(), l_, "day");
                        bool? n_ = this.isVerified(context, Hypertension as object);
                        bool? o_ = context.Operators.And(m_, n_);
                        return o_;
                    }

                    IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
                    Encounter h_(Condition Hypertension) => QualifyingEncounter;
                    IEnumerable<Encounter> i_ = context.Operators.Select<Condition, Encounter>(g_, h_);
                    return i_;
                }

                IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
                return c_;
            });


    private Cached<IEnumerable<Encounter>> _Encounter_with_Normal_Blood_Pressure_Reading_Cached = new();

    [CqlExpressionDefinition("Encounter with Normal Blood Pressure Reading")]
    public IEnumerable<Encounter> Encounter_with_Normal_Blood_Pressure_Reading(CqlContext context) =>
        _Encounter_with_Normal_Blood_Pressure_Reading_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Measurement_Period(context);

                bool? b_(Encounter QualifyingEncounter) {
                    IEnumerable<Observation> d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

                    bool? e_(Observation BloodPressure) {
                        DataType ak_ = BloodPressure?.Effective;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        CqlInterval<CqlDateTime> am_ = QICoreCommon_4_0_000.Instance.toInterval(context, al_);
                        CqlDateTime an_ = context.Operators.End(am_);
                        Period ao_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> ap_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ao_);
                        bool? aq_ = context.Operators.In<CqlDateTime>(an_, ap_, "day");
                        Code<ObservationStatus> ar_ = BloodPressure?.StatusElement;
                        ObservationStatus? as_ = ar_?.Value;
                        string at_ = context.Operators.Convert<string>(as_);
                        string[] au_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? av_ = context.Operators.In<string>(at_, (IEnumerable<string>)au_);
                        bool? aw_ = context.Operators.And(aq_, av_);
                        return aw_;
                    }

                    IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);

                    object g_(Observation @this) {
                        DataType ax_ = @this?.Effective;
                        object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                        CqlInterval<CqlDateTime> az_ = QICoreCommon_4_0_000.Instance.toInterval(context, ay_);
                        CqlDateTime ba_ = context.Operators.Start(az_);
                        return ba_;
                    }

                    IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation i_ = context.Operators.Last<Observation>(h_);
                    List<Observation.ComponentComponent> j_ = i_?.Component;

                    bool? k_(Observation.ComponentComponent C) {
                        CodeableConcept bb_ = C?.Code;
                        CqlConcept bc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bb_);
                        CqlCode bd_ = this.Systolic_blood_pressure(context);
                        CqlConcept be_ = context.Operators.ConvertCodeToConcept(bd_);
                        bool? bf_ = context.Operators.Equivalent(bc_, be_);
                        return bf_;
                    }

                    IEnumerable<Observation.ComponentComponent> l_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)j_, k_);
                    Observation.ComponentComponent m_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(l_);
                    DataType n_ = m_?.Value;
                    object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                    CqlQuantity p_ = context.Operators.Quantity(1m, "mm[Hg]");
                    CqlQuantity q_ = context.Operators.Quantity(120m, "mm[Hg]");
                    CqlInterval<CqlQuantity> r_ = context.Operators.Interval(p_, q_, true, false);
                    bool? s_ = context.Operators.In<CqlQuantity>(o_ as CqlQuantity, r_, default);

                    bool? u_(Observation BloodPressure) {
                        DataType bg_ = BloodPressure?.Effective;
                        object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                        CqlInterval<CqlDateTime> bi_ = QICoreCommon_4_0_000.Instance.toInterval(context, bh_);
                        CqlDateTime bj_ = context.Operators.End(bi_);
                        Period bk_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> bl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bk_);
                        bool? bm_ = context.Operators.In<CqlDateTime>(bj_, bl_, "day");
                        Code<ObservationStatus> bn_ = BloodPressure?.StatusElement;
                        ObservationStatus? bo_ = bn_?.Value;
                        string bp_ = context.Operators.Convert<string>(bo_);
                        string[] bq_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? br_ = context.Operators.In<string>(bp_, (IEnumerable<string>)bq_);
                        bool? bs_ = context.Operators.And(bm_, br_);
                        return bs_;
                    }

                    IEnumerable<Observation> v_ = context.Operators.Where<Observation>(d_, u_);

                    object w_(Observation @this) {
                        DataType bt_ = @this?.Effective;
                        object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                        CqlInterval<CqlDateTime> bv_ = QICoreCommon_4_0_000.Instance.toInterval(context, bu_);
                        CqlDateTime bw_ = context.Operators.Start(bv_);
                        return bw_;
                    }

                    IEnumerable<Observation> x_ = context.Operators.SortBy<Observation>(v_, w_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation y_ = context.Operators.Last<Observation>(x_);
                    List<Observation.ComponentComponent> z_ = y_?.Component;

                    bool? aa_(Observation.ComponentComponent C) {
                        CodeableConcept bx_ = C?.Code;
                        CqlConcept by_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bx_);
                        CqlCode bz_ = this.Diastolic_blood_pressure(context);
                        CqlConcept ca_ = context.Operators.ConvertCodeToConcept(bz_);
                        bool? cb_ = context.Operators.Equivalent(by_, ca_);
                        return cb_;
                    }

                    IEnumerable<Observation.ComponentComponent> ab_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)z_, aa_);
                    Observation.ComponentComponent ac_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ab_);
                    DataType ad_ = ac_?.Value;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    CqlQuantity ag_ = context.Operators.Quantity(80m, "mm[Hg]");
                    CqlInterval<CqlQuantity> ah_ = context.Operators.Interval(p_, ag_, true, false);
                    bool? ai_ = context.Operators.In<CqlQuantity>(ae_ as CqlQuantity, ah_, default);
                    bool? aj_ = context.Operators.And(s_, ai_);
                    return aj_;
                }

                IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
                return c_;
            });


    private Cached<IEnumerable<Encounter>> _Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_Cached = new();

    [CqlExpressionDefinition("Encounter with Elevated Blood Pressure Reading SBP 120 to 129 AND DBP less than 80")]
    public IEnumerable<Encounter> Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80(CqlContext context) =>
        _Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Measurement_Period(context);

                bool? b_(Encounter QualifyingEncounter) {
                    IEnumerable<Observation> d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

                    bool? e_(Observation BloodPressure) {
                        DataType ak_ = BloodPressure?.Effective;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        CqlInterval<CqlDateTime> am_ = QICoreCommon_4_0_000.Instance.toInterval(context, al_);
                        CqlDateTime an_ = context.Operators.End(am_);
                        Period ao_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> ap_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ao_);
                        bool? aq_ = context.Operators.In<CqlDateTime>(an_, ap_, "day");
                        Code<ObservationStatus> ar_ = BloodPressure?.StatusElement;
                        ObservationStatus? as_ = ar_?.Value;
                        string at_ = context.Operators.Convert<string>(as_);
                        string[] au_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? av_ = context.Operators.In<string>(at_, (IEnumerable<string>)au_);
                        bool? aw_ = context.Operators.And(aq_, av_);
                        return aw_;
                    }

                    IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);

                    object g_(Observation @this) {
                        DataType ax_ = @this?.Effective;
                        object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                        CqlInterval<CqlDateTime> az_ = QICoreCommon_4_0_000.Instance.toInterval(context, ay_);
                        CqlDateTime ba_ = context.Operators.Start(az_);
                        return ba_;
                    }

                    IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation i_ = context.Operators.Last<Observation>(h_);
                    List<Observation.ComponentComponent> j_ = i_?.Component;

                    bool? k_(Observation.ComponentComponent C) {
                        CodeableConcept bb_ = C?.Code;
                        CqlConcept bc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bb_);
                        CqlCode bd_ = this.Systolic_blood_pressure(context);
                        CqlConcept be_ = context.Operators.ConvertCodeToConcept(bd_);
                        bool? bf_ = context.Operators.Equivalent(bc_, be_);
                        return bf_;
                    }

                    IEnumerable<Observation.ComponentComponent> l_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)j_, k_);
                    Observation.ComponentComponent m_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(l_);
                    DataType n_ = m_?.Value;
                    object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                    CqlQuantity p_ = context.Operators.Quantity(120m, "mm[Hg]");
                    CqlQuantity q_ = context.Operators.Quantity(129m, "mm[Hg]");
                    CqlInterval<CqlQuantity> r_ = context.Operators.Interval(p_, q_, true, true);
                    bool? s_ = context.Operators.In<CqlQuantity>(o_ as CqlQuantity, r_, default);

                    bool? u_(Observation BloodPressure) {
                        DataType bg_ = BloodPressure?.Effective;
                        object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                        CqlInterval<CqlDateTime> bi_ = QICoreCommon_4_0_000.Instance.toInterval(context, bh_);
                        CqlDateTime bj_ = context.Operators.End(bi_);
                        Period bk_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> bl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bk_);
                        bool? bm_ = context.Operators.In<CqlDateTime>(bj_, bl_, "day");
                        Code<ObservationStatus> bn_ = BloodPressure?.StatusElement;
                        ObservationStatus? bo_ = bn_?.Value;
                        string bp_ = context.Operators.Convert<string>(bo_);
                        string[] bq_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? br_ = context.Operators.In<string>(bp_, (IEnumerable<string>)bq_);
                        bool? bs_ = context.Operators.And(bm_, br_);
                        return bs_;
                    }

                    IEnumerable<Observation> v_ = context.Operators.Where<Observation>(d_, u_);

                    object w_(Observation @this) {
                        DataType bt_ = @this?.Effective;
                        object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                        CqlInterval<CqlDateTime> bv_ = QICoreCommon_4_0_000.Instance.toInterval(context, bu_);
                        CqlDateTime bw_ = context.Operators.Start(bv_);
                        return bw_;
                    }

                    IEnumerable<Observation> x_ = context.Operators.SortBy<Observation>(v_, w_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation y_ = context.Operators.Last<Observation>(x_);
                    List<Observation.ComponentComponent> z_ = y_?.Component;

                    bool? aa_(Observation.ComponentComponent C) {
                        CodeableConcept bx_ = C?.Code;
                        CqlConcept by_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bx_);
                        CqlCode bz_ = this.Diastolic_blood_pressure(context);
                        CqlConcept ca_ = context.Operators.ConvertCodeToConcept(bz_);
                        bool? cb_ = context.Operators.Equivalent(by_, ca_);
                        return cb_;
                    }

                    IEnumerable<Observation.ComponentComponent> ab_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)z_, aa_);
                    Observation.ComponentComponent ac_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ab_);
                    DataType ad_ = ac_?.Value;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    CqlQuantity af_ = context.Operators.Quantity(1m, "mm[Hg]");
                    CqlQuantity ag_ = context.Operators.Quantity(80m, "mm[Hg]");
                    CqlInterval<CqlQuantity> ah_ = context.Operators.Interval(af_, ag_, true, false);
                    bool? ai_ = context.Operators.In<CqlQuantity>(ae_ as CqlQuantity, ah_, default);
                    bool? aj_ = context.Operators.And(s_, ai_);
                    return aj_;
                }

                IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
                return c_;
            });


    private Cached<IEnumerable<ServiceRequest>> _Follow_up_with_Rescreen_Within_6_Months_Cached = new();

    [CqlExpressionDefinition("Follow up with Rescreen Within 6 Months")]
    public IEnumerable<ServiceRequest> Follow_up_with_Rescreen_Within_6_Months(CqlContext context) =>
        _Follow_up_with_Rescreen_Within_6_Months_Cached.GetOrReplace(
            context,
            () =>
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
            });


    private Cached<IEnumerable<ServiceRequest>> _NonPharmacological_Interventions_Cached = new();

    [CqlExpressionDefinition("NonPharmacological Interventions")]
    public IEnumerable<ServiceRequest> NonPharmacological_Interventions(CqlContext context) =>
        _NonPharmacological_Interventions_Cached.GetOrReplace(
            context,
            () =>
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
            });


    private Cached<IEnumerable<ServiceRequest>> _Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading_Cached = new();

    [CqlExpressionDefinition("Referral to Alternate or Primary Healthcare Professional for Hypertensive Reading")]
    public IEnumerable<ServiceRequest> Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(CqlContext context) =>
        _Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading_Cached.GetOrReplace(
            context,
            () =>
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
            });


    private Cached<IEnumerable<Encounter>> _Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_and_Interventions_Cached = new();

    [CqlExpressionDefinition("Encounter with Elevated Blood Pressure Reading SBP 120 to 129 AND DBP less than 80 and Interventions")]
    public IEnumerable<Encounter> Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_and_Interventions(CqlContext context) =>
        _Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_and_Interventions_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Encounter> a_ = this.Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80(context);

                IEnumerable<Encounter> b_(Encounter ElevatedEncounter) {
                    IEnumerable<ServiceRequest> j_ = this.Follow_up_with_Rescreen_Within_6_Months(context);

                    bool? k_(ServiceRequest Twoto6MonthRescreen) {
                        FhirDateTime o_ = Twoto6MonthRescreen?.AuthoredOnElement;
                        CqlDateTime p_ = context.Operators.Convert<CqlDateTime>(o_);
                        Period q_ = ElevatedEncounter?.Period;
                        CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
                        bool? s_ = context.Operators.In<CqlDateTime>(p_, r_, "day");
                        return s_;
                    }

                    IEnumerable<ServiceRequest> l_ = context.Operators.Where<ServiceRequest>(j_, k_);
                    Encounter m_(ServiceRequest Twoto6MonthRescreen) => ElevatedEncounter;
                    IEnumerable<Encounter> n_ = context.Operators.Select<ServiceRequest, Encounter>(l_, m_);
                    return n_;
                }

                IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

                IEnumerable<Encounter> d_(Encounter ElevatedEncounter) {
                    IEnumerable<ServiceRequest> t_ = this.NonPharmacological_Interventions(context);

                    bool? u_(ServiceRequest NonPharmInterventions) {
                        FhirDateTime y_ = NonPharmInterventions?.AuthoredOnElement;
                        CqlDateTime z_ = context.Operators.Convert<CqlDateTime>(y_);
                        Period aa_ = ElevatedEncounter?.Period;
                        CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aa_);
                        bool? ac_ = context.Operators.In<CqlDateTime>(z_, ab_, "day");
                        return ac_;
                    }

                    IEnumerable<ServiceRequest> v_ = context.Operators.Where<ServiceRequest>(t_, u_);
                    Encounter w_(ServiceRequest NonPharmInterventions) => ElevatedEncounter;
                    IEnumerable<Encounter> x_ = context.Operators.Select<ServiceRequest, Encounter>(v_, w_);
                    return x_;
                }

                IEnumerable<Encounter> e_ = context.Operators.SelectMany<Encounter, Encounter>(c_, d_);

                IEnumerable<Encounter> g_(Encounter ElevatedEncounter) {
                    IEnumerable<ServiceRequest> ad_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(context);

                    bool? ae_(ServiceRequest Referral) {
                        FhirDateTime ai_ = Referral?.AuthoredOnElement;
                        CqlDateTime aj_ = context.Operators.Convert<CqlDateTime>(ai_);
                        Period ak_ = ElevatedEncounter?.Period;
                        CqlInterval<CqlDateTime> al_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ak_);
                        bool? am_ = context.Operators.In<CqlDateTime>(aj_, al_, "day");
                        return am_;
                    }

                    IEnumerable<ServiceRequest> af_ = context.Operators.Where<ServiceRequest>(ad_, ae_);
                    Encounter ag_(ServiceRequest Referral) => ElevatedEncounter;
                    IEnumerable<Encounter> ah_ = context.Operators.Select<ServiceRequest, Encounter>(af_, ag_);
                    return ah_;
                }

                IEnumerable<Encounter> h_ = context.Operators.SelectMany<Encounter, Encounter>(a_, g_);
                IEnumerable<Encounter> i_ = context.Operators.Union<Encounter>(e_, h_);
                return i_;
            });


    private Cached<IEnumerable<Encounter>> _Encounter_with_Hypertensive_Reading_Within_Year_Prior_Cached = new();

    [CqlExpressionDefinition("Encounter with Hypertensive Reading Within Year Prior")]
    public IEnumerable<Encounter> Encounter_with_Hypertensive_Reading_Within_Year_Prior(CqlContext context) =>
        _Encounter_with_Hypertensive_Reading_Within_Year_Prior_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Measurement_Period(context);

                bool? b_(Encounter QualifyingEncounter) {
                    IEnumerable<Observation> d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

                    bool? e_(Observation BloodPressure) {
                        DataType bk_ = BloodPressure?.Effective;
                        object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                        CqlInterval<CqlDateTime> bm_ = QICoreCommon_4_0_000.Instance.toInterval(context, bl_);
                        CqlDateTime bn_ = context.Operators.End(bm_);
                        Period bo_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> bp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bo_);
                        CqlDateTime bq_ = context.Operators.Start(bp_);
                        CqlQuantity br_ = context.Operators.Quantity(1m, "year");
                        CqlDateTime bs_ = context.Operators.Subtract(bq_, br_);
                        CqlInterval<CqlDateTime> bu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bo_);
                        CqlDateTime bv_ = context.Operators.Start(bu_);
                        CqlInterval<CqlDateTime> bw_ = context.Operators.Interval(bs_, bv_, true, true);
                        bool? bx_ = context.Operators.In<CqlDateTime>(bn_, bw_, default);
                        CqlInterval<CqlDateTime> bz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bo_);
                        CqlDateTime ca_ = context.Operators.Start(bz_);
                        bool? cb_ = context.Operators.Not((bool?)(ca_ is null));
                        bool? cc_ = context.Operators.And(bx_, cb_);
                        Code<ObservationStatus> cd_ = BloodPressure?.StatusElement;
                        ObservationStatus? ce_ = cd_?.Value;
                        string cf_ = context.Operators.Convert<string>(ce_);
                        string[] cg_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? ch_ = context.Operators.In<string>(cf_, (IEnumerable<string>)cg_);
                        bool? ci_ = context.Operators.And(cc_, ch_);
                        return ci_;
                    }

                    IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);

                    object g_(Observation @this) {
                        DataType cj_ = @this?.Effective;
                        object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                        CqlInterval<CqlDateTime> cl_ = QICoreCommon_4_0_000.Instance.toInterval(context, ck_);
                        CqlDateTime cm_ = context.Operators.Start(cl_);
                        return cm_;
                    }

                    IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation i_ = context.Operators.Last<Observation>(h_);
                    List<Observation.ComponentComponent> j_ = i_?.Component;

                    bool? k_(Observation.ComponentComponent C) {
                        CodeableConcept cn_ = C?.Code;
                        CqlConcept co_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cn_);
                        CqlCode cp_ = this.Systolic_blood_pressure(context);
                        CqlConcept cq_ = context.Operators.ConvertCodeToConcept(cp_);
                        bool? cr_ = context.Operators.Equivalent(co_, cq_);
                        return cr_;
                    }

                    IEnumerable<Observation.ComponentComponent> l_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)j_, k_);
                    Observation.ComponentComponent m_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(l_);
                    DataType n_ = m_?.Value;
                    object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                    CqlQuantity p_ = context.Operators.Quantity(0m, "mm[Hg]");
                    bool? q_ = context.Operators.Greater(o_ as CqlQuantity, p_);

                    bool? s_(Observation BloodPressure) {
                        DataType cs_ = BloodPressure?.Effective;
                        object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                        CqlInterval<CqlDateTime> cu_ = QICoreCommon_4_0_000.Instance.toInterval(context, ct_);
                        CqlDateTime cv_ = context.Operators.End(cu_);
                        Period cw_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> cx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cw_);
                        CqlDateTime cy_ = context.Operators.Start(cx_);
                        CqlQuantity cz_ = context.Operators.Quantity(1m, "year");
                        CqlDateTime da_ = context.Operators.Subtract(cy_, cz_);
                        CqlInterval<CqlDateTime> dc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cw_);
                        CqlDateTime dd_ = context.Operators.Start(dc_);
                        CqlInterval<CqlDateTime> de_ = context.Operators.Interval(da_, dd_, true, true);
                        bool? df_ = context.Operators.In<CqlDateTime>(cv_, de_, default);
                        CqlInterval<CqlDateTime> dh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cw_);
                        CqlDateTime di_ = context.Operators.Start(dh_);
                        bool? dj_ = context.Operators.Not((bool?)(di_ is null));
                        bool? dk_ = context.Operators.And(df_, dj_);
                        Code<ObservationStatus> dl_ = BloodPressure?.StatusElement;
                        ObservationStatus? dm_ = dl_?.Value;
                        string dn_ = context.Operators.Convert<string>(dm_);
                        string[] do_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? dp_ = context.Operators.In<string>(dn_, (IEnumerable<string>)do_);
                        bool? dq_ = context.Operators.And(dk_, dp_);
                        return dq_;
                    }

                    IEnumerable<Observation> t_ = context.Operators.Where<Observation>(d_, s_);

                    object u_(Observation @this) {
                        DataType dr_ = @this?.Effective;
                        object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                        CqlInterval<CqlDateTime> dt_ = QICoreCommon_4_0_000.Instance.toInterval(context, ds_);
                        CqlDateTime du_ = context.Operators.Start(dt_);
                        return du_;
                    }

                    IEnumerable<Observation> v_ = context.Operators.SortBy<Observation>(t_, u_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation w_ = context.Operators.Last<Observation>(v_);
                    List<Observation.ComponentComponent> x_ = w_?.Component;

                    bool? y_(Observation.ComponentComponent C) {
                        CodeableConcept dv_ = C?.Code;
                        CqlConcept dw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dv_);
                        CqlCode dx_ = this.Diastolic_blood_pressure(context);
                        CqlConcept dy_ = context.Operators.ConvertCodeToConcept(dx_);
                        bool? dz_ = context.Operators.Equivalent(dw_, dy_);
                        return dz_;
                    }

                    IEnumerable<Observation.ComponentComponent> z_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)x_, y_);
                    Observation.ComponentComponent aa_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(z_);
                    DataType ab_ = aa_?.Value;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool? ae_ = context.Operators.Greater(ac_ as CqlQuantity, p_);
                    bool? af_ = context.Operators.And(q_, ae_);

                    bool? ah_(Observation BloodPressure) {
                        DataType ea_ = BloodPressure?.Effective;
                        object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                        CqlInterval<CqlDateTime> ec_ = QICoreCommon_4_0_000.Instance.toInterval(context, eb_);
                        CqlDateTime ed_ = context.Operators.End(ec_);
                        Period ee_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> ef_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ee_);
                        CqlDateTime eg_ = context.Operators.Start(ef_);
                        CqlQuantity eh_ = context.Operators.Quantity(1m, "year");
                        CqlDateTime ei_ = context.Operators.Subtract(eg_, eh_);
                        CqlInterval<CqlDateTime> ek_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ee_);
                        CqlDateTime el_ = context.Operators.Start(ek_);
                        CqlInterval<CqlDateTime> em_ = context.Operators.Interval(ei_, el_, true, true);
                        bool? en_ = context.Operators.In<CqlDateTime>(ed_, em_, default);
                        CqlInterval<CqlDateTime> ep_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ee_);
                        CqlDateTime eq_ = context.Operators.Start(ep_);
                        bool? er_ = context.Operators.Not((bool?)(eq_ is null));
                        bool? es_ = context.Operators.And(en_, er_);
                        Code<ObservationStatus> et_ = BloodPressure?.StatusElement;
                        ObservationStatus? eu_ = et_?.Value;
                        string ev_ = context.Operators.Convert<string>(eu_);
                        string[] ew_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? ex_ = context.Operators.In<string>(ev_, (IEnumerable<string>)ew_);
                        bool? ey_ = context.Operators.And(es_, ex_);
                        return ey_;
                    }

                    IEnumerable<Observation> ai_ = context.Operators.Where<Observation>(d_, ah_);

                    object aj_(Observation @this) {
                        DataType ez_ = @this?.Effective;
                        object fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);
                        CqlInterval<CqlDateTime> fb_ = QICoreCommon_4_0_000.Instance.toInterval(context, fa_);
                        CqlDateTime fc_ = context.Operators.Start(fb_);
                        return fc_;
                    }

                    IEnumerable<Observation> ak_ = context.Operators.SortBy<Observation>(ai_, aj_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation al_ = context.Operators.Last<Observation>(ak_);
                    List<Observation.ComponentComponent> am_ = al_?.Component;

                    bool? an_(Observation.ComponentComponent C) {
                        CodeableConcept fd_ = C?.Code;
                        CqlConcept fe_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fd_);
                        CqlCode ff_ = this.Systolic_blood_pressure(context);
                        CqlConcept fg_ = context.Operators.ConvertCodeToConcept(ff_);
                        bool? fh_ = context.Operators.Equivalent(fe_, fg_);
                        return fh_;
                    }

                    IEnumerable<Observation.ComponentComponent> ao_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)am_, an_);
                    Observation.ComponentComponent ap_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ao_);
                    DataType aq_ = ap_?.Value;
                    object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                    CqlQuantity as_ = context.Operators.Quantity(130m, "mm[Hg]");
                    bool? at_ = context.Operators.GreaterOrEqual(ar_ as CqlQuantity, as_);

                    bool? av_(Observation BloodPressure) {
                        DataType fi_ = BloodPressure?.Effective;
                        object fj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fi_);
                        CqlInterval<CqlDateTime> fk_ = QICoreCommon_4_0_000.Instance.toInterval(context, fj_);
                        CqlDateTime fl_ = context.Operators.End(fk_);
                        Period fm_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> fn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fm_);
                        CqlDateTime fo_ = context.Operators.Start(fn_);
                        CqlQuantity fp_ = context.Operators.Quantity(1m, "year");
                        CqlDateTime fq_ = context.Operators.Subtract(fo_, fp_);
                        CqlInterval<CqlDateTime> fs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fm_);
                        CqlDateTime ft_ = context.Operators.Start(fs_);
                        CqlInterval<CqlDateTime> fu_ = context.Operators.Interval(fq_, ft_, true, true);
                        bool? fv_ = context.Operators.In<CqlDateTime>(fl_, fu_, default);
                        CqlInterval<CqlDateTime> fx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fm_);
                        CqlDateTime fy_ = context.Operators.Start(fx_);
                        bool? fz_ = context.Operators.Not((bool?)(fy_ is null));
                        bool? ga_ = context.Operators.And(fv_, fz_);
                        Code<ObservationStatus> gb_ = BloodPressure?.StatusElement;
                        ObservationStatus? gc_ = gb_?.Value;
                        string gd_ = context.Operators.Convert<string>(gc_);
                        string[] ge_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? gf_ = context.Operators.In<string>(gd_, (IEnumerable<string>)ge_);
                        bool? gg_ = context.Operators.And(ga_, gf_);
                        return gg_;
                    }

                    IEnumerable<Observation> aw_ = context.Operators.Where<Observation>(d_, av_);

                    object ax_(Observation @this) {
                        DataType gh_ = @this?.Effective;
                        object gi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gh_);
                        CqlInterval<CqlDateTime> gj_ = QICoreCommon_4_0_000.Instance.toInterval(context, gi_);
                        CqlDateTime gk_ = context.Operators.Start(gj_);
                        return gk_;
                    }

                    IEnumerable<Observation> ay_ = context.Operators.SortBy<Observation>(aw_, ax_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation az_ = context.Operators.Last<Observation>(ay_);
                    List<Observation.ComponentComponent> ba_ = az_?.Component;

                    bool? bb_(Observation.ComponentComponent C) {
                        CodeableConcept gl_ = C?.Code;
                        CqlConcept gm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gl_);
                        CqlCode gn_ = this.Diastolic_blood_pressure(context);
                        CqlConcept go_ = context.Operators.ConvertCodeToConcept(gn_);
                        bool? gp_ = context.Operators.Equivalent(gm_, go_);
                        return gp_;
                    }

                    IEnumerable<Observation.ComponentComponent> bc_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ba_, bb_);
                    Observation.ComponentComponent bd_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(bc_);
                    DataType be_ = bd_?.Value;
                    object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                    CqlQuantity bg_ = context.Operators.Quantity(80m, "mm[Hg]");
                    bool? bh_ = context.Operators.GreaterOrEqual(bf_ as CqlQuantity, bg_);
                    bool? bi_ = context.Operators.Or(at_, bh_);
                    bool? bj_ = context.Operators.And(af_, bi_);
                    return bj_;
                }

                IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
                return c_;
            });


    private Cached<IEnumerable<Encounter>> _Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_Cached = new();

    [CqlExpressionDefinition("Encounter with First Hypertensive Reading SBP Greater than or Equal to 130 OR DBP Greater than or Equal to 80")]
    public IEnumerable<Encounter> Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80(CqlContext context) =>
        _Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Measurement_Period(context);

                bool? b_(Encounter QualifyingEncounter) {
                    IEnumerable<Observation> f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

                    bool? g_(Observation BloodPressure) {
                        DataType bm_ = BloodPressure?.Effective;
                        object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                        CqlInterval<CqlDateTime> bo_ = QICoreCommon_4_0_000.Instance.toInterval(context, bn_);
                        CqlDateTime bp_ = context.Operators.End(bo_);
                        Period bq_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> br_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bq_);
                        bool? bs_ = context.Operators.In<CqlDateTime>(bp_, br_, "day");
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

                    IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);

                    object i_(Observation @this) {
                        DataType bz_ = @this?.Effective;
                        object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                        CqlInterval<CqlDateTime> cb_ = QICoreCommon_4_0_000.Instance.toInterval(context, ca_);
                        CqlDateTime cc_ = context.Operators.Start(cb_);
                        return cc_;
                    }

                    IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation k_ = context.Operators.Last<Observation>(j_);
                    List<Observation.ComponentComponent> l_ = k_?.Component;

                    bool? m_(Observation.ComponentComponent C) {
                        CodeableConcept cd_ = C?.Code;
                        CqlConcept ce_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cd_);
                        CqlCode cf_ = this.Systolic_blood_pressure(context);
                        CqlConcept cg_ = context.Operators.ConvertCodeToConcept(cf_);
                        bool? ch_ = context.Operators.Equivalent(ce_, cg_);
                        return ch_;
                    }

                    IEnumerable<Observation.ComponentComponent> n_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)l_, m_);
                    Observation.ComponentComponent o_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(n_);
                    DataType p_ = o_?.Value;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    CqlQuantity r_ = context.Operators.Quantity(0m, "mm[Hg]");
                    bool? s_ = context.Operators.Greater(q_ as CqlQuantity, r_);

                    bool? u_(Observation BloodPressure) {
                        DataType ci_ = BloodPressure?.Effective;
                        object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                        CqlInterval<CqlDateTime> ck_ = QICoreCommon_4_0_000.Instance.toInterval(context, cj_);
                        CqlDateTime cl_ = context.Operators.End(ck_);
                        Period cm_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> cn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cm_);
                        bool? co_ = context.Operators.In<CqlDateTime>(cl_, cn_, "day");
                        Code<ObservationStatus> cp_ = BloodPressure?.StatusElement;
                        ObservationStatus? cq_ = cp_?.Value;
                        string cr_ = context.Operators.Convert<string>(cq_);
                        string[] cs_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? ct_ = context.Operators.In<string>(cr_, (IEnumerable<string>)cs_);
                        bool? cu_ = context.Operators.And(co_, ct_);
                        return cu_;
                    }

                    IEnumerable<Observation> v_ = context.Operators.Where<Observation>(f_, u_);

                    object w_(Observation @this) {
                        DataType cv_ = @this?.Effective;
                        object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                        CqlInterval<CqlDateTime> cx_ = QICoreCommon_4_0_000.Instance.toInterval(context, cw_);
                        CqlDateTime cy_ = context.Operators.Start(cx_);
                        return cy_;
                    }

                    IEnumerable<Observation> x_ = context.Operators.SortBy<Observation>(v_, w_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation y_ = context.Operators.Last<Observation>(x_);
                    List<Observation.ComponentComponent> z_ = y_?.Component;

                    bool? aa_(Observation.ComponentComponent C) {
                        CodeableConcept cz_ = C?.Code;
                        CqlConcept da_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cz_);
                        CqlCode db_ = this.Diastolic_blood_pressure(context);
                        CqlConcept dc_ = context.Operators.ConvertCodeToConcept(db_);
                        bool? dd_ = context.Operators.Equivalent(da_, dc_);
                        return dd_;
                    }

                    IEnumerable<Observation.ComponentComponent> ab_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)z_, aa_);
                    Observation.ComponentComponent ac_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ab_);
                    DataType ad_ = ac_?.Value;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    bool? ag_ = context.Operators.Greater(ae_ as CqlQuantity, r_);
                    bool? ah_ = context.Operators.And(s_, ag_);

                    bool? aj_(Observation BloodPressure) {
                        DataType de_ = BloodPressure?.Effective;
                        object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                        CqlInterval<CqlDateTime> dg_ = QICoreCommon_4_0_000.Instance.toInterval(context, df_);
                        CqlDateTime dh_ = context.Operators.End(dg_);
                        Period di_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> dj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, di_);
                        bool? dk_ = context.Operators.In<CqlDateTime>(dh_, dj_, "day");
                        Code<ObservationStatus> dl_ = BloodPressure?.StatusElement;
                        ObservationStatus? dm_ = dl_?.Value;
                        string dn_ = context.Operators.Convert<string>(dm_);
                        string[] do_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? dp_ = context.Operators.In<string>(dn_, (IEnumerable<string>)do_);
                        bool? dq_ = context.Operators.And(dk_, dp_);
                        return dq_;
                    }

                    IEnumerable<Observation> ak_ = context.Operators.Where<Observation>(f_, aj_);

                    object al_(Observation @this) {
                        DataType dr_ = @this?.Effective;
                        object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                        CqlInterval<CqlDateTime> dt_ = QICoreCommon_4_0_000.Instance.toInterval(context, ds_);
                        CqlDateTime du_ = context.Operators.Start(dt_);
                        return du_;
                    }

                    IEnumerable<Observation> am_ = context.Operators.SortBy<Observation>(ak_, al_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation an_ = context.Operators.Last<Observation>(am_);
                    List<Observation.ComponentComponent> ao_ = an_?.Component;

                    bool? ap_(Observation.ComponentComponent C) {
                        CodeableConcept dv_ = C?.Code;
                        CqlConcept dw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dv_);
                        CqlCode dx_ = this.Systolic_blood_pressure(context);
                        CqlConcept dy_ = context.Operators.ConvertCodeToConcept(dx_);
                        bool? dz_ = context.Operators.Equivalent(dw_, dy_);
                        return dz_;
                    }

                    IEnumerable<Observation.ComponentComponent> aq_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ao_, ap_);
                    Observation.ComponentComponent ar_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(aq_);
                    DataType as_ = ar_?.Value;
                    object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                    CqlQuantity au_ = context.Operators.Quantity(130m, "mm[Hg]");
                    bool? av_ = context.Operators.GreaterOrEqual(at_ as CqlQuantity, au_);

                    bool? ax_(Observation BloodPressure) {
                        DataType ea_ = BloodPressure?.Effective;
                        object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                        CqlInterval<CqlDateTime> ec_ = QICoreCommon_4_0_000.Instance.toInterval(context, eb_);
                        CqlDateTime ed_ = context.Operators.End(ec_);
                        Period ee_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> ef_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ee_);
                        bool? eg_ = context.Operators.In<CqlDateTime>(ed_, ef_, "day");
                        Code<ObservationStatus> eh_ = BloodPressure?.StatusElement;
                        ObservationStatus? ei_ = eh_?.Value;
                        string ej_ = context.Operators.Convert<string>(ei_);
                        string[] ek_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? el_ = context.Operators.In<string>(ej_, (IEnumerable<string>)ek_);
                        bool? em_ = context.Operators.And(eg_, el_);
                        return em_;
                    }

                    IEnumerable<Observation> ay_ = context.Operators.Where<Observation>(f_, ax_);

                    object az_(Observation @this) {
                        DataType en_ = @this?.Effective;
                        object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                        CqlInterval<CqlDateTime> ep_ = QICoreCommon_4_0_000.Instance.toInterval(context, eo_);
                        CqlDateTime eq_ = context.Operators.Start(ep_);
                        return eq_;
                    }

                    IEnumerable<Observation> ba_ = context.Operators.SortBy<Observation>(ay_, az_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation bb_ = context.Operators.Last<Observation>(ba_);
                    List<Observation.ComponentComponent> bc_ = bb_?.Component;

                    bool? bd_(Observation.ComponentComponent C) {
                        CodeableConcept er_ = C?.Code;
                        CqlConcept es_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, er_);
                        CqlCode et_ = this.Diastolic_blood_pressure(context);
                        CqlConcept eu_ = context.Operators.ConvertCodeToConcept(et_);
                        bool? ev_ = context.Operators.Equivalent(es_, eu_);
                        return ev_;
                    }

                    IEnumerable<Observation.ComponentComponent> be_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)bc_, bd_);
                    Observation.ComponentComponent bf_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(be_);
                    DataType bg_ = bf_?.Value;
                    object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                    CqlQuantity bi_ = context.Operators.Quantity(80m, "mm[Hg]");
                    bool? bj_ = context.Operators.GreaterOrEqual(bh_ as CqlQuantity, bi_);
                    bool? bk_ = context.Operators.Or(av_, bj_);
                    bool? bl_ = context.Operators.And(ah_, bk_);
                    return bl_;
                }

                IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
                IEnumerable<Encounter> d_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior(context);
                IEnumerable<Encounter> e_ = context.Operators.Except<Encounter>(c_, d_);
                return e_;
            });


    private Cached<IEnumerable<ServiceRequest>> _First_Hypertensive_Reading_Interventions_or_Referral_to_Alternate_Professional_Cached = new();

    [CqlExpressionDefinition("First Hypertensive Reading Interventions or Referral to Alternate Professional")]
    public IEnumerable<ServiceRequest> First_Hypertensive_Reading_Interventions_or_Referral_to_Alternate_Professional(CqlContext context) =>
        _First_Hypertensive_Reading_Interventions_or_Referral_to_Alternate_Professional_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlValueSet a_ = this.Follow_Up_Within_4_Weeks(context);
                IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

                IEnumerable<ServiceRequest> c_(ServiceRequest FourWeekRescreen) {
                    IEnumerable<ServiceRequest> g_ = this.NonPharmacological_Interventions(context);

                    bool? h_(ServiceRequest NonPharmInterventionsHTN) {
                        FhirDateTime l_ = FourWeekRescreen?.AuthoredOnElement;
                        CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(l_);
                        CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
                        bool? o_ = context.Operators.In<CqlDateTime>(m_, n_, "day");
                        FhirDateTime p_ = NonPharmInterventionsHTN?.AuthoredOnElement;
                        CqlDateTime q_ = context.Operators.Convert<CqlDateTime>(p_);
                        bool? s_ = context.Operators.In<CqlDateTime>(q_, n_, "day");
                        bool? t_ = context.Operators.And(o_, s_);
                        Code<RequestIntent> u_ = FourWeekRescreen?.IntentElement;
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
                        return aa_;
                    }

                    IEnumerable<ServiceRequest> i_ = context.Operators.Where<ServiceRequest>(g_, h_);
                    ServiceRequest j_(ServiceRequest NonPharmInterventionsHTN) => FourWeekRescreen;
                    IEnumerable<ServiceRequest> k_ = context.Operators.Select<ServiceRequest, ServiceRequest>(i_, j_);
                    return k_;
                }

                IEnumerable<ServiceRequest> d_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(b_, c_);
                IEnumerable<ServiceRequest> e_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(context);
                IEnumerable<ServiceRequest> f_ = context.Operators.Union<ServiceRequest>(d_, e_);
                return f_;
            });


    private Cached<IEnumerable<Encounter>> _Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_and_Interventions_Cached = new();

    [CqlExpressionDefinition("Encounter with First Hypertensive Reading SBP Greater than or Equal to 130 OR DBP Greater than or Equal to 80 and Interventions")]
    public IEnumerable<Encounter> Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_and_Interventions(CqlContext context) =>
        _Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_and_Interventions_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Encounter> a_ = this.Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80(context);

                IEnumerable<Encounter> b_(Encounter FirstHTNEncounter) {
                    IEnumerable<ServiceRequest> d_ = this.First_Hypertensive_Reading_Interventions_or_Referral_to_Alternate_Professional(context);

                    bool? e_(ServiceRequest FirstHTNIntervention) {
                        FhirDateTime i_ = FirstHTNIntervention?.AuthoredOnElement;
                        CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
                        Period k_ = FirstHTNEncounter?.Period;
                        CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                        bool? m_ = context.Operators.In<CqlDateTime>(j_, l_, "day");
                        return m_;
                    }

                    IEnumerable<ServiceRequest> f_ = context.Operators.Where<ServiceRequest>(d_, e_);
                    Encounter g_(ServiceRequest FirstHTNIntervention) => FirstHTNEncounter;
                    IEnumerable<Encounter> h_ = context.Operators.Select<ServiceRequest, Encounter>(f_, g_);
                    return h_;
                }

                IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
                return c_;
            });


    private Cached<IEnumerable<Encounter>> _Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Cached = new();

    [CqlExpressionDefinition("Encounter with Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89")]
    public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89(CqlContext context) =>
        _Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Measurement_Period(context);

                bool? b_(Encounter QualifyingEncounter) {
                    IEnumerable<Observation> f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

                    bool? g_(Observation BloodPressure) {
                        DataType br_ = BloodPressure?.Effective;
                        object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                        CqlInterval<CqlDateTime> bt_ = QICoreCommon_4_0_000.Instance.toInterval(context, bs_);
                        CqlDateTime bu_ = context.Operators.End(bt_);
                        Period bv_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> bw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bv_);
                        bool? bx_ = context.Operators.In<CqlDateTime>(bu_, bw_, "day");
                        Code<ObservationStatus> by_ = BloodPressure?.StatusElement;
                        ObservationStatus? bz_ = by_?.Value;
                        string ca_ = context.Operators.Convert<string>(bz_);
                        string[] cb_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? cc_ = context.Operators.In<string>(ca_, (IEnumerable<string>)cb_);
                        bool? cd_ = context.Operators.And(bx_, cc_);
                        return cd_;
                    }

                    IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);

                    object i_(Observation @this) {
                        DataType ce_ = @this?.Effective;
                        object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                        CqlInterval<CqlDateTime> cg_ = QICoreCommon_4_0_000.Instance.toInterval(context, cf_);
                        CqlDateTime ch_ = context.Operators.Start(cg_);
                        return ch_;
                    }

                    IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation k_ = context.Operators.Last<Observation>(j_);
                    List<Observation.ComponentComponent> l_ = k_?.Component;

                    bool? m_(Observation.ComponentComponent C) {
                        CodeableConcept ci_ = C?.Code;
                        CqlConcept cj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ci_);
                        CqlCode ck_ = this.Systolic_blood_pressure(context);
                        CqlConcept cl_ = context.Operators.ConvertCodeToConcept(ck_);
                        bool? cm_ = context.Operators.Equivalent(cj_, cl_);
                        return cm_;
                    }

                    IEnumerable<Observation.ComponentComponent> n_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)l_, m_);
                    Observation.ComponentComponent o_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(n_);
                    DataType p_ = o_?.Value;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    CqlQuantity r_ = context.Operators.Quantity(130m, "mm[Hg]");
                    CqlQuantity s_ = context.Operators.Quantity(139m, "mm[Hg]");
                    CqlInterval<CqlQuantity> t_ = context.Operators.Interval(r_, s_, true, true);
                    bool? u_ = context.Operators.In<CqlQuantity>(q_ as CqlQuantity, t_, default);

                    bool? w_(Observation BloodPressure) {
                        DataType cn_ = BloodPressure?.Effective;
                        object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                        CqlInterval<CqlDateTime> cp_ = QICoreCommon_4_0_000.Instance.toInterval(context, co_);
                        CqlDateTime cq_ = context.Operators.End(cp_);
                        Period cr_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> cs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cr_);
                        bool? ct_ = context.Operators.In<CqlDateTime>(cq_, cs_, "day");
                        Code<ObservationStatus> cu_ = BloodPressure?.StatusElement;
                        ObservationStatus? cv_ = cu_?.Value;
                        string cw_ = context.Operators.Convert<string>(cv_);
                        string[] cx_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? cy_ = context.Operators.In<string>(cw_, (IEnumerable<string>)cx_);
                        bool? cz_ = context.Operators.And(ct_, cy_);
                        return cz_;
                    }

                    IEnumerable<Observation> x_ = context.Operators.Where<Observation>(f_, w_);

                    object y_(Observation @this) {
                        DataType da_ = @this?.Effective;
                        object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                        CqlInterval<CqlDateTime> dc_ = QICoreCommon_4_0_000.Instance.toInterval(context, db_);
                        CqlDateTime dd_ = context.Operators.Start(dc_);
                        return dd_;
                    }

                    IEnumerable<Observation> z_ = context.Operators.SortBy<Observation>(x_, y_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation aa_ = context.Operators.Last<Observation>(z_);
                    List<Observation.ComponentComponent> ab_ = aa_?.Component;

                    bool? ac_(Observation.ComponentComponent C) {
                        CodeableConcept de_ = C?.Code;
                        CqlConcept df_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, de_);
                        CqlCode dg_ = this.Diastolic_blood_pressure(context);
                        CqlConcept dh_ = context.Operators.ConvertCodeToConcept(dg_);
                        bool? di_ = context.Operators.Equivalent(df_, dh_);
                        return di_;
                    }

                    IEnumerable<Observation.ComponentComponent> ad_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ab_, ac_);
                    Observation.ComponentComponent ae_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ad_);
                    DataType af_ = ae_?.Value;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    CqlQuantity ah_ = context.Operators.Quantity(80m, "mm[Hg]");
                    CqlQuantity ai_ = context.Operators.Quantity(89m, "mm[Hg]");
                    CqlInterval<CqlQuantity> aj_ = context.Operators.Interval(ah_, ai_, true, true);
                    bool? ak_ = context.Operators.In<CqlQuantity>(ag_ as CqlQuantity, aj_, default);
                    bool? al_ = context.Operators.Or(u_, ak_);

                    bool? an_(Observation BloodPressure) {
                        DataType dj_ = BloodPressure?.Effective;
                        object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                        CqlInterval<CqlDateTime> dl_ = QICoreCommon_4_0_000.Instance.toInterval(context, dk_);
                        CqlDateTime dm_ = context.Operators.End(dl_);
                        Period dn_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> do_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dn_);
                        bool? dp_ = context.Operators.In<CqlDateTime>(dm_, do_, "day");
                        Code<ObservationStatus> dq_ = BloodPressure?.StatusElement;
                        ObservationStatus? dr_ = dq_?.Value;
                        string ds_ = context.Operators.Convert<string>(dr_);
                        string[] dt_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? du_ = context.Operators.In<string>(ds_, (IEnumerable<string>)dt_);
                        bool? dv_ = context.Operators.And(dp_, du_);
                        return dv_;
                    }

                    IEnumerable<Observation> ao_ = context.Operators.Where<Observation>(f_, an_);

                    object ap_(Observation @this) {
                        DataType dw_ = @this?.Effective;
                        object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                        CqlInterval<CqlDateTime> dy_ = QICoreCommon_4_0_000.Instance.toInterval(context, dx_);
                        CqlDateTime dz_ = context.Operators.Start(dy_);
                        return dz_;
                    }

                    IEnumerable<Observation> aq_ = context.Operators.SortBy<Observation>(ao_, ap_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation ar_ = context.Operators.Last<Observation>(aq_);
                    List<Observation.ComponentComponent> as_ = ar_?.Component;

                    bool? at_(Observation.ComponentComponent C) {
                        CodeableConcept ea_ = C?.Code;
                        CqlConcept eb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ea_);
                        CqlCode ec_ = this.Systolic_blood_pressure(context);
                        CqlConcept ed_ = context.Operators.ConvertCodeToConcept(ec_);
                        bool? ee_ = context.Operators.Equivalent(eb_, ed_);
                        return ee_;
                    }

                    IEnumerable<Observation.ComponentComponent> au_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)as_, at_);
                    Observation.ComponentComponent av_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(au_);
                    DataType aw_ = av_?.Value;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    CqlQuantity ay_ = context.Operators.Quantity(140m, "mm[Hg]");
                    bool? az_ = context.Operators.GreaterOrEqual(ax_ as CqlQuantity, ay_);

                    bool? bb_(Observation BloodPressure) {
                        DataType ef_ = BloodPressure?.Effective;
                        object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
                        CqlInterval<CqlDateTime> eh_ = QICoreCommon_4_0_000.Instance.toInterval(context, eg_);
                        CqlDateTime ei_ = context.Operators.End(eh_);
                        Period ej_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> ek_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ej_);
                        bool? el_ = context.Operators.In<CqlDateTime>(ei_, ek_, "day");
                        Code<ObservationStatus> em_ = BloodPressure?.StatusElement;
                        ObservationStatus? en_ = em_?.Value;
                        string eo_ = context.Operators.Convert<string>(en_);
                        string[] ep_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? eq_ = context.Operators.In<string>(eo_, (IEnumerable<string>)ep_);
                        bool? er_ = context.Operators.And(el_, eq_);
                        return er_;
                    }

                    IEnumerable<Observation> bc_ = context.Operators.Where<Observation>(f_, bb_);

                    object bd_(Observation @this) {
                        DataType es_ = @this?.Effective;
                        object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                        CqlInterval<CqlDateTime> eu_ = QICoreCommon_4_0_000.Instance.toInterval(context, et_);
                        CqlDateTime ev_ = context.Operators.Start(eu_);
                        return ev_;
                    }

                    IEnumerable<Observation> be_ = context.Operators.SortBy<Observation>(bc_, bd_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation bf_ = context.Operators.Last<Observation>(be_);
                    List<Observation.ComponentComponent> bg_ = bf_?.Component;

                    bool? bh_(Observation.ComponentComponent C) {
                        CodeableConcept ew_ = C?.Code;
                        CqlConcept ex_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ew_);
                        CqlCode ey_ = this.Diastolic_blood_pressure(context);
                        CqlConcept ez_ = context.Operators.ConvertCodeToConcept(ey_);
                        bool? fa_ = context.Operators.Equivalent(ex_, ez_);
                        return fa_;
                    }

                    IEnumerable<Observation.ComponentComponent> bi_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)bg_, bh_);
                    Observation.ComponentComponent bj_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(bi_);
                    DataType bk_ = bj_?.Value;
                    object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    CqlQuantity bm_ = context.Operators.Quantity(90m, "mm[Hg]");
                    bool? bn_ = context.Operators.GreaterOrEqual(bl_ as CqlQuantity, bm_);
                    bool? bo_ = context.Operators.Or(az_, bn_);
                    bool? bp_ = context.Operators.Not(bo_);
                    bool? bq_ = context.Operators.And(al_, bp_);
                    return bq_;
                }

                IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
                IEnumerable<Encounter> d_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior(context);
                IEnumerable<Encounter> e_ = context.Operators.Intersect<Encounter>(c_, d_);
                return e_;
            });


    private Cached<IEnumerable<ServiceRequest>> _Laboratory_Test_or_ECG_for_Hypertension_Cached = new();

    [CqlExpressionDefinition("Laboratory Test or ECG for Hypertension")]
    public IEnumerable<ServiceRequest> Laboratory_Test_or_ECG_for_Hypertension(CqlContext context) =>
        _Laboratory_Test_or_ECG_for_Hypertension_Cached.GetOrReplace(
            context,
            () =>
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
            });


    private Cached<IEnumerable<ServiceRequest>> _Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions_Cached = new();

    [CqlExpressionDefinition("Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 and Interventions")]
    public IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions(CqlContext context) =>
        _Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<ServiceRequest> a_ = this.Follow_up_with_Rescreen_Within_6_Months(context);

                IEnumerable<ServiceRequest> b_(ServiceRequest Rescreen2to6) {
                    IEnumerable<ServiceRequest> f_ = this.Laboratory_Test_or_ECG_for_Hypertension(context);

                    bool? g_(ServiceRequest LabECGIntervention) {
                        FhirDateTime k_ = Rescreen2to6?.AuthoredOnElement;
                        CqlDateTime l_ = context.Operators.Convert<CqlDateTime>(k_);
                        CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
                        bool? n_ = context.Operators.In<CqlDateTime>(l_, m_, "day");
                        FhirDateTime o_ = LabECGIntervention?.AuthoredOnElement;
                        CqlDateTime p_ = context.Operators.Convert<CqlDateTime>(o_);
                        bool? r_ = context.Operators.In<CqlDateTime>(p_, m_, "day");
                        bool? s_ = context.Operators.And(n_, r_);
                        return s_;
                    }

                    IEnumerable<ServiceRequest> h_ = context.Operators.Where<ServiceRequest>(f_, g_);
                    ServiceRequest i_(ServiceRequest LabECGIntervention) => Rescreen2to6;
                    IEnumerable<ServiceRequest> j_ = context.Operators.Select<ServiceRequest, ServiceRequest>(h_, i_);
                    return j_;
                }

                IEnumerable<ServiceRequest> c_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(a_, b_);

                IEnumerable<ServiceRequest> d_(ServiceRequest Rescreen2to6) {
                    IEnumerable<ServiceRequest> t_ = this.NonPharmacological_Interventions(context);

                    bool? u_(ServiceRequest NonPharmSecondIntervention) {
                        FhirDateTime y_ = NonPharmSecondIntervention?.AuthoredOnElement;
                        CqlDateTime z_ = context.Operators.Convert<CqlDateTime>(y_);
                        CqlInterval<CqlDateTime> aa_ = this.Measurement_Period(context);
                        bool? ab_ = context.Operators.In<CqlDateTime>(z_, aa_, "day");
                        return ab_;
                    }

                    IEnumerable<ServiceRequest> v_ = context.Operators.Where<ServiceRequest>(t_, u_);
                    ServiceRequest w_(ServiceRequest NonPharmSecondIntervention) => Rescreen2to6;
                    IEnumerable<ServiceRequest> x_ = context.Operators.Select<ServiceRequest, ServiceRequest>(v_, w_);
                    return x_;
                }

                IEnumerable<ServiceRequest> e_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(c_, d_);
                return e_;
            });


    private Cached<IEnumerable<Encounter>> _Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions_Cached = new();

    [CqlExpressionDefinition("Encounter with Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 and Interventions")]
    public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions(CqlContext context) =>
        _Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Encounter> a_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89(context);

                IEnumerable<Encounter> b_(Encounter SecondHTNEncounterReading) {
                    IEnumerable<ServiceRequest> h_ = this.Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions(context);

                    bool? i_(ServiceRequest EncounterInterventions) {
                        FhirDateTime m_ = EncounterInterventions?.AuthoredOnElement;
                        CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
                        Period o_ = SecondHTNEncounterReading?.Period;
                        CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                        bool? q_ = context.Operators.In<CqlDateTime>(n_, p_, "day");
                        return q_;
                    }

                    IEnumerable<ServiceRequest> j_ = context.Operators.Where<ServiceRequest>(h_, i_);
                    Encounter k_(ServiceRequest EncounterInterventions) => SecondHTNEncounterReading;
                    IEnumerable<Encounter> l_ = context.Operators.Select<ServiceRequest, Encounter>(j_, k_);
                    return l_;
                }

                IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

                IEnumerable<Encounter> e_(Encounter SecondHTNEncounterReading) {
                    IEnumerable<ServiceRequest> r_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(context);

                    bool? s_(ServiceRequest ReferralForHTN) {
                        FhirDateTime w_ = ReferralForHTN?.AuthoredOnElement;
                        CqlDateTime x_ = context.Operators.Convert<CqlDateTime>(w_);
                        Period y_ = SecondHTNEncounterReading?.Period;
                        CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
                        bool? aa_ = context.Operators.In<CqlDateTime>(x_, z_, "day");
                        return aa_;
                    }

                    IEnumerable<ServiceRequest> t_ = context.Operators.Where<ServiceRequest>(r_, s_);
                    Encounter u_(ServiceRequest ReferralForHTN) => SecondHTNEncounterReading;
                    IEnumerable<Encounter> v_ = context.Operators.Select<ServiceRequest, Encounter>(t_, u_);
                    return v_;
                }

                IEnumerable<Encounter> f_ = context.Operators.SelectMany<Encounter, Encounter>(a_, e_);
                IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);
                return g_;
            });


    private Cached<IEnumerable<Encounter>> _Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Cached = new();

    [CqlExpressionDefinition("Encounter with Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90")]
    public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90(CqlContext context) =>
        _Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Measurement_Period(context);

                bool? b_(Encounter QualifyingEncounter) {
                    IEnumerable<Observation> f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

                    bool? g_(Observation BloodPressure) {
                        DataType bm_ = BloodPressure?.Effective;
                        object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                        CqlInterval<CqlDateTime> bo_ = QICoreCommon_4_0_000.Instance.toInterval(context, bn_);
                        CqlDateTime bp_ = context.Operators.End(bo_);
                        Period bq_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> br_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bq_);
                        bool? bs_ = context.Operators.In<CqlDateTime>(bp_, br_, "day");
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

                    IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);

                    object i_(Observation @this) {
                        DataType bz_ = @this?.Effective;
                        object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                        CqlInterval<CqlDateTime> cb_ = QICoreCommon_4_0_000.Instance.toInterval(context, ca_);
                        CqlDateTime cc_ = context.Operators.Start(cb_);
                        return cc_;
                    }

                    IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation k_ = context.Operators.Last<Observation>(j_);
                    List<Observation.ComponentComponent> l_ = k_?.Component;

                    bool? m_(Observation.ComponentComponent C) {
                        CodeableConcept cd_ = C?.Code;
                        CqlConcept ce_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cd_);
                        CqlCode cf_ = this.Systolic_blood_pressure(context);
                        CqlConcept cg_ = context.Operators.ConvertCodeToConcept(cf_);
                        bool? ch_ = context.Operators.Equivalent(ce_, cg_);
                        return ch_;
                    }

                    IEnumerable<Observation.ComponentComponent> n_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)l_, m_);
                    Observation.ComponentComponent o_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(n_);
                    DataType p_ = o_?.Value;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    CqlQuantity r_ = context.Operators.Quantity(0m, "mm[Hg]");
                    bool? s_ = context.Operators.Greater(q_ as CqlQuantity, r_);

                    bool? u_(Observation BloodPressure) {
                        DataType ci_ = BloodPressure?.Effective;
                        object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                        CqlInterval<CqlDateTime> ck_ = QICoreCommon_4_0_000.Instance.toInterval(context, cj_);
                        CqlDateTime cl_ = context.Operators.End(ck_);
                        Period cm_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> cn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cm_);
                        bool? co_ = context.Operators.In<CqlDateTime>(cl_, cn_, "day");
                        Code<ObservationStatus> cp_ = BloodPressure?.StatusElement;
                        ObservationStatus? cq_ = cp_?.Value;
                        string cr_ = context.Operators.Convert<string>(cq_);
                        string[] cs_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? ct_ = context.Operators.In<string>(cr_, (IEnumerable<string>)cs_);
                        bool? cu_ = context.Operators.And(co_, ct_);
                        return cu_;
                    }

                    IEnumerable<Observation> v_ = context.Operators.Where<Observation>(f_, u_);

                    object w_(Observation @this) {
                        DataType cv_ = @this?.Effective;
                        object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                        CqlInterval<CqlDateTime> cx_ = QICoreCommon_4_0_000.Instance.toInterval(context, cw_);
                        CqlDateTime cy_ = context.Operators.Start(cx_);
                        return cy_;
                    }

                    IEnumerable<Observation> x_ = context.Operators.SortBy<Observation>(v_, w_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation y_ = context.Operators.Last<Observation>(x_);
                    List<Observation.ComponentComponent> z_ = y_?.Component;

                    bool? aa_(Observation.ComponentComponent C) {
                        CodeableConcept cz_ = C?.Code;
                        CqlConcept da_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cz_);
                        CqlCode db_ = this.Diastolic_blood_pressure(context);
                        CqlConcept dc_ = context.Operators.ConvertCodeToConcept(db_);
                        bool? dd_ = context.Operators.Equivalent(da_, dc_);
                        return dd_;
                    }

                    IEnumerable<Observation.ComponentComponent> ab_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)z_, aa_);
                    Observation.ComponentComponent ac_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ab_);
                    DataType ad_ = ac_?.Value;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    bool? ag_ = context.Operators.Greater(ae_ as CqlQuantity, r_);
                    bool? ah_ = context.Operators.And(s_, ag_);

                    bool? aj_(Observation BloodPressure) {
                        DataType de_ = BloodPressure?.Effective;
                        object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                        CqlInterval<CqlDateTime> dg_ = QICoreCommon_4_0_000.Instance.toInterval(context, df_);
                        CqlDateTime dh_ = context.Operators.End(dg_);
                        Period di_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> dj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, di_);
                        bool? dk_ = context.Operators.In<CqlDateTime>(dh_, dj_, "day");
                        Code<ObservationStatus> dl_ = BloodPressure?.StatusElement;
                        ObservationStatus? dm_ = dl_?.Value;
                        string dn_ = context.Operators.Convert<string>(dm_);
                        string[] do_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? dp_ = context.Operators.In<string>(dn_, (IEnumerable<string>)do_);
                        bool? dq_ = context.Operators.And(dk_, dp_);
                        return dq_;
                    }

                    IEnumerable<Observation> ak_ = context.Operators.Where<Observation>(f_, aj_);

                    object al_(Observation @this) {
                        DataType dr_ = @this?.Effective;
                        object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                        CqlInterval<CqlDateTime> dt_ = QICoreCommon_4_0_000.Instance.toInterval(context, ds_);
                        CqlDateTime du_ = context.Operators.Start(dt_);
                        return du_;
                    }

                    IEnumerable<Observation> am_ = context.Operators.SortBy<Observation>(ak_, al_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation an_ = context.Operators.Last<Observation>(am_);
                    List<Observation.ComponentComponent> ao_ = an_?.Component;

                    bool? ap_(Observation.ComponentComponent C) {
                        CodeableConcept dv_ = C?.Code;
                        CqlConcept dw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dv_);
                        CqlCode dx_ = this.Systolic_blood_pressure(context);
                        CqlConcept dy_ = context.Operators.ConvertCodeToConcept(dx_);
                        bool? dz_ = context.Operators.Equivalent(dw_, dy_);
                        return dz_;
                    }

                    IEnumerable<Observation.ComponentComponent> aq_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ao_, ap_);
                    Observation.ComponentComponent ar_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(aq_);
                    DataType as_ = ar_?.Value;
                    object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                    CqlQuantity au_ = context.Operators.Quantity(140m, "mm[Hg]");
                    bool? av_ = context.Operators.GreaterOrEqual(at_ as CqlQuantity, au_);

                    bool? ax_(Observation BloodPressure) {
                        DataType ea_ = BloodPressure?.Effective;
                        object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                        CqlInterval<CqlDateTime> ec_ = QICoreCommon_4_0_000.Instance.toInterval(context, eb_);
                        CqlDateTime ed_ = context.Operators.End(ec_);
                        Period ee_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> ef_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ee_);
                        bool? eg_ = context.Operators.In<CqlDateTime>(ed_, ef_, "day");
                        Code<ObservationStatus> eh_ = BloodPressure?.StatusElement;
                        ObservationStatus? ei_ = eh_?.Value;
                        string ej_ = context.Operators.Convert<string>(ei_);
                        string[] ek_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? el_ = context.Operators.In<string>(ej_, (IEnumerable<string>)ek_);
                        bool? em_ = context.Operators.And(eg_, el_);
                        return em_;
                    }

                    IEnumerable<Observation> ay_ = context.Operators.Where<Observation>(f_, ax_);

                    object az_(Observation @this) {
                        DataType en_ = @this?.Effective;
                        object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                        CqlInterval<CqlDateTime> ep_ = QICoreCommon_4_0_000.Instance.toInterval(context, eo_);
                        CqlDateTime eq_ = context.Operators.Start(ep_);
                        return eq_;
                    }

                    IEnumerable<Observation> ba_ = context.Operators.SortBy<Observation>(ay_, az_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation bb_ = context.Operators.Last<Observation>(ba_);
                    List<Observation.ComponentComponent> bc_ = bb_?.Component;

                    bool? bd_(Observation.ComponentComponent C) {
                        CodeableConcept er_ = C?.Code;
                        CqlConcept es_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, er_);
                        CqlCode et_ = this.Diastolic_blood_pressure(context);
                        CqlConcept eu_ = context.Operators.ConvertCodeToConcept(et_);
                        bool? ev_ = context.Operators.Equivalent(es_, eu_);
                        return ev_;
                    }

                    IEnumerable<Observation.ComponentComponent> be_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)bc_, bd_);
                    Observation.ComponentComponent bf_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(be_);
                    DataType bg_ = bf_?.Value;
                    object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                    CqlQuantity bi_ = context.Operators.Quantity(90m, "mm[Hg]");
                    bool? bj_ = context.Operators.GreaterOrEqual(bh_ as CqlQuantity, bi_);
                    bool? bk_ = context.Operators.Or(av_, bj_);
                    bool? bl_ = context.Operators.And(ah_, bk_);
                    return bl_;
                }

                IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
                IEnumerable<Encounter> d_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior(context);
                IEnumerable<Encounter> e_ = context.Operators.Intersect<Encounter>(c_, d_);
                return e_;
            });


    private Cached<IEnumerable<ServiceRequest>> _Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Cached = new();

    [CqlExpressionDefinition("Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 Interventions")]
    public IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions(CqlContext context) =>
        _Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlValueSet a_ = this.Follow_Up_Within_4_Weeks(context);
                IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

                IEnumerable<ServiceRequest> c_(ServiceRequest WeeksRescreen) {
                    IEnumerable<ServiceRequest> i_ = this.Laboratory_Test_or_ECG_for_Hypertension(context);

                    bool? j_(ServiceRequest ECGLabTest) {
                        FhirDateTime n_ = WeeksRescreen?.AuthoredOnElement;
                        CqlDateTime o_ = context.Operators.Convert<CqlDateTime>(n_);
                        CqlInterval<CqlDateTime> p_ = this.Measurement_Period(context);
                        bool? q_ = context.Operators.In<CqlDateTime>(o_, p_, "day");
                        FhirDateTime r_ = ECGLabTest?.AuthoredOnElement;
                        CqlDateTime s_ = context.Operators.Convert<CqlDateTime>(r_);
                        bool? u_ = context.Operators.In<CqlDateTime>(s_, p_, "day");
                        bool? v_ = context.Operators.And(q_, u_);
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
                        bool? ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
                        bool? ac_ = context.Operators.And(v_, ab_);
                        Code<RequestIntent> ad_ = ECGLabTest?.IntentElement;
                        RequestIntent? ae_ = ad_?.Value;
                        Code<RequestIntent> af_ = context.Operators.Convert<Code<RequestIntent>>(ae_);
                        string ag_ = context.Operators.Convert<string>(af_);
                        bool? ai_ = context.Operators.In<string>(ag_, (IEnumerable<string>)aa_);
                        bool? aj_ = context.Operators.And(ac_, ai_);
                        return aj_;
                    }

                    IEnumerable<ServiceRequest> k_ = context.Operators.Where<ServiceRequest>(i_, j_);
                    ServiceRequest l_(ServiceRequest ECGLabTest) => WeeksRescreen;
                    IEnumerable<ServiceRequest> m_ = context.Operators.Select<ServiceRequest, ServiceRequest>(k_, l_);
                    return m_;
                }

                IEnumerable<ServiceRequest> d_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(b_, c_);

                IEnumerable<ServiceRequest> e_(ServiceRequest WeeksRescreen) {
                    IEnumerable<ServiceRequest> ak_ = this.NonPharmacological_Interventions(context);

                    bool? al_(ServiceRequest HTNInterventions) {
                        FhirDateTime ap_ = HTNInterventions?.AuthoredOnElement;
                        CqlDateTime aq_ = context.Operators.Convert<CqlDateTime>(ap_);
                        CqlInterval<CqlDateTime> ar_ = this.Measurement_Period(context);
                        bool? as_ = context.Operators.In<CqlDateTime>(aq_, ar_, "day");
                        return as_;
                    }

                    IEnumerable<ServiceRequest> am_ = context.Operators.Where<ServiceRequest>(ak_, al_);
                    ServiceRequest an_(ServiceRequest HTNInterventions) => WeeksRescreen;
                    IEnumerable<ServiceRequest> ao_ = context.Operators.Select<ServiceRequest, ServiceRequest>(am_, an_);
                    return ao_;
                }

                IEnumerable<ServiceRequest> f_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(d_, e_);

                IEnumerable<ServiceRequest> g_(ServiceRequest WeeksRescreen) {
                    CqlValueSet at_ = this.Pharmacologic_Therapy_for_Hypertension(context);
                    IEnumerable<MedicationRequest> au_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, at_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
                    IEnumerable<MedicationRequest> av_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                    IEnumerable<MedicationRequest> aw_(MedicationRequest MR) {
                        IEnumerable<Medication> bd_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                        bool? be_(Medication M) {
                            object bi_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                            object bj_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                            IEnumerable<string> bk_ = context.Operators.Split((string)bj_, "/");
                            string bl_ = context.Operators.Last<string>(bk_);
                            bool? bm_ = context.Operators.Equal(bi_, bl_);
                            CodeableConcept bn_ = M?.Code;
                            CqlConcept bo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bn_);
                            CqlValueSet bp_ = this.Pharmacologic_Therapy_for_Hypertension(context);
                            bool? bq_ = context.Operators.ConceptInValueSet(bo_, bp_);
                            bool? br_ = context.Operators.And(bm_, bq_);
                            return br_;
                        }

                        IEnumerable<Medication> bf_ = context.Operators.Where<Medication>(bd_, be_);
                        MedicationRequest bg_(Medication M) => MR;
                        IEnumerable<MedicationRequest> bh_ = context.Operators.Select<Medication, MedicationRequest>(bf_, bg_);
                        return bh_;
                    }

                    IEnumerable<MedicationRequest> ax_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(av_, aw_);
                    IEnumerable<MedicationRequest> ay_ = context.Operators.Union<MedicationRequest>(au_, ax_);

                    bool? az_(MedicationRequest Medications) {
                        FhirDateTime bs_ = Medications?.AuthoredOnElement;
                        CqlDateTime bt_ = context.Operators.Convert<CqlDateTime>(bs_);
                        CqlInterval<CqlDateTime> bu_ = this.Measurement_Period(context);
                        bool? bv_ = context.Operators.In<CqlDateTime>(bt_, bu_, "day");
                        Code<MedicationRequest.MedicationrequestStatus> bw_ = Medications?.StatusElement;
                        MedicationRequest.MedicationrequestStatus? bx_ = bw_?.Value;
                        string by_ = context.Operators.Convert<string>(bx_);
                        string[] bz_ = [
                            "active",
                            "completed",
                        ];
                        bool? ca_ = context.Operators.In<string>(by_, (IEnumerable<string>)bz_);
                        bool? cb_ = context.Operators.And(bv_, ca_);
                        return cb_;
                    }

                    IEnumerable<MedicationRequest> ba_ = context.Operators.Where<MedicationRequest>(ay_, az_);
                    ServiceRequest bb_(MedicationRequest Medications) => WeeksRescreen;
                    IEnumerable<ServiceRequest> bc_ = context.Operators.Select<MedicationRequest, ServiceRequest>(ba_, bb_);
                    return bc_;
                }

                IEnumerable<ServiceRequest> h_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(f_, g_);
                return h_;
            });


    private Cached<IEnumerable<Encounter>> _Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_and_Interventions_Cached = new();

    [CqlExpressionDefinition("Encounter with Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 and Interventions")]
    public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_and_Interventions(CqlContext context) =>
        _Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_and_Interventions_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Encounter> a_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90(context);

                IEnumerable<Encounter> b_(Encounter SecondHTNEncounterReading140Over90) {
                    IEnumerable<ServiceRequest> h_ = this.Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions(context);

                    bool? i_(ServiceRequest SecondHTN140Over90Interventions) {
                        FhirDateTime m_ = SecondHTN140Over90Interventions?.AuthoredOnElement;
                        CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
                        Period o_ = SecondHTNEncounterReading140Over90?.Period;
                        CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                        bool? q_ = context.Operators.In<CqlDateTime>(n_, p_, "day");
                        return q_;
                    }

                    IEnumerable<ServiceRequest> j_ = context.Operators.Where<ServiceRequest>(h_, i_);
                    Encounter k_(ServiceRequest SecondHTN140Over90Interventions) => SecondHTNEncounterReading140Over90;
                    IEnumerable<Encounter> l_ = context.Operators.Select<ServiceRequest, Encounter>(j_, k_);
                    return l_;
                }

                IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

                IEnumerable<Encounter> e_(Encounter SecondHTNEncounterReading140Over90) {
                    IEnumerable<ServiceRequest> r_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(context);

                    bool? s_(ServiceRequest ReferralToProfessional) {
                        FhirDateTime w_ = ReferralToProfessional?.AuthoredOnElement;
                        CqlDateTime x_ = context.Operators.Convert<CqlDateTime>(w_);
                        Period y_ = SecondHTNEncounterReading140Over90?.Period;
                        CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
                        bool? aa_ = context.Operators.In<CqlDateTime>(x_, z_, "day");
                        return aa_;
                    }

                    IEnumerable<ServiceRequest> t_ = context.Operators.Where<ServiceRequest>(r_, s_);
                    Encounter u_(ServiceRequest ReferralToProfessional) => SecondHTNEncounterReading140Over90;
                    IEnumerable<Encounter> v_ = context.Operators.Select<ServiceRequest, Encounter>(t_, u_);
                    return v_;
                }

                IEnumerable<Encounter> f_ = context.Operators.SelectMany<Encounter, Encounter>(a_, e_);
                IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);
                return g_;
            });


    private Cached<IEnumerable<Encounter>> _Numerator_Cached = new();

    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        _Numerator_Cached.GetOrReplace(
            context,
            () =>
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
            });


    private Cached<IEnumerable<Encounter>> _Encounter_with_Medical_Reason_for_Not_Obtaining_or_Patient_Declined_Blood_Pressure_Measurement_Cached = new();

    [CqlExpressionDefinition("Encounter with Medical Reason for Not Obtaining or Patient Declined Blood Pressure Measurement")]
    public IEnumerable<Encounter> Encounter_with_Medical_Reason_for_Not_Obtaining_or_Patient_Declined_Blood_Pressure_Measurement(CqlContext context) =>
        _Encounter_with_Medical_Reason_for_Not_Obtaining_or_Patient_Declined_Blood_Pressure_Measurement_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Measurement_Period(context);

                IEnumerable<Encounter> b_(Encounter QualifyingEncounter) {
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
                        Instant s_ = NoBPScreen?.IssuedElement;
                        DateTimeOffset? t_ = s_?.Value;
                        CqlDateTime u_ = context.Operators.Convert<CqlDateTime>(t_);
                        Period v_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, v_);
                        bool? x_ = context.Operators.In<CqlDateTime>(u_, w_, "day");

                        bool? y_(Extension @this) {
                            FhirUri aq_ = @this?.UrlElement;
                            FhirString ar_ = context.Operators.Convert<FhirString>(aq_);
                            string as_ = FHIRHelpers_4_4_000.Instance.ToString(context, ar_);
                            bool? at_ = context.Operators.Equal(as_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                            return at_;
                        }

                        IEnumerable<Extension> z_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoBPScreen is DomainResource
                            ? (NoBPScreen as DomainResource).Extension
                            : default), y_);

                        object aa_(Extension @this) {
                            DataType au_ = @this?.Value;
                            return au_;
                        }

                        IEnumerable<object> ab_ = context.Operators.Select<Extension, object>(z_, aa_);
                        object ac_ = context.Operators.SingletonFrom<object>(ab_);
                        CqlConcept ad_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ac_ as CodeableConcept);
                        CqlValueSet ae_ = this.Patient_Declined(context);
                        bool? af_ = context.Operators.ConceptInValueSet(ad_, ae_);

                        bool? ag_(Extension @this) {
                            FhirUri av_ = @this?.UrlElement;
                            FhirString aw_ = context.Operators.Convert<FhirString>(av_);
                            string ax_ = FHIRHelpers_4_4_000.Instance.ToString(context, aw_);
                            bool? ay_ = context.Operators.Equal(ax_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                            return ay_;
                        }

                        IEnumerable<Extension> ah_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoBPScreen is DomainResource
                            ? (NoBPScreen as DomainResource).Extension
                            : default), ag_);

                        object ai_(Extension @this) {
                            DataType az_ = @this?.Value;
                            return az_;
                        }

                        IEnumerable<object> aj_ = context.Operators.Select<Extension, object>(ah_, ai_);
                        object ak_ = context.Operators.SingletonFrom<object>(aj_);
                        CqlConcept al_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ak_ as CodeableConcept);
                        CqlValueSet am_ = this.Medical_Reason(context);
                        bool? an_ = context.Operators.ConceptInValueSet(al_, am_);
                        bool? ao_ = context.Operators.Or(af_, an_);
                        bool? ap_ = context.Operators.And(x_, ao_);
                        return ap_;
                    }

                    IEnumerable<Observation> p_ = context.Operators.Where<Observation>(n_, o_);
                    Encounter q_(Observation NoBPScreen) => QualifyingEncounter;
                    IEnumerable<Encounter> r_ = context.Operators.Select<Observation, Encounter>(p_, q_);
                    return r_;
                }

                IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
                return c_;
            });


    private Cached<IEnumerable<ServiceRequest>> _NonPharmacological_Intervention_Not_Ordered_Cached = new();

    [CqlExpressionDefinition("NonPharmacological Intervention Not Ordered")]
    public IEnumerable<ServiceRequest> NonPharmacological_Intervention_Not_Ordered(CqlContext context) =>
        _NonPharmacological_Intervention_Not_Ordered_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlValueSet a_ = this.Lifestyle_Recommendation(context);
                IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
                IEnumerable<ServiceRequest> d_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
                IEnumerable<ServiceRequest> e_ = context.Operators.Union<ServiceRequest>(b_, d_);
                CqlValueSet f_ = this.Weight_Reduction_Recommended(context);
                IEnumerable<ServiceRequest> g_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
                IEnumerable<ServiceRequest> i_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
                IEnumerable<ServiceRequest> j_ = context.Operators.Union<ServiceRequest>(g_, i_);
                IEnumerable<ServiceRequest> k_ = context.Operators.Union<ServiceRequest>(e_, j_);
                CqlValueSet l_ = this.Dietary_Recommendations(context);
                IEnumerable<ServiceRequest> m_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
                IEnumerable<ServiceRequest> o_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
                IEnumerable<ServiceRequest> p_ = context.Operators.Union<ServiceRequest>(m_, o_);
                IEnumerable<ServiceRequest> q_ = context.Operators.Union<ServiceRequest>(k_, p_);
                CqlValueSet r_ = this.Recommendation_to_Increase_Physical_Activity(context);
                IEnumerable<ServiceRequest> s_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
                IEnumerable<ServiceRequest> u_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
                IEnumerable<ServiceRequest> v_ = context.Operators.Union<ServiceRequest>(s_, u_);
                IEnumerable<ServiceRequest> w_ = context.Operators.Union<ServiceRequest>(q_, v_);
                CqlValueSet x_ = this.Referral_or_Counseling_for_Alcohol_Consumption(context);
                IEnumerable<ServiceRequest> y_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
                IEnumerable<ServiceRequest> aa_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
                IEnumerable<ServiceRequest> ab_ = context.Operators.Union<ServiceRequest>(y_, aa_);
                IEnumerable<ServiceRequest> ac_ = context.Operators.Union<ServiceRequest>(w_, ab_);

                bool? ad_(ServiceRequest NonPharmIntervention) {
                    Code<RequestStatus> af_ = NonPharmIntervention?.StatusElement;
                    RequestStatus? ag_ = af_?.Value;
                    Code<RequestStatus> ah_ = context.Operators.Convert<Code<RequestStatus>>(ag_);
                    string ai_ = context.Operators.Convert<string>(ah_);
                    string[] aj_ = [
                        "active",
                        "completed",
                        "on-hold",
                    ];
                    bool? ak_ = context.Operators.In<string>(ai_, (IEnumerable<string>)aj_);

                    bool? al_(Extension @this) {
                        FhirUri au_ = @this?.UrlElement;
                        FhirString av_ = context.Operators.Convert<FhirString>(au_);
                        string aw_ = FHIRHelpers_4_4_000.Instance.ToString(context, av_);
                        bool? ax_ = context.Operators.Equal(aw_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                        return ax_;
                    }

                    IEnumerable<Extension> am_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NonPharmIntervention is DomainResource
                        ? (NonPharmIntervention as DomainResource).Extension
                        : default), al_);

                    object an_(Extension @this) {
                        DataType ay_ = @this?.Value;
                        return ay_;
                    }

                    IEnumerable<object> ao_ = context.Operators.Select<Extension, object>(am_, an_);
                    object ap_ = context.Operators.SingletonFrom<object>(ao_);
                    CqlConcept aq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ap_ as CodeableConcept);
                    CqlValueSet ar_ = this.Patient_Declined(context);
                    bool? as_ = context.Operators.ConceptInValueSet(aq_, ar_);
                    bool? at_ = context.Operators.And(ak_, as_);
                    return at_;
                }

                IEnumerable<ServiceRequest> ae_ = context.Operators.Where<ServiceRequest>(ac_, ad_);
                return ae_;
            });


    private Cached<IEnumerable<ServiceRequest>> _Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered_Cached = new();

    [CqlExpressionDefinition("Laboratory Test or ECG for Hypertension Not Ordered")]
    public IEnumerable<ServiceRequest> Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered(CqlContext context) =>
        _Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered_Cached.GetOrReplace(
            context,
            () =>
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
                IEnumerable<ServiceRequest> k_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
                IEnumerable<ServiceRequest> l_ = context.Operators.Union<ServiceRequest>(i_, k_);
                IEnumerable<ServiceRequest> m_ = context.Operators.Union<ServiceRequest>(g_, l_);

                bool? n_(ServiceRequest LabECGNotDone) {
                    Code<RequestStatus> p_ = LabECGNotDone?.StatusElement;
                    RequestStatus? q_ = p_?.Value;
                    Code<RequestStatus> r_ = context.Operators.Convert<Code<RequestStatus>>(q_);
                    string s_ = context.Operators.Convert<string>(r_);
                    string[] t_ = [
                        "active",
                        "completed",
                        "on-hold",
                    ];
                    bool? u_ = context.Operators.In<string>(s_, (IEnumerable<string>)t_);

                    bool? v_(Extension @this) {
                        FhirUri ae_ = @this?.UrlElement;
                        FhirString af_ = context.Operators.Convert<FhirString>(ae_);
                        string ag_ = FHIRHelpers_4_4_000.Instance.ToString(context, af_);
                        bool? ah_ = context.Operators.Equal(ag_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                        return ah_;
                    }

                    IEnumerable<Extension> w_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(LabECGNotDone is DomainResource
                        ? (LabECGNotDone as DomainResource).Extension
                        : default), v_);

                    object x_(Extension @this) {
                        DataType ai_ = @this?.Value;
                        return ai_;
                    }

                    IEnumerable<object> y_ = context.Operators.Select<Extension, object>(w_, x_);
                    object z_ = context.Operators.SingletonFrom<object>(y_);
                    CqlConcept aa_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, z_ as CodeableConcept);
                    CqlValueSet ab_ = this.Patient_Declined(context);
                    bool? ac_ = context.Operators.ConceptInValueSet(aa_, ab_);
                    bool? ad_ = context.Operators.And(u_, ac_);
                    return ad_;
                }

                IEnumerable<ServiceRequest> o_ = context.Operators.Where<ServiceRequest>(m_, n_);
                return o_;
            });


    private Cached<IEnumerable<ServiceRequest>> _Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined_Cached = new();

    [CqlExpressionDefinition("Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 Interventions Declined")]
    public IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined(CqlContext context) =>
        _Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlValueSet a_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
                IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
                IEnumerable<ServiceRequest> d_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
                IEnumerable<ServiceRequest> e_ = context.Operators.Union<ServiceRequest>(b_, d_);
                CqlValueSet f_ = this.Follow_Up_Within_6_Months(context);
                IEnumerable<ServiceRequest> g_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
                IEnumerable<ServiceRequest> i_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
                IEnumerable<ServiceRequest> j_ = context.Operators.Union<ServiceRequest>(g_, i_);
                IEnumerable<ServiceRequest> k_ = context.Operators.Union<ServiceRequest>(e_, j_);

                bool? l_(ServiceRequest SecondHTNDeclinedReferralAndFollowUp) {
                    Code<RequestStatus> r_ = SecondHTNDeclinedReferralAndFollowUp?.StatusElement;
                    RequestStatus? s_ = r_?.Value;
                    Code<RequestStatus> t_ = context.Operators.Convert<Code<RequestStatus>>(s_);
                    string u_ = context.Operators.Convert<string>(t_);
                    string[] v_ = [
                        "active",
                        "completed",
                        "on-hold",
                    ];
                    bool? w_ = context.Operators.In<string>(u_, (IEnumerable<string>)v_);

                    bool? x_(Extension @this) {
                        FhirUri ag_ = @this?.UrlElement;
                        FhirString ah_ = context.Operators.Convert<FhirString>(ag_);
                        string ai_ = FHIRHelpers_4_4_000.Instance.ToString(context, ah_);
                        bool? aj_ = context.Operators.Equal(ai_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                        return aj_;
                    }

                    IEnumerable<Extension> y_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(SecondHTNDeclinedReferralAndFollowUp is DomainResource
                        ? (SecondHTNDeclinedReferralAndFollowUp as DomainResource).Extension
                        : default), x_);

                    object z_(Extension @this) {
                        DataType ak_ = @this?.Value;
                        return ak_;
                    }

                    IEnumerable<object> aa_ = context.Operators.Select<Extension, object>(y_, z_);
                    object ab_ = context.Operators.SingletonFrom<object>(aa_);
                    CqlConcept ac_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ab_ as CodeableConcept);
                    CqlValueSet ad_ = this.Patient_Declined(context);
                    bool? ae_ = context.Operators.ConceptInValueSet(ac_, ad_);
                    bool? af_ = context.Operators.And(w_, ae_);
                    return af_;
                }

                IEnumerable<ServiceRequest> m_ = context.Operators.Where<ServiceRequest>(k_, l_);
                IEnumerable<ServiceRequest> n_ = this.Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered(context);
                IEnumerable<ServiceRequest> o_ = context.Operators.Union<ServiceRequest>(m_, n_);
                IEnumerable<ServiceRequest> p_ = this.NonPharmacological_Intervention_Not_Ordered(context);
                IEnumerable<ServiceRequest> q_ = context.Operators.Union<ServiceRequest>(o_, p_);
                return q_;
            });


    private Cached<IEnumerable<object>> _Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined_Cached = new();

    [CqlExpressionDefinition("Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 Interventions Declined")]
    public IEnumerable<object> Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined(CqlContext context) =>
        _Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlValueSet a_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
                IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
                IEnumerable<ServiceRequest> d_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
                IEnumerable<ServiceRequest> e_ = context.Operators.Union<ServiceRequest>(b_, d_);
                CqlValueSet f_ = this.Follow_Up_Within_4_Weeks(context);
                IEnumerable<ServiceRequest> g_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
                IEnumerable<ServiceRequest> i_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
                IEnumerable<ServiceRequest> j_ = context.Operators.Union<ServiceRequest>(g_, i_);
                IEnumerable<ServiceRequest> k_ = context.Operators.Union<ServiceRequest>(e_, j_);

                bool? l_(ServiceRequest SecondHTN140Over90ReferralFollowUpNotDone) {
                    Code<RequestStatus> z_ = SecondHTN140Over90ReferralFollowUpNotDone?.StatusElement;
                    RequestStatus? aa_ = z_?.Value;
                    Code<RequestStatus> ab_ = context.Operators.Convert<Code<RequestStatus>>(aa_);
                    string ac_ = context.Operators.Convert<string>(ab_);
                    string[] ad_ = [
                        "active",
                        "completed",
                        "on-hold",
                    ];
                    bool? ae_ = context.Operators.In<string>(ac_, (IEnumerable<string>)ad_);

                    bool? af_(Extension @this) {
                        FhirUri ao_ = @this?.UrlElement;
                        FhirString ap_ = context.Operators.Convert<FhirString>(ao_);
                        string aq_ = FHIRHelpers_4_4_000.Instance.ToString(context, ap_);
                        bool? ar_ = context.Operators.Equal(aq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                        return ar_;
                    }

                    IEnumerable<Extension> ag_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(SecondHTN140Over90ReferralFollowUpNotDone is DomainResource
                        ? (SecondHTN140Over90ReferralFollowUpNotDone as DomainResource).Extension
                        : default), af_);

                    object ah_(Extension @this) {
                        DataType as_ = @this?.Value;
                        return as_;
                    }

                    IEnumerable<object> ai_ = context.Operators.Select<Extension, object>(ag_, ah_);
                    object aj_ = context.Operators.SingletonFrom<object>(ai_);
                    CqlConcept ak_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aj_ as CodeableConcept);
                    CqlValueSet al_ = this.Patient_Declined(context);
                    bool? am_ = context.Operators.ConceptInValueSet(ak_, al_);
                    bool? an_ = context.Operators.And(ae_, am_);
                    return an_;
                }

                IEnumerable<ServiceRequest> m_ = context.Operators.Where<ServiceRequest>(k_, l_);
                CqlValueSet n_ = this.Pharmacologic_Therapy_for_Hypertension(context);
                IEnumerable<MedicationRequest> o_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
                IEnumerable<MedicationRequest> q_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
                IEnumerable<MedicationRequest> r_ = context.Operators.Union<MedicationRequest>(o_, q_);

                bool? s_(MedicationRequest MedicationRequestNotOrdered) {
                    Code<MedicationRequest.MedicationrequestStatus> at_ = MedicationRequestNotOrdered?.StatusElement;
                    MedicationRequest.MedicationrequestStatus? au_ = at_?.Value;
                    string av_ = context.Operators.Convert<string>(au_);
                    string[] aw_ = [
                        "active",
                        "completed",
                    ];
                    bool? ax_ = context.Operators.In<string>(av_, (IEnumerable<string>)aw_);
                    return ax_;
                }

                IEnumerable<MedicationRequest> t_ = context.Operators.Where<MedicationRequest>(r_, s_);
                IEnumerable<object> u_ = context.Operators.Union<object>(m_ as IEnumerable<object>, t_ as IEnumerable<object>);
                IEnumerable<ServiceRequest> v_ = this.Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered(context);
                IEnumerable<object> w_ = context.Operators.Union<object>(u_ as IEnumerable<object>, v_ as IEnumerable<object>);
                IEnumerable<ServiceRequest> x_ = this.NonPharmacological_Intervention_Not_Ordered(context);
                IEnumerable<object> y_ = context.Operators.Union<object>(w_ as IEnumerable<object>, x_ as IEnumerable<object>);
                return y_;
            });


    private Cached<IEnumerable<Encounter>> _Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient_Cached = new();

    [CqlExpressionDefinition("Encounter with Order for Hypertension Follow Up Declined by Patient")]
    public IEnumerable<Encounter> Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient(CqlContext context) =>
        _Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Encounter> a_ = this.Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80(context);

                IEnumerable<Encounter> b_(Encounter ElevatedBPEncounter) {
                    CqlValueSet x_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
                    IEnumerable<ServiceRequest> y_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
                    IEnumerable<ServiceRequest> aa_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
                    IEnumerable<ServiceRequest> ab_ = context.Operators.Union<ServiceRequest>(y_, aa_);
                    CqlValueSet ac_ = this.Follow_Up_Within_6_Months(context);
                    IEnumerable<ServiceRequest> ad_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, ac_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
                    IEnumerable<ServiceRequest> af_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, ac_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
                    IEnumerable<ServiceRequest> ag_ = context.Operators.Union<ServiceRequest>(ad_, af_);
                    IEnumerable<ServiceRequest> ah_ = context.Operators.Union<ServiceRequest>(ab_, ag_);

                    bool? ai_(ServiceRequest ElevatedBPDeclinedInterventions) {
                        FhirDateTime am_ = ElevatedBPDeclinedInterventions?.AuthoredOnElement;
                        CqlDateTime an_ = context.Operators.Convert<CqlDateTime>(am_);
                        Period ao_ = ElevatedBPEncounter?.Period;
                        CqlInterval<CqlDateTime> ap_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ao_);
                        bool? aq_ = context.Operators.In<CqlDateTime>(an_, ap_, "day");
                        Code<RequestStatus> ar_ = ElevatedBPDeclinedInterventions?.StatusElement;
                        RequestStatus? as_ = ar_?.Value;
                        Code<RequestStatus> at_ = context.Operators.Convert<Code<RequestStatus>>(as_);
                        string au_ = context.Operators.Convert<string>(at_);
                        string[] av_ = [
                            "active",
                            "completed",
                            "on-hold",
                        ];
                        bool? aw_ = context.Operators.In<string>(au_, (IEnumerable<string>)av_);
                        bool? ax_ = context.Operators.And(aq_, aw_);

                        bool? ay_(Extension @this) {
                            FhirUri bh_ = @this?.UrlElement;
                            FhirString bi_ = context.Operators.Convert<FhirString>(bh_);
                            string bj_ = FHIRHelpers_4_4_000.Instance.ToString(context, bi_);
                            bool? bk_ = context.Operators.Equal(bj_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                            return bk_;
                        }

                        IEnumerable<Extension> az_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(ElevatedBPDeclinedInterventions is DomainResource
                            ? (ElevatedBPDeclinedInterventions as DomainResource).Extension
                            : default), ay_);

                        object ba_(Extension @this) {
                            DataType bl_ = @this?.Value;
                            return bl_;
                        }

                        IEnumerable<object> bb_ = context.Operators.Select<Extension, object>(az_, ba_);
                        object bc_ = context.Operators.SingletonFrom<object>(bb_);
                        CqlConcept bd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bc_ as CodeableConcept);
                        CqlValueSet be_ = this.Patient_Declined(context);
                        bool? bf_ = context.Operators.ConceptInValueSet(bd_, be_);
                        bool? bg_ = context.Operators.And(ax_, bf_);
                        return bg_;
                    }

                    IEnumerable<ServiceRequest> aj_ = context.Operators.Where<ServiceRequest>(ah_, ai_);
                    Encounter ak_(ServiceRequest ElevatedBPDeclinedInterventions) => ElevatedBPEncounter;
                    IEnumerable<Encounter> al_ = context.Operators.Select<ServiceRequest, Encounter>(aj_, ak_);
                    return al_;
                }

                IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

                IEnumerable<Encounter> e_(Encounter ElevatedBPEncounter) {
                    IEnumerable<ServiceRequest> bm_ = this.NonPharmacological_Intervention_Not_Ordered(context);

                    bool? bn_(ServiceRequest NotOrdered) {
                        FhirDateTime br_ = NotOrdered?.AuthoredOnElement;
                        CqlDateTime bs_ = context.Operators.Convert<CqlDateTime>(br_);
                        Period bt_ = ElevatedBPEncounter?.Period;
                        CqlInterval<CqlDateTime> bu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bt_);
                        bool? bv_ = context.Operators.In<CqlDateTime>(bs_, bu_, "day");
                        return bv_;
                    }

                    IEnumerable<ServiceRequest> bo_ = context.Operators.Where<ServiceRequest>(bm_, bn_);
                    Encounter bp_(ServiceRequest NotOrdered) => ElevatedBPEncounter;
                    IEnumerable<Encounter> bq_ = context.Operators.Select<ServiceRequest, Encounter>(bo_, bp_);
                    return bq_;
                }

                IEnumerable<Encounter> f_ = context.Operators.SelectMany<Encounter, Encounter>(a_, e_);
                IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);
                IEnumerable<Encounter> h_ = this.Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80(context);

                IEnumerable<Encounter> i_(Encounter FirstHTNEncounter) {
                    CqlValueSet bw_ = this.Follow_Up_Within_4_Weeks(context);
                    IEnumerable<ServiceRequest> bx_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, bw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
                    IEnumerable<ServiceRequest> bz_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, bw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
                    IEnumerable<ServiceRequest> ca_ = context.Operators.Union<ServiceRequest>(bx_, bz_);
                    CqlValueSet cb_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
                    IEnumerable<ServiceRequest> cc_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, cb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
                    IEnumerable<ServiceRequest> ce_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, cb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
                    IEnumerable<ServiceRequest> cf_ = context.Operators.Union<ServiceRequest>(cc_, ce_);
                    IEnumerable<ServiceRequest> cg_ = context.Operators.Union<ServiceRequest>(ca_, cf_);

                    bool? ch_(ServiceRequest FirstHTNDeclinedInterventions) {
                        FhirDateTime cl_ = FirstHTNDeclinedInterventions?.AuthoredOnElement;
                        CqlDateTime cm_ = context.Operators.Convert<CqlDateTime>(cl_);
                        Period cn_ = FirstHTNEncounter?.Period;
                        CqlInterval<CqlDateTime> co_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cn_);
                        bool? cp_ = context.Operators.In<CqlDateTime>(cm_, co_, "day");
                        Code<RequestStatus> cq_ = FirstHTNDeclinedInterventions?.StatusElement;
                        RequestStatus? cr_ = cq_?.Value;
                        Code<RequestStatus> cs_ = context.Operators.Convert<Code<RequestStatus>>(cr_);
                        string ct_ = context.Operators.Convert<string>(cs_);
                        string[] cu_ = [
                            "active",
                            "completed",
                            "on-hold",
                        ];
                        bool? cv_ = context.Operators.In<string>(ct_, (IEnumerable<string>)cu_);
                        bool? cw_ = context.Operators.And(cp_, cv_);

                        bool? cx_(Extension @this) {
                            FhirUri dg_ = @this?.UrlElement;
                            FhirString dh_ = context.Operators.Convert<FhirString>(dg_);
                            string di_ = FHIRHelpers_4_4_000.Instance.ToString(context, dh_);
                            bool? dj_ = context.Operators.Equal(di_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                            return dj_;
                        }

                        IEnumerable<Extension> cy_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(FirstHTNDeclinedInterventions is DomainResource
                            ? (FirstHTNDeclinedInterventions as DomainResource).Extension
                            : default), cx_);

                        object cz_(Extension @this) {
                            DataType dk_ = @this?.Value;
                            return dk_;
                        }

                        IEnumerable<object> da_ = context.Operators.Select<Extension, object>(cy_, cz_);
                        object db_ = context.Operators.SingletonFrom<object>(da_);
                        CqlConcept dc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, db_ as CodeableConcept);
                        CqlValueSet dd_ = this.Patient_Declined(context);
                        bool? de_ = context.Operators.ConceptInValueSet(dc_, dd_);
                        bool? df_ = context.Operators.And(cw_, de_);
                        return df_;
                    }

                    IEnumerable<ServiceRequest> ci_ = context.Operators.Where<ServiceRequest>(cg_, ch_);
                    Encounter cj_(ServiceRequest FirstHTNDeclinedInterventions) => FirstHTNEncounter;
                    IEnumerable<Encounter> ck_ = context.Operators.Select<ServiceRequest, Encounter>(ci_, cj_);
                    return ck_;
                }

                IEnumerable<Encounter> j_ = context.Operators.SelectMany<Encounter, Encounter>(h_, i_);

                IEnumerable<Encounter> l_(Encounter FirstHTNEncounter) {
                    IEnumerable<ServiceRequest> dl_ = this.NonPharmacological_Intervention_Not_Ordered(context);

                    bool? dm_(ServiceRequest NoNonPharm) {
                        FhirDateTime dq_ = NoNonPharm?.AuthoredOnElement;
                        CqlDateTime dr_ = context.Operators.Convert<CqlDateTime>(dq_);
                        Period ds_ = FirstHTNEncounter?.Period;
                        CqlInterval<CqlDateTime> dt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ds_);
                        bool? du_ = context.Operators.In<CqlDateTime>(dr_, dt_, "day");
                        return du_;
                    }

                    IEnumerable<ServiceRequest> dn_ = context.Operators.Where<ServiceRequest>(dl_, dm_);
                    Encounter do_(ServiceRequest NoNonPharm) => FirstHTNEncounter;
                    IEnumerable<Encounter> dp_ = context.Operators.Select<ServiceRequest, Encounter>(dn_, do_);
                    return dp_;
                }

                IEnumerable<Encounter> m_ = context.Operators.SelectMany<Encounter, Encounter>(h_, l_);
                IEnumerable<Encounter> n_ = context.Operators.Union<Encounter>(j_, m_);
                IEnumerable<Encounter> o_ = context.Operators.Union<Encounter>(g_, n_);
                IEnumerable<Encounter> p_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89(context);

                IEnumerable<Encounter> q_(Encounter SecondHTNEncounter) {
                    IEnumerable<ServiceRequest> dv_ = this.Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined(context);

                    bool? dw_(ServiceRequest SecondHTNDeclinedInterventions) {
                        FhirDateTime ea_ = SecondHTNDeclinedInterventions?.AuthoredOnElement;
                        CqlDateTime eb_ = context.Operators.Convert<CqlDateTime>(ea_);
                        Period ec_ = SecondHTNEncounter?.Period;
                        CqlInterval<CqlDateTime> ed_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ec_);
                        bool? ee_ = context.Operators.In<CqlDateTime>(eb_, ed_, "day");
                        return ee_;
                    }

                    IEnumerable<ServiceRequest> dx_ = context.Operators.Where<ServiceRequest>(dv_, dw_);
                    Encounter dy_(ServiceRequest SecondHTNDeclinedInterventions) => SecondHTNEncounter;
                    IEnumerable<Encounter> dz_ = context.Operators.Select<ServiceRequest, Encounter>(dx_, dy_);
                    return dz_;
                }

                IEnumerable<Encounter> r_ = context.Operators.SelectMany<Encounter, Encounter>(p_, q_);
                IEnumerable<Encounter> s_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90(context);

                IEnumerable<Encounter> t_(Encounter SecondHTN140Over90Encounter) {
                    IEnumerable<object> ef_ = this.Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined(context);

                    bool? eg_(object SecondHTN140Over90DeclinedInterventions) {
                        object ek_ = context.Operators.LateBoundProperty<object>(SecondHTN140Over90DeclinedInterventions, "authoredOn");
                        CqlDateTime el_ = context.Operators.LateBoundProperty<CqlDateTime>(ek_, "value");
                        Period em_ = SecondHTN140Over90Encounter?.Period;
                        CqlInterval<CqlDateTime> en_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, em_);
                        bool? eo_ = context.Operators.In<CqlDateTime>(el_, en_, "day");
                        return eo_;
                    }

                    IEnumerable<object> eh_ = context.Operators.Where<object>(ef_, eg_);
                    Encounter ei_(object SecondHTN140Over90DeclinedInterventions) => SecondHTN140Over90Encounter;
                    IEnumerable<Encounter> ej_ = context.Operators.Select<object, Encounter>(eh_, ei_);
                    return ej_;
                }

                IEnumerable<Encounter> u_ = context.Operators.SelectMany<Encounter, Encounter>(s_, t_);
                IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(r_, u_);
                IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(o_, v_);
                return w_;
            });


    private Cached<IEnumerable<Encounter>> _Denominator_Exceptions_Cached = new();

    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context) =>
        _Denominator_Exceptions_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Encounter> a_ = this.Encounter_with_Medical_Reason_for_Not_Obtaining_or_Patient_Declined_Blood_Pressure_Measurement(context);
                IEnumerable<Encounter> b_ = this.Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient(context);
                IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
                return c_;
            });


    private Cached<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> _SDE_Ethnicity_Cached = new();

    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        _SDE_Ethnicity_Cached.GetOrReplace(
            context,
            () =>
            {
                (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
                return a_;
            });


    private Cached<IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>> _SDE_Payer_Cached = new();

    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        _SDE_Payer_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
                return a_;
            });


    private Cached<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> _SDE_Race_Cached = new();

    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        _SDE_Race_Cached.GetOrReplace(
            context,
            () =>
            {
                (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
                return a_;
            });


    private Cached<CqlCode> _SDE_Sex_Cached = new();

    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        _SDE_Sex_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
                return a_;
            });


    #endregion Functions and Expressions

}
