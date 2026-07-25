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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.4.0")]
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
                FhirDateTime p_ = OpioidMedications?.AuthoredOnElement;
                CqlDateTime q_ = context.Operators.Convert<CqlDateTime>(p_);
                Period r_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                bool? t_ = context.Operators.In<CqlDateTime>(q_, s_, "day");
                return t_;
            }

            IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);

            object g_(MedicationRequest OpioidMedications) {
                DataType u_ = OpioidMedications?.Medication;
                object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                return v_;
            }

            IEnumerable<object> h_ = context.Operators.Select<MedicationRequest, object>(f_, g_);
            IEnumerable<object> i_ = context.Operators.Distinct<object>(h_);
            int? j_ = context.Operators.Count<object>(i_);
            bool? k_ = context.Operators.GreaterOrEqual(j_, 2);

            bool? l_(MedicationRequest OpioidDischargeMedications) {
                FhirDateTime w_ = OpioidDischargeMedications?.AuthoredOnElement;
                CqlDateTime x_ = context.Operators.Convert<CqlDateTime>(w_);
                Period y_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
                bool? aa_ = context.Operators.In<CqlDateTime>(x_, z_, "day");
                IEnumerable<MedicationRequest> ab_ = this.Benzodiazepine_At_Discharge(context);

                bool? ac_(MedicationRequest BenzodiazepineDischargeMedication) {
                    FhirDateTime ag_ = BenzodiazepineDischargeMedication?.AuthoredOnElement;
                    CqlDateTime ah_ = context.Operators.Convert<CqlDateTime>(ag_);
                    Period ai_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ai_);
                    bool? ak_ = context.Operators.In<CqlDateTime>(ah_, aj_, "day");
                    return ak_;
                }

                IEnumerable<MedicationRequest> ad_ = context.Operators.Where<MedicationRequest>(ab_, ac_);
                bool? ae_ = context.Operators.Exists<MedicationRequest>(ad_);
                bool? af_ = context.Operators.And(aa_, ae_);
                return af_;
            }

            IEnumerable<MedicationRequest> m_ = context.Operators.Where<MedicationRequest>(d_, l_);
            bool? n_ = context.Operators.Exists<MedicationRequest>(m_);
            bool? o_ = context.Operators.Or(k_, n_);
            return o_;
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
                CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return p_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.Cancer_Related_Pain(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<Condition> i_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, QualifyingEncounter);

            bool? j_(Condition @this) {
                CodeableConcept q_ = @this?.Code;
                CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                bool? s_ = context.Operators.Not((bool?)(r_ is null));
                return s_;
            }

            IEnumerable<Condition> k_ = context.Operators.Where<Condition>(i_, j_);

            CqlConcept l_(Condition @this) {
                CodeableConcept t_ = @this?.Code;
                CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                return u_;
            }

            IEnumerable<CqlConcept> m_ = context.Operators.Select<Condition, CqlConcept>(k_, l_);
            bool? n_ = context.Operators.ConceptsInValueSet(m_, g_);
            bool? o_ = context.Operators.Or(h_, n_);
            return o_;
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
            CqlValueSet g_ = this.Opioid_Medication_Assisted_Treatment__MAT_(context);
            IEnumerable<Procedure> h_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? i_(Procedure MAT) {
                FhirDateTime l_ = MedicationTreatment?.AuthoredOnElement;
                CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(l_);

                object n_() {

                    bool z_() {
                        DataType ad_ = MAT?.Performed;
                        object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                        bool af_ = ae_ is CqlDateTime;
                        return af_;
                    }


                    bool aa_() {
                        DataType ag_ = MAT?.Performed;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        bool ai_ = ah_ is CqlInterval<CqlDateTime>;
                        return ai_;
                    }


                    bool ab_() {
                        DataType aj_ = MAT?.Performed;
                        object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                        bool al_ = ak_ is CqlQuantity;
                        return al_;
                    }


                    bool ac_() {
                        DataType am_ = MAT?.Performed;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        bool ao_ = an_ is CqlInterval<CqlQuantity>;
                        return ao_;
                    }

                    if (z_())
                    {
                        DataType ap_ = MAT?.Performed;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        return aq_ as CqlDateTime;
                    }
                    else if (aa_())
                    {
                        DataType ar_ = MAT?.Performed;
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        return as_ as CqlInterval<CqlDateTime>;
                    }
                    else if (ab_())
                    {
                        DataType at_ = MAT?.Performed;
                        object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                        return au_ as CqlQuantity;
                    }
                    else if (ac_())
                    {
                        DataType av_ = MAT?.Performed;
                        object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        return aw_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_());
                bool? p_ = context.Operators.In<CqlDateTime>(m_, o_, "day");
                CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
                bool? r_ = context.Operators.In<CqlDateTime>(m_, q_, "day");
                bool? s_ = context.Operators.And(p_, r_);
                Code<EventStatus> t_ = MAT?.StatusElement;
                EventStatus? u_ = t_?.Value;
                string v_ = context.Operators.Convert<string>(u_);
                string[] w_ = [
                    "completed",
                    "in-progress",
                ];
                bool? x_ = context.Operators.In<string>(v_, (IEnumerable<string>)w_);
                bool? y_ = context.Operators.And(s_, x_);
                return y_;
            }

            IEnumerable<Procedure> j_ = context.Operators.Where<Procedure>(h_, i_);
            bool? k_ = context.Operators.Exists<Procedure>(j_);
            return k_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);

        bool? d_(MedicationRequest MedicationTreatment) {
            CqlValueSet ax_ = this.Opioid_Use_Disorder(context);
            IEnumerable<Condition> ay_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ax_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? az_(Condition OUD) {
                FhirDateTime bc_ = MedicationTreatment?.AuthoredOnElement;
                CqlDateTime bd_ = context.Operators.Convert<CqlDateTime>(bc_);
                CqlInterval<CqlDateTime> be_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, OUD as Condition);
                bool? bf_ = context.Operators.In<CqlDateTime>(bd_, be_, "day");
                CqlInterval<CqlDateTime> bg_ = this.Measurement_Period(context);
                bool? bh_ = context.Operators.Overlaps(be_, bg_, "day");
                bool? bi_ = context.Operators.And(bf_, bh_);
                bool? bj_ = this.isVerified(context, OUD as Condition);
                bool? bk_ = context.Operators.And(bi_, bj_);
                return bk_;
            }

            IEnumerable<Condition> ba_ = context.Operators.Where<Condition>(ay_, az_);
            bool? bb_ = context.Operators.Exists<Condition>(ba_);
            return bb_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(a_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);
        return f_;
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
            Code<RequestStatus> i_ = PalliativeOrHospiceCareOrder?.StatusElement;
            RequestStatus? j_ = i_?.Value;
            Code<RequestStatus> k_ = context.Operators.Convert<Code<RequestStatus>>(j_);
            string l_ = context.Operators.Convert<string>(k_);
            string[] m_ = [
                "active",
                "completed",
                "on-hold",
            ];
            bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            return n_;
        }

        IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);
        IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? f_(Procedure PalliativeOrHospiceCarePerformed) {
            Code<EventStatus> o_ = PalliativeOrHospiceCarePerformed?.StatusElement;
            EventStatus? p_ = o_?.Value;
            string q_ = context.Operators.Convert<string>(p_);
            string[] r_ = [
                "completed",
                "in-progress",
            ];
            bool? s_ = context.Operators.In<string>(q_, (IEnumerable<string>)r_);
            return s_;
        }

        IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
        IEnumerable<object> h_ = context.Operators.Union<object>(d_ as IEnumerable<object>, g_ as IEnumerable<object>);
        return h_;
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
                CqlInterval<CqlDateTime> aq_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, CancerPain as Condition);
                Period ar_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> as_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ar_);
                bool? at_ = context.Operators.Overlaps(aq_, as_, "day");
                bool? au_ = this.isVerified(context, CancerPain as Condition);
                bool? av_ = context.Operators.And(at_, au_);
                return av_;
            }

            IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
            bool? h_ = context.Operators.Exists<Condition>(g_);
            IEnumerable<Encounter> i_ = this.Inpatient_Encounter_With_Encounter_Diagnosis_Of_Cancer_Pain(context);
            bool? j_ = context.Operators.Exists<Encounter>(i_);
            bool? k_ = context.Operators.Or(h_, j_);
            CqlValueSet l_ = this.Sickle_Cell_Disease_with_and_without_Crisis(context);
            IEnumerable<Condition> m_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? n_(Condition SickleCellDisease) {
                CqlInterval<CqlDateTime> aw_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, SickleCellDisease as Condition);
                Period ax_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ay_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
                bool? az_ = context.Operators.Overlaps(aw_, ay_, "day");
                bool? ba_ = this.isVerified(context, SickleCellDisease as Condition);
                bool? bb_ = context.Operators.And(az_, ba_);
                return bb_;
            }

            IEnumerable<Condition> o_ = context.Operators.Where<Condition>(m_, n_);
            bool? p_ = context.Operators.Exists<Condition>(o_);
            bool? q_ = context.Operators.Or(k_, p_);
            IEnumerable<MedicationRequest> r_ = this.Treatment_For_Opioid_Use_Disorders(context);

            bool? s_(MedicationRequest OUDTreatment) {
                FhirDateTime bc_ = OUDTreatment?.AuthoredOnElement;
                CqlDateTime bd_ = context.Operators.Convert<CqlDateTime>(bc_);
                Period be_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> bf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, be_);
                bool? bg_ = context.Operators.In<CqlDateTime>(bd_, bf_, "day");
                return bg_;
            }

            IEnumerable<MedicationRequest> t_ = context.Operators.Where<MedicationRequest>(r_, s_);
            bool? u_ = context.Operators.Exists<MedicationRequest>(t_);
            bool? v_ = context.Operators.Or(q_, u_);
            IEnumerable<object> w_ = this.Intervention_Palliative_Or_Hospice_Care(context);

            bool? x_(object PalliativeOrHospiceCare) {

                object bh_() {

                    bool bo_() {
                        object bs_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                        object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                        bool bu_ = bt_ is CqlDateTime;
                        return bu_;
                    }


                    bool bp_() {
                        object bv_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                        object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                        bool bx_ = bw_ is CqlInterval<CqlDateTime>;
                        return bx_;
                    }


                    bool bq_() {
                        object by_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                        object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                        bool ca_ = bz_ is CqlQuantity;
                        return ca_;
                    }


                    bool br_() {
                        object cb_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                        object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                        bool cd_ = cc_ is CqlInterval<CqlQuantity>;
                        return cd_;
                    }

                    if (bo_())
                    {
                        object ce_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                        object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                        return cf_ as CqlDateTime;
                    }
                    else if (bp_())
                    {
                        object cg_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                        object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                        return ch_ as CqlInterval<CqlDateTime>;
                    }
                    else if (bq_())
                    {
                        object ci_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                        object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                        return cj_ as CqlQuantity;
                    }
                    else if (br_())
                    {
                        object ck_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                        return cl_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> bi_ = QICoreCommon_4_0_000.Instance.toInterval(context, bh_());
                CqlDateTime bj_ = context.Operators.Start(bi_);
                object bk_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "authoredOn");
                CqlDateTime bl_ = context.Operators.LateBoundProperty<CqlDateTime>(bk_, "value");
                CqlInterval<CqlDateTime> bm_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
                bool? bn_ = context.Operators.In<CqlDateTime>(bj_ ?? bl_, bm_, (string)default);
                return bn_;
            }

            IEnumerable<object> y_ = context.Operators.Where<object>(w_, x_);
            bool? z_ = context.Operators.Exists<object>(y_);
            bool? aa_ = context.Operators.Or(v_, z_);
            Encounter.HospitalizationComponent ab_ = InpatientEncounter?.Hospitalization;
            CodeableConcept ac_ = ab_?.DischargeDisposition;
            CqlConcept ad_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ac_);
            CqlValueSet ae_ = this.Discharge_To_Acute_Care_Facility(context);
            bool? af_ = context.Operators.ConceptInValueSet(ad_, ae_);
            CqlValueSet ag_ = this.Hospice_Care_Referral_or_Admission(context);
            bool? ah_ = context.Operators.ConceptInValueSet(ad_, ag_);
            bool? ai_ = context.Operators.Or(af_, ah_);
            CqlValueSet aj_ = this.Patient_Expired(context);
            bool? ak_ = context.Operators.ConceptInValueSet(ad_, aj_);
            bool? al_ = context.Operators.Or(ai_, ak_);
            CqlValueSet am_ = this.Left_Against_Medical_Advice(context);
            bool? an_ = context.Operators.ConceptInValueSet(ad_, am_);
            bool? ao_ = context.Operators.Or(al_, an_);
            bool? ap_ = context.Operators.Or(aa_, ao_);
            return ap_;
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
