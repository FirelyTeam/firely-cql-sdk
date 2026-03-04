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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.0.0")]
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
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -8443783423410390790L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS69FHIRPCSBMIScreenAndFollowUp-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (24)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -7017834528525676842L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Qualifying Encounter During Day Of Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_During_Day_Of_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounter_During_Day_Of_Measurement_Period, Qualifying_Encounter_During_Day_Of_Measurement_Period_Compute);

    private const long _cacheIndex_Qualifying_Encounter_During_Day_Of_Measurement_Period = -2606809622907269520L;

    private IEnumerable<Encounter> Qualifying_Encounter_During_Day_Of_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_to_Evaluate_BMI(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? c_(Encounter BMIEncounter) {
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
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -6455816025953421212L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_During_Day_Of_Measurement_Period(context);

        bool? b_(Encounter QualifyingEncounter) {
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
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        bool? d_ = context.Operators.Exists<Encounter>(c_);
        return d_;
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
        CqlValueSet a_ = this.Pregnancy_or_Other_Related_Diagnoses(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);

        bool? f_(object PregnancyDiagnosis) {
            CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PregnancyDiagnosis);
            CqlInterval<CqlDateTime> o_ = this.Measurement_Period(context);
            bool? p_ = context.Operators.Overlaps(n_, o_, "day");
            return p_;
        }

        IEnumerable<object> g_ = context.Operators.Where<object>(e_, f_);
        bool? h_ = context.Operators.Exists<object>(g_);
        IEnumerable<Observation> i_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-pregnancystatus"));

        bool? j_(Observation PregnantObservation) {
            DataType q_ = PregnantObservation?.Effective;
            CqlDateTime r_ = context.Operators.LateBoundProperty<CqlDateTime>(q_, "value");
            CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_ as object);
            CqlInterval<CqlDateTime> t_ = this.Measurement_Period(context);
            bool? u_ = context.Operators.Overlaps(s_, t_, "day");
            Code<ObservationStatus> v_ = PregnantObservation?.StatusElement;
            ObservationStatus? w_ = v_?.Value;
            Code<ObservationStatus> x_ = context.Operators.Convert<Code<ObservationStatus>>(w_);
            string y_ = context.Operators.Convert<string>(x_);
            string[] z_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? aa_ = context.Operators.In<string>(y_, (IEnumerable<string>)z_);
            bool? ab_ = context.Operators.And(u_, aa_);
            DataType ac_ = PregnantObservation?.Value;
            CqlConcept ad_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ac_ as CodeableConcept);
            CqlValueSet ae_ = this.Pregnancy_or_Other_Related_Diagnoses(context);
            bool? af_ = context.Operators.ConceptInValueSet(ad_, ae_);
            bool? ag_ = context.Operators.And(ab_, af_);
            return ag_;
        }

        IEnumerable<Observation> k_ = context.Operators.Where<Observation>(i_, j_);
        bool? l_ = context.Operators.Exists<Observation>(k_);
        bool? m_ = context.Operators.Or(h_, l_);
        return m_;
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
    public IEnumerable<Observation> BMI_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_BMI_During_Measurement_Period, BMI_During_Measurement_Period_Compute);

    private const long _cacheIndex_BMI_During_Measurement_Period = 8421605896850534429L;

    private IEnumerable<Observation> BMI_During_Measurement_Period_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-bmi"));
        IEnumerable<Observation> b_ = Status_1_15_000.Instance.isObservationBMI(context, a_);

        bool? c_(Observation BMI) {
            DataType e_ = BMI?.Value;
            CqlQuantity f_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, e_ as Quantity);
            CqlQuantity g_ = context.Operators.Quantity(0m, "kg/m2");
            bool? h_ = context.Operators.Greater(f_, g_);
            CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
            DataType j_ = BMI?.Effective;
            object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
            CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_);
            bool? m_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(i_, l_, "day");
            bool? n_ = context.Operators.And(h_, m_);
            return n_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Documented High BMI During Measurement Period")]
    public IEnumerable<Observation> Documented_High_BMI_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Documented_High_BMI_During_Measurement_Period, Documented_High_BMI_During_Measurement_Period_Compute);

    private const long _cacheIndex_Documented_High_BMI_During_Measurement_Period = 6429687211226404328L;

    private IEnumerable<Observation> Documented_High_BMI_During_Measurement_Period_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.BMI_During_Measurement_Period(context);

        bool? b_(Observation BMI) {
            DataType d_ = BMI?.Value;
            CqlQuantity e_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, d_ as Quantity);
            CqlQuantity f_ = context.Operators.Quantity(25m, "kg/m2");
            bool? g_ = context.Operators.GreaterOrEqual(e_, f_);
            return g_;
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("High BMI Interventions Ordered")]
    public IEnumerable<object> High_BMI_Interventions_Ordered(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_High_BMI_Interventions_Ordered, High_BMI_Interventions_Ordered_Compute);

    private const long _cacheIndex_High_BMI_Interventions_Ordered = -485185337184598823L;

    private IEnumerable<object> High_BMI_Interventions_Ordered_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Follow_Up_for_Above_Normal_BMI(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        CqlValueSet c_ = this.Referrals_Where_Weight_Assessment_May_Occur(context);
        IEnumerable<ServiceRequest> d_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> e_ = context.Operators.Union<ServiceRequest>(b_, d_);
        CqlValueSet f_ = this.Medications_for_Above_Normal_BMI(context);
        IEnumerable<MedicationRequest> g_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        IEnumerable<MedicationRequest> i_(MedicationRequest MR) {
            IEnumerable<Medication> o_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? p_(Medication M) {
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
            }

            IEnumerable<Medication> q_ = context.Operators.Where<Medication>(o_, p_);
            MedicationRequest r_(Medication M) => MR;
            IEnumerable<MedicationRequest> s_ = context.Operators.Select<Medication, MedicationRequest>(q_, r_);
            return s_;
        }

        IEnumerable<MedicationRequest> j_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(h_, i_);
        IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(g_, j_);
        IEnumerable<object> l_ = context.Operators.Union<object>(e_ as IEnumerable<object>, k_ as IEnumerable<object>);

        bool? m_(object HighInterventionsOrdered) {
            object ad_ = context.Operators.LateBoundProperty<object>(HighInterventionsOrdered, "reasonCode");
            object[] ae_ = [
                ad_,
            ];

            CqlConcept af_(object @this) {
                CqlConcept au_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this as CodeableConcept);
                return au_;
            }

            IEnumerable<CqlConcept> ag_ = context.Operators.Select<object, CqlConcept>((IEnumerable<object>)ae_, af_);
            CqlConcept ah_ = context.Operators.SingletonFrom<CqlConcept>(ag_);
            CqlConcept[] ai_ = [
                ah_,
            ];
            CqlValueSet aj_ = this.Overweight_or_Obese(context);
            bool? ak_ = context.Operators.ConceptsInValueSet((IEnumerable<CqlConcept>)ai_, aj_);
            IEnumerable<Condition> am_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, aj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> ao_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, aj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<object> ap_ = context.Operators.Union<object>(am_ as IEnumerable<object>, ao_ as IEnumerable<object>);

            bool? aq_(object OverweightObese) {
                CqlInterval<CqlDateTime> av_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, OverweightObese);
                CqlDateTime aw_ = context.Operators.Start(av_);
                object ax_ = context.Operators.LateBoundProperty<object>(HighInterventionsOrdered, "authoredOn");
                CqlDateTime ay_ = context.Operators.LateBoundProperty<CqlDateTime>(ax_, "value");
                bool? az_ = context.Operators.SameOrBefore(aw_, ay_, "day");
                return az_;
            }

            IEnumerable<object> ar_ = context.Operators.Where<object>(ap_, aq_);
            bool? as_ = context.Operators.Exists<object>(ar_);
            bool? at_ = context.Operators.Or(ak_, as_);
            return at_;
        }

        IEnumerable<object> n_ = context.Operators.Where<object>(l_, m_);
        return n_;
    }


    [CqlExpressionDefinition("High BMI Interventions Performed")]
    public IEnumerable<Procedure> High_BMI_Interventions_Performed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_High_BMI_Interventions_Performed, High_BMI_Interventions_Performed_Compute);

    private const long _cacheIndex_High_BMI_Interventions_Performed = 7771502893532171407L;

    private IEnumerable<Procedure> High_BMI_Interventions_Performed_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Follow_Up_for_Above_Normal_BMI(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? c_(Procedure HighInterventionsPerformed) {
            List<CodeableConcept> e_ = HighInterventionsPerformed?.ReasonCode;

            CqlConcept f_(CodeableConcept @this) {
                CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return p_;
            }

            IEnumerable<CqlConcept> g_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)e_, f_);
            CqlValueSet h_ = this.Overweight_or_Obese(context);
            bool? i_ = context.Operators.ConceptsInValueSet(g_, h_);
            IEnumerable<Condition> k_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? l_(Condition OverweightObese) {
                CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, OverweightObese as object);
                CqlDateTime r_ = context.Operators.Start(q_);

                object s_() {

                    bool ae_() {
                        DataType ai_ = HighInterventionsPerformed?.Performed;
                        object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                        bool ak_ = aj_ is CqlDateTime;
                        return ak_;
                    }


                    bool af_() {
                        DataType al_ = HighInterventionsPerformed?.Performed;
                        object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                        bool an_ = am_ is CqlInterval<CqlDateTime>;
                        return an_;
                    }


                    bool ag_() {
                        DataType ao_ = HighInterventionsPerformed?.Performed;
                        object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                        bool aq_ = ap_ is CqlQuantity;
                        return aq_;
                    }


                    bool ah_() {
                        DataType ar_ = HighInterventionsPerformed?.Performed;
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        bool at_ = as_ is CqlInterval<CqlQuantity>;
                        return at_;
                    }

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
                    };
                }

                CqlInterval<CqlDateTime> t_ = QICoreCommon_4_0_000.Instance.toInterval(context, s_());
                CqlDateTime u_ = context.Operators.Start(t_);
                bool? v_ = context.Operators.SameOrBefore(r_, u_, "day");
                CqlDateTime x_ = context.Operators.End(q_);

                object y_() {

                    bool bc_() {
                        DataType bg_ = HighInterventionsPerformed?.Performed;
                        object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                        bool bi_ = bh_ is CqlDateTime;
                        return bi_;
                    }


                    bool bd_() {
                        DataType bj_ = HighInterventionsPerformed?.Performed;
                        object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                        bool bl_ = bk_ is CqlInterval<CqlDateTime>;
                        return bl_;
                    }


                    bool be_() {
                        DataType bm_ = HighInterventionsPerformed?.Performed;
                        object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                        bool bo_ = bn_ is CqlQuantity;
                        return bo_;
                    }


                    bool bf_() {
                        DataType bp_ = HighInterventionsPerformed?.Performed;
                        object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                        bool br_ = bq_ is CqlInterval<CqlQuantity>;
                        return br_;
                    }

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
                    };
                }

                CqlInterval<CqlDateTime> z_ = QICoreCommon_4_0_000.Instance.toInterval(context, y_());
                CqlDateTime aa_ = context.Operators.Start(z_);
                bool? ab_ = context.Operators.Before(x_, aa_, "day");
                bool? ac_ = context.Operators.Not(ab_);
                bool? ad_ = context.Operators.And(v_, ac_);
                return ad_;
            }

            IEnumerable<Condition> m_ = context.Operators.Where<Condition>(k_, l_);
            bool? n_ = context.Operators.Exists<Condition>(m_);
            bool? o_ = context.Operators.Or(i_, n_);
            return o_;
        }

        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("High BMI And Follow Up Provided")]
    public IEnumerable<Observation> High_BMI_And_Follow_Up_Provided(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_High_BMI_And_Follow_Up_Provided, High_BMI_And_Follow_Up_Provided_Compute);

    private const long _cacheIndex_High_BMI_And_Follow_Up_Provided = 3190705409215180525L;

    private IEnumerable<Observation> High_BMI_And_Follow_Up_Provided_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Documented_High_BMI_During_Measurement_Period(context);

        IEnumerable<Observation> b_(Observation HighBMI) {
            IEnumerable<object> d_ = this.High_BMI_Interventions_Ordered(context);
            IEnumerable<Procedure> e_ = this.High_BMI_Interventions_Performed(context);
            IEnumerable<object> f_ = context.Operators.Union<object>(d_ as IEnumerable<object>, e_ as IEnumerable<object>);

            bool? g_(object HighBMIInterventions) {

                object k_() {

                    bool s_() {
                        object w_ = context.Operators.LateBoundProperty<object>(HighBMIInterventions, "performed");
                        object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                        bool y_ = x_ is CqlDateTime;
                        return y_;
                    }


                    bool t_() {
                        object z_ = context.Operators.LateBoundProperty<object>(HighBMIInterventions, "performed");
                        object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                        bool ab_ = aa_ is CqlInterval<CqlDateTime>;
                        return ab_;
                    }


                    bool u_() {
                        object ac_ = context.Operators.LateBoundProperty<object>(HighBMIInterventions, "performed");
                        object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                        bool ae_ = ad_ is CqlQuantity;
                        return ae_;
                    }


                    bool v_() {
                        object af_ = context.Operators.LateBoundProperty<object>(HighBMIInterventions, "performed");
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        bool ah_ = ag_ is CqlInterval<CqlQuantity>;
                        return ah_;
                    }

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
                    };
                }

                CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_());
                object m_ = context.Operators.LateBoundProperty<object>(HighBMIInterventions, "authoredOn");
                CqlDateTime n_ = context.Operators.LateBoundProperty<CqlDateTime>(m_, "value");
                CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_ as object);
                CqlDateTime p_ = context.Operators.Start(l_ ?? o_);
                CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
                bool? r_ = context.Operators.In<CqlDateTime>(p_, q_, "day");
                return r_;
            }

            IEnumerable<object> h_ = context.Operators.Where<object>(f_, g_);
            Observation i_(object HighBMIInterventions) => HighBMI;
            IEnumerable<Observation> j_ = context.Operators.Select<object, Observation>(h_, i_);
            return j_;
        }

        IEnumerable<Observation> c_ = context.Operators.SelectMany<Observation, Observation>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Documented Low BMI During Measurement Period")]
    public IEnumerable<Observation> Documented_Low_BMI_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Documented_Low_BMI_During_Measurement_Period, Documented_Low_BMI_During_Measurement_Period_Compute);

    private const long _cacheIndex_Documented_Low_BMI_During_Measurement_Period = -8900815521314324594L;

    private IEnumerable<Observation> Documented_Low_BMI_During_Measurement_Period_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.BMI_During_Measurement_Period(context);

        bool? b_(Observation BMI) {
            DataType d_ = BMI?.Value;
            CqlQuantity e_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, d_ as Quantity);
            CqlQuantity f_ = context.Operators.Quantity(18.5m, "kg/m2");
            bool? g_ = context.Operators.Less(e_, f_);
            return g_;
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Low BMI Interventions Ordered")]
    public IEnumerable<object> Low_BMI_Interventions_Ordered(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Low_BMI_Interventions_Ordered, Low_BMI_Interventions_Ordered_Compute);

    private const long _cacheIndex_Low_BMI_Interventions_Ordered = -1769934396676519667L;

    private IEnumerable<object> Low_BMI_Interventions_Ordered_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Follow_Up_for_Below_Normal_BMI(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        CqlValueSet c_ = this.Referrals_Where_Weight_Assessment_May_Occur(context);
        IEnumerable<ServiceRequest> d_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> e_ = context.Operators.Union<ServiceRequest>(b_, d_);
        CqlValueSet f_ = this.Medications_for_Below_Normal_BMI(context);
        IEnumerable<MedicationRequest> g_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        IEnumerable<MedicationRequest> i_(MedicationRequest MR) {
            IEnumerable<Medication> o_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? p_(Medication M) {
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
            }

            IEnumerable<Medication> q_ = context.Operators.Where<Medication>(o_, p_);
            MedicationRequest r_(Medication M) => MR;
            IEnumerable<MedicationRequest> s_ = context.Operators.Select<Medication, MedicationRequest>(q_, r_);
            return s_;
        }

        IEnumerable<MedicationRequest> j_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(h_, i_);
        IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(g_, j_);
        IEnumerable<object> l_ = context.Operators.Union<object>(e_ as IEnumerable<object>, k_ as IEnumerable<object>);

        bool? m_(object LowInterventionsOrdered) {
            object ad_ = context.Operators.LateBoundProperty<object>(LowInterventionsOrdered, "reasonCode");
            object[] ae_ = [
                ad_,
            ];

            CqlConcept af_(object @this) {
                CqlConcept au_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this as CodeableConcept);
                return au_;
            }

            IEnumerable<CqlConcept> ag_ = context.Operators.Select<object, CqlConcept>((IEnumerable<object>)ae_, af_);
            CqlConcept ah_ = context.Operators.SingletonFrom<CqlConcept>(ag_);
            CqlConcept[] ai_ = [
                ah_,
            ];
            CqlValueSet aj_ = this.Underweight(context);
            bool? ak_ = context.Operators.ConceptsInValueSet((IEnumerable<CqlConcept>)ai_, aj_);
            IEnumerable<Condition> am_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, aj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> ao_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, aj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<object> ap_ = context.Operators.Union<object>(am_ as IEnumerable<object>, ao_ as IEnumerable<object>);

            bool? aq_(object UnderweightDiagnosis) {
                CqlInterval<CqlDateTime> av_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, UnderweightDiagnosis);
                CqlDateTime aw_ = context.Operators.Start(av_);
                object ax_ = context.Operators.LateBoundProperty<object>(LowInterventionsOrdered, "authoredOn");
                CqlDateTime ay_ = context.Operators.LateBoundProperty<CqlDateTime>(ax_, "value");
                bool? az_ = context.Operators.SameOrBefore(aw_, ay_, "day");
                CqlDateTime bb_ = context.Operators.LateBoundProperty<CqlDateTime>(ax_, "value");
                CqlInterval<CqlDateTime> bc_ = this.Measurement_Period(context);
                bool? bd_ = context.Operators.In<CqlDateTime>(bb_, bc_, "day");
                bool? be_ = context.Operators.And(az_, bd_);
                return be_;
            }

            IEnumerable<object> ar_ = context.Operators.Where<object>(ap_, aq_);
            bool? as_ = context.Operators.Exists<object>(ar_);
            bool? at_ = context.Operators.Or(ak_, as_);
            return at_;
        }

        IEnumerable<object> n_ = context.Operators.Where<object>(l_, m_);
        return n_;
    }


    [CqlExpressionDefinition("Low BMI Interventions Performed")]
    public IEnumerable<Procedure> Low_BMI_Interventions_Performed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Low_BMI_Interventions_Performed, Low_BMI_Interventions_Performed_Compute);

    private const long _cacheIndex_Low_BMI_Interventions_Performed = -4502765490759027233L;

    private IEnumerable<Procedure> Low_BMI_Interventions_Performed_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Follow_Up_for_Below_Normal_BMI(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? c_(Procedure LowInterventionsPerformed) {
            List<CodeableConcept> e_ = LowInterventionsPerformed?.ReasonCode;

            CqlConcept f_(CodeableConcept @this) {
                CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return u_;
            }

            IEnumerable<CqlConcept> g_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)e_, f_);
            CqlValueSet h_ = this.Underweight(context);
            bool? i_ = context.Operators.ConceptsInValueSet(g_, h_);
            Code<EventStatus> j_ = LowInterventionsPerformed?.StatusElement;
            EventStatus? k_ = j_?.Value;
            string l_ = context.Operators.Convert<string>(k_);
            bool? m_ = context.Operators.Equal(l_, "completed");
            bool? n_ = context.Operators.And(i_, m_);
            IEnumerable<Condition> p_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? q_(Condition UnderweightDiagnosis) {
                bool? v_ = QICoreCommon_4_0_000.Instance.isHealthConcern(context, UnderweightDiagnosis as object);
                CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, UnderweightDiagnosis as object);
                CqlDateTime x_ = context.Operators.Start(w_);

                object y_() {

                    bool aq_() {
                        DataType au_ = LowInterventionsPerformed?.Performed;
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                        bool aw_ = av_ is CqlDateTime;
                        return aw_;
                    }


                    bool ar_() {
                        DataType ax_ = LowInterventionsPerformed?.Performed;
                        object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                        bool az_ = ay_ is CqlInterval<CqlDateTime>;
                        return az_;
                    }


                    bool as_() {
                        DataType ba_ = LowInterventionsPerformed?.Performed;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        bool bc_ = bb_ is CqlQuantity;
                        return bc_;
                    }


                    bool at_() {
                        DataType bd_ = LowInterventionsPerformed?.Performed;
                        object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                        bool bf_ = be_ is CqlInterval<CqlQuantity>;
                        return bf_;
                    }

                    if (aq_())
                    {
                        DataType bg_ = LowInterventionsPerformed?.Performed;
                        object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                        return (bh_ as CqlDateTime) as object;
                    }
                    else if (ar_())
                    {
                        DataType bi_ = LowInterventionsPerformed?.Performed;
                        object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                        return (bj_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (as_())
                    {
                        DataType bk_ = LowInterventionsPerformed?.Performed;
                        object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                        return (bl_ as CqlQuantity) as object;
                    }
                    else if (at_())
                    {
                        DataType bm_ = LowInterventionsPerformed?.Performed;
                        object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                        return (bn_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> z_ = QICoreCommon_4_0_000.Instance.toInterval(context, y_());
                CqlDateTime aa_ = context.Operators.Start(z_);
                bool? ab_ = context.Operators.SameOrBefore(x_, aa_, "day");
                bool? ac_ = context.Operators.And(v_, ab_);
                CqlInterval<CqlDateTime> ad_ = this.Measurement_Period(context);

                object ae_() {

                    bool bo_() {
                        DataType bs_ = LowInterventionsPerformed?.Performed;
                        object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                        bool bu_ = bt_ is CqlDateTime;
                        return bu_;
                    }


                    bool bp_() {
                        DataType bv_ = LowInterventionsPerformed?.Performed;
                        object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                        bool bx_ = bw_ is CqlInterval<CqlDateTime>;
                        return bx_;
                    }


                    bool bq_() {
                        DataType by_ = LowInterventionsPerformed?.Performed;
                        object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                        bool ca_ = bz_ is CqlQuantity;
                        return ca_;
                    }


                    bool br_() {
                        DataType cb_ = LowInterventionsPerformed?.Performed;
                        object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                        bool cd_ = cc_ is CqlInterval<CqlQuantity>;
                        return cd_;
                    }

                    if (bo_())
                    {
                        DataType ce_ = LowInterventionsPerformed?.Performed;
                        object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                        return (cf_ as CqlDateTime) as object;
                    }
                    else if (bp_())
                    {
                        DataType cg_ = LowInterventionsPerformed?.Performed;
                        object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                        return (ch_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (bq_())
                    {
                        DataType ci_ = LowInterventionsPerformed?.Performed;
                        object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                        return (cj_ as CqlQuantity) as object;
                    }
                    else if (br_())
                    {
                        DataType ck_ = LowInterventionsPerformed?.Performed;
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                        return (cl_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> af_ = QICoreCommon_4_0_000.Instance.toInterval(context, ae_());
                bool? ag_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ad_, af_, "day");
                bool? ah_ = context.Operators.And(ac_, ag_);
                CqlDateTime aj_ = context.Operators.End(w_);

                object ak_() {

                    bool cm_() {
                        DataType cq_ = LowInterventionsPerformed?.Performed;
                        object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                        bool cs_ = cr_ is CqlDateTime;
                        return cs_;
                    }


                    bool cn_() {
                        DataType ct_ = LowInterventionsPerformed?.Performed;
                        object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                        bool cv_ = cu_ is CqlInterval<CqlDateTime>;
                        return cv_;
                    }


                    bool co_() {
                        DataType cw_ = LowInterventionsPerformed?.Performed;
                        object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                        bool cy_ = cx_ is CqlQuantity;
                        return cy_;
                    }


                    bool cp_() {
                        DataType cz_ = LowInterventionsPerformed?.Performed;
                        object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                        bool db_ = da_ is CqlInterval<CqlQuantity>;
                        return db_;
                    }

                    if (cm_())
                    {
                        DataType dc_ = LowInterventionsPerformed?.Performed;
                        object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                        return (dd_ as CqlDateTime) as object;
                    }
                    else if (cn_())
                    {
                        DataType de_ = LowInterventionsPerformed?.Performed;
                        object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                        return (df_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (co_())
                    {
                        DataType dg_ = LowInterventionsPerformed?.Performed;
                        object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                        return (dh_ as CqlQuantity) as object;
                    }
                    else if (cp_())
                    {
                        DataType di_ = LowInterventionsPerformed?.Performed;
                        object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                        return (dj_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> al_ = QICoreCommon_4_0_000.Instance.toInterval(context, ak_());
                CqlDateTime am_ = context.Operators.Start(al_);
                bool? an_ = context.Operators.Before(aj_, am_, "day");
                bool? ao_ = context.Operators.Not(an_);
                bool? ap_ = context.Operators.And(ah_, ao_);
                return ap_;
            }

            IEnumerable<Condition> r_ = context.Operators.Where<Condition>(p_, q_);
            bool? s_ = context.Operators.Exists<Condition>(r_);
            bool? t_ = context.Operators.Or(n_, s_);
            return t_;
        }

        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Low BMI And Follow Up Provided")]
    public IEnumerable<Observation> Low_BMI_And_Follow_Up_Provided(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Low_BMI_And_Follow_Up_Provided, Low_BMI_And_Follow_Up_Provided_Compute);

    private const long _cacheIndex_Low_BMI_And_Follow_Up_Provided = -7253344149275877513L;

    private IEnumerable<Observation> Low_BMI_And_Follow_Up_Provided_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Documented_Low_BMI_During_Measurement_Period(context);

        IEnumerable<Observation> b_(Observation LowBMI) {
            IEnumerable<object> d_ = this.Low_BMI_Interventions_Ordered(context);
            IEnumerable<Procedure> e_ = this.Low_BMI_Interventions_Performed(context);
            IEnumerable<object> f_ = context.Operators.Union<object>(d_ as IEnumerable<object>, e_ as IEnumerable<object>);

            bool? g_(object LowBMIInterventions) {

                object k_() {

                    bool s_() {
                        object w_ = context.Operators.LateBoundProperty<object>(LowBMIInterventions, "performed");
                        object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                        bool y_ = x_ is CqlDateTime;
                        return y_;
                    }


                    bool t_() {
                        object z_ = context.Operators.LateBoundProperty<object>(LowBMIInterventions, "performed");
                        object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                        bool ab_ = aa_ is CqlInterval<CqlDateTime>;
                        return ab_;
                    }


                    bool u_() {
                        object ac_ = context.Operators.LateBoundProperty<object>(LowBMIInterventions, "performed");
                        object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                        bool ae_ = ad_ is CqlQuantity;
                        return ae_;
                    }


                    bool v_() {
                        object af_ = context.Operators.LateBoundProperty<object>(LowBMIInterventions, "performed");
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        bool ah_ = ag_ is CqlInterval<CqlQuantity>;
                        return ah_;
                    }

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
                    };
                }

                CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_());
                object m_ = context.Operators.LateBoundProperty<object>(LowBMIInterventions, "authoredOn");
                CqlDateTime n_ = context.Operators.LateBoundProperty<CqlDateTime>(m_, "value");
                CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_ as object);
                CqlDateTime p_ = context.Operators.Start(l_ ?? o_);
                CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
                bool? r_ = context.Operators.In<CqlDateTime>(p_, q_, "day");
                return r_;
            }

            IEnumerable<object> h_ = context.Operators.Where<object>(f_, g_);
            Observation i_(object LowBMIInterventions) => LowBMI;
            IEnumerable<Observation> j_ = context.Operators.Select<object, Observation>(h_, i_);
            return j_;
        }

        IEnumerable<Observation> c_ = context.Operators.SelectMany<Observation, Observation>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Has Normal BMI")]
    public bool? Has_Normal_BMI(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Normal_BMI, Has_Normal_BMI_Compute);

    private const long _cacheIndex_Has_Normal_BMI = -5047732812496197000L;

    private bool? Has_Normal_BMI_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.BMI_During_Measurement_Period(context);

        bool? b_(Observation BMI) {
            DataType l_ = BMI?.Value;
            CqlQuantity m_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, l_ as Quantity);
            CqlQuantity n_ = context.Operators.Quantity(18.5m, "kg/m2");
            bool? o_ = context.Operators.GreaterOrEqual(m_, n_);
            CqlQuantity q_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, l_ as Quantity);
            CqlQuantity r_ = context.Operators.Quantity(25m, "kg/m2");
            bool? s_ = context.Operators.Less(q_, r_);
            bool? t_ = context.Operators.And(o_, s_);
            return t_;
        }

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
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -1047200998746777891L;

    private bool? Numerator_Compute(CqlContext context)
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
    public IEnumerable<object> Medical_Reason_For_Not_Documenting_A_Follow_Up_Plan_For_Low_Or_High_BMI(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Medical_Reason_For_Not_Documenting_A_Follow_Up_Plan_For_Low_Or_High_BMI, Medical_Reason_For_Not_Documenting_A_Follow_Up_Plan_For_Low_Or_High_BMI_Compute);

    private const long _cacheIndex_Medical_Reason_For_Not_Documenting_A_Follow_Up_Plan_For_Low_Or_High_BMI = -2121890904857911378L;

    private IEnumerable<object> Medical_Reason_For_Not_Documenting_A_Follow_Up_Plan_For_Low_Or_High_BMI_Compute(CqlContext context)
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

        IEnumerable<ServiceRequest> r_(ServiceRequest NoBMIFollowUp) {
            IEnumerable<Encounter> al_ = this.Qualifying_Encounter_During_Day_Of_Measurement_Period(context);

            bool? am_(Encounter QualifyingEncounter) {
                FhirDateTime aq_ = NoBMIFollowUp?.AuthoredOnElement;
                CqlDateTime ar_ = context.Operators.Convert<CqlDateTime>(aq_);
                Period as_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> at_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, as_);
                CqlDateTime au_ = context.Operators.Start(at_);
                bool? av_ = context.Operators.SameAs(ar_, au_, "day");
                return av_;
            }

            IEnumerable<Encounter> an_ = context.Operators.Where<Encounter>(al_, am_);
            ServiceRequest ao_(Encounter QualifyingEncounter) => NoBMIFollowUp;
            IEnumerable<ServiceRequest> ap_ = context.Operators.Select<Encounter, ServiceRequest>(an_, ao_);
            return ap_;
        }

        IEnumerable<ServiceRequest> s_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(q_, r_);

        bool? t_(ServiceRequest NoBMIFollowUp) {
            Code<RequestStatus> aw_ = NoBMIFollowUp?.StatusElement;
            RequestStatus? ax_ = aw_?.Value;
            Code<RequestStatus> ay_ = context.Operators.Convert<Code<RequestStatus>>(ax_);
            bool? az_ = context.Operators.Equivalent(ay_, "completed");

            bool? ba_(Extension @this) {
                FhirUri bj_ = @this?.UrlElement;
                string bk_ = FHIRHelpers_4_4_000.Instance.ToString(context, bj_);
                bool? bl_ = context.Operators.Equal(bk_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                return bl_;
            }

            IEnumerable<Extension> bb_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoBMIFollowUp is DomainResource
                ? (NoBMIFollowUp as DomainResource).Extension
                : default), ba_);

            object bc_(Extension @this) {
                DataType bm_ = @this?.Value;
                return bm_;
            }

            IEnumerable<object> bd_ = context.Operators.Select<Extension, object>(bb_, bc_);
            object be_ = context.Operators.SingletonFrom<object>(bd_);
            CqlConcept bf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, be_ as CodeableConcept);
            CqlValueSet bg_ = this.Medical_Reason(context);
            bool? bh_ = context.Operators.ConceptInValueSet(bf_, bg_);
            bool? bi_ = context.Operators.And(az_, bh_);
            return bi_;
        }

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

        IEnumerable<MedicationRequest> ag_(MedicationRequest NoBMIFollowUp) {
            IEnumerable<Encounter> bn_ = this.Qualifying_Encounter_During_Day_Of_Measurement_Period(context);

            bool? bo_(Encounter QualifyingEncounter) {
                FhirDateTime bs_ = NoBMIFollowUp?.AuthoredOnElement;
                CqlDateTime bt_ = context.Operators.Convert<CqlDateTime>(bs_);
                Period bu_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> bv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bu_);
                CqlDateTime bw_ = context.Operators.Start(bv_);
                bool? bx_ = context.Operators.SameAs(bt_, bw_, "day");
                return bx_;
            }

            IEnumerable<Encounter> bp_ = context.Operators.Where<Encounter>(bn_, bo_);
            MedicationRequest bq_(Encounter QualifyingEncounter) => NoBMIFollowUp;
            IEnumerable<MedicationRequest> br_ = context.Operators.Select<Encounter, MedicationRequest>(bp_, bq_);
            return br_;
        }

        IEnumerable<MedicationRequest> ah_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(af_, ag_);

        bool? ai_(MedicationRequest NoBMIFollowUp) {
            Code<MedicationRequest.MedicationrequestStatus> by_ = NoBMIFollowUp?.StatusElement;
            MedicationRequest.MedicationrequestStatus? bz_ = by_?.Value;
            string ca_ = context.Operators.Convert<string>(bz_);
            bool? cb_ = context.Operators.Equivalent(ca_, "completed");
            List<CodeableConcept> cc_ = NoBMIFollowUp?.ReasonCode;

            CqlConcept cd_(CodeableConcept @this) {
                CqlConcept ci_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return ci_;
            }

            IEnumerable<CqlConcept> ce_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)cc_, cd_);
            CqlValueSet cf_ = this.Medical_Reason(context);
            bool? cg_ = context.Operators.ConceptsInValueSet(ce_, cf_);
            bool? ch_ = context.Operators.And(cb_, cg_);
            return ch_;
        }

        IEnumerable<MedicationRequest> aj_ = context.Operators.Where<MedicationRequest>(ah_, ai_);
        IEnumerable<object> ak_ = context.Operators.Union<object>(u_ as IEnumerable<object>, aj_ as IEnumerable<object>);
        return ak_;
    }


    [CqlExpressionDefinition("Medical Reason Or Patient Reason For Not Performing BMI Exam")]
    public IEnumerable<Observation> Medical_Reason_Or_Patient_Reason_For_Not_Performing_BMI_Exam(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Medical_Reason_Or_Patient_Reason_For_Not_Performing_BMI_Exam, Medical_Reason_Or_Patient_Reason_For_Not_Performing_BMI_Exam_Compute);

    private const long _cacheIndex_Medical_Reason_Or_Patient_Reason_For_Not_Performing_BMI_Exam = 2600735192836884261L;

    private IEnumerable<Observation> Medical_Reason_Or_Patient_Reason_For_Not_Performing_BMI_Exam_Compute(CqlContext context)
    {
        CqlCode a_ = this.Body_mass_index__BMI___Ratio_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationcancelled"));

        IEnumerable<Observation> d_(Observation NoBMI) {
            IEnumerable<Encounter> h_ = this.Qualifying_Encounter_During_Day_Of_Measurement_Period(context);

            bool? i_(Encounter QualifyingEncounter) {
                DataType m_ = NoBMI?.Effective;
                object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_);
                CqlDateTime p_ = context.Operators.End(o_);
                Period q_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
                CqlDateTime s_ = context.Operators.Start(r_);
                bool? t_ = context.Operators.SameAs(p_, s_, "day");
                return t_;
            }

            IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
            Observation k_(Encounter QualifyingEncounter) => NoBMI;
            IEnumerable<Observation> l_ = context.Operators.Select<Encounter, Observation>(j_, k_);
            return l_;
        }

        IEnumerable<Observation> e_ = context.Operators.SelectMany<Observation, Observation>(c_, d_);

        bool? f_(Observation NoBMI) {

            bool? u_(Extension @this) {
                FhirUri al_ = @this?.UrlElement;
                string am_ = FHIRHelpers_4_4_000.Instance.ToString(context, al_);
                bool? an_ = context.Operators.Equal(am_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                return an_;
            }

            IEnumerable<Extension> v_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoBMI is DomainResource
                ? (NoBMI as DomainResource).Extension
                : default), u_);

            object w_(Extension @this) {
                DataType ao_ = @this?.Value;
                return ao_;
            }

            IEnumerable<object> x_ = context.Operators.Select<Extension, object>(v_, w_);
            object y_ = context.Operators.SingletonFrom<object>(x_);
            CqlConcept z_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, y_ as CodeableConcept);
            CqlValueSet aa_ = this.Patient_Declined(context);
            bool? ab_ = context.Operators.ConceptInValueSet(z_, aa_);

            bool? ac_(Extension @this) {
                FhirUri ap_ = @this?.UrlElement;
                string aq_ = FHIRHelpers_4_4_000.Instance.ToString(context, ap_);
                bool? ar_ = context.Operators.Equal(aq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                return ar_;
            }

            IEnumerable<Extension> ad_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoBMI is DomainResource
                ? (NoBMI as DomainResource).Extension
                : default), ac_);

            object ae_(Extension @this) {
                DataType as_ = @this?.Value;
                return as_;
            }

            IEnumerable<object> af_ = context.Operators.Select<Extension, object>(ad_, ae_);
            object ag_ = context.Operators.SingletonFrom<object>(af_);
            CqlConcept ah_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ag_ as CodeableConcept);
            CqlValueSet ai_ = this.Medical_Reason(context);
            bool? aj_ = context.Operators.ConceptInValueSet(ah_, ai_);
            bool? ak_ = context.Operators.Or(ab_, aj_);
            return ak_;
        }

        IEnumerable<Observation> g_ = context.Operators.Where<Observation>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exceptions, Denominator_Exceptions_Compute);

    private const long _cacheIndex_Denominator_Exceptions = 8738725800645268169L;

    private bool? Denominator_Exceptions_Compute(CqlContext context)
    {
        IEnumerable<object> a_ = this.Medical_Reason_For_Not_Documenting_A_Follow_Up_Plan_For_Low_Or_High_BMI(context);
        bool? b_ = context.Operators.Exists<object>(a_);
        IEnumerable<Observation> c_ = this.Medical_Reason_Or_Patient_Reason_For_Not_Performing_BMI_Exam(context);
        bool? d_ = context.Operators.Exists<Observation>(c_);
        bool? e_ = context.Operators.Or(b_, d_);
        return e_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 3500699169556971302L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -3750332539194761427L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 6715964416781495466L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -4885014868042591606L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
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
