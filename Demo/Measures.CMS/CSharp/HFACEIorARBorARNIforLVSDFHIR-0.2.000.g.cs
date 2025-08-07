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
[CqlLibrary("HFACEIorARBorARNIforLVSDFHIR", "0.2.000")]
public partial class HFACEIorARBorARNIforLVSDFHIR_minus_0_2_000 : ILibrary, ISingleton<HFACEIorARBorARNIforLVSDFHIR_minus_0_2_000>
{
    private HFACEIorARBorARNIforLVSDFHIR_minus_0_2_000() {}

    public static HFACEIorARBorARNIforLVSDFHIR_minus_0_2_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "HFACEIorARBorARNIforLVSDFHIR";
    public string Version => "0.2.000";
    public ILibrary[] Dependencies => [FHIRHelpers_minus_4_4_000.Instance, SupplementalDataElements_minus_3_5_000.Instance, QICoreCommon_minus_2_1_000.Instance, AHAOverall_minus_2_8_000.Instance];

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

    [CqlValueSetDefinition("Moderate or Severe LVSD", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1090", valueSetVersion: null)]
    public CqlValueSet Moderate_or_Severe_LVSD(CqlContext _) => _Moderate_or_Severe_LVSD;
    private static readonly CqlValueSet _Moderate_or_Severe_LVSD = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1090", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Acute renal failure caused by angiotensin-converting-enzyme inhibitor (disorder)", codeId: "422593004", codeSystem: "http://snomed.info/sct")]
    public CqlCode Acute_renal_failure_caused_by_angiotensin_minus_converting_minus_enzyme_inhibitor__disorder_(CqlContext _) => _Acute_renal_failure_caused_by_angiotensin_minus_converting_minus_enzyme_inhibitor__disorder_;
    private static readonly CqlCode _Acute_renal_failure_caused_by_angiotensin_minus_converting_minus_enzyme_inhibitor__disorder_ = new CqlCode("422593004", "http://snomed.info/sct");

    [CqlCodeDefinition("Substance with angiotensin II receptor antagonist mechanism of action (substance)", codeId: "372913009", codeSystem: "http://snomed.info/sct")]
    public CqlCode Substance_with_angiotensin_II_receptor_antagonist_mechanism_of_action__substance_(CqlContext _) => _Substance_with_angiotensin_II_receptor_antagonist_mechanism_of_action__substance_;
    private static readonly CqlCode _Substance_with_angiotensin_II_receptor_antagonist_mechanism_of_action__substance_ = new CqlCode("372913009", "http://snomed.info/sct");

    [CqlCodeDefinition("Substance with angiotensin-converting enzyme inhibitor mechanism of action (substance)", codeId: "372733002", codeSystem: "http://snomed.info/sct")]
    public CqlCode Substance_with_angiotensin_minus_converting_enzyme_inhibitor_mechanism_of_action__substance_(CqlContext _) => _Substance_with_angiotensin_minus_converting_enzyme_inhibitor_mechanism_of_action__substance_;
    private static readonly CqlCode _Substance_with_angiotensin_minus_converting_enzyme_inhibitor_mechanism_of_action__substance_ = new CqlCode("372733002", "http://snomed.info/sct");

    [CqlCodeDefinition("Substance with neprilysin inhibitor mechanism of action (substance)", codeId: "786886009", codeSystem: "http://snomed.info/sct")]
    public CqlCode Substance_with_neprilysin_inhibitor_mechanism_of_action__substance_(CqlContext _) => _Substance_with_neprilysin_inhibitor_mechanism_of_action__substance_;
    private static readonly CqlCode _Substance_with_neprilysin_inhibitor_mechanism_of_action__substance_ = new CqlCode("786886009", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Acute_renal_failure_caused_by_angiotensin_minus_converting_minus_enzyme_inhibitor__disorder_,
          _Substance_with_angiotensin_II_receptor_antagonist_mechanism_of_action__substance_,
          _Substance_with_angiotensin_minus_converting_enzyme_inhibitor_mechanism_of_action__substance_,
          _Substance_with_neprilysin_inhibitor_mechanism_of_action__substance_]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("HFACEIorARBorARNIforLVSDFHIR-0.2.000", "Measurement Period", c_);

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


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? a_ = AHAOverall_minus_2_8_000.Instance.Is_Adults_With_Two_Qualifying_Outpatient_Encounters_and_One_Heart_Failure_Outpatient_Encounter_During_the_Measurement_Period(context);

        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        IEnumerable<Encounter> b_ = AHAOverall_minus_2_8_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? c_ = context.Operators.Exists<Encounter>(b_);
        bool? d_ = context.Operators.And(a_, c_);

