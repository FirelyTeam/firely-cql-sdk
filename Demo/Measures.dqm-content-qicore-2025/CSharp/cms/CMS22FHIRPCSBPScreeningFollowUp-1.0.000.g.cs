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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.8.0")]
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
            Code<Encounter.EncounterStatus> j_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? k_ = j_?.Value;
            Code<Encounter.EncounterStatus> l_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(k_);
            CqlBoolean m_ = context.Operators.Equivalent(l_, "finished");
            CqlBoolean n_ = m_;
            Coding o_ = ValidEncounter?.Class;
            CqlCode p_ = FHIRHelpers_4_4_000.Instance.ToCode(context, o_);
            CqlCode q_ = this.@virtual(context);
            CqlBoolean r_ = context.Operators.Equivalent(p_, q_);
            CqlBoolean s_ = (CqlBoolean)!r_;
            return i_
                /* CQL 'and' (145:11-146:44) */ && n_
                /* CQL 'and' (145:5-147:43) */ && s_;
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
        CqlCode c_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept d_ = context.Operators.ConvertCodeToConcept(c_);
        CqlBoolean e_ = context.Operators.Equivalent(b_, d_);
        CqlCode f_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
        CqlConcept g_ = context.Operators.ConvertCodeToConcept(f_);
        CqlBoolean h_ = context.Operators.Equivalent(b_, g_);
        CqlBoolean i_ = h_;
        CqlCode j_ = QICoreCommon_4_0_000.Instance.provisional(context);
        CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
        CqlBoolean l_ = context.Operators.Equivalent(b_, k_);
        CqlBoolean m_ = l_;
        CqlCode n_ = QICoreCommon_4_0_000.Instance.differential(context);
        CqlConcept o_ = context.Operators.ConvertCodeToConcept(n_);
        CqlBoolean p_ = context.Operators.Equivalent(b_, o_);
        CqlBoolean q_ = p_;
        CqlBoolean r_ = e_
            /* CQL 'or' (408:54-409:66) */ || i_
            /* CQL 'or' (408:54-410:66) */ || m_
            /* CQL 'or' (408:52-412:3) */ || q_;
        return (CqlBoolean)(b_ is null)
            /* CQL 'implies' (408:3-412:3) */ || r_;
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
                DataType ai_ = BloodPressure?.Effective;
                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                CqlInterval<CqlDateTime> ak_ = QICoreCommon_4_0_000.Instance.toInterval(context, aj_);
                CqlDateTime al_ = context.Operators.End(ak_);
                Period am_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> an_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, am_);
                CqlBoolean ao_ = context.Operators.In<CqlDateTime>(al_, an_, "day");
                Code<ObservationStatus> ap_ = BloodPressure?.StatusElement;
                ObservationStatus? aq_ = ap_?.Value;
                string ar_ = context.Operators.Convert<string>(aq_);
                string[] as_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean at_ = context.Operators.In<string>(ar_, (IEnumerable<string>)as_);
                CqlBoolean au_ = at_;
                return ao_
                    /* CQL 'and' (164:9-165:73) */ && au_;
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
                CqlBoolean bd_ = context.Operators.Equivalent(ba_, bc_);
                return bd_;
            }

            IEnumerable<Observation.ComponentComponent> l_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)j_, k_);
            Observation.ComponentComponent m_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            CqlQuantity p_ = context.Operators.Quantity(1m, "mm[Hg]");
            CqlQuantity q_ = context.Operators.Quantity(120m, "mm[Hg]");
            CqlInterval<CqlQuantity> r_ = context.Operators.Interval(p_, q_, true, false);
            CqlBoolean s_ = context.Operators.In<CqlQuantity>(o_ as CqlQuantity, r_, (string)default);

            bool? t_(Observation BloodPressure) {
                DataType be_ = BloodPressure?.Effective;
                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                CqlInterval<CqlDateTime> bg_ = QICoreCommon_4_0_000.Instance.toInterval(context, bf_);
                CqlDateTime bh_ = context.Operators.End(bg_);
                Period bi_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bi_);
                CqlBoolean bk_ = context.Operators.In<CqlDateTime>(bh_, bj_, "day");
                Code<ObservationStatus> bl_ = BloodPressure?.StatusElement;
                ObservationStatus? bm_ = bl_?.Value;
                string bn_ = context.Operators.Convert<string>(bm_);
                string[] bo_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean bp_ = context.Operators.In<string>(bn_, (IEnumerable<string>)bo_);
                CqlBoolean bq_ = bp_;
                return bk_
                    /* CQL 'and' (164:9-165:73) */ && bq_;
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
                CqlBoolean bz_ = context.Operators.Equivalent(bw_, by_);
                return bz_;
            }

            IEnumerable<Observation.ComponentComponent> aa_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)y_, z_);
            Observation.ComponentComponent ab_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(aa_);
            DataType ac_ = ab_?.Value;
            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
            CqlQuantity ae_ = context.Operators.Quantity(80m, "mm[Hg]");
            CqlInterval<CqlQuantity> af_ = context.Operators.Interval(p_, ae_, true, false);
            CqlBoolean ag_ = context.Operators.In<CqlQuantity>(ad_ as CqlQuantity, af_, (string)default);
            CqlBoolean ah_ = ag_;
            return s_
                /* CQL 'and' (168:5-175:51) */ && ah_;
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
                CqlBoolean ap_ = context.Operators.In<CqlDateTime>(am_, ao_, "day");
                Code<ObservationStatus> aq_ = BloodPressure?.StatusElement;
                ObservationStatus? ar_ = aq_?.Value;
                string as_ = context.Operators.Convert<string>(ar_);
                string[] at_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean au_ = context.Operators.In<string>(as_, (IEnumerable<string>)at_);
                CqlBoolean av_ = au_;
                return ap_
                    /* CQL 'and' (180:9-181:73) */ && av_;
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
                CqlBoolean be_ = context.Operators.Equivalent(bb_, bd_);
                return be_;
            }

            IEnumerable<Observation.ComponentComponent> l_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)j_, k_);
            Observation.ComponentComponent m_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            CqlQuantity p_ = context.Operators.Quantity(120m, "mm[Hg]");
            CqlQuantity q_ = context.Operators.Quantity(129m, "mm[Hg]");
            CqlInterval<CqlQuantity> r_ = context.Operators.Interval(p_, q_, true, true);
            CqlBoolean s_ = context.Operators.In<CqlQuantity>(o_ as CqlQuantity, r_, (string)default);

            bool? t_(Observation BloodPressure) {
                DataType bf_ = BloodPressure?.Effective;
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                CqlInterval<CqlDateTime> bh_ = QICoreCommon_4_0_000.Instance.toInterval(context, bg_);
                CqlDateTime bi_ = context.Operators.End(bh_);
                Period bj_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> bk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bj_);
                CqlBoolean bl_ = context.Operators.In<CqlDateTime>(bi_, bk_, "day");
                Code<ObservationStatus> bm_ = BloodPressure?.StatusElement;
                ObservationStatus? bn_ = bm_?.Value;
                string bo_ = context.Operators.Convert<string>(bn_);
                string[] bp_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean bq_ = context.Operators.In<string>(bo_, (IEnumerable<string>)bp_);
                CqlBoolean br_ = bq_;
                return bl_
                    /* CQL 'and' (180:9-181:73) */ && br_;
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
                CqlBoolean ca_ = context.Operators.Equivalent(bx_, bz_);
                return ca_;
            }

            IEnumerable<Observation.ComponentComponent> aa_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)y_, z_);
            Observation.ComponentComponent ab_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(aa_);
            DataType ac_ = ab_?.Value;
            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
            CqlQuantity ae_ = context.Operators.Quantity(1m, "mm[Hg]");
            CqlQuantity af_ = context.Operators.Quantity(80m, "mm[Hg]");
            CqlInterval<CqlQuantity> ag_ = context.Operators.Interval(ae_, af_, true, false);
            CqlBoolean ah_ = context.Operators.In<CqlQuantity>(ad_ as CqlQuantity, ag_, (string)default);
            CqlBoolean ai_ = ah_;
            return s_
                /* CQL 'and' (184:5-192:5) */ && ai_;
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
                CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return q_;
            }

            IEnumerable<CqlConcept> g_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)e_, f_);
            CqlValueSet h_ = this.Finding_of_Elevated_Blood_Pressure_or_Hypertension(context);
            CqlBoolean i_ = context.Operators.ConceptsInValueSet(g_, h_);
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
            CqlBoolean o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);
            CqlBoolean p_ = o_;
            return i_
                /* CQL 'and' (118:5-119:108) */ && p_;
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
                CqlBoolean bq_ = context.Operators.In<CqlDateTime>(bj_, bp_, (string)default);
                CqlBoolean br_ = (CqlBoolean)(bm_ is not null);
                Code<ObservationStatus> bs_ = BloodPressure?.StatusElement;
                ObservationStatus? bt_ = bs_?.Value;
                string bu_ = context.Operators.Convert<string>(bt_);
                string[] bv_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean bw_ = context.Operators.In<string>(bu_, (IEnumerable<string>)bv_);
                CqlBoolean bx_ = bw_;
                return bq_
                    /* CQL 'and' (285:17-285:121) */ && br_
                    /* CQL 'and' (285:11-286:75) */ && bx_;
            }

            IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);

            object g_(Observation @this) {
                DataType by_ = @this?.Effective;
                object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                CqlInterval<CqlDateTime> ca_ = QICoreCommon_4_0_000.Instance.toInterval(context, bz_);
                CqlDateTime cb_ = context.Operators.Start(ca_);
                return cb_;
            }

            IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
            Observation i_ = context.Operators.Last<Observation>(h_);
            List<Observation.ComponentComponent> j_ = i_?.Component;

            bool? k_(Observation.ComponentComponent C) {
                CodeableConcept cc_ = C?.Code;
                CqlConcept cd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cc_);
                CqlCode ce_ = this.Systolic_blood_pressure(context);
                CqlConcept cf_ = context.Operators.ConvertCodeToConcept(ce_);
                CqlBoolean cg_ = context.Operators.Equivalent(cd_, cf_);
                return cg_;
            }

            IEnumerable<Observation.ComponentComponent> l_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)j_, k_);
            Observation.ComponentComponent m_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            CqlQuantity p_ = context.Operators.Quantity(0m, "mm[Hg]");
            CqlBoolean q_ = context.Operators.Greater(o_ as CqlQuantity, p_);

            bool? r_(Observation BloodPressure) {
                DataType ch_ = BloodPressure?.Effective;
                object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                CqlInterval<CqlDateTime> cj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ci_);
                CqlDateTime ck_ = context.Operators.End(cj_);
                Period cl_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> cm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cl_);
                CqlDateTime cn_ = context.Operators.Start(cm_);
                CqlQuantity co_ = context.Operators.Quantity(1m, "year");
                CqlDateTime cp_ = context.Operators.Subtract(cn_, co_);
                CqlInterval<CqlDateTime> cq_ = context.Operators.Interval(cp_, cn_, true, true);
                CqlBoolean cr_ = context.Operators.In<CqlDateTime>(ck_, cq_, (string)default);
                CqlBoolean cs_ = (CqlBoolean)(cn_ is not null);
                Code<ObservationStatus> ct_ = BloodPressure?.StatusElement;
                ObservationStatus? cu_ = ct_?.Value;
                string cv_ = context.Operators.Convert<string>(cu_);
                string[] cw_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean cx_ = context.Operators.In<string>(cv_, (IEnumerable<string>)cw_);
                CqlBoolean cy_ = cx_;
                return cr_
                    /* CQL 'and' (285:17-285:121) */ && cs_
                    /* CQL 'and' (285:11-286:75) */ && cy_;
            }

            IEnumerable<Observation> s_ = context.Operators.Where<Observation>(d_, r_);

            object t_(Observation @this) {
                DataType cz_ = @this?.Effective;
                object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                CqlInterval<CqlDateTime> db_ = QICoreCommon_4_0_000.Instance.toInterval(context, da_);
                CqlDateTime dc_ = context.Operators.Start(db_);
                return dc_;
            }

            IEnumerable<Observation> u_ = context.Operators.SortBy<Observation>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
            Observation v_ = context.Operators.Last<Observation>(u_);
            List<Observation.ComponentComponent> w_ = v_?.Component;

            bool? x_(Observation.ComponentComponent C) {
                CodeableConcept dd_ = C?.Code;
                CqlConcept de_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dd_);
                CqlCode df_ = this.Diastolic_blood_pressure(context);
                CqlConcept dg_ = context.Operators.ConvertCodeToConcept(df_);
                CqlBoolean dh_ = context.Operators.Equivalent(de_, dg_);
                return dh_;
            }

            IEnumerable<Observation.ComponentComponent> y_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)w_, x_);
            Observation.ComponentComponent z_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(y_);
            DataType aa_ = z_?.Value;
            object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
            CqlBoolean ac_ = context.Operators.Greater(ab_ as CqlQuantity, p_);
            CqlBoolean ad_ = ac_;

            bool? ae_(Observation BloodPressure) {
                DataType di_ = BloodPressure?.Effective;
                object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                CqlInterval<CqlDateTime> dk_ = QICoreCommon_4_0_000.Instance.toInterval(context, dj_);
                CqlDateTime dl_ = context.Operators.End(dk_);
                Period dm_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> dn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dm_);
                CqlDateTime do_ = context.Operators.Start(dn_);
                CqlQuantity dp_ = context.Operators.Quantity(1m, "year");
                CqlDateTime dq_ = context.Operators.Subtract(do_, dp_);
                CqlInterval<CqlDateTime> dr_ = context.Operators.Interval(dq_, do_, true, true);
                CqlBoolean ds_ = context.Operators.In<CqlDateTime>(dl_, dr_, (string)default);
                CqlBoolean dt_ = (CqlBoolean)(do_ is not null);
                Code<ObservationStatus> du_ = BloodPressure?.StatusElement;
                ObservationStatus? dv_ = du_?.Value;
                string dw_ = context.Operators.Convert<string>(dv_);
                string[] dx_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean dy_ = context.Operators.In<string>(dw_, (IEnumerable<string>)dx_);
                CqlBoolean dz_ = dy_;
                return ds_
                    /* CQL 'and' (285:17-285:121) */ && dt_
                    /* CQL 'and' (285:11-286:75) */ && dz_;
            }

            IEnumerable<Observation> af_ = context.Operators.Where<Observation>(d_, ae_);

            object ag_(Observation @this) {
                DataType ea_ = @this?.Effective;
                object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                CqlInterval<CqlDateTime> ec_ = QICoreCommon_4_0_000.Instance.toInterval(context, eb_);
                CqlDateTime ed_ = context.Operators.Start(ec_);
                return ed_;
            }

            IEnumerable<Observation> ah_ = context.Operators.SortBy<Observation>(af_, ag_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ai_ = context.Operators.Last<Observation>(ah_);
            List<Observation.ComponentComponent> aj_ = ai_?.Component;

            bool? ak_(Observation.ComponentComponent C) {
                CodeableConcept ee_ = C?.Code;
                CqlConcept ef_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ee_);
                CqlCode eg_ = this.Systolic_blood_pressure(context);
                CqlConcept eh_ = context.Operators.ConvertCodeToConcept(eg_);
                CqlBoolean ei_ = context.Operators.Equivalent(ef_, eh_);
                return ei_;
            }

            IEnumerable<Observation.ComponentComponent> al_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)aj_, ak_);
            Observation.ComponentComponent am_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(al_);
            DataType an_ = am_?.Value;
            object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
            CqlQuantity ap_ = context.Operators.Quantity(130m, "mm[Hg]");
            CqlBoolean aq_ = context.Operators.GreaterOrEqual(ao_ as CqlQuantity, ap_);

            bool? ar_(Observation BloodPressure) {
                DataType ej_ = BloodPressure?.Effective;
                object ek_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ej_);
                CqlInterval<CqlDateTime> el_ = QICoreCommon_4_0_000.Instance.toInterval(context, ek_);
                CqlDateTime em_ = context.Operators.End(el_);
                Period en_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> eo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, en_);
                CqlDateTime ep_ = context.Operators.Start(eo_);
                CqlQuantity eq_ = context.Operators.Quantity(1m, "year");
                CqlDateTime er_ = context.Operators.Subtract(ep_, eq_);
                CqlInterval<CqlDateTime> es_ = context.Operators.Interval(er_, ep_, true, true);
                CqlBoolean et_ = context.Operators.In<CqlDateTime>(em_, es_, (string)default);
                CqlBoolean eu_ = (CqlBoolean)(ep_ is not null);
                Code<ObservationStatus> ev_ = BloodPressure?.StatusElement;
                ObservationStatus? ew_ = ev_?.Value;
                string ex_ = context.Operators.Convert<string>(ew_);
                string[] ey_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean ez_ = context.Operators.In<string>(ex_, (IEnumerable<string>)ey_);
                CqlBoolean fa_ = ez_;
                return et_
                    /* CQL 'and' (285:17-285:121) */ && eu_
                    /* CQL 'and' (285:11-286:75) */ && fa_;
            }

            IEnumerable<Observation> as_ = context.Operators.Where<Observation>(d_, ar_);

            object at_(Observation @this) {
                DataType fb_ = @this?.Effective;
                object fc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fb_);
                CqlInterval<CqlDateTime> fd_ = QICoreCommon_4_0_000.Instance.toInterval(context, fc_);
                CqlDateTime fe_ = context.Operators.Start(fd_);
                return fe_;
            }

            IEnumerable<Observation> au_ = context.Operators.SortBy<Observation>(as_, at_, System.ComponentModel.ListSortDirection.Ascending);
            Observation av_ = context.Operators.Last<Observation>(au_);
            List<Observation.ComponentComponent> aw_ = av_?.Component;

            bool? ax_(Observation.ComponentComponent C) {
                CodeableConcept ff_ = C?.Code;
                CqlConcept fg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ff_);
                CqlCode fh_ = this.Diastolic_blood_pressure(context);
                CqlConcept fi_ = context.Operators.ConvertCodeToConcept(fh_);
                CqlBoolean fj_ = context.Operators.Equivalent(fg_, fi_);
                return fj_;
            }

            IEnumerable<Observation.ComponentComponent> ay_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)aw_, ax_);
            Observation.ComponentComponent az_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ay_);
            DataType ba_ = az_?.Value;
            object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
            CqlQuantity bc_ = context.Operators.Quantity(80m, "mm[Hg]");
            CqlBoolean bd_ = context.Operators.GreaterOrEqual(bb_ as CqlQuantity, bc_);
            CqlBoolean be_ = bd_;
            CqlBoolean bf_ = aq_
                /* CQL 'or' (297:15-305:11) */ || be_;
            return q_
                /* CQL 'and' (289:15-296:30) */ && ad_
                /* CQL 'and' (289:7-306:7) */ && bf_;
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
                CqlBoolean bo_ = context.Operators.In<CqlDateTime>(bl_, bn_, "day");
                Code<ObservationStatus> bp_ = BloodPressure?.StatusElement;
                ObservationStatus? bq_ = bp_?.Value;
                string br_ = context.Operators.Convert<string>(bq_);
                string[] bs_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean bt_ = context.Operators.In<string>(br_, (IEnumerable<string>)bs_);
                CqlBoolean bu_ = bt_;
                return bo_
                    /* CQL 'and' (256:11-257:75) */ && bu_;
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
                CqlBoolean cd_ = context.Operators.Equivalent(ca_, cc_);
                return cd_;
            }

            IEnumerable<Observation.ComponentComponent> n_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)l_, m_);
            Observation.ComponentComponent o_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(n_);
            DataType p_ = o_?.Value;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlQuantity r_ = context.Operators.Quantity(0m, "mm[Hg]");
            CqlBoolean s_ = context.Operators.Greater(q_ as CqlQuantity, r_);

            bool? t_(Observation BloodPressure) {
                DataType ce_ = BloodPressure?.Effective;
                object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                CqlInterval<CqlDateTime> cg_ = QICoreCommon_4_0_000.Instance.toInterval(context, cf_);
                CqlDateTime ch_ = context.Operators.End(cg_);
                Period ci_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> cj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ci_);
                CqlBoolean ck_ = context.Operators.In<CqlDateTime>(ch_, cj_, "day");
                Code<ObservationStatus> cl_ = BloodPressure?.StatusElement;
                ObservationStatus? cm_ = cl_?.Value;
                string cn_ = context.Operators.Convert<string>(cm_);
                string[] co_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean cp_ = context.Operators.In<string>(cn_, (IEnumerable<string>)co_);
                CqlBoolean cq_ = cp_;
                return ck_
                    /* CQL 'and' (256:11-257:75) */ && cq_;
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
                CqlBoolean cz_ = context.Operators.Equivalent(cw_, cy_);
                return cz_;
            }

            IEnumerable<Observation.ComponentComponent> aa_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)y_, z_);
            Observation.ComponentComponent ab_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(aa_);
            DataType ac_ = ab_?.Value;
            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
            CqlBoolean ae_ = context.Operators.Greater(ad_ as CqlQuantity, r_);
            CqlBoolean af_ = ae_;

            bool? ag_(Observation BloodPressure) {
                DataType da_ = BloodPressure?.Effective;
                object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                CqlInterval<CqlDateTime> dc_ = QICoreCommon_4_0_000.Instance.toInterval(context, db_);
                CqlDateTime dd_ = context.Operators.End(dc_);
                Period de_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> df_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, de_);
                CqlBoolean dg_ = context.Operators.In<CqlDateTime>(dd_, df_, "day");
                Code<ObservationStatus> dh_ = BloodPressure?.StatusElement;
                ObservationStatus? di_ = dh_?.Value;
                string dj_ = context.Operators.Convert<string>(di_);
                string[] dk_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean dl_ = context.Operators.In<string>(dj_, (IEnumerable<string>)dk_);
                CqlBoolean dm_ = dl_;
                return dg_
                    /* CQL 'and' (256:11-257:75) */ && dm_;
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
                CqlBoolean dv_ = context.Operators.Equivalent(ds_, du_);
                return dv_;
            }

            IEnumerable<Observation.ComponentComponent> an_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)al_, am_);
            Observation.ComponentComponent ao_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(an_);
            DataType ap_ = ao_?.Value;
            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
            CqlQuantity ar_ = context.Operators.Quantity(130m, "mm[Hg]");
            CqlBoolean as_ = context.Operators.GreaterOrEqual(aq_ as CqlQuantity, ar_);

            bool? at_(Observation BloodPressure) {
                DataType dw_ = BloodPressure?.Effective;
                object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                CqlInterval<CqlDateTime> dy_ = QICoreCommon_4_0_000.Instance.toInterval(context, dx_);
                CqlDateTime dz_ = context.Operators.End(dy_);
                Period ea_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> eb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ea_);
                CqlBoolean ec_ = context.Operators.In<CqlDateTime>(dz_, eb_, "day");
                Code<ObservationStatus> ed_ = BloodPressure?.StatusElement;
                ObservationStatus? ee_ = ed_?.Value;
                string ef_ = context.Operators.Convert<string>(ee_);
                string[] eg_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean eh_ = context.Operators.In<string>(ef_, (IEnumerable<string>)eg_);
                CqlBoolean ei_ = eh_;
                return ec_
                    /* CQL 'and' (256:11-257:75) */ && ei_;
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
                CqlBoolean er_ = context.Operators.Equivalent(eo_, eq_);
                return er_;
            }

            IEnumerable<Observation.ComponentComponent> ba_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ay_, az_);
            Observation.ComponentComponent bb_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ba_);
            DataType bc_ = bb_?.Value;
            object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
            CqlQuantity be_ = context.Operators.Quantity(80m, "mm[Hg]");
            CqlBoolean bf_ = context.Operators.GreaterOrEqual(bd_ as CqlQuantity, be_);
            CqlBoolean bg_ = bf_;
            CqlBoolean bh_ = as_
                /* CQL 'or' (269:15-277:11) */ || bg_;
            return s_
                /* CQL 'and' (260:15-268:9) */ && af_
                /* CQL 'and' (260:7-278:7) */ && bh_;
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
                FhirDateTime n_ = NonPharmInterventionsHTN?.AuthoredOnElement;
                CqlDateTime o_ = context.Operators.Convert<CqlDateTime>(n_);
                CqlBoolean p_ = context.Operators.In<CqlDateTime>(o_, l_, "day");
                CqlBoolean q_ = p_;
                Code<RequestIntent> r_ = FourWeekRescreen?.IntentElement;
                RequestIntent? s_ = r_?.Value;
                Code<RequestIntent> t_ = context.Operators.Convert<Code<RequestIntent>>(s_);
                string u_ = context.Operators.Convert<string>(t_);
                string[] v_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                CqlBoolean w_ = context.Operators.In<string>(u_, (IEnumerable<string>)v_);
                CqlBoolean x_ = w_;
                return m_
                    /* CQL 'and' (110:19-111:84) */ && q_
                    /* CQL 'and' (110:19-112:120) */ && x_;
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
                DataType bn_ = BloodPressure?.Effective;
                object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                CqlInterval<CqlDateTime> bp_ = QICoreCommon_4_0_000.Instance.toInterval(context, bo_);
                CqlDateTime bq_ = context.Operators.End(bp_);
                Period br_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> bs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, br_);
                CqlBoolean bt_ = context.Operators.In<CqlDateTime>(bq_, bs_, "day");
                Code<ObservationStatus> bu_ = BloodPressure?.StatusElement;
                ObservationStatus? bv_ = bu_?.Value;
                string bw_ = context.Operators.Convert<string>(bv_);
                string[] bx_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean by_ = context.Operators.In<string>(bw_, (IEnumerable<string>)bx_);
                CqlBoolean bz_ = by_;
                return bt_
                    /* CQL 'and' (226:13-227:77) */ && bz_;
            }

            IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);

            object i_(Observation @this) {
                DataType ca_ = @this?.Effective;
                object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                CqlInterval<CqlDateTime> cc_ = QICoreCommon_4_0_000.Instance.toInterval(context, cb_);
                CqlDateTime cd_ = context.Operators.Start(cc_);
                return cd_;
            }

            IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Observation k_ = context.Operators.Last<Observation>(j_);
            List<Observation.ComponentComponent> l_ = k_?.Component;

            bool? m_(Observation.ComponentComponent C) {
                CodeableConcept ce_ = C?.Code;
                CqlConcept cf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ce_);
                CqlCode cg_ = this.Systolic_blood_pressure(context);
                CqlConcept ch_ = context.Operators.ConvertCodeToConcept(cg_);
                CqlBoolean ci_ = context.Operators.Equivalent(cf_, ch_);
                return ci_;
            }

            IEnumerable<Observation.ComponentComponent> n_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)l_, m_);
            Observation.ComponentComponent o_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(n_);
            DataType p_ = o_?.Value;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlQuantity r_ = context.Operators.Quantity(130m, "mm[Hg]");
            CqlQuantity s_ = context.Operators.Quantity(139m, "mm[Hg]");
            CqlInterval<CqlQuantity> t_ = context.Operators.Interval(r_, s_, true, true);
            CqlBoolean u_ = context.Operators.In<CqlQuantity>(q_ as CqlQuantity, t_, (string)default);

            bool? v_(Observation BloodPressure) {
                DataType cj_ = BloodPressure?.Effective;
                object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                CqlInterval<CqlDateTime> cl_ = QICoreCommon_4_0_000.Instance.toInterval(context, ck_);
                CqlDateTime cm_ = context.Operators.End(cl_);
                Period cn_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> co_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cn_);
                CqlBoolean cp_ = context.Operators.In<CqlDateTime>(cm_, co_, "day");
                Code<ObservationStatus> cq_ = BloodPressure?.StatusElement;
                ObservationStatus? cr_ = cq_?.Value;
                string cs_ = context.Operators.Convert<string>(cr_);
                string[] ct_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean cu_ = context.Operators.In<string>(cs_, (IEnumerable<string>)ct_);
                CqlBoolean cv_ = cu_;
                return cp_
                    /* CQL 'and' (226:13-227:77) */ && cv_;
            }

            IEnumerable<Observation> w_ = context.Operators.Where<Observation>(f_, v_);

            object x_(Observation @this) {
                DataType cw_ = @this?.Effective;
                object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                CqlInterval<CqlDateTime> cy_ = QICoreCommon_4_0_000.Instance.toInterval(context, cx_);
                CqlDateTime cz_ = context.Operators.Start(cy_);
                return cz_;
            }

            IEnumerable<Observation> y_ = context.Operators.SortBy<Observation>(w_, x_, System.ComponentModel.ListSortDirection.Ascending);
            Observation z_ = context.Operators.Last<Observation>(y_);
            List<Observation.ComponentComponent> aa_ = z_?.Component;

            bool? ab_(Observation.ComponentComponent C) {
                CodeableConcept da_ = C?.Code;
                CqlConcept db_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, da_);
                CqlCode dc_ = this.Diastolic_blood_pressure(context);
                CqlConcept dd_ = context.Operators.ConvertCodeToConcept(dc_);
                CqlBoolean de_ = context.Operators.Equivalent(db_, dd_);
                return de_;
            }

            IEnumerable<Observation.ComponentComponent> ac_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)aa_, ab_);
            Observation.ComponentComponent ad_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ac_);
            DataType ae_ = ad_?.Value;
            object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
            CqlQuantity ag_ = context.Operators.Quantity(80m, "mm[Hg]");
            CqlQuantity ah_ = context.Operators.Quantity(89m, "mm[Hg]");
            CqlInterval<CqlQuantity> ai_ = context.Operators.Interval(ag_, ah_, true, true);
            CqlBoolean aj_ = context.Operators.In<CqlQuantity>(af_ as CqlQuantity, ai_, (string)default);
            CqlBoolean ak_ = aj_;

            bool? al_(Observation BloodPressure) {
                DataType df_ = BloodPressure?.Effective;
                object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                CqlInterval<CqlDateTime> dh_ = QICoreCommon_4_0_000.Instance.toInterval(context, dg_);
                CqlDateTime di_ = context.Operators.End(dh_);
                Period dj_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> dk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dj_);
                CqlBoolean dl_ = context.Operators.In<CqlDateTime>(di_, dk_, "day");
                Code<ObservationStatus> dm_ = BloodPressure?.StatusElement;
                ObservationStatus? dn_ = dm_?.Value;
                string do_ = context.Operators.Convert<string>(dn_);
                string[] dp_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean dq_ = context.Operators.In<string>(do_, (IEnumerable<string>)dp_);
                CqlBoolean dr_ = dq_;
                return dl_
                    /* CQL 'and' (226:13-227:77) */ && dr_;
            }

            IEnumerable<Observation> am_ = context.Operators.Where<Observation>(f_, al_);

            object an_(Observation @this) {
                DataType ds_ = @this?.Effective;
                object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                CqlInterval<CqlDateTime> du_ = QICoreCommon_4_0_000.Instance.toInterval(context, dt_);
                CqlDateTime dv_ = context.Operators.Start(du_);
                return dv_;
            }

            IEnumerable<Observation> ao_ = context.Operators.SortBy<Observation>(am_, an_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ap_ = context.Operators.Last<Observation>(ao_);
            List<Observation.ComponentComponent> aq_ = ap_?.Component;

            bool? ar_(Observation.ComponentComponent C) {
                CodeableConcept dw_ = C?.Code;
                CqlConcept dx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dw_);
                CqlCode dy_ = this.Systolic_blood_pressure(context);
                CqlConcept dz_ = context.Operators.ConvertCodeToConcept(dy_);
                CqlBoolean ea_ = context.Operators.Equivalent(dx_, dz_);
                return ea_;
            }

            IEnumerable<Observation.ComponentComponent> as_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)aq_, ar_);
            Observation.ComponentComponent at_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(as_);
            DataType au_ = at_?.Value;
            object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
            CqlQuantity aw_ = context.Operators.Quantity(140m, "mm[Hg]");
            CqlBoolean ax_ = context.Operators.GreaterOrEqual(av_ as CqlQuantity, aw_);

            bool? ay_(Observation BloodPressure) {
                DataType eb_ = BloodPressure?.Effective;
                object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                CqlInterval<CqlDateTime> ed_ = QICoreCommon_4_0_000.Instance.toInterval(context, ec_);
                CqlDateTime ee_ = context.Operators.End(ed_);
                Period ef_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> eg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ef_);
                CqlBoolean eh_ = context.Operators.In<CqlDateTime>(ee_, eg_, "day");
                Code<ObservationStatus> ei_ = BloodPressure?.StatusElement;
                ObservationStatus? ej_ = ei_?.Value;
                string ek_ = context.Operators.Convert<string>(ej_);
                string[] el_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean em_ = context.Operators.In<string>(ek_, (IEnumerable<string>)el_);
                CqlBoolean en_ = em_;
                return eh_
                    /* CQL 'and' (226:13-227:77) */ && en_;
            }

            IEnumerable<Observation> az_ = context.Operators.Where<Observation>(f_, ay_);

            object ba_(Observation @this) {
                DataType eo_ = @this?.Effective;
                object ep_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eo_);
                CqlInterval<CqlDateTime> eq_ = QICoreCommon_4_0_000.Instance.toInterval(context, ep_);
                CqlDateTime er_ = context.Operators.Start(eq_);
                return er_;
            }

            IEnumerable<Observation> bb_ = context.Operators.SortBy<Observation>(az_, ba_, System.ComponentModel.ListSortDirection.Ascending);
            Observation bc_ = context.Operators.Last<Observation>(bb_);
            List<Observation.ComponentComponent> bd_ = bc_?.Component;

            bool? be_(Observation.ComponentComponent C) {
                CodeableConcept es_ = C?.Code;
                CqlConcept et_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, es_);
                CqlCode eu_ = this.Diastolic_blood_pressure(context);
                CqlConcept ev_ = context.Operators.ConvertCodeToConcept(eu_);
                CqlBoolean ew_ = context.Operators.Equivalent(et_, ev_);
                return ew_;
            }

            IEnumerable<Observation.ComponentComponent> bf_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)bd_, be_);
            Observation.ComponentComponent bg_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(bf_);
            DataType bh_ = bg_?.Value;
            object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
            CqlQuantity bj_ = context.Operators.Quantity(90m, "mm[Hg]");
            CqlBoolean bk_ = context.Operators.GreaterOrEqual(bi_ as CqlQuantity, bj_);
            CqlBoolean bl_ = bk_;
            CqlBoolean bm_ = (CqlBoolean)(!((bool?)(ax_
                /* CQL 'or' (239:21-247:13) */ || bl_)));
            return (u_
                /* CQL 'or' (230:17-238:11) */ || ak_)
                /* CQL 'and' (230:9-248:9) */ && bm_;
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
                FhirDateTime m_ = LabECGIntervention?.AuthoredOnElement;
                CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
                CqlBoolean o_ = context.Operators.In<CqlDateTime>(n_, k_, "day");
                CqlBoolean p_ = o_;
                return l_
                    /* CQL 'and' (138:17-139:76) */ && p_;
            }

            CqlBoolean h_ = context.Operators.WhereAny<ServiceRequest>(f_, g_);
            return h_;
        }

        IEnumerable<ServiceRequest> c_ = context.Operators.Where<ServiceRequest>(a_, b_);

        bool? d_(ServiceRequest Rescreen2to6) {
            IEnumerable<ServiceRequest> q_ = this.NonPharmacological_Interventions(context);

            bool? r_(ServiceRequest NonPharmSecondIntervention) {
                FhirDateTime t_ = NonPharmSecondIntervention?.AuthoredOnElement;
                CqlDateTime u_ = context.Operators.Convert<CqlDateTime>(t_);
                CqlInterval<CqlDateTime> v_ = this.Measurement_Period(context);
                CqlBoolean w_ = context.Operators.In<CqlDateTime>(u_, v_, "day");
                return w_;
            }

            CqlBoolean s_ = context.Operators.WhereAny<ServiceRequest>(q_, r_);
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
                DataType bi_ = BloodPressure?.Effective;
                object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                CqlInterval<CqlDateTime> bk_ = QICoreCommon_4_0_000.Instance.toInterval(context, bj_);
                CqlDateTime bl_ = context.Operators.End(bk_);
                Period bm_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> bn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bm_);
                CqlBoolean bo_ = context.Operators.In<CqlDateTime>(bl_, bn_, "day");
                Code<ObservationStatus> bp_ = BloodPressure?.StatusElement;
                ObservationStatus? bq_ = bp_?.Value;
                string br_ = context.Operators.Convert<string>(bq_);
                string[] bs_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean bt_ = context.Operators.In<string>(br_, (IEnumerable<string>)bs_);
                CqlBoolean bu_ = bt_;
                return bo_
                    /* CQL 'and' (197:13-198:77) */ && bu_;
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
                CqlBoolean cd_ = context.Operators.Equivalent(ca_, cc_);
                return cd_;
            }

            IEnumerable<Observation.ComponentComponent> n_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)l_, m_);
            Observation.ComponentComponent o_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(n_);
            DataType p_ = o_?.Value;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlQuantity r_ = context.Operators.Quantity(0m, "mm[Hg]");
            CqlBoolean s_ = context.Operators.Greater(q_ as CqlQuantity, r_);

            bool? t_(Observation BloodPressure) {
                DataType ce_ = BloodPressure?.Effective;
                object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                CqlInterval<CqlDateTime> cg_ = QICoreCommon_4_0_000.Instance.toInterval(context, cf_);
                CqlDateTime ch_ = context.Operators.End(cg_);
                Period ci_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> cj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ci_);
                CqlBoolean ck_ = context.Operators.In<CqlDateTime>(ch_, cj_, "day");
                Code<ObservationStatus> cl_ = BloodPressure?.StatusElement;
                ObservationStatus? cm_ = cl_?.Value;
                string cn_ = context.Operators.Convert<string>(cm_);
                string[] co_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean cp_ = context.Operators.In<string>(cn_, (IEnumerable<string>)co_);
                CqlBoolean cq_ = cp_;
                return ck_
                    /* CQL 'and' (197:13-198:77) */ && cq_;
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
                CqlBoolean cz_ = context.Operators.Equivalent(cw_, cy_);
                return cz_;
            }

            IEnumerable<Observation.ComponentComponent> aa_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)y_, z_);
            Observation.ComponentComponent ab_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(aa_);
            DataType ac_ = ab_?.Value;
            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
            CqlBoolean ae_ = context.Operators.Greater(ad_ as CqlQuantity, r_);
            CqlBoolean af_ = ae_;

            bool? ag_(Observation BloodPressure) {
                DataType da_ = BloodPressure?.Effective;
                object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                CqlInterval<CqlDateTime> dc_ = QICoreCommon_4_0_000.Instance.toInterval(context, db_);
                CqlDateTime dd_ = context.Operators.End(dc_);
                Period de_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> df_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, de_);
                CqlBoolean dg_ = context.Operators.In<CqlDateTime>(dd_, df_, "day");
                Code<ObservationStatus> dh_ = BloodPressure?.StatusElement;
                ObservationStatus? di_ = dh_?.Value;
                string dj_ = context.Operators.Convert<string>(di_);
                string[] dk_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean dl_ = context.Operators.In<string>(dj_, (IEnumerable<string>)dk_);
                CqlBoolean dm_ = dl_;
                return dg_
                    /* CQL 'and' (197:13-198:77) */ && dm_;
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
                CqlBoolean dv_ = context.Operators.Equivalent(ds_, du_);
                return dv_;
            }

            IEnumerable<Observation.ComponentComponent> an_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)al_, am_);
            Observation.ComponentComponent ao_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(an_);
            DataType ap_ = ao_?.Value;
            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
            CqlQuantity ar_ = context.Operators.Quantity(140m, "mm[Hg]");
            CqlBoolean as_ = context.Operators.GreaterOrEqual(aq_ as CqlQuantity, ar_);

            bool? at_(Observation BloodPressure) {
                DataType dw_ = BloodPressure?.Effective;
                object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                CqlInterval<CqlDateTime> dy_ = QICoreCommon_4_0_000.Instance.toInterval(context, dx_);
                CqlDateTime dz_ = context.Operators.End(dy_);
                Period ea_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> eb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ea_);
                CqlBoolean ec_ = context.Operators.In<CqlDateTime>(dz_, eb_, "day");
                Code<ObservationStatus> ed_ = BloodPressure?.StatusElement;
                ObservationStatus? ee_ = ed_?.Value;
                string ef_ = context.Operators.Convert<string>(ee_);
                string[] eg_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean eh_ = context.Operators.In<string>(ef_, (IEnumerable<string>)eg_);
                CqlBoolean ei_ = eh_;
                return ec_
                    /* CQL 'and' (197:13-198:77) */ && ei_;
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
                CqlBoolean er_ = context.Operators.Equivalent(eo_, eq_);
                return er_;
            }

            IEnumerable<Observation.ComponentComponent> ba_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ay_, az_);
            Observation.ComponentComponent bb_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ba_);
            DataType bc_ = bb_?.Value;
            object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
            CqlQuantity be_ = context.Operators.Quantity(90m, "mm[Hg]");
            CqlBoolean bf_ = context.Operators.GreaterOrEqual(bd_ as CqlQuantity, be_);
            CqlBoolean bg_ = bf_;
            CqlBoolean bh_ = as_
                /* CQL 'or' (209:17-217:13) */ || bg_;
            return s_
                /* CQL 'and' (201:17-208:32) */ && af_
                /* CQL 'and' (201:9-218:9) */ && bh_;
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
                FhirDateTime p_ = ECGLabTest?.AuthoredOnElement;
                CqlDateTime q_ = context.Operators.Convert<CqlDateTime>(p_);
                CqlBoolean r_ = context.Operators.In<CqlDateTime>(q_, n_, "day");
                CqlBoolean s_ = r_;
                Code<RequestIntent> t_ = WeeksRescreen?.IntentElement;
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
                CqlBoolean z_ = y_;
                Code<RequestIntent> aa_ = ECGLabTest?.IntentElement;
                RequestIntent? ab_ = aa_?.Value;
                Code<RequestIntent> ac_ = context.Operators.Convert<Code<RequestIntent>>(ab_);
                string ad_ = context.Operators.Convert<string>(ac_);
                CqlBoolean ae_ = context.Operators.In<string>(ad_, (IEnumerable<string>)x_);
                CqlBoolean af_ = ae_;
                return o_
                    /* CQL 'and' (124:19-125:70) */ && s_
                    /* CQL 'and' (124:19-126:117) */ && z_
                    /* CQL 'and' (124:19-127:114) */ && af_;
            }

            CqlBoolean k_ = context.Operators.WhereAny<ServiceRequest>(i_, j_);
            return k_;
        }

        IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);

        bool? e_(ServiceRequest WeeksRescreen) {
            IEnumerable<ServiceRequest> ag_ = this.NonPharmacological_Interventions(context);

            bool? ah_(ServiceRequest HTNInterventions) {
                FhirDateTime aj_ = HTNInterventions?.AuthoredOnElement;
                CqlDateTime ak_ = context.Operators.Convert<CqlDateTime>(aj_);
                CqlInterval<CqlDateTime> al_ = this.Measurement_Period(context);
                CqlBoolean am_ = context.Operators.In<CqlDateTime>(ak_, al_, "day");
                return am_;
            }

            CqlBoolean ai_ = context.Operators.WhereAny<ServiceRequest>(ag_, ah_);
            return ai_;
        }

        IEnumerable<ServiceRequest> f_ = context.Operators.Where<ServiceRequest>(d_, e_);

        bool? g_(ServiceRequest WeeksRescreen) {
            IEnumerable<MedicationRequest> an_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? ao_(MedicationRequest MR) {
                IEnumerable<Medication> av_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? aw_(Medication M) {
                    object ay_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object az_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> ba_ = context.Operators.Split((string)az_, "/");
                    string bb_ = context.Operators.Last<string>(ba_);
                    CqlBoolean bc_ = context.Operators.Equal(ay_, bb_);
                    CodeableConcept bd_ = M?.Code;
                    CqlConcept be_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bd_);
                    CqlValueSet bf_ = this.Pharmacologic_Therapy_for_Hypertension(context);
                    CqlBoolean bg_ = context.Operators.ConceptInValueSet(be_, bf_);
                    CqlBoolean bh_ = bg_;
                    return bc_
                        /* CQL 'and' */ && bh_;
                }

                CqlBoolean ax_ = context.Operators.WhereAny<Medication>(av_, aw_);
                return ax_;
            }

            IEnumerable<MedicationRequest> ap_ = context.Operators.Where<MedicationRequest>(an_, ao_);
            CqlValueSet aq_ = this.Pharmacologic_Therapy_for_Hypertension(context);
            IEnumerable<MedicationRequest> ar_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, aq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> as_ = context.Operators.Union<MedicationRequest>(ap_, ar_);

            bool? at_(MedicationRequest Medications) {
                FhirDateTime bi_ = Medications?.AuthoredOnElement;
                CqlDateTime bj_ = context.Operators.Convert<CqlDateTime>(bi_);
                CqlInterval<CqlDateTime> bk_ = this.Measurement_Period(context);
                CqlBoolean bl_ = context.Operators.In<CqlDateTime>(bj_, bk_, "day");
                Code<MedicationRequest.MedicationrequestStatus> bm_ = Medications?.StatusElement;
                MedicationRequest.MedicationrequestStatus? bn_ = bm_?.Value;
                string bo_ = context.Operators.Convert<string>(bn_);
                string[] bp_ = [
                    "active",
                    "completed",
                ];
                CqlBoolean bq_ = context.Operators.In<string>(bo_, (IEnumerable<string>)bp_);
                CqlBoolean br_ = bq_;
                return bl_
                    /* CQL 'and' (131:19-132:61) */ && br_;
            }

            CqlBoolean au_ = context.Operators.WhereAny<MedicationRequest>(as_, at_);
            return au_;
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

                bool? w_(Extension @this) {
                    FhirUri am_ = @this?.UrlElement;
                    string an_ = FHIRHelpers_4_4_000.Instance.ToString(context, am_);
                    CqlBoolean ao_ = context.Operators.Equal(an_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                    return ao_;
                }


                object x_(Extension @this) {
                    DataType ap_ = @this?.Value;
                    return ap_;
                }

                IEnumerable<object> y_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(NoBPScreen is DomainResource
                    ? (NoBPScreen as DomainResource).Extension
                    : default), w_, x_);
                object z_ = context.Operators.SingletonFrom<object>(y_);
                CqlConcept aa_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, z_ as CodeableConcept);
                CqlValueSet ab_ = this.Patient_Declined(context);
                CqlBoolean ac_ = context.Operators.ConceptInValueSet(aa_, ab_);

                bool? ad_(Extension @this) {
                    FhirUri aq_ = @this?.UrlElement;
                    string ar_ = FHIRHelpers_4_4_000.Instance.ToString(context, aq_);
                    CqlBoolean as_ = context.Operators.Equal(ar_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                    return as_;
                }


                object ae_(Extension @this) {
                    DataType at_ = @this?.Value;
                    return at_;
                }

                IEnumerable<object> af_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(NoBPScreen is DomainResource
                    ? (NoBPScreen as DomainResource).Extension
                    : default), ad_, ae_);
                object ag_ = context.Operators.SingletonFrom<object>(af_);
                CqlConcept ah_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ag_ as CodeableConcept);
                CqlValueSet ai_ = this.Medical_Reason(context);
                CqlBoolean aj_ = context.Operators.ConceptInValueSet(ah_, ai_);
                CqlBoolean ak_ = aj_;
                CqlBoolean al_ = ac_
                    /* CQL 'or' (324:13-326:9) */ || ak_;
                return v_
                    /* CQL 'and' (323:17-326:9) */ && al_;
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

            bool? ab_(Extension @this) {
                FhirUri aj_ = @this?.UrlElement;
                string ak_ = FHIRHelpers_4_4_000.Instance.ToString(context, aj_);
                CqlBoolean al_ = context.Operators.Equal(ak_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                return al_;
            }


            object ac_(Extension @this) {
                DataType am_ = @this?.Value;
                return am_;
            }

            IEnumerable<object> ad_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(NonPharmIntervention is DomainResource
                ? (NonPharmIntervention as DomainResource).Extension
                : default), ab_, ac_);
            object ae_ = context.Operators.SingletonFrom<object>(ad_);
            CqlConcept af_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ae_ as CodeableConcept);
            CqlValueSet ag_ = this.Patient_Declined(context);
            CqlBoolean ah_ = context.Operators.ConceptInValueSet(af_, ag_);
            CqlBoolean ai_ = ah_;
            return aa_
                /* CQL 'and' (315:5-316:66) */ && ai_;
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

            bool? t_(Extension @this) {
                FhirUri ab_ = @this?.UrlElement;
                string ac_ = FHIRHelpers_4_4_000.Instance.ToString(context, ab_);
                CqlBoolean ad_ = context.Operators.Equal(ac_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                return ad_;
            }


            object u_(Extension @this) {
                DataType ae_ = @this?.Value;
                return ae_;
            }

            IEnumerable<object> v_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(LabECGNotDone is DomainResource
                ? (LabECGNotDone as DomainResource).Extension
                : default), t_, u_);
            object w_ = context.Operators.SingletonFrom<object>(v_);
            CqlConcept x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, w_ as CodeableConcept);
            CqlValueSet y_ = this.Patient_Declined(context);
            CqlBoolean z_ = context.Operators.ConceptInValueSet(x_, y_);
            CqlBoolean aa_ = z_;
            return s_
                /* CQL 'and' (387:5-388:59) */ && aa_;
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

            bool? t_(Extension @this) {
                FhirUri ab_ = @this?.UrlElement;
                string ac_ = FHIRHelpers_4_4_000.Instance.ToString(context, ab_);
                CqlBoolean ad_ = context.Operators.Equal(ac_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                return ad_;
            }


            object u_(Extension @this) {
                DataType ae_ = @this?.Value;
                return ae_;
            }

            IEnumerable<object> v_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(SecondHTNDeclinedReferralAndFollowUp is DomainResource
                ? (SecondHTNDeclinedReferralAndFollowUp as DomainResource).Extension
                : default), t_, u_);
            object w_ = context.Operators.SingletonFrom<object>(v_);
            CqlConcept x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, w_ as CodeableConcept);
            CqlValueSet y_ = this.Patient_Declined(context);
            CqlBoolean z_ = context.Operators.ConceptInValueSet(x_, y_);
            CqlBoolean aa_ = z_;
            return s_
                /* CQL 'and' (364:7-365:84) */ && aa_;
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

            bool? z_(Extension @this) {
                FhirUri ah_ = @this?.UrlElement;
                string ai_ = FHIRHelpers_4_4_000.Instance.ToString(context, ah_);
                CqlBoolean aj_ = context.Operators.Equal(ai_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                return aj_;
            }


            object aa_(Extension @this) {
                DataType ak_ = @this?.Value;
                return ak_;
            }

            IEnumerable<object> ab_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(SecondHTN140Over90ReferralFollowUpNotDone is DomainResource
                ? (SecondHTN140Over90ReferralFollowUpNotDone as DomainResource).Extension
                : default), z_, aa_);
            object ac_ = context.Operators.SingletonFrom<object>(ab_);
            CqlConcept ad_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ac_ as CodeableConcept);
            CqlValueSet ae_ = this.Patient_Declined(context);
            CqlBoolean af_ = context.Operators.ConceptInValueSet(ad_, ae_);
            CqlBoolean ag_ = af_;
            return y_
                /* CQL 'and' (373:9-374:91) */ && ag_;
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
                Code<RequestStatus> aj_ = ElevatedBPDeclinedInterventions?.StatusElement;
                RequestStatus? ak_ = aj_?.Value;
                Code<RequestStatus> al_ = context.Operators.Convert<Code<RequestStatus>>(ak_);
                string am_ = context.Operators.Convert<string>(al_);
                string[] an_ = [
                    "active",
                    "completed",
                    "on-hold",
                ];
                CqlBoolean ao_ = context.Operators.In<string>(am_, (IEnumerable<string>)an_);
                CqlBoolean ap_ = ao_;

                bool? aq_(Extension @this) {
                    FhirUri ay_ = @this?.UrlElement;
                    string az_ = FHIRHelpers_4_4_000.Instance.ToString(context, ay_);
                    CqlBoolean ba_ = context.Operators.Equal(az_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                    return ba_;
                }


                object ar_(Extension @this) {
                    DataType bb_ = @this?.Value;
                    return bb_;
                }

                IEnumerable<object> as_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(ElevatedBPDeclinedInterventions is DomainResource
                    ? (ElevatedBPDeclinedInterventions as DomainResource).Extension
                    : default), aq_, ar_);
                object at_ = context.Operators.SingletonFrom<object>(as_);
                CqlConcept au_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, at_ as CodeableConcept);
                CqlValueSet av_ = this.Patient_Declined(context);
                CqlBoolean aw_ = context.Operators.ConceptInValueSet(au_, av_);
                CqlBoolean ax_ = aw_;
                return ai_
                    /* CQL 'and' (332:21-333:94) */ && ap_
                    /* CQL 'and' (332:21-334:83) */ && ax_;
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
                Code<RequestStatus> by_ = FirstHTNDeclinedInterventions?.StatusElement;
                RequestStatus? bz_ = by_?.Value;
                Code<RequestStatus> ca_ = context.Operators.Convert<Code<RequestStatus>>(bz_);
                string cb_ = context.Operators.Convert<string>(ca_);
                string[] cc_ = [
                    "active",
                    "completed",
                    "on-hold",
                ];
                CqlBoolean cd_ = context.Operators.In<string>(cb_, (IEnumerable<string>)cc_);
                CqlBoolean ce_ = cd_;

                bool? cf_(Extension @this) {
                    FhirUri cn_ = @this?.UrlElement;
                    string co_ = FHIRHelpers_4_4_000.Instance.ToString(context, cn_);
                    CqlBoolean cp_ = context.Operators.Equal(co_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                    return cp_;
                }


                object cg_(Extension @this) {
                    DataType cq_ = @this?.Value;
                    return cq_;
                }

                IEnumerable<object> ch_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(FirstHTNDeclinedInterventions is DomainResource
                    ? (FirstHTNDeclinedInterventions as DomainResource).Extension
                    : default), cf_, cg_);
                object ci_ = context.Operators.SingletonFrom<object>(ch_);
                CqlConcept cj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ci_ as CodeableConcept);
                CqlValueSet ck_ = this.Patient_Declined(context);
                CqlBoolean cl_ = context.Operators.ConceptInValueSet(cj_, ck_);
                CqlBoolean cm_ = cl_;
                return bx_
                    /* CQL 'and' (343:23-344:94) */ && ce_
                    /* CQL 'and' (343:23-345:83) */ && cm_;
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
