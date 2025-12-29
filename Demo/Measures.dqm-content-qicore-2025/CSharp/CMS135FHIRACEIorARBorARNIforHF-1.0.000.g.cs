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
[CqlLibrary("CMS135FHIRACEIorARBorARNIforHF", "1.0.000")]
public partial class CMS135FHIRACEIorARBorARNIforHF_1_0_000 : ILibrary, ISingleton<CMS135FHIRACEIorARBorARNIforHF_1_0_000>
{
    private CMS135FHIRACEIorARBorARNIforHF_1_0_000() {}

    public static CMS135FHIRACEIorARBorARNIforHF_1_0_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS135FHIRACEIorARBorARNIforHF";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance, AHAOverall_4_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

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

    #region Codes

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

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Acute_renal_failure_caused_by_angiotensin_converting_enzyme_inhibitor__disorder_,
          _Substance_with_angiotensin_II_receptor_antagonist_mechanism_of_action__substance_,
          _Substance_with_angiotensin_converting_enzyme_inhibitor_mechanism_of_action__substance_,
          _Substance_with_neprilysin_inhibitor_mechanism_of_action__substance_]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object a_ = context.ResolveParameter("CMS135FHIRACEIorARBorARNIforHF-1.0.000", "Measurement Period", null);

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


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? a_ = AHAOverall_4_1_000.Instance.Is_Adult_With_Two_Qualifying_Outpatient_Encounters_and_One_Heart_Failure_Outpatient_Encounter_During_the_Measurement_Period(context);

        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        IEnumerable<Encounter> b_ = AHAOverall_4_1_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? c_ = context.Operators.Exists<Encounter>(b_);
        bool? d_ = context.Operators.And(a_, c_);

        return d_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
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
    public bool? Has_ACEI_or_ARB_or_ARNI_Ordered(CqlContext context)
    {
        CqlValueSet a_ = this.ACE_Inhibitor_or_ARB_or_ARNI(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        bool? c_(MedicationRequest ACEIOrARBOrARNIOrdered)
        {
            bool? f_ = AHAOverall_4_1_000.Instance.isOrderedDuringHeartFailureOutpatientEncounter(context, ACEIOrARBOrARNIOrdered);

            return f_;
        };
        IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(b_, c_);
        bool? e_ = context.Operators.Exists<MedicationRequest>(d_);

        return e_;
    }


    [CqlExpressionDefinition("Is Currently Taking ACEI or ARB or ARNI")]
    public bool? Is_Currently_Taking_ACEI_or_ARB_or_ARNI(CqlContext context)
    {
        CqlValueSet a_ = this.ACE_Inhibitor_or_ARB_or_ARNI(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        bool? c_(MedicationRequest ActiveACEIOrARBOrARNI)
        {
            bool? f_ = AHAOverall_4_1_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, ActiveACEIOrARBOrARNI);

            return f_;
        };
        IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(b_, c_);
        bool? e_ = context.Operators.Exists<MedicationRequest>(d_);

        return e_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? a_ = this.Has_ACEI_or_ARB_or_ARNI_Ordered(context);
        bool? b_ = this.Is_Currently_Taking_ACEI_or_ARB_or_ARNI(context);
        bool? c_ = context.Operators.Or(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Has Medical or Patient Reason for Not Ordering ACEI or ARB or ARNI")]
    public bool? Has_Medical_or_Patient_Reason_for_Not_Ordering_ACEI_or_ARB_or_ARNI(CqlContext context)
    {
        CqlValueSet a_ = this.ACE_Inhibitor_or_ARB_or_ARNI(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        bool? c_(MedicationRequest NoACEIOrARBOrARNIOrdered)
        {
            bool? f_ = AHAOverall_4_1_000.Instance.isMedicationNotRequestedOrderedDuringHeartFailureOutpatientEncounter(context, NoACEIOrARBOrARNIOrdered);
            List<CodeableConcept> g_ = NoACEIOrARBOrARNIOrdered?.ReasonCode;
            CqlConcept h_(CodeableConcept @this)
            {
                CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return y_;
            };
            IEnumerable<CqlConcept> i_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)g_, h_);
            CqlValueSet j_ = this.Medical_Reason(context);
            bool? k_ = context.Operators.ConceptsInValueSet(i_, j_);
            CqlConcept m_(CodeableConcept @this)
            {
                CqlConcept z_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return z_;
            };
            IEnumerable<CqlConcept> n_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)g_, m_);
            CqlValueSet o_ = this.Patient_Reason(context);
            bool? p_ = context.Operators.ConceptsInValueSet(n_, o_);
            bool? q_ = context.Operators.Or(k_, p_);
            CqlConcept s_(CodeableConcept @this)
            {
                CqlConcept aa_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return aa_;
            };
            IEnumerable<CqlConcept> t_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)g_, s_);
            CqlValueSet u_ = this.Patient_Reason_for_ACE_Inhibitor_or_ARB_Decline(context);
            bool? v_ = context.Operators.ConceptsInValueSet(t_, u_);
            bool? w_ = context.Operators.Or(q_, v_);
            bool? x_ = context.Operators.And(f_, w_);

            return x_;
        };
        IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(b_, c_);
        bool? e_ = context.Operators.Exists<MedicationRequest>(d_);

        return e_;
    }


    [CqlExpressionDefinition("Has Allergy or Intolerance to ACEI or ARB or ARNI Ingredient")]
    public bool? Has_Allergy_or_Intolerance_to_ACEI_or_ARB_or_ARNI_Ingredient(CqlContext context)
    {
        CqlValueSet a_ = this.ACE_Inhibitor_or_ARB_or_ARNI_Ingredient(context);
        IEnumerable<AllergyIntolerance> b_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        CqlCode c_ = this.Substance_with_angiotensin_converting_enzyme_inhibitor_mechanism_of_action__substance_(context);
        IEnumerable<CqlCode> d_ = context.Operators.ToList<CqlCode>(c_);
        IEnumerable<AllergyIntolerance> e_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, default, d_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        IEnumerable<AllergyIntolerance> f_ = context.Operators.Union<AllergyIntolerance>(b_, e_);
        CqlCode g_ = this.Substance_with_angiotensin_II_receptor_antagonist_mechanism_of_action__substance_(context);
        IEnumerable<CqlCode> h_ = context.Operators.ToList<CqlCode>(g_);
        IEnumerable<AllergyIntolerance> i_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, default, h_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        CqlCode j_ = this.Substance_with_neprilysin_inhibitor_mechanism_of_action__substance_(context);
        IEnumerable<CqlCode> k_ = context.Operators.ToList<CqlCode>(j_);
        IEnumerable<AllergyIntolerance> l_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, default, k_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        IEnumerable<AllergyIntolerance> m_ = context.Operators.Union<AllergyIntolerance>(i_, l_);
        IEnumerable<AllergyIntolerance> n_ = context.Operators.Union<AllergyIntolerance>(f_, m_);
        bool? o_(AllergyIntolerance ACEIOrARBOrARNIAllergyIntolerance)
        {
            bool? r_ = AHAOverall_4_1_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, ACEIOrARBOrARNIAllergyIntolerance);

            return r_;
        };
        IEnumerable<AllergyIntolerance> p_ = context.Operators.Where<AllergyIntolerance>(n_, o_);
        bool? q_ = context.Operators.Exists<AllergyIntolerance>(p_);

        return q_;
    }


    [CqlExpressionDefinition("Has Diagnosis of Allergy or Intolerance to ACEI or ARB")]
    public bool? Has_Diagnosis_of_Allergy_or_Intolerance_to_ACEI_or_ARB(CqlContext context)
    {
        CqlValueSet a_ = this.Allergy_to_ACE_Inhibitor_or_ARB(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
        CqlValueSet f_ = this.Intolerance_to_ACE_Inhibitor_or_ARB(context);
        IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<object> h_ = context.Operators.Union<object>(e_ as IEnumerable<object>, g_ as IEnumerable<object>);
        IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<object> k_ = context.Operators.Union<object>(h_ as IEnumerable<object>, j_ as IEnumerable<object>);
        bool? l_(object ACEIOrARBAllergyOrIntoleranceDiagnosis)
        {
            bool? o_ = AHAOverall_4_1_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, ACEIOrARBAllergyOrIntoleranceDiagnosis);

            return o_;
        };
        IEnumerable<object> m_ = context.Operators.Where<object>(k_, l_);
        bool? n_ = context.Operators.Exists<object>(m_);

        return n_;
    }


    [CqlExpressionDefinition("Has Diagnosis of Pregnancy")]
    public bool? Has_Diagnosis_of_Pregnancy(CqlContext context)
    {
        CqlValueSet a_ = this.Pregnancy(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
        IEnumerable<object> f_(object PregnancyDiagnosis)
        {
            IEnumerable<Encounter> n_ = AHAOverall_4_1_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? o_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PregnancyDiagnosis);
                CqlDateTime t_ = context.Operators.Start(s_);
                Period u_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
                CqlDateTime w_ = context.Operators.Start(v_);
                CqlQuantity x_ = context.Operators.Quantity(9m, "months");
                CqlDateTime y_ = context.Operators.Subtract(w_, x_);
                CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
                CqlDateTime ab_ = context.Operators.Start(aa_);
                CqlInterval<CqlDateTime> ac_ = context.Operators.Interval(y_, ab_, true, true);
                bool? ad_ = context.Operators.In<CqlDateTime>(t_, ac_, default);
                CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
                CqlDateTime ag_ = context.Operators.Start(af_);
                bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
                bool? ai_ = context.Operators.And(ad_, ah_);
                bool? aj_ = AHAOverall_4_1_000.Instance.isVerified(context, PregnancyDiagnosis);
                bool? ak_ = context.Operators.And(ai_, aj_);

                return ak_;
            };
            IEnumerable<Encounter> p_ = context.Operators.Where<Encounter>(n_, o_);
            object q_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
            PregnancyDiagnosis;
            IEnumerable<object> r_ = context.Operators.Select<Encounter, object>(p_, q_);

            return r_;
        };
        IEnumerable<object> g_ = context.Operators.SelectMany<object, object>(e_, f_);
        bool? h_ = context.Operators.Exists<object>(g_);
        IEnumerable<Observation> i_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-pregnancystatus"));
        IEnumerable<Observation> j_(Observation PregnantObservation)
        {
            IEnumerable<Encounter> al_ = AHAOverall_4_1_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? am_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                DataType aq_ = PregnantObservation?.Effective;
                CqlDateTime ar_ = context.Operators.LateBoundProperty<CqlDateTime>(aq_, "value");
                CqlInterval<CqlDateTime> as_ = QICoreCommon_4_0_000.Instance.toInterval(context, ar_ as object);
                CqlDateTime at_ = context.Operators.Start(as_);
                Period au_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> av_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, au_);
                CqlDateTime aw_ = context.Operators.Start(av_);
                CqlQuantity ax_ = context.Operators.Quantity(9m, "months");
                CqlDateTime ay_ = context.Operators.Subtract(aw_, ax_);
                CqlInterval<CqlDateTime> ba_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, au_);
                CqlDateTime bb_ = context.Operators.Start(ba_);
                CqlInterval<CqlDateTime> bc_ = context.Operators.Interval(ay_, bb_, true, true);
                bool? bd_ = context.Operators.In<CqlDateTime>(at_, bc_, default);
                CqlInterval<CqlDateTime> bf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, au_);
                CqlDateTime bg_ = context.Operators.Start(bf_);
                bool? bh_ = context.Operators.Not((bool?)(bg_ is null));
                bool? bi_ = context.Operators.And(bd_, bh_);
                DataType bj_ = PregnantObservation?.Value;
                CqlConcept bk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bj_ as CodeableConcept);
                CqlValueSet bl_ = this.Pregnancy(context);
                bool? bm_ = context.Operators.ConceptInValueSet(bk_, bl_);
                Code<ObservationStatus> bn_ = PregnantObservation?.StatusElement;
                ObservationStatus? bo_ = bn_?.Value;
                Code<ObservationStatus> bp_ = context.Operators.Convert<Code<ObservationStatus>>(bo_);
                string bq_ = context.Operators.Convert<string>(bp_);
                string[] br_ = [
                "final",
                "amended",
                "corrected",
                    ];
                bool? bs_ = context.Operators.In<string>(bq_, (IEnumerable<string>)br_);
                bool? bt_ = context.Operators.And(bm_, bs_);
                bool? bu_ = context.Operators.And(bi_, bt_);

                return bu_;
            };
            IEnumerable<Encounter> an_ = context.Operators.Where<Encounter>(al_, am_);
            Observation ao_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
            PregnantObservation;
            IEnumerable<Observation> ap_ = context.Operators.Select<Encounter, Observation>(an_, ao_);

            return ap_;
        };
        IEnumerable<Observation> k_ = context.Operators.SelectMany<Observation, Observation>(i_, j_);
        bool? l_ = context.Operators.Exists<Observation>(k_);
        bool? m_ = context.Operators.Or(h_, l_);

        return m_;
    }


    [CqlExpressionDefinition("Has Diagnosis of Renal Failure Due to ACEI")]
    public bool? Has_Diagnosis_of_Renal_Failure_Due_to_ACEI(CqlContext context)
    {
        CqlCode a_ = this.Acute_renal_failure_caused_by_angiotensin_converting_enzyme_inhibitor__disorder_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<object> g_ = context.Operators.Union<object>(c_ as IEnumerable<object>, f_ as IEnumerable<object>);
        bool? h_(object RenalFailureDueToACEI)
        {
            bool? k_ = AHAOverall_4_1_000.Instance.overlapsHeartFailureOutpatientEncounter(context, RenalFailureDueToACEI);

            return k_;
        };
        IEnumerable<object> i_ = context.Operators.Where<object>(g_, h_);
        bool? j_ = context.Operators.Exists<object>(i_);

        return j_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
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
