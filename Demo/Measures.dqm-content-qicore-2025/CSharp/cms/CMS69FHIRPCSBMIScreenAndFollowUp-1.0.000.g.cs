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
[CqlLibrary("CMS69FHIRPCSBMIScreenAndFollowUp", "1.0.000")]
public partial class CMS69FHIRPCSBMIScreenAndFollowUp_1_0_000 : ILibrary, ISingleton<CMS69FHIRPCSBMIScreenAndFollowUp_1_0_000>
{
    #region ValueSets (11)

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

    #region Codes (2)

    [CqlCodeDefinition("Body mass index (BMI) [Ratio]", codeId: "39156-5", codeSystem: "http://loinc.org")]
    public CqlCode Body_mass_index__BMI___Ratio_(CqlContext _) => _Body_mass_index__BMI___Ratio_;
    private static readonly CqlCode _Body_mass_index__BMI___Ratio_ = new CqlCode("39156-5", "http://loinc.org");

    [CqlCodeDefinition("virtual", codeId: "VR", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode @virtual(CqlContext _) => _virtual;
    private static readonly CqlCode _virtual = new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode");

    #endregion Codes

    #region CodeSystems (4)

    [CqlCodeSystemDefinition("ActCode", codeSystemId: "http://terminology.hl7.org/CodeSystem/v3-ActCode", codeSystemVersion: null)]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-ActCode", null, [
          _virtual]);

