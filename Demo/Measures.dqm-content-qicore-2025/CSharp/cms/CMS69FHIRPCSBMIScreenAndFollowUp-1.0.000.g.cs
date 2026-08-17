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
            bool? i_;
            // CQL 'and' (175:11-176:41): right operand skipped when left is false
            if (h_ is false)
            {
                i_ = false;
            }
            else
            {
                Coding j_ = BMIEncounter?.Class;
                CqlCode k_ = FHIRHelpers_4_4_000.Instance.ToCode(context, j_);
                CqlCode l_ = this.@virtual(context);
                bool? m_ = context.Operators.Equivalent(k_, l_);
                i_ = h_ & !m_;
            }
            // CQL 'and' (175:5-177:42): right operand skipped when left is false
            if (i_ is false)
            {
                return false;
            }
            else
            {
                Code<Encounter.EncounterStatus> n_ = BMIEncounter?.StatusElement;
                Encounter.EncounterStatus? o_ = n_?.Value;
                Code<Encounter.EncounterStatus> p_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(o_);
                bool? q_ = context.Operators.Equal(p_, "finished");
                return i_ & q_;
            }
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
            CqlInterval<CqlDateTime> g_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PregnancyDiagnosis);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            bool? i_ = context.Operators.Overlaps(g_, h_, "day");
            return i_;
        }

        bool? f_ = context.Operators.WhereAny<Condition>(d_, e_);
        // CQL 'or' (163:3-171:5): right operand skipped when left is true
        if (f_ is true)
        {
            return true;
        }
        else
        {
            IEnumerable<Observation> j_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-pregnancystatus"));

            bool? k_(Observation PregnantObservation) {
                DataType m_ = PregnantObservation?.Effective;
                CqlDateTime n_ = context.Operators.LateBoundProperty<CqlDateTime>(m_, "value");
                CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_);
                CqlInterval<CqlDateTime> p_ = this.Measurement_Period(context);
                bool? q_ = context.Operators.Overlaps(o_, p_, "day");
                bool? r_;
                // CQL 'and' (168:15-169:79): right operand skipped when left is false
                if (q_ is false)
                {
                    r_ = false;
                }
                else
                {
                    Code<ObservationStatus> s_ = PregnantObservation?.StatusElement;
                    ObservationStatus? t_ = s_?.Value;
                    Code<ObservationStatus> u_ = context.Operators.Convert<Code<ObservationStatus>>(t_);
                    string v_ = context.Operators.Convert<string>(u_);
                    string[] w_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? x_ = context.Operators.In<string>(v_, (IEnumerable<string>)w_);
                    r_ = q_ & x_;
                }
                // CQL 'and' (168:9-170:85): right operand skipped when left is false
                if (r_ is false)
                {
                    return false;
                }
                else
                {
                    DataType y_ = PregnantObservation?.Value;
                    CqlConcept z_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, y_ as CodeableConcept);
                    CqlValueSet aa_ = this.Pregnancy_or_Other_Related_Diagnoses(context);
                    bool? ab_ = context.Operators.ConceptInValueSet(z_, aa_);
                    return r_ & ab_;
                }
            }

            bool? l_ = context.Operators.WhereAny<Observation>(j_, k_);
            return f_ | l_;
        }
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 4225706093378547189L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        bool? a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
        bool? b_;
        // CQL 'or' (45:3-46:69): right operand skipped when left is true
        if (a_ is true)
        {
            b_ = true;
        }
        else
        {
            bool? c_ = PalliativeCare_1_18_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
            b_ = a_ | c_;
        }
        // CQL 'or' (45:3-47:46): right operand skipped when left is true
        if (b_ is true)
        {
            return true;
        }
        else
        {
            bool? d_ = this.Is_Pregnant_During_Measurement_Period(context);
            return b_ | d_;
        }
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
            // CQL 'and' (60:5-61:73): right operand skipped when left is false
            if (h_ is false)
            {
                return false;
            }
            else
            {
                CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
                DataType j_ = BMI?.Effective;
                object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
                CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_);
                bool? m_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(i_, l_, "day");
                return h_ & m_;
            }
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
                // CQL 'and': right operand skipped when left is false
                if (v_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept w_ = M?.Code;
                    CqlConcept x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, w_);
                    CqlValueSet y_ = this.Medications_for_Above_Normal_BMI(context);
                    bool? z_ = context.Operators.ConceptInValueSet(x_, y_);
                    return v_ & z_;
                }
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
            object aa_ = context.Operators.LateBoundProperty<object>(HighInterventionsOrdered, "reasonCode");
            object[] ab_ = [
                aa_,
            ];

            CqlConcept ac_(object @this) {
                CqlConcept ai_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this as CodeableConcept);
                return ai_;
            }

            IEnumerable<CqlConcept> ad_ = context.Operators.Select<object, CqlConcept>((IEnumerable<object>)ab_, ac_);
            CqlConcept ae_ = context.Operators.SingletonFrom<CqlConcept>(ad_);
            CqlConcept[] af_ = [
                ae_,
            ];
            CqlValueSet ag_ = this.Overweight_or_Obese(context);
            bool? ah_ = context.Operators.ConceptsInValueSet((IEnumerable<CqlConcept>)af_, ag_);
            // CQL 'or' (90:7-94:9): right operand skipped when left is true
            if (ah_ is true)
            {
                return true;
            }
            else
            {
                IEnumerable<Condition> aj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ag_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<Condition> ak_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ag_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<Condition> al_ = context.Operators.Union<Condition>(aj_ as IEnumerable<Condition>, ak_ as IEnumerable<Condition>);

                bool? am_(Condition OverweightObese) {
                    CqlInterval<CqlDateTime> ao_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, OverweightObese);
                    CqlDateTime ap_ = context.Operators.Start(ao_);
                    object aq_ = context.Operators.LateBoundProperty<object>(HighInterventionsOrdered, "authoredOn");
                    CqlDateTime ar_ = context.Operators.LateBoundProperty<CqlDateTime>(aq_, "value");
                    bool? as_ = context.Operators.SameOrBefore(ap_, ar_, "day");
                    return as_;
                }

                bool? an_ = context.Operators.WhereAny<Condition>(al_, am_);
                return ah_ | an_;
            }
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
                CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return j_;
            }

            IEnumerable<CqlConcept> g_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)e_, f_);
            CqlValueSet h_ = this.Overweight_or_Obese(context);
            bool? i_ = context.Operators.ConceptsInValueSet(g_, h_);
            // CQL 'or' (99:7-103:9): right operand skipped when left is true
            if (i_ is true)
            {
                return true;
            }
            else
            {
                IEnumerable<Condition> k_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

                bool? l_(Condition OverweightObese) {
                    CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, OverweightObese as Condition);
                    CqlDateTime o_ = context.Operators.Start(n_);
                    object p_;
                    DataType t_ = HighInterventionsPerformed?.Performed;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    bool v_ = u_ is CqlDateTime;
                    if (v_)
                    {
                        p_ = u_ as CqlDateTime;
                    }
                    else
                    {
                        bool w_ = u_ is CqlQuantity;
                        if (w_)
                        {
                            p_ = u_ as CqlQuantity;
                        }
                        else
                        {
                            bool x_ = u_ is CqlInterval<CqlDateTime>;
                            if (x_)
                            {
                                p_ = u_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool y_ = u_ is CqlInterval<CqlQuantity>;
                                if (y_)
                                {
                                    p_ = u_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    p_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
                    CqlDateTime r_ = context.Operators.Start(q_);
                    bool? s_ = context.Operators.SameOrBefore(o_, r_, "day");
                    // CQL 'and' (101:13-102:144): right operand skipped when left is false
                    if (s_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        CqlDateTime z_ = context.Operators.End(n_);
                        object aa_;
                        DataType ae_ = HighInterventionsPerformed?.Performed;
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
                        bool? ad_ = context.Operators.Before(z_, ac_, "day");
                        return s_ & !ad_;
                    }
                }

                bool? m_ = context.Operators.WhereAny<Condition>(k_, l_);
                return i_ | m_;
            }
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
                // CQL 'and': right operand skipped when left is false
                if (v_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept w_ = M?.Code;
                    CqlConcept x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, w_);
                    CqlValueSet y_ = this.Medications_for_Below_Normal_BMI(context);
                    bool? z_ = context.Operators.ConceptInValueSet(x_, y_);
                    return v_ & z_;
                }
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
            object aa_ = context.Operators.LateBoundProperty<object>(LowInterventionsOrdered, "reasonCode");
            object[] ab_ = [
                aa_,
            ];

            CqlConcept ac_(object @this) {
                CqlConcept ai_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this as CodeableConcept);
                return ai_;
            }

            IEnumerable<CqlConcept> ad_ = context.Operators.Select<object, CqlConcept>((IEnumerable<object>)ab_, ac_);
            CqlConcept ae_ = context.Operators.SingletonFrom<CqlConcept>(ad_);
            CqlConcept[] af_ = [
                ae_,
            ];
            CqlValueSet ag_ = this.Underweight(context);
            bool? ah_ = context.Operators.ConceptsInValueSet((IEnumerable<CqlConcept>)af_, ag_);
            // CQL 'or' (118:7-123:9): right operand skipped when left is true
            if (ah_ is true)
            {
                return true;
            }
            else
            {
                IEnumerable<Condition> aj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ag_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<Condition> ak_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ag_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<Condition> al_ = context.Operators.Union<Condition>(aj_ as IEnumerable<Condition>, ak_ as IEnumerable<Condition>);

                bool? am_(Condition UnderweightDiagnosis) {
                    CqlInterval<CqlDateTime> ao_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, UnderweightDiagnosis);
                    CqlDateTime ap_ = context.Operators.Start(ao_);
                    object aq_ = context.Operators.LateBoundProperty<object>(LowInterventionsOrdered, "authoredOn");
                    CqlDateTime ar_ = context.Operators.LateBoundProperty<CqlDateTime>(aq_, "value");
                    bool? as_ = context.Operators.SameOrBefore(ap_, ar_, "day");
                    // CQL 'and' (121:13-122:87): right operand skipped when left is false
                    if (as_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        CqlInterval<CqlDateTime> at_ = this.Measurement_Period(context);
                        bool? au_ = context.Operators.In<CqlDateTime>(ar_, at_, "day");
                        return as_ & au_;
                    }
                }

                bool? an_ = context.Operators.WhereAny<Condition>(al_, am_);
                return ah_ | an_;
            }
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
                CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return k_;
            }

            IEnumerable<CqlConcept> g_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)e_, f_);
            CqlValueSet h_ = this.Underweight(context);
            bool? i_ = context.Operators.ConceptsInValueSet(g_, h_);
            bool? j_;
            // CQL 'and' (128:13-129:58): right operand skipped when left is false
            if (i_ is false)
            {
                j_ = false;
            }
            else
            {
                Code<EventStatus> l_ = LowInterventionsPerformed?.StatusElement;
                EventStatus? m_ = l_?.Value;
                string n_ = context.Operators.Convert<string>(m_);
                bool? o_ = context.Operators.Equal(n_, "completed");
                j_ = i_ & o_;
            }
            // CQL 'or' (128:7-135:9): right operand skipped when left is true
            if (j_ is true)
            {
                return true;
            }
            else
            {
                IEnumerable<Condition> p_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

                bool? q_(Condition UnderweightDiagnosis) {
                    bool? s_ = QICoreCommon_4_0_000.Instance.isHealthConcern(context, UnderweightDiagnosis as Condition);
                    bool? t_;
                    // CQL 'and' (131:19-132:148): right operand skipped when left is false
                    if (s_ is false)
                    {
                        t_ = false;
                    }
                    else
                    {
                        CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, UnderweightDiagnosis as Condition);
                        CqlDateTime w_ = context.Operators.Start(v_);
                        object x_;
                        DataType ab_ = LowInterventionsPerformed?.Performed;
                        object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                        bool ad_ = ac_ is CqlDateTime;
                        if (ad_)
                        {
                            x_ = ac_ as CqlDateTime;
                        }
                        else
                        {
                            bool ae_ = ac_ is CqlQuantity;
                            if (ae_)
                            {
                                x_ = ac_ as CqlQuantity;
                            }
                            else
                            {
                                bool af_ = ac_ is CqlInterval<CqlDateTime>;
                                if (af_)
                                {
                                    x_ = ac_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    bool ag_ = ac_ is CqlInterval<CqlQuantity>;
                                    if (ag_)
                                    {
                                        x_ = ac_ as CqlInterval<CqlQuantity>;
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
                        t_ = s_ & aa_;
                    }
                    bool? u_;
                    // CQL 'and' (131:19-133:103): right operand skipped when left is false
                    if (t_ is false)
                    {
                        u_ = false;
                    }
                    else
                    {
                        CqlInterval<CqlDateTime> ah_ = this.Measurement_Period(context);
                        object ai_;
                        DataType al_ = LowInterventionsPerformed?.Performed;
                        object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                        bool an_ = am_ is CqlDateTime;
                        if (an_)
                        {
                            ai_ = am_ as CqlDateTime;
                        }
                        else
                        {
                            bool ao_ = am_ is CqlQuantity;
                            if (ao_)
                            {
                                ai_ = am_ as CqlQuantity;
                            }
                            else
                            {
                                bool ap_ = am_ is CqlInterval<CqlDateTime>;
                                if (ap_)
                                {
                                    ai_ = am_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    bool aq_ = am_ is CqlInterval<CqlQuantity>;
                                    if (aq_)
                                    {
                                        ai_ = am_ as CqlInterval<CqlQuantity>;
                                    }
                                    else
                                    {
                                        ai_ = null;
                                    }
                                }
                            }
                        }
                        CqlInterval<CqlDateTime> aj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ai_);
                        bool? ak_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ah_, aj_, "day");
                        u_ = t_ & ak_;
                    }
                    // CQL 'and' (131:13-134:148): right operand skipped when left is false
                    if (u_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        CqlInterval<CqlDateTime> ar_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, UnderweightDiagnosis as Condition);
                        CqlDateTime as_ = context.Operators.End(ar_);
                        object at_;
                        DataType ax_ = LowInterventionsPerformed?.Performed;
                        object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                        bool az_ = ay_ is CqlDateTime;
                        if (az_)
                        {
                            at_ = ay_ as CqlDateTime;
                        }
                        else
                        {
                            bool ba_ = ay_ is CqlQuantity;
                            if (ba_)
                            {
                                at_ = ay_ as CqlQuantity;
                            }
                            else
                            {
                                bool bb_ = ay_ is CqlInterval<CqlDateTime>;
                                if (bb_)
                                {
                                    at_ = ay_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    bool bc_ = ay_ is CqlInterval<CqlQuantity>;
                                    if (bc_)
                                    {
                                        at_ = ay_ as CqlInterval<CqlQuantity>;
                                    }
                                    else
                                    {
                                        at_ = null;
                                    }
                                }
                            }
                        }
                        CqlInterval<CqlDateTime> au_ = QICoreCommon_4_0_000.Instance.toInterval(context, at_);
                        CqlDateTime av_ = context.Operators.Start(au_);
                        bool? aw_ = context.Operators.Before(as_, av_, "day");
                        return u_ & !aw_;
                    }
                }

                bool? r_ = context.Operators.WhereAny<Condition>(p_, q_);
                return j_ | r_;
            }
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
            DataType d_ = BMI?.Value;
            CqlQuantity e_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, d_ as Quantity);
            CqlQuantity f_ = context.Operators.Quantity(18.5m, "kg/m2");
            bool? g_ = context.Operators.GreaterOrEqual(e_, f_);
            // CQL 'and' (73:7-74:34): right operand skipped when left is false
            if (g_ is false)
            {
                return false;
            }
            else
            {
                CqlQuantity h_ = context.Operators.Quantity(25m, "kg/m2");
                bool? i_ = context.Operators.Less(e_, h_);
                return g_ & i_;
            }
        }

        bool? c_ = context.Operators.WhereAny<Observation>(a_, b_);
        // CQL 'and' (72:3-78:5): right operand skipped when left is false
        if (c_ is false)
        {
            return false;
        }
        else
        {
            IEnumerable<Observation> j_ = this.Documented_High_BMI_During_Measurement_Period(context);
            bool? k_ = context.Operators.Exists<Observation>(j_);
            bool? l_;
            // CQL 'or' (76:13-78:5): right operand skipped when left is true
            if (k_ is true)
            {
                l_ = true;
            }
            else
            {
                IEnumerable<Observation> m_ = this.Documented_Low_BMI_During_Measurement_Period(context);
                bool? n_ = context.Operators.Exists<Observation>(m_);
                l_ = k_ | n_;
            }
            return c_ & !l_;
        }
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -1047200998746777891L;

    private bool? Numerator_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.High_BMI_And_Follow_Up_Provided(context);
        bool? b_ = context.Operators.Exists<Observation>(a_);
        bool? c_;
        // CQL 'or' (50:3-51:46): right operand skipped when left is true
        if (b_ is true)
        {
            c_ = true;
        }
        else
        {
            IEnumerable<Observation> d_ = this.Low_BMI_And_Follow_Up_Provided(context);
            bool? e_ = context.Operators.Exists<Observation>(d_);
            c_ = b_ | e_;
        }
        // CQL 'or' (50:3-52:23): right operand skipped when left is true
        if (c_ is true)
        {
            return true;
        }
        else
        {
            bool? f_ = this.Has_Normal_BMI(context);
            return c_ | f_;
        }
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
            // CQL 'and' (151:7-152:59): right operand skipped when left is false
            if (an_ is false)
            {
                return false;
            }
            else
            {

                bool? ao_(Extension @this) {
                    FhirUri av_ = @this?.UrlElement;
                    string aw_ = FHIRHelpers_4_4_000.Instance.ToString(context, av_);
                    bool? ax_ = context.Operators.Equal(aw_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                    return ax_;
                }


                object ap_(Extension @this) {
                    DataType ay_ = @this?.Value;
                    return ay_;
                }

                IEnumerable<object> aq_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(NoBMIFollowUp is DomainResource
                    ? (NoBMIFollowUp as DomainResource).Extension
                    : default), ao_, ap_);
                object ar_ = context.Operators.SingletonFrom<object>(aq_);
                CqlConcept as_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ar_ as CodeableConcept);
                CqlValueSet at_ = this.Medical_Reason(context);
                bool? au_ = context.Operators.ConceptInValueSet(as_, at_);
                return an_ & au_;
            }
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
            IEnumerable<Encounter> az_ = this.Qualifying_Encounter_During_Day_Of_Measurement_Period(context);

            bool? ba_(Encounter QualifyingEncounter) {
                FhirDateTime bc_ = NoBMIFollowUp?.AuthoredOnElement;
                CqlDateTime bd_ = context.Operators.Convert<CqlDateTime>(bc_);
                Period be_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> bf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, be_);
                CqlDateTime bg_ = context.Operators.Start(bf_);
                bool? bh_ = context.Operators.SameAs(bd_, bg_, "day");
                return bh_;
            }

            bool? bb_ = context.Operators.WhereAny<Encounter>(az_, ba_);
            return bb_;
        }

        IEnumerable<MedicationRequest> x_ = context.Operators.Where<MedicationRequest>(v_, w_);

        bool? y_(MedicationRequest NoBMIFollowUp) {
            Code<MedicationRequest.MedicationrequestStatus> bi_ = NoBMIFollowUp?.StatusElement;
            MedicationRequest.MedicationrequestStatus? bj_ = bi_?.Value;
            string bk_ = context.Operators.Convert<string>(bj_);
            bool? bl_ = context.Operators.Equivalent(bk_, "completed");
            // CQL 'and' (158:9-159:58): right operand skipped when left is false
            if (bl_ is false)
            {
                return false;
            }
            else
            {
                List<CodeableConcept> bm_ = NoBMIFollowUp?.ReasonCode;

                CqlConcept bn_(CodeableConcept @this) {
                    CqlConcept br_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return br_;
                }

                IEnumerable<CqlConcept> bo_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bm_, bn_);
                CqlValueSet bp_ = this.Medical_Reason(context);
                bool? bq_ = context.Operators.ConceptsInValueSet(bo_, bp_);
                return bl_ & bq_;
            }
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
                FhirUri z_ = @this?.UrlElement;
                string aa_ = FHIRHelpers_4_4_000.Instance.ToString(context, z_);
                bool? ab_ = context.Operators.Equal(aa_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                return ab_;
            }


            object t_(Extension @this) {
                DataType ac_ = @this?.Value;
                return ac_;
            }

            IEnumerable<object> u_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(NoBMI is DomainResource
                ? (NoBMI as DomainResource).Extension
                : default), s_, t_);
            object v_ = context.Operators.SingletonFrom<object>(u_);
            CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_ as CodeableConcept);
            CqlValueSet x_ = this.Patient_Declined(context);
            bool? y_ = context.Operators.ConceptInValueSet(w_, x_);
            // CQL 'or' (110:5-112:5): right operand skipped when left is true
            if (y_ is true)
            {
                return true;
            }
            else
            {

                bool? ad_(Extension @this) {
                    FhirUri ak_ = @this?.UrlElement;
                    string al_ = FHIRHelpers_4_4_000.Instance.ToString(context, ak_);
                    bool? am_ = context.Operators.Equal(al_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                    return am_;
                }


                object ae_(Extension @this) {
                    DataType an_ = @this?.Value;
                    return an_;
                }

                IEnumerable<object> af_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(NoBMI is DomainResource
                    ? (NoBMI as DomainResource).Extension
                    : default), ad_, ae_);
                object ag_ = context.Operators.SingletonFrom<object>(af_);
                CqlConcept ah_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ag_ as CodeableConcept);
                CqlValueSet ai_ = this.Medical_Reason(context);
                bool? aj_ = context.Operators.ConceptInValueSet(ah_, ai_);
                return y_ | aj_;
            }
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
        // CQL 'or' (55:3-56:76): right operand skipped when left is true
        if (b_ is true)
        {
            return true;
        }
        else
        {
            IEnumerable<Observation> c_ = this.Medical_Reason_Or_Patient_Reason_For_Not_Performing_BMI_Exam(context);
            bool? d_ = context.Operators.Exists<Observation>(c_);
            return b_ | d_;
        }
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
