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
[CqlLibrary("CMS506FHIRSafeUseofOpioids", "0.2.004")]
public partial class CMS506FHIRSafeUseofOpioids_0_2_004 : ILibrary, ISingleton<CMS506FHIRSafeUseofOpioids_0_2_004>
{
    private CMS506FHIRSafeUseofOpioids_0_2_004() {}

    public static CMS506FHIRSafeUseofOpioids_0_2_004 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS506FHIRSafeUseofOpioids";
    public string Version => "0.2.004";
    public ILibrary[] Dependencies => [CQMCommon_2_2_000.Instance, FHIRHelpers_4_4_000.Instance, Hospice_6_12_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Cancer Related Pain", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.180", valueSetVersion: null)]
    public CqlValueSet Cancer_Related_Pain(CqlContext _) => _Cancer_Related_Pain;
    private static readonly CqlValueSet _Cancer_Related_Pain = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.180", null);

    [CqlValueSetDefinition("Discharge To Acute Care Facility", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", valueSetVersion: null)]
    public CqlValueSet Discharge_To_Acute_Care_Facility(CqlContext _) => _Discharge_To_Acute_Care_Facility;
    private static readonly CqlValueSet _Discharge_To_Acute_Care_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", null);

    [CqlValueSetDefinition("Ethnicity", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", valueSetVersion: null)]
    public CqlValueSet Ethnicity(CqlContext _) => _Ethnicity;
    private static readonly CqlValueSet _Ethnicity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", null);

    [CqlValueSetDefinition("Hospice Care Referral or Admission", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365", valueSetVersion: null)]
    public CqlValueSet Hospice_Care_Referral_or_Admission(CqlContext _) => _Hospice_Care_Referral_or_Admission;
    private static readonly CqlValueSet _Hospice_Care_Referral_or_Admission = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365", null);

    [CqlValueSetDefinition("Left Against Medical Advice", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", valueSetVersion: null)]
    public CqlValueSet Left_Against_Medical_Advice(CqlContext _) => _Left_Against_Medical_Advice;
    private static readonly CqlValueSet _Left_Against_Medical_Advice = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", null);

    [CqlValueSetDefinition("Medications for Opioid Use Disorder (MOUD)", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.269", valueSetVersion: null)]
    public CqlValueSet Medications_for_Opioid_Use_Disorder__MOUD_(CqlContext _) => _Medications_for_Opioid_Use_Disorder__MOUD_;
    private static readonly CqlValueSet _Medications_for_Opioid_Use_Disorder__MOUD_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.269", null);

    [CqlValueSetDefinition("Patient sex for quality measurement", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1021.120", valueSetVersion: null)]
    public CqlValueSet Patient_sex_for_quality_measurement(CqlContext _) => _Patient_sex_for_quality_measurement;
    private static readonly CqlValueSet _Patient_sex_for_quality_measurement = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1021.120", null);

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

    [CqlValueSetDefinition("Payer Type", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", valueSetVersion: null)]
    public CqlValueSet Payer_Type(CqlContext _) => _Payer_Type;
    private static readonly CqlValueSet _Payer_Type = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", null);

    [CqlValueSetDefinition("Race", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", valueSetVersion: null)]
    public CqlValueSet Race(CqlContext _) => _Race;
    private static readonly CqlValueSet _Race = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", null);

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

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, []);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2024, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2024, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("CMS506FHIRSafeUseofOpioids-0.2.004", "Measurement Period", c_);

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


    [CqlExpressionDefinition("Inpatient Encounter with Age Greater than or Equal to 18")]
    public IEnumerable<Encounter> Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(CqlContext context)
    {
        IEnumerable<Encounter> a_ = CQMCommon_2_2_000.Instance.Inpatient_Encounter(context);
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


    [CqlExpressionDefinition("Opioid at Discharge")]
    public IEnumerable<MedicationRequest> Opioid_at_Discharge(CqlContext context)
    {
        CqlValueSet a_ = this.Schedule_II__III_and_IV_Opioid_Medications(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> d_(MedicationRequest MR)
        {
            IEnumerable<Medication> k_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? l_(Medication M)
            {
                object p_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object q_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> r_ = context.Operators.Split((string)q_, "/");
                string s_ = context.Operators.Last<string>(r_);
                bool? t_ = context.Operators.Equal(p_, s_);
                CodeableConcept u_ = M?.Code;
                CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
                CqlValueSet w_ = this.Schedule_II__III_and_IV_Opioid_Medications(context);
                bool? x_ = context.Operators.ConceptInValueSet(v_, w_);
                bool? y_ = context.Operators.And(t_, x_);

                return y_;
            };
            IEnumerable<Medication> m_ = context.Operators.Where<Medication>(k_, l_);
            MedicationRequest n_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> o_ = context.Operators.Select<Medication, MedicationRequest>(m_, n_);

            return o_;
        };
        IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        bool? g_(MedicationRequest OpioidMedications)
        {
            bool? z_ = QICoreCommon_2_1_000.Instance.isCommunity(context, OpioidMedications);
            bool? aa_ = QICoreCommon_2_1_000.Instance.isDischarge(context, OpioidMedications);
            bool? ab_ = context.Operators.Or(z_, aa_);

            return ab_;
        };
        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
        bool? i_(MedicationRequest OpioidDischargeMedication)
        {
            Code<MedicationRequest.MedicationrequestStatus> ac_ = OpioidDischargeMedication?.StatusElement;
            MedicationRequest.MedicationrequestStatus? ad_ = ac_?.Value;
            string ae_ = context.Operators.Convert<string>(ad_);
            string[] af_ = [
                "active",
                "completed",
            ];
            bool? ag_ = context.Operators.In<string>(ae_, af_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> ah_ = OpioidDischargeMedication?.IntentElement;
            MedicationRequest.MedicationRequestIntent? ai_ = ah_?.Value;
            string aj_ = context.Operators.Convert<string>(ai_);
            bool? ak_ = context.Operators.Equal(aj_, "order");
            bool? al_ = context.Operators.And(ag_, ak_);

            return al_;
        };
        IEnumerable<MedicationRequest> j_ = context.Operators.Where<MedicationRequest>(h_, i_);

        return j_;
    }


    [CqlExpressionDefinition("Benzodiazepine at Discharge")]
    public IEnumerable<MedicationRequest> Benzodiazepine_at_Discharge(CqlContext context)
    {
        CqlValueSet a_ = this.Schedule_IV_Benzodiazepines(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        bool? c_(MedicationRequest BenzoMedications)
        {
            bool? g_ = QICoreCommon_2_1_000.Instance.isCommunity(context, BenzoMedications);
            bool? h_ = QICoreCommon_2_1_000.Instance.isDischarge(context, BenzoMedications);
            bool? i_ = context.Operators.Or(g_, h_);

            return i_;
        };
        IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(b_, c_);
        bool? e_(MedicationRequest BenzodiazepineDischargeMedication)
        {
            Code<MedicationRequest.MedicationrequestStatus> j_ = BenzodiazepineDischargeMedication?.StatusElement;
            MedicationRequest.MedicationrequestStatus? k_ = j_?.Value;
            string l_ = context.Operators.Convert<string>(k_);
            string[] m_ = [
                "active",
                "completed",
            ];
            bool? n_ = context.Operators.In<string>(l_, m_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> o_ = BenzodiazepineDischargeMedication?.IntentElement;
            MedicationRequest.MedicationRequestIntent? p_ = o_?.Value;
            string q_ = context.Operators.Convert<string>(p_);
            bool? r_ = context.Operators.Equal(q_, "order");
            bool? s_ = context.Operators.And(n_, r_);

            return s_;
        };
        IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);

        return f_;
    }


    [CqlExpressionDefinition("Inpatient Encounters with an Opioid or Benzodiazepine at Discharge")]
    public IEnumerable<Encounter> Inpatient_Encounters_with_an_Opioid_or_Benzodiazepine_at_Discharge(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);
        IEnumerable<Encounter> b_(Encounter InpatientEncounter)
        {
            IEnumerable<MedicationRequest> d_ = this.Opioid_at_Discharge(context);
            IEnumerable<MedicationRequest> e_ = this.Benzodiazepine_at_Discharge(context);
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
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters_with_an_Opioid_or_Benzodiazepine_at_Discharge(context);

        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlExpressionDefinition("Intervention Palliative or Hospice Care")]
    public IEnumerable<object> Intervention_Palliative_or_Hospice_Care(CqlContext context)
    {
        CqlValueSet a_ = this.Palliative_or_Hospice_Care(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<Procedure> d_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);

        return e_;
    }


    [CqlExpressionDefinition("Treatment for Opioid Use Disorders")]
    public IEnumerable<MedicationRequest> Treatment_for_Opioid_Use_Disorders(CqlContext context)
    {
        CqlValueSet a_ = this.Medications_for_Opioid_Use_Disorder__MOUD_(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> d_(MedicationRequest MR)
        {
            IEnumerable<Medication> r_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? s_(Medication M)
            {
                object w_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object x_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> y_ = context.Operators.Split((string)x_, "/");
                string z_ = context.Operators.Last<string>(y_);
                bool? aa_ = context.Operators.Equal(w_, z_);
                CodeableConcept ab_ = M?.Code;
                CqlConcept ac_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ab_);
                CqlValueSet ad_ = this.Medications_for_Opioid_Use_Disorder__MOUD_(context);
                bool? ae_ = context.Operators.ConceptInValueSet(ac_, ad_);
                bool? af_ = context.Operators.And(aa_, ae_);

                return af_;
            };
            IEnumerable<Medication> t_ = context.Operators.Where<Medication>(r_, s_);
            MedicationRequest u_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> v_ = context.Operators.Select<Medication, MedicationRequest>(t_, u_);

            return v_;
        };
        IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        IEnumerable<MedicationRequest> g_(MedicationRequest MedicationTreatment)
        {
            CqlValueSet ag_ = this.Opioid_Medication_Assisted_Treatment__MAT_(context);
            IEnumerable<Procedure> ah_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ag_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? ai_(Procedure MAT)
            {
                FhirDateTime am_ = MedicationTreatment?.AuthoredOnElement;
                CqlDateTime an_ = context.Operators.Convert<CqlDateTime>(am_);
                DataType ao_ = MAT?.Performed;
                object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                CqlInterval<CqlDateTime> aq_ = QICoreCommon_2_1_000.Instance.toInterval(context, ap_);
                bool? ar_ = context.Operators.In<CqlDateTime>(an_, aq_, "day");
                CqlDateTime at_ = context.Operators.Convert<CqlDateTime>(am_);
                CqlInterval<CqlDateTime> au_ = this.Measurement_Period(context);
                bool? av_ = context.Operators.In<CqlDateTime>(at_, au_, "day");
                bool? aw_ = context.Operators.And(ar_, av_);

                return aw_;
            };
            IEnumerable<Procedure> aj_ = context.Operators.Where<Procedure>(ah_, ai_);
            MedicationRequest ak_(Procedure MAT) =>
                MedicationTreatment;
            IEnumerable<MedicationRequest> al_ = context.Operators.Select<Procedure, MedicationRequest>(aj_, ak_);

            return al_;
        };
        IEnumerable<MedicationRequest> h_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(f_, g_);
        IEnumerable<MedicationRequest> j_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> l_(MedicationRequest MR)
        {
            IEnumerable<Medication> ax_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? ay_(Medication M)
            {
                object bc_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object bd_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> be_ = context.Operators.Split((string)bd_, "/");
                string bf_ = context.Operators.Last<string>(be_);
                bool? bg_ = context.Operators.Equal(bc_, bf_);
                CodeableConcept bh_ = M?.Code;
                CqlConcept bi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bh_);
                CqlValueSet bj_ = this.Medications_for_Opioid_Use_Disorder__MOUD_(context);
                bool? bk_ = context.Operators.ConceptInValueSet(bi_, bj_);
                bool? bl_ = context.Operators.And(bg_, bk_);

                return bl_;
            };
            IEnumerable<Medication> az_ = context.Operators.Where<Medication>(ax_, ay_);
            MedicationRequest ba_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> bb_ = context.Operators.Select<Medication, MedicationRequest>(az_, ba_);

            return bb_;
        };
        IEnumerable<MedicationRequest> m_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, l_);
        IEnumerable<MedicationRequest> n_ = context.Operators.Union<MedicationRequest>(j_, m_);
        IEnumerable<MedicationRequest> o_(MedicationRequest MedicationTreatment)
        {
            CqlValueSet bm_ = this.Opioid_Use_Disorder(context);
            IEnumerable<Condition> bn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? bo_(Condition OUD)
            {
                FhirDateTime bs_ = MedicationTreatment?.AuthoredOnElement;
                CqlDateTime bt_ = context.Operators.Convert<CqlDateTime>(bs_);
                CqlInterval<CqlDateTime> bu_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, OUD);
                bool? bv_ = context.Operators.In<CqlDateTime>(bt_, bu_, "day");
                CqlInterval<CqlDateTime> bx_ = this.Measurement_Period(context);
                bool? by_ = context.Operators.Overlaps(bu_, bx_, "day");
                bool? bz_ = context.Operators.And(bv_, by_);

                return bz_;
            };
            IEnumerable<Condition> bp_ = context.Operators.Where<Condition>(bn_, bo_);
            MedicationRequest bq_(Condition OUD) =>
                MedicationTreatment;
            IEnumerable<MedicationRequest> br_ = context.Operators.Select<Condition, MedicationRequest>(bp_, bq_);

            return br_;
        };
        IEnumerable<MedicationRequest> p_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(n_, o_);
        IEnumerable<MedicationRequest> q_ = context.Operators.Union<MedicationRequest>(h_, p_);

        return q_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return a_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public IEnumerable<Encounter> Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters_with_an_Opioid_or_Benzodiazepine_at_Discharge(context);
        bool? b_(Encounter InpatientEncounter)
        {
            CqlValueSet d_ = this.Cancer_Related_Pain(context);
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? f_(Condition CancerPain)
            {
                bool? bb_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, CancerPain);
                bool? bc_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, CancerPain);
                bool? bd_ = context.Operators.Or(bb_, bc_);
                CqlInterval<CqlDateTime> be_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, CancerPain);
                Period bf_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> bg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bf_);
                bool? bh_ = context.Operators.Overlaps(be_, bg_, "day");
                bool? bi_ = context.Operators.And(bd_, bh_);

                return bi_;
            };
            IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
            bool? h_ = context.Operators.Exists<Condition>(g_);
            IEnumerable<Condition> i_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, InpatientEncounter);
            bool? j_(Condition InpatientEncounterDiagnosis)
            {
                CodeableConcept bj_ = InpatientEncounterDiagnosis?.Code;
                CqlConcept bk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bj_);
                CqlValueSet bl_ = this.Cancer_Related_Pain(context);
                bool? bm_ = context.Operators.ConceptInValueSet(bk_, bl_);

                return bm_;
            };
            IEnumerable<Condition> k_ = context.Operators.Where<Condition>(i_, j_);
            bool? l_ = context.Operators.Exists<Condition>(k_);
            bool? m_ = context.Operators.Or(h_, l_);
            CqlValueSet n_ = this.Sickle_Cell_Disease_with_and_without_Crisis(context);
            IEnumerable<Condition> o_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? p_(Condition SickleCellDisease)
            {
                CqlInterval<CqlDateTime> bn_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, SickleCellDisease);
                Period bo_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> bp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bo_);
                bool? bq_ = context.Operators.Overlaps(bn_, bp_, "day");

                return bq_;
            };
            IEnumerable<Condition> q_ = context.Operators.Where<Condition>(o_, p_);
            bool? r_ = context.Operators.Exists<Condition>(q_);
            bool? s_ = context.Operators.Or(m_, r_);
            IEnumerable<MedicationRequest> t_ = this.Treatment_for_Opioid_Use_Disorders(context);
            bool? u_(MedicationRequest OUDTreatment)
            {
                FhirDateTime br_ = OUDTreatment?.AuthoredOnElement;
                CqlDateTime bs_ = context.Operators.Convert<CqlDateTime>(br_);
                Period bt_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> bu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bt_);
                bool? bv_ = context.Operators.In<CqlDateTime>(bs_, bu_, "day");

                return bv_;
            };
            IEnumerable<MedicationRequest> v_ = context.Operators.Where<MedicationRequest>(t_, u_);
            bool? w_ = context.Operators.Exists<MedicationRequest>(v_);
            bool? x_ = context.Operators.Or(s_, w_);
            IEnumerable<object> y_ = this.Intervention_Palliative_or_Hospice_Care(context);
            bool? z_(object PalliativeOrHospiceCare)
            {
                object bw_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                CqlInterval<CqlDateTime> by_ = QICoreCommon_2_1_000.Instance.toInterval(context, bx_);
                CqlDateTime bz_ = context.Operators.Start(by_);
                object ca_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "authoredOn");
                CqlDateTime cb_ = context.Operators.LateBoundProperty<CqlDateTime>(ca_, "value");
                CqlInterval<CqlDateTime> cc_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
                bool? cd_ = context.Operators.In<CqlDateTime>(bz_ ?? cb_, cc_, "day");

                return cd_;
            };
            IEnumerable<object> aa_ = context.Operators.Where<object>(y_, z_);
            bool? ab_ = context.Operators.Exists<object>(aa_);
            bool? ac_ = context.Operators.Or(x_, ab_);
            Encounter.HospitalizationComponent ad_ = InpatientEncounter?.Hospitalization;
            CodeableConcept ae_ = ad_?.DischargeDisposition;
            CqlConcept af_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ae_);
            CqlValueSet ag_ = this.Discharge_To_Acute_Care_Facility(context);
            bool? ah_ = context.Operators.ConceptInValueSet(af_, ag_);
            CodeableConcept aj_ = ad_?.DischargeDisposition;
            CqlConcept ak_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aj_);
            CqlValueSet al_ = this.Hospice_Care_Referral_or_Admission(context);
            bool? am_ = context.Operators.ConceptInValueSet(ak_, al_);
            bool? an_ = context.Operators.Or(ah_, am_);
            CodeableConcept ap_ = ad_?.DischargeDisposition;
            CqlConcept aq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ap_);
            CqlValueSet ar_ = this.Patient_Expired(context);
            bool? as_ = context.Operators.ConceptInValueSet(aq_, ar_);
            bool? at_ = context.Operators.Or(an_, as_);
            CodeableConcept av_ = ad_?.DischargeDisposition;
            CqlConcept aw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, av_);
            CqlValueSet ax_ = this.Left_Against_Medical_Advice(context);
            bool? ay_ = context.Operators.ConceptInValueSet(aw_, ax_);
            bool? az_ = context.Operators.Or(at_, ay_);
            bool? ba_ = context.Operators.Or(ac_, az_);

            return ba_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters_with_an_Opioid_or_Benzodiazepine_at_Discharge(context);
        bool? b_(Encounter InpatientEncounter)
        {
            IEnumerable<MedicationRequest> d_ = this.Opioid_at_Discharge(context);
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
                IEnumerable<MedicationRequest> ac_ = this.Benzodiazepine_at_Discharge(context);
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


    #endregion Functions and Expressions

}
