#nullable enable

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
[CqlLibrary("CMS506FHIRSafeUseofOpioids", "1.0.000")]
public partial class CMS506FHIRSafeUseofOpioids_1_0_000 : ILibrary, ISingleton<CMS506FHIRSafeUseofOpioids_1_0_000>
{
    #region ValueSets (12)

    [CqlValueSetDefinition("Cancer Related Pain", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.180", valueSetVersion: null)]
    public CqlValueSet Cancer_Related_Pain(CqlContext _) => _Cancer_Related_Pain;
    private static readonly CqlValueSet _Cancer_Related_Pain = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.180", null);

    [CqlValueSetDefinition("Discharge To Acute Care Facility", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", valueSetVersion: null)]
    public CqlValueSet Discharge_To_Acute_Care_Facility(CqlContext _) => _Discharge_To_Acute_Care_Facility;
    private static readonly CqlValueSet _Discharge_To_Acute_Care_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", null);

    [CqlValueSetDefinition("Hospice Care Referral or Admission", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365", valueSetVersion: null)]
    public CqlValueSet Hospice_Care_Referral_or_Admission(CqlContext _) => _Hospice_Care_Referral_or_Admission;
    private static readonly CqlValueSet _Hospice_Care_Referral_or_Admission = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365", null);

    [CqlValueSetDefinition("Left Against Medical Advice", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", valueSetVersion: null)]
    public CqlValueSet Left_Against_Medical_Advice(CqlContext _) => _Left_Against_Medical_Advice;
    private static readonly CqlValueSet _Left_Against_Medical_Advice = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", null);

    [CqlValueSetDefinition("Medications for Opioid Use Disorder (MOUD)", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.269", valueSetVersion: null)]
    public CqlValueSet Medications_for_Opioid_Use_Disorder__MOUD_(CqlContext _) => _Medications_for_Opioid_Use_Disorder__MOUD_;
    private static readonly CqlValueSet _Medications_for_Opioid_Use_Disorder__MOUD_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.269", null);

    [CqlValueSetDefinition("Opioid Medication Assisted Treatment (MAT)", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.177", valueSetVersion: null)]
    public CqlValueSet Opioid_Medication_Assisted_Treatment__MAT_(CqlContext _) => _Opioid_Medication_Assisted_Treatment__MAT_;
    private static readonly CqlValueSet _Opioid_Medication_Assisted_Treatment__MAT_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.177", null);

    [CqlValueSetDefinition("Opioid Use Disorder", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.171", valueSetVersion: null)]
    public CqlValueSet Opioid_Use_Disorder(CqlContext _) => _Opioid_Use_Disorder;
    private static readonly CqlValueSet _Opioid_Use_Disorder = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.171", null);

    [CqlValueSetDefinition("Palliative or Hospice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579", valueSetVersion: null)]
    public CqlValueSet Palliative_or_Hospice_Care(CqlContext _) => _Palliative_or_Hospice_Care;
    private static readonly CqlValueSet _Palliative_or_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579", null);

    [CqlValueSetDefinition("Patient Expired", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", valueSetVersion: null)]
    public CqlValueSet Patient_Expired(CqlContext _) => _Patient_Expired;
    private static readonly CqlValueSet _Patient_Expired = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);

    [CqlValueSetDefinition("Schedule II, III and IV Opioid Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.241", valueSetVersion: null)]
    public CqlValueSet Schedule_II__III_and_IV_Opioid_Medications(CqlContext _) => _Schedule_II__III_and_IV_Opioid_Medications;
    private static readonly CqlValueSet _Schedule_II__III_and_IV_Opioid_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.241", null);

    [CqlValueSetDefinition("Schedule IV Benzodiazepines", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1125.1", valueSetVersion: null)]
    public CqlValueSet Schedule_IV_Benzodiazepines(CqlContext _) => _Schedule_IV_Benzodiazepines;
    private static readonly CqlValueSet _Schedule_IV_Benzodiazepines = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1125.1", null);

    [CqlValueSetDefinition("Sickle Cell Disease with and without Crisis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.175", valueSetVersion: null)]
    public CqlValueSet Sickle_Cell_Disease_with_and_without_Crisis(CqlContext _) => _Sickle_Cell_Disease_with_and_without_Crisis;
    private static readonly CqlValueSet _Sickle_Cell_Disease_with_and_without_Crisis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.175", null);

    #endregion ValueSets

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime?>? Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -6711178551512193567L;

    private CqlInterval<CqlDateTime?>? Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime? a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime? b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime?>? c_ = context.Operators.Interval(a_, b_, true, false);
        object? d_ = context.ResolveParameter("CMS506FHIRSafeUseofOpioids-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime?>?)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (18)

    [CqlExpressionDefinition("Patient")]
    public Patient? Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 8112107951287448751L;

    private Patient? Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient?>? a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient? b_ = context.Operators.SingletonFrom<Patient?>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Inpatient Encounter With Age Greater Than Or Equal To 18")]
    public IEnumerable<Encounter?>? Inpatient_Encounter_With_Age_Greater_Than_Or_Equal_To_18(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Inpatient_Encounter_With_Age_Greater_Than_Or_Equal_To_18, Inpatient_Encounter_With_Age_Greater_Than_Or_Equal_To_18_Compute);

    private const long _cacheIndex_Inpatient_Encounter_With_Age_Greater_Than_Or_Equal_To_18 = -1650556549303795711L;

    private IEnumerable<Encounter?>? Inpatient_Encounter_With_Age_Greater_Than_Or_Equal_To_18_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = CQMCommon_4_1_000.Instance.Inpatient_Encounter(context);

        bool? b_(Encounter? InpatientHospitalEncounter) {
            Patient? d_ = this.Patient(context);
            Date? e_ = d_?.BirthDateElement;
            string? f_ = e_?.Value;
            CqlDate? g_ = context.Operators.ConvertStringToDate(f_);
            Period? h_ = InpatientHospitalEncounter?.Period;
            CqlInterval<CqlDateTime?>? i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
            CqlDateTime? j_ = context.Operators.Start(i_);
            CqlDate? k_ = context.Operators.DateFrom(j_);
            int? l_ = context.Operators.CalculateAgeAt(g_, k_, "year");
            bool? m_ = context.Operators.GreaterOrEqual(l_, 18);
            return m_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Opioid At Discharge")]
    public IEnumerable<MedicationRequest?>? Opioid_At_Discharge(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Opioid_At_Discharge, Opioid_At_Discharge_Compute);

    private const long _cacheIndex_Opioid_At_Discharge = 5633346317000929987L;

    private IEnumerable<MedicationRequest?>? Opioid_At_Discharge_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest?>? a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest? MR) {
            IEnumerable<Medication?>? i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? j_(Medication? M) {
                object? l_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? m_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? n_ = context.Operators.Split(((string?)m_)!, "/");
                string? o_ = context.Operators.Last<string?>(n_!);
                bool? p_ = context.Operators.Equal(l_, o_);
                CodeableConcept? q_ = M?.Code;
                CqlConcept? r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                CqlValueSet? s_ = this.Schedule_II__III_and_IV_Opioid_Medications(context);
                bool? t_ = context.Operators.ConceptInValueSet(r_, s_);
                bool? u_ = context.Operators.And(p_, t_);
                return u_;
            }

            bool? k_ = context.Operators.WhereAny<Medication?>(i_, j_);
            return k_;
        }

        IEnumerable<MedicationRequest?>? c_ = context.Operators.Where<MedicationRequest?>(a_, b_);
        CqlValueSet? d_ = this.Schedule_II__III_and_IV_Opioid_Medications(context);
        IEnumerable<MedicationRequest?>? e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? f_ = context.Operators.Union<MedicationRequest?>(c_, e_);

        bool? g_(MedicationRequest? OpioidMedications) {
            bool? v_ = QICoreCommon_4_0_000.Instance.isCommunity(context, OpioidMedications as MedicationRequest);
            bool? w_ = QICoreCommon_4_0_000.Instance.isDischarge(context, OpioidMedications as MedicationRequest);
            bool? x_ = context.Operators.Or(v_, w_);
            Code<MedicationRequest.MedicationrequestStatus>? y_ = OpioidMedications?.StatusElement;
            MedicationRequest.MedicationrequestStatus? z_ = y_?.Value;
            string? aa_ = context.Operators.Convert<string?>(z_);
            string?[]? ab_ = [
                "active",
                "completed",
            ];
            bool? ac_ = context.Operators.In<string?>(aa_, (IEnumerable<string?>?)ab_);
            bool? ad_ = context.Operators.And(x_, ac_);
            Code<MedicationRequest.MedicationRequestIntent>? ae_ = OpioidMedications?.IntentElement;
            MedicationRequest.MedicationRequestIntent? af_ = ae_?.Value;
            string? ag_ = context.Operators.Convert<string?>(af_);
            string?[]? ah_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? ai_ = context.Operators.In<string?>(ag_, (IEnumerable<string?>?)ah_);
            bool? aj_ = context.Operators.And(ad_, ai_);
            return aj_;
        }

        IEnumerable<MedicationRequest?>? h_ = context.Operators.Where<MedicationRequest?>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Benzodiazepine At Discharge")]
    public IEnumerable<MedicationRequest?>? Benzodiazepine_At_Discharge(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Benzodiazepine_At_Discharge, Benzodiazepine_At_Discharge_Compute);

    private const long _cacheIndex_Benzodiazepine_At_Discharge = -7244176487788219701L;

    private IEnumerable<MedicationRequest?>? Benzodiazepine_At_Discharge_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest?>? a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest? MR) {
            IEnumerable<Medication?>? i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? j_(Medication? M) {
                object? l_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? m_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? n_ = context.Operators.Split(((string?)m_)!, "/");
                string? o_ = context.Operators.Last<string?>(n_!);
                bool? p_ = context.Operators.Equal(l_, o_);
                CodeableConcept? q_ = M?.Code;
                CqlConcept? r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                CqlValueSet? s_ = this.Schedule_IV_Benzodiazepines(context);
                bool? t_ = context.Operators.ConceptInValueSet(r_, s_);
                bool? u_ = context.Operators.And(p_, t_);
                return u_;
            }

            bool? k_ = context.Operators.WhereAny<Medication?>(i_, j_);
            return k_;
        }

        IEnumerable<MedicationRequest?>? c_ = context.Operators.Where<MedicationRequest?>(a_, b_);
        CqlValueSet? d_ = this.Schedule_IV_Benzodiazepines(context);
        IEnumerable<MedicationRequest?>? e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? f_ = context.Operators.Union<MedicationRequest?>(c_, e_);

        bool? g_(MedicationRequest? BenzoMedications) {
            bool? v_ = QICoreCommon_4_0_000.Instance.isCommunity(context, BenzoMedications as MedicationRequest);
            bool? w_ = QICoreCommon_4_0_000.Instance.isDischarge(context, BenzoMedications as MedicationRequest);
            bool? x_ = context.Operators.Or(v_, w_);
            Code<MedicationRequest.MedicationrequestStatus>? y_ = BenzoMedications?.StatusElement;
            MedicationRequest.MedicationrequestStatus? z_ = y_?.Value;
            string? aa_ = context.Operators.Convert<string?>(z_);
            string?[]? ab_ = [
                "active",
                "completed",
            ];
            bool? ac_ = context.Operators.In<string?>(aa_, (IEnumerable<string?>?)ab_);
            bool? ad_ = context.Operators.And(x_, ac_);
            Code<MedicationRequest.MedicationRequestIntent>? ae_ = BenzoMedications?.IntentElement;
            MedicationRequest.MedicationRequestIntent? af_ = ae_?.Value;
            string? ag_ = context.Operators.Convert<string?>(af_);
            string?[]? ah_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? ai_ = context.Operators.In<string?>(ag_, (IEnumerable<string?>?)ah_);
            bool? aj_ = context.Operators.And(ad_, ai_);
            return aj_;
        }

        IEnumerable<MedicationRequest?>? h_ = context.Operators.Where<MedicationRequest?>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Inpatient Encounters With An Opioid Or Benzodiazepine At Discharge")]
    [CqlTag("description", "Captures encounters of patients with an opioid and/or benzodiazepine at discharge.")]
    public IEnumerable<Encounter?>? Inpatient_Encounters_With_An_Opioid_Or_Benzodiazepine_At_Discharge(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Inpatient_Encounters_With_An_Opioid_Or_Benzodiazepine_At_Discharge, Inpatient_Encounters_With_An_Opioid_Or_Benzodiazepine_At_Discharge_Compute);

    private const long _cacheIndex_Inpatient_Encounters_With_An_Opioid_Or_Benzodiazepine_At_Discharge = -1484108012641628654L;

    private IEnumerable<Encounter?>? Inpatient_Encounters_With_An_Opioid_Or_Benzodiazepine_At_Discharge_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Inpatient_Encounter_With_Age_Greater_Than_Or_Equal_To_18(context);

        bool? b_(Encounter? InpatientEncounter) {
            IEnumerable<MedicationRequest?>? d_ = this.Opioid_At_Discharge(context);
            IEnumerable<MedicationRequest?>? e_ = this.Benzodiazepine_At_Discharge(context);
            IEnumerable<MedicationRequest?>? f_ = context.Operators.Union<MedicationRequest?>(d_, e_);

            bool? g_(MedicationRequest? OpioidOrBenzodiazepineAtDischarge) {
                FhirDateTime? i_ = OpioidOrBenzodiazepineAtDischarge?.AuthoredOnElement;
                CqlDateTime? j_ = context.Operators.Convert<CqlDateTime?>(i_);
                Period? k_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime?>? l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                bool? m_ = context.Operators.In<CqlDateTime?>(j_, l_, "day");
                return m_;
            }

            bool? h_ = context.Operators.WhereAny<MedicationRequest?>(f_, g_);
            return h_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter?>? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -8403253536875342235L;

    private IEnumerable<Encounter?>? Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Inpatient_Encounters_With_An_Opioid_Or_Benzodiazepine_At_Discharge(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter?>? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 8706893806779564920L;

    private IEnumerable<Encounter?>? Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Numerator")]
    [CqlTag("description", "Encounters of patients prescribed two or more opioids or an opioid and benzodiazepine at discharge.")]
    public IEnumerable<Encounter?>? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -7195865355092763235L;

    private IEnumerable<Encounter?>? Numerator_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Denominator(context);

        bool? b_(Encounter? InpatientEncounter) {
            IEnumerable<MedicationRequest?>? d_ = this.Opioid_At_Discharge(context);

            bool? e_(MedicationRequest? OpioidMedications) {
                FhirDateTime? n_ = OpioidMedications?.AuthoredOnElement;
                CqlDateTime? o_ = context.Operators.Convert<CqlDateTime?>(n_);
                Period? p_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime?>? q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                bool? r_ = context.Operators.In<CqlDateTime?>(o_, q_, "day");
                return r_;
            }


            object f_(MedicationRequest? OpioidMedications) {
                DataType? s_ = OpioidMedications?.Medication;
                object? t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                return t_!;
            }

            IEnumerable<object?>? g_ = context.Operators.WhereSelect<MedicationRequest?, object?>(d_, e_, f_);
            IEnumerable<object?>? h_ = context.Operators.Distinct<object?>(g_!);
            int? i_ = context.Operators.Count<object?>(h_);
            bool? j_ = context.Operators.GreaterOrEqual(i_, 2);

            bool? k_(MedicationRequest? OpioidDischargeMedications) {
                FhirDateTime? u_ = OpioidDischargeMedications?.AuthoredOnElement;
                CqlDateTime? v_ = context.Operators.Convert<CqlDateTime?>(u_);
                Period? w_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime?>? x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, w_);
                bool? y_ = context.Operators.In<CqlDateTime?>(v_, x_, "day");
                IEnumerable<MedicationRequest?>? z_ = this.Benzodiazepine_At_Discharge(context);

                bool? aa_(MedicationRequest? BenzodiazepineDischargeMedication) {
                    FhirDateTime? ad_ = BenzodiazepineDischargeMedication?.AuthoredOnElement;
                    CqlDateTime? ae_ = context.Operators.Convert<CqlDateTime?>(ad_);
                    Period? af_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime?>? ag_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, af_);
                    bool? ah_ = context.Operators.In<CqlDateTime?>(ae_, ag_, "day");
                    return ah_;
                }

                bool? ab_ = context.Operators.WhereAny<MedicationRequest?>(z_, aa_);
                bool? ac_ = context.Operators.And(y_, ab_);
                return ac_;
            }

            bool? l_ = context.Operators.WhereAny<MedicationRequest?>(d_, k_);
            bool? m_ = context.Operators.Or(j_, l_);
            return m_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Inpatient Encounter With Encounter Diagnosis Of Cancer Pain")]
    public IEnumerable<Encounter?>? Inpatient_Encounter_With_Encounter_Diagnosis_Of_Cancer_Pain(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Inpatient_Encounter_With_Encounter_Diagnosis_Of_Cancer_Pain, Inpatient_Encounter_With_Encounter_Diagnosis_Of_Cancer_Pain_Compute);

    private const long _cacheIndex_Inpatient_Encounter_With_Encounter_Diagnosis_Of_Cancer_Pain = -8801150840158867846L;

    private IEnumerable<Encounter?>? Inpatient_Encounter_With_Encounter_Diagnosis_Of_Cancer_Pain_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Denominator(context);

        bool? b_(Encounter? QualifyingEncounter) {
            List<CodeableConcept>? d_ = QualifyingEncounter?.ReasonCode;

            CqlConcept? e_(CodeableConcept? @this) {
                CqlConcept? o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return o_;
            }

            IEnumerable<CqlConcept?>? f_ = context.Operators.Select<CodeableConcept?, CqlConcept?>((IEnumerable<CodeableConcept?>?)d_, e_);
            CqlValueSet? g_ = this.Cancer_Related_Pain(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<Condition?>? i_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, QualifyingEncounter);

            bool? j_(Condition? @this) {
                CodeableConcept? p_ = @this?.Code;
                CqlConcept? q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, p_);
                bool? r_ = context.Operators.Not((bool?)(q_ is null));
                return r_;
            }


            CqlConcept? k_(Condition? @this) {
                CodeableConcept? s_ = @this?.Code;
                CqlConcept? t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                return t_;
            }

            IEnumerable<CqlConcept?>? l_ = context.Operators.WhereSelect<Condition?, CqlConcept?>(i_, j_, k_);
            bool? m_ = context.Operators.ConceptsInValueSet(l_, g_);
            bool? n_ = context.Operators.Or(h_, m_);
            return n_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter?>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("isVerified")]
    [CqlTag("description", "Returns true if the given condition either has no verification status or has a verification status of confirmed, unconfirmed, provisional, or differential")]
    public bool? isVerified(CqlContext context, Condition? condition)
    {
        CodeableConcept? a_ = condition?.VerificationStatus;
        CqlConcept? b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        bool? c_ = context.Operators.Not((bool?)(b_ is null));
        CqlCode? d_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept? e_ = context.Operators.ConvertCodeToConcept(d_);
        bool? f_ = context.Operators.Equivalent(b_, e_);
        CqlCode? g_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
        CqlConcept? h_ = context.Operators.ConvertCodeToConcept(g_);
        bool? i_ = context.Operators.Equivalent(b_, h_);
        bool? j_ = context.Operators.Or(f_, i_);
        CqlCode? k_ = QICoreCommon_4_0_000.Instance.provisional(context);
        CqlConcept? l_ = context.Operators.ConvertCodeToConcept(k_);
        bool? m_ = context.Operators.Equivalent(b_, l_);
        bool? n_ = context.Operators.Or(j_, m_);
        CqlCode? o_ = QICoreCommon_4_0_000.Instance.differential(context);
        CqlConcept? p_ = context.Operators.ConvertCodeToConcept(o_);
        bool? q_ = context.Operators.Equivalent(b_, p_);
        bool? r_ = context.Operators.Or(n_, q_);
        bool? s_ = context.Operators.Implies(c_, r_);
        return s_;
    }


    [CqlExpressionDefinition("Medications For Opioid Use Disorder")]
    public IEnumerable<MedicationRequest?>? Medications_For_Opioid_Use_Disorder(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Medications_For_Opioid_Use_Disorder, Medications_For_Opioid_Use_Disorder_Compute);

    private const long _cacheIndex_Medications_For_Opioid_Use_Disorder = 8810620530117923890L;

    private IEnumerable<MedicationRequest?>? Medications_For_Opioid_Use_Disorder_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest?>? a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest? MR) {
            IEnumerable<Medication?>? i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? j_(Medication? M) {
                object? l_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? m_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? n_ = context.Operators.Split(((string?)m_)!, "/");
                string? o_ = context.Operators.Last<string?>(n_!);
                bool? p_ = context.Operators.Equal(l_, o_);
                CodeableConcept? q_ = M?.Code;
                CqlConcept? r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                CqlValueSet? s_ = this.Medications_for_Opioid_Use_Disorder__MOUD_(context);
                bool? t_ = context.Operators.ConceptInValueSet(r_, s_);
                bool? u_ = context.Operators.And(p_, t_);
                return u_;
            }

            bool? k_ = context.Operators.WhereAny<Medication?>(i_, j_);
            return k_;
        }

        IEnumerable<MedicationRequest?>? c_ = context.Operators.Where<MedicationRequest?>(a_, b_);
        CqlValueSet? d_ = this.Medications_for_Opioid_Use_Disorder__MOUD_(context);
        IEnumerable<MedicationRequest?>? e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? f_ = context.Operators.Union<MedicationRequest?>(c_, e_);

        bool? g_(MedicationRequest? DischargeMedication) {
            bool? v_ = QICoreCommon_4_0_000.Instance.isCommunity(context, DischargeMedication as MedicationRequest);
            bool? w_ = QICoreCommon_4_0_000.Instance.isDischarge(context, DischargeMedication as MedicationRequest);
            bool? x_ = context.Operators.Or(v_, w_);
            Code<MedicationRequest.MedicationrequestStatus>? y_ = DischargeMedication?.StatusElement;
            MedicationRequest.MedicationrequestStatus? z_ = y_?.Value;
            string? aa_ = context.Operators.Convert<string?>(z_);
            string?[]? ab_ = [
                "active",
                "completed",
            ];
            bool? ac_ = context.Operators.In<string?>(aa_, (IEnumerable<string?>?)ab_);
            bool? ad_ = context.Operators.And(x_, ac_);
            Code<MedicationRequest.MedicationRequestIntent>? ae_ = DischargeMedication?.IntentElement;
            MedicationRequest.MedicationRequestIntent? af_ = ae_?.Value;
            string? ag_ = context.Operators.Convert<string?>(af_);
            string?[]? ah_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? ai_ = context.Operators.In<string?>(ag_, (IEnumerable<string?>?)ah_);
            bool? aj_ = context.Operators.And(ad_, ai_);
            return aj_;
        }

        IEnumerable<MedicationRequest?>? h_ = context.Operators.Where<MedicationRequest?>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Treatment For Opioid Use Disorders")]
    public IEnumerable<MedicationRequest?>? Treatment_For_Opioid_Use_Disorders(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Treatment_For_Opioid_Use_Disorders, Treatment_For_Opioid_Use_Disorders_Compute);

    private const long _cacheIndex_Treatment_For_Opioid_Use_Disorders = -3469107966402147759L;

    private IEnumerable<MedicationRequest?>? Treatment_For_Opioid_Use_Disorders_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest?>? a_ = this.Medications_For_Opioid_Use_Disorder(context);

        bool? b_(MedicationRequest? MedicationTreatment) {
            CqlValueSet? g_ = this.Opioid_Medication_Assisted_Treatment__MAT_(context);
            IEnumerable<Procedure?>? h_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? i_(Procedure? MAT) {
                FhirDateTime? k_ = MedicationTreatment?.AuthoredOnElement;
                CqlDateTime? l_ = context.Operators.Convert<CqlDateTime?>(k_);
                object? m_;
                DataType? y_ = MAT?.Performed;
                object? z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                bool aa_ = z_ is CqlDateTime;
                if (aa_)
                {
                    DataType? ab_ = MAT?.Performed;
                    object? ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    m_ = ac_ as CqlDateTime;
                }
                else
                {
                    DataType? ad_ = MAT?.Performed;
                    object? ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    bool af_ = ae_ is CqlQuantity;
                    if (af_)
                    {
                        DataType? ag_ = MAT?.Performed;
                        object? ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        m_ = ah_ as CqlQuantity;
                    }
                    else
                    {
                        DataType? ai_ = MAT?.Performed;
                        object? aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                        bool ak_ = aj_ is CqlInterval<CqlDateTime>;
                        if (ak_)
                        {
                            DataType? al_ = MAT?.Performed;
                            object? am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                            m_ = am_ as CqlInterval<CqlDateTime?>;
                        }
                        else
                        {
                            DataType? an_ = MAT?.Performed;
                            object? ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                            bool ap_ = ao_ is CqlInterval<CqlQuantity>;
                            if (ap_)
                            {
                                DataType? aq_ = MAT?.Performed;
                                object? ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                                m_ = ar_ as CqlInterval<CqlQuantity?>;
                            }
                            else
                            {
                                m_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
                bool? o_ = context.Operators.In<CqlDateTime?>(l_, n_, "day");
                CqlInterval<CqlDateTime?>? p_ = this.Measurement_Period(context);
                bool? q_ = context.Operators.In<CqlDateTime?>(l_, p_, "day");
                bool? r_ = context.Operators.And(o_, q_);
                Code<EventStatus>? s_ = MAT?.StatusElement;
                EventStatus? t_ = s_?.Value;
                string? u_ = context.Operators.Convert<string?>(t_);
                string?[]? v_ = [
                    "completed",
                    "in-progress",
                ];
                bool? w_ = context.Operators.In<string?>(u_, (IEnumerable<string?>?)v_);
                bool? x_ = context.Operators.And(r_, w_);
                return x_;
            }

            bool? j_ = context.Operators.WhereAny<Procedure?>(h_, i_);
            return j_;
        }

        IEnumerable<MedicationRequest?>? c_ = context.Operators.Where<MedicationRequest?>(a_, b_);

        bool? d_(MedicationRequest? MedicationTreatment) {
            CqlValueSet? as_ = this.Opioid_Use_Disorder(context);
            IEnumerable<Condition?>? at_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, as_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? au_(Condition? OUD) {
                FhirDateTime? aw_ = MedicationTreatment?.AuthoredOnElement;
                CqlDateTime? ax_ = context.Operators.Convert<CqlDateTime?>(aw_);
                CqlInterval<CqlDateTime?>? ay_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, OUD as Condition);
                bool? az_ = context.Operators.In<CqlDateTime?>(ax_, ay_, "day");
                CqlInterval<CqlDateTime?>? ba_ = this.Measurement_Period(context);
                bool? bb_ = context.Operators.Overlaps(ay_!, ba_!, "day");
                bool? bc_ = context.Operators.And(az_, bb_);
                bool? bd_ = this.isVerified(context, OUD as Condition);
                bool? be_ = context.Operators.And(bc_, bd_);
                return be_;
            }

            bool? av_ = context.Operators.WhereAny<Condition?>(at_, au_);
            return av_;
        }

        IEnumerable<MedicationRequest?>? e_ = context.Operators.Where<MedicationRequest?>(a_, d_);
        IEnumerable<MedicationRequest?>? f_ = context.Operators.Union<MedicationRequest?>(c_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Intervention Palliative Or Hospice Care")]
    public IEnumerable<object?>? Intervention_Palliative_Or_Hospice_Care(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Intervention_Palliative_Or_Hospice_Care, Intervention_Palliative_Or_Hospice_Care_Compute);

    private const long _cacheIndex_Intervention_Palliative_Or_Hospice_Care = -8472319639264910238L;

    private IEnumerable<object?>? Intervention_Palliative_Or_Hospice_Care_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Palliative_or_Hospice_Care(context);
        IEnumerable<ServiceRequest?>? b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        bool? c_(ServiceRequest? PalliativeOrHospiceCareOrder) {
            Code<RequestStatus>? i_ = PalliativeOrHospiceCareOrder?.StatusElement;
            RequestStatus? j_ = i_?.Value;
            Code<RequestStatus>? k_ = context.Operators.Convert<Code<RequestStatus>?>(j_);
            string? l_ = context.Operators.Convert<string?>(k_);
            string?[]? m_ = [
                "active",
                "completed",
                "on-hold",
            ];
            bool? n_ = context.Operators.In<string?>(l_, (IEnumerable<string?>?)m_);
            return n_;
        }

        IEnumerable<ServiceRequest?>? d_ = context.Operators.Where<ServiceRequest?>(b_, c_);
        IEnumerable<Procedure?>? e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? f_(Procedure? PalliativeOrHospiceCarePerformed) {
            Code<EventStatus>? o_ = PalliativeOrHospiceCarePerformed?.StatusElement;
            EventStatus? p_ = o_?.Value;
            string? q_ = context.Operators.Convert<string?>(p_);
            string?[]? r_ = [
                "completed",
                "in-progress",
            ];
            bool? s_ = context.Operators.In<string?>(q_, (IEnumerable<string?>?)r_);
            return s_;
        }

        IEnumerable<Procedure?>? g_ = context.Operators.Where<Procedure?>(e_, f_);
        IEnumerable<object?>? h_ = context.Operators.Union<object?>(d_ as IEnumerable<object?>, g_ as IEnumerable<object?>);
        return h_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    [CqlTag("description", "Excludes encounters of patients with cancer pain or who are receiving palliative or hospice care at the time of the encounter or who receive treatment for opioid use disorder, have sickle cell disease, or who are discharged to another inpatient care facility or discharged against medical advice, or expire during the inpatient stay.")]
    public IEnumerable<Encounter?>? Denominator_Exclusion(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusion, Denominator_Exclusion_Compute);

    private const long _cacheIndex_Denominator_Exclusion = 7742790657479996528L;

    private IEnumerable<Encounter?>? Denominator_Exclusion_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Denominator(context);

        bool? b_(Encounter? InpatientEncounter) {
            CqlValueSet? d_ = this.Cancer_Related_Pain(context);
            IEnumerable<Condition?>? e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? f_(Condition? CancerPain) {
                CqlInterval<CqlDateTime?>? am_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, CancerPain as Condition);
                Period? an_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime?>? ao_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, an_);
                bool? ap_ = context.Operators.Overlaps(am_!, ao_!, "day");
                bool? aq_ = this.isVerified(context, CancerPain as Condition);
                bool? ar_ = context.Operators.And(ap_, aq_);
                return ar_;
            }

            bool? g_ = context.Operators.WhereAny<Condition?>(e_, f_);
            IEnumerable<Encounter?>? h_ = this.Inpatient_Encounter_With_Encounter_Diagnosis_Of_Cancer_Pain(context);
            bool? i_ = context.Operators.Exists<Encounter?>(h_!);
            bool? j_ = context.Operators.Or(g_, i_);
            CqlValueSet? k_ = this.Sickle_Cell_Disease_with_and_without_Crisis(context);
            IEnumerable<Condition?>? l_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? m_(Condition? SickleCellDisease) {
                CqlInterval<CqlDateTime?>? as_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, SickleCellDisease as Condition);
                Period? at_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime?>? au_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, at_);
                bool? av_ = context.Operators.Overlaps(as_!, au_!, "day");
                bool? aw_ = this.isVerified(context, SickleCellDisease as Condition);
                bool? ax_ = context.Operators.And(av_, aw_);
                return ax_;
            }

            bool? n_ = context.Operators.WhereAny<Condition?>(l_, m_);
            bool? o_ = context.Operators.Or(j_, n_);
            IEnumerable<MedicationRequest?>? p_ = this.Treatment_For_Opioid_Use_Disorders(context);

            bool? q_(MedicationRequest? OUDTreatment) {
                FhirDateTime? ay_ = OUDTreatment?.AuthoredOnElement;
                CqlDateTime? az_ = context.Operators.Convert<CqlDateTime?>(ay_);
                Period? ba_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime?>? bb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ba_);
                bool? bc_ = context.Operators.In<CqlDateTime?>(az_, bb_, "day");
                return bc_;
            }

            bool? r_ = context.Operators.WhereAny<MedicationRequest?>(p_, q_);
            bool? s_ = context.Operators.Or(o_, r_);
            IEnumerable<object?>? t_ = this.Intervention_Palliative_Or_Hospice_Care(context);

            bool? u_(object? PalliativeOrHospiceCare) {
                object? bd_;
                object? bk_ = context.Operators.LateBoundProperty<object?>(PalliativeOrHospiceCare, "performed");
                object? bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                bool bm_ = bl_ is CqlDateTime;
                if (bm_)
                {
                    object? bn_ = context.Operators.LateBoundProperty<object?>(PalliativeOrHospiceCare, "performed");
                    object? bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    bd_ = bo_ as CqlDateTime;
                }
                else
                {
                    object? bp_ = context.Operators.LateBoundProperty<object?>(PalliativeOrHospiceCare, "performed");
                    object? bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                    bool br_ = bq_ is CqlQuantity;
                    if (br_)
                    {
                        object? bs_ = context.Operators.LateBoundProperty<object?>(PalliativeOrHospiceCare, "performed");
                        object? bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                        bd_ = bt_ as CqlQuantity;
                    }
                    else
                    {
                        object? bu_ = context.Operators.LateBoundProperty<object?>(PalliativeOrHospiceCare, "performed");
                        object? bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                        bool bw_ = bv_ is CqlInterval<CqlDateTime>;
                        if (bw_)
                        {
                            object? bx_ = context.Operators.LateBoundProperty<object?>(PalliativeOrHospiceCare, "performed");
                            object? by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                            bd_ = by_ as CqlInterval<CqlDateTime?>;
                        }
                        else
                        {
                            object? bz_ = context.Operators.LateBoundProperty<object?>(PalliativeOrHospiceCare, "performed");
                            object? ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                            bool cb_ = ca_ is CqlInterval<CqlQuantity>;
                            if (cb_)
                            {
                                object? cc_ = context.Operators.LateBoundProperty<object?>(PalliativeOrHospiceCare, "performed");
                                object? cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                                bd_ = cd_ as CqlInterval<CqlQuantity?>;
                            }
                            else
                            {
                                bd_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? be_ = QICoreCommon_4_0_000.Instance.toInterval(context, bd_);
                CqlDateTime? bf_ = context.Operators.Start(be_);
                object? bg_ = context.Operators.LateBoundProperty<object?>(PalliativeOrHospiceCare, "authoredOn");
                CqlDateTime? bh_ = context.Operators.LateBoundProperty<CqlDateTime?>(bg_, "value");
                CqlInterval<CqlDateTime?>? bi_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
                bool? bj_ = context.Operators.In<CqlDateTime?>(bf_ ?? bh_, bi_, (string?)default);
                return bj_;
            }

            bool? v_ = context.Operators.WhereAny<object?>(t_, u_);
            bool? w_ = context.Operators.Or(s_, v_);
            Encounter.HospitalizationComponent? x_ = InpatientEncounter?.Hospitalization;
            CodeableConcept? y_ = x_?.DischargeDisposition;
            CqlConcept? z_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, y_);
            CqlValueSet? aa_ = this.Discharge_To_Acute_Care_Facility(context);
            bool? ab_ = context.Operators.ConceptInValueSet(z_, aa_);
            CqlValueSet? ac_ = this.Hospice_Care_Referral_or_Admission(context);
            bool? ad_ = context.Operators.ConceptInValueSet(z_, ac_);
            bool? ae_ = context.Operators.Or(ab_, ad_);
            CqlValueSet? af_ = this.Patient_Expired(context);
            bool? ag_ = context.Operators.ConceptInValueSet(z_, af_);
            bool? ah_ = context.Operators.Or(ae_, ag_);
            CqlValueSet? ai_ = this.Left_Against_Medical_Advice(context);
            bool? aj_ = context.Operators.ConceptInValueSet(z_, ai_);
            bool? ak_ = context.Operators.Or(ah_, aj_);
            bool? al_ = context.Operators.Or(w_, ak_);
            return al_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -8233428871904802123L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 6431907323170134029L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -4462710836571348549L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode? SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 1755239228573560717L;

    private CqlCode? SDE_Sex_Compute(CqlContext context)
    {
        CqlCode? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS506FHIRSafeUseofOpioids_1_0_000() {}

    public static CMS506FHIRSafeUseofOpioids_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS506FHIRSafeUseofOpioids";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [CQMCommon_4_1_000.Instance, FHIRHelpers_4_4_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance];

    #endregion ILibrary Implementation

}
