#nullable enable annotations

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
[CqlLibrary("CMS135FHIRACEIorARBorARNIforHF", "1.0.000")]
public partial class CMS135FHIRACEIorARBorARNIforHF_1_0_000 : ILibrary, ISingleton<CMS135FHIRACEIorARBorARNIforHF_1_0_000>
{
    #region ValueSets (8)

    [CqlValueSetDefinition("ACE Inhibitor or ARB or ARNI Ingredient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1489", valueSetVersion: null)]
    public CqlValueSet ACE_Inhibitor_or_ARB_or_ARNI_Ingredient(CqlContext _) => _ACE_Inhibitor_or_ARB_or_ARNI_Ingredient;
    private static readonly CqlValueSet _ACE_Inhibitor_or_ARB_or_ARNI_Ingredient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1489", null);

    [CqlValueSetDefinition("ACE Inhibitor or ARB or ARNI", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1139", valueSetVersion: null)]
    public CqlValueSet ACE_Inhibitor_or_ARB_or_ARNI(CqlContext _) => _ACE_Inhibitor_or_ARB_or_ARNI;
    private static readonly CqlValueSet _ACE_Inhibitor_or_ARB_or_ARNI = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1139", null);

    [CqlValueSetDefinition("Allergy to ACE Inhibitor or ARB", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1211", valueSetVersion: null)]
    public CqlValueSet Allergy_to_ACE_Inhibitor_or_ARB(CqlContext _) => _Allergy_to_ACE_Inhibitor_or_ARB;
    private static readonly CqlValueSet _Allergy_to_ACE_Inhibitor_or_ARB = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1211", null);

    [CqlValueSetDefinition("Intolerance to ACE Inhibitor or ARB", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1212", valueSetVersion: null)]
    public CqlValueSet Intolerance_to_ACE_Inhibitor_or_ARB(CqlContext _) => _Intolerance_to_ACE_Inhibitor_or_ARB;
    private static readonly CqlValueSet _Intolerance_to_ACE_Inhibitor_or_ARB = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1212", null);

    [CqlValueSetDefinition("Medical Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", valueSetVersion: null)]
    public CqlValueSet Medical_Reason(CqlContext _) => _Medical_Reason;
    private static readonly CqlValueSet _Medical_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);

    [CqlValueSetDefinition("Patient Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008", valueSetVersion: null)]
    public CqlValueSet Patient_Reason(CqlContext _) => _Patient_Reason;
    private static readonly CqlValueSet _Patient_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008", null);

    [CqlValueSetDefinition("Patient Reason for ACE Inhibitor or ARB Decline", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1140", valueSetVersion: null)]
    public CqlValueSet Patient_Reason_for_ACE_Inhibitor_or_ARB_Decline(CqlContext _) => _Patient_Reason_for_ACE_Inhibitor_or_ARB_Decline;
    private static readonly CqlValueSet _Patient_Reason_for_ACE_Inhibitor_or_ARB_Decline = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1140", null);

    [CqlValueSetDefinition("Pregnancy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.378", valueSetVersion: null)]
    public CqlValueSet Pregnancy(CqlContext _) => _Pregnancy;
    private static readonly CqlValueSet _Pregnancy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.378", null);

    #endregion ValueSets

    #region Codes (4)

    [CqlCodeDefinition("Acute renal failure caused by angiotensin-converting-enzyme inhibitor (disorder)", codeId: "422593004", codeSystem: "http://snomed.info/sct")]
    public CqlCode Acute_renal_failure_caused_by_angiotensin_converting_enzyme_inhibitor__disorder_(CqlContext _) => _Acute_renal_failure_caused_by_angiotensin_converting_enzyme_inhibitor__disorder_;
    private static readonly CqlCode _Acute_renal_failure_caused_by_angiotensin_converting_enzyme_inhibitor__disorder_ = new CqlCode("422593004", "http://snomed.info/sct");

    [CqlCodeDefinition("Substance with angiotensin II receptor antagonist mechanism of action (substance)", codeId: "372913009", codeSystem: "http://snomed.info/sct")]
    public CqlCode Substance_with_angiotensin_II_receptor_antagonist_mechanism_of_action__substance_(CqlContext _) => _Substance_with_angiotensin_II_receptor_antagonist_mechanism_of_action__substance_;
    private static readonly CqlCode _Substance_with_angiotensin_II_receptor_antagonist_mechanism_of_action__substance_ = new CqlCode("372913009", "http://snomed.info/sct");

    [CqlCodeDefinition("Substance with angiotensin-converting enzyme inhibitor mechanism of action (substance)", codeId: "372733002", codeSystem: "http://snomed.info/sct")]
    public CqlCode Substance_with_angiotensin_converting_enzyme_inhibitor_mechanism_of_action__substance_(CqlContext _) => _Substance_with_angiotensin_converting_enzyme_inhibitor_mechanism_of_action__substance_;
    private static readonly CqlCode _Substance_with_angiotensin_converting_enzyme_inhibitor_mechanism_of_action__substance_ = new CqlCode("372733002", "http://snomed.info/sct");

    [CqlCodeDefinition("Substance with neprilysin inhibitor mechanism of action (substance)", codeId: "786886009", codeSystem: "http://snomed.info/sct")]
    public CqlCode Substance_with_neprilysin_inhibitor_mechanism_of_action__substance_(CqlContext _) => _Substance_with_neprilysin_inhibitor_mechanism_of_action__substance_;
    private static readonly CqlCode _Substance_with_neprilysin_inhibitor_mechanism_of_action__substance_ = new CqlCode("786886009", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Acute_renal_failure_caused_by_angiotensin_converting_enzyme_inhibitor__disorder_,
          _Substance_with_angiotensin_II_receptor_antagonist_mechanism_of_action__substance_,
          _Substance_with_angiotensin_converting_enzyme_inhibitor_mechanism_of_action__substance_,
          _Substance_with_neprilysin_inhibitor_mechanism_of_action__substance_]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime?>? Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -3976733998904033760L;

    private CqlInterval<CqlDateTime?>? Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime? a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime? b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime?>? c_ = context.Operators.Interval(a_, b_, true, false);
        object? d_ = context.ResolveParameter("CMS135FHIRACEIorARBorARNIforHF-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime?>?)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (17)

    [CqlExpressionDefinition("Patient")]
    public Patient? Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 4169023016099987979L;

    private Patient? Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient?>? a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient? b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -645522142510806885L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        bool? a_ = AHAOverall_4_1_000.Instance.Is_Adult_With_Two_Qualifying_Outpatient_Encounters_and_One_Heart_Failure_Outpatient_Encounter_During_the_Measurement_Period(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = -9213728853240168437L;

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        IEnumerable<Encounter?>? b_ = AHAOverall_4_1_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? c_ = context.Operators.Exists<Encounter>(b_);
        bool? d_ = context.Operators.And(a_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 7006510937250587763L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        bool? a_ = AHAOverall_4_1_000.Instance.Has_Heart_Transplant(context);
        bool? b_ = AHAOverall_4_1_000.Instance.Has_Heart_Transplant_Complications(context);
        bool? c_ = context.Operators.Or(a_, b_);
        bool? d_ = AHAOverall_4_1_000.Instance.Has_Left_Ventricular_Assist_Device(context);
        bool? e_ = context.Operators.Or(c_, d_);
        bool? f_ = AHAOverall_4_1_000.Instance.Has_Left_Ventricular_Assist_Device_Complications(context);
        bool? g_ = context.Operators.Or(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Has ACEI or ARB or ARNI Ordered")]
    public bool? Has_ACEI_or_ARB_or_ARNI_Ordered(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_ACEI_or_ARB_or_ARNI_Ordered, Has_ACEI_or_ARB_or_ARNI_Ordered_Compute);

    private const long _cacheIndex_Has_ACEI_or_ARB_or_ARNI_Ordered = -1639223536239654788L;

    private bool? Has_ACEI_or_ARB_or_ARNI_Ordered_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.ACE_Inhibitor_or_ARB_or_ARNI(context);
        IEnumerable<MedicationRequest?>? b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? c_(MedicationRequest? ACEIOrARBOrARNIOrdered) {
            bool? e_ = AHAOverall_4_1_000.Instance.isOrderedDuringHeartFailureOutpatientEncounter(context, ACEIOrARBOrARNIOrdered);
            return e_;
        }

        bool? d_ = context.Operators.WhereAny<MedicationRequest>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Is Currently Taking ACEI or ARB or ARNI")]
    public bool? Is_Currently_Taking_ACEI_or_ARB_or_ARNI(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Is_Currently_Taking_ACEI_or_ARB_or_ARNI, Is_Currently_Taking_ACEI_or_ARB_or_ARNI_Compute);

    private const long _cacheIndex_Is_Currently_Taking_ACEI_or_ARB_or_ARNI = -4031888466073974089L;

    private bool? Is_Currently_Taking_ACEI_or_ARB_or_ARNI_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.ACE_Inhibitor_or_ARB_or_ARNI(context);
        IEnumerable<MedicationRequest?>? b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? c_(MedicationRequest? ActiveACEIOrARBOrARNI) {
            bool? e_ = AHAOverall_4_1_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, ActiveACEIOrARBOrARNI);
            return e_;
        }

        bool? d_ = context.Operators.WhereAny<MedicationRequest>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -6129741627322258904L;

    private bool? Numerator_Compute(CqlContext context)
    {
        bool? a_ = this.Has_ACEI_or_ARB_or_ARNI_Ordered(context);
        bool? b_ = this.Is_Currently_Taking_ACEI_or_ARB_or_ARNI(context);
        bool? c_ = context.Operators.Or(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Has Medical or Patient Reason for Not Ordering ACEI or ARB or ARNI")]
    public bool? Has_Medical_or_Patient_Reason_for_Not_Ordering_ACEI_or_ARB_or_ARNI(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Medical_or_Patient_Reason_for_Not_Ordering_ACEI_or_ARB_or_ARNI, Has_Medical_or_Patient_Reason_for_Not_Ordering_ACEI_or_ARB_or_ARNI_Compute);

    private const long _cacheIndex_Has_Medical_or_Patient_Reason_for_Not_Ordering_ACEI_or_ARB_or_ARNI = 8513167379765940662L;

    private bool? Has_Medical_or_Patient_Reason_for_Not_Ordering_ACEI_or_ARB_or_ARNI_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.ACE_Inhibitor_or_ARB_or_ARNI(context);
        IEnumerable<MedicationRequest?>? b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));

        bool? c_(MedicationRequest? NoACEIOrARBOrARNIOrdered) {
            bool? e_ = AHAOverall_4_1_000.Instance.isMedicationNotRequestedOrderedDuringHeartFailureOutpatientEncounter(context, NoACEIOrARBOrARNIOrdered);
            List<CodeableConcept?>? f_ = NoACEIOrARBOrARNIOrdered?.ReasonCode;

            CqlConcept? g_(CodeableConcept? @this) {
                CqlConcept? v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return v_;
            }

            IEnumerable<CqlConcept?>? h_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept?>?)f_, g_);
            CqlValueSet? i_ = this.Medical_Reason(context);
            bool? j_ = context.Operators.ConceptsInValueSet(h_, i_);

            CqlConcept? k_(CodeableConcept? @this) {
                CqlConcept? w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return w_;
            }

            IEnumerable<CqlConcept?>? l_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept?>?)f_, k_);
            CqlValueSet? m_ = this.Patient_Reason(context);
            bool? n_ = context.Operators.ConceptsInValueSet(l_, m_);
            bool? o_ = context.Operators.Or(j_, n_);

            CqlConcept? p_(CodeableConcept? @this) {
                CqlConcept? x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return x_;
            }

            IEnumerable<CqlConcept?>? q_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept?>?)f_, p_);
            CqlValueSet? r_ = this.Patient_Reason_for_ACE_Inhibitor_or_ARB_Decline(context);
            bool? s_ = context.Operators.ConceptsInValueSet(q_, r_);
            bool? t_ = context.Operators.Or(o_, s_);
            bool? u_ = context.Operators.And(e_, t_);
            return u_;
        }

        bool? d_ = context.Operators.WhereAny<MedicationRequest>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Has Allergy or Intolerance to ACEI or ARB or ARNI Ingredient")]
    public bool? Has_Allergy_or_Intolerance_to_ACEI_or_ARB_or_ARNI_Ingredient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Allergy_or_Intolerance_to_ACEI_or_ARB_or_ARNI_Ingredient, Has_Allergy_or_Intolerance_to_ACEI_or_ARB_or_ARNI_Ingredient_Compute);

    private const long _cacheIndex_Has_Allergy_or_Intolerance_to_ACEI_or_ARB_or_ARNI_Ingredient = 8659790867262636378L;

    private bool? Has_Allergy_or_Intolerance_to_ACEI_or_ARB_or_ARNI_Ingredient_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.ACE_Inhibitor_or_ARB_or_ARNI_Ingredient(context);
        IEnumerable<AllergyIntolerance?>? b_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        CqlCode? c_ = this.Substance_with_angiotensin_converting_enzyme_inhibitor_mechanism_of_action__substance_(context);
        IEnumerable<CqlCode?>? d_ = context.Operators.ToList<CqlCode>(c_);
        IEnumerable<AllergyIntolerance?>? e_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, default, d_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        IEnumerable<AllergyIntolerance?>? f_ = context.Operators.Union<AllergyIntolerance>(b_, e_);
        CqlCode? g_ = this.Substance_with_angiotensin_II_receptor_antagonist_mechanism_of_action__substance_(context);
        IEnumerable<CqlCode?>? h_ = context.Operators.ToList<CqlCode>(g_);
        IEnumerable<AllergyIntolerance?>? i_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, default, h_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        CqlCode? j_ = this.Substance_with_neprilysin_inhibitor_mechanism_of_action__substance_(context);
        IEnumerable<CqlCode?>? k_ = context.Operators.ToList<CqlCode>(j_);
        IEnumerable<AllergyIntolerance?>? l_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, default, k_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        IEnumerable<AllergyIntolerance?>? m_ = context.Operators.Union<AllergyIntolerance>(i_, l_);
        IEnumerable<AllergyIntolerance?>? n_ = context.Operators.Union<AllergyIntolerance>(f_, m_);

        bool? o_(AllergyIntolerance? ACEIOrARBOrARNIAllergyIntolerance) {
            bool? q_ = AHAOverall_4_1_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, ACEIOrARBOrARNIAllergyIntolerance);
            return q_;
        }

        bool? p_ = context.Operators.WhereAny<AllergyIntolerance>(n_, o_);
        return p_;
    }


    [CqlExpressionDefinition("Has Diagnosis of Allergy or Intolerance to ACEI or ARB")]
    public bool? Has_Diagnosis_of_Allergy_or_Intolerance_to_ACEI_or_ARB(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Diagnosis_of_Allergy_or_Intolerance_to_ACEI_or_ARB, Has_Diagnosis_of_Allergy_or_Intolerance_to_ACEI_or_ARB_Compute);

    private const long _cacheIndex_Has_Diagnosis_of_Allergy_or_Intolerance_to_ACEI_or_ARB = -5818497815833842781L;

    private bool? Has_Diagnosis_of_Allergy_or_Intolerance_to_ACEI_or_ARB_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Allergy_to_ACE_Inhibitor_or_ARB(context);
        IEnumerable<Condition?>? b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition?>? c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition?>?, c_ as IEnumerable<Condition?>?);
        CqlValueSet? e_ = this.Intolerance_to_ACE_Inhibitor_or_ARB(context);
        IEnumerable<Condition?>? f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition?>? g_ = context.Operators.Union<Condition>(d_ as IEnumerable<Condition?>?, f_ as IEnumerable<Condition?>?);
        IEnumerable<Condition?>? h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? i_ = context.Operators.Union<Condition>(g_ as IEnumerable<Condition?>?, h_ as IEnumerable<Condition?>?);

