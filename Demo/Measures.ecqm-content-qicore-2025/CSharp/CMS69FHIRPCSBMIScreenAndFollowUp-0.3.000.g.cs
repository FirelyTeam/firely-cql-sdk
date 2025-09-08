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
[CqlLibrary("CMS69FHIRPCSBMIScreenAndFollowUp", "0.3.000")]
public partial class CMS69FHIRPCSBMIScreenAndFollowUp_0_3_000 : ILibrary, ISingleton<CMS69FHIRPCSBMIScreenAndFollowUp_0_3_000>
{
    private CMS69FHIRPCSBMIScreenAndFollowUp_0_3_000() {}

    public static CMS69FHIRPCSBMIScreenAndFollowUp_0_3_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS69FHIRPCSBMIScreenAndFollowUp";
    public string Version => "0.3.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, Hospice_6_18_000.Instance, PalliativeCare_1_18_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Encounter to Evaluate BMI", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1751", valueSetVersion: null)]
    public CqlValueSet Encounter_to_Evaluate_BMI(CqlContext _) => _Encounter_to_Evaluate_BMI;
    private static readonly CqlValueSet _Encounter_to_Evaluate_BMI = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1751", null);

    [CqlValueSetDefinition("Follow Up for Above Normal BMI", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1525", valueSetVersion: null)]
    public CqlValueSet Follow_Up_for_Above_Normal_BMI(CqlContext _) => _Follow_Up_for_Above_Normal_BMI;
    private static readonly CqlValueSet _Follow_Up_for_Above_Normal_BMI = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1525", null);

    [CqlValueSetDefinition("Follow Up for Below Normal BMI", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1528", valueSetVersion: null)]
    public CqlValueSet Follow_Up_for_Below_Normal_BMI(CqlContext _) => _Follow_Up_for_Below_Normal_BMI;
    private static readonly CqlValueSet _Follow_Up_for_Below_Normal_BMI = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1528", null);

    [CqlValueSetDefinition("Medical Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", valueSetVersion: null)]
    public CqlValueSet Medical_Reason(CqlContext _) => _Medical_Reason;
    private static readonly CqlValueSet _Medical_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);

    [CqlValueSetDefinition("Medications for Above Normal BMI", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1561", valueSetVersion: null)]
    public CqlValueSet Medications_for_Above_Normal_BMI(CqlContext _) => _Medications_for_Above_Normal_BMI;
    private static readonly CqlValueSet _Medications_for_Above_Normal_BMI = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1561", null);

    [CqlValueSetDefinition("Medications for Below Normal BMI", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1562", valueSetVersion: null)]
    public CqlValueSet Medications_for_Below_Normal_BMI(CqlContext _) => _Medications_for_Below_Normal_BMI;
    private static readonly CqlValueSet _Medications_for_Below_Normal_BMI = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1562", null);

    [CqlValueSetDefinition("Overweight or Obese", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.502", valueSetVersion: null)]
    public CqlValueSet Overweight_or_Obese(CqlContext _) => _Overweight_or_Obese;
    private static readonly CqlValueSet _Overweight_or_Obese = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.502", null);

    [CqlValueSetDefinition("Patient Declined", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1582", valueSetVersion: null)]
    public CqlValueSet Patient_Declined(CqlContext _) => _Patient_Declined;
    private static readonly CqlValueSet _Patient_Declined = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1582", null);

    [CqlValueSetDefinition("Pregnancy or Other Related Diagnoses", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1623", valueSetVersion: null)]
    public CqlValueSet Pregnancy_or_Other_Related_Diagnoses(CqlContext _) => _Pregnancy_or_Other_Related_Diagnoses;
    private static readonly CqlValueSet _Pregnancy_or_Other_Related_Diagnoses = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1623", null);

    [CqlValueSetDefinition("Referrals Where Weight Assessment May Occur", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1527", valueSetVersion: null)]
    public CqlValueSet Referrals_Where_Weight_Assessment_May_Occur(CqlContext _) => _Referrals_Where_Weight_Assessment_May_Occur;
    private static readonly CqlValueSet _Referrals_Where_Weight_Assessment_May_Occur = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1527", null);

    [CqlValueSetDefinition("Underweight", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1563", valueSetVersion: null)]
    public CqlValueSet Underweight(CqlContext _) => _Underweight;
    private static readonly CqlValueSet _Underweight = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1563", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Body mass index (BMI) [Ratio]", codeId: "39156-5", codeSystem: "http://loinc.org")]
    public CqlCode Body_mass_index__BMI___Ratio_(CqlContext _) => _Body_mass_index__BMI___Ratio_;
    private static readonly CqlCode _Body_mass_index__BMI___Ratio_ = new CqlCode("39156-5", "http://loinc.org");

    [CqlCodeDefinition("Encounter for palliative care", codeId: "Z51.5", codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode Encounter_for_palliative_care(CqlContext _) => _Encounter_for_palliative_care;
    private static readonly CqlCode _Encounter_for_palliative_care = new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm");

    [CqlCodeDefinition("Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)", codeId: "71007-9", codeSystem: "http://loinc.org")]
    public CqlCode Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(CqlContext _) => _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_;
    private static readonly CqlCode _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_ = new CqlCode("71007-9", "http://loinc.org");

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

    [CqlCodeSystemDefinition("ICD10CM", codeSystemId: "http://hl7.org/fhir/sid/icd-10-cm", codeSystemVersion: null)]
    public CqlCodeSystem ICD10CM(CqlContext _) => _ICD10CM;
    private static readonly CqlCodeSystem _ICD10CM =
      new CqlCodeSystem("http://hl7.org/fhir/sid/icd-10-cm", null, [
          _Encounter_for_palliative_care]);

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Body_mass_index__BMI___Ratio_,
          _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_]);

    [CqlCodeSystemDefinition("ObservationCategoryCodes", codeSystemId: "http://terminology.hl7.org/CodeSystem/observation-category", codeSystemVersion: null)]
    public CqlCodeSystem ObservationCategoryCodes(CqlContext _) => _ObservationCategoryCodes;
    private static readonly CqlCodeSystem _ObservationCategoryCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/observation-category", null, []);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object a_ = context.ResolveParameter("CMS69FHIRPCSBMIScreenAndFollowUp-0.3.000", "Measurement Period", null);

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


    [CqlExpressionDefinition("Qualifying Encounter During Day Of Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_During_Day_Of_Measurement_Period(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_to_Evaluate_BMI(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? c_(Encounter BMIEncounter)
        {
            CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
            Period f_ = BMIEncounter?.Period;
            CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, f_);
            bool? h_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, g_, "day");
            Coding i_ = BMIEncounter?.Class;
            CqlCode j_ = FHIRHelpers_4_4_000.Instance.ToCode(context, i_);
            CqlCode k_ = this.@virtual(context);
            bool? l_ = context.Operators.Equivalent(j_, k_);
            bool? m_ = context.Operators.Not(l_);
            bool? n_ = context.Operators.And(h_, m_);
            Code<Encounter.EncounterStatus> o_ = BMIEncounter?.StatusElement;
            Encounter.EncounterStatus? p_ = o_?.Value;
            Code<Encounter.EncounterStatus> q_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(p_);
            bool? r_ = context.Operators.Equal(q_, "finished");
            bool? s_ = context.Operators.And(n_, r_);

            return s_;
        };
        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_During_Day_Of_Measurement_Period(context);
        bool? b_(Encounter QualifyingEncounter)
        {
            Patient e_ = this.Patient(context);
            Date f_ = e_?.BirthDateElement;
            string g_ = f_?.Value;
            CqlDate h_ = context.Operators.ConvertStringToDate(g_);
            Period i_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
            CqlDateTime k_ = context.Operators.Start(j_);
            CqlDate l_ = context.Operators.DateFrom(k_);
            int? m_ = context.Operators.CalculateAgeAt(h_, l_, "year");
            bool? n_ = context.Operators.GreaterOrEqual(m_, 18);

            return n_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        bool? d_ = context.Operators.Exists<Encounter>(c_);

        return d_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlExpressionDefinition("Is Pregnant During Day Of Measurement Period")]
    public IEnumerable<object> Is_Pregnant_During_Day_Of_Measurement_Period(CqlContext context)
    {
        CqlValueSet a_ = this.Pregnancy_or_Other_Related_Diagnoses(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
        IEnumerable<object> f_(object PregnancyDiagnosis)
        {
            IEnumerable<Encounter> h_ = this.Qualifying_Encounter_During_Day_Of_Measurement_Period(context);
            bool? i_(Encounter QualifyingEncounter)
            {
                object m_ = context.Operators.LateBoundProperty<object>(PregnancyDiagnosis, "clinicalStatus");
                CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, m_ as CodeableConcept);
                CqlCode o_ = QICoreCommon_4_0_000.Instance.active(context);
                CqlConcept p_ = context.Operators.ConvertCodeToConcept(o_);
                bool? q_ = context.Operators.Equivalent(n_, p_);
                CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PregnancyDiagnosis);
                CqlInterval<CqlDateTime> s_ = this.Measurement_Period(context);
                bool? t_ = context.Operators.Overlaps(r_, s_, "day");
                bool? u_ = context.Operators.And(q_, t_);

                return u_;
            };
            IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
            object k_(Encounter QualifyingEncounter) =>
                PregnancyDiagnosis;
            IEnumerable<object> l_ = context.Operators.Select<Encounter, object>(j_, k_);

            return l_;
        };
        IEnumerable<object> g_ = context.Operators.SelectMany<object, object>(e_, f_);

        return g_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
        bool? b_ = PalliativeCare_1_18_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? c_ = context.Operators.Or(a_, b_);
        IEnumerable<object> d_ = this.Is_Pregnant_During_Day_Of_Measurement_Period(context);
        bool? e_ = context.Operators.Exists<object>(d_);
        bool? f_ = context.Operators.Or(c_, e_);

        return f_;
    }


    [CqlExpressionDefinition("BMI During Measurement Period")]
    public IEnumerable<Observation> BMI_During_Measurement_Period(CqlContext context)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-bmi"));
        bool? b_(Observation BMI)
        {
            DataType d_ = BMI?.Value;
            CqlQuantity e_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, d_ as Quantity);
            CqlQuantity f_ = context.Operators.Quantity(0m, "kg/m2");
            bool? g_ = context.Operators.Greater(e_, f_);
            Code<ObservationStatus> h_ = BMI?.StatusElement;
            ObservationStatus? i_ = h_?.Value;
            string j_ = context.Operators.Convert<string>(i_);
            string[] k_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? l_ = context.Operators.In<string>(j_, (IEnumerable<string>)k_);
            bool? m_ = context.Operators.And(g_, l_);
            CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
            DataType o_ = BMI?.Effective;
            object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
            CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
            bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(n_, q_, "day");
            bool? s_ = context.Operators.And(m_, r_);

            return s_;
        };
        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Documented High BMI During Measurement Period")]
    public IEnumerable<Observation> Documented_High_BMI_During_Measurement_Period(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.BMI_During_Measurement_Period(context);
        bool? b_(Observation BMI)
        {
            CqlInterval<CqlDateTime> d_ = this.Measurement_Period(context);
            DataType e_ = BMI?.Effective;
            object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
            CqlInterval<CqlDateTime> g_ = QICoreCommon_4_0_000.Instance.toInterval(context, f_);
            bool? h_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(d_, g_, "day");
            DataType i_ = BMI?.Value;
            CqlQuantity j_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, i_ as Quantity);
            CqlQuantity k_ = context.Operators.Quantity(25m, "kg/m2");
            bool? l_ = context.Operators.GreaterOrEqual(j_, k_);
            bool? m_ = context.Operators.And(h_, l_);

            return m_;
        };
        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("High BMI Interventions Ordered")]
    public IEnumerable<object> High_BMI_Interventions_Ordered(CqlContext context)
    {
        CqlValueSet a_ = this.Follow_Up_for_Above_Normal_BMI(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        CqlValueSet c_ = this.Referrals_Where_Weight_Assessment_May_Occur(context);
        IEnumerable<ServiceRequest> d_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> e_ = context.Operators.Union<ServiceRequest>(b_, d_);
        CqlValueSet f_ = this.Medications_for_Above_Normal_BMI(context);
        IEnumerable<MedicationRequest> g_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> i_(MedicationRequest MR)
        {
            IEnumerable<Medication> o_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? p_(Medication M)
            {
                object t_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object u_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> v_ = context.Operators.Split((string)u_, "/");
                string w_ = context.Operators.Last<string>(v_);
                bool? x_ = context.Operators.Equal(t_, w_);
                CodeableConcept y_ = M?.Code;
                CqlConcept z_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, y_);
                CqlValueSet aa_ = this.Medications_for_Above_Normal_BMI(context);
                bool? ab_ = context.Operators.ConceptInValueSet(z_, aa_);
                bool? ac_ = context.Operators.And(x_, ab_);

                return ac_;
            };
            IEnumerable<Medication> q_ = context.Operators.Where<Medication>(o_, p_);
            MedicationRequest r_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> s_ = context.Operators.Select<Medication, MedicationRequest>(q_, r_);

            return s_;
        };
        IEnumerable<MedicationRequest> j_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(h_, i_);
        IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(g_, j_);
        IEnumerable<object> l_ = context.Operators.Union<object>(e_ as IEnumerable<object>, k_ as IEnumerable<object>);
        bool? m_(object HighInterventionsOrdered)
        {
            object ad_ = context.Operators.LateBoundProperty<object>(HighInterventionsOrdered, "reasonCode");
            object[] ae_ = [
                ad_,
            ];
            CqlConcept af_(object @this)
            {
                CqlConcept ap_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this as CodeableConcept);

                return ap_;
            };
            IEnumerable<CqlConcept> ag_ = context.Operators.Select<object, CqlConcept>((IEnumerable<object>)ae_, af_);
            CqlValueSet ah_ = this.Overweight_or_Obese(context);
            bool? ai_ = context.Operators.ConceptsInValueSet(ag_, ah_);
            IEnumerable<Condition> ak_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ah_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            bool? al_(Condition OverweightObese)
            {
                bool? aq_ = QICoreCommon_4_0_000.Instance.isProblemListItem(context, OverweightObese as object);
                bool? ar_ = QICoreCommon_4_0_000.Instance.isHealthConcern(context, OverweightObese as object);
                bool? as_ = context.Operators.Or(aq_, ar_);
                bool? at_ = QICoreCommon_4_0_000.Instance.isActive(context, OverweightObese as object);
                bool? au_ = context.Operators.And(as_, at_);
                CqlInterval<CqlDateTime> av_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, OverweightObese as object);
                CqlDateTime aw_ = context.Operators.Start(av_);
                object ax_ = context.Operators.LateBoundProperty<object>(HighInterventionsOrdered, "authoredOn");
                CqlDateTime ay_ = context.Operators.LateBoundProperty<CqlDateTime>(ax_, "value");
                bool? az_ = context.Operators.SameOrBefore(aw_, ay_, "day");
                bool? ba_ = context.Operators.And(au_, az_);

                return ba_;
            };
            IEnumerable<Condition> am_ = context.Operators.Where<Condition>(ak_, al_);
            bool? an_ = context.Operators.Exists<Condition>(am_);
            bool? ao_ = context.Operators.Or(ai_, an_);

            return ao_;
        };
        IEnumerable<object> n_ = context.Operators.Where<object>(l_, m_);

        return n_;
    }


    [CqlExpressionDefinition("High BMI Interventions Performed")]
    public IEnumerable<Procedure> High_BMI_Interventions_Performed(CqlContext context)
    {
        CqlValueSet a_ = this.Follow_Up_for_Above_Normal_BMI(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? c_(Procedure HighInterventionsPerformed)
        {
            List<CodeableConcept> e_ = HighInterventionsPerformed?.ReasonCode;
            CqlConcept f_(CodeableConcept @this)
            {
                CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return p_;
            };
            IEnumerable<CqlConcept> g_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)e_, f_);
            CqlValueSet h_ = this.Overweight_or_Obese(context);
            bool? i_ = context.Operators.ConceptsInValueSet(g_, h_);
            IEnumerable<Condition> k_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            bool? l_(Condition OverweightObese)
            {
                CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, OverweightObese as object);
                CqlDateTime r_ = context.Operators.Start(q_);
                object s_()
                {
                    bool ae_()
                    {
                        DataType ai_ = HighInterventionsPerformed?.Performed;
                        object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                        bool ak_ = aj_ is CqlDateTime;

                        return ak_;
                    };
                    bool af_()
                    {
                        DataType al_ = HighInterventionsPerformed?.Performed;
                        object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                        bool an_ = am_ is CqlInterval<CqlDateTime>;

                        return an_;
                    };
                    bool ag_()
                    {
                        DataType ao_ = HighInterventionsPerformed?.Performed;
                        object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                        bool aq_ = ap_ is CqlQuantity;

                        return aq_;
                    };
                    bool ah_()
                    {
                        DataType ar_ = HighInterventionsPerformed?.Performed;
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        bool at_ = as_ is CqlInterval<CqlQuantity>;

                        return at_;
                    };
                    if (ae_())
                    {
                        DataType au_ = HighInterventionsPerformed?.Performed;
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);

                        return (av_ as CqlDateTime) as object;
                    }
                    else if (af_())
                    {
                        DataType aw_ = HighInterventionsPerformed?.Performed;
                        object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);

                        return (ax_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ag_())
                    {
                        DataType ay_ = HighInterventionsPerformed?.Performed;
                        object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);

                        return (az_ as CqlQuantity) as object;
                    }
                    else if (ah_())
                    {
                        DataType ba_ = HighInterventionsPerformed?.Performed;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);

                        return (bb_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> t_ = QICoreCommon_4_0_000.Instance.toInterval(context, s_());
                CqlDateTime u_ = context.Operators.Start(t_);
                bool? v_ = context.Operators.SameOrBefore(r_, u_, "day");
                CqlDateTime x_ = context.Operators.End(q_);
                object y_()
                {
                    bool bc_()
                    {
                        DataType bg_ = HighInterventionsPerformed?.Performed;
                        object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                        bool bi_ = bh_ is CqlDateTime;

                        return bi_;
                    };
                    bool bd_()
                    {
                        DataType bj_ = HighInterventionsPerformed?.Performed;
                        object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                        bool bl_ = bk_ is CqlInterval<CqlDateTime>;

                        return bl_;
                    };
                    bool be_()
                    {
                        DataType bm_ = HighInterventionsPerformed?.Performed;
                        object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                        bool bo_ = bn_ is CqlQuantity;

                        return bo_;
                    };
                    bool bf_()
                    {
                        DataType bp_ = HighInterventionsPerformed?.Performed;
                        object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                        bool br_ = bq_ is CqlInterval<CqlQuantity>;

                        return br_;
                    };
                    if (bc_())
                    {
                        DataType bs_ = HighInterventionsPerformed?.Performed;
                        object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);

                        return (bt_ as CqlDateTime) as object;
                    }
                    else if (bd_())
                    {
                        DataType bu_ = HighInterventionsPerformed?.Performed;
                        object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);

                        return (bv_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (be_())
                    {
                        DataType bw_ = HighInterventionsPerformed?.Performed;
                        object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);

                        return (bx_ as CqlQuantity) as object;
                    }
                    else if (bf_())
                    {
                        DataType by_ = HighInterventionsPerformed?.Performed;
                        object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);

                        return (bz_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> z_ = QICoreCommon_4_0_000.Instance.toInterval(context, y_());
                CqlDateTime aa_ = context.Operators.Start(z_);
                bool? ab_ = context.Operators.Before(x_, aa_, "day");
                bool? ac_ = context.Operators.Not(ab_);
                bool? ad_ = context.Operators.And(v_, ac_);

                return ad_;
            };
            IEnumerable<Condition> m_ = context.Operators.Where<Condition>(k_, l_);
            bool? n_ = context.Operators.Exists<Condition>(m_);
            bool? o_ = context.Operators.Or(i_, n_);

            return o_;
        };
        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("High BMI And Follow Up Provided")]
    public IEnumerable<Observation> High_BMI_And_Follow_Up_Provided(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Documented_High_BMI_During_Measurement_Period(context);
        IEnumerable<Observation> b_(Observation HighBMI)
        {
            IEnumerable<object> d_ = this.High_BMI_Interventions_Ordered(context);
            IEnumerable<Procedure> e_ = this.High_BMI_Interventions_Performed(context);
            IEnumerable<object> f_ = context.Operators.Union<object>(d_ as IEnumerable<object>, e_ as IEnumerable<object>);
            bool? g_(object HighBMIInterventions)
            {
                object k_()
                {
                    bool s_()
                    {
                        object w_ = context.Operators.LateBoundProperty<object>(HighBMIInterventions, "performed");
                        object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                        bool y_ = x_ is CqlDateTime;

                        return y_;
                    };
                    bool t_()
                    {
                        object z_ = context.Operators.LateBoundProperty<object>(HighBMIInterventions, "performed");
                        object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                        bool ab_ = aa_ is CqlInterval<CqlDateTime>;

                        return ab_;
                    };
                    bool u_()
                    {
                        object ac_ = context.Operators.LateBoundProperty<object>(HighBMIInterventions, "performed");
                        object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                        bool ae_ = ad_ is CqlQuantity;

                        return ae_;
                    };
                    bool v_()
                    {
                        object af_ = context.Operators.LateBoundProperty<object>(HighBMIInterventions, "performed");
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        bool ah_ = ag_ is CqlInterval<CqlQuantity>;

                        return ah_;
                    };
                    if (s_())
                    {
                        object ai_ = context.Operators.LateBoundProperty<object>(HighBMIInterventions, "performed");
                        object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);

                        return (aj_ as CqlDateTime) as object;
                    }
                    else if (t_())
                    {
                        object ak_ = context.Operators.LateBoundProperty<object>(HighBMIInterventions, "performed");
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);

                        return (al_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (u_())
                    {
                        object am_ = context.Operators.LateBoundProperty<object>(HighBMIInterventions, "performed");
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);

                        return (an_ as CqlQuantity) as object;
                    }
                    else if (v_())
                    {
                        object ao_ = context.Operators.LateBoundProperty<object>(HighBMIInterventions, "performed");
                        object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);

                        return (ap_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_());
                object m_ = context.Operators.LateBoundProperty<object>(HighBMIInterventions, "authoredOn");
                CqlDateTime n_ = context.Operators.LateBoundProperty<CqlDateTime>(m_, "value");
                CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_ as object);
                CqlDateTime p_ = context.Operators.Start(l_ ?? o_);
                CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
                bool? r_ = context.Operators.In<CqlDateTime>(p_, q_, "day");

                return r_;
            };
            IEnumerable<object> h_ = context.Operators.Where<object>(f_, g_);
            Observation i_(object HighBMIInterventions) =>
                HighBMI;
            IEnumerable<Observation> j_ = context.Operators.Select<object, Observation>(h_, i_);

            return j_;
        };
        IEnumerable<Observation> c_ = context.Operators.SelectMany<Observation, Observation>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Documented Low BMI During Measurement Period")]
    public IEnumerable<Observation> Documented_Low_BMI_During_Measurement_Period(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.BMI_During_Measurement_Period(context);
        bool? b_(Observation BMI)
        {
            CqlInterval<CqlDateTime> d_ = this.Measurement_Period(context);
            DataType e_ = BMI?.Effective;
            object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
            CqlInterval<CqlDateTime> g_ = QICoreCommon_4_0_000.Instance.toInterval(context, f_);
            bool? h_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(d_, g_, "day");
            DataType i_ = BMI?.Value;
            CqlQuantity j_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, i_ as Quantity);
            CqlQuantity k_ = context.Operators.Quantity(18.5m, "kg/m2");
            bool? l_ = context.Operators.Less(j_, k_);
            bool? m_ = context.Operators.And(h_, l_);

            return m_;
        };
        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Low BMI Interventions Ordered")]
    public IEnumerable<object> Low_BMI_Interventions_Ordered(CqlContext context)
    {
        CqlValueSet a_ = this.Follow_Up_for_Below_Normal_BMI(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        CqlValueSet c_ = this.Referrals_Where_Weight_Assessment_May_Occur(context);
        IEnumerable<ServiceRequest> d_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> e_ = context.Operators.Union<ServiceRequest>(b_, d_);
        CqlValueSet f_ = this.Medications_for_Below_Normal_BMI(context);
        IEnumerable<MedicationRequest> g_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> i_(MedicationRequest MR)
        {
            IEnumerable<Medication> o_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? p_(Medication M)
            {
                object t_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object u_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> v_ = context.Operators.Split((string)u_, "/");
                string w_ = context.Operators.Last<string>(v_);
                bool? x_ = context.Operators.Equal(t_, w_);
                CodeableConcept y_ = M?.Code;
                CqlConcept z_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, y_);
                CqlValueSet aa_ = this.Medications_for_Below_Normal_BMI(context);
                bool? ab_ = context.Operators.ConceptInValueSet(z_, aa_);
                bool? ac_ = context.Operators.And(x_, ab_);

                return ac_;
            };
            IEnumerable<Medication> q_ = context.Operators.Where<Medication>(o_, p_);
            MedicationRequest r_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> s_ = context.Operators.Select<Medication, MedicationRequest>(q_, r_);

            return s_;
        };
        IEnumerable<MedicationRequest> j_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(h_, i_);
        IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(g_, j_);
        IEnumerable<object> l_ = context.Operators.Union<object>(e_ as IEnumerable<object>, k_ as IEnumerable<object>);
        bool? m_(object LowInterventionsOrdered)
        {
            object ad_ = context.Operators.LateBoundProperty<object>(LowInterventionsOrdered, "reasonCode");
            object[] ae_ = [
                ad_,
            ];
            CqlConcept af_(object @this)
            {
                CqlConcept ap_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this as CodeableConcept);

                return ap_;
            };
            IEnumerable<CqlConcept> ag_ = context.Operators.Select<object, CqlConcept>((IEnumerable<object>)ae_, af_);
            CqlValueSet ah_ = this.Underweight(context);
            bool? ai_ = context.Operators.ConceptsInValueSet(ag_, ah_);
            IEnumerable<Condition> ak_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ah_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            bool? al_(Condition UnderweightDiagnosis)
            {
                bool? aq_ = QICoreCommon_4_0_000.Instance.isHealthConcern(context, UnderweightDiagnosis as object);
                bool? ar_ = QICoreCommon_4_0_000.Instance.isActive(context, UnderweightDiagnosis as object);
                bool? as_ = context.Operators.And(aq_, ar_);
                CqlInterval<CqlDateTime> at_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, UnderweightDiagnosis as object);
                CqlDateTime au_ = context.Operators.Start(at_);
                object av_ = context.Operators.LateBoundProperty<object>(LowInterventionsOrdered, "authoredOn");
                CqlDateTime aw_ = context.Operators.LateBoundProperty<CqlDateTime>(av_, "value");
                bool? ax_ = context.Operators.SameOrBefore(au_, aw_, "day");
                bool? ay_ = context.Operators.And(as_, ax_);
                CqlDateTime ba_ = context.Operators.LateBoundProperty<CqlDateTime>(av_, "value");
                CqlInterval<CqlDateTime> bb_ = this.Measurement_Period(context);
                bool? bc_ = context.Operators.In<CqlDateTime>(ba_, bb_, "day");
                bool? bd_ = context.Operators.And(ay_, bc_);

                return bd_;
            };
            IEnumerable<Condition> am_ = context.Operators.Where<Condition>(ak_, al_);
            bool? an_ = context.Operators.Exists<Condition>(am_);
            bool? ao_ = context.Operators.Or(ai_, an_);

            return ao_;
        };
        IEnumerable<object> n_ = context.Operators.Where<object>(l_, m_);

        return n_;
    }


    [CqlExpressionDefinition("Low BMI Interventions Performed")]
    public IEnumerable<Procedure> Low_BMI_Interventions_Performed(CqlContext context)
    {
        CqlValueSet a_ = this.Follow_Up_for_Below_Normal_BMI(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? c_(Procedure LowInterventionsPerformed)
        {
            List<CodeableConcept> e_ = LowInterventionsPerformed?.ReasonCode;
            CqlConcept f_(CodeableConcept @this)
            {
                CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return u_;
            };
            IEnumerable<CqlConcept> g_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)e_, f_);
            CqlValueSet h_ = this.Underweight(context);
            bool? i_ = context.Operators.ConceptsInValueSet(g_, h_);
            Code<EventStatus> j_ = LowInterventionsPerformed?.StatusElement;
            EventStatus? k_ = j_?.Value;
            string l_ = context.Operators.Convert<string>(k_);
            bool? m_ = context.Operators.Equal(l_, "completed");
            bool? n_ = context.Operators.And(i_, m_);
            IEnumerable<Condition> p_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            bool? q_(Condition UnderweightDiagnosis)
            {
                bool? v_ = QICoreCommon_4_0_000.Instance.isHealthConcern(context, UnderweightDiagnosis as object);
                bool? w_ = QICoreCommon_4_0_000.Instance.isActive(context, UnderweightDiagnosis as object);
                bool? x_ = context.Operators.And(v_, w_);
                CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, UnderweightDiagnosis as object);
                CqlDateTime z_ = context.Operators.Start(y_);
                object aa_()
                {
                    bool as_()
                    {
                        DataType aw_ = LowInterventionsPerformed?.Performed;
                        object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                        bool ay_ = ax_ is CqlDateTime;

                        return ay_;
                    };
                    bool at_()
                    {
                        DataType az_ = LowInterventionsPerformed?.Performed;
                        object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                        bool bb_ = ba_ is CqlInterval<CqlDateTime>;

                        return bb_;
                    };
                    bool au_()
                    {
                        DataType bc_ = LowInterventionsPerformed?.Performed;
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                        bool be_ = bd_ is CqlQuantity;

                        return be_;
                    };
                    bool av_()
                    {
                        DataType bf_ = LowInterventionsPerformed?.Performed;
                        object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                        bool bh_ = bg_ is CqlInterval<CqlQuantity>;

                        return bh_;
                    };
                    if (as_())
                    {
                        DataType bi_ = LowInterventionsPerformed?.Performed;
                        object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);

                        return (bj_ as CqlDateTime) as object;
                    }
                    else if (at_())
                    {
                        DataType bk_ = LowInterventionsPerformed?.Performed;
                        object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);

                        return (bl_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (au_())
                    {
                        DataType bm_ = LowInterventionsPerformed?.Performed;
                        object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);

                        return (bn_ as CqlQuantity) as object;
                    }
                    else if (av_())
                    {
                        DataType bo_ = LowInterventionsPerformed?.Performed;
                        object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);

                        return (bp_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> ab_ = QICoreCommon_4_0_000.Instance.toInterval(context, aa_());
                CqlDateTime ac_ = context.Operators.Start(ab_);
                bool? ad_ = context.Operators.SameOrBefore(z_, ac_, "day");
                bool? ae_ = context.Operators.And(x_, ad_);
                CqlInterval<CqlDateTime> af_ = this.Measurement_Period(context);
                object ag_()
                {
                    bool bq_()
                    {
                        DataType bu_ = LowInterventionsPerformed?.Performed;
                        object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                        bool bw_ = bv_ is CqlDateTime;

                        return bw_;
                    };
                    bool br_()
                    {
                        DataType bx_ = LowInterventionsPerformed?.Performed;
                        object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                        bool bz_ = by_ is CqlInterval<CqlDateTime>;

                        return bz_;
                    };
                    bool bs_()
                    {
                        DataType ca_ = LowInterventionsPerformed?.Performed;
                        object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                        bool cc_ = cb_ is CqlQuantity;

                        return cc_;
                    };
                    bool bt_()
                    {
                        DataType cd_ = LowInterventionsPerformed?.Performed;
                        object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                        bool cf_ = ce_ is CqlInterval<CqlQuantity>;

                        return cf_;
                    };
                    if (bq_())
                    {
                        DataType cg_ = LowInterventionsPerformed?.Performed;
                        object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);

                        return (ch_ as CqlDateTime) as object;
                    }
                    else if (br_())
                    {
                        DataType ci_ = LowInterventionsPerformed?.Performed;
                        object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);

                        return (cj_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (bs_())
                    {
                        DataType ck_ = LowInterventionsPerformed?.Performed;
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);

                        return (cl_ as CqlQuantity) as object;
                    }
                    else if (bt_())
                    {
                        DataType cm_ = LowInterventionsPerformed?.Performed;
                        object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);

                        return (cn_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_());
                bool? ai_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(af_, ah_, "day");
                bool? aj_ = context.Operators.And(ae_, ai_);
                CqlDateTime al_ = context.Operators.End(y_);
                object am_()
                {
                    bool co_()
                    {
                        DataType cs_ = LowInterventionsPerformed?.Performed;
                        object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                        bool cu_ = ct_ is CqlDateTime;

                        return cu_;
                    };
                    bool cp_()
                    {
                        DataType cv_ = LowInterventionsPerformed?.Performed;
                        object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                        bool cx_ = cw_ is CqlInterval<CqlDateTime>;

                        return cx_;
                    };
                    bool cq_()
                    {
                        DataType cy_ = LowInterventionsPerformed?.Performed;
                        object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                        bool da_ = cz_ is CqlQuantity;

                        return da_;
                    };
                    bool cr_()
                    {
                        DataType db_ = LowInterventionsPerformed?.Performed;
                        object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                        bool dd_ = dc_ is CqlInterval<CqlQuantity>;

                        return dd_;
                    };
                    if (co_())
                    {
                        DataType de_ = LowInterventionsPerformed?.Performed;
                        object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);

                        return (df_ as CqlDateTime) as object;
                    }
                    else if (cp_())
                    {
                        DataType dg_ = LowInterventionsPerformed?.Performed;
                        object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);

                        return (dh_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (cq_())
                    {
                        DataType di_ = LowInterventionsPerformed?.Performed;
                        object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);

                        return (dj_ as CqlQuantity) as object;
                    }
                    else if (cr_())
                    {
                        DataType dk_ = LowInterventionsPerformed?.Performed;
                        object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);

                        return (dl_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> an_ = QICoreCommon_4_0_000.Instance.toInterval(context, am_());
                CqlDateTime ao_ = context.Operators.Start(an_);
                bool? ap_ = context.Operators.Before(al_, ao_, "day");
                bool? aq_ = context.Operators.Not(ap_);
                bool? ar_ = context.Operators.And(aj_, aq_);

                return ar_;
            };
            IEnumerable<Condition> r_ = context.Operators.Where<Condition>(p_, q_);
            bool? s_ = context.Operators.Exists<Condition>(r_);
            bool? t_ = context.Operators.Or(n_, s_);

            return t_;
        };
        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("Low BMI And Follow Up Provided")]
    public IEnumerable<Observation> Low_BMI_And_Follow_Up_Provided(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Documented_Low_BMI_During_Measurement_Period(context);
        IEnumerable<Observation> b_(Observation LowBMI)
        {
            IEnumerable<object> d_ = this.Low_BMI_Interventions_Ordered(context);
            IEnumerable<Procedure> e_ = this.Low_BMI_Interventions_Performed(context);
            IEnumerable<object> f_ = context.Operators.Union<object>(d_ as IEnumerable<object>, e_ as IEnumerable<object>);
            bool? g_(object LowBMIInterventions)
            {
                object k_()
                {
                    bool s_()
                    {
                        object w_ = context.Operators.LateBoundProperty<object>(LowBMIInterventions, "performed");
                        object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                        bool y_ = x_ is CqlDateTime;

                        return y_;
                    };
                    bool t_()
                    {
                        object z_ = context.Operators.LateBoundProperty<object>(LowBMIInterventions, "performed");
                        object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                        bool ab_ = aa_ is CqlInterval<CqlDateTime>;

                        return ab_;
                    };
                    bool u_()
                    {
                        object ac_ = context.Operators.LateBoundProperty<object>(LowBMIInterventions, "performed");
                        object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                        bool ae_ = ad_ is CqlQuantity;

                        return ae_;
                    };
                    bool v_()
                    {
                        object af_ = context.Operators.LateBoundProperty<object>(LowBMIInterventions, "performed");
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        bool ah_ = ag_ is CqlInterval<CqlQuantity>;

                        return ah_;
                    };
                    if (s_())
                    {
                        object ai_ = context.Operators.LateBoundProperty<object>(LowBMIInterventions, "performed");
                        object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);

                        return (aj_ as CqlDateTime) as object;
                    }
                    else if (t_())
                    {
                        object ak_ = context.Operators.LateBoundProperty<object>(LowBMIInterventions, "performed");
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);

                        return (al_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (u_())
                    {
                        object am_ = context.Operators.LateBoundProperty<object>(LowBMIInterventions, "performed");
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);

                        return (an_ as CqlQuantity) as object;
                    }
                    else if (v_())
                    {
                        object ao_ = context.Operators.LateBoundProperty<object>(LowBMIInterventions, "performed");
                        object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);

                        return (ap_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_());
                object m_ = context.Operators.LateBoundProperty<object>(LowBMIInterventions, "authoredOn");
                CqlDateTime n_ = context.Operators.LateBoundProperty<CqlDateTime>(m_, "value");
                CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_ as object);
                CqlDateTime p_ = context.Operators.Start(l_ ?? o_);
                CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
                bool? r_ = context.Operators.In<CqlDateTime>(p_, q_, "day");

                return r_;
            };
            IEnumerable<object> h_ = context.Operators.Where<object>(f_, g_);
            Observation i_(object LowBMIInterventions) =>
                LowBMI;
            IEnumerable<Observation> j_ = context.Operators.Select<object, Observation>(h_, i_);

            return j_;
        };
        IEnumerable<Observation> c_ = context.Operators.SelectMany<Observation, Observation>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Has Normal BMI")]
    public bool? Has_Normal_BMI(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.BMI_During_Measurement_Period(context);
        bool? b_(Observation BMI)
        {
            DataType l_ = BMI?.Value;
            CqlQuantity m_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, l_ as Quantity);
            CqlQuantity n_ = context.Operators.Quantity(18.5m, "kg/m2");
            bool? o_ = context.Operators.GreaterOrEqual(m_, n_);
            CqlQuantity q_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, l_ as Quantity);
            CqlQuantity r_ = context.Operators.Quantity(25m, "kg/m2");
            bool? s_ = context.Operators.Less(q_, r_);
            bool? t_ = context.Operators.And(o_, s_);

            return t_;
        };
        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);
        bool? d_ = context.Operators.Exists<Observation>(c_);
        IEnumerable<Observation> e_ = this.Documented_High_BMI_During_Measurement_Period(context);
        bool? f_ = context.Operators.Exists<Observation>(e_);
        IEnumerable<Observation> g_ = this.Documented_Low_BMI_During_Measurement_Period(context);
        bool? h_ = context.Operators.Exists<Observation>(g_);
        bool? i_ = context.Operators.Or(f_, h_);
        bool? j_ = context.Operators.Not(i_);
        bool? k_ = context.Operators.And(d_, j_);

        return k_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.High_BMI_And_Follow_Up_Provided(context);
        bool? b_ = context.Operators.Exists<Observation>(a_);
        IEnumerable<Observation> c_ = this.Low_BMI_And_Follow_Up_Provided(context);
        bool? d_ = context.Operators.Exists<Observation>(c_);
        bool? e_ = context.Operators.Or(b_, d_);
        bool? f_ = this.Has_Normal_BMI(context);
        bool? g_ = context.Operators.Or(e_, f_);

        return g_;
    }


    [CqlExpressionDefinition("Medical Reason For Not Documenting A Follow Up Plan For Low Or High BMI")]
    public IEnumerable<object> Medical_Reason_For_Not_Documenting_A_Follow_Up_Plan_For_Low_Or_High_BMI(CqlContext context)
    {
        CqlValueSet a_ = this.Referrals_Where_Weight_Assessment_May_Occur(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> d_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> e_ = context.Operators.Union<ServiceRequest>(b_, d_);
        CqlValueSet f_ = this.Follow_Up_for_Above_Normal_BMI(context);
        IEnumerable<ServiceRequest> g_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> i_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> j_ = context.Operators.Union<ServiceRequest>(g_, i_);
        IEnumerable<ServiceRequest> k_ = context.Operators.Union<ServiceRequest>(e_, j_);
        CqlValueSet l_ = this.Follow_Up_for_Below_Normal_BMI(context);
        IEnumerable<ServiceRequest> m_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> o_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> p_ = context.Operators.Union<ServiceRequest>(m_, o_);
        IEnumerable<ServiceRequest> q_ = context.Operators.Union<ServiceRequest>(k_, p_);
        IEnumerable<ServiceRequest> r_(ServiceRequest NoBMIFollowUp)
        {
            IEnumerable<Encounter> al_ = this.Qualifying_Encounter_During_Day_Of_Measurement_Period(context);
            bool? am_(Encounter QualifyingEncounter)
            {
                FhirDateTime aq_ = NoBMIFollowUp?.AuthoredOnElement;
                CqlDateTime ar_ = context.Operators.Convert<CqlDateTime>(aq_);
                Period as_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> at_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, as_);
                CqlDateTime au_ = context.Operators.Start(at_);
                bool? av_ = context.Operators.SameAs(ar_, au_, "day");

                return av_;
            };
            IEnumerable<Encounter> an_ = context.Operators.Where<Encounter>(al_, am_);
            ServiceRequest ao_(Encounter QualifyingEncounter) =>
                NoBMIFollowUp;
            IEnumerable<ServiceRequest> ap_ = context.Operators.Select<Encounter, ServiceRequest>(an_, ao_);

            return ap_;
        };
        IEnumerable<ServiceRequest> s_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(q_, r_);
        bool? t_(ServiceRequest NoBMIFollowUp)
        {
            Code<RequestStatus> aw_ = NoBMIFollowUp?.StatusElement;
            RequestStatus? ax_ = aw_?.Value;
            Code<RequestStatus> ay_ = context.Operators.Convert<Code<RequestStatus>>(ax_);
            bool? az_ = context.Operators.Equivalent(ay_, "completed");
            bool? ba_(Extension @this)
            {
                string bj_ = @this?.Url;
                FhirString bk_ = context.Operators.Convert<FhirString>(bj_);
                string bl_ = FHIRHelpers_4_4_000.Instance.ToString(context, bk_);
                bool? bm_ = context.Operators.Equal(bl_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                return bm_;
            };
            IEnumerable<Extension> bb_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoBMIFollowUp is DomainResource
                    ? (NoBMIFollowUp as DomainResource).Extension
                    : default), ba_);
            object bc_(Extension @this)
            {
                DataType bn_ = @this?.Value;

                return bn_;
            };
            IEnumerable<object> bd_ = context.Operators.Select<Extension, object>(bb_, bc_);
            object be_ = context.Operators.SingletonFrom<object>(bd_);
            CqlConcept bf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, be_ as CodeableConcept);
            CqlValueSet bg_ = this.Medical_Reason(context);
            bool? bh_ = context.Operators.ConceptInValueSet(bf_, bg_);
            bool? bi_ = context.Operators.And(az_, bh_);

            return bi_;
        };
        IEnumerable<ServiceRequest> u_ = context.Operators.Where<ServiceRequest>(s_, t_);
        CqlValueSet v_ = this.Medications_for_Above_Normal_BMI(context);
        IEnumerable<MedicationRequest> w_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> y_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> z_ = context.Operators.Union<MedicationRequest>(w_, y_);
        CqlValueSet aa_ = this.Medications_for_Below_Normal_BMI(context);
        IEnumerable<MedicationRequest> ab_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, aa_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> ad_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, aa_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> ae_ = context.Operators.Union<MedicationRequest>(ab_, ad_);
        IEnumerable<MedicationRequest> af_ = context.Operators.Union<MedicationRequest>(z_, ae_);
        IEnumerable<MedicationRequest> ag_(MedicationRequest NoBMIFollowUp)
        {
            IEnumerable<Encounter> bo_ = this.Qualifying_Encounter_During_Day_Of_Measurement_Period(context);
            bool? bp_(Encounter QualifyingEncounter)
            {
                FhirDateTime bt_ = NoBMIFollowUp?.AuthoredOnElement;
                CqlDateTime bu_ = context.Operators.Convert<CqlDateTime>(bt_);
                Period bv_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> bw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bv_);
                CqlDateTime bx_ = context.Operators.Start(bw_);
                bool? by_ = context.Operators.SameAs(bu_, bx_, "day");

                return by_;
            };
            IEnumerable<Encounter> bq_ = context.Operators.Where<Encounter>(bo_, bp_);
            MedicationRequest br_(Encounter QualifyingEncounter) =>
                NoBMIFollowUp;
            IEnumerable<MedicationRequest> bs_ = context.Operators.Select<Encounter, MedicationRequest>(bq_, br_);

            return bs_;
        };
        IEnumerable<MedicationRequest> ah_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(af_, ag_);
        bool? ai_(MedicationRequest NoBMIFollowUp)
        {
            Code<MedicationRequest.MedicationrequestStatus> bz_ = NoBMIFollowUp?.StatusElement;
            MedicationRequest.MedicationrequestStatus? ca_ = bz_?.Value;
            string cb_ = context.Operators.Convert<string>(ca_);
            bool? cc_ = context.Operators.Equivalent(cb_, "completed");
            List<CodeableConcept> cd_ = NoBMIFollowUp?.ReasonCode;
            CqlConcept ce_(CodeableConcept @this)
            {
                CqlConcept cj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return cj_;
            };
            IEnumerable<CqlConcept> cf_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)cd_, ce_);
            CqlValueSet cg_ = this.Medical_Reason(context);
            bool? ch_ = context.Operators.ConceptsInValueSet(cf_, cg_);
            bool? ci_ = context.Operators.And(cc_, ch_);

            return ci_;
        };
        IEnumerable<MedicationRequest> aj_ = context.Operators.Where<MedicationRequest>(ah_, ai_);
        IEnumerable<object> ak_ = context.Operators.Union<object>(u_ as IEnumerable<object>, aj_ as IEnumerable<object>);

