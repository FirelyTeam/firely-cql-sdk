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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.0.0.0")]
[CqlLibrary("CMS144FHIRHFBetaBlockerForLVSD", "1.0.000")]
public partial class CMS144FHIRHFBetaBlockerForLVSD_1_0_000 : ILibrary, ISingleton<CMS144FHIRHFBetaBlockerForLVSD_1_0_000>
{
    #region ValueSets

    [CqlValueSetDefinition("Allergy to Beta Blocker Therapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1177", valueSetVersion: null)]
    public CqlValueSet Allergy_to_Beta_Blocker_Therapy(CqlContext _) => _Allergy_to_Beta_Blocker_Therapy;
    private static readonly CqlValueSet _Allergy_to_Beta_Blocker_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1177", null);

    [CqlValueSetDefinition("Arrhythmia", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.366", valueSetVersion: null)]
    public CqlValueSet Arrhythmia(CqlContext _) => _Arrhythmia;
    private static readonly CqlValueSet _Arrhythmia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.366", null);

    [CqlValueSetDefinition("Asthma", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.362", valueSetVersion: null)]
    public CqlValueSet Asthma(CqlContext _) => _Asthma;
    private static readonly CqlValueSet _Asthma = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.362", null);

    [CqlValueSetDefinition("Atrioventricular Block", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.367", valueSetVersion: null)]
    public CqlValueSet Atrioventricular_Block(CqlContext _) => _Atrioventricular_Block;
    private static readonly CqlValueSet _Atrioventricular_Block = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.367", null);

    [CqlValueSetDefinition("Beta Blocker Therapy for LVSD", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1184", valueSetVersion: null)]
    public CqlValueSet Beta_Blocker_Therapy_for_LVSD(CqlContext _) => _Beta_Blocker_Therapy_for_LVSD;
    private static readonly CqlValueSet _Beta_Blocker_Therapy_for_LVSD = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1184", null);

    [CqlValueSetDefinition("Beta Blocker Therapy Ingredient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1493", valueSetVersion: null)]
    public CqlValueSet Beta_Blocker_Therapy_Ingredient(CqlContext _) => _Beta_Blocker_Therapy_Ingredient;
    private static readonly CqlValueSet _Beta_Blocker_Therapy_Ingredient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1493", null);

    [CqlValueSetDefinition("Bradycardia", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.412", valueSetVersion: null)]
    public CqlValueSet Bradycardia(CqlContext _) => _Bradycardia;
    private static readonly CqlValueSet _Bradycardia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.412", null);

    [CqlValueSetDefinition("Cardiac Pacer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.53", valueSetVersion: null)]
    public CqlValueSet Cardiac_Pacer(CqlContext _) => _Cardiac_Pacer;
    private static readonly CqlValueSet _Cardiac_Pacer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.53", null);

    [CqlValueSetDefinition("Cardiac Pacer in Situ", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.368", valueSetVersion: null)]
    public CqlValueSet Cardiac_Pacer_in_Situ(CqlContext _) => _Cardiac_Pacer_in_Situ;
    private static readonly CqlValueSet _Cardiac_Pacer_in_Situ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.368", null);

    [CqlValueSetDefinition("Hypotension", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.370", valueSetVersion: null)]
    public CqlValueSet Hypotension(CqlContext _) => _Hypotension;
    private static readonly CqlValueSet _Hypotension = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.370", null);

    [CqlValueSetDefinition("Intolerance to Beta Blocker Therapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1178", valueSetVersion: null)]
    public CqlValueSet Intolerance_to_Beta_Blocker_Therapy(CqlContext _) => _Intolerance_to_Beta_Blocker_Therapy;
    private static readonly CqlValueSet _Intolerance_to_Beta_Blocker_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1178", null);

    [CqlValueSetDefinition("Medical Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", valueSetVersion: null)]
    public CqlValueSet Medical_Reason(CqlContext _) => _Medical_Reason;
    private static readonly CqlValueSet _Medical_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);

    [CqlValueSetDefinition("Patient Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008", valueSetVersion: null)]
    public CqlValueSet Patient_Reason(CqlContext _) => _Patient_Reason;
    private static readonly CqlValueSet _Patient_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Substance with beta adrenergic receptor antagonist mechanism of action (substance)", codeId: "373254001", codeSystem: "http://snomed.info/sct")]
    public CqlCode Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_(CqlContext _) => _Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_;
    private static readonly CqlCode _Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_ = new CqlCode("373254001", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlInterval<CqlDateTime>>(2616853413637305416L, () => {
            object a_ = context.ResolveParameter("CMS144FHIRHFBetaBlockerForLVSD-1.0.000", "Measurement Period", null);
            return (CqlInterval<CqlDateTime>)a_;
        });


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<Patient>(-7772502128286363363L, () => {
            IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
            Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
            return b_;
        });


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(38685777630265383L, () => {
            bool? a_ = AHAOverall_4_1_000.Instance.Is_Adult_With_Two_Qualifying_Outpatient_Encounters_and_One_Heart_Failure_Outpatient_Encounter_During_the_Measurement_Period(context);
            return a_;
        });


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-3472072733239199912L, () => {
            bool? a_ = this.Initial_Population(context);
            IEnumerable<Encounter> b_ = AHAOverall_4_1_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? c_ = context.Operators.Exists<Encounter>(b_);
            bool? d_ = context.Operators.And(a_, c_);
            return d_;
        });


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-6398594374452645514L, () => {
            bool? a_ = AHAOverall_4_1_000.Instance.Has_Heart_Transplant(context);
            bool? b_ = AHAOverall_4_1_000.Instance.Has_Heart_Transplant_Complications(context);
            bool? c_ = context.Operators.Or(a_, b_);
            bool? d_ = AHAOverall_4_1_000.Instance.Has_Left_Ventricular_Assist_Device(context);
            bool? e_ = context.Operators.Or(c_, d_);
            bool? f_ = AHAOverall_4_1_000.Instance.Has_Left_Ventricular_Assist_Device_Complications(context);
            bool? g_ = context.Operators.Or(e_, f_);
            return g_;
        });


    [CqlExpressionDefinition("Has Beta Blocker Therapy for LVSD Ordered")]
    public bool? Has_Beta_Blocker_Therapy_for_LVSD_Ordered(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(6987738993386788375L, () => {
            CqlValueSet a_ = this.Beta_Blocker_Therapy_for_LVSD(context);
            IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? c_(MedicationRequest BetaBlockerOrdered) {
                bool? f_ = AHAOverall_4_1_000.Instance.isOrderedDuringHeartFailureOutpatientEncounter(context, BetaBlockerOrdered);
                return f_;
            }

            IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(b_, c_);
            bool? e_ = context.Operators.Exists<MedicationRequest>(d_);
            return e_;
        });


    [CqlExpressionDefinition("Is Currently Taking Beta Blocker Therapy for LVSD")]
    public bool? Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(5558459301105956202L, () => {
            CqlValueSet a_ = this.Beta_Blocker_Therapy_for_LVSD(context);
            IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            IEnumerable<MedicationRequest> d_(MedicationRequest MR) {
                IEnumerable<Medication> j_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? k_(Medication M) {
                    object o_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object p_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> q_ = context.Operators.Split((string)p_, "/");
                    string r_ = context.Operators.Last<string>(q_);
                    bool? s_ = context.Operators.Equal(o_, r_);
                    CodeableConcept t_ = M?.Code;
                    CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                    CqlValueSet v_ = this.Beta_Blocker_Therapy_for_LVSD(context);
                    bool? w_ = context.Operators.ConceptInValueSet(u_, v_);
                    bool? x_ = context.Operators.And(s_, w_);
                    return x_;
                }

                IEnumerable<Medication> l_ = context.Operators.Where<Medication>(j_, k_);
                MedicationRequest m_(Medication M) => MR;
                IEnumerable<MedicationRequest> n_ = context.Operators.Select<Medication, MedicationRequest>(l_, m_);
                return n_;
            }

            IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
            IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);

            bool? g_(MedicationRequest ActiveBetaBlocker) {
                bool? y_ = AHAOverall_4_1_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, ActiveBetaBlocker);
                return y_;
            }

            IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
            bool? i_ = context.Operators.Exists<MedicationRequest>(h_);
            return i_;
        });


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-1342263068743286196L, () => {
            bool? a_ = this.Has_Beta_Blocker_Therapy_for_LVSD_Ordered(context);
            bool? b_ = this.Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD(context);
            bool? c_ = context.Operators.Or(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Has Consecutive Heart Rates Less than 50")]
    public bool? Has_Consecutive_Heart_Rates_Less_than_50(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(3630379547903955739L, () => {
            IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-heart-rate"));
            IEnumerable<Encounter> b_ = AHAOverall_4_1_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            IEnumerable<ValueTuple<Observation, Encounter>> c_ = context.Operators.CrossJoin<Observation, Encounter>(a_, b_);

            (CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)? d_(ValueTuple<Observation, Encounter> _valueTuple) {
                (CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)? l_ = (CqlTupleMetadata_FUFPMQdRaTBgLhghDWfUUBaNF, _valueTuple.Item1, _valueTuple.Item2);
                return l_;
            }

            IEnumerable<(CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?> e_ = context.Operators.Select<ValueTuple<Observation, Encounter>, (CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?>(c_, d_);

            bool? f_((CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)? tuple_fufpmqdratbglhghdwfuubanf) {
                Period m_ = tuple_fufpmqdratbglhghdwfuubanf?.ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                DataType o_ = tuple_fufpmqdratbglhghdwfuubanf?.HeartRate?.Effective;
                object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
                bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(n_, q_, default);
                Code<ObservationStatus> s_ = tuple_fufpmqdratbglhghdwfuubanf?.HeartRate?.StatusElement;
                ObservationStatus? t_ = s_?.Value;
                string u_ = context.Operators.Convert<string>(t_);
                string[] v_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? w_ = context.Operators.In<string>(u_, (IEnumerable<string>)v_);
                bool? x_ = context.Operators.And(r_, w_);
                DataType y_ = tuple_fufpmqdratbglhghdwfuubanf?.HeartRate?.Value;
                CqlQuantity z_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, y_ as Quantity);
                CqlQuantity aa_ = context.Operators.Quantity(50m, "/min");
                bool? ab_ = context.Operators.Less(z_, aa_);
                bool? ac_ = context.Operators.And(x_, ab_);
                IEnumerable<Observation> ad_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-heart-rate"));

                bool? ae_(Observation MostRecentPriorHeartRate) {
                    Period ao_ = tuple_fufpmqdratbglhghdwfuubanf?.ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> ap_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ao_);
                    DataType aq_ = MostRecentPriorHeartRate?.Effective;
                    object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                    CqlInterval<CqlDateTime> as_ = QICoreCommon_4_0_000.Instance.toInterval(context, ar_);
                    bool? at_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ap_, as_, default);
                    object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                    CqlInterval<CqlDateTime> aw_ = QICoreCommon_4_0_000.Instance.toInterval(context, av_);
                    DataType ax_ = tuple_fufpmqdratbglhghdwfuubanf?.HeartRate?.Effective;
                    object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                    CqlInterval<CqlDateTime> az_ = QICoreCommon_4_0_000.Instance.toInterval(context, ay_);
                    bool? ba_ = context.Operators.Before(aw_, az_, default);
                    bool? bb_ = context.Operators.And(at_, ba_);
                    return bb_;
                }

                IEnumerable<Observation> af_ = context.Operators.Where<Observation>(ad_, ae_);

                object ag_(Observation @this) {
                    DataType bc_ = @this?.Effective;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    CqlInterval<CqlDateTime> be_ = QICoreCommon_4_0_000.Instance.toInterval(context, bd_);
                    CqlDateTime bf_ = context.Operators.Start(be_);
                    return bf_;
                }

                IEnumerable<Observation> ah_ = context.Operators.SortBy<Observation>(af_, ag_, System.ComponentModel.ListSortDirection.Ascending);
                Observation ai_ = context.Operators.Last<Observation>(ah_);
                DataType aj_ = ai_?.Value;
                CqlQuantity ak_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, aj_ as Quantity);
                bool? am_ = context.Operators.Less(ak_, aa_);
                bool? an_ = context.Operators.And(ac_, am_);
                return an_;
            }

            IEnumerable<(CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?> g_ = context.Operators.Where<(CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?>(e_, f_);
            Observation h_((CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)? tuple_fufpmqdratbglhghdwfuubanf) => tuple_fufpmqdratbglhghdwfuubanf?.HeartRate;
            IEnumerable<Observation> i_ = context.Operators.Select<(CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?, Observation>(g_, h_);
            IEnumerable<Observation> j_ = context.Operators.Distinct<Observation>(i_);
            bool? k_ = context.Operators.Exists<Observation>(j_);
            return k_;
        });


    [CqlExpressionDefinition("Has Medical or Patient Reason for Not Ordering Beta Blocker for LVSD")]
    public bool? Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(3729703187196194264L, () => {
            CqlValueSet a_ = this.Beta_Blocker_Therapy_for_LVSD(context);
            IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));

            IEnumerable<MedicationRequest> c_(MedicationRequest NoBetaBlockerOrdered) {
                IEnumerable<Encounter> h_ = AHAOverall_4_1_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);

                bool? i_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) {
                    FhirDateTime m_ = NoBetaBlockerOrdered?.AuthoredOnElement;
                    CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
                    Period o_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                    bool? q_ = context.Operators.In<CqlDateTime>(n_, p_, "day");
                    return q_;
                }

                IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
                MedicationRequest k_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) => NoBetaBlockerOrdered;
                IEnumerable<MedicationRequest> l_ = context.Operators.Select<Encounter, MedicationRequest>(j_, k_);
                return l_;
            }

            IEnumerable<MedicationRequest> d_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(b_, c_);

            bool? e_(MedicationRequest NoBetaBlockerOrdered) {
                List<CodeableConcept> r_ = NoBetaBlockerOrdered?.ReasonCode;

                CqlConcept s_(CodeableConcept @this) {
                    CqlConcept ac_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return ac_;
                }

                IEnumerable<CqlConcept> t_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)r_, s_);
                CqlValueSet u_ = this.Medical_Reason(context);
                bool? v_ = context.Operators.ConceptsInValueSet(t_, u_);

                CqlConcept x_(CodeableConcept @this) {
                    CqlConcept ad_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return ad_;
                }

                IEnumerable<CqlConcept> y_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)r_, x_);
                CqlValueSet z_ = this.Patient_Reason(context);
                bool? aa_ = context.Operators.ConceptsInValueSet(y_, z_);
                bool? ab_ = context.Operators.Or(v_, aa_);
                return ab_;
            }

            IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
            bool? g_ = context.Operators.Exists<MedicationRequest>(f_);
            return g_;
        });


    [CqlFunctionDefinition("isVerified")]
    [CqlTag("description", "Returns true if the given condition either has no verification status or has a verification status of confirmed, unconfirmed, provisional, or differential")]
    public bool? isVerified(CqlContext context, AllergyIntolerance allergyIntolerance)
    {
        CodeableConcept a_ = allergyIntolerance?.VerificationStatus;
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        bool? c_ = context.Operators.Not((bool?)(b_ is null));
        CqlConcept e_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        CqlCode f_ = QICoreCommon_4_0_000.Instance.allergy_confirmed(context);
        CqlConcept g_ = context.Operators.ConvertCodeToConcept(f_);
        bool? h_ = context.Operators.Equivalent(e_, g_);
        CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        CqlCode k_ = QICoreCommon_4_0_000.Instance.allergy_unconfirmed(context);
        CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
        bool? m_ = context.Operators.Equivalent(j_, l_);
        bool? n_ = context.Operators.Or(h_, m_);
        bool? o_ = context.Operators.Implies(c_, n_);
        return o_;
    }


    [CqlExpressionDefinition("Has Arrhythmia Diagnosis")]
    public bool? Has_Arrhythmia_Diagnosis(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-3739507375172224545L, () => {
            CqlValueSet a_ = this.Arrhythmia(context);
            IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);

            bool? f_(object ArrhythmiaAlias) {
                bool? i_ = AHAOverall_4_1_000.Instance.overlapsHeartFailureOutpatientEncounter(context, ArrhythmiaAlias);
                bool? j_ = AHAOverall_4_1_000.Instance.isVerified(context, ArrhythmiaAlias);
                bool? k_ = context.Operators.And(i_, j_);
                return k_;
            }

            IEnumerable<object> g_ = context.Operators.Where<object>(e_, f_);
            bool? h_ = context.Operators.Exists<object>(g_);
            return h_;
        });


    [CqlExpressionDefinition("Has Hypotension Diagnosis")]
    public bool? Has_Hypotension_Diagnosis(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(4435963098547719524L, () => {
            CqlValueSet a_ = this.Hypotension(context);
            IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);

            bool? f_(object HypotensionAlias) {
                bool? i_ = AHAOverall_4_1_000.Instance.overlapsHeartFailureOutpatientEncounter(context, HypotensionAlias);
                bool? j_ = AHAOverall_4_1_000.Instance.isVerified(context, HypotensionAlias);
                bool? k_ = context.Operators.And(i_, j_);
                return k_;
            }

            IEnumerable<object> g_ = context.Operators.Where<object>(e_, f_);
            bool? h_ = context.Operators.Exists<object>(g_);
            return h_;
        });


    [CqlExpressionDefinition("Has Asthma Diagnosis")]
    public bool? Has_Asthma_Diagnosis(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(7044985707602635307L, () => {
            CqlValueSet a_ = this.Asthma(context);
            IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);

            bool? f_(object AsthmaAlias) {
                bool? i_ = AHAOverall_4_1_000.Instance.overlapsHeartFailureOutpatientEncounter(context, AsthmaAlias);
                bool? j_ = AHAOverall_4_1_000.Instance.isVerified(context, AsthmaAlias);
                bool? k_ = context.Operators.And(i_, j_);
                return k_;
            }

            IEnumerable<object> g_ = context.Operators.Where<object>(e_, f_);
            bool? h_ = context.Operators.Exists<object>(g_);
            return h_;
        });


    [CqlExpressionDefinition("Has Diagnosis of Allergy or Intolerance to Beta Blocker Therapy")]
    public bool? Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-7483912433006805992L, () => {
            CqlValueSet a_ = this.Allergy_to_Beta_Blocker_Therapy(context);
            IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
            CqlValueSet f_ = this.Intolerance_to_Beta_Blocker_Therapy(context);
            IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<object> h_ = context.Operators.Union<object>(e_ as IEnumerable<object>, g_ as IEnumerable<object>);
            IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<object> k_ = context.Operators.Union<object>(h_ as IEnumerable<object>, j_ as IEnumerable<object>);

            bool? l_(object BetaBlockerAllergyOrIntoleranceDiagnosis) {
                bool? o_ = AHAOverall_4_1_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, BetaBlockerAllergyOrIntoleranceDiagnosis);
                bool? p_ = AHAOverall_4_1_000.Instance.isVerified(context, BetaBlockerAllergyOrIntoleranceDiagnosis);
                bool? q_ = context.Operators.And(o_, p_);
                return q_;
            }

            IEnumerable<object> m_ = context.Operators.Where<object>(k_, l_);
            bool? n_ = context.Operators.Exists<object>(m_);
            return n_;
        });


    [CqlExpressionDefinition("Has Bradycardia Diagnosis")]
    public bool? Has_Bradycardia_Diagnosis(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-5143505920815233861L, () => {
            CqlValueSet a_ = this.Bradycardia(context);
            IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);

            bool? f_(object BradycardiaAlias) {
                bool? i_ = AHAOverall_4_1_000.Instance.overlapsHeartFailureOutpatientEncounter(context, BradycardiaAlias);
                bool? j_ = AHAOverall_4_1_000.Instance.isVerified(context, BradycardiaAlias);
                bool? k_ = context.Operators.And(i_, j_);
                return k_;
            }

            IEnumerable<object> g_ = context.Operators.Where<object>(e_, f_);
            bool? h_ = context.Operators.Exists<object>(g_);
            return h_;
        });


    [CqlExpressionDefinition("Has Allergy or Intolerance to Beta Blocker Therapy Ingredient")]
    public bool? Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-5160006020200830972L, () => {
            CqlValueSet a_ = this.Beta_Blocker_Therapy_Ingredient(context);
            IEnumerable<AllergyIntolerance> b_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
            CqlCode c_ = this.Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_(context);
            IEnumerable<CqlCode> d_ = context.Operators.ToList<CqlCode>(c_);
            IEnumerable<AllergyIntolerance> e_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, default, d_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
            IEnumerable<AllergyIntolerance> f_ = context.Operators.Union<AllergyIntolerance>(b_, e_);

            bool? g_(AllergyIntolerance BetaBlockerAllergyIntolerance) {
                bool? j_ = AHAOverall_4_1_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, BetaBlockerAllergyIntolerance);
                bool? k_ = this.isVerified(context, BetaBlockerAllergyIntolerance);
                bool? l_ = context.Operators.And(j_, k_);
                return l_;
            }

            IEnumerable<AllergyIntolerance> h_ = context.Operators.Where<AllergyIntolerance>(f_, g_);
            bool? i_ = context.Operators.Exists<AllergyIntolerance>(h_);
            return i_;
        });