        bool? j_(Condition? ACEIOrARBAllergyOrIntoleranceDiagnosis) {
            bool? l_ = AHAOverall_4_1_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, ACEIOrARBAllergyOrIntoleranceDiagnosis);
            return l_;
        }

        bool? k_ = context.Operators.WhereAny<Condition>(i_, j_);
        return k_;
    }


    [CqlExpressionDefinition("Has Diagnosis of Pregnancy")]
    public bool? Has_Diagnosis_of_Pregnancy(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Diagnosis_of_Pregnancy, Has_Diagnosis_of_Pregnancy_Compute);

    private const long _cacheIndex_Has_Diagnosis_of_Pregnancy = -8354907184463934976L;

    private bool? Has_Diagnosis_of_Pregnancy_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Pregnancy(context);
        IEnumerable<Condition?>? b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition?>? c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition?>?, c_ as IEnumerable<Condition?>?);

        bool? e_(Condition? PregnancyDiagnosis) {
            IEnumerable<Encounter?>? k_ = AHAOverall_4_1_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);

            bool? l_(Encounter? ModerateOrSevereLVSDHFOutpatientEncounter) {
                CqlInterval<CqlDateTime?>? n_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PregnancyDiagnosis);
                CqlDateTime? o_ = context.Operators.Start(n_);
                Period? p_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime?>? q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                CqlDateTime? r_ = context.Operators.Start(q_);
                CqlQuantity? s_ = context.Operators.Quantity(9m, "months");
                CqlDateTime? t_ = context.Operators.Subtract(r_, s_);
                CqlInterval<CqlDateTime?>? u_ = context.Operators.Interval(t_, r_, true, true);
                bool? v_ = context.Operators.In<CqlDateTime>(o_, u_, (string)default);
                bool? w_ = context.Operators.Not((bool?)(r_ is null));
                bool? x_ = context.Operators.And(v_, w_);
                bool? y_ = AHAOverall_4_1_000.Instance.isVerified(context, PregnancyDiagnosis);
                bool? z_ = context.Operators.And(x_, y_);
                return z_;
            }

            bool? m_ = context.Operators.WhereAny<Encounter>(k_, l_);
            return m_;
        }

        bool? f_ = context.Operators.WhereAny<Condition>(d_, e_);
        IEnumerable<Observation?>? g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-pregnancystatus"));

        bool? h_(Observation? PregnantObservation) {
            IEnumerable<Encounter?>? aa_ = AHAOverall_4_1_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);

            bool? ab_(Encounter? ModerateOrSevereLVSDHFOutpatientEncounter) {
                DataType? ad_ = PregnantObservation?.Effective;
                CqlDateTime? ae_ = context.Operators.LateBoundProperty<CqlDateTime>(ad_, "value");
                CqlInterval<CqlDateTime?>? af_ = QICoreCommon_4_0_000.Instance.toInterval(context, ae_);
                CqlDateTime? ag_ = context.Operators.Start(af_);
                Period? ah_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime?>? ai_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ah_);
                CqlDateTime? aj_ = context.Operators.Start(ai_);
                CqlQuantity? ak_ = context.Operators.Quantity(9m, "months");
                CqlDateTime? al_ = context.Operators.Subtract(aj_, ak_);
                CqlInterval<CqlDateTime?>? am_ = context.Operators.Interval(al_, aj_, true, true);
                bool? an_ = context.Operators.In<CqlDateTime>(ag_, am_, (string)default);
                bool? ao_ = context.Operators.Not((bool?)(aj_ is null));
                bool? ap_ = context.Operators.And(an_, ao_);
                DataType? aq_ = PregnantObservation?.Value;
                CqlConcept? ar_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aq_ as CodeableConcept?);
                CqlValueSet? as_ = this.Pregnancy(context);
                bool? at_ = context.Operators.ConceptInValueSet(ar_, as_);
                Code<ObservationStatus>? au_ = PregnantObservation?.StatusElement;
                ObservationStatus? av_ = au_?.Value;
                Code<ObservationStatus>? aw_ = context.Operators.Convert<Code<ObservationStatus>>(av_);
                string? ax_ = context.Operators.Convert<string>(aw_);
                string?[]? ay_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? az_ = context.Operators.In<string>(ax_, (IEnumerable<string?>?)ay_);
                bool? ba_ = context.Operators.And(at_, az_);
                bool? bb_ = context.Operators.And(ap_, ba_);
                return bb_;
            }

            bool? ac_ = context.Operators.WhereAny<Encounter>(aa_, ab_);
            return ac_;
        }

        bool? i_ = context.Operators.WhereAny<Observation>(g_, h_);
        bool? j_ = context.Operators.Or(f_, i_);
        return j_;
    }


    [CqlExpressionDefinition("Has Diagnosis of Renal Failure Due to ACEI")]
    public bool? Has_Diagnosis_of_Renal_Failure_Due_to_ACEI(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Diagnosis_of_Renal_Failure_Due_to_ACEI, Has_Diagnosis_of_Renal_Failure_Due_to_ACEI_Compute);

    private const long _cacheIndex_Has_Diagnosis_of_Renal_Failure_Due_to_ACEI = -5286954077281928220L;

    private bool? Has_Diagnosis_of_Renal_Failure_Due_to_ACEI_Compute(CqlContext context)
    {
        CqlCode? a_ = this.Acute_renal_failure_caused_by_angiotensin_converting_enzyme_inhibitor__disorder_(context);
        IEnumerable<CqlCode?>? b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Condition?>? c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition?>? d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? e_ = context.Operators.Union<Condition>(c_ as IEnumerable<Condition?>?, d_ as IEnumerable<Condition?>?);

        bool? f_(Condition? RenalFailureDueToACEI) {
            bool? h_ = AHAOverall_4_1_000.Instance.overlapsHeartFailureOutpatientEncounter(context, RenalFailureDueToACEI);
            return h_;
        }

        bool? g_ = context.Operators.WhereAny<Condition>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exceptions, Denominator_Exceptions_Compute);

    private const long _cacheIndex_Denominator_Exceptions = -8731006423283549807L;

    private bool? Denominator_Exceptions_Compute(CqlContext context)
    {
        bool? a_ = this.Has_Medical_or_Patient_Reason_for_Not_Ordering_ACEI_or_ARB_or_ARNI(context);
        bool? b_ = this.Has_Allergy_or_Intolerance_to_ACEI_or_ARB_or_ARNI_Ingredient(context);
        bool? c_ = context.Operators.Or(a_, b_);
        bool? d_ = this.Has_Diagnosis_of_Allergy_or_Intolerance_to_ACEI_or_ARB(context);
        bool? e_ = context.Operators.Or(c_, d_);
        bool? f_ = this.Has_Diagnosis_of_Pregnancy(context);
        bool? g_ = context.Operators.Or(e_, f_);
        bool? h_ = this.Has_Diagnosis_of_Renal_Failure_Due_to_ACEI(context);
        bool? i_ = context.Operators.Or(g_, h_);
        return i_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -5320667802875949849L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -5297111648573505793L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 2111214370935649149L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode? SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -6580785580066384793L;

    private CqlCode? SDE_Sex_Compute(CqlContext context)
    {
        CqlCode? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS135FHIRACEIorARBorARNIforHF_1_0_000() {}

    public static CMS135FHIRACEIorARBorARNIforHF_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS135FHIRACEIorARBorARNIforHF";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance, AHAOverall_4_1_000.Instance];

    #endregion ILibrary Implementation

}