        return ak_;
    }


    [CqlExpressionDefinition("Medical Reason Or Patient Reason For Not Performing BMI Exam")]
    public IEnumerable<Observation> Medical_Reason_Or_Patient_Reason_For_Not_Performing_BMI_Exam(CqlContext context)
    {
        CqlCode a_ = this.Body_mass_index__BMI___Ratio_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationcancelled"));
        IEnumerable<Observation> d_(Observation NoBMI)
        {
            IEnumerable<Encounter> h_ = this.Qualifying_Encounter_During_Day_Of_Measurement_Period(context);
            bool? i_(Encounter QualifyingEncounter)
            {
                DataType m_ = NoBMI?.Effective;
                object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_);
                CqlDateTime p_ = context.Operators.End(o_);
                Period q_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
                CqlDateTime s_ = context.Operators.Start(r_);
                bool? t_ = context.Operators.SameAs(p_, s_, "day");

                return t_;
            };
            IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
            Observation k_(Encounter QualifyingEncounter) =>
                NoBMI;
            IEnumerable<Observation> l_ = context.Operators.Select<Encounter, Observation>(j_, k_);

            return l_;
        };
        IEnumerable<Observation> e_ = context.Operators.SelectMany<Observation, Observation>(c_, d_);
        bool? f_(Observation NoBMI)
        {
            Code<ObservationStatus> u_ = NoBMI?.StatusElement;
            ObservationStatus? v_ = u_?.Value;
            Code<ObservationStatus> w_ = context.Operators.Convert<Code<ObservationStatus>>(v_);
            bool? x_ = context.Operators.Equal(w_, "cancelled");
            bool? y_(Extension @this)
            {
                string aq_ = @this?.Url;
                FhirString ar_ = context.Operators.Convert<FhirString>(aq_);
                string as_ = FHIRHelpers_4_4_000.Instance.ToString(context, ar_);
                bool? at_ = context.Operators.Equal(as_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

                return at_;
            };
            IEnumerable<Extension> z_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoBMI is DomainResource
                    ? (NoBMI as DomainResource).Extension
                    : default), y_);
            object aa_(Extension @this)
            {
                DataType au_ = @this?.Value;

                return au_;
            };
            IEnumerable<object> ab_ = context.Operators.Select<Extension, object>(z_, aa_);
            object ac_ = context.Operators.SingletonFrom<object>(ab_);
            CqlConcept ad_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ac_ as CodeableConcept);
            CqlValueSet ae_ = this.Patient_Declined(context);
            bool? af_ = context.Operators.ConceptInValueSet(ad_, ae_);
            bool? ag_(Extension @this)
            {
                string av_ = @this?.Url;
                FhirString aw_ = context.Operators.Convert<FhirString>(av_);
                string ax_ = FHIRHelpers_4_4_000.Instance.ToString(context, aw_);
                bool? ay_ = context.Operators.Equal(ax_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

                return ay_;
            };
            IEnumerable<Extension> ah_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoBMI is DomainResource
                    ? (NoBMI as DomainResource).Extension
                    : default), ag_);
            object ai_(Extension @this)
            {
                DataType az_ = @this?.Value;

                return az_;
            };
            IEnumerable<object> aj_ = context.Operators.Select<Extension, object>(ah_, ai_);
            object ak_ = context.Operators.SingletonFrom<object>(aj_);
            CqlConcept al_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ak_ as CodeableConcept);
            CqlValueSet am_ = this.Medical_Reason(context);
            bool? an_ = context.Operators.ConceptInValueSet(al_, am_);
            bool? ao_ = context.Operators.Or(af_, an_);
            bool? ap_ = context.Operators.And(x_, ao_);

            return ap_;
        };
        IEnumerable<Observation> g_ = context.Operators.Where<Observation>(e_, f_);

        return g_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<object> a_ = this.Medical_Reason_For_Not_Documenting_A_Follow_Up_Plan_For_Low_Or_High_BMI(context);
        bool? b_ = context.Operators.Exists<object>(a_);
        IEnumerable<Observation> c_ = this.Medical_Reason_Or_Patient_Reason_For_Not_Performing_BMI_Exam(context);
        bool? d_ = context.Operators.Exists<Observation>(c_);
        bool? e_ = context.Operators.Or(b_, d_);

        return e_;
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
