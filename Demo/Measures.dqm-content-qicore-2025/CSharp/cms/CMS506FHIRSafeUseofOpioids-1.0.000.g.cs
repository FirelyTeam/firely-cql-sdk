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
                    CqlValueSet s_ = this.Schedule_II__III_and_IV_Opioid_Medications(context);
                    bool? t_ = context.Operators.ConceptInValueSet(r_, s_);
                    return p_ & t_;
                }
            }

            bool? k_ = context.Operators.WhereAny<Medication>(i_, j_);
            return k_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Schedule_II__III_and_IV_Opioid_Medications(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest OpioidMedications) {
            bool? u_ = QICoreCommon_4_0_000.Instance.isCommunity(context, OpioidMedications as MedicationRequest);
            bool? v_;
            // CQL 'or' (59:11-61:5): right operand skipped when left is true
            if (u_ is true)
            {
                v_ = true;
            }
            else
            {
                bool? x_ = QICoreCommon_4_0_000.Instance.isDischarge(context, OpioidMedications as MedicationRequest);
                v_ = u_ | x_;
            }
            bool? w_;
            // CQL 'and' (59:11-62:63): right operand skipped when left is false
            if (v_ is false)
            {
                w_ = false;
            }
            else
            {
                Code<MedicationRequest.MedicationrequestStatus> y_ = OpioidMedications?.StatusElement;
                MedicationRequest.MedicationrequestStatus? z_ = y_?.Value;
                string aa_ = context.Operators.Convert<string>(z_);
                string[] ab_ = [
                    "active",
                    "completed",
                ];
                bool? ac_ = context.Operators.In<string>(aa_, (IEnumerable<string>)ab_);
                w_ = v_ & ac_;
            }
            // CQL 'and' (59:5-63:117): right operand skipped when left is false
            if (w_ is false)
            {
                return false;
            }
            else
            {
                Code<MedicationRequest.MedicationRequestIntent> ad_ = OpioidMedications?.IntentElement;
                MedicationRequest.MedicationRequestIntent? ae_ = ad_?.Value;
                string af_ = context.Operators.Convert<string>(ae_);
                string[] ag_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                bool? ah_ = context.Operators.In<string>(af_, (IEnumerable<string>)ag_);
                return w_ & ah_;
            }
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
                    CqlValueSet s_ = this.Schedule_IV_Benzodiazepines(context);
                    bool? t_ = context.Operators.ConceptInValueSet(r_, s_);
                    return p_ & t_;
                }
            }

            bool? k_ = context.Operators.WhereAny<Medication>(i_, j_);
            return k_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Schedule_IV_Benzodiazepines(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest BenzoMedications) {
            bool? u_ = QICoreCommon_4_0_000.Instance.isCommunity(context, BenzoMedications as MedicationRequest);
            bool? v_;
            // CQL 'or' (51:11-53:5): right operand skipped when left is true
            if (u_ is true)
            {
                v_ = true;
            }
            else
            {
                bool? x_ = QICoreCommon_4_0_000.Instance.isDischarge(context, BenzoMedications as MedicationRequest);
                v_ = u_ | x_;
            }
            bool? w_;
            // CQL 'and' (51:11-54:62): right operand skipped when left is false
            if (v_ is false)
            {
                w_ = false;
            }
            else
            {
                Code<MedicationRequest.MedicationrequestStatus> y_ = BenzoMedications?.StatusElement;
                MedicationRequest.MedicationrequestStatus? z_ = y_?.Value;
                string aa_ = context.Operators.Convert<string>(z_);
                string[] ab_ = [
                    "active",
                    "completed",
                ];
                bool? ac_ = context.Operators.In<string>(aa_, (IEnumerable<string>)ab_);
                w_ = v_ & ac_;
            }
            // CQL 'and' (51:5-55:116): right operand skipped when left is false
            if (w_ is false)
            {
                return false;
            }
            else
            {
                Code<MedicationRequest.MedicationRequestIntent> ad_ = BenzoMedications?.IntentElement;
                MedicationRequest.MedicationRequestIntent? ae_ = ad_?.Value;
                string af_ = context.Operators.Convert<string>(ae_);
                string[] ag_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                bool? ah_ = context.Operators.In<string>(af_, (IEnumerable<string>)ag_);
                return w_ & ah_;
            }
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
                FhirDateTime i_ = OpioidOrBenzodiazepineAtDischarge?.AuthoredOnElement;
                CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
                Period k_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                bool? m_ = context.Operators.In<CqlDateTime>(j_, l_, "day");
                return m_;
            }

            bool? h_ = context.Operators.WhereAny<MedicationRequest>(f_, g_);
            return h_;
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
                FhirDateTime k_ = OpioidMedications?.AuthoredOnElement;
                CqlDateTime l_ = context.Operators.Convert<CqlDateTime>(k_);
                Period m_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                bool? o_ = context.Operators.In<CqlDateTime>(l_, n_, "day");
                return o_;
            }


            object f_(MedicationRequest OpioidMedications) {
                DataType p_ = OpioidMedications?.Medication;
                object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                return q_;
            }

            IEnumerable<object> g_ = context.Operators.WhereSelect<MedicationRequest, object>(d_, e_, f_);
            IEnumerable<object> h_ = context.Operators.Distinct<object>(g_);
            int? i_ = context.Operators.Count<object>(h_);
            bool? j_ = context.Operators.GreaterOrEqual(i_, 2);
            // CQL 'or' (72:5-82:7): right operand skipped when left is true
            if (j_ is true)
            {
                return true;
            }
            else
            {

                bool? r_(MedicationRequest OpioidDischargeMedications) {
                    FhirDateTime t_ = OpioidDischargeMedications?.AuthoredOnElement;
                    CqlDateTime u_ = context.Operators.Convert<CqlDateTime>(t_);
                    Period v_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, v_);
                    bool? x_ = context.Operators.In<CqlDateTime>(u_, w_, "day");
                    // CQL 'and' (78:11-81:13): right operand skipped when left is false
                    if (x_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        IEnumerable<MedicationRequest> y_ = this.Benzodiazepine_At_Discharge(context);

                        bool? z_(MedicationRequest BenzodiazepineDischargeMedication) {
                            FhirDateTime ab_ = BenzodiazepineDischargeMedication?.AuthoredOnElement;
                            CqlDateTime ac_ = context.Operators.Convert<CqlDateTime>(ab_);
                            Period ad_ = InpatientEncounter?.Period;
                            CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ad_);
                            bool? af_ = context.Operators.In<CqlDateTime>(ac_, ae_, "day");
                            return af_;
                        }

                        bool? aa_ = context.Operators.WhereAny<MedicationRequest>(y_, z_);
                        return x_ & aa_;
                    }
                }

                bool? s_ = context.Operators.WhereAny<MedicationRequest>(d_, r_);
                return j_ | s_;
            }
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
                CqlConcept i_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return i_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.Cancer_Related_Pain(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            // CQL 'or' (86:5-87:81): right operand skipped when left is true
            if (h_ is true)
            {
                return true;
            }
            else
            {
                IEnumerable<Condition> j_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, QualifyingEncounter);

                bool? k_(Condition @this) {
                    CodeableConcept o_ = @this?.Code;
                    CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, o_);
                    return !((bool?)(p_ is null));
                }


                CqlConcept l_(Condition @this) {
                    CodeableConcept q_ = @this?.Code;
                    CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                    return r_;
                }

                IEnumerable<CqlConcept> m_ = context.Operators.WhereSelect<Condition, CqlConcept>(j_, k_, l_);
                bool? n_ = context.Operators.ConceptsInValueSet(m_, g_);
                return h_ | n_;
            }
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
        CqlCode c_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept d_ = context.Operators.ConvertCodeToConcept(c_);
        bool? e_ = context.Operators.Equivalent(b_, d_);
        bool? f_;
        // CQL 'or' (165:54-166:66): right operand skipped when left is true
        if (e_ is true)
        {
            f_ = true;
        }
        else
        {
            CqlCode j_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
            CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
            bool? l_ = context.Operators.Equivalent(b_, k_);
            f_ = e_ | l_;
        }
        bool? g_;
        // CQL 'or' (165:54-167:66): right operand skipped when left is true
        if (f_ is true)
        {
            g_ = true;
        }
        else
        {
            CqlCode m_ = QICoreCommon_4_0_000.Instance.provisional(context);
            CqlConcept n_ = context.Operators.ConvertCodeToConcept(m_);
            bool? o_ = context.Operators.Equivalent(b_, n_);
            g_ = f_ | o_;
        }
        bool? h_;
        // CQL 'or' (165:52-169:3): right operand skipped when left is true
        if (g_ is true)
        {
            h_ = true;
        }
        else
        {
            CqlCode p_ = QICoreCommon_4_0_000.Instance.differential(context);
            CqlConcept q_ = context.Operators.ConvertCodeToConcept(p_);
            bool? r_ = context.Operators.Equivalent(b_, q_);
            h_ = g_ | r_;
        }
        bool? i_ = context.Operators.Implies(!((bool?)(b_ is null)), h_);
        return i_;
    }


    [CqlExpressionDefinition("Medications For Opioid Use Disorder")]
    public IEnumerable<MedicationRequest> Medications_For_Opioid_Use_Disorder(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Medications_For_Opioid_Use_Disorder, Medications_For_Opioid_Use_Disorder_Compute);

    private const long _cacheIndex_Medications_For_Opioid_Use_Disorder = 8810620530117923890L;

    private IEnumerable<MedicationRequest> Medications_For_Opioid_Use_Disorder_Compute(CqlContext context)
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
                    CqlValueSet s_ = this.Medications_for_Opioid_Use_Disorder__MOUD_(context);
                    bool? t_ = context.Operators.ConceptInValueSet(r_, s_);
                    return p_ & t_;
                }
            }

            bool? k_ = context.Operators.WhereAny<Medication>(i_, j_);
            return k_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Medications_for_Opioid_Use_Disorder__MOUD_(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest DischargeMedication) {
            bool? u_ = QICoreCommon_4_0_000.Instance.isCommunity(context, DischargeMedication as MedicationRequest);
            bool? v_;
            // CQL 'or' (133:11-135:5): right operand skipped when left is true
            if (u_ is true)
            {
                v_ = true;
            }
            else
            {
                bool? x_ = QICoreCommon_4_0_000.Instance.isDischarge(context, DischargeMedication as MedicationRequest);
                v_ = u_ | x_;
            }
            bool? w_;
            // CQL 'and' (133:11-136:65): right operand skipped when left is false
            if (v_ is false)
            {
                w_ = false;
            }
            else
            {
                Code<MedicationRequest.MedicationrequestStatus> y_ = DischargeMedication?.StatusElement;
                MedicationRequest.MedicationrequestStatus? z_ = y_?.Value;
                string aa_ = context.Operators.Convert<string>(z_);
                string[] ab_ = [
                    "active",
                    "completed",
                ];
                bool? ac_ = context.Operators.In<string>(aa_, (IEnumerable<string>)ab_);
                w_ = v_ & ac_;
            }
            // CQL 'and' (133:5-137:119): right operand skipped when left is false
            if (w_ is false)
            {
                return false;
            }
            else
            {
                Code<MedicationRequest.MedicationRequestIntent> ad_ = DischargeMedication?.IntentElement;
                MedicationRequest.MedicationRequestIntent? ae_ = ad_?.Value;
                string af_ = context.Operators.Convert<string>(ae_);
                string[] ag_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                bool? ah_ = context.Operators.In<string>(af_, (IEnumerable<string>)ag_);
                return w_ & ah_;
            }
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
                FhirDateTime k_ = MedicationTreatment?.AuthoredOnElement;
                CqlDateTime l_ = context.Operators.Convert<CqlDateTime>(k_);
                object m_;
                DataType q_ = MAT?.Performed;
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                bool s_ = r_ is CqlDateTime;
                if (s_)
                {
                    DataType t_ = MAT?.Performed;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    m_ = u_ as CqlDateTime;
                }
                else
                {
                    DataType v_ = MAT?.Performed;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlQuantity;
                    if (x_)
                    {
                        DataType y_ = MAT?.Performed;
                        object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                        m_ = z_ as CqlQuantity;
                    }
                    else
                    {
                        DataType aa_ = MAT?.Performed;
                        object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        bool ac_ = ab_ is CqlInterval<CqlDateTime>;
                        if (ac_)
                        {
                            DataType ad_ = MAT?.Performed;
                            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                            m_ = ae_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType af_ = MAT?.Performed;
                            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                            bool ah_ = ag_ is CqlInterval<CqlQuantity>;
                            if (ah_)
                            {
                                DataType ai_ = MAT?.Performed;
                                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                                m_ = aj_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                m_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
                bool? o_ = context.Operators.In<CqlDateTime>(l_, n_, "day");
                bool? p_;
                // CQL 'and' (120:19-121:79): right operand skipped when left is false
                if (o_ is false)
                {
                    p_ = false;
                }
                else
                {
                    CqlInterval<CqlDateTime> ak_ = this.Measurement_Period(context);
                    bool? al_ = context.Operators.In<CqlDateTime>(l_, ak_, "day");
                    p_ = o_ & al_;
                }
                // CQL 'and' (120:19-122:58): right operand skipped when left is false
                if (p_ is false)
                {
                    return false;
                }
                else
                {
                    Code<EventStatus> am_ = MAT?.StatusElement;
                    EventStatus? an_ = am_?.Value;
                    string ao_ = context.Operators.Convert<string>(an_);
                    string[] ap_ = [
                        "completed",
                        "in-progress",
                    ];
                    bool? aq_ = context.Operators.In<string>(ao_, (IEnumerable<string>)ap_);
                    return p_ & aq_;
                }
            }

            bool? j_ = context.Operators.WhereAny<Procedure>(h_, i_);
            return j_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);

        bool? d_(MedicationRequest MedicationTreatment) {
            CqlValueSet ar_ = this.Opioid_Use_Disorder(context);
            IEnumerable<Condition> as_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ar_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? at_(Condition OUD) {
                FhirDateTime av_ = MedicationTreatment?.AuthoredOnElement;
                CqlDateTime aw_ = context.Operators.Convert<CqlDateTime>(av_);
                CqlInterval<CqlDateTime> ax_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, OUD as Condition);
                bool? ay_ = context.Operators.In<CqlDateTime>(aw_, ax_, "day");
                bool? az_;
                // CQL 'and' (126:21-127:79): right operand skipped when left is false
                if (ay_ is false)
                {
                    az_ = false;
                }
                else
                {
                    CqlInterval<CqlDateTime> ba_ = this.Measurement_Period(context);
                    bool? bb_ = context.Operators.Overlaps(ax_, ba_, "day");
                    az_ = ay_ & bb_;
                }
                // CQL 'and' (126:21-128:34): right operand skipped when left is false
                if (az_ is false)
                {
                    return false;
                }
                else
                {
                    bool? bc_ = this.isVerified(context, OUD as Condition);
                    return az_ & bc_;
                }
            }

            bool? au_ = context.Operators.WhereAny<Condition>(as_, at_);
            return au_;
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
                CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, CancerPain as Condition);
                Period m_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                bool? o_ = context.Operators.Overlaps(l_, n_, "day");
                // CQL 'and' (97:9-98:39): right operand skipped when left is false
                if (o_ is false)
                {
                    return false;
                }
                else
                {
                    bool? p_ = this.isVerified(context, CancerPain as Condition);
                    return o_ & p_;
                }
            }

            bool? g_ = context.Operators.WhereAny<Condition>(e_, f_);
            bool? h_;
            // CQL 'or' (96:11-100:81): right operand skipped when left is true
            if (g_ is true)
            {
                h_ = true;
            }
            else
            {
                IEnumerable<Encounter> q_ = this.Inpatient_Encounter_With_Encounter_Diagnosis_Of_Cancer_Pain(context);
                bool? r_ = context.Operators.Exists<Encounter>(q_);
                h_ = g_ | r_;
            }
            bool? i_;
            // CQL 'or' (96:11-104:7): right operand skipped when left is true
            if (h_ is true)
            {
                i_ = true;
            }
            else
            {
                CqlValueSet s_ = this.Sickle_Cell_Disease_with_and_without_Crisis(context);
                IEnumerable<Condition> t_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

                bool? u_(Condition SickleCellDisease) {
                    CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, SickleCellDisease as Condition);
                    Period x_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, x_);
                    bool? z_ = context.Operators.Overlaps(w_, y_, "day");
                    // CQL 'and' (102:11-103:48): right operand skipped when left is false
                    if (z_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        bool? aa_ = this.isVerified(context, SickleCellDisease as Condition);
                        return z_ & aa_;
                    }
                }

                bool? v_ = context.Operators.WhereAny<Condition>(t_, u_);
                i_ = h_ | v_;
            }
            bool? j_;
            // CQL 'or' (96:11-107:7): right operand skipped when left is true
            if (i_ is true)
            {
                j_ = true;
            }
            else
            {
                IEnumerable<MedicationRequest> ab_ = this.Treatment_For_Opioid_Use_Disorders(context);

                bool? ac_(MedicationRequest OUDTreatment) {
                    FhirDateTime ae_ = OUDTreatment?.AuthoredOnElement;
                    CqlDateTime af_ = context.Operators.Convert<CqlDateTime>(ae_);
                    Period ag_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
                    bool? ai_ = context.Operators.In<CqlDateTime>(af_, ah_, "day");
                    return ai_;
                }

                bool? ad_ = context.Operators.WhereAny<MedicationRequest>(ab_, ac_);
                j_ = i_ | ad_;
            }
            bool? k_;
            // CQL 'or' (96:11-110:7): right operand skipped when left is true
            if (j_ is true)
            {
                k_ = true;
            }
            else
            {
                IEnumerable<object> aj_ = this.Intervention_Palliative_Or_Hospice_Care(context);

                bool? ak_(object PalliativeOrHospiceCare) {
                    object am_;
                    object at_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    bool av_ = au_ is CqlDateTime;
                    if (av_)
                    {
                        object aw_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                        object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                        am_ = ax_ as CqlDateTime;
                    }
                    else
                    {
                        object ay_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                        object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                        bool ba_ = az_ is CqlQuantity;
                        if (ba_)
                        {
                            object bb_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                            object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                            am_ = bc_ as CqlQuantity;
                        }
                        else
                        {
                            object bd_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                            object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                            bool bf_ = be_ is CqlInterval<CqlDateTime>;
                            if (bf_)
                            {
                                object bg_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                                object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                                am_ = bh_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                object bi_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                                object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                                bool bk_ = bj_ is CqlInterval<CqlQuantity>;
                                if (bk_)
                                {
                                    object bl_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                                    am_ = bm_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    am_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> an_ = QICoreCommon_4_0_000.Instance.toInterval(context, am_);
                    CqlDateTime ao_ = context.Operators.Start(an_);
                    object ap_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "authoredOn");
                    CqlDateTime aq_ = context.Operators.LateBoundProperty<CqlDateTime>(ap_, "value");
                    CqlInterval<CqlDateTime> ar_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
                    bool? as_ = context.Operators.In<CqlDateTime>(ao_ ?? aq_, ar_, (string)default);
                    return as_;
                }

                bool? al_ = context.Operators.WhereAny<object>(aj_, ak_);
                k_ = j_ | al_;
            }
            // CQL 'or' (96:5-115:7): right operand skipped when left is true
            if (k_ is true)
            {
                return true;
            }
            else
            {
                Encounter.HospitalizationComponent bn_ = InpatientEncounter?.Hospitalization;
                CodeableConcept bo_ = bn_?.DischargeDisposition;
                CqlConcept bp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bo_);
                CqlValueSet bq_ = this.Discharge_To_Acute_Care_Facility(context);
                bool? br_ = context.Operators.ConceptInValueSet(bp_, bq_);
                bool? bs_;
                // CQL 'or' (111:12-112:108): right operand skipped when left is true
                if (br_ is true)
                {
                    bs_ = true;
                }
                else
                {
                    CqlValueSet bv_ = this.Hospice_Care_Referral_or_Admission(context);
                    bool? bw_ = context.Operators.ConceptInValueSet(bp_, bv_);
                    bs_ = br_ | bw_;
                }
                bool? bt_;
                // CQL 'or' (111:12-113:89): right operand skipped when left is true
                if (bs_ is true)
                {
                    bt_ = true;
                }
                else
                {
                    CqlValueSet bx_ = this.Patient_Expired(context);
                    bool? by_ = context.Operators.ConceptInValueSet(bp_, bx_);
                    bt_ = bs_ | by_;
                }
                bool? bu_;
                // CQL 'or' (111:10-115:7): right operand skipped when left is true
                if (bt_ is true)
                {
                    bu_ = true;
                }
                else
                {
                    CqlValueSet bz_ = this.Left_Against_Medical_Advice(context);
                    bool? ca_ = context.Operators.ConceptInValueSet(bp_, bz_);
                    bu_ = bt_ | ca_;
                }
                return k_ | bu_;
            }
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