    [CqlCodeSystemDefinition("ICD10CM", codeSystemId: "http://hl7.org/fhir/sid/icd-10-cm", codeSystemVersion: null)]
    public CqlCodeSystem ICD10CM(CqlContext _) => _ICD10CM;
    private static readonly CqlCodeSystem _ICD10CM =
      new CqlCodeSystem("http://hl7.org/fhir/sid/icd-10-cm", null, []);

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Body_mass_index__BMI___Ratio_]);

    [CqlCodeSystemDefinition("ObservationCategoryCodes", codeSystemId: "http://terminology.hl7.org/CodeSystem/observation-category", codeSystemVersion: null)]
    public CqlCodeSystem ObservationCategoryCodes(CqlContext _) => _ObservationCategoryCodes;
    private static readonly CqlCodeSystem _ObservationCategoryCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/observation-category", null, []);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime?>? Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -8443783423410390790L;

    private CqlInterval<CqlDateTime?>? Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime? a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime? b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime?>? c_ = context.Operators.Interval(a_, b_, true, false);
        object? d_ = context.ResolveParameter("CMS69FHIRPCSBMIScreenAndFollowUp-1.0.000"!, ("Measurement Period")!, c_);
        return (CqlInterval<CqlDateTime?>?)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (24)

    [CqlExpressionDefinition("Patient")]
    public Patient? Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -7017834528525676842L;

    private Patient? Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient?>? a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient? b_ = context.Operators.SingletonFrom<Patient?>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Qualifying Encounter During Day Of Measurement Period")]
    public IEnumerable<Encounter?>? Qualifying_Encounter_During_Day_Of_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounter_During_Day_Of_Measurement_Period, Qualifying_Encounter_During_Day_Of_Measurement_Period_Compute);

    private const long _cacheIndex_Qualifying_Encounter_During_Day_Of_Measurement_Period = -2606809622907269520L;

    private IEnumerable<Encounter?>? Qualifying_Encounter_During_Day_Of_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Encounter_to_Evaluate_BMI(context);
        IEnumerable<Encounter?>? b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? c_(Encounter? BMIEncounter) {
            CqlInterval<CqlDateTime?>? e_ = this.Measurement_Period(context);
            Period? f_ = BMIEncounter?.Period;
            CqlInterval<CqlDateTime?>? g_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, f_);
            bool? h_ = context.Operators.IntervalIncludesInterval<CqlDateTime?>(e_, g_, "day");
            Coding? i_ = BMIEncounter?.Class;
            CqlCode? j_ = FHIRHelpers_4_4_000.Instance.ToCode(context, i_);
            CqlCode? k_ = this.@virtual(context);
            bool? l_ = context.Operators.Equivalent(j_, k_);
            bool? m_ = context.Operators.Not(l_);
            bool? n_ = context.Operators.And(h_, m_);
            Code<Encounter.EncounterStatus>? o_ = BMIEncounter?.StatusElement;
            Encounter.EncounterStatus? p_ = o_?.Value;
            Code<Encounter.EncounterStatus>? q_ = context.Operators.Convert<Code<Encounter.EncounterStatus>?>(p_);
            bool? r_ = context.Operators.Equal(q_, "finished");
            bool? s_ = context.Operators.And(n_, r_);
            return s_;
        }

        IEnumerable<Encounter?>? d_ = context.Operators.Where<Encounter?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -6455816025953421212L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Qualifying_Encounter_During_Day_Of_Measurement_Period(context);

        bool? b_(Encounter? QualifyingEncounter) {
            Patient? d_ = this.Patient(context);
            Date? e_ = d_?.BirthDateElement;
            string? f_ = e_?.Value;
            CqlDate? g_ = context.Operators.ConvertStringToDate(f_);
            Period? h_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime?>? i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
            CqlDateTime? j_ = context.Operators.Start(i_);
            CqlDate? k_ = context.Operators.DateFrom(j_);
            int? l_ = context.Operators.CalculateAgeAt(g_, k_, "year");
            bool? m_ = context.Operators.GreaterOrEqual(l_, 18);
            return m_;
        }

        bool? c_ = context.Operators.WhereAny<Encounter?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = -7017586087803133019L;

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Is Pregnant During Measurement Period")]
    public bool? Is_Pregnant_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Is_Pregnant_During_Measurement_Period, Is_Pregnant_During_Measurement_Period_Compute);

    private const long _cacheIndex_Is_Pregnant_During_Measurement_Period = -3728150604244617674L;

    private bool? Is_Pregnant_During_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Pregnancy_or_Other_Related_Diagnoses(context);
        IEnumerable<Condition?>? b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition?>? c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? d_ = context.Operators.Union<Condition?>(b_ as IEnumerable<Condition?>, c_ as IEnumerable<Condition?>);

        bool? e_(Condition? PregnancyDiagnosis) {
            CqlInterval<CqlDateTime?>? k_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PregnancyDiagnosis);
            CqlInterval<CqlDateTime?>? l_ = this.Measurement_Period(context);
            bool? m_ = context.Operators.Overlaps(k_!, l_!, "day");
            return m_;
        }

        bool? f_ = context.Operators.WhereAny<Condition?>(d_, e_);
        IEnumerable<Observation?>? g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-pregnancystatus"));

        bool? h_(Observation? PregnantObservation) {
            DataType? n_ = PregnantObservation?.Effective;
            CqlDateTime? o_ = context.Operators.LateBoundProperty<CqlDateTime?>(n_, "value"!);
            CqlInterval<CqlDateTime?>? p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_);
            CqlInterval<CqlDateTime?>? q_ = this.Measurement_Period(context);
            bool? r_ = context.Operators.Overlaps(p_!, q_!, "day");
            Code<ObservationStatus>? s_ = PregnantObservation?.StatusElement;
            ObservationStatus? t_ = s_?.Value;
            Code<ObservationStatus>? u_ = context.Operators.Convert<Code<ObservationStatus>?>(t_);
            string? v_ = context.Operators.Convert<string?>(u_);
            string?[]? w_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? x_ = context.Operators.In<string?>(v_, (IEnumerable<string?>?)w_);
            bool? y_ = context.Operators.And(r_, x_);
            DataType? z_ = PregnantObservation?.Value;
            CqlConcept? aa_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, z_ as CodeableConcept);
            CqlValueSet? ab_ = this.Pregnancy_or_Other_Related_Diagnoses(context);
            bool? ac_ = context.Operators.ConceptInValueSet(aa_, ab_);
            bool? ad_ = context.Operators.And(y_, ac_);
            return ad_;
        }

        bool? i_ = context.Operators.WhereAny<Observation?>(g_, h_);
        bool? j_ = context.Operators.Or(f_, i_);
        return j_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 4225706093378547189L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        bool? a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
        bool? b_ = PalliativeCare_1_18_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? c_ = context.Operators.Or(a_, b_);
        bool? d_ = this.Is_Pregnant_During_Measurement_Period(context);
        bool? e_ = context.Operators.Or(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("BMI During Measurement Period")]
    public IEnumerable<Observation?>? BMI_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_BMI_During_Measurement_Period, BMI_During_Measurement_Period_Compute);

    private const long _cacheIndex_BMI_During_Measurement_Period = 8421605896850534429L;

    private IEnumerable<Observation?>? BMI_During_Measurement_Period_Compute(CqlContext context)
    {
        IEnumerable<Observation?>? a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-bmi"));
        IEnumerable<Observation?>? b_ = Status_1_15_000.Instance.isObservationBMI(context, a_);

        bool? c_(Observation? BMI) {
            DataType? e_ = BMI?.Value;
            CqlQuantity? f_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, e_ as Quantity);
            CqlQuantity? g_ = context.Operators.Quantity(0m, "kg/m2");
            bool? h_ = context.Operators.Greater(f_, g_);
            CqlInterval<CqlDateTime?>? i_ = this.Measurement_Period(context);
            DataType? j_ = BMI?.Effective;
            object? k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
            CqlInterval<CqlDateTime?>? l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_);
            bool? m_ = context.Operators.IntervalIncludesInterval<CqlDateTime?>(i_, l_, "day");
            bool? n_ = context.Operators.And(h_, m_);
            return n_;
        }

        IEnumerable<Observation?>? d_ = context.Operators.Where<Observation?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Documented High BMI During Measurement Period")]
    public IEnumerable<Observation?>? Documented_High_BMI_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Documented_High_BMI_During_Measurement_Period, Documented_High_BMI_During_Measurement_Period_Compute);

    private const long _cacheIndex_Documented_High_BMI_During_Measurement_Period = 6429687211226404328L;

    private IEnumerable<Observation?>? Documented_High_BMI_During_Measurement_Period_Compute(CqlContext context)
    {
        IEnumerable<Observation?>? a_ = this.BMI_During_Measurement_Period(context);

        bool? b_(Observation? BMI) {
            DataType? d_ = BMI?.Value;
            CqlQuantity? e_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, d_ as Quantity);
            CqlQuantity? f_ = context.Operators.Quantity(25m, "kg/m2");
            bool? g_ = context.Operators.GreaterOrEqual(e_, f_);
            return g_;
        }

        IEnumerable<Observation?>? c_ = context.Operators.Where<Observation?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("High BMI Interventions Ordered")]
    public IEnumerable<object?>? High_BMI_Interventions_Ordered(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_High_BMI_Interventions_Ordered, High_BMI_Interventions_Ordered_Compute);

    private const long _cacheIndex_High_BMI_Interventions_Ordered = -485185337184598823L;

    private IEnumerable<object?>? High_BMI_Interventions_Ordered_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Follow_Up_for_Above_Normal_BMI(context);
        IEnumerable<ServiceRequest?>? b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        CqlValueSet? c_ = this.Referrals_Where_Weight_Assessment_May_Occur(context);
        IEnumerable<ServiceRequest?>? d_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest?>? e_ = context.Operators.Union<ServiceRequest?>(b_, d_);
        IEnumerable<MedicationRequest?>? f_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? g_(MedicationRequest? MR) {
            IEnumerable<Medication?>? o_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? p_(Medication? M) {
                object? r_ = context.Operators.LateBoundProperty<object?>(M, "id.value"!);
                object? s_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value"!);
                IEnumerable<string?>? t_ = context.Operators.Split(((string?)s_)!, "/"!);
                string? u_ = context.Operators.Last<string?>(t_!);
                bool? v_ = context.Operators.Equal(r_, u_);
                CodeableConcept? w_ = M?.Code;
                CqlConcept? x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, w_);
                CqlValueSet? y_ = this.Medications_for_Above_Normal_BMI(context);
                bool? z_ = context.Operators.ConceptInValueSet(x_, y_);
                bool? aa_ = context.Operators.And(v_, z_);
                return aa_;
            }

            bool? q_ = context.Operators.WhereAny<Medication?>(o_, p_);
            return q_;
        }

        IEnumerable<MedicationRequest?>? h_ = context.Operators.Where<MedicationRequest?>(f_, g_);
        CqlValueSet? i_ = this.Medications_for_Above_Normal_BMI(context);
        IEnumerable<MedicationRequest?>? j_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? k_ = context.Operators.Union<MedicationRequest?>(h_, j_);
        IEnumerable<object?>? l_ = context.Operators.Union<object?>(e_ as IEnumerable<object?>, k_ as IEnumerable<object?>);

        bool? m_(object? HighInterventionsOrdered) {
            object? ab_ = context.Operators.LateBoundProperty<object?>(HighInterventionsOrdered, "reasonCode"!);
            object?[]? ac_ = [
                ab_,
            ];

            CqlConcept? ad_(object? @this) {
                CqlConcept? ap_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this as CodeableConcept);
                return ap_;
            }

            IEnumerable<CqlConcept?>? ae_ = context.Operators.Select<object?, CqlConcept?>((IEnumerable<object?>?)ac_, ad_);
            CqlConcept? af_ = context.Operators.SingletonFrom<CqlConcept?>(ae_);
            CqlConcept?[]? ag_ = [
                af_,
            ];
            CqlValueSet? ah_ = this.Overweight_or_Obese(context);
            bool? ai_ = context.Operators.ConceptsInValueSet((IEnumerable<CqlConcept?>?)ag_, ah_);
            IEnumerable<Condition?>? aj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ah_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition?>? ak_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ah_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition?>? al_ = context.Operators.Union<Condition?>(aj_ as IEnumerable<Condition?>, ak_ as IEnumerable<Condition?>);

            bool? am_(Condition? OverweightObese) {
                CqlInterval<CqlDateTime?>? aq_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, OverweightObese);
                CqlDateTime? ar_ = context.Operators.Start(aq_);
                object? as_ = context.Operators.LateBoundProperty<object?>(HighInterventionsOrdered, "authoredOn"!);
                CqlDateTime? at_ = context.Operators.LateBoundProperty<CqlDateTime?>(as_, "value"!);
                bool? au_ = context.Operators.SameOrBefore(ar_, at_, "day");
                return au_;
            }

            bool? an_ = context.Operators.WhereAny<Condition?>(al_, am_);
            bool? ao_ = context.Operators.Or(ai_, an_);
            return ao_;
        }

        IEnumerable<object?>? n_ = context.Operators.Where<object?>(l_, m_);
        return n_;
    }


    [CqlExpressionDefinition("High BMI Interventions Performed")]
    public IEnumerable<Procedure?>? High_BMI_Interventions_Performed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_High_BMI_Interventions_Performed, High_BMI_Interventions_Performed_Compute);

    private const long _cacheIndex_High_BMI_Interventions_Performed = 7771502893532171407L;

    private IEnumerable<Procedure?>? High_BMI_Interventions_Performed_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Follow_Up_for_Above_Normal_BMI(context);
        IEnumerable<Procedure?>? b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? c_(Procedure? HighInterventionsPerformed) {
            List<CodeableConcept>? e_ = HighInterventionsPerformed?.ReasonCode;

            CqlConcept? f_(CodeableConcept? @this) {
                CqlConcept? n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return n_;
            }

            IEnumerable<CqlConcept?>? g_ = context.Operators.Select<CodeableConcept?, CqlConcept?>((IEnumerable<CodeableConcept?>?)e_, f_);
            CqlValueSet? h_ = this.Overweight_or_Obese(context);
            bool? i_ = context.Operators.ConceptsInValueSet(g_, h_);
            IEnumerable<Condition?>? j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? k_(Condition? OverweightObese) {
                CqlInterval<CqlDateTime?>? o_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, OverweightObese as Condition);
                CqlDateTime? p_ = context.Operators.Start(o_);
                object? q_;
                DataType? ab_ = HighInterventionsPerformed?.Performed;
                object? ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                bool ad_ = ac_ is CqlDateTime;
                if (ad_)
                {
                    DataType? ae_ = HighInterventionsPerformed?.Performed;
                    object? af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    q_ = af_ as CqlDateTime;
                }
                else
                {
                    DataType? ag_ = HighInterventionsPerformed?.Performed;
                    object? ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    bool ai_ = ah_ is CqlQuantity;
                    if (ai_)
                    {
                        DataType? aj_ = HighInterventionsPerformed?.Performed;
                        object? ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                        q_ = ak_ as CqlQuantity;
                    }
                    else
                    {
                        DataType? al_ = HighInterventionsPerformed?.Performed;
                        object? am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                        bool an_ = am_ is CqlInterval<CqlDateTime>;
                        if (an_)
                        {
                            DataType? ao_ = HighInterventionsPerformed?.Performed;
                            object? ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                            q_ = ap_ as CqlInterval<CqlDateTime?>;
                        }
                        else
                        {
                            DataType? aq_ = HighInterventionsPerformed?.Performed;
                            object? ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                            bool as_ = ar_ is CqlInterval<CqlQuantity>;
                            if (as_)
                            {
                                DataType? at_ = HighInterventionsPerformed?.Performed;
                                object? au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                                q_ = au_ as CqlInterval<CqlQuantity?>;
                            }
                            else
                            {
                                q_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
                CqlDateTime? s_ = context.Operators.Start(r_);
                bool? t_ = context.Operators.SameOrBefore(p_, s_, "day");
                CqlDateTime? u_ = context.Operators.End(o_);
                object? v_;
                DataType? av_ = HighInterventionsPerformed?.Performed;
                object? aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                bool ax_ = aw_ is CqlDateTime;
                if (ax_)
                {
                    DataType? ay_ = HighInterventionsPerformed?.Performed;
                    object? az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                    v_ = az_ as CqlDateTime;
                }
                else
                {
                    DataType? ba_ = HighInterventionsPerformed?.Performed;
                    object? bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                    bool bc_ = bb_ is CqlQuantity;
                    if (bc_)
                    {
                        DataType? bd_ = HighInterventionsPerformed?.Performed;
                        object? be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                        v_ = be_ as CqlQuantity;
                    }
                    else
                    {
                        DataType? bf_ = HighInterventionsPerformed?.Performed;
                        object? bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                        bool bh_ = bg_ is CqlInterval<CqlDateTime>;
                        if (bh_)
                        {
                            DataType? bi_ = HighInterventionsPerformed?.Performed;
                            object? bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                            v_ = bj_ as CqlInterval<CqlDateTime?>;
                        }
                        else
                        {
                            DataType? bk_ = HighInterventionsPerformed?.Performed;
                            object? bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                            bool bm_ = bl_ is CqlInterval<CqlQuantity>;
                            if (bm_)
                            {
                                DataType? bn_ = HighInterventionsPerformed?.Performed;
                                object? bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                                v_ = bo_ as CqlInterval<CqlQuantity?>;
                            }
                            else
                            {
                                v_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
                CqlDateTime? x_ = context.Operators.Start(w_);
                bool? y_ = context.Operators.Before(u_, x_, "day");
                bool? z_ = context.Operators.Not(y_);
                bool? aa_ = context.Operators.And(t_, z_);
                return aa_;
            }

            bool? l_ = context.Operators.WhereAny<Condition?>(j_, k_);
            bool? m_ = context.Operators.Or(i_, l_);
            return m_;
        }

        IEnumerable<Procedure?>? d_ = context.Operators.Where<Procedure?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("High BMI And Follow Up Provided")]
    public IEnumerable<Observation?>? High_BMI_And_Follow_Up_Provided(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_High_BMI_And_Follow_Up_Provided, High_BMI_And_Follow_Up_Provided_Compute);

    private const long _cacheIndex_High_BMI_And_Follow_Up_Provided = 3190705409215180525L;

    private IEnumerable<Observation?>? High_BMI_And_Follow_Up_Provided_Compute(CqlContext context)
    {
        IEnumerable<Observation?>? a_ = this.Documented_High_BMI_During_Measurement_Period(context);

        bool? b_(Observation? HighBMI) {
            IEnumerable<object?>? d_ = this.High_BMI_Interventions_Ordered(context);
            IEnumerable<Procedure?>? e_ = this.High_BMI_Interventions_Performed(context);
            IEnumerable<object?>? f_ = context.Operators.Union<object?>(d_ as IEnumerable<object?>, e_ as IEnumerable<object?>);

            bool? g_(object? HighBMIInterventions) {
                object? i_;
                object? q_ = context.Operators.LateBoundProperty<object?>(HighBMIInterventions, "performed"!);
                object? r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                bool s_ = r_ is CqlDateTime;
                if (s_)
                {
                    object? t_ = context.Operators.LateBoundProperty<object?>(HighBMIInterventions, "performed"!);
                    object? u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    i_ = u_ as CqlDateTime;
                }
                else
                {
                    object? v_ = context.Operators.LateBoundProperty<object?>(HighBMIInterventions, "performed"!);
                    object? w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlQuantity;
                    if (x_)
                    {
                        object? y_ = context.Operators.LateBoundProperty<object?>(HighBMIInterventions, "performed"!);
                        object? z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                        i_ = z_ as CqlQuantity;
                    }
                    else
                    {
                        object? aa_ = context.Operators.LateBoundProperty<object?>(HighBMIInterventions, "performed"!);
                        object? ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        bool ac_ = ab_ is CqlInterval<CqlDateTime>;
                        if (ac_)
                        {
                            object? ad_ = context.Operators.LateBoundProperty<object?>(HighBMIInterventions, "performed"!);
                            object? ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                            i_ = ae_ as CqlInterval<CqlDateTime?>;
                        }
                        else
                        {
                            object? af_ = context.Operators.LateBoundProperty<object?>(HighBMIInterventions, "performed"!);
                            object? ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                            bool ah_ = ag_ is CqlInterval<CqlQuantity>;
                            if (ah_)
                            {
                                object? ai_ = context.Operators.LateBoundProperty<object?>(HighBMIInterventions, "performed"!);
                                object? aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                                i_ = aj_ as CqlInterval<CqlQuantity?>;
                            }
                            else
                            {
                                i_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? j_ = QICoreCommon_4_0_000.Instance.toInterval(context, i_);
                object? k_ = context.Operators.LateBoundProperty<object?>(HighBMIInterventions, "authoredOn"!);
                CqlDateTime? l_ = context.Operators.LateBoundProperty<CqlDateTime?>(k_, "value"!);
                CqlInterval<CqlDateTime?>? m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_);
                CqlDateTime? n_ = context.Operators.Start(j_ ?? m_);
                CqlInterval<CqlDateTime?>? o_ = this.Measurement_Period(context);
                bool? p_ = context.Operators.In<CqlDateTime?>(n_, o_, "day");
                return p_;
            }

            bool? h_ = context.Operators.WhereAny<object?>(f_, g_);
            return h_;
        }

        IEnumerable<Observation?>? c_ = context.Operators.Where<Observation?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Documented Low BMI During Measurement Period")]
    public IEnumerable<Observation?>? Documented_Low_BMI_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Documented_Low_BMI_During_Measurement_Period, Documented_Low_BMI_During_Measurement_Period_Compute);

    private const long _cacheIndex_Documented_Low_BMI_During_Measurement_Period = -8900815521314324594L;

    private IEnumerable<Observation?>? Documented_Low_BMI_During_Measurement_Period_Compute(CqlContext context)
    {
        IEnumerable<Observation?>? a_ = this.BMI_During_Measurement_Period(context);

        bool? b_(Observation? BMI) {
            DataType? d_ = BMI?.Value;
            CqlQuantity? e_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, d_ as Quantity);
            CqlQuantity? f_ = context.Operators.Quantity(18.5m, "kg/m2");
            bool? g_ = context.Operators.Less(e_, f_);
            return g_;
        }

        IEnumerable<Observation?>? c_ = context.Operators.Where<Observation?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Low BMI Interventions Ordered")]
    public IEnumerable<object?>? Low_BMI_Interventions_Ordered(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Low_BMI_Interventions_Ordered, Low_BMI_Interventions_Ordered_Compute);

    private const long _cacheIndex_Low_BMI_Interventions_Ordered = -1769934396676519667L;

    private IEnumerable<object?>? Low_BMI_Interventions_Ordered_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Follow_Up_for_Below_Normal_BMI(context);
        IEnumerable<ServiceRequest?>? b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        CqlValueSet? c_ = this.Referrals_Where_Weight_Assessment_May_Occur(context);
        IEnumerable<ServiceRequest?>? d_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest?>? e_ = context.Operators.Union<ServiceRequest?>(b_, d_);
        IEnumerable<MedicationRequest?>? f_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? g_(MedicationRequest? MR) {
            IEnumerable<Medication?>? o_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? p_(Medication? M) {
                object? r_ = context.Operators.LateBoundProperty<object?>(M, "id.value"!);
                object? s_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value"!);
                IEnumerable<string?>? t_ = context.Operators.Split(((string?)s_)!, "/"!);
                string? u_ = context.Operators.Last<string?>(t_!);
                bool? v_ = context.Operators.Equal(r_, u_);
                CodeableConcept? w_ = M?.Code;
                CqlConcept? x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, w_);
                CqlValueSet? y_ = this.Medications_for_Below_Normal_BMI(context);
                bool? z_ = context.Operators.ConceptInValueSet(x_, y_);
                bool? aa_ = context.Operators.And(v_, z_);
                return aa_;
            }

            bool? q_ = context.Operators.WhereAny<Medication?>(o_, p_);
            return q_;
        }

        IEnumerable<MedicationRequest?>? h_ = context.Operators.Where<MedicationRequest?>(f_, g_);
        CqlValueSet? i_ = this.Medications_for_Below_Normal_BMI(context);
        IEnumerable<MedicationRequest?>? j_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? k_ = context.Operators.Union<MedicationRequest?>(h_, j_);
        IEnumerable<object?>? l_ = context.Operators.Union<object?>(e_ as IEnumerable<object?>, k_ as IEnumerable<object?>);

        bool? m_(object? LowInterventionsOrdered) {
            object? ab_ = context.Operators.LateBoundProperty<object?>(LowInterventionsOrdered, "reasonCode"!);
            object?[]? ac_ = [
                ab_,
            ];

            CqlConcept? ad_(object? @this) {
                CqlConcept? ap_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this as CodeableConcept);
                return ap_;
            }

            IEnumerable<CqlConcept?>? ae_ = context.Operators.Select<object?, CqlConcept?>((IEnumerable<object?>?)ac_, ad_);
            CqlConcept? af_ = context.Operators.SingletonFrom<CqlConcept?>(ae_);
            CqlConcept?[]? ag_ = [
                af_,
            ];
            CqlValueSet? ah_ = this.Underweight(context);
            bool? ai_ = context.Operators.ConceptsInValueSet((IEnumerable<CqlConcept?>?)ag_, ah_);
            IEnumerable<Condition?>? aj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ah_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition?>? ak_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ah_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition?>? al_ = context.Operators.Union<Condition?>(aj_ as IEnumerable<Condition?>, ak_ as IEnumerable<Condition?>);

            bool? am_(Condition? UnderweightDiagnosis) {
                CqlInterval<CqlDateTime?>? aq_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, UnderweightDiagnosis);
                CqlDateTime? ar_ = context.Operators.Start(aq_);
                object? as_ = context.Operators.LateBoundProperty<object?>(LowInterventionsOrdered, "authoredOn"!);
                CqlDateTime? at_ = context.Operators.LateBoundProperty<CqlDateTime?>(as_, "value"!);
                bool? au_ = context.Operators.SameOrBefore(ar_, at_, "day");
                CqlInterval<CqlDateTime?>? av_ = this.Measurement_Period(context);
                bool? aw_ = context.Operators.In<CqlDateTime?>(at_, av_, "day");
                bool? ax_ = context.Operators.And(au_, aw_);
                return ax_;
            }

            bool? an_ = context.Operators.WhereAny<Condition?>(al_, am_);
            bool? ao_ = context.Operators.Or(ai_, an_);
            return ao_;
        }

        IEnumerable<object?>? n_ = context.Operators.Where<object?>(l_, m_);
        return n_;
    }


    [CqlExpressionDefinition("Low BMI Interventions Performed")]
    public IEnumerable<Procedure?>? Low_BMI_Interventions_Performed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Low_BMI_Interventions_Performed, Low_BMI_Interventions_Performed_Compute);

    private const long _cacheIndex_Low_BMI_Interventions_Performed = -4502765490759027233L;

    private IEnumerable<Procedure?>? Low_BMI_Interventions_Performed_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Follow_Up_for_Below_Normal_BMI(context);
        IEnumerable<Procedure?>? b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? c_(Procedure? LowInterventionsPerformed) {
            List<CodeableConcept>? e_ = LowInterventionsPerformed?.ReasonCode;

            CqlConcept? f_(CodeableConcept? @this) {
                CqlConcept? s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return s_;
            }

            IEnumerable<CqlConcept?>? g_ = context.Operators.Select<CodeableConcept?, CqlConcept?>((IEnumerable<CodeableConcept?>?)e_, f_);
            CqlValueSet? h_ = this.Underweight(context);
            bool? i_ = context.Operators.ConceptsInValueSet(g_, h_);
            Code<EventStatus>? j_ = LowInterventionsPerformed?.StatusElement;
            EventStatus? k_ = j_?.Value;
            string? l_ = context.Operators.Convert<string?>(k_);
            bool? m_ = context.Operators.Equal(l_, "completed");
            bool? n_ = context.Operators.And(i_, m_);
            IEnumerable<Condition?>? o_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? p_(Condition? UnderweightDiagnosis) {
                bool? t_ = QICoreCommon_4_0_000.Instance.isHealthConcern(context, UnderweightDiagnosis as Condition);
                CqlInterval<CqlDateTime?>? u_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, UnderweightDiagnosis as Condition);
                CqlDateTime? v_ = context.Operators.Start(u_);
                object? w_;
                DataType? an_ = LowInterventionsPerformed?.Performed;
                object? ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                bool ap_ = ao_ is CqlDateTime;
                if (ap_)
                {
                    DataType? aq_ = LowInterventionsPerformed?.Performed;
                    object? ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                    w_ = ar_ as CqlDateTime;
                }
                else
                {
                    DataType? as_ = LowInterventionsPerformed?.Performed;
                    object? at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                    bool au_ = at_ is CqlQuantity;
                    if (au_)
                    {
                        DataType? av_ = LowInterventionsPerformed?.Performed;
                        object? aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        w_ = aw_ as CqlQuantity;
                    }
                    else
                    {
                        DataType? ax_ = LowInterventionsPerformed?.Performed;
                        object? ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                        bool az_ = ay_ is CqlInterval<CqlDateTime>;
                        if (az_)
                        {
                            DataType? ba_ = LowInterventionsPerformed?.Performed;
                            object? bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                            w_ = bb_ as CqlInterval<CqlDateTime?>;
                        }
                        else
                        {
                            DataType? bc_ = LowInterventionsPerformed?.Performed;
                            object? bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                            bool be_ = bd_ is CqlInterval<CqlQuantity>;
                            if (be_)
                            {
                                DataType? bf_ = LowInterventionsPerformed?.Performed;
                                object? bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                                w_ = bg_ as CqlInterval<CqlQuantity?>;
                            }
                            else
                            {
                                w_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? x_ = QICoreCommon_4_0_000.Instance.toInterval(context, w_);
                CqlDateTime? y_ = context.Operators.Start(x_);
                bool? z_ = context.Operators.SameOrBefore(v_, y_, "day");
                bool? aa_ = context.Operators.And(t_, z_);
                CqlInterval<CqlDateTime?>? ab_ = this.Measurement_Period(context);
                object? ac_;
                DataType? bh_ = LowInterventionsPerformed?.Performed;
                object? bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                bool bj_ = bi_ is CqlDateTime;
                if (bj_)
                {
                    DataType? bk_ = LowInterventionsPerformed?.Performed;
                    object? bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    ac_ = bl_ as CqlDateTime;
                }
                else
                {
                    DataType? bm_ = LowInterventionsPerformed?.Performed;
                    object? bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                    bool bo_ = bn_ is CqlQuantity;
                    if (bo_)
                    {
                        DataType? bp_ = LowInterventionsPerformed?.Performed;
                        object? bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                        ac_ = bq_ as CqlQuantity;
                    }
                    else
                    {
                        DataType? br_ = LowInterventionsPerformed?.Performed;
                        object? bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                        bool bt_ = bs_ is CqlInterval<CqlDateTime>;
                        if (bt_)
                        {
                            DataType? bu_ = LowInterventionsPerformed?.Performed;
                            object? bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                            ac_ = bv_ as CqlInterval<CqlDateTime?>;
                        }
                        else
                        {
                            DataType? bw_ = LowInterventionsPerformed?.Performed;
                            object? bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                            bool by_ = bx_ is CqlInterval<CqlQuantity>;
                            if (by_)
                            {
                                DataType? bz_ = LowInterventionsPerformed?.Performed;
                                object? ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                                ac_ = ca_ as CqlInterval<CqlQuantity?>;
                            }
                            else
                            {
                                ac_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? ad_ = QICoreCommon_4_0_000.Instance.toInterval(context, ac_);
                bool? ae_ = context.Operators.IntervalIncludesInterval<CqlDateTime?>(ab_, ad_, "day");
                bool? af_ = context.Operators.And(aa_, ae_);
                CqlDateTime? ag_ = context.Operators.End(u_);
                object? ah_;
                DataType? cb_ = LowInterventionsPerformed?.Performed;
                object? cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                bool cd_ = cc_ is CqlDateTime;
                if (cd_)
                {
                    DataType? ce_ = LowInterventionsPerformed?.Performed;
                    object? cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                    ah_ = cf_ as CqlDateTime;
                }
                else
                {
                    DataType? cg_ = LowInterventionsPerformed?.Performed;
                    object? ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                    bool ci_ = ch_ is CqlQuantity;
                    if (ci_)
                    {
                        DataType? cj_ = LowInterventionsPerformed?.Performed;
                        object? ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                        ah_ = ck_ as CqlQuantity;
                    }
                    else
                    {
                        DataType? cl_ = LowInterventionsPerformed?.Performed;
                        object? cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                        bool cn_ = cm_ is CqlInterval<CqlDateTime>;
                        if (cn_)
                        {
                            DataType? co_ = LowInterventionsPerformed?.Performed;
                            object? cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                            ah_ = cp_ as CqlInterval<CqlDateTime?>;
                        }
                        else
                        {
                            DataType? cq_ = LowInterventionsPerformed?.Performed;
                            object? cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                            bool cs_ = cr_ is CqlInterval<CqlQuantity>;
                            if (cs_)
                            {
                                DataType? ct_ = LowInterventionsPerformed?.Performed;
                                object? cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                                ah_ = cu_ as CqlInterval<CqlQuantity?>;
                            }
                            else
                            {
                                ah_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? ai_ = QICoreCommon_4_0_000.Instance.toInterval(context, ah_);
                CqlDateTime? aj_ = context.Operators.Start(ai_);
                bool? ak_ = context.Operators.Before(ag_, aj_, "day");
                bool? al_ = context.Operators.Not(ak_);
                bool? am_ = context.Operators.And(af_, al_);
                return am_;
            }

            bool? q_ = context.Operators.WhereAny<Condition?>(o_, p_);
            bool? r_ = context.Operators.Or(n_, q_);
            return r_;
        }

        IEnumerable<Procedure?>? d_ = context.Operators.Where<Procedure?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Low BMI And Follow Up Provided")]
    public IEnumerable<Observation?>? Low_BMI_And_Follow_Up_Provided(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Low_BMI_And_Follow_Up_Provided, Low_BMI_And_Follow_Up_Provided_Compute);

    private const long _cacheIndex_Low_BMI_And_Follow_Up_Provided = -7253344149275877513L;

    private IEnumerable<Observation?>? Low_BMI_And_Follow_Up_Provided_Compute(CqlContext context)
    {
        IEnumerable<Observation?>? a_ = this.Documented_Low_BMI_During_Measurement_Period(context);

        bool? b_(Observation? LowBMI) {
            IEnumerable<object?>? d_ = this.Low_BMI_Interventions_Ordered(context);
            IEnumerable<Procedure?>? e_ = this.Low_BMI_Interventions_Performed(context);
            IEnumerable<object?>? f_ = context.Operators.Union<object?>(d_ as IEnumerable<object?>, e_ as IEnumerable<object?>);

            bool? g_(object? LowBMIInterventions) {
                object? i_;
                object? q_ = context.Operators.LateBoundProperty<object?>(LowBMIInterventions, "performed"!);
                object? r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                bool s_ = r_ is CqlDateTime;
                if (s_)
                {
                    object? t_ = context.Operators.LateBoundProperty<object?>(LowBMIInterventions, "performed"!);
                    object? u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    i_ = u_ as CqlDateTime;
                }
                else
                {
                    object? v_ = context.Operators.LateBoundProperty<object?>(LowBMIInterventions, "performed"!);
                    object? w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlQuantity;
                    if (x_)
                    {
                        object? y_ = context.Operators.LateBoundProperty<object?>(LowBMIInterventions, "performed"!);
                        object? z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                        i_ = z_ as CqlQuantity;
                    }
                    else
                    {
                        object? aa_ = context.Operators.LateBoundProperty<object?>(LowBMIInterventions, "performed"!);
                        object? ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        bool ac_ = ab_ is CqlInterval<CqlDateTime>;
                        if (ac_)
                        {
                            object? ad_ = context.Operators.LateBoundProperty<object?>(LowBMIInterventions, "performed"!);
                            object? ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                            i_ = ae_ as CqlInterval<CqlDateTime?>;
                        }
                        else
                        {
                            object? af_ = context.Operators.LateBoundProperty<object?>(LowBMIInterventions, "performed"!);
                            object? ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                            bool ah_ = ag_ is CqlInterval<CqlQuantity>;
                            if (ah_)
                            {
                                object? ai_ = context.Operators.LateBoundProperty<object?>(LowBMIInterventions, "performed"!);
                                object? aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                                i_ = aj_ as CqlInterval<CqlQuantity?>;
                            }
                            else
                            {
                                i_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? j_ = QICoreCommon_4_0_000.Instance.toInterval(context, i_);
                object? k_ = context.Operators.LateBoundProperty<object?>(LowBMIInterventions, "authoredOn"!);
                CqlDateTime? l_ = context.Operators.LateBoundProperty<CqlDateTime?>(k_, "value"!);
                CqlInterval<CqlDateTime?>? m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_);
                CqlDateTime? n_ = context.Operators.Start(j_ ?? m_);
                CqlInterval<CqlDateTime?>? o_ = this.Measurement_Period(context);
                bool? p_ = context.Operators.In<CqlDateTime?>(n_, o_, "day");
                return p_;
            }

            bool? h_ = context.Operators.WhereAny<object?>(f_, g_);
            return h_;
        }

        IEnumerable<Observation?>? c_ = context.Operators.Where<Observation?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Has Normal BMI")]
    public bool? Has_Normal_BMI(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Normal_BMI, Has_Normal_BMI_Compute);

    private const long _cacheIndex_Has_Normal_BMI = -5047732812496197000L;

    private bool? Has_Normal_BMI_Compute(CqlContext context)
    {
        IEnumerable<Observation?>? a_ = this.BMI_During_Measurement_Period(context);

        bool? b_(Observation? BMI) {
            DataType? k_ = BMI?.Value;
            CqlQuantity? l_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, k_ as Quantity);
            CqlQuantity? m_ = context.Operators.Quantity(18.5m, "kg/m2");
            bool? n_ = context.Operators.GreaterOrEqual(l_, m_);
            CqlQuantity? o_ = context.Operators.Quantity(25m, "kg/m2");
            bool? p_ = context.Operators.Less(l_, o_);
            bool? q_ = context.Operators.And(n_, p_);
            return q_;
        }

        bool? c_ = context.Operators.WhereAny<Observation?>(a_, b_);
        IEnumerable<Observation?>? d_ = this.Documented_High_BMI_During_Measurement_Period(context);
        bool? e_ = context.Operators.Exists<Observation?>(d_!);
        IEnumerable<Observation?>? f_ = this.Documented_Low_BMI_During_Measurement_Period(context);
        bool? g_ = context.Operators.Exists<Observation?>(f_!);
        bool? h_ = context.Operators.Or(e_, g_);
        bool? i_ = context.Operators.Not(h_);
        bool? j_ = context.Operators.And(c_, i_);
        return j_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -1047200998746777891L;

    private bool? Numerator_Compute(CqlContext context)
    {
        IEnumerable<Observation?>? a_ = this.High_BMI_And_Follow_Up_Provided(context);
        bool? b_ = context.Operators.Exists<Observation?>(a_!);
        IEnumerable<Observation?>? c_ = this.Low_BMI_And_Follow_Up_Provided(context);
        bool? d_ = context.Operators.Exists<Observation?>(c_!);
        bool? e_ = context.Operators.Or(b_, d_);
        bool? f_ = this.Has_Normal_BMI(context);
        bool? g_ = context.Operators.Or(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Medical Reason For Not Documenting A Follow Up Plan For Low Or High BMI")]
    public IEnumerable<object?>? Medical_Reason_For_Not_Documenting_A_Follow_Up_Plan_For_Low_Or_High_BMI(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Medical_Reason_For_Not_Documenting_A_Follow_Up_Plan_For_Low_Or_High_BMI, Medical_Reason_For_Not_Documenting_A_Follow_Up_Plan_For_Low_Or_High_BMI_Compute);

    private const long _cacheIndex_Medical_Reason_For_Not_Documenting_A_Follow_Up_Plan_For_Low_Or_High_BMI = -2121890904857911378L;

    private IEnumerable<object?>? Medical_Reason_For_Not_Documenting_A_Follow_Up_Plan_For_Low_Or_High_BMI_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Referrals_Where_Weight_Assessment_May_Occur(context);
        IEnumerable<ServiceRequest?>? b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest?>? c_ = context.Operators.Union<ServiceRequest?>(b_, b_);
        CqlValueSet? d_ = this.Follow_Up_for_Above_Normal_BMI(context);
        IEnumerable<ServiceRequest?>? e_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest?>? f_ = context.Operators.Union<ServiceRequest?>(e_, e_);
        IEnumerable<ServiceRequest?>? g_ = context.Operators.Union<ServiceRequest?>(c_, f_);
        CqlValueSet? h_ = this.Follow_Up_for_Below_Normal_BMI(context);
        IEnumerable<ServiceRequest?>? i_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest?>? j_ = context.Operators.Union<ServiceRequest?>(i_, i_);
        IEnumerable<ServiceRequest?>? k_ = context.Operators.Union<ServiceRequest?>(g_, j_);

        bool? l_(ServiceRequest? NoBMIFollowUp) {
            IEnumerable<Encounter?>? ab_ = this.Qualifying_Encounter_During_Day_Of_Measurement_Period(context);

            bool? ac_(Encounter? QualifyingEncounter) {
                FhirDateTime? ae_ = NoBMIFollowUp?.AuthoredOnElement;
                CqlDateTime? af_ = context.Operators.Convert<CqlDateTime?>(ae_);
                Period? ag_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime?>? ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
                CqlDateTime? ai_ = context.Operators.Start(ah_);
                bool? aj_ = context.Operators.SameAs(af_, ai_, "day");
                return aj_;
            }

            bool? ad_ = context.Operators.WhereAny<Encounter?>(ab_, ac_);
            return ad_;
        }

        IEnumerable<ServiceRequest?>? m_ = context.Operators.Where<ServiceRequest?>(k_, l_);

        bool? n_(ServiceRequest? NoBMIFollowUp) {
            Code<RequestStatus>? ak_ = NoBMIFollowUp?.StatusElement;
            RequestStatus? al_ = ak_?.Value;
            Code<RequestStatus>? am_ = context.Operators.Convert<Code<RequestStatus>?>(al_);
            bool? an_ = context.Operators.Equivalent(am_, "completed");

            bool? ao_(Extension? @this) {
                FhirUri? aw_ = @this?.UrlElement;
                string? ax_ = FHIRHelpers_4_4_000.Instance.ToString(context, aw_);
                bool? ay_ = context.Operators.Equal(ax_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                return ay_;
            }


            object ap_(Extension? @this) {
                DataType? az_ = @this?.Value;
                return az_!;
            }

            IEnumerable<object?>? aq_ = context.Operators.WhereSelect<Extension?, object?>((IEnumerable<Extension?>?)(NoBMIFollowUp is DomainResource
                ? (NoBMIFollowUp as DomainResource)!.Extension
                : default), ao_, ap_);
            object? ar_ = context.Operators.SingletonFrom<object?>(aq_);
            CqlConcept? as_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ar_ as CodeableConcept);
            CqlValueSet? at_ = this.Medical_Reason(context);
            bool? au_ = context.Operators.ConceptInValueSet(as_, at_);
            bool? av_ = context.Operators.And(an_, au_);
            return av_;
        }

        IEnumerable<ServiceRequest?>? o_ = context.Operators.Where<ServiceRequest?>(m_, n_);
        CqlValueSet? p_ = this.Medications_for_Above_Normal_BMI(context);
        IEnumerable<MedicationRequest?>? q_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest?>? r_ = context.Operators.Union<MedicationRequest?>(q_, q_);
        CqlValueSet? s_ = this.Medications_for_Below_Normal_BMI(context);
        IEnumerable<MedicationRequest?>? t_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest?>? u_ = context.Operators.Union<MedicationRequest?>(t_, t_);
        IEnumerable<MedicationRequest?>? v_ = context.Operators.Union<MedicationRequest?>(r_, u_);

        bool? w_(MedicationRequest? NoBMIFollowUp) {
            IEnumerable<Encounter?>? ba_ = this.Qualifying_Encounter_During_Day_Of_Measurement_Period(context);

            bool? bb_(Encounter? QualifyingEncounter) {
                FhirDateTime? bd_ = NoBMIFollowUp?.AuthoredOnElement;
                CqlDateTime? be_ = context.Operators.Convert<CqlDateTime?>(bd_);
                Period? bf_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime?>? bg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bf_);
                CqlDateTime? bh_ = context.Operators.Start(bg_);
                bool? bi_ = context.Operators.SameAs(be_, bh_, "day");
                return bi_;
            }

            bool? bc_ = context.Operators.WhereAny<Encounter?>(ba_, bb_);
            return bc_;
        }

        IEnumerable<MedicationRequest?>? x_ = context.Operators.Where<MedicationRequest?>(v_, w_);

        bool? y_(MedicationRequest? NoBMIFollowUp) {
            Code<MedicationRequest.MedicationrequestStatus>? bj_ = NoBMIFollowUp?.StatusElement;
            MedicationRequest.MedicationrequestStatus? bk_ = bj_?.Value;
            string? bl_ = context.Operators.Convert<string?>(bk_);
            bool? bm_ = context.Operators.Equivalent(bl_, "completed");
            List<CodeableConcept>? bn_ = NoBMIFollowUp?.ReasonCode;

            CqlConcept? bo_(CodeableConcept? @this) {
                CqlConcept? bt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return bt_;
            }

            IEnumerable<CqlConcept?>? bp_ = context.Operators.Select<CodeableConcept?, CqlConcept?>((IEnumerable<CodeableConcept?>?)bn_, bo_);
            CqlValueSet? bq_ = this.Medical_Reason(context);
            bool? br_ = context.Operators.ConceptsInValueSet(bp_, bq_);
            bool? bs_ = context.Operators.And(bm_, br_);
            return bs_;
        }

        IEnumerable<MedicationRequest?>? z_ = context.Operators.Where<MedicationRequest?>(x_, y_);
        IEnumerable<object?>? aa_ = context.Operators.Union<object?>(o_ as IEnumerable<object?>, z_ as IEnumerable<object?>);
        return aa_;
    }


    [CqlExpressionDefinition("Medical Reason Or Patient Reason For Not Performing BMI Exam")]
    public IEnumerable<Observation?>? Medical_Reason_Or_Patient_Reason_For_Not_Performing_BMI_Exam(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Medical_Reason_Or_Patient_Reason_For_Not_Performing_BMI_Exam, Medical_Reason_Or_Patient_Reason_For_Not_Performing_BMI_Exam_Compute);

    private const long _cacheIndex_Medical_Reason_Or_Patient_Reason_For_Not_Performing_BMI_Exam = 2600735192836884261L;

    private IEnumerable<Observation?>? Medical_Reason_Or_Patient_Reason_For_Not_Performing_BMI_Exam_Compute(CqlContext context)
    {
        CqlCode? a_ = this.Body_mass_index__BMI___Ratio_(context);
        IEnumerable<CqlCode?>? b_ = context.Operators.ToList<CqlCode?>(a_);
        IEnumerable<Observation?>? c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationcancelled"));

        bool? d_(Observation? NoBMI) {
            IEnumerable<Encounter?>? h_ = this.Qualifying_Encounter_During_Day_Of_Measurement_Period(context);

            bool? i_(Encounter? QualifyingEncounter) {
                DataType? k_ = NoBMI?.Effective;
                object? l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
                CqlInterval<CqlDateTime?>? m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_);
                CqlDateTime? n_ = context.Operators.End(m_);
                Period? o_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime?>? p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                CqlDateTime? q_ = context.Operators.Start(p_);
                bool? r_ = context.Operators.SameAs(n_, q_, "day");
                return r_;
            }

            bool? j_ = context.Operators.WhereAny<Encounter?>(h_, i_);
            return j_;
        }

        IEnumerable<Observation?>? e_ = context.Operators.Where<Observation?>(c_, d_);

        bool? f_(Observation? NoBMI) {

            bool? s_(Extension? @this) {
                FhirUri? ah_ = @this?.UrlElement;
                string? ai_ = FHIRHelpers_4_4_000.Instance.ToString(context, ah_);
                bool? aj_ = context.Operators.Equal(ai_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                return aj_;
            }


            object t_(Extension? @this) {
                DataType? ak_ = @this?.Value;
                return ak_!;
            }

            IEnumerable<object?>? u_ = context.Operators.WhereSelect<Extension?, object?>((IEnumerable<Extension?>?)(NoBMI is DomainResource
                ? (NoBMI as DomainResource)!.Extension
                : default), s_, t_);
            object? v_ = context.Operators.SingletonFrom<object?>(u_);
            CqlConcept? w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_ as CodeableConcept);
            CqlValueSet? x_ = this.Patient_Declined(context);
            bool? y_ = context.Operators.ConceptInValueSet(w_, x_);

            bool? z_(Extension? @this) {
                FhirUri? al_ = @this?.UrlElement;
                string? am_ = FHIRHelpers_4_4_000.Instance.ToString(context, al_);
                bool? an_ = context.Operators.Equal(am_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                return an_;
            }


            object aa_(Extension? @this) {
                DataType? ao_ = @this?.Value;
                return ao_!;
            }

            IEnumerable<object?>? ab_ = context.Operators.WhereSelect<Extension?, object?>((IEnumerable<Extension?>?)(NoBMI is DomainResource
                ? (NoBMI as DomainResource)!.Extension
                : default), z_, aa_);
            object? ac_ = context.Operators.SingletonFrom<object?>(ab_);
            CqlConcept? ad_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ac_ as CodeableConcept);
            CqlValueSet? ae_ = this.Medical_Reason(context);
            bool? af_ = context.Operators.ConceptInValueSet(ad_, ae_);
            bool? ag_ = context.Operators.Or(y_, af_);
            return ag_;
        }

        IEnumerable<Observation?>? g_ = context.Operators.Where<Observation?>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exceptions, Denominator_Exceptions_Compute);

    private const long _cacheIndex_Denominator_Exceptions = 8738725800645268169L;

    private bool? Denominator_Exceptions_Compute(CqlContext context)
    {
        IEnumerable<object?>? a_ = this.Medical_Reason_For_Not_Documenting_A_Follow_Up_Plan_For_Low_Or_High_BMI(context);
        bool? b_ = context.Operators.Exists<object?>(a_!);
        IEnumerable<Observation?>? c_ = this.Medical_Reason_Or_Patient_Reason_For_Not_Performing_BMI_Exam(context);
        bool? d_ = context.Operators.Exists<Observation?>(c_!);
        bool? e_ = context.Operators.Or(b_, d_);
        return e_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 3500699169556971302L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -3750332539194761427L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 6715964416781495466L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode? SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -4885014868042591606L;

    private CqlCode? SDE_Sex_Compute(CqlContext context)
    {
        CqlCode? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS69FHIRPCSBMIScreenAndFollowUp_1_0_000() {}

    public static CMS69FHIRPCSBMIScreenAndFollowUp_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS69FHIRPCSBMIScreenAndFollowUp";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, Status_1_15_000.Instance, Hospice_6_18_000.Instance, PalliativeCare_1_18_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance];

    #endregion ILibrary Implementation

}