        return d_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? a_ = AHAOverall_minus_2_8_000.Instance.Has_Heart_Transplant(context);
        bool? b_ = AHAOverall_minus_2_8_000.Instance.Has_Heart_Transplant_Complications(context);
        bool? c_ = context.Operators.Or(a_, b_);
        bool? d_ = AHAOverall_minus_2_8_000.Instance.Has_Left_Ventricular_Assist_Device(context);
        bool? e_ = context.Operators.Or(c_, d_);
        bool? f_ = AHAOverall_minus_2_8_000.Instance.Has_Left_Ventricular_Assist_Device_Complications(context);
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
            bool? f_ = AHAOverall_minus_2_8_000.Instance.isOrderedDuringHeartFailureOutpatientEncounter(context, ACEIOrARBOrARNIOrdered);

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
            bool? f_ = AHAOverall_minus_2_8_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, ActiveACEIOrARBOrARNI);

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


    [CqlExpressionDefinition("Has Allergy or Intolerance to ACEI or ARB or ARNI Ingredient")]
    public bool? Has_Allergy_or_Intolerance_to_ACEI_or_ARB_or_ARNI_Ingredient(CqlContext context)
    {
        CqlValueSet a_ = this.ACE_Inhibitor_or_ARB_or_ARNI_Ingredient(context);
        IEnumerable<AllergyIntolerance> b_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        CqlCode c_ = this.Substance_with_angiotensin_minus_converting_enzyme_inhibitor_mechanism_of_action__substance_(context);
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
            bool? r_ = AHAOverall_minus_2_8_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, ACEIOrARBOrARNIAllergyIntolerance);

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
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet c_ = this.Intolerance_to_ACE_Inhibitor_or_ARB(context);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
        bool? f_(Condition ACEIOrARBAllergyOrIntoleranceDiagnosis)
        {
            bool? i_ = AHAOverall_minus_2_8_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, ACEIOrARBAllergyOrIntoleranceDiagnosis);

            return i_;
        };
        IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
        bool? h_ = context.Operators.Exists<Condition>(g_);

        return h_;
    }


    [CqlExpressionDefinition("Has Diagnosis of Pregnancy")]
    public bool? Has_Diagnosis_of_Pregnancy(CqlContext context)
    {
        CqlValueSet a_ = this.Pregnancy(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> c_(Condition PregnancyDiagnosis)
        {
            IEnumerable<Encounter> f_ = AHAOverall_minus_2_8_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? g_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                CqlInterval<CqlDateTime> k_ = QICoreCommon_minus_2_1_000.Instance.prevalenceInterval(context, PregnancyDiagnosis);
                CqlDateTime l_ = context.Operators.Start(k_);
                Period m_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_minus_4_4_000.Instance.ToInterval(context, m_);
                CqlDateTime o_ = context.Operators.Start(n_);
                CqlQuantity p_ = context.Operators.Quantity(9m, "months");
                CqlDateTime q_ = context.Operators.Subtract(o_, p_);
                CqlInterval<CqlDateTime> s_ = FHIRHelpers_minus_4_4_000.Instance.ToInterval(context, m_);
                CqlDateTime t_ = context.Operators.Start(s_);
                CqlInterval<CqlDateTime> u_ = context.Operators.Interval(q_, t_, true, true);
                bool? v_ = context.Operators.In<CqlDateTime>(l_, u_, default);
                CqlInterval<CqlDateTime> x_ = FHIRHelpers_minus_4_4_000.Instance.ToInterval(context, m_);
                CqlDateTime y_ = context.Operators.Start(x_);
                bool? z_ = context.Operators.Not((bool?)(y_ is null));
                bool? aa_ = context.Operators.And(v_, z_);

                return aa_;
            };
            IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);
            Condition i_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                PregnancyDiagnosis;
            IEnumerable<Condition> j_ = context.Operators.Select<Encounter, Condition>(h_, i_);

            return j_;
        };
        IEnumerable<Condition> d_ = context.Operators.SelectMany<Condition, Condition>(b_, c_);
        bool? e_ = context.Operators.Exists<Condition>(d_);

        return e_;
    }


    [CqlExpressionDefinition("Has Diagnosis of Renal Failure Due to ACEI")]
    public bool? Has_Diagnosis_of_Renal_Failure_Due_to_ACEI(CqlContext context)
    {
        CqlCode a_ = this.Acute_renal_failure_caused_by_angiotensin_minus_converting_minus_enzyme_inhibitor__disorder_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? d_(Condition RenalFailureDueToACEI)
        {
            bool? g_ = AHAOverall_minus_2_8_000.Instance.overlapsHeartFailureOutpatientEncounter(context, RenalFailureDueToACEI);

            return g_;
        };
        IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);
        bool? f_ = context.Operators.Exists<Condition>(e_);

        return f_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    [CqlTag("commentedOut", "\"Has Medical or Patient Reason for Not Ordering ACEI or ARB or ARNI\"")]
    [CqlTag("commentedOutReason", "Negation issue noted in https://github.com/cqframework/cql-execution/issues/296, which is tied to https://oncprojectracking.healthit.gov/support/browse/BONNIEMAT-1455")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        bool? a_ = this.Has_Allergy_or_Intolerance_to_ACEI_or_ARB_or_ARNI_Ingredient(context);
        bool? b_ = this.Has_Diagnosis_of_Allergy_or_Intolerance_to_ACEI_or_ARB(context);
        bool? c_ = context.Operators.Or(a_, b_);
        bool? d_ = this.Has_Diagnosis_of_Pregnancy(context);
        bool? e_ = context.Operators.Or(c_, d_);
        bool? f_ = this.Has_Diagnosis_of_Renal_Failure_Due_to_ACEI(context);
        bool? g_ = context.Operators.Or(e_, f_);

        return g_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_minus_3_5_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_minus_3_5_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_minus_3_5_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_minus_3_5_000.Instance.SDE_Sex(context);

        return a_;
    }


    [CqlExpressionDefinition("Has Medical or Patient Reason for Not Ordering ACEI or ARB or ARNI")]
    public bool? Has_Medical_or_Patient_Reason_for_Not_Ordering_ACEI_or_ARB_or_ARNI(CqlContext context)
    {
        CqlValueSet a_ = this.ACE_Inhibitor_or_ARB_or_ARNI(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> c_(MedicationRequest NoACEIOrARBOrARNIOrdered)
        {
            IEnumerable<Encounter> h_ = AHAOverall_minus_2_8_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? i_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                FhirDateTime m_ = NoACEIOrARBOrARNIOrdered?.AuthoredOnElement;
                CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
                Period o_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_minus_4_4_000.Instance.ToInterval(context, o_);
                bool? q_ = context.Operators.In<CqlDateTime>(n_, p_, "day");

                return q_;
            };
            IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
            MedicationRequest k_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                NoACEIOrARBOrARNIOrdered;
            IEnumerable<MedicationRequest> l_ = context.Operators.Select<Encounter, MedicationRequest>(j_, k_);

            return l_;
        };
        IEnumerable<MedicationRequest> d_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(b_, c_);
        bool? e_(MedicationRequest NoACEIOrARBOrARNIOrdered)
        {
            Code<MedicationRequest.MedicationrequestStatus> r_ = NoACEIOrARBOrARNIOrdered?.StatusElement;
            MedicationRequest.MedicationrequestStatus? s_ = r_?.Value;
            string t_ = context.Operators.Convert<string>(s_);
            bool? u_ = context.Operators.Equal(t_, "completed");
            Code<MedicationRequest.MedicationRequestIntent> v_ = NoACEIOrARBOrARNIOrdered?.IntentElement;
            MedicationRequest.MedicationRequestIntent? w_ = v_?.Value;
            string x_ = context.Operators.Convert<string>(w_);
            string[] y_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? z_ = context.Operators.In<string>(x_, y_ as IEnumerable<string>);
            bool? aa_ = context.Operators.And(u_, z_);
            List<CodeableConcept> ab_ = NoACEIOrARBOrARNIOrdered?.ReasonCode;
            CqlConcept ac_(CodeableConcept @this)
            {
                CqlConcept at_ = FHIRHelpers_minus_4_4_000.Instance.ToConcept(context, @this);

                return at_;
            };
            IEnumerable<CqlConcept> ad_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ab_, ac_);
            CqlValueSet ae_ = this.Medical_Reason(context);
            bool? af_ = context.Operators.ConceptsInValueSet(ad_, ae_);
            CqlConcept ah_(CodeableConcept @this)
            {
                CqlConcept au_ = FHIRHelpers_minus_4_4_000.Instance.ToConcept(context, @this);

                return au_;
            };
            IEnumerable<CqlConcept> ai_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ab_, ah_);
            CqlValueSet aj_ = this.Patient_Reason(context);
            bool? ak_ = context.Operators.ConceptsInValueSet(ai_, aj_);
            bool? al_ = context.Operators.Or(af_, ak_);
            CqlConcept an_(CodeableConcept @this)
            {
                CqlConcept av_ = FHIRHelpers_minus_4_4_000.Instance.ToConcept(context, @this);

                return av_;
            };
            IEnumerable<CqlConcept> ao_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ab_, an_);
            CqlValueSet ap_ = this.Patient_Reason_for_ACE_Inhibitor_or_ARB_Decline(context);
            bool? aq_ = context.Operators.ConceptsInValueSet(ao_, ap_);
            bool? ar_ = context.Operators.Or(al_, aq_);
            bool? as_ = context.Operators.And(aa_, ar_);

            return as_;
        };
        IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
        bool? g_ = context.Operators.Exists<MedicationRequest>(f_);

        return g_;
    }


    #endregion Functions and Expressions

}
