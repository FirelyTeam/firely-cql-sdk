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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.0.0")]
[CqlLibrary("CMS144FHIRHFBetaBlockerForLVSD", "1.0.000")]
public partial class CMS144FHIRHFBetaBlockerForLVSD_1_0_000 : ILibrary, ISingleton<CMS144FHIRHFBetaBlockerForLVSD_1_0_000>
{
    #region ValueSets (13)

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

    #region Codes (1)

    [CqlCodeDefinition("Substance with beta adrenergic receptor antagonist mechanism of action (substance)", codeId: "373254001", codeSystem: "http://snomed.info/sct")]
    public CqlCode Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_(CqlContext _) => _Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_;
    private static readonly CqlCode _Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_ = new CqlCode("373254001", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 2616853413637305416L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS144FHIRHFBetaBlockerForLVSD-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (25)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -7772502128286363363L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 38685777630265383L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        bool? a_ = AHAOverall_4_1_000.Instance.Is_Adult_With_Two_Qualifying_Outpatient_Encounters_and_One_Heart_Failure_Outpatient_Encounter_During_the_Measurement_Period(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = -3472072733239199912L;

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        // CQL 'and' (37:3-38:95): right operand skipped when left is false
        if (a_ is false)
        {
            return false;
        }
        else
        {
            IEnumerable<Encounter> b_ = AHAOverall_4_1_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? c_ = context.Operators.Exists<Encounter>(b_);
            return a_ & c_;
        }
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = -6398594374452645514L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        bool? a_ = AHAOverall_4_1_000.Instance.Has_Heart_Transplant(context);
        bool? b_;
        // CQL 'or' (41:3-42:47): right operand skipped when left is true
        if (a_ is true)
        {
            b_ = true;
        }
        else
        {
            bool? d_ = AHAOverall_4_1_000.Instance.Has_Heart_Transplant_Complications(context);
            b_ = a_ | d_;
        }
        bool? c_;
        // CQL 'or' (41:3-43:47): right operand skipped when left is true
        if (b_ is true)
        {
            c_ = true;
        }
        else
        {
            bool? e_ = AHAOverall_4_1_000.Instance.Has_Left_Ventricular_Assist_Device(context);
            c_ = b_ | e_;
        }
        // CQL 'or' (41:3-44:61): right operand skipped when left is true
        if (c_ is true)
        {
            return true;
        }
        else
        {
            bool? f_ = AHAOverall_4_1_000.Instance.Has_Left_Ventricular_Assist_Device_Complications(context);
            return c_ | f_;
        }
    }


    [CqlExpressionDefinition("Has Beta Blocker Therapy for LVSD Ordered")]
    public bool? Has_Beta_Blocker_Therapy_for_LVSD_Ordered(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Beta_Blocker_Therapy_for_LVSD_Ordered, Has_Beta_Blocker_Therapy_for_LVSD_Ordered_Compute);

    private const long _cacheIndex_Has_Beta_Blocker_Therapy_for_LVSD_Ordered = 6987738993386788375L;

    private bool? Has_Beta_Blocker_Therapy_for_LVSD_Ordered_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Beta_Blocker_Therapy_for_LVSD(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? c_(MedicationRequest BetaBlockerOrdered) {
            bool? e_ = AHAOverall_4_1_000.Instance.isOrderedDuringHeartFailureOutpatientEncounter(context, BetaBlockerOrdered);
            return e_;
        }

        bool? d_ = context.Operators.WhereAny<MedicationRequest>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Is Currently Taking Beta Blocker Therapy for LVSD")]
    public bool? Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD, Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD_Compute);

    private const long _cacheIndex_Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD = 5558459301105956202L;

    private bool? Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest> a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest MR) {
            IEnumerable<Medication> i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? j_(Medication M) {
                object l_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object m_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> n_ = context.Operators.Split((string)m_, "/");
                string o_ = context.Operators.Last<string>(n_);
                bool? p_ = context.Operators.Equal(l_, o_);
                // CQL 'and': right operand skipped when left is false
                if (p_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept q_ = M?.Code;
                    CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                    CqlValueSet s_ = this.Beta_Blocker_Therapy_for_LVSD(context);
                    bool? t_ = context.Operators.ConceptInValueSet(r_, s_);
                    return p_ & t_;
                }
            }

            bool? k_ = context.Operators.WhereAny<Medication>(i_, j_);
            return k_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Beta_Blocker_Therapy_for_LVSD(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest ActiveBetaBlocker) {
            bool? u_ = AHAOverall_4_1_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, ActiveBetaBlocker);
            return u_;
        }

