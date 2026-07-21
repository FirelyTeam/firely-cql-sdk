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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.2.0")]
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
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -6711178551512193567L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS506FHIRSafeUseofOpioids-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (18)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 8112107951287448751L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Inpatient Encounter With Age Greater Than Or Equal To 18")]
    public IEnumerable<Encounter> Inpatient_Encounter_With_Age_Greater_Than_Or_Equal_To_18(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Inpatient_Encounter_With_Age_Greater_Than_Or_Equal_To_18, Inpatient_Encounter_With_Age_Greater_Than_Or_Equal_To_18_Compute);

    private const long _cacheIndex_Inpatient_Encounter_With_Age_Greater_Than_Or_Equal_To_18 = -1650556549303795711L;

    private IEnumerable<Encounter> Inpatient_Encounter_With_Age_Greater_Than_Or_Equal_To_18_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = CQMCommon_4_1_000.Instance.Inpatient_Encounter(context);

        bool? b_(Encounter InpatientHospitalEncounter) {
            Patient d_ = this.Patient(context);
            Date e_ = d_?.BirthDateElement;
            string f_ = e_?.Value;
            CqlDate g_ = context.Operators.ConvertStringToDate(f_);
            Period h_ = InpatientHospitalEncounter?.Period;
            CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
            CqlDateTime j_ = context.Operators.Start(i_);
            CqlDate k_ = context.Operators.DateFrom(j_);
            int? l_ = context.Operators.CalculateAgeAt(g_, k_, "year");
            bool? m_ = context.Operators.GreaterOrEqual(l_, 18);
            return m_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Opioid At Discharge")]
    public IEnumerable<MedicationRequest> Opioid_At_Discharge(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Opioid_At_Discharge, Opioid_At_Discharge_Compute);

    private const long _cacheIndex_Opioid_At_Discharge = 5633346317000929987L;

    private IEnumerable<MedicationRequest> Opioid_At_Discharge_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Schedule_II__III_and_IV_Opioid_Medications(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? d_(MedicationRequest MR) {
            IEnumerable<Medication> i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? j_(Medication M) {
                object m_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object n_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> o_ = context.Operators.Split((string)n_, "/");
                string p_ = context.Operators.Last<string>(o_);
                bool? q_ = context.Operators.Equal(m_, p_);
                CodeableConcept r_ = M?.Code;
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                CqlValueSet t_ = this.Schedule_II__III_and_IV_Opioid_Medications(context);
                bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                bool? v_ = context.Operators.And(q_, u_);
                return v_;
            }

            IEnumerable<Medication> k_ = context.Operators.Where<Medication>(i_, j_);
            bool? l_ = context.Operators.Exists<Medication>(k_);
            return l_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);

        bool? g_(MedicationRequest OpioidMedications) {
            bool? w_ = QICoreCommon_4_0_000.Instance.isCommunity(context, OpioidMedications as MedicationRequest);
            bool? x_ = QICoreCommon_4_0_000.Instance.isDischarge(context, OpioidMedications as MedicationRequest);
            bool? y_ = context.Operators.Or(w_, x_);
            Code<MedicationRequest.MedicationrequestStatus> z_ = OpioidMedications?.StatusElement;
            MedicationRequest.MedicationrequestStatus? aa_ = z_?.Value;
            string ab_ = context.Operators.Convert<string>(aa_);
            string[] ac_ = [
                "active",
                "completed",
            ];
            bool? ad_ = context.Operators.In<string>(ab_, (IEnumerable<string>)ac_);
            bool? ae_ = context.Operators.And(y_, ad_);
            Code<MedicationRequest.MedicationRequestIntent> af_ = OpioidMedications?.IntentElement;
            MedicationRequest.MedicationRequestIntent? ag_ = af_?.Value;
            string ah_ = context.Operators.Convert<string>(ag_);
            string[] ai_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? aj_ = context.Operators.In<string>(ah_, (IEnumerable<string>)ai_);
            bool? ak_ = context.Operators.And(ae_, aj_);
            return ak_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Benzodiazepine At Discharge")]
    public IEnumerable<MedicationRequest> Benzodiazepine_At_Discharge(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Benzodiazepine_At_Discharge, Benzodiazepine_At_Discharge_Compute);

    private const long _cacheIndex_Benzodiazepine_At_Discharge = -7244176487788219701L;

    private IEnumerable<MedicationRequest> Benzodiazepine_At_Discharge_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Schedule_IV_Benzodiazepines(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? d_(MedicationRequest MR) {
            IEnumerable<Medication> i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? j_(Medication M) {
                object m_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object n_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> o_ = context.Operators.Split((string)n_, "/");
                string p_ = context.Operators.Last<string>(o_);
                bool? q_ = context.Operators.Equal(m_, p_);
                CodeableConcept r_ = M?.Code;
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                CqlValueSet t_ = this.Schedule_IV_Benzodiazepines(context);
                bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                bool? v_ = context.Operators.And(q_, u_);
                return v_;
            }

            IEnumerable<Medication> k_ = context.Operators.Where<Medication>(i_, j_);
            bool? l_ = context.Operators.Exists<Medication>(k_);
            return l_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);

        bool? g_(MedicationRequest BenzoMedications) {
            bool? w_ = QICoreCommon_4_0_000.Instance.isCommunity(context, BenzoMedications as MedicationRequest);
            bool? x_ = QICoreCommon_4_0_000.Instance.isDischarge(context, BenzoMedications as MedicationRequest);
            bool? y_ = context.Operators.Or(w_, x_);
            Code<MedicationRequest.MedicationrequestStatus> z_ = BenzoMedications?.StatusElement;
            MedicationRequest.MedicationrequestStatus? aa_ = z_?.Value;
            string ab_ = context.Operators.Convert<string>(aa_);
            string[] ac_ = [
                "active",
                "completed",
            ];
            bool? ad_ = context.Operators.In<string>(ab_, (IEnumerable<string>)ac_);
            bool? ae_ = context.Operators.And(y_, ad_);
            Code<MedicationRequest.MedicationRequestIntent> af_ = BenzoMedications?.IntentElement;
            MedicationRequest.MedicationRequestIntent? ag_ = af_?.Value;
            string ah_ = context.Operators.Convert<string>(ag_);
            string[] ai_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? aj_ = context.Operators.In<string>(ah_, (IEnumerable<string>)ai_);
            bool? ak_ = context.Operators.And(ae_, aj_);
            return ak_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Inpatient Encounters With An Opioid Or Benzodiazepine At Discharge")]
    [CqlTag("description", "Captures encounters of patients with an opioid and/or benzodiazepine at discharge.")]
    public IEnumerable<Encounter> Inpatient_Encounters_With_An_Opioid_Or_Benzodiazepine_At_Discharge(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Inpatient_Encounters_With_An_Opioid_Or_Benzodiazepine_At_Discharge, Inpatient_Encounters_With_An_Opioid_Or_Benzodiazepine_At_Discharge_Compute);

    private const long _cacheIndex_Inpatient_Encounters_With_An_Opioid_Or_Benzodiazepine_At_Discharge = -1484108012641628654L;

    private IEnumerable<Encounter> Inpatient_Encounters_With_An_Opioid_Or_Benzodiazepine_At_Discharge_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounter_With_Age_Greater_Than_Or_Equal_To_18(context);

        bool? b_(Encounter InpatientEncounter) {
            IEnumerable<MedicationRequest> d_ = this.Opioid_At_Discharge(context);
            IEnumerable<MedicationRequest> e_ = this.Benzodiazepine_At_Discharge(context);
            IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(d_, e_);

            bool? g_(MedicationRequest OpioidOrBenzodiazepineAtDischarge) {
                FhirDateTime j_ = OpioidOrBenzodiazepineAtDischarge?.AuthoredOnElement;
                CqlDateTime k_ = context.Operators.Convert<CqlDateTime>(j_);
                Period l_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                bool? n_ = context.Operators.In<CqlDateTime>(k_, m_, "day");
                return n_;
            }

            IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
            bool? i_ = context.Operators.Exists<MedicationRequest>(h_);
            return i_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -8403253536875342235L;

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters_With_An_Opioid_Or_Benzodiazepine_At_Discharge(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 8706893806779564920L;

    private IEnumerable<Encounter> Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Numerator")]
    [CqlTag("description", "Encounters of patients prescribed two or more opioids or an opioid and benzodiazepine at discharge.")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -7195865355092763235L;

    private IEnumerable<Encounter> Numerator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);

        bool? b_(Encounter InpatientEncounter) {
            IEnumerable<MedicationRequest> d_ = this.Opioid_At_Discharge(context);

            bool? e_(MedicationRequest OpioidMedications) {
                FhirDateTime q_ = OpioidMedications?.AuthoredOnElement;
                CqlDateTime r_ = context.Operators.Convert<CqlDateTime>(q_);
                Period s_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, s_);
                bool? u_ = context.Operators.In<CqlDateTime>(r_, t_, "day");
                return u_;
            }

            IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);

            object g_(MedicationRequest OpioidMedications) {
                DataType v_ = OpioidMedications?.Medication;
                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                return w_;
            }

            IEnumerable<object> h_ = context.Operators.Select<MedicationRequest, object>(f_, g_);
            IEnumerable<object> i_ = context.Operators.Distinct<object>(h_);
            int? j_ = context.Operators.Count<object>(i_);
            bool? k_ = context.Operators.GreaterOrEqual(j_, 2);

            bool? m_(MedicationRequest OpioidDischargeMedications) {
                FhirDateTime x_ = OpioidDischargeMedications?.AuthoredOnElement;
                CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(x_);
                Period z_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
                bool? ab_ = context.Operators.In<CqlDateTime>(y_, aa_, "day");
                IEnumerable<MedicationRequest> ac_ = this.Benzodiazepine_At_Discharge(context);

                bool? ad_(MedicationRequest BenzodiazepineDischargeMedication) {
                    FhirDateTime ah_ = BenzodiazepineDischargeMedication?.AuthoredOnElement;
                    CqlDateTime ai_ = context.Operators.Convert<CqlDateTime>(ah_);
                    Period aj_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aj_);
                    bool? al_ = context.Operators.In<CqlDateTime>(ai_, ak_, "day");
                    return al_;
                }

                IEnumerable<MedicationRequest> ae_ = context.Operators.Where<MedicationRequest>(ac_, ad_);
                bool? af_ = context.Operators.Exists<MedicationRequest>(ae_);
                bool? ag_ = context.Operators.And(ab_, af_);
                return ag_;
            }

            IEnumerable<MedicationRequest> n_ = context.Operators.Where<MedicationRequest>(d_, m_);
            bool? o_ = context.Operators.Exists<MedicationRequest>(n_);
            bool? p_ = context.Operators.Or(k_, o_);
            return p_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Inpatient Encounter With Encounter Diagnosis Of Cancer Pain")]
    public IEnumerable<Encounter> Inpatient_Encounter_With_Encounter_Diagnosis_Of_Cancer_Pain(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Inpatient_Encounter_With_Encounter_Diagnosis_Of_Cancer_Pain, Inpatient_Encounter_With_Encounter_Diagnosis_Of_Cancer_Pain_Compute);

    private const long _cacheIndex_Inpatient_Encounter_With_Encounter_Diagnosis_Of_Cancer_Pain = -8801150840158867846L;

    private IEnumerable<Encounter> Inpatient_Encounter_With_Encounter_Diagnosis_Of_Cancer_Pain_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);

        bool? b_(Encounter QualifyingEncounter) {
            List<CodeableConcept> d_ = QualifyingEncounter?.ReasonCode;

            CqlConcept e_(CodeableConcept @this) {
                CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return q_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.Cancer_Related_Pain(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<Condition> i_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, QualifyingEncounter);

            bool? j_(Condition @this) {
                CodeableConcept r_ = @this?.Code;
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                bool? t_ = context.Operators.Not((bool?)(s_ is null));
                return t_;
            }

            IEnumerable<Condition> k_ = context.Operators.Where<Condition>(i_, j_);

            CqlConcept l_(Condition @this) {
                CodeableConcept u_ = @this?.Code;
                CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
                return v_;
            }

            IEnumerable<CqlConcept> m_ = context.Operators.Select<Condition, CqlConcept>(k_, l_);
            bool? o_ = context.Operators.ConceptsInValueSet(m_, g_);
            bool? p_ = context.Operators.Or(h_, o_);
            return p_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("isVerified")]
    [CqlTag("description", "Returns true if the given condition either has no verification status or has a verification status of confirmed, unconfirmed, provisional, or differential")]
    public bool? isVerified(CqlContext context, Condition condition)
    {
        CodeableConcept a_ = condition?.VerificationStatus;
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        bool? c_ = context.Operators.Not((bool?)(b_ is null));
        CqlConcept e_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        CqlCode f_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept g_ = context.Operators.ConvertCodeToConcept(f_);
        bool? h_ = context.Operators.Equivalent(e_, g_);
        CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        CqlCode k_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
        CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
        bool? m_ = context.Operators.Equivalent(j_, l_);
        bool? n_ = context.Operators.Or(h_, m_);
        CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        CqlCode q_ = QICoreCommon_4_0_000.Instance.provisional(context);
        CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
        bool? s_ = context.Operators.Equivalent(p_, r_);
        bool? t_ = context.Operators.Or(n_, s_);
        CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        CqlCode w_ = QICoreCommon_4_0_000.Instance.differential(context);
        CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
        bool? y_ = context.Operators.Equivalent(v_, x_);
        bool? z_ = context.Operators.Or(t_, y_);
        bool? aa_ = context.Operators.Implies(c_, z_);
        return aa_;
    }


    [CqlExpressionDefinition("Medications For Opioid Use Disorder")]
    public IEnumerable<MedicationRequest> Medications_For_Opioid_Use_Disorder(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Medications_For_Opioid_Use_Disorder, Medications_For_Opioid_Use_Disorder_Compute);

    private const long _cacheIndex_Medications_For_Opioid_Use_Disorder = 8810620530117923890L;

    private IEnumerable<MedicationRequest> Medications_For_Opioid_Use_Disorder_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Medications_for_Opioid_Use_Disorder__MOUD_(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? d_(MedicationRequest MR) {
            IEnumerable<Medication> i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? j_(Medication M) {
                object m_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object n_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> o_ = context.Operators.Split((string)n_, "/");
                string p_ = context.Operators.Last<string>(o_);
                bool? q_ = context.Operators.Equal(m_, p_);
                CodeableConcept r_ = M?.Code;
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                CqlValueSet t_ = this.Medications_for_Opioid_Use_Disorder__MOUD_(context);
                bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                bool? v_ = context.Operators.And(q_, u_);
                return v_;
            }

            IEnumerable<Medication> k_ = context.Operators.Where<Medication>(i_, j_);
            bool? l_ = context.Operators.Exists<Medication>(k_);
            return l_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);

        bool? g_(MedicationRequest DischargeMedication) {
            bool? w_ = QICoreCommon_4_0_000.Instance.isCommunity(context, DischargeMedication as MedicationRequest);
            bool? x_ = QICoreCommon_4_0_000.Instance.isDischarge(context, DischargeMedication as MedicationRequest);
            bool? y_ = context.Operators.Or(w_, x_);
            Code<MedicationRequest.MedicationrequestStatus> z_ = DischargeMedication?.StatusElement;
            MedicationRequest.MedicationrequestStatus? aa_ = z_?.Value;
            string ab_ = context.Operators.Convert<string>(aa_);
            string[] ac_ = [
                "active",
                "completed",
            ];
            bool? ad_ = context.Operators.In<string>(ab_, (IEnumerable<string>)ac_);
            bool? ae_ = context.Operators.And(y_, ad_);
            Code<MedicationRequest.MedicationRequestIntent> af_ = DischargeMedication?.IntentElement;
            MedicationRequest.MedicationRequestIntent? ag_ = af_?.Value;
            string ah_ = context.Operators.Convert<string>(ag_);
            string[] ai_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? aj_ = context.Operators.In<string>(ah_, (IEnumerable<string>)ai_);
            bool? ak_ = context.Operators.And(ae_, aj_);
            return ak_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Treatment For Opioid Use Disorders")]
    public IEnumerable<MedicationRequest> Treatment_For_Opioid_Use_Disorders(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Treatment_For_Opioid_Use_Disorders, Treatment_For_Opioid_Use_Disorders_Compute);

    private const long _cacheIndex_Treatment_For_Opioid_Use_Disorders = -3469107966402147759L;

    private IEnumerable<MedicationRequest> Treatment_For_Opioid_Use_Disorders_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest> a_ = this.Medications_For_Opioid_Use_Disorder(context);

        bool? b_(MedicationRequest MedicationTreatment) {
            CqlValueSet h_ = this.Opioid_Medication_Assisted_Treatment__MAT_(context);
            IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? j_(Procedure MAT) {
                FhirDateTime m_ = MedicationTreatment?.AuthoredOnElement;
                CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);

                object o_() {

                    bool ac_() {
                        DataType ag_ = MAT?.Performed;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        bool ai_ = ah_ is CqlDateTime;
                        return ai_;
                    }


                    bool ad_() {
                        DataType aj_ = MAT?.Performed;
                        object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                        bool al_ = ak_ is CqlInterval<CqlDateTime>;
                        return al_;
                    }


                    bool ae_() {
                        DataType am_ = MAT?.Performed;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        bool ao_ = an_ is CqlQuantity;
                        return ao_;
                    }


                    bool af_() {
                        DataType ap_ = MAT?.Performed;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        bool ar_ = aq_ is CqlInterval<CqlQuantity>;
                        return ar_;
                    }

                    if (ac_())
                    {
                        DataType as_ = MAT?.Performed;
                        object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                        return (at_ as CqlDateTime) as object;
                    }
                    else if (ad_())
                    {
                        DataType au_ = MAT?.Performed;
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                        return (av_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ae_())
                    {
                        DataType aw_ = MAT?.Performed;
                        object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                        return (ax_ as CqlQuantity) as object;
                    }
                    else if (af_())
                    {
                        DataType ay_ = MAT?.Performed;
                        object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                        return (az_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_());
                bool? q_ = context.Operators.In<CqlDateTime>(n_, p_, "day");
                CqlDateTime s_ = context.Operators.Convert<CqlDateTime>(m_);
                CqlInterval<CqlDateTime> t_ = this.Measurement_Period(context);
                bool? u_ = context.Operators.In<CqlDateTime>(s_, t_, "day");
                bool? v_ = context.Operators.And(q_, u_);
                Code<EventStatus> w_ = MAT?.StatusElement;
                EventStatus? x_ = w_?.Value;
                string y_ = context.Operators.Convert<string>(x_);
                string[] z_ = [
                    "completed",
                    "in-progress",
                ];
                bool? aa_ = context.Operators.In<string>(y_, (IEnumerable<string>)z_);
                bool? ab_ = context.Operators.And(v_, aa_);
                return ab_;
            }

            IEnumerable<Procedure> k_ = context.Operators.Where<Procedure>(i_, j_);
            bool? l_ = context.Operators.Exists<Procedure>(k_);
            return l_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);

        bool? e_(MedicationRequest MedicationTreatment) {
            CqlValueSet ba_ = this.Opioid_Use_Disorder(context);
            IEnumerable<Condition> bb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ba_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? bc_(Condition OUD) {
                FhirDateTime bf_ = MedicationTreatment?.AuthoredOnElement;
                CqlDateTime bg_ = context.Operators.Convert<CqlDateTime>(bf_);
                CqlInterval<CqlDateTime> bh_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, OUD as Condition);
                bool? bi_ = context.Operators.In<CqlDateTime>(bg_, bh_, "day");
                CqlInterval<CqlDateTime> bk_ = this.Measurement_Period(context);
                bool? bl_ = context.Operators.Overlaps(bh_, bk_, "day");
                bool? bm_ = context.Operators.And(bi_, bl_);
                bool? bn_ = this.isVerified(context, OUD as Condition);
                bool? bo_ = context.Operators.And(bm_, bn_);
                return bo_;
            }

            IEnumerable<Condition> bd_ = context.Operators.Where<Condition>(bb_, bc_);
            bool? be_ = context.Operators.Exists<Condition>(bd_);
            return be_;
        }

        IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(a_, e_);
        IEnumerable<MedicationRequest> g_ = context.Operators.Union<MedicationRequest>(c_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Intervention Palliative Or Hospice Care")]
    public IEnumerable<object> Intervention_Palliative_Or_Hospice_Care(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Intervention_Palliative_Or_Hospice_Care, Intervention_Palliative_Or_Hospice_Care_Compute);

    private const long _cacheIndex_Intervention_Palliative_Or_Hospice_Care = -8472319639264910238L;

    private IEnumerable<object> Intervention_Palliative_Or_Hospice_Care_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Palliative_or_Hospice_Care(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        bool? c_(ServiceRequest PalliativeOrHospiceCareOrder) {
            Code<RequestStatus> j_ = PalliativeOrHospiceCareOrder?.StatusElement;
            RequestStatus? k_ = j_?.Value;
            Code<RequestStatus> l_ = context.Operators.Convert<Code<RequestStatus>>(k_);
            string m_ = context.Operators.Convert<string>(l_);
            string[] n_ = [
                "active",
                "completed",
                "on-hold",
            ];
            bool? o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);
            return o_;
        }

        IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);
        IEnumerable<Procedure> f_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? g_(Procedure PalliativeOrHospiceCarePerformed) {
            Code<EventStatus> p_ = PalliativeOrHospiceCarePerformed?.StatusElement;
            EventStatus? q_ = p_?.Value;
            string r_ = context.Operators.Convert<string>(q_);
            string[] s_ = [
                "completed",
                "in-progress",
            ];
            bool? t_ = context.Operators.In<string>(r_, (IEnumerable<string>)s_);
            return t_;
        }

        IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
        IEnumerable<object> i_ = context.Operators.Union<object>(d_ as IEnumerable<object>, h_ as IEnumerable<object>);
        return i_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    [CqlTag("description", "Excludes encounters of patients with cancer pain or who are receiving palliative or hospice care at the time of the encounter or who receive treatment for opioid use disorder, have sickle cell disease, or who are discharged to another inpatient care facility or discharged against medical advice, or expire during the inpatient stay.")]
    public IEnumerable<Encounter> Denominator_Exclusion(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusion, Denominator_Exclusion_Compute);

    private const long _cacheIndex_Denominator_Exclusion = 7742790657479996528L;

    private IEnumerable<Encounter> Denominator_Exclusion_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);

        bool? b_(Encounter InpatientEncounter) {
            CqlValueSet d_ = this.Cancer_Related_Pain(context);
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? f_(Condition CancerPain) {
                CqlInterval<CqlDateTime> az_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, CancerPain as Condition);
                Period ba_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> bb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ba_);
                bool? bc_ = context.Operators.Overlaps(az_, bb_, "day");
                bool? bd_ = this.isVerified(context, CancerPain as Condition);
                bool? be_ = context.Operators.And(bc_, bd_);
                return be_;
            }

            IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
            bool? h_ = context.Operators.Exists<Condition>(g_);
            IEnumerable<Encounter> i_ = this.Inpatient_Encounter_With_Encounter_Diagnosis_Of_Cancer_Pain(context);
            bool? j_ = context.Operators.Exists<Encounter>(i_);
            bool? k_ = context.Operators.Or(h_, j_);
            CqlValueSet l_ = this.Sickle_Cell_Disease_with_and_without_Crisis(context);
            IEnumerable<Condition> m_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? n_(Condition SickleCellDisease) {
                CqlInterval<CqlDateTime> bf_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, SickleCellDisease as Condition);
                Period bg_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> bh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bg_);
                bool? bi_ = context.Operators.Overlaps(bf_, bh_, "day");
                bool? bj_ = this.isVerified(context, SickleCellDisease as Condition);
                bool? bk_ = context.Operators.And(bi_, bj_);
                return bk_;
            }

            IEnumerable<Condition> o_ = context.Operators.Where<Condition>(m_, n_);
            bool? p_ = context.Operators.Exists<Condition>(o_);
            bool? q_ = context.Operators.Or(k_, p_);
            IEnumerable<MedicationRequest> r_ = this.Treatment_For_Opioid_Use_Disorders(context);

            bool? s_(MedicationRequest OUDTreatment) {
                FhirDateTime bl_ = OUDTreatment?.AuthoredOnElement;
                CqlDateTime bm_ = context.Operators.Convert<CqlDateTime>(bl_);
                Period bn_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> bo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bn_);
                bool? bp_ = context.Operators.In<CqlDateTime>(bm_, bo_, "day");
                return bp_;
            }

            IEnumerable<MedicationRequest> t_ = context.Operators.Where<MedicationRequest>(r_, s_);
            bool? u_ = context.Operators.Exists<MedicationRequest>(t_);
            bool? v_ = context.Operators.Or(q_, u_);
            IEnumerable<object> w_ = this.Intervention_Palliative_Or_Hospice_Care(context);

            bool? x_(object PalliativeOrHospiceCare) {

                object bq_() {

                    bool bx_() {
                        object cb_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                        object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                        bool cd_ = cc_ is CqlDateTime;
                        return cd_;
                    }


                    bool by_() {
                        object ce_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                        object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                        bool cg_ = cf_ is CqlInterval<CqlDateTime>;
                        return cg_;
                    }


                    bool bz_() {
                        object ch_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                        object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                        bool cj_ = ci_ is CqlQuantity;
                        return cj_;
                    }


                    bool ca_() {
                        object ck_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                        bool cm_ = cl_ is CqlInterval<CqlQuantity>;
                        return cm_;
                    }

                    if (bx_())
                    {
                        object cn_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                        object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                        return (co_ as CqlDateTime) as object;
                    }
                    else if (by_())
                    {
                        object cp_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                        object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                        return (cq_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (bz_())
                    {
                        object cr_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                        object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                        return (cs_ as CqlQuantity) as object;
                    }
                    else if (ca_())
                    {
                        object ct_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                        object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                        return (cu_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> br_ = QICoreCommon_4_0_000.Instance.toInterval(context, bq_());
                CqlDateTime bs_ = context.Operators.Start(br_);
                object bt_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "authoredOn");
                CqlDateTime bu_ = context.Operators.LateBoundProperty<CqlDateTime>(bt_, "value");
                CqlInterval<CqlDateTime> bv_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
                bool? bw_ = context.Operators.In<CqlDateTime>(bs_ ?? bu_, bv_, (string)default);
                return bw_;
            }

            IEnumerable<object> y_ = context.Operators.Where<object>(w_, x_);
            bool? z_ = context.Operators.Exists<object>(y_);
            bool? aa_ = context.Operators.Or(v_, z_);
            Encounter.HospitalizationComponent ab_ = InpatientEncounter?.Hospitalization;
            CodeableConcept ac_ = ab_?.DischargeDisposition;
            CqlConcept ad_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ac_);
            CqlValueSet ae_ = this.Discharge_To_Acute_Care_Facility(context);
            bool? af_ = context.Operators.ConceptInValueSet(ad_, ae_);
            CodeableConcept ah_ = ab_?.DischargeDisposition;
            CqlConcept ai_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ah_);
            CqlValueSet aj_ = this.Hospice_Care_Referral_or_Admission(context);
            bool? ak_ = context.Operators.ConceptInValueSet(ai_, aj_);
            bool? al_ = context.Operators.Or(af_, ak_);
            CodeableConcept an_ = ab_?.DischargeDisposition;
            CqlConcept ao_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, an_);
            CqlValueSet ap_ = this.Patient_Expired(context);
            bool? aq_ = context.Operators.ConceptInValueSet(ao_, ap_);
            bool? ar_ = context.Operators.Or(al_, aq_);
            CodeableConcept at_ = ab_?.DischargeDisposition;
            CqlConcept au_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, at_);
            CqlValueSet av_ = this.Left_Against_Medical_Advice(context);
            bool? aw_ = context.Operators.ConceptInValueSet(au_, av_);
            bool? ax_ = context.Operators.Or(ar_, aw_);
            bool? ay_ = context.Operators.Or(aa_, ax_);
            return ay_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -8233428871904802123L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 6431907323170134029L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -4462710836571348549L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 1755239228573560717L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
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
