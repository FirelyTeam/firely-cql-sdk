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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.2.0")]
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

            CqlBoolean i_() {
                Coding k_ = BMIEncounter?.Class;
                CqlCode l_ = FHIRHelpers_4_4_000.Instance.ToCode(context, k_);
                CqlCode m_ = this.@virtual(context);
                bool? n_ = context.Operators.Equivalent(l_, m_);
                return !n_;
            }


            CqlBoolean j_() {
                Code<Encounter.EncounterStatus> o_ = BMIEncounter?.StatusElement;
                Encounter.EncounterStatus? p_ = o_?.Value;
                Code<Encounter.EncounterStatus> q_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(p_);
                bool? r_ = context.Operators.Equal(q_, "finished");
                return r_;
            }

            return /* CQL 'and' (175:5-177:42) */ (/* CQL 'and' (175:11-176:41) */ ((CqlBoolean)h_
                && i_())
                && j_());
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
            Patient d_ = this.Patient(context);
            Date e_ = d_?.BirthDateElement;
            string f_ = e_?.Value;
            CqlDate g_ = context.Operators.ConvertStringToDate(f_);
            Period h_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
            CqlDateTime j_ = context.Operators.Start(i_);
            CqlDate k_ = context.Operators.DateFrom(j_);
            int? l_ = context.Operators.CalculateAgeAt(g_, k_, "year");
            bool? m_ = context.Operators.GreaterOrEqual(l_, 18);
            return m_;
        }

        bool? c_ = context.Operators.WhereAny<Encounter>(a_, b_);
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
        CqlValueSet a_ = this.Pregnancy_or_Other_Related_Diagnoses(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);

        bool? e_(Condition PregnancyDiagnosis) {
            CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PregnancyDiagnosis);
            CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
            bool? j_ = context.Operators.Overlaps(h_, i_, "day");
            return j_;
        }

        bool? f_ = context.Operators.WhereAny<Condition>(d_, e_);

        CqlBoolean g_() {
            IEnumerable<Observation> k_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-pregnancystatus"));

            bool? l_(Observation PregnantObservation) {
                DataType n_ = PregnantObservation?.Effective;
                CqlDateTime o_ = context.Operators.LateBoundProperty<CqlDateTime>(n_, "value");
                CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_);
                CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
                bool? r_ = context.Operators.Overlaps(p_, q_, "day");

                CqlBoolean s_() {
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
                    return z_;
                }


                CqlBoolean t_() {
                    DataType aa_ = PregnantObservation?.Value;
                    CqlConcept ab_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aa_ as CodeableConcept);
                    CqlValueSet ac_ = this.Pregnancy_or_Other_Related_Diagnoses(context);
                    bool? ad_ = context.Operators.ConceptInValueSet(ab_, ac_);
                    return ad_;
                }

                return /* CQL 'and' (168:9-170:85) */ (/* CQL 'and' (168:15-169:79) */ ((CqlBoolean)r_
                    && s_())
                    && t_());
            }

            bool? m_ = context.Operators.WhereAny<Observation>(k_, l_);
            return m_;
        }

        return /* CQL 'or' (163:3-171:5) */ ((CqlBoolean)f_
            || g_());
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 4225706093378547189L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        bool? a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
        return /* CQL 'or' (45:3-47:46) */ (/* CQL 'or' (45:3-46:69) */ ((CqlBoolean)a_
            || PalliativeCare_1_18_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context))
            || this.Is_Pregnant_During_Measurement_Period(context));
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

            CqlBoolean i_() {
                CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
                DataType k_ = BMI?.Effective;
                object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
                CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_);
                bool? n_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, m_, "day");
                return n_;
            }

            return /* CQL 'and' (60:5-61:73) */ ((CqlBoolean)h_
                && i_());
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
        IEnumerable<MedicationRequest> f_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? g_(MedicationRequest MR) {
            IEnumerable<Medication> o_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? p_(Medication M) {
                object r_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object s_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> t_ = context.Operators.Split((string)s_, "/");
                string u_ = context.Operators.Last<string>(t_);
                bool? v_ = context.Operators.Equal(r_, u_);

                CqlBoolean w_() {
                    CodeableConcept x_ = M?.Code;
                    CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                    CqlValueSet z_ = this.Medications_for_Above_Normal_BMI(context);
                    bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
                    return aa_;
                }

                return /* CQL 'and' */ ((CqlBoolean)v_
                    && w_());
            }

            bool? q_ = context.Operators.WhereAny<Medication>(o_, p_);
            return q_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
        CqlValueSet i_ = this.Medications_for_Above_Normal_BMI(context);
        IEnumerable<MedicationRequest> j_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(h_, j_);
        IEnumerable<object> l_ = context.Operators.Union<object>(e_ as IEnumerable<object>, k_ as IEnumerable<object>);

        bool? m_(object HighInterventionsOrdered) {
            object ab_ = context.Operators.LateBoundProperty<object>(HighInterventionsOrdered, "reasonCode");
            object[] ac_ = [
                ab_,
            ];

            CqlConcept ad_(object @this) {
                CqlConcept ak_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this as CodeableConcept);
                return ak_;
            }

            IEnumerable<CqlConcept> ae_ = context.Operators.Select<object, CqlConcept>((IEnumerable<object>)ac_, ad_);
            CqlConcept af_ = context.Operators.SingletonFrom<CqlConcept>(ae_);
            CqlConcept[] ag_ = [
                af_,
            ];
            CqlValueSet ah_ = this.Overweight_or_Obese(context);
            bool? ai_ = context.Operators.ConceptsInValueSet((IEnumerable<CqlConcept>)ag_, ah_);

            CqlBoolean aj_() {
                CqlValueSet al_ = this.Overweight_or_Obese(context);
                IEnumerable<Condition> am_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, al_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<Condition> an_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, al_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<Condition> ao_ = context.Operators.Union<Condition>(am_ as IEnumerable<Condition>, an_ as IEnumerable<Condition>);

                bool? ap_(Condition OverweightObese) {
                    CqlInterval<CqlDateTime> ar_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, OverweightObese);
                    CqlDateTime as_ = context.Operators.Start(ar_);
                    object at_ = context.Operators.LateBoundProperty<object>(HighInterventionsOrdered, "authoredOn");
                    CqlDateTime au_ = context.Operators.LateBoundProperty<CqlDateTime>(at_, "value");
                    bool? av_ = context.Operators.SameOrBefore(as_, au_, "day");
                    return av_;
                }

                bool? aq_ = context.Operators.WhereAny<Condition>(ao_, ap_);
                return aq_;
            }

            return /* CQL 'or' (90:7-94:9) */ ((CqlBoolean)ai_
                || aj_());
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
                CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return k_;
            }

            IEnumerable<CqlConcept> g_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)e_, f_);
            CqlValueSet h_ = this.Overweight_or_Obese(context);
            bool? i_ = context.Operators.ConceptsInValueSet(g_, h_);

            CqlBoolean j_() {
                CqlValueSet l_ = this.Overweight_or_Obese(context);
                IEnumerable<Condition> m_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

                bool? n_(Condition OverweightObese) {
                    CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, OverweightObese as Condition);
                    CqlDateTime q_ = context.Operators.Start(p_);
                    object r_;
                    DataType w_ = HighInterventionsPerformed?.Performed;
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    bool y_ = x_ is CqlDateTime;
                    if (y_)
                    {
                        r_ = x_ as CqlDateTime;
                    }
                    else
                    {
                        bool z_ = x_ is CqlQuantity;
                        if (z_)
                        {
                            r_ = x_ as CqlQuantity;
                        }
                        else
                        {
                            bool aa_ = x_ is CqlInterval<CqlDateTime>;
                            if (aa_)
                            {
                                r_ = x_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool ab_ = x_ is CqlInterval<CqlQuantity>;
                                if (ab_)
                                {
                                    r_ = x_ as CqlInterval<CqlQuantity>;
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

                    CqlBoolean v_() {
                        CqlInterval<CqlDateTime> ac_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, OverweightObese as Condition);
                        CqlDateTime ad_ = context.Operators.End(ac_);
                        object ae_;
                        DataType ai_ = HighInterventionsPerformed?.Performed;
                        object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                        bool ak_ = aj_ is CqlDateTime;
                        if (ak_)
                        {
                            ae_ = aj_ as CqlDateTime;
                        }
                        else
                        {
                            bool al_ = aj_ is CqlQuantity;
                            if (al_)
                            {
                                ae_ = aj_ as CqlQuantity;
                            }
                            else
                            {
                                bool am_ = aj_ is CqlInterval<CqlDateTime>;
                                if (am_)
                                {
                                    ae_ = aj_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    bool an_ = aj_ is CqlInterval<CqlQuantity>;
                                    if (an_)
                                    {
                                        ae_ = aj_ as CqlInterval<CqlQuantity>;
                                    }
                                    else
                                    {
                                        ae_ = null;
                                    }
                                }
                            }
                        }
                        CqlInterval<CqlDateTime> af_ = QICoreCommon_4_0_000.Instance.toInterval(context, ae_);
                        CqlDateTime ag_ = context.Operators.Start(af_);
                        bool? ah_ = context.Operators.Before(ad_, ag_, "day");
                        return !ah_;
                    }

                    return /* CQL 'and' (101:13-102:144) */ ((CqlBoolean)u_
                        && v_());
                }

                bool? o_ = context.Operators.WhereAny<Condition>(m_, n_);
                return o_;
            }

            return /* CQL 'or' (99:7-103:9) */ ((CqlBoolean)i_
                || j_());
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
                object i_;
                object q_ = context.Operators.LateBoundProperty<object>(HighBMIInterventions, "performed");
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                bool s_ = r_ is CqlDateTime;
                if (s_)
                {
                    i_ = r_ as CqlDateTime;
                }
                else
                {
                    bool t_ = r_ is CqlQuantity;
                    if (t_)
                    {
                        i_ = r_ as CqlQuantity;
                    }
                    else
                    {
                        bool u_ = r_ is CqlInterval<CqlDateTime>;
                        if (u_)
                        {
                            i_ = r_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool v_ = r_ is CqlInterval<CqlQuantity>;
                            if (v_)
                            {
                                i_ = r_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                i_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.toInterval(context, i_);
                object k_ = context.Operators.LateBoundProperty<object>(HighBMIInterventions, "authoredOn");
                CqlDateTime l_ = context.Operators.LateBoundProperty<CqlDateTime>(k_, "value");
                CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_);
                CqlDateTime n_ = context.Operators.Start(j_ ?? m_);
                CqlInterval<CqlDateTime> o_ = this.Measurement_Period(context);
                bool? p_ = context.Operators.In<CqlDateTime>(n_, o_, "day");
                return p_;
            }

            bool? h_ = context.Operators.WhereAny<object>(f_, g_);
            return h_;
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
        IEnumerable<MedicationRequest> f_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? g_(MedicationRequest MR) {
            IEnumerable<Medication> o_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? p_(Medication M) {
                object r_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object s_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> t_ = context.Operators.Split((string)s_, "/");
                string u_ = context.Operators.Last<string>(t_);
                bool? v_ = context.Operators.Equal(r_, u_);

                CqlBoolean w_() {
                    CodeableConcept x_ = M?.Code;
                    CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                    CqlValueSet z_ = this.Medications_for_Below_Normal_BMI(context);
                    bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
                    return aa_;
                }

                return /* CQL 'and' */ ((CqlBoolean)v_
                    && w_());
            }

            bool? q_ = context.Operators.WhereAny<Medication>(o_, p_);
            return q_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
        CqlValueSet i_ = this.Medications_for_Below_Normal_BMI(context);
        IEnumerable<MedicationRequest> j_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(h_, j_);
        IEnumerable<object> l_ = context.Operators.Union<object>(e_ as IEnumerable<object>, k_ as IEnumerable<object>);

        bool? m_(object LowInterventionsOrdered) {
            object ab_ = context.Operators.LateBoundProperty<object>(LowInterventionsOrdered, "reasonCode");
            object[] ac_ = [
                ab_,
            ];

            CqlConcept ad_(object @this) {
                CqlConcept ak_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this as CodeableConcept);
                return ak_;
            }

            IEnumerable<CqlConcept> ae_ = context.Operators.Select<object, CqlConcept>((IEnumerable<object>)ac_, ad_);
            CqlConcept af_ = context.Operators.SingletonFrom<CqlConcept>(ae_);
            CqlConcept[] ag_ = [
                af_,
            ];
            CqlValueSet ah_ = this.Underweight(context);
            bool? ai_ = context.Operators.ConceptsInValueSet((IEnumerable<CqlConcept>)ag_, ah_);

            CqlBoolean aj_() {
                CqlValueSet al_ = this.Underweight(context);
                IEnumerable<Condition> am_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, al_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<Condition> an_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, al_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<Condition> ao_ = context.Operators.Union<Condition>(am_ as IEnumerable<Condition>, an_ as IEnumerable<Condition>);

                bool? ap_(Condition UnderweightDiagnosis) {
                    CqlInterval<CqlDateTime> ar_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, UnderweightDiagnosis);
                    CqlDateTime as_ = context.Operators.Start(ar_);
                    object at_ = context.Operators.LateBoundProperty<object>(LowInterventionsOrdered, "authoredOn");
                    CqlDateTime au_ = context.Operators.LateBoundProperty<CqlDateTime>(at_, "value");
                    bool? av_ = context.Operators.SameOrBefore(as_, au_, "day");

                    CqlBoolean aw_() {
                        object ax_ = context.Operators.LateBoundProperty<object>(LowInterventionsOrdered, "authoredOn");
                        CqlDateTime ay_ = context.Operators.LateBoundProperty<CqlDateTime>(ax_, "value");
                        CqlInterval<CqlDateTime> az_ = this.Measurement_Period(context);
                        bool? ba_ = context.Operators.In<CqlDateTime>(ay_, az_, "day");
                        return ba_;
                    }

                    return /* CQL 'and' (121:13-122:87) */ ((CqlBoolean)av_
                        && aw_());
                }

                bool? aq_ = context.Operators.WhereAny<Condition>(ao_, ap_);
                return aq_;
            }

            return /* CQL 'or' (118:7-123:9) */ ((CqlBoolean)ai_
                || aj_());
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
                CqlConcept l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return l_;
            }

            IEnumerable<CqlConcept> g_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)e_, f_);
            CqlValueSet h_ = this.Underweight(context);
            bool? i_ = context.Operators.ConceptsInValueSet(g_, h_);

            CqlBoolean j_() {
                Code<EventStatus> m_ = LowInterventionsPerformed?.StatusElement;
                EventStatus? n_ = m_?.Value;
                string o_ = context.Operators.Convert<string>(n_);
                bool? p_ = context.Operators.Equal(o_, "completed");
                return p_;
            }


            CqlBoolean k_() {
                CqlValueSet q_ = this.Underweight(context);
                IEnumerable<Condition> r_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, q_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

                bool? s_(Condition UnderweightDiagnosis) {
                    bool? u_ = QICoreCommon_4_0_000.Instance.isHealthConcern(context, UnderweightDiagnosis as Condition);

                    CqlBoolean v_() {
                        CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, UnderweightDiagnosis as Condition);
                        CqlDateTime z_ = context.Operators.Start(y_);
                        object aa_;
                        DataType ae_ = LowInterventionsPerformed?.Performed;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        bool ag_ = af_ is CqlDateTime;
                        if (ag_)
                        {
                            aa_ = af_ as CqlDateTime;
                        }
                        else
                        {
                            bool ah_ = af_ is CqlQuantity;
                            if (ah_)
                            {
                                aa_ = af_ as CqlQuantity;
                            }
                            else
                            {
                                bool ai_ = af_ is CqlInterval<CqlDateTime>;
                                if (ai_)
                                {
                                    aa_ = af_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    bool aj_ = af_ is CqlInterval<CqlQuantity>;
                                    if (aj_)
                                    {
                                        aa_ = af_ as CqlInterval<CqlQuantity>;
                                    }
                                    else
                                    {
                                        aa_ = null;
                                    }
                                }
                            }
                        }
                        CqlInterval<CqlDateTime> ab_ = QICoreCommon_4_0_000.Instance.toInterval(context, aa_);
                        CqlDateTime ac_ = context.Operators.Start(ab_);
                        bool? ad_ = context.Operators.SameOrBefore(z_, ac_, "day");
                        return ad_;
                    }


                    CqlBoolean w_() {
                        CqlInterval<CqlDateTime> ak_ = this.Measurement_Period(context);
                        object al_;
                        DataType ao_ = LowInterventionsPerformed?.Performed;
                        object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                        bool aq_ = ap_ is CqlDateTime;
                        if (aq_)
                        {
                            al_ = ap_ as CqlDateTime;
                        }
                        else
                        {
                            bool ar_ = ap_ is CqlQuantity;
                            if (ar_)
                            {
                                al_ = ap_ as CqlQuantity;
                            }
                            else
                            {
                                bool as_ = ap_ is CqlInterval<CqlDateTime>;
                                if (as_)
                                {
                                    al_ = ap_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    bool at_ = ap_ is CqlInterval<CqlQuantity>;
                                    if (at_)
                                    {
                                        al_ = ap_ as CqlInterval<CqlQuantity>;
                                    }
                                    else
                                    {
                                        al_ = null;
                                    }
                                }
                            }
                        }
                        CqlInterval<CqlDateTime> am_ = QICoreCommon_4_0_000.Instance.toInterval(context, al_);
                        bool? an_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ak_, am_, "day");
                        return an_;
                    }


                    CqlBoolean x_() {
                        CqlInterval<CqlDateTime> au_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, UnderweightDiagnosis as Condition);
                        CqlDateTime av_ = context.Operators.End(au_);
                        object aw_;
                        DataType ba_ = LowInterventionsPerformed?.Performed;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        bool bc_ = bb_ is CqlDateTime;
                        if (bc_)
                        {
                            aw_ = bb_ as CqlDateTime;
                        }
                        else
                        {
                            bool bd_ = bb_ is CqlQuantity;
                            if (bd_)
                            {
                                aw_ = bb_ as CqlQuantity;
                            }
                            else
                            {
                                bool be_ = bb_ is CqlInterval<CqlDateTime>;
                                if (be_)
                                {
                                    aw_ = bb_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    bool bf_ = bb_ is CqlInterval<CqlQuantity>;
                                    if (bf_)
                                    {
                                        aw_ = bb_ as CqlInterval<CqlQuantity>;
                                    }
                                    else
                                    {
                                        aw_ = null;
                                    }
                                }
                            }
                        }
                        CqlInterval<CqlDateTime> ax_ = QICoreCommon_4_0_000.Instance.toInterval(context, aw_);
                        CqlDateTime ay_ = context.Operators.Start(ax_);
                        bool? az_ = context.Operators.Before(av_, ay_, "day");
                        return !az_;
                    }

                    return /* CQL 'and' (131:13-134:148) */ (/* CQL 'and' (131:19-133:103) */ (/* CQL 'and' (131:19-132:148) */ ((CqlBoolean)u_
                        && v_())
                        && w_())
                        && x_());
                }

                bool? t_ = context.Operators.WhereAny<Condition>(r_, s_);
                return t_;
            }

            return /* CQL 'or' (128:7-135:9) */ (/* CQL 'and' (128:13-129:58) */ ((CqlBoolean)i_
                && j_())
                || k_());
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
                object i_;
                object q_ = context.Operators.LateBoundProperty<object>(LowBMIInterventions, "performed");
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                bool s_ = r_ is CqlDateTime;
                if (s_)
                {
                    i_ = r_ as CqlDateTime;
                }
                else
                {
                    bool t_ = r_ is CqlQuantity;
                    if (t_)
                    {
                        i_ = r_ as CqlQuantity;
                    }
                    else
                    {
                        bool u_ = r_ is CqlInterval<CqlDateTime>;
                        if (u_)
                        {
                            i_ = r_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool v_ = r_ is CqlInterval<CqlQuantity>;
                            if (v_)
                            {
                                i_ = r_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                i_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.toInterval(context, i_);
                object k_ = context.Operators.LateBoundProperty<object>(LowBMIInterventions, "authoredOn");
                CqlDateTime l_ = context.Operators.LateBoundProperty<CqlDateTime>(k_, "value");
                CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_);
                CqlDateTime n_ = context.Operators.Start(j_ ?? m_);
                CqlInterval<CqlDateTime> o_ = this.Measurement_Period(context);
                bool? p_ = context.Operators.In<CqlDateTime>(n_, o_, "day");
                return p_;
            }

            bool? h_ = context.Operators.WhereAny<object>(f_, g_);
            return h_;
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
            DataType e_ = BMI?.Value;
            CqlQuantity f_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, e_ as Quantity);
            CqlQuantity g_ = context.Operators.Quantity(18.5m, "kg/m2");
            bool? h_ = context.Operators.GreaterOrEqual(f_, g_);

            CqlBoolean i_() {
                DataType j_ = BMI?.Value;
                CqlQuantity k_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, j_ as Quantity);
                CqlQuantity l_ = context.Operators.Quantity(25m, "kg/m2");
                bool? m_ = context.Operators.Less(k_, l_);
                return m_;
            }

            return /* CQL 'and' (73:7-74:34) */ ((CqlBoolean)h_
                && i_());
        }

        bool? c_ = context.Operators.WhereAny<Observation>(a_, b_);

        CqlBoolean d_() {
            IEnumerable<Observation> n_ = this.Documented_High_BMI_During_Measurement_Period(context);
            bool? o_ = context.Operators.Exists<Observation>(n_);

            CqlBoolean p_() {
                IEnumerable<Observation> q_ = this.Documented_Low_BMI_During_Measurement_Period(context);
                bool? r_ = context.Operators.Exists<Observation>(q_);
                return r_;
            }

            return !((bool?)(/* CQL 'or' (76:13-78:5) */ ((CqlBoolean)o_
                || p_())));
        }

        return /* CQL 'and' (72:3-78:5) */ ((CqlBoolean)c_
            && d_());
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -1047200998746777891L;

    private bool? Numerator_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.High_BMI_And_Follow_Up_Provided(context);
        bool? b_ = context.Operators.Exists<Observation>(a_);

        CqlBoolean c_() {
            IEnumerable<Observation> d_ = this.Low_BMI_And_Follow_Up_Provided(context);
            bool? e_ = context.Operators.Exists<Observation>(d_);
            return e_;
        }

        return /* CQL 'or' (50:3-52:23) */ (/* CQL 'or' (50:3-51:46) */ ((CqlBoolean)b_
            || c_())
            || this.Has_Normal_BMI(context));
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
                FhirDateTime ae_ = NoBMIFollowUp?.AuthoredOnElement;
                CqlDateTime af_ = context.Operators.Convert<CqlDateTime>(ae_);
                Period ag_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
                CqlDateTime ai_ = context.Operators.Start(ah_);
                bool? aj_ = context.Operators.SameAs(af_, ai_, "day");
                return aj_;
            }

            bool? ad_ = context.Operators.WhereAny<Encounter>(ab_, ac_);
            return ad_;
        }

        IEnumerable<ServiceRequest> m_ = context.Operators.Where<ServiceRequest>(k_, l_);

        bool? n_(ServiceRequest NoBMIFollowUp) {
            Code<RequestStatus> ak_ = NoBMIFollowUp?.StatusElement;
            RequestStatus? al_ = ak_?.Value;
            Code<RequestStatus> am_ = context.Operators.Convert<Code<RequestStatus>>(al_);
            bool? an_ = context.Operators.Equivalent(am_, "completed");

            CqlBoolean ao_() {

                bool? ap_(Extension @this) {
                    FhirUri aw_ = @this?.UrlElement;
                    string ax_ = FHIRHelpers_4_4_000.Instance.ToString(context, aw_);
                    bool? ay_ = context.Operators.Equal(ax_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                    return ay_;
                }


                object aq_(Extension @this) {
                    DataType az_ = @this?.Value;
                    return az_;
                }

                IEnumerable<object> ar_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(NoBMIFollowUp is DomainResource
                    ? (NoBMIFollowUp as DomainResource).Extension
                    : default), ap_, aq_);
                object as_ = context.Operators.SingletonFrom<object>(ar_);
                CqlConcept at_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, as_ as CodeableConcept);
                CqlValueSet au_ = this.Medical_Reason(context);
                bool? av_ = context.Operators.ConceptInValueSet(at_, au_);
                return av_;
            }

            return /* CQL 'and' (151:7-152:59) */ ((CqlBoolean)an_
                && ao_());
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
            IEnumerable<Encounter> ba_ = this.Qualifying_Encounter_During_Day_Of_Measurement_Period(context);

            bool? bb_(Encounter QualifyingEncounter) {
                FhirDateTime bd_ = NoBMIFollowUp?.AuthoredOnElement;
                CqlDateTime be_ = context.Operators.Convert<CqlDateTime>(bd_);
                Period bf_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> bg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bf_);
                CqlDateTime bh_ = context.Operators.Start(bg_);
                bool? bi_ = context.Operators.SameAs(be_, bh_, "day");
                return bi_;
            }

            bool? bc_ = context.Operators.WhereAny<Encounter>(ba_, bb_);
            return bc_;
        }

        IEnumerable<MedicationRequest> x_ = context.Operators.Where<MedicationRequest>(v_, w_);

        bool? y_(MedicationRequest NoBMIFollowUp) {
            Code<MedicationRequest.MedicationrequestStatus> bj_ = NoBMIFollowUp?.StatusElement;
            MedicationRequest.MedicationrequestStatus? bk_ = bj_?.Value;
            string bl_ = context.Operators.Convert<string>(bk_);
            bool? bm_ = context.Operators.Equivalent(bl_, "completed");

            CqlBoolean bn_() {
                List<CodeableConcept> bo_ = NoBMIFollowUp?.ReasonCode;

                CqlConcept bp_(CodeableConcept @this) {
                    CqlConcept bt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return bt_;
                }

                IEnumerable<CqlConcept> bq_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bo_, bp_);
                CqlValueSet br_ = this.Medical_Reason(context);
                bool? bs_ = context.Operators.ConceptsInValueSet(bq_, br_);
                return bs_;
            }

            return /* CQL 'and' (158:9-159:58) */ ((CqlBoolean)bm_
                && bn_());
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
                DataType k_ = NoBMI?.Effective;
                object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
                CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_);
                CqlDateTime n_ = context.Operators.End(m_);
                Period o_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                CqlDateTime q_ = context.Operators.Start(p_);
                bool? r_ = context.Operators.SameAs(n_, q_, "day");
                return r_;
            }

            bool? j_ = context.Operators.WhereAny<Encounter>(h_, i_);
            return j_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        bool? f_(Observation NoBMI) {

            bool? s_(Extension @this) {
                FhirUri aa_ = @this?.UrlElement;
                string ab_ = FHIRHelpers_4_4_000.Instance.ToString(context, aa_);
                bool? ac_ = context.Operators.Equal(ab_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                return ac_;
            }


            object t_(Extension @this) {
                DataType ad_ = @this?.Value;
                return ad_;
            }

            IEnumerable<object> u_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(NoBMI is DomainResource
                ? (NoBMI as DomainResource).Extension
                : default), s_, t_);
            object v_ = context.Operators.SingletonFrom<object>(u_);
            CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_ as CodeableConcept);
            CqlValueSet x_ = this.Patient_Declined(context);
            bool? y_ = context.Operators.ConceptInValueSet(w_, x_);

            CqlBoolean z_() {

                bool? ae_(Extension @this) {
                    FhirUri al_ = @this?.UrlElement;
                    string am_ = FHIRHelpers_4_4_000.Instance.ToString(context, al_);
                    bool? an_ = context.Operators.Equal(am_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                    return an_;
                }


                object af_(Extension @this) {
                    DataType ao_ = @this?.Value;
                    return ao_;
                }

                IEnumerable<object> ag_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(NoBMI is DomainResource
                    ? (NoBMI as DomainResource).Extension
                    : default), ae_, af_);
                object ah_ = context.Operators.SingletonFrom<object>(ag_);
                CqlConcept ai_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ah_ as CodeableConcept);
                CqlValueSet aj_ = this.Medical_Reason(context);
                bool? ak_ = context.Operators.ConceptInValueSet(ai_, aj_);
                return ak_;
            }

            return /* CQL 'or' (110:5-112:5) */ ((CqlBoolean)y_
                || z_());
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

        CqlBoolean c_() {
            IEnumerable<Observation> d_ = this.Medical_Reason_Or_Patient_Reason_For_Not_Performing_BMI_Exam(context);
            bool? e_ = context.Operators.Exists<Observation>(d_);
            return e_;
        }

        return /* CQL 'or' (55:3-56:76) */ ((CqlBoolean)b_
            || c_());
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
