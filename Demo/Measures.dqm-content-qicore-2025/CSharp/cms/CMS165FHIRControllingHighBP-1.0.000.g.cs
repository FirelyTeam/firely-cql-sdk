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
[CqlLibrary("CMS165FHIRControllingHighBP", "1.0.000")]
public partial class CMS165FHIRControllingHighBP_1_0_000 : ILibrary, ISingleton<CMS165FHIRControllingHighBP_1_0_000>
{
    #region ValueSets (10)

    [CqlValueSetDefinition("Chronic Kidney Disease, Stage 5", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1002", valueSetVersion: null)]
    public CqlValueSet Chronic_Kidney_Disease__Stage_5(CqlContext _) => _Chronic_Kidney_Disease__Stage_5;
    private static readonly CqlValueSet _Chronic_Kidney_Disease__Stage_5 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1002", null);

    [CqlValueSetDefinition("Dialysis Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1013", valueSetVersion: null)]
    public CqlValueSet Dialysis_Services(CqlContext _) => _Dialysis_Services;
    private static readonly CqlValueSet _Dialysis_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1013", null);

    [CqlValueSetDefinition("Emergency Department Evaluation and Management Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Evaluation_and_Management_Visit(CqlContext _) => _Emergency_Department_Evaluation_and_Management_Visit;
    private static readonly CqlValueSet _Emergency_Department_Evaluation_and_Management_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("End Stage Renal Disease", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353", valueSetVersion: null)]
    public CqlValueSet End_Stage_Renal_Disease(CqlContext _) => _End_Stage_Renal_Disease;
    private static readonly CqlValueSet _End_Stage_Renal_Disease = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353", null);

    [CqlValueSetDefinition("ESRD Monthly Outpatient Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1014", valueSetVersion: null)]
    public CqlValueSet ESRD_Monthly_Outpatient_Services(CqlContext _) => _ESRD_Monthly_Outpatient_Services;
    private static readonly CqlValueSet _ESRD_Monthly_Outpatient_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1014", null);

    [CqlValueSetDefinition("Essential Hypertension", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.104.12.1011", valueSetVersion: null)]
    public CqlValueSet Essential_Hypertension(CqlContext _) => _Essential_Hypertension;
    private static readonly CqlValueSet _Essential_Hypertension = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.104.12.1011", null);

    [CqlValueSetDefinition("Kidney Transplant", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1012", valueSetVersion: null)]
    public CqlValueSet Kidney_Transplant(CqlContext _) => _Kidney_Transplant;
    private static readonly CqlValueSet _Kidney_Transplant = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1012", null);

    [CqlValueSetDefinition("Kidney Transplant Recipient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1029", valueSetVersion: null)]
    public CqlValueSet Kidney_Transplant_Recipient(CqlContext _) => _Kidney_Transplant_Recipient;
    private static readonly CqlValueSet _Kidney_Transplant_Recipient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1029", null);

    [CqlValueSetDefinition("Pregnancy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.378", valueSetVersion: null)]
    public CqlValueSet Pregnancy(CqlContext _) => _Pregnancy;
    private static readonly CqlValueSet _Pregnancy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.378", null);

    #endregion ValueSets

    #region Codes (2)

    [CqlCodeDefinition("Diastolic blood pressure", codeId: "8462-4", codeSystem: "http://loinc.org")]
    public CqlCode Diastolic_blood_pressure(CqlContext _) => _Diastolic_blood_pressure;
    private static readonly CqlCode _Diastolic_blood_pressure = new CqlCode("8462-4", "http://loinc.org");

    [CqlCodeDefinition("Systolic blood pressure", codeId: "8480-6", codeSystem: "http://loinc.org")]
    public CqlCode Systolic_blood_pressure(CqlContext _) => _Systolic_blood_pressure;
    private static readonly CqlCode _Systolic_blood_pressure = new CqlCode("8480-6", "http://loinc.org");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Diastolic_blood_pressure,
          _Systolic_blood_pressure]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 2868529862524195936L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS165FHIRControllingHighBP-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (21)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 6112448456681977422L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Essential Hypertension Diagnosis")]
    public IEnumerable<object> Essential_Hypertension_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Essential_Hypertension_Diagnosis, Essential_Hypertension_Diagnosis_Compute);

    private const long _cacheIndex_Essential_Hypertension_Diagnosis = -2787967750483016207L;

    private IEnumerable<object> Essential_Hypertension_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Essential_Hypertension(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
        IEnumerable<object> f_ = Status_1_15_000.Instance.verified(context, e_);

        bool? g_(object Hypertension) {
            CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, Hypertension);
            CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
            CqlDateTime k_ = context.Operators.Start(j_);
            CqlDateTime m_ = context.Operators.Start(j_);
            CqlQuantity n_ = context.Operators.Quantity(6m, "months");
            CqlDateTime o_ = context.Operators.Add(m_, n_);
            CqlInterval<CqlDateTime> p_ = context.Operators.Interval(k_, o_, true, false);
            bool? q_ = context.Operators.Overlaps(i_, p_, (string)default);
            return q_;
        }

        IEnumerable<object> h_ = context.Operators.Where<object>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 8113727830882407662L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.End(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?> i_ = context.Operators.Interval(18, 85, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, (string)default);
        IEnumerable<object> k_ = this.Essential_Hypertension_Diagnosis(context);
        bool? l_ = context.Operators.Exists<object>(k_);
        bool? m_ = context.Operators.And(j_, l_);
        IEnumerable<Encounter> n_ = AdultOutpatientEncounters_4_19_000.Instance.Qualifying_Encounters(context);
        bool? o_ = context.Operators.Exists<Encounter>(n_);
        bool? p_ = context.Operators.And(m_, o_);
        return p_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 6479199307429863337L;

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Pregnancy or Renal Diagnosis")]
    public IEnumerable<object> Pregnancy_or_Renal_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Pregnancy_or_Renal_Diagnosis, Pregnancy_or_Renal_Diagnosis_Compute);

    private const long _cacheIndex_Pregnancy_or_Renal_Diagnosis = 4765202894533631670L;

    private IEnumerable<object> Pregnancy_or_Renal_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Pregnancy(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
        CqlValueSet f_ = this.End_Stage_Renal_Disease(context);
        IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<object> h_ = context.Operators.Union<object>(e_ as IEnumerable<object>, g_ as IEnumerable<object>);
        IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<object> k_ = context.Operators.Union<object>(h_ as IEnumerable<object>, j_ as IEnumerable<object>);
        CqlValueSet l_ = this.Kidney_Transplant_Recipient(context);
        IEnumerable<Condition> m_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<object> n_ = context.Operators.Union<object>(k_ as IEnumerable<object>, m_ as IEnumerable<object>);
        IEnumerable<Condition> p_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<object> q_ = context.Operators.Union<object>(n_ as IEnumerable<object>, p_ as IEnumerable<object>);
        CqlValueSet r_ = this.Chronic_Kidney_Disease__Stage_5(context);
        IEnumerable<Condition> s_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<object> t_ = context.Operators.Union<object>(q_ as IEnumerable<object>, s_ as IEnumerable<object>);
        IEnumerable<Condition> v_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<object> w_ = context.Operators.Union<object>(t_ as IEnumerable<object>, v_ as IEnumerable<object>);
        IEnumerable<object> x_ = Status_1_15_000.Instance.verified(context, w_);

        bool? y_(object PregnancyESRDDiagnosis) {
            CqlInterval<CqlDateTime> aa_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PregnancyESRDDiagnosis);
            CqlInterval<CqlDateTime> ab_ = this.Measurement_Period(context);
            bool? ac_ = context.Operators.Overlaps(aa_, ab_, (string)default);
            return ac_;
        }

        IEnumerable<object> z_ = context.Operators.Where<object>(x_, y_);
        return z_;
    }


    [CqlExpressionDefinition("End Stage Renal Disease Procedures")]
    public IEnumerable<Procedure> End_Stage_Renal_Disease_Procedures(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_End_Stage_Renal_Disease_Procedures, End_Stage_Renal_Disease_Procedures_Compute);

    private const long _cacheIndex_End_Stage_Renal_Disease_Procedures = 3683699906216537332L;

    private IEnumerable<Procedure> End_Stage_Renal_Disease_Procedures_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Kidney_Transplant(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet c_ = this.Dialysis_Services(context);
        IEnumerable<Procedure> d_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> e_ = context.Operators.Union<Procedure>(b_, d_);
        IEnumerable<Procedure> f_ = Status_1_15_000.Instance.isProcedurePerformed(context, e_);

        bool? g_(Procedure ESRDProcedure) {

            object i_() {

                bool o_() {
                    DataType s_ = ESRDProcedure?.Performed;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlDateTime;
                    return u_;
                }


                bool p_() {
                    DataType v_ = ESRDProcedure?.Performed;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlInterval<CqlDateTime>;
                    return x_;
                }


                bool q_() {
                    DataType y_ = ESRDProcedure?.Performed;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlQuantity;
                    return aa_;
                }


                bool r_() {
                    DataType ab_ = ESRDProcedure?.Performed;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlInterval<CqlQuantity>;
                    return ad_;
                }

                if (o_())
                {
                    DataType ae_ = ESRDProcedure?.Performed;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    return (af_ as CqlDateTime) as object;
                }
                else if (p_())
                {
                    DataType ag_ = ESRDProcedure?.Performed;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    return (ah_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (q_())
                {
                    DataType ai_ = ESRDProcedure?.Performed;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    return (aj_ as CqlQuantity) as object;
                }
                else if (r_())
                {
                    DataType ak_ = ESRDProcedure?.Performed;
                    object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                    return (al_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.toInterval(context, i_());
            CqlDateTime k_ = context.Operators.End(j_);
            CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
            CqlDateTime m_ = context.Operators.End(l_);
            bool? n_ = context.Operators.SameOrBefore(k_, m_, (string)default);
            return n_;
        }

        IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("End Stage Renal Disease Encounter")]
    public IEnumerable<Encounter> End_Stage_Renal_Disease_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_End_Stage_Renal_Disease_Encounter, End_Stage_Renal_Disease_Encounter_Compute);

    private const long _cacheIndex_End_Stage_Renal_Disease_Encounter = 4726818240219101239L;

    private IEnumerable<Encounter> End_Stage_Renal_Disease_Encounter_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.ESRD_Monthly_Outpatient_Services(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> c_ = Status_1_15_000.Instance.isEncounterPerformed(context, b_);

        bool? d_(Encounter ESRDEncounter) {
            Period f_ = ESRDEncounter?.Period;
            CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, f_);
            CqlDateTime h_ = context.Operators.Start(g_);
            CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
            CqlDateTime j_ = context.Operators.End(i_);
            bool? k_ = context.Operators.SameOrBefore(h_, j_, (string)default);
            return k_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = -4301715289763151594L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        bool? a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
        IEnumerable<object> b_ = this.Pregnancy_or_Renal_Diagnosis(context);
        bool? c_ = context.Operators.Exists<object>(b_);
        bool? d_ = context.Operators.Or(a_, c_);
        IEnumerable<Procedure> e_ = this.End_Stage_Renal_Disease_Procedures(context);
        bool? f_ = context.Operators.Exists<Procedure>(e_);
        bool? g_ = context.Operators.Or(d_, f_);
        IEnumerable<Encounter> h_ = this.End_Stage_Renal_Disease_Encounter(context);
        bool? i_ = context.Operators.Exists<Encounter>(h_);
        bool? j_ = context.Operators.Or(g_, i_);
        bool? k_ = AdvancedIllnessandFrailty_1_27_000.Instance.Is_Age_66_to_80_with_Advanced_Illness_and_Frailty_or_Is_Age_81_or_Older_with_Frailty(context);
        bool? l_ = context.Operators.Or(j_, k_);
        bool? m_ = AdvancedIllnessandFrailty_1_27_000.Instance.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(context);
        bool? n_ = context.Operators.Or(l_, m_);
        bool? o_ = PalliativeCare_1_18_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? p_ = context.Operators.Or(n_, o_);
        return p_;
    }


    [CqlFunctionDefinition("getEncounter")]
    public Encounter getEncounter(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Encounter> a_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? b_(Encounter E) {
            Id e_ = E?.IdElement;
            string f_ = e_?.Value;
            FhirString g_ = reference?.ReferenceElement;
            string h_ = g_?.Value;
            string i_ = QICoreCommon_4_0_000.Instance.getId(context, h_);
            bool? j_ = context.Operators.Equal(f_, i_);
            return j_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        Encounter d_ = context.Operators.SingletonFrom<Encounter>(c_);
        return d_;
    }


    [CqlExpressionDefinition("Qualifying Blood Pressure Reading")]
    public IEnumerable<Observation> Qualifying_Blood_Pressure_Reading(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Blood_Pressure_Reading, Qualifying_Blood_Pressure_Reading_Compute);

    private const long _cacheIndex_Qualifying_Blood_Pressure_Reading = -8682094712061780687L;

    private IEnumerable<Observation> Qualifying_Blood_Pressure_Reading_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));
        IEnumerable<Observation> b_ = Status_1_15_000.Instance.isObservationBP(context, a_);
        IEnumerable<Observation> d_ = Status_1_15_000.Instance.isObservationBP(context, a_);

        IEnumerable<Observation> e_(Observation BloodPressure) {
            CqlValueSet o_ = this.Encounter_Inpatient(context);
            IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            CqlValueSet q_ = this.Emergency_Department_Evaluation_and_Management_Visit(context);
            IEnumerable<Encounter> r_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, q_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> s_ = context.Operators.Union<Encounter>(p_, r_);
            IEnumerable<Encounter> t_ = Status_1_15_000.Instance.isEncounterPerformed(context, s_);

            bool? u_(Encounter DisqualifyingEncounter) {
                DataType y_ = BloodPressure?.Effective;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                CqlDateTime aa_ = QICoreCommon_4_0_000.Instance.latest(context, z_);
                Period ab_ = DisqualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ab_);
                bool? ad_ = context.Operators.In<CqlDateTime>(aa_, ac_, "day");
                return ad_;
            }

            IEnumerable<Encounter> v_ = context.Operators.Where<Encounter>(t_, u_);
            Observation w_(Encounter DisqualifyingEncounter) => BloodPressure;
            IEnumerable<Observation> x_ = context.Operators.Select<Encounter, Observation>(v_, w_);
            return x_;
        }

        IEnumerable<Observation> f_ = context.Operators.SelectMany<Observation, Observation>(d_, e_);
        IEnumerable<Observation> g_ = context.Operators.Except<Observation>(b_, f_);

        bool? h_(Observation BloodPressure) {
            DataType ae_ = BloodPressure?.Effective;
            object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
            CqlDateTime ag_ = QICoreCommon_4_0_000.Instance.latest(context, af_);
            CqlInterval<CqlDateTime> ah_ = this.Measurement_Period(context);
            bool? ai_ = context.Operators.In<CqlDateTime>(ag_, ah_, "day");
            return ai_;
        }

        IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
        IEnumerable<Observation> k_ = Status_1_15_000.Instance.isObservationBP(context, a_);

        bool? l_(Observation BloodPressure) {
            ResourceReference aj_ = BloodPressure?.Encounter;
            Encounter ak_ = this.getEncounter(context, aj_);
            Coding al_ = ak_?.Class;
            CqlCode am_ = FHIRHelpers_4_4_000.Instance.ToCode(context, al_);
            string an_ = am_?.code;
            string[] ao_ = [
                "EMER",
                "IMP",
                "ACUTE",
                "NONAC",
                "PRENC",
                "SS",
            ];
            bool? ap_ = context.Operators.In<string>(an_, (IEnumerable<string>)ao_);
            bool? aq_ = context.Operators.Not(ap_);
            DataType ar_ = BloodPressure?.Effective;
            object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
            CqlDateTime at_ = QICoreCommon_4_0_000.Instance.latest(context, as_);
            CqlInterval<CqlDateTime> au_ = this.Measurement_Period(context);
            bool? av_ = context.Operators.In<CqlDateTime>(at_, au_, "day");
            bool? aw_ = context.Operators.And(aq_, av_);
            return aw_;
        }

        IEnumerable<Observation> m_ = context.Operators.Where<Observation>(k_, l_);
        IEnumerable<Observation> n_ = context.Operators.Union<Observation>(i_, m_);
        return n_;
    }


    [CqlExpressionDefinition("Blood Pressure Days")]
    public IEnumerable<CqlDate> Blood_Pressure_Days(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Blood_Pressure_Days, Blood_Pressure_Days_Compute);

    private const long _cacheIndex_Blood_Pressure_Days = -7659304312371477324L;

    private IEnumerable<CqlDate> Blood_Pressure_Days_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Qualifying_Blood_Pressure_Reading(context);

        CqlDate b_(Observation BPExam) {
            DataType e_ = BPExam?.Effective;
            object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
            CqlDateTime g_ = QICoreCommon_4_0_000.Instance.latest(context, f_);
            CqlDate h_ = context.Operators.DateFrom(g_);
            return h_;
        }

        IEnumerable<CqlDate> c_ = context.Operators.Select<Observation, CqlDate>(a_, b_);
        IEnumerable<CqlDate> d_ = context.Operators.Distinct<CqlDate>(c_);
        return d_;
    }


    [CqlExpressionDefinition("Most Recent Blood Pressure Day")]
    public CqlDate Most_Recent_Blood_Pressure_Day(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Most_Recent_Blood_Pressure_Day, Most_Recent_Blood_Pressure_Day_Compute);

    private const long _cacheIndex_Most_Recent_Blood_Pressure_Day = 4534147842878071812L;

    private CqlDate Most_Recent_Blood_Pressure_Day_Compute(CqlContext context)
    {
        IEnumerable<CqlDate> a_ = this.Blood_Pressure_Days(context);
        IEnumerable<CqlDate> b_ = context.Operators.ListSort<CqlDate>(a_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDate c_ = context.Operators.Last<CqlDate>(b_);
        return c_;
    }


    [CqlExpressionDefinition("Lowest Systolic Reading on Most Recent Blood Pressure Day")]
    public CqlQuantity Lowest_Systolic_Reading_on_Most_Recent_Blood_Pressure_Day(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Lowest_Systolic_Reading_on_Most_Recent_Blood_Pressure_Day, Lowest_Systolic_Reading_on_Most_Recent_Blood_Pressure_Day_Compute);

    private const long _cacheIndex_Lowest_Systolic_Reading_on_Most_Recent_Blood_Pressure_Day = -6268987121419031654L;

    private CqlQuantity Lowest_Systolic_Reading_on_Most_Recent_Blood_Pressure_Day_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Qualifying_Blood_Pressure_Reading(context);

        bool? b_(Observation BPReading) {
            DataType i_ = BPReading?.Effective;
            object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
            CqlDateTime k_ = QICoreCommon_4_0_000.Instance.latest(context, j_);
            CqlDate l_ = this.Most_Recent_Blood_Pressure_Day(context);
            CqlDateTime m_ = context.Operators.ConvertDateToDateTime(l_);
            bool? n_ = context.Operators.SameAs(k_, m_, "day");
            return n_;
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        CqlQuantity d_(Observation BPReading) {
            List<Observation.ComponentComponent> o_ = BPReading?.Component;

            bool? p_(Observation.ComponentComponent BPComponent) {
                CodeableConcept v_ = BPComponent?.Code;
                CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                CqlCode x_ = this.Systolic_blood_pressure(context);
                CqlConcept y_ = context.Operators.ConvertCodeToConcept(x_);
                bool? z_ = context.Operators.Equivalent(w_, y_);
                return z_;
            }

            IEnumerable<Observation.ComponentComponent> q_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)o_, p_);

            CqlQuantity r_(Observation.ComponentComponent BPComponent) {
                DataType aa_ = BPComponent?.Value;
                object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                return ab_ as CqlQuantity;
            }

            IEnumerable<CqlQuantity> s_ = context.Operators.Select<Observation.ComponentComponent, CqlQuantity>(q_, r_);
            IEnumerable<CqlQuantity> t_ = context.Operators.Distinct<CqlQuantity>(s_);
            CqlQuantity u_ = context.Operators.SingletonFrom<CqlQuantity>(t_);
            return u_;
        }

        IEnumerable<CqlQuantity> e_ = context.Operators.Select<Observation, CqlQuantity>(c_, d_);
        IEnumerable<CqlQuantity> f_ = context.Operators.Distinct<CqlQuantity>(e_);
        IEnumerable<CqlQuantity> g_ = context.Operators.ListSort<CqlQuantity>(f_, System.ComponentModel.ListSortDirection.Ascending);
        CqlQuantity h_ = context.Operators.First<CqlQuantity>(g_);
        return h_;
    }


    [CqlExpressionDefinition("Has Systolic Blood Pressure Less Than 140")]
    public bool? Has_Systolic_Blood_Pressure_Less_Than_140(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Systolic_Blood_Pressure_Less_Than_140, Has_Systolic_Blood_Pressure_Less_Than_140_Compute);

    private const long _cacheIndex_Has_Systolic_Blood_Pressure_Less_Than_140 = 1921186777350050006L;

    private bool? Has_Systolic_Blood_Pressure_Less_Than_140_Compute(CqlContext context)
    {
        CqlQuantity a_ = this.Lowest_Systolic_Reading_on_Most_Recent_Blood_Pressure_Day(context);
        CqlQuantity b_ = context.Operators.Quantity(140m, "mm[Hg]");
        bool? c_ = context.Operators.Less(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Lowest Diastolic Reading on Most Recent Blood Pressure Day")]
    public CqlQuantity Lowest_Diastolic_Reading_on_Most_Recent_Blood_Pressure_Day(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Lowest_Diastolic_Reading_on_Most_Recent_Blood_Pressure_Day, Lowest_Diastolic_Reading_on_Most_Recent_Blood_Pressure_Day_Compute);

    private const long _cacheIndex_Lowest_Diastolic_Reading_on_Most_Recent_Blood_Pressure_Day = -3841442510623089316L;

    private CqlQuantity Lowest_Diastolic_Reading_on_Most_Recent_Blood_Pressure_Day_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Qualifying_Blood_Pressure_Reading(context);

        bool? b_(Observation BPReading) {
            DataType i_ = BPReading?.Effective;
            object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
            CqlDateTime k_ = QICoreCommon_4_0_000.Instance.latest(context, j_);
            CqlDate l_ = this.Most_Recent_Blood_Pressure_Day(context);
            CqlDateTime m_ = context.Operators.ConvertDateToDateTime(l_);
            bool? n_ = context.Operators.SameAs(k_, m_, "day");
            return n_;
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        CqlQuantity d_(Observation BPReading) {
            List<Observation.ComponentComponent> o_ = BPReading?.Component;

            bool? p_(Observation.ComponentComponent BPComponent) {
                CodeableConcept v_ = BPComponent?.Code;
                CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                CqlCode x_ = this.Diastolic_blood_pressure(context);
                CqlConcept y_ = context.Operators.ConvertCodeToConcept(x_);
                bool? z_ = context.Operators.Equivalent(w_, y_);
                return z_;
            }

            IEnumerable<Observation.ComponentComponent> q_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)o_, p_);

            CqlQuantity r_(Observation.ComponentComponent BPComponent) {
                DataType aa_ = BPComponent?.Value;
                object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                return ab_ as CqlQuantity;
            }

            IEnumerable<CqlQuantity> s_ = context.Operators.Select<Observation.ComponentComponent, CqlQuantity>(q_, r_);
            IEnumerable<CqlQuantity> t_ = context.Operators.Distinct<CqlQuantity>(s_);
            CqlQuantity u_ = context.Operators.SingletonFrom<CqlQuantity>(t_);
            return u_;
        }

        IEnumerable<CqlQuantity> e_ = context.Operators.Select<Observation, CqlQuantity>(c_, d_);
        IEnumerable<CqlQuantity> f_ = context.Operators.Distinct<CqlQuantity>(e_);
        IEnumerable<CqlQuantity> g_ = context.Operators.ListSort<CqlQuantity>(f_, System.ComponentModel.ListSortDirection.Ascending);
        CqlQuantity h_ = context.Operators.First<CqlQuantity>(g_);
        return h_;
    }


    [CqlExpressionDefinition("Has Diastolic Blood Pressure Less Than 90")]
    public bool? Has_Diastolic_Blood_Pressure_Less_Than_90(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Diastolic_Blood_Pressure_Less_Than_90, Has_Diastolic_Blood_Pressure_Less_Than_90_Compute);

    private const long _cacheIndex_Has_Diastolic_Blood_Pressure_Less_Than_90 = 6962517168965446750L;

    private bool? Has_Diastolic_Blood_Pressure_Less_Than_90_Compute(CqlContext context)
    {
        CqlQuantity a_ = this.Lowest_Diastolic_Reading_on_Most_Recent_Blood_Pressure_Day(context);
        CqlQuantity b_ = context.Operators.Quantity(90m, "mm[Hg]");
        bool? c_ = context.Operators.Less(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 7136638974270185813L;

    private bool? Numerator_Compute(CqlContext context)
    {
        bool? a_ = this.Has_Systolic_Blood_Pressure_Less_Than_140(context);
        bool? b_ = this.Has_Diastolic_Blood_Pressure_Less_Than_90(context);
        bool? c_ = context.Operators.And(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 5921252105043752311L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 5350607861850346144L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -4146332498096444483L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 5891651533490106217L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS165FHIRControllingHighBP_1_0_000() {}

    public static CMS165FHIRControllingHighBP_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS165FHIRControllingHighBP";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance, Status_1_15_000.Instance, AdvancedIllnessandFrailty_1_27_000.Instance, AdultOutpatientEncounters_4_19_000.Instance, Hospice_6_18_000.Instance, PalliativeCare_1_18_000.Instance];

    #endregion ILibrary Implementation

}