        bool? h_ = context.Operators.WhereAny<MedicationRequest>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -1342263068743286196L;

    private bool? Numerator_Compute(CqlContext context)
    {
        bool? a_ = this.Has_Beta_Blocker_Therapy_for_LVSD_Ordered(context);
        // CQL 'or' (47:3-48:58): right operand skipped when left is true
        if (a_ is true)
        {
            return true;
        }
        else
        {
            bool? b_ = this.Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD(context);
            return a_ | b_;
        }
    }


    [CqlExpressionDefinition("Has Consecutive Heart Rates Less than 50")]
    public bool? Has_Consecutive_Heart_Rates_Less_than_50(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Consecutive_Heart_Rates_Less_than_50, Has_Consecutive_Heart_Rates_Less_than_50_Compute);

    private const long _cacheIndex_Has_Consecutive_Heart_Rates_Less_than_50 = 3630379547903955739L;

    private bool? Has_Consecutive_Heart_Rates_Less_than_50_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-heart-rate"));
        IEnumerable<Encounter> b_ = AHAOverall_4_1_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        IEnumerable<ValueTuple<Observation, Encounter>> c_ = context.Operators.CrossJoin<Observation, Encounter>(a_, b_);

        (CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)? d_(ValueTuple<Observation, Encounter> _valueTuple) {
            (CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)? j_ = (CqlTupleMetadata_FUFPMQdRaTBgLhghDWfUUBaNF, _valueTuple.Item1, _valueTuple.Item2);
            return j_;
        }


