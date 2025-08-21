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
[CqlLibrary("PCSBMIScreenAndFollowUpFHIR", "0.2.000")]
public partial class PCSBMIScreenAndFollowUpFHIR_0_2_000 : ILibrary, ISingleton<PCSBMIScreenAndFollowUpFHIR_0_2_000>
{
    private PCSBMIScreenAndFollowUpFHIR_0_2_000() {}

    public static PCSBMIScreenAndFollowUpFHIR_0_2_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "PCSBMIScreenAndFollowUpFHIR";
    public string Version => "0.2.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, Hospice_6_12_000.Instance, PalliativeCare_1_11_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance];

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
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("PCSBMIScreenAndFollowUpFHIR-0.2.000", "Measurement Period", c_);

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


    [CqlExpressionDefinition("Qualifying Encounter during Day of Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_during_Day_of_Measurement_Period(CqlContext context)
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
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Day_of_Measurement_Period(context);
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


    [CqlExpressionDefinition("Is Pregnant during Day of Measurement Period")]
    public IEnumerable<Condition> Is_Pregnant_during_Day_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet a_ = this.Pregnancy_or_Other_Related_Diagnoses(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> c_(Condition PregnancyDiagnosis)
        {
            IEnumerable<Encounter> e_ = this.Qualifying_Encounter_during_Day_of_Measurement_Period(context);
            bool? f_(Encounter QualifyingEncounter)
            {
                CodeableConcept j_ = PregnancyDiagnosis?.ClinicalStatus;
                CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
                CqlCode l_ = QICoreCommon_2_1_000.Instance.active(context);
                CqlConcept m_ = context.Operators.ConvertCodeToConcept(l_);
                bool? n_ = context.Operators.Equivalent(k_, m_);
                CqlInterval<CqlDateTime> o_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PregnancyDiagnosis);
                CqlInterval<CqlDateTime> p_ = this.Measurement_Period(context);
                bool? q_ = context.Operators.Overlaps(o_, p_, "day");
                bool? r_ = context.Operators.And(n_, q_);

                return r_;
            };
            IEnumerable<Encounter> g_ = context.Operators.Where<Encounter>(e_, f_);
            Condition h_(Encounter QualifyingEncounter) =>
                PregnancyDiagnosis;
            IEnumerable<Condition> i_ = context.Operators.Select<Encounter, Condition>(g_, h_);

            return i_;
        };
        IEnumerable<Condition> d_ = context.Operators.SelectMany<Condition, Condition>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? a_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? b_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? c_ = context.Operators.Or(a_, b_);
        IEnumerable<Condition> d_ = this.Is_Pregnant_during_Day_of_Measurement_Period(context);
        bool? e_ = context.Operators.Exists<Condition>(d_);
        bool? f_ = context.Operators.Or(c_, e_);

        return f_;
    }


    [CqlExpressionDefinition("BMI during Measurement Period")]
    public IEnumerable<Observation> BMI_during_Measurement_Period(CqlContext context)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bmi"));
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
            bool? l_ = context.Operators.In<string>(j_, k_ as IEnumerable<string>);
            bool? m_ = context.Operators.And(g_, l_);
            CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
            DataType o_ = BMI?.Effective;
            object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
            CqlInterval<CqlDateTime> q_ = QICoreCommon_2_1_000.Instance.toInterval(context, p_);
            bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(n_, q_, "day");
            bool? s_ = context.Operators.And(m_, r_);

            return s_;
        };
        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Documented High BMI during Measurement Period")]
    public IEnumerable<Observation> Documented_High_BMI_during_Measurement_Period(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.BMI_during_Measurement_Period(context);
        bool? b_(Observation BMI)
        {
            CqlInterval<CqlDateTime> d_ = this.Measurement_Period(context);
            DataType e_ = BMI?.Effective;
            object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
            CqlInterval<CqlDateTime> g_ = QICoreCommon_2_1_000.Instance.toInterval(context, f_);
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
                CqlConcept ar_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this as CodeableConcept);

                return ar_;
            };
            IEnumerable<CqlConcept> ag_ = context.Operators.Select<object, CqlConcept>((IEnumerable<object>)ae_, af_);
            CqlConcept ah_ = context.Operators.SingletonFrom<CqlConcept>(ag_);
            CqlConcept[] ai_ = [
                ah_,
            ];
            CqlValueSet aj_ = this.Overweight_or_Obese(context);
            bool? ak_ = context.Operators.ConceptsInValueSet((IEnumerable<CqlConcept>)ai_, aj_);
            IEnumerable<Condition> am_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, aj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? an_(Condition OverweightObese)
            {
                bool? as_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, OverweightObese);
                bool? at_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, OverweightObese);
                bool? au_ = context.Operators.Or(as_, at_);
                bool? av_ = QICoreCommon_2_1_000.Instance.isActive(context, OverweightObese);
                bool? aw_ = context.Operators.And(au_, av_);
                CqlInterval<CqlDateTime> ax_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, OverweightObese);
                CqlDateTime ay_ = context.Operators.Start(ax_);
                object az_ = context.Operators.LateBoundProperty<object>(HighInterventionsOrdered, "authoredOn");
                CqlDateTime ba_ = context.Operators.LateBoundProperty<CqlDateTime>(az_, "value");
                bool? bb_ = context.Operators.SameOrBefore(ay_, ba_, "day");
                bool? bc_ = context.Operators.And(aw_, bb_);

                return bc_;
            };
            IEnumerable<Condition> ao_ = context.Operators.Where<Condition>(am_, an_);
            bool? ap_ = context.Operators.Exists<Condition>(ao_);
            bool? aq_ = context.Operators.Or(ak_, ap_);

            return aq_;
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
            IEnumerable<Condition> k_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? l_(Condition OverweightObese)
            {
                CqlInterval<CqlDateTime> q_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, OverweightObese);
                CqlDateTime r_ = context.Operators.Start(q_);
                DataType s_ = HighInterventionsPerformed?.Performed;
                object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                bool? u_ = context.Operators.SameOrBefore(r_, t_ as CqlDateTime, "day");
                CqlDateTime w_ = context.Operators.End(q_);
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                bool? z_ = context.Operators.Before(w_, y_ as CqlDateTime, "day");
                bool? aa_ = context.Operators.Not(z_);
                bool? ab_ = context.Operators.And(u_, aa_);

                return ab_;
            };
            IEnumerable<Condition> m_ = context.Operators.Where<Condition>(k_, l_);
            bool? n_ = context.Operators.Exists<Condition>(m_);
            bool? o_ = context.Operators.Or(i_, n_);

            return o_;
        };
        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("High BMI and Follow up Provided")]
    public IEnumerable<Observation> High_BMI_and_Follow_up_Provided(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Documented_High_BMI_during_Measurement_Period(context);
        IEnumerable<Observation> b_(Observation HighBMI)
        {
            IEnumerable<object> d_ = this.High_BMI_Interventions_Ordered(context);
            IEnumerable<Procedure> e_ = this.High_BMI_Interventions_Performed(context);
            IEnumerable<object> f_ = context.Operators.Union<object>(d_ as IEnumerable<object>, e_ as IEnumerable<object>);
            bool? g_(object HighBMIInterventions)
            {
                object k_ = context.Operators.LateBoundProperty<object>(HighBMIInterventions, "performed");
                object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
                CqlInterval<CqlDateTime> m_ = QICoreCommon_2_1_000.Instance.toInterval(context, l_);
                object n_ = context.Operators.LateBoundProperty<object>(HighBMIInterventions, "authoredOn");
                CqlDateTime o_ = context.Operators.LateBoundProperty<CqlDateTime>(n_, "value");
                CqlInterval<CqlDateTime> p_ = QICoreCommon_2_1_000.Instance.toInterval(context, o_ as object);
                CqlDateTime q_ = context.Operators.Start(m_ ?? p_);
                CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
                bool? s_ = context.Operators.In<CqlDateTime>(q_, r_, "day");

                return s_;
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


    [CqlExpressionDefinition("Documented Low BMI during Measurement Period")]
    public IEnumerable<Observation> Documented_Low_BMI_during_Measurement_Period(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.BMI_during_Measurement_Period(context);
        bool? b_(Observation BMI)
        {
            CqlInterval<CqlDateTime> d_ = this.Measurement_Period(context);
            DataType e_ = BMI?.Effective;
            object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
            CqlInterval<CqlDateTime> g_ = QICoreCommon_2_1_000.Instance.toInterval(context, f_);
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
                CqlConcept ar_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this as CodeableConcept);

                return ar_;
            };
            IEnumerable<CqlConcept> ag_ = context.Operators.Select<object, CqlConcept>((IEnumerable<object>)ae_, af_);
            CqlConcept ah_ = context.Operators.SingletonFrom<CqlConcept>(ag_);
            CqlConcept[] ai_ = [
                ah_,
            ];
            CqlValueSet aj_ = this.Underweight(context);
            bool? ak_ = context.Operators.ConceptsInValueSet((IEnumerable<CqlConcept>)ai_, aj_);
            IEnumerable<Condition> am_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, aj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? an_(Condition Underweight)
            {
                bool? as_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, Underweight);
                bool? at_ = QICoreCommon_2_1_000.Instance.isActive(context, Underweight);
                bool? au_ = context.Operators.And(as_, at_);
                CqlInterval<CqlDateTime> av_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Underweight);
                CqlDateTime aw_ = context.Operators.Start(av_);
                object ax_ = context.Operators.LateBoundProperty<object>(LowInterventionsOrdered, "authoredOn");
                CqlDateTime ay_ = context.Operators.LateBoundProperty<CqlDateTime>(ax_, "value");
                bool? az_ = context.Operators.SameOrBefore(aw_, ay_, "day");
                bool? ba_ = context.Operators.And(au_, az_);
                CqlDateTime bc_ = context.Operators.LateBoundProperty<CqlDateTime>(ax_, "value");
                CqlInterval<CqlDateTime> bd_ = this.Measurement_Period(context);
                bool? be_ = context.Operators.In<CqlDateTime>(bc_, bd_, "day");
                bool? bf_ = context.Operators.And(ba_, be_);

                return bf_;
            };
            IEnumerable<Condition> ao_ = context.Operators.Where<Condition>(am_, an_);
            bool? ap_ = context.Operators.Exists<Condition>(ao_);
            bool? aq_ = context.Operators.Or(ak_, ap_);

            return aq_;
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
            IEnumerable<Condition> p_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? q_(Condition Underweight)
            {
                bool? v_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, Underweight);
                bool? w_ = QICoreCommon_2_1_000.Instance.isActive(context, Underweight);
                bool? x_ = context.Operators.And(v_, w_);
                CqlInterval<CqlDateTime> y_()
                {
                    bool ar_()
                    {
                        CqlInterval<CqlDateTime> as_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Underweight);
                        CqlDateTime at_ = context.Operators.Start(as_);

                        return at_ is null;
                    };
                    if (ar_())
                    {
                        return default;
                    }
                    else
                    {
                        CqlInterval<CqlDateTime> au_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Underweight);
                        CqlDateTime av_ = context.Operators.Start(au_);
                        CqlDateTime ax_ = context.Operators.Start(au_);
                        CqlInterval<CqlDateTime> ay_ = context.Operators.Interval(av_, ax_, true, true);

                        return ay_;
                    }
                };
                DataType z_ = LowInterventionsPerformed?.Performed;
                object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                CqlInterval<CqlDateTime> ab_ = QICoreCommon_2_1_000.Instance.toInterval(context, aa_);
                bool? ac_ = context.Operators.SameOrBefore(y_(), ab_, "day");
                bool? ad_ = context.Operators.And(x_, ac_);
                CqlInterval<CqlDateTime> ae_ = this.Measurement_Period(context);
                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                CqlInterval<CqlDateTime> ah_ = QICoreCommon_2_1_000.Instance.toInterval(context, ag_);
                bool? ai_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ae_, ah_, "day");
                bool? aj_ = context.Operators.And(ad_, ai_);
                CqlInterval<CqlDateTime> ak_()
                {
                    bool az_()
                    {
                        CqlInterval<CqlDateTime> ba_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Underweight);
                        CqlDateTime bb_ = context.Operators.End(ba_);

                        return bb_ is null;
                    };
                    if (az_())
                    {
                        return default;
                    }
                    else
                    {
                        CqlInterval<CqlDateTime> bc_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Underweight);
                        CqlDateTime bd_ = context.Operators.End(bc_);
                        CqlDateTime bf_ = context.Operators.End(bc_);
                        CqlInterval<CqlDateTime> bg_ = context.Operators.Interval(bd_, bf_, true, true);

                        return bg_;
                    }
                };
                object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                CqlInterval<CqlDateTime> an_ = QICoreCommon_2_1_000.Instance.toInterval(context, am_);
                bool? ao_ = context.Operators.Before(ak_(), an_, "day");
                bool? ap_ = context.Operators.Not(ao_);
                bool? aq_ = context.Operators.And(aj_, ap_);

                return aq_;
            };
            IEnumerable<Condition> r_ = context.Operators.Where<Condition>(p_, q_);
            bool? s_ = context.Operators.Exists<Condition>(r_);
            bool? t_ = context.Operators.Or(n_, s_);

            return t_;
        };
        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("Low BMI and Follow up Provided")]
    public IEnumerable<Observation> Low_BMI_and_Follow_up_Provided(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Documented_Low_BMI_during_Measurement_Period(context);
        IEnumerable<Observation> b_(Observation LowBMI)
        {
            IEnumerable<object> d_ = this.Low_BMI_Interventions_Ordered(context);
            IEnumerable<Procedure> e_ = this.Low_BMI_Interventions_Performed(context);
            IEnumerable<object> f_ = context.Operators.Union<object>(d_ as IEnumerable<object>, e_ as IEnumerable<object>);
            bool? g_(object LowBMIInterventions)
            {
                object k_ = context.Operators.LateBoundProperty<object>(LowBMIInterventions, "performed");
                object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
                CqlInterval<CqlDateTime> m_ = QICoreCommon_2_1_000.Instance.toInterval(context, l_);
                object n_ = context.Operators.LateBoundProperty<object>(LowBMIInterventions, "authoredOn");
                CqlDateTime o_ = context.Operators.LateBoundProperty<CqlDateTime>(n_, "value");
                CqlInterval<CqlDateTime> p_ = QICoreCommon_2_1_000.Instance.toInterval(context, o_ as object);
                CqlDateTime q_ = context.Operators.Start(m_ ?? p_);
                CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
                bool? s_ = context.Operators.In<CqlDateTime>(q_, r_, "day");

                return s_;
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
        IEnumerable<Observation> a_ = this.BMI_during_Measurement_Period(context);
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
        IEnumerable<Observation> e_ = this.Documented_High_BMI_during_Measurement_Period(context);
        bool? f_ = context.Operators.Exists<Observation>(e_);
        IEnumerable<Observation> g_ = this.Documented_Low_BMI_during_Measurement_Period(context);
        bool? h_ = context.Operators.Exists<Observation>(g_);
        bool? i_ = context.Operators.Or(f_, h_);
        bool? j_ = context.Operators.Not(i_);
        bool? k_ = context.Operators.And(d_, j_);

        return k_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.High_BMI_and_Follow_up_Provided(context);
        bool? b_ = context.Operators.Exists<Observation>(a_);
        IEnumerable<Observation> c_ = this.Low_BMI_and_Follow_up_Provided(context);
        bool? d_ = context.Operators.Exists<Observation>(c_);
        bool? e_ = context.Operators.Or(b_, d_);
        bool? f_ = this.Has_Normal_BMI(context);
        bool? g_ = context.Operators.Or(e_, f_);

        return g_;
    }


    [CqlExpressionDefinition("Medical Reason for Not Documenting a Follow up Plan for Low or High BMI")]
    public IEnumerable<object> Medical_Reason_for_Not_Documenting_a_Follow_up_Plan_for_Low_or_High_BMI(CqlContext context)
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
            IEnumerable<Encounter> al_ = this.Qualifying_Encounter_during_Day_of_Measurement_Period(context);
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
        IEnumerable<MedicationRequest> w_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> y_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> z_ = context.Operators.Union<MedicationRequest>(w_, y_);
        CqlValueSet aa_ = this.Medications_for_Below_Normal_BMI(context);
        IEnumerable<MedicationRequest> ab_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, aa_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> ad_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, aa_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> ae_ = context.Operators.Union<MedicationRequest>(ab_, ad_);
        IEnumerable<MedicationRequest> af_ = context.Operators.Union<MedicationRequest>(z_, ae_);
        IEnumerable<MedicationRequest> ag_(MedicationRequest NoBMIFollowUp)
        {
            IEnumerable<Encounter> bo_ = this.Qualifying_Encounter_during_Day_of_Measurement_Period(context);
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


    [CqlExpressionDefinition("Medical Reason or Patient Reason for Not Performing BMI Exam")]
    public IEnumerable<Observation> Medical_Reason_or_Patient_Reason_for_Not_Performing_BMI_Exam(CqlContext context)
    {
        CqlCode a_ = this.Body_mass_index__BMI___Ratio_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
        IEnumerable<Observation> d_(Observation NoBMI)
        {
            IEnumerable<Encounter> h_ = this.Qualifying_Encounter_during_Day_of_Measurement_Period(context);
            bool? i_(Encounter QualifyingEncounter)
            {
                DataType m_ = NoBMI?.Effective;
                object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                CqlInterval<CqlDateTime> o_ = QICoreCommon_2_1_000.Instance.toInterval(context, n_);
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
        IEnumerable<object> a_ = this.Medical_Reason_for_Not_Documenting_a_Follow_up_Plan_for_Low_or_High_BMI(context);
        bool? b_ = context.Operators.Exists<object>(a_);
        IEnumerable<Observation> c_ = this.Medical_Reason_or_Patient_Reason_for_Not_Performing_BMI_Exam(context);
        bool? d_ = context.Operators.Exists<Observation>(c_);
        bool? e_ = context.Operators.Or(b_, d_);

        return e_;
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


    #endregion Functions and Expressions

}
