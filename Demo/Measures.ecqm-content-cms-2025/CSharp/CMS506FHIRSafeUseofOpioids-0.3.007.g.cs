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
[CqlLibrary("CMS506FHIRSafeUseofOpioids", "0.3.007")]
public partial class CMS506FHIRSafeUseofOpioids_0_3_007 : ILibrary, ISingleton<CMS506FHIRSafeUseofOpioids_0_3_007>
{
    private CMS506FHIRSafeUseofOpioids_0_3_007() {}

    public static CMS506FHIRSafeUseofOpioids_0_3_007 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS506FHIRSafeUseofOpioids";
    public string Version => "0.3.007";
    public ILibrary[] Dependencies => [CQMCommon_4_1_000.Instance, FHIRHelpers_4_4_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

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

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2026, 12, 31, 23, 59, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS506FHIRSafeUseofOpioids-0.3.007", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
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


    [CqlExpressionDefinition("Inpatient Encounter With Age Greater Than Or Equal To 18")]
    public IEnumerable<Encounter> Inpatient_Encounter_With_Age_Greater_Than_Or_Equal_To_18(CqlContext context)
    {
        IEnumerable<Encounter> a_ = CQMCommon_4_1_000.Instance.Inpatient_Encounter(context);
        bool? b_(Encounter InpatientHospitalEncounter)
        {
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
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Opioid At Discharge")]
    public IEnumerable<MedicationRequest> Opioid_At_Discharge(CqlContext context)
    {
        CqlValueSet a_ = this.Schedule_II__III_and_IV_Opioid_Medications(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> d_(MedicationRequest MR)
        {
            IEnumerable<Medication> i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? j_(Medication M)
            {
                object n_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object o_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> p_ = context.Operators.Split((string)o_, "/");
                string q_ = context.Operators.Last<string>(p_);
                bool? r_ = context.Operators.Equal(n_, q_);
                CodeableConcept s_ = M?.Code;
                CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                CqlValueSet u_ = this.Schedule_II__III_and_IV_Opioid_Medications(context);
                bool? v_ = context.Operators.ConceptInValueSet(t_, u_);
                bool? w_ = context.Operators.And(r_, v_);

                return w_;
            };
            IEnumerable<Medication> k_ = context.Operators.Where<Medication>(i_, j_);
            MedicationRequest l_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> m_ = context.Operators.Select<Medication, MedicationRequest>(k_, l_);

            return m_;
        };
        IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        bool? g_(MedicationRequest OpioidMedications)
        {
            bool? x_ = QICoreCommon_4_0_000.Instance.isCommunity(context, OpioidMedications as object);
            bool? y_ = QICoreCommon_4_0_000.Instance.isDischarge(context, OpioidMedications as object);
            bool? z_ = context.Operators.Or(x_, y_);
            Code<MedicationRequest.MedicationrequestStatus> aa_ = OpioidMedications?.StatusElement;
            MedicationRequest.MedicationrequestStatus? ab_ = aa_?.Value;
            string ac_ = context.Operators.Convert<string>(ab_);
            string[] ad_ = [
                "active",
                "completed",
            ];
            bool? ae_ = context.Operators.In<string>(ac_, ad_ as IEnumerable<string>);
            bool? af_ = context.Operators.And(z_, ae_);
            Code<MedicationRequest.MedicationRequestIntent> ag_ = OpioidMedications?.IntentElement;
            MedicationRequest.MedicationRequestIntent? ah_ = ag_?.Value;
            string ai_ = context.Operators.Convert<string>(ah_);
            string[] aj_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? ak_ = context.Operators.In<string>(ai_, aj_ as IEnumerable<string>);
            bool? al_ = context.Operators.And(af_, ak_);

            return al_;
        };
        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);

        return h_;
    }


    [CqlExpressionDefinition("Benzodiazepine At Discharge")]
    public IEnumerable<MedicationRequest> Benzodiazepine_At_Discharge(CqlContext context)
    {
        CqlValueSet a_ = this.Schedule_IV_Benzodiazepines(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> d_(MedicationRequest MR)
        {
            IEnumerable<Medication> i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? j_(Medication M)
            {
                object n_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object o_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> p_ = context.Operators.Split((string)o_, "/");
                string q_ = context.Operators.Last<string>(p_);
                bool? r_ = context.Operators.Equal(n_, q_);
                CodeableConcept s_ = M?.Code;
                CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                CqlValueSet u_ = this.Schedule_IV_Benzodiazepines(context);
                bool? v_ = context.Operators.ConceptInValueSet(t_, u_);
                bool? w_ = context.Operators.And(r_, v_);

                return w_;
            };
            IEnumerable<Medication> k_ = context.Operators.Where<Medication>(i_, j_);
            MedicationRequest l_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> m_ = context.Operators.Select<Medication, MedicationRequest>(k_, l_);

            return m_;
        };
        IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        bool? g_(MedicationRequest BenzoMedications)
        {
            bool? x_ = QICoreCommon_4_0_000.Instance.isCommunity(context, BenzoMedications as object);
            bool? y_ = QICoreCommon_4_0_000.Instance.isDischarge(context, BenzoMedications as object);
            bool? z_ = context.Operators.Or(x_, y_);
            Code<MedicationRequest.MedicationrequestStatus> aa_ = BenzoMedications?.StatusElement;
            MedicationRequest.MedicationrequestStatus? ab_ = aa_?.Value;
            string ac_ = context.Operators.Convert<string>(ab_);
            string[] ad_ = [
                "active",
                "completed",
            ];
            bool? ae_ = context.Operators.In<string>(ac_, ad_ as IEnumerable<string>);
            bool? af_ = context.Operators.And(z_, ae_);
            Code<MedicationRequest.MedicationRequestIntent> ag_ = BenzoMedications?.IntentElement;
            MedicationRequest.MedicationRequestIntent? ah_ = ag_?.Value;
            string ai_ = context.Operators.Convert<string>(ah_);
            string[] aj_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? ak_ = context.Operators.In<string>(ai_, aj_ as IEnumerable<string>);
            bool? al_ = context.Operators.And(af_, ak_);

            return al_;
        };
        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);

        return h_;
    }


    [CqlExpressionDefinition("Inpatient Encounters With An Opioid Or Benzodiazepine At Discharge")]
    public IEnumerable<Encounter> Inpatient_Encounters_With_An_Opioid_Or_Benzodiazepine_At_Discharge(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounter_With_Age_Greater_Than_Or_Equal_To_18(context);
        IEnumerable<Encounter> b_(Encounter InpatientEncounter)
        {
            IEnumerable<MedicationRequest> d_ = this.Opioid_At_Discharge(context);
            IEnumerable<MedicationRequest> e_ = this.Benzodiazepine_At_Discharge(context);
            IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(d_, e_);
            bool? g_(MedicationRequest OpioidOrBenzodiazepineAtDischarge)
            {
                FhirDateTime k_ = OpioidOrBenzodiazepineAtDischarge?.AuthoredOnElement;
                CqlDateTime l_ = context.Operators.Convert<CqlDateTime>(k_);
                Period m_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                bool? o_ = context.Operators.In<CqlDateTime>(l_, n_, "day");

                return o_;
            };
            IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
            Encounter i_(MedicationRequest OpioidOrBenzodiazepineAtDischarge) =>
                InpatientEncounter;
            IEnumerable<Encounter> j_ = context.Operators.Select<MedicationRequest, Encounter>(h_, i_);

            return j_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters_With_An_Opioid_Or_Benzodiazepine_At_Discharge(context);

        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);
        bool? b_(Encounter InpatientEncounter)
        {
            IEnumerable<MedicationRequest> d_ = this.Opioid_At_Discharge(context);
            bool? e_(MedicationRequest OpioidMedications)
            {
                FhirDateTime q_ = OpioidMedications?.AuthoredOnElement;
                CqlDateTime r_ = context.Operators.Convert<CqlDateTime>(q_);
                Period s_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, s_);
                bool? u_ = context.Operators.In<CqlDateTime>(r_, t_, "day");

                return u_;
            };
            IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
            object g_(MedicationRequest OpioidMedications)
            {
                DataType v_ = OpioidMedications?.Medication;
                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);

                return w_;
            };
            IEnumerable<object> h_ = context.Operators.Select<MedicationRequest, object>(f_, g_);
            IEnumerable<object> i_ = context.Operators.Distinct<object>(h_);
            int? j_ = context.Operators.Count<object>(i_);
            bool? k_ = context.Operators.GreaterOrEqual(j_, 2);
            bool? m_(MedicationRequest OpioidDischargeMedications)
            {
                FhirDateTime x_ = OpioidDischargeMedications?.AuthoredOnElement;
                CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(x_);
                Period z_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
                bool? ab_ = context.Operators.In<CqlDateTime>(y_, aa_, "day");
                IEnumerable<MedicationRequest> ac_ = this.Benzodiazepine_At_Discharge(context);
                bool? ad_(MedicationRequest BenzodiazepineDischargeMedication)
                {
                    FhirDateTime ah_ = BenzodiazepineDischargeMedication?.AuthoredOnElement;
                    CqlDateTime ai_ = context.Operators.Convert<CqlDateTime>(ah_);
                    Period aj_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aj_);
                    bool? al_ = context.Operators.In<CqlDateTime>(ai_, ak_, "day");

                    return al_;
                };
                IEnumerable<MedicationRequest> ae_ = context.Operators.Where<MedicationRequest>(ac_, ad_);
                bool? af_ = context.Operators.Exists<MedicationRequest>(ae_);
                bool? ag_ = context.Operators.And(ab_, af_);

                return ag_;
            };
            IEnumerable<MedicationRequest> n_ = context.Operators.Where<MedicationRequest>(d_, m_);
            bool? o_ = context.Operators.Exists<MedicationRequest>(n_);
            bool? p_ = context.Operators.Or(k_, o_);

            return p_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Inpatient Encounter With Encounter Diagnosis Of Cancer Pain")]
    public IEnumerable<Encounter> Inpatient_Encounter_With_Encounter_Diagnosis_Of_Cancer_Pain(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);
        bool? b_(Encounter QualifyingEncounter)
        {
            List<CodeableConcept> d_ = QualifyingEncounter?.ReasonCode;
            CqlConcept e_(CodeableConcept @this)
            {
                CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return q_;
            };
            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.Cancer_Related_Pain(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<object> i_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, QualifyingEncounter);
            bool? j_(object @this)
            {
                object r_ = context.Operators.LateBoundProperty<object>(@this, "code");
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_ as CodeableConcept);
                bool? t_ = context.Operators.Not((bool?)(s_ is null));

                return t_;
            };
            IEnumerable<object> k_ = context.Operators.Where<object>(i_, j_);
            CqlConcept l_(object @this)
            {
                object u_ = context.Operators.LateBoundProperty<object>(@this, "code");
                CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_ as CodeableConcept);

                return v_;
            };
            IEnumerable<CqlConcept> m_ = context.Operators.Select<object, CqlConcept>(k_, l_);
            bool? o_ = context.Operators.ConceptsInValueSet(m_, g_);
            bool? p_ = context.Operators.Or(h_, o_);

            return p_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Medications For Opioid Use Disorder")]
    public IEnumerable<MedicationRequest> Medications_For_Opioid_Use_Disorder(CqlContext context)
    {
        CqlValueSet a_ = this.Medications_for_Opioid_Use_Disorder__MOUD_(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> d_(MedicationRequest MR)
        {
            IEnumerable<Medication> i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? j_(Medication M)
            {
                object n_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object o_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> p_ = context.Operators.Split((string)o_, "/");
                string q_ = context.Operators.Last<string>(p_);
                bool? r_ = context.Operators.Equal(n_, q_);
                CodeableConcept s_ = M?.Code;
                CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                CqlValueSet u_ = this.Medications_for_Opioid_Use_Disorder__MOUD_(context);
                bool? v_ = context.Operators.ConceptInValueSet(t_, u_);
                bool? w_ = context.Operators.And(r_, v_);

                return w_;
            };
            IEnumerable<Medication> k_ = context.Operators.Where<Medication>(i_, j_);
            MedicationRequest l_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> m_ = context.Operators.Select<Medication, MedicationRequest>(k_, l_);

            return m_;
        };
        IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        bool? g_(MedicationRequest DischargeMedication)
        {
            bool? x_ = QICoreCommon_4_0_000.Instance.isCommunity(context, DischargeMedication as object);
            bool? y_ = QICoreCommon_4_0_000.Instance.isDischarge(context, DischargeMedication as object);
            bool? z_ = context.Operators.Or(x_, y_);
            Code<MedicationRequest.MedicationrequestStatus> aa_ = DischargeMedication?.StatusElement;
            MedicationRequest.MedicationrequestStatus? ab_ = aa_?.Value;
            string ac_ = context.Operators.Convert<string>(ab_);
            string[] ad_ = [
                "active",
                "completed",
            ];
            bool? ae_ = context.Operators.In<string>(ac_, ad_ as IEnumerable<string>);
            bool? af_ = context.Operators.And(z_, ae_);
            Code<MedicationRequest.MedicationRequestIntent> ag_ = DischargeMedication?.IntentElement;
            MedicationRequest.MedicationRequestIntent? ah_ = ag_?.Value;
            string ai_ = context.Operators.Convert<string>(ah_);
            string[] aj_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? ak_ = context.Operators.In<string>(ai_, aj_ as IEnumerable<string>);
            bool? al_ = context.Operators.And(af_, ak_);

            return al_;
        };
        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);

        return h_;
    }


    [CqlExpressionDefinition("Treatment For Opioid Use Disorders")]
    public IEnumerable<MedicationRequest> Treatment_For_Opioid_Use_Disorders(CqlContext context)
    {
        IEnumerable<MedicationRequest> a_ = this.Medications_For_Opioid_Use_Disorder(context);
        IEnumerable<MedicationRequest> b_(MedicationRequest MedicationTreatment)
        {
            CqlValueSet h_ = this.Opioid_Medication_Assisted_Treatment__MAT_(context);
            IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? j_(Procedure MAT)
            {
                FhirDateTime n_ = MedicationTreatment?.AuthoredOnElement;
                CqlDateTime o_ = context.Operators.Convert<CqlDateTime>(n_);
                object p_()
                {
                    bool ad_()
                    {
                        DataType ah_ = MAT?.Performed;
                        object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                        bool aj_ = ai_ is CqlDateTime;

                        return aj_;
                    };
                    bool ae_()
                    {
                        DataType ak_ = MAT?.Performed;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        bool am_ = al_ is CqlInterval<CqlDateTime>;

                        return am_;
                    };
                    bool af_()
                    {
                        DataType an_ = MAT?.Performed;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        bool ap_ = ao_ is CqlQuantity;

                        return ap_;
                    };
                    bool ag_()
                    {
                        DataType aq_ = MAT?.Performed;
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        bool as_ = ar_ is CqlInterval<CqlQuantity>;

                        return as_;
                    };
                    if (ad_())
                    {
                        DataType at_ = MAT?.Performed;
                        object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);

                        return (au_ as CqlDateTime) as object;
                    }
                    else if (ae_())
                    {
                        DataType av_ = MAT?.Performed;
                        object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);

                        return (aw_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (af_())
                    {
                        DataType ax_ = MAT?.Performed;
                        object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);

                        return (ay_ as CqlQuantity) as object;
                    }
                    else if (ag_())
                    {
                        DataType az_ = MAT?.Performed;
                        object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);

                        return (ba_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_());
                bool? r_ = context.Operators.In<CqlDateTime>(o_, q_, "day");
                CqlDateTime t_ = context.Operators.Convert<CqlDateTime>(n_);
                CqlInterval<CqlDateTime> u_ = this.Measurement_Period(context);
                bool? v_ = context.Operators.In<CqlDateTime>(t_, u_, "day");
                bool? w_ = context.Operators.And(r_, v_);
                Code<EventStatus> x_ = MAT?.StatusElement;
                EventStatus? y_ = x_?.Value;
                string z_ = context.Operators.Convert<string>(y_);
                string[] aa_ = [
                    "completed",
                    "in-progress",
                ];
                bool? ab_ = context.Operators.In<string>(z_, aa_ as IEnumerable<string>);
                bool? ac_ = context.Operators.And(w_, ab_);

                return ac_;
            };
            IEnumerable<Procedure> k_ = context.Operators.Where<Procedure>(i_, j_);
            MedicationRequest l_(Procedure MAT) =>
                MedicationTreatment;
            IEnumerable<MedicationRequest> m_ = context.Operators.Select<Procedure, MedicationRequest>(k_, l_);

            return m_;
        };
        IEnumerable<MedicationRequest> c_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(a_, b_);
        IEnumerable<MedicationRequest> e_(MedicationRequest MedicationTreatment)
        {
            CqlValueSet bb_ = this.Opioid_Use_Disorder(context);
            IEnumerable<Condition> bc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            bool? bd_(Condition OUD)
            {
                FhirDateTime bh_ = MedicationTreatment?.AuthoredOnElement;
                CqlDateTime bi_ = context.Operators.Convert<CqlDateTime>(bh_);
                CqlInterval<CqlDateTime> bj_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, OUD as object);
                bool? bk_ = context.Operators.In<CqlDateTime>(bi_, bj_, "day");
                CqlInterval<CqlDateTime> bm_ = this.Measurement_Period(context);
                bool? bn_ = context.Operators.Overlaps(bj_, bm_, "day");
                bool? bo_ = context.Operators.And(bk_, bn_);
                CodeableConcept bp_ = OUD?.VerificationStatus;
                CqlConcept bq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bp_);
                bool? br_ = context.Operators.Not((bool?)(bq_ is null));
                CqlConcept bt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bp_);
                CqlCode bu_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept bv_ = context.Operators.ConvertCodeToConcept(bu_);
                bool? bw_ = context.Operators.Equivalent(bt_, bv_);
                bool? bx_ = context.Operators.Not(bw_);
                CqlConcept bz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bp_);
                CqlCode ca_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                CqlConcept cb_ = context.Operators.ConvertCodeToConcept(ca_);
                bool? cc_ = context.Operators.Equivalent(bz_, cb_);
                bool? cd_ = context.Operators.Not(cc_);
                bool? ce_ = context.Operators.Or(bx_, cd_);
                bool? cf_ = context.Operators.Implies(br_, ce_);
                bool? cg_ = context.Operators.And(bo_, cf_);

