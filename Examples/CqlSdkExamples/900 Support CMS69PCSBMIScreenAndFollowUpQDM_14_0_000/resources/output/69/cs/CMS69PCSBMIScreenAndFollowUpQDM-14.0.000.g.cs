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
using TestConsoleAppFhir.resources.output;

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.1.0.0")]
[CqlLibrary("CMS69PCSBMIScreenAndFollowUpQDM", "14.0.000")]
public partial class CMS69PCSBMIScreenAndFollowUpQDM_14_0_000 : ILibrary, ISingleton<CMS69PCSBMIScreenAndFollowUpQDM_14_0_000>
{
    private CMS69PCSBMIScreenAndFollowUpQDM_14_0_000() {}

    public static CMS69PCSBMIScreenAndFollowUpQDM_14_0_000 Instance { get; } = new();

    #region ILibrary Implementation

public string Name => "CMS69PCSBMIScreenAndFollowUpQDM";
public string Version => "14.0.000";
    public ILibrary[] Dependencies => [CQMCommonQDM_9_0_000.Instance, HospiceQDM_7_0_000.Instance, PalliativeCareQDM_5_0_000.Instance];

#endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Federal Administrative Sex", valueSetId: "urn:oid:2.16.840.1.113762.1.4.1021.121", valueSetVersion: null)]
public CqlValueSet Federal_Administrative_Sex(CqlContext _) => _Federal_Administrative_Sex;
private static readonly CqlValueSet _Federal_Administrative_Sex = new CqlValueSet("urn:oid:2.16.840.1.113762.1.4.1021.121", null);

    [CqlValueSetDefinition("Encounter to Evaluate BMI", valueSetId: "urn:oid:2.16.840.1.113883.3.600.1.1751", valueSetVersion: null)]
public CqlValueSet Encounter_to_Evaluate_BMI(CqlContext _) => _Encounter_to_Evaluate_BMI;
private static readonly CqlValueSet _Encounter_to_Evaluate_BMI = new CqlValueSet("urn:oid:2.16.840.1.113883.3.600.1.1751", null);

    [CqlValueSetDefinition("Ethnicity", valueSetId: "urn:oid:2.16.840.1.114222.4.11.837", valueSetVersion: null)]
public CqlValueSet Ethnicity(CqlContext _) => _Ethnicity;
private static readonly CqlValueSet _Ethnicity = new CqlValueSet("urn:oid:2.16.840.1.114222.4.11.837", null);

    [CqlValueSetDefinition("Follow Up for Above Normal BMI", valueSetId: "urn:oid:2.16.840.1.113883.3.600.1.1525", valueSetVersion: null)]
public CqlValueSet Follow_Up_for_Above_Normal_BMI(CqlContext _) => _Follow_Up_for_Above_Normal_BMI;
private static readonly CqlValueSet _Follow_Up_for_Above_Normal_BMI = new CqlValueSet("urn:oid:2.16.840.1.113883.3.600.1.1525", null);

    [CqlValueSetDefinition("Follow Up for Below Normal BMI", valueSetId: "urn:oid:2.16.840.1.113883.3.600.1.1528", valueSetVersion: null)]
public CqlValueSet Follow_Up_for_Below_Normal_BMI(CqlContext _) => _Follow_Up_for_Below_Normal_BMI;
private static readonly CqlValueSet _Follow_Up_for_Below_Normal_BMI = new CqlValueSet("urn:oid:2.16.840.1.113883.3.600.1.1528", null);

    [CqlValueSetDefinition("Medical Reason", valueSetId: "urn:oid:2.16.840.1.113883.3.526.3.1007", valueSetVersion: null)]
public CqlValueSet Medical_Reason(CqlContext _) => _Medical_Reason;
private static readonly CqlValueSet _Medical_Reason = new CqlValueSet("urn:oid:2.16.840.1.113883.3.526.3.1007", null);

    [CqlValueSetDefinition("Medications for Above Normal BMI", valueSetId: "urn:oid:2.16.840.1.113883.3.526.3.1561", valueSetVersion: null)]
public CqlValueSet Medications_for_Above_Normal_BMI(CqlContext _) => _Medications_for_Above_Normal_BMI;
private static readonly CqlValueSet _Medications_for_Above_Normal_BMI = new CqlValueSet("urn:oid:2.16.840.1.113883.3.526.3.1561", null);

    [CqlValueSetDefinition("Medications for Below Normal BMI", valueSetId: "urn:oid:2.16.840.1.113883.3.526.3.1562", valueSetVersion: null)]
public CqlValueSet Medications_for_Below_Normal_BMI(CqlContext _) => _Medications_for_Below_Normal_BMI;
private static readonly CqlValueSet _Medications_for_Below_Normal_BMI = new CqlValueSet("urn:oid:2.16.840.1.113883.3.526.3.1562", null);

    [CqlValueSetDefinition("Overweight or Obese", valueSetId: "urn:oid:2.16.840.1.113762.1.4.1047.502", valueSetVersion: null)]
public CqlValueSet Overweight_or_Obese(CqlContext _) => _Overweight_or_Obese;
private static readonly CqlValueSet _Overweight_or_Obese = new CqlValueSet("urn:oid:2.16.840.1.113762.1.4.1047.502", null);

    [CqlValueSetDefinition("Patient Declined", valueSetId: "urn:oid:2.16.840.1.113883.3.526.3.1582", valueSetVersion: null)]
public CqlValueSet Patient_Declined(CqlContext _) => _Patient_Declined;
private static readonly CqlValueSet _Patient_Declined = new CqlValueSet("urn:oid:2.16.840.1.113883.3.526.3.1582", null);

