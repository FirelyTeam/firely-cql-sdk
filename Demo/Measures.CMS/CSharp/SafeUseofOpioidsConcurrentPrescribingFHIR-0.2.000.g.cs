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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.8.0")]
[CqlLibrary("SafeUseofOpioidsConcurrentPrescribingFHIR", "0.2.000")]
public partial class SafeUseofOpioidsConcurrentPrescribingFHIR_0_2_000 : ILibrary, ISingleton<SafeUseofOpioidsConcurrentPrescribingFHIR_0_2_000>
{
    private SafeUseofOpioidsConcurrentPrescribingFHIR_0_2_000() {}

    public static SafeUseofOpioidsConcurrentPrescribingFHIR_0_2_000 Instance { get; } = new();

    #region Library Members
    public string Name => "SafeUseofOpioidsConcurrentPrescribingFHIR";
    public string Version => "0.2.000";
    public ILibrary[] Dependencies => [CQMCommon_2_2_000.Instance, FHIRHelpers_4_4_000.Instance, Hospice_6_12_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance];
    #endregion Library Members

    [CqlDeclaration("Cancer Related Pain")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.180")]
    public CqlValueSet Cancer_Related_Pain(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.180", default);


    [CqlDeclaration("Discharge To Acute Care Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87")]
    public CqlValueSet Discharge_To_Acute_Care_Facility(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", default);


    [CqlDeclaration("Ethnicity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837")]
    public CqlValueSet Ethnicity(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", default);


    [CqlDeclaration("Hospice Care Referral or Admission")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365")]
    public CqlValueSet Hospice_Care_Referral_or_Admission(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365", default);


    [CqlDeclaration("Left Against Medical Advice")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308")]
    public CqlValueSet Left_Against_Medical_Advice(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", default);


    [CqlDeclaration("Medications for Opioid Use Disorder (MOUD)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.269")]
    public CqlValueSet Medications_for_Opioid_Use_Disorder__MOUD_(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.269", default);


    [CqlDeclaration("ONC Administrative Sex")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1")]
    public CqlValueSet ONC_Administrative_Sex(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", default);


    [CqlDeclaration("Opioid Medication Assisted Treatment (MAT)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.177")]
    public CqlValueSet Opioid_Medication_Assisted_Treatment__MAT_(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.177", default);


    [CqlDeclaration("Opioid Use Disorder")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.171")]
    public CqlValueSet Opioid_Use_Disorder(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.171", default);


    [CqlDeclaration("Palliative or Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579")]
    public CqlValueSet Palliative_or_Hospice_Care(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579", default);


    [CqlDeclaration("Patient Expired")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309")]
    public CqlValueSet Patient_Expired(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", default);


    [CqlDeclaration("Payer Type")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591")]
    public CqlValueSet Payer_Type(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", default);


    [CqlDeclaration("Race")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836")]
    public CqlValueSet Race(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", default);


    [CqlDeclaration("Schedule II, III and IV Opioid Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.241")]
    public CqlValueSet Schedule_II__III_and_IV_Opioid_Medications(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.241", default);


    [CqlDeclaration("Schedule IV Benzodiazepines")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1125.1")]
    public CqlValueSet Schedule_IV_Benzodiazepines(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1125.1", default);


    [CqlDeclaration("Sickle Cell Disease with and without Crisis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.175")]
    public CqlValueSet Sickle_Cell_Disease_with_and_without_Crisis(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.175", default);


    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] a_ = []
;

        return a_;
    }


    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("SafeUseofOpioidsConcurrentPrescribingFHIR-0.2.000", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }


    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlDeclaration("Inpatient Encounter with Age Greater than or Equal to 18")]
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


    [CqlDeclaration("Opioid at Discharge")]
    public IEnumerable<MedicationRequest> Opioid_at_Discharge(CqlContext context)
    {
        CqlValueSet a_ = this.Schedule_II__III_and_IV_Opioid_Medications(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
        bool? f_(MedicationRequest OpioidMedications)
        {
            bool? j_ = QICoreCommon_2_1_000.Instance.isCommunity(context, OpioidMedications);
            bool? k_ = QICoreCommon_2_1_000.Instance.isDischarge(context, OpioidMedications);
            bool? l_ = context.Operators.Or(j_, k_);

            return l_;
        };
        IEnumerable<MedicationRequest> g_ = context.Operators.Where<MedicationRequest>(e_, f_);
        bool? h_(MedicationRequest OpioidDischargeMedication)
        {
            Code<MedicationRequest.MedicationrequestStatus> m_ = OpioidDischargeMedication?.StatusElement;
            MedicationRequest.MedicationrequestStatus? n_ = m_?.Value;
            string o_ = context.Operators.Convert<string>(n_);
            string[] p_ = [
                "active",
                "completed",
            ];
            bool? q_ = context.Operators.In<string>(o_, p_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> r_ = OpioidDischargeMedication?.IntentElement;
            MedicationRequest.MedicationRequestIntent? s_ = r_?.Value;
            string t_ = context.Operators.Convert<string>(s_);
            bool? u_ = context.Operators.Equal(t_, "order");
            bool? v_ = context.Operators.And(q_, u_);

            return v_;
        };
        IEnumerable<MedicationRequest> i_ = context.Operators.Where<MedicationRequest>(g_, h_);

        return i_;
    }


    [CqlDeclaration("Benzodiazepine at Discharge")]
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


    [CqlDeclaration("Inpatient Encounters with an Opioid or Benzodiazepine at Discharge")]
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


    [CqlDeclaration("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters_with_an_Opioid_or_Benzodiazepine_at_Discharge(context);

        return a_;
    }


    [CqlDeclaration("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlDeclaration("Treatment for Opioid Use Disorders")]
    public IEnumerable<MedicationRequest> Treatment_for_Opioid_Use_Disorders(CqlContext context)
    {
        CqlValueSet a_ = this.Medications_for_Opioid_Use_Disorder__MOUD_(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
        IEnumerable<MedicationRequest> f_(MedicationRequest MedicationTreatment)
        {
            CqlValueSet h_ = this.Opioid_Medication_Assisted_Treatment__MAT_(context);
            IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? j_(Procedure MAT)
            {
                FhirDateTime n_ = MedicationTreatment?.AuthoredOnElement;
                CqlDateTime o_ = context.Operators.Convert<CqlDateTime>(n_);
                DataType p_ = MAT?.Performed;
                object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                CqlInterval<CqlDateTime> r_ = QICoreCommon_2_1_000.Instance.toInterval(context, q_);
                bool? s_ = context.Operators.In<CqlDateTime>(o_, r_, "day");
                CqlDateTime u_ = context.Operators.Convert<CqlDateTime>(n_);
                CqlInterval<CqlDateTime> v_ = this.Measurement_Period(context);
                bool? w_ = context.Operators.In<CqlDateTime>(u_, v_, "day");
                bool? x_ = context.Operators.And(s_, w_);

                return x_;
            };
            IEnumerable<Procedure> k_ = context.Operators.Where<Procedure>(i_, j_);
            MedicationRequest l_(Procedure MAT) => 
                MedicationTreatment;
            IEnumerable<MedicationRequest> m_ = context.Operators.Select<Procedure, MedicationRequest>(k_, l_);

            return m_;
        };
        IEnumerable<MedicationRequest> g_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(e_, f_);

        return g_;
    }


    [CqlDeclaration("Intervention Palliative or Hospice Care")]
    public IEnumerable<object> Intervention_Palliative_or_Hospice_Care(CqlContext context)
    {
        CqlValueSet a_ = this.Palliative_or_Hospice_Care(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<Procedure> d_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);

        return e_;
    }


    [CqlDeclaration("Denominator Exclusion")]
    public IEnumerable<Encounter> Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters_with_an_Opioid_or_Benzodiazepine_at_Discharge(context);
        bool? b_(Encounter InpatientEncounter)
        {
            CqlValueSet d_ = this.Cancer_Related_Pain(context);
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? f_(Condition CancerPain)
            {
                bool? bh_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, CancerPain);
                bool? bi_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, CancerPain);
                bool? bj_ = context.Operators.Or(bh_, bi_);
                CqlInterval<CqlDateTime> bk_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, CancerPain);
                Period bl_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> bm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bl_);
                bool? bn_ = context.Operators.Overlaps(bk_, bm_, "day");
                bool? bo_ = context.Operators.And(bj_, bn_);

                return bo_;
            };
            IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
            bool? h_ = context.Operators.Exists<Condition>(g_);
            IEnumerable<Condition> i_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, InpatientEncounter);
            bool? j_(Condition InpatientEncounterDiagnosis)
            {
                CodeableConcept bp_ = InpatientEncounterDiagnosis?.Code;
                CqlConcept bq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bp_);
                CqlValueSet br_ = this.Cancer_Related_Pain(context);
                bool? bs_ = context.Operators.ConceptInValueSet(bq_, br_);

                return bs_;
            };
            IEnumerable<Condition> k_ = context.Operators.Where<Condition>(i_, j_);
            bool? l_ = context.Operators.Exists<Condition>(k_);
            bool? m_ = context.Operators.Or(h_, l_);
            CqlValueSet n_ = this.Sickle_Cell_Disease_with_and_without_Crisis(context);
            IEnumerable<Condition> o_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? p_(Condition SickleCellDisease)
            {
                CqlInterval<CqlDateTime> bt_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, SickleCellDisease);
                Period bu_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> bv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bu_);
                bool? bw_ = context.Operators.Overlaps(bt_, bv_, "day");

                return bw_;
            };
            IEnumerable<Condition> q_ = context.Operators.Where<Condition>(o_, p_);
            bool? r_ = context.Operators.Exists<Condition>(q_);
            bool? s_ = context.Operators.Or(m_, r_);
            CqlValueSet t_ = this.Opioid_Use_Disorder(context);
            IEnumerable<Condition> u_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? v_(Condition OUD)
            {
                CqlInterval<CqlDateTime> bx_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, OUD);
                CqlDateTime by_ = context.Operators.Start(bx_);
                Period bz_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ca_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bz_);
                CqlDateTime cb_ = context.Operators.End(ca_);
                bool? cc_ = context.Operators.Before(by_, cb_, "day");

                return cc_;
            };
            IEnumerable<Condition> w_ = context.Operators.Where<Condition>(u_, v_);
            bool? x_ = context.Operators.Exists<Condition>(w_);
            bool? y_ = context.Operators.Or(s_, x_);
            IEnumerable<MedicationRequest> z_ = this.Treatment_for_Opioid_Use_Disorders(context);
            bool? aa_(MedicationRequest OUDTreatment)
            {
                FhirDateTime cd_ = OUDTreatment?.AuthoredOnElement;
                CqlDateTime ce_ = context.Operators.Convert<CqlDateTime>(cd_);
                Period cf_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> cg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cf_);
                bool? ch_ = context.Operators.In<CqlDateTime>(ce_, cg_, "day");

                return ch_;
            };
            IEnumerable<MedicationRequest> ab_ = context.Operators.Where<MedicationRequest>(z_, aa_);
            bool? ac_ = context.Operators.Exists<MedicationRequest>(ab_);
            bool? ad_ = context.Operators.Or(y_, ac_);
            IEnumerable<object> ae_ = this.Intervention_Palliative_or_Hospice_Care(context);
            bool? af_(object PalliativeOrHospiceCare)
            {
                object ci_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                CqlInterval<CqlDateTime> ck_ = QICoreCommon_2_1_000.Instance.toInterval(context, cj_);
                CqlDateTime cl_ = context.Operators.Start(ck_);
                object cm_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "authoredOn");
                CqlDateTime cn_ = context.Operators.LateBoundProperty<CqlDateTime>(cm_, "value");
                CqlInterval<CqlDateTime> co_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
                bool? cp_ = context.Operators.In<CqlDateTime>(cl_ ?? cn_, co_, "day");

                return cp_;
            };
            IEnumerable<object> ag_ = context.Operators.Where<object>(ae_, af_);
            bool? ah_ = context.Operators.Exists<object>(ag_);
            bool? ai_ = context.Operators.Or(ad_, ah_);
            Encounter.HospitalizationComponent aj_ = InpatientEncounter?.Hospitalization;
            CodeableConcept ak_ = aj_?.DischargeDisposition;
            CqlConcept al_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ak_);
            CqlValueSet am_ = this.Discharge_To_Acute_Care_Facility(context);
            bool? an_ = context.Operators.ConceptInValueSet(al_, am_);
            CodeableConcept ap_ = aj_?.DischargeDisposition;
            CqlConcept aq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ap_);
            CqlValueSet ar_ = this.Hospice_Care_Referral_or_Admission(context);
            bool? as_ = context.Operators.ConceptInValueSet(aq_, ar_);
            bool? at_ = context.Operators.Or(an_, as_);
            CodeableConcept av_ = aj_?.DischargeDisposition;
            CqlConcept aw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, av_);
            CqlValueSet ax_ = this.Patient_Expired(context);
            bool? ay_ = context.Operators.ConceptInValueSet(aw_, ax_);
            bool? az_ = context.Operators.Or(at_, ay_);
            CodeableConcept bb_ = aj_?.DischargeDisposition;
            CqlConcept bc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bb_);
            CqlValueSet bd_ = this.Left_Against_Medical_Advice(context);
            bool? be_ = context.Operators.ConceptInValueSet(bc_, bd_);
            bool? bf_ = context.Operators.Or(az_, be_);
            bool? bg_ = context.Operators.Or(ai_, bf_);

            return bg_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters_with_an_Opioid_or_Benzodiazepine_at_Discharge(context);
        bool? b_(Encounter InpatientEncounter)
        {
            IEnumerable<MedicationRequest> d_ = this.Opioid_at_Discharge(context);
            bool? e_(MedicationRequest OpioidMedications)
            {
                FhirDateTime p_ = OpioidMedications?.AuthoredOnElement;
                CqlDateTime q_ = context.Operators.Convert<CqlDateTime>(p_);
                Period r_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                bool? t_ = context.Operators.In<CqlDateTime>(q_, s_, "day");

                return t_;
            };
            IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
            object g_(MedicationRequest OpioidMedications)
            {
                DataType u_ = OpioidMedications?.Medication;
                object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);

                return v_;
            };
            IEnumerable<object> h_ = context.Operators.Select<MedicationRequest, object>(f_, g_);
            int? i_ = context.Operators.Count<object>(h_);
            bool? j_ = context.Operators.GreaterOrEqual(i_, 2);
            bool? l_(MedicationRequest OpioidDischargeMedications)
            {
                FhirDateTime w_ = OpioidDischargeMedications?.AuthoredOnElement;
                CqlDateTime x_ = context.Operators.Convert<CqlDateTime>(w_);
                Period y_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
                bool? aa_ = context.Operators.In<CqlDateTime>(x_, z_, "day");
                IEnumerable<MedicationRequest> ab_ = this.Benzodiazepine_at_Discharge(context);
                bool? ac_(MedicationRequest BenzodiazepineDischargeMedication)
                {
                    FhirDateTime ag_ = BenzodiazepineDischargeMedication?.AuthoredOnElement;
                    CqlDateTime ah_ = context.Operators.Convert<CqlDateTime>(ag_);
                    Period ai_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ai_);
                    bool? ak_ = context.Operators.In<CqlDateTime>(ah_, aj_, "day");

                    return ak_;
                };
                IEnumerable<MedicationRequest> ad_ = context.Operators.Where<MedicationRequest>(ab_, ac_);
                bool? ae_ = context.Operators.Exists<MedicationRequest>(ad_);
                bool? af_ = context.Operators.And(aa_, ae_);

                return af_;
            };
            IEnumerable<MedicationRequest> m_ = context.Operators.Where<MedicationRequest>(d_, l_);
            bool? n_ = context.Operators.Exists<MedicationRequest>(m_);
            bool? o_ = context.Operators.Or(j_, n_);

            return o_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlDeclaration("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlDeclaration("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return a_;
    }

}