                return cg_;
            };
            IEnumerable<Condition> be_ = context.Operators.Where<Condition>(bc_, bd_);
            MedicationRequest bf_(Condition OUD) =>
                MedicationTreatment;
            IEnumerable<MedicationRequest> bg_ = context.Operators.Select<Condition, MedicationRequest>(be_, bf_);

            return bg_;
        };
        IEnumerable<MedicationRequest> f_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(a_, e_);
        IEnumerable<MedicationRequest> g_ = context.Operators.Union<MedicationRequest>(c_, f_);

        return g_;
    }


    [CqlExpressionDefinition("Intervention Palliative Or Hospice Care")]
    public IEnumerable<object> Intervention_Palliative_Or_Hospice_Care(CqlContext context)
    {
        CqlValueSet a_ = this.Palliative_or_Hospice_Care(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        bool? c_(ServiceRequest PalliativeOrHospiceCareOrder)
        {
            Code<RequestStatus> j_ = PalliativeOrHospiceCareOrder?.StatusElement;
            RequestStatus? k_ = j_?.Value;
            Code<RequestStatus> l_ = context.Operators.Convert<Code<RequestStatus>>(k_);
            string m_ = context.Operators.Convert<string>(l_);
            string[] n_ = [
                "active",
                "completed",
                "on-hold",
            ];
            bool? o_ = context.Operators.In<string>(m_, n_ as IEnumerable<string>);

            return o_;
        };
        IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);
        IEnumerable<Procedure> f_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? g_(Procedure PalliativeOrHospiceCarePerformed)
        {
            Code<EventStatus> p_ = PalliativeOrHospiceCarePerformed?.StatusElement;
            EventStatus? q_ = p_?.Value;
            string r_ = context.Operators.Convert<string>(q_);
            string[] s_ = [
                "completed",
                "in-progress",
            ];
            bool? t_ = context.Operators.In<string>(r_, s_ as IEnumerable<string>);

            return t_;
        };
        IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
        IEnumerable<object> i_ = context.Operators.Union<object>(d_ as IEnumerable<object>, h_ as IEnumerable<object>);

        return i_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public IEnumerable<Encounter> Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);
        bool? b_(Encounter InpatientEncounter)
        {
            CqlValueSet d_ = this.Cancer_Related_Pain(context);
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            bool? f_(Condition CancerPain)
            {
                CqlInterval<CqlDateTime> az_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, CancerPain as object);
                Period ba_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> bb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ba_);
                bool? bc_ = context.Operators.Overlaps(az_, bb_, "day");
                CodeableConcept bd_ = CancerPain?.VerificationStatus;
                CqlConcept be_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bd_);
                bool? bf_ = context.Operators.Not((bool?)(be_ is null));
                CqlConcept bh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bd_);
                CqlCode bi_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept bj_ = context.Operators.ConvertCodeToConcept(bi_);
                bool? bk_ = context.Operators.Equivalent(bh_, bj_);
                bool? bl_ = context.Operators.Not(bk_);
                CqlConcept bn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bd_);
                CqlCode bo_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                CqlConcept bp_ = context.Operators.ConvertCodeToConcept(bo_);
                bool? bq_ = context.Operators.Equivalent(bn_, bp_);
                bool? br_ = context.Operators.Not(bq_);
                bool? bs_ = context.Operators.Or(bl_, br_);
                bool? bt_ = context.Operators.Implies(bf_, bs_);
                bool? bu_ = context.Operators.And(bc_, bt_);

                return bu_;
            };
            IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
            bool? h_ = context.Operators.Exists<Condition>(g_);
            IEnumerable<Encounter> i_ = this.Inpatient_Encounter_With_Encounter_Diagnosis_Of_Cancer_Pain(context);
            bool? j_ = context.Operators.Exists<Encounter>(i_);
            bool? k_ = context.Operators.Or(h_, j_);
            CqlValueSet l_ = this.Sickle_Cell_Disease_with_and_without_Crisis(context);
            IEnumerable<Condition> m_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            bool? n_(Condition SickleCellDisease)
            {
                CqlInterval<CqlDateTime> bv_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, SickleCellDisease as object);
                Period bw_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> bx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bw_);
                bool? by_ = context.Operators.Overlaps(bv_, bx_, "day");
                CodeableConcept bz_ = SickleCellDisease?.VerificationStatus;
                CqlConcept ca_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bz_);
                bool? cb_ = context.Operators.Not((bool?)(ca_ is null));
                CqlConcept cd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bz_);
                CqlCode ce_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept cf_ = context.Operators.ConvertCodeToConcept(ce_);
                bool? cg_ = context.Operators.Equivalent(cd_, cf_);
                bool? ch_ = context.Operators.Not(cg_);
                CqlConcept cj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bz_);
                CqlCode ck_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                CqlConcept cl_ = context.Operators.ConvertCodeToConcept(ck_);
                bool? cm_ = context.Operators.Equivalent(cj_, cl_);
                bool? cn_ = context.Operators.Not(cm_);
                bool? co_ = context.Operators.Or(ch_, cn_);
                bool? cp_ = context.Operators.Implies(cb_, co_);
                bool? cq_ = context.Operators.And(by_, cp_);

                return cq_;
            };
            IEnumerable<Condition> o_ = context.Operators.Where<Condition>(m_, n_);
            bool? p_ = context.Operators.Exists<Condition>(o_);
            bool? q_ = context.Operators.Or(k_, p_);
            IEnumerable<MedicationRequest> r_ = this.Treatment_For_Opioid_Use_Disorders(context);
            bool? s_(MedicationRequest OUDTreatment)
            {
                FhirDateTime cr_ = OUDTreatment?.AuthoredOnElement;
                CqlDateTime cs_ = context.Operators.Convert<CqlDateTime>(cr_);
                Period ct_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> cu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ct_);
                bool? cv_ = context.Operators.In<CqlDateTime>(cs_, cu_, "day");

                return cv_;
            };
            IEnumerable<MedicationRequest> t_ = context.Operators.Where<MedicationRequest>(r_, s_);
            bool? u_ = context.Operators.Exists<MedicationRequest>(t_);
            bool? v_ = context.Operators.Or(q_, u_);
            IEnumerable<object> w_ = this.Intervention_Palliative_Or_Hospice_Care(context);
            bool? x_(object PalliativeOrHospiceCare)
            {
                object cw_()
                {
                    bool dd_()
                    {
                        object dh_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                        object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                        bool dj_ = di_ is CqlDateTime;

                        return dj_;
                    };
                    bool de_()
                    {
                        object dk_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                        object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                        bool dm_ = dl_ is CqlInterval<CqlDateTime>;

                        return dm_;
                    };
                    bool df_()
                    {
                        object dn_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                        object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                        bool dp_ = do_ is CqlQuantity;

                        return dp_;
                    };
                    bool dg_()
                    {
                        object dq_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                        object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                        bool ds_ = dr_ is CqlInterval<CqlQuantity>;

                        return ds_;
                    };
                    if (dd_())
                    {
                        object dt_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                        object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);

                        return (du_ as CqlDateTime) as object;
                    }
                    else if (de_())
                    {
                        object dv_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                        object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);

                        return (dw_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (df_())
                    {
                        object dx_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                        object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);

                        return (dy_ as CqlQuantity) as object;
                    }
                    else if (dg_())
                    {
                        object dz_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                        object ea_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dz_);

                        return (ea_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> cx_ = QICoreCommon_4_0_000.Instance.toInterval(context, cw_());
                CqlDateTime cy_ = context.Operators.Start(cx_);
                object cz_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "authoredOn");
                CqlDateTime da_ = context.Operators.LateBoundProperty<CqlDateTime>(cz_, "value");
                CqlInterval<CqlDateTime> db_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
                bool? dc_ = context.Operators.In<CqlDateTime>(cy_ ?? da_, db_, default);

                return dc_;
            };
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
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

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