    [CqlValueSetDefinition("Payer Type", valueSetId: "urn:oid:2.16.840.1.114222.4.11.3591", valueSetVersion: null)]
public CqlValueSet Payer_Type(CqlContext _) => _Payer_Type;
private static readonly CqlValueSet _Payer_Type = new CqlValueSet("urn:oid:2.16.840.1.114222.4.11.3591", null);

    [CqlValueSetDefinition("Pregnancy", valueSetId: "urn:oid:2.16.840.1.113883.3.526.3.378", valueSetVersion: null)]
public CqlValueSet Pregnancy(CqlContext _) => _Pregnancy;
private static readonly CqlValueSet _Pregnancy = new CqlValueSet("urn:oid:2.16.840.1.113883.3.526.3.378", null);

    [CqlValueSetDefinition("Race", valueSetId: "urn:oid:2.16.840.1.114222.4.11.836", valueSetVersion: null)]
public CqlValueSet Race(CqlContext _) => _Race;
private static readonly CqlValueSet _Race = new CqlValueSet("urn:oid:2.16.840.1.114222.4.11.836", null);

    [CqlValueSetDefinition("Referrals Where Weight Assessment May Occur", valueSetId: "urn:oid:2.16.840.1.113883.3.600.1.1527", valueSetVersion: null)]
public CqlValueSet Referrals_Where_Weight_Assessment_May_Occur(CqlContext _) => _Referrals_Where_Weight_Assessment_May_Occur;
private static readonly CqlValueSet _Referrals_Where_Weight_Assessment_May_Occur = new CqlValueSet("urn:oid:2.16.840.1.113883.3.600.1.1527", null);

    [CqlValueSetDefinition("Underweight", valueSetId: "urn:oid:2.16.840.1.113883.3.526.3.1563", valueSetVersion: null)]
public CqlValueSet Underweight(CqlContext _) => _Underweight;
private static readonly CqlValueSet _Underweight = new CqlValueSet("urn:oid:2.16.840.1.113883.3.526.3.1563", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Body mass index (BMI) [Ratio]", codeId: "39156-5", codeSystem: "urn:oid:2.16.840.1.113883.6.1")]
public CqlCode Body_mass_index__BMI___Ratio_(CqlContext _) => _Body_mass_index__BMI___Ratio_;
private static readonly CqlCode _Body_mass_index__BMI___Ratio_ = new CqlCode("39156-5", "urn:oid:2.16.840.1.113883.6.1");

    [CqlCodeDefinition("virtual", codeId: "VR", codeSystem: "urn:oid:2.16.840.1.113883.5.4")]
public CqlCode @virtual(CqlContext _) => _virtual;
private static readonly CqlCode _virtual = new CqlCode("VR", "urn:oid:2.16.840.1.113883.5.4");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "urn:oid:2.16.840.1.113883.6.1", codeSystemVersion: null)]
public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
private static readonly CqlCodeSystem _LOINC =
  new CqlCodeSystem("urn:oid:2.16.840.1.113883.6.1", null, [
      _Body_mass_index__BMI___Ratio_]);

    [CqlCodeSystemDefinition("ActCode", codeSystemId: "urn:oid:2.16.840.1.113883.5.4", codeSystemVersion: null)]
