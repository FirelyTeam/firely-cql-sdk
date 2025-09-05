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
[CqlLibrary("CMS22FHIRPCSBPScreeningFollowUp", "0.3.000")]
public partial class CMS22FHIRPCSBPScreeningFollowUp_0_3_000 : ILibrary, ISingleton<CMS22FHIRPCSBPScreeningFollowUp_0_3_000>
{
    private CMS22FHIRPCSBPScreeningFollowUp_0_3_000() {}

    public static CMS22FHIRPCSBPScreeningFollowUp_0_3_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS22FHIRPCSBPScreeningFollowUp";
    public string Version => "0.3.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

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

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object a_ = context.ResolveParameter("CMS22FHIRPCSBPScreeningFollowUp-0.3.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlExpressionDefinition("Qualifying Encounter during Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_during_Measurement_Period(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_to_Screen_for_Blood_Pressure(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? c_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
            Period f_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, f_);
            bool? h_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, g_, "day");
            Code<Encounter.EncounterStatus> i_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? j_ = i_?.Value;
            Code<Encounter.EncounterStatus> k_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(j_);
            bool? l_ = context.Operators.Equivalent(k_, "finished");
            bool? m_ = context.Operators.And(h_, l_);
            Coding n_ = ValidEncounter?.Class;
            CqlCode o_ = FHIRHelpers_4_4_000.Instance.ToCode(context, n_);
            CqlCode p_ = this.@virtual(context);
            bool? q_ = context.Operators.Equivalent(o_, p_);
            bool? r_ = context.Operators.Not(q_);
            bool? s_ = context.Operators.And(m_, r_);

            return s_;
        };
        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? b_(Encounter QualifyingEncounter)
        {
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
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        IEnumerable<Encounter> b_(Encounter QualifyingEncounter)
        {
            CqlValueSet d_ = this.Diagnosis_of_Hypertension(context);
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            bool? f_(Condition Hypertension)
            {
                bool? j_ = QICoreCommon_4_0_000.Instance.isProblemListItem(context, Hypertension as object);
                bool? k_ = QICoreCommon_4_0_000.Instance.isHealthConcern(context, Hypertension as object);
                bool? l_ = context.Operators.Or(j_, k_);
                CqlInterval<CqlDateTime> m_()
                {
                    bool r_()
                    {
                        CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, Hypertension as object);
                        CqlDateTime t_ = context.Operators.Start(s_);

                        return t_ is null;
                    };
                    if (r_())
                    {
                        return default;
                    }
                    else
                    {
                        CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, Hypertension as object);
                        CqlDateTime v_ = context.Operators.Start(u_);
                        CqlDateTime x_ = context.Operators.Start(u_);
                        CqlInterval<CqlDateTime> y_ = context.Operators.Interval(v_, x_, true, true);

                        return y_;
                    }
                };
                Period n_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                bool? p_ = context.Operators.SameOrBefore(m_(), o_, "day");
                bool? q_ = context.Operators.And(l_, p_);

                return q_;
            };
            IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
            Encounter h_(Condition Hypertension) =>
                QualifyingEncounter;
            IEnumerable<Encounter> i_ = context.Operators.Select<Condition, Encounter>(g_, h_);