        bool? e_((CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)? tuple_fufpmqdratbglhghdwfuubanf) {
            Period k_ = tuple_fufpmqdratbglhghdwfuubanf?.ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
            DataType m_ = tuple_fufpmqdratbglhghdwfuubanf?.HeartRate?.Effective;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
            CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_);
            bool? p_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, o_, (string)default);
            bool? q_;
            // CQL 'and' (130:13-131:67): right operand skipped when left is false
            if (p_ is false)
            {
                q_ = false;
            }
            else
            {
                Code<ObservationStatus> s_ = tuple_fufpmqdratbglhghdwfuubanf?.HeartRate?.StatusElement;
                ObservationStatus? t_ = s_?.Value;
                string u_ = context.Operators.Convert<string>(t_);
                string[] v_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? w_ = context.Operators.In<string>(u_, (IEnumerable<string>)v_);
                q_ = p_ & w_;
            }
            bool? r_;
            // CQL 'and' (130:13-132:39): right operand skipped when left is false
            if (q_ is false)
            {
                r_ = false;
            }
            else
            {
                DataType x_ = tuple_fufpmqdratbglhghdwfuubanf?.HeartRate?.Value;
                CqlQuantity y_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, x_ as Quantity);
                CqlQuantity z_ = context.Operators.Quantity(50m, "/min");
                bool? aa_ = context.Operators.Less(y_, z_);
                r_ = q_ & aa_;
            }
            // CQL 'and' (130:7-133:44): right operand skipped when left is false
            if (r_ is false)
            {
                return false;
            }
            else
            {
                IEnumerable<Observation> ab_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-heart-rate"));

                bool? ac_(Observation MostRecentPriorHeartRate) {
                    Period al_ = tuple_fufpmqdratbglhghdwfuubanf?.ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> am_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, al_);
                    DataType an_ = MostRecentPriorHeartRate?.Effective;
                    object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                    CqlInterval<CqlDateTime> ap_ = QICoreCommon_4_0_000.Instance.toInterval(context, ao_);
                    bool? aq_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(am_, ap_, (string)default);
                    // CQL 'and' (126:11-127:103): right operand skipped when left is false
                    if (aq_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        DataType ar_ = tuple_fufpmqdratbglhghdwfuubanf?.HeartRate?.Effective;
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        CqlInterval<CqlDateTime> at_ = QICoreCommon_4_0_000.Instance.toInterval(context, as_);
                        bool? au_ = context.Operators.Before(ap_, at_, (string)default);
                        return aq_ & au_;
                    }
                }

                IEnumerable<Observation> ad_ = context.Operators.Where<Observation>(ab_, ac_);

                object ae_(Observation @this) {
                    DataType av_ = @this?.Effective;
                    object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                    CqlInterval<CqlDateTime> ax_ = QICoreCommon_4_0_000.Instance.toInterval(context, aw_);
                    CqlDateTime ay_ = context.Operators.Start(ax_);
                    return ay_;
                }

                IEnumerable<Observation> af_ = context.Operators.SortBy<Observation>(ad_, ae_, System.ComponentModel.ListSortDirection.Ascending);
                Observation ag_ = context.Operators.Last<Observation>(af_);
                DataType ah_ = ag_?.Value;
                CqlQuantity ai_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ah_ as Quantity);
                CqlQuantity aj_ = context.Operators.Quantity(50m, "/min");
                bool? ak_ = context.Operators.Less(ai_, aj_);
                return r_ & ak_;
            }
        }

        IEnumerable<(CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?> f_ = context.Operators.SelectWhere<ValueTuple<Observation, Encounter>, (CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?>(c_, d_, e_);
        Observation g_((CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)? tuple_fufpmqdratbglhghdwfuubanf) => tuple_fufpmqdratbglhghdwfuubanf?.HeartRate;
        IEnumerable<Observation> h_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?, Observation>(f_, g_);
        bool? i_ = context.Operators.Exists<Observation>(h_);
        return i_;
    }


    [CqlExpressionDefinition("Has Medical or Patient Reason for Not Ordering Beta Blocker for LVSD")]
    public bool? Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD, Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD_Compute);

    private const long _cacheIndex_Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD = 3729703187196194264L;

    private bool? Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Beta_Blocker_Therapy_for_LVSD(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));

        bool? c_(MedicationRequest NoBetaBlockerOrdered) {
            IEnumerable<Encounter> g_ = AHAOverall_4_1_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);

            bool? h_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) {
                FhirDateTime j_ = NoBetaBlockerOrdered?.AuthoredOnElement;
                CqlDateTime k_ = context.Operators.Convert<CqlDateTime>(j_);
                Period l_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                bool? n_ = context.Operators.In<CqlDateTime>(k_, m_, "day");
                return n_;
            }

            bool? i_ = context.Operators.WhereAny<Encounter>(g_, h_);
            return i_;
        }

        IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(b_, c_);

        bool? e_(MedicationRequest NoBetaBlockerOrdered) {
            List<CodeableConcept> o_ = NoBetaBlockerOrdered?.ReasonCode;

            CqlConcept p_(CodeableConcept @this) {
                CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return t_;
            }

            IEnumerable<CqlConcept> q_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)o_, p_);
            CqlValueSet r_ = this.Medical_Reason(context);
            bool? s_ = context.Operators.ConceptsInValueSet(q_, r_);
            // CQL 'or' (174:7-176:7): right operand skipped when left is true
            if (s_ is true)
            {
                return true;
            }
            else
            {

                CqlConcept u_(CodeableConcept @this) {
                    CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return y_;
                }

                IEnumerable<CqlConcept> v_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)o_, u_);
                CqlValueSet w_ = this.Patient_Reason(context);
                bool? x_ = context.Operators.ConceptsInValueSet(v_, w_);
                return s_ | x_;
            }
        }

        bool? f_ = context.Operators.WhereAny<MedicationRequest>(d_, e_);
        return f_;
    }


    [CqlFunctionDefinition("isVerified")]
    [CqlTag("description", "Returns true if the given condition either has no verification status or has a verification status of confirmed, unconfirmed, provisional, or differential")]
    public bool? isVerified(CqlContext context, AllergyIntolerance allergyIntolerance)
    {
        CodeableConcept a_ = allergyIntolerance?.VerificationStatus;
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        bool? c_ = !((bool?)(b_ is null));
        // CQL 'implies' (185:3-187:3): right operand skipped when left is false
        if (c_ is false)
        {
            return true;
        }
        else
        {
            CqlCode d_ = QICoreCommon_4_0_000.Instance.allergy_confirmed(context);
            CqlConcept e_ = context.Operators.ConvertCodeToConcept(d_);
            bool? f_ = context.Operators.Equivalent(b_, e_);
            bool? g_;
            // CQL 'or' (185:61-187:3): right operand skipped when left is true
            if (f_ is true)
            {
                g_ = true;
            }
            else
            {
                CqlCode h_ = QICoreCommon_4_0_000.Instance.allergy_unconfirmed(context);
                CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
                bool? j_ = context.Operators.Equivalent(b_, i_);
                g_ = f_ | j_;
            }
            return /* CQL 'implies' (185:3-187:3) */ !c_ | g_;
        }
    }


    [CqlExpressionDefinition("Has Arrhythmia Diagnosis")]
    public bool? Has_Arrhythmia_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Arrhythmia_Diagnosis, Has_Arrhythmia_Diagnosis_Compute);

    private const long _cacheIndex_Has_Arrhythmia_Diagnosis = -3739507375172224545L;

    private bool? Has_Arrhythmia_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Arrhythmia(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);

        bool? e_(Condition ArrhythmiaAlias) {
            bool? g_ = AHAOverall_4_1_000.Instance.overlapsHeartFailureOutpatientEncounter(context, ArrhythmiaAlias);
            // CQL 'and' (147:7-148:42): right operand skipped when left is false
            if (g_ is false)
            {
                return false;
            }
            else
            {
                bool? h_ = AHAOverall_4_1_000.Instance.isVerified(context, ArrhythmiaAlias);
                return g_ & h_;
            }
        }

        bool? f_ = context.Operators.WhereAny<Condition>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Has Hypotension Diagnosis")]
    public bool? Has_Hypotension_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Hypotension_Diagnosis, Has_Hypotension_Diagnosis_Compute);

    private const long _cacheIndex_Has_Hypotension_Diagnosis = 4435963098547719524L;

    private bool? Has_Hypotension_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Hypotension(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);

        bool? e_(Condition HypotensionAlias) {
            bool? g_ = AHAOverall_4_1_000.Instance.overlapsHeartFailureOutpatientEncounter(context, HypotensionAlias);
            // CQL 'and' (93:7-94:43): right operand skipped when left is false
            if (g_ is false)
            {
                return false;
            }
            else
            {
                bool? h_ = AHAOverall_4_1_000.Instance.isVerified(context, HypotensionAlias);
                return g_ & h_;
            }
        }

        bool? f_ = context.Operators.WhereAny<Condition>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Has Asthma Diagnosis")]
    public bool? Has_Asthma_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Asthma_Diagnosis, Has_Asthma_Diagnosis_Compute);

    private const long _cacheIndex_Has_Asthma_Diagnosis = 7044985707602635307L;

    private bool? Has_Asthma_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Asthma(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);

        bool? e_(Condition AsthmaAlias) {
            bool? g_ = AHAOverall_4_1_000.Instance.overlapsHeartFailureOutpatientEncounter(context, AsthmaAlias);
            // CQL 'and' (154:7-155:38): right operand skipped when left is false
            if (g_ is false)
            {
                return false;
            }
            else
            {
                bool? h_ = AHAOverall_4_1_000.Instance.isVerified(context, AsthmaAlias);
                return g_ & h_;
            }
        }

        bool? f_ = context.Operators.WhereAny<Condition>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Has Diagnosis of Allergy or Intolerance to Beta Blocker Therapy")]
    public bool? Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy, Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Compute);

    private const long _cacheIndex_Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy = -7483912433006805992L;

    private bool? Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Allergy_to_Beta_Blocker_Therapy(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);
        CqlValueSet e_ = this.Intolerance_to_Beta_Blocker_Therapy(context);
        IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> g_ = context.Operators.Union<Condition>(d_ as IEnumerable<Condition>, f_ as IEnumerable<Condition>);
        IEnumerable<Condition> h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> i_ = context.Operators.Union<Condition>(g_ as IEnumerable<Condition>, h_ as IEnumerable<Condition>);

        bool? j_(Condition BetaBlockerAllergyOrIntoleranceDiagnosis) {
            bool? l_ = AHAOverall_4_1_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, BetaBlockerAllergyOrIntoleranceDiagnosis);
            // CQL 'and' (110:7-111:67): right operand skipped when left is false
            if (l_ is false)
            {
                return false;
            }
            else
            {
                bool? m_ = AHAOverall_4_1_000.Instance.isVerified(context, BetaBlockerAllergyOrIntoleranceDiagnosis);
                return l_ & m_;
            }
        }

        bool? k_ = context.Operators.WhereAny<Condition>(i_, j_);
        return k_;
    }


    [CqlExpressionDefinition("Has Bradycardia Diagnosis")]
    public bool? Has_Bradycardia_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Bradycardia_Diagnosis, Has_Bradycardia_Diagnosis_Compute);

    private const long _cacheIndex_Has_Bradycardia_Diagnosis = -5143505920815233861L;

    private bool? Has_Bradycardia_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Bradycardia(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);

        bool? e_(Condition BradycardiaAlias) {
            bool? g_ = AHAOverall_4_1_000.Instance.overlapsHeartFailureOutpatientEncounter(context, BradycardiaAlias);
            // CQL 'and' (117:7-118:43): right operand skipped when left is false
            if (g_ is false)
            {
                return false;
            }
            else
            {
                bool? h_ = AHAOverall_4_1_000.Instance.isVerified(context, BradycardiaAlias);
                return g_ & h_;
            }
        }

        bool? f_ = context.Operators.WhereAny<Condition>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Has Allergy or Intolerance to Beta Blocker Therapy Ingredient")]
    public bool? Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient, Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient_Compute);

    private const long _cacheIndex_Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient = -5160006020200830972L;

    private bool? Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Beta_Blocker_Therapy_Ingredient(context);
        IEnumerable<AllergyIntolerance> b_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        CqlCode c_ = this.Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_(context);
        IEnumerable<CqlCode> d_ = context.Operators.ToList<CqlCode>(c_);
        IEnumerable<AllergyIntolerance> e_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, default, d_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        IEnumerable<AllergyIntolerance> f_ = context.Operators.Union<AllergyIntolerance>(b_, e_);

        bool? g_(AllergyIntolerance BetaBlockerAllergyIntolerance) {
            bool? i_ = AHAOverall_4_1_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, BetaBlockerAllergyIntolerance);
            // CQL 'and' (140:7-141:56): right operand skipped when left is false
            if (i_ is false)
            {
                return false;
            }
            else
            {
                bool? j_ = this.isVerified(context, BetaBlockerAllergyIntolerance);
                return i_ & j_;
            }
        }

        bool? h_ = context.Operators.WhereAny<AllergyIntolerance>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Has Atrioventricular Block Diagnosis")]
    public bool? Has_Atrioventricular_Block_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Atrioventricular_Block_Diagnosis, Has_Atrioventricular_Block_Diagnosis_Compute);

    private const long _cacheIndex_Has_Atrioventricular_Block_Diagnosis = -4112486325081879223L;

    private bool? Has_Atrioventricular_Block_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Atrioventricular_Block(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);

        bool? e_(Condition AtrioventricularBlockAlias) {
            bool? g_ = AHAOverall_4_1_000.Instance.overlapsHeartFailureOutpatientEncounter(context, AtrioventricularBlockAlias);
            // CQL 'and' (161:7-162:53): right operand skipped when left is false
            if (g_ is false)
            {
                return false;
            }
            else
            {
                bool? h_ = AHAOverall_4_1_000.Instance.isVerified(context, AtrioventricularBlockAlias);
                return g_ & h_;
            }
        }

        bool? f_ = context.Operators.WhereAny<Condition>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Has Diagnosis of Cardiac Pacer in Situ")]
    public bool? Has_Diagnosis_of_Cardiac_Pacer_in_Situ(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Diagnosis_of_Cardiac_Pacer_in_Situ, Has_Diagnosis_of_Cardiac_Pacer_in_Situ_Compute);

    private const long _cacheIndex_Has_Diagnosis_of_Cardiac_Pacer_in_Situ = -7896197255889390503L;

    private bool? Has_Diagnosis_of_Cardiac_Pacer_in_Situ_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Cardiac_Pacer_in_Situ(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);

        bool? e_(Condition CardiacPacerDiagnosis) {
            bool? g_ = AHAOverall_4_1_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, CardiacPacerDiagnosis);
            // CQL 'and' (100:7-101:48): right operand skipped when left is false
            if (g_ is false)
            {
                return false;
            }
            else
            {
                bool? h_ = AHAOverall_4_1_000.Instance.isVerified(context, CardiacPacerDiagnosis);
                return g_ & h_;
            }
        }

        bool? f_ = context.Operators.WhereAny<Condition>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Has Cardiac Pacer Device Implanted")]
    public bool? Has_Cardiac_Pacer_Device_Implanted(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Cardiac_Pacer_Device_Implanted, Has_Cardiac_Pacer_Device_Implanted_Compute);

    private const long _cacheIndex_Has_Cardiac_Pacer_Device_Implanted = 4538725901971682005L;

    private bool? Has_Cardiac_Pacer_Device_Implanted_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Cardiac_Pacer(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? c_(Procedure ImplantedCardiacPacer) {
            IEnumerable<Encounter> g_ = AHAOverall_4_1_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);

            bool? h_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) {
                object j_;
                DataType q_ = ImplantedCardiacPacer?.Performed;
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                bool s_ = r_ is CqlDateTime;
                if (s_)
                {
                    DataType t_ = ImplantedCardiacPacer?.Performed;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    j_ = u_ as CqlDateTime;
                }
                else
                {
                    DataType v_ = ImplantedCardiacPacer?.Performed;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlQuantity;
                    if (x_)
                    {
                        DataType y_ = ImplantedCardiacPacer?.Performed;
                        object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                        j_ = z_ as CqlQuantity;
                    }
                    else
                    {
                        DataType aa_ = ImplantedCardiacPacer?.Performed;
                        object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        bool ac_ = ab_ is CqlInterval<CqlDateTime>;
                        if (ac_)
                        {
                            DataType ad_ = ImplantedCardiacPacer?.Performed;
                            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                            j_ = ae_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType af_ = ImplantedCardiacPacer?.Performed;
                            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                            bool ah_ = ag_ is CqlInterval<CqlQuantity>;
                            if (ah_)
                            {
                                DataType ai_ = ImplantedCardiacPacer?.Performed;
                                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                                j_ = aj_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                j_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_);
                CqlDateTime l_ = context.Operators.Start(k_);
                Period m_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                CqlDateTime o_ = context.Operators.End(n_);
                bool? p_ = context.Operators.Before(l_, o_, (string)default);
                return p_;
            }

            bool? i_ = context.Operators.WhereAny<Encounter>(g_, h_);
            return i_;
        }

        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);

        bool? e_(Procedure ImplantedCardiacPacer) {
            Code<EventStatus> ak_ = ImplantedCardiacPacer?.StatusElement;
            EventStatus? al_ = ak_?.Value;
            string am_ = context.Operators.Convert<string>(al_);
            bool? an_ = context.Operators.Equal(am_, "completed");
            return an_;
        }

        bool? f_ = context.Operators.WhereAny<Procedure>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Atrioventricular Block without Cardiac Pacer")]
    public bool? Atrioventricular_Block_without_Cardiac_Pacer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Atrioventricular_Block_without_Cardiac_Pacer, Atrioventricular_Block_without_Cardiac_Pacer_Compute);

    private const long _cacheIndex_Atrioventricular_Block_without_Cardiac_Pacer = -2169364810011637587L;

    private bool? Atrioventricular_Block_without_Cardiac_Pacer_Compute(CqlContext context)
    {
        bool? a_ = this.Has_Atrioventricular_Block_Diagnosis(context);
        bool? b_;
        // CQL 'and' (74:3-75:52): right operand skipped when left is false
        if (a_ is false)
        {
            b_ = false;
        }
        else
        {
            bool? c_ = this.Has_Diagnosis_of_Cardiac_Pacer_in_Situ(context);
            b_ = a_ & !c_;
        }
        // CQL 'and' (74:3-76:48): right operand skipped when left is false
        if (b_ is false)
        {
            return false;
        }
        else
        {
            bool? d_ = this.Has_Cardiac_Pacer_Device_Implanted(context);
            return b_ & !d_;
        }
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exceptions, Denominator_Exceptions_Compute);

    private const long _cacheIndex_Denominator_Exceptions = 1031791878532453465L;

    private bool? Denominator_Exceptions_Compute(CqlContext context)
    {
        bool? a_ = this.Has_Consecutive_Heart_Rates_Less_than_50(context);
        bool? b_;
        // CQL 'or' (51:3-52:77): right operand skipped when left is true
        if (a_ is true)
        {
            b_ = true;
        }
        else
        {
            bool? i_ = this.Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD(context);
            b_ = a_ | i_;
        }
        bool? c_;
        // CQL 'or' (51:3-53:33): right operand skipped when left is true
        if (b_ is true)
        {
            c_ = true;
        }
        else
        {
            bool? j_ = this.Has_Arrhythmia_Diagnosis(context);
            c_ = b_ | j_;
        }
        bool? d_;
        // CQL 'or' (51:3-54:34): right operand skipped when left is true
        if (c_ is true)
        {
            d_ = true;
        }
        else
        {
            bool? k_ = this.Has_Hypotension_Diagnosis(context);
            d_ = c_ | k_;
        }
        bool? e_;
        // CQL 'or' (51:3-55:29): right operand skipped when left is true
        if (d_ is true)
        {
            e_ = true;
        }
        else
        {
            bool? l_ = this.Has_Asthma_Diagnosis(context);
            e_ = d_ | l_;
        }
        bool? f_;
        // CQL 'or' (51:3-56:72): right operand skipped when left is true
        if (e_ is true)
        {
            f_ = true;
        }
        else
        {
            bool? m_ = this.Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy(context);
            f_ = e_ | m_;
        }
        bool? g_;
        // CQL 'or' (51:3-57:34): right operand skipped when left is true
        if (f_ is true)
        {
            g_ = true;
        }
        else
        {
            bool? n_ = this.Has_Bradycardia_Diagnosis(context);
            g_ = f_ | n_;
        }
        bool? h_;
        // CQL 'or' (51:3-58:70): right operand skipped when left is true
        if (g_ is true)
        {
            h_ = true;
        }
        else
        {
            bool? o_ = this.Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient(context);
            h_ = g_ | o_;
        }
        // CQL 'or' (51:3-59:53): right operand skipped when left is true
        if (h_ is true)
        {
            return true;
        }
        else
        {
            bool? p_ = this.Atrioventricular_Block_without_Cardiac_Pacer(context);
            return h_ | p_;
        }
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -6906981998527120373L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 5786546152402859203L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -8643694095353757601L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 8624947786324799592L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


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