public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
private static readonly CqlCodeSystem _ActCode =
  new CqlCodeSystem("urn:oid:2.16.840.1.113883.5.4", null, [
      _virtual]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object a_ = context.ResolveParameter("CMS69PCSBMIScreenAndFollowUpQDM-14.0.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public PatientDetails Patient(CqlContext context)
    {
        IEnumerable<PatientDetails> a_ = context.Operators.Retrieve<PatientDetails>(new RetrieveParameters(default, default, default, "Patient"));
        PatientDetails b_ = context.Operators.SingletonFrom<PatientDetails>(a_);

        return b_;
    }


    [CqlExpressionDefinition("Qualifying Encounter During Day Of Measurement Period")]
    public IEnumerable<PositiveEncounterPerformed> Qualifying_Encounter_During_Day_Of_Measurement_Period(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_to_Evaluate_BMI(context);
        IEnumerable<PositiveEncounterPerformed> b_ = context.Operators.Retrieve<PositiveEncounterPerformed>(new RetrieveParameters(default, a_, default, "PositiveEncounterPerformed"));
        bool? c_(PositiveEncounterPerformed BMIEncounter)
        {
            CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
            CqlInterval<CqlDateTime> f_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(BMIEncounter, "relevantPeriod");
            bool? g_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, f_, "day");
            CqlCode h_ = context.Operators.LateBoundProperty<CqlCode>(BMIEncounter, "class");
            CqlCode i_ = this.@virtual(context);
            bool? j_ = context.Operators.Equivalent(h_, i_);
            bool? k_ = context.Operators.Not(j_);
            bool? l_ = context.Operators.And(g_, k_);

            return l_;
        };
        IEnumerable<PositiveEncounterPerformed> d_ = context.Operators.Where<PositiveEncounterPerformed>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        IEnumerable<PositiveEncounterPerformed> a_ = this.Qualifying_Encounter_During_Day_Of_Measurement_Period(context);
        bool? b_(PositiveEncounterPerformed QualifyingEncounter)
        {
            PatientDetails e_ = this.Patient(context);
            object f_ = context.Operators.LateBoundProperty<object>(e_, "birthDatetime");
            CqlInterval<CqlDateTime> g_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(QualifyingEncounter, "relevantPeriod");
            CqlDateTime h_ = context.Operators.Start(g_);
            CqlDate i_ = context.Operators.DateFrom(h_);
            int? j_ = context.Operators.CalculateAgeAt((CqlDate)f_, i_, "year");
            bool? k_ = context.Operators.GreaterOrEqual(j_, 18);

            return k_;
        };
        IEnumerable<PositiveEncounterPerformed> c_ = context.Operators.Where<PositiveEncounterPerformed>(a_, b_);
        bool? d_ = context.Operators.Exists<PositiveEncounterPerformed>(c_);

        return d_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlExpressionDefinition("Medical Reason For Not Documenting A Follow Up Plan For Low Or High BMI")]
    public IEnumerable<object> Medical_Reason_For_Not_Documenting_A_Follow_Up_Plan_For_Low_Or_High_BMI(CqlContext context)
    {
        CqlValueSet a_ = this.Referrals_Where_Weight_Assessment_May_Occur(context);
        IEnumerable<NegativeInterventionOrder> b_ = context.Operators.Retrieve<NegativeInterventionOrder>(new RetrieveParameters(default, a_, default, "NegativeInterventionOrder"));
        CqlValueSet c_ = this.Follow_Up_for_Above_Normal_BMI(context);
        IEnumerable<NegativeInterventionOrder> d_ = context.Operators.Retrieve<NegativeInterventionOrder>(new RetrieveParameters(default, c_, default, "NegativeInterventionOrder"));
        IEnumerable<NegativeInterventionOrder> e_ = context.Operators.Union<NegativeInterventionOrder>(b_, d_);
        IEnumerable<NegativeInterventionPerformed> g_ = context.Operators.Retrieve<NegativeInterventionPerformed>(new RetrieveParameters(default, c_, default, "NegativeInterventionPerformed"));
        IEnumerable<object> h_ = context.Operators.Union<object>(e_ as IEnumerable<object>, g_ as IEnumerable<object>);
        CqlValueSet i_ = this.Follow_Up_for_Below_Normal_BMI(context);
        IEnumerable<NegativeInterventionOrder> j_ = context.Operators.Retrieve<NegativeInterventionOrder>(new RetrieveParameters(default, i_, default, "NegativeInterventionOrder"));
        IEnumerable<object> k_ = context.Operators.Union<object>(h_ as IEnumerable<object>, j_ as IEnumerable<object>);
        IEnumerable<NegativeInterventionPerformed> m_ = context.Operators.Retrieve<NegativeInterventionPerformed>(new RetrieveParameters(default, i_, default, "NegativeInterventionPerformed"));
        IEnumerable<object> n_ = context.Operators.Union<object>(k_ as IEnumerable<object>, m_ as IEnumerable<object>);
        CqlValueSet o_ = this.Medications_for_Above_Normal_BMI(context);
        IEnumerable<NegativeMedicationOrder> p_ = context.Operators.Retrieve<NegativeMedicationOrder>(new RetrieveParameters(default, o_, default, "NegativeMedicationOrder"));
        IEnumerable<object> q_ = context.Operators.Union<object>(n_ as IEnumerable<object>, p_ as IEnumerable<object>);
        CqlValueSet r_ = this.Medications_for_Below_Normal_BMI(context);
        IEnumerable<NegativeMedicationOrder> s_ = context.Operators.Retrieve<NegativeMedicationOrder>(new RetrieveParameters(default, r_, default, "NegativeMedicationOrder"));
        IEnumerable<object> t_ = context.Operators.Union<object>(q_ as IEnumerable<object>, s_ as IEnumerable<object>);
        IEnumerable<object> u_(object NoBMIFollowUp)
        {
            IEnumerable<PositiveEncounterPerformed> y_ = this.Qualifying_Encounter_During_Day_Of_Measurement_Period(context);
            bool? z_(PositiveEncounterPerformed QualifyingEncounter)
            {
                CqlDateTime ad_ = context.Operators.LateBoundProperty<CqlDateTime>(NoBMIFollowUp, "authorDatetime");
                CqlInterval<CqlDateTime> ae_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(QualifyingEncounter, "relevantPeriod");
                CqlDateTime af_ = context.Operators.Start(ae_);
                bool? ag_ = context.Operators.SameAs(ad_, af_, "day");

                return ag_;
            };
            IEnumerable<PositiveEncounterPerformed> aa_ = context.Operators.Where<PositiveEncounterPerformed>(y_, z_);
            object ab_(PositiveEncounterPerformed QualifyingEncounter) =>
                NoBMIFollowUp;
            IEnumerable<object> ac_ = context.Operators.Select<PositiveEncounterPerformed, object>(aa_, ab_);

            return ac_;
        };
        IEnumerable<object> v_ = context.Operators.SelectMany<object, object>(t_, u_);
        bool? w_(object NoBMIFollowUp)
        {
            CqlCode ah_ = context.Operators.LateBoundProperty<CqlCode>(NoBMIFollowUp, "negationRationale");
            CqlValueSet ai_ = this.Medical_Reason(context);
            bool? aj_ = context.Operators.CodeInValueSet(ah_, ai_);

            return aj_;
        };
        IEnumerable<object> x_ = context.Operators.Where<object>(v_, w_);

        return x_;
    }


    [CqlExpressionDefinition("Medical Reason Or Patient Reason For Not Performing BMI Exam")]
    public IEnumerable<NegativePhysicalExamPerformed> Medical_Reason_Or_Patient_Reason_For_Not_Performing_BMI_Exam(CqlContext context)
    {
        CqlCode a_ = this.Body_mass_index__BMI___Ratio_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<NegativePhysicalExamPerformed> c_ = context.Operators.Retrieve<NegativePhysicalExamPerformed>(new RetrieveParameters(default, default, b_, "NegativePhysicalExamPerformed"));
        IEnumerable<NegativePhysicalExamPerformed> d_(NegativePhysicalExamPerformed NoBMI)
        {
            IEnumerable<PositiveEncounterPerformed> h_ = this.Qualifying_Encounter_During_Day_Of_Measurement_Period(context);
            bool? i_(PositiveEncounterPerformed QualifyingEncounter)
            {
                CqlDateTime m_ = context.Operators.LateBoundProperty<CqlDateTime>(NoBMI, "authorDatetime");
                CqlInterval<CqlDateTime> n_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(QualifyingEncounter, "relevantPeriod");
                CqlDateTime o_ = context.Operators.Start(n_);
                bool? p_ = context.Operators.SameAs(m_, o_, "day");

                return p_;
            };
            IEnumerable<PositiveEncounterPerformed> j_ = context.Operators.Where<PositiveEncounterPerformed>(h_, i_);
            NegativePhysicalExamPerformed k_(PositiveEncounterPerformed QualifyingEncounter) =>
                NoBMI;
            IEnumerable<NegativePhysicalExamPerformed> l_ = context.Operators.Select<PositiveEncounterPerformed, NegativePhysicalExamPerformed>(j_, k_);

            return l_;
        };
        IEnumerable<NegativePhysicalExamPerformed> e_ = context.Operators.SelectMany<NegativePhysicalExamPerformed, NegativePhysicalExamPerformed>(c_, d_);
        bool? f_(NegativePhysicalExamPerformed NoBMI)
        {
            CqlCode q_ = context.Operators.LateBoundProperty<CqlCode>(NoBMI, "negationRationale");
            CqlValueSet r_ = this.Medical_Reason(context);
            bool? s_ = context.Operators.CodeInValueSet(q_, r_);
            CqlValueSet u_ = this.Patient_Declined(context);
            bool? v_ = context.Operators.CodeInValueSet(q_, u_);
            bool? w_ = context.Operators.Or(s_, v_);

            return w_;
        };
        IEnumerable<NegativePhysicalExamPerformed> g_ = context.Operators.Where<NegativePhysicalExamPerformed>(e_, f_);

        return g_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<object> a_ = this.Medical_Reason_For_Not_Documenting_A_Follow_Up_Plan_For_Low_Or_High_BMI(context);
        bool? b_ = context.Operators.Exists<object>(a_);
        IEnumerable<NegativePhysicalExamPerformed> c_ = this.Medical_Reason_Or_Patient_Reason_For_Not_Performing_BMI_Exam(context);
        bool? d_ = context.Operators.Exists<NegativePhysicalExamPerformed>(c_);
        bool? e_ = context.Operators.Or(b_, d_);

        return e_;
    }


    [CqlExpressionDefinition("Is Pregnant During Day Of Measurement Period")]
    public bool? Is_Pregnant_During_Day_Of_Measurement_Period(CqlContext context)
    {
        CqlValueSet a_ = this.Pregnancy(context);
        IEnumerable<Diagnosis> b_ = context.Operators.Retrieve<Diagnosis>(new RetrieveParameters(default, a_, default, default));
        IEnumerable<Diagnosis> c_(Diagnosis PregnancyDiagnosis)
        {
            IEnumerable<PositiveEncounterPerformed> f_ = this.Qualifying_Encounter_During_Day_Of_Measurement_Period(context);
            bool? g_(PositiveEncounterPerformed QualifyingEncounter)
            {
                CqlInterval<CqlDateTime> k_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(PregnancyDiagnosis, "prevalencePeriod");
                CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
                bool? m_ = context.Operators.Overlaps(k_, l_, "day");

                return m_;
            };
            IEnumerable<PositiveEncounterPerformed> h_ = context.Operators.Where<PositiveEncounterPerformed>(f_, g_);
            Diagnosis i_(PositiveEncounterPerformed QualifyingEncounter) =>
                PregnancyDiagnosis;
            IEnumerable<Diagnosis> j_ = context.Operators.Select<PositiveEncounterPerformed, Diagnosis>(h_, i_);

            return j_;
        };
        IEnumerable<Diagnosis> d_ = context.Operators.SelectMany<Diagnosis, Diagnosis>(b_, c_);
        bool? e_ = context.Operators.Exists<Diagnosis>(d_);

        return e_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? a_ = HospiceQDM_7_0_000.Instance.Has_Hospice_Services(context);
        bool? b_ = PalliativeCareQDM_5_0_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? c_ = context.Operators.Or(a_, b_);
        bool? d_ = this.Is_Pregnant_During_Day_Of_Measurement_Period(context);
        bool? e_ = context.Operators.Or(c_, d_);

        return e_;
    }


    [CqlExpressionDefinition("BMI During Measurement Period")]
    public IEnumerable<PositivePhysicalExamPerformed> BMI_During_Measurement_Period(CqlContext context)
    {
        CqlCode a_ = this.Body_mass_index__BMI___Ratio_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<PositivePhysicalExamPerformed> c_ = context.Operators.Retrieve<PositivePhysicalExamPerformed>(new RetrieveParameters(default, default, b_, "PositivePhysicalExamPerformed"));
        bool? d_(PositivePhysicalExamPerformed BMI)
        {
            CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
            CqlDateTime g_ = context.Operators.LateBoundProperty<CqlDateTime>(BMI, "relevantDatetime");
            CqlInterval<CqlDateTime> h_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(BMI, "relevantPeriod");
            CqlInterval<CqlDateTime> i_ = CQMCommonQDM_9_0_000.Instance.NormalizeInterval(context, g_, h_);
            bool? j_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, i_, "day");
            object k_ = context.Operators.LateBoundProperty<object>(BMI, "result");
            CqlQuantity l_ = context.Operators.Quantity(0m, "kg/m2");
            bool? m_ = context.Operators.Greater(k_ as CqlQuantity, l_);
            bool? n_ = context.Operators.And(j_, m_);

            return n_;
        };
        IEnumerable<PositivePhysicalExamPerformed> e_ = context.Operators.Where<PositivePhysicalExamPerformed>(c_, d_);

        return e_;
    }


    [CqlExpressionDefinition("Documented High BMI During Measurement Period")]
    public IEnumerable<PositivePhysicalExamPerformed> Documented_High_BMI_During_Measurement_Period(CqlContext context)
    {
        IEnumerable<PositivePhysicalExamPerformed> a_ = this.BMI_During_Measurement_Period(context);
        bool? b_(PositivePhysicalExamPerformed BMI)
        {
            CqlInterval<CqlDateTime> d_ = this.Measurement_Period(context);
            CqlDateTime e_ = context.Operators.LateBoundProperty<CqlDateTime>(BMI, "relevantDatetime");
            CqlInterval<CqlDateTime> f_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(BMI, "relevantPeriod");
            CqlInterval<CqlDateTime> g_ = CQMCommonQDM_9_0_000.Instance.NormalizeInterval(context, e_, f_);
            bool? h_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(d_, g_, "day");
            object i_ = context.Operators.LateBoundProperty<object>(BMI, "result");
            CqlQuantity j_ = context.Operators.Quantity(25m, "kg/m2");
            bool? k_ = context.Operators.GreaterOrEqual(i_ as CqlQuantity, j_);
            bool? l_ = context.Operators.And(h_, k_);

            return l_;
        };
        IEnumerable<PositivePhysicalExamPerformed> c_ = context.Operators.Where<PositivePhysicalExamPerformed>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Documented Low BMI During Measurement Period")]
    public IEnumerable<PositivePhysicalExamPerformed> Documented_Low_BMI_During_Measurement_Period(CqlContext context)
    {
        IEnumerable<PositivePhysicalExamPerformed> a_ = this.BMI_During_Measurement_Period(context);
        bool? b_(PositivePhysicalExamPerformed BMI)
        {
            CqlInterval<CqlDateTime> d_ = this.Measurement_Period(context);
            CqlDateTime e_ = context.Operators.LateBoundProperty<CqlDateTime>(BMI, "relevantDatetime");
            CqlInterval<CqlDateTime> f_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(BMI, "relevantPeriod");
            CqlInterval<CqlDateTime> g_ = CQMCommonQDM_9_0_000.Instance.NormalizeInterval(context, e_, f_);
            bool? h_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(d_, g_, "day");
            object i_ = context.Operators.LateBoundProperty<object>(BMI, "result");
            CqlQuantity j_ = context.Operators.Quantity(18.5m, "kg/m2");
            bool? k_ = context.Operators.Less(i_ as CqlQuantity, j_);
            bool? l_ = context.Operators.And(h_, k_);

            return l_;
        };
        IEnumerable<PositivePhysicalExamPerformed> c_ = context.Operators.Where<PositivePhysicalExamPerformed>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Has Normal BMI")]
    public bool? Has_Normal_BMI(CqlContext context)
    {
        IEnumerable<PositivePhysicalExamPerformed> a_ = this.BMI_During_Measurement_Period(context);
        bool? b_(PositivePhysicalExamPerformed BMI)
        {
            object l_ = context.Operators.LateBoundProperty<object>(BMI, "result");
            CqlQuantity m_ = context.Operators.Quantity(18.5m, "kg/m2");
            bool? n_ = context.Operators.GreaterOrEqual(l_ as CqlQuantity, m_);
            CqlQuantity p_ = context.Operators.Quantity(25m, "kg/m2");
            bool? q_ = context.Operators.Less(l_ as CqlQuantity, p_);
            bool? r_ = context.Operators.And(n_, q_);

            return r_;
        };
        IEnumerable<PositivePhysicalExamPerformed> c_ = context.Operators.Where<PositivePhysicalExamPerformed>(a_, b_);
        bool? d_ = context.Operators.Exists<PositivePhysicalExamPerformed>(c_);
        IEnumerable<PositivePhysicalExamPerformed> e_ = this.Documented_High_BMI_During_Measurement_Period(context);
        bool? f_ = context.Operators.Exists<PositivePhysicalExamPerformed>(e_);
        IEnumerable<PositivePhysicalExamPerformed> g_ = this.Documented_Low_BMI_During_Measurement_Period(context);
        bool? h_ = context.Operators.Exists<PositivePhysicalExamPerformed>(g_);
        bool? i_ = context.Operators.Or(f_, h_);
        bool? j_ = context.Operators.Not(i_);
        bool? k_ = context.Operators.And(d_, j_);

        return k_;
    }


    [CqlExpressionDefinition("High BMI Interventions Ordered")]
    public IEnumerable<object> High_BMI_Interventions_Ordered(CqlContext context)
    {
        CqlValueSet a_ = this.Follow_Up_for_Above_Normal_BMI(context);
        IEnumerable<PositiveInterventionOrder> b_ = context.Operators.Retrieve<PositiveInterventionOrder>(new RetrieveParameters(default, a_, default, "PositiveInterventionOrder"));
        CqlValueSet c_ = this.Referrals_Where_Weight_Assessment_May_Occur(context);
        IEnumerable<PositiveInterventionOrder> d_ = context.Operators.Retrieve<PositiveInterventionOrder>(new RetrieveParameters(default, c_, default, "PositiveInterventionOrder"));
        IEnumerable<PositiveInterventionOrder> e_ = context.Operators.Union<PositiveInterventionOrder>(b_, d_);
        CqlValueSet f_ = this.Medications_for_Above_Normal_BMI(context);
        IEnumerable<PositiveMedicationOrder> g_ = context.Operators.Retrieve<PositiveMedicationOrder>(new RetrieveParameters(default, f_, default, "PositiveMedicationOrder"));
        IEnumerable<object> h_ = context.Operators.Union<object>(e_ as IEnumerable<object>, g_ as IEnumerable<object>);
        bool? i_(object HighInterventionsOrdered)
        {
            CqlCode k_ = context.Operators.LateBoundProperty<CqlCode>(HighInterventionsOrdered, "reason");
            CqlValueSet l_ = this.Overweight_or_Obese(context);
            bool? m_ = context.Operators.CodeInValueSet(k_, l_);
            IEnumerable<Diagnosis> o_ = context.Operators.Retrieve<Diagnosis>(new RetrieveParameters(default, l_, default, default));
            bool? p_(Diagnosis OverweightObese)
            {
                CqlInterval<CqlDateTime> t_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(OverweightObese, "prevalencePeriod");
                CqlDateTime u_ = context.Operators.Start(t_);
                CqlDateTime v_ = context.Operators.LateBoundProperty<CqlDateTime>(HighInterventionsOrdered, "authorDatetime");
                bool? w_ = context.Operators.SameOrBefore(u_, v_, "day");
                CqlDateTime y_ = context.Operators.End(t_);
                bool? aa_ = context.Operators.Before(y_, v_, "day");
                bool? ab_ = context.Operators.Not(aa_);
                bool? ac_ = context.Operators.And(w_, ab_);

                return ac_;
            };
            IEnumerable<Diagnosis> q_ = context.Operators.Where<Diagnosis>(o_, p_);
            bool? r_ = context.Operators.Exists<Diagnosis>(q_);
            bool? s_ = context.Operators.Or(m_, r_);

            return s_;
        };
        IEnumerable<object> j_ = context.Operators.Where<object>(h_, i_);

        return j_;
    }


    [CqlExpressionDefinition("High BMI Interventions Performed")]
    public IEnumerable<PositiveInterventionPerformed> High_BMI_Interventions_Performed(CqlContext context)
    {
        CqlValueSet a_ = this.Follow_Up_for_Above_Normal_BMI(context);
        IEnumerable<PositiveInterventionPerformed> b_ = context.Operators.Retrieve<PositiveInterventionPerformed>(new RetrieveParameters(default, a_, default, "PositiveInterventionPerformed"));
        bool? c_(PositiveInterventionPerformed HighInterventionsPerformed)
        {
            CqlCode e_ = context.Operators.LateBoundProperty<CqlCode>(HighInterventionsPerformed, "reason");
            CqlValueSet f_ = this.Overweight_or_Obese(context);
            bool? g_ = context.Operators.CodeInValueSet(e_, f_);
            IEnumerable<Diagnosis> i_ = context.Operators.Retrieve<Diagnosis>(new RetrieveParameters(default, f_, default, default));
            bool? j_(Diagnosis OverweightObese)
            {
                CqlInterval<CqlDateTime> n_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(OverweightObese, "prevalencePeriod");
                CqlDateTime o_ = context.Operators.Start(n_);
                CqlDateTime p_ = context.Operators.LateBoundProperty<CqlDateTime>(HighInterventionsPerformed, "relevantDatetime");
                CqlInterval<CqlDateTime> q_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(HighInterventionsPerformed, "relevantPeriod");
                CqlInterval<CqlDateTime> r_ = CQMCommonQDM_9_0_000.Instance.NormalizeInterval(context, p_, q_);
                CqlDateTime s_ = context.Operators.Start(r_);
                bool? t_ = context.Operators.SameOrBefore(o_, s_, "day");
                CqlDateTime v_ = context.Operators.End(n_);
                CqlInterval<CqlDateTime> y_ = CQMCommonQDM_9_0_000.Instance.NormalizeInterval(context, p_, q_);
                CqlDateTime z_ = context.Operators.Start(y_);
                bool? aa_ = context.Operators.Before(v_, z_, "day");
                bool? ab_ = context.Operators.Not(aa_);
                bool? ac_ = context.Operators.And(t_, ab_);

                return ac_;
            };
            IEnumerable<Diagnosis> k_ = context.Operators.Where<Diagnosis>(i_, j_);
            bool? l_ = context.Operators.Exists<Diagnosis>(k_);
            bool? m_ = context.Operators.Or(g_, l_);

            return m_;
        };
        IEnumerable<PositiveInterventionPerformed> d_ = context.Operators.Where<PositiveInterventionPerformed>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("High BMI And Follow Up Provided")]
    public IEnumerable<PositivePhysicalExamPerformed> High_BMI_And_Follow_Up_Provided(CqlContext context)
    {
        IEnumerable<PositivePhysicalExamPerformed> a_ = this.Documented_High_BMI_During_Measurement_Period(context);
        IEnumerable<PositivePhysicalExamPerformed> b_(PositivePhysicalExamPerformed HighBMI)
        {
            IEnumerable<object> d_ = this.High_BMI_Interventions_Ordered(context);
            IEnumerable<PositiveInterventionPerformed> e_ = this.High_BMI_Interventions_Performed(context);
            IEnumerable<object> f_ = context.Operators.Union<object>(d_ as IEnumerable<object>, e_ as IEnumerable<object>);
            bool? g_(object HighBMIInterventions)
            {
                CqlDateTime k_ = context.Operators.LateBoundProperty<CqlDateTime>(HighBMIInterventions, "relevantDatetime");
                CqlInterval<CqlDateTime> l_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(HighBMIInterventions, "relevantPeriod");
                CqlInterval<CqlDateTime> m_ = CQMCommonQDM_9_0_000.Instance.NormalizeInterval(context, k_, l_);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlDateTime o_ = context.Operators.LateBoundProperty<CqlDateTime>(HighBMIInterventions, "authorDatetime");
                CqlInterval<CqlDateTime> p_ = this.Measurement_Period(context);
                bool? q_ = context.Operators.In<CqlDateTime>(n_ ?? o_, p_, "day");

                return q_;
            };
            IEnumerable<object> h_ = context.Operators.Where<object>(f_, g_);
            PositivePhysicalExamPerformed i_(object HighBMIInterventions) =>
                HighBMI;
            IEnumerable<PositivePhysicalExamPerformed> j_ = context.Operators.Select<object, PositivePhysicalExamPerformed>(h_, i_);

            return j_;
        };
        IEnumerable<PositivePhysicalExamPerformed> c_ = context.Operators.SelectMany<PositivePhysicalExamPerformed, PositivePhysicalExamPerformed>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Low BMI Interventions Ordered")]
    public IEnumerable<object> Low_BMI_Interventions_Ordered(CqlContext context)
    {
        CqlValueSet a_ = this.Follow_Up_for_Below_Normal_BMI(context);
        IEnumerable<PositiveInterventionOrder> b_ = context.Operators.Retrieve<PositiveInterventionOrder>(new RetrieveParameters(default, a_, default, "PositiveInterventionOrder"));
        CqlValueSet c_ = this.Referrals_Where_Weight_Assessment_May_Occur(context);
        IEnumerable<PositiveInterventionOrder> d_ = context.Operators.Retrieve<PositiveInterventionOrder>(new RetrieveParameters(default, c_, default, "PositiveInterventionOrder"));
        IEnumerable<PositiveInterventionOrder> e_ = context.Operators.Union<PositiveInterventionOrder>(b_, d_);
        CqlValueSet f_ = this.Medications_for_Below_Normal_BMI(context);
        IEnumerable<PositiveMedicationOrder> g_ = context.Operators.Retrieve<PositiveMedicationOrder>(new RetrieveParameters(default, f_, default, "PositiveMedicationOrder"));
        IEnumerable<object> h_ = context.Operators.Union<object>(e_ as IEnumerable<object>, g_ as IEnumerable<object>);
        bool? i_(object LowInterventionsOrdered)
        {
            CqlCode k_ = context.Operators.LateBoundProperty<CqlCode>(LowInterventionsOrdered, "reason");
            CqlValueSet l_ = this.Underweight(context);
            bool? m_ = context.Operators.CodeInValueSet(k_, l_);
            IEnumerable<Diagnosis> o_ = context.Operators.Retrieve<Diagnosis>(new RetrieveParameters(default, l_, default, default));
            bool? p_(Diagnosis UnderweightDiagnosis)
            {
                CqlInterval<CqlDateTime> t_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(UnderweightDiagnosis, "prevalencePeriod");
                CqlDateTime u_ = context.Operators.Start(t_);
                CqlDateTime v_ = context.Operators.LateBoundProperty<CqlDateTime>(LowInterventionsOrdered, "authorDatetime");
                bool? w_ = context.Operators.SameOrBefore(u_, v_, "day");
                CqlDateTime y_ = context.Operators.End(t_);
                bool? aa_ = context.Operators.Before(y_, v_, "day");
                bool? ab_ = context.Operators.Not(aa_);
                bool? ac_ = context.Operators.And(w_, ab_);

                return ac_;
            };
            IEnumerable<Diagnosis> q_ = context.Operators.Where<Diagnosis>(o_, p_);
            bool? r_ = context.Operators.Exists<Diagnosis>(q_);
            bool? s_ = context.Operators.Or(m_, r_);

            return s_;
        };
        IEnumerable<object> j_ = context.Operators.Where<object>(h_, i_);

        return j_;
    }


    [CqlExpressionDefinition("Low BMI Interventions Performed")]
    public IEnumerable<PositiveInterventionPerformed> Low_BMI_Interventions_Performed(CqlContext context)
    {
        CqlValueSet a_ = this.Follow_Up_for_Below_Normal_BMI(context);
        IEnumerable<PositiveInterventionPerformed> b_ = context.Operators.Retrieve<PositiveInterventionPerformed>(new RetrieveParameters(default, a_, default, "PositiveInterventionPerformed"));
        bool? c_(PositiveInterventionPerformed LowInterventionsPerformed)
        {
            CqlCode e_ = context.Operators.LateBoundProperty<CqlCode>(LowInterventionsPerformed, "reason");
            CqlValueSet f_ = this.Underweight(context);
            bool? g_ = context.Operators.CodeInValueSet(e_, f_);
            IEnumerable<Diagnosis> i_ = context.Operators.Retrieve<Diagnosis>(new RetrieveParameters(default, f_, default, default));
            bool? j_(Diagnosis UnderweightDiagnosis)
            {
                CqlInterval<CqlDateTime> n_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(UnderweightDiagnosis, "prevalencePeriod");
                CqlDateTime o_ = context.Operators.Start(n_);
                CqlDateTime p_ = context.Operators.LateBoundProperty<CqlDateTime>(LowInterventionsPerformed, "relevantDatetime");
                CqlInterval<CqlDateTime> q_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(LowInterventionsPerformed, "relevantPeriod");
                CqlInterval<CqlDateTime> r_ = CQMCommonQDM_9_0_000.Instance.NormalizeInterval(context, p_, q_);
                CqlDateTime s_ = context.Operators.Start(r_);
                bool? t_ = context.Operators.SameOrBefore(o_, s_, "day");
                CqlDateTime v_ = context.Operators.End(n_);
                CqlInterval<CqlDateTime> y_ = CQMCommonQDM_9_0_000.Instance.NormalizeInterval(context, p_, q_);
                CqlDateTime z_ = context.Operators.Start(y_);
                bool? aa_ = context.Operators.Before(v_, z_, "day");
                bool? ab_ = context.Operators.Not(aa_);
                bool? ac_ = context.Operators.And(t_, ab_);

                return ac_;
            };
            IEnumerable<Diagnosis> k_ = context.Operators.Where<Diagnosis>(i_, j_);
            bool? l_ = context.Operators.Exists<Diagnosis>(k_);
            bool? m_ = context.Operators.Or(g_, l_);

            return m_;
        };
        IEnumerable<PositiveInterventionPerformed> d_ = context.Operators.Where<PositiveInterventionPerformed>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("Low BMI And Follow Up Provided")]
    public IEnumerable<PositivePhysicalExamPerformed> Low_BMI_And_Follow_Up_Provided(CqlContext context)
    {
        IEnumerable<PositivePhysicalExamPerformed> a_ = this.Documented_Low_BMI_During_Measurement_Period(context);
        IEnumerable<PositivePhysicalExamPerformed> b_(PositivePhysicalExamPerformed LowBMI)
        {
            IEnumerable<object> d_ = this.Low_BMI_Interventions_Ordered(context);
            IEnumerable<PositiveInterventionPerformed> e_ = this.Low_BMI_Interventions_Performed(context);
            IEnumerable<object> f_ = context.Operators.Union<object>(d_ as IEnumerable<object>, e_ as IEnumerable<object>);
            bool? g_(object LowBMIInterventions)
            {
                CqlDateTime k_ = context.Operators.LateBoundProperty<CqlDateTime>(LowBMIInterventions, "relevantDatetime");
                CqlInterval<CqlDateTime> l_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(LowBMIInterventions, "relevantPeriod");
                CqlInterval<CqlDateTime> m_ = CQMCommonQDM_9_0_000.Instance.NormalizeInterval(context, k_, l_);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlDateTime o_ = context.Operators.LateBoundProperty<CqlDateTime>(LowBMIInterventions, "authorDatetime");
                CqlInterval<CqlDateTime> p_ = this.Measurement_Period(context);
                bool? q_ = context.Operators.In<CqlDateTime>(n_ ?? o_, p_, "day");

                return q_;
            };
            IEnumerable<object> h_ = context.Operators.Where<object>(f_, g_);
            PositivePhysicalExamPerformed i_(object LowBMIInterventions) =>
                LowBMI;
            IEnumerable<PositivePhysicalExamPerformed> j_ = context.Operators.Select<object, PositivePhysicalExamPerformed>(h_, i_);

            return j_;
        };
        IEnumerable<PositivePhysicalExamPerformed> c_ = context.Operators.SelectMany<PositivePhysicalExamPerformed, PositivePhysicalExamPerformed>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<PositivePhysicalExamPerformed> a_ = this.High_BMI_And_Follow_Up_Provided(context);
        bool? b_ = context.Operators.Exists<PositivePhysicalExamPerformed>(a_);
        IEnumerable<PositivePhysicalExamPerformed> c_ = this.Low_BMI_And_Follow_Up_Provided(context);
        bool? d_ = context.Operators.Exists<PositivePhysicalExamPerformed>(c_);
        bool? e_ = context.Operators.Or(b_, d_);
        bool? f_ = this.Has_Normal_BMI(context);
        bool? g_ = context.Operators.Or(e_, f_);

        return g_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<PatientCharacteristicEthnicity> SDE_Ethnicity(CqlContext context)
    {
        CqlValueSet a_ = this.Ethnicity(context);
        IEnumerable<PatientCharacteristicEthnicity> b_ = context.Operators.Retrieve<PatientCharacteristicEthnicity>(new RetrieveParameters(default, a_, default, default));

        return b_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<PatientCharacteristicPayer> SDE_Payer(CqlContext context)
    {
        CqlValueSet a_ = this.Payer_Type(context);
        IEnumerable<PatientCharacteristicPayer> b_ = context.Operators.Retrieve<PatientCharacteristicPayer>(new RetrieveParameters(default, a_, default, default));

        return b_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<PatientCharacteristicRace> SDE_Race(CqlContext context)
    {
        CqlValueSet a_ = this.Race(context);
        IEnumerable<PatientCharacteristicRace> b_ = context.Operators.Retrieve<PatientCharacteristicRace>(new RetrieveParameters(default, a_, default, default));

        return b_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public IEnumerable<PatientCharacteristicSex> SDE_Sex(CqlContext context)
    {
        CqlValueSet a_ = this.Federal_Administrative_Sex(context);
        IEnumerable<PatientCharacteristicSex> b_ = context.Operators.Retrieve<PatientCharacteristicSex>(new RetrieveParameters(default, a_, default, default));

        return b_;
    }


    #endregion Functions and Expressions

}
