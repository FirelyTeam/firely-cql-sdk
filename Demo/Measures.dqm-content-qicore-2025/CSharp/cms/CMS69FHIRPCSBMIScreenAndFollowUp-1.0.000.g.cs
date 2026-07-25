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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.5.0")]
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
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);

        bool? e_(Condition PregnancyDiagnosis) {
            CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PregnancyDiagnosis);
            CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
            bool? o_ = context.Operators.Overlaps(m_, n_, "day");
            return o_;
        }

        IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
        bool? g_ = context.Operators.Exists<Condition>(f_);
        IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-pregnancystatus"));

        bool? i_(Observation PregnantObservation) {
            DataType p_ = PregnantObservation?.Effective;
            CqlDateTime q_ = context.Operators.LateBoundProperty<CqlDateTime>(p_, "value");
            CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
            CqlInterval<CqlDateTime> s_ = this.Measurement_Period(context);
            bool? t_ = context.Operators.Overlaps(r_, s_, "day");
            Code<ObservationStatus> u_ = PregnantObservation?.StatusElement;
            ObservationStatus? v_ = u_?.Value;
            Code<ObservationStatus> w_ = context.Operators.Convert<Code<ObservationStatus>>(v_);
            string x_ = context.Operators.Convert<string>(w_);
            string[] y_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? z_ = context.Operators.In<string>(x_, (IEnumerable<string>)y_);
            bool? aa_ = context.Operators.And(t_, z_);
            DataType ab_ = PregnantObservation?.Value;
            CqlConcept ac_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ab_ as CodeableConcept);
            CqlValueSet ad_ = this.Pregnancy_or_Other_Related_Diagnoses(context);
            bool? ae_ = context.Operators.ConceptInValueSet(ac_, ad_);
            bool? af_ = context.Operators.And(aa_, ae_);
            return af_;
        }

        IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);
        bool? k_ = context.Operators.Exists<Observation>(j_);
        bool? l_ = context.Operators.Or(g_, k_);
        return l_;
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

        bool? i_(MedicationRequest MR) {
            IEnumerable<Medication> o_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? p_(Medication M) {
                object s_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object t_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> u_ = context.Operators.Split((string)t_, "/");
                string v_ = context.Operators.Last<string>(u_);
                bool? w_ = context.Operators.Equal(s_, v_);
                CodeableConcept x_ = M?.Code;
                CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                CqlValueSet z_ = this.Medications_for_Above_Normal_BMI(context);
                bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
                bool? ab_ = context.Operators.And(w_, aa_);
                return ab_;
            }

            IEnumerable<Medication> q_ = context.Operators.Where<Medication>(o_, p_);
            bool? r_ = context.Operators.Exists<Medication>(q_);
            return r_;
        }

        IEnumerable<MedicationRequest> j_ = context.Operators.Where<MedicationRequest>(h_, i_);
        IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(g_, j_);
        IEnumerable<object> l_ = context.Operators.Union<object>(e_ as IEnumerable<object>, k_ as IEnumerable<object>);

        bool? m_(object HighInterventionsOrdered) {
            object ac_ = context.Operators.LateBoundProperty<object>(HighInterventionsOrdered, "reasonCode");
            object[] ad_ = [
                ac_,
            ];

            CqlConcept ae_(object @this) {
                CqlConcept ar_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this as CodeableConcept);
                return ar_;
            }

            IEnumerable<CqlConcept> af_ = context.Operators.Select<object, CqlConcept>((IEnumerable<object>)ad_, ae_);
            CqlConcept ag_ = context.Operators.SingletonFrom<CqlConcept>(af_);
            CqlConcept[] ah_ = [
                ag_,
            ];
            CqlValueSet ai_ = this.Overweight_or_Obese(context);
            bool? aj_ = context.Operators.ConceptsInValueSet((IEnumerable<CqlConcept>)ah_, ai_);
            IEnumerable<Condition> ak_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ai_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> al_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ai_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> am_ = context.Operators.Union<Condition>(ak_ as IEnumerable<Condition>, al_ as IEnumerable<Condition>);

            bool? an_(Condition OverweightObese) {
                CqlInterval<CqlDateTime> as_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, OverweightObese);
                CqlDateTime at_ = context.Operators.Start(as_);
                object au_ = context.Operators.LateBoundProperty<object>(HighInterventionsOrdered, "authoredOn");
                CqlDateTime av_ = context.Operators.LateBoundProperty<CqlDateTime>(au_, "value");
                bool? aw_ = context.Operators.SameOrBefore(at_, av_, "day");
                return aw_;
            }

            IEnumerable<Condition> ao_ = context.Operators.Where<Condition>(am_, an_);
            bool? ap_ = context.Operators.Exists<Condition>(ao_);
            bool? aq_ = context.Operators.Or(aj_, ap_);
            return aq_;
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
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return o_;
            }

            IEnumerable<CqlConcept> g_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)e_, f_);
            CqlValueSet h_ = this.Overweight_or_Obese(context);
            bool? i_ = context.Operators.ConceptsInValueSet(g_, h_);
            IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? k_(Condition OverweightObese) {
                CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, OverweightObese as Condition);
                CqlDateTime q_ = context.Operators.Start(p_);
                object r_;
                DataType ac_ = HighInterventionsPerformed?.Performed;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                bool ae_ = ad_ is CqlDateTime;
                if (ae_)
                {
                    DataType af_ = HighInterventionsPerformed?.Performed;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    r_ = ag_ as CqlDateTime;
                }
                else
                {
                    DataType ah_ = HighInterventionsPerformed?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    bool aj_ = ai_ is CqlInterval<CqlDateTime>;
                    if (aj_)
                    {
                        DataType ak_ = HighInterventionsPerformed?.Performed;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        r_ = al_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType am_ = HighInterventionsPerformed?.Performed;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        bool ao_ = an_ is CqlQuantity;
                        if (ao_)
                        {
                            DataType ap_ = HighInterventionsPerformed?.Performed;
                            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                            r_ = aq_ as CqlQuantity;
                        }
                        else
                        {
                            DataType ar_ = HighInterventionsPerformed?.Performed;
                            object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                            bool at_ = as_ is CqlInterval<CqlQuantity>;
                            if (at_)
                            {
                                DataType au_ = HighInterventionsPerformed?.Performed;
                                object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                                r_ = av_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                r_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_);
                CqlDateTime t_ = context.Operators.Start(s_);
                bool? u_ = context.Operators.SameOrBefore(q_, t_, "day");
                CqlDateTime v_ = context.Operators.End(p_);
                object w_;
                DataType aw_ = HighInterventionsPerformed?.Performed;
                object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                bool ay_ = ax_ is CqlDateTime;
                if (ay_)
                {
                    DataType az_ = HighInterventionsPerformed?.Performed;
                    object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                    w_ = ba_ as CqlDateTime;
                }
                else
                {
                    DataType bb_ = HighInterventionsPerformed?.Performed;
                    object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                    bool bd_ = bc_ is CqlInterval<CqlDateTime>;
                    if (bd_)
                    {
                        DataType be_ = HighInterventionsPerformed?.Performed;
                        object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                        w_ = bf_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType bg_ = HighInterventionsPerformed?.Performed;
                        object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                        bool bi_ = bh_ is CqlQuantity;
                        if (bi_)
                        {
                            DataType bj_ = HighInterventionsPerformed?.Performed;
                            object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                            w_ = bk_ as CqlQuantity;
                        }
                        else
                        {
                            DataType bl_ = HighInterventionsPerformed?.Performed;
                            object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                            bool bn_ = bm_ is CqlInterval<CqlQuantity>;
                            if (bn_)
                            {
                                DataType bo_ = HighInterventionsPerformed?.Performed;
                                object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                                w_ = bp_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                w_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> x_ = QICoreCommon_4_0_000.Instance.toInterval(context, w_);
                CqlDateTime y_ = context.Operators.Start(x_);
                bool? z_ = context.Operators.Before(v_, y_, "day");
                bool? aa_ = context.Operators.Not(z_);
                bool? ab_ = context.Operators.And(u_, aa_);
                return ab_;
            }

            IEnumerable<Condition> l_ = context.Operators.Where<Condition>(j_, k_);
            bool? m_ = context.Operators.Exists<Condition>(l_);
            bool? n_ = context.Operators.Or(i_, m_);
            return n_;
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

        bool? b_(Observation HighBMI) {
            IEnumerable<object> d_ = this.High_BMI_Interventions_Ordered(context);
            IEnumerable<Procedure> e_ = this.High_BMI_Interventions_Performed(context);
            IEnumerable<object> f_ = context.Operators.Union<object>(d_ as IEnumerable<object>, e_ as IEnumerable<object>);

            bool? g_(object HighBMIInterventions) {
                object j_;
                object r_ = context.Operators.LateBoundProperty<object>(HighBMIInterventions, "performed");
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                bool t_ = s_ is CqlDateTime;
                if (t_)
                {
                    object u_ = context.Operators.LateBoundProperty<object>(HighBMIInterventions, "performed");
                    object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                    j_ = v_ as CqlDateTime;
                }
                else
                {
                    object w_ = context.Operators.LateBoundProperty<object>(HighBMIInterventions, "performed");
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    bool y_ = x_ is CqlInterval<CqlDateTime>;
                    if (y_)
                    {
                        object z_ = context.Operators.LateBoundProperty<object>(HighBMIInterventions, "performed");
                        object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                        j_ = aa_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        object ab_ = context.Operators.LateBoundProperty<object>(HighBMIInterventions, "performed");
                        object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                        bool ad_ = ac_ is CqlQuantity;
                        if (ad_)
                        {
                            object ae_ = context.Operators.LateBoundProperty<object>(HighBMIInterventions, "performed");
                            object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                            j_ = af_ as CqlQuantity;
                        }
                        else
                        {
                            object ag_ = context.Operators.LateBoundProperty<object>(HighBMIInterventions, "performed");
                            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                            bool ai_ = ah_ is CqlInterval<CqlQuantity>;
                            if (ai_)
                            {
                                object aj_ = context.Operators.LateBoundProperty<object>(HighBMIInterventions, "performed");
                                object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                                j_ = ak_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                j_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_);
                object l_ = context.Operators.LateBoundProperty<object>(HighBMIInterventions, "authoredOn");
                CqlDateTime m_ = context.Operators.LateBoundProperty<CqlDateTime>(l_, "value");
                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
                CqlDateTime o_ = context.Operators.Start(k_ ?? n_);
                CqlInterval<CqlDateTime> p_ = this.Measurement_Period(context);
                bool? q_ = context.Operators.In<CqlDateTime>(o_, p_, "day");
                return q_;
            }

            IEnumerable<object> h_ = context.Operators.Where<object>(f_, g_);
            bool? i_ = context.Operators.Exists<object>(h_);
            return i_;
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);
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

        bool? i_(MedicationRequest MR) {
            IEnumerable<Medication> o_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? p_(Medication M) {
                object s_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object t_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> u_ = context.Operators.Split((string)t_, "/");
                string v_ = context.Operators.Last<string>(u_);
                bool? w_ = context.Operators.Equal(s_, v_);
                CodeableConcept x_ = M?.Code;
                CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                CqlValueSet z_ = this.Medications_for_Below_Normal_BMI(context);
                bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
                bool? ab_ = context.Operators.And(w_, aa_);
                return ab_;
            }

            IEnumerable<Medication> q_ = context.Operators.Where<Medication>(o_, p_);
            bool? r_ = context.Operators.Exists<Medication>(q_);
            return r_;
        }

        IEnumerable<MedicationRequest> j_ = context.Operators.Where<MedicationRequest>(h_, i_);
        IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(g_, j_);
        IEnumerable<object> l_ = context.Operators.Union<object>(e_ as IEnumerable<object>, k_ as IEnumerable<object>);

        bool? m_(object LowInterventionsOrdered) {
            object ac_ = context.Operators.LateBoundProperty<object>(LowInterventionsOrdered, "reasonCode");
            object[] ad_ = [
                ac_,
            ];

            CqlConcept ae_(object @this) {
                CqlConcept ar_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this as CodeableConcept);
                return ar_;
            }

            IEnumerable<CqlConcept> af_ = context.Operators.Select<object, CqlConcept>((IEnumerable<object>)ad_, ae_);
            CqlConcept ag_ = context.Operators.SingletonFrom<CqlConcept>(af_);
            CqlConcept[] ah_ = [
                ag_,
            ];
            CqlValueSet ai_ = this.Underweight(context);
            bool? aj_ = context.Operators.ConceptsInValueSet((IEnumerable<CqlConcept>)ah_, ai_);
            IEnumerable<Condition> ak_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ai_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> al_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ai_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> am_ = context.Operators.Union<Condition>(ak_ as IEnumerable<Condition>, al_ as IEnumerable<Condition>);

            bool? an_(Condition UnderweightDiagnosis) {
                CqlInterval<CqlDateTime> as_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, UnderweightDiagnosis);
                CqlDateTime at_ = context.Operators.Start(as_);
                object au_ = context.Operators.LateBoundProperty<object>(LowInterventionsOrdered, "authoredOn");
                CqlDateTime av_ = context.Operators.LateBoundProperty<CqlDateTime>(au_, "value");
                bool? aw_ = context.Operators.SameOrBefore(at_, av_, "day");
                CqlInterval<CqlDateTime> ax_ = this.Measurement_Period(context);
                bool? ay_ = context.Operators.In<CqlDateTime>(av_, ax_, "day");
                bool? az_ = context.Operators.And(aw_, ay_);
                return az_;
            }

            IEnumerable<Condition> ao_ = context.Operators.Where<Condition>(am_, an_);
            bool? ap_ = context.Operators.Exists<Condition>(ao_);
            bool? aq_ = context.Operators.Or(aj_, ap_);
            return aq_;
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
                CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return t_;
            }

            IEnumerable<CqlConcept> g_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)e_, f_);
            CqlValueSet h_ = this.Underweight(context);
            bool? i_ = context.Operators.ConceptsInValueSet(g_, h_);
            Code<EventStatus> j_ = LowInterventionsPerformed?.StatusElement;
            EventStatus? k_ = j_?.Value;
            string l_ = context.Operators.Convert<string>(k_);
            bool? m_ = context.Operators.Equal(l_, "completed");
            bool? n_ = context.Operators.And(i_, m_);
            IEnumerable<Condition> o_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? p_(Condition UnderweightDiagnosis) {
                bool? u_ = QICoreCommon_4_0_000.Instance.isHealthConcern(context, UnderweightDiagnosis as Condition);
                CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, UnderweightDiagnosis as Condition);
                CqlDateTime w_ = context.Operators.Start(v_);
                object x_;
                DataType ao_ = LowInterventionsPerformed?.Performed;
                object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                bool aq_ = ap_ is CqlDateTime;
                if (aq_)
                {
                    DataType ar_ = LowInterventionsPerformed?.Performed;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    x_ = as_ as CqlDateTime;
                }
                else
                {
                    DataType at_ = LowInterventionsPerformed?.Performed;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    bool av_ = au_ is CqlInterval<CqlDateTime>;
                    if (av_)
                    {
                        DataType aw_ = LowInterventionsPerformed?.Performed;
                        object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                        x_ = ax_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ay_ = LowInterventionsPerformed?.Performed;
                        object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                        bool ba_ = az_ is CqlQuantity;
                        if (ba_)
                        {
                            DataType bb_ = LowInterventionsPerformed?.Performed;
                            object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                            x_ = bc_ as CqlQuantity;
                        }
                        else
                        {
                            DataType bd_ = LowInterventionsPerformed?.Performed;
                            object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                            bool bf_ = be_ is CqlInterval<CqlQuantity>;
                            if (bf_)
                            {
                                DataType bg_ = LowInterventionsPerformed?.Performed;
                                object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                                x_ = bh_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                x_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_);
                CqlDateTime z_ = context.Operators.Start(y_);
                bool? aa_ = context.Operators.SameOrBefore(w_, z_, "day");
                bool? ab_ = context.Operators.And(u_, aa_);
                CqlInterval<CqlDateTime> ac_ = this.Measurement_Period(context);
                object ad_;
                DataType bi_ = LowInterventionsPerformed?.Performed;
                object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                bool bk_ = bj_ is CqlDateTime;
                if (bk_)
                {
                    DataType bl_ = LowInterventionsPerformed?.Performed;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    ad_ = bm_ as CqlDateTime;
                }
                else
                {
                    DataType bn_ = LowInterventionsPerformed?.Performed;
                    object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    bool bp_ = bo_ is CqlInterval<CqlDateTime>;
                    if (bp_)
                    {
                        DataType bq_ = LowInterventionsPerformed?.Performed;
                        object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                        ad_ = br_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType bs_ = LowInterventionsPerformed?.Performed;
                        object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                        bool bu_ = bt_ is CqlQuantity;
                        if (bu_)
                        {
                            DataType bv_ = LowInterventionsPerformed?.Performed;
                            object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                            ad_ = bw_ as CqlQuantity;
                        }
                        else
                        {
                            DataType bx_ = LowInterventionsPerformed?.Performed;
                            object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                            bool bz_ = by_ is CqlInterval<CqlQuantity>;
                            if (bz_)
                            {
                                DataType ca_ = LowInterventionsPerformed?.Performed;
                                object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                                ad_ = cb_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ad_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ae_ = QICoreCommon_4_0_000.Instance.toInterval(context, ad_);
                bool? af_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ac_, ae_, "day");
                bool? ag_ = context.Operators.And(ab_, af_);
                CqlDateTime ah_ = context.Operators.End(v_);
                object ai_;
                DataType cc_ = LowInterventionsPerformed?.Performed;
                object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                bool ce_ = cd_ is CqlDateTime;
                if (ce_)
                {
                    DataType cf_ = LowInterventionsPerformed?.Performed;
                    object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                    ai_ = cg_ as CqlDateTime;
                }
                else
                {
                    DataType ch_ = LowInterventionsPerformed?.Performed;
                    object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                    bool cj_ = ci_ is CqlInterval<CqlDateTime>;
                    if (cj_)
                    {
                        DataType ck_ = LowInterventionsPerformed?.Performed;
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                        ai_ = cl_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType cm_ = LowInterventionsPerformed?.Performed;
                        object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                        bool co_ = cn_ is CqlQuantity;
                        if (co_)
                        {
                            DataType cp_ = LowInterventionsPerformed?.Performed;
                            object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                            ai_ = cq_ as CqlQuantity;
                        }
                        else
                        {
                            DataType cr_ = LowInterventionsPerformed?.Performed;
                            object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                            bool ct_ = cs_ is CqlInterval<CqlQuantity>;
                            if (ct_)
                            {
                                DataType cu_ = LowInterventionsPerformed?.Performed;
                                object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                                ai_ = cv_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ai_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> aj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ai_);
                CqlDateTime ak_ = context.Operators.Start(aj_);
                bool? al_ = context.Operators.Before(ah_, ak_, "day");
                bool? am_ = context.Operators.Not(al_);
                bool? an_ = context.Operators.And(ag_, am_);
                return an_;
            }

            IEnumerable<Condition> q_ = context.Operators.Where<Condition>(o_, p_);
            bool? r_ = context.Operators.Exists<Condition>(q_);
            bool? s_ = context.Operators.Or(n_, r_);
            return s_;
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

        bool? b_(Observation LowBMI) {
            IEnumerable<object> d_ = this.Low_BMI_Interventions_Ordered(context);
            IEnumerable<Procedure> e_ = this.Low_BMI_Interventions_Performed(context);
            IEnumerable<object> f_ = context.Operators.Union<object>(d_ as IEnumerable<object>, e_ as IEnumerable<object>);

            bool? g_(object LowBMIInterventions) {
                object j_;
                object r_ = context.Operators.LateBoundProperty<object>(LowBMIInterventions, "performed");
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                bool t_ = s_ is CqlDateTime;
                if (t_)
                {
                    object u_ = context.Operators.LateBoundProperty<object>(LowBMIInterventions, "performed");
                    object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                    j_ = v_ as CqlDateTime;
                }
                else
                {
                    object w_ = context.Operators.LateBoundProperty<object>(LowBMIInterventions, "performed");
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    bool y_ = x_ is CqlInterval<CqlDateTime>;
                    if (y_)
                    {
                        object z_ = context.Operators.LateBoundProperty<object>(LowBMIInterventions, "performed");
                        object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                        j_ = aa_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        object ab_ = context.Operators.LateBoundProperty<object>(LowBMIInterventions, "performed");
                        object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                        bool ad_ = ac_ is CqlQuantity;
                        if (ad_)
                        {
                            object ae_ = context.Operators.LateBoundProperty<object>(LowBMIInterventions, "performed");
                            object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                            j_ = af_ as CqlQuantity;
                        }
                        else
                        {
                            object ag_ = context.Operators.LateBoundProperty<object>(LowBMIInterventions, "performed");
                            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                            bool ai_ = ah_ is CqlInterval<CqlQuantity>;
                            if (ai_)
                            {
                                object aj_ = context.Operators.LateBoundProperty<object>(LowBMIInterventions, "performed");
                                object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                                j_ = ak_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                j_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_);
                object l_ = context.Operators.LateBoundProperty<object>(LowBMIInterventions, "authoredOn");
                CqlDateTime m_ = context.Operators.LateBoundProperty<CqlDateTime>(l_, "value");
                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
                CqlDateTime o_ = context.Operators.Start(k_ ?? n_);
                CqlInterval<CqlDateTime> p_ = this.Measurement_Period(context);
                bool? q_ = context.Operators.In<CqlDateTime>(o_, p_, "day");
                return q_;
            }

            IEnumerable<object> h_ = context.Operators.Where<object>(f_, g_);
            bool? i_ = context.Operators.Exists<object>(h_);
            return i_;
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);
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
            CqlQuantity p_ = context.Operators.Quantity(25m, "kg/m2");
            bool? q_ = context.Operators.Less(m_, p_);
            bool? r_ = context.Operators.And(o_, q_);
            return r_;
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
        IEnumerable<ServiceRequest> c_ = context.Operators.Union<ServiceRequest>(b_, b_);
        CqlValueSet d_ = this.Follow_Up_for_Above_Normal_BMI(context);
        IEnumerable<ServiceRequest> e_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> f_ = context.Operators.Union<ServiceRequest>(e_, e_);
        IEnumerable<ServiceRequest> g_ = context.Operators.Union<ServiceRequest>(c_, f_);
        CqlValueSet h_ = this.Follow_Up_for_Below_Normal_BMI(context);
        IEnumerable<ServiceRequest> i_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> j_ = context.Operators.Union<ServiceRequest>(i_, i_);
        IEnumerable<ServiceRequest> k_ = context.Operators.Union<ServiceRequest>(g_, j_);

        bool? l_(ServiceRequest NoBMIFollowUp) {
            IEnumerable<Encounter> ab_ = this.Qualifying_Encounter_During_Day_Of_Measurement_Period(context);

            bool? ac_(Encounter QualifyingEncounter) {
                FhirDateTime af_ = NoBMIFollowUp?.AuthoredOnElement;
                CqlDateTime ag_ = context.Operators.Convert<CqlDateTime>(af_);
                Period ah_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> ai_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ah_);
                CqlDateTime aj_ = context.Operators.Start(ai_);
                bool? ak_ = context.Operators.SameAs(ag_, aj_, "day");
                return ak_;
            }

            IEnumerable<Encounter> ad_ = context.Operators.Where<Encounter>(ab_, ac_);
            bool? ae_ = context.Operators.Exists<Encounter>(ad_);
            return ae_;
        }

        IEnumerable<ServiceRequest> m_ = context.Operators.Where<ServiceRequest>(k_, l_);

        bool? n_(ServiceRequest NoBMIFollowUp) {
            Code<RequestStatus> al_ = NoBMIFollowUp?.StatusElement;
            RequestStatus? am_ = al_?.Value;
            Code<RequestStatus> an_ = context.Operators.Convert<Code<RequestStatus>>(am_);
            bool? ao_ = context.Operators.Equivalent(an_, "completed");

            bool? ap_(Extension @this) {
                FhirUri ay_ = @this?.UrlElement;
                string az_ = FHIRHelpers_4_4_000.Instance.ToString(context, ay_);
                bool? ba_ = context.Operators.Equal(az_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                return ba_;
            }

            IEnumerable<Extension> aq_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoBMIFollowUp is DomainResource
                ? (NoBMIFollowUp as DomainResource).Extension
                : default), ap_);

            object ar_(Extension @this) {
                DataType bb_ = @this?.Value;
                return bb_;
            }

            IEnumerable<object> as_ = context.Operators.Select<Extension, object>(aq_, ar_);
            object at_ = context.Operators.SingletonFrom<object>(as_);
            CqlConcept au_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, at_ as CodeableConcept);
            CqlValueSet av_ = this.Medical_Reason(context);
            bool? aw_ = context.Operators.ConceptInValueSet(au_, av_);
            bool? ax_ = context.Operators.And(ao_, aw_);
            return ax_;
        }

        IEnumerable<ServiceRequest> o_ = context.Operators.Where<ServiceRequest>(m_, n_);
        CqlValueSet p_ = this.Medications_for_Above_Normal_BMI(context);
        IEnumerable<MedicationRequest> q_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> r_ = context.Operators.Union<MedicationRequest>(q_, q_);
        CqlValueSet s_ = this.Medications_for_Below_Normal_BMI(context);
        IEnumerable<MedicationRequest> t_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> u_ = context.Operators.Union<MedicationRequest>(t_, t_);
        IEnumerable<MedicationRequest> v_ = context.Operators.Union<MedicationRequest>(r_, u_);

        bool? w_(MedicationRequest NoBMIFollowUp) {
            IEnumerable<Encounter> bc_ = this.Qualifying_Encounter_During_Day_Of_Measurement_Period(context);

            bool? bd_(Encounter QualifyingEncounter) {
                FhirDateTime bg_ = NoBMIFollowUp?.AuthoredOnElement;
                CqlDateTime bh_ = context.Operators.Convert<CqlDateTime>(bg_);
                Period bi_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bi_);
                CqlDateTime bk_ = context.Operators.Start(bj_);
                bool? bl_ = context.Operators.SameAs(bh_, bk_, "day");
                return bl_;
            }

            IEnumerable<Encounter> be_ = context.Operators.Where<Encounter>(bc_, bd_);
            bool? bf_ = context.Operators.Exists<Encounter>(be_);
            return bf_;
        }

        IEnumerable<MedicationRequest> x_ = context.Operators.Where<MedicationRequest>(v_, w_);

        bool? y_(MedicationRequest NoBMIFollowUp) {
            Code<MedicationRequest.MedicationrequestStatus> bm_ = NoBMIFollowUp?.StatusElement;
            MedicationRequest.MedicationrequestStatus? bn_ = bm_?.Value;
            string bo_ = context.Operators.Convert<string>(bn_);
            bool? bp_ = context.Operators.Equivalent(bo_, "completed");
            List<CodeableConcept> bq_ = NoBMIFollowUp?.ReasonCode;

            CqlConcept br_(CodeableConcept @this) {
                CqlConcept bw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return bw_;
            }

            IEnumerable<CqlConcept> bs_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bq_, br_);
            CqlValueSet bt_ = this.Medical_Reason(context);
            bool? bu_ = context.Operators.ConceptsInValueSet(bs_, bt_);
            bool? bv_ = context.Operators.And(bp_, bu_);
            return bv_;
        }

        IEnumerable<MedicationRequest> z_ = context.Operators.Where<MedicationRequest>(x_, y_);
        IEnumerable<object> aa_ = context.Operators.Union<object>(o_ as IEnumerable<object>, z_ as IEnumerable<object>);
        return aa_;
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

        bool? d_(Observation NoBMI) {
            IEnumerable<Encounter> h_ = this.Qualifying_Encounter_During_Day_Of_Measurement_Period(context);

            bool? i_(Encounter QualifyingEncounter) {
                DataType l_ = NoBMI?.Effective;
                object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
                CqlDateTime o_ = context.Operators.End(n_);
                Period p_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                CqlDateTime r_ = context.Operators.Start(q_);
                bool? s_ = context.Operators.SameAs(o_, r_, "day");
                return s_;
            }

            IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
            bool? k_ = context.Operators.Exists<Encounter>(j_);
            return k_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        bool? f_(Observation NoBMI) {

            bool? t_(Extension @this) {
                FhirUri ak_ = @this?.UrlElement;
                string al_ = FHIRHelpers_4_4_000.Instance.ToString(context, ak_);
                bool? am_ = context.Operators.Equal(al_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                return am_;
            }

            IEnumerable<Extension> u_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoBMI is DomainResource
                ? (NoBMI as DomainResource).Extension
                : default), t_);

            object v_(Extension @this) {
                DataType an_ = @this?.Value;
                return an_;
            }

            IEnumerable<object> w_ = context.Operators.Select<Extension, object>(u_, v_);
            object x_ = context.Operators.SingletonFrom<object>(w_);
            CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_ as CodeableConcept);
            CqlValueSet z_ = this.Patient_Declined(context);
            bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);

            bool? ab_(Extension @this) {
                FhirUri ao_ = @this?.UrlElement;
                string ap_ = FHIRHelpers_4_4_000.Instance.ToString(context, ao_);
                bool? aq_ = context.Operators.Equal(ap_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                return aq_;
            }

            IEnumerable<Extension> ac_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoBMI is DomainResource
                ? (NoBMI as DomainResource).Extension
                : default), ab_);

            object ad_(Extension @this) {
                DataType ar_ = @this?.Value;
                return ar_;
            }

            IEnumerable<object> ae_ = context.Operators.Select<Extension, object>(ac_, ad_);
            object af_ = context.Operators.SingletonFrom<object>(ae_);
            CqlConcept ag_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, af_ as CodeableConcept);
            CqlValueSet ah_ = this.Medical_Reason(context);
            bool? ai_ = context.Operators.ConceptInValueSet(ag_, ah_);
            bool? aj_ = context.Operators.Or(aa_, ai_);
            return aj_;
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