            return i_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Encounter with Normal Blood Pressure Reading")]
    public IEnumerable<Encounter> Encounter_with_Normal_Blood_Pressure_Reading(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? b_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));
            bool? e_(Observation BloodPressure)
            {
                DataType ak_ = BloodPressure?.Effective;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                CqlInterval<CqlDateTime> am_ = QICoreCommon_4_0_000.Instance.toInterval(context, al_);
                CqlDateTime an_ = context.Operators.End(am_);
                Period ao_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> ap_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ao_);
                bool? aq_ = context.Operators.In<CqlDateTime>(an_, ap_, default);
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
            };
            IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
            object g_(Observation @this)
            {
                DataType ax_ = @this?.Effective;
                object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                CqlInterval<CqlDateTime> az_ = QICoreCommon_4_0_000.Instance.toInterval(context, ay_);
                CqlDateTime ba_ = context.Operators.Start(az_);

                return ba_;
            };
            IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
            Observation i_ = context.Operators.Last<Observation>(h_);
            List<Observation.ComponentComponent> j_ = i_?.Component;
            bool? k_(Observation.ComponentComponent C)
            {
                CodeableConcept bb_ = C?.Code;
                CqlConcept bc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bb_);
                CqlCode bd_ = this.Systolic_blood_pressure(context);
                CqlConcept be_ = context.Operators.ConvertCodeToConcept(bd_);
                bool? bf_ = context.Operators.Equivalent(bc_, be_);

                return bf_;
            };
            IEnumerable<Observation.ComponentComponent> l_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)j_, k_);
            Observation.ComponentComponent m_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            CqlQuantity p_ = context.Operators.Quantity(1m, "mm[Hg]");
            CqlQuantity q_ = context.Operators.Quantity(120m, "mm[Hg]");
            CqlInterval<CqlQuantity> r_ = context.Operators.Interval(p_, q_, true, false);
            bool? s_ = context.Operators.In<CqlQuantity>(o_ as CqlQuantity, r_, default);
            bool? u_(Observation BloodPressure)
            {
                DataType bg_ = BloodPressure?.Effective;
                object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                CqlInterval<CqlDateTime> bi_ = QICoreCommon_4_0_000.Instance.toInterval(context, bh_);
                CqlDateTime bj_ = context.Operators.End(bi_);
                Period bk_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> bl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bk_);
                bool? bm_ = context.Operators.In<CqlDateTime>(bj_, bl_, default);
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
            };
            IEnumerable<Observation> v_ = context.Operators.Where<Observation>(d_, u_);
            object w_(Observation @this)
            {
                DataType bt_ = @this?.Effective;
                object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                CqlInterval<CqlDateTime> bv_ = QICoreCommon_4_0_000.Instance.toInterval(context, bu_);
                CqlDateTime bw_ = context.Operators.Start(bv_);

                return bw_;
            };
            IEnumerable<Observation> x_ = context.Operators.SortBy<Observation>(v_, w_, System.ComponentModel.ListSortDirection.Ascending);
            Observation y_ = context.Operators.Last<Observation>(x_);
            List<Observation.ComponentComponent> z_ = y_?.Component;
            bool? aa_(Observation.ComponentComponent C)
            {
                CodeableConcept bx_ = C?.Code;
                CqlConcept by_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bx_);
                CqlCode bz_ = this.Diastolic_blood_pressure(context);
                CqlConcept ca_ = context.Operators.ConvertCodeToConcept(bz_);
                bool? cb_ = context.Operators.Equivalent(by_, ca_);

                return cb_;
            };
            IEnumerable<Observation.ComponentComponent> ab_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)z_, aa_);
            Observation.ComponentComponent ac_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ab_);
            DataType ad_ = ac_?.Value;
            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
            CqlQuantity ag_ = context.Operators.Quantity(80m, "mm[Hg]");
            CqlInterval<CqlQuantity> ah_ = context.Operators.Interval(p_, ag_, true, false);
            bool? ai_ = context.Operators.In<CqlQuantity>(ae_ as CqlQuantity, ah_, default);
            bool? aj_ = context.Operators.And(s_, ai_);

            return aj_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Encounter with Elevated Blood Pressure Reading SBP 120 to 129 AND DBP less than 80")]
    public IEnumerable<Encounter> Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? b_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));
            bool? e_(Observation BloodPressure)
            {
                DataType ak_ = BloodPressure?.Effective;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                CqlInterval<CqlDateTime> am_ = QICoreCommon_4_0_000.Instance.toInterval(context, al_);
                CqlDateTime an_ = context.Operators.End(am_);
                Period ao_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> ap_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ao_);
                bool? aq_ = context.Operators.In<CqlDateTime>(an_, ap_, default);
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
            };
            IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
            object g_(Observation @this)
            {
                DataType ax_ = @this?.Effective;
                object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                CqlInterval<CqlDateTime> az_ = QICoreCommon_4_0_000.Instance.toInterval(context, ay_);
                CqlDateTime ba_ = context.Operators.Start(az_);

                return ba_;
            };
            IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
            Observation i_ = context.Operators.Last<Observation>(h_);
            List<Observation.ComponentComponent> j_ = i_?.Component;
            bool? k_(Observation.ComponentComponent C)
            {
                CodeableConcept bb_ = C?.Code;
                CqlConcept bc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bb_);
                CqlCode bd_ = this.Systolic_blood_pressure(context);
                CqlConcept be_ = context.Operators.ConvertCodeToConcept(bd_);
                bool? bf_ = context.Operators.Equivalent(bc_, be_);

                return bf_;
            };
            IEnumerable<Observation.ComponentComponent> l_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)j_, k_);
            Observation.ComponentComponent m_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            CqlQuantity p_ = context.Operators.Quantity(120m, "mm[Hg]");
            CqlQuantity q_ = context.Operators.Quantity(129m, "mm[Hg]");
            CqlInterval<CqlQuantity> r_ = context.Operators.Interval(p_, q_, true, true);
            bool? s_ = context.Operators.In<CqlQuantity>(o_ as CqlQuantity, r_, default);
            bool? u_(Observation BloodPressure)
            {
                DataType bg_ = BloodPressure?.Effective;
                object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                CqlInterval<CqlDateTime> bi_ = QICoreCommon_4_0_000.Instance.toInterval(context, bh_);
                CqlDateTime bj_ = context.Operators.End(bi_);
                Period bk_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> bl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bk_);
                bool? bm_ = context.Operators.In<CqlDateTime>(bj_, bl_, default);
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
            };
            IEnumerable<Observation> v_ = context.Operators.Where<Observation>(d_, u_);
            object w_(Observation @this)
            {
                DataType bt_ = @this?.Effective;
                object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                CqlInterval<CqlDateTime> bv_ = QICoreCommon_4_0_000.Instance.toInterval(context, bu_);
                CqlDateTime bw_ = context.Operators.Start(bv_);

                return bw_;
            };
            IEnumerable<Observation> x_ = context.Operators.SortBy<Observation>(v_, w_, System.ComponentModel.ListSortDirection.Ascending);
            Observation y_ = context.Operators.Last<Observation>(x_);
            List<Observation.ComponentComponent> z_ = y_?.Component;
            bool? aa_(Observation.ComponentComponent C)
            {
                CodeableConcept bx_ = C?.Code;
                CqlConcept by_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bx_);
                CqlCode bz_ = this.Diastolic_blood_pressure(context);
                CqlConcept ca_ = context.Operators.ConvertCodeToConcept(bz_);
                bool? cb_ = context.Operators.Equivalent(by_, ca_);

                return cb_;
            };
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
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Follow up with Rescreen Within 6 Months")]
    public IEnumerable<ServiceRequest> Follow_up_with_Rescreen_Within_6_Months(CqlContext context)
    {
        CqlValueSet a_ = this.Follow_Up_Within_6_Months(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        bool? c_(ServiceRequest FollowUp)
        {
            Code<RequestIntent> e_ = FollowUp?.IntentElement;
            RequestIntent? f_ = e_?.Value;
            Code<RequestIntent> g_ = context.Operators.Convert<Code<RequestIntent>>(f_);
            bool? h_ = context.Operators.Equivalent(g_, "order");

            return h_;
        };
        IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("NonPharmacological Interventions")]
    public IEnumerable<ServiceRequest> NonPharmacological_Interventions(CqlContext context)
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
        bool? o_(ServiceRequest NonPharmaInterventions)
        {
            Code<RequestIntent> q_ = NonPharmaInterventions?.IntentElement;
            RequestIntent? r_ = q_?.Value;
            Code<RequestIntent> s_ = context.Operators.Convert<Code<RequestIntent>>(r_);
            bool? t_ = context.Operators.Equivalent(s_, "order");

            return t_;
        };
        IEnumerable<ServiceRequest> p_ = context.Operators.Where<ServiceRequest>(n_, o_);

        return p_;
    }


    [CqlExpressionDefinition("Referral to Alternate or Primary Healthcare Professional for Hypertensive Reading")]
    public IEnumerable<ServiceRequest> Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(CqlContext context)
    {
        CqlValueSet a_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        bool? c_(ServiceRequest Referral)
        {
            List<CodeableConcept> e_ = Referral?.ReasonCode;
            CqlConcept f_(CodeableConcept @this)
            {
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return o_;
            };
            IEnumerable<CqlConcept> g_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)e_, f_);
            CqlValueSet h_ = this.Finding_of_Elevated_Blood_Pressure_or_Hypertension(context);
            bool? i_ = context.Operators.ConceptsInValueSet(g_, h_);
            Code<RequestIntent> j_ = Referral?.IntentElement;
            RequestIntent? k_ = j_?.Value;
            Code<RequestIntent> l_ = context.Operators.Convert<Code<RequestIntent>>(k_);
            bool? m_ = context.Operators.Equivalent(l_, "order");
            bool? n_ = context.Operators.And(i_, m_);

            return n_;
        };
        IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("Encounter with Elevated Blood Pressure Reading SBP 120 to 129 AND DBP less than 80 and Interventions")]
    public IEnumerable<Encounter> Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_and_Interventions(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80(context);
        IEnumerable<Encounter> b_(Encounter ElevatedEncounter)
        {
            IEnumerable<ServiceRequest> j_ = this.Follow_up_with_Rescreen_Within_6_Months(context);
            bool? k_(ServiceRequest Twoto6MonthRescreen)
            {
                FhirDateTime o_ = Twoto6MonthRescreen?.AuthoredOnElement;
                CqlDateTime p_ = context.Operators.Convert<CqlDateTime>(o_);
                Period q_ = ElevatedEncounter?.Period;
                CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
                bool? s_ = context.Operators.In<CqlDateTime>(p_, r_, "day");

                return s_;
            };
            IEnumerable<ServiceRequest> l_ = context.Operators.Where<ServiceRequest>(j_, k_);
            Encounter m_(ServiceRequest Twoto6MonthRescreen) =>
                ElevatedEncounter;
            IEnumerable<Encounter> n_ = context.Operators.Select<ServiceRequest, Encounter>(l_, m_);

            return n_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        IEnumerable<Encounter> d_(Encounter ElevatedEncounter)
        {
            IEnumerable<ServiceRequest> t_ = this.NonPharmacological_Interventions(context);
            bool? u_(ServiceRequest NonPharmInterventions)
            {
                FhirDateTime y_ = NonPharmInterventions?.AuthoredOnElement;
                CqlDateTime z_ = context.Operators.Convert<CqlDateTime>(y_);
                Period aa_ = ElevatedEncounter?.Period;
                CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aa_);
                bool? ac_ = context.Operators.In<CqlDateTime>(z_, ab_, "day");

                return ac_;
            };
            IEnumerable<ServiceRequest> v_ = context.Operators.Where<ServiceRequest>(t_, u_);
            Encounter w_(ServiceRequest NonPharmInterventions) =>
                ElevatedEncounter;
            IEnumerable<Encounter> x_ = context.Operators.Select<ServiceRequest, Encounter>(v_, w_);

            return x_;
        };
        IEnumerable<Encounter> e_ = context.Operators.SelectMany<Encounter, Encounter>(c_, d_);
        IEnumerable<Encounter> g_(Encounter ElevatedEncounter)
        {
            IEnumerable<ServiceRequest> ad_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(context);
            bool? ae_(ServiceRequest Referral)
            {
                FhirDateTime ai_ = Referral?.AuthoredOnElement;
                CqlDateTime aj_ = context.Operators.Convert<CqlDateTime>(ai_);
                Period ak_ = ElevatedEncounter?.Period;
                CqlInterval<CqlDateTime> al_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ak_);
                bool? am_ = context.Operators.In<CqlDateTime>(aj_, al_, "day");

                return am_;
            };
            IEnumerable<ServiceRequest> af_ = context.Operators.Where<ServiceRequest>(ad_, ae_);
            Encounter ag_(ServiceRequest Referral) =>
                ElevatedEncounter;
            IEnumerable<Encounter> ah_ = context.Operators.Select<ServiceRequest, Encounter>(af_, ag_);

            return ah_;
        };
        IEnumerable<Encounter> h_ = context.Operators.SelectMany<Encounter, Encounter>(a_, g_);
        IEnumerable<Encounter> i_ = context.Operators.Union<Encounter>(e_, h_);

        return i_;
    }


    [CqlExpressionDefinition("Encounter with Hypertensive Reading Within Year Prior")]
    public IEnumerable<Encounter> Encounter_with_Hypertensive_Reading_Within_Year_Prior(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? b_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));
            bool? e_(Observation BloodPressure)
            {
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
            };
            IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
            object g_(Observation @this)
            {
                DataType cj_ = @this?.Effective;
                object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                CqlInterval<CqlDateTime> cl_ = QICoreCommon_4_0_000.Instance.toInterval(context, ck_);
                CqlDateTime cm_ = context.Operators.Start(cl_);

                return cm_;
            };
            IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
            Observation i_ = context.Operators.Last<Observation>(h_);
            List<Observation.ComponentComponent> j_ = i_?.Component;
            bool? k_(Observation.ComponentComponent C)
            {
                CodeableConcept cn_ = C?.Code;
                CqlConcept co_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cn_);
                CqlCode cp_ = this.Systolic_blood_pressure(context);
                CqlConcept cq_ = context.Operators.ConvertCodeToConcept(cp_);
                bool? cr_ = context.Operators.Equivalent(co_, cq_);

                return cr_;
            };
            IEnumerable<Observation.ComponentComponent> l_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)j_, k_);
            Observation.ComponentComponent m_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            CqlQuantity p_ = context.Operators.Quantity(0m, "mm[Hg]");
            bool? q_ = context.Operators.Greater(o_ as CqlQuantity, p_);
            bool? s_(Observation BloodPressure)
            {
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
            };
            IEnumerable<Observation> t_ = context.Operators.Where<Observation>(d_, s_);
            object u_(Observation @this)
            {
                DataType dr_ = @this?.Effective;
                object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                CqlInterval<CqlDateTime> dt_ = QICoreCommon_4_0_000.Instance.toInterval(context, ds_);
                CqlDateTime du_ = context.Operators.Start(dt_);

                return du_;
            };
            IEnumerable<Observation> v_ = context.Operators.SortBy<Observation>(t_, u_, System.ComponentModel.ListSortDirection.Ascending);
            Observation w_ = context.Operators.Last<Observation>(v_);
            List<Observation.ComponentComponent> x_ = w_?.Component;
            bool? y_(Observation.ComponentComponent C)
            {
                CodeableConcept dv_ = C?.Code;
                CqlConcept dw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dv_);
                CqlCode dx_ = this.Diastolic_blood_pressure(context);
                CqlConcept dy_ = context.Operators.ConvertCodeToConcept(dx_);
                bool? dz_ = context.Operators.Equivalent(dw_, dy_);

                return dz_;
            };
            IEnumerable<Observation.ComponentComponent> z_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)x_, y_);
            Observation.ComponentComponent aa_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(z_);
            DataType ab_ = aa_?.Value;
            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
            bool? ae_ = context.Operators.Greater(ac_ as CqlQuantity, p_);
            bool? af_ = context.Operators.And(q_, ae_);
            bool? ah_(Observation BloodPressure)
            {
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
            };
            IEnumerable<Observation> ai_ = context.Operators.Where<Observation>(d_, ah_);
            object aj_(Observation @this)
            {
                DataType ez_ = @this?.Effective;
                object fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);
                CqlInterval<CqlDateTime> fb_ = QICoreCommon_4_0_000.Instance.toInterval(context, fa_);
                CqlDateTime fc_ = context.Operators.Start(fb_);

                return fc_;
            };
            IEnumerable<Observation> ak_ = context.Operators.SortBy<Observation>(ai_, aj_, System.ComponentModel.ListSortDirection.Ascending);
            Observation al_ = context.Operators.Last<Observation>(ak_);
            List<Observation.ComponentComponent> am_ = al_?.Component;
            bool? an_(Observation.ComponentComponent C)
            {
                CodeableConcept fd_ = C?.Code;
                CqlConcept fe_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fd_);
                CqlCode ff_ = this.Systolic_blood_pressure(context);
                CqlConcept fg_ = context.Operators.ConvertCodeToConcept(ff_);
                bool? fh_ = context.Operators.Equivalent(fe_, fg_);

                return fh_;
            };
            IEnumerable<Observation.ComponentComponent> ao_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)am_, an_);
            Observation.ComponentComponent ap_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ao_);
            DataType aq_ = ap_?.Value;
            object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
            CqlQuantity as_ = context.Operators.Quantity(130m, "mm[Hg]");
            bool? at_ = context.Operators.GreaterOrEqual(ar_ as CqlQuantity, as_);
            bool? av_(Observation BloodPressure)
            {
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
            };
            IEnumerable<Observation> aw_ = context.Operators.Where<Observation>(d_, av_);
            object ax_(Observation @this)
            {
                DataType gh_ = @this?.Effective;
                object gi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gh_);
                CqlInterval<CqlDateTime> gj_ = QICoreCommon_4_0_000.Instance.toInterval(context, gi_);
                CqlDateTime gk_ = context.Operators.Start(gj_);

                return gk_;
            };
            IEnumerable<Observation> ay_ = context.Operators.SortBy<Observation>(aw_, ax_, System.ComponentModel.ListSortDirection.Ascending);
            Observation az_ = context.Operators.Last<Observation>(ay_);
            List<Observation.ComponentComponent> ba_ = az_?.Component;
            bool? bb_(Observation.ComponentComponent C)
            {
                CodeableConcept gl_ = C?.Code;
                CqlConcept gm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gl_);
                CqlCode gn_ = this.Diastolic_blood_pressure(context);
                CqlConcept go_ = context.Operators.ConvertCodeToConcept(gn_);
                bool? gp_ = context.Operators.Equivalent(gm_, go_);

                return gp_;
            };
            IEnumerable<Observation.ComponentComponent> bc_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ba_, bb_);
            Observation.ComponentComponent bd_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(bc_);
            DataType be_ = bd_?.Value;
            object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
            CqlQuantity bg_ = context.Operators.Quantity(80m, "mm[Hg]");
            bool? bh_ = context.Operators.GreaterOrEqual(bf_ as CqlQuantity, bg_);
            bool? bi_ = context.Operators.Or(at_, bh_);
            bool? bj_ = context.Operators.And(af_, bi_);

            return bj_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Encounter with First Hypertensive Reading SBP Greater than or Equal to 130 OR DBP Greater than or Equal to 80")]
    public IEnumerable<Encounter> Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? b_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));
            bool? g_(Observation BloodPressure)
            {
                DataType bm_ = BloodPressure?.Effective;
                object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                CqlInterval<CqlDateTime> bo_ = QICoreCommon_4_0_000.Instance.toInterval(context, bn_);
                CqlDateTime bp_ = context.Operators.End(bo_);
                Period bq_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> br_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bq_);
                bool? bs_ = context.Operators.In<CqlDateTime>(bp_, br_, "day");

                return bs_;
            };
            IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);
            object i_(Observation @this)
            {
                DataType bt_ = @this?.Effective;
                object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                CqlInterval<CqlDateTime> bv_ = QICoreCommon_4_0_000.Instance.toInterval(context, bu_);
                CqlDateTime bw_ = context.Operators.Start(bv_);

                return bw_;
            };
            IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Observation k_ = context.Operators.Last<Observation>(j_);
            List<Observation.ComponentComponent> l_ = k_?.Component;
            bool? m_(Observation.ComponentComponent C)
            {
                CodeableConcept bx_ = C?.Code;
                CqlConcept by_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bx_);
                CqlCode bz_ = this.Systolic_blood_pressure(context);
                CqlConcept ca_ = context.Operators.ConvertCodeToConcept(bz_);
                bool? cb_ = context.Operators.Equivalent(by_, ca_);

                return cb_;
            };
            IEnumerable<Observation.ComponentComponent> n_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)l_, m_);
            Observation.ComponentComponent o_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(n_);
            DataType p_ = o_?.Value;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlQuantity r_ = context.Operators.Quantity(0m, "mm[Hg]");
            bool? s_ = context.Operators.Greater(q_ as CqlQuantity, r_);
            bool? u_(Observation BloodPressure)
            {
                DataType cc_ = BloodPressure?.Effective;
                object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                CqlInterval<CqlDateTime> ce_ = QICoreCommon_4_0_000.Instance.toInterval(context, cd_);
                CqlDateTime cf_ = context.Operators.End(ce_);
                Period cg_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> ch_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cg_);
                bool? ci_ = context.Operators.In<CqlDateTime>(cf_, ch_, "day");

                return ci_;
            };
            IEnumerable<Observation> v_ = context.Operators.Where<Observation>(f_, u_);
            object w_(Observation @this)
            {
                DataType cj_ = @this?.Effective;
                object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                CqlInterval<CqlDateTime> cl_ = QICoreCommon_4_0_000.Instance.toInterval(context, ck_);
                CqlDateTime cm_ = context.Operators.Start(cl_);

                return cm_;
            };
            IEnumerable<Observation> x_ = context.Operators.SortBy<Observation>(v_, w_, System.ComponentModel.ListSortDirection.Ascending);
            Observation y_ = context.Operators.Last<Observation>(x_);
            List<Observation.ComponentComponent> z_ = y_?.Component;
            bool? aa_(Observation.ComponentComponent C)
            {
                CodeableConcept cn_ = C?.Code;
                CqlConcept co_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cn_);
                CqlCode cp_ = this.Diastolic_blood_pressure(context);
                CqlConcept cq_ = context.Operators.ConvertCodeToConcept(cp_);
                bool? cr_ = context.Operators.Equivalent(co_, cq_);

                return cr_;
            };
            IEnumerable<Observation.ComponentComponent> ab_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)z_, aa_);
            Observation.ComponentComponent ac_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ab_);
            DataType ad_ = ac_?.Value;
            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
            bool? ag_ = context.Operators.Greater(ae_ as CqlQuantity, r_);
            bool? ah_ = context.Operators.And(s_, ag_);
            bool? aj_(Observation BloodPressure)
            {
                DataType cs_ = BloodPressure?.Effective;
                object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                CqlInterval<CqlDateTime> cu_ = QICoreCommon_4_0_000.Instance.toInterval(context, ct_);
                CqlDateTime cv_ = context.Operators.End(cu_);
                Period cw_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> cx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cw_);
                bool? cy_ = context.Operators.In<CqlDateTime>(cv_, cx_, "day");

                return cy_;
            };
            IEnumerable<Observation> ak_ = context.Operators.Where<Observation>(f_, aj_);
            object al_(Observation @this)
            {
                DataType cz_ = @this?.Effective;
                object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                CqlInterval<CqlDateTime> db_ = QICoreCommon_4_0_000.Instance.toInterval(context, da_);
                CqlDateTime dc_ = context.Operators.Start(db_);

                return dc_;
            };
            IEnumerable<Observation> am_ = context.Operators.SortBy<Observation>(ak_, al_, System.ComponentModel.ListSortDirection.Ascending);
            Observation an_ = context.Operators.Last<Observation>(am_);
            List<Observation.ComponentComponent> ao_ = an_?.Component;
            bool? ap_(Observation.ComponentComponent C)
            {
                CodeableConcept dd_ = C?.Code;
                CqlConcept de_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dd_);
                CqlCode df_ = this.Systolic_blood_pressure(context);
                CqlConcept dg_ = context.Operators.ConvertCodeToConcept(df_);
                bool? dh_ = context.Operators.Equivalent(de_, dg_);

                return dh_;
            };
            IEnumerable<Observation.ComponentComponent> aq_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ao_, ap_);
            Observation.ComponentComponent ar_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(aq_);
            DataType as_ = ar_?.Value;
            object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
            CqlQuantity au_ = context.Operators.Quantity(130m, "mm[Hg]");
            bool? av_ = context.Operators.GreaterOrEqual(at_ as CqlQuantity, au_);
            bool? ax_(Observation BloodPressure)
            {
                DataType di_ = BloodPressure?.Effective;
                object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                CqlInterval<CqlDateTime> dk_ = QICoreCommon_4_0_000.Instance.toInterval(context, dj_);
                CqlDateTime dl_ = context.Operators.End(dk_);
                Period dm_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> dn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dm_);
                bool? do_ = context.Operators.In<CqlDateTime>(dl_, dn_, "day");

                return do_;
            };
            IEnumerable<Observation> ay_ = context.Operators.Where<Observation>(f_, ax_);
            object az_(Observation @this)
            {
                DataType dp_ = @this?.Effective;
                object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
                CqlInterval<CqlDateTime> dr_ = QICoreCommon_4_0_000.Instance.toInterval(context, dq_);
                CqlDateTime ds_ = context.Operators.Start(dr_);

                return ds_;
            };
            IEnumerable<Observation> ba_ = context.Operators.SortBy<Observation>(ay_, az_, System.ComponentModel.ListSortDirection.Ascending);
            Observation bb_ = context.Operators.Last<Observation>(ba_);
            List<Observation.ComponentComponent> bc_ = bb_?.Component;
            bool? bd_(Observation.ComponentComponent C)
            {
                CodeableConcept dt_ = C?.Code;
                CqlConcept du_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dt_);
                CqlCode dv_ = this.Diastolic_blood_pressure(context);
                CqlConcept dw_ = context.Operators.ConvertCodeToConcept(dv_);
                bool? dx_ = context.Operators.Equivalent(du_, dw_);

                return dx_;
            };
            IEnumerable<Observation.ComponentComponent> be_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)bc_, bd_);
            Observation.ComponentComponent bf_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(be_);
            DataType bg_ = bf_?.Value;
            object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
            CqlQuantity bi_ = context.Operators.Quantity(80m, "mm[Hg]");
            bool? bj_ = context.Operators.GreaterOrEqual(bh_ as CqlQuantity, bi_);
            bool? bk_ = context.Operators.Or(av_, bj_);
            bool? bl_ = context.Operators.And(ah_, bk_);

            return bl_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior(context);
        IEnumerable<Encounter> e_ = context.Operators.Except<Encounter>(c_, d_);

        return e_;
    }


    [CqlExpressionDefinition("First Hypertensive Reading Interventions or Referral to Alternate Professional")]
    public IEnumerable<ServiceRequest> First_Hypertensive_Reading_Interventions_or_Referral_to_Alternate_Professional(CqlContext context)
    {
        CqlValueSet a_ = this.Follow_Up_Within_4_Weeks(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> c_(ServiceRequest FourWeekRescreen)
        {
            IEnumerable<ServiceRequest> g_ = this.NonPharmacological_Interventions(context);
            bool? h_(ServiceRequest NonPharmInterventionsHTN)
            {
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
                bool? x_ = context.Operators.Equivalent(w_, "order");
                bool? y_ = context.Operators.And(t_, x_);

                return y_;
            };
            IEnumerable<ServiceRequest> i_ = context.Operators.Where<ServiceRequest>(g_, h_);
            ServiceRequest j_(ServiceRequest NonPharmInterventionsHTN) =>
                FourWeekRescreen;
            IEnumerable<ServiceRequest> k_ = context.Operators.Select<ServiceRequest, ServiceRequest>(i_, j_);

            return k_;
        };
        IEnumerable<ServiceRequest> d_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(b_, c_);
        IEnumerable<ServiceRequest> e_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(context);
        IEnumerable<ServiceRequest> f_ = context.Operators.Union<ServiceRequest>(d_, e_);

        return f_;
    }


    [CqlExpressionDefinition("Encounter with First Hypertensive Reading SBP Greater than or Equal to 130 OR DBP Greater than or Equal to 80 and Interventions")]
    public IEnumerable<Encounter> Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_and_Interventions(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80(context);
        IEnumerable<Encounter> b_(Encounter FirstHTNEncounter)
        {
            IEnumerable<ServiceRequest> d_ = this.First_Hypertensive_Reading_Interventions_or_Referral_to_Alternate_Professional(context);
            bool? e_(ServiceRequest FirstHTNIntervention)
            {
                FhirDateTime i_ = FirstHTNIntervention?.AuthoredOnElement;
                CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
                Period k_ = FirstHTNEncounter?.Period;
                CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                bool? m_ = context.Operators.In<CqlDateTime>(j_, l_, "day");

                return m_;
            };
            IEnumerable<ServiceRequest> f_ = context.Operators.Where<ServiceRequest>(d_, e_);
            Encounter g_(ServiceRequest FirstHTNIntervention) =>
                FirstHTNEncounter;
            IEnumerable<Encounter> h_ = context.Operators.Select<ServiceRequest, Encounter>(f_, g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Encounter with Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89")]
    public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? b_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));
            bool? e_(Observation BloodPressure)
            {
                DataType bs_ = BloodPressure?.Effective;
                object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                CqlInterval<CqlDateTime> bu_ = QICoreCommon_4_0_000.Instance.toInterval(context, bt_);
                CqlDateTime bv_ = context.Operators.End(bu_);
                Period bw_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> bx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bw_);
                bool? by_ = context.Operators.In<CqlDateTime>(bv_, bx_, "day");
                Code<ObservationStatus> bz_ = BloodPressure?.StatusElement;
                ObservationStatus? ca_ = bz_?.Value;
                string cb_ = context.Operators.Convert<string>(ca_);
                string[] cc_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? cd_ = context.Operators.In<string>(cb_, (IEnumerable<string>)cc_);
                bool? ce_ = context.Operators.And(by_, cd_);

                return ce_;
            };
            IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
            object g_(Observation @this)
            {
                DataType cf_ = @this?.Effective;
                object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                CqlInterval<CqlDateTime> ch_ = QICoreCommon_4_0_000.Instance.toInterval(context, cg_);
                CqlDateTime ci_ = context.Operators.Start(ch_);

                return ci_;
            };
            IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
            Observation i_ = context.Operators.Last<Observation>(h_);
            List<Observation.ComponentComponent> j_ = i_?.Component;
            bool? k_(Observation.ComponentComponent C)
            {
                CodeableConcept cj_ = C?.Code;
                CqlConcept ck_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cj_);
                CqlCode cl_ = this.Systolic_blood_pressure(context);
                CqlConcept cm_ = context.Operators.ConvertCodeToConcept(cl_);
                bool? cn_ = context.Operators.Equivalent(ck_, cm_);

                return cn_;
            };
            IEnumerable<Observation.ComponentComponent> l_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)j_, k_);
            Observation.ComponentComponent m_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            CqlQuantity p_ = context.Operators.Quantity(130m, "mm[Hg]");
            CqlQuantity q_ = context.Operators.Quantity(139m, "mm[Hg]");
            CqlInterval<CqlQuantity> r_ = context.Operators.Interval(p_, q_, true, true);
            bool? s_ = context.Operators.In<CqlQuantity>(o_ as CqlQuantity, r_, default);
            bool? u_(Observation BloodPressure)
            {
                DataType co_ = BloodPressure?.Effective;
                object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                CqlInterval<CqlDateTime> cq_ = QICoreCommon_4_0_000.Instance.toInterval(context, cp_);
                CqlDateTime cr_ = context.Operators.End(cq_);
                Period cs_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> ct_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cs_);
                bool? cu_ = context.Operators.In<CqlDateTime>(cr_, ct_, "day");
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
            };
            IEnumerable<Observation> v_ = context.Operators.Where<Observation>(d_, u_);
            object w_(Observation @this)
            {
                DataType db_ = @this?.Effective;
                object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                CqlInterval<CqlDateTime> dd_ = QICoreCommon_4_0_000.Instance.toInterval(context, dc_);
                CqlDateTime de_ = context.Operators.Start(dd_);

                return de_;
            };
            IEnumerable<Observation> x_ = context.Operators.SortBy<Observation>(v_, w_, System.ComponentModel.ListSortDirection.Ascending);
            Observation y_ = context.Operators.Last<Observation>(x_);
            List<Observation.ComponentComponent> z_ = y_?.Component;
            bool? aa_(Observation.ComponentComponent C)
            {
                CodeableConcept df_ = C?.Code;
                CqlConcept dg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, df_);
                CqlCode dh_ = this.Diastolic_blood_pressure(context);
                CqlConcept di_ = context.Operators.ConvertCodeToConcept(dh_);
                bool? dj_ = context.Operators.Equivalent(dg_, di_);

                return dj_;
            };
            IEnumerable<Observation.ComponentComponent> ab_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)z_, aa_);
            Observation.ComponentComponent ac_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ab_);
            DataType ad_ = ac_?.Value;
            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
            CqlQuantity af_ = context.Operators.Quantity(80m, "mm[Hg]");
            CqlQuantity ag_ = context.Operators.Quantity(89m, "mm[Hg]");
            CqlInterval<CqlQuantity> ah_ = context.Operators.Interval(af_, ag_, true, true);
            bool? ai_ = context.Operators.In<CqlQuantity>(ae_ as CqlQuantity, ah_, default);
            bool? aj_ = context.Operators.Or(s_, ai_);
            bool? al_(Observation BloodPressure)
            {
                DataType dk_ = BloodPressure?.Effective;
                object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                CqlInterval<CqlDateTime> dm_ = QICoreCommon_4_0_000.Instance.toInterval(context, dl_);
                CqlDateTime dn_ = context.Operators.End(dm_);
                Period do_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> dp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, do_);
                bool? dq_ = context.Operators.In<CqlDateTime>(dn_, dp_, "day");
                Code<ObservationStatus> dr_ = BloodPressure?.StatusElement;
                ObservationStatus? ds_ = dr_?.Value;
                string dt_ = context.Operators.Convert<string>(ds_);
                string[] du_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? dv_ = context.Operators.In<string>(dt_, (IEnumerable<string>)du_);
                bool? dw_ = context.Operators.And(dq_, dv_);

                return dw_;
            };
            IEnumerable<Observation> am_ = context.Operators.Where<Observation>(d_, al_);
            object an_(Observation @this)
            {
                DataType dx_ = @this?.Effective;
                object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                CqlInterval<CqlDateTime> dz_ = QICoreCommon_4_0_000.Instance.toInterval(context, dy_);
                CqlDateTime ea_ = context.Operators.Start(dz_);

                return ea_;
            };
            IEnumerable<Observation> ao_ = context.Operators.SortBy<Observation>(am_, an_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ap_ = context.Operators.Last<Observation>(ao_);
            List<Observation.ComponentComponent> aq_ = ap_?.Component;
            bool? ar_(Observation.ComponentComponent C)
            {
                CodeableConcept eb_ = C?.Code;
                CqlConcept ec_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, eb_);
                CqlCode ed_ = this.Systolic_blood_pressure(context);
                CqlConcept ee_ = context.Operators.ConvertCodeToConcept(ed_);
                bool? ef_ = context.Operators.Equivalent(ec_, ee_);

                return ef_;
            };
            IEnumerable<Observation.ComponentComponent> as_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)aq_, ar_);
            Observation.ComponentComponent at_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(as_);
            DataType au_ = at_?.Value;
            object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
            CqlQuantity aw_ = context.Operators.Quantity(140m, "mm[Hg]");
            bool? ax_ = context.Operators.GreaterOrEqual(av_ as CqlQuantity, aw_);
            bool? az_(Observation BloodPressure)
            {
                DataType eg_ = BloodPressure?.Effective;
                object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                CqlInterval<CqlDateTime> ei_ = QICoreCommon_4_0_000.Instance.toInterval(context, eh_);
                CqlDateTime ej_ = context.Operators.End(ei_);
                Period ek_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> el_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ek_);
                bool? em_ = context.Operators.In<CqlDateTime>(ej_, el_, "day");
                Code<ObservationStatus> en_ = BloodPressure?.StatusElement;
                ObservationStatus? eo_ = en_?.Value;
                string ep_ = context.Operators.Convert<string>(eo_);
                string[] eq_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? er_ = context.Operators.In<string>(ep_, (IEnumerable<string>)eq_);
                bool? es_ = context.Operators.And(em_, er_);

                return es_;
            };
            IEnumerable<Observation> ba_ = context.Operators.Where<Observation>(d_, az_);
            object bb_(Observation @this)
            {
                DataType et_ = @this?.Effective;
                object eu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, et_);
                CqlInterval<CqlDateTime> ev_ = QICoreCommon_4_0_000.Instance.toInterval(context, eu_);
                CqlDateTime ew_ = context.Operators.Start(ev_);

                return ew_;
            };
            IEnumerable<Observation> bc_ = context.Operators.SortBy<Observation>(ba_, bb_, System.ComponentModel.ListSortDirection.Ascending);
            Observation bd_ = context.Operators.Last<Observation>(bc_);
            List<Observation.ComponentComponent> be_ = bd_?.Component;
            bool? bf_(Observation.ComponentComponent C)
            {
                CodeableConcept ex_ = C?.Code;
                CqlConcept ey_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ex_);
                CqlCode ez_ = this.Diastolic_blood_pressure(context);
                CqlConcept fa_ = context.Operators.ConvertCodeToConcept(ez_);
                bool? fb_ = context.Operators.Equivalent(ey_, fa_);

                return fb_;
            };
            IEnumerable<Observation.ComponentComponent> bg_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)be_, bf_);
            Observation.ComponentComponent bh_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(bg_);
            DataType bi_ = bh_?.Value;
            object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
            CqlQuantity bk_ = context.Operators.Quantity(90m, "mm[Hg]");
            bool? bl_ = context.Operators.GreaterOrEqual(bj_ as CqlQuantity, bk_);
            bool? bm_ = context.Operators.Or(ax_, bl_);
            bool? bn_ = context.Operators.Not(bm_);
            bool? bo_ = context.Operators.And(aj_, bn_);
            IEnumerable<Encounter> bp_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior(context);
            bool? bq_ = context.Operators.Exists<Encounter>(bp_);
            bool? br_ = context.Operators.And(bo_, bq_);

            return br_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Laboratory Test or ECG for Hypertension")]
    public IEnumerable<ServiceRequest> Laboratory_Test_or_ECG_for_Hypertension(CqlContext context)
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
        bool? k_(ServiceRequest EKGLab)
        {
            Code<RequestIntent> m_ = EKGLab?.IntentElement;
            RequestIntent? n_ = m_?.Value;
            Code<RequestIntent> o_ = context.Operators.Convert<Code<RequestIntent>>(n_);
            bool? p_ = context.Operators.Equivalent(o_, "order");

            return p_;
        };
        IEnumerable<ServiceRequest> l_ = context.Operators.Where<ServiceRequest>(j_, k_);

        return l_;
    }


    [CqlExpressionDefinition("Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 and Interventions")]
    public IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions(CqlContext context)
    {
        IEnumerable<ServiceRequest> a_ = this.Follow_up_with_Rescreen_Within_6_Months(context);
        IEnumerable<ServiceRequest> b_(ServiceRequest Rescreen2to6)
        {
            IEnumerable<ServiceRequest> f_ = this.Laboratory_Test_or_ECG_for_Hypertension(context);
            bool? g_(ServiceRequest LabECGIntervention)
            {
                FhirDateTime k_ = Rescreen2to6?.AuthoredOnElement;
                CqlDateTime l_ = context.Operators.Convert<CqlDateTime>(k_);
                CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
                bool? n_ = context.Operators.In<CqlDateTime>(l_, m_, "day");
                FhirDateTime o_ = LabECGIntervention?.AuthoredOnElement;
                CqlDateTime p_ = context.Operators.Convert<CqlDateTime>(o_);
                bool? r_ = context.Operators.In<CqlDateTime>(p_, m_, "day");
                bool? s_ = context.Operators.And(n_, r_);

                return s_;
            };
            IEnumerable<ServiceRequest> h_ = context.Operators.Where<ServiceRequest>(f_, g_);
            ServiceRequest i_(ServiceRequest LabECGIntervention) =>
                Rescreen2to6;
            IEnumerable<ServiceRequest> j_ = context.Operators.Select<ServiceRequest, ServiceRequest>(h_, i_);

            return j_;
        };
        IEnumerable<ServiceRequest> c_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(a_, b_);
        IEnumerable<ServiceRequest> d_(ServiceRequest Rescreen2to6)
        {
            IEnumerable<ServiceRequest> t_ = this.NonPharmacological_Interventions(context);
            bool? u_(ServiceRequest NonPharmSecondIntervention)
            {
                FhirDateTime y_ = NonPharmSecondIntervention?.AuthoredOnElement;
                CqlDateTime z_ = context.Operators.Convert<CqlDateTime>(y_);
                CqlInterval<CqlDateTime> aa_ = this.Measurement_Period(context);
                bool? ab_ = context.Operators.In<CqlDateTime>(z_, aa_, "day");

                return ab_;
            };
            IEnumerable<ServiceRequest> v_ = context.Operators.Where<ServiceRequest>(t_, u_);
            ServiceRequest w_(ServiceRequest NonPharmSecondIntervention) =>
                Rescreen2to6;
            IEnumerable<ServiceRequest> x_ = context.Operators.Select<ServiceRequest, ServiceRequest>(v_, w_);

            return x_;
        };
        IEnumerable<ServiceRequest> e_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(c_, d_);

        return e_;
    }


    [CqlExpressionDefinition("Encounter with Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 and Interventions")]
    public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89(context);
        IEnumerable<Encounter> b_(Encounter SecondHTNEncounterReading)
        {
            IEnumerable<ServiceRequest> h_ = this.Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions(context);
            bool? i_(ServiceRequest EncounterInterventions)
            {
                FhirDateTime m_ = EncounterInterventions?.AuthoredOnElement;
                CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
                Period o_ = SecondHTNEncounterReading?.Period;
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                bool? q_ = context.Operators.In<CqlDateTime>(n_, p_, "day");

                return q_;
            };
            IEnumerable<ServiceRequest> j_ = context.Operators.Where<ServiceRequest>(h_, i_);
            Encounter k_(ServiceRequest EncounterInterventions) =>
                SecondHTNEncounterReading;
            IEnumerable<Encounter> l_ = context.Operators.Select<ServiceRequest, Encounter>(j_, k_);

            return l_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        IEnumerable<Encounter> e_(Encounter SecondHTNEncounterReading)
        {
            IEnumerable<ServiceRequest> r_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(context);
            bool? s_(ServiceRequest ReferralForHTN)
            {
                FhirDateTime w_ = ReferralForHTN?.AuthoredOnElement;
                CqlDateTime x_ = context.Operators.Convert<CqlDateTime>(w_);
                Period y_ = SecondHTNEncounterReading?.Period;
                CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
                bool? aa_ = context.Operators.In<CqlDateTime>(x_, z_, "day");

                return aa_;
            };
            IEnumerable<ServiceRequest> t_ = context.Operators.Where<ServiceRequest>(r_, s_);
            Encounter u_(ServiceRequest ReferralForHTN) =>
                SecondHTNEncounterReading;
            IEnumerable<Encounter> v_ = context.Operators.Select<ServiceRequest, Encounter>(t_, u_);

            return v_;
        };
        IEnumerable<Encounter> f_ = context.Operators.SelectMany<Encounter, Encounter>(a_, e_);
        IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);

        return g_;
    }


    [CqlExpressionDefinition("Encounter with Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90")]
    public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? b_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));
            bool? e_(Observation BloodPressure)
            {
                DataType bn_ = BloodPressure?.Effective;
                object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                CqlInterval<CqlDateTime> bp_ = QICoreCommon_4_0_000.Instance.toInterval(context, bo_);
                CqlDateTime bq_ = context.Operators.End(bp_);
                Period br_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> bs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, br_);
                bool? bt_ = context.Operators.In<CqlDateTime>(bq_, bs_, default);
                Code<ObservationStatus> bu_ = BloodPressure?.StatusElement;
                ObservationStatus? bv_ = bu_?.Value;
                string bw_ = context.Operators.Convert<string>(bv_);
                string[] bx_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? by_ = context.Operators.In<string>(bw_, (IEnumerable<string>)bx_);
                bool? bz_ = context.Operators.And(bt_, by_);

                return bz_;
            };
            IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
            object g_(Observation @this)
            {
                DataType ca_ = @this?.Effective;
                object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                CqlInterval<CqlDateTime> cc_ = QICoreCommon_4_0_000.Instance.toInterval(context, cb_);
                CqlDateTime cd_ = context.Operators.Start(cc_);

                return cd_;
            };
            IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
            Observation i_ = context.Operators.Last<Observation>(h_);
            List<Observation.ComponentComponent> j_ = i_?.Component;
            bool? k_(Observation.ComponentComponent C)
            {
                CodeableConcept ce_ = C?.Code;
                CqlConcept cf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ce_);
                CqlCode cg_ = this.Systolic_blood_pressure(context);
                CqlConcept ch_ = context.Operators.ConvertCodeToConcept(cg_);
                bool? ci_ = context.Operators.Equivalent(cf_, ch_);

                return ci_;
            };
            IEnumerable<Observation.ComponentComponent> l_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)j_, k_);
            Observation.ComponentComponent m_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            CqlQuantity p_ = context.Operators.Quantity(0m, "mm[Hg]");
            bool? q_ = context.Operators.Greater(o_ as CqlQuantity, p_);
            bool? s_(Observation BloodPressure)
            {
                DataType cj_ = BloodPressure?.Effective;
                object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                CqlInterval<CqlDateTime> cl_ = QICoreCommon_4_0_000.Instance.toInterval(context, ck_);
                CqlDateTime cm_ = context.Operators.End(cl_);
                Period cn_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> co_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cn_);
                bool? cp_ = context.Operators.In<CqlDateTime>(cm_, co_, default);
                Code<ObservationStatus> cq_ = BloodPressure?.StatusElement;
                ObservationStatus? cr_ = cq_?.Value;
                string cs_ = context.Operators.Convert<string>(cr_);
                string[] ct_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? cu_ = context.Operators.In<string>(cs_, (IEnumerable<string>)ct_);
                bool? cv_ = context.Operators.And(cp_, cu_);

                return cv_;
            };
            IEnumerable<Observation> t_ = context.Operators.Where<Observation>(d_, s_);
            object u_(Observation @this)
            {
                DataType cw_ = @this?.Effective;
                object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                CqlInterval<CqlDateTime> cy_ = QICoreCommon_4_0_000.Instance.toInterval(context, cx_);
                CqlDateTime cz_ = context.Operators.Start(cy_);

                return cz_;
            };
            IEnumerable<Observation> v_ = context.Operators.SortBy<Observation>(t_, u_, System.ComponentModel.ListSortDirection.Ascending);
            Observation w_ = context.Operators.Last<Observation>(v_);
            List<Observation.ComponentComponent> x_ = w_?.Component;
            bool? y_(Observation.ComponentComponent C)
            {
                CodeableConcept da_ = C?.Code;
                CqlConcept db_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, da_);
                CqlCode dc_ = this.Diastolic_blood_pressure(context);
                CqlConcept dd_ = context.Operators.ConvertCodeToConcept(dc_);
                bool? de_ = context.Operators.Equivalent(db_, dd_);

                return de_;
            };
            IEnumerable<Observation.ComponentComponent> z_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)x_, y_);
            Observation.ComponentComponent aa_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(z_);
            DataType ab_ = aa_?.Value;
            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
            bool? ae_ = context.Operators.Greater(ac_ as CqlQuantity, p_);
            bool? af_ = context.Operators.And(q_, ae_);
            bool? ah_(Observation BloodPressure)
            {
                DataType df_ = BloodPressure?.Effective;
                object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                CqlInterval<CqlDateTime> dh_ = QICoreCommon_4_0_000.Instance.toInterval(context, dg_);
                CqlDateTime di_ = context.Operators.End(dh_);
                Period dj_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> dk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dj_);
                bool? dl_ = context.Operators.In<CqlDateTime>(di_, dk_, default);
                Code<ObservationStatus> dm_ = BloodPressure?.StatusElement;
                ObservationStatus? dn_ = dm_?.Value;
                string do_ = context.Operators.Convert<string>(dn_);
                string[] dp_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? dq_ = context.Operators.In<string>(do_, (IEnumerable<string>)dp_);
                bool? dr_ = context.Operators.And(dl_, dq_);

                return dr_;
            };
            IEnumerable<Observation> ai_ = context.Operators.Where<Observation>(d_, ah_);
            object aj_(Observation @this)
            {
                DataType ds_ = @this?.Effective;
                object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                CqlInterval<CqlDateTime> du_ = QICoreCommon_4_0_000.Instance.toInterval(context, dt_);
                CqlDateTime dv_ = context.Operators.Start(du_);

                return dv_;
            };
            IEnumerable<Observation> ak_ = context.Operators.SortBy<Observation>(ai_, aj_, System.ComponentModel.ListSortDirection.Ascending);
            Observation al_ = context.Operators.Last<Observation>(ak_);
            List<Observation.ComponentComponent> am_ = al_?.Component;
            bool? an_(Observation.ComponentComponent C)
            {
                CodeableConcept dw_ = C?.Code;
                CqlConcept dx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dw_);
                CqlCode dy_ = this.Systolic_blood_pressure(context);
                CqlConcept dz_ = context.Operators.ConvertCodeToConcept(dy_);
                bool? ea_ = context.Operators.Equivalent(dx_, dz_);

                return ea_;
            };
            IEnumerable<Observation.ComponentComponent> ao_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)am_, an_);
            Observation.ComponentComponent ap_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ao_);
            DataType aq_ = ap_?.Value;
            object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
            CqlQuantity as_ = context.Operators.Quantity(140m, "mm[Hg]");
            bool? at_ = context.Operators.GreaterOrEqual(ar_ as CqlQuantity, as_);
            bool? av_(Observation BloodPressure)
            {
                DataType eb_ = BloodPressure?.Effective;
                object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                CqlInterval<CqlDateTime> ed_ = QICoreCommon_4_0_000.Instance.toInterval(context, ec_);
                CqlDateTime ee_ = context.Operators.End(ed_);
                Period ef_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> eg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ef_);
                bool? eh_ = context.Operators.In<CqlDateTime>(ee_, eg_, default);
                Code<ObservationStatus> ei_ = BloodPressure?.StatusElement;
                ObservationStatus? ej_ = ei_?.Value;
                string ek_ = context.Operators.Convert<string>(ej_);
                string[] el_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? em_ = context.Operators.In<string>(ek_, (IEnumerable<string>)el_);
                bool? en_ = context.Operators.And(eh_, em_);

                return en_;
            };
            IEnumerable<Observation> aw_ = context.Operators.Where<Observation>(d_, av_);
            object ax_(Observation @this)
            {
                DataType eo_ = @this?.Effective;
                object ep_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eo_);
                CqlInterval<CqlDateTime> eq_ = QICoreCommon_4_0_000.Instance.toInterval(context, ep_);
                CqlDateTime er_ = context.Operators.Start(eq_);

                return er_;
            };
            IEnumerable<Observation> ay_ = context.Operators.SortBy<Observation>(aw_, ax_, System.ComponentModel.ListSortDirection.Ascending);
            Observation az_ = context.Operators.Last<Observation>(ay_);
            List<Observation.ComponentComponent> ba_ = az_?.Component;
            bool? bb_(Observation.ComponentComponent C)
            {
                CodeableConcept es_ = C?.Code;
                CqlConcept et_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, es_);
                CqlCode eu_ = this.Diastolic_blood_pressure(context);
                CqlConcept ev_ = context.Operators.ConvertCodeToConcept(eu_);
                bool? ew_ = context.Operators.Equivalent(et_, ev_);

                return ew_;
            };
            IEnumerable<Observation.ComponentComponent> bc_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ba_, bb_);
            Observation.ComponentComponent bd_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(bc_);
            DataType be_ = bd_?.Value;
            object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
            CqlQuantity bg_ = context.Operators.Quantity(90m, "mm[Hg]");
            bool? bh_ = context.Operators.GreaterOrEqual(bf_ as CqlQuantity, bg_);
            bool? bi_ = context.Operators.Or(at_, bh_);
            bool? bj_ = context.Operators.And(af_, bi_);
            IEnumerable<Encounter> bk_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior(context);
            bool? bl_ = context.Operators.Exists<Encounter>(bk_);
            bool? bm_ = context.Operators.And(bj_, bl_);

            return bm_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 Interventions")]
    public IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions(CqlContext context)
    {
        CqlValueSet a_ = this.Follow_Up_Within_4_Weeks(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> c_(ServiceRequest WeeksRescreen)
        {
            IEnumerable<ServiceRequest> i_ = this.Laboratory_Test_or_ECG_for_Hypertension(context);
            bool? j_(ServiceRequest ECGLabTest)
            {
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
                bool? z_ = context.Operators.Equivalent(y_, "order");
                bool? aa_ = context.Operators.And(v_, z_);
                Code<RequestIntent> ab_ = ECGLabTest?.IntentElement;
                RequestIntent? ac_ = ab_?.Value;
                Code<RequestIntent> ad_ = context.Operators.Convert<Code<RequestIntent>>(ac_);
                bool? ae_ = context.Operators.Equivalent(ad_, "order");
                bool? af_ = context.Operators.And(aa_, ae_);

                return af_;
            };
            IEnumerable<ServiceRequest> k_ = context.Operators.Where<ServiceRequest>(i_, j_);
            ServiceRequest l_(ServiceRequest ECGLabTest) =>
                WeeksRescreen;
            IEnumerable<ServiceRequest> m_ = context.Operators.Select<ServiceRequest, ServiceRequest>(k_, l_);

            return m_;
        };
        IEnumerable<ServiceRequest> d_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(b_, c_);
        IEnumerable<ServiceRequest> e_(ServiceRequest WeeksRescreen)
        {
            IEnumerable<ServiceRequest> ag_ = this.NonPharmacological_Interventions(context);
            bool? ah_(ServiceRequest HTNInterventions)
            {
                FhirDateTime al_ = HTNInterventions?.AuthoredOnElement;
                CqlDateTime am_ = context.Operators.Convert<CqlDateTime>(al_);
                CqlInterval<CqlDateTime> an_ = this.Measurement_Period(context);
                bool? ao_ = context.Operators.In<CqlDateTime>(am_, an_, "day");

                return ao_;
            };
            IEnumerable<ServiceRequest> ai_ = context.Operators.Where<ServiceRequest>(ag_, ah_);
            ServiceRequest aj_(ServiceRequest HTNInterventions) =>
                WeeksRescreen;
            IEnumerable<ServiceRequest> ak_ = context.Operators.Select<ServiceRequest, ServiceRequest>(ai_, aj_);

            return ak_;
        };
        IEnumerable<ServiceRequest> f_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(d_, e_);
        IEnumerable<ServiceRequest> g_(ServiceRequest WeeksRescreen)
        {
            CqlValueSet ap_ = this.Pharmacologic_Therapy_for_Hypertension(context);
            IEnumerable<MedicationRequest> aq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ap_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> ar_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> as_(MedicationRequest MR)
            {
                IEnumerable<Medication> az_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? ba_(Medication M)
                {
                    object be_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object bf_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> bg_ = context.Operators.Split((string)bf_, "/");
                    string bh_ = context.Operators.Last<string>(bg_);
                    bool? bi_ = context.Operators.Equal(be_, bh_);
                    CodeableConcept bj_ = M?.Code;
                    CqlConcept bk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bj_);
                    CqlValueSet bl_ = this.Pharmacologic_Therapy_for_Hypertension(context);
                    bool? bm_ = context.Operators.ConceptInValueSet(bk_, bl_);
                    bool? bn_ = context.Operators.And(bi_, bm_);

                    return bn_;
                };
                IEnumerable<Medication> bb_ = context.Operators.Where<Medication>(az_, ba_);
                MedicationRequest bc_(Medication M) =>
                    MR;
                IEnumerable<MedicationRequest> bd_ = context.Operators.Select<Medication, MedicationRequest>(bb_, bc_);

                return bd_;
            };
            IEnumerable<MedicationRequest> at_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(ar_, as_);
            IEnumerable<MedicationRequest> au_ = context.Operators.Union<MedicationRequest>(aq_, at_);
            bool? av_(MedicationRequest Medications)
            {
                FhirDateTime bo_ = Medications?.AuthoredOnElement;
                CqlDateTime bp_ = context.Operators.Convert<CqlDateTime>(bo_);
                CqlInterval<CqlDateTime> bq_ = this.Measurement_Period(context);
                bool? br_ = context.Operators.In<CqlDateTime>(bp_, bq_, "day");
                Code<MedicationRequest.MedicationrequestStatus> bs_ = Medications?.StatusElement;
                MedicationRequest.MedicationrequestStatus? bt_ = bs_?.Value;
                string bu_ = context.Operators.Convert<string>(bt_);
                bool? bv_ = context.Operators.Equivalent(bu_, "active");
                bool? bw_ = context.Operators.And(br_, bv_);

                return bw_;
            };
            IEnumerable<MedicationRequest> aw_ = context.Operators.Where<MedicationRequest>(au_, av_);
            ServiceRequest ax_(MedicationRequest Medications) =>
                WeeksRescreen;
            IEnumerable<ServiceRequest> ay_ = context.Operators.Select<MedicationRequest, ServiceRequest>(aw_, ax_);

            return ay_;
        };
        IEnumerable<ServiceRequest> h_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(f_, g_);

        return h_;
    }


    [CqlExpressionDefinition("Encounter with Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 and Interventions")]
    public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_and_Interventions(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90(context);
        IEnumerable<Encounter> b_(Encounter SecondHTNEncounterReading140Over90)
        {
            IEnumerable<ServiceRequest> h_ = this.Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions(context);
            bool? i_(ServiceRequest SecondHTN140Over90Interventions)
            {
                FhirDateTime m_ = SecondHTN140Over90Interventions?.AuthoredOnElement;
                CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
                Period o_ = SecondHTNEncounterReading140Over90?.Period;
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                bool? q_ = context.Operators.In<CqlDateTime>(n_, p_, "day");

                return q_;
            };
            IEnumerable<ServiceRequest> j_ = context.Operators.Where<ServiceRequest>(h_, i_);
            Encounter k_(ServiceRequest SecondHTN140Over90Interventions) =>
                SecondHTNEncounterReading140Over90;
            IEnumerable<Encounter> l_ = context.Operators.Select<ServiceRequest, Encounter>(j_, k_);

            return l_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        IEnumerable<Encounter> e_(Encounter SecondHTNEncounterReading140Over90)
        {
            IEnumerable<ServiceRequest> r_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(context);
            bool? s_(ServiceRequest ReferralToProfessional)
            {
                FhirDateTime w_ = ReferralToProfessional?.AuthoredOnElement;
                CqlDateTime x_ = context.Operators.Convert<CqlDateTime>(w_);
                Period y_ = SecondHTNEncounterReading140Over90?.Period;
                CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
                bool? aa_ = context.Operators.In<CqlDateTime>(x_, z_, "day");

                return aa_;
            };
            IEnumerable<ServiceRequest> t_ = context.Operators.Where<ServiceRequest>(r_, s_);
            Encounter u_(ServiceRequest ReferralToProfessional) =>
                SecondHTNEncounterReading140Over90;
            IEnumerable<Encounter> v_ = context.Operators.Select<ServiceRequest, Encounter>(t_, u_);

            return v_;
        };
        IEnumerable<Encounter> f_ = context.Operators.SelectMany<Encounter, Encounter>(a_, e_);
        IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);

        return g_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
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
    public IEnumerable<Encounter> Encounter_with_Medical_Reason_for_Not_Obtaining_or_Patient_Declined_Blood_Pressure_Measurement(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        IEnumerable<Encounter> b_(Encounter QualifyingEncounter)
        {
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
            bool? o_(Observation NoBPScreen)
            {
                Instant s_ = NoBPScreen?.IssuedElement;
                DateTimeOffset? t_ = s_?.Value;
                CqlDateTime u_ = context.Operators.Convert<CqlDateTime>(t_);
                Period v_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, v_);
                bool? x_ = context.Operators.In<CqlDateTime>(u_, w_, "day");
                Code<ObservationStatus> y_ = NoBPScreen?.StatusElement;
                ObservationStatus? z_ = y_?.Value;
                Code<ObservationStatus> aa_ = context.Operators.Convert<Code<ObservationStatus>>(z_);
                bool? ab_ = context.Operators.Equal(aa_, "cancelled");
                bool? ac_ = context.Operators.And(x_, ab_);
                bool? ad_(Extension @this)
                {
                    string av_ = @this?.Url;
                    FhirString aw_ = context.Operators.Convert<FhirString>(av_);
                    string ax_ = FHIRHelpers_4_4_000.Instance.ToString(context, aw_);
                    bool? ay_ = context.Operators.Equal(ax_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

                    return ay_;
                };
                IEnumerable<Extension> ae_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoBPScreen is DomainResource
                        ? (NoBPScreen as DomainResource).Extension
                        : default), ad_);
                object af_(Extension @this)
                {
                    DataType az_ = @this?.Value;

                    return az_;
                };
                IEnumerable<object> ag_ = context.Operators.Select<Extension, object>(ae_, af_);
                object ah_ = context.Operators.SingletonFrom<object>(ag_);
                CqlConcept ai_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ah_ as CodeableConcept);
                CqlValueSet aj_ = this.Patient_Declined(context);
                bool? ak_ = context.Operators.ConceptInValueSet(ai_, aj_);
                bool? al_(Extension @this)
                {
                    string ba_ = @this?.Url;
                    FhirString bb_ = context.Operators.Convert<FhirString>(ba_);
                    string bc_ = FHIRHelpers_4_4_000.Instance.ToString(context, bb_);
                    bool? bd_ = context.Operators.Equal(bc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

                    return bd_;
                };
                IEnumerable<Extension> am_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoBPScreen is DomainResource
                        ? (NoBPScreen as DomainResource).Extension
                        : default), al_);
                object an_(Extension @this)
                {
                    DataType be_ = @this?.Value;

                    return be_;
                };
                IEnumerable<object> ao_ = context.Operators.Select<Extension, object>(am_, an_);
                object ap_ = context.Operators.SingletonFrom<object>(ao_);
                CqlConcept aq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ap_ as CodeableConcept);
                CqlValueSet ar_ = this.Medical_Reason(context);
                bool? as_ = context.Operators.ConceptInValueSet(aq_, ar_);
                bool? at_ = context.Operators.Or(ak_, as_);
                bool? au_ = context.Operators.And(ac_, at_);

                return au_;
            };
            IEnumerable<Observation> p_ = context.Operators.Where<Observation>(n_, o_);
            Encounter q_(Observation NoBPScreen) =>
                QualifyingEncounter;
            IEnumerable<Encounter> r_ = context.Operators.Select<Observation, Encounter>(p_, q_);

            return r_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("NonPharmacological Intervention Not Ordered")]
    public IEnumerable<ServiceRequest> NonPharmacological_Intervention_Not_Ordered(CqlContext context)
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
        bool? ad_(ServiceRequest NonPharmIntervention)
        {
            Code<RequestStatus> af_ = NonPharmIntervention?.StatusElement;
            RequestStatus? ag_ = af_?.Value;
            Code<RequestStatus> ah_ = context.Operators.Convert<Code<RequestStatus>>(ag_);
            bool? ai_ = context.Operators.Equal(ah_, "completed");
            bool? aj_(Extension @this)
            {
                string as_ = @this?.Url;
                FhirString at_ = context.Operators.Convert<FhirString>(as_);
                string au_ = FHIRHelpers_4_4_000.Instance.ToString(context, at_);
                bool? av_ = context.Operators.Equal(au_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                return av_;
            };
            IEnumerable<Extension> ak_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NonPharmIntervention is DomainResource
                    ? (NonPharmIntervention as DomainResource).Extension
                    : default), aj_);
            object al_(Extension @this)
            {
                DataType aw_ = @this?.Value;

                return aw_;
            };
            IEnumerable<object> am_ = context.Operators.Select<Extension, object>(ak_, al_);
            object an_ = context.Operators.SingletonFrom<object>(am_);
            CqlConcept ao_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, an_ as CodeableConcept);
            CqlValueSet ap_ = this.Patient_Declined(context);
            bool? aq_ = context.Operators.ConceptInValueSet(ao_, ap_);
            bool? ar_ = context.Operators.And(ai_, aq_);

            return ar_;
        };
        IEnumerable<ServiceRequest> ae_ = context.Operators.Where<ServiceRequest>(ac_, ad_);

        return ae_;
    }


    [CqlExpressionDefinition("Laboratory Test or ECG for Hypertension Not Ordered")]
    public IEnumerable<ServiceRequest> Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered(CqlContext context)
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
        bool? n_(ServiceRequest LabECGNotDone)
        {
            List<Extension> p_ = LabECGNotDone?.Extension;
            bool? q_(Extension E)
            {
                string t_ = E?.Url;
                FhirString u_ = context.Operators.Convert<FhirString>(t_);
                string v_ = u_?.Value;
                bool? w_ = context.Operators.Equal(v_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                DataType x_ = E?.Value;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                CqlValueSet z_ = this.Patient_Declined(context);
                bool? aa_ = context.Operators.ConceptInValueSet(y_ as CqlConcept, z_);
                bool? ab_ = context.Operators.And(w_, aa_);

                return ab_;
            };
            IEnumerable<Extension> r_ = context.Operators.Where<Extension>((IEnumerable<Extension>)p_, q_);
            bool? s_ = context.Operators.Exists<Extension>(r_);

            return s_;
        };
        IEnumerable<ServiceRequest> o_ = context.Operators.Where<ServiceRequest>(m_, n_);

        return o_;
    }


    [CqlExpressionDefinition("Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 Interventions Declined")]
    public IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined(CqlContext context)
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
        bool? l_(ServiceRequest SecondHTNDeclinedReferralAndFollowUp)
        {
            Code<RequestStatus> r_ = SecondHTNDeclinedReferralAndFollowUp?.StatusElement;
            RequestStatus? s_ = r_?.Value;
            Code<RequestStatus> t_ = context.Operators.Convert<Code<RequestStatus>>(s_);
            bool? u_ = context.Operators.Equal(t_, "completed");
            bool? v_(Extension @this)
            {
                string ae_ = @this?.Url;
                FhirString af_ = context.Operators.Convert<FhirString>(ae_);
                string ag_ = FHIRHelpers_4_4_000.Instance.ToString(context, af_);
                bool? ah_ = context.Operators.Equal(ag_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                return ah_;
            };
            IEnumerable<Extension> w_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(SecondHTNDeclinedReferralAndFollowUp is DomainResource
                    ? (SecondHTNDeclinedReferralAndFollowUp as DomainResource).Extension
                    : default), v_);
            object x_(Extension @this)
            {
                DataType ai_ = @this?.Value;

                return ai_;
            };
            IEnumerable<object> y_ = context.Operators.Select<Extension, object>(w_, x_);
            object z_ = context.Operators.SingletonFrom<object>(y_);
            CqlConcept aa_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, z_ as CodeableConcept);
            CqlValueSet ab_ = this.Patient_Declined(context);
            bool? ac_ = context.Operators.ConceptInValueSet(aa_, ab_);
            bool? ad_ = context.Operators.And(u_, ac_);

            return ad_;
        };
        IEnumerable<ServiceRequest> m_ = context.Operators.Where<ServiceRequest>(k_, l_);
        IEnumerable<ServiceRequest> n_ = this.Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered(context);
        IEnumerable<ServiceRequest> o_ = context.Operators.Union<ServiceRequest>(m_, n_);
        IEnumerable<ServiceRequest> p_ = this.NonPharmacological_Intervention_Not_Ordered(context);
        IEnumerable<ServiceRequest> q_ = context.Operators.Union<ServiceRequest>(o_, p_);

        return q_;
    }


    [CqlExpressionDefinition("Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 Interventions Declined")]
    public IEnumerable<object> Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined(CqlContext context)
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
        bool? l_(ServiceRequest SecondHTN140Over90ReferralFollowUpNotDone)
        {
            Code<RequestStatus> z_ = SecondHTN140Over90ReferralFollowUpNotDone?.StatusElement;
            RequestStatus? aa_ = z_?.Value;
            Code<RequestStatus> ab_ = context.Operators.Convert<Code<RequestStatus>>(aa_);
            bool? ac_ = context.Operators.Equal(ab_, "completed");
            bool? ad_(Extension @this)
            {
                string am_ = @this?.Url;
                FhirString an_ = context.Operators.Convert<FhirString>(am_);
                string ao_ = FHIRHelpers_4_4_000.Instance.ToString(context, an_);
                bool? ap_ = context.Operators.Equal(ao_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                return ap_;
            };
            IEnumerable<Extension> ae_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(SecondHTN140Over90ReferralFollowUpNotDone is DomainResource
                    ? (SecondHTN140Over90ReferralFollowUpNotDone as DomainResource).Extension
                    : default), ad_);
            object af_(Extension @this)
            {
                DataType aq_ = @this?.Value;

                return aq_;
            };
            IEnumerable<object> ag_ = context.Operators.Select<Extension, object>(ae_, af_);
            object ah_ = context.Operators.SingletonFrom<object>(ag_);
            CqlConcept ai_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ah_ as CodeableConcept);
            CqlValueSet aj_ = this.Patient_Declined(context);
            bool? ak_ = context.Operators.ConceptInValueSet(ai_, aj_);
            bool? al_ = context.Operators.And(ac_, ak_);

            return al_;
        };
        IEnumerable<ServiceRequest> m_ = context.Operators.Where<ServiceRequest>(k_, l_);
        CqlValueSet n_ = this.Pharmacologic_Therapy_for_Hypertension(context);
        IEnumerable<MedicationRequest> o_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> q_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> r_ = context.Operators.Union<MedicationRequest>(o_, q_);
        bool? s_(MedicationRequest MedicationRequestNotOrdered)
        {
            Code<MedicationRequest.MedicationrequestStatus> ar_ = MedicationRequestNotOrdered?.StatusElement;
            MedicationRequest.MedicationrequestStatus? as_ = ar_?.Value;
            string at_ = context.Operators.Convert<string>(as_);
            bool? au_ = context.Operators.Equal(at_, "completed");

            return au_;
        };
        IEnumerable<MedicationRequest> t_ = context.Operators.Where<MedicationRequest>(r_, s_);
        IEnumerable<object> u_ = context.Operators.Union<object>(m_ as IEnumerable<object>, t_ as IEnumerable<object>);
        IEnumerable<ServiceRequest> v_ = this.Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered(context);
        IEnumerable<object> w_ = context.Operators.Union<object>(u_ as IEnumerable<object>, v_ as IEnumerable<object>);
        IEnumerable<ServiceRequest> x_ = this.NonPharmacological_Intervention_Not_Ordered(context);
        IEnumerable<object> y_ = context.Operators.Union<object>(w_ as IEnumerable<object>, x_ as IEnumerable<object>);

        return y_;
    }


    [CqlExpressionDefinition("Encounter with Order for Hypertension Follow Up Declined by Patient")]
    public IEnumerable<Encounter> Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80(context);
        IEnumerable<Encounter> b_(Encounter ElevatedBPEncounter)
        {
            CqlValueSet x_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
            IEnumerable<ServiceRequest> y_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> aa_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> ab_ = context.Operators.Union<ServiceRequest>(y_, aa_);
            CqlValueSet ac_ = this.Follow_Up_Within_6_Months(context);
            IEnumerable<ServiceRequest> ad_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, ac_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> af_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, ac_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> ag_ = context.Operators.Union<ServiceRequest>(ad_, af_);
            IEnumerable<ServiceRequest> ah_ = context.Operators.Union<ServiceRequest>(ab_, ag_);
            bool? ai_(ServiceRequest ElevatedBPDeclinedInterventions)
            {
                FhirDateTime am_ = ElevatedBPDeclinedInterventions?.AuthoredOnElement;
                CqlDateTime an_ = context.Operators.Convert<CqlDateTime>(am_);
                Period ao_ = ElevatedBPEncounter?.Period;
                CqlInterval<CqlDateTime> ap_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ao_);
                bool? aq_ = context.Operators.In<CqlDateTime>(an_, ap_, "day");
                Code<RequestStatus> ar_ = ElevatedBPDeclinedInterventions?.StatusElement;
                RequestStatus? as_ = ar_?.Value;
                Code<RequestStatus> at_ = context.Operators.Convert<Code<RequestStatus>>(as_);
                bool? au_ = context.Operators.Equal(at_, "completed");
                bool? av_ = context.Operators.And(aq_, au_);
                bool? aw_(Extension @this)
                {
                    string bf_ = @this?.Url;
                    FhirString bg_ = context.Operators.Convert<FhirString>(bf_);
                    string bh_ = FHIRHelpers_4_4_000.Instance.ToString(context, bg_);
                    bool? bi_ = context.Operators.Equal(bh_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                    return bi_;
                };
                IEnumerable<Extension> ax_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(ElevatedBPDeclinedInterventions is DomainResource
                        ? (ElevatedBPDeclinedInterventions as DomainResource).Extension
                        : default), aw_);
                object ay_(Extension @this)
                {
                    DataType bj_ = @this?.Value;

                    return bj_;
                };
                IEnumerable<object> az_ = context.Operators.Select<Extension, object>(ax_, ay_);
                object ba_ = context.Operators.SingletonFrom<object>(az_);
                CqlConcept bb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ba_ as CodeableConcept);
                CqlValueSet bc_ = this.Patient_Declined(context);
                bool? bd_ = context.Operators.ConceptInValueSet(bb_, bc_);
                bool? be_ = context.Operators.And(av_, bd_);

                return be_;
            };
            IEnumerable<ServiceRequest> aj_ = context.Operators.Where<ServiceRequest>(ah_, ai_);
            Encounter ak_(ServiceRequest ElevatedBPDeclinedInterventions) =>
                ElevatedBPEncounter;
            IEnumerable<Encounter> al_ = context.Operators.Select<ServiceRequest, Encounter>(aj_, ak_);

            return al_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        IEnumerable<Encounter> e_(Encounter ElevatedBPEncounter)
        {
            IEnumerable<ServiceRequest> bk_ = this.NonPharmacological_Intervention_Not_Ordered(context);
            bool? bl_(ServiceRequest NotOrdered)
            {
                FhirDateTime bp_ = NotOrdered?.AuthoredOnElement;
                CqlDateTime bq_ = context.Operators.Convert<CqlDateTime>(bp_);
                Period br_ = ElevatedBPEncounter?.Period;
                CqlInterval<CqlDateTime> bs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, br_);
                bool? bt_ = context.Operators.In<CqlDateTime>(bq_, bs_, "day");

                return bt_;
            };
            IEnumerable<ServiceRequest> bm_ = context.Operators.Where<ServiceRequest>(bk_, bl_);
            Encounter bn_(ServiceRequest NotOrdered) =>
                ElevatedBPEncounter;
            IEnumerable<Encounter> bo_ = context.Operators.Select<ServiceRequest, Encounter>(bm_, bn_);

            return bo_;
        };
        IEnumerable<Encounter> f_ = context.Operators.SelectMany<Encounter, Encounter>(a_, e_);
        IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);
        IEnumerable<Encounter> h_ = this.Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80(context);
        IEnumerable<Encounter> i_(Encounter FirstHTNEncounter)
        {
            CqlValueSet bu_ = this.Follow_Up_Within_4_Weeks(context);
            IEnumerable<ServiceRequest> bv_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, bu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> bx_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, bu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> by_ = context.Operators.Union<ServiceRequest>(bv_, bx_);
            CqlValueSet bz_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
            IEnumerable<ServiceRequest> ca_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, bz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> cc_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, bz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> cd_ = context.Operators.Union<ServiceRequest>(ca_, cc_);
            IEnumerable<ServiceRequest> ce_ = context.Operators.Union<ServiceRequest>(by_, cd_);
            bool? cf_(ServiceRequest FirstHTNDeclinedInterventions)
            {
                FhirDateTime cj_ = FirstHTNDeclinedInterventions?.AuthoredOnElement;
                CqlDateTime ck_ = context.Operators.Convert<CqlDateTime>(cj_);
                Period cl_ = FirstHTNEncounter?.Period;
                CqlInterval<CqlDateTime> cm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cl_);
                bool? cn_ = context.Operators.In<CqlDateTime>(ck_, cm_, "day");
                Code<RequestStatus> co_ = FirstHTNDeclinedInterventions?.StatusElement;
                RequestStatus? cp_ = co_?.Value;
                Code<RequestStatus> cq_ = context.Operators.Convert<Code<RequestStatus>>(cp_);
                bool? cr_ = context.Operators.Equal(cq_, "completed");
                bool? cs_ = context.Operators.And(cn_, cr_);
                bool? ct_(Extension @this)
                {
                    string dc_ = @this?.Url;
                    FhirString dd_ = context.Operators.Convert<FhirString>(dc_);
                    string de_ = FHIRHelpers_4_4_000.Instance.ToString(context, dd_);
                    bool? df_ = context.Operators.Equal(de_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                    return df_;
                };
                IEnumerable<Extension> cu_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(FirstHTNDeclinedInterventions is DomainResource
                        ? (FirstHTNDeclinedInterventions as DomainResource).Extension
                        : default), ct_);
                object cv_(Extension @this)
                {
                    DataType dg_ = @this?.Value;

                    return dg_;
                };
                IEnumerable<object> cw_ = context.Operators.Select<Extension, object>(cu_, cv_);
                object cx_ = context.Operators.SingletonFrom<object>(cw_);
                CqlConcept cy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cx_ as CodeableConcept);
                CqlValueSet cz_ = this.Patient_Declined(context);
                bool? da_ = context.Operators.ConceptInValueSet(cy_, cz_);
                bool? db_ = context.Operators.And(cs_, da_);

                return db_;
            };
            IEnumerable<ServiceRequest> cg_ = context.Operators.Where<ServiceRequest>(ce_, cf_);
            Encounter ch_(ServiceRequest FirstHTNDeclinedInterventions) =>
                FirstHTNEncounter;
            IEnumerable<Encounter> ci_ = context.Operators.Select<ServiceRequest, Encounter>(cg_, ch_);

            return ci_;
        };
        IEnumerable<Encounter> j_ = context.Operators.SelectMany<Encounter, Encounter>(h_, i_);
        IEnumerable<Encounter> l_(Encounter FirstHTNEncounter)
        {
            IEnumerable<ServiceRequest> dh_ = this.NonPharmacological_Intervention_Not_Ordered(context);
            bool? di_(ServiceRequest NoNonPharm)
            {
                FhirDateTime dm_ = NoNonPharm?.AuthoredOnElement;
                CqlDateTime dn_ = context.Operators.Convert<CqlDateTime>(dm_);
                Period do_ = FirstHTNEncounter?.Period;
                CqlInterval<CqlDateTime> dp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, do_);
                bool? dq_ = context.Operators.In<CqlDateTime>(dn_, dp_, "day");

                return dq_;
            };
            IEnumerable<ServiceRequest> dj_ = context.Operators.Where<ServiceRequest>(dh_, di_);
            Encounter dk_(ServiceRequest NoNonPharm) =>
                FirstHTNEncounter;
            IEnumerable<Encounter> dl_ = context.Operators.Select<ServiceRequest, Encounter>(dj_, dk_);

            return dl_;
        };
        IEnumerable<Encounter> m_ = context.Operators.SelectMany<Encounter, Encounter>(h_, l_);
        IEnumerable<Encounter> n_ = context.Operators.Union<Encounter>(j_, m_);
        IEnumerable<Encounter> o_ = context.Operators.Union<Encounter>(g_, n_);
        IEnumerable<Encounter> p_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89(context);
        IEnumerable<Encounter> q_(Encounter SecondHTNEncounter)
        {
            IEnumerable<ServiceRequest> dr_ = this.Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined(context);
            bool? ds_(ServiceRequest SecondHTNDeclinedInterventions)
            {
                FhirDateTime dw_ = SecondHTNDeclinedInterventions?.AuthoredOnElement;
                CqlDateTime dx_ = context.Operators.Convert<CqlDateTime>(dw_);
                Period dy_ = SecondHTNEncounter?.Period;
                CqlInterval<CqlDateTime> dz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dy_);
                bool? ea_ = context.Operators.In<CqlDateTime>(dx_, dz_, "day");

                return ea_;
            };
            IEnumerable<ServiceRequest> dt_ = context.Operators.Where<ServiceRequest>(dr_, ds_);
            Encounter du_(ServiceRequest SecondHTNDeclinedInterventions) =>
                SecondHTNEncounter;
            IEnumerable<Encounter> dv_ = context.Operators.Select<ServiceRequest, Encounter>(dt_, du_);

            return dv_;
        };
        IEnumerable<Encounter> r_ = context.Operators.SelectMany<Encounter, Encounter>(p_, q_);
        IEnumerable<Encounter> s_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90(context);
        IEnumerable<Encounter> t_(Encounter SecondHTN140Over90Encounter)
        {
            IEnumerable<object> eb_ = this.Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined(context);
            bool? ec_(object SecondHTN140Over90DeclinedInterventions)
            {
                object eg_ = context.Operators.LateBoundProperty<object>(SecondHTN140Over90DeclinedInterventions, "authoredOn");
                CqlDateTime eh_ = context.Operators.LateBoundProperty<CqlDateTime>(eg_, "value");
                Period ei_ = SecondHTN140Over90Encounter?.Period;
                CqlInterval<CqlDateTime> ej_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ei_);
                bool? ek_ = context.Operators.In<CqlDateTime>(eh_, ej_, "day");

                return ek_;
            };
            IEnumerable<object> ed_ = context.Operators.Where<object>(eb_, ec_);
            Encounter ee_(object SecondHTN140Over90DeclinedInterventions) =>
                SecondHTN140Over90Encounter;
            IEnumerable<Encounter> ef_ = context.Operators.Select<object, Encounter>(ed_, ee_);

            return ef_;
        };
        IEnumerable<Encounter> u_ = context.Operators.SelectMany<Encounter, Encounter>(s_, t_);
        IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(r_, u_);
        IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(o_, v_);

        return w_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Medical_Reason_for_Not_Obtaining_or_Patient_Declined_Blood_Pressure_Measurement(context);
        IEnumerable<Encounter> b_ = this.Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);

        return a_;
    }


    #endregion Functions and Expressions

}