    [CqlExpressionDefinition("Has Atrioventricular Block Diagnosis")]
    public bool? Has_Atrioventricular_Block_Diagnosis(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-4112486325081879223L, () => {
            CqlValueSet a_ = this.Atrioventricular_Block(context);
            IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);

            bool? f_(object AtrioventricularBlockAlias) {
                bool? i_ = AHAOverall_4_1_000.Instance.overlapsHeartFailureOutpatientEncounter(context, AtrioventricularBlockAlias);
                bool? j_ = AHAOverall_4_1_000.Instance.isVerified(context, AtrioventricularBlockAlias);
                bool? k_ = context.Operators.And(i_, j_);
                return k_;
            }

            IEnumerable<object> g_ = context.Operators.Where<object>(e_, f_);
            bool? h_ = context.Operators.Exists<object>(g_);
            return h_;
        });


    [CqlExpressionDefinition("Has Diagnosis of Cardiac Pacer in Situ")]
    public bool? Has_Diagnosis_of_Cardiac_Pacer_in_Situ(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-7896197255889390503L, () => {
            CqlValueSet a_ = this.Cardiac_Pacer_in_Situ(context);
            IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);

            bool? f_(object CardiacPacerDiagnosis) {
                bool? i_ = AHAOverall_4_1_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, CardiacPacerDiagnosis);
                bool? j_ = AHAOverall_4_1_000.Instance.isVerified(context, CardiacPacerDiagnosis);
                bool? k_ = context.Operators.And(i_, j_);
                return k_;
            }

            IEnumerable<object> g_ = context.Operators.Where<object>(e_, f_);
            bool? h_ = context.Operators.Exists<object>(g_);
            return h_;
        });


    [CqlExpressionDefinition("Has Cardiac Pacer Device Implanted")]
    public bool? Has_Cardiac_Pacer_Device_Implanted(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(4538725901971682005L, () => {
            CqlValueSet a_ = this.Cardiac_Pacer(context);
            IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            IEnumerable<Procedure> c_(Procedure ImplantedCardiacPacer) {
                IEnumerable<Encounter> h_ = AHAOverall_4_1_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);

                bool? i_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) {

                    object m_() {

                        bool t_() {
                            DataType x_ = ImplantedCardiacPacer?.Performed;
                            object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                            bool z_ = y_ is CqlDateTime;
                            return z_;
                        }


                        bool u_() {
                            DataType aa_ = ImplantedCardiacPacer?.Performed;
                            object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                            bool ac_ = ab_ is CqlInterval<CqlDateTime>;
                            return ac_;
                        }


                        bool v_() {
                            DataType ad_ = ImplantedCardiacPacer?.Performed;
                            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                            bool af_ = ae_ is CqlQuantity;
                            return af_;
                        }


                        bool w_() {
                            DataType ag_ = ImplantedCardiacPacer?.Performed;
                            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                            bool ai_ = ah_ is CqlInterval<CqlQuantity>;
                            return ai_;
                        }

                        if (t_())
                        {
                            DataType aj_ = ImplantedCardiacPacer?.Performed;
                            object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                            return (ak_ as CqlDateTime) as object;
                        }
                        else if (u_())
                        {
                            DataType al_ = ImplantedCardiacPacer?.Performed;
                            object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                            return (am_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (v_())
                        {
                            DataType an_ = ImplantedCardiacPacer?.Performed;
                            object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                            return (ao_ as CqlQuantity) as object;
                        }
                        else if (w_())
                        {
                            DataType ap_ = ImplantedCardiacPacer?.Performed;
                            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                            return (aq_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_());
                    CqlDateTime o_ = context.Operators.Start(n_);
                    Period p_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                    CqlDateTime r_ = context.Operators.End(q_);
                    bool? s_ = context.Operators.Before(o_, r_, default);
                    return s_;
                }

                IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
                Procedure k_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) => ImplantedCardiacPacer;
                IEnumerable<Procedure> l_ = context.Operators.Select<Encounter, Procedure>(j_, k_);
                return l_;
            }

            IEnumerable<Procedure> d_ = context.Operators.SelectMany<Procedure, Procedure>(b_, c_);

            bool? e_(Procedure ImplantedCardiacPacer) {
                Code<EventStatus> ar_ = ImplantedCardiacPacer?.StatusElement;
                EventStatus? as_ = ar_?.Value;
                string at_ = context.Operators.Convert<string>(as_);
                bool? au_ = context.Operators.Equal(at_, "completed");
                return au_;
            }

            IEnumerable<Procedure> f_ = context.Operators.Where<Procedure>(d_, e_);
            bool? g_ = context.Operators.Exists<Procedure>(f_);
            return g_;
        });


    [CqlExpressionDefinition("Atrioventricular Block without Cardiac Pacer")]
    public bool? Atrioventricular_Block_without_Cardiac_Pacer(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-2169364810011637587L, () => {
            bool? a_ = this.Has_Atrioventricular_Block_Diagnosis(context);
            bool? b_ = this.Has_Diagnosis_of_Cardiac_Pacer_in_Situ(context);
            bool? c_ = context.Operators.Not(b_);
            bool? d_ = context.Operators.And(a_, c_);
            bool? e_ = this.Has_Cardiac_Pacer_Device_Implanted(context);
            bool? f_ = context.Operators.Not(e_);
            bool? g_ = context.Operators.And(d_, f_);
            return g_;
        });


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(1031791878532453465L, () => {
            bool? a_ = this.Has_Consecutive_Heart_Rates_Less_than_50(context);
            bool? b_ = this.Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD(context);
            bool? c_ = context.Operators.Or(a_, b_);
            bool? d_ = this.Has_Arrhythmia_Diagnosis(context);
            bool? e_ = context.Operators.Or(c_, d_);
            bool? f_ = this.Has_Hypotension_Diagnosis(context);
            bool? g_ = context.Operators.Or(e_, f_);
            bool? h_ = this.Has_Asthma_Diagnosis(context);
            bool? i_ = context.Operators.Or(g_, h_);
            bool? j_ = this.Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy(context);
            bool? k_ = context.Operators.Or(i_, j_);
            bool? l_ = this.Has_Bradycardia_Diagnosis(context);
            bool? m_ = context.Operators.Or(k_, l_);
            bool? n_ = this.Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient(context);
            bool? o_ = context.Operators.Or(m_, n_);
            bool? p_ = this.Atrioventricular_Block_without_Cardiac_Pacer(context);
            bool? q_ = context.Operators.Or(o_, p_);
            return q_;
        });


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(-6906981998527120373L, () => {
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>>(5786546152402859203L, () => {
            IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(-8643694095353757601L, () => {
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlCode>(8624947786324799592L, () => {
            CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
            return a_;
        });


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS144FHIRHFBetaBlockerForLVSD_1_0_000() {}

    public static CMS144FHIRHFBetaBlockerForLVSD_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS144FHIRHFBetaBlockerForLVSD";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance, AHAOverall_4_1_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_FUFPMQdRaTBgLhghDWfUUBaNF = new(
       [typeof(Observation), typeof(Encounter)],
       ["HeartRate", "ModerateOrSevereLVSDHFOutpatientEncounter"]);

    #endregion CqlTupleMetadata Properties

}
